Public Class clsBatchBankTransfert
    Public Const LIMIT_DAYPAID As Integer = 10 ' days 
    Public Const DAYRECOUVREMENT As Integer = 15 ' days



    'Public Shared Function getIdLastBank_Transfert() As String
    '    Dim sql As String

    '    sql = "SELECT max(id) as obid FROM payment"
    '    Return sql
    'End Function
    Public Shared Function GetUpdateLinkADULTSVODAbo() As String
        Dim sql As String

        sql = "update payment p set abo_id = (select max(abo_id) from abo a where a.customerid = p.customers_id and a.action = " & ClsCustomersData.TypeAction.ACTION_RECONDUCTION_ADULT_SVOD & ")" & _
              " where p.abo_id = 0 and date(p.date_added) = date(now())"

        Return sql
    End Function
    Public Shared Function GetUpdateLinkAbo() As String
        Dim sql As String

        sql = "update payment p set abo_id = (select max(abo_id) from abo a where a.customerid = p.customers_id and a.action = " & ClsCustomersData.TypeAction.ACTION_RECONDUCTION & ")" & _
              " where p.abo_id = 0 and date(p.date_added) = date(now())"

        Return sql
    End Function
    Public Shared Function insertBankTransfert(ByVal abo_id As Integer, ByVal customers_id As Integer, ByVal amount As String) As String
        Dim sql As String
        sql = ClsPayment.CreatePayment(abo_id, ClsCustomersData.Payment_Method.VIREMENT, customers_id, amount, 0)
        Return sql
    End Function

    Public Shared Function insertPayPalBankTransfert(ByVal abo_id As Integer, ByVal customers_id As Integer, ByVal amount As String) As String
        Dim sql As String
        sql = ClsPayment.CreatePayment(abo_id, ClsCustomersData.Payment_Method.PAYPAL, customers_id, amount, 0)
        Return sql
    End Function

    'Private Shared Function UpdateUser() As String
    '    Dim sql As String

    '    sql = "user_modified = " & clsSession.user_id

    '    Return sql
    'End Function
    Public Shared Function UpdateCommunicationBankTransfert(ByVal id As Integer, ByVal communication As String) As String
        Dim sql As String
        sql = ClsPayment.UpdateCommunication(id, communication)
        Return sql
    End Function

    'Public Shared Function UpdateAmount_receivedBankTransfert(ByVal id As Integer, ByVal amount As String) As String
    '    Dim sql As String
    '    sql = "update bank_transfert bt set amount_received = amount_received + " & amount & "," & UpdateUser() & ",last_modified = now() where bt.id = " & id
    '    Return sql
    'End Function

    'Public Shared Function UpdateStatusBankTransfert(ByVal id As Integer, ByVal status As Integer) As String
    '    Dim sql As String
    '    sql = "update bank_transfert bt set bt.payment_status = " & status & "," & UpdateUser() & ",last_modified = now() where bt.id in = " & id
    '    Return sql
    'End Function
    'Public Shared Function UpdateStatusBankTransfert(ByVal id As Integer, ByVal status As PaymentOfflineData.StepPayment) As String
    '    Dim sql As String
    '    sql = "update bank_transfert bt set bt.payment_status = " & PlushTools.clsEnum.getValueEnum(status) & "," & UpdateUser() & ",last_modified = now() where bt.id = " & id
    '    Return sql
    'End Function

    Public Shared Function UpdateStatusBankTransfert(ByVal list_id As String, ByVal status As PaymentOfflineData.StepPayment) As String
        Dim sql As String
        sql = ClsPayment.GetUpdatePaymentStatus(list_id, status)
        Return sql
    End Function

    Public Shared Function InsertPayPalPaymentsHistory(ByVal payment_id As Integer, ByVal XMLRequest As String, ByVal XMLResponse As String, ByVal message As String, ByVal customers_id As Integer) As String
        Dim sql As String
        sql = ClsPayment.CreatePayPalPaymentsHistory(payment_id, XMLRequest, XMLResponse, message, customers_id)
        Return sql
    End Function

    'Public Shared Function UpdateCloseStatus(ByVal id_movement As Integer, ByVal id As Integer, ByVal status As PaymentOfflineData.StepPayment) As String
    '    Dim sql As String
    '    sql = "update payment p set p.account_movements_id = " & id_movement & _
    '                                ", p.payment_status= " & status & _
    '                                "," & UpdateUser() & _
    '                                ",p.last_modified = now() " & _
    '        " where p.id = " & id
    '    Return sql
    'End Function

    Public Shared Function UpdateMatchingBankAccount(ByVal id_movement As Integer) As String
        Dim sql As String
        sql = "update bank_account_movements set ismatching = " & ClsMatching.matching_type.BANKTRANSFER & " where account_movements_id = " & id_movement
        Return sql
    End Function

    Public Shared Function getMatchingNoRecovery() As String
        Dim sql As String

        sql = " select bm.account_movements_id,p.id, p.communication,p.customers_id,p.payment_status, p.amount,bm.amount " & _
              " from payment p join bank_account_movements bm on bm.structuredComm12 = p.communication " & _
              " where p.payment_status in (" & PaymentOfflineData.GetListOpenNoRecovery() & ")" & _
              " and bm.ismatching = 0 and p.communication <> 0 and abs(cast(bm.amount as decimal(10,2)) - cast(p.amount as decimal(10,2))) <= 1 "
        Return sql
    End Function

    'Public Shared Function GetDataPaymentPerCustomerDetail(ByVal customer_id As Integer, ByVal nb_limitdaysPayment As Integer, ByVal lst_payment_offline As String) As String
    '    Dim Sql As String
    '    Dim customerStr As String = ""
    '    Dim strvaliduser As String = ""
    '    If customer_id > 0 Then

    '        customerStr = " And c.customers_id = " & customer_id

    '    End If

    '    Sql = "SELECT pos.name old_status_name, if (pos2.name is null,pos_offline.name,pos2.name) new_status_name,pa.*,c.*,bt.*,btps.name payment_status_name,ab.*,p.*," & _
    '        " bt.structure_communication as communication," & _
    '        " if(p.last_modified is not null,date(date_add(p.last_modified , interval " & nb_limitdaysPayment & " day)),null) as limit_date_payment " & _
    '        " FROM customers c join bank_transfert bt on c.customers_id = bt.customers_id " & _
    '        " left join products_abo pa on c.customers_abo_type = pa.products_id" & _
    '        " left join address_book ab on ab.address_book_id = c.customers_default_address_id and c.customers_id = ab.customers_id " & _
    '        " left join payment p on p.reason_pk_name = '" & PlushTools.clsEnum.getNameStrEnum(ClsCustomersData.Payment_Method.BANK_TRANSFER) & "' and p.reason_pk_value = bt.id " & _
    '        " left join payment_status_history psh on p.id = psh.id and psh.new_status in (" & lst_payment_offline & ") " & _
    '        " left join payment_status pos on psh.old_status = pos.id " & _
    '        " left join payment_status pos2 on psh.new_status = pos2.id " & _
    '        " left join payment_status pos_offline on p.payment_status = pos_offline.id " & _
    '        " left join payment_status btps on bt.payment_status = btps.id " & _
    '        " where 1 = 1 " & customerStr


    '    Return Sql

    'End Function

    Public Shared Function GetDataPaymentCustomerDetail(ByVal date_print_start As DateTime, ByVal date_print_end As DateTime, ByVal nb_limitdaysPayment As Integer, ByVal lst_payment_offline As String, Optional ByVal validUser As Boolean = True, Optional ByVal customer_id As Integer = 0) As String
        Dim Sql As String
        Dim customerStr As String = ""
        Dim strvaliduser As String = ""
        If customer_id > 0 Then

            customerStr = " And c.customers_id = " & customer_id

        End If

        If validUser Then
            strvaliduser = " and c.customers_abo = 1 and customers_abo_suspended = 0 "
        End If
        'SELECT pa.qty_credit,c.customers_gender,c.customers_language ,c.customers_id, c.customers_firstname, c.customers_lastname,c.customers_email_address, " & _
        '       " c.customers_abo,ab.entry_street_address, ab.entry_postcode,bt.structure_communication as communication, bt.amount,ab.entry_city, " & _
        '      "date_format(date_add(c.customers_abo_validityto,interval -1 month) ,'%Y-%m-%d')as date_added,c.customers_abo_validityto ," & _
        '     " date_format(date_add(now() , interval 10 day) ,'%d/%m/%y') as limit_date_payment "


        Sql = "SELECT pa.*,c.*,p.*,ps.name payment_status_name,ab.*," & _
            " p.communication," & _
            " date(date_add(now() , interval " & nb_limitdaysPayment & " day)) as limit_date_payment " & _
            " FROM customers c join payment p on c.customers_id = p.customers_id " & _
            " left join products_abo pa on c.customers_abo_type = pa.products_id" & _
            " left join address_book ab on ab.address_book_id = c.customers_default_address_id and c.customers_id = ab.customers_id " & _
            " left join payment_status ps on p.payment_status = ps.id " & _
            " where date(p.date_added) >= date('" & PlushTools.ClsDate.formatDate(date_print_start) & "') " & _
            " and date(p.date_added) <= date('" & PlushTools.ClsDate.formatDate(date_print_end) & "') " & _
             strvaliduser & customerStr & _
            " order by  c.customers_language ASC "

        Return Sql

    End Function
    Public Shared Function GetDataPaymentCustomer(ByVal nb_limitdaysPayment As Integer, Optional ByVal customer_id As Integer = 0) As String
        Dim Sql As String
        Dim customerStr As String = ""
        Dim strvaliduser As String = ""
        If customer_id > 0 Then
            customerStr = " And c.customers_id = " & customer_id
        End If

        strvaliduser = " c.customers_abo = 1 and customers_abo_suspended = 0 "


        Sql = "SELECT distinct pa.qty_credit,c.customers_gender,c.customers_language,c.customers_id, c.customers_firstname , c.customers_lastname,c.customers_email_address,p.*, " & _
            " c.customers_abo ,ab.entry_street_address, ab.entry_postcode,ab.entry_city " & _
            ",c.customers_abo_validityto ,c.customers_abo," & _
            " date(date_add(now() , interval " & nb_limitdaysPayment & " day)) as limit_date_payment " & _
            " FROM customers c join payment p on c.customers_id = p.customers_id " & _
            " join abo a on p.abo_id = a.abo_id and a.product_id <> (SELECT products_id  FROM products where products_title = 'ADULTSVOD') " & _
            " join products_abo pa on c.customers_abo_type = pa.products_id " & _
            " left join address_book ab on ab.address_book_id = c.customers_default_address_id and c.customers_id = ab.customers_id " & _
            " where " & strvaliduser & customerStr & " And p.amount > 0 And p.payment_status = " & PaymentOfflineData.StepPayment.WAITING_PAYMENT & _
             " and p.payment_method = " & ClsCustomersData.Payment_Method.VIREMENT & _
             " order by  c.customers_language ASC "

        Return Sql

    End Function
    Public Shared Function GetDataADULTSVODPaymentCustomer(ByVal nb_limitdaysPayment As Integer, Optional ByVal customer_id As Integer = 0) As String
        Dim Sql As String
        Dim customerStr As String = ""
        Dim strvaliduser As String = ""
        If customer_id > 0 Then
            customerStr = " And c.customers_id = " & customer_id
        End If

        strvaliduser = " c.customers_abo = 1 and customers_abo_suspended = 0 "


        Sql = "SELECT distinct pa.qty_credit,c.customers_gender,c.customers_language,c.customers_id, c.customers_firstname , c.customers_lastname,c.customers_email_address,p.*, " & _
            " c.customers_abo ,ab.entry_street_address, ab.entry_postcode,ab.entry_city " & _
            ",c.customers_abo_validityto ,c.customers_abo," & _
            " date(date_add(now() , interval " & nb_limitdaysPayment & " day)) as limit_date_payment " & _
            " FROM customers c join payment p on c.customers_id = p.customers_id " & _
            " join abo a on p.abo_id = a.abo_id and a.product_id = (SELECT products_id  FROM products where products_title = 'ADULTSVOD')  " & _
            " join products_abo pa on c.customers_abo_type = pa.products_id " & _
            " left join address_book ab on ab.address_book_id = c.customers_default_address_id and c.customers_id = ab.customers_id " & _
            " where " & strvaliduser & customerStr & " And p.amount > 0 And p.payment_status = " & PaymentOfflineData.StepPayment.WAITING_PAYMENT & _
             " and p.payment_method = " & ClsCustomersData.Payment_Method.VIREMENT & _
             " order by  c.customers_language ASC "

        Return Sql

    End Function

    Public Shared Function GetDataPaymentCustomerDuplicata(ByVal date_print_start As DateTime, ByVal date_print_end As DateTime, ByVal nb_limitdaysPayment As Integer, Optional ByVal validUser As Boolean = True, Optional ByVal customer_id As Integer = 0) As String
        Dim Sql As String
        Dim customerStr As String = ""
        Dim strvaliduser As String = ""
        If customer_id > 0 Then

            customerStr = " And c.customers_id = " & customer_id

        End If

        If validUser Then
            strvaliduser = " and c.customers_abo = 1 and customers_abo_suspended = 0 "
        End If


        Sql = "SELECT pa.qty_credit,c.customers_gender,c.customers_language,c.customers_id, c.customers_firstname , c.customers_lastname,c.customers_email_address,p.*, " & _
            " c.customers_abo ,ab.entry_street_address, ab.entry_postcode,p.communication, p.amount,ab.entry_city " & _
            ",c.customers_abo_validityto ,c.customers_abo," & _
            " date(date_add(now() , interval " & nb_limitdaysPayment & " day)) as limit_date_payment " & _
            " FROM customers c join payment p on c.customers_id = p.customers_id " & _
            " join products_abo pa on c.customers_abo_type = pa.products_id" & _
            " left join address_book ab on ab.address_book_id = c.customers_default_address_id and c.customers_id = ab.customers_id " & _
            " where date(p.date_added) >= date('" & PlushTools.ClsDate.formatDate(date_print_start) & "') " & _
            " and date(p.date_added) <= date('" & PlushTools.ClsDate.formatDate(date_print_end) & "') " & _
             strvaliduser & customerStr & " and p.amount > 0 " & _
            " and p.payment_method = " & ClsCustomersData.Payment_Method.VIREMENT & _
            " order by  c.customers_language ASC "

        Return Sql

    End Function

    Public Shared Function UpdateCustomersInRecoveryStep(ByVal nb_Waitdays As Integer) As String
        Dim sql As String
        ' update table payment 
        sql = " update payment p " & _
              " set payment_status = " & PaymentOfflineData.StepPayment.CREATE_RECOVERY & _
              ", last_modified = now() " & _
              ", user_modified = " & clsSession.user_id & _
              " where payment_status = " & PaymentOfflineData.StepPayment.PRINTED & " and date_add(p.last_modified,interval " & nb_Waitdays & " day) <= now() "

        Return sql

    End Function

    'Public Shared Function UpdateCustomersInOfflinePaymentRequest(ByVal id As Integer, ByVal amount As String) As String
    '    Dim sql As String
    '    ' update table payment 
    '    sql = "update payment set amount = amount - " & amount & ",last_modified = now(),user_modified = " & clsSession.user_id & _
    '    " where id = " & id

    '    Return sql

    'End Function
End Class
