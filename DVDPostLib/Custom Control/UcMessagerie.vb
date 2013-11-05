

Public Class UcMessagerie


#Region "Messagerie"
    Private Enum Status
        VIEW
        REPLY
        [NEW]
    End Enum

    Private _newTicket As ucMessagesTicket

    Private _customers_id As Integer


    Private _CurrentStatus As Status
    Public ReadOnly Property CurrentMode() As Integer
        Get
            Return _CurrentStatus
        End Get
      
    End Property

    Private Sub ChangeMode(ByVal st As Status)

        _CurrentStatus = st


        Select Case _CurrentStatus
            Case Status.[NEW]

                btnNewTicket.Visible = True
                btnReply.Visible = False
                BtnSend.Visible = False
                GCNewTicket.Visible = True
                txtTitle.EditValue = Nothing
                cmbCategorieTicket.EditValue = -1

            Case Status.REPLY
                btnReply.Visible = False
                btnNewTicket.Visible = False
                BtnSend.Visible = True
                GCNewTicket.Visible = False

            Case Status.VIEW
                btnNewTicket.Visible = True
                btnReply.Visible = True
                BtnSend.Visible = False
                GCNewTicket.Visible = False

            Case Else

        End Select


    End Sub
    Public Property Customers_id() As Integer
        Get
            Return _customers_id
        End Get
        Set(ByVal value As Integer)
            _customers_id = value
        End Set
    End Property


    Private _language_id As Integer
    Public Property language_id() As Integer
        Get
            Return _language_id
        End Get
        Set(ByVal value As Integer)
            _language_id = value
        End Set
    End Property

    Private Sub ucDetail_Refreshcontrol(ByVal sender As Object)
        LoadMessagerie()
    End Sub
    Private Sub ucDetail_ChangeSize(ByVal sender As Object)
        Dim ucDetail As ucMessagesTicket = sender
        Dim start As Integer = scrollMessageTicket.Controls.IndexOf(ucDetail)
        Dim posStart As Integer = ucDetail.Height + ucDetail.Top
        If start > -1 Then
            start += 1
            For index As Integer = start To scrollMessageTicket.Controls.Count - 1
                scrollMessageTicket.Controls(index).Top = posStart
                posStart += scrollMessageTicket.Controls(index).Height
            Next
        End If

    End Sub

    Private Function calcPosition() As Integer
        Dim pos As Integer

        pos = 0

        For Each Item As Windows.Forms.Control In scrollMessageTicket.Controls
            pos = Item.Height + Item.Top
        Next


        Return pos
    End Function
    Private Sub GridViewTicketHistory_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewTicketHistory.FocusedRowChanged
        Dim dt As DataTable
        Dim ticket_id As Integer
        scrollMessageTicket.Controls.Clear()
        If GridViewTicketHistory.FocusedRowHandle < 0 Then Return
        ticket_id = GridViewTicketHistory.GetDataRow(GridViewTicketHistory.FocusedRowHandle)("id")

        If ticket_id > -1 Then

            dt = PlushBuziness.clsMessagerie.GetHistoryMessage(ticket_id, language_id)
            Dim ucDetail As ucMessagesTicket = Nothing
            Dim positionY As Integer = 0
            For Each dr As DataRow In dt.Rows

                ucDetail = New ucMessagesTicket(dr, customers_id)
                AddHandler ucDetail.ChangeSize, AddressOf ucDetail_ChangeSize
                AddHandler ucDetail.RefreshControl, AddressOf ucDetail_RefreshControl
                ucDetail.Width = scrollMessageTicket.Width
                ucDetail.Top = positionY
                positionY += ucDetail.Height
                scrollMessageTicket.Controls.Add(ucDetail)
            Next
            If ucDetail IsNot Nothing Then
                ucDetail.OpenView()

            End If
        End If
        ChangeMode(Status.VIEW)

    End Sub
    Private Sub addFirstControl(ByVal ctrl As Windows.Forms.Control)
        Dim index As Integer = 1
        For Each Item As Windows.Forms.Control In scrollMessageTicket.Controls
            scrollMessageTicket.Controls.SetChildIndex(Item, index)
            index += 1
        Next

        scrollMessageTicket.Controls.Add(ctrl)
        scrollMessageTicket.Controls.SetChildIndex(ctrl, 0)
    End Sub
    Private Sub btnReply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReply.Click
        Dim ticket_id As Integer
        If GridViewTicketHistory.FocusedRowHandle < 0 Then Return
        ticket_id = GridViewTicketHistory.GetDataRow(GridViewTicketHistory.FocusedRowHandle)("id")
        Dim ucDetail As ucMessagesTicket

        If ticket_id > -1 Then
            ucDetail = New ucMessagesTicket(ticket_id, Customers_id)
            AddHandler ucDetail.ChangeSize, AddressOf ucDetail_ChangeSize
            ucDetail.Width = scrollMessageTicket.Width
            addFirstControl(ucDetail)
            ucDetail_ChangeSize(ucDetail)

            _newTicket = ucDetail
        End If

        ChangeMode(Status.REPLY)

    End Sub
    Private Sub BtnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSend.Click
        Dim selectFocus As Integer
        _newTicket.send()
        ChangeMode(Status.VIEW)
        selectFocus = GridViewTicketHistory.FocusedRowHandle
        GridViewTicketHistory_FocusedRowChanged(Nothing, Nothing)
        LoadMessagerie()
        GridViewTicketHistory.FocusedRowHandle = selectFocus
    End Sub

    Private Sub btnNewTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewTicket.Click
        Dim dt As DataTable

        ChangeMode(Status.[NEW])
        dt = PlushBuziness.clsMessagerie.GetCategorieTicket()

        cmbCategorieTicket.Properties.ValueMember = "id"
        cmbCategorieTicket.Properties.DisplayMember = "name"
        cmbCategorieTicket.Properties.DataSource = dt

        cmbCategorieTicket.EditValue = Nothing

    End Sub

    Public Sub LoadMessagerie()
        Dim dt As DataTable

        dt = PlushBuziness.clsMessagerie.GetHistoryTicket(Customers_id)
        gridTicketHistory.DataSource = dt
        If dt.Rows.Count = 0 Then
            btnNewTicket_Click(Me, Nothing)
            Return
        End If
        GridViewTicketHistory.SelectRow(0)
        GridViewTicketHistory.FocusedRowHandle = 0
        GridViewTicketHistory_FocusedRowChanged(GridViewTicketHistory, Nothing)

    End Sub
    Private Sub btnSaveTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTicket.Click
        Dim category_id As Integer
        ChangeMode(Status.VIEW)

        If txtTitle.EditValue IsNot Nothing And cmbCategorieTicket.EditValue Is Nothing Then
            category_id = -1
        ElseIf txtTitle.EditValue Is Nothing And cmbCategorieTicket.EditValue IsNot Nothing Then
            category_id = cmbCategorieTicket.EditValue
        Else
            MsgBox("il faut entrer une categorie ou un titre mais pas les deux ", MsgBoxStyle.Critical)
            Return
        End If
        PlushBuziness.clsMessagerie.GetCreateTicket(Customers_id, txtTitle.EditValue, category_id)
        LoadMessagerie()
        btnReply_Click(sender, e)

    End Sub

    Private Sub btnCancelTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelTicket.Click
        ChangeMode(Status.VIEW)
    End Sub
#End Region


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

   
End Class
