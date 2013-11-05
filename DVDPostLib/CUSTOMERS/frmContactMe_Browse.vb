Public Class frmContactMe_Browse
    Inherits BizzLib.frmBKForm
    Private _dt As DataTable

    Dim WithEvents _user1 As DevExpress.XtraBars.BarButtonItem = btnUser1
    Private WithEvents _btnok As DevExpress.XtraBars.BarButtonItem = btnOK

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Misc_Bar.Visible = True
        btnUser1.Caption = "close call"
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnOK.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        Dim menuStrip As New PlushBuziness.contextMenu()
        GridcallMeBrowse.ContextMenuStrip = menuStrip

    End Sub
    Private Sub addRepositoryreason()

        Dim dt As DataTable
        Dim sql As String
        Dim repository_value As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        sql = PlushData.clsCallMeBrowse.getSelectValueReason()
        dt = PlushData.clsConnection.FillDataSet(sql)

        repository_value.DataSource = dt
        repository_value.DisplayMember = "name"
        repository_value.ValueMember = "id"
        GridcallMeBrowse.RepositoryItems.Add(repository_value)
        GridViewCallMeBrowse.Columns("reason").ColumnEdit = repository_value
    End Sub
    Private Sub addRepositoryday()

        Dim repository_value As New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit

        GridcallMeBrowse.RepositoryItems.Add(repository_value)
        GridViewCallMeBrowse.Columns("day").ColumnEdit = repository_value
    End Sub
    Private Sub addRepositoryHour()

        Dim dt As DataTable
        Dim sql As String
        Dim repository_value As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        sql = PlushData.clsCallMeBrowse.getSelectValueHour()
        dt = PlushData.clsConnection.FillDataSet(sql)

        repository_value.DataSource = dt
        repository_value.DisplayMember = "CodeDesc"
        repository_value.ValueMember = "CodeValue"
        GridcallMeBrowse.RepositoryItems.Add(repository_value)

        GridViewCallMeBrowse.Columns("hour").ColumnEdit = repository_value
    End Sub

    Private Sub ManageRepository()
        addRepositoryHour()
        addRepositoryreason()
        addRepositoryday()

        GridViewCallMeBrowse.Columns("day").OptionsColumn.AllowEdit = True
        GridViewCallMeBrowse.Columns("hour").OptionsColumn.AllowEdit = True
        GridViewCallMeBrowse.Columns("comment").OptionsColumn.AllowEdit = True
    End Sub
    Private Sub loadDataset()
        Dim sql As String

        sql = PlushData.clsCallMeBrowse.getselectCallMeBrowse()
        _dt = PlushData.clsConnection.FillDataSet(sql)
        GridcallMeBrowse.DataSource = _dt.DefaultView
        clsDevExpress.AddHyperlinkDynamic(GridcallMeBrowse)
        '  GridViewCallMeBrowse.PopulateColumns()

    End Sub
    Private Sub saveData()
        Me.BindingContext(_dt.DefaultView).EndCurrentEdit()
        PlushData.clsConnection.UpdateDataTableInDB(_dt, PlushData.clsCallMeBrowse.getselectforUpdate())
        loadDataset()
    End Sub


    Private Sub GridViewParrainage_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridViewCallMeBrowse.ValidateRow
        saveData()
    End Sub

    Private Sub GridViewParrainage_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridViewCallMeBrowse.CellValueChanged
        saveData()
    End Sub

    Private Sub btnUser1_Click(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _user1.ItemClick
        Dim Comment As String
        Dim id As Integer
        Dim sql As String
        If GridViewCallMeBrowse.FocusedRowHandle < 0 Then Exit Sub
        id = GridViewCallMeBrowse.GetDataRow(GridViewCallMeBrowse.FocusedRowHandle)("id")
        Comment = InputBox("Add your comment", "Comment", "")
        If Not Comment.Equals(String.Empty) Then
            sql = PlushData.clsCallMeBrowse.getUpdateCallMeBrowse(Comment, id)
            PlushData.clsConnection.ExecuteNonQuery(sql)
            loadDataset()
        End If
    End Sub

    Private Sub frmContactMe_Browse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadDataset()
        ManageRepository()
     
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _btnok.ItemClick
        loadDataset()
    End Sub
End Class