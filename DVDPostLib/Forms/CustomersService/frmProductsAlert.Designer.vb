<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductsAlert
    Inherits BizzLib.frmBKForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GridProductsAlert = New DevExpress.XtraGrid.GridControl
        Me.GridViewProductsAlert = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.products_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_dvd_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.alert_comment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.delete = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnDeleted = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.alert_cre_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.comment_by = New DevExpress.XtraGrid.Columns.GridColumn
        Me.alert_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.btnAddProductsAlert = New DevExpress.XtraEditors.SimpleButton
        Me.memoAddComment = New DevExpress.XtraEditors.MemoEdit
        Me.txtProductsId = New DevExpress.XtraEditors.TextEdit
        Me.txtProductsDvdId = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.MemoSeeComment = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridProductsAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewProductsAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoAddComment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductsId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductsDvdId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoSeeComment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridProductsAlert
        '
        Me.GridProductsAlert.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridProductsAlert.EmbeddedNavigator.Name = ""
        Me.GridProductsAlert.FormsUseDefaultLookAndFeel = False
        Me.GridProductsAlert.Location = New System.Drawing.Point(27, 239)
        Me.GridProductsAlert.MainView = Me.GridViewProductsAlert
        Me.GridProductsAlert.Name = "GridProductsAlert"
        Me.GridProductsAlert.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.btnDeleted})
        Me.GridProductsAlert.Size = New System.Drawing.Size(812, 321)
        Me.GridProductsAlert.TabIndex = 4
        Me.GridProductsAlert.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewProductsAlert, Me.GridView2})
        '
        'GridViewProductsAlert
        '
        Me.GridViewProductsAlert.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.products_id, Me.products_dvd_id, Me.alert_comment, Me.delete, Me.alert_cre_date, Me.comment_by, Me.alert_id})
        Me.GridViewProductsAlert.GridControl = Me.GridProductsAlert
        Me.GridViewProductsAlert.Name = "GridViewProductsAlert"
        Me.GridViewProductsAlert.OptionsView.ColumnAutoWidth = False
        '
        'products_id
        '
        Me.products_id.Caption = "products_id"
        Me.products_id.FieldName = "products_id"
        Me.products_id.Name = "products_id"
        Me.products_id.OptionsColumn.AllowEdit = False
        Me.products_id.OptionsColumn.ReadOnly = True
        Me.products_id.Visible = True
        Me.products_id.VisibleIndex = 1
        '
        'products_dvd_id
        '
        Me.products_dvd_id.Caption = "products_dvd_id"
        Me.products_dvd_id.FieldName = "products_dvd_id"
        Me.products_dvd_id.Name = "products_dvd_id"
        Me.products_dvd_id.OptionsColumn.AllowEdit = False
        Me.products_dvd_id.OptionsColumn.ReadOnly = True
        Me.products_dvd_id.Visible = True
        Me.products_dvd_id.VisibleIndex = 2
        '
        'alert_comment
        '
        Me.alert_comment.Caption = "comment"
        Me.alert_comment.FieldName = "alert_comment"
        Me.alert_comment.Name = "alert_comment"
        Me.alert_comment.OptionsColumn.AllowEdit = False
        Me.alert_comment.OptionsColumn.ReadOnly = True
        Me.alert_comment.Visible = True
        Me.alert_comment.VisibleIndex = 3
        Me.alert_comment.Width = 304
        '
        'delete
        '
        Me.delete.Caption = "delete"
        Me.delete.ColumnEdit = Me.btnDeleted
        Me.delete.Name = "delete"
        Me.delete.Visible = True
        Me.delete.VisibleIndex = 5
        '
        'btnDeleted
        '
        Me.btnDeleted.AutoHeight = False
        Me.btnDeleted.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Delete", -1, True, True, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.btnDeleted.Name = "btnDeleted"
        Me.btnDeleted.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'alert_cre_date
        '
        Me.alert_cre_date.Caption = "alert_date"
        Me.alert_cre_date.FieldName = "alert_cre_date"
        Me.alert_cre_date.Name = "alert_cre_date"
        Me.alert_cre_date.OptionsColumn.AllowEdit = False
        Me.alert_cre_date.OptionsColumn.ReadOnly = True
        Me.alert_cre_date.Visible = True
        Me.alert_cre_date.VisibleIndex = 0
        '
        'comment_by
        '
        Me.comment_by.Caption = "comment_by"
        Me.comment_by.FieldName = "FullName"
        Me.comment_by.Name = "comment_by"
        Me.comment_by.OptionsColumn.AllowEdit = False
        Me.comment_by.OptionsColumn.ReadOnly = True
        Me.comment_by.Visible = True
        Me.comment_by.VisibleIndex = 4
        '
        'alert_id
        '
        Me.alert_id.Caption = "alert_id"
        Me.alert_id.FieldName = "alert_id"
        Me.alert_id.Name = "alert_id"
        Me.alert_id.OptionsColumn.AllowEdit = False
        Me.alert_id.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridProductsAlert
        Me.GridView2.Name = "GridView2"
        '
        'btnAddProductsAlert
        '
        Me.btnAddProductsAlert.Location = New System.Drawing.Point(700, 108)
        Me.btnAddProductsAlert.Name = "btnAddProductsAlert"
        Me.btnAddProductsAlert.Size = New System.Drawing.Size(104, 23)
        Me.btnAddProductsAlert.TabIndex = 37
        Me.btnAddProductsAlert.Text = "Add Products Alert"
        '
        'memoAddComment
        '
        Me.memoAddComment.Location = New System.Drawing.Point(443, 137)
        Me.memoAddComment.Name = "memoAddComment"
        Me.memoAddComment.Size = New System.Drawing.Size(361, 96)
        Me.memoAddComment.TabIndex = 38
        '
        'txtProductsId
        '
        Me.txtProductsId.Location = New System.Drawing.Point(520, 49)
        Me.txtProductsId.Name = "txtProductsId"
        Me.txtProductsId.Size = New System.Drawing.Size(96, 20)
        Me.txtProductsId.TabIndex = 39
        '
        'txtProductsDvdId
        '
        Me.txtProductsDvdId.Location = New System.Drawing.Point(520, 75)
        Me.txtProductsDvdId.Name = "txtProductsDvdId"
        Me.txtProductsDvdId.Size = New System.Drawing.Size(96, 20)
        Me.txtProductsDvdId.TabIndex = 40
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(443, 52)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl4.TabIndex = 41
        Me.LabelControl4.Text = "produtcs id"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(443, 78)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl1.TabIndex = 42
        Me.LabelControl1.Text = "products dvdid"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(443, 118)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl2.TabIndex = 43
        Me.LabelControl2.Text = "comment"
        '
        'MemoSeeComment
        '
        Me.MemoSeeComment.Location = New System.Drawing.Point(24, 137)
        Me.MemoSeeComment.Name = "MemoSeeComment"
        Me.MemoSeeComment.Properties.ReadOnly = True
        Me.MemoSeeComment.Size = New System.Drawing.Size(388, 96)
        Me.MemoSeeComment.TabIndex = 44
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(27, 118)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl3.TabIndex = 45
        Me.LabelControl3.Text = "see comment"
        '
        'frmProductsAlert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 583)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.MemoSeeComment)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtProductsDvdId)
        Me.Controls.Add(Me.txtProductsId)
        Me.Controls.Add(Me.memoAddComment)
        Me.Controls.Add(Me.btnAddProductsAlert)
        Me.Controls.Add(Me.GridProductsAlert)
        Me.Name = "frmProductsAlert"
        Me.Text = "frmProductsAlert"
        Me.Controls.SetChildIndex(Me.GridProductsAlert, 0)
        Me.Controls.SetChildIndex(Me.btnAddProductsAlert, 0)
        Me.Controls.SetChildIndex(Me.memoAddComment, 0)
        Me.Controls.SetChildIndex(Me.txtProductsId, 0)
        Me.Controls.SetChildIndex(Me.txtProductsDvdId, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.MemoSeeComment, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridProductsAlert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewProductsAlert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoAddComment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductsId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductsDvdId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoSeeComment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridProductsAlert As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewProductsAlert As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnAddProductsAlert As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents memoAddComment As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtProductsId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProductsDvdId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents products_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_dvd_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents alert_comment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents delete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnDeleted As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents alert_cre_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MemoSeeComment As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents comment_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents alert_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
