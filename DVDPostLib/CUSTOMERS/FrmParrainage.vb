Public Class frmParrainage
    Inherits BizzLib.frmBKForm
    Private _dt As DataTable
    Private _sql As String

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        loadDataset()
        Main_Bar.Visible = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub loadDataset()


        _sql = PlushData.ClsParrainage.getActivationNotLinked()
        _dt = PlushData.clsConnection.FillDataSet(_sql)

        GridParrainage.DataSource = _dt.DefaultView

    End Sub
    Private Sub saveData()
        Me.BindingContext(_dt.DefaultView).EndCurrentEdit()
        PlushData.clsConnection.UpdateDataTableInDB(_dt, _sql)
        loadDataset()
    End Sub


    Private Sub GridViewParrainage_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridViewParrainage.ValidateRow
        saveData()
    End Sub

    Private Sub GridViewParrainage_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridViewParrainage.CellValueChanged
        saveData()
    End Sub
End Class