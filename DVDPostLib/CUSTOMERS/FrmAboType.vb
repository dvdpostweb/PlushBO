Public Class frmAboType
    Inherits BizzLib.frmBKForm

    Private Sub loadDataset()
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.ClsCustomersData.GetAboType()
        dt = PlushData.clsConnection.FillDataSet(sql)
        GridAboType.DataSource = dt.DefaultView

    End Sub


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        loadDataset()
        Main_Bar.Visible = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class