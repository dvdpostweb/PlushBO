Public Class frmStatProductCritique
    Inherits BizzLib.frmGeneral_Browse

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MenuStrip As New PlushBuziness.contextMenu()

        Grid1.ContextMenuStrip = MenuStrip

        TabParameters.PageVisible = True
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

    Private Sub loadData(ByVal dt As DataTable)

        Grid1.DataSource = Nothing
        Grid1.Views(0).PopulateColumns()


        Grid1.DataSource = dt
        TabControl1.SelectedTabPage = TabResult
        clsDevExpress.AddHyperlinkDynamic(Grid1)
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

    Private Sub btnBestRating_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBestRating.Click
        Dim dt As DataTable
        dt = PlushBuziness.clsReviews.GetBestRatingProducts()
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(dt)
    End Sub



    Private Sub BtnBestControverseWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBestControverseWeek.Click
        Dim dt As DataTable
        dt = PlushBuziness.clsReviews.GetBestProductPolemique(True)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(dt)
    End Sub

    Private Sub btnBestRatingWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBestRatingWeek.Click
        Dim dt As DataTable
        dt = PlushBuziness.clsReviews.GetBestRatingProducts(True)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(dt)
    End Sub

    Private Sub BtnBestControverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBestControverse.Click
        Dim dt As DataTable
        dt = PlushBuziness.clsReviews.GetBestProductPolemique()
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(dt)
    End Sub
End Class