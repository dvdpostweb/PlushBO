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
        Me.colpayment_offline_request_status_history_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpayment_offline_request_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnew_status2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbOfflineRequestStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colold_status2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldate_added6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridBankAccountMovements = New DevExpress.XtraGrid.GridControl
        Me.GridViewBankAccountMovements = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIsmatching = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
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
        Me.GCBankAccountMovements = New DevExpress.XtraEditors.GroupControl
        Me.txtAccountMovement_id = New DevExpress.XtraEditors.TextEdit
        Me.lblAccountMovements_id = New DevExpress.XtraEditors.LabelControl
        Me.BtnLoadBankAccountMovements = New DevExpress.XtraEditors.SimpleButton
        Me.chkIsmatching = New DevExpress.XtraEditors.CheckEdit
        Me.lcEnddate = New DevExpress.XtraEditors.LabelControl
        Me.LcStartDate = New DevExpress.XtraEditors.LabelControl
        Me.txtEndDate = New DevExpress.XtraEditors.DateEdit
        Me.txtStartDate = New DevExpress.XtraEditors.DateEdit
        Me.GridPayment = New DevExpress.XtraGrid.GridControl
        Me.GridViewPayment = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GCTypePayment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCAmountPay = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCDateAdded = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCLastnModified = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCCommunicationPay = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCCustomersID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCIdRecovery = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcStatusRecovery = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcIdMatching = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCommunication_Recovery = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCPayment = New DevExpress.XtraEditors.GroupControl
        Me.txtcustomers_id = New DevExpress.XtraEditors.TextEdit
        Me.btnLoadPayment = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.checkOpenPayment = New DevExpress.XtraEditors.CheckEdit
        Me.BtnReconciliation = New DevExpress.XtraEditors.SimpleButton
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOfflineRequestStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBankAccountMovements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewBankAccountMovements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCBankAccountMovements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCBankAccountMovements.SuspendLayout()
        CType(Me.txtAccountMovement_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsmatching.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCPayment.SuspendLayout()
        CType(Me.txtcustomers_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkOpenPayment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GridBankAccountMovements.EmbeddedNavigator.Name = ""
        Me.GridBankAccountMovements.FormsUseDefaultLookAndFeel = False
        Me.GridBankAccountMovements.Location = New System.Drawing.Point(262, 36)
        Me.GridBankAccountMovements.MainView = Me.GridViewBankAccountMovements
        Me.GridBankAccountMovements.Name = "GridBankAccountMovements"
        Me.GridBankAccountMovements.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridBankAccountMovements.Size = New System.Drawing.Size(911, 270)
        Me.GridBankAccountMovements.TabIndex = 4
        Me.GridBankAccountMovements.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewBankAccountMovements})
        '
        'GridViewBankAccountMovements
        '
        Me.GridViewBankAccountMovements.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIsmatching, Me.colBankAccountMovements_id, Me.coldate_coda_created, Me.colCodaFilename, Me.colamount2, Me.coldvdpost_bank_account, Me.colcommunicationStr, Me.colCommunication2, Me.colStructuredComm12, Me.colCounterpartdetails, Me.ColCommunication_type, Me.colEntireData, Me.colBankAccountClient})
        Me.GridViewBankAccountMovements.CustomizationFormBounds = New System.Drawing.Rectangle(1113, 176, 327, 364)
        Me.GridViewBankAccountMovements.GridControl = Me.GridBankAccountMovements
        Me.GridViewBankAccountMovements.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewBankAccountMovements.Name = "GridViewBankAccountMovements"
        Me.GridViewBankAccountMovements.OptionsView.ColumnAutoWidth = False
        Me.GridViewBankAccountMovements.OptionsView.ShowFooter = True
        '
        'colIsmatching
        '
        Me.colIsmatching.Caption = "Open payment"
        Me.colIsmatching.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colIsmatching.FieldName = "ismatching"
        Me.colIsmatching.Name = "colIsmatching"
        Me.colIsmatching.OptionsColumn.AllowEdit = False
        Me.colIsmatching.OptionsColumn.ReadOnly = True
        Me.colIsmatching.Visible = True
        Me.colIsmatching.VisibleIndex = 1
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = 0
        Me.RepositoryItemCheckEdit1.ValueUnchecked = 1
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
        Me.coldate_coda_created.VisibleIndex = 2
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
        Me.colCodaFilename.VisibleIndex = 10
        '
        'colamount2
        '
        Me.colamount2.Caption = "amount"
        Me.colamount2.FieldName = "Amount"
        Me.colamount2.Name = "colamount2"
        Me.colamount2.OptionsColumn.AllowEdit = False
        Me.colamount2.OptionsColumn.ReadOnly = True
        Me.colamount2.Visible = True
        Me.colamount2.VisibleIndex = 5
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
        Me.coldvdpost_bank_account.VisibleIndex = 11
        '
        'colcommunicationStr
        '
        Me.colcommunicationStr.Caption = "Str communication"
        Me.colcommunicationStr.FieldName = "Communication"
        Me.colcommunicationStr.Name = "colcommunicationStr"
        Me.colcommunicationStr.OptionsColumn.AllowEdit = False
        Me.colcommunicationStr.OptionsColumn.ReadOnly = True
        Me.colcommunicationStr.Visible = True
        Me.colcommunicationStr.VisibleIndex = 9
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
        Me.colCommunication2.VisibleIndex = 6
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
        Me.colStructuredComm12.VisibleIndex = 7
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
        Me.colCounterpartdetails.VisibleIndex = 4
        Me.colCounterpartdetails.Width = 180
        '
        'ColCommunication_type
        '
        Me.ColCommunication_type.Caption = "type communication "
        Me.ColCommunication_type.FieldName = "communication_type"
        Me.ColCommunication_type.Name = "ColCommunication_type"
        Me.ColCommunication_type.OptionsColumn.AllowEdit = False
        Me.ColCommunication_type.OptionsColumn.ReadOnly = True
        Me.ColCommunication_type.Visible = True
        Me.ColCommunication_type.VisibleIndex = 8
        '
        'colEntireData
        '
        Me.colEntireData.Caption = "entireData"
        Me.colEntireData.FieldName = "EntireData"
        Me.colEntireData.Name = "colEntireData"
        Me.colEntireData.OptionsColumn.AllowEdit = False
        Me.colEntireData.Visible = True
        Me.colEntireData.VisibleIndex = 12
        '
        'colBankAccountClient
        '
        Me.colBankAccountClient.Caption = "BankAccountClient"
        Me.colBankAccountClient.FieldName = "BankAccountCounterpart"
        Me.colBankAccountClient.Name = "colBankAccountClient"
        Me.colBankAccountClient.OptionsColumn.AllowEdit = False
        Me.colBankAccountClient.Visible = True
        Me.colBankAccountClient.VisibleIndex = 3
        Me.colBankAccountClient.Width = 111
        '
        'GCBankAccountMovements
        '
        Me.GCBankAccountMovements.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCBankAccountMovements.Controls.Add(Me.txtAccountMovement_id)
        Me.GCBankAccountMovements.Controls.Add(Me.lblAccountMovements_id)
        Me.GCBankAccountMovements.Controls.Add(Me.BtnLoadBankAccountMovements)
        Me.GCBankAccountMovements.Controls.Add(Me.chkIsmatching)
        Me.GCBankAccountMovements.Controls.Add(Me.lcEnddate)
        Me.GCBankAccountMovements.Controls.Add(Me.LcStartDate)
        Me.GCBankAccountMovements.Controls.Add(Me.txtEndDate)
        Me.GCBankAccountMovements.Controls.Add(Me.txtStartDate)
        Me.GCBankAccountMovements.Location = New System.Drawing.Point(4, 36)
        Me.GCBankAccountMovements.Name = "GCBankAccountMovements"
        Me.GCBankAccountMovements.Size = New System.Drawing.Size(252, 270)
        Me.GCBankAccountMovements.TabIndex = 13
        Me.GCBankAccountMovements.Text = "Parameters Bank Account Movements"
        '
        'txtAccountMovement_id
        '
        Me.txtAccountMovement_id.Location = New System.Drawing.Point(144, 90)
        Me.txtAccountMovement_id.Name = "txtAccountMovement_id"
        Me.txtAccountMovement_id.Size = New System.Drawing.Size(100, 20)
        Me.txtAccountMovement_id.TabIndex = 58
        '
        'lblAccountMovements_id
        '
        Me.lblAccountMovements_id.Location = New System.Drawing.Point(45, 93)
        Me.lblAccountMovements_id.Name = "lblAccountMovements_id"
        Me.lblAccountMovements_id.Size = New System.Drawing.Size(11, 13)
        Me.lblAccountMovements_id.TabIndex = 57
        Me.lblAccountMovements_id.Text = "ID"
        '
        'BtnLoadBankAccountMovements
        '
        Me.BtnLoadBankAccountMovements.Location = New System.Drawing.Point(45, 160)
        Me.BtnLoadBankAccountMovements.Name = "BtnLoadBankAccountMovements"
        Me.BtnLoadBankAccountMovements.Size = New System.Drawing.Size(144, 23)
        Me.BtnLoadBankAccountMovements.TabIndex = 56
        Me.BtnLoadBankAccountMovements.Text = "Load"
        '
        'chkIsmatching
        '
        Me.chkIsmatching.EditValue = 0
        Me.chkIsmatching.Location = New System.Drawing.Point(37, 126)
        Me.chkIsmatching.Name = "chkIsmatching"
        Me.chkIsmatching.Properties.Caption = "Open Payment"
        Me.chkIsmatching.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkIsmatching.Properties.ValueChecked = 1
        Me.chkIsmatching.Properties.ValueUnchecked = 0
        Me.chkIsmatching.Size = New System.Drawing.Size(207, 19)
        Me.chkIsmatching.TabIndex = 53
        '
        'lcEnddate
        '
        Me.lcEnddate.Location = New System.Drawing.Point(48, 64)
        Me.lcEnddate.Name = "lcEnddate"
        Me.lcEnddate.Size = New System.Drawing.Size(44, 13)
        Me.lcEnddate.TabIndex = 3
        Me.lcEnddate.Text = "End Date"
        '
        'LcStartDate
        '
        Me.LcStartDate.Location = New System.Drawing.Point(48, 32)
        Me.LcStartDate.Name = "LcStartDate"
        Me.LcStartDate.Size = New System.Drawing.Size(49, 13)
        Me.LcStartDate.TabIndex = 2
        Me.LcStartDate.Text = "start Date"
        '
        'txtEndDate
        '
        Me.txtEndDate.EditValue = Nothing
        Me.txtEndDate.Location = New System.Drawing.Point(144, 64)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEndDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtEndDate.Size = New System.Drawing.Size(100, 20)
        Me.txtEndDate.TabIndex = 1
        '
        'txtStartDate
        '
        Me.txtStartDate.EditValue = Nothing
        Me.txtStartDate.Location = New System.Drawing.Point(144, 32)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStartDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtStartDate.Size = New System.Drawing.Size(100, 20)
        Me.txtStartDate.TabIndex = 0
        '
        'GridPayment
        '
        Me.GridPayment.EmbeddedNavigator.Name = ""
        Me.GridPayment.FormsUseDefaultLookAndFeel = False
        Me.GridPayment.Location = New System.Drawing.Point(262, 421)
        Me.GridPayment.MainView = Me.GridViewPayment
        Me.GridPayment.Name = "GridPayment"
        Me.GridPayment.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GridPayment.Size = New System.Drawing.Size(921, 270)
        Me.GridPayment.TabIndex = 14
        Me.GridPayment.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPayment, Me.GridView1})
        '
        'GridViewPayment
        '
        Me.GridViewPayment.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCTypePayment, Me.GCId, Me.GCAmountPay, Me.GCDateAdded, Me.GCLastnModified, Me.GCCommunicationPay, Me.GCCustomersID, Me.GCStatus, Me.GCIdRecovery, Me.gcStatusRecovery, Me.gcIdMatching, Me.colCommunication_Recovery})
        Me.GridViewPayment.CustomizationFormBounds = New System.Drawing.Rectangle(1113, 176, 327, 364)
        Me.GridViewPayment.GridControl = Me.GridPayment
        Me.GridViewPayment.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewPayment.Name = "GridViewPayment"
        Me.GridViewPayment.OptionsSelection.MultiSelect = True
        Me.GridViewPayment.OptionsView.ColumnAutoWidth = False
        Me.GridViewPayment.OptionsView.ShowFooter = True
        '
        'GCTypePayment
        '
        Me.GCTypePayment.Caption = "type payment"
        Me.GCTypePayment.FieldName = "type_payment"
        Me.GCTypePayment.Name = "GCTypePayment"
        Me.GCTypePayment.Visible = True
        Me.GCTypePayment.VisibleIndex = 0
        Me.GCTypePayment.Width = 85
        '
        'GCId
        '
        Me.GCId.Caption = "ID"
        Me.GCId.FieldName = "id"
        Me.GCId.Name = "GCId"
        Me.GCId.OptionsColumn.AllowEdit = False
        Me.GCId.OptionsColumn.ReadOnly = True
        Me.GCId.Visible = True
        Me.GCId.VisibleIndex = 1
        '
        'GCAmountPay
        '
        Me.GCAmountPay.Caption = "amount"
        Me.GCAmountPay.DisplayFormat.FormatString = "#.00"
        Me.GCAmountPay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GCAmountPay.FieldName = "amount"
        Me.GCAmountPay.Name = "GCAmountPay"
        Me.GCAmountPay.OptionsColumn.AllowEdit = False
        Me.GCAmountPay.OptionsColumn.ReadOnly = True
        Me.GCAmountPay.Visible = True
        Me.GCAmountPay.VisibleIndex = 2
        Me.GCAmountPay.Width = 76
        '
        'GCDateAdded
        '
        Me.GCDateAdded.Caption = "date_added"
        Me.GCDateAdded.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.GCDateAdded.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GCDateAdded.FieldName = "date_added"
        Me.GCDateAdded.Name = "GCDateAdded"
        Me.GCDateAdded.OptionsColumn.AllowEdit = False
        Me.GCDateAdded.OptionsColumn.ReadOnly = True
        Me.GCDateAdded.Visible = True
        Me.GCDateAdded.VisibleIndex = 3
        Me.GCDateAdded.Width = 97
        '
        'GCLastnModified
        '
        Me.GCLastnModified.Caption = "Last modified"
        Me.GCLastnModified.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.GCLastnModified.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GCLastnModified.FieldName = "last_modified"
        Me.GCLastnModified.Name = "GCLastnModified"
        Me.GCLastnModified.OptionsColumn.AllowEdit = False
        Me.GCLastnModified.OptionsColumn.ReadOnly = True
        Me.GCLastnModified.Visible = True
        Me.GCLastnModified.VisibleIndex = 4
        '
        'GCCommunicationPay
        '
        Me.GCCommunicationPay.Caption = "communication"
        Me.GCCommunicationPay.FieldName = "communication"
        Me.GCCommunicationPay.Name = "GCCommunicationPay"
        Me.GCCommunicationPay.OptionsColumn.AllowEdit = False
        Me.GCCommunicationPay.OptionsColumn.ReadOnly = True
        Me.GCCommunicationPay.Visible = True
        Me.GCCommunicationPay.VisibleIndex = 6
        Me.GCCommunicationPay.Width = 101
        '
        'GCCustomersID
        '
        Me.GCCustomersID.Caption = "customers_id"
        Me.GCCustomersID.FieldName = "customers_id"
        Me.GCCustomersID.Name = "GCCustomersID"
        Me.GCCustomersID.OptionsColumn.AllowEdit = False
        Me.GCCustomersID.OptionsColumn.ReadOnly = True
        Me.GCCustomersID.Visible = True
        Me.GCCustomersID.VisibleIndex = 8
        Me.GCCustomersID.Width = 155
        '
        'GCStatus
        '
        Me.GCStatus.Caption = "Status"
        Me.GCStatus.FieldName = "status"
        Me.GCStatus.Name = "GCStatus"
        Me.GCStatus.OptionsColumn.AllowEdit = False
        Me.GCStatus.OptionsColumn.ReadOnly = True
        Me.GCStatus.Visible = True
        Me.GCStatus.VisibleIndex = 9
        Me.GCStatus.Width = 105
        '
        'GCIdRecovery
        '
        Me.GCIdRecovery.Caption = "id recovery"
        Me.GCIdRecovery.FieldName = "id_recovery"
        Me.GCIdRecovery.Name = "GCIdRecovery"
        Me.GCIdRecovery.OptionsColumn.AllowEdit = False
        Me.GCIdRecovery.OptionsColumn.ReadOnly = True
        Me.GCIdRecovery.Visible = True
        Me.GCIdRecovery.VisibleIndex = 10
        Me.GCIdRecovery.Width = 186
        '
        'gcStatusRecovery
        '
        Me.gcStatusRecovery.Caption = "status_recovery"
        Me.gcStatusRecovery.FieldName = "status_recovery"
        Me.gcStatusRecovery.Name = "gcStatusRecovery"
        Me.gcStatusRecovery.OptionsColumn.AllowEdit = False
        Me.gcStatusRecovery.OptionsColumn.ReadOnly = True
        Me.gcStatusRecovery.Visible = True
        Me.gcStatusRecovery.VisibleIndex = 11
        Me.gcStatusRecovery.Width = 124
        '
        'gcIdMatching
        '
        Me.gcIdMatching.Caption = "id Matching"
        Me.gcIdMatching.FieldName = "id_matching"
        Me.gcIdMatching.Name = "gcIdMatching"
        Me.gcIdMatching.OptionsColumn.AllowEdit = False
        Me.gcIdMatching.OptionsColumn.ReadOnly = True
        Me.gcIdMatching.Visible = True
        Me.gcIdMatching.VisibleIndex = 5
        Me.gcIdMatching.Width = 95
        '
        'colCommunication_Recovery
        '
        Me.colCommunication_Recovery.Caption = "Communication_Recovery"
        Me.colCommunication_Recovery.FieldName = "communication_recovery"
        Me.colCommunication_Recovery.Name = "colCommunication_Recovery"
        Me.colCommunication_Recovery.Visible = True
        Me.colCommunication_Recovery.VisibleIndex = 7
        Me.colCommunication_Recovery.Width = 109
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "name"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "id"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.GridView1.GridControl = Me.GridPayment
        Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "payment_offline_request_status_history_id"
        Me.GridColumn1.FieldName = "payment_offline_request_status_history_id"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "payment_offline_request_id"
        Me.GridColumn2.FieldName = "payment_offline_request_id"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "new_status"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn3.FieldName = "new_status"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "old_status"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn4.FieldName = "old_status"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "date_added"
        Me.GridColumn5.FieldName = "date_added"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GCPayment
        '
        Me.GCPayment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCPayment.Controls.Add(Me.txtcustomers_id)
        Me.GCPayment.Controls.Add(Me.btnLoadPayment)
        Me.GCPayment.Controls.Add(Me.LabelControl8)
        Me.GCPayment.Controls.Add(Me.checkOpenPayment)
        Me.GCPayment.Location = New System.Drawing.Point(4, 421)
        Me.GCPayment.Name = "GCPayment"
        Me.GCPayment.Size = New System.Drawing.Size(252, 253)
        Me.GCPayment.TabIndex = 54
        Me.GCPayment.Text = "Parameters Bank Account Movements"
        '
        'txtcustomers_id
        '
        Me.txtcustomers_id.Location = New System.Drawing.Point(91, 28)
        Me.txtcustomers_id.Name = "txtcustomers_id"
        Me.txtcustomers_id.Size = New System.Drawing.Size(138, 20)
        Me.txtcustomers_id.TabIndex = 56
        '
        'btnLoadPayment
        '
        Me.btnLoadPayment.Location = New System.Drawing.Point(16, 91)
        Me.btnLoadPayment.Name = "btnLoadPayment"
        Me.btnLoadPayment.Size = New System.Drawing.Size(144, 23)
        Me.btnLoadPayment.TabIndex = 55
        Me.btnLoadPayment.Text = "Load"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(16, 31)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl8.TabIndex = 54
        Me.LabelControl8.Text = "Customer ID"
        '
        'checkOpenPayment
        '
        Me.checkOpenPayment.Location = New System.Drawing.Point(13, 54)
        Me.checkOpenPayment.Name = "checkOpenPayment"
        Me.checkOpenPayment.Properties.Caption = "Open Payment"
        Me.checkOpenPayment.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.checkOpenPayment.Properties.ValueChecked = 1
        Me.checkOpenPayment.Properties.ValueUnchecked = 0
        Me.checkOpenPayment.Size = New System.Drawing.Size(216, 19)
        Me.checkOpenPayment.TabIndex = 53
        '
        'BtnReconciliation
        '
        Me.BtnReconciliation.Location = New System.Drawing.Point(35, 350)
        Me.BtnReconciliation.Name = "BtnReconciliation"
        Me.BtnReconciliation.Size = New System.Drawing.Size(144, 23)
        Me.BtnReconciliation.TabIndex = 56
        Me.BtnReconciliation.Text = "Reconciliation"
        '
        'FrmReconciliation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 766)
        Me.Controls.Add(Me.BtnReconciliation)
        Me.Controls.Add(Me.GCPayment)
        Me.Controls.Add(Me.GridPayment)
        Me.Controls.Add(Me.GCBankAccountMovements)
        Me.Controls.Add(Me.GridBankAccountMovements)
        Me.Name = "FrmReconciliation"
        Me.Text = "FrmReconciliation"
        Me.Controls.SetChildIndex(Me.GridBankAccountMovements, 0)
        Me.Controls.SetChildIndex(Me.GCBankAccountMovements, 0)
        Me.Controls.SetChildIndex(Me.GridPayment, 0)
        Me.Controls.SetChildIndex(Me.GCPayment, 0)
        Me.Controls.SetChildIndex(Me.BtnReconciliation, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOfflineRequestStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBankAccountMovements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewBankAccountMovements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCBankAccountMovements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCBankAccountMovements.ResumeLayout(False)
        Me.GCBankAccountMovements.PerformLayout()
        CType(Me.txtAccountMovement_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsmatching.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCPayment.ResumeLayout(False)
        Me.GCPayment.PerformLayout()
        CType(Me.txtcustomers_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkOpenPayment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridBankAccountMovements As DevExpress.XtraGrid.GridControl
    ' Friend WithEvents GridViewBankAccountMovements2 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents GridPayment As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridViewPayment As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCAmountPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCLastnModified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCCommunicationPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCCustomersID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcStatusRecovery As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIdMatching As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCDateAdded As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCIdRecovery As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkIsmatching As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GCPayment As DevExpress.XtraEditors.GroupControl
    Friend WithEvents checkOpenPayment As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnLoadBankAccountMovements As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoadPayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnReconciliation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColCommunication_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsmatching As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCTypePayment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtcustomers_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents txtAccountMovement_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAccountMovements_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colEntireData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommunication_Recovery As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankAccountClient As DevExpress.XtraGrid.Columns.GridColumn

End Class
