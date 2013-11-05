Imports BizzLib.clsGlobal.ObjectState

Public Class frmEDoc_Maintenance
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
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnScan As DevExpress.XtraEditors.SimpleButton

    Friend WithEvents cmbType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPath As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colEDocID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colKeyWord As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents cmbCategory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnView1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Public WithEvents TabEdoc As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.objDS = New BizzLib.dsEDoc
        Me.GridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colEDocID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colKeyWord = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.btnView1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmbCategory = New DevExpress.XtraEditors.LookUpEdit
        Me.btnBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblPath = New System.Windows.Forms.Label
        Me.lblCategory = New System.Windows.Forms.Label
        Me.lblType = New System.Windows.Forms.Label
        Me.cmbType = New DevExpress.XtraEditors.LookUpEdit
        Me.lblID = New System.Windows.Forms.Label
        Me.btnScan = New DevExpress.XtraEditors.SimpleButton
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.TabEdoc = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.TabEdoc.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 520)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(888, 22)
        '
        'PopMenuSave
        '
        '
        'PopMenuDelete
        '
        '
        'PopMenuEdit
        '
        '
        'PopMenuNew
        '
        '
        'PopMenuUndo
        '
        '
        'Grid1
        '
        Me.Grid1.DataSource = Me.objDS.EDocKeyword
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'Grid1.EmbeddedNavigator
        '
        Me.Grid1.EmbeddedNavigator.Enabled = False
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 168)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(879, 269)
        Me.Grid1.TabIndex = 42
        Me.Grid1.UseEmbeddedNavigator = True
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsEDoc"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GridView1
        '
        Me.GridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colEDocID, Me.colKeyWord, Me.colType})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.GroupPanelText = "..."
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowBands = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colEDocID)
        Me.GridBand1.Columns.Add(Me.colKeyWord)
        Me.GridBand1.Columns.Add(Me.colType)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 243
        '
        'colEDocID
        '
        Me.colEDocID.Caption = "EDocID"
        Me.colEDocID.FieldName = "EDocID"
        Me.colEDocID.Name = "colEDocID"
        Me.colEDocID.Width = 487
        '
        'colKeyWord
        '
        Me.colKeyWord.Caption = "KeyWord"
        Me.colKeyWord.FieldName = "KeyWord"
        Me.colKeyWord.Name = "colKeyWord"
        Me.colKeyWord.Visible = True
        Me.colKeyWord.Width = 243
        '
        'colType
        '
        Me.colType.Caption = "Type"
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Width = 371
        '
        'btnView1
        '
        Me.btnView1.Location = New System.Drawing.Point(472, 64)
        Me.btnView1.Name = "btnView1"
        Me.btnView1.Size = New System.Drawing.Size(80, 24)
        Me.btnView1.TabIndex = 43
        Me.btnView1.Text = "View"
        '
        'cmbCategory
        '
        Me.cmbCategory.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "EDoc.EDocCategory"))
        Me.cmbCategory.Location = New System.Drawing.Point(120, 120)
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
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(472, 32)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(80, 24)
        Me.btnBrowse.TabIndex = 41
        Me.btnBrowse.Text = "Browse"
        '
        'txtDescription
        '
        Me.txtDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "EDoc.Description"))
        Me.txtDescription.Enabled = False
        Me.txtDescription.Location = New System.Drawing.Point(120, 88)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(344, 20)
        Me.txtDescription.TabIndex = 31
        Me.txtDescription.Text = ""
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "EDoc.EDocID"))
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(120, 8)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(168, 20)
        Me.txtID.TabIndex = 28
        Me.txtID.Text = ""
        '
        'txtPath
        '
        Me.txtPath.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "EDoc.EDocPath"))
        Me.txtPath.Enabled = False
        Me.txtPath.Location = New System.Drawing.Point(120, 64)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(344, 20)
        Me.txtPath.TabIndex = 4
        Me.txtPath.Text = ""
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "EDoc.Name"))
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(120, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(344, 20)
        Me.txtName.TabIndex = 4
        Me.txtName.Text = ""
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(16, 32)
        Me.lblName.Name = "lblName"
        Me.lblName.TabIndex = 39
        Me.lblName.Text = "File Name"
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(16, 88)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.TabIndex = 30
        Me.lblDescription.Text = "Description"
        '
        'lblPath
        '
        Me.lblPath.Location = New System.Drawing.Point(16, 64)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.TabIndex = 40
        Me.lblPath.Text = "Path"
        '
        'lblCategory
        '
        Me.lblCategory.Location = New System.Drawing.Point(16, 120)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.TabIndex = 27
        Me.lblCategory.Text = "Category"
        '
        'lblType
        '
        Me.lblType.Location = New System.Drawing.Point(16, 144)
        Me.lblType.Name = "lblType"
        Me.lblType.TabIndex = 13
        Me.lblType.Text = "Doc. Type"
        '
        'cmbType
        '
        Me.cmbType.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "EDoc.EDocType"))
        Me.cmbType.Location = New System.Drawing.Point(120, 144)
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
        'lblID
        '
        Me.lblID.Location = New System.Drawing.Point(16, 8)
        Me.lblID.Name = "lblID"
        Me.lblID.TabIndex = 38
        Me.lblID.Text = "ID"
        '
        'btnScan
        '
        Me.btnScan.Location = New System.Drawing.Point(472, 88)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(80, 24)
        Me.btnScan.TabIndex = 35
        Me.btnScan.Text = "Scan"
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
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 53)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.TabEdoc
        Me.XtraTabControl1.Size = New System.Drawing.Size(888, 467)
        Me.XtraTabControl1.TabIndex = 35
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabEdoc})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'TabEdoc
        '
        Me.TabEdoc.Controls.Add(Me.Grid1)
        Me.TabEdoc.Controls.Add(Me.PanelControl1)
        Me.TabEdoc.Name = "TabEdoc"
        Me.TabEdoc.Size = New System.Drawing.Size(879, 437)
        Me.TabEdoc.Text = "EDoc"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblDescription)
        Me.PanelControl1.Controls.Add(Me.lblPath)
        Me.PanelControl1.Controls.Add(Me.lblCategory)
        Me.PanelControl1.Controls.Add(Me.lblType)
        Me.PanelControl1.Controls.Add(Me.cmbType)
        Me.PanelControl1.Controls.Add(Me.lblID)
        Me.PanelControl1.Controls.Add(Me.btnBrowse)
        Me.PanelControl1.Controls.Add(Me.txtPath)
        Me.PanelControl1.Controls.Add(Me.txtDescription)
        Me.PanelControl1.Controls.Add(Me.txtID)
        Me.PanelControl1.Controls.Add(Me.cmbCategory)
        Me.PanelControl1.Controls.Add(Me.btnView1)
        Me.PanelControl1.Controls.Add(Me.txtName)
        Me.PanelControl1.Controls.Add(Me.btnScan)
        Me.PanelControl1.Controls.Add(Me.lblName)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(879, 168)
        Me.PanelControl1.TabIndex = 0
        Me.PanelControl1.Text = "PanelControl1"
        '
        'frmEDoc_Maintenance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(888, 542)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmEDoc_Maintenance"
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.TabEdoc.ResumeLayout(False)
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
            If KeyFieldName & "" = "" Then KeyFieldName = "Name"
            If IDField & "" = "" Then IDField = "EDocID"
            If TableName = "" Then TableName = "EDoc"
            MainDataSet = objDS

            HelpProvider1.HelpNamespace = ".\Help\" & SessionInfo.UserLang & "\BizzKeys.chm"
            BKFilter.ApplyDefaultFilter(Me.Tag, IsFiltered, FilterTxt, StatusBar1.Panels(1))

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
                    'Find the Record by the ID and Getting the Associated Name
                    Me.objDS.Tables(TableName).DefaultView.Sort = IDField
                    Dim _Name As String = Me.objDS.Tables(TableName).DefaultView(Me.objDS.Tables(TableName).DefaultView.Find(New Object() {KeyValue})).Item(KeyFieldName)
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

    Public Sub NewRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuNew.Click, MyBase.EventNewRecord
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
            CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item(IDField) = BKGlobal.GetNextID("EDocID")
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        PositionChanged(Sender, e)
    End Sub
    Public Sub EditRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuEdit.Click, MyBase.EventEditRecord
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
    Public Sub DeleteRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuDelete.Click, MyBase.EventDeleteRecord
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            'Msg = 1 = Confirm Delete
            If MsgBox(BKGlobal.GetMsg(1, SessionInfo.UserLang), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    BKGlobal.DeleteTranslations("EDoc.EDocID", CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item(IDField) & "")
                    BKGlobal.DeleteComments(SessionInfo.EntityID, txtName.Text)
                    'Deleting the EDoc
                    MainData.DeleteByID(CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item(IDField))
                    EnablingAll(False)
                    LoadDataSet()
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
    Public Sub UndoChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuUndo.Click, MyBase.EventUndoChanges
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
    Public Sub SaveChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuSave.Click, MyBase.EventSaveChanges
        Dim _ID As Integer
        Try
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

    Public Sub UpdateDataSet() Handles MyBase.EventUpdateDataset
        'Stop any current edits.
        Me.BindingContext(objDS, TableName).EndCurrentEdit()
        GridView1.CloseEditor()
        GridView1.UpdateCurrentRow()
        MainData.ObjKeyWord.Save()
        MainData.Save()
    End Sub
    Public Sub LoadDataSet() Handles MyBase.EventLoadDataset
        Dim _WhereTxt As String = " WHERE ( 0 = 0 ) "
        If IsFiltered Then
            _WhereTxt = _WhereTxt & " AND ( " & FilterTxt & " )"
        Else

        End If
        MainData = New clsEDoc.clsEDoc_Doc(SessionInfo, objDS, KeyDataSet, TableName, _WhereTxt, "ORDER BY " & KeyFieldName)
        Me.objDS.Tables(TableName).DefaultView.Sort = KeyFieldName
    End Sub
    Public Sub PositionChanged(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.EventPositionChanged
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            If CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item(IDField) & "" <> "" Then
                MainData.LoadKeyWords(CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item(IDField))
            Else
                MainData.LoadKeyWords(-1)
            End If
            StatusBar1.Panels(0).Text = (((Me.BindingContext(objDS, TableName).Position + 1).ToString + " of  ") _
                        + Me.BindingContext(objDS, TableName).Count.ToString)
            ToolTip1.SetToolTip(StatusBar1, TableName & "-->" & IDField & "=" & CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item(IDField) & "")
            txtQuickSearch.EditValue = txtName.Text
        End If
    End Sub
    Public Sub EnablingEditFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingEditFields
        'ToBeChecked ***
        txtName.Enabled = Enabling
        txtDescription.Enabled = Enabling
        txtPath.Enabled = Enabling
        cmbCategory.Properties.Enabled = Enabling
        cmbType.Properties.Enabled = Enabling
        GridView1.OptionsBehavior.Editable = Enabling
        Grid1.EmbeddedNavigator.Enabled = Enabling
    End Sub
    Public Sub EnablingKeyFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingkeyFields
        'ToBeChecked ***
    End Sub
    Private Sub StartPrintForm() Handles MyBase.EventPrintForm
        BKReport.PrintForm(CurrentReportID, New DataRow() { _
            CType(Me.BindingContext(MainDataSet, TableName).Current, DataRowView).Row})
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
        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            Dim fi As New IO.FileInfo(OpenFileDialog1.FileName)
            txtName.Text = fi.Name
            txtPath.Text = fi.DirectoryName
        End If
    End Sub
    Private Sub btnView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView1.Click
        Dim p As New System.Diagnostics.ProcessStartInfo
        p.FileName = txtPath.Text & "\" & txtName.Text
        p.UseShellExecute = True
        System.Diagnostics.Process.Start(p)
    End Sub
    Private Sub btnScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScan.Click
        SaveChanges(sender, e)
        If CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item(IDField) & "" <> "" Then
            MainData.Scan(CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item(IDField))
        End If
    End Sub

End Class
