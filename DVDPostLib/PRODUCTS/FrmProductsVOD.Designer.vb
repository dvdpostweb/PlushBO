<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductsVOD
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
        Me.components = New System.ComponentModel.Container
        Dim colDateStartUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Dim GridViewInvoiceItems As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductsVOD))
        Me.GridBand9 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colStartOn = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.dpStartOn = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colEndOn = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.dpEndOn = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colCreatedAt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colUpdatedAt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colKind = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.lkupSVODKind = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPrepaidStartOn = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.dpPrepaidStartOn = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colPrepaidEndOn = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.dpPrepaidEndOn = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colIMDB = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridSVODDates = New DevExpress.XtraGrid.GridControl
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.Main_Bar = New DevExpress.XtraBars.Bar
        Me.btnNew = New DevExpress.XtraBars.BarButtonItem
        Me.btnEdit = New DevExpress.XtraBars.BarButtonItem
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem
        Me.Misc_Bar = New DevExpress.XtraBars.Bar
        Me.MainBtns_btnExcel = New DevExpress.XtraBars.BarButtonItem
        Me.MainBtns_btnBigger = New DevExpress.XtraBars.BarButtonItem
        Me.MainBtns_btnSmaller = New DevExpress.XtraBars.BarButtonItem
        Me.MainBtns_btnBestFit = New DevExpress.XtraBars.BarButtonItem
        Me.btnOK = New DevExpress.XtraBars.BarButtonItem
        Me.btnUser1 = New DevExpress.XtraBars.BarButtonItem
        Me.btnUser2 = New DevExpress.XtraBars.BarButtonItem
        Me.btnUser3 = New DevExpress.XtraBars.BarButtonItem
        Me.btnUser4 = New DevExpress.XtraBars.BarButtonItem
        Me.btnUser5 = New DevExpress.XtraBars.BarButtonItem
        Me.btnExportXML = New DevExpress.XtraBars.BarButtonItem
        Me.btnImportXML = New DevExpress.XtraBars.BarButtonItem
        Me.View_Bar = New DevExpress.XtraBars.Bar
        Me.btnView = New DevExpress.XtraBars.BarButtonItem
        Me.cmbViewList = New DevExpress.XtraBars.BarEditItem
        Me.btnEditView = New DevExpress.XtraBars.BarButtonItem
        Me.btnNewView = New DevExpress.XtraBars.BarButtonItem
        Me.btnDeleteView = New DevExpress.XtraBars.BarButtonItem
        Me.btnSaveView = New DevExpress.XtraBars.BarButtonItem
        Me.btnMakeViewCommon = New DevExpress.XtraBars.BarButtonItem
        Me.btnSendViewUser = New DevExpress.XtraBars.BarButtonItem
        Me.btnCopyView = New DevExpress.XtraBars.BarButtonItem
        Me.QuickSearch_Bar = New DevExpress.XtraBars.Bar
        Me.txtQuickSearch = New DevExpress.XtraBars.BarEditItem
        Me.btnQuickSearch = New DevExpress.XtraBars.BarButtonItem
        Me.Report_Bar = New DevExpress.XtraBars.Bar
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem
        Me.cmbReportList = New DevExpress.XtraBars.BarEditItem
        Me.btnEditReportInfo = New DevExpress.XtraBars.BarButtonItem
        Me.btnNewReport = New DevExpress.XtraBars.BarButtonItem
        Me.btnDeleteReport = New DevExpress.XtraBars.BarButtonItem
        Me.btnDesignReport = New DevExpress.XtraBars.BarButtonItem
        Me.btnMakeReportCommon = New DevExpress.XtraBars.BarButtonItem
        Me.btnSendReportUser = New DevExpress.XtraBars.BarButtonItem
        Me.btnCopyReport = New DevExpress.XtraBars.BarButtonItem
        Me.Filter_Bar = New DevExpress.XtraBars.Bar
        Me.btnFilter = New DevExpress.XtraBars.BarButtonItem
        Me.cmbFilterList = New DevExpress.XtraBars.BarEditItem
        Me.btnEditFilter = New DevExpress.XtraBars.BarButtonItem
        Me.btnNewFilter = New DevExpress.XtraBars.BarButtonItem
        Me.btnDeleteFilter = New DevExpress.XtraBars.BarButtonItem
        Me.btnMakeFilterCommon = New DevExpress.XtraBars.BarButtonItem
        Me.btnSendFilterUSer = New DevExpress.XtraBars.BarButtonItem
        Me.btnCopyFilter = New DevExpress.XtraBars.BarButtonItem
        Me.DefaultSet_Bar = New DevExpress.XtraBars.Bar
        Me.btnDefault = New DevExpress.XtraBars.BarButtonItem
        Me.cmbDefaultList = New DevExpress.XtraBars.BarEditItem
        Me.btnEditDefault = New DevExpress.XtraBars.BarButtonItem
        Me.btnNewDefault = New DevExpress.XtraBars.BarButtonItem
        Me.btnDeleteDefault = New DevExpress.XtraBars.BarButtonItem
        Me.btnSaveDefault = New DevExpress.XtraBars.BarButtonItem
        Me.btnMakeDefaultCommon = New DevExpress.XtraBars.BarButtonItem
        Me.btnSendDefaultUser = New DevExpress.XtraBars.BarButtonItem
        Me.btnCopyDefault = New DevExpress.XtraBars.BarButtonItem
        Me.Misc_Bar2 = New DevExpress.XtraBars.Bar
        Me.btnTranslation = New DevExpress.XtraBars.BarButtonItem
        Me.btnComments = New DevExpress.XtraBars.BarButtonItem
        Me.btnAttachements = New DevExpress.XtraBars.BarButtonItem
        Me.Nav_Bar = New DevExpress.XtraBars.Bar
        Me.btnFirst = New DevExpress.XtraBars.BarButtonItem
        Me.btnPrevious = New DevExpress.XtraBars.BarButtonItem
        Me.btnNext = New DevExpress.XtraBars.BarButtonItem
        Me.btnLast = New DevExpress.XtraBars.BarButtonItem
        Me.XTabVODAndTrailers = New DevExpress.XtraTab.XtraTabControl
        Me.xTabTrailers = New DevExpress.XtraTab.XtraTabPage
        Me.btnSaveTrailers = New DevExpress.XtraEditors.SimpleButton
        Me.grdTrailers = New DevExpress.XtraGrid.GridControl
        Me.GridViewTrailers = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.col_watch_trailer = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryBtnWatchTrailer = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.col_trailer_filename = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.col_imdb_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.col_audio = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.repLanguageTrailers = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.col_sub = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.repSubtitleTrailers = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.col_status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbgridStatusTrailer = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.col_available = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbLanguagesTrailers = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.cmbSubtitleTrailers = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.webTrailers = New System.Windows.Forms.WebBrowser
        Me.XTabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.btnRipped = New DevExpress.XtraEditors.SimpleButton
        Me.BtnViewAll = New DevExpress.XtraEditors.SimpleButton
        Me.BtnNewVodProduct = New DevExpress.XtraEditors.SimpleButton
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.txtImdb = New DevExpress.XtraEditors.TextEdit
        Me.LblImdb = New DevExpress.XtraEditors.LabelControl
        Me.TxtProducts_id = New DevExpress.XtraEditors.TextEdit
        Me.lblProduct_id = New DevExpress.XtraEditors.LabelControl
        Me.txtTitleSearch = New DevExpress.XtraEditors.TextEdit
        Me.lblPartTitle = New DevExpress.XtraEditors.LabelControl
        Me.XTabResult = New DevExpress.XtraTab.XtraTabPage
        Me.btnSaveAllChanges = New DevExpress.XtraEditors.SimpleButton
        Me.GridVod = New DevExpress.XtraGrid.GridControl
        Me.GridViewSearch = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colImdb_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.spnedtCredit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.colproducts_name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colQuality = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colStudio = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbStudio = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colStatus = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbgridStatus = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.collanguage_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbLanguages = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colLanguage_subtitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbLanguagesSubtitleEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ColAvailable_from = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.dpDateStart = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colExpireAt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.dtpDateExpired = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colAvailableBackCatalogueFrom = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.dpBackcatalogueStart = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colBackcatalogueExpireAt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.dpBackcataloguExpired = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colSvodA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colSvodB = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colAvailable = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.chkcolAvailable = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colDRM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colcountry = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositorycmbSupportVod = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XTabView = New DevExpress.XtraTab.XtraTabPage
        Me.txtEpisodeID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl
        Me.txtSeasonID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.chkDRM = New DevExpress.XtraEditors.CheckEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtId = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cmbDateStart = New DevExpress.XtraEditors.DateEdit
        Me.cmbDateExpired = New DevExpress.XtraEditors.DateEdit
        Me.chkIsPPV = New DevExpress.XtraEditors.CheckEdit
        Me.cmbDateLaterStart = New DevExpress.XtraEditors.DateEdit
        Me.txtPPVPrice = New DevExpress.XtraEditors.TextEdit
        Me.cmbDateLaterExpired = New DevExpress.XtraEditors.DateEdit
        Me.chkAvailable = New DevExpress.XtraEditors.CheckEdit
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtIdNL = New DevExpress.XtraEditors.TextEdit
        Me.txtPPVPriceNL = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.chkIsPPVNL = New DevExpress.XtraEditors.CheckEdit
        Me.chkNL = New DevExpress.XtraEditors.CheckEdit
        Me.chkAvailableNL = New DevExpress.XtraEditors.CheckEdit
        Me.cmbDateLaterExpiredNL = New DevExpress.XtraEditors.DateEdit
        Me.cmbDateLaterStartNL = New DevExpress.XtraEditors.DateEdit
        Me.cmbDateExpiredNL = New DevExpress.XtraEditors.DateEdit
        Me.cmbDateStartNL = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.gpbLuxemburg = New System.Windows.Forms.GroupBox
        Me.txtIdLU = New DevExpress.XtraEditors.TextEdit
        Me.txtPPVPriceLU = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.chkIsPPVLU = New DevExpress.XtraEditors.CheckEdit
        Me.chkLU = New DevExpress.XtraEditors.CheckEdit
        Me.chkAvailableLU = New DevExpress.XtraEditors.CheckEdit
        Me.cmbDateLaterExpiredLU = New DevExpress.XtraEditors.DateEdit
        Me.cmbDateLaterStartLU = New DevExpress.XtraEditors.DateEdit
        Me.cmbDateExpiredLU = New DevExpress.XtraEditors.DateEdit
        Me.cmbDateStartLU = New DevExpress.XtraEditors.DateEdit
        Me.btnDeleteVOD = New DevExpress.XtraEditors.SimpleButton
        Me.cmbSupportVod = New DevExpress.XtraEditors.LookUpEdit
        Me.lblSupport = New DevExpress.XtraEditors.LabelControl
        Me.cmbSource = New DevExpress.XtraEditors.LookUpEdit
        Me.lblSource = New DevExpress.XtraEditors.LabelControl
        Me.cmbQuality = New DevExpress.XtraEditors.LookUpEdit
        Me.lblHigh = New DevExpress.XtraEditors.LabelControl
        Me.cmbStatus = New DevExpress.XtraEditors.LookUpEdit
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl
        Me.cmbStudioEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.lblStudio = New DevExpress.XtraEditors.LabelControl
        Me.btnCancelVod = New DevExpress.XtraEditors.SimpleButton
        Me.cmbLanguageSubtitle = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbLanguageSound = New DevExpress.XtraEditors.LookUpEdit
        Me.TxtFilename = New DevExpress.XtraEditors.TextEdit
        Me.lblNameFile = New DevExpress.XtraEditors.LabelControl
        Me.lblLanguage_subtitle = New DevExpress.XtraEditors.LabelControl
        Me.lblLanguageSound = New DevExpress.XtraEditors.LabelControl
        Me.txtImdbView = New DevExpress.XtraEditors.TextEdit
        Me.lblImdbView = New DevExpress.XtraEditors.LabelControl
        Me.btnSaveVod = New DevExpress.XtraEditors.SimpleButton
        Me.btnEditVod = New DevExpress.XtraEditors.SimpleButton
        Me.XTabProcess = New DevExpress.XtraTab.XtraTabPage
        Me.lblDestinationPathFile = New System.Windows.Forms.Label
        Me.txtDestinationPath = New DevExpress.XtraEditors.TextEdit
        Me.btnDestination = New DevExpress.XtraEditors.SimpleButton
        Me.txtSourcePath = New DevExpress.XtraEditors.TextEdit
        Me.ProgressBarRipping = New DevExpress.XtraEditors.ProgressBarControl
        Me.btnGenerateRipping = New DevExpress.XtraEditors.SimpleButton
        Me.btnSource = New DevExpress.XtraEditors.SimpleButton
        Me.lblPathSourceTitle = New System.Windows.Forms.Label
        Me.XTabViewVod = New DevExpress.XtraTab.XtraTabPage
        Me.GridVodWatch = New DevExpress.XtraGrid.GridControl
        Me.gridViewVodWatch = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colBtnWatchFilm = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryBtnWatchMovie = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.colQuality2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colProductNameUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colStudioUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryCmbStudio = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colStatusUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.ColImdbUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colLangAudioUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositorycmbLanguage = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colLangSubtitleUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryLanguageSubtitleGrid = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colDateExpiredUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colAvailableUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositorychkAvailable = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.WebSiteDvdPost = New System.Windows.Forms.WebBrowser
        Me.XTabFtp = New DevExpress.XtraTab.XtraTabPage
        Me.lblDbFtp = New System.Windows.Forms.Label
        Me.lblFtpLocal = New System.Windows.Forms.Label
        Me.txtSourceFtp = New DevExpress.XtraEditors.TextEdit
        Me.TxtSourceLocal = New DevExpress.XtraEditors.TextEdit
        Me.btnFolderLocal = New DevExpress.XtraEditors.SimpleButton
        Me.lblLocal = New System.Windows.Forms.Label
        Me.GridDBFtp = New DevExpress.XtraGrid.GridControl
        Me.GridViewDBFtp = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridFtpLocal = New DevExpress.XtraGrid.GridControl
        Me.GridViewFtpLocal = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNameFileFtp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BtnCompare = New System.Windows.Forms.Button
        Me.lblFTP = New System.Windows.Forms.Label
        Me.XtabAutomateTranscode = New DevExpress.XtraTab.XtraTabPage
        Me.lblError = New System.Windows.Forms.Label
        Me.lblOk = New System.Windows.Forms.Label
        Me.lstError = New System.Windows.Forms.ListBox
        Me.LstResult = New System.Windows.Forms.ListBox
        Me.btnGenerateVod = New DevExpress.XtraEditors.SimpleButton
        Me.txtPathOfFile = New DevExpress.XtraEditors.TextEdit
        Me.btnChooseFileTxt = New DevExpress.XtraEditors.SimpleButton
        Me.lblTxtFile = New System.Windows.Forms.Label
        Me.xTabVODOnlyMovie = New DevExpress.XtraTab.XtraTabPage
        Me.grdOnlyVODMovie = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.imdb_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.filename = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnAllNoMovieInfo = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabTrailerSearch = New DevExpress.XtraTab.XtraTabPage
        Me.btnTrailerViewAll = New DevExpress.XtraEditors.SimpleButton
        Me.btnTrailerNew = New DevExpress.XtraEditors.SimpleButton
        Me.btnTrailerSearch = New DevExpress.XtraEditors.SimpleButton
        Me.txtTrailerImdbSearch = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtTrailerProductsIDSearch = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtTrailerTitleSearch = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabTrailerResult = New DevExpress.XtraTab.XtraTabPage
        Me.gridTrailersResult = New DevExpress.XtraGrid.GridControl
        Me.GridViewTrailer = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.BandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.BandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn7 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.BandedGridColumn8 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbTrailerLanguageGrid = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.BandedGridColumn9 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbTrailerSubtitleGrid = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.BandedGridColumn10 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.BandedGridColumn11 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.BandedGridColumn14 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.GridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.XtraTabTrailerView = New DevExpress.XtraTab.XtraTabPage
        Me.txtTrailerID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl
        Me.cmbTrailerDateStart = New DevExpress.XtraEditors.DateEdit
        Me.cmbTRailerDateExpired = New DevExpress.XtraEditors.DateEdit
        Me.chkTrailerAvailable = New DevExpress.XtraEditors.CheckEdit
        Me.btnTrailerDelete = New DevExpress.XtraEditors.SimpleButton
        Me.cmdTrailerStatus = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.btnTrailerCancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmbTrailerSubtitle = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbTrailerLanguageSound = New DevExpress.XtraEditors.LookUpEdit
        Me.txtTrailerFilename = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.txtTrailerImdb = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.btnTrailerSave = New DevExpress.XtraEditors.SimpleButton
        Me.btnTrailerEdit = New DevExpress.XtraEditors.SimpleButton
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit
        Me.FolderChoose = New System.Windows.Forms.FolderBrowserDialog
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit
        Me.DateEdit4 = New DevExpress.XtraEditors.DateEdit
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TextEdit11 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit12 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.CheckEdit3 = New DevExpress.XtraEditors.CheckEdit
        Me.CheckEdit4 = New DevExpress.XtraEditors.CheckEdit
        Me.SpinEdit2 = New DevExpress.XtraEditors.SpinEdit
        Me.CheckEdit5 = New DevExpress.XtraEditors.CheckEdit
        Me.DateEdit5 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit6 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit7 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit8 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.TextEdit13 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit14 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl
        Me.CheckEdit6 = New DevExpress.XtraEditors.CheckEdit
        Me.CheckEdit7 = New DevExpress.XtraEditors.CheckEdit
        Me.SpinEdit3 = New DevExpress.XtraEditors.SpinEdit
        Me.CheckEdit8 = New DevExpress.XtraEditors.CheckEdit
        Me.DateEdit9 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit10 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit11 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit12 = New DevExpress.XtraEditors.DateEdit
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl
        Me.LookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl
        Me.LookUpEdit3 = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl
        Me.LookUpEdit5 = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl
        Me.LookUpEdit8 = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton
        Me.LookUpEdit9 = New DevExpress.XtraEditors.LookUpEdit
        Me.LookUpEdit10 = New DevExpress.XtraEditors.LookUpEdit
        Me.TextEdit15 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit16 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton10 = New DevExpress.XtraEditors.SimpleButton
        Me.chkVideoland = New DevExpress.XtraEditors.CheckEdit
        colDateStartUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        GridViewInvoiceItems = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(GridViewInvoiceItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpStartOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpStartOn.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpEndOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpEndOn.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupSVODKind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpPrepaidStartOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpPrepaidStartOn.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpPrepaidEndOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpPrepaidEndOn.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSVODDates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XTabVODAndTrailers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabVODAndTrailers.SuspendLayout()
        Me.xTabTrailers.SuspendLayout()
        CType(Me.grdTrailers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTrailers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryBtnWatchTrailer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repLanguageTrailers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repSubtitleTrailers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbgridStatusTrailer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguagesTrailers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSubtitleTrailers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabSearch.SuspendLayout()
        CType(Me.txtImdb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtProducts_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabResult.SuspendLayout()
        CType(Me.GridVod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnedtCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbgridStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguagesSubtitleEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpDateStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpDateStart.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateExpired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateExpired.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpBackcatalogueStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpBackcatalogueStart.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpBackcataloguExpired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpBackcataloguExpired.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkcolAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositorycmbSupportVod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabView.SuspendLayout()
        CType(Me.txtEpisodeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSeasonID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDRM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateExpired.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateExpired.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsPPV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateLaterStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateLaterStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPPVPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateLaterExpired.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateLaterExpired.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAvailable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtIdNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPPVPriceNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsPPVNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAvailableNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateLaterExpiredNL.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateLaterExpiredNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateLaterStartNL.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateLaterStartNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateExpiredNL.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateExpiredNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateStartNL.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateStartNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbLuxemburg.SuspendLayout()
        CType(Me.txtIdLU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPPVPriceLU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsPPVLU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAvailableLU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateLaterExpiredLU.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateLaterExpiredLU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateLaterStartLU.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateLaterStartLU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateExpiredLU.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateExpiredLU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateStartLU.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateStartLU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSupportVod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbQuality.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStudioEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguageSubtitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguageSound.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFilename.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImdbView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabProcess.SuspendLayout()
        CType(Me.txtDestinationPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSourcePath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarRipping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabViewVod.SuspendLayout()
        CType(Me.GridVodWatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewVodWatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryBtnWatchMovie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryCmbStudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositorycmbLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryLanguageSubtitleGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositorychkAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabFtp.SuspendLayout()
        CType(Me.txtSourceFtp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSourceLocal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDBFtp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDBFtp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridFtpLocal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewFtpLocal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtabAutomateTranscode.SuspendLayout()
        CType(Me.txtPathOfFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xTabVODOnlyMovie.SuspendLayout()
        CType(Me.grdOnlyVODMovie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabTrailerSearch.SuspendLayout()
        CType(Me.txtTrailerImdbSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrailerProductsIDSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrailerTitleSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabTrailerResult.SuspendLayout()
        CType(Me.gridTrailersResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTrailer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTrailerLanguageGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTrailerSubtitleGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabTrailerView.SuspendLayout()
        CType(Me.txtTrailerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTrailerDateStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTrailerDateStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTRailerDateExpired.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTRailerDateExpired.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTrailerAvailable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdTrailerStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTrailerSubtitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTrailerLanguageSound.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrailerFilename.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrailerImdb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit4.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit5.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit6.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit7.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit8.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.TextEdit13.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit9.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit10.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit11.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit12.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit15.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit16.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVideoland.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colDateStartUploaded
        '
        colDateStartUploaded.Caption = "date start"
        colDateStartUploaded.FieldName = "available_from"
        colDateStartUploaded.Name = "colDateStartUploaded"
        colDateStartUploaded.OptionsColumn.AllowEdit = False
        colDateStartUploaded.Visible = True
        colDateStartUploaded.Width = 48
        '
        'GridViewInvoiceItems
        '
        GridViewInvoiceItems.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand9})
        GridViewInvoiceItems.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colID, Me.colStartOn, Me.colIMDB, Me.colEndOn, Me.colCreatedAt, Me.colUpdatedAt, Me.colKind, Me.colPrepaidStartOn, Me.colPrepaidEndOn})
        GridViewInvoiceItems.CustomizationFormBounds = New System.Drawing.Rectangle(755, 333, 217, 222)
        GridViewInvoiceItems.GridControl = Me.GridSVODDates
        GridViewInvoiceItems.Name = "GridViewInvoiceItems"
        GridViewInvoiceItems.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValesMode.Disabled
        GridViewInvoiceItems.OptionsNavigation.AutoFocusNewRow = True
        GridViewInvoiceItems.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        GridViewInvoiceItems.OptionsView.ShowBands = False
        GridViewInvoiceItems.OptionsView.ShowDetailButtons = False
        GridViewInvoiceItems.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        GridViewInvoiceItems.OptionsView.ShowGroupPanel = False
        '
        'GridBand9
        '
        Me.GridBand9.Caption = "gridBand1"
        Me.GridBand9.Columns.Add(Me.colStartOn)
        Me.GridBand9.Columns.Add(Me.colEndOn)
        Me.GridBand9.Columns.Add(Me.colCreatedAt)
        Me.GridBand9.Columns.Add(Me.colUpdatedAt)
        Me.GridBand9.Columns.Add(Me.colKind)
        Me.GridBand9.Columns.Add(Me.colPrepaidStartOn)
        Me.GridBand9.Columns.Add(Me.colPrepaidEndOn)
        Me.GridBand9.MinWidth = 20
        Me.GridBand9.Name = "GridBand9"
        Me.GridBand9.Width = 913
        '
        'colStartOn
        '
        Me.colStartOn.Caption = "start on"
        Me.colStartOn.ColumnEdit = Me.dpStartOn
        Me.colStartOn.FieldName = "start_on"
        Me.colStartOn.Name = "colStartOn"
        Me.colStartOn.Visible = True
        Me.colStartOn.Width = 138
        '
        'dpStartOn
        '
        Me.dpStartOn.AutoHeight = False
        Me.dpStartOn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpStartOn.Name = "dpStartOn"
        Me.dpStartOn.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'colEndOn
        '
        Me.colEndOn.Caption = "end on"
        Me.colEndOn.ColumnEdit = Me.dpEndOn
        Me.colEndOn.FieldName = "end_on"
        Me.colEndOn.Name = "colEndOn"
        Me.colEndOn.Visible = True
        Me.colEndOn.Width = 131
        '
        'dpEndOn
        '
        Me.dpEndOn.AutoHeight = False
        Me.dpEndOn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpEndOn.Name = "dpEndOn"
        Me.dpEndOn.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'colCreatedAt
        '
        Me.colCreatedAt.Caption = "created at"
        Me.colCreatedAt.FieldName = "created_at"
        Me.colCreatedAt.Name = "colCreatedAt"
        Me.colCreatedAt.OptionsColumn.AllowEdit = False
        Me.colCreatedAt.Visible = True
        Me.colCreatedAt.Width = 97
        '
        'colUpdatedAt
        '
        Me.colUpdatedAt.Caption = "updated_at"
        Me.colUpdatedAt.FieldName = "updated_at"
        Me.colUpdatedAt.Name = "colUpdatedAt"
        Me.colUpdatedAt.OptionsColumn.AllowEdit = False
        Me.colUpdatedAt.Visible = True
        Me.colUpdatedAt.Width = 91
        '
        'colKind
        '
        Me.colKind.Caption = "Kind"
        Me.colKind.ColumnEdit = Me.lkupSVODKind
        Me.colKind.FieldName = "kind"
        Me.colKind.Name = "colKind"
        Me.colKind.Visible = True
        Me.colKind.Width = 146
        '
        'lkupSVODKind
        '
        Me.lkupSVODKind.AutoHeight = False
        Me.lkupSVODKind.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupSVODKind.Name = "lkupSVODKind"
        '
        'colPrepaidStartOn
        '
        Me.colPrepaidStartOn.Caption = "prepaid start on"
        Me.colPrepaidStartOn.ColumnEdit = Me.dpPrepaidStartOn
        Me.colPrepaidStartOn.FieldName = "prepaid_start_on"
        Me.colPrepaidStartOn.Name = "colPrepaidStartOn"
        Me.colPrepaidStartOn.Visible = True
        Me.colPrepaidStartOn.Width = 167
        '
        'dpPrepaidStartOn
        '
        Me.dpPrepaidStartOn.AutoHeight = False
        Me.dpPrepaidStartOn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpPrepaidStartOn.Name = "dpPrepaidStartOn"
        Me.dpPrepaidStartOn.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'colPrepaidEndOn
        '
        Me.colPrepaidEndOn.Caption = "prepaid end on"
        Me.colPrepaidEndOn.ColumnEdit = Me.dpPrepaidEndOn
        Me.colPrepaidEndOn.FieldName = "prepaid_end_on"
        Me.colPrepaidEndOn.Name = "colPrepaidEndOn"
        Me.colPrepaidEndOn.Visible = True
        Me.colPrepaidEndOn.Width = 143
        '
        'dpPrepaidEndOn
        '
        Me.dpPrepaidEndOn.AutoHeight = False
        Me.dpPrepaidEndOn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpPrepaidEndOn.Name = "dpPrepaidEndOn"
        Me.dpPrepaidEndOn.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'colID
        '
        Me.colID.Caption = "id"
        Me.colID.FieldName = "id"
        Me.colID.Name = "colID"
        '
        'colIMDB
        '
        Me.colIMDB.Caption = "imdb"
        Me.colIMDB.FieldName = "imdb_id"
        Me.colIMDB.Name = "colIMDB"
        '
        'GridSVODDates
        '
        Me.GridSVODDates.AllowDrop = True
        Me.GridSVODDates.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridSVODDates.EmbeddedNavigator.AllowDrop = True
        Me.GridSVODDates.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridSVODDates.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridSVODDates.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridSVODDates.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridSVODDates.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridSVODDates.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridSVODDates.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridSVODDates.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridSVODDates.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridSVODDates.EmbeddedNavigator.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.GridSVODDates.EmbeddedNavigator.Name = ""
        Me.GridSVODDates.FormsUseDefaultLookAndFeel = False
        Me.GridSVODDates.Location = New System.Drawing.Point(324, 97)
        Me.GridSVODDates.MainView = GridViewInvoiceItems
        Me.GridSVODDates.Name = "GridSVODDates"
        Me.GridSVODDates.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkupSVODKind, Me.dpPrepaidStartOn, Me.dpPrepaidEndOn})
        Me.GridSVODDates.Size = New System.Drawing.Size(655, 240)
        Me.GridSVODDates.TabIndex = 138
        Me.GridSVODDates.UseEmbeddedNavigator = True
        Me.GridSVODDates.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {GridViewInvoiceItems})
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "languages_id", 82, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 32, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "name"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "languages_id"
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "Name29", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "Name30", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.RepositoryItemLookUpEdit3.DisplayMember = "code"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = CType(1, Byte)
        Me.RepositoryItemCheckEdit1.ValueUnchecked = CType(0, Byte)
        '
        'BarManager1
        '
        Me.BarManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("Main", New System.Guid("434484d9-7ac5-47e5-9412-313a111b7240")), New DevExpress.XtraBars.BarManagerCategory("Miscelaneous", New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")), New DevExpress.XtraBars.BarManagerCategory("Views", New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")), New DevExpress.XtraBars.BarManagerCategory("Filters", New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")), New DevExpress.XtraBars.BarManagerCategory("Reporting", New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")), New DevExpress.XtraBars.BarManagerCategory("Default Values", New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")), New DevExpress.XtraBars.BarManagerCategory("Quick Search", New System.Guid("2d735e09-7c7c-4ed4-b3ca-996e094a2026")), New DevExpress.XtraBars.BarManagerCategory("Misc_Maintenance", New System.Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")), New DevExpress.XtraBars.BarManagerCategory("Navigation", New System.Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90"))})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 73
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbViewListRepos, Me.txtQuickSearchRepos, Me.cmbReportListRepos, Me.cmbFilterListRepos, Me.cmbDefaultListRepos})
        '
        'Main_Bar
        '
        Me.Main_Bar.BarName = "Main_Bar"
        Me.Main_Bar.DockCol = 0
        Me.Main_Bar.DockRow = 0
        Me.Main_Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Main_Bar.FloatLocation = New System.Drawing.Point(246, 185)
        Me.Main_Bar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnNew), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUndo)})
        Me.Main_Bar.Offset = 7
        Me.Main_Bar.Text = "Main Bar"
        Me.Main_Bar.Visible = False
        '
        'btnNew
        '
        Me.btnNew.Caption = "New"
        Me.btnNew.CategoryGuid = New System.Guid("434484d9-7ac5-47e5-9412-313a111b7240")
        Me.btnNew.Glyph = CType(resources.GetObject("btnNew.Glyph"), System.Drawing.Image)
        Me.btnNew.Id = 0
        Me.btnNew.Name = "btnNew"
        '
        'btnEdit
        '
        Me.btnEdit.Caption = "Edit"
        Me.btnEdit.CategoryGuid = New System.Guid("434484d9-7ac5-47e5-9412-313a111b7240")
        Me.btnEdit.Glyph = CType(resources.GetObject("btnEdit.Glyph"), System.Drawing.Image)
        Me.btnEdit.Id = 2
        Me.btnEdit.Name = "btnEdit"
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.CategoryGuid = New System.Guid("434484d9-7ac5-47e5-9412-313a111b7240")
        Me.btnDelete.Glyph = CType(resources.GetObject("btnDelete.Glyph"), System.Drawing.Image)
        Me.btnDelete.Id = 1
        Me.btnDelete.Name = "btnDelete"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.CategoryGuid = New System.Guid("434484d9-7ac5-47e5-9412-313a111b7240")
        Me.btnSave.Glyph = CType(resources.GetObject("btnSave.Glyph"), System.Drawing.Image)
        Me.btnSave.Id = 3
        Me.btnSave.Name = "btnSave"
        '
        'btnUndo
        '
        Me.btnUndo.Caption = "Undo"
        Me.btnUndo.Glyph = CType(resources.GetObject("btnUndo.Glyph"), System.Drawing.Image)
        Me.btnUndo.Id = 70
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'Misc_Bar
        '
        Me.Misc_Bar.BarName = "Misc_Bar"
        Me.Misc_Bar.DockCol = 1
        Me.Misc_Bar.DockRow = 0
        Me.Misc_Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Misc_Bar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.MainBtns_btnExcel), New DevExpress.XtraBars.LinkPersistInfo(Me.MainBtns_btnBigger), New DevExpress.XtraBars.LinkPersistInfo(Me.MainBtns_btnSmaller), New DevExpress.XtraBars.LinkPersistInfo(Me.MainBtns_btnBestFit), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnOK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUser1), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUser2), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUser3), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUser4), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUser5), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExportXML), New DevExpress.XtraBars.LinkPersistInfo(Me.btnImportXML)})
        Me.Misc_Bar.Offset = 182
        Me.Misc_Bar.Text = "Misc. Bar"
        Me.Misc_Bar.Visible = False
        '
        'MainBtns_btnExcel
        '
        Me.MainBtns_btnExcel.Caption = "Excell"
        Me.MainBtns_btnExcel.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.MainBtns_btnExcel.Glyph = CType(resources.GetObject("MainBtns_btnExcel.Glyph"), System.Drawing.Image)
        Me.MainBtns_btnExcel.Id = 5
        Me.MainBtns_btnExcel.Name = "MainBtns_btnExcel"
        '
        'MainBtns_btnBigger
        '
        Me.MainBtns_btnBigger.Caption = "Bigger"
        Me.MainBtns_btnBigger.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.MainBtns_btnBigger.Glyph = CType(resources.GetObject("MainBtns_btnBigger.Glyph"), System.Drawing.Image)
        Me.MainBtns_btnBigger.Id = 6
        Me.MainBtns_btnBigger.Name = "MainBtns_btnBigger"
        '
        'MainBtns_btnSmaller
        '
        Me.MainBtns_btnSmaller.Caption = "Smaller"
        Me.MainBtns_btnSmaller.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.MainBtns_btnSmaller.Glyph = CType(resources.GetObject("MainBtns_btnSmaller.Glyph"), System.Drawing.Image)
        Me.MainBtns_btnSmaller.Id = 7
        Me.MainBtns_btnSmaller.Name = "MainBtns_btnSmaller"
        '
        'MainBtns_btnBestFit
        '
        Me.MainBtns_btnBestFit.Caption = "BestFit"
        Me.MainBtns_btnBestFit.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.MainBtns_btnBestFit.Glyph = CType(resources.GetObject("MainBtns_btnBestFit.Glyph"), System.Drawing.Image)
        Me.MainBtns_btnBestFit.Id = 8
        Me.MainBtns_btnBestFit.Name = "MainBtns_btnBestFit"
        '
        'btnOK
        '
        Me.btnOK.Caption = "OK"
        Me.btnOK.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.btnOK.Glyph = CType(resources.GetObject("btnOK.Glyph"), System.Drawing.Image)
        Me.btnOK.Id = 46
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnUser1
        '
        Me.btnUser1.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnUser1.Caption = "1"
        Me.btnUser1.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.btnUser1.Id = 58
        Me.btnUser1.Name = "btnUser1"
        Me.btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnUser2
        '
        Me.btnUser2.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnUser2.Caption = "2"
        Me.btnUser2.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.btnUser2.Id = 59
        Me.btnUser2.Name = "btnUser2"
        Me.btnUser2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnUser3
        '
        Me.btnUser3.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnUser3.Caption = "3"
        Me.btnUser3.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.btnUser3.Id = 60
        Me.btnUser3.Name = "btnUser3"
        Me.btnUser3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnUser4
        '
        Me.btnUser4.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnUser4.Caption = "4"
        Me.btnUser4.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.btnUser4.Id = 61
        Me.btnUser4.Name = "btnUser4"
        Me.btnUser4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnUser5
        '
        Me.btnUser5.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnUser5.Caption = "5"
        Me.btnUser5.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.btnUser5.Id = 62
        Me.btnUser5.Name = "btnUser5"
        Me.btnUser5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnExportXML
        '
        Me.btnExportXML.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnExportXML.Caption = "Export"
        Me.btnExportXML.Id = 71
        Me.btnExportXML.Name = "btnExportXML"
        '
        'btnImportXML
        '
        Me.btnImportXML.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnImportXML.Caption = "Import"
        Me.btnImportXML.Id = 72
        Me.btnImportXML.Name = "btnImportXML"
        '
        'View_Bar
        '
        Me.View_Bar.BarName = "View_Bar"
        Me.View_Bar.DockCol = 4
        Me.View_Bar.DockRow = 0
        Me.View_Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.View_Bar.FloatLocation = New System.Drawing.Point(517, 188)
        Me.View_Bar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnView), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.cmbViewList, "", False, True, True, 133), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnViewDetail, DevExpress.XtraBars.BarItemPaintStyle.Standard)})
        Me.View_Bar.Offset = 395
        Me.View_Bar.Text = "View Bar"
        Me.View_Bar.Visible = False
        '
        'btnView
        '
        Me.btnView.Caption = "View"
        Me.btnView.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnView.Glyph = CType(resources.GetObject("btnView.Glyph"), System.Drawing.Image)
        Me.btnView.Id = 19
        Me.btnView.Name = "btnView"
        '
        'cmbViewList
        '
        Me.cmbViewList.Caption = "ViewList"
        Me.cmbViewList.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.cmbViewList.Edit = Me.cmbViewListRepos
        Me.cmbViewList.Id = 21
        Me.cmbViewList.Name = "cmbViewList"
        '
        'btnEditView
        '
        Me.btnEditView.Caption = "Edit"
        Me.btnEditView.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnEditView.Glyph = CType(resources.GetObject("btnEditView.Glyph"), System.Drawing.Image)
        Me.btnEditView.Id = 13
        Me.btnEditView.Name = "btnEditView"
        '
        'btnNewView
        '
        Me.btnNewView.Caption = "New"
        Me.btnNewView.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnNewView.Glyph = CType(resources.GetObject("btnNewView.Glyph"), System.Drawing.Image)
        Me.btnNewView.Id = 12
        Me.btnNewView.Name = "btnNewView"
        '
        'btnDeleteView
        '
        Me.btnDeleteView.Caption = "Delete"
        Me.btnDeleteView.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnDeleteView.Glyph = CType(resources.GetObject("btnDeleteView.Glyph"), System.Drawing.Image)
        Me.btnDeleteView.Id = 14
        Me.btnDeleteView.Name = "btnDeleteView"
        '
        'btnSaveView
        '
        Me.btnSaveView.Caption = "Save"
        Me.btnSaveView.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnSaveView.Glyph = CType(resources.GetObject("btnSaveView.Glyph"), System.Drawing.Image)
        Me.btnSaveView.Id = 17
        Me.btnSaveView.Name = "btnSaveView"
        '
        'btnMakeViewCommon
        '
        Me.btnMakeViewCommon.Caption = "Make Common"
        Me.btnMakeViewCommon.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnMakeViewCommon.Glyph = CType(resources.GetObject("btnMakeViewCommon.Glyph"), System.Drawing.Image)
        Me.btnMakeViewCommon.Id = 15
        Me.btnMakeViewCommon.Name = "btnMakeViewCommon"
        '
        'btnSendViewUser
        '
        Me.btnSendViewUser.Caption = "Send to USer"
        Me.btnSendViewUser.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnSendViewUser.Glyph = CType(resources.GetObject("btnSendViewUser.Glyph"), System.Drawing.Image)
        Me.btnSendViewUser.Id = 16
        Me.btnSendViewUser.Name = "btnSendViewUser"
        '
        'btnCopyView
        '
        Me.btnCopyView.Caption = "Copy"
        Me.btnCopyView.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnCopyView.Glyph = CType(resources.GetObject("btnCopyView.Glyph"), System.Drawing.Image)
        Me.btnCopyView.Id = 18
        Me.btnCopyView.Name = "btnCopyView"
        '
        'QuickSearch_Bar
        '
        Me.QuickSearch_Bar.BarName = "QuickSearch_Bar"
        Me.QuickSearch_Bar.DockCol = 2
        Me.QuickSearch_Bar.DockRow = 0
        Me.QuickSearch_Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.QuickSearch_Bar.FloatLocation = New System.Drawing.Point(251, 153)
        Me.QuickSearch_Bar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.txtQuickSearch, "", False, True, True, 122), New DevExpress.XtraBars.LinkPersistInfo(Me.btnQuickSearch)})
        Me.QuickSearch_Bar.Offset = 498
        Me.QuickSearch_Bar.Text = "Quick Search Bar"
        Me.QuickSearch_Bar.Visible = False
        '
        'txtQuickSearch
        '
        Me.txtQuickSearch.CategoryGuid = New System.Guid("2d735e09-7c7c-4ed4-b3ca-996e094a2026")
        Me.txtQuickSearch.Edit = Me.txtQuickSearchRepos
        Me.txtQuickSearch.Id = 23
        Me.txtQuickSearch.Name = "txtQuickSearch"
        '
        'btnQuickSearch
        '
        Me.btnQuickSearch.Caption = "Search"
        Me.btnQuickSearch.CategoryGuid = New System.Guid("2d735e09-7c7c-4ed4-b3ca-996e094a2026")
        Me.btnQuickSearch.Glyph = CType(resources.GetObject("btnQuickSearch.Glyph"), System.Drawing.Image)
        Me.btnQuickSearch.Id = 22
        Me.btnQuickSearch.Name = "btnQuickSearch"
        '
        'Report_Bar
        '
        Me.Report_Bar.BarName = "Report_Bar"
        Me.Report_Bar.DockCol = 7
        Me.Report_Bar.DockRow = 0
        Me.Report_Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Report_Bar.FloatLocation = New System.Drawing.Point(31, 162)
        Me.Report_Bar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrint), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.cmbReportList, "", False, True, True, 131), New DevExpress.XtraBars.LinkPersistInfo(Me.btnReportDetail)})
        Me.Report_Bar.Offset = 1065
        Me.Report_Bar.Text = "Report Bar"
        Me.Report_Bar.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.Caption = "Print"
        Me.btnPrint.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnPrint.Glyph = CType(resources.GetObject("btnPrint.Glyph"), System.Drawing.Image)
        Me.btnPrint.Id = 24
        Me.btnPrint.Name = "btnPrint"
        '
        'cmbReportList
        '
        Me.cmbReportList.Caption = "Report List"
        Me.cmbReportList.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.cmbReportList.Edit = Me.cmbReportListRepos
        Me.cmbReportList.Id = 26
        Me.cmbReportList.Name = "cmbReportList"
        '
        'btnEditReportInfo
        '
        Me.btnEditReportInfo.Caption = "Edit"
        Me.btnEditReportInfo.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnEditReportInfo.Glyph = CType(resources.GetObject("btnEditReportInfo.Glyph"), System.Drawing.Image)
        Me.btnEditReportInfo.Id = 28
        Me.btnEditReportInfo.Name = "btnEditReportInfo"
        '
        'btnNewReport
        '
        Me.btnNewReport.Caption = "New"
        Me.btnNewReport.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnNewReport.Glyph = CType(resources.GetObject("btnNewReport.Glyph"), System.Drawing.Image)
        Me.btnNewReport.Id = 29
        Me.btnNewReport.Name = "btnNewReport"
        '
        'btnDeleteReport
        '
        Me.btnDeleteReport.Caption = "Delete"
        Me.btnDeleteReport.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnDeleteReport.Glyph = CType(resources.GetObject("btnDeleteReport.Glyph"), System.Drawing.Image)
        Me.btnDeleteReport.Id = 30
        Me.btnDeleteReport.Name = "btnDeleteReport"
        '
        'btnDesignReport
        '
        Me.btnDesignReport.Caption = "Design Report"
        Me.btnDesignReport.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnDesignReport.Glyph = CType(resources.GetObject("btnDesignReport.Glyph"), System.Drawing.Image)
        Me.btnDesignReport.Id = 31
        Me.btnDesignReport.Name = "btnDesignReport"
        '
        'btnMakeReportCommon
        '
        Me.btnMakeReportCommon.Caption = "Make Common"
        Me.btnMakeReportCommon.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnMakeReportCommon.Glyph = CType(resources.GetObject("btnMakeReportCommon.Glyph"), System.Drawing.Image)
        Me.btnMakeReportCommon.Id = 32
        Me.btnMakeReportCommon.Name = "btnMakeReportCommon"
        '
        'btnSendReportUser
        '
        Me.btnSendReportUser.Caption = "Send to User"
        Me.btnSendReportUser.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnSendReportUser.Glyph = CType(resources.GetObject("btnSendReportUser.Glyph"), System.Drawing.Image)
        Me.btnSendReportUser.Id = 33
        Me.btnSendReportUser.Name = "btnSendReportUser"
        '
        'btnCopyReport
        '
        Me.btnCopyReport.Caption = "Copy"
        Me.btnCopyReport.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnCopyReport.Glyph = CType(resources.GetObject("btnCopyReport.Glyph"), System.Drawing.Image)
        Me.btnCopyReport.Id = 34
        Me.btnCopyReport.Name = "btnCopyReport"
        '
        'Filter_Bar
        '
        Me.Filter_Bar.BarName = "Filter_Bar"
        Me.Filter_Bar.DockCol = 5
        Me.Filter_Bar.DockRow = 0
        Me.Filter_Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Filter_Bar.FloatLocation = New System.Drawing.Point(337, 218)
        Me.Filter_Bar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnFilter), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.cmbFilterList, "", False, True, True, 132), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFilterDetail)})
        Me.Filter_Bar.Offset = 1053
        Me.Filter_Bar.Text = "Filter Bar"
        Me.Filter_Bar.Visible = False
        '
        'btnFilter
        '
        Me.btnFilter.Caption = "btnFilter"
        Me.btnFilter.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnFilter.Glyph = CType(resources.GetObject("btnFilter.Glyph"), System.Drawing.Image)
        Me.btnFilter.Id = 35
        Me.btnFilter.Name = "btnFilter"
        '
        'cmbFilterList
        '
        Me.cmbFilterList.Caption = "cmbFilterList"
        Me.cmbFilterList.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.cmbFilterList.Edit = Me.cmbFilterListRepos
        Me.cmbFilterList.Id = 38
        Me.cmbFilterList.Name = "cmbFilterList"
        '
        'btnEditFilter
        '
        Me.btnEditFilter.Caption = "Edit"
        Me.btnEditFilter.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnEditFilter.Glyph = CType(resources.GetObject("btnEditFilter.Glyph"), System.Drawing.Image)
        Me.btnEditFilter.Id = 39
        Me.btnEditFilter.Name = "btnEditFilter"
        '
        'btnNewFilter
        '
        Me.btnNewFilter.Caption = "New"
        Me.btnNewFilter.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnNewFilter.Glyph = CType(resources.GetObject("btnNewFilter.Glyph"), System.Drawing.Image)
        Me.btnNewFilter.Id = 40
        Me.btnNewFilter.Name = "btnNewFilter"
        '
        'btnDeleteFilter
        '
        Me.btnDeleteFilter.Caption = "Delete"
        Me.btnDeleteFilter.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnDeleteFilter.Glyph = CType(resources.GetObject("btnDeleteFilter.Glyph"), System.Drawing.Image)
        Me.btnDeleteFilter.Id = 41
        Me.btnDeleteFilter.Name = "btnDeleteFilter"
        '
        'btnMakeFilterCommon
        '
        Me.btnMakeFilterCommon.Caption = "Make Common"
        Me.btnMakeFilterCommon.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnMakeFilterCommon.Glyph = CType(resources.GetObject("btnMakeFilterCommon.Glyph"), System.Drawing.Image)
        Me.btnMakeFilterCommon.Id = 43
        Me.btnMakeFilterCommon.Name = "btnMakeFilterCommon"
        '
        'btnSendFilterUSer
        '
        Me.btnSendFilterUSer.Caption = "Send to USer"
        Me.btnSendFilterUSer.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnSendFilterUSer.Glyph = CType(resources.GetObject("btnSendFilterUSer.Glyph"), System.Drawing.Image)
        Me.btnSendFilterUSer.Id = 44
        Me.btnSendFilterUSer.Name = "btnSendFilterUSer"
        '
        'btnCopyFilter
        '
        Me.btnCopyFilter.Caption = "Copy"
        Me.btnCopyFilter.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnCopyFilter.Glyph = CType(resources.GetObject("btnCopyFilter.Glyph"), System.Drawing.Image)
        Me.btnCopyFilter.Id = 45
        Me.btnCopyFilter.Name = "btnCopyFilter"
        '
        'DefaultSet_Bar
        '
        Me.DefaultSet_Bar.BarName = "DefaultSet_Bar"
        Me.DefaultSet_Bar.DockCol = 6
        Me.DefaultSet_Bar.DockRow = 0
        Me.DefaultSet_Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.DefaultSet_Bar.FloatLocation = New System.Drawing.Point(298, 224)
        Me.DefaultSet_Bar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnDefault), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.cmbDefaultList, "", False, True, True, 132), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDefaultDetail)})
        Me.DefaultSet_Bar.Offset = 1060
        Me.DefaultSet_Bar.Text = "Default Set Bar"
        Me.DefaultSet_Bar.Visible = False
        '
        'btnDefault
        '
        Me.btnDefault.Caption = "Default"
        Me.btnDefault.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnDefault.Glyph = CType(resources.GetObject("btnDefault.Glyph"), System.Drawing.Image)
        Me.btnDefault.Id = 47
        Me.btnDefault.Name = "btnDefault"
        '
        'cmbDefaultList
        '
        Me.cmbDefaultList.Caption = "cmbDefaultList"
        Me.cmbDefaultList.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.cmbDefaultList.Edit = Me.cmbDefaultListRepos
        Me.cmbDefaultList.Id = 49
        Me.cmbDefaultList.Name = "cmbDefaultList"
        '
        'btnEditDefault
        '
        Me.btnEditDefault.Caption = "Edit"
        Me.btnEditDefault.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnEditDefault.Glyph = CType(resources.GetObject("btnEditDefault.Glyph"), System.Drawing.Image)
        Me.btnEditDefault.Id = 51
        Me.btnEditDefault.Name = "btnEditDefault"
        '
        'btnNewDefault
        '
        Me.btnNewDefault.Caption = "New"
        Me.btnNewDefault.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnNewDefault.Glyph = CType(resources.GetObject("btnNewDefault.Glyph"), System.Drawing.Image)
        Me.btnNewDefault.Id = 52
        Me.btnNewDefault.Name = "btnNewDefault"
        '
        'btnDeleteDefault
        '
        Me.btnDeleteDefault.Caption = "Delete"
        Me.btnDeleteDefault.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnDeleteDefault.Glyph = CType(resources.GetObject("btnDeleteDefault.Glyph"), System.Drawing.Image)
        Me.btnDeleteDefault.Id = 53
        Me.btnDeleteDefault.Name = "btnDeleteDefault"
        '
        'btnSaveDefault
        '
        Me.btnSaveDefault.Caption = "Save"
        Me.btnSaveDefault.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnSaveDefault.Glyph = CType(resources.GetObject("btnSaveDefault.Glyph"), System.Drawing.Image)
        Me.btnSaveDefault.Id = 54
        Me.btnSaveDefault.Name = "btnSaveDefault"
        '
        'btnMakeDefaultCommon
        '
        Me.btnMakeDefaultCommon.Caption = "Make Common"
        Me.btnMakeDefaultCommon.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnMakeDefaultCommon.Glyph = CType(resources.GetObject("btnMakeDefaultCommon.Glyph"), System.Drawing.Image)
        Me.btnMakeDefaultCommon.Id = 55
        Me.btnMakeDefaultCommon.Name = "btnMakeDefaultCommon"
        '
        'btnSendDefaultUser
        '
        Me.btnSendDefaultUser.Caption = "Send to USer"
        Me.btnSendDefaultUser.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnSendDefaultUser.Glyph = CType(resources.GetObject("btnSendDefaultUser.Glyph"), System.Drawing.Image)
        Me.btnSendDefaultUser.Id = 56
        Me.btnSendDefaultUser.Name = "btnSendDefaultUser"
        '
        'btnCopyDefault
        '
        Me.btnCopyDefault.Caption = "Copy"
        Me.btnCopyDefault.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnCopyDefault.Glyph = CType(resources.GetObject("btnCopyDefault.Glyph"), System.Drawing.Image)
        Me.btnCopyDefault.Id = 57
        Me.btnCopyDefault.Name = "btnCopyDefault"
        '
        'Misc_Bar2
        '
        Me.Misc_Bar2.BarName = "Misc_Bar2"
        Me.Misc_Bar2.DockCol = 8
        Me.Misc_Bar2.DockRow = 0
        Me.Misc_Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Misc_Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnTranslation), New DevExpress.XtraBars.LinkPersistInfo(Me.btnComments), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAttachements)})
        Me.Misc_Bar2.Offset = 1123
        Me.Misc_Bar2.Text = "Misc_Bar2 for Maintenance Screen"
        Me.Misc_Bar2.Visible = False
        '
        'btnTranslation
        '
        Me.btnTranslation.Caption = "Translation"
        Me.btnTranslation.CategoryGuid = New System.Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")
        Me.btnTranslation.Glyph = CType(resources.GetObject("btnTranslation.Glyph"), System.Drawing.Image)
        Me.btnTranslation.Id = 63
        Me.btnTranslation.Name = "btnTranslation"
        '
        'btnComments
        '
        Me.btnComments.Caption = "Comments"
        Me.btnComments.CategoryGuid = New System.Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")
        Me.btnComments.Glyph = CType(resources.GetObject("btnComments.Glyph"), System.Drawing.Image)
        Me.btnComments.Id = 64
        Me.btnComments.Name = "btnComments"
        '
        'btnAttachements
        '
        Me.btnAttachements.Caption = "Attachements"
        Me.btnAttachements.CategoryGuid = New System.Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")
        Me.btnAttachements.Glyph = CType(resources.GetObject("btnAttachements.Glyph"), System.Drawing.Image)
        Me.btnAttachements.Id = 65
        Me.btnAttachements.Name = "btnAttachements"
        '
        'Nav_Bar
        '
        Me.Nav_Bar.BarName = "Nav_Bar"
        Me.Nav_Bar.DockCol = 3
        Me.Nav_Bar.DockRow = 0
        Me.Nav_Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Nav_Bar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnFirst), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrevious), New DevExpress.XtraBars.LinkPersistInfo(Me.btnNext), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLast)})
        Me.Nav_Bar.Offset = 172
        Me.Nav_Bar.Text = "Nav Bar"
        Me.Nav_Bar.Visible = False
        '
        'btnFirst
        '
        Me.btnFirst.Caption = "First"
        Me.btnFirst.CategoryGuid = New System.Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
        Me.btnFirst.Glyph = CType(resources.GetObject("btnFirst.Glyph"), System.Drawing.Image)
        Me.btnFirst.Id = 66
        Me.btnFirst.Name = "btnFirst"
        '
        'btnPrevious
        '
        Me.btnPrevious.Caption = "Previous"
        Me.btnPrevious.CategoryGuid = New System.Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
        Me.btnPrevious.Glyph = CType(resources.GetObject("btnPrevious.Glyph"), System.Drawing.Image)
        Me.btnPrevious.Id = 67
        Me.btnPrevious.Name = "btnPrevious"
        '
        'btnNext
        '
        Me.btnNext.Caption = "Next"
        Me.btnNext.CategoryGuid = New System.Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
        Me.btnNext.Glyph = CType(resources.GetObject("btnNext.Glyph"), System.Drawing.Image)
        Me.btnNext.Id = 68
        Me.btnNext.Name = "btnNext"
        '
        'btnLast
        '
        Me.btnLast.Caption = "Last"
        Me.btnLast.CategoryGuid = New System.Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
        Me.btnLast.Glyph = CType(resources.GetObject("btnLast.Glyph"), System.Drawing.Image)
        Me.btnLast.Id = 69
        Me.btnLast.Name = "btnLast"
        '
        'XTabVODAndTrailers
        '
        Me.XTabVODAndTrailers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTabVODAndTrailers.Location = New System.Drawing.Point(0, 30)
        Me.XTabVODAndTrailers.Name = "XTabVODAndTrailers"
        Me.XTabVODAndTrailers.SelectedTabPage = Me.xTabTrailers
        Me.XTabVODAndTrailers.Size = New System.Drawing.Size(1009, 725)
        Me.XTabVODAndTrailers.TabIndex = 4
        Me.XTabVODAndTrailers.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTabSearch, Me.XTabResult, Me.XTabView, Me.XTabProcess, Me.XTabViewVod, Me.XTabFtp, Me.XtabAutomateTranscode, Me.xTabVODOnlyMovie, Me.xTabTrailers, Me.XtraTabTrailerSearch, Me.XtraTabTrailerResult, Me.XtraTabTrailerView})
        Me.XTabVODAndTrailers.Text = "VOD"
        '
        'xTabTrailers
        '
        Me.xTabTrailers.Controls.Add(Me.btnSaveTrailers)
        Me.xTabTrailers.Controls.Add(Me.grdTrailers)
        Me.xTabTrailers.Controls.Add(Me.webTrailers)
        Me.xTabTrailers.Name = "xTabTrailers"
        Me.xTabTrailers.Size = New System.Drawing.Size(1000, 694)
        Me.xTabTrailers.Text = "Trailers"
        '
        'btnSaveTrailers
        '
        Me.btnSaveTrailers.Location = New System.Drawing.Point(3, 3)
        Me.btnSaveTrailers.Name = "btnSaveTrailers"
        Me.btnSaveTrailers.Size = New System.Drawing.Size(97, 23)
        Me.btnSaveTrailers.TabIndex = 20
        Me.btnSaveTrailers.Text = "Save All Changes"
        '
        'grdTrailers
        '
        Me.grdTrailers.Dock = System.Windows.Forms.DockStyle.Left
        Me.grdTrailers.EmbeddedNavigator.Name = ""
        Me.grdTrailers.FormsUseDefaultLookAndFeel = False
        Me.grdTrailers.Location = New System.Drawing.Point(0, 0)
        Me.grdTrailers.MainView = Me.GridViewTrailers
        Me.grdTrailers.Name = "grdTrailers"
        Me.grdTrailers.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbgridStatusTrailer, Me.cmbLanguagesTrailers, Me.cmbSubtitleTrailers, Me.repLanguageTrailers, Me.repSubtitleTrailers, Me.RepositoryBtnWatchTrailer})
        Me.grdTrailers.Size = New System.Drawing.Size(438, 694)
        Me.grdTrailers.TabIndex = 8
        Me.grdTrailers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewTrailers})
        '
        'GridViewTrailers
        '
        Me.GridViewTrailers.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand5})
        Me.GridViewTrailers.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.col_imdb_id, Me.col_trailer_filename, Me.col_audio, Me.col_sub, Me.col_available, Me.col_status, Me.col_watch_trailer})
        Me.GridViewTrailers.CustomizationFormBounds = New System.Drawing.Rectangle(799, 449, 225, 209)
        Me.GridViewTrailers.GridControl = Me.grdTrailers
        Me.GridViewTrailers.Name = "GridViewTrailers"
        Me.GridViewTrailers.OptionsView.ColumnAutoWidth = True
        Me.GridViewTrailers.OptionsView.ShowAutoFilterRow = True
        Me.GridViewTrailers.OptionsView.ShowBands = False
        Me.GridViewTrailers.OptionsView.ShowFooter = True
        '
        'GridBand5
        '
        Me.GridBand5.Caption = "GridBand1"
        Me.GridBand5.Columns.Add(Me.col_watch_trailer)
        Me.GridBand5.Columns.Add(Me.col_trailer_filename)
        Me.GridBand5.Columns.Add(Me.col_imdb_id)
        Me.GridBand5.Columns.Add(Me.col_audio)
        Me.GridBand5.Columns.Add(Me.col_sub)
        Me.GridBand5.Columns.Add(Me.col_status)
        Me.GridBand5.Columns.Add(Me.col_available)
        Me.GridBand5.MinWidth = 20
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.Width = 417
        '
        'col_watch_trailer
        '
        Me.col_watch_trailer.Caption = "watch trailer"
        Me.col_watch_trailer.ColumnEdit = Me.RepositoryBtnWatchTrailer
        Me.col_watch_trailer.FieldName = "colBtnWatchFilm"
        Me.col_watch_trailer.Name = "col_watch_trailer"
        Me.col_watch_trailer.Visible = True
        Me.col_watch_trailer.Width = 77
        '
        'RepositoryBtnWatchTrailer
        '
        Me.RepositoryBtnWatchTrailer.AutoHeight = False
        Me.RepositoryBtnWatchTrailer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryBtnWatchTrailer.Name = "RepositoryBtnWatchTrailer"
        Me.RepositoryBtnWatchTrailer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_trailer_filename
        '
        Me.col_trailer_filename.Caption = "filename"
        Me.col_trailer_filename.FieldName = "filename"
        Me.col_trailer_filename.Name = "col_trailer_filename"
        Me.col_trailer_filename.OptionsColumn.AllowEdit = False
        Me.col_trailer_filename.Visible = True
        Me.col_trailer_filename.Width = 137
        '
        'col_imdb_id
        '
        Me.col_imdb_id.Caption = "imdb id"
        Me.col_imdb_id.FieldName = "imdb_id"
        Me.col_imdb_id.Name = "col_imdb_id"
        Me.col_imdb_id.OptionsColumn.AllowEdit = False
        Me.col_imdb_id.Visible = True
        Me.col_imdb_id.Width = 46
        '
        'col_audio
        '
        Me.col_audio.Caption = "Audio"
        Me.col_audio.ColumnEdit = Me.repLanguageTrailers
        Me.col_audio.FieldName = "language_id"
        Me.col_audio.Name = "col_audio"
        Me.col_audio.OptionsColumn.AllowEdit = False
        Me.col_audio.Visible = True
        Me.col_audio.Width = 41
        '
        'repLanguageTrailers
        '
        Me.repLanguageTrailers.AutoHeight = False
        Me.repLanguageTrailers.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repLanguageTrailers.Name = "repLanguageTrailers"
        Me.repLanguageTrailers.NullText = ""
        Me.repLanguageTrailers.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'col_sub
        '
        Me.col_sub.Caption = "Subtitle"
        Me.col_sub.ColumnEdit = Me.repSubtitleTrailers
        Me.col_sub.FieldName = "subtitle_id"
        Me.col_sub.Name = "col_sub"
        Me.col_sub.OptionsColumn.AllowEdit = False
        Me.col_sub.Visible = True
        Me.col_sub.Width = 46
        '
        'repSubtitleTrailers
        '
        Me.repSubtitleTrailers.AutoHeight = False
        Me.repSubtitleTrailers.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repSubtitleTrailers.Name = "repSubtitleTrailers"
        Me.repSubtitleTrailers.NullText = ""
        Me.repSubtitleTrailers.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'col_status
        '
        Me.col_status.Caption = "status"
        Me.col_status.ColumnEdit = Me.cmbgridStatusTrailer
        Me.col_status.FieldName = "status"
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.Width = 70
        '
        'cmbgridStatusTrailer
        '
        Me.cmbgridStatusTrailer.AutoHeight = False
        Me.cmbgridStatusTrailer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbgridStatusTrailer.Name = "cmbgridStatusTrailer"
        '
        'col_available
        '
        Me.col_available.Caption = "available"
        Me.col_available.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.col_available.FieldName = "available"
        Me.col_available.Name = "col_available"
        Me.col_available.OptionsColumn.AllowEdit = False
        Me.col_available.OptionsColumn.ReadOnly = True
        Me.col_available.Width = 301
        '
        'cmbLanguagesTrailers
        '
        Me.cmbLanguagesTrailers.AutoHeight = False
        Me.cmbLanguagesTrailers.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguagesTrailers.Name = "cmbLanguagesTrailers"
        '
        'cmbSubtitleTrailers
        '
        Me.cmbSubtitleTrailers.AutoHeight = False
        Me.cmbSubtitleTrailers.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSubtitleTrailers.Name = "cmbSubtitleTrailers"
        '
        'webTrailers
        '
        Me.webTrailers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webTrailers.Location = New System.Drawing.Point(445, 0)
        Me.webTrailers.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webTrailers.Name = "webTrailers"
        Me.webTrailers.Size = New System.Drawing.Size(818, 630)
        Me.webTrailers.TabIndex = 9
        '
        'XTabSearch
        '
        Me.XTabSearch.Controls.Add(Me.btnRipped)
        Me.XTabSearch.Controls.Add(Me.BtnViewAll)
        Me.XTabSearch.Controls.Add(Me.BtnNewVodProduct)
        Me.XTabSearch.Controls.Add(Me.btnSearch)
        Me.XTabSearch.Controls.Add(Me.txtImdb)
        Me.XTabSearch.Controls.Add(Me.LblImdb)
        Me.XTabSearch.Controls.Add(Me.TxtProducts_id)
        Me.XTabSearch.Controls.Add(Me.lblProduct_id)
        Me.XTabSearch.Controls.Add(Me.txtTitleSearch)
        Me.XTabSearch.Controls.Add(Me.lblPartTitle)
        Me.XTabSearch.Name = "XTabSearch"
        Me.XTabSearch.Size = New System.Drawing.Size(1000, 694)
        Me.XTabSearch.Text = "Search"
        '
        'btnRipped
        '
        Me.btnRipped.Location = New System.Drawing.Point(444, 211)
        Me.btnRipped.Name = "btnRipped"
        Me.btnRipped.Size = New System.Drawing.Size(75, 23)
        Me.btnRipped.TabIndex = 18
        Me.btnRipped.Text = "ripped"
        '
        'BtnViewAll
        '
        Me.BtnViewAll.Location = New System.Drawing.Point(335, 211)
        Me.BtnViewAll.Name = "BtnViewAll"
        Me.BtnViewAll.Size = New System.Drawing.Size(75, 23)
        Me.BtnViewAll.TabIndex = 17
        Me.BtnViewAll.Text = "View all"
        '
        'BtnNewVodProduct
        '
        Me.BtnNewVodProduct.Location = New System.Drawing.Point(194, 211)
        Me.BtnNewVodProduct.Name = "BtnNewVodProduct"
        Me.BtnNewVodProduct.Size = New System.Drawing.Size(75, 23)
        Me.BtnNewVodProduct.TabIndex = 16
        Me.BtnNewVodProduct.Text = "New"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(56, 211)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "Search"
        '
        'txtImdb
        '
        Me.txtImdb.Location = New System.Drawing.Point(157, 113)
        Me.txtImdb.Name = "txtImdb"
        Me.txtImdb.Size = New System.Drawing.Size(112, 20)
        Me.txtImdb.TabIndex = 14
        '
        'LblImdb
        '
        Me.LblImdb.Location = New System.Drawing.Point(26, 116)
        Me.LblImdb.Name = "LblImdb"
        Me.LblImdb.Size = New System.Drawing.Size(38, 13)
        Me.LblImdb.TabIndex = 13
        Me.LblImdb.Text = "Imdb ID"
        '
        'TxtProducts_id
        '
        Me.TxtProducts_id.Location = New System.Drawing.Point(157, 68)
        Me.TxtProducts_id.Name = "TxtProducts_id"
        Me.TxtProducts_id.Size = New System.Drawing.Size(112, 20)
        Me.TxtProducts_id.TabIndex = 12
        '
        'lblProduct_id
        '
        Me.lblProduct_id.Location = New System.Drawing.Point(26, 71)
        Me.lblProduct_id.Name = "lblProduct_id"
        Me.lblProduct_id.Size = New System.Drawing.Size(51, 13)
        Me.lblProduct_id.TabIndex = 11
        Me.lblProduct_id.Text = "Product ID"
        '
        'txtTitleSearch
        '
        Me.txtTitleSearch.Location = New System.Drawing.Point(157, 28)
        Me.txtTitleSearch.Name = "txtTitleSearch"
        Me.txtTitleSearch.Size = New System.Drawing.Size(472, 20)
        Me.txtTitleSearch.TabIndex = 10
        '
        'lblPartTitle
        '
        Me.lblPartTitle.Location = New System.Drawing.Point(26, 35)
        Me.lblPartTitle.Name = "lblPartTitle"
        Me.lblPartTitle.Size = New System.Drawing.Size(56, 13)
        Me.lblPartTitle.TabIndex = 9
        Me.lblPartTitle.Text = "Part of Title"
        '
        'XTabResult
        '
        Me.XTabResult.Controls.Add(Me.btnSaveAllChanges)
        Me.XTabResult.Controls.Add(Me.GridVod)
        Me.XTabResult.Name = "XTabResult"
        Me.XTabResult.Size = New System.Drawing.Size(1000, 694)
        Me.XTabResult.Text = "Result"
        '
        'btnSaveAllChanges
        '
        Me.btnSaveAllChanges.Location = New System.Drawing.Point(9, 3)
        Me.btnSaveAllChanges.Name = "btnSaveAllChanges"
        Me.btnSaveAllChanges.Size = New System.Drawing.Size(97, 23)
        Me.btnSaveAllChanges.TabIndex = 19
        Me.btnSaveAllChanges.Text = "Save All Changes"
        '
        'GridVod
        '
        Me.GridVod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVod.EmbeddedNavigator.Name = ""
        Me.GridVod.FormsUseDefaultLookAndFeel = False
        Me.GridVod.Location = New System.Drawing.Point(0, 0)
        Me.GridVod.MainView = Me.GridViewSearch
        Me.GridVod.Name = "GridVod"
        Me.GridVod.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbLanguages, Me.chkcolAvailable, Me.cmbStudio, Me.RepositorycmbSupportVod, Me.cmbgridStatus, Me.dpDateStart, Me.dtpDateExpired, Me.cmbLanguagesSubtitleEdit, Me.RepositoryItemLookUpEdit2, Me.spnedtCredit, Me.dpBackcatalogueStart, Me.dpBackcataloguExpired})
        Me.GridVod.Size = New System.Drawing.Size(1000, 694)
        Me.GridVod.TabIndex = 4
        Me.GridVod.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSearch})
        '
        'GridViewSearch
        '
        Me.GridViewSearch.Appearance.FocusedRow.BackColor = System.Drawing.Color.Silver
        Me.GridViewSearch.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridViewSearch.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand3, Me.GridBand4})
        Me.GridViewSearch.ColumnPanelRowHeight = 45
        Me.GridViewSearch.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colImdb_id, Me.collanguage_id, Me.colproducts_name, Me.ColAvailable_from, Me.colExpireAt, Me.colAvailableBackCatalogueFrom, Me.colBackcatalogueExpireAt, Me.colLanguage_subtitle, Me.colAvailable, Me.colStudio, Me.colStatus, Me.colQuality, Me.colcountry, Me.colSvodA, Me.colSvodB, Me.colDRM})
        Me.GridViewSearch.CustomizationFormBounds = New System.Drawing.Rectangle(1375, 482, 225, 209)
        Me.GridViewSearch.DetailHeight = 50
        Me.GridViewSearch.GridControl = Me.GridVod
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
        Me.GridBand1.Columns.Add(Me.colImdb_id)
        Me.GridBand1.Columns.Add(Me.colproducts_name)
        Me.GridBand1.Columns.Add(Me.colQuality)
        Me.GridBand1.Columns.Add(Me.colStudio)
        Me.GridBand1.Columns.Add(Me.colStatus)
        Me.GridBand1.Columns.Add(Me.collanguage_id)
        Me.GridBand1.Columns.Add(Me.colLanguage_subtitle)
        Me.GridBand1.Columns.Add(Me.ColAvailable_from)
        Me.GridBand1.Columns.Add(Me.colExpireAt)
        Me.GridBand1.Columns.Add(Me.colAvailableBackCatalogueFrom)
        Me.GridBand1.Columns.Add(Me.colBackcatalogueExpireAt)
        Me.GridBand1.Columns.Add(Me.colSvodA)
        Me.GridBand1.Columns.Add(Me.colSvodB)
        Me.GridBand1.Columns.Add(Me.colAvailable)
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 959
        '
        'colImdb_id
        '
        Me.colImdb_id.Caption = "imdb id"
        Me.colImdb_id.ColumnEdit = Me.spnedtCredit
        Me.colImdb_id.FieldName = "imdb_id"
        Me.colImdb_id.Name = "colImdb_id"
        Me.colImdb_id.OptionsColumn.AllowEdit = False
        Me.colImdb_id.Visible = True
        Me.colImdb_id.Width = 41
        '
        'spnedtCredit
        '
        Me.spnedtCredit.AutoHeight = False
        Me.spnedtCredit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.spnedtCredit.MaxValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.spnedtCredit.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spnedtCredit.Name = "spnedtCredit"
        '
        'colproducts_name
        '
        Me.colproducts_name.Caption = "products name"
        Me.colproducts_name.FieldName = "products_name"
        Me.colproducts_name.Name = "colproducts_name"
        Me.colproducts_name.OptionsColumn.AllowEdit = False
        Me.colproducts_name.Visible = True
        Me.colproducts_name.Width = 115
        '
        'colQuality
        '
        Me.colQuality.Caption = "quality"
        Me.colQuality.FieldName = "quality"
        Me.colQuality.Name = "colQuality"
        Me.colQuality.OptionsColumn.AllowEdit = False
        Me.colQuality.Visible = True
        Me.colQuality.Width = 38
        '
        'colStudio
        '
        Me.colStudio.Caption = "studio"
        Me.colStudio.ColumnEdit = Me.cmbStudio
        Me.colStudio.FieldName = "studio_id"
        Me.colStudio.Name = "colStudio"
        Me.colStudio.Visible = True
        Me.colStudio.Width = 59
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
        'colStatus
        '
        Me.colStatus.Caption = "status"
        Me.colStatus.ColumnEdit = Me.cmbgridStatus
        Me.colStatus.FieldName = "status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.Width = 61
        '
        'cmbgridStatus
        '
        Me.cmbgridStatus.AutoHeight = False
        Me.cmbgridStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbgridStatus.Name = "cmbgridStatus"
        '
        'collanguage_id
        '
        Me.collanguage_id.Caption = "language sound"
        Me.collanguage_id.ColumnEdit = Me.cmbLanguages
        Me.collanguage_id.FieldName = "language_id"
        Me.collanguage_id.Name = "collanguage_id"
        Me.collanguage_id.OptionsColumn.AllowEdit = False
        Me.collanguage_id.Visible = True
        Me.collanguage_id.Width = 78
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
        'colLanguage_subtitle
        '
        Me.colLanguage_subtitle.Caption = "language subtitle"
        Me.colLanguage_subtitle.ColumnEdit = Me.cmbLanguagesSubtitleEdit
        Me.colLanguage_subtitle.FieldName = "subtitle_id"
        Me.colLanguage_subtitle.Name = "colLanguage_subtitle"
        Me.colLanguage_subtitle.OptionsColumn.AllowEdit = False
        Me.colLanguage_subtitle.Visible = True
        Me.colLanguage_subtitle.Width = 84
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
        'ColAvailable_from
        '
        Me.ColAvailable_from.Caption = "A"
        Me.ColAvailable_from.ColumnEdit = Me.dpDateStart
        Me.ColAvailable_from.FieldName = "available_from"
        Me.ColAvailable_from.Name = "ColAvailable_from"
        Me.ColAvailable_from.Visible = True
        Me.ColAvailable_from.Width = 59
        '
        'dpDateStart
        '
        Me.dpDateStart.AutoHeight = False
        Me.dpDateStart.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpDateStart.Name = "dpDateStart"
        Me.dpDateStart.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'colExpireAt
        '
        Me.colExpireAt.Caption = "B"
        Me.colExpireAt.ColumnEdit = Me.dtpDateExpired
        Me.colExpireAt.FieldName = "expire_at"
        Me.colExpireAt.Name = "colExpireAt"
        Me.colExpireAt.Visible = True
        Me.colExpireAt.Width = 72
        '
        'dtpDateExpired
        '
        Me.dtpDateExpired.AutoHeight = False
        Me.dtpDateExpired.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateExpired.Name = "dtpDateExpired"
        Me.dtpDateExpired.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'colAvailableBackCatalogueFrom
        '
        Me.colAvailableBackCatalogueFrom.Caption = "C"
        Me.colAvailableBackCatalogueFrom.ColumnEdit = Me.dpBackcatalogueStart
        Me.colAvailableBackCatalogueFrom.FieldName = "available_backcatalogue_from"
        Me.colAvailableBackCatalogueFrom.Name = "colAvailableBackCatalogueFrom"
        Me.colAvailableBackCatalogueFrom.Visible = True
        Me.colAvailableBackCatalogueFrom.Width = 77
        '
        'dpBackcatalogueStart
        '
        Me.dpBackcatalogueStart.AutoHeight = False
        Me.dpBackcatalogueStart.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpBackcatalogueStart.Name = "dpBackcatalogueStart"
        Me.dpBackcatalogueStart.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'colBackcatalogueExpireAt
        '
        Me.colBackcatalogueExpireAt.Caption = "D"
        Me.colBackcatalogueExpireAt.ColumnEdit = Me.dpBackcataloguExpired
        Me.colBackcatalogueExpireAt.FieldName = "expire_backcatalogue_at"
        Me.colBackcatalogueExpireAt.Name = "colBackcatalogueExpireAt"
        Me.colBackcatalogueExpireAt.Visible = True
        Me.colBackcatalogueExpireAt.Width = 70
        '
        'dpBackcataloguExpired
        '
        Me.dpBackcataloguExpired.AutoHeight = False
        Me.dpBackcataloguExpired.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpBackcataloguExpired.Name = "dpBackcataloguExpired"
        Me.dpBackcataloguExpired.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'colSvodA
        '
        Me.colSvodA.Caption = "svod A"
        Me.colSvodA.FieldName = "svod_A"
        Me.colSvodA.Name = "colSvodA"
        Me.colSvodA.OptionsColumn.AllowEdit = False
        Me.colSvodA.Visible = True
        '
        'colSvodB
        '
        Me.colSvodB.Caption = "svod B"
        Me.colSvodB.FieldName = "svod_B"
        Me.colSvodB.Name = "colSvodB"
        Me.colSvodB.OptionsColumn.AllowEdit = False
        Me.colSvodB.Visible = True
        '
        'colAvailable
        '
        Me.colAvailable.Caption = "available"
        Me.colAvailable.ColumnEdit = Me.chkcolAvailable
        Me.colAvailable.FieldName = "available"
        Me.colAvailable.Name = "colAvailable"
        Me.colAvailable.Visible = True
        Me.colAvailable.Width = 55
        '
        'chkcolAvailable
        '
        Me.chkcolAvailable.AutoHeight = False
        Me.chkcolAvailable.Name = "chkcolAvailable"
        Me.chkcolAvailable.ValueChecked = CType(1, Byte)
        Me.chkcolAvailable.ValueUnchecked = CType(0, Byte)
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "gridBand1"
        Me.GridBand3.Columns.Add(Me.colDRM)
        Me.GridBand3.MinWidth = 20
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 75
        '
        'colDRM
        '
        Me.colDRM.Caption = "DRM"
        Me.colDRM.FieldName = "drm"
        Me.colDRM.Name = "colDRM"
        Me.colDRM.Visible = True
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "gridBand2"
        Me.GridBand4.MinWidth = 20
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 50
        '
        'colcountry
        '
        Me.colcountry.Caption = "country"
        Me.colcountry.FieldName = "country"
        Me.colcountry.Name = "colcountry"
        '
        'RepositorycmbSupportVod
        '
        Me.RepositorycmbSupportVod.AutoHeight = False
        Me.RepositorycmbSupportVod.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositorycmbSupportVod.Name = "RepositorycmbSupportVod"
        Me.RepositorycmbSupportVod.NullText = ""
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'XTabView
        '
        Me.XTabView.Controls.Add(Me.chkVideoland)
        Me.XTabView.Controls.Add(Me.txtEpisodeID)
        Me.XTabView.Controls.Add(Me.LabelControl45)
        Me.XTabView.Controls.Add(Me.txtSeasonID)
        Me.XTabView.Controls.Add(Me.LabelControl44)
        Me.XTabView.Controls.Add(Me.LabelControl12)
        Me.XTabView.Controls.Add(Me.chkDRM)
        Me.XTabView.Controls.Add(Me.GridSVODDates)
        Me.XTabView.Controls.Add(Me.GroupBox1)
        Me.XTabView.Controls.Add(Me.GroupBox2)
        Me.XTabView.Controls.Add(Me.LabelControl15)
        Me.XTabView.Controls.Add(Me.LabelControl10)
        Me.XTabView.Controls.Add(Me.LabelControl9)
        Me.XTabView.Controls.Add(Me.LabelControl8)
        Me.XTabView.Controls.Add(Me.LabelControl7)
        Me.XTabView.Controls.Add(Me.LabelControl6)
        Me.XTabView.Controls.Add(Me.gpbLuxemburg)
        Me.XTabView.Controls.Add(Me.btnDeleteVOD)
        Me.XTabView.Controls.Add(Me.cmbSupportVod)
        Me.XTabView.Controls.Add(Me.lblSupport)
        Me.XTabView.Controls.Add(Me.cmbSource)
        Me.XTabView.Controls.Add(Me.lblSource)
        Me.XTabView.Controls.Add(Me.cmbQuality)
        Me.XTabView.Controls.Add(Me.lblHigh)
        Me.XTabView.Controls.Add(Me.cmbStatus)
        Me.XTabView.Controls.Add(Me.lblStatus)
        Me.XTabView.Controls.Add(Me.cmbStudioEdit)
        Me.XTabView.Controls.Add(Me.lblStudio)
        Me.XTabView.Controls.Add(Me.btnCancelVod)
        Me.XTabView.Controls.Add(Me.cmbLanguageSubtitle)
        Me.XTabView.Controls.Add(Me.cmbLanguageSound)
        Me.XTabView.Controls.Add(Me.TxtFilename)
        Me.XTabView.Controls.Add(Me.lblNameFile)
        Me.XTabView.Controls.Add(Me.lblLanguage_subtitle)
        Me.XTabView.Controls.Add(Me.lblLanguageSound)
        Me.XTabView.Controls.Add(Me.txtImdbView)
        Me.XTabView.Controls.Add(Me.lblImdbView)
        Me.XTabView.Controls.Add(Me.btnSaveVod)
        Me.XTabView.Controls.Add(Me.btnEditVod)
        Me.XTabView.Name = "XTabView"
        Me.XTabView.Size = New System.Drawing.Size(1000, 694)
        Me.XTabView.Text = "View"
        '
        'txtEpisodeID
        '
        Me.txtEpisodeID.Enabled = False
        Me.txtEpisodeID.Location = New System.Drawing.Point(106, 121)
        Me.txtEpisodeID.Name = "txtEpisodeID"
        Me.txtEpisodeID.Size = New System.Drawing.Size(112, 20)
        Me.txtEpisodeID.TabIndex = 144
        '
        'LabelControl45
        '
        Me.LabelControl45.Location = New System.Drawing.Point(18, 121)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl45.TabIndex = 143
        Me.LabelControl45.Text = "Episode"
        '
        'txtSeasonID
        '
        Me.txtSeasonID.Enabled = False
        Me.txtSeasonID.Location = New System.Drawing.Point(106, 94)
        Me.txtSeasonID.Name = "txtSeasonID"
        Me.txtSeasonID.Size = New System.Drawing.Size(112, 20)
        Me.txtSeasonID.TabIndex = 142
        '
        'LabelControl44
        '
        Me.LabelControl44.Location = New System.Drawing.Point(18, 94)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl44.TabIndex = 141
        Me.LabelControl44.Text = "Season"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(330, 70)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl12.TabIndex = 140
        Me.LabelControl12.Text = "SVOD Dates And Kind"
        '
        'chkDRM
        '
        Me.chkDRM.Location = New System.Drawing.Point(104, 368)
        Me.chkDRM.Name = "chkDRM"
        Me.chkDRM.Properties.Caption = "DRM"
        Me.chkDRM.Size = New System.Drawing.Size(69, 19)
        Me.chkDRM.TabIndex = 139
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.cmbDateStart)
        Me.GroupBox1.Controls.Add(Me.cmbDateExpired)
        Me.GroupBox1.Controls.Add(Me.chkIsPPV)
        Me.GroupBox1.Controls.Add(Me.cmbDateLaterStart)
        Me.GroupBox1.Controls.Add(Me.txtPPVPrice)
        Me.GroupBox1.Controls.Add(Me.cmbDateLaterExpired)
        Me.GroupBox1.Controls.Add(Me.chkAvailable)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 432)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(967, 82)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Belgium"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(76, 18)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(73, 20)
        Me.txtId.TabIndex = 73
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(770, 58)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 67
        Me.LabelControl1.Text = "PPV price"
        '
        'cmbDateStart
        '
        Me.cmbDateStart.EditValue = Nothing
        Me.cmbDateStart.Enabled = False
        Me.cmbDateStart.Location = New System.Drawing.Point(194, 18)
        Me.cmbDateStart.Name = "cmbDateStart"
        Me.cmbDateStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateStart.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateStart.Size = New System.Drawing.Size(112, 20)
        Me.cmbDateStart.TabIndex = 67
        '
        'cmbDateExpired
        '
        Me.cmbDateExpired.EditValue = Nothing
        Me.cmbDateExpired.Enabled = False
        Me.cmbDateExpired.Location = New System.Drawing.Point(312, 18)
        Me.cmbDateExpired.Name = "cmbDateExpired"
        Me.cmbDateExpired.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateExpired.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateExpired.Size = New System.Drawing.Size(112, 20)
        Me.cmbDateExpired.TabIndex = 68
        '
        'chkIsPPV
        '
        Me.chkIsPPV.Location = New System.Drawing.Point(728, 18)
        Me.chkIsPPV.Name = "chkIsPPV"
        Me.chkIsPPV.Properties.Caption = "Is PPV"
        Me.chkIsPPV.Size = New System.Drawing.Size(69, 19)
        Me.chkIsPPV.TabIndex = 103
        '
        'cmbDateLaterStart
        '
        Me.cmbDateLaterStart.EditValue = Nothing
        Me.cmbDateLaterStart.Enabled = False
        Me.cmbDateLaterStart.Location = New System.Drawing.Point(430, 18)
        Me.cmbDateLaterStart.Name = "cmbDateLaterStart"
        Me.cmbDateLaterStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateLaterStart.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateLaterStart.Size = New System.Drawing.Size(112, 20)
        Me.cmbDateLaterStart.TabIndex = 89
        '
        'txtPPVPrice
        '
        Me.txtPPVPrice.Enabled = False
        Me.txtPPVPrice.Location = New System.Drawing.Point(820, 52)
        Me.txtPPVPrice.Name = "txtPPVPrice"
        Me.txtPPVPrice.Size = New System.Drawing.Size(97, 20)
        Me.txtPPVPrice.TabIndex = 102
        '
        'cmbDateLaterExpired
        '
        Me.cmbDateLaterExpired.EditValue = Nothing
        Me.cmbDateLaterExpired.Enabled = False
        Me.cmbDateLaterExpired.Location = New System.Drawing.Point(548, 18)
        Me.cmbDateLaterExpired.Name = "cmbDateLaterExpired"
        Me.cmbDateLaterExpired.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateLaterExpired.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateLaterExpired.Size = New System.Drawing.Size(112, 20)
        Me.cmbDateLaterExpired.TabIndex = 90
        '
        'chkAvailable
        '
        Me.chkAvailable.Location = New System.Drawing.Point(674, 19)
        Me.chkAvailable.Name = "chkAvailable"
        Me.chkAvailable.Properties.Caption = ""
        Me.chkAvailable.Size = New System.Drawing.Size(44, 19)
        Me.chkAvailable.TabIndex = 65
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtIdNL)
        Me.GroupBox2.Controls.Add(Me.txtPPVPriceNL)
        Me.GroupBox2.Controls.Add(Me.LabelControl14)
        Me.GroupBox2.Controls.Add(Me.chkIsPPVNL)
        Me.GroupBox2.Controls.Add(Me.chkNL)
        Me.GroupBox2.Controls.Add(Me.chkAvailableNL)
        Me.GroupBox2.Controls.Add(Me.cmbDateLaterExpiredNL)
        Me.GroupBox2.Controls.Add(Me.cmbDateLaterStartNL)
        Me.GroupBox2.Controls.Add(Me.cmbDateExpiredNL)
        Me.GroupBox2.Controls.Add(Me.cmbDateStartNL)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 602)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(967, 82)
        Me.GroupBox2.TabIndex = 101
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nederland"
        '
        'txtIdNL
        '
        Me.txtIdNL.Enabled = False
        Me.txtIdNL.Location = New System.Drawing.Point(76, 19)
        Me.txtIdNL.Name = "txtIdNL"
        Me.txtIdNL.Size = New System.Drawing.Size(73, 20)
        Me.txtIdNL.TabIndex = 102
        '
        'txtPPVPriceNL
        '
        Me.txtPPVPriceNL.Enabled = False
        Me.txtPPVPriceNL.Location = New System.Drawing.Point(820, 52)
        Me.txtPPVPriceNL.Name = "txtPPVPriceNL"
        Me.txtPPVPriceNL.Size = New System.Drawing.Size(98, 20)
        Me.txtPPVPriceNL.TabIndex = 98
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(756, 55)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl14.TabIndex = 97
        Me.LabelControl14.Text = "PPV price"
        '
        'chkIsPPVNL
        '
        Me.chkIsPPVNL.Location = New System.Drawing.Point(728, 20)
        Me.chkIsPPVNL.Name = "chkIsPPVNL"
        Me.chkIsPPVNL.Properties.Caption = "Is PPV"
        Me.chkIsPPVNL.Size = New System.Drawing.Size(59, 19)
        Me.chkIsPPVNL.TabIndex = 96
        '
        'chkNL
        '
        Me.chkNL.Location = New System.Drawing.Point(6, 20)
        Me.chkNL.Name = "chkNL"
        Me.chkNL.Properties.Caption = ""
        Me.chkNL.Size = New System.Drawing.Size(56, 19)
        Me.chkNL.TabIndex = 95
        '
        'chkAvailableNL
        '
        Me.chkAvailableNL.Location = New System.Drawing.Point(674, 20)
        Me.chkAvailableNL.Name = "chkAvailableNL"
        Me.chkAvailableNL.Properties.Caption = ""
        Me.chkAvailableNL.Size = New System.Drawing.Size(47, 19)
        Me.chkAvailableNL.TabIndex = 92
        '
        'cmbDateLaterExpiredNL
        '
        Me.cmbDateLaterExpiredNL.EditValue = Nothing
        Me.cmbDateLaterExpiredNL.Enabled = False
        Me.cmbDateLaterExpiredNL.Location = New System.Drawing.Point(547, 19)
        Me.cmbDateLaterExpiredNL.Name = "cmbDateLaterExpiredNL"
        Me.cmbDateLaterExpiredNL.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateLaterExpiredNL.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateLaterExpiredNL.Size = New System.Drawing.Size(112, 20)
        Me.cmbDateLaterExpiredNL.TabIndex = 91
        '
        'cmbDateLaterStartNL
        '
        Me.cmbDateLaterStartNL.EditValue = Nothing
        Me.cmbDateLaterStartNL.Enabled = False
        Me.cmbDateLaterStartNL.Location = New System.Drawing.Point(429, 19)
        Me.cmbDateLaterStartNL.Name = "cmbDateLaterStartNL"
        Me.cmbDateLaterStartNL.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateLaterStartNL.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateLaterStartNL.Size = New System.Drawing.Size(112, 20)
        Me.cmbDateLaterStartNL.TabIndex = 90
        '
        'cmbDateExpiredNL
        '
        Me.cmbDateExpiredNL.EditValue = Nothing
        Me.cmbDateExpiredNL.Enabled = False
        Me.cmbDateExpiredNL.Location = New System.Drawing.Point(312, 19)
        Me.cmbDateExpiredNL.Name = "cmbDateExpiredNL"
        Me.cmbDateExpiredNL.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateExpiredNL.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateExpiredNL.Size = New System.Drawing.Size(112, 20)
        Me.cmbDateExpiredNL.TabIndex = 78
        '
        'cmbDateStartNL
        '
        Me.cmbDateStartNL.EditValue = Nothing
        Me.cmbDateStartNL.Enabled = False
        Me.cmbDateStartNL.Location = New System.Drawing.Point(194, 19)
        Me.cmbDateStartNL.Name = "cmbDateStartNL"
        Me.cmbDateStartNL.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateStartNL.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateStartNL.Size = New System.Drawing.Size(112, 20)
        Me.cmbDateStartNL.TabIndex = 77
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(94, 413)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl15.TabIndex = 99
        Me.LabelControl15.Text = "ID"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(694, 413)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl10.TabIndex = 98
        Me.LabelControl10.Text = "available"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(565, 413)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl9.TabIndex = 97
        Me.LabelControl9.Text = "backatalogue expire"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(447, 413)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl8.TabIndex = 96
        Me.LabelControl8.Text = "backatalogue start"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(330, 413)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl7.TabIndex = 95
        Me.LabelControl7.Text = "date expired"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(212, 413)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl6.TabIndex = 94
        Me.LabelControl6.Text = "date start"
        '
        'gpbLuxemburg
        '
        Me.gpbLuxemburg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpbLuxemburg.Controls.Add(Me.txtIdLU)
        Me.gpbLuxemburg.Controls.Add(Me.txtPPVPriceLU)
        Me.gpbLuxemburg.Controls.Add(Me.LabelControl13)
        Me.gpbLuxemburg.Controls.Add(Me.chkIsPPVLU)
        Me.gpbLuxemburg.Controls.Add(Me.chkLU)
        Me.gpbLuxemburg.Controls.Add(Me.chkAvailableLU)
        Me.gpbLuxemburg.Controls.Add(Me.cmbDateLaterExpiredLU)
        Me.gpbLuxemburg.Controls.Add(Me.cmbDateLaterStartLU)
        Me.gpbLuxemburg.Controls.Add(Me.cmbDateExpiredLU)
        Me.gpbLuxemburg.Controls.Add(Me.cmbDateStartLU)
        Me.gpbLuxemburg.Location = New System.Drawing.Point(12, 517)
        Me.gpbLuxemburg.Name = "gpbLuxemburg"
        Me.gpbLuxemburg.Size = New System.Drawing.Size(967, 82)
        Me.gpbLuxemburg.TabIndex = 92
        Me.gpbLuxemburg.TabStop = False
        Me.gpbLuxemburg.Text = "Luxemburg"
        '
        'txtIdLU
        '
        Me.txtIdLU.Enabled = False
        Me.txtIdLU.Location = New System.Drawing.Point(76, 19)
        Me.txtIdLU.Name = "txtIdLU"
        Me.txtIdLU.Size = New System.Drawing.Size(73, 20)
        Me.txtIdLU.TabIndex = 100
        '
        'txtPPVPriceLU
        '
        Me.txtPPVPriceLU.Enabled = False
        Me.txtPPVPriceLU.Location = New System.Drawing.Point(820, 51)
        Me.txtPPVPriceLU.Name = "txtPPVPriceLU"
        Me.txtPPVPriceLU.Size = New System.Drawing.Size(98, 20)
        Me.txtPPVPriceLU.TabIndex = 98
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(756, 55)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl13.TabIndex = 97
        Me.LabelControl13.Text = "PPV price"
        '
        'chkIsPPVLU
        '
        Me.chkIsPPVLU.Location = New System.Drawing.Point(728, 19)
        Me.chkIsPPVLU.Name = "chkIsPPVLU"
        Me.chkIsPPVLU.Properties.Caption = "Is PPV"
        Me.chkIsPPVLU.Size = New System.Drawing.Size(59, 19)
        Me.chkIsPPVLU.TabIndex = 96
        '
        'chkLU
        '
        Me.chkLU.Location = New System.Drawing.Point(6, 20)
        Me.chkLU.Name = "chkLU"
        Me.chkLU.Properties.Caption = ""
        Me.chkLU.Size = New System.Drawing.Size(56, 19)
        Me.chkLU.TabIndex = 95
        '
        'chkAvailableLU
        '
        Me.chkAvailableLU.Location = New System.Drawing.Point(674, 20)
        Me.chkAvailableLU.Name = "chkAvailableLU"
        Me.chkAvailableLU.Properties.Caption = ""
        Me.chkAvailableLU.Size = New System.Drawing.Size(47, 19)
        Me.chkAvailableLU.TabIndex = 92
        '
        'cmbDateLaterExpiredLU
        '
        Me.cmbDateLaterExpiredLU.EditValue = Nothing
        Me.cmbDateLaterExpiredLU.Enabled = False
        Me.cmbDateLaterExpiredLU.Location = New System.Drawing.Point(547, 19)
        Me.cmbDateLaterExpiredLU.Name = "cmbDateLaterExpiredLU"
        Me.cmbDateLaterExpiredLU.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateLaterExpiredLU.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateLaterExpiredLU.Size = New System.Drawing.Size(112, 20)
        Me.cmbDateLaterExpiredLU.TabIndex = 91
        '
        'cmbDateLaterStartLU
        '
        Me.cmbDateLaterStartLU.EditValue = Nothing
        Me.cmbDateLaterStartLU.Enabled = False
        Me.cmbDateLaterStartLU.Location = New System.Drawing.Point(429, 19)
        Me.cmbDateLaterStartLU.Name = "cmbDateLaterStartLU"
        Me.cmbDateLaterStartLU.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateLaterStartLU.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateLaterStartLU.Size = New System.Drawing.Size(112, 20)
        Me.cmbDateLaterStartLU.TabIndex = 90
        '
        'cmbDateExpiredLU
        '
        Me.cmbDateExpiredLU.EditValue = Nothing
        Me.cmbDateExpiredLU.Enabled = False
        Me.cmbDateExpiredLU.Location = New System.Drawing.Point(312, 19)
        Me.cmbDateExpiredLU.Name = "cmbDateExpiredLU"
        Me.cmbDateExpiredLU.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateExpiredLU.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateExpiredLU.Size = New System.Drawing.Size(112, 20)
        Me.cmbDateExpiredLU.TabIndex = 78
        '
        'cmbDateStartLU
        '
        Me.cmbDateStartLU.EditValue = Nothing
        Me.cmbDateStartLU.Enabled = False
        Me.cmbDateStartLU.Location = New System.Drawing.Point(194, 19)
        Me.cmbDateStartLU.Name = "cmbDateStartLU"
        Me.cmbDateStartLU.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateStartLU.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateStartLU.Size = New System.Drawing.Size(112, 20)
        Me.cmbDateStartLU.TabIndex = 77
        '
        'btnDeleteVOD
        '
        Me.btnDeleteVOD.Enabled = False
        Me.btnDeleteVOD.Location = New System.Drawing.Point(317, 23)
        Me.btnDeleteVOD.Name = "btnDeleteVOD"
        Me.btnDeleteVOD.Size = New System.Drawing.Size(79, 23)
        Me.btnDeleteVOD.TabIndex = 86
        Me.btnDeleteVOD.Text = "Delete"
        '
        'cmbSupportVod
        '
        Me.cmbSupportVod.AllowDrop = True
        Me.cmbSupportVod.Enabled = False
        Me.cmbSupportVod.Location = New System.Drawing.Point(106, 340)
        Me.cmbSupportVod.Name = "cmbSupportVod"
        Me.cmbSupportVod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSupportVod.Properties.DisplayMember = "status_desc"
        Me.cmbSupportVod.Properties.NullText = ""
        Me.cmbSupportVod.Properties.ValueMember = "status_id"
        Me.cmbSupportVod.Size = New System.Drawing.Size(112, 20)
        Me.cmbSupportVod.TabIndex = 83
        '
        'lblSupport
        '
        Me.lblSupport.Location = New System.Drawing.Point(57, 344)
        Me.lblSupport.Name = "lblSupport"
        Me.lblSupport.Size = New System.Drawing.Size(37, 13)
        Me.lblSupport.TabIndex = 82
        Me.lblSupport.Text = "support"
        '
        'cmbSource
        '
        Me.cmbSource.AllowDrop = True
        Me.cmbSource.Enabled = False
        Me.cmbSource.Location = New System.Drawing.Point(106, 312)
        Me.cmbSource.Name = "cmbSource"
        Me.cmbSource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSource.Properties.DisplayMember = "status_desc"
        Me.cmbSource.Properties.NullText = ""
        Me.cmbSource.Properties.ValueMember = "status_id"
        Me.cmbSource.Size = New System.Drawing.Size(112, 20)
        Me.cmbSource.TabIndex = 81
        '
        'lblSource
        '
        Me.lblSource.Location = New System.Drawing.Point(57, 312)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(32, 13)
        Me.lblSource.TabIndex = 80
        Me.lblSource.Text = "source"
        '
        'cmbQuality
        '
        Me.cmbQuality.AllowDrop = True
        Me.cmbQuality.Enabled = False
        Me.cmbQuality.Location = New System.Drawing.Point(106, 285)
        Me.cmbQuality.Name = "cmbQuality"
        Me.cmbQuality.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbQuality.Properties.DisplayMember = "status_desc"
        Me.cmbQuality.Properties.NullText = ""
        Me.cmbQuality.Properties.ValueMember = "status_id"
        Me.cmbQuality.Size = New System.Drawing.Size(112, 20)
        Me.cmbQuality.TabIndex = 79
        '
        'lblHigh
        '
        Me.lblHigh.Location = New System.Drawing.Point(57, 285)
        Me.lblHigh.Name = "lblHigh"
        Me.lblHigh.Size = New System.Drawing.Size(32, 13)
        Me.lblHigh.TabIndex = 78
        Me.lblHigh.Text = "quality"
        '
        'cmbStatus
        '
        Me.cmbStatus.Enabled = False
        Me.cmbStatus.Location = New System.Drawing.Point(106, 257)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStatus.Properties.DisplayMember = "status_desc"
        Me.cmbStatus.Properties.NullText = ""
        Me.cmbStatus.Properties.ValueMember = "status_id"
        Me.cmbStatus.Size = New System.Drawing.Size(112, 20)
        Me.cmbStatus.TabIndex = 77
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(57, 257)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(30, 13)
        Me.lblStatus.TabIndex = 76
        Me.lblStatus.Text = "status"
        '
        'cmbStudioEdit
        '
        Me.cmbStudioEdit.Enabled = False
        Me.cmbStudioEdit.Location = New System.Drawing.Point(106, 230)
        Me.cmbStudioEdit.Name = "cmbStudioEdit"
        Me.cmbStudioEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStudioEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_name", "name", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbStudioEdit.Properties.DisplayMember = "status_desc"
        Me.cmbStudioEdit.Properties.NullText = ""
        Me.cmbStudioEdit.Properties.ValueMember = "status_id"
        Me.cmbStudioEdit.Size = New System.Drawing.Size(112, 20)
        Me.cmbStudioEdit.TabIndex = 75
        '
        'lblStudio
        '
        Me.lblStudio.Location = New System.Drawing.Point(57, 230)
        Me.lblStudio.Name = "lblStudio"
        Me.lblStudio.Size = New System.Drawing.Size(29, 13)
        Me.lblStudio.TabIndex = 74
        Me.lblStudio.Text = "studio"
        '
        'btnCancelVod
        '
        Me.btnCancelVod.Enabled = False
        Me.btnCancelVod.Location = New System.Drawing.Point(215, 23)
        Me.btnCancelVod.Name = "btnCancelVod"
        Me.btnCancelVod.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelVod.TabIndex = 71
        Me.btnCancelVod.Text = "Cancel"
        '
        'cmbLanguageSubtitle
        '
        Me.cmbLanguageSubtitle.Enabled = False
        Me.cmbLanguageSubtitle.Location = New System.Drawing.Point(106, 203)
        Me.cmbLanguageSubtitle.Name = "cmbLanguageSubtitle"
        Me.cmbLanguageSubtitle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguageSubtitle.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("subtitle_id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("lngdsc", "Language", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbLanguageSubtitle.Properties.DisplayMember = "lngdsc"
        Me.cmbLanguageSubtitle.Properties.NullText = ""
        Me.cmbLanguageSubtitle.Properties.ValueMember = "subtitle_id"
        Me.cmbLanguageSubtitle.Size = New System.Drawing.Size(112, 20)
        Me.cmbLanguageSubtitle.TabIndex = 70
        '
        'cmbLanguageSound
        '
        Me.cmbLanguageSound.Enabled = False
        Me.cmbLanguageSound.Location = New System.Drawing.Point(106, 176)
        Me.cmbLanguageSound.Name = "cmbLanguageSound"
        Me.cmbLanguageSound.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguageSound.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("lngdsc", "Language", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbLanguageSound.Properties.DisplayMember = "lngdsc"
        Me.cmbLanguageSound.Properties.NullText = ""
        Me.cmbLanguageSound.Properties.ValueMember = "id"
        Me.cmbLanguageSound.Size = New System.Drawing.Size(112, 20)
        Me.cmbLanguageSound.TabIndex = 69
        '
        'TxtFilename
        '
        Me.TxtFilename.Enabled = False
        Me.TxtFilename.Location = New System.Drawing.Point(106, 147)
        Me.TxtFilename.Name = "TxtFilename"
        Me.TxtFilename.Size = New System.Drawing.Size(179, 20)
        Me.TxtFilename.TabIndex = 66
        '
        'lblNameFile
        '
        Me.lblNameFile.Location = New System.Drawing.Point(18, 147)
        Me.lblNameFile.Name = "lblNameFile"
        Me.lblNameFile.Size = New System.Drawing.Size(43, 13)
        Me.lblNameFile.TabIndex = 63
        Me.lblNameFile.Text = "file name"
        '
        'lblLanguage_subtitle
        '
        Me.lblLanguage_subtitle.Location = New System.Drawing.Point(18, 203)
        Me.lblLanguage_subtitle.Name = "lblLanguage_subtitle"
        Me.lblLanguage_subtitle.Size = New System.Drawing.Size(82, 13)
        Me.lblLanguage_subtitle.TabIndex = 60
        Me.lblLanguage_subtitle.Text = "language subtitle"
        '
        'lblLanguageSound
        '
        Me.lblLanguageSound.Location = New System.Drawing.Point(18, 176)
        Me.lblLanguageSound.Name = "lblLanguageSound"
        Me.lblLanguageSound.Size = New System.Drawing.Size(76, 13)
        Me.lblLanguageSound.TabIndex = 59
        Me.lblLanguageSound.Text = "language sound"
        '
        'txtImdbView
        '
        Me.txtImdbView.Enabled = False
        Me.txtImdbView.Location = New System.Drawing.Point(106, 70)
        Me.txtImdbView.Name = "txtImdbView"
        Me.txtImdbView.Size = New System.Drawing.Size(112, 20)
        Me.txtImdbView.TabIndex = 58
        '
        'lblImdbView
        '
        Me.lblImdbView.Location = New System.Drawing.Point(18, 70)
        Me.lblImdbView.Name = "lblImdbView"
        Me.lblImdbView.Size = New System.Drawing.Size(38, 13)
        Me.lblImdbView.TabIndex = 57
        Me.lblImdbView.Text = "Imdb ID"
        '
        'btnSaveVod
        '
        Me.btnSaveVod.Enabled = False
        Me.btnSaveVod.Location = New System.Drawing.Point(18, 23)
        Me.btnSaveVod.Name = "btnSaveVod"
        Me.btnSaveVod.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveVod.TabIndex = 52
        Me.btnSaveVod.Text = "Save"
        '
        'btnEditVod
        '
        Me.btnEditVod.Enabled = False
        Me.btnEditVod.Location = New System.Drawing.Point(113, 23)
        Me.btnEditVod.Name = "btnEditVod"
        Me.btnEditVod.Size = New System.Drawing.Size(79, 23)
        Me.btnEditVod.TabIndex = 51
        Me.btnEditVod.Text = "Edit"
        '
        'XTabProcess
        '
        Me.XTabProcess.Controls.Add(Me.lblDestinationPathFile)
        Me.XTabProcess.Controls.Add(Me.txtDestinationPath)
        Me.XTabProcess.Controls.Add(Me.btnDestination)
        Me.XTabProcess.Controls.Add(Me.txtSourcePath)
        Me.XTabProcess.Controls.Add(Me.ProgressBarRipping)
        Me.XTabProcess.Controls.Add(Me.btnGenerateRipping)
        Me.XTabProcess.Controls.Add(Me.btnSource)
        Me.XTabProcess.Controls.Add(Me.lblPathSourceTitle)
        Me.XTabProcess.Name = "XTabProcess"
        Me.XTabProcess.Size = New System.Drawing.Size(1000, 694)
        Me.XTabProcess.Text = "Processus vod"
        '
        'lblDestinationPathFile
        '
        Me.lblDestinationPathFile.AutoSize = True
        Me.lblDestinationPathFile.Location = New System.Drawing.Point(76, 64)
        Me.lblDestinationPathFile.Name = "lblDestinationPathFile"
        Me.lblDestinationPathFile.Size = New System.Drawing.Size(126, 13)
        Me.lblDestinationPathFile.TabIndex = 8
        Me.lblDestinationPathFile.Text = "Destination queue filezilla"
        '
        'txtDestinationPath
        '
        Me.txtDestinationPath.EditValue = "z:\vod\tmp\xml"
        Me.txtDestinationPath.Location = New System.Drawing.Point(219, 61)
        Me.txtDestinationPath.Name = "txtDestinationPath"
        Me.txtDestinationPath.Size = New System.Drawing.Size(471, 20)
        Me.txtDestinationPath.TabIndex = 7
        '
        'btnDestination
        '
        Me.btnDestination.Location = New System.Drawing.Point(30, 58)
        Me.btnDestination.Name = "btnDestination"
        Me.btnDestination.Size = New System.Drawing.Size(40, 23)
        Me.btnDestination.TabIndex = 6
        Me.btnDestination.Text = "..."
        '
        'txtSourcePath
        '
        Me.txtSourcePath.Location = New System.Drawing.Point(219, 16)
        Me.txtSourcePath.Name = "txtSourcePath"
        Me.txtSourcePath.Size = New System.Drawing.Size(471, 20)
        Me.txtSourcePath.TabIndex = 5
        '
        'ProgressBarRipping
        '
        Me.ProgressBarRipping.Location = New System.Drawing.Point(219, 136)
        Me.ProgressBarRipping.Name = "ProgressBarRipping"
        Me.ProgressBarRipping.Size = New System.Drawing.Size(350, 23)
        Me.ProgressBarRipping.TabIndex = 4
        '
        'btnGenerateRipping
        '
        Me.btnGenerateRipping.Location = New System.Drawing.Point(9, 136)
        Me.btnGenerateRipping.Name = "btnGenerateRipping"
        Me.btnGenerateRipping.Size = New System.Drawing.Size(116, 23)
        Me.btnGenerateRipping.TabIndex = 3
        Me.btnGenerateRipping.Text = "Generate Ripping"
        '
        'btnSource
        '
        Me.btnSource.Location = New System.Drawing.Point(30, 16)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(40, 23)
        Me.btnSource.TabIndex = 2
        Me.btnSource.Text = "..."
        '
        'lblPathSourceTitle
        '
        Me.lblPathSourceTitle.AutoSize = True
        Me.lblPathSourceTitle.Location = New System.Drawing.Point(76, 23)
        Me.lblPathSourceTitle.Name = "lblPathSourceTitle"
        Me.lblPathSourceTitle.Size = New System.Drawing.Size(85, 13)
        Me.lblPathSourceTitle.TabIndex = 0
        Me.lblPathSourceTitle.Text = "Source files mp4"
        '
        'XTabViewVod
        '
        Me.XTabViewVod.Controls.Add(Me.GridVodWatch)
        Me.XTabViewVod.Controls.Add(Me.WebSiteDvdPost)
        Me.XTabViewVod.Name = "XTabViewVod"
        Me.XTabViewVod.Size = New System.Drawing.Size(1000, 694)
        Me.XTabViewVod.Text = "view vod"
        '
        'GridVodWatch
        '
        Me.GridVodWatch.Dock = System.Windows.Forms.DockStyle.Left
        Me.GridVodWatch.EmbeddedNavigator.Name = ""
        Me.GridVodWatch.FormsUseDefaultLookAndFeel = False
        Me.GridVodWatch.Location = New System.Drawing.Point(0, 0)
        Me.GridVodWatch.MainView = Me.gridViewVodWatch
        Me.GridVodWatch.Name = "GridVodWatch"
        Me.GridVodWatch.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositorycmbLanguage, Me.RepositorychkAvailable, Me.RepositoryCmbStudio, Me.RepositoryBtnWatchMovie, Me.RepositoryLanguageSubtitleGrid})
        Me.GridVodWatch.Size = New System.Drawing.Size(438, 694)
        Me.GridVodWatch.TabIndex = 5
        Me.GridVodWatch.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewVodWatch})
        '
        'gridViewVodWatch
        '
        Me.gridViewVodWatch.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.gridViewVodWatch.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.ColImdbUploaded, Me.colLangAudioUploaded, Me.colProductNameUploaded, colDateStartUploaded, Me.colDateExpiredUploaded, Me.colLangSubtitleUploaded, Me.colAvailableUploaded, Me.colStudioUploaded, Me.colStatusUploaded, Me.colQuality2, Me.colBtnWatchFilm})
        Me.gridViewVodWatch.CustomizationFormBounds = New System.Drawing.Rectangle(799, 449, 225, 209)
        Me.gridViewVodWatch.GridControl = Me.GridVodWatch
        Me.gridViewVodWatch.Name = "gridViewVodWatch"
        Me.gridViewVodWatch.OptionsView.ColumnAutoWidth = True
        Me.gridViewVodWatch.OptionsView.ShowAutoFilterRow = True
        Me.gridViewVodWatch.OptionsView.ShowBands = False
        Me.gridViewVodWatch.OptionsView.ShowFooter = True
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "GridBand1"
        Me.GridBand2.Columns.Add(Me.colBtnWatchFilm)
        Me.GridBand2.Columns.Add(Me.colQuality2)
        Me.GridBand2.Columns.Add(Me.colProductNameUploaded)
        Me.GridBand2.Columns.Add(Me.colStudioUploaded)
        Me.GridBand2.Columns.Add(Me.colStatusUploaded)
        Me.GridBand2.Columns.Add(Me.ColImdbUploaded)
        Me.GridBand2.Columns.Add(Me.colLangAudioUploaded)
        Me.GridBand2.Columns.Add(Me.colLangSubtitleUploaded)
        Me.GridBand2.Columns.Add(colDateStartUploaded)
        Me.GridBand2.Columns.Add(Me.colDateExpiredUploaded)
        Me.GridBand2.Columns.Add(Me.colAvailableUploaded)
        Me.GridBand2.MinWidth = 20
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 448
        '
        'colBtnWatchFilm
        '
        Me.colBtnWatchFilm.Caption = "watch movie"
        Me.colBtnWatchFilm.ColumnEdit = Me.RepositoryBtnWatchMovie
        Me.colBtnWatchFilm.FieldName = "colBtnWatchFilm"
        Me.colBtnWatchFilm.Name = "colBtnWatchFilm"
        Me.colBtnWatchFilm.Visible = True
        Me.colBtnWatchFilm.Width = 78
        '
        'RepositoryBtnWatchMovie
        '
        Me.RepositoryBtnWatchMovie.AutoHeight = False
        Me.RepositoryBtnWatchMovie.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryBtnWatchMovie.Name = "RepositoryBtnWatchMovie"
        Me.RepositoryBtnWatchMovie.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colQuality2
        '
        Me.colQuality2.Caption = "quality"
        Me.colQuality2.FieldName = "quality"
        Me.colQuality2.Name = "colQuality2"
        Me.colQuality2.OptionsColumn.AllowEdit = False
        Me.colQuality2.Visible = True
        Me.colQuality2.Width = 32
        '
        'colProductNameUploaded
        '
        Me.colProductNameUploaded.Caption = "products name"
        Me.colProductNameUploaded.FieldName = "products_name"
        Me.colProductNameUploaded.Name = "colProductNameUploaded"
        Me.colProductNameUploaded.OptionsColumn.AllowEdit = False
        Me.colProductNameUploaded.Visible = True
        Me.colProductNameUploaded.Width = 86
        '
        'colStudioUploaded
        '
        Me.colStudioUploaded.Caption = "studio"
        Me.colStudioUploaded.ColumnEdit = Me.RepositoryCmbStudio
        Me.colStudioUploaded.FieldName = "studio_id"
        Me.colStudioUploaded.Name = "colStudioUploaded"
        Me.colStudioUploaded.OptionsColumn.AllowEdit = False
        Me.colStudioUploaded.OptionsColumn.ReadOnly = True
        '
        'RepositoryCmbStudio
        '
        Me.RepositoryCmbStudio.AutoHeight = False
        Me.RepositoryCmbStudio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryCmbStudio.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_id", "id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_name", "name", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.RepositoryCmbStudio.DisplayMember = "studio_name"
        Me.RepositoryCmbStudio.Name = "RepositoryCmbStudio"
        Me.RepositoryCmbStudio.NullText = ""
        Me.RepositoryCmbStudio.ValueMember = "studio_id"
        '
        'colStatusUploaded
        '
        Me.colStatusUploaded.Caption = "status"
        Me.colStatusUploaded.FieldName = "status"
        Me.colStatusUploaded.Name = "colStatusUploaded"
        '
        'ColImdbUploaded
        '
        Me.ColImdbUploaded.Caption = "imdb id"
        Me.ColImdbUploaded.FieldName = "imdb_id"
        Me.ColImdbUploaded.Name = "ColImdbUploaded"
        Me.ColImdbUploaded.OptionsColumn.AllowEdit = False
        Me.ColImdbUploaded.Visible = True
        Me.ColImdbUploaded.Width = 45
        '
        'colLangAudioUploaded
        '
        Me.colLangAudioUploaded.Caption = "Audio"
        Me.colLangAudioUploaded.ColumnEdit = Me.RepositorycmbLanguage
        Me.colLangAudioUploaded.FieldName = "language_id"
        Me.colLangAudioUploaded.Name = "colLangAudioUploaded"
        Me.colLangAudioUploaded.OptionsColumn.AllowEdit = False
        Me.colLangAudioUploaded.Visible = True
        Me.colLangAudioUploaded.Width = 36
        '
        'RepositorycmbLanguage
        '
        Me.RepositorycmbLanguage.AutoHeight = False
        Me.RepositorycmbLanguage.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositorycmbLanguage.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "languages_id", 82, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 32, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositorycmbLanguage.DisplayMember = "name"
        Me.RepositorycmbLanguage.Name = "RepositorycmbLanguage"
        Me.RepositorycmbLanguage.NullText = ""
        Me.RepositorycmbLanguage.ValueMember = "languages_id"
        '
        'colLangSubtitleUploaded
        '
        Me.colLangSubtitleUploaded.Caption = "Subtitle"
        Me.colLangSubtitleUploaded.ColumnEdit = Me.RepositoryLanguageSubtitleGrid
        Me.colLangSubtitleUploaded.FieldName = "subtitle_id"
        Me.colLangSubtitleUploaded.Name = "colLangSubtitleUploaded"
        Me.colLangSubtitleUploaded.OptionsColumn.AllowEdit = False
        Me.colLangSubtitleUploaded.Visible = True
        Me.colLangSubtitleUploaded.Width = 42
        '
        'RepositoryLanguageSubtitleGrid
        '
        Me.RepositoryLanguageSubtitleGrid.AutoHeight = False
        Me.RepositoryLanguageSubtitleGrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryLanguageSubtitleGrid.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "Name29", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "Name30", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.RepositoryLanguageSubtitleGrid.DisplayMember = "code"
        Me.RepositoryLanguageSubtitleGrid.Name = "RepositoryLanguageSubtitleGrid"
        Me.RepositoryLanguageSubtitleGrid.NullText = ""
        '
        'colDateExpiredUploaded
        '
        Me.colDateExpiredUploaded.Caption = "date expired"
        Me.colDateExpiredUploaded.FieldName = "expire_at"
        Me.colDateExpiredUploaded.Name = "colDateExpiredUploaded"
        Me.colDateExpiredUploaded.OptionsColumn.AllowEdit = False
        Me.colDateExpiredUploaded.Visible = True
        Me.colDateExpiredUploaded.Width = 61
        '
        'colAvailableUploaded
        '
        Me.colAvailableUploaded.Caption = "available"
        Me.colAvailableUploaded.ColumnEdit = Me.RepositorychkAvailable
        Me.colAvailableUploaded.FieldName = "available"
        Me.colAvailableUploaded.Name = "colAvailableUploaded"
        Me.colAvailableUploaded.OptionsColumn.AllowEdit = False
        Me.colAvailableUploaded.OptionsColumn.ReadOnly = True
        Me.colAvailableUploaded.Visible = True
        Me.colAvailableUploaded.Width = 20
        '
        'RepositorychkAvailable
        '
        Me.RepositorychkAvailable.AutoHeight = False
        Me.RepositorychkAvailable.Name = "RepositorychkAvailable"
        Me.RepositorychkAvailable.ValueChecked = CType(1, Byte)
        Me.RepositorychkAvailable.ValueUnchecked = CType(0, Byte)
        '
        'WebSiteDvdPost
        '
        Me.WebSiteDvdPost.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebSiteDvdPost.Location = New System.Drawing.Point(203, 1)
        Me.WebSiteDvdPost.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebSiteDvdPost.Name = "WebSiteDvdPost"
        Me.WebSiteDvdPost.Size = New System.Drawing.Size(1003, 630)
        Me.WebSiteDvdPost.TabIndex = 7
        '
        'XTabFtp
        '
        Me.XTabFtp.Controls.Add(Me.lblDbFtp)
        Me.XTabFtp.Controls.Add(Me.lblFtpLocal)
        Me.XTabFtp.Controls.Add(Me.txtSourceFtp)
        Me.XTabFtp.Controls.Add(Me.TxtSourceLocal)
        Me.XTabFtp.Controls.Add(Me.btnFolderLocal)
        Me.XTabFtp.Controls.Add(Me.lblLocal)
        Me.XTabFtp.Controls.Add(Me.GridDBFtp)
        Me.XTabFtp.Controls.Add(Me.GridFtpLocal)
        Me.XTabFtp.Controls.Add(Me.BtnCompare)
        Me.XTabFtp.Controls.Add(Me.lblFTP)
        Me.XTabFtp.Name = "XTabFtp"
        Me.XTabFtp.Size = New System.Drawing.Size(1000, 694)
        Me.XTabFtp.Text = "Compare Ftp"
        '
        'lblDbFtp
        '
        Me.lblDbFtp.AutoSize = True
        Me.lblDbFtp.Location = New System.Drawing.Point(526, 85)
        Me.lblDbFtp.Name = "lblDbFtp"
        Me.lblDbFtp.Size = New System.Drawing.Size(56, 13)
        Me.lblDbFtp.TabIndex = 14
        Me.lblDbFtp.Text = "DB % FTP"
        '
        'lblFtpLocal
        '
        Me.lblFtpLocal.AutoSize = True
        Me.lblFtpLocal.Location = New System.Drawing.Point(140, 85)
        Me.lblFtpLocal.Name = "lblFtpLocal"
        Me.lblFtpLocal.Size = New System.Drawing.Size(60, 13)
        Me.lblFtpLocal.TabIndex = 13
        Me.lblFtpLocal.Text = "FT % Local"
        '
        'txtSourceFtp
        '
        Me.txtSourceFtp.EditValue = "ftp://upload.cdnlayer.com/media/secureflash/"
        Me.txtSourceFtp.Location = New System.Drawing.Point(42, 31)
        Me.txtSourceFtp.Name = "txtSourceFtp"
        Me.txtSourceFtp.Size = New System.Drawing.Size(263, 20)
        Me.txtSourceFtp.TabIndex = 12
        '
        'TxtSourceLocal
        '
        Me.TxtSourceLocal.EditValue = "z:\vod\tmp"
        Me.TxtSourceLocal.Location = New System.Drawing.Point(46, 60)
        Me.TxtSourceLocal.Name = "TxtSourceLocal"
        Me.TxtSourceLocal.Size = New System.Drawing.Size(182, 20)
        Me.TxtSourceLocal.TabIndex = 11
        '
        'btnFolderLocal
        '
        Me.btnFolderLocal.Location = New System.Drawing.Point(234, 63)
        Me.btnFolderLocal.Name = "btnFolderLocal"
        Me.btnFolderLocal.Size = New System.Drawing.Size(40, 23)
        Me.btnFolderLocal.TabIndex = 10
        Me.btnFolderLocal.Text = "..."
        '
        'lblLocal
        '
        Me.lblLocal.AutoSize = True
        Me.lblLocal.Location = New System.Drawing.Point(11, 67)
        Me.lblLocal.Name = "lblLocal"
        Me.lblLocal.Size = New System.Drawing.Size(29, 13)
        Me.lblLocal.TabIndex = 9
        Me.lblLocal.Text = "local"
        '
        'GridDBFtp
        '
        Me.GridDBFtp.EmbeddedNavigator.Name = ""
        Me.GridDBFtp.FormsUseDefaultLookAndFeel = False
        Me.GridDBFtp.Location = New System.Drawing.Point(357, 101)
        Me.GridDBFtp.MainView = Me.GridViewDBFtp
        Me.GridDBFtp.Name = "GridDBFtp"
        Me.GridDBFtp.Size = New System.Drawing.Size(486, 530)
        Me.GridDBFtp.TabIndex = 7
        Me.GridDBFtp.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDBFtp})
        '
        'GridViewDBFtp
        '
        Me.GridViewDBFtp.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.GridViewDBFtp.GridControl = Me.GridDBFtp
        Me.GridViewDBFtp.Name = "GridViewDBFtp"
        Me.GridViewDBFtp.OptionsBehavior.Editable = False
        Me.GridViewDBFtp.OptionsView.ShowFooter = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Name File"
        Me.GridColumn1.FieldName = "Column"
        Me.GridColumn1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridFtpLocal
        '
        Me.GridFtpLocal.EmbeddedNavigator.Name = ""
        Me.GridFtpLocal.FormsUseDefaultLookAndFeel = False
        Me.GridFtpLocal.Location = New System.Drawing.Point(12, 101)
        Me.GridFtpLocal.MainView = Me.GridViewFtpLocal
        Me.GridFtpLocal.Name = "GridFtpLocal"
        Me.GridFtpLocal.Size = New System.Drawing.Size(318, 527)
        Me.GridFtpLocal.TabIndex = 5
        Me.GridFtpLocal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewFtpLocal})
        '
        'GridViewFtpLocal
        '
        Me.GridViewFtpLocal.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNameFileFtp})
        Me.GridViewFtpLocal.GridControl = Me.GridFtpLocal
        Me.GridViewFtpLocal.Name = "GridViewFtpLocal"
        Me.GridViewFtpLocal.OptionsBehavior.Editable = False
        Me.GridViewFtpLocal.OptionsView.ShowFooter = True
        '
        'colNameFileFtp
        '
        Me.colNameFileFtp.Caption = "Name file"
        Me.colNameFileFtp.FieldName = "Column"
        Me.colNameFileFtp.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colNameFileFtp.Name = "colNameFileFtp"
        Me.colNameFileFtp.OptionsColumn.AllowEdit = False
        Me.colNameFileFtp.OptionsColumn.ReadOnly = True
        Me.colNameFileFtp.Visible = True
        Me.colNameFileFtp.VisibleIndex = 0
        '
        'BtnCompare
        '
        Me.BtnCompare.Location = New System.Drawing.Point(230, 3)
        Me.BtnCompare.Name = "BtnCompare"
        Me.BtnCompare.Size = New System.Drawing.Size(75, 23)
        Me.BtnCompare.TabIndex = 4
        Me.BtnCompare.Text = "Compare"
        Me.BtnCompare.UseVisualStyleBackColor = True
        '
        'lblFTP
        '
        Me.lblFTP.AutoSize = True
        Me.lblFTP.Location = New System.Drawing.Point(9, 34)
        Me.lblFTP.Name = "lblFTP"
        Me.lblFTP.Size = New System.Drawing.Size(27, 13)
        Me.lblFTP.TabIndex = 2
        Me.lblFTP.Text = "FTP"
        '
        'XtabAutomateTranscode
        '
        Me.XtabAutomateTranscode.Controls.Add(Me.lblError)
        Me.XtabAutomateTranscode.Controls.Add(Me.lblOk)
        Me.XtabAutomateTranscode.Controls.Add(Me.lstError)
        Me.XtabAutomateTranscode.Controls.Add(Me.LstResult)
        Me.XtabAutomateTranscode.Controls.Add(Me.btnGenerateVod)
        Me.XtabAutomateTranscode.Controls.Add(Me.txtPathOfFile)
        Me.XtabAutomateTranscode.Controls.Add(Me.btnChooseFileTxt)
        Me.XtabAutomateTranscode.Controls.Add(Me.lblTxtFile)
        Me.XtabAutomateTranscode.Margin = New System.Windows.Forms.Padding(2)
        Me.XtabAutomateTranscode.Name = "XtabAutomateTranscode"
        Me.XtabAutomateTranscode.Size = New System.Drawing.Size(1000, 694)
        Me.XtabAutomateTranscode.Text = "Automate Transcode"
        Me.XtabAutomateTranscode.Tooltip = "Deletes data from last load"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(203, 327)
        Me.lblError.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(29, 13)
        Me.lblError.TabIndex = 13
        Me.lblError.Text = "Error"
        '
        'lblOk
        '
        Me.lblOk.AutoSize = True
        Me.lblOk.Location = New System.Drawing.Point(203, 58)
        Me.lblOk.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOk.Name = "lblOk"
        Me.lblOk.Size = New System.Drawing.Size(49, 13)
        Me.lblOk.TabIndex = 12
        Me.lblOk.Text = "new Vod"
        '
        'lstError
        '
        Me.lstError.FormattingEnabled = True
        Me.lstError.Location = New System.Drawing.Point(290, 327)
        Me.lstError.Margin = New System.Windows.Forms.Padding(2)
        Me.lstError.Name = "lstError"
        Me.lstError.Size = New System.Drawing.Size(457, 225)
        Me.lstError.TabIndex = 11
        '
        'LstResult
        '
        Me.LstResult.FormattingEnabled = True
        Me.LstResult.Location = New System.Drawing.Point(290, 58)
        Me.LstResult.Margin = New System.Windows.Forms.Padding(2)
        Me.LstResult.Name = "LstResult"
        Me.LstResult.Size = New System.Drawing.Size(457, 238)
        Me.LstResult.TabIndex = 10
        '
        'btnGenerateVod
        '
        Me.btnGenerateVod.Location = New System.Drawing.Point(16, 58)
        Me.btnGenerateVod.Name = "btnGenerateVod"
        Me.btnGenerateVod.Size = New System.Drawing.Size(116, 23)
        Me.btnGenerateVod.TabIndex = 9
        Me.btnGenerateVod.Text = "Generate Create vod"
        '
        'txtPathOfFile
        '
        Me.txtPathOfFile.Location = New System.Drawing.Point(206, 15)
        Me.txtPathOfFile.Name = "txtPathOfFile"
        Me.txtPathOfFile.Size = New System.Drawing.Size(471, 20)
        Me.txtPathOfFile.TabIndex = 8
        '
        'btnChooseFileTxt
        '
        Me.btnChooseFileTxt.Location = New System.Drawing.Point(16, 15)
        Me.btnChooseFileTxt.Name = "btnChooseFileTxt"
        Me.btnChooseFileTxt.Size = New System.Drawing.Size(40, 23)
        Me.btnChooseFileTxt.TabIndex = 7
        Me.btnChooseFileTxt.Text = "..."
        '
        'lblTxtFile
        '
        Me.lblTxtFile.AutoSize = True
        Me.lblTxtFile.Location = New System.Drawing.Point(62, 22)
        Me.lblTxtFile.Name = "lblTxtFile"
        Me.lblTxtFile.Size = New System.Drawing.Size(76, 13)
        Me.lblTxtFile.TabIndex = 6
        Me.lblTxtFile.Text = "Source files txt"
        '
        'xTabVODOnlyMovie
        '
        Me.xTabVODOnlyMovie.Controls.Add(Me.grdOnlyVODMovie)
        Me.xTabVODOnlyMovie.Controls.Add(Me.btnAllNoMovieInfo)
        Me.xTabVODOnlyMovie.Name = "xTabVODOnlyMovie"
        Me.xTabVODOnlyMovie.Size = New System.Drawing.Size(1000, 694)
        Me.xTabVODOnlyMovie.Text = "VOD Without Info"
        '
        'grdOnlyVODMovie
        '
        Me.grdOnlyVODMovie.EmbeddedNavigator.Name = ""
        Me.grdOnlyVODMovie.FormsUseDefaultLookAndFeel = False
        Me.grdOnlyVODMovie.Location = New System.Drawing.Point(26, 69)
        Me.grdOnlyVODMovie.MainView = Me.GridView1
        Me.grdOnlyVODMovie.Name = "grdOnlyVODMovie"
        Me.grdOnlyVODMovie.Size = New System.Drawing.Size(486, 530)
        Me.grdOnlyVODMovie.TabIndex = 19
        Me.grdOnlyVODMovie.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.imdb_id, Me.filename})
        Me.GridView1.GridControl = Me.grdOnlyVODMovie
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'imdb_id
        '
        Me.imdb_id.Caption = "imdb_id"
        Me.imdb_id.FieldName = "imdb_id"
        Me.imdb_id.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.imdb_id.Name = "imdb_id"
        Me.imdb_id.OptionsColumn.ReadOnly = True
        Me.imdb_id.Visible = True
        Me.imdb_id.VisibleIndex = 0
        Me.imdb_id.Width = 147
        '
        'filename
        '
        Me.filename.Caption = "file name"
        Me.filename.FieldName = "filename"
        Me.filename.Name = "filename"
        Me.filename.Visible = True
        Me.filename.VisibleIndex = 1
        Me.filename.Width = 318
        '
        'btnAllNoMovieInfo
        '
        Me.btnAllNoMovieInfo.Location = New System.Drawing.Point(26, 30)
        Me.btnAllNoMovieInfo.Name = "btnAllNoMovieInfo"
        Me.btnAllNoMovieInfo.Size = New System.Drawing.Size(136, 23)
        Me.btnAllNoMovieInfo.TabIndex = 18
        Me.btnAllNoMovieInfo.Text = "Show All VOD Without Info"
        '
        'XtraTabTrailerSearch
        '
        Me.XtraTabTrailerSearch.Controls.Add(Me.btnTrailerViewAll)
        Me.XtraTabTrailerSearch.Controls.Add(Me.btnTrailerNew)
        Me.XtraTabTrailerSearch.Controls.Add(Me.btnTrailerSearch)
        Me.XtraTabTrailerSearch.Controls.Add(Me.txtTrailerImdbSearch)
        Me.XtraTabTrailerSearch.Controls.Add(Me.LabelControl4)
        Me.XtraTabTrailerSearch.Controls.Add(Me.txtTrailerProductsIDSearch)
        Me.XtraTabTrailerSearch.Controls.Add(Me.LabelControl5)
        Me.XtraTabTrailerSearch.Controls.Add(Me.txtTrailerTitleSearch)
        Me.XtraTabTrailerSearch.Controls.Add(Me.LabelControl11)
        Me.XtraTabTrailerSearch.Name = "XtraTabTrailerSearch"
        Me.XtraTabTrailerSearch.Size = New System.Drawing.Size(1000, 694)
        Me.XtraTabTrailerSearch.Text = "Trailer search"
        '
        'btnTrailerViewAll
        '
        Me.btnTrailerViewAll.Location = New System.Drawing.Point(320, 200)
        Me.btnTrailerViewAll.Name = "btnTrailerViewAll"
        Me.btnTrailerViewAll.Size = New System.Drawing.Size(75, 23)
        Me.btnTrailerViewAll.TabIndex = 27
        Me.btnTrailerViewAll.Text = "View all"
        '
        'btnTrailerNew
        '
        Me.btnTrailerNew.Location = New System.Drawing.Point(179, 200)
        Me.btnTrailerNew.Name = "btnTrailerNew"
        Me.btnTrailerNew.Size = New System.Drawing.Size(75, 23)
        Me.btnTrailerNew.TabIndex = 26
        Me.btnTrailerNew.Text = "New"
        '
        'btnTrailerSearch
        '
        Me.btnTrailerSearch.Location = New System.Drawing.Point(41, 200)
        Me.btnTrailerSearch.Name = "btnTrailerSearch"
        Me.btnTrailerSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnTrailerSearch.TabIndex = 25
        Me.btnTrailerSearch.Text = "Search"
        '
        'txtTrailerImdbSearch
        '
        Me.txtTrailerImdbSearch.Location = New System.Drawing.Point(142, 102)
        Me.txtTrailerImdbSearch.Name = "txtTrailerImdbSearch"
        Me.txtTrailerImdbSearch.Size = New System.Drawing.Size(112, 20)
        Me.txtTrailerImdbSearch.TabIndex = 24
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(11, 105)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl4.TabIndex = 23
        Me.LabelControl4.Text = "Imdb ID"
        '
        'txtTrailerProductsIDSearch
        '
        Me.txtTrailerProductsIDSearch.Location = New System.Drawing.Point(142, 57)
        Me.txtTrailerProductsIDSearch.Name = "txtTrailerProductsIDSearch"
        Me.txtTrailerProductsIDSearch.Size = New System.Drawing.Size(112, 20)
        Me.txtTrailerProductsIDSearch.TabIndex = 22
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(11, 60)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl5.TabIndex = 21
        Me.LabelControl5.Text = "Product ID"
        '
        'txtTrailerTitleSearch
        '
        Me.txtTrailerTitleSearch.Location = New System.Drawing.Point(142, 17)
        Me.txtTrailerTitleSearch.Name = "txtTrailerTitleSearch"
        Me.txtTrailerTitleSearch.Size = New System.Drawing.Size(472, 20)
        Me.txtTrailerTitleSearch.TabIndex = 20
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(11, 24)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl11.TabIndex = 19
        Me.LabelControl11.Text = "Part of Title"
        '
        'XtraTabTrailerResult
        '
        Me.XtraTabTrailerResult.Controls.Add(Me.gridTrailersResult)
        Me.XtraTabTrailerResult.Name = "XtraTabTrailerResult"
        Me.XtraTabTrailerResult.Size = New System.Drawing.Size(1000, 694)
        Me.XtraTabTrailerResult.Text = "ResultTrailer"
        '
        'gridTrailersResult
        '
        Me.gridTrailersResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridTrailersResult.EmbeddedNavigator.Name = ""
        Me.gridTrailersResult.FormsUseDefaultLookAndFeel = False
        Me.gridTrailersResult.Location = New System.Drawing.Point(0, 0)
        Me.gridTrailersResult.MainView = Me.GridViewTrailer
        Me.gridTrailersResult.Name = "gridTrailersResult"
        Me.gridTrailersResult.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbTrailerLanguageGrid, Me.RepositoryItemCheckEdit2, Me.RepositoryItemLookUpEdit5, Me.RepositoryItemLookUpEdit4, Me.RepositoryItemComboBox1, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.cmbTrailerSubtitleGrid, Me.RepositoryItemLookUpEdit8, Me.RepositoryItemSpinEdit1, Me.RepositoryItemDateEdit3, Me.RepositoryItemDateEdit4})
        Me.gridTrailersResult.Size = New System.Drawing.Size(1000, 694)
        Me.gridTrailersResult.TabIndex = 5
        Me.gridTrailersResult.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewTrailer})
        '
        'GridViewTrailer
        '
        Me.GridViewTrailer.Appearance.FocusedRow.BackColor = System.Drawing.Color.Silver
        Me.GridViewTrailer.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridViewTrailer.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand6, Me.GridBand7, Me.GridBand8})
        Me.GridViewTrailer.ColumnPanelRowHeight = 45
        Me.GridViewTrailer.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BandedGridColumn2, Me.BandedGridColumn8, Me.BandedGridColumn3, Me.BandedGridColumn10, Me.BandedGridColumn11, Me.BandedGridColumn9, Me.BandedGridColumn14, Me.BandedGridColumn7})
        Me.GridViewTrailer.CustomizationFormBounds = New System.Drawing.Rectangle(0, 375, 225, 209)
        Me.GridViewTrailer.DetailHeight = 50
        Me.GridViewTrailer.GridControl = Me.gridTrailersResult
        Me.GridViewTrailer.Name = "GridViewTrailer"
        Me.GridViewTrailer.OptionsView.ColumnAutoWidth = True
        Me.GridViewTrailer.OptionsView.ShowAutoFilterRow = True
        Me.GridViewTrailer.OptionsView.ShowBands = False
        Me.GridViewTrailer.OptionsView.ShowFooter = True
        Me.GridViewTrailer.RowHeight = 33
        Me.GridViewTrailer.RowSeparatorHeight = 3
        '
        'GridBand6
        '
        Me.GridBand6.Caption = "GridBand1"
        Me.GridBand6.Columns.Add(Me.BandedGridColumn2)
        Me.GridBand6.Columns.Add(Me.BandedGridColumn3)
        Me.GridBand6.Columns.Add(Me.BandedGridColumn7)
        Me.GridBand6.Columns.Add(Me.BandedGridColumn8)
        Me.GridBand6.Columns.Add(Me.BandedGridColumn9)
        Me.GridBand6.Columns.Add(Me.BandedGridColumn10)
        Me.GridBand6.Columns.Add(Me.BandedGridColumn11)
        Me.GridBand6.Columns.Add(Me.BandedGridColumn14)
        Me.GridBand6.MinWidth = 20
        Me.GridBand6.Name = "GridBand6"
        Me.GridBand6.Width = 807
        '
        'BandedGridColumn2
        '
        Me.BandedGridColumn2.Caption = "imdb id"
        Me.BandedGridColumn2.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.BandedGridColumn2.FieldName = "imdb_id"
        Me.BandedGridColumn2.Name = "BandedGridColumn2"
        Me.BandedGridColumn2.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn2.Visible = True
        Me.BandedGridColumn2.Width = 61
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'BandedGridColumn3
        '
        Me.BandedGridColumn3.Caption = "products name"
        Me.BandedGridColumn3.FieldName = "products_name"
        Me.BandedGridColumn3.Name = "BandedGridColumn3"
        Me.BandedGridColumn3.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn3.Visible = True
        Me.BandedGridColumn3.Width = 165
        '
        'BandedGridColumn7
        '
        Me.BandedGridColumn7.Caption = "status"
        Me.BandedGridColumn7.ColumnEdit = Me.RepositoryItemComboBox1
        Me.BandedGridColumn7.FieldName = "status"
        Me.BandedGridColumn7.Name = "BandedGridColumn7"
        Me.BandedGridColumn7.Visible = True
        Me.BandedGridColumn7.Width = 91
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'BandedGridColumn8
        '
        Me.BandedGridColumn8.Caption = "language sound"
        Me.BandedGridColumn8.ColumnEdit = Me.cmbTrailerLanguageGrid
        Me.BandedGridColumn8.FieldName = "language_id"
        Me.BandedGridColumn8.Name = "BandedGridColumn8"
        Me.BandedGridColumn8.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn8.Visible = True
        Me.BandedGridColumn8.Width = 91
        '
        'cmbTrailerLanguageGrid
        '
        Me.cmbTrailerLanguageGrid.AutoHeight = False
        Me.cmbTrailerLanguageGrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTrailerLanguageGrid.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "languages_id", 82, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 32, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbTrailerLanguageGrid.DisplayMember = "name"
        Me.cmbTrailerLanguageGrid.Name = "cmbTrailerLanguageGrid"
        Me.cmbTrailerLanguageGrid.NullText = ""
        Me.cmbTrailerLanguageGrid.ValueMember = "languages_id"
        '
        'BandedGridColumn9
        '
        Me.BandedGridColumn9.Caption = "language subtitle"
        Me.BandedGridColumn9.ColumnEdit = Me.cmbTrailerSubtitleGrid
        Me.BandedGridColumn9.FieldName = "subtitle_id"
        Me.BandedGridColumn9.Name = "BandedGridColumn9"
        Me.BandedGridColumn9.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn9.Visible = True
        Me.BandedGridColumn9.Width = 94
        '
        'cmbTrailerSubtitleGrid
        '
        Me.cmbTrailerSubtitleGrid.AutoHeight = False
        Me.cmbTrailerSubtitleGrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTrailerSubtitleGrid.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_id", "id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "language", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbTrailerSubtitleGrid.DisplayMember = "code"
        Me.cmbTrailerSubtitleGrid.Name = "cmbTrailerSubtitleGrid"
        Me.cmbTrailerSubtitleGrid.NullText = ""
        '
        'BandedGridColumn10
        '
        Me.BandedGridColumn10.Caption = "date start"
        Me.BandedGridColumn10.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.BandedGridColumn10.FieldName = "available_from"
        Me.BandedGridColumn10.Name = "BandedGridColumn10"
        Me.BandedGridColumn10.Visible = True
        Me.BandedGridColumn10.Width = 89
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'BandedGridColumn11
        '
        Me.BandedGridColumn11.Caption = "date expired"
        Me.BandedGridColumn11.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.BandedGridColumn11.FieldName = "expire_at"
        Me.BandedGridColumn11.Name = "BandedGridColumn11"
        Me.BandedGridColumn11.Visible = True
        Me.BandedGridColumn11.Width = 108
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'BandedGridColumn14
        '
        Me.BandedGridColumn14.Caption = "available"
        Me.BandedGridColumn14.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.BandedGridColumn14.FieldName = "available"
        Me.BandedGridColumn14.Name = "BandedGridColumn14"
        Me.BandedGridColumn14.Visible = True
        Me.BandedGridColumn14.Width = 108
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.ValueChecked = CType(1, Byte)
        Me.RepositoryItemCheckEdit2.ValueUnchecked = CType(0, Byte)
        '
        'GridBand7
        '
        Me.GridBand7.Caption = "gridBand1"
        Me.GridBand7.MinWidth = 20
        Me.GridBand7.Name = "GridBand7"
        Me.GridBand7.Width = 95
        '
        'GridBand8
        '
        Me.GridBand8.Caption = "gridBand2"
        Me.GridBand8.MinWidth = 20
        Me.GridBand8.Name = "GridBand8"
        Me.GridBand8.Width = 74
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_id", "id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_name", "name", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.RepositoryItemLookUpEdit5.DisplayMember = "studio_name"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.NullText = ""
        Me.RepositoryItemLookUpEdit5.ValueMember = "studio_id"
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        '
        'RepositoryItemLookUpEdit8
        '
        Me.RepositoryItemLookUpEdit8.AutoHeight = False
        Me.RepositoryItemLookUpEdit8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit8.Name = "RepositoryItemLookUpEdit8"
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        Me.RepositoryItemDateEdit3.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'RepositoryItemDateEdit4
        '
        Me.RepositoryItemDateEdit4.AutoHeight = False
        Me.RepositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.Name = "RepositoryItemDateEdit4"
        Me.RepositoryItemDateEdit4.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'XtraTabTrailerView
        '
        Me.XtraTabTrailerView.Controls.Add(Me.txtTrailerID)
        Me.XtraTabTrailerView.Controls.Add(Me.LabelControl43)
        Me.XtraTabTrailerView.Controls.Add(Me.LabelControl40)
        Me.XtraTabTrailerView.Controls.Add(Me.LabelControl41)
        Me.XtraTabTrailerView.Controls.Add(Me.LabelControl42)
        Me.XtraTabTrailerView.Controls.Add(Me.cmbTrailerDateStart)
        Me.XtraTabTrailerView.Controls.Add(Me.cmbTRailerDateExpired)
        Me.XtraTabTrailerView.Controls.Add(Me.chkTrailerAvailable)
        Me.XtraTabTrailerView.Controls.Add(Me.btnTrailerDelete)
        Me.XtraTabTrailerView.Controls.Add(Me.cmdTrailerStatus)
        Me.XtraTabTrailerView.Controls.Add(Me.LabelControl19)
        Me.XtraTabTrailerView.Controls.Add(Me.btnTrailerCancel)
        Me.XtraTabTrailerView.Controls.Add(Me.cmbTrailerSubtitle)
        Me.XtraTabTrailerView.Controls.Add(Me.cmbTrailerLanguageSound)
        Me.XtraTabTrailerView.Controls.Add(Me.txtTrailerFilename)
        Me.XtraTabTrailerView.Controls.Add(Me.LabelControl21)
        Me.XtraTabTrailerView.Controls.Add(Me.LabelControl22)
        Me.XtraTabTrailerView.Controls.Add(Me.LabelControl23)
        Me.XtraTabTrailerView.Controls.Add(Me.txtTrailerImdb)
        Me.XtraTabTrailerView.Controls.Add(Me.LabelControl24)
        Me.XtraTabTrailerView.Controls.Add(Me.btnTrailerSave)
        Me.XtraTabTrailerView.Controls.Add(Me.btnTrailerEdit)
        Me.XtraTabTrailerView.Name = "XtraTabTrailerView"
        Me.XtraTabTrailerView.Size = New System.Drawing.Size(1000, 694)
        Me.XtraTabTrailerView.Text = "Trailer View"
        '
        'txtTrailerID
        '
        Me.txtTrailerID.Enabled = False
        Me.txtTrailerID.Location = New System.Drawing.Point(136, 68)
        Me.txtTrailerID.Name = "txtTrailerID"
        Me.txtTrailerID.Size = New System.Drawing.Size(73, 20)
        Me.txtTrailerID.TabIndex = 115
        '
        'LabelControl43
        '
        Me.LabelControl43.Location = New System.Drawing.Point(30, 71)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl43.TabIndex = 116
        Me.LabelControl43.Text = "ID"
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(436, 182)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl40.TabIndex = 114
        Me.LabelControl40.Text = "available"
        '
        'LabelControl41
        '
        Me.LabelControl41.Location = New System.Drawing.Point(31, 283)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl41.TabIndex = 113
        Me.LabelControl41.Text = "date expired"
        '
        'LabelControl42
        '
        Me.LabelControl42.Location = New System.Drawing.Point(31, 250)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl42.TabIndex = 112
        Me.LabelControl42.Text = "date start"
        '
        'cmbTrailerDateStart
        '
        Me.cmbTrailerDateStart.EditValue = Nothing
        Me.cmbTrailerDateStart.Enabled = False
        Me.cmbTrailerDateStart.Location = New System.Drawing.Point(136, 243)
        Me.cmbTrailerDateStart.Name = "cmbTrailerDateStart"
        Me.cmbTrailerDateStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTrailerDateStart.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbTrailerDateStart.Size = New System.Drawing.Size(112, 20)
        Me.cmbTrailerDateStart.TabIndex = 110
        '
        'cmbTRailerDateExpired
        '
        Me.cmbTRailerDateExpired.EditValue = Nothing
        Me.cmbTRailerDateExpired.Enabled = False
        Me.cmbTRailerDateExpired.Location = New System.Drawing.Point(136, 280)
        Me.cmbTRailerDateExpired.Name = "cmbTRailerDateExpired"
        Me.cmbTRailerDateExpired.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTRailerDateExpired.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbTRailerDateExpired.Size = New System.Drawing.Size(112, 20)
        Me.cmbTRailerDateExpired.TabIndex = 111
        '
        'chkTrailerAvailable
        '
        Me.chkTrailerAvailable.Location = New System.Drawing.Point(484, 180)
        Me.chkTrailerAvailable.Name = "chkTrailerAvailable"
        Me.chkTrailerAvailable.Properties.Caption = ""
        Me.chkTrailerAvailable.Size = New System.Drawing.Size(44, 19)
        Me.chkTrailerAvailable.TabIndex = 109
        '
        'btnTrailerDelete
        '
        Me.btnTrailerDelete.Enabled = False
        Me.btnTrailerDelete.Location = New System.Drawing.Point(330, 25)
        Me.btnTrailerDelete.Name = "btnTrailerDelete"
        Me.btnTrailerDelete.Size = New System.Drawing.Size(79, 23)
        Me.btnTrailerDelete.TabIndex = 108
        Me.btnTrailerDelete.Text = "Delete"
        '
        'cmdTrailerStatus
        '
        Me.cmdTrailerStatus.Enabled = False
        Me.cmdTrailerStatus.Location = New System.Drawing.Point(485, 138)
        Me.cmdTrailerStatus.Name = "cmdTrailerStatus"
        Me.cmdTrailerStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdTrailerStatus.Properties.DisplayMember = "status_desc"
        Me.cmdTrailerStatus.Properties.NullText = ""
        Me.cmdTrailerStatus.Properties.ValueMember = "status_id"
        Me.cmdTrailerStatus.Size = New System.Drawing.Size(112, 20)
        Me.cmdTrailerStatus.TabIndex = 101
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(436, 142)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl19.TabIndex = 100
        Me.LabelControl19.Text = "status"
        '
        'btnTrailerCancel
        '
        Me.btnTrailerCancel.Enabled = False
        Me.btnTrailerCancel.Location = New System.Drawing.Point(228, 25)
        Me.btnTrailerCancel.Name = "btnTrailerCancel"
        Me.btnTrailerCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnTrailerCancel.TabIndex = 97
        Me.btnTrailerCancel.Text = "Cancel"
        '
        'cmbTrailerSubtitle
        '
        Me.cmbTrailerSubtitle.Enabled = False
        Me.cmbTrailerSubtitle.Location = New System.Drawing.Point(136, 210)
        Me.cmbTrailerSubtitle.Name = "cmbTrailerSubtitle"
        Me.cmbTrailerSubtitle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTrailerSubtitle.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("subtitle_id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("lngdsc", "Language", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbTrailerSubtitle.Properties.DisplayMember = "lngdsc"
        Me.cmbTrailerSubtitle.Properties.NullText = ""
        Me.cmbTrailerSubtitle.Properties.ValueMember = "subtitle_id"
        Me.cmbTrailerSubtitle.Size = New System.Drawing.Size(112, 20)
        Me.cmbTrailerSubtitle.TabIndex = 96
        '
        'cmbTrailerLanguageSound
        '
        Me.cmbTrailerLanguageSound.Enabled = False
        Me.cmbTrailerLanguageSound.Location = New System.Drawing.Point(136, 175)
        Me.cmbTrailerLanguageSound.Name = "cmbTrailerLanguageSound"
        Me.cmbTrailerLanguageSound.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTrailerLanguageSound.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("lngdsc", "Language", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbTrailerLanguageSound.Properties.DisplayMember = "lngdsc"
        Me.cmbTrailerLanguageSound.Properties.NullText = ""
        Me.cmbTrailerLanguageSound.Properties.ValueMember = "id"
        Me.cmbTrailerLanguageSound.Size = New System.Drawing.Size(112, 20)
        Me.cmbTrailerLanguageSound.TabIndex = 95
        '
        'txtTrailerFilename
        '
        Me.txtTrailerFilename.Enabled = False
        Me.txtTrailerFilename.Location = New System.Drawing.Point(136, 137)
        Me.txtTrailerFilename.Name = "txtTrailerFilename"
        Me.txtTrailerFilename.Size = New System.Drawing.Size(273, 20)
        Me.txtTrailerFilename.TabIndex = 94
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(31, 141)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl21.TabIndex = 93
        Me.LabelControl21.Text = "file name"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(31, 214)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl22.TabIndex = 92
        Me.LabelControl22.Text = "language subtitle"
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(30, 179)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl23.TabIndex = 91
        Me.LabelControl23.Text = "language sound"
        '
        'txtTrailerImdb
        '
        Me.txtTrailerImdb.Enabled = False
        Me.txtTrailerImdb.Location = New System.Drawing.Point(136, 102)
        Me.txtTrailerImdb.Name = "txtTrailerImdb"
        Me.txtTrailerImdb.Size = New System.Drawing.Size(112, 20)
        Me.txtTrailerImdb.TabIndex = 90
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(31, 106)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl24.TabIndex = 89
        Me.LabelControl24.Text = "Imdb ID"
        '
        'btnTrailerSave
        '
        Me.btnTrailerSave.Enabled = False
        Me.btnTrailerSave.Location = New System.Drawing.Point(31, 25)
        Me.btnTrailerSave.Name = "btnTrailerSave"
        Me.btnTrailerSave.Size = New System.Drawing.Size(75, 23)
        Me.btnTrailerSave.TabIndex = 88
        Me.btnTrailerSave.Text = "Save"
        '
        'btnTrailerEdit
        '
        Me.btnTrailerEdit.Enabled = False
        Me.btnTrailerEdit.Location = New System.Drawing.Point(126, 25)
        Me.btnTrailerEdit.Name = "btnTrailerEdit"
        Me.btnTrailerEdit.Size = New System.Drawing.Size(79, 23)
        Me.btnTrailerEdit.TabIndex = 87
        Me.btnTrailerEdit.Text = "Edit"
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(157, 28)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(472, 20)
        Me.TextEdit2.TabIndex = 10
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(26, 35)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Part of Title"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(194, 211)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 16
        Me.SimpleButton1.Text = "New"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(56, 211)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 15
        Me.SimpleButton2.Text = "Search"
        '
        'TextEdit3
        '
        Me.TextEdit3.Enabled = False
        Me.TextEdit3.Location = New System.Drawing.Point(157, 113)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(112, 20)
        Me.TextEdit3.TabIndex = 14
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(26, 116)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl3.TabIndex = 13
        Me.LabelControl3.Text = "Imdb ID"
        '
        'TextEdit4
        '
        Me.TextEdit4.Enabled = False
        Me.TextEdit4.Location = New System.Drawing.Point(157, 68)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(112, 20)
        Me.TextEdit4.TabIndex = 12
        '
        'FolderChoose
        '
        Me.FolderChoose.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.FolderChoose.SelectedPath = "Z:\VOD\tmp"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Enabled = False
        Me.DateEdit1.Location = New System.Drawing.Point(194, 18)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(112, 20)
        Me.DateEdit1.TabIndex = 67
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextEdit9)
        Me.GroupBox3.Controls.Add(Me.LabelControl16)
        Me.GroupBox3.Controls.Add(Me.DateEdit1)
        Me.GroupBox3.Controls.Add(Me.DateEdit2)
        Me.GroupBox3.Controls.Add(Me.CheckEdit1)
        Me.GroupBox3.Controls.Add(Me.DateEdit3)
        Me.GroupBox3.Controls.Add(Me.TextEdit10)
        Me.GroupBox3.Controls.Add(Me.DateEdit4)
        Me.GroupBox3.Controls.Add(Me.CheckEdit2)
        Me.GroupBox3.Controls.Add(Me.SpinEdit1)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 329)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(928, 82)
        Me.GroupBox3.TabIndex = 104
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Belgium"
        '
        'TextEdit9
        '
        Me.TextEdit9.Enabled = False
        Me.TextEdit9.Location = New System.Drawing.Point(76, 18)
        Me.TextEdit9.Name = "TextEdit9"
        Me.TextEdit9.Size = New System.Drawing.Size(73, 20)
        Me.TextEdit9.TabIndex = 73
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(770, 58)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl16.TabIndex = 67
        Me.LabelControl16.Text = "PPV price"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Enabled = False
        Me.DateEdit2.Location = New System.Drawing.Point(312, 18)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit2.Size = New System.Drawing.Size(112, 20)
        Me.DateEdit2.TabIndex = 68
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(818, 18)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Is PPV"
        Me.CheckEdit1.Size = New System.Drawing.Size(69, 19)
        Me.CheckEdit1.TabIndex = 103
        '
        'DateEdit3
        '
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.Enabled = False
        Me.DateEdit3.Location = New System.Drawing.Point(430, 18)
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit3.Size = New System.Drawing.Size(112, 20)
        Me.DateEdit3.TabIndex = 89
        '
        'TextEdit10
        '
        Me.TextEdit10.Enabled = False
        Me.TextEdit10.Location = New System.Drawing.Point(820, 52)
        Me.TextEdit10.Name = "TextEdit10"
        Me.TextEdit10.Size = New System.Drawing.Size(97, 20)
        Me.TextEdit10.TabIndex = 102
        '
        'DateEdit4
        '
        Me.DateEdit4.EditValue = Nothing
        Me.DateEdit4.Enabled = False
        Me.DateEdit4.Location = New System.Drawing.Point(548, 18)
        Me.DateEdit4.Name = "DateEdit4"
        Me.DateEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit4.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit4.Size = New System.Drawing.Size(112, 20)
        Me.DateEdit4.TabIndex = 90
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(674, 19)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = ""
        Me.CheckEdit2.Size = New System.Drawing.Size(44, 19)
        Me.CheckEdit2.TabIndex = 65
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(726, 18)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit1.Properties.MaxValue = New Decimal(New Integer() {4, 0, 0, 0})
        Me.SpinEdit1.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit1.Size = New System.Drawing.Size(59, 20)
        Me.SpinEdit1.TabIndex = 84
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextEdit11)
        Me.GroupBox4.Controls.Add(Me.TextEdit12)
        Me.GroupBox4.Controls.Add(Me.LabelControl17)
        Me.GroupBox4.Controls.Add(Me.CheckEdit3)
        Me.GroupBox4.Controls.Add(Me.CheckEdit4)
        Me.GroupBox4.Controls.Add(Me.SpinEdit2)
        Me.GroupBox4.Controls.Add(Me.CheckEdit5)
        Me.GroupBox4.Controls.Add(Me.DateEdit5)
        Me.GroupBox4.Controls.Add(Me.DateEdit6)
        Me.GroupBox4.Controls.Add(Me.DateEdit7)
        Me.GroupBox4.Controls.Add(Me.DateEdit8)
        Me.GroupBox4.Location = New System.Drawing.Point(18, 524)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(932, 82)
        Me.GroupBox4.TabIndex = 101
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Nederland"
        '
        'TextEdit11
        '
        Me.TextEdit11.Enabled = False
        Me.TextEdit11.Location = New System.Drawing.Point(76, 19)
        Me.TextEdit11.Name = "TextEdit11"
        Me.TextEdit11.Size = New System.Drawing.Size(73, 20)
        Me.TextEdit11.TabIndex = 102
        '
        'TextEdit12
        '
        Me.TextEdit12.Enabled = False
        Me.TextEdit12.Location = New System.Drawing.Point(820, 52)
        Me.TextEdit12.Name = "TextEdit12"
        Me.TextEdit12.Size = New System.Drawing.Size(98, 20)
        Me.TextEdit12.TabIndex = 98
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(756, 55)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl17.TabIndex = 97
        Me.LabelControl17.Text = "PPV price"
        '
        'CheckEdit3
        '
        Me.CheckEdit3.Location = New System.Drawing.Point(818, 20)
        Me.CheckEdit3.Name = "CheckEdit3"
        Me.CheckEdit3.Properties.Caption = "Is PPV"
        Me.CheckEdit3.Size = New System.Drawing.Size(59, 19)
        Me.CheckEdit3.TabIndex = 96
        '
        'CheckEdit4
        '
        Me.CheckEdit4.Location = New System.Drawing.Point(6, 20)
        Me.CheckEdit4.Name = "CheckEdit4"
        Me.CheckEdit4.Properties.Caption = ""
        Me.CheckEdit4.Size = New System.Drawing.Size(56, 19)
        Me.CheckEdit4.TabIndex = 95
        '
        'SpinEdit2
        '
        Me.SpinEdit2.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit2.Location = New System.Drawing.Point(726, 19)
        Me.SpinEdit2.Name = "SpinEdit2"
        Me.SpinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit2.Properties.MaxValue = New Decimal(New Integer() {4, 0, 0, 0})
        Me.SpinEdit2.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit2.Size = New System.Drawing.Size(59, 20)
        Me.SpinEdit2.TabIndex = 94
        '
        'CheckEdit5
        '
        Me.CheckEdit5.Location = New System.Drawing.Point(674, 20)
        Me.CheckEdit5.Name = "CheckEdit5"
        Me.CheckEdit5.Properties.Caption = ""
        Me.CheckEdit5.Size = New System.Drawing.Size(47, 19)
        Me.CheckEdit5.TabIndex = 92
        '
        'DateEdit5
        '
        Me.DateEdit5.EditValue = Nothing
        Me.DateEdit5.Enabled = False
        Me.DateEdit5.Location = New System.Drawing.Point(547, 19)
        Me.DateEdit5.Name = "DateEdit5"
        Me.DateEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit5.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit5.Size = New System.Drawing.Size(112, 20)
        Me.DateEdit5.TabIndex = 91
        '
        'DateEdit6
        '
        Me.DateEdit6.EditValue = Nothing
        Me.DateEdit6.Enabled = False
        Me.DateEdit6.Location = New System.Drawing.Point(429, 19)
        Me.DateEdit6.Name = "DateEdit6"
        Me.DateEdit6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit6.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit6.Size = New System.Drawing.Size(112, 20)
        Me.DateEdit6.TabIndex = 90
        '
        'DateEdit7
        '
        Me.DateEdit7.EditValue = Nothing
        Me.DateEdit7.Enabled = False
        Me.DateEdit7.Location = New System.Drawing.Point(312, 19)
        Me.DateEdit7.Name = "DateEdit7"
        Me.DateEdit7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit7.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit7.Size = New System.Drawing.Size(112, 20)
        Me.DateEdit7.TabIndex = 78
        '
        'DateEdit8
        '
        Me.DateEdit8.EditValue = Nothing
        Me.DateEdit8.Enabled = False
        Me.DateEdit8.Location = New System.Drawing.Point(194, 19)
        Me.DateEdit8.Name = "DateEdit8"
        Me.DateEdit8.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit8.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit8.Size = New System.Drawing.Size(112, 20)
        Me.DateEdit8.TabIndex = 77
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(94, 310)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl18.TabIndex = 99
        Me.LabelControl18.Text = "ID"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(877, 310)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl20.TabIndex = 100
        Me.LabelControl20.Text = "credit"
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(694, 310)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl25.TabIndex = 98
        Me.LabelControl25.Text = "available"
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(565, 310)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl26.TabIndex = 97
        Me.LabelControl26.Text = "backatalogue expire"
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(447, 310)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl27.TabIndex = 96
        Me.LabelControl27.Text = "backatalogue start"
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(330, 310)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl28.TabIndex = 95
        Me.LabelControl28.Text = "date expired"
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(212, 310)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl29.TabIndex = 94
        Me.LabelControl29.Text = "date start"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextEdit13)
        Me.GroupBox5.Controls.Add(Me.TextEdit14)
        Me.GroupBox5.Controls.Add(Me.LabelControl30)
        Me.GroupBox5.Controls.Add(Me.CheckEdit6)
        Me.GroupBox5.Controls.Add(Me.CheckEdit7)
        Me.GroupBox5.Controls.Add(Me.SpinEdit3)
        Me.GroupBox5.Controls.Add(Me.CheckEdit8)
        Me.GroupBox5.Controls.Add(Me.DateEdit9)
        Me.GroupBox5.Controls.Add(Me.DateEdit10)
        Me.GroupBox5.Controls.Add(Me.DateEdit11)
        Me.GroupBox5.Controls.Add(Me.DateEdit12)
        Me.GroupBox5.Location = New System.Drawing.Point(18, 436)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(932, 82)
        Me.GroupBox5.TabIndex = 92
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Luxemburg"
        '
        'TextEdit13
        '
        Me.TextEdit13.Enabled = False
        Me.TextEdit13.Location = New System.Drawing.Point(76, 19)
        Me.TextEdit13.Name = "TextEdit13"
        Me.TextEdit13.Size = New System.Drawing.Size(73, 20)
        Me.TextEdit13.TabIndex = 100
        '
        'TextEdit14
        '
        Me.TextEdit14.Enabled = False
        Me.TextEdit14.Location = New System.Drawing.Point(820, 51)
        Me.TextEdit14.Name = "TextEdit14"
        Me.TextEdit14.Size = New System.Drawing.Size(98, 20)
        Me.TextEdit14.TabIndex = 98
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(756, 55)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl30.TabIndex = 97
        Me.LabelControl30.Text = "PPV price"
        '
        'CheckEdit6
        '
        Me.CheckEdit6.Location = New System.Drawing.Point(818, 19)
        Me.CheckEdit6.Name = "CheckEdit6"
        Me.CheckEdit6.Properties.Caption = "Is PPV"
        Me.CheckEdit6.Size = New System.Drawing.Size(59, 19)
        Me.CheckEdit6.TabIndex = 96
        '
        'CheckEdit7
        '
        Me.CheckEdit7.Location = New System.Drawing.Point(6, 20)
        Me.CheckEdit7.Name = "CheckEdit7"
        Me.CheckEdit7.Properties.Caption = ""
        Me.CheckEdit7.Size = New System.Drawing.Size(56, 19)
        Me.CheckEdit7.TabIndex = 95
        '
        'SpinEdit3
        '
        Me.SpinEdit3.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit3.Location = New System.Drawing.Point(726, 19)
        Me.SpinEdit3.Name = "SpinEdit3"
        Me.SpinEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit3.Properties.MaxValue = New Decimal(New Integer() {4, 0, 0, 0})
        Me.SpinEdit3.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit3.Size = New System.Drawing.Size(59, 20)
        Me.SpinEdit3.TabIndex = 94
        '
        'CheckEdit8
        '
        Me.CheckEdit8.Location = New System.Drawing.Point(674, 20)
        Me.CheckEdit8.Name = "CheckEdit8"
        Me.CheckEdit8.Properties.Caption = ""
        Me.CheckEdit8.Size = New System.Drawing.Size(47, 19)
        Me.CheckEdit8.TabIndex = 92
        '
        'DateEdit9
        '
        Me.DateEdit9.EditValue = Nothing
        Me.DateEdit9.Enabled = False
        Me.DateEdit9.Location = New System.Drawing.Point(547, 19)
        Me.DateEdit9.Name = "DateEdit9"
        Me.DateEdit9.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit9.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit9.Size = New System.Drawing.Size(112, 20)
        Me.DateEdit9.TabIndex = 91
        '
        'DateEdit10
        '
        Me.DateEdit10.EditValue = Nothing
        Me.DateEdit10.Enabled = False
        Me.DateEdit10.Location = New System.Drawing.Point(429, 19)
        Me.DateEdit10.Name = "DateEdit10"
        Me.DateEdit10.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit10.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit10.Size = New System.Drawing.Size(112, 20)
        Me.DateEdit10.TabIndex = 90
        '
        'DateEdit11
        '
        Me.DateEdit11.EditValue = Nothing
        Me.DateEdit11.Enabled = False
        Me.DateEdit11.Location = New System.Drawing.Point(312, 19)
        Me.DateEdit11.Name = "DateEdit11"
        Me.DateEdit11.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit11.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit11.Size = New System.Drawing.Size(112, 20)
        Me.DateEdit11.TabIndex = 78
        '
        'DateEdit12
        '
        Me.DateEdit12.EditValue = Nothing
        Me.DateEdit12.Enabled = False
        Me.DateEdit12.Location = New System.Drawing.Point(194, 19)
        Me.DateEdit12.Name = "DateEdit12"
        Me.DateEdit12.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit12.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit12.Size = New System.Drawing.Size(112, 20)
        Me.DateEdit12.TabIndex = 77
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Enabled = False
        Me.SimpleButton7.Location = New System.Drawing.Point(317, 23)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(79, 23)
        Me.SimpleButton7.TabIndex = 86
        Me.SimpleButton7.Text = "Delete"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.AllowDrop = True
        Me.LookUpEdit1.Enabled = False
        Me.LookUpEdit1.Location = New System.Drawing.Point(594, 135)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.DisplayMember = "status_desc"
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.ValueMember = "status_id"
        Me.LookUpEdit1.Size = New System.Drawing.Size(112, 20)
        Me.LookUpEdit1.TabIndex = 83
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(542, 139)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl31.TabIndex = 82
        Me.LabelControl31.Text = "support"
        '
        'LookUpEdit2
        '
        Me.LookUpEdit2.AllowDrop = True
        Me.LookUpEdit2.Enabled = False
        Me.LookUpEdit2.Location = New System.Drawing.Point(594, 100)
        Me.LookUpEdit2.Name = "LookUpEdit2"
        Me.LookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit2.Properties.DisplayMember = "status_desc"
        Me.LookUpEdit2.Properties.NullText = ""
        Me.LookUpEdit2.Properties.ValueMember = "status_id"
        Me.LookUpEdit2.Size = New System.Drawing.Size(112, 20)
        Me.LookUpEdit2.TabIndex = 81
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(542, 104)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl32.TabIndex = 80
        Me.LabelControl32.Text = "source"
        '
        'LookUpEdit3
        '
        Me.LookUpEdit3.AllowDrop = True
        Me.LookUpEdit3.Enabled = False
        Me.LookUpEdit3.Location = New System.Drawing.Point(398, 171)
        Me.LookUpEdit3.Name = "LookUpEdit3"
        Me.LookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit3.Properties.DisplayMember = "status_desc"
        Me.LookUpEdit3.Properties.NullText = ""
        Me.LookUpEdit3.Properties.ValueMember = "status_id"
        Me.LookUpEdit3.Size = New System.Drawing.Size(112, 20)
        Me.LookUpEdit3.TabIndex = 79
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(349, 175)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl33.TabIndex = 78
        Me.LabelControl33.Text = "quality"
        '
        'LookUpEdit5
        '
        Me.LookUpEdit5.Enabled = False
        Me.LookUpEdit5.Location = New System.Drawing.Point(398, 136)
        Me.LookUpEdit5.Name = "LookUpEdit5"
        Me.LookUpEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit5.Properties.DisplayMember = "status_desc"
        Me.LookUpEdit5.Properties.NullText = ""
        Me.LookUpEdit5.Properties.ValueMember = "status_id"
        Me.LookUpEdit5.Size = New System.Drawing.Size(112, 20)
        Me.LookUpEdit5.TabIndex = 77
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(349, 140)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl34.TabIndex = 76
        Me.LabelControl34.Text = "status"
        '
        'LookUpEdit8
        '
        Me.LookUpEdit8.Enabled = False
        Me.LookUpEdit8.Location = New System.Drawing.Point(398, 100)
        Me.LookUpEdit8.Name = "LookUpEdit8"
        Me.LookUpEdit8.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit8.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_name", "name", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit8.Properties.DisplayMember = "status_desc"
        Me.LookUpEdit8.Properties.NullText = ""
        Me.LookUpEdit8.Properties.ValueMember = "status_id"
        Me.LookUpEdit8.Size = New System.Drawing.Size(112, 20)
        Me.LookUpEdit8.TabIndex = 75
        '
        'LabelControl35
        '
        Me.LabelControl35.Location = New System.Drawing.Point(349, 104)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl35.TabIndex = 74
        Me.LabelControl35.Text = "studio"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Enabled = False
        Me.SimpleButton8.Location = New System.Drawing.Point(215, 23)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton8.TabIndex = 71
        Me.SimpleButton8.Text = "Cancel"
        '
        'LookUpEdit9
        '
        Me.LookUpEdit9.Enabled = False
        Me.LookUpEdit9.Location = New System.Drawing.Point(123, 208)
        Me.LookUpEdit9.Name = "LookUpEdit9"
        Me.LookUpEdit9.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit9.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("subtitle_id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("lngdsc", "Language", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit9.Properties.DisplayMember = "lngdsc"
        Me.LookUpEdit9.Properties.NullText = ""
        Me.LookUpEdit9.Properties.ValueMember = "subtitle_id"
        Me.LookUpEdit9.Size = New System.Drawing.Size(112, 20)
        Me.LookUpEdit9.TabIndex = 70
        '
        'LookUpEdit10
        '
        Me.LookUpEdit10.Enabled = False
        Me.LookUpEdit10.Location = New System.Drawing.Point(123, 173)
        Me.LookUpEdit10.Name = "LookUpEdit10"
        Me.LookUpEdit10.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit10.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("lngdsc", "Language", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit10.Properties.DisplayMember = "lngdsc"
        Me.LookUpEdit10.Properties.NullText = ""
        Me.LookUpEdit10.Properties.ValueMember = "id"
        Me.LookUpEdit10.Size = New System.Drawing.Size(112, 20)
        Me.LookUpEdit10.TabIndex = 69
        '
        'TextEdit15
        '
        Me.TextEdit15.Enabled = False
        Me.TextEdit15.Location = New System.Drawing.Point(123, 135)
        Me.TextEdit15.Name = "TextEdit15"
        Me.TextEdit15.Size = New System.Drawing.Size(179, 20)
        Me.TextEdit15.TabIndex = 66
        '
        'LabelControl36
        '
        Me.LabelControl36.Location = New System.Drawing.Point(18, 139)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl36.TabIndex = 63
        Me.LabelControl36.Text = "file name"
        '
        'LabelControl37
        '
        Me.LabelControl37.Location = New System.Drawing.Point(18, 212)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl37.TabIndex = 60
        Me.LabelControl37.Text = "language subtitle"
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(17, 177)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl38.TabIndex = 59
        Me.LabelControl38.Text = "language sound"
        '
        'TextEdit16
        '
        Me.TextEdit16.Enabled = False
        Me.TextEdit16.Location = New System.Drawing.Point(123, 100)
        Me.TextEdit16.Name = "TextEdit16"
        Me.TextEdit16.Size = New System.Drawing.Size(112, 20)
        Me.TextEdit16.TabIndex = 58
        '
        'LabelControl39
        '
        Me.LabelControl39.Location = New System.Drawing.Point(18, 104)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl39.TabIndex = 57
        Me.LabelControl39.Text = "Imdb ID"
        '
        'SimpleButton9
        '
        Me.SimpleButton9.Enabled = False
        Me.SimpleButton9.Location = New System.Drawing.Point(18, 23)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton9.TabIndex = 52
        Me.SimpleButton9.Text = "Save"
        '
        'SimpleButton10
        '
        Me.SimpleButton10.Enabled = False
        Me.SimpleButton10.Location = New System.Drawing.Point(113, 23)
        Me.SimpleButton10.Name = "SimpleButton10"
        Me.SimpleButton10.Size = New System.Drawing.Size(79, 23)
        Me.SimpleButton10.TabIndex = 51
        Me.SimpleButton10.Text = "Edit"
        '
        'chkVideoland
        '
        Me.chkVideoland.Location = New System.Drawing.Point(104, 393)
        Me.chkVideoland.Name = "chkVideoland"
        Me.chkVideoland.Properties.Caption = "Videoland"
        Me.chkVideoland.Size = New System.Drawing.Size(114, 19)
        Me.chkVideoland.TabIndex = 145
        '
        'FrmProductsVOD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 755)
        Me.Controls.Add(Me.XTabVODAndTrailers)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmProductsVOD"
        Me.Text = "FrmProductsVOD"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.XTabVODAndTrailers, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(GridViewInvoiceItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpStartOn.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpStartOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpEndOn.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpEndOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupSVODKind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpPrepaidStartOn.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpPrepaidStartOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpPrepaidEndOn.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpPrepaidEndOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSVODDates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XTabVODAndTrailers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabVODAndTrailers.ResumeLayout(False)
        Me.xTabTrailers.ResumeLayout(False)
        CType(Me.grdTrailers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTrailers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryBtnWatchTrailer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repLanguageTrailers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repSubtitleTrailers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbgridStatusTrailer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguagesTrailers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSubtitleTrailers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabSearch.ResumeLayout(False)
        Me.XTabSearch.PerformLayout()
        CType(Me.txtImdb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtProducts_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabResult.ResumeLayout(False)
        CType(Me.GridVod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnedtCredit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbgridStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguagesSubtitleEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpDateStart.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpDateStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateExpired.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateExpired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpBackcatalogueStart.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpBackcatalogueStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpBackcataloguExpired.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpBackcataloguExpired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkcolAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositorycmbSupportVod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabView.ResumeLayout(False)
        Me.XTabView.PerformLayout()
        CType(Me.txtEpisodeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSeasonID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDRM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateExpired.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateExpired.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsPPV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateLaterStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateLaterStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPPVPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateLaterExpired.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateLaterExpired.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAvailable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtIdNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPPVPriceNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsPPVNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAvailableNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateLaterExpiredNL.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateLaterExpiredNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateLaterStartNL.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateLaterStartNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateExpiredNL.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateExpiredNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateStartNL.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateStartNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbLuxemburg.ResumeLayout(False)
        Me.gpbLuxemburg.PerformLayout()
        CType(Me.txtIdLU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPPVPriceLU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsPPVLU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAvailableLU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateLaterExpiredLU.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateLaterExpiredLU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateLaterStartLU.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateLaterStartLU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateExpiredLU.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateExpiredLU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateStartLU.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateStartLU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSupportVod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbQuality.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStudioEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguageSubtitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguageSound.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFilename.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImdbView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabProcess.ResumeLayout(False)
        Me.XTabProcess.PerformLayout()
        CType(Me.txtDestinationPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSourcePath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarRipping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabViewVod.ResumeLayout(False)
        CType(Me.GridVodWatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewVodWatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryBtnWatchMovie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryCmbStudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositorycmbLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryLanguageSubtitleGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositorychkAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabFtp.ResumeLayout(False)
        Me.XTabFtp.PerformLayout()
        CType(Me.txtSourceFtp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSourceLocal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDBFtp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDBFtp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridFtpLocal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewFtpLocal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtabAutomateTranscode.ResumeLayout(False)
        Me.XtabAutomateTranscode.PerformLayout()
        CType(Me.txtPathOfFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xTabVODOnlyMovie.ResumeLayout(False)
        CType(Me.grdOnlyVODMovie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabTrailerSearch.ResumeLayout(False)
        Me.XtraTabTrailerSearch.PerformLayout()
        CType(Me.txtTrailerImdbSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrailerProductsIDSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrailerTitleSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabTrailerResult.ResumeLayout(False)
        CType(Me.gridTrailersResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTrailer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTrailerLanguageGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTrailerSubtitleGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabTrailerView.ResumeLayout(False)
        Me.XtraTabTrailerView.PerformLayout()
        CType(Me.txtTrailerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTrailerDateStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTrailerDateStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTRailerDateExpired.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTRailerDateExpired.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTrailerAvailable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdTrailerStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTrailerSubtitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTrailerLanguageSound.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrailerFilename.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrailerImdb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit4.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit5.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit6.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit7.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit8.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.TextEdit13.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit9.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit10.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit11.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit12.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit15.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit16.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVideoland.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XTabVODAndTrailers As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTabSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTabResult As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTabView As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtTitleSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPartTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtProducts_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblProduct_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtImdb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblImdb As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridVod As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSearch As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colImdb_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents collanguage_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbLanguages As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colproducts_name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BtnNewVodProduct As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColAvailable_from As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colExpireAt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLanguage_subtitle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAvailable As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents btnSaveVod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditVod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtImdbView As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblImdbView As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNameFile As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLanguage_subtitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLanguageSound As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtFilename As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkAvailable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbDateExpired As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbDateStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbLanguageSubtitle As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbLanguageSound As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnCancelVod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkcolAvailable As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents txtId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colStudio As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbStudio As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbStudioEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblStudio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnViewAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colStatus As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents XTabProcess As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblPathSourceTitle As System.Windows.Forms.Label
    Friend WithEvents FolderChoose As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnSource As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBarRipping As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents btnGenerateRipping As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSourcePath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDestinationPathFile As System.Windows.Forms.Label
    Friend WithEvents txtDestinationPath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnDestination As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XTabViewVod As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridVodWatch As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewVodWatch As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colStudioUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryCmbStudio As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colStatusUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColImdbUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLangAudioUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositorycmbLanguage As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colLangSubtitleUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProductNameUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDateExpiredUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAvailableUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositorychkAvailable As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents lblHigh As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRipped As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XTabFtp As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblFTP As System.Windows.Forms.Label
    Friend WithEvents BtnCompare As System.Windows.Forms.Button
    Friend WithEvents GridFtpLocal As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewFtpLocal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNameFileFtp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridDBFtp As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewDBFtp As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtSourceLocal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnFolderLocal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblLocal As System.Windows.Forms.Label
    Friend WithEvents txtSourceFtp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFtpLocal As System.Windows.Forms.Label
    Friend WithEvents lblDbFtp As System.Windows.Forms.Label
    Friend WithEvents colQuality As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbQuality As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colQuality2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbSource As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblSource As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtabAutomateTranscode As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtPathOfFile As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnChooseFileTxt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTxtFile As System.Windows.Forms.Label
    Friend WithEvents btnGenerateVod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblOk As System.Windows.Forms.Label
    Friend WithEvents lstError As System.Windows.Forms.ListBox
    Friend WithEvents LstResult As System.Windows.Forms.ListBox
    Friend WithEvents cmbSupportVod As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblSupport As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositorycmbSupportVod As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents RepositoryBtnWatchMovie As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colBtnWatchFilm As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Private WithEvents Main_Bar As DevExpress.XtraBars.Bar
    Private WithEvents btnNew As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnEdit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Private WithEvents Misc_Bar As DevExpress.XtraBars.Bar
    Private WithEvents MainBtns_btnExcel As DevExpress.XtraBars.BarButtonItem
    Private WithEvents MainBtns_btnBigger As DevExpress.XtraBars.BarButtonItem
    Private WithEvents MainBtns_btnSmaller As DevExpress.XtraBars.BarButtonItem
    Private WithEvents MainBtns_btnBestFit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnOK As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnUser1 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnUser2 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnUser3 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnUser4 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnUser5 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnExportXML As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnImportXML As DevExpress.XtraBars.BarButtonItem
    Private WithEvents View_Bar As DevExpress.XtraBars.Bar
    Private WithEvents btnView As DevExpress.XtraBars.BarButtonItem
    Private WithEvents cmbViewList As DevExpress.XtraBars.BarEditItem
    'Private WithEvents btnViewDetail As DevExpress.XtraBars.BarSubItem
    Private WithEvents btnEditView As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnNewView As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnDeleteView As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSaveView As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnMakeViewCommon As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSendViewUser As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnCopyView As DevExpress.XtraBars.BarButtonItem
    Private WithEvents QuickSearch_Bar As DevExpress.XtraBars.Bar
    Private WithEvents txtQuickSearch As DevExpress.XtraBars.BarEditItem
    Private WithEvents btnQuickSearch As DevExpress.XtraBars.BarButtonItem
    Private WithEvents Report_Bar As DevExpress.XtraBars.Bar
    Private WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Private WithEvents cmbReportList As DevExpress.XtraBars.BarEditItem
    'Private WithEvents btnReportDetail As DevExpress.XtraBars.BarSubItem
    Private WithEvents btnEditReportInfo As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnNewReport As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnDeleteReport As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnDesignReport As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnMakeReportCommon As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSendReportUser As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnCopyReport As DevExpress.XtraBars.BarButtonItem
    Private WithEvents Filter_Bar As DevExpress.XtraBars.Bar
    Private WithEvents btnFilter As DevExpress.XtraBars.BarButtonItem
    Private WithEvents cmbFilterList As DevExpress.XtraBars.BarEditItem
    'Private WithEvents btnFilterDetail As DevExpress.XtraBars.BarSubItem
    Private WithEvents btnEditFilter As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnNewFilter As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnDeleteFilter As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnMakeFilterCommon As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSendFilterUSer As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnCopyFilter As DevExpress.XtraBars.BarButtonItem
    Private WithEvents DefaultSet_Bar As DevExpress.XtraBars.Bar
    Private WithEvents btnDefault As DevExpress.XtraBars.BarButtonItem
    Private WithEvents cmbDefaultList As DevExpress.XtraBars.BarEditItem
    'Private WithEvents btnDefaultDetail As DevExpress.XtraBars.BarSubItem
    Private WithEvents btnEditDefault As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnNewDefault As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnDeleteDefault As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSaveDefault As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnMakeDefaultCommon As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSendDefaultUser As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnCopyDefault As DevExpress.XtraBars.BarButtonItem
    Private WithEvents Misc_Bar2 As DevExpress.XtraBars.Bar
    Private WithEvents btnTranslation As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnComments As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnAttachements As DevExpress.XtraBars.BarButtonItem
    Private WithEvents Nav_Bar As DevExpress.XtraBars.Bar
    Private WithEvents btnFirst As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnPrevious As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnNext As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnLast As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents xTabVODOnlyMovie As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnAllNoMovieInfo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdOnlyVODMovie As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents imdb_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents filename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDeleteVOD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbgridStatus As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents btnSaveAllChanges As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dpDateStart As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtpDateExpired As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents cmbLanguagesSubtitleEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryLanguageSubtitleGrid As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents spnedtCredit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents WebSiteDvdPost As System.Windows.Forms.WebBrowser
    Friend WithEvents cmbDateLaterExpired As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbDateLaterStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colAvailableBackCatalogueFrom As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents dpBackcatalogueStart As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colBackcatalogueExpireAt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents dpBackcataloguExpired As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gpbLuxemburg As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkAvailableLU As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbDateLaterExpiredLU As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbDateLaterStartLU As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbDateExpiredLU As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbDateStartLU As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkLU As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtPPVPriceLU As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkIsPPVLU As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPPVPriceNL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkIsPPVNL As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkNL As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAvailableNL As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbDateLaterExpiredNL As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbDateLaterStartNL As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbDateExpiredNL As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbDateStartNL As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtIdNL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIdLU As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colcountry As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkIsPPV As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtPPVPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents xTabTrailers As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grdTrailers As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewTrailers As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents col_watch_trailer As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents col_trailer_filename As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents col_imdb_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents col_audio As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents col_sub As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents col_available As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents webTrailers As System.Windows.Forms.WebBrowser
    Friend WithEvents btnSaveTrailers As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbgridStatusTrailer As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cmbLanguagesTrailers As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cmbSubtitleTrailers As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents repLanguageTrailers As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents repSubtitleTrailers As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryBtnWatchTrailer As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents XtraTabTrailerSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnTrailerViewAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTrailerNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTrailerSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTrailerImdbSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTrailerProductsIDSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTrailerTitleSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabTrailerResult As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabTrailerView As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gridTrailersResult As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewTrailer As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents BandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BandedGridColumn7 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BandedGridColumn8 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbTrailerLanguageGrid As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BandedGridColumn9 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbTrailerSubtitleGrid As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BandedGridColumn10 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BandedGridColumn11 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BandedGridColumn14 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents RepositoryItemLookUpEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbTrailerDateStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbTRailerDateExpired As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkTrailerAvailable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnTrailerDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdTrailerStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnTrailerCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbTrailerSubtitle As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbTrailerLanguageSound As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTrailerFilename As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTrailerImdb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnTrailerSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTrailerEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateEdit4 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit4 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SpinEdit2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CheckEdit5 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DateEdit5 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit6 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit7 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit8 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextEdit13 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit14 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit6 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit7 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SpinEdit3 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CheckEdit8 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DateEdit9 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit10 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit11 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit12 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit5 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit8 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LookUpEdit9 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEdit10 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit15 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit16 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTrailerID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridSVODDates As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridBand9 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStartOn As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIMDB As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colEndOn As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCreatedAt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUpdatedAt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSvodA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSvodB As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDRM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents chkDRM As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dpStartOn As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dpEndOn As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colKind As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents lkupSVODKind As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colPrepaidStartOn As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents dpPrepaidStartOn As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colPrepaidEndOn As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents dpPrepaidEndOn As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents txtEpisodeID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSeasonID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents chkVideoland As DevExpress.XtraEditors.CheckEdit
End Class
