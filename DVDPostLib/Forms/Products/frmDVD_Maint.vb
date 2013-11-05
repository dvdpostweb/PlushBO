Imports BizzLib.clsGlobal.ObjectState
Imports System.Windows.Forms.Application
Imports System.Threading
Imports System.Windows.Forms
Imports System.Collections.Generic

Public Class frmDVD_Maint

    Inherits BizzLib.frmGeneral_Maintenance

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
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabMain As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabFR As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabNL As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabEN As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabLanguages As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabTheme As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblProductID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtModel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblModel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtyNow As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblQtyNow As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSearch As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents objDS As DVDPostLib.dsProducts
    Friend WithEvents colproducts_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents collanguage_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_model As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbLanguages As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tabDVDs As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnRemoveDVD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReCalcQty As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbProducts_Media As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbProducts_Status As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbProducts_Type As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbAvailability As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbRating As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbPublic As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtPictureImage As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictProducts_Image As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents grpLanguage As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents grpSubTitles As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tabTrailers As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabFeeSharing As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtABOSerieNbr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbABOSerie As DevExpress.XtraEditors.LookUpEdit
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
    Friend WithEvents GridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents SplitterControl3 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents grpSoundTracks As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridTrailers As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewTrailers As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridSoundtracks As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSoundTracks As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents btnSoundTracks As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbLangTrailer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents coltrailers_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_id4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents collanguage_id1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coltrailer As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbSoundTracks As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colproducts_id5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_soundtracks_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
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
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFeeSharing_End As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFeeSharing_TurnPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFeeSharing_UpfrontFee As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents chkGommetteFR As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkGommetteNL As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colcategory_selected As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents txtOtherProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Public WithEvents TreeListCategories As DevExpress.XtraTreeList.TreeList
    Public WithEvents TreeListThemes As DevExpress.XtraTreeList.TreeList
    Friend WithEvents chkThemeSelected As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colthemes_id As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colparent_id1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colthemes_type As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colthemes_name As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colthemes_selected As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitterControl2 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl12 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCategories As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThemes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCopy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkProduct_Next As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkInCinemaNow As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkInTheBags As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkInTheBagsNext As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl13 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitterControl4 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelControl14 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl15 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitterControl6 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl16 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitterControl5 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSale_price As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtQty_to_sale As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaleDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNew_Sale_Price As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNew_qty_to_sale As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkOnly_for_sale As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridProducts_DVD As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewProducts_DVD As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colproducts_id6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_dvdid As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_dvd_status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colbox_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colpibox_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcover_boxid As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colstock_type As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbProducts_DVD_Status As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridOrders_History As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colorders_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_id7 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldvd_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldelivery_country As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colpick_group As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colpick_boxid As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldate_purchased As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldelivery_name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_email_address As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colorders_products_status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbOrders_Products_Status As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents chkLoadAllOrders As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTitleSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddNewDVDs As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNbrOfDVDToAdd As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GridOrdersStatusHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewOrdersStatusHistory As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand9 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colorders_status_history_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colorders_id1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colnew_value As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colold_value As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldate_added As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_notified As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridVIewOrders_History As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents cmbOrdersStatus1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colinout As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldvd_buy_date As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colEntityID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridDVDStatusHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand10 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents cmbProductsDVDStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colstatus_history_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colstatus_date As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colprevious_status_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colstatus_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coluser_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcomment As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colbroadcast As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbTrailers_Broadcast As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnTransferProductID As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtWLToProcess As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtToProdID1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustLang1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFromProdID1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabTransfers As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtIMDB_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabGames As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmbProducts_product_type As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGame_NbrOfPlayersOnline As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGame_NbrOfPlayers As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGame_ConfigMini As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents chkGameOnline As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ButDelPrDvdId As System.Windows.Forms.Button
    Friend WithEvents btnDeleteFromliste As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabPrevision As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridPrevision As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewPrevision As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBandPrevision As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents cmbFeeSharingStudio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbMovieMaxPartner As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTiteNrMovieMax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabWishlistCustomers As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridWishlistCustomers As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewWishlistCustomers As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand11 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colorders_status_name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.objDS = New DVDPostLib.dsProducts
        Me.GridViewSearch = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colproducts_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.collanguage_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbLanguages = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colproducts_name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_model = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.txtTitleSearch = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.tabMain = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.btnDeleteFromliste = New DevExpress.XtraEditors.SimpleButton
        Me.btnCopy = New DevExpress.XtraEditors.SimpleButton
        Me.btnReCalcQty = New DevExpress.XtraEditors.SimpleButton
        Me.btnRemoveDVD = New DevExpress.XtraEditors.SimpleButton
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
        Me.txtPictureImage = New DevExpress.XtraEditors.TextEdit
        Me.grpSeries = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.txtABOSerieNbr = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.cmbABOSerie = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txtSerieNbr = New DevExpress.XtraEditors.TextEdit
        Me.lblSerieNbr = New DevExpress.XtraEditors.LabelControl
        Me.cmbSerie = New DevExpress.XtraEditors.LookUpEdit
        Me.lblSeries = New DevExpress.XtraEditors.LabelControl
        Me.grpMain = New DevExpress.XtraEditors.GroupControl
        Me.cmbProducts_product_type = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl
        Me.txtIMDB_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit
        Me.chkInTheBagsNext = New DevExpress.XtraEditors.CheckEdit
        Me.chkInTheBags = New DevExpress.XtraEditors.CheckEdit
        Me.chkInCinemaNow = New DevExpress.XtraEditors.CheckEdit
        Me.chkProduct_Next = New DevExpress.XtraEditors.CheckEdit
        Me.txtOtherProductID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl
        Me.chkGommetteNL = New DevExpress.XtraEditors.CheckEdit
        Me.chkGommetteFR = New DevExpress.XtraEditors.CheckEdit
        Me.cmbRating = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.cmbAvailability = New DevExpress.XtraEditors.LookUpEdit
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
        Me.txtQtyNow = New DevExpress.XtraEditors.TextEdit
        Me.lblQtyNow = New DevExpress.XtraEditors.LabelControl
        Me.txtQty = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
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
        Me.tabTheme = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl
        Me.TreeListThemes = New DevExpress.XtraTreeList.TreeList
        Me.colthemes_id = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colparent_id1 = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colthemes_type = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colthemes_name = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colthemes_selected = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.chkThemeSelected = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PanelControl12 = New DevExpress.XtraEditors.PanelControl
        Me.btnThemes = New DevExpress.XtraEditors.SimpleButton
        Me.SplitterControl2 = New DevExpress.XtraEditors.SplitterControl
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl
        Me.TreeListCategories = New DevExpress.XtraTreeList.TreeList
        Me.colcategories_id = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colparent_id = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colcategories_type = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colcategories_name = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colcategory_selected = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.chkSelectCategory = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
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
        Me.grpSoundTracks = New DevExpress.XtraEditors.GroupControl
        Me.GridSoundtracks = New DevExpress.XtraGrid.GridControl
        Me.GridViewSoundTracks = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colproducts_id5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_soundtracks_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbSoundTracks = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl
        Me.btnSoundTracks = New DevExpress.XtraEditors.SimpleButton
        Me.SplitterControl3 = New DevExpress.XtraEditors.SplitterControl
        Me.grpTrailers = New DevExpress.XtraEditors.GroupControl
        Me.GridTrailers = New DevExpress.XtraGrid.GridControl
        Me.GridViewTrailers = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.coltrailers_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_id4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.collanguage_id1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbLangTrailer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.coltrailer = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colbroadcast = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbTrailers_Broadcast = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl
        Me.tabFeeSharing = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl
        Me.chkOnly_for_sale = New DevExpress.XtraEditors.CheckEdit
        Me.txtNew_Sale_Price = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl
        Me.txtNew_qty_to_sale = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl
        Me.txtSale_price = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl
        Me.txtQty_to_sale = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl
        Me.txtPrice = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl
        Me.txtSaleDate = New DevExpress.XtraEditors.DateEdit
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl
        Me.txtTiteNrMovieMax = New DevExpress.XtraEditors.TextEdit
        Me.cmbFeeSharingStudio = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbMovieMaxPartner = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl
        Me.txtFeeSharing_TurnPrice = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl
        Me.txtFeeSharing_UpfrontFee = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
        Me.txtFeeSharing_End = New DevExpress.XtraEditors.DateEdit
        Me.tabDVDs = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl14 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl15 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl16 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.GridOrdersStatusHistory = New DevExpress.XtraGrid.GridControl
        Me.GridViewOrdersStatusHistory = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand9 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colorders_status_history_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colorders_id1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colnew_value = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbOrdersStatus1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colold_value = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldate_added = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_notified = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.SplitterControl5 = New DevExpress.XtraEditors.SplitterControl
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        Me.GridOrders_History = New DevExpress.XtraGrid.GridControl
        Me.GridVIewOrders_History = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colorders_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldvd_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldelivery_name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_id7 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldelivery_country = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colpick_group = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colpick_boxid = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldate_purchased = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colorders_status_name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_email_address = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colorders_products_status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbOrders_Products_Status = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.chkLoadAllOrders = New DevExpress.XtraEditors.CheckEdit
        Me.SplitterControl6 = New DevExpress.XtraEditors.SplitterControl
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.GridDVDStatusHistory = New DevExpress.XtraGrid.GridControl
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand10 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colstatus_history_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colstatus_date = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colprevious_status_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbProductsDVDStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colstatus_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coluser_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcomment = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.SplitterControl4 = New DevExpress.XtraEditors.SplitterControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridProducts_DVD = New DevExpress.XtraGrid.GridControl
        Me.GridViewProducts_DVD = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colproducts_id6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_dvdid = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_dvd_status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbProducts_DVD_Status = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colbox_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colpibox_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colinout = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcover_boxid = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colstock_type = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colEntityID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldvd_buy_date = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.PanelControl13 = New DevExpress.XtraEditors.PanelControl
        Me.ButDelPrDvdId = New System.Windows.Forms.Button
        Me.txtNbrOfDVDToAdd = New DevExpress.XtraEditors.SpinEdit
        Me.btnAddNewDVDs = New DevExpress.XtraEditors.SimpleButton
        Me.tabGames = New DevExpress.XtraTab.XtraTabPage
        Me.chkGameOnline = New DevExpress.XtraEditors.CheckEdit
        Me.txtGame_ConfigMini = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl
        Me.txtGame_NbrOfPlayersOnline = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl
        Me.txtGame_NbrOfPlayers = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl
        Me.tabTransfers = New DevExpress.XtraTab.XtraTabPage
        Me.LabelControl50 = New DevExpress.XtraEditors.LabelControl
        Me.btnTransferProductID = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl
        Me.txtWLToProcess = New DevExpress.XtraEditors.TextEdit
        Me.txtToProdID1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl
        Me.txtFromProdID1 = New DevExpress.XtraEditors.TextEdit
        Me.txtCustLang1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl
        Me.tabPrevision = New DevExpress.XtraTab.XtraTabPage
        Me.GridPrevision = New DevExpress.XtraGrid.GridControl
        Me.GridViewPrevision = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBandPrevision = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.tabWishlistCustomers = New DevExpress.XtraTab.XtraTabPage
        Me.GridWishlistCustomers = New DevExpress.XtraGrid.GridControl
        Me.gridViewWishlistCustomers = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand11 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.BandedGridColumn6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabSearch.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
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
        CType(Me.txtPictureImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSeries.SuspendLayout()
        CType(Me.txtABOSerieNbr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbABOSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieNbr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        CType(Me.cmbProducts_product_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIMDB_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInTheBagsNext.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInTheBags.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInCinemaNow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkProduct_Next.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtherProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGommetteNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGommetteFR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAvailability.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.txtQtyNow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabTheme.SuspendLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.TreeListThemes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkThemeSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl12.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.TreeListCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelectCategory, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.grpSoundTracks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSoundTracks.SuspendLayout()
        CType(Me.GridSoundtracks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSoundTracks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSoundTracks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.grpTrailers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTrailers.SuspendLayout()
        CType(Me.GridTrailers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTrailers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLangTrailer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTrailers_Broadcast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFeeSharing.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.chkOnly_for_sale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNew_Sale_Price.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNew_qty_to_sale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSale_price.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty_to_sale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaleDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaleDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.txtTiteNrMovieMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFeeSharingStudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMovieMaxPartner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFeeSharing_TurnPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFeeSharing_UpfrontFee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFeeSharing_End.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFeeSharing_End.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDVDs.SuspendLayout()
        CType(Me.PanelControl14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl14.SuspendLayout()
        CType(Me.PanelControl15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl15.SuspendLayout()
        CType(Me.PanelControl16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl16.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridOrdersStatusHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewOrdersStatusHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOrdersStatus1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GridOrders_History, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridVIewOrders_History, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOrders_Products_Status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLoadAllOrders.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GridDVDStatusHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductsDVDStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridProducts_DVD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewProducts_DVD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProducts_DVD_Status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl13.SuspendLayout()
        CType(Me.txtNbrOfDVDToAdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGames.SuspendLayout()
        CType(Me.chkGameOnline.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGame_ConfigMini.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGame_NbrOfPlayersOnline.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGame_NbrOfPlayers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTransfers.SuspendLayout()
        CType(Me.txtWLToProcess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToProdID1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromProdID1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustLang1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPrevision.SuspendLayout()
        CType(Me.GridPrevision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPrevision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWishlistCustomers.SuspendLayout()
        CType(Me.GridWishlistCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewWishlistCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl10.SuspendLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 96)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabSearch
        Me.XtraTabControl1.Size = New System.Drawing.Size(1056, 660)
        Me.XtraTabControl1.TabIndex = 35
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabSearch, Me.tabMain, Me.tabFR, Me.tabNL, Me.tabEN, Me.tabTheme, Me.tabLanguages, Me.tabTrailers, Me.tabFeeSharing, Me.tabDVDs, Me.tabGames, Me.tabTransfers, Me.tabPrevision, Me.tabWishlistCustomers})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'tabSearch
        '
        Me.tabSearch.Controls.Add(Me.GridControl2)
        Me.tabSearch.Controls.Add(Me.PanelControl2)
        Me.tabSearch.Name = "tabSearch"
        Me.tabSearch.Size = New System.Drawing.Size(1047, 629)
        Me.tabSearch.Text = "Search"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.objDS.products_description1
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.FormsUseDefaultLookAndFeel = False
        Me.GridControl2.Location = New System.Drawing.Point(0, 40)
        Me.GridControl2.MainView = Me.GridViewSearch
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbLanguages})
        Me.GridControl2.Size = New System.Drawing.Size(1047, 589)
        Me.GridControl2.TabIndex = 3
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSearch})
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
        Me.GridViewSearch.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colproducts_id, Me.collanguage_id, Me.colproducts_name, Me.colproducts_model})
        Me.GridViewSearch.GridControl = Me.GridControl2
        Me.GridViewSearch.Name = "GridViewSearch"
        Me.GridViewSearch.OptionsBehavior.Editable = False
        Me.GridViewSearch.OptionsView.ShowAutoFilterRow = True
        Me.GridViewSearch.OptionsView.ShowBands = False
        Me.GridViewSearch.OptionsView.ShowFooter = True
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colproducts_id)
        Me.GridBand1.Columns.Add(Me.collanguage_id)
        Me.GridBand1.Columns.Add(Me.colproducts_name)
        Me.GridBand1.Columns.Add(Me.colproducts_model)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 806
        '
        'colproducts_id
        '
        Me.colproducts_id.Caption = "products_id"
        Me.colproducts_id.FieldName = "products_id"
        Me.colproducts_id.Name = "colproducts_id"
        Me.colproducts_id.Visible = True
        '
        'collanguage_id
        '
        Me.collanguage_id.Caption = "language_id"
        Me.collanguage_id.ColumnEdit = Me.cmbLanguages
        Me.collanguage_id.FieldName = "language_id"
        Me.collanguage_id.Name = "collanguage_id"
        Me.collanguage_id.Visible = True
        Me.collanguage_id.Width = 147
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
        Me.colproducts_name.Visible = True
        Me.colproducts_name.Width = 219
        '
        'colproducts_model
        '
        Me.colproducts_model.Caption = "products_model"
        Me.colproducts_model.FieldName = "products_model"
        Me.colproducts_model.Name = "colproducts_model"
        Me.colproducts_model.Visible = True
        Me.colproducts_model.Width = 365
        '
        'PanelControl2
        '
        Me.PanelControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl2.Controls.Add(Me.btnSearch)
        Me.PanelControl2.Controls.Add(Me.txtTitleSearch)
        Me.PanelControl2.Controls.Add(Me.LabelControl7)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1047, 40)
        Me.PanelControl2.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(632, 8)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Search"
        '
        'txtTitleSearch
        '
        Me.txtTitleSearch.Location = New System.Drawing.Point(144, 8)
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
        Me.PanelControl3.Controls.Add(Me.btnReCalcQty)
        Me.PanelControl3.Controls.Add(Me.btnRemoveDVD)
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
        'btnReCalcQty
        '
        Me.btnReCalcQty.Location = New System.Drawing.Point(224, 8)
        Me.btnReCalcQty.Name = "btnReCalcQty"
        Me.btnReCalcQty.Size = New System.Drawing.Size(75, 23)
        Me.btnReCalcQty.TabIndex = 1
        Me.btnReCalcQty.Text = "Re-Calc Qty"
        '
        'btnRemoveDVD
        '
        Me.btnRemoveDVD.Location = New System.Drawing.Point(8, 8)
        Me.btnRemoveDVD.Name = "btnRemoveDVD"
        Me.btnRemoveDVD.Size = New System.Drawing.Size(208, 23)
        Me.btnRemoveDVD.TabIndex = 0
        Me.btnRemoveDVD.Text = "Remove DVD from wishlist and products"
        '
        'grpActors
        '
        Me.grpActors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpActors.Controls.Add(Me.GridActors)
        Me.grpActors.Controls.Add(Me.PanelControl1)
        Me.grpActors.Location = New System.Drawing.Point(728, 40)
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
        Me.grpImage.Controls.Add(Me.txtPictureImage)
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
        'txtPictureImage
        '
        Me.txtPictureImage.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_image", True))
        Me.txtPictureImage.Enabled = False
        Me.txtPictureImage.Location = New System.Drawing.Point(8, 24)
        Me.txtPictureImage.Name = "txtPictureImage"
        Me.txtPictureImage.Size = New System.Drawing.Size(248, 20)
        Me.txtPictureImage.TabIndex = 0
        '
        'grpSeries
        '
        Me.grpSeries.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpSeries.Controls.Add(Me.LabelControl13)
        Me.grpSeries.Controls.Add(Me.LabelControl12)
        Me.grpSeries.Controls.Add(Me.txtABOSerieNbr)
        Me.grpSeries.Controls.Add(Me.LabelControl10)
        Me.grpSeries.Controls.Add(Me.cmbABOSerie)
        Me.grpSeries.Controls.Add(Me.LabelControl11)
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
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(8, 88)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl12.TabIndex = 34
        Me.LabelControl12.Text = "For ABO Process"
        '
        'txtABOSerieNbr
        '
        Me.txtABOSerieNbr.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_series_aboprocess_number", True))
        Me.txtABOSerieNbr.Enabled = False
        Me.txtABOSerieNbr.Location = New System.Drawing.Point(96, 128)
        Me.txtABOSerieNbr.Name = "txtABOSerieNbr"
        Me.txtABOSerieNbr.Size = New System.Drawing.Size(160, 20)
        Me.txtABOSerieNbr.TabIndex = 31
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(8, 128)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl10.TabIndex = 33
        Me.LabelControl10.Text = "Serie Nbr"
        '
        'cmbABOSerie
        '
        Me.cmbABOSerie.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_series_aboprocess_id", True))
        Me.cmbABOSerie.Enabled = False
        Me.cmbABOSerie.Location = New System.Drawing.Point(96, 104)
        Me.cmbABOSerie.Name = "cmbABOSerie"
        Me.cmbABOSerie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.cmbABOSerie.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_id", "series_id", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_name", "series_name", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbABOSerie.Properties.DataSource = Me.objDS.series
        Me.cmbABOSerie.Properties.DisplayMember = "series_name"
        Me.cmbABOSerie.Properties.NullText = ""
        Me.cmbABOSerie.Properties.ValueMember = "series_id"
        Me.cmbABOSerie.Size = New System.Drawing.Size(160, 20)
        Me.cmbABOSerie.TabIndex = 30
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(8, 104)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl11.TabIndex = 32
        Me.LabelControl11.Text = "Serie"
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
        Me.grpMain.Controls.Add(Me.cmbProducts_product_type)
        Me.grpMain.Controls.Add(Me.LabelControl52)
        Me.grpMain.Controls.Add(Me.txtIMDB_ID)
        Me.grpMain.Controls.Add(Me.LabelControl51)
        Me.grpMain.Controls.Add(Me.txtTitle)
        Me.grpMain.Controls.Add(Me.chkInTheBagsNext)
        Me.grpMain.Controls.Add(Me.chkInTheBags)
        Me.grpMain.Controls.Add(Me.chkInCinemaNow)
        Me.grpMain.Controls.Add(Me.chkProduct_Next)
        Me.grpMain.Controls.Add(Me.txtOtherProductID)
        Me.grpMain.Controls.Add(Me.LabelControl39)
        Me.grpMain.Controls.Add(Me.chkGommetteNL)
        Me.grpMain.Controls.Add(Me.chkGommetteFR)
        Me.grpMain.Controls.Add(Me.cmbRating)
        Me.grpMain.Controls.Add(Me.LabelControl9)
        Me.grpMain.Controls.Add(Me.LabelControl8)
        Me.grpMain.Controls.Add(Me.cmbAvailability)
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
        Me.grpMain.Controls.Add(Me.txtQtyNow)
        Me.grpMain.Controls.Add(Me.lblQtyNow)
        Me.grpMain.Controls.Add(Me.txtQty)
        Me.grpMain.Controls.Add(Me.LabelControl1)
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
        '
        'LabelControl52
        '
        Me.LabelControl52.Location = New System.Drawing.Point(16, 97)
        Me.LabelControl52.Name = "LabelControl52"
        Me.LabelControl52.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl52.TabIndex = 53
        Me.LabelControl52.Text = "Product Type"
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
        'chkInTheBagsNext
        '
        Me.chkInTheBagsNext.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.in_the_bags_next", True))
        Me.chkInTheBagsNext.EditValue = 0
        Me.chkInTheBagsNext.Enabled = False
        Me.chkInTheBagsNext.Location = New System.Drawing.Point(232, 407)
        Me.chkInTheBagsNext.Name = "chkInTheBagsNext"
        Me.chkInTheBagsNext.Properties.Caption = "In The Bags Next"
        Me.chkInTheBagsNext.Properties.ValueChecked = 1
        Me.chkInTheBagsNext.Properties.ValueUnchecked = 0
        Me.chkInTheBagsNext.Size = New System.Drawing.Size(112, 19)
        Me.chkInTheBagsNext.TabIndex = 48
        '
        'chkInTheBags
        '
        Me.chkInTheBags.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.in_the_bags", True))
        Me.chkInTheBags.EditValue = 0
        Me.chkInTheBags.Enabled = False
        Me.chkInTheBags.Location = New System.Drawing.Point(104, 407)
        Me.chkInTheBags.Name = "chkInTheBags"
        Me.chkInTheBags.Properties.Caption = "In The Bags"
        Me.chkInTheBags.Properties.ValueChecked = 1
        Me.chkInTheBags.Properties.ValueUnchecked = 0
        Me.chkInTheBags.Size = New System.Drawing.Size(112, 19)
        Me.chkInTheBags.TabIndex = 47
        '
        'chkInCinemaNow
        '
        Me.chkInCinemaNow.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.in_cinema_now", True))
        Me.chkInCinemaNow.EditValue = 0
        Me.chkInCinemaNow.Enabled = False
        Me.chkInCinemaNow.Location = New System.Drawing.Point(232, 391)
        Me.chkInCinemaNow.Name = "chkInCinemaNow"
        Me.chkInCinemaNow.Properties.Caption = "In Cinema Now"
        Me.chkInCinemaNow.Properties.ValueChecked = 1
        Me.chkInCinemaNow.Properties.ValueUnchecked = 0
        Me.chkInCinemaNow.Size = New System.Drawing.Size(112, 19)
        Me.chkInCinemaNow.TabIndex = 46
        '
        'chkProduct_Next
        '
        Me.chkProduct_Next.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_next", True))
        Me.chkProduct_Next.EditValue = 0
        Me.chkProduct_Next.Enabled = False
        Me.chkProduct_Next.Location = New System.Drawing.Point(104, 391)
        Me.chkProduct_Next.Name = "chkProduct_Next"
        Me.chkProduct_Next.Properties.Caption = "Product Next"
        Me.chkProduct_Next.Properties.ValueChecked = 1
        Me.chkProduct_Next.Properties.ValueUnchecked = 0
        Me.chkProduct_Next.Size = New System.Drawing.Size(112, 19)
        Me.chkProduct_Next.TabIndex = 45
        '
        'txtOtherProductID
        '
        Me.txtOtherProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_other_language", True))
        Me.txtOtherProductID.Enabled = False
        Me.txtOtherProductID.Location = New System.Drawing.Point(328, 24)
        Me.txtOtherProductID.Name = "txtOtherProductID"
        Me.txtOtherProductID.Size = New System.Drawing.Size(104, 20)
        Me.txtOtherProductID.TabIndex = 44
        '
        'LabelControl39
        '
        Me.LabelControl39.Location = New System.Drawing.Point(240, 24)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl39.TabIndex = 43
        Me.LabelControl39.Text = "Linked ID"
        Me.ToolTip1.SetToolTip(Me.LabelControl39, "Product ID of same title in another language.")
        '
        'chkGommetteNL
        '
        Me.chkGommetteNL.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_undertitle_nl", True))
        Me.chkGommetteNL.EditValue = 0
        Me.chkGommetteNL.Enabled = False
        Me.chkGommetteNL.Location = New System.Drawing.Point(232, 431)
        Me.chkGommetteNL.Name = "chkGommetteNL"
        Me.chkGommetteNL.Properties.Caption = "Gommette NL"
        Me.chkGommetteNL.Properties.ValueChecked = 1
        Me.chkGommetteNL.Properties.ValueUnchecked = 0
        Me.chkGommetteNL.Size = New System.Drawing.Size(112, 19)
        Me.chkGommetteNL.TabIndex = 42
        '
        'chkGommetteFR
        '
        Me.chkGommetteFR.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_language_fr", True))
        Me.chkGommetteFR.EditValue = 0
        Me.chkGommetteFR.Enabled = False
        Me.chkGommetteFR.Location = New System.Drawing.Point(104, 431)
        Me.chkGommetteFR.Name = "chkGommetteFR"
        Me.chkGommetteFR.Properties.Caption = "Gommette FR"
        Me.chkGommetteFR.Properties.ValueChecked = 1
        Me.chkGommetteFR.Properties.ValueUnchecked = 0
        Me.chkGommetteFR.Size = New System.Drawing.Size(112, 19)
        Me.chkGommetteFR.TabIndex = 41
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
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(240, 48)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl8.TabIndex = 39
        Me.LabelControl8.Text = "Availability"
        '
        'cmbAvailability
        '
        Me.cmbAvailability.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_availability", True))
        Me.cmbAvailability.Enabled = False
        Me.cmbAvailability.Location = New System.Drawing.Point(328, 48)
        Me.cmbAvailability.Name = "cmbAvailability"
        Me.cmbAvailability.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAvailability.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("availability_id", "availability_id", 83, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("availability_desc", "availability_desc", 84, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbAvailability.Properties.DataSource = Me.objDS.view_products_availability
        Me.cmbAvailability.Properties.DisplayMember = "availability_desc"
        Me.cmbAvailability.Properties.NullText = ""
        Me.cmbAvailability.Properties.ValueMember = "availability_id"
        Me.cmbAvailability.Size = New System.Drawing.Size(104, 20)
        Me.cmbAvailability.TabIndex = 2
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(16, 367)
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
        Me.cmbProducts_Status.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("status_id", "status_id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("status_desc", "status_desc", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
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
        Me.cmbDirector.Location = New System.Drawing.Point(104, 367)
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
        Me.cmbPictureFormat.Location = New System.Drawing.Point(104, 319)
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
        Me.lblPictureFormat.Location = New System.Drawing.Point(16, 319)
        Me.lblPictureFormat.Name = "lblPictureFormat"
        Me.lblPictureFormat.Size = New System.Drawing.Size(70, 13)
        Me.lblPictureFormat.TabIndex = 24
        Me.lblPictureFormat.Text = "Picture Format"
        '
        'cmbPublic
        '
        Me.cmbPublic.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_public", True))
        Me.cmbPublic.Enabled = False
        Me.cmbPublic.Location = New System.Drawing.Point(104, 295)
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
        Me.lblPublic.Location = New System.Drawing.Point(16, 295)
        Me.lblPublic.Name = "lblPublic"
        Me.lblPublic.Size = New System.Drawing.Size(27, 13)
        Me.lblPublic.TabIndex = 22
        Me.lblPublic.Text = "Public"
        '
        'cmbStudio
        '
        Me.cmbStudio.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_studio", True))
        Me.cmbStudio.Enabled = False
        Me.cmbStudio.Location = New System.Drawing.Point(104, 343)
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
        Me.lblStudio.Location = New System.Drawing.Point(16, 343)
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
        'txtQtyNow
        '
        Me.txtQtyNow.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_quantity", True))
        Me.txtQtyNow.Enabled = False
        Me.txtQtyNow.Location = New System.Drawing.Point(328, 171)
        Me.txtQtyNow.Name = "txtQtyNow"
        Me.txtQtyNow.Size = New System.Drawing.Size(104, 20)
        Me.txtQtyNow.TabIndex = 8
        '
        'lblQtyNow
        '
        Me.lblQtyNow.Location = New System.Drawing.Point(240, 171)
        Me.lblQtyNow.Name = "lblQtyNow"
        Me.lblQtyNow.Size = New System.Drawing.Size(42, 13)
        Me.lblQtyNow.TabIndex = 8
        Me.lblQtyNow.Text = "Qty Now"
        '
        'txtQty
        '
        Me.txtQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_dvd_quantity", True))
        Me.txtQty.Enabled = False
        Me.txtQty.Location = New System.Drawing.Point(104, 171)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(112, 20)
        Me.txtQty.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 171)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Qty"
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
        'tabTheme
        '
        Me.tabTheme.Controls.Add(Me.PanelControl7)
        Me.tabTheme.Controls.Add(Me.SplitterControl2)
        Me.tabTheme.Controls.Add(Me.PanelControl6)
        Me.tabTheme.Name = "tabTheme"
        Me.tabTheme.Size = New System.Drawing.Size(1047, 629)
        Me.tabTheme.Text = "Themes and Categories"
        '
        'PanelControl7
        '
        Me.PanelControl7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl7.Controls.Add(Me.TreeListThemes)
        Me.PanelControl7.Controls.Add(Me.PanelControl12)
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl7.Location = New System.Drawing.Point(550, 0)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(497, 629)
        Me.PanelControl7.TabIndex = 12
        '
        'TreeListThemes
        '
        Me.TreeListThemes.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeListThemes.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.TreeListThemes.Appearance.Empty.Options.UseBackColor = True
        Me.TreeListThemes.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeListThemes.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeListThemes.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.TreeListThemes.Appearance.EvenRow.Options.UseBackColor = True
        Me.TreeListThemes.Appearance.EvenRow.Options.UseBorderColor = True
        Me.TreeListThemes.Appearance.EvenRow.Options.UseForeColor = True
        Me.TreeListThemes.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.TreeListThemes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.TreeListThemes.Appearance.FocusedCell.Options.UseBackColor = True
        Me.TreeListThemes.Appearance.FocusedCell.Options.UseForeColor = True
        Me.TreeListThemes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.TreeListThemes.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.TreeListThemes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.TreeListThemes.Appearance.FocusedRow.Options.UseBackColor = True
        Me.TreeListThemes.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.TreeListThemes.Appearance.FocusedRow.Options.UseForeColor = True
        Me.TreeListThemes.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeListThemes.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeListThemes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.TreeListThemes.Appearance.FooterPanel.Options.UseBackColor = True
        Me.TreeListThemes.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.TreeListThemes.Appearance.FooterPanel.Options.UseForeColor = True
        Me.TreeListThemes.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeListThemes.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeListThemes.Appearance.GroupButton.Options.UseBackColor = True
        Me.TreeListThemes.Appearance.GroupButton.Options.UseBorderColor = True
        Me.TreeListThemes.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TreeListThemes.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TreeListThemes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.TreeListThemes.Appearance.GroupFooter.Options.UseBackColor = True
        Me.TreeListThemes.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.TreeListThemes.Appearance.GroupFooter.Options.UseForeColor = True
        Me.TreeListThemes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TreeListThemes.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TreeListThemes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.TreeListThemes.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.TreeListThemes.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.TreeListThemes.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.TreeListThemes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TreeListThemes.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TreeListThemes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeListThemes.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.TreeListThemes.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.TreeListThemes.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.TreeListThemes.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeListThemes.Appearance.HorzLine.Options.UseBackColor = True
        Me.TreeListThemes.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeListThemes.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeListThemes.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.TreeListThemes.Appearance.OddRow.Options.UseBackColor = True
        Me.TreeListThemes.Appearance.OddRow.Options.UseBorderColor = True
        Me.TreeListThemes.Appearance.OddRow.Options.UseForeColor = True
        Me.TreeListThemes.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.TreeListThemes.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TreeListThemes.Appearance.Preview.Options.UseFont = True
        Me.TreeListThemes.Appearance.Preview.Options.UseForeColor = True
        Me.TreeListThemes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeListThemes.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.TreeListThemes.Appearance.Row.Options.UseBackColor = True
        Me.TreeListThemes.Appearance.Row.Options.UseForeColor = True
        Me.TreeListThemes.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TreeListThemes.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.TreeListThemes.Appearance.SelectedRow.Options.UseBackColor = True
        Me.TreeListThemes.Appearance.SelectedRow.Options.UseForeColor = True
        Me.TreeListThemes.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.TreeListThemes.Appearance.TreeLine.Options.UseBackColor = True
        Me.TreeListThemes.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TreeListThemes.Appearance.VertLine.Options.UseBackColor = True
        Me.TreeListThemes.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colthemes_id, Me.colparent_id1, Me.colthemes_type, Me.colthemes_name, Me.colthemes_selected})
        Me.TreeListThemes.CustomizationFormBounds = New System.Drawing.Rectangle(960, 402, 208, 170)
        Me.TreeListThemes.DataSource = Me.objDS.themes_fr_view1
        Me.TreeListThemes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeListThemes.KeyFieldName = "themes_id"
        Me.TreeListThemes.Location = New System.Drawing.Point(2, 2)
        Me.TreeListThemes.Name = "TreeListThemes"
        Me.TreeListThemes.OptionsBehavior.Editable = False
        Me.TreeListThemes.OptionsBehavior.PopulateServiceColumns = True
        Me.TreeListThemes.OptionsView.EnableAppearanceEvenRow = True
        Me.TreeListThemes.OptionsView.EnableAppearanceOddRow = True
        Me.TreeListThemes.OptionsView.ShowHorzLines = False
        Me.TreeListThemes.OptionsView.ShowIndicator = False
        Me.TreeListThemes.OptionsView.ShowVertLines = False
        Me.TreeListThemes.ParentFieldName = "parent_id"
        Me.TreeListThemes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkThemeSelected})
        Me.TreeListThemes.Size = New System.Drawing.Size(493, 577)
        Me.TreeListThemes.TabIndex = 9
        '
        'colthemes_id
        '
        Me.colthemes_id.Caption = "themes_id"
        Me.colthemes_id.FieldName = "themes_id"
        Me.colthemes_id.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colthemes_id.Name = "colthemes_id"
        Me.colthemes_id.Width = 99
        '
        'colparent_id1
        '
        Me.colparent_id1.Caption = "parent_id"
        Me.colparent_id1.FieldName = "parent_id"
        Me.colparent_id1.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colparent_id1.Name = "colparent_id1"
        Me.colparent_id1.Width = 99
        '
        'colthemes_type
        '
        Me.colthemes_type.Caption = "themes_type"
        Me.colthemes_type.FieldName = "themes_type"
        Me.colthemes_type.Name = "colthemes_type"
        Me.colthemes_type.Visible = True
        Me.colthemes_type.VisibleIndex = 1
        Me.colthemes_type.Width = 165
        '
        'colthemes_name
        '
        Me.colthemes_name.Caption = "themes_name"
        Me.colthemes_name.FieldName = "themes_name"
        Me.colthemes_name.Name = "colthemes_name"
        Me.colthemes_name.Visible = True
        Me.colthemes_name.VisibleIndex = 0
        Me.colthemes_name.Width = 164
        '
        'colthemes_selected
        '
        Me.colthemes_selected.Caption = "themes_selected"
        Me.colthemes_selected.ColumnEdit = Me.chkThemeSelected
        Me.colthemes_selected.FieldName = "themes_selected"
        Me.colthemes_selected.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colthemes_selected.Name = "colthemes_selected"
        Me.colthemes_selected.Visible = True
        Me.colthemes_selected.VisibleIndex = 2
        Me.colthemes_selected.Width = 163
        '
        'chkThemeSelected
        '
        Me.chkThemeSelected.AutoHeight = False
        Me.chkThemeSelected.Name = "chkThemeSelected"
        Me.chkThemeSelected.ValueChecked = 1
        Me.chkThemeSelected.ValueUnchecked = 0
        '
        'PanelControl12
        '
        Me.PanelControl12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl12.Controls.Add(Me.btnThemes)
        Me.PanelControl12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl12.Location = New System.Drawing.Point(2, 579)
        Me.PanelControl12.Name = "PanelControl12"
        Me.PanelControl12.Size = New System.Drawing.Size(493, 48)
        Me.PanelControl12.TabIndex = 10
        '
        'btnThemes
        '
        Me.btnThemes.Location = New System.Drawing.Point(8, 16)
        Me.btnThemes.Name = "btnThemes"
        Me.btnThemes.Size = New System.Drawing.Size(120, 23)
        Me.btnThemes.TabIndex = 0
        Me.btnThemes.Text = "Manage Themes"
        '
        'SplitterControl2
        '
        Me.SplitterControl2.Location = New System.Drawing.Point(544, 0)
        Me.SplitterControl2.Name = "SplitterControl2"
        Me.SplitterControl2.Size = New System.Drawing.Size(6, 629)
        Me.SplitterControl2.TabIndex = 11
        Me.SplitterControl2.TabStop = False
        '
        'PanelControl6
        '
        Me.PanelControl6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl6.Controls.Add(Me.TreeListCategories)
        Me.PanelControl6.Controls.Add(Me.PanelControl11)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl6.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(544, 629)
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
        Me.TreeListCategories.KeyFieldName = "categories_id"
        Me.TreeListCategories.Location = New System.Drawing.Point(2, 2)
        Me.TreeListCategories.Name = "TreeListCategories"
        Me.TreeListCategories.OptionsBehavior.Editable = False
        Me.TreeListCategories.OptionsBehavior.PopulateServiceColumns = True
        Me.TreeListCategories.OptionsView.EnableAppearanceEvenRow = True
        Me.TreeListCategories.OptionsView.EnableAppearanceOddRow = True
        Me.TreeListCategories.OptionsView.ShowHorzLines = False
        Me.TreeListCategories.OptionsView.ShowIndicator = False
        Me.TreeListCategories.OptionsView.ShowVertLines = False
        Me.TreeListCategories.ParentFieldName = "parent_id"
        Me.TreeListCategories.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkSelectCategory})
        Me.TreeListCategories.Size = New System.Drawing.Size(540, 577)
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
        'PanelControl11
        '
        Me.PanelControl11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl11.Controls.Add(Me.btnCategories)
        Me.PanelControl11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl11.Location = New System.Drawing.Point(2, 579)
        Me.PanelControl11.Name = "PanelControl11"
        Me.PanelControl11.Size = New System.Drawing.Size(540, 48)
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
        Me.tabLanguages.Size = New System.Drawing.Size(1047, 629)
        Me.tabLanguages.Text = "Languages"
        '
        'grpSubTitles
        '
        Me.grpSubTitles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpSubTitles.Controls.Add(Me.GridUndertitles)
        Me.grpSubTitles.Controls.Add(Me.PanelControl5)
        Me.grpSubTitles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpSubTitles.Location = New System.Drawing.Point(502, 0)
        Me.grpSubTitles.Name = "grpSubTitles"
        Me.grpSubTitles.Size = New System.Drawing.Size(545, 629)
        Me.grpSubTitles.TabIndex = 2
        Me.grpSubTitles.Text = "SubTitles"
        '
        'GridUndertitles
        '
        Me.GridUndertitles.DataSource = Me.objDS.products_to_undertitles
        Me.GridUndertitles.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.SplitterControl1.Location = New System.Drawing.Point(496, 0)
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
        Me.grpLanguage.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpLanguage.Location = New System.Drawing.Point(0, 0)
        Me.grpLanguage.Name = "grpLanguage"
        Me.grpLanguage.Size = New System.Drawing.Size(496, 629)
        Me.grpLanguage.TabIndex = 0
        Me.grpLanguage.Text = "Language"
        '
        'GridLanguages
        '
        Me.GridLanguages.DataSource = Me.objDS.products_to_languages
        Me.GridLanguages.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.GridLanguages.Size = New System.Drawing.Size(492, 567)
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
        Me.PanelControl4.Size = New System.Drawing.Size(492, 40)
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
        Me.tabTrailers.Controls.Add(Me.grpSoundTracks)
        Me.tabTrailers.Controls.Add(Me.SplitterControl3)
        Me.tabTrailers.Controls.Add(Me.grpTrailers)
        Me.tabTrailers.Name = "tabTrailers"
        Me.tabTrailers.Size = New System.Drawing.Size(1047, 629)
        Me.tabTrailers.Text = "Trailers / Sound Tracks"
        '
        'grpSoundTracks
        '
        Me.grpSoundTracks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpSoundTracks.Controls.Add(Me.GridSoundtracks)
        Me.grpSoundTracks.Controls.Add(Me.PanelControl9)
        Me.grpSoundTracks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpSoundTracks.Location = New System.Drawing.Point(590, 0)
        Me.grpSoundTracks.Name = "grpSoundTracks"
        Me.grpSoundTracks.Size = New System.Drawing.Size(457, 629)
        Me.grpSoundTracks.TabIndex = 3
        Me.grpSoundTracks.Text = "SoundTracks"
        '
        'GridSoundtracks
        '
        Me.GridSoundtracks.DataSource = Me.objDS.products_to_soundtracks
        Me.GridSoundtracks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSoundtracks.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridSoundtracks.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridSoundtracks.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridSoundtracks.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridSoundtracks.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridSoundtracks.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridSoundtracks.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridSoundtracks.EmbeddedNavigator.Enabled = False
        Me.GridSoundtracks.EmbeddedNavigator.Name = ""
        Me.GridSoundtracks.FormsUseDefaultLookAndFeel = False
        Me.GridSoundtracks.Location = New System.Drawing.Point(2, 20)
        Me.GridSoundtracks.MainView = Me.GridViewSoundTracks
        Me.GridSoundtracks.Name = "GridSoundtracks"
        Me.GridSoundtracks.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbSoundTracks})
        Me.GridSoundtracks.Size = New System.Drawing.Size(453, 567)
        Me.GridSoundtracks.TabIndex = 4
        Me.GridSoundtracks.UseEmbeddedNavigator = True
        Me.GridSoundtracks.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSoundTracks})
        '
        'GridViewSoundTracks
        '
        Me.GridViewSoundTracks.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand8})
        Me.GridViewSoundTracks.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colproducts_id5, Me.colproducts_soundtracks_id})
        Me.GridViewSoundTracks.CustomizationFormBounds = New System.Drawing.Rectangle(755, 333, 217, 222)
        Me.GridViewSoundTracks.GridControl = Me.GridSoundtracks
        Me.GridViewSoundTracks.Name = "GridViewSoundTracks"
        Me.GridViewSoundTracks.OptionsBehavior.Editable = False
        Me.GridViewSoundTracks.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridViewSoundTracks.OptionsView.ShowBands = False
        Me.GridViewSoundTracks.OptionsView.ShowGroupPanel = False
        '
        'GridBand8
        '
        Me.GridBand8.Caption = "gridBand1"
        Me.GridBand8.Columns.Add(Me.colproducts_id5)
        Me.GridBand8.Columns.Add(Me.colproducts_soundtracks_id)
        Me.GridBand8.Name = "GridBand8"
        Me.GridBand8.Width = 310
        '
        'colproducts_id5
        '
        Me.colproducts_id5.Caption = "products_id"
        Me.colproducts_id5.FieldName = "products_id"
        Me.colproducts_id5.Name = "colproducts_id5"
        Me.colproducts_id5.Width = 123
        '
        'colproducts_soundtracks_id
        '
        Me.colproducts_soundtracks_id.Caption = "products_soundtracks_id"
        Me.colproducts_soundtracks_id.ColumnEdit = Me.cmbSoundTracks
        Me.colproducts_soundtracks_id.FieldName = "products_soundtracks_id"
        Me.colproducts_soundtracks_id.Name = "colproducts_soundtracks_id"
        Me.colproducts_soundtracks_id.Visible = True
        Me.colproducts_soundtracks_id.Width = 310
        '
        'cmbSoundTracks
        '
        Me.cmbSoundTracks.AutoHeight = False
        Me.cmbSoundTracks.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSoundTracks.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("soundtracks_id", "soundtracks_id", 91, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("soundtracks_description", "soundtracks_description", 116, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbSoundTracks.DataSource = Me.objDS.products_soundtracks
        Me.cmbSoundTracks.DisplayMember = "soundtracks_description"
        Me.cmbSoundTracks.Name = "cmbSoundTracks"
        Me.cmbSoundTracks.NullText = "NEW Line"
        Me.cmbSoundTracks.ValueMember = "soundtracks_id"
        '
        'PanelControl9
        '
        Me.PanelControl9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl9.Controls.Add(Me.btnSoundTracks)
        Me.PanelControl9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl9.Location = New System.Drawing.Point(2, 587)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(453, 40)
        Me.PanelControl9.TabIndex = 5
        '
        'btnSoundTracks
        '
        Me.btnSoundTracks.Location = New System.Drawing.Point(8, 8)
        Me.btnSoundTracks.Name = "btnSoundTracks"
        Me.btnSoundTracks.Size = New System.Drawing.Size(120, 23)
        Me.btnSoundTracks.TabIndex = 0
        Me.btnSoundTracks.Text = "Manage Soundtracks"
        '
        'SplitterControl3
        '
        Me.SplitterControl3.Appearance.BackColor = System.Drawing.SystemColors.Highlight
        Me.SplitterControl3.Appearance.Options.UseBackColor = True
        Me.SplitterControl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitterControl3.Location = New System.Drawing.Point(584, 0)
        Me.SplitterControl3.Name = "SplitterControl3"
        Me.SplitterControl3.Size = New System.Drawing.Size(6, 629)
        Me.SplitterControl3.TabIndex = 2
        Me.SplitterControl3.TabStop = False
        '
        'grpTrailers
        '
        Me.grpTrailers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpTrailers.Controls.Add(Me.GridTrailers)
        Me.grpTrailers.Controls.Add(Me.PanelControl8)
        Me.grpTrailers.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpTrailers.Location = New System.Drawing.Point(0, 0)
        Me.grpTrailers.Name = "grpTrailers"
        Me.grpTrailers.Size = New System.Drawing.Size(584, 629)
        Me.grpTrailers.TabIndex = 1
        Me.grpTrailers.Text = "Trailers"
        '
        'GridTrailers
        '
        Me.GridTrailers.DataSource = Me.objDS.products_trailers
        Me.GridTrailers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridTrailers.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridTrailers.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridTrailers.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridTrailers.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridTrailers.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridTrailers.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridTrailers.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridTrailers.EmbeddedNavigator.Enabled = False
        Me.GridTrailers.EmbeddedNavigator.Name = ""
        Me.GridTrailers.FormsUseDefaultLookAndFeel = False
        Me.GridTrailers.Location = New System.Drawing.Point(2, 20)
        Me.GridTrailers.MainView = Me.GridViewTrailers
        Me.GridTrailers.Name = "GridTrailers"
        Me.GridTrailers.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbLangTrailer, Me.cmbTrailers_Broadcast})
        Me.GridTrailers.Size = New System.Drawing.Size(580, 567)
        Me.GridTrailers.TabIndex = 4
        Me.GridTrailers.UseEmbeddedNavigator = True
        Me.GridTrailers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewTrailers})
        '
        'GridViewTrailers
        '
        Me.GridViewTrailers.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand7})
        Me.GridViewTrailers.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.coltrailers_id, Me.colproducts_id4, Me.collanguage_id1, Me.coltrailer, Me.colbroadcast})
        Me.GridViewTrailers.CustomizationFormBounds = New System.Drawing.Rectangle(755, 333, 217, 222)
        Me.GridViewTrailers.GridControl = Me.GridTrailers
        Me.GridViewTrailers.Name = "GridViewTrailers"
        Me.GridViewTrailers.OptionsBehavior.Editable = False
        Me.GridViewTrailers.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridViewTrailers.OptionsView.ShowBands = False
        Me.GridViewTrailers.OptionsView.ShowGroupPanel = False
        '
        'GridBand7
        '
        Me.GridBand7.Caption = "GridBand2"
        Me.GridBand7.Columns.Add(Me.coltrailers_id)
        Me.GridBand7.Columns.Add(Me.colproducts_id4)
        Me.GridBand7.Columns.Add(Me.collanguage_id1)
        Me.GridBand7.Columns.Add(Me.coltrailer)
        Me.GridBand7.Columns.Add(Me.colbroadcast)
        Me.GridBand7.Name = "GridBand7"
        Me.GridBand7.Width = 556
        '
        'coltrailers_id
        '
        Me.coltrailers_id.Caption = "trailers_id"
        Me.coltrailers_id.FieldName = "trailers_id"
        Me.coltrailers_id.Name = "coltrailers_id"
        Me.coltrailers_id.Width = 121
        '
        'colproducts_id4
        '
        Me.colproducts_id4.Caption = "products_id"
        Me.colproducts_id4.FieldName = "products_id"
        Me.colproducts_id4.Name = "colproducts_id4"
        Me.colproducts_id4.Width = 132
        '
        'collanguage_id1
        '
        Me.collanguage_id1.Caption = "language_id"
        Me.collanguage_id1.ColumnEdit = Me.cmbLangTrailer
        Me.collanguage_id1.FieldName = "language_id"
        Me.collanguage_id1.Name = "collanguage_id1"
        Me.collanguage_id1.Visible = True
        Me.collanguage_id1.Width = 113
        '
        'cmbLangTrailer
        '
        Me.cmbLangTrailer.AutoHeight = False
        Me.cmbLangTrailer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLangTrailer.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "languages_id", 82, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_description", "languages_description", 113, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbLangTrailer.DataSource = Me.objDS.products_languages
        Me.cmbLangTrailer.DisplayMember = "languages_description"
        Me.cmbLangTrailer.Name = "cmbLangTrailer"
        Me.cmbLangTrailer.NullText = "New Line"
        Me.cmbLangTrailer.ValueMember = "languages_id"
        '
        'coltrailer
        '
        Me.coltrailer.Caption = "trailer"
        Me.coltrailer.FieldName = "trailer"
        Me.coltrailer.Name = "coltrailer"
        Me.coltrailer.Visible = True
        Me.coltrailer.Width = 330
        '
        'colbroadcast
        '
        Me.colbroadcast.Caption = "broadcast"
        Me.colbroadcast.ColumnEdit = Me.cmbTrailers_Broadcast
        Me.colbroadcast.FieldName = "broadcast"
        Me.colbroadcast.Name = "colbroadcast"
        Me.colbroadcast.Visible = True
        Me.colbroadcast.Width = 113
        '
        'cmbTrailers_Broadcast
        '
        Me.cmbTrailers_Broadcast.AutoHeight = False
        Me.cmbTrailers_Broadcast.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTrailers_Broadcast.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("broadcast", "broadcast", 67, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbTrailers_Broadcast.DataSource = Me.objDS.trailers_broadcast
        Me.cmbTrailers_Broadcast.DisplayMember = "broadcast"
        Me.cmbTrailers_Broadcast.Name = "cmbTrailers_Broadcast"
        Me.cmbTrailers_Broadcast.ValueMember = "broadcast"
        '
        'PanelControl8
        '
        Me.PanelControl8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl8.Location = New System.Drawing.Point(2, 587)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(580, 40)
        Me.PanelControl8.TabIndex = 5
        '
        'tabFeeSharing
        '
        Me.tabFeeSharing.Controls.Add(Me.GroupControl6)
        Me.tabFeeSharing.Controls.Add(Me.GroupControl7)
        Me.tabFeeSharing.Name = "tabFeeSharing"
        Me.tabFeeSharing.Size = New System.Drawing.Size(1047, 629)
        Me.tabFeeSharing.Text = "FeeSharing / Sale / Purchase"
        '
        'GroupControl6
        '
        Me.GroupControl6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl6.Controls.Add(Me.chkOnly_for_sale)
        Me.GroupControl6.Controls.Add(Me.txtNew_Sale_Price)
        Me.GroupControl6.Controls.Add(Me.LabelControl44)
        Me.GroupControl6.Controls.Add(Me.txtNew_qty_to_sale)
        Me.GroupControl6.Controls.Add(Me.LabelControl45)
        Me.GroupControl6.Controls.Add(Me.txtSale_price)
        Me.GroupControl6.Controls.Add(Me.LabelControl43)
        Me.GroupControl6.Controls.Add(Me.txtQty_to_sale)
        Me.GroupControl6.Controls.Add(Me.LabelControl42)
        Me.GroupControl6.Controls.Add(Me.txtPrice)
        Me.GroupControl6.Controls.Add(Me.LabelControl41)
        Me.GroupControl6.Controls.Add(Me.LabelControl40)
        Me.GroupControl6.Controls.Add(Me.txtSaleDate)
        Me.GroupControl6.Location = New System.Drawing.Point(328, 16)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(272, 224)
        Me.GroupControl6.TabIndex = 52
        Me.GroupControl6.Text = "Purchase / Sales Info"
        '
        'chkOnly_for_sale
        '
        Me.chkOnly_for_sale.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.only_for_sale", True))
        Me.chkOnly_for_sale.EditValue = 0
        Me.chkOnly_for_sale.Enabled = False
        Me.chkOnly_for_sale.Location = New System.Drawing.Point(8, 184)
        Me.chkOnly_for_sale.Name = "chkOnly_for_sale"
        Me.chkOnly_for_sale.Properties.Caption = "Only For Sale"
        Me.chkOnly_for_sale.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkOnly_for_sale.Properties.ValueChecked = 1
        Me.chkOnly_for_sale.Properties.ValueUnchecked = 0
        Me.chkOnly_for_sale.Size = New System.Drawing.Size(104, 19)
        Me.chkOnly_for_sale.TabIndex = 51
        '
        'txtNew_Sale_Price
        '
        Me.txtNew_Sale_Price.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_new_sale_price", True))
        Me.txtNew_Sale_Price.Enabled = False
        Me.txtNew_Sale_Price.Location = New System.Drawing.Point(96, 160)
        Me.txtNew_Sale_Price.Name = "txtNew_Sale_Price"
        Me.txtNew_Sale_Price.Size = New System.Drawing.Size(112, 20)
        Me.txtNew_Sale_Price.TabIndex = 49
        '
        'LabelControl44
        '
        Me.LabelControl44.Location = New System.Drawing.Point(8, 160)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl44.TabIndex = 50
        Me.LabelControl44.Text = "NEW Sale Price"
        '
        'txtNew_qty_to_sale
        '
        Me.txtNew_qty_to_sale.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.quantity_new_to_sale", True))
        Me.txtNew_qty_to_sale.Enabled = False
        Me.txtNew_qty_to_sale.Location = New System.Drawing.Point(96, 136)
        Me.txtNew_qty_to_sale.Name = "txtNew_qty_to_sale"
        Me.txtNew_qty_to_sale.Size = New System.Drawing.Size(112, 20)
        Me.txtNew_qty_to_sale.TabIndex = 47
        '
        'LabelControl45
        '
        Me.LabelControl45.Location = New System.Drawing.Point(8, 136)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl45.TabIndex = 48
        Me.LabelControl45.Text = "NEW Qty to Sale"
        '
        'txtSale_price
        '
        Me.txtSale_price.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_sale_price", True))
        Me.txtSale_price.Enabled = False
        Me.txtSale_price.Location = New System.Drawing.Point(96, 104)
        Me.txtSale_price.Name = "txtSale_price"
        Me.txtSale_price.Size = New System.Drawing.Size(112, 20)
        Me.txtSale_price.TabIndex = 43
        '
        'LabelControl43
        '
        Me.LabelControl43.Location = New System.Drawing.Point(8, 104)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl43.TabIndex = 44
        Me.LabelControl43.Text = "Sale Price"
        '
        'txtQty_to_sale
        '
        Me.txtQty_to_sale.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.quantity_to_sale", True))
        Me.txtQty_to_sale.Enabled = False
        Me.txtQty_to_sale.Location = New System.Drawing.Point(96, 56)
        Me.txtQty_to_sale.Name = "txtQty_to_sale"
        Me.txtQty_to_sale.Size = New System.Drawing.Size(112, 20)
        Me.txtQty_to_sale.TabIndex = 41
        '
        'LabelControl42
        '
        Me.LabelControl42.Location = New System.Drawing.Point(8, 56)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl42.TabIndex = 42
        Me.LabelControl42.Text = "Qty to Sale"
        '
        'txtPrice
        '
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_price", True))
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(96, 24)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(112, 20)
        Me.txtPrice.TabIndex = 39
        '
        'LabelControl41
        '
        Me.LabelControl41.Location = New System.Drawing.Point(8, 24)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl41.TabIndex = 40
        Me.LabelControl41.Text = "Purchase Price"
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(8, 80)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl40.TabIndex = 38
        Me.LabelControl40.Text = "Sale Date"
        '
        'txtSaleDate
        '
        Me.txtSaleDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_sale_date", True))
        Me.txtSaleDate.EditValue = Nothing
        Me.txtSaleDate.Enabled = False
        Me.txtSaleDate.Location = New System.Drawing.Point(96, 80)
        Me.txtSaleDate.Name = "txtSaleDate"
        Me.txtSaleDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSaleDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtSaleDate.Size = New System.Drawing.Size(112, 20)
        Me.txtSaleDate.TabIndex = 37
        '
        'GroupControl7
        '
        Me.GroupControl7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl7.Controls.Add(Me.LabelControl57)
        Me.GroupControl7.Controls.Add(Me.LabelControl56)
        Me.GroupControl7.Controls.Add(Me.txtTiteNrMovieMax)
        Me.GroupControl7.Controls.Add(Me.cmbFeeSharingStudio)
        Me.GroupControl7.Controls.Add(Me.cmbMovieMaxPartner)
        Me.GroupControl7.Controls.Add(Me.LabelControl48)
        Me.GroupControl7.Controls.Add(Me.txtFeeSharing_TurnPrice)
        Me.GroupControl7.Controls.Add(Me.LabelControl32)
        Me.GroupControl7.Controls.Add(Me.txtFeeSharing_UpfrontFee)
        Me.GroupControl7.Controls.Add(Me.LabelControl30)
        Me.GroupControl7.Controls.Add(Me.LabelControl29)
        Me.GroupControl7.Controls.Add(Me.txtFeeSharing_End)
        Me.GroupControl7.Location = New System.Drawing.Point(24, 16)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(288, 224)
        Me.GroupControl7.TabIndex = 51
        Me.GroupControl7.Text = "Fee Sharing"
        '
        'LabelControl57
        '
        Me.LabelControl57.Location = New System.Drawing.Point(15, 187)
        Me.LabelControl57.Name = "LabelControl57"
        Me.LabelControl57.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl57.TabIndex = 57
        Me.LabelControl57.Text = "Title id MovieMax"
        '
        'LabelControl56
        '
        Me.LabelControl56.Location = New System.Drawing.Point(15, 163)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl56.TabIndex = 56
        Me.LabelControl56.Text = "MovieMax Partner"
        '
        'txtTiteNrMovieMax
        '
        Me.txtTiteNrMovieMax.Enabled = False
        Me.txtTiteNrMovieMax.Location = New System.Drawing.Point(159, 184)
        Me.txtTiteNrMovieMax.Name = "txtTiteNrMovieMax"
        Me.txtTiteNrMovieMax.Size = New System.Drawing.Size(112, 20)
        Me.txtTiteNrMovieMax.TabIndex = 55
        '
        'cmbFeeSharingStudio
        '
        Me.cmbFeeSharingStudio.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.feesharing", True))
        Me.cmbFeeSharingStudio.Enabled = False
        Me.cmbFeeSharingStudio.Location = New System.Drawing.Point(159, 39)
        Me.cmbFeeSharingStudio.Name = "cmbFeeSharingStudio"
        Me.cmbFeeSharingStudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbFeeSharingStudio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbFeeSharingStudio.Properties.DisplayMember = "DisplayMember"
        Me.cmbFeeSharingStudio.Properties.NullText = ""
        Me.cmbFeeSharingStudio.Properties.ValueMember = "Value"
        Me.cmbFeeSharingStudio.Size = New System.Drawing.Size(112, 20)
        Me.cmbFeeSharingStudio.TabIndex = 53
        '
        'cmbMovieMaxPartner
        '
        Me.cmbMovieMaxPartner.Enabled = False
        Me.cmbMovieMaxPartner.Location = New System.Drawing.Point(159, 157)
        Me.cmbMovieMaxPartner.Name = "cmbMovieMaxPartner"
        Me.cmbMovieMaxPartner.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMovieMaxPartner.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("leverancier", "leverancier", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbMovieMaxPartner.Properties.DisplayMember = "leverancier"
        Me.cmbMovieMaxPartner.Properties.NullText = ""
        Me.cmbMovieMaxPartner.Properties.ValueMember = "id"
        Me.cmbMovieMaxPartner.Size = New System.Drawing.Size(112, 20)
        Me.cmbMovieMaxPartner.TabIndex = 54
        '
        'LabelControl48
        '
        Me.LabelControl48.Location = New System.Drawing.Point(15, 42)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(101, 13)
        Me.LabelControl48.TabIndex = 51
        Me.LabelControl48.Text = "FeeSharing Studio ID"
        '
        'txtFeeSharing_TurnPrice
        '
        Me.txtFeeSharing_TurnPrice.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.feesharing_turn_price", True))
        Me.txtFeeSharing_TurnPrice.Enabled = False
        Me.txtFeeSharing_TurnPrice.Location = New System.Drawing.Point(159, 119)
        Me.txtFeeSharing_TurnPrice.Name = "txtFeeSharing_TurnPrice"
        Me.txtFeeSharing_TurnPrice.Size = New System.Drawing.Size(112, 20)
        Me.txtFeeSharing_TurnPrice.TabIndex = 44
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(15, 122)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl32.TabIndex = 43
        Me.LabelControl32.Text = "Turn Price"
        '
        'txtFeeSharing_UpfrontFee
        '
        Me.txtFeeSharing_UpfrontFee.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.feesharing_upfront_fee", True))
        Me.txtFeeSharing_UpfrontFee.Enabled = False
        Me.txtFeeSharing_UpfrontFee.Location = New System.Drawing.Point(159, 93)
        Me.txtFeeSharing_UpfrontFee.Name = "txtFeeSharing_UpfrontFee"
        Me.txtFeeSharing_UpfrontFee.Size = New System.Drawing.Size(112, 20)
        Me.txtFeeSharing_UpfrontFee.TabIndex = 40
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(15, 96)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl30.TabIndex = 39
        Me.LabelControl30.Text = "Upfront Fee"
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(15, 66)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl29.TabIndex = 38
        Me.LabelControl29.Text = "FeeSharing END"
        '
        'txtFeeSharing_End
        '
        Me.txtFeeSharing_End.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.feesharing_end", True))
        Me.txtFeeSharing_End.EditValue = Nothing
        Me.txtFeeSharing_End.Enabled = False
        Me.txtFeeSharing_End.Location = New System.Drawing.Point(159, 66)
        Me.txtFeeSharing_End.Name = "txtFeeSharing_End"
        Me.txtFeeSharing_End.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFeeSharing_End.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtFeeSharing_End.Size = New System.Drawing.Size(112, 20)
        Me.txtFeeSharing_End.TabIndex = 37
        '
        'tabDVDs
        '
        Me.tabDVDs.Controls.Add(Me.PanelControl14)
        Me.tabDVDs.Controls.Add(Me.SplitterControl4)
        Me.tabDVDs.Controls.Add(Me.GroupControl1)
        Me.tabDVDs.Controls.Add(Me.PanelControl13)
        Me.tabDVDs.Name = "tabDVDs"
        Me.tabDVDs.Size = New System.Drawing.Size(1047, 629)
        Me.tabDVDs.Text = "DVDs"
        '
        'PanelControl14
        '
        Me.PanelControl14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl14.Controls.Add(Me.PanelControl15)
        Me.PanelControl14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl14.Location = New System.Drawing.Point(398, 40)
        Me.PanelControl14.Name = "PanelControl14"
        Me.PanelControl14.Size = New System.Drawing.Size(649, 589)
        Me.PanelControl14.TabIndex = 3
        '
        'PanelControl15
        '
        Me.PanelControl15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl15.Controls.Add(Me.PanelControl16)
        Me.PanelControl15.Controls.Add(Me.SplitterControl6)
        Me.PanelControl15.Controls.Add(Me.GroupControl4)
        Me.PanelControl15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl15.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl15.Name = "PanelControl15"
        Me.PanelControl15.Size = New System.Drawing.Size(645, 585)
        Me.PanelControl15.TabIndex = 2
        '
        'PanelControl16
        '
        Me.PanelControl16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl16.Controls.Add(Me.GroupControl3)
        Me.PanelControl16.Controls.Add(Me.SplitterControl5)
        Me.PanelControl16.Controls.Add(Me.GroupControl5)
        Me.PanelControl16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl16.Location = New System.Drawing.Point(262, 2)
        Me.PanelControl16.Name = "PanelControl16"
        Me.PanelControl16.Size = New System.Drawing.Size(381, 581)
        Me.PanelControl16.TabIndex = 3
        '
        'GroupControl3
        '
        Me.GroupControl3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl3.Controls.Add(Me.GridOrdersStatusHistory)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(2, 374)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(377, 205)
        Me.GroupControl3.TabIndex = 4
        Me.GroupControl3.Text = "Orders Status History"
        '
        'GridOrdersStatusHistory
        '
        Me.GridOrdersStatusHistory.DataSource = Me.objDS.orders_status_history
        Me.GridOrdersStatusHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOrdersStatusHistory.EmbeddedNavigator.Name = ""
        Me.GridOrdersStatusHistory.FormsUseDefaultLookAndFeel = False
        Me.GridOrdersStatusHistory.Location = New System.Drawing.Point(2, 20)
        Me.GridOrdersStatusHistory.MainView = Me.GridViewOrdersStatusHistory
        Me.GridOrdersStatusHistory.Name = "GridOrdersStatusHistory"
        Me.GridOrdersStatusHistory.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbOrdersStatus1})
        Me.GridOrdersStatusHistory.Size = New System.Drawing.Size(373, 183)
        Me.GridOrdersStatusHistory.TabIndex = 2
        Me.GridOrdersStatusHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewOrdersStatusHistory})
        '
        'GridViewOrdersStatusHistory
        '
        Me.GridViewOrdersStatusHistory.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand9})
        Me.GridViewOrdersStatusHistory.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colorders_status_history_id, Me.colorders_id1, Me.colnew_value, Me.colold_value, Me.coldate_added, Me.colcustomers_notified})
        Me.GridViewOrdersStatusHistory.CustomizationFormBounds = New System.Drawing.Rectangle(918, 163, 362, 574)
        Me.GridViewOrdersStatusHistory.GridControl = Me.GridOrdersStatusHistory
        Me.GridViewOrdersStatusHistory.Name = "GridViewOrdersStatusHistory"
        Me.GridViewOrdersStatusHistory.OptionsBehavior.Editable = False
        Me.GridViewOrdersStatusHistory.OptionsView.ShowBands = False
        '
        'GridBand9
        '
        Me.GridBand9.Caption = "GridBand5"
        Me.GridBand9.Columns.Add(Me.colorders_status_history_id)
        Me.GridBand9.Columns.Add(Me.colorders_id1)
        Me.GridBand9.Columns.Add(Me.colnew_value)
        Me.GridBand9.Columns.Add(Me.colold_value)
        Me.GridBand9.Columns.Add(Me.coldate_added)
        Me.GridBand9.Columns.Add(Me.colcustomers_notified)
        Me.GridBand9.Name = "GridBand9"
        Me.GridBand9.Width = 450
        '
        'colorders_status_history_id
        '
        Me.colorders_status_history_id.Caption = "orders_status_history_id"
        Me.colorders_status_history_id.FieldName = "orders_status_history_id"
        Me.colorders_status_history_id.Name = "colorders_status_history_id"
        Me.colorders_status_history_id.Visible = True
        '
        'colorders_id1
        '
        Me.colorders_id1.Caption = "orders_id"
        Me.colorders_id1.FieldName = "orders_id"
        Me.colorders_id1.Name = "colorders_id1"
        Me.colorders_id1.Visible = True
        '
        'colnew_value
        '
        Me.colnew_value.Caption = "new_value"
        Me.colnew_value.ColumnEdit = Me.cmbOrdersStatus1
        Me.colnew_value.FieldName = "new_value"
        Me.colnew_value.Name = "colnew_value"
        Me.colnew_value.Visible = True
        '
        'cmbOrdersStatus1
        '
        Me.cmbOrdersStatus1.AutoHeight = False
        Me.cmbOrdersStatus1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOrdersStatus1.DataSource = Me.objDS.orders_status
        Me.cmbOrdersStatus1.DisplayMember = "orders_status_name"
        Me.cmbOrdersStatus1.Name = "cmbOrdersStatus1"
        Me.cmbOrdersStatus1.ValueMember = "orders_status_id"
        '
        'colold_value
        '
        Me.colold_value.Caption = "old_value"
        Me.colold_value.ColumnEdit = Me.cmbOrdersStatus1
        Me.colold_value.FieldName = "old_value"
        Me.colold_value.Name = "colold_value"
        Me.colold_value.Visible = True
        '
        'coldate_added
        '
        Me.coldate_added.Caption = "date_added"
        Me.coldate_added.FieldName = "date_added"
        Me.coldate_added.Name = "coldate_added"
        Me.coldate_added.Visible = True
        '
        'colcustomers_notified
        '
        Me.colcustomers_notified.Caption = "customers_notified"
        Me.colcustomers_notified.FieldName = "customers_notified"
        Me.colcustomers_notified.Name = "colcustomers_notified"
        Me.colcustomers_notified.Visible = True
        '
        'SplitterControl5
        '
        Me.SplitterControl5.Appearance.BackColor = System.Drawing.SystemColors.Desktop
        Me.SplitterControl5.Appearance.Options.UseBackColor = True
        Me.SplitterControl5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitterControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl5.Location = New System.Drawing.Point(2, 368)
        Me.SplitterControl5.Name = "SplitterControl5"
        Me.SplitterControl5.Size = New System.Drawing.Size(377, 6)
        Me.SplitterControl5.TabIndex = 3
        Me.SplitterControl5.TabStop = False
        '
        'GroupControl5
        '
        Me.GroupControl5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl5.Controls.Add(Me.GridOrders_History)
        Me.GroupControl5.Controls.Add(Me.chkLoadAllOrders)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl5.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(377, 366)
        Me.GroupControl5.TabIndex = 2
        Me.GroupControl5.Text = "Orders History"
        '
        'GridOrders_History
        '
        Me.GridOrders_History.DataSource = Me.objDS.orders_products_view1
        Me.GridOrders_History.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOrders_History.EmbeddedNavigator.Name = ""
        Me.GridOrders_History.FormsUseDefaultLookAndFeel = False
        Me.GridOrders_History.Location = New System.Drawing.Point(2, 20)
        Me.GridOrders_History.MainView = Me.GridVIewOrders_History
        Me.GridOrders_History.Name = "GridOrders_History"
        Me.GridOrders_History.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbOrders_Products_Status})
        Me.GridOrders_History.Size = New System.Drawing.Size(373, 344)
        Me.GridOrders_History.TabIndex = 1
        Me.GridOrders_History.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridVIewOrders_History})
        '
        'GridVIewOrders_History
        '
        Me.GridVIewOrders_History.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand6})
        Me.GridVIewOrders_History.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colorders_id, Me.colcustomers_id, Me.colproducts_id7, Me.coldvd_id, Me.coldelivery_country, Me.colpick_group, Me.colpick_boxid, Me.coldate_purchased, Me.coldelivery_name, Me.colcustomers_email_address, Me.colorders_products_status, Me.colorders_status_name})
        Me.GridVIewOrders_History.CustomizationFormBounds = New System.Drawing.Rectangle(918, 163, 362, 574)
        Me.GridVIewOrders_History.GridControl = Me.GridOrders_History
        Me.GridVIewOrders_History.Name = "GridVIewOrders_History"
        Me.GridVIewOrders_History.OptionsBehavior.Editable = False
        Me.GridVIewOrders_History.OptionsView.ShowBands = False
        '
        'GridBand6
        '
        Me.GridBand6.Caption = "GridBand5"
        Me.GridBand6.Columns.Add(Me.colorders_id)
        Me.GridBand6.Columns.Add(Me.coldvd_id)
        Me.GridBand6.Columns.Add(Me.colcustomers_id)
        Me.GridBand6.Columns.Add(Me.coldelivery_name)
        Me.GridBand6.Columns.Add(Me.colproducts_id7)
        Me.GridBand6.Columns.Add(Me.coldelivery_country)
        Me.GridBand6.Columns.Add(Me.colpick_group)
        Me.GridBand6.Columns.Add(Me.colpick_boxid)
        Me.GridBand6.Columns.Add(Me.coldate_purchased)
        Me.GridBand6.Columns.Add(Me.colorders_status_name)
        Me.GridBand6.Columns.Add(Me.colcustomers_email_address)
        Me.GridBand6.MinWidth = 20
        Me.GridBand6.Name = "GridBand6"
        Me.GridBand6.Width = 462
        '
        'colorders_id
        '
        Me.colorders_id.Caption = "orders_id"
        Me.colorders_id.FieldName = "orders_id"
        Me.colorders_id.Name = "colorders_id"
        Me.colorders_id.Visible = True
        '
        'coldvd_id
        '
        Me.coldvd_id.Caption = "dvd_id"
        Me.coldvd_id.FieldName = "dvd_id"
        Me.coldvd_id.Name = "coldvd_id"
        Me.coldvd_id.Visible = True
        Me.coldvd_id.Width = 54
        '
        'colcustomers_id
        '
        Me.colcustomers_id.Caption = "customers_id"
        Me.colcustomers_id.FieldName = "customers_id"
        Me.colcustomers_id.Name = "colcustomers_id"
        Me.colcustomers_id.Visible = True
        Me.colcustomers_id.Width = 61
        '
        'coldelivery_name
        '
        Me.coldelivery_name.Caption = "delivery_name"
        Me.coldelivery_name.FieldName = "delivery_name"
        Me.coldelivery_name.Name = "coldelivery_name"
        Me.coldelivery_name.Visible = True
        Me.coldelivery_name.Width = 122
        '
        'colproducts_id7
        '
        Me.colproducts_id7.Caption = "products_id"
        Me.colproducts_id7.FieldName = "products_id"
        Me.colproducts_id7.Name = "colproducts_id7"
        '
        'coldelivery_country
        '
        Me.coldelivery_country.Caption = "delivery_country"
        Me.coldelivery_country.FieldName = "delivery_country"
        Me.coldelivery_country.Name = "coldelivery_country"
        '
        'colpick_group
        '
        Me.colpick_group.Caption = "pick_group"
        Me.colpick_group.FieldName = "pick_group"
        Me.colpick_group.Name = "colpick_group"
        '
        'colpick_boxid
        '
        Me.colpick_boxid.Caption = "pick_boxid"
        Me.colpick_boxid.FieldName = "pick_boxid"
        Me.colpick_boxid.Name = "colpick_boxid"
        '
        'coldate_purchased
        '
        Me.coldate_purchased.Caption = "date_purchased"
        Me.coldate_purchased.FieldName = "date_purchased"
        Me.coldate_purchased.Name = "coldate_purchased"
        Me.coldate_purchased.Visible = True
        '
        'colorders_status_name
        '
        Me.colorders_status_name.Caption = "orders_status"
        Me.colorders_status_name.FieldName = "orders_status_name"
        Me.colorders_status_name.Name = "colorders_status_name"
        Me.colorders_status_name.OptionsColumn.AllowEdit = False
        Me.colorders_status_name.OptionsColumn.ReadOnly = True
        Me.colorders_status_name.Visible = True
        '
        'colcustomers_email_address
        '
        Me.colcustomers_email_address.Caption = "customers_email_address"
        Me.colcustomers_email_address.FieldName = "customers_email_address"
        Me.colcustomers_email_address.Name = "colcustomers_email_address"
        '
        'colorders_products_status
        '
        Me.colorders_products_status.Caption = "orders_products_status"
        Me.colorders_products_status.ColumnEdit = Me.cmbOrders_Products_Status
        Me.colorders_products_status.FieldName = "orders_products_status"
        Me.colorders_products_status.Name = "colorders_products_status"
        '
        'cmbOrders_Products_Status
        '
        Me.cmbOrders_Products_Status.AutoHeight = False
        Me.cmbOrders_Products_Status.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOrders_Products_Status.DataSource = Me.objDS.orders_products_status
        Me.cmbOrders_Products_Status.DisplayMember = "orders_products_status_name"
        Me.cmbOrders_Products_Status.Name = "cmbOrders_Products_Status"
        Me.cmbOrders_Products_Status.ValueMember = "orders_products_status_id"
        '
        'chkLoadAllOrders
        '
        Me.chkLoadAllOrders.Location = New System.Drawing.Point(336, 0)
        Me.chkLoadAllOrders.Name = "chkLoadAllOrders"
        Me.chkLoadAllOrders.Properties.Caption = "Show All Orders"
        Me.chkLoadAllOrders.Size = New System.Drawing.Size(96, 19)
        Me.chkLoadAllOrders.TabIndex = 0
        '
        'SplitterControl6
        '
        Me.SplitterControl6.Appearance.BackColor = System.Drawing.SystemColors.Desktop
        Me.SplitterControl6.Appearance.Options.UseBackColor = True
        Me.SplitterControl6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitterControl6.Location = New System.Drawing.Point(256, 2)
        Me.SplitterControl6.Name = "SplitterControl6"
        Me.SplitterControl6.Size = New System.Drawing.Size(6, 581)
        Me.SplitterControl6.TabIndex = 1
        Me.SplitterControl6.TabStop = False
        '
        'GroupControl4
        '
        Me.GroupControl4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl4.Controls.Add(Me.GridDVDStatusHistory)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl4.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(254, 581)
        Me.GroupControl4.TabIndex = 0
        Me.GroupControl4.Text = "DVD Status History"
        '
        'GridDVDStatusHistory
        '
        Me.GridDVDStatusHistory.DataSource = Me.objDS.products_dvd_status_history
        Me.GridDVDStatusHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDVDStatusHistory.EmbeddedNavigator.Name = ""
        Me.GridDVDStatusHistory.FormsUseDefaultLookAndFeel = False
        Me.GridDVDStatusHistory.Location = New System.Drawing.Point(2, 20)
        Me.GridDVDStatusHistory.MainView = Me.AdvBandedGridView1
        Me.GridDVDStatusHistory.Name = "GridDVDStatusHistory"
        Me.GridDVDStatusHistory.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbProductsDVDStatus})
        Me.GridDVDStatusHistory.Size = New System.Drawing.Size(250, 559)
        Me.GridDVDStatusHistory.TabIndex = 2
        Me.GridDVDStatusHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGridView1})
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand10})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colstatus_history_id, Me.colstatus_date, Me.colprevious_status_id, Me.colstatus_id, Me.coluser_id, Me.colcomment})
        Me.AdvBandedGridView1.CustomizationFormBounds = New System.Drawing.Rectangle(918, 148, 362, 574)
        Me.AdvBandedGridView1.GridControl = Me.GridDVDStatusHistory
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsBehavior.Editable = False
        Me.AdvBandedGridView1.OptionsView.ShowBands = False
        '
        'GridBand10
        '
        Me.GridBand10.Caption = "GridBand5"
        Me.GridBand10.Columns.Add(Me.colstatus_history_id)
        Me.GridBand10.Columns.Add(Me.colstatus_date)
        Me.GridBand10.Columns.Add(Me.colprevious_status_id)
        Me.GridBand10.Columns.Add(Me.colstatus_id)
        Me.GridBand10.Columns.Add(Me.coluser_id)
        Me.GridBand10.Columns.Add(Me.colcomment)
        Me.GridBand10.Name = "GridBand10"
        Me.GridBand10.Width = 267
        '
        'colstatus_history_id
        '
        Me.colstatus_history_id.Caption = "status_history_id"
        Me.colstatus_history_id.FieldName = "status_history_id"
        Me.colstatus_history_id.Name = "colstatus_history_id"
        '
        'colstatus_date
        '
        Me.colstatus_date.Caption = "status_date"
        Me.colstatus_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.colstatus_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colstatus_date.FieldName = "status_date"
        Me.colstatus_date.Name = "colstatus_date"
        Me.colstatus_date.Visible = True
        Me.colstatus_date.Width = 117
        '
        'colprevious_status_id
        '
        Me.colprevious_status_id.Caption = "previous_status_id"
        Me.colprevious_status_id.ColumnEdit = Me.cmbProductsDVDStatus
        Me.colprevious_status_id.FieldName = "previous_status_id"
        Me.colprevious_status_id.Name = "colprevious_status_id"
        Me.colprevious_status_id.Visible = True
        '
        'cmbProductsDVDStatus
        '
        Me.cmbProductsDVDStatus.AutoHeight = False
        Me.cmbProductsDVDStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProductsDVDStatus.DataSource = Me.objDS.products_dvd_status
        Me.cmbProductsDVDStatus.DisplayMember = "products_dvd_status_name"
        Me.cmbProductsDVDStatus.Name = "cmbProductsDVDStatus"
        Me.cmbProductsDVDStatus.ValueMember = "products_dvd_status_id"
        '
        'colstatus_id
        '
        Me.colstatus_id.Caption = "status_id"
        Me.colstatus_id.ColumnEdit = Me.cmbProductsDVDStatus
        Me.colstatus_id.FieldName = "status_id"
        Me.colstatus_id.Name = "colstatus_id"
        Me.colstatus_id.Visible = True
        '
        'coluser_id
        '
        Me.coluser_id.Caption = "user_id"
        Me.coluser_id.FieldName = "user_id"
        Me.coluser_id.Name = "coluser_id"
        '
        'colcomment
        '
        Me.colcomment.Caption = "comment"
        Me.colcomment.FieldName = "comment"
        Me.colcomment.Name = "colcomment"
        '
        'SplitterControl4
        '
        Me.SplitterControl4.Appearance.BackColor = System.Drawing.SystemColors.Desktop
        Me.SplitterControl4.Appearance.Options.UseBackColor = True
        Me.SplitterControl4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitterControl4.Location = New System.Drawing.Point(392, 40)
        Me.SplitterControl4.Name = "SplitterControl4"
        Me.SplitterControl4.Size = New System.Drawing.Size(6, 589)
        Me.SplitterControl4.TabIndex = 2
        Me.SplitterControl4.TabStop = False
        '
        'GroupControl1
        '
        Me.GroupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl1.Controls.Add(Me.GridProducts_DVD)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(0, 40)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(392, 589)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "DVDs"
        '
        'GridProducts_DVD
        '
        Me.GridProducts_DVD.DataSource = Me.objDS.products_dvd
        Me.GridProducts_DVD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridProducts_DVD.EmbeddedNavigator.Name = ""
        Me.GridProducts_DVD.FormsUseDefaultLookAndFeel = False
        Me.GridProducts_DVD.Location = New System.Drawing.Point(2, 20)
        Me.GridProducts_DVD.MainView = Me.GridViewProducts_DVD
        Me.GridProducts_DVD.Name = "GridProducts_DVD"
        Me.GridProducts_DVD.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbProducts_DVD_Status})
        Me.GridProducts_DVD.Size = New System.Drawing.Size(388, 567)
        Me.GridProducts_DVD.TabIndex = 0
        Me.GridProducts_DVD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewProducts_DVD})
        '
        'GridViewProducts_DVD
        '
        Me.GridViewProducts_DVD.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand5})
        Me.GridViewProducts_DVD.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colproducts_id6, Me.colproducts_dvdid, Me.colproducts_dvd_status, Me.colbox_id, Me.colpibox_id, Me.colcover_boxid, Me.colstock_type, Me.colinout, Me.colEntityID, Me.coldvd_buy_date})
        Me.GridViewProducts_DVD.CustomizationFormBounds = New System.Drawing.Rectangle(147, 336, 217, 222)
        Me.GridViewProducts_DVD.GridControl = Me.GridProducts_DVD
        Me.GridViewProducts_DVD.Name = "GridViewProducts_DVD"
        Me.GridViewProducts_DVD.OptionsBehavior.Editable = False
        Me.GridViewProducts_DVD.OptionsView.ShowBands = False
        '
        'GridBand5
        '
        Me.GridBand5.Caption = "GridBand5"
        Me.GridBand5.Columns.Add(Me.colproducts_id6)
        Me.GridBand5.Columns.Add(Me.colproducts_dvdid)
        Me.GridBand5.Columns.Add(Me.colproducts_dvd_status)
        Me.GridBand5.Columns.Add(Me.colbox_id)
        Me.GridBand5.Columns.Add(Me.colpibox_id)
        Me.GridBand5.Columns.Add(Me.colinout)
        Me.GridBand5.Columns.Add(Me.colcover_boxid)
        Me.GridBand5.Columns.Add(Me.colstock_type)
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.Width = 410
        '
        'colproducts_id6
        '
        Me.colproducts_id6.Caption = "products_id"
        Me.colproducts_id6.FieldName = "products_id"
        Me.colproducts_id6.Name = "colproducts_id6"
        '
        'colproducts_dvdid
        '
        Me.colproducts_dvdid.Caption = "products_dvdid"
        Me.colproducts_dvdid.FieldName = "products_dvdid"
        Me.colproducts_dvdid.Name = "colproducts_dvdid"
        Me.colproducts_dvdid.Visible = True
        Me.colproducts_dvdid.Width = 102
        '
        'colproducts_dvd_status
        '
        Me.colproducts_dvd_status.Caption = "products_dvd_status"
        Me.colproducts_dvd_status.ColumnEdit = Me.cmbProducts_DVD_Status
        Me.colproducts_dvd_status.FieldName = "products_dvd_status"
        Me.colproducts_dvd_status.Name = "colproducts_dvd_status"
        Me.colproducts_dvd_status.Visible = True
        Me.colproducts_dvd_status.Width = 83
        '
        'cmbProducts_DVD_Status
        '
        Me.cmbProducts_DVD_Status.AutoHeight = False
        Me.cmbProducts_DVD_Status.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProducts_DVD_Status.DataSource = Me.objDS.products_dvd_status
        Me.cmbProducts_DVD_Status.DisplayMember = "products_dvd_status_name"
        Me.cmbProducts_DVD_Status.Name = "cmbProducts_DVD_Status"
        Me.cmbProducts_DVD_Status.NullText = ""
        Me.cmbProducts_DVD_Status.ValueMember = "products_dvd_status_id"
        '
        'colbox_id
        '
        Me.colbox_id.Caption = "box_id"
        Me.colbox_id.FieldName = "box_id"
        Me.colbox_id.Name = "colbox_id"
        Me.colbox_id.Visible = True
        '
        'colpibox_id
        '
        Me.colpibox_id.Caption = "pibox_id"
        Me.colpibox_id.FieldName = "pibox_id"
        Me.colpibox_id.Name = "colpibox_id"
        Me.colpibox_id.Visible = True
        '
        'colinout
        '
        Me.colinout.Caption = "inout"
        Me.colinout.FieldName = "inout"
        Me.colinout.Name = "colinout"
        Me.colinout.Visible = True
        '
        'colcover_boxid
        '
        Me.colcover_boxid.Caption = "cover_boxid"
        Me.colcover_boxid.FieldName = "cover_boxid"
        Me.colcover_boxid.Name = "colcover_boxid"
        '
        'colstock_type
        '
        Me.colstock_type.Caption = "stock_type"
        Me.colstock_type.FieldName = "stock_type"
        Me.colstock_type.Name = "colstock_type"
        '
        'colEntityID
        '
        Me.colEntityID.Caption = "EntityID"
        Me.colEntityID.FieldName = "EntityID"
        Me.colEntityID.Name = "colEntityID"
        Me.colEntityID.Visible = True
        '
        'coldvd_buy_date
        '
        Me.coldvd_buy_date.Caption = "dvd_buy_date"
        Me.coldvd_buy_date.FieldName = "dvd_buy_date"
        Me.coldvd_buy_date.Name = "coldvd_buy_date"
        Me.coldvd_buy_date.Visible = True
        '
        'PanelControl13
        '
        Me.PanelControl13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl13.Controls.Add(Me.ButDelPrDvdId)
        Me.PanelControl13.Controls.Add(Me.txtNbrOfDVDToAdd)
        Me.PanelControl13.Controls.Add(Me.btnAddNewDVDs)
        Me.PanelControl13.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl13.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl13.Name = "PanelControl13"
        Me.PanelControl13.Size = New System.Drawing.Size(1047, 40)
        Me.PanelControl13.TabIndex = 0
        '
        'ButDelPrDvdId
        '
        Me.ButDelPrDvdId.Location = New System.Drawing.Point(213, 8)
        Me.ButDelPrDvdId.Name = "ButDelPrDvdId"
        Me.ButDelPrDvdId.Size = New System.Drawing.Size(75, 23)
        Me.ButDelPrDvdId.TabIndex = 3
        Me.ButDelPrDvdId.Text = "Delete "
        Me.ButDelPrDvdId.UseVisualStyleBackColor = True
        '
        'txtNbrOfDVDToAdd
        '
        Me.txtNbrOfDVDToAdd.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNbrOfDVDToAdd.Location = New System.Drawing.Point(104, 8)
        Me.txtNbrOfDVDToAdd.Name = "txtNbrOfDVDToAdd"
        Me.txtNbrOfDVDToAdd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtNbrOfDVDToAdd.Size = New System.Drawing.Size(100, 20)
        Me.txtNbrOfDVDToAdd.TabIndex = 2
        '
        'btnAddNewDVDs
        '
        Me.btnAddNewDVDs.Location = New System.Drawing.Point(8, 8)
        Me.btnAddNewDVDs.Name = "btnAddNewDVDs"
        Me.btnAddNewDVDs.Size = New System.Drawing.Size(88, 23)
        Me.btnAddNewDVDs.TabIndex = 1
        Me.btnAddNewDVDs.Text = "ADD New DVDs"
        '
        'tabGames
        '
        Me.tabGames.Controls.Add(Me.chkGameOnline)
        Me.tabGames.Controls.Add(Me.txtGame_ConfigMini)
        Me.tabGames.Controls.Add(Me.LabelControl55)
        Me.tabGames.Controls.Add(Me.txtGame_NbrOfPlayersOnline)
        Me.tabGames.Controls.Add(Me.LabelControl54)
        Me.tabGames.Controls.Add(Me.txtGame_NbrOfPlayers)
        Me.tabGames.Controls.Add(Me.LabelControl53)
        Me.tabGames.Name = "tabGames"
        Me.tabGames.Size = New System.Drawing.Size(1047, 629)
        Me.tabGames.Text = "Games"
        '
        'chkGameOnline
        '
        Me.chkGameOnline.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.game_online", True))
        Me.chkGameOnline.EditValue = 0
        Me.chkGameOnline.Enabled = False
        Me.chkGameOnline.Location = New System.Drawing.Point(36, 49)
        Me.chkGameOnline.Name = "chkGameOnline"
        Me.chkGameOnline.Properties.Caption = "Online"
        Me.chkGameOnline.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkGameOnline.Properties.ValueChecked = 1
        Me.chkGameOnline.Properties.ValueUnchecked = 0
        Me.chkGameOnline.Size = New System.Drawing.Size(133, 19)
        Me.chkGameOnline.TabIndex = 42
        '
        'txtGame_ConfigMini
        '
        Me.txtGame_ConfigMini.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.game_config_mini", True))
        Me.txtGame_ConfigMini.Enabled = False
        Me.txtGame_ConfigMini.Location = New System.Drawing.Point(153, 100)
        Me.txtGame_ConfigMini.Name = "txtGame_ConfigMini"
        Me.txtGame_ConfigMini.Size = New System.Drawing.Size(408, 80)
        Me.txtGame_ConfigMini.TabIndex = 13
        '
        'LabelControl55
        '
        Me.LabelControl55.Location = New System.Drawing.Point(41, 103)
        Me.LabelControl55.Name = "LabelControl55"
        Me.LabelControl55.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl55.TabIndex = 12
        Me.LabelControl55.Text = "Config Minimum"
        '
        'txtGame_NbrOfPlayersOnline
        '
        Me.txtGame_NbrOfPlayersOnline.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.game_nbr_of_players_online", True))
        Me.txtGame_NbrOfPlayersOnline.Enabled = False
        Me.txtGame_NbrOfPlayersOnline.Location = New System.Drawing.Point(153, 74)
        Me.txtGame_NbrOfPlayersOnline.Name = "txtGame_NbrOfPlayersOnline"
        Me.txtGame_NbrOfPlayersOnline.Size = New System.Drawing.Size(112, 20)
        Me.txtGame_NbrOfPlayersOnline.TabIndex = 11
        '
        'LabelControl54
        '
        Me.LabelControl54.Location = New System.Drawing.Point(41, 77)
        Me.LabelControl54.Name = "LabelControl54"
        Me.LabelControl54.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl54.TabIndex = 10
        Me.LabelControl54.Text = "Nbr Of Players Online"
        '
        'txtGame_NbrOfPlayers
        '
        Me.txtGame_NbrOfPlayers.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.game_nbr_of_players", True))
        Me.txtGame_NbrOfPlayers.Enabled = False
        Me.txtGame_NbrOfPlayers.Location = New System.Drawing.Point(153, 20)
        Me.txtGame_NbrOfPlayers.Name = "txtGame_NbrOfPlayers"
        Me.txtGame_NbrOfPlayers.Size = New System.Drawing.Size(112, 20)
        Me.txtGame_NbrOfPlayers.TabIndex = 9
        '
        'LabelControl53
        '
        Me.LabelControl53.Location = New System.Drawing.Point(41, 23)
        Me.LabelControl53.Name = "LabelControl53"
        Me.LabelControl53.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl53.TabIndex = 8
        Me.LabelControl53.Text = "Nbr of Players"
        '
        'tabTransfers
        '
        Me.tabTransfers.Controls.Add(Me.LabelControl50)
        Me.tabTransfers.Controls.Add(Me.btnTransferProductID)
        Me.tabTransfers.Controls.Add(Me.LabelControl46)
        Me.tabTransfers.Controls.Add(Me.txtWLToProcess)
        Me.tabTransfers.Controls.Add(Me.txtToProdID1)
        Me.tabTransfers.Controls.Add(Me.LabelControl47)
        Me.tabTransfers.Controls.Add(Me.txtFromProdID1)
        Me.tabTransfers.Controls.Add(Me.txtCustLang1)
        Me.tabTransfers.Controls.Add(Me.LabelControl49)
        Me.tabTransfers.Name = "tabTransfers"
        Me.tabTransfers.Size = New System.Drawing.Size(1047, 629)
        Me.tabTransfers.Text = "WishListTransfers"
        '
        'LabelControl50
        '
        Me.LabelControl50.Location = New System.Drawing.Point(32, 24)
        Me.LabelControl50.Name = "LabelControl50"
        Me.LabelControl50.Size = New System.Drawing.Size(244, 13)
        Me.LabelControl50.TabIndex = 39
        Me.LabelControl50.Text = "Transfer Wishlist of customers with language (ID) :"
        '
        'btnTransferProductID
        '
        Me.btnTransferProductID.Location = New System.Drawing.Point(64, 64)
        Me.btnTransferProductID.Name = "btnTransferProductID"
        Me.btnTransferProductID.Size = New System.Drawing.Size(104, 23)
        Me.btnTransferProductID.TabIndex = 38
        Me.btnTransferProductID.Text = "GO"
        '
        'LabelControl46
        '
        Me.LabelControl46.Location = New System.Drawing.Point(184, 72)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl46.TabIndex = 37
        Me.LabelControl46.Text = "WL To Process"
        '
        'txtWLToProcess
        '
        Me.txtWLToProcess.EditValue = "0"
        Me.txtWLToProcess.Location = New System.Drawing.Point(288, 64)
        Me.txtWLToProcess.Name = "txtWLToProcess"
        Me.txtWLToProcess.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtWLToProcess.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtWLToProcess.Size = New System.Drawing.Size(100, 20)
        Me.txtWLToProcess.TabIndex = 36
        '
        'txtToProdID1
        '
        Me.txtToProdID1.Location = New System.Drawing.Point(672, 24)
        Me.txtToProdID1.Name = "txtToProdID1"
        Me.txtToProdID1.Size = New System.Drawing.Size(100, 20)
        Me.txtToProdID1.TabIndex = 35
        '
        'LabelControl47
        '
        Me.LabelControl47.Location = New System.Drawing.Point(592, 24)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl47.TabIndex = 34
        Me.LabelControl47.Text = "To Product ID"
        '
        'txtFromProdID1
        '
        Me.txtFromProdID1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_id", True))
        Me.txtFromProdID1.Enabled = False
        Me.txtFromProdID1.Location = New System.Drawing.Point(488, 24)
        Me.txtFromProdID1.Name = "txtFromProdID1"
        Me.txtFromProdID1.Size = New System.Drawing.Size(100, 20)
        Me.txtFromProdID1.TabIndex = 33
        '
        'txtCustLang1
        '
        Me.txtCustLang1.Location = New System.Drawing.Point(288, 24)
        Me.txtCustLang1.Name = "txtCustLang1"
        Me.txtCustLang1.Size = New System.Drawing.Size(100, 20)
        Me.txtCustLang1.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.txtCustLang1, "1=French, 2=Neederlands, 3=English")
        '
        'LabelControl49
        '
        Me.LabelControl49.Location = New System.Drawing.Point(392, 24)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl49.TabIndex = 30
        Me.LabelControl49.Text = "From products ID :"
        '
        'tabPrevision
        '
        Me.tabPrevision.Controls.Add(Me.GridPrevision)
        Me.tabPrevision.Name = "tabPrevision"
        Me.tabPrevision.Size = New System.Drawing.Size(1047, 629)
        Me.tabPrevision.Text = "Prevision"
        '
        'GridPrevision
        '
        Me.GridPrevision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPrevision.EmbeddedNavigator.Name = ""
        Me.GridPrevision.FormsUseDefaultLookAndFeel = False
        Me.GridPrevision.Location = New System.Drawing.Point(0, 0)
        Me.GridPrevision.MainView = Me.GridViewPrevision
        Me.GridPrevision.Name = "GridPrevision"
        Me.GridPrevision.Size = New System.Drawing.Size(1047, 629)
        Me.GridPrevision.TabIndex = 0
        Me.GridPrevision.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPrevision})
        '
        'GridViewPrevision
        '
        Me.GridViewPrevision.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBandPrevision})
        Me.GridViewPrevision.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3})
        Me.GridViewPrevision.GridControl = Me.GridPrevision
        Me.GridViewPrevision.Name = "GridViewPrevision"
        Me.GridViewPrevision.OptionsView.ShowFooter = True
        '
        'GridBandPrevision
        '
        Me.GridBandPrevision.Name = "GridBandPrevision"
        '
        'tabWishlistCustomers
        '
        Me.tabWishlistCustomers.Controls.Add(Me.GridWishlistCustomers)
        Me.tabWishlistCustomers.Name = "tabWishlistCustomers"
        Me.tabWishlistCustomers.Size = New System.Drawing.Size(1047, 629)
        Me.tabWishlistCustomers.Text = "WishlistCustomers"
        '
        'GridWishlistCustomers
        '
        Me.GridWishlistCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridWishlistCustomers.EmbeddedNavigator.Name = ""
        Me.GridWishlistCustomers.FormsUseDefaultLookAndFeel = False
        Me.GridWishlistCustomers.Location = New System.Drawing.Point(0, 0)
        Me.GridWishlistCustomers.MainView = Me.gridViewWishlistCustomers
        Me.GridWishlistCustomers.Name = "GridWishlistCustomers"
        Me.GridWishlistCustomers.Size = New System.Drawing.Size(1047, 629)
        Me.GridWishlistCustomers.TabIndex = 1
        Me.GridWishlistCustomers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewWishlistCustomers})
        '
        'gridViewWishlistCustomers
        '
        Me.gridViewWishlistCustomers.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand11})
        Me.gridViewWishlistCustomers.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gridViewWishlistCustomers.GridControl = Me.GridWishlistCustomers
        Me.gridViewWishlistCustomers.Name = "gridViewWishlistCustomers"
        Me.gridViewWishlistCustomers.OptionsBehavior.Editable = False
        Me.gridViewWishlistCustomers.OptionsView.ShowFooter = True
        '
        'GridBand11
        '
        Me.GridBand11.Name = "GridBand11"
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
        Me.TextEdit1.Location = New System.Drawing.Point(96, 8)
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
        'frmDVD_Maint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1056, 778)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.PanelControl10)
        Me.Name = "frmDVD_Maint"
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.PanelControl10, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabSearch.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
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
        CType(Me.txtPictureImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSeries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSeries.ResumeLayout(False)
        Me.grpSeries.PerformLayout()
        CType(Me.txtABOSerieNbr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbABOSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieNbr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        CType(Me.cmbProducts_product_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIMDB_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInTheBagsNext.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInTheBags.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInCinemaNow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkProduct_Next.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtherProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGommetteNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGommetteFR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAvailability.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.txtQtyNow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.tabTheme.ResumeLayout(False)
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        CType(Me.TreeListThemes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkThemeSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl12.ResumeLayout(False)
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.TreeListCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelectCategory, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.grpSoundTracks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSoundTracks.ResumeLayout(False)
        CType(Me.GridSoundtracks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSoundTracks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSoundTracks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        CType(Me.grpTrailers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTrailers.ResumeLayout(False)
        CType(Me.GridTrailers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTrailers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLangTrailer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTrailers_Broadcast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFeeSharing.ResumeLayout(False)
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.GroupControl6.PerformLayout()
        CType(Me.chkOnly_for_sale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNew_Sale_Price.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNew_qty_to_sale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSale_price.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty_to_sale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaleDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaleDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        CType(Me.txtTiteNrMovieMax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFeeSharingStudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMovieMaxPartner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFeeSharing_TurnPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFeeSharing_UpfrontFee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFeeSharing_End.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFeeSharing_End.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDVDs.ResumeLayout(False)
        CType(Me.PanelControl14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl14.ResumeLayout(False)
        CType(Me.PanelControl15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl15.ResumeLayout(False)
        CType(Me.PanelControl16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl16.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridOrdersStatusHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewOrdersStatusHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOrdersStatus1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.GridOrders_History, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridVIewOrders_History, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOrders_Products_Status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLoadAllOrders.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GridDVDStatusHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductsDVDStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridProducts_DVD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewProducts_DVD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProducts_DVD_Status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl13.ResumeLayout(False)
        CType(Me.txtNbrOfDVDToAdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGames.ResumeLayout(False)
        Me.tabGames.PerformLayout()
        CType(Me.chkGameOnline.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGame_ConfigMini.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGame_NbrOfPlayersOnline.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGame_NbrOfPlayers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTransfers.ResumeLayout(False)
        Me.tabTransfers.PerformLayout()
        CType(Me.txtWLToProcess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToProdID1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromProdID1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustLang1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPrevision.ResumeLayout(False)
        CType(Me.GridPrevision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPrevision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWishlistCustomers.ResumeLayout(False)
        CType(Me.GridWishlistCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewWishlistCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl10.ResumeLayout(False)
        Me.PanelControl10.PerformLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sSQL As String
    Private _ctrlGridControl As DVDPostBuziness.ClsGridControl

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim KeyDataSet As String = "BizzLib.dsGeneral" 'The Dataset used 
    Dim CurrentProductID As Integer
    Dim CurrentDVDID As Integer = -1
    Dim CurrentOrderID As Integer = -1
    Dim MainData As clsProduct_DVD
    Dim sem As New Semaphore(0, 100)
    Dim boolLoadingDVDInfo As Boolean = False
    Dim boolLoadingOrder As Boolean = False
    Dim _refreshData_prevision As Boolean
    Dim _refreshData_wishlistCustomer As Boolean
    Dim _refreshData_FeeSharing As Boolean
    Dim _listFeeSharingStudio As New List(Of DVDPostBuziness.clsKeyCombo)
    Private Class ComboParam
        Public LTable As DataTable
        Public LSQLStr As String
        Public Sub New(ByVal vTable As DataTable, ByVal vSQLSTr As String)
            LTable = vTable
            LSQLStr = vSQLSTr
        End Sub
    End Class

    Dim mvarImagesServer As String = ""
    Public Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim menuStrip As New DVDPostBuziness.contextMenu()
        GridControl2.ContextMenuStrip = menuStrip
        GridActors.ContextMenuStrip = menuStrip
        GridLanguages.ContextMenuStrip = menuStrip
        GridUndertitles.ContextMenuStrip = menuStrip
        GridTrailers.ContextMenuStrip = menuStrip
        GridSoundtracks.ContextMenuStrip = menuStrip
        GridProducts_DVD.ContextMenuStrip = menuStrip
        GridDVDStatusHistory.ContextMenuStrip = menuStrip
        GridOrders_History.ContextMenuStrip = menuStrip
        GridOrdersStatusHistory.ContextMenuStrip = menuStrip
        GridPrevision.ContextMenuStrip = menuStrip
        GridWishlistCustomers.ContextMenuStrip = menuStrip

        Try

            'SetUp of Variables
            KeyFieldName = "products_id"
            IDField = "products_id"
            TableName = "products"
            MainDataSet = objDS
            '  MyBase.RaiseEventForReportDesigner = True
            'HelpProvider1.HelpNamespace = ".\Help\" & SessionInfo.UserLang & "\BizzKeys.chm"
            'Attempt to load the dataset.
            mvarImagesServer = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global' and Name = 'ImagesServer'")
            Me.LoadBKComboSet()
            ' DvdPostData.clsConnection.ExecuteNonQuery("update products_dvd set last_admindate = Null where last_admindate = '0000-00-00 00:00:00'")
            BKGlobal.LoadAssociatedMenu(Me.Tag, PopMenuAssociatedTasks, Me)
            btnNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            DefaultSet_Bar.Visible = False
            Filter_Bar.Visible = False
            Misc_Bar2.Visible = False
            'If OpenType = "NEW" Then
            '    'NewRecord(sender, e)
            'End If
            'If OpenType = "EDIT" Then
            '    If KeyValue <> "" Then 'Not IsNothing(_Row) Then
            '        Dim _View As New DataView(Me.objDS.Tables(TableName), "", IDField, DataViewRowState.CurrentRows)
            '        Dim _Name As String = _View(_View.Find(New Object() {KeyValue}))(KeyFieldName)
            '        'Now Finding the record by the name, because this is the one used in the ORDER BY in the LoadDataset
            '        Me.objDS.Tables(TableName).DefaultView.Sort = KeyFieldName
            '        Me.BindingContext(objDS, TableName).Position = Me.objDS.Tables(TableName).DefaultView.Find(New Object() {_Name})
            '        'EditRecord(sender, e)
            '    Else
            '        OpenType = "BROWSE"
            '        Exit Sub
            '    End If
            'End If
            XtraTabControl1.SelectedTabPage = tabSearch

            ' recupe variable products_id  provenant du frmCustomer_maint GridViewOrders par la DVDPostBuziness.clsSingleton
            Dim params As DVDPostBuziness.clsSingleton = Nothing
            params = DVDPostBuziness.clsSingleton.Instance()
            Dim Dvd_Pr_ID As Integer = params.Products_dvd_id

            If Dvd_Pr_ID <> Nothing Then
                txtQuickSearch.EditValue = Dvd_Pr_ID
                If IsNumeric(txtQuickSearch.EditValue) Then
                    CurrentProductID = txtQuickSearch.EditValue
                    LoadProductsInfo()
                    If XtraTabControl1.SelectedTabPage.Name = tabSearch.Name Then
                        XtraTabControl1.SelectedTabPage = tabMain
                    End If
                End If
            End If




        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, eLoad)
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
    End Sub
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
            'Me.BindingContext(objDS, TableName).AddNew()
            MainData = New clsProduct_DVD(SessionInfo, objDS, 0, 0)
            CurrentProductID = MainData.AddNewProduct()
            txtQuickSearch.EditValue = CurrentProductID
            LoadProductsInfo()
            EditRecord(Sender, e)
        Catch eEndEdit As System.Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, eEndEdit)
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
        'PositionChanged(Sender, e)
        LoadProductsInfo()
        OpenType = "BROWSE"
    End Sub
    Private Sub SaveChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuSave.Click, MyBase.EventSaveChanges

        Try
            'Validate Fields and assign any Necessary ID
            MainData.ValidateRecordFields(CType(Me.BindingContext(objDS, TableName).Current, DataRowView))
            'Attempt to update the datasource.
            Me.UpdateDataSet()
            SetState(BrowseState)
            PopMenuNew.Enabled = True
            PopMenuEdit.Enabled = True
            PopMenuSave.Enabled = False
            PopMenuDelete.Enabled = True
            PopMenuUndo.Enabled = False
            EnablingAll(False)
            OpenType = "BROWSE"
        Catch eUpdate As System.Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, eUpdate)
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        Finally
        End Try
        'PositionChanged(Sender, e)
    End Sub
    Public Sub UpdateDataSet() Handles MyBase.EventUpdateDataset
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
        GridViewSoundTracks.CloseEditor()
        GridViewSoundTracks.UpdateCurrentRow()
        Me.BindingContext(objDS, "products_to_soundtracks").EndCurrentEdit()
        GridViewTrailers.CloseEditor()
        GridViewTrailers.UpdateCurrentRow()
        Me.BindingContext(objDS, "products_trailers").EndCurrentEdit()
        Me.BindingContext(objDS, "products_description_fr").EndCurrentEdit()
        Me.BindingContext(objDS, "products_description_nl").EndCurrentEdit()
        Me.BindingContext(objDS, "products_description_en").EndCurrentEdit()
        'Saving Category Tree
        Dim _node As DevExpress.XtraTreeList.Nodes.TreeListNode
        For Each _node In TreeListCategories.Nodes
            SaveCategoryNode(_node)
        Next
        For Each _node In TreeListThemes.Nodes
            SaveThemeNode(_node)
        Next
        'Changing GommetteInfo
        UpdateGommetteInfo()
        MainData.SaveAll()
        'MainData.Save()

        If XtraTabControl1.SelectedTabPage Is tabFeeSharing Then
            SaveMoviemax()
        End If

    End Sub
    Public Sub LoadBKComboSet()
        Try
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("languages"), "SELECT * FROM languages"))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("directors"), "SELECT * FROM directors"))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("actors"), "SELECT * FROM actors order by actors_name "))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("series"), "SELECT * FROM series"))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("view_products_status"), "SELECT codevalue as status_id, codedesc as status_desc from generalglobalcode where CodeType = 'Products_Status'"))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("view_products_type"), "SELECT codevalue as type_id, codedesc as type_desc from generalglobalcode where CodeType = 'Products_Type'"))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("product_type"), "SELECT CodeValue , CodeDesc from generalglobalcode where CodeType = 'product_type'"))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("view_products_media"), "SELECT codevalue as media_id, codedesc as media_desc from generalglobalcode where CodeType = 'Products_Media'"))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("view_products_availability"), "SELECT codevalue as availability_id, codedesc as availability_desc from generalglobalcode where CodeType = 'Products_Availability'"))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("view_products_rating"), "SELECT codevalue as rating_id, codedesc as rating_desc from generalglobalcode where CodeType = 'Products_Rating'"))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("products_countries"), "SELECT * FROM products_countries"))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("studio"), "SELECT * FROM studio"))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("public1"), "SELECT * FROM public where language_id = 1 order by public_id "))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("picture_format"), "SELECT * FROM picture_format where language_id = 1 order by picture_format_id "))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("products_languages"), "SELECT * FROM products_languages where languagenav_id = 1 "))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("products_undertitles"), "SELECT * FROM products_undertitles  where language_id = 1 "))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("products_soundtracks"), "SELECT * FROM products_soundtracks  where language_id = 1 "))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("products_dvd_status"), "SELECT * FROM products_dvd_status "))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("orders_products_status"), "SELECT * FROM orders_products_status  where language_id = 1 "))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("orders_status"), "SELECT * FROM orders_status  where language_id = 1 "))
            'System.Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf LoadOneCombo), New ComboParam(objDS.Tables("trailers_broadcast"), "SELECT codevalue as broadcast from generalglobalcode where CodeType = 'trailers_broadcast'"))

            DvdPostData.clsConnection.FillDataSet(objDS.Tables("languages"), "SELECT * FROM languages")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("directors"), "SELECT * FROM directors")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("actors"), "SELECT * FROM actors order by actors_name ")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("series"), "SELECT * FROM series")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("view_products_status"), "SELECT codevalue as status_id, codedesc as status_desc from generalglobalcode where CodeType = 'Products_Status'")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("view_products_type"), "SELECT codevalue as type_id, codedesc as type_desc from generalglobalcode where CodeType = 'Products_Type'")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("product_type"), "SELECT CodeValue , CodeDesc from generalglobalcode where CodeType = 'product_type'")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("view_products_media"), "SELECT codevalue as media_id, codedesc as media_desc from generalglobalcode where CodeType = 'Products_Media'")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("view_products_availability"), "SELECT codevalue as availability_id, codedesc as availability_desc from generalglobalcode where CodeType = 'Products_Availability'")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("view_products_rating"), "SELECT codevalue as rating_id, codedesc as rating_desc from generalglobalcode where CodeType = 'Products_Rating'")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_countries"), "SELECT * FROM products_countries")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("studio"), "SELECT * FROM studio")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("public1"), "SELECT * FROM public where language_id = 1 order by public_id ")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("picture_format"), "SELECT * FROM picture_format where language_id = 1 order by picture_format_id ")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("series"), "SELECT * FROM series")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_languages"), "SELECT * FROM products_languages where languagenav_id = 1 ")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_undertitles"), "SELECT * FROM products_undertitles  where language_id = 1 ")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_soundtracks"), "SELECT * FROM products_soundtracks  where language_id = 1 ")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_dvd_status"), "SELECT * FROM products_dvd_status ")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("orders_products_status"), "SELECT * FROM orders_products_status  where language_id = 1 ")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("orders_status"), "SELECT * FROM orders_status  where language_id = 1 ")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("trailers_broadcast"), "SELECT codevalue as broadcast from generalglobalcode where CodeType = 'trailers_broadcast'")
        Catch ex As Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, ex)
            Throw ex
        End Try
    End Sub
    Public Sub LoadOneCombo(ByVal stateInfo As Object)
        Dim _ComboParam As ComboParam = CType(stateInfo, ComboParam)
        DvdPostData.clsConnection.FillDataSet(_ComboParam.LTable, _ComboParam.LSQLStr)
    End Sub
    Public Sub UpdateGommetteInfo()
        Dim _row As DataRowView
        Dim _intFR As Integer = 0
        Dim _intNL As Integer = 0
        Dim _view As DataView
        _view = New DataView(objDS.Tables("products_to_languages"), "", "", DataViewRowState.CurrentRows)
        For Each _row In _view
            If _row("products_languages_id") = 1 Then _intFR += 1
            If _row("products_languages_id") = 2 Then _intNL += 1
        Next
        _view = New DataView(objDS.Tables("products_to_undertitles"), "", "", DataViewRowState.CurrentRows)
        For Each _row In _view
            If _row("products_undertitles_id") = 1 Then _intFR += 1
            If _row("products_undertitles_id") = 2 Then _intNL += 1
        Next
        If _intFR > 0 Then
            objDS.Tables("products").Rows(0)("products_language_fr") = 1
        Else
            objDS.Tables("products").Rows(0)("products_language_fr") = 0
        End If

        If _intNL > 0 Then
            objDS.Tables("products").Rows(0)("products_undertitle_nl") = 1
        Else
            objDS.Tables("products").Rows(0)("products_undertitle_nl") = 0
        End If
    End Sub
    Public Sub LoadProductsInfo()
        boolLoadingDVDInfo = True
        objDS.Tables("products").Clear()
        MainData = New clsProduct_DVD(SessionInfo, objDS, CurrentProductID, 0)
        objDS.Tables("orders_status_history").Clear()
        objDS.Tables("orders_products_view1").Clear()
        If txtQuickSearch.EditValue <> CurrentProductID Then
            txtQuickSearch.EditValue = CurrentProductID
        End If
        'Dim _T(11) As Thread
        'Dim i As Integer = 0
        '_T(0) = New Thread(AddressOf MainData.LoadActors)
        '_T(1) = New Thread(AddressOf MainData.LoadLanguages)
        '_T(2) = New Thread(AddressOf MainData.LoadUndertitles)
        '_T(3) = New Thread(AddressOf MainData.LoadTrailers)
        '_T(4) = New Thread(AddressOf MainData.LoadSoundtracks)
        '_T(5) = New Thread(AddressOf MainData.LoadCategories)
        '_T(6) = New Thread(AddressOf MainData.LoadThemes)
        '_T(7) = New Thread(AddressOf MainData.LoadDescriptionFR)
        '_T(8) = New Thread(AddressOf MainData.LoadDescriptionNL)
        '_T(9) = New Thread(AddressOf MainData.LoadDescriptionEN)
        '_T(10) = New Thread(AddressOf MainData.Load_All_Products_DVD_Info)
        'For i = 0 To 10
        '    _T(i).Start()
        'Next
        MainData.LoadActors()
        MainData.LoadLanguages()
        MainData.LoadUndertitles()
        MainData.LoadTrailers()
        MainData.LoadSoundtracks()
        MainData.LoadCategories()
        MainData.LoadThemes()
        MainData.LoadDescriptionFR()
        MainData.LoadDescriptionNL()
        MainData.LoadDescriptionEN()
        MainData.Load_All_Products_DVD_Info()
        RefreshSmallPicture()
        RefreshPictureFR()
        RefreshPictureNL()
        RefreshPictureEN()
        RefreshCategoryTree()
        RefreshThemeTree()
        boolLoadingDVDInfo = False
        RefreshCategoryTree()
        _refreshData_prevision = True
        _refreshData_wishlistCustomer = True
        _refreshData_FeeSharing = True
        loadPrevision(CurrentProductID)
        loadWishlistCustomers(CurrentProductID)
        'loadFeeSharingStudio()

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
        cmbAvailability.Enabled = Enabling
        cmbRating.Enabled = Enabling
        cmbPictureFormat.Enabled = Enabling
        cmbPublic.Enabled = Enabling
        txtPictureImage.Enabled = Enabling
        txtOtherProductID.Enabled = Enabling
        txtIMDB_ID.Enabled = Enabling
        'PictProducts_Image.Enabled = Enabling
        cmbSerie.Enabled = Enabling
        txtSerieNbr.Enabled = Enabling
        cmbABOSerie.Enabled = Enabling
        txtABOSerieNbr.Enabled = Enabling
        GridViewActors.OptionsBehavior.Editable = Enabling
        GridActors.EmbeddedNavigator.Enabled = Enabling
        GridViewLanguages.OptionsBehavior.Editable = Enabling
        GridLanguages.EmbeddedNavigator.Enabled = Enabling
        GridViewUndertitles.OptionsBehavior.Editable = Enabling
        GridUndertitles.EmbeddedNavigator.Enabled = Enabling
        GridViewTrailers.OptionsBehavior.Editable = Enabling
        GridTrailers.EmbeddedNavigator.Enabled = Enabling
        GridViewSoundTracks.OptionsBehavior.Editable = Enabling
        GridSoundtracks.EmbeddedNavigator.Enabled = Enabling
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
        cmbMovieMaxPartner.Enabled = Enabling
        txtTiteNrMovieMax.Enabled = Enabling
        cmbMovieMaxPartner.Enabled = Enabling
        cmbFeeSharingStudio.Enabled = Enabling

        txtFeeSharing_End.Enabled = Enabling


        txtFeeSharing_TurnPrice.Enabled = Enabling

        txtFeeSharing_UpfrontFee.Enabled = Enabling

        chkInCinemaNow.Enabled = Enabling
        chkInTheBags.Enabled = Enabling
        chkInTheBagsNext.Enabled = Enabling
        chkProduct_Next.Enabled = Enabling
        'Categories
        TreeListCategories.OptionsBehavior.Editable = Enabling
        TreeListThemes.OptionsBehavior.Editable = Enabling
        'Sale/Purchqse
        txtPrice.Enabled = Enabling
        txtQty_to_sale.Enabled = Enabling
        txtSale_price.Enabled = Enabling
        txtSaleDate.Enabled = Enabling
        txtNew_qty_to_sale.Enabled = Enabling
        txtNew_Sale_Price.Enabled = Enabling
        chkOnly_for_sale.Enabled = Enabling
        cmbProducts_product_type.Enabled = Enabling
        chkGameOnline.Enabled = Enabling
        txtGame_ConfigMini.Enabled = Enabling
        txtGame_NbrOfPlayersOnline.Enabled = Enabling
        txtGame_NbrOfPlayers.Enabled = Enabling


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

#Region "Navigation / Search"
    Public Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Search()
    End Sub
    Public Sub Search()
        Dim _SQLTxt As String
        _SQLTxt = "SELECT PD.products_id, PD.language_id, PD.products_name , P.products_model as products_model FROM products_description PD " & _
                                " Left join products P on P.products_id = PD.products_id " & _
                                " where products_name like '%" & txtTitleSearch.Text.Trim & "%'  "
        objDS.Tables("products_description1").Clear()
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_description1"), _SQLTxt)
    End Sub
    Private Sub txtTitleSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTitleSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Search()
        End If
    End Sub
    Private Sub GridViewSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridViewSearch.DoubleClick
        CurrentProductID = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle)("products_id")
        LoadProductsInfo()
        If XtraTabControl1.SelectedTabPage.Name = tabSearch.Name Then
            XtraTabControl1.SelectedTabPage = tabMain
        End If
    End Sub

    Public Sub searchID(ByVal products_id As Integer)
        txtQuickSearch.EditValue = products_id
        CurrentProductID = products_id
        LoadProductsInfo()
        If XtraTabControl1.SelectedTabPage.Name = tabSearch.Name Then
            XtraTabControl1.SelectedTabPage = tabMain
        End If
    End Sub
    Public Sub searchID()
        Dim param As DVDPostBuziness.clsSingleton
        param = DVDPostBuziness.clsSingleton.Instance()

        'If param.Products_id <> Nothing Then
        '    txtQuickSearch.EditValue = param.Products_id
        '    param.Products_id = Nothing
        'End If

        If IsNumeric(txtQuickSearch.EditValue) Then
            CurrentProductID = txtQuickSearch.EditValue
            LoadProductsInfo()
            If XtraTabControl1.SelectedTabPage.Name = tabSearch.Name Then
                XtraTabControl1.SelectedTabPage = tabMain
            End If
        End If
    End Sub
    Public Overrides Sub btnQuickSearch_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuickSearch.ItemClick
        searchID()
    End Sub
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

#End Region

#Region "PLUS-BUTTON-FOR-ADDITIONAL-EDITORS"
    Private Sub btnRemoveDVD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveDVD.Click
        Dim _ans As MsgBoxResult
        _ans = MsgBox("Are you sure you want to remove this DVD from Site and ALL WishList?", MsgBoxStyle.YesNo)
        If _ans = MsgBoxResult.Yes Then
            XtraTabControl1.Enabled = False
            MainData.RemoveDVDFromCatalogue()
            XtraTabControl1.Enabled = True
            MsgBox("Ce titre a été retiré de notre catalogue et de toutes les wishlist (avec envoi de e-mail aux clients)", MsgBoxStyle.Information)
        End If
        XtraTabControl1.Enabled = True
    End Sub
    Private Sub btnDeleteFromliste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteFromliste.Click
        Dim _ans As MsgBoxResult
        _ans = MsgBox("Are you sure you want to erase this DVD of liste?", MsgBoxStyle.YesNo)
        Dim exist As Boolean = False
        exist = BKGlobal.ExecuteExists("select * from products_dvd where products_id = " & txtProductID.Text.ToString)
        If _ans = MsgBoxResult.Yes Then
            If exist = False Then
                DvdPostData.clsConnection.ExecuteNonQuery("delete from products where products_id = " & txtProductID.Text.ToString)
                MsgBox("done")
                Search()
                XtraTabControl1.SelectedTabPage = tabSearch
            Else
                MsgBox("you can't erase this products , if exist DVDs for this products")
            End If
        End If
    End Sub
    Private Sub btnReCalcQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReCalcQty.Click
        MainData.RecalcQty()
    End Sub
    Private Sub cmbStudio_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbStudio.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim _frm As New frmStudioBrowseMaint_Browse(SessionInfo)
            _frm.Tag = 670 'MenuID if started with the MenuTree
            _frm.ShowDialog(Me)
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("studio"), "SELECT * FROM studio")
        End If
    End Sub
    Private Sub cmbcountry_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbcountry.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim _frm As New frmProdCountriesBrowseMaint_Browse(SessionInfo)
            _frm.Tag = 671 'MenuID if started with the MenuTree
            _frm.ShowDialog(Me)
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_countries"), "SELECT * FROM products_countries")
        End If
    End Sub
    Private Sub cmbDirector_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbDirector.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim _frm As New frmDirectorsBrowseMaint(SessionInfo)
            _frm.Tag = 672 'MenuID if started with the MenuTree
            _frm.ShowDialog(Me)
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("directors"), "SELECT * FROM directors")
        End If
    End Sub
    Private Sub cmbSerie_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbSerie.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim _frm As New frmSeriesBrowseMaint(SessionInfo)
            _frm.Tag = 673 'MenuID if started with the MenuTree
            _frm.ShowDialog(Me)
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("series"), "SELECT * FROM series")
        End If
    End Sub
    Private Sub cmbABOSerie_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbABOSerie.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim _frm As New frmSeriesBrowseMaint(SessionInfo)
            _frm.Tag = 673 'MenuID if started with the MenuTree
            _frm.ShowDialog(Me)
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("series"), "SELECT * FROM series")
        End If
    End Sub
    Private Sub btnActorsMaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActorsMaint.Click
        Dim _frm As New frmActorsBrowseMaint(SessionInfo)
        _frm.Tag = 674 'MenuID if started with the MenuTree
        _frm.ShowDialog(Me)
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("actors"), "SELECT * FROM actors")
    End Sub
    Private Sub btnLang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLang.Click
        Dim _frm As New frmProdLangBrowseMaint(SessionInfo)
        _frm.Tag = 675 'MenuID if started with the MenuTree
        _frm.ShowDialog(Me)
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_languages"), "SELECT * FROM products_languages where languagenav_id = 1 ")
    End Sub
    Private Sub btnSubTitles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubTitles.Click
        Dim _frm As New frmProdUnderTitlesBrowseMaint(SessionInfo)
        _frm.Tag = 676 'MenuID if started with the MenuTree
        _frm.ShowDialog(Me)
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_undertitles"), "SELECT * FROM products_undertitles  where language_id = 1 ")
    End Sub
    Private Sub btnSoundTracks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSoundTracks.Click
        Dim _frm As New frmSoundtracksBrowseMaint(SessionInfo)
        _frm.Tag = 678 'MenuID if started with the MenuTree
        _frm.ShowDialog(Me)
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_soundtracks"), "SELECT * FROM products_soundtracks  where language_id = 1 ")
    End Sub


#End Region

#Region "Images"
    Private Sub txtPictureImage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPictureImage.EditValueChanged
        RefreshSmallPicture()
    End Sub
    Private Sub txtImageFR_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImageFR.EditValueChanged
        RefreshPictureFR()
    End Sub
    Private Sub txtImageNL_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImageNL.EditValueChanged
        RefreshPictureNL()
    End Sub
    Private Sub txtImageEN_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImageEN.EditValueChanged
        RefreshPictureEN()
    End Sub
    Private Sub RefreshSmallPicture()
        If txtPictureImage.EditValue & "" <> "" Then
            If MainData.productsType & "" = "DVD_NORM" Then
                If System.IO.File.Exists("\\" & mvarImagesServer & "\images\" & txtPictureImage.EditValue) Then
                    PictProducts_Image.Image = System.Drawing.Image.FromFile("\\" & mvarImagesServer & "\images\" & txtPictureImage.EditValue)
                Else
                    PictProducts_Image.Image = Nothing
                End If
            ElseIf MainData.productsType & "" = "DVD_ADULT" Then
                If System.IO.File.Exists("\\" & mvarImagesServer & "\imagesx\" & txtPictureImage.EditValue) Then
                    PictProducts_Image.Image = System.Drawing.Image.FromFile("\\" & mvarImagesServer & "\imagesx\" & txtPictureImage.EditValue)
                Else
                    PictProducts_Image.Image = Nothing
                End If
            Else
                PictProducts_Image.Image = Nothing
            End If
        End If
    End Sub
    Private Sub RefreshPictureFR()
        If txtImageFR.EditValue & "" <> "" Then
            If MainData.productsType & "" = "DVD_NORM" Then
                If System.IO.File.Exists("\\" & mvarImagesServer & "\images\" & txtImageFR.EditValue) Then
                    pictFR.Image = System.Drawing.Image.FromFile("\\" & mvarImagesServer & "\images\" & txtImageFR.EditValue)
                Else
                    pictFR.Image = Nothing
                End If
            ElseIf MainData.productsType & "" = "DVD_ADULT" Then
                If System.IO.File.Exists("\\" & mvarImagesServer & "\imagesx\" & txtImageFR.EditValue) Then
                    pictFR.Image = System.Drawing.Image.FromFile("\\" & mvarImagesServer & "\imagesx\" & txtImageFR.EditValue)
                Else
                    pictFR.Image = Nothing
                End If
            Else
                pictFR.Image = Nothing
            End If
        End If
    End Sub
    Private Sub RefreshPictureNL()
        If txtImageNL.EditValue & "" <> "" Then
            If MainData.productsType & "" = "DVD_NORM" Then
                If System.IO.File.Exists("\\" & mvarImagesServer & "\images\" & txtImageNL.EditValue) Then
                    pictNL.Image = System.Drawing.Image.FromFile("\\" & mvarImagesServer & "\images\" & txtImageNL.EditValue)
                Else
                    pictNL.Image = Nothing
                End If
            ElseIf MainData.productsType & "" = "DVD_ADULT" Then
                If System.IO.File.Exists("\\" & mvarImagesServer & "\imagesx\" & txtImageNL.EditValue) Then
                    pictNL.Image = System.Drawing.Image.FromFile("\\" & mvarImagesServer & "\imagesx\" & txtImageNL.EditValue)
                Else
                    pictNL.Image = Nothing
                End If
            Else
                pictNL.Image = Nothing
            End If
        End If
    End Sub
    Private Sub RefreshPictureEN()
        If txtImageEN.EditValue & "" <> "" Then
            If MainData.productsType & "" = "DVD_NORM" Then
                If System.IO.File.Exists("\\" & mvarImagesServer & "\images\" & txtImageEN.EditValue) Then
                    pictEN.Image = System.Drawing.Image.FromFile("\\" & mvarImagesServer & "\images\" & txtImageEN.EditValue)
                Else
                    pictEN.Image = Nothing
                End If
            ElseIf MainData.productsType & "" = "DVD_ADULT" Then
                If System.IO.File.Exists("\\" & mvarImagesServer & "\imagesx\" & txtImageEN.EditValue) Then
                    pictEN.Image = System.Drawing.Image.FromFile("\\" & mvarImagesServer & "\imagesx\" & txtImageEN.EditValue)
                Else
                    pictEN.Image = Nothing
                End If
            Else
                pictEN.Image = Nothing
            End If
        End If
    End Sub
#End Region

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
    Private Sub RefreshCategoryTree()
        If boolLoadingDVDInfo Then Exit Sub
        Dim _ID As Integer
        Dim _product_type As String 'Movie; Game
        Dim _products_type As String 'DVD_NORM, DVD_Adult
        Dim _DS As New dsProducts
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            _ID = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField)
            _product_type = cmbProducts_product_type.EditValue & ""   'CType(Me.BindingContext(objDS, TableName).Current, DataRowView)("products_product_type")
            _products_type = cmbProducts_Type.EditValue & ""
            If _product_type & "" = "" Then _product_type = "Movie"
            If _products_type & "" = "" Then _products_type = "DVD_NORM"
            If IsDBNull(_ID) Then Exit Sub
            objDS.Tables("categories_fr_view1").Clear()
            Dim _category_sql As String = "select c.categories_id, parent_id, categories_type, cdesc.categories_name from categories c" & _
                 " left join categories_description cdesc on cdesc.categories_id = c.categories_id and cdesc.language_id = 1 " & _
                 " WHERE categories_type = '" & _products_type & "' and product_type = '" & _product_type & "'"
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("categories_fr_view1"), _category_sql)
            DvdPostData.clsConnection.FillDataSet(_DS.Tables("products_to_categories"), "SELECT * from products_to_categories where products_id = " & MainData.ProductsID)
            Dim _row As DataRow
            For Each _row In objDS.Tables("categories_fr_view1").Rows
                If IsNothing(_DS.Tables("products_to_categories").Rows.Find(New Object() {MainData.ProductsID, _row("categories_id")})) Then
                    _row("category_selected") = 0
                Else
                    _row("category_selected") = 1
                End If
                'If MainData.IsInCategory(MainData.ProductsId, _row("categories_id")) Then
                '    _row("category_selected") = 1
                'Else
                '    _row("category_selected") = 0
                'End If
            Next
        End If
    End Sub
    Private Sub TreeListCategories_NodesReloaded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeListCategories.NodesReloaded
        TreeListCategories.ExpandAll()
        'TreeList1.Nodes.FirstNode.Expanded = True
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
                _view = New DataView(objDS.Tables("categories_fr_view1"), "parent_id = " & e.Node("categories_id"), "", DataViewRowState.CurrentRows)
                For Each _row In _view
                    _row("category_selected") = e.Value
                Next
                'For Each _node In e.Node.Nodes   'TreeList1.FocusedNode.Nodes
                '    'CheckNodes(_node, e.Value)
                '    _node("category_selected") = e.Value
                'Next
            Catch ex As Exception
                DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, ex)
            End Try

        End If
        'TreeList1.RefreshDataSource()
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
    Private Sub RefreshThemeTree()
        Dim _ID As Integer
        Dim _DS As New dsProducts
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            _ID = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField)
            If IsDBNull(_ID) Then Exit Sub
            objDS.Tables("themes_fr_view1").Clear()
            Dim _theme_sql As String = "select t.themes_id, parent_id, themes_type, tdesc.themes_name from themes t " & _
                 " left join themes_description tdesc on tdesc.themes_id = t.themes_id and tdesc.language_id = 1 " & _
                 " WHERE themes_type = '" & MainData.productsType & "' "
            Cls1.FillDataSet(objDS.Tables("themes_fr_view1"), _theme_sql)
            Cls1.FillDataSet(_DS.Tables("products_to_themes"), "SELECT * from products_to_themes where products_id = " & MainData.ProductsID)
            Dim _row As DataRow
            For Each _row In objDS.Tables("themes_fr_view1").Rows
                If IsNothing(_DS.Tables("products_to_themes").Rows.Find(New Object() {MainData.ProductsID, _row("themes_id")})) Then
                    _row("themes_selected") = 0
                Else
                    _row("themes_selected") = 1
                End If
                'If MainData.IsInTheme(MainData.ProductsId, _row("themes_id")) Then
                '    _row("themes_selected") = 1
                'Else
                '    _row("themes_selected") = 0
                'End If
            Next
        End If
    End Sub
    Private Sub TreeListThemes_NodesReloaded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeListThemes.NodesReloaded
        TreeListThemes.ExpandAll()
        'TreeList1.Nodes.FirstNode.Expanded = True
    End Sub
    Private Sub TreeListthemes_CellValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles TreeListThemes.CellValueChanging
        Dim _view As DataView
        Dim _row As DataRowView
        If e.Column.FieldName <> "themes_selected" Then Exit Sub
        If e.Value = 1 Then 'Putting to TRUE then put Also Parent to True
            e.Node("themes_selected") = e.Value
            If Not IsNothing(e.Node.ParentNode) Then
                e.Node.ParentNode("themes_selected") = e.Value
            End If
        Else 'Putting to False , then Put also Children To False
            e.Node("themes_selected") = e.Value
            Try
                _view = New DataView(objDS.Tables("themes_fr_view1"), "parent_id = " & e.Node("themes_id"), "", DataViewRowState.CurrentRows)
                For Each _row In _view
                    _row("themes_selected") = e.Value
                Next
                'For Each _node In e.Node.Nodes   'TreeList1.FocusedNode.Nodes
                '    'CheckNodes(_node, e.Value)
                '    _node("category_selected") = e.Value
                'Next
            Catch ex As Exception
                DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, ex)
            End Try

        End If
        'TreeList1.RefreshDataSource()
    End Sub
    Private Sub txtModel_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtModel.Leave
        If txtModel.Enabled = False Then Exit Sub
        If txtImageFR.EditValue & "" = "" Then
            'txtImageFR.EditValue = "dvd/" & txtModel.Text.ToLower & "bfr.jpg"
            'txtImageFR.Refresh()
            objDS.Tables("products_description_fr").Rows(0)("products_image_big") = "dvd/" & txtModel.Text.ToLower & "bfr.jpg"
        End If
        If txtImageNL.EditValue & "" = "" Then
            'txtImageNL.EditValue = "dvd/" & txtModel.Text.ToLower & "bnl.jpg"
            'txtImageNL.Refresh()
            objDS.Tables("products_description_nl").Rows(0)("products_image_big") = "dvd/" & txtModel.Text.ToLower & "bfr.jpg"
        End If
        If txtImageEN.EditValue & "" = "" Then
            'txtImageEN.EditValue = "dvd/" & txtModel.Text.ToLower & "buk.jpg"
            'txtImageEN.Refresh()
            objDS.Tables("products_description_en").Rows(0)("products_image_big") = "dvd/" & txtModel.Text.ToLower & "bfr.jpg"
        End If
    End Sub
    Private Sub btnCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategories.Click
        MsgBox("Pas Encore fini", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub btnThemes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThemes.Click
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
    Private Sub GridViewProducts_DVD_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewProducts_DVD.FocusedRowChanged
        If GridViewProducts_DVD.IsValidRowHandle(GridViewProducts_DVD.FocusedRowHandle) Then
            CurrentDVDID = GridViewProducts_DVD.GetDataRow(GridViewProducts_DVD.FocusedRowHandle)("products_dvdid")
            LoadOrders(CurrentDVDID)
            LoadProductsDVDStatusHistory(CurrentDVDID)
        End If
    End Sub
    Private Sub chkLoadAllOrders_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLoadAllOrders.CheckedChanged
        If chkLoadAllOrders.Checked = True Then
            LoadOrders(-1)
        Else
            If GridViewProducts_DVD.IsValidRowHandle(GridViewProducts_DVD.FocusedRowHandle) Then
                CurrentDVDID = GridViewProducts_DVD.GetDataRow(GridViewProducts_DVD.FocusedRowHandle)("products_dvdid")
                LoadOrders(CurrentDVDID)
            End If
        End If
    End Sub
    Private Sub LoadOrders(ByVal vDVD_ID As Integer)
        If boolLoadingOrder = True Then Exit Sub
        boolLoadingOrder = True
        objDS.Tables("orders_products_view1").Clear()
        Dim _SQLTxt As String
        If vDVD_ID <> -1 Then
            _SQLTxt = "select op.orders_id, o.customers_id, op.products_id, op.products_dvd as dvd_id, o.delivery_country, o.delivery_name, o.customers_email_address, " & _
                        " op.pick_group, op.pick_boxid, o.date_purchased, op.orders_products_status , os.orders_status_name" & _
                        " from orders_products op left join orders o on o.orders_id = op.orders_id " & _
                        " join orders_status os on o.orders_status = os.orders_status_id and os.language_id = 1 " & _
                        " where op.products_id = " & CurrentProductID & " AND op.products_dvd = " & CurrentDVDID & _
                        " ORDER BY op.orders_id desc "
        Else
            _SQLTxt = "select op.orders_id, o.customers_id, op.products_id, op.products_dvd as dvd_id, o.delivery_country, o.delivery_name, o.customers_email_address, " & _
                                    " op.pick_group, op.pick_boxid, o.date_purchased, op.orders_products_status ,o.orders_status_name" & _
                                    " from orders_products op left join orders o on o.orders_id = op.orders_id " & _
                                    " join orders_status os on o.orders_status = os.orders_status_id and os.language_id = 1 " & _
                                    " where op.products_id = " & CurrentProductID & _
                                    " ORDER BY op.orders_id desc "
        End If
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("orders_products_view1"), _SQLTxt)
        boolLoadingOrder = False
    End Sub
    Private Sub LoadProductsDVDStatusHistory(ByVal vDVD_ID As Integer)
        If CurrentProductID = -1 Or CurrentDVDID = 1 Then Exit Sub
        objDS.Tables("products_dvd_status_history").Clear()
        Dim _SQLTxt As String
        _SQLTxt = "select * from products_dvd_status_history where products_id = " & CurrentProductID & " AND products_dvdid = " & CurrentDVDID
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_dvd_status_history"), _SQLTxt)
    End Sub

    Private Sub GridVIewOrders_History_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridVIewOrders_History.FocusedRowChanged
        Dim _SQLTxt As String
        If GridVIewOrders_History.IsValidRowHandle(GridVIewOrders_History.FocusedRowHandle) Then
            CurrentOrderID = GridVIewOrders_History.GetDataRow(GridVIewOrders_History.FocusedRowHandle)("orders_id")
        Else
            CurrentOrderID = -1
        End If
        objDS.Tables("orders_status_history").Clear()
        If CurrentOrderID <> -1 Then
            _SQLTxt = "select * " & _
                      " from orders_status_history " & _
                      " where orders_id = " & CurrentOrderID & _
                      " ORDER BY orders_status_history_id desc "
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("orders_status_history"), _SQLTxt)
        End If
    End Sub

    Private Sub btnAddNewDVDs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewDVDs.Click
        'MsgBox("Not Yet!", MsgBoxStyle.Information)
        Dim msg As MsgBoxResult
        msg = MsgBox("Add new Dvd", MsgBoxStyle.YesNo)

        If msg = MsgBoxResult.Yes Then
            If CurrentProductID <= 0 Then
                MsgBox("Choisir un Product.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If txtNbrOfDVDToAdd.Value <= 0 Then
                MsgBox("Choisir une quantité a ajouter.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If IsNothing(MainData) Then
                MsgBox("Choisir un Product.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            MainData.AddNewDVD(txtNbrOfDVDToAdd.Value)
            'Dim intmaxproducts_dvdid As Integer = 0
            'Dim _SQLTxt As String
            '_SQLTxt = "SELECT if(max(products_dvdid)  is null, 0, max(products_dvdid))  as cnt FROM products_dvd where products_id = '" & CurrentProductID & "' "
            'intmaxproducts_dvdid = BKGlobal.ExecuteFindFieldValueINT("cnt", _SQLTxt)

            '_SQLTxt = "update products set products_dvd_quantity = products_dvd_quantity + '" & txtNbrOfDVDToAdd.Value & _
            '          "' , products_availability = 1, products_quantity = products_quantity + '" & txtNbrOfDVDToAdd.Value & "' where products_id = '" & CurrentProductID & "'  "
            'DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)

            'Dim i As Integer

            'For i = (intmaxproducts_dvdid + 1) To (CInt(txtNbrOfDVDToAdd.Value) + intmaxproducts_dvdid)
            '    _SQLTxt = "insert into products_dvd (products_id , products_dvdid ,`inout`,  products_dvd_status, last_admindate, dvd_buy_date )values( '" & _
            '            CurrentProductID & "' , '" & i & "' , 1 , 1 , now(), now() ) "
            '    DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
            '    'cmbAvailability.EditValue = 1
            '    'SaveChanges(sender, e)
            'Next
            LoadProductsInfo()
        End If
    End Sub
    Private Sub btnTransferProductID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferProductID.Click
        If CurrentProductID = -1 Then
            MsgBox("Please select a Product first", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If Not IsNumeric(txtToProdID1.EditValue) Then
            MsgBox("Please select a TO Product ID.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim sSQL2 As String = "SELECT w.wl_id, w.customers_id, w.product_id, c.customers_language from wishlist w,  customers c where w.customers_id = c.customers_id and c.customers_language  = '" & txtCustLang1.EditValue & "' and w.product_id = '" & txtFromProdID1.EditValue & "' "
        Dim _DS As New DataSet
        _DS.Tables.Add("TmpTable")
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("TmpTable"), sSQL2)
        Dim _row As DataRow
        Dim i, j As Integer
        Dim ssql3 As String = ""
        Dim _Exist As Boolean = False
        'txtWLToProcess.EditValue = _DS.Tables("TmpTable").Rows.Count
        DoEvents()
        For Each _row In _DS.Tables("TmpTable").Rows
            'txtWLToProcess.EditValue -= 1
            DoEvents()
            _Exist = BKGlobal.ExecuteExists("select count(*) as cnt from wishlist w " & _
                   " where product_id = " & txtToProdID1.EditValue & " and w.customers_id = " & _row("customers_id"))
            Try
                If _Exist Then
                    ssql3 = "delete from  wishlist where wl_id   = '" & _row("wl_id") & "' and product_id = '" & txtFromProdID1.EditValue & "'  "
                    DvdPostData.clsConnection.ExecuteNonQuery(ssql3)
                    j = j + 1
                Else
                    ssql3 = "update wishlist  set product_id = '" & txtToProdID1.EditValue & "' where wl_id   = '" & _row("wl_id") & "' and product_id = '" & txtFromProdID1.EditValue & "'  "
                    DvdPostData.clsConnection.ExecuteNonQuery(ssql3)
                    i = i + 1
                End If
            Catch ex As Exception
                DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, ex)
            End Try
        Next
        MsgBox(i & " entries Done; " & j & " deleted because bouble ", MsgBoxStyle.Exclamation)
    End Sub


    Private Sub cmbProducts_Type_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProducts_Type.EditValueChanged
        RefreshCategoryTree()
    End Sub
    Private Sub cmbProducts_product_type_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProducts_product_type.EditValueChanged
        RefreshCategoryTree()
    End Sub


    'Private Sub PanelControl3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelControl3.Paint

    'End Sub

    Private Sub ButDelPrDvdId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButDelPrDvdId.Click
        ''delete dvd in dvdmaintenance on DVDS

        If Me.GridViewProducts_DVD.RowCount = 0 Then
            MsgBox("Select a products_dvdid.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim prdvd_id As String = Me.GridViewProducts_DVD.GetDataRow(GridViewProducts_DVD.FocusedRowHandle)("products_dvdid").ToString
        Dim _ans As MsgBoxResult
        _ans = MsgBox("products: " + Me.CurrentProductID.ToString + "    products_dvdid: " + prdvd_id, MsgBoxStyle.YesNo)

        Dim _SQLTxt As String
        objDS.Tables("orders_products_view1").Clear()

        _SQLTxt = "select op.orders_id, o.customers_id, op.products_id, op.products_dvd as dvd_id, o.delivery_country, o.delivery_name, o.customers_email_address, " & _
                               " op.pick_group, op.pick_boxid, o.date_purchased, op.orders_products_status " & _
                                       " from orders_products op left join orders o on o.orders_id = op.orders_id " & _
                                        " where op.products_dvd = '" & prdvd_id & " 'and op.products_id = " & CurrentProductID & _
                                        " ORDER BY op.orders_id desc "
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("orders_products_view1"), _SQLTxt)



        If _ans = MsgBoxResult.Yes And objDS.Tables("orders_products_view1").Rows.Count = 0 Then
            'delete de dvd de la table products_dvd + update de la quantite de dvd  nbrDvd-1
            DvdPostData.clsConnection.ExecuteNonQuery("delete from products_dvd where products_id = " & Me.CurrentProductID.ToString & _
                                         " and products_dvdid = '" & prdvd_id & "' ")
            DvdPostData.clsConnection.ExecuteNonQuery("update products set products_dvd_quantity = products_dvd_quantity -1 ,products_quantity = products_quantity -1 " & _
                                         "where products_id = '" & CurrentProductID.ToString & "'  ")

            Me.GridViewProducts_DVD.DeleteSelectedRows()
            MsgBox("ok")
            Exit Sub


        ElseIf _ans = MsgBoxResult.No Then
            Exit Sub
        Else
            MsgBox("You cannot remove this DVD of the list")
        End If




    End Sub
    Private Sub Purchase_click(ByVal sender As Object, ByVal e As System.EventArgs)
        _ctrlGridControl.GridPurchase_click()
    End Sub
    Private Sub loadWishlistCustomers(ByVal product_id As Integer)
        Dim sql As String
        Dim dt As DataTable
        If _refreshData_wishlistCustomer Then
            sql = DvdPostData.clsProductDvd.GetWishlistCustomerProduct(product_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            gridViewWishlistCustomers.Columns.Clear()
            GridWishlistCustomers.DataSource = dt
            gridViewWishlistCustomers.BestFitColumns()
            _refreshData_wishlistCustomer = False
        End If
    End Sub
    Private Sub loadPrevision(ByVal product_id As Integer)
        Dim sql As String
        Dim dt As DataTable
        If _refreshData_prevision Then
            sql = DvdPostData.ClsPurchaseSale.GetSelectViewPurchaseSaleByProducts(product_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            GridViewPrevision.Columns.Clear()
            GridPrevision.DataSource = dt
            GridViewPrevision.BestFitColumns()

            _ctrlGridControl = New DVDPostBuziness.ClsGridControl()
            AddHandler _ctrlGridControl.Purchase_click, AddressOf Purchase_click
            _ctrlGridControl.addColumnButtonOrderPurchase(GridPrevision, GridViewPrevision)
            _refreshData_prevision = False
        End If
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPage Is tabPrevision Then
            loadPrevision(CurrentProductID)
        ElseIf XtraTabControl1.SelectedTabPage Is tabFeeSharing Then
            loadFeeSharing()
        ElseIf XtraTabControl1.SelectedTabPage Is tabWishlistCustomers Then
            loadWishlistCustomers(CurrentProductID)
        End If

    End Sub


    Private Sub loadFeeSharing()
        If _refreshData_FeeSharing = True Then
            loadFeeSharingStudio()
            LoadMovieMaxInfo()

            _refreshData_FeeSharing = False
        End If
    End Sub


    Private Sub loadFeeSharingStudio()
        _listFeeSharingStudio.Add(New DVDPostBuziness.clsKeyCombo("Universal/Global Data", DvdPostData.clsFeeSharing.feeSharingStudio.UNIVERSAL_GLOBAL_DATA))
        _listFeeSharingStudio.Add(New DVDPostBuziness.clsKeyCombo("MovieMax", DvdPostData.clsFeeSharing.feeSharingStudio.MOVIEMAX))
        cmbFeeSharingStudio.Properties.DataSource = _listFeeSharingStudio
    End Sub

    Private Sub cmbFeeSharingStudio_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFeeSharingStudio.EditValueChanged
        If cmbFeeSharingStudio.EditValue = DvdPostData.clsFeeSharing.feeSharingStudio.UNIVERSAL_GLOBAL_DATA Then
            txtFeeSharing_UpfrontFee.EditValue = DvdPostData.clsFeeSharing.UPFRONTFEE_VALUE_UNIVERSAL_GLOBAL_DATA
            txtFeeSharing_TurnPrice.EditValue = DvdPostData.clsFeeSharing.TURN_PRICE

        ElseIf cmbFeeSharingStudio.EditValue = DvdPostData.clsFeeSharing.feeSharingStudio.MOVIEMAX Then
            txtFeeSharing_UpfrontFee.EditValue = DvdPostData.clsFeeSharing.UPFRONTFEE_VALUE_MOVIEMAX
            txtFeeSharing_TurnPrice.EditValue = DvdPostData.clsFeeSharing.TURN_PRICE

            LoadMovieMaxInfo()
        End If


    End Sub

    Private Sub laodcmbMovieMaxPartner()

        Dim dt As DataTable
        Dim sql As String = DvdPostData.clsFeeSharing.GetMovieMaxPartner()

        dt = DvdPostData.clsConnection.FillDataSet(sql)
        cmbMovieMaxPartner.Properties.DataSource = dt



    End Sub

    Private Sub LoadMovieMaxInfo()
        If cmbFeeSharingStudio.EditValue = DvdPostData.clsFeeSharing.feeSharingStudio.MOVIEMAX Then
            laodcmbMovieMaxPartner()
            Dim dt As DataTable
            Dim sql As String = DvdPostData.clsFeeSharing.GetMovieMaxInput(CurrentProductID)
            dt = DvdPostData.clsConnection.FillDataSet(sql)

            If Not dt.Rows.Count = 0 Then
                txtTiteNrMovieMax.EditValue = dt.Rows(0)("titelnr")
                cmbMovieMaxPartner.EditValue = dt.Rows(0)("maatschappij")
            End If

        End If

    End Sub

    Private Sub SaveMoviemax() '(ByVal products_id As Integer, ByVal titleName As String, ByVal titeNr As Integer, ByVal maatschappij As Integer)
        If cmbFeeSharingStudio.EditValue = DvdPostData.clsFeeSharing.feeSharingStudio.MOVIEMAX Then

            Dim products_id As Integer = CurrentProductID
            Dim ok As Boolean = DvdPostData.clsConnection.ExecuteScalar(DvdPostData.clsFeeSharing.moviemaxExist(products_id))
            Dim titelNr As Integer = txtTiteNrMovieMax.EditValue
            Dim maatschappij As Integer = cmbMovieMaxPartner.EditValue


            If ok = False Then
                Dim sql As String = DvdPostData.clsFeeSharing.insertMovieMax(products_id, titelNr, maatschappij)
                DvdPostData.clsConnection.ExecuteNonQuery(sql)
            End If

            If ok = True Then
                Dim updateSql As String = DvdPostData.clsFeeSharing.updateMovieMaxInput(products_id, txtTiteNrMovieMax.EditValue, cmbMovieMaxPartner.EditValue)
                DvdPostData.clsConnection.ExecuteNonQuery(updateSql)
            End If
        End If
    End Sub


    'Private Sub openFrmCustMaint(ByVal customers_id As Integer)
    '    Dim result As frmCustomers_Maint
    '    Dim _frm As New frmCustomers_Maint()
    '    _frm.SessionInfo = SessionInfo
    '    result = _frm.openFrmCustMaint(customers_id, Me.ParentForm)
    '    result.XtraTabControl1.SelectedTabPage = result.tabWishList

    'End Sub


    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Dim fB As New Windows.Forms.FolderBrowserDialog
    '    Dim str As String
    '    Dim feesharing As New feesharing


    '    fB.RootFolder = Environment.SpecialFolder.Desktop
    '    fB.Description = "Choose a folder"
    '    fB.ShowDialog()

    '    If fB.SelectedPath = String.Empty Then
    '        MsgBox("Pas de sélection")
    '        Exit Sub
    '    End If

    '    Try
    '        str = feesharing.batchFeeSharing()
    '        Dim okWrite As Boolean = DVDPostTools.clsFile.WriteFile(fB.SelectedPath & "\test.txt", str)
    '        If okWrite = False Then
    '            MsgBox("the file is not record")
    '        End If
    '    Catch ex As Exception
    '        Exit Sub
    '    End Try
    'End Sub

    Private Sub GridWishlistCustomers_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridWishlistCustomers.DoubleClick
        If gridViewWishlistCustomers.RowCount <> 0 Then
            Dim customers_id As String = gridViewWishlistCustomers.GetDataRow(gridViewWishlistCustomers.FocusedRowHandle)("customers_id")
            Dim frm As frmCustomers_Maint
            frm = ClsCustomers.openFrmCustMaint(customers_id, Me.ParentForm, SessionInfo)
            frm.XtraTabControl1.SelectedTabPage = frm.tabWishList
        End If
    End Sub
End Class
