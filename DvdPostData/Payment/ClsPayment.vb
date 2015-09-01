Public Class ClsPayment
    Public Enum Payment_type
        RECONDUCTION = 1
        LOST_CHARGE = 2
        LONGTIME = 3
    End Enum

    Public Shared Function getIdLastPayment() As String
        Dim sql As String
        ' id   -> payment  
        sql = "SELECT max(id) as obid FROM payment"
        Return sql
    End Function

    'Public Shared Function GetSelectCpt_Payment_open() As String
    '    Dim sql As String
    '    sql = " select count(*) from payment p where p.customers_id = p.customers_id and p2.payment_status not in (" & PaymentOfflineData.GetListClose() & ")"
    '    Return sql
    'End Function
    Public Shared Function getSelectNoPaymentOgone(ByVal mail_id As String) As String
        Dim sql As String

        sql = " select t.customer_id customers_id,t.created_at from tickets t join message_tickets mt on t.id = mt.ticket_id" & _
              " where mt.mail_id in (" & mail_id & ")" & _
              " and mt.is_read = 0 group by t.customer_id order by t.created_at "

        Return sql
    End Function
    Public Shared Function GetLastPaymentStatus(ByVal id As Integer) As String
        Dim sql As String
        sql = " select payment_status from payment p where p.id = " & id
        Return sql
    End Function


    Public Shared Function GetCountOfCustomersUnpaidPayments(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = " select count(*) from payment p where p.payment_status not in (" & PaymentOfflineData.GetListPaid() & ", " & PaymentOfflineData.GetListClose() & ") and p.customers_id = " & customers_id
        Return sql
    End Function

    Public Shared Function GetLastPaymentByTypeJustOpenStatus(ByVal customers_id As Integer, ByVal payment_type As Payment_type) As String
        Dim sql As String

        sql = " select id,payment_status from payment " & _
              " where payment_status in (" & PlushData.PaymentOfflineData.StepPayment.CREATE_RECOVERY & "," & PlushData.PaymentOfflineData.StepPayment.MAIL_SENT & ") " & _
              " and payment_type_id = " & payment_type & _
              " and customers_id = " & customers_id & " order by 1 desc limit 1"
        Return sql
    End Function

    Public Shared Function GetLastPaymentOpenStatus(ByVal customers_id As Integer, ByVal method As ClsCustomersData.Payment_Method) As String
        Dim sql As String

        sql = " select id,payment_status,batch_id from payment " & _
              " where payment_status not in (" & PlushData.PaymentOfflineData.GetListClose() & ") " & _
              " and payment_method = " & method & _
              " and customers_id = " & customers_id & " order by 1 desc limit 1"
        Return sql
    End Function

    Public Shared Function GetLastPaymentOpenStatus(ByVal customers_id As Integer, ByVal batch_id As Integer, ByVal method As ClsCustomersData.Payment_Method) As String
        Dim sql As String

        sql = " select id,payment_status,batch_id from payment " & _
              " where payment_status not in (" & PlushData.PaymentOfflineData.GetListClose() & ") " & _
              " and payment_method = " & method & _
              " and customers_id = " & customers_id & _
              " and batch_id = " & batch_id & " order by 1 desc limit 1"
        Return sql
    End Function

    'Public Shared Function GetLastPaymentOpenNotCreateRecoveryStatus(ByVal customers_id As Integer, ByVal method As ClsCustomersData.Payment_Method) As String
    '    Dim sql As String

    '    sql = " select id,payment_status,batch_id from payment " & _
    '          " where payment_status not in (9, " & PlushData.PaymentOfflineData.GetListClose() & ") " & _
    '          " and payment_method = " & method & _
    '          " and customers_id = " & customers_id & " order by 1 desc limit 1"
    '    Return sql
    'End Function

    Public Shared Function GetLastPaymentOpenNotCreateRecoveryStatus(ByVal customers_id As Integer, ByVal method As ClsCustomersData.Payment_Method) As String
        Dim sql As String

        sql = " select id,payment_status,batch_id from payment " & _
              " where payment_status not in (9, " & PlushData.PaymentOfflineData.GetListClose() & ") " & _
              " and payment_method = " & method & _
              " and customers_id = " & customers_id & " order by 1 desc limit 1"
        Return sql
    End Function

    Public Shared Function GetUpdateClosePayment(ByVal id As Integer, ByVal new_status As PaymentOfflineData.StepPayment, ByVal last_status As PaymentOfflineData.StepPayment, ByVal id_movement As Integer) As String
        Dim sql As String

        sql = " update payment " & _
              " set payment_status = " & new_status & _
              " ,last_status_id = " & last_status & _
              " ,last_modified = now()" & _
              ", date_closed = now()" & _
              ", user_modified = " & clsSession.user_id & _
              ",account_movements_id = " & id_movement & _
              " where id = " & id
        Return sql

    End Function

    Public Shared Function GetUpdateClosePayment(ByVal id As Integer, ByVal new_status As PaymentOfflineData.StepPayment, ByVal last_status As PaymentOfflineData.StepPayment) As String
        Dim sql As String

        sql = " update payment " & _
              " set payment_status = " & new_status & _
              " ,last_status_id = " & last_status & _
              " ,last_modified = now()" & _
              ", date_closed = now()" & _
              ", user_modified = " & clsSession.user_id & _
              " where id = " & id
        Return sql

    End Function

    Public Shared Function GetUpdateAllPaymentStatus(ByVal old_status As PaymentOfflineData.StepPayment, ByVal new_status As PaymentOfflineData.StepPayment) As String
        Dim sql As String
        sql = "update payment set " & _
              " payment_status=" & new_status & _
              " ,last_modified=now() " & _
              ", user_modified = " & clsSession.user_id & _
              " where payment_status=" & old_status

        Return sql

    End Function
    Public Shared Function GetUpdatePaymentStatus(ByVal list_id As String, ByVal status As PaymentOfflineData.StepPayment) As String
        Dim sql As String
        sql = " update payment p " & _
              " set p.payment_status = " & status & _
              ", user_modified = " & clsSession.user_id & _
              ", last_modified = now() " & _
              " where p.id in (" & list_id & ")" & _
              " and payment_status = " & PaymentOfflineData.StepPayment.WAITING_PAYMENT

        Return sql
    End Function

    Public Shared Function GetUpdatePaymentStatus(ByVal id As Integer, ByVal status As PaymentOfflineData.StepPayment, ByVal old_status As PaymentOfflineData.StepPayment) As String
        Dim sql As String

        sql = " update payment " & _
              " set payment_status=" & status & _
              " ,last_modified=now()" & _
              ", user_modified = " & clsSession.user_id & _
              " where payment_status = " & old_status & _
              " and id = " & id
        Return sql
    End Function

    Public Shared Function GetUpdatePaymentStatus(ByVal customers_id As Integer, ByVal id As Integer, ByVal status As PaymentOfflineData.StepPayment) As String
        Dim sql As String

        sql = " update payment " & _
              " set payment_status=" & status & _
              " ,last_modified=now()" & _
              ", user_modified = " & clsSession.user_id & _
              " where customers_id = " & customers_id & _
              " and payment_status <> " & status & _
              " and id = " & id
        Return sql
    End Function

    Public Shared Function GetUpdatePaymentStatus(ByVal customers_id As Integer, ByVal id As Integer, ByVal batch_id As Integer, ByVal status As PaymentOfflineData.StepPayment) As String
        Dim sql As String

        sql = " update payment " & _
              " set payment_status=" & status & _
              " ,last_modified=now()" & _
              ", user_modified = " & clsSession.user_id & _
              " ,batch_id = " & batch_id & _
              " where customers_id = " & customers_id & _
              " and id = " & id
        Return sql
    End Function

    Public Shared Function CreatePayment(ByVal id_payment As Integer, ByVal method As ClsCustomersData.Payment_Method, ByVal customers_id As Integer, ByVal price As String, ByVal communication As String, ByVal payment_type As Payment_type) As String
        Dim sql As String
        sql = "insert into payment "
        sql = sql & " (id ,date_added, payment_method, abo_id , customers_id , amount , payment_status,user_modified , last_modified,communication,payment_type_id) "
        sql = sql & " values (" & id_payment & ",now()," & method & ",0," & customers_id & "," & price & "," & PaymentOfflineData.StepPayment.CREATE_RECOVERY & "," & clsSession.user_id & ",now(),'" & communication & "'," & payment_type & ")"
        Return sql
    End Function

    Public Shared Function CreatePayment(ByVal id_payment As Integer, ByVal abo_id As Integer, ByVal method As ClsCustomersData.Payment_Method, ByVal customers_id As Integer, ByVal price As String, ByVal domiciliation_number As String, ByVal communication As String) As String
        Dim sql As String
        sql = "insert into payment "
        sql = sql & " (id ,date_added, payment_method, abo_id , customers_id , amount , payment_status,user_modified , last_modified,domiciliation_number,communication) "
        sql = sql & " values (" & id_payment & ",now()," & method & "," & abo_id & "," & customers_id & "," & price & "," & PaymentOfflineData.StepPayment.WAITING_PAYMENT & "," & clsSession.user_id & ",now(),'" & domiciliation_number & "','" & communication & "')"
        Return sql
    End Function

    Public Shared Function CreatePayPalPaymentsHistory(ByVal payment_id As Integer, ByVal xml_request As String, ByVal xml_response As String, ByVal message As String, ByVal customers_id As Integer)
        Dim sql As String
        sql = "insert into paypal_payments_history "
        sql = sql & " (payment_id, pp_request, pp_response, created_date, message, customer_id) "
        sql = sql & " values (" & payment_id & ", '" & xml_request & "', '" & xml_response & "',now() , '" & message & "', " & customers_id & ")"
        Return sql
    End Function

    Public Shared Function CreatePayment(ByVal abo_id As Integer, ByVal method As ClsCustomersData.Payment_Method, ByVal customers_id As Integer, ByVal price As String) As String
        Dim sql As String
        sql = "insert into payment "
        sql = sql & " (id ,date_added, payment_method, abo_id , customers_id , amount , payment_status ,user_modified , last_modified) "
        sql = sql & " values (null,now()," & method & "," & abo_id & "," & customers_id & "," & price & "," & PaymentOfflineData.StepPayment.WAITING_PAYMENT & "," & clsSession.user_id & ",now())"
        Return sql
    End Function

    Public Shared Function CreatePayment(ByVal abo_id As Integer, ByVal method As ClsCustomersData.Payment_Method, ByVal customers_id As Integer, ByVal price As String, ByVal batch_id As Integer) As String
        Dim sql As String
        sql = "insert into payment "
        sql = sql & " (id ,date_added, payment_method, abo_id , customers_id , amount , payment_status , batch_id ,user_modified , last_modified) "
        sql = sql & " values (null,now()," & method & "," & abo_id & "," & customers_id & "," & price & "," & PaymentOfflineData.StepPayment.WAITING_PAYMENT & "," & batch_id & "," & clsSession.user_id & ",now())"
        Return sql
    End Function

    Public Shared Function UpdateBatchId(ByVal oldBatchid As Integer, ByVal newBatchId As Integer, ByVal customers_id As Integer) As String
        Dim sql As String
        ' payment 
        sql = " update payment " & _
              " set batch_id = " & newBatchId & _
              ", last_modified = now() " & _
              ", user_modified = " & clsSession.user_id & _
              " where customers_id = " & customers_id & " and batch_id = " & oldBatchid
        Return sql
    End Function
    ''' <summary>
    '''  changement de status via la gestion du workflow recovery 
    ''' </summary>
    ''' <param name="old_status"></param>
    ''' <param name="new_status"></param>
    ''' <param name="delay"></param>
    ''' <param name="isclosed"></param>
    ''' <param name="account_movements_id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function UpdateStatusAutomatic(ByVal old_status As Integer, _
                                                 ByVal new_status As Integer, _
                                                 ByVal delay As Integer, _
                                                 ByVal isclosed As Boolean, _
                                                 ByVal account_movements_id As String) As String
        Dim sql As String
        Dim sqlConditionForTransition As String
        sql = " update payment set " & _
              " payment_status=" & new_status & _
              ", last_modified=now() " & _
              ", user_modified = " & clsSession.user_id

        sqlConditionForTransition = " and to_days(date_add(last_modified,INTERVAL " & delay & " DAY))<=to_days(curdate())"

        If Not account_movements_id = Nothing Then
            sql = sql & ", account_movements_id = " & account_movements_id
        End If

        If isclosed Then
            sql = sql & ", date_closed=now(), last_status_id = " & old_status
        End If

        sql = sql & " where payment_status=" & old_status
        sql = sql & sqlConditionForTransition

        Return sql
    End Function

    Public Shared Function getPayment(ByVal customers_id As Integer, ByVal id As String) As String
        Dim sql As String
        sql = "select * from payment where customers_id = " & customers_id & " and id = " & id
        Return sql
    End Function

    Public Shared Function UpdateCommunication(ByVal id As Integer, ByVal communication As String) As String
        Dim sql As String
        sql = " update payment " & _
              " set communication = '" & communication & "'" & _
              ", user_modified = " & clsSession.user_id & _
              ",last_modified = now() where id = " & id
        Return sql
    End Function
    ''' <summary>
    ''' check the date of reconduction payment 
    ''' if the gap between two payment is early 1 month is not always good 
    ''' </summary>
    ''' <param name="d"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CheckReconductionLogiq(ByVal d As DateTime) As String
        Dim sql As String

        sql = " select * from payment p " & _
              " where p.date_added > '" & d & "' and p.payment_type_id = 1 and date(p.date_added) < " & _
              "        (select date_add(max(date(p2.date_added)),interval 30 day) &  " & _
              "        from payment p2 " & _
              "        where p2.payment_type_id = 1 and p2.date_added > '" & d & "' and p2.id <> p.id and p2.date_added < p.date_added and p2.customers_id = p.customers_id) "
        Return sql

    End Function

    Public Shared Function GetSelectPaymentStatuses() As String
        Dim sql As String
        sql = "SELECT id, name FROM payment_status "

        Return sql
    End Function
End Class
