' test branche
Public Class ClsBatchOgone

    Public Shared Function GetListUnpaid() As String
        Dim str As String

        str = PlushTools.clsEnum.getValueStrEnum(PaymentOfflineData.StepPayment.WAITING_PAYMENT) + "," + _
              PlushTools.clsEnum.getValueStrEnum(PaymentOfflineData.StepPayment.PAYBACK)

        Return str

    End Function

    Public Shared Function getLastIdInsert() As String
        Dim sql As String
        sql = " SELECT LAST_INSERT_ID() "
        Return sql
    End Function

    Public Shared Function getIdLastOgoneBatch() As String
        Dim sql As String

        sql = "SELECT if(isnull(max(ogone_batch_id)),0,max(ogone_batch_id)) as obid FROM ogone_batch"
        Return sql
    End Function


    Public Shared Function GetListCustomersRejectOgone(ByVal date_start As DateTime) As String
        ' payment 
        Dim sql As String
        sql = "SELECT distinct c.customers_id,o.batch_id,o.amount,p.products_model, " & _
              " c.ogone_card_type," & _
              " c.ogone_card_no," & _
              " c.ogone_exp_date " & _
              " FROM payment o " & _
              " JOIN customers c on c.customers_id = o.customers_id " & _
              " JOIN products p on c.customers_abo_type = p.products_id " & _
              " LEFT JOIN ( Select ab.customerid" & _
              "             from abo ab " & _
              "             join (select customerid,max(abo_id) abo_id from abo group by customerid) a on ab.abo_id = a.abo_id" & _
              "             where(ab.action = " & ClsCustomersData.TypeAction.ACTION_CHANGCARD & " and date(ab.Date) = date(date_add(now(),interval -1 day))) " & _
              " ) changecard_cust on changecard_cust.customerid = o.customers_id " & _
              " where date(o.date_added) = date('" & PlushTools.ClsDate.formatDate(date_start) & "')" & _
              " and o.payment_status  = " & PaymentOfflineData.StepPayment.CREATE_RECOVERY & _
              " and o.payment_method = " & ClsCustomersData.Payment_Method.OGONE & _
              " and changecard_cust.customerid is null "

        Return sql
    End Function


    Public Shared Function OgonePaymentHistory(ByVal new_status As String, ByVal ogone_id As Integer) As String
        Dim sql As String
        ' payment 

        sql = "insert into ogone_payment_status_history "
        sql = sql & " (ogone_payment_status_history_id,ogone_id,new_status,old_status,date_added)"
        sql = sql & " select null, id, " & new_status & ", payment_status, now()"
        sql = sql & " from payment dp "
        sql = sql & " where id=" & ogone_id

        Return sql
    End Function

    Public Shared Function OgonePaymentBatch(ByVal Batch_flux As String) As String
        Dim sql As String
        Batch_flux = Batch_flux.Replace("'", "''")
        sql = "insert into ogone_batch (ogone_batch_date, ogone_batch_output) values (now(), '" & Batch_flux & "')"
        Return sql
    End Function

    Public Shared Function UpdateBatchId(ByVal oldBatchid As Integer, ByVal newBatchId As Integer, ByVal customers_id As Integer) As String
        Dim sql As String
        ' payment 
        sql = ClsPayment.UpdateBatchId(oldBatchid, newBatchId, customers_id)
        Return sql
    End Function
    'Public Shared Function GetRowPaymentOgone(ByVal customers_id As Integer, ByVal id As Integer) As String
    '    Dim sql As String
    '    ' payment 
    '    sql = "select * from payment where customers_id = " & customers_id & _
    '          " And id = " & id & _
    '          " and payment_status in (" & DvdPostData.PaymentOfflineData.GetListOpen() & ")"

    '    Return sql
    'End Function
    'Public Shared Function GetPaymentOgone(ByVal customers_id As Integer, ByVal batch_id As Integer) As String
    '    Dim sql As String
    '    ' payment 
    '    sql = "select * from payment where customers_id = " & customers_id & _
    '          " And batch_id = " & batch_id & _
    '          " order by date_added limit 1"
    '    Return sql
    'End Function

    Public Shared Function GetLastPaymentOpenStatus_ogone(ByVal customers_id As Integer, ByVal batch_id As Integer) As String
        Dim sql As String
        ' payment 
        sql = ClsPayment.GetLastPaymentOpenStatus(customers_id, batch_id, ClsCustomersData.Payment_Method.OGONE)
        Return sql
    End Function


    Public Shared Function GetLastPaymentOpenStatus_ogone(ByVal customers_id As Integer) As String
        Dim sql As String
        ' payment 
        sql = ClsPayment.GetLastPaymentOpenStatus(customers_id, ClsCustomersData.Payment_Method.OGONE)
        Return sql
    End Function

    Public Shared Function GetLastPaymentOpenNotCreateRecoveryStatus_ogone(ByVal customers_id As Integer) As String
        Dim sql As String
        ' payment 
        sql = ClsPayment.GetLastPaymentOpenNotCreateRecoveryStatus(customers_id, ClsCustomersData.Payment_Method.OGONE)
        Return sql
    End Function

    'Public Shared Function GetLastPaymentStatus_ogone(ByVal customers_id As Integer) As String
    '    Dim sql As String
    '    ' payment 
    '    sql = "select max(id) from payment op where customers_id = " & customers_id & " group by customers_id "
    '    Return sql
    'End Function
    Public Shared Function GetUpdatePaymentStatus_ogone(ByVal customers_id As Integer, ByVal id As Integer, ByVal batch_id As Integer, ByVal status_ogone As PaymentOfflineData.StepPayment) As String
        Dim sql As String
        sql = ClsPayment.GetUpdatePaymentStatus(customers_id, id, batch_id, status_ogone)
        Return sql
    End Function



    'Public Shared Function GetUpdatePaymentStatus_ogone(ByVal customers_id As Integer, ByVal id As Integer, ByVal batch_id As Integer) As String
    '    Dim sql As String
    '    ' payment 
    '    sql = "update payment set "
    '    sql = sql & " payment_status=" & PaymentOfflineData.StepPayment.   ", "
    '    sql = sql & " last_modified=now() "
    '    sql = sql & " where customers_id = " & customers_id
    '    sql = sql & " and batch_id  = " & batch_id
    '    sql = sql & " and id = " & id
    '    sql = sql & " and payment_methode = " & ClsCustomersData.Payment_Method.OGONE
    '    Return sql
    'End Function

    Public Shared Function CreateOgonePayment(ByVal abo_id As Integer, _
                                             ByVal customers_id As Integer, _
                                             ByVal price As String, _
                                             ByVal batch_id As Integer) As String
        Dim sql As String
        sql = ClsPayment.CreatePayment(abo_id, ClsCustomersData.Payment_Method.OGONE, customers_id, price, batch_id)
        Return sql
    End Function

    Public Shared Function GetLastAboIdCustomers(ByVal customers_id As Integer, ByVal product_id As Integer) As String
        Dim sql As String

        sql = "select abo_id from abo where customerid = " & customers_id & " and product_id = " & product_id & " order by 1 desc limit 1"
        Return sql
    End Function

    Public Shared Function GetCustomersLastAboAction(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = "select Action from abo where customerid = " & customers_id & " order by 1 desc limit 1"
        Return sql
    End Function

    'Public Shared Function getUpdateStatusOgone(ByVal id As Integer, ByVal status As PaymentOfflineData.StepPayment) As String
    '    Dim sql As String
    '    ' payment 
    '    sql = "update payment set payment_status = " & status & ",last_modified = now()  where id = " & id
    '    Return sql
    'End Function
End Class