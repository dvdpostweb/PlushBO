Imports System.IO
Imports System.Collections.Generic
Public Class frmSurvey
    Inherits BizzLib.frmBKForm
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        AddEventCtrl(TabPictures, GetType(DevExpress.XtraEditors.PictureEdit))
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
    Friend WithEvents XtraTabControlTheme As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabResult As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabDetail As DevExpress.XtraTab.XtraTabPage

    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupSearch As DevExpress.XtraEditors.GroupControl

    Friend WithEvents lblEventThemeId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnNewSurvey As DevExpress.XtraEditors.SimpleButton

    Friend WithEvents lblSelected As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkSelected As DevExpress.XtraEditors.CheckEdit

    Friend WithEvents ContextMenu1 As PlushBuziness.contextMenu
    Friend WithEvents DsSite1 As PlushLib.DsSite
    Private WithEvents GridSurveys As DevExpress.XtraGrid.GridControl
    Private WithEvents GridViewSurveys As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveSurvey As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditSurvey As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNewSurvey_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtSurveyId_edit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTitleEditFR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitleEditFR As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbKind As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblKind As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitleEditNL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitleEditNL As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbThemeEventEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblThemeEventEdit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbKindEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblKindEdit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUpdateDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblUpdateDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCreateDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDateCreate As DevExpress.XtraEditors.LabelControl
    Private WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents coltitle_fr As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents coltitle_nl As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents coltitle_en As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colsurvey_kind_id As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colsurvey_kind_name As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colthemes_event_id As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colthemes_event_name As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents coltotal_rating As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colcreated_at As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colupdated_at As DevExpress.XtraGrid.Columns.GridColumn
    '
    Private WithEvents colDateAdded As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colLastModified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEditLanguage As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEditThemeEvent As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Private WithEvents colKind As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colLanguage As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colthemeEvent As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colStyle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbThemeEvent As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblThemeEvent As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitleEditEN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitleEditEN As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TabPictures As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabTitle_page As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabControl_TitlePage_image As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabTitlePageFR As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_title_page_FR As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents tabTitlePageNL As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_title_page_NL As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents tabTitlePageEN As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_title_page_EN As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents OFDPicture As System.Windows.Forms.OpenFileDialog




    Friend WithEvents TxtSurveyId As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSurvey))
        Me.tabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.GroupSearch = New DevExpress.XtraEditors.GroupControl
        Me.cmbThemeEvent = New DevExpress.XtraEditors.LookUpEdit
        Me.lblThemeEvent = New DevExpress.XtraEditors.LabelControl
        Me.cmbKind = New DevExpress.XtraEditors.LookUpEdit
        Me.lblKind = New DevExpress.XtraEditors.LabelControl
        Me.TxtSurveyId = New DevExpress.XtraEditors.TextEdit
        Me.btnNewSurvey = New DevExpress.XtraEditors.SimpleButton
        Me.lblEventThemeId = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit
        Me.tabResult = New DevExpress.XtraTab.XtraTabPage
        Me.GridSurveys = New DevExpress.XtraGrid.GridControl
        Me.GridViewSurveys = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemLookUpEditLanguage = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEditThemeEvent = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDateAdded = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLastModified = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKind = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLanguage = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colthemeEvent = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStyle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DsSite1 = New PlushLib.DsSite
        Me.chkSelected = New DevExpress.XtraEditors.CheckEdit
        Me.lblSelected = New DevExpress.XtraEditors.LabelControl
        Me.ContextMenu1 = New PlushBuziness.contextMenu
        Me.XtraTabControlTheme = New DevExpress.XtraTab.XtraTabControl
        Me.tabDetail = New DevExpress.XtraTab.XtraTabPage
        Me.txtTitleEditEN = New DevExpress.XtraEditors.TextEdit
        Me.lblTitleEditEN = New DevExpress.XtraEditors.LabelControl
        Me.TabPictures = New DevExpress.XtraTab.XtraTabControl
        Me.tabTitle_page = New DevExpress.XtraTab.XtraTabPage
        Me.tabControl_TitlePage_image = New DevExpress.XtraTab.XtraTabControl
        Me.tabTitlePageFR = New DevExpress.XtraTab.XtraTabPage
        Me.image_title_page_FR = New DevExpress.XtraEditors.PictureEdit
        Me.tabTitlePageNL = New DevExpress.XtraTab.XtraTabPage
        Me.image_title_page_NL = New DevExpress.XtraEditors.PictureEdit
        Me.tabTitlePageEN = New DevExpress.XtraTab.XtraTabPage
        Me.image_title_page_EN = New DevExpress.XtraEditors.PictureEdit
        Me.cmbThemeEventEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.lblThemeEventEdit = New DevExpress.XtraEditors.LabelControl
        Me.cmbKindEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.lblKindEdit = New DevExpress.XtraEditors.LabelControl
        Me.txtUpdateDate = New DevExpress.XtraEditors.TextEdit
        Me.lblUpdateDate = New DevExpress.XtraEditors.LabelControl
        Me.txtCreateDate = New DevExpress.XtraEditors.TextEdit
        Me.lblDateCreate = New DevExpress.XtraEditors.LabelControl
        Me.txtTitleEditNL = New DevExpress.XtraEditors.TextEdit
        Me.lblTitleEditNL = New DevExpress.XtraEditors.LabelControl
        Me.lblId = New DevExpress.XtraEditors.LabelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSaveSurvey = New DevExpress.XtraEditors.SimpleButton
        Me.btnEditSurvey = New DevExpress.XtraEditors.SimpleButton
        Me.btnNewSurvey_edit = New DevExpress.XtraEditors.SimpleButton
        Me.TxtSurveyId_edit = New DevExpress.XtraEditors.TextEdit
        Me.txtTitleEditFR = New DevExpress.XtraEditors.TextEdit
        Me.lblTitleEditFR = New DevExpress.XtraEditors.LabelControl
        Me.OFDPicture = New System.Windows.Forms.OpenFileDialog
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearch.SuspendLayout()
        CType(Me.GroupSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupSearch.SuspendLayout()
        CType(Me.cmbThemeEvent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSurveyId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabResult.SuspendLayout()
        CType(Me.GridSurveys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSurveys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEditLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEditThemeEvent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSite1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControlTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControlTheme.SuspendLayout()
        Me.tabDetail.SuspendLayout()
        CType(Me.txtTitleEditEN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPictures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPictures.SuspendLayout()
        Me.tabTitle_page.SuspendLayout()
        CType(Me.tabControl_TitlePage_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl_TitlePage_image.SuspendLayout()
        Me.tabTitlePageFR.SuspendLayout()
        CType(Me.image_title_page_FR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTitlePageNL.SuspendLayout()
        CType(Me.image_title_page_NL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTitlePageEN.SuspendLayout()
        CType(Me.image_title_page_EN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbThemeEventEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbKindEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUpdateDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreateDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleEditNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSurveyId_edit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleEditFR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabSearch
        '
        Me.tabSearch.Controls.Add(Me.GroupSearch)
        Me.tabSearch.Name = "tabSearch"
        resources.ApplyResources(Me.tabSearch, "tabSearch")
        '
        'GroupSearch
        '
        resources.ApplyResources(Me.GroupSearch, "GroupSearch")
        Me.GroupSearch.Controls.Add(Me.cmbThemeEvent)
        Me.GroupSearch.Controls.Add(Me.lblThemeEvent)
        Me.GroupSearch.Controls.Add(Me.cmbKind)
        Me.GroupSearch.Controls.Add(Me.lblKind)
        Me.GroupSearch.Controls.Add(Me.TxtSurveyId)
        Me.GroupSearch.Controls.Add(Me.btnNewSurvey)
        Me.GroupSearch.Controls.Add(Me.lblEventThemeId)
        Me.GroupSearch.Controls.Add(Me.btnSearch)
        Me.GroupSearch.Controls.Add(Me.lblTitle)
        Me.GroupSearch.Controls.Add(Me.txtTitle)
        Me.GroupSearch.Name = "GroupSearch"
        '
        'cmbThemeEvent
        '
        resources.ApplyResources(Me.cmbThemeEvent, "cmbThemeEvent")
        Me.cmbThemeEvent.Name = "cmbThemeEvent"
        Me.cmbThemeEvent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbThemeEvent.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbThemeEvent.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Name", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbThemeEvent.Properties.NullText = resources.GetString("cmbThemeEvent.Properties.NullText")
        '
        'lblThemeEvent
        '
        resources.ApplyResources(Me.lblThemeEvent, "lblThemeEvent")
        Me.lblThemeEvent.Name = "lblThemeEvent"
        '
        'cmbKind
        '
        resources.ApplyResources(Me.cmbKind, "cmbKind")
        Me.cmbKind.Name = "cmbKind"
        Me.cmbKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbKind.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbKind.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Name", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbKind.Properties.NullText = resources.GetString("cmbKind.Properties.NullText")
        '
        'lblKind
        '
        resources.ApplyResources(Me.lblKind, "lblKind")
        Me.lblKind.Name = "lblKind"
        '
        'TxtSurveyId
        '
        resources.ApplyResources(Me.TxtSurveyId, "TxtSurveyId")
        Me.TxtSurveyId.Name = "TxtSurveyId"
        Me.TxtSurveyId.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtSurveyId.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'btnNewSurvey
        '
        resources.ApplyResources(Me.btnNewSurvey, "btnNewSurvey")
        Me.btnNewSurvey.Name = "btnNewSurvey"
        '
        'lblEventThemeId
        '
        resources.ApplyResources(Me.lblEventThemeId, "lblEventThemeId")
        Me.lblEventThemeId.Name = "lblEventThemeId"
        '
        'btnSearch
        '
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        Me.btnSearch.Name = "btnSearch"
        '
        'lblTitle
        '
        resources.ApplyResources(Me.lblTitle, "lblTitle")
        Me.lblTitle.Name = "lblTitle"
        '
        'txtTitle
        '
        resources.ApplyResources(Me.txtTitle, "txtTitle")
        Me.txtTitle.Name = "txtTitle"
        '
        'tabResult
        '
        Me.tabResult.Controls.Add(Me.GridSurveys)
        Me.tabResult.Name = "tabResult"
        resources.ApplyResources(Me.tabResult, "tabResult")
        '
        'GridSurveys
        '
        resources.ApplyResources(Me.GridSurveys, "GridSurveys")
        Me.GridSurveys.EmbeddedNavigator.Name = ""
        Me.GridSurveys.FormsUseDefaultLookAndFeel = False
        Me.GridSurveys.MainView = Me.GridViewSurveys
        Me.GridSurveys.Name = "GridSurveys"
        Me.GridSurveys.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEditLanguage, Me.RepositoryItemLookUpEditThemeEvent})
        Me.GridSurveys.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSurveys})
        '
        'GridViewSurveys
        '
        Me.GridViewSurveys.GridControl = Me.GridSurveys
        Me.GridViewSurveys.Name = "GridViewSurveys"
        Me.GridViewSurveys.OptionsView.ShowFooter = True
        '
        'RepositoryItemLookUpEditLanguage
        '
        resources.ApplyResources(Me.RepositoryItemLookUpEditLanguage, "RepositoryItemLookUpEditLanguage")
        Me.RepositoryItemLookUpEditLanguage.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEditLanguage.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemLookUpEditLanguage.Name = "RepositoryItemLookUpEditLanguage"
        '
        'RepositoryItemLookUpEditThemeEvent
        '
        resources.ApplyResources(Me.RepositoryItemLookUpEditThemeEvent, "RepositoryItemLookUpEditThemeEvent")
        Me.RepositoryItemLookUpEditThemeEvent.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEditThemeEvent.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemLookUpEditThemeEvent.Name = "RepositoryItemLookUpEditThemeEvent"
        '
        'colId
        '
        resources.ApplyResources(Me.colId, "colId")
        Me.colId.FieldName = "id"
        Me.colId.Name = "colId"
        Me.colId.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        '
        'colDateAdded
        '
        resources.ApplyResources(Me.colDateAdded, "colDateAdded")
        Me.colDateAdded.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.colDateAdded.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDateAdded.FieldName = "created_at"
        Me.colDateAdded.Name = "colDateAdded"
        '
        'colLastModified
        '
        resources.ApplyResources(Me.colLastModified, "colLastModified")
        Me.colLastModified.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.colLastModified.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colLastModified.FieldName = "updated_at"
        Me.colLastModified.Name = "colLastModified"
        '
        'colKind
        '
        resources.ApplyResources(Me.colKind, "colKind")
        Me.colKind.FieldName = "kind"
        Me.colKind.Name = "colKind"
        '
        'colLanguage
        '
        resources.ApplyResources(Me.colLanguage, "colLanguage")
        Me.colLanguage.ColumnEdit = Me.RepositoryItemLookUpEditLanguage
        Me.colLanguage.FieldName = "language"
        Me.colLanguage.Name = "colLanguage"
        '
        'colthemeEvent
        '
        resources.ApplyResources(Me.colthemeEvent, "colthemeEvent")
        Me.colthemeEvent.ColumnEdit = Me.RepositoryItemLookUpEditThemeEvent
        Me.colthemeEvent.FieldName = "theme_event_id"
        Me.colthemeEvent.Name = "colthemeEvent"
        '
        'colStyle
        '
        resources.ApplyResources(Me.colStyle, "colStyle")
        Me.colStyle.FieldName = "style"
        Me.colStyle.Name = "colStyle"
        '
        'DsSite1
        '
        Me.DsSite1.DataSetName = "DsSite"
        Me.DsSite1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chkSelected
        '
        Me.chkSelected.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.selected", True))
        resources.ApplyResources(Me.chkSelected, "chkSelected")
        Me.chkSelected.Name = "chkSelected"
        Me.chkSelected.Properties.Caption = resources.GetString("chkSelected.Properties.Caption")
        '
        'lblSelected
        '
        resources.ApplyResources(Me.lblSelected, "lblSelected")
        Me.lblSelected.Name = "lblSelected"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.Name = "ContextMenu1"
        resources.ApplyResources(Me.ContextMenu1, "ContextMenu1")
        '
        'XtraTabControlTheme
        '
        resources.ApplyResources(Me.XtraTabControlTheme, "XtraTabControlTheme")
        Me.XtraTabControlTheme.Name = "XtraTabControlTheme"
        Me.XtraTabControlTheme.SelectedTabPage = Me.tabResult
        Me.XtraTabControlTheme.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabSearch, Me.tabResult, Me.tabDetail})
        '
        'tabDetail
        '
        Me.tabDetail.Controls.Add(Me.txtTitleEditEN)
        Me.tabDetail.Controls.Add(Me.lblTitleEditEN)
        Me.tabDetail.Controls.Add(Me.TabPictures)
        Me.tabDetail.Controls.Add(Me.cmbThemeEventEdit)
        Me.tabDetail.Controls.Add(Me.lblThemeEventEdit)
        Me.tabDetail.Controls.Add(Me.cmbKindEdit)
        Me.tabDetail.Controls.Add(Me.lblKindEdit)
        Me.tabDetail.Controls.Add(Me.txtUpdateDate)
        Me.tabDetail.Controls.Add(Me.lblUpdateDate)
        Me.tabDetail.Controls.Add(Me.txtCreateDate)
        Me.tabDetail.Controls.Add(Me.lblDateCreate)
        Me.tabDetail.Controls.Add(Me.txtTitleEditNL)
        Me.tabDetail.Controls.Add(Me.lblTitleEditNL)
        Me.tabDetail.Controls.Add(Me.lblId)
        Me.tabDetail.Controls.Add(Me.btnCancel)
        Me.tabDetail.Controls.Add(Me.btnSaveSurvey)
        Me.tabDetail.Controls.Add(Me.btnEditSurvey)
        Me.tabDetail.Controls.Add(Me.btnNewSurvey_edit)
        Me.tabDetail.Controls.Add(Me.TxtSurveyId_edit)
        Me.tabDetail.Controls.Add(Me.txtTitleEditFR)
        Me.tabDetail.Controls.Add(Me.lblTitleEditFR)
        Me.tabDetail.Name = "tabDetail"
        resources.ApplyResources(Me.tabDetail, "tabDetail")
        '
        'txtTitleEditEN
        '
        Me.txtTitleEditEN.AllowDrop = True
        Me.txtTitleEditEN.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Surveys.title_en", True))
        resources.ApplyResources(Me.txtTitleEditEN, "txtTitleEditEN")
        Me.txtTitleEditEN.Name = "txtTitleEditEN"
        '
        'lblTitleEditEN
        '
        resources.ApplyResources(Me.lblTitleEditEN, "lblTitleEditEN")
        Me.lblTitleEditEN.Name = "lblTitleEditEN"
        '
        'TabPictures
        '
        resources.ApplyResources(Me.TabPictures, "TabPictures")
        Me.TabPictures.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DsSite1, "themes_events.banner_menu", True))
        Me.TabPictures.Name = "TabPictures"
        Me.TabPictures.SelectedTabPage = Me.tabTitle_page
        Me.TabPictures.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabTitle_page})
        '
        'tabTitle_page
        '
        Me.tabTitle_page.Controls.Add(Me.tabControl_TitlePage_image)
        Me.tabTitle_page.Name = "tabTitle_page"
        resources.ApplyResources(Me.tabTitle_page, "tabTitle_page")
        Me.tabTitle_page.Tag = "surveys"
        '
        'tabControl_TitlePage_image
        '
        resources.ApplyResources(Me.tabControl_TitlePage_image, "tabControl_TitlePage_image")
        Me.tabControl_TitlePage_image.Name = "tabControl_TitlePage_image"
        Me.tabControl_TitlePage_image.SelectedTabPage = Me.tabTitlePageFR
        Me.tabControl_TitlePage_image.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabTitlePageFR, Me.tabTitlePageNL, Me.tabTitlePageEN})
        '
        'tabTitlePageFR
        '
        Me.tabTitlePageFR.Controls.Add(Me.image_title_page_FR)
        Me.tabTitlePageFR.Name = "tabTitlePageFR"
        resources.ApplyResources(Me.tabTitlePageFR, "tabTitlePageFR")
        Me.tabTitlePageFR.Tag = "FR"
        '
        'image_title_page_FR
        '
        Me.image_title_page_FR.AllowDrop = True
        resources.ApplyResources(Me.image_title_page_FR, "image_title_page_FR")
        Me.image_title_page_FR.Name = "image_title_page_FR"
        Me.image_title_page_FR.Properties.ReadOnly = True
        Me.image_title_page_FR.Properties.ShowMenu = False
        Me.image_title_page_FR.Tag = "FR"
        '
        'tabTitlePageNL
        '
        Me.tabTitlePageNL.Controls.Add(Me.image_title_page_NL)
        Me.tabTitlePageNL.Name = "tabTitlePageNL"
        resources.ApplyResources(Me.tabTitlePageNL, "tabTitlePageNL")
        Me.tabTitlePageNL.Tag = "NL"
        '
        'image_title_page_NL
        '
        Me.image_title_page_NL.AllowDrop = True
        resources.ApplyResources(Me.image_title_page_NL, "image_title_page_NL")
        Me.image_title_page_NL.Name = "image_title_page_NL"
        Me.image_title_page_NL.Properties.ReadOnly = True
        Me.image_title_page_NL.Properties.ShowMenu = False
        Me.image_title_page_NL.Tag = "NL"
        '
        'tabTitlePageEN
        '
        Me.tabTitlePageEN.Controls.Add(Me.image_title_page_EN)
        Me.tabTitlePageEN.Name = "tabTitlePageEN"
        resources.ApplyResources(Me.tabTitlePageEN, "tabTitlePageEN")
        Me.tabTitlePageEN.Tag = "EN"
        '
        'image_title_page_EN
        '
        Me.image_title_page_EN.AllowDrop = True
        resources.ApplyResources(Me.image_title_page_EN, "image_title_page_EN")
        Me.image_title_page_EN.Name = "image_title_page_EN"
        Me.image_title_page_EN.Properties.ReadOnly = True
        Me.image_title_page_EN.Properties.ShowMenu = False
        Me.image_title_page_EN.Tag = "EN"
        '
        'cmbThemeEventEdit
        '
        Me.cmbThemeEventEdit.AllowDrop = True
        Me.cmbThemeEventEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Surveys.themes_event_id", True))
        resources.ApplyResources(Me.cmbThemeEventEdit, "cmbThemeEventEdit")
        Me.cmbThemeEventEdit.Name = "cmbThemeEventEdit"
        Me.cmbThemeEventEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbThemeEventEdit.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbThemeEventEdit.Properties.NullText = resources.GetString("cmbThemeEventEdit.Properties.NullText")
        '
        'lblThemeEventEdit
        '
        resources.ApplyResources(Me.lblThemeEventEdit, "lblThemeEventEdit")
        Me.lblThemeEventEdit.Name = "lblThemeEventEdit"
        '
        'cmbKindEdit
        '
        Me.cmbKindEdit.AllowDrop = True
        Me.cmbKindEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Surveys.survey_kind_id", True))
        resources.ApplyResources(Me.cmbKindEdit, "cmbKindEdit")
        Me.cmbKindEdit.Name = "cmbKindEdit"
        Me.cmbKindEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbKindEdit.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbKindEdit.Properties.NullText = resources.GetString("cmbKindEdit.Properties.NullText")
        '
        'lblKindEdit
        '
        resources.ApplyResources(Me.lblKindEdit, "lblKindEdit")
        Me.lblKindEdit.Name = "lblKindEdit"
        '
        'txtUpdateDate
        '
        Me.txtUpdateDate.AllowDrop = True
        Me.txtUpdateDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Surveys.updated_at", True))
        resources.ApplyResources(Me.txtUpdateDate, "txtUpdateDate")
        Me.txtUpdateDate.Name = "txtUpdateDate"
        '
        'lblUpdateDate
        '
        resources.ApplyResources(Me.lblUpdateDate, "lblUpdateDate")
        Me.lblUpdateDate.Name = "lblUpdateDate"
        '
        'txtCreateDate
        '
        Me.txtCreateDate.AllowDrop = True
        Me.txtCreateDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Surveys.created_at", True))
        resources.ApplyResources(Me.txtCreateDate, "txtCreateDate")
        Me.txtCreateDate.Name = "txtCreateDate"
        '
        'lblDateCreate
        '
        resources.ApplyResources(Me.lblDateCreate, "lblDateCreate")
        Me.lblDateCreate.Name = "lblDateCreate"
        '
        'txtTitleEditNL
        '
        Me.txtTitleEditNL.AllowDrop = True
        Me.txtTitleEditNL.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Surveys.title_nl", True))
        resources.ApplyResources(Me.txtTitleEditNL, "txtTitleEditNL")
        Me.txtTitleEditNL.Name = "txtTitleEditNL"
        '
        'lblTitleEditNL
        '
        resources.ApplyResources(Me.lblTitleEditNL, "lblTitleEditNL")
        Me.lblTitleEditNL.Name = "lblTitleEditNL"
        '
        'lblId
        '
        resources.ApplyResources(Me.lblId, "lblId")
        Me.lblId.Name = "lblId"
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Name = "btnCancel"
        '
        'btnSaveSurvey
        '
        resources.ApplyResources(Me.btnSaveSurvey, "btnSaveSurvey")
        Me.btnSaveSurvey.Name = "btnSaveSurvey"
        '
        'btnEditSurvey
        '
        resources.ApplyResources(Me.btnEditSurvey, "btnEditSurvey")
        Me.btnEditSurvey.Name = "btnEditSurvey"
        '
        'btnNewSurvey_edit
        '
        resources.ApplyResources(Me.btnNewSurvey_edit, "btnNewSurvey_edit")
        Me.btnNewSurvey_edit.Name = "btnNewSurvey_edit"
        '
        'TxtSurveyId_edit
        '
        Me.TxtSurveyId_edit.AllowDrop = True
        Me.TxtSurveyId_edit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Surveys.id", True))
        resources.ApplyResources(Me.TxtSurveyId_edit, "TxtSurveyId_edit")
        Me.TxtSurveyId_edit.Name = "TxtSurveyId_edit"
        '
        'txtTitleEditFR
        '
        Me.txtTitleEditFR.AllowDrop = True
        Me.txtTitleEditFR.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Surveys.title_fr", True))
        resources.ApplyResources(Me.txtTitleEditFR, "txtTitleEditFR")
        Me.txtTitleEditFR.Name = "txtTitleEditFR"
        '
        'lblTitleEditFR
        '
        resources.ApplyResources(Me.lblTitleEditFR, "lblTitleEditFR")
        Me.lblTitleEditFR.Name = "lblTitleEditFR"
        '
        'OFDPicture
        '
        resources.ApplyResources(Me.OFDPicture, "OFDPicture")
        '
        'frmSurvey
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.XtraTabControlTheme)
        Me.Name = "frmSurvey"
        Me.Controls.SetChildIndex(Me.XtraTabControlTheme, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSearch.ResumeLayout(False)
        CType(Me.GroupSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupSearch.ResumeLayout(False)
        Me.GroupSearch.PerformLayout()
        CType(Me.cmbThemeEvent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSurveyId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabResult.ResumeLayout(False)
        CType(Me.GridSurveys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSurveys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEditLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEditThemeEvent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSite1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControlTheme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControlTheme.ResumeLayout(False)
        Me.tabDetail.ResumeLayout(False)
        Me.tabDetail.PerformLayout()
        CType(Me.txtTitleEditEN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPictures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPictures.ResumeLayout(False)
        Me.tabTitle_page.ResumeLayout(False)
        CType(Me.tabControl_TitlePage_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl_TitlePage_image.ResumeLayout(False)
        Me.tabTitlePageFR.ResumeLayout(False)
        CType(Me.image_title_page_FR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTitlePageNL.ResumeLayout(False)
        CType(Me.image_title_page_NL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTitlePageEN.ResumeLayout(False)
        CType(Me.image_title_page_EN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbThemeEventEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbKindEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUpdateDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreateDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleEditNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSurveyId_edit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleEditFR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
        AddEventCtrl(TabPictures, GetType(DevExpress.XtraEditors.PictureEdit))
    End Sub
    Dim CurrentCodeType As String
    Dim _enableField As Boolean
    Dim _sql As String

    Dim _PathPictureWrite As String
    Dim _PathPictureRead As String
    Const SERVERKEY As String = "SERVERPATH"
    Const LANGKEY As String = "LANG"
    Const THEMEEVENTIDKEY As String = "ID"

    Const PATHLOGO As String = SERVERKEY & "surveys\" & LANGKEY & "\"


    Enum StepForm
        EDIT
        [NEW]
        SAVE
        CANCEL
        INIT
        LOAD
    End Enum

    Private Sub save()
        PlushData.clsConnection.UpdateDataTableInDB(DsSite1.Surveys, _sql)
    End Sub

    Private Sub ChangeStep(ByVal stepCurrent As StepForm)
        Select Case stepCurrent
            Case StepForm.CANCEL
                btnEditSurvey.Enabled = True
                btnSaveSurvey.Enabled = False
                btnNewSurvey_edit.Enabled = True
                btnCancel.Enabled = False

                EnableField(False)

                tabSearch.PageVisible = True
                tabResult.PageVisible = True

            Case StepForm.EDIT
                btnEditSurvey.Enabled = False
                btnSaveSurvey.Enabled = True
                btnNewSurvey_edit.Enabled = False
                btnCancel.Enabled = True

                EnableField(True)

                tabDetail.PageVisible = True
                tabResult.PageVisible = False

            Case StepForm.INIT
                btnEditSurvey.Enabled = False
                btnSaveSurvey.Enabled = False
                btnNewSurvey_edit.Enabled = True
                btnCancel.Enabled = False
                EnableField(False)

                tabResult.PageVisible = False
                tabSearch.PageVisible = True
                tabDetail.PageVisible = False
                XtraTabControlTheme.SelectedTabPage = tabSearch


            Case StepForm.[NEW]
                btnEditSurvey.Enabled = False
                btnSaveSurvey.Enabled = True
                btnNewSurvey_edit.Enabled = False
                btnCancel.Enabled = True
                EnableField(True)
                tabResult.PageVisible = False
                tabDetail.PageVisible = True
                XtraTabControlTheme.SelectedTabPage = tabDetail



            Case StepForm.SAVE
                btnEditSurvey.Enabled = True
                btnSaveSurvey.Enabled = False
                btnNewSurvey_edit.Enabled = True
                btnCancel.Enabled = False
                EnableField(False)
                tabDetail.PageVisible = True
                tabResult.PageVisible = True

            Case StepForm.LOAD
                btnEditSurvey.Enabled = True
                btnSaveSurvey.Enabled = False
                btnNewSurvey_edit.Enabled = True
                btnCancel.Enabled = False
                EnableField(False)

                tabDetail.PageVisible = True
                XtraTabControlTheme.SelectedTabPage = tabDetail

        End Select
    End Sub

    Public Sub this_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        GridViewSurveys.OptionsView.ColumnAutoWidth = False
        GridViewSurveys.OptionsBehavior.Editable = False

        XtraTabControlTheme.SelectedTabPage = tabSearch
        ' Misc_Bar.Visible = True

        Dim menuStrip As New PlushBuziness.contextMenu()
        GridSurveys.ContextMenuStrip = menuStrip

        Dim serverPath As String
        serverPath = PlushBuziness.clsPicture.getPathServerMapping()
        _PathPictureWrite = PATHLOGO.Replace(SERVERKEY, serverPath)

        ' serverPath = DVDPostBuziness.clsPicture.getPathServer()
        _PathPictureRead = PATHLOGO.Replace(SERVERKEY, serverPath)

        loadKind()
        loadThemeEvent()
        DsSite1.Surveys.created_atColumn.DefaultValue = DateTime.Now
        search()
        ChangeStep(StepForm.INIT)


    End Sub

    Private Sub loadKind()
        Dim dtSurveyKind As DataTable
        Dim dtSurveyKindEdit As DataTable
        Dim key As String = "id"
        Dim value As String = "name"

        Dim sql As String

        sql = PlushData.clsSurveys.GetSurveysKind()

        dtSurveyKind = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtSurveyKind)

        cmbKind.Properties.ValueMember = key
        cmbKind.Properties.DisplayMember = value
        cmbKind.Properties.DataSource = dtSurveyKind

        dtSurveyKindEdit = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtSurveyKindEdit)
        cmbKindEdit.Properties.ValueMember = key
        cmbKindEdit.Properties.DisplayMember = value
        cmbKindEdit.Properties.DataSource = dtSurveyKindEdit

    End Sub
    Private Sub loadThemeEvent()
        Dim dtThemeEvent As DataTable
        Dim dtThemeEventEdit As DataTable
        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "name"

        sql = PlushData.clsThemeEvent.GetThemeEventValue()
        dtThemeEvent = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtThemeEvent)


        cmbThemeEvent.Properties.ValueMember = key
        cmbThemeEvent.Properties.DisplayMember = value
        cmbThemeEvent.Properties.DataSource = dtThemeEvent

        dtThemeEventEdit = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtThemeEventEdit)

        cmbThemeEventEdit.Properties.ValueMember = key
        cmbThemeEventEdit.Properties.DisplayMember = value
        cmbThemeEventEdit.Properties.DataSource = dtThemeEventEdit

        RepositoryItemLookUpEditThemeEvent.ValueMember = key
        RepositoryItemLookUpEditThemeEvent.DisplayMember = value
        RepositoryItemLookUpEditThemeEvent.DataSource = dtThemeEvent
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        search()

        tabDetail.PageVisible = False
        tabResult.PageVisible = True
        XtraTabControlTheme.SelectedTabPage = tabResult
    End Sub

    Public Sub search()

        Dim id As Object
        Dim title As Object
        Dim kind_id As Object
        Dim theme_event_id As Object


        id = TxtSurveyId.EditValue
        title = txtTitle.EditValue
        kind_id = cmbKind.EditValue
        theme_event_id = cmbThemeEvent.EditValue

        DsSite1.Surveys.Clear()
        _sql = PlushData.clsSurveys.GetSearchSurvey(id, title, kind_id, theme_event_id)
        PlushData.clsConnection.FillDataSet(DsSite1.Surveys, _sql, )
        GridSurveys.DataSource = DsSite1.Surveys


    End Sub

    Private Sub initForm()
        Dim blank As String = String.Empty
        txtTitleEditFR.EditValue = blank
        txtTitleEditNL.EditValue = blank

        cmbThemeEventEdit.EditValue = blank
        cmbKindEdit.ItemIndex = 1



    End Sub
    Private Sub loadformEdit()
        loadInfo()
        ChangeStep(StepForm.LOAD)
        refreshAllPictures(TabPictures)
    End Sub

    Private Sub GridThemeEvent_doubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadformEdit()
        ChangeStep(StepForm.LOAD)
    End Sub

    Private Sub loadInfo()
        Dim currentRow As DataRow

        If GridViewSurveys.RowCount > 0 Then
            currentRow = GridViewSurveys.GetDataRow(GridViewSurveys.FocusedRowHandle())
            Dim index As Integer = DsSite1.Surveys.Rows.IndexOf(currentRow)
            Me.BindingContext(DsSite1, DsSite1.Surveys.TableName).Position = index
            XtraTabControlTheme.SelectedTabPage = tabDetail
        End If
    End Sub

    Private Sub insertData()

        Dim dr As DsSite.SurveysRow
        dr = DsSite1.Surveys.NewRow()
        dr.id = PlushBuziness.ClsSurveys.GetLastId()
        DsSite1.Surveys.AddSurveysRow(dr)
        Me.BindingContext(DsSite1, DsSite1.Surveys.TableName).Position = DsSite1.Surveys.Rows.Count - 1

    End Sub

    Private Function EnableField(ByVal ok As Boolean) As Boolean
        Dim enable As Boolean
        enable = ok

        txtTitleEditFR.Enabled = enable
        txtTitleEditNL.Enabled = enable
        txtTitleEditEN.Enabled = enable

        TabPictures.Enabled = enable
        cmbThemeEventEdit.Enabled = enable
        cmbKindEdit.Enabled = enable


        Return ok
    End Function

    Private Sub btnEditSurvey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditSurvey.Click
        ChangeStep(StepForm.EDIT)

    End Sub

    Private Sub btnNewSurvey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewSurvey.Click, btnNewSurvey_edit.Click

        insertData()
        initForm()
        ChangeStep(StepForm.[NEW])
    End Sub

    Private Sub btnSaveSurvey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSurvey.Click

        Dim drv As DataRowView
        Dim dr As DsSite.SurveysRow
        drv = Me.BindingContext(DsSite1, DsSite1.Surveys.TableName).Current
        dr = drv.Row
        dr.updated_at = DateTime.Now
        Me.BindingContext(DsSite1, DsSite1.Surveys.TableName).EndCurrentEdit()
        PlushData.clsConnection.UpdateDataTableInDB(DsSite1.Surveys, _sql)
        ChangeStep(StepForm.SAVE)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(DsSite1, DsSite1.Surveys.TableName).EndCurrentEdit()
        Me.BindingContext(DsSite1, DsSite1.Surveys.TableName).CancelCurrentEdit()
        DsSite1.Surveys.Rows.RemoveAt(DsSite1.Surveys.Rows.Count - 1)
        ChangeStep(StepForm.CANCEL)

    End Sub

    Private Sub GridSurveys_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridSurveys.DoubleClick
        loadformEdit()
        ChangeStep(StepForm.LOAD)
        'loadInfo()
        'ChangeStep(StepForm.LOAD)

    End Sub

#Region "Picture Tab"

    ''' <summary>
    ''' sub recursive pour mettre a jour ts les controls d'un type
    ''' </summary>
    ''' <param name="ctrl"></param>
    ''' <param name="typectrl"></param>
    ''' <remarks></remarks>
    Private Sub AddEventCtrl(ByVal ctrl As Windows.Forms.Control, ByVal typectrl As Type)
        Dim index As Integer = 0
        While index < ctrl.Controls.Count
            If ctrl.Controls(index).GetType() Is typectrl Then
                AddHandler ctrl.Controls(index).DoubleClick, AddressOf Image_DoubleClick
            Else
                AddEventCtrl(ctrl.Controls(index), typectrl)
            End If

            index += 1
        End While


    End Sub

    ''' <summary>
    ''' sub recursive pour mettre a jour ts les controls d'un type
    ''' </summary>
    ''' <param name="ctrl"></param>
    ''' <param name="typectrl"></param>
    ''' <param name="enabled"></param>
    ''' <remarks></remarks>
    Private Sub SearchAllCtrl(ByVal ctrl As Windows.Forms.Control, ByVal typectrl As Type, ByVal enabled As Boolean)
        Dim index As Integer = 0
        While index < ctrl.Controls.Count
            If ctrl.Controls(index).GetType() Is typectrl Then
                ctrl.Controls(index).Enabled = enabled
            Else
                SearchAllCtrl(ctrl.Controls(index), typectrl, enabled)
            End If

            index += 1
        End While


    End Sub

    Private Function SearchCtrl(ByVal ctrl As Windows.Forms.Control, ByVal typectrl As Type) As Object
        Dim index As Integer = 0
        While index < ctrl.Controls.Count
            If ctrl.Controls(index).GetType() Is typectrl Then
                Return ctrl.Controls(index)
            End If

            index += 1
        End While

        Return Nothing
    End Function

    Private Function SearchTabControlCtrl(ByVal tab As DevExpress.XtraTab.XtraTabPage) As DevExpress.XtraTab.XtraTabControl
        Return SearchCtrl(tab, GetType(DevExpress.XtraTab.XtraTabControl))
    End Function

    Private Function SearchImageCtrl(ByVal tab As DevExpress.XtraTab.XtraTabPage) As DevExpress.XtraEditors.PictureEdit
        Return SearchCtrl(tab, GetType(DevExpress.XtraEditors.PictureEdit))
    End Function

    Private Sub RefreshPictureTab(ByVal tabControl As DevExpress.XtraTab.XtraTabControl)
        Dim type As PlushBuziness.clsPicture.TypePicture
        Dim lang As String
        Dim img As DevExpress.XtraEditors.PictureEdit

        type = PlushBuziness.clsPicture.ConvertStringToEnum(tabControl.Parent.Tag)
        For Each tab As DevExpress.XtraTab.XtraTabPage In tabControl.TabPages
            img = SearchImageCtrl(tab)
            If Not img Is Nothing Then
                lang = tab.Tag
                RefreshPicture(img, TxtSurveyId_edit.EditValue, type)
            End If
        Next


    End Sub

    Private Sub RefreshTypePictures(ByVal tab As DevExpress.XtraTab.XtraTabPage)

        Dim chk As DevExpress.XtraEditors.CheckEdit
        Dim tabLang As DevExpress.XtraTab.XtraTabControl
        chk = SearchCtrl(tab, GetType(DevExpress.XtraEditors.CheckEdit))
        tabLang = SearchCtrl(tab, GetType(DevExpress.XtraTab.XtraTabControl))
        If Not tabLang Is Nothing Then
            '  If Not chk Is Nothing AndAlso chk.Checked Then
            RefreshPictureTab(tabLang)
            tabLang.Visible = True
            'Else
            '     tabLang.Visible = False
            '  End If
        End If

    End Sub
    Private Sub refreshAllPictures(ByVal tabControl As DevExpress.XtraTab.XtraTabControl)

        For Each tab As DevExpress.XtraTab.XtraTabPage In tabControl.TabPages
            RefreshTypePictures(tab)
        Next


    End Sub

    Private Function GetFullPathPicture(ByVal Lang As String, ByVal themeEventId As Integer, ByVal tp_picture As PlushBuziness.clsPicture.TypePicture, ByVal FullpathPicture As String) As FileInfo

        Dim pathPicture As String
        Dim TmpnameFilePicture As String
        pathPicture = FullpathPicture

        pathPicture = pathPicture.Replace(LANGKEY, Lang)
        TmpnameFilePicture = themeEventId
        TmpnameFilePicture += PlushBuziness.clsPicture.GetExtension(tp_picture)
        Dim file As FileInfo = New FileInfo(pathPicture & "\" & TmpnameFilePicture)
        Return file

    End Function
    Private Function thumbnailCallback() As Boolean
        Return False
    End Function

    Private Sub RefreshPicture(ByVal img As DevExpress.XtraEditors.PictureEdit, ByVal SurveyId As Integer, ByVal tp_picture As PlushBuziness.clsPicture.TypePicture)

        Dim filePicture As FileInfo

        filePicture = GetFullPathPicture(img.Tag, SurveyId, tp_picture, _PathPictureRead)

        If System.IO.File.Exists(filePicture.FullName) Then

            Dim myCallback As New Drawing.Image.GetThumbnailImageAbort(AddressOf thumbnailCallback)

            Using temp As System.Drawing.Image = System.Drawing.Image.FromFile(filePicture.FullName)
                img.Image = New System.Drawing.Bitmap(temp)
            End Using
            'this method used for reduce picture if too large 
            img.Image = img.Image.GetThumbnailImage(img.Width, img.Height, myCallback, IntPtr.Zero)
        Else
            img.Image = Nothing
        End If
    End Sub

    Private Function AddPicture(ByVal tp_picture As PlushBuziness.clsPicture.TypePicture, ByVal lang As String) As Boolean


        Dim FilePictureDestination As FileInfo
        Dim pathPictureSource As String
        Dim extension As String
        extension = PlushBuziness.clsPicture.GetExtension(tp_picture)
        OFDPicture.Filter = extension & "|*" & extension
        FilePictureDestination = GetFullPathPicture(lang, TxtSurveyId_edit.EditValue, tp_picture, _PathPictureWrite)
        If OFDPicture.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pathPictureSource = OFDPicture.FileName
            If Not Directory.Exists(FilePictureDestination.DirectoryName) Then
                Directory.CreateDirectory(FilePictureDestination.DirectoryName)
            End If
            File.Copy(pathPictureSource, FilePictureDestination.FullName, True)
            Return True
        End If

        Return False
    End Function



    Private Sub Image_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim img As DevExpress.XtraEditors.PictureEdit
        Dim tabType As DevExpress.XtraTab.XtraTabPage
        Dim tabLang As DevExpress.XtraTab.XtraTabPage
        Dim tp_picture As PlushBuziness.clsPicture.TypePicture
        img = sender
        tabLang = img.Parent
        tabType = tabLang.Parent.Parent
        tp_picture = PlushBuziness.clsPicture.ConvertStringToEnum(tabType.Tag)

        If AddPicture(tp_picture, tabLang.Tag) Then
            RefreshTypePictures(tabType)
        End If

    End Sub

#End Region
End Class



