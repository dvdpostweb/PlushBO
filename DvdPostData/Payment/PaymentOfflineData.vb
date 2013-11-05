Public Class PaymentOfflineData

    Enum StepPayment
        ALL_RECOVERY = 0 ' RECOVERY ALL STATUS 
        WAITING_PAYMENT = 1 ' open
        PAID = 2 ' close
        CANCEL = 3 ' close
        PAID_RECOVERY = 4 ' close 
        CANCEL_RECOVERY = 5 ' close
        '  RECOVERY = 6 ' open
        RECOVERY_DOM_ERROR = 7 ' open
        RECOVERY_INSOLVENT = 8 ' open
        CREATE_RECOVERY = 9 ' open Recovery
        MAIL_TO_SEND = 13 ' open Recovery
        MAIL_SENT = 14 ' open Recovery
        MAIL2_TO_SEND = 15 ' open Recovery
        MAIL2_SENT = 16 ' open Recovery
        LETTER_TO_SEND = 17 ' open Recovery
        LETTER_SENT = 18 ' open Recovery
        [CALL] = 10 ' open Recovery
        DELAY_PROCESS = 11 ' open Recovery
        RECALL_CUSTOMERS = 12 ' open Recovery
        LETTER_AVOCAT_TO_SEND = 19 ' open Recovery
        LETTER_AVOCAT_SENT = 20 ' open Recovery
        EUROFIDES_TO_SEND = 21 ' open Recovery
        EUROFIDES_SENT = 22 ' open Recovery
        PAYBACK = 23 ' open
        PAYBACKPAID = 24 ' close
        PRINTED = 25 ' open 
        REJECTDOMERROR = 26 ' open
        REJECTINSOLVENT = 27 ' open 
        IRRECOVERABLE = 28 ' close 
    End Enum
   
    Enum TypeSend
        LETTER = 3
        LETTER_AVOCAT = 4
        LETTER_BANKTRANSFER = 1103
        LETTER_BANKTRANSFER_ADULTSVOD = 1104
    End Enum

    Public Shared Function GetListRecoverySuspended() As String
        Dim str As String

        str = PlushTools.clsEnum.getValueStrEnum(StepPayment.LETTER_SENT) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.LETTER_AVOCAT_SENT) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.LETTER_AVOCAT_TO_SEND) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.EUROFIDES_SENT) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.EUROFIDES_TO_SEND)

        Return str

    End Function

    Public Shared Function GetListRecovery() As String
        Dim str As String

        str = PlushTools.clsEnum.getValueStrEnum(StepPayment.CREATE_RECOVERY) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.MAIL_TO_SEND) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.MAIL_SENT) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.MAIL2_TO_SEND) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.MAIL2_SENT) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.LETTER_TO_SEND) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.CALL) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.RECALL_CUSTOMERS) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.DELAY_PROCESS) + "," + _
              GetListRecoverySuspended()
        Return str

    End Function

    Public Shared Function GetListPaid() As String
        Dim str As String

        str = PlushTools.clsEnum.getValueStrEnum(StepPayment.PAID) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.PAID_RECOVERY) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.PAYBACKPAID)
        Return str

    End Function

    Public Shared Function GetListOpenNoRecovery() As String
        Dim str As String

        str = PlushTools.clsEnum.getValueStrEnum(StepPayment.WAITING_PAYMENT) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.CREATE_RECOVERY) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.PRINTED)

        Return str

    End Function


    Public Shared Function GetListOpen() As String
        Dim str As String

        str = PlushTools.clsEnum.getValueStrEnum(StepPayment.WAITING_PAYMENT) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.CREATE_RECOVERY) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.PRINTED) + "," + _
              GetListRecovery()
        Return str

    End Function

    Public Shared Function GetListClose() As String
        Dim str As String

        str = PlushTools.clsEnum.getValueStrEnum(StepPayment.CANCEL) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.CANCEL_RECOVERY) + "," + _
              PlushTools.clsEnum.getValueStrEnum(StepPayment.IRRECOVERABLE) + "," + _
              GetListPaid()
        Return str

    End Function




    Public Shared Function GetDvdAtHome(ByVal customers_id As String, ByVal customers_lang As Integer) As String
        Dim sql As String
        sql = "SELECT op.products_id, pd.products_name  FROM orders o " & _
                  " LEFT JOIN orders_products op on op.orders_id = o.orders_id " & _
                  " LEFT JOIN products_description pd on pd.products_id = op.products_id and language_id = " & customers_lang & _
                  " where o.customers_id = " & customers_id & "  AND o.orders_status = 2 " 'Expidited Only   " & _CustRow("customers_id") & " 

        Return sql
    End Function


    Public Shared Function GetSummary(ByVal TypeStatus As String) As String
        Dim sql As String

        ' sql = "select sum(if(p.payment_status is null,0,1)) total, pos.id as status_id, pos.name as status_name from payment_status pos " & _
        sql = "select sum(if(p.payment_status is null,0,1)) total, pos.id as status_id, pos.name as status_name,orderstep" & _
              " from payment_status pos " & _
              " left join payment p on pos.id=p.payment_status " & _
              " where orderStep > 0 " & _
              " group by pos.id " & _
              " UNION " & _
              " select count(*) total, 0 as status_id, 'ALL' as status_name ,0 orderstep " & _
              " from payment_status pos " & _
              " right join payment p on pos.id=p.payment_status " & _
              " where orderStep > 0 " & _
              " order by orderstep"
        Return sql
    End Function
    Public Shared Function GetPaymentCustomersOpen(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "SELECT date(p.date_added) date_reconduction ,amount,p.*,ab.* " & _
        " FROM payment p left join customers c on c.customers_id = p.customers_id " & _
        " left join payment_status pos on pos.id = p.payment_status" & _
        " left join address_book ab on c.customers_id = ab.customers_id and c.customers_default_address_id = ab.address_book_id " & _
        " where c.customers_id = " & customers_id & " and p.payment_status in ( " & GetListOpen() & ")"
        Return sql
    End Function
    Public Shared Function GetStepPaymentCustomer(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "SELECT * " & _
        " FROM payment p left join customers c on c.customers_id = p.customers_id " & _
        " left join payment_status pos on pos.id = p.payment_status" & _
        " left join address_book ab on c.customers_id = ab.customers_id and c.customers_default_address_id = ab.address_book_id " & _
        " where c.customers_id = " & customers_id
        Return sql

    End Function

    Public Shared Function GetStepPaymentALL() As String
        Dim sql As String
        sql = "SELECT * " & _
        " FROM payment p left join customers c on c.customers_id = p.customers_id " & _
        " left join payment_status pos on pos.id = p.payment_status" & _
        " left join customers_abo_payment_method capm on capm.customers_abo_payment_method_id = p.payment_method " & _
        " left join address_book ab on c.customers_id = ab.customers_id and c.customers_default_address_id = ab.address_book_id " & _
        " where pos.orderStep > 0 "
        Return sql

    End Function

    Public Shared Function GetStepPaymentPrint(ByVal StepPayment As Integer) As String
        Dim sql As String
        sql = "SELECT " & clsMassEmail.CapitalizeSql("c.customers_firstname", "c.customers_lastname") & " as customers_name," & _
               " c.customers_gender,p.amount as payment_offline_amount, " & _
               " p.communication as payment_offline_communication,p.id, " & _
               " date_format(p.date_added,'%d/%m/%Y ') as payment_offline_reason_date, " & _
               " c.email,c.customers_language,c.customers_id " & _
               " FROM payment p join customers c on c.customers_id = p.customers_id " & _
               " where p.payment_status = " & StepPayment
        Return sql
    End Function

    Private Shared Function GetColumsSelectSummary() As String
        Dim sql As String
        sql = "SELECT capm.customers_abo_payment_method_name, c.customers_abo_payment_method " & _
        ",c.customers_abo" & _
        ",ps.name" & _
        ",p.amount" & _
        ",p.id" & _
        ",p.communication" & _
        ",c.customers_id" & _
        ",p.date_added" & _
        ",p.last_modified" & _
        ",c.customers_lastname" & _
        ",c.customers_firstname" & _
        ",c.email" & _
        ",c.customers_telephone" & _
        ",c.customers_language " & _
        ",ab.entry_street_address" & _
        ",ab.entry_postcode " & _
        ",ab.entry_city " & _
        ",c.customers_abo_validityto" & _
        ",c.customers_language,p.payment_status,c.customers_next_abo_type"

        Return sql
    End Function
    Private Shared Function GetColumsSelect() As String
        Dim sql As String

        sql = "SELECT capm.customers_abo_payment_method_name, c.customers_abo_payment_method " & _
        ",c.customers_abo" & _
        ",ps.name" & _
        ",p.amount" & _
        ",p.id" & _
        ",p.communication" & _
        ",c.customers_id" & _
        ",p.date_added" & _
        ",p.last_modified" & _
        ",c.customers_lastname" & _
        ",c.customers_firstname" & _
        ",c.email" & _
        ",c.customers_telephone" & _
        ",c.customers_abo_validityto" & _
        ",c.customers_language" & _
        ",ab.entry_street_address" & _
        ",ab.entry_postcode " & _
        ",c.customers_abo_dvd_home_norm home_norm" & _
        ",c.customers_abo_dvd_home_adult home_adult" & _
        ",ab.entry_city " & _
        ",o.nb_orders" & _
        ",p_open.nb_payment_open" & _
        ",c.customers_info_date_account_created" & _
        ",code.code_type" & _
        ",code.code" & _
        ",last_order.lastorder_date,p.payment_status,c.customers_next_abo_type"

        Return sql
    End Function

    Public Shared Function GetStepPaymentSummary(ByVal StepPayment As Integer) As String
        Dim sql As String
        sql = GetColumsSelectSummary() & _
              "  FROM  payment p " & _
              " left join payment_status ps on ps.id = p.payment_status" & _
              " left join customers_abo_payment_method capm on capm.customers_abo_payment_method_id = p.payment_method " & _
              " left join customers c on c.customers_id = p.customers_id " & _
              " left join address_book ab on c.customers_id = ab.customers_id and c.customers_default_address_id = ab.address_book_id " & _
              " where p.payment_status = " & StepPayment
        Return sql
    End Function
    Public Shared Function GetStepPayment(ByVal StepPayment As Integer) As String
        Dim sql As String
        sql = GetColumsSelect() & _
        " FROM  payment p " & _
        " left join payment_status ps on ps.id = p.payment_status" & _
        " left join customers_abo_payment_method capm on capm.customers_abo_payment_method_id = p.payment_method " & _
        " left join customers c on c.customers_id = p.customers_id " & _
        " left join address_book ab on c.customers_id = ab.customers_id and c.customers_default_address_id = ab.address_book_id " & _
        " left join (select o.customers_id,count(*)nb_orders from orders o group by o.customers_id) o on o.customers_id = c.customers_id " & _
        " left join (select p2.customers_id,count(*) nb_payment_open " & _
        "            from payment p2 " & _
        "            where p2.payment_status in  (" & GetListRecovery() & ") " & _
        "            group by p2.customers_id ) p_open on p_open.customers_id = c.customers_id " & _
        " left join (select a.customerid,if(a.action = " & ClsCustomersData.TypeAction.ACTION_FROM_DISCOUNT & ",'D','A') code_type," & _
        "            if(a.action = " & ClsCustomersData.TypeAction.ACTION_FROM_DISCOUNT & "," & _
        "           (select max(discount_code) from discount_code where discount_code_id = a.code_id)," & _
        "           (select max(activation_code) from activation_code where activation_id = a.code_id)) code from abo a" & _
        "            join  " & _
        "           (select customerid,max(abo_id) abo_id from abo " & _
        "           where action in (" & ClsCustomersData.TypeAction.ACTION_FROM_ACTIVATION & "," & ClsCustomersData.TypeAction.ACTION_FROM_DISCOUNT & ") " & _
        "           group by customerid) lastcode on a.abo_id = lastcode.abo_id ) code on  code.customerid = c.customers_id " & _
        " left join (select customers_id,max(date_purchased) LastOrder_date " & _
        "            from orders group " & _
        "            by customers_id) last_order on c.customers_id = last_order.customers_id " & _
        " where p.payment_status = " & StepPayment

        Return sql

    End Function

    Public Shared Function GetStepPaymentWithAbo(ByVal StepPayment As Integer) As String
        Dim sql As String
        sql = "SELECT p.date_added date_reconduction,p.*,c.*,pos.*,ab.*, " & _
        "(SELECT pa.qty_credit from abo a " & _
        " join products_abo pa on a.product_id = pa.products_id " & _
        " where a.customerid = p.customers_id  order by a.abo_id desc  limit 1) as qty_credit " & _
        " FROM payment p left join customers c on c.customers_id = p.customers_id " & _
        " left join customers_abo_payment_method capm on capm.customers_abo_payment_method_id = c.customers_abo_payment_method" & _
        " left join payment_status pos on pos.id = p.payment_status" & _
        " left join address_book ab on c.customers_id = ab.customers_id and c.customers_default_address_id = ab.address_book_id " & _
        " where p.payment_status = " & StepPayment
        Return sql
    End Function

    Public Shared Function getListStepChanged(ByVal delay As Integer, ByVal old_status As Integer) As String

        Dim sqlConditionForTransition As String
        Dim sql As String
        sqlConditionForTransition = " and to_days(date_add(p.last_modified,INTERVAL " & delay & " DAY))<=to_days(curdate())"

        sql = "select p.id from payment p, customers c"
        sql = sql & " where c.customers_id=p.customers_id"
        sql = sql & " and p.payment_status=" & old_status
        sql = sql & sqlConditionForTransition

        Return sql
    End Function

    Public Shared Function SaveHistory(ByVal old_status As Integer, ByVal new_status As Integer) As String
        Dim sql As String
        sql = "insert into payment_status_history (payment_status_history_id ,id, new_status, old_status, date_added) "
        sql = sql & " select null, id, " & new_status & ", payment_status, now() "
        sql = sql & " from payment where id=" & old_status
        Return sql
    End Function
    Public Shared Function UpdateStatus(ByVal old_status As Integer, _
                                        ByVal new_status As Integer, _
                                        ByVal delay As Integer, _
                                        Optional ByVal isclosed As Boolean = False, _
                                        Optional ByVal account_movements_id As String = Nothing) As String
        Dim sql As String
        sql = ClsPayment.UpdateStatusAutomatic(old_status, new_status, delay, isclosed, account_movements_id)
        Return sql
    End Function

    Public Shared Function UpdateStatusOgone(ByVal customers_id As Integer, ByVal id As Integer, ByVal status_Recovery As PaymentOfflineData.StepPayment) As String
        Dim sql As String

        sql = ClsPayment.GetUpdatePaymentStatus(customers_id, id, status_Recovery)
        Return sql

    End Function


    Public Shared Function ForcedUpdateStatus(ByVal id As Integer, ByVal new_status As PaymentOfflineData.StepPayment, ByVal old_status As PaymentOfflineData.StepPayment) As String
        Dim sql As String
        sql = ClsPayment.GetUpdatePaymentStatus(id, new_status, old_status)
        Return sql

    End Function

    Public Shared Function ForcedUpdateAllCustomerStatus(ByVal old_status As PaymentOfflineData.StepPayment, ByVal new_status As PaymentOfflineData.StepPayment) As String
        Dim sql As String
        sql = ClsPayment.GetUpdateAllPaymentStatus(old_status, new_status)
        Return sql

    End Function

    Public Shared Function GetMail(ByVal mail_id As Integer, ByVal lang As Integer) As String
        Dim sql As String
        sql = "SELECT * FROM mail_messages WHERE mail_messages_id = '" & mail_id & "' and language_id = '" & lang & "'"
        Return sql
    End Function

    Public Shared Function GetReport(ByVal rept_id As Integer)
        Dim sql As String

        sql = "SELECT * FROM generalreport WHERE ReportID = " & rept_id & " order by ReportLang"
        Return sql

    End Function


    Public Shared Function GetDvdatHome(ByVal customers_id As Integer, ByVal customer_lang As Integer) As String
        Dim sql As String
        sql = "SELECT *  FROM orders o " & _
                      " LEFT JOIN orders_products op on op.orders_id = o.orders_id " & _
                      " LEFT JOIN products p on p.products_id = op.products_id " & _
                      " LEFT JOIN products_description pd on pd.products_id = op.products_id and language_id = " & customer_lang & _
                      " where o.customers_id = " & customers_id & "  AND o.orders_status = 2 " 'Expidited Only   " & _CustRow("customers_id") & " 

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
    Public Shared Function getMaxidMailHistory() As String
        Dim sql As String
        sql = "select if(isnull(max(mail_messages_sent_history_id)),0,max(mail_messages_sent_history_id)) from mail_messages_sent_history "
        Return sql
    End Function
    Public Shared Function SaveMailHistory(ByVal customers_id As Integer, ByVal mail_message_id As Integer, ByVal customers_lang As Integer, ByVal email_address As String, ByVal lstvariable As String)

        Dim sql As String

        sql = "insert into mail_messages_sent_history (date, customers_id, " & _
                 " mail_messages_id , language_id,customers_email_address,lstvariable) values( " & _
                 " now()," & customers_id & "," & mail_message_id & "," & _
                 customers_lang & ",'" & email_address & "','" & lstvariable & "') "

        Return sql
    End Function

    Public Shared Function UpdateCommunicationStructure(ByVal id As Integer, ByVal communication As String) As String
        Dim sql As String

        sql = "update payment p set "
        sql = sql & " p.communication='" & communication & "'"
        sql = sql & " where p.id = " & id

        Return sql

    End Function

    Public Shared Function getPaymentOfflineRequest(ByVal customers_id As Integer, ByVal id As String) As String
        Dim sql As String

        sql = ClsPayment.getPayment(customers_id, id)

        Return sql
    End Function

    Public Shared Function UpdateStatusPaymentOffline(ByVal id As Integer, ByVal status As StepPayment, Optional ByVal communication As String = "", Optional ByVal batch_id As Integer = -1) As String
        Dim sql As String
        Dim strcommunication As String = ""
        Dim strbatch As String = ""
        If Not communication Is String.Empty Then
            strcommunication = ",p.communication = '" & communication & "'"
        End If

        If batch_id > -1 Then
            strbatch = ",p.batch_id = " & batch_id
        End If

        sql = " update payment p  " & _
              " set payment_status = " & status & _
              strbatch & _
              strcommunication & _
             ",user_modified = " & clsSession.user_id & _
             ",last_modified = now() " & _
             " where id = " & id
        Return sql
    End Function


    '****** MATCHING RECOVERY -> PAYMENT ********************'
    '    ' matching recovery -> payment 
    '    update payment p
    'join ogone_payment op on p.reason_pk_name = 'OGONE' and p.reason_pk_value = op.ogone_id
    'set op.payment_status = 4,op.last_modified = now()
    'where p.payment_status in (2,3,4,5) and op.payment_status not in (2,3,4,5);


    'select * from payment p
    'join domiciliation_payment op on p.reason_pk_name = 'DOMICILIATION' and p.reason_pk_value = op.domiciliation_id
    'where p.payment_status in (2,3,4,5) and op.payment_status not in (2,3,4,5)
    ';
    'select * from payment p
    'join bank_transfert op on p.reason_pk_name = 'BANK TRANSFER' and p.reason_pk_value = op.id
    'where p.payment_status in (2,3,4,5) and op.payment_status not in (2,3,4,5)
    '****** MATCHING RECOVERY -> PAYMENT ********************

    ' ****************************************************************************************
    ' Draft a utiliser plus tard
    ' ****************************************************************************************

    'select payment_status,cpt_orders,count(*) from
    '(
    'select (select count(*) from orders o where o.customers_id = p.customers_id) cpt_orders,p.* from payment p

    ') x
    'group by payment_status,cpt_orders
    ';

    'update payment p join
    '(
    'select id from (
    'select (select count(*) from orders o where o.customers_id = p.customers_id) cpt_orders,p.*
    'from payment p
    'where not payment_status in (19,20,21) order by cpt_orders
    ') x
    'where cpt_orders = 0
    ') xx on xx.id = p.id

    'set p.payment_status = 19,p.last_modified = now();


    'select id from (
    'select (select count(*) from orders o where o.customers_id = p.customers_id) cpt_orders,p.*
    'from payment p
    'where not payment_status in (19,20,21) order by cpt_orders
    ') x
    'where cpt_orders = 1;

    'update payment p join
    '(
    'select pdetail.id from customers c join
    '(
    'select customers_id,count(*) cpt from payment where not payment_status in (19,20,21) group by customers_id
    ') p on c.customers_id = p.customers_id

    'join payment pdetail on pdetail.customers_id = c.customers_id
    'where
    'p.cpt = 1 and c.customers_abo_dvd_credit >= 50 and c.customers_abo_dvd_home_norm = 0 and c.customers_abo_dvd_home_adult = 0

    ') xx on xx.id = p.id

    'set p.payment_status = 19,p.last_modified = now();


    'select distinct c.customers_id from payment p
    'join customers c on c.customers_id = p.customers_id
    'where last_modified > '2010-05-12 16:00:00' and payment_status = 19
    'and c.customers_abo = 1;


    ' ********************************
    ' Error language mail 
    ' ********************************
    '  select date(date),mail_messages_id,count(*) from customers c join mail_messages_sent_history mmsh on c.customers_id = mmsh.customers_id
    ' where c.customers_language <> mmsh.language_id
    ' group by date(date),mail_messages_id
    ' order by date(date) desc
    ' ********************************
End Class