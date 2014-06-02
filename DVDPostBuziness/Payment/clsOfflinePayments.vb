Imports PlushData
Public Class clsOffLinePayments
    Inherits clsCompta

    Private _CurrentOffLineID As Integer = 0
    Public OffLineRequestRow As DataRow = Nothing





#Region "Constantes"
#Region "Constantes RECOUVREMENT"

    Enum IdFormStep
        FRM_STEP = 1083
    End Enum




    Public Const CLASS_STATUS As String = "PAYMENT_OFFLINE"

    'Public Const PAYMENT_OFFLINE_STATUS_CANCELED As Integer = 19
    'Public Const PAYMENT_OFFLINE_STATUS_RECEIVED As Integer = 20
    'Public Const PAYMENT_OFFLINE_STATUS_RECEIVED_AT_EUROFIDES As Integer = 21


    Public Const DAYS_CREATE_RECOVERY As Integer = 7 '1
    Public Const DAYS_MAIL_SENT As Integer = 7
    Public Const DAYS_MAIL2_SENT As Integer = 7
    'Public Const DAYS_LETTER_SENT As Integer = 30
    Public Const DAYS_CALL As Integer = 7

    Public Const DAYS_DELAY_PROCESS As Integer = 15
    Public Const DAYS_RECALL As Integer = 10
    Public Const DAYS_LETTER_AVOCAT_SENT As Integer = 20
    Public Const DAYS_EUROFIDES_SENT As Integer = 30

#End Region



#End Region



    Public Function StepNextPaymentOffline(ByVal stepcurrent As PaymentOfflineData.StepPayment) As PaymentOfflineData.StepPayment


        Select Case stepcurrent
            Case PaymentOfflineData.StepPayment.CREATE_RECOVERY
                Return PaymentOfflineData.StepPayment.MAIL_TO_SEND


            Case PaymentOfflineData.StepPayment.MAIL_TO_SEND
                Return PaymentOfflineData.StepPayment.MAIL_SENT

            Case PaymentOfflineData.StepPayment.MAIL_SENT
                Return PaymentOfflineData.StepPayment.MAIL2_TO_SEND

            Case PaymentOfflineData.StepPayment.MAIL2_TO_SEND
                Return PaymentOfflineData.StepPayment.MAIL2_SENT

            Case PaymentOfflineData.StepPayment.MAIL2_SENT
                Return PaymentOfflineData.StepPayment.CALL

            Case PaymentOfflineData.StepPayment.CALL
                Return PaymentOfflineData.StepPayment.RECALL_CUSTOMERS

                'Case PaymentOfflineData.StepPayment.LETTER_SENT
                '    Return PaymentOfflineData.StepPayment.CALL

                'Case PaymentOfflineData.StepPayment.DELAY_PROCESS, _
                '     PaymentOfflineData.StepPayment.RECALL_CUSTOMERS

                '    Return PaymentOfflineData.StepPayment.LETTER_AVOCAT_TO_SEND

                'Case PaymentOfflineData.StepPayment.LETTER_AVOCAT_TO_SEND
                '    Return PaymentOfflineData.StepPayment.LETTER_AVOCAT_SENT

                'Case PaymentOfflineData.StepPayment.LETTER_AVOCAT_SENT
                '    Return PaymentOfflineData.StepPayment.EUROFIDES_TO_SEND

                'Case PaymentOfflineData.StepPayment.EUROFIDES_TO_SEND
                '    Return PaymentOfflineData.StepPayment.EUROFIDES_SENT

            Case Else
                Return Nothing

        End Select


    End Function

    Public Sub UpdatePaymentOfflineStatus(ByVal old_status As Integer, ByVal new_status As Integer, ByVal delay As Integer, Optional ByVal isClosed As Boolean = False, Optional ByVal account_movements_id As String = Nothing)
        If old_status = 0 Then Exit Sub

        PlushData.clsConnection.ExecuteNonQuery(PlushData.PaymentOfflineData.UpdateStatus(old_status, new_status, delay, isClosed, account_movements_id))

    End Sub

    Public Shadows Sub ForcedupdateAllCustomerStepStatus(ByVal old_status As Integer)

        Dim new_status As Integer = StepNextPaymentOffline(old_status)
        MyBase.ForcedUpdateAllCustomerStepStatus(old_status, new_status)

    End Sub

    Public Shadows Sub ForcedupdateStepStatus(ByVal old_status As Integer, ByVal payment_offline_request_id As Integer)

        Dim new_status As Integer = StepNextPaymentOffline(old_status)
        MyBase.ForcedUpdateStepStatus(old_status, new_status, payment_offline_request_id)

    End Sub


    Public Sub ApplyAllTransitions()
        'ABO
        applyTransition(PaymentOfflineData.StepPayment.CREATE_RECOVERY)

        SendMail(PaymentOfflineData.StepPayment.MAIL_TO_SEND, PlushBuziness.clsMail.Mail.MAIL_PLUSH_PAYMENT_NOT_RECEIVED)
        applyTransition(PaymentOfflineData.StepPayment.MAIL_SENT)

        SendMail(PaymentOfflineData.StepPayment.MAIL2_TO_SEND, PlushBuziness.clsMail.Mail.MAIL2_PLUSH_PAYMENT_NOT_RECEIVED)
        applyTransition(PaymentOfflineData.StepPayment.MAIL2_SENT)

        'sendLetter(PaymentOfflineData.TypeSend.LETTER, PaymentOfflineData.StepPayment.LETTER_TO_SEND)
        'applyTransition(PaymentOfflineData.StepPayment.LETTER_SENT)

        'applyTransition(PaymentOfflineData.StepPayment.CALL)
        'applyTransition(PaymentOfflineData.StepPayment.RECALL_CUSTOMERS)
        'applyTransition(PaymentOfflineData.StepPayment.LETTER_AVOCAT_SENT)

        PlushData.clsConnection.CommitTransaction(True)

    End Sub
    Public Sub applyTransition(ByVal old_status As Integer)

        Dim new_Status As Integer = StepNextPaymentOffline(old_status)
        Dim delay As Integer = DelayForStep(old_status)

        UpdatePaymentOfflineStatus(old_status, new_Status, delay, False, Nothing)
    End Sub

    Public Function DelayForStep(ByVal stepcurrent As PaymentOfflineData.StepPayment) As Integer


        Select Case stepcurrent
            Case PaymentOfflineData.StepPayment.CREATE_RECOVERY
                Return DAYS_CREATE_RECOVERY
            Case PaymentOfflineData.StepPayment.MAIL_SENT
                Return DAYS_MAIL_SENT
            Case PaymentOfflineData.StepPayment.MAIL2_SENT
                Return DAYS_MAIL2_SENT
            Case PaymentOfflineData.StepPayment.CALL
                Return DAYS_CALL
            Case PaymentOfflineData.StepPayment.DELAY_PROCESS
                Return DAYS_DELAY_PROCESS
            Case PaymentOfflineData.StepPayment.RECALL_CUSTOMERS
                Return DAYS_RECALL
            Case PaymentOfflineData.StepPayment.LETTER_AVOCAT_SENT
                Return DAYS_LETTER_AVOCAT_SENT

            Case Else
                Return Nothing

        End Select


    End Function

    Public Shadows Sub SendMail(ByVal stepCurrent As Integer, ByVal mail_id As clsMail.Mail)

        Dim dtCustomers As New DataTable
        Dim dtPictureDVD As DataTable = Nothing

        dtCustomers = PlushData.clsConnection.FillDataSet(PlushData.PaymentOfflineData.GetStepPaymentPrint(stepCurrent))
        If dtCustomers.Rows.Count = 0 Then Return
        ' au cas ou on rajouterait les 7 images
        If clsMsgError.MsgBox("Do you want to send " & dtCustomers.Rows.Count & " mail ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Dim ok As Boolean
            For Each rCustomer As DataRow In dtCustomers.Rows

                ok = clsMail.SendMail(rCustomer, mail_id)
                If Not ok Then
                    clsMsgError.MsgBox("mail to customers_id " & rCustomer("customers_id") & " not sent ")
                End If
                'Return
                ForcedupdateStepStatus(stepCurrent, rCustomer("id"))

            Next
            clsMsgError.MsgBox("sending mails for mail_id finished: OK = " & ok.ToString())
        End If
    End Sub


    Public Shadows Sub sendLetter(ByVal report_id As Integer, ByVal stepCurrent As Integer)
        Dim dt As New DataTable
        Dim sql As String = PlushData.PaymentOfflineData.GetStepPaymentWithAbo(stepCurrent)
        dt = PlushData.clsConnection.FillDataSet(sql)
        MyBase.sendLetter(dt, report_id, PaymentOfflineData.StepPayment.LETTER_TO_SEND = stepCurrent)
        ForcedupdateAllCustomerStepStatus(stepCurrent)
    End Sub


    Public Function GetStep(ByVal stepcurrent As Integer) As String()
        Dim listAction() As String = {"Mail", "Mail2", "Letter", "Recall", "Delay Process", "Letter Avocat", "EuroFides", "Design Report", "Irrecoverable", "Eurofides To Send"}

        Select Case stepcurrent
            Case PaymentOfflineData.StepPayment.CREATE_RECOVERY
                Dim listResult() As String = {listAction(7)}
                Return listResult
            Case PaymentOfflineData.StepPayment.CALL
                Dim listResult() As String = {listAction(3), listAction(4), listAction(8), listAction(9)}
                Return listResult
            Case PaymentOfflineData.StepPayment.RECALL_CUSTOMERS
                Dim listResult() As String = {listAction(4), listAction(8), listAction(9)}
                Return listResult
            Case PaymentOfflineData.StepPayment.DELAY_PROCESS
                Dim listResult() As String = {listAction(8), listAction(9)}
                Return listResult
            Case PaymentOfflineData.StepPayment.MAIL_TO_SEND
                Dim listResult() As String = {listAction(0)}
                Return listResult
            Case PaymentOfflineData.StepPayment.MAIL2_TO_SEND
                Dim listResult() As String = {listAction(1)}
                Return listResult
            Case PaymentOfflineData.StepPayment.LETTER_TO_SEND
                Dim listResult() As String = {listAction(2)}
                Return listResult
            Case PaymentOfflineData.StepPayment.LETTER_AVOCAT_TO_SEND
                Dim listResult() As String = {listAction(5), listAction(8), listAction(9)}
                Return listResult
            Case PaymentOfflineData.StepPayment.EUROFIDES_TO_SEND
                Dim listResult() As String = {listAction(6), listAction(8)}
                Return listResult

            Case Else
                Return Nothing

        End Select

    End Function

    Public Sub ExecuteStep(ByVal GridView1 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal stepAction As String)
        Select Case stepAction

            Case "Mail"
                'SendMail(PaymentOfflineData.StepPayment.MAIL_TO_SEND, clsMail.Mail.MAIL_RECOVERY)
            Case "Mail2"
                'SendMail(PaymentOfflineData.StepPayment.MAIL_TO_SEND, clsMail.Mail.MAIL2_RECOVERY)
            Case "Letter"
                sendLetter(PaymentOfflineData.TypeSend.LETTER, PaymentOfflineData.StepPayment.LETTER_TO_SEND)
            Case "Recall"
                ToChangeStatus(PaymentOfflineData.StepPayment.RECALL_CUSTOMERS, GridView1)
            Case "Delay Process"
                ToChangeStatus(PaymentOfflineData.StepPayment.DELAY_PROCESS, GridView1)
            Case "Letter Avocat"
                sendLetter(PaymentOfflineData.TypeSend.LETTER_AVOCAT, PaymentOfflineData.StepPayment.LETTER_AVOCAT_TO_SEND)
            Case "EuroFides"
                ToChangeStatus(PaymentOfflineData.StepPayment.EUROFIDES_SENT, GridView1, True)
            Case "Irrecoverable"
                ToChangeStatus(PaymentOfflineData.StepPayment.IRRECOVERABLE, GridView1, True)
            Case "Eurofides To Send"
                ToChangeStatus(PaymentOfflineData.StepPayment.EUROFIDES_TO_SEND, GridView1, False)
            Case "Design Report"
                designReport()
        End Select

    End Sub
    Public Shared Function getListOfflineUnPaid() As String
        Dim str As String = ""


        Return str
    End Function

    Public Shared Function GetNoPaymentOgone() As DataTable
        Dim sql As String
        Dim dt As DataTable

        'sql = PlushData.ClsPayment.getSelectNoPaymentOgone(clsMail.Mail.MAIL_PAYMENT_INVALID_OGONE & "," & clsMail.Mail.MAIL_PAYMENT_INVALID_OGONE_OLD)
        'dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt
    End Function
    Private Shared Function suspendedPayment() As Integer
        Dim sql As String
        Dim dt As DataTable
        Dim cpt_suspended As Integer
        Dim ok As Boolean
        ' with table suspension
        sql = PlushData.ClsCustomersData.GetSelectSuspended()
        dt = PlushData.clsConnection.FillDataSet(sql)


        For Each dr As DataRow In dt.Rows
            'ok = PlushBuziness.ClsWebServices.CallSuspended(dr("customers_id"), DateTime.Now, ClsWebServices.TypeSuspend.PAYMENT)
            If ok Then cpt_suspended += 1
        Next

        Return cpt_suspended
    End Function

    Private Shared Function UnsuspendedHolidays() As Integer
        Dim sql As String
        Dim dt As DataTable
        Dim cpt_unsuspended As Integer
        Dim ok As Boolean
        ' with table suspension
        sql = PlushData.clsAboSuspended.GetUnsuspendCustomersSetBackholidays()
        dt = PlushData.clsConnection.FillDataSet(sql)

        For Each dr As DataRow In dt.Rows
            'ok = PlushBuziness.ClsWebServices.CallUnSuspended(dr("customers_id"), DateTime.Now, ClsWebServices.TypeSuspend.HOLIDAYS)
            If ok Then cpt_unsuspended += 1
        Next

        Return cpt_unsuspended
    End Function


    Private Shared Function UnsuspendedPayment() As Integer
        Dim sql As String
        Dim dt As DataTable
        Dim cpt_unsuspended As Integer
        Dim ok As Boolean
        ' with table suspension
        sql = PlushData.ClsCustomersData.GetSelectUnsuspended()
        dt = PlushData.clsConnection.FillDataSet(sql)


        For Each dr As DataRow In dt.Rows
            'ok = PlushBuziness.ClsWebServices.CallUnSuspended(dr("customers_id"), DateTime.Now, ClsWebServices.TypeSuspend.PAYMENT)
            If ok Then cpt_unsuspended += 1
        Next

        Return cpt_unsuspended
    End Function
    Public Shared Function MatchingCommunicationStructureOrNameFirtsName() As Integer
        Dim sql As String
        Dim result As Integer = 0
        Dim dt As DataTable
        Dim cpt_find_coda As Integer


        Try
            PlushData.clsConnection.CreateTransaction(False)

            sql = PlushData.ClsMatching.GetMatchingByall()
            dt = PlushData.clsConnection.FillDataSet(sql)


            For Each dr As DataRow In dt.Rows

                sql = PlushData.ClsMatching.getUpdateBankAccountMovementsCustomersId(dr("account_movements_id"), dr("customers_id"))
                cpt_find_coda = PlushData.clsConnection.ExecuteNonQuery(sql)
                If cpt_find_coda <> 1 Then
                    Throw New Exception(" Error Matching Customers_id ")
                End If
                result += 1
            Next
            PlushData.clsConnection.CommitTransaction(True)
            Return result
        Catch ex As Exception
            PlushData.clsConnection.CommitTransaction(False)
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Matching, ex)
        End Try

    End Function

    Public Shared Function MatchingOfflineRequestCommunicationStructure() As Integer
        Dim sql As String
        Dim result As Integer = 0
        Dim dt As DataTable
        Dim cpt_find_recovery As Integer
        ' Dim cpt_find_coda As Integer
        Dim payment_status_close As Integer

        Dim matching_type As PlushData.ClsMatching.matching_type

        Try
            PlushData.clsConnection.CreateTransaction(False)

            sql = PlushData.ClsMatching.getSelectMatchingCommunicationStructure()
            dt = PlushData.clsConnection.FillDataSet(sql)


            For Each dr As DataRow In dt.Rows
                If dr("payment_status") = PlushData.PaymentOfflineData.StepPayment.WAITING_PAYMENT Or _
                   dr("payment_status") = PlushData.PaymentOfflineData.StepPayment.PRINTED Or _
                   dr("payment_status") = PlushData.PaymentOfflineData.StepPayment.CREATE_RECOVERY Then

                    payment_status_close = PlushData.PaymentOfflineData.StepPayment.PAID
                    matching_type = ClsMatching.matching_type.BANKTRANSFER
                Else
                    payment_status_close = PlushData.PaymentOfflineData.StepPayment.PAID_RECOVERY
                    matching_type = ClsMatching.matching_type.RECOVERY
                End If

                'sql = DvdPostData.ClsMatching.getUpdateBankAccountMovements(dr("account_movements_id"), matching_type, dr("customers_id"))
                'cpt_find_coda = DvdPostData.clsConnection.ExecuteNonQuery(sql)

                sql = PlushData.ClsMatching.ClosePayment(dr("account_movements_id"), dr("id"), dr("payment_status"), dr("customers_id"), payment_status_close, matching_type)
                cpt_find_recovery = PlushData.clsConnection.ExecuteNonQuery(sql)

                'If cpt_find_coda <> cpt_find_recovery Then
                '    Throw New Exception("Error Matching payment_ID = " & dr("id") & " Coda_id = " & dr("account_movements_id"))
                'End If
            Next
            PlushData.clsConnection.CommitTransaction(True)
            Return cpt_find_recovery
        Catch ex As Exception
            PlushData.clsConnection.CommitTransaction(False)
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Matching, ex)
        End Try

    End Function

    'matching of paymets and suspends customer who didn't pay two invoices
    Public Shared Sub matchingOffline()
        Dim user_id As Integer = clsSession.user_id

        Dim cpt_recovery As Integer
        Dim cpt_find_Open As Integer
        Dim cpt_unsuspended As Integer
        Dim cpt_suspended As Integer
        Dim cpt_unsuspended_holiday As Integer

        cpt_recovery = MatchingOfflineRequestCommunicationStructure()
        cpt_find_Open = MatchingCommunicationStructureOrNameFirtsName()
        'for suspension call webservice
        cpt_unsuspended = UnsuspendedPayment()
        cpt_suspended = suspendedPayment()
        cpt_unsuspended_holiday = UnsuspendedHolidays()


        If (cpt_recovery + cpt_find_Open + cpt_unsuspended + cpt_suspended + cpt_unsuspended_holiday > 0) Then
            clsMsgError.MsgBox( _
                   " Matching recovery : " & cpt_recovery & vbNewLine & _
                   " Finded customers : " & cpt_find_Open & vbNewLine & _
                   " Unsuspended : " & cpt_unsuspended & vbNewLine & _
                   " Suspended : " & cpt_suspended & vbNewLine & _
                   " Unsuspended Holiday : " & cpt_unsuspended_holiday)
        End If
    End Sub
End Class