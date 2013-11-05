Imports System.IO
Imports System.Collections.Generic

Public Class frmInvoice
    Inherits BizzLib.frmBKForm

    Private Sub InitializeComponent()
        Dim GridViewInvoiceItems As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colDVDTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDVDQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colDVDUnitPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colDVDTotal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridInvoiceItems = New DevExpress.XtraGrid.GridControl
        Me.cmbSoundTracks = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabInvoice = New DevExpress.XtraTab.XtraTabControl
        Me.TabResult = New DevExpress.XtraTab.XtraTabPage
        Me.GridInvoices = New DevExpress.XtraGrid.GridControl
        Me.GridViewSearch = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colSupplierName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colSupplierInvoceNumber = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colInvoiceDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colInvoiceTotal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
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
        Me.lblToDateSearch = New DevExpress.XtraEditors.LabelControl
        Me.dtToDateSearch = New DevExpress.XtraEditors.DateEdit
        Me.lblFromDateSearch = New DevExpress.XtraEditors.LabelControl
        Me.dtFromDateSearch = New DevExpress.XtraEditors.DateEdit
        Me.txtDVDTitleSearch = New DevExpress.XtraEditors.TextEdit
        Me.lblDVDTitleSearch = New DevExpress.XtraEditors.LabelControl
        Me.txtSupplierNameSearch = New DevExpress.XtraEditors.TextEdit
        Me.lblSupplierNameSearch = New DevExpress.XtraEditors.LabelControl
        Me.txtInvoiceNumberSearch = New DevExpress.XtraEditors.TextEdit
        Me.lblInvoiceNumberSearch = New DevExpress.XtraEditors.LabelControl
        Me.BtnViewAll = New DevExpress.XtraEditors.SimpleButton
        Me.BtnNewInvoice = New DevExpress.XtraEditors.SimpleButton
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.TabInvoice = New DevExpress.XtraTab.XtraTabPage
        Me.txtInvoiceTotal = New DevExpress.XtraEditors.TextEdit
        Me.lblInvoiceTotal = New DevExpress.XtraEditors.LabelControl
        Me.txtDVDPostAccountingInvoiceNumber = New DevExpress.XtraEditors.TextEdit
        Me.dtInvoiceDate = New DevExpress.XtraEditors.DateEdit
        Me.btnEditInvoice = New DevExpress.XtraEditors.SimpleButton
        Me.txtSupplierInvoiceNumber = New DevExpress.XtraEditors.TextEdit
        Me.lblDVDPostAccountingInvoiceNumber = New DevExpress.XtraEditors.LabelControl
        Me.btnDeleteInvoice = New DevExpress.XtraEditors.SimpleButton
        Me.lblSupplierInvoiceNumber = New DevExpress.XtraEditors.LabelControl
        Me.lblSuplierName = New DevExpress.XtraEditors.LabelControl
        Me.txtId = New DevExpress.XtraEditors.TextEdit
        Me.lblInvoiceID = New DevExpress.XtraEditors.LabelControl
        Me.btnCancelInvoice = New DevExpress.XtraEditors.SimpleButton
        Me.txtSupplierName = New DevExpress.XtraEditors.TextEdit
        Me.lblInvoiceDate = New DevExpress.XtraEditors.LabelControl
        Me.btnSaveInvoice = New DevExpress.XtraEditors.SimpleButton
        GridViewInvoiceItems = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(GridViewInvoiceItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridInvoiceItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSoundTracks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabInvoice.SuspendLayout()
        Me.TabResult.SuspendLayout()
        CType(Me.GridInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.dtToDateSearch.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtToDateSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFromDateSearch.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFromDateSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVDTitleSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplierNameSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceNumberSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabInvoice.SuspendLayout()
        CType(Me.txtInvoiceTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVDPostAccountingInvoiceNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInvoiceDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInvoiceDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplierInvoiceNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplierName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridViewInvoiceItems
        '
        GridViewInvoiceItems.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand8})
        GridViewInvoiceItems.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colDVDTitle, Me.colDVDQuantity, Me.colDVDUnitPrice, Me.colDVDTotal})
        GridViewInvoiceItems.CustomizationFormBounds = New System.Drawing.Rectangle(755, 333, 217, 222)
        GridViewInvoiceItems.GridControl = Me.GridInvoiceItems
        GridViewInvoiceItems.Name = "GridViewInvoiceItems"
        GridViewInvoiceItems.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValesMode.Disabled
        GridViewInvoiceItems.OptionsNavigation.AutoFocusNewRow = True
        GridViewInvoiceItems.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        GridViewInvoiceItems.OptionsView.ShowBands = False
        GridViewInvoiceItems.OptionsView.ShowDetailButtons = False
        GridViewInvoiceItems.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        GridViewInvoiceItems.OptionsView.ShowGroupPanel = False
        GridViewInvoiceItems.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDVDTitle, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridBand8
        '
        Me.GridBand8.Caption = "gridBand1"
        Me.GridBand8.Columns.Add(Me.colDVDTitle)
        Me.GridBand8.Columns.Add(Me.colDVDQuantity)
        Me.GridBand8.Columns.Add(Me.colDVDUnitPrice)
        Me.GridBand8.Columns.Add(Me.colDVDTotal)
        Me.GridBand8.MinWidth = 20
        Me.GridBand8.Name = "GridBand8"
        Me.GridBand8.Width = 526
        '
        'colDVDTitle
        '
        Me.colDVDTitle.Caption = "DVD Title"
        Me.colDVDTitle.FieldName = "dvd_title"
        Me.colDVDTitle.Name = "colDVDTitle"
        Me.colDVDTitle.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDVDTitle.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDVDTitle.OptionsColumn.AllowMove = False
        Me.colDVDTitle.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colDVDTitle.Visible = True
        Me.colDVDTitle.Width = 253
        '
        'colDVDQuantity
        '
        Me.colDVDQuantity.Caption = "DVD Quantity"
        Me.colDVDQuantity.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colDVDQuantity.FieldName = "dvd_quantity"
        Me.colDVDQuantity.Name = "colDVDQuantity"
        Me.colDVDQuantity.Visible = True
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colDVDUnitPrice
        '
        Me.colDVDUnitPrice.Caption = "DVD Unit Price"
        Me.colDVDUnitPrice.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colDVDUnitPrice.FieldName = "dvd_unit_price"
        Me.colDVDUnitPrice.Name = "colDVDUnitPrice"
        Me.colDVDUnitPrice.Visible = True
        Me.colDVDUnitPrice.Width = 103
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'colDVDTotal
        '
        Me.colDVDTotal.Caption = "DVD Total"
        Me.colDVDTotal.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colDVDTotal.FieldName = "dvd_total"
        Me.colDVDTotal.Name = "colDVDTotal"
        Me.colDVDTotal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDVDTotal.Visible = True
        Me.colDVDTotal.Width = 95
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'GridInvoiceItems
        '
        Me.GridInvoiceItems.AllowDrop = True
        Me.GridInvoiceItems.EmbeddedNavigator.AllowDrop = True
        Me.GridInvoiceItems.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridInvoiceItems.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridInvoiceItems.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridInvoiceItems.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridInvoiceItems.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridInvoiceItems.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridInvoiceItems.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridInvoiceItems.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridInvoiceItems.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridInvoiceItems.EmbeddedNavigator.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.GridInvoiceItems.EmbeddedNavigator.Name = ""
        Me.GridInvoiceItems.FormsUseDefaultLookAndFeel = False
        Me.GridInvoiceItems.Location = New System.Drawing.Point(556, 95)
        Me.GridInvoiceItems.MainView = GridViewInvoiceItems
        Me.GridInvoiceItems.Name = "GridInvoiceItems"
        Me.GridInvoiceItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbSoundTracks, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3})
        Me.GridInvoiceItems.Size = New System.Drawing.Size(589, 350)
        Me.GridInvoiceItems.TabIndex = 137
        Me.GridInvoiceItems.UseEmbeddedNavigator = True
        Me.GridInvoiceItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {GridViewInvoiceItems})
        '
        'cmbSoundTracks
        '
        Me.cmbSoundTracks.AutoHeight = False
        Me.cmbSoundTracks.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSoundTracks.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("soundtracks_id", "soundtracks_id", 91, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("soundtracks_description", "soundtracks_description", 116, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbSoundTracks.DisplayMember = "soundtracks_description"
        Me.cmbSoundTracks.Name = "cmbSoundTracks"
        Me.cmbSoundTracks.NullText = "NEW Line"
        Me.cmbSoundTracks.ValueMember = "soundtracks_id"
        '
        'XtraTabInvoice
        '
        Me.XtraTabInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabInvoice.Location = New System.Drawing.Point(0, 30)
        Me.XtraTabInvoice.Name = "XtraTabInvoice"
        Me.XtraTabInvoice.SelectedTabPage = Me.TabResult
        Me.XtraTabInvoice.Size = New System.Drawing.Size(1160, 538)
        Me.XtraTabInvoice.TabIndex = 6
        Me.XtraTabInvoice.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabSearch, Me.TabResult, Me.TabInvoice})
        '
        'TabResult
        '
        Me.TabResult.Controls.Add(Me.GridInvoices)
        Me.TabResult.Name = "TabResult"
        Me.TabResult.Size = New System.Drawing.Size(1151, 507)
        Me.TabResult.Text = "Result"
        '
        'GridInvoices
        '
        Me.GridInvoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridInvoices.EmbeddedNavigator.Name = ""
        Me.GridInvoices.FormsUseDefaultLookAndFeel = False
        Me.GridInvoices.Location = New System.Drawing.Point(0, 0)
        Me.GridInvoices.MainView = Me.GridViewSearch
        Me.GridInvoices.Name = "GridInvoices"
        Me.GridInvoices.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbLanguages, Me.chkcolAvailable, Me.cmbStudio, Me.RepositorycmbSupportVod, Me.cmbgridStatus, Me.dpDateStart, Me.dtpDateExpired, Me.cmbLanguagesSubtitleEdit, Me.RepositoryItemLookUpEdit2, Me.spnedtCredit, Me.dpBackcatalogueStart, Me.dpBackcataloguExpired, Me.RepositoryItemCheckEdit1, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6})
        Me.GridInvoices.Size = New System.Drawing.Size(1151, 507)
        Me.GridInvoices.TabIndex = 5
        Me.GridInvoices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSearch})
        '
        'GridViewSearch
        '
        Me.GridViewSearch.Appearance.FocusedRow.BackColor = System.Drawing.Color.Silver
        Me.GridViewSearch.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridViewSearch.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand3, Me.GridBand4})
        Me.GridViewSearch.ColumnPanelRowHeight = 45
        Me.GridViewSearch.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colSupplierName, Me.colInvoiceDate, Me.colSupplierInvoceNumber, Me.colInvoiceTotal})
        Me.GridViewSearch.CustomizationFormBounds = New System.Drawing.Rectangle(0, 375, 225, 209)
        Me.GridViewSearch.DetailHeight = 50
        Me.GridViewSearch.GridControl = Me.GridInvoices
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
        Me.GridBand1.Columns.Add(Me.colSupplierName)
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 187
        '
        'colSupplierName
        '
        Me.colSupplierName.Caption = "Supplier Name"
        Me.colSupplierName.FieldName = "supplier_name"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.Width = 187
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "gridBand1"
        Me.GridBand3.Columns.Add(Me.colSupplierInvoceNumber)
        Me.GridBand3.MinWidth = 20
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 187
        '
        'colSupplierInvoceNumber
        '
        Me.colSupplierInvoceNumber.Caption = "Supplier Invoce Number"
        Me.colSupplierInvoceNumber.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.colSupplierInvoceNumber.FieldName = "supplier_invoice_number"
        Me.colSupplierInvoceNumber.Name = "colSupplierInvoceNumber"
        Me.colSupplierInvoceNumber.Visible = True
        Me.colSupplierInvoceNumber.Width = 187
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
        Me.GridBand4.Columns.Add(Me.colInvoiceDate)
        Me.GridBand4.Columns.Add(Me.colInvoiceTotal)
        Me.GridBand4.MinWidth = 20
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 376
        '
        'colInvoiceDate
        '
        Me.colInvoiceDate.Caption = "Invoice Date"
        Me.colInvoiceDate.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.colInvoiceDate.FieldName = "invoice_date"
        Me.colInvoiceDate.Name = "colInvoiceDate"
        Me.colInvoiceDate.Visible = True
        Me.colInvoiceDate.Width = 119
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'colInvoiceTotal
        '
        Me.colInvoiceTotal.Caption = "InvoiceTotal"
        Me.colInvoiceTotal.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.colInvoiceTotal.FieldName = "invoice_total"
        Me.colInvoiceTotal.Name = "colInvoiceTotal"
        Me.colInvoiceTotal.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colInvoiceTotal.OptionsColumn.AllowIncrementalSearch = False
        Me.colInvoiceTotal.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colInvoiceTotal.OptionsColumn.AllowMove = False
        Me.colInvoiceTotal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colInvoiceTotal.Visible = True
        Me.colInvoiceTotal.Width = 257
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
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
        Me.TabSearch.Controls.Add(Me.lblToDateSearch)
        Me.TabSearch.Controls.Add(Me.dtToDateSearch)
        Me.TabSearch.Controls.Add(Me.lblFromDateSearch)
        Me.TabSearch.Controls.Add(Me.dtFromDateSearch)
        Me.TabSearch.Controls.Add(Me.txtDVDTitleSearch)
        Me.TabSearch.Controls.Add(Me.lblDVDTitleSearch)
        Me.TabSearch.Controls.Add(Me.txtSupplierNameSearch)
        Me.TabSearch.Controls.Add(Me.lblSupplierNameSearch)
        Me.TabSearch.Controls.Add(Me.txtInvoiceNumberSearch)
        Me.TabSearch.Controls.Add(Me.lblInvoiceNumberSearch)
        Me.TabSearch.Controls.Add(Me.BtnViewAll)
        Me.TabSearch.Controls.Add(Me.BtnNewInvoice)
        Me.TabSearch.Controls.Add(Me.btnSearch)
        Me.TabSearch.Name = "TabSearch"
        Me.TabSearch.Size = New System.Drawing.Size(1151, 507)
        Me.TabSearch.Text = "Search"
        '
        'lblToDateSearch
        '
        Me.lblToDateSearch.Location = New System.Drawing.Point(54, 217)
        Me.lblToDateSearch.Name = "lblToDateSearch"
        Me.lblToDateSearch.Size = New System.Drawing.Size(38, 13)
        Me.lblToDateSearch.TabIndex = 106
        Me.lblToDateSearch.Text = "To Date"
        '
        'dtToDateSearch
        '
        Me.dtToDateSearch.EditValue = Nothing
        Me.dtToDateSearch.Location = New System.Drawing.Point(159, 210)
        Me.dtToDateSearch.Name = "dtToDateSearch"
        Me.dtToDateSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtToDateSearch.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtToDateSearch.Size = New System.Drawing.Size(112, 20)
        Me.dtToDateSearch.TabIndex = 105
        '
        'lblFromDateSearch
        '
        Me.lblFromDateSearch.Location = New System.Drawing.Point(54, 170)
        Me.lblFromDateSearch.Name = "lblFromDateSearch"
        Me.lblFromDateSearch.Size = New System.Drawing.Size(50, 13)
        Me.lblFromDateSearch.TabIndex = 104
        Me.lblFromDateSearch.Text = "From Date"
        '
        'dtFromDateSearch
        '
        Me.dtFromDateSearch.EditValue = Nothing
        Me.dtFromDateSearch.Location = New System.Drawing.Point(159, 167)
        Me.dtFromDateSearch.Name = "dtFromDateSearch"
        Me.dtFromDateSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFromDateSearch.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtFromDateSearch.Size = New System.Drawing.Size(112, 20)
        Me.dtFromDateSearch.TabIndex = 103
        '
        'txtDVDTitleSearch
        '
        Me.txtDVDTitleSearch.Location = New System.Drawing.Point(159, 121)
        Me.txtDVDTitleSearch.Name = "txtDVDTitleSearch"
        Me.txtDVDTitleSearch.Size = New System.Drawing.Size(179, 20)
        Me.txtDVDTitleSearch.TabIndex = 93
        '
        'lblDVDTitleSearch
        '
        Me.lblDVDTitleSearch.Location = New System.Drawing.Point(54, 128)
        Me.lblDVDTitleSearch.Name = "lblDVDTitleSearch"
        Me.lblDVDTitleSearch.Size = New System.Drawing.Size(43, 13)
        Me.lblDVDTitleSearch.TabIndex = 92
        Me.lblDVDTitleSearch.Text = "DVD Title"
        '
        'txtSupplierNameSearch
        '
        Me.txtSupplierNameSearch.Location = New System.Drawing.Point(159, 26)
        Me.txtSupplierNameSearch.Name = "txtSupplierNameSearch"
        Me.txtSupplierNameSearch.Size = New System.Drawing.Size(179, 20)
        Me.txtSupplierNameSearch.TabIndex = 91
        '
        'lblSupplierNameSearch
        '
        Me.lblSupplierNameSearch.Location = New System.Drawing.Point(54, 33)
        Me.lblSupplierNameSearch.Name = "lblSupplierNameSearch"
        Me.lblSupplierNameSearch.Size = New System.Drawing.Size(67, 13)
        Me.lblSupplierNameSearch.TabIndex = 90
        Me.lblSupplierNameSearch.Text = "Supplier name"
        '
        'txtInvoiceNumberSearch
        '
        Me.txtInvoiceNumberSearch.Location = New System.Drawing.Point(159, 75)
        Me.txtInvoiceNumberSearch.Name = "txtInvoiceNumberSearch"
        Me.txtInvoiceNumberSearch.Size = New System.Drawing.Size(179, 20)
        Me.txtInvoiceNumberSearch.TabIndex = 89
        '
        'lblInvoiceNumberSearch
        '
        Me.lblInvoiceNumberSearch.Location = New System.Drawing.Point(54, 82)
        Me.lblInvoiceNumberSearch.Name = "lblInvoiceNumberSearch"
        Me.lblInvoiceNumberSearch.Size = New System.Drawing.Size(74, 13)
        Me.lblInvoiceNumberSearch.TabIndex = 86
        Me.lblInvoiceNumberSearch.Text = "Invoice number"
        '
        'BtnViewAll
        '
        Me.BtnViewAll.Location = New System.Drawing.Point(327, 268)
        Me.BtnViewAll.Name = "BtnViewAll"
        Me.BtnViewAll.Size = New System.Drawing.Size(75, 23)
        Me.BtnViewAll.TabIndex = 85
        Me.BtnViewAll.Text = "View all"
        '
        'BtnNewInvoice
        '
        Me.BtnNewInvoice.Location = New System.Drawing.Point(186, 268)
        Me.BtnNewInvoice.Name = "BtnNewInvoice"
        Me.BtnNewInvoice.Size = New System.Drawing.Size(75, 23)
        Me.BtnNewInvoice.TabIndex = 84
        Me.BtnNewInvoice.Text = "New"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(48, 268)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 83
        Me.btnSearch.Text = "Search"
        '
        'TabInvoice
        '
        Me.TabInvoice.Controls.Add(Me.GridInvoiceItems)
        Me.TabInvoice.Controls.Add(Me.txtInvoiceTotal)
        Me.TabInvoice.Controls.Add(Me.lblInvoiceTotal)
        Me.TabInvoice.Controls.Add(Me.txtDVDPostAccountingInvoiceNumber)
        Me.TabInvoice.Controls.Add(Me.dtInvoiceDate)
        Me.TabInvoice.Controls.Add(Me.btnEditInvoice)
        Me.TabInvoice.Controls.Add(Me.txtSupplierInvoiceNumber)
        Me.TabInvoice.Controls.Add(Me.lblDVDPostAccountingInvoiceNumber)
        Me.TabInvoice.Controls.Add(Me.btnDeleteInvoice)
        Me.TabInvoice.Controls.Add(Me.lblSupplierInvoiceNumber)
        Me.TabInvoice.Controls.Add(Me.lblSuplierName)
        Me.TabInvoice.Controls.Add(Me.txtId)
        Me.TabInvoice.Controls.Add(Me.lblInvoiceID)
        Me.TabInvoice.Controls.Add(Me.btnCancelInvoice)
        Me.TabInvoice.Controls.Add(Me.txtSupplierName)
        Me.TabInvoice.Controls.Add(Me.lblInvoiceDate)
        Me.TabInvoice.Controls.Add(Me.btnSaveInvoice)
        Me.TabInvoice.Name = "TabInvoice"
        Me.TabInvoice.Size = New System.Drawing.Size(1151, 507)
        Me.TabInvoice.Text = "Invoice"
        '
        'txtInvoiceTotal
        '
        Me.txtInvoiceTotal.Enabled = False
        Me.txtInvoiceTotal.Location = New System.Drawing.Point(240, 306)
        Me.txtInvoiceTotal.Name = "txtInvoiceTotal"
        Me.txtInvoiceTotal.Properties.Mask.EditMask = "n2"
        Me.txtInvoiceTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtInvoiceTotal.Size = New System.Drawing.Size(146, 20)
        Me.txtInvoiceTotal.TabIndex = 136
        '
        'lblInvoiceTotal
        '
        Me.lblInvoiceTotal.Location = New System.Drawing.Point(55, 313)
        Me.lblInvoiceTotal.Name = "lblInvoiceTotal"
        Me.lblInvoiceTotal.Size = New System.Drawing.Size(62, 13)
        Me.lblInvoiceTotal.TabIndex = 135
        Me.lblInvoiceTotal.Text = "Invoice Total"
        '
        'txtDVDPostAccountingInvoiceNumber
        '
        Me.txtDVDPostAccountingInvoiceNumber.Enabled = False
        Me.txtDVDPostAccountingInvoiceNumber.Location = New System.Drawing.Point(240, 258)
        Me.txtDVDPostAccountingInvoiceNumber.Name = "txtDVDPostAccountingInvoiceNumber"
        Me.txtDVDPostAccountingInvoiceNumber.Size = New System.Drawing.Size(282, 20)
        Me.txtDVDPostAccountingInvoiceNumber.TabIndex = 133
        '
        'dtInvoiceDate
        '
        Me.dtInvoiceDate.EditValue = Nothing
        Me.dtInvoiceDate.Location = New System.Drawing.Point(240, 171)
        Me.dtInvoiceDate.Name = "dtInvoiceDate"
        Me.dtInvoiceDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtInvoiceDate.Size = New System.Drawing.Size(146, 20)
        Me.dtInvoiceDate.TabIndex = 132
        '
        'btnEditInvoice
        '
        Me.btnEditInvoice.Enabled = False
        Me.btnEditInvoice.Location = New System.Drawing.Point(151, 48)
        Me.btnEditInvoice.Name = "btnEditInvoice"
        Me.btnEditInvoice.Size = New System.Drawing.Size(79, 23)
        Me.btnEditInvoice.TabIndex = 129
        Me.btnEditInvoice.Text = "Edit"
        '
        'txtSupplierInvoiceNumber
        '
        Me.txtSupplierInvoiceNumber.Enabled = False
        Me.txtSupplierInvoiceNumber.Location = New System.Drawing.Point(240, 213)
        Me.txtSupplierInvoiceNumber.Name = "txtSupplierInvoiceNumber"
        Me.txtSupplierInvoiceNumber.Size = New System.Drawing.Size(282, 20)
        Me.txtSupplierInvoiceNumber.TabIndex = 121
        '
        'lblDVDPostAccountingInvoiceNumber
        '
        Me.lblDVDPostAccountingInvoiceNumber.Location = New System.Drawing.Point(55, 265)
        Me.lblDVDPostAccountingInvoiceNumber.Name = "lblDVDPostAccountingInvoiceNumber"
        Me.lblDVDPostAccountingInvoiceNumber.Size = New System.Drawing.Size(175, 13)
        Me.lblDVDPostAccountingInvoiceNumber.TabIndex = 116
        Me.lblDVDPostAccountingInvoiceNumber.Text = "DVDPost Accounting Invoice Number"
        '
        'btnDeleteInvoice
        '
        Me.btnDeleteInvoice.Enabled = False
        Me.btnDeleteInvoice.Location = New System.Drawing.Point(354, 48)
        Me.btnDeleteInvoice.Name = "btnDeleteInvoice"
        Me.btnDeleteInvoice.Size = New System.Drawing.Size(79, 23)
        Me.btnDeleteInvoice.TabIndex = 114
        Me.btnDeleteInvoice.Text = "Delete"
        '
        'lblSupplierInvoiceNumber
        '
        Me.lblSupplierInvoiceNumber.Location = New System.Drawing.Point(55, 213)
        Me.lblSupplierInvoiceNumber.Name = "lblSupplierInvoiceNumber"
        Me.lblSupplierInvoiceNumber.Size = New System.Drawing.Size(110, 13)
        Me.lblSupplierInvoiceNumber.TabIndex = 113
        Me.lblSupplierInvoiceNumber.Text = "Suplier Invoice Number"
        '
        'lblSuplierName
        '
        Me.lblSuplierName.Location = New System.Drawing.Point(55, 135)
        Me.lblSuplierName.Name = "lblSuplierName"
        Me.lblSuplierName.Size = New System.Drawing.Size(62, 13)
        Me.lblSuplierName.TabIndex = 111
        Me.lblSuplierName.Text = "Suplier Name"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(240, 95)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(112, 20)
        Me.txtId.TabIndex = 110
        '
        'lblInvoiceID
        '
        Me.lblInvoiceID.Location = New System.Drawing.Point(120, 95)
        Me.lblInvoiceID.Name = "lblInvoiceID"
        Me.lblInvoiceID.Size = New System.Drawing.Size(11, 13)
        Me.lblInvoiceID.TabIndex = 109
        Me.lblInvoiceID.Text = "ID"
        '
        'btnCancelInvoice
        '
        Me.btnCancelInvoice.Enabled = False
        Me.btnCancelInvoice.Location = New System.Drawing.Point(252, 48)
        Me.btnCancelInvoice.Name = "btnCancelInvoice"
        Me.btnCancelInvoice.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelInvoice.TabIndex = 108
        Me.btnCancelInvoice.Text = "Cancel"
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Enabled = False
        Me.txtSupplierName.Location = New System.Drawing.Point(240, 131)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(282, 20)
        Me.txtSupplierName.TabIndex = 106
        '
        'lblInvoiceDate
        '
        Me.lblInvoiceDate.Location = New System.Drawing.Point(55, 171)
        Me.lblInvoiceDate.Name = "lblInvoiceDate"
        Me.lblInvoiceDate.Size = New System.Drawing.Size(61, 13)
        Me.lblInvoiceDate.TabIndex = 105
        Me.lblInvoiceDate.Text = "Invoice Date"
        '
        'btnSaveInvoice
        '
        Me.btnSaveInvoice.Enabled = False
        Me.btnSaveInvoice.Location = New System.Drawing.Point(55, 48)
        Me.btnSaveInvoice.Name = "btnSaveInvoice"
        Me.btnSaveInvoice.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveInvoice.TabIndex = 104
        Me.btnSaveInvoice.Text = "Save"
        '
        'frmInvoice
        '
        Me.ClientSize = New System.Drawing.Size(1160, 568)
        Me.Controls.Add(Me.XtraTabInvoice)
        Me.Name = "frmInvoice"
        Me.Controls.SetChildIndex(Me.XtraTabInvoice, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(GridViewInvoiceItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridInvoiceItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSoundTracks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabInvoice.ResumeLayout(False)
        Me.TabResult.ResumeLayout(False)
        CType(Me.GridInvoices, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.dtToDateSearch.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtToDateSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFromDateSearch.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFromDateSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVDTitleSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplierNameSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceNumberSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabInvoice.ResumeLayout(False)
        Me.TabInvoice.PerformLayout()
        CType(Me.txtInvoiceTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVDPostAccountingInvoiceNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInvoiceDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInvoiceDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplierInvoiceNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplierName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSaveInvoice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblInvoiceDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtInvoiceDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDVDPostAccountingInvoiceNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInvoiceTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblInvoiceTotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSupplierNameSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSupplierNameSearch As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDVDTitleSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDVDTitleSearch As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSupplierName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCancelInvoice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblInvoiceID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSuplierName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSupplierInvoiceNumber As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDeleteInvoice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblDVDPostAccountingInvoiceNumber As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSupplierInvoiceNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnEditInvoice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TabInvoice As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNewInvoice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnViewAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblInvoiceNumberSearch As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInvoiceNumberSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TabSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dpBackcataloguExpired As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dpBackcatalogueStart As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents spnedtCredit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbLanguagesSubtitleEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents dtpDateExpired As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dpDateStart As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents cmbgridStatus As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositorycmbSupportVod As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbStudio As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents chkcolAvailable As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cmbLanguages As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridViewSearch As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridInvoices As DevExpress.XtraGrid.GridControl
    Friend WithEvents TabResult As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblToDateSearch As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtToDateSearch As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFromDateSearch As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFromDateSearch As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInvoiceDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSupplierInvoceNumber As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInvoiceTotal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridInvoiceItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents cmbSoundTracks As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colDVDTitle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDVDQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDVDUnitPrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDVDTotal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents XtraTabInvoice As DevExpress.XtraTab.XtraTabControl

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()

        GridViewSearch.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        GridViewSearch.OptionsBehavior.Editable = True
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        GridViewSearch.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        GridViewSearch.OptionsBehavior.Editable = True

    End Sub

    Dim CurrentCodeType As String
    Dim _enableField As Boolean
    Dim _sql As String
    Dim _InvoiceItems As dsInvoices
    Dim _InvoiceItemsUpdate As dsInvoices.invoice_itemsDataTable


    Dim WithEvents _ExportExcel As DevExpress.XtraBars.BarButtonItem = MainBtns_btnExcel
    Dim WithEvents SFDExportExcel As New System.Windows.Forms.SaveFileDialog


    Public Sub this_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        GridViewSearch.OptionsView.ColumnAutoWidth = False
        GridViewSearch.OptionsBehavior.Editable = False

        XtraTabInvoice.SelectedTabPage = TabSearch
        ' Misc_Bar.Visible = True

        Misc_Bar.Visible = True
        Dim menuStrip As New PlushBuziness.contextMenu()
        GridInvoices.ContextMenuStrip = menuStrip
        GridInvoiceItems.ContextMenuStrip = menuStrip
    End Sub

    'Private Sub btnexcel_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _ExportExcel.ItemClick
    '    SFDExportExcel.DefaultExt = "xls"
    '    SFDExportExcel.Filter = "Excel(*.xls)|*.xls"
    '    If SFDExportExcel.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        GridInvoiceDetail.ExportToXls(SFDExportExcel.FileName)
    '    End If
    'End Sub


    Enum StepForm
        EDIT
        [NEW]
        SAVE
        CANCEL
        INIT
        LOAD
        CHOOSEINVOICE
        DETAILED
    End Enum

    Enum typeSearch
        DETAIL
        ALL
    End Enum
    Private _typesearch As typeSearch
    Private Sub initForm()
        Dim blank As String = String.Empty

        txtId.EditValue = String.Empty
        txtId.EditValue = blank
        txtSupplierNameSearch.EditValue = blank
        txtInvoiceNumberSearch.EditValue = blank
        txtDVDTitleSearch.EditValue = blank
        dtFromDateSearch.EditValue = Nothing
        dtToDateSearch.EditValue = Nothing
        '
        txtSupplierName.EditValue = blank
        txtSupplierInvoiceNumber.EditValue = blank
        txtDVDPostAccountingInvoiceNumber.EditValue = blank
        txtInvoiceTotal.EditValue = blank
        '
        _InvoiceItems = New dsInvoices()
        GridInvoiceItems.DataSource = _InvoiceItems.Tables("invoice_items")

    End Sub


    Private Sub loadData(ByVal row As DataRow)

        If row("id") Is DBNull.Value Then
            txtId.EditValue = ""
        Else
            txtId.EditValue = row("id")
        End If
        If row("supplier_name") Is DBNull.Value Then
            txtSupplierName.EditValue = ""
        Else
            txtSupplierName.EditValue = row("supplier_name")
        End If

        If row("invoice_date") Is DBNull.Value Then
            dtInvoiceDate.DateTime = DateTime.Now
        Else
            dtInvoiceDate.EditValue = row("invoice_date")
        End If

        If row("supplier_invoice_number") Is DBNull.Value Then
            txtSupplierInvoiceNumber.EditValue = ""
        Else
            txtSupplierInvoiceNumber.EditValue = row("supplier_invoice_number")
        End If

        If row("dvdpost_invoice_number") Is DBNull.Value Then
            txtDVDPostAccountingInvoiceNumber.EditValue = 0
        Else
            txtDVDPostAccountingInvoiceNumber.EditValue = row("dvdpost_invoice_number")
        End If

        If row("invoice_total") Is DBNull.Value Then
            txtInvoiceTotal.EditValue = 0
        Else
            txtInvoiceTotal.EditValue = row("invoice_total")
        End If

        _InvoiceItemsUpdate = New dsInvoices.invoice_itemsDataTable()

        Dim sql As String
        sql = PlushData.clsInvoice.getSelectInvoiceItems(row("id"))

        PlushData.clsConnection.FillDataSet(_InvoiceItemsUpdate, sql)

        GridInvoiceItems.DataSource = _InvoiceItemsUpdate

    End Sub

    Private Sub EnableField(ByVal enable As Boolean)


        txtSupplierName.Enabled = enable
        txtSupplierInvoiceNumber.Enabled = enable
        txtDVDPostAccountingInvoiceNumber.Enabled = enable
        dtInvoiceDate.Enabled = enable
        txtInvoiceTotal.Enabled = enable
        GridInvoiceItems.Enabled = enable

    End Sub
    Private Sub ChangeStep(ByVal stepCurrent As StepForm)
        Select Case stepCurrent
            Case StepForm.CANCEL
                btnEditInvoice.Enabled = True
                btnSaveInvoice.Enabled = False
                btnCancelInvoice.Enabled = False
                btnDeleteInvoice.Enabled = True

                EnableField(False)

                'TabSearch.PageVisible = True
                'TabResult.PageVisible = True

            Case StepForm.EDIT
                btnEditInvoice.Enabled = False
                btnSaveInvoice.Enabled = True
                btnCancelInvoice.Enabled = True
                btnDeleteInvoice.Enabled = True

                EnableField(True)
                'TabInvoice.PageVisible = True
                'TabResult.PageVisible = False

            Case StepForm.INIT
                btnEditInvoice.Enabled = False
                btnSaveInvoice.Enabled = False
                btnCancelInvoice.Enabled = False
                btnDeleteInvoice.Enabled = False

                EnableField(False)

                'TabResult.PageVisible = True
                'TabSearch.PageVisible = True
                'TabInvoice.PageVisible = False
                XtraTabInvoice.SelectedTabPage = TabSearch


            Case StepForm.[NEW]
                btnEditInvoice.Enabled = False
                btnSaveInvoice.Enabled = True
                btnCancelInvoice.Enabled = True
                btnDeleteInvoice.Enabled = False

                EnableField(True)
                'TabResult.PageVisible = False
                'TabInvoice.PageVisible = True
                XtraTabInvoice.SelectedTabPage = TabInvoice

            Case StepForm.SAVE
                btnEditInvoice.Enabled = True
                btnSaveInvoice.Enabled = False
                btnCancelInvoice.Enabled = False
                btnDeleteInvoice.Enabled = True

                EnableField(False)
                'TabInvoice.PageVisible = True
                'TabResult.PageVisible = True

            Case StepForm.LOAD
                btnEditInvoice.Enabled = True
                btnSaveInvoice.Enabled = False
                btnCancelInvoice.Enabled = False

                EnableField(False)
                'TabSearch.PageVisible = False
                'TabResult.PageVisible = True

                XtraTabInvoice.SelectedTabPage = TabResult

            Case StepForm.CHOOSEINVOICE
                btnEditInvoice.Enabled = True
                btnSaveInvoice.Enabled = False
                btnCancelInvoice.Enabled = False

                EnableField(False)
                'TabResult.PageVisible = False
                'TabInvoice.PageVisible = True
                XtraTabInvoice.SelectedTabPage = TabInvoice

            Case StepForm.DETAILED
                btnEditInvoice.Enabled = False
                btnSaveInvoice.Enabled = False
                btnCancelInvoice.Enabled = False

                EnableField(False)
                'XTabResult.PageVisible = True
                'XTabView.PageVisible = False
                XtraTabInvoice.SelectedTabPage = TabInvoice

        End Select
        XtraTabInvoice.Refresh()
    End Sub

    'Private Sub loadInfoStudio()

    '    Dim row As DataRow
    '    If GridViewSearch.RowCount > 0 Then
    '        row = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle())
    '        loadData(row)
    '    End If
    'End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim sql As String
        Dim dt As DataTable = Nothing

        If txtDVDTitleSearch.Text <> String.Empty Then
            sql = "select si.* from studio_invoices si join studio_invoice_items sii on si.id = sii.invoice_id where "
        Else
            sql = "select * from studio_invoices where "
        End If
        If txtSupplierNameSearch.Text <> String.Empty Then
            sql = sql & " supplier_name like '%" & txtSupplierNameSearch.EditValue & "%' "
        Else
            sql = sql & " 1 = 1 "
        End If
        If txtInvoiceNumberSearch.Text <> String.Empty Then
            sql = sql & " AND supplier_invoice_number like '%" & txtInvoiceNumberSearch.EditValue & "%' "
        End If

        If txtDVDTitleSearch.Text <> String.Empty Then
            sql = sql & " AND dvd_title like '%" & txtDVDTitleSearch.EditValue & "%' "
        End If

        If dtFromDateSearch.EditValue <> Nothing Then
            sql = sql & " AND invoice_date > '" & PlushTools.ClsDate.formatDateDB(dtFromDateSearch.EditValue) & "' "
        End If

        If dtToDateSearch.EditValue <> Nothing Then
            sql = sql & " AND invoice_date < '" & PlushTools.ClsDate.formatDateDB(dtToDateSearch.EditValue) & "' "
        End If

        sql = sql & " group by id"

        dt = PlushData.clsConnection.FillDataSet(sql)
        If Not dt Is Nothing Then
            GridInvoices.DataSource = dt
            ChangeStep(StepForm.LOAD)
            _typesearch = typeSearch.DETAIL
        End If


    End Sub

    Private Function Save() As Boolean
        Dim sql As String
        Dim row As dsInvoices.invoice_itemsRow
        sql = ""

        Dim invoice_id As Integer = 0
        Try

            If txtId.Text Is Nothing Or txtId.Text = String.Empty Then
                sql = PlushData.clsInvoice.getInsertInvoice(txtSupplierName.EditValue, PlushTools.ClsDate.formatDateDB(dtInvoiceDate.EditValue), txtSupplierInvoiceNumber.EditValue, txtDVDPostAccountingInvoiceNumber.EditValue, txtInvoiceTotal.EditValue)
                PlushData.clsConnection.ExecuteNonQuery(sql)

                sql = PlushData.clsInvoice.getSelectNewInvoiceID(txtSupplierName.EditValue, PlushTools.ClsDate.formatDateDB(dtInvoiceDate.EditValue), txtSupplierInvoiceNumber.EditValue, txtDVDPostAccountingInvoiceNumber.EditValue, txtInvoiceTotal.EditValue)
                invoice_id = PlushData.clsConnection.ExecuteScalar(sql)

                For Each row In _InvoiceItems.invoice_items

                    sql = PlushData.clsInvoice.getInsertInvoiceItem(invoice_id, row.dvd_title, row.dvd_quantity, row.dvd_unit_price, row.dvd_total)
                    PlushData.clsConnection.ExecuteNonQuery(sql)

                Next

            Else
                sql = PlushData.clsInvoice.getUpdateInvoice(txtId.EditValue, txtSupplierName.EditValue, PlushTools.ClsDate.formatDateDB(dtInvoiceDate.EditValue), txtSupplierInvoiceNumber.EditValue, txtDVDPostAccountingInvoiceNumber.EditValue, txtInvoiceTotal.EditValue)
                PlushData.clsConnection.ExecuteNonQuery(sql)

                invoice_id = txtId.EditValue

                For Each row In _InvoiceItemsUpdate.Rows

                    sql = PlushData.clsInvoice.getUpdateInvoiceItem(row.id, row.invoice_id, row.dvd_title, row.dvd_quantity, row.dvd_unit_price, row.dvd_total)
                    PlushData.clsConnection.ExecuteNonQuery(sql)

                Next

            End If
            Return True
        Catch ex As Exception
            sql = PlushData.clsInvoice.GetDeleteInvoiceItems(invoice_id)
            PlushData.clsConnection.ExecuteNonQuery(sql)


            sql = PlushData.clsInvoice.GetDeleteInvoice(invoice_id)
            PlushData.clsConnection.ExecuteNonQuery(sql)

            MsgBox(ex.Message, MsgBoxStyle.Information)
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.BO, ex)
            Return False
        End Try
    End Function

    Private Sub btnSaveStudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveInvoice.Click
        If Save() Then
            ChangeStep(StepForm.SAVE)
            If _typesearch = typeSearch.DETAIL Then
                btnSearch_Click(Nothing, Nothing)
            Else
                BtnViewAll_Click(Nothing, Nothing)
            End If
        Else
            MsgBox("Error Save Invoice (voir log)", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnEditInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditInvoice.Click
        ChangeStep(StepForm.EDIT)
    End Sub

    Private Sub GridInvoices_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridInvoices.DoubleClick
        loadInfoInvoice()
        ChangeStep(StepForm.CHOOSEINVOICE)
    End Sub


    Private Sub btnCancelInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelInvoice.Click
        ChangeStep(StepForm.CANCEL)
    End Sub

    Private Sub BtnViewAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewAll.Click
        Dim sql As String
        Dim dt As DataTable = Nothing

        sql = PlushData.clsInvoice.getSelectInvoicesAll()
        dt = PlushData.clsConnection.FillDataSet(sql)

        If Not dt Is Nothing Then
            GridInvoices.DataSource = dt
            ChangeStep(StepForm.LOAD)
            _typesearch = typeSearch.ALL
        End If
    End Sub

    Private Sub btnDeleteInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteInvoice.Click
        Dim sql As String

        sql = PlushData.clsInvoice.GetDeleteInvoiceItems(txtId.Text)
        PlushData.clsConnection.ExecuteNonQuery(sql)

        sql = PlushData.clsInvoice.GetDeleteInvoice(txtId.Text)
        PlushData.clsConnection.ExecuteNonQuery(sql)

        If _typesearch = typeSearch.DETAIL Then
            btnSearch_Click(Nothing, Nothing)
        Else
            BtnViewAll_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub loadInfoInvoice()

        Dim row As DataRow
        If GridViewSearch.RowCount > 0 Then
            row = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle())
            loadData(row)
        End If
    End Sub

    Private Sub loadData(ByVal sql As String)

        'Dim dt As DataTable
        'dt = DvdPostData.clsConnection.FillDataSet(sql, DvdPostData.clsConnection.typeAccessDb.READ)
        '' dt = DvdPostData.clsConnection.FillDataSet(sql)
        'Grid1.DataSource = Nothing
        'Grid1.Views(0).PopulateColumns()

        'Grid1.DataSource = dt
        'TabAnalise.SelectedTabPage = XtraTabDetailedReport

        'clsDevExpress.AddHyperlinkDynamic(Grid1)

    End Sub

    Private Sub BtnNewInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewInvoice.Click
        initForm()
        ChangeStep(StepForm.[NEW])
    End Sub
End Class
