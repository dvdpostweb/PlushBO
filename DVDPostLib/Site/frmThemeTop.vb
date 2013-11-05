Imports System.IO
Imports System.Collections.Generic
Public Class frmThemeTop
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
    Friend WithEvents XtraTabControlTheme As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabResult As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabDetail As DevExpress.XtraTab.XtraTabPage

    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupSearch As DevExpress.XtraEditors.GroupControl

    Friend WithEvents lblEventThemeId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnNewTheme As DevExpress.XtraEditors.SimpleButton

    Friend WithEvents lblSelected As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkSelected As DevExpress.XtraEditors.CheckEdit

    Friend WithEvents ContextMenu1 As PlushBuziness.contextMenu
    Friend WithEvents DsSite1 As PlushLib.DsSite
    Friend WithEvents GridThemeTop As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewThemeTop As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveTheme As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditTheme As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNewTheme_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtEventThemeId_edit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTitleEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitleEdit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbKind As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblKind As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbThemeEvent As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblThemeEvent As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDescription As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblHomePage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkStatus As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbThemeEventEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblThemeEventEdit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbKindEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblKindEdit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUpdateDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblUpdateDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCreateDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDateCreate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbStyle As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblStyle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbLanguage As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblLanguage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemChkStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colDateAdded As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastModified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEditLanguage As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEditThemeEvent As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colKind As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLanguage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colthemeEvent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkHomepage As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbChannelEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblChannel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colChannel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbChannel As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblChannelSearch As DevExpress.XtraEditors.LabelControl




    Friend WithEvents TxtEventThemeId As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemeTop))
        Me.tabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.GroupSearch = New DevExpress.XtraEditors.GroupControl
        Me.cmbThemeEvent = New DevExpress.XtraEditors.LookUpEdit
        Me.lblThemeEvent = New DevExpress.XtraEditors.LabelControl
        Me.cmbKind = New DevExpress.XtraEditors.LookUpEdit
        Me.lblKind = New DevExpress.XtraEditors.LabelControl
        Me.TxtEventThemeId = New DevExpress.XtraEditors.TextEdit
        Me.btnNewTheme = New DevExpress.XtraEditors.SimpleButton
        Me.lblEventThemeId = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit
        Me.tabResult = New DevExpress.XtraTab.XtraTabPage
        Me.GridThemeTop = New DevExpress.XtraGrid.GridControl
        Me.GridViewThemeTop = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemChkStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colDateAdded = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLastModified = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKind = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLanguage = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEditLanguage = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colthemeEvent = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEditThemeEvent = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colStyle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colChannel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DsSite1 = New PlushLib.DsSite
        Me.chkSelected = New DevExpress.XtraEditors.CheckEdit
        Me.lblSelected = New DevExpress.XtraEditors.LabelControl
        Me.ContextMenu1 = New PlushBuziness.contextMenu
        Me.XtraTabControlTheme = New DevExpress.XtraTab.XtraTabControl
        Me.tabDetail = New DevExpress.XtraTab.XtraTabPage
        Me.cmbChannelEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.lblChannel = New DevExpress.XtraEditors.LabelControl
        Me.chkHomepage = New DevExpress.XtraEditors.CheckEdit
        Me.cmbStyle = New DevExpress.XtraEditors.LookUpEdit
        Me.lblStyle = New DevExpress.XtraEditors.LabelControl
        Me.cmbLanguage = New DevExpress.XtraEditors.LookUpEdit
        Me.lblLanguage = New DevExpress.XtraEditors.LabelControl
        Me.cmbThemeEventEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.lblThemeEventEdit = New DevExpress.XtraEditors.LabelControl
        Me.cmbKindEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.lblKindEdit = New DevExpress.XtraEditors.LabelControl
        Me.txtUpdateDate = New DevExpress.XtraEditors.TextEdit
        Me.lblUpdateDate = New DevExpress.XtraEditors.LabelControl
        Me.txtCreateDate = New DevExpress.XtraEditors.TextEdit
        Me.lblDateCreate = New DevExpress.XtraEditors.LabelControl
        Me.chkStatus = New DevExpress.XtraEditors.CheckEdit
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl
        Me.lblHomePage = New DevExpress.XtraEditors.LabelControl
        Me.TxtDescription = New DevExpress.XtraEditors.TextEdit
        Me.lblDescription = New DevExpress.XtraEditors.LabelControl
        Me.lblId = New DevExpress.XtraEditors.LabelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSaveTheme = New DevExpress.XtraEditors.SimpleButton
        Me.btnEditTheme = New DevExpress.XtraEditors.SimpleButton
        Me.btnNewTheme_edit = New DevExpress.XtraEditors.SimpleButton
        Me.TxtEventThemeId_edit = New DevExpress.XtraEditors.TextEdit
        Me.txtTitleEdit = New DevExpress.XtraEditors.TextEdit
        Me.lblTitleEdit = New DevExpress.XtraEditors.LabelControl
        Me.cmbChannel = New DevExpress.XtraEditors.LookUpEdit
        Me.lblChannelSearch = New DevExpress.XtraEditors.LabelControl
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
        CType(Me.TxtEventThemeId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabResult.SuspendLayout()
        CType(Me.GridThemeTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewThemeTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemChkStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEditLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEditThemeEvent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSite1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControlTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControlTheme.SuspendLayout()
        Me.tabDetail.SuspendLayout()
        CType(Me.cmbChannelEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkHomepage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbThemeEventEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbKindEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUpdateDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreateDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEventThemeId_edit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbChannel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupSearch.Controls.Add(Me.cmbChannel)
        Me.GroupSearch.Controls.Add(Me.lblChannelSearch)
        Me.GroupSearch.Controls.Add(Me.cmbThemeEvent)
        Me.GroupSearch.Controls.Add(Me.lblThemeEvent)
        Me.GroupSearch.Controls.Add(Me.cmbKind)
        Me.GroupSearch.Controls.Add(Me.lblKind)
        Me.GroupSearch.Controls.Add(Me.TxtEventThemeId)
        Me.GroupSearch.Controls.Add(Me.btnNewTheme)
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
        Me.cmbKind.Properties.NullText = resources.GetString("cmbKind.Properties.NullText")
        '
        'lblKind
        '
        resources.ApplyResources(Me.lblKind, "lblKind")
        Me.lblKind.Name = "lblKind"
        '
        'TxtEventThemeId
        '
        resources.ApplyResources(Me.TxtEventThemeId, "TxtEventThemeId")
        Me.TxtEventThemeId.Name = "TxtEventThemeId"
        Me.TxtEventThemeId.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtEventThemeId.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'btnNewTheme
        '
        resources.ApplyResources(Me.btnNewTheme, "btnNewTheme")
        Me.btnNewTheme.Name = "btnNewTheme"
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
        Me.tabResult.Controls.Add(Me.GridThemeTop)
        Me.tabResult.Name = "tabResult"
        resources.ApplyResources(Me.tabResult, "tabResult")
        '
        'GridThemeTop
        '
        resources.ApplyResources(Me.GridThemeTop, "GridThemeTop")
        Me.GridThemeTop.EmbeddedNavigator.Name = ""
        Me.GridThemeTop.FormsUseDefaultLookAndFeel = False
        Me.GridThemeTop.MainView = Me.GridViewThemeTop
        Me.GridThemeTop.Name = "GridThemeTop"
        Me.GridThemeTop.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemChkStatus, Me.RepositoryItemLookUpEditLanguage, Me.RepositoryItemLookUpEditThemeEvent})
        Me.GridThemeTop.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewThemeTop})
        '
        'GridViewThemeTop
        '
        Me.GridViewThemeTop.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colName, Me.colStatus, Me.colDateAdded, Me.colLastModified, Me.colKind, Me.colLanguage, Me.colthemeEvent, Me.colStyle, Me.colChannel})
        Me.GridViewThemeTop.GridControl = Me.GridThemeTop
        Me.GridViewThemeTop.Name = "GridViewThemeTop"
        Me.GridViewThemeTop.OptionsView.ShowFooter = True
        '
        'colId
        '
        resources.ApplyResources(Me.colId, "colId")
        Me.colId.FieldName = "id"
        Me.colId.Name = "colId"
        Me.colId.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        '
        'colName
        '
        resources.ApplyResources(Me.colName, "colName")
        Me.colName.FieldName = "name"
        Me.colName.Name = "colName"
        '
        'colStatus
        '
        resources.ApplyResources(Me.colStatus, "colStatus")
        Me.colStatus.ColumnEdit = Me.RepositoryItemChkStatus
        Me.colStatus.FieldName = "status"
        Me.colStatus.Name = "colStatus"
        '
        'RepositoryItemChkStatus
        '
        resources.ApplyResources(Me.RepositoryItemChkStatus, "RepositoryItemChkStatus")
        Me.RepositoryItemChkStatus.Name = "RepositoryItemChkStatus"
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
        'RepositoryItemLookUpEditLanguage
        '
        resources.ApplyResources(Me.RepositoryItemLookUpEditLanguage, "RepositoryItemLookUpEditLanguage")
        Me.RepositoryItemLookUpEditLanguage.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEditLanguage.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemLookUpEditLanguage.Name = "RepositoryItemLookUpEditLanguage"
        '
        'colthemeEvent
        '
        resources.ApplyResources(Me.colthemeEvent, "colthemeEvent")
        Me.colthemeEvent.ColumnEdit = Me.RepositoryItemLookUpEditThemeEvent
        Me.colthemeEvent.FieldName = "theme_event_id"
        Me.colthemeEvent.Name = "colthemeEvent"
        '
        'RepositoryItemLookUpEditThemeEvent
        '
        resources.ApplyResources(Me.RepositoryItemLookUpEditThemeEvent, "RepositoryItemLookUpEditThemeEvent")
        Me.RepositoryItemLookUpEditThemeEvent.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEditThemeEvent.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemLookUpEditThemeEvent.Name = "RepositoryItemLookUpEditThemeEvent"
        '
        'colStyle
        '
        resources.ApplyResources(Me.colStyle, "colStyle")
        Me.colStyle.FieldName = "style"
        Me.colStyle.Name = "colStyle"
        '
        'colChannel
        '
        resources.ApplyResources(Me.colChannel, "colChannel")
        Me.colChannel.FieldName = "channel"
        Me.colChannel.Name = "colChannel"
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
        Me.tabDetail.Controls.Add(Me.cmbChannelEdit)
        Me.tabDetail.Controls.Add(Me.lblChannel)
        Me.tabDetail.Controls.Add(Me.chkHomepage)
        Me.tabDetail.Controls.Add(Me.cmbStyle)
        Me.tabDetail.Controls.Add(Me.lblStyle)
        Me.tabDetail.Controls.Add(Me.cmbLanguage)
        Me.tabDetail.Controls.Add(Me.lblLanguage)
        Me.tabDetail.Controls.Add(Me.cmbThemeEventEdit)
        Me.tabDetail.Controls.Add(Me.lblThemeEventEdit)
        Me.tabDetail.Controls.Add(Me.cmbKindEdit)
        Me.tabDetail.Controls.Add(Me.lblKindEdit)
        Me.tabDetail.Controls.Add(Me.txtUpdateDate)
        Me.tabDetail.Controls.Add(Me.lblUpdateDate)
        Me.tabDetail.Controls.Add(Me.txtCreateDate)
        Me.tabDetail.Controls.Add(Me.lblDateCreate)
        Me.tabDetail.Controls.Add(Me.chkStatus)
        Me.tabDetail.Controls.Add(Me.lblStatus)
        Me.tabDetail.Controls.Add(Me.lblHomePage)
        Me.tabDetail.Controls.Add(Me.TxtDescription)
        Me.tabDetail.Controls.Add(Me.lblDescription)
        Me.tabDetail.Controls.Add(Me.lblId)
        Me.tabDetail.Controls.Add(Me.btnCancel)
        Me.tabDetail.Controls.Add(Me.btnSaveTheme)
        Me.tabDetail.Controls.Add(Me.btnEditTheme)
        Me.tabDetail.Controls.Add(Me.btnNewTheme_edit)
        Me.tabDetail.Controls.Add(Me.TxtEventThemeId_edit)
        Me.tabDetail.Controls.Add(Me.txtTitleEdit)
        Me.tabDetail.Controls.Add(Me.lblTitleEdit)
        Me.tabDetail.Name = "tabDetail"
        resources.ApplyResources(Me.tabDetail, "tabDetail")
        '
        'cmbChannelEdit
        '
        Me.cmbChannelEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "product_lists.channel", True))
        resources.ApplyResources(Me.cmbChannelEdit, "cmbChannelEdit")
        Me.cmbChannelEdit.Name = "cmbChannelEdit"
        Me.cmbChannelEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbChannelEdit.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbChannelEdit.Properties.DisplayMember = "status_desc"
        Me.cmbChannelEdit.Properties.NullText = resources.GetString("cmbChannelEdit.Properties.NullText")
        Me.cmbChannelEdit.Properties.ValueMember = "status_id"
        '
        'lblChannel
        '
        resources.ApplyResources(Me.lblChannel, "lblChannel")
        Me.lblChannel.Name = "lblChannel"
        '
        'chkHomepage
        '
        Me.chkHomepage.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "product_lists.status", True))
        resources.ApplyResources(Me.chkHomepage, "chkHomepage")
        Me.chkHomepage.Name = "chkHomepage"
        Me.chkHomepage.Properties.Caption = resources.GetString("chkHomepage.Properties.Caption")
        '
        'cmbStyle
        '
        Me.cmbStyle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "product_lists.style", True))
        resources.ApplyResources(Me.cmbStyle, "cmbStyle")
        Me.cmbStyle.Name = "cmbStyle"
        Me.cmbStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbStyle.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbStyle.Properties.DisplayMember = "status_desc"
        Me.cmbStyle.Properties.NullText = resources.GetString("cmbStyle.Properties.NullText")
        Me.cmbStyle.Properties.ValueMember = "status_id"
        '
        'lblStyle
        '
        resources.ApplyResources(Me.lblStyle, "lblStyle")
        Me.lblStyle.Name = "lblStyle"
        '
        'cmbLanguage
        '
        Me.cmbLanguage.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "product_lists.language", True))
        resources.ApplyResources(Me.cmbLanguage, "cmbLanguage")
        Me.cmbLanguage.Name = "cmbLanguage"
        Me.cmbLanguage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbLanguage.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbLanguage.Properties.DisplayMember = "status_desc"
        Me.cmbLanguage.Properties.NullText = resources.GetString("cmbLanguage.Properties.NullText")
        Me.cmbLanguage.Properties.ValueMember = "status_id"
        '
        'lblLanguage
        '
        resources.ApplyResources(Me.lblLanguage, "lblLanguage")
        Me.lblLanguage.Name = "lblLanguage"
        '
        'cmbThemeEventEdit
        '
        Me.cmbThemeEventEdit.AllowDrop = True
        Me.cmbThemeEventEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "product_lists.theme_event_id", True))
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
        Me.cmbKindEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "product_lists.kind", True))
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
        Me.txtUpdateDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "product_lists.updated_at", True))
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
        Me.txtCreateDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "product_lists.created_at", True))
        resources.ApplyResources(Me.txtCreateDate, "txtCreateDate")
        Me.txtCreateDate.Name = "txtCreateDate"
        '
        'lblDateCreate
        '
        resources.ApplyResources(Me.lblDateCreate, "lblDateCreate")
        Me.lblDateCreate.Name = "lblDateCreate"
        '
        'chkStatus
        '
        Me.chkStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "product_lists.status", True))
        resources.ApplyResources(Me.chkStatus, "chkStatus")
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Properties.Caption = resources.GetString("chkStatus.Properties.Caption")
        '
        'lblStatus
        '
        resources.ApplyResources(Me.lblStatus, "lblStatus")
        Me.lblStatus.Name = "lblStatus"
        '
        'lblHomePage
        '
        resources.ApplyResources(Me.lblHomePage, "lblHomePage")
        Me.lblHomePage.Name = "lblHomePage"
        '
        'TxtDescription
        '
        Me.TxtDescription.AllowDrop = True
        Me.TxtDescription.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "product_lists.description", True))
        resources.ApplyResources(Me.TxtDescription, "TxtDescription")
        Me.TxtDescription.Name = "TxtDescription"
        '
        'lblDescription
        '
        resources.ApplyResources(Me.lblDescription, "lblDescription")
        Me.lblDescription.Name = "lblDescription"
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
        'btnSaveTheme
        '
        resources.ApplyResources(Me.btnSaveTheme, "btnSaveTheme")
        Me.btnSaveTheme.Name = "btnSaveTheme"
        '
        'btnEditTheme
        '
        resources.ApplyResources(Me.btnEditTheme, "btnEditTheme")
        Me.btnEditTheme.Name = "btnEditTheme"
        '
        'btnNewTheme_edit
        '
        resources.ApplyResources(Me.btnNewTheme_edit, "btnNewTheme_edit")
        Me.btnNewTheme_edit.Name = "btnNewTheme_edit"
        '
        'TxtEventThemeId_edit
        '
        Me.TxtEventThemeId_edit.AllowDrop = True
        Me.TxtEventThemeId_edit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "product_lists.id", True))
        resources.ApplyResources(Me.TxtEventThemeId_edit, "TxtEventThemeId_edit")
        Me.TxtEventThemeId_edit.Name = "TxtEventThemeId_edit"
        '
        'txtTitleEdit
        '
        Me.txtTitleEdit.AllowDrop = True
        Me.txtTitleEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "product_lists.name", True))
        resources.ApplyResources(Me.txtTitleEdit, "txtTitleEdit")
        Me.txtTitleEdit.Name = "txtTitleEdit"
        '
        'lblTitleEdit
        '
        resources.ApplyResources(Me.lblTitleEdit, "lblTitleEdit")
        Me.lblTitleEdit.Name = "lblTitleEdit"
        '
        'cmbChannel
        '
        resources.ApplyResources(Me.cmbChannel, "cmbChannel")
        Me.cmbChannel.Name = "cmbChannel"
        Me.cmbChannel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbChannel.Properties.NullText = resources.GetString("LookUpEdit1.Properties.NullText")
        '
        'lblChannelSearch
        '
        resources.ApplyResources(Me.lblChannelSearch, "lblChannelSearch")
        Me.lblChannelSearch.Name = "lblChannelSearch"
        '
        'frmThemeTop
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.XtraTabControlTheme)
        Me.Name = "frmThemeTop"
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
        CType(Me.TxtEventThemeId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabResult.ResumeLayout(False)
        CType(Me.GridThemeTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewThemeTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemChkStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEditLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEditThemeEvent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSite1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControlTheme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControlTheme.ResumeLayout(False)
        Me.tabDetail.ResumeLayout(False)
        Me.tabDetail.PerformLayout()
        CType(Me.cmbChannelEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkHomepage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbThemeEventEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbKindEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUpdateDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreateDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEventThemeId_edit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbChannel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim CurrentCodeType As String
    Dim _enableField As Boolean
    Dim _sql As String

    Enum StepForm
        EDIT
        [NEW]
        SAVE
        CANCEL
        INIT
        LOAD
    End Enum

    Private Sub save()
        PlushData.clsConnection.UpdateDataTableInDB(DsSite1.product_lists, _sql)
    End Sub

    Private Sub ChangeStep(ByVal stepCurrent As StepForm)
        Select Case stepCurrent
            Case StepForm.CANCEL
                btnEditTheme.Enabled = True
                btnSaveTheme.Enabled = False
                btnNewTheme_edit.Enabled = True
                btnCancel.Enabled = False

                EnableField(False)

                tabSearch.PageVisible = True
                tabResult.PageVisible = True

            Case StepForm.EDIT
                btnEditTheme.Enabled = False
                btnSaveTheme.Enabled = True
                btnNewTheme_edit.Enabled = False
                btnCancel.Enabled = True

                EnableField(True)

                tabDetail.PageVisible = True
                tabResult.PageVisible = False

            Case StepForm.INIT
                btnEditTheme.Enabled = False
                btnSaveTheme.Enabled = False
                btnNewTheme_edit.Enabled = True
                btnCancel.Enabled = False
                EnableField(False)

                tabResult.PageVisible = False
                tabSearch.PageVisible = True
                tabDetail.PageVisible = False
                XtraTabControlTheme.SelectedTabPage = tabSearch


            Case StepForm.[NEW]
                btnEditTheme.Enabled = False
                btnSaveTheme.Enabled = True
                btnNewTheme_edit.Enabled = False
                btnCancel.Enabled = True
                EnableField(True)
                tabResult.PageVisible = False
                tabDetail.PageVisible = True
                XtraTabControlTheme.SelectedTabPage = tabDetail



            Case StepForm.SAVE
                btnEditTheme.Enabled = True
                btnSaveTheme.Enabled = False
                btnNewTheme_edit.Enabled = True
                btnCancel.Enabled = False
                EnableField(False)
                tabDetail.PageVisible = True
                tabResult.PageVisible = True

            Case StepForm.LOAD
                btnEditTheme.Enabled = True
                btnSaveTheme.Enabled = False
                btnNewTheme_edit.Enabled = True
                btnCancel.Enabled = False
                EnableField(False)

                tabDetail.PageVisible = True
                XtraTabControlTheme.SelectedTabPage = tabDetail

        End Select
    End Sub

    Public Sub this_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        GridViewThemeTop.OptionsView.ColumnAutoWidth = False
        GridViewThemeTop.OptionsBehavior.Editable = False

        XtraTabControlTheme.SelectedTabPage = tabSearch
        ' Misc_Bar.Visible = True

        Dim menuStrip As New PlushBuziness.contextMenu()
        GridThemeTop.ContextMenuStrip = menuStrip
        loadThemeEvent()
        loadKind()
        loadLanguage()
        loadStyle()
        loadChannel()
        search()
        ChangeStep(StepForm.INIT)


    End Sub

    Private Sub loadLanguage()
        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "code"
        Dim dtLanguage As DataTable

        sql = PlushData.ClsVod.GetLanguage()
        dtLanguage = PlushData.clsConnection.FillDataSet(sql)

        cmbLanguage.Properties.ValueMember = key
        cmbLanguage.Properties.DisplayMember = value
        cmbLanguage.Properties.DataSource = dtLanguage

        RepositoryItemLookUpEditLanguage.ValueMember = key
        RepositoryItemLookUpEditLanguage.DisplayMember = value
        RepositoryItemLookUpEditLanguage.DataSource = dtLanguage

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
    Private Sub loadStyle()
        Dim lstStyle As List(Of PlushBuziness.clsKeyComboEnum)
        Dim sql As String

        sql = PlushData.clsThemeTop.GetEnumMysqlStyle()
        lstStyle = PlushBuziness.ClsCombo.GetListEnum(sql)

        cmbStyle.Properties.ValueMember = "Value"
        cmbStyle.Properties.DisplayMember = "DisplayMember"
        cmbStyle.Properties.DataSource = lstStyle

    End Sub
    Private Sub loadKind()
        Dim lstKind As List(Of PlushBuziness.clsKeyComboEnum)
        Dim lstKindEdit As List(Of PlushBuziness.clsKeyComboEnum)
        Dim sql As String

        sql = PlushData.clsThemeTop.GetEnumMysqlKind()
        lstKind = PlushBuziness.ClsCombo.GetListEnum(sql)

        lstKind.Add(New PlushBuziness.clsKeyComboEnum("", ""))
        cmbKind.Properties.ValueMember = "Value"
        cmbKind.Properties.DisplayMember = "DisplayMember"
        cmbKind.Properties.DataSource = lstKind

        lstKindEdit = PlushBuziness.ClsCombo.GetListEnum(sql)
        cmbKindEdit.Properties.ValueMember = "Value"
        cmbKindEdit.Properties.DisplayMember = "DisplayMember"
        cmbKindEdit.Properties.DataSource = lstKindEdit

    End Sub

    Private Sub loadChannel()
        Dim lstChannel As List(Of PlushBuziness.clsKeyComboEnum)
        Dim lstChannelEdit As List(Of PlushBuziness.clsKeyComboEnum)
        Dim sql As String

        sql = PlushData.clsThemeTop.GetEnumMysqlChannel()
        lstChannel = PlushBuziness.ClsCombo.GetListEnum(sql)

        lstChannel.Add(New PlushBuziness.clsKeyComboEnum("", ""))
        cmbChannel.Properties.ValueMember = "Value"
        cmbChannel.Properties.DisplayMember = "DisplayMember"
        cmbChannel.Properties.DataSource = lstChannel

        lstChannelEdit = PlushBuziness.ClsCombo.GetListEnum(sql)
        cmbChannelEdit.Properties.ValueMember = "Value"
        cmbChannelEdit.Properties.DisplayMember = "DisplayMember"
        cmbChannelEdit.Properties.DataSource = lstChannelEdit

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
        Dim kind As Object
        Dim theme_event As Object
        Dim channel As Object


        id = TxtEventThemeId.EditValue
        title = txtTitle.EditValue
        kind = cmbKind.EditValue
        theme_event = cmbThemeEvent.EditValue
        channel = cmbChannel.EditValue

        DsSite1.product_lists.Clear()
        _sql = PlushData.clsThemeTop.GetSearch(id, title, kind, theme_event, channel)
        PlushData.clsConnection.FillDataSet(DsSite1.product_lists, _sql, )
        GridThemeTop.DataSource = DsSite1.product_lists


    End Sub

    Private Sub initForm()
        Dim blank As String = String.Empty
        txtTitleEdit.EditValue = blank
        TxtDescription.EditValue = blank
        chkHomepage.EditValue = 0

        chkStatus.EditValue = 0

        cmbLanguage.EditValue = blank
        cmbThemeEventEdit.EditValue = blank
        cmbKindEdit.ItemIndex = 1
        cmbStyle.ItemIndex = 0
        cmbChannelEdit.ItemIndex = 0


    End Sub

    Private Sub GridThemeEvent_doubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridThemeTop.DoubleClick
        loadInfo()
        ChangeStep(StepForm.LOAD)
    End Sub

    Private Sub loadInfo()
        Dim currentRow As DataRow

        If GridViewThemeTop.RowCount > 0 Then
            currentRow = GridViewThemeTop.GetDataRow(GridViewThemeTop.FocusedRowHandle())
            Dim index As Integer = DsSite1.product_lists.Rows.IndexOf(currentRow)
            Me.BindingContext(DsSite1, DsSite1.product_lists.TableName).Position = index
            XtraTabControlTheme.SelectedTabPage = tabDetail
        End If
    End Sub

    Private Sub insertData()

        Dim dr As DsSite.product_listsRow
        dr = DsSite1.product_lists.NewRow()
        dr.id = PlushBuziness.ClsThemeTop.GetLastId()
        DsSite1.product_lists.Addproduct_listsRow(dr)
        Me.BindingContext(DsSite1, DsSite1.product_lists.TableName).Position = DsSite1.product_lists.Rows.Count - 1

    End Sub

    Private Function EnableField(ByVal ok As Boolean) As Boolean
        Dim enable As Boolean
        enable = ok

        txtTitleEdit.Enabled = enable
        TxtDescription.Enabled = enable
        chkHomepage.Enabled = enable

        chkStatus.Enabled = enable

        cmbLanguage.Enabled = enable
        cmbThemeEventEdit.Enabled = enable
        cmbKindEdit.Enabled = enable
        cmbStyle.Enabled = enable
        cmbChannelEdit.Enabled = enable


        Return ok
    End Function

    Private Sub btnEditTheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditTheme.Click
        ChangeStep(StepForm.EDIT)

    End Sub

    Private Sub btnNewTheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewTheme.Click, btnNewTheme_edit.Click

        insertData()
        initForm()
        ChangeStep(StepForm.[NEW])
    End Sub

    Private Sub btnSaveTheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTheme.Click

        Dim drv As DataRowView
        Dim dr As DsSite.product_listsRow
        drv = Me.BindingContext(DsSite1, DsSite1.product_lists.TableName).Current
        dr = drv.Row
        If dr.Iscreated_atNull Then
            dr.created_at = Now()
        End If
        dr.updated_at = Now()
        Me.BindingContext(DsSite1, DsSite1.product_lists.TableName).EndCurrentEdit()
        PlushData.clsConnection.UpdateDataTableInDB(DsSite1.product_lists, _sql)
        ChangeStep(StepForm.SAVE)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(DsSite1, DsSite1.product_lists.TableName).EndCurrentEdit()
        Me.BindingContext(DsSite1, DsSite1.product_lists.TableName).CancelCurrentEdit()
        DsSite1.product_lists.Rows.RemoveAt(DsSite1.product_lists.Rows.Count - 1)
        ChangeStep(StepForm.CANCEL)

    End Sub



End Class



