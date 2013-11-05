Public Class frmNoPaymentOgone

    Dim WithEvents _user1 As DevExpress.XtraBars.BarButtonItem = btnUser1

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
       
    End Sub

    Private Sub loadDataset()
        Dim dt As DataTable
        dt = PlushBuziness.clsOffLinePayments.GetNoPaymentOgone()
        GridNoPaymentOgone.DataSource = dt.DefaultView
        clsDevExpress.AddHyperlinkDynamic(GridNoPaymentOgone)
        GridViewNoPaymentOgone.Columns(0).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        '  GridViewCallMeBrowse.PopulateColumns()

    End Sub


    Private Sub frmPlainte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loaddataset()
    End Sub
End Class