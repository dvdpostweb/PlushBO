<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayPerViewMaint
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
        Me.TabCreatePPV = New DevExpress.XtraTab.XtraTabPage
        Me.txtPPVFolder = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.btnCreateSummaryReport = New DevExpress.XtraEditors.SimpleButton
        Me.cmbCountry = New DevExpress.XtraEditors.LookUpEdit
        Me.lblStudioBilling = New DevExpress.XtraEditors.LabelControl
        Me.TabResult = New DevExpress.XtraTab.XtraTabPage
        Me.GridPPV = New DevExpress.XtraGrid.GridControl
        Me.GridViewSearch = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.col_customers_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.col_products_title = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.col_imdb_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.col_created_at = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.col_is_ppv = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.col_ppv_price = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
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
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.TabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.dtSearchTo = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.dtSearchFrom = New DevExpress.XtraEditors.DateEdit
        Me.txtSearch_imdb_id = New DevExpress.XtraEditors.TextEdit
        Me.cmbSearchCountry = New DevExpress.XtraEditors.LookUpEdit
        Me.lblCountry = New DevExpress.XtraEditors.LabelControl
        Me.lblimdb_id = New DevExpress.XtraEditors.LabelControl
        Me.BtnViewAll = New DevExpress.XtraEditors.SimpleButton
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.TabPPVMaint = New DevExpress.XtraTab.XtraTabControl
        Me.OFDFilePPV = New System.Windows.Forms.OpenFileDialog
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCreatePPV.SuspendLayout()
        CType(Me.txtPPVFolder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabResult.SuspendLayout()
        CType(Me.GridPPV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSearch.SuspendLayout()
        CType(Me.dtSearchTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtSearchTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtSearchFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtSearchFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearch_imdb_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSearchCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPPVMaint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPPVMaint.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabCreatePPV
        '
        Me.TabCreatePPV.Controls.Add(Me.txtPPVFolder)
        Me.TabCreatePPV.Controls.Add(Me.LabelControl2)
        Me.TabCreatePPV.Controls.Add(Me.LabelControl1)
        Me.TabCreatePPV.Controls.Add(Me.txtToDate)
        Me.TabCreatePPV.Controls.Add(Me.LabelControl4)
        Me.TabCreatePPV.Controls.Add(Me.txtFromDate)
        Me.TabCreatePPV.Controls.Add(Me.btnCreateSummaryReport)
        Me.TabCreatePPV.Controls.Add(Me.cmbCountry)
        Me.TabCreatePPV.Controls.Add(Me.lblStudioBilling)
        Me.TabCreatePPV.Name = "TabCreatePPV"
        Me.TabCreatePPV.Size = New System.Drawing.Size(941, 440)
        Me.TabCreatePPV.Text = "Create PPV file"
        '
        'txtPPVFolder
        '
        Me.txtPPVFolder.Location = New System.Drawing.Point(437, 21)
        Me.txtPPVFolder.Name = "txtPPVFolder"
        Me.txtPPVFolder.Size = New System.Drawing.Size(294, 20)
        Me.txtPPVFolder.TabIndex = 108
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(332, 25)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl2.TabIndex = 107
        Me.LabelControl2.Text = "PPV folder"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(55, 114)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl1.TabIndex = 102
        Me.LabelControl1.Text = "To Date"
        '
        'txtToDate
        '
        Me.txtToDate.EditValue = Nothing
        Me.txtToDate.Location = New System.Drawing.Point(138, 110)
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtToDate.Size = New System.Drawing.Size(112, 20)
        Me.txtToDate.TabIndex = 101
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(55, 67)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl4.TabIndex = 100
        Me.LabelControl4.Text = "From Date"
        '
        'txtFromDate
        '
        Me.txtFromDate.EditValue = Nothing
        Me.txtFromDate.Location = New System.Drawing.Point(138, 63)
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtFromDate.Size = New System.Drawing.Size(112, 20)
        Me.txtFromDate.TabIndex = 99
        '
        'btnCreateSummaryReport
        '
        Me.btnCreateSummaryReport.Location = New System.Drawing.Point(55, 186)
        Me.btnCreateSummaryReport.Name = "btnCreateSummaryReport"
        Me.btnCreateSummaryReport.Size = New System.Drawing.Size(128, 23)
        Me.btnCreateSummaryReport.TabIndex = 97
        Me.btnCreateSummaryReport.Text = "Create PPV file"
        '
        'cmbCountry
        '
        Me.cmbCountry.EditValue = "1"
        Me.cmbCountry.Location = New System.Drawing.Point(138, 21)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCountry.Properties.DisplayMember = "status_desc"
        Me.cmbCountry.Properties.NullText = ""
        Me.cmbCountry.Properties.ValueMember = "status_id"
        Me.cmbCountry.Size = New System.Drawing.Size(112, 20)
        Me.cmbCountry.TabIndex = 94
        '
        'lblStudioBilling
        '
        Me.lblStudioBilling.Location = New System.Drawing.Point(55, 25)
        Me.lblStudioBilling.Name = "lblStudioBilling"
        Me.lblStudioBilling.Size = New System.Drawing.Size(39, 13)
        Me.lblStudioBilling.TabIndex = 93
        Me.lblStudioBilling.Text = "Country"
        '
        'TabResult
        '
        Me.TabResult.Controls.Add(Me.GridPPV)
        Me.TabResult.Name = "TabResult"
        Me.TabResult.Size = New System.Drawing.Size(941, 440)
        Me.TabResult.Text = "Result"
        '
        'GridPPV
        '
        Me.GridPPV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPPV.EmbeddedNavigator.Name = ""
        Me.GridPPV.FormsUseDefaultLookAndFeel = False
        Me.GridPPV.Location = New System.Drawing.Point(0, 0)
        Me.GridPPV.MainView = Me.GridViewSearch
        Me.GridPPV.Name = "GridPPV"
        Me.GridPPV.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbLanguages, Me.chkcolAvailable, Me.cmbStudio, Me.RepositorycmbSupportVod, Me.cmbgridStatus, Me.dpDateStart, Me.dtpDateExpired, Me.cmbLanguagesSubtitleEdit, Me.RepositoryItemLookUpEdit2, Me.spnedtCredit, Me.dpBackcatalogueStart, Me.dpBackcataloguExpired, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.GridPPV.Size = New System.Drawing.Size(941, 440)
        Me.GridPPV.TabIndex = 5
        Me.GridPPV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSearch, Me.GridView2})
        '
        'GridViewSearch
        '
        Me.GridViewSearch.Appearance.FocusedRow.BackColor = System.Drawing.Color.Silver
        Me.GridViewSearch.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridViewSearch.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand3, Me.GridBand4})
        Me.GridViewSearch.ColumnPanelRowHeight = 45
        Me.GridViewSearch.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.col_customers_id, Me.col_products_title, Me.col_imdb_id, Me.col_created_at, Me.col_is_ppv, Me.col_ppv_price})
        Me.GridViewSearch.CustomizationFormBounds = New System.Drawing.Rectangle(0, 375, 225, 209)
        Me.GridViewSearch.DetailHeight = 50
        Me.GridViewSearch.GridControl = Me.GridPPV
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
        Me.GridBand1.Columns.Add(Me.col_customers_id)
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 75
        '
        'col_customers_id
        '
        Me.col_customers_id.Caption = "customers_id"
        Me.col_customers_id.FieldName = "customers_id"
        Me.col_customers_id.Name = "col_customers_id"
        Me.col_customers_id.Visible = True
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "gridBand1"
        Me.GridBand3.Columns.Add(Me.col_products_title)
        Me.GridBand3.MinWidth = 20
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 75
        '
        'col_products_title
        '
        Me.col_products_title.Caption = "products_title"
        Me.col_products_title.FieldName = "products_title"
        Me.col_products_title.Name = "col_products_title"
        Me.col_products_title.Visible = True
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "gridBand2"
        Me.GridBand4.Columns.Add(Me.col_imdb_id)
        Me.GridBand4.Columns.Add(Me.col_created_at)
        Me.GridBand4.Columns.Add(Me.col_is_ppv)
        Me.GridBand4.Columns.Add(Me.col_ppv_price)
        Me.GridBand4.MinWidth = 20
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 300
        '
        'col_imdb_id
        '
        Me.col_imdb_id.Caption = "imdb_id"
        Me.col_imdb_id.FieldName = "imdb_id"
        Me.col_imdb_id.Name = "col_imdb_id"
        Me.col_imdb_id.Visible = True
        '
        'col_created_at
        '
        Me.col_created_at.Caption = "created_at"
        Me.col_created_at.FieldName = "created_at"
        Me.col_created_at.Name = "col_created_at"
        Me.col_created_at.Visible = True
        '
        'col_is_ppv
        '
        Me.col_is_ppv.Caption = "is_ppv"
        Me.col_is_ppv.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.col_is_ppv.FieldName = "is_ppv"
        Me.col_is_ppv.Name = "col_is_ppv"
        Me.col_is_ppv.Visible = True
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'col_ppv_price
        '
        Me.col_ppv_price.Caption = "ppv_price"
        Me.col_ppv_price.FieldName = "amount"
        Me.col_ppv_price.Name = "col_ppv_price"
        Me.col_ppv_price.Visible = True
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
        Me.RepositoryItemCheckEdit1.ValueChecked = "1"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "0"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridPPV
        Me.GridView2.Name = "GridView2"
        '
        'TabSearch
        '
        Me.TabSearch.Controls.Add(Me.LabelControl5)
        Me.TabSearch.Controls.Add(Me.dtSearchTo)
        Me.TabSearch.Controls.Add(Me.LabelControl6)
        Me.TabSearch.Controls.Add(Me.dtSearchFrom)
        Me.TabSearch.Controls.Add(Me.txtSearch_imdb_id)
        Me.TabSearch.Controls.Add(Me.cmbSearchCountry)
        Me.TabSearch.Controls.Add(Me.lblCountry)
        Me.TabSearch.Controls.Add(Me.lblimdb_id)
        Me.TabSearch.Controls.Add(Me.BtnViewAll)
        Me.TabSearch.Controls.Add(Me.btnSearch)
        Me.TabSearch.Name = "TabSearch"
        Me.TabSearch.Size = New System.Drawing.Size(941, 440)
        Me.TabSearch.Text = "Search"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(54, 168)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl5.TabIndex = 106
        Me.LabelControl5.Text = "To Date"
        '
        'dtSearchTo
        '
        Me.dtSearchTo.EditValue = Nothing
        Me.dtSearchTo.Location = New System.Drawing.Point(159, 161)
        Me.dtSearchTo.Name = "dtSearchTo"
        Me.dtSearchTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtSearchTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtSearchTo.Size = New System.Drawing.Size(112, 20)
        Me.dtSearchTo.TabIndex = 105
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(54, 121)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl6.TabIndex = 104
        Me.LabelControl6.Text = "From Date"
        '
        'dtSearchFrom
        '
        Me.dtSearchFrom.EditValue = Nothing
        Me.dtSearchFrom.Location = New System.Drawing.Point(159, 118)
        Me.dtSearchFrom.Name = "dtSearchFrom"
        Me.dtSearchFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtSearchFrom.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtSearchFrom.Size = New System.Drawing.Size(112, 20)
        Me.dtSearchFrom.TabIndex = 103
        '
        'txtSearch_imdb_id
        '
        Me.txtSearch_imdb_id.Location = New System.Drawing.Point(159, 22)
        Me.txtSearch_imdb_id.Name = "txtSearch_imdb_id"
        Me.txtSearch_imdb_id.Size = New System.Drawing.Size(112, 20)
        Me.txtSearch_imdb_id.TabIndex = 89
        '
        'cmbSearchCountry
        '
        Me.cmbSearchCountry.EditValue = "1"
        Me.cmbSearchCountry.Location = New System.Drawing.Point(159, 71)
        Me.cmbSearchCountry.Name = "cmbSearchCountry"
        Me.cmbSearchCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSearchCountry.Properties.NullText = ""
        Me.cmbSearchCountry.Properties.ValueMember = "status_id"
        Me.cmbSearchCountry.Size = New System.Drawing.Size(112, 20)
        Me.cmbSearchCountry.TabIndex = 88
        '
        'lblCountry
        '
        Me.lblCountry.Location = New System.Drawing.Point(54, 74)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(39, 13)
        Me.lblCountry.TabIndex = 87
        Me.lblCountry.Text = "Country"
        '
        'lblimdb_id
        '
        Me.lblimdb_id.Location = New System.Drawing.Point(54, 29)
        Me.lblimdb_id.Name = "lblimdb_id"
        Me.lblimdb_id.Size = New System.Drawing.Size(36, 13)
        Me.lblimdb_id.TabIndex = 86
        Me.lblimdb_id.Text = "imdb_id"
        '
        'BtnViewAll
        '
        Me.BtnViewAll.Location = New System.Drawing.Point(159, 315)
        Me.BtnViewAll.Name = "BtnViewAll"
        Me.BtnViewAll.Size = New System.Drawing.Size(75, 23)
        Me.BtnViewAll.TabIndex = 85
        Me.BtnViewAll.Text = "View all"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(52, 315)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 83
        Me.btnSearch.Text = "Search"
        '
        'TabPPVMaint
        '
        Me.TabPPVMaint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPPVMaint.Location = New System.Drawing.Point(0, 30)
        Me.TabPPVMaint.Name = "TabPPVMaint"
        Me.TabPPVMaint.SelectedTabPage = Me.TabResult
        Me.TabPPVMaint.Size = New System.Drawing.Size(950, 471)
        Me.TabPPVMaint.TabIndex = 6
        Me.TabPPVMaint.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabSearch, Me.TabResult, Me.TabCreatePPV})
        Me.TabPPVMaint.Text = "Create PPV File"
        '
        'OFDFilePPV
        '
        Me.OFDFilePPV.FileName = "OpenFileDialog1"
        '
        'frmPayPerViewMaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 501)
        Me.Controls.Add(Me.TabPPVMaint)
        Me.Name = "frmPayPerViewMaint"
        Me.Text = "frmPayPerViewMaint"
        Me.Controls.SetChildIndex(Me.TabPPVMaint, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCreatePPV.ResumeLayout(False)
        Me.TabCreatePPV.PerformLayout()
        CType(Me.txtPPVFolder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabResult.ResumeLayout(False)
        CType(Me.GridPPV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSearch.ResumeLayout(False)
        Me.TabSearch.PerformLayout()
        CType(Me.dtSearchTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtSearchTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtSearchFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtSearchFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearch_imdb_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSearchCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPPVMaint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPPVMaint.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabCreatePPV As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnCreateSummaryReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbCountry As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblStudioBilling As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TabResult As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridPPV As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSearch As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
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
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtSearchTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtSearchFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtSearch_imdb_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbSearchCountry As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblCountry As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblimdb_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnViewAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TabPPVMaint As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents txtPPVFolder As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents OFDFilePPV As System.Windows.Forms.OpenFileDialog
    Friend WithEvents col_customers_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents col_products_title As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents col_imdb_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents col_created_at As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents col_is_ppv As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents col_ppv_price As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
End Class
