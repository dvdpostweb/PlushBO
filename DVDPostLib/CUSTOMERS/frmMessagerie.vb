Public Class frmMessagerie
    Inherits BizzLib.frmBKForm

    Private withevents _btnok As DevExpress.XtraBars.BarButtonItem = btnOK
    Private Sub loadDataset()
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsMessagerie.getViewUnreadMessage()
        dt = PlushData.clsConnection.FillDataSet(sql)
        GridMessagerie.DataSource = dt.DefaultView
        clsDevExpress.AddHyperlinkDynamic(GridMessagerie)

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        loadDataset()
        Dim menuStrip As New PlushBuziness.contextMenu()
        GridMessagerie.ContextMenuStrip = menuStrip
        Misc_Bar.Visible = True
        btnOK.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub GridViewMessagerie_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridViewMessagerie.DoubleClick
        Dim customers_id As Integer
        If GridViewMessagerie.GetDataRow(GridViewMessagerie.FocusedRowHandle) Is Nothing Then Return
        customers_id = GridViewMessagerie.GetDataRow(GridViewMessagerie.FocusedRowHandle)("customer_id")
        ClsCustomers.openFrmCustMaint(customers_id, Me.ParentForm, SessionInfo)

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _btnok.ItemClick
        loadDataset()
    End Sub
End Class