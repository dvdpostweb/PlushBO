Imports System.Windows.Forms


Public Class contextMenu
    Inherits System.Windows.Forms.ContextMenuStrip



    Private Sub copy_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MyBase.ItemClicked
        Dim grid As DevExpress.XtraGrid.GridControl
        Dim gridview As DevExpress.XtraGrid.Views.Grid.GridView
        'ContextMenuStrip1.SourceControl
        If TypeOf (SourceControl) Is DevExpress.XtraGrid.GridControl Then
            grid = SourceControl
            gridview = grid.FocusedView
        End If
        If Not IsNothing(gridview.FocusedValue) And Not DBNull.Value.Equals(gridview.FocusedValue) Then
            'If Not DBNull.Value.Equals(gridview.FocusedValue) Then
            copyMethod(gridview.FocusedValue)
            'End If
        End If

    End Sub

    Public Sub New()
        Me.Items.Add("copy") 
    End Sub

    Private Sub copyMethod(ByVal data As String)
        Clipboard.SetDataObject(data)
    End Sub

End Class
