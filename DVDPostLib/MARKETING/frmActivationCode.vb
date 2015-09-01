Imports System.IO
Imports System.Collections.Generic
Public Class frmActivationCode
    Inherits BizzLib.frmGeneral_Browse
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
    Friend WithEvents lblYear As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbValidTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtyToGenerate As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtValidValue As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbNextDiscount As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbValidType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbProductsID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbGroup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnGenerate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrefix As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DS As PlushLib.dsMarketting
    Friend WithEvents chkWaranty As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAuto_Stop_at_Next_Reconduction As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBanner As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDescEN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescNL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescFR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkFree_Upgrade_Allowed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFooter As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCampaign As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tabSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblSearch As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtActivationId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSearchName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupSearch As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtActivationCodeSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkOnlyUsed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabResult2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridActivationCode As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewActivationCode As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents activation_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_group As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents campaign_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_group_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_pack As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_code_creation_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_code_validto_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_products_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents validity_month As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents validity_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents validity_value As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_waranty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents comment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents abo_dvd_credit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents next_discount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents credit0_auto_reconduct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents abo_auto_stop_next_reconduction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents banner As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_text_fr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_text_nl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_text_en As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents free_upgrade_allowed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents footer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents campaign As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents combined_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCampaignSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCampaign As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnEx As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbGroupSearch As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtActivationCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbCombinedAction As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValidityMonth As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnSaveBycustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomerId As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomersIdSearch As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GrpCustomers As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValidityToCustomersChange As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtActivationCodeID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCreationDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnNewActivation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbNextAboType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveDiscount As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditActivation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNewDiscount As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXls As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colSize_w As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckDebitCard As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckCreditCard As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckPaypal As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbDiscountAction As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtActivationValue2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents cmbActivation_Type As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTVODFreeCredits As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents chkAllCust As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtComment As DevExpress.XtraEditors.TextEdit

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActivationCode))
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.lblYear = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtComment = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.btnGenerate = New DevExpress.XtraEditors.SimpleButton
        Me.cmbGroup = New DevExpress.XtraEditors.LookUpEdit
        Me.DS = New PlushLib.dsMarketting
        Me.cmbProductsID = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbValidType = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbNextDiscount = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtValidValue = New DevExpress.XtraEditors.SpinEdit
        Me.txtQtyToGenerate = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.cmbValidTo = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtPrefix = New DevExpress.XtraEditors.TextEdit
        Me.chkWaranty = New DevExpress.XtraEditors.CheckEdit
        Me.chkAuto_Stop_at_Next_Reconduction = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtBanner = New DevExpress.XtraEditors.TextEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.txtDescEN = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.txtDescNL = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.txtDescFR = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.chkFree_Upgrade_Allowed = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.txtFooter = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.txtCampaign = New DevExpress.XtraEditors.TextEdit
        Me.tabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.GroupSearch = New DevExpress.XtraEditors.GroupControl
        Me.btnXls = New DevExpress.XtraEditors.SimpleButton
        Me.btnNewActivation = New DevExpress.XtraEditors.SimpleButton
        Me.btnEx = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.cmbGroupSearch = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.txtCustomersIdSearch = New DevExpress.XtraEditors.SpinEdit
        Me.lblCampaign = New DevExpress.XtraEditors.LabelControl
        Me.chkOnlyUsed = New DevExpress.XtraEditors.CheckEdit
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.txtCampaignSearch = New DevExpress.XtraEditors.TextEdit
        Me.txtActivationCodeSearch = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.lblSearchName = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.lblSearch = New DevExpress.XtraEditors.LabelControl
        Me.txtActivationId = New DevExpress.XtraEditors.TextEdit
        Me.tabResult2 = New DevExpress.XtraTab.XtraTabPage
        Me.GridActivationCode = New DevExpress.XtraGrid.GridControl
        Me.GridViewActivationCode = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.activation_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_group = New DevExpress.XtraGrid.Columns.GridColumn
        Me.campaign_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_group_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_pack = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_code_creation_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_code_validto_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_products_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.validity_month = New DevExpress.XtraGrid.Columns.GridColumn
        Me.validity_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.validity_value = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_waranty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.comment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.abo_dvd_credit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.next_discount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.credit0_auto_reconduct = New DevExpress.XtraGrid.Columns.GridColumn
        Me.abo_auto_stop_next_reconduction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.banner = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_text_fr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_text_nl = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_text_en = New DevExpress.XtraGrid.Columns.GridColumn
        Me.free_upgrade_allowed = New DevExpress.XtraGrid.Columns.GridColumn
        Me.footer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.campaign = New DevExpress.XtraGrid.Columns.GridColumn
        Me.combined_action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSize_w = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.txtActivationCode = New DevExpress.XtraEditors.TextEdit
        Me.cmbCombinedAction = New DevExpress.XtraEditors.LookUpEdit
        Me.txtValidityMonth = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.btnSaveBycustomer = New DevExpress.XtraEditors.SimpleButton
        Me.txtCustomerId = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.GrpCustomers = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.txtValidityToCustomersChange = New DevExpress.XtraEditors.DateEdit
        Me.txtActivationCodeID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.txtCreationDate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.cmbNextAboType = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSaveDiscount = New DevExpress.XtraEditors.SimpleButton
        Me.btnEditActivation = New DevExpress.XtraEditors.SimpleButton
        Me.btnNewDiscount = New DevExpress.XtraEditors.SimpleButton
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.CheckDebitCard = New DevExpress.XtraEditors.CheckEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckCreditCard = New DevExpress.XtraEditors.CheckEdit
        Me.CheckPaypal = New DevExpress.XtraEditors.CheckEdit
        Me.cmbDiscountAction = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl
        Me.txtActivationValue2 = New DevExpress.XtraEditors.SpinEdit
        Me.cmbActivation_Type = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
        Me.txtTVODFreeCredits = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl
        Me.chkAllCust = New DevExpress.XtraEditors.CheckEdit
        Me.Panel1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabParameters.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        Me.TabChart.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductsID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbValidType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNextDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValidValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtyToGenerate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbValidTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbValidTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrefix.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkWaranty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAuto_Stop_at_Next_Reconduction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBanner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtDescEN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescFR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFree_Upgrade_Allowed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFooter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCampaign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearch.SuspendLayout()
        CType(Me.GroupSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupSearch.SuspendLayout()
        CType(Me.cmbGroupSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomersIdSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOnlyUsed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCampaignSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivationCodeSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivationId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabResult2.SuspendLayout()
        CType(Me.GridActivationCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewActivationCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivationCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCombinedAction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValidityMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrpCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpCustomers.SuspendLayout()
        CType(Me.txtValidityToCustomersChange.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValidityToCustomersChange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivationCodeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreationDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreationDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNextAboType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckDebitCard.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CheckCreditCard.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckPaypal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDiscountAction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivationValue2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbActivation_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTVODFreeCredits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAllCust.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        resources.ApplyResources(Me.StatusBar1, "StatusBar1")
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.SelectedTabPage = Me.TabResult
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabSearch, Me.tabResult2})
        Me.TabControl1.Controls.SetChildIndex(Me.TabChart, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabAnalyse, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabResult, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.tabResult2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabParameters, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.tabSearch, 0)
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.chkAllCust)
        Me.TabParameters.Controls.Add(Me.txtTVODFreeCredits)
        Me.TabParameters.Controls.Add(Me.LabelControl30)
        Me.TabParameters.Controls.Add(Me.txtActivationValue2)
        Me.TabParameters.Controls.Add(Me.cmbActivation_Type)
        Me.TabParameters.Controls.Add(Me.LabelControl8)
        Me.TabParameters.Controls.Add(Me.LabelControl29)
        Me.TabParameters.Controls.Add(Me.cmbDiscountAction)
        Me.TabParameters.Controls.Add(Me.LabelControl28)
        Me.TabParameters.Controls.Add(Me.GroupBox1)
        Me.TabParameters.Controls.Add(Me.btnCancel)
        Me.TabParameters.Controls.Add(Me.btnSaveDiscount)
        Me.TabParameters.Controls.Add(Me.btnEditActivation)
        Me.TabParameters.Controls.Add(Me.btnNewDiscount)
        Me.TabParameters.Controls.Add(Me.cmbNextAboType)
        Me.TabParameters.Controls.Add(Me.LabelControl27)
        Me.TabParameters.Controls.Add(Me.LabelControl26)
        Me.TabParameters.Controls.Add(Me.txtCreationDate)
        Me.TabParameters.Controls.Add(Me.LabelControl25)
        Me.TabParameters.Controls.Add(Me.txtActivationCodeID)
        Me.TabParameters.Controls.Add(Me.GrpCustomers)
        Me.TabParameters.Controls.Add(Me.LabelControl23)
        Me.TabParameters.Controls.Add(Me.cmbValidTo)
        Me.TabParameters.Controls.Add(Me.LabelControl2)
        Me.TabParameters.Controls.Add(Me.LabelControl20)
        Me.TabParameters.Controls.Add(Me.txtValidityMonth)
        Me.TabParameters.Controls.Add(Me.cmbCombinedAction)
        Me.TabParameters.Controls.Add(Me.txtActivationCode)
        Me.TabParameters.Controls.Add(Me.LabelControl19)
        Me.TabParameters.Controls.Add(Me.LabelControl15)
        Me.TabParameters.Controls.Add(Me.txtCampaign)
        Me.TabParameters.Controls.Add(Me.LabelControl14)
        Me.TabParameters.Controls.Add(Me.txtFooter)
        Me.TabParameters.Controls.Add(Me.chkFree_Upgrade_Allowed)
        Me.TabParameters.Controls.Add(Me.GroupControl2)
        Me.TabParameters.Controls.Add(Me.GroupControl1)
        Me.TabParameters.Controls.Add(Me.chkAuto_Stop_at_Next_Reconduction)
        Me.TabParameters.Controls.Add(Me.chkWaranty)
        Me.TabParameters.Controls.Add(Me.txtValidValue)
        Me.TabParameters.Controls.Add(Me.LabelControl6)
        Me.TabParameters.Controls.Add(Me.cmbNextDiscount)
        Me.TabParameters.Controls.Add(Me.cmbValidType)
        Me.TabParameters.Controls.Add(Me.cmbProductsID)
        Me.TabParameters.Controls.Add(Me.cmbGroup)
        Me.TabParameters.Controls.Add(Me.LabelControl5)
        Me.TabParameters.Controls.Add(Me.LabelControl4)
        Me.TabParameters.Controls.Add(Me.LabelControl1)
        Me.TabParameters.Controls.Add(Me.LabelControl3)
        Me.TabParameters.Controls.Add(Me.txtComment)
        Me.TabParameters.Controls.Add(Me.lblYear)
        resources.ApplyResources(Me.TabParameters, "TabParameters")
        '
        'TabResult
        '
        resources.ApplyResources(Me.TabResult, "TabResult")
        '
        'TabAnalyse
        '
        resources.ApplyResources(Me.TabAnalyse, "TabAnalyse")
        '
        'UcPivotGrid1
        '
        resources.ApplyResources(Me.UcPivotGrid1, "UcPivotGrid1")
        '
        'UcChart1
        '
        resources.ApplyResources(Me.UcChart1, "UcChart1")
        '
        'TabChart
        '
        resources.ApplyResources(Me.TabChart, "TabChart")
        '
        'btnViewDetail
        '
        Me.btnViewDetail.Glyph = CType(resources.GetObject("btnViewDetail.Glyph"), System.Drawing.Image)
        '
        'Grid1
        '
        resources.ApplyResources(Me.Grid1, "Grid1")
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.FormsUseDefaultLookAndFeel = False
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.HelpProvider1.SetShowHelp(Me.Grid1, CType(resources.GetObject("Grid1.ShowHelp"), Boolean))
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        resources.ApplyResources(Me.GridView1, "GridView1")
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowBands = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        Me.HelpProvider1.SetShowHelp(Me.lblYear, CType(resources.GetObject("lblYear.ShowHelp"), Boolean))
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, CType(resources.GetObject("LabelControl2.ShowHelp"), Boolean))
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl3, CType(resources.GetObject("LabelControl3.ShowHelp"), Boolean))
        '
        'txtComment
        '
        resources.ApplyResources(Me.txtComment, "txtComment")
        Me.txtComment.Name = "txtComment"
        Me.HelpProvider1.SetShowHelp(Me.txtComment, CType(resources.GetObject("txtComment.ShowHelp"), Boolean))
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, CType(resources.GetObject("LabelControl1.ShowHelp"), Boolean))
        '
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl4, CType(resources.GetObject("LabelControl4.ShowHelp"), Boolean))
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Name = "LabelControl5"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl5, CType(resources.GetObject("LabelControl5.ShowHelp"), Boolean))
        '
        'btnGenerate
        '
        resources.ApplyResources(Me.btnGenerate, "btnGenerate")
        Me.btnGenerate.Name = "btnGenerate"
        '
        'cmbGroup
        '
        resources.ApplyResources(Me.cmbGroup, "cmbGroup")
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbGroup.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbGroup.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbGroup.Properties.DisplayMember = "DisplayMember"
        Me.cmbGroup.Properties.NullText = resources.GetString("cmbGroup.Properties.NullText")
        Me.cmbGroup.Properties.ValueMember = "Value"
        '
        'DS
        '
        Me.DS.DataSetName = "dsMarketting"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbProductsID
        '
        resources.ApplyResources(Me.cmbProductsID, "cmbProductsID")
        Me.cmbProductsID.Name = "cmbProductsID"
        Me.cmbProductsID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbProductsID.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbProductsID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 75, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbProductsID.Properties.DisplayMember = "DisplayMember"
        Me.cmbProductsID.Properties.NullText = resources.GetString("cmbProductsID.Properties.NullText")
        Me.cmbProductsID.Properties.PopupWidth = 500
        Me.cmbProductsID.Properties.ValueMember = "Value"
        Me.HelpProvider1.SetShowHelp(Me.cmbProductsID, CType(resources.GetObject("cmbProductsID.ShowHelp"), Boolean))
        '
        'cmbValidType
        '
        resources.ApplyResources(Me.cmbValidType, "cmbValidType")
        Me.cmbValidType.Name = "cmbValidType"
        Me.cmbValidType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbValidType.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbValidType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbValidType.Properties.DisplayMember = "DisplayMember"
        Me.cmbValidType.Properties.NullText = resources.GetString("cmbValidType.Properties.NullText")
        Me.cmbValidType.Properties.ValueMember = "Value"
        Me.HelpProvider1.SetShowHelp(Me.cmbValidType, CType(resources.GetObject("cmbValidType.ShowHelp"), Boolean))
        '
        'cmbNextDiscount
        '
        resources.ApplyResources(Me.cmbNextDiscount, "cmbNextDiscount")
        Me.cmbNextDiscount.Name = "cmbNextDiscount"
        Me.cmbNextDiscount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbNextDiscount.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbNextDiscount.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 50)})
        Me.cmbNextDiscount.Properties.DisplayMember = "DisplayMember"
        Me.cmbNextDiscount.Properties.NullText = resources.GetString("cmbNextDiscount.Properties.NullText")
        Me.cmbNextDiscount.Properties.PopupWidth = 500
        Me.cmbNextDiscount.Properties.ValueMember = "Value"
        Me.HelpProvider1.SetShowHelp(Me.cmbNextDiscount, CType(resources.GetObject("cmbNextDiscount.ShowHelp"), Boolean))
        '
        'LabelControl6
        '
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.Name = "LabelControl6"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl6, CType(resources.GetObject("LabelControl6.ShowHelp"), Boolean))
        '
        'txtValidValue
        '
        resources.ApplyResources(Me.txtValidValue, "txtValidValue")
        Me.txtValidValue.Name = "txtValidValue"
        Me.txtValidValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtValidValue.Properties.MaxLength = 1000000
        Me.txtValidValue.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
        '
        'txtQtyToGenerate
        '
        resources.ApplyResources(Me.txtQtyToGenerate, "txtQtyToGenerate")
        Me.txtQtyToGenerate.Name = "txtQtyToGenerate"
        Me.txtQtyToGenerate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtQtyToGenerate.Properties.MaxLength = 1000000
        Me.txtQtyToGenerate.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtQtyToGenerate, CType(resources.GetObject("txtQtyToGenerate.ShowHelp"), Boolean))
        '
        'LabelControl7
        '
        resources.ApplyResources(Me.LabelControl7, "LabelControl7")
        Me.LabelControl7.Name = "LabelControl7"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl7, CType(resources.GetObject("LabelControl7.ShowHelp"), Boolean))
        '
        'cmbValidTo
        '
        Me.cmbValidTo.EditValue = Nothing
        resources.ApplyResources(Me.cmbValidTo, "cmbValidTo")
        Me.cmbValidTo.Name = "cmbValidTo"
        Me.cmbValidTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbValidTo.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbValidTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'LabelControl9
        '
        resources.ApplyResources(Me.LabelControl9, "LabelControl9")
        Me.LabelControl9.Name = "LabelControl9"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl9, CType(resources.GetObject("LabelControl9.ShowHelp"), Boolean))
        '
        'txtPrefix
        '
        resources.ApplyResources(Me.txtPrefix, "txtPrefix")
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Properties.MaxLength = 5
        Me.HelpProvider1.SetShowHelp(Me.txtPrefix, CType(resources.GetObject("txtPrefix.ShowHelp"), Boolean))
        '
        'chkWaranty
        '
        resources.ApplyResources(Me.chkWaranty, "chkWaranty")
        Me.chkWaranty.Name = "chkWaranty"
        Me.chkWaranty.Properties.Caption = resources.GetString("chkWaranty.Properties.Caption")
        Me.chkWaranty.Properties.ValueChecked = 1
        Me.chkWaranty.Properties.ValueUnchecked = 0
        '
        'chkAuto_Stop_at_Next_Reconduction
        '
        resources.ApplyResources(Me.chkAuto_Stop_at_Next_Reconduction, "chkAuto_Stop_at_Next_Reconduction")
        Me.chkAuto_Stop_at_Next_Reconduction.Name = "chkAuto_Stop_at_Next_Reconduction"
        Me.chkAuto_Stop_at_Next_Reconduction.Properties.Caption = resources.GetString("chkAuto_Stop_at_Next_Reconduction.Properties.Caption")
        Me.chkAuto_Stop_at_Next_Reconduction.Properties.ValueChecked = 1
        Me.chkAuto_Stop_at_Next_Reconduction.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.chkAuto_Stop_at_Next_Reconduction, CType(resources.GetObject("chkAuto_Stop_at_Next_Reconduction.ShowHelp"), Boolean))
        '
        'LabelControl10
        '
        resources.ApplyResources(Me.LabelControl10, "LabelControl10")
        Me.LabelControl10.Name = "LabelControl10"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl10, CType(resources.GetObject("LabelControl10.ShowHelp"), Boolean))
        '
        'txtBanner
        '
        resources.ApplyResources(Me.txtBanner, "txtBanner")
        Me.txtBanner.Name = "txtBanner"
        Me.HelpProvider1.SetShowHelp(Me.txtBanner, CType(resources.GetObject("txtBanner.ShowHelp"), Boolean))
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.txtQtyToGenerate)
        Me.GroupControl1.Controls.Add(Me.btnGenerate)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txtPrefix)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Name = "GroupControl1"
        '
        'GroupControl2
        '
        resources.ApplyResources(Me.GroupControl2, "GroupControl2")
        Me.GroupControl2.Controls.Add(Me.txtDescEN)
        Me.GroupControl2.Controls.Add(Me.LabelControl13)
        Me.GroupControl2.Controls.Add(Me.txtDescNL)
        Me.GroupControl2.Controls.Add(Me.LabelControl12)
        Me.GroupControl2.Controls.Add(Me.txtDescFR)
        Me.GroupControl2.Controls.Add(Me.LabelControl11)
        Me.GroupControl2.Controls.Add(Me.txtBanner)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Name = "GroupControl2"
        '
        'txtDescEN
        '
        resources.ApplyResources(Me.txtDescEN, "txtDescEN")
        Me.txtDescEN.Name = "txtDescEN"
        Me.HelpProvider1.SetShowHelp(Me.txtDescEN, CType(resources.GetObject("txtDescEN.ShowHelp"), Boolean))
        '
        'LabelControl13
        '
        resources.ApplyResources(Me.LabelControl13, "LabelControl13")
        Me.LabelControl13.Name = "LabelControl13"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl13, CType(resources.GetObject("LabelControl13.ShowHelp"), Boolean))
        '
        'txtDescNL
        '
        resources.ApplyResources(Me.txtDescNL, "txtDescNL")
        Me.txtDescNL.Name = "txtDescNL"
        Me.HelpProvider1.SetShowHelp(Me.txtDescNL, CType(resources.GetObject("txtDescNL.ShowHelp"), Boolean))
        '
        'LabelControl12
        '
        resources.ApplyResources(Me.LabelControl12, "LabelControl12")
        Me.LabelControl12.Name = "LabelControl12"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl12, CType(resources.GetObject("LabelControl12.ShowHelp"), Boolean))
        '
        'txtDescFR
        '
        resources.ApplyResources(Me.txtDescFR, "txtDescFR")
        Me.txtDescFR.Name = "txtDescFR"
        Me.HelpProvider1.SetShowHelp(Me.txtDescFR, CType(resources.GetObject("txtDescFR.ShowHelp"), Boolean))
        '
        'LabelControl11
        '
        resources.ApplyResources(Me.LabelControl11, "LabelControl11")
        Me.LabelControl11.Name = "LabelControl11"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl11, CType(resources.GetObject("LabelControl11.ShowHelp"), Boolean))
        '
        'chkFree_Upgrade_Allowed
        '
        resources.ApplyResources(Me.chkFree_Upgrade_Allowed, "chkFree_Upgrade_Allowed")
        Me.chkFree_Upgrade_Allowed.Name = "chkFree_Upgrade_Allowed"
        Me.chkFree_Upgrade_Allowed.Properties.Caption = resources.GetString("chkFree_Upgrade_Allowed.Properties.Caption")
        Me.chkFree_Upgrade_Allowed.Properties.ValueChecked = 1
        Me.chkFree_Upgrade_Allowed.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.chkFree_Upgrade_Allowed, CType(resources.GetObject("chkFree_Upgrade_Allowed.ShowHelp"), Boolean))
        '
        'LabelControl14
        '
        resources.ApplyResources(Me.LabelControl14, "LabelControl14")
        Me.LabelControl14.Name = "LabelControl14"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl14, CType(resources.GetObject("LabelControl14.ShowHelp"), Boolean))
        '
        'txtFooter
        '
        resources.ApplyResources(Me.txtFooter, "txtFooter")
        Me.txtFooter.Name = "txtFooter"
        Me.HelpProvider1.SetShowHelp(Me.txtFooter, CType(resources.GetObject("txtFooter.ShowHelp"), Boolean))
        '
        'LabelControl15
        '
        resources.ApplyResources(Me.LabelControl15, "LabelControl15")
        Me.LabelControl15.Name = "LabelControl15"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl15, CType(resources.GetObject("LabelControl15.ShowHelp"), Boolean))
        '
        'txtCampaign
        '
        resources.ApplyResources(Me.txtCampaign, "txtCampaign")
        Me.txtCampaign.Name = "txtCampaign"
        Me.HelpProvider1.SetShowHelp(Me.txtCampaign, CType(resources.GetObject("txtCampaign.ShowHelp"), Boolean))
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
        Me.GroupSearch.Controls.Add(Me.btnXls)
        Me.GroupSearch.Controls.Add(Me.btnNewActivation)
        Me.GroupSearch.Controls.Add(Me.btnEx)
        Me.GroupSearch.Controls.Add(Me.LabelControl22)
        Me.GroupSearch.Controls.Add(Me.cmbGroupSearch)
        Me.GroupSearch.Controls.Add(Me.LabelControl18)
        Me.GroupSearch.Controls.Add(Me.txtCustomersIdSearch)
        Me.GroupSearch.Controls.Add(Me.lblCampaign)
        Me.GroupSearch.Controls.Add(Me.chkOnlyUsed)
        Me.GroupSearch.Controls.Add(Me.txtFromDate)
        Me.GroupSearch.Controls.Add(Me.txtCampaignSearch)
        Me.GroupSearch.Controls.Add(Me.txtActivationCodeSearch)
        Me.GroupSearch.Controls.Add(Me.LabelControl16)
        Me.GroupSearch.Controls.Add(Me.lblSearchName)
        Me.GroupSearch.Controls.Add(Me.txtToDate)
        Me.GroupSearch.Controls.Add(Me.btnSearch)
        Me.GroupSearch.Controls.Add(Me.LabelControl17)
        Me.GroupSearch.Controls.Add(Me.lblSearch)
        Me.GroupSearch.Controls.Add(Me.txtActivationId)
        Me.GroupSearch.Name = "GroupSearch"
        Me.HelpProvider1.SetShowHelp(Me.GroupSearch, CType(resources.GetObject("GroupSearch.ShowHelp"), Boolean))
        '
        'btnXls
        '
        Me.btnXls.Image = CType(resources.GetObject("btnXls.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.btnXls, "btnXls")
        Me.btnXls.Name = "btnXls"
        Me.HelpProvider1.SetShowHelp(Me.btnXls, CType(resources.GetObject("btnXls.ShowHelp"), Boolean))
        '
        'btnNewActivation
        '
        resources.ApplyResources(Me.btnNewActivation, "btnNewActivation")
        Me.btnNewActivation.Name = "btnNewActivation"
        Me.HelpProvider1.SetShowHelp(Me.btnNewActivation, CType(resources.GetObject("btnNewActivation.ShowHelp"), Boolean))
        '
        'btnEx
        '
        resources.ApplyResources(Me.btnEx, "btnEx")
        Me.btnEx.Name = "btnEx"
        Me.HelpProvider1.SetShowHelp(Me.btnEx, CType(resources.GetObject("btnEx.ShowHelp"), Boolean))
        '
        'LabelControl22
        '
        resources.ApplyResources(Me.LabelControl22, "LabelControl22")
        Me.LabelControl22.Name = "LabelControl22"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl22, CType(resources.GetObject("LabelControl22.ShowHelp"), Boolean))
        '
        'cmbGroupSearch
        '
        resources.ApplyResources(Me.cmbGroupSearch, "cmbGroupSearch")
        Me.cmbGroupSearch.Name = "cmbGroupSearch"
        Me.cmbGroupSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbGroupSearch.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbGroupSearch.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbGroupSearch.Properties.DisplayMember = "DisplayMember"
        Me.cmbGroupSearch.Properties.NullText = resources.GetString("cmbGroupSearch.Properties.NullText")
        Me.cmbGroupSearch.Properties.ValueMember = "Value"
        Me.HelpProvider1.SetShowHelp(Me.cmbGroupSearch, CType(resources.GetObject("cmbGroupSearch.ShowHelp"), Boolean))
        '
        'LabelControl18
        '
        resources.ApplyResources(Me.LabelControl18, "LabelControl18")
        Me.LabelControl18.Name = "LabelControl18"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl18, CType(resources.GetObject("LabelControl18.ShowHelp"), Boolean))
        '
        'txtCustomersIdSearch
        '
        resources.ApplyResources(Me.txtCustomersIdSearch, "txtCustomersIdSearch")
        Me.txtCustomersIdSearch.Name = "txtCustomersIdSearch"
        Me.txtCustomersIdSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCustomersIdSearch.Properties.MaxLength = 1000000
        Me.txtCustomersIdSearch.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtCustomersIdSearch, CType(resources.GetObject("txtCustomersIdSearch.ShowHelp"), Boolean))
        '
        'lblCampaign
        '
        resources.ApplyResources(Me.lblCampaign, "lblCampaign")
        Me.lblCampaign.Name = "lblCampaign"
        Me.HelpProvider1.SetShowHelp(Me.lblCampaign, CType(resources.GetObject("lblCampaign.ShowHelp"), Boolean))
        '
        'chkOnlyUsed
        '
        resources.ApplyResources(Me.chkOnlyUsed, "chkOnlyUsed")
        Me.chkOnlyUsed.Name = "chkOnlyUsed"
        Me.chkOnlyUsed.Properties.Caption = resources.GetString("chkOnlyUsed.Properties.Caption")
        Me.chkOnlyUsed.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.HelpProvider1.SetShowHelp(Me.chkOnlyUsed, CType(resources.GetObject("chkOnlyUsed.ShowHelp"), Boolean))
        '
        'txtFromDate
        '
        Me.txtFromDate.EditValue = Nothing
        resources.ApplyResources(Me.txtFromDate, "txtFromDate")
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtFromDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtFromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtFromDate, CType(resources.GetObject("txtFromDate.ShowHelp"), Boolean))
        '
        'txtCampaignSearch
        '
        resources.ApplyResources(Me.txtCampaignSearch, "txtCampaignSearch")
        Me.txtCampaignSearch.Name = "txtCampaignSearch"
        Me.HelpProvider1.SetShowHelp(Me.txtCampaignSearch, CType(resources.GetObject("txtCampaignSearch.ShowHelp"), Boolean))
        '
        'txtActivationCodeSearch
        '
        resources.ApplyResources(Me.txtActivationCodeSearch, "txtActivationCodeSearch")
        Me.txtActivationCodeSearch.Name = "txtActivationCodeSearch"
        Me.HelpProvider1.SetShowHelp(Me.txtActivationCodeSearch, CType(resources.GetObject("txtActivationCodeSearch.ShowHelp"), Boolean))
        '
        'LabelControl16
        '
        resources.ApplyResources(Me.LabelControl16, "LabelControl16")
        Me.LabelControl16.Name = "LabelControl16"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl16, CType(resources.GetObject("LabelControl16.ShowHelp"), Boolean))
        '
        'lblSearchName
        '
        resources.ApplyResources(Me.lblSearchName, "lblSearchName")
        Me.lblSearchName.Name = "lblSearchName"
        Me.HelpProvider1.SetShowHelp(Me.lblSearchName, CType(resources.GetObject("lblSearchName.ShowHelp"), Boolean))
        '
        'txtToDate
        '
        Me.txtToDate.EditValue = Nothing
        resources.ApplyResources(Me.txtToDate, "txtToDate")
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtToDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtToDate, CType(resources.GetObject("txtToDate.ShowHelp"), Boolean))
        '
        'btnSearch
        '
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        Me.btnSearch.Name = "btnSearch"
        Me.HelpProvider1.SetShowHelp(Me.btnSearch, CType(resources.GetObject("btnSearch.ShowHelp"), Boolean))
        '
        'LabelControl17
        '
        resources.ApplyResources(Me.LabelControl17, "LabelControl17")
        Me.LabelControl17.Name = "LabelControl17"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl17, CType(resources.GetObject("LabelControl17.ShowHelp"), Boolean))
        '
        'lblSearch
        '
        resources.ApplyResources(Me.lblSearch, "lblSearch")
        Me.lblSearch.Name = "lblSearch"
        Me.HelpProvider1.SetShowHelp(Me.lblSearch, CType(resources.GetObject("lblSearch.ShowHelp"), Boolean))
        '
        'txtActivationId
        '
        resources.ApplyResources(Me.txtActivationId, "txtActivationId")
        Me.txtActivationId.Name = "txtActivationId"
        Me.HelpProvider1.SetShowHelp(Me.txtActivationId, CType(resources.GetObject("txtActivationId.ShowHelp"), Boolean))
        '
        'tabResult2
        '
        Me.tabResult2.Controls.Add(Me.GridActivationCode)
        Me.tabResult2.Name = "tabResult2"
        resources.ApplyResources(Me.tabResult2, "tabResult2")
        '
        'GridActivationCode
        '
        resources.ApplyResources(Me.GridActivationCode, "GridActivationCode")
        Me.GridActivationCode.EmbeddedNavigator.Name = ""
        Me.GridActivationCode.FormsUseDefaultLookAndFeel = False
        Me.GridActivationCode.MainView = Me.GridViewActivationCode
        Me.GridActivationCode.Name = "GridActivationCode"
        Me.GridActivationCode.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewActivationCode})
        '
        'GridViewActivationCode
        '
        Me.GridViewActivationCode.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.activation_id, Me.activation_code, Me.activation_group, Me.campaign_id, Me.activation_group_id, Me.activation_pack, Me.activation_code_creation_date, Me.activation_code_validto_date, Me.activation_products_id, Me.validity_month, Me.validity_type, Me.validity_value, Me.activation_waranty, Me.customers_id, Me.activation_date, Me.comment, Me.abo_dvd_credit, Me.next_discount, Me.credit0_auto_reconduct, Me.abo_auto_stop_next_reconduction, Me.banner, Me.activation_text_fr, Me.activation_text_nl, Me.activation_text_en, Me.free_upgrade_allowed, Me.footer, Me.campaign, Me.combined_action, Me.colSize_w})
        Me.GridViewActivationCode.GridControl = Me.GridActivationCode
        Me.GridViewActivationCode.Name = "GridViewActivationCode"
        Me.GridViewActivationCode.OptionsView.ShowFooter = True
        '
        'activation_id
        '
        resources.ApplyResources(Me.activation_id, "activation_id")
        Me.activation_id.FieldName = "activation_id"
        Me.activation_id.Name = "activation_id"
        Me.activation_id.OptionsColumn.ReadOnly = True
        '
        'activation_code
        '
        resources.ApplyResources(Me.activation_code, "activation_code")
        Me.activation_code.FieldName = "activation_code"
        Me.activation_code.Name = "activation_code"
        Me.activation_code.OptionsColumn.ReadOnly = True
        '
        'activation_group
        '
        resources.ApplyResources(Me.activation_group, "activation_group")
        Me.activation_group.FieldName = "activation_group"
        Me.activation_group.Name = "activation_group"
        '
        'campaign_id
        '
        resources.ApplyResources(Me.campaign_id, "campaign_id")
        Me.campaign_id.FieldName = "campaign_id"
        Me.campaign_id.Name = "campaign_id"
        '
        'activation_group_id
        '
        resources.ApplyResources(Me.activation_group_id, "activation_group_id")
        Me.activation_group_id.FieldName = "activation_group_id"
        Me.activation_group_id.Name = "activation_group_id"
        '
        'activation_pack
        '
        resources.ApplyResources(Me.activation_pack, "activation_pack")
        Me.activation_pack.FieldName = "activation_pack"
        Me.activation_pack.Name = "activation_pack"
        '
        'activation_code_creation_date
        '
        resources.ApplyResources(Me.activation_code_creation_date, "activation_code_creation_date")
        Me.activation_code_creation_date.FieldName = "activation_code_creation_date"
        Me.activation_code_creation_date.Name = "activation_code_creation_date"
        Me.activation_code_creation_date.OptionsColumn.ReadOnly = True
        '
        'activation_code_validto_date
        '
        resources.ApplyResources(Me.activation_code_validto_date, "activation_code_validto_date")
        Me.activation_code_validto_date.FieldName = "activation_code_validto_date"
        Me.activation_code_validto_date.Name = "activation_code_validto_date"
        Me.activation_code_validto_date.OptionsColumn.ReadOnly = True
        '
        'activation_products_id
        '
        resources.ApplyResources(Me.activation_products_id, "activation_products_id")
        Me.activation_products_id.FieldName = "activation_products_id"
        Me.activation_products_id.Name = "activation_products_id"
        Me.activation_products_id.OptionsColumn.ReadOnly = True
        '
        'validity_month
        '
        resources.ApplyResources(Me.validity_month, "validity_month")
        Me.validity_month.FieldName = "validity_month"
        Me.validity_month.Name = "validity_month"
        Me.validity_month.OptionsColumn.ReadOnly = True
        '
        'validity_type
        '
        resources.ApplyResources(Me.validity_type, "validity_type")
        Me.validity_type.FieldName = "validity_type"
        Me.validity_type.Name = "validity_type"
        Me.validity_type.OptionsColumn.ReadOnly = True
        '
        'validity_value
        '
        resources.ApplyResources(Me.validity_value, "validity_value")
        Me.validity_value.FieldName = "validity_value"
        Me.validity_value.Name = "validity_value"
        Me.validity_value.OptionsColumn.ReadOnly = True
        '
        'activation_waranty
        '
        resources.ApplyResources(Me.activation_waranty, "activation_waranty")
        Me.activation_waranty.FieldName = "activation_waranty"
        Me.activation_waranty.Name = "activation_waranty"
        '
        'customers_id
        '
        resources.ApplyResources(Me.customers_id, "customers_id")
        Me.customers_id.FieldName = "customers_id"
        Me.customers_id.Name = "customers_id"
        Me.customers_id.OptionsColumn.ReadOnly = True
        '
        'activation_date
        '
        resources.ApplyResources(Me.activation_date, "activation_date")
        Me.activation_date.DisplayFormat.FormatString = "d"
        Me.activation_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.activation_date.FieldName = "activation_date"
        Me.activation_date.Name = "activation_date"
        Me.activation_date.OptionsColumn.ReadOnly = True
        '
        'comment
        '
        resources.ApplyResources(Me.comment, "comment")
        Me.comment.FieldName = "comment"
        Me.comment.Name = "comment"
        Me.comment.OptionsColumn.ReadOnly = True
        '
        'abo_dvd_credit
        '
        resources.ApplyResources(Me.abo_dvd_credit, "abo_dvd_credit")
        Me.abo_dvd_credit.FieldName = "abo_dvd_credit"
        Me.abo_dvd_credit.Name = "abo_dvd_credit"
        Me.abo_dvd_credit.OptionsColumn.ReadOnly = True
        '
        'next_discount
        '
        resources.ApplyResources(Me.next_discount, "next_discount")
        Me.next_discount.FieldName = "next_discount"
        Me.next_discount.Name = "next_discount"
        Me.next_discount.OptionsColumn.ReadOnly = True
        '
        'credit0_auto_reconduct
        '
        resources.ApplyResources(Me.credit0_auto_reconduct, "credit0_auto_reconduct")
        Me.credit0_auto_reconduct.FieldName = "credit0_auto_reconduct"
        Me.credit0_auto_reconduct.Name = "credit0_auto_reconduct"
        '
        'abo_auto_stop_next_reconduction
        '
        resources.ApplyResources(Me.abo_auto_stop_next_reconduction, "abo_auto_stop_next_reconduction")
        Me.abo_auto_stop_next_reconduction.FieldName = "abo_auto_stop_next_reconduction"
        Me.abo_auto_stop_next_reconduction.Name = "abo_auto_stop_next_reconduction"
        '
        'banner
        '
        resources.ApplyResources(Me.banner, "banner")
        Me.banner.FieldName = "banner"
        Me.banner.Name = "banner"
        '
        'activation_text_fr
        '
        resources.ApplyResources(Me.activation_text_fr, "activation_text_fr")
        Me.activation_text_fr.FieldName = "activation_text_fr"
        Me.activation_text_fr.Name = "activation_text_fr"
        '
        'activation_text_nl
        '
        resources.ApplyResources(Me.activation_text_nl, "activation_text_nl")
        Me.activation_text_nl.FieldName = "activation_text_nl"
        Me.activation_text_nl.Name = "activation_text_nl"
        '
        'activation_text_en
        '
        resources.ApplyResources(Me.activation_text_en, "activation_text_en")
        Me.activation_text_en.FieldName = "activation_text_en"
        Me.activation_text_en.Name = "activation_text_en"
        '
        'free_upgrade_allowed
        '
        resources.ApplyResources(Me.free_upgrade_allowed, "free_upgrade_allowed")
        Me.free_upgrade_allowed.FieldName = "free_upgrade_allowed"
        Me.free_upgrade_allowed.Name = "free_upgrade_allowed"
        '
        'footer
        '
        resources.ApplyResources(Me.footer, "footer")
        Me.footer.FieldName = "footer"
        Me.footer.Name = "footer"
        '
        'campaign
        '
        resources.ApplyResources(Me.campaign, "campaign")
        Me.campaign.FieldName = "campaign"
        Me.campaign.Name = "campaign"
        Me.campaign.OptionsColumn.ReadOnly = True
        '
        'combined_action
        '
        resources.ApplyResources(Me.combined_action, "combined_action")
        Me.combined_action.FieldName = "combined_action"
        Me.combined_action.Name = "combined_action"
        '
        'colSize_w
        '
        resources.ApplyResources(Me.colSize_w, "colSize_w")
        Me.colSize_w.FieldName = "size_w"
        Me.colSize_w.Name = "colSize_w"
        '
        'LabelControl19
        '
        resources.ApplyResources(Me.LabelControl19, "LabelControl19")
        Me.LabelControl19.Name = "LabelControl19"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl19, CType(resources.GetObject("LabelControl19.ShowHelp"), Boolean))
        '
        'txtActivationCode
        '
        resources.ApplyResources(Me.txtActivationCode, "txtActivationCode")
        Me.txtActivationCode.Name = "txtActivationCode"
        Me.HelpProvider1.SetShowHelp(Me.txtActivationCode, CType(resources.GetObject("txtActivationCode.ShowHelp"), Boolean))
        '
        'cmbCombinedAction
        '
        resources.ApplyResources(Me.cmbCombinedAction, "cmbCombinedAction")
        Me.cmbCombinedAction.Name = "cmbCombinedAction"
        Me.cmbCombinedAction.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbCombinedAction.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbCombinedAction.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbCombinedAction.Properties.DisplayMember = "DisplayMember"
        Me.cmbCombinedAction.Properties.NullText = resources.GetString("cmbCombinedAction.Properties.NullText")
        Me.cmbCombinedAction.Properties.ValueMember = "DisplayMember"
        Me.HelpProvider1.SetShowHelp(Me.cmbCombinedAction, CType(resources.GetObject("cmbCombinedAction.ShowHelp"), Boolean))
        '
        'txtValidityMonth
        '
        resources.ApplyResources(Me.txtValidityMonth, "txtValidityMonth")
        Me.txtValidityMonth.Name = "txtValidityMonth"
        Me.txtValidityMonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtValidityMonth.Properties.MaxLength = 1000000
        Me.txtValidityMonth.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtValidityMonth, CType(resources.GetObject("txtValidityMonth.ShowHelp"), Boolean))
        '
        'LabelControl20
        '
        resources.ApplyResources(Me.LabelControl20, "LabelControl20")
        Me.LabelControl20.Name = "LabelControl20"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl20, CType(resources.GetObject("LabelControl20.ShowHelp"), Boolean))
        '
        'btnSaveBycustomer
        '
        resources.ApplyResources(Me.btnSaveBycustomer, "btnSaveBycustomer")
        Me.btnSaveBycustomer.Name = "btnSaveBycustomer"
        Me.HelpProvider1.SetShowHelp(Me.btnSaveBycustomer, CType(resources.GetObject("btnSaveBycustomer.ShowHelp"), Boolean))
        '
        'txtCustomerId
        '
        resources.ApplyResources(Me.txtCustomerId, "txtCustomerId")
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCustomerId.Properties.MaxLength = 1000000
        Me.txtCustomerId.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtCustomerId, CType(resources.GetObject("txtCustomerId.ShowHelp"), Boolean))
        '
        'LabelControl21
        '
        resources.ApplyResources(Me.LabelControl21, "LabelControl21")
        Me.LabelControl21.Name = "LabelControl21"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl21, CType(resources.GetObject("LabelControl21.ShowHelp"), Boolean))
        '
        'LabelControl23
        '
        resources.ApplyResources(Me.LabelControl23, "LabelControl23")
        Me.LabelControl23.Name = "LabelControl23"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl23, CType(resources.GetObject("LabelControl23.ShowHelp"), Boolean))
        '
        'GrpCustomers
        '
        resources.ApplyResources(Me.GrpCustomers, "GrpCustomers")
        Me.GrpCustomers.Controls.Add(Me.LabelControl24)
        Me.GrpCustomers.Controls.Add(Me.txtValidityToCustomersChange)
        Me.GrpCustomers.Controls.Add(Me.btnSaveBycustomer)
        Me.GrpCustomers.Controls.Add(Me.txtCustomerId)
        Me.GrpCustomers.Controls.Add(Me.LabelControl21)
        Me.GrpCustomers.Name = "GrpCustomers"
        Me.HelpProvider1.SetShowHelp(Me.GrpCustomers, CType(resources.GetObject("GrpCustomers.ShowHelp"), Boolean))
        '
        'LabelControl24
        '
        resources.ApplyResources(Me.LabelControl24, "LabelControl24")
        Me.LabelControl24.Name = "LabelControl24"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl24, CType(resources.GetObject("LabelControl24.ShowHelp"), Boolean))
        '
        'txtValidityToCustomersChange
        '
        Me.txtValidityToCustomersChange.EditValue = Nothing
        resources.ApplyResources(Me.txtValidityToCustomersChange, "txtValidityToCustomersChange")
        Me.txtValidityToCustomersChange.Name = "txtValidityToCustomersChange"
        Me.txtValidityToCustomersChange.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtValidityToCustomersChange.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtValidityToCustomersChange.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtValidityToCustomersChange, CType(resources.GetObject("txtValidityToCustomersChange.ShowHelp"), Boolean))
        '
        'txtActivationCodeID
        '
        resources.ApplyResources(Me.txtActivationCodeID, "txtActivationCodeID")
        Me.txtActivationCodeID.Name = "txtActivationCodeID"
        Me.HelpProvider1.SetShowHelp(Me.txtActivationCodeID, CType(resources.GetObject("txtActivationCodeID.ShowHelp"), Boolean))
        '
        'LabelControl25
        '
        resources.ApplyResources(Me.LabelControl25, "LabelControl25")
        Me.LabelControl25.Name = "LabelControl25"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl25, CType(resources.GetObject("LabelControl25.ShowHelp"), Boolean))
        '
        'txtCreationDate
        '
        resources.ApplyResources(Me.txtCreationDate, "txtCreationDate")
        Me.txtCreationDate.Name = "txtCreationDate"
        Me.txtCreationDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtCreationDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtCreationDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtCreationDate, CType(resources.GetObject("txtCreationDate.ShowHelp"), Boolean))
        '
        'LabelControl26
        '
        resources.ApplyResources(Me.LabelControl26, "LabelControl26")
        Me.LabelControl26.Name = "LabelControl26"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl26, CType(resources.GetObject("LabelControl26.ShowHelp"), Boolean))
        '
        'cmbNextAboType
        '
        Me.cmbNextAboType.AllowDrop = True
        resources.ApplyResources(Me.cmbNextAboType, "cmbNextAboType")
        Me.cmbNextAboType.Name = "cmbNextAboType"
        Me.cmbNextAboType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbNextAboType.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbNextAboType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 87, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 98, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbNextAboType.Properties.DisplayMember = "DisplayMember"
        Me.cmbNextAboType.Properties.NullText = resources.GetString("cmbNextAboType.Properties.NullText")
        Me.cmbNextAboType.Properties.ValueMember = "Value"
        '
        'LabelControl27
        '
        resources.ApplyResources(Me.LabelControl27, "LabelControl27")
        Me.LabelControl27.Name = "LabelControl27"
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Name = "btnCancel"
        Me.HelpProvider1.SetShowHelp(Me.btnCancel, CType(resources.GetObject("btnCancel.ShowHelp"), Boolean))
        '
        'btnSaveDiscount
        '
        resources.ApplyResources(Me.btnSaveDiscount, "btnSaveDiscount")
        Me.btnSaveDiscount.Name = "btnSaveDiscount"
        Me.HelpProvider1.SetShowHelp(Me.btnSaveDiscount, CType(resources.GetObject("btnSaveDiscount.ShowHelp"), Boolean))
        '
        'btnEditActivation
        '
        resources.ApplyResources(Me.btnEditActivation, "btnEditActivation")
        Me.btnEditActivation.Name = "btnEditActivation"
        Me.HelpProvider1.SetShowHelp(Me.btnEditActivation, CType(resources.GetObject("btnEditActivation.ShowHelp"), Boolean))
        '
        'btnNewDiscount
        '
        resources.ApplyResources(Me.btnNewDiscount, "btnNewDiscount")
        Me.btnNewDiscount.Name = "btnNewDiscount"
        Me.HelpProvider1.SetShowHelp(Me.btnNewDiscount, CType(resources.GetObject("btnNewDiscount.ShowHelp"), Boolean))
        '
        'BarManager2
        '
        Me.BarManager2.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {CType(resources.GetObject("BarManager2.Categories"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager2.Categories1"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager2.Categories2"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager2.Categories3"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager2.Categories4"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager2.Categories5"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager2.Categories6"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager2.Categories7"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager2.Categories8"), DevExpress.XtraBars.BarManagerCategory)})
        Me.BarManager2.Form = Me
        Me.BarManager2.MaxItemId = 73
        Me.BarManager2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbViewListRepos, Me.txtQuickSearchRepos, Me.cmbReportListRepos, Me.cmbFilterListRepos, Me.cmbDefaultListRepos})
        '
        'CheckDebitCard
        '
        resources.ApplyResources(Me.CheckDebitCard, "CheckDebitCard")
        Me.CheckDebitCard.Name = "CheckDebitCard"
        Me.CheckDebitCard.Properties.Caption = resources.GetString("CheckDebitCard.Properties.Caption")
        Me.CheckDebitCard.Properties.ValueChecked = 1
        Me.CheckDebitCard.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.CheckDebitCard, CType(resources.GetObject("CheckDebitCard.ShowHelp"), Boolean))
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckDebitCard)
        Me.GroupBox1.Controls.Add(Me.CheckCreditCard)
        Me.GroupBox1.Controls.Add(Me.CheckPaypal)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'CheckCreditCard
        '
        resources.ApplyResources(Me.CheckCreditCard, "CheckCreditCard")
        Me.CheckCreditCard.Name = "CheckCreditCard"
        Me.CheckCreditCard.Properties.Caption = resources.GetString("CheckCreditCard.Properties.Caption")
        Me.CheckCreditCard.Properties.ValueChecked = 1
        Me.CheckCreditCard.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.CheckCreditCard, CType(resources.GetObject("CheckCreditCard.ShowHelp"), Boolean))
        '
        'CheckPaypal
        '
        resources.ApplyResources(Me.CheckPaypal, "CheckPaypal")
        Me.CheckPaypal.Name = "CheckPaypal"
        Me.CheckPaypal.Properties.Caption = resources.GetString("CheckPaypal.Properties.Caption")
        Me.CheckPaypal.Properties.ValueChecked = 1
        Me.CheckPaypal.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.CheckPaypal, CType(resources.GetObject("CheckPaypal.ShowHelp"), Boolean))
        '
        'cmbDiscountAction
        '
        Me.cmbDiscountAction.AllowDrop = True
        resources.ApplyResources(Me.cmbDiscountAction, "cmbDiscountAction")
        Me.cmbDiscountAction.Name = "cmbDiscountAction"
        Me.cmbDiscountAction.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbDiscountAction.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbDiscountAction.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 87, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 98, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbDiscountAction.Properties.DisplayMember = "DisplayMember"
        Me.cmbDiscountAction.Properties.NullText = resources.GetString("cmbDiscountAction.Properties.NullText")
        Me.cmbDiscountAction.Properties.ValueMember = "Value"
        '
        'LabelControl28
        '
        resources.ApplyResources(Me.LabelControl28, "LabelControl28")
        Me.LabelControl28.Name = "LabelControl28"
        '
        'txtActivationValue2
        '
        resources.ApplyResources(Me.txtActivationValue2, "txtActivationValue2")
        Me.txtActivationValue2.Name = "txtActivationValue2"
        Me.txtActivationValue2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtActivationValue2.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtActivationValue2, CType(resources.GetObject("txtActivationValue2.ShowHelp"), Boolean))
        '
        'cmbActivation_Type
        '
        resources.ApplyResources(Me.cmbActivation_Type, "cmbActivation_Type")
        Me.cmbActivation_Type.Name = "cmbActivation_Type"
        Me.cmbActivation_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbActivation_Type.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbActivation_Type.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 87, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 98, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbActivation_Type.Properties.DisplayMember = "DisplayMember"
        Me.cmbActivation_Type.Properties.NullText = resources.GetString("cmbActivation_Type.Properties.NullText")
        Me.cmbActivation_Type.Properties.ValueMember = "Value"
        '
        'LabelControl8
        '
        resources.ApplyResources(Me.LabelControl8, "LabelControl8")
        Me.LabelControl8.Name = "LabelControl8"
        '
        'LabelControl29
        '
        resources.ApplyResources(Me.LabelControl29, "LabelControl29")
        Me.LabelControl29.Name = "LabelControl29"
        '
        'txtTVODFreeCredits
        '
        resources.ApplyResources(Me.txtTVODFreeCredits, "txtTVODFreeCredits")
        Me.txtTVODFreeCredits.Name = "txtTVODFreeCredits"
        Me.txtTVODFreeCredits.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtTVODFreeCredits.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtTVODFreeCredits, CType(resources.GetObject("txtTVODFreeCredits.ShowHelp"), Boolean))
        '
        'LabelControl30
        '
        resources.ApplyResources(Me.LabelControl30, "LabelControl30")
        Me.LabelControl30.Name = "LabelControl30"
        '
        'chkAllCust
        '
        resources.ApplyResources(Me.chkAllCust, "chkAllCust")
        Me.chkAllCust.Name = "chkAllCust"
        Me.chkAllCust.Properties.Caption = resources.GetString("chkAllCust.Properties.Caption")
        Me.chkAllCust.Properties.ValueChecked = 1
        Me.chkAllCust.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.chkAllCust, CType(resources.GetObject("chkAllCust.ShowHelp"), Boolean))
        '
        'frmActivationCode
        '
        resources.ApplyResources(Me, "$this")
        Me.BarManager1 = Me.BarManager2
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.HelpButton = False
        Me.HelpProvider1.SetHelpKeyword(Me, resources.GetString("$this.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me, CType(resources.GetObject("$this.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me, resources.GetString("$this.HelpString"))
        Me.Name = "frmActivationCode"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        Me.TabParameters.PerformLayout()
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabChart.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductsID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbValidType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNextDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValidValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtyToGenerate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbValidTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbValidTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrefix.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkWaranty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAuto_Stop_at_Next_Reconduction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBanner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtDescEN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescFR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFree_Upgrade_Allowed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFooter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCampaign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSearch.ResumeLayout(False)
        CType(Me.GroupSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupSearch.ResumeLayout(False)
        Me.GroupSearch.PerformLayout()
        CType(Me.cmbGroupSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomersIdSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOnlyUsed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCampaignSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivationCodeSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivationId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabResult2.ResumeLayout(False)
        CType(Me.GridActivationCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewActivationCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivationCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCombinedAction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValidityMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrpCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpCustomers.ResumeLayout(False)
        Me.GrpCustomers.PerformLayout()
        CType(Me.txtValidityToCustomersChange.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValidityToCustomersChange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivationCodeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreationDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreationDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNextAboType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckDebitCard.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CheckCreditCard.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckPaypal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDiscountAction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivationValue2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbActivation_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTVODFreeCredits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAllCust.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim KeyDataSet As String = "BizzLib.dsMarketting" 'The Dataset used 
    Dim CurrentCodeType As String
    Dim param As PlushBuziness.clsSingleton
    ' Public WithEvents cmbLeverancier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    ' free_upgrade_allowed, footer, campaign, combined_action
    Dim _activationId As Integer
    Dim _activationCode As String
    Dim _activation_type As Integer
    Dim _activation_value As String
    Dim _campaignId As String
    Dim _activationGroupId As Integer
    Dim _activationPack As Integer
    Dim _activationCodeCreationDate As String
    Dim _activationCodeValidtoDate As String
    Dim _activationProductsId As Integer
    Dim _validityMonth As Integer
    Dim _validityType As Integer
    Dim _validityValue As Integer
    Dim _activationWaranty As Integer
    Dim _customersId As Integer
    Dim _activationDate As String
    Dim _commentActivation As String
    Dim _aboDvdCredit As Integer
    Dim _aboDVDRemain As Integer
    Dim _nextDiscount As Integer
    Dim _NextaboType As String
    Dim _tvod_free As Integer
    Dim _credit0autoReconduct As Integer
    Dim _aboAutoStopNextReconduction As Boolean
    Dim _bannerActivation As String
    Dim _activationTextFr As String
    Dim _activationTextNl As String
    Dim _activationTextEn As String
    Dim _freeUpgradeAllowed As Integer
    Dim _footerActivation As String
    Dim _campaignActivation As String
    Dim _combinedAction As String
    Dim _validityToChangeCustomers As String
    Dim _paypal As Integer
    Dim _creditcard As Integer
    Dim _debitcard As Integer
    Dim _discount_action As String
    Dim _all_cust As Integer

    Dim _enableField As Boolean

    Enum StepForm
        EDIT
        [NEW]
        SAVE
        CANCEL
        INIT
        LOAD
    End Enum


    Private Sub ChangeStep(ByVal stepCurrent As StepForm)
        Select Case stepCurrent
            Case StepForm.CANCEL
                btnEditActivation.Enabled = True
                btnSaveDiscount.Enabled = False
                btnGenerate.Enabled = False
                btnNew.Enabled = True
                btnCancel.Enabled = False

                EnableField(False)
                btnGenerate.Enabled = False

                tabSearch.PageVisible = True
                tabResult2.PageVisible = True

            Case StepForm.EDIT
                btnEditActivation.Enabled = False
                btnSaveDiscount.Enabled = True
                btnNew.Enabled = False
                btnCancel.Enabled = True
                btnGenerate.Enabled = True

                EnableField(True)
                btnGenerate.Enabled = True
                TabParameters.PageVisible = True
                tabResult2.PageVisible = False

            Case StepForm.INIT
                btnEditActivation.Enabled = False
                btnSaveDiscount.Enabled = False
                btnNew.Enabled = True
                btnCancel.Enabled = False
                btnGenerate.Enabled = False

                EnableField(False)
                btnGenerate.Enabled = False
                tabResult2.PageVisible = False
                tabSearch.PageVisible = True
                TabParameters.PageVisible = False
                TabControl1.SelectedTabPage = tabSearch


            Case StepForm.[NEW]
                btnEditActivation.Enabled = False
                btnSaveDiscount.Enabled = True
                btnNew.Enabled = False
                btnCancel.Enabled = True
                btnGenerate.Enabled = True

                btnGenerate.Enabled = True
                EnableField(True)
                tabResult2.PageVisible = False
                TabParameters.PageVisible = True
                TabControl1.SelectedTabPage = TabParameters



            Case StepForm.SAVE
                btnEditActivation.Enabled = True
                btnSaveDiscount.Enabled = False
                btnNew.Enabled = True
                btnCancel.Enabled = False
                btnGenerate.Enabled = False

                btnGenerate.Enabled = False
                EnableField(False)
                TabParameters.PageVisible = True
                tabResult2.PageVisible = True

            Case StepForm.LOAD
                btnEditActivation.Enabled = True
                btnSaveDiscount.Enabled = False
                btnNew.Enabled = True
                btnCancel.Enabled = False
                btnGenerate.Enabled = False

                EnableField(False)
                btnGenerate.Enabled = False
                TabParameters.PageVisible = True
                TabControl1.SelectedTabPage = TabParameters

        End Select
    End Sub

    Public Sub this_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        GridViewActivationCode.OptionsView.ColumnAutoWidth = False
        GridViewActivationCode.OptionsBehavior.Editable = False

        TabControl1.SelectedTabPage = tabSearch
        ' Misc_Bar.Visible = True
        TabParameters.PageVisible = False
        TabAnalyse.PageVisible = False ' not used
        TabChart.PageVisible = False ' not used
        TabResult.PageVisible = False ' not used


        Dim menuStrip As New PlushBuziness.contextMenu()
        GridActivationCode.ContextMenuStrip = menuStrip
        LoadBKComboSet()
        ChangeStep(StepForm.INIT)


    End Sub

    Public Sub LoadBKComboSet()
        cmbActivation_Type.Properties.DataSource = GetListCmb(PlushData.clsActivationCode.GetDiscountType(), "discount_explained", "discount_type")
        cmbGroup.Properties.DataSource = GetListCmb(PlushData.clsActivationCode.GetActivationGroup, "activation_group_name", "activation_group_id") 'GetCombo(DvdPostData.clsActivationCode.GetActivationGroup)
        cmbProductsID.Properties.DataSource = GetListCmb(PlushData.clsActivationCode.GetProducts(PlushData.clsActivationCode.productsTypeAbo), "products_title", "products_id") 'GetCombo(DvdPostData.clsActivationCode.GetProducts(DvdPostData.clsActivationCode.productsTypeAbo))
        cmbValidType.Properties.DataSource = GetListCmb(PlushData.clsActivationCode.GetActivationValidityType, "validity_type_explained", "validity_type_id") 'GetCombo(DvdPostData.clsActivationCode.GetActivationValidityType)
        cmbNextDiscount.Properties.DataSource = GetListCmb(PlushData.clsActivationCode.GetDiscountCode(), "discount_code", "discount_code_id") 'GetCombo(DvdPostData.clsActivationCode.GetDiscountCode)
        cmbGroupSearch.Properties.DataSource = GetListCmb(PlushData.clsActivationCode.GetActivationGroup(), "activation_group_name", "activation_group_id")
        cmbCombinedAction.Properties.DataSource = GetListCombinedAction()
        cmbNextAboType.Properties.DataSource = GetListCmb(PlushData.clsActivationCode.GetProducts(PlushData.clsActivationCode.productsTypeAbo), "products_title", "products_id")
        loadDiscountAction()

    End Sub

    Private Function GetListCombinedAction() As List(Of PlushBuziness.clsKeyCombo)
        Dim listCmb As New List(Of PlushBuziness.clsKeyCombo)
        listCmb.Add(New PlushBuziness.clsKeyCombo("YES", 0))
        listCmb.Add(New PlushBuziness.clsKeyCombo("NO", 1))
        Return listCmb
    End Function
    Private Function GetListCmb(ByVal sql As String, ByVal displayMember As String, ByVal value As String) As List(Of PlushBuziness.clsKeyCombo)
        Dim listCmb As New List(Of PlushBuziness.clsKeyCombo)
        Dim dt As DataTable
        Dim dr As DataRow

        dt = PlushData.clsConnection.FillDataSet(sql)

        listCmb.Add(New PlushBuziness.clsKeyCombo("", 0))
        For Each dr In dt.Rows
            listCmb.Add(New PlushBuziness.clsKeyCombo(dr(displayMember), dr(value)))
        Next

        Return listCmb
    End Function


    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim number As Integer
        Dim ok As Boolean
        number = txtQtyToGenerate.EditValue
        If txtQtyToGenerate.EditValue <= 0 Or (txtPrefix.Text & "" = "" And txtPrefix.Text.Length < 4) Then
            MsgBox("Specify a Nbr of code to generate " _
                   & " and specify a Prefix with 4 characters ", MsgBoxStyle.Critical)
        Else
            ok = CheckTextBox()
            If ok Then
                loadVarUpdateInsert()
                generateActivationCode(number)
                ChangeStep(StepForm.SAVE)
            End If

        End If
        'If txtPrefix.Text & "" = "" And txtPrefix.Text.Length < 4 Then
        '    MsgBox("Please specify a Prefix with 4 characters", MsgBoxStyle.Critical)

        '    Exit Sub
        'End If


    End Sub


    Private Function CheckTextBox() As Boolean

        If cmbGroup.EditValue & "" = "" Then
            MsgBox("Select a Group", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If

        If cmbProductsID.EditValue & "" = "" Then
            MsgBox("Please Select a Product", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If
        If cmbValidType.EditValue & "" = "" Then
            MsgBox("Please Select a Validity Type", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If
        If txtValidValue.EditValue <= 0 Then
            MsgBox("Please select a validity value greater than 0", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If
        'If txtDVDCredit.EditValue <= 0 Then
        '    MsgBox("Please select a DVD Credit value greater than 0", MsgBoxStyle.Critical)
        '    Return False
        '    Exit Function
        'End If
        If cmbValidTo.EditValue & "" = "" Then
            MsgBox("Please select a Valid TO Date", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If

        If txtCampaign.EditValue = "" Then
            MsgBox("Please specify a compaign name ", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If

        Return True

    End Function


    Private Sub loadDiscountAction()
        Dim listCmb As New List(Of PlushBuziness.clsKeyCombo)
        Dim lstdiscountaction As List(Of PlushBuziness.clsKeyComboEnum)
        Dim sql As String
        Dim dr As DataRow

        sql = PlushData.clsActivationCode.GetEnumMysqlDiscountAction()
        lstdiscountaction = PlushBuziness.ClsCombo.GetListEnum(sql)

        listCmb.Add(New PlushBuziness.clsKeyCombo("", 0))
        For i As Integer = 0 To lstdiscountaction.Count - 1
            listCmb.Add(New PlushBuziness.clsKeyCombo(lstdiscountaction(i).Value, i + 1))
        Next

        'cmbDiscountAction.Properties.ValueMember = "Value"
        'cmbDiscountAction.Properties.DisplayMember = "DisplayMember"
        cmbDiscountAction.Properties.DataSource = listCmb
        cmbDiscountAction.SelectedText = ""
    End Sub

    Private Sub generateActivationCode(ByVal number As Integer)
        Dim tabCode As ArrayList = createData(number)
        Dim count As Integer = 0
        Dim el As String
        Dim fieldInsert As String = ""
        'Dim strline As String
        Dim sql As String


        PlushData.clsConnection.CreateTransaction(True)

        For Each el In tabCode
            count += 1

            sql = PlushData.clsActivationCode.insertActivationCode(el, _activation_type, _activation_value, _activationGroupId, 0, _
                                                                            _activationCodeValidtoDate, _activationProductsId, _
                                                                            _validityType, _validityValue, _
                                                                            _activationWaranty, _commentActivation, _
                                                                            _nextDiscount, _tvod_free, _
                                                                            _aboAutoStopNextReconduction, _NextaboType, _bannerActivation, _
                                                                            _activationTextFr, _activationTextNl, _
                                                                            _activationTextEn, _freeUpgradeAllowed, _
                                                                            _footerActivation, _campaignActivation, _
                                                                            _combinedAction, _paypal, _creditcard, _debitcard, _discount_action, _all_cust)
            PlushData.clsConnection.ExecuteNonQuery(sql)

        Next
        PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Discount, count)


        MsgBox(count.ToString & " activation_code created")






    End Sub
    Public Function GenerateCode() As String
        Dim _Code As String

        _Code = Guid.NewGuid().ToString().GetHashCode.ToString("X")

        _Code = Replace(_Code, "0", "-")
        _Code = Replace(_Code, "O", "-")
        _Code = txtPrefix.Text.ToUpper + _Code
        _Code.ToUpper()

        Return _Code.Substring(0, _Code.Length - 2)
    End Function

    Public Function getActivationCode() As DataView
        Dim dt As DataTable
        dt = PlushData.clsConnection.FillDataSet(PlushData.clsActivationCode.GetActivationSearch(, , txtPrefix.Text)) 'GetActivationWithPrefixe(txtPrefix.Text))
        Dim view As New DataView(dt, "", "activation_code", DataViewRowState.CurrentRows)
        Return view
    End Function


    Public Function createData(ByVal maxNumber As Integer) As ArrayList

        Dim activationCode As String
        Dim tabActivationCode As New ArrayList
        Dim viewExist As DataView = getActivationCode()

        Dim dico As New System.Collections.Generic.Dictionary(Of String, String)
        For Each data As DataRowView In viewExist
            dico.Add(data.Row("activation_code").ToUpper(), "")
        Next

        Dim i As Integer

        For i = 0 To maxNumber - 1
            activationCode = GenerateCode()

            While (dico.ContainsKey((activationCode).ToUpper()) = True)
                activationCode = GenerateCode()
            End While

            tabActivationCode.Add(activationCode)
            dico.Add(activationCode.ToUpper(), "")
        Next

        Return tabActivationCode
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        search()

        TabParameters.PageVisible = False
        tabResult2.PageVisible = True
        TabControl1.SelectedTabPage = tabResult2
    End Sub

    Public Sub search()
        Dim activation_id As String
        Dim activation_code As String
        Dim activationUse As Boolean = False
        Dim dateTo As String
        Dim dateFrom As String
        Dim groupId As String
        Dim campaign As String
        Dim dt As DataTable
        Dim sqlSearch As String
        Dim customers_id As Integer

        Dim param As PlushBuziness.clsSingleton
        param = PlushBuziness.clsSingleton.Instance()



        If param.Activation_Discount_id = Nothing Then
            activation_id = txtActivationId.Text.Trim
        Else
            activation_id = param.Activation_Discount_id
            param.Activation_Discount_id = Nothing
        End If
        'activation_id = txtActivationId.Text.Trim
        activation_code = txtActivationCodeSearch.Text.Trim
        dateFrom = txtFromDate.EditValue
        dateTo = txtToDate.EditValue
        campaign = txtCampaignSearch.Text.Trim
        groupId = cmbGroupSearch.EditValue
        customers_id = txtCustomersIdSearch.EditValue

        If groupId = "0" Then
            groupId = String.Empty
        End If

        If chkOnlyUsed.Checked = True Then
            activationUse = True
        End If

        sqlSearch = PlushData.clsActivationCode.GetActivationSearch(customers_id, activation_id, activation_code, activationUse, campaign, dateFrom, dateTo, groupId)
        dt = PlushData.clsConnection.FillDataSet(sqlSearch)
        GridActivationCode.DataSource = dt

        btnXls.Visible = dt.Rows.Count > 0


    End Sub


    Private Function GetCombo(ByVal sql As String) As DataTable
        Dim dt As DataTable
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt
    End Function



    Private Sub loadActivationExpiration()
        Dim dt As DataTable
        Dim sqlActivationExp As String = PlushData.clsActivationCode.GetActivationExpiration()
        dt = PlushData.clsConnection.FillDataSet(sqlActivationExp)
        GridActivationCode.DataSource = dt
        TabControl1.SelectedTabPage = tabResult2
    End Sub


    Private Sub btnEx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEx.Click
        loadActivationExpiration()
        AddHandler GridViewActivationCode.RowStyle, AddressOf GridViewActivationCode_RowStyle
    End Sub

    'change color of the row by gauthier
    Public Sub GridViewActivationCode_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs)
        Dim View As DevExpress.XtraGrid.Views.Grid.GridView = sender
        If (e.RowHandle >= 0) Then
            Dim validitytoString As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("activation_code_validto_date")).ToString
            If validitytoString <> "" Then
                Dim validityToDate As Date = CType(validitytoString, Date)
                If validityToDate >= Date.Now Then
                    e.Appearance.BackColor = Drawing.Color.LightGreen
                    e.Appearance.BackColor2 = Drawing.Color.SeaShell
                End If

                If validityToDate < Date.Now Then
                    e.Appearance.BackColor = Drawing.Color.LightSalmon
                    e.Appearance.BackColor2 = Drawing.Color.SeaShell
                End If

            End If
        End If
    End Sub
    Private Sub initForm()
        Dim blank As String = String.Empty
        txtActivationCodeID.EditValue = blank
        txtCustomerId.EditValue = blank
        txtActivationCode.EditValue = blank
        cmbActivation_Type.EditValue = blank
        txtActivationValue2.EditValue = blank
        cmbGroup.EditValue = blank
        cmbValidTo.EditValue = blank
        cmbProductsID.EditValue = blank
        txtValidityMonth.EditValue = blank
        cmbValidType.EditValue = blank
        txtValidValue.EditValue = blank
        'txtDVDCredit.EditValue = blank
        'txtDVDRemain.EditValue = blank
        cmbNextDiscount.EditValue = 0
        txtFooter.EditValue = blank
        txtComment.EditValue = blank
        txtBanner.EditValue = blank
        txtDescFR.EditValue = blank
        txtDescNL.EditValue = blank
        txtDescNL.EditValue = blank
        txtDescEN.EditValue = blank
        txtCampaign.EditValue = blank
        chkWaranty.EditValue = 0
        chkAuto_Stop_at_Next_Reconduction.EditValue = 0
        cmbCombinedAction.EditValue = 0
        'CheckCombinetActi.EditValue = clsMarketing.clsActivationCode.GetCombinedAction(dr)
        chkFree_Upgrade_Allowed.EditValue = 0

        '  txtValidityToCustomersChange.EditValue = blank
        txtCreationDate.EditValue = blank
        cmbNextAboType.EditValue = 0
        CheckPaypal.Checked = False
        CheckCreditCard.Checked = False
        CheckDebitCard.Checked = False
        chkAllCust.Checked = False
        cmbDiscountAction.EditValue = Nothing

    End Sub


    Private Sub loadTextBoxInfo(ByVal dr As DataRow)
        txtActivationCodeID.EditValue = clsMarketing.clsActivationCode.GetActivationId(dr)
        txtCustomerId.EditValue = clsMarketing.clsActivationCode.GetCustomersId(dr)
        txtActivationCode.EditValue = clsMarketing.clsActivationCode.GetActivationCode(dr)
        cmbActivation_Type.EditValue = clsMarketing.clsActivationCode.getActivationType(dr)
        txtActivationValue2.EditValue = clsMarketing.clsActivationCode.getActivationValue(dr)
        cmbGroup.EditValue = clsMarketing.clsActivationCode.GetActivationGroup(dr)
        cmbValidTo.EditValue = clsMarketing.clsActivationCode.GetActivationCodeValidtoDate(dr)
        cmbProductsID.EditValue = clsMarketing.clsActivationCode.GetActivationProductsId(dr)
        txtValidityMonth.EditValue = clsMarketing.clsActivationCode.GetValidityMonth(dr)
        cmbValidType.EditValue = clsMarketing.clsActivationCode.GetValidityType(dr)
        txtValidValue.EditValue = clsMarketing.clsActivationCode.GetValidityValue(dr)
        'txtDVDCredit.EditValue = clsMarketing.clsActivationCode.GetAboDvdCredit(dr)
        'txtDVDRemain.EditValue = clsMarketing.clsActivationCode.GetAboDvdRemain(dr)
        cmbNextDiscount.EditValue = clsMarketing.clsActivationCode.GetNextDiscount(dr)
        txtFooter.EditValue = clsMarketing.clsActivationCode.GetFooter(dr)
        txtComment.EditValue = clsMarketing.clsActivationCode.GetComment(dr)
        txtBanner.EditValue = clsMarketing.clsActivationCode.GetBanner(dr)
        txtDescFR.EditValue = clsMarketing.clsActivationCode.getActivationTextFr(dr)
        txtDescNL.EditValue = clsMarketing.clsActivationCode.getActivationTextNl(dr)
        txtDescNL.EditValue = clsMarketing.clsActivationCode.getActivationTextNl(dr)
        txtDescEN.EditValue = clsMarketing.clsActivationCode.getActivationTextEn(dr)
        txtCampaign.EditValue = clsMarketing.clsActivationCode.GetCampaign(dr)
        chkWaranty.EditValue = clsMarketing.clsActivationCode.GetActivationWaranty(dr)
        chkAuto_Stop_at_Next_Reconduction.EditValue = clsMarketing.clsActivationCode.GetAboAutoStopNextReconduction(dr)
        cmbCombinedAction.EditValue = clsMarketing.clsActivationCode.GetCombinedAction(dr)
        'CheckCombinetActi.EditValue = clsMarketing.clsActivationCode.GetCombinedAction(dr)
        chkFree_Upgrade_Allowed.EditValue = clsMarketing.clsActivationCode.GetFreeUpgradeAllowed(dr)

        txtValidityToCustomersChange.EditValue = clsMarketing.clsActivationCode.GetActivationCodeValidtoDate(dr)
        txtCreationDate.EditValue = clsMarketing.clsActivationCode.GetActivationCodeCreationDate(dr)
        cmbNextAboType.EditValue = clsMarketing.clsDiscountCode.GetNextAboType(dr) 'dr("next_abo_type")

        CheckPaypal.EditValue = clsMarketing.clsDiscountCode.GetPayPal(dr)
        CheckCreditCard.EditValue = clsMarketing.clsDiscountCode.GetCrediCard(dr)
        CheckDebitCard.EditValue = clsMarketing.clsDiscountCode.GetDebitCard(dr)
        chkAllCust.EditValue = clsMarketing.clsDiscountCode.GetAllCust(dr)
        cmbDiscountAction.EditValue = clsMarketing.clsDiscountCode.GetDiscountAction(dr)

    End Sub

    Private Sub loadVarUpdateInsert()

        If txtActivationCodeID.EditValue IsNot String.Empty Then
            _activationId = txtActivationCodeID.EditValue
        End If
        _activationCode = txtActivationCode.EditValue
        _activation_type = cmbActivation_Type.EditValue
        _activation_value = txtActivationValue2.EditValue
        '_campaignId 
        _activationGroupId = cmbGroup.EditValue
        '_activationPack 
        _activationCodeCreationDate = txtCreationDate.EditValue
        _activationCodeValidtoDate = cmbValidTo.EditValue
        _activationProductsId = cmbProductsID.EditValue
        _validityMonth = txtValidityMonth.EditValue
        _validityType = cmbValidType.EditValue
        _validityValue = txtValidValue.EditValue
        _activationWaranty = chkWaranty.Checked
        '_activationDate'
        _commentActivation = txtComment.EditValue
        '_aboDvdCredit = txtDVDCredit.EditValue
        '_aboDVDRemain = txtDVDRemain.EditValue
        _nextDiscount = cmbNextDiscount.EditValue
        _tvod_free = txtTVODFreeCredits.EditValue
        '_credit0autoReconduct 
        _aboAutoStopNextReconduction = chkAuto_Stop_at_Next_Reconduction.Checked
        _bannerActivation = txtBanner.EditValue
        _activationTextFr = txtDescFR.EditValue
        _activationTextNl = txtDescNL.EditValue
        _activationTextEn = txtDescEN.EditValue
        _freeUpgradeAllowed = chkFree_Upgrade_Allowed.Checked
        _footerActivation = txtFooter.EditValue
        _campaignActivation = txtCampaign.EditValue
        _combinedAction = cmbCombinedAction.EditValue

        _validityToChangeCustomers = txtValidityToCustomersChange.EditValue
        _customersId = txtCustomerId.EditValue

        _NextaboType = cmbNextAboType.EditValue

        _paypal = CheckPaypal.EditValue
        _creditcard = CheckCreditCard.EditValue
        _debitcard = CheckDebitCard.EditValue
        _all_cust = chkAllCust.EditValue
        _discount_action = cmbDiscountAction.EditValue

    End Sub


    Private Sub loadInfoActivation(ByVal activation_id As Integer)
        Dim dt As DataTable
        Dim sql As String

        sql = PlushData.clsActivationCode.GetActivationSearch(, activation_id)
        dt = PlushData.clsConnection.FillDataSet(sql)
        loadTextBoxInfo(dt.Rows(0))
    End Sub

    Private Sub GridActivationCode_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridActivationCode.DoubleClick
        loadInfo()
        ChangeStep(StepForm.LOAD)
    End Sub

    Private Sub loadInfo()
        Dim activation_id As Integer
        If GridViewActivationCode.RowCount > 0 Then
            activation_id = GridViewActivationCode.GetDataRow(GridViewActivationCode.FocusedRowHandle())("activation_id")
            loadInfoActivation(activation_id)
            TabControl1.SelectedTabPage = TabParameters
        End If
    End Sub

    Private Sub updateActivationByCust()
        Dim sql As String
        Dim count As Integer
        loadVarUpdateInsert()
        Try


            PlushData.clsConnection.CreateTransaction(False)
            sql = PlushData.clsActivationCode.updateActivationBYCust(_customersId, _activationId, _validityToChangeCustomers)
            count = PlushData.clsConnection.ExecuteNonQuery(sql)

            If MsgBox("you go to update " & count & " activations codes ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                PlushData.clsConnection.CommitTransaction(True)
                ChangeStep(StepForm.SAVE)
            Else
                PlushData.clsConnection.CommitTransaction(False)
                ChangeStep(StepForm.CANCEL)
            End If
        Catch ex As Exception
            PlushData.clsConnection.CommitTransaction(False)
            PlushBuziness.clsMsgError.MsgBox(ex.Message)
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Discount, ex, _customersId)
        End Try
    End Sub



    Private Sub btnSaveBycustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveBycustomer.Click
        updateActivationByCust()
    End Sub

    Private Sub updateActivation()
        Dim sql As String
        Dim activationCodeCondition As String
        Dim count As Integer

        Try

            loadVarUpdateInsert()
            activationCodeCondition = _activationCode.Substring(0, 3)
            PlushData.clsConnection.CreateTransaction(False)
            sql = PlushData.clsActivationCode.updateActivation(_activationGroupId, _activation_type, _activation_value, 0, _
                                                                                 _activationCodeValidtoDate, _activationProductsId, _
                                                                                 _validityType, _validityValue, _
                                                                                 _activationWaranty, _commentActivation, _
                                                                                 _nextDiscount, _tvod_free, _
                                                                                 _aboAutoStopNextReconduction, _bannerActivation, _
                                                                                 _activationTextFr, _activationTextNl, _
                                                                                 _activationTextEn, _freeUpgradeAllowed, _
                                                                                 _footerActivation, _campaignActivation, _
                                                                                 _combinedAction, _activationCodeCreationDate, activationCodeCondition, _
                                                                                 _NextaboType, _paypal, _creditcard, _debitcard, _discount_action, _all_cust)

            count = PlushData.clsConnection.ExecuteNonQuery(sql)
            If MsgBox("you go to update " & count & " activations codes ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                PlushData.clsConnection.CommitTransaction(True)
                ChangeStep(StepForm.SAVE)
            Else
                ChangeStep(StepForm.CANCEL)
                PlushData.clsConnection.CommitTransaction(False)
            End If


        Catch ex As Exception
            PlushData.clsConnection.CommitTransaction(False)
            PlushBuziness.clsMsgError.MsgBox(ex.Message)
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Discount, ex)
        End Try



    End Sub

    Private Function EnableField(ByVal ok As Boolean) As Boolean
        Dim enable As Boolean
        enable = ok


        cmbGroup.Enabled = enable
        cmbValidTo.Enabled = enable
        cmbProductsID.Enabled = enable
        txtValidityMonth.Enabled = enable
        cmbValidType.Enabled = enable
        txtValidValue.Enabled = enable
        cmbActivation_Type.Enabled = enable
        txtActivationValue2.Enabled = enable
        cmbNextDiscount.Enabled = enable
        txtFooter.Enabled = enable
        txtComment.Enabled = enable
        txtBanner.Enabled = enable
        txtDescFR.Enabled = enable
        txtDescNL.Enabled = enable
        txtDescNL.Enabled = enable
        txtDescEN.Enabled = enable
        txtCampaign.Enabled = enable
        chkWaranty.Enabled = enable
        chkAuto_Stop_at_Next_Reconduction.Enabled = enable
        cmbCombinedAction.Enabled = enable
        chkFree_Upgrade_Allowed.Enabled = enable

        txtTVODFreeCredits.Enabled = enable

        txtValidityToCustomersChange.Enabled = enable
        txtPrefix.Enabled = enable

        txtQtyToGenerate.Enabled = enable
        cmbNextAboType.Enabled = enable

        GroupBox1.Enabled = enable
        CheckPaypal.Enabled = enable
        CheckCreditCard.Enabled = enable
        CheckDebitCard.Enabled = enable
        chkAllCust.Enabled = enable

        cmbDiscountAction.Enabled = enable
        Return ok
    End Function

    Private Sub btnEditActivation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ChangeStep(StepForm.EDIT)

    End Sub

    'Public Sub enablingField() '
    '    If _enableField Then
    '        _enableField = EnableField(False)
    '        loadInfo()
    '    Else
    '        _enableField = EnableField(True)
    '    End If
    'End Sub

    Private Sub btnNewActivation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewActivation.Click

        initForm()
        ChangeStep(StepForm.[NEW])
    End Sub

    Private Sub btnEditDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditActivation.Click
        ChangeStep(StepForm.EDIT)
    End Sub

    Private Sub btnSaveDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDiscount.Click
        Dim ok As Boolean

        ok = CheckTextBox()
        If ok Then
            '  loadVarUpdateInsert()
            updateActivation()
        End If
    End Sub


    Private Sub btnNewDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewDiscount.Click
        btnNewActivation_Click(Nothing, Nothing)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ChangeStep(StepForm.CANCEL)
    End Sub

    Private Sub btnXls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXls.Click
        PlushBuziness.clsExport.ExportXls(GridViewActivationCode)
    End Sub

End Class



