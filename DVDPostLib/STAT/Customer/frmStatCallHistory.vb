Public Class frmStatCallHistory
    Inherits BizzLib.frmGeneral_Browse

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MenuStrip As New PlushBuziness.contextMenu()

        Grid1.ContextMenuStrip = MenuStrip

        TabParameters.PageVisible = True
        txtFromDate.DateTime = Now().ToString(txtFromDate.Properties.EditFormat.FormatString)
        txtToDate.DateTime = Now().ToString(txtFromDate.Properties.EditFormat.FormatString)
        ' BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , True, False, False, True)
        CurrentDefaultSetID = cmbDefaultList.EditValue
        Misc_Bar.Visible = True
        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        If CurrentDefaultSetID <> 0 Then
            BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
            TabControl1.SelectedTabPage = TabResult
        Else
            TabControl1.SelectedTabPage = TabParameters
        End If
    End Sub

    Private Sub loadData(ByVal sql As String)

        Dim dt As DataTable
        dt = PlushData.clsConnection.FillDataSet(sql, PlushData.clsConnection.typeAccessDb.READ)
        ' dt = DvdPostData.clsConnection.FillDataSet(sql)
        Grid1.DataSource = Nothing
        Grid1.Views(0).PopulateColumns()

        Grid1.DataSource = dt
        TabControl1.SelectedTabPage = TabResult
        clsDevExpress.AddHyperlinkDynamic(Grid1)

    End Sub


    Private Sub btnNodeMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNodeMain.Click
        Dim sql As String
        sql = PlushData.clsStatCallHistory.getSelectMainNode(txtFromDate.EditValue, txtToDate.EditValue)
        'DvdPostData.clsConnection.timeoutMIN = 20
        loadData(sql)
    End Sub

    Private Sub BtnAboStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAboStop.Click
        Dim sql As String
        sql = PlushData.clsStatCallHistory.getSelectAboStop(txtFromDate.EditValue, txtToDate.EditValue)
        'DvdPostData.clsConnection.timeoutMIN = 20
        loadData(sql)
    End Sub

    Private Sub BtnCallHistoryContactUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCallHistoryContactUser.Click
        Dim sql As String
        sql = PlushData.clsStatCallHistory.getSelectContactUser(txtFromDate.EditValue, txtToDate.EditValue)
        'DvdPostData.clsConnection.timeoutMIN = 20
        loadData(sql)
    End Sub

    Private Sub btnRetention_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetention.Click
        Dim sql As String
        sql = PlushData.clsStatCallHistory.getSelectRetentionUser(txtFromDate.EditValue, txtToDate.EditValue)
        'DvdPostData.clsConnection.timeoutMIN = 20
        loadData(sql)
    End Sub

    Private Sub btnAllValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllValue.Click
        Dim sql As String
        sql = PlushData.clsStatCallHistory.getSelectAllValue(txtFromDate.EditValue, txtToDate.EditValue)
        'DvdPostData.clsConnection.timeoutMIN = 20
        loadData(sql)
    End Sub
End Class