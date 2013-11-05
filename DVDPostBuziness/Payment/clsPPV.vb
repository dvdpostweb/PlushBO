Imports MySql.Data.MySqlClient
Imports System.IO
Imports System
Imports System.Collections.Generic
Imports PlushData

Public Class clsPPV

    Public Event initMapping_Event(ByVal cpt As Integer)
    Public Event stepMapping_event(ByVal index As Integer)

    Const CURRENCY As String = "EUR"
    Const OPERATION_CODE As String = "SAL"
    Const DESC As String = "pay per view payment "

    Public Function CreatePPVPaymentsManager(ByVal idcountry As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, Optional ByVal filepath As String = "") As Boolean
        Dim idBatchOgone As Integer
        Dim dtPPVPayments As DataTable
        Dim sql As String
        Try
            If PPVPaymentExists(idcountry, dateFrom, dateTo) Then
                clsMsgError.MsgBox("Payment already exists!")
                Return False
            End If
            PlushData.clsConnection.CreateTransaction(False) ' false parameter creates transaction
            sql = clsPPVPayments.getSelectForPPVPayments(idcountry, dateFrom, dateTo)

            dtPPVPayments = PlushData.clsConnection.FillDataSet(sql)

            If clsMsgError.MsgBox("Are you sur to process " & dtPPVPayments.Rows.Count & " PPV payments for period from '" & PlushTools.ClsDate.formatDate(dateFrom) & "' to '" & PlushTools.ClsDate.formatDate(dateTo) & "' ?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                idBatchOgone = ClsBatchOgone.getIdBatchOgone()

                insertCustomersOgonePayment(dtPPVPayments, idBatchOgone)
                CreatePPVPaymentsFile(dtPPVPayments, idcountry, idBatchOgone, filepath)
                CreatePPVPayments(idBatchOgone, idcountry, dateFrom, dateTo)
                PlushData.clsConnection.CommitTransaction(True)
                Return True
            End If
        Catch ex As Exception
            PlushData.clsConnection.CommitTransaction(False)
            Return False
        End Try
    End Function

    Public Sub CreatePPVPayments(ByVal batch_id As Integer, ByVal idcountry As Integer, ByVal dateFrom As Date, ByVal dateTo As Date)
        Dim sql As String
        sql = clsPPVPayments.getInsertPPVPayment(batch_id, idcountry, dateFrom, dateTo)
        PlushData.clsConnection.ExecuteNonQuery(sql, False)

    End Sub

    Public Function PPVPaymentExists(ByVal country_id As Integer, ByVal dateFrom As Date, ByVal dateTo As Date) As Boolean
        Dim sql As String
        Dim dt As DataTable

        sql = clsPPVPayments.getSelectPPVPaymentExists(country_id, dateFrom, dateTo)
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt.Rows.Count > 0

    End Function

    Public Sub CreatePPVPaymentsFile(ByVal dtPPVPayments As DataTable, ByVal idcountry As Integer, ByVal idBatchOgone As Integer, Optional ByVal filepath As String = "")
        Dim stroutput As String = ""
        Dim message As String = ""
        Dim pathfile As String = ClsBatchOgone.CreatePathFile(ClsBatchOgone.TypeBatch.PAY_PER_VIEW, idcountry, filepath)
        RaiseEvent initMapping_Event(dtPPVPayments.Rows.Count)

        stroutput = stroutput + GetHeader(dtPPVPayments.Rows.Count, idBatchOgone, idcountry)
        Dim cpt As Integer = 0
        For Each dr As DataRow In dtPPVPayments.Rows
            stroutput = stroutput + CreateLineOgone(dr, idBatchOgone)
            RaiseEvent stepMapping_event(cpt)
            cpt += 1
        Next
        stroutput = stroutput + GetFooter()

        Dim ok As Boolean = PlushTools.clsFile.WriteFileNoExist(ClsBatchOgone.CreatePathFile(ClsBatchOgone.TypeBatch.PAY_PER_VIEW, idcountry, filepath), stroutput)
        PlushData.clsConnection.ExecuteNonQuery(PlushData.ClsBatchOgone.OgonePaymentBatch(stroutput))

        If ok Then
            message = " PPV File " & pathfile & " is successfuly created "
            clsMsgError.MsgBox(message)
        Else
            message = " PPV File is not created. See error log in logmessages"
            clsMsgError.MsgBox(message)
            Throw New Exception(" PPV File is not created. See error log in logmessages")
        End If


    End Sub

    Public Shared Function CreateLineOgone(ByVal rCustomers As DataRow, ByVal batch_id As Integer) As String
        Dim customers_id As Integer
        Dim product_model As String
        Dim amount As String
        Dim created_at As String
        Dim type_CardCredit As String = String.Empty
        Dim num_card As String = String.Empty
        Dim card_exp_date As String = String.Empty


        Try
            customers_id = rCustomers("customers_id")
            product_model = rCustomers("products_title")
            amount = rCustomers("amount")
            created_at = PlushTools.ClsDate.formatDate(rCustomers("created_at"))


            Return CreateLineOgone(customers_id, _
                                   CURRENCY, _
                                   OPERATION_CODE, _
                                   DESC, _
                                   product_model, _
                                   created_at, _
                                   batch_id, _
                                   amount, _
                                   type_CardCredit, _
                                   num_card, _
                                   card_exp_date)
        Catch ex As Exception
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex, customers_id)
            'Throw New Exception(ex.Message & " customers id : " & cls.GetCustomersId(drReconduction))
            Return ""
        End Try

    End Function

    Public Shared Function CreateLineOgone(ByVal customers_id As Integer, _
                                          ByVal currency As String, _
                                          ByVal Operatopn_code As String, _
                                          ByVal desc As String, _
                                          ByVal products_title As String, _
                                          ByVal created_at As String, _
                                          ByVal batch_id As Integer, _
                                          ByVal amount As String, _
                                          ByVal type_cardCredit As String, _
                                          ByVal num_card As String, _
                                           ByVal card_exp_date As String) As String
        Dim line As String = ""

        line = line + PlushTools.ClsPrice.castPriceDbToPriceBatch(amount) + ";"    'amount
        line = line + currency & ";" 'currency
        If String.IsNullOrEmpty(num_card) Then
            line = line + ";" 'card type
            line = line + ";" 'card number
            line = line + ";" 'exp date
        Else
            line = line + type_cardCredit & ";" 'card type
            line = line + num_card & ";" 'card number
            line = line + card_exp_date & ";" 'exp date
            ' EncodeNumberCard(customers_id, num_card)
        End If


        line = line + "bp" & batch_id & "cp" & customers_id & ";" 'ref 
        line = line + desc & products_title & " from " & created_at & ";" 'desc
        line = line + ";" 'client name
        line = line + ";" 'payment id
        line = line + Operatopn_code & ";" 'operation code
        line = line + ";" '
        line = line + ";" '
        line = line + ";" '
        line = line + ";" '
        line = line + ";" '
        line = line + ";" '
        line = line & "p" & customers_id & ";" 'clientalias
        line = line + vbLf 'ControlChars.CrLf

        Return line
    End Function

    Private Shared Function GetHeader(ByVal cpt_transaction As Integer, ByVal idBatchOgone As Integer, ByVal idcountry As PlushData.ClsCustomersData.Country) As String
        Dim stroutput As String = ""
        Dim pspid As String
        Dim pwd As String

        If idcountry = ClsCustomersData.Country.BELGIUM Then
            pspid = Configuration.ConfigurationManager.AppSettings("ogone_pspidBE")
            pwd = Configuration.ConfigurationManager.AppSettings("ogone_pwdBE")
        Else
            pspid = Configuration.ConfigurationManager.AppSettings("ogone_pspidNL")
            pwd = Configuration.ConfigurationManager.AppSettings("ogone_pwdNL")
        End If
        stroutput = stroutput & "OHL" & ";" & pspid & ";" & pwd & ";" & ";" & ";" & ControlChars.CrLf
        stroutput = stroutput & "OHF" & ";" & "pbatchogone" & idBatchOgone & ";" & "ATR" & ";" & ";" & cpt_transaction & ";" & ControlChars.CrLf

        Return stroutput
    End Function

    Private Shared Function GetFooter() As String
        Dim stroutput As String = ""
        stroutput = "OTF" & ";" & ControlChars.CrLf
        Return stroutput
    End Function

    Private Sub insertCustomersOgonePayment(ByVal dtCustomers As DataTable, ByRef lastOgoneBatch_id As Integer)
        For Each drcustomer As DataRow In dtCustomers.Rows
            insertOgonePayment(drcustomer, lastOgoneBatch_id)
        Next
    End Sub
    Private Sub insertOgonePayment(ByVal drcustomers As DataRow, ByVal ogone_batch_id As Integer)
        Dim abo_id As Integer = 0
        Dim customers_id As Integer
        Dim price As String = ""
        Try
            price = GetCustomersAmount(drcustomers)
            price = PlushTools.ClsPrice.FormatPrice(price)
            'abo_id = GetCustomersAbo(drcustomers) 'TODO da li ovo treba ?????
            customers_id = GetCustomersId(drcustomers)

            PlushData.clsConnection.ExecuteNonQuery(PlushData.ClsBatchOgone.CreateOgonePayment(abo_id, customers_id, price, ogone_batch_id), False)

            'OgonePaymentLastID = DvdPostData.clsConnection.ExecuteScalar(DvdPostData.ClsBatchOgone.getLastIdInsert())

            'DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.ClsBatchOgone.OgonePaymentHistory(PaymentOfflineData.StepPayment.WAITING_PAYMENT, OgonePaymentLastID), True)
        Catch ex As Exception
            clsMsgError.MsgBox("erreur insertion ogone customers_id " & customers_id & " price " & price)
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex, customers_id)
        End Try
    End Sub

    Public Function GetCustomersAmount(ByVal drCustomer As DataRow) As String
        Return drCustomer("amount")
    End Function

    Public Function GetCustomersPayment_method(ByVal drCustomer As DataRow) As Integer
        Return drCustomer("customers_abo_payment_method")
    End Function

    Public Function GetCustomersId(ByVal drCustomer As DataRow) As Integer
        Return drCustomer("customers_id")
    End Function

End Class
