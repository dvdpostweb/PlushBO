Public Class frmPlainte

    Dim WithEvents _user1 As DevExpress.XtraBars.BarButtonItem = btnUser1

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Misc_Bar.Visible = True
        btnUser1.Caption = "status order : Retourné"
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

    End Sub

    Private Sub loadDataset()
        Dim dt As DataTable
        dt = PlushBuziness.clsOrders.GetselectOrderComplaint_Inadmissible()
        GridPlainte.DataSource = dt.DefaultView
        clsDevExpress.AddHyperlinkDynamic(GridPlainte)
        '  GridViewCallMeBrowse.PopulateColumns()

    End Sub

    Private Sub btnUser1_Click(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _user1.ItemClick

        Dim orders_id As Integer
        Dim status As Integer

        If GridViewPlainte.FocusedRowHandle < 0 Then Exit Sub
        orders_id = GridViewPlainte.GetDataRow(GridViewPlainte.FocusedRowHandle)("orders_id")
        status = GridViewPlainte.GetDataRow(GridViewPlainte.FocusedRowHandle)("orders_status")
        PlushBuziness.clsOrders.UpdateOrder(orders_id, PlushData.clsOdersStatusHistory.OrderStatusNew.RETURNED, status)
        loadDataset()
        MsgBox("terminé")
    End Sub



    Private Sub frmPlainte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loaddataset()
    End Sub
End Class