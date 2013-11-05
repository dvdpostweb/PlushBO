Imports System.Collections.Generic
Public Class ucCallsHistory

    Private lstValue As List(Of Integer)
    Private stateCurrent As StateCall
    Private Enum StateCall
        [NEW]
        VIEW
    End Enum
    Public Event initUpdateValue()

    Public Property customers_id() As Integer
        Get
            Return txtCallCustomers_id.EditValue
        End Get
        Set(ByVal value As Integer)
            txtCallCustomers_id.EditValue = value
        End Set
    End Property


    Public Property Reconductions() As Integer
        Get
            Return txtCallReconduction.EditValue
        End Get
        Set(ByVal value As Integer)
            txtCallReconduction.EditValue = value
        End Set
    End Property


    Public Property FT() As Boolean
        Get
            Return chkCallFt.Checked
        End Get
        Set(ByVal value As Boolean)
            chkCallFt.Checked = value
        End Set
    End Property

    Private Sub loadValueRadiobutton(ByVal rg As DevExpress.XtraEditors.RadioGroup, ByVal dv As DataView, ByVal key As String, ByVal value As String)

        Dim gpitem As DevExpress.XtraEditors.Controls.RadioGroupItem
        rg.Properties.Items.Clear()
        ' rg.Update()
        For Each drv As DataRowView In dv
            gpitem = New DevExpress.XtraEditors.Controls.RadioGroupItem()
            gpitem.Value = drv(key)
            gpitem.Description = drv(value)
            rg.Properties.Items.Add(gpitem)
        Next
        rg.SelectedIndex = -1

    End Sub

    Private Sub loadValueRadiobutton(ByVal rg As DevExpress.XtraEditors.RadioGroup, ByVal dt As DataTable, ByVal key As String, ByVal value As String)

        Dim gpitem As DevExpress.XtraEditors.Controls.RadioGroupItem
        ' rg.SelectedIndex = 0
        rg.Properties.Items.Clear()
        For Each dr As DataRow In dt.Rows
            gpitem = New DevExpress.XtraEditors.Controls.RadioGroupItem()
            gpitem.Value = dr(key)
            gpitem.Description = dr(value)
            rg.Properties.Items.Add(gpitem)
        Next


    End Sub
    Private Sub LoadContact()
        loadValueRadiobutton(rgContact, PlushBuziness.clsCallHistory.contacts, "id", "text")
    End Sub

    Private Sub loadNode(ByVal id As Integer)
        Dim dv As DataView
        dv = PlushBuziness.clsCallHistory.getChild(id)
        loadValueRadiobutton(rgCallDetail, dv, "id", "text")

        If dv.Count > 0 Then
            If dv(0)("parent_text") IsNot DBNull.Value Then
                lblTitle.Text = dv(0)("parent_text")
            End If

        End If
    End Sub
    Private Sub loadMainNode()
        Dim dv As DataView
        dv = PlushBuziness.clsCallHistory.getChild()
        loadValueRadiobutton(rgCallDetail, dv, "id", "text")

        If dv.Count > 0 Then
            If dv(0)("parent_text") Is DBNull.Value Then
                lblTitle.Text = "Raison d'appel"
            Else
                lblTitle.Text = dv(0)("parent_text")
            End If

        End If
        If Not lstValue Is Nothing Then
            lstValue.Clear()
        End If
    End Sub
    Private Sub InitData()

        pnlCallData.Visible = True
        pnlCallQuestionnaire.Visible = True
        txtCallStartDate.Text = String.Empty
        txtCallCustomers_id.Text = String.Empty
        txtCallEndDate.Text = String.Empty
        txtCallReconduction.Text = String.Empty
        chkCallFt.Checked = False
        rgContact.SelectedIndex = -1
        memCallComment.Text = String.Empty

        ManagedAction(0)

    End Sub

    Private Sub LoadData(ByVal dr As DataRow)
        LoadContact()

        pnlCallData.Visible = True
        pnlCallQuestionnaire.Visible = False
        txtCallStartDate.Text = dr("start_date")
        txtCallCustomers_id.Text = dr("customers_id")
        txtCallEndDate.Text = dr("end_date")
        txtCallReconduction.Text = dr("nb_reconduction")
        chkCallFt.Checked = dr("FT")
        rgContact.SelectedIndex = dr("contact_id") - 1
        memCallComment.Text = dr("comment")

        ManagedAction(0)


    End Sub
    Private Sub ChangeStateControl(ByVal c As Windows.Forms.Control, ByVal enabling As Boolean)

        c.Enabled = enabling
        If enabling = False Then
            c.ForeColor = Drawing.Color.Black
        End If
    End Sub

    Private Sub btnCallNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCallNew.Click

        stateCurrent = StateCall.[NEW]

        LoadContact()
        loadMainNode()
        InitData()
        lstValue = New List(Of Integer)()
        txtCallStartDate.Text = DateTime.Now()
        GridCallHistory.Visible = False
        pnlCallData.Visible = True
        pnlCallQuestionnaire.Visible = True

        btnFinish.Visible = False
        btnPrec.Visible = False
        btnSuivant.Visible = True


        RaiseEvent initUpdateValue()

    End Sub
    Private Sub loadPreviousRadioGroup()
        If rgCallDetail.SelectedIndex() = -1 Then Return
        Dim id As Integer = rgCallDetail.Properties.Items(rgCallDetail.SelectedIndex()).Value
        lstValue.Remove(id)

        If Not PlushBuziness.clsCallHistory.isMainCurrentNode() Then
            Dim parent_id As Integer
            id = PlushBuziness.clsCallHistory.Queue.Dequeue()
            parent_id = PlushBuziness.clsCallHistory.getParentid(id)

            If parent_id > -1 Then
                loadNode(parent_id)
            Else
                loadMainNode()
            End If
            rgCallDetail.SelectedIndex = rgCallDetail.Properties.Items.GetItemIndexByValue(UInteger.Parse(id))
        End If
        ManagedAction(id)
    End Sub
    Private Sub ManagedAction(ByVal id As Integer)

        If PlushBuziness.clsCallHistory.isFeuille(id) Then
            btnSuivant.Visible = False
            btnFinish.Visible = True

        Else
            btnSuivant.Visible = True
            btnFinish.Visible = False
        End If

        If PlushBuziness.clsCallHistory.isMainCurrentNode() Then
            btnPrec.Visible = False
        Else
            btnPrec.Visible = True
        End If

        Dim enable As Boolean
        enable = stateCurrent = StateCall.[NEW]

        ChangeStateControl(txtCallCustomers_id, False)
        ChangeStateControl(txtCallStartDate, False)
        ChangeStateControl(txtCallEndDate, False)
        ChangeStateControl(txtCallReconduction, False)
        ChangeStateControl(chkCallFt, False)

        ChangeStateControl(rgContact, enable)
        ChangeStateControl(memCallComment, enable)

    End Sub

    Private Sub loadNextRadioGroup()

        If rgCallDetail.SelectedIndex() = -1 Then Return
        Dim id As Integer = rgCallDetail.Properties.Items(rgCallDetail.SelectedIndex()).Value
        'rgCallDetail.SelectedIndex() = 0
        lstValue.Add(id)

        PlushBuziness.clsCallHistory.Queue.Enqueue(id)
        If Not PlushBuziness.clsCallHistory.isFeuille(id) Then
            loadNode(id)
            rgCallDetail.SelectedIndex() = 0
            id = rgCallDetail.Properties.Items(0).Value
        End If
        ManagedAction(id)
    End Sub
    Private Sub rgCallDetail_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCallDetail.SelectedIndexChanged
        If rgCallDetail.SelectedIndex() = -1 Then Return
        Dim id As Integer = rgCallDetail.Properties.Items(rgCallDetail.SelectedIndex()).Value
        ManagedAction(id)
        ' btnSuivant_Click(sender, e)
        ' Dim t As Threading.Thread

        '  t = New Threading.Thread(AddressOf loadRadioGroup)
        '   t.Start()
        ' loadNextRadioGroup()
    End Sub

    Private Sub btnSuivant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuivant.Click
        loadNextRadioGroup()

    End Sub

    Private Sub btnPrec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrec.Click
        loadPreviousRadioGroup()
    End Sub
    Public Sub LoadHistory(ByVal customers_id As Integer)
        GridCallHistory.DataSource = PlushBuziness.clsCallHistory.Loadhistory(customers_id)
        GridCallHistory_FocusedRowChanged(GridCallHistory, Nothing)
        pnlCallQuestionnaire.Visible = False
    End Sub
    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinish.Click

        If rgContact.SelectedIndex > -1 Then
            Dim id As Integer = rgCallDetail.Properties.Items(rgCallDetail.SelectedIndex()).Value
            If Not lstValue.Contains(id) Then
                lstValue.Add(id)
            End If
            PlushBuziness.clsCallHistory.SaveValue(lstValue, _
                                                    txtCallCustomers_id.EditValue, _
                                                    chkCallFt.Checked, _
                                                    txtCallReconduction.EditValue, _
                                                     rgContact.Properties.Items(rgContact.SelectedIndex()).Value, _
                                                    memCallComment.Text, _
                                                    txtCallStartDate.EditValue, _
                                                    Now())
            MsgBox("appel terminé")
            pnlCallData.Visible = False
            pnlCallQuestionnaire.Visible = False
            GridCallHistory.Visible = True
            LoadHistory(txtCallCustomers_id.EditValue)
        Else
            MsgBox("choisir un type de contact avant de sauver")
        End If

    End Sub

    Private Sub GridCallHistory_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewCallHistory.FocusedRowChanged
        Dim dr As DataRow
        Dim result As String
        dr = GridViewCallHistory.GetDataRow(GridViewCallHistory.FocusedRowHandle)
        stateCurrent = StateCall.VIEW
        If (Not dr Is Nothing) Then
            result = PlushBuziness.clsCallHistory.LoadValue(dr("id"))
            lblCallValues.Text = result
            LoadData(dr)
            GridCallHistory.Visible = True
        Else
            GridCallHistory.Visible = False
            pnlCallData.Visible = False
            lblCallValues.Text = ""
        End If
    End Sub
End Class
