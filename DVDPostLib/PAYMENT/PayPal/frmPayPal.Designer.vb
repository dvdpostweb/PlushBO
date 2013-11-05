<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayPal
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
        Me.XtraTabPayPal = New DevExpress.XtraTab.XtraTabControl
        Me.TabResult = New DevExpress.XtraTab.XtraTabPage
        Me.GridPayPal = New DevExpress.XtraGrid.GridControl
        Me.GridViewSearch = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colPaymentID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colPaymentStatusName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colPaymentDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colPaymentAmount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colnotes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colppid = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPaymentStatusID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCommunication = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPPRequest = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPPResponse = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colMessage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbLanguages = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.chkcolAvailable = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.cmbStudio = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositorycmbSupportVod = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.cmbgridStatus = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.dpDateStart = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dtpDateExpired = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.cmbLanguagesSubtitleEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.spnedtCredit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.dpBackcatalogueStart = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dpBackcataloguExpired = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.TabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.cmbPaymentStatusSearch = New DevExpress.XtraEditors.LookUpEdit
        Me.lblToDateSearch = New DevExpress.XtraEditors.LabelControl
        Me.dtToDateSearch = New DevExpress.XtraEditors.DateEdit
        Me.lblFromDateSearch = New DevExpress.XtraEditors.LabelControl
        Me.dtFromDateSearch = New DevExpress.XtraEditors.DateEdit
        Me.txtCustomersIDSearch = New DevExpress.XtraEditors.TextEdit
        Me.lblCustomersID = New DevExpress.XtraEditors.LabelControl
        Me.lblPaymentStatus = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.TabPayment = New DevExpress.XtraTab.XtraTabPage
        Me.txtppid = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txtNote = New System.Windows.Forms.TextBox
        Me.txtLongResponse = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtShortResponse = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtResponse = New System.Windows.Forms.TextBox
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtRequest = New System.Windows.Forms.TextBox
        Me.txtMessage = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtCommunication = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtDateAdded = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.cmbPaymentStatus = New DevExpress.XtraEditors.LookUpEdit
        Me.txtCustomersID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.btnEditPayPal = New DevExpress.XtraEditors.SimpleButton
        Me.txtId = New DevExpress.XtraEditors.TextEdit
        Me.lblPaymentID = New DevExpress.XtraEditors.LabelControl
        Me.btnCancelPayPal = New DevExpress.XtraEditors.SimpleButton
        Me.btnSavePayPal = New DevExpress.XtraEditors.SimpleButton
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabPayPal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPayPal.SuspendLayout()
        Me.TabResult.SuspendLayout()
        CType(Me.GridPayPal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkcolAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositorycmbSupportVod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbgridStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpDateStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpDateStart.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateExpired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateExpired.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguagesSubtitleEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnedtCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpBackcatalogueStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpBackcatalogueStart.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpBackcataloguExpired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpBackcataloguExpired.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSearch.SuspendLayout()
        CType(Me.cmbPaymentStatusSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtToDateSearch.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtToDateSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFromDateSearch.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFromDateSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomersIDSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPayment.SuspendLayout()
        CType(Me.txtppid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLongResponse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShortResponse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCommunication.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateAdded.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPaymentStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomersID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabPayPal
        '
        Me.XtraTabPayPal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabPayPal.Location = New System.Drawing.Point(0, 30)
        Me.XtraTabPayPal.Name = "XtraTabPayPal"
        Me.XtraTabPayPal.SelectedTabPage = Me.TabResult
        Me.XtraTabPayPal.Size = New System.Drawing.Size(1160, 666)
        Me.XtraTabPayPal.TabIndex = 7
        Me.XtraTabPayPal.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabSearch, Me.TabResult, Me.TabPayment})
        '
        'TabResult
        '
        Me.TabResult.Controls.Add(Me.GridPayPal)
        Me.TabResult.Name = "TabResult"
        Me.TabResult.Size = New System.Drawing.Size(1151, 635)
        Me.TabResult.Text = "Result"
        '
        'GridPayPal
        '
        Me.GridPayPal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPayPal.EmbeddedNavigator.Name = ""
        Me.GridPayPal.FormsUseDefaultLookAndFeel = False
        Me.GridPayPal.Location = New System.Drawing.Point(0, 0)
        Me.GridPayPal.MainView = Me.GridViewSearch
        Me.GridPayPal.Name = "GridPayPal"
        Me.GridPayPal.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbLanguages, Me.chkcolAvailable, Me.cmbStudio, Me.RepositorycmbSupportVod, Me.cmbgridStatus, Me.dpDateStart, Me.dtpDateExpired, Me.cmbLanguagesSubtitleEdit, Me.RepositoryItemLookUpEdit2, Me.spnedtCredit, Me.dpBackcatalogueStart, Me.dpBackcataloguExpired, Me.RepositoryItemCheckEdit1, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6})
        Me.GridPayPal.Size = New System.Drawing.Size(1151, 635)
        Me.GridPayPal.TabIndex = 5
        Me.GridPayPal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSearch})
        '
        'GridViewSearch
        '
        Me.GridViewSearch.Appearance.FocusedRow.BackColor = System.Drawing.Color.Silver
        Me.GridViewSearch.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridViewSearch.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand3, Me.GridBand4})
        Me.GridViewSearch.ColumnPanelRowHeight = 45
        Me.GridViewSearch.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colnotes, Me.colppid, Me.colPaymentID, Me.colPaymentDate, Me.colPaymentStatusName, Me.colPaymentAmount, Me.colPaymentStatusID, Me.colCommunication, Me.colPPRequest, Me.colPPResponse, Me.colMessage})
        Me.GridViewSearch.CustomizationFormBounds = New System.Drawing.Rectangle(0, 375, 225, 209)
        Me.GridViewSearch.DetailHeight = 50
        Me.GridViewSearch.GridControl = Me.GridPayPal
        Me.GridViewSearch.Name = "GridViewSearch"
        Me.GridViewSearch.OptionsView.ColumnAutoWidth = True
        Me.GridViewSearch.OptionsView.ShowAutoFilterRow = True
        Me.GridViewSearch.OptionsView.ShowBands = False
        Me.GridViewSearch.OptionsView.ShowFooter = True
        Me.GridViewSearch.RowHeight = 33
        Me.GridViewSearch.RowSeparatorHeight = 3
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colPaymentID)
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 187
        '
        'colPaymentID
        '
        Me.colPaymentID.Caption = "PaymentID"
        Me.colPaymentID.FieldName = "id"
        Me.colPaymentID.Name = "colPaymentID"
        Me.colPaymentID.Visible = True
        Me.colPaymentID.Width = 187
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "gridBand1"
        Me.GridBand3.Columns.Add(Me.colPaymentStatusName)
        Me.GridBand3.MinWidth = 20
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 187
        '
        'colPaymentStatusName
        '
        Me.colPaymentStatusName.Caption = "Payment status"
        Me.colPaymentStatusName.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.colPaymentStatusName.FieldName = "payment_status_name"
        Me.colPaymentStatusName.Name = "colPaymentStatusName"
        Me.colPaymentStatusName.Visible = True
        Me.colPaymentStatusName.Width = 187
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "gridBand2"
        Me.GridBand4.Columns.Add(Me.colPaymentDate)
        Me.GridBand4.Columns.Add(Me.colPaymentAmount)
        Me.GridBand4.MinWidth = 20
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 376
        '
        'colPaymentDate
        '
        Me.colPaymentDate.Caption = "Payment Date"
        Me.colPaymentDate.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.colPaymentDate.FieldName = "date_added"
        Me.colPaymentDate.Name = "colPaymentDate"
        Me.colPaymentDate.Visible = True
        Me.colPaymentDate.Width = 119
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'colPaymentAmount
        '
        Me.colPaymentAmount.Caption = "Amount"
        Me.colPaymentAmount.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.colPaymentAmount.FieldName = "amount"
        Me.colPaymentAmount.Name = "colPaymentAmount"
        Me.colPaymentAmount.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPaymentAmount.OptionsColumn.AllowIncrementalSearch = False
        Me.colPaymentAmount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPaymentAmount.OptionsColumn.AllowMove = False
        Me.colPaymentAmount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPaymentAmount.Visible = True
        Me.colPaymentAmount.Width = 257
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'colnotes
        '
        Me.colnotes.Caption = "PayPal notes"
        Me.colnotes.FieldName = "notes"
        Me.colnotes.Name = "colnotes"
        Me.colnotes.Visible = True
        '
        'colppid
        '
        Me.colppid.Caption = "ppid"
        Me.colppid.FieldName = "ppid"
        Me.colppid.Name = "colppid"
        Me.colppid.Visible = True
        '
        'colPaymentStatusID
        '
        Me.colPaymentStatusID.Caption = "Payment Status ID"
        Me.colPaymentStatusID.FieldName = "payment_status"
        Me.colPaymentStatusID.Name = "colPaymentStatusID"
        Me.colPaymentStatusID.Visible = True
        '
        'colCommunication
        '
        Me.colCommunication.Caption = "Communication"
        Me.colCommunication.FieldName = "communication"
        Me.colCommunication.Name = "colCommunication"
        Me.colCommunication.Visible = True
        '
        'colPPRequest
        '
        Me.colPPRequest.Caption = "PP Request"
        Me.colPPRequest.FieldName = "pp_request"
        Me.colPPRequest.Name = "colPPRequest"
        Me.colPPRequest.Visible = True
        '
        'colPPResponse
        '
        Me.colPPResponse.Caption = "PP response"
        Me.colPPResponse.FieldName = "pp_response"
        Me.colPPResponse.Name = "colPPResponse"
        Me.colPPResponse.Visible = True
        '
        'colMessage
        '
        Me.colMessage.Caption = "Message"
        Me.colMessage.FieldName = "message"
        Me.colMessage.Name = "colMessage"
        Me.colMessage.Visible = True
        '
        'cmbLanguages
        '
        Me.cmbLanguages.AutoHeight = False
        Me.cmbLanguages.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguages.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "languages_id", 82, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 32, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbLanguages.DisplayMember = "name"
        Me.cmbLanguages.Name = "cmbLanguages"
        Me.cmbLanguages.NullText = ""
        Me.cmbLanguages.ValueMember = "languages_id"
        '
        'chkcolAvailable
        '
        Me.chkcolAvailable.AutoHeight = False
        Me.chkcolAvailable.Name = "chkcolAvailable"
        Me.chkcolAvailable.ValueChecked = CType(1, Byte)
        Me.chkcolAvailable.ValueUnchecked = CType(0, Byte)
        '
        'cmbStudio
        '
        Me.cmbStudio.AutoHeight = False
        Me.cmbStudio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStudio.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_id", "id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_name", "name", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbStudio.DisplayMember = "studio_name"
        Me.cmbStudio.Name = "cmbStudio"
        Me.cmbStudio.NullText = ""
        Me.cmbStudio.ValueMember = "studio_id"
        '
        'RepositorycmbSupportVod
        '
        Me.RepositorycmbSupportVod.AutoHeight = False
        Me.RepositorycmbSupportVod.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositorycmbSupportVod.Name = "RepositorycmbSupportVod"
        Me.RepositorycmbSupportVod.NullText = ""
        '
        'cmbgridStatus
        '
        Me.cmbgridStatus.AutoHeight = False
        Me.cmbgridStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbgridStatus.Name = "cmbgridStatus"
        '
        'dpDateStart
        '
        Me.dpDateStart.AutoHeight = False
        Me.dpDateStart.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpDateStart.Name = "dpDateStart"
        Me.dpDateStart.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'dtpDateExpired
        '
        Me.dtpDateExpired.AutoHeight = False
        Me.dtpDateExpired.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateExpired.Name = "dtpDateExpired"
        Me.dtpDateExpired.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'cmbLanguagesSubtitleEdit
        '
        Me.cmbLanguagesSubtitleEdit.AutoHeight = False
        Me.cmbLanguagesSubtitleEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguagesSubtitleEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_id", "id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "language", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbLanguagesSubtitleEdit.DisplayMember = "code"
        Me.cmbLanguagesSubtitleEdit.Name = "cmbLanguagesSubtitleEdit"
        Me.cmbLanguagesSubtitleEdit.NullText = ""
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'spnedtCredit
        '
        Me.spnedtCredit.AutoHeight = False
        Me.spnedtCredit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.spnedtCredit.MaxValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.spnedtCredit.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spnedtCredit.Name = "spnedtCredit"
        '
        'dpBackcatalogueStart
        '
        Me.dpBackcatalogueStart.AutoHeight = False
        Me.dpBackcatalogueStart.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpBackcatalogueStart.Name = "dpBackcatalogueStart"
        Me.dpBackcatalogueStart.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'dpBackcataloguExpired
        '
        Me.dpBackcataloguExpired.AutoHeight = False
        Me.dpBackcataloguExpired.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpBackcataloguExpired.Name = "dpBackcataloguExpired"
        Me.dpBackcataloguExpired.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'TabSearch
        '
        Me.TabSearch.Controls.Add(Me.cmbPaymentStatusSearch)
        Me.TabSearch.Controls.Add(Me.lblToDateSearch)
        Me.TabSearch.Controls.Add(Me.dtToDateSearch)
        Me.TabSearch.Controls.Add(Me.lblFromDateSearch)
        Me.TabSearch.Controls.Add(Me.dtFromDateSearch)
        Me.TabSearch.Controls.Add(Me.txtCustomersIDSearch)
        Me.TabSearch.Controls.Add(Me.lblCustomersID)
        Me.TabSearch.Controls.Add(Me.lblPaymentStatus)
        Me.TabSearch.Controls.Add(Me.btnSearch)
        Me.TabSearch.Name = "TabSearch"
        Me.TabSearch.Size = New System.Drawing.Size(1151, 635)
        Me.TabSearch.Text = "Search"
        '
        'cmbPaymentStatusSearch
        '
        Me.cmbPaymentStatusSearch.Location = New System.Drawing.Point(159, 75)
        Me.cmbPaymentStatusSearch.Name = "cmbPaymentStatusSearch"
        Me.cmbPaymentStatusSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPaymentStatusSearch.Properties.NullText = ""
        Me.cmbPaymentStatusSearch.Size = New System.Drawing.Size(179, 20)
        Me.cmbPaymentStatusSearch.TabIndex = 107
        '
        'lblToDateSearch
        '
        Me.lblToDateSearch.Location = New System.Drawing.Point(54, 176)
        Me.lblToDateSearch.Name = "lblToDateSearch"
        Me.lblToDateSearch.Size = New System.Drawing.Size(38, 13)
        Me.lblToDateSearch.TabIndex = 106
        Me.lblToDateSearch.Text = "To Date"
        '
        'dtToDateSearch
        '
        Me.dtToDateSearch.EditValue = Nothing
        Me.dtToDateSearch.Location = New System.Drawing.Point(159, 169)
        Me.dtToDateSearch.Name = "dtToDateSearch"
        Me.dtToDateSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtToDateSearch.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtToDateSearch.Size = New System.Drawing.Size(112, 20)
        Me.dtToDateSearch.TabIndex = 105
        '
        'lblFromDateSearch
        '
        Me.lblFromDateSearch.Location = New System.Drawing.Point(54, 129)
        Me.lblFromDateSearch.Name = "lblFromDateSearch"
        Me.lblFromDateSearch.Size = New System.Drawing.Size(50, 13)
        Me.lblFromDateSearch.TabIndex = 104
        Me.lblFromDateSearch.Text = "From Date"
        '
        'dtFromDateSearch
        '
        Me.dtFromDateSearch.EditValue = Nothing
        Me.dtFromDateSearch.Location = New System.Drawing.Point(159, 126)
        Me.dtFromDateSearch.Name = "dtFromDateSearch"
        Me.dtFromDateSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFromDateSearch.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtFromDateSearch.Size = New System.Drawing.Size(112, 20)
        Me.dtFromDateSearch.TabIndex = 103
        '
        'txtCustomersIDSearch
        '
        Me.txtCustomersIDSearch.Location = New System.Drawing.Point(159, 26)
        Me.txtCustomersIDSearch.Name = "txtCustomersIDSearch"
        Me.txtCustomersIDSearch.Size = New System.Drawing.Size(179, 20)
        Me.txtCustomersIDSearch.TabIndex = 91
        '
        'lblCustomersID
        '
        Me.lblCustomersID.Location = New System.Drawing.Point(54, 33)
        Me.lblCustomersID.Name = "lblCustomersID"
        Me.lblCustomersID.Size = New System.Drawing.Size(65, 13)
        Me.lblCustomersID.TabIndex = 90
        Me.lblCustomersID.Text = "Customers ID"
        '
        'lblPaymentStatus
        '
        Me.lblPaymentStatus.Location = New System.Drawing.Point(54, 82)
        Me.lblPaymentStatus.Name = "lblPaymentStatus"
        Me.lblPaymentStatus.Size = New System.Drawing.Size(76, 13)
        Me.lblPaymentStatus.TabIndex = 86
        Me.lblPaymentStatus.Text = "Payment Status"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(263, 261)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 83
        Me.btnSearch.Text = "Search"
        '
        'TabPayment
        '
        Me.TabPayment.Controls.Add(Me.txtppid)
        Me.TabPayment.Controls.Add(Me.LabelControl11)
        Me.TabPayment.Controls.Add(Me.txtNote)
        Me.TabPayment.Controls.Add(Me.txtLongResponse)
        Me.TabPayment.Controls.Add(Me.LabelControl10)
        Me.TabPayment.Controls.Add(Me.txtShortResponse)
        Me.TabPayment.Controls.Add(Me.LabelControl9)
        Me.TabPayment.Controls.Add(Me.LabelControl8)
        Me.TabPayment.Controls.Add(Me.txtResponse)
        Me.TabPayment.Controls.Add(Me.LabelControl7)
        Me.TabPayment.Controls.Add(Me.txtRequest)
        Me.TabPayment.Controls.Add(Me.txtMessage)
        Me.TabPayment.Controls.Add(Me.LabelControl6)
        Me.TabPayment.Controls.Add(Me.txtCommunication)
        Me.TabPayment.Controls.Add(Me.LabelControl5)
        Me.TabPayment.Controls.Add(Me.txtAmount)
        Me.TabPayment.Controls.Add(Me.LabelControl4)
        Me.TabPayment.Controls.Add(Me.txtDateAdded)
        Me.TabPayment.Controls.Add(Me.LabelControl3)
        Me.TabPayment.Controls.Add(Me.cmbPaymentStatus)
        Me.TabPayment.Controls.Add(Me.txtCustomersID)
        Me.TabPayment.Controls.Add(Me.LabelControl1)
        Me.TabPayment.Controls.Add(Me.LabelControl2)
        Me.TabPayment.Controls.Add(Me.btnEditPayPal)
        Me.TabPayment.Controls.Add(Me.txtId)
        Me.TabPayment.Controls.Add(Me.lblPaymentID)
        Me.TabPayment.Controls.Add(Me.btnCancelPayPal)
        Me.TabPayment.Controls.Add(Me.btnSavePayPal)
        Me.TabPayment.Name = "TabPayment"
        Me.TabPayment.Size = New System.Drawing.Size(1151, 635)
        Me.TabPayment.Text = "PayPal Payment"
        '
        'txtppid
        '
        Me.txtppid.Enabled = False
        Me.txtppid.Location = New System.Drawing.Point(466, 21)
        Me.txtppid.Name = "txtppid"
        Me.txtppid.Size = New System.Drawing.Size(112, 20)
        Me.txtppid.TabIndex = 152
        Me.txtppid.Visible = False
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(39, 380)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl11.TabIndex = 151
        Me.LabelControl11.Text = "PayPal 's Notes"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(39, 412)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNote.Size = New System.Drawing.Size(333, 217)
        Me.txtNote.TabIndex = 150
        '
        'txtLongResponse
        '
        Me.txtLongResponse.Location = New System.Drawing.Point(547, 403)
        Me.txtLongResponse.Name = "txtLongResponse"
        Me.txtLongResponse.Properties.ReadOnly = True
        Me.txtLongResponse.Size = New System.Drawing.Size(594, 20)
        Me.txtLongResponse.TabIndex = 149
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(493, 406)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl10.TabIndex = 148
        Me.LabelControl10.Text = "Long msg"
        '
        'txtShortResponse
        '
        Me.txtShortResponse.Location = New System.Drawing.Point(547, 377)
        Me.txtShortResponse.Name = "txtShortResponse"
        Me.txtShortResponse.Properties.ReadOnly = True
        Me.txtShortResponse.Size = New System.Drawing.Size(263, 20)
        Me.txtShortResponse.TabIndex = 147
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(493, 380)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl9.TabIndex = 146
        Me.LabelControl9.Text = "Short msg"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(381, 380)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl8.TabIndex = 145
        Me.LabelControl8.Text = "PayPal Response"
        '
        'txtResponse
        '
        Me.txtResponse.Location = New System.Drawing.Point(489, 432)
        Me.txtResponse.Multiline = True
        Me.txtResponse.Name = "txtResponse"
        Me.txtResponse.ReadOnly = True
        Me.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResponse.Size = New System.Drawing.Size(652, 197)
        Me.txtResponse.TabIndex = 144
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(381, 138)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl7.TabIndex = 143
        Me.LabelControl7.Text = "PayPal  Request"
        '
        'txtRequest
        '
        Me.txtRequest.Location = New System.Drawing.Point(489, 138)
        Me.txtRequest.Multiline = True
        Me.txtRequest.Name = "txtRequest"
        Me.txtRequest.ReadOnly = True
        Me.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRequest.Size = New System.Drawing.Size(652, 220)
        Me.txtRequest.TabIndex = 142
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(489, 85)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Properties.ReadOnly = True
        Me.txtMessage.Size = New System.Drawing.Size(656, 20)
        Me.txtMessage.TabIndex = 141
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(381, 92)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl6.TabIndex = 140
        Me.LabelControl6.Text = "Message"
        '
        'txtCommunication
        '
        Me.txtCommunication.Location = New System.Drawing.Point(166, 316)
        Me.txtCommunication.Name = "txtCommunication"
        Me.txtCommunication.Size = New System.Drawing.Size(179, 20)
        Me.txtCommunication.TabIndex = 139
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(61, 323)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl5.TabIndex = 138
        Me.LabelControl5.Text = "Communication"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(166, 266)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(179, 20)
        Me.txtAmount.TabIndex = 137
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(61, 273)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl4.TabIndex = 136
        Me.LabelControl4.Text = "Amount"
        '
        'txtDateAdded
        '
        Me.txtDateAdded.Location = New System.Drawing.Point(166, 221)
        Me.txtDateAdded.Name = "txtDateAdded"
        Me.txtDateAdded.Size = New System.Drawing.Size(179, 20)
        Me.txtDateAdded.TabIndex = 135
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(61, 228)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl3.TabIndex = 134
        Me.LabelControl3.Text = "Date Added"
        '
        'cmbPaymentStatus
        '
        Me.cmbPaymentStatus.Location = New System.Drawing.Point(166, 180)
        Me.cmbPaymentStatus.Name = "cmbPaymentStatus"
        Me.cmbPaymentStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPaymentStatus.Properties.NullText = ""
        Me.cmbPaymentStatus.Size = New System.Drawing.Size(179, 20)
        Me.cmbPaymentStatus.TabIndex = 133
        '
        'txtCustomersID
        '
        Me.txtCustomersID.Location = New System.Drawing.Point(166, 131)
        Me.txtCustomersID.Name = "txtCustomersID"
        Me.txtCustomersID.Size = New System.Drawing.Size(179, 20)
        Me.txtCustomersID.TabIndex = 132
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(61, 138)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl1.TabIndex = 131
        Me.LabelControl1.Text = "Customers ID"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(61, 187)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl2.TabIndex = 130
        Me.LabelControl2.Text = "Payment Status"
        '
        'btnEditPayPal
        '
        Me.btnEditPayPal.Enabled = False
        Me.btnEditPayPal.Location = New System.Drawing.Point(151, 33)
        Me.btnEditPayPal.Name = "btnEditPayPal"
        Me.btnEditPayPal.Size = New System.Drawing.Size(79, 23)
        Me.btnEditPayPal.TabIndex = 129
        Me.btnEditPayPal.Text = "Edit"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(166, 89)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(112, 20)
        Me.txtId.TabIndex = 110
        '
        'lblPaymentID
        '
        Me.lblPaymentID.Location = New System.Drawing.Point(61, 92)
        Me.lblPaymentID.Name = "lblPaymentID"
        Me.lblPaymentID.Size = New System.Drawing.Size(56, 13)
        Me.lblPaymentID.TabIndex = 109
        Me.lblPaymentID.Text = "Payment ID"
        '
        'btnCancelPayPal
        '
        Me.btnCancelPayPal.Enabled = False
        Me.btnCancelPayPal.Location = New System.Drawing.Point(252, 33)
        Me.btnCancelPayPal.Name = "btnCancelPayPal"
        Me.btnCancelPayPal.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelPayPal.TabIndex = 108
        Me.btnCancelPayPal.Text = "Cancel"
        '
        'btnSavePayPal
        '
        Me.btnSavePayPal.Enabled = False
        Me.btnSavePayPal.Location = New System.Drawing.Point(55, 33)
        Me.btnSavePayPal.Name = "btnSavePayPal"
        Me.btnSavePayPal.Size = New System.Drawing.Size(75, 23)
        Me.btnSavePayPal.TabIndex = 104
        Me.btnSavePayPal.Text = "Save"
        '
        'frmPayPal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 696)
        Me.Controls.Add(Me.XtraTabPayPal)
        Me.Name = "frmPayPal"
        Me.Text = "frmPayPal"
        Me.Controls.SetChildIndex(Me.XtraTabPayPal, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabPayPal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPayPal.ResumeLayout(False)
        Me.TabResult.ResumeLayout(False)
        CType(Me.GridPayPal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkcolAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositorycmbSupportVod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbgridStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpDateStart.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpDateStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateExpired.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateExpired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguagesSubtitleEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnedtCredit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpBackcatalogueStart.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpBackcatalogueStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpBackcataloguExpired.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpBackcataloguExpired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSearch.ResumeLayout(False)
        Me.TabSearch.PerformLayout()
        CType(Me.cmbPaymentStatusSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtToDateSearch.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtToDateSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFromDateSearch.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFromDateSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomersIDSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPayment.ResumeLayout(False)
        Me.TabPayment.PerformLayout()
        CType(Me.txtppid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLongResponse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShortResponse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCommunication.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateAdded.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPaymentStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomersID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabPayPal As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabResult As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridPayPal As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSearch As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colPaymentID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colPaymentStatusName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colPaymentDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colPaymentAmount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cmbLanguages As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents chkcolAvailable As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cmbStudio As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositorycmbSupportVod As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbgridStatus As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents dpDateStart As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtpDateExpired As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents cmbLanguagesSubtitleEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents spnedtCredit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents dpBackcatalogueStart As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dpBackcataloguExpired As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents TabSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblToDateSearch As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtToDateSearch As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFromDateSearch As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFromDateSearch As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCustomersIDSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCustomersID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPaymentStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TabPayment As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnEditPayPal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPaymentID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancelPayPal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSavePayPal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbPaymentStatusSearch As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbPaymentStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtCustomersID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCommunication As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateAdded As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMessage As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtResponse As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRequest As System.Windows.Forms.TextBox
    Friend WithEvents colPaymentStatusID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCommunication As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPPRequest As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPPResponse As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMessage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents txtShortResponse As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLongResponse As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents colnotes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colppid As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents txtppid As DevExpress.XtraEditors.TextEdit
End Class
