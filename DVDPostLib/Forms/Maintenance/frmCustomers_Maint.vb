Imports BizzLib.clsGlobal.ObjectState

Public Class frmCustomers_Maint
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
    Friend WithEvents tabSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcustomers_id_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcustomers_name_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcustomers_email_address_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcustomers_domiciliation_number_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcustomers_address_street_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcustomers_postcode_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents objDS As DVDPostLib.dsCustomerMaint
    Friend WithEvents GridViewSearch As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colcustomers_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_firstname As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_lastname As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_email_address As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_abo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colblack_listed As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colentry_street_address As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colentry_postcode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldomiciliation_number As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtLastName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomers_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFirstName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabWishList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabAboHistory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDeliveryFirstName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeliveryLastName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnStopNow As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnStopAtReconduction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAbo_ValidityTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbABO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtABOCredit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDVDNorm As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtDVDAdult As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtDVDAdultAtHome As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtABO As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtTel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelEvening As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbNextABO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbDeliveryCountry As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDeliveryCity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeliveryPostCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeliveryAddr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDVDNormAtHome As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents GridWishList As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewWishList As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colwl_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_id1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproduct_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colrank As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colpriority As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldate_added As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colwishlist_type As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_title As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colqty_in_stock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents txtEMail As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents colSendIt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents btnSendIt As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridWishListAssigned As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewWishListAssigned As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colwl_assigned_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colwl_id1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_id2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colrank1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldate_added1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldate_assigned As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colwishlist_type1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_title1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents chkMultiShipment As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridABO As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewABO As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colabo_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomerid As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAction As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcode_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproduct_id1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colpayment_method As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colprivilege_notified As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcomment As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colsite As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbABO_Action As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tabOrdersHistor As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitterControl2 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewOrders As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents colorders_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_id3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_street_address As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_suburb As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_city As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_postcode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_state As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_country As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_telephone As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_email_address1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_address_format_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldelivery_name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldelivery_street_address As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldelivery_suburb As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldelivery_city As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldelivery_postcode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldelivery_state As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldelivery_country As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldelivery_address_format_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colpayment_method1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcc_type As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcc_owner As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcc_number As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcc_expires As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldate_purchased As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colorders_status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colorders_date_finished As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents collast_modified As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcomments As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcurrency As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcurrency_value As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colsite1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colsecured_mail As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colmultishipment_sm As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colorders_products_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_id1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_model As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_price As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colfinal_price As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_tax As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_quantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_dvd As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colorders_products_status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colfeesharing As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbOrders_Status As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tabCRM As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tabMain = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.chkMultiShipment = New DevExpress.XtraEditors.CheckEdit
        Me.objDS = New DVDPostLib.dsCustomerMaint
        Me.cmbNextABO = New DevExpress.XtraEditors.LookUpEdit
        Me.txtDVDAdultAtHome = New DevExpress.XtraEditors.SpinEdit
        Me.txtDVDNormAtHome = New DevExpress.XtraEditors.SpinEdit
        Me.txtDVDAdult = New DevExpress.XtraEditors.SpinEdit
        Me.txtDVDNorm = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.txtABOCredit = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.txtAbo_ValidityTo = New DevExpress.XtraEditors.DateEdit
        Me.cmbABO = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.btnStopAtReconduction = New DevExpress.XtraEditors.SimpleButton
        Me.btnStopNow = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.txtDeliveryFirstName = New DevExpress.XtraEditors.TextEdit
        Me.txtDeliveryLastName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.cmbDeliveryCountry = New DevExpress.XtraEditors.LookUpEdit
        Me.txtDeliveryCity = New DevExpress.XtraEditors.TextEdit
        Me.txtDeliveryPostCode = New DevExpress.XtraEditors.TextEdit
        Me.txtDeliveryAddr = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtEMail = New DevExpress.XtraEditors.HyperLinkEdit
        Me.txtTelEvening = New DevExpress.XtraEditors.TextEdit
        Me.txtTel = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.txtABO = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.txtFirstName = New DevExpress.XtraEditors.TextEdit
        Me.txtLastName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtCustomers_id = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.tabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridViewSearch = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colcustomers_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_firstname = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_lastname = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_email_address = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_abo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colblack_listed = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colentry_street_address = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colentry_postcode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldomiciliation_number = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.txtcustomers_postcode_search = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.txtcustomers_address_street_search = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtcustomers_domiciliation_number_search = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtcustomers_email_address_search = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtcustomers_name_search = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtcustomers_id_search = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.tabWishList = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.GridWishListAssigned = New DevExpress.XtraGrid.GridControl
        Me.GridViewWishListAssigned = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colwishlist_type1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colwl_assigned_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colwl_id1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_id2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colrank1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldate_added1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldate_assigned = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_title1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl
        Me.GridWishList = New DevExpress.XtraGrid.GridControl
        Me.GridViewWishList = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colSendIt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.btnSendIt = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.colwishlist_type = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colwl_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_id1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproduct_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colrank = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colpriority = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldate_added = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_title = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colqty_in_stock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.tabAboHistory = New DevExpress.XtraTab.XtraTabPage
        Me.GridABO = New DevExpress.XtraGrid.GridControl
        Me.GridViewABO = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colabo_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomerid = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colAction = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbABO_Action = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colcode_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproduct_id1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colpayment_method = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colprivilege_notified = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcomment = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colsite = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.tabOrdersHistor = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl
        Me.SplitterControl2 = New DevExpress.XtraEditors.SplitterControl
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        Me.GridOrders = New DevExpress.XtraGrid.GridControl
        Me.GridViewOrders = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colorders_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldate_purchased = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colorders_status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbOrders_Status = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colcustomers_id3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_street_address = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_suburb = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_city = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_postcode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_state = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_country = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_telephone = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_email_address1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_address_format_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldelivery_name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldelivery_street_address = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldelivery_suburb = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldelivery_city = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldelivery_postcode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldelivery_state = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldelivery_country = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldelivery_address_format_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colpayment_method1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcc_type = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcc_owner = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcc_number = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcc_expires = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colorders_date_finished = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.collast_modified = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcomments = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcurrency = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcurrency_value = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colsite1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colsecured_mail = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colmultishipment_sm = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colorders_products_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_id1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_model = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_dvd = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_price = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colfinal_price = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_tax = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_quantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colorders_products_status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colfeesharing = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.tabCRM = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabMain.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.chkMultiShipment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNextABO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVDAdultAtHome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVDNormAtHome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVDAdult.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVDNorm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtABOCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbo_ValidityTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbABO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtDeliveryFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDeliveryCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryPostCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryAddr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtEMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelEvening.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtABO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomers_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearch.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtcustomers_postcode_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_address_street_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_domiciliation_number_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_email_address_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_name_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_id_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWishList.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GridWishListAssigned, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewWishListAssigned, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridWishList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewWishList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSendIt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAboHistory.SuspendLayout()
        CType(Me.GridABO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewABO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbABO_Action, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOrdersHistor.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GridOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOrders_Status, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCRM.SuspendLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PopMenuEdit
        '
        '
        'PopMenuSave
        '
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 424)
        Me.StatusBar1.Name = "StatusBar1"
        '
        'PrintSystem1
        '
        Me.PrintSystem1.ExportOptions.XlsNativeFormat = True
        '
        'PopMenuUndo
        '
        '
        'Misc_Bar
        '
        Me.Misc_Bar.DockCol = 3
        Me.Misc_Bar.DockRow = 1
        Me.Misc_Bar.Offset = 717
        '
        'Nav_Bar
        '
        Me.Nav_Bar.DockCol = 1
        Me.Nav_Bar.Offset = 171
        '
        'Misc_Bar2
        '
        Me.Misc_Bar2.DockCol = 4
        '
        'QuickSearch_Bar
        '
        Me.QuickSearch_Bar.DockCol = 2
        Me.QuickSearch_Bar.Offset = 313
        '
        'View_Bar
        '
        Me.View_Bar.DockCol = 2
        Me.View_Bar.DockRow = 1
        Me.View_Bar.FloatLocation = New System.Drawing.Point(774, 203)
        Me.View_Bar.Offset = 475
        '
        'Report_Bar
        '
        Me.Report_Bar.DockCol = 3
        Me.Report_Bar.DockRow = 0
        Me.Report_Bar.Offset = 517
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 57)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabMain
        Me.XtraTabControl1.Size = New System.Drawing.Size(1056, 367)
        Me.XtraTabControl1.TabIndex = 35
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabSearch, Me.tabMain, Me.tabWishList, Me.tabAboHistory, Me.tabOrdersHistor, Me.tabCRM})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.GroupControl3)
        Me.tabMain.Controls.Add(Me.PanelControl2)
        Me.tabMain.Controls.Add(Me.GroupControl2)
        Me.tabMain.Controls.Add(Me.GroupControl1)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Size = New System.Drawing.Size(1047, 337)
        Me.tabMain.Text = "General Info"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.chkMultiShipment)
        Me.GroupControl3.Controls.Add(Me.cmbNextABO)
        Me.GroupControl3.Controls.Add(Me.txtDVDAdultAtHome)
        Me.GroupControl3.Controls.Add(Me.txtDVDNormAtHome)
        Me.GroupControl3.Controls.Add(Me.txtDVDAdult)
        Me.GroupControl3.Controls.Add(Me.txtDVDNorm)
        Me.GroupControl3.Controls.Add(Me.LabelControl19)
        Me.GroupControl3.Controls.Add(Me.LabelControl18)
        Me.GroupControl3.Controls.Add(Me.LabelControl17)
        Me.GroupControl3.Controls.Add(Me.LabelControl16)
        Me.GroupControl3.Controls.Add(Me.txtABOCredit)
        Me.GroupControl3.Controls.Add(Me.LabelControl15)
        Me.GroupControl3.Controls.Add(Me.LabelControl14)
        Me.GroupControl3.Controls.Add(Me.txtAbo_ValidityTo)
        Me.GroupControl3.Controls.Add(Me.cmbABO)
        Me.GroupControl3.Controls.Add(Me.LabelControl13)
        Me.GroupControl3.Controls.Add(Me.LabelControl12)
        Me.GroupControl3.Location = New System.Drawing.Point(640, 8)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(232, 288)
        Me.GroupControl3.TabIndex = 5
        Me.GroupControl3.Text = "ABO Info"
        '
        'chkMultiShipment
        '
        Me.chkMultiShipment.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_multishipment"))
        Me.chkMultiShipment.Enabled = False
        Me.chkMultiShipment.Location = New System.Drawing.Point(8, 192)
        Me.chkMultiShipment.Name = "chkMultiShipment"
        '
        'chkMultiShipment.Properties
        '
        Me.chkMultiShipment.Properties.Caption = "Multi-Shipment"
        Me.chkMultiShipment.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkMultiShipment.Properties.ValueChecked = 1
        Me.chkMultiShipment.Properties.ValueUnchecked = 0
        Me.chkMultiShipment.Size = New System.Drawing.Size(96, 18)
        Me.chkMultiShipment.TabIndex = 30
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsCustomerMaint"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'cmbNextABO
        '
        Me.cmbNextABO.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_next_abo_type"))
        Me.cmbNextABO.Enabled = False
        Me.cmbNextABO.Location = New System.Drawing.Point(72, 48)
        Me.cmbNextABO.Name = "cmbNextABO"
        '
        'cmbNextABO.Properties
        '
        Me.cmbNextABO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNextABO.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_id", "products_id", 75, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_model", "products_model", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_title", "products_title", 72, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbNextABO.Properties.DataSource = Me.objDS.products_abo
        Me.cmbNextABO.Properties.DisplayMember = "products_title"
        Me.cmbNextABO.Properties.NullText = ""
        Me.cmbNextABO.Properties.ValueMember = "products_id"
        Me.cmbNextABO.Size = New System.Drawing.Size(152, 20)
        Me.cmbNextABO.TabIndex = 29
        '
        'txtDVDAdultAtHome
        '
        Me.txtDVDAdultAtHome.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_home_adult"))
        Me.txtDVDAdultAtHome.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDVDAdultAtHome.Enabled = False
        Me.txtDVDAdultAtHome.Location = New System.Drawing.Point(152, 160)
        Me.txtDVDAdultAtHome.Name = "txtDVDAdultAtHome"
        '
        'txtDVDAdultAtHome.Properties
        '
        Me.txtDVDAdultAtHome.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDVDAdultAtHome.Size = New System.Drawing.Size(72, 20)
        Me.txtDVDAdultAtHome.TabIndex = 28
        '
        'txtDVDNormAtHome
        '
        Me.txtDVDNormAtHome.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_home_norm"))
        Me.txtDVDNormAtHome.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDVDNormAtHome.Enabled = False
        Me.txtDVDNormAtHome.Location = New System.Drawing.Point(152, 136)
        Me.txtDVDNormAtHome.Name = "txtDVDNormAtHome"
        '
        'txtDVDNormAtHome.Properties
        '
        Me.txtDVDNormAtHome.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDVDNormAtHome.Size = New System.Drawing.Size(72, 20)
        Me.txtDVDNormAtHome.TabIndex = 27
        '
        'txtDVDAdult
        '
        Me.txtDVDAdult.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_adult"))
        Me.txtDVDAdult.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDVDAdult.Enabled = False
        Me.txtDVDAdult.Location = New System.Drawing.Point(72, 160)
        Me.txtDVDAdult.Name = "txtDVDAdult"
        '
        'txtDVDAdult.Properties
        '
        Me.txtDVDAdult.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDVDAdult.Size = New System.Drawing.Size(72, 20)
        Me.txtDVDAdult.TabIndex = 26
        '
        'txtDVDNorm
        '
        Me.txtDVDNorm.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_norm"))
        Me.txtDVDNorm.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDVDNorm.Enabled = False
        Me.txtDVDNorm.Location = New System.Drawing.Point(72, 136)
        Me.txtDVDNorm.Name = "txtDVDNorm"
        '
        'txtDVDNorm.Properties
        '
        Me.txtDVDNorm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDVDNorm.Size = New System.Drawing.Size(72, 20)
        Me.txtDVDNorm.TabIndex = 25
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(8, 168)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(64, 14)
        Me.LabelControl19.TabIndex = 24
        Me.LabelControl19.Text = "ADULT"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(8, 144)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(64, 14)
        Me.LabelControl18.TabIndex = 23
        Me.LabelControl18.Text = "NORM"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(160, 120)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(64, 14)
        Me.LabelControl17.TabIndex = 22
        Me.LabelControl17.Text = "@Home"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(72, 120)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(64, 14)
        Me.LabelControl16.TabIndex = 21
        Me.LabelControl16.Text = "Asked"
        '
        'txtABOCredit
        '
        Me.txtABOCredit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_credit"))
        Me.txtABOCredit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtABOCredit.Enabled = False
        Me.txtABOCredit.Location = New System.Drawing.Point(72, 96)
        Me.txtABOCredit.Name = "txtABOCredit"
        '
        'txtABOCredit.Properties
        '
        Me.txtABOCredit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtABOCredit.Size = New System.Drawing.Size(152, 20)
        Me.txtABOCredit.TabIndex = 20
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(8, 104)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(64, 14)
        Me.LabelControl15.TabIndex = 19
        Me.LabelControl15.Text = "Credits"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(8, 80)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(64, 14)
        Me.LabelControl14.TabIndex = 18
        Me.LabelControl14.Text = "Validity"
        '
        'txtAbo_ValidityTo
        '
        Me.txtAbo_ValidityTo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_validityto"))
        Me.txtAbo_ValidityTo.EditValue = Nothing
        Me.txtAbo_ValidityTo.Enabled = False
        Me.txtAbo_ValidityTo.Location = New System.Drawing.Point(72, 72)
        Me.txtAbo_ValidityTo.Name = "txtAbo_ValidityTo"
        '
        'txtAbo_ValidityTo.Properties
        '
        Me.txtAbo_ValidityTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAbo_ValidityTo.Size = New System.Drawing.Size(152, 20)
        Me.txtAbo_ValidityTo.TabIndex = 17
        '
        'cmbABO
        '
        Me.cmbABO.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_type"))
        Me.cmbABO.Enabled = False
        Me.cmbABO.Location = New System.Drawing.Point(72, 24)
        Me.cmbABO.Name = "cmbABO"
        '
        'cmbABO.Properties
        '
        Me.cmbABO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbABO.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_id", "products_id", 75, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_model", "products_model", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_title", "products_title", 72, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbABO.Properties.DataSource = Me.objDS.products_abo
        Me.cmbABO.Properties.DisplayMember = "products_title"
        Me.cmbABO.Properties.NullText = ""
        Me.cmbABO.Properties.ValueMember = "products_id"
        Me.cmbABO.Size = New System.Drawing.Size(152, 20)
        Me.cmbABO.TabIndex = 15
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(8, 56)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(64, 14)
        Me.LabelControl13.TabIndex = 14
        Me.LabelControl13.Text = "Next ABO"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(8, 32)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(64, 14)
        Me.LabelControl12.TabIndex = 12
        Me.LabelControl12.Text = "ABO"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnStopAtReconduction)
        Me.PanelControl2.Controls.Add(Me.btnStopNow)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl2.Location = New System.Drawing.Point(887, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(160, 337)
        Me.PanelControl2.TabIndex = 4
        Me.PanelControl2.Text = "PanelControl2"
        '
        'btnStopAtReconduction
        '
        Me.btnStopAtReconduction.Location = New System.Drawing.Point(8, 32)
        Me.btnStopAtReconduction.Name = "btnStopAtReconduction"
        Me.btnStopAtReconduction.Size = New System.Drawing.Size(144, 23)
        Me.btnStopAtReconduction.TabIndex = 3
        Me.btnStopAtReconduction.Text = "Stop @ Reconduction"
        '
        'btnStopNow
        '
        Me.btnStopNow.Location = New System.Drawing.Point(8, 8)
        Me.btnStopNow.Name = "btnStopNow"
        Me.btnStopNow.Size = New System.Drawing.Size(144, 23)
        Me.btnStopNow.TabIndex = 2
        Me.btnStopNow.Text = "Stop NOW"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txtDeliveryFirstName)
        Me.GroupControl2.Controls.Add(Me.txtDeliveryLastName)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.cmbDeliveryCountry)
        Me.GroupControl2.Controls.Add(Me.txtDeliveryCity)
        Me.GroupControl2.Controls.Add(Me.txtDeliveryPostCode)
        Me.GroupControl2.Controls.Add(Me.txtDeliveryAddr)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Location = New System.Drawing.Point(24, 168)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(608, 128)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Default Delivery Address"
        '
        'txtDeliveryFirstName
        '
        Me.txtDeliveryFirstName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_firstname"))
        Me.txtDeliveryFirstName.Enabled = False
        Me.txtDeliveryFirstName.Location = New System.Drawing.Point(384, 24)
        Me.txtDeliveryFirstName.Name = "txtDeliveryFirstName"
        Me.txtDeliveryFirstName.Size = New System.Drawing.Size(208, 20)
        Me.txtDeliveryFirstName.TabIndex = 17
        '
        'txtDeliveryLastName
        '
        Me.txtDeliveryLastName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_lastname"))
        Me.txtDeliveryLastName.Enabled = False
        Me.txtDeliveryLastName.Location = New System.Drawing.Point(152, 24)
        Me.txtDeliveryLastName.Name = "txtDeliveryLastName"
        Me.txtDeliveryLastName.Size = New System.Drawing.Size(224, 20)
        Me.txtDeliveryLastName.TabIndex = 16
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(16, 32)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(136, 14)
        Me.LabelControl10.TabIndex = 15
        Me.LabelControl10.Text = "Name"
        '
        'cmbDeliveryCountry
        '
        Me.cmbDeliveryCountry.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_country_id"))
        Me.cmbDeliveryCountry.Enabled = False
        Me.cmbDeliveryCountry.Location = New System.Drawing.Point(152, 96)
        Me.cmbDeliveryCountry.Name = "cmbDeliveryCountry"
        '
        'cmbDeliveryCountry.Properties
        '
        Me.cmbDeliveryCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDeliveryCountry.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("countries_id", "countries_id", 77, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("countries_name", "countries_name", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbDeliveryCountry.Properties.DataSource = Me.objDS.country
        Me.cmbDeliveryCountry.Properties.DisplayMember = "countries_name"
        Me.cmbDeliveryCountry.Properties.NullText = ""
        Me.cmbDeliveryCountry.Properties.ValueMember = "countries_id"
        Me.cmbDeliveryCountry.Size = New System.Drawing.Size(440, 20)
        Me.cmbDeliveryCountry.TabIndex = 14
        '
        'txtDeliveryCity
        '
        Me.txtDeliveryCity.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_city"))
        Me.txtDeliveryCity.Enabled = False
        Me.txtDeliveryCity.Location = New System.Drawing.Point(280, 72)
        Me.txtDeliveryCity.Name = "txtDeliveryCity"
        Me.txtDeliveryCity.Size = New System.Drawing.Size(312, 20)
        Me.txtDeliveryCity.TabIndex = 13
        '
        'txtDeliveryPostCode
        '
        Me.txtDeliveryPostCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_postcode"))
        Me.txtDeliveryPostCode.Enabled = False
        Me.txtDeliveryPostCode.Location = New System.Drawing.Point(152, 72)
        Me.txtDeliveryPostCode.Name = "txtDeliveryPostCode"
        Me.txtDeliveryPostCode.Size = New System.Drawing.Size(120, 20)
        Me.txtDeliveryPostCode.TabIndex = 12
        '
        'txtDeliveryAddr
        '
        Me.txtDeliveryAddr.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_street_address"))
        Me.txtDeliveryAddr.Enabled = False
        Me.txtDeliveryAddr.Location = New System.Drawing.Point(152, 48)
        Me.txtDeliveryAddr.Name = "txtDeliveryAddr"
        Me.txtDeliveryAddr.Size = New System.Drawing.Size(440, 20)
        Me.txtDeliveryAddr.TabIndex = 10
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(16, 56)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(136, 14)
        Me.LabelControl9.TabIndex = 8
        Me.LabelControl9.Text = "Address"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtEMail)
        Me.GroupControl1.Controls.Add(Me.txtTelEvening)
        Me.GroupControl1.Controls.Add(Me.txtTel)
        Me.GroupControl1.Controls.Add(Me.LabelControl21)
        Me.GroupControl1.Controls.Add(Me.txtABO)
        Me.GroupControl1.Controls.Add(Me.LabelControl20)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.txtFirstName)
        Me.GroupControl1.Controls.Add(Me.txtLastName)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txtCustomers_id)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Location = New System.Drawing.Point(24, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(608, 152)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Global Info"
        '
        'txtEMail
        '
        Me.txtEMail.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_email_address"))
        Me.txtEMail.Location = New System.Drawing.Point(144, 72)
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(440, 20)
        Me.txtEMail.TabIndex = 19
        '
        'txtTelEvening
        '
        Me.txtTelEvening.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_telephone_evening"))
        Me.txtTelEvening.Enabled = False
        Me.txtTelEvening.Location = New System.Drawing.Point(376, 96)
        Me.txtTelEvening.Name = "txtTelEvening"
        Me.txtTelEvening.Size = New System.Drawing.Size(208, 20)
        Me.txtTelEvening.TabIndex = 18
        '
        'txtTel
        '
        Me.txtTel.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_telephone"))
        Me.txtTel.Enabled = False
        Me.txtTel.Location = New System.Drawing.Point(144, 96)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(224, 20)
        Me.txtTel.TabIndex = 17
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(8, 104)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(136, 14)
        Me.LabelControl21.TabIndex = 16
        Me.LabelControl21.Text = "Tel Day / Evening"
        '
        'txtABO
        '
        Me.txtABO.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo"))
        Me.txtABO.Location = New System.Drawing.Point(528, 24)
        Me.txtABO.Name = "txtABO"
        '
        'txtABO.Properties
        '
        Me.txtABO.Properties.Appearance.BackColor = System.Drawing.Color.RosyBrown
        Me.txtABO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtABO.Properties.Appearance.Options.UseBackColor = True
        Me.txtABO.Properties.Appearance.Options.UseFont = True
        Me.txtABO.Properties.Caption = "ABO"
        Me.txtABO.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtABO.Properties.ValueChecked = 1
        Me.txtABO.Properties.ValueUnchecked = 0
        Me.txtABO.Size = New System.Drawing.Size(56, 21)
        Me.txtABO.TabIndex = 15
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(8, 80)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(136, 14)
        Me.LabelControl20.TabIndex = 12
        Me.LabelControl20.Text = "EMail"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(8, 128)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(136, 14)
        Me.LabelControl11.TabIndex = 11
        Me.LabelControl11.Text = "Date of Birth"
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_dob"))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Enabled = False
        Me.DateEdit1.Location = New System.Drawing.Point(144, 120)
        Me.DateEdit1.Name = "DateEdit1"
        '
        'DateEdit1.Properties
        '
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "dddd dd MMM yyyy"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit1.Size = New System.Drawing.Size(224, 20)
        Me.DateEdit1.TabIndex = 10
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_firstname"))
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Location = New System.Drawing.Point(376, 48)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(208, 20)
        Me.txtFirstName.TabIndex = 9
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_lastname"))
        Me.txtLastName.Enabled = False
        Me.txtLastName.Location = New System.Drawing.Point(144, 48)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(224, 20)
        Me.txtLastName.TabIndex = 7
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(8, 56)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(136, 14)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Name"
        '
        'txtCustomers_id
        '
        Me.txtCustomers_id.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_id"))
        Me.txtCustomers_id.Enabled = False
        Me.txtCustomers_id.Location = New System.Drawing.Point(144, 24)
        Me.txtCustomers_id.Name = "txtCustomers_id"
        '
        'txtCustomers_id.Properties
        '
        Me.txtCustomers_id.Properties.ReadOnly = True
        Me.txtCustomers_id.Size = New System.Drawing.Size(128, 20)
        Me.txtCustomers_id.TabIndex = 5
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(8, 32)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(136, 14)
        Me.LabelControl8.TabIndex = 4
        Me.LabelControl8.Text = "Customer ID"
        '
        'tabSearch
        '
        Me.tabSearch.Controls.Add(Me.GridControl1)
        Me.tabSearch.Controls.Add(Me.PanelControl1)
        Me.tabSearch.Name = "tabSearch"
        Me.tabSearch.Size = New System.Drawing.Size(1047, 337)
        Me.tabSearch.Text = "Search"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.objDS.customers_search_result
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 176)
        Me.GridControl1.MainView = Me.GridViewSearch
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(1047, 161)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSearch})
        '
        'GridViewSearch
        '
        Me.GridViewSearch.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridViewSearch.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colcustomers_id, Me.colcustomers_firstname, Me.colcustomers_lastname, Me.colcustomers_email_address, Me.colcustomers_abo, Me.colblack_listed, Me.colentry_street_address, Me.colentry_postcode, Me.coldomiciliation_number})
        Me.GridViewSearch.GridControl = Me.GridControl1
        Me.GridViewSearch.Name = "GridViewSearch"
        Me.GridViewSearch.OptionsBehavior.Editable = False
        Me.GridViewSearch.OptionsView.ShowAutoFilterRow = True
        Me.GridViewSearch.OptionsView.ShowBands = False
        Me.GridViewSearch.OptionsView.ShowFooter = True
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colcustomers_id)
        Me.GridBand1.Columns.Add(Me.colcustomers_firstname)
        Me.GridBand1.Columns.Add(Me.colcustomers_lastname)
        Me.GridBand1.Columns.Add(Me.colcustomers_email_address)
        Me.GridBand1.Columns.Add(Me.colcustomers_abo)
        Me.GridBand1.Columns.Add(Me.colblack_listed)
        Me.GridBand1.Columns.Add(Me.colentry_street_address)
        Me.GridBand1.Columns.Add(Me.colentry_postcode)
        Me.GridBand1.Columns.Add(Me.coldomiciliation_number)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 990
        '
        'colcustomers_id
        '
        Me.colcustomers_id.Caption = "customers_id"
        Me.colcustomers_id.FieldName = "customers_id"
        Me.colcustomers_id.Name = "colcustomers_id"
        Me.colcustomers_id.Visible = True
        Me.colcustomers_id.Width = 85
        '
        'colcustomers_firstname
        '
        Me.colcustomers_firstname.Caption = "customers_firstname"
        Me.colcustomers_firstname.FieldName = "customers_firstname"
        Me.colcustomers_firstname.Name = "colcustomers_firstname"
        Me.colcustomers_firstname.Visible = True
        Me.colcustomers_firstname.Width = 122
        '
        'colcustomers_lastname
        '
        Me.colcustomers_lastname.Caption = "customers_lastname"
        Me.colcustomers_lastname.FieldName = "customers_lastname"
        Me.colcustomers_lastname.Name = "colcustomers_lastname"
        Me.colcustomers_lastname.Visible = True
        Me.colcustomers_lastname.Width = 120
        '
        'colcustomers_email_address
        '
        Me.colcustomers_email_address.Caption = "customers_email_address"
        Me.colcustomers_email_address.FieldName = "customers_email_address"
        Me.colcustomers_email_address.Name = "colcustomers_email_address"
        Me.colcustomers_email_address.Visible = True
        Me.colcustomers_email_address.Width = 145
        '
        'colcustomers_abo
        '
        Me.colcustomers_abo.Caption = "customers_abo"
        Me.colcustomers_abo.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colcustomers_abo.FieldName = "customers_abo"
        Me.colcustomers_abo.Name = "colcustomers_abo"
        Me.colcustomers_abo.Visible = True
        Me.colcustomers_abo.Width = 95
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = 1
        Me.RepositoryItemCheckEdit1.ValueUnchecked = 0
        '
        'colblack_listed
        '
        Me.colblack_listed.Caption = "black_listed"
        Me.colblack_listed.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colblack_listed.FieldName = "black_listed"
        Me.colblack_listed.Name = "colblack_listed"
        Me.colblack_listed.Visible = True
        Me.colblack_listed.Width = 77
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.ValueChecked = 1
        Me.RepositoryItemCheckEdit2.ValueUnchecked = 0
        '
        'colentry_street_address
        '
        Me.colentry_street_address.Caption = "entry_street_address"
        Me.colentry_street_address.FieldName = "entry_street_address"
        Me.colentry_street_address.Name = "colentry_street_address"
        Me.colentry_street_address.Visible = True
        Me.colentry_street_address.Width = 127
        '
        'colentry_postcode
        '
        Me.colentry_postcode.Caption = "entry_postcode"
        Me.colentry_postcode.FieldName = "entry_postcode"
        Me.colentry_postcode.Name = "colentry_postcode"
        Me.colentry_postcode.Visible = True
        Me.colentry_postcode.Width = 98
        '
        'coldomiciliation_number
        '
        Me.coldomiciliation_number.Caption = "domiciliation_number"
        Me.coldomiciliation_number.FieldName = "domiciliation_number"
        Me.coldomiciliation_number.Name = "coldomiciliation_number"
        Me.coldomiciliation_number.Visible = True
        Me.coldomiciliation_number.Width = 121
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtcustomers_postcode_search)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.btnSearch)
        Me.PanelControl1.Controls.Add(Me.txtcustomers_address_street_search)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtcustomers_domiciliation_number_search)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txtcustomers_email_address_search)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txtcustomers_name_search)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txtcustomers_id_search)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1047, 176)
        Me.PanelControl1.TabIndex = 0
        Me.PanelControl1.Text = "PanelControl1"
        '
        'txtcustomers_postcode_search
        '
        Me.txtcustomers_postcode_search.Location = New System.Drawing.Point(160, 136)
        Me.txtcustomers_postcode_search.Name = "txtcustomers_postcode_search"
        Me.txtcustomers_postcode_search.Size = New System.Drawing.Size(272, 20)
        Me.txtcustomers_postcode_search.TabIndex = 12
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(24, 144)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(136, 14)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "PostCode"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(448, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "&Search"
        '
        'txtcustomers_address_street_search
        '
        Me.txtcustomers_address_street_search.Location = New System.Drawing.Point(160, 112)
        Me.txtcustomers_address_street_search.Name = "txtcustomers_address_street_search"
        Me.txtcustomers_address_street_search.Size = New System.Drawing.Size(272, 20)
        Me.txtcustomers_address_street_search.TabIndex = 9
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(24, 120)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(136, 14)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Street"
        '
        'txtcustomers_domiciliation_number_search
        '
        Me.txtcustomers_domiciliation_number_search.Location = New System.Drawing.Point(160, 88)
        Me.txtcustomers_domiciliation_number_search.Name = "txtcustomers_domiciliation_number_search"
        Me.txtcustomers_domiciliation_number_search.Size = New System.Drawing.Size(272, 20)
        Me.txtcustomers_domiciliation_number_search.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(24, 96)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(136, 14)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Domiciliation Nbr"
        '
        'txtcustomers_email_address_search
        '
        Me.txtcustomers_email_address_search.Location = New System.Drawing.Point(160, 64)
        Me.txtcustomers_email_address_search.Name = "txtcustomers_email_address_search"
        Me.txtcustomers_email_address_search.Size = New System.Drawing.Size(272, 20)
        Me.txtcustomers_email_address_search.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(24, 72)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(136, 14)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Part of E-Mail"
        '
        'txtcustomers_name_search
        '
        Me.txtcustomers_name_search.Location = New System.Drawing.Point(160, 40)
        Me.txtcustomers_name_search.Name = "txtcustomers_name_search"
        Me.txtcustomers_name_search.Size = New System.Drawing.Size(272, 20)
        Me.txtcustomers_name_search.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(24, 48)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(136, 14)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Part of Name"
        '
        'txtcustomers_id_search
        '
        Me.txtcustomers_id_search.Location = New System.Drawing.Point(160, 16)
        Me.txtcustomers_id_search.Name = "txtcustomers_id_search"
        Me.txtcustomers_id_search.Size = New System.Drawing.Size(272, 20)
        Me.txtcustomers_id_search.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(136, 14)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Customer ID"
        '
        'tabWishList
        '
        Me.tabWishList.Controls.Add(Me.GroupControl4)
        Me.tabWishList.Controls.Add(Me.SplitterControl1)
        Me.tabWishList.Controls.Add(Me.GridWishList)
        Me.tabWishList.Name = "tabWishList"
        Me.tabWishList.Size = New System.Drawing.Size(1047, 337)
        Me.tabWishList.Text = "WishList"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.GridWishListAssigned)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(584, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(463, 337)
        Me.GroupControl4.TabIndex = 3
        Me.GroupControl4.Text = "DVD Already Assigned"
        '
        'GridWishListAssigned
        '
        Me.GridWishListAssigned.DataSource = Me.objDS.wishlist_assigned_view1
        Me.GridWishListAssigned.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'GridWishListAssigned.EmbeddedNavigator
        '
        Me.GridWishListAssigned.EmbeddedNavigator.Name = ""
        Me.GridWishListAssigned.Location = New System.Drawing.Point(2, 20)
        Me.GridWishListAssigned.MainView = Me.GridViewWishListAssigned
        Me.GridWishListAssigned.Name = "GridWishListAssigned"
        Me.GridWishListAssigned.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1})
        Me.GridWishListAssigned.Size = New System.Drawing.Size(459, 315)
        Me.GridWishListAssigned.TabIndex = 2
        Me.GridWishListAssigned.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewWishListAssigned})
        '
        'GridViewWishListAssigned
        '
        Me.GridViewWishListAssigned.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand3})
        Me.GridViewWishListAssigned.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colwl_assigned_id, Me.colwl_id1, Me.colcustomers_id2, Me.colproducts_id, Me.colrank1, Me.coldate_added1, Me.coldate_assigned, Me.colwishlist_type1, Me.colproducts_title1})
        Me.GridViewWishListAssigned.CustomizationFormBounds = New System.Drawing.Rectangle(883, 417, 208, 191)
        Me.GridViewWishListAssigned.GridControl = Me.GridWishListAssigned
        Me.GridViewWishListAssigned.GroupCount = 1
        Me.GridViewWishListAssigned.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "wishlist_type", Nothing, "")})
        Me.GridViewWishListAssigned.Name = "GridViewWishListAssigned"
        Me.GridViewWishListAssigned.OptionsView.ShowBands = False
        Me.GridViewWishListAssigned.OptionsView.ShowFooter = True
        Me.GridViewWishListAssigned.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colwishlist_type1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "GridBand2"
        Me.GridBand3.Columns.Add(Me.colwishlist_type1)
        Me.GridBand3.Columns.Add(Me.colwl_assigned_id)
        Me.GridBand3.Columns.Add(Me.colwl_id1)
        Me.GridBand3.Columns.Add(Me.colcustomers_id2)
        Me.GridBand3.Columns.Add(Me.colproducts_id)
        Me.GridBand3.Columns.Add(Me.colrank1)
        Me.GridBand3.Columns.Add(Me.coldate_added1)
        Me.GridBand3.Columns.Add(Me.coldate_assigned)
        Me.GridBand3.Columns.Add(Me.colproducts_title1)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 455
        '
        'colwishlist_type1
        '
        Me.colwishlist_type1.Caption = "wishlist_type"
        Me.colwishlist_type1.FieldName = "wishlist_type"
        Me.colwishlist_type1.Name = "colwishlist_type1"
        Me.colwishlist_type1.OptionsColumn.ReadOnly = True
        Me.colwishlist_type1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colwishlist_type1.Visible = True
        '
        'colwl_assigned_id
        '
        Me.colwl_assigned_id.Caption = "wl_assigned_id"
        Me.colwl_assigned_id.FieldName = "wl_assigned_id"
        Me.colwl_assigned_id.Name = "colwl_assigned_id"
        Me.colwl_assigned_id.OptionsColumn.ReadOnly = True
        '
        'colwl_id1
        '
        Me.colwl_id1.Caption = "wl_id"
        Me.colwl_id1.FieldName = "wl_id"
        Me.colwl_id1.Name = "colwl_id1"
        Me.colwl_id1.OptionsColumn.ReadOnly = True
        '
        'colcustomers_id2
        '
        Me.colcustomers_id2.Caption = "customers_id"
        Me.colcustomers_id2.FieldName = "customers_id"
        Me.colcustomers_id2.Name = "colcustomers_id2"
        Me.colcustomers_id2.OptionsColumn.ReadOnly = True
        '
        'colproducts_id
        '
        Me.colproducts_id.Caption = "products_id"
        Me.colproducts_id.FieldName = "products_id"
        Me.colproducts_id.Name = "colproducts_id"
        Me.colproducts_id.OptionsColumn.ReadOnly = True
        Me.colproducts_id.Visible = True
        Me.colproducts_id.Width = 80
        '
        'colrank1
        '
        Me.colrank1.Caption = "rank"
        Me.colrank1.FieldName = "rank"
        Me.colrank1.Name = "colrank1"
        Me.colrank1.OptionsColumn.ReadOnly = True
        Me.colrank1.Visible = True
        '
        'coldate_added1
        '
        Me.coldate_added1.Caption = "date_added"
        Me.coldate_added1.FieldName = "date_added"
        Me.coldate_added1.Name = "coldate_added1"
        Me.coldate_added1.OptionsColumn.ReadOnly = True
        Me.coldate_added1.Visible = True
        '
        'coldate_assigned
        '
        Me.coldate_assigned.Caption = "date_assigned"
        Me.coldate_assigned.FieldName = "date_assigned"
        Me.coldate_assigned.Name = "coldate_assigned"
        Me.coldate_assigned.OptionsColumn.ReadOnly = True
        Me.coldate_assigned.Visible = True
        '
        'colproducts_title1
        '
        Me.colproducts_title1.Caption = "products_title"
        Me.colproducts_title1.FieldName = "products_title"
        Me.colproducts_title1.Name = "colproducts_title1"
        Me.colproducts_title1.OptionsColumn.ReadOnly = True
        Me.colproducts_title1.Visible = True
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(576, 0)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(8, 337)
        Me.SplitterControl1.TabIndex = 1
        Me.SplitterControl1.TabStop = False
        '
        'GridWishList
        '
        Me.GridWishList.DataSource = Me.objDS.wishlist_view1
        Me.GridWishList.Dock = System.Windows.Forms.DockStyle.Left
        '
        'GridWishList.EmbeddedNavigator
        '
        Me.GridWishList.EmbeddedNavigator.Name = ""
        Me.GridWishList.Location = New System.Drawing.Point(0, 0)
        Me.GridWishList.MainView = Me.GridViewWishList
        Me.GridWishList.Name = "GridWishList"
        Me.GridWishList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnSendIt})
        Me.GridWishList.Size = New System.Drawing.Size(576, 337)
        Me.GridWishList.TabIndex = 0
        Me.GridWishList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewWishList})
        '
        'GridViewWishList
        '
        Me.GridViewWishList.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.GridViewWishList.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colwl_id, Me.colcustomers_id1, Me.colproduct_id, Me.colrank, Me.colpriority, Me.coldate_added, Me.colwishlist_type, Me.colproducts_title, Me.colqty_in_stock, Me.colSendIt})
        Me.GridViewWishList.CustomizationFormBounds = New System.Drawing.Rectangle(883, 417, 208, 191)
        Me.GridViewWishList.GridControl = Me.GridWishList
        Me.GridViewWishList.GroupCount = 1
        Me.GridViewWishList.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "wishlist_type", Nothing, "")})
        Me.GridViewWishList.Name = "GridViewWishList"
        Me.GridViewWishList.OptionsView.ShowBands = False
        Me.GridViewWishList.OptionsView.ShowFooter = True
        Me.GridViewWishList.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colwishlist_type, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "GridBand2"
        Me.GridBand2.Columns.Add(Me.colSendIt)
        Me.GridBand2.Columns.Add(Me.colwishlist_type)
        Me.GridBand2.Columns.Add(Me.colwl_id)
        Me.GridBand2.Columns.Add(Me.colcustomers_id1)
        Me.GridBand2.Columns.Add(Me.colproduct_id)
        Me.GridBand2.Columns.Add(Me.colrank)
        Me.GridBand2.Columns.Add(Me.colpriority)
        Me.GridBand2.Columns.Add(Me.coldate_added)
        Me.GridBand2.Columns.Add(Me.colproducts_title)
        Me.GridBand2.Columns.Add(Me.colqty_in_stock)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 627
        '
        'colSendIt
        '
        Me.colSendIt.Caption = "Send It"
        Me.colSendIt.ColumnEdit = Me.btnSendIt
        Me.colSendIt.Name = "colSendIt"
        Me.colSendIt.Visible = True
        '
        'btnSendIt
        '
        Me.btnSendIt.AutoHeight = False
        Me.btnSendIt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.btnSendIt.Name = "btnSendIt"
        Me.btnSendIt.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colwishlist_type
        '
        Me.colwishlist_type.Caption = "wishlist_type"
        Me.colwishlist_type.FieldName = "wishlist_type"
        Me.colwishlist_type.Name = "colwishlist_type"
        Me.colwishlist_type.OptionsColumn.ReadOnly = True
        Me.colwishlist_type.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colwishlist_type.Visible = True
        Me.colwishlist_type.Width = 89
        '
        'colwl_id
        '
        Me.colwl_id.Caption = "wl_id"
        Me.colwl_id.FieldName = "wl_id"
        Me.colwl_id.Name = "colwl_id"
        Me.colwl_id.OptionsColumn.ReadOnly = True
        '
        'colcustomers_id1
        '
        Me.colcustomers_id1.Caption = "customers_id"
        Me.colcustomers_id1.FieldName = "customers_id"
        Me.colcustomers_id1.Name = "colcustomers_id1"
        Me.colcustomers_id1.OptionsColumn.ReadOnly = True
        '
        'colproduct_id
        '
        Me.colproduct_id.Caption = "product_id"
        Me.colproduct_id.FieldName = "product_id"
        Me.colproduct_id.Name = "colproduct_id"
        Me.colproduct_id.OptionsColumn.ReadOnly = True
        Me.colproduct_id.Visible = True
        Me.colproduct_id.Width = 68
        '
        'colrank
        '
        Me.colrank.Caption = "rank"
        Me.colrank.FieldName = "rank"
        Me.colrank.Name = "colrank"
        Me.colrank.OptionsColumn.ReadOnly = True
        Me.colrank.Visible = True
        Me.colrank.Width = 44
        '
        'colpriority
        '
        Me.colpriority.Caption = "priority"
        Me.colpriority.FieldName = "priority"
        Me.colpriority.Name = "colpriority"
        Me.colpriority.OptionsColumn.ReadOnly = True
        Me.colpriority.Visible = True
        Me.colpriority.Width = 57
        '
        'coldate_added
        '
        Me.coldate_added.Caption = "date_added"
        Me.coldate_added.FieldName = "date_added"
        Me.coldate_added.Name = "coldate_added"
        Me.coldate_added.OptionsColumn.ReadOnly = True
        Me.coldate_added.Visible = True
        '
        'colproducts_title
        '
        Me.colproducts_title.Caption = "products_title"
        Me.colproducts_title.FieldName = "products_title"
        Me.colproducts_title.Name = "colproducts_title"
        Me.colproducts_title.OptionsColumn.ReadOnly = True
        Me.colproducts_title.Visible = True
        Me.colproducts_title.Width = 144
        '
        'colqty_in_stock
        '
        Me.colqty_in_stock.Caption = "qty_in_stock"
        Me.colqty_in_stock.FieldName = "qty_in_stock"
        Me.colqty_in_stock.Name = "colqty_in_stock"
        Me.colqty_in_stock.OptionsColumn.ReadOnly = True
        Me.colqty_in_stock.Visible = True
        '
        'tabAboHistory
        '
        Me.tabAboHistory.Controls.Add(Me.GridABO)
        Me.tabAboHistory.Name = "tabAboHistory"
        Me.tabAboHistory.Size = New System.Drawing.Size(1047, 337)
        Me.tabAboHistory.Text = "ABO History"
        '
        'GridABO
        '
        Me.GridABO.DataSource = Me.objDS.abo
        Me.GridABO.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'GridABO.EmbeddedNavigator
        '
        Me.GridABO.EmbeddedNavigator.Name = ""
        Me.GridABO.Location = New System.Drawing.Point(0, 0)
        Me.GridABO.MainView = Me.GridViewABO
        Me.GridABO.Name = "GridABO"
        Me.GridABO.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbABO_Action})
        Me.GridABO.Size = New System.Drawing.Size(1047, 337)
        Me.GridABO.TabIndex = 0
        Me.GridABO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewABO})
        '
        'GridViewABO
        '
        Me.GridViewABO.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand4})
        Me.GridViewABO.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colabo_id, Me.colcustomerid, Me.colAction, Me.colcode_id, Me.colDate, Me.colproduct_id1, Me.colpayment_method, Me.colprivilege_notified, Me.colcomment, Me.colsite})
        Me.GridViewABO.GridControl = Me.GridABO
        Me.GridViewABO.Name = "GridViewABO"
        Me.GridViewABO.OptionsView.ShowBands = False
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "GridBand4"
        Me.GridBand4.Columns.Add(Me.colabo_id)
        Me.GridBand4.Columns.Add(Me.colcustomerid)
        Me.GridBand4.Columns.Add(Me.colAction)
        Me.GridBand4.Columns.Add(Me.colcode_id)
        Me.GridBand4.Columns.Add(Me.colDate)
        Me.GridBand4.Columns.Add(Me.colproduct_id1)
        Me.GridBand4.Columns.Add(Me.colpayment_method)
        Me.GridBand4.Columns.Add(Me.colprivilege_notified)
        Me.GridBand4.Columns.Add(Me.colcomment)
        Me.GridBand4.Columns.Add(Me.colsite)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 750
        '
        'colabo_id
        '
        Me.colabo_id.Caption = "abo_id"
        Me.colabo_id.FieldName = "abo_id"
        Me.colabo_id.Name = "colabo_id"
        Me.colabo_id.OptionsColumn.ReadOnly = True
        Me.colabo_id.Visible = True
        '
        'colcustomerid
        '
        Me.colcustomerid.Caption = "customerid"
        Me.colcustomerid.FieldName = "customerid"
        Me.colcustomerid.Name = "colcustomerid"
        Me.colcustomerid.OptionsColumn.ReadOnly = True
        Me.colcustomerid.Visible = True
        '
        'colAction
        '
        Me.colAction.Caption = "Action"
        Me.colAction.ColumnEdit = Me.cmbABO_Action
        Me.colAction.FieldName = "Action"
        Me.colAction.Name = "colAction"
        Me.colAction.OptionsColumn.ReadOnly = True
        Me.colAction.Visible = True
        '
        'cmbABO_Action
        '
        Me.cmbABO_Action.AutoHeight = False
        Me.cmbABO_Action.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbABO_Action.DataSource = Me.objDS.abo_action
        Me.cmbABO_Action.DisplayMember = "name"
        Me.cmbABO_Action.Name = "cmbABO_Action"
        Me.cmbABO_Action.NullText = ""
        Me.cmbABO_Action.ValueMember = "id"
        '
        'colcode_id
        '
        Me.colcode_id.Caption = "code_id"
        Me.colcode_id.FieldName = "code_id"
        Me.colcode_id.Name = "colcode_id"
        Me.colcode_id.OptionsColumn.ReadOnly = True
        Me.colcode_id.Visible = True
        '
        'colDate
        '
        Me.colDate.Caption = "Date"
        Me.colDate.FieldName = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.OptionsColumn.ReadOnly = True
        Me.colDate.Visible = True
        '
        'colproduct_id1
        '
        Me.colproduct_id1.Caption = "product_id"
        Me.colproduct_id1.FieldName = "product_id"
        Me.colproduct_id1.Name = "colproduct_id1"
        Me.colproduct_id1.OptionsColumn.ReadOnly = True
        Me.colproduct_id1.Visible = True
        '
        'colpayment_method
        '
        Me.colpayment_method.Caption = "payment_method"
        Me.colpayment_method.FieldName = "payment_method"
        Me.colpayment_method.Name = "colpayment_method"
        Me.colpayment_method.OptionsColumn.ReadOnly = True
        Me.colpayment_method.Visible = True
        '
        'colprivilege_notified
        '
        Me.colprivilege_notified.Caption = "privilege_notified"
        Me.colprivilege_notified.FieldName = "privilege_notified"
        Me.colprivilege_notified.Name = "colprivilege_notified"
        Me.colprivilege_notified.OptionsColumn.ReadOnly = True
        Me.colprivilege_notified.Visible = True
        '
        'colcomment
        '
        Me.colcomment.Caption = "comment"
        Me.colcomment.FieldName = "comment"
        Me.colcomment.Name = "colcomment"
        Me.colcomment.OptionsColumn.ReadOnly = True
        Me.colcomment.Visible = True
        '
        'colsite
        '
        Me.colsite.Caption = "site"
        Me.colsite.FieldName = "site"
        Me.colsite.Name = "colsite"
        Me.colsite.OptionsColumn.ReadOnly = True
        Me.colsite.Visible = True
        '
        'tabOrdersHistor
        '
        Me.tabOrdersHistor.Controls.Add(Me.GroupControl6)
        Me.tabOrdersHistor.Controls.Add(Me.SplitterControl2)
        Me.tabOrdersHistor.Controls.Add(Me.GroupControl5)
        Me.tabOrdersHistor.Name = "tabOrdersHistor"
        Me.tabOrdersHistor.Size = New System.Drawing.Size(1047, 337)
        Me.tabOrdersHistor.Text = "Orders History"
        '
        'GroupControl6
        '
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl6.Location = New System.Drawing.Point(632, 0)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(415, 337)
        Me.GroupControl6.TabIndex = 2
        Me.GroupControl6.Text = "Orders Detail"
        '
        'SplitterControl2
        '
        Me.SplitterControl2.Location = New System.Drawing.Point(624, 0)
        Me.SplitterControl2.Name = "SplitterControl2"
        Me.SplitterControl2.Size = New System.Drawing.Size(8, 337)
        Me.SplitterControl2.TabIndex = 1
        Me.SplitterControl2.TabStop = False
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.GridOrders)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl5.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(624, 337)
        Me.GroupControl5.TabIndex = 0
        Me.GroupControl5.Text = "Orders"
        '
        'GridOrders
        '
        Me.GridOrders.DataSource = Me.objDS.Customers_Orders_View1
        Me.GridOrders.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'GridOrders.EmbeddedNavigator
        '
        Me.GridOrders.EmbeddedNavigator.Name = ""
        Me.GridOrders.Location = New System.Drawing.Point(2, 20)
        Me.GridOrders.MainView = Me.GridViewOrders
        Me.GridOrders.Name = "GridOrders"
        Me.GridOrders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbOrders_Status})
        Me.GridOrders.Size = New System.Drawing.Size(620, 315)
        Me.GridOrders.TabIndex = 1
        Me.GridOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewOrders})
        '
        'GridViewOrders
        '
        Me.GridViewOrders.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand5})
        Me.GridViewOrders.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colorders_id, Me.colcustomers_id3, Me.colcustomers_name, Me.colcustomers_street_address, Me.colcustomers_suburb, Me.colcustomers_city, Me.colcustomers_postcode, Me.colcustomers_state, Me.colcustomers_country, Me.colcustomers_telephone, Me.colcustomers_email_address1, Me.colcustomers_address_format_id, Me.coldelivery_name, Me.coldelivery_street_address, Me.coldelivery_suburb, Me.coldelivery_city, Me.coldelivery_postcode, Me.coldelivery_state, Me.coldelivery_country, Me.coldelivery_address_format_id, Me.colpayment_method1, Me.colcc_type, Me.colcc_owner, Me.colcc_number, Me.colcc_expires, Me.coldate_purchased, Me.colorders_status, Me.colorders_date_finished, Me.collast_modified, Me.colcomments, Me.colcurrency, Me.colcurrency_value, Me.colsite1, Me.colsecured_mail, Me.colmultishipment_sm, Me.colorders_products_id, Me.colproducts_id1, Me.colproducts_model, Me.colproducts_name, Me.colproducts_price, Me.colfinal_price, Me.colproducts_tax, Me.colproducts_quantity, Me.colproducts_dvd, Me.colorders_products_status, Me.colfeesharing})
        Me.GridViewOrders.CustomizationFormBounds = New System.Drawing.Rectangle(671, 230, 217, 291)
        Me.GridViewOrders.GridControl = Me.GridOrders
        Me.GridViewOrders.Name = "GridViewOrders"
        Me.GridViewOrders.OptionsView.ShowBands = False
        '
        'GridBand5
        '
        Me.GridBand5.Caption = "GridBand4"
        Me.GridBand5.Columns.Add(Me.colorders_id)
        Me.GridBand5.Columns.Add(Me.coldate_purchased)
        Me.GridBand5.Columns.Add(Me.colorders_status)
        Me.GridBand5.Columns.Add(Me.colcustomers_id3)
        Me.GridBand5.Columns.Add(Me.colcustomers_name)
        Me.GridBand5.Columns.Add(Me.colcustomers_street_address)
        Me.GridBand5.Columns.Add(Me.colcustomers_suburb)
        Me.GridBand5.Columns.Add(Me.colcustomers_city)
        Me.GridBand5.Columns.Add(Me.colcustomers_postcode)
        Me.GridBand5.Columns.Add(Me.colcustomers_state)
        Me.GridBand5.Columns.Add(Me.colcustomers_country)
        Me.GridBand5.Columns.Add(Me.colcustomers_telephone)
        Me.GridBand5.Columns.Add(Me.colcustomers_email_address1)
        Me.GridBand5.Columns.Add(Me.colcustomers_address_format_id)
        Me.GridBand5.Columns.Add(Me.coldelivery_name)
        Me.GridBand5.Columns.Add(Me.coldelivery_street_address)
        Me.GridBand5.Columns.Add(Me.coldelivery_suburb)
        Me.GridBand5.Columns.Add(Me.coldelivery_city)
        Me.GridBand5.Columns.Add(Me.coldelivery_postcode)
        Me.GridBand5.Columns.Add(Me.coldelivery_state)
        Me.GridBand5.Columns.Add(Me.coldelivery_country)
        Me.GridBand5.Columns.Add(Me.coldelivery_address_format_id)
        Me.GridBand5.Columns.Add(Me.colpayment_method1)
        Me.GridBand5.Columns.Add(Me.colcc_type)
        Me.GridBand5.Columns.Add(Me.colcc_owner)
        Me.GridBand5.Columns.Add(Me.colcc_number)
        Me.GridBand5.Columns.Add(Me.colcc_expires)
        Me.GridBand5.Columns.Add(Me.colproducts_name)
        Me.GridBand5.Columns.Add(Me.colorders_date_finished)
        Me.GridBand5.Columns.Add(Me.collast_modified)
        Me.GridBand5.Columns.Add(Me.colcomments)
        Me.GridBand5.Columns.Add(Me.colcurrency)
        Me.GridBand5.Columns.Add(Me.colcurrency_value)
        Me.GridBand5.Columns.Add(Me.colsite1)
        Me.GridBand5.Columns.Add(Me.colsecured_mail)
        Me.GridBand5.Columns.Add(Me.colmultishipment_sm)
        Me.GridBand5.Columns.Add(Me.colorders_products_id)
        Me.GridBand5.Columns.Add(Me.colproducts_id1)
        Me.GridBand5.Columns.Add(Me.colproducts_model)
        Me.GridBand5.Columns.Add(Me.colproducts_dvd)
        Me.GridBand5.Columns.Add(Me.colproducts_price)
        Me.GridBand5.Columns.Add(Me.colfinal_price)
        Me.GridBand5.Columns.Add(Me.colproducts_tax)
        Me.GridBand5.Columns.Add(Me.colproducts_quantity)
        Me.GridBand5.Columns.Add(Me.colorders_products_status)
        Me.GridBand5.Columns.Add(Me.colfeesharing)
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.Width = 600
        '
        'colorders_id
        '
        Me.colorders_id.Caption = "orders_id"
        Me.colorders_id.FieldName = "orders_id"
        Me.colorders_id.Name = "colorders_id"
        Me.colorders_id.OptionsColumn.ReadOnly = True
        Me.colorders_id.Visible = True
        '
        'coldate_purchased
        '
        Me.coldate_purchased.Caption = "date_purchased"
        Me.coldate_purchased.FieldName = "date_purchased"
        Me.coldate_purchased.Name = "coldate_purchased"
        Me.coldate_purchased.OptionsColumn.ReadOnly = True
        Me.coldate_purchased.Visible = True
        '
        'colorders_status
        '
        Me.colorders_status.Caption = "orders_status"
        Me.colorders_status.ColumnEdit = Me.cmbOrders_Status
        Me.colorders_status.FieldName = "orders_status"
        Me.colorders_status.Name = "colorders_status"
        Me.colorders_status.OptionsColumn.ReadOnly = True
        Me.colorders_status.Visible = True
        '
        'cmbOrders_Status
        '
        Me.cmbOrders_Status.AutoHeight = False
        Me.cmbOrders_Status.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOrders_Status.DataSource = Me.objDS.orders_status
        Me.cmbOrders_Status.DisplayMember = "orders_status_name"
        Me.cmbOrders_Status.Name = "cmbOrders_Status"
        Me.cmbOrders_Status.NullText = ""
        Me.cmbOrders_Status.ValueMember = "orders_status_id"
        '
        'colcustomers_id3
        '
        Me.colcustomers_id3.Caption = "customers_id"
        Me.colcustomers_id3.FieldName = "customers_id"
        Me.colcustomers_id3.Name = "colcustomers_id3"
        Me.colcustomers_id3.OptionsColumn.ReadOnly = True
        Me.colcustomers_id3.Visible = True
        '
        'colcustomers_name
        '
        Me.colcustomers_name.Caption = "customers_name"
        Me.colcustomers_name.FieldName = "customers_name"
        Me.colcustomers_name.Name = "colcustomers_name"
        Me.colcustomers_name.OptionsColumn.ReadOnly = True
        '
        'colcustomers_street_address
        '
        Me.colcustomers_street_address.Caption = "customers_street_address"
        Me.colcustomers_street_address.FieldName = "customers_street_address"
        Me.colcustomers_street_address.Name = "colcustomers_street_address"
        Me.colcustomers_street_address.OptionsColumn.ReadOnly = True
        '
        'colcustomers_suburb
        '
        Me.colcustomers_suburb.Caption = "customers_suburb"
        Me.colcustomers_suburb.FieldName = "customers_suburb"
        Me.colcustomers_suburb.Name = "colcustomers_suburb"
        Me.colcustomers_suburb.OptionsColumn.ReadOnly = True
        '
        'colcustomers_city
        '
        Me.colcustomers_city.Caption = "customers_city"
        Me.colcustomers_city.FieldName = "customers_city"
        Me.colcustomers_city.Name = "colcustomers_city"
        Me.colcustomers_city.OptionsColumn.ReadOnly = True
        '
        'colcustomers_postcode
        '
        Me.colcustomers_postcode.Caption = "customers_postcode"
        Me.colcustomers_postcode.FieldName = "customers_postcode"
        Me.colcustomers_postcode.Name = "colcustomers_postcode"
        Me.colcustomers_postcode.OptionsColumn.ReadOnly = True
        '
        'colcustomers_state
        '
        Me.colcustomers_state.Caption = "customers_state"
        Me.colcustomers_state.FieldName = "customers_state"
        Me.colcustomers_state.Name = "colcustomers_state"
        Me.colcustomers_state.OptionsColumn.ReadOnly = True
        '
        'colcustomers_country
        '
        Me.colcustomers_country.Caption = "customers_country"
        Me.colcustomers_country.FieldName = "customers_country"
        Me.colcustomers_country.Name = "colcustomers_country"
        Me.colcustomers_country.OptionsColumn.ReadOnly = True
        '
        'colcustomers_telephone
        '
        Me.colcustomers_telephone.Caption = "customers_telephone"
        Me.colcustomers_telephone.FieldName = "customers_telephone"
        Me.colcustomers_telephone.Name = "colcustomers_telephone"
        Me.colcustomers_telephone.OptionsColumn.ReadOnly = True
        '
        'colcustomers_email_address1
        '
        Me.colcustomers_email_address1.Caption = "customers_email_address"
        Me.colcustomers_email_address1.FieldName = "customers_email_address"
        Me.colcustomers_email_address1.Name = "colcustomers_email_address1"
        Me.colcustomers_email_address1.OptionsColumn.ReadOnly = True
        '
        'colcustomers_address_format_id
        '
        Me.colcustomers_address_format_id.Caption = "customers_address_format_id"
        Me.colcustomers_address_format_id.FieldName = "customers_address_format_id"
        Me.colcustomers_address_format_id.Name = "colcustomers_address_format_id"
        Me.colcustomers_address_format_id.OptionsColumn.ReadOnly = True
        '
        'coldelivery_name
        '
        Me.coldelivery_name.Caption = "delivery_name"
        Me.coldelivery_name.FieldName = "delivery_name"
        Me.coldelivery_name.Name = "coldelivery_name"
        Me.coldelivery_name.OptionsColumn.ReadOnly = True
        Me.coldelivery_name.Visible = True
        '
        'coldelivery_street_address
        '
        Me.coldelivery_street_address.Caption = "delivery_street_address"
        Me.coldelivery_street_address.FieldName = "delivery_street_address"
        Me.coldelivery_street_address.Name = "coldelivery_street_address"
        Me.coldelivery_street_address.OptionsColumn.ReadOnly = True
        '
        'coldelivery_suburb
        '
        Me.coldelivery_suburb.Caption = "delivery_suburb"
        Me.coldelivery_suburb.FieldName = "delivery_suburb"
        Me.coldelivery_suburb.Name = "coldelivery_suburb"
        Me.coldelivery_suburb.OptionsColumn.ReadOnly = True
        '
        'coldelivery_city
        '
        Me.coldelivery_city.Caption = "delivery_city"
        Me.coldelivery_city.FieldName = "delivery_city"
        Me.coldelivery_city.Name = "coldelivery_city"
        Me.coldelivery_city.OptionsColumn.ReadOnly = True
        '
        'coldelivery_postcode
        '
        Me.coldelivery_postcode.Caption = "delivery_postcode"
        Me.coldelivery_postcode.FieldName = "delivery_postcode"
        Me.coldelivery_postcode.Name = "coldelivery_postcode"
        Me.coldelivery_postcode.OptionsColumn.ReadOnly = True
        '
        'coldelivery_state
        '
        Me.coldelivery_state.Caption = "delivery_state"
        Me.coldelivery_state.FieldName = "delivery_state"
        Me.coldelivery_state.Name = "coldelivery_state"
        Me.coldelivery_state.OptionsColumn.ReadOnly = True
        '
        'coldelivery_country
        '
        Me.coldelivery_country.Caption = "delivery_country"
        Me.coldelivery_country.FieldName = "delivery_country"
        Me.coldelivery_country.Name = "coldelivery_country"
        Me.coldelivery_country.OptionsColumn.ReadOnly = True
        '
        'coldelivery_address_format_id
        '
        Me.coldelivery_address_format_id.Caption = "delivery_address_format_id"
        Me.coldelivery_address_format_id.FieldName = "delivery_address_format_id"
        Me.coldelivery_address_format_id.Name = "coldelivery_address_format_id"
        Me.coldelivery_address_format_id.OptionsColumn.ReadOnly = True
        '
        'colpayment_method1
        '
        Me.colpayment_method1.Caption = "payment_method"
        Me.colpayment_method1.FieldName = "payment_method"
        Me.colpayment_method1.Name = "colpayment_method1"
        Me.colpayment_method1.OptionsColumn.ReadOnly = True
        '
        'colcc_type
        '
        Me.colcc_type.Caption = "cc_type"
        Me.colcc_type.FieldName = "cc_type"
        Me.colcc_type.Name = "colcc_type"
        Me.colcc_type.OptionsColumn.ReadOnly = True
        '
        'colcc_owner
        '
        Me.colcc_owner.Caption = "cc_owner"
        Me.colcc_owner.FieldName = "cc_owner"
        Me.colcc_owner.Name = "colcc_owner"
        Me.colcc_owner.OptionsColumn.ReadOnly = True
        '
        'colcc_number
        '
        Me.colcc_number.Caption = "cc_number"
        Me.colcc_number.FieldName = "cc_number"
        Me.colcc_number.Name = "colcc_number"
        Me.colcc_number.OptionsColumn.ReadOnly = True
        '
        'colcc_expires
        '
        Me.colcc_expires.Caption = "cc_expires"
        Me.colcc_expires.FieldName = "cc_expires"
        Me.colcc_expires.Name = "colcc_expires"
        Me.colcc_expires.OptionsColumn.ReadOnly = True
        '
        'colproducts_name
        '
        Me.colproducts_name.Caption = "products_name"
        Me.colproducts_name.FieldName = "products_name"
        Me.colproducts_name.Name = "colproducts_name"
        Me.colproducts_name.OptionsColumn.ReadOnly = True
        Me.colproducts_name.Visible = True
        '
        'colorders_date_finished
        '
        Me.colorders_date_finished.Caption = "orders_date_finished"
        Me.colorders_date_finished.FieldName = "orders_date_finished"
        Me.colorders_date_finished.Name = "colorders_date_finished"
        Me.colorders_date_finished.OptionsColumn.ReadOnly = True
        '
        'collast_modified
        '
        Me.collast_modified.Caption = "last_modified"
        Me.collast_modified.FieldName = "last_modified"
        Me.collast_modified.Name = "collast_modified"
        Me.collast_modified.OptionsColumn.ReadOnly = True
        '
        'colcomments
        '
        Me.colcomments.Caption = "comments"
        Me.colcomments.FieldName = "comments"
        Me.colcomments.Name = "colcomments"
        Me.colcomments.OptionsColumn.ReadOnly = True
        '
        'colcurrency
        '
        Me.colcurrency.Caption = "currency"
        Me.colcurrency.FieldName = "currency"
        Me.colcurrency.Name = "colcurrency"
        Me.colcurrency.OptionsColumn.ReadOnly = True
        '
        'colcurrency_value
        '
        Me.colcurrency_value.Caption = "currency_value"
        Me.colcurrency_value.FieldName = "currency_value"
        Me.colcurrency_value.Name = "colcurrency_value"
        Me.colcurrency_value.OptionsColumn.ReadOnly = True
        '
        'colsite1
        '
        Me.colsite1.Caption = "site"
        Me.colsite1.FieldName = "site"
        Me.colsite1.Name = "colsite1"
        Me.colsite1.OptionsColumn.ReadOnly = True
        '
        'colsecured_mail
        '
        Me.colsecured_mail.Caption = "secured_mail"
        Me.colsecured_mail.FieldName = "secured_mail"
        Me.colsecured_mail.Name = "colsecured_mail"
        Me.colsecured_mail.OptionsColumn.ReadOnly = True
        '
        'colmultishipment_sm
        '
        Me.colmultishipment_sm.Caption = "multishipment_sm"
        Me.colmultishipment_sm.FieldName = "multishipment_sm"
        Me.colmultishipment_sm.Name = "colmultishipment_sm"
        Me.colmultishipment_sm.OptionsColumn.ReadOnly = True
        '
        'colorders_products_id
        '
        Me.colorders_products_id.Caption = "orders_products_id"
        Me.colorders_products_id.FieldName = "orders_products_id"
        Me.colorders_products_id.Name = "colorders_products_id"
        Me.colorders_products_id.OptionsColumn.ReadOnly = True
        '
        'colproducts_id1
        '
        Me.colproducts_id1.Caption = "products_id"
        Me.colproducts_id1.FieldName = "products_id"
        Me.colproducts_id1.Name = "colproducts_id1"
        Me.colproducts_id1.OptionsColumn.ReadOnly = True
        Me.colproducts_id1.Visible = True
        '
        'colproducts_model
        '
        Me.colproducts_model.Caption = "products_model"
        Me.colproducts_model.FieldName = "products_model"
        Me.colproducts_model.Name = "colproducts_model"
        Me.colproducts_model.OptionsColumn.ReadOnly = True
        '
        'colproducts_dvd
        '
        Me.colproducts_dvd.Caption = "products_dvd"
        Me.colproducts_dvd.FieldName = "products_dvd"
        Me.colproducts_dvd.Name = "colproducts_dvd"
        Me.colproducts_dvd.OptionsColumn.ReadOnly = True
        Me.colproducts_dvd.Visible = True
        '
        'colproducts_price
        '
        Me.colproducts_price.Caption = "products_price"
        Me.colproducts_price.FieldName = "products_price"
        Me.colproducts_price.Name = "colproducts_price"
        Me.colproducts_price.OptionsColumn.ReadOnly = True
        '
        'colfinal_price
        '
        Me.colfinal_price.Caption = "final_price"
        Me.colfinal_price.FieldName = "final_price"
        Me.colfinal_price.Name = "colfinal_price"
        Me.colfinal_price.OptionsColumn.ReadOnly = True
        '
        'colproducts_tax
        '
        Me.colproducts_tax.Caption = "products_tax"
        Me.colproducts_tax.FieldName = "products_tax"
        Me.colproducts_tax.Name = "colproducts_tax"
        Me.colproducts_tax.OptionsColumn.ReadOnly = True
        '
        'colproducts_quantity
        '
        Me.colproducts_quantity.Caption = "products_quantity"
        Me.colproducts_quantity.FieldName = "products_quantity"
        Me.colproducts_quantity.Name = "colproducts_quantity"
        Me.colproducts_quantity.OptionsColumn.ReadOnly = True
        '
        'colorders_products_status
        '
        Me.colorders_products_status.Caption = "orders_products_status"
        Me.colorders_products_status.FieldName = "orders_products_status"
        Me.colorders_products_status.Name = "colorders_products_status"
        Me.colorders_products_status.OptionsColumn.ReadOnly = True
        '
        'colfeesharing
        '
        Me.colfeesharing.Caption = "feesharing"
        Me.colfeesharing.FieldName = "feesharing"
        Me.colfeesharing.Name = "colfeesharing"
        Me.colfeesharing.OptionsColumn.ReadOnly = True
        '
        'tabCRM
        '
        Me.tabCRM.Controls.Add(Me.GridControl2)
        Me.tabCRM.Controls.Add(Me.GroupControl7)
        Me.tabCRM.Name = "tabCRM"
        Me.tabCRM.Size = New System.Drawing.Size(1047, 337)
        Me.tabCRM.Text = "Call Mgmt"
        '
        'GroupControl7
        '
        Me.GroupControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl7.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(440, 337)
        Me.GroupControl7.TabIndex = 0
        Me.GroupControl7.Text = "Call / Action Detail"
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'GridControl2.EmbeddedNavigator
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(440, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(607, 337)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl2
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'frmCustomers_Maint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1056, 446)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmCustomers_Maint"
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabMain.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.chkMultiShipment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNextABO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVDAdultAtHome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVDNormAtHome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVDAdult.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVDNorm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtABOCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbo_ValidityTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbABO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.txtDeliveryFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDeliveryCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryPostCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryAddr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtEMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelEvening.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtABO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomers_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSearch.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtcustomers_postcode_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_address_street_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_domiciliation_number_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_email_address_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_name_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_id_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWishList.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GridWishListAssigned, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewWishListAssigned, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridWishList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewWishList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSendIt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAboHistory.ResumeLayout(False)
        CType(Me.GridABO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewABO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbABO_Action, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOrdersHistor.ResumeLayout(False)
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.GridOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOrders_Status, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCRM.ResumeLayout(False)
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sSQL As String

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim KeyDataSet As String = "BizzLib.dsGeneral" 'The Dataset used 
    Dim CurrentCustomerID As Integer
    Dim MainData As clsCustomersInfo.clsCustomer
    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _Row As DataRow
        Try
            'SetUp of Variables
            KeyFieldName = "customers_lastname"
            IDField = "customers_id"
            TableName = "customers"
            MainDataSet = objDS
            MyBase.RaiseEventForReportDesigner = True
            HelpProvider1.HelpNamespace = ".\Help\" & SessionInfo.UserLang & "\BizzKeys.chm"
            'Attempt to load the dataset.
            Me.LoadBKComboSet()
            BKGlobal.LoadAssociatedMenu(Me.Tag, PopMenuAssociatedTasks, Me)
            btnNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            DefaultSet_Bar.Visible = False
            Filter_Bar.Visible = False
            Misc_Bar2.Visible = False
            GridViewWishList.ExpandAllGroups()
            'If OpenType = "NEW" Then
            '    'NewRecord(sender, e)
            'End If
            'If OpenType = "EDIT" Then
            '    If KeyValue <> "" Then 'Not IsNothing(_Row) Then
            '        Dim _View As New DataView(Me.objDS.Tables(TableName), "", IDField, DataViewRowState.CurrentRows)
            '        Dim _Name As String = _View(_View.Find(New Object() {KeyValue})).Item(KeyFieldName)
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


        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
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
        LoadCustomerInfo()
        OpenType = "BROWSE"
    End Sub
    Private Sub SaveChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuSave.Click, MyBase.EventSaveChanges
        Dim _ID As Integer
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
        Me.BindingContext(objDS, "address_book_default").EndCurrentEdit()
        MainData.Save()
        'MainData.AddrData.Rows(0).Item("EntityID") = CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item(IDField)
        'MainData.AddrData.Rows(0).Item("Name") = CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item("Name")
        'MainData.AddrData.Rows(0).Item("Description") = CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item("Description")
        'MainData.SaveOnlyAddr()
    End Sub
    Public Sub LoadBKComboSet()
        Try
            BKCombo.GetCombo(objDS, "country", "countries_name", "SELECT * FROM Country")
            BKCombo.GetCombo(objDS, "products_abo", "products_id", "SELECT products_id, products_model, products_title FROM products where products_type = 'ABO' ")
            BKGlobal.Cls1.FillDataSet(objDS.Tables("abo_action"), "SELECT * FROM abo_action")
            BKGlobal.Cls1.FillDataSet(objDS.Tables("orders_status"), "SELECT * FROM orders_status WHERE language_id = 1 ")
            BKGlobal.Cls1.FillDataSet(objDS.Tables("orders_products_status"), "SELECT * FROM orders_products_status")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#Region "Search"
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        sSQL = "SELECT c.customers_id, c.customers_firstname, c.customers_lastname, c.customers_email_address, c.customers_abo, " & _
               " c.black_listed, ab.entry_street_address, ab.entry_postcode, c.domiciliation_number " & _
               " FROM customers c LEFT JOIN address_book ab on c.customers_id=ab.customers_id and c.customers_default_address_id=ab.address_book_id "
        sSQL = sSQL & " where 1 "
        If txtcustomers_id_search.Text <> "" Then
            sSQL = sSQL & " AND c.customers_id = " & txtcustomers_id_search.Text
        Else
            If txtcustomers_email_address_search.Text.Length > 0 Then sSQL = sSQL & " and c.customers_email_address like '%" & _
                txtcustomers_email_address_search.Text & "%'"
            If txtcustomers_name_search.Text.Length > 0 Then sSQL = sSQL & " and (c.customers_firstname like '%" & _
                txtcustomers_name_search.Text & "%' or c.customers_lastname like '%" & txtcustomers_name_search.Text & "%')"
            If txtcustomers_domiciliation_number_search.Text.Length > 0 Then sSQL = sSQL & " and c.domiciliation_number like '%" & _
                txtcustomers_domiciliation_number_search.Text & "%'"

            If txtcustomers_address_street_search.Text.Length > 0 Then sSQL = sSQL & " and ab.entry_street_address like '%" & _
                txtcustomers_address_street_search.Text & "%'"
            If txtcustomers_postcode_search.Text.Length > 0 Then sSQL = sSQL & " and ab.entry_postcode like '%" & _
                txtcustomers_postcode_search.Text & "%'"
            sSQL = sSQL & " order by c.customers_id asc"
            sSQL = sSQL & " limit 100"
        End If
        objDS.Tables("customers_search_result").Clear()
        BKGlobal.Cls1.FillDataSet(objDS.Tables("customers_search_result"), sSQL)

    End Sub
    Private Sub GridViewSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridViewSearch.DoubleClick
        CurrentCustomerID = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle).Item("customers_id")
        LoadCustomerInfo()
        XtraTabControl1.SelectedTabPage = tabMain
    End Sub
#End Region

    Public Sub LoadCustomerInfo()
        objDS.Tables("customers").Clear()
        MainData = New clsCustomersInfo.clsCustomer(SessionInfo, objDS, CurrentCustomerID)
        GridViewWishList.BestFitColumns()
        GridViewWishList.ExpandAllGroups()
        GridViewWishListAssigned.BestFitColumns()
        GridViewWishListAssigned.ExpandAllGroups()
    End Sub
    Private Sub EnablingEditFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingEditFields
        txtLastName.Enabled = Enabling
        txtFirstName.Enabled = Enabling
        txtEMail.Enabled = Enabling
        txtTel.Enabled = Enabling
        txtTelEvening.Enabled = Enabling

        txtDeliveryFirstName.Enabled = Enabling
        txtDeliveryLastName.Enabled = Enabling
        txtDeliveryAddr.Enabled = Enabling
        txtDeliveryCity.Enabled = Enabling
        txtDeliveryPostCode.Enabled = Enabling
        cmbDeliveryCountry.Enabled = Enabling

        txtAbo_ValidityTo.Enabled = Enabling
        cmbNextABO.Enabled = Enabling
        txtABOCredit.Enabled = Enabling
        chkMultiShipment.Enabled = Enabling
        'txtDVDNormAtHome.Enabled = Enabling
        'txtDVDAdultAtHome.Enabled = Enabling

    End Sub
    Private Sub EnablingKeyFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingkeyFields
        'ToBeChecked ***
    End Sub
    Private Sub StartPrintForm() Handles MyBase.EventPrintForm
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            'Find EntityView1Row
            Dim _SQLTxt As String = "SELECT * FROM GeneralEntityView1 WHERE EntityID = " & CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item("EntityID")
            Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)
            objDS.Tables("GeneralEntityView1").Clear()
            _Cls1.FillDataSet(objDS.Tables("GeneralEntityView1"), _SQLTxt)
            If objDS.Tables("GeneralEntityView1").Rows.Count = 1 Then
                BKReport.PrintForm(CurrentReportID, New DataRow() { _
                    objDS.Tables("GeneralEntityView1").Rows(0), _
                    CType(Me.BindingContext(objDS, "GeneralAddress").Current, DataRowView).Row})
            End If
        End If
    End Sub
    Private Sub StartDesignReport() Handles MyBase.EventDesignReport
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            'Find EntityView1Row
            Dim _SQLTxt As String = "SELECT * FROM GeneralEntityView1 WHERE EntityID = " & CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item("EntityID")
            Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)
            objDS.Tables("GeneralEntityView1").Clear()
            _Cls1.FillDataSet(objDS.Tables("GeneralEntityView1"), _SQLTxt)
            If objDS.Tables("GeneralEntityView1").Rows.Count = 1 Then
                BKReport.DesignReport(CurrentReportID, New DataRow() { _
                    objDS.Tables("GeneralEntityView1").Rows(0), _
                    CType(Me.BindingContext(objDS, "GeneralAddress").Current, DataRowView).Row})
            End If
        End If
    End Sub

    Public Overrides Sub btnQuickSearch_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuickSearch.ItemClick
        If IsNumeric(txtQuickSearch.EditValue) Then
            CurrentCustomerID = txtQuickSearch.EditValue
            LoadCustomerInfo()
            XtraTabControl1.SelectedTabPage = tabMain
        End If
    End Sub
    Public Overloads Sub btnPrevious_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrevious.ItemClick
        CurrentCustomerID -= 1
        LoadCustomerInfo()
    End Sub
    Public Overloads Sub btnNext_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNext.ItemClick
        CurrentCustomerID += 1
        LoadCustomerInfo()
    End Sub
    Public Overloads Sub btnFirst_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFirst.ItemClick
        CurrentCustomerID = 0
        LoadCustomerInfo()
    End Sub
    Public Overloads Sub btnLast_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLast.ItemClick
        CurrentCustomerID = BKGlobal.ExecuteFindFieldValueINT("customers_id", "select customers_id from customers order by customers_id desc limit 1")
        LoadCustomerInfo()
    End Sub

    Private Sub btnSendIt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSendIt.Click
        Dim _ProductID As Integer
        Dim _DVDId As Integer
        Dim _WLId As Integer
        Dim _DS As New dsProducts
        Dim _objProductsDVD As clsProduct_DVD
        Dim _SQL As String
        Me.Enabled = False
        _ProductID = GridViewWishList.GetDataRow(GridViewWishList.FocusedRowHandle).Item("product_id")
        _WLId = GridViewWishList.GetDataRow(GridViewWishList.FocusedRowHandle).Item("wl_id")
        _DVDId = BKGlobal.ExecuteFindFieldValueINT("products_dvdid", "select products_dvdid from products_dvd where products_id = " & _ProductID & _
                 " and products_dvd_status = 1 and inout = 1 and box_id > 0 order by box_id asc limit 1")
        If _DVDId <> -1 And _ProductID > 50 Then
            _objProductsDVD = New clsProduct_DVD(SessionInfo, _DS, _ProductID, _DVDId)
            _objProductsDVD.AssignDVD(False, _WLId, CurrentCustomerID)
            _SQL = "update products_dvd pd set  inout = 2 WHERE pd.products_id = " & _ProductID & " AND products_dvdid = " & _DVDId
            BKGlobal.Cls1.ExecuteNonQuery(_SQL)
            MsgBox("This button will send the DVD : " & _ProductID.ToString & " - " & _DVDId, MsgBoxStyle.Information)
        Else
            MsgBox("Cannot send DVD : " & _ProductID.ToString & " (No Available DVD) ", MsgBoxStyle.Information)
        End If
        Me.Enabled = True
    End Sub

End Class
