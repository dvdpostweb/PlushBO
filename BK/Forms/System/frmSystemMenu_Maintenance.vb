Imports BizzLib.clsGlobal.ObjectState

Public Class frmsystemmenu_Maintenance
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabMenu As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMenuStartID As System.Windows.Forms.Label
    Friend WithEvents txtMenuStartID As System.Windows.Forms.TextBox
    Friend WithEvents lblMenuIconExpanded As System.Windows.Forms.Label
    Friend WithEvents txtMenuIconExpanded As System.Windows.Forms.TextBox
    Friend WithEvents lblLabel As System.Windows.Forms.Label
    Friend WithEvents lblForm As System.Windows.Forms.Label
    Friend WithEvents lblIcon As System.Windows.Forms.Label
    Friend WithEvents txtMenuLabel As System.Windows.Forms.TextBox
    Friend WithEvents txtMenuForm As System.Windows.Forms.TextBox
    Friend WithEvents txtMenuICon As System.Windows.Forms.TextBox
    Friend WithEvents TabRoles As System.Windows.Forms.TabPage
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDataAdapterMenu_Role As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents GridViewMenuRole As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridMenuRole As DevExpress.XtraGrid.GridControl
    Friend WithEvents objDS As BizzLib.dsSystem
    Friend WithEvents colRoleID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbRole As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents OleDbDataAdapterMenu_Sub As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents lblMenuStartCode As System.Windows.Forms.Label
    Friend WithEvents txtMenuStartCode As System.Windows.Forms.TextBox
    Friend WithEvents GrpGenericBrowseInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblBTableName As System.Windows.Forms.Label
    Friend WithEvents txtBTableName As System.Windows.Forms.TextBox
    Friend WithEvents lblBIDField As System.Windows.Forms.Label
    Friend WithEvents txtBIDField As System.Windows.Forms.TextBox
    Friend WithEvents lblBNameField As System.Windows.Forms.Label
    Friend WithEvents txtBNameField As System.Windows.Forms.TextBox
    Friend WithEvents lblBToMaintMenuID As System.Windows.Forms.Label
    Friend WithEvents txtToMaintMenuID As System.Windows.Forms.TextBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents lblWhereClause As System.Windows.Forms.Label
    Friend WithEvents txtBrowseWhere As System.Windows.Forms.TextBox
    Friend WithEvents lblOderBy As System.Windows.Forms.Label
    Friend WithEvents txtOrderBy As System.Windows.Forms.TextBox
    Friend WithEvents GridTranslation As DevExpress.XtraGrid.GridControl
    Friend WithEvents colLang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMenuLabel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblAssemblyName As System.Windows.Forms.Label
    Friend WithEvents txtAssemblyName As System.Windows.Forms.TextBox
    Friend WithEvents PEdit As System.Windows.Forms.Panel
    Friend WithEvents LblID As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents GridViewTranslation As DevExpress.XtraGrid.Views.Grid.GridView

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsystemmenu_Maintenance))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabMenu = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PEdit = New System.Windows.Forms.Panel
        Me.LblID = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.objDS = New BizzLib.dsSystem
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.lblAssemblyName = New System.Windows.Forms.Label
        Me.txtAssemblyName = New System.Windows.Forms.TextBox
        Me.GridTranslation = New DevExpress.XtraGrid.GridControl
        Me.GridViewTranslation = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colLang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMenuLabel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GrpGenericBrowseInfo = New System.Windows.Forms.GroupBox
        Me.txtOrderBy = New System.Windows.Forms.TextBox
        Me.lblOderBy = New System.Windows.Forms.Label
        Me.txtBrowseWhere = New System.Windows.Forms.TextBox
        Me.lblWhereClause = New System.Windows.Forms.Label
        Me.lblBToMaintMenuID = New System.Windows.Forms.Label
        Me.txtToMaintMenuID = New System.Windows.Forms.TextBox
        Me.lblBNameField = New System.Windows.Forms.Label
        Me.txtBNameField = New System.Windows.Forms.TextBox
        Me.lblBIDField = New System.Windows.Forms.Label
        Me.txtBIDField = New System.Windows.Forms.TextBox
        Me.lblBTableName = New System.Windows.Forms.Label
        Me.txtBTableName = New System.Windows.Forms.TextBox
        Me.lblMenuStartCode = New System.Windows.Forms.Label
        Me.txtMenuStartCode = New System.Windows.Forms.TextBox
        Me.lblMenuStartID = New System.Windows.Forms.Label
        Me.txtMenuStartID = New System.Windows.Forms.TextBox
        Me.lblMenuIconExpanded = New System.Windows.Forms.Label
        Me.txtMenuIconExpanded = New System.Windows.Forms.TextBox
        Me.lblLabel = New System.Windows.Forms.Label
        Me.lblForm = New System.Windows.Forms.Label
        Me.lblIcon = New System.Windows.Forms.Label
        Me.txtMenuLabel = New System.Windows.Forms.TextBox
        Me.txtMenuForm = New System.Windows.Forms.TextBox
        Me.txtMenuICon = New System.Windows.Forms.TextBox
        Me.TabRoles = New System.Windows.Forms.TabPage
        Me.GridMenuRole = New DevExpress.XtraGrid.GridControl
        Me.GridViewMenuRole = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colRoleID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbRole = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapterMenu_Role = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapterMenu_Sub = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PEdit.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridTranslation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTranslation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpGenericBrowseInfo.SuspendLayout()
        Me.TabRoles.SuspendLayout()
        CType(Me.GridMenuRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMenuRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRole, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.StatusBar1.Location = New System.Drawing.Point(0, 428)
        Me.StatusBar1.Size = New System.Drawing.Size(848, 26)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabMenu)
        Me.TabControl1.Controls.Add(Me.TabRoles)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 66)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(848, 362)
        Me.TabControl1.TabIndex = 34
        '
        'TabMenu
        '
        Me.TabMenu.Controls.Add(Me.Panel1)
        Me.TabMenu.Location = New System.Drawing.Point(4, 25)
        Me.TabMenu.Name = "TabMenu"
        Me.TabMenu.Size = New System.Drawing.Size(840, 333)
        Me.TabMenu.TabIndex = 0
        Me.TabMenu.Text = "Menu"
        Me.TabMenu.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.PEdit)
        Me.Panel1.Controls.Add(Me.lblAssemblyName)
        Me.Panel1.Controls.Add(Me.txtAssemblyName)
        Me.Panel1.Controls.Add(Me.GridTranslation)
        Me.Panel1.Controls.Add(Me.GrpGenericBrowseInfo)
        Me.Panel1.Controls.Add(Me.lblMenuStartCode)
        Me.Panel1.Controls.Add(Me.txtMenuStartCode)
        Me.Panel1.Controls.Add(Me.lblMenuStartID)
        Me.Panel1.Controls.Add(Me.txtMenuStartID)
        Me.Panel1.Controls.Add(Me.lblMenuIconExpanded)
        Me.Panel1.Controls.Add(Me.txtMenuIconExpanded)
        Me.Panel1.Controls.Add(Me.lblLabel)
        Me.Panel1.Controls.Add(Me.lblForm)
        Me.Panel1.Controls.Add(Me.lblIcon)
        Me.Panel1.Controls.Add(Me.txtMenuLabel)
        Me.Panel1.Controls.Add(Me.txtMenuForm)
        Me.Panel1.Controls.Add(Me.txtMenuICon)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(840, 333)
        Me.Panel1.TabIndex = 31
        '
        'PEdit
        '
        Me.PEdit.BackColor = System.Drawing.SystemColors.Window
        Me.PEdit.Controls.Add(Me.LblID)
        Me.PEdit.Controls.Add(Me.txtId)
        Me.PEdit.Controls.Add(Me.Label2)
        Me.PEdit.Controls.Add(Me.TextBox1)
        Me.PEdit.Controls.Add(Me.GroupBox1)
        Me.PEdit.Controls.Add(Me.Label9)
        Me.PEdit.Controls.Add(Me.TextBox8)
        Me.PEdit.Controls.Add(Me.Label1)
        Me.PEdit.Controls.Add(Me.TextBox9)
        Me.PEdit.Controls.Add(Me.Label10)
        Me.PEdit.Controls.Add(Me.TextBox10)
        Me.PEdit.Controls.Add(Me.Label11)
        Me.PEdit.Controls.Add(Me.Label12)
        Me.PEdit.Controls.Add(Me.Label13)
        Me.PEdit.Controls.Add(Me.TextBox11)
        Me.PEdit.Controls.Add(Me.TextBox12)
        Me.PEdit.Controls.Add(Me.TextBox13)
        Me.PEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PEdit.Enabled = False
        Me.PEdit.Location = New System.Drawing.Point(0, 0)
        Me.PEdit.Name = "PEdit"
        Me.PEdit.Size = New System.Drawing.Size(840, 333)
        Me.PEdit.TabIndex = 32
        '
        'LblID
        '
        Me.LblID.Location = New System.Drawing.Point(304, 122)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(28, 27)
        Me.LblID.TabIndex = 23
        Me.LblID.Text = "ID"
        '
        'txtId
        '
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.MenuID", True))
        Me.txtId.Location = New System.Drawing.Point(338, 119)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(90, 22)
        Me.txtId.TabIndex = 24
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsSystem"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 27)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Assembly Name (dll)"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.MenuAssembly", True))
        Me.TextBox1.Location = New System.Drawing.Point(188, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(214, 22)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = "BizzLib.dll"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Location = New System.Drawing.Point(505, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 249)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generic Browse Info"
        Me.GroupBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.BrowseOrderByClause", True))
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(144, 166)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(278, 22)
        Me.TextBox2.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 27)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Order By Clause"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.BrowseWhereClause", True))
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(144, 138)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(278, 22)
        Me.TextBox3.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 27)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Where Clause"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(10, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 26)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "To Maint. MenuID"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.BrowseToMaintMenuID", True))
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(144, 111)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(278, 22)
        Me.TextBox4.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(10, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 26)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "NameField"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.BrowseNameField", True))
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(144, 80)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(278, 22)
        Me.TextBox5.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(10, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 27)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "IDField"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.BrowseIDField", True))
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(144, 55)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(278, 22)
        Me.TextBox6.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(10, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 26)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Table Name"
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.BrowseTableName", True))
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(144, 28)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(278, 22)
        Me.TextBox7.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(4, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 26)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Start Code"
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.MenuStartCode", True))
        Me.TextBox8.Location = New System.Drawing.Point(188, 152)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(214, 22)
        Me.TextBox8.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 27)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Start ID"
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.MenuStartID", True))
        Me.TextBox9.Location = New System.Drawing.Point(188, 126)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(90, 22)
        Me.TextBox9.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(510, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 26)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Expanded Icon"
        Me.Label10.Visible = False
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.MenuIconExpanded", True))
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(635, 43)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(336, 22)
        Me.TextBox10.TabIndex = 14
        Me.TextBox10.Visible = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(1, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 27)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Label"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(1, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(181, 27)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Form Name(case sensitive)"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(510, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 27)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Icon"
        Me.Label13.Visible = False
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.MenuLabel", True))
        Me.TextBox11.Location = New System.Drawing.Point(188, 18)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(214, 22)
        Me.TextBox11.TabIndex = 9
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.MenuForm", True))
        Me.TextBox12.Location = New System.Drawing.Point(188, 46)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(214, 22)
        Me.TextBox12.TabIndex = 11
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.MenuIcon", True))
        Me.TextBox13.Enabled = False
        Me.TextBox13.Location = New System.Drawing.Point(635, 15)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(336, 22)
        Me.TextBox13.TabIndex = 12
        Me.TextBox13.Visible = False
        '
        'lblAssemblyName
        '
        Me.lblAssemblyName.Location = New System.Drawing.Point(4, 83)
        Me.lblAssemblyName.Name = "lblAssemblyName"
        Me.lblAssemblyName.Size = New System.Drawing.Size(145, 27)
        Me.lblAssemblyName.TabIndex = 21
        Me.lblAssemblyName.Text = "Assembly Name (dll)"
        '
        'txtAssemblyName
        '
        Me.txtAssemblyName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.MenuAssembly", True))
        Me.txtAssemblyName.Enabled = False
        Me.txtAssemblyName.Location = New System.Drawing.Point(188, 80)
        Me.txtAssemblyName.Name = "txtAssemblyName"
        Me.txtAssemblyName.Size = New System.Drawing.Size(214, 22)
        Me.txtAssemblyName.TabIndex = 22
        Me.txtAssemblyName.Text = "BizzLib.dll"
        '
        'GridTranslation
        '
        Me.GridTranslation.DataMember = "systemmenutranslation"
        Me.GridTranslation.DataSource = Me.objDS
        Me.GridTranslation.EmbeddedNavigator.Name = ""
        Me.GridTranslation.FormsUseDefaultLookAndFeel = False
        Me.GridTranslation.Location = New System.Drawing.Point(19, 185)
        Me.GridTranslation.MainView = Me.GridViewTranslation
        Me.GridTranslation.Name = "GridTranslation"
        Me.GridTranslation.Size = New System.Drawing.Size(480, 212)
        Me.GridTranslation.TabIndex = 20
        Me.GridTranslation.UseEmbeddedNavigator = True
        Me.GridTranslation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewTranslation})
        '
        'GridViewTranslation
        '
        Me.GridViewTranslation.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLang, Me.colMenuLabel})
        Me.GridViewTranslation.GridControl = Me.GridTranslation
        Me.GridViewTranslation.Name = "GridViewTranslation"
        Me.GridViewTranslation.OptionsBehavior.Editable = False
        Me.GridViewTranslation.OptionsView.ShowGroupPanel = False
        '
        'colLang
        '
        Me.colLang.Caption = "Lang"
        Me.colLang.FieldName = "Lang"
        Me.colLang.Name = "colLang"
        Me.colLang.Visible = True
        Me.colLang.VisibleIndex = 0
        Me.colLang.Width = 68
        '
        'colMenuLabel
        '
        Me.colMenuLabel.Caption = "MenuLabel"
        Me.colMenuLabel.FieldName = "MenuLabel"
        Me.colMenuLabel.Name = "colMenuLabel"
        Me.colMenuLabel.Width = 318
        '
        'GrpGenericBrowseInfo
        '
        Me.GrpGenericBrowseInfo.Controls.Add(Me.txtOrderBy)
        Me.GrpGenericBrowseInfo.Controls.Add(Me.lblOderBy)
        Me.GrpGenericBrowseInfo.Controls.Add(Me.txtBrowseWhere)
        Me.GrpGenericBrowseInfo.Controls.Add(Me.lblWhereClause)
        Me.GrpGenericBrowseInfo.Controls.Add(Me.lblBToMaintMenuID)
        Me.GrpGenericBrowseInfo.Controls.Add(Me.txtToMaintMenuID)
        Me.GrpGenericBrowseInfo.Controls.Add(Me.lblBNameField)
        Me.GrpGenericBrowseInfo.Controls.Add(Me.txtBNameField)
        Me.GrpGenericBrowseInfo.Controls.Add(Me.lblBIDField)
        Me.GrpGenericBrowseInfo.Controls.Add(Me.txtBIDField)
        Me.GrpGenericBrowseInfo.Controls.Add(Me.lblBTableName)
        Me.GrpGenericBrowseInfo.Controls.Add(Me.txtBTableName)
        Me.GrpGenericBrowseInfo.Location = New System.Drawing.Point(530, 157)
        Me.GrpGenericBrowseInfo.Name = "GrpGenericBrowseInfo"
        Me.GrpGenericBrowseInfo.Size = New System.Drawing.Size(452, 249)
        Me.GrpGenericBrowseInfo.TabIndex = 19
        Me.GrpGenericBrowseInfo.TabStop = False
        Me.GrpGenericBrowseInfo.Text = "Generic Browse Info"
        Me.GrpGenericBrowseInfo.Visible = False
        '
        'txtOrderBy
        '
        Me.txtOrderBy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.BrowseOrderByClause", True))
        Me.txtOrderBy.Enabled = False
        Me.txtOrderBy.Location = New System.Drawing.Point(144, 166)
        Me.txtOrderBy.Name = "txtOrderBy"
        Me.txtOrderBy.Size = New System.Drawing.Size(278, 22)
        Me.txtOrderBy.TabIndex = 21
        '
        'lblOderBy
        '
        Me.lblOderBy.Location = New System.Drawing.Point(10, 166)
        Me.lblOderBy.Name = "lblOderBy"
        Me.lblOderBy.Size = New System.Drawing.Size(120, 27)
        Me.lblOderBy.TabIndex = 20
        Me.lblOderBy.Text = "Order By Clause"
        '
        'txtBrowseWhere
        '
        Me.txtBrowseWhere.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.BrowseWhereClause", True))
        Me.txtBrowseWhere.Enabled = False
        Me.txtBrowseWhere.Location = New System.Drawing.Point(144, 138)
        Me.txtBrowseWhere.Name = "txtBrowseWhere"
        Me.txtBrowseWhere.Size = New System.Drawing.Size(278, 22)
        Me.txtBrowseWhere.TabIndex = 19
        '
        'lblWhereClause
        '
        Me.lblWhereClause.Location = New System.Drawing.Point(10, 138)
        Me.lblWhereClause.Name = "lblWhereClause"
        Me.lblWhereClause.Size = New System.Drawing.Size(120, 27)
        Me.lblWhereClause.TabIndex = 18
        Me.lblWhereClause.Text = "Where Clause"
        '
        'lblBToMaintMenuID
        '
        Me.lblBToMaintMenuID.Location = New System.Drawing.Point(10, 111)
        Me.lblBToMaintMenuID.Name = "lblBToMaintMenuID"
        Me.lblBToMaintMenuID.Size = New System.Drawing.Size(120, 26)
        Me.lblBToMaintMenuID.TabIndex = 16
        Me.lblBToMaintMenuID.Text = "To Maint. MenuID"
        '
        'txtToMaintMenuID
        '
        Me.txtToMaintMenuID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.BrowseToMaintMenuID", True))
        Me.txtToMaintMenuID.Enabled = False
        Me.txtToMaintMenuID.Location = New System.Drawing.Point(144, 111)
        Me.txtToMaintMenuID.Name = "txtToMaintMenuID"
        Me.txtToMaintMenuID.Size = New System.Drawing.Size(278, 22)
        Me.txtToMaintMenuID.TabIndex = 17
        '
        'lblBNameField
        '
        Me.lblBNameField.Location = New System.Drawing.Point(10, 80)
        Me.lblBNameField.Name = "lblBNameField"
        Me.lblBNameField.Size = New System.Drawing.Size(120, 26)
        Me.lblBNameField.TabIndex = 14
        Me.lblBNameField.Text = "NameField"
        '
        'txtBNameField
        '
        Me.txtBNameField.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.BrowseNameField", True))
        Me.txtBNameField.Enabled = False
        Me.txtBNameField.Location = New System.Drawing.Point(144, 80)
        Me.txtBNameField.Name = "txtBNameField"
        Me.txtBNameField.Size = New System.Drawing.Size(278, 22)
        Me.txtBNameField.TabIndex = 15
        '
        'lblBIDField
        '
        Me.lblBIDField.Location = New System.Drawing.Point(10, 55)
        Me.lblBIDField.Name = "lblBIDField"
        Me.lblBIDField.Size = New System.Drawing.Size(120, 27)
        Me.lblBIDField.TabIndex = 12
        Me.lblBIDField.Text = "IDField"
        '
        'txtBIDField
        '
        Me.txtBIDField.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.BrowseIDField", True))
        Me.txtBIDField.Enabled = False
        Me.txtBIDField.Location = New System.Drawing.Point(144, 55)
        Me.txtBIDField.Name = "txtBIDField"
        Me.txtBIDField.Size = New System.Drawing.Size(278, 22)
        Me.txtBIDField.TabIndex = 13
        '
        'lblBTableName
        '
        Me.lblBTableName.Location = New System.Drawing.Point(10, 28)
        Me.lblBTableName.Name = "lblBTableName"
        Me.lblBTableName.Size = New System.Drawing.Size(120, 26)
        Me.lblBTableName.TabIndex = 10
        Me.lblBTableName.Text = "Table Name"
        '
        'txtBTableName
        '
        Me.txtBTableName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.BrowseTableName", True))
        Me.txtBTableName.Enabled = False
        Me.txtBTableName.Location = New System.Drawing.Point(144, 28)
        Me.txtBTableName.Name = "txtBTableName"
        Me.txtBTableName.Size = New System.Drawing.Size(278, 22)
        Me.txtBTableName.TabIndex = 11
        '
        'lblMenuStartCode
        '
        Me.lblMenuStartCode.Location = New System.Drawing.Point(4, 155)
        Me.lblMenuStartCode.Name = "lblMenuStartCode"
        Me.lblMenuStartCode.Size = New System.Drawing.Size(120, 26)
        Me.lblMenuStartCode.TabIndex = 17
        Me.lblMenuStartCode.Text = "Start Code"
        '
        'txtMenuStartCode
        '
        Me.txtMenuStartCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.MenuStartCode", True))
        Me.txtMenuStartCode.Enabled = False
        Me.txtMenuStartCode.Location = New System.Drawing.Point(188, 152)
        Me.txtMenuStartCode.Name = "txtMenuStartCode"
        Me.txtMenuStartCode.Size = New System.Drawing.Size(214, 22)
        Me.txtMenuStartCode.TabIndex = 18
        '
        'lblMenuStartID
        '
        Me.lblMenuStartID.Location = New System.Drawing.Point(4, 121)
        Me.lblMenuStartID.Name = "lblMenuStartID"
        Me.lblMenuStartID.Size = New System.Drawing.Size(120, 27)
        Me.lblMenuStartID.TabIndex = 15
        Me.lblMenuStartID.Text = "Start ID"
        '
        'txtMenuStartID
        '
        Me.txtMenuStartID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.MenuStartID", True))
        Me.txtMenuStartID.Enabled = False
        Me.txtMenuStartID.Location = New System.Drawing.Point(188, 126)
        Me.txtMenuStartID.Name = "txtMenuStartID"
        Me.txtMenuStartID.Size = New System.Drawing.Size(90, 22)
        Me.txtMenuStartID.TabIndex = 16
        '
        'lblMenuIconExpanded
        '
        Me.lblMenuIconExpanded.Location = New System.Drawing.Point(510, 43)
        Me.lblMenuIconExpanded.Name = "lblMenuIconExpanded"
        Me.lblMenuIconExpanded.Size = New System.Drawing.Size(120, 26)
        Me.lblMenuIconExpanded.TabIndex = 13
        Me.lblMenuIconExpanded.Text = "Expanded Icon"
        Me.lblMenuIconExpanded.Visible = False
        '
        'txtMenuIconExpanded
        '
        Me.txtMenuIconExpanded.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.MenuIconExpanded", True))
        Me.txtMenuIconExpanded.Enabled = False
        Me.txtMenuIconExpanded.Location = New System.Drawing.Point(635, 43)
        Me.txtMenuIconExpanded.Name = "txtMenuIconExpanded"
        Me.txtMenuIconExpanded.Size = New System.Drawing.Size(336, 22)
        Me.txtMenuIconExpanded.TabIndex = 14
        Me.txtMenuIconExpanded.Visible = False
        '
        'lblLabel
        '
        Me.lblLabel.Location = New System.Drawing.Point(1, 15)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(120, 27)
        Me.lblLabel.TabIndex = 4
        Me.lblLabel.Text = "Label"
        '
        'lblForm
        '
        Me.lblForm.Location = New System.Drawing.Point(1, 45)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(181, 27)
        Me.lblForm.TabIndex = 6
        Me.lblForm.Text = "Form Name(case sensitive)"
        '
        'lblIcon
        '
        Me.lblIcon.Location = New System.Drawing.Point(510, 15)
        Me.lblIcon.Name = "lblIcon"
        Me.lblIcon.Size = New System.Drawing.Size(120, 27)
        Me.lblIcon.TabIndex = 7
        Me.lblIcon.Text = "Icon"
        Me.lblIcon.Visible = False
        '
        'txtMenuLabel
        '
        Me.txtMenuLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.MenuLabel", True))
        Me.txtMenuLabel.Enabled = False
        Me.txtMenuLabel.Location = New System.Drawing.Point(188, 18)
        Me.txtMenuLabel.Name = "txtMenuLabel"
        Me.txtMenuLabel.Size = New System.Drawing.Size(214, 22)
        Me.txtMenuLabel.TabIndex = 9
        '
        'txtMenuForm
        '
        Me.txtMenuForm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.MenuForm", True))
        Me.txtMenuForm.Enabled = False
        Me.txtMenuForm.Location = New System.Drawing.Point(188, 46)
        Me.txtMenuForm.Name = "txtMenuForm"
        Me.txtMenuForm.Size = New System.Drawing.Size(214, 22)
        Me.txtMenuForm.TabIndex = 11
        '
        'txtMenuICon
        '
        Me.txtMenuICon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "systemmenu.MenuIcon", True))
        Me.txtMenuICon.Enabled = False
        Me.txtMenuICon.Location = New System.Drawing.Point(635, 15)
        Me.txtMenuICon.Name = "txtMenuICon"
        Me.txtMenuICon.Size = New System.Drawing.Size(336, 22)
        Me.txtMenuICon.TabIndex = 12
        Me.txtMenuICon.Visible = False
        '
        'TabRoles
        '
        Me.TabRoles.Controls.Add(Me.GridMenuRole)
        Me.TabRoles.Location = New System.Drawing.Point(4, 25)
        Me.TabRoles.Name = "TabRoles"
        Me.TabRoles.Size = New System.Drawing.Size(840, 333)
        Me.TabRoles.TabIndex = 1
        Me.TabRoles.Text = "Roles"
        Me.TabRoles.UseVisualStyleBackColor = True
        Me.TabRoles.Visible = False
        '
        'GridMenuRole
        '
        Me.GridMenuRole.DataSource = Me.objDS.securitymenu_role
        Me.GridMenuRole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMenuRole.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridMenuRole.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridMenuRole.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridMenuRole.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridMenuRole.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridMenuRole.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridMenuRole.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridMenuRole.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridMenuRole.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridMenuRole.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridMenuRole.EmbeddedNavigator.Buttons.Remove.ImageIndex = 1
        Me.GridMenuRole.EmbeddedNavigator.Enabled = False
        Me.GridMenuRole.EmbeddedNavigator.Name = ""
        Me.GridMenuRole.Enabled = False
        Me.GridMenuRole.FormsUseDefaultLookAndFeel = False
        Me.GridMenuRole.Location = New System.Drawing.Point(0, 0)
        Me.GridMenuRole.MainView = Me.GridViewMenuRole
        Me.GridMenuRole.Name = "GridMenuRole"
        Me.GridMenuRole.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbRole})
        Me.GridMenuRole.Size = New System.Drawing.Size(840, 333)
        Me.GridMenuRole.TabIndex = 0
        Me.GridMenuRole.UseEmbeddedNavigator = True
        Me.GridMenuRole.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewMenuRole})
        '
        'GridViewMenuRole
        '
        Me.GridViewMenuRole.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRoleID})
        Me.GridViewMenuRole.GridControl = Me.GridMenuRole
        Me.GridViewMenuRole.GroupPanelText = "..."
        Me.GridViewMenuRole.Name = "GridViewMenuRole"
        Me.GridViewMenuRole.OptionsBehavior.Editable = False
        Me.GridViewMenuRole.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridViewMenuRole.OptionsView.ShowGroupPanel = False
        '
        'colRoleID
        '
        Me.colRoleID.Caption = "Role"
        Me.colRoleID.ColumnEdit = Me.cmbRole
        Me.colRoleID.FieldName = "RoleID"
        Me.colRoleID.Name = "colRoleID"
        Me.colRoleID.Visible = True
        Me.colRoleID.VisibleIndex = 0
        '
        'cmbRole
        '
        Me.cmbRole.AutoHeight = False
        Me.cmbRole.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRole.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 38, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbRole.DataSource = Me.objDS.securityrole
        Me.cmbRole.DisplayMember = "Name"
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.NullText = ""
        Me.cmbRole.ValueMember = "RoleID"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "systemmenu", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MenuID", "MenuID"), New System.Data.Common.DataColumnMapping("MenuLabel", "MenuLabel"), New System.Data.Common.DataColumnMapping("MenuForm", "MenuForm"), New System.Data.Common.DataColumnMapping("MenuIcon", "MenuIcon"), New System.Data.Common.DataColumnMapping("MenuIconExpanded", "MenuIconExpanded"), New System.Data.Common.DataColumnMapping("MenuStartID", "MenuStartID"), New System.Data.Common.DataColumnMapping("MenuStartCode", "MenuStartCode"), New System.Data.Common.DataColumnMapping("BrowseTableName", "BrowseTableName"), New System.Data.Common.DataColumnMapping("BrowseIDField", "BrowseIDField"), New System.Data.Common.DataColumnMapping("BrowseNameField", "BrowseNameField"), New System.Data.Common.DataColumnMapping("BrowseToMaintMenuID", "BrowseToMaintMenuID"), New System.Data.Common.DataColumnMapping("BrowseWhereClause", "BrowseWhereClause"), New System.Data.Common.DataColumnMapping("BrowseOrderByClause", "BrowseOrderByClause")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseIDField", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseIDField", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseIDField1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseIDField", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseNameField", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseNameField", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseNameField1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseNameField", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseOrderByClause", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseOrderByClause", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseOrderByClause1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseOrderByClause", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseTableName", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseTableName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseTableName1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseTableName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseToMaintMenuID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseToMaintMenuID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseToMaintMenuID1", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseToMaintMenuID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseWhereClause", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseWhereClause", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseWhereClause1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseWhereClause", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuForm", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuForm1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIcon", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIcon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIcon1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIcon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIconExpanded", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIconExpanded", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIconExpanded1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIconExpanded", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuLabel", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuLabel", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuLabel1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuLabel", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartID1", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = resources.GetString("OleDbInsertCommand1.CommandText")
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID"), New System.Data.OleDb.OleDbParameter("MenuLabel", System.Data.OleDb.OleDbType.VarChar, 50, "MenuLabel"), New System.Data.OleDb.OleDbParameter("MenuForm", System.Data.OleDb.OleDbType.VarChar, 100, "MenuForm"), New System.Data.OleDb.OleDbParameter("MenuIcon", System.Data.OleDb.OleDbType.VarChar, 100, "MenuIcon"), New System.Data.OleDb.OleDbParameter("MenuIconExpanded", System.Data.OleDb.OleDbType.VarChar, 100, "MenuIconExpanded"), New System.Data.OleDb.OleDbParameter("MenuStartID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuStartID"), New System.Data.OleDb.OleDbParameter("MenuStartCode", System.Data.OleDb.OleDbType.VarChar, 50, "MenuStartCode"), New System.Data.OleDb.OleDbParameter("BrowseTableName", System.Data.OleDb.OleDbType.VarChar, 50, "BrowseTableName"), New System.Data.OleDb.OleDbParameter("BrowseIDField", System.Data.OleDb.OleDbType.VarChar, 50, "BrowseIDField"), New System.Data.OleDb.OleDbParameter("BrowseNameField", System.Data.OleDb.OleDbType.VarChar, 50, "BrowseNameField"), New System.Data.OleDb.OleDbParameter("BrowseToMaintMenuID", System.Data.OleDb.OleDbType.[Integer], 4, "BrowseToMaintMenuID"), New System.Data.OleDb.OleDbParameter("BrowseWhereClause", System.Data.OleDb.OleDbType.VarChar, 50, "BrowseWhereClause"), New System.Data.OleDb.OleDbParameter("BrowseOrderByClause", System.Data.OleDb.OleDbType.VarChar, 50, "BrowseOrderByClause"), New System.Data.OleDb.OleDbParameter("Select_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID")})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = resources.GetString("OleDbSelectCommand1.CommandText")
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID"), New System.Data.OleDb.OleDbParameter("MenuLabel", System.Data.OleDb.OleDbType.VarChar, 50, "MenuLabel"), New System.Data.OleDb.OleDbParameter("MenuForm", System.Data.OleDb.OleDbType.VarChar, 100, "MenuForm"), New System.Data.OleDb.OleDbParameter("MenuIcon", System.Data.OleDb.OleDbType.VarChar, 100, "MenuIcon"), New System.Data.OleDb.OleDbParameter("MenuIconExpanded", System.Data.OleDb.OleDbType.VarChar, 100, "MenuIconExpanded"), New System.Data.OleDb.OleDbParameter("MenuStartID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuStartID"), New System.Data.OleDb.OleDbParameter("MenuStartCode", System.Data.OleDb.OleDbType.VarChar, 50, "MenuStartCode"), New System.Data.OleDb.OleDbParameter("BrowseTableName", System.Data.OleDb.OleDbType.VarChar, 50, "BrowseTableName"), New System.Data.OleDb.OleDbParameter("BrowseIDField", System.Data.OleDb.OleDbType.VarChar, 50, "BrowseIDField"), New System.Data.OleDb.OleDbParameter("BrowseNameField", System.Data.OleDb.OleDbType.VarChar, 50, "BrowseNameField"), New System.Data.OleDb.OleDbParameter("BrowseToMaintMenuID", System.Data.OleDb.OleDbType.[Integer], 4, "BrowseToMaintMenuID"), New System.Data.OleDb.OleDbParameter("BrowseWhereClause", System.Data.OleDb.OleDbType.VarChar, 50, "BrowseWhereClause"), New System.Data.OleDb.OleDbParameter("BrowseOrderByClause", System.Data.OleDb.OleDbType.VarChar, 50, "BrowseOrderByClause"), New System.Data.OleDb.OleDbParameter("Original_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseIDField", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseIDField", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseIDField1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseIDField", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseNameField", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseNameField", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseNameField1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseNameField", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseOrderByClause", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseOrderByClause", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseOrderByClause1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseOrderByClause", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseTableName", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseTableName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseTableName1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseTableName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseToMaintMenuID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseToMaintMenuID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseToMaintMenuID1", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseToMaintMenuID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseWhereClause", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseWhereClause", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BrowseWhereClause1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrowseWhereClause", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuForm", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuForm1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIcon", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIcon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIcon1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIcon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIconExpanded", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIconExpanded", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuIconExpanded1", System.Data.OleDb.OleDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuIconExpanded", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuLabel", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuLabel", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuLabel1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuLabel", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartCode1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MenuStartID1", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuStartID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Select_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID")})
        '
        'OleDbDataAdapterMenu_Role
        '
        Me.OleDbDataAdapterMenu_Role.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapterMenu_Role.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapterMenu_Role.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapterMenu_Role.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "securitymenu_role", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RoleID", "RoleID"), New System.Data.Common.DataColumnMapping("MenuID", "MenuID")})})
        Me.OleDbDataAdapterMenu_Role.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM securitymenu_role WHERE (MenuID = ?) AND (RoleID = ?)"
        Me.OleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MenuID", System.Data.OleDb.OleDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_RoleID", System.Data.OleDb.OleDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RoleID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO securitymenu_role(RoleID, MenuID) VALUES (?, ?); SELECT RoleID, MenuI" & _
            "D FROM securitymenu_role WHERE (MenuID = ?) AND (RoleID = ?)"
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("RoleID", System.Data.OleDb.OleDbType.VarChar, 10, "RoleID"), New System.Data.OleDb.OleDbParameter("MenuID", System.Data.OleDb.OleDbType.VarChar, 10, "MenuID"), New System.Data.OleDb.OleDbParameter("Select_MenuID", System.Data.OleDb.OleDbType.VarChar, 10, "MenuID"), New System.Data.OleDb.OleDbParameter("Select_RoleID", System.Data.OleDb.OleDbType.VarChar, 10, "RoleID")})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT RoleID, MenuID FROM securitymenu_role WHERE (RoleID <> '0')"
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE securitymenu_role SET RoleID = ?, MenuID = ? WHERE (MenuID = ?) AND (RoleI" & _
            "D = ?); SELECT RoleID, MenuID FROM securitymenu_role WHERE (MenuID = ?) AND (Rol" & _
            "eID = ?)"
        Me.OleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("RoleID", System.Data.OleDb.OleDbType.VarChar, 10, "RoleID"), New System.Data.OleDb.OleDbParameter("MenuID", System.Data.OleDb.OleDbType.VarChar, 10, "MenuID"), New System.Data.OleDb.OleDbParameter("Original_MenuID", System.Data.OleDb.OleDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_RoleID", System.Data.OleDb.OleDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RoleID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Select_MenuID", System.Data.OleDb.OleDbType.VarChar, 10, "MenuID"), New System.Data.OleDb.OleDbParameter("Select_RoleID", System.Data.OleDb.OleDbType.VarChar, 10, "RoleID")})
        '
        'OleDbDataAdapterMenu_Sub
        '
        Me.OleDbDataAdapterMenu_Sub.DeleteCommand = Me.OleDbDeleteCommand3
        Me.OleDbDataAdapterMenu_Sub.InsertCommand = Me.OleDbInsertCommand3
        Me.OleDbDataAdapterMenu_Sub.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDbDataAdapterMenu_Sub.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "systemmenusub", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MenuID", "MenuID"), New System.Data.Common.DataColumnMapping("SubMenuID", "SubMenuID")})})
        Me.OleDbDataAdapterMenu_Sub.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM systemmenusub WHERE (MenuID = ?) AND (SubMenuID = ?)"
        Me.OleDbDeleteCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SubMenuID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubMenuID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO systemmenusub(MenuID, SubMenuID) VALUES (?, ?); SELECT MenuID, SubMen" & _
            "uID FROM systemmenusub WHERE (MenuID = ?) AND (SubMenuID = ?)"
        Me.OleDbInsertCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID"), New System.Data.OleDb.OleDbParameter("SubMenuID", System.Data.OleDb.OleDbType.[Integer], 4, "SubMenuID"), New System.Data.OleDb.OleDbParameter("Select_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID"), New System.Data.OleDb.OleDbParameter("Select_SubMenuID", System.Data.OleDb.OleDbType.[Integer], 4, "SubMenuID")})
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT MenuID, SubMenuID FROM systemmenusub"
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE systemmenusub SET MenuID = ?, SubMenuID = ? WHERE (MenuID = ?) AND (SubMen" & _
            "uID = ?); SELECT MenuID, SubMenuID FROM systemmenusub WHERE (MenuID = ?) AND (Su" & _
            "bMenuID = ?)"
        Me.OleDbUpdateCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID"), New System.Data.OleDb.OleDbParameter("SubMenuID", System.Data.OleDb.OleDbType.[Integer], 4, "SubMenuID"), New System.Data.OleDb.OleDbParameter("Original_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MenuID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SubMenuID", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubMenuID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Select_MenuID", System.Data.OleDb.OleDbType.[Integer], 4, "MenuID"), New System.Data.OleDb.OleDbParameter("Select_SubMenuID", System.Data.OleDb.OleDbType.[Integer], 4, "SubMenuID")})
        '
        'frmsystemmenu_Maintenance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(848, 454)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "frmsystemmenu_Maintenance"
        Me.Tag = ""
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PEdit.ResumeLayout(False)
        Me.PEdit.PerformLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridTranslation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTranslation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpGenericBrowseInfo.ResumeLayout(False)
        Me.GrpGenericBrowseInfo.PerformLayout()
        Me.TabRoles.ResumeLayout(False)
        CType(Me.GridMenuRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMenuRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRole, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim SQLRoleTxt, SQLMenuSubTxt As String
    Dim KeyDataSet As String = "BizzLib.dsSystem" 'The Dataset used 
    Dim CurrentMenuID As Integer
    Dim _SQLmenuTranslation As String = "SELECT * FROM systemmenutranslation "
    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            KeyFieldName = "MenuID"
            IDField = "MenuID"
            TableName = "systemmenu"
            MainDataSet = objDS

            HelpProvider1.HelpNamespace = ".\Help\" & SessionInfo.UserLang & "\BizzKeys.chm"
            SQLTxt1 = OleDbDataAdapter1.SelectCommand.CommandText
            SQLRoleTxt = OleDbDataAdapterMenu_Role.SelectCommand.CommandText
            '  SQLMenuSubTxt = OleDbDataAdapterMenu_Sub.SelectCommand.CommandText
            Me.LoadBKComboSet()
            Me.LoadDataSet()
            ' BKGlobal.LoadAssociatedMenu(Me.Tag, PopMenuAssociatedTasks, Me)
            '  TabAssociated.Visible = False
            If OpenType = "NEW" Then
                NewRecord(sender, e)
            End If
            If OpenType = "EDIT" Then
                If KeyValue <> "" Then
                    objDS.Tables(TableName).DefaultView.Sort = KeyFieldName
                    Me.BindingContext(objDS, TableName).Position = Me.objDS.Tables(TableName).DefaultView.Find(KeyValue)
                    PositionChanged(sender, e)
                    EditRecord(sender, e)
                Else
                    OpenType = "BROWSE"
                    Exit Sub
                End If
            End If
        Catch eLoad As System.Exception
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
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

            Me.BindingContext(objDS, TableName).AddNew()

            Dim Nextid As Integer = GetLastId()
            CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField) = Nextid
            CType(Me.BindingContext(objDS, TableName).Current, DataRowView)("MenuAssembly") = "DVDPostLib.dll"
            CType(Me.BindingContext(objDS, TableName).Current, DataRowView)("MenuStartID") = GetLastMenuStartId()
            Me.BindingContext(objDS, TableName).Position = Me.objDS.Tables(TableName).Rows.Count
            Me.BindingContext(objDS, TableName).EndCurrentEdit()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        'PositionChanged(Sender, e)
        UndoChanges(Sender, e)
        EditRecord(Sender, e)

    End Sub
    Private Function GetLastMenuStartId() As Integer
        Dim sql As String
        Dim result As Integer

        sql = "select max(MenuStartID) from systemmenu"
        result = PlushData.clsConnection.ExecuteScalar(sql)

        Return result + 1

    End Function

    Private Function GetLastId() As Integer
        Dim sql As String
        Dim result As Integer

        sql = "select max(" & IDField & ") from systemmenu"
        result = PlushData.clsConnection.ExecuteScalar(sql)

        Return result + 1

    End Function
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
        Dim _ID As Integer
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            _ID = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField)
            If MsgBox(BKGlobal.GetMsg(1, SessionInfo.UserLang), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If ValidateBeforeDelete() Then
                    BKGlobal.DeleteTranslations(TableName & "." & IDField, _ID)
                    DeleteMenuLinkedTables(_ID)
                    Me.BindingContext(objDS, TableName).RemoveAt(Me.BindingContext(objDS, TableName).Position)
                    UpdateDataSet()
                    EnablingAll(False)
                    PositionChanged(Sender, e)
                End If
            End If
        End If
    End Sub
    Private Function ValidateBeforeDelete() As Boolean
        Return True
    End Function
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
        Dim _ID As Integer
        ' If ValidateBeforeSave() Then
        Try
            If CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField) & "" = "" Then
                _ID = BKGlobal.GetNextID(IDField)
                CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField) = _ID
            Else
                _ID = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField) & ""
            End If
            GridViewMenuRole.CloseEditor()
            GridViewMenuRole.UpdateCurrentRow()
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
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        Finally
        End Try
        PositionChanged(Sender, e)
        ' End If
    End Sub
    Private Function ValidateBeforeSave() As Boolean
        If txtMenuLabel.Text & "" = "" Then
            MsgBox(BKGlobal.GetMsg(5, SessionInfo.UserLang), MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function

    Public Sub UpdateDataSet() Handles MyBase.EventUpdateDataset
        Dim objService As New BizzLib.clsDataSet(SessionInfo)
        Dim objDataSetChanges As BizzLib.dsSystem = New BizzLib.dsSystem
        Me.BindingContext(objDS, TableName).EndCurrentEdit()
        Me.BindingContext(objDS, "securitymenu_role").EndCurrentEdit()
        GridViewTranslation.CloseEditor()
        GridViewTranslation.UpdateCurrentRow()
        objDataSetChanges = CType(objDS.GetChanges, BizzLib.dsSystem)
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                objService.UpdateDataSource(objDataSetChanges.Tables(TableName), OleDbDataAdapter1)
                objService.UpdateDataSource(objDataSetChanges.Tables("securitymenu_role"), OleDbDataAdapterMenu_Role)
                objDS.Merge(objDataSetChanges)
                objDS.AcceptChanges()
            Catch eUpdate As System.Exception
                Throw eUpdate
            End Try
        End If

    End Sub
    Public Sub LoadDataSet() Handles MyBase.EventLoadDataset

        Try
            SQLTxt1 = "select * from systemmenu where 1"
            If IsFiltered Then
                OleDbDataAdapter1.SelectCommand.CommandText = SQLTxt1 & " AND " & FilterTxt & " ORDER BY " & KeyFieldName
            Else
                OleDbDataAdapter1.SelectCommand.CommandText = SQLTxt1 & " ORDER BY " & KeyFieldName
            End If
            objDS.Tables(TableName).Clear()
            PlushData.clsConnection.FillDataSet(objDS.Tables(TableName), OleDbDataAdapter1.SelectCommand.CommandText)
        Catch eFillDataSet As System.Exception
            Throw eFillDataSet
        End Try
        Try
            Me.objDS.Tables(TableName).DefaultView.Sort = KeyFieldName
        Catch eLoadMerge As System.Exception
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub LoadBKComboSet()
        Try
            BKCombo.GetCombo_Role(objDS, "securityrole", "Name")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LoadMenuRolesDataSet()

        Try
            SQLRoleTxt = "select * from securitymenu_role where 1"
            objDS.Tables("securitymenu_role").Clear()
            OleDbDataAdapterMenu_Role.SelectCommand.CommandText = SQLRoleTxt & " AND MenuID = " & CurrentMenuID
            PlushData.clsConnection.FillDataSet(objDS.Tables("securitymenu_role"), OleDbDataAdapterMenu_Role.SelectCommand.CommandText)
        Catch eFillDataSet As System.Exception
            Throw eFillDataSet
        End Try
        Try

            objDS.Tables("securitymenu_role").Columns("MenuID").DefaultValue = CurrentMenuID
        Catch eLoadMerge As System.Exception
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub LoadMenuSubDataSet()
        Dim objDataSetTemp As DataSet
        objDataSetTemp = objDS.Clone

        Try
            OleDbDataAdapterMenu_Sub.SelectCommand.CommandText = SQLMenuSubTxt & " WHERE MenuID = " & CurrentMenuID
            PlushData.clsConnection.FillDataSet(objDataSetTemp.Tables("systemmenusub"), OleDbDataAdapterMenu_Sub.SelectCommand.CommandText)
        Catch eFillDataSet As System.Exception
            Throw eFillDataSet
        End Try
        Try
            objDS.Tables("systemmenusub").Clear()
            objDS.Merge(objDataSetTemp)
            objDS.Tables("systemmenusub").Columns("MenuID").DefaultValue = CurrentMenuID
        Catch eLoadMerge As System.Exception
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub LoadMenuTranslationDataSet()
        Dim objDataSetTemp As DataSet
        objDataSetTemp = objDS.Clone
        Try
            PlushData.clsConnection.FillDataSet(objDataSetTemp.Tables("systemmenutranslation"), _SQLmenuTranslation & " WHERE MenuID = " & CurrentMenuID)
        Catch eFillDataSet As System.Exception
            Throw eFillDataSet
        End Try
        Try
            objDS.Tables("systemmenutranslation").Clear()
            objDS.Merge(objDataSetTemp)
            objDS.Tables("systemmenutranslation").Columns("MenuID").DefaultValue = CurrentMenuID
        Catch eLoadMerge As System.Exception
            Throw eLoadMerge
        End Try

    End Sub

    Private Sub PositionChanged(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.EventPositionChanged
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            If CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField) & "" <> "" Then
                CurrentMenuID = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField)
                LoadMenuRolesDataSet()
            Else
                CurrentMenuID = -1
                '  objDS.Tables("systemmenutranslation").Clear()
                '  objDS.Tables("systemmenusub").Clear()
                objDS.Tables("securitymenu_role").Clear()
            End If
            StatusBar1.Panels(0).Text = (((Me.BindingContext(objDS, TableName).Position + 1).ToString + " of  ") _
                        + Me.BindingContext(objDS, TableName).Count.ToString)
            ToolTip1.SetToolTip(StatusBar1, TableName & "-->" & IDField & "=" & CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField) & "")
            txtQuickSearch.EditValue = txtMenuLabel.Text
        End If
    End Sub

    Private Sub EnablingEditFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingEditFields
        'txtMenuLabel.Enabled = Enabling
        'txtMenuForm.Enabled = Enabling
        'txtMenuICon.Enabled = Enabling
        'txtMenuIconExpanded.Enabled = Enabling
        'txtMenuStartID.Enabled = Enabling
        'txtMenuStartCode.Enabled = Enabling
        'txtBIDField.Enabled = Enabling
        'txtBNameField.Enabled = Enabling
        'txtBTableName.Enabled = Enabling
        'txtToMaintMenuID.Enabled = Enabling
        'txtBrowseWhere.Enabled = Enabling
        'txtOrderBy.Enabled = Enabling
        'txtAssemblyName.Enabled = Enabling
        PEdit.Enabled = Enabling
        GridMenuRole.EmbeddedNavigator.Enabled = Enabling
        GridViewMenuRole.OptionsBehavior.Editable = Enabling
        ' GridMenuParent.EmbeddedNavigator.Enabled = Enabling
        ' GridViewMenuParent.OptionsBehavior.Editable = Enabling
        GridMenuRole.Enabled = Enabling
        'GridMenuParent.Enabled = Enabling
        ' GridViewTranslation.OptionsBehavior.Editable = Enabling
        ' GridTranslation.EmbeddedNavigator.Enabled = Enabling
    End Sub
    Private Sub EnablingKeyFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingkeyFields
    End Sub
    Private Sub StartPrintForm() Handles MyBase.EventPrintForm
        BKReport.PrintForm(CurrentReportID, New DataRow() { _
            CType(Me.BindingContext(MainDataSet, TableName).Current, DataRowView).Row, _
            CType(Me.BindingContext(objDS, "GeneralAddress").Current, DataRowView).Row})
    End Sub

End Class
