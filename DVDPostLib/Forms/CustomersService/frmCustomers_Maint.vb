Imports BizzLib.clsGlobal.ObjectState
Imports System.Net.Mail
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports DevExpress.XtraSpellChecker
Public Class frmCustomers_Maint
    Inherits BizzLib.frmGeneral_Maintenance

    Friend WithEvents chkCustServSendMail As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridAboprocessStats As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewAboprocessStats As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dvd_norm_to_send As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_adult_to_send As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_highsent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_mediumsent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_lowsent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_norm_abo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_adult_abo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_norm_compensation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_adult_compensation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_norm_home As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_adult_home As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents creditABoProcess As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customer_abo_rank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents msgerror As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nbdvdfindnorm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nbdvdfindadult As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nbwishlistadult As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nbwishlistnorm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents label As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents date_start As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents quantity_free As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents credit_free As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabSponsorShip As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridSon As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents used_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents son_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents son_abo_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents points As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridViewGodson As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents date_used As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sponsor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpSponsorShip As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpGift As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridGift As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewGift As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents date_attribution As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents points_customers As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gift_sent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gift_sent_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_id_gift As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gift_name_fr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gift_name_nl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gift_name_en As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents points_gift As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridGodFather As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridviewGodFather As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coldate_used As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents father_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfather_abo_type As DevExpress.XtraGrid.Columns.GridColumn

    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPtSponsorShip As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents customers_lastname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_firstname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col2customers_lastname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col2customers_firstname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpCustomersPoint As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridCustPointHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCustPointHistory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col2date_added As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_points_history As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_points_history_action_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_points_history_sub_action_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducts_availability As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents checkAvailibility As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents DateAdded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents products_date_available As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents tabCompensation As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabComment As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridCompensation As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCompensation As DevExpress.XtraGrid.Views.Grid.GridView

    Friend WithEvents compensation_date_given As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents compensation_date_setback As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents compensation_comment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents orders_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents orders_id_given As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_name_given As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompProducts_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbSuspended As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MemoCustomersComment As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnAddCustomersComment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridCustComment As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCustComment As DevExpress.XtraGrid.Views.Grid.GridView

    Friend WithEvents MemoInsertComment As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents customers_comment_text As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_comment_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelDateEndHoliday As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEndOfHoliday As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnViewCustserv As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnViewGift As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Col3Orders_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnPaid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridAddress As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewAddress As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents entry_firstname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents entry_lastname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents entry_street_address As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents entry_postcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents entry_city As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents countries_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shopping_discount_value As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabProductsRating As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridProductsRating As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewProductsRating As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents products As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_rating As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_rating_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rating_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRatingProducts_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWAdate_added As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProducts_next As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProductsstatus As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colentry_street_address As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents fullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridOrdersHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewOrdersHistory As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

    Friend WithEvents coldate_added_Orders_history As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents new_status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents old_status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCommunication_recovery As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnSponsorCard As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GrpSponsonCard As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblCard2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCard2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCard1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCard1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCard5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCard5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCard4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCard4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCard3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCard3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnSaveSponsorCard As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRedlisted As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBlackListed As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridCodeLinked As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCodeLinked As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCCodeLinked As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnEmailError As DevExpress.XtraEditors.SimpleButton


    Friend WithEvents gridViewCustServ As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colcustserv_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collanguage_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents custserv_cat_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomer_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colorders_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvd_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsubject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmessage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladmindate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladminmessage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmessagesent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers2_id6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustserv2_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collanguage2_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents custserv_cat_name2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomer2_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colorders2_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts2_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvd2_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsubject3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmessage3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladmindate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladminmessage3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmessagesent3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MemoOtherReason As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents tabSuspendedHistory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridSuspendedHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSuspendedHistory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents suspended_history_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents suspended_history_date_end As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents abosuspended_history_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridDroselia As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewDroselia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents droselia_codes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents droselia_buy_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents droselia_used_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents catalog_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents droselia_url_link As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDroselia As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colorders_last_modified As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents lblNextCredit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNextPrice As DevExpress.XtraEditors.LabelControl
   
   
    ' Private Const MAIL_RECEIVEDDOM As Integer = 424

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
    Friend WithEvents txtNextCredit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNextPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents objDS As DVDPostLib.dsCustomerMaint
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colpayment_offline_request_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvdpost_bank_account1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcommunication2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_added As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpayment_offline_status1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collast_modified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcomment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_payment_id3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cologone_payment_id3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaccount_movements_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_closed1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_closed_eurofides1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colreason_pk_name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colreason_pk_value1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount_received1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_payment_id4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_payment_date1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colabo_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_address1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstrdomiciliation_debiter_name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstrdomiciliation_number1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcommunication3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfirst_payment1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colreconduction1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_payment_status1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_payment_isabel_date1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_unpaid_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbatch_immatriculation_number1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collast_modified4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colabo_stopped_with_dvdathome_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cologone_payment_id4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_added1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colabo_id3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cologone_payment_status1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cologone_batch_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collast_modified5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustserv_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_id3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collanguage_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustserv_cat_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomer_date1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colorders_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvd_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsubject1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmessage1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladmindate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladminby1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladminmessage1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmessagesent1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvd_finally_arrived_mail1 As DevExpress.XtraGrid.Columns.GridColumn


    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LCNumDom As DevExpress.XtraEditors.LabelControl

    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

    Friend WithEvents TabMailHistory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabAboProcess As DevExpress.XtraTab.XtraTabPage

    Friend WithEvents GridCustServ As DevExpress.XtraGrid.GridControl
    Friend WithEvents colcustserv_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_id10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collanguage_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustserv_cat_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomer_date2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colorders_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvd_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsubject2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmessage2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladmindate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladminby2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladminmessage2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmessagesent2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvd_finally_arrived_mail2 As DevExpress.XtraGrid.Columns.GridColumn

    Friend WithEvents tabDroselia As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents butGenCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabPaymentMovements As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCBankAccountMovement As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridBankAccountMovement As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVBankAccountMovement As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coldomiciliation_payment_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_payment_date2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colabo_id4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_id8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_name2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_address2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstrdomiciliation_debiter_name2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstrdomiciliation_number2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcommunication4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfirst_payment2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colreconduction2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_payment_status2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_payment_isabel_date2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_unpaid_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbatch_immatriculation_number2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collast_modified6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colabo_stopped_with_dvdathome_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cologone_payment_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_added7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colabo_id5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_id9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cologone_payment_status2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cologone_batch_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collast_modified7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabPayment As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbPayMethod As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CalcEdit As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CalcEdit1 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents GroupDomiciliation As DevExpress.XtraEditors.GroupControl
    Friend WithEvents panelDomiciliation As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDomStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDomDebiterName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDomNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDomAcctNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnCancelPayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupOgone As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelOgone As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cc_owner2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cc_card_no2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cc_card_type2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_cc_expiration_status2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_cc_expiration_date2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridPayment As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewPayment As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn59 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn60 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn61 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn62 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn63 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCTypePayment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCAmountPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCDateAdded As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCLastnModified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCCommunicationPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCCustomersID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayment_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCIdRecovery As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcStatusRecovery As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIdMatching As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents checkOpenPayment As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnLoadPayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabCRM As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmbCustServ_cat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SplitterControl4 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSaveCustServ As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutCustServ As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewOrders As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents col2orders_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldate_purchased As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colorders_status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
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
    Friend WithEvents colproducts_name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colorders_date_finished As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcomments As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcurrency As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcurrency_value As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colsite1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colsecured_mail As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colmultishipment_sm As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colorders_products_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_model As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_dvd As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_price As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colfinal_price As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_tax As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_quantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colorders_products_status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colfeesharing As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridABO As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewABO As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colcustomerid As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAction As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbABO_Action As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colcode_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproduct_id1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colpayment_method As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colprivilege_notified As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colsite As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colwl_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduct_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrank2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpriority1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colwishlist_type2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_title2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty_in_stock1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridWishList As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewWishList As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colSendIt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents btnSendIt As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colwishlist_type As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colwl_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproduct_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colrank As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colpriority As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_title As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colqty_in_stock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents txtCustServ_Response_Message As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtCustServ_DVD_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustServ_Products_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustServ_OrderID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustServ_CustDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtCustServ_Subject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridWishListAssigned As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewWishListAssigned As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colwishlist_type1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colwl_assigned_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colwl_id1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colrprioritywish As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldate_assigned As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_title1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents tabOrdersHistor As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitterControl2 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSearch As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents col2customers_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_firstname As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_lastname As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_email_address As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_abo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colblack_listed As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents custserv_customer_date As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colentry_postcode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldomiciliation_number As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_language As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents call_phone As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents tabAboHistory As DevExpress.XtraTab.XtraTabPage

    Friend WithEvents tabWishList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelPayment As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tabMain As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnForcedReconduction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnActivateDomiciliation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReceivedDomiciliation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControlACtPhone As DevExpress.XtraEditors.GroupControl
    Public WithEvents cmbPhoneActivDelete As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelReason As System.Windows.Forms.Label
    Friend WithEvents btnDelPhoAct As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateCallPhoneActivation As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelCallMeDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnActPhone As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkRedListed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkBlackListed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkNewsLetterPartner As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkNewsLetter As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtWishListKind As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNbrOfLogons As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbLanguage As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnReActivate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblAboSumP As System.Windows.Forms.Label
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGoto30 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRegistrationStep As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDVDAdultAtHome As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDiscValidity As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkAutoStop As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtActivationDiscountCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbNextDiscCode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDiscType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkMultiShipment As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbNextABO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDVDNormAtHome As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtDVDAdult As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtDVDNorm As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtABOCredit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAbo_ValidityTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbABO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDeliveryFirstName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeliveryLastName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDeliverycountry As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDeliveryCity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeliveryPostCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeliveryAddr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblComment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtYearsOld As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblGender As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGender As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblyearsOld As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSetPassWord As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLogas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbEntity As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateCreated As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtTel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEMail As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents txtTelEvening As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtABO As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtFirstName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLastName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomers_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnStopNow As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnStopAtReconduction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TxtCustomers_NumComm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNumComm As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcustomers_domiciliation_number_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPhoneActivation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcustomers_postcode_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtcustomers_address_street_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcustomers_email_address_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcustomers_name_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcustomers_id_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl

    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents grpContEmail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewMail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents messages_subject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents messages_title As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mail_opened_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mail_opened As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents date_sended As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents messages_html As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents browser As System.Windows.Forms.WebBrowser
    Friend WithEvents products_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents tabPurchase As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridShoppingOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewShoppingOrders As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents shopping_orders_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents date_orders As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shopping_products_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents quantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shopping_discount_code_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_state As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_bonus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_url As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_awards As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_viewed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_image_big As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabCreditHist As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridCreditHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCreditHistory As DevExpress.XtraGrid.Views.Grid.GridView

    Friend WithEvents id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents credit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents quantity_paid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents date_added As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents action_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cologone_payment_status_history_id As DevExpress.XtraGrid.Columns.GridColumn

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim coldvd_finally_arrived_mail3 As DevExpress.XtraGrid.Columns.GridColumn
        Me.txtNextCredit = New DevExpress.XtraEditors.TextEdit
        Me.txtNextPrice = New DevExpress.XtraEditors.TextEdit
        Me.objDS = New DVDPostLib.dsCustomerMaint
        Me.colcustomers2_id6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridViewGodson = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.date_used = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sponsor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridSon = New DevExpress.XtraGrid.GridControl
        Me.GridViewSon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.used_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.son_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.son_abo_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.points = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_lastname = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_firstname = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpayment_offline_request_id2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colamount3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldvdpost_bank_account1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcommunication2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustomers_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldate_added = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpayment_offline_status1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collast_modified = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcomment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldomiciliation_payment_id3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cologone_payment_id3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colaccount_movements_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldate_closed1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldate_closed_eurofides1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colreason_pk_name1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colreason_pk_value1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colamount_received1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldomiciliation_payment_id4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldomiciliation_payment_date1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colabo_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustomers_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustomers_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustomers_address1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colamount4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colstrdomiciliation_debiter_name1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colstrdomiciliation_number1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcommunication3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colfirst_payment1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colreconduction1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldomiciliation_payment_status1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldomiciliation_payment_isabel_date1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldomiciliation_unpaid_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbatch_immatriculation_number1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collast_modified4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colabo_stopped_with_dvdathome_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cologone_payment_id4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldate_added1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colabo_id3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustomers_id2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colamount5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cologone_payment_status1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cologone_batch_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collast_modified5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustserv_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustomers_id3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collanguage_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustserv_cat_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustomer_date1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colorders_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldvd_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsubject1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colmessage1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coladmindate1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coladminby1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coladminmessage1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colmessagesent1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldvd_finally_arrived_mail1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit
        Me.LCNumDom = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.TabMailHistory = New DevExpress.XtraTab.XtraTabPage
        Me.browser = New System.Windows.Forms.WebBrowser
        Me.grpContEmail = New DevExpress.XtraGrid.GridControl
        Me.GridViewMail = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.messages_subject = New DevExpress.XtraGrid.Columns.GridColumn
        Me.messages_title = New DevExpress.XtraGrid.Columns.GridColumn
        Me.mail_opened_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.mail_opened = New DevExpress.XtraGrid.Columns.GridColumn
        Me.date_sended = New DevExpress.XtraGrid.Columns.GridColumn
        Me.messages_html = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tabAboProcess = New DevExpress.XtraTab.XtraTabPage
        Me.GridAboprocessStats = New DevExpress.XtraGrid.GridControl
        Me.GridViewAboprocessStats = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.dvd_norm_to_send = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dvd_adult_to_send = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dvd_highsent = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dvd_mediumsent = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dvd_lowsent = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dvd_norm_abo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dvd_adult_abo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dvd_norm_compensation = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dvd_adult_compensation = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dvd_norm_home = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dvd_adult_home = New DevExpress.XtraGrid.Columns.GridColumn
        Me.creditABoProcess = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customer_abo_rank = New DevExpress.XtraGrid.Columns.GridColumn
        Me.msgerror = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nbdvdfindnorm = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nbdvdfindadult = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nbwishlistadult = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nbwishlistnorm = New DevExpress.XtraGrid.Columns.GridColumn
        Me.label = New DevExpress.XtraGrid.Columns.GridColumn
        Me.date_start = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridCustServ = New DevExpress.XtraGrid.GridControl
        Me.gridViewCustServ = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colcustserv2_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collanguage2_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.custserv_cat_name2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustomer2_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colorders2_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts2_id2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldvd2_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsubject3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colmessage3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coladmindate3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coladminmessage3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colmessagesent3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbCustServ_cat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tabDroselia = New DevExpress.XtraTab.XtraTabPage
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.txtDroselia = New DevExpress.XtraEditors.SpinEdit
        Me.GridDroselia = New DevExpress.XtraGrid.GridControl
        Me.GridViewDroselia = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.droselia_codes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.droselia_buy_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.droselia_used_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.catalog_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.droselia_url_link = New DevExpress.XtraGrid.Columns.GridColumn
        Me.butGenCode = New DevExpress.XtraEditors.SimpleButton
        Me.tabPaymentMovements = New DevExpress.XtraTab.XtraTabPage
        Me.GCBankAccountMovement = New DevExpress.XtraEditors.GroupControl
        Me.GridBankAccountMovement = New DevExpress.XtraGrid.GridControl
        Me.GVBankAccountMovement = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridOrders = New DevExpress.XtraGrid.GridControl
        Me.GridViewOrders = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.col2orders_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldate_purchased = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colorders_status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
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
        Me.colcomments = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcurrency = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcurrency_value = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colsite1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colsecured_mail = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colmultishipment_sm = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colorders_products_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_model = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.products_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_dvd = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colorders_last_modified = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_price = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colfinal_price = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_tax = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_quantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colorders_products_status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colfeesharing = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Col3Orders_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridABO = New DevExpress.XtraGrid.GridControl
        Me.GridViewABO = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colcustomerid = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colAction = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbABO_Action = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colcode_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproduct_id1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colpayment_method = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colprivilege_notified = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colsite = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.tabPayment = New DevExpress.XtraTab.XtraTabPage
        Me.GridPayment = New DevExpress.XtraGrid.GridControl
        Me.GridViewPayment = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GCTypePayment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCAmountPay = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCDateAdded = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCLastnModified = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCCommunicationPay = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCCustomersID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPayment_status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCIdRecovery = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcStatusRecovery = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcIdMatching = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCommunication_recovery = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.BtnPaid = New DevExpress.XtraEditors.SimpleButton
        Me.btnLoadPayment = New DevExpress.XtraEditors.SimpleButton
        Me.checkOpenPayment = New DevExpress.XtraEditors.CheckEdit
        Me.GroupOgone = New DevExpress.XtraEditors.GroupControl
        Me.PanelOgone = New DevExpress.XtraEditors.PanelControl
        Me.txt_cc_expiration_date2 = New DevExpress.XtraEditors.TextEdit
        Me.cmb_cc_expiration_status2 = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl
        Me.txt_cc_card_type2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl
        Me.txt_cc_card_no2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl
        Me.txt_cc_owner2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl
        Me.BtnCancelPayment = New DevExpress.XtraEditors.SimpleButton
        Me.GroupDomiciliation = New DevExpress.XtraEditors.GroupControl
        Me.panelDomiciliation = New DevExpress.XtraEditors.PanelControl
        Me.txtDomAcctNumber = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl
        Me.txtDomNumber = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl
        Me.txtDomDebiterName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl
        Me.cmbDomStatus = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl
        Me.CalcEdit1 = New DevExpress.XtraEditors.CalcEdit
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl
        Me.CalcEdit = New DevExpress.XtraEditors.CalcEdit
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl
        Me.cmbPayMethod = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl50 = New DevExpress.XtraEditors.LabelControl
        Me.GridColumn59 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn60 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn61 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn62 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn63 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colwl_id2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustomers_id8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproduct_id2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colrank2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpriority1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldate_added7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colwishlist_type2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_title2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colqty_in_stock1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridWishList = New DevExpress.XtraGrid.GridControl
        Me.GridViewWishList = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colSendIt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.btnSendIt = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.colwishlist_type = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.DateAdded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colwl_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproduct_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colrank = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colpriority = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_title = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.products_date_available = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colqty_in_stock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colProducts_next = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.checkAvailibility = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colProductsstatus = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colProducts_availability = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.tabCRM = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl
        Me.LayoutCustServ = New DevExpress.XtraDataLayout.DataLayoutControl
        Me.txtCustServ_Response_Message = New DevExpress.XtraEditors.MemoEdit
        Me.txtCustServ_DVD_ID = New DevExpress.XtraEditors.TextEdit
        Me.txtCustServ_Products_id = New DevExpress.XtraEditors.TextEdit
        Me.txtCustServ_OrderID = New DevExpress.XtraEditors.TextEdit
        Me.txtCustServ_CustDate = New DevExpress.XtraEditors.DateEdit
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.txtCustServ_Subject = New DevExpress.XtraEditors.TextEdit
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl
        Me.chkCustServSendMail = New DevExpress.XtraEditors.CheckEdit
        Me.btnSaveCustServ = New DevExpress.XtraEditors.SimpleButton
        Me.SplitterControl4 = New DevExpress.XtraEditors.SplitterControl
        Me.GridWishListAssigned = New DevExpress.XtraGrid.GridControl
        Me.GridViewWishListAssigned = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colwishlist_type1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colwl_assigned_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colwl_id1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colrprioritywish = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldate_assigned = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colWAdate_added = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_title1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.coldomiciliation_payment_id2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldomiciliation_payment_date2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colabo_id4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustomers_name2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustomers_address2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colamount6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colstrdomiciliation_debiter_name2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colstrdomiciliation_number2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcommunication4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colfirst_payment2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colreconduction2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldomiciliation_payment_status2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldomiciliation_payment_isabel_date2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldomiciliation_unpaid_id2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbatch_immatriculation_number2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collast_modified6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colabo_stopped_with_dvdathome_id2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cologone_payment_id2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colabo_id5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustomers_id9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colamount7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cologone_payment_status2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cologone_batch_id2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collast_modified7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustserv_id2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustomers_id10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collanguage_id2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustserv_cat_id2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcustomer_date2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colorders_id2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldvd_id2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsubject2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colmessage2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coladmindate2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coladminby2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coladminmessage2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colmessagesent2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldvd_finally_arrived_mail2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tabOrdersHistor = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl
        Me.GridOrdersHistory = New DevExpress.XtraGrid.GridControl
        Me.GridViewOrdersHistory = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.coldate_added_Orders_history = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.new_status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.old_status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.SplitterControl2 = New DevExpress.XtraEditors.SplitterControl
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridViewSearch = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.col2customers_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_firstname = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_lastname = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_email_address = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_abo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colblack_listed = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colentry_postcode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colentry_street_address = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldomiciliation_number = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_language = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.call_phone = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.custserv_customer_date = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.tabAboHistory = New DevExpress.XtraTab.XtraTabPage
        Me.tabWishList = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl
        Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl
        Me.PanelPayment = New DevExpress.XtraEditors.PanelControl
        Me.tabMain = New DevExpress.XtraTab.XtraTabPage
        Me.lblNextPrice = New DevExpress.XtraEditors.LabelControl
        Me.lblNextCredit = New DevExpress.XtraEditors.LabelControl
        Me.btnForcedReconduction = New DevExpress.XtraEditors.SimpleButton
        Me.btnActivateDomiciliation = New DevExpress.XtraEditors.SimpleButton
        Me.btnReceivedDomiciliation = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControlACtPhone = New DevExpress.XtraEditors.GroupControl
        Me.MemoOtherReason = New DevExpress.XtraEditors.MemoEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbPhoneActivDelete = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelReason = New System.Windows.Forms.Label
        Me.DateCallPhoneActivation = New DevExpress.XtraEditors.DateEdit
        Me.LabelCallMeDate = New DevExpress.XtraEditors.LabelControl
        Me.btnDelPhoAct = New DevExpress.XtraEditors.SimpleButton
        Me.btnActPhone = New DevExpress.XtraEditors.SimpleButton
        Me.btnReActivate = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.LabelDateEndHoliday = New DevExpress.XtraEditors.LabelControl
        Me.DateEndOfHoliday = New DevExpress.XtraEditors.DateEdit
        Me.cmbSuspended = New DevExpress.XtraEditors.LookUpEdit
        Me.lblAboSumP = New System.Windows.Forms.Label
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl
        Me.btnGoto30 = New DevExpress.XtraEditors.SimpleButton
        Me.txtRegistrationStep = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl
        Me.txtDVDAdultAtHome = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.txtDiscValidity = New DevExpress.XtraEditors.DateEdit
        Me.chkAutoStop = New DevExpress.XtraEditors.CheckEdit
        Me.txtActivationDiscountCode = New DevExpress.XtraEditors.TextEdit
        Me.cmbNextDiscCode = New DevExpress.XtraEditors.LookUpEdit
        Me.txtDiscType = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.chkMultiShipment = New DevExpress.XtraEditors.CheckEdit
        Me.cmbNextABO = New DevExpress.XtraEditors.LookUpEdit
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
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GridAddress = New DevExpress.XtraGrid.GridControl
        Me.GridViewAddress = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.entry_firstname = New DevExpress.XtraGrid.Columns.GridColumn
        Me.entry_lastname = New DevExpress.XtraGrid.Columns.GridColumn
        Me.entry_street_address = New DevExpress.XtraGrid.Columns.GridColumn
        Me.entry_postcode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.entry_city = New DevExpress.XtraGrid.Columns.GridColumn
        Me.countries_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtDeliveryFirstName = New DevExpress.XtraEditors.TextEdit
        Me.txtDeliveryLastName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.cmbDeliverycountry = New DevExpress.XtraEditors.LookUpEdit
        Me.txtDeliveryCity = New DevExpress.XtraEditors.TextEdit
        Me.txtDeliveryPostCode = New DevExpress.XtraEditors.TextEdit
        Me.txtDeliveryAddr = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtPtSponsorShip = New DevExpress.XtraEditors.SpinEdit
        Me.lblComment = New DevExpress.XtraEditors.LabelControl
        Me.chkRedListed = New DevExpress.XtraEditors.CheckEdit
        Me.txtComment = New DevExpress.XtraEditors.TextEdit
        Me.chkBlackListed = New DevExpress.XtraEditors.CheckEdit
        Me.txtYearsOld = New DevExpress.XtraEditors.TextEdit
        Me.chkNewsLetterPartner = New DevExpress.XtraEditors.CheckEdit
        Me.lblGender = New DevExpress.XtraEditors.LabelControl
        Me.chkNewsLetter = New DevExpress.XtraEditors.CheckEdit
        Me.txtGender = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl
        Me.lblyearsOld = New DevExpress.XtraEditors.LabelControl
        Me.txtWishListKind = New DevExpress.XtraEditors.TextEdit
        Me.lblSetPassWord = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl
        Me.lblLogas = New DevExpress.XtraEditors.LabelControl
        Me.txtNbrOfLogons = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
        Me.cmbEntity = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.cmbLanguage = New DevExpress.XtraEditors.LookUpEdit
        Me.txtDateCreated = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.txtTel = New DevExpress.XtraEditors.TextEdit
        Me.txtEMail = New DevExpress.XtraEditors.HyperLinkEdit
        Me.txtTelEvening = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.txtABO = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.txtFirstName = New DevExpress.XtraEditors.TextEdit
        Me.txtLastName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtCustomers_id = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.btnStopNow = New DevExpress.XtraEditors.SimpleButton
        Me.btnStopAtReconduction = New DevExpress.XtraEditors.SimpleButton
        Me.tabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.BtnEmailError = New DevExpress.XtraEditors.SimpleButton
        Me.btnRedlisted = New DevExpress.XtraEditors.SimpleButton
        Me.btnBlackListed = New DevExpress.XtraEditors.SimpleButton
        Me.BtnSponsorCard = New DevExpress.XtraEditors.SimpleButton
        Me.btnViewGift = New DevExpress.XtraEditors.SimpleButton
        Me.btnViewCustserv = New DevExpress.XtraEditors.SimpleButton
        Me.TxtCustomers_NumComm = New DevExpress.XtraEditors.TextEdit
        Me.lblNumComm = New DevExpress.XtraEditors.LabelControl
        Me.txtcustomers_domiciliation_number_search = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.btnPhoneActivation = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtcustomers_postcode_search = New DevExpress.XtraEditors.TextEdit
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.txtcustomers_address_street_search = New DevExpress.XtraEditors.TextEdit
        Me.txtcustomers_email_address_search = New DevExpress.XtraEditors.TextEdit
        Me.txtcustomers_name_search = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtcustomers_id_search = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tabComment = New DevExpress.XtraTab.XtraTabPage
        Me.MemoCustomersComment = New DevExpress.XtraEditors.MemoEdit
        Me.GridCustComment = New DevExpress.XtraGrid.GridControl
        Me.GridViewCustComment = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.customers_comment_text = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_comment_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fullName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MemoInsertComment = New DevExpress.XtraEditors.MemoEdit
        Me.btnAddCustomersComment = New DevExpress.XtraEditors.SimpleButton
        Me.tabPurchase = New DevExpress.XtraTab.XtraTabPage
        Me.GridShoppingOrders = New DevExpress.XtraGrid.GridControl
        Me.GridViewShoppingOrders = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.shopping_orders_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.date_orders = New DevExpress.XtraGrid.Columns.GridColumn
        Me.shopping_products_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.quantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dvd_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.price = New DevExpress.XtraGrid.Columns.GridColumn
        Me.shopping_discount_code_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_state = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_description = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_bonus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_url = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_awards = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_viewed = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_image_big = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.shopping_discount_value = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tabCreditHist = New DevExpress.XtraTab.XtraTabPage
        Me.GridCreditHistory = New DevExpress.XtraGrid.GridControl
        Me.GridViewCreditHistory = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.credit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.quantity_paid = New DevExpress.XtraGrid.Columns.GridColumn
        Me.date_added = New DevExpress.XtraGrid.Columns.GridColumn
        Me.action_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.quantity_free = New DevExpress.XtraGrid.Columns.GridColumn
        Me.credit_free = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tabSponsorShip = New DevExpress.XtraTab.XtraTabPage
        Me.GCCodeLinked = New DevExpress.XtraEditors.GroupControl
        Me.GridCodeLinked = New DevExpress.XtraGrid.GridControl
        Me.GridViewCodeLinked = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GrpSponsonCard = New DevExpress.XtraEditors.GroupControl
        Me.BtnSaveSponsorCard = New DevExpress.XtraEditors.SimpleButton
        Me.lblCard5 = New DevExpress.XtraEditors.LabelControl
        Me.txtCard5 = New DevExpress.XtraEditors.TextEdit
        Me.lblCard4 = New DevExpress.XtraEditors.LabelControl
        Me.txtCard4 = New DevExpress.XtraEditors.TextEdit
        Me.lblCard3 = New DevExpress.XtraEditors.LabelControl
        Me.txtCard3 = New DevExpress.XtraEditors.TextEdit
        Me.lblCard2 = New DevExpress.XtraEditors.LabelControl
        Me.txtCard2 = New DevExpress.XtraEditors.TextEdit
        Me.lblCard1 = New DevExpress.XtraEditors.LabelControl
        Me.txtCard1 = New DevExpress.XtraEditors.TextEdit
        Me.grpCustomersPoint = New DevExpress.XtraEditors.GroupControl
        Me.GridCustPointHistory = New DevExpress.XtraGrid.GridControl
        Me.GridViewCustPointHistory = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.col2date_added = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_points_history = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_points_history_action_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_points_history_sub_action_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grpGift = New DevExpress.XtraEditors.GroupControl
        Me.GridGift = New DevExpress.XtraGrid.GridControl
        Me.GridViewGift = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.date_attribution = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gift_sent = New DevExpress.XtraGrid.Columns.GridColumn
        Me.points_customers = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gift_sent_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_id_gift = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gift_name_fr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gift_name_nl = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gift_name_en = New DevExpress.XtraGrid.Columns.GridColumn
        Me.points_gift = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grpSponsorShip = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.GridGodFather = New DevExpress.XtraGrid.GridControl
        Me.GridviewGodFather = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.coldate_used = New DevExpress.XtraGrid.Columns.GridColumn
        Me.father_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colfather_abo_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col2customers_lastname = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col2customers_firstname = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tabCompensation = New DevExpress.XtraTab.XtraTabPage
        Me.GridCompensation = New DevExpress.XtraGrid.GridControl
        Me.GridViewCompensation = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.compensation_date_given = New DevExpress.XtraGrid.Columns.GridColumn
        Me.compensation_date_setback = New DevExpress.XtraGrid.Columns.GridColumn
        Me.compensation_comment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.orders_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.orders_id_given = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_name_given = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCompProducts_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tabProductsRating = New DevExpress.XtraTab.XtraTabPage
        Me.GridProductsRating = New DevExpress.XtraGrid.GridControl
        Me.GridViewProductsRating = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.products = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_rating = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_rating_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rating_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRatingProducts_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tabSuspendedHistory = New DevExpress.XtraTab.XtraTabPage
        Me.GridSuspendedHistory = New DevExpress.XtraGrid.GridControl
        Me.GridViewSuspendedHistory = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.suspended_history_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.suspended_history_date_end = New DevExpress.XtraGrid.Columns.GridColumn
        Me.abosuspended_history_type = New DevExpress.XtraGrid.Columns.GridColumn
        coldvd_finally_arrived_mail3 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(txtNextCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(txtNextPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewGodson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMailHistory.SuspendLayout()
        CType(Me.grpContEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAboProcess.SuspendLayout()
        CType(Me.GridAboprocessStats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewAboprocessStats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCustServ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewCustServ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCustServ_cat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDroselia.SuspendLayout()
        CType(Me.txtDroselia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDroselia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDroselia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPaymentMovements.SuspendLayout()
        CType(Me.GCBankAccountMovement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCBankAccountMovement.SuspendLayout()
        CType(Me.GridBankAccountMovement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVBankAccountMovement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridABO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewABO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbABO_Action, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPayment.SuspendLayout()
        CType(Me.GridPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkOpenPayment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupOgone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupOgone.SuspendLayout()
        CType(Me.PanelOgone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelOgone.SuspendLayout()
        CType(Me.txt_cc_expiration_date2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_cc_expiration_status2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cc_card_type2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cc_card_no2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cc_owner2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupDomiciliation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDomiciliation.SuspendLayout()
        CType(Me.panelDomiciliation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDomiciliation.SuspendLayout()
        CType(Me.txtDomAcctNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDomNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDomDebiterName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDomStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalcEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPayMethod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridWishList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewWishList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSendIt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkAvailibility, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCRM.SuspendLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.LayoutCustServ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutCustServ.SuspendLayout()
        CType(Me.txtCustServ_Response_Message.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustServ_DVD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustServ_Products_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustServ_OrderID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustServ_CustDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustServ_CustDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustServ_Subject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.chkCustServSendMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridWishListAssigned, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewWishListAssigned, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOrdersHistor.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.GridOrdersHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewOrdersHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAboHistory.SuspendLayout()
        Me.tabWishList.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl11.SuspendLayout()
        CType(Me.PanelPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        CType(Me.GroupControlACtPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControlACtPhone.SuspendLayout()
        CType(Me.MemoOtherReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPhoneActivDelete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateCallPhoneActivation.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateCallPhoneActivation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.DateEndOfHoliday.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEndOfHoliday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSuspended.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegistrationStep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVDAdultAtHome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscValidity.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscValidity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAutoStop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivationDiscountCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNextDiscCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMultiShipment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNextABO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVDNormAtHome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVDAdult.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVDNorm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtABOCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbo_ValidityTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbo_ValidityTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbABO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDeliverycountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryPostCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryAddr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtPtSponsorShip.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRedListed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBlackListed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYearsOld.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNewsLetterPartner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNewsLetter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWishListKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNbrOfLogons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbEntity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateCreated.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateCreated.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelEvening.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtABO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomers_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearch.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.TxtCustomers_NumComm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_domiciliation_number_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_postcode_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_address_street_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_email_address_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_name_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_id_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabComment.SuspendLayout()
        CType(Me.MemoCustomersComment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCustComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCustComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoInsertComment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPurchase.SuspendLayout()
        CType(Me.GridShoppingOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewShoppingOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCreditHist.SuspendLayout()
        CType(Me.GridCreditHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCreditHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSponsorShip.SuspendLayout()
        CType(Me.GCCodeLinked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCCodeLinked.SuspendLayout()
        CType(Me.GridCodeLinked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCodeLinked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrpSponsonCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSponsonCard.SuspendLayout()
        CType(Me.txtCard5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCard4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCard3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCard2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCard1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpCustomersPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCustomersPoint.SuspendLayout()
        CType(Me.GridCustPointHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCustPointHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpGift, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGift.SuspendLayout()
        CType(Me.GridGift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewGift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSponsorShip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSponsorShip.SuspendLayout()
        CType(Me.GridGodFather, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridviewGodFather, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCompensation.SuspendLayout()
        CType(Me.GridCompensation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCompensation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProductsRating.SuspendLayout()
        CType(Me.GridProductsRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewProductsRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSuspendedHistory.SuspendLayout()
        CType(Me.GridSuspendedHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSuspendedHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.StatusBar1.Location = New System.Drawing.Point(0, 995)
        Me.StatusBar1.Size = New System.Drawing.Size(1159, 10)
        '
        'coldvd_finally_arrived_mail3
        '
        coldvd_finally_arrived_mail3.Caption = "dvd_finally_arrived_mail"
        coldvd_finally_arrived_mail3.FieldName = "dvd_finally_arrived_mail"
        coldvd_finally_arrived_mail3.Name = "coldvd_finally_arrived_mail3"
        coldvd_finally_arrived_mail3.OptionsColumn.AllowEdit = False
        coldvd_finally_arrived_mail3.OptionsColumn.ReadOnly = True
        '
        'txtNextCredit
        '
        txtNextCredit.Enabled = False
        txtNextCredit.Location = New System.Drawing.Point(697, 14)
        txtNextCredit.Name = "txtNextCredit"
        txtNextCredit.Properties.ReadOnly = True
        txtNextCredit.Size = New System.Drawing.Size(79, 20)
        txtNextCredit.TabIndex = 21
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsCustomerMaint"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtNextPrice
        '
        txtNextPrice.Enabled = False
        txtNextPrice.Location = New System.Drawing.Point(854, 14)
        txtNextPrice.Name = "txtNextPrice"
        txtNextPrice.Properties.ReadOnly = True
        txtNextPrice.Size = New System.Drawing.Size(79, 20)
        txtNextPrice.TabIndex = 23
        '
        'colcustomers2_id6
        '
        Me.colcustomers2_id6.Caption = "customers_id"
        Me.colcustomers2_id6.FieldName = "customers_id"
        Me.colcustomers2_id6.Name = "colcustomers2_id6"
        Me.colcustomers2_id6.OptionsColumn.AllowEdit = False
        Me.colcustomers2_id6.OptionsColumn.ReadOnly = True
        '
        'GridViewGodson
        '
        Me.GridViewGodson.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.date_used, Me.sponsor})
        Me.GridViewGodson.GridControl = Me.GridSon
        Me.GridViewGodson.Name = "GridViewGodson"
        '
        'date_used
        '
        Me.date_used.Caption = "date_used"
        Me.date_used.FieldName = "date"
        Me.date_used.Name = "date_used"
        Me.date_used.Visible = True
        Me.date_used.VisibleIndex = 0
        Me.date_used.Width = 140
        '
        'sponsor
        '
        Me.sponsor.Caption = "sponsor"
        Me.sponsor.FieldName = "son_id"
        Me.sponsor.Name = "sponsor"
        Me.sponsor.Visible = True
        Me.sponsor.VisibleIndex = 1
        Me.sponsor.Width = 888
        '
        'GridSon
        '
        Me.GridSon.EmbeddedNavigator.Name = ""
        Me.GridSon.FormsUseDefaultLookAndFeel = False
        Me.GridSon.Location = New System.Drawing.Point(0, 36)
        Me.GridSon.MainView = Me.GridViewSon
        Me.GridSon.Name = "GridSon"
        Me.GridSon.Size = New System.Drawing.Size(610, 229)
        Me.GridSon.TabIndex = 0
        Me.GridSon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSon, Me.GridViewGodson})
        '
        'GridViewSon
        '
        Me.GridViewSon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.used_date, Me.son_id, Me.son_abo_type, Me.points, Me.customers_lastname, Me.customers_firstname})
        Me.GridViewSon.GridControl = Me.GridSon
        Me.GridViewSon.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewSon.Name = "GridViewSon"
        '
        'used_date
        '
        Me.used_date.Caption = "used_date"
        Me.used_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.used_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.used_date.FieldName = "date"
        Me.used_date.Name = "used_date"
        Me.used_date.OptionsColumn.AllowEdit = False
        Me.used_date.Visible = True
        Me.used_date.VisibleIndex = 0
        Me.used_date.Width = 70
        '
        'son_id
        '
        Me.son_id.Caption = "son_id"
        Me.son_id.FieldName = "son_id"
        Me.son_id.Name = "son_id"
        Me.son_id.OptionsColumn.AllowEdit = False
        '
        'son_abo_type
        '
        Me.son_abo_type.Caption = "abo_type"
        Me.son_abo_type.FieldName = "son_abo_type"
        Me.son_abo_type.Name = "son_abo_type"
        Me.son_abo_type.OptionsColumn.AllowEdit = False
        Me.son_abo_type.Visible = True
        Me.son_abo_type.VisibleIndex = 3
        Me.son_abo_type.Width = 107
        '
        'points
        '
        Me.points.Caption = "points"
        Me.points.FieldName = "points"
        Me.points.Name = "points"
        Me.points.OptionsColumn.AllowEdit = False
        Me.points.Visible = True
        Me.points.VisibleIndex = 4
        Me.points.Width = 41
        '
        'customers_lastname
        '
        Me.customers_lastname.Caption = "customers_lastname"
        Me.customers_lastname.FieldName = "customers_lastname"
        Me.customers_lastname.Name = "customers_lastname"
        Me.customers_lastname.OptionsColumn.AllowEdit = False
        Me.customers_lastname.Visible = True
        Me.customers_lastname.VisibleIndex = 1
        Me.customers_lastname.Width = 142
        '
        'customers_firstname
        '
        Me.customers_firstname.Caption = "customers_firstname"
        Me.customers_firstname.FieldName = "customers_firstname"
        Me.customers_firstname.Name = "customers_firstname"
        Me.customers_firstname.OptionsColumn.AllowEdit = False
        Me.customers_firstname.Visible = True
        Me.customers_firstname.VisibleIndex = 2
        Me.customers_firstname.Width = 229
        '
        'colpayment_offline_request_id2
        '
        Me.colpayment_offline_request_id2.Caption = "payment_offline_request_id"
        Me.colpayment_offline_request_id2.FieldName = "payment_offline_request_id"
        Me.colpayment_offline_request_id2.Name = "colpayment_offline_request_id2"
        Me.colpayment_offline_request_id2.Visible = True
        Me.colpayment_offline_request_id2.VisibleIndex = 0
        '
        'colamount3
        '
        Me.colamount3.Caption = "amount"
        Me.colamount3.FieldName = "amount"
        Me.colamount3.Name = "colamount3"
        Me.colamount3.Visible = True
        Me.colamount3.VisibleIndex = 1
        '
        'coldvdpost_bank_account1
        '
        Me.coldvdpost_bank_account1.Caption = "dvdpost_bank_account"
        Me.coldvdpost_bank_account1.FieldName = "dvdpost_bank_account"
        Me.coldvdpost_bank_account1.Name = "coldvdpost_bank_account1"
        Me.coldvdpost_bank_account1.Visible = True
        Me.coldvdpost_bank_account1.VisibleIndex = 2
        '
        'colcommunication2
        '
        Me.colcommunication2.Caption = "communication"
        Me.colcommunication2.FieldName = "communication"
        Me.colcommunication2.Name = "colcommunication2"
        Me.colcommunication2.Visible = True
        Me.colcommunication2.VisibleIndex = 3
        '
        'colcustomers_id
        '
        Me.colcustomers_id.Caption = "customers_id"
        Me.colcustomers_id.FieldName = "customers_id"
        Me.colcustomers_id.Name = "colcustomers_id"
        Me.colcustomers_id.Visible = True
        Me.colcustomers_id.VisibleIndex = 4
        '
        'coldate_added
        '
        Me.coldate_added.Caption = "date_added"
        Me.coldate_added.FieldName = "date_added"
        Me.coldate_added.Name = "coldate_added"
        Me.coldate_added.Visible = True
        Me.coldate_added.VisibleIndex = 5
        '
        'colpayment_offline_status1
        '
        Me.colpayment_offline_status1.Caption = "payment_offline_status"
        Me.colpayment_offline_status1.FieldName = "payment_offline_status"
        Me.colpayment_offline_status1.Name = "colpayment_offline_status1"
        Me.colpayment_offline_status1.Visible = True
        Me.colpayment_offline_status1.VisibleIndex = 6
        '
        'collast_modified
        '
        Me.collast_modified.Caption = "last_modified"
        Me.collast_modified.FieldName = "last_modified"
        Me.collast_modified.Name = "collast_modified"
        '
        'colcomment
        '
        Me.colcomment.Caption = "comment"
        Me.colcomment.FieldName = "comment"
        Me.colcomment.Name = "colcomment"
        Me.colcomment.Visible = True
        Me.colcomment.VisibleIndex = 7
        '
        'coldomiciliation_payment_id3
        '
        Me.coldomiciliation_payment_id3.Caption = "domiciliation_payment_id"
        Me.coldomiciliation_payment_id3.FieldName = "domiciliation_payment_id"
        Me.coldomiciliation_payment_id3.Name = "coldomiciliation_payment_id3"
        Me.coldomiciliation_payment_id3.Visible = True
        Me.coldomiciliation_payment_id3.VisibleIndex = 8
        '
        'cologone_payment_id3
        '
        Me.cologone_payment_id3.Caption = "ogone_payment_id"
        Me.cologone_payment_id3.FieldName = "ogone_payment_id"
        Me.cologone_payment_id3.Name = "cologone_payment_id3"
        Me.cologone_payment_id3.Visible = True
        Me.cologone_payment_id3.VisibleIndex = 9
        '
        'colaccount_movements_id1
        '
        Me.colaccount_movements_id1.Caption = "account_movements_id"
        Me.colaccount_movements_id1.FieldName = "account_movements_id"
        Me.colaccount_movements_id1.Name = "colaccount_movements_id1"
        Me.colaccount_movements_id1.Visible = True
        Me.colaccount_movements_id1.VisibleIndex = 10
        '
        'coldate_closed1
        '
        Me.coldate_closed1.Caption = "date_closed"
        Me.coldate_closed1.FieldName = "date_closed"
        Me.coldate_closed1.Name = "coldate_closed1"
        Me.coldate_closed1.Visible = True
        Me.coldate_closed1.VisibleIndex = 11
        '
        'coldate_closed_eurofides1
        '
        Me.coldate_closed_eurofides1.Caption = "date_closed_eurofides"
        Me.coldate_closed_eurofides1.FieldName = "date_closed_eurofides"
        Me.coldate_closed_eurofides1.Name = "coldate_closed_eurofides1"
        Me.coldate_closed_eurofides1.Visible = True
        Me.coldate_closed_eurofides1.VisibleIndex = 12
        '
        'colreason_pk_name1
        '
        Me.colreason_pk_name1.Caption = "reason_pk_name"
        Me.colreason_pk_name1.FieldName = "reason_pk_name"
        Me.colreason_pk_name1.Name = "colreason_pk_name1"
        Me.colreason_pk_name1.Visible = True
        Me.colreason_pk_name1.VisibleIndex = 13
        '
        'colreason_pk_value1
        '
        Me.colreason_pk_value1.Caption = "reason_pk_value"
        Me.colreason_pk_value1.FieldName = "reason_pk_value"
        Me.colreason_pk_value1.Name = "colreason_pk_value1"
        Me.colreason_pk_value1.Visible = True
        Me.colreason_pk_value1.VisibleIndex = 14
        '
        'colamount_received1
        '
        Me.colamount_received1.Caption = "amount_received"
        Me.colamount_received1.FieldName = "amount_received"
        Me.colamount_received1.Name = "colamount_received1"
        Me.colamount_received1.Visible = True
        Me.colamount_received1.VisibleIndex = 15
        '
        'coldomiciliation_payment_id4
        '
        Me.coldomiciliation_payment_id4.Caption = "domiciliation_payment_id"
        Me.coldomiciliation_payment_id4.FieldName = "domiciliation_payment_id"
        Me.coldomiciliation_payment_id4.Name = "coldomiciliation_payment_id4"
        Me.coldomiciliation_payment_id4.Visible = True
        Me.coldomiciliation_payment_id4.VisibleIndex = 0
        '
        'coldomiciliation_payment_date1
        '
        Me.coldomiciliation_payment_date1.Caption = "domiciliation_payment_date"
        Me.coldomiciliation_payment_date1.FieldName = "domiciliation_payment_date"
        Me.coldomiciliation_payment_date1.Name = "coldomiciliation_payment_date1"
        Me.coldomiciliation_payment_date1.Visible = True
        Me.coldomiciliation_payment_date1.VisibleIndex = 1
        '
        'colabo_id
        '
        Me.colabo_id.Caption = "abo_id"
        Me.colabo_id.FieldName = "abo_id"
        Me.colabo_id.Name = "colabo_id"
        Me.colabo_id.Visible = True
        Me.colabo_id.VisibleIndex = 2
        '
        'colcustomers_id1
        '
        Me.colcustomers_id1.Caption = "customers_id"
        Me.colcustomers_id1.FieldName = "customers_id"
        Me.colcustomers_id1.Name = "colcustomers_id1"
        '
        'colcustomers_name
        '
        Me.colcustomers_name.Caption = "customers_name"
        Me.colcustomers_name.FieldName = "customers_name"
        Me.colcustomers_name.Name = "colcustomers_name"
        '
        'colcustomers_address1
        '
        Me.colcustomers_address1.Caption = "customers_address"
        Me.colcustomers_address1.FieldName = "customers_address"
        Me.colcustomers_address1.Name = "colcustomers_address1"
        Me.colcustomers_address1.Visible = True
        Me.colcustomers_address1.VisibleIndex = 3
        '
        'colamount4
        '
        Me.colamount4.Caption = "amount"
        Me.colamount4.FieldName = "amount"
        Me.colamount4.Name = "colamount4"
        Me.colamount4.Visible = True
        Me.colamount4.VisibleIndex = 4
        '
        'colstrdomiciliation_debiter_name1
        '
        Me.colstrdomiciliation_debiter_name1.Caption = "strdomiciliation_debiter_name"
        Me.colstrdomiciliation_debiter_name1.FieldName = "strdomiciliation_debiter_name"
        Me.colstrdomiciliation_debiter_name1.Name = "colstrdomiciliation_debiter_name1"
        Me.colstrdomiciliation_debiter_name1.Visible = True
        Me.colstrdomiciliation_debiter_name1.VisibleIndex = 5
        '
        'colstrdomiciliation_number1
        '
        Me.colstrdomiciliation_number1.Caption = "strdomiciliation_number"
        Me.colstrdomiciliation_number1.FieldName = "strdomiciliation_number"
        Me.colstrdomiciliation_number1.Name = "colstrdomiciliation_number1"
        Me.colstrdomiciliation_number1.Visible = True
        Me.colstrdomiciliation_number1.VisibleIndex = 6
        '
        'colcommunication3
        '
        Me.colcommunication3.Caption = "communication"
        Me.colcommunication3.FieldName = "communication"
        Me.colcommunication3.Name = "colcommunication3"
        Me.colcommunication3.Visible = True
        Me.colcommunication3.VisibleIndex = 7
        '
        'colfirst_payment1
        '
        Me.colfirst_payment1.Caption = "first_payment"
        Me.colfirst_payment1.FieldName = "first_payment"
        Me.colfirst_payment1.Name = "colfirst_payment1"
        Me.colfirst_payment1.Visible = True
        Me.colfirst_payment1.VisibleIndex = 8
        '
        'colreconduction1
        '
        Me.colreconduction1.Caption = "reconduction"
        Me.colreconduction1.FieldName = "reconduction"
        Me.colreconduction1.Name = "colreconduction1"
        Me.colreconduction1.Visible = True
        Me.colreconduction1.VisibleIndex = 9
        '
        'coldomiciliation_payment_status1
        '
        Me.coldomiciliation_payment_status1.Caption = "payment_status"
        Me.coldomiciliation_payment_status1.FieldName = "payment_status"
        Me.coldomiciliation_payment_status1.Name = "coldomiciliation_payment_status1"
        Me.coldomiciliation_payment_status1.Visible = True
        Me.coldomiciliation_payment_status1.VisibleIndex = 10
        '
        'coldomiciliation_payment_isabel_date1
        '
        Me.coldomiciliation_payment_isabel_date1.Caption = "domiciliation_payment_isabel_date"
        Me.coldomiciliation_payment_isabel_date1.FieldName = "domiciliation_payment_isabel_date"
        Me.coldomiciliation_payment_isabel_date1.Name = "coldomiciliation_payment_isabel_date1"
        Me.coldomiciliation_payment_isabel_date1.Visible = True
        Me.coldomiciliation_payment_isabel_date1.VisibleIndex = 11
        '
        'coldomiciliation_unpaid_id1
        '
        Me.coldomiciliation_unpaid_id1.Caption = "domiciliation_unpaid_id"
        Me.coldomiciliation_unpaid_id1.FieldName = "domiciliation_unpaid_id"
        Me.coldomiciliation_unpaid_id1.Name = "coldomiciliation_unpaid_id1"
        Me.coldomiciliation_unpaid_id1.Visible = True
        Me.coldomiciliation_unpaid_id1.VisibleIndex = 12
        '
        'colbatch_immatriculation_number1
        '
        Me.colbatch_immatriculation_number1.Caption = "batch_immatriculation_number"
        Me.colbatch_immatriculation_number1.FieldName = "batch_immatriculation_number"
        Me.colbatch_immatriculation_number1.Name = "colbatch_immatriculation_number1"
        Me.colbatch_immatriculation_number1.Visible = True
        Me.colbatch_immatriculation_number1.VisibleIndex = 13
        '
        'collast_modified4
        '
        Me.collast_modified4.Caption = "last_modified"
        Me.collast_modified4.FieldName = "last_modified"
        Me.collast_modified4.Name = "collast_modified4"
        Me.collast_modified4.Visible = True
        Me.collast_modified4.VisibleIndex = 14
        '
        'colabo_stopped_with_dvdathome_id1
        '
        Me.colabo_stopped_with_dvdathome_id1.Caption = "abo_stopped_with_dvdathome_id"
        Me.colabo_stopped_with_dvdathome_id1.FieldName = "abo_stopped_with_dvdathome_id"
        Me.colabo_stopped_with_dvdathome_id1.Name = "colabo_stopped_with_dvdathome_id1"
        Me.colabo_stopped_with_dvdathome_id1.Visible = True
        Me.colabo_stopped_with_dvdathome_id1.VisibleIndex = 15
        '
        'cologone_payment_id4
        '
        Me.cologone_payment_id4.Caption = "ogone_payment_id"
        Me.cologone_payment_id4.FieldName = "ogone_payment_id"
        Me.cologone_payment_id4.Name = "cologone_payment_id4"
        Me.cologone_payment_id4.Visible = True
        Me.cologone_payment_id4.VisibleIndex = 0
        '
        'coldate_added1
        '
        Me.coldate_added1.Caption = "date_added"
        Me.coldate_added1.FieldName = "date_added"
        Me.coldate_added1.Name = "coldate_added1"
        Me.coldate_added1.Visible = True
        Me.coldate_added1.VisibleIndex = 1
        '
        'colabo_id3
        '
        Me.colabo_id3.Caption = "abo_id"
        Me.colabo_id3.FieldName = "abo_id"
        Me.colabo_id3.Name = "colabo_id3"
        Me.colabo_id3.Visible = True
        Me.colabo_id3.VisibleIndex = 2
        '
        'colcustomers_id2
        '
        Me.colcustomers_id2.Caption = "customers_id"
        Me.colcustomers_id2.FieldName = "customers_id"
        Me.colcustomers_id2.Name = "colcustomers_id2"
        '
        'colamount5
        '
        Me.colamount5.Caption = "amount"
        Me.colamount5.FieldName = "amount"
        Me.colamount5.Name = "colamount5"
        Me.colamount5.Visible = True
        Me.colamount5.VisibleIndex = 3
        '
        'cologone_payment_status1
        '
        Me.cologone_payment_status1.Caption = "ogone_payment_status"
        Me.cologone_payment_status1.FieldName = "ogone_payment_status"
        Me.cologone_payment_status1.Name = "cologone_payment_status1"
        Me.cologone_payment_status1.Visible = True
        Me.cologone_payment_status1.VisibleIndex = 4
        '
        'cologone_batch_id1
        '
        Me.cologone_batch_id1.Caption = "ogone_batch_id"
        Me.cologone_batch_id1.FieldName = "ogone_batch_id"
        Me.cologone_batch_id1.Name = "cologone_batch_id1"
        Me.cologone_batch_id1.Visible = True
        Me.cologone_batch_id1.VisibleIndex = 5
        '
        'collast_modified5
        '
        Me.collast_modified5.Caption = "last_modified"
        Me.collast_modified5.FieldName = "last_modified"
        Me.collast_modified5.Name = "collast_modified5"
        Me.collast_modified5.Visible = True
        Me.collast_modified5.VisibleIndex = 6
        '
        'colcustserv_id1
        '
        Me.colcustserv_id1.Caption = "custserv_id"
        Me.colcustserv_id1.FieldName = "custserv_id"
        Me.colcustserv_id1.Name = "colcustserv_id1"
        Me.colcustserv_id1.Visible = True
        Me.colcustserv_id1.VisibleIndex = 0
        '
        'colcustomers_id3
        '
        Me.colcustomers_id3.Caption = "customers_id"
        Me.colcustomers_id3.FieldName = "customers_id"
        Me.colcustomers_id3.Name = "colcustomers_id3"
        Me.colcustomers_id3.Visible = True
        Me.colcustomers_id3.VisibleIndex = 1
        '
        'collanguage_id1
        '
        Me.collanguage_id1.Caption = "language_id"
        Me.collanguage_id1.FieldName = "language_id"
        Me.collanguage_id1.Name = "collanguage_id1"
        Me.collanguage_id1.Visible = True
        Me.collanguage_id1.VisibleIndex = 2
        '
        'colcustserv_cat_id1
        '
        Me.colcustserv_cat_id1.Caption = "custserv_cat_id"
        Me.colcustserv_cat_id1.FieldName = "custserv_cat_id"
        Me.colcustserv_cat_id1.Name = "colcustserv_cat_id1"
        Me.colcustserv_cat_id1.Visible = True
        Me.colcustserv_cat_id1.VisibleIndex = 3
        '
        'colcustomer_date1
        '
        Me.colcustomer_date1.Caption = "customer_date"
        Me.colcustomer_date1.FieldName = "customer_date"
        Me.colcustomer_date1.Name = "colcustomer_date1"
        Me.colcustomer_date1.Visible = True
        Me.colcustomer_date1.VisibleIndex = 4
        '
        'colorders_id
        '
        Me.colorders_id.Caption = "orders_id"
        Me.colorders_id.FieldName = "orders_id"
        Me.colorders_id.Name = "colorders_id"
        Me.colorders_id.Visible = True
        Me.colorders_id.VisibleIndex = 5
        '
        'colproducts_id
        '
        Me.colproducts_id.Caption = "products_id"
        Me.colproducts_id.FieldName = "products_id"
        Me.colproducts_id.Name = "colproducts_id"
        Me.colproducts_id.Visible = True
        Me.colproducts_id.VisibleIndex = 6
        '
        'coldvd_id1
        '
        Me.coldvd_id1.Caption = "dvd_id"
        Me.coldvd_id1.FieldName = "dvd_id"
        Me.coldvd_id1.Name = "coldvd_id1"
        Me.coldvd_id1.Visible = True
        Me.coldvd_id1.VisibleIndex = 7
        '
        'colsubject1
        '
        Me.colsubject1.Caption = "subject"
        Me.colsubject1.FieldName = "subject"
        Me.colsubject1.Name = "colsubject1"
        Me.colsubject1.Visible = True
        Me.colsubject1.VisibleIndex = 8
        '
        'colmessage1
        '
        Me.colmessage1.Caption = "message"
        Me.colmessage1.FieldName = "message"
        Me.colmessage1.Name = "colmessage1"
        Me.colmessage1.Visible = True
        Me.colmessage1.VisibleIndex = 9
        '
        'coladmindate1
        '
        Me.coladmindate1.Caption = "admindate"
        Me.coladmindate1.FieldName = "admindate"
        Me.coladmindate1.Name = "coladmindate1"
        Me.coladmindate1.Visible = True
        Me.coladmindate1.VisibleIndex = 10
        '
        'coladminby1
        '
        Me.coladminby1.Caption = "adminby"
        Me.coladminby1.FieldName = "adminby"
        Me.coladminby1.Name = "coladminby1"
        Me.coladminby1.Visible = True
        Me.coladminby1.VisibleIndex = 11
        '
        'coladminmessage1
        '
        Me.coladminmessage1.Caption = "adminmessage"
        Me.coladminmessage1.FieldName = "adminmessage"
        Me.coladminmessage1.Name = "coladminmessage1"
        Me.coladminmessage1.Visible = True
        Me.coladminmessage1.VisibleIndex = 12
        '
        'colmessagesent1
        '
        Me.colmessagesent1.Caption = "messagesent"
        Me.colmessagesent1.FieldName = "messagesent"
        Me.colmessagesent1.Name = "colmessagesent1"
        Me.colmessagesent1.Visible = True
        Me.colmessagesent1.VisibleIndex = 13
        '
        'coldvd_finally_arrived_mail1
        '
        Me.coldvd_finally_arrived_mail1.Caption = "dvd_finally_arrived_mail"
        Me.coldvd_finally_arrived_mail1.FieldName = "dvd_finally_arrived_mail"
        Me.coldvd_finally_arrived_mail1.Name = "coldvd_finally_arrived_mail1"
        Me.coldvd_finally_arrived_mail1.Visible = True
        Me.coldvd_finally_arrived_mail1.VisibleIndex = 14
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_city", True))
        Me.TextEdit3.Enabled = False
        Me.TextEdit3.Location = New System.Drawing.Point(280, 72)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(312, 20)
        Me.TextEdit3.TabIndex = 13
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_postcode", True))
        Me.TextEdit4.Enabled = False
        Me.TextEdit4.Location = New System.Drawing.Point(152, 72)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(120, 20)
        Me.TextEdit4.TabIndex = 12
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_street_address", True))
        Me.TextEdit5.Enabled = False
        Me.TextEdit5.Location = New System.Drawing.Point(152, 48)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Size = New System.Drawing.Size(224, 20)
        Me.TextEdit5.TabIndex = 10
        '
        'LCNumDom
        '
        Me.LCNumDom.Location = New System.Drawing.Point(16, 56)
        Me.LCNumDom.Name = "LCNumDom"
        Me.LCNumDom.Size = New System.Drawing.Size(45, 13)
        Me.LCNumDom.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.LCNumDom, "number of domiciliation ")
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(1021, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(144, 23)
        Me.SimpleButton1.TabIndex = 12
        Me.SimpleButton1.Text = "test"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.objDS.payment_offline_status
        Me.RepositoryItemLookUpEdit2.DisplayMember = "name"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "id"
        '
        'TabMailHistory
        '
        Me.TabMailHistory.AutoScroll = True
        Me.TabMailHistory.Controls.Add(Me.browser)
        Me.TabMailHistory.Controls.Add(Me.grpContEmail)
        Me.TabMailHistory.Name = "TabMailHistory"
        Me.TabMailHistory.Size = New System.Drawing.Size(1150, 917)
        Me.TabMailHistory.Text = "mail sended"
        '
        'browser
        '
        Me.browser.Location = New System.Drawing.Point(7, 387)
        Me.browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.browser.Name = "browser"
        Me.browser.Size = New System.Drawing.Size(1162, 450)
        Me.browser.TabIndex = 18
        '
        'grpContEmail
        '
        Me.grpContEmail.EmbeddedNavigator.Name = ""
        Me.grpContEmail.FormsUseDefaultLookAndFeel = False
        Me.grpContEmail.Location = New System.Drawing.Point(3, 33)
        Me.grpContEmail.MainView = Me.GridViewMail
        Me.grpContEmail.Name = "grpContEmail"
        Me.grpContEmail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit6})
        Me.grpContEmail.Size = New System.Drawing.Size(1166, 350)
        Me.grpContEmail.TabIndex = 16
        Me.grpContEmail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewMail})
        '
        'GridViewMail
        '
        Me.GridViewMail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.messages_subject, Me.messages_title, Me.mail_opened_date, Me.mail_opened, Me.date_sended, Me.messages_html})
        Me.GridViewMail.CustomizationFormBounds = New System.Drawing.Rectangle(513, 252, 296, 323)
        Me.GridViewMail.GridControl = Me.grpContEmail
        Me.GridViewMail.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewMail.Name = "GridViewMail"
        Me.GridViewMail.OptionsView.ShowFooter = True
        '
        'messages_subject
        '
        Me.messages_subject.Caption = "messages_subject"
        Me.messages_subject.FieldName = "messages_subject"
        Me.messages_subject.Name = "messages_subject"
        Me.messages_subject.OptionsColumn.AllowEdit = False
        Me.messages_subject.OptionsColumn.ReadOnly = True
        Me.messages_subject.Visible = True
        Me.messages_subject.VisibleIndex = 1
        Me.messages_subject.Width = 229
        '
        'messages_title
        '
        Me.messages_title.Caption = "messages_title"
        Me.messages_title.FieldName = "messages_title"
        Me.messages_title.Name = "messages_title"
        Me.messages_title.OptionsColumn.AllowEdit = False
        Me.messages_title.OptionsColumn.ReadOnly = True
        Me.messages_title.Visible = True
        Me.messages_title.VisibleIndex = 2
        Me.messages_title.Width = 292
        '
        'mail_opened_date
        '
        Me.mail_opened_date.Caption = "mail_opened_date"
        Me.mail_opened_date.FieldName = "mail_opened_date"
        Me.mail_opened_date.Name = "mail_opened_date"
        Me.mail_opened_date.OptionsColumn.AllowEdit = False
        Me.mail_opened_date.OptionsColumn.ReadOnly = True
        Me.mail_opened_date.Visible = True
        Me.mail_opened_date.VisibleIndex = 3
        Me.mail_opened_date.Width = 137
        '
        'mail_opened
        '
        Me.mail_opened.Caption = "mail_opened"
        Me.mail_opened.FieldName = "mail_opened"
        Me.mail_opened.Name = "mail_opened"
        Me.mail_opened.OptionsColumn.AllowEdit = False
        Me.mail_opened.OptionsColumn.ReadOnly = True
        Me.mail_opened.Visible = True
        Me.mail_opened.VisibleIndex = 4
        Me.mail_opened.Width = 84
        '
        'date_sended
        '
        Me.date_sended.Caption = "date_sended"
        Me.date_sended.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.date_sended.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.date_sended.FieldName = "date"
        Me.date_sended.Name = "date_sended"
        Me.date_sended.OptionsColumn.AllowEdit = False
        Me.date_sended.OptionsColumn.ReadOnly = True
        Me.date_sended.Visible = True
        Me.date_sended.VisibleIndex = 0
        Me.date_sended.Width = 114
        '
        'messages_html
        '
        Me.messages_html.Caption = "messages_html"
        Me.messages_html.FieldName = "messages_html"
        Me.messages_html.Name = "messages_html"
        Me.messages_html.OptionsColumn.AllowEdit = False
        Me.messages_html.OptionsColumn.ReadOnly = True
        Me.messages_html.Width = 801
        '
        'RepositoryItemLookUpEdit6
        '
        Me.RepositoryItemLookUpEdit6.AutoHeight = False
        Me.RepositoryItemLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit6.DataSource = Me.objDS.custserv_cat
        Me.RepositoryItemLookUpEdit6.DisplayMember = "custserv_cat_name"
        Me.RepositoryItemLookUpEdit6.Name = "RepositoryItemLookUpEdit6"
        Me.RepositoryItemLookUpEdit6.ValueMember = "custserv_cat_id"
        '
        'tabAboProcess
        '
        Me.tabAboProcess.Controls.Add(Me.GridAboprocessStats)
        Me.tabAboProcess.Name = "tabAboProcess"
        Me.tabAboProcess.Size = New System.Drawing.Size(1150, 917)
        Me.tabAboProcess.Text = "aboProcess"
        '
        'GridAboprocessStats
        '
        Me.GridAboprocessStats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAboprocessStats.EmbeddedNavigator.Name = ""
        Me.GridAboprocessStats.FormsUseDefaultLookAndFeel = False
        Me.GridAboprocessStats.Location = New System.Drawing.Point(0, 0)
        Me.GridAboprocessStats.MainView = Me.GridViewAboprocessStats
        Me.GridAboprocessStats.Name = "GridAboprocessStats"
        Me.GridAboprocessStats.Size = New System.Drawing.Size(1150, 917)
        Me.GridAboprocessStats.TabIndex = 0
        Me.GridAboprocessStats.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewAboprocessStats})
        '
        'GridViewAboprocessStats
        '
        Me.GridViewAboprocessStats.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.dvd_norm_to_send, Me.dvd_adult_to_send, Me.dvd_highsent, Me.dvd_mediumsent, Me.dvd_lowsent, Me.dvd_norm_abo, Me.dvd_adult_abo, Me.dvd_norm_compensation, Me.dvd_adult_compensation, Me.dvd_norm_home, Me.dvd_adult_home, Me.creditABoProcess, Me.customer_abo_rank, Me.msgerror, Me.nbdvdfindnorm, Me.nbdvdfindadult, Me.nbwishlistadult, Me.nbwishlistnorm, Me.label, Me.date_start})
        Me.GridViewAboprocessStats.GridControl = Me.GridAboprocessStats
        Me.GridViewAboprocessStats.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewAboprocessStats.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridViewAboprocessStats.Name = "GridViewAboprocessStats"
        Me.GridViewAboprocessStats.OptionsView.ColumnAutoWidth = False
        Me.GridViewAboprocessStats.OptionsView.ShowFooter = True
        '
        'dvd_norm_to_send
        '
        Me.dvd_norm_to_send.Caption = "dvd_norm_to_send"
        Me.dvd_norm_to_send.FieldName = "dvd_norm_to_send"
        Me.dvd_norm_to_send.Name = "dvd_norm_to_send"
        Me.dvd_norm_to_send.OptionsColumn.AllowEdit = False
        Me.dvd_norm_to_send.OptionsColumn.FixedWidth = True
        Me.dvd_norm_to_send.OptionsColumn.ReadOnly = True
        Me.dvd_norm_to_send.Visible = True
        Me.dvd_norm_to_send.VisibleIndex = 2
        Me.dvd_norm_to_send.Width = 117
        '
        'dvd_adult_to_send
        '
        Me.dvd_adult_to_send.Caption = "dvd_adult_to_send"
        Me.dvd_adult_to_send.FieldName = "dvd_adult_to_send"
        Me.dvd_adult_to_send.Name = "dvd_adult_to_send"
        Me.dvd_adult_to_send.OptionsColumn.AllowEdit = False
        Me.dvd_adult_to_send.OptionsColumn.FixedWidth = True
        Me.dvd_adult_to_send.OptionsColumn.ReadOnly = True
        Me.dvd_adult_to_send.Visible = True
        Me.dvd_adult_to_send.VisibleIndex = 3
        Me.dvd_adult_to_send.Width = 125
        '
        'dvd_highsent
        '
        Me.dvd_highsent.Caption = "dvd_highsent"
        Me.dvd_highsent.FieldName = "dvd_highsent"
        Me.dvd_highsent.Name = "dvd_highsent"
        Me.dvd_highsent.OptionsColumn.AllowEdit = False
        Me.dvd_highsent.OptionsColumn.FixedWidth = True
        Me.dvd_highsent.OptionsColumn.ReadOnly = True
        Me.dvd_highsent.Visible = True
        Me.dvd_highsent.VisibleIndex = 4
        Me.dvd_highsent.Width = 104
        '
        'dvd_mediumsent
        '
        Me.dvd_mediumsent.Caption = "dvd_mediumsent"
        Me.dvd_mediumsent.FieldName = "dvd_mediumsent"
        Me.dvd_mediumsent.Name = "dvd_mediumsent"
        Me.dvd_mediumsent.OptionsColumn.AllowEdit = False
        Me.dvd_mediumsent.OptionsColumn.FixedWidth = True
        Me.dvd_mediumsent.OptionsColumn.ReadOnly = True
        Me.dvd_mediumsent.Visible = True
        Me.dvd_mediumsent.VisibleIndex = 5
        Me.dvd_mediumsent.Width = 107
        '
        'dvd_lowsent
        '
        Me.dvd_lowsent.Caption = "dvd_lowsent"
        Me.dvd_lowsent.FieldName = "dvd_lowsent"
        Me.dvd_lowsent.Name = "dvd_lowsent"
        Me.dvd_lowsent.OptionsColumn.AllowEdit = False
        Me.dvd_lowsent.OptionsColumn.FixedWidth = True
        Me.dvd_lowsent.OptionsColumn.ReadOnly = True
        Me.dvd_lowsent.Visible = True
        Me.dvd_lowsent.VisibleIndex = 6
        '
        'dvd_norm_abo
        '
        Me.dvd_norm_abo.Caption = "dvd_norm_abo"
        Me.dvd_norm_abo.FieldName = "dvd_norm_abo"
        Me.dvd_norm_abo.Name = "dvd_norm_abo"
        Me.dvd_norm_abo.OptionsColumn.AllowEdit = False
        Me.dvd_norm_abo.OptionsColumn.FixedWidth = True
        Me.dvd_norm_abo.OptionsColumn.ReadOnly = True
        Me.dvd_norm_abo.Visible = True
        Me.dvd_norm_abo.VisibleIndex = 7
        Me.dvd_norm_abo.Width = 104
        '
        'dvd_adult_abo
        '
        Me.dvd_adult_abo.Caption = "dvd_adult_abo"
        Me.dvd_adult_abo.FieldName = "dvd_adult_abo"
        Me.dvd_adult_abo.Name = "dvd_adult_abo"
        Me.dvd_adult_abo.OptionsColumn.AllowEdit = False
        Me.dvd_adult_abo.OptionsColumn.FixedWidth = True
        Me.dvd_adult_abo.OptionsColumn.ReadOnly = True
        Me.dvd_adult_abo.Visible = True
        Me.dvd_adult_abo.VisibleIndex = 8
        Me.dvd_adult_abo.Width = 95
        '
        'dvd_norm_compensation
        '
        Me.dvd_norm_compensation.Caption = "dvd_norm_compensation"
        Me.dvd_norm_compensation.FieldName = "dvd_norm_compensation"
        Me.dvd_norm_compensation.Name = "dvd_norm_compensation"
        Me.dvd_norm_compensation.OptionsColumn.AllowEdit = False
        Me.dvd_norm_compensation.OptionsColumn.FixedWidth = True
        Me.dvd_norm_compensation.OptionsColumn.ReadOnly = True
        Me.dvd_norm_compensation.Visible = True
        Me.dvd_norm_compensation.VisibleIndex = 9
        Me.dvd_norm_compensation.Width = 130
        '
        'dvd_adult_compensation
        '
        Me.dvd_adult_compensation.Caption = "dvd_adult_compensation"
        Me.dvd_adult_compensation.FieldName = "dvd_adult_compensation"
        Me.dvd_adult_compensation.Name = "dvd_adult_compensation"
        Me.dvd_adult_compensation.OptionsColumn.AllowEdit = False
        Me.dvd_adult_compensation.OptionsColumn.FixedWidth = True
        Me.dvd_adult_compensation.OptionsColumn.ReadOnly = True
        Me.dvd_adult_compensation.Visible = True
        Me.dvd_adult_compensation.VisibleIndex = 10
        Me.dvd_adult_compensation.Width = 155
        '
        'dvd_norm_home
        '
        Me.dvd_norm_home.Caption = "dvd_norm_home"
        Me.dvd_norm_home.FieldName = "dvd_norm_home"
        Me.dvd_norm_home.Name = "dvd_norm_home"
        Me.dvd_norm_home.OptionsColumn.AllowEdit = False
        Me.dvd_norm_home.OptionsColumn.FixedWidth = True
        Me.dvd_norm_home.OptionsColumn.ReadOnly = True
        Me.dvd_norm_home.Visible = True
        Me.dvd_norm_home.VisibleIndex = 11
        Me.dvd_norm_home.Width = 97
        '
        'dvd_adult_home
        '
        Me.dvd_adult_home.Caption = "dvd_adult_home"
        Me.dvd_adult_home.FieldName = "dvd_adult_home"
        Me.dvd_adult_home.Name = "dvd_adult_home"
        Me.dvd_adult_home.OptionsColumn.AllowEdit = False
        Me.dvd_adult_home.OptionsColumn.FixedWidth = True
        Me.dvd_adult_home.OptionsColumn.ReadOnly = True
        Me.dvd_adult_home.Visible = True
        Me.dvd_adult_home.VisibleIndex = 12
        Me.dvd_adult_home.Width = 127
        '
        'creditABoProcess
        '
        Me.creditABoProcess.Caption = " credit"
        Me.creditABoProcess.FieldName = " credit"
        Me.creditABoProcess.Name = "creditABoProcess"
        Me.creditABoProcess.OptionsColumn.AllowEdit = False
        Me.creditABoProcess.OptionsColumn.FixedWidth = True
        Me.creditABoProcess.OptionsColumn.ReadOnly = True
        '
        'customer_abo_rank
        '
        Me.customer_abo_rank.Caption = "customer_abo_rank"
        Me.customer_abo_rank.FieldName = "customer_abo_rank"
        Me.customer_abo_rank.Name = "customer_abo_rank"
        Me.customer_abo_rank.OptionsColumn.AllowEdit = False
        Me.customer_abo_rank.OptionsColumn.FixedWidth = True
        Me.customer_abo_rank.OptionsColumn.ReadOnly = True
        Me.customer_abo_rank.Width = 123
        '
        'msgerror
        '
        Me.msgerror.Caption = "msgerror"
        Me.msgerror.FieldName = "msgerror"
        Me.msgerror.Name = "msgerror"
        Me.msgerror.OptionsColumn.AllowEdit = False
        Me.msgerror.OptionsColumn.FixedWidth = True
        Me.msgerror.OptionsColumn.ReadOnly = True
        Me.msgerror.Visible = True
        Me.msgerror.VisibleIndex = 13
        '
        'nbdvdfindnorm
        '
        Me.nbdvdfindnorm.Caption = "nbdvdfindnorm"
        Me.nbdvdfindnorm.FieldName = "nbdvdfindnorm"
        Me.nbdvdfindnorm.Name = "nbdvdfindnorm"
        Me.nbdvdfindnorm.OptionsColumn.AllowEdit = False
        Me.nbdvdfindnorm.OptionsColumn.FixedWidth = True
        Me.nbdvdfindnorm.OptionsColumn.ReadOnly = True
        Me.nbdvdfindnorm.Visible = True
        Me.nbdvdfindnorm.VisibleIndex = 14
        Me.nbdvdfindnorm.Width = 94
        '
        'nbdvdfindadult
        '
        Me.nbdvdfindadult.Caption = "nbdvdfindadult"
        Me.nbdvdfindadult.FieldName = "nbdvdfindadult"
        Me.nbdvdfindadult.Name = "nbdvdfindadult"
        Me.nbdvdfindadult.OptionsColumn.AllowEdit = False
        Me.nbdvdfindadult.OptionsColumn.FixedWidth = True
        Me.nbdvdfindadult.OptionsColumn.ReadOnly = True
        Me.nbdvdfindadult.Visible = True
        Me.nbdvdfindadult.VisibleIndex = 15
        Me.nbdvdfindadult.Width = 94
        '
        'nbwishlistadult
        '
        Me.nbwishlistadult.Caption = "nbwishlistadult"
        Me.nbwishlistadult.FieldName = "nbwishlistadult"
        Me.nbwishlistadult.Name = "nbwishlistadult"
        Me.nbwishlistadult.OptionsColumn.AllowEdit = False
        Me.nbwishlistadult.OptionsColumn.FixedWidth = True
        Me.nbwishlistadult.OptionsColumn.ReadOnly = True
        Me.nbwishlistadult.Visible = True
        Me.nbwishlistadult.VisibleIndex = 16
        Me.nbwishlistadult.Width = 81
        '
        'nbwishlistnorm
        '
        Me.nbwishlistnorm.Caption = "nbwishlistnorm"
        Me.nbwishlistnorm.FieldName = "nbwishlistnorm"
        Me.nbwishlistnorm.Name = "nbwishlistnorm"
        Me.nbwishlistnorm.OptionsColumn.AllowEdit = False
        Me.nbwishlistnorm.OptionsColumn.FixedWidth = True
        Me.nbwishlistnorm.OptionsColumn.ReadOnly = True
        Me.nbwishlistnorm.Visible = True
        Me.nbwishlistnorm.VisibleIndex = 17
        Me.nbwishlistnorm.Width = 83
        '
        'label
        '
        Me.label.Caption = "status"
        Me.label.FieldName = "label"
        Me.label.Name = "label"
        Me.label.OptionsColumn.AllowEdit = False
        Me.label.OptionsColumn.FixedWidth = True
        Me.label.OptionsColumn.ReadOnly = True
        Me.label.Visible = True
        Me.label.VisibleIndex = 1
        '
        'date_start
        '
        Me.date_start.Caption = "date_start"
        Me.date_start.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.date_start.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.date_start.FieldName = "date_start"
        Me.date_start.Name = "date_start"
        Me.date_start.OptionsColumn.AllowEdit = False
        Me.date_start.OptionsColumn.FixedWidth = True
        Me.date_start.OptionsColumn.ReadOnly = True
        Me.date_start.Visible = True
        Me.date_start.VisibleIndex = 0
        '
        'GridCustServ
        '
        Me.GridCustServ.Dock = System.Windows.Forms.DockStyle.Left
        Me.GridCustServ.EmbeddedNavigator.Name = ""
        Me.GridCustServ.FormsUseDefaultLookAndFeel = False
        Me.GridCustServ.Location = New System.Drawing.Point(0, 0)
        Me.GridCustServ.MainView = Me.gridViewCustServ
        Me.GridCustServ.Name = "GridCustServ"
        Me.GridCustServ.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbCustServ_cat})
        Me.GridCustServ.Size = New System.Drawing.Size(672, 917)
        Me.GridCustServ.TabIndex = 1
        Me.GridCustServ.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewCustServ})
        '
        'gridViewCustServ
        '
        Me.gridViewCustServ.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcustserv2_id, Me.colcustomers2_id6, Me.collanguage2_id, Me.custserv_cat_name2, Me.colcustomer2_date, Me.colorders2_id1, Me.colproducts2_id2, Me.coldvd2_id, Me.colsubject3, Me.colmessage3, Me.coladmindate3, Me.coladminmessage3, Me.colmessagesent3, coldvd_finally_arrived_mail3})
        Me.gridViewCustServ.CustomizationFormBounds = New System.Drawing.Rectangle(1694, 898, 216, 178)
        Me.gridViewCustServ.GridControl = Me.GridCustServ
        Me.gridViewCustServ.Name = "gridViewCustServ"
        '
        'colcustserv2_id
        '
        Me.colcustserv2_id.Caption = "custserv_id"
        Me.colcustserv2_id.FieldName = "colcustserv_id"
        Me.colcustserv2_id.Name = "colcustserv2_id"
        Me.colcustserv2_id.OptionsColumn.AllowEdit = False
        Me.colcustserv2_id.OptionsColumn.ReadOnly = True
        '
        'collanguage2_id
        '
        Me.collanguage2_id.Caption = "language_id"
        Me.collanguage2_id.FieldName = "language_id"
        Me.collanguage2_id.Name = "collanguage2_id"
        Me.collanguage2_id.OptionsColumn.AllowEdit = False
        Me.collanguage2_id.OptionsColumn.ReadOnly = True
        '
        'custserv_cat_name2
        '
        Me.custserv_cat_name2.Caption = "custserv_cat_name"
        Me.custserv_cat_name2.FieldName = "custserv_cat_name"
        Me.custserv_cat_name2.Name = "custserv_cat_name2"
        Me.custserv_cat_name2.OptionsColumn.AllowEdit = False
        Me.custserv_cat_name2.OptionsColumn.ReadOnly = True
        Me.custserv_cat_name2.Visible = True
        Me.custserv_cat_name2.VisibleIndex = 1
        '
        'colcustomer2_date
        '
        Me.colcustomer2_date.Caption = "customer_date"
        Me.colcustomer2_date.DisplayFormat.FormatString = "ddd/MM/yyyy HH:mm:ss"
        Me.colcustomer2_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colcustomer2_date.FieldName = "customer_date"
        Me.colcustomer2_date.Name = "colcustomer2_date"
        Me.colcustomer2_date.OptionsColumn.AllowEdit = False
        Me.colcustomer2_date.OptionsColumn.ReadOnly = True
        Me.colcustomer2_date.Visible = True
        Me.colcustomer2_date.VisibleIndex = 0
        '
        'colorders2_id1
        '
        Me.colorders2_id1.Caption = "orders_id"
        Me.colorders2_id1.FieldName = "orders_id"
        Me.colorders2_id1.Name = "colorders2_id1"
        Me.colorders2_id1.OptionsColumn.AllowEdit = False
        Me.colorders2_id1.OptionsColumn.ReadOnly = True
        '
        'colproducts2_id2
        '
        Me.colproducts2_id2.Caption = "products_id"
        Me.colproducts2_id2.FieldName = "products_id2"
        Me.colproducts2_id2.Name = "colproducts2_id2"
        Me.colproducts2_id2.OptionsColumn.AllowEdit = False
        Me.colproducts2_id2.OptionsColumn.ReadOnly = True
        '
        'coldvd2_id
        '
        Me.coldvd2_id.Caption = "dvd_id"
        Me.coldvd2_id.FieldName = "dvd_id"
        Me.coldvd2_id.Name = "coldvd2_id"
        Me.coldvd2_id.OptionsColumn.AllowEdit = False
        Me.coldvd2_id.OptionsColumn.ReadOnly = True
        '
        'colsubject3
        '
        Me.colsubject3.Caption = "subject"
        Me.colsubject3.FieldName = "subject"
        Me.colsubject3.Name = "colsubject3"
        Me.colsubject3.OptionsColumn.AllowEdit = False
        Me.colsubject3.OptionsColumn.ReadOnly = True
        Me.colsubject3.Visible = True
        Me.colsubject3.VisibleIndex = 2
        '
        'colmessage3
        '
        Me.colmessage3.Caption = "message"
        Me.colmessage3.FieldName = "message"
        Me.colmessage3.Name = "colmessage3"
        Me.colmessage3.OptionsColumn.AllowEdit = False
        Me.colmessage3.OptionsColumn.ReadOnly = True
        '
        'coladmindate3
        '
        Me.coladmindate3.Caption = "admindate"
        Me.coladmindate3.FieldName = "admindate"
        Me.coladmindate3.Name = "coladmindate3"
        Me.coladmindate3.OptionsColumn.AllowEdit = False
        Me.coladmindate3.OptionsColumn.ReadOnly = True
        Me.coladmindate3.Visible = True
        Me.coladmindate3.VisibleIndex = 3
        '
        'coladminmessage3
        '
        Me.coladminmessage3.Caption = "adminmessage"
        Me.coladminmessage3.FieldName = "adminmessage"
        Me.coladminmessage3.Name = "coladminmessage3"
        Me.coladminmessage3.OptionsColumn.AllowEdit = False
        Me.coladminmessage3.OptionsColumn.ReadOnly = True
        '
        'colmessagesent3
        '
        Me.colmessagesent3.Caption = "messagesent"
        Me.colmessagesent3.FieldName = "messagesent"
        Me.colmessagesent3.Name = "colmessagesent3"
        Me.colmessagesent3.OptionsColumn.AllowEdit = False
        Me.colmessagesent3.OptionsColumn.ReadOnly = True
        Me.colmessagesent3.Visible = True
        Me.colmessagesent3.VisibleIndex = 4
        '
        'cmbCustServ_cat
        '
        Me.cmbCustServ_cat.Name = "cmbCustServ_cat"
        '
        'tabDroselia
        '
        Me.tabDroselia.Appearance.PageClient.BackColor = System.Drawing.Color.Gray
        Me.tabDroselia.Appearance.PageClient.Options.UseBackColor = True
        Me.tabDroselia.Controls.Add(Me.LabelControl38)
        Me.tabDroselia.Controls.Add(Me.txtDroselia)
        Me.tabDroselia.Controls.Add(Me.GridDroselia)
        Me.tabDroselia.Controls.Add(Me.butGenCode)
        Me.tabDroselia.Name = "tabDroselia"
        Me.tabDroselia.Size = New System.Drawing.Size(1150, 917)
        Me.tabDroselia.Text = "Droselia"
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(3, 17)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(135, 13)
        Me.LabelControl38.TabIndex = 22
        Me.LabelControl38.Text = "number of code to generate"
        '
        'txtDroselia
        '
        Me.txtDroselia.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDroselia.Location = New System.Drawing.Point(145, 14)
        Me.txtDroselia.Name = "txtDroselia"
        Me.txtDroselia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDroselia.Properties.MaxLength = 1000
        Me.txtDroselia.Properties.MaxValue = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.txtDroselia.Size = New System.Drawing.Size(65, 20)
        Me.txtDroselia.TabIndex = 21
        '
        'GridDroselia
        '
        Me.GridDroselia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDroselia.EmbeddedNavigator.Name = ""
        Me.GridDroselia.FormsUseDefaultLookAndFeel = False
        Me.GridDroselia.Location = New System.Drawing.Point(0, 58)
        Me.GridDroselia.MainView = Me.GridViewDroselia
        Me.GridDroselia.Name = "GridDroselia"
        Me.GridDroselia.Size = New System.Drawing.Size(1150, 859)
        Me.GridDroselia.TabIndex = 16
        Me.GridDroselia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDroselia})
        '
        'GridViewDroselia
        '
        Me.GridViewDroselia.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.droselia_codes, Me.droselia_buy_date, Me.droselia_used_date, Me.catalog_id, Me.droselia_url_link})
        Me.GridViewDroselia.GridControl = Me.GridDroselia
        Me.GridViewDroselia.Name = "GridViewDroselia"
        Me.GridViewDroselia.OptionsView.ColumnAutoWidth = False
        Me.GridViewDroselia.OptionsView.ShowFooter = True
        '
        'droselia_codes
        '
        Me.droselia_codes.Caption = "droselia_codes"
        Me.droselia_codes.FieldName = "droselia_codes"
        Me.droselia_codes.Name = "droselia_codes"
        Me.droselia_codes.OptionsColumn.AllowEdit = False
        Me.droselia_codes.OptionsColumn.FixedWidth = True
        Me.droselia_codes.OptionsColumn.ReadOnly = True
        Me.droselia_codes.Visible = True
        Me.droselia_codes.VisibleIndex = 0
        Me.droselia_codes.Width = 109
        '
        'droselia_buy_date
        '
        Me.droselia_buy_date.Caption = "buy_date"
        Me.droselia_buy_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.droselia_buy_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.droselia_buy_date.FieldName = "buy_date"
        Me.droselia_buy_date.Name = "droselia_buy_date"
        Me.droselia_buy_date.OptionsColumn.AllowEdit = False
        Me.droselia_buy_date.OptionsColumn.FixedWidth = True
        Me.droselia_buy_date.OptionsColumn.ReadOnly = True
        Me.droselia_buy_date.Visible = True
        Me.droselia_buy_date.VisibleIndex = 1
        Me.droselia_buy_date.Width = 163
        '
        'droselia_used_date
        '
        Me.droselia_used_date.Caption = "used_date"
        Me.droselia_used_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.droselia_used_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.droselia_used_date.FieldName = "used_date"
        Me.droselia_used_date.Name = "droselia_used_date"
        Me.droselia_used_date.OptionsColumn.AllowEdit = False
        Me.droselia_used_date.OptionsColumn.FixedWidth = True
        Me.droselia_used_date.OptionsColumn.ReadOnly = True
        Me.droselia_used_date.Visible = True
        Me.droselia_used_date.VisibleIndex = 2
        Me.droselia_used_date.Width = 171
        '
        'catalog_id
        '
        Me.catalog_id.Caption = "catalog_id"
        Me.catalog_id.FieldName = "catalog_id"
        Me.catalog_id.Name = "catalog_id"
        Me.catalog_id.OptionsColumn.AllowEdit = False
        Me.catalog_id.OptionsColumn.FixedWidth = True
        Me.catalog_id.OptionsColumn.ReadOnly = True
        Me.catalog_id.Visible = True
        Me.catalog_id.VisibleIndex = 3
        Me.catalog_id.Width = 93
        '
        'droselia_url_link
        '
        Me.droselia_url_link.Caption = "url_link"
        Me.droselia_url_link.FieldName = "url_link"
        Me.droselia_url_link.Name = "droselia_url_link"
        Me.droselia_url_link.OptionsColumn.AllowEdit = False
        Me.droselia_url_link.OptionsColumn.FixedWidth = True
        Me.droselia_url_link.OptionsColumn.ReadOnly = True
        Me.droselia_url_link.Visible = True
        Me.droselia_url_link.VisibleIndex = 4
        '
        'butGenCode
        '
        Me.butGenCode.Location = New System.Drawing.Point(222, 13)
        Me.butGenCode.Name = "butGenCode"
        Me.butGenCode.Size = New System.Drawing.Size(92, 23)
        Me.butGenCode.TabIndex = 11
        Me.butGenCode.Text = "Generate code"
        '
        'tabPaymentMovements
        '
        Me.tabPaymentMovements.Controls.Add(Me.GCBankAccountMovement)
        Me.tabPaymentMovements.Name = "tabPaymentMovements"
        Me.tabPaymentMovements.Size = New System.Drawing.Size(1150, 917)
        Me.tabPaymentMovements.Text = "Payment Movements"
        '
        'GCBankAccountMovement
        '
        Me.GCBankAccountMovement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCBankAccountMovement.Controls.Add(Me.GridBankAccountMovement)
        Me.GCBankAccountMovement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCBankAccountMovement.Location = New System.Drawing.Point(0, 0)
        Me.GCBankAccountMovement.Name = "GCBankAccountMovement"
        Me.GCBankAccountMovement.Size = New System.Drawing.Size(1150, 917)
        Me.GCBankAccountMovement.TabIndex = 1
        Me.GCBankAccountMovement.Text = "Bank Account movements"
        '
        'GridBankAccountMovement
        '
        Me.GridBankAccountMovement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBankAccountMovement.EmbeddedNavigator.Name = ""
        Me.GridBankAccountMovement.FormsUseDefaultLookAndFeel = False
        Me.GridBankAccountMovement.Location = New System.Drawing.Point(2, 20)
        Me.GridBankAccountMovement.MainView = Me.GVBankAccountMovement
        Me.GridBankAccountMovement.Name = "GridBankAccountMovement"
        Me.GridBankAccountMovement.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit4})
        Me.GridBankAccountMovement.Size = New System.Drawing.Size(1146, 895)
        Me.GridBankAccountMovement.TabIndex = 3
        Me.GridBankAccountMovement.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVBankAccountMovement})
        '
        'GVBankAccountMovement
        '
        Me.GVBankAccountMovement.CustomizationFormBounds = New System.Drawing.Rectangle(1113, 176, 327, 364)
        Me.GVBankAccountMovement.GridControl = Me.GridBankAccountMovement
        Me.GVBankAccountMovement.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GVBankAccountMovement.Name = "GVBankAccountMovement"
        Me.GVBankAccountMovement.OptionsBehavior.Editable = False
        Me.GVBankAccountMovement.OptionsView.ColumnAutoWidth = False
        Me.GVBankAccountMovement.OptionsView.ShowFooter = True
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.DataSource = Me.objDS.payment_offline_status
        Me.RepositoryItemLookUpEdit4.DisplayMember = "name"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.ValueMember = "id"
        '
        'GridOrders
        '
        Me.GridOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOrders.EmbeddedNavigator.Name = ""
        Me.GridOrders.FormsUseDefaultLookAndFeel = False
        Me.GridOrders.Location = New System.Drawing.Point(2, 20)
        Me.GridOrders.MainView = Me.GridViewOrders
        Me.GridOrders.Name = "GridOrders"
        Me.GridOrders.Size = New System.Drawing.Size(839, 895)
        Me.GridOrders.TabIndex = 1
        Me.GridOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewOrders})
        '
        'GridViewOrders
        '
        Me.GridViewOrders.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand5})
        Me.GridViewOrders.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colcustomers_street_address, Me.colcustomers_suburb, Me.colcustomers_city, Me.colcustomers_postcode, Me.colcustomers_state, Me.colcustomers_country, Me.colcustomers_telephone, Me.colcustomers_email_address1, Me.colcustomers_address_format_id, Me.coldelivery_name, Me.coldelivery_street_address, Me.coldelivery_suburb, Me.coldelivery_city, Me.coldelivery_postcode, Me.coldelivery_state, Me.coldelivery_country, Me.coldelivery_address_format_id, Me.colpayment_method1, Me.colcc_type, Me.colcc_owner, Me.colcc_number, Me.colcc_expires, Me.coldate_purchased, Me.colorders_status, Me.colorders_date_finished, Me.colcomments, Me.colcurrency, Me.colcurrency_value, Me.colsite1, Me.colsecured_mail, Me.colmultishipment_sm, Me.colorders_products_id, Me.colproducts_model, Me.colproducts_name, Me.colproducts_price, Me.colfinal_price, Me.colproducts_tax, Me.colproducts_quantity, Me.colproducts_dvd, Me.colorders_products_status, Me.colfeesharing, Me.col2orders_id, Me.products_id, Me.colorders_last_modified})
        Me.GridViewOrders.CustomizationFormBounds = New System.Drawing.Rectangle(671, 230, 217, 291)
        Me.GridViewOrders.GridControl = Me.GridOrders
        Me.GridViewOrders.GroupCount = 1
        Me.GridViewOrders.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewOrders.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "orders_status", Nothing, "")})
        Me.GridViewOrders.Name = "GridViewOrders"
        Me.GridViewOrders.OptionsBehavior.Editable = False
        Me.GridViewOrders.OptionsView.ShowBands = False
        Me.GridViewOrders.OptionsView.ShowFooter = True
        Me.GridViewOrders.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colorders_status, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridBand5
        '
        Me.GridBand5.Caption = "GridBand4"
        Me.GridBand5.Columns.Add(Me.col2orders_id)
        Me.GridBand5.Columns.Add(Me.coldate_purchased)
        Me.GridBand5.Columns.Add(Me.colorders_status)
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
        Me.GridBand5.Columns.Add(Me.colcomments)
        Me.GridBand5.Columns.Add(Me.colcurrency)
        Me.GridBand5.Columns.Add(Me.colcurrency_value)
        Me.GridBand5.Columns.Add(Me.colsite1)
        Me.GridBand5.Columns.Add(Me.colsecured_mail)
        Me.GridBand5.Columns.Add(Me.colmultishipment_sm)
        Me.GridBand5.Columns.Add(Me.colorders_products_id)
        Me.GridBand5.Columns.Add(Me.colproducts_model)
        Me.GridBand5.Columns.Add(Me.products_id)
        Me.GridBand5.Columns.Add(Me.colproducts_dvd)
        Me.GridBand5.Columns.Add(Me.colorders_last_modified)
        Me.GridBand5.Columns.Add(Me.colproducts_price)
        Me.GridBand5.Columns.Add(Me.colfinal_price)
        Me.GridBand5.Columns.Add(Me.colproducts_tax)
        Me.GridBand5.Columns.Add(Me.colproducts_quantity)
        Me.GridBand5.Columns.Add(Me.colorders_products_status)
        Me.GridBand5.Columns.Add(Me.colfeesharing)
        Me.GridBand5.MinWidth = 20
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.Width = 752
        '
        'col2orders_id
        '
        Me.col2orders_id.Caption = "orders_id"
        Me.col2orders_id.FieldName = "orders_id"
        Me.col2orders_id.Name = "col2orders_id"
        Me.col2orders_id.OptionsColumn.AllowEdit = False
        Me.col2orders_id.Visible = True
        Me.col2orders_id.Width = 70
        '
        'coldate_purchased
        '
        Me.coldate_purchased.Caption = "date_purchased"
        Me.coldate_purchased.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.coldate_purchased.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldate_purchased.FieldName = "date_purchased"
        Me.coldate_purchased.Name = "coldate_purchased"
        Me.coldate_purchased.OptionsColumn.AllowEdit = False
        Me.coldate_purchased.OptionsColumn.ReadOnly = True
        Me.coldate_purchased.Visible = True
        Me.coldate_purchased.Width = 114
        '
        'colorders_status
        '
        Me.colorders_status.Caption = "orders_status"
        Me.colorders_status.FieldName = "orders_status"
        Me.colorders_status.Name = "colorders_status"
        Me.colorders_status.OptionsColumn.AllowEdit = False
        Me.colorders_status.OptionsColumn.ReadOnly = True
        Me.colorders_status.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colorders_status.Visible = True
        Me.colorders_status.Width = 91
        '
        'colcustomers_street_address
        '
        Me.colcustomers_street_address.Caption = "customers_street_address"
        Me.colcustomers_street_address.FieldName = "customers_street_address"
        Me.colcustomers_street_address.Name = "colcustomers_street_address"
        Me.colcustomers_street_address.OptionsColumn.AllowEdit = False
        Me.colcustomers_street_address.OptionsColumn.ReadOnly = True
        '
        'colcustomers_suburb
        '
        Me.colcustomers_suburb.Caption = "customers_suburb"
        Me.colcustomers_suburb.FieldName = "customers_suburb"
        Me.colcustomers_suburb.Name = "colcustomers_suburb"
        Me.colcustomers_suburb.OptionsColumn.AllowEdit = False
        Me.colcustomers_suburb.OptionsColumn.ReadOnly = True
        '
        'colcustomers_city
        '
        Me.colcustomers_city.Caption = "customers_city"
        Me.colcustomers_city.FieldName = "customers_city"
        Me.colcustomers_city.Name = "colcustomers_city"
        Me.colcustomers_city.OptionsColumn.AllowEdit = False
        Me.colcustomers_city.OptionsColumn.ReadOnly = True
        '
        'colcustomers_postcode
        '
        Me.colcustomers_postcode.Caption = "customers_postcode"
        Me.colcustomers_postcode.FieldName = "customers_postcode"
        Me.colcustomers_postcode.Name = "colcustomers_postcode"
        Me.colcustomers_postcode.OptionsColumn.AllowEdit = False
        Me.colcustomers_postcode.OptionsColumn.ReadOnly = True
        '
        'colcustomers_state
        '
        Me.colcustomers_state.Caption = "customers_state"
        Me.colcustomers_state.FieldName = "customers_state"
        Me.colcustomers_state.Name = "colcustomers_state"
        Me.colcustomers_state.OptionsColumn.AllowEdit = False
        Me.colcustomers_state.OptionsColumn.ReadOnly = True
        '
        'colcustomers_country
        '
        Me.colcustomers_country.Caption = "customers_country"
        Me.colcustomers_country.FieldName = "customers_country"
        Me.colcustomers_country.Name = "colcustomers_country"
        Me.colcustomers_country.OptionsColumn.AllowEdit = False
        Me.colcustomers_country.OptionsColumn.ReadOnly = True
        '
        'colcustomers_telephone
        '
        Me.colcustomers_telephone.Caption = "customers_telephone"
        Me.colcustomers_telephone.FieldName = "customers_telephone"
        Me.colcustomers_telephone.Name = "colcustomers_telephone"
        Me.colcustomers_telephone.OptionsColumn.AllowEdit = False
        Me.colcustomers_telephone.OptionsColumn.ReadOnly = True
        '
        'colcustomers_email_address1
        '
        Me.colcustomers_email_address1.Caption = "customers_email_address"
        Me.colcustomers_email_address1.FieldName = "customers_email_address"
        Me.colcustomers_email_address1.Name = "colcustomers_email_address1"
        Me.colcustomers_email_address1.OptionsColumn.AllowEdit = False
        Me.colcustomers_email_address1.OptionsColumn.ReadOnly = True
        '
        'colcustomers_address_format_id
        '
        Me.colcustomers_address_format_id.Caption = "customers_address_format_id"
        Me.colcustomers_address_format_id.FieldName = "customers_address_format_id"
        Me.colcustomers_address_format_id.Name = "colcustomers_address_format_id"
        Me.colcustomers_address_format_id.OptionsColumn.AllowEdit = False
        Me.colcustomers_address_format_id.OptionsColumn.ReadOnly = True
        '
        'coldelivery_name
        '
        Me.coldelivery_name.Caption = "delivery_name"
        Me.coldelivery_name.FieldName = "delivery_name"
        Me.coldelivery_name.Name = "coldelivery_name"
        Me.coldelivery_name.OptionsColumn.AllowEdit = False
        Me.coldelivery_name.OptionsColumn.ReadOnly = True
        Me.coldelivery_name.Visible = True
        Me.coldelivery_name.Width = 94
        '
        'coldelivery_street_address
        '
        Me.coldelivery_street_address.Caption = "delivery_street_address"
        Me.coldelivery_street_address.FieldName = "delivery_street_address"
        Me.coldelivery_street_address.Name = "coldelivery_street_address"
        Me.coldelivery_street_address.OptionsColumn.AllowEdit = False
        Me.coldelivery_street_address.OptionsColumn.ReadOnly = True
        '
        'coldelivery_suburb
        '
        Me.coldelivery_suburb.Caption = "delivery_suburb"
        Me.coldelivery_suburb.FieldName = "delivery_suburb"
        Me.coldelivery_suburb.Name = "coldelivery_suburb"
        Me.coldelivery_suburb.OptionsColumn.AllowEdit = False
        Me.coldelivery_suburb.OptionsColumn.ReadOnly = True
        '
        'coldelivery_city
        '
        Me.coldelivery_city.Caption = "delivery_city"
        Me.coldelivery_city.FieldName = "delivery_city"
        Me.coldelivery_city.Name = "coldelivery_city"
        Me.coldelivery_city.OptionsColumn.AllowEdit = False
        Me.coldelivery_city.OptionsColumn.ReadOnly = True
        '
        'coldelivery_postcode
        '
        Me.coldelivery_postcode.Caption = "delivery_postcode"
        Me.coldelivery_postcode.FieldName = "delivery_postcode"
        Me.coldelivery_postcode.Name = "coldelivery_postcode"
        Me.coldelivery_postcode.OptionsColumn.AllowEdit = False
        Me.coldelivery_postcode.OptionsColumn.ReadOnly = True
        '
        'coldelivery_state
        '
        Me.coldelivery_state.Caption = "delivery_state"
        Me.coldelivery_state.FieldName = "delivery_state"
        Me.coldelivery_state.Name = "coldelivery_state"
        Me.coldelivery_state.OptionsColumn.AllowEdit = False
        Me.coldelivery_state.OptionsColumn.ReadOnly = True
        '
        'coldelivery_country
        '
        Me.coldelivery_country.Caption = "delivery_country"
        Me.coldelivery_country.FieldName = "delivery_country"
        Me.coldelivery_country.Name = "coldelivery_country"
        Me.coldelivery_country.OptionsColumn.AllowEdit = False
        Me.coldelivery_country.OptionsColumn.ReadOnly = True
        '
        'coldelivery_address_format_id
        '
        Me.coldelivery_address_format_id.Caption = "delivery_address_format_id"
        Me.coldelivery_address_format_id.FieldName = "delivery_address_format_id"
        Me.coldelivery_address_format_id.Name = "coldelivery_address_format_id"
        Me.coldelivery_address_format_id.OptionsColumn.AllowEdit = False
        Me.coldelivery_address_format_id.OptionsColumn.ReadOnly = True
        '
        'colpayment_method1
        '
        Me.colpayment_method1.Caption = "payment_method"
        Me.colpayment_method1.FieldName = "payment_method"
        Me.colpayment_method1.Name = "colpayment_method1"
        Me.colpayment_method1.OptionsColumn.AllowEdit = False
        Me.colpayment_method1.OptionsColumn.ReadOnly = True
        '
        'colcc_type
        '
        Me.colcc_type.Caption = "cc_type"
        Me.colcc_type.FieldName = "cc_type"
        Me.colcc_type.Name = "colcc_type"
        Me.colcc_type.OptionsColumn.AllowEdit = False
        Me.colcc_type.OptionsColumn.ReadOnly = True
        '
        'colcc_owner
        '
        Me.colcc_owner.Caption = "cc_owner"
        Me.colcc_owner.FieldName = "cc_owner"
        Me.colcc_owner.Name = "colcc_owner"
        Me.colcc_owner.OptionsColumn.AllowEdit = False
        Me.colcc_owner.OptionsColumn.ReadOnly = True
        '
        'colcc_number
        '
        Me.colcc_number.Caption = "cc_number"
        Me.colcc_number.FieldName = "cc_number"
        Me.colcc_number.Name = "colcc_number"
        Me.colcc_number.OptionsColumn.AllowEdit = False
        Me.colcc_number.OptionsColumn.ReadOnly = True
        '
        'colcc_expires
        '
        Me.colcc_expires.Caption = "cc_expires"
        Me.colcc_expires.FieldName = "cc_expires"
        Me.colcc_expires.Name = "colcc_expires"
        Me.colcc_expires.OptionsColumn.AllowEdit = False
        Me.colcc_expires.OptionsColumn.ReadOnly = True
        '
        'colproducts_name
        '
        Me.colproducts_name.Caption = "products_name"
        Me.colproducts_name.FieldName = "products_name"
        Me.colproducts_name.Name = "colproducts_name"
        Me.colproducts_name.OptionsColumn.AllowEdit = False
        Me.colproducts_name.OptionsColumn.ReadOnly = True
        Me.colproducts_name.Visible = True
        Me.colproducts_name.Width = 108
        '
        'colorders_date_finished
        '
        Me.colorders_date_finished.Caption = "orders_date_finished"
        Me.colorders_date_finished.FieldName = "orders_date_finished"
        Me.colorders_date_finished.Name = "colorders_date_finished"
        Me.colorders_date_finished.OptionsColumn.AllowEdit = False
        Me.colorders_date_finished.OptionsColumn.ReadOnly = True
        '
        'colcomments
        '
        Me.colcomments.Caption = "comments"
        Me.colcomments.FieldName = "comments"
        Me.colcomments.Name = "colcomments"
        Me.colcomments.OptionsColumn.AllowEdit = False
        Me.colcomments.OptionsColumn.ReadOnly = True
        '
        'colcurrency
        '
        Me.colcurrency.Caption = "currency"
        Me.colcurrency.FieldName = "currency"
        Me.colcurrency.Name = "colcurrency"
        Me.colcurrency.OptionsColumn.AllowEdit = False
        Me.colcurrency.OptionsColumn.ReadOnly = True
        '
        'colcurrency_value
        '
        Me.colcurrency_value.Caption = "currency_value"
        Me.colcurrency_value.FieldName = "currency_value"
        Me.colcurrency_value.Name = "colcurrency_value"
        Me.colcurrency_value.OptionsColumn.AllowEdit = False
        Me.colcurrency_value.OptionsColumn.ReadOnly = True
        '
        'colsite1
        '
        Me.colsite1.Caption = "site"
        Me.colsite1.FieldName = "site"
        Me.colsite1.Name = "colsite1"
        Me.colsite1.OptionsColumn.AllowEdit = False
        Me.colsite1.OptionsColumn.ReadOnly = True
        '
        'colsecured_mail
        '
        Me.colsecured_mail.Caption = "secured_mail"
        Me.colsecured_mail.FieldName = "secured_mail"
        Me.colsecured_mail.Name = "colsecured_mail"
        Me.colsecured_mail.OptionsColumn.AllowEdit = False
        Me.colsecured_mail.OptionsColumn.ReadOnly = True
        '
        'colmultishipment_sm
        '
        Me.colmultishipment_sm.Caption = "multishipment_sm"
        Me.colmultishipment_sm.FieldName = "multishipment_sm"
        Me.colmultishipment_sm.Name = "colmultishipment_sm"
        Me.colmultishipment_sm.OptionsColumn.AllowEdit = False
        Me.colmultishipment_sm.OptionsColumn.ReadOnly = True
        '
        'colorders_products_id
        '
        Me.colorders_products_id.Caption = "orders_products_id"
        Me.colorders_products_id.FieldName = "orders_products_id"
        Me.colorders_products_id.Name = "colorders_products_id"
        Me.colorders_products_id.OptionsColumn.AllowEdit = False
        Me.colorders_products_id.OptionsColumn.ReadOnly = True
        Me.colorders_products_id.Width = 115
        '
        'colproducts_model
        '
        Me.colproducts_model.Caption = "products_model"
        Me.colproducts_model.FieldName = "products_model"
        Me.colproducts_model.Name = "colproducts_model"
        Me.colproducts_model.OptionsColumn.AllowEdit = False
        Me.colproducts_model.OptionsColumn.ReadOnly = True
        '
        'products_id
        '
        Me.products_id.Caption = "products_id"
        Me.products_id.FieldName = "products_id"
        Me.products_id.Name = "products_id"
        Me.products_id.Visible = True
        Me.products_id.Width = 84
        '
        'colproducts_dvd
        '
        Me.colproducts_dvd.Caption = "products_dvd"
        Me.colproducts_dvd.FieldName = "products_dvd"
        Me.colproducts_dvd.Name = "colproducts_dvd"
        Me.colproducts_dvd.OptionsColumn.AllowEdit = False
        Me.colproducts_dvd.OptionsColumn.ReadOnly = True
        Me.colproducts_dvd.Visible = True
        Me.colproducts_dvd.Width = 94
        '
        'colorders_last_modified
        '
        Me.colorders_last_modified.Caption = "last_modified"
        Me.colorders_last_modified.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.colorders_last_modified.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colorders_last_modified.FieldName = "last_modified"
        Me.colorders_last_modified.Name = "colorders_last_modified"
        Me.colorders_last_modified.OptionsColumn.AllowEdit = False
        Me.colorders_last_modified.OptionsColumn.ReadOnly = True
        Me.colorders_last_modified.Visible = True
        Me.colorders_last_modified.Width = 97
        '
        'colproducts_price
        '
        Me.colproducts_price.Caption = "products_price"
        Me.colproducts_price.FieldName = "products_price"
        Me.colproducts_price.Name = "colproducts_price"
        Me.colproducts_price.OptionsColumn.AllowEdit = False
        Me.colproducts_price.OptionsColumn.ReadOnly = True
        '
        'colfinal_price
        '
        Me.colfinal_price.Caption = "final_price"
        Me.colfinal_price.FieldName = "final_price"
        Me.colfinal_price.Name = "colfinal_price"
        Me.colfinal_price.OptionsColumn.AllowEdit = False
        Me.colfinal_price.OptionsColumn.ReadOnly = True
        '
        'colproducts_tax
        '
        Me.colproducts_tax.Caption = "products_tax"
        Me.colproducts_tax.FieldName = "products_tax"
        Me.colproducts_tax.Name = "colproducts_tax"
        Me.colproducts_tax.OptionsColumn.AllowEdit = False
        Me.colproducts_tax.OptionsColumn.ReadOnly = True
        '
        'colproducts_quantity
        '
        Me.colproducts_quantity.Caption = "products_quantity"
        Me.colproducts_quantity.FieldName = "products_quantity"
        Me.colproducts_quantity.Name = "colproducts_quantity"
        Me.colproducts_quantity.OptionsColumn.AllowEdit = False
        Me.colproducts_quantity.OptionsColumn.ReadOnly = True
        '
        'colorders_products_status
        '
        Me.colorders_products_status.Caption = "orders_products_status"
        Me.colorders_products_status.FieldName = "orders_products_status"
        Me.colorders_products_status.Name = "colorders_products_status"
        Me.colorders_products_status.OptionsColumn.AllowEdit = False
        Me.colorders_products_status.OptionsColumn.ReadOnly = True
        '
        'colfeesharing
        '
        Me.colfeesharing.Caption = "feesharing"
        Me.colfeesharing.FieldName = "feesharing"
        Me.colfeesharing.Name = "colfeesharing"
        Me.colfeesharing.OptionsColumn.AllowEdit = False
        Me.colfeesharing.OptionsColumn.ReadOnly = True
        '
        'Col3Orders_id
        '
        Me.Col3Orders_id.Caption = "orders_id"
        Me.Col3Orders_id.FieldName = "orders_id"
        Me.Col3Orders_id.Name = "Col3Orders_id"
        Me.Col3Orders_id.OptionsColumn.AllowEdit = False
        Me.Col3Orders_id.Visible = True
        Me.Col3Orders_id.VisibleIndex = 5
        '
        'GridABO
        '
        Me.GridABO.DataSource = Me.objDS.abo
        Me.GridABO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridABO.EmbeddedNavigator.Name = ""
        Me.GridABO.FormsUseDefaultLookAndFeel = False
        Me.GridABO.Location = New System.Drawing.Point(0, 0)
        Me.GridABO.MainView = Me.GridViewABO
        Me.GridABO.Name = "GridABO"
        Me.GridABO.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbABO_Action})
        Me.GridABO.Size = New System.Drawing.Size(1150, 917)
        Me.GridABO.TabIndex = 0
        Me.GridABO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewABO})
        '
        'GridViewABO
        '
        Me.GridViewABO.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand4})
        Me.GridViewABO.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colcustomerid, Me.colAction, Me.colcode_id, Me.colDate, Me.colproduct_id1, Me.colpayment_method, Me.colprivilege_notified, Me.colsite})
        Me.GridViewABO.CustomizationFormBounds = New System.Drawing.Rectangle(1463, 644, 217, 222)
        Me.GridViewABO.GridControl = Me.GridABO
        Me.GridViewABO.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewABO.Name = "GridViewABO"
        Me.GridViewABO.OptionsView.ShowBands = False
        Me.GridViewABO.OptionsView.ShowFooter = True
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "GridBand4"
        Me.GridBand4.Columns.Add(Me.colcustomerid)
        Me.GridBand4.Columns.Add(Me.colAction)
        Me.GridBand4.Columns.Add(Me.colcode_id)
        Me.GridBand4.Columns.Add(Me.colDate)
        Me.GridBand4.Columns.Add(Me.colproduct_id1)
        Me.GridBand4.Columns.Add(Me.colpayment_method)
        Me.GridBand4.Columns.Add(Me.colprivilege_notified)
        Me.GridBand4.Columns.Add(Me.colsite)
        Me.GridBand4.MinWidth = 20
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 907
        '
        'colcustomerid
        '
        Me.colcustomerid.Caption = "customerid"
        Me.colcustomerid.FieldName = "customerid"
        Me.colcustomerid.Name = "colcustomerid"
        Me.colcustomerid.OptionsColumn.AllowEdit = False
        Me.colcustomerid.OptionsColumn.ReadOnly = True
        Me.colcustomerid.Visible = True
        Me.colcustomerid.Width = 112
        '
        'colAction
        '
        Me.colAction.Caption = "Action"
        Me.colAction.ColumnEdit = Me.cmbABO_Action
        Me.colAction.FieldName = "Action"
        Me.colAction.Name = "colAction"
        Me.colAction.OptionsColumn.AllowEdit = False
        Me.colAction.OptionsColumn.ReadOnly = True
        Me.colAction.Visible = True
        Me.colAction.Width = 135
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
        Me.colcode_id.OptionsColumn.AllowEdit = False
        Me.colcode_id.OptionsColumn.ReadOnly = True
        Me.colcode_id.Visible = True
        Me.colcode_id.Width = 114
        '
        'colDate
        '
        Me.colDate.Caption = "Date"
        Me.colDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDate.FieldName = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.OptionsColumn.AllowEdit = False
        Me.colDate.OptionsColumn.ReadOnly = True
        Me.colDate.Visible = True
        Me.colDate.Width = 127
        '
        'colproduct_id1
        '
        Me.colproduct_id1.Caption = "product_id"
        Me.colproduct_id1.FieldName = "product_id"
        Me.colproduct_id1.Name = "colproduct_id1"
        Me.colproduct_id1.OptionsColumn.AllowEdit = False
        Me.colproduct_id1.OptionsColumn.ReadOnly = True
        Me.colproduct_id1.Visible = True
        Me.colproduct_id1.Width = 120
        '
        'colpayment_method
        '
        Me.colpayment_method.Caption = "payment_method"
        Me.colpayment_method.FieldName = "payment_method"
        Me.colpayment_method.Name = "colpayment_method"
        Me.colpayment_method.OptionsColumn.AllowEdit = False
        Me.colpayment_method.OptionsColumn.ReadOnly = True
        Me.colpayment_method.Visible = True
        Me.colpayment_method.Width = 138
        '
        'colprivilege_notified
        '
        Me.colprivilege_notified.Caption = "privilege_notified"
        Me.colprivilege_notified.FieldName = "privilege_notified"
        Me.colprivilege_notified.Name = "colprivilege_notified"
        Me.colprivilege_notified.OptionsColumn.AllowEdit = False
        Me.colprivilege_notified.OptionsColumn.ReadOnly = True
        Me.colprivilege_notified.Visible = True
        Me.colprivilege_notified.Width = 86
        '
        'colsite
        '
        Me.colsite.Caption = "site"
        Me.colsite.FieldName = "site"
        Me.colsite.Name = "colsite"
        Me.colsite.OptionsColumn.AllowEdit = False
        Me.colsite.OptionsColumn.ReadOnly = True
        Me.colsite.Visible = True
        '
        'tabPayment
        '
        Me.tabPayment.Controls.Add(Me.GridPayment)
        Me.tabPayment.Controls.Add(Me.BtnPaid)
        Me.tabPayment.Controls.Add(Me.btnLoadPayment)
        Me.tabPayment.Controls.Add(Me.checkOpenPayment)
        Me.tabPayment.Controls.Add(Me.GroupOgone)
        Me.tabPayment.Controls.Add(Me.BtnCancelPayment)
        Me.tabPayment.Controls.Add(Me.GroupDomiciliation)
        Me.tabPayment.Controls.Add(Me.CalcEdit1)
        Me.tabPayment.Controls.Add(Me.LabelControl48)
        Me.tabPayment.Controls.Add(Me.CalcEdit)
        Me.tabPayment.Controls.Add(Me.LabelControl49)
        Me.tabPayment.Controls.Add(Me.cmbPayMethod)
        Me.tabPayment.Controls.Add(Me.LabelControl50)
        Me.tabPayment.Name = "tabPayment"
        Me.tabPayment.Size = New System.Drawing.Size(1150, 917)
        Me.tabPayment.Text = "Payment"
        '
        'GridPayment
        '
        Me.GridPayment.EmbeddedNavigator.Name = ""
        Me.GridPayment.FormsUseDefaultLookAndFeel = False
        Me.GridPayment.Location = New System.Drawing.Point(3, 233)
        Me.GridPayment.MainView = Me.GridViewPayment
        Me.GridPayment.Name = "GridPayment"
        Me.GridPayment.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit5})
        Me.GridPayment.Size = New System.Drawing.Size(1146, 895)
        Me.GridPayment.TabIndex = 61
        Me.GridPayment.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPayment})
        '
        'GridViewPayment
        '
        Me.GridViewPayment.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCTypePayment, Me.GCId, Me.GCAmountPay, Me.GCDateAdded, Me.GCLastnModified, Me.GCCommunicationPay, Me.GCCustomersID, Me.colPayment_status, Me.GCIdRecovery, Me.gcStatusRecovery, Me.gcIdMatching, Me.colCommunication_recovery})
        Me.GridViewPayment.CustomizationFormBounds = New System.Drawing.Rectangle(1113, 176, 327, 364)
        Me.GridViewPayment.GridControl = Me.GridPayment
        Me.GridViewPayment.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewPayment.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridViewPayment.Name = "GridViewPayment"
        Me.GridViewPayment.OptionsSelection.MultiSelect = True
        Me.GridViewPayment.OptionsView.ColumnAutoWidth = False
        Me.GridViewPayment.OptionsView.ShowFooter = True
        '
        'GCTypePayment
        '
        Me.GCTypePayment.Caption = "type payment"
        Me.GCTypePayment.FieldName = "type_payment"
        Me.GCTypePayment.Name = "GCTypePayment"
        Me.GCTypePayment.Visible = True
        Me.GCTypePayment.VisibleIndex = 0
        Me.GCTypePayment.Width = 81
        '
        'GCId
        '
        Me.GCId.Caption = "ID"
        Me.GCId.FieldName = "id"
        Me.GCId.Name = "GCId"
        Me.GCId.OptionsColumn.AllowEdit = False
        Me.GCId.OptionsColumn.ReadOnly = True
        Me.GCId.Visible = True
        Me.GCId.VisibleIndex = 1
        Me.GCId.Width = 28
        '
        'GCAmountPay
        '
        Me.GCAmountPay.Caption = "amount"
        Me.GCAmountPay.DisplayFormat.FormatString = "#.00"
        Me.GCAmountPay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GCAmountPay.FieldName = "amount"
        Me.GCAmountPay.Name = "GCAmountPay"
        Me.GCAmountPay.OptionsColumn.AllowEdit = False
        Me.GCAmountPay.OptionsColumn.ReadOnly = True
        Me.GCAmountPay.Visible = True
        Me.GCAmountPay.VisibleIndex = 2
        Me.GCAmountPay.Width = 57
        '
        'GCDateAdded
        '
        Me.GCDateAdded.Caption = "date_added"
        Me.GCDateAdded.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.GCDateAdded.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GCDateAdded.FieldName = "date_added"
        Me.GCDateAdded.Name = "GCDateAdded"
        Me.GCDateAdded.OptionsColumn.AllowEdit = False
        Me.GCDateAdded.OptionsColumn.ReadOnly = True
        Me.GCDateAdded.Visible = True
        Me.GCDateAdded.VisibleIndex = 4
        Me.GCDateAdded.Width = 97
        '
        'GCLastnModified
        '
        Me.GCLastnModified.Caption = "Last modified"
        Me.GCLastnModified.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.GCLastnModified.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GCLastnModified.FieldName = "last_modified"
        Me.GCLastnModified.Name = "GCLastnModified"
        Me.GCLastnModified.OptionsColumn.AllowEdit = False
        Me.GCLastnModified.OptionsColumn.ReadOnly = True
        Me.GCLastnModified.Visible = True
        Me.GCLastnModified.VisibleIndex = 5
        '
        'GCCommunicationPay
        '
        Me.GCCommunicationPay.Caption = "communication"
        Me.GCCommunicationPay.FieldName = "communication"
        Me.GCCommunicationPay.Name = "GCCommunicationPay"
        Me.GCCommunicationPay.OptionsColumn.AllowEdit = False
        Me.GCCommunicationPay.OptionsColumn.ReadOnly = True
        Me.GCCommunicationPay.Visible = True
        Me.GCCommunicationPay.VisibleIndex = 6
        Me.GCCommunicationPay.Width = 101
        '
        'GCCustomersID
        '
        Me.GCCustomersID.Caption = "customers_id"
        Me.GCCustomersID.FieldName = "customers_id"
        Me.GCCustomersID.Name = "GCCustomersID"
        Me.GCCustomersID.OptionsColumn.AllowEdit = False
        Me.GCCustomersID.OptionsColumn.ReadOnly = True
        Me.GCCustomersID.Visible = True
        Me.GCCustomersID.VisibleIndex = 3
        Me.GCCustomersID.Width = 112
        '
        'colPayment_status
        '
        Me.colPayment_status.Caption = "Payment_Status"
        Me.colPayment_status.FieldName = "payment_status"
        Me.colPayment_status.Name = "colPayment_status"
        Me.colPayment_status.OptionsColumn.AllowEdit = False
        Me.colPayment_status.OptionsColumn.ReadOnly = True
        Me.colPayment_status.Visible = True
        Me.colPayment_status.VisibleIndex = 8
        Me.colPayment_status.Width = 105
        '
        'GCIdRecovery
        '
        Me.GCIdRecovery.Caption = "id recovery"
        Me.GCIdRecovery.FieldName = "id_recovery"
        Me.GCIdRecovery.Name = "GCIdRecovery"
        Me.GCIdRecovery.OptionsColumn.AllowEdit = False
        Me.GCIdRecovery.OptionsColumn.ReadOnly = True
        Me.GCIdRecovery.Visible = True
        Me.GCIdRecovery.VisibleIndex = 11
        Me.GCIdRecovery.Width = 73
        '
        'gcStatusRecovery
        '
        Me.gcStatusRecovery.Caption = "status_recovery"
        Me.gcStatusRecovery.FieldName = "status_recovery"
        Me.gcStatusRecovery.Name = "gcStatusRecovery"
        Me.gcStatusRecovery.OptionsColumn.AllowEdit = False
        Me.gcStatusRecovery.OptionsColumn.ReadOnly = True
        Me.gcStatusRecovery.Visible = True
        Me.gcStatusRecovery.VisibleIndex = 9
        Me.gcStatusRecovery.Width = 124
        '
        'gcIdMatching
        '
        Me.gcIdMatching.Caption = "id Matching"
        Me.gcIdMatching.FieldName = "id_matching"
        Me.gcIdMatching.Name = "gcIdMatching"
        Me.gcIdMatching.OptionsColumn.AllowEdit = False
        Me.gcIdMatching.OptionsColumn.ReadOnly = True
        Me.gcIdMatching.Visible = True
        Me.gcIdMatching.VisibleIndex = 10
        Me.gcIdMatching.Width = 95
        '
        'colCommunication_recovery
        '
        Me.colCommunication_recovery.Caption = "Communication_Recovery"
        Me.colCommunication_recovery.FieldName = "communication_recovery"
        Me.colCommunication_recovery.Name = "colCommunication_recovery"
        Me.colCommunication_recovery.Visible = True
        Me.colCommunication_recovery.VisibleIndex = 7
        Me.colCommunication_recovery.Width = 137
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.DisplayMember = "name"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.ValueMember = "id"
        '
        'BtnPaid
        '
        Me.BtnPaid.Location = New System.Drawing.Point(506, 200)
        Me.BtnPaid.Name = "BtnPaid"
        Me.BtnPaid.Size = New System.Drawing.Size(136, 23)
        Me.BtnPaid.TabIndex = 64
        Me.BtnPaid.Text = "Paid Payment"
        '
        'btnLoadPayment
        '
        Me.btnLoadPayment.Location = New System.Drawing.Point(151, 200)
        Me.btnLoadPayment.Name = "btnLoadPayment"
        Me.btnLoadPayment.Size = New System.Drawing.Size(144, 23)
        Me.btnLoadPayment.TabIndex = 63
        Me.btnLoadPayment.Text = "Load"
        '
        'checkOpenPayment
        '
        Me.checkOpenPayment.Location = New System.Drawing.Point(34, 204)
        Me.checkOpenPayment.Name = "checkOpenPayment"
        Me.checkOpenPayment.Properties.Caption = "Open Payment"
        Me.checkOpenPayment.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.checkOpenPayment.Properties.ValueChecked = 1
        Me.checkOpenPayment.Properties.ValueUnchecked = 0
        Me.checkOpenPayment.Size = New System.Drawing.Size(106, 19)
        Me.checkOpenPayment.TabIndex = 62
        '
        'GroupOgone
        '
        Me.GroupOgone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupOgone.Controls.Add(Me.PanelOgone)
        Me.GroupOgone.Location = New System.Drawing.Point(424, 41)
        Me.GroupOgone.Name = "GroupOgone"
        Me.GroupOgone.Size = New System.Drawing.Size(460, 140)
        Me.GroupOgone.TabIndex = 57
        Me.GroupOgone.Text = "OGONE"
        '
        'PanelOgone
        '
        Me.PanelOgone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelOgone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelOgone.Controls.Add(Me.txt_cc_expiration_date2)
        Me.PanelOgone.Controls.Add(Me.cmb_cc_expiration_status2)
        Me.PanelOgone.Controls.Add(Me.LabelControl55)
        Me.PanelOgone.Controls.Add(Me.txt_cc_card_type2)
        Me.PanelOgone.Controls.Add(Me.LabelControl56)
        Me.PanelOgone.Controls.Add(Me.txt_cc_card_no2)
        Me.PanelOgone.Controls.Add(Me.LabelControl57)
        Me.PanelOgone.Controls.Add(Me.txt_cc_owner2)
        Me.PanelOgone.Controls.Add(Me.LabelControl58)
        Me.PanelOgone.Location = New System.Drawing.Point(5, 23)
        Me.PanelOgone.Name = "PanelOgone"
        Me.PanelOgone.Size = New System.Drawing.Size(448, 111)
        Me.PanelOgone.TabIndex = 0
        '
        'txt_cc_expiration_date2
        '
        Me.txt_cc_expiration_date2.AllowDrop = True
        Me.txt_cc_expiration_date2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.ogone_exp_date", True))
        Me.txt_cc_expiration_date2.Enabled = False
        Me.txt_cc_expiration_date2.Location = New System.Drawing.Point(142, 83)
        Me.txt_cc_expiration_date2.Name = "txt_cc_expiration_date2"
        Me.txt_cc_expiration_date2.Size = New System.Drawing.Size(164, 20)
        Me.txt_cc_expiration_date2.TabIndex = 59
        '
        'cmb_cc_expiration_status2
        '
        Me.cmb_cc_expiration_status2.AllowDrop = True
        Me.cmb_cc_expiration_status2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.ogone_cc_expiration_status", True))
        Me.cmb_cc_expiration_status2.Enabled = False
        Me.cmb_cc_expiration_status2.Location = New System.Drawing.Point(312, 83)
        Me.cmb_cc_expiration_status2.Name = "cmb_cc_expiration_status2"
        Me.cmb_cc_expiration_status2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_cc_expiration_status2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cc_expiration_status_name", "Name", 33, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmb_cc_expiration_status2.Properties.DataSource = Me.objDS.cc_expiration_status
        Me.cmb_cc_expiration_status2.Properties.DisplayMember = "cc_expiration_status_name"
        Me.cmb_cc_expiration_status2.Properties.NullText = ""
        Me.cmb_cc_expiration_status2.Properties.ValueMember = "cc_expiration_status_id"
        Me.cmb_cc_expiration_status2.Size = New System.Drawing.Size(127, 20)
        Me.cmb_cc_expiration_status2.TabIndex = 58
        '
        'LabelControl55
        '
        Me.LabelControl55.Location = New System.Drawing.Point(9, 86)
        Me.LabelControl55.Name = "LabelControl55"
        Me.LabelControl55.Size = New System.Drawing.Size(115, 13)
        Me.LabelControl55.TabIndex = 57
        Me.LabelControl55.Text = "Expiration Date / Status"
        '
        'txt_cc_card_type2
        '
        Me.txt_cc_card_type2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.ogone_card_type", True))
        Me.txt_cc_card_type2.Enabled = False
        Me.txt_cc_card_type2.Location = New System.Drawing.Point(142, 5)
        Me.txt_cc_card_type2.Name = "txt_cc_card_type2"
        Me.txt_cc_card_type2.Size = New System.Drawing.Size(164, 20)
        Me.txt_cc_card_type2.TabIndex = 55
        '
        'LabelControl56
        '
        Me.LabelControl56.Location = New System.Drawing.Point(9, 8)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl56.TabIndex = 54
        Me.LabelControl56.Text = "Card Type"
        '
        'txt_cc_card_no2
        '
        Me.txt_cc_card_no2.AllowDrop = True
        Me.txt_cc_card_no2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.ogone_card_no", True))
        Me.txt_cc_card_no2.Enabled = False
        Me.txt_cc_card_no2.Location = New System.Drawing.Point(142, 57)
        Me.txt_cc_card_no2.Name = "txt_cc_card_no2"
        Me.txt_cc_card_no2.Size = New System.Drawing.Size(164, 20)
        Me.txt_cc_card_no2.TabIndex = 53
        '
        'LabelControl57
        '
        Me.LabelControl57.Location = New System.Drawing.Point(9, 60)
        Me.LabelControl57.Name = "LabelControl57"
        Me.LabelControl57.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl57.TabIndex = 52
        Me.LabelControl57.Text = "Card No"
        '
        'txt_cc_owner2
        '
        Me.txt_cc_owner2.AllowDrop = True
        Me.txt_cc_owner2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.ogone_owner", True))
        Me.txt_cc_owner2.Enabled = False
        Me.txt_cc_owner2.Location = New System.Drawing.Point(142, 31)
        Me.txt_cc_owner2.Name = "txt_cc_owner2"
        Me.txt_cc_owner2.Size = New System.Drawing.Size(164, 20)
        Me.txt_cc_owner2.TabIndex = 51
        '
        'LabelControl58
        '
        Me.LabelControl58.Location = New System.Drawing.Point(9, 34)
        Me.LabelControl58.Name = "LabelControl58"
        Me.LabelControl58.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl58.TabIndex = 50
        Me.LabelControl58.Text = "Owner"
        '
        'BtnCancelPayment
        '
        Me.BtnCancelPayment.Location = New System.Drawing.Point(341, 200)
        Me.BtnCancelPayment.Name = "BtnCancelPayment"
        Me.BtnCancelPayment.Size = New System.Drawing.Size(136, 23)
        Me.BtnCancelPayment.TabIndex = 54
        Me.BtnCancelPayment.Text = "Cancel Payment"
        '
        'GroupDomiciliation
        '
        Me.GroupDomiciliation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupDomiciliation.Controls.Add(Me.panelDomiciliation)
        Me.GroupDomiciliation.Location = New System.Drawing.Point(19, 41)
        Me.GroupDomiciliation.Name = "GroupDomiciliation"
        Me.GroupDomiciliation.Size = New System.Drawing.Size(374, 145)
        Me.GroupDomiciliation.TabIndex = 56
        Me.GroupDomiciliation.Text = "Domiciliation"
        '
        'panelDomiciliation
        '
        Me.panelDomiciliation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelDomiciliation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.panelDomiciliation.Controls.Add(Me.txtDomAcctNumber)
        Me.panelDomiciliation.Controls.Add(Me.LabelControl51)
        Me.panelDomiciliation.Controls.Add(Me.txtDomNumber)
        Me.panelDomiciliation.Controls.Add(Me.LabelControl52)
        Me.panelDomiciliation.Controls.Add(Me.txtDomDebiterName)
        Me.panelDomiciliation.Controls.Add(Me.LabelControl53)
        Me.panelDomiciliation.Controls.Add(Me.cmbDomStatus)
        Me.panelDomiciliation.Controls.Add(Me.LabelControl54)
        Me.panelDomiciliation.Location = New System.Drawing.Point(3, 23)
        Me.panelDomiciliation.Name = "panelDomiciliation"
        Me.panelDomiciliation.Size = New System.Drawing.Size(366, 111)
        Me.panelDomiciliation.TabIndex = 0
        '
        'txtDomAcctNumber
        '
        Me.txtDomAcctNumber.AllowDrop = True
        Me.txtDomAcctNumber.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.domiciliation_account_number", True))
        Me.txtDomAcctNumber.Enabled = False
        Me.txtDomAcctNumber.Location = New System.Drawing.Point(129, 83)
        Me.txtDomAcctNumber.Name = "txtDomAcctNumber"
        Me.txtDomAcctNumber.Size = New System.Drawing.Size(224, 20)
        Me.txtDomAcctNumber.TabIndex = 53
        '
        'LabelControl51
        '
        Me.LabelControl51.Location = New System.Drawing.Point(15, 86)
        Me.LabelControl51.Name = "LabelControl51"
        Me.LabelControl51.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl51.TabIndex = 52
        Me.LabelControl51.Text = "Dom Account Number"
        '
        'txtDomNumber
        '
        Me.txtDomNumber.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.domiciliation_number", True))
        Me.txtDomNumber.Enabled = False
        Me.txtDomNumber.Location = New System.Drawing.Point(129, 57)
        Me.txtDomNumber.Name = "txtDomNumber"
        Me.txtDomNumber.Size = New System.Drawing.Size(224, 20)
        Me.txtDomNumber.TabIndex = 51
        '
        'LabelControl52
        '
        Me.LabelControl52.Location = New System.Drawing.Point(15, 60)
        Me.LabelControl52.Name = "LabelControl52"
        Me.LabelControl52.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl52.TabIndex = 50
        Me.LabelControl52.Text = "Dom Number"
        '
        'txtDomDebiterName
        '
        Me.txtDomDebiterName.AllowDrop = True
        Me.txtDomDebiterName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.domiciliation_debiter_name", True))
        Me.txtDomDebiterName.Enabled = False
        Me.txtDomDebiterName.Location = New System.Drawing.Point(129, 31)
        Me.txtDomDebiterName.Name = "txtDomDebiterName"
        Me.txtDomDebiterName.Size = New System.Drawing.Size(224, 20)
        Me.txtDomDebiterName.TabIndex = 49
        '
        'LabelControl53
        '
        Me.LabelControl53.Location = New System.Drawing.Point(15, 34)
        Me.LabelControl53.Name = "LabelControl53"
        Me.LabelControl53.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl53.TabIndex = 48
        Me.LabelControl53.Text = "Debiter Name"
        '
        'cmbDomStatus
        '
        Me.cmbDomStatus.AllowDrop = True
        Me.cmbDomStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.domiciliation_status", True))
        Me.cmbDomStatus.Enabled = False
        Me.cmbDomStatus.Location = New System.Drawing.Point(129, 5)
        Me.cmbDomStatus.Name = "cmbDomStatus"
        Me.cmbDomStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDomStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("domiciliation_status_name", "Name", 33, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbDomStatus.Properties.DataSource = Me.objDS.domiciliation_status
        Me.cmbDomStatus.Properties.DisplayMember = "domiciliation_status_name"
        Me.cmbDomStatus.Properties.NullText = ""
        Me.cmbDomStatus.Properties.ValueMember = "domiciliation_status_id"
        Me.cmbDomStatus.Size = New System.Drawing.Size(224, 20)
        Me.cmbDomStatus.TabIndex = 47
        '
        'LabelControl54
        '
        Me.LabelControl54.Location = New System.Drawing.Point(15, 8)
        Me.LabelControl54.Name = "LabelControl54"
        Me.LabelControl54.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl54.TabIndex = 46
        Me.LabelControl54.Text = "Domiciliation Status"
        '
        'CalcEdit1
        '
        Me.CalcEdit1.Enabled = False
        Me.CalcEdit1.Location = New System.Drawing.Point(635, 15)
        Me.CalcEdit1.Name = "CalcEdit1"
        Me.CalcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalcEdit1.Size = New System.Drawing.Size(100, 20)
        Me.CalcEdit1.TabIndex = 55
        Me.CalcEdit1.Visible = False
        '
        'LabelControl48
        '
        Me.LabelControl48.Location = New System.Drawing.Point(563, 18)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl48.TabIndex = 54
        Me.LabelControl48.Text = "Open Amount"
        Me.LabelControl48.Visible = False
        '
        'CalcEdit
        '
        Me.CalcEdit.Enabled = False
        Me.CalcEdit.Location = New System.Drawing.Point(421, 15)
        Me.CalcEdit.Name = "CalcEdit"
        Me.CalcEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalcEdit.Size = New System.Drawing.Size(100, 20)
        Me.CalcEdit.TabIndex = 53
        Me.CalcEdit.Visible = False
        '
        'LabelControl49
        '
        Me.LabelControl49.Location = New System.Drawing.Point(397, 18)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(14, 13)
        Me.LabelControl49.TabIndex = 52
        Me.LabelControl49.Text = "CA"
        Me.LabelControl49.Visible = False
        '
        'cmbPayMethod
        '
        Me.cmbPayMethod.AllowDrop = True
        Me.cmbPayMethod.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_payment_method", True))
        Me.cmbPayMethod.Enabled = False
        Me.cmbPayMethod.Location = New System.Drawing.Point(128, 15)
        Me.cmbPayMethod.Name = "cmbPayMethod"
        Me.cmbPayMethod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPayMethod.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("customers_abo_payment_method_name", "Name", 33, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbPayMethod.Properties.DataSource = Me.objDS.customers_abo_payment_method
        Me.cmbPayMethod.Properties.DisplayMember = "customers_abo_payment_method_name"
        Me.cmbPayMethod.Properties.NullText = ""
        Me.cmbPayMethod.Properties.ValueMember = "customers_abo_payment_method_id"
        Me.cmbPayMethod.Size = New System.Drawing.Size(224, 20)
        Me.cmbPayMethod.TabIndex = 51
        '
        'LabelControl50
        '
        Me.LabelControl50.Location = New System.Drawing.Point(19, 18)
        Me.LabelControl50.Name = "LabelControl50"
        Me.LabelControl50.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl50.TabIndex = 50
        Me.LabelControl50.Text = "Payment Method"
        '
        'GridColumn59
        '
        Me.GridColumn59.Name = "GridColumn59"
        '
        'GridColumn60
        '
        Me.GridColumn60.Name = "GridColumn60"
        '
        'GridColumn61
        '
        Me.GridColumn61.Name = "GridColumn61"
        '
        'GridColumn62
        '
        Me.GridColumn62.Name = "GridColumn62"
        '
        'GridColumn63
        '
        Me.GridColumn63.Name = "GridColumn63"
        '
        'colwl_id2
        '
        Me.colwl_id2.Name = "colwl_id2"
        '
        'colcustomers_id8
        '
        Me.colcustomers_id8.Name = "colcustomers_id8"
        '
        'colproduct_id2
        '
        Me.colproduct_id2.Name = "colproduct_id2"
        '
        'colrank2
        '
        Me.colrank2.Name = "colrank2"
        '
        'colpriority1
        '
        Me.colpriority1.Name = "colpriority1"
        '
        'coldate_added7
        '
        Me.coldate_added7.Name = "coldate_added7"
        '
        'colwishlist_type2
        '
        Me.colwishlist_type2.Name = "colwishlist_type2"
        '
        'colproducts_title2
        '
        Me.colproducts_title2.Name = "colproducts_title2"
        '
        'colqty_in_stock1
        '
        Me.colqty_in_stock1.Name = "colqty_in_stock1"
        '
        'GridWishList
        '
        Me.GridWishList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridWishList.EmbeddedNavigator.Name = ""
        Me.GridWishList.FormsUseDefaultLookAndFeel = False
        Me.GridWishList.Location = New System.Drawing.Point(2, 40)
        Me.GridWishList.MainView = Me.GridViewWishList
        Me.GridWishList.Name = "GridWishList"
        Me.GridWishList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnSendIt, Me.checkAvailibility})
        Me.GridWishList.Size = New System.Drawing.Size(605, 875)
        Me.GridWishList.TabIndex = 0
        Me.GridWishList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewWishList})
        '
        'GridViewWishList
        '
        Me.GridViewWishList.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.GridViewWishList.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colwl_id, Me.colproduct_id, Me.colrank, Me.colpriority, Me.colwishlist_type, Me.colproducts_title, Me.colqty_in_stock, Me.colSendIt, Me.colProducts_availability, Me.DateAdded, Me.products_date_available, Me.colProducts_next, Me.colProductsstatus})
        Me.GridViewWishList.CustomizationFormBounds = New System.Drawing.Rectangle(1083, 490, 208, 191)
        Me.GridViewWishList.GridControl = Me.GridWishList
        Me.GridViewWishList.GroupCount = 1
        Me.GridViewWishList.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
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
        Me.GridBand2.Columns.Add(Me.DateAdded)
        Me.GridBand2.Columns.Add(Me.colwl_id)
        Me.GridBand2.Columns.Add(Me.colproduct_id)
        Me.GridBand2.Columns.Add(Me.colrank)
        Me.GridBand2.Columns.Add(Me.colpriority)
        Me.GridBand2.Columns.Add(Me.colproducts_title)
        Me.GridBand2.Columns.Add(Me.products_date_available)
        Me.GridBand2.Columns.Add(Me.colqty_in_stock)
        Me.GridBand2.Columns.Add(Me.colProducts_next)
        Me.GridBand2.Columns.Add(Me.colProductsstatus)
        Me.GridBand2.Columns.Add(Me.colProducts_availability)
        Me.GridBand2.MinWidth = 20
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 1105
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
        Me.colwishlist_type.OptionsColumn.AllowEdit = False
        Me.colwishlist_type.OptionsColumn.ReadOnly = True
        Me.colwishlist_type.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colwishlist_type.Visible = True
        Me.colwishlist_type.Width = 87
        '
        'DateAdded
        '
        Me.DateAdded.Caption = "date_added"
        Me.DateAdded.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.DateAdded.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateAdded.FieldName = "date_added"
        Me.DateAdded.Name = "DateAdded"
        Me.DateAdded.OptionsColumn.AllowEdit = False
        Me.DateAdded.OptionsColumn.ReadOnly = True
        Me.DateAdded.Visible = True
        Me.DateAdded.Width = 109
        '
        'colwl_id
        '
        Me.colwl_id.Caption = "wl_id"
        Me.colwl_id.FieldName = "wl_id"
        Me.colwl_id.Name = "colwl_id"
        Me.colwl_id.OptionsColumn.AllowEdit = False
        Me.colwl_id.OptionsColumn.ReadOnly = True
        '
        'colproduct_id
        '
        Me.colproduct_id.Caption = "product_id"
        Me.colproduct_id.FieldName = "product_id"
        Me.colproduct_id.Name = "colproduct_id"
        Me.colproduct_id.OptionsColumn.AllowEdit = False
        Me.colproduct_id.OptionsColumn.ReadOnly = True
        Me.colproduct_id.Visible = True
        Me.colproduct_id.Width = 74
        '
        'colrank
        '
        Me.colrank.Caption = "rank"
        Me.colrank.FieldName = "rank"
        Me.colrank.Name = "colrank"
        Me.colrank.OptionsColumn.AllowEdit = False
        Me.colrank.OptionsColumn.ReadOnly = True
        Me.colrank.Width = 44
        '
        'colpriority
        '
        Me.colpriority.Caption = "priority"
        Me.colpriority.FieldName = "priority"
        Me.colpriority.Name = "colpriority"
        Me.colpriority.OptionsColumn.AllowEdit = False
        Me.colpriority.OptionsColumn.ReadOnly = True
        Me.colpriority.Visible = True
        Me.colpriority.Width = 57
        '
        'colproducts_title
        '
        Me.colproducts_title.Caption = "products_title"
        Me.colproducts_title.FieldName = "products_title_description"
        Me.colproducts_title.Name = "colproducts_title"
        Me.colproducts_title.OptionsColumn.AllowEdit = False
        Me.colproducts_title.OptionsColumn.ReadOnly = True
        Me.colproducts_title.Visible = True
        Me.colproducts_title.Width = 144
        '
        'products_date_available
        '
        Me.products_date_available.Caption = "products_date_available"
        Me.products_date_available.FieldName = "products_date_available"
        Me.products_date_available.Name = "products_date_available"
        Me.products_date_available.OptionsColumn.AllowEdit = False
        Me.products_date_available.OptionsColumn.ReadOnly = True
        Me.products_date_available.Visible = True
        Me.products_date_available.Width = 142
        '
        'colqty_in_stock
        '
        Me.colqty_in_stock.Caption = "qty_in_stock"
        Me.colqty_in_stock.FieldName = "qty_in_stock"
        Me.colqty_in_stock.Name = "colqty_in_stock"
        Me.colqty_in_stock.OptionsColumn.AllowEdit = False
        Me.colqty_in_stock.OptionsColumn.ReadOnly = True
        Me.colqty_in_stock.Visible = True
        Me.colqty_in_stock.Width = 87
        '
        'colProducts_next
        '
        Me.colProducts_next.Caption = "Products_Next"
        Me.colProducts_next.ColumnEdit = Me.checkAvailibility
        Me.colProducts_next.FieldName = "products_next"
        Me.colProducts_next.Name = "colProducts_next"
        Me.colProducts_next.Visible = True
        Me.colProducts_next.Width = 98
        '
        'checkAvailibility
        '
        Me.checkAvailibility.AutoHeight = False
        Me.checkAvailibility.Name = "checkAvailibility"
        Me.checkAvailibility.ReadOnly = True
        Me.checkAvailibility.ValueChecked = 1
        Me.checkAvailibility.ValueUnchecked = 0
        '
        'colProductsstatus
        '
        Me.colProductsstatus.Caption = "Products_status"
        Me.colProductsstatus.FieldName = "products_status"
        Me.colProductsstatus.Name = "colProductsstatus"
        Me.colProductsstatus.Visible = True
        Me.colProductsstatus.Width = 108
        '
        'colProducts_availability
        '
        Me.colProducts_availability.Caption = "products_availability"
        Me.colProducts_availability.FieldName = "products_availability"
        Me.colProducts_availability.Name = "colProducts_availability"
        Me.colProducts_availability.Visible = True
        Me.colProducts_availability.Width = 124
        '
        'tabCRM
        '
        Me.tabCRM.Controls.Add(Me.PanelControl7)
        Me.tabCRM.Controls.Add(Me.SplitterControl4)
        Me.tabCRM.Controls.Add(Me.GridCustServ)
        Me.tabCRM.Name = "tabCRM"
        Me.tabCRM.Size = New System.Drawing.Size(1150, 917)
        Me.tabCRM.Text = "Cust Serv"
        '
        'PanelControl7
        '
        Me.PanelControl7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl7.Controls.Add(Me.PanelControl8)
        Me.PanelControl7.Controls.Add(Me.GroupControl7)
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl7.Location = New System.Drawing.Point(678, 0)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(472, 917)
        Me.PanelControl7.TabIndex = 3
        '
        'PanelControl8
        '
        Me.PanelControl8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl8.Controls.Add(Me.LayoutCustServ)
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl8.Location = New System.Drawing.Point(2, 65)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(468, 850)
        Me.PanelControl8.TabIndex = 1
        '
        'LayoutCustServ
        '
        Me.LayoutCustServ.Controls.Add(Me.txtCustServ_Response_Message)
        Me.LayoutCustServ.Controls.Add(Me.txtCustServ_DVD_ID)
        Me.LayoutCustServ.Controls.Add(Me.txtCustServ_Products_id)
        Me.LayoutCustServ.Controls.Add(Me.txtCustServ_OrderID)
        Me.LayoutCustServ.Controls.Add(Me.txtCustServ_CustDate)
        Me.LayoutCustServ.Controls.Add(Me.MemoEdit1)
        Me.LayoutCustServ.Controls.Add(Me.txtCustServ_Subject)
        Me.LayoutCustServ.DataSource = Me.objDS.custserv
        Me.LayoutCustServ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutCustServ.Location = New System.Drawing.Point(2, 2)
        Me.LayoutCustServ.Name = "LayoutCustServ"
        Me.LayoutCustServ.Root = Me.LayoutControlGroup1
        Me.LayoutCustServ.Size = New System.Drawing.Size(464, 846)
        Me.LayoutCustServ.TabIndex = 0
        Me.LayoutCustServ.Text = "DataLayoutControl1"
        '
        'txtCustServ_Response_Message
        '
        Me.txtCustServ_Response_Message.Location = New System.Drawing.Point(107, 525)
        Me.txtCustServ_Response_Message.Name = "txtCustServ_Response_Message"
        Me.txtCustServ_Response_Message.Size = New System.Drawing.Size(366, 312)
        Me.txtCustServ_Response_Message.StyleController = Me.LayoutCustServ
        Me.txtCustServ_Response_Message.TabIndex = 14
        '
        'txtCustServ_DVD_ID
        '
        Me.txtCustServ_DVD_ID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "custserv.dvd_id", True))
        Me.txtCustServ_DVD_ID.Location = New System.Drawing.Point(423, 439)
        Me.txtCustServ_DVD_ID.Name = "txtCustServ_DVD_ID"
        Me.txtCustServ_DVD_ID.Properties.ReadOnly = True
        Me.txtCustServ_DVD_ID.Size = New System.Drawing.Size(50, 20)
        Me.txtCustServ_DVD_ID.StyleController = Me.LayoutCustServ
        Me.txtCustServ_DVD_ID.TabIndex = 11
        '
        'txtCustServ_Products_id
        '
        Me.txtCustServ_Products_id.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "custserv.products_id", True))
        Me.txtCustServ_Products_id.Location = New System.Drawing.Point(265, 439)
        Me.txtCustServ_Products_id.Name = "txtCustServ_Products_id"
        Me.txtCustServ_Products_id.Properties.ReadOnly = True
        Me.txtCustServ_Products_id.Size = New System.Drawing.Size(50, 20)
        Me.txtCustServ_Products_id.StyleController = Me.LayoutCustServ
        Me.txtCustServ_Products_id.TabIndex = 10
        '
        'txtCustServ_OrderID
        '
        Me.txtCustServ_OrderID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "custserv.orders_id", True))
        Me.txtCustServ_OrderID.Location = New System.Drawing.Point(107, 439)
        Me.txtCustServ_OrderID.Name = "txtCustServ_OrderID"
        Me.txtCustServ_OrderID.Properties.ReadOnly = True
        Me.txtCustServ_OrderID.Size = New System.Drawing.Size(50, 20)
        Me.txtCustServ_OrderID.StyleController = Me.LayoutCustServ
        Me.txtCustServ_OrderID.TabIndex = 9
        '
        'txtCustServ_CustDate
        '
        Me.txtCustServ_CustDate.EditValue = Nothing
        Me.txtCustServ_CustDate.Location = New System.Drawing.Point(107, 28)
        Me.txtCustServ_CustDate.Name = "txtCustServ_CustDate"
        Me.txtCustServ_CustDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCustServ_CustDate.Properties.ReadOnly = True
        Me.txtCustServ_CustDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCustServ_CustDate.Size = New System.Drawing.Size(366, 20)
        Me.txtCustServ_CustDate.StyleController = Me.LayoutCustServ
        Me.txtCustServ_CustDate.TabIndex = 8
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Location = New System.Drawing.Point(107, 59)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.ReadOnly = True
        Me.MemoEdit1.Size = New System.Drawing.Size(366, 345)
        Me.MemoEdit1.StyleController = Me.LayoutCustServ
        Me.MemoEdit1.TabIndex = 7
        '
        'txtCustServ_Subject
        '
        Me.txtCustServ_Subject.Location = New System.Drawing.Point(104, 473)
        Me.txtCustServ_Subject.Name = "txtCustServ_Subject"
        Me.txtCustServ_Subject.Size = New System.Drawing.Size(372, 20)
        Me.txtCustServ_Subject.StyleController = Me.LayoutCustServ
        Me.txtCustServ_Subject.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(482, 846)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Misc"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem6, Me.LayoutControlItem8})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 411)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(480, 55)
        Me.LayoutControlGroup2.Text = "Misc"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtCustServ_Products_id
        Me.LayoutControlItem7.CustomizationFormText = "Products ID"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(158, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(158, 31)
        Me.LayoutControlItem7.Text = "Products ID"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(92, 20)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtCustServ_OrderID
        Me.LayoutControlItem6.CustomizationFormText = "Order ID"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(158, 31)
        Me.LayoutControlItem6.Text = "Order ID"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(92, 20)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtCustServ_DVD_ID
        Me.LayoutControlItem8.CustomizationFormText = "DVD ID"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(316, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(158, 31)
        Me.LayoutControlItem8.Text = "DVD ID"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(92, 20)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Call / E-Mail Info"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem4})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(480, 411)
        Me.LayoutControlGroup3.Text = "Call / E-Mail Info"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtCustServ_CustDate
        Me.LayoutControlItem5.CustomizationFormText = "Date"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(474, 31)
        Me.LayoutControlItem5.Text = "Date"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(92, 20)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.MemoEdit1
        Me.LayoutControlItem4.CustomizationFormText = "Message"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(474, 356)
        Me.LayoutControlItem4.Text = "Message"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(92, 20)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "Response"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 497)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(480, 347)
        Me.LayoutControlGroup4.Text = "Response"
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtCustServ_Response_Message
        Me.LayoutControlItem11.CustomizationFormText = "Response Message"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(474, 323)
        Me.LayoutControlItem11.Text = "Response Message"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(92, 20)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtCustServ_Subject
        Me.LayoutControlItem3.CustomizationFormText = "Subject"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 466)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(480, 31)
        Me.LayoutControlItem3.Text = "Subject"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(92, 20)
        '
        'GroupControl7
        '
        Me.GroupControl7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl7.Controls.Add(Me.chkCustServSendMail)
        Me.GroupControl7.Controls.Add(Me.btnSaveCustServ)
        Me.GroupControl7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl7.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(468, 63)
        Me.GroupControl7.TabIndex = 0
        Me.GroupControl7.Text = "Call / Action Detail"
        '
        'chkCustServSendMail
        '
        Me.chkCustServSendMail.EditValue = 1
        Me.chkCustServSendMail.Location = New System.Drawing.Point(99, 30)
        Me.chkCustServSendMail.Name = "chkCustServSendMail"
        Me.chkCustServSendMail.Properties.Caption = "Send Email"
        Me.chkCustServSendMail.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkCustServSendMail.Properties.ValueChecked = 1
        Me.chkCustServSendMail.Properties.ValueUnchecked = 0
        Me.chkCustServSendMail.Size = New System.Drawing.Size(96, 19)
        Me.chkCustServSendMail.TabIndex = 31
        '
        'btnSaveCustServ
        '
        Me.btnSaveCustServ.Location = New System.Drawing.Point(4, 27)
        Me.btnSaveCustServ.Name = "btnSaveCustServ"
        Me.btnSaveCustServ.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveCustServ.TabIndex = 9
        Me.btnSaveCustServ.Text = "Save"
        '
        'SplitterControl4
        '
        Me.SplitterControl4.Location = New System.Drawing.Point(672, 0)
        Me.SplitterControl4.Name = "SplitterControl4"
        Me.SplitterControl4.Size = New System.Drawing.Size(6, 917)
        Me.SplitterControl4.TabIndex = 2
        Me.SplitterControl4.TabStop = False
        '
        'GridWishListAssigned
        '
        Me.GridWishListAssigned.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridWishListAssigned.EmbeddedNavigator.Name = ""
        Me.GridWishListAssigned.FormsUseDefaultLookAndFeel = False
        Me.GridWishListAssigned.Location = New System.Drawing.Point(2, 20)
        Me.GridWishListAssigned.MainView = Me.GridViewWishListAssigned
        Me.GridWishListAssigned.Name = "GridWishListAssigned"
        Me.GridWishListAssigned.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1})
        Me.GridWishListAssigned.Size = New System.Drawing.Size(531, 895)
        Me.GridWishListAssigned.TabIndex = 2
        Me.GridWishListAssigned.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewWishListAssigned})
        '
        'GridViewWishListAssigned
        '
        Me.GridViewWishListAssigned.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand3})
        Me.GridViewWishListAssigned.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colwl_assigned_id, Me.colwl_id1, Me.colrprioritywish, Me.coldate_assigned, Me.colwishlist_type1, Me.colproducts_title1, Me.colWAdate_added})
        Me.GridViewWishListAssigned.CustomizationFormBounds = New System.Drawing.Rectangle(883, 417, 208, 191)
        Me.GridViewWishListAssigned.GridControl = Me.GridWishListAssigned
        Me.GridViewWishListAssigned.GroupCount = 1
        Me.GridViewWishListAssigned.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
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
        Me.GridBand3.Columns.Add(Me.colrprioritywish)
        Me.GridBand3.Columns.Add(Me.coldate_assigned)
        Me.GridBand3.Columns.Add(Me.colWAdate_added)
        Me.GridBand3.Columns.Add(Me.colproducts_title1)
        Me.GridBand3.MinWidth = 20
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 469
        '
        'colwishlist_type1
        '
        Me.colwishlist_type1.Caption = "wishlist_type"
        Me.colwishlist_type1.FieldName = "wishlist_type"
        Me.colwishlist_type1.Name = "colwishlist_type1"
        Me.colwishlist_type1.OptionsColumn.AllowEdit = False
        Me.colwishlist_type1.OptionsColumn.ReadOnly = True
        Me.colwishlist_type1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colwishlist_type1.Visible = True
        '
        'colwl_assigned_id
        '
        Me.colwl_assigned_id.Caption = "wl_assigned_id"
        Me.colwl_assigned_id.FieldName = "wl_assigned_id"
        Me.colwl_assigned_id.Name = "colwl_assigned_id"
        Me.colwl_assigned_id.OptionsColumn.AllowEdit = False
        Me.colwl_assigned_id.OptionsColumn.ReadOnly = True
        '
        'colwl_id1
        '
        Me.colwl_id1.Caption = "wl_id"
        Me.colwl_id1.FieldName = "wl_id"
        Me.colwl_id1.Name = "colwl_id1"
        Me.colwl_id1.OptionsColumn.AllowEdit = False
        Me.colwl_id1.OptionsColumn.ReadOnly = True
        '
        'colrprioritywish
        '
        Me.colrprioritywish.Caption = "priority"
        Me.colrprioritywish.FieldName = "priority"
        Me.colrprioritywish.Name = "colrprioritywish"
        Me.colrprioritywish.OptionsColumn.AllowEdit = False
        Me.colrprioritywish.OptionsColumn.ReadOnly = True
        Me.colrprioritywish.Visible = True
        '
        'coldate_assigned
        '
        Me.coldate_assigned.Caption = "date_assigned"
        Me.coldate_assigned.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.coldate_assigned.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldate_assigned.FieldName = "date_assigned"
        Me.coldate_assigned.Name = "coldate_assigned"
        Me.coldate_assigned.OptionsColumn.AllowEdit = False
        Me.coldate_assigned.OptionsColumn.ReadOnly = True
        Me.coldate_assigned.Visible = True
        '
        'colWAdate_added
        '
        Me.colWAdate_added.Caption = "wishlist_date_added"
        Me.colWAdate_added.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.colWAdate_added.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colWAdate_added.FieldName = "date_added"
        Me.colWAdate_added.Name = "colWAdate_added"
        Me.colWAdate_added.OptionsColumn.AllowEdit = False
        Me.colWAdate_added.OptionsColumn.ReadOnly = True
        Me.colWAdate_added.Visible = True
        Me.colWAdate_added.Width = 119
        '
        'colproducts_title1
        '
        Me.colproducts_title1.Caption = "products_title"
        Me.colproducts_title1.FieldName = "products_title_description"
        Me.colproducts_title1.Name = "colproducts_title1"
        Me.colproducts_title1.OptionsColumn.AllowEdit = False
        Me.colproducts_title1.OptionsColumn.ReadOnly = True
        Me.colproducts_title1.Visible = True
        Me.colproducts_title1.Width = 125
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'coldomiciliation_payment_id2
        '
        Me.coldomiciliation_payment_id2.Caption = "domiciliation_payment_id"
        Me.coldomiciliation_payment_id2.FieldName = "domiciliation_payment_id"
        Me.coldomiciliation_payment_id2.Name = "coldomiciliation_payment_id2"
        Me.coldomiciliation_payment_id2.Visible = True
        Me.coldomiciliation_payment_id2.VisibleIndex = 0
        '
        'coldomiciliation_payment_date2
        '
        Me.coldomiciliation_payment_date2.Caption = "domiciliation_payment_date"
        Me.coldomiciliation_payment_date2.FieldName = "domiciliation_payment_date"
        Me.coldomiciliation_payment_date2.Name = "coldomiciliation_payment_date2"
        Me.coldomiciliation_payment_date2.Visible = True
        Me.coldomiciliation_payment_date2.VisibleIndex = 1
        '
        'colabo_id4
        '
        Me.colabo_id4.Caption = "abo_id"
        Me.colabo_id4.FieldName = "abo_id"
        Me.colabo_id4.Name = "colabo_id4"
        Me.colabo_id4.Visible = True
        Me.colabo_id4.VisibleIndex = 2
        '
        'colcustomers_name2
        '
        Me.colcustomers_name2.Caption = "customers_name"
        Me.colcustomers_name2.FieldName = "customers_name"
        Me.colcustomers_name2.Name = "colcustomers_name2"
        Me.colcustomers_name2.Visible = True
        Me.colcustomers_name2.VisibleIndex = 4
        '
        'colcustomers_address2
        '
        Me.colcustomers_address2.Caption = "customers_address"
        Me.colcustomers_address2.FieldName = "customers_address"
        Me.colcustomers_address2.Name = "colcustomers_address2"
        Me.colcustomers_address2.Visible = True
        Me.colcustomers_address2.VisibleIndex = 5
        '
        'colamount6
        '
        Me.colamount6.Caption = "amount"
        Me.colamount6.FieldName = "amount"
        Me.colamount6.Name = "colamount6"
        Me.colamount6.Visible = True
        Me.colamount6.VisibleIndex = 6
        '
        'colstrdomiciliation_debiter_name2
        '
        Me.colstrdomiciliation_debiter_name2.Caption = "strdomiciliation_debiter_name"
        Me.colstrdomiciliation_debiter_name2.FieldName = "strdomiciliation_debiter_name"
        Me.colstrdomiciliation_debiter_name2.Name = "colstrdomiciliation_debiter_name2"
        Me.colstrdomiciliation_debiter_name2.Visible = True
        Me.colstrdomiciliation_debiter_name2.VisibleIndex = 7
        '
        'colstrdomiciliation_number2
        '
        Me.colstrdomiciliation_number2.Caption = "strdomiciliation_number"
        Me.colstrdomiciliation_number2.FieldName = "strdomiciliation_number"
        Me.colstrdomiciliation_number2.Name = "colstrdomiciliation_number2"
        Me.colstrdomiciliation_number2.Visible = True
        Me.colstrdomiciliation_number2.VisibleIndex = 8
        '
        'colcommunication4
        '
        Me.colcommunication4.Caption = "communication"
        Me.colcommunication4.FieldName = "communication"
        Me.colcommunication4.Name = "colcommunication4"
        Me.colcommunication4.Visible = True
        Me.colcommunication4.VisibleIndex = 9
        '
        'colfirst_payment2
        '
        Me.colfirst_payment2.Caption = "first_payment"
        Me.colfirst_payment2.FieldName = "first_payment"
        Me.colfirst_payment2.Name = "colfirst_payment2"
        Me.colfirst_payment2.Visible = True
        Me.colfirst_payment2.VisibleIndex = 10
        '
        'colreconduction2
        '
        Me.colreconduction2.Caption = "reconduction"
        Me.colreconduction2.FieldName = "reconduction"
        Me.colreconduction2.Name = "colreconduction2"
        Me.colreconduction2.Visible = True
        Me.colreconduction2.VisibleIndex = 11
        '
        'coldomiciliation_payment_status2
        '
        Me.coldomiciliation_payment_status2.Caption = "payment_status"
        Me.coldomiciliation_payment_status2.FieldName = "payment_status"
        Me.coldomiciliation_payment_status2.Name = "coldomiciliation_payment_status2"
        Me.coldomiciliation_payment_status2.Visible = True
        Me.coldomiciliation_payment_status2.VisibleIndex = 12
        '
        'coldomiciliation_payment_isabel_date2
        '
        Me.coldomiciliation_payment_isabel_date2.Caption = "domiciliation_payment_isabel_date"
        Me.coldomiciliation_payment_isabel_date2.FieldName = "domiciliation_payment_isabel_date"
        Me.coldomiciliation_payment_isabel_date2.Name = "coldomiciliation_payment_isabel_date2"
        Me.coldomiciliation_payment_isabel_date2.Visible = True
        Me.coldomiciliation_payment_isabel_date2.VisibleIndex = 13
        '
        'coldomiciliation_unpaid_id2
        '
        Me.coldomiciliation_unpaid_id2.Caption = "domiciliation_unpaid_id"
        Me.coldomiciliation_unpaid_id2.FieldName = "domiciliation_unpaid_id"
        Me.coldomiciliation_unpaid_id2.Name = "coldomiciliation_unpaid_id2"
        Me.coldomiciliation_unpaid_id2.Visible = True
        Me.coldomiciliation_unpaid_id2.VisibleIndex = 14
        '
        'colbatch_immatriculation_number2
        '
        Me.colbatch_immatriculation_number2.Caption = "batch_immatriculation_number"
        Me.colbatch_immatriculation_number2.FieldName = "batch_immatriculation_number"
        Me.colbatch_immatriculation_number2.Name = "colbatch_immatriculation_number2"
        Me.colbatch_immatriculation_number2.Visible = True
        Me.colbatch_immatriculation_number2.VisibleIndex = 15
        '
        'collast_modified6
        '
        Me.collast_modified6.Caption = "last_modified"
        Me.collast_modified6.FieldName = "last_modified"
        Me.collast_modified6.Name = "collast_modified6"
        Me.collast_modified6.Visible = True
        Me.collast_modified6.VisibleIndex = 16
        '
        'colabo_stopped_with_dvdathome_id2
        '
        Me.colabo_stopped_with_dvdathome_id2.Caption = "abo_stopped_with_dvdathome_id"
        Me.colabo_stopped_with_dvdathome_id2.FieldName = "abo_stopped_with_dvdathome_id"
        Me.colabo_stopped_with_dvdathome_id2.Name = "colabo_stopped_with_dvdathome_id2"
        Me.colabo_stopped_with_dvdathome_id2.Visible = True
        Me.colabo_stopped_with_dvdathome_id2.VisibleIndex = 17
        '
        'cologone_payment_id2
        '
        Me.cologone_payment_id2.Caption = "ogone_payment_id"
        Me.cologone_payment_id2.FieldName = "ogone_payment_id"
        Me.cologone_payment_id2.Name = "cologone_payment_id2"
        Me.cologone_payment_id2.Visible = True
        Me.cologone_payment_id2.VisibleIndex = 0
        '
        'colabo_id5
        '
        Me.colabo_id5.Caption = "abo_id"
        Me.colabo_id5.FieldName = "abo_id"
        Me.colabo_id5.Name = "colabo_id5"
        Me.colabo_id5.Visible = True
        Me.colabo_id5.VisibleIndex = 1
        '
        'colcustomers_id9
        '
        Me.colcustomers_id9.Caption = "customers_id"
        Me.colcustomers_id9.FieldName = "customers_id"
        Me.colcustomers_id9.Name = "colcustomers_id9"
        Me.colcustomers_id9.Visible = True
        Me.colcustomers_id9.VisibleIndex = 2
        '
        'colamount7
        '
        Me.colamount7.Caption = "amount"
        Me.colamount7.FieldName = "amount"
        Me.colamount7.Name = "colamount7"
        Me.colamount7.Visible = True
        Me.colamount7.VisibleIndex = 3
        '
        'cologone_payment_status2
        '
        Me.cologone_payment_status2.Caption = "ogone_payment_status"
        Me.cologone_payment_status2.FieldName = "ogone_payment_status"
        Me.cologone_payment_status2.Name = "cologone_payment_status2"
        Me.cologone_payment_status2.Visible = True
        Me.cologone_payment_status2.VisibleIndex = 5
        '
        'cologone_batch_id2
        '
        Me.cologone_batch_id2.Caption = "ogone_batch_id"
        Me.cologone_batch_id2.FieldName = "ogone_batch_id"
        Me.cologone_batch_id2.Name = "cologone_batch_id2"
        Me.cologone_batch_id2.Visible = True
        Me.cologone_batch_id2.VisibleIndex = 6
        '
        'collast_modified7
        '
        Me.collast_modified7.Caption = "last_modified"
        Me.collast_modified7.FieldName = "last_modified"
        Me.collast_modified7.Name = "collast_modified7"
        Me.collast_modified7.Visible = True
        Me.collast_modified7.VisibleIndex = 7
        '
        'colcustserv_id2
        '
        Me.colcustserv_id2.Caption = "custserv_id"
        Me.colcustserv_id2.FieldName = "custserv_id"
        Me.colcustserv_id2.Name = "colcustserv_id2"
        Me.colcustserv_id2.Visible = True
        Me.colcustserv_id2.VisibleIndex = 0
        '
        'colcustomers_id10
        '
        Me.colcustomers_id10.Caption = "customers_id"
        Me.colcustomers_id10.FieldName = "customers_id"
        Me.colcustomers_id10.Name = "colcustomers_id10"
        Me.colcustomers_id10.Visible = True
        Me.colcustomers_id10.VisibleIndex = 1
        '
        'collanguage_id2
        '
        Me.collanguage_id2.Caption = "language_id"
        Me.collanguage_id2.FieldName = "language_id"
        Me.collanguage_id2.Name = "collanguage_id2"
        Me.collanguage_id2.Visible = True
        Me.collanguage_id2.VisibleIndex = 2
        '
        'colcustserv_cat_id2
        '
        Me.colcustserv_cat_id2.Caption = "custserv_cat_id"
        Me.colcustserv_cat_id2.FieldName = "custserv_cat_id"
        Me.colcustserv_cat_id2.Name = "colcustserv_cat_id2"
        Me.colcustserv_cat_id2.Visible = True
        Me.colcustserv_cat_id2.VisibleIndex = 3
        '
        'colcustomer_date2
        '
        Me.colcustomer_date2.Caption = "customer_date"
        Me.colcustomer_date2.FieldName = "customer_date"
        Me.colcustomer_date2.Name = "colcustomer_date2"
        Me.colcustomer_date2.Visible = True
        Me.colcustomer_date2.VisibleIndex = 4
        '
        'colorders_id2
        '
        Me.colorders_id2.Caption = "orders_id"
        Me.colorders_id2.FieldName = "orders_id"
        Me.colorders_id2.Name = "colorders_id2"
        Me.colorders_id2.Visible = True
        Me.colorders_id2.VisibleIndex = 5
        '
        'colproducts_id1
        '
        Me.colproducts_id1.Caption = "products_id"
        Me.colproducts_id1.FieldName = "products_id"
        Me.colproducts_id1.Name = "colproducts_id1"
        Me.colproducts_id1.Visible = True
        Me.colproducts_id1.VisibleIndex = 6
        '
        'coldvd_id2
        '
        Me.coldvd_id2.Caption = "dvd_id"
        Me.coldvd_id2.FieldName = "dvd_id"
        Me.coldvd_id2.Name = "coldvd_id2"
        Me.coldvd_id2.Visible = True
        Me.coldvd_id2.VisibleIndex = 7
        '
        'colsubject2
        '
        Me.colsubject2.Caption = "subject"
        Me.colsubject2.FieldName = "subject"
        Me.colsubject2.Name = "colsubject2"
        Me.colsubject2.Visible = True
        Me.colsubject2.VisibleIndex = 8
        '
        'colmessage2
        '
        Me.colmessage2.Caption = "message"
        Me.colmessage2.FieldName = "message"
        Me.colmessage2.Name = "colmessage2"
        Me.colmessage2.Visible = True
        Me.colmessage2.VisibleIndex = 9
        '
        'coladmindate2
        '
        Me.coladmindate2.Caption = "admindate"
        Me.coladmindate2.FieldName = "admindate"
        Me.coladmindate2.Name = "coladmindate2"
        Me.coladmindate2.Visible = True
        Me.coladmindate2.VisibleIndex = 10
        '
        'coladminby2
        '
        Me.coladminby2.Caption = "adminby"
        Me.coladminby2.FieldName = "adminby"
        Me.coladminby2.Name = "coladminby2"
        Me.coladminby2.Visible = True
        Me.coladminby2.VisibleIndex = 11
        '
        'coladminmessage2
        '
        Me.coladminmessage2.Caption = "adminmessage"
        Me.coladminmessage2.FieldName = "adminmessage"
        Me.coladminmessage2.Name = "coladminmessage2"
        Me.coladminmessage2.Visible = True
        Me.coladminmessage2.VisibleIndex = 12
        '
        'colmessagesent2
        '
        Me.colmessagesent2.Caption = "messagesent"
        Me.colmessagesent2.FieldName = "messagesent"
        Me.colmessagesent2.Name = "colmessagesent2"
        Me.colmessagesent2.Visible = True
        Me.colmessagesent2.VisibleIndex = 13
        '
        'coldvd_finally_arrived_mail2
        '
        Me.coldvd_finally_arrived_mail2.Caption = "dvd_finally_arrived_mail"
        Me.coldvd_finally_arrived_mail2.FieldName = "dvd_finally_arrived_mail"
        Me.coldvd_finally_arrived_mail2.Name = "coldvd_finally_arrived_mail2"
        Me.coldvd_finally_arrived_mail2.Visible = True
        Me.coldvd_finally_arrived_mail2.VisibleIndex = 14
        '
        'tabOrdersHistor
        '
        Me.tabOrdersHistor.Controls.Add(Me.GroupControl6)
        Me.tabOrdersHistor.Controls.Add(Me.SplitterControl2)
        Me.tabOrdersHistor.Controls.Add(Me.GroupControl5)
        Me.tabOrdersHistor.Name = "tabOrdersHistor"
        Me.tabOrdersHistor.Size = New System.Drawing.Size(1150, 917)
        Me.tabOrdersHistor.Text = "Orders History"
        '
        'GroupControl6
        '
        Me.GroupControl6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl6.Controls.Add(Me.GridOrdersHistory)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl6.Location = New System.Drawing.Point(849, 0)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(301, 917)
        Me.GroupControl6.TabIndex = 2
        Me.GroupControl6.Text = "Orders Detail"
        '
        'GridOrdersHistory
        '
        Me.GridOrdersHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOrdersHistory.EmbeddedNavigator.Name = ""
        Me.GridOrdersHistory.FormsUseDefaultLookAndFeel = False
        Me.GridOrdersHistory.Location = New System.Drawing.Point(2, 20)
        Me.GridOrdersHistory.MainView = Me.GridViewOrdersHistory
        Me.GridOrdersHistory.Name = "GridOrdersHistory"
        Me.GridOrdersHistory.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GridOrdersHistory.Size = New System.Drawing.Size(297, 895)
        Me.GridOrdersHistory.TabIndex = 2
        Me.GridOrdersHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewOrdersHistory})
        '
        'GridViewOrdersHistory
        '
        Me.GridViewOrdersHistory.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand6})
        Me.GridViewOrdersHistory.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.coldate_added_Orders_history, Me.new_status, Me.old_status})
        Me.GridViewOrdersHistory.CustomizationFormBounds = New System.Drawing.Rectangle(989, 251, 217, 291)
        Me.GridViewOrdersHistory.GridControl = Me.GridOrdersHistory
        Me.GridViewOrdersHistory.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewOrdersHistory.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "orders_status", Nothing, "")})
        Me.GridViewOrdersHistory.Name = "GridViewOrdersHistory"
        Me.GridViewOrdersHistory.OptionsBehavior.Editable = False
        Me.GridViewOrdersHistory.OptionsView.ShowBands = False
        Me.GridViewOrdersHistory.OptionsView.ShowFooter = True
        '
        'GridBand6
        '
        Me.GridBand6.Caption = "GridBand4"
        Me.GridBand6.Columns.Add(Me.coldate_added_Orders_history)
        Me.GridBand6.Columns.Add(Me.new_status)
        Me.GridBand6.Columns.Add(Me.old_status)
        Me.GridBand6.MinWidth = 20
        Me.GridBand6.Name = "GridBand6"
        Me.GridBand6.Width = 353
        '
        'coldate_added_Orders_history
        '
        Me.coldate_added_Orders_history.Caption = "date_added"
        Me.coldate_added_Orders_history.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.coldate_added_Orders_history.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldate_added_Orders_history.FieldName = "date_added"
        Me.coldate_added_Orders_history.Name = "coldate_added_Orders_history"
        Me.coldate_added_Orders_history.OptionsColumn.AllowEdit = False
        Me.coldate_added_Orders_history.OptionsColumn.ReadOnly = True
        Me.coldate_added_Orders_history.Visible = True
        Me.coldate_added_Orders_history.Width = 120
        '
        'new_status
        '
        Me.new_status.Caption = "new_status"
        Me.new_status.FieldName = "new_status"
        Me.new_status.Name = "new_status"
        Me.new_status.Visible = True
        Me.new_status.Width = 114
        '
        'old_status
        '
        Me.old_status.Caption = "old_status"
        Me.old_status.FieldName = "old_status"
        Me.old_status.Name = "old_status"
        Me.old_status.Visible = True
        Me.old_status.Width = 119
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.objDS.orders_status
        Me.RepositoryItemLookUpEdit1.DisplayMember = "orders_status_name"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "orders_status_id"
        '
        'SplitterControl2
        '
        Me.SplitterControl2.Location = New System.Drawing.Point(843, 0)
        Me.SplitterControl2.Name = "SplitterControl2"
        Me.SplitterControl2.Size = New System.Drawing.Size(6, 917)
        Me.SplitterControl2.TabIndex = 1
        Me.SplitterControl2.TabStop = False
        '
        'GroupControl5
        '
        Me.GroupControl5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl5.Controls.Add(Me.GridOrders)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl5.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(843, 917)
        Me.GroupControl5.TabIndex = 0
        Me.GroupControl5.Text = "Orders"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.FormsUseDefaultLookAndFeel = False
        Me.GridControl1.Location = New System.Drawing.Point(0, 176)
        Me.GridControl1.MainView = Me.GridViewSearch
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(1150, 741)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSearch})
        '
        'GridViewSearch
        '
        Me.GridViewSearch.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridViewSearch.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colcustomers_firstname, Me.colcustomers_lastname, Me.colcustomers_email_address, Me.colcustomers_abo, Me.colblack_listed, Me.custserv_customer_date, Me.colentry_postcode, Me.coldomiciliation_number, Me.col2customers_id, Me.colcustomers_language, Me.call_phone, Me.colentry_street_address})
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
        Me.GridBand1.Columns.Add(Me.col2customers_id)
        Me.GridBand1.Columns.Add(Me.colcustomers_firstname)
        Me.GridBand1.Columns.Add(Me.colcustomers_lastname)
        Me.GridBand1.Columns.Add(Me.colcustomers_email_address)
        Me.GridBand1.Columns.Add(Me.colcustomers_abo)
        Me.GridBand1.Columns.Add(Me.colblack_listed)
        Me.GridBand1.Columns.Add(Me.colentry_postcode)
        Me.GridBand1.Columns.Add(Me.colentry_street_address)
        Me.GridBand1.Columns.Add(Me.coldomiciliation_number)
        Me.GridBand1.Columns.Add(Me.colcustomers_language)
        Me.GridBand1.Columns.Add(Me.call_phone)
        Me.GridBand1.Columns.Add(Me.custserv_customer_date)
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 1322
        '
        'col2customers_id
        '
        Me.col2customers_id.Caption = "customers_id"
        Me.col2customers_id.FieldName = "customers_id"
        Me.col2customers_id.Name = "col2customers_id"
        Me.col2customers_id.Visible = True
        Me.col2customers_id.Width = 90
        '
        'colcustomers_firstname
        '
        Me.colcustomers_firstname.Caption = "customers_firstname"
        Me.colcustomers_firstname.FieldName = "customers_firstname"
        Me.colcustomers_firstname.Name = "colcustomers_firstname"
        Me.colcustomers_firstname.Visible = True
        Me.colcustomers_firstname.Width = 120
        '
        'colcustomers_lastname
        '
        Me.colcustomers_lastname.Caption = "customers_lastname"
        Me.colcustomers_lastname.FieldName = "customers_lastname"
        Me.colcustomers_lastname.Name = "colcustomers_lastname"
        Me.colcustomers_lastname.Visible = True
        Me.colcustomers_lastname.Width = 118
        '
        'colcustomers_email_address
        '
        Me.colcustomers_email_address.Caption = "customers_email_address"
        Me.colcustomers_email_address.FieldName = "customers_email_address"
        Me.colcustomers_email_address.Name = "colcustomers_email_address"
        Me.colcustomers_email_address.Visible = True
        Me.colcustomers_email_address.Width = 143
        '
        'colcustomers_abo
        '
        Me.colcustomers_abo.Caption = "customers_abo"
        Me.colcustomers_abo.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colcustomers_abo.FieldName = "customers_abo"
        Me.colcustomers_abo.Name = "colcustomers_abo"
        Me.colcustomers_abo.Visible = True
        Me.colcustomers_abo.Width = 90
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
        Me.colblack_listed.Width = 72
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.ValueChecked = 1
        Me.RepositoryItemCheckEdit2.ValueUnchecked = 0
        '
        'colentry_postcode
        '
        Me.colentry_postcode.Caption = "entry_postcode"
        Me.colentry_postcode.FieldName = "entry_postcode"
        Me.colentry_postcode.Name = "colentry_postcode"
        Me.colentry_postcode.Visible = True
        Me.colentry_postcode.Width = 96
        '
        'colentry_street_address
        '
        Me.colentry_street_address.Caption = "entry_street_address"
        Me.colentry_street_address.FieldName = "entry_street_address"
        Me.colentry_street_address.Name = "colentry_street_address"
        Me.colentry_street_address.OptionsColumn.ReadOnly = True
        Me.colentry_street_address.Visible = True
        Me.colentry_street_address.Width = 191
        '
        'coldomiciliation_number
        '
        Me.coldomiciliation_number.Caption = "domiciliation_number"
        Me.coldomiciliation_number.FieldName = "domiciliation_number"
        Me.coldomiciliation_number.Name = "coldomiciliation_number"
        Me.coldomiciliation_number.Visible = True
        Me.coldomiciliation_number.Width = 121
        '
        'colcustomers_language
        '
        Me.colcustomers_language.Caption = "language"
        Me.colcustomers_language.FieldName = "customers_language"
        Me.colcustomers_language.Name = "colcustomers_language"
        Me.colcustomers_language.Visible = True
        Me.colcustomers_language.Width = 52
        '
        'call_phone
        '
        Me.call_phone.Caption = "call_phone"
        Me.call_phone.FieldName = "call_phone"
        Me.call_phone.Name = "call_phone"
        Me.call_phone.Visible = True
        Me.call_phone.Width = 105
        '
        'custserv_customer_date
        '
        Me.custserv_customer_date.Caption = "CustServ_date"
        Me.custserv_customer_date.FieldName = "customer_date"
        Me.custserv_customer_date.Name = "custserv_customer_date"
        Me.custserv_customer_date.Visible = True
        Me.custserv_customer_date.Width = 124
        '
        'tabAboHistory
        '
        Me.tabAboHistory.Controls.Add(Me.GridABO)
        Me.tabAboHistory.Name = "tabAboHistory"
        Me.tabAboHistory.Size = New System.Drawing.Size(1150, 917)
        Me.tabAboHistory.Text = "ABO History"
        '
        'tabWishList
        '
        Me.tabWishList.Controls.Add(Me.GroupControl4)
        Me.tabWishList.Controls.Add(Me.SplitterControl1)
        Me.tabWishList.Controls.Add(Me.PanelControl11)
        Me.tabWishList.Name = "tabWishList"
        Me.tabWishList.Size = New System.Drawing.Size(1150, 917)
        Me.tabWishList.Text = "WishList"
        '
        'GroupControl4
        '
        Me.GroupControl4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl4.Controls.Add(Me.GridWishListAssigned)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(615, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(535, 917)
        Me.GroupControl4.TabIndex = 3
        Me.GroupControl4.Text = "DVD Already Assigned"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(609, 0)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(6, 917)
        Me.SplitterControl1.TabIndex = 1
        Me.SplitterControl1.TabStop = False
        '
        'PanelControl11
        '
        Me.PanelControl11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl11.Controls.Add(Me.GridWishList)
        Me.PanelControl11.Controls.Add(Me.PanelPayment)
        Me.PanelControl11.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl11.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl11.Name = "PanelControl11"
        Me.PanelControl11.Size = New System.Drawing.Size(609, 917)
        Me.PanelControl11.TabIndex = 4
        '
        'PanelPayment
        '
        Me.PanelPayment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelPayment.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPayment.Location = New System.Drawing.Point(2, 2)
        Me.PanelPayment.Name = "PanelPayment"
        Me.PanelPayment.Size = New System.Drawing.Size(605, 38)
        Me.PanelPayment.TabIndex = 1
        '
        'tabMain
        '
        Me.tabMain.AutoScroll = True
        Me.tabMain.Controls.Add(Me.lblNextPrice)
        Me.tabMain.Controls.Add(Me.lblNextCredit)
        Me.tabMain.Controls.Add(txtNextPrice)
        Me.tabMain.Controls.Add(txtNextCredit)
        Me.tabMain.Controls.Add(Me.btnForcedReconduction)
        Me.tabMain.Controls.Add(Me.btnActivateDomiciliation)
        Me.tabMain.Controls.Add(Me.btnReceivedDomiciliation)
        Me.tabMain.Controls.Add(Me.GroupControlACtPhone)
        Me.tabMain.Controls.Add(Me.btnDelPhoAct)
        Me.tabMain.Controls.Add(Me.btnActPhone)
        Me.tabMain.Controls.Add(Me.btnReActivate)
        Me.tabMain.Controls.Add(Me.GroupControl3)
        Me.tabMain.Controls.Add(Me.GroupControl2)
        Me.tabMain.Controls.Add(Me.GroupControl1)
        Me.tabMain.Controls.Add(Me.btnStopNow)
        Me.tabMain.Controls.Add(Me.btnStopAtReconduction)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Size = New System.Drawing.Size(1150, 917)
        Me.tabMain.Text = "General Info"
        '
        'lblNextPrice
        '
        Me.lblNextPrice.Location = New System.Drawing.Point(793, 17)
        Me.lblNextPrice.Name = "lblNextPrice"
        Me.lblNextPrice.Size = New System.Drawing.Size(49, 13)
        Me.lblNextPrice.TabIndex = 24
        Me.lblNextPrice.Text = "Next Price"
        '
        'lblNextCredit
        '
        Me.lblNextCredit.Location = New System.Drawing.Point(632, 17)
        Me.lblNextCredit.Name = "lblNextCredit"
        Me.lblNextCredit.Size = New System.Drawing.Size(55, 13)
        Me.lblNextCredit.TabIndex = 22
        Me.lblNextCredit.Text = "Next Credit"
        '
        'btnForcedReconduction
        '
        Me.btnForcedReconduction.Location = New System.Drawing.Point(990, 40)
        Me.btnForcedReconduction.Name = "btnForcedReconduction"
        Me.btnForcedReconduction.Size = New System.Drawing.Size(144, 23)
        Me.btnForcedReconduction.TabIndex = 13
        Me.btnForcedReconduction.Text = "Reconduction"
        '
        'btnActivateDomiciliation
        '
        Me.btnActivateDomiciliation.Location = New System.Drawing.Point(990, 245)
        Me.btnActivateDomiciliation.Name = "btnActivateDomiciliation"
        Me.btnActivateDomiciliation.Size = New System.Drawing.Size(144, 23)
        Me.btnActivateDomiciliation.TabIndex = 12
        Me.btnActivateDomiciliation.Text = "&Activate by Domiciliation"
        '
        'btnReceivedDomiciliation
        '
        Me.btnReceivedDomiciliation.Location = New System.Drawing.Point(989, 293)
        Me.btnReceivedDomiciliation.Name = "btnReceivedDomiciliation"
        Me.btnReceivedDomiciliation.Size = New System.Drawing.Size(144, 23)
        Me.btnReceivedDomiciliation.TabIndex = 11
        Me.btnReceivedDomiciliation.Text = "&Received domiciliation"
        Me.ToolTip1.SetToolTip(Me.btnReceivedDomiciliation, "received dom 70")
        '
        'GroupControlACtPhone
        '
        Me.GroupControlACtPhone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControlACtPhone.Controls.Add(Me.MemoOtherReason)
        Me.GroupControlACtPhone.Controls.Add(Me.Label2)
        Me.GroupControlACtPhone.Controls.Add(Me.cmbPhoneActivDelete)
        Me.GroupControlACtPhone.Controls.Add(Me.LabelReason)
        Me.GroupControlACtPhone.Controls.Add(Me.DateCallPhoneActivation)
        Me.GroupControlACtPhone.Controls.Add(Me.LabelCallMeDate)
        Me.GroupControlACtPhone.Location = New System.Drawing.Point(632, 443)
        Me.GroupControlACtPhone.Name = "GroupControlACtPhone"
        Me.GroupControlACtPhone.Size = New System.Drawing.Size(328, 237)
        Me.GroupControlACtPhone.TabIndex = 10
        Me.GroupControlACtPhone.Text = "Phone activation Info"
        '
        'MemoOtherReason
        '
        Me.MemoOtherReason.Enabled = False
        Me.MemoOtherReason.Location = New System.Drawing.Point(25, 131)
        Me.MemoOtherReason.Name = "MemoOtherReason"
        Me.MemoOtherReason.Size = New System.Drawing.Size(232, 79)
        Me.MemoOtherReason.StyleController = Me.LayoutCustServ
        Me.MemoOtherReason.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Comment"
        '
        'cmbPhoneActivDelete
        '
        Me.cmbPhoneActivDelete.Enabled = False
        Me.cmbPhoneActivDelete.Location = New System.Drawing.Point(136, 70)
        Me.cmbPhoneActivDelete.Name = "cmbPhoneActivDelete"
        Me.cmbPhoneActivDelete.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPhoneActivDelete.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("reason", "reason", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("stop_phone_id", "stop_phone_id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbPhoneActivDelete.Properties.DisplayMember = "reason"
        Me.cmbPhoneActivDelete.Properties.NullText = ""
        Me.cmbPhoneActivDelete.Properties.ValueMember = "stop_phone_id"
        Me.cmbPhoneActivDelete.Size = New System.Drawing.Size(121, 20)
        Me.cmbPhoneActivDelete.TabIndex = 40
        '
        'LabelReason
        '
        Me.LabelReason.AutoSize = True
        Me.LabelReason.Location = New System.Drawing.Point(22, 73)
        Me.LabelReason.Name = "LabelReason"
        Me.LabelReason.Size = New System.Drawing.Size(99, 13)
        Me.LabelReason.TabIndex = 23
        Me.LabelReason.Text = "Reason from delete"
        '
        'DateCallPhoneActivation
        '
        Me.DateCallPhoneActivation.CausesValidation = False
        Me.DateCallPhoneActivation.EditValue = Nothing
        Me.DateCallPhoneActivation.Enabled = False
        Me.DateCallPhoneActivation.Location = New System.Drawing.Point(136, 42)
        Me.DateCallPhoneActivation.Name = "DateCallPhoneActivation"
        Me.DateCallPhoneActivation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateCallPhoneActivation.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateCallPhoneActivation.Size = New System.Drawing.Size(121, 20)
        Me.DateCallPhoneActivation.TabIndex = 18
        '
        'LabelCallMeDate
        '
        Me.LabelCallMeDate.Location = New System.Drawing.Point(25, 45)
        Me.LabelCallMeDate.Name = "LabelCallMeDate"
        Me.LabelCallMeDate.Size = New System.Drawing.Size(57, 13)
        Me.LabelCallMeDate.TabIndex = 13
        Me.LabelCallMeDate.Text = "call me date"
        '
        'btnDelPhoAct
        '
        Me.btnDelPhoAct.Location = New System.Drawing.Point(990, 403)
        Me.btnDelPhoAct.Name = "btnDelPhoAct"
        Me.btnDelPhoAct.Size = New System.Drawing.Size(144, 23)
        Me.btnDelPhoAct.TabIndex = 20
        Me.btnDelPhoAct.Text = "Delete Phone activation"
        '
        'btnActPhone
        '
        Me.btnActPhone.Location = New System.Drawing.Point(990, 197)
        Me.btnActPhone.Name = "btnActPhone"
        Me.btnActPhone.Size = New System.Drawing.Size(144, 23)
        Me.btnActPhone.TabIndex = 9
        Me.btnActPhone.Text = "&Activate by phone"
        '
        'btnReActivate
        '
        Me.btnReActivate.Location = New System.Drawing.Point(990, 84)
        Me.btnReActivate.Name = "btnReActivate"
        Me.btnReActivate.Size = New System.Drawing.Size(144, 23)
        Me.btnReActivate.TabIndex = 6
        Me.btnReActivate.Text = "Re-Activate"
        '
        'GroupControl3
        '
        Me.GroupControl3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl3.Controls.Add(Me.LabelDateEndHoliday)
        Me.GroupControl3.Controls.Add(Me.DateEndOfHoliday)
        Me.GroupControl3.Controls.Add(Me.cmbSuspended)
        Me.GroupControl3.Controls.Add(Me.lblAboSumP)
        Me.GroupControl3.Controls.Add(Me.LabelControl37)
        Me.GroupControl3.Controls.Add(Me.btnGoto30)
        Me.GroupControl3.Controls.Add(Me.txtRegistrationStep)
        Me.GroupControl3.Controls.Add(Me.LabelControl32)
        Me.GroupControl3.Controls.Add(Me.txtDVDAdultAtHome)
        Me.GroupControl3.Controls.Add(Me.LabelControl24)
        Me.GroupControl3.Controls.Add(Me.txtDiscValidity)
        Me.GroupControl3.Controls.Add(Me.chkAutoStop)
        Me.GroupControl3.Controls.Add(Me.txtActivationDiscountCode)
        Me.GroupControl3.Controls.Add(Me.cmbNextDiscCode)
        Me.GroupControl3.Controls.Add(Me.txtDiscType)
        Me.GroupControl3.Controls.Add(Me.LabelControl23)
        Me.GroupControl3.Controls.Add(Me.LabelControl22)
        Me.GroupControl3.Controls.Add(Me.chkMultiShipment)
        Me.GroupControl3.Controls.Add(Me.cmbNextABO)
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
        Me.GroupControl3.Location = New System.Drawing.Point(632, 40)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(328, 388)
        Me.GroupControl3.TabIndex = 5
        Me.GroupControl3.Text = "ABO Info"
        '
        'LabelDateEndHoliday
        '
        Me.LabelDateEndHoliday.Location = New System.Drawing.Point(8, 149)
        Me.LabelDateEndHoliday.Name = "LabelDateEndHoliday"
        Me.LabelDateEndHoliday.Size = New System.Drawing.Size(113, 13)
        Me.LabelDateEndHoliday.TabIndex = 51
        Me.LabelDateEndHoliday.Text = "closing date of vacancy"
        '
        'DateEndOfHoliday
        '
        Me.DateEndOfHoliday.EditValue = Nothing
        Me.DateEndOfHoliday.Enabled = False
        Me.DateEndOfHoliday.Location = New System.Drawing.Point(160, 146)
        Me.DateEndOfHoliday.Name = "DateEndOfHoliday"
        Me.DateEndOfHoliday.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEndOfHoliday.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEndOfHoliday.Size = New System.Drawing.Size(152, 20)
        Me.DateEndOfHoliday.TabIndex = 50
        '
        'cmbSuspended
        '
        Me.cmbSuspended.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_suspended", True))
        Me.cmbSuspended.Enabled = False
        Me.cmbSuspended.Location = New System.Drawing.Point(160, 123)
        Me.cmbSuspended.Name = "cmbSuspended"
        Me.cmbSuspended.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSuspended.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 75, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbSuspended.Properties.DisplayMember = "DisplayMember"
        Me.cmbSuspended.Properties.NullText = ""
        Me.cmbSuspended.Properties.ValueMember = "Value"
        Me.cmbSuspended.Size = New System.Drawing.Size(152, 20)
        Me.cmbSuspended.TabIndex = 48
        '
        'lblAboSumP
        '
        Me.lblAboSumP.AutoSize = True
        Me.lblAboSumP.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAboSumP.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblAboSumP.Location = New System.Drawing.Point(5, 29)
        Me.lblAboSumP.Name = "lblAboSumP"
        Me.lblAboSumP.Size = New System.Drawing.Size(139, 13)
        Me.lblAboSumP.TabIndex = 47
        Me.lblAboSumP.Text = "ABO 12 mois SummerPower"
        '
        'LabelControl37
        '
        Me.LabelControl37.Location = New System.Drawing.Point(8, 127)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl37.TabIndex = 45
        Me.LabelControl37.Text = "Suspended"
        '
        'btnGoto30
        '
        Me.btnGoto30.Enabled = False
        Me.btnGoto30.Location = New System.Drawing.Point(248, 337)
        Me.btnGoto30.Name = "btnGoto30"
        Me.btnGoto30.Size = New System.Drawing.Size(64, 23)
        Me.btnGoto30.TabIndex = 44
        Me.btnGoto30.Text = "Goto 30"
        Me.btnGoto30.Visible = False
        '
        'txtRegistrationStep
        '
        Me.txtRegistrationStep.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_registration_step", True))
        Me.txtRegistrationStep.Enabled = False
        Me.txtRegistrationStep.Location = New System.Drawing.Point(160, 337)
        Me.txtRegistrationStep.Name = "txtRegistrationStep"
        Me.txtRegistrationStep.Size = New System.Drawing.Size(80, 20)
        Me.txtRegistrationStep.TabIndex = 43
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(8, 345)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl32.TabIndex = 42
        Me.LabelControl32.Text = "Registration Step"
        '
        'txtDVDAdultAtHome
        '
        Me.txtDVDAdultAtHome.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_home_adult", True))
        Me.txtDVDAdultAtHome.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDVDAdultAtHome.Enabled = False
        Me.txtDVDAdultAtHome.Location = New System.Drawing.Point(240, 241)
        Me.txtDVDAdultAtHome.Name = "txtDVDAdultAtHome"
        Me.txtDVDAdultAtHome.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDVDAdultAtHome.Size = New System.Drawing.Size(72, 20)
        Me.txtDVDAdultAtHome.TabIndex = 41
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(8, 297)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl24.TabIndex = 40
        Me.LabelControl24.Text = "Discount Validity"
        '
        'txtDiscValidity
        '
        Me.txtDiscValidity.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_discount_recurring_to_date", True))
        Me.txtDiscValidity.EditValue = Nothing
        Me.txtDiscValidity.Enabled = False
        Me.txtDiscValidity.Location = New System.Drawing.Point(160, 289)
        Me.txtDiscValidity.Name = "txtDiscValidity"
        Me.txtDiscValidity.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtDiscValidity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDiscValidity.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDiscValidity.Size = New System.Drawing.Size(152, 20)
        Me.txtDiscValidity.TabIndex = 39
        '
        'chkAutoStop
        '
        Me.chkAutoStop.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_auto_stop_next_reconduction", True))
        Me.chkAutoStop.Enabled = False
        Me.chkAutoStop.Location = New System.Drawing.Point(120, 369)
        Me.chkAutoStop.Name = "chkAutoStop"
        Me.chkAutoStop.Properties.Caption = "Auto-Stop"
        Me.chkAutoStop.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkAutoStop.Properties.ValueChecked = 1
        Me.chkAutoStop.Properties.ValueUnchecked = 0
        Me.chkAutoStop.Size = New System.Drawing.Size(96, 19)
        Me.chkAutoStop.TabIndex = 38
        '
        'txtActivationDiscountCode
        '
        Me.txtActivationDiscountCode.Enabled = False
        Me.txtActivationDiscountCode.Location = New System.Drawing.Point(160, 265)
        Me.txtActivationDiscountCode.Name = "txtActivationDiscountCode"
        Me.txtActivationDiscountCode.Size = New System.Drawing.Size(112, 20)
        Me.txtActivationDiscountCode.TabIndex = 37
        '
        'cmbNextDiscCode
        '
        Me.cmbNextDiscCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_next_discount_code", True))
        Me.cmbNextDiscCode.Enabled = False
        Me.cmbNextDiscCode.Location = New System.Drawing.Point(160, 313)
        Me.cmbNextDiscCode.Name = "cmbNextDiscCode"
        Me.cmbNextDiscCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.cmbNextDiscCode.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("discount_code_id", "discount_code_id", 102, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("discount_code", "discount_code", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbNextDiscCode.Properties.DataSource = Me.objDS.discount_code
        Me.cmbNextDiscCode.Properties.DisplayMember = "discount_code"
        Me.cmbNextDiscCode.Properties.NullText = ""
        Me.cmbNextDiscCode.Properties.ValueMember = "discount_code_id"
        Me.cmbNextDiscCode.Size = New System.Drawing.Size(152, 20)
        Me.cmbNextDiscCode.TabIndex = 36
        '
        'txtDiscType
        '
        Me.txtDiscType.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.activation_discount_code_type", True))
        Me.txtDiscType.Enabled = False
        Me.txtDiscType.Location = New System.Drawing.Point(280, 265)
        Me.txtDiscType.Name = "txtDiscType"
        Me.txtDiscType.Size = New System.Drawing.Size(32, 20)
        Me.txtDiscType.TabIndex = 35
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(8, 321)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl23.TabIndex = 33
        Me.LabelControl23.Text = "Next Disc. Code"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(8, 273)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(109, 13)
        Me.LabelControl22.TabIndex = 31
        Me.LabelControl22.Text = "Activation / Disc. Code"
        '
        'chkMultiShipment
        '
        Me.chkMultiShipment.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_multishipment", True))
        Me.chkMultiShipment.Enabled = False
        Me.chkMultiShipment.Location = New System.Drawing.Point(8, 369)
        Me.chkMultiShipment.Name = "chkMultiShipment"
        Me.chkMultiShipment.Properties.Caption = "Multi-Shipment"
        Me.chkMultiShipment.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkMultiShipment.Properties.ValueChecked = 1
        Me.chkMultiShipment.Properties.ValueUnchecked = 0
        Me.chkMultiShipment.Size = New System.Drawing.Size(96, 19)
        Me.chkMultiShipment.TabIndex = 30
        '
        'cmbNextABO
        '
        Me.cmbNextABO.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_next_abo_type", True))
        Me.cmbNextABO.Enabled = False
        Me.cmbNextABO.Location = New System.Drawing.Point(160, 69)
        Me.cmbNextABO.Name = "cmbNextABO"
        Me.cmbNextABO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNextABO.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_id", "products_id", 75, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_model", "products_model", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_title", "products_title", 72, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbNextABO.Properties.DataSource = Me.objDS.products_abo
        Me.cmbNextABO.Properties.DisplayMember = "products_title"
        Me.cmbNextABO.Properties.NullText = ""
        Me.cmbNextABO.Properties.ValueMember = "products_id"
        Me.cmbNextABO.Size = New System.Drawing.Size(152, 20)
        Me.cmbNextABO.TabIndex = 29
        '
        'txtDVDNormAtHome
        '
        Me.txtDVDNormAtHome.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_home_norm", True))
        Me.txtDVDNormAtHome.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDVDNormAtHome.Enabled = False
        Me.txtDVDNormAtHome.Location = New System.Drawing.Point(240, 217)
        Me.txtDVDNormAtHome.Name = "txtDVDNormAtHome"
        Me.txtDVDNormAtHome.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDVDNormAtHome.Size = New System.Drawing.Size(72, 20)
        Me.txtDVDNormAtHome.TabIndex = 27
        '
        'txtDVDAdult
        '
        Me.txtDVDAdult.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_adult", True))
        Me.txtDVDAdult.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDVDAdult.Enabled = False
        Me.txtDVDAdult.Location = New System.Drawing.Point(160, 241)
        Me.txtDVDAdult.Name = "txtDVDAdult"
        Me.txtDVDAdult.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDVDAdult.Size = New System.Drawing.Size(72, 20)
        Me.txtDVDAdult.TabIndex = 26
        '
        'txtDVDNorm
        '
        Me.txtDVDNorm.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_norm", True))
        Me.txtDVDNorm.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDVDNorm.Enabled = False
        Me.txtDVDNorm.Location = New System.Drawing.Point(160, 217)
        Me.txtDVDNorm.Name = "txtDVDNorm"
        Me.txtDVDNorm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDVDNorm.Size = New System.Drawing.Size(72, 20)
        Me.txtDVDNorm.TabIndex = 25
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(8, 249)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl19.TabIndex = 24
        Me.LabelControl19.Text = "ADULT"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(8, 225)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl18.TabIndex = 23
        Me.LabelControl18.Text = "NORM"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(248, 201)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl17.TabIndex = 22
        Me.LabelControl17.Text = "@Home"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(160, 201)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl16.TabIndex = 21
        Me.LabelControl16.Text = "Asked"
        '
        'txtABOCredit
        '
        Me.txtABOCredit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_credit", True))
        Me.txtABOCredit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtABOCredit.Enabled = False
        Me.txtABOCredit.Location = New System.Drawing.Point(160, 177)
        Me.txtABOCredit.Name = "txtABOCredit"
        Me.txtABOCredit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtABOCredit.Properties.MaxLength = 1000
        Me.txtABOCredit.Properties.MaxValue = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.txtABOCredit.Size = New System.Drawing.Size(152, 20)
        Me.txtABOCredit.TabIndex = 20
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(8, 185)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl15.TabIndex = 19
        Me.LabelControl15.Text = "Credits"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(8, 101)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl14.TabIndex = 18
        Me.LabelControl14.Text = "Validity"
        '
        'txtAbo_ValidityTo
        '
        Me.txtAbo_ValidityTo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_validityto", True))
        Me.txtAbo_ValidityTo.EditValue = Nothing
        Me.txtAbo_ValidityTo.Enabled = False
        Me.txtAbo_ValidityTo.Location = New System.Drawing.Point(160, 93)
        Me.txtAbo_ValidityTo.Name = "txtAbo_ValidityTo"
        Me.txtAbo_ValidityTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAbo_ValidityTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtAbo_ValidityTo.Size = New System.Drawing.Size(152, 20)
        Me.txtAbo_ValidityTo.TabIndex = 17
        '
        'cmbABO
        '
        Me.cmbABO.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_type", True))
        Me.cmbABO.Enabled = False
        Me.cmbABO.Location = New System.Drawing.Point(160, 45)
        Me.cmbABO.Name = "cmbABO"
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
        Me.LabelControl13.Location = New System.Drawing.Point(8, 77)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl13.TabIndex = 14
        Me.LabelControl13.Text = "Next ABO"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(8, 53)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl12.TabIndex = 12
        Me.LabelControl12.Text = "ABO"
        '
        'GroupControl2
        '
        Me.GroupControl2.AutoSize = True
        Me.GroupControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupControl2.Controls.Add(Me.GridAddress)
        Me.GroupControl2.Controls.Add(Me.txtDeliveryFirstName)
        Me.GroupControl2.Controls.Add(Me.txtDeliveryLastName)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.cmbDeliverycountry)
        Me.GroupControl2.Controls.Add(Me.txtDeliveryCity)
        Me.GroupControl2.Controls.Add(Me.txtDeliveryPostCode)
        Me.GroupControl2.Controls.Add(Me.txtDeliveryAddr)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Location = New System.Drawing.Point(16, 472)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(600, 304)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Default Delivery Address"
        '
        'GridAddress
        '
        Me.GridAddress.AllowDrop = True
        Me.GridAddress.EmbeddedNavigator.Name = ""
        Me.GridAddress.FormsUseDefaultLookAndFeel = False
        Me.GridAddress.Location = New System.Drawing.Point(15, 133)
        Me.GridAddress.MainView = Me.GridViewAddress
        Me.GridAddress.Name = "GridAddress"
        Me.GridAddress.Size = New System.Drawing.Size(577, 146)
        Me.GridAddress.TabIndex = 20
        Me.GridAddress.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewAddress})
        '
        'GridViewAddress
        '
        Me.GridViewAddress.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.entry_firstname, Me.entry_lastname, Me.entry_street_address, Me.entry_postcode, Me.entry_city, Me.countries_name})
        Me.GridViewAddress.GridControl = Me.GridAddress
        Me.GridViewAddress.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewAddress.Name = "GridViewAddress"
        Me.GridViewAddress.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridViewAddress.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewAddress.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridViewAddress.OptionsView.ColumnAutoWidth = False
        Me.GridViewAddress.OptionsView.ShowFooter = True
        '
        'entry_firstname
        '
        Me.entry_firstname.Caption = "entry_firstname"
        Me.entry_firstname.FieldName = "entry_firstname"
        Me.entry_firstname.Name = "entry_firstname"
        Me.entry_firstname.OptionsColumn.AllowEdit = False
        Me.entry_firstname.OptionsColumn.FixedWidth = True
        Me.entry_firstname.Visible = True
        Me.entry_firstname.VisibleIndex = 0
        Me.entry_firstname.Width = 130
        '
        'entry_lastname
        '
        Me.entry_lastname.Caption = "entry_lastname"
        Me.entry_lastname.FieldName = "entry_lastname"
        Me.entry_lastname.Name = "entry_lastname"
        Me.entry_lastname.OptionsColumn.AllowEdit = False
        Me.entry_lastname.OptionsColumn.FixedWidth = True
        Me.entry_lastname.Visible = True
        Me.entry_lastname.VisibleIndex = 1
        Me.entry_lastname.Width = 156
        '
        'entry_street_address
        '
        Me.entry_street_address.Caption = "entry_street_address"
        Me.entry_street_address.FieldName = "entry_street_address"
        Me.entry_street_address.Name = "entry_street_address"
        Me.entry_street_address.OptionsColumn.AllowEdit = False
        Me.entry_street_address.OptionsColumn.FixedWidth = True
        Me.entry_street_address.Visible = True
        Me.entry_street_address.VisibleIndex = 2
        Me.entry_street_address.Width = 235
        '
        'entry_postcode
        '
        Me.entry_postcode.Caption = "entry_postcode"
        Me.entry_postcode.FieldName = "entry_postcode"
        Me.entry_postcode.Name = "entry_postcode"
        Me.entry_postcode.OptionsColumn.AllowEdit = False
        Me.entry_postcode.OptionsColumn.FixedWidth = True
        Me.entry_postcode.Visible = True
        Me.entry_postcode.VisibleIndex = 3
        Me.entry_postcode.Width = 111
        '
        'entry_city
        '
        Me.entry_city.Caption = "entry_city"
        Me.entry_city.FieldName = "entry_city"
        Me.entry_city.Name = "entry_city"
        Me.entry_city.OptionsColumn.AllowEdit = False
        Me.entry_city.OptionsColumn.FixedWidth = True
        Me.entry_city.Visible = True
        Me.entry_city.VisibleIndex = 4
        Me.entry_city.Width = 108
        '
        'countries_name
        '
        Me.countries_name.Caption = "countries_name"
        Me.countries_name.FieldName = "countries_name"
        Me.countries_name.Name = "countries_name"
        Me.countries_name.OptionsColumn.AllowEdit = False
        Me.countries_name.OptionsColumn.FixedWidth = True
        Me.countries_name.Visible = True
        Me.countries_name.VisibleIndex = 5
        Me.countries_name.Width = 135
        '
        'txtDeliveryFirstName
        '
        Me.txtDeliveryFirstName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_firstname", True))
        Me.txtDeliveryFirstName.Enabled = False
        Me.txtDeliveryFirstName.Location = New System.Drawing.Point(384, 28)
        Me.txtDeliveryFirstName.Name = "txtDeliveryFirstName"
        Me.txtDeliveryFirstName.Size = New System.Drawing.Size(208, 20)
        Me.txtDeliveryFirstName.TabIndex = 17
        '
        'txtDeliveryLastName
        '
        Me.txtDeliveryLastName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_lastname", True))
        Me.txtDeliveryLastName.Enabled = False
        Me.txtDeliveryLastName.Location = New System.Drawing.Point(152, 28)
        Me.txtDeliveryLastName.Name = "txtDeliveryLastName"
        Me.txtDeliveryLastName.Size = New System.Drawing.Size(224, 20)
        Me.txtDeliveryLastName.TabIndex = 16
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(16, 36)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl10.TabIndex = 15
        Me.LabelControl10.Text = "Name"
        '
        'cmbDeliverycountry
        '
        Me.cmbDeliverycountry.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_country_id", True))
        Me.cmbDeliverycountry.Enabled = False
        Me.cmbDeliverycountry.Location = New System.Drawing.Point(153, 100)
        Me.cmbDeliverycountry.Name = "cmbDeliverycountry"
        Me.cmbDeliverycountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDeliverycountry.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("countries_id", "countries_id", 77, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("countries_name", "countries_name", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbDeliverycountry.Properties.DataSource = Me.objDS.country
        Me.cmbDeliverycountry.Properties.DisplayMember = "countries_name"
        Me.cmbDeliverycountry.Properties.NullText = ""
        Me.cmbDeliverycountry.Properties.ValueMember = "countries_id"
        Me.cmbDeliverycountry.Size = New System.Drawing.Size(440, 20)
        Me.cmbDeliverycountry.TabIndex = 14
        '
        'txtDeliveryCity
        '
        Me.txtDeliveryCity.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_city", True))
        Me.txtDeliveryCity.Enabled = False
        Me.txtDeliveryCity.Location = New System.Drawing.Point(280, 76)
        Me.txtDeliveryCity.Name = "txtDeliveryCity"
        Me.txtDeliveryCity.Size = New System.Drawing.Size(312, 20)
        Me.txtDeliveryCity.TabIndex = 13
        '
        'txtDeliveryPostCode
        '
        Me.txtDeliveryPostCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_postcode", True))
        Me.txtDeliveryPostCode.Enabled = False
        Me.txtDeliveryPostCode.Location = New System.Drawing.Point(152, 76)
        Me.txtDeliveryPostCode.Name = "txtDeliveryPostCode"
        Me.txtDeliveryPostCode.Size = New System.Drawing.Size(120, 20)
        Me.txtDeliveryPostCode.TabIndex = 12
        '
        'txtDeliveryAddr
        '
        Me.txtDeliveryAddr.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_street_address", True))
        Me.txtDeliveryAddr.Enabled = False
        Me.txtDeliveryAddr.Location = New System.Drawing.Point(152, 52)
        Me.txtDeliveryAddr.Name = "txtDeliveryAddr"
        Me.txtDeliveryAddr.Size = New System.Drawing.Size(440, 20)
        Me.txtDeliveryAddr.TabIndex = 10
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(16, 60)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl9.TabIndex = 8
        Me.LabelControl9.Text = "Address"
        '
        'GroupControl1
        '
        Me.GroupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl1.Controls.Add(Me.txtPtSponsorShip)
        Me.GroupControl1.Controls.Add(Me.lblComment)
        Me.GroupControl1.Controls.Add(Me.chkRedListed)
        Me.GroupControl1.Controls.Add(Me.txtComment)
        Me.GroupControl1.Controls.Add(Me.chkBlackListed)
        Me.GroupControl1.Controls.Add(Me.txtYearsOld)
        Me.GroupControl1.Controls.Add(Me.chkNewsLetterPartner)
        Me.GroupControl1.Controls.Add(Me.lblGender)
        Me.GroupControl1.Controls.Add(Me.chkNewsLetter)
        Me.GroupControl1.Controls.Add(Me.txtGender)
        Me.GroupControl1.Controls.Add(Me.LabelControl31)
        Me.GroupControl1.Controls.Add(Me.lblyearsOld)
        Me.GroupControl1.Controls.Add(Me.txtWishListKind)
        Me.GroupControl1.Controls.Add(Me.lblSetPassWord)
        Me.GroupControl1.Controls.Add(Me.LabelControl30)
        Me.GroupControl1.Controls.Add(Me.lblLogas)
        Me.GroupControl1.Controls.Add(Me.txtNbrOfLogons)
        Me.GroupControl1.Controls.Add(Me.LabelControl36)
        Me.GroupControl1.Controls.Add(Me.LabelControl29)
        Me.GroupControl1.Controls.Add(Me.cmbEntity)
        Me.GroupControl1.Controls.Add(Me.LabelControl28)
        Me.GroupControl1.Controls.Add(Me.LabelControl34)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.LabelControl26)
        Me.GroupControl1.Controls.Add(Me.cmbLanguage)
        Me.GroupControl1.Controls.Add(Me.txtDateCreated)
        Me.GroupControl1.Controls.Add(Me.LabelControl27)
        Me.GroupControl1.Controls.Add(Me.txtTel)
        Me.GroupControl1.Controls.Add(Me.txtEMail)
        Me.GroupControl1.Controls.Add(Me.txtTelEvening)
        Me.GroupControl1.Controls.Add(Me.LabelControl21)
        Me.GroupControl1.Controls.Add(Me.txtABO)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.txtFirstName)
        Me.GroupControl1.Controls.Add(Me.txtLastName)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txtCustomers_id)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Location = New System.Drawing.Point(16, 40)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(600, 413)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Global Info"
        '
        'txtPtSponsorShip
        '
        Me.txtPtSponsorShip.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.mgm_points", True))
        Me.txtPtSponsorShip.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPtSponsorShip.Enabled = False
        Me.txtPtSponsorShip.Location = New System.Drawing.Point(438, 285)
        Me.txtPtSponsorShip.Name = "txtPtSponsorShip"
        Me.txtPtSponsorShip.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtPtSponsorShip.Properties.MaxLength = 100000
        Me.txtPtSponsorShip.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtPtSponsorShip.Size = New System.Drawing.Size(152, 20)
        Me.txtPtSponsorShip.TabIndex = 26
        '
        'lblComment
        '
        Me.lblComment.Location = New System.Drawing.Point(16, 234)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(45, 13)
        Me.lblComment.TabIndex = 58
        Me.lblComment.Text = "Comment"
        '
        'chkRedListed
        '
        Me.chkRedListed.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.red_listed", True))
        Me.chkRedListed.Enabled = False
        Me.chkRedListed.Location = New System.Drawing.Point(356, 359)
        Me.chkRedListed.Name = "chkRedListed"
        Me.chkRedListed.Properties.Caption = "Red Listed"
        Me.chkRedListed.Properties.ValueChecked = 1
        Me.chkRedListed.Properties.ValueUnchecked = 0
        Me.chkRedListed.Size = New System.Drawing.Size(128, 19)
        Me.chkRedListed.TabIndex = 54
        '
        'txtComment
        '
        Me.txtComment.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.comment", True))
        Me.txtComment.Enabled = False
        Me.txtComment.Location = New System.Drawing.Point(144, 231)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(440, 20)
        Me.txtComment.TabIndex = 57
        '
        'chkBlackListed
        '
        Me.chkBlackListed.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.black_listed", True))
        Me.chkBlackListed.Enabled = False
        Me.chkBlackListed.Location = New System.Drawing.Point(356, 384)
        Me.chkBlackListed.Name = "chkBlackListed"
        Me.chkBlackListed.Properties.Caption = "Black Listed"
        Me.chkBlackListed.Properties.ValueChecked = 1
        Me.chkBlackListed.Properties.ValueUnchecked = 0
        Me.chkBlackListed.Size = New System.Drawing.Size(147, 19)
        Me.chkBlackListed.TabIndex = 53
        '
        'txtYearsOld
        '
        Me.txtYearsOld.Enabled = False
        Me.txtYearsOld.Location = New System.Drawing.Point(296, 179)
        Me.txtYearsOld.Name = "txtYearsOld"
        Me.txtYearsOld.Size = New System.Drawing.Size(28, 20)
        Me.txtYearsOld.TabIndex = 56
        '
        'chkNewsLetterPartner
        '
        Me.chkNewsLetterPartner.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_newsletterpartner", True))
        Me.chkNewsLetterPartner.Enabled = False
        Me.chkNewsLetterPartner.Location = New System.Drawing.Point(142, 384)
        Me.chkNewsLetterPartner.Name = "chkNewsLetterPartner"
        Me.chkNewsLetterPartner.Properties.Caption = "NewsLetter Partner"
        Me.chkNewsLetterPartner.Properties.ValueChecked = 1
        Me.chkNewsLetterPartner.Properties.ValueUnchecked = 0
        Me.chkNewsLetterPartner.Size = New System.Drawing.Size(152, 19)
        Me.chkNewsLetterPartner.TabIndex = 52
        '
        'lblGender
        '
        Me.lblGender.Location = New System.Drawing.Point(16, 208)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(35, 13)
        Me.lblGender.TabIndex = 55
        Me.lblGender.Text = "Gender"
        '
        'chkNewsLetter
        '
        Me.chkNewsLetter.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_newsletter", True))
        Me.chkNewsLetter.Enabled = False
        Me.chkNewsLetter.Location = New System.Drawing.Point(142, 359)
        Me.chkNewsLetter.Name = "chkNewsLetter"
        Me.chkNewsLetter.Properties.Caption = "NewsLetter"
        Me.chkNewsLetter.Properties.ValueChecked = 1
        Me.chkNewsLetter.Properties.ValueUnchecked = 0
        Me.chkNewsLetter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNewsLetter.Size = New System.Drawing.Size(128, 19)
        Me.chkNewsLetter.TabIndex = 51
        '
        'txtGender
        '
        Me.txtGender.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_gender", True))
        Me.txtGender.Enabled = False
        Me.txtGender.Location = New System.Drawing.Point(144, 205)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(28, 20)
        Me.txtGender.TabIndex = 54
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(330, 288)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl31.TabIndex = 49
        Me.LabelControl31.Text = "Points Parainage"
        '
        'lblyearsOld
        '
        Me.lblyearsOld.Location = New System.Drawing.Point(330, 182)
        Me.lblyearsOld.Name = "lblyearsOld"
        Me.lblyearsOld.Size = New System.Drawing.Size(44, 13)
        Me.lblyearsOld.TabIndex = 53
        Me.lblyearsOld.Text = "years old"
        '
        'txtWishListKind
        '
        Me.txtWishListKind.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.wishlist_kind", True))
        Me.txtWishListKind.Enabled = False
        Me.txtWishListKind.Location = New System.Drawing.Point(438, 260)
        Me.txtWishListKind.Name = "txtWishListKind"
        Me.txtWishListKind.Size = New System.Drawing.Size(152, 20)
        Me.txtWishListKind.TabIndex = 48
        '
        'lblSetPassWord
        '
        Me.lblSetPassWord.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.lblSetPassWord.Appearance.Options.UseForeColor = True
        Me.lblSetPassWord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSetPassWord.Location = New System.Drawing.Point(199, 29)
        Me.lblSetPassWord.Name = "lblSetPassWord"
        Me.lblSetPassWord.Size = New System.Drawing.Size(100, 13)
        Me.lblSetPassWord.TabIndex = 51
        Me.lblSetPassWord.Text = " Set a new password"
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(330, 263)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl30.TabIndex = 47
        Me.LabelControl30.Text = "WishList Kind"
        '
        'lblLogas
        '
        Me.lblLogas.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.lblLogas.Appearance.Options.UseForeColor = True
        Me.lblLogas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogas.Location = New System.Drawing.Point(144, 29)
        Me.lblLogas.Name = "lblLogas"
        Me.lblLogas.Size = New System.Drawing.Size(28, 13)
        Me.lblLogas.TabIndex = 50
        Me.lblLogas.Text = "Logas"
        '
        'txtNbrOfLogons
        '
        Me.txtNbrOfLogons.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_info_number_of_logons", True))
        Me.txtNbrOfLogons.Enabled = False
        Me.txtNbrOfLogons.Location = New System.Drawing.Point(144, 315)
        Me.txtNbrOfLogons.Name = "txtNbrOfLogons"
        Me.txtNbrOfLogons.Size = New System.Drawing.Size(152, 20)
        Me.txtNbrOfLogons.TabIndex = 46
        '
        'LabelControl36
        '
        Me.LabelControl36.Location = New System.Drawing.Point(16, 134)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl36.TabIndex = 49
        Me.LabelControl36.Text = "E-Mail"
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(14, 316)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl29.TabIndex = 45
        Me.LabelControl29.Text = "Nbr of Logons"
        '
        'cmbEntity
        '
        Me.cmbEntity.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.EntityID", True))
        Me.cmbEntity.Enabled = False
        Me.cmbEntity.Location = New System.Drawing.Point(144, 75)
        Me.cmbEntity.Name = "cmbEntity"
        Me.cmbEntity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbEntity.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 33, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbEntity.Properties.DataSource = Me.objDS.generalentity
        Me.cmbEntity.Properties.DisplayMember = "Name"
        Me.cmbEntity.Properties.NullText = ""
        Me.cmbEntity.Properties.ValueMember = "EntityID"
        Me.cmbEntity.Size = New System.Drawing.Size(224, 20)
        Me.cmbEntity.TabIndex = 44
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(14, 292)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl28.TabIndex = 44
        Me.LabelControl28.Text = "Last Logon"
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(15, 78)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl34.TabIndex = 43
        Me.LabelControl34.Text = "Entity"
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_info_date_of_last_logon", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Enabled = False
        Me.DateEdit2.Location = New System.Drawing.Point(144, 289)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit2.Size = New System.Drawing.Size(152, 20)
        Me.DateEdit2.TabIndex = 43
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(280, 51)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl26.TabIndex = 42
        Me.LabelControl26.Text = "Created"
        '
        'cmbLanguage
        '
        Me.cmbLanguage.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_language", True))
        Me.cmbLanguage.Enabled = False
        Me.cmbLanguage.Location = New System.Drawing.Point(144, 260)
        Me.cmbLanguage.Name = "cmbLanguage"
        Me.cmbLanguage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguage.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 32, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbLanguage.Properties.DataSource = Me.objDS.languages
        Me.cmbLanguage.Properties.DisplayMember = "name"
        Me.cmbLanguage.Properties.NullText = ""
        Me.cmbLanguage.Properties.ValueMember = "languages_id"
        Me.cmbLanguage.Size = New System.Drawing.Size(152, 20)
        Me.cmbLanguage.TabIndex = 17
        '
        'txtDateCreated
        '
        Me.txtDateCreated.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_info_date_account_created", True))
        Me.txtDateCreated.EditValue = Nothing
        Me.txtDateCreated.Enabled = False
        Me.txtDateCreated.Location = New System.Drawing.Point(376, 51)
        Me.txtDateCreated.Name = "txtDateCreated"
        Me.txtDateCreated.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtDateCreated.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateCreated.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDateCreated.Size = New System.Drawing.Size(144, 20)
        Me.txtDateCreated.TabIndex = 41
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(14, 268)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl27.TabIndex = 16
        Me.LabelControl27.Text = "Language"
        '
        'txtTel
        '
        Me.txtTel.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_telephone", True))
        Me.txtTel.Enabled = False
        Me.txtTel.Location = New System.Drawing.Point(144, 155)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(224, 20)
        Me.txtTel.TabIndex = 20
        '
        'txtEMail
        '
        Me.txtEMail.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_email_address", True))
        Me.txtEMail.Enabled = False
        Me.txtEMail.Location = New System.Drawing.Point(144, 131)
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(440, 20)
        Me.txtEMail.TabIndex = 19
        '
        'txtTelEvening
        '
        Me.txtTelEvening.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_telephone_evening", True))
        Me.txtTelEvening.Enabled = False
        Me.txtTelEvening.Location = New System.Drawing.Point(376, 155)
        Me.txtTelEvening.Name = "txtTelEvening"
        Me.txtTelEvening.Size = New System.Drawing.Size(208, 20)
        Me.txtTelEvening.TabIndex = 18
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(16, 157)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl21.TabIndex = 16
        Me.LabelControl21.Text = "Tel Day / Evening"
        '
        'txtABO
        '
        Me.txtABO.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo", True))
        Me.txtABO.Enabled = False
        Me.txtABO.Location = New System.Drawing.Point(528, 51)
        Me.txtABO.Name = "txtABO"
        Me.txtABO.Properties.Appearance.BackColor = System.Drawing.Color.Red
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
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(16, 182)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl11.TabIndex = 11
        Me.LabelControl11.Text = "Date of Birth"
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_dob", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Enabled = False
        Me.DateEdit1.Location = New System.Drawing.Point(144, 179)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(128, 20)
        Me.DateEdit1.TabIndex = 10
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_firstname", True))
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Location = New System.Drawing.Point(376, 107)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(208, 20)
        Me.txtFirstName.TabIndex = 9
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_lastname", True))
        Me.txtLastName.Enabled = False
        Me.txtLastName.Location = New System.Drawing.Point(144, 107)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(224, 20)
        Me.txtLastName.TabIndex = 7
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(16, 110)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Name"
        '
        'txtCustomers_id
        '
        Me.txtCustomers_id.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_id", True))
        Me.txtCustomers_id.Enabled = False
        Me.txtCustomers_id.Location = New System.Drawing.Point(144, 51)
        Me.txtCustomers_id.Name = "txtCustomers_id"
        Me.txtCustomers_id.Properties.ReadOnly = True
        Me.txtCustomers_id.Size = New System.Drawing.Size(128, 20)
        Me.txtCustomers_id.TabIndex = 5
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(16, 54)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl8.TabIndex = 4
        Me.LabelControl8.Text = "Customer ID"
        '
        'btnStopNow
        '
        Me.btnStopNow.Location = New System.Drawing.Point(989, 361)
        Me.btnStopNow.Name = "btnStopNow"
        Me.btnStopNow.Size = New System.Drawing.Size(144, 23)
        Me.btnStopNow.TabIndex = 2
        Me.btnStopNow.Text = "Stop NOW"
        '
        'btnStopAtReconduction
        '
        Me.btnStopAtReconduction.Location = New System.Drawing.Point(989, 130)
        Me.btnStopAtReconduction.Name = "btnStopAtReconduction"
        Me.btnStopAtReconduction.Size = New System.Drawing.Size(144, 23)
        Me.btnStopAtReconduction.TabIndex = 3
        Me.btnStopAtReconduction.Text = "Stop @ Reconduction"
        '
        'tabSearch
        '
        Me.tabSearch.Controls.Add(Me.GridControl1)
        Me.tabSearch.Controls.Add(Me.PanelControl1)
        Me.tabSearch.Name = "tabSearch"
        Me.tabSearch.Size = New System.Drawing.Size(1150, 917)
        Me.tabSearch.Text = "Search"
        '
        'PanelControl1
        '
        Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl1.Controls.Add(Me.BtnEmailError)
        Me.PanelControl1.Controls.Add(Me.btnRedlisted)
        Me.PanelControl1.Controls.Add(Me.btnBlackListed)
        Me.PanelControl1.Controls.Add(Me.BtnSponsorCard)
        Me.PanelControl1.Controls.Add(Me.btnViewGift)
        Me.PanelControl1.Controls.Add(Me.btnViewCustserv)
        Me.PanelControl1.Controls.Add(Me.TxtCustomers_NumComm)
        Me.PanelControl1.Controls.Add(Me.lblNumComm)
        Me.PanelControl1.Controls.Add(Me.txtcustomers_domiciliation_number_search)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.btnPhoneActivation)
        Me.PanelControl1.Controls.Add(Me.LabelControl35)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtcustomers_postcode_search)
        Me.PanelControl1.Controls.Add(Me.btnSearch)
        Me.PanelControl1.Controls.Add(Me.txtcustomers_address_street_search)
        Me.PanelControl1.Controls.Add(Me.txtcustomers_email_address_search)
        Me.PanelControl1.Controls.Add(Me.txtcustomers_name_search)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txtcustomers_id_search)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1150, 176)
        Me.PanelControl1.TabIndex = 0
        '
        'BtnEmailError
        '
        Me.BtnEmailError.Location = New System.Drawing.Point(951, 95)
        Me.BtnEmailError.Name = "BtnEmailError"
        Me.BtnEmailError.Size = New System.Drawing.Size(138, 23)
        Me.BtnEmailError.TabIndex = 59
        Me.BtnEmailError.Text = "Email Error"
        '
        'btnRedlisted
        '
        Me.btnRedlisted.Location = New System.Drawing.Point(797, 95)
        Me.btnRedlisted.Name = "btnRedlisted"
        Me.btnRedlisted.Size = New System.Drawing.Size(138, 23)
        Me.btnRedlisted.TabIndex = 58
        Me.btnRedlisted.Text = "Customers Redlisted"
        '
        'btnBlackListed
        '
        Me.btnBlackListed.Location = New System.Drawing.Point(668, 95)
        Me.btnBlackListed.Name = "btnBlackListed"
        Me.btnBlackListed.Size = New System.Drawing.Size(123, 23)
        Me.btnBlackListed.TabIndex = 57
        Me.btnBlackListed.Text = "Customers Blacklisted"
        '
        'BtnSponsorCard
        '
        Me.BtnSponsorCard.Location = New System.Drawing.Point(951, 129)
        Me.BtnSponsorCard.Name = "BtnSponsorCard"
        Me.BtnSponsorCard.Size = New System.Drawing.Size(138, 23)
        Me.BtnSponsorCard.TabIndex = 56
        Me.BtnSponsorCard.Text = "Sponsor card"
        '
        'btnViewGift
        '
        Me.btnViewGift.Location = New System.Drawing.Point(797, 129)
        Me.btnViewGift.Name = "btnViewGift"
        Me.btnViewGift.Size = New System.Drawing.Size(138, 23)
        Me.btnViewGift.TabIndex = 55
        Me.btnViewGift.Text = "View Customers With Gift"
        '
        'btnViewCustserv
        '
        Me.btnViewCustserv.Location = New System.Drawing.Point(668, 129)
        Me.btnViewCustserv.Name = "btnViewCustserv"
        Me.btnViewCustserv.Size = New System.Drawing.Size(123, 23)
        Me.btnViewCustserv.TabIndex = 54
        Me.btnViewCustserv.Text = "View CustServ"
        '
        'TxtCustomers_NumComm
        '
        Me.TxtCustomers_NumComm.Location = New System.Drawing.Point(261, 45)
        Me.TxtCustomers_NumComm.Name = "TxtCustomers_NumComm"
        Me.TxtCustomers_NumComm.Size = New System.Drawing.Size(137, 20)
        Me.TxtCustomers_NumComm.TabIndex = 53
        '
        'lblNumComm
        '
        Me.lblNumComm.Location = New System.Drawing.Point(404, 48)
        Me.lblNumComm.Name = "lblNumComm"
        Me.lblNumComm.Size = New System.Drawing.Size(96, 13)
        Me.lblNumComm.TabIndex = 52
        Me.lblNumComm.Text = "Communication Num"
        '
        'txtcustomers_domiciliation_number_search
        '
        Me.txtcustomers_domiciliation_number_search.Location = New System.Drawing.Point(261, 19)
        Me.txtcustomers_domiciliation_number_search.Name = "txtcustomers_domiciliation_number_search"
        Me.txtcustomers_domiciliation_number_search.Size = New System.Drawing.Size(137, 20)
        Me.txtcustomers_domiciliation_number_search.TabIndex = 51
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(404, 22)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl4.TabIndex = 50
        Me.LabelControl4.Text = "Domiciliation Num"
        '
        'btnPhoneActivation
        '
        Me.btnPhoneActivation.Location = New System.Drawing.Point(521, 129)
        Me.btnPhoneActivation.Name = "btnPhoneActivation"
        Me.btnPhoneActivation.Size = New System.Drawing.Size(141, 23)
        Me.btnPhoneActivation.TabIndex = 49
        Me.btnPhoneActivation.Text = "&View Phone Activation"
        '
        'LabelControl35
        '
        Me.LabelControl35.Location = New System.Drawing.Point(24, 71)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl35.TabIndex = 48
        Me.LabelControl35.Text = "E-Mail"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(24, 139)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl6.TabIndex = 47
        Me.LabelControl6.Text = "PostCode"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(24, 119)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl5.TabIndex = 46
        Me.LabelControl5.Text = "Street"
        '
        'txtcustomers_postcode_search
        '
        Me.txtcustomers_postcode_search.Location = New System.Drawing.Point(99, 139)
        Me.txtcustomers_postcode_search.Name = "txtcustomers_postcode_search"
        Me.txtcustomers_postcode_search.Size = New System.Drawing.Size(156, 20)
        Me.txtcustomers_postcode_search.TabIndex = 12
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(440, 129)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "&Search"
        '
        'txtcustomers_address_street_search
        '
        Me.txtcustomers_address_street_search.Location = New System.Drawing.Point(99, 115)
        Me.txtcustomers_address_street_search.Name = "txtcustomers_address_street_search"
        Me.txtcustomers_address_street_search.Size = New System.Drawing.Size(156, 20)
        Me.txtcustomers_address_street_search.TabIndex = 9
        '
        'txtcustomers_email_address_search
        '
        Me.txtcustomers_email_address_search.Location = New System.Drawing.Point(99, 67)
        Me.txtcustomers_email_address_search.Name = "txtcustomers_email_address_search"
        Me.txtcustomers_email_address_search.Size = New System.Drawing.Size(156, 20)
        Me.txtcustomers_email_address_search.TabIndex = 5
        '
        'txtcustomers_name_search
        '
        Me.txtcustomers_name_search.Location = New System.Drawing.Point(99, 43)
        Me.txtcustomers_name_search.Name = "txtcustomers_name_search"
        Me.txtcustomers_name_search.Size = New System.Drawing.Size(156, 20)
        Me.txtcustomers_name_search.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(24, 48)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Part of Name"
        '
        'txtcustomers_id_search
        '
        Me.txtcustomers_id_search.Location = New System.Drawing.Point(99, 19)
        Me.txtcustomers_id_search.Name = "txtcustomers_id_search"
        Me.txtcustomers_id_search.Size = New System.Drawing.Size(156, 20)
        Me.txtcustomers_id_search.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Customer ID"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 57)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabMain
        Me.XtraTabControl1.Size = New System.Drawing.Size(1159, 948)
        Me.XtraTabControl1.TabIndex = 35
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabSearch, Me.tabMain, Me.tabComment, Me.tabWishList, Me.tabAboHistory, Me.tabOrdersHistor, Me.tabCRM, Me.tabPayment, Me.tabPaymentMovements, Me.tabDroselia, Me.tabAboProcess, Me.TabMailHistory, Me.tabPurchase, Me.tabCreditHist, Me.tabSponsorShip, Me.tabCompensation, Me.tabProductsRating, Me.tabSuspendedHistory})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'tabComment
        '
        Me.tabComment.AutoScroll = True
        Me.tabComment.Controls.Add(Me.MemoCustomersComment)
        Me.tabComment.Controls.Add(Me.GridCustComment)
        Me.tabComment.Controls.Add(Me.MemoInsertComment)
        Me.tabComment.Controls.Add(Me.btnAddCustomersComment)
        Me.tabComment.Name = "tabComment"
        Me.tabComment.Size = New System.Drawing.Size(1150, 917)
        Me.tabComment.Text = "Comment"
        '
        'MemoCustomersComment
        '
        Me.MemoCustomersComment.Location = New System.Drawing.Point(57, 49)
        Me.MemoCustomersComment.Name = "MemoCustomersComment"
        Me.MemoCustomersComment.Properties.ReadOnly = True
        Me.MemoCustomersComment.Size = New System.Drawing.Size(388, 85)
        Me.MemoCustomersComment.StyleController = Me.LayoutCustServ
        Me.MemoCustomersComment.TabIndex = 15
        '
        'GridCustComment
        '
        Me.GridCustComment.EmbeddedNavigator.Name = ""
        Me.GridCustComment.FormsUseDefaultLookAndFeel = False
        Me.GridCustComment.Location = New System.Drawing.Point(57, 197)
        Me.GridCustComment.MainView = Me.GridViewCustComment
        Me.GridCustComment.Name = "GridCustComment"
        Me.GridCustComment.Size = New System.Drawing.Size(782, 398)
        Me.GridCustComment.TabIndex = 0
        Me.GridCustComment.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCustComment})
        '
        'GridViewCustComment
        '
        Me.GridViewCustComment.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.customers_comment_text, Me.customers_comment_date, Me.fullName})
        Me.GridViewCustComment.GridControl = Me.GridCustComment
        Me.GridViewCustComment.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewCustComment.Name = "GridViewCustComment"
        '
        'customers_comment_text
        '
        Me.customers_comment_text.Caption = "customers_comment_text"
        Me.customers_comment_text.FieldName = "customers_comment_text"
        Me.customers_comment_text.Name = "customers_comment_text"
        Me.customers_comment_text.OptionsColumn.AllowEdit = False
        Me.customers_comment_text.OptionsColumn.ReadOnly = True
        Me.customers_comment_text.Visible = True
        Me.customers_comment_text.VisibleIndex = 1
        Me.customers_comment_text.Width = 1002
        '
        'customers_comment_date
        '
        Me.customers_comment_date.Caption = "customers_comment_date"
        Me.customers_comment_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.customers_comment_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.customers_comment_date.FieldName = "customers_comment_date"
        Me.customers_comment_date.Name = "customers_comment_date"
        Me.customers_comment_date.OptionsColumn.AllowEdit = False
        Me.customers_comment_date.OptionsColumn.ReadOnly = True
        Me.customers_comment_date.Visible = True
        Me.customers_comment_date.VisibleIndex = 0
        Me.customers_comment_date.Width = 549
        '
        'fullName
        '
        Me.fullName.Caption = "comment_by"
        Me.fullName.FieldName = "FullName"
        Me.fullName.Name = "fullName"
        Me.fullName.Visible = True
        Me.fullName.VisibleIndex = 2
        '
        'MemoInsertComment
        '
        Me.MemoInsertComment.Location = New System.Drawing.Point(451, 49)
        Me.MemoInsertComment.Name = "MemoInsertComment"
        Me.MemoInsertComment.Size = New System.Drawing.Size(388, 85)
        Me.MemoInsertComment.StyleController = Me.LayoutCustServ
        Me.MemoInsertComment.TabIndex = 16
        '
        'btnAddCustomersComment
        '
        Me.btnAddCustomersComment.Location = New System.Drawing.Point(693, 140)
        Me.btnAddCustomersComment.Name = "btnAddCustomersComment"
        Me.btnAddCustomersComment.Size = New System.Drawing.Size(146, 23)
        Me.btnAddCustomersComment.TabIndex = 14
        Me.btnAddCustomersComment.Text = "Add Customers Comment"
        '
        'tabPurchase
        '
        Me.tabPurchase.AutoScroll = True
        Me.tabPurchase.Controls.Add(Me.GridShoppingOrders)
        Me.tabPurchase.Name = "tabPurchase"
        Me.tabPurchase.Size = New System.Drawing.Size(1150, 917)
        Me.tabPurchase.Text = "Purchase"
        '
        'GridShoppingOrders
        '
        Me.GridShoppingOrders.EmbeddedNavigator.Name = ""
        Me.GridShoppingOrders.FormsUseDefaultLookAndFeel = False
        Me.GridShoppingOrders.Location = New System.Drawing.Point(0, 3)
        Me.GridShoppingOrders.MainView = Me.GridViewShoppingOrders
        Me.GridShoppingOrders.Name = "GridShoppingOrders"
        Me.GridShoppingOrders.Size = New System.Drawing.Size(1400, 914)
        Me.GridShoppingOrders.TabIndex = 0
        Me.GridShoppingOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewShoppingOrders})
        '
        'GridViewShoppingOrders
        '
        Me.GridViewShoppingOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.shopping_orders_id, Me.customers_id, Me.date_orders, Me.shopping_products_id, Me.quantity, Me.dvd_id, Me.price, Me.shopping_discount_code_id, Me.products_type, Me.products_state, Me.products_name, Me.products_description, Me.products_bonus, Me.products_url, Me.products_awards, Me.products_viewed, Me.products_image_big, Me.status_name, Me.shopping_discount_value})
        Me.GridViewShoppingOrders.GridControl = Me.GridShoppingOrders
        Me.GridViewShoppingOrders.GroupCount = 1
        Me.GridViewShoppingOrders.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewShoppingOrders.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "products_type", Nothing, "")})
        Me.GridViewShoppingOrders.Name = "GridViewShoppingOrders"
        Me.GridViewShoppingOrders.OptionsView.ShowFooter = True
        Me.GridViewShoppingOrders.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.products_type, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'shopping_orders_id
        '
        Me.shopping_orders_id.Caption = "shopping_orders_id"
        Me.shopping_orders_id.FieldName = "shopping_orders_id"
        Me.shopping_orders_id.Name = "shopping_orders_id"
        Me.shopping_orders_id.OptionsColumn.AllowEdit = False
        Me.shopping_orders_id.OptionsColumn.FixedWidth = True
        '
        'customers_id
        '
        Me.customers_id.Caption = "customers_id"
        Me.customers_id.FieldName = "customers_id"
        Me.customers_id.Name = "customers_id"
        Me.customers_id.OptionsColumn.AllowEdit = False
        '
        'date_orders
        '
        Me.date_orders.Caption = "date_orders"
        Me.date_orders.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.date_orders.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.date_orders.FieldName = "date"
        Me.date_orders.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.date_orders.Name = "date_orders"
        Me.date_orders.OptionsColumn.AllowEdit = False
        Me.date_orders.OptionsColumn.FixedWidth = True
        Me.date_orders.OptionsColumn.ReadOnly = True
        Me.date_orders.Visible = True
        Me.date_orders.VisibleIndex = 0
        Me.date_orders.Width = 96
        '
        'shopping_products_id
        '
        Me.shopping_products_id.Caption = "products_id"
        Me.shopping_products_id.FieldName = "products_id"
        Me.shopping_products_id.Name = "shopping_products_id"
        Me.shopping_products_id.OptionsColumn.AllowEdit = False
        Me.shopping_products_id.OptionsColumn.FixedWidth = True
        Me.shopping_products_id.OptionsColumn.ReadOnly = True
        Me.shopping_products_id.Visible = True
        Me.shopping_products_id.VisibleIndex = 1
        '
        'quantity
        '
        Me.quantity.Caption = "quantity"
        Me.quantity.FieldName = "quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.OptionsColumn.AllowEdit = False
        Me.quantity.OptionsColumn.FixedWidth = True
        Me.quantity.OptionsColumn.ReadOnly = True
        Me.quantity.Visible = True
        Me.quantity.VisibleIndex = 2
        Me.quantity.Width = 77
        '
        'dvd_id
        '
        Me.dvd_id.Caption = "dvd_id"
        Me.dvd_id.FieldName = "dvd_id"
        Me.dvd_id.Name = "dvd_id"
        Me.dvd_id.OptionsColumn.AllowEdit = False
        Me.dvd_id.OptionsColumn.ReadOnly = True
        Me.dvd_id.Width = 144
        '
        'price
        '
        Me.price.Caption = "price"
        Me.price.FieldName = "price"
        Me.price.Name = "price"
        Me.price.OptionsColumn.AllowEdit = False
        Me.price.OptionsColumn.FixedWidth = True
        Me.price.OptionsColumn.ReadOnly = True
        Me.price.Visible = True
        Me.price.VisibleIndex = 3
        Me.price.Width = 71
        '
        'shopping_discount_code_id
        '
        Me.shopping_discount_code_id.Caption = "shopping_discount_code"
        Me.shopping_discount_code_id.FieldName = "discount_code"
        Me.shopping_discount_code_id.Name = "shopping_discount_code_id"
        Me.shopping_discount_code_id.OptionsColumn.AllowEdit = False
        Me.shopping_discount_code_id.OptionsColumn.FixedWidth = True
        Me.shopping_discount_code_id.OptionsColumn.ReadOnly = True
        Me.shopping_discount_code_id.Visible = True
        Me.shopping_discount_code_id.VisibleIndex = 7
        Me.shopping_discount_code_id.Width = 184
        '
        'products_type
        '
        Me.products_type.Caption = "products_type"
        Me.products_type.FieldName = "products_type"
        Me.products_type.Name = "products_type"
        Me.products_type.OptionsColumn.AllowEdit = False
        Me.products_type.OptionsColumn.FixedWidth = True
        Me.products_type.OptionsColumn.ReadOnly = True
        Me.products_type.Width = 135
        '
        'products_state
        '
        Me.products_state.Caption = "products_state"
        Me.products_state.FieldName = "products_state"
        Me.products_state.Name = "products_state"
        Me.products_state.OptionsColumn.AllowEdit = False
        Me.products_state.OptionsColumn.FixedWidth = True
        Me.products_state.OptionsColumn.ReadOnly = True
        Me.products_state.Visible = True
        Me.products_state.VisibleIndex = 5
        Me.products_state.Width = 125
        '
        'products_name
        '
        Me.products_name.Caption = "products_name"
        Me.products_name.FieldName = "products_name"
        Me.products_name.Name = "products_name"
        Me.products_name.OptionsColumn.AllowEdit = False
        Me.products_name.OptionsColumn.FixedWidth = True
        Me.products_name.OptionsColumn.ReadOnly = True
        Me.products_name.Visible = True
        Me.products_name.VisibleIndex = 6
        Me.products_name.Width = 336
        '
        'products_description
        '
        Me.products_description.Caption = "products_description"
        Me.products_description.FieldName = "products_description"
        Me.products_description.Name = "products_description"
        Me.products_description.OptionsColumn.AllowEdit = False
        '
        'products_bonus
        '
        Me.products_bonus.Caption = "products_bonus"
        Me.products_bonus.FieldName = "products_bonus"
        Me.products_bonus.Name = "products_bonus"
        Me.products_bonus.OptionsColumn.AllowEdit = False
        '
        'products_url
        '
        Me.products_url.Caption = "products_url"
        Me.products_url.FieldName = "products_url"
        Me.products_url.Name = "products_url"
        Me.products_url.OptionsColumn.AllowEdit = False
        '
        'products_awards
        '
        Me.products_awards.Caption = "products_awards"
        Me.products_awards.FieldName = "products_awards"
        Me.products_awards.Name = "products_awards"
        Me.products_awards.OptionsColumn.AllowEdit = False
        '
        'products_viewed
        '
        Me.products_viewed.Caption = "products_viewed"
        Me.products_viewed.FieldName = "products_viewed"
        Me.products_viewed.Name = "products_viewed"
        Me.products_viewed.OptionsColumn.AllowEdit = False
        '
        'products_image_big
        '
        Me.products_image_big.Caption = "products_image_big"
        Me.products_image_big.FieldName = "products_image_big"
        Me.products_image_big.Name = "products_image_big"
        Me.products_image_big.OptionsColumn.AllowEdit = False
        '
        'status_name
        '
        Me.status_name.Caption = "status_name"
        Me.status_name.FieldName = "status_name"
        Me.status_name.Name = "status_name"
        Me.status_name.OptionsColumn.AllowEdit = False
        Me.status_name.OptionsColumn.FixedWidth = True
        Me.status_name.OptionsColumn.ReadOnly = True
        Me.status_name.Visible = True
        Me.status_name.VisibleIndex = 4
        Me.status_name.Width = 102
        '
        'shopping_discount_value
        '
        Me.shopping_discount_value.Caption = "shopping_discount_value"
        Me.shopping_discount_value.FieldName = "discount_text_fr"
        Me.shopping_discount_value.Name = "shopping_discount_value"
        Me.shopping_discount_value.OptionsColumn.AllowEdit = False
        Me.shopping_discount_value.OptionsColumn.FixedWidth = True
        Me.shopping_discount_value.OptionsColumn.ReadOnly = True
        Me.shopping_discount_value.Visible = True
        Me.shopping_discount_value.VisibleIndex = 8
        Me.shopping_discount_value.Width = 662
        '
        'tabCreditHist
        '
        Me.tabCreditHist.Controls.Add(Me.GridCreditHistory)
        Me.tabCreditHist.Name = "tabCreditHist"
        Me.tabCreditHist.Size = New System.Drawing.Size(1150, 917)
        Me.tabCreditHist.Text = "Credit history"
        '
        'GridCreditHistory
        '
        Me.GridCreditHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCreditHistory.EmbeddedNavigator.Name = ""
        Me.GridCreditHistory.FormsUseDefaultLookAndFeel = False
        Me.GridCreditHistory.Location = New System.Drawing.Point(0, 0)
        Me.GridCreditHistory.MainView = Me.GridViewCreditHistory
        Me.GridCreditHistory.Name = "GridCreditHistory"
        Me.GridCreditHistory.Size = New System.Drawing.Size(1150, 917)
        Me.GridCreditHistory.TabIndex = 1
        Me.GridCreditHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCreditHistory})
        '
        'GridViewCreditHistory
        '
        Me.GridViewCreditHistory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.id, Me.credit, Me.quantity_paid, Me.date_added, Me.action_name, Me.quantity_free, Me.credit_free, Me.Col3Orders_id})
        Me.GridViewCreditHistory.GridControl = Me.GridCreditHistory
        Me.GridViewCreditHistory.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewCreditHistory.Name = "GridViewCreditHistory"
        Me.GridViewCreditHistory.OptionsView.ColumnAutoWidth = False
        Me.GridViewCreditHistory.OptionsView.ShowFooter = True
        '
        'id
        '
        Me.id.Caption = "id"
        Me.id.FieldName = "id"
        Me.id.Name = "id"
        Me.id.OptionsColumn.AllowEdit = False
        Me.id.OptionsColumn.FixedWidth = True
        Me.id.OptionsColumn.ReadOnly = True
        '
        'credit
        '
        Me.credit.Caption = "credit"
        Me.credit.FieldName = "credit"
        Me.credit.Name = "credit"
        Me.credit.OptionsColumn.AllowEdit = False
        Me.credit.OptionsColumn.FixedWidth = True
        Me.credit.OptionsColumn.ReadOnly = True
        Me.credit.Visible = True
        Me.credit.VisibleIndex = 2
        Me.credit.Width = 76
        '
        'quantity_paid
        '
        Me.quantity_paid.Caption = "quantity_paid"
        Me.quantity_paid.FieldName = "quantity_paid"
        Me.quantity_paid.Name = "quantity_paid"
        Me.quantity_paid.OptionsColumn.AllowEdit = False
        Me.quantity_paid.OptionsColumn.FixedWidth = True
        Me.quantity_paid.OptionsColumn.ReadOnly = True
        Me.quantity_paid.Visible = True
        Me.quantity_paid.VisibleIndex = 3
        Me.quantity_paid.Width = 90
        '
        'date_added
        '
        Me.date_added.Caption = "date_added"
        Me.date_added.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.date_added.FieldName = "date_added"
        Me.date_added.Name = "date_added"
        Me.date_added.OptionsColumn.AllowEdit = False
        Me.date_added.OptionsColumn.FixedWidth = True
        Me.date_added.OptionsColumn.ReadOnly = True
        Me.date_added.Visible = True
        Me.date_added.VisibleIndex = 0
        Me.date_added.Width = 135
        '
        'action_name
        '
        Me.action_name.Caption = "action_name"
        Me.action_name.FieldName = "action_name"
        Me.action_name.Name = "action_name"
        Me.action_name.OptionsColumn.AllowEdit = False
        Me.action_name.OptionsColumn.FixedWidth = True
        Me.action_name.OptionsColumn.ReadOnly = True
        Me.action_name.Visible = True
        Me.action_name.VisibleIndex = 1
        Me.action_name.Width = 131
        '
        'quantity_free
        '
        Me.quantity_free.Caption = "quantity_free"
        Me.quantity_free.FieldName = "quantity_free"
        Me.quantity_free.Name = "quantity_free"
        Me.quantity_free.OptionsColumn.AllowEdit = False
        Me.quantity_free.OptionsColumn.FixedWidth = True
        Me.quantity_free.OptionsColumn.ReadOnly = True
        Me.quantity_free.Visible = True
        Me.quantity_free.VisibleIndex = 4
        Me.quantity_free.Width = 99
        '
        'credit_free
        '
        Me.credit_free.Caption = "credit_free"
        Me.credit_free.FieldName = "credit_free"
        Me.credit_free.Name = "credit_free"
        Me.credit_free.OptionsColumn.AllowEdit = False
        Me.credit_free.OptionsColumn.FixedWidth = True
        Me.credit_free.OptionsColumn.ReadOnly = True
        Me.credit_free.Visible = True
        Me.credit_free.VisibleIndex = 6
        Me.credit_free.Width = 96
        '
        'tabSponsorShip
        '
        Me.tabSponsorShip.AutoScroll = True
        Me.tabSponsorShip.Controls.Add(Me.GCCodeLinked)
        Me.tabSponsorShip.Controls.Add(Me.GrpSponsonCard)
        Me.tabSponsorShip.Controls.Add(Me.grpCustomersPoint)
        Me.tabSponsorShip.Controls.Add(Me.grpGift)
        Me.tabSponsorShip.Controls.Add(Me.grpSponsorShip)
        Me.tabSponsorShip.Name = "tabSponsorShip"
        Me.tabSponsorShip.Size = New System.Drawing.Size(1150, 917)
        Me.tabSponsorShip.Text = "Sponsorship"
        '
        'GCCodeLinked
        '
        Me.GCCodeLinked.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCCodeLinked.Controls.Add(Me.GridCodeLinked)
        Me.GCCodeLinked.Location = New System.Drawing.Point(855, 19)
        Me.GCCodeLinked.Name = "GCCodeLinked"
        Me.GCCodeLinked.Size = New System.Drawing.Size(289, 379)
        Me.GCCodeLinked.TabIndex = 16
        Me.GCCodeLinked.Text = "Association Code"
        '
        'GridCodeLinked
        '
        Me.GridCodeLinked.EmbeddedNavigator.Name = ""
        Me.GridCodeLinked.FormsUseDefaultLookAndFeel = False
        Me.GridCodeLinked.Location = New System.Drawing.Point(9, 23)
        Me.GridCodeLinked.MainView = Me.GridViewCodeLinked
        Me.GridCodeLinked.Name = "GridCodeLinked"
        Me.GridCodeLinked.Size = New System.Drawing.Size(280, 351)
        Me.GridCodeLinked.TabIndex = 16
        Me.GridCodeLinked.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCodeLinked})
        '
        'GridViewCodeLinked
        '
        Me.GridViewCodeLinked.GridControl = Me.GridCodeLinked
        Me.GridViewCodeLinked.Name = "GridViewCodeLinked"
        Me.GridViewCodeLinked.OptionsBehavior.Editable = False
        Me.GridViewCodeLinked.OptionsView.ShowFooter = True
        '
        'GrpSponsonCard
        '
        Me.GrpSponsonCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GrpSponsonCard.Controls.Add(Me.BtnSaveSponsorCard)
        Me.GrpSponsonCard.Controls.Add(Me.lblCard5)
        Me.GrpSponsonCard.Controls.Add(Me.txtCard5)
        Me.GrpSponsonCard.Controls.Add(Me.lblCard4)
        Me.GrpSponsonCard.Controls.Add(Me.txtCard4)
        Me.GrpSponsonCard.Controls.Add(Me.lblCard3)
        Me.GrpSponsonCard.Controls.Add(Me.txtCard3)
        Me.GrpSponsonCard.Controls.Add(Me.lblCard2)
        Me.GrpSponsonCard.Controls.Add(Me.txtCard2)
        Me.GrpSponsonCard.Controls.Add(Me.lblCard1)
        Me.GrpSponsonCard.Controls.Add(Me.txtCard1)
        Me.GrpSponsonCard.Location = New System.Drawing.Point(641, 19)
        Me.GrpSponsonCard.Name = "GrpSponsonCard"
        Me.GrpSponsonCard.Size = New System.Drawing.Size(208, 379)
        Me.GrpSponsonCard.TabIndex = 15
        Me.GrpSponsonCard.Text = "Sponsor Card"
        '
        'BtnSaveSponsorCard
        '
        Me.BtnSaveSponsorCard.Location = New System.Drawing.Point(50, 258)
        Me.BtnSaveSponsorCard.Name = "BtnSaveSponsorCard"
        Me.BtnSaveSponsorCard.Size = New System.Drawing.Size(97, 23)
        Me.BtnSaveSponsorCard.TabIndex = 12
        Me.BtnSaveSponsorCard.Text = "Save"
        '
        'lblCard5
        '
        Me.lblCard5.Location = New System.Drawing.Point(5, 214)
        Me.lblCard5.Name = "lblCard5"
        Me.lblCard5.Size = New System.Drawing.Size(32, 13)
        Me.lblCard5.TabIndex = 11
        Me.lblCard5.Text = "Card 5"
        '
        'txtCard5
        '
        Me.txtCard5.Location = New System.Drawing.Point(62, 211)
        Me.txtCard5.Name = "txtCard5"
        Me.txtCard5.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtCard5.Size = New System.Drawing.Size(142, 20)
        Me.txtCard5.TabIndex = 4
        '
        'lblCard4
        '
        Me.lblCard4.Location = New System.Drawing.Point(5, 167)
        Me.lblCard4.Name = "lblCard4"
        Me.lblCard4.Size = New System.Drawing.Size(32, 13)
        Me.lblCard4.TabIndex = 9
        Me.lblCard4.Text = "Card 4"
        '
        'txtCard4
        '
        Me.txtCard4.Location = New System.Drawing.Point(62, 164)
        Me.txtCard4.Name = "txtCard4"
        Me.txtCard4.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtCard4.Size = New System.Drawing.Size(142, 20)
        Me.txtCard4.TabIndex = 3
        '
        'lblCard3
        '
        Me.lblCard3.Location = New System.Drawing.Point(5, 116)
        Me.lblCard3.Name = "lblCard3"
        Me.lblCard3.Size = New System.Drawing.Size(32, 13)
        Me.lblCard3.TabIndex = 7
        Me.lblCard3.Text = "Card 3"
        '
        'txtCard3
        '
        Me.txtCard3.Location = New System.Drawing.Point(62, 113)
        Me.txtCard3.Name = "txtCard3"
        Me.txtCard3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtCard3.Size = New System.Drawing.Size(142, 20)
        Me.txtCard3.TabIndex = 2
        '
        'lblCard2
        '
        Me.lblCard2.Location = New System.Drawing.Point(5, 75)
        Me.lblCard2.Name = "lblCard2"
        Me.lblCard2.Size = New System.Drawing.Size(32, 13)
        Me.lblCard2.TabIndex = 5
        Me.lblCard2.Text = "Card 2"
        '
        'txtCard2
        '
        Me.txtCard2.Location = New System.Drawing.Point(62, 72)
        Me.txtCard2.Name = "txtCard2"
        Me.txtCard2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtCard2.Size = New System.Drawing.Size(142, 20)
        Me.txtCard2.TabIndex = 1
        '
        'lblCard1
        '
        Me.lblCard1.Location = New System.Drawing.Point(5, 36)
        Me.lblCard1.Name = "lblCard1"
        Me.lblCard1.Size = New System.Drawing.Size(32, 13)
        Me.lblCard1.TabIndex = 3
        Me.lblCard1.Text = "Card 1"
        '
        'txtCard1
        '
        Me.txtCard1.EnterMoveNextControl = True
        Me.txtCard1.Location = New System.Drawing.Point(62, 33)
        Me.txtCard1.Name = "txtCard1"
        Me.txtCard1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtCard1.Size = New System.Drawing.Size(142, 20)
        Me.txtCard1.TabIndex = 0
        '
        'grpCustomersPoint
        '
        Me.grpCustomersPoint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpCustomersPoint.Controls.Add(Me.GridCustPointHistory)
        Me.grpCustomersPoint.Location = New System.Drawing.Point(9, 668)
        Me.grpCustomersPoint.Name = "grpCustomersPoint"
        Me.grpCustomersPoint.Size = New System.Drawing.Size(1175, 212)
        Me.grpCustomersPoint.TabIndex = 14
        Me.grpCustomersPoint.Text = "Point History"
        '
        'GridCustPointHistory
        '
        Me.GridCustPointHistory.EmbeddedNavigator.Name = ""
        Me.GridCustPointHistory.FormsUseDefaultLookAndFeel = False
        Me.GridCustPointHistory.Location = New System.Drawing.Point(17, 44)
        Me.GridCustPointHistory.MainView = Me.GridViewCustPointHistory
        Me.GridCustPointHistory.Name = "GridCustPointHistory"
        Me.GridCustPointHistory.Size = New System.Drawing.Size(1130, 159)
        Me.GridCustPointHistory.TabIndex = 0
        Me.GridCustPointHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCustPointHistory})
        '
        'GridViewCustPointHistory
        '
        Me.GridViewCustPointHistory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col2date_added, Me.customers_points_history, Me.customers_points_history_action_name, Me.customers_points_history_sub_action_name})
        Me.GridViewCustPointHistory.CustomizationFormBounds = New System.Drawing.Rectangle(1022, 838, 208, 170)
        Me.GridViewCustPointHistory.GridControl = Me.GridCustPointHistory
        Me.GridViewCustPointHistory.Name = "GridViewCustPointHistory"
        Me.GridViewCustPointHistory.OptionsCustomization.AllowColumnResizing = False
        '
        'col2date_added
        '
        Me.col2date_added.Caption = "date_added"
        Me.col2date_added.FieldName = "date"
        Me.col2date_added.Name = "col2date_added"
        Me.col2date_added.OptionsColumn.AllowEdit = False
        Me.col2date_added.OptionsColumn.FixedWidth = True
        Me.col2date_added.OptionsColumn.ReadOnly = True
        Me.col2date_added.Visible = True
        Me.col2date_added.VisibleIndex = 0
        '
        'customers_points_history
        '
        Me.customers_points_history.Caption = "points"
        Me.customers_points_history.FieldName = "points"
        Me.customers_points_history.Name = "customers_points_history"
        Me.customers_points_history.OptionsColumn.AllowEdit = False
        Me.customers_points_history.OptionsColumn.FixedWidth = True
        Me.customers_points_history.OptionsColumn.ReadOnly = True
        Me.customers_points_history.Visible = True
        Me.customers_points_history.VisibleIndex = 1
        '
        'customers_points_history_action_name
        '
        Me.customers_points_history_action_name.Caption = "action_name"
        Me.customers_points_history_action_name.FieldName = "action_name"
        Me.customers_points_history_action_name.Name = "customers_points_history_action_name"
        Me.customers_points_history_action_name.OptionsColumn.AllowEdit = False
        Me.customers_points_history_action_name.OptionsColumn.FixedWidth = True
        Me.customers_points_history_action_name.OptionsColumn.ReadOnly = True
        Me.customers_points_history_action_name.Visible = True
        Me.customers_points_history_action_name.VisibleIndex = 2
        '
        'customers_points_history_sub_action_name
        '
        Me.customers_points_history_sub_action_name.Caption = "sub_action_name"
        Me.customers_points_history_sub_action_name.FieldName = "sub_action_name"
        Me.customers_points_history_sub_action_name.Name = "customers_points_history_sub_action_name"
        Me.customers_points_history_sub_action_name.OptionsColumn.AllowEdit = False
        Me.customers_points_history_sub_action_name.OptionsColumn.FixedWidth = True
        Me.customers_points_history_sub_action_name.OptionsColumn.ReadOnly = True
        Me.customers_points_history_sub_action_name.Visible = True
        Me.customers_points_history_sub_action_name.VisibleIndex = 3
        '
        'grpGift
        '
        Me.grpGift.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpGift.Controls.Add(Me.GridGift)
        Me.grpGift.Location = New System.Drawing.Point(9, 409)
        Me.grpGift.Name = "grpGift"
        Me.grpGift.Size = New System.Drawing.Size(1175, 253)
        Me.grpGift.TabIndex = 13
        Me.grpGift.Text = "Gift"
        '
        'GridGift
        '
        Me.GridGift.EmbeddedNavigator.Name = ""
        Me.GridGift.FormsUseDefaultLookAndFeel = False
        Me.GridGift.Location = New System.Drawing.Point(17, 44)
        Me.GridGift.MainView = Me.GridViewGift
        Me.GridGift.Name = "GridGift"
        Me.GridGift.Size = New System.Drawing.Size(1130, 195)
        Me.GridGift.TabIndex = 0
        Me.GridGift.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewGift})
        '
        'GridViewGift
        '
        Me.GridViewGift.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.date_attribution, Me.gift_sent, Me.points_customers, Me.gift_sent_date, Me.products_id_gift, Me.gift_name_fr, Me.gift_name_nl, Me.gift_name_en, Me.points_gift})
        Me.GridViewGift.CustomizationFormBounds = New System.Drawing.Rectangle(1022, 838, 208, 170)
        Me.GridViewGift.GridControl = Me.GridGift
        Me.GridViewGift.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewGift.Name = "GridViewGift"
        Me.GridViewGift.OptionsCustomization.AllowColumnResizing = False
        '
        'date_attribution
        '
        Me.date_attribution.Caption = "date_attribution"
        Me.date_attribution.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.date_attribution.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.date_attribution.FieldName = "date"
        Me.date_attribution.Name = "date_attribution"
        Me.date_attribution.OptionsColumn.AllowEdit = False
        Me.date_attribution.OptionsColumn.FixedWidth = True
        Me.date_attribution.OptionsColumn.ReadOnly = True
        Me.date_attribution.Visible = True
        Me.date_attribution.VisibleIndex = 0
        '
        'gift_sent
        '
        Me.gift_sent.Caption = "gift_sent"
        Me.gift_sent.FieldName = "gift_sent"
        Me.gift_sent.Name = "gift_sent"
        Me.gift_sent.OptionsColumn.AllowEdit = False
        Me.gift_sent.OptionsColumn.FixedWidth = True
        Me.gift_sent.OptionsColumn.ReadOnly = True
        Me.gift_sent.Visible = True
        Me.gift_sent.VisibleIndex = 1
        '
        'points_customers
        '
        Me.points_customers.Caption = "points_customers"
        Me.points_customers.FieldName = "customers_points"
        Me.points_customers.Name = "points_customers"
        Me.points_customers.OptionsColumn.AllowEdit = False
        Me.points_customers.OptionsColumn.FixedWidth = True
        Me.points_customers.OptionsColumn.ReadOnly = True
        Me.points_customers.Visible = True
        Me.points_customers.VisibleIndex = 2
        '
        'gift_sent_date
        '
        Me.gift_sent_date.Caption = "gift_sent_date"
        Me.gift_sent_date.FieldName = "gift_sent_date"
        Me.gift_sent_date.Name = "gift_sent_date"
        Me.gift_sent_date.OptionsColumn.AllowEdit = False
        Me.gift_sent_date.OptionsColumn.FixedWidth = True
        Me.gift_sent_date.OptionsColumn.ReadOnly = True
        Me.gift_sent_date.Visible = True
        Me.gift_sent_date.VisibleIndex = 3
        '
        'products_id_gift
        '
        Me.products_id_gift.Caption = "products_id_gift"
        Me.products_id_gift.FieldName = "products_id"
        Me.products_id_gift.Name = "products_id_gift"
        Me.products_id_gift.OptionsColumn.AllowEdit = False
        Me.products_id_gift.OptionsColumn.FixedWidth = True
        Me.products_id_gift.OptionsColumn.ReadOnly = True
        Me.products_id_gift.Visible = True
        Me.products_id_gift.VisibleIndex = 4
        '
        'gift_name_fr
        '
        Me.gift_name_fr.Caption = "gift_name_fr"
        Me.gift_name_fr.FieldName = "gift_name_fr"
        Me.gift_name_fr.Name = "gift_name_fr"
        Me.gift_name_fr.OptionsColumn.AllowEdit = False
        Me.gift_name_fr.OptionsColumn.FixedWidth = True
        Me.gift_name_fr.OptionsColumn.ReadOnly = True
        Me.gift_name_fr.Visible = True
        Me.gift_name_fr.VisibleIndex = 5
        '
        'gift_name_nl
        '
        Me.gift_name_nl.Caption = "gift_name_nl"
        Me.gift_name_nl.FieldName = "gift_name_nl"
        Me.gift_name_nl.Name = "gift_name_nl"
        Me.gift_name_nl.OptionsColumn.AllowEdit = False
        Me.gift_name_nl.OptionsColumn.FixedWidth = True
        Me.gift_name_nl.OptionsColumn.ReadOnly = True
        Me.gift_name_nl.Visible = True
        Me.gift_name_nl.VisibleIndex = 6
        '
        'gift_name_en
        '
        Me.gift_name_en.Caption = "gift_name_en"
        Me.gift_name_en.FieldName = "gift_name_en"
        Me.gift_name_en.Name = "gift_name_en"
        Me.gift_name_en.OptionsColumn.AllowEdit = False
        Me.gift_name_en.OptionsColumn.FixedWidth = True
        Me.gift_name_en.OptionsColumn.ReadOnly = True
        Me.gift_name_en.Visible = True
        Me.gift_name_en.VisibleIndex = 7
        '
        'points_gift
        '
        Me.points_gift.Caption = "points_gift"
        Me.points_gift.FieldName = "gift_points"
        Me.points_gift.Name = "points_gift"
        Me.points_gift.OptionsColumn.AllowEdit = False
        Me.points_gift.OptionsColumn.FixedWidth = True
        Me.points_gift.OptionsColumn.ReadOnly = True
        Me.points_gift.Visible = True
        Me.points_gift.VisibleIndex = 8
        '
        'grpSponsorShip
        '
        Me.grpSponsorShip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpSponsorShip.Controls.Add(Me.LabelControl33)
        Me.grpSponsorShip.Controls.Add(Me.LabelControl25)
        Me.grpSponsorShip.Controls.Add(Me.GridGodFather)
        Me.grpSponsorShip.Controls.Add(Me.GridSon)
        Me.grpSponsorShip.Location = New System.Drawing.Point(9, 19)
        Me.grpSponsorShip.Name = "grpSponsorShip"
        Me.grpSponsorShip.Size = New System.Drawing.Size(626, 384)
        Me.grpSponsorShip.TabIndex = 12
        Me.grpSponsorShip.Text = "Sponsorship"
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(5, 268)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl33.TabIndex = 18
        Me.LabelControl33.Text = "GodFather"
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(5, 23)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl25.TabIndex = 17
        Me.LabelControl25.Text = "Sons"
        '
        'GridGodFather
        '
        Me.GridGodFather.EmbeddedNavigator.Name = ""
        Me.GridGodFather.FormsUseDefaultLookAndFeel = False
        Me.GridGodFather.Location = New System.Drawing.Point(5, 279)
        Me.GridGodFather.MainView = Me.GridviewGodFather
        Me.GridGodFather.Name = "GridGodFather"
        Me.GridGodFather.Size = New System.Drawing.Size(610, 105)
        Me.GridGodFather.TabIndex = 12
        Me.GridGodFather.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridviewGodFather})
        '
        'GridviewGodFather
        '
        Me.GridviewGodFather.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldate_used, Me.father_id, Me.colfather_abo_type, Me.col2customers_lastname, Me.col2customers_firstname})
        Me.GridviewGodFather.GridControl = Me.GridGodFather
        Me.GridviewGodFather.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridviewGodFather.Name = "GridviewGodFather"
        '
        'coldate_used
        '
        Me.coldate_used.Caption = "date_used"
        Me.coldate_used.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.coldate_used.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldate_used.FieldName = "date"
        Me.coldate_used.Name = "coldate_used"
        Me.coldate_used.OptionsColumn.AllowEdit = False
        Me.coldate_used.Visible = True
        Me.coldate_used.VisibleIndex = 0
        '
        'father_id
        '
        Me.father_id.Caption = "father_id"
        Me.father_id.FieldName = "father_id"
        Me.father_id.Name = "father_id"
        Me.father_id.OptionsColumn.AllowEdit = False
        '
        'colfather_abo_type
        '
        Me.colfather_abo_type.Caption = "abo_type"
        Me.colfather_abo_type.FieldName = "father_abo_type"
        Me.colfather_abo_type.Name = "colfather_abo_type"
        Me.colfather_abo_type.OptionsColumn.AllowEdit = False
        Me.colfather_abo_type.Visible = True
        Me.colfather_abo_type.VisibleIndex = 3
        '
        'col2customers_lastname
        '
        Me.col2customers_lastname.Caption = "customers_lastname"
        Me.col2customers_lastname.FieldName = "customers_lastname"
        Me.col2customers_lastname.Name = "col2customers_lastname"
        Me.col2customers_lastname.OptionsColumn.AllowEdit = False
        Me.col2customers_lastname.Visible = True
        Me.col2customers_lastname.VisibleIndex = 1
        '
        'col2customers_firstname
        '
        Me.col2customers_firstname.Caption = "customers_firstname"
        Me.col2customers_firstname.FieldName = "customers_firstname"
        Me.col2customers_firstname.Name = "col2customers_firstname"
        Me.col2customers_firstname.OptionsColumn.AllowEdit = False
        Me.col2customers_firstname.Visible = True
        Me.col2customers_firstname.VisibleIndex = 2
        '
        'tabCompensation
        '
        Me.tabCompensation.Controls.Add(Me.GridCompensation)
        Me.tabCompensation.Name = "tabCompensation"
        Me.tabCompensation.Size = New System.Drawing.Size(1150, 917)
        Me.tabCompensation.Text = "Compensation"
        '
        'GridCompensation
        '
        Me.GridCompensation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCompensation.EmbeddedNavigator.Name = ""
        Me.GridCompensation.FormsUseDefaultLookAndFeel = False
        Me.GridCompensation.Location = New System.Drawing.Point(0, 0)
        Me.GridCompensation.MainView = Me.GridViewCompensation
        Me.GridCompensation.Name = "GridCompensation"
        Me.GridCompensation.Size = New System.Drawing.Size(1150, 917)
        Me.GridCompensation.TabIndex = 0
        Me.GridCompensation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCompensation})
        '
        'GridViewCompensation
        '
        Me.GridViewCompensation.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.compensation_date_given, Me.compensation_date_setback, Me.compensation_comment, Me.orders_id, Me.orders_id_given, Me.products_name_given, Me.colCompProducts_name})
        Me.GridViewCompensation.GridControl = Me.GridCompensation
        Me.GridViewCompensation.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewCompensation.Name = "GridViewCompensation"
        Me.GridViewCompensation.OptionsView.ColumnAutoWidth = False
        '
        'compensation_date_given
        '
        Me.compensation_date_given.Caption = "compensation_date_given"
        Me.compensation_date_given.FieldName = "compensation_date_given"
        Me.compensation_date_given.Name = "compensation_date_given"
        Me.compensation_date_given.OptionsColumn.AllowEdit = False
        Me.compensation_date_given.OptionsColumn.FixedWidth = True
        Me.compensation_date_given.OptionsColumn.ReadOnly = True
        Me.compensation_date_given.Visible = True
        Me.compensation_date_given.VisibleIndex = 3
        Me.compensation_date_given.Width = 150
        '
        'compensation_date_setback
        '
        Me.compensation_date_setback.Caption = "compensation_date_setback"
        Me.compensation_date_setback.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.compensation_date_setback.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.compensation_date_setback.FieldName = "compensation_date_setback"
        Me.compensation_date_setback.Name = "compensation_date_setback"
        Me.compensation_date_setback.OptionsColumn.AllowEdit = False
        Me.compensation_date_setback.OptionsColumn.FixedWidth = True
        Me.compensation_date_setback.OptionsColumn.ReadOnly = True
        Me.compensation_date_setback.Visible = True
        Me.compensation_date_setback.VisibleIndex = 0
        Me.compensation_date_setback.Width = 150
        '
        'compensation_comment
        '
        Me.compensation_comment.Caption = "compensation_comment"
        Me.compensation_comment.FieldName = "compensation_comment"
        Me.compensation_comment.Name = "compensation_comment"
        Me.compensation_comment.OptionsColumn.AllowEdit = False
        Me.compensation_comment.OptionsColumn.FixedWidth = True
        Me.compensation_comment.OptionsColumn.ReadOnly = True
        Me.compensation_comment.Visible = True
        Me.compensation_comment.VisibleIndex = 4
        Me.compensation_comment.Width = 150
        '
        'orders_id
        '
        Me.orders_id.Caption = "orders_id"
        Me.orders_id.FieldName = "orders_id"
        Me.orders_id.Name = "orders_id"
        Me.orders_id.OptionsColumn.AllowEdit = False
        Me.orders_id.OptionsColumn.FixedWidth = True
        Me.orders_id.OptionsColumn.ReadOnly = True
        Me.orders_id.Visible = True
        Me.orders_id.VisibleIndex = 5
        Me.orders_id.Width = 150
        '
        'orders_id_given
        '
        Me.orders_id_given.Caption = "orders_id_given"
        Me.orders_id_given.FieldName = "orders_id_given"
        Me.orders_id_given.Name = "orders_id_given"
        Me.orders_id_given.OptionsColumn.AllowEdit = False
        Me.orders_id_given.OptionsColumn.FixedWidth = True
        Me.orders_id_given.OptionsColumn.ReadOnly = True
        Me.orders_id_given.Visible = True
        Me.orders_id_given.VisibleIndex = 1
        Me.orders_id_given.Width = 110
        '
        'products_name_given
        '
        Me.products_name_given.Caption = "products_name_given"
        Me.products_name_given.FieldName = "products_name_given"
        Me.products_name_given.Name = "products_name_given"
        Me.products_name_given.OptionsColumn.AllowEdit = False
        Me.products_name_given.OptionsColumn.FixedWidth = True
        Me.products_name_given.OptionsColumn.ReadOnly = True
        Me.products_name_given.Visible = True
        Me.products_name_given.VisibleIndex = 2
        Me.products_name_given.Width = 300
        '
        'colCompProducts_name
        '
        Me.colCompProducts_name.Caption = "products_name"
        Me.colCompProducts_name.FieldName = "products_name"
        Me.colCompProducts_name.Name = "colCompProducts_name"
        Me.colCompProducts_name.OptionsColumn.AllowEdit = False
        Me.colCompProducts_name.OptionsColumn.FixedWidth = True
        Me.colCompProducts_name.OptionsColumn.ReadOnly = True
        Me.colCompProducts_name.Visible = True
        Me.colCompProducts_name.VisibleIndex = 6
        Me.colCompProducts_name.Width = 300
        '
        'tabProductsRating
        '
        Me.tabProductsRating.Controls.Add(Me.GridProductsRating)
        Me.tabProductsRating.Name = "tabProductsRating"
        Me.tabProductsRating.Size = New System.Drawing.Size(1150, 917)
        Me.tabProductsRating.Text = "Products rating"
        '
        'GridProductsRating
        '
        Me.GridProductsRating.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridProductsRating.EmbeddedNavigator.Name = ""
        Me.GridProductsRating.FormsUseDefaultLookAndFeel = False
        Me.GridProductsRating.Location = New System.Drawing.Point(0, 0)
        Me.GridProductsRating.MainView = Me.GridViewProductsRating
        Me.GridProductsRating.Name = "GridProductsRating"
        Me.GridProductsRating.Size = New System.Drawing.Size(1150, 917)
        Me.GridProductsRating.TabIndex = 2
        Me.GridProductsRating.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewProductsRating})
        '
        'GridViewProductsRating
        '
        Me.GridViewProductsRating.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.products, Me.products_rating, Me.products_rating_date, Me.rating_type, Me.colRatingProducts_name})
        Me.GridViewProductsRating.GridControl = Me.GridProductsRating
        Me.GridViewProductsRating.GroupCount = 1
        Me.GridViewProductsRating.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewProductsRating.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "products_rating", Nothing, "")})
        Me.GridViewProductsRating.Name = "GridViewProductsRating"
        Me.GridViewProductsRating.OptionsView.ColumnAutoWidth = False
        Me.GridViewProductsRating.OptionsView.ShowFooter = True
        Me.GridViewProductsRating.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.rating_type, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'products
        '
        Me.products.Caption = "products_id"
        Me.products.FieldName = "products_id"
        Me.products.Name = "products"
        Me.products.OptionsColumn.AllowEdit = False
        Me.products.OptionsColumn.ReadOnly = True
        Me.products.Visible = True
        Me.products.VisibleIndex = 0
        Me.products.Width = 92
        '
        'products_rating
        '
        Me.products_rating.Caption = "products_rating"
        Me.products_rating.FieldName = "products_rating"
        Me.products_rating.Name = "products_rating"
        Me.products_rating.OptionsColumn.AllowEdit = False
        Me.products_rating.OptionsColumn.ReadOnly = True
        Me.products_rating.Visible = True
        Me.products_rating.VisibleIndex = 2
        Me.products_rating.Width = 129
        '
        'products_rating_date
        '
        Me.products_rating_date.Caption = "products_rating_date"
        Me.products_rating_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.products_rating_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.products_rating_date.FieldName = "products_rating_date"
        Me.products_rating_date.Name = "products_rating_date"
        Me.products_rating_date.OptionsColumn.AllowEdit = False
        Me.products_rating_date.OptionsColumn.ReadOnly = True
        Me.products_rating_date.Visible = True
        Me.products_rating_date.VisibleIndex = 1
        Me.products_rating_date.Width = 162
        '
        'rating_type
        '
        Me.rating_type.Caption = "rating_type"
        Me.rating_type.FieldName = "rating_type"
        Me.rating_type.Name = "rating_type"
        Me.rating_type.OptionsColumn.AllowEdit = False
        Me.rating_type.OptionsColumn.ReadOnly = True
        Me.rating_type.Visible = True
        Me.rating_type.VisibleIndex = 3
        Me.rating_type.Width = 196
        '
        'colRatingProducts_name
        '
        Me.colRatingProducts_name.Caption = "products_name"
        Me.colRatingProducts_name.FieldName = "products_name"
        Me.colRatingProducts_name.Name = "colRatingProducts_name"
        Me.colRatingProducts_name.OptionsColumn.AllowEdit = False
        Me.colRatingProducts_name.OptionsColumn.ReadOnly = True
        Me.colRatingProducts_name.Visible = True
        Me.colRatingProducts_name.VisibleIndex = 3
        Me.colRatingProducts_name.Width = 249
        '
        'tabSuspendedHistory
        '
        Me.tabSuspendedHistory.Controls.Add(Me.GridSuspendedHistory)
        Me.tabSuspendedHistory.Name = "tabSuspendedHistory"
        Me.tabSuspendedHistory.Size = New System.Drawing.Size(1150, 917)
        Me.tabSuspendedHistory.Text = "Suspended History"
        '
        'GridSuspendedHistory
        '
        Me.GridSuspendedHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSuspendedHistory.EmbeddedNavigator.Name = ""
        Me.GridSuspendedHistory.FormsUseDefaultLookAndFeel = False
        Me.GridSuspendedHistory.Location = New System.Drawing.Point(0, 0)
        Me.GridSuspendedHistory.MainView = Me.GridViewSuspendedHistory
        Me.GridSuspendedHistory.Name = "GridSuspendedHistory"
        Me.GridSuspendedHistory.Size = New System.Drawing.Size(1150, 917)
        Me.GridSuspendedHistory.TabIndex = 1
        Me.GridSuspendedHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSuspendedHistory})
        '
        'GridViewSuspendedHistory
        '
        Me.GridViewSuspendedHistory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.suspended_history_date, Me.suspended_history_date_end, Me.abosuspended_history_type})
        Me.GridViewSuspendedHistory.GridControl = Me.GridSuspendedHistory
        Me.GridViewSuspendedHistory.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewSuspendedHistory.Name = "GridViewSuspendedHistory"
        Me.GridViewSuspendedHistory.OptionsView.ColumnAutoWidth = False
        Me.GridViewSuspendedHistory.OptionsView.ShowFooter = True
        '
        'suspended_history_date
        '
        Me.suspended_history_date.Caption = "date_added"
        Me.suspended_history_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.suspended_history_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.suspended_history_date.FieldName = "date_added"
        Me.suspended_history_date.Name = "suspended_history_date"
        Me.suspended_history_date.OptionsColumn.AllowEdit = False
        Me.suspended_history_date.OptionsColumn.FixedWidth = True
        Me.suspended_history_date.OptionsColumn.ReadOnly = True
        Me.suspended_history_date.Visible = True
        Me.suspended_history_date.VisibleIndex = 0
        Me.suspended_history_date.Width = 150
        '
        'suspended_history_date_end
        '
        Me.suspended_history_date_end.Caption = "date_end"
        Me.suspended_history_date_end.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.suspended_history_date_end.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.suspended_history_date_end.FieldName = "date_end"
        Me.suspended_history_date_end.Name = "suspended_history_date_end"
        Me.suspended_history_date_end.OptionsColumn.AllowEdit = False
        Me.suspended_history_date_end.OptionsColumn.FixedWidth = True
        Me.suspended_history_date_end.OptionsColumn.ReadOnly = True
        Me.suspended_history_date_end.Visible = True
        Me.suspended_history_date_end.VisibleIndex = 1
        Me.suspended_history_date_end.Width = 150
        '
        'abosuspended_history_type
        '
        Me.abosuspended_history_type.Caption = "status"
        Me.abosuspended_history_type.FieldName = "status"
        Me.abosuspended_history_type.Name = "abosuspended_history_type"
        Me.abosuspended_history_type.OptionsColumn.AllowEdit = False
        Me.abosuspended_history_type.OptionsColumn.FixedWidth = True
        Me.abosuspended_history_type.OptionsColumn.ReadOnly = True
        Me.abosuspended_history_type.Visible = True
        Me.abosuspended_history_type.VisibleIndex = 2
        Me.abosuspended_history_type.Width = 161
        '
        'frmCustomers_Maint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1159, 1005)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmCustomers_Maint"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(txtNextCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(txtNextPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewGodson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMailHistory.ResumeLayout(False)
        CType(Me.grpContEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAboProcess.ResumeLayout(False)
        CType(Me.GridAboprocessStats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewAboprocessStats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCustServ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewCustServ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCustServ_cat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDroselia.ResumeLayout(False)
        Me.tabDroselia.PerformLayout()
        CType(Me.txtDroselia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDroselia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDroselia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPaymentMovements.ResumeLayout(False)
        CType(Me.GCBankAccountMovement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCBankAccountMovement.ResumeLayout(False)
        CType(Me.GridBankAccountMovement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVBankAccountMovement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridABO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewABO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbABO_Action, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPayment.ResumeLayout(False)
        Me.tabPayment.PerformLayout()
        CType(Me.GridPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkOpenPayment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupOgone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupOgone.ResumeLayout(False)
        CType(Me.PanelOgone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelOgone.ResumeLayout(False)
        Me.PanelOgone.PerformLayout()
        CType(Me.txt_cc_expiration_date2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_cc_expiration_status2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cc_card_type2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cc_card_no2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cc_owner2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupDomiciliation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDomiciliation.ResumeLayout(False)
        CType(Me.panelDomiciliation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDomiciliation.ResumeLayout(False)
        Me.panelDomiciliation.PerformLayout()
        CType(Me.txtDomAcctNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDomNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDomDebiterName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDomStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalcEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPayMethod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridWishList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewWishList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSendIt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkAvailibility, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCRM.ResumeLayout(False)
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        CType(Me.LayoutCustServ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutCustServ.ResumeLayout(False)
        CType(Me.txtCustServ_Response_Message.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustServ_DVD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustServ_Products_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustServ_OrderID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustServ_CustDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustServ_CustDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustServ_Subject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.chkCustServSendMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridWishListAssigned, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewWishListAssigned, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOrdersHistor.ResumeLayout(False)
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.GridOrdersHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewOrdersHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAboHistory.ResumeLayout(False)
        Me.tabWishList.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl11.ResumeLayout(False)
        CType(Me.PanelPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.tabMain.PerformLayout()
        CType(Me.GroupControlACtPhone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControlACtPhone.ResumeLayout(False)
        Me.GroupControlACtPhone.PerformLayout()
        CType(Me.MemoOtherReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPhoneActivDelete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateCallPhoneActivation.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateCallPhoneActivation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.DateEndOfHoliday.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEndOfHoliday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSuspended.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegistrationStep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVDAdultAtHome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscValidity.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscValidity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAutoStop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivationDiscountCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNextDiscCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMultiShipment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNextABO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVDNormAtHome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVDAdult.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVDNorm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtABOCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbo_ValidityTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbo_ValidityTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbABO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GridAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDeliverycountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryPostCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryAddr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtPtSponsorShip.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRedListed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBlackListed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYearsOld.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNewsLetterPartner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNewsLetter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWishListKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNbrOfLogons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbEntity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateCreated.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateCreated.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelEvening.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtABO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomers_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSearch.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.TxtCustomers_NumComm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_domiciliation_number_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_postcode_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_address_street_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_email_address_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_name_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_id_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabComment.ResumeLayout(False)
        CType(Me.MemoCustomersComment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCustComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCustComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoInsertComment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPurchase.ResumeLayout(False)
        CType(Me.GridShoppingOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewShoppingOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCreditHist.ResumeLayout(False)
        CType(Me.GridCreditHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCreditHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSponsorShip.ResumeLayout(False)
        CType(Me.GCCodeLinked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCCodeLinked.ResumeLayout(False)
        CType(Me.GridCodeLinked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCodeLinked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrpSponsonCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSponsonCard.ResumeLayout(False)
        Me.GrpSponsonCard.PerformLayout()
        CType(Me.txtCard5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCard4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCard3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCard2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCard1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpCustomersPoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCustomersPoint.ResumeLayout(False)
        CType(Me.GridCustPointHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCustPointHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpGift, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGift.ResumeLayout(False)
        CType(Me.GridGift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewGift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSponsorShip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSponsorShip.ResumeLayout(False)
        Me.grpSponsorShip.PerformLayout()
        CType(Me.GridGodFather, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridviewGodFather, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCompensation.ResumeLayout(False)
        CType(Me.GridCompensation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCompensation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProductsRating.ResumeLayout(False)
        CType(Me.GridProductsRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewProductsRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSuspendedHistory.ResumeLayout(False)
        CType(Me.GridSuspendedHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSuspendedHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sSQL As String

    Private ReadOnly Property lang_id() As Integer
        Get
            Return cmbLanguage.EditValue
        End Get

    End Property
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()

    End Sub
    ' Dim KeyDataSet As String = "BizzLib.dsGeneral" 'The Dataset used 
    Public _CurrentCustomerID As Integer
    Dim MainData As ClsCustomersInfo.clsCustomer
    Public boolReactivation As Boolean = False
    Dim boolLoadingCustomerInfo As Boolean = False
    Dim _dataSet As New DataSet()
    Dim _refreshData_wishlist As Boolean
    Dim _refreshData_paymentOffline As Boolean
    Dim _refreshData_payment As Boolean
    Dim _refreshData_paymentmovement As Boolean
    Dim _refreshData_bankTransfer As Boolean
    Dim _refreshData_accountInfo As Boolean
    Dim _refreshData_orders As Boolean
    Dim _refreshData_aboHist As Boolean
    Dim _refreshData_Sponsorship As Boolean
    Dim _refreshdata_aboprocess As Boolean
    Dim _refreshdata_emailHistory As Boolean
    Dim _refreshdata_purchase As Boolean
    Dim _refreshdata_creditHistory As Boolean
    Dim _refreshdata_custServ As Boolean
    Dim _refreshdata_compensation As Boolean
    Dim _refreshdata_customersComment As Boolean
    Dim _refresh_productsRating As Boolean
    Dim _refresh_suspendedHistory As Boolean
    Dim _refresh_droselia As Boolean
    Dim _oldCredit As Integer
    Dim _newCredit As Integer
    Dim _oldMgm As Integer
    Dim _newMgm As Integer
    Dim _old_date_Holiday As Date
    Dim _oldSuspended As Integer
    Private _lstSuspended As New List(Of DVDPostBuziness.clsKeyCombo)


    Public Sub Local_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim menuStrip As New DVDPostBuziness.contextMenu()

        'MemoInsertComment.Properties.WordWrap

        GridControl1.ContextMenuStrip = menuStrip
        GridAddress.ContextMenuStrip = menuStrip
        GridWishList.ContextMenuStrip = menuStrip
        GridWishListAssigned.ContextMenuStrip = menuStrip
        GridCustComment.ContextMenuStrip = menuStrip
        GridABO.ContextMenuStrip = menuStrip
        GridOrders.ContextMenuStrip = menuStrip
        GridOrdersHistory.ContextMenuStrip = menuStrip
        GridCustServ.ContextMenuStrip = menuStrip
        GridPayment.ContextMenuStrip = menuStrip
        GridBankAccountMovement.ContextMenuStrip = menuStrip
        GridAboprocessStats.ContextMenuStrip = menuStrip
        grpContEmail.ContextMenuStrip = menuStrip
        GridShoppingOrders.ContextMenuStrip = menuStrip
        GridCreditHistory.ContextMenuStrip = menuStrip
        GridSon.ContextMenuStrip = menuStrip
        GridGodFather.ContextMenuStrip = menuStrip
        GridGift.ContextMenuStrip = menuStrip
        GridCustPointHistory.ContextMenuStrip = menuStrip
        GridCompensation.ContextMenuStrip = menuStrip
        GridProductsRating.ContextMenuStrip = menuStrip
        GridSuspendedHistory.ContextMenuStrip = menuStrip
        GridDroselia.ContextMenuStrip = menuStrip





        Me._dataSet.Tables.Add("reason_to_stop") ' for stop the abo with the button "stop abo"

        Me.lblAboSumP.Visible = False
        GroupControlACtPhone.Visible = False


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
   
            XtraTabControl1.SelectedTabPage = tabSearch
            btnForcedReconduction.Visible = DvdPostData.clsSession.isAdmin


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
        _oldCredit = txtABOCredit.EditValue
        _newCredit = txtABOCredit.EditValue
        _oldMgm = txtPtSponsorShip.EditValue
        _newMgm = txtPtSponsorShip.EditValue
        _oldSuspended = cmbSuspended.EditValue
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
        LoadCustomerInfo()
        OpenType = "BROWSE"
        boolReactivation = False
    End Sub
    Private Sub SaveChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuSave.Click, MyBase.EventSaveChanges

        Try
            'Validate Fields and assign any Necessary ID
            MainData.ValidateRecordFields(CType(Me.BindingContext(objDS, TableName).Current, DataRowView))
            'Attempt to update the datasource.
            If boolReactivation = True Then
                cmbABO.Enabled = False
                cmbNextABO.EditValue = cmbABO.EditValue
                txtRegistrationStep.EditValue = 100
                txtAbo_ValidityTo.DateTime = Now()
                txtDVDAdult.EditValue = 0
                txtDVDNorm.EditValue = BKGlobal.ExecuteFindFieldValueINT("qty_at_home", "SELECT qty_at_home FROM products_abo where products_id = " & cmbABO.EditValue)
                txtABO.EditValue = 1
                Dim sql As String = ""
                sql = "insert into abo (Customerid , Action, Date  , product_id, comment) "
                sql = sql & "select customers_id, " & AboAction.ACTION_MANUAL_CREATION & ", now(), customers_abo_type, 'Manual Re-Activation by " & SessionInfo.UserFullName & "'"
                sql = sql & " from customers where "
                sql = sql & " customers_id = " & txtCustomers_id.EditValue
                Dim _Result As Integer = DvdPostData.clsConnection.ExecuteNonQuery(sql)
                boolReactivation = False
            Else

            End If
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
    End Sub
    Public Sub UpdateDataSet() Handles MyBase.EventUpdateDataset

        
        _newMgm = txtPtSponsorShip.EditValue
        If _newMgm <> _oldMgm Then
            DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.clsMemberGetMember.insertCustomersPointHist(_CurrentCustomerID, DvdPostData.clsMemberGetMember.PointsHistoryAction.ADD, DvdPostData.clsMemberGetMember.PointsHistorySubAction.POINT_MANUAL_ALLOCATION, calculCredit(_oldMgm, _newMgm)))
            _refreshData_Sponsorship = True
        End If


        'Stop any current edits. bug replace value lastname in value abo 
        '   objDS.Tables(TableName).AcceptChanges()
        Me.BindingContext(objDS, TableName).EndCurrentEdit()
        Me.BindingContext(objDS, "address_book_default").EndCurrentEdit()
        MainData.Save()


     

        _newCredit = txtABOCredit.EditValue 'by gauthier
        If _oldCredit <> _newCredit Then
            addCreditToCustomers(calculCredit(_oldCredit, _newCredit), _CurrentCustomerID, DvdPostData.clsCreditHistory.ActionId.MANUAL_CREDIT, _oldCredit)
        End If

        suspended()



        updateInsertPhoneActivation(False)


        refreshClient()
    End Sub




    Public Sub LoadBKComboSet()
        Try
            BKCombo.GetCombo(objDS, "country", "countries_name", "SELECT * FROM country")
            BKCombo.GetCombo(objDS, "products_abo", "products_id", "SELECT products_id, products_model, products_title FROM products where products_type = 'ABO' ")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("abo_action"), "SELECT * FROM abo_action")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("orders_status"), "SELECT * FROM orders_status WHERE language_id = 1 ")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("orders_products_status"), "SELECT * FROM orders_products_status")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("discount_code"), "SELECT * FROM discount_code")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("languages"), "SELECT * FROM languages")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("generalentity"), "SELECT EntityID, name, description, currcode FROM generalentity")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("customers_abo_payment_method"), "SELECT * FROM customers_abo_payment_method c")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("domiciliation_status"), "SELECT * FROM domiciliation_status  where language_id = 1")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("payment_status"), "SELECT * FROM payment_status ")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("ogone_payment_status"), "SELECT * FROM ogone_payment_status ")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("cc_expiration_status"), "SELECT * FROM cc_expiration_status  where language_id = 1 ")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("custserv_cat"), "SELECT * FROM custserv_cat  where language_id = 1 ")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("payment_offline_status"), "SELECT * FROM payment_offline_status ")
            LoadSuspended()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#Region "Search"
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Search()
    End Sub
    Public Sub Search()
        Dim sql As String

        Dim customers_id As String
        Dim email As String
        Dim NameCustomer As String
        Dim streetCustomer As String
        Dim PostCodeCustomer As String
        Dim NumDom As String
        Dim NumComm As String

        Dim param As DVDPostBuziness.clsSingleton
        param = DVDPostBuziness.clsSingleton.Instance()

        If param.CustomersId <> Nothing Then
            customers_id = param.CustomersId
            param.CustomersId = Nothing
        Else
            customers_id = txtcustomers_id_search.Text.Trim
        End If


        email = txtcustomers_email_address_search.Text.Trim
        NameCustomer = txtcustomers_name_search.Text.Trim
        NumDom = txtcustomers_domiciliation_number_search.Text.Trim
        streetCustomer = txtcustomers_address_street_search.Text.Trim
        PostCodeCustomer = txtcustomers_postcode_search.Text.Trim
        NumComm = TxtCustomers_NumComm.Text.Trim
        sql = DvdPostData.ClsCustomersData.GetSelectCustomersSearch(customers_id, email, NameCustomer, streetCustomer, PostCodeCustomer, NumDom, NumComm)

        Dim dt As DataTable
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt
    End Sub
    Public Sub searchPhoneAct()
        ' Dim sqlPA As String = "SELECT distinct c.customers_id, c.customers_firstname, c.customers_lastname, c.customers_email_address, c.customers_abo,c.customers_abo_payment_method,c.customers_language," & _
        '" c.black_listed, ab.entry_street_address, ab.entry_postcode, c.domiciliation_number " & _
        '" FROM customers c,address_book ab" & _
        '" where( c.customers_registration_step = 100 and c.customers_abo = 0 and  c.customers_default_address_id = ab.address_book_id And c.customers_id = ab.customers_id And c.customers_abo_payment_method = 20) "

        ' objDS.Tables("customers_search_result").Clear()
        ' DvdPostData.clsConnection.FillDataSet(objDS.Tables("customers_search_result"), sqlPA)


        ' Dim row As DataRow



        ' For Each row In objDS.Tables("customers_search_result").Rows

        '     Dim custid As Integer
        '     custid = row.Item("customers_id")
        '     Dim _dsHistPhone As New DataSet
        '     Dim existcust As Boolean = exist(custid)
        '     _dsHistPhone.Tables.Add("hist_Phone_acti")
        '     If existcust Then
        '         DvdPostData.clsConnection.FillDataSet(_dsHistPhone.Tables("hist_Phone_acti"), "select * from historique_phone_activation where customers_id = '" & custid.ToString & "' ")
        '         row.Item("call_phone") = _dsHistPhone.Tables("hist_Phone_acti").Rows(0).Item("call_phone").ToString
        '     End If
        ' Next
        ' GridControl1.DataSource = objDS.Tables("customers_search_result")

        Dim dt As DataTable
        Dim sql As String

        sql = DvdPostData.clsPhoneActivation.GetPhoneActivation()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt

    End Sub
    Private Sub btnPhoneActivation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhoneActivation.Click
        searchPhoneAct()
        reasonStopActPhone()
    End Sub

    Private Sub txtcustomers_id_search_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustomers_id_search.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Search()
        End If
    End Sub
    Private Sub txtcustomers_name_search_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustomers_name_search.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Search()
        End If
    End Sub
    Private Sub txtcustomers_email_address_search_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustomers_email_address_search.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Search()
        End If
    End Sub
    Private Sub txtcustomers_domiciliation_number_search_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Search()
        End If
    End Sub

    Private Sub txtcustomers_address_street_search_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustomers_address_street_search.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Search()
        End If
    End Sub

    Private Sub txtcustomers_postcode_search_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustomers_postcode_search.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Search()
        End If
    End Sub
    Public Sub refreshClient()
        _refreshData_wishlist = True
        _refreshData_paymentmovement = True
        _refreshData_paymentOffline = True
        _refreshData_bankTransfer = True
        _refreshData_accountInfo = True
        _refreshData_orders = True
        _refreshData_aboHist = True
        _refreshData_payment = True
        _refreshData_Sponsorship = True
        _refreshdata_aboprocess = True
        _refreshdata_emailHistory = True
        _refreshdata_purchase = True
        _refreshdata_creditHistory = True
        _refreshdata_custServ = True
        _refreshdata_compensation = True
        _refreshdata_customersComment = True
        _refresh_productsRating = True
        _refresh_suspendedHistory = True
        _refresh_droselia = True

        LoadCustomerInfo()

    End Sub

    Private Sub GridViewSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        _CurrentCustomerID = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle)("customers_id")
        refreshClient()

        XtraTabControl1.SelectedTabPage = tabMain
    End Sub
#End Region
    Private Sub loadPayment(ByVal customers_id As Integer)
        Dim sql As String
        If _refreshData_payment Then
            Try

                Dim dt As DataTable

                sql = DvdPostData.ClsMatching.GetDataPaymentAllTypePayments(customers_id, checkOpenPayment.Checked)
                dt = DvdPostData.clsConnection.FillDataSet(sql)
                GridPayment.DataSource = dt
            Catch ex As Exception
                MsgBox("Num client is not valid")
            End Try
            _refreshData_payment = False
        End If
    End Sub

    Private Sub loadBankAccountMovement(ByVal customers_id As Integer)
        Dim sql As String
        Dim dt As DataTable
        If _refreshData_paymentmovement Then
            sql = DvdPostData.ClsMatching.GetMatchingByall(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)

            GridBankAccountMovement.DataSource = dt
            _refreshData_paymentmovement = False
        End If

    End Sub

    Private Sub loadwishlist(ByVal customers_id As Integer, ByVal lang_id As Integer)

        If _refreshData_wishlist Then

            Dim sql As String
            Dim dt As DataTable
            sql = DvdPostData.ClsCustomersData.GetSelectWishlist(customers_id, lang_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            GridWishList.DataSource = dt
            GridViewWishList.BestFitColumns()
            GridViewWishList.ExpandAllGroups()

            sql = DvdPostData.ClsCustomersData.GetSelectWishlistAssigned(customers_id, lang_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            GridWishListAssigned.DataSource = dt

            GridViewWishListAssigned.BestFitColumns()
            GridViewWishListAssigned.ExpandAllGroups()
            _refreshData_wishlist = False
        End If
    End Sub

    Private Sub loadOrders(ByVal customers_id As Integer)
        If _refreshData_orders Then

            Dim dt As New DataTable
            Dim sql As String = DvdPostData.clsOdersStatusHistory.GetOrdersByCustomers(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            GridOrders.DataSource = dt
            GridViewOrders.BestFitColumns()
            GridViewOrders.ExpandAllGroups()


            _refreshData_orders = False
        End If

    End Sub

    Private Sub loadOrderHistory(ByVal oders_id As Integer)
        Dim dt As New DataTable
        Dim sql As String = DvdPostData.clsOdersStatusHistory.GetOrderHistory(oders_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridOrdersHistory.DataSource = dt
    End Sub

    Public Sub GridViewOders_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewOrders.FocusedRowChanged
        If GridViewOrders.RowCount <> 0 Then
            Dim oders_id As Integer = GridViewOrders.GetDataRow(GridViewOrders.FocusedRowHandle)("orders_id")
            loadOrderHistory(oders_id)
        Else
            GridOrdersHistory.DataSource = Nothing
        End If
    End Sub

    Private Sub LoadSuspended()

        _lstSuspended.Add(New DVDPostBuziness.clsKeyCombo("HOLIDAY", 1))
        _lstSuspended.Add(New DVDPostBuziness.clsKeyCombo("SUSPENDED", 2))
        _lstSuspended.Add(New DVDPostBuziness.clsKeyCombo("", 0))
        Me.cmbSuspended.Properties.DataSource = _lstSuspended
        cmbSuspended.Enabled = False

    End Sub

    Private Sub loadAboHist(ByVal customers_id As Integer)

        If _refreshData_aboHist Then
            Dim mvarAbo As ClsCustomersInfo.clsCustomerABO
            mvarAbo = New ClsCustomersInfo.clsCustomerABO(SessionInfo, objDS, customers_id)
            _refreshData_aboHist = False
        End If
    End Sub
    Public Sub LoadCustomerInfo()



        objDS.Tables("customers").Clear()
        MainData = New ClsCustomersInfo.clsCustomer(SessionInfo, objDS, _CurrentCustomerID)

        Dim _ds As New DataSet()
        Dim _row As DataRow
        If objDS.Tables("customers").Rows.Count = 0 Then
            MsgBox("Ce client n'existe pas", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If objDS.Tables("customers").Rows(0)("activation_discount_code_type") = "A" Then 'Activation
            txtActivationDiscountCode.EditValue = objDS.Tables("customers").Rows(0)("activation_discount_code_id")
        ElseIf objDS.Tables("customers").Rows(0)("activation_discount_code_type") = "D" Then 'Discount
            _row = objDS.Tables("discount_code").Rows.Find(New Object() {objDS.Tables("customers").Rows(0)("activation_discount_code_id")})
            If Not IsNothing(_row) Then
                txtActivationDiscountCode.EditValue = _row("discount_code")
            Else
                txtActivationDiscountCode.EditValue = Nothing
            End If
        Else
            txtActivationDiscountCode.EditValue = objDS.Tables("customers").Rows(0)("activation_discount_code_id")
        End If

        'loadDroselia(_CurrentCustomerID)

        'do visible txt summer power abo 12 mois
        Me.displayLblSummer(_CurrentCustomerID)
        Dim credit As Integer
        Dim price As String = ""
        Dim clscustomers As New DVDPostBuziness.ClsCustomers
        clscustomers.GetInfoNextReconduction(_CurrentCustomerID, credit, price)
        txtNextCredit.EditValue = credit
        txtNextPrice.EditValue = price
        'visble group control phone activation
        VisiblePhoneActivation(_CurrentCustomerID)

        If txtABO.Checked Then
            txtABO.BackColor = Drawing.Color.GreenYellow
        Else
            txtABO.BackColor = Drawing.Color.Red
        End If

        If cmbSuspended.EditValue = 1 Then
            cmbSuspended.BackColor = Drawing.Color.LightBlue
            cmbSuspended.ForeColor = Drawing.Color.White
        ElseIf cmbSuspended.EditValue = 2 Then
            cmbSuspended.BackColor = Drawing.Color.Red
            cmbSuspended.ForeColor = Drawing.Color.White
        Else
            cmbSuspended.BackColor = Nothing
        End If

        'calcul the Age
        If objDS.Tables("customers").Rows(0)("customers_dob") IsNot (DBNull.Value) Then
            txtYearsOld.Text = calculAge(DateEdit1.EditValue)
        End If

        'to suspend holiday
        DateEndOfHoliday.EditValue = DvdPostData.clsConnection.ExecuteScalar(DvdPostData.clsAboSuspended.GetDateEndHoliday(_CurrentCustomerID))
        _old_date_Holiday = DateEndOfHoliday.EditValue


        ' change backcolor for chkAutoStop
        CheckboxColor()

        'display addressbook
        loadAddressBook(_CurrentCustomerID)


    End Sub
    Private Sub EnablingEditFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingEditFields
        txtLastName.Enabled = Enabling
        txtFirstName.Enabled = Enabling
        txtEMail.Enabled = Enabling
        txtTel.Enabled = Enabling
        txtTelEvening.Enabled = Enabling

        'txtDeliveryFirstName.Enabled = Enabling
        'txtDeliveryLastName.Enabled = Enabling
        'txtDeliveryAddr.Enabled = Enabling
        'txtDeliveryCity.Enabled = Enabling
        'txtDeliveryPostCode.Enabled = Enabling
        'cmbDeliverycountry.Enabled = Enabling


        txtAbo_ValidityTo.Enabled = Enabling
        cmbSuspended.Enabled = Enabling
        cmbNextABO.Enabled = Enabling

        txtABOCredit.Enabled = Enabling
        txtComment.Enabled = Enabling
        cmbSuspended.Enabled = Enabling

        chkMultiShipment.Enabled = Enabling
        cmbNextDiscCode.Enabled = Enabling
        chkAutoStop.Enabled = Enabling
        txtDiscValidity.Enabled = Enabling
        'txtSelect_For_Email.Enabled = Enabling
        txtWishListKind.Enabled = Enabling
        cmbLanguage.Enabled = Enabling
        chkNewsLetter.Enabled = Enabling
        chkNewsLetterPartner.Enabled = Enabling
        chkBlackListed.Enabled = Enabling
        chkRedListed.Enabled = Enabling
        btnGoto30.Enabled = Enabling
        'txtDVDNormAtHome.Enabled = Enabling
        'txtDVDAdultAtHome.Enabled = Enabling


        cmbPayMethod.Enabled = Enabling

        cmbDomStatus.Enabled = Enabling
        txtDomAcctNumber.Enabled = Enabling
        txtDomDebiterName.Enabled = Enabling
        txtDomNumber.Enabled = Enabling

        txt_cc_card_no2.Enabled = Enabling
        txt_cc_card_type2.Enabled = Enabling
        txt_cc_expiration_date2.Enabled = Enabling
        txt_cc_owner2.Enabled = Enabling
        cmb_cc_expiration_status2.Enabled = Enabling


        txtPtSponsorShip.Enabled = Enabling

        DateEndOfHoliday.Enabled = Enabling


        'phone activation

        DateCallPhoneActivation.Enabled = Enabling
        cmbPhoneActivDelete.Enabled = Enabling
        MemoOtherReason.Enabled = Enabling


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

    Public Overrides Sub btnQuickSearch_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuickSearch.ItemClick
        If IsNumeric(txtQuickSearch.EditValue) Then
            _CurrentCustomerID = txtQuickSearch.EditValue
            refreshClient()
            XtraTabControl1.SelectedTabPage = tabMain

        End If
    End Sub

    Public Overloads Sub btnPrevious_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrevious.ItemClick
        _CurrentCustomerID -= 1
        LoadCustomerInfo()
    End Sub
    Public Overloads Sub btnNext_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNext.ItemClick
        _CurrentCustomerID += 1
        LoadCustomerInfo()
    End Sub
    Public Overloads Sub btnFirst_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFirst.ItemClick
        _CurrentCustomerID = 0
        LoadCustomerInfo()
    End Sub
    Public Overloads Sub btnLast_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLast.ItemClick
        _CurrentCustomerID = BKGlobal.ExecuteFindFieldValueINT("customers_id", "select customers_id from customers order by customers_id desc limit 1")
        LoadCustomerInfo()
    End Sub

    Private Sub assignDVD()
        Dim productId As Integer
        Dim DVDId As Integer
        Dim WLId As Integer
        Dim _DS As New dsProducts
        Dim _objProductsDVD As clsProduct_DVD
        Dim sql As String

        'Me.Enabled = False

        productId = GridViewWishList.GetDataRow(GridViewWishList.FocusedRowHandle)("product_id")
        WLId = GridViewWishList.GetDataRow(GridViewWishList.FocusedRowHandle)("wl_id")

        sql = DvdPostData.clsProductDvd.GetProductsDvdToManualAssign(productId)
        DVDId = DvdPostData.clsConnection.ExecuteScalar(sql)

        If DVDId > 0 And productId > 50 Then

            _objProductsDVD = New clsProduct_DVD(SessionInfo, _DS, productId, DVDId)
            _objProductsDVD.AssignDVD(False, WLId, _CurrentCustomerID, DvdPostData.clsCreditHistory.ActionId.MANUAL_ASSIGN)

            MsgBox("This button will send the DVD : " & productId.ToString & " - " & DVDId, MsgBoxStyle.Information)
        Else
            MsgBox("Cannot send DVD : " & productId.ToString & " (No Available DVD) ", MsgBoxStyle.Information)
        End If

    End Sub
    Private Sub cmbNextDiscCode_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbNextDiscCode.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Delete Then
            cmbNextDiscCode.EditValue = 0

        End If
    End Sub
    Private Sub cmbNextDiscCode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNextDiscCode.EditValueChanged
        If cmbNextDiscCode.Enabled = False Then Exit Sub
        chkAutoStop.Checked = False
    End Sub
    Private Sub btnStopAtReconduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopAtReconduction.Click
        Dim _Return As Integer
        Dim _SQLTxt As String = "update customers set customers_abo_auto_stop_next_reconduction = 1 where customers_id = " & txtCustomers_id.EditValue
        _Return = DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        If _Return = 1 Then
            MsgBox("Customer will be Auto-Stopped at next reconduction", MsgBoxStyle.Exclamation)
        Else
            MsgBox("An Error occure." & vbCrLf & _SQLTxt)
        End If
        LoadCustomerInfo()
    End Sub
    Private Sub btnStopNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopNow.Click

        ' the futur code to obligate the customers take off the dvd et home    
        'If (txtDVDNormAtHome.EditValue > 0 Or txtDVDAdultAtHome.EditValue > 0) Then
        '    MsgBox("It's not possible to stop this customer but he has " & txtDVDNormAtHome.EditValue & " DVD Norm " & vbNewLine & _
        '    txtDVDAdultAtHome.EditValue & " DVD Adult (Check the orders History)", MsgBoxStyle.Critical)
        'Else
        Dim reasonStop As New frmChooseStop(SessionInfo)

        reasonStop.drCustomer = objDS.Tables("customers").Rows(0)
        reasonStop.customers_id = txtCustomers_id.EditValue
        reasonStop.typeAbo = cmbABO.EditValue
        reasonStop.ShowDialog()

        refreshClient()
        ' End If

    End Sub
    Private Sub btnReActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReActivate.Click

        Dim sql As String
        Dim cpt As Integer

        If (txtDVDNormAtHome.EditValue > 0 Or txtDVDAdultAtHome.EditValue > 0) Then
            MsgBox("It's not possible to activate this customer but he has " & txtDVDNormAtHome.EditValue & " DVD Norm " & vbNewLine & _
            txtDVDAdultAtHome.EditValue & " DVD Adult (Check the orders History)", MsgBoxStyle.Critical)
        Else

            sql = DvdPostData.ClsCustomersData.GetUpdateActivation(_CurrentCustomerID)
            cpt = DvdPostData.clsConnection.ExecuteNonQuery(sql)
            If cpt = 1 Then
                refreshClient()
            Else
                MsgBox("Activation Error", MsgBoxStyle.Critical)
            End If
        End If



    End Sub
    Private Sub btnGoto30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoto30.Click
        txtRegistrationStep.EditValue = 30
    End Sub



    Private Sub chkViewNegativeBoxes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _refreshData_wishlist = True
        loadwishlist(_CurrentCustomerID, lang_id)
    End Sub

    Private Sub GridOrders_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridOrders.Click

    End Sub
    Private Sub GridViewOrders_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridOrders.DoubleClick
        'envois de du products_id ds la clsingleton pour ensuite etre recupere dans le frmDVD_Maint
        Dim objet1 As DVDPostBuziness.clsSingleton = Nothing

        objet1 = DVDPostBuziness.clsSingleton.Instance()
        objet1.Products_dvd_id = GridViewOrders.GetDataRow(GridViewOrders.FocusedRowHandle)("products_id")

        BKGlobal.StartMenuForm("1033", Me.MdiParent)


    End Sub

    Public Sub loadDroselia(ByVal customers_id As Integer)
        If _refresh_droselia = True Then
            Dim dt As DataTable
            Dim sql As String

            sql = DvdPostData.ClsDroselia.GetDroselia(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            Me.GridDroselia.DataSource = dt

            _refresh_droselia = False

        End If
    End Sub


    Private Sub butGenCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butGenCode.Click
        If txtDroselia.EditValue > 0 Then
            Dim nbr As Integer
            Dim cls As New DVDPostBuziness.ClsCustomers
            Dim str As String
            Dim input As String

            nbr = txtDroselia.EditValue
            str = cls.GenerateDroseliaCode(nbr, _CurrentCustomerID)

            refreshClient()
            loadDroselia(_CurrentCustomerID)

            input = InputBox("", "droselia code", str)
        End If

    End Sub



    Private Sub btnActPhone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActPhone.Click
        Dim typepayment As Integer

        If Me.txtABO.Checked = True Then
            MsgBox("member already activate")
            Exit Sub
        End If
        typepayment = objDS.Tables("customers").Rows(0)("customers_abo_payment_method")
        If typepayment <> DvdPostData.ClsCustomersData.Payment_Method.PHONE Then
            MsgBox("this is not an activation phone member, you cannot activate this abo ", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim cls As DVDPostBuziness.ClsCustomers = New DVDPostBuziness.ClsCustomers()

        Dim ok As Boolean
        ok = cls.Initialisation(_CurrentCustomerID, False)

        If ok Then
            MsgBox("Phone customer activated")
            ok = cls.ReconductionPhone(DvdPostData.ClsCustomersData.Country.BELGIQUE, _CurrentCustomerID, False)
            'cls.UpdateParrainageSummer(_CurrentCustomerID)
            ' cls.UpdateParrainage(_CurrentCustomerID, txtcustomers_email_address_search.Text.Trim, cmbABO.EditValue)

            If ok Then
                MsgBox("Reconduction OK")
                refreshClient()
            Else
                MsgBox("Error Reconduction", MsgBoxStyle.Critical)
            End If

        Else
            MsgBox("Error activate phone", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub btnDelPhoAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelPhoAct.Click


        If Me.cmbPhoneActivDelete.EditValue Is Nothing Then
            MsgBox("you must choose a reason to stop phone activation")
            Me.cmbPhoneActivDelete.ForeColor = Drawing.Color.SeaGreen

        Else
            updateInsertPhoneActivation(True)
            searchPhoneAct()
            refreshClient()
        End If

    End Sub


    Private Sub updateInsertPhoneActivation(ByVal date_delete As Boolean)

        Dim customers_abo As Integer
        Dim customers_id As Integer
        Dim other_reason As String
        Dim stop_phone_id As String
        Dim call_phone As String
        Dim count As Integer
        Dim sql As String
        Dim existCust As Boolean
        Dim registration_step As Integer
        Dim payment_method As Integer

        customers_abo = Me.objDS.Tables("customers").Rows(0)("customers_abo")
        registration_step = Me.objDS.Tables("customers").Rows(0)("customers_registration_step")
        payment_method = Me.objDS.Tables("customers").Rows(0)("customers_abo_payment_method")

        customers_id = _CurrentCustomerID



        If MemoOtherReason.EditValue IsNot Nothing Then
            other_reason = MemoOtherReason.EditValue.ToString
        Else
            other_reason = String.Empty
        End If


        If DateCallPhoneActivation.EditValue IsNot Nothing Then
            call_phone = DateCallPhoneActivation.EditValue.ToString
        Else
            call_phone = String.Empty
        End If

        If cmbPhoneActivDelete.EditValue IsNot Nothing Then
            stop_phone_id = cmbPhoneActivDelete.EditValue.ToString
        Else
            stop_phone_id = String.Empty
        End If

        If customers_abo = DvdPostData.ClsCustomersData.abo.UNVALID And registration_step = 100 And payment_method = DvdPostData.ClsCustomersData.Payment_Method.PHONE Then
            existCust = exist(customers_id)
            Try

                DvdPostData.clsConnection.CreateTransaction(True)

                If existCust Then
                    sql = DvdPostData.clsPhoneActivation.UpdatePhoneActivation(customers_id, stop_phone_id, other_reason, call_phone, date_delete)
                Else
                    sql = DvdPostData.clsPhoneActivation.insertPhoneActivation(customers_id, stop_phone_id, other_reason, call_phone, date_delete)
                End If

                count = DvdPostData.clsConnection.ExecuteNonQuery(sql)

                If date_delete Then
                    sql = DvdPostData.clsPhoneActivation.updateCustomerStep(customers_id)
                    count = DvdPostData.clsConnection.ExecuteNonQuery(sql)
                End If

                DvdPostData.clsConnection.ExecuteBulkQuery(DvdPostData.clsMsgError.processType.Phone_History, count)

            Catch ex As Exception
                DvdPostData.clsConnection.CancelBulkQuery()
                DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Phone_History, ex, customers_id)
            End Try
        End If


    End Sub

    Private Sub VisiblePhoneActivation(ByVal customers_id As Integer)
        Dim dt As DataTable
        Dim sql As String
        'render visible groupcontrol
        If Me.txtRegistrationStep.Text = "100" And objDS.Tables("customers").Rows(0)("customers_abo") = 0 Then
            Me.GroupControlACtPhone.Visible = True
            sql = DvdPostData.clsPhoneActivation.GetHistoriquePhoneActivation(customers_id)

            dt = DvdPostData.clsConnection.FillDataSet(sql)

            ' Dim existCust As Boolean = exist(customers_id, "historique_phone_activation")
            If dt.Rows.Count > 0 Then 'existCust = True Then
                Me.DateCallPhoneActivation.EditValue = dt.Rows(0)("call_phone")
                Me.MemoOtherReason.EditValue = dt.Rows(0)("other_reason")
                Me.cmbPhoneActivDelete.EditValue = dt.Rows(0)("stop_phone_id")

            Else
                'put blank 
                Me.DateCallPhoneActivation.EditValue = ""
                Me.MemoOtherReason.EditValue = ""
                Me.cmbPhoneActivDelete.EditValue = ""
            End If
        Else
            Me.GroupControlACtPhone.Visible = False
        End If
    End Sub

    ''put the list of stop_phone_acti_reason in the dropdowlist (lookupedit1)
    Public Sub reasonStopActPhone()
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.clsPhoneActivation.GetStopPhoneActiReason()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Me.cmbPhoneActivDelete.Properties.DataSource = dt

    End Sub


    Public Function exist(ByVal customers_id As Integer) As Boolean
        Dim sql As String
        sql = DvdPostData.clsPhoneActivation.GetExist(customers_id)
        Return DvdPostData.clsConnection.ExecuteScalar(sql)
    End Function

    Public Sub displayLblSummer(ByVal customers_id As Integer)
        Dim sqlSumWint As String = DvdPostData.ClsCustomersData.GetSelectAboSummerWinterPOwer(customers_id)
        Dim codeSummerWinter As String = BKGlobal.ExecuteFindFieldValue("discount_summer_winter", sqlSumWint)

        If codeSummerWinter <> "0" Then
            Me.lblAboSumP.Visible = True
            Me.lblAboSumP.Text = codeSummerWinter
        Else
            Me.lblAboSumP.Visible = False
        End If

    End Sub

    Private Sub reconductionForced(ByVal customers_id As Integer)

        Dim ok As Boolean
        Dim cls As DVDPostBuziness.ClsCustomers = New DVDPostBuziness.ClsCustomers()
        ok = cls.ReconductionForced(customers_id)

        If ok Then
            MsgBox("Reconduction OK")
            refreshClient()
        Else
            MsgBox("Error Reconduction", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub btnActivateDomiciliation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivateDomiciliation.Click
        If Me.txtABO.Checked = True Then
            MsgBox("member already activate")



        ElseIf objDS.Tables("customers").Rows(0)("customers_abo_payment_method") <> DvdPostData.ClsCustomersData.Payment_Method.DOMICILIATION Then
            MsgBox("No domiciliation customer", MsgBoxStyle.Critical)

        Else

            Dim cls As DVDPostBuziness.ClsCustomers = New DVDPostBuziness.ClsCustomers()
            Dim numDom As String
            ' Dim numaccount As String

            numDom = InputBox("Enter number of domiciliation please ")
            'numaccount = InputBox("Enter bank account number(IBAN) please ")

            If (numDom <> String.Empty AndAlso numDom.Length = 12) Then
                cls.updateNumDom(_CurrentCustomerID, numDom)
                Dim ok As Boolean
                ok = cls.Initialisation(_CurrentCustomerID, True)

                If ok Then
                    MsgBox("Domiciliation customer activated")
                    ok = cls.ReconductionDomiciliation(DvdPostData.ClsCustomersData.Country.BELGIQUE, _CurrentCustomerID, False)
                    If ok Then
                        DVDPostBuziness.clsMail.SendMail(_CurrentCustomerID, DVDPostBuziness.clsMail.Mail.MAIL_ACTIVATIONDOM)
                        MsgBox("Reconduction OK")
                        refreshClient()
                    Else
                        MsgBox("Error Reconduction", MsgBoxStyle.Critical)
                    End If
                Else
                    MsgBox("Error activate domiciliation", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("data invalidated (length num domiciliation : 12)", MsgBoxStyle.Critical)
            End If

        End If
    End Sub

    Private Sub btnReceivedDomiciliation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceivedDomiciliation.Click
        Dim sql As String

        sql = DvdPostData.ClsBatchDomiciliation.UpdateActivation _
                       (_CurrentCustomerID, _
                        DvdPostData.ClsCustomersData.Payment_Method.DOMICILIATION, _
                       DvdPostData.ClsCustomersData.Country.BELGIQUE, _
                       DvdPostData.ClsCustomersData.StepRegistrationStatus.CREATE_DOMICILIATION, _
                        DvdPostData.ClsCustomersData.DomiciliationStatus.RETRIEVELETTER, _
                       DvdPostData.ClsCustomersData.StepRegistrationStatus.RECEIVED_DOMICILIATION)

        Dim cpt As Integer
        cpt = DvdPostData.clsConnection.ExecuteNonQuery(sql)

        If cpt = 1 Then
            MsgBox("Received Domiciliation OK")
            DVDPostBuziness.clsMail.SendMail(_CurrentCustomerID, DVDPostBuziness.clsMail.Mail.MAIL_RECEIVEDDOM)
            refreshClient()
        Else
            MsgBox("Error Received Domiciliation", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub StatusBar1_PanelClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.StatusBarPanelClickEventArgs) Handles StatusBar1.PanelClick

    End Sub

    Private Sub GridViewWishList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSendIt.Click 'Handles btnSendIt.Click
        If GridViewWishList.RowCount <> 0 Then
            assignDVD()
            refreshClient()
            loadwishlist(_CurrentCustomerID, lang_id)
        End If
    End Sub

    Private Sub btnForcedReconduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForcedReconduction.Click
        reconductionForced(_CurrentCustomerID)
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged

        If XtraTabControl1.SelectedTabPage Is tabPaymentMovements Then
            loadBankAccountMovement(_CurrentCustomerID)
        ElseIf XtraTabControl1.SelectedTabPage Is tabWishList Then
            loadwishlist(_CurrentCustomerID, lang_id)
        ElseIf XtraTabControl1.SelectedTabPage Is tabOrdersHistor Then
            loadOrders(_CurrentCustomerID)
        ElseIf XtraTabControl1.SelectedTabPage Is tabAboHistory Then
            loadAboHist(_CurrentCustomerID)
        ElseIf XtraTabControl1.SelectedTabPage Is tabPayment Then
            loadPayment(_CurrentCustomerID)
        ElseIf XtraTabControl1.SelectedTabPage Is TabMailHistory Then
            loadEmailHistory(_CurrentCustomerID)
        ElseIf XtraTabControl1.SelectedTabPage Is tabPurchase Then
            loadShoppingOrders(_CurrentCustomerID)
        ElseIf XtraTabControl1.SelectedTabPage Is tabCreditHist Then
            loadCreditHist(_CurrentCustomerID)
        ElseIf XtraTabControl1.SelectedTabPage Is tabCRM Then
            loadCustServ(_CurrentCustomerID)
        ElseIf XtraTabControl1.SelectedTabPage Is tabAboProcess Then
            loadAboprocessStats(_CurrentCustomerID)
        ElseIf XtraTabControl1.SelectedTabPage Is tabSponsorShip Then
            loadSponsor(_CurrentCustomerID) ' DvdPostData.clsMemberGetMember.SponsorshipType.SPONSOR) ', DvdPostData.clsMemberGetMember.SponsorshipType.SPONSOR)
        ElseIf XtraTabControl1.SelectedTabPage Is tabCompensation Then
            loadCompensation(_CurrentCustomerID)
        ElseIf XtraTabControl1.SelectedTabPage Is tabComment Then
            loadCustComment(_CurrentCustomerID)
        ElseIf XtraTabControl1.SelectedTabPage Is tabProductsRating Then
            loadProductsRating(_CurrentCustomerID)
        ElseIf XtraTabControl1.SelectedTabPage Is tabSuspendedHistory Then
            loadSupendedHistory(_CurrentCustomerID)
        ElseIf XtraTabControl1.SelectedTabPage Is tabDroselia Then
            loadDroselia(_CurrentCustomerID)
        End If

    End Sub

    Private Sub btnLoadPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadPayment.Click
        _refreshData_payment = True
        loadPayment(_CurrentCustomerID)
    End Sub

    Private Sub btnCancelPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelPayment.Click
        Dim id As Integer
        Dim strtype_payment As String
        Dim type_payment As DvdPostData.ClsCustomersData.Payment_Method
        Dim dr As DataRow
        Dim sql As String
        Dim cpt_result As Integer
        If GridViewPayment.GetSelectedRows().Length = 0 Then
            MsgBox("Please select one payment before Cancel")
            Return
        End If
        dr = GridViewPayment.GetDataRow(GridViewPayment.FocusedRowHandle)
        id = dr("id")
        strtype_payment = dr("type_payment")


        If MsgBox("Are you sur to cancel this payment ID = " & id, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            DvdPostData.clsConnection.CreateTransaction(True)

            Select Case strtype_payment
                Case DVDPostTools.clsEnum.getNameStrEnum(DvdPostData.ClsCustomersData.Payment_Method.BANK_TRANSFER)
                    type_payment = DvdPostData.ClsCustomersData.Payment_Method.BANK_TRANSFER
                    sql = DvdPostData.clsBatchBankTransfert.UpdateStatusBankTransfert(id, DvdPostData.PaymentOfflineData.StepPayment.CANCEL)
                    DvdPostData.clsConnection.ExecuteNonQuery(sql)

                Case DVDPostTools.clsEnum.getNameStrEnum(DvdPostData.ClsCustomersData.Payment_Method.OGONE)
                    type_payment = DvdPostData.ClsCustomersData.Payment_Method.OGONE
                    sql = DvdPostData.ClsBatchOgone.getUpdateStatusOgone(id, DvdPostData.PaymentOfflineData.StepPayment.CANCEL)
                    DvdPostData.clsConnection.ExecuteNonQuery(sql)

                Case DVDPostTools.clsEnum.getNameStrEnum(DvdPostData.ClsCustomersData.Payment_Method.DOMICILIATION)
                    type_payment = DvdPostData.ClsCustomersData.Payment_Method.DOMICILIATION
                    sql = DvdPostData.ClsBatchDomiciliation.getUpdateStatusDomiciliation(id, DvdPostData.PaymentOfflineData.StepPayment.CANCEL)
                    DvdPostData.clsConnection.ExecuteNonQuery(sql)

            End Select

            sql = DvdPostData.PaymentOfflineData.UpdateStatusPaymentOffline(id, DvdPostData.PaymentOfflineData.StepPayment.CANCEL_RECOVERY, type_payment)
            DvdPostData.clsConnection.ExecuteNonQuery(sql)

            If DvdPostData.clsConnection.ExecuteBulkQuery(DvdPostData.clsMsgError.processType.Cancel, cpt_result) Then
                MsgBox("Cancel OK")
                _refreshData_payment = True
                loadPayment(_CurrentCustomerID)

            Else
                MsgBox("Cancel Error")
            End If
        End If
    End Sub
    Private Sub BtnPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPaid.Click
        Dim id As Integer
        Dim strtype_payment As String
        Dim type_payment As DvdPostData.ClsCustomersData.Payment_Method
        Dim dr As DataRow
        Dim sql As String
        Dim cpt_result As Integer
        If GridViewPayment.GetSelectedRows().Length = 0 Then
            MsgBox("Please select one payment before Pay")
            Return
        End If
        dr = GridViewPayment.GetDataRow(GridViewPayment.FocusedRowHandle)
        id = dr("id")
        strtype_payment = dr("type_payment")


        If MsgBox("Are you sur to Pay this payment ID = " & id, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            DvdPostData.clsConnection.CreateTransaction(True)

            Select Case strtype_payment
                Case DVDPostTools.clsEnum.getNameStrEnum(DvdPostData.ClsCustomersData.Payment_Method.BANK_TRANSFER)
                    type_payment = DvdPostData.ClsCustomersData.Payment_Method.BANK_TRANSFER
                    sql = DvdPostData.clsBatchBankTransfert.UpdateStatusBankTransfert(id, DvdPostData.PaymentOfflineData.StepPayment.PAID)
                    DvdPostData.clsConnection.ExecuteNonQuery(sql)

                Case DVDPostTools.clsEnum.getNameStrEnum(DvdPostData.ClsCustomersData.Payment_Method.OGONE)
                    type_payment = DvdPostData.ClsCustomersData.Payment_Method.OGONE
                    sql = DvdPostData.ClsBatchOgone.getUpdateStatusOgone(id, DvdPostData.PaymentOfflineData.StepPayment.PAID)
                    DvdPostData.clsConnection.ExecuteNonQuery(sql)

                Case DVDPostTools.clsEnum.getNameStrEnum(DvdPostData.ClsCustomersData.Payment_Method.DOMICILIATION)
                    type_payment = DvdPostData.ClsCustomersData.Payment_Method.DOMICILIATION
                    sql = DvdPostData.ClsBatchDomiciliation.getUpdateStatusDomiciliation(id, DvdPostData.PaymentOfflineData.StepPayment.PAID)
                    DvdPostData.clsConnection.ExecuteNonQuery(sql)

            End Select

            sql = DvdPostData.PaymentOfflineData.UpdateStatusPaymentOffline(id, DvdPostData.PaymentOfflineData.StepPayment.PAID, type_payment)
            DvdPostData.clsConnection.ExecuteNonQuery(sql)

            If DvdPostData.clsConnection.ExecuteBulkQuery(DvdPostData.clsMsgError.processType.Paid, cpt_result) Then
                MsgBox("Pay OK")
                _refreshData_payment = True
                loadPayment(_CurrentCustomerID)

            Else
                MsgBox("Pay Error")
            End If
        End If
    End Sub

    ''' <summary>
    ''' insert in credit_history ' by gauthier
    ''' </summary>
    Private Sub addCreditToCustomers(ByVal quantity As Integer, ByVal customers_id As Integer, ByVal creditAction As DvdPostData.clsCreditHistory.ActionId, ByVal oldCredit As Integer)

        Dim sqlAddCredit As String = DvdPostData.clsCreditHistory.GetInsertCreditHistory(quantity, _CurrentCustomerID, creditAction, , oldCredit)
        DvdPostData.clsConnection.ExecuteNonQuery(sqlAddCredit)

    End Sub

    Private Function calculCredit(ByVal oldCredit As Integer, ByVal newCredit As Integer) As Integer
        Dim result As Integer
        result = newCredit - oldCredit
        Return result
    End Function

    Private Sub lblLogas_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLogas.Click
        System.Diagnostics.Process.Start("http://www.dvdpost.be/logas.php?customers_id=" & _CurrentCustomerID & "")
    End Sub

    Private Sub lblSetPassWord_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSetPassWord.Click
        If MsgBox("change password", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok And _CurrentCustomerID > 0 Then
            Dim sql As String
            Dim code As String
            Dim count As Integer
            Try
                code = GenerateCode()
                sql = DvdPostData.ClsCustomersData.GetUpdatePassWord(_CurrentCustomerID, MD5Encrypt(code))

                DvdPostData.clsConnection.CreateTransaction(False)
                count = DvdPostData.clsConnection.ExecuteNonQuery(sql)
                If count = 1 Then
                    DvdPostData.clsConnection.CommitTransaction(True)
                    code = InputBox("New Password", "", code)
                Else
                    DvdPostData.clsConnection.CommitTransaction(False)
                    MsgBox(" Not new password ")
                End If
            Catch ex As Exception
                DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.SignaletiqueCustomer, ex)
            End Try


        End If
    End Sub

    Private Function GenerateCode() As String
        Dim code As String

        code = Guid.NewGuid().ToString().GetHashCode.ToString("X")

        code = Replace(code, "0", "-")
        code = Replace(code, "O", "-")
        code.ToUpper()
        code = code.Substring(0, code.Length - 2)

        Return code
    End Function

    Private Function MD5Encrypt(ByVal str As String) As String


        Dim md5 As Security.Cryptography.MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim strOutput As String
        Dim i As Integer


        md5 = New Security.Cryptography.MD5CryptoServiceProvider


        bytValue = System.Text.Encoding.UTF8.GetBytes(str)


        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            strOutput &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

        Return strOutput



    End Function

    Private Function calculAge(ByVal birthday As DateTime) As Integer
        Dim result As Integer
        result = DateDiff(DateInterval.Year, birthday, Date.Now)
        Return result
    End Function

    Private Sub loadEmailHistory(ByVal customers_id As Integer)
        If _refreshdata_emailHistory = True Then
            Dim dt As DataTable
            Dim sql As String = DvdPostData.clsMassEmail.GetemailHistory(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            Dim msg As String
            For Each dr As DataRow In dt.Rows
                msg = dr("messages_html")
                If dr("lstvariable") IsNot DBNull.Value Then
                    dr("messages_html") = DVDPostBuziness.clsMail.replacevariableInMsg(msg, dr("lstvariable"))
                End If
            Next

            grpContEmail.DataSource = dt

            If dt.Rows.Count > 0 Then
                GridViewMail.SelectRow(0)
                displayDetailsMail()
            End If

            _refreshdata_emailHistory = False
        End If

    End Sub
    Private Sub displayDetailsMail()
        browser.DocumentText = GridViewMail.GetDataRow(GridViewMail.FocusedRowHandle)("messages_html").ToString()
    End Sub
    Private Sub GridViewMail_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewMail.FocusedRowChanged 'grpContEmail.DoubleClick
        displayDetailsMail()
    End Sub

    Private Sub loadShoppingOrders(ByVal customers_id As Integer)
        If _refreshdata_purchase = True Then
            Dim dt As DataTable
            Dim sqlShopping As String = DvdPostData.clsShopping.GetShoppingOrders(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sqlShopping)
            GridShoppingOrders.DataSource = dt

            GridViewShoppingOrders.BestFitColumns()
            GridViewShoppingOrders.ExpandAllGroups()

            _refreshdata_purchase = False
        End If
    End Sub

    Private Sub loadCreditHist(ByVal customers_id As Integer)
        If _refreshdata_creditHistory = True Then
            Dim dt As DataTable
            Dim sqlCreditHist As String = DvdPostData.clsCreditHistory.GetCreditHistoryByCust(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sqlCreditHist)
            GridCreditHistory.DataSource = dt

            _refreshdata_creditHistory = False
        End If

    End Sub

    Private Sub loadCustServ(ByVal customers_id As Integer)
        If _refreshdata_custServ = True Then
            Dim dt As DataTable
            Dim sqlCustServ As String = DvdPostData.ClsCustserv.GetCustservByCustomers(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sqlCustServ)
            GridCustServ.DataSource = dt

            gridViewCustServ.BestFitColumns()
            gridViewCustServ.ExpandAllGroups()

            displayInfoCustserv()

            _refreshdata_custServ = False
        End If
    End Sub

    Private Sub displayInfoCustserv()
        If gridViewCustServ.RowCount <> 0 Then
            Dim dr As System.Data.DataRow
            dr = gridViewCustServ.GetDataRow(gridViewCustServ.FocusedRowHandle)

            txtCustServ_CustDate.EditValue = dr("customer_date")
            txtCustServ_Subject.EditValue = dr("subject")
            'cmbCustServCat1.EditValue = dr("custserv_cat_name")
            MemoEdit1.EditValue = dr("message")
            txtCustServ_OrderID.EditValue = dr("orders_id")
            txtCustServ_Products_id.EditValue = dr("products_id")
            txtCustServ_DVD_ID.EditValue = dr("dvd_id")
            'txtCustServ_AdminDate.EditValue = dr("admindate")
            txtCustServ_Response_Message.EditValue = dr("adminmessage")
        Else
            txtCustServ_CustDate.EditValue = String.Empty
            txtCustServ_Subject.EditValue = String.Empty
            MemoEdit1.EditValue = String.Empty
            txtCustServ_OrderID.EditValue = String.Empty
            txtCustServ_Products_id.EditValue = String.Empty
            txtCustServ_DVD_ID.EditValue = String.Empty
            txtCustServ_Response_Message.EditValue = String.Empty

        End If
    End Sub

    Private Sub GridViewCustServ_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridViewCustServ.FocusedRowChanged  'grpContEmail.DoubleClick
        displayInfoCustserv()
    End Sub

    Private Sub btnSaveCustServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveCustServ.Click
        Dim dr As DataRow
        Dim custservId As Integer
        Dim messageAdmin As String
        Dim sqlUpdate As String
        Dim subject As String
        Dim sendEmail As Boolean
        Try
            dr = gridViewCustServ.GetDataRow(gridViewCustServ.FocusedRowHandle)

            custservId = CType(dr("custserv_id"), Integer)
            messageAdmin = txtCustServ_Response_Message.Text.Trim
            messageAdmin = Replace(messageAdmin, "'", "\'")
            messageAdmin = Replace(messageAdmin, vbNewLine, "<br>")
            messageAdmin = Replace(messageAdmin, "’", "\'")

            subject = txtCustServ_Subject.Text.Trim
            subject = Replace(subject, "'", "\'")
            subject = Replace(subject, "’", "\'")
            sendEmail = chkCustServSendMail.Checked

            sqlUpdate = DvdPostData.ClsCustserv.upadeCustservByCustMaint(custservId, messageAdmin, subject, sendEmail)
            DvdPostData.clsConnection.ExecuteNonQuery(sqlUpdate)

            If sendEmail = True Then
                DVDPostBuziness.clsMail.SendMail(_CurrentCustomerID, DVDPostBuziness.clsMail.Mail.MAIL_CUST_SERV)
            End If

            refreshClient()
            loadCustServ(_CurrentCustomerID)

            searchCustserv()
        Catch ex As Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Email, ex)
        End Try
    End Sub

    Private Sub GridViewABO_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewABO.DoubleClick
        Dim param As DVDPostBuziness.clsSingleton
        param = DVDPostBuziness.clsSingleton.Instance()
        'param.Activayion_Dscount_id = CType(GridViewABO.GetDataRow(GridViewABO.FocusedRowHandle)("code_id"), Integer)

        Dim action_id As Integer = CType(GridViewABO.GetDataRow(GridViewABO.FocusedRowHandle)("action"), Integer)

        If action_id = DvdPostData.ClsCustomersData.TypeAction.ACTION_FROM_ACTIVATION Then
            param.Activation_Discount_id = CType(GridViewABO.GetDataRow(GridViewABO.FocusedRowHandle)("code_id"), Integer)
            Dim frmAct As New frmActivationCode(SessionInfo)
            frmAct.MdiParent = Me.ParentForm
            frmAct.Show()
            frmAct.search()
        End If

        If action_id = DvdPostData.ClsCustomersData.TypeAction.ACTION_FROM_DISCOUNT Then
            param.Activation_Discount_id = CType(GridViewABO.GetDataRow(GridViewABO.FocusedRowHandle)("code_id"), Integer)
            Dim frmDisc As New frmDiscountCode(SessionInfo)
            frmDisc.MdiParent = Me.ParentForm
            frmDisc.Show()
            frmDisc.search()
        End If
    End Sub

    Public Sub loadAboprocessStats(ByVal customers_id As Integer)
        If _refreshdata_aboprocess = True Then
            Dim dt As New DataTable
            Dim sqlStats As String

            sqlStats = DvdPostData.AboProcessData.GetAboprocessStatsByCust(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sqlStats)
            GridAboprocessStats.DataSource = dt
            _refreshdata_aboprocess = False
        End If

    End Sub
    Private Sub loadSponsorCard(ByVal customers_id As Integer)
        Dim sql As String
        Dim dt As DataTable


        sql = DvdPostData.clsMemberGetMember.GetListCustToOrderCard(customers_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        If dt.Rows.Count > 0 Then
            VisibleControl(dt.Rows(0)("cpt_card"))
        Else
            VisibleControl(0)
        End If
    End Sub
    Private Function getListCode() As String
        Dim result As String = String.Empty
        Dim txt As Control
        For index As Integer = 1 To 5
            txt = GrpSponsonCard.Controls("txtCard" + index.ToString())
            If txt.Visible = True Then
                If txt.Text = "" Then
                    Return String.Empty
                Else
                    result = result + txt.Text + ";"
                End If
            End If
        Next
        result = result.Remove(result.Length - 1, 1)
        Return result
    End Function
    Private Sub VisibleControl(ByVal cpt As Integer)
        Dim label As Control
        Dim txt As Control
        Dim ok As Boolean = False

        For index As Integer = 1 To 5

            label = GrpSponsonCard.Controls("lblCard" + index.ToString())
            txt = GrpSponsonCard.Controls("txtCard" + index.ToString())

            If index > cpt Then
                label.Visible = False
                txt.Visible = False
            Else
                ok = True
                label.Visible = True
                txt.Visible = True
                txt.Text = String.Empty
            End If
        Next

        BtnSaveSponsorCard.Enabled = ok
    End Sub
    Private Sub loadSponsor(ByVal customers_id As Integer)
        If _refreshData_Sponsorship = True Then
            Dim sql As String
            Dim dtSponsor As DataTable
            Dim dtGodson As DataTable
            Dim dtCode As DataTable

            sql = DvdPostData.clsMemberGetMember.GetSponsorUsed(customers_id, DvdPostData.clsMemberGetMember.SponsorshipType.SPONSOR)
            dtSponsor = DvdPostData.clsConnection.FillDataSet(sql)
            GridSon.DataSource = dtSponsor

            sql = DvdPostData.clsMemberGetMember.GetSponsorUsed(customers_id, DvdPostData.clsMemberGetMember.SponsorshipType.GODSON)
            dtGodson = DvdPostData.clsConnection.FillDataSet(sql)
            GridGodFather.DataSource = dtGodson

            sql = DvdPostData.clsMemberGetMember.GetCodeLinkCustomers(customers_id)
            dtCode = DvdPostData.clsConnection.FillDataSet(sql)
            GridCodeLinked.DataSource = dtCode


            loadMgmGift(customers_id)
            loadCustomersPointHistory(customers_id)
            loadSponsorCard(customers_id)

            _refreshData_Sponsorship = False
        End If


    End Sub

    Public Sub loadMgmGift(ByVal customers_id As Integer)
        Dim dt As DataTable
        Dim sqlGift As String

        sqlGift = DvdPostData.clsMemberGetMember.GetMgmGift(customers_id)
        dt = DvdPostData.clsConnection.FillDataSet(sqlGift)
        GridGift.DataSource = dt
    End Sub
    Public Sub loadCustomersPointHistory(ByVal customers_id As Integer)
        Dim dt As DataTable
        Dim sql As String

        sql = DvdPostData.clsMemberGetMember.GetCustomersPointsHistory(customers_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridCustPointHistory.DataSource = dt
    End Sub
    Private Sub GridViewSponsorOf_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewSon.DoubleClick
        If GridViewSon.RowCount <> 0 Then
            Dim customers_id As String = GridViewSon.GetDataRow(GridViewSon.FocusedRowHandle)("son_id")
            ClsCustomers.openFrmCustMaint(customers_id, Me.ParentForm, SessionInfo)
        End If
    End Sub
    Private Sub GridviewGodSonOf_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridviewGodFather.DoubleClick
        If GridviewGodFather.RowCount <> 0 Then
            Dim customers_id As String = GridviewGodFather.GetDataRow(GridviewGodFather.FocusedRowHandle)("father_id")
            ClsCustomers.openFrmCustMaint(customers_id, Me.ParentForm, SessionInfo)
        End If
    End Sub

    Public Function openFrmCustMaint(ByVal customers_id As Integer, ByVal frmParent As Form) As frmCustomers_Maint
        '  Dim objet1 As DVDPostBuziness.clsSingleton = Nothing
        '  objet1 = DVDPostBuziness.clsSingleton.Instance()
        '  objet1.CustomersId = customers_id
        Dim frm As New frmCustomers_Maint(SessionInfo)
        frm.MdiParent = frmParent
        frm.Text = "Customers Maint"
        frm.Show()
        frm.txtQuickSearch.EditValue = customers_id
        frm._CurrentCustomerID = frm.txtQuickSearch.EditValue
        frm.refreshClient()

        frm.XtraTabControl1.SelectedTabPage = frm.tabMain
        Return frm
        'frm.Show()
        'frm.Search()
        'frm.Text = "Customers Maint"
        ''frm.Text
    End Function

    Private Sub loadCompensation(ByVal customers_id As Integer)
        If _refreshdata_compensation Then

            Dim dt As DataTable
            Dim sqlCompensation As String

            sqlCompensation = DvdPostData.clsCompensation.GetCompensationByCust(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sqlCompensation)

            GridCompensation.DataSource = dt

            _refreshdata_compensation = False
        End If

    End Sub

    Private Sub loadCustComment(ByVal customers_id As Integer)
        If _refreshdata_customersComment Then

            Dim sql As String = DvdPostData.clsCustomersComment.GetCustomersComment(customers_id)
            Dim dt As DataTable

            dt = DvdPostData.clsConnection.FillDataSet(sql)
            GridCustComment.DataSource = dt

            _refreshdata_customersComment = False
        End If
    End Sub

    Private Sub GridViewCustComment_FocusedRowHandle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewCustComment.FocusedRowChanged 'grpContEmail.DoubleClick
        If GridViewCustComment.RowCount <> 0 Then
            MemoCustomersComment.Text = GridViewCustComment.GetDataRow(GridViewCustComment.FocusedRowHandle)("customers_comment_text").ToString()
        Else
            MemoCustomersComment.Text = String.Empty
        End If
    End Sub

    Private Sub btnAddCustomersComment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCustomersComment.Click
        If MemoInsertComment.Text <> String.Empty Then
            Dim str As String
            str = MemoInsertComment.Text
            Dim sqlInsertComment As String = DvdPostData.clsCustomersComment.GetInsertCustomersComment(_CurrentCustomerID, str)
            DvdPostData.clsConnection.ExecuteNonQuery(sqlInsertComment)

            _refreshdata_customersComment = True
            loadCustComment(_CurrentCustomerID)
            MemoInsertComment.Text = String.Empty
        End If
    End Sub



    Private Sub btnViewCustserv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewCustserv.Click
        searchCustserv()
    End Sub

    Private Sub searchCustserv()
        Dim dt As DataTable
        Dim sql As String = DvdPostData.ClsCustserv.GetCustServCustomers()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt
    End Sub

    Private Sub btnViewGift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewGift.Click
        Dim dt As DataTable
        Dim sql As String = DvdPostData.clsMemberGetMember.GetCustomersWithGift()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt
    End Sub

    Private Sub chkAutoStop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoStop.CheckedChanged
        CheckboxColor()
    End Sub

    Private Sub CheckboxColor()
        If chkAutoStop.Checked Then
            chkAutoStop.BackColor = Drawing.Color.Red
        Else
            chkAutoStop.BackColor = Drawing.Color.Transparent
        End If
    End Sub

    Private Sub loadAddressBook(ByVal customers_id As Integer)
        Dim dt As DataTable
        Dim sql As String = DvdPostData.clsAddressBook.GetAddressByCustomer(customers_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridAddress.DataSource = dt

        If GridViewAddress.RowCount = 0 Then
            GridAddress.Visible = False
        Else
            GridAddress.Visible = True
        End If
    End Sub

    Private Sub loadProductsRating(ByVal customers_id As Integer)
        If _refresh_productsRating = True Then
            Dim dt As DataTable
            Dim sql As String = DvdPostData.clsProductsRating.GetProductsRatingByCust(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            GridProductsRating.DataSource = dt

            GridViewProductsRating.ExpandAllGroups()

            _refresh_productsRating = False
        End If
    End Sub

    Private Sub BtnSponsorCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSponsorCard.Click
        Dim dt As DataTable
        Dim sql As String = DvdPostData.clsMemberGetMember.GetListCustToOrderCard()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt
    End Sub

    Private Sub BtnSaveSponsorCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveSponsorCard.Click
        Dim result As String
        Dim ok As Boolean

        result = getListCode()
        If result Is String.Empty Then
            MsgBox("card without activation code  ", MsgBoxStyle.Critical)
        Else
            ok = DVDPostBuziness.clsMemberGetMember.CallUrllinkCard(_CurrentCustomerID, result)
            If ok Then
                MsgBox("ok")

            Else
                MsgBox("Error")
            End If
        End If
    End Sub

    Private Sub loadRedBlackListed(ByVal redBlackList As DvdPostData.ClsCustomersData.RedBlackListed)
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.ClsCustomersData.GetRedBlacklistedCustomers(redBlackList)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt
    End Sub

    Private Sub btnBlackListed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlackListed.Click
        loadRedBlackListed(DvdPostData.ClsCustomersData.RedBlackListed.BLACKLISTED)
    End Sub

    Private Sub btnRedlisted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRedlisted.Click
        loadRedBlackListed(DvdPostData.ClsCustomersData.RedBlackListed.REDLISTED)
    End Sub

    Private Sub BtnEmailError_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmailError.Click
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.clsOdersStatusHistory.GetListOrderHistory(True, True)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt
    End Sub


    Private Sub loadSupendedHistory(ByVal customers_id As Integer)
        Dim sql As String
        Dim dt As DataTable

        If _refresh_suspendedHistory = True Then

            sql = DvdPostData.clsAboSuspended.GetSuspendedHistory(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            GridSuspendedHistory.DataSource = dt

            _refresh_suspendedHistory = False
        End If
    End Sub

    Private Sub unsuspendedPayment(ByVal customers_id As Integer)
        Dim sql As String
        Dim id As Object
        Dim type As String

        type = DvdPostData.clsAboSuspended.Payment

        sql = DvdPostData.clsAboSuspended.GetIdAboSuspendedHistory(customers_id, type)
        id = DvdPostData.clsConnection.ExecuteScalar(sql)


        If Not IsNumeric(id) Then
            MsgBox("this customers are not suspension to close")
        Else
            Try
                DvdPostData.clsConnection.CreateTransaction(False)
                sql = DvdPostData.clsAboSuspended.GetUpdateAboSuspendedHistory(id)

                DvdPostData.clsConnection.ExecuteNonQuery(sql)

                DvdPostData.clsConnection.CommitTransaction(True)

            Catch ex As Exception
                DvdPostData.clsConnection.CommitTransaction(False)
                DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.SignaletiqueCustomer, ex, customers_id)
            End Try
        End If
    End Sub

    Private Sub suspendForHoliday(ByVal customers_id As Integer, ByVal date_end As Date, ByVal old_date_end As Date)
        If cmbSuspended.EditValue = DvdPostData.ClsCustomersData.Suspended.HOLLIDAY And date_end <> old_date_end Then
            Dim sqlSuspended As String
            Dim IntervalDay As Integer
            Dim type As String
            Dim id As Object
            Dim count As Integer


            type = DvdPostData.clsAboSuspended.Holidays

            sqlSuspended = DvdPostData.clsAboSuspended.GetIdAboSuspendedHistory(customers_id, type, old_date_end)
            id = DvdPostData.clsConnection.ExecuteScalar(sqlSuspended)


            If date_end < old_date_end Then
                IntervalDay = DateDiff(DateInterval.Day, old_date_end, date_end)
            Else
                IntervalDay = DateDiff(DateInterval.Day, Date.Now, date_end)
            End If

            Try
                DvdPostData.clsConnection.CreateTransaction(False)



                'sqlSuspended = DvdPostData.clsAboSuspended.GetInsertAboSuspendedHistory(customers_id, DvdPostData.clsAboSuspended.aboSupendedAction.SUSPENDED, DvdPostData.clsAboSuspended.aboSupendedReason.HOLIDAY)
                If Not IsNumeric(id) Then
                    sqlSuspended = DvdPostData.clsAboSuspended.GetInsertAboSuspendedHistory(customers_id, type, date_end)
                Else
                    sqlSuspended = DvdPostData.clsAboSuspended.GetUpdateAboSuspendedHistory(id, date_end)
                End If
                count = DvdPostData.clsConnection.ExecuteNonQuery(sqlSuspended)




                ' sqlSuspended = DvdPostData.clsAboSuspended.GetInsertAboSuspendedHoliday(customers_id, date_end)
                'DvdPostData.clsConnection.ExecuteNonQuery(sqlSuspended)

                sqlSuspended = DvdPostData.clsAboSuspended.GetUpdateValidityToForHoliday(customers_id, IntervalDay)
                count = DvdPostData.clsConnection.ExecuteNonQuery(sqlSuspended)

                DvdPostData.clsConnection.CommitTransaction(True)

                'DvdPostData.clsConnection.ExecuteBulkQuery(DvdPostData.clsMsgError.processType.SignaletiqueCustomer, count)

                refreshClient()
            Catch ex As Exception
                'DvdPostData.clsConnection.CancelBulkQuery()
                DvdPostData.clsConnection.CommitTransaction(False)
                DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.SignaletiqueCustomer, ex, _CurrentCustomerID)
            End Try


        End If
    End Sub

    Private Sub suspended()
        Dim newSuspended As Integer

        newSuspended = cmbSuspended.EditValue

        If Not IsNothing(DateEndOfHoliday.EditValue) And newSuspended = DvdPostData.ClsCustomersData.Suspended.HOLLIDAY Then
            Dim new_date_end_holiday As Date = DateEndOfHoliday.EditValue 'by Gauthier
            suspendForHoliday(_CurrentCustomerID, new_date_end_holiday, _old_date_Holiday)
        End If

        If _oldSuspended <> newSuspended And newSuspended = DvdPostData.ClsCustomersData.Suspended.OK Then
            unsuspendedPayment(_CurrentCustomerID)
        End If

    End Sub



    '' to check the words Gauthier
    Private Function SpellChecker(ByVal str As String) As String
        Dim spellCheck As New SpellChecker
        spellCheck.Check(str)
        Return str
    End Function

End Class

