Imports System.IO
Imports System.Collections.Generic
Public Class frmLandings
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
    Friend WithEvents GridLandings As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewLandings As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveTheme As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditTheme As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNewTheme_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtLandingId_edit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTitleEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitleEdit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbKind As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblKind As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbKindEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblKindEdit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateExpirated As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbActifFr As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblActifFR As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemChkStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEditLanguage As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEditThemeEvent As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbActifEN As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblActifEN As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbActifNL As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblActifNL As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLogin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spnOrdered As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblOrdered As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReference As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblReference As DevExpress.XtraEditors.LabelControl
    Friend WithEvents imgLanding As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents OFDPicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtExpiratedDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbLogin As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnPrivateProd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPublicBeta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPublicProd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrivateBeta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblImageiPad As DevExpress.XtraEditors.LabelControl
    Friend WithEvents imgLandingiPad As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblImageiPhone As DevExpress.XtraEditors.LabelControl
    Friend WithEvents imgLandingiPhone As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblImageWebSite As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents imgLandingsSmartTV As DevExpress.XtraEditors.PictureEdit




    Friend WithEvents TxtLandingId As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLandings))
        Me.tabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.GroupSearch = New DevExpress.XtraEditors.GroupControl
        Me.btnPublicBeta = New DevExpress.XtraEditors.SimpleButton
        Me.btnPublicProd = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrivateBeta = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrivateProd = New DevExpress.XtraEditors.SimpleButton
        Me.cmbKind = New DevExpress.XtraEditors.LookUpEdit
        Me.lblKind = New DevExpress.XtraEditors.LabelControl
        Me.TxtLandingId = New DevExpress.XtraEditors.TextEdit
        Me.btnNewTheme = New DevExpress.XtraEditors.SimpleButton
        Me.lblEventThemeId = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit
        Me.tabResult = New DevExpress.XtraTab.XtraTabPage
        Me.GridLandings = New DevExpress.XtraGrid.GridControl
        Me.GridViewLandings = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemChkStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemLookUpEditLanguage = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEditThemeEvent = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.DsSite1 = New PlushLib.DsSite
        Me.chkSelected = New DevExpress.XtraEditors.CheckEdit
        Me.lblSelected = New DevExpress.XtraEditors.LabelControl
        Me.ContextMenu1 = New PlushBuziness.contextMenu
        Me.XtraTabControlTheme = New DevExpress.XtraTab.XtraTabControl
        Me.tabDetail = New DevExpress.XtraTab.XtraTabPage
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.imgLandingsSmartTV = New DevExpress.XtraEditors.PictureEdit
        Me.lblImageiPad = New DevExpress.XtraEditors.LabelControl
        Me.imgLandingiPad = New DevExpress.XtraEditors.PictureEdit
        Me.lblImageiPhone = New DevExpress.XtraEditors.LabelControl
        Me.imgLandingiPhone = New DevExpress.XtraEditors.PictureEdit
        Me.lblImageWebSite = New DevExpress.XtraEditors.LabelControl
        Me.cmbLogin = New DevExpress.XtraEditors.LookUpEdit
        Me.txtExpiratedDate = New DevExpress.XtraEditors.DateEdit
        Me.imgLanding = New DevExpress.XtraEditors.PictureEdit
        Me.txtReference = New DevExpress.XtraEditors.TextEdit
        Me.lblReference = New DevExpress.XtraEditors.LabelControl
        Me.spnOrdered = New DevExpress.XtraEditors.SpinEdit
        Me.lblOrdered = New DevExpress.XtraEditors.LabelControl
        Me.lblLogin = New DevExpress.XtraEditors.LabelControl
        Me.cmbActifEN = New DevExpress.XtraEditors.LookUpEdit
        Me.lblActifEN = New DevExpress.XtraEditors.LabelControl
        Me.cmbActifNL = New DevExpress.XtraEditors.LookUpEdit
        Me.lblActifNL = New DevExpress.XtraEditors.LabelControl
        Me.cmbActifFr = New DevExpress.XtraEditors.LookUpEdit
        Me.lblActifFR = New DevExpress.XtraEditors.LabelControl
        Me.cmbKindEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.lblKindEdit = New DevExpress.XtraEditors.LabelControl
        Me.lblDateExpirated = New DevExpress.XtraEditors.LabelControl
        Me.lblId = New DevExpress.XtraEditors.LabelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSaveTheme = New DevExpress.XtraEditors.SimpleButton
        Me.btnEditTheme = New DevExpress.XtraEditors.SimpleButton
        Me.btnNewTheme_edit = New DevExpress.XtraEditors.SimpleButton
        Me.TxtLandingId_edit = New DevExpress.XtraEditors.TextEdit
        Me.txtTitleEdit = New DevExpress.XtraEditors.TextEdit
        Me.lblTitleEdit = New DevExpress.XtraEditors.LabelControl
        Me.OFDPicture = New System.Windows.Forms.OpenFileDialog
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearch.SuspendLayout()
        CType(Me.GroupSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupSearch.SuspendLayout()
        CType(Me.cmbKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtLandingId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabResult.SuspendLayout()
        CType(Me.GridLandings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewLandings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemChkStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEditLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEditThemeEvent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSite1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControlTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControlTheme.SuspendLayout()
        Me.tabDetail.SuspendLayout()
        CType(Me.imgLandingsSmartTV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLandingiPad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLandingiPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLogin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExpiratedDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExpiratedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLanding.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnOrdered.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbActifEN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbActifNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbActifFr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbKindEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtLandingId_edit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupSearch.Controls.Add(Me.btnPublicBeta)
        Me.GroupSearch.Controls.Add(Me.btnPublicProd)
        Me.GroupSearch.Controls.Add(Me.btnPrivateBeta)
        Me.GroupSearch.Controls.Add(Me.btnPrivateProd)
        Me.GroupSearch.Controls.Add(Me.cmbKind)
        Me.GroupSearch.Controls.Add(Me.lblKind)
        Me.GroupSearch.Controls.Add(Me.TxtLandingId)
        Me.GroupSearch.Controls.Add(Me.btnNewTheme)
        Me.GroupSearch.Controls.Add(Me.lblEventThemeId)
        Me.GroupSearch.Controls.Add(Me.btnSearch)
        Me.GroupSearch.Controls.Add(Me.lblTitle)
        Me.GroupSearch.Controls.Add(Me.txtTitle)
        Me.GroupSearch.Name = "GroupSearch"
        '
        'btnPublicBeta
        '
        resources.ApplyResources(Me.btnPublicBeta, "btnPublicBeta")
        Me.btnPublicBeta.Name = "btnPublicBeta"
        '
        'btnPublicProd
        '
        resources.ApplyResources(Me.btnPublicProd, "btnPublicProd")
        Me.btnPublicProd.Name = "btnPublicProd"
        '
        'btnPrivateBeta
        '
        resources.ApplyResources(Me.btnPrivateBeta, "btnPrivateBeta")
        Me.btnPrivateBeta.Name = "btnPrivateBeta"
        '
        'btnPrivateProd
        '
        resources.ApplyResources(Me.btnPrivateProd, "btnPrivateProd")
        Me.btnPrivateProd.Name = "btnPrivateProd"
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
        'TxtLandingId
        '
        resources.ApplyResources(Me.TxtLandingId, "TxtLandingId")
        Me.TxtLandingId.Name = "TxtLandingId"
        Me.TxtLandingId.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtLandingId.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
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
        Me.tabResult.Controls.Add(Me.GridLandings)
        Me.tabResult.Name = "tabResult"
        resources.ApplyResources(Me.tabResult, "tabResult")
        '
        'GridLandings
        '
        resources.ApplyResources(Me.GridLandings, "GridLandings")
        Me.GridLandings.EmbeddedNavigator.Name = ""
        Me.GridLandings.FormsUseDefaultLookAndFeel = False
        Me.GridLandings.MainView = Me.GridViewLandings
        Me.GridLandings.Name = "GridLandings"
        Me.GridLandings.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemChkStatus, Me.RepositoryItemLookUpEditLanguage, Me.RepositoryItemLookUpEditThemeEvent})
        Me.GridLandings.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewLandings})
        '
        'GridViewLandings
        '
        Me.GridViewLandings.GridControl = Me.GridLandings
        Me.GridViewLandings.Name = "GridViewLandings"
        Me.GridViewLandings.OptionsView.ShowFooter = True
        '
        'RepositoryItemChkStatus
        '
        resources.ApplyResources(Me.RepositoryItemChkStatus, "RepositoryItemChkStatus")
        Me.RepositoryItemChkStatus.Name = "RepositoryItemChkStatus"
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
        Me.tabDetail.Controls.Add(Me.LabelControl1)
        Me.tabDetail.Controls.Add(Me.imgLandingsSmartTV)
        Me.tabDetail.Controls.Add(Me.lblImageiPad)
        Me.tabDetail.Controls.Add(Me.imgLandingiPad)
        Me.tabDetail.Controls.Add(Me.lblImageiPhone)
        Me.tabDetail.Controls.Add(Me.imgLandingiPhone)
        Me.tabDetail.Controls.Add(Me.lblImageWebSite)
        Me.tabDetail.Controls.Add(Me.cmbLogin)
        Me.tabDetail.Controls.Add(Me.txtExpiratedDate)
        Me.tabDetail.Controls.Add(Me.imgLanding)
        Me.tabDetail.Controls.Add(Me.txtReference)
        Me.tabDetail.Controls.Add(Me.lblReference)
        Me.tabDetail.Controls.Add(Me.spnOrdered)
        Me.tabDetail.Controls.Add(Me.lblOrdered)
        Me.tabDetail.Controls.Add(Me.lblLogin)
        Me.tabDetail.Controls.Add(Me.cmbActifEN)
        Me.tabDetail.Controls.Add(Me.lblActifEN)
        Me.tabDetail.Controls.Add(Me.cmbActifNL)
        Me.tabDetail.Controls.Add(Me.lblActifNL)
        Me.tabDetail.Controls.Add(Me.cmbActifFr)
        Me.tabDetail.Controls.Add(Me.lblActifFR)
        Me.tabDetail.Controls.Add(Me.cmbKindEdit)
        Me.tabDetail.Controls.Add(Me.lblKindEdit)
        Me.tabDetail.Controls.Add(Me.lblDateExpirated)
        Me.tabDetail.Controls.Add(Me.lblId)
        Me.tabDetail.Controls.Add(Me.btnCancel)
        Me.tabDetail.Controls.Add(Me.btnSaveTheme)
        Me.tabDetail.Controls.Add(Me.btnEditTheme)
        Me.tabDetail.Controls.Add(Me.btnNewTheme_edit)
        Me.tabDetail.Controls.Add(Me.TxtLandingId_edit)
        Me.tabDetail.Controls.Add(Me.txtTitleEdit)
        Me.tabDetail.Controls.Add(Me.lblTitleEdit)
        Me.tabDetail.Name = "tabDetail"
        resources.ApplyResources(Me.tabDetail, "tabDetail")
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        '
        'imgLandingsSmartTV
        '
        resources.ApplyResources(Me.imgLandingsSmartTV, "imgLandingsSmartTV")
        Me.imgLandingsSmartTV.Name = "imgLandingsSmartTV"
        Me.imgLandingsSmartTV.Properties.ShowMenu = False
        '
        'lblImageiPad
        '
        resources.ApplyResources(Me.lblImageiPad, "lblImageiPad")
        Me.lblImageiPad.Name = "lblImageiPad"
        '
        'imgLandingiPad
        '
        resources.ApplyResources(Me.imgLandingiPad, "imgLandingiPad")
        Me.imgLandingiPad.Name = "imgLandingiPad"
        Me.imgLandingiPad.Properties.ShowMenu = False
        '
        'lblImageiPhone
        '
        resources.ApplyResources(Me.lblImageiPhone, "lblImageiPhone")
        Me.lblImageiPhone.Name = "lblImageiPhone"
        '
        'imgLandingiPhone
        '
        resources.ApplyResources(Me.imgLandingiPhone, "imgLandingiPhone")
        Me.imgLandingiPhone.Name = "imgLandingiPhone"
        Me.imgLandingiPhone.Properties.ShowMenu = False
        '
        'lblImageWebSite
        '
        resources.ApplyResources(Me.lblImageWebSite, "lblImageWebSite")
        Me.lblImageWebSite.Name = "lblImageWebSite"
        '
        'cmbLogin
        '
        Me.cmbLogin.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "landings.login", True))
        resources.ApplyResources(Me.cmbLogin, "cmbLogin")
        Me.cmbLogin.Name = "cmbLogin"
        Me.cmbLogin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbLogin.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbLogin.Properties.NullText = resources.GetString("cmbLogin.Properties.NullText")
        '
        'txtExpiratedDate
        '
        Me.txtExpiratedDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "landings.expirated_date", True))
        Me.txtExpiratedDate.EditValue = Nothing
        resources.ApplyResources(Me.txtExpiratedDate, "txtExpiratedDate")
        Me.txtExpiratedDate.Name = "txtExpiratedDate"
        Me.txtExpiratedDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtExpiratedDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtExpiratedDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'imgLanding
        '
        resources.ApplyResources(Me.imgLanding, "imgLanding")
        Me.imgLanding.Name = "imgLanding"
        Me.imgLanding.Properties.ShowMenu = False
        '
        'txtReference
        '
        Me.txtReference.AllowDrop = True
        Me.txtReference.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "landings.reference_id", True))
        resources.ApplyResources(Me.txtReference, "txtReference")
        Me.txtReference.Name = "txtReference"
        '
        'lblReference
        '
        resources.ApplyResources(Me.lblReference, "lblReference")
        Me.lblReference.Name = "lblReference"
        '
        'spnOrdered
        '
        Me.spnOrdered.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "landings.ordered", True))
        resources.ApplyResources(Me.spnOrdered, "spnOrdered")
        Me.spnOrdered.Name = "spnOrdered"
        Me.spnOrdered.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.spnOrdered.Properties.MaxLength = 2
        Me.spnOrdered.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lblOrdered
        '
        resources.ApplyResources(Me.lblOrdered, "lblOrdered")
        Me.lblOrdered.Name = "lblOrdered"
        '
        'lblLogin
        '
        resources.ApplyResources(Me.lblLogin, "lblLogin")
        Me.lblLogin.Name = "lblLogin"
        '
        'cmbActifEN
        '
        Me.cmbActifEN.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "landings.actif_english", True))
        resources.ApplyResources(Me.cmbActifEN, "cmbActifEN")
        Me.cmbActifEN.Name = "cmbActifEN"
        Me.cmbActifEN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbActifEN.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbActifEN.Properties.DisplayMember = "status_desc"
        Me.cmbActifEN.Properties.NullText = resources.GetString("cmbActifEN.Properties.NullText")
        Me.cmbActifEN.Properties.ValueMember = "status_id"
        '
        'lblActifEN
        '
        resources.ApplyResources(Me.lblActifEN, "lblActifEN")
        Me.lblActifEN.Name = "lblActifEN"
        '
        'cmbActifNL
        '
        Me.cmbActifNL.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "landings.actif_dutch", True))
        resources.ApplyResources(Me.cmbActifNL, "cmbActifNL")
        Me.cmbActifNL.Name = "cmbActifNL"
        Me.cmbActifNL.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbActifNL.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbActifNL.Properties.DisplayMember = "status_desc"
        Me.cmbActifNL.Properties.NullText = resources.GetString("cmbActifNL.Properties.NullText")
        Me.cmbActifNL.Properties.ValueMember = "status_id"
        '
        'lblActifNL
        '
        resources.ApplyResources(Me.lblActifNL, "lblActifNL")
        Me.lblActifNL.Name = "lblActifNL"
        '
        'cmbActifFr
        '
        Me.cmbActifFr.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "landings.actif_french", True))
        resources.ApplyResources(Me.cmbActifFr, "cmbActifFr")
        Me.cmbActifFr.Name = "cmbActifFr"
        Me.cmbActifFr.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbActifFr.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbActifFr.Properties.DisplayMember = "status_desc"
        Me.cmbActifFr.Properties.NullText = resources.GetString("cmbActifFr.Properties.NullText")
        Me.cmbActifFr.Properties.ValueMember = "status_id"
        '
        'lblActifFR
        '
        resources.ApplyResources(Me.lblActifFR, "lblActifFR")
        Me.lblActifFR.Name = "lblActifFR"
        '
        'cmbKindEdit
        '
        Me.cmbKindEdit.AllowDrop = True
        Me.cmbKindEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "landings.kind", True))
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
        'lblDateExpirated
        '
        resources.ApplyResources(Me.lblDateExpirated, "lblDateExpirated")
        Me.lblDateExpirated.Name = "lblDateExpirated"
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
        'TxtLandingId_edit
        '
        Me.TxtLandingId_edit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "landings.id", True))
        resources.ApplyResources(Me.TxtLandingId_edit, "TxtLandingId_edit")
        Me.TxtLandingId_edit.Name = "TxtLandingId_edit"
        '
        'txtTitleEdit
        '
        Me.txtTitleEdit.AllowDrop = True
        Me.txtTitleEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "landings.name", True))
        resources.ApplyResources(Me.txtTitleEdit, "txtTitleEdit")
        Me.txtTitleEdit.Name = "txtTitleEdit"
        '
        'lblTitleEdit
        '
        resources.ApplyResources(Me.lblTitleEdit, "lblTitleEdit")
        Me.lblTitleEdit.Name = "lblTitleEdit"
        '
        'OFDPicture
        '
        resources.ApplyResources(Me.OFDPicture, "OFDPicture")
        '
        'frmLandings
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.XtraTabControlTheme)
        Me.Name = "frmLandings"
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
        CType(Me.cmbKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtLandingId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabResult.ResumeLayout(False)
        CType(Me.GridLandings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewLandings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemChkStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEditLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEditThemeEvent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSite1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControlTheme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControlTheme.ResumeLayout(False)
        Me.tabDetail.ResumeLayout(False)
        Me.tabDetail.PerformLayout()
        CType(Me.imgLandingsSmartTV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLandingiPad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLandingiPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLogin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExpiratedDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExpiratedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLanding.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnOrdered.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbActifEN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbActifNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbActifFr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbKindEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtLandingId_edit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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

    Dim _PathPictureWrite As String
    Dim _PathPictureRead As String
    Const SERVERKEY As String = "SERVERPATH"
    Const LANDINGIDKEY As String = "ID"


    Enum StepForm
        EDIT
        [NEW]
        SAVE
        CANCEL
        INIT
        LOAD
    End Enum

    Private Sub save()
        PlushData.clsConnection.UpdateDataTableInDB(DsSite1.landings, _sql)
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
        GridViewLandings.OptionsView.ColumnAutoWidth = False
        GridViewLandings.OptionsBehavior.Editable = False

        XtraTabControlTheme.SelectedTabPage = tabSearch
        ' Misc_Bar.Visible = True

        Dim menuStrip As New PlushBuziness.contextMenu()
        GridLandings.ContextMenuStrip = menuStrip
        loadKind()
        loadActif()
        LoadLogin()

        Dim serverPath As String
        serverPath = PlushBuziness.clsPicture.getPathServerMapping()
        _PathPictureWrite = serverPath

        serverPath = PlushBuziness.clsPicture.getPathServer()
        _PathPictureRead = serverPath


        search()
        ChangeStep(StepForm.INIT)


    End Sub

    Private Sub LoadLogin()
        Dim sql As String
        Dim lstLogin As List(Of PlushBuziness.clsKeyComboEnum)
        sql = PlushData.clsLandings.GetEnumMysqlLogin()
        lstLogin = PlushBuziness.ClsCombo.GetListEnum(sql)

        cmbLogin.Properties.ValueMember = "Value"
        cmbLogin.Properties.DisplayMember = "DisplayMember"
        cmbLogin.Properties.DataSource = lstLogin

    End Sub

    Private Sub loadActif()
        Dim lstActifFR As List(Of PlushBuziness.clsKeyComboEnum)
        Dim lstActifNL As List(Of PlushBuziness.clsKeyComboEnum)
        Dim lstActifEN As List(Of PlushBuziness.clsKeyComboEnum)
        Dim sql As String

        sql = PlushData.clsLandings.GetEnumMysqlActif()
        lstActifFR = PlushBuziness.ClsCombo.GetListEnum(sql)

        cmbActifFr.Properties.ValueMember = "Value"
        cmbActifFr.Properties.DisplayMember = "DisplayMember"
        cmbActifFr.Properties.DataSource = lstActifFR

        lstActifNL = PlushBuziness.ClsCombo.GetListEnum(sql)

        cmbActifNL.Properties.ValueMember = "Value"
        cmbActifNL.Properties.DisplayMember = "DisplayMember"
        cmbActifNL.Properties.DataSource = lstActifNL

        lstActifEN = PlushBuziness.ClsCombo.GetListEnum(sql)

        cmbActifEN.Properties.ValueMember = "Value"
        cmbActifEN.Properties.DisplayMember = "DisplayMember"
        cmbActifEN.Properties.DataSource = lstActifEN

    End Sub
    Private Sub loadKind()
        Dim lstKind As List(Of PlushBuziness.clsKeyComboEnum)
        Dim lstKindEdit As List(Of PlushBuziness.clsKeyComboEnum)
        Dim sql As String

        sql = PlushData.clsLandings.GetEnumMysqlKind()
        lstKind = PlushBuziness.ClsCombo.GetListEnum(sql)

        cmbKind.Properties.ValueMember = "Value"
        cmbKind.Properties.DisplayMember = "DisplayMember"
        cmbKind.Properties.DataSource = lstKind

        lstKindEdit = PlushBuziness.ClsCombo.GetListEnum(sql)
        cmbKindEdit.Properties.ValueMember = "Value"
        cmbKindEdit.Properties.DisplayMember = "DisplayMember"
        cmbKindEdit.Properties.DataSource = lstKindEdit

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


        id = TxtLandingId.EditValue
        title = txtTitle.EditValue
        kind = cmbKind.EditValue

        DsSite1.landings.Clear()
        _sql = PlushData.clsLandings.GetSearch(id, title, kind)
        PlushData.clsConnection.FillDataSet(DsSite1.landings, _sql, )
        GridLandings.DataSource = DsSite1.landings


    End Sub

    Private Sub initForm()
        Dim blank As String = String.Empty
        txtTitleEdit.EditValue = blank
        txtExpiratedDate.EditValue = blank
        cmbKindEdit.EditValue = blank
        cmbActifFr.EditValue = blank
        cmbActifNL.EditValue = blank
        cmbActifEN.EditValue = blank

        txtReference.EditValue = blank
        cmbLogin.EditValue = blank
        spnOrdered.EditValue = 0

    End Sub

    Private Sub GridThemeEvent_doubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLandings.DoubleClick
        loadInfo()
        ChangeStep(StepForm.LOAD)
        RefreshPicture(imgLanding, TxtLandingId_edit.EditValue, PlushBuziness.clsPicture.TypePicture.landings_plush)
        RefreshPicture(imgLandingiPhone, TxtLandingId_edit.EditValue, PlushBuziness.clsPicture.TypePicture.landingsmobile_plush)
        RefreshPicture(imgLandingiPad, TxtLandingId_edit.EditValue, PlushBuziness.clsPicture.TypePicture.landingstablet_plush)
        RefreshPicture(imgLandingsSmartTV, TxtLandingId_edit.EditValue, PlushBuziness.clsPicture.TypePicture.landingssmarttv_plush)
    End Sub

    Private Sub loadInfo()
        Dim currentRow As DataRow

        If GridViewLandings.RowCount > 0 Then
            currentRow = GridViewLandings.GetDataRow(GridViewLandings.FocusedRowHandle())
            Dim index As Integer = DsSite1.landings.Rows.IndexOf(currentRow)
            Me.BindingContext(DsSite1, DsSite1.landings.TableName).Position = index
            XtraTabControlTheme.SelectedTabPage = tabDetail

        End If
    End Sub

    Private Sub insertData()

        Dim dr As DsSite.landingsRow
        dr = DsSite1.landings.NewRow()
        dr.id = PlushBuziness.ClsLandings.GetLastId()
        DsSite1.landings.AddlandingsRow(dr)
        Me.BindingContext(DsSite1, DsSite1.landings.TableName).Position = DsSite1.landings.Rows.Count - 1

    End Sub

    Private Function EnableField(ByVal ok As Boolean) As Boolean
        Dim enable As Boolean
        enable = ok

        txtTitleEdit.Enabled = enable

        cmbKindEdit.Enabled = enable
        cmbActifFr.Enabled = enable
        cmbActifNL.Enabled = enable
        cmbActifEN.Enabled = enable
        txtExpiratedDate.Enabled = enable
        cmbLogin.Enabled = enable
        spnOrdered.Enabled = enable
        txtReference.Enabled = enable

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
        Dim dr As DsSite.landingsRow
        drv = Me.BindingContext(DsSite1, DsSite1.landings.TableName).Current
        dr = drv.Row

        Me.BindingContext(DsSite1, DsSite1.landings.TableName).EndCurrentEdit()
        PlushData.clsConnection.UpdateDataTableInDB(DsSite1.landings, _sql)
        ChangeStep(StepForm.SAVE)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(DsSite1, DsSite1.landings.TableName).CancelCurrentEdit()
        ChangeStep(StepForm.CANCEL)

    End Sub

#Region "Picture"

    Private Sub imgLanding_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgLanding.DoubleClick
        'Dim img As DevExpress.XtraEditors.PictureEdit = sender
        'If img.Image IsNot Nothing Then
        '    img.Image.Dispose()
        '    img.Image = Nothing
        'End If



        If AddPicture(PlushBuziness.clsPicture.TypePicture.landings_plush) Then
            RefreshPicture(imgLanding, TxtLandingId_edit.EditValue, PlushBuziness.clsPicture.TypePicture.landings_plush)
        End If
    End Sub
    Private Sub RefreshPicture(ByVal img As DevExpress.XtraEditors.PictureEdit, ByVal landingId As Integer, ByVal tp_picture As PlushBuziness.clsPicture.TypePicture)

        Dim filePicture As FileInfo
        'If img.Image IsNot Nothing Then
        '    img.Image.Dispose()
        'End If
        filePicture = GetFullPathPicture(landingId, tp_picture, _PathPictureRead)

        If System.IO.File.Exists(filePicture.FullName) Then

            Dim myCallback As New Drawing.Image.GetThumbnailImageAbort(AddressOf thumbnailCallback)
            'img.Image = New Drawing.Bitmap(filePicture.FullName)

            Using temp As System.Drawing.Image = System.Drawing.Image.FromFile(filePicture.FullName)
                img.Image = New System.Drawing.Bitmap(temp)
            End Using
            'img.Image = System.Drawing.Image.FromFile(filePicture.FullName)
            'this method used for reduce picture if too large 
            img.Image = img.Image.GetThumbnailImage(img.Width, img.Height, myCallback, IntPtr.Zero)
        Else
            img.Image = Nothing
        End If
    End Sub

    Private Function AddPicture(ByVal tp_picture As PlushBuziness.clsPicture.TypePicture) As Boolean


        Dim FilePictureDestination As FileInfo
        Dim pathPictureSource As String
        Dim extension As String

        extension = PlushBuziness.clsPicture.GetExtension(tp_picture)
        OFDPicture.Filter = extension & "|*" & extension
        FilePictureDestination = GetFullPathPicture(TxtLandingId_edit.EditValue, tp_picture, _PathPictureWrite)
        If OFDPicture.ShowDialog() = Windows.Forms.DialogResult.OK Then

            pathPictureSource = OFDPicture.FileName
            'File.Open(FilePictureDestination.FullName, FileMode.Append)

            If Not Directory.Exists(FilePictureDestination.DirectoryName) Then
                Directory.CreateDirectory(FilePictureDestination.DirectoryName)
            End If
            'File.Decrypt(pathPictureSource)
            File.Copy(pathPictureSource, FilePictureDestination.FullName, True)
            Return True

        End If

        Return False

    End Function


    Private Function GetFullPathPicture(ByVal landingId As Integer, ByVal tp_picture As PlushBuziness.clsPicture.TypePicture, ByVal FullpathPicture As String) As FileInfo

        Dim pathPicture As String
        Dim TmpnameFilePicture As String

        pathPicture = FullpathPicture

        TmpnameFilePicture = landingId
        TmpnameFilePicture += PlushBuziness.clsPicture.GetExtension(tp_picture)
        Dim file As FileInfo = New FileInfo(pathPicture & PlushTools.clsEnum.getNameStrEnum(tp_picture) & "\" & TmpnameFilePicture)
        Return file

    End Function
    Private Function thumbnailCallback() As Boolean
        Return False
    End Function
#End Region
    Private Sub LoadDataSearch(ByVal sql As String)
        DsSite1.landings.Clear()
        PlushData.clsConnection.FillDataSet(DsSite1.landings, sql, )
        GridLandings.DataSource = DsSite1.landings

        tabDetail.PageVisible = False
        tabResult.PageVisible = True
        XtraTabControlTheme.SelectedTabPage = tabResult
    End Sub
    Private Sub btnPrivateProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrivateProd.Click
        _sql = PlushData.clsLandings.getPrivateSiteProduction()
        LoadDataSearch(_sql)
    End Sub

    Private Sub btnPrivateBeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrivateBeta.Click
        _sql = PlushData.clsLandings.getPrivateSiteBeta()
        LoadDataSearch(_sql)
    End Sub

    Private Sub btnPublicProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPublicProd.Click
        _sql = PlushData.clsLandings.getPublicSiteProduction()
        LoadDataSearch(_sql)
    End Sub

    Private Sub btnPublicBeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPublicBeta.Click
        _sql = PlushData.clsLandings.getPublicSiteBeta()
        LoadDataSearch(_sql)
    End Sub

    Private Sub imgLandingiPhone_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgLandingiPhone.DoubleClick
        If AddPicture(PlushBuziness.clsPicture.TypePicture.landingsmobile_plush) Then
            RefreshPicture(imgLandingiPhone, TxtLandingId_edit.EditValue, PlushBuziness.clsPicture.TypePicture.landingsmobile_plush)
        End If
    End Sub

    Private Sub imgLandingiPad_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgLandingiPad.DoubleClick
        If AddPicture(PlushBuziness.clsPicture.TypePicture.landingstablet_plush) Then
            RefreshPicture(imgLandingiPad, TxtLandingId_edit.EditValue, PlushBuziness.clsPicture.TypePicture.landingstablet_plush)
        End If
    End Sub

    Private Sub imgLandingsSmartTV_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgLandingsSmartTV.DoubleClick
        If AddPicture(PlushBuziness.clsPicture.TypePicture.landingssmarttv_plush) Then
            RefreshPicture(imgLandingsSmartTV, TxtLandingId_edit.EditValue, PlushBuziness.clsPicture.TypePicture.landingssmarttv_plush)
        End If
    End Sub

    Private Sub imgLandingsSmartTV_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgLandingsSmartTV.EditValueChanged

    End Sub
End Class



