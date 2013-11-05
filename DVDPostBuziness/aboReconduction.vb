Public Class aboReconduction
    ' Inherits BizzLib.clsBKGenericClass
    Dim _ds As New DataSet
    Dim _FutureCredit As Integer
    Dim _FutureDVDAtHome As Integer = 0
    Dim _FutureNorm As Integer = 0
    Dim _FutureAdult As Integer = 0
    Dim _ActionCode As Integer '2= upgrade, 3=DownGrade
    Public codeValue As Integer = 0
    Public codetype As Integer = 0
    Public codeActiv As String = 0
    Public discType As String = 0
    Public nextDiscountCodeId As String
    Public customers_abo_discount_recurring_to_date As Integer
    Dim currentTime As Date
    Dim currentCustomers_id As Integer
    Public aboType As Integer
    Public updateActiv As Boolean = False 'use to make update when the disount must be change
    Public customers_abo_auto_stop_next_reconduction As Integer
    Dim customers_next_abo_type As Integer
    Dim customers_abo_type As Integer
    Dim customers_abo_dvd_adult As Integer
    Dim customers_abo_dvd_norm As Integer
    Dim amount As String

    ' jour avant d'arriver dans la table Payment_offline_request
    Public Const DAYS_WAIT_OFFLINE As Integer = 10
    Public Const PAYMENT_OFFLINE_STATUS_CREATED As Integer = 1



    Public Sub initialise()
        _ds.Clear()
        _FutureCredit = 0
        _FutureDVDAtHome = 0
        _FutureNorm = 0
        _FutureAdult = 0
        _ActionCode = 0 '2= upgrade, 3=DownGrade
        codeValue = 0
        codetype = 0
        codeActiv = 0
        discType = 0
        nextDiscountCodeId = 0
        currentCustomers_id = 0
        aboType = 0
        updateActiv = False
        customers_abo_auto_stop_next_reconduction = 0
        customers_next_abo_type = 0
        customers_abo_type = 0
        customers_abo_dvd_adult = 0
        customers_abo_dvd_norm = 0
        amount = ""

    End Sub


    Public Sub stopAbo(ByVal customers_id As Integer, ByVal abo_type As Integer, ByRef comment As String, ByVal reason_id As Integer, ByVal commentAboStop As String)

        Dim sql As String = ""
        Dim newComment As String = ""
        'If Not comment Is Nothing Then newComment = Replace(comment, "'", "\'")
        If Not commentAboStop Is Nothing Then commentAboStop = Replace(commentAboStop, "'", "\'")

        insertAbo(DvdPostData.ClsCustomersData.TypeAction.ACTION_STOP, customers_id, comment)
        'Dim _Result As Integer

        sql = DvdPostData.ClsCustomersData.GetUpdateAboStop(customers_id)
        DvdPostData.clsConnection.ExecuteNonQuery(sql)


        'If _Result <> 1 Then Throw New Exception("Wrong number of rows updated (" & _Result & ") trying to stop abo of customers_id " & customers_id)

        'insert the reason stop in the table "customers_abo_stop"
        sql = DvdPostData.ClsCustomersData.GetInsertHistoryAboStop(customers_id, reason_id, commentAboStop)
        DvdPostData.clsConnection.ExecuteNonQuery(sql)

        'Dim _objDVDPostMisc As New clsDVDPostMisc(SessionInfo)
        '52 = MAIL_ID_ABO_STOPPED_BY_DVDPOST
        '_objDVDPostMisc.SendMail(52, customers_id, abo_type)

        clsMail.SendMail(customers_id, 52)


        ' End If
    End Sub

    Public Sub insertAbo(ByVal action As Integer, ByVal customersId As Integer, ByVal comment As String)
        Dim sql As String
        If Not comment Is Nothing Then
            comment = Replace(comment, "'", " ")
        Else
            comment = ""
        End If
        comment = comment + " " + DvdPostData.clsSession.user_id.ToString()

        sql = "insert into abo(customerid , Action , Date , product_id, payment_method,comment)" & _
                                      " select customers_id," & action & ", now(), customers_abo_type,customers_abo_payment_method_name,'" & comment & "'" & _
                                      " from customers c ,customers_abo_payment_method cpm where " & _
                                      " c.customers_id = " & customersId.ToString & "  And cpm.customers_abo_payment_method_id = c.customers_abo_payment_method and customers_abo = 1"
        DvdPostData.clsConnection.ExecuteNonQuery(sql)

    End Sub


    Public Sub insertPhoneActInBankTRansfert(ByVal customers_id As Integer, ByVal price As String)

        Dim sql As String
        Dim clsCust As ClsCustomers = New ClsCustomers()
        sql = DvdPostData.clsBatchBankTransfert.insertBankTransfert(customers_id, price, DvdPostData.ClsCustomersData.Payment_Method.PHONE)
        DvdPostData.clsConnection.ExecuteNonQuery(sql)

    End Sub


End Class



