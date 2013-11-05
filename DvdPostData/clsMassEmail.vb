Public Class clsMassEmail

    Public Shared Function getAllMailMessages() As String
        Dim sql As String
        sql = "SELECT * from mail_messages WHERE language_id = 1 order by mail_messages_id"
        Return sql
    End Function

    Public Shared Function getSmtpServer() As String
        Dim sql As String
        sql = "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global' and Name = 'SMTPServer'"
        Return sql
    End Function

    Public Shared Function getLanguages() As String
        Dim sql As String
        sql = "SELECT * from languages "
        Return sql
    End Function

    Public Shared Function getSite() As String
        Dim sql As String
        sql = "SELECT * from site "
        Return sql
    End Function

    Public Shared Function getCustomersDiscountUse(ByVal discount_code_id As Integer, ByVal message_id As Integer)
        Dim sql As String
        sql = " select * , count(mail_messages_id) as already_sent " & _
                     " from discount_use du ,customers c " & _
                     " left join mail_messages_sent_history mh on mh.customers_id = c.customers_id and mh.mail_messages_id = " & message_id & _
                     " where(discount_code_id = " & discount_code_id & " And c.customers_id = du.customers_id  ) " & _
                     " group by c.customers_id "
        Return sql
    End Function
    Private Shared Function CapitalizeSql(ByVal str As String) As String
        Dim sql As String

        sql = "concat(UPPER(SUBSTRING(" & str & ",1,1)),LOWER(SUBSTRING(" & str & ",2)))"
        Return sql
    End Function
    Public Shared Function CapitalizeSql(ByVal strFirstName As String, ByVal strLastName As String) As String
        Dim sql As String

        sql = "concat(" & CapitalizeSql(strFirstName) & ",' '," & CapitalizeSql(strLastName) & ")"
        Return sql
    End Function
    Public Shared Function getCustWithMailHistSentAndAdressBook(ByVal message_id As Integer, ByVal newsLetter As Boolean, ByVal newsPartner As Boolean, ByVal dstart As DateTime, ByVal dstop As DateTime, ByVal istest As Boolean) As String

        Dim sql As String
        Dim sqldateStart As String = ""
        Dim sqldateStop As String = ""

        If dstart <> DateTime.MinValue Then
            sqldateStart = " and customers_abo_validityto >= '" & PlushTools.ClsDate.formatDateDB(dstart) & "'"
        End If

        If dstop <> DateTime.MinValue Then
            sqldateStop = " and customers_abo_validityto <= '" & PlushTools.ClsDate.formatDateDB(dstop) & "'"
        End If

        sql = "SELECT " & CapitalizeSql("customers_firstname", "customers_lastname") & " as customers_name , '2010-07-30' payment_offline_reason_date,'14.95' payment_offline_amount, '000000' payment_offline_communication, " & _
                " (select max(date_purchased) from orders where customers_id=C.customers_id)as date_last_order,C.customers_id , customers_gender, customers_firstname ,customers_lastname , C.customers_email_address , " & _
                             " customers_abo , customers_next_abo_type,C.activation_discount_code_id, customers_abo_dvd_credit, customers_abo_dvd_norm, customers_abo_dvd_adult, " & _
                             " customers_abo_dvd_home_norm, customers_abo_dvd_home_adult , C.customers_registration_step," & _
                     "  count(mail_messages_id) as already_sent,  C.selected_for_email, C.site, C.marketing_ok , C.mgm_points ," & _
                     " if (customers_abo_validityto = '0000-00-00 00:00:00', Null, DATE_FORMAT(customers_abo_validityto,'%e-%m-%Y')) as next_reconduction_date,  " & _
                     " if (customers_dob = '0000-00-00 00:00:00', Null, DATE_FORMAT(customers_dob,'%e-%m-%Y')) as customers_dob, customers_language, activation_discount_code_id,  " & _
                     " C.customers_registration_step, DATE_FORMAT(C.customers_info_date_account_created,'%e-%m-%Y') as abo_creation_date, C.activation_discount_code_type, entry_postcode, is_email_valid, date_first_delivery,EntityID, ab.entry_country_id ,  " & _
                     " C.abo_not_served_reason, (select count(*) from wishlist wl where wl.customers_id = C.customers_id) as wl_size,'' abo_action,  " & _
                     " abo.type_code,abo.promo_code " & _
                     " FROM customers C " & _
                     " LEFT JOIN (" & ClsCustomersData.getLastCodeSubscription() & ") abo on abo.customerid = C.customers_id  " & _
                    " LEFT JOIN mail_messages_sent_history mh on mh.customers_id = C.customers_id and mail_messages_id = " & message_id & " " & _
                    " LEFT JOIN address_book ab on ab.customers_id = C.customers_id and C.customers_default_address_id = ab.address_book_id " & _
                     " where is_email_valid = 1  " + getNewsLetter(newsLetter) + getNewParnerChip(newsPartner) + sqldateStart + sqldateStop & _
                     " GROUP BY C.customers_id"

        '" (select count(mail_messages_id) as already_sent from mail_messages_sent_history mh where mh.customers_id = C.customers_id and mail_messages_id = " & message_id & ") already_sent " & _
        If istest Then
            sql = sql + " limit 1"
        End If


        Return sql
    End Function

    Public Shared Function getNewsLetter(ByVal newsLetter As Boolean) As String
        Dim sql As String
        If newsLetter = 0 Then
            sql = " "
        Else
            sql = " AND customers_newsletter = 1 "
        End If
        Return sql
    End Function

    Public Shared Function getNewParnerChip(ByVal newsPartner As Boolean) As String
        Dim sql As String
        If newsPartner = 0 Then
            sql = " "
        Else
            sql = " AND customers_newsletter = 1 "
        End If
        Return sql
    End Function

    Public Shared Function getLastAboAction(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "SELECT name " & _
              " FROM abo a left join abo_action aa on a.action = aa.id " & _
              " where customerid = " & customers_id & _
              " ORDER BY abo_id DESC limit 1"
        Return sql
    End Function

    Public Shared Function getCustomersWithDiscountCode() As String
        Dim sql As String
        sql = "SELECT  customerid as customers_id, activation_code as Code, if (`Date` = '0000-00-00 00:00:00', Null, `Date`) as Code_Creation_Date, 'ac' as Code_type " & _
              " FROM abo a " & _
              " LEFT JOIN activation_code ac on a.code_id= ac.activation_id" & _
              " WHERE a.Action = 8" & _
              " UNION " & _
              " SELECT  customerid as customers_id, discount_code as Code, if (`Date` = '0000-00-00 00:00:00', Null, `Date`) as Code_Creation_Date, 'dc' as Code_type " & _
              " FROM abo a " & _
              " LEFT JOIN discount_code dc on a.code_id = dc.discount_code_id" & _
              " WHERE a.action = 6"
        Return sql
    End Function

    Public Shared Function getAboStopDelay(ByVal periode As Integer, ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "select * from abo" & _
                       " where `action` = 4" & _
                       " and `date` <= date_sub(curdate(), interval " & periode & " month)" & _
                       " and customerid=" & customers_id & " order by abo_id desc limit 1"
        Return sql

    End Function


    Public Shared Function insertMailSentHistory(ByVal maxMailId As Integer, ByVal customers_id As Integer, ByVal message_id As Integer, ByVal language As Integer, ByVal email As String) As String
        Dim sql As String
        sql = "insert into mail_messages_sent_history (mail_messages_sent_history_id, date, customers_id, " & _
                                " mail_messages_id , language_id, customers_email_address) values('" & maxMailId & _
                                "', now(), '" & customers_id & "', '" & message_id & "', '" & _
                               language & "', '" & email & "' ) "
        Return sql
    End Function

    Public Shared Function getMemGetMemGift() As String
        Dim sql As String
        sql = "SELECT (mem_get_mem_gift_id) as id ,gift_name_fr,gift_name_nl , gift_name_en , points , quantity FROM `mem_get_mem_gift` WHERE mem_get_mem_gift_id IN ( 35, 36, 37, 38 ) order by mem_get_mem_gift_id"
        Return sql
    End Function


    Public Shared Function insertActionKeys(ByVal customers_id As Integer, ByVal uniqid As String) As String
        Dim sql As String
        sql = "insert into actions_key (customers_id ,actions_id , `key`) values (" & customers_id & " ,1, '" & uniqid & "') "
        Return sql
    End Function


    Public Shared Function GetemailHistory(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "select * from mail_messages_sent_history msh join mail_messages ms on ms.mail_messages_id = msh.mail_messages_id and msh.language_id = ms.language_id where customers_id = " & customers_id & " order by msh.date desc "
        Return sql
    End Function



End Class
