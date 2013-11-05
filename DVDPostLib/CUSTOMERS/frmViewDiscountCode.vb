Public Class frmViewDiscountCode
    Inherits BizzLib.frmBKForm

    Dim WithEvents _ExportExcel As DevExpress.XtraBars.BarButtonItem = MainBtns_btnExcel

    Private Sub loadDataset()
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsDiscountCode.GetSelectDiscountUsed()
        dt = PlushData.clsConnection.FillDataSet(sql)
        GridDiscountUse.DataSource = dt.DefaultView
        clsDevExpress.AddHyperlinkDynamic(GridDiscountUse)

    End Sub

    Private Sub btnexcel_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _ExportExcel.ItemClick
        SFDExportExcel.DefaultExt = "xls"
        SFDExportExcel.Filter = "Excel(*.xls)|*.xls"

        If SFDExportExcel.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GridDiscountUse.ExportToXls(SFDExportExcel.FileName)
        End If


        '  loadDataset()
    End Sub



    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        loadDataset()
        Misc_Bar.Visible = True

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class