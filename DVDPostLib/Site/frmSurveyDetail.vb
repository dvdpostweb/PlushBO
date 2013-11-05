Imports System.IO
Imports System.Collections.Generic
Public Class frmSurveyDetail
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



    Friend WithEvents lblSelected As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkSelected As DevExpress.XtraEditors.CheckEdit

    Friend WithEvents ContextMenu1 As PlushBuziness.contextMenu
    Friend WithEvents DsSite1 As PlushLib.DsSite
    Private WithEvents GridSurvey_Details As DevExpress.XtraGrid.GridControl
    Private WithEvents GridViewSurvey_Details As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveSurveyDetail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditSurveyDetail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNewSurveyDetail_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtSurvey_detailId_edit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbSurveyEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblSurveyEdit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblReference As DevExpress.XtraEditors.LabelControl
    Friend WithEvents imgSurveyDetail As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents OFDPicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GBFreeTxt As System.Windows.Forms.GroupBox
    Friend WithEvents txtTitleEditEN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitleEditEN As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitleEditNL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitleEditNL As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitleEditFR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitleEditFR As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spnRating As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GroupSearch As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbSurvey As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblSurvey As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtSurvey_DetailId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnNewSurveyDetail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblEventThemeId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbReference_id As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents RepositoryItemSurvey As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lblRating As DevExpress.XtraEditors.LabelControl




    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSurveyDetail))
        Me.tabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.GroupSearch = New DevExpress.XtraEditors.GroupControl
        Me.cmbSurvey = New DevExpress.XtraEditors.LookUpEdit
        Me.lblSurvey = New DevExpress.XtraEditors.LabelControl
        Me.TxtSurvey_DetailId = New DevExpress.XtraEditors.TextEdit
        Me.btnNewSurveyDetail = New DevExpress.XtraEditors.SimpleButton
        Me.lblEventThemeId = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.tabResult = New DevExpress.XtraTab.XtraTabPage
        Me.GridSurvey_Details = New DevExpress.XtraGrid.GridControl
        Me.GridViewSurvey_Details = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemSurvey = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.DsSite1 = New PlushLib.DsSite
        Me.chkSelected = New DevExpress.XtraEditors.CheckEdit
        Me.lblSelected = New DevExpress.XtraEditors.LabelControl
        Me.ContextMenu1 = New PlushBuziness.contextMenu
        Me.XtraTabControlTheme = New DevExpress.XtraTab.XtraTabControl
        Me.tabDetail = New DevExpress.XtraTab.XtraTabPage
        Me.cmbReference_id = New DevExpress.XtraEditors.LookUpEdit
        Me.spnRating = New DevExpress.XtraEditors.SpinEdit
        Me.lblRating = New DevExpress.XtraEditors.LabelControl
        Me.GBFreeTxt = New System.Windows.Forms.GroupBox
        Me.txtTitleEditEN = New DevExpress.XtraEditors.TextEdit
        Me.lblTitleEditEN = New DevExpress.XtraEditors.LabelControl
        Me.txtTitleEditNL = New DevExpress.XtraEditors.TextEdit
        Me.lblTitleEditNL = New DevExpress.XtraEditors.LabelControl
        Me.txtTitleEditFR = New DevExpress.XtraEditors.TextEdit
        Me.lblTitleEditFR = New DevExpress.XtraEditors.LabelControl
        Me.imgSurveyDetail = New DevExpress.XtraEditors.PictureEdit
        Me.lblReference = New DevExpress.XtraEditors.LabelControl
        Me.cmbSurveyEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.lblSurveyEdit = New DevExpress.XtraEditors.LabelControl
        Me.lblId = New DevExpress.XtraEditors.LabelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSaveSurveyDetail = New DevExpress.XtraEditors.SimpleButton
        Me.btnEditSurveyDetail = New DevExpress.XtraEditors.SimpleButton
        Me.btnNewSurveyDetail_edit = New DevExpress.XtraEditors.SimpleButton
        Me.TxtSurvey_detailId_edit = New DevExpress.XtraEditors.TextEdit
        Me.OFDPicture = New System.Windows.Forms.OpenFileDialog
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearch.SuspendLayout()
        CType(Me.GroupSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupSearch.SuspendLayout()
        CType(Me.cmbSurvey.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSurvey_DetailId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabResult.SuspendLayout()
        CType(Me.GridSurvey_Details, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSurvey_Details, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSurvey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSite1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControlTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControlTheme.SuspendLayout()
        Me.tabDetail.SuspendLayout()
        CType(Me.cmbReference_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBFreeTxt.SuspendLayout()
        CType(Me.txtTitleEditEN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleEditNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleEditFR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSurveyDetail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSurveyEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSurvey_detailId_edit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupSearch.Controls.Add(Me.cmbSurvey)
        Me.GroupSearch.Controls.Add(Me.lblSurvey)
        Me.GroupSearch.Controls.Add(Me.TxtSurvey_DetailId)
        Me.GroupSearch.Controls.Add(Me.btnNewSurveyDetail)
        Me.GroupSearch.Controls.Add(Me.lblEventThemeId)
        Me.GroupSearch.Controls.Add(Me.btnSearch)
        Me.GroupSearch.Name = "GroupSearch"
        '
        'cmbSurvey
        '
        resources.ApplyResources(Me.cmbSurvey, "cmbSurvey")
        Me.cmbSurvey.Name = "cmbSurvey"
        Me.cmbSurvey.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbSurvey.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbSurvey.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("title_fr", "Title_fr", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbSurvey.Properties.NullText = resources.GetString("cmbSurvey.Properties.NullText")
        '
        'lblSurvey
        '
        resources.ApplyResources(Me.lblSurvey, "lblSurvey")
        Me.lblSurvey.Name = "lblSurvey"
        '
        'TxtSurvey_DetailId
        '
        resources.ApplyResources(Me.TxtSurvey_DetailId, "TxtSurvey_DetailId")
        Me.TxtSurvey_DetailId.Name = "TxtSurvey_DetailId"
        Me.TxtSurvey_DetailId.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtSurvey_DetailId.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'btnNewSurveyDetail
        '
        resources.ApplyResources(Me.btnNewSurveyDetail, "btnNewSurveyDetail")
        Me.btnNewSurveyDetail.Name = "btnNewSurveyDetail"
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
        'tabResult
        '
        Me.tabResult.Controls.Add(Me.GridSurvey_Details)
        Me.tabResult.Name = "tabResult"
        resources.ApplyResources(Me.tabResult, "tabResult")
        '
        'GridSurvey_Details
        '
        resources.ApplyResources(Me.GridSurvey_Details, "GridSurvey_Details")
        Me.GridSurvey_Details.EmbeddedNavigator.Name = ""
        Me.GridSurvey_Details.FormsUseDefaultLookAndFeel = False
        Me.GridSurvey_Details.MainView = Me.GridViewSurvey_Details
        Me.GridSurvey_Details.Name = "GridSurvey_Details"
        Me.GridSurvey_Details.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSurvey})
        Me.GridSurvey_Details.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSurvey_Details})
        '
        'GridViewSurvey_Details
        '
        Me.GridViewSurvey_Details.GridControl = Me.GridSurvey_Details
        Me.GridViewSurvey_Details.Name = "GridViewSurvey_Details"
        Me.GridViewSurvey_Details.OptionsView.ShowFooter = True
        '
        'RepositoryItemSurvey
        '
        resources.ApplyResources(Me.RepositoryItemSurvey, "RepositoryItemSurvey")
        Me.RepositoryItemSurvey.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemSurvey.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemSurvey.Name = "RepositoryItemSurvey"
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
        Me.tabDetail.Controls.Add(Me.cmbReference_id)
        Me.tabDetail.Controls.Add(Me.spnRating)
        Me.tabDetail.Controls.Add(Me.lblRating)
        Me.tabDetail.Controls.Add(Me.GBFreeTxt)
        Me.tabDetail.Controls.Add(Me.imgSurveyDetail)
        Me.tabDetail.Controls.Add(Me.lblReference)
        Me.tabDetail.Controls.Add(Me.cmbSurveyEdit)
        Me.tabDetail.Controls.Add(Me.lblSurveyEdit)
        Me.tabDetail.Controls.Add(Me.lblId)
        Me.tabDetail.Controls.Add(Me.btnCancel)
        Me.tabDetail.Controls.Add(Me.btnSaveSurveyDetail)
        Me.tabDetail.Controls.Add(Me.btnEditSurveyDetail)
        Me.tabDetail.Controls.Add(Me.btnNewSurveyDetail_edit)
        Me.tabDetail.Controls.Add(Me.TxtSurvey_detailId_edit)
        Me.tabDetail.Name = "tabDetail"
        resources.ApplyResources(Me.tabDetail, "tabDetail")
        '
        'cmbReference_id
        '
        Me.cmbReference_id.AllowDrop = True
        Me.cmbReference_id.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Survey_Details.reference_id", True))
        resources.ApplyResources(Me.cmbReference_id, "cmbReference_id")
        Me.cmbReference_id.Name = "cmbReference_id"
        Me.cmbReference_id.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbReference_id.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbReference_id.Properties.NullText = resources.GetString("cmbReference_id.Properties.NullText")
        '
        'spnRating
        '
        Me.spnRating.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Survey_Details.rating", True))
        resources.ApplyResources(Me.spnRating, "spnRating")
        Me.spnRating.Name = "spnRating"
        Me.spnRating.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.spnRating.Properties.MaxLength = 1
        Me.spnRating.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lblRating
        '
        resources.ApplyResources(Me.lblRating, "lblRating")
        Me.lblRating.Name = "lblRating"
        '
        'GBFreeTxt
        '
        Me.GBFreeTxt.Controls.Add(Me.txtTitleEditEN)
        Me.GBFreeTxt.Controls.Add(Me.lblTitleEditEN)
        Me.GBFreeTxt.Controls.Add(Me.txtTitleEditNL)
        Me.GBFreeTxt.Controls.Add(Me.lblTitleEditNL)
        Me.GBFreeTxt.Controls.Add(Me.txtTitleEditFR)
        Me.GBFreeTxt.Controls.Add(Me.lblTitleEditFR)
        resources.ApplyResources(Me.GBFreeTxt, "GBFreeTxt")
        Me.GBFreeTxt.Name = "GBFreeTxt"
        Me.GBFreeTxt.TabStop = False
        '
        'txtTitleEditEN
        '
        Me.txtTitleEditEN.AllowDrop = True
        Me.txtTitleEditEN.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Survey_Details.free_text_en", True))
        resources.ApplyResources(Me.txtTitleEditEN, "txtTitleEditEN")
        Me.txtTitleEditEN.Name = "txtTitleEditEN"
        '
        'lblTitleEditEN
        '
        resources.ApplyResources(Me.lblTitleEditEN, "lblTitleEditEN")
        Me.lblTitleEditEN.Name = "lblTitleEditEN"
        '
        'txtTitleEditNL
        '
        Me.txtTitleEditNL.AllowDrop = True
        Me.txtTitleEditNL.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Survey_Details.free_text_nl", True))
        resources.ApplyResources(Me.txtTitleEditNL, "txtTitleEditNL")
        Me.txtTitleEditNL.Name = "txtTitleEditNL"
        '
        'lblTitleEditNL
        '
        resources.ApplyResources(Me.lblTitleEditNL, "lblTitleEditNL")
        Me.lblTitleEditNL.Name = "lblTitleEditNL"
        '
        'txtTitleEditFR
        '
        Me.txtTitleEditFR.AllowDrop = True
        Me.txtTitleEditFR.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Survey_Details.free_text_fr", True))
        resources.ApplyResources(Me.txtTitleEditFR, "txtTitleEditFR")
        Me.txtTitleEditFR.Name = "txtTitleEditFR"
        '
        'lblTitleEditFR
        '
        resources.ApplyResources(Me.lblTitleEditFR, "lblTitleEditFR")
        Me.lblTitleEditFR.Name = "lblTitleEditFR"
        '
        'imgSurveyDetail
        '
        resources.ApplyResources(Me.imgSurveyDetail, "imgSurveyDetail")
        Me.imgSurveyDetail.Name = "imgSurveyDetail"
        Me.imgSurveyDetail.Properties.ShowMenu = False
        '
        'lblReference
        '
        resources.ApplyResources(Me.lblReference, "lblReference")
        Me.lblReference.Name = "lblReference"
        '
        'cmbSurveyEdit
        '
        Me.cmbSurveyEdit.AllowDrop = True
        Me.cmbSurveyEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Survey_Details.survey_id", True))
        resources.ApplyResources(Me.cmbSurveyEdit, "cmbSurveyEdit")
        Me.cmbSurveyEdit.Name = "cmbSurveyEdit"
        Me.cmbSurveyEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbSurveyEdit.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbSurveyEdit.Properties.NullText = resources.GetString("cmbSurveyEdit.Properties.NullText")
        '
        'lblSurveyEdit
        '
        resources.ApplyResources(Me.lblSurveyEdit, "lblSurveyEdit")
        Me.lblSurveyEdit.Name = "lblSurveyEdit"
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
        'btnSaveSurveyDetail
        '
        resources.ApplyResources(Me.btnSaveSurveyDetail, "btnSaveSurveyDetail")
        Me.btnSaveSurveyDetail.Name = "btnSaveSurveyDetail"
        '
        'btnEditSurveyDetail
        '
        resources.ApplyResources(Me.btnEditSurveyDetail, "btnEditSurveyDetail")
        Me.btnEditSurveyDetail.Name = "btnEditSurveyDetail"
        '
        'btnNewSurveyDetail_edit
        '
        resources.ApplyResources(Me.btnNewSurveyDetail_edit, "btnNewSurveyDetail_edit")
        Me.btnNewSurveyDetail_edit.Name = "btnNewSurveyDetail_edit"
        '
        'TxtSurvey_detailId_edit
        '
        Me.TxtSurvey_detailId_edit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "Survey_Details.id", True))
        resources.ApplyResources(Me.TxtSurvey_detailId_edit, "TxtSurvey_detailId_edit")
        Me.TxtSurvey_detailId_edit.Name = "TxtSurvey_detailId_edit"
        '
        'OFDPicture
        '
        resources.ApplyResources(Me.OFDPicture, "OFDPicture")
        '
        'frmSurveyDetail
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.XtraTabControlTheme)
        Me.Name = "frmSurveyDetail"
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
        CType(Me.cmbSurvey.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSurvey_DetailId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabResult.ResumeLayout(False)
        CType(Me.GridSurvey_Details, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSurvey_Details, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSurvey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSite1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControlTheme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControlTheme.ResumeLayout(False)
        Me.tabDetail.ResumeLayout(False)
        Me.tabDetail.PerformLayout()
        CType(Me.cmbReference_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBFreeTxt.ResumeLayout(False)
        Me.GBFreeTxt.PerformLayout()
        CType(Me.txtTitleEditEN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleEditNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleEditFR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSurveyDetail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSurveyEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSurvey_detailId_edit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Const SurveyDetailKEY As String = "answer"


    Enum StepForm
        EDIT
        [NEW]
        SAVE
        CANCEL
        INIT
        LOAD
    End Enum

    Private Sub save()

        PlushData.clsConnection.UpdateDataTableInDB(DsSite1.Survey_Details, _sql)
    End Sub

    Private Sub ChangeStep(ByVal stepCurrent As StepForm)
        Select Case stepCurrent
            Case StepForm.CANCEL
                btnEditSurveyDetail.Enabled = True
                btnSaveSurveyDetail.Enabled = False
                btnNewSurveyDetail_edit.Enabled = True
                btnCancel.Enabled = False

                EnableField(False)

                tabSearch.PageVisible = True
                tabResult.PageVisible = True

            Case StepForm.EDIT
                btnEditSurveyDetail.Enabled = False
                btnSaveSurveyDetail.Enabled = True
                btnNewSurveyDetail_edit.Enabled = False
                btnCancel.Enabled = True

                EnableField(True)

                tabDetail.PageVisible = True
                tabResult.PageVisible = False

            Case StepForm.INIT
                btnEditSurveyDetail.Enabled = False
                btnSaveSurveyDetail.Enabled = False
                btnNewSurveyDetail_edit.Enabled = True
                btnCancel.Enabled = False
                EnableField(False)

                tabResult.PageVisible = False
                tabSearch.PageVisible = True
                tabDetail.PageVisible = False
                XtraTabControlTheme.SelectedTabPage = tabSearch


            Case StepForm.[NEW]
                btnEditSurveyDetail.Enabled = False
                btnSaveSurveyDetail.Enabled = True
                btnNewSurveyDetail_edit.Enabled = False
                btnCancel.Enabled = True
                EnableField(True)
                tabResult.PageVisible = False
                tabDetail.PageVisible = True
                XtraTabControlTheme.SelectedTabPage = tabDetail



            Case StepForm.SAVE
                btnEditSurveyDetail.Enabled = True
                btnSaveSurveyDetail.Enabled = False
                btnNewSurveyDetail_edit.Enabled = True
                btnCancel.Enabled = False
                EnableField(False)
                tabDetail.PageVisible = True
                tabResult.PageVisible = True

            Case StepForm.LOAD
                btnEditSurveyDetail.Enabled = True
                btnSaveSurveyDetail.Enabled = False
                btnNewSurveyDetail_edit.Enabled = True
                btnCancel.Enabled = False
                EnableField(False)

                tabDetail.PageVisible = True
                XtraTabControlTheme.SelectedTabPage = tabDetail

        End Select
    End Sub

    Public Sub this_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        GridViewSurvey_Details.OptionsView.ColumnAutoWidth = False
        GridViewSurvey_Details.OptionsBehavior.Editable = False

        XtraTabControlTheme.SelectedTabPage = tabSearch
        ' Misc_Bar.Visible = True

        Dim menuStrip As New PlushBuziness.contextMenu()
        GridSurvey_Details.ContextMenuStrip = menuStrip
        loadSurvey()

        Dim serverPath As String
        serverPath = PlushBuziness.clsPicture.getPathServerMapping()
        _PathPictureWrite = serverPath

        '  serverPath = DVDPostBuziness.clsPicture.getPathServer()
        _PathPictureRead = serverPath

        DsSite1.Survey_Details.created_atColumn.DefaultValue = DateTime.Now

        search()
        ChangeStep(StepForm.INIT)


    End Sub


    Private Sub loadSurvey()
        Dim dtSurvey As DataTable
        Dim dtSurveyEdit As DataTable
        Dim key As String = "id"
        Dim value As String = "title_fr"
        Dim sql As String

        sql = PlushData.clsSurveys.GetSurveys()

        dtSurvey = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtSurvey)

        cmbSurvey.Properties.ValueMember = key
        cmbSurvey.Properties.DisplayMember = value
        cmbSurvey.Properties.DataSource = dtSurvey

        RepositoryItemSurvey.ValueMember = key
        RepositoryItemSurvey.DisplayMember = value
        RepositoryItemSurvey.DataSource = dtSurvey

        dtSurveyEdit = PlushData.clsConnection.FillDataSet(sql)
        PlushBuziness.ClsCombo.addRowEmpty(dtSurveyEdit)
        cmbSurveyEdit.Properties.ValueMember = key
        cmbSurveyEdit.Properties.DisplayMember = value
        cmbSurveyEdit.Properties.DataSource = dtSurveyEdit



    End Sub


    Public Sub search()

        Dim id As Object
        Dim survey_id As Object
        'Dim  As Object


        id = TxtSurvey_DetailId.EditValue
        survey_id = cmbSurvey.EditValue

        DsSite1.Survey_Details.Clear()
        _sql = PlushData.clsSurveys.GetSearchSurveyDetails(id, survey_id)
        PlushData.clsConnection.FillDataSet(DsSite1.Survey_Details, _sql, )
        GridSurvey_Details.DataSource = DsSite1.Survey_Details

        GridViewSurvey_Details.Columns("survey_id").ColumnEdit = RepositoryItemSurvey

    End Sub

    Private Sub initForm()
        Dim blank As String = String.Empty
        cmbSurveyEdit.EditValue = blank


        cmbReference_id.EditValue = blank
        spnRating.EditValue = 0

    End Sub

    Private Sub GridThemeEvent_doubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridSurvey_Details.DoubleClick
        loadInfo()
        ChangeStep(StepForm.LOAD)
        'RefreshPicture(imgLanding, TxtLandingId_edit.EditValue, DVDPostBuziness.clsPicture.TypePicture.SurveyDetails)
    End Sub
    Private Function getKindSurvey(ByVal survey_id As Integer) As Integer
        Dim sql As String
        Dim kind_id As Integer
        sql = PlushData.clsSurveys.GetKindOfSurvey(survey_id)
        kind_id = PlushData.clsConnection.ExecuteScalar(sql)

        Return kind_id
    End Function
    Private Sub LoadDataKind(ByVal kind_id As PlushData.clsSurveys.kind)

        Dim sql As String
        Select Case kind_id
            Case PlushData.clsSurveys.kind.ACTORS
                sql = PlushData.clsActors.GetSelectList()

            Case PlushData.clsSurveys.kind.DIRECTORS
                sql = PlushData.clsDirectors.GetSelectList()
            Case PlushData.clsSurveys.kind.PRODUCTS
                sql = PlushData.clsProducts.GetSelectList()

            Case Else
                Return
        End Select

        lblReference.Text = PlushTools.clsEnum.getNameStrEnum(kind_id)
        Dim dt As DataTable
        dt = PlushData.clsConnection.FillDataSet(sql)
        cmbReference_id.Properties.ValueMember = "id"
        cmbReference_id.Properties.DisplayMember = "name"
        cmbReference_id.Properties.DataSource = dt

    End Sub
    Private Sub loadInfoSurvey(ByVal survey_id As Integer)
        Dim kind_id As Integer

        kind_id = getKindSurvey(survey_id)
        If kind_id = PlushData.clsSurveys.kind.FREE Then
            GBFreeTxt.Visible = True
            cmbReference_id.Visible = False
            lblReference.Visible = False
        Else
            cmbReference_id.Visible = True
            lblReference.Visible = True
            GBFreeTxt.Visible = False
            LoadDataKind(kind_id)
        End If

    End Sub
    Private Sub loadInfo()
        Dim currentRow As DataRow

        If GridViewSurvey_Details.RowCount > 0 Then
            currentRow = GridViewSurvey_Details.GetDataRow(GridViewSurvey_Details.FocusedRowHandle())
            Dim index As Integer = DsSite1.Survey_Details.Rows.IndexOf(currentRow)
            Me.BindingContext(DsSite1, DsSite1.Survey_Details.TableName).Position = index
            XtraTabControlTheme.SelectedTabPage = tabDetail

            loadInfoSurvey(currentRow("survey_id"))
            RefreshPicture(imgSurveyDetail, currentRow("id"), PlushBuziness.clsPicture.TypePicture.surveys)
        End If

    End Sub

    Private Sub insertData()

        Dim dr As DsSite.Survey_DetailsRow
        dr = DsSite1.Survey_Details.NewRow()
        dr.id = PlushBuziness.ClsSurveys.GetLastIdDetail()
        DsSite1.Survey_Details.AddSurvey_DetailsRow(dr)
        Me.BindingContext(DsSite1, DsSite1.Survey_Details.TableName).Position = DsSite1.Survey_Details.Rows.Count - 1

    End Sub

    Private Function EnableField(ByVal ok As Boolean) As Boolean
        Dim enable As Boolean
        enable = ok


        cmbSurveyEdit.Enabled = enable
        spnRating.Enabled = enable
        cmbReference_id.Enabled = enable
        imgSurveyDetail.Enabled = enable
        GBFreeTxt.Enabled = enable
        Return ok
    End Function

    Private Sub btnEditSurveyDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditSurveyDetail.Click
        ChangeStep(StepForm.EDIT)

    End Sub

    Private Sub btnNewSurveyDetail_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewSurveyDetail_edit.Click

        insertData()
        ChangeStep(StepForm.[NEW])
    End Sub

    Private Sub btnSaveSurveyDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSurveyDetail.Click

        Dim drv As DataRowView
        Dim dr As DsSite.Survey_DetailsRow
        drv = Me.BindingContext(DsSite1, DsSite1.Survey_Details.TableName).Current
        dr = drv.Row
        dr.updated_at = DateTime.Now
        Me.BindingContext(DsSite1, DsSite1.Survey_Details.TableName).EndCurrentEdit()
        PlushData.clsConnection.UpdateDataTableInDB(DsSite1.Survey_Details, _sql)
        ChangeStep(StepForm.SAVE)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(DsSite1, DsSite1.Survey_Details.TableName).CancelCurrentEdit()
        ChangeStep(StepForm.CANCEL)

    End Sub

#Region "Picture"

    Private Sub imgLanding_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgSurveyDetail.DoubleClick
        'Dim img As DevExpress.XtraEditors.PictureEdit = sender
        'If img.Image IsNot Nothing Then
        '    img.Image.Dispose()
        '    img.Image = Nothing
        'End If



        If AddPicture(PlushBuziness.clsPicture.TypePicture.surveys) Then
            RefreshPicture(imgSurveyDetail, TxtSurvey_detailId_edit.EditValue, PlushBuziness.clsPicture.TypePicture.surveys)
        End If
    End Sub
    Private Sub RefreshPicture(ByVal img As DevExpress.XtraEditors.PictureEdit, ByVal survey_detailId As Integer, ByVal tp_picture As PlushBuziness.clsPicture.TypePicture)

        Dim filePicture As FileInfo
        'If img.Image IsNot Nothing Then
        '    img.Image.Dispose()
        'End If
        filePicture = GetFullPathPicture(survey_detailId, tp_picture, _PathPictureRead)

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

        extension = PlushBuziness.clsPicture.GetExtension(PlushBuziness.clsPicture.TypePicture.survey_detail)
        OFDPicture.Filter = extension & "|*" & extension
        FilePictureDestination = GetFullPathPicture(TxtSurvey_detailId_edit.EditValue, tp_picture, _PathPictureWrite)
        If OFDPicture.ShowDialog() = Windows.Forms.DialogResult.OK Then

            pathPictureSource = OFDPicture.FileName
            'File.Open(FilePictureDestination.FullName, FileMode.Append)

            If Not Directory.Exists(FilePictureDestination.DirectoryName) Then
                Directory.CreateDirectory(FilePictureDestination.DirectoryName)
            End If

            File.Copy(pathPictureSource, FilePictureDestination.FullName, True)
            Return True

        End If

        Return False

    End Function


    Private Function GetFullPathPicture(ByVal survey_DetailId As Integer, ByVal tp_picture As PlushBuziness.clsPicture.TypePicture, ByVal FullpathPicture As String) As FileInfo

        Dim pathPicture As String
        Dim TmpnameFilePicture As String

        pathPicture = FullpathPicture

        TmpnameFilePicture = survey_DetailId
        TmpnameFilePicture += PlushBuziness.clsPicture.GetExtension(PlushBuziness.clsPicture.TypePicture.survey_detail)
        Dim file As FileInfo = New FileInfo(pathPicture & PlushTools.clsEnum.getNameStrEnum(tp_picture) & "\" & SurveyDetailKEY & "\" & TmpnameFilePicture)
        Return file

    End Function
    Private Function thumbnailCallback() As Boolean
        Return False
    End Function
#End Region
    Private Sub LoadDataSearch(ByVal sql As String)
        DsSite1.Survey_Details.Clear()
        PlushData.clsConnection.FillDataSet(DsSite1.Survey_Details, sql, )
        GridSurvey_Details.DataSource = DsSite1.Survey_Details

        tabDetail.PageVisible = False
        tabResult.PageVisible = True
        XtraTabControlTheme.SelectedTabPage = tabResult
    End Sub


    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        search()

        tabDetail.PageVisible = False
        tabResult.PageVisible = True
        XtraTabControlTheme.SelectedTabPage = tabResult
    End Sub

    Private Sub btnNewSurveyDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewSurveyDetail.Click
        insertData()
        ChangeStep(StepForm.[NEW])
    End Sub


    Private Sub cmbSurveyEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSurveyEdit.EditValueChanged
        loadInfoSurvey(cmbSurveyEdit.EditValue)
    End Sub
End Class



