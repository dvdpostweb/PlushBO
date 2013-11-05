Imports System.IO
Imports System.Collections.Generic
Public Class frmTranslate
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
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveTheme As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditTheme As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNewTheme_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtEventThemeId_edit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKeyEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitleEdit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbLanguage As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblLanguage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitleEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbLanguageEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblLanguageEdit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNameSpace As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUpdateDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblUpdateDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCreateDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDateCreate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridTranslate As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewTranslate As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamespace As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateAdded As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastModified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLanguage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEditLanguage As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemChkStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEditThemeEvent As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbLanding As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblLanding As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbLandingEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblLandingEdit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbNamespace As DevExpress.XtraEditors.LookUpEdit




    Friend WithEvents TxtEventThemeId As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTranslate))
        Me.tabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.GroupSearch = New DevExpress.XtraEditors.GroupControl
        Me.cmbLanding = New DevExpress.XtraEditors.LookUpEdit
        Me.lblLanding = New DevExpress.XtraEditors.LabelControl
        Me.cmbLanguage = New DevExpress.XtraEditors.LookUpEdit
        Me.lblLanguage = New DevExpress.XtraEditors.LabelControl
        Me.TxtEventThemeId = New DevExpress.XtraEditors.TextEdit
        Me.btnNewTheme = New DevExpress.XtraEditors.SimpleButton
        Me.lblEventThemeId = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit
        Me.tabResult = New DevExpress.XtraTab.XtraTabPage
        Me.GridTranslate = New DevExpress.XtraGrid.GridControl
        Me.GridViewTranslate = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNamespace = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDateAdded = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLastModified = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKey = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLanguage = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEditLanguage = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemChkStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemLookUpEditThemeEvent = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.DsSite1 = New PlushLib.DsSite
        Me.chkSelected = New DevExpress.XtraEditors.CheckEdit
        Me.lblSelected = New DevExpress.XtraEditors.LabelControl
        Me.ContextMenu1 = New PlushBuziness.contextMenu
        Me.XtraTabControlTheme = New DevExpress.XtraTab.XtraTabControl
        Me.tabDetail = New DevExpress.XtraTab.XtraTabPage
        Me.cmbNamespace = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbLandingEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.lblLandingEdit = New DevExpress.XtraEditors.LabelControl
        Me.txtUpdateDate = New DevExpress.XtraEditors.TextEdit
        Me.lblUpdateDate = New DevExpress.XtraEditors.LabelControl
        Me.txtCreateDate = New DevExpress.XtraEditors.TextEdit
        Me.lblDateCreate = New DevExpress.XtraEditors.LabelControl
        Me.lblNameSpace = New DevExpress.XtraEditors.LabelControl
        Me.txtTitleEdit = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cmbLanguageEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.lblLanguageEdit = New DevExpress.XtraEditors.LabelControl
        Me.lblId = New DevExpress.XtraEditors.LabelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSaveTheme = New DevExpress.XtraEditors.SimpleButton
        Me.btnEditTheme = New DevExpress.XtraEditors.SimpleButton
        Me.btnNewTheme_edit = New DevExpress.XtraEditors.SimpleButton
        Me.TxtEventThemeId_edit = New DevExpress.XtraEditors.TextEdit
        Me.txtKeyEdit = New DevExpress.XtraEditors.TextEdit
        Me.lblTitleEdit = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearch.SuspendLayout()
        CType(Me.GroupSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupSearch.SuspendLayout()
        CType(Me.cmbLanding.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEventThemeId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabResult.SuspendLayout()
        CType(Me.GridTranslate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTranslate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEditLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemChkStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEditThemeEvent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSite1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControlTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControlTheme.SuspendLayout()
        Me.tabDetail.SuspendLayout()
        CType(Me.cmbNamespace.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLandingEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUpdateDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreateDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguageEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEventThemeId_edit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKeyEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupSearch.Controls.Add(Me.cmbLanding)
        Me.GroupSearch.Controls.Add(Me.lblLanding)
        Me.GroupSearch.Controls.Add(Me.cmbLanguage)
        Me.GroupSearch.Controls.Add(Me.lblLanguage)
        Me.GroupSearch.Controls.Add(Me.TxtEventThemeId)
        Me.GroupSearch.Controls.Add(Me.btnNewTheme)
        Me.GroupSearch.Controls.Add(Me.lblEventThemeId)
        Me.GroupSearch.Controls.Add(Me.btnSearch)
        Me.GroupSearch.Controls.Add(Me.lblTitle)
        Me.GroupSearch.Controls.Add(Me.txtTitle)
        Me.GroupSearch.Name = "GroupSearch"
        '
        'cmbLanding
        '
        resources.ApplyResources(Me.cmbLanding, "cmbLanding")
        Me.cmbLanding.Name = "cmbLanding"
        Me.cmbLanding.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbLanding.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbLanding.Properties.NullText = resources.GetString("cmbLanding.Properties.NullText")
        '
        'lblLanding
        '
        resources.ApplyResources(Me.lblLanding, "lblLanding")
        Me.lblLanding.Name = "lblLanding"
        '
        'cmbLanguage
        '
        resources.ApplyResources(Me.cmbLanguage, "cmbLanguage")
        Me.cmbLanguage.Name = "cmbLanguage"
        Me.cmbLanguage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbLanguage.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbLanguage.Properties.NullText = resources.GetString("cmbLanguage.Properties.NullText")
        '
        'lblLanguage
        '
        resources.ApplyResources(Me.lblLanguage, "lblLanguage")
        Me.lblLanguage.Name = "lblLanguage"
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
        Me.tabResult.Controls.Add(Me.GridTranslate)
        Me.tabResult.Name = "tabResult"
        resources.ApplyResources(Me.tabResult, "tabResult")
        '
        'GridTranslate
        '
        resources.ApplyResources(Me.GridTranslate, "GridTranslate")
        Me.GridTranslate.EmbeddedNavigator.Name = ""
        Me.GridTranslate.FormsUseDefaultLookAndFeel = False
        Me.GridTranslate.MainView = Me.GridViewTranslate
        Me.GridTranslate.Name = "GridTranslate"
        Me.GridTranslate.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemChkStatus, Me.RepositoryItemLookUpEditLanguage, Me.RepositoryItemLookUpEditThemeEvent})
        Me.GridTranslate.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewTranslate})
        '
        'GridViewTranslate
        '
        Me.GridViewTranslate.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colName, Me.colNamespace, Me.colDateAdded, Me.colLastModified, Me.colKey, Me.colLanguage})
        Me.GridViewTranslate.GridControl = Me.GridTranslate
        Me.GridViewTranslate.Name = "GridViewTranslate"
        Me.GridViewTranslate.OptionsView.ShowAutoFilterRow = True
        Me.GridViewTranslate.OptionsView.ShowFooter = True
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
        Me.colName.FieldName = "text"
        Me.colName.Name = "colName"
        '
        'colNamespace
        '
        resources.ApplyResources(Me.colNamespace, "colNamespace")
        Me.colNamespace.FieldName = "namespace"
        Me.colNamespace.Name = "colNamespace"
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
        'colKey
        '
        resources.ApplyResources(Me.colKey, "colKey")
        Me.colKey.FieldName = "tr_key"
        Me.colKey.Name = "colKey"
        '
        'colLanguage
        '
        resources.ApplyResources(Me.colLanguage, "colLanguage")
        Me.colLanguage.ColumnEdit = Me.RepositoryItemLookUpEditLanguage
        Me.colLanguage.FieldName = "locale_id"
        Me.colLanguage.Name = "colLanguage"
        '
        'RepositoryItemLookUpEditLanguage
        '
        resources.ApplyResources(Me.RepositoryItemLookUpEditLanguage, "RepositoryItemLookUpEditLanguage")
        Me.RepositoryItemLookUpEditLanguage.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEditLanguage.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemLookUpEditLanguage.Name = "RepositoryItemLookUpEditLanguage"
        '
        'RepositoryItemChkStatus
        '
        resources.ApplyResources(Me.RepositoryItemChkStatus, "RepositoryItemChkStatus")
        Me.RepositoryItemChkStatus.Name = "RepositoryItemChkStatus"
        '
        'RepositoryItemLookUpEditThemeEvent
        '
        resources.ApplyResources(Me.RepositoryItemLookUpEditThemeEvent, "RepositoryItemLookUpEditThemeEvent")
        Me.RepositoryItemLookUpEditThemeEvent.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEditThemeEvent.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemLookUpEditThemeEvent.Name = "RepositoryItemLookUpEditThemeEvent"
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
        Me.tabDetail.Controls.Add(Me.cmbNamespace)
        Me.tabDetail.Controls.Add(Me.cmbLandingEdit)
        Me.tabDetail.Controls.Add(Me.lblLandingEdit)
        Me.tabDetail.Controls.Add(Me.txtUpdateDate)
        Me.tabDetail.Controls.Add(Me.lblUpdateDate)
        Me.tabDetail.Controls.Add(Me.txtCreateDate)
        Me.tabDetail.Controls.Add(Me.lblDateCreate)
        Me.tabDetail.Controls.Add(Me.lblNameSpace)
        Me.tabDetail.Controls.Add(Me.txtTitleEdit)
        Me.tabDetail.Controls.Add(Me.LabelControl1)
        Me.tabDetail.Controls.Add(Me.cmbLanguageEdit)
        Me.tabDetail.Controls.Add(Me.lblLanguageEdit)
        Me.tabDetail.Controls.Add(Me.lblId)
        Me.tabDetail.Controls.Add(Me.btnCancel)
        Me.tabDetail.Controls.Add(Me.btnSaveTheme)
        Me.tabDetail.Controls.Add(Me.btnEditTheme)
        Me.tabDetail.Controls.Add(Me.btnNewTheme_edit)
        Me.tabDetail.Controls.Add(Me.TxtEventThemeId_edit)
        Me.tabDetail.Controls.Add(Me.txtKeyEdit)
        Me.tabDetail.Controls.Add(Me.lblTitleEdit)
        Me.tabDetail.Name = "tabDetail"
        resources.ApplyResources(Me.tabDetail, "tabDetail")
        '
        'cmbNamespace
        '
        Me.cmbNamespace.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Translate.namespace", True))
        resources.ApplyResources(Me.cmbNamespace, "cmbNamespace")
        Me.cmbNamespace.Name = "cmbNamespace"
        Me.cmbNamespace.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbNamespace.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbNamespace.Properties.NullText = resources.GetString("cmbNamespace.Properties.NullText")
        '
        'cmbLandingEdit
        '
        Me.cmbLandingEdit.AllowDrop = True
        resources.ApplyResources(Me.cmbLandingEdit, "cmbLandingEdit")
        Me.cmbLandingEdit.Name = "cmbLandingEdit"
        Me.cmbLandingEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbLandingEdit.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbLandingEdit.Properties.NullText = resources.GetString("cmbLandingEdit.Properties.NullText")
        '
        'lblLandingEdit
        '
        resources.ApplyResources(Me.lblLandingEdit, "lblLandingEdit")
        Me.lblLandingEdit.Name = "lblLandingEdit"
        '
        'txtUpdateDate
        '
        Me.txtUpdateDate.AllowDrop = True
        Me.txtUpdateDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Translate.updated_at", True))
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
        Me.txtCreateDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Translate.created_at", True))
        resources.ApplyResources(Me.txtCreateDate, "txtCreateDate")
        Me.txtCreateDate.Name = "txtCreateDate"
        '
        'lblDateCreate
        '
        resources.ApplyResources(Me.lblDateCreate, "lblDateCreate")
        Me.lblDateCreate.Name = "lblDateCreate"
        '
        'lblNameSpace
        '
        resources.ApplyResources(Me.lblNameSpace, "lblNameSpace")
        Me.lblNameSpace.Name = "lblNameSpace"
        '
        'txtTitleEdit
        '
        Me.txtTitleEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Translate.text", True))
        resources.ApplyResources(Me.txtTitleEdit, "txtTitleEdit")
        Me.txtTitleEdit.Name = "txtTitleEdit"
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        '
        'cmbLanguageEdit
        '
        Me.cmbLanguageEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Translate.locale_id", True))
        resources.ApplyResources(Me.cmbLanguageEdit, "cmbLanguageEdit")
        Me.cmbLanguageEdit.Name = "cmbLanguageEdit"
        Me.cmbLanguageEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbLanguageEdit.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbLanguageEdit.Properties.NullText = resources.GetString("cmbLanguageEdit.Properties.NullText")
        '
        'lblLanguageEdit
        '
        resources.ApplyResources(Me.lblLanguageEdit, "lblLanguageEdit")
        Me.lblLanguageEdit.Name = "lblLanguageEdit"
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
        Me.TxtEventThemeId_edit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Translate.id", True))
        resources.ApplyResources(Me.TxtEventThemeId_edit, "TxtEventThemeId_edit")
        Me.TxtEventThemeId_edit.Name = "TxtEventThemeId_edit"
        '
        'txtKeyEdit
        '
        Me.txtKeyEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Translate.tr_key", True))
        resources.ApplyResources(Me.txtKeyEdit, "txtKeyEdit")
        Me.txtKeyEdit.Name = "txtKeyEdit"
        '
        'lblTitleEdit
        '
        resources.ApplyResources(Me.lblTitleEdit, "lblTitleEdit")
        Me.lblTitleEdit.Name = "lblTitleEdit"
        '
        'TextEdit1
        '
        Me.TextEdit1.AllowDrop = True
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Translate.updated_at", True))
        resources.ApplyResources(Me.TextEdit1, "TextEdit1")
        Me.TextEdit1.Name = "TextEdit1"
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'TextEdit2
        '
        Me.TextEdit2.AllowDrop = True
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Translate.created_at", True))
        resources.ApplyResources(Me.TextEdit2, "TextEdit2")
        Me.TextEdit2.Name = "TextEdit2"
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Translate.namespace", True))
        resources.ApplyResources(Me.TextEdit3, "TextEdit3")
        Me.TextEdit3.Name = "TextEdit3"
        '
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Translate.text", True))
        resources.ApplyResources(Me.TextEdit4, "TextEdit4")
        Me.TextEdit4.Name = "TextEdit4"
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Name = "LabelControl5"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Translate.locale_id", True))
        resources.ApplyResources(Me.LookUpEdit1, "LookUpEdit1")
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit1.Properties.DisplayMember = "status_desc"
        Me.LookUpEdit1.Properties.NullText = resources.GetString("LookUpEdit1.Properties.NullText")
        Me.LookUpEdit1.Properties.ValueMember = "status_id"
        '
        'LabelControl6
        '
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.Name = "LabelControl6"
        '
        'LabelControl7
        '
        resources.ApplyResources(Me.LabelControl7, "LabelControl7")
        Me.LabelControl7.Name = "LabelControl7"
        '
        'SimpleButton1
        '
        resources.ApplyResources(Me.SimpleButton1, "SimpleButton1")
        Me.SimpleButton1.Name = "SimpleButton1"
        '
        'SimpleButton2
        '
        resources.ApplyResources(Me.SimpleButton2, "SimpleButton2")
        Me.SimpleButton2.Name = "SimpleButton2"
        '
        'SimpleButton3
        '
        resources.ApplyResources(Me.SimpleButton3, "SimpleButton3")
        Me.SimpleButton3.Name = "SimpleButton3"
        '
        'SimpleButton4
        '
        resources.ApplyResources(Me.SimpleButton4, "SimpleButton4")
        Me.SimpleButton4.Name = "SimpleButton4"
        '
        'TextEdit5
        '
        Me.TextEdit5.AllowDrop = True
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Translate.id", True))
        resources.ApplyResources(Me.TextEdit5, "TextEdit5")
        Me.TextEdit5.Name = "TextEdit5"
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Translate.tr_key", True))
        resources.ApplyResources(Me.TextEdit6, "TextEdit6")
        Me.TextEdit6.Name = "TextEdit6"
        '
        'LabelControl8
        '
        resources.ApplyResources(Me.LabelControl8, "LabelControl8")
        Me.LabelControl8.Name = "LabelControl8"
        '
        'frmTranslate
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.XtraTabControlTheme)
        Me.Name = "frmTranslate"
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
        CType(Me.cmbLanding.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEventThemeId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabResult.ResumeLayout(False)
        CType(Me.GridTranslate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTranslate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEditLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemChkStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEditThemeEvent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSite1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControlTheme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControlTheme.ResumeLayout(False)
        Me.tabDetail.ResumeLayout(False)
        Me.tabDetail.PerformLayout()
        CType(Me.cmbNamespace.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLandingEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUpdateDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreateDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguageEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEventThemeId_edit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKeyEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim CurrentCodeType As String
    Dim stepcurrent As StepForm
    Dim _enableField As Boolean
    Dim _sql As String

    ' code non maintenable mais obligation a cause design DB 
    Const NAMESPACE1 As String = "home.index.carousel_item"
    Const NAMESPACE2 As String = "home.index.carousel_item_title"
    Const NAMESPACE3 As String = "products.left_column"

    Enum StepForm
        EDIT
        [NEW]
        SAVE
        CANCEL
        INIT
        LOAD
    End Enum

    Private Sub save()
        PlushData.clsConnection.UpdateDataTableInDB(DsSite1.Translate, _sql)
    End Sub

    Private Sub ChangeStep(ByVal stept As StepForm)
        stepcurrent = stept

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


    Private Function gettranslateKey(ByVal strnamespace As String) As String

        Select Case strnamespace
            Case NAMESPACE1
                Return "name,link"
            Case NAMESPACE2
                Return "title"
            Case Else
                Return ""
        End Select


    End Function

    Public Sub this_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        GridViewTranslate.OptionsView.ColumnAutoWidth = False
        GridViewTranslate.OptionsBehavior.Editable = False

        XtraTabControlTheme.SelectedTabPage = tabSearch
        ' Misc_Bar.Visible = True

        Dim menuStrip As New PlushBuziness.contextMenu()
        GridTranslate.ContextMenuStrip = menuStrip


        loadLanguage()
        loadLanding()
        LoadNamespace()

        ' after search load cmb
        search()


        ChangeStep(StepForm.INIT)


    End Sub
    Private Sub LoadNamespace()

        Dim lstNamespace As New List(Of PlushBuziness.clsKeyComboEnum)
        Dim item As PlushBuziness.clsKeyComboEnum

        item = New PlushBuziness.clsKeyComboEnum(NAMESPACE1, NAMESPACE1)
        lstNamespace.Add(item)

        item = New PlushBuziness.clsKeyComboEnum(NAMESPACE2, NAMESPACE2)
        lstNamespace.Add(item)

        item = New PlushBuziness.clsKeyComboEnum(NAMESPACE3, NAMESPACE3)
        lstNamespace.Add(item)


        cmbNamespace.Properties.ValueMember = "Value"
        cmbNamespace.Properties.DisplayMember = "DisplayMember"
        cmbNamespace.Properties.DataSource = lstNamespace

    End Sub
    Private Sub loadLanding()

        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "name"
        Dim dtLanding As DataTable

        Dim dtLandingEdit As DataTable

        sql = PlushData.clsTranslate.GetLoadLanding()
        dtLanding = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtLanding)
        cmbLanding.Properties.ValueMember = key
        cmbLanding.Properties.DisplayMember = value
        cmbLanding.Properties.DataSource = dtLanding


        dtLandingEdit = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtLandingEdit)
        cmbLandingEdit.Properties.ValueMember = key
        cmbLandingEdit.Properties.DisplayMember = value
        cmbLandingEdit.Properties.DataSource = dtLanding

    End Sub
    Private Sub loadLanguage()
        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "short"
        Dim dtLanguage As DataTable
        Dim dtLanguageEdit As DataTable

        sql = PlushData.clsLandings.getLanguages()
        dtLanguageEdit = PlushData.clsConnection.FillDataSet(sql)

        cmbLanguageEdit.Properties.ValueMember = key
        cmbLanguageEdit.Properties.DisplayMember = value
        cmbLanguageEdit.Properties.DataSource = dtLanguageEdit

        RepositoryItemLookUpEditLanguage.ValueMember = key
        RepositoryItemLookUpEditLanguage.DisplayMember = value
        RepositoryItemLookUpEditLanguage.DataSource = dtLanguageEdit

        dtLanguage = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtLanguage)
        cmbLanguage.Properties.ValueMember = key
        cmbLanguage.Properties.DisplayMember = value
        cmbLanguage.Properties.DataSource = dtLanguage


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
        Dim lang As Object
        Dim landing As Object

        id = TxtEventThemeId.EditValue
        title = txtTitle.EditValue
        lang = cmbLanguage.EditValue
        landing = cmbLanding.EditValue
        DsSite1.Translate.Clear()
        _sql = PlushData.clsTranslate.GetSearch(id, title, lang, landing)
        PlushData.clsConnection.FillDataSet(DsSite1.Translate, _sql, )
        GridTranslate.DataSource = DsSite1.Translate


    End Sub

    Private Sub initForm()
        Dim blank As String = String.Empty

        txtKeyEdit.EditValue = blank
        txtTitleEdit.EditValue = blank
        cmbLanguageEdit.EditValue = blank
        cmbNamespace.EditValue = blank

    End Sub

    Private Sub GridTranslate_doubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridTranslate.DoubleClick
        loadInfo()
        ChangeStep(StepForm.LOAD)
    End Sub
    Private Sub SetThemeId(ByVal key As String)
        Dim lst As String()

        lst = key.Split("_")

        If lst.Length = 2 Then
            cmbLandingEdit.EditValue = CInt(lst(1))
        Else
            cmbLandingEdit.EditValue = -1
        End If
    End Sub
    Private Sub loadInfo()
        Dim currentRow As DataRow

        If GridViewTranslate.RowCount > 0 Then
            currentRow = GridViewTranslate.GetDataRow(GridViewTranslate.FocusedRowHandle())
            Dim index As Integer = DsSite1.Translate.Rows.IndexOf(currentRow)
            Me.BindingContext(DsSite1, DsSite1.Translate.TableName).Position = index
            XtraTabControlTheme.SelectedTabPage = tabDetail
            SetThemeId(Me.BindingContext(DsSite1, DsSite1.Translate.TableName).Current("tr_key"))


        End If
    End Sub

    Private Sub insertData()

        Dim dr As DsSite.TranslateRow
        dr = DsSite1.Translate.NewRow()
        dr.id = PlushBuziness.ClsTranslate.GetLastId()
        DsSite1.Translate.AddTranslateRow(dr)
        Me.BindingContext(DsSite1, DsSite1.Translate.TableName).Position = DsSite1.Translate.Rows.Count - 1

    End Sub

    Private Function EnableField(ByVal ok As Boolean) As Boolean
        Dim enable As Boolean
        enable = ok

        txtKeyEdit.Enabled = enable
        txtTitleEdit.Enabled = enable
        cmbLanguageEdit.Enabled = enable
        cmbNamespace.Enabled = enable
        cmbLandingEdit.Enabled = enable

        Return ok
    End Function

    Private Sub btnEditTheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditTheme.Click
        ChangeStep(StepForm.EDIT)

    End Sub

    Private Sub btnNewTheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewTheme.Click, btnNewTheme_edit.Click

        insertData()
        ChangeStep(StepForm.[NEW])
    End Sub

    Private Sub btnSaveTheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTheme.Click

        Dim drv As DataRowView
        Dim dr As DsSite.TranslateRow
        drv = Me.BindingContext(DsSite1, DsSite1.Translate.TableName).Current
        dr = drv.Row
        If dr.Iscreated_atNull Then
            dr.created_at = Now()
        End If
        dr.updated_at = Now()
        Me.BindingContext(DsSite1, DsSite1.Translate.TableName).EndCurrentEdit()
        PlushData.clsConnection.UpdateDataTableInDB(DsSite1.Translate, _sql)
        ChangeStep(StepForm.SAVE)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(DsSite1, DsSite1.Translate.TableName).CancelCurrentEdit()
        ChangeStep(StepForm.CANCEL)

    End Sub


    Private Sub cmbTheme_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLandingEdit.EditValueChanged
        If stepcurrent <> StepForm.LOAD Then
            txtKeyEdit.EditValue = "_" & cmbLandingEdit.EditValue
        End If
    End Sub
End Class



