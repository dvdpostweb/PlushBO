<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReconciliation
    Inherits BizzLib.frmBKForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ColTypePayment As DevExpress.XtraGrid.Columns.GridColumn
        Dim ColPayment_id As DevExpress.XtraGrid.Columns.GridColumn
        Dim ColAmountPay As DevExpress.XtraGrid.Columns.GridColumn
        Dim ColDateAdded As DevExpress.XtraGrid.Columns.GridColumn
        Dim ColIdMatching As DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryCmbMatching = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colpayment_offline_request_status_history_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpayment_offline_request_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnew_status2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbOfflineRequestStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colold_status2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldate_added6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridBankAccountMovements = New DevExpress.XtraGrid.GridControl
        Me.GridViewBankAccountMovements = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIsmatching = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBankAccountMovements_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldate_coda_created = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodaFilename = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colamount2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldvdpost_bank_account = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcommunicationStr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCommunication2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStructuredComm12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCounterpartdetails = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCommunication_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEntireData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBankAccountClient = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCustomers_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CheckOpenPaymentCoda = New DevExpress.XtraEditors.CheckEdit
        Me.GCBankAccountMovements = New DevExpress.XtraEditors.GroupControl
        Me.btn_noPayment = New DevExpress.XtraEditors.SimpleButton
        Me.txtAccountMovement_id = New DevExpress.XtraEditors.TextEdit
        Me.lblAccountMovements_id = New DevExpress.XtraEditors.LabelControl
        Me.BtnLoadBankAccountMovements = New DevExpress.XtraEditors.SimpleButton
        Me.lcEnddate = New DevExpress.XtraEditors.LabelControl
        Me.LcStartDate = New DevExpress.XtraEditors.LabelControl
        Me.txtEndDate = New DevExpress.XtraEditors.DateEdit
        Me.txtStartDate = New DevExpress.XtraEditors.DateEdit
        Me.GCPayment = New DevExpress.XtraEditors.GroupControl
        Me.BtnReopen = New DevExpress.XtraEditors.SimpleButton
        Me.txtMatching_id = New DevExpress.XtraEditors.TextEdit
        Me.lblMatching_id = New DevExpress.XtraEditors.LabelControl
        Me.txtcustomers_id = New DevExpress.XtraEditors.TextEdit
        Me.btnLoadPayment = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.checkOpenPayment = New DevExpress.XtraEditors.CheckEdit
        Me.BtnReconciliation = New DevExpress.XtraEditors.SimpleButton
        Me.GridPayment = New DevExpress.XtraGrid.GridControl
        Me.GridViewPayment = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColLastnModified = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCommunicationPay = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCustomersID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPayment_status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColLast_status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDate_closed = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDomNumber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colabopay_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        ColTypePayment = New DevExpress.XtraGrid.Columns.GridColumn
        ColPayment_id = New DevExpress.XtraGrid.Columns.GridColumn
        ColAmountPay = New DevExpress.XtraGrid.Columns.GridColumn
        ColDateAdded = New DevExpress.XtraGrid.Columns.GridColumn
        ColIdMatching = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryCmbMatching, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOfflineRequestStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBankAccountMovements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewBankAccountMovements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckOpenPaymentCoda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCBankAccountMovements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCBankAccountMovements.SuspendLayout()
        CType(Me.txtAccountMovement_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCPayment.SuspendLayout()
        CType(Me.txtMatching_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkOpenPayment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColTypePayment
        '
        ColTypePayment.Caption = "type payment"
        ColTypePayment.FieldName = "type_payment"
        ColTypePayment.Name = "ColTypePayment"
        ColTypePayment.OptionsColumn.AllowEdit = False
        ColTypePayment.Visible = True
        ColTypePayment.VisibleIndex = 0
        ColTypePayment.Width = 81
        '
        'ColPayment_id
        '
        ColPayment_id.Caption = "ID"
        ColPayment_id.FieldName = "id"
        ColPayment_id.Name = "ColPayment_id"
        ColPayment_id.OptionsColumn.AllowEdit = False
        ColPayment_id.OptionsColumn.ReadOnly = True
        ColPayment_id.Visible = True
        ColPayment_id.VisibleIndex = 1
        ColPayment_id.Width = 62
        '
        'ColAmountPay
        '
        ColAmountPay.Caption = "amount"
        ColAmountPay.DisplayFormat.FormatString = "#.00"
        ColAmountPay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        ColAmountPay.FieldName = "amount"
        ColAmountPay.Name = "ColAmountPay"
        ColAmountPay.OptionsColumn.AllowEdit = False
        ColAmountPay.OptionsColumn.ReadOnly = True
        ColAmountPay.Visible = True
        ColAmountPay.VisibleIndex = 3
        ColAmountPay.Width = 57
        '
        'ColDateAdded
        '
        ColDateAdded.Caption = "date_added"
        ColDateAdded.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        ColDateAdded.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        ColDateAdded.FieldName = "date_added"
        ColDateAdded.Name = "ColDateAdded"
        ColDateAdded.OptionsColumn.AllowEdit = False
        ColDateAdded.OptionsColumn.ReadOnly = True
        ColDateAdded.Visible = True
        ColDateAdded.VisibleIndex = 4
        ColDateAdded.Width = 97
        '
        'ColIdMatching
        '
        ColIdMatching.Caption = "id Matching"
        ColIdMatching.FieldName = "id_matching"
        ColIdMatching.Name = "ColIdMatching"
        ColIdMatching.OptionsColumn.AllowEdit = False
        ColIdMatching.OptionsColumn.ReadOnly = True
        ColIdMatching.Visible = True
        ColIdMatching.VisibleIndex = 8
        ColIdMatching.Width = 95
        '
        'RepositoryCmbMatching
        '
        Me.RepositoryCmbMatching.AutoHeight = False
        Me.RepositoryCmbMatching.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryCmbMatching.DisplayMember = "name"
        Me.RepositoryCmbMatching.Name = "RepositoryCmbMatching"
        Me.RepositoryCmbMatching.NullText = ""
        Me.RepositoryCmbMatching.ValueMember = "id"
        '
        'colpayment_offline_request_status_history_id
        '
        Me.colpayment_offline_request_status_history_id.Caption = "payment_offline_request_status_history_id"
        Me.colpayment_offline_request_status_history_id.FieldName = "payment_offline_request_status_history_id"
        Me.colpayment_offline_request_status_history_id.Name = "colpayment_offline_request_status_history_id"
        Me.colpayment_offline_request_status_history_id.OptionsColumn.ReadOnly = True
        Me.colpayment_offline_request_status_history_id.Visible = True
        Me.colpayment_offline_request_status_history_id.VisibleIndex = 0
        '
        'colpayment_offline_request_id1
        '
        Me.colpayment_offline_request_id1.Caption = "payment_offline_request_id"
        Me.colpayment_offline_request_id1.FieldName = "payment_offline_request_id"
        Me.colpayment_offline_request_id1.Name = "colpayment_offline_request_id1"
        Me.colpayment_offline_request_id1.OptionsColumn.ReadOnly = True
        Me.colpayment_offline_request_id1.Visible = True
        Me.colpayment_offline_request_id1.VisibleIndex = 1
        '
        'colnew_status2
        '
        Me.colnew_status2.Caption = "new_status"
        Me.colnew_status2.ColumnEdit = Me.cmbOfflineRequestStatus
        Me.colnew_status2.FieldName = "new_status"
        Me.colnew_status2.Name = "colnew_status2"
        Me.colnew_status2.OptionsColumn.ReadOnly = True
        Me.colnew_status2.Visible = True
        Me.colnew_status2.VisibleIndex = 2
        '
        'cmbOfflineRequestStatus
        '
        Me.cmbOfflineRequestStatus.AutoHeight = False
        Me.cmbOfflineRequestStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOfflineRequestStatus.DisplayMember = "name"
        Me.cmbOfflineRequestStatus.Name = "cmbOfflineRequestStatus"
        Me.cmbOfflineRequestStatus.ValueMember = "id"
        '
        'colold_status2
        '
        Me.colold_status2.Caption = "old_status"
        Me.colold_status2.ColumnEdit = Me.cmbOfflineRequestStatus
        Me.colold_status2.FieldName = "old_status"
        Me.colold_status2.Name = "colold_status2"
        Me.colold_status2.OptionsColumn.ReadOnly = True
        Me.colold_status2.Visible = True
        Me.colold_status2.VisibleIndex = 3
        '
        'coldate_added6
        '
        Me.coldate_added6.Caption = "date_added"
        Me.coldate_added6.FieldName = "date_added"
        Me.coldate_added6.Name = "coldate_added6"
        Me.coldate_added6.OptionsColumn.ReadOnly = True
        Me.coldate_added6.Visible = True
        Me.coldate_added6.VisibleIndex = 4
        '
        'GridBankAccountMovements
        '
        Me.GridBankAccountMovements.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GridBankAccountMovements.EmbeddedNavigator.Name = ""
        Me.GridBankAccountMovements.FormsUseDefaultLookAndFeel = False
        Me.GridBankAccountMovements.Location = New System.Drawing.Point(349, 44)
        Me.GridBankAccountMovements.MainView = Me.GridViewBankAccountMovements
        Me.GridBankAccountMovements.Margin = New System.Windows.Forms.Padding(4)
        Me.GridBankAccountMovements.Name = "GridBankAccountMovements"
        Me.GridBankAccountMovements.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryCmbMatching})
        Me.GridBankAccountMovements.Size = New System.Drawing.Size(1215, 332)
        Me.GridBankAccountMovements.TabIndex = 4
        Me.GridBankAccountMovements.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewBankAccountMovements})
        '
        'GridViewBankAccountMovements
        '
        Me.GridViewBankAccountMovements.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIsmatching, Me.colBankAccountMovements_id, Me.coldate_coda_created, Me.colCodaFilename, Me.colamount2, Me.coldvdpost_bank_account, Me.colcommunicationStr, Me.colCommunication2, Me.colStructuredComm12, Me.colCounterpartdetails, Me.ColCommunication_type, Me.colEntireData, Me.colBankAccountClient, Me.colCustomers_id, Me.colComment})
        Me.GridViewBankAccountMovements.CustomizationFormBounds = New System.Drawing.Rectangle(1113, 176, 327, 364)
        Me.GridViewBankAccountMovements.GridControl = Me.GridBankAccountMovements
        Me.GridViewBankAccountMovements.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewBankAccountMovements.Name = "GridViewBankAccountMovements"
        Me.GridViewBankAccountMovements.OptionsSelection.MultiSelect = True
        Me.GridViewBankAccountMovements.OptionsView.ColumnAutoWidth = False
        Me.GridViewBankAccountMovements.OptionsView.ShowFooter = True
        '
        'colIsmatching
        '
        Me.colIsmatching.Caption = "Open payment"
        Me.colIsmatching.ColumnEdit = Me.RepositoryCmbMatching
        Me.colIsmatching.FieldName = "ismatching"
        Me.colIsmatching.Name = "colIsmatching"
        Me.colIsmatching.OptionsColumn.AllowEdit = False
        Me.colIsmatching.OptionsColumn.ReadOnly = True
        Me.colIsmatching.Visible = True
        Me.colIsmatching.VisibleIndex = 3
        Me.colIsmatching.Width = 82
        '
        'colBankAccountMovements_id
        '
        Me.colBankAccountMovements_id.Caption = "id"
        Me.colBankAccountMovements_id.FieldName = "account_movements_id"
        Me.colBankAccountMovements_id.Name = "colBankAccountMovements_id"
        Me.colBankAccountMovements_id.OptionsColumn.AllowEdit = False
        Me.colBankAccountMovements_id.OptionsColumn.ReadOnly = True
        Me.colBankAccountMovements_id.Visible = True
        Me.colBankAccountMovements_id.VisibleIndex = 0
        '
        'coldate_coda_created
        '
        Me.coldate_coda_created.Caption = "date_added"
        Me.coldate_coda_created.DisplayFormat.FormatString = "d"
        Me.coldate_coda_created.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldate_coda_created.FieldName = "date_coda_created"
        Me.coldate_coda_created.Name = "coldate_coda_created"
        Me.coldate_coda_created.OptionsColumn.AllowEdit = False
        Me.coldate_coda_created.OptionsColumn.ReadOnly = True
        Me.coldate_coda_created.Visible = True
        Me.coldate_coda_created.VisibleIndex = 4
        Me.coldate_coda_created.Width = 105
        '
        'colCodaFilename
        '
        Me.colCodaFilename.Caption = "filename"
        Me.colCodaFilename.FieldName = "coda_filename"
        Me.colCodaFilename.Name = "colCodaFilename"
        Me.colCodaFilename.OptionsColumn.AllowEdit = False
        Me.colCodaFilename.OptionsColumn.ReadOnly = True
        Me.colCodaFilename.Visible = True
        Me.colCodaFilename.VisibleIndex = 12
        '
        'colamount2
        '
        Me.colamount2.Caption = "amount"
        Me.colamount2.FieldName = "Amount"
        Me.colamount2.Name = "colamount2"
        Me.colamount2.OptionsColumn.AllowEdit = False
        Me.colamount2.OptionsColumn.ReadOnly = True
        Me.colamount2.Visible = True
        Me.colamount2.VisibleIndex = 7
        Me.colamount2.Width = 84
        '
        'coldvdpost_bank_account
        '
        Me.coldvdpost_bank_account.Caption = "dvdpost_bank_account"
        Me.coldvdpost_bank_account.FieldName = "dvdpost_bank_account"
        Me.coldvdpost_bank_account.Name = "coldvdpost_bank_account"
        Me.coldvdpost_bank_account.OptionsColumn.AllowEdit = False
        Me.coldvdpost_bank_account.OptionsColumn.ReadOnly = True
        Me.coldvdpost_bank_account.Visible = True
        Me.coldvdpost_bank_account.VisibleIndex = 13
        '
        'colcommunicationStr
        '
        Me.colcommunicationStr.Caption = "Str communication"
        Me.colcommunicationStr.FieldName = "Communication"
        Me.colcommunicationStr.Name = "colcommunicationStr"
        Me.colcommunicationStr.OptionsColumn.AllowEdit = False
        Me.colcommunicationStr.OptionsColumn.ReadOnly = True
        Me.colcommunicationStr.Visible = True
        Me.colcommunicationStr.VisibleIndex = 11
        Me.colcommunicationStr.Width = 240
        '
        'colCommunication2
        '
        Me.colCommunication2.Caption = "Num Dom"
        Me.colCommunication2.FieldName = "Communication2"
        Me.colCommunication2.Name = "colCommunication2"
        Me.colCommunication2.OptionsColumn.AllowEdit = False
        Me.colCommunication2.OptionsColumn.ReadOnly = True
        Me.colCommunication2.Visible = True
        Me.colCommunication2.VisibleIndex = 8
        Me.colCommunication2.Width = 124
        '
        'colStructuredComm12
        '
        Me.colStructuredComm12.Caption = "communication struct"
        Me.colStructuredComm12.FieldName = "structuredComm12"
        Me.colStructuredComm12.Name = "colStructuredComm12"
        Me.colStructuredComm12.OptionsColumn.AllowEdit = False
        Me.colStructuredComm12.OptionsColumn.ReadOnly = True
        Me.colStructuredComm12.Visible = True
        Me.colStructuredComm12.VisibleIndex = 9
        Me.colStructuredComm12.Width = 113
        '
        'colCounterpartdetails
        '
        Me.colCounterpartdetails.Caption = "Info Client"
        Me.colCounterpartdetails.FieldName = "CounterpartDetails"
        Me.colCounterpartdetails.Name = "colCounterpartdetails"
        Me.colCounterpartdetails.OptionsColumn.AllowEdit = False
        Me.colCounterpartdetails.OptionsColumn.ReadOnly = True
        Me.colCounterpartdetails.Visible = True
        Me.colCounterpartdetails.VisibleIndex = 6
        Me.colCounterpartdetails.Width = 146
        '
        'ColCommunication_type
        '
        Me.ColCommunication_type.Caption = "type communication "
        Me.ColCommunication_type.FieldName = "communication_type"
        Me.ColCommunication_type.Name = "ColCommunication_type"
        Me.ColCommunication_type.OptionsColumn.AllowEdit = False
        Me.ColCommunication_type.OptionsColumn.ReadOnly = True
        Me.ColCommunication_type.Visible = True
        Me.ColCommunication_type.VisibleIndex = 10
        '
        'colEntireData
        '
        Me.colEntireData.Caption = "entireData"
        Me.colEntireData.FieldName = "EntireData"
        Me.colEntireData.Name = "colEntireData"
        Me.colEntireData.OptionsColumn.AllowEdit = False
        Me.colEntireData.Visible = True
        Me.colEntireData.VisibleIndex = 14
        '
        'colBankAccountClient
        '
        Me.colBankAccountClient.Caption = "BankAccountClient"
        Me.colBankAccountClient.FieldName = "BankAccountCounterpart"
        Me.colBankAccountClient.Name = "colBankAccountClient"
        Me.colBankAccountClient.OptionsColumn.AllowEdit = False
        Me.colBankAccountClient.Visible = True
        Me.colBankAccountClient.VisibleIndex = 5
        Me.colBankAccountClient.Width = 111
        '
        'colCustomers_id
        '
        Me.colCustomers_id.Caption = "customers_id"
        Me.colCustomers_id.FieldName = "customers_id"
        Me.colCustomers_id.Name = "colCustomers_id"
        Me.colCustomers_id.Visible = True
        Me.colCustomers_id.VisibleIndex = 1
        Me.colCustomers_id.Width = 99
        '
        'colComment
        '
        Me.colComment.Caption = "comment"
        Me.colComment.FieldName = "comment"
        Me.colComment.Name = "colComment"
        Me.colComment.Visible = True
        Me.colComment.VisibleIndex = 2
        Me.colComment.Width = 102
        '
        'CheckOpenPaymentCoda
        '
        Me.CheckOpenPaymentCoda.Location = New System.Drawing.Point(37, 154)
        Me.CheckOpenPaymentCoda.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckOpenPaymentCoda.Name = "CheckOpenPaymentCoda"
        Me.CheckOpenPaymentCoda.Properties.Caption = "Open Payment"
        Me.CheckOpenPaymentCoda.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckOpenPaymentCoda.Properties.ValueChecked = 1
        Me.CheckOpenPaymentCoda.Properties.ValueUnchecked = 0
        Me.CheckOpenPaymentCoda.Size = New System.Drawing.Size(288, 21)
        Me.CheckOpenPaymentCoda.TabIndex = 59
        '
        'GCBankAccountMovements
        '
        Me.GCBankAccountMovements.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCBankAccountMovements.Controls.Add(Me.btn_noPayment)
        Me.GCBankAccountMovements.Controls.Add(Me.CheckOpenPaymentCoda)
        Me.GCBankAccountMovements.Controls.Add(Me.txtAccountMovement_id)
        Me.GCBankAccountMovements.Controls.Add(Me.lblAccountMovements_id)
        Me.GCBankAccountMovements.Controls.Add(Me.BtnLoadBankAccountMovements)
        Me.GCBankAccountMovements.Controls.Add(Me.lcEnddate)
        Me.GCBankAccountMovements.Controls.Add(Me.LcStartDate)
        Me.GCBankAccountMovements.Controls.Add(Me.txtEndDate)
        Me.GCBankAccountMovements.Controls.Add(Me.txtStartDate)
        Me.GCBankAccountMovements.Location = New System.Drawing.Point(5, 44)
        Me.GCBankAccountMovements.Margin = New System.Windows.Forms.Padding(4)
        Me.GCBankAccountMovements.Name = "GCBankAccountMovements"
        Me.GCBankAccountMovements.Size = New System.Drawing.Size(336, 332)
        Me.GCBankAccountMovements.TabIndex = 13
        Me.GCBankAccountMovements.Text = "No Payment"
        '
        'btn_noPayment
        '
        Me.btn_noPayment.Location = New System.Drawing.Point(64, 250)
        Me.btn_noPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_noPayment.Name = "btn_noPayment"
        Me.btn_noPayment.Size = New System.Drawing.Size(192, 28)
        Me.btn_noPayment.TabIndex = 59
        Me.btn_noPayment.Text = "no Payment"
        '
        'txtAccountMovement_id
        '
        Me.txtAccountMovement_id.Location = New System.Drawing.Point(192, 111)
        Me.txtAccountMovement_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAccountMovement_id.Name = "txtAccountMovement_id"
        Me.txtAccountMovement_id.Size = New System.Drawing.Size(133, 22)
        Me.txtAccountMovement_id.TabIndex = 58
        '
        'lblAccountMovements_id
        '
        Me.lblAccountMovements_id.Location = New System.Drawing.Point(60, 114)
        Me.lblAccountMovements_id.Margin = New System.Windows.Forms.Padding(4)
        Me.lblAccountMovements_id.Name = "lblAccountMovements_id"
        Me.lblAccountMovements_id.Size = New System.Drawing.Size(12, 16)
        Me.lblAccountMovements_id.TabIndex = 57
        Me.lblAccountMovements_id.Text = "ID"
        '
        'BtnLoadBankAccountMovements
        '
        Me.BtnLoadBankAccountMovements.Location = New System.Drawing.Point(60, 197)
        Me.BtnLoadBankAccountMovements.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLoadBankAccountMovements.Name = "BtnLoadBankAccountMovements"
        Me.BtnLoadBankAccountMovements.Size = New System.Drawing.Size(192, 28)
        Me.BtnLoadBankAccountMovements.TabIndex = 56
        Me.BtnLoadBankAccountMovements.Text = "Load"
        '
        'lcEnddate
        '
        Me.lcEnddate.Location = New System.Drawing.Point(64, 79)
        Me.lcEnddate.Margin = New System.Windows.Forms.Padding(4)
        Me.lcEnddate.Name = "lcEnddate"
        Me.lcEnddate.Size = New System.Drawing.Size(51, 16)
        Me.lcEnddate.TabIndex = 3
        Me.lcEnddate.Text = "End Date"
        '
        'LcStartDate
        '
        Me.LcStartDate.Location = New System.Drawing.Point(64, 39)
        Me.LcStartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.LcStartDate.Name = "LcStartDate"
        Me.LcStartDate.Size = New System.Drawing.Size(56, 16)
        Me.LcStartDate.TabIndex = 2
        Me.LcStartDate.Text = "start Date"
        '
        'txtEndDate
        '
        Me.txtEndDate.EditValue = Nothing
        Me.txtEndDate.Location = New System.Drawing.Point(192, 79)
        Me.txtEndDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEndDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtEndDate.Size = New System.Drawing.Size(133, 22)
        Me.txtEndDate.TabIndex = 1
        '
        'txtStartDate
        '
        Me.txtStartDate.EditValue = Nothing
        Me.txtStartDate.Location = New System.Drawing.Point(192, 39)
        Me.txtStartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStartDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtStartDate.Size = New System.Drawing.Size(133, 22)
        Me.txtStartDate.TabIndex = 0
        '
        'GCPayment
        '
        Me.GCPayment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCPayment.Controls.Add(Me.BtnReopen)
        Me.GCPayment.Controls.Add(Me.txtMatching_id)
        Me.GCPayment.Controls.Add(Me.lblMatching_id)
        Me.GCPayment.Controls.Add(Me.txtcustomers_id)
        Me.GCPayment.Controls.Add(Me.btnLoadPayment)
        Me.GCPayment.Controls.Add(Me.LabelControl8)
        Me.GCPayment.Controls.Add(Me.checkOpenPayment)
        Me.GCPayment.Location = New System.Drawing.Point(5, 518)
        Me.GCPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.GCPayment.Name = "GCPayment"
        Me.GCPayment.Size = New System.Drawing.Size(336, 311)
        Me.GCPayment.TabIndex = 54
        Me.GCPayment.Text = "Parameters Bank Account Movements"
        '
        'BtnReopen
        '
        Me.BtnReopen.Location = New System.Drawing.Point(21, 222)
        Me.BtnReopen.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnReopen.Name = "BtnReopen"
        Me.BtnReopen.Size = New System.Drawing.Size(192, 28)
        Me.BtnReopen.TabIndex = 61
        Me.BtnReopen.Text = "Re Opened Payment"
        '
        'txtMatching_id
        '
        Me.txtMatching_id.Location = New System.Drawing.Point(121, 81)
        Me.txtMatching_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMatching_id.Name = "txtMatching_id"
        Me.txtMatching_id.Size = New System.Drawing.Size(184, 22)
        Me.txtMatching_id.TabIndex = 60
        '
        'lblMatching_id
        '
        Me.lblMatching_id.Location = New System.Drawing.Point(21, 85)
        Me.lblMatching_id.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMatching_id.Name = "lblMatching_id"
        Me.lblMatching_id.Size = New System.Drawing.Size(67, 16)
        Me.lblMatching_id.TabIndex = 59
        Me.lblMatching_id.Text = "Matching ID"
        '
        'txtcustomers_id
        '
        Me.txtcustomers_id.Location = New System.Drawing.Point(121, 34)
        Me.txtcustomers_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcustomers_id.Name = "txtcustomers_id"
        Me.txtcustomers_id.Size = New System.Drawing.Size(184, 22)
        Me.txtcustomers_id.TabIndex = 56
        '
        'btnLoadPayment
        '
        Me.btnLoadPayment.Location = New System.Drawing.Point(21, 171)
        Me.btnLoadPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLoadPayment.Name = "btnLoadPayment"
        Me.btnLoadPayment.Size = New System.Drawing.Size(192, 28)
        Me.btnLoadPayment.TabIndex = 55
        Me.btnLoadPayment.Text = "Load"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(21, 38)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl8.TabIndex = 54
        Me.LabelControl8.Text = "Customer ID"
        '
        'checkOpenPayment
        '
        Me.checkOpenPayment.Location = New System.Drawing.Point(17, 126)
        Me.checkOpenPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.checkOpenPayment.Name = "checkOpenPayment"
        Me.checkOpenPayment.Properties.Caption = "Open Payment"
        Me.checkOpenPayment.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.checkOpenPayment.Properties.ValueChecked = 1
        Me.checkOpenPayment.Properties.ValueUnchecked = 0
        Me.checkOpenPayment.Size = New System.Drawing.Size(288, 21)
        Me.checkOpenPayment.TabIndex = 53
        '
        'BtnReconciliation
        '
        Me.BtnReconciliation.Location = New System.Drawing.Point(47, 431)
        Me.BtnReconciliation.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnReconciliation.Name = "BtnReconciliation"
        Me.BtnReconciliation.Size = New System.Drawing.Size(192, 28)
        Me.BtnReconciliation.TabIndex = 56
        Me.BtnReconciliation.Text = "Reconciliation"
        '
        'GridPayment
        '
        Me.GridPayment.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GridPayment.EmbeddedNavigator.Name = ""
        Me.GridPayment.FormsUseDefaultLookAndFeel = False
        Me.GridPayment.Location = New System.Drawing.Point(349, 518)
        Me.GridPayment.MainView = Me.GridViewPayment
        Me.GridPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.GridPayment.Name = "GridPayment"
        Me.GridPayment.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit5})
        Me.GridPayment.Size = New System.Drawing.Size(1215, 410)
        Me.GridPayment.TabIndex = 62
        Me.GridPayment.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPayment})
        '
        'GridViewPayment
        '
        Me.GridViewPayment.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {ColTypePayment, ColPayment_id, ColAmountPay, ColDateAdded, Me.ColLastnModified, Me.ColCommunicationPay, Me.ColCustomersID, Me.colPayment_status, ColIdMatching, Me.ColLast_status, Me.colDate_closed, Me.colDomNumber, Me.colabopay_id})
        Me.GridViewPayment.CustomizationFormBounds = New System.Drawing.Rectangle(892, 263, 327, 364)
        Me.GridViewPayment.GridControl = Me.GridPayment
        Me.GridViewPayment.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewPayment.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridViewPayment.Name = "GridViewPayment"
        Me.GridViewPayment.OptionsSelection.MultiSelect = True
        Me.GridViewPayment.OptionsView.ColumnAutoWidth = False
        Me.GridViewPayment.OptionsView.ShowFooter = True
        '
        'ColLastnModified
        '
        Me.ColLastnModified.Caption = "Last modified"
        Me.ColLastnModified.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.ColLastnModified.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColLastnModified.FieldName = "last_modified"
        Me.ColLastnModified.Name = "ColLastnModified"
        Me.ColLastnModified.OptionsColumn.AllowEdit = False
        Me.ColLastnModified.OptionsColumn.ReadOnly = True
        Me.ColLastnModified.Visible = True
        Me.ColLastnModified.VisibleIndex = 5
        '
        'ColCommunicationPay
        '
        Me.ColCommunicationPay.Caption = "communication"
        Me.ColCommunicationPay.FieldName = "communication"
        Me.ColCommunicationPay.Name = "ColCommunicationPay"
        Me.ColCommunicationPay.OptionsColumn.AllowEdit = False
        Me.ColCommunicationPay.OptionsColumn.ReadOnly = True
        Me.ColCommunicationPay.Visible = True
        Me.ColCommunicationPay.VisibleIndex = 6
        Me.ColCommunicationPay.Width = 101
        '
        'ColCustomersID
        '
        Me.ColCustomersID.Caption = "customers_id"
        Me.ColCustomersID.FieldName = "customers_id"
        Me.ColCustomersID.Name = "ColCustomersID"
        Me.ColCustomersID.OptionsColumn.AllowEdit = False
        Me.ColCustomersID.OptionsColumn.ReadOnly = True
        Me.ColCustomersID.Visible = True
        Me.ColCustomersID.VisibleIndex = 2
        Me.ColCustomersID.Width = 112
        '
        'colPayment_status
        '
        Me.colPayment_status.Caption = "Payment_Status"
        Me.colPayment_status.FieldName = "payment_status"
        Me.colPayment_status.Name = "colPayment_status"
        Me.colPayment_status.OptionsColumn.AllowEdit = False
        Me.colPayment_status.OptionsColumn.ReadOnly = True
        Me.colPayment_status.Visible = True
        Me.colPayment_status.VisibleIndex = 7
        Me.colPayment_status.Width = 105
        '
        'ColLast_status
        '
        Me.ColLast_status.Caption = "last_status"
        Me.ColLast_status.FieldName = "last_status"
        Me.ColLast_status.Name = "ColLast_status"
        Me.ColLast_status.OptionsColumn.AllowEdit = False
        '
        'colDate_closed
        '
        Me.colDate_closed.Caption = "date_closed"
        Me.colDate_closed.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.colDate_closed.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDate_closed.FieldName = "date_closed"
        Me.colDate_closed.Name = "colDate_closed"
        Me.colDate_closed.OptionsColumn.AllowEdit = False
        '
        'colDomNumber
        '
        Me.colDomNumber.Caption = "domiciliation_number"
        Me.colDomNumber.FieldName = "domiciliation_number"
        Me.colDomNumber.Name = "colDomNumber"
        Me.colDomNumber.OptionsColumn.AllowEdit = False
        Me.colDomNumber.Width = 132
        '
        'colabopay_id
        '
        Me.colabopay_id.Caption = "abo_id"
        Me.colabopay_id.FieldName = "abo_id"
        Me.colabopay_id.Name = "colabopay_id"
        Me.colabopay_id.OptionsColumn.AllowEdit = False
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.DisplayMember = "name"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.ValueMember = "id"
        '
        'FrmReconciliation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1580, 943)
        Me.Controls.Add(Me.GridPayment)
        Me.Controls.Add(Me.BtnReconciliation)
        Me.Controls.Add(Me.GCPayment)
        Me.Controls.Add(Me.GCBankAccountMovements)
        Me.Controls.Add(Me.GridBankAccountMovements)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmReconciliation"
        Me.Text = "FrmReconciliation"
        Me.Controls.SetChildIndex(Me.GridBankAccountMovements, 0)
        Me.Controls.SetChildIndex(Me.GCBankAccountMovements, 0)
        Me.Controls.SetChildIndex(Me.GCPayment, 0)
        Me.Controls.SetChildIndex(Me.BtnReconciliation, 0)
        Me.Controls.SetChildIndex(Me.GridPayment, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryCmbMatching, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOfflineRequestStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBankAccountMovements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewBankAccountMovements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckOpenPaymentCoda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCBankAccountMovements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCBankAccountMovements.ResumeLayout(False)
        Me.GCBankAccountMovements.PerformLayout()
        CType(Me.txtAccountMovement_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCPayment.ResumeLayout(False)
        Me.GCPayment.PerformLayout()
        CType(Me.txtMatching_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkOpenPayment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridBankAccountMovements As DevExpress.XtraGrid.GridControl
    ' Friend WithEvents GridViewBankAccountMovements2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CheckOpenPaymentCoda As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents RepositoryCmbMatching As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colpayment_offline_request_status_history_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpayment_offline_request_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnew_status2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbOfflineRequestStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colold_status2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_added6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridViewBankAccountMovements As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBankAccountMovements_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvdpost_bank_account As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcommunicationStr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_coda_created As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommunication2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCounterpartdetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodaFilename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStructuredComm12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCBankAccountMovements As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lcEnddate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LcStartDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtStartDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GCPayment As DevExpress.XtraEditors.GroupControl
    Friend WithEvents checkOpenPayment As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnLoadBankAccountMovements As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoadPayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnReconciliation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColCommunication_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsmatching As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtcustomers_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAccountMovement_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAccountMovements_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colEntireData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankAccountClient As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridPayment As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewPayment As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColLastnModified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCommunicationPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCustomersID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayment_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLast_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDate_closed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDomNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colabopay_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btn_noPayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMatching_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMatching_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnReopen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCustomers_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComment As DevExpress.XtraGrid.Columns.GridColumn

End Class
