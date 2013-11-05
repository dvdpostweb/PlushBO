Public Class frmSystemMenu_Browse
    Inherits BizzLib.frmBKForm

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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents colMenuID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMenuLabel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMenuIcon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMenuIconExpanded As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnNew1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnEdit1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnDelete1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnSave1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnSep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnPrint1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolBar2 As System.Windows.Forms.ToolBar
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents btnPlus As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnMinus As System.Windows.Forms.ToolBarButton
    Friend WithEvents Separator1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnLeft As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnRight As System.Windows.Forms.ToolBarButton
    Friend WithEvents separator2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnUp As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnDown As System.Windows.Forms.ToolBarButton
    Friend WithEvents Separator3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolBarButton
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDataAdapter3 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents RightMouseMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents PopMenuNew As System.Windows.Forms.MenuItem
    Friend WithEvents PopMenuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents PopMenuDelete As System.Windows.Forms.MenuItem
    Friend WithEvents PopMenuSave As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents PopMenuPrintPreview As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents PopMenuAssociatedTasks As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents PopMenuUserTasks As System.Windows.Forms.MenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents colMenuStartID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents objDS As BizzLib.dsSystem
    Friend WithEvents colMenuStartCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents colMenuStartCode2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMenuAssembly As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMenuLandScape As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Public WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colMenuLabel1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colSequence As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colMenuStartID1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colMenuStartCode1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colMenuStartCode21 As DevExpress.XtraTreeList.Columns.TreeListColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSystemMenu_Browse))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.RightMouseMenu = New System.Windows.Forms.ContextMenu
        Me.PopMenuNew = New System.Windows.Forms.MenuItem
        Me.PopMenuEdit = New System.Windows.Forms.MenuItem
        Me.PopMenuDelete = New System.Windows.Forms.MenuItem
        Me.PopMenuSave = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.PopMenuPrintPreview = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.PopMenuAssociatedTasks = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.PopMenuUserTasks = New System.Windows.Forms.MenuItem
        Me.objDS = New BizzLib.dsSystem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMenuID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMenuLabel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFormName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMenuIcon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMenuIconExpanded = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMenuStartID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMenuStartCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMenuStartCode2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMenuAssembly = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMenuLandScape = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.btnNew1 = New System.Windows.Forms.ToolBarButton
        Me.btnEdit1 = New System.Windows.Forms.ToolBarButton
        Me.btnDelete1 = New System.Windows.Forms.ToolBarButton
        Me.btnSave1 = New System.Windows.Forms.ToolBarButton
        Me.btnSep1 = New System.Windows.Forms.ToolBarButton
        Me.btnPrint1 = New System.Windows.Forms.ToolBarButton
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.colMenuLabel1 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colSequence = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colMenuStartID1 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colMenuStartCode1 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colMenuStartCode21 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.ToolBar2 = New System.Windows.Forms.ToolBar
        Me.btnPlus = New System.Windows.Forms.ToolBarButton
        Me.btnMinus = New System.Windows.Forms.ToolBarButton
        Me.Separator1 = New System.Windows.Forms.ToolBarButton
        Me.btnLeft = New System.Windows.Forms.ToolBarButton
        Me.btnRight = New System.Windows.Forms.ToolBarButton
        Me.separator2 = New System.Windows.Forms.ToolBarButton
        Me.btnUp = New System.Windows.Forms.ToolBarButton
        Me.btnDown = New System.Windows.Forms.ToolBarButton
        Me.Separator3 = New System.Windows.Forms.ToolBarButton
        Me.btnRefresh = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter3 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        '
        'StatusBar1
        '
        resources.ApplyResources(Me.StatusBar1, "StatusBar1")
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.HelpProvider1.SetShowHelp(Me.StatusBar1, CType(resources.GetObject("StatusBar1.ShowHelp"), Boolean))
        Me.StatusBar1.ShowPanels = True
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        resources.ApplyResources(Me.StatusBarPanel1, "StatusBarPanel1")
        '
        'Grid1
        '
        Me.Grid1.ContextMenu = Me.RightMouseMenu
        resources.ApplyResources(Me.Grid1, "Grid1")
        Me.Grid1.DataSource = Me.objDS
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.FormsUseDefaultLookAndFeel = False
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.HelpProvider1.SetShowHelp(Me.Grid1, CType(resources.GetObject("Grid1.ShowHelp"), Boolean))
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'RightMouseMenu
        '
        Me.RightMouseMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.PopMenuNew, Me.PopMenuEdit, Me.PopMenuDelete, Me.PopMenuSave, Me.MenuItem5, Me.PopMenuPrintPreview, Me.MenuItem7, Me.PopMenuAssociatedTasks, Me.MenuItem9, Me.PopMenuUserTasks})
        '
        'PopMenuNew
        '
        Me.PopMenuNew.Index = 0
        resources.ApplyResources(Me.PopMenuNew, "PopMenuNew")
        '
        'PopMenuEdit
        '
        Me.PopMenuEdit.Index = 1
        resources.ApplyResources(Me.PopMenuEdit, "PopMenuEdit")
        '
        'PopMenuDelete
        '
        Me.PopMenuDelete.Index = 2
        resources.ApplyResources(Me.PopMenuDelete, "PopMenuDelete")
        '
        'PopMenuSave
        '
        Me.PopMenuSave.Index = 3
        resources.ApplyResources(Me.PopMenuSave, "PopMenuSave")
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        resources.ApplyResources(Me.MenuItem5, "MenuItem5")
        '
        'PopMenuPrintPreview
        '
        Me.PopMenuPrintPreview.Index = 5
        resources.ApplyResources(Me.PopMenuPrintPreview, "PopMenuPrintPreview")
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 6
        resources.ApplyResources(Me.MenuItem7, "MenuItem7")
        '
        'PopMenuAssociatedTasks
        '
        Me.PopMenuAssociatedTasks.Index = 7
        resources.ApplyResources(Me.PopMenuAssociatedTasks, "PopMenuAssociatedTasks")
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 8
        resources.ApplyResources(Me.MenuItem9, "MenuItem9")
        '
        'PopMenuUserTasks
        '
        Me.PopMenuUserTasks.Index = 9
        resources.ApplyResources(Me.PopMenuUserTasks, "PopMenuUserTasks")
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsSystem"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMenuID, Me.colMenuLabel, Me.colFormName, Me.colMenuIcon, Me.colMenuIconExpanded, Me.colMenuStartID, Me.colMenuStartCode, Me.colMenuStartCode2, Me.colMenuAssembly, Me.colMenuLandScape})
        Me.GridView1.GridControl = Me.Grid1
        resources.ApplyResources(Me.GridView1, "GridView1")
        Me.GridView1.Name = "GridView1"
        '
        'colMenuID
        '
        resources.ApplyResources(Me.colMenuID, "colMenuID")
        Me.colMenuID.DisplayFormat.FormatString = "d"
        Me.colMenuID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMenuID.FieldName = "MenuID"
        Me.colMenuID.Name = "colMenuID"
        Me.colMenuID.OptionsColumn.AllowEdit = False
        Me.colMenuID.OptionsColumn.ReadOnly = True
        '
        'colMenuLabel
        '
        resources.ApplyResources(Me.colMenuLabel, "colMenuLabel")
        Me.colMenuLabel.FieldName = "MenuLabel"
        Me.colMenuLabel.Name = "colMenuLabel"
        '
        'colFormName
        '
        resources.ApplyResources(Me.colFormName, "colFormName")
        Me.colFormName.FieldName = "MenuForm"
        Me.colFormName.Name = "colFormName"
        '
        'colMenuIcon
        '
        resources.ApplyResources(Me.colMenuIcon, "colMenuIcon")
        Me.colMenuIcon.FieldName = "MenuIcon"
        Me.colMenuIcon.Name = "colMenuIcon"
        '
        'colMenuIconExpanded
        '
        resources.ApplyResources(Me.colMenuIconExpanded, "colMenuIconExpanded")
        Me.colMenuIconExpanded.FieldName = "MenuIconExpanded"
        Me.colMenuIconExpanded.Name = "colMenuIconExpanded"
        '
        'colMenuStartID
        '
        resources.ApplyResources(Me.colMenuStartID, "colMenuStartID")
        Me.colMenuStartID.FieldName = "MenuStartID"
        Me.colMenuStartID.Name = "colMenuStartID"
        '
        'colMenuStartCode
        '
        resources.ApplyResources(Me.colMenuStartCode, "colMenuStartCode")
        Me.colMenuStartCode.FieldName = "MenuStartCode"
        Me.colMenuStartCode.Name = "colMenuStartCode"
        '
        'colMenuStartCode2
        '
        resources.ApplyResources(Me.colMenuStartCode2, "colMenuStartCode2")
        Me.colMenuStartCode2.FieldName = "MenuStartCode2"
        Me.colMenuStartCode2.Name = "colMenuStartCode2"
        '
        'colMenuAssembly
        '
        resources.ApplyResources(Me.colMenuAssembly, "colMenuAssembly")
        Me.colMenuAssembly.FieldName = "MenuAssembly"
        Me.colMenuAssembly.Name = "colMenuAssembly"
        '
        'colMenuLandScape
        '
        resources.ApplyResources(Me.colMenuLandScape, "colMenuLandScape")
        Me.colMenuLandScape.FieldName = "MenuLandScape"
        Me.colMenuLandScape.Name = "colMenuLandScape"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "systemmenu", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MenuID", "MenuID"), New System.Data.Common.DataColumnMapping("MenuLabel", "MenuLabel"), New System.Data.Common.DataColumnMapping("MenuForm", "MenuForm"), New System.Data.Common.DataColumnMapping("MenuIcon", "MenuIcon"), New System.Data.Common.DataColumnMapping("MenuIconExpanded", "MenuIconExpanded"), New System.Data.Common.DataColumnMapping("MenuStartID", "MenuStartID"), New System.Data.Common.DataColumnMapping("MenuStartCode", "MenuStartCode"), New System.Data.Common.DataColumnMapping("MenuStartCode2", "MenuStartCode2"), New System.Data.Common.DataColumnMapping("MenuAssembly", "MenuAssembly"), New System.Data.Common.DataColumnMapping("MenuLandScape", "MenuLandScape")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuAssembly", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuAssembly", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuAssembly1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuAssembly", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuForm", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuForm1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIcon", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIcon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIcon1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIcon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIconExpanded", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIconExpanded", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIconExpanded1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIconExpanded", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuLabel", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuLabel", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuLabel1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuLabel", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuLandScape", System.Data.OleDb.OleDbType.[Boolean], 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuLandScape", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuLandScape1", System.Data.OleDb.OleDbType.[Boolean], 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuLandScape", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode2", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode2", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode21", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode2", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartID1", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = resources.GetString("OleDbConnection1.ConnectionString")
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = resources.GetString("OleDbInsertCommand1.CommandText")
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID"), New System.Data.OleDb.OleDbParameter("MenuLabel", System.Data.OleDb.OleDbType.VarChar, 50, "MenuLabel"), New System.Data.OleDb.OleDbParameter("MenuForm", System.Data.OleDb.OleDbType.VarChar, 100, "MenuForm"), New System.Data.OleDb.OleDbParameter("MenuIcon", System.Data.OleDb.OleDbType.VarChar, 100, "MenuIcon"), New System.Data.OleDb.OleDbParameter("MenuIconExpanded", System.Data.OleDb.OleDbType.VarChar, 100, "MenuIconExpanded"), New System.Data.OleDb.OleDbParameter("MenuStartID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuStartID"), New System.Data.OleDb.OleDbParameter("MenuStartCode", System.Data.OleDb.OleDbType.VarChar, 50, "MenuStartCode"), New System.Data.OleDb.OleDbParameter("MenuStartCode2", System.Data.OleDb.OleDbType.VarChar, 50, "MenuStartCode2"), New System.Data.OleDb.OleDbParameter("MenuAssembly", System.Data.OleDb.OleDbType.VarChar, 50, "MenuAssembly"), New System.Data.OleDb.OleDbParameter("MenuLandScape", System.Data.OleDb.OleDbType.[Boolean], 1, "MenuLandScape"), New System.Data.OleDb.OleDbParameter("Select_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID")})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT MenuID, MenuLabel, MenuForm, MenuIcon, MenuIconExpanded, MenuStartID, Menu" & _
            "StartCode, MenuStartCode2, MenuAssembly, MenuLandScape FROM systemmenu"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID"), New System.Data.OleDb.OleDbParameter("MenuLabel", System.Data.OleDb.OleDbType.VarChar, 50, "MenuLabel"), New System.Data.OleDb.OleDbParameter("MenuForm", System.Data.OleDb.OleDbType.VarChar, 100, "MenuForm"), New System.Data.OleDb.OleDbParameter("MenuIcon", System.Data.OleDb.OleDbType.VarChar, 100, "MenuIcon"), New System.Data.OleDb.OleDbParameter("MenuIconExpanded", System.Data.OleDb.OleDbType.VarChar, 100, "MenuIconExpanded"), New System.Data.OleDb.OleDbParameter("MenuStartID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuStartID"), New System.Data.OleDb.OleDbParameter("MenuStartCode", System.Data.OleDb.OleDbType.VarChar, 50, "MenuStartCode"), New System.Data.OleDb.OleDbParameter("MenuStartCode2", System.Data.OleDb.OleDbType.VarChar, 50, "MenuStartCode2"), New System.Data.OleDb.OleDbParameter("MenuAssembly", System.Data.OleDb.OleDbType.VarChar, 50, "MenuAssembly"), New System.Data.OleDb.OleDbParameter("MenuLandScape", System.Data.OleDb.OleDbType.[Boolean], 1, "MenuLandScape"), New System.Data.OleDb.OleDbParameter("Original_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuAssembly", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuAssembly", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuAssembly1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuAssembly", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuForm", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuForm1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIcon", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIcon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIcon1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIcon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIconExpanded", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIconExpanded", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIconExpanded1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIconExpanded", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuLabel", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuLabel", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuLabel1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuLabel", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuLandScape", System.Data.OleDb.OleDbType.[Boolean], 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuLandScape", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuLandScape1", System.Data.OleDb.OleDbType.[Boolean], 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuLandScape", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode2", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode2", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode21", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode2", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartID1", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Select_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID")})
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Grid1)
        Me.Panel1.Controls.Add(Me.Panel3)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        Me.HelpProvider1.SetShowHelp(Me.Panel1, CType(resources.GetObject("Panel1.ShowHelp"), Boolean))
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Splitter2)
        Me.Panel3.Controls.Add(Me.Panel4)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        Me.HelpProvider1.SetShowHelp(Me.Panel3, CType(resources.GetObject("Panel3.ShowHelp"), Boolean))
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ToolBar1)
        resources.ApplyResources(Me.Panel5, "Panel5")
        Me.Panel5.Name = "Panel5"
        Me.HelpProvider1.SetShowHelp(Me.Panel5, CType(resources.GetObject("Panel5.ShowHelp"), Boolean))
        '
        'ToolBar1
        '
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.btnNew1, Me.btnEdit1, Me.btnDelete1, Me.btnSave1, Me.btnSep1, Me.btnPrint1})
        resources.ApplyResources(Me.ToolBar1, "ToolBar1")
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Name = "ToolBar1"
        Me.HelpProvider1.SetShowHelp(Me.ToolBar1, CType(resources.GetObject("ToolBar1.ShowHelp"), Boolean))
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'btnNew1
        '
        resources.ApplyResources(Me.btnNew1, "btnNew1")
        Me.btnNew1.Name = "btnNew1"
        Me.btnNew1.Tag = "btnNew1"
        '
        'btnEdit1
        '
        resources.ApplyResources(Me.btnEdit1, "btnEdit1")
        Me.btnEdit1.Name = "btnEdit1"
        Me.btnEdit1.Tag = "btnEdit1"
        '
        'btnDelete1
        '
        resources.ApplyResources(Me.btnDelete1, "btnDelete1")
        Me.btnDelete1.Name = "btnDelete1"
        Me.btnDelete1.Tag = "btnDelete1"
        '
        'btnSave1
        '
        resources.ApplyResources(Me.btnSave1, "btnSave1")
        Me.btnSave1.Name = "btnSave1"
        Me.btnSave1.Tag = "btnSave1"
        '
        'btnSep1
        '
        Me.btnSep1.Name = "btnSep1"
        Me.btnSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'btnPrint1
        '
        resources.ApplyResources(Me.btnPrint1, "btnPrint1")
        Me.btnPrint1.Name = "btnPrint1"
        '
        'Splitter2
        '
        Me.Splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.Splitter2, "Splitter2")
        Me.Splitter2.Name = "Splitter2"
        Me.HelpProvider1.SetShowHelp(Me.Splitter2, CType(resources.GetObject("Splitter2.ShowHelp"), Boolean))
        Me.Splitter2.TabStop = False
        '
        'Panel4
        '
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        Me.HelpProvider1.SetShowHelp(Me.Panel4, CType(resources.GetObject("Panel4.ShowHelp"), Boolean))
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TreeList1)
        Me.Panel2.Controls.Add(Me.ToolBar2)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        Me.HelpProvider1.SetShowHelp(Me.Panel2, CType(resources.GetObject("Panel2.ShowHelp"), Boolean))
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
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colMenuLabel1, Me.colSequence, Me.colMenuStartID1, Me.colMenuStartCode1, Me.colMenuStartCode21})
        Me.TreeList1.DataSource = Me.objDS.systemmenutreeView1
        resources.ApplyResources(Me.TreeList1, "TreeList1")
        Me.TreeList1.KeyFieldName = "MenuID"
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsView.EnableAppearanceEvenRow = True
        Me.TreeList1.OptionsView.EnableAppearanceOddRow = True
        Me.TreeList1.OptionsView.ShowHorzLines = False
        Me.TreeList1.OptionsView.ShowIndicator = False
        Me.TreeList1.OptionsView.ShowVertLines = False
        Me.TreeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.HelpProvider1.SetShowHelp(Me.TreeList1, CType(resources.GetObject("TreeList1.ShowHelp"), Boolean))
        '
        'colMenuLabel1
        '
        resources.ApplyResources(Me.colMenuLabel1, "colMenuLabel1")
        Me.colMenuLabel1.FieldName = "MenuLabel"
        Me.colMenuLabel1.Name = "colMenuLabel1"
        Me.colMenuLabel1.OptionsColumn.AllowEdit = False
        Me.colMenuLabel1.OptionsColumn.ReadOnly = True
        '
        'colSequence
        '
        resources.ApplyResources(Me.colSequence, "colSequence")
        Me.colSequence.FieldName = "Sequence"
        Me.colSequence.Name = "colSequence"
        '
        'colMenuStartID1
        '
        resources.ApplyResources(Me.colMenuStartID1, "colMenuStartID1")
        Me.colMenuStartID1.FieldName = "MenuStartID"
        Me.colMenuStartID1.Name = "colMenuStartID1"
        '
        'colMenuStartCode1
        '
        resources.ApplyResources(Me.colMenuStartCode1, "colMenuStartCode1")
        Me.colMenuStartCode1.FieldName = "MenuStartCode"
        Me.colMenuStartCode1.Name = "colMenuStartCode1"
        '
        'colMenuStartCode21
        '
        resources.ApplyResources(Me.colMenuStartCode21, "colMenuStartCode21")
        Me.colMenuStartCode21.FieldName = "MenuStartCode2"
        Me.colMenuStartCode21.Name = "colMenuStartCode21"
        '
        'RepositoryItemCheckEdit1
        '
        resources.ApplyResources(Me.RepositoryItemCheckEdit1, "RepositoryItemCheckEdit1")
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'ToolBar2
        '
        Me.ToolBar2.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.btnPlus, Me.btnMinus, Me.Separator1, Me.btnLeft, Me.btnRight, Me.separator2, Me.btnUp, Me.btnDown, Me.Separator3, Me.btnRefresh})
        resources.ApplyResources(Me.ToolBar2, "ToolBar2")
        Me.ToolBar2.ImageList = Me.ImageList2
        Me.ToolBar2.Name = "ToolBar2"
        Me.HelpProvider1.SetShowHelp(Me.ToolBar2, CType(resources.GetObject("ToolBar2.ShowHelp"), Boolean))
        '
        'btnPlus
        '
        resources.ApplyResources(Me.btnPlus, "btnPlus")
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Tag = "btnPlus"
        '
        'btnMinus
        '
        resources.ApplyResources(Me.btnMinus, "btnMinus")
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Tag = "btnMinus"
        '
        'Separator1
        '
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'btnLeft
        '
        resources.ApplyResources(Me.btnLeft, "btnLeft")
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Tag = "btnLeft"
        '
        'btnRight
        '
        resources.ApplyResources(Me.btnRight, "btnRight")
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Tag = "btnRight"
        '
        'separator2
        '
        Me.separator2.Name = "separator2"
        Me.separator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'btnUp
        '
        resources.ApplyResources(Me.btnUp, "btnUp")
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Tag = "btnUp"
        '
        'btnDown
        '
        resources.ApplyResources(Me.btnDown, "btnDown")
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Tag = "btnDown"
        '
        'Separator3
        '
        Me.Separator3.Name = "Separator3"
        Me.Separator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'btnRefresh
        '
        resources.ApplyResources(Me.btnRefresh, "btnRefresh")
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Tag = "btnRefresh"
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        Me.ImageList2.Images.SetKeyName(3, "")
        Me.ImageList2.Images.SetKeyName(4, "")
        Me.ImageList2.Images.SetKeyName(5, "")
        Me.ImageList2.Images.SetKeyName(6, "")
        '
        'Splitter1
        '
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.Splitter1, "Splitter1")
        Me.Splitter1.Name = "Splitter1"
        Me.HelpProvider1.SetShowHelp(Me.Splitter1, CType(resources.GetObject("Splitter1.ShowHelp"), Boolean))
        Me.Splitter1.TabStop = False
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "systemmenu", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ParentID", "ParentID"), New System.Data.Common.DataColumnMapping("MenuID", "MenuID"), New System.Data.Common.DataColumnMapping("MenuLabel", "MenuLabel"), New System.Data.Common.DataColumnMapping("MenuForm", "MenuForm"), New System.Data.Common.DataColumnMapping("MenuIcon", "MenuIcon"), New System.Data.Common.DataColumnMapping("MenuIconExpanded", "MenuIconExpanded"), New System.Data.Common.DataColumnMapping("Sequence", "Sequence"), New System.Data.Common.DataColumnMapping("MenuStartID", "MenuStartID"), New System.Data.Common.DataColumnMapping("MenuStartCode", "MenuStartCode"), New System.Data.Common.DataColumnMapping("MenuStartCode2", "MenuStartCode2")})})
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = resources.GetString("OleDbSelectCommand3.CommandText")
        '
        'OleDbDataAdapter3
        '
        Me.OleDbDataAdapter3.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapter3.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter3.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "systemmenutree", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ParentID", "ParentID"), New System.Data.Common.DataColumnMapping("MenuID", "MenuID"), New System.Data.Common.DataColumnMapping("Sequence", "Sequence")})})
        Me.OleDbDataAdapter3.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM systemmenutree WHERE (MenuID = ?) AND (ParentID = ?) AND (Sequence = " & _
            "? OR ? IS NULL AND Sequence IS NULL)"
        Me.OleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ParentID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ParentID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sequence", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sequence", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sequence1", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sequence", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO systemmenutree(ParentID, MenuID, Sequence) VALUES (?, ?, ?); SELECT P" & _
            "arentID, MenuID, Sequence FROM systemmenutree WHERE (MenuID = ?) AND (ParentID =" & _
            " ?)"
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ParentID", System.Data.OleDb.OleDbType.[Integer], 4, "ParentID"), New System.Data.OleDb.OleDbParameter("MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID"), New System.Data.OleDb.OleDbParameter("Sequence", System.Data.OleDb.OleDbType.[Integer], 4, "Sequence"), New System.Data.OleDb.OleDbParameter("Select_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID"), New System.Data.OleDb.OleDbParameter("Select_ParentID", System.Data.OleDb.OleDbType.[Integer], 4, "ParentID")})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT ParentID, MenuID, Sequence FROM systemmenutree"
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = resources.GetString("OleDbUpdateCommand2.CommandText")
        Me.OleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ParentID", System.Data.OleDb.OleDbType.[Integer], 4, "ParentID"), New System.Data.OleDb.OleDbParameter("MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID"), New System.Data.OleDb.OleDbParameter("Sequence", System.Data.OleDb.OleDbType.[Integer], 4, "Sequence"), New System.Data.OleDb.OleDbParameter("Original_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ParentID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ParentID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sequence", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sequence", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sequence1", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sequence", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Select_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID"), New System.Data.OleDb.OleDbParameter("Select_ParentID", System.Data.OleDb.OleDbType.[Integer], 4, "ParentID")})
        '
        'HelpProvider1
        '
        resources.ApplyResources(Me.HelpProvider1, "HelpProvider1")
        '
        'frmSystemMenu_Browse
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusBar1)
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpKeyword(Me, resources.GetString("$this.HelpKeyword"))
        Me.MaximizeBox = False
        Me.Name = "frmSystemMenu_Browse"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Splitter1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    'ToBeChecked *** Modify the ValidateBeforeDelete Function
    Dim SQLTxt1 As String
    Dim TableName As String = "systemmenu"
    Dim frm As frmsystemmenu_Maintenance
    Dim MaintenanceMenuID As Integer = 391
    Dim NameField As String = "MenuLabel"

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            HelpProvider1.HelpNamespace = ".\Help\" & SessionInfo.UserLang & "\BizzKeys.chm"
            SQLTxt1 = OleDbDataAdapter1.SelectCommand.CommandText
            'Attempt to load the dataset.
            Me.LoadDataSet()
            BKGlobal.LoadAssociatedMenu(Me.Tag, PopMenuAssociatedTasks, Me)
            'BKGlobal.LoadMenuTree1(objDS.Tables("MenuTree"), treeApplication)
            RefreshMenuTree()
            'treeApplication.Nodes(0).Expanded = True
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
    End Sub
    Private Sub frm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        UpdateDataSet()
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case e.Button.Tag.ToString
            Case "btnNew1"
                NewRecord()
            Case "btnDelete1"
                DeleteRecord()
            Case "btnEdit1"
                EditRecord()
            Case "btnSave1"
                UpdateDataSet()
        End Select
    End Sub
    Private Sub NewRecord()
        'NEW With detail Window
        frm = New frmsystemmenu_Maintenance(SessionInfo)   'Activator.CreateInstance(frm.GetType)
        'frm.KeyID = -1
        frm.OpenType = "NEW"
        frm.Tag = MaintenanceMenuID

        frm.ShowDialog(Me)
        LoadDataSet()

        'Dim _frm As New frmsystemmenu_Maintenance
        '_frm.KeyValue = ""
        '_frm.OpenType = "NEW"
        '_frm.ShowDialog(Me)
        'LoadDataSet()
    End Sub
    Private Sub EditRecord()
        Dim _RowHandle As Integer
        Dim _Name As String
        Dim drv As DataRowView
        'frm = Activator.CreateInstance(frm.GetType)
        frm = New frmsystemmenu_Maintenance(SessionInfo)
        drv = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)
        frm.KeyValue = drv("MenuID")

        _Name = frm.KeyValue
        frm.OpenType = "EDIT"
        frm.Tag = MaintenanceMenuID

        frm.ShowDialog(Me)
        LoadDataSet()
        _RowHandle = _GridView1.LocateByValue(0, _GridView1.Columns("MenuID"), _Name)
        If _RowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            GridView1.TopRowIndex = _RowHandle
            GridView1.FocusedRowHandle = _RowHandle
        End If
        RefreshMenuTree()
        'Dim _frm As New frmsystemmenu_Maintenance
        'Dim _Pos As Integer
        '_Pos = Me.BindingContext(objDS, TableName).Position
        '_frm.KeyValue = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("MenuLabel"))
        '_frm.OpenType = "EDIT"
        '_frm.ShowDialog(Me)
        'LoadDataSet()
        'Me.BindingContext(objDS, TableName).Position = _Pos
    End Sub
    Private Sub DeleteRecord()
        'Msg = 1 = Confirm Delete
        If MsgBox(BKGlobal.GetMsg(1, SessionInfo.UserLang), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If ValidateBeforeDelete() Then
                Try
                    'Delete MenuTree Entry
                    'Delete MenuUser Entries
                    'Delete MenuRoles Entries
                    GridView1.DeleteRow(GridView1.FocusedRowHandle)
                    Me.UpdateDataSet()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub
    Private Function ValidateBeforeDelete() As Boolean
        Return True
    End Function
    Private Sub UndoChanges()
        LoadDataSet()
    End Sub
    Private Sub SaveChanges()
        UpdateDataSet()
    End Sub

    Public Sub UpdateDataSet()
        GridView1.CloseEditor()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As BizzLib.dsSystem = New BizzLib.dsSystem
        'Stop any current edits.
        Me.BindingContext(objDS, TableName).EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objDS.GetChanges, BizzLib.dsSystem)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Cls1.UpdateDataSource(objDataSetChanges.Tables("systemmenu"), OleDbDataAdapter1)
                Cls1.UpdateDataSource(objDataSetChanges.Tables("systemmenutree"), OleDbDataAdapter3)
                objDS.Merge(objDataSetChanges)
                objDS.AcceptChanges()
            Catch eUpdate As System.Exception
                'Add your error handling code here.
                Throw eUpdate
            End Try
            'Add your code to check the returned dataset for any errors that may have been
            'pushed into the row object's error.
        End If

    End Sub
    Public Sub LoadDataSet()
        'Create a new dataset to hold the records returned from the call to FillDataSet.
        'A temporary dataset is used because filling the existing dataset would
        'require the databindings to be rebound.
        Dim objDataSetTemp As New BizzLib.dsSystem
        Try
            OleDbDataAdapter1.SelectCommand.CommandText = SQLTxt1
            'Attempt to fill the temporary dataset.
            PlushData.clsConnection.FillDataSet(objDataSetTemp.Tables("systemmenu"), SQLTxt1)
            PlushData.clsConnection.FillDataSet(objDataSetTemp.Tables("systemmenutree"), OleDbDataAdapter3.SelectCommand.CommandText)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objDS.Clear()
            'Merge the records into the main dataset.
            objDS.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try
    End Sub

    Private Sub ToolBar2_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar2.ButtonClick
        Select Case e.Button.Tag.ToString
            Case "btnDown"
                MoveMenuDown()
            Case "btnUp"
                MoveMenuUp()
            Case "btnLeft"
                MoveMenuLeft()
            Case "btnRight"
                MoveMenuRight()
            Case "btnRefresh"
                RefreshMenuTree()
            Case "btnPlus"
                btnPlus_Click()
            Case "btnMinus"
                btnMinus_Click()
        End Select
    End Sub
    Private Sub UpdateSequence(ByVal seq As Integer, ByVal menu_id As Integer)
        Dim sql As String

        sql = "Update systemmenutree SET Sequence = " & seq & " WHERE MenuID = " & menu_id
        PlushData.clsConnection.ExecuteNonQuery(sql)
    End Sub

    Private Sub moveMenuUpDown(ByVal currentNode As DevExpress.XtraTreeList.Nodes.TreeListNode, ByVal moveNode As DevExpress.XtraTreeList.Nodes.TreeListNode)
        Dim seqTemp As Integer
        Dim Keysequence As String = "Sequence"
        Dim KeyParent As String = "ParentID"
        Dim keyMenu As String = "MenuID"
        If Not IsNothing(moveNode) Then
            'Check same Parent 
            If currentNode(KeyParent) = moveNode(KeyParent) Then
                seqTemp = currentNode(Keysequence)
                currentNode(Keysequence) = moveNode(Keysequence)
                moveNode(Keysequence) = seqTemp
                UpdateSequence(currentNode(Keysequence), currentNode(keyMenu))
                UpdateSequence(moveNode(Keysequence), moveNode(keyMenu))
                TreeList1.Columns(Keysequence).SortOrder = SortOrder.Ascending
            Else
                MsgBox("Error Parent_id Check this", MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Private Sub MoveMenuDown()

        Dim currentNode As DevExpress.XtraTreeList.Nodes.TreeListNode
        Dim Keysequence As String = "Sequence"

        currentNode = TreeList1.FocusedNode
        If Not IsNothing(currentNode) AndAlso Not IsNothing(currentNode.NextNode) Then
            If currentNode(Keysequence) = currentNode.NextNode(Keysequence) Then
                currentNode(Keysequence) = currentNode.NextNode(Keysequence) + 1
            End If
            moveMenuUpDown(TreeList1.FocusedNode, currentNode.NextNode)
        End If
    End Sub
    Private Sub MoveMenuUp()

        Dim currentNode As DevExpress.XtraTreeList.Nodes.TreeListNode
        Dim Keysequence As String = "Sequence"

        currentNode = TreeList1.FocusedNode
        If Not IsNothing(currentNode) AndAlso Not IsNothing(currentNode.PrevNode) Then
            If currentNode(Keysequence) = currentNode.PrevNode(Keysequence) Then
                currentNode(Keysequence) = currentNode.PrevNode(Keysequence) - 1
            End If
            moveMenuUpDown(TreeList1.FocusedNode, currentNode.PrevNode)
        End If
    End Sub
    Private Sub MoveMenuLeft()
        Dim _N As DevExpress.XtraTreeList.Nodes.TreeListNode
        Dim _N1 As DevExpress.XtraTreeList.Nodes.TreeListNode
        Dim _N2 As DevExpress.XtraTreeList.Nodes.TreeListNode
        Dim _Seq As Integer
        _N = TreeList1.FocusedNode
        If Not IsNothing(_N) Then
            _N1 = _N.ParentNode
            If Not IsNothing(_N1) Then
                _Seq = _N1("Sequence")
                'The Node Moving to Left will Have N1 Seq Nbr
                'Moving N1 and All Next Nodes  Seq Down
                _N2 = _N1
                Do
                    _N2("Sequence") += 1
                    Cls1.ExecuteNonQuery("Update systemmenutree SET Sequence = " & _N2("Sequence") & _
                        " WHERE MenuID = " & _N2("MenuID") & " AND ParentID = " & _N2("ParentID"))
                    _N2 = _N2.NextNode
                    If IsNothing(_N2) Then Exit Do
                Loop
                Cls1.ExecuteNonQuery("Update systemmenutree SET Sequence = " & _Seq & " , ParentID = " & _N1("ParentID") & _
                    " WHERE MenuID = " & _N("MenuID") & " AND ParentID = " & _N("ParentID"))
                _N("Sequence") = _Seq
                'Cls1.ExecuteNonQuery("Update systemmenutree SET ParentID = " & _N1("ParentID") & _
                '                    " WHERE MenuID = " & _N("MenuID") & " AND ParentID = " & _N("ParentID"))
                _N("ParentID") = _N1("ParentID")
                Dim _MenuID As Integer = _N("MenuID")
                RefreshMenuTree()
                TreeList1.SetFocusedNode(TreeList1.FindNodeByKeyID(_MenuID))
            End If
        End If
    End Sub
    Private Sub MoveMenuRight()
        Dim _N As DevExpress.XtraTreeList.Nodes.TreeListNode
        Dim _N1 As DevExpress.XtraTreeList.Nodes.TreeListNode
        Dim _N2 As DevExpress.XtraTreeList.Nodes.TreeListNode
        Dim _Seq As Integer
        _N = TreeList1.FocusedNode
        If Not IsNothing(_N) Then
            _N1 = _N.NextNode
            If Not IsNothing(_N1) Then
                If _N1.HasChildren Then
                    _Seq = _N1("Sequence")
                    'The Node Moving to Left will Have N1 Seq Nbr
                    'Moving N1 and All Next Nodes  Seq Down
                    _N2 = _N1.FirstNode
                    Do
                        _N2("Sequence") += 1
                        Cls1.ExecuteNonQuery("Update systemmenutree SET Sequence = " & _N2("Sequence") & _
                            " WHERE MenuID = " & _N2("MenuID") & " AND ParentID = " & _N2("ParentID"))
                        _N2 = _N2.NextNode
                        If IsNothing(_N2) Then Exit Do
                    Loop
                Else
                    _Seq = 1
                End If
                Cls1.ExecuteNonQuery("Update systemmenutree SET Sequence = " & _Seq & " , ParentID = " & _N1("MenuID") & _
                    " WHERE MenuID = " & _N("MenuID") & " AND ParentID = " & _N("ParentID"))
                _N("Sequence") = _Seq
                _N("ParentID") = _N1("MenuID")
                Dim _MenuID As Integer = _N("MenuID")
                RefreshMenuTree()
                TreeList1.SetFocusedNode(TreeList1.FindNodeByKeyID(_MenuID))
            End If
        End If
    End Sub
    Private Sub btnMinus_Click()
        Dim _Node, _PreviousNode As DevExpress.XtraTreeList.Nodes.TreeListNode
        Dim _Answ As MsgBoxResult
        Dim _ParentID As Integer
        'Message 1 = Confirm Delete
        _Answ = MsgBox(BKGlobal.GetMsg(1, SessionInfo.UserLang), MsgBoxStyle.OkCancel)
        If _Answ = MsgBoxResult.Cancel Then
            Exit Sub
        End If
        _Node = TreeList1.FocusedNode 'treeApplication.ActiveNode
        If Not IsNothing(_Node.ParentNode) Then
            _PreviousNode = _Node.ParentNode
            DeleteMenuTreeEntry(_Node("MenuID"), _Node("ParentID"))
        Else
            _PreviousNode = TreeList1.Nodes(0) 'treeApplication.Nodes(0)
            DeleteMenuTreeEntry(_Node("MenuID"), 0)
        End If
        _ParentID = CInt(_PreviousNode("MenuID"))
        UpdateDataSet()
        Dim _MenuID As Integer = _PreviousNode("MenuID")
        RefreshMenuTree()
        TreeList1.SetFocusedNode(TreeList1.FindNodeByKeyID(_MenuID))
        TreeList1.FocusedNode.Expanded = True
    End Sub
    Private Sub btnPlus_Click()
        Dim _Node As DevExpress.XtraTreeList.Nodes.TreeListNode
        Dim _MenuIDToAdd As Integer
        Dim _View As DataView
        Dim _Row As DataRow
        Dim _NextSequence As Integer = 1
        Dim _ParentID As Integer

        _Node = TreeList1.FocusedNode  'treeApplication.ActiveNode
        'Getting MenuID to assign
        _MenuIDToAdd = CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("MenuID")))
        'Getting ParentID to Assign
        If Not IsNothing(_Node.ParentNode) Then
            _ParentID = _Node("ParentID")  'treeApplication.ActiveNode.Parent.Key
        Else
            _ParentID = 0
        End If
        'Getting Next Sequence to Assign
        _View = New DataView(objDS.Tables("systemmenutree"), "ParentID = " & _ParentID, _
                         "Sequence", DataViewRowState.CurrentRows)
        If _View.Count > 0 Then
            _NextSequence = _View(_View.Count - 1)("Sequence") + 1
        End If
        'Check If not exist at another level
        _View = New DataView(objDS.Tables("systemmenutree"), "MenuID = " & _MenuIDToAdd, _
                                 "Sequence", DataViewRowState.CurrentRows)
        If _View.Count > 0 Then
            MsgBox("Already exist for as Child of MenuID: " & _View(0)("ParentID"), MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        'Check if already exist
        _Row = objDS.Tables("systemmenutree").Rows.Find(New Object() {_ParentID, _MenuIDToAdd})
        If IsNothing(_Row) Then
            'Adding the Data
            _Row = objDS.Tables("systemmenutree").NewRow
            _Row("MenuID") = _MenuIDToAdd
            _Row("ParentID") = _ParentID
            _Row("Sequence") = _NextSequence
            objDS.Tables("systemmenutree").Rows.Add(_Row)
            UpdateDataSet()
            'Refresh Tree View
            RefreshMenuTree()
            TreeList1.SetFocusedNode(TreeList1.FindNodeByKeyID(_MenuIDToAdd))
            TreeList1.FocusedNode.Expanded = True
        End If
    End Sub
    Private Sub RefreshMenuTree()
        'Load All Menus - No AccessAllowed to setup because it is the design of the Menu
        objDS.Tables("systemmenutreeView1").Clear()
        PlushData.clsConnection.FillDataSet(objDS.Tables("systemmenutreeView1"), MenuTreeSQLTxt)
        TreeList1.Columns("Sequence").SortOrder = SortOrder.Ascending
    End Sub
    Private Sub DeleteMenuTreeEntry(ByVal MenuID As Integer, ByVal ParentID As Integer)
        Dim _CurrentRow As DataRow
        Dim _View As DataView
        Dim _RowV As DataRowView

        _CurrentRow = objDS.Tables("systemmenutree").Rows.Find(New Object() {ParentID, MenuID})
        If Not IsNothing(_CurrentRow) Then
            Do
                'Deleting Childs
                _View = New DataView(objDS.Tables("systemmenutree"), "ParentID = " & MenuID, _
                         "Sequence", DataViewRowState.CurrentRows)
                If _View.Count > 0 Then
                    _RowV = _View(0)
                    DeleteMenuTreeEntry(_RowV("MenuID"), _RowV("ParentID"))
                Else
                    Exit Do
                End If
            Loop
            _CurrentRow.Delete()
        End If

    End Sub

    Private Sub TreeList1_AfterFocusNode(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles TreeList1.AfterFocusNode
        GotoBrowseRecord()
    End Sub

    Private Sub GotoBrowseRecord()
        Dim _row As DataRow
        Dim _Node, _ParentNode As DevExpress.XtraTreeList.Nodes.TreeListNode
        Dim _ParentID As Integer
        Dim _GridView As DevExpress.XtraGrid.Views.Base.ColumnView = Grid1.MainView
        Dim _RowHandle As Integer

        _Node = TreeList1.FocusedNode
        If IsNothing(_Node) Then
            Exit Sub
        End If
        _ParentNode = _Node.ParentNode
        If IsNothing(_ParentNode) Then
            _ParentID = 0
        Else
            _ParentID = _Node("ParentID")
        End If
        _row = objDS.Tables("systemmenutree").Rows.Find(New Object() {_ParentID, _Node("MenuID")})
        If Not IsNothing(_row) Then
            StatusBar1.Panels(0).Text = "MenuID: " & _Node("MenuID") & ", Parent MenuID: " & _ParentID & ", Sequence: " & _row("Sequence") & "."
        Else
            StatusBar1.Panels(0).Text = ""
        End If

        'Selecting the Appropriate Menu in the Grid
        _RowHandle = _GridView.LocateByValue(0, _GridView.Columns("MenuID"), _Node("MenuID"))
        GridView1.TopRowIndex = _RowHandle
        GridView1.FocusedRowHandle = _RowHandle
    End Sub

    Private Sub ShortCutPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid1.KeyDown, ToolBar1.KeyDown, MyBase.KeyDown
        'MsgBox(e.Modifiers & " " & e.KeyData)
        If e.KeyCode = SessionInfo.ShortCut.DeleteKey And e.Modifiers = SessionInfo.ShortCut.DeleteModifier Then
            DeleteRecord()
        End If
        If e.KeyCode = SessionInfo.ShortCut.AddKey And e.Modifiers = SessionInfo.ShortCut.AddModifier Then
            NewRecord()
        End If
        If e.KeyCode = SessionInfo.ShortCut.EditKey And e.Modifiers = SessionInfo.ShortCut.EditModifier Then
            EditRecord()
        End If
        If e.KeyCode = SessionInfo.ShortCut.SaveKey And e.Modifiers = SessionInfo.ShortCut.SaveModifier Then
            UpdateDataSet()
        End If
        If e.KeyCode = SessionInfo.ShortCut.UndoKey And e.Modifiers = SessionInfo.ShortCut.UndoModifier Then
            GridView1.CancelUpdateCurrentRow()
        End If
    End Sub
    Private Sub PopMenuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuNew.Click
        NewRecord()
    End Sub
    Private Sub PopMenuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuEdit.Click
        EditRecord()
    End Sub
    Private Sub PopMenuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuDelete.Click
        DeleteRecord()
    End Sub
    Private Sub PopMenuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuSave.Click
        UpdateDataSet()
    End Sub

    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        EditRecord()
    End Sub
    Private Sub GridView1_BeforeLeaveRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles GridView1.BeforeLeaveRow
        UpdateDataSet()
    End Sub

    Private Sub TreeList1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles TreeList1.CellValueChanged
        Dim _N As DevExpress.XtraTreeList.Nodes.TreeListNode
        _N = TreeList1.FocusedNode
        Dim _MenuID As Integer
        If IsNothing(_N) Then Exit Sub
        _MenuID = _N("MenuID")
        Dim _row As DataRow
        _row = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If IsNothing(_row) Then Exit Sub
        Select Case e.Column.FieldName
            Case "MenuStartID"
                _row("MenuStartID") = _N("MenuStartID")
            Case "MenuStartCode"
                _row("MenuStartCode") = _N("MenuStartCode")
            Case "MenuStartCode2"
                _row("MenuStartCode2") = _N("MenuStartCode2")
        End Select
        UpdateDataSet()
        RefreshMenuTree()
        TreeList1.SetFocusedNode(TreeList1.FindNodeByKeyID(_MenuID))
    End Sub
End Class
