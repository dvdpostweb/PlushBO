Public Class clsExport
    Public Shared Sub ExportXls(ByVal grid As DevExpress.XtraGrid.Views.Grid.GridView)
        If grid.RowCount = 0 Then Return
        Dim saveFile As New Windows.Forms.SaveFileDialog()
        saveFile.Filter = "Excel (*.xls)|*.xls "
        If (saveFile.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            grid.ExportToXls(saveFile.FileName)
        End If
    End Sub

    Public Shared Sub Print(ByVal doc As DevExpress.XtraPrinting.IPrintable)
        Dim system As New DevExpress.XtraPrinting.PrintingSystem
        Dim link As New DevExpress.XtraPrinting.PrintableComponentLink
        system.Links.Add(link)
        link.Component = doc
        link.CreateDocument(system)
        system.PageSettings.Landscape = True
        system.PageSettings.PaperKind = Drawing.Printing.PaperKind.A4
        system.PreviewFormEx.Show()

    End Sub
End Class
