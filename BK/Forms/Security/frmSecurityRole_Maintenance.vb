Imports BizzLib.clsGlobal.ObjectState

Public Class frmsecurityrole_Maintenance
    Inherits BizzLib.frmGeneral_Maintenance
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblEntity As System.Windows.Forms.Label
    Friend WithEvents cmbEntity As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents objDS As BizzLib.dsSecurity
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents RolePage As System.Windows.Forms.TabPage
    Friend WithEvents EntitiesPage As System.Windows.Forms.TabPage
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEntityID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EntityLookUp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridEntityList As DevExpress.XtraGrid.GridControl
    Friend WithEvents MenusPage As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents chkCanModiifyCommonViews As DevExpress.XtraEditors.CheckEdit
    Public WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents colAccessAllowed As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colMenuLabel As DevExpress.XtraTreeList.Columns.TreeListColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblEntity = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.objDS = New BizzLib.dsSecurity
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkCanModiifyCommonViews = New DevExpress.XtraEditors.CheckEdit
        Me.cmbEntity = New DevExpress.XtraEditors.LookUpEdit
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.RolePage = New System.Windows.Forms.TabPage
        Me.EntitiesPage = New System.Windows.Forms.TabPage
        Me.GridEntityList = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colEntityID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.EntityLookUp = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.MenusPage = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.colMenuLabel = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colAccessAllowed = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.chkCanModiifyCommonViews.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbEntity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.RolePage.SuspendLayout()
        Me.EntitiesPage.SuspendLayout()
        CType(Me.GridEntityList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntityLookUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenusPage.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PopMenuNew
        '
        '
        'PopMenuEdit
        '
        '
        'PopMenuDelete
        '
        '
        'PopMenuSave
        '
        '
        'PopMenuUndo
        '
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 416)
        Me.StatusBar1.Size = New System.Drawing.Size(784, 22)
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(24, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 23)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(24, 48)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(100, 23)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "Description"
        '
        'lblEntity
        '
        Me.lblEntity.Location = New System.Drawing.Point(24, 80)
        Me.lblEntity.Name = "lblEntity"
        Me.lblEntity.Size = New System.Drawing.Size(100, 23)
        Me.lblEntity.TabIndex = 5
        Me.lblEntity.Text = "Default Entity"
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "securityrole.Name", True))
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(128, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 8
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsSecurity"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDescription
        '
        Me.txtDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "securityrole.Description", True))
        Me.txtDescription.Enabled = False
        Me.txtDescription.Location = New System.Drawing.Point(128, 48)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(376, 20)
        Me.txtDescription.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.chkCanModiifyCommonViews)
        Me.Panel1.Controls.Add(Me.cmbEntity)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.txtDescription)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.lblDescription)
        Me.Panel1.Controls.Add(Me.lblEntity)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 333)
        Me.Panel1.TabIndex = 31
        '
        'chkCanModiifyCommonViews
        '
        Me.chkCanModiifyCommonViews.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.objDS, "securityrole.CanModifyGlobalViews", True))
        Me.chkCanModiifyCommonViews.Location = New System.Drawing.Point(280, 80)
        Me.chkCanModiifyCommonViews.Name = "chkCanModiifyCommonViews"
        Me.chkCanModiifyCommonViews.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.chkCanModiifyCommonViews.Properties.Appearance.Options.UseBackColor = True
        Me.chkCanModiifyCommonViews.Properties.Caption = "Allowed to Manipulate Common Objects"
        Me.chkCanModiifyCommonViews.Size = New System.Drawing.Size(224, 19)
        Me.chkCanModiifyCommonViews.TabIndex = 12
        '
        'cmbEntity
        '
        Me.cmbEntity.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "securityrole.EntityID", True))
        Me.cmbEntity.Location = New System.Drawing.Point(128, 80)
        Me.cmbEntity.Name = "cmbEntity"
        Me.cmbEntity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbEntity.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 38, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbEntity.Properties.DataSource = Me.objDS.generalentity
        Me.cmbEntity.Properties.DisplayMember = "Name"
        Me.cmbEntity.Properties.NullText = ""
        Me.cmbEntity.Properties.ValueMember = "EntityID"
        Me.cmbEntity.Size = New System.Drawing.Size(120, 20)
        Me.cmbEntity.TabIndex = 11
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.RolePage)
        Me.TabControl1.Controls.Add(Me.EntitiesPage)
        Me.TabControl1.Controls.Add(Me.MenusPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 359)
        Me.TabControl1.TabIndex = 33
        '
        'RolePage
        '
        Me.RolePage.Controls.Add(Me.Panel1)
        Me.RolePage.Location = New System.Drawing.Point(4, 22)
        Me.RolePage.Name = "RolePage"
        Me.RolePage.Size = New System.Drawing.Size(776, 333)
        Me.RolePage.TabIndex = 0
        Me.RolePage.Text = "Role"
        '
        'EntitiesPage
        '
        Me.EntitiesPage.Controls.Add(Me.GridEntityList)
        Me.EntitiesPage.Location = New System.Drawing.Point(4, 22)
        Me.EntitiesPage.Name = "EntitiesPage"
        Me.EntitiesPage.Size = New System.Drawing.Size(776, 333)
        Me.EntitiesPage.TabIndex = 1
        Me.EntitiesPage.Text = "Entities"
        '
        'GridEntityList
        '
        Me.GridEntityList.DataMember = "securityrole_entity"
        Me.GridEntityList.DataSource = Me.objDS
        Me.GridEntityList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEntityList.EmbeddedNavigator.Name = ""
        Me.GridEntityList.Enabled = False
        Me.GridEntityList.FormsUseDefaultLookAndFeel = False
        Me.GridEntityList.Location = New System.Drawing.Point(0, 0)
        Me.GridEntityList.MainView = Me.GridView1
        Me.GridEntityList.Name = "GridEntityList"
        Me.GridEntityList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.EntityLookUp})
        Me.GridEntityList.Size = New System.Drawing.Size(776, 333)
        Me.GridEntityList.TabIndex = 0
        Me.GridEntityList.UseEmbeddedNavigator = True
        Me.GridEntityList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEntityID})
        Me.GridView1.GridControl = Me.GridEntityList
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colEntityID
        '
        Me.colEntityID.Caption = "Entity"
        Me.colEntityID.ColumnEdit = Me.EntityLookUp
        Me.colEntityID.FieldName = "EntityID"
        Me.colEntityID.Name = "colEntityID"
        Me.colEntityID.Visible = True
        Me.colEntityID.VisibleIndex = 0
        '
        'EntityLookUp
        '
        Me.EntityLookUp.AutoHeight = False
        Me.EntityLookUp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EntityLookUp.DataSource = Me.objDS.generalentity
        Me.EntityLookUp.DisplayMember = "Name"
        Me.EntityLookUp.Name = "EntityLookUp"
        Me.EntityLookUp.NullText = ""
        Me.EntityLookUp.ValueMember = "EntityID"
        '
        'MenusPage
        '
        Me.MenusPage.Controls.Add(Me.Panel2)
        Me.MenusPage.Location = New System.Drawing.Point(4, 22)
        Me.MenusPage.Name = "MenusPage"
        Me.MenusPage.Size = New System.Drawing.Size(776, 333)
        Me.MenusPage.TabIndex = 2
        Me.MenusPage.Text = "Menus"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.TreeList1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(776, 333)
        Me.Panel2.TabIndex = 2
        '
        'TreeList1
        '
        Me.TreeList1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeList1.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.TreeList1.Appearance.Empty.Options.UseBackColor = True
        Me.TreeList1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeList1.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeList1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.EvenRow.Options.UseBackColor = True
        Me.TreeList1.Appearance.EvenRow.Options.UseBorderColor = True
        Me.TreeList1.Appearance.EvenRow.Options.UseForeColor = True
        Me.TreeList1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.TreeList1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.TreeList1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.TreeList1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.TreeList1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.TreeList1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.TreeList1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.TreeList1.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.TreeList1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.TreeList1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeList1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeList1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.TreeList1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.TreeList1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.TreeList1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeList1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeList1.Appearance.GroupButton.Options.UseBackColor = True
        Me.TreeList1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.TreeList1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TreeList1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TreeList1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.TreeList1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.TreeList1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.TreeList1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TreeList1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TreeList1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.TreeList1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.TreeList1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.TreeList1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TreeList1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TreeList1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeList1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.TreeList1.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.TreeList1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.TreeList1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeList1.Appearance.HorzLine.Options.UseBackColor = True
        Me.TreeList1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeList1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeList1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.OddRow.Options.UseBackColor = True
        Me.TreeList1.Appearance.OddRow.Options.UseBorderColor = True
        Me.TreeList1.Appearance.OddRow.Options.UseForeColor = True
        Me.TreeList1.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.TreeList1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TreeList1.Appearance.Preview.Options.UseFont = True
        Me.TreeList1.Appearance.Preview.Options.UseForeColor = True
        Me.TreeList1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeList1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.Row.Options.UseBackColor = True
        Me.TreeList1.Appearance.Row.Options.UseForeColor = True
        Me.TreeList1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TreeList1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.TreeList1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.TreeList1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.TreeList1.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.TreeList1.Appearance.TreeLine.Options.UseBackColor = True
        Me.TreeList1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeList1.Appearance.VertLine.Options.UseBackColor = True
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colMenuLabel, Me.colAccessAllowed})
        Me.TreeList1.DataSource = Me.objDS.systemmenutreeView1
        Me.TreeList1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeList1.Enabled = False
        Me.TreeList1.KeyFieldName = "MenuID"
        Me.TreeList1.Location = New System.Drawing.Point(0, 0)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsView.EnableAppearanceEvenRow = True
        Me.TreeList1.OptionsView.EnableAppearanceOddRow = True
        Me.TreeList1.OptionsView.ShowHorzLines = False
        Me.TreeList1.OptionsView.ShowIndicator = False
        Me.TreeList1.OptionsView.ShowVertLines = False
        Me.TreeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.TreeList1.Size = New System.Drawing.Size(584, 333)
        Me.TreeList1.TabIndex = 0
        '
        'colMenuLabel
        '
        Me.colMenuLabel.Caption = "MenuLabel"
        Me.colMenuLabel.FieldName = "MenuLabel"
        Me.colMenuLabel.Name = "colMenuLabel"
        Me.colMenuLabel.OptionsColumn.AllowEdit = False
        Me.colMenuLabel.Visible = True
        Me.colMenuLabel.VisibleIndex = 0
        Me.colMenuLabel.Width = 546
        '
        'colAccessAllowed
        '
        Me.colAccessAllowed.FieldName = "AccessAllowed"
        Me.colAccessAllowed.MinWidth = 10
        Me.colAccessAllowed.Name = "colAccessAllowed"
        Me.colAccessAllowed.Visible = True
        Me.colAccessAllowed.VisibleIndex = 1
        Me.colAccessAllowed.Width = 34
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmsecurityrole_Maintenance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(784, 438)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "frmsecurityrole_Maintenance"
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.chkCanModiifyCommonViews.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbEntity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.RolePage.ResumeLayout(False)
        Me.EntitiesPage.ResumeLayout(False)
        CType(Me.GridEntityList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntityLookUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenusPage.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim KeyDataSet As String = "BizzLib.dsSecurity" 'The Dataset used 
    Dim MainData As clsData_Role

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'SetUp of Variables
            KeyFieldName = "Name"
            IDField = "RoleID"
            TableName = "securityrole"
            MainDataSet = objDS

            HelpProvider1.HelpNamespace = ".\Help\" & SessionInfo.UserLang & "\BizzKeys.chm"
            'Attempt to load the dataset.
            Me.LoadBKComboSet()
            Me.LoadDataSet()
            BKGlobal.LoadAssociatedMenu(Me.Tag, PopMenuAssociatedTasks, Me)
            If OpenType = "NEW" Then
                NewRecord(sender, e)
            End If
            If OpenType = "EDIT" Then
                'Retreiving the GLAccount Code for the Associated ID
                '_Row = objDs.Tables(TableName).Rows.Find(New Object() {KeyID})
                If KeyValue <> "" Then 'Not IsNothing(_Row) Then
                    Me.objDS.Tables(TableName).DefaultView.Sort = IDField
                    Dim _Name As String = Me.objDS.Tables(TableName).DefaultView(Me.objDS.Tables(TableName).DefaultView.Find(New Object() {KeyValue}))(KeyFieldName)
                    'Now Finding the record by the name, because this is the one used in the ORDER BY in the LoadDataset
                    Me.objDS.Tables(TableName).DefaultView.Sort = KeyFieldName
                    Me.BindingContext(objDS, TableName).Position = Me.objDS.Tables(TableName).DefaultView.Find(New Object() {_Name})
                    PositionChanged(sender, e)
                    EditRecord(sender, e)
                Else
                    OpenType = "BROWSE"
                    Exit Sub
                End If
            End If
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        PositionChanged(sender, e)
    End Sub
    Private Sub frm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim _Answ As MsgBoxResult
        If OpenType = "EDIT" Or OpenType = "NEW" Then
            _Answ = MsgBox(BKGlobal.GetMsg(4, SessionInfo.UserLang), MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question)
            If _Answ = MsgBoxResult.Yes Then
                SaveChanges(sender, e)
            End If
            If _Answ = MsgBoxResult.No Then
                UndoChanges(sender, e)
            End If
            If _Answ = MsgBoxResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub NewRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuNew.Click, MyBase.EventNewRecord
        SetState(NewState)
        PopMenuNew.Enabled = False
        PopMenuEdit.Enabled = False
        PopMenuSave.Enabled = True
        PopMenuDelete.Enabled = False
        PopMenuUndo.Enabled = True
        EnablingAll(True)
        OpenType = "NEW"
        Try
            'Clear out the current edits
            Me.BindingContext(objDS, TableName).EndCurrentEdit()
            Me.BindingContext(objDS, TableName).AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        PositionChanged(Sender, e)
    End Sub
    Private Sub EditRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuEdit.Click, MyBase.EventEditRecord
        If Me.BindingContext(objDS, TableName).Position < 0 Then
            Exit Sub
        End If
        SetState(EditState)
        PopMenuNew.Enabled = False
        PopMenuEdit.Enabled = False
        PopMenuSave.Enabled = True
        PopMenuDelete.Enabled = False
        PopMenuUndo.Enabled = True
        EnablingForEdit()
        OpenType = "EDIT"
    End Sub
    Private Sub DeleteRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuDelete.Click, MyBase.EventDeleteRecord
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            'Msg = 1 = Confirm Delete
            If MsgBox(BKGlobal.GetMsg(1, SessionInfo.UserLang), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    BKGlobal.DeleteTranslations(TableName & "." & IDField, CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField) & "")
                    BKGlobal.DeleteComments(SessionInfo.EntityID, txtName.Text)
                    MainData.Delete(CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField))
                    EnablingAll(False)
                    PositionChanged(Sender, e)
                Catch ex As Exception
                    If ex.Source <> "##" Then
                        '7: Cannot Delete - Linked Tables exists
                        MsgBox(BKGlobal.GetMsg(7, SessionInfo.UserLang), MsgBoxStyle.Critical)
                    Else
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    End If
                    Exit Sub
                End Try
            End If
        End If
    End Sub
    Private Sub UndoChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuUndo.Click, MyBase.EventUndoChanges
        SetState(BrowseState)
        PopMenuNew.Enabled = True
        PopMenuEdit.Enabled = True
        PopMenuSave.Enabled = False
        PopMenuDelete.Enabled = True
        PopMenuUndo.Enabled = False
        EnablingAll(False)
        Me.BindingContext(objDS, TableName).CancelCurrentEdit()
        PositionChanged(Sender, e)
        OpenType = "BROWSE"
    End Sub
    Private Sub SaveChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuSave.Click, MyBase.EventSaveChanges

        Dim _node As DevExpress.XtraTreeList.Nodes.TreeListNode
        Try
            GridView1.CloseEditor()
            GridView1.UpdateCurrentRow()
            If IsDBNull(CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField)) Then
                CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField) = BKGlobal.GetNextID(IDField)
            End If
            'Saving the Menu_Role Links
            For Each _node In TreeList1.Nodes
                SaveNode(_node)
            Next
            'Validate Fields and assign any Necessary ID
            MainData.ValidateRecordFields(CType(Me.BindingContext(objDS, TableName).Current, DataRowView))
            'Attempt to update the datasource.
            Me.UpdateDataSet()
            SetState(BrowseState)
            PopMenuNew.Enabled = True
            PopMenuEdit.Enabled = True
            PopMenuSave.Enabled = False
            PopMenuDelete.Enabled = True
            PopMenuUndo.Enabled = False
            EnablingAll(False)
            OpenType = "BROWSE"
        Catch eUpdate As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        Finally
        End Try
        PositionChanged(Sender, e)
    End Sub

    Private Sub SaveNode(ByVal Node1 As DevExpress.XtraTreeList.Nodes.TreeListNode)
        Dim _row As DataRow
        Dim _Node As DevExpress.XtraTreeList.Nodes.TreeListNode
        _row = objDS.Tables("securitymenu_role").Rows.Find(New Object() {CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField), Node1("MenuID")})
        If Node1("AccessAllowed") = True Then
            If IsNothing(_row) Then
                _row = objDS.Tables("securitymenu_role").NewRow
                _row("RoleID") = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField)
                _row("MenuID") = Node1("MenuID")
                objDS.Tables("securitymenu_role").Rows.Add(_row)
            End If
        Else
            'UnChecked
            If Not IsNothing(_row) Then
                _row.Delete()
            End If
        End If
        For Each _Node In Node1.Nodes
            SaveNode(_Node)
        Next
    End Sub
    Public Sub UpdateDataSet() Handles MyBase.EventUpdateDataset
        'Stop any current edits.
        Me.BindingContext(objDS, TableName).EndCurrentEdit()
        MainData.Save()
    End Sub
    Public Sub LoadDataSet() Handles MyBase.EventLoadDataset
        If IsFiltered Then
            MainData = New clsData_Role(SessionInfo, objDS, KeyDataSet, TableName, " WHERE " & FilterTxt, "ORDER BY " & KeyFieldName)
        Else
            MainData = New clsData_Role(SessionInfo, objDS, KeyDataSet, TableName, "", "ORDER BY " & KeyFieldName)
        End If
        Me.objDS.Tables(TableName).DefaultView.Sort = "Name"
        Me.objDS.Tables(TableName).Columns("CanModifyGlobalViews").DefaultValue = 0
        'LoadMenuTreeDataSet()
    End Sub
    Public Sub LoadBKComboSet()
        Try
            BKCombo.GetCombo_EntityAll(objDS, "generalentity", "Name")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PositionChanged(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.EventPositionChanged
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            If CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField) & "" = "" Then
                MainData.LoadEntityList(objDS, KeyDataSet, -1)
                MainData.LoadMenuList(objDS, KeyDataSet, -1)
            Else
                MainData.LoadEntityList(objDS, KeyDataSet, CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField))
                MainData.LoadMenuList(objDS, KeyDataSet, CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField))
            End If
            StatusBar1.Panels(0).Text = (((Me.BindingContext(objDS, TableName).Position + 1).ToString + " of  ") _
                        + Me.BindingContext(objDS, TableName).Count.ToString)
            ToolTip1.SetToolTip(StatusBar1, TableName & "-->" & IDField & "=" & CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField) & "")
            txtQuickSearch.EditValue = txtName.Text
            RefreshMenuTree()
        End If
    End Sub

    Private Sub EnablingEditFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingEditFields
        'ToBeChecked ***
        txtName.Enabled = Enabling
        txtDescription.Enabled = Enabling
        cmbEntity.Properties.Enabled = Enabling
        GridEntityList.Enabled = Enabling
        'treeApplication.Enabled = Enabling
        chkCanModiifyCommonViews.Properties.Enabled = Enabling
        TreeList1.Enabled = Enabling
    End Sub
    Private Sub EnablingKeyFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingkeyFields
        'ToBeChecked ***
    End Sub
    Private Sub StartPrintForm() Handles MyBase.EventPrintForm
        BKReport.PrintForm(CurrentReportID, New DataRow() {CType(Me.BindingContext(MainDataSet, TableName).Current, DataRowView).Row}, _
            New DataTable() {objDS.Tables("securityrole_entity"), objDS.Tables("securitymenu_role")})
    End Sub

    Private Sub RefreshMenuTree()
        Dim _ID As Integer
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            If IsDBNull(CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField)) Then Exit Sub
            _ID = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField)
            If IsDBNull(_ID) Then Exit Sub
            objDS.Tables("systemmenutreeView1").Clear()
            PlushData.clsConnection.FillDataSet(objDS.Tables("systemmenutreeView1"), MenuTreeSQLTxt)
            Dim _row As DataRow
            For Each _row In objDS.Tables("systemmenutreeView1").Rows
                If BKGlobal.CheckMenuAccessAutorization(_row("MenuID"), _ID) Or _ID = 0 Then
                    _row("AccessAllowed") = True
                Else
                    _row("AccessAllowed") = False
                End If
            Next
        End If
    End Sub

    Private Sub TreeList1_NodesReloaded(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeList1.NodesReloaded
        TreeList1.CollapseAll()
        If IsNothing(TreeList1.Nodes.FirstNode) Then
            Exit Sub
        End If
        TreeList1.Nodes.FirstNode.Expanded = True
    End Sub
    Private Sub CheckNodes(ByVal _node As DevExpress.XtraTreeList.Nodes.TreeListNode, ByVal NodeValue As Boolean)
        _node("AccessAllowed") = NodeValue
        For Each _node In _node.Nodes
            CheckNodes(_node, NodeValue)
        Next
    End Sub
    Private Sub TreeList1_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles TreeList1.CellValueChanging
        Dim _node As DevExpress.XtraTreeList.Nodes.TreeListNode
        For Each _node In e.Node.Nodes  'TreeList1.FocusedNode.Nodes
            CheckNodes(_node, e.Value)
        Next
        e.Node("AccessAllowed") = e.Value
        TreeList1.RefreshDataSource()
    End Sub
End Class

