Public Class frmSmartTV
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

        clsDevExpress.sessionInfo = SessionInfo
    End Sub

    Private Sub loadData(ByVal sql As String)

        Dim dt As DataTable
        dt = PlushData.clsConnection.FillDataSet(sql, PlushData.clsConnection.typeAccessDb.WRITE)
        ' dt = DvdPostData.clsConnection.FillDataSet(sql)
        Grid1.DataSource = Nothing
        Grid1.Views(0).PopulateColumns()


        Grid1.DataSource = dt
        TabControl1.SelectedTabPage = TabResult
        ' clsDevExpress.AddHyperlinkDynamic(Grid1)
    End Sub

    Private Sub btnAppUsedByCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppUsedByCustomers.Click

        Dim sql As String
        sql = PlushData.clsSmartTV.GetSelectCustomersUseSmartTVApplication(txtFromDate.EditValue, txtToDate.EditValue, ConvertToSmartTVNumber(cmbSmartTV.Text))

        loadData(sql)
    End Sub

    Private Sub brnVODWatchedByCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnVODWatchedByCust.Click
        Dim sql As String
        sql = PlushData.clsSmartTV.GetSelectSmartTVWatched(txtFromDate.EditValue, txtToDate.EditValue, ConvertToSmartTVNumber(cmbSmartTV.Text))

        loadData(sql)
    End Sub

    Private Sub btnMostWatched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostWatched.Click
        Dim sql As String
        sql = PlushData.clsSmartTV.GetSelectSmartTVMostWatchedMovies(txtFromDate.EditValue, txtToDate.EditValue, ConvertToSmartTVNumber(cmbSmartTV.Text))

        loadData(sql)
    End Sub

    Private Function ConvertToSmartTVNumber(ByVal tv As String) As Integer
        If tv = "Samsung" Then Return 4
        If tv = "LG" Then Return 3
        If tv = "Philips" Then Return 7

    End Function

End Class