Imports System.Windows.Forms.Application
Public Class frmClosedAtEurofides
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
    Friend WithEvents PanelSelection As System.Windows.Forms.Panel
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents lblExcelFile As System.Windows.Forms.Label
    Friend WithEvents txtExcelFile As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFile1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PanelDataDetail As System.Windows.Forms.Panel
    Friend WithEvents PanelCommands As System.Windows.Forms.Panel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnClearData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntityName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntityID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAcctName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAcctID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndingBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBeginingBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransAmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMessage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBeginingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnLoadData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _DS As DVDPostLib.dsCompta
    Friend WithEvents colDossier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDebiteur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotreRef As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateOuverture As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDu_Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDu_Principal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDu_ClausePenale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDu_Interet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDu_FraisAdmin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDu_FraisHuissier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecup_Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecup_Principal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecup_ClausePenale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecup_Interet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecup_FraisAdmin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecup_FraisHuissier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSolde_Du As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateCloture As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colprocess_comment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpayment_offline_request_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpinProcessCounter As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnProcess As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PanelSelection = New System.Windows.Forms.Panel
        Me.SpinProcessCounter = New DevExpress.XtraEditors.SpinEdit
        Me.btnBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.txtExcelFile = New System.Windows.Forms.TextBox
        Me.lblExcelFile = New System.Windows.Forms.Label
        Me.btnLoadData = New DevExpress.XtraEditors.SimpleButton
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.OpenFile1 = New System.Windows.Forms.OpenFileDialog
        Me.PanelDataDetail = New System.Windows.Forms.Panel
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me._DS = New DVDPostLib.dsCompta
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDossier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDebiteur = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNotreRef = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDateOuverture = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDu_Total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDu_Principal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDu_ClausePenale = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDu_Interet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDu_FraisAdmin = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDu_FraisHuissier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRecup_Total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRecup_Principal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRecup_ClausePenale = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRecup_Interet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRecup_FraisAdmin = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRecup_FraisHuissier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSolde_Du = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDateCloture = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustomers_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpayment_offline_request_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colprocess_comment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelCommands = New System.Windows.Forms.Panel
        Me.btnProcess = New DevExpress.XtraEditors.SimpleButton
        Me.btnClearData = New DevExpress.XtraEditors.SimpleButton
        Me.colDate1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEntityName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEntityID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBankName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBankID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAcctName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAcctID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCurrCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEndingBalance = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBeginingBalance = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTransAmt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMessage = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBeginingDate = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSelection.SuspendLayout()
        CType(Me.SpinProcessCounter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDataDetail.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCommands.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSelection
        '
        Me.PanelSelection.Controls.Add(Me.SpinProcessCounter)
        Me.PanelSelection.Controls.Add(Me.btnBrowse)
        Me.PanelSelection.Controls.Add(Me.txtExcelFile)
        Me.PanelSelection.Controls.Add(Me.lblExcelFile)
        Me.PanelSelection.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSelection.Location = New System.Drawing.Point(0, 30)
        Me.PanelSelection.Name = "PanelSelection"
        Me.PanelSelection.Size = New System.Drawing.Size(992, 40)
        Me.PanelSelection.TabIndex = 0
        '
        'SpinProcessCounter
        '
        Me.SpinProcessCounter.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinProcessCounter.Location = New System.Drawing.Point(605, 7)
        Me.SpinProcessCounter.Name = "SpinProcessCounter"
        Me.SpinProcessCounter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinProcessCounter.Size = New System.Drawing.Size(100, 20)
        Me.SpinProcessCounter.TabIndex = 20
        Me.SpinProcessCounter.Visible = False
        '
        'btnBrowse
        '
        Me.btnBrowse.ImageIndex = 13
        Me.btnBrowse.Location = New System.Drawing.Point(504, 8)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(56, 24)
        Me.btnBrowse.TabIndex = 19
        Me.btnBrowse.Text = "&Browse"
        '
        'txtExcelFile
        '
        Me.txtExcelFile.Location = New System.Drawing.Point(120, 8)
        Me.txtExcelFile.Name = "txtExcelFile"
        Me.txtExcelFile.Size = New System.Drawing.Size(368, 20)
        Me.txtExcelFile.TabIndex = 2
        '
        'lblExcelFile
        '
        Me.lblExcelFile.Location = New System.Drawing.Point(8, 16)
        Me.lblExcelFile.Name = "lblExcelFile"
        Me.lblExcelFile.Size = New System.Drawing.Size(112, 16)
        Me.lblExcelFile.TabIndex = 1
        Me.lblExcelFile.Text = "Excel File to Import"
        '
        'btnLoadData
        '
        Me.btnLoadData.ImageIndex = 13
        Me.btnLoadData.Location = New System.Drawing.Point(8, 40)
        Me.btnLoadData.Name = "btnLoadData"
        Me.btnLoadData.Size = New System.Drawing.Size(72, 24)
        Me.btnLoadData.TabIndex = 18
        Me.btnLoadData.Text = "&Load Data"
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 416)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(992, 22)
        Me.StatusBar1.TabIndex = 1
        Me.StatusBar1.Text = "StatusBar1"
        '
        'OpenFile1
        '
        Me.OpenFile1.DefaultExt = "xls"
        Me.OpenFile1.Filter = "Excel File|*.xls|All files|*.*"
        '
        'PanelDataDetail
        '
        Me.PanelDataDetail.Controls.Add(Me.GridControl1)
        Me.PanelDataDetail.Controls.Add(Me.PanelCommands)
        Me.PanelDataDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDataDetail.Location = New System.Drawing.Point(0, 70)
        Me.PanelDataDetail.Name = "PanelDataDetail"
        Me.PanelDataDetail.Size = New System.Drawing.Size(992, 346)
        Me.PanelDataDetail.TabIndex = 2
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me._DS.Eurofides
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.FormsUseDefaultLookAndFeel = False
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(904, 346)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        '_DS
        '
        Me._DS.DataSetName = "dsCompta"
        Me._DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDossier, Me.colDebiteur, Me.colNotreRef, Me.colDateOuverture, Me.colDu_Total, Me.colDu_Principal, Me.colDu_ClausePenale, Me.colDu_Interet, Me.colDu_FraisAdmin, Me.colDu_FraisHuissier, Me.colRecup_Total, Me.colRecup_Principal, Me.colRecup_ClausePenale, Me.colRecup_Interet, Me.colRecup_FraisAdmin, Me.colRecup_FraisHuissier, Me.colSolde_Du, Me.colComment, Me.colDateCloture, Me.colcustomers_id, Me.colpayment_offline_request_id, Me.colprocess_comment})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(1086, 229, 208, 360)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.GroupPanelText = "..."
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colDossier
        '
        Me.colDossier.Caption = "Dossier"
        Me.colDossier.FieldName = "Dossier"
        Me.colDossier.Name = "colDossier"
        Me.colDossier.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colDossier.Visible = True
        Me.colDossier.VisibleIndex = 0
        '
        'colDebiteur
        '
        Me.colDebiteur.Caption = "Debiteur"
        Me.colDebiteur.FieldName = "Debiteur"
        Me.colDebiteur.Name = "colDebiteur"
        Me.colDebiteur.Visible = True
        Me.colDebiteur.VisibleIndex = 1
        '
        'colNotreRef
        '
        Me.colNotreRef.Caption = "NotreRef"
        Me.colNotreRef.FieldName = "NotreRef"
        Me.colNotreRef.Name = "colNotreRef"
        Me.colNotreRef.Visible = True
        Me.colNotreRef.VisibleIndex = 2
        '
        'colDateOuverture
        '
        Me.colDateOuverture.Caption = "DateOuverture"
        Me.colDateOuverture.FieldName = "DateOuverture"
        Me.colDateOuverture.Name = "colDateOuverture"
        Me.colDateOuverture.Visible = True
        Me.colDateOuverture.VisibleIndex = 3
        '
        'colDu_Total
        '
        Me.colDu_Total.Caption = "Du_Total"
        Me.colDu_Total.FieldName = "Du_Total"
        Me.colDu_Total.Name = "colDu_Total"
        Me.colDu_Total.Visible = True
        Me.colDu_Total.VisibleIndex = 4
        '
        'colDu_Principal
        '
        Me.colDu_Principal.Caption = "Du_Principal"
        Me.colDu_Principal.FieldName = "Du_Principal"
        Me.colDu_Principal.Name = "colDu_Principal"
        '
        'colDu_ClausePenale
        '
        Me.colDu_ClausePenale.Caption = "Du_ClausePenale"
        Me.colDu_ClausePenale.FieldName = "Du_ClausePenale"
        Me.colDu_ClausePenale.Name = "colDu_ClausePenale"
        '
        'colDu_Interet
        '
        Me.colDu_Interet.Caption = "Du_Interet"
        Me.colDu_Interet.FieldName = "Du_Interet"
        Me.colDu_Interet.Name = "colDu_Interet"
        '
        'colDu_FraisAdmin
        '
        Me.colDu_FraisAdmin.Caption = "Du_FraisAdmin"
        Me.colDu_FraisAdmin.FieldName = "Du_FraisAdmin"
        Me.colDu_FraisAdmin.Name = "colDu_FraisAdmin"
        '
        'colDu_FraisHuissier
        '
        Me.colDu_FraisHuissier.Caption = "Du_FraisHuissier"
        Me.colDu_FraisHuissier.FieldName = "Du_FraisHuissier"
        Me.colDu_FraisHuissier.Name = "colDu_FraisHuissier"
        '
        'colRecup_Total
        '
        Me.colRecup_Total.Caption = "Recup_Total"
        Me.colRecup_Total.FieldName = "Recup_Total"
        Me.colRecup_Total.Name = "colRecup_Total"
        Me.colRecup_Total.Visible = True
        Me.colRecup_Total.VisibleIndex = 5
        '
        'colRecup_Principal
        '
        Me.colRecup_Principal.Caption = "Recup_Principal"
        Me.colRecup_Principal.FieldName = "Recup_Principal"
        Me.colRecup_Principal.Name = "colRecup_Principal"
        '
        'colRecup_ClausePenale
        '
        Me.colRecup_ClausePenale.Caption = "Recup_ClausePenale"
        Me.colRecup_ClausePenale.FieldName = "Recup_ClausePenale"
        Me.colRecup_ClausePenale.Name = "colRecup_ClausePenale"
        '
        'colRecup_Interet
        '
        Me.colRecup_Interet.Caption = "Recup_Interet"
        Me.colRecup_Interet.FieldName = "Recup_Interet"
        Me.colRecup_Interet.Name = "colRecup_Interet"
        '
        'colRecup_FraisAdmin
        '
        Me.colRecup_FraisAdmin.Caption = "Recup_FraisAdmin"
        Me.colRecup_FraisAdmin.FieldName = "Recup_FraisAdmin"
        Me.colRecup_FraisAdmin.Name = "colRecup_FraisAdmin"
        '
        'colRecup_FraisHuissier
        '
        Me.colRecup_FraisHuissier.Caption = "Recup_FraisHuissier"
        Me.colRecup_FraisHuissier.FieldName = "Recup_FraisHuissier"
        Me.colRecup_FraisHuissier.Name = "colRecup_FraisHuissier"
        '
        'colSolde_Du
        '
        Me.colSolde_Du.Caption = "Solde_Du"
        Me.colSolde_Du.FieldName = "Solde_Du"
        Me.colSolde_Du.Name = "colSolde_Du"
        Me.colSolde_Du.Visible = True
        Me.colSolde_Du.VisibleIndex = 6
        '
        'colComment
        '
        Me.colComment.Caption = "Comment"
        Me.colComment.FieldName = "Comment"
        Me.colComment.Name = "colComment"
        '
        'colDateCloture
        '
        Me.colDateCloture.Caption = "DateCloture"
        Me.colDateCloture.FieldName = "DateCloture"
        Me.colDateCloture.Name = "colDateCloture"
        Me.colDateCloture.Visible = True
        Me.colDateCloture.VisibleIndex = 7
        '
        'colcustomers_id
        '
        Me.colcustomers_id.Caption = "customers_id"
        Me.colcustomers_id.FieldName = "customers_id"
        Me.colcustomers_id.Name = "colcustomers_id"
        Me.colcustomers_id.Visible = True
        Me.colcustomers_id.VisibleIndex = 8
        '
        'colpayment_offline_request_id
        '
        Me.colpayment_offline_request_id.Caption = "payment_offline_request_id"
        Me.colpayment_offline_request_id.FieldName = "payment_offline_request_id"
        Me.colpayment_offline_request_id.Name = "colpayment_offline_request_id"
        Me.colpayment_offline_request_id.Visible = True
        Me.colpayment_offline_request_id.VisibleIndex = 9
        '
        'colprocess_comment
        '
        Me.colprocess_comment.Caption = "process_comment"
        Me.colprocess_comment.FieldName = "process_comment"
        Me.colprocess_comment.Name = "colprocess_comment"
        Me.colprocess_comment.Visible = True
        Me.colprocess_comment.VisibleIndex = 10
        '
        'PanelCommands
        '
        Me.PanelCommands.Controls.Add(Me.btnProcess)
        Me.PanelCommands.Controls.Add(Me.btnClearData)
        Me.PanelCommands.Controls.Add(Me.btnLoadData)
        Me.PanelCommands.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelCommands.Location = New System.Drawing.Point(904, 0)
        Me.PanelCommands.Name = "PanelCommands"
        Me.PanelCommands.Size = New System.Drawing.Size(88, 346)
        Me.PanelCommands.TabIndex = 3
        '
        'btnProcess
        '
        Me.btnProcess.ImageIndex = 13
        Me.btnProcess.Location = New System.Drawing.Point(8, 72)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(72, 24)
        Me.btnProcess.TabIndex = 20
        Me.btnProcess.Text = "&Process"
        '
        'btnClearData
        '
        Me.btnClearData.ImageIndex = 13
        Me.btnClearData.Location = New System.Drawing.Point(8, 8)
        Me.btnClearData.Name = "btnClearData"
        Me.btnClearData.Size = New System.Drawing.Size(72, 24)
        Me.btnClearData.TabIndex = 19
        Me.btnClearData.Text = "&Clear Data"
        '
        'colDate1
        '
        Me.colDate1.Caption = "Date1"
        Me.colDate1.FieldName = "Date1"
        Me.colDate1.Name = "colDate1"
        Me.colDate1.Visible = True
        Me.colDate1.VisibleIndex = 9
        Me.colDate1.Width = 71
        '
        'colEntityName
        '
        Me.colEntityName.Caption = "EntityName"
        Me.colEntityName.FieldName = "EntityName"
        Me.colEntityName.Name = "colEntityName"
        Me.colEntityName.Visible = True
        Me.colEntityName.VisibleIndex = 0
        Me.colEntityName.Width = 74
        '
        'colEntityID
        '
        Me.colEntityID.Caption = "EntityID"
        Me.colEntityID.FieldName = "EntityID"
        Me.colEntityID.Name = "colEntityID"
        Me.colEntityID.Visible = True
        Me.colEntityID.VisibleIndex = 1
        Me.colEntityID.Width = 49
        '
        'colBankName
        '
        Me.colBankName.Caption = "BankName"
        Me.colBankName.FieldName = "BankName"
        Me.colBankName.Name = "colBankName"
        Me.colBankName.Visible = True
        Me.colBankName.VisibleIndex = 2
        Me.colBankName.Width = 76
        '
        'colBankID
        '
        Me.colBankID.Caption = "BankID"
        Me.colBankID.FieldName = "BankID"
        Me.colBankID.Name = "colBankID"
        Me.colBankID.Visible = True
        Me.colBankID.VisibleIndex = 3
        Me.colBankID.Width = 50
        '
        'colAcctName
        '
        Me.colAcctName.Caption = "AcctName"
        Me.colAcctName.FieldName = "AcctName"
        Me.colAcctName.Name = "colAcctName"
        Me.colAcctName.Visible = True
        Me.colAcctName.VisibleIndex = 4
        Me.colAcctName.Width = 127
        '
        'colAcctID
        '
        Me.colAcctID.Caption = "AcctID"
        Me.colAcctID.FieldName = "AcctID"
        Me.colAcctID.Name = "colAcctID"
        Me.colAcctID.Visible = True
        Me.colAcctID.VisibleIndex = 5
        Me.colAcctID.Width = 51
        '
        'colCurrCode
        '
        Me.colCurrCode.Caption = "CurrCode"
        Me.colCurrCode.FieldName = "CurrCode"
        Me.colCurrCode.Name = "colCurrCode"
        Me.colCurrCode.Visible = True
        Me.colCurrCode.VisibleIndex = 6
        Me.colCurrCode.Width = 73
        '
        'colEndingBalance
        '
        Me.colEndingBalance.Caption = "EndingBalance"
        Me.colEndingBalance.FieldName = "EndingBalance"
        Me.colEndingBalance.Name = "colEndingBalance"
        Me.colEndingBalance.Visible = True
        Me.colEndingBalance.VisibleIndex = 10
        Me.colEndingBalance.Width = 76
        '
        'colBeginingBalance
        '
        Me.colBeginingBalance.Caption = "BeginingBalance"
        Me.colBeginingBalance.FieldName = "BeginingBalance"
        Me.colBeginingBalance.Name = "colBeginingBalance"
        Me.colBeginingBalance.Visible = True
        Me.colBeginingBalance.VisibleIndex = 8
        Me.colBeginingBalance.Width = 78
        '
        'colTransAmt
        '
        Me.colTransAmt.Caption = "TransAmt"
        Me.colTransAmt.FieldName = "TransAmt"
        Me.colTransAmt.Name = "colTransAmt"
        Me.colTransAmt.Visible = True
        Me.colTransAmt.VisibleIndex = 11
        Me.colTransAmt.Width = 92
        '
        'colMessage
        '
        Me.colMessage.Caption = "Message"
        Me.colMessage.FieldName = "Message"
        Me.colMessage.Name = "colMessage"
        '
        'colBeginingDate
        '
        Me.colBeginingDate.Caption = "BeginingDate"
        Me.colBeginingDate.FieldName = "BeginingDate"
        Me.colBeginingDate.Name = "colBeginingDate"
        Me.colBeginingDate.Visible = True
        Me.colBeginingDate.VisibleIndex = 7
        Me.colBeginingDate.Width = 73
        '
        'frmClosedAtEurofides
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(992, 438)
        Me.Controls.Add(Me.PanelDataDetail)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.PanelSelection)
        Me.Name = "frmClosedAtEurofides"
        Me.Text = "Import from Excel"
        Me.Controls.SetChildIndex(Me.PanelSelection, 0)
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.PanelDataDetail, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSelection.ResumeLayout(False)
        Me.PanelSelection.PerformLayout()
        CType(Me.SpinProcessCounter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDataDetail.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCommands.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
    Dim Date1 As Date
    Dim TableName As String = "Eurofides"
    Dim ExcelFileName As String

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFile1.ShowDialog()
        ExcelFileName = OpenFile1.FileName
        txtExcelFile.Text = ExcelFileName
    End Sub
    Private Sub btnClearData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearData.Click
        _DS.Tables(TableName).Clear()
    End Sub
    Private Sub btnLoadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadData.Click
        'Dim ExcelApp As Object
        'Dim WB As Excel.Workbook
        'Dim _XWorkSheet As New Excel.Worksheet
        Dim _Row As DataRow
        Dim i, _CustID, _Offine_Request_id As Integer
        Dim _frm As New BizzLib.frmProgressBarPopUP(SessionInfo)

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        _frm.MemoEdit1.Text = ""
        _frm.Show()
        _frm.MemoEdit1.Text += "Connecting To Excel" & vbCrLf
        _frm.Refresh()
        _DS.Tables(TableName).Clear()
        'TT ExcelApp = CreateObject("Excel.Application")
        'TT WB = ExcelApp.Workbooks.Open(txtExcelFile.Text)
        'TT _XWorkSheet = WB.Worksheets(1)
        Dim EXCELConn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & txtExcelFile.Text & ";Extended Properties=""Excel 8.0;HDR=No""")
        EXCELConn.Open()
        Dim _SQLTxt As String = "SELECT * FROM [Sheet1$A1:A1]"
        Dim _ole As New OleDb.OleDbDataAdapter(_SQLTxt, EXCELConn)
        Dim _ExcelDS As New DataSet
        _ExcelDS.Tables.Add("Date1")
        '_ExcelDS.Tables("Date1").Columns.Add("Date1")
        'TT Date1 = _XWorkSheet.Range("B1").Value
        _ole.Fill(_ExcelDS.Tables("Date1"))
        If _ExcelDS.Tables("Date1").Rows.Count = 0 Then
            MsgBox("Cannot Find Excel Info in Cell A1", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'If Not IsDate(_ExcelDS.Tables("Date1").Rows(0).Item(0)) Then
        '    MsgBox("Cell B1 is not a DATE", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        i = 3
        _ExcelDS.Tables.Add("ExcelRow")

        _frm.MemoEdit1.Text += "Loading Data from Excel" & vbCrLf
        _frm.Refresh()

        Do
            _SQLTxt = "SELECT * FROM [Sheet1$A" & i & ":U" & i & "]"
            _ole.SelectCommand.CommandText = _SQLTxt
            'TT Date1 = _XWorkSheet.Range("B1").Value
            _ole.Fill(_ExcelDS.Tables("ExcelRow"))
            If _ExcelDS.Tables("ExcelRow").Rows.Count = 0 Then
                Exit Do
            End If
            If IsDBNull(_ExcelDS.Tables("ExcelRow").Rows(0).Item(0)) Then
                Exit Do
            End If
            _Row = _DS.Tables(TableName).NewRow()
            _Row.Item("Dossier") = _ExcelDS.Tables("ExcelRow").Rows(0).Item(0)
            _Row.Item("Debiteur") = _ExcelDS.Tables("ExcelRow").Rows(0).Item(1)
            _Row.Item("NotreRef") = _ExcelDS.Tables("ExcelRow").Rows(0).Item(2)
            _Row.Item("DateOuverture") = _ExcelDS.Tables("ExcelRow").Rows(0).Item(3)

            _Row.Item("Du_Principal") = _ExcelDS.Tables("ExcelRow").Rows(0).Item(4)
            _Row.Item("Du_ClausePenale") = _ExcelDS.Tables("ExcelRow").Rows(0).Item(6)
            _Row.Item("Du_Interet") = _ExcelDS.Tables("ExcelRow").Rows(0).Item(7)
            _Row.Item("Du_FraisAdmin") = _ExcelDS.Tables("ExcelRow").Rows(0).Item(8)
            _Row.Item("Du_FraisHuissier") = _ExcelDS.Tables("ExcelRow").Rows(0).Item(9)
            _Row.Item("Du_Total") = _Row.Item("Du_Principal") + _Row.Item("Du_ClausePenale") + _Row.Item("Du_Interet") + _Row.Item("Du_FraisAdmin") + _Row.Item("Du_FraisHuissier")

            _Row.Item("Recup_Principal") = _ExcelDS.Tables("ExcelRow").Rows(0).Item(11)
            _Row.Item("Recup_ClausePenale") = _ExcelDS.Tables("ExcelRow").Rows(0).Item(12)
            _Row.Item("Recup_Interet") = _ExcelDS.Tables("ExcelRow").Rows(0).Item(13)
            _Row.Item("Recup_FraisAdmin") = _ExcelDS.Tables("ExcelRow").Rows(0).Item(14)
            _Row.Item("Recup_FraisHuissier") = _ExcelDS.Tables("ExcelRow").Rows(0).Item(15)
            _Row.Item("Recup_Total") = _Row.Item("Recup_Principal") + _Row.Item("Recup_ClausePenale") + _Row.Item("Recup_Interet") + _Row.Item("Recup_FraisAdmin") + _Row.Item("Recup_FraisHuissier")

            _Row.Item("Solde_Du") = _Row.Item("Du_Total") - _Row.Item("Recup_Total")
            _Row.Item("Comment") = _ExcelDS.Tables("ExcelRow").Rows(0).Item(17)
            _Row.Item("DateCloture") = _ExcelDS.Tables("ExcelRow").Rows(0).Item(18)

            _DS.Tables(TableName).Rows.Add(_Row)
            i += 1
            _ExcelDS.Tables("ExcelRow").Clear()
        Loop
        EXCELConn.Close()


        _frm.MemoEdit1.Text += "Retreiving Customers ID / Payment ID" & vbCrLf
        _frm.Refresh()
        SpinProcessCounter.EditValue = _DS.Tables(TableName).Rows.Count
        SpinProcessCounter.Visible = True
        SpinProcessCounter.Refresh()
        For Each _Row In _DS.Tables(TableName).Rows
            _DS.Tables("payment_offline_request").Clear()
            'Searching By Communication
            BKGlobal.Cls1.FillDataSet(_DS.Tables("payment_offline_request"), "SELECT * FROM payment_offline_request p WHERE communication = '" & _Row.Item("NotreRef") & "'")
            If _DS.Tables("payment_offline_request").Rows.Count = 0 Then
                'Searching By CustomerID
                BKGlobal.Cls1.FillDataSet(_DS.Tables("payment_offline_request"), _
                     "SELECT * FROM payment_offline_request p WHERE customers_id = '" & _Row.Item("NotreRef") & "' and " & _
                     " payment_offline_status = 9 and amount = " & _Row.Item("Du_Principal") & " ORDER BY payment_offline_request_id LIMIT 1")
                If _DS.Tables("payment_offline_request").Rows.Count = 0 Then
                    _Row.Item("process_comment") = "Cannot Find OffLine Request"
                    _Row.Item("customers_id") = DBNull.Value
                    _Row.Item("payment_offline_request_id") = DBNull.Value
                Else
                    _Row.Item("process_comment") = ""
                    _Row.Item("customers_id") = _DS.Tables("payment_offline_request").Rows(0).Item("customers_id")
                    _Row.Item("payment_offline_request_id") = _DS.Tables("payment_offline_request").Rows(0).Item("payment_offline_request_id")
                End If
            Else
                If _DS.Tables("payment_offline_request").Rows.Count > 1 Then
                    _Row.Item("process_comment") = "More than 1 OffLine Request"
                    _Row.Item("customers_id") = DBNull.Value
                    _Row.Item("payment_offline_request_id") = DBNull.Value
                Else
                    _Row.Item("process_comment") = ""
                    _Row.Item("customers_id") = _DS.Tables("payment_offline_request").Rows(0).Item("customers_id")
                    _Row.Item("payment_offline_request_id") = _DS.Tables("payment_offline_request").Rows(0).Item("payment_offline_request_id")
                End If
            End If
            SpinProcessCounter.EditValue -= 1
            SpinProcessCounter.Refresh()
        Next
        SpinProcessCounter.Visible = False
        _frm.MemoEdit1.Text += "Closing Excel" & vbCrLf
        _frm.Refresh()
        _frm.Close()
        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI

    End Sub
    Private Sub btnCreateTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Dim _row As DataRow
        Dim _OffLine As clsOffLinePayments
        SpinProcessCounter.EditValue = _DS.Tables(TableName).Rows.Count
        SpinProcessCounter.Visible = True
        SpinProcessCounter.Refresh()
        For Each _row In _DS.Tables(TableName).Rows
            If Not IsDBNull(_row.Item("payment_offline_request_id")) Then
                _OffLine = New clsOffLinePayments(SessionInfo)
                _OffLine.CurrentOffLineID = _row.Item("payment_offline_request_id")
                _OffLine.SetPaymentClosedAtEurofides(_row.Item("Recup_Total"))
                SpinProcessCounter.EditValue -= 1
                SpinProcessCounter.Refresh()
                DoEvents()
            End If
        Next
        SpinProcessCounter.Visible = False
    End Sub

End Class
