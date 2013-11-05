Public Class frmStatCustomerCritique
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


    Private Sub btnBestCritique_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBestCritique.Click
        Dim dt As DataTable
        dt = PlushBuziness.clsReviews.GetBestNumberCritique()
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(dt)
    End Sub


    Private Sub btnBestRating_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBestRating.Click
        Dim dt As DataTable
        dt = PlushBuziness.clsReviews.GetBestRating()
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(dt)
    End Sub

    Private Sub btnBestQualityDVDPOST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBestQualityDVDPOST.Click
        Dim dt As DataTable
        dt = PlushBuziness.clsReviews.getBestqualityDvdpostCritique()
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(dt)
    End Sub

    Private Sub btnBestQualityCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBestQualityCustomers.Click
        Dim dt As DataTable
        dt = PlushBuziness.clsReviews.GetBestCritiqueCustomers()
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(dt)
    End Sub

    Private Sub btnBestCritiqueWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBestCritiqueWeek.Click
        Dim dt As DataTable
        dt = PlushBuziness.clsReviews.GetBestNumberCritique(True)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(dt)
    End Sub

    Private Sub btnBestRatingWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBestRatingWeek.Click
        Dim dt As DataTable
        dt = PlushBuziness.clsReviews.GetBestRating(True)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(dt)
    End Sub

    Private Sub btnBestQualityDvdpostWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBestQualityDvdpostWeek.Click
        Dim dt As DataTable
        dt = PlushBuziness.clsReviews.getBestqualityDvdpostCritique(True)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(dt)
    End Sub

    Private Sub btnBestQualityCustomersWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBestQualityCustomersWeek.Click
        Dim dt As DataTable
        dt = PlushBuziness.clsReviews.GetBestCritiqueCustomers(True)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(dt)
    End Sub
End Class