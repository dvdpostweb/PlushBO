Imports System.IO
Imports System.Collections.Generic
Public Class frmSearchProduct
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

    Friend WithEvents lblTheme As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupSearch As DevExpress.XtraEditors.GroupControl

    Friend WithEvents lblCategorie As DevExpress.XtraEditors.LabelControl

    Friend WithEvents lblSelected As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkSelected As DevExpress.XtraEditors.CheckEdit

    Friend WithEvents ContextMenu1 As PlushBuziness.contextMenu
    Friend WithEvents DsSite1 As PlushLib.DsSite
    Friend WithEvents GridProducts As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewProducts As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmbStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbAvailability As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblAvailability As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemChkProductNext As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEditLanguage As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpCategorie As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbCategorie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbTheme As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbStudio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbSerie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbSubtitle As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblSubtitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbLanguage As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblLanguage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSerie As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblStudio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkProductNext As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbActor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblActors As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbRating As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblRating As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemLookUpEditStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEditAvailability As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEditSerie As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEditStudio As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSerie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStudio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductNext As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRating As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbProductType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblProductType As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colCptDvdOK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcpt_cust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbDirector As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblDirector As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbProductMedia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblProductMedia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colCustHigh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVodExists As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductsMedia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbActiveCustomers As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents customers_active As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_not_active As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvailability As DevExpress.XtraGrid.Columns.GridColumn




    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchProduct))
        Me.tabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.GroupSearch = New DevExpress.XtraEditors.GroupControl
        Me.cmbActiveCustomers = New System.Windows.Forms.ComboBox
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.cmbDirector = New DevExpress.XtraEditors.LookUpEdit
        Me.lblDirector = New DevExpress.XtraEditors.LabelControl
        Me.cmbProductMedia = New DevExpress.XtraEditors.LookUpEdit
        Me.lblProductMedia = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.cmbProductType = New DevExpress.XtraEditors.LookUpEdit
        Me.lblProductType = New DevExpress.XtraEditors.LabelControl
        Me.cmbRating = New DevExpress.XtraEditors.LookUpEdit
        Me.lblRating = New DevExpress.XtraEditors.LabelControl
        Me.chkProductNext = New DevExpress.XtraEditors.CheckEdit
        Me.cmbActor = New DevExpress.XtraEditors.LookUpEdit
        Me.lblActors = New DevExpress.XtraEditors.LabelControl
        Me.cmbStudio = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbSerie = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbSubtitle = New DevExpress.XtraEditors.LookUpEdit
        Me.lblSubtitle = New DevExpress.XtraEditors.LabelControl
        Me.cmbLanguage = New DevExpress.XtraEditors.LookUpEdit
        Me.lblLanguage = New DevExpress.XtraEditors.LabelControl
        Me.lblSerie = New DevExpress.XtraEditors.LabelControl
        Me.lblStudio = New DevExpress.XtraEditors.LabelControl
        Me.cmbTheme = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbCategorie = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbAvailability = New DevExpress.XtraEditors.LookUpEdit
        Me.lblAvailability = New DevExpress.XtraEditors.LabelControl
        Me.cmbStatus = New DevExpress.XtraEditors.LookUpEdit
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl
        Me.lblCategorie = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.lblTheme = New DevExpress.XtraEditors.LabelControl
        Me.tabResult = New DevExpress.XtraTab.XtraTabPage
        Me.GridProducts = New DevExpress.XtraGrid.GridControl
        Me.GridViewProducts = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEditStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colAvailability = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEditAvailability = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSerie = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEditSerie = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colStudio = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEditStudio = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colProductNext = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemChkProductNext = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colRating = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProductType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCptDvdOK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcpt_cust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_active = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_not_active = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCustHigh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVodExists = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProductsMedia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEditLanguage = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.DsSite1 = New PlushLib.DsSite
        Me.chkSelected = New DevExpress.XtraEditors.CheckEdit
        Me.lblSelected = New DevExpress.XtraEditors.LabelControl
        Me.ContextMenu1 = New PlushBuziness.contextMenu
        Me.XtraTabControlTheme = New DevExpress.XtraTab.XtraTabControl
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearch.SuspendLayout()
        CType(Me.GroupSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupSearch.SuspendLayout()
        CType(Me.cmbDirector.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductMedia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkProductNext.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbActor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSubtitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTheme.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCategorie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAvailability.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabResult.SuspendLayout()
        CType(Me.GridProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEditStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEditAvailability, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEditSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEditStudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemChkProductNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEditLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSite1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControlTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControlTheme.SuspendLayout()
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
        Me.GroupSearch.Controls.Add(Me.cmbActiveCustomers)
        Me.GroupSearch.Controls.Add(Me.LabelControl3)
        Me.GroupSearch.Controls.Add(Me.cmbDirector)
        Me.GroupSearch.Controls.Add(Me.lblDirector)
        Me.GroupSearch.Controls.Add(Me.cmbProductMedia)
        Me.GroupSearch.Controls.Add(Me.lblProductMedia)
        Me.GroupSearch.Controls.Add(Me.LabelControl2)
        Me.GroupSearch.Controls.Add(Me.txtToDate)
        Me.GroupSearch.Controls.Add(Me.LabelControl1)
        Me.GroupSearch.Controls.Add(Me.txtFromDate)
        Me.GroupSearch.Controls.Add(Me.cmbProductType)
        Me.GroupSearch.Controls.Add(Me.lblProductType)
        Me.GroupSearch.Controls.Add(Me.cmbRating)
        Me.GroupSearch.Controls.Add(Me.lblRating)
        Me.GroupSearch.Controls.Add(Me.chkProductNext)
        Me.GroupSearch.Controls.Add(Me.cmbActor)
        Me.GroupSearch.Controls.Add(Me.lblActors)
        Me.GroupSearch.Controls.Add(Me.cmbStudio)
        Me.GroupSearch.Controls.Add(Me.cmbSerie)
        Me.GroupSearch.Controls.Add(Me.cmbSubtitle)
        Me.GroupSearch.Controls.Add(Me.lblSubtitle)
        Me.GroupSearch.Controls.Add(Me.cmbLanguage)
        Me.GroupSearch.Controls.Add(Me.lblLanguage)
        Me.GroupSearch.Controls.Add(Me.lblSerie)
        Me.GroupSearch.Controls.Add(Me.lblStudio)
        Me.GroupSearch.Controls.Add(Me.cmbTheme)
        Me.GroupSearch.Controls.Add(Me.cmbCategorie)
        Me.GroupSearch.Controls.Add(Me.cmbAvailability)
        Me.GroupSearch.Controls.Add(Me.lblAvailability)
        Me.GroupSearch.Controls.Add(Me.cmbStatus)
        Me.GroupSearch.Controls.Add(Me.lblStatus)
        Me.GroupSearch.Controls.Add(Me.lblCategorie)
        Me.GroupSearch.Controls.Add(Me.btnSearch)
        Me.GroupSearch.Controls.Add(Me.lblTheme)
        Me.GroupSearch.Name = "GroupSearch"
        '
        'cmbActiveCustomers
        '
        Me.cmbActiveCustomers.FormattingEnabled = True
        Me.cmbActiveCustomers.Items.AddRange(New Object() {resources.GetString("cmbActiveCustomers.Items"), resources.GetString("cmbActiveCustomers.Items1")})
        resources.ApplyResources(Me.cmbActiveCustomers, "cmbActiveCustomers")
        Me.cmbActiveCustomers.Name = "cmbActiveCustomers"
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        '
        'cmbDirector
        '
        resources.ApplyResources(Me.cmbDirector, "cmbDirector")
        Me.cmbDirector.Name = "cmbDirector"
        Me.cmbDirector.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbDirector.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbDirector.Properties.NullText = resources.GetString("cmbDirector.Properties.NullText")
        '
        'lblDirector
        '
        resources.ApplyResources(Me.lblDirector, "lblDirector")
        Me.lblDirector.Name = "lblDirector"
        '
        'cmbProductMedia
        '
        resources.ApplyResources(Me.cmbProductMedia, "cmbProductMedia")
        Me.cmbProductMedia.Name = "cmbProductMedia"
        Me.cmbProductMedia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbProductMedia.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbProductMedia.Properties.NullText = resources.GetString("cmbProductMedia.Properties.NullText")
        '
        'lblProductMedia
        '
        resources.ApplyResources(Me.lblProductMedia, "lblProductMedia")
        Me.lblProductMedia.Name = "lblProductMedia"
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'txtToDate
        '
        Me.txtToDate.EditValue = Nothing
        resources.ApplyResources(Me.txtToDate, "txtToDate")
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtToDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        '
        'txtFromDate
        '
        Me.txtFromDate.EditValue = Nothing
        resources.ApplyResources(Me.txtFromDate, "txtFromDate")
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtFromDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtFromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'cmbProductType
        '
        resources.ApplyResources(Me.cmbProductType, "cmbProductType")
        Me.cmbProductType.Name = "cmbProductType"
        Me.cmbProductType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbProductType.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbProductType.Properties.NullText = resources.GetString("cmbProductType.Properties.NullText")
        '
        'lblProductType
        '
        resources.ApplyResources(Me.lblProductType, "lblProductType")
        Me.lblProductType.Name = "lblProductType"
        '
        'cmbRating
        '
        resources.ApplyResources(Me.cmbRating, "cmbRating")
        Me.cmbRating.Name = "cmbRating"
        Me.cmbRating.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbRating.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbRating.Properties.NullText = resources.GetString("cmbRating.Properties.NullText")
        '
        'lblRating
        '
        resources.ApplyResources(Me.lblRating, "lblRating")
        Me.lblRating.Name = "lblRating"
        '
        'chkProductNext
        '
        Me.chkProductNext.EditValue = Nothing
        resources.ApplyResources(Me.chkProductNext, "chkProductNext")
        Me.chkProductNext.Name = "chkProductNext"
        Me.chkProductNext.Properties.AllowGrayed = True
        Me.chkProductNext.Properties.Caption = resources.GetString("chkProductNext.Properties.Caption")
        Me.chkProductNext.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Inactive
        '
        'cmbActor
        '
        resources.ApplyResources(Me.cmbActor, "cmbActor")
        Me.cmbActor.Name = "cmbActor"
        Me.cmbActor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbActor.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbActor.Properties.NullText = resources.GetString("cmbActor.Properties.NullText")
        '
        'lblActors
        '
        resources.ApplyResources(Me.lblActors, "lblActors")
        Me.lblActors.Name = "lblActors"
        '
        'cmbStudio
        '
        Me.cmbStudio.AllowDrop = True
        resources.ApplyResources(Me.cmbStudio, "cmbStudio")
        Me.cmbStudio.Name = "cmbStudio"
        Me.cmbStudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbStudio.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbStudio.Properties.NullText = resources.GetString("cmbStudio.Properties.NullText")
        '
        'cmbSerie
        '
        resources.ApplyResources(Me.cmbSerie, "cmbSerie")
        Me.cmbSerie.Name = "cmbSerie"
        Me.cmbSerie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbSerie.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbSerie.Properties.NullText = resources.GetString("cmbSerie.Properties.NullText")
        '
        'cmbSubtitle
        '
        resources.ApplyResources(Me.cmbSubtitle, "cmbSubtitle")
        Me.cmbSubtitle.Name = "cmbSubtitle"
        Me.cmbSubtitle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbSubtitle.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbSubtitle.Properties.NullText = resources.GetString("cmbSubtitle.Properties.NullText")
        '
        'lblSubtitle
        '
        resources.ApplyResources(Me.lblSubtitle, "lblSubtitle")
        Me.lblSubtitle.Name = "lblSubtitle"
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
        'lblSerie
        '
        resources.ApplyResources(Me.lblSerie, "lblSerie")
        Me.lblSerie.Name = "lblSerie"
        '
        'lblStudio
        '
        resources.ApplyResources(Me.lblStudio, "lblStudio")
        Me.lblStudio.Name = "lblStudio"
        '
        'cmbTheme
        '
        resources.ApplyResources(Me.cmbTheme, "cmbTheme")
        Me.cmbTheme.Name = "cmbTheme"
        Me.cmbTheme.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbTheme.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbTheme.Properties.NullText = resources.GetString("cmbTheme.Properties.NullText")
        '
        'cmbCategorie
        '
        resources.ApplyResources(Me.cmbCategorie, "cmbCategorie")
        Me.cmbCategorie.Name = "cmbCategorie"
        Me.cmbCategorie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbCategorie.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbCategorie.Properties.NullText = resources.GetString("cmbCategorie.Properties.NullText")
        '
        'cmbAvailability
        '
        resources.ApplyResources(Me.cmbAvailability, "cmbAvailability")
        Me.cmbAvailability.Name = "cmbAvailability"
        Me.cmbAvailability.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbAvailability.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbAvailability.Properties.NullText = resources.GetString("cmbAvailability.Properties.NullText")
        '
        'lblAvailability
        '
        resources.ApplyResources(Me.lblAvailability, "lblAvailability")
        Me.lblAvailability.Name = "lblAvailability"
        '
        'cmbStatus
        '
        resources.ApplyResources(Me.cmbStatus, "cmbStatus")
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbStatus.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbStatus.Properties.NullText = resources.GetString("cmbStatus.Properties.NullText")
        '
        'lblStatus
        '
        resources.ApplyResources(Me.lblStatus, "lblStatus")
        Me.lblStatus.Name = "lblStatus"
        '
        'lblCategorie
        '
        resources.ApplyResources(Me.lblCategorie, "lblCategorie")
        Me.lblCategorie.Name = "lblCategorie"
        '
        'btnSearch
        '
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        Me.btnSearch.Name = "btnSearch"
        '
        'lblTheme
        '
        resources.ApplyResources(Me.lblTheme, "lblTheme")
        Me.lblTheme.Name = "lblTheme"
        '
        'tabResult
        '
        Me.tabResult.Controls.Add(Me.GridProducts)
        Me.tabResult.Name = "tabResult"
        resources.ApplyResources(Me.tabResult, "tabResult")
        '
        'GridProducts
        '
        resources.ApplyResources(Me.GridProducts, "GridProducts")
        Me.GridProducts.EmbeddedNavigator.Name = ""
        Me.GridProducts.FormsUseDefaultLookAndFeel = False
        Me.GridProducts.MainView = Me.GridViewProducts
        Me.GridProducts.Name = "GridProducts"
        Me.GridProducts.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemChkProductNext, Me.RepositoryItemLookUpEditLanguage, Me.RepositoryItemLookUpEditStatus, Me.RepositoryItemLookUpEditAvailability, Me.RepositoryItemLookUpEditSerie, Me.RepositoryItemLookUpEditStudio})
        Me.GridProducts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewProducts})
        '
        'GridViewProducts
        '
        Me.GridViewProducts.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colName, Me.colStatus, Me.colAvailability, Me.colSerie, Me.colStudio, Me.colProductNext, Me.colRating, Me.colProductType, Me.colCptDvdOK, Me.colcpt_cust, Me.coldate, Me.customers_active, Me.customers_not_active, Me.colCustHigh, Me.colVodExists, Me.colProductsMedia})
        Me.GridViewProducts.CustomizationFormBounds = New System.Drawing.Rectangle(1382, 593, 218, 205)
        Me.GridViewProducts.GridControl = Me.GridProducts
        Me.GridViewProducts.Name = "GridViewProducts"
        Me.GridViewProducts.OptionsView.ShowFooter = True
        Me.GridViewProducts.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colId, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colId
        '
        resources.ApplyResources(Me.colId, "colId")
        Me.colId.FieldName = "products_id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.ReadOnly = True
        Me.colId.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        '
        'colName
        '
        resources.ApplyResources(Me.colName, "colName")
        Me.colName.FieldName = "products_name"
        Me.colName.Name = "colName"
        Me.colName.OptionsColumn.ReadOnly = True
        '
        'colStatus
        '
        resources.ApplyResources(Me.colStatus, "colStatus")
        Me.colStatus.ColumnEdit = Me.RepositoryItemLookUpEditStatus
        Me.colStatus.FieldName = "products_status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemLookUpEditStatus
        '
        resources.ApplyResources(Me.RepositoryItemLookUpEditStatus, "RepositoryItemLookUpEditStatus")
        Me.RepositoryItemLookUpEditStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEditStatus.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemLookUpEditStatus.DisplayMember = "name"
        Me.RepositoryItemLookUpEditStatus.Name = "RepositoryItemLookUpEditStatus"
        Me.RepositoryItemLookUpEditStatus.ValueMember = "id"
        '
        'colAvailability
        '
        resources.ApplyResources(Me.colAvailability, "colAvailability")
        Me.colAvailability.ColumnEdit = Me.RepositoryItemLookUpEditAvailability
        Me.colAvailability.FieldName = "products_availability"
        Me.colAvailability.Name = "colAvailability"
        Me.colAvailability.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemLookUpEditAvailability
        '
        resources.ApplyResources(Me.RepositoryItemLookUpEditAvailability, "RepositoryItemLookUpEditAvailability")
        Me.RepositoryItemLookUpEditAvailability.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEditAvailability.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemLookUpEditAvailability.DisplayMember = "name"
        Me.RepositoryItemLookUpEditAvailability.Name = "RepositoryItemLookUpEditAvailability"
        Me.RepositoryItemLookUpEditAvailability.ValueMember = "id"
        '
        'colSerie
        '
        resources.ApplyResources(Me.colSerie, "colSerie")
        Me.colSerie.ColumnEdit = Me.RepositoryItemLookUpEditSerie
        Me.colSerie.FieldName = "products_series_id"
        Me.colSerie.Name = "colSerie"
        Me.colSerie.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemLookUpEditSerie
        '
        resources.ApplyResources(Me.RepositoryItemLookUpEditSerie, "RepositoryItemLookUpEditSerie")
        Me.RepositoryItemLookUpEditSerie.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEditSerie.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemLookUpEditSerie.DisplayMember = "name"
        Me.RepositoryItemLookUpEditSerie.Name = "RepositoryItemLookUpEditSerie"
        Me.RepositoryItemLookUpEditSerie.ValueMember = "id"
        '
        'colStudio
        '
        resources.ApplyResources(Me.colStudio, "colStudio")
        Me.colStudio.ColumnEdit = Me.RepositoryItemLookUpEditStudio
        Me.colStudio.FieldName = "products_studio"
        Me.colStudio.Name = "colStudio"
        Me.colStudio.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemLookUpEditStudio
        '
        resources.ApplyResources(Me.RepositoryItemLookUpEditStudio, "RepositoryItemLookUpEditStudio")
        Me.RepositoryItemLookUpEditStudio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEditStudio.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemLookUpEditStudio.DisplayMember = "name"
        Me.RepositoryItemLookUpEditStudio.Name = "RepositoryItemLookUpEditStudio"
        Me.RepositoryItemLookUpEditStudio.ValueMember = "id"
        '
        'colProductNext
        '
        resources.ApplyResources(Me.colProductNext, "colProductNext")
        Me.colProductNext.ColumnEdit = Me.RepositoryItemChkProductNext
        Me.colProductNext.FieldName = "products_next"
        Me.colProductNext.Name = "colProductNext"
        Me.colProductNext.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemChkProductNext
        '
        resources.ApplyResources(Me.RepositoryItemChkProductNext, "RepositoryItemChkProductNext")
        Me.RepositoryItemChkProductNext.Name = "RepositoryItemChkProductNext"
        Me.RepositoryItemChkProductNext.ValueChecked = 1
        Me.RepositoryItemChkProductNext.ValueUnchecked = 0
        '
        'colRating
        '
        resources.ApplyResources(Me.colRating, "colRating")
        Me.colRating.FieldName = "products_rating"
        Me.colRating.Name = "colRating"
        Me.colRating.OptionsColumn.ReadOnly = True
        '
        'colProductType
        '
        resources.ApplyResources(Me.colProductType, "colProductType")
        Me.colProductType.FieldName = "products_type"
        Me.colProductType.Name = "colProductType"
        Me.colProductType.OptionsColumn.ReadOnly = True
        '
        'colCptDvdOK
        '
        resources.ApplyResources(Me.colCptDvdOK, "colCptDvdOK")
        Me.colCptDvdOK.FieldName = "cpt_dvd"
        Me.colCptDvdOK.Name = "colCptDvdOK"
        '
        'colcpt_cust
        '
        resources.ApplyResources(Me.colcpt_cust, "colcpt_cust")
        Me.colcpt_cust.FieldName = "cpt_cust"
        Me.colcpt_cust.Name = "colcpt_cust"
        '
        'coldate
        '
        resources.ApplyResources(Me.coldate, "coldate")
        Me.coldate.FieldName = "products_date_added"
        Me.coldate.Name = "coldate"
        '
        'customers_active
        '
        resources.ApplyResources(Me.customers_active, "customers_active")
        Me.customers_active.FieldName = "customers_active"
        Me.customers_active.Name = "customers_active"
        '
        'customers_not_active
        '
        resources.ApplyResources(Me.customers_not_active, "customers_not_active")
        Me.customers_not_active.FieldName = "customers_not_active"
        Me.customers_not_active.Name = "customers_not_active"
        '
        'colCustHigh
        '
        resources.ApplyResources(Me.colCustHigh, "colCustHigh")
        Me.colCustHigh.FieldName = "cutomers_high"
        Me.colCustHigh.Name = "colCustHigh"
        '
        'colVodExists
        '
        resources.ApplyResources(Me.colVodExists, "colVodExists")
        Me.colVodExists.FieldName = "vod_exists"
        Me.colVodExists.Name = "colVodExists"
        '
        'colProductsMedia
        '
        resources.ApplyResources(Me.colProductsMedia, "colProductsMedia")
        Me.colProductsMedia.FieldName = "products_media"
        Me.colProductsMedia.Name = "colProductsMedia"
        '
        'RepositoryItemLookUpEditLanguage
        '
        resources.ApplyResources(Me.RepositoryItemLookUpEditLanguage, "RepositoryItemLookUpEditLanguage")
        Me.RepositoryItemLookUpEditLanguage.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEditLanguage.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemLookUpEditLanguage.Name = "RepositoryItemLookUpEditLanguage"
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
        Me.XtraTabControlTheme.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabSearch, Me.tabResult})
        '
        'frmSearchProduct
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.XtraTabControlTheme)
        Me.Name = "frmSearchProduct"
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
        CType(Me.cmbDirector.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductMedia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkProductNext.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbActor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSubtitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTheme.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCategorie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAvailability.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabResult.ResumeLayout(False)
        CType(Me.GridProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEditStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEditAvailability, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEditSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEditStudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemChkProductNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEditLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSite1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControlTheme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControlTheme.ResumeLayout(False)
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

    Dim WithEvents _ExportExcel As DevExpress.XtraBars.BarButtonItem = MainBtns_btnExcel
    Dim WithEvents SFDExportExcel As New System.Windows.Forms.SaveFileDialog

    Enum StepForm
        INIT
        LOAD
    End Enum


    Public Sub this_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        GridViewProducts.OptionsView.ColumnAutoWidth = False
        GridViewProducts.OptionsBehavior.Editable = False

        XtraTabControlTheme.SelectedTabPage = tabSearch
        ' Misc_Bar.Visible = True

        Misc_Bar.Visible = True
        Dim menuStrip As New PlushBuziness.contextMenu()
        GridProducts.ContextMenuStrip = menuStrip
        '        txtFromDate.DateTime = Now().ToString(txtFromDate.Properties.EditFormat.FormatString)
        '        txtToDate.DateTime = Now().ToString(txtFromDate.Properties.EditFormat.FormatString)

        loadProductsType()
        loadProductsMedia()
        loadRating()
        loadStatus()
        loadStudio()
        loadDirector()
        loadAvailability()
        loadSerie()
        loadLanguage()
        loadSubtitle()



    End Sub

    Private Sub loadRating()
        Dim dtRating As DataTable

        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "name"

        sql = PlushData.clsProductDvd.GetSelectRating()
        dtRating = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtRating)


        cmbRating.Properties.ValueMember = key
        cmbRating.Properties.DisplayMember = value
        cmbRating.Properties.DataSource = dtRating

        cmbRating.EditValue = 0

    End Sub
    Private Sub loadProductsType()
        Dim dtProductType As DataTable

        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "name"

        sql = PlushData.clsProductDvd.GetSelectType()
        dtProductType = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtProductType)


        cmbProductType.Properties.ValueMember = key
        cmbProductType.Properties.DisplayMember = value
        cmbProductType.Properties.DataSource = dtProductType

        cmbProductType.EditValue = 0

    End Sub
    Private Sub loadProductsMedia()
        Dim dtProductMedia As DataTable

        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "name"

        sql = PlushData.clsProductDvd.GetSelectMedia()
        dtProductMedia = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtProductMedia)


        cmbProductMedia.Properties.ValueMember = key
        cmbProductMedia.Properties.DisplayMember = value
        cmbProductMedia.Properties.DataSource = dtProductMedia

        cmbProductMedia.EditValue = 0

    End Sub
    Private Sub loadSubtitle()

        Dim key As String = "id"
        Dim value As String = "code"
        Dim dtSubtitle As DataTable
        Dim sql As String
        sql = PlushData.ClsVod.GetAllSubtitle()
        dtSubtitle = PlushData.clsConnection.FillDataSet(sql)

        cmbSubtitle.Properties.ValueMember = key
        cmbSubtitle.Properties.DisplayMember = value
        cmbSubtitle.Properties.DataSource = dtSubtitle

        cmbSubtitle.EditValue = 0

    End Sub
    Private Sub loadLanguage()
        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "code"
        Dim dtLanguage As DataTable


        sql = PlushData.ClsVod.GetAllLanguage()
        dtLanguage = PlushData.clsConnection.FillDataSet(sql)

        cmbLanguage.Properties.ValueMember = key
        cmbLanguage.Properties.DisplayMember = value
        cmbLanguage.Properties.DataSource = dtLanguage

        cmbLanguage.EditValue = 0
        RepositoryItemLookUpEditLanguage.ValueMember = key
        RepositoryItemLookUpEditLanguage.DisplayMember = value
        RepositoryItemLookUpEditLanguage.DataSource = dtLanguage


    End Sub
    Private Sub loadCategorie(ByVal products_type As String)
        Dim dtCategorie As DataTable

        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "name"

        sql = PlushData.clsProductDvd.GetSelectCategorie(products_type)
        dtCategorie = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtCategorie)


        cmbCategorie.Properties.ValueMember = key
        cmbCategorie.Properties.DisplayMember = value
        cmbCategorie.Properties.DataSource = dtCategorie

        cmbCategorie.EditValue = 0
    End Sub
    Private Sub loadTheme(ByVal products_type As String)
        Dim dtTheme As DataTable

        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "name"

        sql = PlushData.clsProductDvd.GetSelectTheme(products_type)
        dtTheme = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtTheme)


        cmbTheme.Properties.ValueMember = key
        cmbTheme.Properties.DisplayMember = value
        cmbTheme.Properties.DataSource = dtTheme

        cmbTheme.EditValue = 0

    End Sub
    Private Sub loadStatus()
        Dim dtStatus As DataTable

        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "name"

        sql = PlushData.clsProductDvd.GetSelectStatus()
        dtStatus = PlushData.clsConnection.FillDataSet(sql)
        ' value empty = -4 but the value 0 exist in this table
        PlushBuziness.ClsCombo.addRowEmpty(dtStatus, -4)


        cmbStatus.Properties.ValueMember = key
        cmbStatus.Properties.DisplayMember = value
        cmbStatus.Properties.DataSource = dtStatus
        ' strange if integer not set 
        cmbStatus.EditValue = "-4"

        RepositoryItemLookUpEditStatus.ValueMember = key
        RepositoryItemLookUpEditStatus.DisplayMember = value
        RepositoryItemLookUpEditStatus.DataSource = dtStatus
    End Sub
    Private Sub loadAvailability()
        Dim dtAvailability As DataTable

        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "name"

        sql = PlushData.clsProductDvd.GetSelectAvailability()
        dtAvailability = PlushData.clsConnection.FillDataSet(sql)
        ' value empty = -4 but the value 0 exist in this table
        PlushBuziness.ClsCombo.addRowEmpty(dtAvailability, -4)


        cmbAvailability.Properties.ValueMember = key
        cmbAvailability.Properties.DisplayMember = value
        cmbAvailability.Properties.DataSource = dtAvailability
        ' strange if integer not set 
        cmbAvailability.EditValue = "-4"

        RepositoryItemLookUpEditAvailability.ValueMember = key
        RepositoryItemLookUpEditAvailability.DisplayMember = value
        RepositoryItemLookUpEditAvailability.DataSource = dtAvailability
    End Sub
    Private Sub loadSerie()
        Dim dtSerie As DataTable

        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "name"

        sql = PlushData.clsProductDvd.GetSelectSerie()
        dtSerie = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtSerie)


        cmbSerie.Properties.ValueMember = key
        cmbSerie.Properties.DisplayMember = value
        cmbSerie.Properties.DataSource = dtSerie

        cmbSerie.EditValue = 0

        RepositoryItemLookUpEditSerie.ValueMember = key
        RepositoryItemLookUpEditSerie.DisplayMember = value
        RepositoryItemLookUpEditSerie.DataSource = dtSerie
    End Sub
    Private Sub loadStudio()
        Dim dtStudio As DataTable

        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "name"

        sql = PlushData.clsProductDvd.GetSelectStudio()
        dtStudio = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtStudio)


        cmbStudio.Properties.ValueMember = key
        cmbStudio.Properties.DisplayMember = value
        cmbStudio.Properties.DataSource = dtStudio

        cmbStudio.EditValue = 0
        RepositoryItemLookUpEditStudio.ValueMember = key
        RepositoryItemLookUpEditStudio.DisplayMember = value
        RepositoryItemLookUpEditStudio.DataSource = dtStudio
    End Sub
    Private Sub loadDirector()
        Dim dtDirector As DataTable

        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "name"

        sql = PlushData.clsProductDvd.GetSelectDirector()
        dtDirector = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtDirector)


        cmbDirector.Properties.ValueMember = key
        cmbDirector.Properties.DisplayMember = value
        cmbDirector.Properties.DataSource = dtDirector

        cmbDirector.EditValue = 0
        'RepositoryItemLookUpEditStudio.ValueMember = key
        'RepositoryItemLookUpEditStudio.DisplayMember = value
        'RepositoryItemLookUpEditStudio.DataSource = dtDirector
    End Sub
    Private Sub loadActor(ByVal products_type As String)
        Dim dtActor As DataTable

        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "name"

        sql = PlushData.clsProductDvd.GetSelectActor(products_type)
        dtActor = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtActor)

        cmbActor.Properties.ValueMember = key
        cmbActor.Properties.DisplayMember = value
        cmbActor.Properties.DataSource = dtActor

        cmbActor.EditValue = 0

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        search()
        tabResult.PageVisible = True
        XtraTabControlTheme.SelectedTabPage = tabResult
    End Sub

    Public Sub search()

        Dim sql As String
        Dim dt As DataTable
        Dim cust_active As String
        If cmbActiveCustomers.Text.Equals("Active") Then
            cust_active = " customers_abo = 1 and customers_abo_suspended <> 2 "
        Else
            cust_active = " ( customers_abo = 0 or customers_abo_suspended = 2 ) "
        End If

        sql = PlushData.clsProductDvd.getSelectSearchViewProduct(cmbCategorie.EditValue, _
                                                                   cmbTheme.EditValue, _
                                                                   cmbStatus.EditValue, _
                                                                   cmbAvailability.EditValue, _
                                                                   cmbSerie.EditValue, _
                                                                   cmbStudio.EditValue, _
                                                                   cmbLanguage.EditValue, _
                                                                   cmbSubtitle.EditValue, _
                                                                   cmbActor.EditValue, _
                                                                   cmbDirector.EditValue, _
                                                                   cmbRating.Text, _
                                                                   cmbProductType.Text, _
                                                                   cmbProductMedia.Text, _
                                                                   chkProductNext.CheckState, _
                                                                   txtFromDate.EditValue, _
                                                                   txtToDate.EditValue, _
                                                                   cust_active)


        '  _sql = DvdPostData.clsThemeTop.GetSearch(id, title, kind, theme_event)
        dt = PlushData.clsConnection.FillDataSet(sql)
        GridProducts.DataSource = dt

        clsDevExpress.AddHyperlinkDynamic(GridProducts)


    End Sub

    Private Sub cmbProductType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductType.EditValueChanged

        If cmbProductType.EditValue = 0 Then
            lblCategorie.Visible = False
            lblTheme.Visible = False
            lblActors.Visible = False

            cmbCategorie.Visible = False
            cmbTheme.Visible = False
            cmbActor.Visible = False

        Else
            lblCategorie.Visible = True
            lblTheme.Visible = True
            lblActors.Visible = True

            cmbCategorie.Visible = True
            cmbTheme.Visible = True
            cmbActor.Visible = True

            loadCategorie(cmbProductType.Text)
            loadTheme(cmbProductType.Text)
            loadActor(cmbProductType.Text)

        End If
    End Sub

    Private Sub btnexcel_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _ExportExcel.ItemClick
        SFDExportExcel.DefaultExt = "xls"
        SFDExportExcel.Filter = "Excel(*.xls)|*.xls"
        If SFDExportExcel.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GridProducts.ExportToXls(SFDExportExcel.FileName)
        End If
    End Sub
End Class



