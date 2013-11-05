Public Class clsDVDatHome
    Inherits clsCompta

#Region "Constantes DVD@Home"

    Enum IdFormStep
        FRM_STEP = 1113
    End Enum
    Enum TypeSend
        LETTER = 6
        LETTER2 = 7
        LETTER_AVOCAT = 8
    End Enum

    Enum StepDvdatHome
        CREATED_DVD = 10
        MAIL_TOSEND_DVD = 11
        MAIL_SENT_DVD = 12
        LETTER_TOSEND_DVD = 13
        LETTER_SENT_DVD = 14
        LETTER2_TOSEND_DVD = 24
        LETTER2_SENT_DVD = 25
        CALLED_DVD = 15
        PROMISE_TO_RETURN_DVD = 16
        LETTER_AVOCAT_TOSEND_DVD = 17
        LETTER_AVOCAT_SENT_DVD = 18
        CANCELED_DVD = 26
        RECEIVED_DVD = 27


    End Enum

    Public Const CLASS_STATUS As String = "DVD@HOME"

    Public Const DAYS_SEND_MAIL_DVDHOME As Integer = 5
    Public Const DAYS_SEND_LETTER_DVDHOME As Integer = 10
    Public Const DAYS_SEND_LETTER2_DVDHOME As Integer = 10
    Public Const DAYS_SEND_LETTER_AVOCAT_DVDHOME As Integer = 10

#End Region

    'Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
    '    'Add any initialization after the InitializeComponent() call
    '    'MyBase.New(CurrentSessionInfo)
    'End Sub

    Public Function StepNextDVDatHome(ByVal stepcurrent As StepDvdatHome) As StepDvdatHome


        Select Case stepcurrent
            Case StepDvdatHome.CREATED_DVD
                Return StepDvdatHome.MAIL_TOSEND_DVD
            Case StepDvdatHome.MAIL_TOSEND_DVD
                Return StepDvdatHome.MAIL_SENT_DVD
            Case StepDvdatHome.MAIL_SENT_DVD
                Return StepDvdatHome.LETTER_TOSEND_DVD
            Case StepDvdatHome.LETTER_TOSEND_DVD
                Return StepDvdatHome.LETTER_SENT_DVD
            Case StepDvdatHome.LETTER_SENT_DVD
                Return StepDvdatHome.LETTER2_TOSEND_DVD
            Case StepDvdatHome.LETTER2_TOSEND_DVD
                Return StepDvdatHome.LETTER2_SENT_DVD
            Case StepDvdatHome.CALLED_DVD
                Return StepDvdatHome.LETTER_AVOCAT_TOSEND_DVD
            Case StepDvdatHome.PROMISE_TO_RETURN_DVD
                Return StepDvdatHome.LETTER_AVOCAT_TOSEND_DVD
            Case StepDvdatHome.LETTER_AVOCAT_TOSEND_DVD
                Return StepDvdatHome.LETTER_AVOCAT_SENT_DVD
            Case Else
                Return Nothing

        End Select


    End Function

    Public Sub UpdateDvdStatus(ByVal old_status As Integer, ByVal new_status As Integer, ByVal delay As Integer, Optional ByVal isClosed As Boolean = False, Optional ByVal account_movements_id As String = Nothing)
        If old_status = 0 Then Exit Sub

        DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.PaymentOfflineData.SaveHistory(old_status, new_status))
        DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.PaymentOfflineData.UpdateStatus(old_status, new_status, delay, isClosed, account_movements_id))

    End Sub


    Private Shadows Sub ForcedupdateAllCustomerStepStatus(ByVal old_status As Integer)

        Dim new_status As Integer = StepNextDVDatHome(old_status)
        MyBase.ForcedUpdateAllCustomerStepStatus(old_status, new_status)

    End Sub

    Public Shadows Sub ForcedupdateStepStatus(ByVal old_status As Integer, ByVal payment_offline_request_id As Integer)

        Dim new_status As Integer = StepNextDVDatHome(old_status)
        MyBase.ForcedUpdateStepStatus(old_status, new_status, payment_offline_request_id)

    End Sub

    Public Sub ApplyAllTransitions()

        applyTransition(StepDvdatHome.CREATED_DVD)
        applyTransition(StepDvdatHome.MAIL_SENT_DVD)
        applyTransition(StepDvdatHome.LETTER_SENT_DVD)
        applyTransition(StepDvdatHome.LETTER2_SENT_DVD)
        applyTransition(StepDvdatHome.CALLED_DVD)
        applyTransition(StepDvdatHome.PROMISE_TO_RETURN_DVD)

    End Sub

    Public Sub applyTransition(ByVal old_status As Integer)

        ' Dim sql As String

        Dim new_Status As Integer = StepNextDVDatHome(old_status)
        Dim delay As Integer = DelayForStep(old_status)
        'sql = DvdPostData.PaymentOfflineData.getListStepChanged(delay, old_status)

        MyBase.UpdateStepStatus(old_status, new_Status, delay, False, Nothing)

    End Sub

    Public Function DelayForStep(ByVal stepcurrent As StepDvdatHome) As Integer


        Select Case stepcurrent
            Case StepDvdatHome.CREATED_DVD
                Return DAYS_SEND_MAIL_DVDHOME
            Case StepDvdatHome.MAIL_SENT_DVD
                Return DAYS_SEND_LETTER_DVDHOME
            Case StepDvdatHome.LETTER_SENT_DVD
                Return DAYS_SEND_LETTER2_DVDHOME
            Case StepDvdatHome.CALLED_DVD
                Return DAYS_SEND_LETTER_AVOCAT_DVDHOME
            Case StepDvdatHome.PROMISE_TO_RETURN_DVD
                Return DAYS_SEND_LETTER_AVOCAT_DVDHOME
            Case Else
                Return Nothing

        End Select


    End Function

    Private Function GetListDvdAtHome(ByVal customers_id As Integer, ByVal customers_lang As Integer) As String
        Dim dtDvdatHome As New DataTable
        dtDvdatHome = DvdPostData.clsConnection.FillDataSet(DvdPostData.PaymentOfflineData.GetDvdAtHome(customers_id, customers_lang))
        Dim StrLstProduct As String = ""
        For Each prodrow As DataRow In dtDvdatHome.Rows
            StrLstProduct = StrLstProduct & prodrow("products_name") & "<br/>"
        Next
        Return StrLstProduct

    End Function

    Public Function addProductsTitles(ByVal dtSource As DataTable) As DataTable

        If Not dtSource.Columns.Contains("products_titles") Then
            dtSource.Columns.Add("products_titles")
        End If
        Dim dt As DataTable = New DataTable()

        For Each row As DataRow In dtSource.Rows
            dt.Clear()
            dt = DvdPostData.clsConnection.FillDataSet(DvdPostData.PaymentOfflineData.GetDvdAtHome(row("customers_id"), row("customers_language")))
            For Each row1 As DataRow In dt.Rows
                row("products_titles") = row("products_titles") & " - " & row1("products_name").ToString
            Next
            ' _row("products_titles") = _row("products_titles") & " - "
        Next
        Return dtSource
    End Function


   

    Public Shadows Sub SendMail(ByVal stepCurrent As Integer)

        Dim dtCustomers As New DataTable

        dtCustomers = DvdPostData.clsConnection.FillDataSet(DvdPostData.PaymentOfflineData.GetStepPayment(stepCurrent))
        dtCustomers = addProductsTitles(dtCustomers)

        'dtPictureDVD = getPictureSDVD()
        If clsMsgError.MsgBox("Do you want to send " & dtCustomers.Rows.Count & " mail ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Dim ok As Boolean
            For Each rCustomer As DataRow In dtCustomers.Rows
                ok = clsMail.SendMail(rCustomer, clsMail.Mail.MAIL_DVDHOME, True)
                If Not ok Then Return
                ForcedupdateStepStatus(stepCurrent, rCustomer("payment_offline_request_id"))

            Next

            clsMsgError.MsgBox("mail sent")
        End If
    End Sub

   

   
    Public Shadows Sub DesignReport()
        MyBase.designReport()
    End Sub


    Public Shadows Sub sendLetter(ByVal report_id As Integer, ByVal stepCurrent As Integer)
        Dim dt As New DataTable
        dt = DvdPostData.clsConnection.FillDataSet(DvdPostData.PaymentOfflineData.GetStepPayment(stepCurrent))
        dt = addProductsTitles(dt)
        MyBase.sendLetter(dt, report_id)
        ForcedupdateAllCustomerStepStatus(stepCurrent)

    End Sub

    Public Function GetStep(ByVal stepcurrent As Integer) As String()
        Dim listAction() As String = {"Mail", "Letter", "Letter2", "Called", "Promise Return", "Letter Avocat", "Design Report"}

        Select Case stepcurrent
            Case StepDvdatHome.CREATED_DVD
                Dim listResult() As String = {listAction(6)}
                Return listResult
            Case StepDvdatHome.MAIL_TOSEND_DVD
                Dim listResult() As String = {listAction(0)}
                Return listResult
            Case StepDvdatHome.LETTER_TOSEND_DVD
                Dim listResult() As String = {listAction(1)}
                Return listResult
            Case StepDvdatHome.LETTER2_TOSEND_DVD
                Dim listResult() As String = {listAction(2)}
                Return listResult
            Case StepDvdatHome.LETTER2_SENT_DVD
                Dim listResult() As String = {listAction(3), listAction(4)}
                Return listResult
            Case StepDvdatHome.LETTER_AVOCAT_TOSEND_DVD
                Dim listResult() As String = {listAction(5)}
                Return listResult
            Case Else
                Return Nothing

        End Select

    End Function

    Public Sub ExecuteStep(ByVal GridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView, ByVal stepAction As String)
        Select Case stepAction

            Case "Mail"
                SendMail(clsDVDatHome.StepDvdatHome.MAIL_TOSEND_DVD)
            Case "Letter"
                sendLetter(clsDVDatHome.TypeSend.LETTER, clsDVDatHome.StepDvdatHome.LETTER_TOSEND_DVD)
            Case "Letter2"
                sendLetter(clsDVDatHome.TypeSend.LETTER, clsDVDatHome.StepDvdatHome.LETTER2_TOSEND_DVD)
            Case "Called"
                ToChangeStatus(clsDVDatHome.StepDvdatHome.CALLED_DVD, GridView1)
            Case "Promise Return"
                ToChangeStatus(clsDVDatHome.StepDvdatHome.PROMISE_TO_RETURN_DVD, GridView1)
            Case "Letter Avocat"
                sendLetter(clsDVDatHome.TypeSend.LETTER, clsDVDatHome.StepDvdatHome.LETTER_AVOCAT_TOSEND_DVD)
            Case "Design Report"
                DesignReport()
        End Select


    End Sub
End Class