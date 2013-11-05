Public Class ucMessagesTicket
    Public Event ChangeSize(ByVal sender As Object)
    Public Event RefreshControl(ByVal sender As Object)
    Private _customers_id As Integer

    '  Public Event Reload(ByVal sender As Object)
    Private TicketId As Integer
    Private TicketMessageId As Integer

    Private Sub NewHeader()
        lblDate.Text = Now()
        lblUser.Text = PlushData.clsSession.FullName
        Dim fnt As Drawing.Font
        fnt = New Drawing.Font(Me.Font.Name, 11, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        lblDate.Font = fnt
        lblUser.Font = fnt

        chkRead.Visible = False

    End Sub

    Private Sub LoadHeader(ByVal drTicketMsg As DataRow)
        lblDate.Text = drTicketMsg("created_at")
        TicketMessageId = drTicketMsg("id")
        If drTicketMsg("user_id") Is DBNull.Value Then
            lblUser.Text = String.Empty
        Else
            lblUser.Text = drTicketMsg("fullname")
        End If
        Dim fnt As Drawing.Font
        If drTicketMsg("is_read") = 0 Then
            fnt = New Drawing.Font(Me.Font.Name, 11, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

            chkRead.Checked = False
            chkRead.Visible = drTicketMsg("user_id") Is DBNull.Value
        Else
            fnt = New Drawing.Font(Me.Font.Name, 11, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
            chkRead.Visible = False
        End If

        lblDate.Font = fnt
        lblUser.Font = fnt

    End Sub
    Private Function ReplacedVariables(ByVal drTicketMsg As DataRow) As String
        Dim msg As String
        If drTicketMsg("messages_html") Is DBNull.Value Then Return ""
        msg = drTicketMsg("messages_html")
        If drTicketMsg("data") IsNot DBNull.Value Then
            msg = PlushBuziness.clsMail.replacevariableInMsg(msg, drTicketMsg("data"))
        End If

        Return msg
    End Function
    'Private Function convertMemStreamToString(ByVal ms As System.IO.MemoryStream) As String
    '    ms.Seek(0, IO.SeekOrigin.Begin)

    '    Dim jsonBytes As Byte()
    '    jsonBytes = New Byte(CType(ms.Length, Integer)) {}
    '    ms.Read(jsonBytes, 0, ms.Length)
    '    ' ms.Close()
    '    Return System.Text.Encoding.Unicode.GetString(jsonBytes)

    'End Function

    Private Sub LoadMsg(ByVal drTicketMsg As DataRow)
        Dim msg As String
        '  Dim bulk As String = ""
        msg = ReplacedVariables(drTicketMsg)
        Dim lst As Byte() = System.Text.Encoding.Unicode.GetBytes(msg)
        Dim memStream As System.IO.Stream = New System.IO.MemoryStream(lst)

        MessageTicketHtml.DocumentStream = memStream



    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        MessageTicketHtml = New System.Windows.Forms.WebBrowser
        MessageTicketHtml.Visible = False
        MessageTicketHtml.Height = 1000
        chksendMail.Visible = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal Ticket_id As Integer, ByVal customers_id As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        _customers_id = customers_id
        NewMessageTicketHtml = New DevExpress.XtraEditors.MemoEdit()

        NewMessageTicketHtml.Visible = True
        NewMessageTicketHtml.Height = 200
        NewHeader()
        chksendMail.Visible = True
        txtSubject.Visible = True
        lblSubject.Visible = True
        txtSubject.EditValue = ""

        TicketId = Ticket_id

        Me.Controls.Add(NewMessageTicketHtml)
        NewMessageTicketHtml.Top = GCHeaderMessage.Height
        NewMessageTicketHtml.Width = Me.Width
        Me.Height = GCHeaderMessage.Height + NewMessageTicketHtml.Height

    End Sub

    Public Sub New(ByVal drTicketMsg As DataRow, ByVal customers_id As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        _customers_id = customers_id
        MessageTicketHtml = New System.Windows.Forms.WebBrowser
        MessageTicketHtml.Visible = False
        MessageTicketHtml.Height = 1000
        LoadHeader(drTicketMsg)
        LoadMsg(drTicketMsg)
        TicketId = Integer.MaxValue
        chksendMail.Visible = False
        txtSubject.Visible = False
        lblSubject.Visible = False

    End Sub

    Public Sub OpenView()
        MessageTicketHtml.Visible = Not MessageTicketHtml.Visible

        If MessageTicketHtml.Visible Then
            Me.Controls.Add(MessageTicketHtml)
            MessageTicketHtml.Top = GCHeaderMessage.Height
            MessageTicketHtml.Width = Me.Width
            Me.Height = GCHeaderMessage.Height + MessageTicketHtml.Height

        Else
            Me.Controls.Remove(MessageTicketHtml)
            Me.Height = GCHeaderMessage.Height

        End If
        Me.Update()
        RaiseEvent ChangeSize(Me)
    End Sub
    Private Sub GCHeaderMessage_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GCHeaderMessage.DoubleClick
        OpenView()
    End Sub
    Private Function FormatHtml(ByVal str As String) As String

        str = Replace(str, "'", "\'")
        str = Replace(str, vbNewLine, "<br>")
        str = Replace(str, "’", "\'")

        Return str
    End Function
    Public Sub send()
        If NewMessageTicketHtml.Text <> String.Empty Then
            Dim variables As String
            variables = FormatHtml(NewMessageTicketHtml.Text.Trim())
            variables = PlushBuziness.clsMail.CreateVariableGeneric(variables)
            Dim mail_history_id As Integer = -1
            If chksendMail.Checked Then
                mail_history_id = PlushBuziness.clsMail.SendMail(_customers_id, PlushBuziness.clsMail.Mail.MAIL_PLUSH_REPLY, variables, txtSubject.EditValue)
            End If
            PlushBuziness.clsMessagerie.GetCreateMessage(TicketId, PlushBuziness.clsMail.Mail.MAIL_REPLY_MESSAGERIE, variables, mail_history_id)
            PlushBuziness.clsMessagerie.setFlagReadMessage(TicketId)

            RaiseEvent ChangeSize(Me)
        End If
    End Sub

    Private Sub chkRead_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRead.CheckStateChanged
        PlushBuziness.clsMessagerie.setFlagReadMessage(TicketMessageId, chkRead.Checked)
        RaiseEvent RefreshControl(Me)
    End Sub
End Class
