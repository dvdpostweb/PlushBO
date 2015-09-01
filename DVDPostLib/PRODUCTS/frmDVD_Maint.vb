Imports BizzLib.clsGlobal.ObjectState
Imports System.Windows.Forms.Application
Imports System.Threading
Imports System.Windows.Forms
Imports System.Collections.Generic


Public Class frmDVD_Maint
    Inherits BizzLib.frmGeneral_Maintenance

    Private Class ComboParam
        Public LTable As DataTable
        Public LSQLStr As String
        Public Sub New(ByVal vTable As DataTable, ByVal vSQLSTr As String)
            LTable = vTable
            LSQLStr = vSQLSTr
        End Sub
    End Class
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
    Friend WithEvents XTabControlProduct As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabMain As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabFR As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabNL As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabEN As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabLanguages As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabCategories As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblProductID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtModel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblModel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateAdded As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateAdded As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDateAvailable As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtYear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblYear As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRunTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblRunTime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblcountry As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbcountry As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbStudio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblStudio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPublic As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbPictureFormat As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPictureFormat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbDirector As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblDirector As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpSeries As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblSeries As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbSerie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtSerieNbr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSerieNbr As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpImage As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpActors As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnActorsMaint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridProductsDVD As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSearch As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents objDS As PlushLib.dsProducts
    Friend WithEvents colproducts_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents collanguage_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_model As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbLanguages As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbProducts_Media As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbProducts_Status As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbProducts_Type As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbRating As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbPublic As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PictProducts_Image As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents grpLanguage As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents grpSubTitles As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tabTrailers As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridActors As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewActors As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colproducts_id1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colactors_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbActors As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnLang As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSubTitles As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BandedGridColumn5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridViewLanguages As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents cmbLanguages1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colproducts_id2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_languages_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridViewUndertitles As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents cmbUndertitles As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colproducts_id3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_undertitles_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridUndertitles As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridLanguages As DevExpress.XtraGrid.GridControl
    Friend WithEvents grpTrailers As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitterControl3 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtURLFr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtImageFR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pictFR As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtDescFR As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtDescNL As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pictNL As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtImageNL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtURLNl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescEN As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents pictEN As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtImageEN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtURLEn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNameEN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkSelectCategory As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colcategories_id As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colparent_id As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colcategories_type As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colcategories_name As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents txtAwardFR As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtAwardEN As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtAwardNL As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents colcategory_selected As DevExpress.XtraTreeList.Columns.TreeListColumn
    Public WithEvents TreeListCategories As DevExpress.XtraTreeList.TreeList
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCategories As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCopy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkInCinemaNow As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTitleSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIMDB_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbProducts_product_type As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDeleteFromliste As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabVod As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCancelVod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbLanguageSubtitle As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbLanguageSound As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbDateExpired As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbDateStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtFilename As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkAvailable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblAvailable As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNameFile As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateExpired As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateStart As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLanguage_subtitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLanguageSound As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtImdbView As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblImdbView As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSaveVod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditVod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSearchImdb_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblImdb_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnUnlock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtImdb_id_serie As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblImdb_id_serie As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryIProductProducts_id As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabCritiques As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblValueNbCritiquePositive As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNbCritiquePositive As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValueNbCrtitiques As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNbCritiques As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValueRatingAverage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRatingAverage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridCritiques As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCritiques As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblValueNBRating As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNbRating As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblImdbId_serie As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSearchImdbId_serie As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkVodNext As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblDirectorSearch As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDirectorSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tabVodWishlist As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridVODWishlist As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewVODWishlist As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand12 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents grpVOD As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl61 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVODAudio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl60 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents imgIMDBID_2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents imgIMDBID_1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents imgIMDBID_6 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents imgIMDBID_5 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents imgIMDBID_4 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents imgIMDBID_3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GridStreamingTrailers As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdvBandedGridView2 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand13 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents BandedGridColumn8 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BandedGridColumn9 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn10 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents BandedGridColumn7 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents chkVodNextNL As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtEpisodeID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSeasonID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkVodNextLU As DevExpress.XtraEditors.CheckEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim FilterCondition2 As DevExpress.XtraTreeList.FilterCondition = New DevExpress.XtraTreeList.FilterCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colcategory_selected = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.chkSelectCategory = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.XTabControlProduct = New DevExpress.XtraTab.XtraTabControl
        Me.tabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.GridProductsDVD = New DevExpress.XtraGrid.GridControl
        Me.objDS = New PlushLib.dsProducts
        Me.GridViewSearch = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colproducts_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryIProductProducts_id = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.collanguage_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbLanguages = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colproducts_name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_model = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn7 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.lblDirectorSearch = New DevExpress.XtraEditors.LabelControl
        Me.txtDirectorSearch = New DevExpress.XtraEditors.TextEdit
        Me.lblImdbId_serie = New DevExpress.XtraEditors.LabelControl
        Me.txtSearchImdbId_serie = New DevExpress.XtraEditors.TextEdit
        Me.btnUnlock = New DevExpress.XtraEditors.SimpleButton
        Me.txtSearchImdb_id = New DevExpress.XtraEditors.TextEdit
        Me.lblImdb_id = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.txtTitleSearch = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.tabMain = New DevExpress.XtraTab.XtraTabPage
        Me.grpVOD = New DevExpress.XtraEditors.GroupControl
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl61 = New DevExpress.XtraEditors.LabelControl
        Me.txtVODAudio = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl60 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.btnDeleteFromliste = New DevExpress.XtraEditors.SimpleButton
        Me.btnCopy = New DevExpress.XtraEditors.SimpleButton
        Me.grpActors = New DevExpress.XtraEditors.GroupControl
        Me.GridActors = New DevExpress.XtraGrid.GridControl
        Me.GridViewActors = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colproducts_id1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colactors_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbActors = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnActorsMaint = New DevExpress.XtraEditors.SimpleButton
        Me.grpImage = New DevExpress.XtraEditors.GroupControl
        Me.PictProducts_Image = New DevExpress.XtraEditors.PictureEdit
        Me.grpSeries = New DevExpress.XtraEditors.GroupControl
        Me.txtImdb_id_serie = New DevExpress.XtraEditors.TextEdit
        Me.lblImdb_id_serie = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.txtSerieNbr = New DevExpress.XtraEditors.TextEdit
        Me.lblSerieNbr = New DevExpress.XtraEditors.LabelControl
        Me.cmbSerie = New DevExpress.XtraEditors.LookUpEdit
        Me.lblSeries = New DevExpress.XtraEditors.LabelControl
        Me.grpMain = New DevExpress.XtraEditors.GroupControl
        Me.txtEpisodeID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtSeasonID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.chkVodNextNL = New DevExpress.XtraEditors.CheckEdit
        Me.chkVodNextLU = New DevExpress.XtraEditors.CheckEdit
        Me.chkVodNext = New DevExpress.XtraEditors.CheckEdit
        Me.cmbProducts_product_type = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl
        Me.txtIMDB_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit
        Me.chkInCinemaNow = New DevExpress.XtraEditors.CheckEdit
        Me.cmbRating = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.cmbProducts_Media = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.cmbProducts_Type = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.cmbProducts_Status = New DevExpress.XtraEditors.LookUpEdit
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl
        Me.cmbDirector = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbPictureFormat = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPictureFormat = New DevExpress.XtraEditors.LabelControl
        Me.cmbPublic = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPublic = New DevExpress.XtraEditors.LabelControl
        Me.cmbStudio = New DevExpress.XtraEditors.LookUpEdit
        Me.lblStudio = New DevExpress.XtraEditors.LabelControl
        Me.cmbcountry = New DevExpress.XtraEditors.LookUpEdit
        Me.lblcountry = New DevExpress.XtraEditors.LabelControl
        Me.txtRunTime = New DevExpress.XtraEditors.TextEdit
        Me.lblRunTime = New DevExpress.XtraEditors.LabelControl
        Me.txtYear = New DevExpress.XtraEditors.TextEdit
        Me.lblYear = New DevExpress.XtraEditors.LabelControl
        Me.txtDateAvailable = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtDateAdded = New DevExpress.XtraEditors.DateEdit
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl
        Me.txtModel = New DevExpress.XtraEditors.TextEdit
        Me.lblModel = New DevExpress.XtraEditors.LabelControl
        Me.txtProductID = New DevExpress.XtraEditors.TextEdit
        Me.lblProductID = New DevExpress.XtraEditors.LabelControl
        Me.tabFR = New DevExpress.XtraTab.XtraTabPage
        Me.txtAwardFR = New DevExpress.XtraEditors.MemoEdit
        Me.txtDescFR = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.pictFR = New DevExpress.XtraEditors.PictureEdit
        Me.txtImageFR = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.txtURLFr = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.txtNameFR = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.tabNL = New DevExpress.XtraTab.XtraTabPage
        Me.txtAwardNL = New DevExpress.XtraEditors.MemoEdit
        Me.txtDescNL = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.pictNL = New DevExpress.XtraEditors.PictureEdit
        Me.txtImageNL = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.txtURLNl = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.txtNameNL = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.tabEN = New DevExpress.XtraTab.XtraTabPage
        Me.txtAwardEN = New DevExpress.XtraEditors.MemoEdit
        Me.txtDescEN = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.pictEN = New DevExpress.XtraEditors.PictureEdit
        Me.txtImageEN = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.txtURLEn = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.txtNameEN = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl
        Me.tabCategories = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl
        Me.TreeListCategories = New DevExpress.XtraTreeList.TreeList
        Me.colcategories_id = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colparent_id = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colcategories_type = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colcategories_name = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl
        Me.btnCategories = New DevExpress.XtraEditors.SimpleButton
        Me.tabLanguages = New DevExpress.XtraTab.XtraTabPage
        Me.grpSubTitles = New DevExpress.XtraEditors.GroupControl
        Me.GridUndertitles = New DevExpress.XtraGrid.GridControl
        Me.GridViewUndertitles = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colproducts_id3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_undertitles_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbUndertitles = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.btnSubTitles = New DevExpress.XtraEditors.SimpleButton
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl
        Me.grpLanguage = New DevExpress.XtraEditors.GroupControl
        Me.GridLanguages = New DevExpress.XtraGrid.GridControl
        Me.GridViewLanguages = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colproducts_id2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_languages_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbLanguages1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.btnLang = New DevExpress.XtraEditors.SimpleButton
        Me.tabTrailers = New DevExpress.XtraTab.XtraTabPage
        Me.SplitterControl3 = New DevExpress.XtraEditors.SplitterControl
        Me.grpTrailers = New DevExpress.XtraEditors.GroupControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GridStreamingTrailers = New DevExpress.XtraGrid.GridControl
        Me.AdvBandedGridView2 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand13 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.BandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn8 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn9 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn10 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl
        Me.tabVod = New DevExpress.XtraTab.XtraTabPage
        Me.txtId = New DevExpress.XtraEditors.TextEdit
        Me.btnCancelVod = New DevExpress.XtraEditors.SimpleButton
        Me.cmbLanguageSubtitle = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbLanguageSound = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbDateExpired = New DevExpress.XtraEditors.DateEdit
        Me.cmbDateStart = New DevExpress.XtraEditors.DateEdit
        Me.TxtFilename = New DevExpress.XtraEditors.TextEdit
        Me.chkAvailable = New DevExpress.XtraEditors.CheckEdit
        Me.lblAvailable = New DevExpress.XtraEditors.LabelControl
        Me.lblNameFile = New DevExpress.XtraEditors.LabelControl
        Me.lblDateExpired = New DevExpress.XtraEditors.LabelControl
        Me.lblDateStart = New DevExpress.XtraEditors.LabelControl
        Me.lblLanguage_subtitle = New DevExpress.XtraEditors.LabelControl
        Me.lblLanguageSound = New DevExpress.XtraEditors.LabelControl
        Me.txtImdbView = New DevExpress.XtraEditors.TextEdit
        Me.lblImdbView = New DevExpress.XtraEditors.LabelControl
        Me.btnSaveVod = New DevExpress.XtraEditors.SimpleButton
        Me.btnEditVod = New DevExpress.XtraEditors.SimpleButton
        Me.tabCritiques = New DevExpress.XtraTab.XtraTabPage
        Me.lblValueNBRating = New DevExpress.XtraEditors.LabelControl
        Me.lblNbRating = New DevExpress.XtraEditors.LabelControl
        Me.lblValueNbCritiquePositive = New DevExpress.XtraEditors.LabelControl
        Me.lblNbCritiquePositive = New DevExpress.XtraEditors.LabelControl
        Me.lblValueNbCrtitiques = New DevExpress.XtraEditors.LabelControl
        Me.lblNbCritiques = New DevExpress.XtraEditors.LabelControl
        Me.lblValueRatingAverage = New DevExpress.XtraEditors.LabelControl
        Me.lblRatingAverage = New DevExpress.XtraEditors.LabelControl
        Me.GridCritiques = New DevExpress.XtraGrid.GridControl
        Me.GridViewCritiques = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tabVodWishlist = New DevExpress.XtraTab.XtraTabPage
        Me.GridVODWishlist = New DevExpress.XtraGrid.GridControl
        Me.gridViewVODWishlist = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand12 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.imgIMDBID_5 = New DevExpress.XtraEditors.PictureEdit
        Me.imgIMDBID_4 = New DevExpress.XtraEditors.PictureEdit
        Me.imgIMDBID_3 = New DevExpress.XtraEditors.PictureEdit
        Me.imgIMDBID_2 = New DevExpress.XtraEditors.PictureEdit
        Me.imgIMDBID_1 = New DevExpress.XtraEditors.PictureEdit
        Me.BandedGridColumn6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelectCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XTabControlProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabControlProduct.SuspendLayout()
        Me.tabSearch.SuspendLayout()
        CType(Me.GridProductsDVD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryIProductProducts_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtDirectorSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearchImdbId_serie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearchImdb_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        CType(Me.grpVOD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpVOD.SuspendLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVODAudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.grpActors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpActors.SuspendLayout()
        CType(Me.GridActors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewActors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbActors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grpImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpImage.SuspendLayout()
        CType(Me.PictProducts_Image.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSeries.SuspendLayout()
        CType(Me.txtImdb_id_serie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieNbr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        CType(Me.txtEpisodeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSeasonID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVodNextNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVodNextLU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVodNext.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProducts_product_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIMDB_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInCinemaNow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProducts_Media.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProducts_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProducts_Status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDirector.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPictureFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPublic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbcountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRunTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateAvailable.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateAvailable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateAdded.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateAdded.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFR.SuspendLayout()
        CType(Me.txtAwardFR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescFR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictFR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImageFR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtURLFr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameFR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNL.SuspendLayout()
        CType(Me.txtAwardNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImageNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtURLNl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEN.SuspendLayout()
        CType(Me.txtAwardEN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescEN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictEN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImageEN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtURLEn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameEN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCategories.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.TreeListCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl11.SuspendLayout()
        Me.tabLanguages.SuspendLayout()
        CType(Me.grpSubTitles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSubTitles.SuspendLayout()
        CType(Me.GridUndertitles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewUndertitles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUndertitles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.grpLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLanguage.SuspendLayout()
        CType(Me.GridLanguages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewLanguages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguages1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        Me.tabTrailers.SuspendLayout()
        CType(Me.grpTrailers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTrailers.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GridStreamingTrailers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabVod.SuspendLayout()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguageSubtitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguageSound.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateExpired.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateExpired.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFilename.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAvailable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImdbView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCritiques.SuspendLayout()
        CType(Me.GridCritiques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCritiques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabVodWishlist.SuspendLayout()
        CType(Me.GridVODWishlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewVODWishlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgIMDBID_5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgIMDBID_4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgIMDBID_3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgIMDBID_2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgIMDBID_1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl10.SuspendLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PopMenuNew
        '
        '
        'PopMenuEdit
        '
        '
        'PopMenuSave
        '
        '
        'PopMenuUndo
        '
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 756)
        '
        'colcategory_selected
        '
        Me.colcategory_selected.Caption = "category_selected"
        Me.colcategory_selected.ColumnEdit = Me.chkSelectCategory
        Me.colcategory_selected.FieldName = "category_selected"
        Me.colcategory_selected.Name = "colcategory_selected"
        Me.colcategory_selected.Visible = True
        Me.colcategory_selected.VisibleIndex = 2
        '
        'chkSelectCategory
        '
        Me.chkSelectCategory.AutoHeight = False
        Me.chkSelectCategory.Name = "chkSelectCategory"
        Me.chkSelectCategory.ValueChecked = 1
        Me.chkSelectCategory.ValueUnchecked = 0
        '
        'XTabControlProduct
        '
        Me.XTabControlProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTabControlProduct.Location = New System.Drawing.Point(0, 96)
        Me.XTabControlProduct.Name = "XTabControlProduct"
        Me.XTabControlProduct.SelectedTabPage = Me.tabSearch
        Me.XTabControlProduct.Size = New System.Drawing.Size(1056, 660)
        Me.XTabControlProduct.TabIndex = 35
        Me.XTabControlProduct.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabSearch, Me.tabMain, Me.tabFR, Me.tabNL, Me.tabEN, Me.tabCategories, Me.tabLanguages, Me.tabTrailers, Me.tabVod, Me.tabCritiques, Me.tabVodWishlist})
        Me.XTabControlProduct.Text = "XtraTabControl1"
        '
        'tabSearch
        '
        Me.tabSearch.Controls.Add(Me.GridProductsDVD)
        Me.tabSearch.Controls.Add(Me.PanelControl2)
        Me.tabSearch.Name = "tabSearch"
        Me.tabSearch.Size = New System.Drawing.Size(1047, 629)
        Me.tabSearch.Text = "Search"
        '
        'GridProductsDVD
        '
        Me.GridProductsDVD.DataSource = Me.objDS.products_description1
        Me.GridProductsDVD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridProductsDVD.EmbeddedNavigator.Name = ""
        Me.GridProductsDVD.FormsUseDefaultLookAndFeel = False
        Me.GridProductsDVD.Location = New System.Drawing.Point(0, 134)
        Me.GridProductsDVD.MainView = Me.GridViewSearch
        Me.GridProductsDVD.Name = "GridProductsDVD"
        Me.GridProductsDVD.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbLanguages, Me.RepositoryIProductProducts_id})
        Me.GridProductsDVD.Size = New System.Drawing.Size(1047, 495)
        Me.GridProductsDVD.TabIndex = 3
        Me.GridProductsDVD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSearch})
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsProducts"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridViewSearch
        '
        Me.GridViewSearch.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridViewSearch.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colproducts_id, Me.collanguage_id, Me.colproducts_name, Me.colproducts_model, Me.BandedGridColumn7})
        Me.GridViewSearch.GridControl = Me.GridProductsDVD
        Me.GridViewSearch.Name = "GridViewSearch"
        Me.GridViewSearch.OptionsView.ShowAutoFilterRow = True
        Me.GridViewSearch.OptionsView.ShowBands = False
        Me.GridViewSearch.OptionsView.ShowFooter = True
        Me.GridViewSearch.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colproducts_model, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colproducts_id)
        Me.GridBand1.Columns.Add(Me.collanguage_id)
        Me.GridBand1.Columns.Add(Me.colproducts_name)
        Me.GridBand1.Columns.Add(Me.colproducts_model)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn7)
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 774
        '
        'colproducts_id
        '
        Me.colproducts_id.Caption = "products_id"
        Me.colproducts_id.ColumnEdit = Me.RepositoryIProductProducts_id
        Me.colproducts_id.FieldName = "products_id"
        Me.colproducts_id.Name = "colproducts_id"
        Me.colproducts_id.Visible = True
        '
        'RepositoryIProductProducts_id
        '
        Me.RepositoryIProductProducts_id.AutoHeight = False
        Me.RepositoryIProductProducts_id.Name = "RepositoryIProductProducts_id"
        '
        'collanguage_id
        '
        Me.collanguage_id.Caption = "language_id"
        Me.collanguage_id.ColumnEdit = Me.cmbLanguages
        Me.collanguage_id.FieldName = "language_id"
        Me.collanguage_id.Name = "collanguage_id"
        Me.collanguage_id.OptionsColumn.AllowEdit = False
        Me.collanguage_id.Visible = True
        Me.collanguage_id.Width = 84
        '
        'cmbLanguages
        '
        Me.cmbLanguages.AutoHeight = False
        Me.cmbLanguages.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguages.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "languages_id", 82, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 32, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbLanguages.DataSource = Me.objDS.languages
        Me.cmbLanguages.DisplayMember = "name"
        Me.cmbLanguages.Name = "cmbLanguages"
        Me.cmbLanguages.ValueMember = "languages_id"
        '
        'colproducts_name
        '
        Me.colproducts_name.Caption = "products_name"
        Me.colproducts_name.FieldName = "products_name"
        Me.colproducts_name.Name = "colproducts_name"
        Me.colproducts_name.OptionsColumn.AllowEdit = False
        Me.colproducts_name.Visible = True
        Me.colproducts_name.Width = 326
        '
        'colproducts_model
        '
        Me.colproducts_model.Caption = "products_model"
        Me.colproducts_model.FieldName = "products_model"
        Me.colproducts_model.Name = "colproducts_model"
        Me.colproducts_model.OptionsColumn.AllowEdit = False
        Me.colproducts_model.Visible = True
        Me.colproducts_model.Width = 144
        '
        'BandedGridColumn7
        '
        Me.BandedGridColumn7.Caption = "products_media"
        Me.BandedGridColumn7.FieldName = "products_media"
        Me.BandedGridColumn7.Name = "BandedGridColumn7"
        Me.BandedGridColumn7.Visible = True
        Me.BandedGridColumn7.Width = 145
        '
        'PanelControl2
        '
        Me.PanelControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl2.Controls.Add(Me.lblDirectorSearch)
        Me.PanelControl2.Controls.Add(Me.txtDirectorSearch)
        Me.PanelControl2.Controls.Add(Me.lblImdbId_serie)
        Me.PanelControl2.Controls.Add(Me.txtSearchImdbId_serie)
        Me.PanelControl2.Controls.Add(Me.btnUnlock)
        Me.PanelControl2.Controls.Add(Me.txtSearchImdb_id)
        Me.PanelControl2.Controls.Add(Me.lblImdb_id)
        Me.PanelControl2.Controls.Add(Me.btnSearch)
        Me.PanelControl2.Controls.Add(Me.txtTitleSearch)
        Me.PanelControl2.Controls.Add(Me.LabelControl7)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1047, 134)
        Me.PanelControl2.TabIndex = 2
        '
        'lblDirectorSearch
        '
        Me.lblDirectorSearch.Location = New System.Drawing.Point(782, 43)
        Me.lblDirectorSearch.Name = "lblDirectorSearch"
        Me.lblDirectorSearch.Size = New System.Drawing.Size(38, 13)
        Me.lblDirectorSearch.TabIndex = 75
        Me.lblDirectorSearch.Text = "Director"
        '
        'txtDirectorSearch
        '
        Me.txtDirectorSearch.Location = New System.Drawing.Point(826, 39)
        Me.txtDirectorSearch.Name = "txtDirectorSearch"
        Me.txtDirectorSearch.Size = New System.Drawing.Size(134, 20)
        Me.txtDirectorSearch.TabIndex = 74
        '
        'lblImdbId_serie
        '
        Me.lblImdbId_serie.Location = New System.Drawing.Point(248, 42)
        Me.lblImdbId_serie.Name = "lblImdbId_serie"
        Me.lblImdbId_serie.Size = New System.Drawing.Size(65, 13)
        Me.lblImdbId_serie.TabIndex = 69
        Me.lblImdbId_serie.Text = "imdb_id_serie"
        '
        'txtSearchImdbId_serie
        '
        Me.txtSearchImdbId_serie.Location = New System.Drawing.Point(321, 39)
        Me.txtSearchImdbId_serie.Name = "txtSearchImdbId_serie"
        Me.txtSearchImdbId_serie.Size = New System.Drawing.Size(99, 20)
        Me.txtSearchImdbId_serie.TabIndex = 68
        '
        'btnUnlock
        '
        Me.btnUnlock.Appearance.BackColor = System.Drawing.Color.White
        Me.btnUnlock.Appearance.BackColor2 = System.Drawing.Color.White
        Me.btnUnlock.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnlock.Appearance.Options.UseBackColor = True
        Me.btnUnlock.Appearance.Options.UseFont = True
        Me.btnUnlock.Location = New System.Drawing.Point(4, 4)
        Me.btnUnlock.Name = "btnUnlock"
        Me.HelpProvider1.SetShowHelp(Me.btnUnlock, True)
        Me.btnUnlock.Size = New System.Drawing.Size(75, 64)
        Me.btnUnlock.TabIndex = 64
        Me.btnUnlock.Text = "unlock"
        Me.btnUnlock.Visible = False
        '
        'txtSearchImdb_id
        '
        Me.txtSearchImdb_id.Location = New System.Drawing.Point(128, 36)
        Me.txtSearchImdb_id.Name = "txtSearchImdb_id"
        Me.txtSearchImdb_id.Size = New System.Drawing.Size(99, 20)
        Me.txtSearchImdb_id.TabIndex = 11
        '
        'lblImdb_id
        '
        Me.lblImdb_id.Location = New System.Drawing.Point(9, 39)
        Me.lblImdb_id.Name = "lblImdb_id"
        Me.lblImdb_id.Size = New System.Drawing.Size(38, 13)
        Me.lblImdb_id.TabIndex = 10
        Me.lblImdb_id.Text = "Imdb ID"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(966, 36)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Search"
        '
        'txtTitleSearch
        '
        Me.txtTitleSearch.Location = New System.Drawing.Point(129, 8)
        Me.txtTitleSearch.Name = "txtTitleSearch"
        Me.txtTitleSearch.Size = New System.Drawing.Size(472, 20)
        Me.txtTitleSearch.TabIndex = 8
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(8, 16)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl7.TabIndex = 2
        Me.LabelControl7.Text = "Part of Title"
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.grpVOD)
        Me.tabMain.Controls.Add(Me.GroupControl2)
        Me.tabMain.Controls.Add(Me.PanelControl3)
        Me.tabMain.Controls.Add(Me.grpActors)
        Me.tabMain.Controls.Add(Me.grpImage)
        Me.tabMain.Controls.Add(Me.grpSeries)
        Me.tabMain.Controls.Add(Me.grpMain)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Size = New System.Drawing.Size(1047, 629)
        Me.tabMain.Text = "General Info"
        '
        'grpVOD
        '
        Me.grpVOD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpVOD.Controls.Add(Me.TextEdit4)
        Me.grpVOD.Controls.Add(Me.LabelControl61)
        Me.grpVOD.Controls.Add(Me.txtVODAudio)
        Me.grpVOD.Controls.Add(Me.LabelControl60)
        Me.grpVOD.Location = New System.Drawing.Point(733, 41)
        Me.grpVOD.Name = "grpVOD"
        Me.grpVOD.Size = New System.Drawing.Size(265, 90)
        Me.grpVOD.TabIndex = 6
        Me.grpVOD.Text = "VOD"
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "streaming_products.subtitle", True))
        Me.TextEdit4.EditValue = ""
        Me.TextEdit4.Enabled = False
        Me.TextEdit4.Location = New System.Drawing.Point(63, 56)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(197, 20)
        Me.TextEdit4.TabIndex = 53
        '
        'LabelControl61
        '
        Me.LabelControl61.Location = New System.Drawing.Point(8, 60)
        Me.LabelControl61.Name = "LabelControl61"
        Me.LabelControl61.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl61.TabIndex = 52
        Me.LabelControl61.Text = "Subtitle"
        '
        'txtVODAudio
        '
        Me.txtVODAudio.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "streaming_products.audio", True))
        Me.txtVODAudio.EditValue = ""
        Me.txtVODAudio.Enabled = False
        Me.txtVODAudio.Location = New System.Drawing.Point(63, 32)
        Me.txtVODAudio.Name = "txtVODAudio"
        Me.txtVODAudio.Size = New System.Drawing.Size(197, 20)
        Me.txtVODAudio.TabIndex = 51
        '
        'LabelControl60
        '
        Me.LabelControl60.Location = New System.Drawing.Point(8, 36)
        Me.LabelControl60.Name = "LabelControl60"
        Me.LabelControl60.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl60.TabIndex = 50
        Me.LabelControl60.Text = "Audio"
        '
        'GroupControl2
        '
        Me.GroupControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl2.Controls.Add(Me.MemoEdit1)
        Me.GroupControl2.Location = New System.Drawing.Point(8, 511)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(992, 179)
        Me.GroupControl2.TabIndex = 5
        Me.GroupControl2.Text = "Espace de Travail"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit1.Location = New System.Drawing.Point(2, 20)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(988, 157)
        Me.MemoEdit1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl3.Controls.Add(Me.btnDeleteFromliste)
        Me.PanelControl3.Controls.Add(Me.btnCopy)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1047, 32)
        Me.PanelControl3.TabIndex = 4
        '
        'btnDeleteFromliste
        '
        Me.btnDeleteFromliste.Location = New System.Drawing.Point(386, 9)
        Me.btnDeleteFromliste.Name = "btnDeleteFromliste"
        Me.btnDeleteFromliste.Size = New System.Drawing.Size(105, 23)
        Me.btnDeleteFromliste.TabIndex = 3
        Me.btnDeleteFromliste.Text = "Erase of the list"
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(305, 9)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 2
        Me.btnCopy.Text = "Copy"
        '
        'grpActors
        '
        Me.grpActors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpActors.Controls.Add(Me.GridActors)
        Me.grpActors.Controls.Add(Me.PanelControl1)
        Me.grpActors.Location = New System.Drawing.Point(728, 138)
        Me.grpActors.Name = "grpActors"
        Me.grpActors.Size = New System.Drawing.Size(272, 280)
        Me.grpActors.TabIndex = 3
        Me.grpActors.Text = "Actors"
        '
        'GridActors
        '
        Me.GridActors.DataSource = Me.objDS.products_to_actors
        Me.GridActors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridActors.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridActors.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridActors.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridActors.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridActors.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridActors.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridActors.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridActors.EmbeddedNavigator.Enabled = False
        Me.GridActors.EmbeddedNavigator.Name = ""
        Me.GridActors.FormsUseDefaultLookAndFeel = False
        Me.GridActors.Location = New System.Drawing.Point(2, 20)
        Me.GridActors.MainView = Me.GridViewActors
        Me.GridActors.Name = "GridActors"
        Me.GridActors.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbActors})
        Me.GridActors.Size = New System.Drawing.Size(268, 218)
        Me.GridActors.TabIndex = 0
        Me.GridActors.UseEmbeddedNavigator = True
        Me.GridActors.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewActors})
        '
        'GridViewActors
        '
        Me.GridViewActors.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.GridViewActors.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colproducts_id1, Me.colactors_id})
        Me.GridViewActors.CustomizationFormBounds = New System.Drawing.Rectangle(755, 333, 217, 222)
        Me.GridViewActors.GridControl = Me.GridActors
        Me.GridViewActors.Name = "GridViewActors"
        Me.GridViewActors.OptionsBehavior.Editable = False
        Me.GridViewActors.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridViewActors.OptionsView.ShowBands = False
        Me.GridViewActors.OptionsView.ShowGroupPanel = False
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "GridBand2"
        Me.GridBand2.Columns.Add(Me.colproducts_id1)
        Me.GridBand2.Columns.Add(Me.colactors_id)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 170
        '
        'colproducts_id1
        '
        Me.colproducts_id1.Caption = "products_id"
        Me.colproducts_id1.FieldName = "products_id"
        Me.colproducts_id1.Name = "colproducts_id1"
        '
        'colactors_id
        '
        Me.colactors_id.Caption = "actors_id"
        Me.colactors_id.ColumnEdit = Me.cmbActors
        Me.colactors_id.FieldName = "actors_id"
        Me.colactors_id.Name = "colactors_id"
        Me.colactors_id.Visible = True
        Me.colactors_id.Width = 170
        '
        'cmbActors
        '
        Me.cmbActors.AutoHeight = False
        Me.cmbActors.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbActors.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("actors_id", "actors_id", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("actors_name", "actors_name", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbActors.DataSource = Me.objDS.actors
        Me.cmbActors.DisplayMember = "actors_name"
        Me.cmbActors.Name = "cmbActors"
        Me.cmbActors.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbActors.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.cmbActors.ValidateOnEnterKey = True
        Me.cmbActors.ValueMember = "actors_id"
        '
        'PanelControl1
        '
        Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl1.Controls.Add(Me.btnActorsMaint)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(2, 238)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(268, 40)
        Me.PanelControl1.TabIndex = 1
        '
        'btnActorsMaint
        '
        Me.btnActorsMaint.Location = New System.Drawing.Point(48, 8)
        Me.btnActorsMaint.Name = "btnActorsMaint"
        Me.btnActorsMaint.Size = New System.Drawing.Size(96, 23)
        Me.btnActorsMaint.TabIndex = 0
        Me.btnActorsMaint.Text = "Manage Actors"
        '
        'grpImage
        '
        Me.grpImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpImage.Controls.Add(Me.PictProducts_Image)
        Me.grpImage.Location = New System.Drawing.Point(456, 256)
        Me.grpImage.Name = "grpImage"
        Me.grpImage.Size = New System.Drawing.Size(264, 249)
        Me.grpImage.TabIndex = 2
        Me.grpImage.Text = "Small Image"
        '
        'PictProducts_Image
        '
        Me.PictProducts_Image.Location = New System.Drawing.Point(88, 56)
        Me.PictProducts_Image.Name = "PictProducts_Image"
        Me.PictProducts_Image.Properties.ReadOnly = True
        Me.PictProducts_Image.Size = New System.Drawing.Size(100, 136)
        Me.PictProducts_Image.TabIndex = 5
        '
        'grpSeries
        '
        Me.grpSeries.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpSeries.Controls.Add(Me.txtImdb_id_serie)
        Me.grpSeries.Controls.Add(Me.lblImdb_id_serie)
        Me.grpSeries.Controls.Add(Me.LabelControl13)
        Me.grpSeries.Controls.Add(Me.txtSerieNbr)
        Me.grpSeries.Controls.Add(Me.lblSerieNbr)
        Me.grpSeries.Controls.Add(Me.cmbSerie)
        Me.grpSeries.Controls.Add(Me.lblSeries)
        Me.grpSeries.Location = New System.Drawing.Point(456, 40)
        Me.grpSeries.Name = "grpSeries"
        Me.grpSeries.Size = New System.Drawing.Size(264, 208)
        Me.grpSeries.TabIndex = 1
        Me.grpSeries.Text = "Series Info"
        '
        'txtImdb_id_serie
        '
        Me.txtImdb_id_serie.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.imdb_id_serie", True))
        Me.txtImdb_id_serie.EditValue = "0"
        Me.txtImdb_id_serie.Enabled = False
        Me.txtImdb_id_serie.Location = New System.Drawing.Point(96, 153)
        Me.txtImdb_id_serie.Name = "txtImdb_id_serie"
        Me.txtImdb_id_serie.Size = New System.Drawing.Size(160, 20)
        Me.txtImdb_id_serie.TabIndex = 52
        '
        'lblImdb_id_serie
        '
        Me.lblImdb_id_serie.Location = New System.Drawing.Point(7, 156)
        Me.lblImdb_id_serie.Name = "lblImdb_id_serie"
        Me.lblImdb_id_serie.Size = New System.Drawing.Size(66, 13)
        Me.lblImdb_id_serie.TabIndex = 53
        Me.lblImdb_id_serie.Text = "IMDB ID Serie"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(8, 24)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl13.TabIndex = 35
        Me.LabelControl13.Text = "For WEB Site"
        '
        'txtSerieNbr
        '
        Me.txtSerieNbr.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_series_number", True))
        Me.txtSerieNbr.Enabled = False
        Me.txtSerieNbr.Location = New System.Drawing.Point(96, 64)
        Me.txtSerieNbr.Name = "txtSerieNbr"
        Me.txtSerieNbr.Size = New System.Drawing.Size(160, 20)
        Me.txtSerieNbr.TabIndex = 1
        '
        'lblSerieNbr
        '
        Me.lblSerieNbr.Location = New System.Drawing.Point(8, 64)
        Me.lblSerieNbr.Name = "lblSerieNbr"
        Me.lblSerieNbr.Size = New System.Drawing.Size(44, 13)
        Me.lblSerieNbr.TabIndex = 29
        Me.lblSerieNbr.Text = "Serie Nbr"
        '
        'cmbSerie
        '
        Me.cmbSerie.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_series_id", True))
        Me.cmbSerie.Enabled = False
        Me.cmbSerie.Location = New System.Drawing.Point(96, 40)
        Me.cmbSerie.Name = "cmbSerie"
        Me.cmbSerie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.cmbSerie.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_id", "series_id", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_name", "series_name", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbSerie.Properties.DataSource = Me.objDS.series
        Me.cmbSerie.Properties.DisplayMember = "series_name"
        Me.cmbSerie.Properties.NullText = ""
        Me.cmbSerie.Properties.ValueMember = "series_id"
        Me.cmbSerie.Size = New System.Drawing.Size(160, 20)
        Me.cmbSerie.TabIndex = 0
        '
        'lblSeries
        '
        Me.lblSeries.Location = New System.Drawing.Point(8, 40)
        Me.lblSeries.Name = "lblSeries"
        Me.lblSeries.Size = New System.Drawing.Size(24, 13)
        Me.lblSeries.TabIndex = 12
        Me.lblSeries.Text = "Serie"
        '
        'grpMain
        '
        Me.grpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpMain.Controls.Add(Me.txtEpisodeID)
        Me.grpMain.Controls.Add(Me.LabelControl8)
        Me.grpMain.Controls.Add(Me.txtSeasonID)
        Me.grpMain.Controls.Add(Me.LabelControl1)
        Me.grpMain.Controls.Add(Me.chkVodNextNL)
        Me.grpMain.Controls.Add(Me.chkVodNextLU)
        Me.grpMain.Controls.Add(Me.chkVodNext)
        Me.grpMain.Controls.Add(Me.cmbProducts_product_type)
        Me.grpMain.Controls.Add(Me.LabelControl52)
        Me.grpMain.Controls.Add(Me.txtIMDB_ID)
        Me.grpMain.Controls.Add(Me.LabelControl51)
        Me.grpMain.Controls.Add(Me.txtTitle)
        Me.grpMain.Controls.Add(Me.chkInCinemaNow)
        Me.grpMain.Controls.Add(Me.cmbRating)
        Me.grpMain.Controls.Add(Me.LabelControl9)
        Me.grpMain.Controls.Add(Me.LabelControl6)
        Me.grpMain.Controls.Add(Me.LabelControl5)
        Me.grpMain.Controls.Add(Me.cmbProducts_Media)
        Me.grpMain.Controls.Add(Me.LabelControl4)
        Me.grpMain.Controls.Add(Me.cmbProducts_Type)
        Me.grpMain.Controls.Add(Me.LabelControl3)
        Me.grpMain.Controls.Add(Me.cmbProducts_Status)
        Me.grpMain.Controls.Add(Me.lblStatus)
        Me.grpMain.Controls.Add(Me.cmbDirector)
        Me.grpMain.Controls.Add(Me.cmbPictureFormat)
        Me.grpMain.Controls.Add(Me.lblPictureFormat)
        Me.grpMain.Controls.Add(Me.cmbPublic)
        Me.grpMain.Controls.Add(Me.lblPublic)
        Me.grpMain.Controls.Add(Me.cmbStudio)
        Me.grpMain.Controls.Add(Me.lblStudio)
        Me.grpMain.Controls.Add(Me.cmbcountry)
        Me.grpMain.Controls.Add(Me.lblcountry)
        Me.grpMain.Controls.Add(Me.txtRunTime)
        Me.grpMain.Controls.Add(Me.lblRunTime)
        Me.grpMain.Controls.Add(Me.txtYear)
        Me.grpMain.Controls.Add(Me.lblYear)
        Me.grpMain.Controls.Add(Me.txtDateAvailable)
        Me.grpMain.Controls.Add(Me.LabelControl2)
        Me.grpMain.Controls.Add(Me.txtDateAdded)
        Me.grpMain.Controls.Add(Me.lblTitle)
        Me.grpMain.Controls.Add(Me.txtModel)
        Me.grpMain.Controls.Add(Me.lblModel)
        Me.grpMain.Controls.Add(Me.txtProductID)
        Me.grpMain.Controls.Add(Me.lblProductID)
        Me.grpMain.Location = New System.Drawing.Point(8, 40)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(440, 465)
        Me.grpMain.TabIndex = 0
        Me.grpMain.Text = "General Info"
        '
        'txtEpisodeID
        '
        Me.txtEpisodeID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.episode_id", True))
        Me.txtEpisodeID.Enabled = False
        Me.txtEpisodeID.Location = New System.Drawing.Point(104, 318)
        Me.txtEpisodeID.Name = "txtEpisodeID"
        Me.txtEpisodeID.Size = New System.Drawing.Size(104, 20)
        Me.txtEpisodeID.TabIndex = 59
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(16, 321)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl8.TabIndex = 60
        Me.LabelControl8.Text = "Episode"
        '
        'txtSeasonID
        '
        Me.txtSeasonID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.season_id", True))
        Me.txtSeasonID.Enabled = False
        Me.txtSeasonID.Location = New System.Drawing.Point(104, 294)
        Me.txtSeasonID.Name = "txtSeasonID"
        Me.txtSeasonID.Size = New System.Drawing.Size(104, 20)
        Me.txtSeasonID.TabIndex = 57
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 297)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl1.TabIndex = 58
        Me.LabelControl1.Text = "Season"
        '
        'chkVodNextNL
        '
        Me.chkVodNextNL.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.vod_next_nl", True))
        Me.chkVodNextNL.EditValue = 0
        Me.chkVodNextNL.Enabled = False
        Me.chkVodNextNL.Location = New System.Drawing.Point(319, 440)
        Me.chkVodNextNL.Name = "chkVodNextNL"
        Me.chkVodNextNL.Properties.Caption = "Soon in VOD Nl"
        Me.chkVodNextNL.Properties.ValueChecked = 1
        Me.chkVodNextNL.Properties.ValueUnchecked = 0
        Me.chkVodNextNL.Size = New System.Drawing.Size(100, 19)
        Me.chkVodNextNL.TabIndex = 56
        '
        'chkVodNextLU
        '
        Me.chkVodNextLU.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.vod_next_lux", True))
        Me.chkVodNextLU.EditValue = 0
        Me.chkVodNextLU.Enabled = False
        Me.chkVodNextLU.Location = New System.Drawing.Point(203, 440)
        Me.chkVodNextLU.Name = "chkVodNextLU"
        Me.chkVodNextLU.Properties.Caption = "Soon in VOD Lux"
        Me.chkVodNextLU.Properties.ValueChecked = 1
        Me.chkVodNextLU.Properties.ValueUnchecked = 0
        Me.chkVodNextLU.Size = New System.Drawing.Size(106, 19)
        Me.chkVodNextLU.TabIndex = 55
        '
        'chkVodNext
        '
        Me.chkVodNext.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.vod_next", True))
        Me.chkVodNext.EditValue = 0
        Me.chkVodNext.Enabled = False
        Me.chkVodNext.Location = New System.Drawing.Point(115, 440)
        Me.chkVodNext.Name = "chkVodNext"
        Me.chkVodNext.Properties.Caption = "Soon in VOD"
        Me.chkVodNext.Properties.ValueChecked = 1
        Me.chkVodNext.Properties.ValueUnchecked = 0
        Me.chkVodNext.Size = New System.Drawing.Size(93, 19)
        Me.chkVodNext.TabIndex = 54
        '
        'cmbProducts_product_type
        '
        Me.cmbProducts_product_type.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_product_type", True))
        Me.cmbProducts_product_type.Enabled = False
        Me.cmbProducts_product_type.Location = New System.Drawing.Point(104, 97)
        Me.cmbProducts_product_type.Name = "cmbProducts_product_type"
        Me.cmbProducts_product_type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProducts_product_type.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeDesc", "Desc", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbProducts_product_type.Properties.DataSource = Me.objDS.product_type
        Me.cmbProducts_product_type.Properties.DisplayMember = "CodeDesc"
        Me.cmbProducts_product_type.Properties.NullText = ""
        Me.cmbProducts_product_type.Properties.ValueMember = "CodeValue"
        Me.cmbProducts_product_type.Size = New System.Drawing.Size(112, 20)
        Me.cmbProducts_product_type.TabIndex = 52
        Me.cmbProducts_product_type.Visible = False
        '
        'LabelControl52
        '
        Me.LabelControl52.Location = New System.Drawing.Point(16, 97)
        Me.LabelControl52.Name = "LabelControl52"
        Me.LabelControl52.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl52.TabIndex = 53
        Me.LabelControl52.Text = "Product Type"
        Me.LabelControl52.Visible = False
        '
        'txtIMDB_ID
        '
        Me.txtIMDB_ID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.imdb_id", True))
        Me.txtIMDB_ID.Enabled = False
        Me.txtIMDB_ID.Location = New System.Drawing.Point(104, 269)
        Me.txtIMDB_ID.Name = "txtIMDB_ID"
        Me.txtIMDB_ID.Size = New System.Drawing.Size(104, 20)
        Me.txtIMDB_ID.TabIndex = 50
        '
        'LabelControl51
        '
        Me.LabelControl51.Location = New System.Drawing.Point(16, 272)
        Me.LabelControl51.Name = "LabelControl51"
        Me.LabelControl51.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl51.TabIndex = 51
        Me.LabelControl51.Text = "IMDB ID"
        '
        'txtTitle
        '
        Me.txtTitle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_title", True))
        Me.txtTitle.Enabled = False
        Me.txtTitle.Location = New System.Drawing.Point(104, 147)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(328, 20)
        Me.txtTitle.TabIndex = 49
        '
        'chkInCinemaNow
        '
        Me.chkInCinemaNow.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.in_cinema_now", True))
        Me.chkInCinemaNow.EditValue = 0
        Me.chkInCinemaNow.Enabled = False
        Me.chkInCinemaNow.Location = New System.Drawing.Point(14, 440)
        Me.chkInCinemaNow.Name = "chkInCinemaNow"
        Me.chkInCinemaNow.Properties.Caption = "In Cinema Now"
        Me.chkInCinemaNow.Properties.ValueChecked = 1
        Me.chkInCinemaNow.Properties.ValueUnchecked = 0
        Me.chkInCinemaNow.Size = New System.Drawing.Size(112, 19)
        Me.chkInCinemaNow.TabIndex = 46
        '
        'cmbRating
        '
        Me.cmbRating.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_rating", True))
        Me.cmbRating.Enabled = False
        Me.cmbRating.Location = New System.Drawing.Point(328, 243)
        Me.cmbRating.Name = "cmbRating"
        Me.cmbRating.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRating.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("rating_desc", "rating_desc", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbRating.Properties.DataSource = Me.objDS.view_products_rating
        Me.cmbRating.Properties.DisplayMember = "rating_desc"
        Me.cmbRating.Properties.NullText = ""
        Me.cmbRating.Properties.ValueMember = "rating_id"
        Me.cmbRating.Size = New System.Drawing.Size(104, 20)
        Me.cmbRating.TabIndex = 14
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(240, 243)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl9.TabIndex = 40
        Me.LabelControl9.Text = "Rating"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(16, 415)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl6.TabIndex = 37
        Me.LabelControl6.Text = "Director"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(16, 195)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl5.TabIndex = 36
        Me.LabelControl5.Text = "Date Added"
        '
        'cmbProducts_Media
        '
        Me.cmbProducts_Media.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_media", True))
        Me.cmbProducts_Media.Enabled = False
        Me.cmbProducts_Media.Location = New System.Drawing.Point(328, 72)
        Me.cmbProducts_Media.Name = "cmbProducts_Media"
        Me.cmbProducts_Media.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProducts_Media.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("media_desc", "media_desc", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbProducts_Media.Properties.DataSource = Me.objDS.view_products_media
        Me.cmbProducts_Media.Properties.DisplayMember = "media_desc"
        Me.cmbProducts_Media.Properties.NullText = ""
        Me.cmbProducts_Media.Properties.ValueMember = "media_desc"
        Me.cmbProducts_Media.Size = New System.Drawing.Size(104, 20)
        Me.cmbProducts_Media.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(240, 72)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl4.TabIndex = 34
        Me.LabelControl4.Text = "Media"
        '
        'cmbProducts_Type
        '
        Me.cmbProducts_Type.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_type", True))
        Me.cmbProducts_Type.Enabled = False
        Me.cmbProducts_Type.Location = New System.Drawing.Point(104, 72)
        Me.cmbProducts_Type.Name = "cmbProducts_Type"
        Me.cmbProducts_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProducts_Type.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type_desc", "type_desc", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbProducts_Type.Properties.DataSource = Me.objDS.view_products_type
        Me.cmbProducts_Type.Properties.DisplayMember = "type_desc"
        Me.cmbProducts_Type.Properties.NullText = ""
        Me.cmbProducts_Type.Properties.ValueMember = "type_desc"
        Me.cmbProducts_Type.Size = New System.Drawing.Size(112, 20)
        Me.cmbProducts_Type.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 72)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl3.TabIndex = 32
        Me.LabelControl3.Text = "Type"
        '
        'cmbProducts_Status
        '
        Me.cmbProducts_Status.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_status", True))
        Me.cmbProducts_Status.Enabled = False
        Me.cmbProducts_Status.Location = New System.Drawing.Point(104, 48)
        Me.cmbProducts_Status.Name = "cmbProducts_Status"
        Me.cmbProducts_Status.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProducts_Status.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("status_desc", "status_desc", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbProducts_Status.Properties.DataSource = Me.objDS.view_products_status
        Me.cmbProducts_Status.Properties.DisplayMember = "status_desc"
        Me.cmbProducts_Status.Properties.NullText = ""
        Me.cmbProducts_Status.Properties.ValueMember = "status_id"
        Me.cmbProducts_Status.Size = New System.Drawing.Size(112, 20)
        Me.cmbProducts_Status.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(16, 48)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(31, 13)
        Me.lblStatus.TabIndex = 30
        Me.lblStatus.Text = "Status"
        '
        'cmbDirector
        '
        Me.cmbDirector.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_directors_id", True))
        Me.cmbDirector.Enabled = False
        Me.cmbDirector.Location = New System.Drawing.Point(104, 415)
        Me.cmbDirector.Name = "cmbDirector"
        Me.cmbDirector.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.cmbDirector.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("directors_id", "directors_id", 75, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("directors_name", "directors_name", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbDirector.Properties.DataSource = Me.objDS.directors
        Me.cmbDirector.Properties.DisplayMember = "directors_name"
        Me.cmbDirector.Properties.NullText = ""
        Me.cmbDirector.Properties.ValueMember = "directors_id"
        Me.cmbDirector.Size = New System.Drawing.Size(328, 20)
        Me.cmbDirector.TabIndex = 18
        '
        'cmbPictureFormat
        '
        Me.cmbPictureFormat.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_picture_format", True))
        Me.cmbPictureFormat.Enabled = False
        Me.cmbPictureFormat.Location = New System.Drawing.Point(104, 367)
        Me.cmbPictureFormat.Name = "cmbPictureFormat"
        Me.cmbPictureFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPictureFormat.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("picture_format_id", "picture_format_id", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("picture_format_name", "picture_format_name", 109, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbPictureFormat.Properties.DataSource = Me.objDS.picture_format
        Me.cmbPictureFormat.Properties.DisplayMember = "picture_format_name"
        Me.cmbPictureFormat.Properties.NullText = ""
        Me.cmbPictureFormat.Properties.ValueMember = "picture_format_id"
        Me.cmbPictureFormat.Size = New System.Drawing.Size(328, 20)
        Me.cmbPictureFormat.TabIndex = 16
        '
        'lblPictureFormat
        '
        Me.lblPictureFormat.Location = New System.Drawing.Point(16, 367)
        Me.lblPictureFormat.Name = "lblPictureFormat"
        Me.lblPictureFormat.Size = New System.Drawing.Size(70, 13)
        Me.lblPictureFormat.TabIndex = 24
        Me.lblPictureFormat.Text = "Picture Format"
        '
        'cmbPublic
        '
        Me.cmbPublic.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_public", True))
        Me.cmbPublic.Enabled = False
        Me.cmbPublic.Location = New System.Drawing.Point(104, 343)
        Me.cmbPublic.Name = "cmbPublic"
        Me.cmbPublic.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPublic.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("public_id", "public_id", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("public_name", "public_name", 95, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbPublic.Properties.DataSource = Me.objDS.public1
        Me.cmbPublic.Properties.DisplayMember = "public_name"
        Me.cmbPublic.Properties.NullText = ""
        Me.cmbPublic.Properties.ValueMember = "public_id"
        Me.cmbPublic.Size = New System.Drawing.Size(328, 20)
        Me.cmbPublic.TabIndex = 15
        '
        'lblPublic
        '
        Me.lblPublic.Location = New System.Drawing.Point(16, 343)
        Me.lblPublic.Name = "lblPublic"
        Me.lblPublic.Size = New System.Drawing.Size(27, 13)
        Me.lblPublic.TabIndex = 22
        Me.lblPublic.Text = "Public"
        '
        'cmbStudio
        '
        Me.cmbStudio.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_studio", True))
        Me.cmbStudio.Enabled = False
        Me.cmbStudio.Location = New System.Drawing.Point(104, 391)
        Me.cmbStudio.Name = "cmbStudio"
        Me.cmbStudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.cmbStudio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_name", "studio_name", 67, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_type", "studio_type", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbStudio.Properties.DataSource = Me.objDS.studio
        Me.cmbStudio.Properties.DisplayMember = "studio_name"
        Me.cmbStudio.Properties.NullText = ""
        Me.cmbStudio.Properties.ValueMember = "studio_id"
        Me.cmbStudio.Size = New System.Drawing.Size(328, 20)
        Me.cmbStudio.TabIndex = 17
        '
        'lblStudio
        '
        Me.lblStudio.Location = New System.Drawing.Point(16, 391)
        Me.lblStudio.Name = "lblStudio"
        Me.lblStudio.Size = New System.Drawing.Size(30, 13)
        Me.lblStudio.TabIndex = 20
        Me.lblStudio.Text = "Studio"
        '
        'cmbcountry
        '
        Me.cmbcountry.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_countries_id", True))
        Me.cmbcountry.Enabled = False
        Me.cmbcountry.Location = New System.Drawing.Point(104, 243)
        Me.cmbcountry.Name = "cmbcountry"
        Me.cmbcountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.cmbcountry.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("countries_id", "countries_id", 77, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("countries_name", "countries_name", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbcountry.Properties.DataSource = Me.objDS.products_countries
        Me.cmbcountry.Properties.DisplayMember = "countries_name"
        Me.cmbcountry.Properties.NullText = ""
        Me.cmbcountry.Properties.ValueMember = "countries_id"
        Me.cmbcountry.Size = New System.Drawing.Size(112, 20)
        Me.cmbcountry.TabIndex = 13
        '
        'lblcountry
        '
        Me.lblcountry.Location = New System.Drawing.Point(16, 243)
        Me.lblcountry.Name = "lblcountry"
        Me.lblcountry.Size = New System.Drawing.Size(37, 13)
        Me.lblcountry.TabIndex = 18
        Me.lblcountry.Text = "country"
        '
        'txtRunTime
        '
        Me.txtRunTime.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_runtime", True))
        Me.txtRunTime.Enabled = False
        Me.txtRunTime.Location = New System.Drawing.Point(328, 219)
        Me.txtRunTime.Name = "txtRunTime"
        Me.txtRunTime.Size = New System.Drawing.Size(104, 20)
        Me.txtRunTime.TabIndex = 12
        '
        'lblRunTime
        '
        Me.lblRunTime.Location = New System.Drawing.Point(240, 219)
        Me.lblRunTime.Name = "lblRunTime"
        Me.lblRunTime.Size = New System.Drawing.Size(44, 13)
        Me.lblRunTime.TabIndex = 16
        Me.lblRunTime.Text = "Run Time"
        '
        'txtYear
        '
        Me.txtYear.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_year", True))
        Me.txtYear.Enabled = False
        Me.txtYear.Location = New System.Drawing.Point(104, 219)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(112, 20)
        Me.txtYear.TabIndex = 11
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(16, 219)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(22, 13)
        Me.lblYear.TabIndex = 14
        Me.lblYear.Text = "Year"
        '
        'txtDateAvailable
        '
        Me.txtDateAvailable.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_date_available", True))
        Me.txtDateAvailable.EditValue = Nothing
        Me.txtDateAvailable.Enabled = False
        Me.txtDateAvailable.Location = New System.Drawing.Point(328, 195)
        Me.txtDateAvailable.Name = "txtDateAvailable"
        Me.txtDateAvailable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateAvailable.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDateAvailable.Size = New System.Drawing.Size(104, 20)
        Me.txtDateAvailable.TabIndex = 10
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(240, 195)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "Date Available"
        '
        'txtDateAdded
        '
        Me.txtDateAdded.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_date_added", True))
        Me.txtDateAdded.EditValue = Nothing
        Me.txtDateAdded.Enabled = False
        Me.txtDateAdded.Location = New System.Drawing.Point(104, 195)
        Me.txtDateAdded.Name = "txtDateAdded"
        Me.txtDateAdded.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateAdded.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDateAdded.Size = New System.Drawing.Size(112, 20)
        Me.txtDateAdded.TabIndex = 9
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(16, 147)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(20, 13)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Title"
        '
        'txtModel
        '
        Me.txtModel.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_model", True))
        Me.txtModel.Enabled = False
        Me.txtModel.Location = New System.Drawing.Point(104, 123)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(328, 20)
        Me.txtModel.TabIndex = 5
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(16, 123)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(28, 13)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Model"
        '
        'txtProductID
        '
        Me.txtProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_id", True))
        Me.txtProductID.Enabled = False
        Me.txtProductID.Location = New System.Drawing.Point(104, 24)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(112, 20)
        Me.txtProductID.TabIndex = 0
        '
        'lblProductID
        '
        Me.lblProductID.Location = New System.Drawing.Point(16, 24)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(51, 13)
        Me.lblProductID.TabIndex = 0
        Me.lblProductID.Text = "Product ID"
        '
        'tabFR
        '
        Me.tabFR.Controls.Add(Me.txtAwardFR)
        Me.tabFR.Controls.Add(Me.txtDescFR)
        Me.tabFR.Controls.Add(Me.LabelControl18)
        Me.tabFR.Controls.Add(Me.pictFR)
        Me.tabFR.Controls.Add(Me.txtImageFR)
        Me.tabFR.Controls.Add(Me.LabelControl17)
        Me.tabFR.Controls.Add(Me.LabelControl16)
        Me.tabFR.Controls.Add(Me.txtURLFr)
        Me.tabFR.Controls.Add(Me.LabelControl15)
        Me.tabFR.Controls.Add(Me.txtNameFR)
        Me.tabFR.Controls.Add(Me.LabelControl14)
        Me.tabFR.Name = "tabFR"
        Me.tabFR.Size = New System.Drawing.Size(1047, 629)
        Me.tabFR.Text = "FR"
        '
        'txtAwardFR
        '
        Me.txtAwardFR.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_fr.products_awards", True))
        Me.txtAwardFR.Enabled = False
        Me.txtAwardFR.Location = New System.Drawing.Point(128, 56)
        Me.txtAwardFR.Name = "txtAwardFR"
        Me.txtAwardFR.Size = New System.Drawing.Size(408, 80)
        Me.txtAwardFR.TabIndex = 12
        '
        'txtDescFR
        '
        Me.txtDescFR.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_fr.products_description", True))
        Me.txtDescFR.Enabled = False
        Me.txtDescFR.Location = New System.Drawing.Point(128, 168)
        Me.txtDescFR.Name = "txtDescFR"
        Me.txtDescFR.Size = New System.Drawing.Size(408, 224)
        Me.txtDescFR.TabIndex = 11
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(16, 168)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl18.TabIndex = 10
        Me.LabelControl18.Text = "Product Description"
        '
        'pictFR
        '
        Me.pictFR.Location = New System.Drawing.Point(552, 32)
        Me.pictFR.Name = "pictFR"
        Me.pictFR.Properties.ReadOnly = True
        Me.pictFR.Size = New System.Drawing.Size(280, 320)
        Me.pictFR.TabIndex = 9
        '
        'txtImageFR
        '
        Me.txtImageFR.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_fr.products_image_big", True))
        Me.txtImageFR.Enabled = False
        Me.txtImageFR.Location = New System.Drawing.Point(128, 144)
        Me.txtImageFR.Name = "txtImageFR"
        Me.txtImageFR.Size = New System.Drawing.Size(408, 20)
        Me.txtImageFR.TabIndex = 8
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(16, 144)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl17.TabIndex = 7
        Me.LabelControl17.Text = "Product Image"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(16, 56)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl16.TabIndex = 5
        Me.LabelControl16.Text = "Product Award"
        '
        'txtURLFr
        '
        Me.txtURLFr.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_fr.products_url", True))
        Me.txtURLFr.Enabled = False
        Me.txtURLFr.Location = New System.Drawing.Point(128, 32)
        Me.txtURLFr.Name = "txtURLFr"
        Me.txtURLFr.Size = New System.Drawing.Size(408, 20)
        Me.txtURLFr.TabIndex = 4
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(16, 32)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl15.TabIndex = 3
        Me.LabelControl15.Text = "Product URL"
        '
        'txtNameFR
        '
        Me.txtNameFR.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_fr.products_name", True))
        Me.txtNameFR.Enabled = False
        Me.txtNameFR.Location = New System.Drawing.Point(128, 8)
        Me.txtNameFR.Name = "txtNameFR"
        Me.txtNameFR.Size = New System.Drawing.Size(408, 20)
        Me.txtNameFR.TabIndex = 2
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(16, 8)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl14.TabIndex = 1
        Me.LabelControl14.Text = "Product Name"
        '
        'tabNL
        '
        Me.tabNL.Controls.Add(Me.txtAwardNL)
        Me.tabNL.Controls.Add(Me.txtDescNL)
        Me.tabNL.Controls.Add(Me.LabelControl19)
        Me.tabNL.Controls.Add(Me.pictNL)
        Me.tabNL.Controls.Add(Me.txtImageNL)
        Me.tabNL.Controls.Add(Me.LabelControl20)
        Me.tabNL.Controls.Add(Me.LabelControl21)
        Me.tabNL.Controls.Add(Me.txtURLNl)
        Me.tabNL.Controls.Add(Me.LabelControl22)
        Me.tabNL.Controls.Add(Me.txtNameNL)
        Me.tabNL.Controls.Add(Me.LabelControl23)
        Me.tabNL.Name = "tabNL"
        Me.tabNL.Size = New System.Drawing.Size(1047, 629)
        Me.tabNL.Text = "NL"
        '
        'txtAwardNL
        '
        Me.txtAwardNL.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_nl.products_awards", True))
        Me.txtAwardNL.Enabled = False
        Me.txtAwardNL.Location = New System.Drawing.Point(128, 56)
        Me.txtAwardNL.Name = "txtAwardNL"
        Me.txtAwardNL.Size = New System.Drawing.Size(408, 80)
        Me.txtAwardNL.TabIndex = 23
        '
        'txtDescNL
        '
        Me.txtDescNL.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_nl.products_description", True))
        Me.txtDescNL.Enabled = False
        Me.txtDescNL.Location = New System.Drawing.Point(128, 168)
        Me.txtDescNL.Name = "txtDescNL"
        Me.txtDescNL.Size = New System.Drawing.Size(408, 224)
        Me.txtDescNL.TabIndex = 22
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(16, 168)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl19.TabIndex = 21
        Me.LabelControl19.Text = "Product Description"
        '
        'pictNL
        '
        Me.pictNL.Location = New System.Drawing.Point(552, 32)
        Me.pictNL.Name = "pictNL"
        Me.pictNL.Properties.ReadOnly = True
        Me.pictNL.Size = New System.Drawing.Size(280, 320)
        Me.pictNL.TabIndex = 20
        '
        'txtImageNL
        '
        Me.txtImageNL.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_nl.products_image_big", True))
        Me.txtImageNL.Enabled = False
        Me.txtImageNL.Location = New System.Drawing.Point(128, 144)
        Me.txtImageNL.Name = "txtImageNL"
        Me.txtImageNL.Size = New System.Drawing.Size(408, 20)
        Me.txtImageNL.TabIndex = 19
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(16, 144)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl20.TabIndex = 18
        Me.LabelControl20.Text = "Product Image"
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(16, 56)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl21.TabIndex = 16
        Me.LabelControl21.Text = "Product Award"
        '
        'txtURLNl
        '
        Me.txtURLNl.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_nl.products_url", True))
        Me.txtURLNl.Enabled = False
        Me.txtURLNl.Location = New System.Drawing.Point(128, 32)
        Me.txtURLNl.Name = "txtURLNl"
        Me.txtURLNl.Size = New System.Drawing.Size(408, 20)
        Me.txtURLNl.TabIndex = 15
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(16, 32)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl22.TabIndex = 14
        Me.LabelControl22.Text = "Product URL"
        '
        'txtNameNL
        '
        Me.txtNameNL.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_nl.products_name", True))
        Me.txtNameNL.Enabled = False
        Me.txtNameNL.Location = New System.Drawing.Point(128, 8)
        Me.txtNameNL.Name = "txtNameNL"
        Me.txtNameNL.Size = New System.Drawing.Size(408, 20)
        Me.txtNameNL.TabIndex = 13
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(16, 8)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl23.TabIndex = 12
        Me.LabelControl23.Text = "Product Name"
        '
        'tabEN
        '
        Me.tabEN.Controls.Add(Me.txtAwardEN)
        Me.tabEN.Controls.Add(Me.txtDescEN)
        Me.tabEN.Controls.Add(Me.LabelControl24)
        Me.tabEN.Controls.Add(Me.pictEN)
        Me.tabEN.Controls.Add(Me.txtImageEN)
        Me.tabEN.Controls.Add(Me.LabelControl25)
        Me.tabEN.Controls.Add(Me.LabelControl26)
        Me.tabEN.Controls.Add(Me.txtURLEn)
        Me.tabEN.Controls.Add(Me.LabelControl27)
        Me.tabEN.Controls.Add(Me.txtNameEN)
        Me.tabEN.Controls.Add(Me.LabelControl28)
        Me.tabEN.Name = "tabEN"
        Me.tabEN.Size = New System.Drawing.Size(1047, 629)
        Me.tabEN.Text = "EN"
        '
        'txtAwardEN
        '
        Me.txtAwardEN.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_en.products_awards", True))
        Me.txtAwardEN.Enabled = False
        Me.txtAwardEN.Location = New System.Drawing.Point(128, 56)
        Me.txtAwardEN.Name = "txtAwardEN"
        Me.txtAwardEN.Size = New System.Drawing.Size(408, 80)
        Me.txtAwardEN.TabIndex = 34
        '
        'txtDescEN
        '
        Me.txtDescEN.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_en.products_description", True))
        Me.txtDescEN.Enabled = False
        Me.txtDescEN.Location = New System.Drawing.Point(128, 168)
        Me.txtDescEN.Name = "txtDescEN"
        Me.txtDescEN.Size = New System.Drawing.Size(408, 224)
        Me.txtDescEN.TabIndex = 33
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(16, 168)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl24.TabIndex = 32
        Me.LabelControl24.Text = "Product Description"
        '
        'pictEN
        '
        Me.pictEN.Location = New System.Drawing.Point(552, 32)
        Me.pictEN.Name = "pictEN"
        Me.pictEN.Properties.ReadOnly = True
        Me.pictEN.Size = New System.Drawing.Size(280, 320)
        Me.pictEN.TabIndex = 31
        '
        'txtImageEN
        '
        Me.txtImageEN.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_en.products_image_big", True))
        Me.txtImageEN.Enabled = False
        Me.txtImageEN.Location = New System.Drawing.Point(128, 144)
        Me.txtImageEN.Name = "txtImageEN"
        Me.txtImageEN.Size = New System.Drawing.Size(408, 20)
        Me.txtImageEN.TabIndex = 30
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(16, 144)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl25.TabIndex = 29
        Me.LabelControl25.Text = "Product Image"
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(16, 56)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl26.TabIndex = 27
        Me.LabelControl26.Text = "Product Award"
        '
        'txtURLEn
        '
        Me.txtURLEn.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_en.products_url", True))
        Me.txtURLEn.Enabled = False
        Me.txtURLEn.Location = New System.Drawing.Point(128, 32)
        Me.txtURLEn.Name = "txtURLEn"
        Me.txtURLEn.Size = New System.Drawing.Size(408, 20)
        Me.txtURLEn.TabIndex = 26
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(16, 32)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl27.TabIndex = 25
        Me.LabelControl27.Text = "Product URL"
        '
        'txtNameEN
        '
        Me.txtNameEN.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_en.products_name", True))
        Me.txtNameEN.Enabled = False
        Me.txtNameEN.Location = New System.Drawing.Point(128, 8)
        Me.txtNameEN.Name = "txtNameEN"
        Me.txtNameEN.Size = New System.Drawing.Size(408, 20)
        Me.txtNameEN.TabIndex = 24
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(16, 8)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl28.TabIndex = 23
        Me.LabelControl28.Text = "Product Name"
        '
        'tabCategories
        '
        Me.tabCategories.Controls.Add(Me.PanelControl6)
        Me.tabCategories.Name = "tabCategories"
        Me.tabCategories.Size = New System.Drawing.Size(1047, 629)
        Me.tabCategories.Text = "Categories"
        '
        'PanelControl6
        '
        Me.PanelControl6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl6.Controls.Add(Me.TreeListCategories)
        Me.PanelControl6.Controls.Add(Me.PanelControl11)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl6.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(1047, 629)
        Me.PanelControl6.TabIndex = 10
        '
        'TreeListCategories
        '
        Me.TreeListCategories.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeListCategories.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.TreeListCategories.Appearance.Empty.Options.UseBackColor = True
        Me.TreeListCategories.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeListCategories.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeListCategories.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.TreeListCategories.Appearance.EvenRow.Options.UseBackColor = True
        Me.TreeListCategories.Appearance.EvenRow.Options.UseBorderColor = True
        Me.TreeListCategories.Appearance.EvenRow.Options.UseForeColor = True
        Me.TreeListCategories.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.TreeListCategories.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.TreeListCategories.Appearance.FocusedCell.Options.UseBackColor = True
        Me.TreeListCategories.Appearance.FocusedCell.Options.UseForeColor = True
        Me.TreeListCategories.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.TreeListCategories.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.TreeListCategories.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.TreeListCategories.Appearance.FocusedRow.Options.UseBackColor = True
        Me.TreeListCategories.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.TreeListCategories.Appearance.FocusedRow.Options.UseForeColor = True
        Me.TreeListCategories.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeListCategories.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeListCategories.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.TreeListCategories.Appearance.FooterPanel.Options.UseBackColor = True
        Me.TreeListCategories.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.TreeListCategories.Appearance.FooterPanel.Options.UseForeColor = True
        Me.TreeListCategories.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeListCategories.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeListCategories.Appearance.GroupButton.Options.UseBackColor = True
        Me.TreeListCategories.Appearance.GroupButton.Options.UseBorderColor = True
        Me.TreeListCategories.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TreeListCategories.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TreeListCategories.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.TreeListCategories.Appearance.GroupFooter.Options.UseBackColor = True
        Me.TreeListCategories.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.TreeListCategories.Appearance.GroupFooter.Options.UseForeColor = True
        Me.TreeListCategories.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TreeListCategories.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TreeListCategories.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.TreeListCategories.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.TreeListCategories.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.TreeListCategories.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.TreeListCategories.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TreeListCategories.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TreeListCategories.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeListCategories.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.TreeListCategories.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.TreeListCategories.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.TreeListCategories.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeListCategories.Appearance.HorzLine.Options.UseBackColor = True
        Me.TreeListCategories.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeListCategories.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeListCategories.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.TreeListCategories.Appearance.OddRow.Options.UseBackColor = True
        Me.TreeListCategories.Appearance.OddRow.Options.UseBorderColor = True
        Me.TreeListCategories.Appearance.OddRow.Options.UseForeColor = True
        Me.TreeListCategories.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.TreeListCategories.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TreeListCategories.Appearance.Preview.Options.UseFont = True
        Me.TreeListCategories.Appearance.Preview.Options.UseForeColor = True
        Me.TreeListCategories.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeListCategories.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.TreeListCategories.Appearance.Row.Options.UseBackColor = True
        Me.TreeListCategories.Appearance.Row.Options.UseForeColor = True
        Me.TreeListCategories.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TreeListCategories.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.TreeListCategories.Appearance.SelectedRow.Options.UseBackColor = True
        Me.TreeListCategories.Appearance.SelectedRow.Options.UseForeColor = True
        Me.TreeListCategories.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.TreeListCategories.Appearance.TreeLine.Options.UseBackColor = True
        Me.TreeListCategories.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeListCategories.Appearance.VertLine.Options.UseBackColor = True
        Me.TreeListCategories.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colcategories_id, Me.colparent_id, Me.colcategories_type, Me.colcategories_name, Me.colcategory_selected})
        Me.TreeListCategories.CustomizationFormBounds = New System.Drawing.Rectangle(960, 402, 208, 170)
        Me.TreeListCategories.DataSource = Me.objDS.categories_fr_view1
        Me.TreeListCategories.Dock = System.Windows.Forms.DockStyle.Fill
        FilterCondition2.Column = Me.colcategory_selected
        FilterCondition2.Condition = DevExpress.XtraTreeList.FilterConditionEnum.Equals
        FilterCondition2.Value1 = True
        FilterCondition2.Visible = True
        Me.TreeListCategories.FilterConditions.AddRange(New DevExpress.XtraTreeList.FilterCondition() {FilterCondition2})
        Me.TreeListCategories.KeyFieldName = "categories_id"
        Me.TreeListCategories.Location = New System.Drawing.Point(2, 2)
        Me.TreeListCategories.Name = "TreeListCategories"
        Me.TreeListCategories.OptionsBehavior.Editable = False
        Me.TreeListCategories.OptionsBehavior.EnableFiltering = True
        Me.TreeListCategories.OptionsBehavior.PopulateServiceColumns = True
        Me.TreeListCategories.OptionsView.EnableAppearanceEvenRow = True
        Me.TreeListCategories.OptionsView.EnableAppearanceOddRow = True
        Me.TreeListCategories.OptionsView.ShowHorzLines = False
        Me.TreeListCategories.OptionsView.ShowIndicator = False
        Me.TreeListCategories.OptionsView.ShowVertLines = False
        Me.TreeListCategories.ParentFieldName = "parent_id"
        Me.TreeListCategories.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkSelectCategory})
        Me.TreeListCategories.Size = New System.Drawing.Size(1043, 577)
        Me.TreeListCategories.TabIndex = 7
        '
        'colcategories_id
        '
        Me.colcategories_id.Caption = "categories_id"
        Me.colcategories_id.FieldName = "categories_id"
        Me.colcategories_id.Name = "colcategories_id"
        '
        'colparent_id
        '
        Me.colparent_id.Caption = "parent_id"
        Me.colparent_id.FieldName = "parent_id"
        Me.colparent_id.Name = "colparent_id"
        '
        'colcategories_type
        '
        Me.colcategories_type.Caption = "categories_type"
        Me.colcategories_type.FieldName = "categories_type"
        Me.colcategories_type.Name = "colcategories_type"
        Me.colcategories_type.Visible = True
        Me.colcategories_type.VisibleIndex = 1
        Me.colcategories_type.Width = 167
        '
        'colcategories_name
        '
        Me.colcategories_name.Caption = "categories_name"
        Me.colcategories_name.FieldName = "categories_name"
        Me.colcategories_name.Name = "colcategories_name"
        Me.colcategories_name.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.colcategories_name.Visible = True
        Me.colcategories_name.VisibleIndex = 0
        Me.colcategories_name.Width = 167
        '
        'PanelControl11
        '
        Me.PanelControl11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl11.Controls.Add(Me.btnCategories)
        Me.PanelControl11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl11.Location = New System.Drawing.Point(2, 579)
        Me.PanelControl11.Name = "PanelControl11"
        Me.PanelControl11.Size = New System.Drawing.Size(1043, 48)
        Me.PanelControl11.TabIndex = 8
        '
        'btnCategories
        '
        Me.btnCategories.Location = New System.Drawing.Point(8, 16)
        Me.btnCategories.Name = "btnCategories"
        Me.btnCategories.Size = New System.Drawing.Size(120, 23)
        Me.btnCategories.TabIndex = 0
        Me.btnCategories.Text = "Manage Categories"
        '
        'tabLanguages
        '
        Me.tabLanguages.Controls.Add(Me.grpSubTitles)
        Me.tabLanguages.Controls.Add(Me.SplitterControl1)
        Me.tabLanguages.Controls.Add(Me.grpLanguage)
        Me.tabLanguages.Name = "tabLanguages"
        Me.tabLanguages.PageEnabled = False
        Me.tabLanguages.PageVisible = False
        Me.tabLanguages.Size = New System.Drawing.Size(1047, 629)
        Me.tabLanguages.Text = "Languages"
        '
        'grpSubTitles
        '
        Me.grpSubTitles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpSubTitles.Controls.Add(Me.GridUndertitles)
        Me.grpSubTitles.Controls.Add(Me.PanelControl5)
        Me.grpSubTitles.Location = New System.Drawing.Point(502, 0)
        Me.grpSubTitles.Name = "grpSubTitles"
        Me.grpSubTitles.Size = New System.Drawing.Size(545, 629)
        Me.grpSubTitles.TabIndex = 2
        Me.grpSubTitles.Text = "SubTitles"
        '
        'GridUndertitles
        '
        Me.GridUndertitles.DataSource = Me.objDS.products_to_undertitles
        Me.GridUndertitles.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridUndertitles.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridUndertitles.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridUndertitles.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridUndertitles.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridUndertitles.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridUndertitles.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridUndertitles.EmbeddedNavigator.Enabled = False
        Me.GridUndertitles.EmbeddedNavigator.Name = ""
        Me.GridUndertitles.FormsUseDefaultLookAndFeel = False
        Me.GridUndertitles.Location = New System.Drawing.Point(2, 20)
        Me.GridUndertitles.MainView = Me.GridViewUndertitles
        Me.GridUndertitles.Name = "GridUndertitles"
        Me.GridUndertitles.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbUndertitles})
        Me.GridUndertitles.Size = New System.Drawing.Size(541, 567)
        Me.GridUndertitles.TabIndex = 4
        Me.GridUndertitles.UseEmbeddedNavigator = True
        Me.GridUndertitles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewUndertitles})
        '
        'GridViewUndertitles
        '
        Me.GridViewUndertitles.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand4})
        Me.GridViewUndertitles.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colproducts_id3, Me.colproducts_undertitles_id})
        Me.GridViewUndertitles.CustomizationFormBounds = New System.Drawing.Rectangle(755, 333, 217, 222)
        Me.GridViewUndertitles.GridControl = Me.GridUndertitles
        Me.GridViewUndertitles.Name = "GridViewUndertitles"
        Me.GridViewUndertitles.OptionsBehavior.Editable = False
        Me.GridViewUndertitles.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridViewUndertitles.OptionsView.ShowBands = False
        Me.GridViewUndertitles.OptionsView.ShowGroupPanel = False
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "GridBand2"
        Me.GridBand4.Columns.Add(Me.colproducts_id3)
        Me.GridBand4.Columns.Add(Me.colproducts_undertitles_id)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 245
        '
        'colproducts_id3
        '
        Me.colproducts_id3.Caption = "products_id"
        Me.colproducts_id3.FieldName = "products_id"
        Me.colproducts_id3.Name = "colproducts_id3"
        '
        'colproducts_undertitles_id
        '
        Me.colproducts_undertitles_id.Caption = "SubTitles"
        Me.colproducts_undertitles_id.ColumnEdit = Me.cmbUndertitles
        Me.colproducts_undertitles_id.FieldName = "products_undertitles_id"
        Me.colproducts_undertitles_id.Name = "colproducts_undertitles_id"
        Me.colproducts_undertitles_id.Visible = True
        Me.colproducts_undertitles_id.Width = 245
        '
        'cmbUndertitles
        '
        Me.cmbUndertitles.AutoHeight = False
        Me.cmbUndertitles.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbUndertitles.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("undertitles_id", "undertitles_id", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("undertitles_description", "undertitles_description", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbUndertitles.DataSource = Me.objDS.products_undertitles
        Me.cmbUndertitles.DisplayMember = "undertitles_description"
        Me.cmbUndertitles.Name = "cmbUndertitles"
        Me.cmbUndertitles.NullText = "NEW Line"
        Me.cmbUndertitles.ValueMember = "undertitles_id"
        '
        'PanelControl5
        '
        Me.PanelControl5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl5.Controls.Add(Me.btnSubTitles)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl5.Location = New System.Drawing.Point(2, 587)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(541, 40)
        Me.PanelControl5.TabIndex = 5
        '
        'btnSubTitles
        '
        Me.btnSubTitles.Location = New System.Drawing.Point(8, 8)
        Me.btnSubTitles.Name = "btnSubTitles"
        Me.btnSubTitles.Size = New System.Drawing.Size(96, 23)
        Me.btnSubTitles.TabIndex = 0
        Me.btnSubTitles.Text = "Manage SubTitles"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Appearance.BackColor = System.Drawing.SystemColors.Highlight
        Me.SplitterControl1.Appearance.Options.UseBackColor = True
        Me.SplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(6, 629)
        Me.SplitterControl1.TabIndex = 1
        Me.SplitterControl1.TabStop = False
        '
        'grpLanguage
        '
        Me.grpLanguage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpLanguage.Controls.Add(Me.GridLanguages)
        Me.grpLanguage.Controls.Add(Me.PanelControl4)
        Me.grpLanguage.Location = New System.Drawing.Point(0, 0)
        Me.grpLanguage.Name = "grpLanguage"
        Me.grpLanguage.Size = New System.Drawing.Size(387, 629)
        Me.grpLanguage.TabIndex = 0
        Me.grpLanguage.Text = "Language"
        '
        'GridLanguages
        '
        Me.GridLanguages.DataSource = Me.objDS.products_to_languages
        Me.GridLanguages.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridLanguages.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridLanguages.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridLanguages.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridLanguages.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridLanguages.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridLanguages.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridLanguages.EmbeddedNavigator.Enabled = False
        Me.GridLanguages.EmbeddedNavigator.Name = ""
        Me.GridLanguages.FormsUseDefaultLookAndFeel = False
        Me.GridLanguages.Location = New System.Drawing.Point(2, 20)
        Me.GridLanguages.MainView = Me.GridViewLanguages
        Me.GridLanguages.Name = "GridLanguages"
        Me.GridLanguages.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbLanguages1})
        Me.GridLanguages.Size = New System.Drawing.Size(362, 567)
        Me.GridLanguages.TabIndex = 4
        Me.GridLanguages.UseEmbeddedNavigator = True
        Me.GridLanguages.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewLanguages})
        '
        'GridViewLanguages
        '
        Me.GridViewLanguages.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand3})
        Me.GridViewLanguages.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colproducts_id2, Me.colproducts_languages_id})
        Me.GridViewLanguages.CustomizationFormBounds = New System.Drawing.Rectangle(755, 333, 217, 222)
        Me.GridViewLanguages.GridControl = Me.GridLanguages
        Me.GridViewLanguages.Name = "GridViewLanguages"
        Me.GridViewLanguages.OptionsBehavior.Editable = False
        Me.GridViewLanguages.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridViewLanguages.OptionsView.ShowBands = False
        Me.GridViewLanguages.OptionsView.ShowGroupPanel = False
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "GridBand2"
        Me.GridBand3.Columns.Add(Me.colproducts_id2)
        Me.GridBand3.Columns.Add(Me.colproducts_languages_id)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 241
        '
        'colproducts_id2
        '
        Me.colproducts_id2.Caption = "products_id"
        Me.colproducts_id2.FieldName = "products_id"
        Me.colproducts_id2.Name = "colproducts_id2"
        '
        'colproducts_languages_id
        '
        Me.colproducts_languages_id.Caption = "Language"
        Me.colproducts_languages_id.ColumnEdit = Me.cmbLanguages1
        Me.colproducts_languages_id.FieldName = "products_languages_id"
        Me.colproducts_languages_id.Name = "colproducts_languages_id"
        Me.colproducts_languages_id.Visible = True
        Me.colproducts_languages_id.Width = 241
        '
        'cmbLanguages1
        '
        Me.cmbLanguages1.AutoHeight = False
        Me.cmbLanguages1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguages1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "languages_id", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_description", "languages_description", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbLanguages1.DataSource = Me.objDS.products_languages
        Me.cmbLanguages1.DisplayMember = "languages_description"
        Me.cmbLanguages1.Name = "cmbLanguages1"
        Me.cmbLanguages1.NullText = "NEW Line"
        Me.cmbLanguages1.ValueMember = "languages_id"
        '
        'PanelControl4
        '
        Me.PanelControl4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl4.Controls.Add(Me.btnLang)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(2, 587)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(383, 40)
        Me.PanelControl4.TabIndex = 5
        '
        'btnLang
        '
        Me.btnLang.Location = New System.Drawing.Point(8, 8)
        Me.btnLang.Name = "btnLang"
        Me.btnLang.Size = New System.Drawing.Size(96, 23)
        Me.btnLang.TabIndex = 0
        Me.btnLang.Text = "Manage Lang"
        '
        'tabTrailers
        '
        Me.tabTrailers.Controls.Add(Me.SplitterControl3)
        Me.tabTrailers.Controls.Add(Me.grpTrailers)
        Me.tabTrailers.Name = "tabTrailers"
        Me.tabTrailers.Size = New System.Drawing.Size(1047, 629)
        Me.tabTrailers.Text = "Trailers"
        '
        'SplitterControl3
        '
        Me.SplitterControl3.Appearance.BackColor = System.Drawing.SystemColors.Highlight
        Me.SplitterControl3.Appearance.Options.UseBackColor = True
        Me.SplitterControl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitterControl3.Location = New System.Drawing.Point(0, 0)
        Me.SplitterControl3.Name = "SplitterControl3"
        Me.SplitterControl3.Size = New System.Drawing.Size(6, 629)
        Me.SplitterControl3.TabIndex = 2
        Me.SplitterControl3.TabStop = False
        '
        'grpTrailers
        '
        Me.grpTrailers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpTrailers.Controls.Add(Me.Panel2)
        Me.grpTrailers.Controls.Add(Me.Splitter2)
        Me.grpTrailers.Controls.Add(Me.PanelControl8)
        Me.grpTrailers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTrailers.Location = New System.Drawing.Point(0, 0)
        Me.grpTrailers.Name = "grpTrailers"
        Me.grpTrailers.Size = New System.Drawing.Size(1047, 629)
        Me.grpTrailers.TabIndex = 1
        Me.grpTrailers.Text = "Trailers"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridStreamingTrailers)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1043, 557)
        Me.Panel2.TabIndex = 9
        '
        'GridStreamingTrailers
        '
        Me.GridStreamingTrailers.DataSource = Me.objDS.streaming_trailers
        Me.GridStreamingTrailers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridStreamingTrailers.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridStreamingTrailers.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridStreamingTrailers.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridStreamingTrailers.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridStreamingTrailers.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridStreamingTrailers.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridStreamingTrailers.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridStreamingTrailers.EmbeddedNavigator.Enabled = False
        Me.GridStreamingTrailers.EmbeddedNavigator.Name = ""
        Me.GridStreamingTrailers.FormsUseDefaultLookAndFeel = False
        Me.GridStreamingTrailers.Location = New System.Drawing.Point(0, 0)
        Me.GridStreamingTrailers.MainView = Me.AdvBandedGridView2
        Me.GridStreamingTrailers.Name = "GridStreamingTrailers"
        Me.GridStreamingTrailers.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemButtonEdit1})
        Me.GridStreamingTrailers.Size = New System.Drawing.Size(1043, 557)
        Me.GridStreamingTrailers.TabIndex = 6
        Me.GridStreamingTrailers.UseEmbeddedNavigator = True
        Me.GridStreamingTrailers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGridView2})
        '
        'AdvBandedGridView2
        '
        Me.AdvBandedGridView2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand13})
        Me.AdvBandedGridView2.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BandedGridColumn3, Me.BandedGridColumn4, Me.BandedGridColumn8, Me.BandedGridColumn9, Me.BandedGridColumn10})
        Me.AdvBandedGridView2.CustomizationFormBounds = New System.Drawing.Rectangle(755, 333, 217, 222)
        Me.AdvBandedGridView2.GridControl = Me.GridStreamingTrailers
        Me.AdvBandedGridView2.Name = "AdvBandedGridView2"
        Me.AdvBandedGridView2.OptionsBehavior.Editable = False
        Me.AdvBandedGridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.AdvBandedGridView2.OptionsView.ShowBands = False
        Me.AdvBandedGridView2.OptionsView.ShowGroupPanel = False
        '
        'GridBand13
        '
        Me.GridBand13.Caption = "GridBand2"
        Me.GridBand13.Columns.Add(Me.BandedGridColumn3)
        Me.GridBand13.Columns.Add(Me.BandedGridColumn4)
        Me.GridBand13.Columns.Add(Me.BandedGridColumn8)
        Me.GridBand13.Columns.Add(Me.BandedGridColumn9)
        Me.GridBand13.Columns.Add(Me.BandedGridColumn10)
        Me.GridBand13.MinWidth = 20
        Me.GridBand13.Name = "GridBand13"
        Me.GridBand13.Width = 419
        '
        'BandedGridColumn3
        '
        Me.BandedGridColumn3.Caption = "id"
        Me.BandedGridColumn3.FieldName = "id"
        Me.BandedGridColumn3.Name = "BandedGridColumn3"
        Me.BandedGridColumn3.Width = 121
        '
        'BandedGridColumn4
        '
        Me.BandedGridColumn4.Caption = "filename"
        Me.BandedGridColumn4.FieldName = "filename"
        Me.BandedGridColumn4.Name = "BandedGridColumn4"
        Me.BandedGridColumn4.Visible = True
        Me.BandedGridColumn4.Width = 173
        '
        'BandedGridColumn8
        '
        Me.BandedGridColumn8.Caption = "audio"
        Me.BandedGridColumn8.FieldName = "audio"
        Me.BandedGridColumn8.Name = "BandedGridColumn8"
        Me.BandedGridColumn8.Visible = True
        Me.BandedGridColumn8.Width = 51
        '
        'BandedGridColumn9
        '
        Me.BandedGridColumn9.Caption = "subtitle"
        Me.BandedGridColumn9.FieldName = "subtitle"
        Me.BandedGridColumn9.Name = "BandedGridColumn9"
        Me.BandedGridColumn9.Visible = True
        Me.BandedGridColumn9.Width = 58
        '
        'BandedGridColumn10
        '
        Me.BandedGridColumn10.Caption = "status"
        Me.BandedGridColumn10.FieldName = "status"
        Me.BandedGridColumn10.Name = "BandedGridColumn10"
        Me.BandedGridColumn10.Visible = True
        Me.BandedGridColumn10.Width = 137
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "languages_id", 82, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_description", "languages_description", 113, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.objDS.products_languages
        Me.RepositoryItemLookUpEdit1.DisplayMember = "languages_description"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = "New Line"
        Me.RepositoryItemLookUpEdit1.ValueMember = "languages_id"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("broadcast", "broadcast", 67, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.objDS.trailers_broadcast
        Me.RepositoryItemLookUpEdit2.DisplayMember = "broadcast"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "broadcast"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter2.Location = New System.Drawing.Point(2, 20)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(1043, 10)
        Me.Splitter2.TabIndex = 8
        Me.Splitter2.TabStop = False
        '
        'PanelControl8
        '
        Me.PanelControl8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl8.Location = New System.Drawing.Point(2, 587)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(1043, 40)
        Me.PanelControl8.TabIndex = 5
        '
        'tabVod
        '
        Me.tabVod.Controls.Add(Me.txtId)
        Me.tabVod.Controls.Add(Me.btnCancelVod)
        Me.tabVod.Controls.Add(Me.cmbLanguageSubtitle)
        Me.tabVod.Controls.Add(Me.cmbLanguageSound)
        Me.tabVod.Controls.Add(Me.cmbDateExpired)
        Me.tabVod.Controls.Add(Me.cmbDateStart)
        Me.tabVod.Controls.Add(Me.TxtFilename)
        Me.tabVod.Controls.Add(Me.chkAvailable)
        Me.tabVod.Controls.Add(Me.lblAvailable)
        Me.tabVod.Controls.Add(Me.lblNameFile)
        Me.tabVod.Controls.Add(Me.lblDateExpired)
        Me.tabVod.Controls.Add(Me.lblDateStart)
        Me.tabVod.Controls.Add(Me.lblLanguage_subtitle)
        Me.tabVod.Controls.Add(Me.lblLanguageSound)
        Me.tabVod.Controls.Add(Me.txtImdbView)
        Me.tabVod.Controls.Add(Me.lblImdbView)
        Me.tabVod.Controls.Add(Me.btnSaveVod)
        Me.tabVod.Controls.Add(Me.btnEditVod)
        Me.tabVod.Name = "tabVod"
        Me.tabVod.PageVisible = False
        Me.tabVod.Size = New System.Drawing.Size(1047, 629)
        Me.tabVod.Text = "Vod"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(401, 71)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(112, 20)
        Me.txtId.TabIndex = 91
        '
        'btnCancelVod
        '
        Me.btnCancelVod.Location = New System.Drawing.Point(239, 28)
        Me.btnCancelVod.Name = "btnCancelVod"
        Me.btnCancelVod.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelVod.TabIndex = 90
        Me.btnCancelVod.Text = "Cancel"
        '
        'cmbLanguageSubtitle
        '
        Me.cmbLanguageSubtitle.Location = New System.Drawing.Point(135, 184)
        Me.cmbLanguageSubtitle.Name = "cmbLanguageSubtitle"
        Me.cmbLanguageSubtitle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguageSubtitle.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbLanguageSubtitle.Properties.DisplayMember = "status_desc"
        Me.cmbLanguageSubtitle.Properties.NullText = ""
        Me.cmbLanguageSubtitle.Properties.ValueMember = "status_id"
        Me.cmbLanguageSubtitle.Size = New System.Drawing.Size(112, 20)
        Me.cmbLanguageSubtitle.TabIndex = 89
        '
        'cmbLanguageSound
        '
        Me.cmbLanguageSound.Location = New System.Drawing.Point(135, 136)
        Me.cmbLanguageSound.Name = "cmbLanguageSound"
        Me.cmbLanguageSound.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguageSound.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbLanguageSound.Properties.DisplayMember = "status_desc"
        Me.cmbLanguageSound.Properties.NullText = ""
        Me.cmbLanguageSound.Properties.ValueMember = "status_id"
        Me.cmbLanguageSound.Size = New System.Drawing.Size(112, 20)
        Me.cmbLanguageSound.TabIndex = 88
        '
        'cmbDateExpired
        '
        Me.cmbDateExpired.EditValue = Nothing
        Me.cmbDateExpired.Location = New System.Drawing.Point(135, 272)
        Me.cmbDateExpired.Name = "cmbDateExpired"
        Me.cmbDateExpired.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateExpired.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateExpired.Size = New System.Drawing.Size(112, 20)
        Me.cmbDateExpired.TabIndex = 87
        '
        'cmbDateStart
        '
        Me.cmbDateStart.EditValue = Nothing
        Me.cmbDateStart.Location = New System.Drawing.Point(135, 226)
        Me.cmbDateStart.Name = "cmbDateStart"
        Me.cmbDateStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateStart.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateStart.Size = New System.Drawing.Size(112, 20)
        Me.cmbDateStart.TabIndex = 86
        '
        'TxtFilename
        '
        Me.TxtFilename.Enabled = False
        Me.TxtFilename.Location = New System.Drawing.Point(135, 325)
        Me.TxtFilename.Name = "TxtFilename"
        Me.TxtFilename.Size = New System.Drawing.Size(179, 20)
        Me.TxtFilename.TabIndex = 85
        '
        'chkAvailable
        '
        Me.chkAvailable.Location = New System.Drawing.Point(133, 371)
        Me.chkAvailable.Name = "chkAvailable"
        Me.chkAvailable.Properties.Caption = ""
        Me.chkAvailable.Size = New System.Drawing.Size(56, 19)
        Me.chkAvailable.TabIndex = 84
        '
        'lblAvailable
        '
        Me.lblAvailable.Location = New System.Drawing.Point(40, 374)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(42, 13)
        Me.lblAvailable.TabIndex = 83
        Me.lblAvailable.Text = "available"
        '
        'lblNameFile
        '
        Me.lblNameFile.Location = New System.Drawing.Point(40, 332)
        Me.lblNameFile.Name = "lblNameFile"
        Me.lblNameFile.Size = New System.Drawing.Size(43, 13)
        Me.lblNameFile.TabIndex = 82
        Me.lblNameFile.Text = "file name"
        '
        'lblDateExpired
        '
        Me.lblDateExpired.Location = New System.Drawing.Point(40, 279)
        Me.lblDateExpired.Name = "lblDateExpired"
        Me.lblDateExpired.Size = New System.Drawing.Size(61, 13)
        Me.lblDateExpired.TabIndex = 81
        Me.lblDateExpired.Text = "date expired"
        '
        'lblDateStart
        '
        Me.lblDateStart.Location = New System.Drawing.Point(40, 233)
        Me.lblDateStart.Name = "lblDateStart"
        Me.lblDateStart.Size = New System.Drawing.Size(48, 13)
        Me.lblDateStart.TabIndex = 80
        Me.lblDateStart.Text = "date start"
        '
        'lblLanguage_subtitle
        '
        Me.lblLanguage_subtitle.Location = New System.Drawing.Point(40, 187)
        Me.lblLanguage_subtitle.Name = "lblLanguage_subtitle"
        Me.lblLanguage_subtitle.Size = New System.Drawing.Size(82, 13)
        Me.lblLanguage_subtitle.TabIndex = 79
        Me.lblLanguage_subtitle.Text = "language subtitle"
        '
        'lblLanguageSound
        '
        Me.lblLanguageSound.Location = New System.Drawing.Point(40, 139)
        Me.lblLanguageSound.Name = "lblLanguageSound"
        Me.lblLanguageSound.Size = New System.Drawing.Size(76, 13)
        Me.lblLanguageSound.TabIndex = 78
        Me.lblLanguageSound.Text = "language sound"
        '
        'txtImdbView
        '
        Me.txtImdbView.Location = New System.Drawing.Point(135, 101)
        Me.txtImdbView.Name = "txtImdbView"
        Me.txtImdbView.Size = New System.Drawing.Size(112, 20)
        Me.txtImdbView.TabIndex = 77
        '
        'lblImdbView
        '
        Me.lblImdbView.Location = New System.Drawing.Point(40, 104)
        Me.lblImdbView.Name = "lblImdbView"
        Me.lblImdbView.Size = New System.Drawing.Size(38, 13)
        Me.lblImdbView.TabIndex = 76
        Me.lblImdbView.Text = "Imdb ID"
        '
        'btnSaveVod
        '
        Me.btnSaveVod.Location = New System.Drawing.Point(40, 28)
        Me.btnSaveVod.Name = "btnSaveVod"
        Me.btnSaveVod.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveVod.TabIndex = 75
        Me.btnSaveVod.Text = "Save"
        '
        'btnEditVod
        '
        Me.btnEditVod.Location = New System.Drawing.Point(135, 28)
        Me.btnEditVod.Name = "btnEditVod"
        Me.btnEditVod.Size = New System.Drawing.Size(79, 23)
        Me.btnEditVod.TabIndex = 74
        Me.btnEditVod.Text = "Edit"
        '
        'tabCritiques
        '
        Me.tabCritiques.Controls.Add(Me.lblValueNBRating)
        Me.tabCritiques.Controls.Add(Me.lblNbRating)
        Me.tabCritiques.Controls.Add(Me.lblValueNbCritiquePositive)
        Me.tabCritiques.Controls.Add(Me.lblNbCritiquePositive)
        Me.tabCritiques.Controls.Add(Me.lblValueNbCrtitiques)
        Me.tabCritiques.Controls.Add(Me.lblNbCritiques)
        Me.tabCritiques.Controls.Add(Me.lblValueRatingAverage)
        Me.tabCritiques.Controls.Add(Me.lblRatingAverage)
        Me.tabCritiques.Controls.Add(Me.GridCritiques)
        Me.tabCritiques.Name = "tabCritiques"
        Me.tabCritiques.Size = New System.Drawing.Size(1047, 629)
        Me.tabCritiques.Text = "Critiques"
        '
        'lblValueNBRating
        '
        Me.lblValueNBRating.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueNBRating.Appearance.Options.UseFont = True
        Me.lblValueNBRating.Location = New System.Drawing.Point(289, 62)
        Me.lblValueNBRating.Name = "lblValueNBRating"
        Me.lblValueNBRating.Size = New System.Drawing.Size(10, 22)
        Me.lblValueNBRating.TabIndex = 15
        Me.lblValueNBRating.Text = "0"
        '
        'lblNbRating
        '
        Me.lblNbRating.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbRating.Appearance.Options.UseFont = True
        Me.lblNbRating.Location = New System.Drawing.Point(134, 68)
        Me.lblNbRating.Name = "lblNbRating"
        Me.lblNbRating.Size = New System.Drawing.Size(53, 17)
        Me.lblNbRating.TabIndex = 14
        Me.lblNbRating.Text = "# Rating"
        '
        'lblValueNbCritiquePositive
        '
        Me.lblValueNbCritiquePositive.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueNbCritiquePositive.Appearance.Options.UseFont = True
        Me.lblValueNbCritiquePositive.Location = New System.Drawing.Point(289, 27)
        Me.lblValueNbCritiquePositive.Name = "lblValueNbCritiquePositive"
        Me.lblValueNbCritiquePositive.Size = New System.Drawing.Size(10, 22)
        Me.lblValueNbCritiquePositive.TabIndex = 13
        Me.lblValueNbCritiquePositive.Text = "0"
        '
        'lblNbCritiquePositive
        '
        Me.lblNbCritiquePositive.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbCritiquePositive.Appearance.Options.UseFont = True
        Me.lblNbCritiquePositive.Location = New System.Drawing.Point(134, 32)
        Me.lblNbCritiquePositive.Name = "lblNbCritiquePositive"
        Me.lblNbCritiquePositive.Size = New System.Drawing.Size(138, 17)
        Me.lblNbCritiquePositive.TabIndex = 12
        Me.lblNbCritiquePositive.Text = "# Critiques pertinentes"
        '
        'lblValueNbCrtitiques
        '
        Me.lblValueNbCrtitiques.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueNbCrtitiques.Appearance.Options.UseFont = True
        Me.lblValueNbCrtitiques.Location = New System.Drawing.Point(289, -3)
        Me.lblValueNbCrtitiques.Name = "lblValueNbCrtitiques"
        Me.lblValueNbCrtitiques.Size = New System.Drawing.Size(10, 22)
        Me.lblValueNbCrtitiques.TabIndex = 11
        Me.lblValueNbCrtitiques.Text = "0"
        '
        'lblNbCritiques
        '
        Me.lblNbCritiques.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbCritiques.Appearance.Options.UseFont = True
        Me.lblNbCritiques.Location = New System.Drawing.Point(132, 3)
        Me.lblNbCritiques.Name = "lblNbCritiques"
        Me.lblNbCritiques.Size = New System.Drawing.Size(66, 17)
        Me.lblNbCritiques.TabIndex = 10
        Me.lblNbCritiques.Text = "# Critiques"
        '
        'lblValueRatingAverage
        '
        Me.lblValueRatingAverage.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueRatingAverage.Appearance.Options.UseFont = True
        Me.lblValueRatingAverage.Location = New System.Drawing.Point(455, -3)
        Me.lblValueRatingAverage.Name = "lblValueRatingAverage"
        Me.lblValueRatingAverage.Size = New System.Drawing.Size(10, 22)
        Me.lblValueRatingAverage.TabIndex = 9
        Me.lblValueRatingAverage.Text = "0"
        '
        'lblRatingAverage
        '
        Me.lblRatingAverage.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRatingAverage.Appearance.Options.UseFont = True
        Me.lblRatingAverage.Location = New System.Drawing.Point(352, 3)
        Me.lblRatingAverage.Name = "lblRatingAverage"
        Me.lblRatingAverage.Size = New System.Drawing.Size(84, 17)
        Me.lblRatingAverage.TabIndex = 8
        Me.lblRatingAverage.Text = "Rating Moyen"
        '
        'GridCritiques
        '
        Me.GridCritiques.EmbeddedNavigator.Name = ""
        Me.GridCritiques.FormsUseDefaultLookAndFeel = False
        Me.GridCritiques.Location = New System.Drawing.Point(9, 97)
        Me.GridCritiques.MainView = Me.GridViewCritiques
        Me.GridCritiques.Name = "GridCritiques"
        Me.GridCritiques.Size = New System.Drawing.Size(861, 384)
        Me.GridCritiques.TabIndex = 7
        Me.GridCritiques.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCritiques})
        '
        'GridViewCritiques
        '
        Me.GridViewCritiques.GridControl = Me.GridCritiques
        Me.GridViewCritiques.Name = "GridViewCritiques"
        Me.GridViewCritiques.OptionsView.ShowFooter = True
        '
        'tabVodWishlist
        '
        Me.tabVodWishlist.Controls.Add(Me.GridVODWishlist)
        Me.tabVodWishlist.Name = "tabVodWishlist"
        Me.tabVodWishlist.Size = New System.Drawing.Size(1047, 629)
        Me.tabVodWishlist.Text = "VODWishlist"
        '
        'GridVODWishlist
        '
        Me.GridVODWishlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVODWishlist.EmbeddedNavigator.Name = ""
        Me.GridVODWishlist.FormsUseDefaultLookAndFeel = False
        Me.GridVODWishlist.Location = New System.Drawing.Point(0, 0)
        Me.GridVODWishlist.MainView = Me.gridViewVODWishlist
        Me.GridVODWishlist.Name = "GridVODWishlist"
        Me.GridVODWishlist.Size = New System.Drawing.Size(1047, 629)
        Me.GridVODWishlist.TabIndex = 2
        Me.GridVODWishlist.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewVODWishlist})
        '
        'gridViewVODWishlist
        '
        Me.gridViewVODWishlist.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand12})
        Me.gridViewVODWishlist.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.gridViewVODWishlist.GridControl = Me.GridVODWishlist
        Me.gridViewVODWishlist.Name = "gridViewVODWishlist"
        Me.gridViewVODWishlist.OptionsBehavior.Editable = False
        Me.gridViewVODWishlist.OptionsView.ShowFooter = True
        '
        'GridBand12
        '
        Me.GridBand12.Name = "GridBand12"
        '
        'imgIMDBID_5
        '
        Me.imgIMDBID_5.Location = New System.Drawing.Point(6, 414)
        Me.imgIMDBID_5.Name = "imgIMDBID_5"
        Me.imgIMDBID_5.Properties.ReadOnly = True
        Me.imgIMDBID_5.Size = New System.Drawing.Size(265, 95)
        Me.imgIMDBID_5.TabIndex = 10
        '
        'imgIMDBID_4
        '
        Me.imgIMDBID_4.Location = New System.Drawing.Point(6, 319)
        Me.imgIMDBID_4.Name = "imgIMDBID_4"
        Me.imgIMDBID_4.Properties.ReadOnly = True
        Me.imgIMDBID_4.Size = New System.Drawing.Size(265, 95)
        Me.imgIMDBID_4.TabIndex = 9
        '
        'imgIMDBID_3
        '
        Me.imgIMDBID_3.Location = New System.Drawing.Point(6, 224)
        Me.imgIMDBID_3.Name = "imgIMDBID_3"
        Me.imgIMDBID_3.Properties.ReadOnly = True
        Me.imgIMDBID_3.Size = New System.Drawing.Size(265, 95)
        Me.imgIMDBID_3.TabIndex = 8
        '
        'imgIMDBID_2
        '
        Me.imgIMDBID_2.Location = New System.Drawing.Point(6, 129)
        Me.imgIMDBID_2.Name = "imgIMDBID_2"
        Me.imgIMDBID_2.Properties.ReadOnly = True
        Me.imgIMDBID_2.Size = New System.Drawing.Size(265, 95)
        Me.imgIMDBID_2.TabIndex = 7
        '
        'imgIMDBID_1
        '
        Me.imgIMDBID_1.Location = New System.Drawing.Point(6, 23)
        Me.imgIMDBID_1.Name = "imgIMDBID_1"
        Me.imgIMDBID_1.Properties.ReadOnly = True
        Me.imgIMDBID_1.Size = New System.Drawing.Size(265, 106)
        Me.imgIMDBID_1.TabIndex = 6
        '
        'BandedGridColumn6
        '
        Me.BandedGridColumn6.Caption = "actors_id"
        Me.BandedGridColumn6.FieldName = "actors_id"
        Me.BandedGridColumn6.Name = "BandedGridColumn6"
        Me.BandedGridColumn6.Visible = True
        Me.BandedGridColumn6.Width = 237
        '
        'PanelControl10
        '
        Me.PanelControl10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl10.Controls.Add(Me.TextEdit3)
        Me.PanelControl10.Controls.Add(Me.LabelControl38)
        Me.PanelControl10.Controls.Add(Me.TextEdit2)
        Me.PanelControl10.Controls.Add(Me.LabelControl37)
        Me.PanelControl10.Controls.Add(Me.TextEdit1)
        Me.PanelControl10.Controls.Add(Me.LabelControl36)
        Me.PanelControl10.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl10.Location = New System.Drawing.Point(0, 57)
        Me.PanelControl10.Name = "PanelControl10"
        Me.PanelControl10.Size = New System.Drawing.Size(1056, 39)
        Me.PanelControl10.TabIndex = 36
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_title", True))
        Me.TextEdit3.Enabled = False
        Me.TextEdit3.Location = New System.Drawing.Point(696, 8)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(312, 20)
        Me.TextEdit3.TabIndex = 9
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(608, 8)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl38.TabIndex = 8
        Me.LabelControl38.Text = "Title"
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_model", True))
        Me.TextEdit2.Enabled = False
        Me.TextEdit2.Location = New System.Drawing.Point(304, 8)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(296, 20)
        Me.TextEdit2.TabIndex = 7
        '
        'LabelControl37
        '
        Me.LabelControl37.Location = New System.Drawing.Point(216, 8)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl37.TabIndex = 6
        Me.LabelControl37.Text = "Model"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_id", True))
        Me.TextEdit1.Enabled = False
        Me.TextEdit1.Location = New System.Drawing.Point(77, 6)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(112, 20)
        Me.TextEdit1.TabIndex = 2
        '
        'LabelControl36
        '
        Me.LabelControl36.Location = New System.Drawing.Point(8, 8)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl36.TabIndex = 1
        Me.LabelControl36.Text = "Product ID"
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl31.Appearance.Options.UseFont = True
        Me.LabelControl31.Location = New System.Drawing.Point(300, 52)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(13, 28)
        Me.LabelControl31.TabIndex = 6
        Me.LabelControl31.Text = "0"
        '
        'LabelControl33
        '
        Me.LabelControl33.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl33.Appearance.Options.UseFont = True
        Me.LabelControl33.Location = New System.Drawing.Point(254, 25)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(152, 21)
        Me.LabelControl33.TabIndex = 5
        Me.LabelControl33.Text = "# Critiques positives"
        '
        'LabelControl34
        '
        Me.LabelControl34.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl34.Appearance.Options.UseFont = True
        Me.LabelControl34.Location = New System.Drawing.Point(198, 52)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(13, 28)
        Me.LabelControl34.TabIndex = 4
        Me.LabelControl34.Text = "0"
        '
        'GridControl1
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.FormsUseDefaultLookAndFeel = False
        Me.GridControl1.Location = New System.Drawing.Point(9, 86)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1024, 443)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "products_id", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'LabelControl35
        '
        Me.LabelControl35.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl35.Appearance.Options.UseFont = True
        Me.LabelControl35.Location = New System.Drawing.Point(152, 25)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(82, 21)
        Me.LabelControl35.TabIndex = 3
        Me.LabelControl35.Text = "# Critiques"
        '
        'LabelControl58
        '
        Me.LabelControl58.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl58.Appearance.Options.UseFont = True
        Me.LabelControl58.Location = New System.Drawing.Point(67, 52)
        Me.LabelControl58.Name = "LabelControl58"
        Me.LabelControl58.Size = New System.Drawing.Size(13, 28)
        Me.LabelControl58.TabIndex = 2
        Me.LabelControl58.Text = "0"
        '
        'LabelControl59
        '
        Me.LabelControl59.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl59.Appearance.Options.UseFont = True
        Me.LabelControl59.Location = New System.Drawing.Point(21, 25)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(101, 21)
        Me.LabelControl59.TabIndex = 1
        Me.LabelControl59.Text = "Rating Moyen"
        '
        'frmDVD_Maint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1056, 778)
        Me.Controls.Add(Me.XTabControlProduct)
        Me.Controls.Add(Me.PanelControl10)
        Me.Name = "frmDVD_Maint"
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.PanelControl10, 0)
        Me.Controls.SetChildIndex(Me.XTabControlProduct, 0)
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelectCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XTabControlProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabControlProduct.ResumeLayout(False)
        Me.tabSearch.ResumeLayout(False)
        CType(Me.GridProductsDVD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryIProductProducts_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtDirectorSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearchImdbId_serie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearchImdb_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        CType(Me.grpVOD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpVOD.ResumeLayout(False)
        Me.grpVOD.PerformLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVODAudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.grpActors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpActors.ResumeLayout(False)
        CType(Me.GridActors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewActors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbActors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grpImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpImage.ResumeLayout(False)
        CType(Me.PictProducts_Image.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSeries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSeries.ResumeLayout(False)
        Me.grpSeries.PerformLayout()
        CType(Me.txtImdb_id_serie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieNbr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        CType(Me.txtEpisodeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSeasonID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVodNextNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVodNextLU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVodNext.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProducts_product_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIMDB_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInCinemaNow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProducts_Media.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProducts_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProducts_Status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDirector.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPictureFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPublic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbcountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRunTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateAvailable.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateAvailable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateAdded.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateAdded.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFR.ResumeLayout(False)
        Me.tabFR.PerformLayout()
        CType(Me.txtAwardFR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescFR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictFR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImageFR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtURLFr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameFR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNL.ResumeLayout(False)
        Me.tabNL.PerformLayout()
        CType(Me.txtAwardNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImageNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtURLNl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEN.ResumeLayout(False)
        Me.tabEN.PerformLayout()
        CType(Me.txtAwardEN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescEN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictEN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImageEN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtURLEn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameEN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCategories.ResumeLayout(False)
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.TreeListCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl11.ResumeLayout(False)
        Me.tabLanguages.ResumeLayout(False)
        CType(Me.grpSubTitles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSubTitles.ResumeLayout(False)
        CType(Me.GridUndertitles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewUndertitles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUndertitles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.grpLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLanguage.ResumeLayout(False)
        CType(Me.GridLanguages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewLanguages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguages1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.tabTrailers.ResumeLayout(False)
        CType(Me.grpTrailers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTrailers.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridStreamingTrailers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabVod.ResumeLayout(False)
        Me.tabVod.PerformLayout()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguageSubtitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguageSound.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateExpired.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateExpired.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFilename.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAvailable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImdbView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCritiques.ResumeLayout(False)
        Me.tabCritiques.PerformLayout()
        CType(Me.GridCritiques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCritiques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabVodWishlist.ResumeLayout(False)
        CType(Me.GridVODWishlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewVODWishlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgIMDBID_5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgIMDBID_4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgIMDBID_3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgIMDBID_2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgIMDBID_1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl10.ResumeLayout(False)
        Me.PanelControl10.PerformLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sSQL As String
    Private _ctrlGridControl As PlushBuziness.ClsGridControl
    'Dim _CheckProcess As ClsCheckProcessLogistic

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()

    End Sub
    Dim KeyDataSet As String = "BizzLib.dsGeneral" 'The Dataset used 
    Dim CurrentProductID As Integer
    Dim CurrentDVDID As Integer = -1
    Dim CurrentOrderID As Integer = -1
    Dim MainData As clsProduct_DVD
    ' Dim sem As New Semaphore(0, 100)
    '  Dim boolLoadingDVDInfo As Boolean = False
    '  Dim boolLoadingOrder As Boolean = False
    Private Enum TypeOfTab

        FR = 0
        NL
        EN
        THEMES
        LANGUAGES
        TRAILERS
        FEESHARING
        DVD
        GAMES
        WISHLISTCUST
        TRANSFER
        PREVISION
        VOD
        CRITIQUES
        VODWISHLIST


    End Enum
    Dim LstRefreshData As New List(Of Boolean)
    Dim _listFeeSharingStudio As New List(Of PlushBuziness.clsKeyCombo)



    Dim mvarImagesServer As String = ""
    Public Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim menuStrip As New PlushBuziness.contextMenu()
        GridProductsDVD.ContextMenuStrip = menuStrip
        GridActors.ContextMenuStrip = menuStrip
        GridLanguages.ContextMenuStrip = menuStrip
        GridUndertitles.ContextMenuStrip = menuStrip
        'GridTrailers.ContextMenuStrip = menuStrip
        'GridSoundtracks.ContextMenuStrip = menuStrip
        'GridProducts_DVD.ContextMenuStrip = menuStrip
        'GridDVDStatusHistory.ContextMenuStrip = menuStrip
        'GridOrders_History.ContextMenuStrip = menuStrip
        'GridOrdersStatusHistory.ContextMenuStrip = menuStrip
        'GridPrevision.ContextMenuStrip = menuStrip
        'GridWishlistCustomers.ContextMenuStrip = menuStrip
        GridCritiques.ContextMenuStrip = menuStrip


        'tabGames.PageVisible = False

        Try

            'SetUp of Variables
            KeyFieldName = "products_id"
            IDField = "products_id"
            TableName = "products"
            MainDataSet = objDS
            'Attempt to load the dataset.
            mvarImagesServer = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global' and Name = 'ImagesServer'")
            Me.LoadBKComboSet()
            BKGlobal.LoadAssociatedMenu(Me.Tag, PopMenuAssociatedTasks, Me)
            btnNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            DefaultSet_Bar.Visible = False
            Filter_Bar.Visible = False
            Misc_Bar2.Visible = False

            XTabControlProduct.SelectedTabPage = tabSearch

            ' recupe variable products_id  provenant du frmCustomer_maint GridViewOrders par la DVDPostBuziness.clsSingleton
            Dim params As PlushBuziness.clsSingleton = Nothing
            params = PlushBuziness.clsSingleton.Instance()
            Dim Dvd_Pr_ID As Integer = params.Products_dvd_id

            If Dvd_Pr_ID <> Nothing Then
                txtQuickSearch.EditValue = Dvd_Pr_ID
                If IsNumeric(txtQuickSearch.EditValue) Then
                    CurrentProductID = txtQuickSearch.EditValue
                    LoadProductsInfo()
                    If XTabControlProduct.SelectedTabPage.Name = tabSearch.Name Then
                        XTabControlProduct.SelectedTabPage = tabMain
                    End If
                End If
            End If

            'initCheckProcess()
            'clsDevExpress.AddHyperlinkDynamic(GridOrders_History)
            'loadWhereDvd()

        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Stock, eLoad)
            ' System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
    End Sub
#Region "EDIT SAVE NEW"
    Private Sub NewRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuNew.Click, MyBase.EventNewRecord
        SetState(NewState)
        PopMenuNew.Enabled = False
        PopMenuEdit.Enabled = False
        PopMenuSave.Enabled = True
        PopMenuDelete.Enabled = False
        PopMenuUndo.Enabled = True
        EnablingAll(True)
        OpenType = "NEW"
        Try
            'Clear out the current edits
            Me.BindingContext(objDS, TableName).EndCurrentEdit()
            MainData = New clsProduct_DVD(SessionInfo, objDS, 0, 0)
            CurrentProductID = MainData.AddNewProduct()
            txtQuickSearch.EditValue = CurrentProductID
            LoadProductsInfo()
            EditRecord(Sender, e)
        Catch eEndEdit As System.Exception
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Stock, eEndEdit)
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try

    End Sub
    Private Sub EditRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuEdit.Click, MyBase.EventEditRecord
        If Me.BindingContext(objDS, TableName).Position < 0 Then
            Exit Sub
        End If
        SetState(EditState)
        PopMenuNew.Enabled = False
        PopMenuEdit.Enabled = False
        PopMenuSave.Enabled = True
        PopMenuDelete.Enabled = False
        PopMenuUndo.Enabled = True
        EnablingForEdit()
        OpenType = "EDIT"
    End Sub
    Private Sub UndoChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuUndo.Click, MyBase.EventUndoChanges
        SetState(BrowseState)
        PopMenuNew.Enabled = True
        PopMenuEdit.Enabled = True
        PopMenuSave.Enabled = False
        PopMenuDelete.Enabled = True
        PopMenuUndo.Enabled = False
        EnablingAll(False)
        Me.BindingContext(objDS, TableName).CancelCurrentEdit()
        LoadProductsInfo()
        OpenType = "BROWSE"
    End Sub
    Private Sub SaveChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuSave.Click, MyBase.EventSaveChanges

        Try
            'Validate Fields and assign any Necessary ID
            MainData.ValidateRecordFields(CType(Me.BindingContext(objDS, TableName).Current, DataRowView))
            'Attempt to update the datasource.
            Me.UpdateDataSet()
            Me.objDS.products(0).products_last_modified = DateTime.Now
            Me.UpdateDataSet()
            RefreshPictureFR()
            RefreshPictureEN()
            RefreshPictureNL()
            SetState(BrowseState)
            PopMenuNew.Enabled = True
            PopMenuEdit.Enabled = True
            PopMenuSave.Enabled = False
            PopMenuDelete.Enabled = True
            PopMenuUndo.Enabled = False
            EnablingAll(False)
            OpenType = "BROWSE"
        Catch eUpdate As System.Exception
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Stock, eUpdate)
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        Finally
        End Try
    End Sub
    Public Sub UpdateDataSet() Handles MyBase.EventUpdateDataset
        Try
            'Stop any current edits.
            Me.BindingContext(objDS, TableName).EndCurrentEdit()
            GridViewActors.CloseEditor()
            GridViewActors.UpdateCurrentRow()
            Me.BindingContext(objDS, "products_to_actors").EndCurrentEdit()
            GridViewLanguages.CloseEditor()
            GridViewLanguages.UpdateCurrentRow()
            Me.BindingContext(objDS, "products_to_languages").EndCurrentEdit()
            GridViewUndertitles.CloseEditor()
            GridViewUndertitles.UpdateCurrentRow()
            Me.BindingContext(objDS, "products_to_undertitles").EndCurrentEdit()
            'GridViewSoundTracks.CloseEditor()
            'GridViewSoundTracks.UpdateCurrentRow()
            Me.BindingContext(objDS, "products_to_soundtracks").EndCurrentEdit()
            'GridViewTrailers.CloseEditor()
            'GridViewTrailers.UpdateCurrentRow()
            'Me.BindingContext(objDS, "products_trailers").EndCurrentEdit()
            Me.BindingContext(objDS, "products_description_fr").EndCurrentEdit()
            Me.BindingContext(objDS, "products_description_nl").EndCurrentEdit()
            Me.BindingContext(objDS, "products_description_en").EndCurrentEdit()
            'Saving Category Tree
            Dim _node As DevExpress.XtraTreeList.Nodes.TreeListNode
            For Each _node In TreeListCategories.Nodes
                SaveCategoryNode(_node)
            Next
            'For Each _node In TreeListThemes.Nodes
            '    SaveThemeNode(_node)
            'Next
            'Changing GommetteInfo
            'UpdateGommetteInfo()
            MainData.SaveAll(txtIMDB_ID.Text)

            'If XTabControlProduct.SelectedTabPage Is tabFeeSharing Then
            '    SaveMoviemax()
            'End If
            objDS.AcceptChanges()
        Catch ex As Exception
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Stock, ex)
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SaveCategoryNode(ByVal Node1 As DevExpress.XtraTreeList.Nodes.TreeListNode)
        Dim _row As DataRow
        Dim _Node As DevExpress.XtraTreeList.Nodes.TreeListNode
        _row = objDS.Tables("products_to_categories").Rows.Find(New Object() {CurrentProductID, Node1("categories_id")})
        If Node1("category_selected") = 1 Then
            If IsNothing(_row) Then
                _row = objDS.Tables("products_to_categories").NewRow
                _row("products_id") = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField)
                _row("categories_id") = Node1("categories_id")
                objDS.Tables("products_to_categories").Rows.Add(_row)
            End If
        Else
            'UnChecked
            If Not IsNothing(_row) Then
                _row.Delete()
            End If
        End If
        For Each _Node In Node1.Nodes
            SaveCategoryNode(_Node)
        Next
    End Sub
    Private Sub SaveThemeNode(ByVal Node1 As DevExpress.XtraTreeList.Nodes.TreeListNode)
        Dim _row As DataRow
        Dim _Node As DevExpress.XtraTreeList.Nodes.TreeListNode
        _row = objDS.Tables("products_to_themes").Rows.Find(New Object() {CurrentProductID, Node1("themes_id")})
        If Node1("themes_selected") = 1 Then
            If IsNothing(_row) Then
                _row = objDS.Tables("products_to_themes").NewRow
                _row("products_id") = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField)
                _row("themes_id") = Node1("themes_id")
                objDS.Tables("products_to_themes").Rows.Add(_row)
            End If
        Else
            'UnChecked
            If Not IsNothing(_row) Then
                _row.Delete()
            End If
        End If
        For Each _Node In Node1.Nodes
            SaveThemeNode(_Node)
        Next
    End Sub
    Private Sub SaveMoviemax()
        'If cmbFeeSharingStudio.EditValue = DvdPostData.clsFeeSharing.feeSharingStudio.MOVIEMAX Then

        '    Dim products_id As Integer = CurrentProductID
        '    Dim ok As Boolean = DvdPostData.clsConnection.ExecuteScalar(DvdPostData.clsFeeSharing.moviemaxExist(products_id))
        '    Dim titelNr As Integer = txtTiteNrMovieMax.EditValue
        '    Dim maatschappij As Integer = cmbMovieMaxPartner.EditValue


        '    If ok = False Then
        '        Dim sql As String = DvdPostData.clsFeeSharing.insertMovieMax(products_id, titelNr, maatschappij)
        '        DvdPostData.clsConnection.ExecuteNonQuery(sql)
        '    End If

        '    If ok = True Then
        '        Dim updateSql As String = DvdPostData.clsFeeSharing.updateMovieMaxInput(products_id, txtTiteNrMovieMax.EditValue, cmbMovieMaxPartner.EditValue)
        '        DvdPostData.clsConnection.ExecuteNonQuery(updateSql)
        '    End If
        'End If
    End Sub
#End Region

#Region "Load Data"

    Private Sub InitRefeshTab()
        LstRefreshData.Clear()
        For Each Item As TypeOfTab In [Enum].GetValues(GetType(TypeOfTab))
            LstRefreshData.Add(True)
        Next

    End Sub

    'Private Sub loadWhereDvd()
    '    Dim lstWhereDvd As New List(Of DVDPostBuziness.clsKeyCombo)
    '    Dim sql As String
    '    Dim item As DVDPostBuziness.clsKeyCombo

    '    item = New DVDPostBuziness.clsKeyCombo()
    '    item.DisplayMember = PlushTools.clsEnum.getNameStrEnum(DvdPostData.ClsCustomersData.WhereDVD.IN)
    '    item.Value = DvdPostData.ClsCustomersData.WhereDVD.IN

    '    lstWhereDvd.Add(item)

    '    item = New DVDPostBuziness.clsKeyCombo()
    '    item.DisplayMember = PlushTools.clsEnum.getNameStrEnum(DvdPostData.ClsCustomersData.WhereDVD.OUT)
    '    item.Value = DvdPostData.ClsCustomersData.WhereDVD.OUT
    '    lstWhereDvd.Add(item)

    '    cmbInOut.ValueMember = "Value"
    '    cmbInOut.DisplayMember = "DisplayMember"
    '    cmbInOut.DataSource = lstWhereDvd

    'End Sub
    'Private Sub LoadOrdersData(ByVal vDVD_ID As Integer)

    '    '  If boolLoadingOrder = True Then Exit Sub
    '    '  boolLoadingOrder = True
    '    objDS.orders_products_view1.Clear()
    '    Dim _SQLTxt As String
    '    If vDVD_ID <> -1 Then
    '        _SQLTxt = "select op.orders_id,o.orders_status, o.customers_id,o.customers_name,op.products_id, op.products_dvd as dvd_id, o.delivery_country, o.delivery_name, o.customers_email_address, " & _
    '                    " op.pick_group, op.pick_boxid, o.date_purchased, op.orders_products_status , os.name orders_status_name,o.orders_type" & _
    '                    " from orders_products op left join orders o on o.orders_id = op.orders_id " & _
    '                    " join orders_status_new os on o.orders_status = os.id " & _
    '                    " where op.products_id = " & CurrentProductID & " AND op.products_dvd = " & CurrentDVDID & _
    '                    " ORDER BY op.orders_id desc "
    '    Else
    '        _SQLTxt = "select o.orders_type,op.orders_id,o.orders_status, o.customers_id, op.products_id, op.products_dvd as dvd_id, o.delivery_country, o.delivery_name, o.customers_email_address, " & _
    '                                " op.pick_group, op.pick_boxid, o.date_purchased, op.orders_products_status ,os.name orders_status_name,o.orders_type" & _
    '                                " from orders_products op left join orders o on o.orders_id = op.orders_id " & _
    '                                " join orders_status_new os on o.orders_status = os.id " & _
    '                                " where op.products_id = " & CurrentProductID & _
    '                                " ORDER BY op.orders_id desc "
    '    End If
    '    DvdPostData.clsConnection.FillDataSet(objDS.orders_products_view1, _SQLTxt)
    '    ' boolLoadingOrder = False
    'End Sub
    'Private Sub LoadProductsDVDStatusHistory(ByVal vDVD_ID As Integer)
    '    If CurrentProductID < 1 Then Exit Sub
    '    objDS.products_dvd_status_history.Clear()
    '    Dim _SQLTxt As String
    '    _SQLTxt = "select * from products_dvd_status_history where products_id = " & CurrentProductID & " AND products_dvdid = " & CurrentDVDID
    '    DvdPostData.clsConnection.FillDataSet(objDS.products_dvd_status_history, _SQLTxt)
    'End Sub
    'Private Sub loadFeeSharingStudio()
    '    _listFeeSharingStudio.Clear()
    '    _listFeeSharingStudio.Add(New DVDPostBuziness.clsKeyCombo("", 0))
    '    _listFeeSharingStudio.Add(New DVDPostBuziness.clsKeyCombo("Universal/Global Data", DvdPostData.clsFeeSharing.feeSharingStudio.UNIVERSAL_GLOBAL_DATA))
    '    _listFeeSharingStudio.Add(New DVDPostBuziness.clsKeyCombo("MovieMax", DvdPostData.clsFeeSharing.feeSharingStudio.MOVIEMAX))

    '    cmbFeeSharingStudio.Properties.DataSource = _listFeeSharingStudio
    'End Sub
    'Private Sub loadcmbMovieMaxPartner()

    '    Dim dt As DataTable
    '    Dim sql As String = DvdPostData.clsFeeSharing.GetMovieMaxPartner()

    '    dt = DvdPostData.clsConnection.FillDataSet(sql)
    '    cmbMovieMaxPartner.Properties.DataSource = dt
    '    cmbMovieMaxPartner.ItemIndex = -1
    '    cmbMovieMaxPartner.EditValue = DBNull.Value


    'End Sub
    'Private Sub LoadMovieMaxInfo()

    '    loadcmbMovieMaxPartner()
    '    txtTiteNrMovieMax.EditValue = ""
    '    If cmbFeeSharingStudio.EditValue = DvdPostData.clsFeeSharing.feeSharingStudio.MOVIEMAX Then

    '        Dim dt As DataTable
    '        Dim sql As String = DvdPostData.clsFeeSharing.GetMovieMaxInput(CurrentProductID)
    '        dt = DvdPostData.clsConnection.FillDataSet(sql)

    '        If Not dt.Rows.Count = 0 Then
    '            txtTiteNrMovieMax.EditValue = dt.Rows(0)("titelnr")
    '            cmbMovieMaxPartner.EditValue = dt.Rows(0)("maatschappij")
    '        End If

    '    End If

    'End Sub
    Private Sub LoadLanguagesData()
        PlushData.clsConnection.FillDataSet(objDS.languages, "SELECT * FROM languages")
    End Sub
    Private Sub loadStudio()
        PlushData.clsConnection.FillDataSet(objDS.studio, "SELECT * FROM studio")
    End Sub
    Private Sub loadDirectors()
        PlushData.clsConnection.FillDataSet(objDS.directors, "SELECT * FROM directors")
    End Sub
    Private Sub LoadActors()
        PlushData.clsConnection.FillDataSet(objDS.actors, "SELECT * FROM actors order by actors_name ")
    End Sub
    Private Sub loadSeries()
        PlushData.clsConnection.FillDataSet(objDS.series, "SELECT * FROM series")
    End Sub
    Private Sub LoadProductsLanguage()
        PlushData.clsConnection.FillDataSet(objDS.products_languages, "SELECT * FROM products_languages where languagenav_id = 1 ")
    End Sub
    Private Sub loadProductsCountries()
        PlushData.clsConnection.FillDataSet(objDS.products_countries, "SELECT * FROM products_countries")
    End Sub
    Private Sub loadProductsUndertitle()
        PlushData.clsConnection.FillDataSet(objDS.products_undertitles, "SELECT * FROM products_undertitles  where language_id = 1 ")
    End Sub
    Private Sub loadProductsSoundtracks()
        PlushData.clsConnection.FillDataSet(objDS.products_soundtracks, "SELECT * FROM products_soundtracks  where language_id = 1 ")
    End Sub
    Private Sub loadCritique(ByVal products_id As Integer)
        If LstRefreshData(TypeOfTab.CRITIQUES) Then
            Dim dt_reviews As DataTable
            Dim dt_average As DataTable
            Dim dr_average As DataRow

            dt_reviews = PlushBuziness.clsReviews.GetReviewProduct(products_id)
            GridCritiques.DataSource = dt_reviews
            GridViewCritiques.BestFitColumns()
            clsDevExpress.AddHyperlinkDynamic(GridCritiques)
            clsDevExpress.AddCountFooter(GridCritiques)

            dt_average = PlushBuziness.clsReviews.GetAverageCritiqueProducts(products_id)

            If dt_average.Rows.Count > 0 Then
                dr_average = dt_average.Rows(0)
                lblValueNbCrtitiques.Text = dr_average("cpt_critiques")
                lblValueNbCritiquePositive.Text = dr_average("cpt_critiques_positive")
                lblValueRatingAverage.Text = dr_average("average_rating_critique")
            End If

            dt_average = PlushBuziness.clsReviews.GetAverageRatingProducts(products_id)
            If dt_average.Rows.Count > 0 Then
                dr_average = dt_average.Rows(0)
                lblValueNBRating.Text = dr_average("cpt_rating")
            End If

            LstRefreshData(TypeOfTab.CRITIQUES) = False
        End If
    End Sub
    Private Sub loadVOD(ByVal product_id As Integer)
        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.clsProductDvd.GetSelectVod(product_id)
        dt = PlushData.clsConnection.FillDataSet(sql)

    End Sub
    'Private Sub loadWishlistCustomers(ByVal product_id As Integer)
    '    Dim sql As String
    '    Dim dt As DataTable
    '    If LstRefreshData(TypeOfTab.WISHLISTCUST) Then
    '        sql = DvdPostData.clsProductDvd.GetSelectWishlistCustomerProduct(product_id)
    '        dt = DvdPostData.clsConnection.FillDataSet(sql)
    '        gridViewWishlistCustomers.Columns.Clear()
    '        GridWishlistCustomers.DataSource = dt
    '        gridViewWishlistCustomers.BestFitColumns()
    '        clsDevExpress.AddHyperlinkDynamic(GridWishlistCustomers)
    '        clsDevExpress.AddCountFooter(GridWishlistCustomers)
    '        LstRefreshData(TypeOfTab.WISHLISTCUST) = False
    '    End If
    'End Sub
    Private Sub loadVodWishlist(ByVal product_id As Integer)
        Dim sql As String
        Dim dt As DataTable
        If LstRefreshData(TypeOfTab.VODWISHLIST) Then
            sql = PlushData.ClsVod.GetSelectVodWishlist(product_id)
            dt = PlushData.clsConnection.FillDataSet(sql)
            gridViewVODWishlist.Columns.Clear()
            GridVODWishlist.DataSource = dt
            gridViewVODWishlist.BestFitColumns()
            'clsDevExpress.AddHyperlinkDynamic(GridWishlistCustomers)
            'clsDevExpress.AddCountFooter(GridWishlistCustomers)
            LstRefreshData(TypeOfTab.VODWISHLIST) = False
        End If
    End Sub
    'Private Sub loadPrevision(ByVal product_id As Integer)
    '    Dim sql As String
    '    Dim dt As DataTable
    '    If LstRefreshData(TypeOfTab.PREVISION) Then
    '        sql = DvdPostData.ClsPurchaseSale.GetSelectViewPurchaseSaleByProducts(product_id)
    '        dt = DvdPostData.clsConnection.FillDataSet(sql)
    '        GridViewPrevision.Columns.Clear()
    '        GridPrevision.DataSource = dt
    '        GridViewPrevision.BestFitColumns()
    '        clsDevExpress.AddHyperlinkDynamic(GridPrevision)
    '        _ctrlGridControl = New DVDPostBuziness.ClsGridControl()
    '        AddHandler _ctrlGridControl.Purchase_click, AddressOf Purchase_click
    '        _ctrlGridControl.addColumnButtonOrderPurchase(GridPrevision, GridViewPrevision)
    '        LstRefreshData(TypeOfTab.PREVISION) = False
    '    End If
    'End Sub
    'Private Sub loadFeeSharing()
    '    If LstRefreshData(TypeOfTab.FEESHARING) = True Then
    '        loadFeeSharingStudio()
    '        LoadMovieMaxInfo()

    '        LstRefreshData(TypeOfTab.FEESHARING) = False
    '    End If
    'End Sub
    Private Sub LoadFR()
        If LstRefreshData(TypeOfTab.FR) Then
            MainData.LoadDescriptionFR()
            RefreshPictureFR()
        End If
        LstRefreshData(TypeOfTab.FR) = False
    End Sub
    Private Sub LoadNL()
        If LstRefreshData(TypeOfTab.NL) Then
            MainData.LoadDescriptionNL()
            RefreshPictureNL()
        End If
        LstRefreshData(TypeOfTab.NL) = False
    End Sub
    Private Sub LoadEN()
        If LstRefreshData(TypeOfTab.EN) Then
            MainData.LoadDescriptionEN()
            RefreshPictureEN()
        End If
        LstRefreshData(TypeOfTab.EN) = False
    End Sub
    'Private Sub loadDVD()
    '    If LstRefreshData(TypeOfTab.DVD) Then
    '        MainData.Load_All_Products_DVD_Info()
    '        ' Me.GridProducts_DVD.RefreshDataSource()

    '    End If
    '    LstRefreshData(TypeOfTab.DVD) = False
    'End Sub
    Private Sub loadTrailer()
        If LstRefreshData(TypeOfTab.TRAILERS) Then
            'MainData.LoadTrailers()
            MainData.LoadStreamingTrailers()
            MainData.LoadSoundtracks()
            RefreshPictureTrailer()
        End If
        LstRefreshData(TypeOfTab.TRAILERS) = False
    End Sub

    Private Sub loadLanguages()
        If LstRefreshData(TypeOfTab.LANGUAGES) Then
            MainData.LoadLanguages()
            MainData.LoadUndertitles()
        End If
        LstRefreshData(TypeOfTab.LANGUAGES) = False
    End Sub
    Private Sub loadTheme()
        If LstRefreshData(TypeOfTab.THEMES) Then
            TreeListCategories.Nodes.Clear()
            'TreeListThemes.Nodes.Clear()
            'MainData.LoadThemes()
            MainData.LoadCategories()
            RefreshCategoryTree()
            '  TreeListCategories.Refresh()
            'RefreshThemeTree()
        End If
        LstRefreshData(TypeOfTab.THEMES) = False
    End Sub
    'Private Sub loadTransfer()
    '    If LstRefreshData(TypeOfTab.TRANSFER) Then
    '        MainData.Load()
    '    End If
    '    LstRefreshData(TypeOfTab.TRANSFER) = False
    'End Sub
    'Private Sub loadDVDStatus()
    '    DvdPostData.clsConnection.FillDataSet(objDS.products_dvd_status, "SELECT * FROM products_dvd_status ")
    'End Sub

    Public Sub LoadBKComboSet()
        Try

            LoadLanguagesData()
            loadStudio()
            loadDirectors()
            LoadActors()
            loadSeries()
            LoadProductsLanguage()
            loadProductsCountries()
            loadProductsUndertitle()
            loadProductsSoundtracks()
            'loadDVDStatus()
            loadProductsCountries()


            PlushData.clsConnection.FillDataSet(objDS.view_products_status, "SELECT codevalue as status_id, codedesc as status_desc from generalglobalcode where CodeType = 'Products_Status'")
            PlushData.clsConnection.FillDataSet(objDS.view_products_type, "SELECT codevalue as type_id, codedesc as type_desc from generalglobalcode where CodeType = 'Products_Type'")
            PlushData.clsConnection.FillDataSet(objDS.product_type, "SELECT CodeValue , CodeDesc from generalglobalcode where CodeType = 'product_type'")
            PlushData.clsConnection.FillDataSet(objDS.view_products_media, "SELECT codevalue as media_id, codedesc as media_desc from generalglobalcode where CodeType = 'Products_Media'")
            PlushData.clsConnection.FillDataSet(objDS.view_products_availability, "SELECT codevalue as availability_id, codedesc as availability_desc from generalglobalcode where CodeType = 'Products_Availability'")
            PlushData.clsConnection.FillDataSet(objDS.view_products_rating, "SELECT codevalue as rating_id, codedesc as rating_desc from generalglobalcode where CodeType = 'Products_Rating'")

            PlushData.clsConnection.FillDataSet(objDS.public1, "SELECT * FROM public where language_id = 1 order by public_id ")
            PlushData.clsConnection.FillDataSet(objDS.picture_format, "SELECT * FROM picture_format where language_id = 1 order by picture_format_id ")

            'DvdPostData.clsConnection.FillDataSet(objDS.orders_products_status, "SELECT * FROM orders_products_status  where language_id = 1 ")
            'DvdPostData.clsConnection.FillDataSet(objDS.orders_status, "SELECT * FROM orders_status_new ")
            PlushData.clsConnection.FillDataSet(objDS.trailers_broadcast, "SELECT codevalue as broadcast from generalglobalcode where CodeType = 'trailers_broadcast'")
        Catch ex As Exception
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Stock, ex)
            Throw ex
        End Try
    End Sub
    Public Sub LoadOneCombo(ByVal stateInfo As Object)
        Dim _ComboParam As ComboParam = CType(stateInfo, ComboParam)
        PlushData.clsConnection.FillDataSet(_ComboParam.LTable, _ComboParam.LSQLStr)
    End Sub

#End Region
    Private Sub ClearData()

        objDS.products.Clear()
        objDS.products_description.Clear()
        objDS.products_trailers.Clear()
        objDS.products_description_fr.Clear()
        objDS.products_description_nl.Clear()
        objDS.products_description_en.Clear()
        objDS.products_to_actors.Clear()
        objDS.products_to_categories.Clear()
        objDS.products_to_languages.Clear()
        objDS.products_to_soundtracks.Clear()
        objDS.products_to_undertitles.Clear()

    End Sub
    'Public Sub UpdateGommetteInfo()
    '    Dim _row As DataRowView
    '    Dim _intFR As Integer = 0
    '    Dim _intNL As Integer = 0
    '    Dim _view As DataView
    '    _view = New DataView(objDS.products_to_languages, "", "", DataViewRowState.CurrentRows)
    '    For Each _row In _view
    '        If _row("products_languages_id") = 1 Then _intFR += 1
    '        If _row("products_languages_id") = 2 Then _intNL += 1
    '    Next
    '    _view = New DataView(objDS.products_to_undertitles, "", "", DataViewRowState.CurrentRows)
    '    For Each _row In _view
    '        If _row("products_undertitles_id") = 1 Then _intFR += 1
    '        If _row("products_undertitles_id") = 2 Then _intNL += 1
    '    Next
    '    If _intFR > 0 Then
    '        objDS.products.Rows(0)("products_language_fr") = 1
    '    Else
    '        objDS.products.Rows(0)("products_language_fr") = 0
    '    End If

    '    If _intNL > 0 Then
    '        objDS.products.Rows(0)("products_undertitle_nl") = 1
    '    Else
    '        objDS.products.Rows(0)("products_undertitle_nl") = 0
    '    End If
    'End Sub
    Public Sub LoadProductsInfo()
        ' boolLoadingDVDInfo = True

        ClearData()
        MainData = New clsProduct_DVD(SessionInfo, objDS, CurrentProductID, 0)
        'objDS.orders_status_history.Clear()
        'objDS.orders_products_view1.Clear()
        If txtQuickSearch.EditValue <> CurrentProductID.ToString() Then
            txtQuickSearch.EditValue = CurrentProductID
        End If
        InitRefeshTab()

        RefreshTab(XTabControlProduct.SelectedTabPage)
        ' MainData.LoadProductsDetail()
        MainData.LoadActors()
        'MainData.LoadTrailers()
        MainData.LoadSoundtracks()
        loadTheme()
        MainData.LoadVod()
        'MainData.LoadLanguages()
        'MainData.LoadUndertitles()
        'MainData.LoadTrailers()
        'MainData.LoadSoundtracks()
        'MainData.LoadDescriptionFR()
        'MainData.LoadDescriptionNL()
        'MainData.LoadDescriptionEN()
        ' MainData.Load_All_Products_DVD_Info()
        'RefreshSmallPicture()
        'RefreshPictureFR()
        'RefreshPictureNL()
        'RefreshPictureEN()
        'RefreshCategoryTree()
        'RefreshThemeTree()
        ''  boolLoadingDVDInfo = False
        'RefreshCategoryTree()

        '  loadPrevision(CurrentProductID)
        '  loadWishlistCustomers(CurrentProductID)

    End Sub
    Private Sub EnablingEditFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingEditFields
        txtModel.Enabled = Enabling
        txtTitle.Enabled = Enabling
        'txtQty.Enabled = Enabling
        'txtQtyNow.Enabled = Enabling
        'txtDateAdded.Enabled = Enabling
        txtDateAvailable.Enabled = Enabling
        cmbProducts_Media.Enabled = Enabling
        cmbProducts_Status.Enabled = Enabling
        cmbProducts_Type.Enabled = Enabling
        txtYear.Enabled = Enabling
        txtRunTime.Enabled = Enabling
        cmbcountry.Enabled = Enabling
        cmbStudio.Enabled = Enabling
        cmbDirector.Enabled = Enabling
        'cmbAvailability.Enabled = Enabling
        cmbRating.Enabled = Enabling
        cmbPictureFormat.Enabled = Enabling
        cmbPublic.Enabled = Enabling
        'txtPictureImage.Enabled = Enabling
        'txtOtherProductID.Enabled = Enabling
        txtIMDB_ID.Enabled = Enabling
        'txtSeasonID.Enabled = Enabling
        'txtEpisodeID.Enabled = Enabling
        txtImdb_id_serie.Enabled = Enabling

        'PictProducts_Image.Enabled = Enabling
        cmbSerie.Enabled = Enabling
        txtSerieNbr.Enabled = Enabling
        'cmbABOSerie.Enabled = Enabling
        'txtABOSerieNbr.Enabled = Enabling
        GridViewActors.OptionsBehavior.Editable = Enabling
        GridActors.EmbeddedNavigator.Enabled = Enabling
        GridViewLanguages.OptionsBehavior.Editable = Enabling
        GridLanguages.EmbeddedNavigator.Enabled = Enabling
        GridViewUndertitles.OptionsBehavior.Editable = Enabling
        GridUndertitles.EmbeddedNavigator.Enabled = Enabling
        'GridViewTrailers.OptionsBehavior.Editable = Enabling
        'GridTrailers.EmbeddedNavigator.Enabled = Enabling
        'GridViewSoundTracks.OptionsBehavior.Editable = Enabling
        'GridSoundtracks.EmbeddedNavigator.Enabled = Enabling
        'Desc FR
        txtNameFR.Enabled = Enabling
        txtURLFr.Enabled = Enabling
        txtDescFR.Enabled = Enabling
        txtImageFR.Enabled = Enabling
        txtAwardFR.Enabled = Enabling
        'Desc NL
        txtNameNL.Enabled = Enabling
        txtURLNl.Enabled = Enabling
        txtDescNL.Enabled = Enabling
        txtImageNL.Enabled = Enabling
        txtAwardNL.Enabled = Enabling
        'Desc EN
        txtNameEN.Enabled = Enabling
        txtURLEn.Enabled = Enabling
        txtDescEN.Enabled = Enabling
        txtImageEN.Enabled = Enabling
        txtAwardEN.Enabled = Enabling
        'FeeSharing
        'cmbMovieMaxPartner.Enabled = Enabling
        'txtTiteNrMovieMax.Enabled = Enabling
        'cmbMovieMaxPartner.Enabled = Enabling
        'cmbFeeSharingStudio.Enabled = Enabling

        'txtFeeSharing_End.Enabled = Enabling


        'txtFeeSharing_TurnPrice.Enabled = Enabling

        'txtFeeSharing_UpfrontFee.Enabled = Enabling

        chkInCinemaNow.Enabled = Enabling
        'chkInTheBags.Enabled = Enabling
        'chkInTheBagsNext.Enabled = Enabling
        'chkProduct_Next.Enabled = Enabling
        chkVodNext.Enabled = Enabling
        chkVodNextLU.Enabled = Enabling
        chkVodNextNL.Enabled = Enabling
        'Categories
        TreeListCategories.OptionsBehavior.Editable = Enabling
        'TreeListThemes.OptionsBehavior.Editable = Enabling
        'Sale/Purchqse
        'txtPrice.Enabled = Enabling
        'txtQty_to_sale.Enabled = Enabling
        'txtSale_price.Enabled = Enabling
        'txtSaleDate.Enabled = Enabling
        'txtNew_qty_to_sale.Enabled = Enabling
        'txtNew_Sale_Price.Enabled = Enabling
        'chkOnly_for_sale.Enabled = Enabling
        cmbProducts_product_type.Enabled = Enabling
        'chkGameOnline.Enabled = Enabling
        'txtGame_ConfigMini.Enabled = Enabling
        'txtGame_NbrOfPlayersOnline.Enabled = Enabling
        'txtGame_NbrOfPlayers.Enabled = Enabling


    End Sub
    Private Sub EnablingKeyFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingkeyFields
        'ToBeChecked ***
    End Sub
    Private Sub StartPrintForm() Handles MyBase.EventPrintForm
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            'Find EntityView1Row
            Dim _SQLTxt As String = "SELECT * FROM generalentityView1 WHERE EntityID = " & CType(Me.BindingContext(objDS, TableName).Current, DataRowView)("EntityID")
            Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)
            objDS.Tables("generalentityView1").Clear()
            _Cls1.FillDataSet(objDS.Tables("generalentityView1"), _SQLTxt)
            If objDS.Tables("generalentityView1").Rows.Count = 1 Then
                BKReport.PrintForm(CurrentReportID, New DataRow() { _
                    objDS.Tables("generalentityView1").Rows(0), _
                    CType(Me.BindingContext(objDS, "GeneralAddress").Current, DataRowView).Row})
            End If
        End If
    End Sub
    Private Sub StartDesignReport() Handles MyBase.EventDesignReport
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            'Find EntityView1Row
            Dim _SQLTxt As String = "SELECT * FROM generalentityView1 WHERE EntityID = " & CType(Me.BindingContext(objDS, TableName).Current, DataRowView)("EntityID")
            Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)
            objDS.Tables("generalentityView1").Clear()
            _Cls1.FillDataSet(objDS.Tables("generalentityView1"), _SQLTxt)
            If objDS.Tables("generalentityView1").Rows.Count = 1 Then
                BKReport.DesignReport(CurrentReportID, New DataRow() { _
                    objDS.Tables("generalentityView1").Rows(0), _
                    CType(Me.BindingContext(objDS, "GeneralAddress").Current, DataRowView).Row})
            End If
        End If
    End Sub

#Region "Search"
    Public Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Search()
    End Sub
    Public Sub Search()
        Dim _SQLTxt As String
        Dim dt As DataTable
        Dim searchTitle As String = String.Empty
        Dim searchImdb As String = String.Empty
        Dim searchImdb_id_serie As String = String.Empty
        Dim searchProducts_id As String = String.Empty
        Dim productsMedia As String = String.Empty
        Dim director As String = String.Empty

        If Not txtTitleSearch.EditValue Is Nothing AndAlso txtTitleSearch.EditValue <> "" Then
            searchTitle = " and products_name like '%" & txtTitleSearch.Text.Trim & "%'"
        End If

        If Not txtSearchImdb_id.EditValue Is Nothing AndAlso txtSearchImdb_id.EditValue <> "" Then
            searchImdb = " and imdb_id = " & txtSearchImdb_id.Text.Trim
        End If

        If Not txtSearchImdbId_serie.EditValue Is Nothing AndAlso txtSearchImdbId_serie.EditValue <> "" Then
            searchImdb_id_serie = " and imdb_id_serie = " & txtSearchImdbId_serie.Text.Trim
        End If

        'If Not txtSearchProductID.EditValue Is Nothing AndAlso txtSearchProductID.EditValue <> "" Then
        '    searchProducts_id = " and P.products_id = " & txtSearchProductID.Text.Trim
        'End If

        'If Not txtProducts_Media.EditValue Is Nothing AndAlso txtProducts_Media.EditValue <> "" Then
        '    productsMedia = " and P.products_media = '" & txtProducts_Media.Text.Trim & "'"
        'End If

        If Not txtDirectorSearch.EditValue Is Nothing AndAlso txtDirectorSearch.EditValue <> "" Then
            director = " and P.products_directors_id in (select directors_id from directors where directors_name like '%" & txtDirectorSearch.Text.Trim & "%' ) "
        End If

        _SQLTxt = "SELECT PD.products_id, PD.language_id, PD.products_name , P.products_model as products_model, P.products_media " & _
                  " FROM products_description PD " & _
                  " Left join products P on P.products_id = PD.products_id " & _
                  " where 1 = 1" & searchTitle & searchImdb & searchImdb_id_serie & searchProducts_id & productsMedia & director & _
                  " group by P.products_id "
        ' objDS.products_description1.Clear()
        ' DvdPostData.clsConnection.FillDataSet(objDS.products_description1, _SQLTxt)
        dt = PlushData.clsConnection.FillDataSet(_SQLTxt)
        GridProductsDVD.DataSource = dt

    End Sub
    Private Sub txtTitleSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTitleSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Search()
        End If
    End Sub
    'Private Sub GridViewSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridViewSearch.DoubleClick
    '    CurrentProductID = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle)("products_id")
    '    LoadProductsInfo()
    '    If XTabControlProduct.SelectedTabPage.Name = tabSearch.Name Then
    '        XTabControlProduct.SelectedTabPage = tabMain
    '    End If
    'End Sub

    Public Sub searchID(ByVal products_id As Integer)
        txtQuickSearch.EditValue = products_id
        CurrentProductID = products_id
        LoadProductsInfo()
        If XTabControlProduct.SelectedTabPage.Name = tabSearch.Name Then
            XTabControlProduct.SelectedTabPage = tabMain
        End If
    End Sub
    Public Sub searchID()
        Dim param As PlushBuziness.clsSingleton
        param = PlushBuziness.clsSingleton.Instance()

        If IsNumeric(txtQuickSearch.EditValue) Then
            CurrentProductID = txtQuickSearch.EditValue
            LoadProductsInfo()
            If XTabControlProduct.SelectedTabPage.Name = tabSearch.Name Then
                XTabControlProduct.SelectedTabPage = tabMain
            End If

            ' RefreshTab(XTabControlProduct.SelectedTabPage)
        End If
    End Sub
    Public Overrides Sub btnQuickSearch_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuickSearch.ItemClick
        searchID()
    End Sub

#End Region


#Region "Event"

    Public Overloads Sub btnPrevious_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrevious.ItemClick
        CurrentProductID -= 1
        If CurrentProductID < 51 Then CurrentProductID = 51
        LoadProductsInfo()
    End Sub
    Public Overloads Sub btnNext_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNext.ItemClick
        CurrentProductID += 1
        LoadProductsInfo()
    End Sub
    Public Overloads Sub btnFirst_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFirst.ItemClick
        CurrentProductID = 51
        LoadProductsInfo()
    End Sub
    Public Overloads Sub btnLast_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLast.ItemClick
        CurrentProductID = BKGlobal.ExecuteFindFieldValueINT("products_id", "select products_id from products order by products_id desc limit 1")
        LoadProductsInfo()
    End Sub

    'Private Sub btnRemoveDVD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveDVD.Click
    '    Dim _ans As MsgBoxResult
    '    _ans = MsgBox("Are you sure you want to remove this DVD from Site and ALL WishList?", MsgBoxStyle.YesNo)
    '    If _ans = MsgBoxResult.Yes Then
    '        XTabControlProduct.Enabled = False
    '        MainData.RemoveDVDFromCatalogue()
    '        XTabControlProduct.Enabled = True
    '        MsgBox("Ce titre a été retiré de notre catalogue et de toutes les wishlist (avec envoi de e-mail aux clients)", MsgBoxStyle.Information)
    '    End If
    '    XTabControlProduct.Enabled = True
    'End Sub
    'Private Sub btnDeleteFromliste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteFromliste.Click
    '    Dim _ans As MsgBoxResult
    '    _ans = MsgBox("Are you sure you want to erase this DVD of liste?", MsgBoxStyle.YesNo)
    '    Dim exist As Boolean = False
    '    exist = BKGlobal.ExecuteExists("select * from products_dvd where products_id = " & txtProductID.Text.ToString)
    '    If _ans = MsgBoxResult.Yes Then
    '        If exist = False Then
    '            DvdPostData.clsConnection.ExecuteNonQuery("delete from products where products_id = " & txtProductID.Text.ToString)
    '            MsgBox("done")
    '            Search()
    '            XTabControlProduct.SelectedTabPage = tabSearch
    '        Else
    '            MsgBox("you can't erase this products , if exist DVDs for this products")
    '        End If
    '    End If
    'End Sub
    'Private Sub btnReCalcQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReCalcQty.Click
    '    '   MainData.RecalcQty()
    'End Sub
    Private Sub cmbStudio_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbStudio.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim _frm As New frmStudioBrowseMaint_Browse(SessionInfo)
            _frm.Tag = 670 'MenuID if started with the MenuTree
            _frm.ShowDialog(Me)
            loadStudio()
        End If
    End Sub
    Private Sub cmbcountry_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbcountry.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim _frm As New frmProdCountriesBrowseMaint_Browse(SessionInfo)
            _frm.Tag = 671 'MenuID if started with the MenuTree
            _frm.ShowDialog(Me)
            loadProductsCountries()
        End If
    End Sub
    Private Sub cmbDirector_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbDirector.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim _frm As New frmDirectorsBrowseMaint(SessionInfo)
            _frm.Tag = 672 'MenuID if started with the MenuTree
            _frm.ShowDialog(Me)
            loadDirectors()
        End If
    End Sub
    Private Sub cmbSerie_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbSerie.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim _frm As New frmSeriesBrowseMaint(SessionInfo)
            _frm.Tag = 673 'MenuID if started with the MenuTree
            _frm.ShowDialog(Me)
            loadSeries()
        End If
    End Sub
    Private Sub cmbABOSerie_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim _frm As New frmSeriesBrowseMaint(SessionInfo)
            _frm.Tag = 673 'MenuID if started with the MenuTree
            _frm.ShowDialog(Me)
        End If
    End Sub
    Private Sub btnActorsMaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActorsMaint.Click
        Dim _frm As New frmActorsBrowseMaint(SessionInfo)
        _frm.Tag = 674 'MenuID if started with the MenuTree
        Try
            _frm.ShowDialog(Me)
            LoadActors()
            cmbActors.ForceInitialize()
        Catch ex As Exception
            PlushBuziness.clsMsgError.MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnLang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLang.Click
        Dim _frm As New frmProdLangBrowseMaint(SessionInfo)
        _frm.Tag = 675 'MenuID if started with the MenuTree
        _frm.ShowDialog(Me)
        LoadProductsLanguage()
    End Sub
    Private Sub btnSubTitles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubTitles.Click
        Dim _frm As New frmProdUnderTitlesBrowseMaint(SessionInfo)
        _frm.Tag = 676 'MenuID if started with the MenuTree
        _frm.ShowDialog(Me)
        loadProductsUndertitle()

    End Sub
    Private Sub btnSoundTracks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _frm As New frmSoundtracksBrowseMaint(SessionInfo)
        _frm.Tag = 678 'MenuID if started with the MenuTree
        _frm.ShowDialog(Me)
        loadProductsSoundtracks()
    End Sub

    'Private Sub TreeListThemes_NodesReloaded(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TreeListThemes.ExpandAll()
    'End Sub
    'Private Sub TreeListthemes_CellValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.CellValueChangedEventArgs)
    '    Dim _view As DataView
    '    Dim _row As DataRowView
    '    If e.Column.FieldName <> "themes_selected" Then Exit Sub
    '    If e.Value = 1 Then 'Putting to TRUE then put Also Parent to True
    '        e.Node("themes_selected") = e.Value
    '        If Not IsNothing(e.Node.ParentNode) Then
    '            e.Node.ParentNode("themes_selected") = e.Value
    '        End If
    '    Else 'Putting to False , then Put also Children To False
    '        e.Node("themes_selected") = e.Value
    '        Try
    '            _view = New DataView(objDS.themes_fr_view1, "parent_id = " & e.Node("themes_id"), "", DataViewRowState.CurrentRows)
    '            For Each _row In _view
    '                _row("themes_selected") = e.Value
    '            Next

    '        Catch ex As Exception
    '            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, ex)
    '        End Try

    '    End If

    'End Sub

    Private Sub txtModel_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtModel.Leave
        If txtModel.Enabled = False Then Exit Sub
        If objDS.products_description_fr.Rows.Count = 0 Then Return
        If txtImageFR.EditValue & "" = "" Then
            objDS.products_description_fr.Rows(0)("products_image_big") = "dvd/" & txtModel.Text.ToLower & "bfr.jpg"
        End If
        If txtImageNL.EditValue & "" = "" Then
            objDS.products_description_nl.Rows(0)("products_image_big") = "dvd/" & txtModel.Text.ToLower & "bfr.jpg"
        End If
        If txtImageEN.EditValue & "" = "" Then
            objDS.products_description_en.Rows(0)("products_image_big") = "dvd/" & txtModel.Text.ToLower & "bfr.jpg"
        End If
    End Sub
    Private Sub btnCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategories.Click
        MsgBox("Pas Encore fini", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub btnThemes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Pas Encore fini", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        If IsNothing(MainData) Or MainData.ProductsID = -1 Then Exit Sub
        Dim _answ As MsgBoxResult
        _answ = MsgBox("Do you really want to make a copy of this Product Info ?", MsgBoxStyle.YesNo)
        If _answ = MsgBoxResult.No Then Exit Sub
        Dim _newID As Integer
        _newID = MainData.CopyProduct()
        MsgBox("New Products ID is : " & _newID.ToString, MsgBoxStyle.Exclamation)
    End Sub

    'Private Sub GridViewProducts_DVD_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
    '    If GridViewProducts_DVD.IsValidRowHandle(GridViewProducts_DVD.FocusedRowHandle) Then
    '        CurrentDVDID = GridViewProducts_DVD.GetDataRow(GridViewProducts_DVD.FocusedRowHandle)("products_dvdid")
    '        LoadOrdersData(CurrentDVDID)
    '        LoadProductsDVDStatusHistory(CurrentDVDID)
    '    End If
    'End Sub
    'Private Sub chkLoadAllOrders_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If chkLoadAllOrders.Checked = True Then
    '        LoadOrdersData(-1)
    '    Else
    '        If GridViewProducts_DVD.IsValidRowHandle(GridViewProducts_DVD.FocusedRowHandle) Then
    '            CurrentDVDID = GridViewProducts_DVD.GetDataRow(GridViewProducts_DVD.FocusedRowHandle)("products_dvdid")
    '            LoadOrdersData(CurrentDVDID)
    '        End If
    '    End If
    'End Sub

    Private Sub TreeListCategories_NodesReloaded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeListCategories.NodesReloaded
        TreeListCategories.ExpandAll()
    End Sub
    Private Sub TreeListCategories_CellValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles TreeListCategories.CellValueChanging
        Dim _view As DataView
        Dim _row As DataRowView
        If e.Column.FieldName <> "category_selected" Then Exit Sub
        If e.Value = 1 Then 'Putting to TRUE then put Also Parent to True
            e.Node("category_selected") = e.Value
            If Not IsNothing(e.Node.ParentNode) Then
                e.Node.ParentNode("category_selected") = e.Value
            End If
        Else 'Putting to False , then Put also Children To False
            e.Node("category_selected") = e.Value
            Try
                _view = New DataView(objDS.categories_fr_view1, "parent_id = " & e.Node("categories_id"), "", DataViewRowState.CurrentRows)
                For Each _row In _view
                    _row("category_selected") = e.Value
                Next

            Catch ex As Exception
                PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Stock, ex)
            End Try

        End If

    End Sub

    'Private Sub GridVIewOrders_History_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
    '    Dim _SQLTxt As String
    '    If GridVIewOrders_History.IsValidRowHandle(GridVIewOrders_History.FocusedRowHandle) Then
    '        CurrentOrderID = GridVIewOrders_History.GetDataRow(GridVIewOrders_History.FocusedRowHandle)("orders_id")
    '    Else
    '        CurrentOrderID = -1
    '    End If
    '    objDS.orders_status_history.Clear()
    '    If CurrentOrderID <> -1 Then
    '        _SQLTxt = "select * " & _
    '                  " from orders_status_history " & _
    '                  " where orders_id = " & CurrentOrderID & _
    '                  " ORDER BY orders_status_history_id desc "
    '        DvdPostData.clsConnection.FillDataSet(objDS.orders_status_history, _SQLTxt)
    '    End If
    'End Sub

    'Private Sub btnAddNewDVDs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'MsgBox("Not Yet!", MsgBoxStyle.Information)
    '    Dim msg As MsgBoxResult
    '    msg = MsgBox("Do you want add " & txtNbrOfDVDToAdd.Value & "  Dvd ? ", MsgBoxStyle.YesNo)

    '    If msg = MsgBoxResult.Yes Then
    '        If CurrentProductID <= 0 Then
    '            MsgBox("Choisir un Product.", MsgBoxStyle.Exclamation)
    '            Exit Sub
    '        End If
    '        If txtNbrOfDVDToAdd.Value <= 0 Then
    '            MsgBox("Choisir une quantité a ajouter.", MsgBoxStyle.Exclamation)
    '            Exit Sub
    '        End If
    '        If IsNothing(MainData) Then
    '            MsgBox("Choisir un Product.", MsgBoxStyle.Exclamation)
    '            Exit Sub
    '        End If

    '        MainData.AddNewDVD(txtNbrOfDVDToAdd.Value)

    '        LoadProductsInfo()

    '    End If
    'End Sub
    'Private Sub btnTransferProductID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CurrentProductID = -1 Then
    '        MsgBox("Please select a Product first", MsgBoxStyle.Exclamation)
    '        Exit Sub
    '    End If
    '    If Not IsNumeric(txtToProdID1.EditValue) Then
    '        MsgBox("Please select a TO Product ID.", MsgBoxStyle.Exclamation)
    '        Exit Sub
    '    End If
    '    Dim sSQL2 As String = "SELECT w.wl_id, w.customers_id, w.product_id, c.customers_language from wishlist w,  customers c where w.customers_id = c.customers_id and c.customers_language  = '" & txtCustLang1.EditValue & "' and w.product_id = '" & txtFromProdID1.EditValue & "' "
    '    Dim _DS As New DataSet
    '    _DS.Tables.Add("TmpTable")
    '    DvdPostData.clsConnection.FillDataSet(_DS.Tables("TmpTable"), sSQL2)
    '    Dim _row As DataRow
    '    Dim i, j As Integer
    '    Dim ssql3 As String = ""
    '    Dim _Exist As Boolean = False
    '    'txtWLToProcess.EditValue = _DS.Tables("TmpTable").Rows.Count
    '    DoEvents()
    '    For Each _row In _DS.Tables("TmpTable").Rows
    '        'txtWLToProcess.EditValue -= 1
    '        DoEvents()
    '        _Exist = BKGlobal.ExecuteExists("select count(*) as cnt from wishlist w " & _
    '               " where product_id = " & txtToProdID1.EditValue & " and w.customers_id = " & _row("customers_id"))
    '        Try
    '            If _Exist Then
    '                ssql3 = "delete from  wishlist where wl_id   = '" & _row("wl_id") & "' and product_id = '" & txtFromProdID1.EditValue & "'  "
    '                DvdPostData.clsConnection.ExecuteNonQuery(ssql3)
    '                j = j + 1
    '            Else
    '                ssql3 = "update wishlist  set product_id = '" & txtToProdID1.EditValue & "' where wl_id   = '" & _row("wl_id") & "' and product_id = '" & txtFromProdID1.EditValue & "'  "
    '                DvdPostData.clsConnection.ExecuteNonQuery(ssql3)
    '                i = i + 1
    '            End If
    '        Catch ex As Exception
    '            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, ex)
    '        End Try
    '    Next
    '    MsgBox(i & " entries Done; " & j & " deleted because bouble ", MsgBoxStyle.Exclamation)
    'End Sub


    'Private Sub ButDelPrDvdId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ''delete dvd in dvdmaintenance on DVDS

    '    If Me.GridViewProducts_DVD.RowCount = 0 Then
    '        MsgBox("Select a products_dvdid.", MsgBoxStyle.Exclamation)
    '        Exit Sub
    '    End If
    '    Dim prdvd_id As String = Me.GridViewProducts_DVD.GetDataRow(GridViewProducts_DVD.FocusedRowHandle)("products_dvdid").ToString
    '    Dim _ans As MsgBoxResult
    '    _ans = MsgBox("products: " + Me.CurrentProductID.ToString + "    products_dvdid: " + prdvd_id, MsgBoxStyle.YesNo)

    '    Dim _SQLTxt As String
    '    objDS.orders_products_view1.Clear()

    '    _SQLTxt = "select op.orders_id, o.customers_id, op.products_id, op.products_dvd as dvd_id, o.delivery_country, o.delivery_name, o.customers_email_address, " & _
    '                           " op.pick_group, op.pick_boxid, o.date_purchased, op.orders_products_status " & _
    '                                   " from orders_products op left join orders o on o.orders_id = op.orders_id " & _
    '                                    " where op.products_dvd = '" & prdvd_id & " 'and op.products_id = " & CurrentProductID & _
    '                                    " ORDER BY op.orders_id desc "
    '    DvdPostData.clsConnection.FillDataSet(objDS.orders_products_view1, _SQLTxt)



    '    If _ans = MsgBoxResult.Yes And objDS.orders_products_view1.Rows.Count = 0 Then
    '        'delete de dvd de la table products_dvd + update de la quantite de dvd  nbrDvd-1
    '        DvdPostData.clsConnection.ExecuteNonQuery("delete from products_dvd where products_id = " & Me.CurrentProductID.ToString & _
    '                                     " and products_dvdid = '" & prdvd_id & "' ")
    '        'DvdPostData.clsConnection.ExecuteNonQuery("update products set products_dvd_quantity = products_dvd_quantity -1 ,products_quantity = products_quantity -1 " & _
    '        '                             "where products_id = '" & CurrentProductID.ToString & "'  ")

    '        'Me.GridViewProducts_DVD.DeleteSelectedRows()
    '        MsgBox("ok")
    '        Exit Sub


    '    ElseIf _ans = MsgBoxResult.No Then
    '        Exit Sub
    '    Else
    '        MsgBox("You cannot remove this DVD of the list")
    '    End If




    'End Sub
    Private Sub Purchase_click(ByVal sender As Object, ByVal e As System.EventArgs)
        _ctrlGridControl.GridPurchase_click()
    End Sub


    Private Sub RefreshTab(ByVal tabCurrent As DevExpress.XtraTab.XtraTabPage)
        'If tabCurrent Is tabPrevision Then
        '    loadPrevision(CurrentProductID)
        'ElseIf tabCurrent Is tabFeeSharing Then
        'loadFeeSharing()
        'ElseIf tabCurrent Is tabWishlistCustomers Then
        'loadWishlistCustomers(CurrentProductID)
        If tabCurrent Is tabFR Then
            LoadFR()
        ElseIf tabCurrent Is tabNL Then
            LoadNL()
        ElseIf tabCurrent Is tabEN Then
            LoadEN()
            'ElseIf tabCurrent Is tabDVDs Then
            '    loadDVD()
        ElseIf tabCurrent Is tabLanguages Then
            loadLanguages()
        ElseIf tabCurrent Is tabCategories Then
            loadTheme()
        ElseIf tabCurrent Is tabTrailers Then
            loadTrailer()
        ElseIf tabCurrent Is tabCritiques Then
            loadCritique(CurrentProductID)
            'ElseIf tabCurrent Is tabGames Then
            'ElseIf tabCurrent Is tabTransfers Then
        ElseIf tabCurrent Is tabVodWishlist Then
            loadVodWishlist(CurrentProductID)
        End If
    End Sub
    Private Sub XTabControlProduct_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XTabControlProduct.SelectedPageChanged

        RefreshTab(XTabControlProduct.SelectedTabPage)
    End Sub

    'Private Sub cmbFeeSharingStudio_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If cmbFeeSharingStudio.EditValue = DvdPostData.clsFeeSharing.feeSharingStudio.UNIVERSAL_GLOBAL_DATA Then
    '        txtFeeSharing_UpfrontFee.EditValue = DvdPostData.clsFeeSharing.UPFRONTFEE_VALUE_UNIVERSAL_GLOBAL_DATA
    '        txtFeeSharing_TurnPrice.EditValue = DvdPostData.clsFeeSharing.TURN_PRICE

    '    ElseIf cmbFeeSharingStudio.EditValue = DvdPostData.clsFeeSharing.feeSharingStudio.MOVIEMAX Then
    '        txtFeeSharing_UpfrontFee.EditValue = DvdPostData.clsFeeSharing.UPFRONTFEE_VALUE_MOVIEMAX
    '        txtFeeSharing_TurnPrice.EditValue = DvdPostData.clsFeeSharing.TURN_PRICE

    '        LoadMovieMaxInfo()
    '    End If


    'End Sub

    'Private Sub GridWishlistCustomers_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If gridViewWishlistCustomers.RowCount <> 0 Then
    '        Dim customers_id As String = gridViewWishlistCustomers.GetDataRow(gridViewWishlistCustomers.FocusedRowHandle)("customers_id")
    '        Dim frm As frmCustomers_Maint
    '        frm = ClsCustomers.openFrmCustMaint(customers_id, Me.ParentForm, SessionInfo)
    '        frm.XTabCustomers.SelectedTabPage = frm.tabWishList
    '    End If
    'End Sub

#End Region

#Region "Images"
    'Private Sub txtPictureImage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    RefreshSmallPicture()
    'End Sub
    Private Sub txtImageFR_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImageFR.EditValueChanged
        RefreshPictureFR()
    End Sub
    Private Sub txtImageNL_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImageNL.EditValueChanged
        RefreshPictureNL()
    End Sub
    Private Sub txtImageEN_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImageEN.EditValueChanged
        RefreshPictureEN()
    End Sub
    Private Sub RefreshPicture(ByVal CtrlnamePicture As DevExpress.XtraEditors.TextEdit, ByVal ctrlImg As DevExpress.XtraEditors.PictureEdit)

        If CtrlnamePicture Is Nothing Then Return
        ctrlImg.Image = Nothing
        Dim pathserver As String
        If CtrlnamePicture.EditValue & "" <> "" Then
            If MainData.productsType & "" = "DVD_NORM" Then
                pathserver = PlushBuziness.clsPicture.getPathServer(PlushData.clsProductDvd.Type_DVD.DVD_NORM)
            Else
                pathserver = PlushBuziness.clsPicture.getPathServer(PlushData.clsProductDvd.Type_DVD.DVD_ADULT)
            End If
            pathserver = pathserver & CtrlnamePicture.EditValue

            If System.IO.File.Exists(pathserver) Then
                ctrlImg.Image = System.Drawing.Image.FromFile(pathserver)
            End If

        End If
    End Sub
    Private Sub LoadPictureTrailer(ByVal CtrlnamePicture As String, ByVal ctrlImg As DevExpress.XtraEditors.PictureEdit)

        If CtrlnamePicture Is Nothing Then Return
        ctrlImg.Image = Nothing
        Dim pathserver As String
        If CtrlnamePicture & "" <> "" Then
            If MainData.productsType & "" = "DVD_NORM" Then
                pathserver = PlushBuziness.clsPicture.getPathServer(PlushData.clsProductDvd.Type_DVD.DVD_NORM)
            Else
                pathserver = PlushBuziness.clsPicture.getPathServer(PlushData.clsProductDvd.Type_DVD.DVD_ADULT)
            End If
            pathserver = pathserver & CtrlnamePicture

            If System.IO.File.Exists(pathserver) Then
                ctrlImg.Image = System.Drawing.Image.FromFile(pathserver)
            End If

        End If
    End Sub
    'Private Sub RefreshSmallPicture()
    '    RefreshPicture(txtPictureImage, PictProducts_Image)
    'End Sub
    Private Sub RefreshPictureFR()
        RefreshPicture(txtImageFR, pictFR)
    End Sub
    Private Sub RefreshPictureNL()
        RefreshPicture(txtImageNL, pictNL)

    End Sub
    Private Sub RefreshPictureEN()
        RefreshPicture(txtImageEN, pictEN)
    End Sub
    Private Sub RefreshPictureTrailer()
        LoadPictureTrailer("screenshots\small\" & txtIMDB_ID.Text & "_1.jpg", imgIMDBID_1)
        LoadPictureTrailer("screenshots\small\" & txtIMDB_ID.Text & "_2.jpg", imgIMDBID_2)
        LoadPictureTrailer("screenshots\small\" & txtIMDB_ID.Text & "_3.jpg", imgIMDBID_3)
        LoadPictureTrailer("screenshots\small\" & txtIMDB_ID.Text & "_4.jpg", imgIMDBID_4)
        LoadPictureTrailer("screenshots\small\" & txtIMDB_ID.Text & "_5.jpg", imgIMDBID_5)
        LoadPictureTrailer("screenshots\small\" & txtIMDB_ID.Text & "_6.jpg", imgIMDBID_6)
    End Sub
#End Region


    Private Sub RefreshCategoryTree()
        ' If boolLoadingDVDInfo Then Exit Sub
        Dim _ID As Integer
        Dim _product_type As String 'Movie; Game
        Dim _products_type As String 'DVD_NORM, DVD_Adult
        Dim _DS As New dsProducts
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            _ID = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField)
            _products_type = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)("products_type")
            _product_type = cmbProducts_product_type.EditValue & ""
            '_products_type = cmbProducts_Type.EditValue & ""
            If _product_type & "" = "" Then _product_type = "Movie"
            If _products_type & "" = "" Then _products_type = "DVD_NORM"
            If IsDBNull(_ID) Then Exit Sub
            objDS.categories_fr_view1.Clear()
            Dim _category_sql As String = "select c.categories_id, parent_id, categories_type, cdesc.categories_name from categories c" & _
                 " left join categories_description cdesc on cdesc.categories_id = c.categories_id and cdesc.language_id = 1 " & _
                 " WHERE categories_type = '" & _products_type & "' and product_type = '" & _product_type & "'"
            PlushData.clsConnection.FillDataSet(objDS.categories_fr_view1, _category_sql)
            PlushData.clsConnection.FillDataSet(_DS.products_to_categories, "SELECT * from products_to_categories where products_id = " & MainData.ProductsID)
            Dim _row As DataRow
            For Each _row In objDS.categories_fr_view1.Rows
                If IsNothing(_DS.products_to_categories.Rows.Find(New Object() {MainData.ProductsID, _row("categories_id")})) Then
                    _row("category_selected") = 0
                Else
                    _row("category_selected") = 1
                End If

            Next
        End If
    End Sub


    'Private Sub RefreshThemeTree()
    '    Dim _ID As Integer
    '    Dim _DS As New dsProducts
    '    If Me.BindingContext(objDS, TableName).Position >= 0 Then
    '        _ID = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField)
    '        If IsDBNull(_ID) Then Exit Sub
    '        objDS.themes_fr_view1.Clear()
    '        Dim _theme_sql As String = "select t.themes_id, parent_id, themes_type, tdesc.themes_name from themes t " & _
    '             " left join themes_description tdesc on tdesc.themes_id = t.themes_id and tdesc.language_id = 1 " & _
    '             " WHERE themes_type = '" & MainData.productsType & "' "
    '        Cls1.FillDataSet(objDS.themes_fr_view1, _theme_sql)
    '        Cls1.FillDataSet(_DS.products_to_themes, "SELECT * from products_to_themes where products_id = " & MainData.ProductsID)
    '        Dim _row As DataRow
    '        For Each _row In objDS.themes_fr_view1.Rows
    '            If IsNothing(_DS.products_to_themes.Rows.Find(New Object() {MainData.ProductsID, _row("themes_id")})) Then
    '                _row("themes_selected") = 0
    '            Else
    '                _row("themes_selected") = 1
    '            End If

    '        Next
    '    End If
    'End Sub


    'Private Sub initCheckProcess()
    '    _CheckProcess = New ClsCheckProcessLogistic()
    '    _CheckProcess.txtInfo = txtINFO
    '    _CheckProcess.sessionInfo = SessionInfo
    '    _CheckProcess.objDS = objDS
    '    _CheckProcess.txtbarcode = txtBarCode
    '    _CheckProcess.btnUnlock = btnUnlock
    '    objDS.EnforceConstraints = False
    'End Sub


    'Private Sub btnOK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK1.Click

    '    If txtBarCode.Text = "" Then
    '        btnSearch_Click(Nothing, Nothing)
    '        Return
    '    End If

    '    Dim objProductDVD As clsProduct_DVD

    '    objProductDVD = _CheckProcess.GetCodeBar(txtBarCode.Text)
    '    If objProductDVD Is Nothing Then Return

    '    txtQuickSearch.EditValue = objProductDVD.ProductsID
    '    searchID()
    '    XTabControlProduct.SelectedTabPage = tabDVDs
    '    GridViewProducts_DVD.SelectRow(objProductDVD.DvdId - 1)
    '    GridViewProducts_DVD.FocusedRowHandle = objProductDVD.DvdId - 1

    'End Sub


    'Private Sub btnFindBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindBarCode.Click
    '    _CheckProcess.GenereBarCode()
    'End Sub

    Private Sub RepositoryIProductProducts_id_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryIProductProducts_id.Click

        CurrentProductID = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle)("products_id")
        LoadProductsInfo()
        If XTabControlProduct.SelectedTabPage.Name = tabSearch.Name Then
            XTabControlProduct.SelectedTabPage = tabMain
        End If
    End Sub

    Private Sub GridViewCritiques_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewCritiques.DoubleClick
        Dim _frm As New frmReviewsMaint(SessionInfo)
        Dim _Review_ID As Integer
        Dim _i As Integer = GridViewCritiques.FocusedRowHandle
        _Review_ID = GridViewCritiques.GetDataRow(_i)("reviews_id")
        _frm.txtReviewID.EditValue = _Review_ID
        _frm.SearchReviewInfo()
        _frm.ShowDialog(Me)
    End Sub

    'Private Sub RepositoryIbtnChangeStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim orders_id As Integer
    '    Dim order_status As Integer
    '    Dim products_status As Integer
    '    Dim sql As String

    '    order_status = GridVIewOrders_History.GetDataRow(GridVIewOrders_History.FocusedRowHandle)("orders_status")
    '    orders_id = GridVIewOrders_History.GetDataRow(GridVIewOrders_History.FocusedRowHandle)("orders_id")

    '    If order_status = DvdPostData.clsOdersStatusHistory.OrderStatusNew.CHECK Then
    '        products_status = GridViewProducts_DVD.GetDataRow(GridViewProducts_DVD.FocusedRowHandle)("products_dvd_status")
    '        If products_status = DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK Then
    '            DVDPostBuziness.clsOrders.UpdateOrder(orders_id, DvdPostData.clsOdersStatusHistory.OrderStatusNew.COMPLAINT_INADMISSIBLE, order_status)
    '            MsgBox("DVD Lisible no accepted")
    '        Else
    '            DVDPostBuziness.clsOrders.UpdateOrder(orders_id, DvdPostData.clsOdersStatusHistory.OrderStatusNew.RETURNED, order_status)
    '            MsgBox("DVD Illisible", MsgBoxStyle.Critical)
    '        End If

    '        LoadOrdersData(CurrentDVDID)
    '    End If
    'End Sub

    Private Sub ButtonWatchTrailer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim WebTrailer As System.Windows.Forms.WebBrowser = New System.Windows.Forms.WebBrowser()
        Dim frmShowTrailer As System.Windows.Forms.Form = New System.Windows.Forms.Form()
        Dim strDocumentText As String = String.Empty
        Dim strTrailerRemoteID As String
        Dim strBroadcast As String = String.Empty

        'If GridViewTrailers.FocusedRowHandle > -1 Then
        '    strTrailerRemoteID = GridViewTrailers.GetDataRow(GridViewTrailers.FocusedRowHandle)("trailer")
        '    strBroadcast = GridViewTrailers.GetDataRow(GridViewTrailers.FocusedRowHandle)("broadcast")
        'End If
        If strBroadcast = "DAYLYMOTION" Then
            strDocumentText = String.Format("<object width=""480"" height=""285""><param name=""movie"" value=""http://www.dailymotion.com/swf/video/{0}_space-symphony-maetel-bande-annonce_creation""></param><param name=""allowFullScreen"" value=""true""></param><param name=""allowScriptAccess"" value=""always""></param><embed type=""application/x-shockwave-flash"" src=""http://www.dailymotion.com/swf/video/{0}_space-symphony-maetel-bande-annonce_creation"" width=""480"" height=""285"" allowfullscreen=""true"" allowscriptaccess=""always""></embed></object>", strTrailerRemoteID)
            frmShowTrailer.Width = 550
            frmShowTrailer.Height = 330
        ElseIf strBroadcast = "YOUTUBE" Then
            strDocumentText = String.Format("<object width=""640"" height=""385""><param name=""movie"" value=""http://www.youtube.com/v/{0}&hl=en_US&fs=1?rel=0""></param><param name=""allowFullScreen"" value=""true""></param><param name=""allowscriptaccess"" value=""always""></param><embed src=""http://www.youtube.com/v/{0}&hl=en_US&;fs=1?rel=0"" type=""application/x-shockwave-flash"" allowscriptaccess=""always"" allowfullscreen=""true"" width=""640"" height=""385""></embed></object>", strTrailerRemoteID)
            frmShowTrailer.Width = 700
            frmShowTrailer.Height = 440
        ElseIf strBroadcast = "CINEMOVIES" Then
            strDocumentText = String.Format("<html><body><embed height=""458"" width=""610"" allowscriptaccess=""always"" allowfullscreen=""true"" flashvars=""{0}"" src=""http://www.cinemovies.fr/player/export/CineMovies2.swf""></embed></html></body>", strTrailerRemoteID)
            '          strDocumentText = String.Format("<object id=""ply"" width=""610"" height=""458"" type=""application/x-shockwave-flash"" data=""http://www.cinemovies.fr/player/export/CineMovies2.swf""> " & _
            '"" <param name=""wmode"" value=""transparent""> " & _
            '"" <param name=""allowfullscreen"" value=""true""> " & _
            '"" <param name=""allowscriptaccess"" value=""always""> " & _
            '"" <param name=""flashvars"" value=""{0}""></object>", strTrailerRemoteID)
            frmShowTrailer.Width = 700
            frmShowTrailer.Height = 530
        ElseIf strBroadcast = "ALLOCINE" Then
            strDocumentText = String.Format("<object type=""application/x-shockwave-flash"" id=""V6_player"" data=""http://images.allocine.fr/commons/player/AcV3/AcPlayer_v3.0.swf"" width=""760px"" height=""464px"" style=""visibility: visible; display: block; "" > " & _
                              " <param name=""menu"" value=""false""/> " & _
                              " <param name=""wmode"" value=""window""/> " & _
                              " <param name=""scale"" value=""noScale""/>" & _
                              " <param name=""allowFullscreen"" value=""true""/> " & _
                              " <param name=""allowScriptAccess"" value=""always""/> " & _
                              " <param name=""bgcolor"" value=""#000000""/> " & _
                              " <param name=""flashvars"" value=""{0}""/></object>", strTrailerRemoteID)
            frmShowTrailer.Width = 770
            frmShowTrailer.Height = 470
        ElseIf strBroadcast = "AAMREVIEWS" Then
            strDocumentText = String.Format("<object type=""application/x-shockwave-flash"" width=""450"" height=""300""wmode=""transparent"" data=""http://www.aamreviews.com/flvplayer.swf?file=http://www.aamreviews.com/flvideo/{0}&autostart=true&showfsbutton=true""> " & _
                                           "   <param name=""movie"" value=""http://www.aamreviews.com/flvplayer.swf?file=http://www.aamreviews.com/flvideo/3372.flv&autostart=true&showfsbutton=true"" /> " & _
                                           "  <param name=""wmode"" value=""transparent"" /> " & _
                                           " <param name=""allowScriptAccess"" value=""sameDomain"" /> " & _
                                           " <embed src=""http://www.aamreviews.com/flvplayer.swf?file=http://www.aamreviews.com/flvideo/<%= trailer.remote_id %>&autostart=true&showfsbutton=true"" loop=""False"" width=""330"" height=""220"" allowscriptaccess=""sameDomain"" type=""application/x-shockwave-flash"" pluginspage=""http://www.macromedia.com/go/getflashplayer"" /></embed></object>", strTrailerRemoteID)
            frmShowTrailer.Width = 500
            frmShowTrailer.Height = 350
        ElseIf strBroadcast = "DORCELVISION" Then
            strDocumentText = String.Format("<object codebase=""http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=,0,0,0"" id=""AnimationFlash"" width=""330"" height=""220"" classid=""clsid:d27cdb6e-ae6d-11cf-96b8-444553540000""> " & _
                                             " <param name=""allowScriptAccess"" value=""always""/>  " & _
                                             " <param name=""movie"" value=""{0}""/>  " & _
                                             "  <param name=""swLiveConnect"" value=""TRUE""/> " & _
                                             " <param name=""quality"" value=""high""/> " & _
                                             "<param name=""bgcolor"" value=""""/> " & _
                                             " <param name=""wmode"" value=""opaque""/> " & _
                                             " <embed id=""AnimationFlash"" allowscriptaccess=""always"" width=""330"" height=""220"" src=""{0}"" swliveconnect=""TRUE"" quality=""high"" pluginspage=""http://www.macromedia.com/shockwave/download/index.cgi?P1_Prod_Version=ShockwaveFlash"" bgcolor="""" wmode=""opaque"" type=""application/x-shockwave-flash""/></object>", strTrailerRemoteID)
            frmShowTrailer.Width = 300
            frmShowTrailer.Height = 400
        ElseIf strBroadcast = "FILM1" Or strBroadcast = "COMMEAUCINEMA" Or strBroadcast = "CINENEWS.BE" Or strBroadcast = "TRUVEO" Then
            strDocumentText = "<object width=""640"" height=""385"" type=""application/x-shockwave-flash"" data=""http://releases.flowplayer.org/swf/flowplayer-3.2.7.swf"" name=""player_api"" id=""player_api""><param value=""true"" name=""allowfullscreen""><param value=""always"" name=""allowscriptaccess""><param value=""high"" name=""quality""><param value=""#000000"" name=""bgcolor""><param value=""config={""plugins"":{""content"":{""url"":""flowplayer.content-3.2.0.swf"",""height"":220,""padding"":30,""backgroundColor"":""#112233"",""opacity"":0.0,""backgroundGradient"":[0.1,0.1,1],""html"":"""",""style"":{""p"":{""fontSize"":40}}},""controls"":{""url"":""flowplayer.controls-tube-3.2.5.swf""}},""playerId"":""player"",""clip"":{""url"":"
            strDocumentText = strDocumentText & strTrailerRemoteID & ",""playlist"":[{""url"":" & strTrailerRemoteID & "}]} name=""flashvars""> </object>"

            frmShowTrailer.Width = 700
            frmShowTrailer.Height = 550
        End If

        WebTrailer.DocumentText = strDocumentText
        WebTrailer.Dock = DockStyle.Fill

        frmShowTrailer.Controls.Add(WebTrailer)
        Try
            frmShowTrailer.ShowDialog(Me)
        Catch ex As Exception

        End Try

        WebTrailer.Stop()
        WebTrailer.Dispose()
        WebTrailer = Nothing
        frmShowTrailer.Dispose()
        frmShowTrailer = Nothing
    End Sub

    Private Sub txtImageFR_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImageFR.Leave
        ValidateImagePath(sender)
    End Sub

    Private Sub ValidateImagePath(ByVal sender As System.Object)
        If CType(sender, DevExpress.XtraEditors.TextEdit).Text.Contains(" ") Then
            MessageBox.Show("Image name can not contain spaces !")
            CType(sender, DevExpress.XtraEditors.TextEdit).Focus()
        End If

    End Sub

    Private Sub txtImageNL_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImageNL.Leave
        ValidateImagePath(sender)
    End Sub

    Private Sub txtImageEN_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImageEN.Leave
        ValidateImagePath(sender)
    End Sub
End Class
