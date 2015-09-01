Imports BizzLib.clsGlobal.ObjectState
Imports System.Net.Mail
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports DevExpress.XtraSpellChecker
Imports BCrypt

Public Class frmCustomers_Maint
    Inherits BizzLib.frmGeneral_Maintenance



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
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents objDS As PlushLib.dsCustomerMaint
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

    '  Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

    Friend WithEvents tabMailHistory As DevExpress.XtraTab.XtraTabPage

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

    Friend WithEvents tabPaymentMovements As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCBankAccountMovement As DevExpress.XtraEditors.GroupControl
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
    'Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
    Friend WithEvents BtnCancelPayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupOgone As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelOgone As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cc_owner2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cc_card_no2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cc_card_type2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemPayment As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_cc_expiration_status2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_cc_expiration_date2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridPayment As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewPayment As DevExpress.XtraGrid.Views.Grid.GridView
    ' Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn59 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn60 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn61 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn62 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn63 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLastModified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCommunicationPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCustomersID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayment_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents checkOpenPayment As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnLoadPayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabCustServ As DevExpress.XtraTab.XtraTabPage
    '  Friend WithEvents cmbCustServ_cat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SPlitCCustserv As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GCCustServ As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSaveCustServ As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutCustServ As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridABO As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewABO As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colcustomerid As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAction As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    ' Friend WithEvents cmbABO_Action As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
    Friend WithEvents txtCustServ_Response_Message As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtCustServ_DVD_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustServ_Products_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustServ_OrderID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustServ_CustDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtCustServ_Subject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LCGMisc As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCGResponse As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSearch As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents col2customers_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_firstname As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_lastname As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_email_address As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_abo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colentry_postcode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_language As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents call_phone As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents tabAboHistory As DevExpress.XtraTab.XtraTabPage

    Friend WithEvents tabMain As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnForcedReconduction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnActivateDomiciliation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReceivedDomiciliation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCACtPhone As DevExpress.XtraEditors.GroupControl
    Public WithEvents cmbPhoneActivDelete As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelReason As System.Windows.Forms.Label
    Friend WithEvents btnDelPhoAct As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateCallPhoneActivation As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelCallMeDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnActPhone As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkNewsLetterPartner As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkNewsLetter As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtNbrOfLogons As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbLanguage As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnReActivate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCAboInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblSuspended As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGoto30 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRegistrationStep As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblRegistrationStep As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDiscountrecurring As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDiscRecurring As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkAutoStop As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbNextDiscCode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblNextDiscount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblActivation As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbNextABO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblValidity As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAbo_ValidityTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbABO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblNextAbo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAbo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCadresse As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDeliveryFirstName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeliveryLastName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDeliverycountry As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDeliveryCity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeliveryPostCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeliveryAddr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCcustomersInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtYearsOld As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblGender As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGender As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblyearsOld As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSetPassWord As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEMail As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtABO As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateBirthday As DevExpress.XtraEditors.DateEdit
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

    Friend WithEvents XTabCustomers As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents grpContEmail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewMail As DevExpress.XtraGrid.Views.Grid.GridView
    '  Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents messages_subject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents messages_title As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mail_opened_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mail_opened As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents date_sended As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents messages_html As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents browser As System.Windows.Forms.WebBrowser
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

    Friend WithEvents cologone_payment_status_history_id As DevExpress.XtraGrid.Columns.GridColumn






    Friend WithEvents chkCustServSendMail As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents tabSponsorShip As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridSon As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents used_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSon_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents son_abo_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents points As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridViewGodson As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents date_used As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sponsor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCSponsorShip As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCGift As DevExpress.XtraEditors.GroupControl
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
    Friend WithEvents lblDateEndHoliday As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEndOfHoliday As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnViewCustserv As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnViewGift As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents colentry_street_address As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents fullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

    Friend WithEvents BtnSponsorCard As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCSponsonCard As DevExpress.XtraEditors.GroupControl
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
    Friend WithEvents txtNextPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChkListConfig As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents btnRefreshTab As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabConfig As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblNextPrice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabVodView As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridViewVod As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcDate_added As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCLast_modified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCProducts_title As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCImdb_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCCount_ip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCNb_viewed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCUsedIp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCMail_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLast_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDate_closed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDomNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colabopay_id As DevExpress.XtraGrid.Columns.GridColumn

    Friend WithEvents txtLast_logon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCpt_reconduction As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNbReconduction As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridBankAccountMovements As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewBankAccountMovements As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIsmatching As DevExpress.XtraGrid.Columns.GridColumn
    Protected WithEvents RepositoryCmbMatching As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colBankAccountMovements_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_coda_created As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodaFilename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvdpost_bank_account As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcommunicationStr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStructuredComm12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCounterpartdetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCommunication_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntireData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankAccountClient As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ColLastnModified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankAccount_Customers_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankAccount_Comment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabCalls As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    ' Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents MemoEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    ' Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LookUpEdit3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LookUpEdit4 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl60 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LookUpEdit5 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SpinEdit2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit3 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit4 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl61 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl62 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl63 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl64 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit5 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl65 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl66 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit4 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LookUpEdit6 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl67 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl68 As DevExpress.XtraEditors.LabelControl
    '  Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl69 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit7 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl70 As DevExpress.XtraEditors.LabelControl
    'Friend WithEvents GroupControl9 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit13 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SpinEdit6 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl71 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TextEdit14 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit4 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TextEdit15 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit5 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl72 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit6 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TextEdit16 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl73 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl74 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit17 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl75 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl76 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl77 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit18 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl78 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl79 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit8 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl80 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl81 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl82 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit9 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DateEdit5 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl83 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit19 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents HyperLinkEdit1 As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents TextEdit20 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl84 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit7 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl85 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit6 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TextEdit21 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit22 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl86 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit23 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl87 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents UcCallsHistory1 As PlushLib.ucCallsHistory
    Friend WithEvents tabMessagerie As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmbDiscountActivation As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents UcMessagerieCustomer As PlushLib.UcMessagerie
    Friend WithEvents RepositoryWishlistIProduct As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryISponsorCustomers_id As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryISponsorGodCustomers_id As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryICustomersCustomers_id As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents tabCritiques As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridCritiques As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCritiques As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblValueNbCrtitiques As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNbCrtitiques As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValueRatingAverage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRatingAverage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblValueNbCritiquePositive As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNbCritiquePositive As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValueAverageRatingDvdPost As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAverageRatingDvdPost As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValueRating As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRating As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cdate_added As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDate_added_Current As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GCCompensation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents phone_activation_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPPAgreementID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateConfirmationSentAt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateConfirmedAt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnReplayAllCreditHistory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateCreated As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkCustomerLockedForReconduction As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblAboSumP As System.Windows.Forms.Label
    Friend WithEvents txtTVODFreeCredits As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDiscType As DevExpress.XtraEditors.ComboBoxEdit


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim coldvd_finally_arrived_mail3 As DevExpress.XtraGrid.Columns.GridColumn
        Dim GridchkAbo As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Dim GridchkBlackList As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Dim ColTypePayment As DevExpress.XtraGrid.Columns.GridColumn
        Dim ColPayment_id As DevExpress.XtraGrid.Columns.GridColumn
        Dim ColAmountPay As DevExpress.XtraGrid.Columns.GridColumn
        Dim ColDateAdded As DevExpress.XtraGrid.Columns.GridColumn
        Dim ColIdMatching As DevExpress.XtraGrid.Columns.GridColumn
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomers_Maint))
        Me.txtNextPrice = New DevExpress.XtraEditors.TextEdit
        Me.objDS = New PlushLib.dsCustomerMaint
        Me.colcustomers2_id6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridViewGodson = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.date_used = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sponsor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridSon = New DevExpress.XtraGrid.GridControl
        Me.GridViewSon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.used_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSon_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryISponsorCustomers_id = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
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
        Me.tabMailHistory = New DevExpress.XtraTab.XtraTabPage
        Me.browser = New System.Windows.Forms.WebBrowser
        Me.grpContEmail = New DevExpress.XtraGrid.GridControl
        Me.GridViewMail = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.messages_subject = New DevExpress.XtraGrid.Columns.GridColumn
        Me.messages_title = New DevExpress.XtraGrid.Columns.GridColumn
        Me.mail_opened_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.mail_opened = New DevExpress.XtraGrid.Columns.GridColumn
        Me.date_sended = New DevExpress.XtraGrid.Columns.GridColumn
        Me.messages_html = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCMail_id = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.tabPaymentMovements = New DevExpress.XtraTab.XtraTabPage
        Me.GCBankAccountMovement = New DevExpress.XtraEditors.GroupControl
        Me.GridBankAccountMovements = New DevExpress.XtraGrid.GridControl
        Me.GridViewBankAccountMovements = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIsmatching = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryCmbMatching = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colBankAccountMovements_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldate_coda_created = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodaFilename = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colamount2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldvdpost_bank_account = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcommunicationStr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStructuredComm12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCounterpartdetails = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCommunication_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEntireData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBankAccountClient = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBankAccount_Customers_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBankAccount_Comment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridABO = New DevExpress.XtraGrid.GridControl
        Me.GridViewABO = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colcustomerid = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colAction = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcode_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproduct_id1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colpayment_method = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colprivilege_notified = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colsite = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.ColLast_status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDate_closed = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colDomNumber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colabopay_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tabPayment = New DevExpress.XtraTab.XtraTabPage
        Me.GridPayment = New DevExpress.XtraGrid.GridControl
        Me.GridViewPayment = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColLastModified = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCommunicationPay = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCustomersID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPayment_status = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.tabCustServ = New DevExpress.XtraTab.XtraTabPage
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
        Me.LCGMisc = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LCGResponse = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.GCCustServ = New DevExpress.XtraEditors.GroupControl
        Me.chkCustServSendMail = New DevExpress.XtraEditors.CheckEdit
        Me.btnSaveCustServ = New DevExpress.XtraEditors.SimpleButton
        Me.SPlitCCustserv = New DevExpress.XtraEditors.SplitterControl
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridViewSearch = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.phone_activation_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.col2customers_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryICustomersCustomers_id = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.colcustomers_firstname = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_lastname = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_email_address = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colentry_postcode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colentry_street_address = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_language = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.call_phone = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_abo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.tabAboHistory = New DevExpress.XtraTab.XtraTabPage
        Me.tabMain = New DevExpress.XtraTab.XtraTabPage
        Me.lblCpt_reconduction = New DevExpress.XtraEditors.LabelControl
        Me.lblNbReconduction = New DevExpress.XtraEditors.LabelControl
        Me.lblNextPrice = New DevExpress.XtraEditors.LabelControl
        Me.btnForcedReconduction = New DevExpress.XtraEditors.SimpleButton
        Me.btnActivateDomiciliation = New DevExpress.XtraEditors.SimpleButton
        Me.btnReceivedDomiciliation = New DevExpress.XtraEditors.SimpleButton
        Me.GCACtPhone = New DevExpress.XtraEditors.GroupControl
        Me.MemoOtherReason = New DevExpress.XtraEditors.MemoEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbPhoneActivDelete = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelReason = New System.Windows.Forms.Label
        Me.DateCallPhoneActivation = New DevExpress.XtraEditors.DateEdit
        Me.LabelCallMeDate = New DevExpress.XtraEditors.LabelControl
        Me.btnDelPhoAct = New DevExpress.XtraEditors.SimpleButton
        Me.btnActPhone = New DevExpress.XtraEditors.SimpleButton
        Me.btnReActivate = New DevExpress.XtraEditors.SimpleButton
        Me.GCAboInfo = New DevExpress.XtraEditors.GroupControl
        Me.txtTVODFreeCredits = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.lblAboSumP = New System.Windows.Forms.Label
        Me.chkCustomerLockedForReconduction = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.DateConfirmationSentAt = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.DateConfirmedAt = New DevExpress.XtraEditors.DateEdit
        Me.cmbDiscountActivation = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbDiscType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblDateEndHoliday = New DevExpress.XtraEditors.LabelControl
        Me.DateEndOfHoliday = New DevExpress.XtraEditors.DateEdit
        Me.cmbSuspended = New DevExpress.XtraEditors.LookUpEdit
        Me.lblSuspended = New DevExpress.XtraEditors.LabelControl
        Me.btnGoto30 = New DevExpress.XtraEditors.SimpleButton
        Me.txtRegistrationStep = New DevExpress.XtraEditors.TextEdit
        Me.lblRegistrationStep = New DevExpress.XtraEditors.LabelControl
        Me.lblDiscountrecurring = New DevExpress.XtraEditors.LabelControl
        Me.txtDiscRecurring = New DevExpress.XtraEditors.DateEdit
        Me.chkAutoStop = New DevExpress.XtraEditors.CheckEdit
        Me.cmbNextDiscCode = New DevExpress.XtraEditors.LookUpEdit
        Me.lblNextDiscount = New DevExpress.XtraEditors.LabelControl
        Me.lblActivation = New DevExpress.XtraEditors.LabelControl
        Me.cmbNextABO = New DevExpress.XtraEditors.LookUpEdit
        Me.lblValidity = New DevExpress.XtraEditors.LabelControl
        Me.txtAbo_ValidityTo = New DevExpress.XtraEditors.DateEdit
        Me.cmbABO = New DevExpress.XtraEditors.LookUpEdit
        Me.lblNextAbo = New DevExpress.XtraEditors.LabelControl
        Me.lblAbo = New DevExpress.XtraEditors.LabelControl
        Me.GCadresse = New DevExpress.XtraEditors.GroupControl
        Me.txtDate_added_Current = New DevExpress.XtraEditors.TextEdit
        Me.GridAddress = New DevExpress.XtraGrid.GridControl
        Me.GridViewAddress = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.entry_firstname = New DevExpress.XtraGrid.Columns.GridColumn
        Me.entry_lastname = New DevExpress.XtraGrid.Columns.GridColumn
        Me.entry_street_address = New DevExpress.XtraGrid.Columns.GridColumn
        Me.entry_postcode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.entry_city = New DevExpress.XtraGrid.Columns.GridColumn
        Me.countries_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cdate_added = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtDeliveryFirstName = New DevExpress.XtraEditors.TextEdit
        Me.txtDeliveryLastName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.cmbDeliverycountry = New DevExpress.XtraEditors.LookUpEdit
        Me.txtDeliveryCity = New DevExpress.XtraEditors.TextEdit
        Me.txtDeliveryPostCode = New DevExpress.XtraEditors.TextEdit
        Me.txtDeliveryAddr = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.GCcustomersInfo = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.txtDateCreated = New DevExpress.XtraEditors.DateEdit
        Me.txtLast_logon = New DevExpress.XtraEditors.TextEdit
        Me.txtYearsOld = New DevExpress.XtraEditors.TextEdit
        Me.chkNewsLetterPartner = New DevExpress.XtraEditors.CheckEdit
        Me.lblGender = New DevExpress.XtraEditors.LabelControl
        Me.chkNewsLetter = New DevExpress.XtraEditors.CheckEdit
        Me.txtGender = New DevExpress.XtraEditors.TextEdit
        Me.lblyearsOld = New DevExpress.XtraEditors.LabelControl
        Me.lblSetPassWord = New DevExpress.XtraEditors.LabelControl
        Me.txtNbrOfLogons = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl
        Me.cmbLanguage = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.txtTel = New DevExpress.XtraEditors.TextEdit
        Me.txtEMail = New DevExpress.XtraEditors.HyperLinkEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.txtABO = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.DateBirthday = New DevExpress.XtraEditors.DateEdit
        Me.txtFirstName = New DevExpress.XtraEditors.TextEdit
        Me.txtLastName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtCustomers_id = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.btnStopNow = New DevExpress.XtraEditors.SimpleButton
        Me.btnStopAtReconduction = New DevExpress.XtraEditors.SimpleButton
        Me.tabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.txtPPAgreementID = New DevExpress.XtraEditors.TextEdit
        Me.btnReplayAllCreditHistory = New DevExpress.XtraEditors.SimpleButton
        Me.BtnEmailError = New DevExpress.XtraEditors.SimpleButton
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
        Me.XTabCustomers = New DevExpress.XtraTab.XtraTabControl
        Me.tabComment = New DevExpress.XtraTab.XtraTabPage
        Me.MemoCustomersComment = New DevExpress.XtraEditors.MemoEdit
        Me.GridCustComment = New DevExpress.XtraGrid.GridControl
        Me.GridViewCustComment = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.customers_comment_text = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_comment_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fullName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MemoInsertComment = New DevExpress.XtraEditors.MemoEdit
        Me.btnAddCustomersComment = New DevExpress.XtraEditors.SimpleButton
        Me.tabCalls = New DevExpress.XtraTab.XtraTabPage
        Me.UcCallsHistory1 = New PlushLib.ucCallsHistory
        Me.tabMessagerie = New DevExpress.XtraTab.XtraTabPage
        Me.UcMessagerieCustomer = New PlushLib.UcMessagerie
        Me.tabSponsorShip = New DevExpress.XtraTab.XtraTabPage
        Me.GCCodeLinked = New DevExpress.XtraEditors.GroupControl
        Me.GridCodeLinked = New DevExpress.XtraGrid.GridControl
        Me.GridViewCodeLinked = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GCSponsonCard = New DevExpress.XtraEditors.GroupControl
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
        Me.GCGift = New DevExpress.XtraEditors.GroupControl
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
        Me.GCSponsorShip = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.GridGodFather = New DevExpress.XtraGrid.GridControl
        Me.GridviewGodFather = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.coldate_used = New DevExpress.XtraGrid.Columns.GridColumn
        Me.father_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryISponsorGodCustomers_id = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.colfather_abo_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col2customers_lastname = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col2customers_firstname = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.tabVodView = New DevExpress.XtraTab.XtraTabPage
        Me.GridViewVod = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcDate_added = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCLast_modified = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCProducts_title = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCImdb_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCCount_ip = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCNb_viewed = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCUsedIp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCCompensation = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GCID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tabCritiques = New DevExpress.XtraTab.XtraTabPage
        Me.lblValueRating = New DevExpress.XtraEditors.LabelControl
        Me.lblRating = New DevExpress.XtraEditors.LabelControl
        Me.lblValueAverageRatingDvdPost = New DevExpress.XtraEditors.LabelControl
        Me.lblAverageRatingDvdPost = New DevExpress.XtraEditors.LabelControl
        Me.lblValueNbCritiquePositive = New DevExpress.XtraEditors.LabelControl
        Me.lblNbCritiquePositive = New DevExpress.XtraEditors.LabelControl
        Me.lblValueNbCrtitiques = New DevExpress.XtraEditors.LabelControl
        Me.lblNbCrtitiques = New DevExpress.XtraEditors.LabelControl
        Me.lblValueRatingAverage = New DevExpress.XtraEditors.LabelControl
        Me.lblRatingAverage = New DevExpress.XtraEditors.LabelControl
        Me.GridCritiques = New DevExpress.XtraGrid.GridControl
        Me.GridViewCritiques = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tabConfig = New DevExpress.XtraTab.XtraTabPage
        Me.btnRefreshTab = New DevExpress.XtraEditors.SimpleButton
        Me.ChkListConfig = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton
        Me.MemoEdit2 = New DevExpress.XtraEditors.MemoEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.LookUpEdit3 = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit
        Me.LookUpEdit4 = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl60 = New DevExpress.XtraEditors.LabelControl
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit
        Me.LookUpEdit5 = New DevExpress.XtraEditors.LookUpEdit
        Me.SpinEdit2 = New DevExpress.XtraEditors.SpinEdit
        Me.SpinEdit3 = New DevExpress.XtraEditors.SpinEdit
        Me.SpinEdit4 = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl61 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl62 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl63 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl
        Me.SpinEdit5 = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl65 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl66 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit4 = New DevExpress.XtraEditors.DateEdit
        Me.LookUpEdit6 = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl67 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl68 = New DevExpress.XtraEditors.LabelControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl69 = New DevExpress.XtraEditors.LabelControl
        Me.LookUpEdit7 = New DevExpress.XtraEditors.LookUpEdit
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit11 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit12 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl70 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit13 = New DevExpress.XtraEditors.TextEdit
        Me.SpinEdit6 = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl71 = New DevExpress.XtraEditors.LabelControl
        Me.CheckEdit3 = New DevExpress.XtraEditors.CheckEdit
        Me.TextEdit14 = New DevExpress.XtraEditors.TextEdit
        Me.CheckEdit4 = New DevExpress.XtraEditors.CheckEdit
        Me.TextEdit15 = New DevExpress.XtraEditors.TextEdit
        Me.CheckEdit5 = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl72 = New DevExpress.XtraEditors.LabelControl
        Me.CheckEdit6 = New DevExpress.XtraEditors.CheckEdit
        Me.TextEdit16 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl73 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl74 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit17 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl75 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl76 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl77 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit18 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl78 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl79 = New DevExpress.XtraEditors.LabelControl
        Me.LookUpEdit8 = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl80 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl81 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl82 = New DevExpress.XtraEditors.LabelControl
        Me.LookUpEdit9 = New DevExpress.XtraEditors.LookUpEdit
        Me.DateEdit5 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl83 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit19 = New DevExpress.XtraEditors.TextEdit
        Me.HyperLinkEdit1 = New DevExpress.XtraEditors.HyperLinkEdit
        Me.TextEdit20 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl84 = New DevExpress.XtraEditors.LabelControl
        Me.CheckEdit7 = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl85 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit6 = New DevExpress.XtraEditors.DateEdit
        Me.TextEdit21 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit22 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl86 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit23 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl87 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton10 = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        coldvd_finally_arrived_mail3 = New DevExpress.XtraGrid.Columns.GridColumn
        GridchkAbo = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        GridchkBlackList = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        ColTypePayment = New DevExpress.XtraGrid.Columns.GridColumn
        ColPayment_id = New DevExpress.XtraGrid.Columns.GridColumn
        ColAmountPay = New DevExpress.XtraGrid.Columns.GridColumn
        ColDateAdded = New DevExpress.XtraGrid.Columns.GridColumn
        ColIdMatching = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(GridchkAbo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(GridchkBlackList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNextPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewGodson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryISponsorCustomers_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMailHistory.SuspendLayout()
        CType(Me.grpContEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCustServ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewCustServ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPaymentMovements.SuspendLayout()
        CType(Me.GCBankAccountMovement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCBankAccountMovement.SuspendLayout()
        CType(Me.GridBankAccountMovements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewBankAccountMovements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryCmbMatching, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridABO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewABO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPayment.SuspendLayout()
        CType(Me.GridPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPayment, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalcEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPayMethod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCustServ.SuspendLayout()
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
        CType(Me.LCGMisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCGResponse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCCustServ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCCustServ.SuspendLayout()
        CType(Me.chkCustServSendMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryICustomersCustomers_id, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAboHistory.SuspendLayout()
        Me.tabMain.SuspendLayout()
        CType(Me.GCACtPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCACtPhone.SuspendLayout()
        CType(Me.MemoOtherReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPhoneActivDelete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateCallPhoneActivation.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateCallPhoneActivation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCAboInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCAboInfo.SuspendLayout()
        CType(Me.txtTVODFreeCredits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCustomerLockedForReconduction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateConfirmationSentAt.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateConfirmationSentAt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateConfirmedAt.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateConfirmedAt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDiscountActivation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDiscType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEndOfHoliday.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEndOfHoliday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSuspended.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegistrationStep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscRecurring.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscRecurring.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAutoStop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNextDiscCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNextABO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbo_ValidityTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbo_ValidityTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbABO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCadresse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCadresse.SuspendLayout()
        CType(Me.txtDate_added_Current.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDeliverycountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryPostCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryAddr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCcustomersInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCcustomersInfo.SuspendLayout()
        CType(Me.txtDateCreated.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateCreated.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLast_logon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYearsOld.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNewsLetterPartner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNewsLetter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNbrOfLogons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtABO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateBirthday.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateBirthday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomers_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearch.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtPPAgreementID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCustomers_NumComm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_domiciliation_number_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_postcode_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_address_street_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_email_address_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_name_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_id_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XTabCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabCustomers.SuspendLayout()
        Me.tabComment.SuspendLayout()
        CType(Me.MemoCustomersComment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCustComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCustComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoInsertComment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCalls.SuspendLayout()
        Me.tabMessagerie.SuspendLayout()
        Me.tabSponsorShip.SuspendLayout()
        CType(Me.GCCodeLinked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCCodeLinked.SuspendLayout()
        CType(Me.GridCodeLinked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCodeLinked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCSponsonCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCSponsonCard.SuspendLayout()
        CType(Me.txtCard5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCard4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCard3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCard2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCard1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpCustomersPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCustomersPoint.SuspendLayout()
        CType(Me.GridCustPointHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCustPointHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCGift, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCGift.SuspendLayout()
        CType(Me.GridGift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewGift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCSponsorShip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCSponsorShip.SuspendLayout()
        CType(Me.GridGodFather, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridviewGodFather, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryISponsorGodCustomers_id, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPurchase.SuspendLayout()
        CType(Me.GridShoppingOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewShoppingOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCompensation.SuspendLayout()
        CType(Me.GridCompensation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCompensation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProductsRating.SuspendLayout()
        CType(Me.GridProductsRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewProductsRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSuspendedHistory.SuspendLayout()
        CType(Me.GridSuspendedHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSuspendedHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabVodView.SuspendLayout()
        CType(Me.GridViewVod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCritiques.SuspendLayout()
        CType(Me.GridCritiques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCritiques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConfig.SuspendLayout()
        CType(Me.ChkListConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit4.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit13.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit15.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit16.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit17.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit18.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit5.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit19.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit20.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit6.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit21.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit22.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit23.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.StatusBar1.Location = New System.Drawing.Point(0, 864)
        Me.StatusBar1.Size = New System.Drawing.Size(1262, 10)
        '
        'coldvd_finally_arrived_mail3
        '
        coldvd_finally_arrived_mail3.Caption = "dvd_finally_arrived_mail"
        coldvd_finally_arrived_mail3.FieldName = "dvd_finally_arrived_mail"
        coldvd_finally_arrived_mail3.Name = "coldvd_finally_arrived_mail3"
        coldvd_finally_arrived_mail3.OptionsColumn.AllowEdit = False
        coldvd_finally_arrived_mail3.OptionsColumn.ReadOnly = True
        '
        'GridchkAbo
        '
        GridchkAbo.AutoHeight = False
        GridchkAbo.Name = "GridchkAbo"
        GridchkAbo.ValueChecked = 1
        GridchkAbo.ValueUnchecked = 0
        '
        'GridchkBlackList
        '
        GridchkBlackList.AutoHeight = False
        GridchkBlackList.Name = "GridchkBlackList"
        GridchkBlackList.ValueChecked = 1
        GridchkBlackList.ValueUnchecked = 0
        '
        'ColTypePayment
        '
        ColTypePayment.Caption = "type payment "
        ColTypePayment.FieldName = "type_payment"
        ColTypePayment.Name = "ColTypePayment"
        ColTypePayment.Visible = True
        ColTypePayment.VisibleIndex = 0
        ColTypePayment.Width = 81
        '
        'ColPayment_id
        '
        ColPayment_id.Caption = "ID"
        ColPayment_id.FieldName = "id"
        ColPayment_id.Name = "ColPayment_id"
        ColPayment_id.Visible = True
        ColPayment_id.VisibleIndex = 1
        '
        'ColAmountPay
        '
        ColAmountPay.Caption = "amount"
        ColAmountPay.FieldName = "amount"
        ColAmountPay.Name = "ColAmountPay"
        ColAmountPay.Visible = True
        ColAmountPay.VisibleIndex = 2
        '
        'ColDateAdded
        '
        ColDateAdded.Caption = "date_added"
        ColDateAdded.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        ColDateAdded.FieldName = "date_added"
        ColDateAdded.Name = "ColDateAdded"
        ColDateAdded.Visible = True
        ColDateAdded.VisibleIndex = 4
        '
        'ColIdMatching
        '
        ColIdMatching.Caption = "id matching"
        ColIdMatching.FieldName = "id_matching"
        ColIdMatching.Name = "ColIdMatching"
        ColIdMatching.Visible = True
        ColIdMatching.VisibleIndex = 8
        '
        'txtNextPrice
        '
        Me.txtNextPrice.Enabled = False
        Me.txtNextPrice.Location = New System.Drawing.Point(889, 37)
        Me.txtNextPrice.Name = "txtNextPrice"
        Me.txtNextPrice.Properties.ReadOnly = True
        Me.txtNextPrice.Size = New System.Drawing.Size(79, 20)
        Me.txtNextPrice.TabIndex = 23
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsCustomerMaint"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.GridSon.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryISponsorCustomers_id})
        Me.GridSon.Size = New System.Drawing.Size(610, 229)
        Me.GridSon.TabIndex = 0
        Me.GridSon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSon, Me.GridViewGodson})
        '
        'GridViewSon
        '
        Me.GridViewSon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.used_date, Me.colSon_id, Me.son_abo_type, Me.points, Me.customers_lastname, Me.customers_firstname})
        Me.GridViewSon.CustomizationFormBounds = New System.Drawing.Rectangle(1382, 593, 218, 205)
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
        Me.used_date.VisibleIndex = 1
        Me.used_date.Width = 70
        '
        'colSon_id
        '
        Me.colSon_id.Caption = "customers_id"
        Me.colSon_id.ColumnEdit = Me.RepositoryISponsorCustomers_id
        Me.colSon_id.FieldName = "customers_id"
        Me.colSon_id.Name = "colSon_id"
        Me.colSon_id.Visible = True
        Me.colSon_id.VisibleIndex = 0
        '
        'RepositoryISponsorCustomers_id
        '
        Me.RepositoryISponsorCustomers_id.AutoHeight = False
        Me.RepositoryISponsorCustomers_id.Name = "RepositoryISponsorCustomers_id"
        '
        'son_abo_type
        '
        Me.son_abo_type.Caption = "abo_type"
        Me.son_abo_type.FieldName = "son_abo_type"
        Me.son_abo_type.Name = "son_abo_type"
        Me.son_abo_type.OptionsColumn.AllowEdit = False
        Me.son_abo_type.Visible = True
        Me.son_abo_type.VisibleIndex = 4
        Me.son_abo_type.Width = 107
        '
        'points
        '
        Me.points.Caption = "points"
        Me.points.FieldName = "points"
        Me.points.Name = "points"
        Me.points.OptionsColumn.AllowEdit = False
        Me.points.Visible = True
        Me.points.VisibleIndex = 5
        Me.points.Width = 41
        '
        'customers_lastname
        '
        Me.customers_lastname.Caption = "customers_lastname"
        Me.customers_lastname.FieldName = "customers_lastname"
        Me.customers_lastname.Name = "customers_lastname"
        Me.customers_lastname.OptionsColumn.AllowEdit = False
        Me.customers_lastname.Visible = True
        Me.customers_lastname.VisibleIndex = 2
        Me.customers_lastname.Width = 142
        '
        'customers_firstname
        '
        Me.customers_firstname.Caption = "customers_firstname"
        Me.customers_firstname.FieldName = "customers_firstname"
        Me.customers_firstname.Name = "customers_firstname"
        Me.customers_firstname.OptionsColumn.AllowEdit = False
        Me.customers_firstname.Visible = True
        Me.customers_firstname.VisibleIndex = 3
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
        'tabMailHistory
        '
        Me.tabMailHistory.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMailHistory.Appearance.Header.Options.UseFont = True
        Me.tabMailHistory.AutoScroll = True
        Me.tabMailHistory.Controls.Add(Me.browser)
        Me.tabMailHistory.Controls.Add(Me.grpContEmail)
        Me.tabMailHistory.Name = "tabMailHistory"
        Me.tabMailHistory.Size = New System.Drawing.Size(1253, 783)
        Me.tabMailHistory.Text = "mail history"
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
        Me.grpContEmail.Size = New System.Drawing.Size(1166, 350)
        Me.grpContEmail.TabIndex = 16
        Me.grpContEmail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewMail})
        '
        'GridViewMail
        '
        Me.GridViewMail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.messages_subject, Me.messages_title, Me.mail_opened_date, Me.mail_opened, Me.date_sended, Me.messages_html, Me.GCMail_id})
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
        Me.messages_subject.Width = 433
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
        Me.messages_title.Width = 551
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
        Me.mail_opened_date.Width = 258
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
        Me.mail_opened.Width = 163
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
        Me.date_sended.Width = 215
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
        'GCMail_id
        '
        Me.GCMail_id.Caption = "Mail_id"
        Me.GCMail_id.FieldName = "mail_messages_id"
        Me.GCMail_id.Name = "GCMail_id"
        Me.GCMail_id.Width = 108
        '
        'GridCustServ
        '
        Me.GridCustServ.Dock = System.Windows.Forms.DockStyle.Left
        Me.GridCustServ.EmbeddedNavigator.Name = ""
        Me.GridCustServ.FormsUseDefaultLookAndFeel = False
        Me.GridCustServ.Location = New System.Drawing.Point(0, 0)
        Me.GridCustServ.MainView = Me.gridViewCustServ
        Me.GridCustServ.Name = "GridCustServ"
        Me.GridCustServ.Size = New System.Drawing.Size(672, 783)
        Me.GridCustServ.TabIndex = 1
        Me.GridCustServ.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewCustServ})
        '
        'gridViewCustServ
        '
        Me.gridViewCustServ.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcustserv2_id, Me.colcustomers2_id6, Me.collanguage2_id, Me.custserv_cat_name2, Me.colcustomer2_date, Me.colorders2_id1, Me.colproducts2_id2, Me.coldvd2_id, Me.colsubject3, Me.colmessage3, Me.coladmindate3, Me.coladminmessage3, Me.colmessagesent3, coldvd_finally_arrived_mail3})
        Me.gridViewCustServ.CustomizationFormBounds = New System.Drawing.Rectangle(1384, 542, 216, 178)
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
        Me.colcustomer2_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
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
        'tabPaymentMovements
        '
        Me.tabPaymentMovements.Controls.Add(Me.GCBankAccountMovement)
        Me.tabPaymentMovements.Name = "tabPaymentMovements"
        Me.tabPaymentMovements.Size = New System.Drawing.Size(1253, 783)
        Me.tabPaymentMovements.Text = "Payment Movements"
        '
        'GCBankAccountMovement
        '
        Me.GCBankAccountMovement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCBankAccountMovement.Controls.Add(Me.GridBankAccountMovements)
        Me.GCBankAccountMovement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCBankAccountMovement.Location = New System.Drawing.Point(0, 0)
        Me.GCBankAccountMovement.Name = "GCBankAccountMovement"
        Me.GCBankAccountMovement.Size = New System.Drawing.Size(1253, 783)
        Me.GCBankAccountMovement.TabIndex = 1
        Me.GCBankAccountMovement.Text = "Bank Account movements"
        '
        'GridBankAccountMovements
        '
        Me.GridBankAccountMovements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBankAccountMovements.EmbeddedNavigator.Name = ""
        Me.GridBankAccountMovements.FormsUseDefaultLookAndFeel = False
        Me.GridBankAccountMovements.Location = New System.Drawing.Point(2, 20)
        Me.GridBankAccountMovements.MainView = Me.GridViewBankAccountMovements
        Me.GridBankAccountMovements.Name = "GridBankAccountMovements"
        Me.GridBankAccountMovements.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryCmbMatching})
        Me.GridBankAccountMovements.Size = New System.Drawing.Size(1249, 761)
        Me.GridBankAccountMovements.TabIndex = 5
        Me.GridBankAccountMovements.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewBankAccountMovements})
        '
        'GridViewBankAccountMovements
        '
        Me.GridViewBankAccountMovements.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIsmatching, Me.colBankAccountMovements_id, Me.coldate_coda_created, Me.colCodaFilename, Me.colamount2, Me.coldvdpost_bank_account, Me.colcommunicationStr, Me.GridColumn1, Me.colStructuredComm12, Me.colCounterpartdetails, Me.ColCommunication_type, Me.colEntireData, Me.colBankAccountClient, Me.colBankAccount_Customers_id, Me.colBankAccount_Comment})
        Me.GridViewBankAccountMovements.CustomizationFormBounds = New System.Drawing.Rectangle(1113, 176, 327, 364)
        Me.GridViewBankAccountMovements.GridControl = Me.GridBankAccountMovements
        Me.GridViewBankAccountMovements.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewBankAccountMovements.Name = "GridViewBankAccountMovements"
        Me.GridViewBankAccountMovements.OptionsSelection.MultiSelect = True
        Me.GridViewBankAccountMovements.OptionsView.ColumnAutoWidth = False
        Me.GridViewBankAccountMovements.OptionsView.ShowFooter = True
        '
        'colIsmatching
        '
        Me.colIsmatching.Caption = "Open payment"
        Me.colIsmatching.ColumnEdit = Me.RepositoryCmbMatching
        Me.colIsmatching.FieldName = "ismatching"
        Me.colIsmatching.Name = "colIsmatching"
        Me.colIsmatching.OptionsColumn.AllowEdit = False
        Me.colIsmatching.OptionsColumn.ReadOnly = True
        Me.colIsmatching.Visible = True
        Me.colIsmatching.VisibleIndex = 3
        '
        'RepositoryCmbMatching
        '
        Me.RepositoryCmbMatching.AutoHeight = False
        Me.RepositoryCmbMatching.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryCmbMatching.DisplayMember = "name"
        Me.RepositoryCmbMatching.Name = "RepositoryCmbMatching"
        Me.RepositoryCmbMatching.NullText = ""
        Me.RepositoryCmbMatching.ValueMember = "id"
        '
        'colBankAccountMovements_id
        '
        Me.colBankAccountMovements_id.Caption = "id"
        Me.colBankAccountMovements_id.FieldName = "account_movements_id"
        Me.colBankAccountMovements_id.Name = "colBankAccountMovements_id"
        Me.colBankAccountMovements_id.OptionsColumn.AllowEdit = False
        Me.colBankAccountMovements_id.OptionsColumn.ReadOnly = True
        Me.colBankAccountMovements_id.Visible = True
        Me.colBankAccountMovements_id.VisibleIndex = 0
        '
        'coldate_coda_created
        '
        Me.coldate_coda_created.Caption = "date_added"
        Me.coldate_coda_created.DisplayFormat.FormatString = "d"
        Me.coldate_coda_created.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldate_coda_created.FieldName = "date_coda_created"
        Me.coldate_coda_created.Name = "coldate_coda_created"
        Me.coldate_coda_created.OptionsColumn.AllowEdit = False
        Me.coldate_coda_created.OptionsColumn.ReadOnly = True
        Me.coldate_coda_created.Visible = True
        Me.coldate_coda_created.VisibleIndex = 4
        Me.coldate_coda_created.Width = 105
        '
        'colCodaFilename
        '
        Me.colCodaFilename.Caption = "filename"
        Me.colCodaFilename.FieldName = "coda_filename"
        Me.colCodaFilename.Name = "colCodaFilename"
        Me.colCodaFilename.OptionsColumn.AllowEdit = False
        Me.colCodaFilename.OptionsColumn.ReadOnly = True
        Me.colCodaFilename.Visible = True
        Me.colCodaFilename.VisibleIndex = 12
        '
        'colamount2
        '
        Me.colamount2.Caption = "amount"
        Me.colamount2.FieldName = "Amount"
        Me.colamount2.Name = "colamount2"
        Me.colamount2.OptionsColumn.AllowEdit = False
        Me.colamount2.OptionsColumn.ReadOnly = True
        Me.colamount2.Visible = True
        Me.colamount2.VisibleIndex = 7
        Me.colamount2.Width = 84
        '
        'coldvdpost_bank_account
        '
        Me.coldvdpost_bank_account.Caption = "dvdpost_bank_account"
        Me.coldvdpost_bank_account.FieldName = "dvdpost_bank_account"
        Me.coldvdpost_bank_account.Name = "coldvdpost_bank_account"
        Me.coldvdpost_bank_account.OptionsColumn.AllowEdit = False
        Me.coldvdpost_bank_account.OptionsColumn.ReadOnly = True
        Me.coldvdpost_bank_account.Visible = True
        Me.coldvdpost_bank_account.VisibleIndex = 13
        '
        'colcommunicationStr
        '
        Me.colcommunicationStr.Caption = "Str communication"
        Me.colcommunicationStr.FieldName = "Communication"
        Me.colcommunicationStr.Name = "colcommunicationStr"
        Me.colcommunicationStr.OptionsColumn.AllowEdit = False
        Me.colcommunicationStr.OptionsColumn.ReadOnly = True
        Me.colcommunicationStr.Visible = True
        Me.colcommunicationStr.VisibleIndex = 11
        Me.colcommunicationStr.Width = 240
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Num Dom"
        Me.GridColumn1.FieldName = "Communication2"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 8
        Me.GridColumn1.Width = 124
        '
        'colStructuredComm12
        '
        Me.colStructuredComm12.Caption = "communication struct"
        Me.colStructuredComm12.FieldName = "structuredComm12"
        Me.colStructuredComm12.Name = "colStructuredComm12"
        Me.colStructuredComm12.OptionsColumn.AllowEdit = False
        Me.colStructuredComm12.OptionsColumn.ReadOnly = True
        Me.colStructuredComm12.Visible = True
        Me.colStructuredComm12.VisibleIndex = 9
        Me.colStructuredComm12.Width = 113
        '
        'colCounterpartdetails
        '
        Me.colCounterpartdetails.Caption = "Info Client"
        Me.colCounterpartdetails.FieldName = "CounterpartDetails"
        Me.colCounterpartdetails.Name = "colCounterpartdetails"
        Me.colCounterpartdetails.OptionsColumn.AllowEdit = False
        Me.colCounterpartdetails.OptionsColumn.ReadOnly = True
        Me.colCounterpartdetails.Visible = True
        Me.colCounterpartdetails.VisibleIndex = 6
        Me.colCounterpartdetails.Width = 180
        '
        'ColCommunication_type
        '
        Me.ColCommunication_type.Caption = "type communication "
        Me.ColCommunication_type.FieldName = "communication_type"
        Me.ColCommunication_type.Name = "ColCommunication_type"
        Me.ColCommunication_type.OptionsColumn.AllowEdit = False
        Me.ColCommunication_type.OptionsColumn.ReadOnly = True
        Me.ColCommunication_type.Visible = True
        Me.ColCommunication_type.VisibleIndex = 10
        '
        'colEntireData
        '
        Me.colEntireData.Caption = "entireData"
        Me.colEntireData.FieldName = "EntireData"
        Me.colEntireData.Name = "colEntireData"
        Me.colEntireData.OptionsColumn.AllowEdit = False
        Me.colEntireData.Visible = True
        Me.colEntireData.VisibleIndex = 14
        '
        'colBankAccountClient
        '
        Me.colBankAccountClient.Caption = "BankAccountClient"
        Me.colBankAccountClient.FieldName = "BankAccountCounterpart"
        Me.colBankAccountClient.Name = "colBankAccountClient"
        Me.colBankAccountClient.OptionsColumn.AllowEdit = False
        Me.colBankAccountClient.Visible = True
        Me.colBankAccountClient.VisibleIndex = 5
        Me.colBankAccountClient.Width = 111
        '
        'colBankAccount_Customers_id
        '
        Me.colBankAccount_Customers_id.Caption = "customers_id"
        Me.colBankAccount_Customers_id.FieldName = "customers_id"
        Me.colBankAccount_Customers_id.Name = "colBankAccount_Customers_id"
        Me.colBankAccount_Customers_id.Visible = True
        Me.colBankAccount_Customers_id.VisibleIndex = 1
        Me.colBankAccount_Customers_id.Width = 97
        '
        'colBankAccount_Comment
        '
        Me.colBankAccount_Comment.Caption = "comment"
        Me.colBankAccount_Comment.FieldName = "comment"
        Me.colBankAccount_Comment.Name = "colBankAccount_Comment"
        Me.colBankAccount_Comment.Visible = True
        Me.colBankAccount_Comment.VisibleIndex = 2
        Me.colBankAccount_Comment.Width = 154
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
        Me.GridABO.Size = New System.Drawing.Size(1253, 783)
        Me.GridABO.TabIndex = 0
        Me.GridABO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewABO})
        '
        'GridViewABO
        '
        Me.GridViewABO.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand4})
        Me.GridViewABO.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colcustomerid, Me.colAction, Me.colcode_id, Me.colDate, Me.colproduct_id1, Me.colpayment_method, Me.colprivilege_notified, Me.colsite})
        Me.GridViewABO.CustomizationFormBounds = New System.Drawing.Rectangle(1383, 422, 217, 222)
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
        Me.colAction.FieldName = "Action"
        Me.colAction.Name = "colAction"
        Me.colAction.OptionsColumn.AllowEdit = False
        Me.colAction.OptionsColumn.ReadOnly = True
        Me.colAction.Visible = True
        Me.colAction.Width = 135
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
        'ColLast_status
        '
        Me.ColLast_status.Caption = "last_status"
        Me.ColLast_status.FieldName = "last_status"
        Me.ColLast_status.Name = "ColLast_status"
        Me.ColLast_status.OptionsColumn.AllowEdit = False
        '
        'colDate_closed
        '
        Me.colDate_closed.Caption = "date_closed"
        Me.colDate_closed.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.colDate_closed.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDate_closed.FieldName = "date_closed"
        Me.colDate_closed.Name = "colDate_closed"
        Me.colDate_closed.OptionsColumn.AllowEdit = False
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.DisplayMember = "name"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.ValueMember = "id"
        '
        'colDomNumber
        '
        Me.colDomNumber.Caption = "domiciliation_number"
        Me.colDomNumber.FieldName = "domiciliation_number"
        Me.colDomNumber.Name = "colDomNumber"
        Me.colDomNumber.OptionsColumn.AllowEdit = False
        Me.colDomNumber.Width = 132
        '
        'colabopay_id
        '
        Me.colabopay_id.Caption = "abo_id"
        Me.colabopay_id.FieldName = "abo_id"
        Me.colabopay_id.Name = "colabopay_id"
        Me.colabopay_id.OptionsColumn.AllowEdit = False
        '
        'tabPayment
        '
        Me.tabPayment.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tabPayment.Appearance.Header.Options.UseFont = True
        Me.tabPayment.Controls.Add(Me.GridPayment)
        Me.tabPayment.Controls.Add(Me.BtnPaid)
        Me.tabPayment.Controls.Add(Me.btnLoadPayment)
        Me.tabPayment.Controls.Add(Me.checkOpenPayment)
        Me.tabPayment.Controls.Add(Me.GroupOgone)
        Me.tabPayment.Controls.Add(Me.BtnCancelPayment)
        Me.tabPayment.Controls.Add(Me.CalcEdit1)
        Me.tabPayment.Controls.Add(Me.LabelControl48)
        Me.tabPayment.Controls.Add(Me.CalcEdit)
        Me.tabPayment.Controls.Add(Me.LabelControl49)
        Me.tabPayment.Controls.Add(Me.cmbPayMethod)
        Me.tabPayment.Controls.Add(Me.LabelControl50)
        Me.tabPayment.Name = "tabPayment"
        Me.tabPayment.Size = New System.Drawing.Size(1253, 783)
        Me.tabPayment.Text = "Invoices"
        '
        'GridPayment
        '
        Me.GridPayment.EmbeddedNavigator.Name = ""
        Me.GridPayment.FormsUseDefaultLookAndFeel = False
        Me.GridPayment.Location = New System.Drawing.Point(3, 233)
        Me.GridPayment.MainView = Me.GridViewPayment
        Me.GridPayment.Name = "GridPayment"
        Me.GridPayment.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit5})
        Me.GridPayment.Size = New System.Drawing.Size(1150, 449)
        Me.GridPayment.TabIndex = 61
        Me.GridPayment.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPayment})
        '
        'GridViewPayment
        '
        Me.GridViewPayment.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {ColTypePayment, ColPayment_id, ColAmountPay, ColDateAdded, Me.ColLastModified, Me.ColCommunicationPay, Me.ColCustomersID, Me.colPayment_status, ColIdMatching, Me.ColLast_status, Me.colDate_closed, Me.colDomNumber, Me.colabopay_id})
        Me.GridViewPayment.CustomizationFormBounds = New System.Drawing.Rectangle(1273, 240, 327, 364)
        Me.GridViewPayment.GridControl = Me.GridPayment
        Me.GridViewPayment.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewPayment.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridViewPayment.Name = "GridViewPayment"
        Me.GridViewPayment.OptionsSelection.MultiSelect = True
        Me.GridViewPayment.OptionsView.ColumnAutoWidth = False
        Me.GridViewPayment.OptionsView.ShowFooter = True
        '
        'ColLastModified
        '
        Me.ColLastModified.Caption = "Last modified"
        Me.ColLastModified.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.ColLastModified.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColLastModified.FieldName = "last_modified"
        Me.ColLastModified.Name = "ColLastModified"
        Me.ColLastModified.OptionsColumn.AllowEdit = False
        Me.ColLastModified.OptionsColumn.ReadOnly = True
        Me.ColLastModified.Visible = True
        Me.ColLastModified.VisibleIndex = 5
        '
        'ColCommunicationPay
        '
        Me.ColCommunicationPay.Caption = "communication"
        Me.ColCommunicationPay.FieldName = "communication"
        Me.ColCommunicationPay.Name = "ColCommunicationPay"
        Me.ColCommunicationPay.OptionsColumn.AllowEdit = False
        Me.ColCommunicationPay.OptionsColumn.ReadOnly = True
        Me.ColCommunicationPay.Visible = True
        Me.ColCommunicationPay.VisibleIndex = 6
        Me.ColCommunicationPay.Width = 101
        '
        'ColCustomersID
        '
        Me.ColCustomersID.Caption = "customers_id"
        Me.ColCustomersID.FieldName = "customers_id"
        Me.ColCustomersID.Name = "ColCustomersID"
        Me.ColCustomersID.OptionsColumn.AllowEdit = False
        Me.ColCustomersID.OptionsColumn.ReadOnly = True
        Me.ColCustomersID.Visible = True
        Me.ColCustomersID.VisibleIndex = 3
        Me.ColCustomersID.Width = 112
        '
        'colPayment_status
        '
        Me.colPayment_status.Caption = "Payment_Status"
        Me.colPayment_status.FieldName = "payment_status"
        Me.colPayment_status.Name = "colPayment_status"
        Me.colPayment_status.OptionsColumn.AllowEdit = False
        Me.colPayment_status.OptionsColumn.ReadOnly = True
        Me.colPayment_status.Visible = True
        Me.colPayment_status.VisibleIndex = 7
        Me.colPayment_status.Width = 105
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
        'tabCustServ
        '
        Me.tabCustServ.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tabCustServ.Appearance.Header.Options.UseFont = True
        Me.tabCustServ.Controls.Add(Me.PanelControl7)
        Me.tabCustServ.Controls.Add(Me.SPlitCCustserv)
        Me.tabCustServ.Controls.Add(Me.GridCustServ)
        Me.tabCustServ.Name = "tabCustServ"
        Me.tabCustServ.PageEnabled = False
        Me.tabCustServ.PageVisible = False
        Me.tabCustServ.Size = New System.Drawing.Size(1253, 783)
        Me.tabCustServ.Text = "Cust Serv"
        '
        'PanelControl7
        '
        Me.PanelControl7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl7.Controls.Add(Me.PanelControl8)
        Me.PanelControl7.Controls.Add(Me.GCCustServ)
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl7.Location = New System.Drawing.Point(678, 0)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(575, 783)
        Me.PanelControl7.TabIndex = 3
        '
        'PanelControl8
        '
        Me.PanelControl8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl8.Controls.Add(Me.LayoutCustServ)
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl8.Location = New System.Drawing.Point(2, 65)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(571, 716)
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
        Me.LayoutCustServ.Size = New System.Drawing.Size(567, 712)
        Me.LayoutCustServ.TabIndex = 0
        Me.LayoutCustServ.Text = "DataLayoutControl1"
        '
        'txtCustServ_Response_Message
        '
        Me.txtCustServ_Response_Message.Location = New System.Drawing.Point(107, 454)
        Me.txtCustServ_Response_Message.Name = "txtCustServ_Response_Message"
        Me.txtCustServ_Response_Message.Size = New System.Drawing.Size(451, 249)
        Me.txtCustServ_Response_Message.StyleController = Me.LayoutCustServ
        Me.txtCustServ_Response_Message.TabIndex = 14
        '
        'txtCustServ_DVD_ID
        '
        Me.txtCustServ_DVD_ID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "custserv.dvd_id", True))
        Me.txtCustServ_DVD_ID.Location = New System.Drawing.Point(479, 368)
        Me.txtCustServ_DVD_ID.Name = "txtCustServ_DVD_ID"
        Me.txtCustServ_DVD_ID.Properties.ReadOnly = True
        Me.txtCustServ_DVD_ID.Size = New System.Drawing.Size(79, 20)
        Me.txtCustServ_DVD_ID.StyleController = Me.LayoutCustServ
        Me.txtCustServ_DVD_ID.TabIndex = 11
        '
        'txtCustServ_Products_id
        '
        Me.txtCustServ_Products_id.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "custserv.products_id", True))
        Me.txtCustServ_Products_id.Location = New System.Drawing.Point(293, 368)
        Me.txtCustServ_Products_id.Name = "txtCustServ_Products_id"
        Me.txtCustServ_Products_id.Properties.ReadOnly = True
        Me.txtCustServ_Products_id.Size = New System.Drawing.Size(78, 20)
        Me.txtCustServ_Products_id.StyleController = Me.LayoutCustServ
        Me.txtCustServ_Products_id.TabIndex = 10
        '
        'txtCustServ_OrderID
        '
        Me.txtCustServ_OrderID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "custserv.orders_id", True))
        Me.txtCustServ_OrderID.Location = New System.Drawing.Point(107, 368)
        Me.txtCustServ_OrderID.Name = "txtCustServ_OrderID"
        Me.txtCustServ_OrderID.Properties.ReadOnly = True
        Me.txtCustServ_OrderID.Size = New System.Drawing.Size(78, 20)
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
        Me.txtCustServ_CustDate.Size = New System.Drawing.Size(451, 20)
        Me.txtCustServ_CustDate.StyleController = Me.LayoutCustServ
        Me.txtCustServ_CustDate.TabIndex = 8
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Location = New System.Drawing.Point(107, 59)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.ReadOnly = True
        Me.MemoEdit1.Size = New System.Drawing.Size(451, 274)
        Me.MemoEdit1.StyleController = Me.LayoutCustServ
        Me.MemoEdit1.TabIndex = 7
        '
        'txtCustServ_Subject
        '
        Me.txtCustServ_Subject.Location = New System.Drawing.Point(104, 402)
        Me.txtCustServ_Subject.Name = "txtCustServ_Subject"
        Me.txtCustServ_Subject.Size = New System.Drawing.Size(457, 20)
        Me.txtCustServ_Subject.StyleController = Me.LayoutCustServ
        Me.txtCustServ_Subject.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LCGMisc, Me.LayoutControlGroup3, Me.LCGResponse, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(567, 712)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LCGMisc
        '
        Me.LCGMisc.CustomizationFormText = "Misc"
        Me.LCGMisc.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem6, Me.LayoutControlItem8})
        Me.LCGMisc.Location = New System.Drawing.Point(0, 340)
        Me.LCGMisc.Name = "LCGMisc"
        Me.LCGMisc.Size = New System.Drawing.Size(565, 55)
        Me.LCGMisc.Text = "Misc"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtCustServ_Products_id
        Me.LayoutControlItem7.CustomizationFormText = "Products ID"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(186, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(186, 31)
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
        Me.LayoutControlItem6.Size = New System.Drawing.Size(186, 31)
        Me.LayoutControlItem6.Text = "Order ID"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(92, 20)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtCustServ_DVD_ID
        Me.LayoutControlItem8.CustomizationFormText = "DVD ID"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(372, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(187, 31)
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
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(565, 340)
        Me.LayoutControlGroup3.Text = "Call / E-Mail Info"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtCustServ_CustDate
        Me.LayoutControlItem5.CustomizationFormText = "Date"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(559, 31)
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
        Me.LayoutControlItem4.Size = New System.Drawing.Size(559, 285)
        Me.LayoutControlItem4.Text = "Message"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(92, 20)
        '
        'LCGResponse
        '
        Me.LCGResponse.CustomizationFormText = "Response"
        Me.LCGResponse.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11})
        Me.LCGResponse.Location = New System.Drawing.Point(0, 426)
        Me.LCGResponse.Name = "LCGResponse"
        Me.LCGResponse.Size = New System.Drawing.Size(565, 284)
        Me.LCGResponse.Text = "Response"
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtCustServ_Response_Message
        Me.LayoutControlItem11.CustomizationFormText = "Response Message"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(559, 260)
        Me.LayoutControlItem11.Text = "Response Message"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(92, 20)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtCustServ_Subject
        Me.LayoutControlItem3.CustomizationFormText = "Subject"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 395)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(565, 31)
        Me.LayoutControlItem3.Text = "Subject"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(92, 20)
        '
        'GCCustServ
        '
        Me.GCCustServ.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCCustServ.Controls.Add(Me.chkCustServSendMail)
        Me.GCCustServ.Controls.Add(Me.btnSaveCustServ)
        Me.GCCustServ.Dock = System.Windows.Forms.DockStyle.Top
        Me.GCCustServ.Location = New System.Drawing.Point(2, 2)
        Me.GCCustServ.Name = "GCCustServ"
        Me.GCCustServ.Size = New System.Drawing.Size(571, 63)
        Me.GCCustServ.TabIndex = 0
        Me.GCCustServ.Text = "Call / Action Detail"
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
        'SPlitCCustserv
        '
        Me.SPlitCCustserv.Location = New System.Drawing.Point(672, 0)
        Me.SPlitCCustserv.Name = "SPlitCCustserv"
        Me.SPlitCCustserv.Size = New System.Drawing.Size(6, 783)
        Me.SPlitCCustserv.TabIndex = 2
        Me.SPlitCCustserv.TabStop = False
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
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.FormsUseDefaultLookAndFeel = False
        Me.GridControl1.Location = New System.Drawing.Point(0, 176)
        Me.GridControl1.MainView = Me.GridViewSearch
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {GridchkAbo, GridchkBlackList, Me.RepositoryICustomersCustomers_id})
        Me.GridControl1.Size = New System.Drawing.Size(1253, 607)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSearch})
        '
        'GridViewSearch
        '
        Me.GridViewSearch.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridViewSearch.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colcustomers_firstname, Me.colcustomers_lastname, Me.colcustomers_email_address, Me.colcustomers_abo, Me.colentry_postcode, Me.col2customers_id, Me.colcustomers_language, Me.call_phone, Me.colentry_street_address, Me.phone_activation_id})
        Me.GridViewSearch.CustomizationFormBounds = New System.Drawing.Rectangle(1357, 529, 225, 209)
        Me.GridViewSearch.GridControl = Me.GridControl1
        Me.GridViewSearch.Name = "GridViewSearch"
        Me.GridViewSearch.OptionsView.ShowAutoFilterRow = True
        Me.GridViewSearch.OptionsView.ShowBands = False
        Me.GridViewSearch.OptionsView.ShowFooter = True
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.phone_activation_id)
        Me.GridBand1.Columns.Add(Me.col2customers_id)
        Me.GridBand1.Columns.Add(Me.colcustomers_firstname)
        Me.GridBand1.Columns.Add(Me.colcustomers_lastname)
        Me.GridBand1.Columns.Add(Me.colcustomers_email_address)
        Me.GridBand1.Columns.Add(Me.colentry_postcode)
        Me.GridBand1.Columns.Add(Me.colentry_street_address)
        Me.GridBand1.Columns.Add(Me.colcustomers_language)
        Me.GridBand1.Columns.Add(Me.call_phone)
        Me.GridBand1.Columns.Add(Me.colcustomers_abo)
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 1005
        '
        'phone_activation_id
        '
        Me.phone_activation_id.Caption = "phone_activation_id"
        Me.phone_activation_id.FieldName = "phone_activation_id"
        Me.phone_activation_id.Name = "phone_activation_id"
        '
        'col2customers_id
        '
        Me.col2customers_id.Caption = "customers_id"
        Me.col2customers_id.ColumnEdit = Me.RepositoryICustomersCustomers_id
        Me.col2customers_id.FieldName = "customers_id"
        Me.col2customers_id.Name = "col2customers_id"
        Me.col2customers_id.Visible = True
        Me.col2customers_id.Width = 90
        '
        'RepositoryICustomersCustomers_id
        '
        Me.RepositoryICustomersCustomers_id.AutoHeight = False
        Me.RepositoryICustomersCustomers_id.Name = "RepositoryICustomersCustomers_id"
        '
        'colcustomers_firstname
        '
        Me.colcustomers_firstname.Caption = "firstname"
        Me.colcustomers_firstname.FieldName = "customers_firstname"
        Me.colcustomers_firstname.Name = "colcustomers_firstname"
        Me.colcustomers_firstname.OptionsColumn.AllowEdit = False
        Me.colcustomers_firstname.Visible = True
        Me.colcustomers_firstname.Width = 120
        '
        'colcustomers_lastname
        '
        Me.colcustomers_lastname.Caption = "lastname"
        Me.colcustomers_lastname.FieldName = "customers_lastname"
        Me.colcustomers_lastname.Name = "colcustomers_lastname"
        Me.colcustomers_lastname.OptionsColumn.AllowEdit = False
        Me.colcustomers_lastname.Visible = True
        Me.colcustomers_lastname.Width = 118
        '
        'colcustomers_email_address
        '
        Me.colcustomers_email_address.Caption = "email"
        Me.colcustomers_email_address.FieldName = "email"
        Me.colcustomers_email_address.Name = "colcustomers_email_address"
        Me.colcustomers_email_address.OptionsColumn.AllowEdit = False
        Me.colcustomers_email_address.Visible = True
        Me.colcustomers_email_address.Width = 143
        '
        'colentry_postcode
        '
        Me.colentry_postcode.Caption = "postcode"
        Me.colentry_postcode.FieldName = "entry_postcode"
        Me.colentry_postcode.Name = "colentry_postcode"
        Me.colentry_postcode.OptionsColumn.AllowEdit = False
        Me.colentry_postcode.Visible = True
        Me.colentry_postcode.Width = 96
        '
        'colentry_street_address
        '
        Me.colentry_street_address.Caption = "address"
        Me.colentry_street_address.FieldName = "entry_street_address"
        Me.colentry_street_address.Name = "colentry_street_address"
        Me.colentry_street_address.OptionsColumn.AllowEdit = False
        Me.colentry_street_address.OptionsColumn.ReadOnly = True
        Me.colentry_street_address.Visible = True
        Me.colentry_street_address.Width = 191
        '
        'colcustomers_language
        '
        Me.colcustomers_language.Caption = "language"
        Me.colcustomers_language.FieldName = "customers_language"
        Me.colcustomers_language.Name = "colcustomers_language"
        Me.colcustomers_language.OptionsColumn.AllowEdit = False
        Me.colcustomers_language.Visible = True
        Me.colcustomers_language.Width = 52
        '
        'call_phone
        '
        Me.call_phone.Caption = "phone"
        Me.call_phone.FieldName = "call_phone"
        Me.call_phone.Name = "call_phone"
        Me.call_phone.OptionsColumn.AllowEdit = False
        Me.call_phone.Visible = True
        Me.call_phone.Width = 105
        '
        'colcustomers_abo
        '
        Me.colcustomers_abo.Caption = "abo"
        Me.colcustomers_abo.ColumnEdit = GridchkAbo
        Me.colcustomers_abo.FieldName = "customers_abo"
        Me.colcustomers_abo.Name = "colcustomers_abo"
        Me.colcustomers_abo.OptionsColumn.AllowEdit = False
        Me.colcustomers_abo.Visible = True
        Me.colcustomers_abo.Width = 90
        '
        'tabAboHistory
        '
        Me.tabAboHistory.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tabAboHistory.Appearance.Header.Options.UseFont = True
        Me.tabAboHistory.Controls.Add(Me.GridABO)
        Me.tabAboHistory.Name = "tabAboHistory"
        Me.tabAboHistory.Size = New System.Drawing.Size(1253, 783)
        Me.tabAboHistory.Text = "ABO History"
        '
        'tabMain
        '
        Me.tabMain.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.Appearance.Header.Options.UseFont = True
        Me.tabMain.AutoScroll = True
        Me.tabMain.Controls.Add(Me.lblCpt_reconduction)
        Me.tabMain.Controls.Add(Me.lblNbReconduction)
        Me.tabMain.Controls.Add(Me.lblNextPrice)
        Me.tabMain.Controls.Add(Me.txtNextPrice)
        Me.tabMain.Controls.Add(Me.btnForcedReconduction)
        Me.tabMain.Controls.Add(Me.btnActivateDomiciliation)
        Me.tabMain.Controls.Add(Me.btnReceivedDomiciliation)
        Me.tabMain.Controls.Add(Me.GCACtPhone)
        Me.tabMain.Controls.Add(Me.btnDelPhoAct)
        Me.tabMain.Controls.Add(Me.btnActPhone)
        Me.tabMain.Controls.Add(Me.btnReActivate)
        Me.tabMain.Controls.Add(Me.GCAboInfo)
        Me.tabMain.Controls.Add(Me.GCadresse)
        Me.tabMain.Controls.Add(Me.GCcustomersInfo)
        Me.tabMain.Controls.Add(Me.btnStopNow)
        Me.tabMain.Controls.Add(Me.btnStopAtReconduction)
        Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.Name = "tabMain"
        Me.tabMain.ShowCloseButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.tabMain.Size = New System.Drawing.Size(1253, 783)
        Me.tabMain.Text = "General Info"
        '
        'lblCpt_reconduction
        '
        Me.lblCpt_reconduction.Location = New System.Drawing.Point(134, 20)
        Me.lblCpt_reconduction.Name = "lblCpt_reconduction"
        Me.lblCpt_reconduction.Size = New System.Drawing.Size(6, 13)
        Me.lblCpt_reconduction.TabIndex = 28
        Me.lblCpt_reconduction.Text = "0"
        '
        'lblNbReconduction
        '
        Me.lblNbReconduction.Location = New System.Drawing.Point(16, 20)
        Me.lblNbReconduction.Name = "lblNbReconduction"
        Me.lblNbReconduction.Size = New System.Drawing.Size(109, 13)
        Me.lblNbReconduction.TabIndex = 27
        Me.lblNbReconduction.Text = "Nombre reconduction :"
        '
        'lblNextPrice
        '
        Me.lblNextPrice.Location = New System.Drawing.Point(828, 40)
        Me.lblNextPrice.Name = "lblNextPrice"
        Me.lblNextPrice.Size = New System.Drawing.Size(49, 13)
        Me.lblNextPrice.TabIndex = 24
        Me.lblNextPrice.Text = "Next Price"
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
        Me.btnActivateDomiciliation.Location = New System.Drawing.Point(990, 268)
        Me.btnActivateDomiciliation.Name = "btnActivateDomiciliation"
        Me.btnActivateDomiciliation.Size = New System.Drawing.Size(144, 23)
        Me.btnActivateDomiciliation.TabIndex = 12
        Me.btnActivateDomiciliation.Text = "&Activate by Domiciliation"
        Me.btnActivateDomiciliation.Visible = False
        '
        'btnReceivedDomiciliation
        '
        Me.btnReceivedDomiciliation.Location = New System.Drawing.Point(989, 316)
        Me.btnReceivedDomiciliation.Name = "btnReceivedDomiciliation"
        Me.btnReceivedDomiciliation.Size = New System.Drawing.Size(144, 23)
        Me.btnReceivedDomiciliation.TabIndex = 11
        Me.btnReceivedDomiciliation.Text = "&Received domiciliation"
        Me.ToolTip1.SetToolTip(Me.btnReceivedDomiciliation, "received dom 70")
        Me.btnReceivedDomiciliation.Visible = False
        '
        'GCACtPhone
        '
        Me.GCACtPhone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCACtPhone.Controls.Add(Me.MemoOtherReason)
        Me.GCACtPhone.Controls.Add(Me.Label2)
        Me.GCACtPhone.Controls.Add(Me.cmbPhoneActivDelete)
        Me.GCACtPhone.Controls.Add(Me.LabelReason)
        Me.GCACtPhone.Controls.Add(Me.DateCallPhoneActivation)
        Me.GCACtPhone.Controls.Add(Me.LabelCallMeDate)
        Me.GCACtPhone.Location = New System.Drawing.Point(632, 565)
        Me.GCACtPhone.Name = "GCACtPhone"
        Me.GCACtPhone.Size = New System.Drawing.Size(328, 177)
        Me.GCACtPhone.TabIndex = 10
        Me.GCACtPhone.Text = "Phone activation Info"
        Me.GCACtPhone.Visible = False
        '
        'MemoOtherReason
        '
        Me.MemoOtherReason.Enabled = False
        Me.MemoOtherReason.Location = New System.Drawing.Point(91, 89)
        Me.MemoOtherReason.Name = "MemoOtherReason"
        Me.MemoOtherReason.Size = New System.Drawing.Size(232, 79)
        Me.MemoOtherReason.StyleController = Me.LayoutCustServ
        Me.MemoOtherReason.TabIndex = 43
        Me.MemoOtherReason.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Comment"
        Me.Label2.Visible = False
        '
        'cmbPhoneActivDelete
        '
        Me.cmbPhoneActivDelete.Enabled = False
        Me.cmbPhoneActivDelete.Location = New System.Drawing.Point(136, 58)
        Me.cmbPhoneActivDelete.Name = "cmbPhoneActivDelete"
        Me.cmbPhoneActivDelete.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPhoneActivDelete.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("reason", "reason", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("stop_phone_id", "stop_phone_id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbPhoneActivDelete.Properties.DisplayMember = "reason"
        Me.cmbPhoneActivDelete.Properties.NullText = ""
        Me.cmbPhoneActivDelete.Properties.ValueMember = "stop_phone_id"
        Me.cmbPhoneActivDelete.Size = New System.Drawing.Size(185, 20)
        Me.cmbPhoneActivDelete.TabIndex = 40
        Me.cmbPhoneActivDelete.Visible = False
        '
        'LabelReason
        '
        Me.LabelReason.AutoSize = True
        Me.LabelReason.Location = New System.Drawing.Point(22, 61)
        Me.LabelReason.Name = "LabelReason"
        Me.LabelReason.Size = New System.Drawing.Size(99, 13)
        Me.LabelReason.TabIndex = 23
        Me.LabelReason.Text = "Reason from delete"
        Me.LabelReason.Visible = False
        '
        'DateCallPhoneActivation
        '
        Me.DateCallPhoneActivation.CausesValidation = False
        Me.DateCallPhoneActivation.EditValue = New Date(2013, 3, 21, 15, 38, 23, 0)
        Me.DateCallPhoneActivation.Enabled = False
        Me.DateCallPhoneActivation.Location = New System.Drawing.Point(136, 30)
        Me.DateCallPhoneActivation.Name = "DateCallPhoneActivation"
        Me.DateCallPhoneActivation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateCallPhoneActivation.Properties.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss"
        Me.DateCallPhoneActivation.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateCallPhoneActivation.Properties.EditFormat.FormatString = "dd.MM.yyyy HH:mm:ss"
        Me.DateCallPhoneActivation.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateCallPhoneActivation.Properties.Mask.EditMask = "s"
        Me.DateCallPhoneActivation.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateCallPhoneActivation.Size = New System.Drawing.Size(185, 20)
        Me.DateCallPhoneActivation.TabIndex = 18
        Me.DateCallPhoneActivation.Visible = False
        '
        'LabelCallMeDate
        '
        Me.LabelCallMeDate.Location = New System.Drawing.Point(25, 33)
        Me.LabelCallMeDate.Name = "LabelCallMeDate"
        Me.LabelCallMeDate.Size = New System.Drawing.Size(57, 13)
        Me.LabelCallMeDate.TabIndex = 13
        Me.LabelCallMeDate.Text = "call me date"
        Me.LabelCallMeDate.Visible = False
        '
        'btnDelPhoAct
        '
        Me.btnDelPhoAct.Location = New System.Drawing.Point(990, 403)
        Me.btnDelPhoAct.Name = "btnDelPhoAct"
        Me.btnDelPhoAct.Size = New System.Drawing.Size(144, 23)
        Me.btnDelPhoAct.TabIndex = 20
        Me.btnDelPhoAct.Text = "Delete Phone activation"
        Me.btnDelPhoAct.Visible = False
        '
        'btnActPhone
        '
        Me.btnActPhone.Location = New System.Drawing.Point(990, 220)
        Me.btnActPhone.Name = "btnActPhone"
        Me.btnActPhone.Size = New System.Drawing.Size(144, 23)
        Me.btnActPhone.TabIndex = 9
        Me.btnActPhone.Text = "&Activate by phone"
        Me.btnActPhone.Visible = False
        '
        'btnReActivate
        '
        Me.btnReActivate.Location = New System.Drawing.Point(990, 84)
        Me.btnReActivate.Name = "btnReActivate"
        Me.btnReActivate.Size = New System.Drawing.Size(144, 23)
        Me.btnReActivate.TabIndex = 6
        Me.btnReActivate.Text = "Re-Activate"
        Me.btnReActivate.Visible = False
        '
        'GCAboInfo
        '
        Me.GCAboInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCAboInfo.Controls.Add(Me.txtTVODFreeCredits)
        Me.GCAboInfo.Controls.Add(Me.LabelControl19)
        Me.GCAboInfo.Controls.Add(Me.lblAboSumP)
        Me.GCAboInfo.Controls.Add(Me.chkCustomerLockedForReconduction)
        Me.GCAboInfo.Controls.Add(Me.LabelControl15)
        Me.GCAboInfo.Controls.Add(Me.DateConfirmationSentAt)
        Me.GCAboInfo.Controls.Add(Me.LabelControl14)
        Me.GCAboInfo.Controls.Add(Me.DateConfirmedAt)
        Me.GCAboInfo.Controls.Add(Me.cmbDiscountActivation)
        Me.GCAboInfo.Controls.Add(Me.cmbDiscType)
        Me.GCAboInfo.Controls.Add(Me.lblDateEndHoliday)
        Me.GCAboInfo.Controls.Add(Me.DateEndOfHoliday)
        Me.GCAboInfo.Controls.Add(Me.cmbSuspended)
        Me.GCAboInfo.Controls.Add(Me.lblSuspended)
        Me.GCAboInfo.Controls.Add(Me.btnGoto30)
        Me.GCAboInfo.Controls.Add(Me.txtRegistrationStep)
        Me.GCAboInfo.Controls.Add(Me.lblRegistrationStep)
        Me.GCAboInfo.Controls.Add(Me.lblDiscountrecurring)
        Me.GCAboInfo.Controls.Add(Me.txtDiscRecurring)
        Me.GCAboInfo.Controls.Add(Me.chkAutoStop)
        Me.GCAboInfo.Controls.Add(Me.cmbNextDiscCode)
        Me.GCAboInfo.Controls.Add(Me.lblNextDiscount)
        Me.GCAboInfo.Controls.Add(Me.lblActivation)
        Me.GCAboInfo.Controls.Add(Me.cmbNextABO)
        Me.GCAboInfo.Controls.Add(Me.lblValidity)
        Me.GCAboInfo.Controls.Add(Me.txtAbo_ValidityTo)
        Me.GCAboInfo.Controls.Add(Me.cmbABO)
        Me.GCAboInfo.Controls.Add(Me.lblNextAbo)
        Me.GCAboInfo.Controls.Add(Me.lblAbo)
        Me.GCAboInfo.Location = New System.Drawing.Point(632, 67)
        Me.GCAboInfo.Name = "GCAboInfo"
        Me.GCAboInfo.Size = New System.Drawing.Size(336, 445)
        Me.GCAboInfo.TabIndex = 5
        Me.GCAboInfo.Text = "ABO Info"
        '
        'txtTVODFreeCredits
        '
        Me.txtTVODFreeCredits.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.tvod_free", True))
        Me.txtTVODFreeCredits.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTVODFreeCredits.Enabled = False
        Me.txtTVODFreeCredits.Location = New System.Drawing.Point(161, 284)
        Me.txtTVODFreeCredits.Name = "txtTVODFreeCredits"
        Me.txtTVODFreeCredits.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtTVODFreeCredits.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtTVODFreeCredits, True)
        Me.txtTVODFreeCredits.Size = New System.Drawing.Size(100, 20)
        Me.txtTVODFreeCredits.TabIndex = 94
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(8, 291)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl19.TabIndex = 93
        Me.LabelControl19.Text = "TVOD free credits"
        '
        'lblAboSumP
        '
        Me.lblAboSumP.AutoSize = True
        Me.lblAboSumP.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAboSumP.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblAboSumP.Location = New System.Drawing.Point(5, 54)
        Me.lblAboSumP.Name = "lblAboSumP"
        Me.lblAboSumP.Size = New System.Drawing.Size(139, 13)
        Me.lblAboSumP.TabIndex = 66
        Me.lblAboSumP.Text = "ABO 12 mois SummerPower"
        '
        'chkCustomerLockedForReconduction
        '
        Me.chkCustomerLockedForReconduction.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_locked__for_reconduction", True))
        Me.chkCustomerLockedForReconduction.Enabled = False
        Me.chkCustomerLockedForReconduction.Location = New System.Drawing.Point(5, 24)
        Me.chkCustomerLockedForReconduction.Name = "chkCustomerLockedForReconduction"
        Me.chkCustomerLockedForReconduction.Properties.Caption = "Locked for reconduction"
        Me.chkCustomerLockedForReconduction.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkCustomerLockedForReconduction.Size = New System.Drawing.Size(173, 19)
        Me.chkCustomerLockedForReconduction.TabIndex = 65
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(8, 396)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl15.TabIndex = 64
        Me.LabelControl15.Text = "Confirmation sent at"
        '
        'DateConfirmationSentAt
        '
        Me.DateConfirmationSentAt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.confirmation_sent_at", True))
        Me.DateConfirmationSentAt.EditValue = Nothing
        Me.DateConfirmationSentAt.Enabled = False
        Me.DateConfirmationSentAt.Location = New System.Drawing.Point(160, 393)
        Me.DateConfirmationSentAt.Name = "DateConfirmationSentAt"
        Me.DateConfirmationSentAt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateConfirmationSentAt.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateConfirmationSentAt.Size = New System.Drawing.Size(128, 20)
        Me.DateConfirmationSentAt.TabIndex = 63
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(8, 370)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl14.TabIndex = 62
        Me.LabelControl14.Text = "Confirmed at"
        '
        'DateConfirmedAt
        '
        Me.DateConfirmedAt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.confirmed_at", True))
        Me.DateConfirmedAt.EditValue = Nothing
        Me.DateConfirmedAt.Enabled = False
        Me.DateConfirmedAt.Location = New System.Drawing.Point(160, 367)
        Me.DateConfirmedAt.Name = "DateConfirmedAt"
        Me.DateConfirmedAt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateConfirmedAt.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateConfirmedAt.Size = New System.Drawing.Size(128, 20)
        Me.DateConfirmedAt.TabIndex = 61
        '
        'cmbDiscountActivation
        '
        Me.cmbDiscountActivation.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.activation_discount_code_id", True))
        Me.cmbDiscountActivation.Enabled = False
        Me.cmbDiscountActivation.Location = New System.Drawing.Point(160, 210)
        Me.cmbDiscountActivation.Name = "cmbDiscountActivation"
        Me.cmbDiscountActivation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.cmbDiscountActivation.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("discount_code_id", "discount_code_id", 102, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("discount_code", "discount_code", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbDiscountActivation.Properties.DataSource = Me.objDS.discount_code
        Me.cmbDiscountActivation.Properties.DisplayMember = "code"
        Me.cmbDiscountActivation.Properties.NullText = ""
        Me.cmbDiscountActivation.Properties.ValueMember = "code_id"
        Me.cmbDiscountActivation.Size = New System.Drawing.Size(87, 20)
        Me.cmbDiscountActivation.TabIndex = 60
        '
        'cmbDiscType
        '
        Me.cmbDiscType.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.activation_discount_code_type", True))
        Me.cmbDiscType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "customers.activation_discount_code_type", True))
        Me.cmbDiscType.Enabled = False
        Me.cmbDiscType.Location = New System.Drawing.Point(248, 210)
        Me.cmbDiscType.Name = "cmbDiscType"
        Me.cmbDiscType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDiscType.Properties.Items.AddRange(New Object() {"A", "D"})
        Me.cmbDiscType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbDiscType.Size = New System.Drawing.Size(80, 20)
        Me.cmbDiscType.TabIndex = 59
        '
        'lblDateEndHoliday
        '
        Me.lblDateEndHoliday.Location = New System.Drawing.Point(8, 185)
        Me.lblDateEndHoliday.Name = "lblDateEndHoliday"
        Me.lblDateEndHoliday.Size = New System.Drawing.Size(113, 13)
        Me.lblDateEndHoliday.TabIndex = 51
        Me.lblDateEndHoliday.Text = "closing date of vacancy"
        '
        'DateEndOfHoliday
        '
        Me.DateEndOfHoliday.EditValue = Nothing
        Me.DateEndOfHoliday.Enabled = False
        Me.DateEndOfHoliday.Location = New System.Drawing.Point(160, 182)
        Me.DateEndOfHoliday.Name = "DateEndOfHoliday"
        Me.DateEndOfHoliday.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEndOfHoliday.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEndOfHoliday.Size = New System.Drawing.Size(152, 20)
        Me.DateEndOfHoliday.TabIndex = 50
        '
        'cmbSuspended
        '
        Me.cmbSuspended.Enabled = False
        Me.cmbSuspended.Location = New System.Drawing.Point(160, 159)
        Me.cmbSuspended.Name = "cmbSuspended"
        Me.cmbSuspended.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSuspended.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 75, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbSuspended.Properties.DisplayMember = "DisplayMember"
        Me.cmbSuspended.Properties.NullText = ""
        Me.cmbSuspended.Properties.ValueMember = "Value"
        Me.cmbSuspended.Size = New System.Drawing.Size(152, 20)
        Me.cmbSuspended.TabIndex = 48
        '
        'lblSuspended
        '
        Me.lblSuspended.Location = New System.Drawing.Point(8, 163)
        Me.lblSuspended.Name = "lblSuspended"
        Me.lblSuspended.Size = New System.Drawing.Size(53, 13)
        Me.lblSuspended.TabIndex = 45
        Me.lblSuspended.Text = "Suspended"
        '
        'btnGoto30
        '
        Me.btnGoto30.Enabled = False
        Me.btnGoto30.Location = New System.Drawing.Point(248, 310)
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
        Me.txtRegistrationStep.Location = New System.Drawing.Point(160, 310)
        Me.txtRegistrationStep.Name = "txtRegistrationStep"
        Me.txtRegistrationStep.Size = New System.Drawing.Size(80, 20)
        Me.txtRegistrationStep.TabIndex = 43
        '
        'lblRegistrationStep
        '
        Me.lblRegistrationStep.Location = New System.Drawing.Point(8, 318)
        Me.lblRegistrationStep.Name = "lblRegistrationStep"
        Me.lblRegistrationStep.Size = New System.Drawing.Size(83, 13)
        Me.lblRegistrationStep.TabIndex = 42
        Me.lblRegistrationStep.Text = "Registration Step"
        '
        'lblDiscountrecurring
        '
        Me.lblDiscountrecurring.Location = New System.Drawing.Point(8, 242)
        Me.lblDiscountrecurring.Name = "lblDiscountrecurring"
        Me.lblDiscountrecurring.Size = New System.Drawing.Size(90, 13)
        Me.lblDiscountrecurring.TabIndex = 40
        Me.lblDiscountrecurring.Text = "Discount Recurring"
        '
        'txtDiscRecurring
        '
        Me.txtDiscRecurring.AllowDrop = True
        Me.txtDiscRecurring.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_discount_recurring_to_date", True))
        Me.txtDiscRecurring.EditValue = Nothing
        Me.txtDiscRecurring.Enabled = False
        Me.txtDiscRecurring.Location = New System.Drawing.Point(160, 234)
        Me.txtDiscRecurring.Name = "txtDiscRecurring"
        Me.txtDiscRecurring.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtDiscRecurring.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDiscRecurring.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDiscRecurring.Size = New System.Drawing.Size(152, 20)
        Me.txtDiscRecurring.TabIndex = 39
        '
        'chkAutoStop
        '
        Me.chkAutoStop.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_auto_stop_next_reconduction", True))
        Me.chkAutoStop.Enabled = False
        Me.chkAutoStop.Location = New System.Drawing.Point(120, 342)
        Me.chkAutoStop.Name = "chkAutoStop"
        Me.chkAutoStop.Properties.Caption = "Auto-Stop"
        Me.chkAutoStop.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkAutoStop.Size = New System.Drawing.Size(96, 19)
        Me.chkAutoStop.TabIndex = 38
        '
        'cmbNextDiscCode
        '
        Me.cmbNextDiscCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_next_discount_code", True))
        Me.cmbNextDiscCode.Enabled = False
        Me.cmbNextDiscCode.Location = New System.Drawing.Point(160, 258)
        Me.cmbNextDiscCode.Name = "cmbNextDiscCode"
        Me.cmbNextDiscCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.cmbNextDiscCode.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("discount_code_id", "discount_code_id", 102, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("discount_code", "discount_code", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbNextDiscCode.Properties.DataSource = Me.objDS.discount_code
        Me.cmbNextDiscCode.Properties.DisplayMember = "code"
        Me.cmbNextDiscCode.Properties.NullText = ""
        Me.cmbNextDiscCode.Properties.ValueMember = "code_id"
        Me.cmbNextDiscCode.Size = New System.Drawing.Size(152, 20)
        Me.cmbNextDiscCode.TabIndex = 36
        '
        'lblNextDiscount
        '
        Me.lblNextDiscount.Location = New System.Drawing.Point(8, 266)
        Me.lblNextDiscount.Name = "lblNextDiscount"
        Me.lblNextDiscount.Size = New System.Drawing.Size(77, 13)
        Me.lblNextDiscount.TabIndex = 33
        Me.lblNextDiscount.Text = "Next Disc. Code"
        '
        'lblActivation
        '
        Me.lblActivation.Location = New System.Drawing.Point(8, 218)
        Me.lblActivation.Name = "lblActivation"
        Me.lblActivation.Size = New System.Drawing.Size(109, 13)
        Me.lblActivation.TabIndex = 31
        Me.lblActivation.Text = "Activation / Disc. Code"
        '
        'cmbNextABO
        '
        Me.cmbNextABO.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_next_abo_type", True))
        Me.cmbNextABO.Enabled = False
        Me.cmbNextABO.Location = New System.Drawing.Point(160, 105)
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
        'lblValidity
        '
        Me.lblValidity.Location = New System.Drawing.Point(8, 137)
        Me.lblValidity.Name = "lblValidity"
        Me.lblValidity.Size = New System.Drawing.Size(34, 13)
        Me.lblValidity.TabIndex = 18
        Me.lblValidity.Text = "Validity"
        '
        'txtAbo_ValidityTo
        '
        Me.txtAbo_ValidityTo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_validityto", True))
        Me.txtAbo_ValidityTo.EditValue = Nothing
        Me.txtAbo_ValidityTo.Enabled = False
        Me.txtAbo_ValidityTo.Location = New System.Drawing.Point(160, 129)
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
        Me.cmbABO.Location = New System.Drawing.Point(160, 81)
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
        'lblNextAbo
        '
        Me.lblNextAbo.Location = New System.Drawing.Point(8, 113)
        Me.lblNextAbo.Name = "lblNextAbo"
        Me.lblNextAbo.Size = New System.Drawing.Size(47, 13)
        Me.lblNextAbo.TabIndex = 14
        Me.lblNextAbo.Text = "Next ABO"
        '
        'lblAbo
        '
        Me.lblAbo.Location = New System.Drawing.Point(8, 89)
        Me.lblAbo.Name = "lblAbo"
        Me.lblAbo.Size = New System.Drawing.Size(21, 13)
        Me.lblAbo.TabIndex = 12
        Me.lblAbo.Text = "ABO"
        '
        'GCadresse
        '
        Me.GCadresse.AutoSize = True
        Me.GCadresse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GCadresse.Controls.Add(Me.txtDate_added_Current)
        Me.GCadresse.Controls.Add(Me.GridAddress)
        Me.GCadresse.Controls.Add(Me.txtDeliveryFirstName)
        Me.GCadresse.Controls.Add(Me.txtDeliveryLastName)
        Me.GCadresse.Controls.Add(Me.LabelControl10)
        Me.GCadresse.Controls.Add(Me.cmbDeliverycountry)
        Me.GCadresse.Controls.Add(Me.txtDeliveryCity)
        Me.GCadresse.Controls.Add(Me.txtDeliveryPostCode)
        Me.GCadresse.Controls.Add(Me.txtDeliveryAddr)
        Me.GCadresse.Controls.Add(Me.LabelControl9)
        Me.GCadresse.Location = New System.Drawing.Point(16, 439)
        Me.GCadresse.Name = "GCadresse"
        Me.GCadresse.Size = New System.Drawing.Size(600, 304)
        Me.GCadresse.TabIndex = 1
        Me.GCadresse.Text = "Default Delivery Address"
        '
        'txtDate_added_Current
        '
        Me.txtDate_added_Current.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.date_added", True))
        Me.txtDate_added_Current.Enabled = False
        Me.txtDate_added_Current.Location = New System.Drawing.Point(4, 85)
        Me.txtDate_added_Current.Name = "txtDate_added_Current"
        Me.txtDate_added_Current.Properties.ReadOnly = True
        Me.txtDate_added_Current.Size = New System.Drawing.Size(134, 20)
        Me.txtDate_added_Current.TabIndex = 21
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
        Me.GridViewAddress.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.entry_firstname, Me.entry_lastname, Me.entry_street_address, Me.entry_postcode, Me.entry_city, Me.countries_name, Me.cdate_added})
        Me.GridViewAddress.CustomizationFormBounds = New System.Drawing.Rectangle(1382, 593, 218, 205)
        Me.GridViewAddress.GridControl = Me.GridAddress
        Me.GridViewAddress.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewAddress.Name = "GridViewAddress"
        Me.GridViewAddress.OptionsBehavior.Editable = False
        Me.GridViewAddress.OptionsCustomization.AllowGroup = False
        Me.GridViewAddress.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridViewAddress.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewAddress.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridViewAddress.OptionsView.ColumnAutoWidth = False
        Me.GridViewAddress.OptionsView.ShowGroupPanel = False
        Me.GridViewAddress.OptionsView.ShowHorzLines = False
        Me.GridViewAddress.OptionsView.ShowIndicator = False
        '
        'entry_firstname
        '
        Me.entry_firstname.Caption = "entry_firstname"
        Me.entry_firstname.FieldName = "entry_firstname"
        Me.entry_firstname.Name = "entry_firstname"
        Me.entry_firstname.OptionsColumn.AllowEdit = False
        Me.entry_firstname.OptionsColumn.FixedWidth = True
        Me.entry_firstname.OptionsColumn.ReadOnly = True
        Me.entry_firstname.Visible = True
        Me.entry_firstname.VisibleIndex = 1
        Me.entry_firstname.Width = 130
        '
        'entry_lastname
        '
        Me.entry_lastname.Caption = "entry_lastname"
        Me.entry_lastname.FieldName = "entry_lastname"
        Me.entry_lastname.Name = "entry_lastname"
        Me.entry_lastname.OptionsColumn.AllowEdit = False
        Me.entry_lastname.OptionsColumn.FixedWidth = True
        Me.entry_lastname.OptionsColumn.ReadOnly = True
        Me.entry_lastname.Visible = True
        Me.entry_lastname.VisibleIndex = 2
        Me.entry_lastname.Width = 156
        '
        'entry_street_address
        '
        Me.entry_street_address.Caption = "entry_street_address"
        Me.entry_street_address.FieldName = "entry_street_address"
        Me.entry_street_address.Name = "entry_street_address"
        Me.entry_street_address.OptionsColumn.AllowEdit = False
        Me.entry_street_address.OptionsColumn.FixedWidth = True
        Me.entry_street_address.OptionsColumn.ReadOnly = True
        Me.entry_street_address.Visible = True
        Me.entry_street_address.VisibleIndex = 3
        Me.entry_street_address.Width = 235
        '
        'entry_postcode
        '
        Me.entry_postcode.Caption = "entry_postcode"
        Me.entry_postcode.FieldName = "entry_postcode"
        Me.entry_postcode.Name = "entry_postcode"
        Me.entry_postcode.OptionsColumn.AllowEdit = False
        Me.entry_postcode.OptionsColumn.FixedWidth = True
        Me.entry_postcode.OptionsColumn.ReadOnly = True
        Me.entry_postcode.Visible = True
        Me.entry_postcode.VisibleIndex = 4
        Me.entry_postcode.Width = 111
        '
        'entry_city
        '
        Me.entry_city.Caption = "entry_city"
        Me.entry_city.FieldName = "entry_city"
        Me.entry_city.Name = "entry_city"
        Me.entry_city.OptionsColumn.AllowEdit = False
        Me.entry_city.OptionsColumn.FixedWidth = True
        Me.entry_city.OptionsColumn.ReadOnly = True
        Me.entry_city.Visible = True
        Me.entry_city.VisibleIndex = 5
        Me.entry_city.Width = 108
        '
        'countries_name
        '
        Me.countries_name.Caption = "countries_name"
        Me.countries_name.FieldName = "countries_name"
        Me.countries_name.Name = "countries_name"
        Me.countries_name.OptionsColumn.AllowEdit = False
        Me.countries_name.OptionsColumn.FixedWidth = True
        Me.countries_name.OptionsColumn.ReadOnly = True
        Me.countries_name.Visible = True
        Me.countries_name.VisibleIndex = 6
        Me.countries_name.Width = 135
        '
        'cdate_added
        '
        Me.cdate_added.Caption = "date_added"
        Me.cdate_added.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.cdate_added.FieldName = "date_added"
        Me.cdate_added.Name = "cdate_added"
        Me.cdate_added.OptionsColumn.AllowEdit = False
        Me.cdate_added.OptionsColumn.ReadOnly = True
        Me.cdate_added.Visible = True
        Me.cdate_added.VisibleIndex = 0
        Me.cdate_added.Width = 96
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
        'GCcustomersInfo
        '
        Me.GCcustomersInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCcustomersInfo.Controls.Add(Me.LabelControl26)
        Me.GCcustomersInfo.Controls.Add(Me.txtDateCreated)
        Me.GCcustomersInfo.Controls.Add(Me.txtLast_logon)
        Me.GCcustomersInfo.Controls.Add(Me.txtYearsOld)
        Me.GCcustomersInfo.Controls.Add(Me.chkNewsLetterPartner)
        Me.GCcustomersInfo.Controls.Add(Me.lblGender)
        Me.GCcustomersInfo.Controls.Add(Me.chkNewsLetter)
        Me.GCcustomersInfo.Controls.Add(Me.txtGender)
        Me.GCcustomersInfo.Controls.Add(Me.lblyearsOld)
        Me.GCcustomersInfo.Controls.Add(Me.lblSetPassWord)
        Me.GCcustomersInfo.Controls.Add(Me.txtNbrOfLogons)
        Me.GCcustomersInfo.Controls.Add(Me.LabelControl36)
        Me.GCcustomersInfo.Controls.Add(Me.LabelControl29)
        Me.GCcustomersInfo.Controls.Add(Me.LabelControl28)
        Me.GCcustomersInfo.Controls.Add(Me.cmbLanguage)
        Me.GCcustomersInfo.Controls.Add(Me.LabelControl27)
        Me.GCcustomersInfo.Controls.Add(Me.txtTel)
        Me.GCcustomersInfo.Controls.Add(Me.txtEMail)
        Me.GCcustomersInfo.Controls.Add(Me.LabelControl21)
        Me.GCcustomersInfo.Controls.Add(Me.txtABO)
        Me.GCcustomersInfo.Controls.Add(Me.LabelControl11)
        Me.GCcustomersInfo.Controls.Add(Me.DateBirthday)
        Me.GCcustomersInfo.Controls.Add(Me.txtFirstName)
        Me.GCcustomersInfo.Controls.Add(Me.txtLastName)
        Me.GCcustomersInfo.Controls.Add(Me.LabelControl7)
        Me.GCcustomersInfo.Controls.Add(Me.txtCustomers_id)
        Me.GCcustomersInfo.Controls.Add(Me.LabelControl8)
        Me.GCcustomersInfo.Location = New System.Drawing.Point(16, 40)
        Me.GCcustomersInfo.Name = "GCcustomersInfo"
        Me.GCcustomersInfo.Size = New System.Drawing.Size(600, 386)
        Me.GCcustomersInfo.TabIndex = 0
        Me.GCcustomersInfo.Text = "Global Info"
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(280, 53)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl26.TabIndex = 61
        Me.LabelControl26.Text = "Created"
        '
        'txtDateCreated
        '
        Me.txtDateCreated.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.created_at", True))
        Me.txtDateCreated.EditValue = Nothing
        Me.txtDateCreated.Enabled = False
        Me.txtDateCreated.Location = New System.Drawing.Point(376, 53)
        Me.txtDateCreated.Name = "txtDateCreated"
        Me.txtDateCreated.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtDateCreated.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateCreated.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDateCreated.Size = New System.Drawing.Size(144, 20)
        Me.txtDateCreated.TabIndex = 60
        '
        'txtLast_logon
        '
        Me.txtLast_logon.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.current_sign_in_at", True))
        Me.txtLast_logon.Enabled = False
        Me.txtLast_logon.Location = New System.Drawing.Point(144, 265)
        Me.txtLast_logon.Name = "txtLast_logon"
        Me.txtLast_logon.Size = New System.Drawing.Size(152, 20)
        Me.txtLast_logon.TabIndex = 59
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
        Me.chkNewsLetterPartner.Location = New System.Drawing.Point(364, 256)
        Me.chkNewsLetterPartner.Name = "chkNewsLetterPartner"
        Me.chkNewsLetterPartner.Properties.Caption = "NewsLetter Partner"
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
        Me.chkNewsLetter.Location = New System.Drawing.Point(364, 235)
        Me.chkNewsLetter.Name = "chkNewsLetter"
        Me.chkNewsLetter.Properties.Caption = "NewsLetter"
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
        'lblyearsOld
        '
        Me.lblyearsOld.Location = New System.Drawing.Point(330, 182)
        Me.lblyearsOld.Name = "lblyearsOld"
        Me.lblyearsOld.Size = New System.Drawing.Size(44, 13)
        Me.lblyearsOld.TabIndex = 53
        Me.lblyearsOld.Text = "years old"
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
        'txtNbrOfLogons
        '
        Me.txtNbrOfLogons.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.sign_in_count", True))
        Me.txtNbrOfLogons.Enabled = False
        Me.txtNbrOfLogons.Location = New System.Drawing.Point(144, 290)
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
        Me.LabelControl29.Location = New System.Drawing.Point(14, 291)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl29.TabIndex = 45
        Me.LabelControl29.Text = "Nbr of Logons"
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(14, 267)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl28.TabIndex = 44
        Me.LabelControl28.Text = "Last Logon"
        '
        'cmbLanguage
        '
        Me.cmbLanguage.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_language", True))
        Me.cmbLanguage.Enabled = False
        Me.cmbLanguage.Location = New System.Drawing.Point(144, 235)
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
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(14, 243)
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
        Me.txtEMail.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.email", True))
        Me.txtEMail.Enabled = False
        Me.txtEMail.Location = New System.Drawing.Point(144, 131)
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtEMail.Size = New System.Drawing.Size(440, 20)
        Me.txtEMail.TabIndex = 19
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(16, 157)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl21.TabIndex = 16
        Me.LabelControl21.Text = "Phone"
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
        'DateBirthday
        '
        Me.DateBirthday.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_dob", True))
        Me.DateBirthday.EditValue = Nothing
        Me.DateBirthday.Enabled = False
        Me.DateBirthday.Location = New System.Drawing.Point(144, 179)
        Me.DateBirthday.Name = "DateBirthday"
        Me.DateBirthday.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateBirthday.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateBirthday.Size = New System.Drawing.Size(128, 20)
        Me.DateBirthday.TabIndex = 10
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
        Me.btnStopNow.Location = New System.Drawing.Point(990, 174)
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
        Me.tabSearch.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tabSearch.Appearance.Header.Options.UseFont = True
        Me.tabSearch.Controls.Add(Me.GridControl1)
        Me.tabSearch.Controls.Add(Me.PanelControl1)
        Me.tabSearch.Name = "tabSearch"
        Me.tabSearch.ShowCloseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.tabSearch.Size = New System.Drawing.Size(1253, 783)
        Me.tabSearch.Text = "Search"
        '
        'PanelControl1
        '
        Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl1.Controls.Add(Me.LabelControl16)
        Me.PanelControl1.Controls.Add(Me.txtPPAgreementID)
        Me.PanelControl1.Controls.Add(Me.btnReplayAllCreditHistory)
        Me.PanelControl1.Controls.Add(Me.BtnEmailError)
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
        Me.PanelControl1.Size = New System.Drawing.Size(1253, 176)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(261, 71)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl16.TabIndex = 62
        Me.LabelControl16.Text = "PP agreement id"
        Me.LabelControl16.Visible = False
        '
        'txtPPAgreementID
        '
        Me.txtPPAgreementID.Location = New System.Drawing.Point(346, 68)
        Me.txtPPAgreementID.Name = "txtPPAgreementID"
        Me.txtPPAgreementID.Size = New System.Drawing.Size(156, 20)
        Me.txtPPAgreementID.TabIndex = 61
        Me.txtPPAgreementID.Visible = False
        '
        'btnReplayAllCreditHistory
        '
        Me.btnReplayAllCreditHistory.Location = New System.Drawing.Point(889, 86)
        Me.btnReplayAllCreditHistory.Name = "btnReplayAllCreditHistory"
        Me.btnReplayAllCreditHistory.Size = New System.Drawing.Size(138, 39)
        Me.btnReplayAllCreditHistory.TabIndex = 60
        Me.btnReplayAllCreditHistory.Text = "replay all credit history"
        Me.btnReplayAllCreditHistory.Visible = False
        '
        'BtnEmailError
        '
        Me.BtnEmailError.Location = New System.Drawing.Point(587, 119)
        Me.BtnEmailError.Name = "BtnEmailError"
        Me.BtnEmailError.Size = New System.Drawing.Size(138, 23)
        Me.BtnEmailError.TabIndex = 59
        Me.BtnEmailError.Text = "Email Error"
        Me.BtnEmailError.Visible = False
        '
        'BtnSponsorCard
        '
        Me.BtnSponsorCard.Location = New System.Drawing.Point(889, 48)
        Me.BtnSponsorCard.Name = "BtnSponsorCard"
        Me.BtnSponsorCard.Size = New System.Drawing.Size(138, 23)
        Me.BtnSponsorCard.TabIndex = 56
        Me.BtnSponsorCard.Text = "Sponsor card"
        Me.BtnSponsorCard.Visible = False
        '
        'btnViewGift
        '
        Me.btnViewGift.Location = New System.Drawing.Point(734, 119)
        Me.btnViewGift.Name = "btnViewGift"
        Me.btnViewGift.Size = New System.Drawing.Size(138, 23)
        Me.btnViewGift.TabIndex = 55
        Me.btnViewGift.Text = "View Customers With Gift"
        Me.btnViewGift.Visible = False
        '
        'btnViewCustserv
        '
        Me.btnViewCustserv.Location = New System.Drawing.Point(734, 86)
        Me.btnViewCustserv.Name = "btnViewCustserv"
        Me.btnViewCustserv.Size = New System.Drawing.Size(138, 23)
        Me.btnViewCustserv.TabIndex = 54
        Me.btnViewCustserv.Text = "View CustServ"
        Me.btnViewCustserv.Visible = False
        '
        'TxtCustomers_NumComm
        '
        Me.TxtCustomers_NumComm.Location = New System.Drawing.Point(136, 109)
        Me.TxtCustomers_NumComm.Name = "TxtCustomers_NumComm"
        Me.TxtCustomers_NumComm.Size = New System.Drawing.Size(137, 20)
        Me.TxtCustomers_NumComm.TabIndex = 53
        Me.TxtCustomers_NumComm.Visible = False
        '
        'lblNumComm
        '
        Me.lblNumComm.Location = New System.Drawing.Point(24, 111)
        Me.lblNumComm.Name = "lblNumComm"
        Me.lblNumComm.Size = New System.Drawing.Size(96, 13)
        Me.lblNumComm.TabIndex = 52
        Me.lblNumComm.Text = "Communication Num"
        Me.lblNumComm.Visible = False
        '
        'txtcustomers_domiciliation_number_search
        '
        Me.txtcustomers_domiciliation_number_search.Location = New System.Drawing.Point(136, 139)
        Me.txtcustomers_domiciliation_number_search.Name = "txtcustomers_domiciliation_number_search"
        Me.txtcustomers_domiciliation_number_search.Size = New System.Drawing.Size(137, 20)
        Me.txtcustomers_domiciliation_number_search.TabIndex = 51
        Me.txtcustomers_domiciliation_number_search.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(24, 142)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl4.TabIndex = 50
        Me.LabelControl4.Text = "Domiciliation Num"
        Me.LabelControl4.Visible = False
        '
        'btnPhoneActivation
        '
        Me.btnPhoneActivation.Location = New System.Drawing.Point(587, 86)
        Me.btnPhoneActivation.Name = "btnPhoneActivation"
        Me.btnPhoneActivation.Size = New System.Drawing.Size(141, 23)
        Me.btnPhoneActivation.TabIndex = 49
        Me.btnPhoneActivation.Text = "&View Phone Activation"
        Me.btnPhoneActivation.Visible = False
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
        Me.LabelControl6.Location = New System.Drawing.Point(261, 48)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl6.TabIndex = 47
        Me.LabelControl6.Text = "PostCode"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(261, 23)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl5.TabIndex = 46
        Me.LabelControl5.Text = "Street"
        '
        'txtcustomers_postcode_search
        '
        Me.txtcustomers_postcode_search.Location = New System.Drawing.Point(346, 43)
        Me.txtcustomers_postcode_search.Name = "txtcustomers_postcode_search"
        Me.txtcustomers_postcode_search.Size = New System.Drawing.Size(156, 20)
        Me.txtcustomers_postcode_search.TabIndex = 12
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(313, 118)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(137, 37)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "&Search"
        '
        'txtcustomers_address_street_search
        '
        Me.txtcustomers_address_street_search.Location = New System.Drawing.Point(346, 19)
        Me.txtcustomers_address_street_search.Name = "txtcustomers_address_street_search"
        Me.txtcustomers_address_street_search.Size = New System.Drawing.Size(156, 20)
        Me.txtcustomers_address_street_search.TabIndex = 9
        '
        'txtcustomers_email_address_search
        '
        Me.txtcustomers_email_address_search.Location = New System.Drawing.Point(90, 68)
        Me.txtcustomers_email_address_search.Name = "txtcustomers_email_address_search"
        Me.txtcustomers_email_address_search.Size = New System.Drawing.Size(156, 20)
        Me.txtcustomers_email_address_search.TabIndex = 5
        '
        'txtcustomers_name_search
        '
        Me.txtcustomers_name_search.Location = New System.Drawing.Point(90, 43)
        Me.txtcustomers_name_search.Name = "txtcustomers_name_search"
        Me.txtcustomers_name_search.Size = New System.Drawing.Size(156, 20)
        Me.txtcustomers_name_search.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(24, 48)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Name"
        '
        'txtcustomers_id_search
        '
        Me.txtcustomers_id_search.Location = New System.Drawing.Point(90, 19)
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
        'XTabCustomers
        '
        Me.XTabCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTabCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTabCustomers.Location = New System.Drawing.Point(0, 57)
        Me.XTabCustomers.Name = "XTabCustomers"
        Me.XTabCustomers.SelectedTabPage = Me.tabMain
        Me.XTabCustomers.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XTabCustomers.Size = New System.Drawing.Size(1262, 817)
        Me.XTabCustomers.TabIndex = 35
        Me.XTabCustomers.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabSearch, Me.tabMain, Me.tabComment, Me.tabCalls, Me.tabAboHistory, Me.tabMessagerie, Me.tabCustServ, Me.tabPayment, Me.tabMailHistory, Me.tabSponsorShip, Me.tabPaymentMovements, Me.tabPurchase, Me.tabCompensation, Me.tabProductsRating, Me.tabSuspendedHistory, Me.tabVodView, Me.tabCritiques, Me.tabConfig})
        '
        'tabComment
        '
        Me.tabComment.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tabComment.Appearance.Header.Options.UseFont = True
        Me.tabComment.AutoScroll = True
        Me.tabComment.Controls.Add(Me.MemoCustomersComment)
        Me.tabComment.Controls.Add(Me.GridCustComment)
        Me.tabComment.Controls.Add(Me.MemoInsertComment)
        Me.tabComment.Controls.Add(Me.btnAddCustomersComment)
        Me.tabComment.Name = "tabComment"
        Me.tabComment.ShowCloseButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.tabComment.Size = New System.Drawing.Size(1253, 783)
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
        'tabCalls
        '
        Me.tabCalls.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCalls.Appearance.Header.Options.UseFont = True
        Me.tabCalls.Controls.Add(Me.UcCallsHistory1)
        Me.tabCalls.Name = "tabCalls"
        Me.tabCalls.Size = New System.Drawing.Size(1253, 783)
        Me.tabCalls.Text = "calls"
        '
        'UcCallsHistory1
        '
        Me.UcCallsHistory1.customers_id = 0
        Me.UcCallsHistory1.FT = False
        Me.UcCallsHistory1.Location = New System.Drawing.Point(7, 3)
        Me.UcCallsHistory1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcCallsHistory1.Name = "UcCallsHistory1"
        Me.UcCallsHistory1.Reconductions = 0
        Me.UcCallsHistory1.Size = New System.Drawing.Size(1037, 514)
        Me.UcCallsHistory1.TabIndex = 0
        '
        'tabMessagerie
        '
        Me.tabMessagerie.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMessagerie.Appearance.Header.Options.UseFont = True
        Me.tabMessagerie.Controls.Add(Me.UcMessagerieCustomer)
        Me.tabMessagerie.Name = "tabMessagerie"
        Me.tabMessagerie.Size = New System.Drawing.Size(1253, 783)
        Me.tabMessagerie.Text = "Messagerie"
        '
        'UcMessagerieCustomer
        '
        Me.UcMessagerieCustomer.Customers_id = 0
        Me.UcMessagerieCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMessagerieCustomer.language_id = 0
        Me.UcMessagerieCustomer.Location = New System.Drawing.Point(0, 0)
        Me.UcMessagerieCustomer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcMessagerieCustomer.Name = "UcMessagerieCustomer"
        Me.UcMessagerieCustomer.Size = New System.Drawing.Size(1253, 783)
        Me.UcMessagerieCustomer.TabIndex = 0
        '
        'tabSponsorShip
        '
        Me.tabSponsorShip.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tabSponsorShip.Appearance.Header.Options.UseFont = True
        Me.tabSponsorShip.AutoScroll = True
        Me.tabSponsorShip.Controls.Add(Me.GCCodeLinked)
        Me.tabSponsorShip.Controls.Add(Me.GCSponsonCard)
        Me.tabSponsorShip.Controls.Add(Me.grpCustomersPoint)
        Me.tabSponsorShip.Controls.Add(Me.GCGift)
        Me.tabSponsorShip.Controls.Add(Me.GCSponsorShip)
        Me.tabSponsorShip.Name = "tabSponsorShip"
        Me.tabSponsorShip.Size = New System.Drawing.Size(1253, 783)
        Me.tabSponsorShip.Text = "Sponsorship"
        '
        'GCCodeLinked
        '
        Me.GCCodeLinked.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCCodeLinked.Controls.Add(Me.GridCodeLinked)
        Me.GCCodeLinked.Location = New System.Drawing.Point(855, 19)
        Me.GCCodeLinked.Name = "GCCodeLinked"
        Me.GCCodeLinked.Size = New System.Drawing.Size(326, 379)
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
        Me.GridCodeLinked.Size = New System.Drawing.Size(312, 351)
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
        'GCSponsonCard
        '
        Me.GCSponsonCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCSponsonCard.Controls.Add(Me.BtnSaveSponsorCard)
        Me.GCSponsonCard.Controls.Add(Me.lblCard5)
        Me.GCSponsonCard.Controls.Add(Me.txtCard5)
        Me.GCSponsonCard.Controls.Add(Me.lblCard4)
        Me.GCSponsonCard.Controls.Add(Me.txtCard4)
        Me.GCSponsonCard.Controls.Add(Me.lblCard3)
        Me.GCSponsonCard.Controls.Add(Me.txtCard3)
        Me.GCSponsonCard.Controls.Add(Me.lblCard2)
        Me.GCSponsonCard.Controls.Add(Me.txtCard2)
        Me.GCSponsonCard.Controls.Add(Me.lblCard1)
        Me.GCSponsonCard.Controls.Add(Me.txtCard1)
        Me.GCSponsonCard.Location = New System.Drawing.Point(641, 19)
        Me.GCSponsonCard.Name = "GCSponsonCard"
        Me.GCSponsonCard.Size = New System.Drawing.Size(208, 379)
        Me.GCSponsonCard.TabIndex = 15
        Me.GCSponsonCard.Text = "Sponsor Card"
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
        Me.GridViewCustPointHistory.CustomizationFormBounds = New System.Drawing.Rectangle(1022, 668, 208, 170)
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
        'GCGift
        '
        Me.GCGift.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCGift.Controls.Add(Me.GridGift)
        Me.GCGift.Location = New System.Drawing.Point(9, 409)
        Me.GCGift.Name = "GCGift"
        Me.GCGift.Size = New System.Drawing.Size(1175, 253)
        Me.GCGift.TabIndex = 13
        Me.GCGift.Text = "Gift"
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
        Me.GridViewGift.CustomizationFormBounds = New System.Drawing.Rectangle(1022, 668, 208, 170)
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
        'GCSponsorShip
        '
        Me.GCSponsorShip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCSponsorShip.Controls.Add(Me.LabelControl33)
        Me.GCSponsorShip.Controls.Add(Me.LabelControl25)
        Me.GCSponsorShip.Controls.Add(Me.GridGodFather)
        Me.GCSponsorShip.Controls.Add(Me.GridSon)
        Me.GCSponsorShip.Location = New System.Drawing.Point(9, 19)
        Me.GCSponsorShip.Name = "GCSponsorShip"
        Me.GCSponsorShip.Size = New System.Drawing.Size(626, 384)
        Me.GCSponsorShip.TabIndex = 12
        Me.GCSponsorShip.Text = "Sponsorship"
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
        Me.GridGodFather.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryISponsorGodCustomers_id})
        Me.GridGodFather.Size = New System.Drawing.Size(610, 105)
        Me.GridGodFather.TabIndex = 12
        Me.GridGodFather.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridviewGodFather})
        '
        'GridviewGodFather
        '
        Me.GridviewGodFather.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldate_used, Me.father_id, Me.colfather_abo_type, Me.col2customers_lastname, Me.col2customers_firstname})
        Me.GridviewGodFather.CustomizationFormBounds = New System.Drawing.Rectangle(1382, 593, 218, 205)
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
        Me.coldate_used.VisibleIndex = 1
        Me.coldate_used.Width = 277
        '
        'father_id
        '
        Me.father_id.Caption = "customers_id"
        Me.father_id.ColumnEdit = Me.RepositoryISponsorGodCustomers_id
        Me.father_id.FieldName = "father_id"
        Me.father_id.Name = "father_id"
        Me.father_id.OptionsColumn.AllowEdit = False
        Me.father_id.Visible = True
        Me.father_id.VisibleIndex = 0
        Me.father_id.Width = 133
        '
        'RepositoryISponsorGodCustomers_id
        '
        Me.RepositoryISponsorGodCustomers_id.AutoHeight = False
        Me.RepositoryISponsorGodCustomers_id.Name = "RepositoryISponsorGodCustomers_id"
        '
        'colfather_abo_type
        '
        Me.colfather_abo_type.Caption = "abo_type"
        Me.colfather_abo_type.FieldName = "father_abo_type"
        Me.colfather_abo_type.Name = "colfather_abo_type"
        Me.colfather_abo_type.OptionsColumn.AllowEdit = False
        Me.colfather_abo_type.Visible = True
        Me.colfather_abo_type.VisibleIndex = 4
        Me.colfather_abo_type.Width = 284
        '
        'col2customers_lastname
        '
        Me.col2customers_lastname.Caption = "customers_lastname"
        Me.col2customers_lastname.FieldName = "customers_lastname"
        Me.col2customers_lastname.Name = "col2customers_lastname"
        Me.col2customers_lastname.OptionsColumn.AllowEdit = False
        Me.col2customers_lastname.Visible = True
        Me.col2customers_lastname.VisibleIndex = 2
        Me.col2customers_lastname.Width = 277
        '
        'col2customers_firstname
        '
        Me.col2customers_firstname.Caption = "customers_firstname"
        Me.col2customers_firstname.FieldName = "customers_firstname"
        Me.col2customers_firstname.Name = "col2customers_firstname"
        Me.col2customers_firstname.OptionsColumn.AllowEdit = False
        Me.col2customers_firstname.Visible = True
        Me.col2customers_firstname.VisibleIndex = 3
        Me.col2customers_firstname.Width = 277
        '
        'tabPurchase
        '
        Me.tabPurchase.AutoScroll = True
        Me.tabPurchase.Controls.Add(Me.GridShoppingOrders)
        Me.tabPurchase.Name = "tabPurchase"
        Me.tabPurchase.Size = New System.Drawing.Size(1253, 783)
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
        Me.shopping_products_id.Width = 193
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
        'tabCompensation
        '
        Me.tabCompensation.Controls.Add(Me.GridCompensation)
        Me.tabCompensation.Name = "tabCompensation"
        Me.tabCompensation.PageEnabled = False
        Me.tabCompensation.PageVisible = False
        Me.tabCompensation.Size = New System.Drawing.Size(1253, 783)
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
        Me.GridCompensation.Size = New System.Drawing.Size(1253, 783)
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
        Me.tabProductsRating.Size = New System.Drawing.Size(1253, 783)
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
        Me.GridProductsRating.Size = New System.Drawing.Size(1253, 783)
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
        Me.tabSuspendedHistory.Size = New System.Drawing.Size(1253, 783)
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
        Me.GridSuspendedHistory.Size = New System.Drawing.Size(1253, 783)
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
        'tabVodView
        '
        Me.tabVodView.Controls.Add(Me.GridViewVod)
        Me.tabVodView.Name = "tabVodView"
        Me.tabVodView.Size = New System.Drawing.Size(1253, 783)
        Me.tabVodView.Text = "Vod Viewed"
        '
        'GridViewVod
        '
        Me.GridViewVod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridViewVod.EmbeddedNavigator.Name = ""
        Me.GridViewVod.FormsUseDefaultLookAndFeel = False
        Me.GridViewVod.Location = New System.Drawing.Point(0, 0)
        Me.GridViewVod.MainView = Me.GridView1
        Me.GridViewVod.Name = "GridViewVod"
        Me.GridViewVod.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridViewVod.Size = New System.Drawing.Size(1253, 783)
        Me.GridViewVod.TabIndex = 2
        Me.GridViewVod.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcDate_added, Me.GCLast_modified, Me.GCProducts_title, Me.GCImdb_id, Me.GCCount_ip, Me.GCNb_viewed, Me.GCUsedIp, Me.GCCompensation, Me.GCID})
        Me.GridView1.GridControl = Me.GridViewVod
        Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'gcDate_added
        '
        Me.gcDate_added.Caption = "date_added"
        Me.gcDate_added.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.gcDate_added.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcDate_added.FieldName = "created_at"
        Me.gcDate_added.Name = "gcDate_added"
        Me.gcDate_added.OptionsColumn.AllowEdit = False
        Me.gcDate_added.OptionsColumn.FixedWidth = True
        Me.gcDate_added.OptionsColumn.ReadOnly = True
        Me.gcDate_added.Visible = True
        Me.gcDate_added.VisibleIndex = 2
        Me.gcDate_added.Width = 150
        '
        'GCLast_modified
        '
        Me.GCLast_modified.Caption = "last_modifed"
        Me.GCLast_modified.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.GCLast_modified.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GCLast_modified.FieldName = "updated_at"
        Me.GCLast_modified.Name = "GCLast_modified"
        Me.GCLast_modified.OptionsColumn.AllowEdit = False
        Me.GCLast_modified.OptionsColumn.FixedWidth = True
        Me.GCLast_modified.OptionsColumn.ReadOnly = True
        Me.GCLast_modified.Visible = True
        Me.GCLast_modified.VisibleIndex = 3
        Me.GCLast_modified.Width = 150
        '
        'GCProducts_title
        '
        Me.GCProducts_title.Caption = "Title"
        Me.GCProducts_title.FieldName = "products_title"
        Me.GCProducts_title.Name = "GCProducts_title"
        Me.GCProducts_title.OptionsColumn.AllowEdit = False
        Me.GCProducts_title.OptionsColumn.FixedWidth = True
        Me.GCProducts_title.OptionsColumn.ReadOnly = True
        Me.GCProducts_title.Visible = True
        Me.GCProducts_title.VisibleIndex = 1
        Me.GCProducts_title.Width = 161
        '
        'GCImdb_id
        '
        Me.GCImdb_id.Caption = "imdb_id"
        Me.GCImdb_id.FieldName = "imdb_id"
        Me.GCImdb_id.Name = "GCImdb_id"
        Me.GCImdb_id.Visible = True
        Me.GCImdb_id.VisibleIndex = 0
        '
        'GCCount_ip
        '
        Me.GCCount_ip.Caption = "max_ip"
        Me.GCCount_ip.FieldName = "count_ip"
        Me.GCCount_ip.Name = "GCCount_ip"
        Me.GCCount_ip.Visible = True
        Me.GCCount_ip.VisibleIndex = 5
        '
        'GCNb_viewed
        '
        Me.GCNb_viewed.Caption = "nb_viewed"
        Me.GCNb_viewed.FieldName = "nb_viewed"
        Me.GCNb_viewed.Name = "GCNb_viewed"
        Me.GCNb_viewed.Visible = True
        Me.GCNb_viewed.VisibleIndex = 6
        '
        'GCUsedIp
        '
        Me.GCUsedIp.Caption = "used_ip"
        Me.GCUsedIp.FieldName = "used_ip"
        Me.GCUsedIp.Name = "GCUsedIp"
        Me.GCUsedIp.Visible = True
        Me.GCUsedIp.VisibleIndex = 4
        '
        'GCCompensation
        '
        Me.GCCompensation.Caption = "compensed"
        Me.GCCompensation.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GCCompensation.FieldName = "compensed"
        Me.GCCompensation.Name = "GCCompensation"
        Me.GCCompensation.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GCCompensation.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.GCCompensation.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GCCompensation.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.GCCompensation.Visible = True
        Me.GCCompensation.VisibleIndex = 7
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.RepositoryItemCheckEdit1.AppearanceDisabled.Options.UseBackColor = True
        Me.RepositoryItemCheckEdit1.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.RepositoryItemCheckEdit1.AppearanceFocused.Options.UseBackColor = True
        Me.RepositoryItemCheckEdit1.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.RepositoryItemCheckEdit1.AppearanceReadOnly.Options.UseBackColor = True
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit1.ValueChecked = "True"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "False"
        '
        'GCID
        '
        Me.GCID.Caption = "ID"
        Me.GCID.FieldName = "id"
        Me.GCID.Name = "GCID"
        '
        'tabCritiques
        '
        Me.tabCritiques.Controls.Add(Me.lblValueRating)
        Me.tabCritiques.Controls.Add(Me.lblRating)
        Me.tabCritiques.Controls.Add(Me.lblValueAverageRatingDvdPost)
        Me.tabCritiques.Controls.Add(Me.lblAverageRatingDvdPost)
        Me.tabCritiques.Controls.Add(Me.lblValueNbCritiquePositive)
        Me.tabCritiques.Controls.Add(Me.lblNbCritiquePositive)
        Me.tabCritiques.Controls.Add(Me.lblValueNbCrtitiques)
        Me.tabCritiques.Controls.Add(Me.lblNbCrtitiques)
        Me.tabCritiques.Controls.Add(Me.lblValueRatingAverage)
        Me.tabCritiques.Controls.Add(Me.lblRatingAverage)
        Me.tabCritiques.Controls.Add(Me.GridCritiques)
        Me.tabCritiques.Name = "tabCritiques"
        Me.tabCritiques.Size = New System.Drawing.Size(1253, 783)
        Me.tabCritiques.Text = "Critiques"
        '
        'lblValueRating
        '
        Me.lblValueRating.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueRating.Appearance.Options.UseFont = True
        Me.lblValueRating.Location = New System.Drawing.Point(139, 60)
        Me.lblValueRating.Name = "lblValueRating"
        Me.lblValueRating.Size = New System.Drawing.Size(10, 22)
        Me.lblValueRating.TabIndex = 10
        Me.lblValueRating.Text = "0"
        '
        'lblRating
        '
        Me.lblRating.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRating.Appearance.Options.UseFont = True
        Me.lblRating.Location = New System.Drawing.Point(7, 65)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(53, 17)
        Me.lblRating.TabIndex = 9
        Me.lblRating.Text = "# Rating"
        '
        'lblValueAverageRatingDvdPost
        '
        Me.lblValueAverageRatingDvdPost.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueAverageRatingDvdPost.Appearance.Options.UseFont = True
        Me.lblValueAverageRatingDvdPost.Location = New System.Drawing.Point(288, 14)
        Me.lblValueAverageRatingDvdPost.Name = "lblValueAverageRatingDvdPost"
        Me.lblValueAverageRatingDvdPost.Size = New System.Drawing.Size(10, 22)
        Me.lblValueAverageRatingDvdPost.TabIndex = 8
        Me.lblValueAverageRatingDvdPost.Text = "0"
        '
        'lblAverageRatingDvdPost
        '
        Me.lblAverageRatingDvdPost.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageRatingDvdPost.Appearance.Options.UseFont = True
        Me.lblAverageRatingDvdPost.Location = New System.Drawing.Point(188, 18)
        Me.lblAverageRatingDvdPost.Name = "lblAverageRatingDvdPost"
        Me.lblAverageRatingDvdPost.Size = New System.Drawing.Size(96, 17)
        Me.lblAverageRatingDvdPost.TabIndex = 7
        Me.lblAverageRatingDvdPost.Text = "Rating DvdPost"
        '
        'lblValueNbCritiquePositive
        '
        Me.lblValueNbCritiquePositive.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueNbCritiquePositive.Appearance.Options.UseFont = True
        Me.lblValueNbCritiquePositive.Location = New System.Drawing.Point(139, 12)
        Me.lblValueNbCritiquePositive.Name = "lblValueNbCritiquePositive"
        Me.lblValueNbCritiquePositive.Size = New System.Drawing.Size(10, 22)
        Me.lblValueNbCritiquePositive.TabIndex = 6
        Me.lblValueNbCritiquePositive.Text = "0"
        '
        'lblNbCritiquePositive
        '
        Me.lblNbCritiquePositive.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbCritiquePositive.Appearance.Options.UseFont = True
        Me.lblNbCritiquePositive.Location = New System.Drawing.Point(7, 17)
        Me.lblNbCritiquePositive.Name = "lblNbCritiquePositive"
        Me.lblNbCritiquePositive.Size = New System.Drawing.Size(122, 17)
        Me.lblNbCritiquePositive.TabIndex = 5
        Me.lblNbCritiquePositive.Text = "# Critiques positives"
        '
        'lblValueNbCrtitiques
        '
        Me.lblValueNbCrtitiques.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueNbCrtitiques.Appearance.Options.UseFont = True
        Me.lblValueNbCrtitiques.Location = New System.Drawing.Point(139, 36)
        Me.lblValueNbCrtitiques.Name = "lblValueNbCrtitiques"
        Me.lblValueNbCrtitiques.Size = New System.Drawing.Size(10, 22)
        Me.lblValueNbCrtitiques.TabIndex = 4
        Me.lblValueNbCrtitiques.Text = "0"
        '
        'lblNbCrtitiques
        '
        Me.lblNbCrtitiques.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbCrtitiques.Appearance.Options.UseFont = True
        Me.lblNbCrtitiques.Location = New System.Drawing.Point(7, 41)
        Me.lblNbCrtitiques.Name = "lblNbCrtitiques"
        Me.lblNbCrtitiques.Size = New System.Drawing.Size(66, 17)
        Me.lblNbCrtitiques.TabIndex = 3
        Me.lblNbCrtitiques.Text = "# Critiques"
        '
        'lblValueRatingAverage
        '
        Me.lblValueRatingAverage.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueRatingAverage.Appearance.Options.UseFont = True
        Me.lblValueRatingAverage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblValueRatingAverage.Location = New System.Drawing.Point(427, 12)
        Me.lblValueRatingAverage.Name = "lblValueRatingAverage"
        Me.lblValueRatingAverage.Size = New System.Drawing.Size(10, 22)
        Me.lblValueRatingAverage.TabIndex = 2
        Me.lblValueRatingAverage.Text = "0"
        '
        'lblRatingAverage
        '
        Me.lblRatingAverage.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRatingAverage.Appearance.Options.UseFont = True
        Me.lblRatingAverage.Location = New System.Drawing.Point(326, 17)
        Me.lblRatingAverage.Name = "lblRatingAverage"
        Me.lblRatingAverage.Size = New System.Drawing.Size(84, 17)
        Me.lblRatingAverage.TabIndex = 1
        Me.lblRatingAverage.Text = "Rating Moyen"
        '
        'GridCritiques
        '
        Me.GridCritiques.EmbeddedNavigator.Name = ""
        Me.GridCritiques.FormsUseDefaultLookAndFeel = False
        Me.GridCritiques.Location = New System.Drawing.Point(7, 101)
        Me.GridCritiques.MainView = Me.GridViewCritiques
        Me.GridCritiques.Name = "GridCritiques"
        Me.GridCritiques.Size = New System.Drawing.Size(854, 405)
        Me.GridCritiques.TabIndex = 0
        Me.GridCritiques.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCritiques})
        '
        'GridViewCritiques
        '
        Me.GridViewCritiques.GridControl = Me.GridCritiques
        Me.GridViewCritiques.Name = "GridViewCritiques"
        Me.GridViewCritiques.OptionsView.ShowFooter = True
        '
        'tabConfig
        '
        Me.tabConfig.Controls.Add(Me.btnRefreshTab)
        Me.tabConfig.Controls.Add(Me.ChkListConfig)
        Me.tabConfig.Name = "tabConfig"
        Me.tabConfig.Size = New System.Drawing.Size(1253, 783)
        Me.tabConfig.Text = "Config"
        '
        'btnRefreshTab
        '
        Me.btnRefreshTab.Location = New System.Drawing.Point(636, 34)
        Me.btnRefreshTab.Name = "btnRefreshTab"
        Me.btnRefreshTab.Size = New System.Drawing.Size(158, 41)
        Me.btnRefreshTab.TabIndex = 1
        Me.btnRefreshTab.Text = "refresh tab"
        '
        'ChkListConfig
        '
        Me.ChkListConfig.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkListConfig.Appearance.Options.UseFont = True
        Me.ChkListConfig.CheckOnClick = True
        Me.ChkListConfig.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("comment", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("calls", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("abo history", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("messagerie", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("invoices", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("payment movements"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("mail history"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("products rating"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("suspended history"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("vod viewed"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("critiques")})
        Me.ChkListConfig.LeftCoord = 0
        Me.ChkListConfig.Location = New System.Drawing.Point(33, 43)
        Me.ChkListConfig.MultiColumn = True
        Me.ChkListConfig.Name = "ChkListConfig"
        Me.ChkListConfig.Size = New System.Drawing.Size(545, 111)
        Me.ChkListConfig.TabIndex = 0
        '
        'LabelControl39
        '
        Me.LabelControl39.Location = New System.Drawing.Point(19, 23)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(131, 16)
        Me.LabelControl39.TabIndex = 27
        Me.LabelControl39.Text = "Nombre reconduction :"
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(161, 23)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(7, 16)
        Me.LabelControl40.TabIndex = 28
        Me.LabelControl40.Text = "0"
        '
        'LabelControl41
        '
        Me.LabelControl41.Location = New System.Drawing.Point(952, 20)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl41.TabIndex = 24
        Me.LabelControl41.Text = "Next Price"
        '
        'LabelControl42
        '
        Me.LabelControl42.Location = New System.Drawing.Point(758, 20)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl42.TabIndex = 22
        Me.LabelControl42.Text = "Next Credit"
        '
        'TextEdit1
        '
        Me.TextEdit1.Enabled = False
        Me.TextEdit1.Location = New System.Drawing.Point(1025, 16)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(95, 20)
        Me.TextEdit1.TabIndex = 23
        '
        'TextEdit2
        '
        Me.TextEdit2.Enabled = False
        Me.TextEdit2.Location = New System.Drawing.Point(836, 16)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(95, 20)
        Me.TextEdit2.TabIndex = 21
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(1188, 46)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(173, 27)
        Me.SimpleButton2.TabIndex = 13
        Me.SimpleButton2.Text = "Reconduction"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(1188, 283)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(173, 26)
        Me.SimpleButton3.TabIndex = 12
        Me.SimpleButton3.Text = "&Activate by Domiciliation"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(1187, 338)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(173, 27)
        Me.SimpleButton4.TabIndex = 11
        Me.SimpleButton4.Text = "&Received domiciliation"
        Me.ToolTip1.SetToolTip(Me.SimpleButton4, "received dom 70")
        '
        'MemoEdit2
        '
        Me.MemoEdit2.Enabled = False
        Me.MemoEdit2.Location = New System.Drawing.Point(30, 151)
        Me.MemoEdit2.Name = "MemoEdit2"
        Me.MemoEdit2.Size = New System.Drawing.Size(278, 91)
        Me.MemoEdit2.StyleController = Me.LayoutCustServ
        Me.MemoEdit2.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Comment"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Enabled = False
        Me.LookUpEdit1.Location = New System.Drawing.Point(163, 81)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("reason", "reason", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("stop_phone_id", "stop_phone_id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.LookUpEdit1.Properties.DisplayMember = "reason"
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.ValueMember = "stop_phone_id"
        Me.LookUpEdit1.Size = New System.Drawing.Size(145, 20)
        Me.LookUpEdit1.TabIndex = 40
        Me.LookUpEdit1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Reason from delete"
        Me.Label3.Visible = False
        '
        'DateEdit1
        '
        Me.DateEdit1.CausesValidation = False
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Enabled = False
        Me.DateEdit1.Location = New System.Drawing.Point(163, 48)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(145, 20)
        Me.DateEdit1.TabIndex = 18
        '
        'LabelControl43
        '
        Me.LabelControl43.Location = New System.Drawing.Point(30, 52)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(70, 16)
        Me.LabelControl43.TabIndex = 13
        Me.LabelControl43.Text = "call me date"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Location = New System.Drawing.Point(1188, 465)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(173, 27)
        Me.SimpleButton5.TabIndex = 20
        Me.SimpleButton5.Text = "Delete Phone activation"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Location = New System.Drawing.Point(1188, 227)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(173, 27)
        Me.SimpleButton6.TabIndex = 9
        Me.SimpleButton6.Text = "&Activate by phone"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Location = New System.Drawing.Point(1188, 97)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(173, 26)
        Me.SimpleButton7.TabIndex = 6
        Me.SimpleButton7.Text = "Re-Activate"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.activation_discount_code_type", True))
        Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "customers.activation_discount_code_type", True))
        Me.ComboBoxEdit1.Enabled = False
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(334, 306)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"A", "D", ""})
        Me.ComboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(60, 20)
        Me.ComboBoxEdit1.TabIndex = 59
        '
        'LabelControl44
        '
        Me.LabelControl44.Location = New System.Drawing.Point(10, 172)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(132, 16)
        Me.LabelControl44.TabIndex = 51
        Me.LabelControl44.Text = "closing date of vacancy"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Enabled = False
        Me.DateEdit2.Location = New System.Drawing.Point(192, 168)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit2.Size = New System.Drawing.Size(182, 20)
        Me.DateEdit2.TabIndex = 50
        '
        'LookUpEdit3
        '
        Me.LookUpEdit3.Enabled = False
        Me.LookUpEdit3.Location = New System.Drawing.Point(192, 142)
        Me.LookUpEdit3.Name = "LookUpEdit3"
        Me.LookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit3.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 75, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit3.Properties.DisplayMember = "DisplayMember"
        Me.LookUpEdit3.Properties.NullText = ""
        Me.LookUpEdit3.Properties.ValueMember = "Value"
        Me.LookUpEdit3.Size = New System.Drawing.Size(182, 20)
        Me.LookUpEdit3.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(6, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 17)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "ABO 12 mois SummerPower"
        '
        'LabelControl45
        '
        Me.LabelControl45.Location = New System.Drawing.Point(10, 147)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl45.TabIndex = 45
        Me.LabelControl45.Text = "Suspended"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Enabled = False
        Me.SimpleButton8.Location = New System.Drawing.Point(298, 389)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(76, 26)
        Me.SimpleButton8.TabIndex = 44
        Me.SimpleButton8.Text = "Goto 30"
        Me.SimpleButton8.Visible = False
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_registration_step", True))
        Me.TextEdit6.Enabled = False
        Me.TextEdit6.Location = New System.Drawing.Point(192, 389)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Size = New System.Drawing.Size(96, 20)
        Me.TextEdit6.TabIndex = 43
        '
        'LabelControl46
        '
        Me.LabelControl46.Location = New System.Drawing.Point(10, 398)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(98, 16)
        Me.LabelControl46.TabIndex = 42
        Me.LabelControl46.Text = "Registration Step"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_home_adult", True))
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Enabled = False
        Me.SpinEdit1.Location = New System.Drawing.Point(288, 278)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit1.Size = New System.Drawing.Size(86, 20)
        Me.SpinEdit1.TabIndex = 41
        '
        'LabelControl47
        '
        Me.LabelControl47.Location = New System.Drawing.Point(10, 343)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(107, 16)
        Me.LabelControl47.TabIndex = 40
        Me.LabelControl47.Text = "Discount Recurring"
        '
        'DateEdit3
        '
        Me.DateEdit3.AllowDrop = True
        Me.DateEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_discount_recurring_to_date", True))
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.Enabled = False
        Me.DateEdit3.Location = New System.Drawing.Point(192, 333)
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit3.Size = New System.Drawing.Size(182, 20)
        Me.DateEdit3.TabIndex = 39
        '
        'CheckEdit1
        '
        Me.CheckEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_auto_stop_next_reconduction", True))
        Me.CheckEdit1.Enabled = False
        Me.CheckEdit1.Location = New System.Drawing.Point(144, 426)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Auto-Stop"
        Me.CheckEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit1.Properties.ValueChecked = 1
        Me.CheckEdit1.Properties.ValueUnchecked = 0
        Me.CheckEdit1.Size = New System.Drawing.Size(115, 19)
        Me.CheckEdit1.TabIndex = 38
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.activation_discount_code_id", True))
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "customers.activation_discount_code_id", True))
        Me.TextEdit7.Enabled = False
        Me.TextEdit7.Location = New System.Drawing.Point(192, 306)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Size = New System.Drawing.Size(134, 20)
        Me.TextEdit7.TabIndex = 37
        '
        'LookUpEdit4
        '
        Me.LookUpEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_next_discount_code", True))
        Me.LookUpEdit4.Enabled = False
        Me.LookUpEdit4.Location = New System.Drawing.Point(192, 361)
        Me.LookUpEdit4.Name = "LookUpEdit4"
        Me.LookUpEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.LookUpEdit4.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("discount_code_id", "discount_code_id", 102, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("discount_code", "discount_code", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit4.Properties.DataSource = Me.objDS.discount_code
        Me.LookUpEdit4.Properties.DisplayMember = "discount_code"
        Me.LookUpEdit4.Properties.NullText = ""
        Me.LookUpEdit4.Properties.ValueMember = "discount_code_id"
        Me.LookUpEdit4.Size = New System.Drawing.Size(182, 20)
        Me.LookUpEdit4.TabIndex = 36
        '
        'LabelControl59
        '
        Me.LabelControl59.Location = New System.Drawing.Point(10, 370)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(89, 16)
        Me.LabelControl59.TabIndex = 33
        Me.LabelControl59.Text = "Next Disc. Code"
        '
        'LabelControl60
        '
        Me.LabelControl60.Location = New System.Drawing.Point(10, 315)
        Me.LabelControl60.Name = "LabelControl60"
        Me.LabelControl60.Size = New System.Drawing.Size(128, 16)
        Me.LabelControl60.TabIndex = 31
        Me.LabelControl60.Text = "Activation / Disc. Code"
        '
        'CheckEdit2
        '
        Me.CheckEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_multishipment", True))
        Me.CheckEdit2.Enabled = False
        Me.CheckEdit2.Location = New System.Drawing.Point(10, 426)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = "Multi-Shipment"
        Me.CheckEdit2.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit2.Properties.ValueChecked = 1
        Me.CheckEdit2.Properties.ValueUnchecked = 0
        Me.CheckEdit2.Size = New System.Drawing.Size(115, 19)
        Me.CheckEdit2.TabIndex = 30
        '
        'LookUpEdit5
        '
        Me.LookUpEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_next_abo_type", True))
        Me.LookUpEdit5.Enabled = False
        Me.LookUpEdit5.Location = New System.Drawing.Point(192, 80)
        Me.LookUpEdit5.Name = "LookUpEdit5"
        Me.LookUpEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit5.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_id", "products_id", 75, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_model", "products_model", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_title", "products_title", 72, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit5.Properties.DataSource = Me.objDS.products_abo
        Me.LookUpEdit5.Properties.DisplayMember = "products_title"
        Me.LookUpEdit5.Properties.NullText = ""
        Me.LookUpEdit5.Properties.ValueMember = "products_id"
        Me.LookUpEdit5.Size = New System.Drawing.Size(182, 20)
        Me.LookUpEdit5.TabIndex = 29
        '
        'SpinEdit2
        '
        Me.SpinEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_home_norm", True))
        Me.SpinEdit2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit2.Enabled = False
        Me.SpinEdit2.Location = New System.Drawing.Point(288, 250)
        Me.SpinEdit2.Name = "SpinEdit2"
        Me.SpinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit2.Size = New System.Drawing.Size(86, 20)
        Me.SpinEdit2.TabIndex = 27
        '
        'SpinEdit3
        '
        Me.SpinEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_adult", True))
        Me.SpinEdit3.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit3.Enabled = False
        Me.SpinEdit3.Location = New System.Drawing.Point(192, 278)
        Me.SpinEdit3.Name = "SpinEdit3"
        Me.SpinEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit3.Size = New System.Drawing.Size(86, 20)
        Me.SpinEdit3.TabIndex = 26
        '
        'SpinEdit4
        '
        Me.SpinEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_norm", True))
        Me.SpinEdit4.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit4.Enabled = False
        Me.SpinEdit4.Location = New System.Drawing.Point(192, 250)
        Me.SpinEdit4.Name = "SpinEdit4"
        Me.SpinEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit4.Size = New System.Drawing.Size(86, 20)
        Me.SpinEdit4.TabIndex = 25
        '
        'LabelControl61
        '
        Me.LabelControl61.Location = New System.Drawing.Point(10, 287)
        Me.LabelControl61.Name = "LabelControl61"
        Me.LabelControl61.Size = New System.Drawing.Size(38, 16)
        Me.LabelControl61.TabIndex = 24
        Me.LabelControl61.Text = "ADULT"
        '
        'LabelControl62
        '
        Me.LabelControl62.Location = New System.Drawing.Point(10, 260)
        Me.LabelControl62.Name = "LabelControl62"
        Me.LabelControl62.Size = New System.Drawing.Size(35, 16)
        Me.LabelControl62.TabIndex = 23
        Me.LabelControl62.Text = "NORM"
        '
        'LabelControl63
        '
        Me.LabelControl63.Location = New System.Drawing.Point(298, 232)
        Me.LabelControl63.Name = "LabelControl63"
        Me.LabelControl63.Size = New System.Drawing.Size(45, 16)
        Me.LabelControl63.TabIndex = 22
        Me.LabelControl63.Text = "@Home"
        '
        'LabelControl64
        '
        Me.LabelControl64.Location = New System.Drawing.Point(192, 232)
        Me.LabelControl64.Name = "LabelControl64"
        Me.LabelControl64.Size = New System.Drawing.Size(34, 16)
        Me.LabelControl64.TabIndex = 21
        Me.LabelControl64.Text = "Asked"
        '
        'SpinEdit5
        '
        Me.SpinEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_credit", True))
        Me.SpinEdit5.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit5.Enabled = False
        Me.SpinEdit5.Location = New System.Drawing.Point(192, 204)
        Me.SpinEdit5.Name = "SpinEdit5"
        Me.SpinEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit5.Properties.MaxLength = 1000
        Me.SpinEdit5.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.SpinEdit5.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.SpinEdit5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SpinEdit5.Size = New System.Drawing.Size(182, 20)
        Me.SpinEdit5.TabIndex = 20
        '
        'LabelControl65
        '
        Me.LabelControl65.Location = New System.Drawing.Point(10, 213)
        Me.LabelControl65.Name = "LabelControl65"
        Me.LabelControl65.Size = New System.Drawing.Size(40, 16)
        Me.LabelControl65.TabIndex = 19
        Me.LabelControl65.Text = "Credits"
        '
        'LabelControl66
        '
        Me.LabelControl66.Location = New System.Drawing.Point(10, 117)
        Me.LabelControl66.Name = "LabelControl66"
        Me.LabelControl66.Size = New System.Drawing.Size(41, 16)
        Me.LabelControl66.TabIndex = 18
        Me.LabelControl66.Text = "Validity"
        '
        'DateEdit4
        '
        Me.DateEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_validityto", True))
        Me.DateEdit4.EditValue = Nothing
        Me.DateEdit4.Enabled = False
        Me.DateEdit4.Location = New System.Drawing.Point(192, 107)
        Me.DateEdit4.Name = "DateEdit4"
        Me.DateEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit4.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit4.Size = New System.Drawing.Size(182, 20)
        Me.DateEdit4.TabIndex = 17
        '
        'LookUpEdit6
        '
        Me.LookUpEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_type", True))
        Me.LookUpEdit6.Enabled = False
        Me.LookUpEdit6.Location = New System.Drawing.Point(192, 52)
        Me.LookUpEdit6.Name = "LookUpEdit6"
        Me.LookUpEdit6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit6.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_id", "products_id", 75, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_model", "products_model", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_title", "products_title", 72, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit6.Properties.DataSource = Me.objDS.products_abo
        Me.LookUpEdit6.Properties.DisplayMember = "products_title"
        Me.LookUpEdit6.Properties.NullText = ""
        Me.LookUpEdit6.Properties.ValueMember = "products_id"
        Me.LookUpEdit6.Size = New System.Drawing.Size(182, 20)
        Me.LookUpEdit6.TabIndex = 15
        '
        'LabelControl67
        '
        Me.LabelControl67.Location = New System.Drawing.Point(10, 89)
        Me.LabelControl67.Name = "LabelControl67"
        Me.LabelControl67.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl67.TabIndex = 14
        Me.LabelControl67.Text = "Next ABO"
        '
        'LabelControl68
        '
        Me.LabelControl68.Location = New System.Drawing.Point(10, 61)
        Me.LabelControl68.Name = "LabelControl68"
        Me.LabelControl68.Size = New System.Drawing.Size(24, 16)
        Me.LabelControl68.TabIndex = 12
        Me.LabelControl68.Text = "ABO"
        '
        'GridControl2
        '
        Me.GridControl2.AllowDrop = True
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.FormsUseDefaultLookAndFeel = False
        Me.GridControl2.Location = New System.Drawing.Point(18, 153)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(692, 169)
        Me.GridControl2.TabIndex = 20
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowFooter = True
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "entry_firstname"
        Me.GridColumn2.FieldName = "entry_firstname"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.FixedWidth = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 130
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "entry_lastname"
        Me.GridColumn3.FieldName = "entry_lastname"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.FixedWidth = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 156
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "entry_street_address"
        Me.GridColumn4.FieldName = "entry_street_address"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.FixedWidth = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 235
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "entry_postcode"
        Me.GridColumn5.FieldName = "entry_postcode"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.FixedWidth = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 111
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "entry_city"
        Me.GridColumn6.FieldName = "entry_city"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.FixedWidth = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 108
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "countries_name"
        Me.GridColumn7.FieldName = "countries_name"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.FixedWidth = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        Me.GridColumn7.Width = 135
        '
        'TextEdit8
        '
        Me.TextEdit8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_firstname", True))
        Me.TextEdit8.Enabled = False
        Me.TextEdit8.Location = New System.Drawing.Point(461, 32)
        Me.TextEdit8.Name = "TextEdit8"
        Me.TextEdit8.Size = New System.Drawing.Size(249, 20)
        Me.TextEdit8.TabIndex = 17
        '
        'TextEdit9
        '
        Me.TextEdit9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_lastname", True))
        Me.TextEdit9.Enabled = False
        Me.TextEdit9.Location = New System.Drawing.Point(182, 32)
        Me.TextEdit9.Name = "TextEdit9"
        Me.TextEdit9.Size = New System.Drawing.Size(269, 20)
        Me.TextEdit9.TabIndex = 16
        '
        'LabelControl69
        '
        Me.LabelControl69.Location = New System.Drawing.Point(19, 42)
        Me.LabelControl69.Name = "LabelControl69"
        Me.LabelControl69.Size = New System.Drawing.Size(33, 16)
        Me.LabelControl69.TabIndex = 15
        Me.LabelControl69.Text = "Name"
        '
        'LookUpEdit7
        '
        Me.LookUpEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_country_id", True))
        Me.LookUpEdit7.Enabled = False
        Me.LookUpEdit7.Location = New System.Drawing.Point(184, 115)
        Me.LookUpEdit7.Name = "LookUpEdit7"
        Me.LookUpEdit7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit7.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("countries_id", "countries_id", 77, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("countries_name", "countries_name", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit7.Properties.DataSource = Me.objDS.country
        Me.LookUpEdit7.Properties.DisplayMember = "countries_name"
        Me.LookUpEdit7.Properties.NullText = ""
        Me.LookUpEdit7.Properties.ValueMember = "countries_id"
        Me.LookUpEdit7.Size = New System.Drawing.Size(528, 20)
        Me.LookUpEdit7.TabIndex = 14
        '
        'TextEdit10
        '
        Me.TextEdit10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_city", True))
        Me.TextEdit10.Enabled = False
        Me.TextEdit10.Location = New System.Drawing.Point(336, 88)
        Me.TextEdit10.Name = "TextEdit10"
        Me.TextEdit10.Size = New System.Drawing.Size(374, 20)
        Me.TextEdit10.TabIndex = 13
        '
        'TextEdit11
        '
        Me.TextEdit11.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_postcode", True))
        Me.TextEdit11.Enabled = False
        Me.TextEdit11.Location = New System.Drawing.Point(182, 88)
        Me.TextEdit11.Name = "TextEdit11"
        Me.TextEdit11.Size = New System.Drawing.Size(144, 20)
        Me.TextEdit11.TabIndex = 12
        '
        'TextEdit12
        '
        Me.TextEdit12.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_street_address", True))
        Me.TextEdit12.Enabled = False
        Me.TextEdit12.Location = New System.Drawing.Point(182, 60)
        Me.TextEdit12.Name = "TextEdit12"
        Me.TextEdit12.Size = New System.Drawing.Size(528, 20)
        Me.TextEdit12.TabIndex = 10
        '
        'LabelControl70
        '
        Me.LabelControl70.Location = New System.Drawing.Point(19, 69)
        Me.LabelControl70.Name = "LabelControl70"
        Me.LabelControl70.Size = New System.Drawing.Size(46, 16)
        Me.LabelControl70.TabIndex = 8
        Me.LabelControl70.Text = "Address"
        '
        'TextEdit13
        '
        Me.TextEdit13.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customer_attributes.last_login_at", True))
        Me.TextEdit13.Enabled = False
        Me.TextEdit13.Location = New System.Drawing.Point(173, 335)
        Me.TextEdit13.Name = "TextEdit13"
        Me.TextEdit13.Size = New System.Drawing.Size(182, 20)
        Me.TextEdit13.TabIndex = 59
        '
        'SpinEdit6
        '
        Me.SpinEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.mgm_points", True))
        Me.SpinEdit6.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit6.Enabled = False
        Me.SpinEdit6.Location = New System.Drawing.Point(526, 329)
        Me.SpinEdit6.Name = "SpinEdit6"
        Me.SpinEdit6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit6.Properties.MaxLength = 100000
        Me.SpinEdit6.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.SpinEdit6.Size = New System.Drawing.Size(182, 20)
        Me.SpinEdit6.TabIndex = 26
        '
        'LabelControl71
        '
        Me.LabelControl71.Location = New System.Drawing.Point(19, 270)
        Me.LabelControl71.Name = "LabelControl71"
        Me.LabelControl71.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl71.TabIndex = 58
        Me.LabelControl71.Text = "Comment"
        '
        'CheckEdit3
        '
        Me.CheckEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.red_listed", True))
        Me.CheckEdit3.Enabled = False
        Me.CheckEdit3.Location = New System.Drawing.Point(427, 414)
        Me.CheckEdit3.Name = "CheckEdit3"
        Me.CheckEdit3.Properties.Caption = "Red Listed"
        Me.CheckEdit3.Properties.ValueChecked = 1
        Me.CheckEdit3.Properties.ValueUnchecked = 0
        Me.CheckEdit3.Size = New System.Drawing.Size(154, 19)
        Me.CheckEdit3.TabIndex = 54
        '
        'TextEdit14
        '
        Me.TextEdit14.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.comment", True))
        Me.TextEdit14.Enabled = False
        Me.TextEdit14.Location = New System.Drawing.Point(173, 267)
        Me.TextEdit14.Name = "TextEdit14"
        Me.TextEdit14.Size = New System.Drawing.Size(528, 20)
        Me.TextEdit14.TabIndex = 57
        '
        'CheckEdit4
        '
        Me.CheckEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.black_listed", True))
        Me.CheckEdit4.Enabled = False
        Me.CheckEdit4.Location = New System.Drawing.Point(427, 443)
        Me.CheckEdit4.Name = "CheckEdit4"
        Me.CheckEdit4.Properties.Caption = "Black Listed"
        Me.CheckEdit4.Properties.ValueChecked = 1
        Me.CheckEdit4.Properties.ValueUnchecked = 0
        Me.CheckEdit4.Size = New System.Drawing.Size(177, 19)
        Me.CheckEdit4.TabIndex = 53
        '
        'TextEdit15
        '
        Me.TextEdit15.Enabled = False
        Me.TextEdit15.Location = New System.Drawing.Point(355, 207)
        Me.TextEdit15.Name = "TextEdit15"
        Me.TextEdit15.Size = New System.Drawing.Size(34, 20)
        Me.TextEdit15.TabIndex = 56
        '
        'CheckEdit5
        '
        Me.CheckEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_newsletterpartner", True))
        Me.CheckEdit5.Enabled = False
        Me.CheckEdit5.Location = New System.Drawing.Point(170, 443)
        Me.CheckEdit5.Name = "CheckEdit5"
        Me.CheckEdit5.Properties.Caption = "NewsLetter Partner"
        Me.CheckEdit5.Properties.ValueChecked = 1
        Me.CheckEdit5.Properties.ValueUnchecked = 0
        Me.CheckEdit5.Size = New System.Drawing.Size(183, 19)
        Me.CheckEdit5.TabIndex = 52
        '
        'LabelControl72
        '
        Me.LabelControl72.Location = New System.Drawing.Point(19, 240)
        Me.LabelControl72.Name = "LabelControl72"
        Me.LabelControl72.Size = New System.Drawing.Size(41, 16)
        Me.LabelControl72.TabIndex = 55
        Me.LabelControl72.Text = "Gender"
        '
        'CheckEdit6
        '
        Me.CheckEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_newsletter", True))
        Me.CheckEdit6.Enabled = False
        Me.CheckEdit6.Location = New System.Drawing.Point(170, 414)
        Me.CheckEdit6.Name = "CheckEdit6"
        Me.CheckEdit6.Properties.Caption = "NewsLetter"
        Me.CheckEdit6.Properties.ValueChecked = 1
        Me.CheckEdit6.Properties.ValueUnchecked = 0
        Me.CheckEdit6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckEdit6.Size = New System.Drawing.Size(154, 19)
        Me.CheckEdit6.TabIndex = 51
        '
        'TextEdit16
        '
        Me.TextEdit16.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_gender", True))
        Me.TextEdit16.Enabled = False
        Me.TextEdit16.Location = New System.Drawing.Point(173, 237)
        Me.TextEdit16.Name = "TextEdit16"
        Me.TextEdit16.Size = New System.Drawing.Size(33, 20)
        Me.TextEdit16.TabIndex = 54
        '
        'LabelControl73
        '
        Me.LabelControl73.Location = New System.Drawing.Point(396, 332)
        Me.LabelControl73.Name = "LabelControl73"
        Me.LabelControl73.Size = New System.Drawing.Size(95, 16)
        Me.LabelControl73.TabIndex = 49
        Me.LabelControl73.Text = "Points Parainage"
        '
        'LabelControl74
        '
        Me.LabelControl74.Location = New System.Drawing.Point(396, 210)
        Me.LabelControl74.Name = "LabelControl74"
        Me.LabelControl74.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl74.TabIndex = 53
        Me.LabelControl74.Text = "years old"
        '
        'TextEdit17
        '
        Me.TextEdit17.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.wishlist_kind", True))
        Me.TextEdit17.Enabled = False
        Me.TextEdit17.Location = New System.Drawing.Point(526, 300)
        Me.TextEdit17.Name = "TextEdit17"
        Me.TextEdit17.Size = New System.Drawing.Size(182, 20)
        Me.TextEdit17.TabIndex = 48
        '
        'LabelControl75
        '
        Me.LabelControl75.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelControl75.Appearance.Options.UseForeColor = True
        Me.LabelControl75.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl75.Location = New System.Drawing.Point(239, 33)
        Me.LabelControl75.Name = "LabelControl75"
        Me.LabelControl75.Size = New System.Drawing.Size(121, 16)
        Me.LabelControl75.TabIndex = 51
        Me.LabelControl75.Text = " Set a new password"
        '
        'LabelControl76
        '
        Me.LabelControl76.Location = New System.Drawing.Point(396, 303)
        Me.LabelControl76.Name = "LabelControl76"
        Me.LabelControl76.Size = New System.Drawing.Size(75, 16)
        Me.LabelControl76.TabIndex = 47
        Me.LabelControl76.Text = "WishList Kind"
        '
        'LabelControl77
        '
        Me.LabelControl77.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelControl77.Appearance.Options.UseForeColor = True
        Me.LabelControl77.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl77.Location = New System.Drawing.Point(173, 33)
        Me.LabelControl77.Name = "LabelControl77"
        Me.LabelControl77.Size = New System.Drawing.Size(33, 16)
        Me.LabelControl77.TabIndex = 50
        Me.LabelControl77.Text = "Logas"
        '
        'TextEdit18
        '
        Me.TextEdit18.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customer_attributes.number_of_logins", True))
        Me.TextEdit18.Enabled = False
        Me.TextEdit18.Location = New System.Drawing.Point(173, 363)
        Me.TextEdit18.Name = "TextEdit18"
        Me.TextEdit18.Size = New System.Drawing.Size(182, 20)
        Me.TextEdit18.TabIndex = 46
        '
        'LabelControl78
        '
        Me.LabelControl78.Location = New System.Drawing.Point(19, 155)
        Me.LabelControl78.Name = "LabelControl78"
        Me.LabelControl78.Size = New System.Drawing.Size(35, 16)
        Me.LabelControl78.TabIndex = 49
        Me.LabelControl78.Text = "E-Mail"
        '
        'LabelControl79
        '
        Me.LabelControl79.Location = New System.Drawing.Point(17, 365)
        Me.LabelControl79.Name = "LabelControl79"
        Me.LabelControl79.Size = New System.Drawing.Size(79, 16)
        Me.LabelControl79.TabIndex = 45
        Me.LabelControl79.Text = "Nbr of Logons"
        '
        'LookUpEdit8
        '
        Me.LookUpEdit8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.EntityID", True))
        Me.LookUpEdit8.Enabled = False
        Me.LookUpEdit8.Location = New System.Drawing.Point(173, 87)
        Me.LookUpEdit8.Name = "LookUpEdit8"
        Me.LookUpEdit8.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit8.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 33, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit8.Properties.DataSource = Me.objDS.generalentity
        Me.LookUpEdit8.Properties.DisplayMember = "Name"
        Me.LookUpEdit8.Properties.NullText = ""
        Me.LookUpEdit8.Properties.ValueMember = "EntityID"
        Me.LookUpEdit8.Size = New System.Drawing.Size(269, 20)
        Me.LookUpEdit8.TabIndex = 44
        '
        'LabelControl80
        '
        Me.LabelControl80.Location = New System.Drawing.Point(17, 337)
        Me.LabelControl80.Name = "LabelControl80"
        Me.LabelControl80.Size = New System.Drawing.Size(61, 16)
        Me.LabelControl80.TabIndex = 44
        Me.LabelControl80.Text = "Last Logon"
        '
        'LabelControl81
        '
        Me.LabelControl81.Location = New System.Drawing.Point(18, 90)
        Me.LabelControl81.Name = "LabelControl81"
        Me.LabelControl81.Size = New System.Drawing.Size(31, 16)
        Me.LabelControl81.TabIndex = 43
        Me.LabelControl81.Text = "Entity"
        '
        'LabelControl82
        '
        Me.LabelControl82.Location = New System.Drawing.Point(336, 59)
        Me.LabelControl82.Name = "LabelControl82"
        Me.LabelControl82.Size = New System.Drawing.Size(45, 16)
        Me.LabelControl82.TabIndex = 42
        Me.LabelControl82.Text = "Created"
        '
        'LookUpEdit9
        '
        Me.LookUpEdit9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_language", True))
        Me.LookUpEdit9.Enabled = False
        Me.LookUpEdit9.Location = New System.Drawing.Point(173, 300)
        Me.LookUpEdit9.Name = "LookUpEdit9"
        Me.LookUpEdit9.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit9.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 32, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit9.Properties.DataSource = Me.objDS.languages
        Me.LookUpEdit9.Properties.DisplayMember = "name"
        Me.LookUpEdit9.Properties.NullText = ""
        Me.LookUpEdit9.Properties.ValueMember = "languages_id"
        Me.LookUpEdit9.Size = New System.Drawing.Size(182, 20)
        Me.LookUpEdit9.TabIndex = 17
        '
        'DateEdit5
        '
        Me.DateEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_info_date_account_created", True))
        Me.DateEdit5.EditValue = Nothing
        Me.DateEdit5.Enabled = False
        Me.DateEdit5.Location = New System.Drawing.Point(451, 59)
        Me.DateEdit5.Name = "DateEdit5"
        Me.DateEdit5.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.DateEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit5.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit5.Size = New System.Drawing.Size(173, 20)
        Me.DateEdit5.TabIndex = 41
        '
        'LabelControl83
        '
        Me.LabelControl83.Location = New System.Drawing.Point(17, 309)
        Me.LabelControl83.Name = "LabelControl83"
        Me.LabelControl83.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl83.TabIndex = 16
        Me.LabelControl83.Text = "Language"
        '
        'TextEdit19
        '
        Me.TextEdit19.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_telephone", True))
        Me.TextEdit19.Enabled = False
        Me.TextEdit19.Location = New System.Drawing.Point(173, 179)
        Me.TextEdit19.Name = "TextEdit19"
        Me.TextEdit19.Size = New System.Drawing.Size(269, 20)
        Me.TextEdit19.TabIndex = 20
        '
        'HyperLinkEdit1
        '
        Me.HyperLinkEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_email_address", True))
        Me.HyperLinkEdit1.Enabled = False
        Me.HyperLinkEdit1.Location = New System.Drawing.Point(173, 151)
        Me.HyperLinkEdit1.Name = "HyperLinkEdit1"
        Me.HyperLinkEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.HyperLinkEdit1.Size = New System.Drawing.Size(528, 20)
        Me.HyperLinkEdit1.TabIndex = 19
        '
        'TextEdit20
        '
        Me.TextEdit20.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_telephone_evening", True))
        Me.TextEdit20.Enabled = False
        Me.TextEdit20.Location = New System.Drawing.Point(451, 179)
        Me.TextEdit20.Name = "TextEdit20"
        Me.TextEdit20.Size = New System.Drawing.Size(250, 20)
        Me.TextEdit20.TabIndex = 18
        '
        'LabelControl84
        '
        Me.LabelControl84.Location = New System.Drawing.Point(19, 181)
        Me.LabelControl84.Name = "LabelControl84"
        Me.LabelControl84.Size = New System.Drawing.Size(100, 16)
        Me.LabelControl84.TabIndex = 16
        Me.LabelControl84.Text = "Tel Day / Evening"
        '
        'CheckEdit7
        '
        Me.CheckEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo", True))
        Me.CheckEdit7.Enabled = False
        Me.CheckEdit7.Location = New System.Drawing.Point(634, 59)
        Me.CheckEdit7.Name = "CheckEdit7"
        Me.CheckEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Red
        Me.CheckEdit7.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CheckEdit7.Properties.Appearance.Options.UseBackColor = True
        Me.CheckEdit7.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit7.Properties.Caption = "ABO"
        Me.CheckEdit7.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit7.Properties.ValueChecked = 1
        Me.CheckEdit7.Properties.ValueUnchecked = 0
        Me.CheckEdit7.Size = New System.Drawing.Size(67, 21)
        Me.CheckEdit7.TabIndex = 15
        '
        'LabelControl85
        '
        Me.LabelControl85.Location = New System.Drawing.Point(19, 210)
        Me.LabelControl85.Name = "LabelControl85"
        Me.LabelControl85.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl85.TabIndex = 11
        Me.LabelControl85.Text = "Date of Birth"
        '
        'DateEdit6
        '
        Me.DateEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_dob", True))
        Me.DateEdit6.EditValue = Nothing
        Me.DateEdit6.Enabled = False
        Me.DateEdit6.Location = New System.Drawing.Point(173, 207)
        Me.DateEdit6.Name = "DateEdit6"
        Me.DateEdit6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit6.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit6.Size = New System.Drawing.Size(153, 20)
        Me.DateEdit6.TabIndex = 10
        '
        'TextEdit21
        '
        Me.TextEdit21.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_firstname", True))
        Me.TextEdit21.Enabled = False
        Me.TextEdit21.Location = New System.Drawing.Point(451, 123)
        Me.TextEdit21.Name = "TextEdit21"
        Me.TextEdit21.Size = New System.Drawing.Size(250, 20)
        Me.TextEdit21.TabIndex = 9
        '
        'TextEdit22
        '
        Me.TextEdit22.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_lastname", True))
        Me.TextEdit22.Enabled = False
        Me.TextEdit22.Location = New System.Drawing.Point(173, 123)
        Me.TextEdit22.Name = "TextEdit22"
        Me.TextEdit22.Size = New System.Drawing.Size(269, 20)
        Me.TextEdit22.TabIndex = 7
        '
        'LabelControl86
        '
        Me.LabelControl86.Location = New System.Drawing.Point(19, 127)
        Me.LabelControl86.Name = "LabelControl86"
        Me.LabelControl86.Size = New System.Drawing.Size(33, 16)
        Me.LabelControl86.TabIndex = 6
        Me.LabelControl86.Text = "Name"
        '
        'TextEdit23
        '
        Me.TextEdit23.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_id", True))
        Me.TextEdit23.Enabled = False
        Me.TextEdit23.Location = New System.Drawing.Point(173, 59)
        Me.TextEdit23.Name = "TextEdit23"
        Me.TextEdit23.Properties.ReadOnly = True
        Me.TextEdit23.Size = New System.Drawing.Size(153, 20)
        Me.TextEdit23.TabIndex = 5
        '
        'LabelControl87
        '
        Me.LabelControl87.Location = New System.Drawing.Point(19, 62)
        Me.LabelControl87.Name = "LabelControl87"
        Me.LabelControl87.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl87.TabIndex = 4
        Me.LabelControl87.Text = "Customer ID"
        '
        'SimpleButton9
        '
        Me.SimpleButton9.Location = New System.Drawing.Point(1187, 417)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(173, 26)
        Me.SimpleButton9.TabIndex = 2
        Me.SimpleButton9.Text = "Stop NOW"
        '
        'SimpleButton10
        '
        Me.SimpleButton10.Location = New System.Drawing.Point(1187, 150)
        Me.SimpleButton10.Name = "SimpleButton10"
        Me.SimpleButton10.Size = New System.Drawing.Size(173, 27)
        Me.SimpleButton10.TabIndex = 3
        Me.SimpleButton10.Text = "Stop @ Reconduction"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(563, 26)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(101, 21)
        Me.LabelControl12.TabIndex = 1
        Me.LabelControl12.Text = "Rating Moyen"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(609, 53)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(13, 28)
        Me.LabelControl13.TabIndex = 2
        Me.LabelControl13.Text = "0"
        '
        'GridControl3
        '
        Me.GridControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridControl3.EmbeddedNavigator.Name = ""
        Me.GridControl3.FormsUseDefaultLookAndFeel = False
        Me.GridControl3.Location = New System.Drawing.Point(3, 3)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(400, 286)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        '
        'frmCustomers_Maint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1262, 874)
        Me.Controls.Add(Me.XTabCustomers)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCustomers_Maint"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.XTabCustomers, 0)
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(GridchkAbo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(GridchkBlackList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNextPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewGodson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryISponsorCustomers_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMailHistory.ResumeLayout(False)
        CType(Me.grpContEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCustServ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewCustServ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPaymentMovements.ResumeLayout(False)
        CType(Me.GCBankAccountMovement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCBankAccountMovement.ResumeLayout(False)
        CType(Me.GridBankAccountMovements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewBankAccountMovements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryCmbMatching, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridABO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewABO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPayment.ResumeLayout(False)
        Me.tabPayment.PerformLayout()
        CType(Me.GridPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPayment, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalcEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPayMethod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCustServ.ResumeLayout(False)
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
        CType(Me.LCGMisc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCGResponse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCCustServ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCCustServ.ResumeLayout(False)
        CType(Me.chkCustServSendMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryICustomersCustomers_id, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAboHistory.ResumeLayout(False)
        Me.tabMain.ResumeLayout(False)
        Me.tabMain.PerformLayout()
        CType(Me.GCACtPhone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCACtPhone.ResumeLayout(False)
        Me.GCACtPhone.PerformLayout()
        CType(Me.MemoOtherReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPhoneActivDelete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateCallPhoneActivation.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateCallPhoneActivation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCAboInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCAboInfo.ResumeLayout(False)
        Me.GCAboInfo.PerformLayout()
        CType(Me.txtTVODFreeCredits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCustomerLockedForReconduction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateConfirmationSentAt.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateConfirmationSentAt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateConfirmedAt.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateConfirmedAt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDiscountActivation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDiscType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEndOfHoliday.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEndOfHoliday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSuspended.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegistrationStep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscRecurring.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscRecurring.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAutoStop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNextDiscCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNextABO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbo_ValidityTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbo_ValidityTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbABO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCadresse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCadresse.ResumeLayout(False)
        Me.GCadresse.PerformLayout()
        CType(Me.txtDate_added_Current.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDeliverycountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryPostCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryAddr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCcustomersInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCcustomersInfo.ResumeLayout(False)
        Me.GCcustomersInfo.PerformLayout()
        CType(Me.txtDateCreated.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateCreated.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLast_logon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYearsOld.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNewsLetterPartner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNewsLetter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNbrOfLogons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtABO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateBirthday.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateBirthday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomers_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSearch.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtPPAgreementID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCustomers_NumComm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_domiciliation_number_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_postcode_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_address_street_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_email_address_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_name_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_id_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XTabCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabCustomers.ResumeLayout(False)
        Me.tabComment.ResumeLayout(False)
        CType(Me.MemoCustomersComment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCustComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCustComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoInsertComment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCalls.ResumeLayout(False)
        Me.tabMessagerie.ResumeLayout(False)
        Me.tabSponsorShip.ResumeLayout(False)
        CType(Me.GCCodeLinked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCCodeLinked.ResumeLayout(False)
        CType(Me.GridCodeLinked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCodeLinked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCSponsonCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCSponsonCard.ResumeLayout(False)
        Me.GCSponsonCard.PerformLayout()
        CType(Me.txtCard5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCard4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCard3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCard2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCard1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpCustomersPoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCustomersPoint.ResumeLayout(False)
        CType(Me.GridCustPointHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCustPointHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCGift, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCGift.ResumeLayout(False)
        CType(Me.GridGift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewGift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCSponsorShip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCSponsorShip.ResumeLayout(False)
        Me.GCSponsorShip.PerformLayout()
        CType(Me.GridGodFather, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridviewGodFather, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryISponsorGodCustomers_id, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPurchase.ResumeLayout(False)
        CType(Me.GridShoppingOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewShoppingOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCompensation.ResumeLayout(False)
        CType(Me.GridCompensation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCompensation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProductsRating.ResumeLayout(False)
        CType(Me.GridProductsRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewProductsRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSuspendedHistory.ResumeLayout(False)
        CType(Me.GridSuspendedHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSuspendedHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabVodView.ResumeLayout(False)
        CType(Me.GridViewVod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCritiques.ResumeLayout(False)
        Me.tabCritiques.PerformLayout()
        CType(Me.GridCritiques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCritiques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConfig.ResumeLayout(False)
        CType(Me.ChkListConfig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit4.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit13.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit15.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit16.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit17.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit18.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit5.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit19.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit20.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit6.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit21.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit22.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit23.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Dim modeEdit As Boolean = False
    Dim _dataSet As New DataSet()
    Dim refreshTab As New List(Of Boolean)
    Dim _saveCustomersComment As Boolean

    Dim _oldCredit As Integer
    Dim _newCredit As Integer
    Dim _oldMgm As Integer
    Dim _newMgm As Integer
    Dim _old_date_Holiday As Date
    Dim _oldSuspended As Integer
    Dim _oldNextAboType As Integer
    Dim _oldAboType As Integer
    Private _lstSuspended As New List(Of PlushBuziness.clsKeyCombo)
    Private _lstADULTSVOD As New List(Of PlushBuziness.clsKeyCombo)
    Private _loadInfo As Boolean


    Public Sub Local_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim menuStrip As New PlushBuziness.contextMenu()

        'MemoInsertComment.Properties.WordWrap

        GridControl1.ContextMenuStrip = menuStrip
        GridAddress.ContextMenuStrip = menuStrip
        'GridWishList.ContextMenuStrip = menuStrip
        'GridWishListAssigned.ContextMenuStrip = menuStrip
        GridCustComment.ContextMenuStrip = menuStrip
        GridABO.ContextMenuStrip = menuStrip
        'GridOrders.ContextMenuStrip = menuStrip
        'GridOrdersStatusHistory.ContextMenuStrip = menuStrip
        GridCustServ.ContextMenuStrip = menuStrip
        GridPayment.ContextMenuStrip = menuStrip
        GridBankAccountMovements.ContextMenuStrip = menuStrip
        'GridAboprocessOld.ContextMenuStrip = menuStrip
        grpContEmail.ContextMenuStrip = menuStrip
        GridShoppingOrders.ContextMenuStrip = menuStrip
        'GridCreditHistory.ContextMenuStrip = menuStrip
        GridCodeLinked.ContextMenuStrip = menuStrip
        GridSon.ContextMenuStrip = menuStrip
        GridGodFather.ContextMenuStrip = menuStrip
        GridGift.ContextMenuStrip = menuStrip
        GridCustPointHistory.ContextMenuStrip = menuStrip
        GridCompensation.ContextMenuStrip = menuStrip
        GridProductsRating.ContextMenuStrip = menuStrip
        GridSuspendedHistory.ContextMenuStrip = menuStrip
        'GridDroselia.ContextMenuStrip = menuStrip
        GridViewVod.ContextMenuStrip = menuStrip
        GridCritiques.ContextMenuStrip = menuStrip

        'clsDevExpress.AddHyperlinkDynamic(GridWishList)
        'clsDevExpress.AddHyperlinkDynamic(GridWishListAssigned)
        'clsDevExpress.AddHyperlinkDynamic(GridOrders)
        clsDevExpress.AddHyperlinkDynamic(GridPayment)
        clsDevExpress.AddHyperlinkDynamic(GridBankAccountMovements)
        'clsDevExpress.AddHyperlinkDynamic(gridAboprocess)
        'clsDevExpress.AddHyperlinkDynamic(GridAboprocessOld)
        clsDevExpress.AddHyperlinkDynamic(GridSon)
        clsDevExpress.AddHyperlinkDynamic(GridGodFather)
        clsDevExpress.AddHyperlinkDynamic(GridCompensation)
        clsDevExpress.AddHyperlinkDynamic(GridProductsRating)
        'clsDevExpress.AddHyperlinkDynamic(GridViewVod)
        clsDevExpress.AddHyperlinkDynamicWithCheckBox(GridViewVod)

        Me._dataSet.Tables.Add("reason_to_stop") ' for stop the abo with the button "stop abo"

        Me.lblAboSumP.Visible = False
        GCACtPhone.Visible = False


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
            'GridViewWishList.ExpandAllGroups()

            XTabCustomers.SelectedTabPage = tabSearch
            btnForcedReconduction.Visible = PlushData.clsSession.isAdmin
            loadTypeMatching()
            EnablingEditFields(False)
            HideAllTab()

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
        '_oldCredit = txtABOCredit.EditValue
        '_newCredit = txtABOCredit.EditValue
        '_oldMgm = txtPtSponsorShip.EditValue
        '_newMgm = txtPtSponsorShip.EditValue
        _oldSuspended = cmbSuspended.EditValue
        _oldNextAboType = cmbNextABO.EditValue
        _oldAboType = cmbABO.EditValue
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
        If _CurrentCustomerID > 0 Then
            LoadCustomerInfo()
        End If
        OpenType = "BROWSE"

    End Sub
    Private Sub SaveChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuSave.Click, MyBase.EventSaveChanges

        Try

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
            MsgBox("Error Save Data " & eUpdate.Message, MsgBoxStyle.Critical)
        Finally
        End Try
    End Sub


    Private Function UpdateCreditHistory() As Boolean
        '_newCredit = txtABOCredit.EditValue
        Dim update As Boolean = False
        If _oldCredit <> _newCredit Then

            If Math.Abs(calculCredit(_oldCredit, _newCredit)) >= 5 Then
                If MsgBox("Update Credit " & _oldCredit & " -> " & _newCredit, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    update = True
                End If
            Else
                update = True
            End If
        Else
            Return True
        End If

        If update Then
            addCreditToCustomers(calculCredit(_oldCredit, _newCredit), _CurrentCustomerID, PlushData.clsCreditHistory.ActionId.MANUAL_CREDIT, _oldCredit)
        End If

        Return update
    End Function
    Public Sub UpdateDataSet() Handles MyBase.EventUpdateDataset
        If objDS.Tables(TableName).Rows.Count = 0 Then Return
        Try
            PlushData.clsConnection.CreateTransaction(False)

            '_newMgm = txtPtSponsorShip.EditValue
            'If _newMgm <> _oldMgm Then
            '    PlushData.clsConnection.ExecuteNonQuery(PlushData.clsMemberGetMember.insertCustomersPointHist(_CurrentCustomerID, PlushData.clsMemberGetMember.PointsHistoryAction.ADD, PlushData.clsMemberGetMember.PointsHistorySubAction.POINT_MANUAL_ALLOCATION, calculCredit(_oldMgm, _newMgm)))
            '    refreshTab(XTabCustomers.SelectedTabPageIndex) = True
            ''End If
            upgrade_downgrade()
            suspended()
            'If Not UpdateCreditHistory() Then
            '    PlushData.clsConnection.CommitTransaction(False)
            '    refreshClient()
            '    Return
            'End If
            'updateInsertPhoneActivation(False)

            Me.BindingContext(objDS, TableName).EndCurrentEdit()
            Me.BindingContext(objDS, "address_book_default").EndCurrentEdit()
            'Me.BindingContext(objDS, "customer_attributes").EndCurrentEdit()

            ' DvdPostData.clsConnection.UpdateDataTableInDB(objDS.Tables(TableName), "SELECT * FROM customers where customers_id = " & _CurrentCustomerID)
            MainData.Save()


            PlushData.clsConnection.CommitTransaction(True)

            refreshClient()

        Catch ex As Exception
            PlushData.clsConnection.CommitTransaction(False)
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.SignaletiqueCustomer, ex)
            Throw ex
        End Try
    End Sub




    Public Sub LoadBKComboSet()
        Try
            BKCombo.GetCombo(objDS, "country", "countries_name", "SELECT * FROM country")
            BKCombo.GetCombo(objDS, "products_abo", "products_id", "SELECT products_id, products_model, products_title FROM products where products_type = 'ABO' ")
            'BKCombo.GetCombo(objDS, "ppv_status", "ppv_status_id", "SELECT ppv_status_id, ppv_status_name FROM ppv_status ")
            ' DvdPostData.clsConnection.FillDataSet(objDS.Tables("abo_action"), "SELECT * FROM abo_action")
            ' DvdPostData.clsConnection.FillDataSet(objDS.Tables("orders_status"), "SELECT * FROM orders_status WHERE language_id = 1 ")
            PlushData.clsConnection.FillDataSet(objDS.Tables("ppv_status"), "SELECT id as ppv_status_id, name as ppv_status_name FROM ppv_status")
            PlushData.clsConnection.FillDataSet(objDS.Tables("discount_code"), "SELECT discount_code code ,discount_code_id code_id,dc.* FROM discount_code dc ")
            PlushData.clsConnection.FillDataSet(objDS.Tables("languages"), "SELECT * FROM languages")
            PlushData.clsConnection.FillDataSet(objDS.Tables("generalentity"), "SELECT EntityID, name, description, currcode FROM generalentity")
            PlushData.clsConnection.FillDataSet(objDS.Tables("customers_abo_payment_method"), "SELECT * FROM customers_abo_payment_method c")
            If Not objDS.Tables.Contains("User_dvdPost") Then objDS.Tables.Add("User_dvdPost")
            PlushData.clsConnection.FillDataSet(objDS.Tables("User_dvdPost"), "SELECT customers_id FROM securityuser where not customers_id is null")

            '  DvdPostData.clsConnection.FillDataSet(objDS.Tables("domiciliation_status"), "SELECT * FROM domiciliation_status  where language_id = 1")
            '   DvdPostData.clsConnection.FillDataSet(objDS.Tables("payment_status"), "SELECT * FROM payment_status ")
            '   DvdPostData.clsConnection.FillDataSet(objDS.Tables("ogone_payment_status"), "SELECT * FROM ogone_payment_status ")
            ' DvdPostData.clsConnection.FillDataSet(objDS.Tables("cc_expiration_status"), "SELECT * FROM cc_expiration_status  where language_id = 1 ")
            '  DvdPostData.clsConnection.FillDataSet(objDS.Tables("custserv_cat"), "SELECT * FROM custserv_cat  where language_id = 1 ")
            '  DvdPostData.clsConnection.FillDataSet(objDS.Tables("payment_offline_status"), "SELECT * FROM payment_offline_status ")
            LoadSuspended()
            LoadADULTSVOD()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#Region "Search"
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        UndoChanges(sender, e)
        Search()
    End Sub
    Public Sub Search()
        ' SendMail()
        Dim sql As String

        Dim customers_id As String
        Dim email As String
        Dim NameCustomer As String
        Dim streetCustomer As String
        Dim PostCodeCustomer As String
        Dim PayPalAgreementID As String
        Dim NumDom As String
        Dim NumComm As String

        Dim param As PlushBuziness.clsSingleton
        param = PlushBuziness.clsSingleton.Instance()

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
        PayPalAgreementID = txtPPAgreementID.Text.Trim
        sql = PlushData.ClsCustomersData.GetSelectCustomersSearch(customers_id, email, NameCustomer, streetCustomer, PostCodeCustomer, NumDom, NumComm, PayPalAgreementID)

        Dim dt As DataTable
        dt = PlushData.clsConnection.FillDataSet(sql)
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

        sql = PlushData.clsPhoneActivation.GetPhoneActivation()
        dt = PlushData.clsConnection.FillDataSet(sql)
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
        refreshTab.Clear()
        For Each tab As DevExpress.XtraTab.XtraTabPage In XTabCustomers.TabPages
            refreshTab.Add(True)
            'ChkListConfig.Items(1).Value   
        Next
        _saveCustomersComment = True

        LoadCustomerInfo()

    End Sub

    'Private Sub GridViewSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
    '    If GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle) Is Nothing Then Return
    '    _CurrentCustomerID = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle)("customers_id")
    '    refreshClient()

    '    XTabCustomers.SelectedTabPage = tabMain
    'End Sub
#End Region

    Private Sub loadVod(ByVal index As Integer, ByVal customers_id As Integer)
        Dim sql As String
        If refreshTab(index) Then
            Try
                Dim dt As DataTable

                sql = PlushData.ClsVod.getViewVod(customers_id)
                dt = PlushData.clsConnection.FillDataSet(sql)
                GridViewVod.DataSource = dt
            Catch ex As Exception
                MsgBox("Num client is not valid")
            End Try
            refreshTab(index) = False
        End If
    End Sub
    Private Sub loadMessagerie(ByVal index As Integer, ByVal customers_id As Integer)

        If refreshTab(index) Then
            UcMessagerieCustomer.LoadMessagerie()
            refreshTab(index) = False
        End If
    End Sub
    Private Sub loadPayment(ByVal index As Integer, ByVal customers_id As Integer)
        Dim sql As String
        If refreshTab(index) Then
            Try

                Dim dt As DataTable

                sql = PlushData.ClsMatching.GetDataPayment(customers_id, checkOpenPayment.Checked)
                dt = PlushData.clsConnection.FillDataSet(sql)
                GridPayment.DataSource = dt
            Catch ex As Exception
                MsgBox("Num client is not valid" & ex.Message)
            End Try
            refreshTab(index) = False
        End If
    End Sub
    Private Sub loadTypeMatching()
        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.ClsMatching.GetTypeMatching()
        dt = PlushData.clsConnection.FillDataSet(sql)

        RepositoryCmbMatching.DataSource = dt
        ' RepositoryCmbMatching.DisplayMember = "name"
        ' RepositoryCmbMatching.ValueMember = "id"


    End Sub

    Private Sub loadBankAccountMovement(ByVal index As Integer, ByVal customers_id As Integer)
        Dim sql As String
        Dim dt As DataTable
        If refreshTab(index) Then
            loadTypeMatching()

            sql = PlushData.ClsMatching.GetMatchingByall(customers_id)
            dt = PlushData.clsConnection.FillDataSet(sql)

            GridBankAccountMovements.DataSource = dt
            refreshTab(index) = False
        End If

    End Sub

    Private Sub loadCritique(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then
            Dim dt_reviews As DataTable
            Dim dt As DataTable
            Dim dr As DataRow

            dt_reviews = PlushBuziness.clsReviews.GetReviewCustomer(customers_id)
            GridCritiques.DataSource = dt_reviews
            GridViewCritiques.Columns("critique").OptionsColumn.FixedWidth = True
            GridViewCritiques.Columns("critique").Width = 700
            GridViewCritiques.BestFitColumns()
            clsDevExpress.AddHyperlinkDynamic(GridCritiques)
            clsDevExpress.AddCountFooter(GridCritiques)
            dt = PlushBuziness.clsReviews.GetAverageCritiqueCustomers(customers_id)

            If dt.Rows.Count > 0 Then
                dr = dt.Rows(0)
                lblValueNbCritiquePositive.Text = dr("cpt_critiques_positive")
                lblValueRatingAverage.Text = String.Format("{0:##}", dr("average_rating_critique"))
            End If

            dt = PlushBuziness.clsReviews.GetCritiqueCustomers(customers_id)
            If dt.Rows.Count > 0 Then
                dr = dt.Rows(0)
                lblValueNbCrtitiques.Text = dr("cpt_critiques")
                If dr("average_rating") Is DBNull.Value Then
                    lblValueAverageRatingDvdPost.Text = 0
                Else
                    lblValueAverageRatingDvdPost.Text = String.Format("{0:##}", dr("average_rating"))
                End If


            End If

            dt = PlushBuziness.clsReviews.GetRating(customers_id)
            If dt.Rows.Count > 0 Then
                dr = dt.Rows(0)
                lblValueRating.Text = dr("cpt_rating")
            End If


            refreshTab(index) = False
        End If
    End Sub
    'Private Sub loadwishlist(ByVal index As Integer, ByVal customers_id As Integer, ByVal lang_id As Integer)

    '    If refreshTab(index) Then

    '        Dim sql As String
    '        Dim dt As DataTable
    '        sql = PlushData.ClsCustomersData.GetSelectWishlist(customers_id, lang_id)
    '        dt = PlushData.clsConnection.FillDataSet(sql)
    '        GridWishList.DataSource = dt
    '        GridViewWishList.BestFitColumns()
    '        GridViewWishList.ExpandAllGroups()

    '        sql = PlushData.ClsCustomersData.GetSelectWishlistAssigned(customers_id, lang_id)
    '        dt = PlushData.clsConnection.FillDataSet(sql)
    '        GridWishListAssigned.DataSource = dt

    '        GridViewWishListAssigned.BestFitColumns()
    '        GridViewWishListAssigned.ExpandAllGroups()

    '        sql = PlushData.ClsCustomersData.getSelectInfoWishlist(customers_id, PlushData.clsProductDvd.Type_DVD.DVD_NORM)
    '        dt = PlushData.clsConnection.FillDataSet(sql)
    '        gridInfoNorm.DataSource = dt

    '        sql = PlushData.ClsCustomersData.getSelectInfoWishlist(customers_id, PlushData.clsProductDvd.Type_DVD.DVD_ADULT)
    '        dt = PlushData.clsConnection.FillDataSet(sql)
    '        gridInfoAdult.DataSource = dt


    '        refreshTab(index) = False
    '    End If
    'End Sub

    'Private Sub loadOrders(ByVal index As Integer, ByVal customers_id As Integer)
    '    If refreshTab(index) Then

    '        Dim dt As New DataTable
    '        Dim sql As String = PlushData.clsOdersStatusHistory.GetOrdersByCustomers(customers_id)
    '        dt = PlushData.clsConnection.FillDataSet(sql)
    '        GridOrders.DataSource = dt
    '        GridViewOrders.BestFitColumns()
    '        GridViewOrders.ExpandAllGroups()


    '        refreshTab(index) = False
    '    End If

    'End Sub

    'Private Sub loadOrderHistory(ByVal orders_id As Integer)
    '    Dim dt As New DataTable
    '    Dim sql As String = PlushData.clsOdersStatusHistory.GetOrderHistory(orders_id)
    '    dt = PlushData.clsConnection.FillDataSet(sql)
    '    GridOrdersStatusHistory.DataSource = dt
    'End Sub

    'Public Sub GridViewOders_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) 
    '    If GridViewOrders.RowCount <> 0 Then
    '        Dim oders_id As Integer = GridViewOrders.GetDataRow(GridViewOrders.FocusedRowHandle)("orders_id")
    '        loadOrderHistory(oders_id)
    '    Else
    '        GridOrdersStatusHistory.DataSource = Nothing
    '    End If
    'End Sub

    Private Sub LoadSuspended()

        _lstSuspended.Add(New PlushBuziness.clsKeyCombo("HOLIDAY", 1))
        _lstSuspended.Add(New PlushBuziness.clsKeyCombo("SUSPENDED", 2))
        _lstSuspended.Add(New PlushBuziness.clsKeyCombo("", 0))
        Me.cmbSuspended.Properties.DataSource = _lstSuspended
        cmbSuspended.Enabled = False

    End Sub

    Private Sub LoadADULTSVOD()

        _lstADULTSVOD.Add(New PlushBuziness.clsKeyCombo("CHARGE_ACTIVE", 1))
        _lstADULTSVOD.Add(New PlushBuziness.clsKeyCombo("ACTIVE", 2))
        _lstADULTSVOD.Add(New PlushBuziness.clsKeyCombo("CHARGE_STOPNEXTRECONDUCTION", 3))
        _lstADULTSVOD.Add(New PlushBuziness.clsKeyCombo("STOPNEXTRECONDUCTION", 4))
        _lstADULTSVOD.Add(New PlushBuziness.clsKeyCombo("STOPED", 0))
        _lstSuspended.Add(New PlushBuziness.clsKeyCombo("", -1))
        'Me.cmbADULTSVODStatus.Properties.DataSource = _lstADULTSVOD
        'cmbADULTSVODStatus.Enabled = False

    End Sub

    Private Sub loadAboHist(ByVal index As Integer, ByVal customers_id As Integer)

        If refreshTab(index) Then
            'Dim mvarAbo As ClsCustomersInfo.clsCustomerABO
            'mvarAbo = New ClsCustomersInfo.clsCustomerABO(SessionInfo, objDS, customers_id)

            Dim sql As String
            Dim dt As DataTable
            sql = PlushData.ClsCustomersData.getSelectAboHistory(customers_id)
            dt = PlushData.clsConnection.FillDataSet(sql)

            GridABO.DataSource = dt
            refreshTab(index) = False
        End If
    End Sub

    Private Sub loadAttributesCustomer(ByVal customers_id As Integer)
        Dim sql As String
        sql = PlushData.ClsCustomersData.getSelectAttributes(customers_id)
        PlushData.clsConnection.FillDataSet(objDS.Tables("customer_attributes"), sql)

    End Sub
    'Private Sub loadCustomerSVOD(ByVal customers_id As Integer)
    '    Dim sql As String
    '    sql = PlushData.ClsCustomersData.getSelectSVOD(customers_id)
    '    PlushData.clsConnection.FillDataSet(objDS.Tables("customers_svod"), sql)

    'End Sub
    Private Sub loadDiscountActivation(ByVal drCust As DataRow)

        Dim dt As DataTable
        If drCust("activation_discount_code_type") Is DBNull.Value OrElse drCust("activation_discount_code_type") = String.Empty Then
            cmbDiscountActivation.Properties.DataSource = Nothing
            cmbDiscType.SelectedIndex = 2
        ElseIf drCust("activation_discount_code_type") = "A" Then

            Dim sql As String

            sql = PlushData.ClsCustomersData.GetSelectActivationCode(drCust("activation_discount_code_id"))
            dt = PlushData.clsConnection.FillDataSet(sql)

            PlushBuziness.ClsCombo.addRowEmpty(dt)
            cmbDiscountActivation.Properties.DataSource = dt
            cmbDiscType.SelectedIndex = 0
            cmbDiscountActivation.Refresh()
        Else
            Dim dr As dsCustomerMaint.discount_codeRow
            If objDS.discount_code.Select("discount_code_id = 0").Length = 0 Then
                dr = objDS.discount_code.Newdiscount_codeRow()
                dr.discount_code_id = 0
                dr.discount_code = ""

                objDS.discount_code.Rows.Add(dr)
            End If
            dt = objDS.discount_code.Copy()


            cmbDiscountActivation.Properties.DataSource = dt
            cmbDiscType.SelectedIndex = 1
            cmbDiscountActivation.Refresh()

            'txtTVODFreeCredits.EditValue = drCust("tvod_free")

        End If
    End Sub
    Public Sub LoadCustomerInfo()
        _loadInfo = True

        objDS.Tables("address_book_all").Clear()
        'objDS.Tables("customer_attributes").Clear()
        objDS.Tables("customers_svod").Clear()
        objDS.Tables("customers").Clear()



        MainData = New ClsCustomersInfo.clsCustomer(SessionInfo, objDS, _CurrentCustomerID)
        Dim lst_dr() As DataRow = objDS.Tables("User_dvdPost").Select("customers_id = " & _CurrentCustomerID)
        PlushData.clsSession.isDVDPostUser = lst_dr.Length > 0


        Dim _ds As New DataSet()
        If objDS.Tables("customers").Rows.Count = 0 Then
            MsgBox("Ce client n'existe pas", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim drCust As DataRow = objDS.Tables("customers").Rows(0) 'D:\DVDPost\Plush\DVDPostLib\CUSTOMERS\frmPlainte.vb
        'do visible txt summer power abo 12 mois
        Me.displayLblSummer(_CurrentCustomerID)
        'Dim credit As Integer
        'Dim dvdremainNext As Integer
        Dim price As String = ""
        Dim clscustomers As New PlushBuziness.ClsCustomers
        'clscustomers.aboStopDebug()
        clscustomers.GetInfoNextReconduction(_CurrentCustomerID, price)
        'txtNextCredit.EditValue = credit
        'txtNextDVDRemain.EditValue = dvdremainNext
        txtNextPrice.EditValue = price
        'visble group control phone activation
        'VisiblePhoneActivation(_CurrentCustomerID)
        ' loadVodAccess(_CurrentCustomerID)
        If txtABO.Checked Then
            txtABO.BackColor = Drawing.Color.GreenYellow
        Else
            txtABO.BackColor = Drawing.Color.Red
        End If
        cmbSuspended.EditValue = drCust("customers_abo_suspended")
        'cmbADULTSVODStatus.EditValue = drCust("svod_adult")

        'calcul the Age
        If drCust("customers_dob") IsNot (DBNull.Value) Then
            txtYearsOld.Text = calculAge(DateBirthday.EditValue)
        End If

        'to suspend holiday
        DateEndOfHoliday.EditValue = PlushData.clsConnection.ExecuteScalar(PlushData.clsAboSuspended.GetDateEndHoliday(_CurrentCustomerID))
        _old_date_Holiday = DateEndOfHoliday.EditValue
        'Dim dt As DataTable
        'dt = clscustomers.GetInfoAttributesCustomer(_CurrentCustomerID)
        'If dt.Rows.Count > 0 Then
        '    ChkCreditCombined.Checked = dt.Rows(0)("combined")
        'Else
        '    MsgBox("Error Field Combined", MsgBoxStyle.Critical)
        'End If
        ' change backcolor for chkAutoStop
        CheckboxColor()
        loadDiscountActivation(drCust)
        'display addressbook
        loadAddressBook(_CurrentCustomerID)
        'loadAttributesCustomer(_CurrentCustomerID)
        'loadCustomerSVOD(_CurrentCustomerID)
        loadCptReconduction(_CurrentCustomerID)
        'chkFt.Checked = PlushBuziness.ClsCustomers.isFT(_CurrentCustomerID)
        HideTab()
        UcMessagerieCustomer.Customers_id = _CurrentCustomerID
        UcMessagerieCustomer.language_id = lang_id

        _loadInfo = False
        EnablingEditFields(False)
    End Sub
    Private Function isrightAccess() As Boolean
        Return (Not PlushData.clsSession.isDVDPostUser Or PlushData.clsSession.isEnvTest)
    End Function

    Private Function isTVODABO() As Boolean
        Return cmbABO.EditValue = PlushData.ClsCustomersData.TVOD_ANYONE_ABO
    End Function

    Private Function isLockedForReconduction() As Boolean
        Return chkCustomerLockedForReconduction.Checked
    End Function
    Private Sub ChangeStatecheckBox(ByVal c As DevExpress.XtraEditors.CheckEdit, ByVal enabling As Boolean)
        c.Enabled = True
        c.Properties.ReadOnly = Not enabling
    End Sub
    Private Sub ChangeStateControl(ByVal c As Control, ByVal enabling As Boolean)

        c.Enabled = enabling
        If enabling = False Then
            c.ForeColor = Drawing.Color.Black
        End If

    End Sub
    Private Sub EnablingEditFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingEditFields


        ChangeStateControl(txtLastName, Enabling)
        ChangeStateControl(txtFirstName, Enabling)
        ChangeStateControl(txtEMail, Enabling)
        ChangeStateControl(txtTel, Enabling)
        'ChangeStateControl(txtTelEvening, Enabling)


        ChangeStateControl(txtDeliveryFirstName, Enabling)
        ChangeStateControl(txtDeliveryLastName, Enabling)
        ChangeStateControl(txtDeliveryAddr, Enabling)
        ChangeStateControl(txtDeliveryCity, Enabling)
        ChangeStateControl(txtDeliveryPostCode, Enabling)
        ChangeStateControl(cmbDeliverycountry, Enabling)


        ChangeStateControl(cmbDiscountActivation, Enabling And isrightAccess())
        ChangeStateControl(cmbDiscType, Enabling And isrightAccess())
        ChangeStateControl(txtTVODFreeCredits, Enabling And isrightAccess())
        ChangeStateControl(txtABO, Enabling And isrightAccess())
        ChangeStateControl(cmbSuspended, Enabling And isrightAccess())
        ChangeStateControl(cmbABO, Enabling And isrightAccess() And Not isTVODABO())
        ChangeStateControl(cmbNextABO, Enabling And isrightAccess()) ' And Not isLockedForReconduction())
        'ChangeStateControl(txtABOCredit, Enabling And isrightAccess() And Not PlushBuziness.ClsInventory.isAboprocessRun())
        'ChangeStateControl(txtRemainDVD, Enabling And isrightAccess() And PlushBuziness.ClsInventory.isNPP(txtCustomers_id.Text) And Not PlushBuziness.ClsInventory.isAboprocessRun())
        ChangeStateControl(cmbNextDiscCode, Enabling And isrightAccess())
        ChangeStateControl(txtAbo_ValidityTo, Enabling And isrightAccess())
        'ChangeStateControl(cmbPPVStatus, Enabling)


        'ChangeStateControl(txtComment, Enabling)
        'ChangeStateControl(cmbSuspended, Enabling)
        'ChangeStateControl(cmbADULTSVODStatus, Enabling)
        'ChangeStatecheckBox(chkMultiShipment, Enabling)
        ChangeStatecheckBox(chkAutoStop, Enabling)
        'ChangeStatecheckBox(chksleep, Enabling)


        'ChangeStateControl(txtWishListKind, Enabling)
        ChangeStateControl(cmbLanguage, Enabling)
        ChangeStatecheckBox(chkNewsLetter, Enabling)
        ChangeStatecheckBox(chkNewsLetterPartner, Enabling)
        'ChangeStatecheckBox(chkBlackListed, Enabling)
        'ChangeStatecheckBox(chkRedListed, Enabling)
        ChangeStateControl(btnGoto30, Enabling)


        ChangeStateControl(cmbPayMethod, Enabling)

        'ChangeStateControl(cmbDomStatus, Enabling)
        'ChangeStateControl(txtDomAcctNumber, Enabling)
        'ChangeStateControl(txtDomDebiterName, Enabling)
        'ChangeStateControl(txtDomNumber, Enabling)

        ChangeStateControl(txt_cc_card_no2, Enabling)
        ChangeStateControl(txt_cc_card_type2, Enabling)
        ChangeStateControl(txt_cc_expiration_date2, Enabling)
        ChangeStateControl(txt_cc_owner2, Enabling)
        ChangeStateControl(cmb_cc_expiration_status2, Enabling)


        'ChangeStateControl(txtPtSponsorShip, Enabling)

        ChangeStateControl(DateEndOfHoliday, Enabling)


        ' Right buttons disabeld in Edit mode
        ChangeStateControl(btnActPhone, Not Enabling)
        ChangeStateControl(btnStopNow, Not Enabling)
        ChangeStateControl(btnDelPhoAct, Not Enabling)
        ChangeStateControl(btnForcedReconduction, Not Enabling)
        ChangeStateControl(btnStopAtReconduction, Not Enabling)
        ChangeStateControl(btnReActivate, Not Enabling)

        'phone activation

        ChangeStateControl(DateCallPhoneActivation, Enabling)
        ChangeStateControl(cmbPhoneActivDelete, Enabling)
        ChangeStateControl(MemoOtherReason, Enabling)

        ChangeStateControl(txtCustServ_Subject, Enabling)
        ChangeStateControl(txtCustServ_Response_Message, Enabling)

        'ChangeStatecheckBox(chkOnly_VOD, Enabling)
        'ChangeStatecheckBox(chkCreditReceivedBySite, False)


        ChangeStateControl(txtCustomers_id, False)
        ChangeStateControl(txtDateCreated, False)
        'ChangeStateControl(cmbEntity, False)
        ChangeStateControl(DateBirthday, False)
        ChangeStateControl(txtYearsOld, False)
        ChangeStateControl(txtGender, False)
        ChangeStateControl(txtLast_logon, False)
        ChangeStateControl(txtNbrOfLogons, False)
        'ChangeStateControl(txtDVDNorm, False)
        'ChangeStateControl(txtDVDNormAtHome, False)
        'ChangeStateControl(txtDVDAdult, False)
        'ChangeStateControl(txtDVDAdultAtHome, False)
        ChangeStateControl(txtRegistrationStep, False)
        'ChangeStateControl(txtNextCredit, False)
        'ChangeStateControl(txtNextDVDRemain, False)
        ChangeStateControl(txtNextPrice, False)
        ChangeStateControl(txtDiscRecurring, False)

        _saveCustomersComment = Enabling


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
            XTabCustomers.SelectedTabPage = tabMain

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

    'Private Sub assignDVD()
    '    Dim productId As Integer
    '    Dim DVDId As Integer
    '    Dim WLId As Integer
    '    Dim _DS As New dsProducts
    '    Dim _objProductsDVD As clsProduct_DVD
    '    Dim sql As String
    '    Dim isIllimitedAbo As Boolean

    '    If DVDPostBuziness.ClsInventory.isAboprocessRun() Then
    '        MsgBox("Wait please but aboprocess run", MsgBoxStyle.Critical)
    '        Return
    '    End If
    '    If Not isrightAccess() Then
    '        MsgBox("Function Disabled !!!", MsgBoxStyle.Critical)
    '    Else

    '        isIllimitedAbo = DVDPostBuziness.ClsCustomers.isIllimitedaboByCustomers(_CurrentCustomerID)
    '        'Me.Enabled = False
    '        If txtABOCredit.EditValue > 0 Or isIllimitedAbo Then

    '            productId = GridViewWishList.GetDataRow(GridViewWishList.FocusedRowHandle)("product_id")
    '            WLId = GridViewWishList.GetDataRow(GridViewWishList.FocusedRowHandle)("wl_id")

    '            sql = DvdPostData.clsProductDvd.GetSelectProductsDvdToManualAssign(productId)
    '            DVDId = DvdPostData.clsConnection.ExecuteScalar(sql)

    '            If DVDId > 0 Then

    '                _objProductsDVD = New clsProduct_DVD(SessionInfo, _DS, productId, DVDId)

    '                _objProductsDVD.AssignDVD( isIllimitedAbo, False, WLId, _CurrentCustomerID, DvdPostData.clsCreditHistory.ActionId.MANUAL_ASSIGN, DvdPostData.ClsCustomersData.OrdersType.MANUAL)

    '                MsgBox("This button will send the DVD : " & productId.ToString & " - " & DVDId, MsgBoxStyle.Information)
    '                refreshTab(XTabCustomers.SelectedTabPageIndex) = True
    '                loadwishlist(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID, lang_id)
    '                txtABOCredit.EditValue -= 1
    '            Else
    '                MsgBox("Cannot send DVD : " & productId.ToString & " (No Available DVD) ", MsgBoxStyle.Information)
    '            End If
    '        Else
    '            MsgBox("No enough credit !!", MsgBoxStyle.Critical)
    '        End If
    '    End If
    'End Sub
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
        Dim _SQLTxt As String = "update customers set customers_abo_auto_stop_next_reconduction = 1, customers_abo_discount_recurring_to_date = null where customers_id = " & txtCustomers_id.EditValue
        _Return = PlushData.clsConnection.ExecuteNonQuery(_SQLTxt)
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
        If MsgBox(" Confirmez votre demande de stop !", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            MsgBox("Demande Annulée ")
        Else
            Dim reasonStop As New frmChooseStop(SessionInfo)
            reasonStop.drCustomer = objDS.Tables("customers").Rows(0)
            reasonStop.customers_id = txtCustomers_id.EditValue
            reasonStop.typeAbo = cmbABO.EditValue
            reasonStop.ShowDialog()
            refreshClient()
        End If


        ' End If

    End Sub
    Private Sub btnReActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReActivate.Click

        Dim sql As String
        Dim cpt As Integer

        'If (txtDVDNormAtHome.EditValue > 0 Or txtDVDAdultAtHome.EditValue > 0) Then
        '    MsgBox("It's not possible to activate this customer but he has " & txtDVDNormAtHome.EditValue & " DVD Norm " & vbNewLine & _
        '    txtDVDAdultAtHome.EditValue & " DVD Adult (Check the orders History)", MsgBoxStyle.Critical)
        'Else

        sql = PlushData.ClsCustomersData.GetUpdateActivation(_CurrentCustomerID)
        cpt = PlushData.clsConnection.ExecuteNonQuery(sql)
        If cpt = 1 Then
            refreshClient()
        Else
            MsgBox("Activation Error", MsgBoxStyle.Critical)
        End If
        'End If



    End Sub
    Private Sub btnGoto30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoto30.Click
        txtRegistrationStep.EditValue = 30
    End Sub



    'Private Sub chkViewNegativeBoxes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    _refreshData_wishlist = True
    '    loadwishlist(_CurrentCustomerID, lang_id)
    'End Sub

    Private Sub GridOrders_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub loadCallHistory(ByVal index As Integer, ByVal customers_id As Integer)

        If refreshTab(index) Then
            UcCallsHistory1.loadHistory(customers_id)
            refreshTab(index) = False
        End If

    End Sub
    'Public Sub loadDroselia(ByVal index As Integer, ByVal customers_id As Integer)
    '    If refreshTab(index) Then
    '        Dim dt As DataTable
    '        Dim sql As String

    '        sql = PlushData.ClsDroselia.GetDroselia(customers_id)
    '        dt = PlushData.clsConnection.FillDataSet(sql)
    '        Me.GridDroselia.DataSource = dt

    '        refreshTab(index) = False

    '    End If
    'End Sub


    'Private Sub butGenCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
    '    If txtDroselia.EditValue > 0 Then
    '        Dim nbr As Integer
    '        Dim cls As New PlushBuziness.ClsCustomers
    '        Dim str As String
    '        Dim input As String

    '        nbr = txtDroselia.EditValue
    '        str = cls.GenerateDroseliaCode(nbr, _CurrentCustomerID)

    '        refreshClient()
    '        loadDroselia(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID)

    '        input = InputBox("", "droselia code", str)
    '    End If

    'End Sub



    Private Sub btnActPhone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActPhone.Click
        Dim typepayment As Integer

        If Me.txtABO.Checked = True Then
            MsgBox("member already activate")
            Exit Sub
        End If
        typepayment = objDS.Tables("customers").Rows(0)("customers_abo_payment_method")
        If typepayment <> PlushData.ClsCustomersData.Payment_Method.VIREMENT Then
            MsgBox("this is not an activation phone member, you cannot activate this abo ", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim cls As PlushBuziness.ClsCustomers = New PlushBuziness.ClsCustomers()

        Dim ok As Boolean
        ok = cls.Initialisation(_CurrentCustomerID, False)

        If ok Then
            ok = cls.ReconductionVirement(PlushData.ClsCustomersData.Country.BELGIUM, _CurrentCustomerID, False)
            'cls.UpdateParrainageSummer(_CurrentCustomerID)
            ' cls.UpdateParrainage(_CurrentCustomerID, txtcustomers_email_address_search.Text.Trim, cmbABO.EditValue)

            If ok Then
                MsgBox("Reconduction OK")
                ' Dim sql As String
                'sql = DvdPostData.ClsCustomersData.GetInsertVodAccess(_CurrentCustomerID)
                'DvdPostData.clsConnection.ExecuteNonQuery(sql)
                refreshClient()
            Else
                ' il faudrait annuler toutes les actions 
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
            call_phone = DateCallPhoneActivation.DateTime.ToString("yyyy-MM-dd HH:mm:ss")
        Else
            call_phone = String.Empty
        End If

        If cmbPhoneActivDelete.EditValue IsNot Nothing Then
            stop_phone_id = cmbPhoneActivDelete.EditValue.ToString
        Else
            stop_phone_id = String.Empty
        End If

        If customers_abo = PlushData.ClsCustomersData.abo.UNVALID And registration_step = 100 And payment_method = PlushData.ClsCustomersData.Payment_Method.VIREMENT Then
            existCust = exist(customers_id)
            Try

                PlushData.clsConnection.CreateTransaction(True)

                If existCust Then
                    sql = PlushData.clsPhoneActivation.UpdatePhoneActivation(customers_id, stop_phone_id, other_reason, call_phone, date_delete)
                Else
                    sql = PlushData.clsPhoneActivation.insertPhoneActivation(customers_id, stop_phone_id, other_reason, call_phone, date_delete)
                End If

                count = PlushData.clsConnection.ExecuteNonQuery(sql)

                If date_delete Then
                    sql = PlushData.clsPhoneActivation.updateCustomerStep(customers_id)
                    count = PlushData.clsConnection.ExecuteNonQuery(sql)
                End If

                PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Phone_History, count)

            Catch ex As Exception
                PlushData.clsConnection.CancelBulkQuery()
                PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Phone_History, ex, customers_id)
            End Try
        End If


    End Sub

    'Private Sub VisiblePhoneActivation(ByVal customers_id As Integer)
    '    Dim dt As DataTable
    '    Dim sql As String
    '    'render visible groupcontrol
    '    If Me.txtRegistrationStep.Text = "100" And objDS.Tables("customers").Rows(0)("customers_abo") = 0 Then
    '        Me.GCACtPhone.Visible = True
    '        sql = PlushData.clsPhoneActivation.GetHistoriquePhoneActivation(customers_id)

    '        dt = PlushData.clsConnection.FillDataSet(sql)

    '        ' Dim existCust As Boolean = exist(customers_id, "historique_phone_activation")
    '        If dt.Rows.Count > 0 Then 'existCust = True Then
    '            Me.DateCallPhoneActivation.EditValue = dt.Rows(0)("call_phone")
    '            Me.MemoOtherReason.EditValue = dt.Rows(0)("other_reason")
    '            Me.cmbPhoneActivDelete.EditValue = dt.Rows(0)("stop_phone_id")

    '        Else
    '            'put blank 
    '            Me.DateCallPhoneActivation.EditValue = ""
    '            Me.MemoOtherReason.EditValue = ""
    '            Me.cmbPhoneActivDelete.EditValue = ""
    '        End If
    '    Else
    '        Me.GCACtPhone.Visible = False
    '    End If
    'End Sub

    ''put the list of stop_phone_acti_reason in the dropdowlist (lookupedit1)
    Public Sub reasonStopActPhone()
        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.clsPhoneActivation.GetStopPhoneActiReason()
        dt = PlushData.clsConnection.FillDataSet(sql)
        Me.cmbPhoneActivDelete.Properties.DataSource = dt

    End Sub

    Private Sub SendMail()
        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.ClsCustomersData.getSelectCustStopKeepdvdBacklog()
        dt = PlushData.clsConnection.FillDataSet(sql)


        'For Each dr As DataRow In dt.Rows
        '    PlushBuziness.clsMail.SendMail(dr, PlushBuziness.clsMail.Mail.MAIL_DVDABOSTOPBACKLOG)
        'Next

    End Sub
    Public Function exist(ByVal customers_id As Integer) As Boolean
        Dim sql As String
        sql = PlushData.clsPhoneActivation.GetExist(customers_id)
        Return PlushData.clsConnection.ExecuteScalar(sql)
    End Function

    Public Sub displayLblSummer(ByVal customers_id As Integer)
        Dim sqlSumWint As String = PlushData.ClsCustomersData.GetSelectAboSummerWinterPOwer(customers_id)
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
        Dim cls As PlushBuziness.ClsCustomers = New PlushBuziness.ClsCustomers()

        ok = cls.ReconductionForced(customers_id)
        ' warning check the batch_id in table payment and find replace in batch text 
        ' cls.ReplayReconduction_customers("2011-07-17", DvdPostData.ClsCustomersData.Country.BELGIQUE)
        'cls.ReplayReconductionNoInvoice_customers("2011-07-18", DvdPostData.ClsCustomersData.Country.BELGIQUE)
        If ok Then
            MsgBox("Reconduction OK")
            refreshClient()
        Else
            MsgBox("Error Reconduction", MsgBoxStyle.Critical)
        End If

    End Sub

    'Private Sub btnActivateDomiciliation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivateDomiciliation.Click
    '    If Me.txtABO.Checked = True Then
    '        MsgBox("member already activate")



    '    ElseIf objDS.Tables("customers").Rows(0)("customers_abo_payment_method") <> DvdPostData.ClsCustomersData.Payment_Method.DOMICILIATION Then
    '        MsgBox("No domiciliation customer", MsgBoxStyle.Critical)

    '    Else

    '        Dim cls As DVDPostBuziness.ClsCustomers = New DVDPostBuziness.ClsCustomers()
    '        Dim numDom As String
    '        ' Dim numaccount As String

    '        numDom = InputBox("Enter number of domiciliation please ")
    '        'numaccount = InputBox("Enter bank account number(IBAN) please ")

    '        If (numDom <> String.Empty AndAlso numDom.Length = 12) Then
    '            cls.updateNumDom(_CurrentCustomerID, numDom)
    '            Dim ok As Boolean
    '            ok = cls.Initialisation(_CurrentCustomerID, True)

    '            If ok Then
    '                MsgBox("Domiciliation customer activated")
    '                ok = cls.ReconductionDomiciliation(DvdPostData.ClsCustomersData.Country.BELGIQUE, _CurrentCustomerID, False)
    '                If ok Then
    '                    DVDPostBuziness.clsMail.SendMail(_CurrentCustomerID, DVDPostBuziness.clsMail.Mail.MAIL_ACTIVATIONDOM)
    '                    MsgBox("Reconduction OK")
    '                    refreshClient()
    '                Else
    '                    MsgBox("Error Reconduction", MsgBoxStyle.Critical)
    '                End If
    '            Else
    '                MsgBox("Error activate domiciliation", MsgBoxStyle.Critical)
    '            End If
    '        Else
    '            MsgBox("data invalidated (length num domiciliation : 12)", MsgBoxStyle.Critical)
    '        End If

    '    End If
    'End Sub

    'Private Sub btnReceivedDomiciliation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceivedDomiciliation.Click
    '    Dim sql As String

    '    sql = DvdPostData.ClsBatchDomiciliation.UpdateActivation _
    '                   (_CurrentCustomerID, _
    '                    DvdPostData.ClsCustomersData.Payment_Method.DOMICILIATION, _
    '                   DvdPostData.ClsCustomersData.Country.BELGIQUE, _
    '                   DvdPostData.ClsCustomersData.StepRegistrationStatus.CREATE_DOMICILIATION, _
    '                    DvdPostData.ClsCustomersData.DomiciliationStatus.RETRIEVELETTER, _
    '                   DvdPostData.ClsCustomersData.StepRegistrationStatus.RECEIVED_DOMICILIATION)

    '    Dim cpt As Integer
    '    cpt = DvdPostData.clsConnection.ExecuteNonQuery(sql)

    '    If cpt = 1 Then
    '        MsgBox("Received Domiciliation OK")
    '        DVDPostBuziness.clsMail.SendMail(_CurrentCustomerID, DVDPostBuziness.clsMail.Mail.MAIL_RECEIVEDDOM)
    '        refreshClient()
    '    Else
    '        MsgBox("Error Received Domiciliation", MsgBoxStyle.Critical)
    '    End If
    'End Sub



    'Private Sub GridViewWishList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSendIt.Click 'Handles btnSendIt.Click
    '    If GridViewWishList.RowCount <> 0 Then
    '        assignDVD()
    '        refreshClient()
    '        ' loadwishlist(_CurrentCustomerID, lang_id)
    '    End If
    'End Sub

    Private Sub btnForcedReconduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForcedReconduction.Click
        reconductionForced(_CurrentCustomerID)
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XTabCustomers.SelectedPageChanged
        Dim index As Integer = XTabCustomers.SelectedTabPageIndex
        If XTabCustomers.SelectedTabPage Is tabPaymentMovements Then
            loadBankAccountMovement(index, _CurrentCustomerID)
            'ElseIf XTabCustomers.SelectedTabPage Is tabWishList Then
            '    loadwishlist(index, _CurrentCustomerID, lang_id)
            'ElseIf XTabCustomers.SelectedTabPage Is tabOrdersHistor Then
            '    loadOrders(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabAboHistory Then
            loadAboHist(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabPayment Then
            loadPayment(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabMailHistory Then
            loadEmailHistory(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabPurchase Then
            loadShoppingOrders(index, _CurrentCustomerID)
            'ElseIf XTabCustomers.SelectedTabPage Is tabCreditHist Then
            '    loadCreditHist(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabCustServ Then
            loadCustServ(index, _CurrentCustomerID)
            'ElseIf XTabCustomers.SelectedTabPage Is tabAboProcessOld Then
            '    loadAboprocessOldStats(index, _CurrentCustomerID)
            'ElseIf XTabCustomers.SelectedTabPage Is tabAboprocess Then
            '    loadAboprocessStats(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabSponsorShip Then
            loadSponsor(index, _CurrentCustomerID) ' DvdPostData.clsMemberGetMember.SponsorshipType.SPONSOR) ', DvdPostData.clsMemberGetMember.SponsorshipType.SPONSOR)
        ElseIf XTabCustomers.SelectedTabPage Is tabCompensation Then
            loadCompensation(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabComment Then
            loadCustComment(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabProductsRating Then
            loadProductsRating(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabSuspendedHistory Then
            loadSupendedHistory(index, _CurrentCustomerID)
            'ElseIf XTabCustomers.SelectedTabPage Is tabDroselia Then
            '    loadDroselia(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabVodView Then
            loadVod(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabCalls Then
            loadCallHistory(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabMessagerie Then
            loadMessagerie(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabCritiques Then
            loadCritique(index, _CurrentCustomerID)
        End If

    End Sub

    Private Sub btnLoadPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadPayment.Click
        refreshTab(XTabCustomers.SelectedTabPageIndex) = True
        loadPayment(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID)
    End Sub
    Private Function ClosePayment(ByVal status As PlushData.PaymentOfflineData.StepPayment) As Boolean
        Dim id As Integer
        Dim strtype_payment As String

        Dim dr As DataRow
        Dim sql As String
        Dim last_status As PlushData.PaymentOfflineData.StepPayment


        dr = GridViewPayment.GetDataRow(GridViewPayment.FocusedRowHandle)
        id = dr("id")
        strtype_payment = dr("type_payment")
        last_status = dr("payment_status_id")

        If MsgBox("Are you sur to close (" & PlushTools.clsEnum.getNameStrEnum(status) & ") this payment ID = " & id, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            sql = PlushData.ClsPayment.GetUpdateClosePayment(id, status, last_status)
            PlushData.clsConnection.ExecuteNonQuery(sql)

            refreshTab(XTabCustomers.SelectedTabPageIndex) = True
            loadPayment(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID)
            Return True
        Else
            Return False
        End If


    End Function
    Private Sub btnCancelPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelPayment.Click

        If GridViewPayment.GetSelectedRows().Length = 0 Then
            MsgBox("Please select one payment before Cancel")
        End If

        If ClosePayment(PlushData.PaymentOfflineData.StepPayment.CANCEL) Then
            MsgBox("Cancel OK")
        Else
            MsgBox("Cancel Error")
        End If
    End Sub
    Private Sub BtnPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPaid.Click


        If GridViewPayment.GetSelectedRows().Length = 0 Then
            MsgBox("Please select one payment before paid")
        End If

        If ClosePayment(PlushData.PaymentOfflineData.StepPayment.PAID) Then
            MsgBox("Pay OK")
        Else
            MsgBox("Pay Error")
        End If

    End Sub

    ''' <summary>
    ''' insert in credit_history ' by gauthier
    ''' </summary>
    Private Sub addCreditToCustomers(ByVal quantity As Integer, ByVal customers_id As Integer, ByVal creditAction As PlushData.clsCreditHistory.ActionId, ByVal oldCredit As Integer)

        Dim sqlAddCredit As String = PlushData.clsCreditHistory.GetInsertCreditHistory(quantity, _CurrentCustomerID, creditAction, False, Nothing, oldCredit)
        PlushData.clsConnection.ExecuteNonQuery(sqlAddCredit)

    End Sub

    Private Function calculCredit(ByVal oldCredit As Integer, ByVal newCredit As Integer) As Integer
        Dim result As Integer
        result = newCredit - oldCredit
        Return result
    End Function

    Private Sub lblLogas_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Diagnostics.Process.Start("http://www.dvdpost.be/logas.php?customers_id=" & _CurrentCustomerID & "")
    End Sub

    Private Sub lblSetPassWord_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSetPassWord.Click

        If MsgBox("change password", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok And _CurrentCustomerID > 0 Then
            Dim sql As String
            Dim code As String
            Dim count As Integer
            Try
                'Dim v As Boolean = BCrypt.CheckPassword("D137C2", "$2a$10$oegZ.Qy4497TF8lN3/VFg.9oaXU2zVV3St4wrT6q4IDvRv//wgk5O")
                code = GenerateCode()
                'sql = PlushData.ClsCustomersData.GetUpdatePassWord(_CurrentCustomerID, PlushBuziness.ClsCustomers.MD5Encrypt(code))
                sql = PlushData.ClsCustomersData.GetUpdatePassWord(_CurrentCustomerID, HashPassword(code, GenerateSalt(10)))

                PlushData.clsConnection.CreateTransaction(False)
                count = PlushData.clsConnection.ExecuteNonQuery(sql)
                If count = 1 Then
                    PlushData.clsConnection.CommitTransaction(True)
                    code = InputBox("New Password", "", code)
                Else
                    PlushData.clsConnection.CommitTransaction(False)
                    MsgBox(" Not new password ")
                End If
            Catch ex As Exception
                PlushData.clsConnection.CommitTransaction(False)
                PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.SignaletiqueCustomer, ex)
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


    Private Function calculAge(ByVal birthday As DateTime) As Integer
        Dim result As Integer
        result = DateDiff(DateInterval.Year, birthday, Date.Now)
        Return result
    End Function
    ' Code permettant d'envoyer une copie d'un mail d'un client
    'Private Sub sendMail(ByVal strmessage As String, ByVal strSubject As String)
    '    Dim mymail As Net.Mail.MailMessage
    '    mymail = New Net.Mail.MailMessage("dvb@dvdpost.be", "ms@dvdpost.be")
    '    mymail.From = New Net.Mail.MailAddress("dvb@dvdpost.be", "IT")
    '    mymail.Subject = strSubject
    '    mymail.IsBodyHtml = True
    '    mymail.Body = strmessage

    '    DVDPostBuziness.clsMail.SendMail(mymail)


    'End Sub
    Private Sub loadEmailHistory(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then
            Dim dt As DataTable
            Dim sql As String = PlushData.clsMassEmail.GetemailHistory(customers_id)
            dt = PlushData.clsConnection.FillDataSet(sql)
            Dim msg As String
            '  Dim bulk As String = ""
            For Each dr As DataRow In dt.Rows
                msg = dr("messages_html")
                If dr("lstvariable") IsNot DBNull.Value Then
                    dr("messages_html") = PlushBuziness.clsMail.replacevariableInMsg(msg, dr("lstvariable"))
                End If
                ' sendMail(dr("messages_html"), dr("messages_subject"))
                ' bulk = bulk + dr("messages_html")
            Next

            grpContEmail.DataSource = dt

            If dt.Rows.Count > 0 Then
                GridViewMail.SelectRow(0)
                displayDetailsMail()
            End If

            refreshTab(index) = False
        End If

    End Sub
    Private Sub displayDetailsMail()
        browser.DocumentText = GridViewMail.GetDataRow(GridViewMail.FocusedRowHandle)("messages_html").ToString()
    End Sub
    Private Sub GridViewMail_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewMail.FocusedRowChanged 'grpContEmail.DoubleClick
        displayDetailsMail()
    End Sub

    Private Sub loadShoppingOrders(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then
            Dim dt As DataTable
            Dim sqlShopping As String = PlushData.clsShopping.GetShoppingOrders(customers_id)
            dt = PlushData.clsConnection.FillDataSet(sqlShopping)
            GridShoppingOrders.DataSource = dt

            GridViewShoppingOrders.BestFitColumns()
            GridViewShoppingOrders.ExpandAllGroups()

            refreshTab(index) = False
        End If
    End Sub

    'Private Sub loadCreditHist(ByVal index As Integer, ByVal customers_id As Integer)
    '    If refreshTab(index) Then
    '        Dim dt As DataTable
    '        Dim sqlCreditHist As String = PlushData.clsCreditHistory.GetCreditHistoryByCust(customers_id)
    '        dt = PlushData.clsConnection.FillDataSet(sqlCreditHist)
    '        GridCreditHistory.DataSource = dt

    '        refreshTab(index) = False
    '    End If

    'End Sub

    Private Sub loadCustServ(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then
            Dim dt As DataTable
            Dim sqlCustServ As String = PlushData.ClsCustserv.GetCustservByCustomers(customers_id)
            dt = PlushData.clsConnection.FillDataSet(sqlCustServ)
            GridCustServ.DataSource = dt

            gridViewCustServ.BestFitColumns()
            gridViewCustServ.ExpandAllGroups()

            displayInfoCustserv(index)

            refreshTab(index) = False
        End If
    End Sub


    Private Sub displayInfoCustserv(ByVal index As Integer)
        If gridViewCustServ.RowCount <> 0 Then
            If (refreshTab(index) Or _saveCustomersComment) Then
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
            End If
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
        displayInfoCustserv(XTabCustomers.SelectedTabPageIndex)
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

            sqlUpdate = PlushData.ClsCustserv.upadeCustservByCustMaint(custservId, messageAdmin, subject, sendEmail)
            PlushData.clsConnection.ExecuteNonQuery(sqlUpdate)

            If sendEmail = True Then
                PlushBuziness.clsMail.SendMail(_CurrentCustomerID, PlushBuziness.clsMail.Mail.MAIL_CUST_SERV)
            End If

            refreshClient()
            loadCustServ(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID)

            searchCustserv()
            _saveCustomersComment = True
        Catch ex As Exception
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Email, ex)
        End Try
    End Sub

    Private Sub GridViewABO_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewABO.DoubleClick
        Dim param As PlushBuziness.clsSingleton
        param = PlushBuziness.clsSingleton.Instance()
        'param.Activayion_Dscount_id = CType(GridViewABO.GetDataRow(GridViewABO.FocusedRowHandle)("code_id"), Integer)

        Dim action_id As Integer = CType(GridViewABO.GetDataRow(GridViewABO.FocusedRowHandle)("action"), Integer)

        If action_id = PlushData.ClsCustomersData.TypeAction.ACTION_FROM_ACTIVATION Then
            param.Activation_Discount_id = CType(GridViewABO.GetDataRow(GridViewABO.FocusedRowHandle)("code_id"), Integer)
            Dim frmAct As New frmActivationCode(SessionInfo)
            frmAct.MdiParent = Me.ParentForm
            frmAct.Show()
            frmAct.search()
        End If

        If action_id = PlushData.ClsCustomersData.TypeAction.ACTION_FROM_DISCOUNT Then
            param.Activation_Discount_id = CType(GridViewABO.GetDataRow(GridViewABO.FocusedRowHandle)("code_id"), Integer)
            Dim frmDisc As New frmDiscountCode(SessionInfo)
            frmDisc.MdiParent = Me.ParentForm
            frmDisc.Show()
            frmDisc.search()
        End If
    End Sub
    Private Sub loadCptReconduction(ByVal customers_id As Integer)

        Dim sql As String
        Dim cpt As Integer
        sql = PlushData.ClsCustomersData.GetSelectCountReconduction(customers_id)
        cpt = PlushData.clsConnection.ExecuteScalar(sql)

        lblCpt_reconduction.Text = cpt
    End Sub
    'Private Sub loadAboprocessStats(ByVal index As Integer, ByVal customers_id As Integer)
    '    If refreshTab(index) Then
    '        Dim dt As New DataTable
    '        Dim sqlStats As String

    '        sqlStats = PlushData.AboProcessData.GetAboprocessStatsByCust(customers_id)
    '        dt = PlushData.clsConnection.FillDataSet(sqlStats)
    '        gridAboprocess.DataSource = dt
    '        refreshTab(index) = False
    '    End If

    'End Sub

    'Private Sub loadAboprocessOldStats(ByVal index As Integer, ByVal customers_id As Integer)
    '    If refreshTab(index) Then
    '        Dim dt As New DataTable
    '        Dim sqlStats As String

    '        sqlStats = PlushData.AboProcessData.GetAboprocessOldByCust(customers_id)
    '        dt = PlushData.clsConnection.FillDataSet(sqlStats)
    '        GridAboprocessOld.DataSource = dt
    '        refreshTab(index) = False
    '    End If

    'End Sub
    Private Sub loadSponsorCard(ByVal customers_id As Integer)
        Dim sql As String
        Dim dt As DataTable


        sql = PlushData.clsMemberGetMember.GetListCustToOrderCard(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sql)

        If dt.Rows.Count > 0 Then
            VisibleControl(dt.Rows(0)("cpt_card"))
        Else
            VisibleControl(0)
        End If
    End Sub
    Private Function getListCode(ByRef cpt_codeActivation As Integer) As String
        Dim result As String = String.Empty
        Dim ctrl_txt As Control
        cpt_codeActivation = 0
        For index As Integer = 1 To 5
            ctrl_txt = GCSponsonCard.Controls("txtCard" + index.ToString())
            If ctrl_txt.Visible = True Then
                If ctrl_txt.Text <> "" Then
                    result = result + ctrl_txt.Text + ";"
                End If
                cpt_codeActivation += 1
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

            label = GCSponsonCard.Controls("lblCard" + index.ToString())
            txt = GCSponsonCard.Controls("txtCard" + index.ToString())

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
    Private Sub loadSponsor(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then
            Dim sql As String
            Dim dtSponsor As DataTable
            Dim dtGodson As DataTable
            Dim dtCode As DataTable

            sql = PlushData.clsMemberGetMember.GetSponsorUsed(customers_id, PlushData.clsMemberGetMember.SponsorshipType.SPONSOR)
            dtSponsor = PlushData.clsConnection.FillDataSet(sql)
            GridSon.DataSource = dtSponsor

            sql = PlushData.clsMemberGetMember.GetSponsorUsed(customers_id, PlushData.clsMemberGetMember.SponsorshipType.GODSON)
            dtGodson = PlushData.clsConnection.FillDataSet(sql)
            GridGodFather.DataSource = dtGodson

            sql = PlushData.clsMemberGetMember.GetCodeLinkCustomers(customers_id)
            dtCode = PlushData.clsConnection.FillDataSet(sql)
            GridCodeLinked.DataSource = dtCode


            loadMgmGift(customers_id)
            loadCustomersPointHistory(customers_id)
            loadSponsorCard(customers_id)

            refreshTab(index) = False
        End If


    End Sub

    Public Sub loadMgmGift(ByVal customers_id As Integer)
        Dim dt As DataTable
        Dim sqlGift As String

        sqlGift = PlushData.clsMemberGetMember.GetMgmGift(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sqlGift)
        GridGift.DataSource = dt
    End Sub
    Public Sub loadCustomersPointHistory(ByVal customers_id As Integer)
        Dim dt As DataTable
        Dim sql As String

        sql = PlushData.clsMemberGetMember.GetCustomersPointsHistory(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sql)
        GridCustPointHistory.DataSource = dt
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

        frm.XTabCustomers.SelectedTabPage = frm.tabMain
        Return frm
        'frm.Show()
        'frm.Search()
        'frm.Text = "Customers Maint"
        ''frm.Text
    End Function

    Private Sub loadCompensation(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then

            Dim dt As DataTable
            Dim sqlCompensation As String

            sqlCompensation = PlushData.clsCompensation.GetCompensationByCust(customers_id)
            dt = PlushData.clsConnection.FillDataSet(sqlCompensation)

            GridCompensation.DataSource = dt

            refreshTab(index) = False
        End If

    End Sub

    Private Sub loadCustComment(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then

            Dim sql As String = PlushData.clsCustomersComment.GetCustomersComment(customers_id)
            Dim dt As DataTable
            MemoCustomersComment.Text = String.Empty
            dt = PlushData.clsConnection.FillDataSet(sql)
            GridCustComment.DataSource = dt

            refreshTab(index) = False
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
            Dim sqlInsertComment As String = PlushData.clsCustomersComment.GetInsertCustomersComment(_CurrentCustomerID, str)
            PlushData.clsConnection.ExecuteNonQuery(sqlInsertComment)

            refreshTab(XTabCustomers.SelectedTabPageIndex) = True
            loadCustComment(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID)
            MemoInsertComment.Text = String.Empty
        End If
    End Sub



    Private Sub btnViewCustserv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewCustserv.Click
        searchCustserv()
    End Sub

    Private Sub searchCustserv()
        Dim dt As DataTable
        Dim sql As String = PlushData.ClsCustserv.GetCustServCustomers()
        dt = PlushData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt
    End Sub

    Private Sub btnViewGift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewGift.Click
        Dim dt As DataTable
        Dim sql As String = PlushData.clsMemberGetMember.GetCustomersWithGift()
        dt = PlushData.clsConnection.FillDataSet(sql)
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
        Dim sql As String = PlushData.clsAddressBook.GetAddressByCustomer(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sql)
        GridAddress.DataSource = dt

        If GridViewAddress.RowCount = 0 Then
            GridAddress.Visible = False
        Else
            GridAddress.Visible = True
        End If
    End Sub

    Private Sub loadProductsRating(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then
            Dim dt As DataTable
            Dim sql As String = PlushData.clsProductsRating.GetProductsRatingByCust(customers_id)
            dt = PlushData.clsConnection.FillDataSet(sql)
            GridProductsRating.DataSource = dt
            GridViewProductsRating.ExpandAllGroups()
            refreshTab(index) = False
        End If
    End Sub

    Private Sub BtnSponsorCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSponsorCard.Click
        Dim dt As DataTable
        Dim sql As String = PlushData.clsMemberGetMember.GetListCustToOrderCard()
        dt = PlushData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt
    End Sub

    Private Sub BtnSaveSponsorCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveSponsorCard.Click
        Dim result As String
        Dim ok As Boolean
        Dim cpt_card As Integer
        result = getListCode(cpt_card)
        Dim lst As String() = result.Split(";")
        Dim AllCards As Boolean = (cpt_card = lst.Length)
        Dim item As String = ""
        For Each item In lst
            ok = PlushBuziness.ClsWebServices.CallUrllinkCard(_CurrentCustomerID, item)
            If ok = False Then
                Exit For
            Else
                cpt_card -= 1
            End If
        Next

        ' (cpt_card = lst.Length) = encoder toutes les cartes que le client a besoin 
        If ok And AllCards Then
            BtnSaveSponsorCard.Enabled = False
            Dim sql As String
            sql = PlushData.clsMemberGetMember.GetUpdateSendFlag(_CurrentCustomerID)
            PlushData.clsConnection.ExecuteNonQuery(sql)
            MsgBox("ok")

        Else
            Dim sql As String
            sql = PlushData.clsMemberGetMember.GetUpdateNbCard(_CurrentCustomerID, cpt_card)
            PlushData.clsConnection.ExecuteNonQuery(sql)
            If (Not ok) Then
                MsgBox("Error code : " & item)
            Else
                MsgBox("You must filled " & cpt_card & " codes")
            End If

            refreshTab(XTabCustomers.SelectedTabPageIndex) = True
            loadSponsor(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID)
        End If
    End Sub

    Private Sub loadRedBlackListed(ByVal redBlackList As PlushData.ClsCustomersData.RedBlackListed)
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.ClsCustomersData.GetRedBlacklistedCustomers(redBlackList)
        dt = PlushData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt
    End Sub

    Private Sub btnBlackListed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadRedBlackListed(PlushData.ClsCustomersData.RedBlackListed.BLACKLISTED)
    End Sub

    Private Sub btnRedlisted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadRedBlackListed(PlushData.ClsCustomersData.RedBlackListed.REDLISTED)
    End Sub

    Private Sub BtnEmailError_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmailError.Click
        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.clsOdersStatusHistory.GetListOrderHistory(True, True)
        dt = PlushData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt
    End Sub


    Private Sub loadSupendedHistory(ByVal index As Integer, ByVal customers_id As Integer)
        Dim sql As String
        Dim dt As DataTable

        If refreshTab(index) Then

            sql = PlushData.clsAboSuspended.GetSuspendedHistory(customers_id)
            dt = PlushData.clsConnection.FillDataSet(sql)
            GridSuspendedHistory.DataSource = dt

            refreshTab(index) = False
        End If
    End Sub

    Private Sub suspendedPayment(ByVal customers_id As Integer)

        If Not PlushBuziness.ClsCustomers.SuspendPaymentCustomer(customers_id).Equals(String.Empty) Then
            MsgBox("Error Suspension Payment", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub unsuspendedPayment(ByVal customers_id As Integer)
        Dim returnString = PlushBuziness.ClsCustomers.UnsuspendPaymentCustomer(customers_id, cmbABO.EditValue)
        If Not returnString.Equals(String.Empty) Then
            MsgBox(returnString, MsgBoxStyle.Critical, "Error UnSuspension Payment")
        End If

    End Sub

    Private Sub UnsuspendForHolidays(ByVal customers_id As Integer, ByVal date_end As Date, ByVal old_date_end As Date)

        If Not PlushBuziness.ClsCustomers.UnsuspendForHolidayCustomer(customers_id, cmbABO.EditValue, DateEndOfHoliday.EditValue).Equals(String.Empty) Then
            MsgBox("Error UnSuspension Holidays", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub suspendForHolidays(ByVal customers_id As Integer, ByVal date_end As Date, ByVal old_date_end As Date)
        If Not PlushBuziness.ClsCustomers.SuspendForHolidayCustomer(customers_id, cmbABO.EditValue, DateEndOfHoliday.EditValue, date_end).Equals(String.Empty) Then
            MsgBox("Error Suspension Payment", MsgBoxStyle.Critical)
        End If
        'If Not PlushBuziness.ClsWebServices.CallSuspended(customers_id, date_end, PlushBuziness.ClsWebServices.TypeSuspend.HOLIDAYS) Then
        '    MsgBox("Error Suspension Holidays", MsgBoxStyle.Critical)
        'End If

    End Sub

    Private Sub suspended()
        Dim newSuspended As Integer

        newSuspended = cmbSuspended.EditValue
        If _oldSuspended = newSuspended Then Return

        If Not IsNothing(DateEndOfHoliday.EditValue) And newSuspended = PlushData.ClsCustomersData.Suspended.HOLIDAY Then
            Dim new_date_end_holiday As Date = DateEndOfHoliday.EditValue
            suspendForHolidays(_CurrentCustomerID, new_date_end_holiday, _old_date_Holiday)
        ElseIf newSuspended = PlushData.ClsCustomersData.Suspended.RECONDUCTION Then
            suspendedPayment(_CurrentCustomerID)
        End If

        If _oldSuspended <> newSuspended And newSuspended = PlushData.ClsCustomersData.Suspended.OK Then
            If _oldSuspended = PlushData.ClsCustomersData.Suspended.RECONDUCTION Then
                unsuspendedPayment(_CurrentCustomerID)
            Else
                UnsuspendForHolidays(_CurrentCustomerID, DateTime.Now, _old_date_Holiday)
            End If
        End If

    End Sub
    Private Sub upgrade_downgrade()
        Dim newNextABOType As Integer
        Dim Sql As String
        Dim package_count As Integer
        Dim package_count_next As Integer

        newNextABOType = cmbNextABO.EditValue

        If _oldNextAboType = newNextABOType Then Return

        Sql = PlushData.ClsCustomersData.GetAboPackage_PackageCount(_oldAboType)
        package_count = PlushData.clsConnection.ExecuteScalar(Sql)

        Sql = PlushData.ClsCustomersData.GetAboPackage_PackageCount(newNextABOType)
        package_count_next = PlushData.clsConnection.ExecuteScalar(Sql)

        If package_count >= package_count_next Then
            Sql = PlushData.ClsCustomersData.GetInsertHistoryAbo(_CurrentCustomerID, Nothing, newNextABOType, PlushData.ClsCustomersData.Payment_Method.OGONE, PlushData.ClsCustomersData.TypeAction.ACTION_REQUEST_OF_ABO_DOWNGRADE)
            PlushData.clsConnection.ExecuteNonQuery(Sql)
            chkCustomerLockedForReconduction.Checked = True
        ElseIf package_count < package_count_next Then
            cmbABO.EditValue = newNextABOType
            Sql = PlushData.ClsCustomersData.GetInsertHistoryAbo(_CurrentCustomerID, Nothing, newNextABOType, PlushData.ClsCustomersData.Payment_Method.OGONE, PlushData.ClsCustomersData.TypeAction.ACTION_UPGRADE)
            PlushData.clsConnection.ExecuteNonQuery(Sql)
            chkCustomerLockedForReconduction.Checked = True
        End If

    End Sub
    Private Function getCheckItem(ByVal key As String, ByVal lst As DevExpress.XtraEditors.CheckedListBoxControl) As DevExpress.XtraEditors.Controls.CheckedListBoxItem
        Dim i As Integer
        i = 0
        While i < lst.Items.Count

            If lst.Items(i).Value = key.ToLower() Then
                Return lst.Items(i)
            End If
            i += 1
        End While

        Return Nothing
    End Function
    Private Sub HideAllTab()

        For Each tab As DevExpress.XtraTab.XtraTabPage In tabConfig.TabControl().TabPages
            tab.PageVisible = tab.Text = tabSearch.Text
            'ChkListConfig.Items(1).Value   
        Next

    End Sub


    Private Sub HideTab()
        Dim chkItem As DevExpress.XtraEditors.Controls.CheckedListBoxItem
        For Each tab As DevExpress.XtraTab.XtraTabPage In tabConfig.TabControl().TabPages
            chkItem = getCheckItem(tab.Text, ChkListConfig)
            If chkItem IsNot Nothing Then
                tab.PageVisible = chkItem.CheckState = CheckState.Checked
                'ChkListConfig.Items(1).Value   
            End If
        Next

        tabConfig.PageVisible = True
        tabMain.PageVisible = True

    End Sub

    '' to check the words Gauthier
    Private Function SpellChecker(ByVal str As String) As String
        Dim spellCheck As New SpellChecker
        spellCheck.Check(str)
        Return str
    End Function

    Private Sub btnRefreshTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshTab.Click
        HideTab()
    End Sub

    'Private Sub BtnVodAccess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVodAccess.Click
    '    Dim sql As String

    '    sql = DvdPostData.ClsCustomersData.GetInsertVodAccess(_CurrentCustomerID)
    '    DvdPostData.clsConnection.ExecuteNonQuery(sql)
    '    ' loadVodAccess(_CurrentCustomerID)
    'End Sub

    Private Sub UcCallsHistory1_initUpdateValue() Handles UcCallsHistory1.initUpdateValue
        UcCallsHistory1.customers_id = _CurrentCustomerID
        UcCallsHistory1.Reconductions = Integer.Parse(lblCpt_reconduction.Text)
        'UcCallsHistory1.FT = chkFt.Checked
    End Sub

    Private Sub RepositoryICustomersCustomers_id_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryICustomersCustomers_id.Click
        If GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle) Is Nothing Then Return
        _CurrentCustomerID = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle)("customers_id")
        refreshClient()
        XTabCustomers.SelectedTabPage = tabMain
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

    'Private Sub RepositoryIbtnAddDVD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
    '    Dim products_id As Integer
    '    Dim objProductsDVD As clsProduct_DVD
    '    Dim check As Boolean

    '    check = GridViewWishListAssigned.GetDataRow(GridViewWishListAssigned.FocusedRowHandle)("order_check")
    '    products_id = GridViewWishListAssigned.GetDataRow(GridViewWishListAssigned.FocusedRowHandle)("products_id")
    '    If check Then

    '        objProductsDVD = New clsProduct_DVD(SessionInfo, New PlushLib.dsProducts(), products_id, 0)
    '        objProductsDVD.ReplaceDvdWishlist(_CurrentCustomerID, products_id)

    '        MsgBox(products_id & " est rajouté dans la wishlist")
    '        loadwishlist(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID, lang_id)
    '    Else
    '        MsgBox(products_id & " n'est pas une dvd associé à une commande qui doit être vérifier", MsgBoxStyle.Critical)
    '    End If
    'End Sub

    'Private Sub RepositoryIbtnCheckOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
    '    Dim orders_id As Integer
    '    Dim status As Integer

    '    status = GridViewOrders.GetDataRow(GridViewOrders.FocusedRowHandle)("orders_status_id")
    '    orders_id = GridViewOrders.GetDataRow(GridViewOrders.FocusedRowHandle)("orders_id")
    '    If status <> PlushData.clsOdersStatusHistory.OrderStatusNew.RETURNED Then
    '        If status = PlushData.clsOdersStatusHistory.OrderStatusNew.DELAYED_GO Then
    '            PlushBuziness.clsOrders.UpdateOrder(orders_id, PlushData.clsOdersStatusHistory.OrderStatusNew.EXPEDITED, status)
    '        Else

    '            Dim frm As frmStatusOrder = New frmStatusOrder()
    '            frm.orders_id = orders_id
    '            frm.customers_id = _CurrentCustomerID
    '            frm.oldstatus = status
    '            frm.ShowDialog()
    '        End If

    '        refreshTab(XTabCustomers.SelectedTabPageIndex) = True
    '        loadOrders(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID)
    '        refreshTab(XTabCustomers.SelectedTabPageIndex) = True
    '        loadwishlist(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID, lang_id)

    '    End If
    'End Sub

    Private Sub btnCreditHistoryReplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        'PlushData.clsCreditHistory.GetUpdateAllCreditHistory(_CurrentCustomerID, ChkCreditCombined.Checked)
    End Sub

    Private Sub btnReplayAllCreditHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplayAllCreditHistory.Click
        Dim dt As DataTable
        Dim sql As String
        Dim index As Integer = 0
        Dim combined As Boolean
        Dim cpt_result As Integer
        sql = "select customers_id,combined from customers c left join customer_attributes ca on c.customers_id = ca.customer_id order by customers_id desc "
        dt = PlushData.clsConnection.FillDataSet(sql)
        PlushData.clsConnection.CreateTransaction(True)

        For Each dr As DataRow In dt.Rows

            If dr("combined") Is DBNull.Value Then
                combined = False
            Else
                combined = dr("combined")
            End If

            PlushData.clsCreditHistory.GetUpdateAllCreditHistory(dr("customers_id"), combined)
            index += 1

            If index Mod 1000 = 0 Then
                PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Batch, cpt_result)
                PlushData.clsConnection.CreateTransaction(True)
            End If
        Next
        PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Batch, cpt_result)
    End Sub
    ''' <summary>
    ''' used to cancel if change manually in suspension payment
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmbSuspended_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles cmbSuspended.EditValueChanging

        If e.NewValue = 2 And Not _loadInfo Then
            e.Cancel = True
            Return
        End If

        If e.NewValue = 1 Then
            cmbSuspended.BackColor = Drawing.Color.LightBlue
            cmbSuspended.ForeColor = Drawing.Color.White
        ElseIf e.NewValue = 2 Then
            cmbSuspended.BackColor = Drawing.Color.Red
            cmbSuspended.ForeColor = Drawing.Color.White
        Else
            cmbSuspended.BackColor = Nothing
        End If

    End Sub

    Private Sub RepositoryItemCheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit1.CheckedChanged
        Dim row As DataRow
        Dim sql As String

        If MsgBox("Are you sure to flag this token as compensed/uncompansed?", MsgBoxStyle.YesNo, "Warrning!") = MsgBoxResult.Yes Then

            row = GridView1.GetDataRow(GridView1.FocusedRowHandle())


            If row("compensed") = "True" Then
                row("compensed") = "False"
                sql = "update tokens set compensed = 0 where id = " & row("ID")
            Else
                sql = "update tokens set compensed = 1 where id = " & row("ID")
                row("compensed") = "True"
            End If

            PlushData.clsConnection.ExecuteNonQuery(sql, True)
        End If

    End Sub

    Private Sub LabelControl34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 

    End Sub
End Class

