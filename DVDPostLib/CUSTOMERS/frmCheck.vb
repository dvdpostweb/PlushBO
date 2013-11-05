Public Class frmCheck

    Dim WithEvents _user1 As DevExpress.XtraBars.BarButtonItem = btnUser1

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Misc_Bar.Visible = True
        btnUser1.Caption = "status order : retardé au retour"
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

    End Sub

    Private Sub loadDataset()
        Dim dt As DataTable
        dt = PlushBuziness.clsOrders.getOrderTwoWeekCheck()
        GridCheck.DataSource = dt.DefaultView
        clsDevExpress.AddHyperlinkDynamic(GridCheck)
        '  GridViewCallMeBrowse.PopulateColumns()

    End Sub

    Private Sub btnUser1_Click(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _user1.ItemClick

        Dim orders_id As Integer
        Dim status As Integer

        If GridViewCheck.FocusedRowHandle < 0 Then Exit Sub
        orders_id = GridViewCheck.GetDataRow(GridViewCheck.FocusedRowHandle)("orders_id")
        status = GridViewCheck.GetDataRow(GridViewCheck.FocusedRowHandle)("orders_status")
        PlushBuziness.clsOrders.UpdateOrder(orders_id, PlushData.clsOdersStatusHistory.OrderStatusNew.DELAYED_BACK, status)
        loadDataset()
        MsgBox("terminé")
    End Sub



    Private Sub frmCheck_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadDataset()
    End Sub
End Class