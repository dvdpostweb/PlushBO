Public Class frmWelcomeCall
    Inherits BizzLib.frmBKForm
    Private _dt As DataTable

    Dim WithEvents _user1 As DevExpress.XtraBars.BarButtonItem = btnUser1
    Private WithEvents _btnok As DevExpress.XtraBars.BarButtonItem = btnOK

    Private Sub frmWelcomeCall_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadDataset()
        ManageRepository()
    End Sub

    Private Sub loadDataset()
        Dim sql As String

        sql = PlushData.clsWelcomeCall.getselectWelcomeCall()
        Try
            _dt = PlushData.clsConnection.FillDataSet(sql)
        Catch ex As Exception
            Dim e As Integer = 1
        End Try
        GridWelcomeCall.DataSource = _dt.DefaultView
        clsDevExpress.AddHyperlinkDynamic(GridWelcomeCall)
        '  GridViewCallMeBrowse.PopulateColumns()

    End Sub

    Private Sub addRepositoryday()

        Dim repository_value As New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit

        GridWelcomeCall.RepositoryItems.Add(repository_value)
        GridViewWelcomeCall.Columns("welcomecall_day").ColumnEdit = repository_value
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
        GridWelcomeCall.RepositoryItems.Add(repository_value)

        GridViewWelcomeCall.Columns("welcomecall_hour").ColumnEdit = repository_value
    End Sub

    Private Sub ManageRepository()
        addRepositoryHour()
        'addRepositoryreason()
        addRepositoryday()

        GridViewWelcomeCall.Columns("welcomecall_day").OptionsColumn.AllowEdit = True
        GridViewWelcomeCall.Columns("welcomecall_hour").OptionsColumn.AllowEdit = True
        'GridViewCallMeBrowse.Columns("comment").OptionsColumn.AllowEdit = True
    End Sub

    Private Sub saveData()
        Me.BindingContext(_dt.DefaultView).EndCurrentEdit()
        PlushData.clsConnection.UpdateDataTableInDB(_dt, PlushData.clsWelcomeCall.getselectforUpdate())
        _dt.AcceptChanges()
        _dt.Clear()
        loadDataset()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Misc_Bar.Visible = True
        btnUser1.Caption = "close call"
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnOK.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        Dim menuStrip As New PlushBuziness.contextMenu()
        GridWelcomeCall.ContextMenuStrip = menuStrip

    End Sub

    Private Sub GridViewParrainage_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridViewWelcomeCall.ValidateRow
        saveData()
    End Sub

    Private Sub GridViewParrainage_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridViewWelcomeCall.CellValueChanged
        saveData()
    End Sub

    Private Sub btnUser1_Click(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _user1.ItemClick
        Dim Comment As String
        Dim id As Integer
        Dim sql As String
        If GridViewWelcomeCall.FocusedRowHandle < 0 Then Exit Sub
        id = GridViewWelcomeCall.GetDataRow(GridViewWelcomeCall.FocusedRowHandle)("customers_id")
        'Comment = InputBox("Add your comment", "Comment", "")
        'If Not Comment.Equals(String.Empty) Then
        sql = PlushData.clsWelcomeCall.getUpdateWelcomecall(id)
        PlushData.clsConnection.ExecuteNonQuery(sql)
        loadDataset()
        'End If
    End Sub

End Class