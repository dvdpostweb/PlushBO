Imports BizzLib.clsGlobal.ObjectState

Public Class frmEDoc_Load
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents objDS As BizzLib.dsEDoc
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

    Friend WithEvents cmbType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPath As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbCategory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents chkAutoScan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtFileToSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblFileToSearch As System.Windows.Forms.Label
    Friend WithEvents btnLoadFileList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents lstFiles As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lstFiles = New System.Windows.Forms.CheckedListBox
        Me.btnLoadFileList = New DevExpress.XtraEditors.SimpleButton
        Me.txtFileToSearch = New System.Windows.Forms.TextBox
        Me.lblFileToSearch = New System.Windows.Forms.Label
        Me.chkAutoScan = New DevExpress.XtraEditors.CheckEdit
        Me.cmbCategory = New DevExpress.XtraEditors.LookUpEdit
        Me.objDS = New BizzLib.dsEDoc
        Me.btnBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblPath = New System.Windows.Forms.Label
        Me.lblCategory = New System.Windows.Forms.Label
        Me.lblType = New System.Windows.Forms.Label
        Me.cmbType = New DevExpress.XtraEditors.LookUpEdit
        Me.btnImport = New DevExpress.XtraEditors.SimpleButton
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAutoScan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstFiles
        '
        Me.lstFiles.CheckOnClick = True
        Me.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstFiles.Location = New System.Drawing.Point(0, 216)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.Size = New System.Drawing.Size(744, 259)
        Me.lstFiles.TabIndex = 42
        '
        'btnLoadFileList
        '
        Me.btnLoadFileList.Location = New System.Drawing.Point(472, 48)
        Me.btnLoadFileList.Name = "btnLoadFileList"
        Me.btnLoadFileList.Size = New System.Drawing.Size(120, 23)
        Me.btnLoadFileList.TabIndex = 46
        Me.btnLoadFileList.Text = "Load File List"
        '
        'txtFileToSearch
        '
        Me.txtFileToSearch.Location = New System.Drawing.Point(120, 40)
        Me.txtFileToSearch.Name = "txtFileToSearch"
        Me.txtFileToSearch.Size = New System.Drawing.Size(344, 20)
        Me.txtFileToSearch.TabIndex = 45
        Me.txtFileToSearch.Text = "*"
        '
        'lblFileToSearch
        '
        Me.lblFileToSearch.Location = New System.Drawing.Point(16, 40)
        Me.lblFileToSearch.Name = "lblFileToSearch"
        Me.lblFileToSearch.TabIndex = 44
        Me.lblFileToSearch.Text = "Description"
        '
        'chkAutoScan
        '
        Me.chkAutoScan.Location = New System.Drawing.Point(16, 152)
        Me.chkAutoScan.Name = "chkAutoScan"
        '
        'chkAutoScan.Properties
        '
        Me.chkAutoScan.Properties.Caption = "Auto Scan"
        Me.chkAutoScan.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkAutoScan.Size = New System.Drawing.Size(120, 19)
        Me.chkAutoScan.TabIndex = 43
        '
        'cmbCategory
        '
        Me.cmbCategory.Location = New System.Drawing.Point(120, 104)
        Me.cmbCategory.Name = "cmbCategory"
        '
        'cmbCategory.Properties
        '
        Me.cmbCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCategory.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeValue", "CodeValue", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeDesc", "CodeDesc", 130, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbCategory.Properties.DataSource = Me.objDS.EDocCategoryView1
        Me.cmbCategory.Properties.DisplayMember = "CodeValue"
        Me.cmbCategory.Properties.NullText = ""
        Me.cmbCategory.Properties.PopupWidth = 200
        Me.cmbCategory.Properties.ValueMember = "CodeValue"
        Me.cmbCategory.Size = New System.Drawing.Size(168, 20)
        Me.cmbCategory.TabIndex = 42
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsEDoc"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(472, 16)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(120, 24)
        Me.btnBrowse.TabIndex = 41
        Me.btnBrowse.Text = "Browse"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(120, 72)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(344, 20)
        Me.txtDescription.TabIndex = 31
        Me.txtDescription.Text = ""
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(120, 16)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(344, 20)
        Me.txtPath.TabIndex = 4
        Me.txtPath.Text = ""
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(16, 72)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.TabIndex = 30
        Me.lblDescription.Text = "Description"
        '
        'lblPath
        '
        Me.lblPath.Location = New System.Drawing.Point(16, 16)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.TabIndex = 40
        Me.lblPath.Text = "Path"
        '
        'lblCategory
        '
        Me.lblCategory.Location = New System.Drawing.Point(16, 104)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.TabIndex = 27
        Me.lblCategory.Text = "Category"
        '
        'lblType
        '
        Me.lblType.Location = New System.Drawing.Point(16, 128)
        Me.lblType.Name = "lblType"
        Me.lblType.TabIndex = 13
        Me.lblType.Text = "Doc. Type"
        '
        'cmbType
        '
        Me.cmbType.Location = New System.Drawing.Point(120, 128)
        Me.cmbType.Name = "cmbType"
        '
        'cmbType.Properties
        '
        Me.cmbType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeValue", "CodeValue", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeDesc", "CodeDesc", 130, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbType.Properties.DataSource = Me.objDS.EDocTypeView1
        Me.cmbType.Properties.DisplayMember = "CodeValue"
        Me.cmbType.Properties.NullText = ""
        Me.cmbType.Properties.PopupWidth = 200
        Me.cmbType.Properties.ValueMember = "CodeValue"
        Me.cmbType.Size = New System.Drawing.Size(168, 20)
        Me.cmbType.TabIndex = 37
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(472, 80)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(120, 24)
        Me.btnImport.TabIndex = 35
        Me.btnImport.Text = "Import Selected Files"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CashBankAccount", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BankAccountID", "BankAccountID"), New System.Data.Common.DataColumnMapping("BankID", "BankID"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("CurrCode", "CurrCode"), New System.Data.Common.DataColumnMapping("Category", "Category"), New System.Data.Common.DataColumnMapping("IBAN", "IBAN"), New System.Data.Common.DataColumnMapping("UserType", "UserType")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM CashBankAccount WHERE (BankAccountID = ?) AND (BankID = ? OR ? IS NUL" & _
        "L AND BankID IS NULL) AND (Category = ? OR ? IS NULL AND Category IS NULL) AND (" & _
        "CurrCode = ? OR ? IS NULL AND CurrCode IS NULL) AND (Description = ? OR ? IS NUL" & _
        "L AND Description IS NULL) AND (IBAN = ? OR ? IS NULL AND IBAN IS NULL) AND (Nam" & _
        "e = ? OR ? IS NULL AND Name IS NULL) AND (UserType = ? OR ? IS NULL AND UserType" & _
        " IS NULL)"
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BankAccountID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BankAccountID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BankID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BankID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BankID1", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BankID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Category", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Category", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Category1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Category", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CurrCode", System.Data.OleDb.OleDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CurrCode1", System.Data.OleDb.OleDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IBAN", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IBAN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IBAN1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IBAN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserType", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserType1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserType", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO CashBankAccount(BankAccountID, BankID, Name, Description, CurrCode, C" & _
        "ategory, IBAN, UserType) VALUES (?, ?, ?, ?, ?, ?, ?, ?); SELECT BankAccountID, " & _
        "BankID, Name, Description, CurrCode, Category, IBAN, UserType FROM CashBankAccou" & _
        "nt WHERE (BankAccountID = ?)"
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BankAccountID", System.Data.OleDb.OleDbType.Integer, 4, "BankAccountID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BankID", System.Data.OleDb.OleDbType.Integer, 4, "BankID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarChar, 50, "Name"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarChar, 150, "Description"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CurrCode", System.Data.OleDb.OleDbType.VarChar, 3, "CurrCode"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Category", System.Data.OleDb.OleDbType.VarChar, 50, "Category"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("IBAN", System.Data.OleDb.OleDbType.VarChar, 50, "IBAN"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserType", System.Data.OleDb.OleDbType.VarChar, 50, "UserType"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Select_BankAccountID", System.Data.OleDb.OleDbType.Integer, 4, "BankAccountID"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT BankAccountID, BankID, Name, Description, CurrCode, Category, IBAN, UserTy" & _
        "pe FROM CashBankAccount WHERE (SystemType = 0)"
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE CashBankAccount SET BankAccountID = ?, BankID = ?, Name = ?, Description =" & _
        " ?, CurrCode = ?, Category = ?, IBAN = ?, UserType = ? WHERE (BankAccountID = ?)" & _
        " AND (BankID = ? OR ? IS NULL AND BankID IS NULL) AND (Category = ? OR ? IS NULL" & _
        " AND Category IS NULL) AND (CurrCode = ? OR ? IS NULL AND CurrCode IS NULL) AND " & _
        "(Description = ? OR ? IS NULL AND Description IS NULL) AND (IBAN = ? OR ? IS NUL" & _
        "L AND IBAN IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (UserType =" & _
        " ? OR ? IS NULL AND UserType IS NULL); SELECT BankAccountID, BankID, Name, Descr" & _
        "iption, CurrCode, Category, IBAN, UserType FROM CashBankAccount WHERE (BankAccou" & _
        "ntID = ?)"
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BankAccountID", System.Data.OleDb.OleDbType.Integer, 4, "BankAccountID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BankID", System.Data.OleDb.OleDbType.Integer, 4, "BankID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarChar, 50, "Name"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarChar, 150, "Description"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CurrCode", System.Data.OleDb.OleDbType.VarChar, 3, "CurrCode"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Category", System.Data.OleDb.OleDbType.VarChar, 50, "Category"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("IBAN", System.Data.OleDb.OleDbType.VarChar, 50, "IBAN"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserType", System.Data.OleDb.OleDbType.VarChar, 50, "UserType"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BankAccountID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BankAccountID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BankID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BankID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BankID1", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BankID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Category", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Category", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Category1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Category", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CurrCode", System.Data.OleDb.OleDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CurrCode1", System.Data.OleDb.OleDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IBAN", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IBAN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IBAN1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IBAN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserType", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserType1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Select_BankAccountID", System.Data.OleDb.OleDbType.Integer, 4, "BankAccountID"))
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "PDF Files (*.PDF)|*.pdf|All Files (*.*)|*.*"
        Me.OpenFileDialog1.InitialDirectory = "C:\"
        Me.OpenFileDialog1.RestoreDirectory = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtDescription)
        Me.PanelControl1.Controls.Add(Me.txtPath)
        Me.PanelControl1.Controls.Add(Me.cmbType)
        Me.PanelControl1.Controls.Add(Me.btnLoadFileList)
        Me.PanelControl1.Controls.Add(Me.lblPath)
        Me.PanelControl1.Controls.Add(Me.lblDescription)
        Me.PanelControl1.Controls.Add(Me.txtFileToSearch)
        Me.PanelControl1.Controls.Add(Me.lblCategory)
        Me.PanelControl1.Controls.Add(Me.lblFileToSearch)
        Me.PanelControl1.Controls.Add(Me.lblType)
        Me.PanelControl1.Controls.Add(Me.chkAutoScan)
        Me.PanelControl1.Controls.Add(Me.cmbCategory)
        Me.PanelControl1.Controls.Add(Me.btnBrowse)
        Me.PanelControl1.Controls.Add(Me.btnImport)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(744, 216)
        Me.PanelControl1.TabIndex = 34
        Me.PanelControl1.Text = "PanelControl1"
        '
        'frmEDoc_Load
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(744, 478)
        Me.Controls.Add(Me.lstFiles)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmEDoc_Load"
        Me.Text = "##"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        Me.Controls.SetChildIndex(Me.lstFiles, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAutoScan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim KeyDataSet As String = "BizzLib.dsEDoc" 'The Dataset used 
    Dim MainData As clsEDoc.clsEDoc_Doc

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _Row As DataRow
        Try
            'SetUp of Variables
            'If KeyFieldName & "" = "" Then KeyFieldName = "Name"
            'If IDField & "" = "" Then IDField = "EDocID"
            'If TableName = "" Then TableName = "EDoc"
            'MainDataSet = objDS
            'ToolBar1.Tools("Banner").SharedProps.Caption = BKGlobal.GetFormBanner(Me.Tag)
            'ToolBar1.Tools("Banner").SharedProps.Visible = SessionInfo.BannerVisible

            HelpProvider1.HelpNamespace = ".\Help\" & SessionInfo.UserLang & "\BizzKeys.chm"
            'ApplyDefaultFilter(Me.Tag, IsFiltered, FilterTxt, StatusBar1.Panels(1))

            Me.LoadBKComboSet()
            'Me.LoadDataSet()
            'BKGlobal.LoadAssociatedMenu(Me.Tag, PopMenuAssociatedTasks, Me)
            'If OpenType = "NEW" Then
            '    NewRecord(sender, e)
            'End If
            'If OpenType = "EDIT" Then
            '    'Retreiving the GLAccount Code for the Associated ID
            '    '_Row = objDs.Tables(TableName).Rows.Find(New Object() {KeyID})
            '    If KeyValue <> "" Then 'Not IsNothing(_Row) Then
            '        'Find the Record by the ID and Getting the Associated Name
            '        Me.objDS.Tables(TableName).DefaultView.Sort = IDField
            '        Dim _Name As String = Me.objDS.Tables(TableName).DefaultView(Me.objDS.Tables(TableName).DefaultView.Find(New Object() {KeyValue})).Item(KeyFieldName)
            '        'Now Finding the record by the name, because this is the one used in the ORDER BY in the LoadDataset
            '        Me.objDS.Tables(TableName).DefaultView.Sort = KeyFieldName
            '        Me.BindingContext(objDS, TableName).Position = Me.objDS.Tables(TableName).DefaultView.Find(New Object() {_Name})
            '        PositionChanged(sender, e)
            '        EditRecord(sender, e)
            '    Else
            '        OpenType = "BROWSE"
            '        Exit Sub
            '    End If
            'End If
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        'PositionChanged(sender, e)
    End Sub

    Public Sub LoadBKComboSet()
        Try
            GetCombo(objDS, "EDocTypeView1", "CodeValue", "SELECT * FROM EDocTypeView1")
            GetCombo(objDS, "EDocCategoryView1", "CodeValue", "SELECT * FROM EDocCategoryView1")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        'If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
        '    Dim fi As New IO.FileInfo(OpenFileDialog1.FileName)
        '    txtName.Text = fi.Name
        '    txtPath.Text = fi.DirectoryName
        'End If
        If FolderBrowserDialog1.ShowDialog(Me) = DialogResult.OK Then
            txtPath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        'SaveChanges(sender, e)
        'If CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item(IDField) & "" <> "" Then
        '    MainData.Scan(CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item(IDField))
        'End If
        Dim _FileToImport As String
        Dim _FileInfo As System.IO.FileInfo
        Dim _EDocRow As DataRow
        'Check type edoctype and Edoc category are selected
        If cmbType.EditValue & "" = "" Then
            MsgBox("Default Doc Type is not selected.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If cmbCategory.EditValue & "" = "" Then
            MsgBox("Default Doc Category is not selected.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        MainData = New clsEDoc.clsEDoc_Doc(SessionInfo, objDS, "BizzLib.dsEDoc", "EDoc", "", "")
        MainData.TableOfData.DefaultView.Sort = "EDocPath, Name"
        For Each _FileToImport In lstFiles.CheckedItems
            If Not MainData.Exists(txtPath.Text, _FileToImport) Then
                'MsgBox(_FileToImport & " is a new entry ")
                _EDocRow = MainData.TableOfData.NewRow()
                _EDocRow.Item("EDocID") = BKGlobal.GetNextID("EDocID")
                _EDocRow.Item("Name") = _FileToImport
                _EDocRow.Item("Description") = txtDescription.Text & ""
                _EDocRow.Item("EDocPath") = txtPath.Text & ""
                _EDocRow.Item("EDocType") = cmbType.EditValue
                _EDocRow.Item("EDocCategory") = cmbCategory.EditValue
                MainData.TableOfData.Rows.Add(_EDocRow)
                If chkAutoScan.Checked Then
                    MainData.Scan(_EDocRow.Item("EDocID"))
                End If
                MainData.Save()
                'Dim _CurrentIdx = lstFiles.FindStringExact(_FileToImport)
            Else
                'MsgBox(_FileToImport & " Already Exist ")
            End If
        Next
    End Sub

    Private Sub btnLoadFileList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadFileList.Click
        Dim _Folder As System.IO.Directory
        Dim _FileInfo As System.IO.FileInfo
        Dim _FilesNames() As String
        Dim _FileName As String
        If txtPath.Text & "" = "" Then
            MsgBox("No path has been specified", MsgBoxStyle.Critical)
            Exit Sub
        End If
        lstFiles.Items.Clear()
        _FilesNames = _Folder.GetFiles(txtPath.Text, txtFileToSearch.Text & ".pdf")
        For Each _FileName In _FilesNames
            _FileInfo = New System.IO.FileInfo(_FileName)
            lstFiles.Items.Add(_FileInfo.Name, True)
        Next
    End Sub
End Class
