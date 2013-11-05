Public Class PaymentOfflineData

    'Public Shared Function GetStepPaymentDVDAll() As String
    '    Dim sql As String
    '    sql = "SELECT * " & _
    '    " FROM payment_offline_request por left join customers c on c.customers_id = por.customers_id " & _
    '    " left join customers_abo_payment_method capm on capm.customers_abo_payment_method_id = c.customers_abo_payment_method" & _
    '    " left join payment_offline_status pos on pos.id = por.payment_offline_status" & _
    '    " left join orders o on c.customers_id = o.customers_id " & _
    '    " LEFT JOIN orders_products op on op.orders_id = o.orders_id " & _
    '    " LEFT JOIN products_description pd on pd.products_id = op.products_id and language_id = c.customers_language" & _
    '    " where o.orders_status = 2 " 'Expidited Only   " & _CustRow.Item("customers_id") & " 

    '    Return sql
    'End Function

    'Public Shared Function GetStepPaymentDVD(ByVal stepPaymentOffline As Integer) As String
    '    Dim sql As String
    '    sql = "SELECT * " & _
    '    " FROM payment_offline_request por left join customers c on c.customers_id = por.customers_id " & _
    '    " left join customers_abo_payment_method capm on capm.customers_abo_payment_method_id = c.customers_abo_payment_method" & _
    '    " left join payment_offline_status pos on pos.id = por.payment_offline_status" & _
    '    " left join orders o on c.customers_id = o.customers_id " & _
    '    " LEFT JOIN orders_products op on op.orders_id = o.orders_id " & _
    '    " LEFT JOIN products_description pd on pd.products_id = op.products_id and language_id = c.customers_language" & _
    '    " where por.payment_offline_status = " & stepPaymentOffline & " AND o.orders_status = 2 " 'Expidited Only   " & _CustRow.Item("customers_id") & " 

    '    Return sql
    'End Function
    Public Shared Function GetDvdAtHome(ByVal customers_id As String, ByVal customers_lang As Integer) As String
        Dim sql As String
        sql = "SELECT op.products_id, pd.products_name  FROM orders o " & _
                  " LEFT JOIN orders_products op on op.orders_id = o.orders_id " & _
                  " LEFT JOIN products_description pd on pd.products_id = op.products_id and language_id = " & customers_lang & _
                  " where o.customers_id = " & customers_id & "  AND o.orders_status = 2 " 'Expidited Only   " & _CustRow.Item("customers_id") & " 

        Return sql
    End Function

    Public Shared Function GetPicturesDVD() As String
        Dim sql As String

        sql = " select p.products_id , count(pd.products_id) as cnt_dvd , " & _
       " pdesc_fr.products_image_big as image_fr, pdesc_fr.products_name as name_fr, " & _
       " pdesc_nl.products_image_big as image_nl, pdesc_nl.products_name as name_nl, " & _
       " pdesc_en.products_image_big as image_en, pdesc_en.products_name as name_en, '' as categories " & _
       " from products p " & _
       " left join products_dvd pd on pd.products_id = p.products_id " & _
       " left join products_description pdesc_fr on pdesc_fr.products_id = p.products_id and pdesc_fr.language_id = 1 " & _
       " left join products_description pdesc_nl on pdesc_nl.products_id = p.products_id and pdesc_nl.language_id = 2 " & _
       " left join products_description pdesc_en on pdesc_en.products_id = p.products_id and pdesc_en.language_id = 3 " & _
       " WHERE pd.products_dvd_status = 1 and pd.`inout` = 1 and p.products_status = 1 and p.products_type = 'DVD_NORM' " & _
       " and (p.rating_users / p.rating_count) >= 3 " & _
       " group by pd.products_id order by rand() limit 7 "
        Return sql

    End Function
    Public Shared Function GetSummary(ByVal TypeStatus As String) As String
        Dim sql As String

        ' sql = "select sum(if(por.payment_offline_status is null,0,1)) total, pos.id as status_id, pos.name as status_name from payment_offline_status pos " & _
        sql = "select sum(if(por.payment_offline_status is null,0,1)) total, pos.id as status_id, pos.name as status_name,orderstep" & _
              " from payment_offline_status pos " & _
              " left join payment_offline_request por on pos.id=por.payment_offline_status " & _
              " where not orderStep is null and TypeStatus = '" & TypeStatus & "'" & _
              " group by pos.id " & _
              " UNION " & _
              " select count(*) total, 0 as status_id, 'ALL' as status_name ,0 orderstep from payment_offline_status pos " & _
              " right join payment_offline_request por on pos.id=por.payment_offline_status " & _
              " where not orderStep is null and TypeStatus = '" & TypeStatus & "'" & _
              " order by orderstep"
        Return sql
    End Function
    Public Shared Function GetStepPaymentALL(ByVal TypeStatus As String) As String
        Dim sql As String
        sql = "SELECT * " & _
        " FROM payment_offline_request por left join customers c on c.customers_id = por.customers_id " & _
        " left join customers_abo_payment_method capm on capm.customers_abo_payment_method_id = c.customers_abo_payment_method" & _
        " left join payment_offline_status pos on pos.id = por.payment_offline_status" & _
        " left join address_book ab on c.customers_id = ab.customers_id and c.customers_default_address_id = ab.address_book_id " & _
        " where pos.TypeStatus = '" & TypeStatus & "'"
        Return sql

    End Function
    Public Shared Function GetStepPaymentDetail(ByVal stepPaymentOffline As Integer) As String
        Dim sql As String

        sql = "SELECT if(capm.customers_abo_payment_method_name is null,reason_pk_name,capm.customers_abo_payment_method_name) , c.*,capm.*  FROM payment_offline_request por" & _
        "  join customers c on por.customers_id = c.customers_id " & _
        "  join payment_offline_status pos on pos.id = por.payment_offline_status " & _
        "  join address_book ab on c.customers_id = ab.customers_id and c.customers_default_address_id = ab.address_book_id" & _
        "  left join bank_transfert bt on bt.id = reason_pk_value" & _
        "  left join customers_abo_payment_method capm on capm.customers_abo_payment_method_id = bt.payment_method" & _
        " where por.payment_offline_status = " & stepPaymentOffline

        Return Sql

    End Function

    Public Shared Function GetStepPayment(ByVal stepPaymentOffline As Integer) As String
        Dim sql = "SELECT * " & _
        " FROM payment_offline_request por left join customers c on c.customers_id = por.customers_id " & _
        " left join customers_abo_payment_method capm on capm.customers_abo_payment_method_id = c.customers_abo_payment_method" & _
        " left join payment_offline_status pos on pos.id = por.payment_offline_status" & _
        " left join address_book ab on c.customers_id = ab.customers_id and c.customers_default_address_id = ab.address_book_id " & _
        " where por.payment_offline_status = " & stepPaymentOffline

        Return sql

    End Function

    Public Shared Function GetSpepPaymentWithAbo(ByVal stepPaymentOffline As Integer) As String
        Dim sql As String
        sql = "SELECT * , date_format(date_add(c.customers_abo_validityto,interval -1 month) ,'%Y-%m-%d')as date_added ,  " & _
        "(SELECT pa.qty_credit from abo a " & _
        " join products_abo pa on a.product_id = pa.products_id " & _
        " where a.customerid = por.customers_id  order by a.abo_id desc  limit 1) as qty_credit " & _
        " FROM payment_offline_request por left join customers c on c.customers_id = por.customers_id " & _
        " left join customers_abo_payment_method capm on capm.customers_abo_payment_method_id = c.customers_abo_payment_method" & _
        " left join payment_offline_status pos on pos.id = por.payment_offline_status" & _
        " left join address_book ab on c.customers_id = ab.customers_id and c.customers_default_address_id = ab.address_book_id " & _
        " where por.payment_offline_status = " & stepPaymentOffline
        Return sql
    End Function

    Public Shared Function getListStepChanged(ByVal delay As Integer, ByVal old_status As Integer) As String

        Dim sqlConditionForTransition As String
        Dim sql As String
        sqlConditionForTransition = " and to_days(date_add(por.last_modified,INTERVAL " & delay & " DAY))<=to_days(curdate())"

        sql = "select por.payment_offline_request_id from payment_offline_request por, customers c"
        sql = sql & " where c.customers_id=por.customers_id"
        sql = sql & " and por.payment_offline_status=" & old_status
        sql = sql & sqlConditionForTransition

        Return sql
    End Function

    Public Shared Function SaveHistory(ByVal old_status As Integer, ByVal new_status As Integer) As String
        Dim sql As String
        sql = "insert into payment_offline_request_status_history (payment_offline_request_status_history_id ,payment_offline_request_id, new_status, old_status, date_added) "
        sql = sql & " select null, payment_offline_request_id, " & new_status & ", payment_offline_status, now() "
        sql = sql & " from payment_offline_request where payment_offline_request_id=" & old_status
        Return sql
    End Function
    Public Shared Function UpdateStatus(ByVal old_status As Integer, ByVal new_status As Integer, ByVal delay As Integer, Optional ByVal isclosed As Boolean = False, Optional ByVal account_movements_id As String = Nothing) As String
        Dim sql As String
        Dim sqlConditionForTransition As String
        sql = "update payment_offline_request set "
        sql = sql & " payment_offline_status=" & new_status & " "
        sql = sql & " ,last_modified=now() "

        sqlConditionForTransition = " and to_days(date_add(last_modified,INTERVAL " & delay & " DAY))<=to_days(curdate())"
        If Not account_movements_id = Nothing Then sql = sql & ", account_movements_id='" & account_movements_id & "' "
        If isclosed Then sql = sql & ", date_closed=now() "
        sql = sql & " where payment_offline_status=" & old_status
        sql = sql & sqlConditionForTransition

        Return sql
    End Function

    Public Shared Function UpdateStatus(ByVal id As Integer, ByVal typePayment As String, ByVal customers_id As Integer, ByVal status As Integer) As String
        Dim sql As String
        sql = "update payment_offline_request set "
        sql = sql & " payment_offline_status=" & status & " "
        sql = sql & " ,last_modified=now() "
        sql = sql & " , user_modified = " & clsSession.user_id
        sql = sql & " where reason_pk_value=" & id
        sql = sql & " and reason_pk_name = '" & typePayment & "'"
        sql = sql & " and customers_id = " & customers_id

        Return sql

    End Function


    Public Shared Function ForcedUpdateStatus(ByVal old_status As Integer, ByVal new_status As Integer, ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "update payment_offline_request set "
        sql = sql & " payment_offline_status=" & new_status & " "
        sql = sql & " ,last_modified=now() "
        sql = sql & " where payment_offline_status=" & old_status
        sql = sql & " and customers_id = " & customers_id

        Return sql

    End Function

    Public Shared Function ForcedUpdateAllCustomerStatus(ByVal old_status As Integer, ByVal new_status As Integer) As String
        Dim sql As String
        sql = "update payment_offline_request set "
        sql = sql & " payment_offline_status=" & new_status & " "
        sql = sql & " ,last_modified=now() "
        sql = sql & " where payment_offline_status=" & old_status

        Return sql

    End Function

    Public Shared Function GetMail(ByVal mail_id As Integer, ByVal lang As Integer) As String
        Dim sql As String
        sql = "SELECT * FROM mail_messages WHERE mail_messages_id = '" & mail_id & "' and language_id = '" & lang & "'"
        Return sql
    End Function

    Public Shared Function GetReport(ByVal report_id As Integer)
        Dim sql As String

        sql = "SELECT * FROM generalreport WHERE ReportID = " & report_id & " order by ReportLang"
        Return sql

    End Function


    Public Shared Function GetDvdatHome(ByVal customers_id As Integer, ByVal customer_lang As Integer) As String
        Dim sql As String
        sql = "SELECT *  FROM orders o " & _
                      " LEFT JOIN orders_products op on op.orders_id = o.orders_id " & _
                      " LEFT JOIN products p on p.products_id = op.products_id " & _
                      " LEFT JOIN products_description pd on pd.products_id = op.products_id and language_id = " & customer_lang & _
                      " where o.customers_id = " & customers_id & "  AND o.orders_status = 2 " 'Expidited Only   " & _CustRow.Item("customers_id") & " 

        Return sql
    End Function

    Public Shared Function GetSite() As String
        Dim sql As String

        sql = "select * from site where site_name = 'www'"
        Return sql

    End Function

    Public Shared Function GetParametersGlobal() As String
        Dim sql As String

        sql = "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global'"
        Return sql

    End Function

    Public Shared Function SaveMailHistory(ByVal customers_id As Integer, ByVal mail_message_id As Integer, ByVal customers_lang As Integer)

        Dim sql As String

        sql = "insert into mail_messages_sent_history (date, customers_id, " & _
                 " mail_messages_id , language_id ) values( " & _
                 " now(), '" & customers_id & "', '" & mail_message_id & "', '" & _
                 customers_lang & "' ) "

        Return sql
    End Function

   

    Public Shared Function InsertPaymentOfflineRequest(ByVal Payment_offline_request_id As Integer, _
                                                       ByVal status_created As Integer, _
                                                       ByVal amount As String, _
                                                       ByVal bank_account As String, _
                                                       ByVal customers_id As Integer, _
                                                       ByVal reason_type As String, _
                                                       ByVal reason_id As String, _
                                                       ByVal comm_struc As String) As String
        Dim sql As String

        sql = "insert into payment_offline_request  (Payment_offline_request_id,amount,dvdpost_bank_account,communication,customers_id,date_added,"
        sql = sql & " payment_offline_status, last_modified, comment, reason_pk_name,reason_pk_value )"
        sql = sql & " values ("
        sql = sql & Payment_offline_request_id & "," & amount & "," & bank_account & ",'" & comm_struc & "'," & customers_id & ",now()," & status_created
        sql = sql & ",now(),null,'" & reason_type & "','" & reason_id & "'"
        sql = sql & ")"

        Return sql
    End Function

    Public Shared Function UpdateCommunicationStructure(ByVal payment_offline_request_id As Integer, ByVal communication As String) As String
        Dim sql As String

        sql = "update payment_offline_request por set "
        sql = sql & " por.communication='" & communication & "'"
        sql = sql & " where por.payment_offline_request_id = " & payment_offline_request_id

        Return sql

    End Function

    Public Shared Function getIdLast() As String
        Dim sql As String

        sql = "SELECT max(payment_offline_request_id) as obid FROM payment_offline_request"
        Return sql
    End Function

    Public Shared Function getPaymentOfflineRequest(ByVal customers_id As Integer, ByVal reason_id As String, ByVal reason_name As String) As String
        Dim sql As String

        sql = "select * from payment_offline_request where customers_id = " & customers_id & " and reason_pk_name = '" & reason_name & "' "
        sql = sql & " and reason_pk_value = '" & reason_id & "'"
        Return sql
    End Function

    Public Shared Function getMatchingOfflineRequest(ByVal status_paid As Integer) As String
        Dim sql As String

        sql = " update bank_account_movements bm "
        sql = sql & " inner join payment_offline_request por on por.communication = bm.structuredComm12 "
        sql = sql & " set por.account_movements_id = bm.account_movements_id,  bm.ismatching = 1,bm.date_added = now(),bm.last_modified = now(),bm.user_modified = " & clsSession.user_id
        sql = sql & " , por.payment_offline_status = " & status_paid & ", por.last_modified = now(),por.user_modified = " & clsSession.user_id
        sql = sql & " where bm.ismatching = 0 and cast(bm.amount as decimal) = cast(por.amount as decimal) "

        Return sql
    End Function

    Public Shared Function GetMatchingOgone(ByVal reason_name As String, ByVal status_ogone_paid As Integer, ByVal lst_status_offline_paid As String, ByVal lst_status_ogone_Unpaid As String) As String
        Dim sql As String

        sql = " update ogone_payment op join payment_offline_request por" & _
                " on op.ogone_payment_id = por.reason_pk_value and por.reason_pk_name = '" & reason_name & "'" & _
                " set op.account_movements_id = por.account_movements_id,op.ogone_payment_status = " & status_ogone_paid & ",op.last_modified = now(),por.amount_received = por.amount" & _
                " where op.ogone_payment_status in (" & lst_status_ogone_Unpaid & ") and por.payment_offline_status in (" & lst_status_offline_paid & ")" & _
                " and cast(por.amount as decimal) = cast(op.amount as decimal) "
        Return sql
    End Function


    Public Shared Function GetMatchingDomiciliation(ByVal reason_name As String, ByVal status_Dom_paid As Integer, ByVal lst_status_offline_paid As String, ByVal lst_status_dom_Unpaid As String) As String
        Dim sql As String

        sql = " update domiciliation_payment dp join payment_offline_request por" & _
                " on dp.domiciliation_payment_id = por.reason_pk_value and por.reason_pk_name = '" & reason_name & "'" & _
                " set dp.account_movements_id = por.account_movements_id,dp.domiciliation_payment_status = " & status_Dom_paid & ",dp.last_modified = now(),por.amount_received = por.amount" & _
                " where dp.domiciliation_payment_status in (" & lst_status_dom_Unpaid & ") and por.payment_offline_status in (" & lst_status_offline_paid & ")" & _
                " and cast(por.amount as decimal) = cast(dp.amount as decimal) and por.communication = dp.strdomiciliation_number"
        Return sql
    End Function


    Public Shared Function GetMatchingBankTransfer(ByVal reason_name As String, ByVal status_BankTransfer_paid As String, ByVal lst_status_offline_paid As String, ByVal lst_status_bankTransfer_Unpaid As String) As String
        Dim sql As String

        sql = " update bank_transfert bm join payment_offline_request por" & _
                " on bm.id = por.reason_pk_value and por.reason_pk_name = '" & reason_name & "'" & _
                " set bm.account_movements_id = por.account_movements_id, bm.status = '" & status_BankTransfer_paid & "',bm.last_modified = now(),por.amount_received = por.amount" & _
                " where bm.status in (" & lst_status_bankTransfer_Unpaid & ") and por.payment_offline_status in (" & lst_status_offline_paid & ")" & _
                " and cast(por.amount as decimal) = cast(bm.amount as decimal)  and por.communication = bm.structure_communication"
        Return sql
    End Function

End Class