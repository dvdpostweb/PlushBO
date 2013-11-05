Imports BizzLib.clsGlobal.ObjectState

Public Class frmSecurityUser_Maintenance
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents lblLang As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents cmbLang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtPassWord As System.Windows.Forms.TextBox
    Friend WithEvents lblPassWord As System.Windows.Forms.Label
    Friend WithEvents cmbShortCut As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblShortCut As System.Windows.Forms.Label
    Friend WithEvents cmbDefaultRole As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblDefaultRole As System.Windows.Forms.Label
    Friend WithEvents chkBannerVisible As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents chkAutoSaveViews As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowInTaskBar As System.Windows.Forms.CheckBox
    Friend WithEvents btnBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUserDocPath As System.Windows.Forms.TextBox
    Friend WithEvents lblUserDocPath As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents chkAutoHideMenu As System.Windows.Forms.CheckBox
    Friend WithEvents DsUsers1 As PlushLib.DsUsers
    Friend WithEvents txtCustomers_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblBox_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCust_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBox_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridUserRole As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewUserRole As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRoleID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbRole As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ChkEncrypted As System.Windows.Forms.CheckBox
    Friend WithEvents TabUser As System.Windows.Forms.TabPage
    Friend WithEvents TabRole As System.Windows.Forms.TabPage

    '<System.Diagnostics.DebuggerStepThrough()> 
    Private Sub InitializeComponent()
        Me.TabRole = New TabPage
        Me.TabUser = New TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtBox_id = New DevExpress.XtraEditors.TextEdit
        Me.DsUsers1 = New PlushLib.DsUsers
        Me.lblBox_id = New DevExpress.XtraEditors.LabelControl
        Me.lblCust_id = New DevExpress.XtraEditors.LabelControl
        Me.txtCustomers_id = New DevExpress.XtraEditors.TextEdit
        Me.ChkEncrypted = New System.Windows.Forms.CheckBox
        Me.btnBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.txtUserDocPath = New System.Windows.Forms.TextBox
        Me.lblUserDocPath = New System.Windows.Forms.Label
        Me.chkAutoHideMenu = New System.Windows.Forms.CheckBox
        Me.chkShowInTaskBar = New System.Windows.Forms.CheckBox
        Me.chkAutoSaveViews = New System.Windows.Forms.CheckBox
        Me.chkBannerVisible = New System.Windows.Forms.CheckBox
        Me.cmbDefaultRole = New DevExpress.XtraEditors.LookUpEdit
        Me.lblDefaultRole = New System.Windows.Forms.Label
        Me.cmbShortCut = New DevExpress.XtraEditors.LookUpEdit
        Me.lblShortCut = New System.Windows.Forms.Label
        Me.txtPassWord = New System.Windows.Forms.TextBox
        Me.lblPassWord = New System.Windows.Forms.Label
        Me.cmbLang = New DevExpress.XtraEditors.LookUpEdit
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtLogin = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.lblLogin = New System.Windows.Forms.Label
        Me.lblLang = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.GridUserRole = New DevExpress.XtraGrid.GridControl
        Me.GridViewUserRole = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colRoleID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbRole = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        TabUser = New System.Windows.Forms.TabPage
        TabRole = New System.Windows.Forms.TabPage
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txtBox_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsUsers1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomers_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultRole.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbShortCut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        TabUser.SuspendLayout()
        TabRole.SuspendLayout()
        CType(Me.GridUserRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewUserRole, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.StatusBar1.Location = New System.Drawing.Point(0, 360)
        Me.StatusBar1.Size = New System.Drawing.Size(528, 22)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.txtBox_id)
        Me.Panel1.Controls.Add(Me.lblBox_id)
        Me.Panel1.Controls.Add(Me.lblCust_id)
        Me.Panel1.Controls.Add(Me.txtCustomers_id)
        Me.Panel1.Controls.Add(Me.ChkEncrypted)
        Me.Panel1.Controls.Add(Me.btnBrowse)
        Me.Panel1.Controls.Add(Me.txtUserDocPath)
        Me.Panel1.Controls.Add(Me.lblUserDocPath)
        Me.Panel1.Controls.Add(Me.chkAutoHideMenu)
        Me.Panel1.Controls.Add(Me.chkShowInTaskBar)
        Me.Panel1.Controls.Add(Me.chkAutoSaveViews)
        Me.Panel1.Controls.Add(Me.chkBannerVisible)
        Me.Panel1.Controls.Add(Me.cmbDefaultRole)
        Me.Panel1.Controls.Add(Me.lblDefaultRole)
        Me.Panel1.Controls.Add(Me.cmbShortCut)
        Me.Panel1.Controls.Add(Me.lblShortCut)
        Me.Panel1.Controls.Add(Me.txtPassWord)
        Me.Panel1.Controls.Add(Me.lblPassWord)
        Me.Panel1.Controls.Add(Me.cmbLang)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.txtLogin)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.lblLogin)
        Me.Panel1.Controls.Add(Me.lblLang)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 281)
        Me.Panel1.TabIndex = 31
        '
        'txtBox_id
        '
        Me.txtBox_id.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsUsers1, "securityuser.box_id", True))
        Me.txtBox_id.Location = New System.Drawing.Point(351, 173)
        Me.txtBox_id.Name = "txtBox_id"
        Me.txtBox_id.Size = New System.Drawing.Size(82, 20)
        Me.txtBox_id.TabIndex = 48
        '
        'DsUsers1
        '
        Me.DsUsers1.DataSetName = "DsUsers"
        Me.DsUsers1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblBox_id
        '
        Me.lblBox_id.Location = New System.Drawing.Point(267, 176)
        Me.lblBox_id.Name = "lblBox_id"
        Me.lblBox_id.Size = New System.Drawing.Size(32, 13)
        Me.lblBox_id.TabIndex = 47
        Me.lblBox_id.Text = "box_id"
        '
        'lblCust_id
        '
        Me.lblCust_id.Location = New System.Drawing.Point(267, 138)
        Me.lblCust_id.Name = "lblCust_id"
        Me.lblCust_id.Size = New System.Drawing.Size(63, 13)
        Me.lblCust_id.TabIndex = 46
        Me.lblCust_id.Text = "customers_id"
        '
        'txtCustomers_id
        '
        Me.txtCustomers_id.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsUsers1, "securityuser.customers_id", True))
        Me.txtCustomers_id.Location = New System.Drawing.Point(351, 135)
        Me.txtCustomers_id.Name = "txtCustomers_id"
        Me.txtCustomers_id.Size = New System.Drawing.Size(127, 20)
        Me.txtCustomers_id.TabIndex = 45
        '
        'ChkEncrypted
        '
        Me.ChkEncrypted.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkEncrypted.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsUsers1, "securityuser.isencrypt", True))
        Me.ChkEncrypted.Enabled = False
        Me.ChkEncrypted.Location = New System.Drawing.Point(267, 64)
        Me.ChkEncrypted.Name = "ChkEncrypted"
        Me.ChkEncrypted.Size = New System.Drawing.Size(71, 22)
        Me.ChkEncrypted.TabIndex = 44
        Me.ChkEncrypted.Text = "encrypted"
        Me.ChkEncrypted.Visible = False
        Me.ChkEncrypted.Checked = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(464, 95)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(24, 23)
        Me.btnBrowse.TabIndex = 43
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.Visible = False
        '
        'txtUserDocPath
        '
        Me.txtUserDocPath.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsUsers1, "securityuser.UserDocPath", True))
        Me.txtUserDocPath.Enabled = False
        Me.txtUserDocPath.Location = New System.Drawing.Point(128, 95)
        Me.txtUserDocPath.Name = "txtUserDocPath"
        Me.txtUserDocPath.Size = New System.Drawing.Size(328, 20)
        Me.txtUserDocPath.TabIndex = 42
        Me.txtUserDocPath.Visible = False
        '
        'lblUserDocPath
        '
        Me.lblUserDocPath.Location = New System.Drawing.Point(24, 95)
        Me.lblUserDocPath.Name = "lblUserDocPath"
        Me.lblUserDocPath.Size = New System.Drawing.Size(104, 23)
        Me.lblUserDocPath.TabIndex = 41
        Me.lblUserDocPath.Text = "User Doc Path"
        Me.lblUserDocPath.Visible = False
        '
        'chkAutoHideMenu
        '
        Me.chkAutoHideMenu.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAutoHideMenu.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsUsers1, "securityuser.AutoHideMenu", True))
        Me.chkAutoHideMenu.Enabled = False
        Me.chkAutoHideMenu.Location = New System.Drawing.Point(272, 240)
        Me.chkAutoHideMenu.Name = "chkAutoHideMenu"
        Me.chkAutoHideMenu.Size = New System.Drawing.Size(120, 24)
        Me.chkAutoHideMenu.TabIndex = 21
        Me.chkAutoHideMenu.Text = "Auto Hide Menu"
        Me.chkAutoHideMenu.Visible = False
        '
        'chkShowInTaskBar
        '
        Me.chkShowInTaskBar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkShowInTaskBar.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsUsers1, "securityuser.ShowInTaskBar", True))
        Me.chkShowInTaskBar.Enabled = False
        Me.chkShowInTaskBar.Location = New System.Drawing.Point(24, 240)
        Me.chkShowInTaskBar.Name = "chkShowInTaskBar"
        Me.chkShowInTaskBar.Size = New System.Drawing.Size(120, 24)
        Me.chkShowInTaskBar.TabIndex = 20
        Me.chkShowInTaskBar.Text = "Show in task bar"
        Me.chkShowInTaskBar.Visible = False
        '
        'chkAutoSaveViews
        '
        Me.chkAutoSaveViews.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAutoSaveViews.Enabled = False
        Me.chkAutoSaveViews.Location = New System.Drawing.Point(168, 208)
        Me.chkAutoSaveViews.Name = "chkAutoSaveViews"
        Me.chkAutoSaveViews.Size = New System.Drawing.Size(224, 24)
        Me.chkAutoSaveViews.TabIndex = 19
        Me.chkAutoSaveViews.Text = "Auto Save Views on Closing Windows"
        Me.chkAutoSaveViews.Visible = False
        '
        'chkBannerVisible
        '
        Me.chkBannerVisible.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkBannerVisible.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsUsers1, "securityuser.BannerVisible", True))
        Me.chkBannerVisible.Enabled = False
        Me.chkBannerVisible.Location = New System.Drawing.Point(24, 208)
        Me.chkBannerVisible.Name = "chkBannerVisible"
        Me.chkBannerVisible.Size = New System.Drawing.Size(120, 24)
        Me.chkBannerVisible.TabIndex = 18
        Me.chkBannerVisible.Text = "Show Banners"
        Me.chkBannerVisible.Visible = False
        '
        'cmbDefaultRole
        '
        Me.cmbDefaultRole.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsUsers1, "securityuser.DefaultRoleID", True))
        Me.cmbDefaultRole.Location = New System.Drawing.Point(128, 176)
        Me.cmbDefaultRole.Name = "cmbDefaultRole"
        Me.cmbDefaultRole.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDefaultRole.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 38, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbDefaultRole.Properties.DisplayMember = "Name"
        Me.cmbDefaultRole.Properties.NullText = ""
        Me.cmbDefaultRole.Properties.ValueMember = "RoleID"
        Me.cmbDefaultRole.Size = New System.Drawing.Size(120, 20)
        Me.cmbDefaultRole.TabIndex = 17
        Me.cmbDefaultRole.Visible = False
        '
        'lblDefaultRole
        '
        Me.lblDefaultRole.Location = New System.Drawing.Point(24, 176)
        Me.lblDefaultRole.Name = "lblDefaultRole"
        Me.lblDefaultRole.Size = New System.Drawing.Size(100, 23)
        Me.lblDefaultRole.TabIndex = 16
        Me.lblDefaultRole.Text = "Default Role"
        Me.lblDefaultRole.Visible = False
        '
        'cmbShortCut
        '
        Me.cmbShortCut.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsUsers1, "securityuser.ShortCutID", True))
        Me.cmbShortCut.Location = New System.Drawing.Point(128, 152)
        Me.cmbShortCut.Name = "cmbShortCut"
        Me.cmbShortCut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbShortCut.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 38, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbShortCut.Properties.DisplayMember = "Name"
        Me.cmbShortCut.Properties.NullText = ""
        Me.cmbShortCut.Properties.ValueMember = "ShortCutID"
        Me.cmbShortCut.Size = New System.Drawing.Size(120, 20)
        Me.cmbShortCut.TabIndex = 15
        Me.cmbShortCut.Visible = False
        '
        'lblShortCut
        '
        Me.lblShortCut.Location = New System.Drawing.Point(24, 152)
        Me.lblShortCut.Name = "lblShortCut"
        Me.lblShortCut.Size = New System.Drawing.Size(100, 23)
        Me.lblShortCut.TabIndex = 14
        Me.lblShortCut.Text = "ShortCut Profile"
        Me.lblShortCut.Visible = False
        '
        'txtPassWord
        '
        Me.txtPassWord.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsUsers1, "securityuser.PassWord", True))
        Me.txtPassWord.Enabled = False
        Me.txtPassWord.Location = New System.Drawing.Point(368, 48)
        Me.txtPassWord.Name = "txtPassWord"
        Me.txtPassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassWord.Size = New System.Drawing.Size(120, 20)
        Me.txtPassWord.TabIndex = 13
        '
        'lblPassWord
        '
        Me.lblPassWord.Location = New System.Drawing.Point(264, 48)
        Me.lblPassWord.Name = "lblPassWord"
        Me.lblPassWord.Size = New System.Drawing.Size(100, 23)
        Me.lblPassWord.TabIndex = 12
        Me.lblPassWord.Text = "PassWord"
        '
        'cmbLang
        '
        Me.cmbLang.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsUsers1, "securityuser.Lang", True))
        Me.cmbLang.Location = New System.Drawing.Point(128, 128)
        Me.cmbLang.Name = "cmbLang"
        Me.cmbLang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Lang", "Lang", 46, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbLang.Properties.DisplayMember = "Lang"
        Me.cmbLang.Properties.NullText = ""
        Me.cmbLang.Properties.ValueMember = "Lang"
        Me.cmbLang.Size = New System.Drawing.Size(120, 20)
        Me.cmbLang.TabIndex = 11
        Me.cmbLang.Visible = False
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsUsers1, "securityuser.FullName", True))
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(128, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(360, 20)
        Me.txtName.TabIndex = 8
        '
        'txtLogin
        '
        Me.txtLogin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsUsers1, "securityuser.Login", True))
        Me.txtLogin.Enabled = False
        Me.txtLogin.Location = New System.Drawing.Point(128, 48)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(120, 20)
        Me.txtLogin.TabIndex = 9
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(24, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 23)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'lblLogin
        '
        Me.lblLogin.Location = New System.Drawing.Point(24, 48)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(100, 23)
        Me.lblLogin.TabIndex = 4
        Me.lblLogin.Text = "Login"
        '
        'lblLang
        '
        Me.lblLang.Location = New System.Drawing.Point(24, 128)
        Me.lblLang.Name = "lblLang"
        Me.lblLang.Size = New System.Drawing.Size(100, 23)
        Me.lblLang.TabIndex = 5
        Me.lblLang.Text = "Language"
        Me.lblLang.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(TabUser)
        Me.TabControl1.Controls.Add(TabRole)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 53)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(528, 307)
        Me.TabControl1.TabIndex = 33
        '
        'TabUser
        '
        TabUser.Controls.Add(Me.Panel1)
        TabUser.Location = New System.Drawing.Point(4, 22)
        TabUser.Name = "TabUser"
        TabUser.Size = New System.Drawing.Size(520, 281)
        TabUser.TabIndex = 0
        TabUser.Text = "User"
        TabUser.UseVisualStyleBackColor = True
        '
        'TabRole
        '
        TabRole.Controls.Add(Me.GridUserRole)
        TabRole.Location = New System.Drawing.Point(4, 22)
        TabRole.Name = "TabRole"
        TabRole.Size = New System.Drawing.Size(520, 281)
        TabRole.TabIndex = 2
        TabRole.Text = "Assigned Roles"
        TabRole.UseVisualStyleBackColor = True
        '
        'GridUserRole
        '
        Me.GridUserRole.DataSource = Me.DsUsers1.securityuser_role
        Me.GridUserRole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridUserRole.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridUserRole.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridUserRole.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridUserRole.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridUserRole.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridUserRole.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridUserRole.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridUserRole.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridUserRole.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridUserRole.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridUserRole.EmbeddedNavigator.Buttons.Remove.ImageIndex = 1
        Me.GridUserRole.EmbeddedNavigator.Enabled = False
        Me.GridUserRole.EmbeddedNavigator.Name = ""
        Me.GridUserRole.Enabled = False
        Me.GridUserRole.FormsUseDefaultLookAndFeel = False
        Me.GridUserRole.Location = New System.Drawing.Point(0, 0)
        Me.GridUserRole.MainView = Me.GridViewUserRole
        Me.GridUserRole.Name = "GridUserRole"
        Me.GridUserRole.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbRole})
        Me.GridUserRole.Size = New System.Drawing.Size(520, 281)
        Me.GridUserRole.TabIndex = 1
        Me.GridUserRole.UseEmbeddedNavigator = True
        Me.GridUserRole.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewUserRole})
        '
        'GridViewUserRole
        '
        Me.GridViewUserRole.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRoleID})
        Me.GridViewUserRole.GridControl = Me.GridUserRole
        Me.GridViewUserRole.GroupPanelText = "..."
        Me.GridViewUserRole.Name = "GridViewUserRole"
        Me.GridViewUserRole.OptionsBehavior.Editable = False
        Me.GridViewUserRole.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridViewUserRole.OptionsView.ShowGroupPanel = False
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
        Me.cmbRole.DataSource = Me.DsUsers1.securityrole
        Me.cmbRole.DisplayMember = "Name"
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.NullText = ""
        Me.cmbRole.ValueMember = "RoleID"
        '
        'frmSecurityUser_Maintenance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 382)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "frmSecurityUser_Maintenance"
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtBox_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsUsers1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomers_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultRole.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbShortCut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        TabUser.ResumeLayout(False)
        TabRole.ResumeLayout(False)
        CType(Me.GridUserRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewUserRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRole, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub

    Dim CurrentUserID As Integer
    Dim SQLMenuTxt, SQLRoleTxt As String
    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'SetUp of Variables
            KeyFieldName = "FullName"
            IDField = "UserID"
            TableName = "securityuser"

            SQLRoleTxt = "select * from securityuser_role where "
            'Attempt to load the dataset.
            ' Me.LoadBKComboSet()
            Me.LoadDataSet()

            BKGlobal.LoadAssociatedMenu(Me.Tag, PopMenuAssociatedTasks, Me)
            If OpenType = "NEW" Then
                NewRecord(sender, e)
            End If
            If OpenType = "EDIT" Then
                If KeyValue <> "" Then
                    Me.DsUsers1.securityuser.DefaultView.Sort = IDField
                    Dim _Name As String = Me.DsUsers1.securityuser.DefaultView(Me.DsUsers1.securityuser.DefaultView.Find(New Object() {KeyValue}))(KeyFieldName)

                    Me.DsUsers1.securityuser.DefaultView.Sort = KeyFieldName
                    Me.BindingContext(DsUsers1, DsUsers1.securityuser.TableName).Position = Me.DsUsers1.securityuser.DefaultView.Find(New Object() {_Name})
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
        changeState(NewState)
        Try
            Me.BindingContext(DsUsers1, DsUsers1.securityuser.TableName).EndCurrentEdit()
            Me.BindingContext(DsUsers1, DsUsers1.securityuser.TableName).AddNew()

        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        PositionChanged(Sender, e)
    End Sub
    Private Sub EditRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuEdit.Click, MyBase.EventEditRecord
        If Me.BindingContext(DsUsers1, DsUsers1.securityuser.TableName).Position < 0 Then
            Exit Sub
        End If
        changeState(EditState)
    End Sub
    Private Sub DeleteRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuDelete.Click, MyBase.EventDeleteRecord
        Dim _ID As Integer
        Dim login As String
        If Me.BindingContext(DsUsers1, TableName).Position >= 0 Then
            _ID = CType(Me.BindingContext(DsUsers1, TableName).Current, DataRowView)(IDField)
            login = CType(Me.BindingContext(DsUsers1, TableName).Current, DataRowView)("login")
            Try
                If TabControl1.SelectedTab Is TabUser Then
                    If MsgBox("confirm delete User " & login & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        DeleteUserLinkedTables(_ID)
                        Me.BindingContext(DsUsers1, TableName).RemoveAt(Me.BindingContext(DsUsers1, TableName).Position)
                    End If
                ElseIf TabControl1.SelectedTab Is TabRole Then
                    Me.BindingContext(DsUsers1, DsUsers1.securityuser_role.TableName).RemoveAt(Me.BindingContext(DsUsers1, DsUsers1.securityuser_role.TableName).Position)
                End If
                ' BKGlobal.DeleteTranslations(TableName & "." & IDField, _ID)
                ' BKGlobal.DeleteComments(SessionInfo.EntityID, txtName.Text)
                'Delete Associated Tables
                ' DeleteUserLinkedTables(_ID)
                'Deleting User

                UpdateDataSet()
                EnablingAll(False)
                PositionChanged(Sender, e)
            Catch ex As Exception
                MsgBox(BKGlobal.GetMsg(7, SessionInfo.UserLang), MsgBoxStyle.Critical)
                Exit Sub
            End Try

        End If
    End Sub
    Private Sub changeState(ByVal state As BizzLib.clsGlobal.ObjectState)
        SetState(state)

        If state = BrowseState Then
            UpdateAction(True)
            OpenType = "BROWSE"
        ElseIf state = EditState Then
            UpdateAction(False)
            'EnablingForEdit()
            OpenType = "EDIT"
        ElseIf state = NewState Then
            UpdateAction(False)
            OpenType = "NEW"
        End If
    End Sub

    Private Sub UpdateAction(ByVal Lock As Boolean)

        PopMenuNew.Enabled = Lock
        PopMenuEdit.Enabled = Lock
        PopMenuSave.Enabled = Not Lock
        PopMenuDelete.Enabled = Lock
        PopMenuUndo.Enabled = Not Lock
        EnablingAll(Not Lock)
    End Sub
    Private Sub UndoChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuUndo.Click, MyBase.EventUndoChanges
        changeState(BrowseState)
        Me.BindingContext(DsUsers1, TableName).CancelCurrentEdit()
        PositionChanged(Sender, e)
    End Sub
    Private Sub SaveChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuSave.Click, MyBase.EventSaveChanges
        Dim _ID As Integer


        Try
            'If CType(Me.BindingContext(DsUsers1, TableName).Current, DataRowView)(IDField) & "" = "" Then
            '    '_ID = BKGlobal.GetNextID(IDField)
            '    _ID = CType(Me.BindingContext(DsUsers1, TableName).Current, DataRowView)(IDField) & ""
            'Else
            '    _ID = CType(Me.BindingContext(DsUsers1, TableName).Current, DataRowView)(IDField) & ""
            'End If
            GridViewUserRole.CloseEditor()
            GridViewUserRole.UpdateCurrentRow()

            Me.UpdateDataSet()
            changeState(BrowseState)

            ' GridView1.CloseEditor()
            ' GridView1.UpdateCurrentRow()

        Catch eUpdate As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        End Try
        PositionChanged(Sender, e)

    End Sub

    Public Sub UpdateDataSet() Handles MyBase.EventUpdateDataset

        If Not ChkEncrypted.Checked Then
            txtPassWord.Text = PlushBuziness.ClsCustomers.MD5Encrypt(txtPassWord.Text)
            ChkEncrypted.Checked = True
        End If
        'Stop any current edits.
        Me.BindingContext(DsUsers1, DsUsers1.securityuser.TableName).EndCurrentEdit()

        Me.BindingContext(DsUsers1, DsUsers1.securityuser_role.TableName).EndCurrentEdit()

        Try

            PlushData.clsConnection.UpdateDataTableInDB(DsUsers1.securityuser, PlushData.clsUsers.GetselectUser)
            PlushData.clsConnection.UpdateDataTableInDB(DsUsers1.securityuser_role, PlushData.clsUsers.GetselectUser_role(CurrentUserID))
            DsUsers1.AcceptChanges()
        Catch eUpdate As System.Exception

            Throw eUpdate
        End Try

    End Sub
    Private Sub loadRole()
        Dim sql As String
        sql = PlushData.clsUsers.GetselectRole()
        PlushData.clsConnection.FillDataSet(DsUsers1.securityrole, sql)

    End Sub

    Private Sub loadUser_role(ByVal user_id As Integer)
        Dim sql As String
        sql = PlushData.clsUsers.GetselectUser_role(user_id)
        DsUsers1.securityuser_role.Clear()
        PlushData.clsConnection.FillDataSet(DsUsers1.securityuser_role, sql)
        DsUsers1.securityuser_role.Columns(DsUsers1.securityuser_role.UserIdColumn.ColumnName).DefaultValue = user_id

    End Sub

    Private Sub loadUser()
        Dim sql As String
        sql = PlushData.clsUsers.GetselectUser()
        PlushData.clsConnection.FillDataSet(DsUsers1.securityuser, sql)

    End Sub

    Public Sub LoadDataSet() Handles MyBase.EventLoadDataset
        loadUser()
        loadRole()
    End Sub


    Private Function SearchByLogin(ByVal login As String) As Integer
        Dim index As Integer = 0
        Dim finded As Boolean = False
        While Not finded And index < DsUsers1.securityuser.Count
            If DsUsers1.securityuser.Rows(index)(DsUsers1.securityuser.LoginColumn.Caption) = login Then
                finded = True
            Else
                index += 1
            End If
        End While
        If finded Then
            Return index
        Else
            Return -1
        End If
    End Function
    Public Overrides Sub btnQuickSearch_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuickSearch.ItemClick
        Dim pos As Integer
        pos = SearchByLogin(txtQuickSearch.EditValue)
        If pos > -1 Then
            Me.BindingContext(DsUsers1, DsUsers1.securityuser.TableName).Position = pos
            CurrentUserID = CType(Me.BindingContext(DsUsers1, DsUsers1.securityuser.TableName).Current, DataRowView)(IDField)
            loadUser_role(CurrentUserID)
        End If

    End Sub

    Private Sub PositionChanged(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.EventPositionChanged
        If Me.BindingContext(DsUsers1, DsUsers1.securityuser.TableName).Position >= 0 Then
            If CType(Me.BindingContext(DsUsers1, DsUsers1.securityuser.TableName).Current, DataRowView)(IDField) & "" <> "" Then
                CurrentUserID = CType(Me.BindingContext(DsUsers1, DsUsers1.securityuser.TableName).Current, DataRowView)(IDField)
                loadUser_role(CurrentUserID)
            Else
                CurrentUserID = -1
            End If
            'StatusBar1.Panels(0).Text = (((Me.BindingContext(DsUsers1, DsUsers1.securityuser.TableName).Position + 1).ToString + " of  ") _
            '            + Me.BindingContext(DsUsers1, TableName).Count.ToString)
            ' ToolTip1.SetToolTip(StatusBar1, DsUsers1.securityuser.TableName & "-->" & IDField & "=" & CType(Me.BindingContext(DsUsers1, DsUsers1.securityuser.TableName).Current, DataRowView)(IDField) & "")
            txtQuickSearch.EditValue = CType(Me.BindingContext(DsUsers1, DsUsers1.securityuser.TableName).Current, DataRowView)("Login")
        End If
    End Sub

    Private Sub EnablingEditFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingEditFields
        txtName.Enabled = Enabling
        txtLogin.Enabled = Enabling
        txtPassWord.Enabled = Enabling
        txtUserDocPath.Enabled = Enabling
        cmbLang.Properties.Enabled = Enabling
        cmbDefaultRole.Properties.Enabled = Enabling
        cmbShortCut.Properties.Enabled = Enabling
        chkBannerVisible.Enabled = Enabling
        chkAutoSaveViews.Enabled = Enabling
        chkShowInTaskBar.Enabled = Enabling
        chkAutoHideMenu.Enabled = Enabling
        GridViewUserRole.OptionsBehavior.Editable = Enabling
        GridUserRole.EmbeddedNavigator.Enabled = Enabling
        GridUserRole.Enabled = Enabling
        ChkEncrypted.Enabled = Enabling
        txtBox_id.Enabled = Enabling
        txtCustomers_id.Enabled = Enabling
    End Sub
    Private Sub EnablingKeyFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingkeyFields
        'ToBeChecked ***
    End Sub
    Private Sub StartPrintForm() Handles MyBase.EventPrintForm
        '    BKReport.PrintForm(CurrentReportID, New DataRow() {CType(Me.BindingContext(MainDataSet, TableName).Current, DataRowView).Row}, _
        '        New DataTable() {DsUsers1.Tables("securityusermenu"), DsUsers1.Tables("securityuser_role")})
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        If FolderBrowserDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            'Dim fi As New IO.FileInfo(FolderBrowserDialog1.SelectedPath)
            txtUserDocPath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

End Class
