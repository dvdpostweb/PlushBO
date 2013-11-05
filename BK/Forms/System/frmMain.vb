Public Class frmMain
    Inherits Form

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

            ' avoid loos data 
            Dim cpt As Integer
            PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.LOGIN, cpt)

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
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents RightMouseMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents btnGO As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMenuStartID As System.Windows.Forms.TextBox
    Friend WithEvents lblMenuStartID As System.Windows.Forms.Label
    Friend WithEvents PanelBottomMenu As System.Windows.Forms.Panel
    Friend WithEvents ToolBar2 As System.Windows.Forms.ToolBar
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents btnRefreshMenuTree As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnChangeDatabase As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnChangeEntity As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnUserInfo As System.Windows.Forms.ToolBarButton
    Friend WithEvents PanelStartID As System.Windows.Forms.StatusBarPanel
    Friend WithEvents DockPanelMenu As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Public WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents colMenuLabel As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents objDS As BizzLib.dsSystem
    Friend WithEvents colMenuStartID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colMenuStartCode As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colMenuStartCode2 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Public WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Public WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents colSequence As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TimerMySQL As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.RightMouseMenu = New System.Windows.Forms.ContextMenu
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanelMenu = New DevExpress.XtraBars.Docking.DockPanel
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.colMenuLabel = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colMenuStartID = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colMenuStartCode = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colMenuStartCode2 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colSequence = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.PanelBottomMenu = New System.Windows.Forms.Panel
        Me.ToolBar2 = New System.Windows.Forms.ToolBar
        Me.btnRefreshMenuTree = New System.Windows.Forms.ToolBarButton
        Me.btnChangeDatabase = New System.Windows.Forms.ToolBarButton
        Me.btnChangeEntity = New System.Windows.Forms.ToolBarButton
        Me.btnUserInfo = New System.Windows.Forms.ToolBarButton
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.PanelStartID = New System.Windows.Forms.StatusBarPanel
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnGO = New DevExpress.XtraEditors.SimpleButton
        Me.txtMenuStartID = New System.Windows.Forms.TextBox
        Me.lblMenuStartID = New System.Windows.Forms.Label
        Me.objDS = New BizzLib.dsSystem
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.TimerMySQL = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanelMenu.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBottomMenu.SuspendLayout()
        CType(Me.PanelStartID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "")
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "systemmenu", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ParentID", "ParentID"), New System.Data.Common.DataColumnMapping("MenuID", "MenuID"), New System.Data.Common.DataColumnMapping("MenuLabel", "MenuLabel"), New System.Data.Common.DataColumnMapping("MenuForm", "MenuForm"), New System.Data.Common.DataColumnMapping("MenuIcon", "MenuIcon"), New System.Data.Common.DataColumnMapping("MenuIconExpanded", "MenuIconExpanded"), New System.Data.Common.DataColumnMapping("Sequence", "Sequence"), New System.Data.Common.DataColumnMapping("MenuStartID", "MenuStartID"), New System.Data.Common.DataColumnMapping("MenuStartCode", "MenuStartCode"), New System.Data.Common.DataColumnMapping("MenuStartCode2", "MenuStartCode2")})})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = resources.GetString("OleDbSelectCommand1.CommandText")
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "systemmenu", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MenuID", "MenuID"), New System.Data.Common.DataColumnMapping("MenuLabel", "MenuLabel"), New System.Data.Common.DataColumnMapping("MenuForm", "MenuForm"), New System.Data.Common.DataColumnMapping("MenuIcon", "MenuIcon"), New System.Data.Common.DataColumnMapping("MenuIconExpanded", "MenuIconExpanded"), New System.Data.Common.DataColumnMapping("MenuStartID", "MenuStartID"), New System.Data.Common.DataColumnMapping("MenuStartCode", "MenuStartCode"), New System.Data.Common.DataColumnMapping("MenuStartCode2", "MenuStartCode2")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuForm", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuForm1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIcon", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIcon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIcon1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIcon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIconExpanded", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIconExpanded", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIconExpanded1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIconExpanded", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuLabel", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuLabel", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuLabel1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuLabel", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode2", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode2", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode21", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode2", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartID1", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = resources.GetString("OleDbInsertCommand1.CommandText")
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID"), New System.Data.OleDb.OleDbParameter("MenuLabel", System.Data.OleDb.OleDbType.VarChar, 50, "MenuLabel"), New System.Data.OleDb.OleDbParameter("MenuForm", System.Data.OleDb.OleDbType.VarChar, 100, "MenuForm"), New System.Data.OleDb.OleDbParameter("MenuIcon", System.Data.OleDb.OleDbType.VarChar, 100, "MenuIcon"), New System.Data.OleDb.OleDbParameter("MenuIconExpanded", System.Data.OleDb.OleDbType.VarChar, 100, "MenuIconExpanded"), New System.Data.OleDb.OleDbParameter("MenuStartID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuStartID"), New System.Data.OleDb.OleDbParameter("MenuStartCode", System.Data.OleDb.OleDbType.VarChar, 50, "MenuStartCode"), New System.Data.OleDb.OleDbParameter("MenuStartCode2", System.Data.OleDb.OleDbType.VarChar, 50, "MenuStartCode2"), New System.Data.OleDb.OleDbParameter("Select_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID")})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT MenuID, MenuLabel, MenuForm, MenuIcon, MenuIconExpanded, MenuStartID, Menu" & _
            "StartCode, MenuStartCode2 FROM systemmenu"
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID"), New System.Data.OleDb.OleDbParameter("MenuLabel", System.Data.OleDb.OleDbType.VarChar, 50, "MenuLabel"), New System.Data.OleDb.OleDbParameter("MenuForm", System.Data.OleDb.OleDbType.VarChar, 100, "MenuForm"), New System.Data.OleDb.OleDbParameter("MenuIcon", System.Data.OleDb.OleDbType.VarChar, 100, "MenuIcon"), New System.Data.OleDb.OleDbParameter("MenuIconExpanded", System.Data.OleDb.OleDbType.VarChar, 100, "MenuIconExpanded"), New System.Data.OleDb.OleDbParameter("MenuStartID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuStartID"), New System.Data.OleDb.OleDbParameter("MenuStartCode", System.Data.OleDb.OleDbType.VarChar, 50, "MenuStartCode"), New System.Data.OleDb.OleDbParameter("MenuStartCode2", System.Data.OleDb.OleDbType.VarChar, 50, "MenuStartCode2"), New System.Data.OleDb.OleDbParameter("Original_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuForm", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuForm1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIcon", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIcon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIcon1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIcon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIconExpanded", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIconExpanded", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIconExpanded1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIconExpanded", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuLabel", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuLabel", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuLabel1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuLabel", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode2", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode2", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode21", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode2", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartID1", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Select_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID")})
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = ".\Help\BizzKeys.chm"
        '
        'Splitter1
        '
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Splitter1.Location = New System.Drawing.Point(371, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(10, 422)
        Me.Splitter1.TabIndex = 6
        Me.Splitter1.TabStop = False
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanelMenu})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar"})
        '
        'DockPanelMenu
        '
        Me.DockPanelMenu.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanelMenu.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanelMenu.ID = New System.Guid("19e798fd-2ba6-4fef-8ca0-ae0d861b7707")
        Me.DockPanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.DockPanelMenu.Name = "DockPanelMenu"
        Me.DockPanelMenu.Options.ShowCloseButton = False
        Me.DockPanelMenu.Options.ShowMaximizeButton = False
        Me.DockPanelMenu.Size = New System.Drawing.Size(371, 422)
        Me.DockPanelMenu.Text = "Menu"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.XtraTabControl1)
        Me.DockPanel1_Container.Controls.Add(Me.PanelBottomMenu)
        Me.DockPanel1_Container.Controls.Add(Me.PanelControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 25)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(365, 394)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 40)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(365, 322)
        Me.XtraTabControl1.TabIndex = 6
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.TreeList1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(356, 292)
        Me.XtraTabPage1.Text = "Tree Menu"
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
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colMenuLabel, Me.colMenuStartID, Me.colMenuStartCode, Me.colMenuStartCode2, Me.colSequence})
        Me.TreeList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeList1.KeyFieldName = "MenuID"
        Me.TreeList1.Location = New System.Drawing.Point(0, 0)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsView.EnableAppearanceEvenRow = True
        Me.TreeList1.OptionsView.EnableAppearanceOddRow = True
        Me.TreeList1.OptionsView.ShowHorzLines = False
        Me.TreeList1.OptionsView.ShowIndicator = False
        Me.TreeList1.OptionsView.ShowVertLines = False
        Me.TreeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.TreeList1.Size = New System.Drawing.Size(356, 292)
        Me.TreeList1.TabIndex = 1
        '
        'colMenuLabel
        '
        Me.colMenuLabel.Caption = "MenuLabel"
        Me.colMenuLabel.FieldName = "MenuLabel"
        Me.colMenuLabel.Name = "colMenuLabel"
        Me.colMenuLabel.OptionsColumn.AllowEdit = False
        Me.colMenuLabel.Visible = True
        Me.colMenuLabel.VisibleIndex = 0
        Me.colMenuLabel.Width = 250
        '
        'colMenuStartID
        '
        Me.colMenuStartID.Caption = "MenuStartID"
        Me.colMenuStartID.FieldName = "MenuStartID"
        Me.colMenuStartID.Name = "colMenuStartID"
        Me.colMenuStartID.OptionsColumn.AllowEdit = False
        Me.colMenuStartID.Visible = True
        Me.colMenuStartID.VisibleIndex = 3
        '
        'colMenuStartCode
        '
        Me.colMenuStartCode.Caption = "MenuStartCode"
        Me.colMenuStartCode.FieldName = "MenuStartCode"
        Me.colMenuStartCode.Name = "colMenuStartCode"
        Me.colMenuStartCode.OptionsColumn.AllowEdit = False
        Me.colMenuStartCode.Visible = True
        Me.colMenuStartCode.VisibleIndex = 1
        '
        'colMenuStartCode2
        '
        Me.colMenuStartCode2.Caption = "MenuStartCode2"
        Me.colMenuStartCode2.FieldName = "MenuStartCode2"
        Me.colMenuStartCode2.Name = "colMenuStartCode2"
        Me.colMenuStartCode2.OptionsColumn.AllowEdit = False
        Me.colMenuStartCode2.Visible = True
        Me.colMenuStartCode2.VisibleIndex = 2
        '
        'colSequence
        '
        Me.colSequence.Caption = "Sequence"
        Me.colSequence.FieldName = "Sequence"
        Me.colSequence.Name = "colSequence"
        Me.colSequence.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.PageVisible = False
        Me.XtraTabPage2.Size = New System.Drawing.Size(356, 292)
        Me.XtraTabPage2.Text = "Agenda"
        '
        'PanelBottomMenu
        '
        Me.PanelBottomMenu.Controls.Add(Me.ToolBar2)
        Me.PanelBottomMenu.Controls.Add(Me.StatusBar1)
        Me.PanelBottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottomMenu.Location = New System.Drawing.Point(0, 362)
        Me.PanelBottomMenu.Name = "PanelBottomMenu"
        Me.PanelBottomMenu.Size = New System.Drawing.Size(365, 32)
        Me.PanelBottomMenu.TabIndex = 5
        '
        'ToolBar2
        '
        Me.ToolBar2.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar2.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.btnRefreshMenuTree, Me.btnChangeDatabase, Me.btnChangeEntity, Me.btnUserInfo})
        Me.ToolBar2.ButtonSize = New System.Drawing.Size(23, 22)
        Me.ToolBar2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolBar2.DropDownArrows = True
        Me.ToolBar2.ImageList = Me.ImageList1
        Me.ToolBar2.Location = New System.Drawing.Point(136, 0)
        Me.ToolBar2.Name = "ToolBar2"
        Me.ToolBar2.ShowToolTips = True
        Me.ToolBar2.Size = New System.Drawing.Size(229, 28)
        Me.ToolBar2.TabIndex = 2
        '
        'btnRefreshMenuTree
        '
        Me.btnRefreshMenuTree.ImageIndex = 1
        Me.btnRefreshMenuTree.Name = "btnRefreshMenuTree"
        Me.btnRefreshMenuTree.Tag = "btnRefreshMenuTree"
        '
        'btnChangeDatabase
        '
        Me.btnChangeDatabase.ImageIndex = 10
        Me.btnChangeDatabase.Name = "btnChangeDatabase"
        Me.btnChangeDatabase.Tag = "btnChangeDatabase"
        Me.btnChangeDatabase.ToolTipText = "Change Current Database"
        '
        'btnChangeEntity
        '
        Me.btnChangeEntity.ImageIndex = 11
        Me.btnChangeEntity.Name = "btnChangeEntity"
        Me.btnChangeEntity.Tag = "btnChangeEntity"
        Me.btnChangeEntity.ToolTipText = "Change Current Entity"
        '
        'btnUserInfo
        '
        Me.btnUserInfo.ImageIndex = 9
        Me.btnUserInfo.Name = "btnUserInfo"
        Me.btnUserInfo.Tag = "btnUserInfo"
        Me.btnUserInfo.ToolTipText = "Edit my Profile (Password, Langue, ...)"
        '
        'StatusBar1
        '
        Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.StatusBar1.Location = New System.Drawing.Point(0, 0)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.PanelStartID})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(136, 32)
        Me.StatusBar1.TabIndex = 1
        '
        'PanelStartID
        '
        Me.PanelStartID.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.PanelStartID.Name = "PanelStartID"
        Me.PanelStartID.Width = 119
        '
        'PanelControl1
        '
        Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl1.Controls.Add(Me.btnGO)
        Me.PanelControl1.Controls.Add(Me.txtMenuStartID)
        Me.PanelControl1.Controls.Add(Me.lblMenuStartID)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(365, 40)
        Me.PanelControl1.TabIndex = 8
        '
        'btnGO
        '
        Me.btnGO.ImageIndex = 8
        Me.btnGO.ImageList = Me.ImageList1
        Me.btnGO.Location = New System.Drawing.Point(216, 8)
        Me.btnGO.Name = "btnGO"
        Me.btnGO.Size = New System.Drawing.Size(24, 23)
        Me.btnGO.TabIndex = 1
        '
        'txtMenuStartID
        '
        Me.txtMenuStartID.Location = New System.Drawing.Point(112, 8)
        Me.txtMenuStartID.Name = "txtMenuStartID"
        Me.txtMenuStartID.Size = New System.Drawing.Size(100, 20)
        Me.txtMenuStartID.TabIndex = 0
        '
        'lblMenuStartID
        '
        Me.lblMenuStartID.Location = New System.Drawing.Point(6, 15)
        Me.lblMenuStartID.Name = "lblMenuStartID"
        Me.lblMenuStartID.Size = New System.Drawing.Size(100, 16)
        Me.lblMenuStartID.TabIndex = 0
        Me.lblMenuStartID.Text = "MenuID"
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsSystem"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "iMaginary"
        '
        'TimerMySQL
        '
        Me.TimerMySQL.Interval = 45000
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(896, 422)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.DockPanelMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "BizzKeys"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanelMenu.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBottomMenu.ResumeLayout(False)
        Me.PanelBottomMenu.PerformLayout()
        CType(Me.PanelStartID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public numArgs As Short
    Public ArgArray() As String
    Dim SQLTxt1 As String
    Public UserMenus() As BizzLib.clsUserMenu 'MenuItem
    Public UserMenu As New BizzLib.clsUserMenu("UserTasks", Me)
    Private Const DefaultNodeSelected As Integer = 647

    Sub GetCommandLine(Optional ByRef MaxArgs As Integer = 15)
        ' Declare variables.
        Dim separators As String = " "
        Dim commands As String = Microsoft.VisualBasic.Command()
        ArgArray = commands.Split(separators.ToCharArray)
        numArgs = ArgArray.Length
    End Sub
    Private Sub StartBatch(ByVal vAssembly As String, ByVal vObjectName As String, ByVal vMethodName As String)
        Dim _frm As BizzLib.frmBKForm 'Form
        Dim _Type As System.Type

        '_Type = BKGlobal.GetFormType("frmsystemdatabase_Browse", "DVDPost.exe")
        _Type = BKGlobal.GetFormType(vObjectName, vAssembly)
        _frm = Activator.CreateInstance(_Type)
        _frm.SetBKOjects(SessionInfo)
        _frm.Tag = -1
        _frm.Text = BKGlobal.GetFormBanner(-1) 'SessionInfo.UserFullName & " - " & SessionInfo.EntityName
        _frm.Icon = New System.Drawing.Icon(SessionInfo.FormIcon)
        _frm.ShowInTaskbar = SessionInfo.ShowInTaskBar
        Dim _Method As System.Reflection.MethodInfo
        '_Method = _Type.GetMethod("Test")
        _Method = _Type.GetMethod(vMethodName)
        _Method.Invoke(_frm, Nothing)
        _frm.Dispose()
    End Sub

    Private Sub frmMain_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        PlushBuziness.clsMsgError.FileAppend("PLUSH_Log_Connexion", "OUT " & PlushData.clsSession.FullName & " " & DateTime.Now().ToString())
    End Sub
    Private Sub frmSystemMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'OleDBConnInitialize() 'Load Database Connection String from INI file and Set it up
        'test parameters : -b DVDPost.exe frmsystemdatabase_Browse Test
        ' DvdPostData.clsConnection.typeEnv = "prod"
        '  SessionInfo = New BizzLib.clsSessionInfo(1, 0, "", "", "")
        ' CreateSuperUser() 'Check that Admin User with ID = 0 exist in User, Role, Entity, Holding, ....
        StartSession()
        GetCommandLine()
        If numArgs >= 4 Then
            If StrComp(ArgArray(0), "-b", CompareMethod.Text) = 0 Then
                StartBatch(ArgArray(1), ArgArray(2), ArgArray(3))
                End
            End If
        End If
    End Sub
    Private Sub frmSystemMainMenu_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        If DockPanelMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible Then
            txtMenuStartID.Focus()
        End If
    End Sub
    Private Function CopyFileAssembly(ByVal path As String, ByVal nameDestination As String) As Boolean

        path = path + "\" & nameDestination
        If System.IO.File.Exists(path) Then
            System.IO.File.Copy(path, nameDestination, True)
            'Return PlushTools.clsFtp.DisplayFileFromServer("http://www.dvdpost.be/images/newsletters/movies/FR/", "04.jpg", Nothing, Nothing)
            Return True
        End If
        Return False


    End Function

    Private Sub StartSession()
        'SessionInfo.DBName = DBName
        'SessionInfo.DBConnString = DBConnString
        'SessionInfo.DBConnType = UsedConnection

        Login()
        SessionInfo = New BizzLib.clsSessionInfo(PlushData.clsSession.user_id, 1, _
                    PlushData.clsConnection.typeEnv, PlushData.clsConnection.ConnectionString, "MySQL")

        BKGlobal = New BizzLib.clsGlobal(SessionInfo)
        'myBKGlobal = New BizzlibNew.BizzLibNew.clsGlobal(DvdPostData.Session.MySession)
        '    BKCombo = New BizzLib.clsCombo(SessionInfo)
        'EventHandler_UserMenuClick = New ContextMenuClick_EventHandler(AddressOf BKGlobal.ContextMenuClick)
        '   Me.Icon = New System.Drawing.Icon(SessionInfo.FormIcon)
        '  HelpProvider1.HelpNamespace = ".\Help\" & SessionInfo.UserLang & "\BizzKeys.chm"
        'Dim _UpgradeFrom As String = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT ParamValue FROM generalglobalparameter WHERE SetupCategory = 'GLOBAL' and Name = 'UpgradeFrom'")
        ' ne pas effacer ce bout de code


#If DEBUG Then
        Me.Text = "Version debug " & PlushData.clsSession.FullName
#Else
        '        Dim path As String
        '        Try
        '            'TODO UPGRADE                
        '            If CopyFileAssembly(_UpgradeFrom, "DVDPostLib.dll") Then
        '                path = _UpgradeFrom
        '                ' Else
        '                '    path = Application.StartupPath
        '            End If
        '            CopyFileAssembly(_UpgradeFrom, "DVDPostData.dll")
        '            CopyFileAssembly(_UpgradeFrom, "DVDPost.exe.config")

        '        Catch ex As Exception
        '            MsgBox("Error Update File " & ex.Message)
        '        End Try

        Dim assemblyBytes As Byte() = System.IO.File.ReadAllBytes(Application.StartupPath & "\PlushLib.dll")
        Dim assembly As System.Reflection.Assembly = System.Reflection.Assembly.Load(assemblyBytes)

        ' Dim version As Integer = DVDPostLib.clsSingleton.GetVersionAssembly()
        ' Dim dll As System.Reflection.Assembly = System.Reflection.Assembly.LoadFrom(path & "\DVDPostLib.dll")

        ''affiche la version et le nom de l utilisateur
        'Me.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " " & SessionInfo.UserDocPath & " " & assembly.GetName.Version.ToString & _
        '       " - " & SessionInfo.UserFullName & " - " & SessionInfo.EntityName & "(" & SessionInfo.EntityCurr & ")"
        Me.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " " & PlushData.clsConnection.typeEnv & " " & assembly.GetName.Version.ToString & " " & PlushData.clsSession.FullName
        PlushData.clsSession.Version = Me.Text

        PlushBuziness.clsMsgError.FileAppend("PLUSH_Log_Connexion", "IN " & PlushData.clsSession.FullName & " " & DateTime.Now().ToString())

#End If
        PlushData.clsSession.Version = Me.Text
        ' MsgBox(Application.StartupPath)
        ' ------- 
        'System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMajorPart & "." & _
        'System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMinorPart & _
        'Chr(97 + System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileBuildPart) & _
        '" - " & _
        'System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FilePrivatePart & _


        'SessionInfo.MDIStyle = True
        'If SessionInfo.MDIStyle = True Then
        Me.WindowState = FormWindowState.Maximized
        Me.IsMdiContainer = True
        'End If
        'If SessionInfo.AutoHideMenu = True Then
        '   DockPanelMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        'Else
        DockPanelMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
        ' End If
        MenuForm = Me
        If IsNothing(objDS.Tables("MenuTree")) Then
            objDS.Tables.Add("MenuTree")
        Else
            objDS.Tables("MenuTree").Clear()
        End If
        SQLTxt1 = OleDbDataAdapter1.SelectCommand.CommandText
        RefreshMenuTree()
        '
        'treeApplication.Nodes.Clear()
        'LoadDataSet()
        'BKGlobal.LoadMenuTree(objDS.Tables("MenuTree"), treeApplication)

        'If treeApplication.Nodes.Count > 0 Then
        '    treeApplication.Nodes(0).Expanded = True
        'End If
        ' LoadUserMenu()
        RightMouseMenu.MenuItems.Add(UserMenu.CloneMenu)
        txtMenuStartID.Focus()
    End Sub
    Private Sub Login()
        Dim _Frm As New frmSecurityLogin(SessionInfo)
        _Frm.ShowDialog(Me)
        SessionInfo = _Frm.SessionInfo
        '_Frm.Dispose()
    End Sub
    Public Sub LoadDataSet()
        Dim objService As New BizzLib.clsDataSet(SessionInfo)
        Try
            'Attempt to fill the temporary dataset.
            'Loading Menu Defibition
            'If SessionInfo.RoleID <> 0 Then
            '    OleDbDataAdapter1.SelectCommand.CommandText = SQLTxt1 & " WHERE RoleID = " & SessionInfo.RoleID
            'Else
            '    OleDbDataAdapter1.SelectCommand.CommandText = SQLTxt1 & " WHERE RoleID IS NULL "
            'End If
            objDS.Tables("MenuTree").Clear()
            objDS.Tables("systemmenu").Clear()
            PlushData.clsConnection.FillDataSet(objDS.Tables("MenuTree"), OleDbDataAdapter1.SelectCommand.CommandText)
            'Loading MenuTree
            PlushData.clsConnection.FillDataSet(objDS.Tables("systemmenu"), OleDbDataAdapter2.SelectCommand.CommandText)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
    End Sub

    Private Sub txtMenuID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMenuStartID.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            'If IsNumeric(txtMenuStartID.Text) Then
            StartingMenuID(txtMenuStartID.Text)
            'End If
        End If
    End Sub
    Private Sub btnGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGO.Click
        StartingMenuID(txtMenuStartID.Text)
    End Sub

#Region "Load Menu"
    Public Function GetFormType(ByVal FormName As String, ByVal AssemblyName As String) As Type
        Dim assembly As Reflection.Assembly = assembly.LoadFrom((SessionInfo.ApplDir & "\" & AssemblyName))
        Dim length As Integer = Strings.InStr(AssemblyName, ".", CompareMethod.Text)
        Dim str As String = Strings.Mid(AssemblyName, 1, length)
        Return [assembly].GetType((str & FormName), True)
    End Function
    Public Function SetGeneralBrowseParam(ByVal FRM As BizzLib.frmGeneral_Browse, ByVal MenuID As Integer) As Integer
        Dim sql As String
        Dim dt As DataTable

        sql = "SELECT * FROM systemmenu WHERE MenuID = " & MenuID
        dt = PlushData.clsConnection.FillDataSet(sql)

        If dt.Rows.Count = 1 Then
            Dim row As DataRow

            row = dt.Rows(0)

            FRM.TableName = row("BrowseTableName")
            FRM.IDField = row("BrowseIDField")
            FRM.NameField = row("BrowseNameField")
            FRM.MaintenanceMenuID = row("BrowsetoMaintMenuID")
            FRM.WhereClause = row("BrowseWhereClause")
            If (Strings.InStr(FRM.WhereClause, "@AllowedEntityList", CompareMethod.Text) <> 0) Then
                FRM.WhereClause = Strings.Replace(FRM.WhereClause, "@AllowedEntityList", SessionInfo.AllowedEntityList, 1, -1, CompareMethod.Text)
            End If
            If (Strings.InStr(FRM.WhereClause, "@EntityID", CompareMethod.Text) <> 0) Then
                FRM.WhereClause = Strings.Replace(FRM.WhereClause, "@EntityID", SessionInfo.EntityID.ToString(), 1, -1, CompareMethod.Text)
            End If
            FRM.OrderByClause = row("BrowseOrderByClause")
            Return 1
        End If
        Return 0

    End Function
    'Public Function GetFormBanner(ByVal MenuID As Integer) As String
    '    Dim sql As String
    '    Dim dt As DataTable
    '    sql = "SELECT * FROM systemmenu WHERE MenuID = " & MenuID
    '    dt = DvdPostData.clsConnection.FillDataSet(sql)

    '    If dt.Rows.Count = 1 Then
    '        Dim row As DataRow
    '        row = dt.Rows(0)
    '        Return row("MenuLabel")
    '    Else
    '        MsgBox("Error MenuID " & MenuID, MsgBoxStyle.Critical)
    '    End If

    '    Return ""
    'End Function
    Public Sub StartForm(ByVal FormName As String, ByVal AssemblyName As String, ByVal MenuID As Integer, ByVal MenuTitle As String, ByVal OwnerForm As Form, Optional ByVal ShowForm As Boolean = True)

        Dim form As BizzLib.frmBKForm
        If (FormName = "frmGeneral_Browse") Then
            form = New BizzLib.frmGeneral_Browse(SessionInfo)
            If (SetGeneralBrowseParam(DirectCast(form, BizzLib.frmGeneral_Browse), MenuID) = 0) Then
                Return
            End If
            form.Tag = MenuID
            form.Text = MenuTitle
            ' form.Icon = New Icon(SessionInfo.FormIcon)
            form.ShowInTaskbar = SessionInfo.ShowInTaskBar
            DirectCast(form, BizzLib.frmGeneral_Browse).StartUp()
        Else
            form = DirectCast(Activator.CreateInstance(Me.GetFormType(FormName, AssemblyName)), BizzLib.frmBKForm)
            form.SetBKOjects(SessionInfo)
            form.Tag = MenuID
            form.Text = MenuTitle
            ' form.Icon = New Icon(SessionInfo.FormIcon)
            form.ShowInTaskbar = SessionInfo.ShowInTaskBar
        End If
        SessionInfo.MDIStyle = True
        If SessionInfo.MDIStyle Then
            form.MdiParent = OwnerForm
            If ShowForm Then
                form.Show()

            End If
        Else
            form.MinimizeBox = True
            form.MaximizeBox = True
            If Information.IsNothing(OwnerForm) Then
                If ShowForm Then
                    form.Show()
                End If
            ElseIf ShowForm Then
                If (OwnerForm.Name = "frmSystemMainMenu") Then
                    form.Show()
                Else
                    form.ShowDialog(OwnerForm)
                End If
            End If
        End If

    End Sub
    Public Function StartMenuForm(ByVal MenuStartID As String) As Integer
        Dim sql As String
        Dim dt As DataTable
        Try
            sql = "SELECT * FROM systemmenu WHERE MenuStartId = '" & MenuStartID & "'"
            dt = PlushData.clsConnection.FillDataSet(sql)

            If dt.Rows.Count = 1 Then
                Dim row As DataRow
                row = dt.Rows(0)
                StartForm(row("MenuForm"), row("MenuAssembly"), row("MenuID"), row("MenuLabel"), Me, True)
                Return row("MenuID")
            Else
                MsgBox("Error MenuStartID " & MenuStartID, MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function



#End Region


    Private Sub StartingMenuID(ByVal MenuStartID As String)
        Dim _MenuID As Integer
        If txtMenuStartID.Text & "" = "" Then Exit Sub
        'Try
        '_MenuID = BKGlobal.StartMenuForm(txtMenuStartID.Text, Me)
        '  _MenuID = BKGlobal.GetStartID(txtMenuStartID.Text)

        _MenuID = StartMenuForm(MenuStartID)
        ' _MenuID = GetStartID(txtMenuStartID.Text)

        'Catch

        '    _MenuID = myBKGlobal.StartMenuForm(txtMenuStartID.Text, Me)
        '    _MenuID = myBKGlobal.GetStartID(txtMenuStartID.Text)
        'End Try


        If Not IsNothing(TreeList1.FindNodeByKeyID(_MenuID)) Then
            TreeList1.CollapseAll()
            TreeList1.SetFocusedNode(TreeList1.FindNodeByKeyID(_MenuID))
            If TreeList1.FocusedNode.HasChildren Then TreeList1.FocusedNode.Expanded = True
        End If

    End Sub

    Private Sub ToolBar2_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar2.ButtonClick
        Select Case e.Button.Tag.ToString
            Case "btnRefreshMenuTree"
                RefreshMenuTree()
            Case "btnChangeDatabase"
                Dim _frmDBSelect As New BizzLib.frmDialogSelectDatabase(SessionInfo)
                _frmDBSelect.ShowDialog(Me)
                If _frmDBSelect.DialogResult = Windows.Forms.DialogResult.OK Then
                    If MsgBox("Are you sure you want to be connected to database : " & _frmDBSelect.SelectedDBName, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        'Find ConnectionString 
                        Dim _DBConnString As String = BKGlobal.ExecuteFindFieldValue("ConnectionString", "SELECT ConnectionString FROm systemdatabase Where DBName = '" & _frmDBSelect.SelectedDBName & "' ")
                        If _DBConnString & "" <> "" Then
                            SessionInfo.DBName = _frmDBSelect.SelectedDBName
                            SessionInfo.DBConnString = _DBConnString
                            SessionInfo.ChangeDBConnection()
                            StartSession()
                            'Login()
                        Else
                            MsgBox("ConnectionString is Empty for Database : " & _frmDBSelect.SelectedDBName)
                            Exit Sub
                        End If
                    End If
                End If
        End Select
    End Sub
    Private Sub RefreshMenuTree()

        Dim dt_menu As DataTable
        Dim dt_menu_role As DataTable
        '  objDS.Tables("systemmenutreeView1").Clear()

        'SessionInfo.RoleID = 3
        ' Dim _cls1 As New BizzLib.clsDataSet(SessionInfo)
        dt_menu = PlushData.clsConnection.FillDataSet(MenuTreeSQLTxt)
        ' DvdPostData.clsConnection.FillDataSet(objDS.Tables("systemmenutreeView1"), MenuTreeSQLTxt)
        Dim _row As DataRow
        'Dim _DSSecurity As New BizzLib.dsSecurity
        Dim _SQLTxt As String = "SELECT * FROM securitymenu_role WHERE RoleID in (" & PlushData.clsSession.GetLstRole() & ")"
        ' DvdPostData.clsConnection.FillDataSet(_DSSecurity.Tables("securitymenu_role"), _SQLTxt)
        dt_menu_role = PlushData.clsConnection.FillDataSet(_SQLTxt)
        '  Dim _SecurityView As New DataView(_DSSecurity.Tables("securitymenu_role"), "", "MenuID", DataViewRowState.CurrentRows)
        'Dim _SecurityRow As DataRowView
        For Each _row In dt_menu.Rows
            If Not PlushData.clsSession.isAccesMenu(dt_menu_role, _row("MenuID")) Then
                _row.Delete()
            End If
            'If BKGlobal.CheckMenuAccessAutorization(_row("MenuID"), roleId) Or roleId = 0 Then
            'Else
            '    _row.Delete()
            'End If
            'Pour Limiter les Acces a la base de Donnée
            'If _SecurityView.Find(New Object() {_row("MenuID")}) >= 0 Then
            '    _SecurityRow = _SecurityView(_SecurityView.Find(New Object() {_row("MenuID")}))
            '    If Not IsNothing(_SecurityRow) Then

            '    Else
            '        _row.Delete()
            '    End If
            'Else
            '    _row.Delete()
            'End If
        Next
        Me.TreeList1.DataSource = dt_menu
        TreeList1.CollapseAll()
        TreeList1.Columns("Sequence").SortOrder = SortOrder.Ascending
        txtMenuStartID.Text = ""
        Dim _N As DevExpress.XtraTreeList.Nodes.TreeListNode
        _N = TreeList1.FindNodeByKeyID(DefaultNodeSelected)
        TreeList1.SetFocusedNode(_N)
        If Not IsNothing(TreeList1.FocusedNode) Then TreeList1.FocusedNode.Expanded = True
    End Sub
    Private Sub LoadUserMenu()
        Dim _UserMenu As DataTable
        Dim _row As DataRow
        Dim _i As Integer = 0
        'Dim _Menu As MenuItem

        _UserMenu = BKGlobal.GetUserMenu(PlushData.clsSession.user_id)
        If _UserMenu.Rows.Count > 0 Then
            ReDim UserMenus(_UserMenu.Rows.Count - 1)
        Else
            Exit Sub
        End If
        For Each _row In _UserMenu.Rows
            'Load UserMenu
            UserMenus(_i) = New BizzLib.clsUserMenu(_row("MenuLabel"), Me) 'MenuItem
            UserMenus(_i).MergeOrder = _row("MenuID")
            UserMenus(_i).Text = _row("MenuLabel")
            AddHandler UserMenus(_i).UserMenu_Click, AddressOf BKGlobal.ContextMenuClick
            UserMenu.MenuItems.Add(UserMenus(_i))
            _i += 1
        Next
    End Sub

    Private Sub TreeList1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeList1.DoubleClick


        If TreeList1.FocusedNode.HasChildren Then
            TreeList1.FocusedNode.Expanded = Not TreeList1.FocusedNode.Expanded

        Else
            Dim _id As Integer = TreeList1.FocusedNode("MenuStartID")
            SetTxtMenuID(TreeList1.FocusedNode)
            StartingMenuID(_id)
        End If

    End Sub
    Private Sub TreeList1_FocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList1.FocusedNodeChanged
        '  SetTxtMenuID(e.Node)
    End Sub
    Private Sub SetTxtMenuID(ByVal Node1 As DevExpress.XtraTreeList.Nodes.TreeListNode)
        If IsNothing(Node1) Then
            Exit Sub
        End If
        If Node1("MenuStartCode") & "" <> "" Then
            txtMenuStartID.Text = Node1("MenuStartCode") & ""
        Else
            If Node1("MenuStartCode2") & "" <> "" Then
                txtMenuStartID.Text = Node1("MenuStartCode2") & ""
            Else
                txtMenuStartID.Text = Node1("MenuStartID") & ""
            End If
        End If
    End Sub
    Private Sub TreeList1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TreeList1.KeyPress
        Select Case e.KeyChar
            Case ControlChars.Cr
                If TreeList1.FocusedNode.HasChildren Then
                    TreeList1.FocusedNode.Expanded = Not TreeList1.FocusedNode.Expanded
                Else
                    Dim _id As Integer = TreeList1.FocusedNode("MenuStartID")
                    SetTxtMenuID(TreeList1.FocusedNode)
                    StartingMenuID(_id)
                End If
        End Select
    End Sub

    Private Sub TimerMySQL_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMySQL.Tick
        Dim _SQLTxt As String = "Select USerID FROM securityuser where UserId = " & PlushData.clsSession.user_id
        Dim _userid As Integer
        _userid = BKGlobal.ExecuteFindFieldValueINT("UserID", _SQLTxt)
    End Sub
End Class
