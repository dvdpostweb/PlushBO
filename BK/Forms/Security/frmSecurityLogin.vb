Public Class frmSecurityLogin
    Inherits BizzLib.frmBKForm

    Dim _typeEnv As String


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
    Friend WithEvents btnEnter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLeave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtPassWord As System.Windows.Forms.TextBox
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents cmbRoles As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents objDS As System.Data.DataSet
    Friend WithEvents OleDbDataAdapter_Roles As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents btnDetail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OleDbDataAdapter_User As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents CheckDBTEst As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSecurityLogin))
        Me.txtLogin = New System.Windows.Forms.TextBox
        Me.lblLogin = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.txtPassWord = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CheckDBTEst = New System.Windows.Forms.CheckBox
        Me.btnDetail = New DevExpress.XtraEditors.SimpleButton
        Me.cmbRoles = New DevExpress.XtraEditors.LookUpEdit
        Me.btnLeave = New DevExpress.XtraEditors.SimpleButton
        Me.btnEnter = New DevExpress.XtraEditors.SimpleButton
        Me.lblRole = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbDataAdapter_Roles = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.objDS = New System.Data.DataSet
        Me.OleDbDataAdapter_User = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.cmbRoles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLogin
        '
        Me.HelpProvider1.SetHelpKeyword(Me.txtLogin, "Login")
        Me.HelpProvider1.SetHelpString(Me.txtLogin, "Your User Login")
        Me.txtLogin.Location = New System.Drawing.Point(200, 20)
        Me.txtLogin.Name = "txtLogin"
        Me.HelpProvider1.SetShowHelp(Me.txtLogin, True)
        Me.txtLogin.Size = New System.Drawing.Size(100, 20)
        Me.txtLogin.TabIndex = 0
        '
        'lblLogin
        '
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(128, 24)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(64, 16)
        Me.lblLogin.TabIndex = 2
        Me.lblLogin.Text = "Login"
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(128, 48)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 16)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'txtPassWord
        '
        Me.HelpProvider1.SetHelpKeyword(Me.txtPassWord, "Login")
        Me.HelpProvider1.SetHelpString(Me.txtPassWord, "Your Password")
        Me.txtPassWord.Location = New System.Drawing.Point(200, 44)
        Me.txtPassWord.Name = "txtPassWord"
        Me.txtPassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.HelpProvider1.SetShowHelp(Me.txtPassWord, True)
        Me.txtPassWord.Size = New System.Drawing.Size(100, 20)
        Me.txtPassWord.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.CheckDBTEst)
        Me.Panel1.Controls.Add(Me.btnDetail)
        Me.Panel1.Controls.Add(Me.cmbRoles)
        Me.Panel1.Controls.Add(Me.btnLeave)
        Me.Panel1.Controls.Add(Me.btnEnter)
        Me.Panel1.Controls.Add(Me.lblRole)
        Me.Panel1.Controls.Add(Me.txtLogin)
        Me.Panel1.Controls.Add(Me.txtPassWord)
        Me.Panel1.Controls.Add(Me.lblLogin)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 249)
        Me.Panel1.TabIndex = 7
        '
        'CheckDBTEst
        '
        Me.CheckDBTEst.AutoSize = True
        Me.CheckDBTEst.BackColor = System.Drawing.SystemColors.Window
        Me.CheckDBTEst.Location = New System.Drawing.Point(40, 151)
        Me.CheckDBTEst.Name = "CheckDBTEst"
        Me.CheckDBTEst.Size = New System.Drawing.Size(62, 17)
        Me.CheckDBTEst.TabIndex = 10
        Me.CheckDBTEst.Text = "DBTest"
        Me.CheckDBTEst.UseVisualStyleBackColor = False
        '
        'btnDetail
        '
        Me.btnDetail.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDetail.Appearance.Options.UseBackColor = True
        Me.HelpProvider1.SetHelpKeyword(Me.btnDetail, "Login")
        Me.HelpProvider1.SetHelpString(Me.btnDetail, "Show / Hide Role Selctor")
        Me.btnDetail.Image = CType(resources.GetObject("btnDetail.Image"), System.Drawing.Image)
        Me.btnDetail.Location = New System.Drawing.Point(40, 208)
        Me.btnDetail.Name = "btnDetail"
        Me.HelpProvider1.SetShowHelp(Me.btnDetail, True)
        Me.btnDetail.Size = New System.Drawing.Size(88, 24)
        Me.btnDetail.TabIndex = 5
        Me.btnDetail.Text = "Detail"
        '
        'cmbRoles
        '
        Me.HelpProvider1.SetHelpString(Me.cmbRoles, "The Role you want to use for this session.")
        Me.cmbRoles.Location = New System.Drawing.Point(200, 72)
        Me.cmbRoles.Name = "cmbRoles"
        Me.cmbRoles.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRoles.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleName", "Role", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleDescription", "Description", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EntityName", "Entity", 48, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbRoles.Properties.DisplayMember = "RoleName"
        Me.cmbRoles.Properties.NullText = ""
        Me.cmbRoles.Properties.ValueMember = "RoleID"
        Me.HelpProvider1.SetShowHelp(Me.cmbRoles, True)
        Me.cmbRoles.Size = New System.Drawing.Size(112, 20)
        Me.cmbRoles.TabIndex = 2
        Me.cmbRoles.Visible = False
        '
        'btnLeave
        '
        Me.btnLeave.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.btnLeave.Appearance.Options.UseBackColor = True
        Me.btnLeave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProvider1.SetHelpKeyword(Me.btnLeave, "Login")
        Me.HelpProvider1.SetHelpString(Me.btnLeave, "Leave the application")
        Me.btnLeave.Image = CType(resources.GetObject("btnLeave.Image"), System.Drawing.Image)
        Me.btnLeave.Location = New System.Drawing.Point(224, 208)
        Me.btnLeave.Name = "btnLeave"
        Me.HelpProvider1.SetShowHelp(Me.btnLeave, True)
        Me.btnLeave.Size = New System.Drawing.Size(88, 24)
        Me.btnLeave.TabIndex = 4
        Me.btnLeave.Text = "Leave"
        '
        'btnEnter
        '
        Me.btnEnter.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEnter.Appearance.Options.UseBackColor = True
        Me.HelpProvider1.SetHelpKeyword(Me.btnEnter, "Login")
        Me.HelpProvider1.SetHelpString(Me.btnEnter, "Start a session")
        Me.btnEnter.Image = CType(resources.GetObject("btnEnter.Image"), System.Drawing.Image)
        Me.btnEnter.Location = New System.Drawing.Point(136, 208)
        Me.btnEnter.Name = "btnEnter"
        Me.HelpProvider1.SetShowHelp(Me.btnEnter, True)
        Me.btnEnter.Size = New System.Drawing.Size(80, 24)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "Enter"
        '
        'lblRole
        '
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.Location = New System.Drawing.Point(128, 75)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(64, 16)
        Me.lblRole.TabIndex = 8
        Me.lblRole.Text = "Role"
        Me.lblRole.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(437, 249)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = resources.GetString("OleDbConnection1.ConnectionString")
        '
        'OleDbDataAdapter_Roles
        '
        Me.OleDbDataAdapter_Roles.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter_Roles.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "securityrole", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RoleID", "RoleID"), New System.Data.Common.DataColumnMapping("EntityID", "EntityID"), New System.Data.Common.DataColumnMapping("RoleName", "RoleName"), New System.Data.Common.DataColumnMapping("RoleDescription", "RoleDescription"), New System.Data.Common.DataColumnMapping("UserId", "UserId"), New System.Data.Common.DataColumnMapping("EntityName", "EntityName"), New System.Data.Common.DataColumnMapping("EntityDescription", "EntityDescription")})})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = resources.GetString("OleDbSelectCommand1.CommandText")
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'objDS
        '
        Me.objDS.DataSetName = "NewDataSet"
        Me.objDS.Locale = New System.Globalization.CultureInfo("fr-BE")
        '
        'OleDbDataAdapter_User
        '
        Me.OleDbDataAdapter_User.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter_User.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "securityuser", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("UserID", "UserID"), New System.Data.Common.DataColumnMapping("FullName", "FullName"), New System.Data.Common.DataColumnMapping("Login", "Login"), New System.Data.Common.DataColumnMapping("PassWord", "PassWord"), New System.Data.Common.DataColumnMapping("ShortCutID", "ShortCutID"), New System.Data.Common.DataColumnMapping("Lang", "Lang"), New System.Data.Common.DataColumnMapping("DefaultRoleID", "DefaultRoleID")})})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT * FROM securityuser"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'frmSecurityLogin
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnLeave
        Me.ClientSize = New System.Drawing.Size(437, 275)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpKeyword(Me, "Login")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Misc_Bar2 = Nothing
        Me.Name = "frmSecurityLogin"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmbRoles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim SQLTxtRole, SQLTxtUser As String
    Dim OK As Boolean = False
    Private Sub btnLeave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeave.Click
        End
    End Sub
    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If OKToLogin() = True Then
            OK = True
            Me.Hide()
        End If
    End Sub
    Private Sub loadRoles()
        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.ClsCustomersData.GetSelectRolesUser()
        dt = PlushData.clsConnection.FillDataSet(sql)


        For Each dr As DataRow In dt.Rows
            PlushData.clsSession.Lst_role.Add(dr("RoleID"))
        Next

    End Sub
    Private Sub SelectEnv()

        Dim connectionString As String

        If Me.CheckDBTEst.Checked = True Then
            '   Dim roles As Integer = cmbRoles.EditValue
            '   Dim userId As Integer = objDS.Tables("User").Rows(0)("UserID")

            ' If roles = 1 Then
            _typeEnv = "test"
            MsgBox("you are on the dbTest")
            PlushData.clsSession.isEnvTest = True
            'Else
            '    MsgBox("you cannot use DBtest, you will be to redirect on the DB dvdpost_be_prod")
            '    Me.CheckDBTEst.Checked = False
            ' End If
        Else
            _typeEnv = "prod"
            PlushData.clsSession.isEnvTest = False
        End If

        Dim key As String

        key = PlushData.clsConnection.GetConnectionString(_typeEnv, PlushData.clsConnection.typeAccessDb.WRITE)
        connectionString = Configuration.ConfigurationManager.ConnectionStrings(key).ConnectionString
        PlushData.clsConnection.typeEnv = _typeEnv
        'SessionInfo = New BizzLib.clsSessionInfo(objDS.Tables("User").Rows(0)("UserID"), cmbRoles.EditValue, _
        '            _typeEnv, connectionString, SessionInfo.DBConnType)

        '' DvdPostData.Session.MySession = mysession
        'SessionInfo.UserDocPath = _typeEnv

    End Sub
    Private Function OKToLogin() As Boolean


        SelectEnv()
        LoadDataUser()

        'Check Login PassWord
        If objDS.Tables("User").Rows.Count = 0 Then
            '2: Invalid Login / Password
            MsgBox("no exist user ", MsgBoxStyle.Critical)
            Return False
        Else
            If String.Compare(objDS.Tables("User").Rows(0)("PassWord"), PlushBuziness.ClsCustomers.MD5Encrypt(txtPassWord.Text), False) <> 0 Then
                '2: Invalid Login / Password
                MsgBox("Error Login ", MsgBoxStyle.Critical)
                Return False
            End If
        End If

        PlushData.clsSession.user_id = objDS.Tables("User").Rows(0)("UserID")

        PlushData.clsSession.FullName = objDS.Tables("User").Rows(0)("FullName")
        PlushData.clsSession.isBatch = False

        If Not objDS.Tables("User").Rows(0)("box_id") Is DBNull.Value Then PlushData.clsSession.box_id = objDS.Tables("User").Rows(0)("box_id")
        loadRoles()



        Return True
    End Function

    Private Sub frmSecurityLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SQLTxtRole = OleDbDataAdapter_Roles.SelectCommand.CommandText
        SQLTxtUser = OleDbDataAdapter_User.SelectCommand.CommandText
        objDS.Tables.Add("Role")
        objDS.Tables.Add("User")

    End Sub
    Public Sub LoadDataRoles(Optional ByVal UserID As Integer = -1)
        Try
            Dim sql As String
            objDS.Tables("Role").Clear()
            'Only Appropriate UserID
            sql = SQLTxtRole & " WHERE UserID = " & UserID & " "
            'Attempt to fill the temporary dataset.
            PlushData.clsConnection.FillDataSet(objDS.Tables("Role"), sql)
            objDS.Tables("Role").PrimaryKey = New DataColumn() {objDS.Tables("Role").Columns("RoleID")}
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
    End Sub
    Private Sub LoadDataUser()
        Try
            Dim sql As String
            objDS.Tables("User").Clear()
            'Only Appropriate Entity
            sql = SQLTxtUser & " WHERE Login = '" & txtLogin.Text & "' "
            'Attempt to fill the temporary dataset.
            PlushData.clsConnection.FillDataSet(objDS.Tables("User"), sql)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
    End Sub
    Private Sub frmSecurityLogin_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If OK = False Then
            End
        End If
    End Sub
    Private Sub txtLogin_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLogin.Leave
       
    End Sub

    Private Sub btnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetail.Click
        ToggleDetail()
    End Sub
    Private Sub ShowDetail()
        lblRole.Visible = True
        cmbRoles.Visible = True
    End Sub
    Private Sub HideDetail()
        lblRole.Visible = False
        cmbRoles.Visible = False
    End Sub
    Private Sub ToggleDetail()
        lblRole.Visible = Not lblRole.Visible
        cmbRoles.Visible = Not cmbRoles.Visible
    End Sub
End Class
