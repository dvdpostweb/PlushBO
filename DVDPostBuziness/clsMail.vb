Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class clsMail

    Public Const STRPARAMSMTPSERVER As String = "SMTPServer"
    Public Const PARAMSMTPSERVER As Integer = 4
    Private Shared _dtParams As DataTable
    Private Shared _drSite As DataRow
    Public Const MAIL_FROM As String = "info@plush.be"
    Public Const MAIL_TEST As String = "im@dvdpost.be"
    Public Const MAIL_NAME As String = "Plush"
    Private Const CountryLux As Integer = 150
    Private Const CountryNL As Integer = 124
    Private Const NbPointDefault As Integer = 200
    Private Const NBPRODUCTSIMAGE As Integer = 7
    Private Const NBACTORS As Integer = 3

    Private Const BaliseMail As String = "$"
    Private Const ReplaceRegEx As String = "\" & BaliseMail
    Private Const cptRepeat As Integer = 3
    Private Const SeparateKeyValue As String = ":::"
    Private Const SeparateVariable As String = ";;;"

    Private Const VariableGeneric As String = "content"

    Public Enum MailCategory
        STOABO = 1
        PARRAINAGE = 2
        MONCOMPTE = 3
        ABO = 4
        ENVOI = 5
        PAIEMENT = 6
    End Enum
    Public Enum Mail
        MAIL_CUST_SERV = 6
        'MAIL_DVDHOME = 14 ' not used
        'MAIL_STOP = 52
        'MAIL_RECOVERY = 449
        'MAIL2_RECOVERY = 450
        'MAIL_IN = 566 ' 99
        'MAIL_OUT = 567 ' 100
        'MAIL_VOD = 565
        'MAIL_WISHLIST = 103 ' not used
        'MAIL_DVD_INDISPONIBLE = 570 ' not used 
        'MAIL_ACTIVATIONDOM = 415 ' not used
        'MAIL_RECEIVEDDOM = 424 ' not used 
        'MAIL_SON_PAID = 447
        'MAIL_SON_ACTIVATION = 448
        'MAIL_PAYMENT_INVALID_OGONE = 584 '438
        'MAIL_PAYMENT_INVALID_OGONE_OLD = 438
        ''Mail_ENDPERIODESSAI = 249 ' not used
        ''MAIL_VOD_CONFIRMATION = 571
        'MAIL_DVDABOSTOP = 573
        'MAIL_DVDABOSTOPBACKLOG = 575
        MAIL_REPLY_MESSAGERIE = 578
        'MAIL_REPLY = 579
        'MAIL_REGISTRATION = 600
        MAIL_PLUSH_PAYMENT_NOT_RECEIVED = 602
        MAIL2_PLUSH_PAYMENT_NOT_RECEIVED = 603
        MAIL_PLUSH_PAYMENT_NOT_RECEIVED_CREATE_RECOVERY = 604
        MAIL_PLUSH_REPLY = 605

    End Enum
    Public Shared Function CreateVariableGeneric(ByVal str As String) As String
        Return Getbalise() & VariableGeneric & Getbalise() & SeparateKeyValue & str & SeparateVariable
    End Function

    Private Shared Sub LoadSite()
        If _drSite IsNot Nothing Then Return
        Dim sql As String
        sql = PlushData.PaymentOfflineData.GetSite()
        Dim dt As New DataTable()
        dt = PlushData.clsConnection.FillDataSet(sql)
        _drSite = dt.Rows(0)
    End Sub

    Private Shared Sub loadParams()
        If _dtParams IsNot Nothing Then Return
        Dim sql As String
        sql = PlushData.PaymentOfflineData.GetParametersGlobal()
        _dtParams = New DataTable()
        _dtParams = PlushData.clsConnection.FillDataSet(sql)
    End Sub

    Private Shared Function getcategorie(ByVal mail_id As Mail) As Integer

        Select Case mail_id

            'Case Mail.MAIL_CUST_SERV, Mail.MAIL_REGISTRATION
            '    Return MailCategory.MONCOMPTE
            'Case Mail.MAIL_DVDABOSTOP, Mail.MAIL_DVDABOSTOPBACKLOG, Mail.MAIL_STOP
            '    Return MailCategory.STOABO
            'Case Mail.MAIL_IN, Mail.MAIL_OUT, Mail.MAIL_VOD_CONFIRMATION
            '    Return MailCategory.ENVOI
            'Case Mail.MAIL_PAYMENT_INVALID_OGONE, Mail.MAIL_RECOVERY, Mail.MAIL2_RECOVERY
            '    Return MailCategory.Paiement
            'Case Mail.MAIL_SON_ACTIVATION, Mail.MAIL_SON_PAID
            '    Return MailCategory.PARRAINAGE
            Case Mail.MAIL_PLUSH_PAYMENT_NOT_RECEIVED, Mail.MAIL2_PLUSH_PAYMENT_NOT_RECEIVED, Mail.MAIL_PLUSH_PAYMENT_NOT_RECEIVED_CREATE_RECOVERY
                Return MailCategory.PAIEMENT

            Case Else
                Return 0
        End Select



    End Function
    Private Shared Function SendObject(ByVal mail_id As Mail, ByVal lstvariables As String, ByVal customers_lang As Integer, ByVal rowcustomers As DataRow, ByVal subject As String, Optional ByVal emailTest As String = "", Optional ByVal emailFrom As String = "", Optional ByVal emailName As String = "") As Integer
        Dim sql As String
        sql = PlushData.PaymentOfflineData.GetMail(mail_id, customers_lang)
        Dim dtMail As New DataTable()
        Dim result As Integer

        dtMail = PlushData.clsConnection.FillDataSet(sql)
        Dim mymail As Net.Mail.MailMessage
        If dtMail.Rows.Count > 0 Then
            Dim RowMail As DataRow = dtMail.Rows(0)
            Try
                PlushData.clsConnection.CreateTransaction(True)
                Dim msg As String = ""
                Dim strsubject As String = ""
                Dim IdHistoryMail As Integer = PlushData.clsConnection.ExecuteScalar(PlushData.PaymentOfflineData.getMaxidMailHistory())
                IdHistoryMail += 1
                replaceParamCommun(rowcustomers, RowMail, IdHistoryMail, strsubject, msg, lstvariables)
                msg = replacevariableInMsg(msg, lstvariables)
                mymail = CreateMail(rowcustomers("email"), msg, subject)

                If mymail IsNot Nothing Then
                    If isSendMail(RowMail, rowcustomers) Then
                        SendMail(mymail)
                        sql = PlushData.PaymentOfflineData.SaveMailHistory(rowcustomers("Customers_id"), mail_id, customers_lang, mymail.To(0).Address, lstvariables)
                        result = PlushData.clsConnection.ExecuteNonQuery(sql)
                        ' clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Email, DvdPostData.clsConnection.bulkQuery & " " & result & " " & sql)
                        Dim cpt_result As Integer = 0
                        PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Email, cpt_result)
                        Return IdHistoryMail
                    Else
                        Return -1
                    End If

                Else
                    Dim msgerror As String

                    msgerror = "Error mail id : " & mail_id & " lang : " & customers_lang
                    clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Email, msgerror)
                    PlushData.clsConnection.CancelBulkQuery()
                    Return -1
                    'clsMsgError.MsgBox(msgerror)
                End If

            Catch ex As Exception
                Dim msgerror As String
                PlushData.clsConnection.CancelBulkQuery()
                msgerror = "Error mail id : " & mail_id & " lang : " & customers_lang & " " & ex.Message
                clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Email, msgerror)
                Return -1
                'Throw ex
            End Try

        End If
        Return -1
    End Function
    Private Shared Function isSendMail(ByVal RowMail As DataRow, ByVal RowCustomer As DataRow) As Boolean
        Dim isMailCopy As Boolean
        Dim sql As String
        sql = PlushData.ClsCustomersData.GetSelectIsMailCopy(RowCustomer("Customers_id"))
        isMailCopy = PlushData.clsConnection.ExecuteScalar(sql)
        Return RowMail("force_copy") = 1 Or isMailCopy

    End Function
    Private Shared Function SendObject(ByVal mail_id As Mail, ByVal customers_lang As Integer, ByVal rowcustomers As DataRow, Optional ByVal saveMessagerie As Boolean = True, Optional ByVal emailTest As String = "", Optional ByVal emailFrom As String = "", Optional ByVal emailName As String = "") As Boolean
        Dim sql As String
        sql = PlushData.PaymentOfflineData.GetMail(mail_id, customers_lang)

        Dim dtMail As New DataTable()
        Dim result As Integer
        Dim lstvariable As String = String.Empty

        dtMail = PlushData.clsConnection.FillDataSet(sql)
        Dim mymail As Net.Mail.MailMessage
        If dtMail.Rows.Count > 0 Then
            Dim RowMail As DataRow = dtMail.Rows(0)
            Try
                PlushData.clsConnection.CreateTransaction(True)
                mymail = FormatMail(RowMail, rowcustomers, customers_lang, lstvariable, emailTest, emailFrom, emailName)

                If mymail IsNot Nothing Then
                    If isSendMail(RowMail, rowcustomers) Then
                        SendMail(mymail)
                        sql = PlushData.PaymentOfflineData.SaveMailHistory(rowcustomers("Customers_id"), mail_id, customers_lang, mymail.To(0).Address, lstvariable)
                        result = PlushData.clsConnection.ExecuteNonQuery(sql)
                        ' clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Email, DvdPostData.clsConnection.bulkQuery & " " & result & " " & sql)
                        Dim cpt_result As Integer = 0

                        PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Email, cpt_result)
                    Else
                        PlushData.clsConnection.CancelBulkQuery()
                    End If
                    If saveMessagerie Then
                        Dim categorie As Integer
                        Dim IdHistoryMail As Integer
                        categorie = getcategorie(mail_id)
                        IdHistoryMail = PlushData.clsConnection.ExecuteScalar(PlushData.PaymentOfflineData.getMaxidMailHistory())
                        PlushBuziness.clsMessagerie.GetCreateFullMessage(rowcustomers("Customers_id"), Nothing, categorie, mail_id, lstvariable, IdHistoryMail)
                    End If
                    Return True
                Else
                    Dim msgerror As String

                    msgerror = "Error mail id : " & mail_id & " lang : " & customers_lang
                    clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Email, msgerror)
                    PlushData.clsConnection.CancelBulkQuery()
                    Return False
                    'clsMsgError.MsgBox(msgerror)
                End If

            Catch ex As Exception
                Dim msgerror As String
                PlushData.clsConnection.CancelBulkQuery()
                msgerror = "Error mail id : " & mail_id & " lang : " & customers_lang & " " & ex.Message & " email: " & rowcustomers("email")
                clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Email, msgerror)
                Return False
                'Throw ex
            End Try

        End If
        Return False
    End Function
    Public Shared Function SendMail(ByVal customers_id As Integer, ByVal mail_id As Integer, ByVal lstvariables As String, ByVal subject As String) As Integer
        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.ClsCustomersData.GetSelectCustomerDetail(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sql)
        If dt.Rows.Count = 0 Then
            Return False
        Else
            Return SendObject(mail_id, lstvariables, dt.Rows(0)("customers_language"), dt.Rows(0), subject)
        End If
    End Function

    Public Shared Function SendMail(ByVal rowCustomers As DataRow, ByVal mail_id As Mail, Optional ByVal saveMessagerie As Boolean = True, Optional ByVal emailTest As String = "", Optional ByVal emailFrom As String = "", Optional ByVal emailName As String = "") As Boolean
        Return SendObject(mail_id, rowCustomers("customers_language"), rowCustomers, saveMessagerie, emailTest, emailFrom, emailName)
    End Function
    Public Shared Function SendMail(ByVal MsgMail As String, ByVal Subject As String, ByVal MailTo As String, Optional ByVal emailFrom As String = "", Optional ByVal emailName As String = "") As Boolean
        Dim strFrom As String
        Dim strName As String
        If MsgMail.Length = 0 Then
            Return False
        Else
            If PlushData.clsSession.isEnvTest Then
                MailTo = MAIL_TEST
            End If

            If emailFrom = "" Then
                strFrom = MAIL_FROM
            Else
                strFrom = emailFrom
            End If

            If emailName = "" Then
                strName = MAIL_NAME
            Else
                strName = emailName
            End If
            Dim mymail As Net.Mail.MailMessage
            mymail = New Net.Mail.MailMessage(strFrom, MailTo)
            mymail.From = New Net.Mail.MailAddress(strFrom, strName)
            mymail.Subject = Subject
            mymail.IsBodyHtml = True
            mymail.Body = MsgMail
            SendMail(mymail)

        End If

    End Function
    Public Shared Function SendMail(ByVal customers_id As Integer, ByVal mail_id As Integer, Optional ByVal saveMessagerie As Boolean = True, Optional ByVal emailTest As String = "", Optional ByVal emailFrom As String = "", Optional ByVal emailName As String = "") As Boolean
        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.ClsCustomersData.GetSelectCustomerDetail(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sql)
        If dt.Rows.Count = 0 Then
            Return False
        Else
            Return SendMail(dt.Rows(0), mail_id, saveMessagerie, emailTest, emailFrom, emailName)
        End If

    End Function
    Public Shared Sub sendMail(ByVal mymail As Net.Mail.MailMessage)
        '.Find(New String() {"Global", "SMTPServer"})
        If _dtParams Is Nothing Then
            loadParams()
        End If

        Dim dr As DataRow = _dtParams.Rows(PARAMSMTPSERVER)
        If dr("Name") = STRPARAMSMTPSERVER Then


            Dim SmtpMail As New Net.Mail.SmtpClient(dr("ParamValue"))
            'SmtpMail.Credentials = New System.Net.NetworkCredential("Administrator", "DVD8(post")
            SmtpMail.Credentials = New System.Net.NetworkCredential("info@plush.be", "fireball18")
            SmtpMail.Port = 1025
            Try
                SmtpMail.Send(mymail)

                'End Try

            Catch ex As SmtpFailedRecipientsException
                clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Email, ex)
                For i As Integer = 0 To ex.InnerExceptions.Length

                    Dim status As SmtpStatusCode = ex.InnerExceptions(i).StatusCode
                    If status = SmtpStatusCode.MailboxBusy Or status = SmtpStatusCode.MailboxUnavailable Then

                        System.Threading.Thread.Sleep(5000)
                        SmtpMail.Send(mymail)

                    Else

                        clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Email, ex)
                    End If

                Next
            Catch ex As Exception
                While (ex.InnerException IsNot Nothing)
                    ex = ex.InnerException
                    clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Email, ex)
                End While
                clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Email, ex)

                Threading.Thread.Sleep(1000)

            End Try

        End If

    End Sub

    '#Region "vodx"
    '    ' insert in the table vodx
    '    Private Shared Sub insertVodx(ByVal customers_id As Integer, ByVal uniqid As String)
    '        Dim sql_insert As String
    '        sql_insert = DvdPostData.clsMassEmail.insertActionKeys(customers_id, uniqid)
    '        DvdPostData.clsConnection.ExecuteNonQuery(sql_insert)
    '    End Sub
    '    ' generate a unique code
    '    Private Shared Function uniqueId() As String
    '        Dim leGuid As Guid = Guid.NewGuid()
    '        Return leGuid.ToString()
    '    End Function

    '    Private Shared Sub replaceVodx(ByVal CustRow As DataRow, ByVal lang As Integer, ByRef strmessage As String)

    '        If IsExistInString(strmessage, "$$$uniq_key$$$") Then
    '            Dim key As String
    '            Dim linkUnidKey As String
    '            key = uniqueId()
    '            insertVodx(CustRow("customers_id"), key)

    '            'choose country
    '            If CustRow("entry_country_id") = CountryLux Then
    '                linkUnidKey = "http://www.dvdpost.be/actions.php?uniq_id=" + key 'site belge car pas encore de site pour le luxembourg

    '            ElseIf CustRow("entry_country_id") = CountryNL Then
    '                linkUnidKey = "http://www.dvdpost.nl/actions.php?uniq_id=" + key
    '            Else 'belgium
    '                linkUnidKey = "http://www.dvdpost.be/actions.php?uniq_id=" + key
    '                If lang = DvdPostData.ClsCustomersData.Language.FR Then
    '                    linkUnidKey = linkUnidKey + "&language=fr" + "&email=" + CustRow("customers_email_address").ToString
    '                End If

    '                If lang = DvdPostData.ClsCustomersData.Language.NL Then
    '                    linkUnidKey = linkUnidKey + "&language=nl" + "&email=" + CustRow("customers_email_address").ToString
    '                End If

    '                If lang = DvdPostData.ClsCustomersData.Language.EN Then
    '                    linkUnidKey = linkUnidKey + "&language=en" + "&email=" + CustRow("customers_email_address").ToString
    '                End If


    '            End If
    '            strmessage = Replace(strmessage, "$$$uniq_key$$$", linkUnidKey)
    '        End If
    '    End Sub
    '#End Region



    'Private Shared Sub replaceActivation(ByVal CustRow As DataRow, ByRef strmessage As String)

    '    If IsExistInString(strmessage, "$$$activation_code$$$") _
    '       Or IsExistInString(strmessage, "$$$code$$$") And CustRow.Table.Columns.Contains("code") Then
    '        Try
    '            strmessage = Replace(strmessage, "$$$activation_code$$$", CustRow("code"))
    '            strmessage = Replace(strmessage, "$$$code$$$", CustRow("code"))
    '        Catch ex As Exception
    '            clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Email, ex)
    '        End Try
    '    End If
    'End Sub
    'Private Shared Sub replaceLastOrder(ByVal CustRow As DataRow, ByRef strmessage As String)
    '    If IsExistInString(strmessage, "$$$date_last_order$$$") Then 'And CustRow.Table.Columns.Contains("Products_titles") Then
    '        Try
    '            strmessage = Replace(strmessage, "$$$date_last_order$$$", CustRow("date_last_order"))
    '        Catch ex As Exception
    '            clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Email, ex)
    '        End Try

    '    End If
    'End Sub
    Public Shared Function replacevariableInMsg(ByVal msg As String, ByVal lstvariable As String) As String

        Dim keyvariables As String()
        Dim lstkeyValue As String()
        keyvariables = lstvariable.Split(New String() {SeparateVariable}, StringSplitOptions.RemoveEmptyEntries)


        For Each Item As String In keyvariables
            lstkeyValue = Item.Split(New String() {SeparateKeyValue}, StringSplitOptions.RemoveEmptyEntries)
            If lstkeyValue.Length > 1 Then
                If lstkeyValue(0).Contains(BaliseMail) Then
                    msg = msg.Replace(lstkeyValue(0), lstkeyValue(1))
                Else
                    Dim balise As String = Getbalise()
                    msg = msg.Replace(balise & lstkeyValue(0) & balise, lstkeyValue(1))
                End If
            Else
                msg = msg.Replace(lstkeyValue(0), "")
            End If
        Next

        Return msg

    End Function
    Private Shared Function ReplaceVar(ByVal msg As String, ByVal key As String, ByVal val As String, ByRef lstvariable As String, Optional ByVal novalue As Boolean = False) As String
        Dim old_msg As String
        old_msg = msg
        msg = Replace(msg, key, val)
        If old_msg <> msg Then
            ' avoid flag read in back office when the mail open 
            If novalue Then
                val = "0"
            End If
            lstvariable = lstvariable & key & SeparateKeyValue & val.Replace("'", "''") & SeparateVariable
        End If
        Return msg
    End Function
    Private Shared Sub replaceParamCommun(ByVal CustRow As DataRow, _
                                 ByVal MailRow As DataRow, _
                                 ByVal mailHistoryId As Integer, _
                                 ByRef strSubject As String, _
                                 ByRef strmessage As String, _
                                 ByRef lstvariable As String)

        Dim site As String
        Dim logo As String

        LoadSite()
        loadParams()
        Dim balise As String = Getbalise()
        site = _drSite("site_link")
        logo = _drSite("logo")


        strSubject = MailRow("messages_subject")
        strmessage = MailRow("messages_html")
        ' IsExistInString(strmessage, "$$$customers_name$$$") And
        ' If CustRow.Table.Columns.Contains("customers_firstname") Then


        '  Dim firstname As String = PlushTools.ClsString.Capitalize(CustRow("customers_firstname").ToString())
        '  Dim lastname As String = PlushTools.ClsString.Capitalize(CustRow("customers_lastname").ToString())


        'titre

        strmessage = ReplaceVar(strmessage, balise & "title" & balise, MailRow("messages_title"), lstvariable)

        'customers_name
        'strmessage = Replace(strmessage, "$$$name$$$", firstname & " " & lastname)
        'strmessage = Replace(strmessage, "$$$customers_name$$$", firstname & " " & lastname)
        'strmessage = Replace(strmessage, "$$$customers_email$$$", CustRow("email"))
        'strmessage = Replace(strmessage, "$$$email$$$", CustRow("email"))
        ''site & Logo
        strmessage = ReplaceVar(strmessage, balise & "site" & balise, "<a href='" & site & " '>" & site & "</a>", lstvariable)
        strmessage = ReplaceVar(strmessage, balise & "site_link" & balise, site, lstvariable)
        'strmessage = Replace(strmessage, "$$$site_image$$$", "<a href='" & site & " '>")
        'strmessage = Replace(strmessage, "$$$logo_dvdpost$$$", "<a href='" & site & " '> <img src='" & logo & "' border='0'> </a>")
        ''today
        'strmessage = Replace(strmessage, "$$$today$$$", Today())
        ''Abo Creation Date
        'strmessage = Replace(strmessage, "$$$abo_creation_date$$$", CustRow("customers_info_date_account_created"))
        ''mailid 
        strmessage = ReplaceVar(strmessage, balise & "mail_id" & balise, mailHistoryId, lstvariable)
        strmessage = ReplaceVar(strmessage, balise & "mail_messages_sent_history_id" & balise, mailHistoryId + 1, lstvariable, True)
        ''customers_id
        'strmessage = Replace(strmessage, "$$$customers_id$$$", CustRow("customers_id"))

        'strmessage = Replace(strmessage, "$$$dvdathome$$$", CustRow("customers_abo_dvd_home_norm") + CustRow("customers_abo_dvd_home_adult"))
        ''customers_abo_validityto
        'strmessage = Replace(strmessage, "$$$next_reconduction_date$$$", CustRow("customers_abo_validityto") & "")
        '   End If

    End Sub
    Private Shared Sub replacePaymentOffline(ByVal CustRow As DataRow, ByRef strmessage As String)
        If IsExistInString(strmessage, "$$$payment_offline_communication$$$") And CustRow.Table.Columns.Contains("communication") Then
            strmessage = Replace(strmessage, "$$$payment_offline_communication$$$", CustRow("communication") & "")
            strmessage = Replace(strmessage, "$$$payment_offline_amount$$$", CustRow("amount") & "")
            strmessage = Replace(strmessage, "$$$payment_offline_reason_date$$$", CustRow("date_reconduction") & "")
        End If
    End Sub
    'Private Shared Sub replaceProductPicture(ByVal CustRow As DataRow, ByRef strmessage As String)
    '    If IsExistInString(strmessage, "$$$products_image$$$") And CustRow.Table.Columns.Contains("products_image_big") Then
    '        strmessage = Replace(strmessage, "$$$products_image$$$", CustRow("products_image_big"))
    '        strmessage = Replace(strmessage, "$$$products_name$$$", CustRow("products_name"))
    '        strmessage = Replace(strmessage, "$$$products_id$$$", CustRow("Products_id"))
    '    End If
    'End Sub

    'Private Shared Sub replaceProduct(ByVal CustRow As DataRow, ByRef strmessage As String)
    '    If IsExistInString(strmessage, "$$$products_name$$$") And CustRow.Table.Columns.Contains("Products_titles") Then
    '        strmessage = Replace(strmessage, "$$$products_name$$$", CustRow("Products_titles"))
    '    End If
    'End Sub
    'Private Shared Sub replacePromoCode(ByVal CustRow As DataRow, ByRef strmessage As String)
    '    If InStr(strmessage, "$$$promo_code$$$", CompareMethod.Text) <> 0 Then

    '        Dim sql As String
    '        Dim dt As DataTable
    '        Dim promocode As String = ""
    '        If CustRow("activation_discount_code_type") = "D" Then
    '            sql = DvdPostData.ClsCustomersData.GetSelectActivationCode(CustRow("activation_discount_code_id"))
    '            dt = DvdPostData.clsConnection.FillDataSet(sql)
    '            If dt.Rows.Count > 0 Then
    '                promocode = dt.Rows(0)("activation_code")
    '            End If
    '        Else
    '            sql = DvdPostData.ClsCustomersData.GetSelectDiscountCode(CustRow("activation_discount_code_id"))
    '            dt = DvdPostData.clsConnection.FillDataSet(sql)
    '            If dt.Rows.Count > 0 Then
    '                promocode = dt.Rows(0)("discount_code")
    '            End If
    '        End If
    '        strmessage = Replace(strmessage, "$$$promo_code$$$", promocode)
    '    End If
    'End Sub

    'Private Shared Sub replaceAbo(ByVal CustRow As DataRow, ByVal lang As Integer, ByRef strmessage As String)

    '    If InStr(strmessage, "$$$next_abo_price$$$", CompareMethod.Text) <> 0 And CustRow.Table.Columns.Contains("customers_next_abo_type") Then
    '        Dim sql As String
    '        Dim dt As DataTable
    '        Dim dr As DataRow
    '        sql = DvdPostData.ClsCustomersData.GetSelectDetailsProducts(CustRow("customers_next_abo_type"), lang)
    '        dt = DvdPostData.clsConnection.FillDataSet(sql)
    '        If dt.Rows.Count = 1 Then
    '            dr = dt.Rows(0)

    '            'strmessage = Replace(strmessage, "$$$actual_abo_name$$$", dr(""))
    '            'strmessage = Replace(strmessage, "$$$actual_abo_price$$$", dr(""))
    '            'strmessage = Replace(strmessage, "$$$next_abo_name$$$", dr(""))
    '            strmessage = Replace(strmessage, "$$$next_abo_price$$$", dr("products_price"))
    '            strmessage = Replace(strmessage, "$$$next_abo_dvd_credit$$$", dr("qty_credit"))
    '            'strmessage = Replace(strmessage, "$$$next_abo_dvd_at_home$$$", dr(""))
    '        End If
    '        'endif
    '    End If
    'End Sub
    Private Shared Function Getbalise() As String
        Dim balise As String = New String(BaliseMail, cptRepeat)
        Return balise
    End Function
    Private Shared Function SearchVariableMail(ByVal strmsg As String) As Dictionary(Of String, String)
        Dim pattern As String = "((" & ReplaceRegEx & "){" & cptRepeat & "}\w+(" & ReplaceRegEx & "){" & cptRepeat & "})"
        Dim dico_replace As New Dictionary(Of String, String)
        Dim exp As New Regex(pattern)
        Dim key As String
        Dim val As String
        Dim balise As String = Getbalise()
        For Each Item As Match In Regex.Matches(strmsg, pattern)
            key = Item.Value
            val = Item.Value.Replace(balise, "")
            If Not dico_replace.ContainsKey(key) Then
                dico_replace.Add(key, val)
            End If
        Next

        Return dico_replace
    End Function

    Private Shared Function ReplaceData(ByVal strmsg As String, ByVal dico_replace As Dictionary(Of String, String), ByVal rowcustomers As DataRow, ByRef lstVariable As String) As String
        Dim str As String

        str = strmsg
        Dim val As String
        For Each kvp As KeyValuePair(Of String, String) In dico_replace
            If rowcustomers.Table.Columns.Contains(kvp.Value) Then
                If rowcustomers(kvp.Value) Is DBNull.Value Then
                    val = String.Empty
                Else
                    val = rowcustomers(kvp.Value)
                End If
                lstVariable = lstVariable & kvp.Key & SeparateKeyValue & val.Replace("'", "''") & SeparateVariable
                str = str.Replace(kvp.Key, val)
            End If
        Next
        Return str
    End Function
    Private Shared Function CreateMail(ByVal email As String, ByVal htmlMsg As String, ByVal subject As String, Optional ByVal eMailTest As String = "", Optional ByVal emailFrom As String = "", Optional ByVal emailName As String = "") As Net.Mail.MailMessage
        Dim strTo As String
        Dim strFrom As String
        Dim strName As String

        If eMailTest = "" Then
            strTo = email
        Else
            strTo = eMailTest
        End If

        If emailFrom = "" Then
            strFrom = MAIL_FROM
        Else
            strFrom = emailFrom
        End If

        If emailName = "" Then
            strName = MAIL_NAME
        Else
            strName = emailName
        End If

        If PlushData.clsSession.isEnvTest Then
            strTo = MAIL_TEST
        End If
        ' david debug 
        'strTo = "dvb@dvdpost.be"
        ''titre
        Dim mymail As Net.Mail.MailMessage
        Dim balise As String = New String(BaliseMail, cptRepeat)
        If Not htmlMsg.Contains(balise) Then
            mymail = New Net.Mail.MailMessage(strFrom, strTo)
            mymail.From = New Net.Mail.MailAddress(strFrom, strName)
            mymail.Subject = subject
            mymail.IsBodyHtml = True
            mymail.Body = htmlMsg
        Else
            Throw New Exception("Mail have parameters with $$$ ")
        End If


        Return mymail
    End Function

    Private Shared Function FormatMail(ByVal RowMail As DataRow, _
                                      ByVal rowcustomers As DataRow, _
                                      ByVal customers_language As Integer, _
                                      ByRef lstvariable As String, _
                                      Optional ByVal eMailTest As String = "", Optional ByVal emailFrom As String = "", Optional ByVal emailName As String = "") As Net.Mail.MailMessage


        Dim strSubject As String = ""
        Dim strMessage As String = ""
        Dim IdHistoryMail As Integer

        IdHistoryMail = PlushData.clsConnection.ExecuteScalar(PlushData.PaymentOfflineData.getMaxidMailHistory())



        replaceParamCommun(rowcustomers, RowMail, IdHistoryMail, strSubject, strMessage, lstvariable)

        Dim dico_replace As Dictionary(Of String, String)

        dico_replace = SearchVariableMail(strMessage)

        strMessage = ReplaceData(strMessage, dico_replace, rowcustomers, lstvariable)

        'replaceActivation(rowcustomers, strMessage)
        'replaceLastOrder(rowcustomers, strMessage)
        'replaceMemGetMem(rowcustomers, customers_language, strMessage)
        'replaceVodx(rowcustomers, customers_language, strMessage)
        'replaceProduct(rowcustomers, strMessage)
        replacePaymentOffline(rowcustomers, strMessage)
        'replaceAbo(rowcustomers, customers_language, strMessage)
        ReplacePictureDVD(rowcustomers, customers_language, strMessage, lstvariable)
        'replacePromoCode(rowcustomers, strMessage)
        'replaceMailSponsor(rowcustomers, strMessage, strSubject)
        ReplaceGender(rowcustomers, customers_language, strMessage, lstvariable)
        ReplaceActors(rowcustomers, strMessage, lstvariable)
        ReplaceInvoiceOpen(rowcustomers, strMessage, lstvariable)
        ReplaceIN_OUT(rowcustomers, RowMail, strMessage, lstvariable)
        ReplaceINDISPONIBLE(rowcustomers, RowMail, strMessage, lstvariable)
        'replaceProductPicture(rowcustomers, strMessage)
        Return CreateMail(rowcustomers("email"), strMessage, strSubject, eMailTest, emailFrom, emailName)

    End Function

    Private Shared Sub ReplaceGender(ByVal CustRow As DataRow, ByVal customers_language As Integer, ByRef strMessage As String, ByRef lstvariable As String)
        Dim balise As String = Getbalise()
        Dim result As String
        If IsExistInString(strMessage, balise & "gender_simple" & balise) Then
            result = getGender(CustRow("customers_gender"), customers_language)
            strMessage = ReplaceVar(strMessage, balise & "gender_simple" & balise, result, lstvariable)
        End If

    End Sub


#Region "member get member"
    'Private Shared Function loadCmbCadeaux() As DataTable

    '    Dim sql As String
    '    Dim dt As DataTable
    '    sql = DvdPostData.clsMassEmail.getMemGetMemGift
    '    dt = DvdPostData.clsConnection.FillDataSet(sql)
    '    Return dt
    'End Function

    Private Shared Function IsExistInString(ByVal str As String, ByVal strsearch As String) As Boolean
        Return InStr(str, strsearch, CompareMethod.Text) <> 0
    End Function




    'Private Shared Sub replaceMailSponsor(ByVal CustRow As DataRow, ByRef strmessage As String, ByRef strSubject As String)
    '    Dim balise As String = Getbalise()

    '    If IsExistInString(strmessage, balise & "godfather_name" & balise) Then 'And CustRow.Table.Columns.Contains("godson_mgm_point") Then
    '        Dim sponsorLastName As String
    '        Dim sponsorFirstName As String
    '        Dim godSonLastName As String
    '        Dim godSonFirstName As String

    '        'strSubject = MailRow("subject")
    '        godSonLastName = PlushTools.ClsString.Capitalize(CustRow("godson_lastname"))
    '        godSonFirstName = PlushTools.ClsString.Capitalize(CustRow("godson_firstname"))
    '        sponsorLastName = PlushTools.ClsString.Capitalize(CustRow("sponsor_lastname"))
    '        sponsorFirstName = PlushTools.ClsString.Capitalize(CustRow("sponsor_firstname"))

    '        strSubject = Replace(strSubject, balise & "godfather_name" & balise, godSonFirstName & " " & godSonFirstName)

    '        strmessage = Replace(strmessage, balise & "godfather_name" & balise, sponsorFirstName & " " & sponsorLastName)
    '        strmessage = Replace(strmessage, balise & "godfather_point" & balise, CustRow("sponsor_mgm_points"))

    '        strmessage = Replace(strmessage, balise & "son_name" & balise, godSonFirstName & " " & godSonLastName)
    '        'strmessage = Replace(strmessage, "$$$customers_points$$$", CustRow("godson_mgm_point"))
    '    End If
    'End Sub



    'Private Shared Sub replaceMemGetMem(ByVal CustRow As DataRow, ByVal lang As Integer, ByRef strmessage As String)
    '    Dim balise As String = Getbalise()

    '    If IsExistInString(strmessage, balise & "nbr_point" & balise) And CustRow.Table.Columns.Contains("mgm_points") Then
    '        Dim dtcadeau As DataTable
    '        dtcadeau = loadCmbCadeaux()
    '        Dim id As Integer = returnIdCadeaux(CustRow("mgm_points"), dtcadeau)
    '        Dim nbrPoint As Integer = calculPoint(CustRow("mgm_points"), id, dtcadeau)
    '        Dim nrbAmis As Integer = calculNbrAmis(nbrPoint)
    '        Dim nameCadeaux As String = giveNameCadeaux(id, lang, dtcadeau)
    '        strmessage = Replace(strmessage, balise & "nbr_point" & balise, nbrPoint)
    '        strmessage = Replace(strmessage, balise & "nbr_amis" & balise, nrbAmis)
    '        strmessage = Replace(strmessage, balise & "name_cadeaux" & balise, nameCadeaux)
    '    End If
    'End Sub

    'Private Shared Function calculNbrAmis(ByVal pointToReceive As Integer) As Integer
    '    Dim nbrAmisDouble As Double
    '    Dim nbramisInt As Integer
    '    nbrAmisDouble = pointToReceive
    '    nbrAmisDouble = nbrAmisDouble / NbPointDefault
    '    nbramisInt = Math.Round(nbrAmisDouble, 0)

    '    Return nbramisInt
    'End Function



    'Private Shared Function calculPoint(ByVal mgmPoint As Integer, ByVal id As Integer, ByVal dtCadeau As DataTable) As Integer
    '    Dim row As DataRow
    '    Dim pointToReceive As Integer
    '    Dim idCadeaux As Integer


    '    For Each row In dtCadeau.Rows
    '        If id = row("id") Then
    '            pointToReceive = row("points")
    '            pointToReceive = pointToReceive - mgmPoint
    '            idCadeaux = row("id")
    '            If pointToReceive < 0 Then
    '                pointToReceive = 0
    '            End If
    '            Exit For
    '        End If

    '    Next
    '    Return pointToReceive

    'End Function


    'Private Shared Function giveNameCadeaux(ByVal id As Integer, ByVal language As Integer, ByVal dtCadeau As DataTable) As String
    '    Dim nameCad As String = ""
    '    Dim row As DataRow
    '    For Each row In dtCadeau.Rows
    '        If row("id") = id Then
    '            Select Case language
    '                Case 1
    '                    nameCad = row("gift_name_fr")
    '                Case 2
    '                    nameCad = row("gift_name_nl")
    '                Case 3
    '                    nameCad = row("gift_name_en")
    '            End Select
    '            Exit For
    '        End If
    '    Next
    '    Return nameCad
    'End Function

    'Private Shared Function returnIdCadeaux(ByVal mgmPoint As Integer, ByVal dtCadeau As DataTable) As Integer
    '    Dim row As DataRow
    '    Dim id As Integer

    '    For Each row In dtCadeau.Rows
    '        If mgmPoint <= row("points") Then
    '            id = row("id")
    '            Exit For
    '        End If

    '    Next
    '    Return id
    'End Function

#End Region
#Region "HTML"
    Private Shared Function GetSendMail(ByVal MailRow As DataRow) As String


        'Select Case MailRow("mail_messages_id")
        '    Case Mail.MAIL_IN
        '        Return "in"
        '    Case Mail.MAIL_OUT
        '        Return "out"

        '    Case Mail.MAIL_VOD, Mail.MAIL_VOD_CONFIRMATION
        '        Return "vod"
        '    Case Else
        '        Return ""
        'End Select

    End Function
    Private Shared Sub ReplaceIN_OUT(ByVal CustRow As DataRow, ByVal MailRow As DataRow, ByRef strMessage As String, ByRef lstvariable As String)
        Dim balise As String = Getbalise()
        If IsExistInString(strMessage, balise & "movie_details" & balise) Then

            Dim ResultMovieDetail As String
            Dim ResultMovieRecommandationDVD As String
            Dim ResultMovieVOD As String
            Dim send As String = GetSendMail(MailRow)
            Dim customers_id As Integer = CustRow("customers_id")
            Dim products_id As Integer = CustRow("products_id")
            Dim Strdate As String = CustRow("date_sent")
            '  Dim lang As DvdPostData.ClsCustomersData.Language
            ResultMovieDetail = PlushBuziness.ClsWebServices.CallUrlMOVIEDETAIL(customers_id, products_id, send)
            ResultMovieRecommandationDVD = PlushBuziness.ClsWebServices.CallUrlRecommendationDVD(customers_id, products_id)
            ResultMovieVOD = PlushBuziness.ClsWebServices.CallUrlVOD(customers_id)

            strMessage = ReplaceVar(strMessage, balise & "movie_details" & balise, ResultMovieDetail, lstvariable)
            strMessage = ReplaceVar(strMessage, balise & "recommendation_dvd_to_dvd" & balise, ResultMovieRecommandationDVD, lstvariable)
            strMessage = ReplaceVar(strMessage, balise & "selection_vod" & balise, ResultMovieVOD, lstvariable)
            strMessage = ReplaceVar(strMessage, balise & "date" & balise, Strdate, lstvariable)
        End If

    End Sub

    Private Shared Sub ReplaceINDISPONIBLE(ByVal CustRow As DataRow, ByVal MailRow As DataRow, ByRef strMessage As String, ByRef lstvariable As String)
        Dim balise As String = Getbalise()
        If IsExistInString(strMessage, balise & "recommendation_dvd_to_dvd" & balise) Then

            Dim ResultMovieRecommandationDVD As String
            Dim send As String = GetSendMail(MailRow)
            Dim customers_id As Integer = CustRow("customers_id")
            Dim products_id As Integer = CustRow("products_id")
            Dim keyRecommandationDisplay As String

            ''

            '   Dim dtPictureDVD As DataTable = getPictureSDVD(products_id)

            '  Dim lang As DvdPostData.ClsCustomersData.Language
            ResultMovieRecommandationDVD = PlushBuziness.ClsWebServices.CallUrlRecommendationDVD(customers_id, products_id)
            If ResultMovieRecommandationDVD.Length > 1 Then
                keyRecommandationDisplay = ""
            Else
                keyRecommandationDisplay = "style = 'display:none'"
            End If

            strMessage = ReplaceVar(strMessage, balise & "indispo_title" & balise, "titre_indisponible", lstvariable)
            strMessage = ReplaceVar(strMessage, balise & "indispo_jacket" & balise, "dvd_indisponible", lstvariable)
            strMessage = ReplaceVar(strMessage, balise & "recommendation_display" & balise, keyRecommandationDisplay, lstvariable)
            strMessage = ReplaceVar(strMessage, balise & "products_id" & balise, products_id, lstvariable)
            strMessage = ReplaceVar(strMessage, balise & "products_name" & balise, CustRow("products_name"), lstvariable)
            strMessage = ReplaceVar(strMessage, balise & "recommendation_dvd_to_dvd" & balise, ResultMovieRecommandationDVD, lstvariable)
        End If

    End Sub
#End Region
#Region "Actors"
    Private Shared Sub ReplaceActors(ByVal CustRow As DataRow, ByRef strMessage As String, ByRef lstvariable As String)
        Dim balise As String = Getbalise()
        If IsExistInString(strMessage, balise & "actor1_id" & balise) _
            AndAlso CustRow.Table.Columns.Contains("products_id") Then

            Dim dtactors As DataTable
            Dim products_id As Integer
            Dim containsActors As Boolean
            Dim actor_id As String = String.Empty
            Dim actor_name As String = String.Empty
            Dim director_id As String = String.Empty
            Dim director_name As String = String.Empty
            Dim products_rating As String = String.Empty

            products_id = CustRow("products_id")
            dtactors = getListActors(products_id)
            containsActors = dtactors.Rows.Count > 0
            Dim j As Integer
            For i As Integer = 1 To NBACTORS
                j = i - 1
                If dtactors.Rows.Count > i AndAlso dtactors.Rows(j)("actors_name") IsNot DBNull.Value Then
                    actor_name = dtactors.Rows(j)("actors_name")
                    actor_id = dtactors.Rows(j)("actors_id")
                Else
                    actor_name = String.Empty
                    actor_id = String.Empty
                End If
                strMessage = ReplaceVar(strMessage, balise & "actor" & i & "_id" & balise, actor_id, lstvariable)
                strMessage = ReplaceVar(strMessage, balise & "actor" & i & balise, actor_name, lstvariable)
            Next
            If containsActors Then
                If dtactors.Rows(0)("directors_id") IsNot DBNull.Value Then
                    director_id = dtactors.Rows(0)("directors_id")
                    director_name = dtactors.Rows(0)("directors_name")
                End If

            End If
            strMessage = ReplaceVar(strMessage, balise & "directors_id" & balise, director_id, lstvariable)
            strMessage = ReplaceVar(strMessage, balise & "directors" & balise, director_name, lstvariable)
            If CustRow("products_rating") IsNot DBNull.Value Then
                products_rating = CustRow("products_rating")
            End If
            strMessage = ReplaceVar(strMessage, balise & "products_rating" & balise, products_rating, lstvariable)
        End If
    End Sub
#End Region
#Region "Picture"
    Private Shared Sub ReplacePictureDVD(ByVal CustRow As DataRow, ByVal customers_language As Integer, ByRef strMessage As String, ByRef lstvariable As String)
        Dim balise As String = Getbalise()
        If IsExistInString(strMessage, balise & "dvd1_products_id" & balise) Then

            Dim dtProductDVD As DataTable
            Dim customers_id As Integer = CustRow("customers_id")
            '  Dim lang As DvdPostData.ClsCustomersData.Language
            dtProductDVD = PlushBuziness.ClsWebServices.CallUrlRecommendation(customers_id)
            '   lang = customers_language
            ' strMessage = ReplaceVar(strMessage, balise & "lang", PlushTools.clsEnum.getNameStrEnum(lang), lstvariable)
            Dim lg As String = String.Empty
            Dim j As Integer
            For i As Integer = 1 To NBPRODUCTSIMAGE
                j = i - 1
                strMessage = ReplaceVar(strMessage, balise & "dvd" & i & "_products_id" & balise, dtProductDVD.Rows(j)("id"), lstvariable)
                strMessage = ReplaceVar(strMessage, balise & "dvd" & i & "_products_image" & balise, dtProductDVD.Rows(j)("image"), lstvariable)
                strMessage = ReplaceVar(strMessage, balise & "dvd" & i & "_products_name" & balise, dtProductDVD.Rows(j)("name"), lstvariable)

                'Select Case customers_language
                '    Case 1 'FR
                '        lg = "fr"
                '    Case 2 'NL
                '        lg = "nl"
                '    Case 3 'EN
                '        lg = "en"

                'End Select

            Next

        End If

    End Sub

#End Region
#Region "Recovery Payment"
    Private Shared Sub ReplaceInvoiceOpen(ByVal CustRow As DataRow, ByRef strMessage As String, ByRef lstvariable As String)
        Dim balise As String = Getbalise()
        If IsExistInString(strMessage, balise & "PaymentOpened" & balise) Then
            Dim sql As String
            Dim dtPayment As DataTable
            Dim customers_id As Integer = CustRow("customers_id")
            Dim result As String
            Dim lineStart As String = "<tr>"
            Dim lineEnd As String = "</tr>"
            ' Dim ColEmpty As String = "<td width=5%></td>"
            Dim colValue As String = "<td>$$$value$$$</td>"
            Dim tableStart As String = "<table cellspacing=3 cellpadding=2 align=center border=rules>"
            Dim tableEnd As String = "</table>"
            result = tableStart

            Dim strdate As String
            Dim stramount As String


            sql = PlushData.PaymentOfflineData.GetPaymentCustomersOpen(customers_id)
            dtPayment = PlushData.clsConnection.FillDataSet(sql)


            For Each dr As DataRow In dtPayment.Rows
                strdate = dr("date_reconduction")
                stramount = dr("amount")
                result = result + lineStart
                '    result = result + ColEmpty
                result = result + colValue.Replace("$$$value$$$", strdate)
                '   result = result + ColEmpty
                result = result + colValue.Replace("$$$value$$$", stramount)
                result = result + lineEnd
            Next
            result = result + tableEnd
            strMessage = ReplaceVar(strMessage, balise & "PaymentOpened" & balise, result, lstvariable)
        End If
    End Sub
#End Region
#Region "LoadData"
    Private Shared Function getListActors(ByVal products_id As Integer) As DataTable
        Dim dt As New DataTable
        Dim sql As String

        sql = PlushData.clsProductDvd.GetSelectListActors(products_id)
        dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt
    End Function

    Private Shared Function getGender(ByVal gender As String, ByVal language_id As Integer) As String
        Dim sql As String
        Dim result As String
        Dim genderTxt As String
        If gender = "m" Then
            genderTxt = "'TEXT_MALE_GENDER'"
        Else
            genderTxt = "'TEXT_FEMALE_GENDER'"
        End If
        sql = " select translation_value from dvdpost_common.translation2 " & _
                " where language_id = " & language_id & " and translation_key = " & genderTxt & " and translation_page = 'automatic_mails' "

        result = PlushData.clsConnection.ExecuteScalar(sql)

        Return result

    End Function
    Private Shared Function getPictureSDVD(ByVal products_id As Integer) As DataTable
        Dim dt As New DataTable
        Dim sql As String

        sql = PlushData.clsProductDvd.GetSelectPicturesDVD(products_id)
        dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt
    End Function
#End Region

    '' mail_scheduler
    ' select * from scheduler_mail where adddate(date_last_execution,frequencyDays) >= date(now()) and hour(now()) = hour_executed
    ' insert scheduler_mail_history(null,mail_id,null,now(),frequencyDays,hour_executed,cpt_mail_sent,script_php,now(),user_id(userSite))    
    ' update scheduler_mail set date_last_execution = now() where scheduler_mail_id = x    
    '' --------------
End Class




