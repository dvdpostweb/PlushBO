Imports System.Windows.Forms.Application
Public Class xxxfrmListingOUT
    Inherits BizzLib.frmGeneral_Browse

    Dim WithEvents _ExportExcel As DevExpress.XtraBars.BarButtonItem = MainBtns_btnExcel
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
    Friend WithEvents SFDExportExcel As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnLoadOrders As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMaxDVDPerGroup As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnClearDVDAssigned As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAssignDVDToOrders As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEtrangerNL As System.Windows.Forms.TextBox
    Friend WithEvents txtEtrangerFR As System.Windows.Forms.TextBox
    Friend WithEvents LblBelgiqueFR As System.Windows.Forms.Label
    Friend WithEvents LblBelgiqueNL As System.Windows.Forms.Label
    Friend WithEvents lblEtrangerNL As System.Windows.Forms.Label
    Friend WithEvents LblEtrangerFR As System.Windows.Forms.Label
    Friend WithEvents txtBelgiqueNL As System.Windows.Forms.TextBox
    Friend WithEvents txtBelgiqueFR As System.Windows.Forms.TextBox
    Friend WithEvents lblPickGroup As System.Windows.Forms.Label
    Friend WithEvents txtBelgiqueNLQtyClient As System.Windows.Forms.TextBox
    Friend WithEvents txtBelgiqueFRQtyClient As System.Windows.Forms.TextBox
    Friend WithEvents txtEtrangerNLQtyClient As System.Windows.Forms.TextBox
    Friend WithEvents txtEtrangerFrQtyClient As System.Windows.Forms.TextBox
    Friend WithEvents Lblnb_cust As System.Windows.Forms.Label
    Friend WithEvents TabResultLstOut As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridListingOut As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewListingOut As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrders_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomers_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldelivery_country As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducts_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvd_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBoxId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpibox_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLanguage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpickgroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldatepurchased As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colorders_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpick_boxid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabParams As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnSetPickingGroup As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xxxfrmListingOUT))
        Me.btnLoadOrders = New DevExpress.XtraEditors.SimpleButton
        Me.txtMaxDVDPerGroup = New DevExpress.XtraEditors.SpinEdit
        Me.btnClearDVDAssigned = New DevExpress.XtraEditors.SimpleButton
        Me.btnAssignDVDToOrders = New DevExpress.XtraEditors.SimpleButton
        Me.btnSetPickingGroup = New DevExpress.XtraEditors.SimpleButton
        Me.SFDExportExcel = New System.Windows.Forms.SaveFileDialog
        Me.LblEtrangerFR = New System.Windows.Forms.Label
        Me.lblEtrangerNL = New System.Windows.Forms.Label
        Me.LblBelgiqueNL = New System.Windows.Forms.Label
        Me.LblBelgiqueFR = New System.Windows.Forms.Label
        Me.txtEtrangerFR = New System.Windows.Forms.TextBox
        Me.txtEtrangerNL = New System.Windows.Forms.TextBox
        Me.txtBelgiqueFR = New System.Windows.Forms.TextBox
        Me.txtBelgiqueNL = New System.Windows.Forms.TextBox
        Me.lblPickGroup = New System.Windows.Forms.Label
        Me.txtEtrangerFrQtyClient = New System.Windows.Forms.TextBox
        Me.txtEtrangerNLQtyClient = New System.Windows.Forms.TextBox
        Me.txtBelgiqueFRQtyClient = New System.Windows.Forms.TextBox
        Me.txtBelgiqueNLQtyClient = New System.Windows.Forms.TextBox
        Me.Lblnb_cust = New System.Windows.Forms.Label
        Me.TabResultLstOut = New DevExpress.XtraTab.XtraTabPage
        Me.GridListingOut = New DevExpress.XtraGrid.GridControl
        Me.GridViewListingOut = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOrders_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCustomers_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldelivery_country = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProducts_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldvd_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBoxId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpibox_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLanguage = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpickgroup = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldatepurchased = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colorders_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpick_boxid = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tabParams = New DevExpress.XtraTab.XtraTabPage
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
        CType(Me.txtMaxDVDPerGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabResultLstOut.SuspendLayout()
        CType(Me.GridListingOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewListingOut, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabResultLstOut, Me.tabParams})
        Me.TabControl1.Controls.SetChildIndex(Me.tabParams, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabResultLstOut, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabChart, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabAnalyse, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabResult, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabParameters, 0)
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.Lblnb_cust)
        Me.TabParameters.Controls.Add(Me.txtBelgiqueNLQtyClient)
        Me.TabParameters.Controls.Add(Me.txtBelgiqueFRQtyClient)
        Me.TabParameters.Controls.Add(Me.txtEtrangerNLQtyClient)
        Me.TabParameters.Controls.Add(Me.txtEtrangerFrQtyClient)
        Me.TabParameters.Controls.Add(Me.lblPickGroup)
        Me.TabParameters.Controls.Add(Me.txtBelgiqueNL)
        Me.TabParameters.Controls.Add(Me.txtBelgiqueFR)
        Me.TabParameters.Controls.Add(Me.txtEtrangerNL)
        Me.TabParameters.Controls.Add(Me.txtEtrangerFR)
        Me.TabParameters.Controls.Add(Me.LblBelgiqueFR)
        Me.TabParameters.Controls.Add(Me.LblBelgiqueNL)
        Me.TabParameters.Controls.Add(Me.lblEtrangerNL)
        Me.TabParameters.Controls.Add(Me.LblEtrangerFR)
        Me.TabParameters.Controls.Add(Me.btnSetPickingGroup)
        Me.TabParameters.Controls.Add(Me.btnAssignDVDToOrders)
        Me.TabParameters.Controls.Add(Me.btnClearDVDAssigned)
        Me.TabParameters.Controls.Add(Me.txtMaxDVDPerGroup)
        Me.TabParameters.Controls.Add(Me.btnLoadOrders)
        resources.ApplyResources(Me.TabParameters, "TabParameters")
        '
        'TabResult
        '
        Me.TabResult.PageVisible = False
        resources.ApplyResources(Me.TabResult, "TabResult")
        '
        'TabAnalyse
        '
        Me.TabAnalyse.PageVisible = False
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
        Me.TabChart.PageVisible = False
        resources.ApplyResources(Me.TabChart, "TabChart")
        '
        'btnLoadOrders
        '
        resources.ApplyResources(Me.btnLoadOrders, "btnLoadOrders")
        Me.btnLoadOrders.Name = "btnLoadOrders"
        Me.HelpProvider1.SetShowHelp(Me.btnLoadOrders, CType(resources.GetObject("btnLoadOrders.ShowHelp"), Boolean))
        '
        'txtMaxDVDPerGroup
        '
        resources.ApplyResources(Me.txtMaxDVDPerGroup, "txtMaxDVDPerGroup")
        Me.txtMaxDVDPerGroup.Name = "txtMaxDVDPerGroup"
        Me.txtMaxDVDPerGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtMaxDVDPerGroup, CType(resources.GetObject("txtMaxDVDPerGroup.ShowHelp"), Boolean))
        '
        'btnClearDVDAssigned
        '
        resources.ApplyResources(Me.btnClearDVDAssigned, "btnClearDVDAssigned")
        Me.btnClearDVDAssigned.Name = "btnClearDVDAssigned"
        Me.HelpProvider1.SetShowHelp(Me.btnClearDVDAssigned, CType(resources.GetObject("btnClearDVDAssigned.ShowHelp"), Boolean))
        '
        'btnAssignDVDToOrders
        '
        resources.ApplyResources(Me.btnAssignDVDToOrders, "btnAssignDVDToOrders")
        Me.btnAssignDVDToOrders.Name = "btnAssignDVDToOrders"
        Me.HelpProvider1.SetShowHelp(Me.btnAssignDVDToOrders, CType(resources.GetObject("btnAssignDVDToOrders.ShowHelp"), Boolean))
        '
        'btnSetPickingGroup
        '
        resources.ApplyResources(Me.btnSetPickingGroup, "btnSetPickingGroup")
        Me.btnSetPickingGroup.Name = "btnSetPickingGroup"
        Me.HelpProvider1.SetShowHelp(Me.btnSetPickingGroup, CType(resources.GetObject("btnSetPickingGroup.ShowHelp"), Boolean))
        '
        'LblEtrangerFR
        '
        resources.ApplyResources(Me.LblEtrangerFR, "LblEtrangerFR")
        Me.LblEtrangerFR.Name = "LblEtrangerFR"
        '
        'lblEtrangerNL
        '
        resources.ApplyResources(Me.lblEtrangerNL, "lblEtrangerNL")
        Me.lblEtrangerNL.Name = "lblEtrangerNL"
        Me.HelpProvider1.SetShowHelp(Me.lblEtrangerNL, CType(resources.GetObject("lblEtrangerNL.ShowHelp"), Boolean))
        '
        'LblBelgiqueNL
        '
        resources.ApplyResources(Me.LblBelgiqueNL, "LblBelgiqueNL")
        Me.LblBelgiqueNL.Name = "LblBelgiqueNL"
        Me.HelpProvider1.SetShowHelp(Me.LblBelgiqueNL, CType(resources.GetObject("LblBelgiqueNL.ShowHelp"), Boolean))
        '
        'LblBelgiqueFR
        '
        resources.ApplyResources(Me.LblBelgiqueFR, "LblBelgiqueFR")
        Me.LblBelgiqueFR.Name = "LblBelgiqueFR"
        Me.HelpProvider1.SetShowHelp(Me.LblBelgiqueFR, CType(resources.GetObject("LblBelgiqueFR.ShowHelp"), Boolean))
        '
        'txtEtrangerFR
        '
        resources.ApplyResources(Me.txtEtrangerFR, "txtEtrangerFR")
        Me.txtEtrangerFR.Name = "txtEtrangerFR"
        '
        'txtEtrangerNL
        '
        resources.ApplyResources(Me.txtEtrangerNL, "txtEtrangerNL")
        Me.txtEtrangerNL.Name = "txtEtrangerNL"
        Me.HelpProvider1.SetShowHelp(Me.txtEtrangerNL, CType(resources.GetObject("txtEtrangerNL.ShowHelp"), Boolean))
        '
        'txtBelgiqueFR
        '
        resources.ApplyResources(Me.txtBelgiqueFR, "txtBelgiqueFR")
        Me.txtBelgiqueFR.Name = "txtBelgiqueFR"
        Me.HelpProvider1.SetShowHelp(Me.txtBelgiqueFR, CType(resources.GetObject("txtBelgiqueFR.ShowHelp"), Boolean))
        '
        'txtBelgiqueNL
        '
        resources.ApplyResources(Me.txtBelgiqueNL, "txtBelgiqueNL")
        Me.txtBelgiqueNL.Name = "txtBelgiqueNL"
        Me.HelpProvider1.SetShowHelp(Me.txtBelgiqueNL, CType(resources.GetObject("txtBelgiqueNL.ShowHelp"), Boolean))
        '
        'lblPickGroup
        '
        resources.ApplyResources(Me.lblPickGroup, "lblPickGroup")
        Me.lblPickGroup.Name = "lblPickGroup"
        '
        'txtEtrangerFrQtyClient
        '
        resources.ApplyResources(Me.txtEtrangerFrQtyClient, "txtEtrangerFrQtyClient")
        Me.txtEtrangerFrQtyClient.Name = "txtEtrangerFrQtyClient"
        Me.txtEtrangerFrQtyClient.ReadOnly = True
        Me.HelpProvider1.SetShowHelp(Me.txtEtrangerFrQtyClient, CType(resources.GetObject("txtEtrangerFrQtyClient.ShowHelp"), Boolean))
        '
        'txtEtrangerNLQtyClient
        '
        resources.ApplyResources(Me.txtEtrangerNLQtyClient, "txtEtrangerNLQtyClient")
        Me.txtEtrangerNLQtyClient.Name = "txtEtrangerNLQtyClient"
        Me.txtEtrangerNLQtyClient.ReadOnly = True
        Me.HelpProvider1.SetShowHelp(Me.txtEtrangerNLQtyClient, CType(resources.GetObject("txtEtrangerNLQtyClient.ShowHelp"), Boolean))
        '
        'txtBelgiqueFRQtyClient
        '
        resources.ApplyResources(Me.txtBelgiqueFRQtyClient, "txtBelgiqueFRQtyClient")
        Me.txtBelgiqueFRQtyClient.Name = "txtBelgiqueFRQtyClient"
        Me.txtBelgiqueFRQtyClient.ReadOnly = True
        Me.HelpProvider1.SetShowHelp(Me.txtBelgiqueFRQtyClient, CType(resources.GetObject("txtBelgiqueFRQtyClient.ShowHelp"), Boolean))
        '
        'txtBelgiqueNLQtyClient
        '
        resources.ApplyResources(Me.txtBelgiqueNLQtyClient, "txtBelgiqueNLQtyClient")
        Me.txtBelgiqueNLQtyClient.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBelgiqueNLQtyClient.Name = "txtBelgiqueNLQtyClient"
        Me.txtBelgiqueNLQtyClient.ReadOnly = True
        Me.HelpProvider1.SetShowHelp(Me.txtBelgiqueNLQtyClient, CType(resources.GetObject("txtBelgiqueNLQtyClient.ShowHelp"), Boolean))
        '
        'Lblnb_cust
        '
        resources.ApplyResources(Me.Lblnb_cust, "Lblnb_cust")
        Me.Lblnb_cust.Name = "Lblnb_cust"
        Me.HelpProvider1.SetShowHelp(Me.Lblnb_cust, CType(resources.GetObject("Lblnb_cust.ShowHelp"), Boolean))
        '
        'TabResultLstOut
        '
        Me.TabResultLstOut.Controls.Add(Me.GridListingOut)
        Me.TabResultLstOut.Name = "TabResultLstOut"
        resources.ApplyResources(Me.TabResultLstOut, "TabResultLstOut")
        '
        'GridListingOut
        '
        resources.ApplyResources(Me.GridListingOut, "GridListingOut")
        Me.GridListingOut.EmbeddedNavigator.Name = ""
        Me.GridListingOut.FormsUseDefaultLookAndFeel = False
        Me.GridListingOut.MainView = Me.GridViewListingOut
        Me.GridListingOut.Name = "GridListingOut"
        Me.GridListingOut.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewListingOut})
        '
        'GridViewListingOut
        '
        Me.GridViewListingOut.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrders_id, Me.colCustomers_id, Me.coldelivery_country, Me.colProducts_id, Me.coldvd_id, Me.colBoxId, Me.colpibox_id, Me.colLanguage, Me.colpickgroup, Me.coldatepurchased, Me.colorders_type, Me.colpick_boxid})
        Me.GridViewListingOut.CustomizationFormBounds = New System.Drawing.Rectangle(1454, 748, 216, 178)
        Me.GridViewListingOut.GridControl = Me.GridListingOut
        Me.GridViewListingOut.Name = "GridViewListingOut"
        Me.GridViewListingOut.OptionsSelection.MultiSelect = True
        Me.GridViewListingOut.OptionsView.ShowFooter = True
        '
        'colOrders_id
        '
        resources.ApplyResources(Me.colOrders_id, "colOrders_id")
        Me.colOrders_id.FieldName = "orders_id"
        Me.colOrders_id.Name = "colOrders_id"
        Me.colOrders_id.OptionsColumn.AllowEdit = False
        Me.colOrders_id.OptionsColumn.ReadOnly = True
        '
        'colCustomers_id
        '
        resources.ApplyResources(Me.colCustomers_id, "colCustomers_id")
        Me.colCustomers_id.FieldName = "customers_id"
        Me.colCustomers_id.Name = "colCustomers_id"
        Me.colCustomers_id.OptionsColumn.AllowEdit = False
        Me.colCustomers_id.OptionsColumn.ReadOnly = True
        '
        'coldelivery_country
        '
        resources.ApplyResources(Me.coldelivery_country, "coldelivery_country")
        Me.coldelivery_country.FieldName = "delivery_country"
        Me.coldelivery_country.Name = "coldelivery_country"
        Me.coldelivery_country.OptionsColumn.AllowEdit = False
        Me.coldelivery_country.OptionsColumn.ReadOnly = True
        '
        'colProducts_id
        '
        resources.ApplyResources(Me.colProducts_id, "colProducts_id")
        Me.colProducts_id.FieldName = "products_id"
        Me.colProducts_id.Name = "colProducts_id"
        Me.colProducts_id.OptionsColumn.AllowEdit = False
        Me.colProducts_id.OptionsColumn.ReadOnly = True
        '
        'coldvd_id
        '
        resources.ApplyResources(Me.coldvd_id, "coldvd_id")
        Me.coldvd_id.FieldName = "dvd_id"
        Me.coldvd_id.Name = "coldvd_id"
        Me.coldvd_id.OptionsColumn.AllowEdit = False
        Me.coldvd_id.OptionsColumn.ReadOnly = True
        '
        'colBoxId
        '
        resources.ApplyResources(Me.colBoxId, "colBoxId")
        Me.colBoxId.FieldName = "box_id"
        Me.colBoxId.Name = "colBoxId"
        Me.colBoxId.OptionsColumn.AllowEdit = False
        Me.colBoxId.OptionsColumn.ReadOnly = True
        '
        'colpibox_id
        '
        resources.ApplyResources(Me.colpibox_id, "colpibox_id")
        Me.colpibox_id.FieldName = "pibox_id"
        Me.colpibox_id.Name = "colpibox_id"
        Me.colpibox_id.OptionsColumn.AllowEdit = False
        Me.colpibox_id.OptionsColumn.ReadOnly = True
        '
        'colLanguage
        '
        resources.ApplyResources(Me.colLanguage, "colLanguage")
        Me.colLanguage.FieldName = "language_id"
        Me.colLanguage.Name = "colLanguage"
        Me.colLanguage.OptionsColumn.AllowEdit = False
        Me.colLanguage.OptionsColumn.ReadOnly = True
        '
        'colpickgroup
        '
        resources.ApplyResources(Me.colpickgroup, "colpickgroup")
        Me.colpickgroup.FieldName = "pick_group"
        Me.colpickgroup.Name = "colpickgroup"
        Me.colpickgroup.OptionsColumn.AllowEdit = False
        Me.colpickgroup.OptionsColumn.ReadOnly = True
        '
        'coldatepurchased
        '
        resources.ApplyResources(Me.coldatepurchased, "coldatepurchased")
        Me.coldatepurchased.DisplayFormat.FormatString = clsDevExpress.COLDATETIME
        Me.coldatepurchased.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.coldatepurchased.FieldName = "date_purchased"
        Me.coldatepurchased.GroupFormat.FormatString = clsDevExpress.COLDATETIME
        Me.coldatepurchased.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.coldatepurchased.Name = "coldatepurchased"
        Me.coldatepurchased.OptionsColumn.AllowEdit = False
        Me.coldatepurchased.OptionsColumn.ReadOnly = True
        '
        'colorders_type
        '
        resources.ApplyResources(Me.colorders_type, "colorders_type")
        Me.colorders_type.FieldName = "orders_type"
        Me.colorders_type.Name = "colorders_type"
        Me.colorders_type.OptionsColumn.AllowEdit = False
        Me.colorders_type.OptionsColumn.ReadOnly = True
        '
        'colpick_boxid
        '
        resources.ApplyResources(Me.colpick_boxid, "colpick_boxid")
        Me.colpick_boxid.FieldName = "pick_boxid"
        Me.colpick_boxid.Name = "colpick_boxid"
        '
        'tabParams
        '
        Me.tabParams.Name = "tabParams"
        resources.ApplyResources(Me.tabParams, "tabParams")
        '
        'xxxfrmListingOUT
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "xxxfrmListingOUT"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
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
        CType(Me.txtMaxDVDPerGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabResultLstOut.ResumeLayout(False)
        CType(Me.GridListingOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewListingOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "
    'Dim _DS As New DataSet
    Dim _ProductView As DataView
    Dim OrderViewToPick As DataView
    ' Dim _objDS As dsEnvelopeLabels
    Dim _Lstview(4) As DataView
    Dim _ds As DataSet
    Dim _dtOrders As DataTable


    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim menuStrip As New DVDPostBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip
        GridListingOut.ContextMenuStrip = menuStrip

        '      _DS.Tables.Add("TmpOrderTable")
        '     _DS.Tables.Add("TmpProductsDVDTable")


        ' objDS = New dsEnvelopeLabels
        ' --------------------------------------------------
        ' only used by bizkeys.dll !!!!
        _ds = New DataSet
        _ds.Tables.Add("orders_out_view1")
        _dtOrders = _ds.Tables("orders_out_view1")
        objDS = _ds

        ' --------------------------------------------------
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        ' MyBase.TableName = "orders_out_view1"
        ' MyBase.IDField = "orders_id"
        ' MyBase.NameField = "orders_id"
        '    MyBase.MaintenanceMenuID = -1
        '  MyBase.WhereClause = ""
        '  MyBase.AutoLoadData = False
        ' MyBase.StartUp()
        ' --------------------------------------------------
        'objDS = Nothing
        ' --------------------------------------------------
        ' BKGlobal.SetToolBar(BarManager1, Me.Tag, False, False, False, False, True, False, , True, False, False, False)
        Main_Bar.Visible = False
        Misc_Bar.Visible = True

        CurrentDefaultSetID = cmbDefaultList.EditValue
        'btnOK
        '  Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Never  'DevExpress.XtraBars.BarItemVisibility.Always

        ' TabAnalyse.Visible = False
        '  TabChart.Visible = False
        TabControl1.SelectedTabPage = TabParameters
        'txtProcedure.Text = "1. The system will load all ORDERS to ship." & vbCrLf & _
        '                    "2. It will create group of DVDs to pick " & vbCrLf & _
        '                    "      By country " & vbCrLf & _
        '                    "      By Language " & vbCrLf & _
        '                    "      With Maximum : " & txtMaxDVDPerGroup.Value.ToString & vbCrLf & _
        '                    "3. When Result appear : " & vbCrLf & _
        '                    "   Print 'Picking List' and follow the instruction"
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser1.Caption = "Cancel Order"
        btnUser1.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        btnUser2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser2.Caption = "DVD are Lost"
        btnUser2.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        GridView1.OptionsSelection.MultiSelect = True

        Dim strdate As String = "'" & DVDPostTools.ClsDate.formatDate() + " 10:00:00'"
        GridViewListingOut.ActiveFilter.Add(GridViewListingOut.Columns("date_purchased"), _
           New DevExpress.XtraGrid.Columns.ColumnFilterInfo("[date_purchased] <= " & strdate))

        'GridView1.ActiveFilter.Add(GridView1.Columns("date_purchased"), _
        'New DevExpress.XtraGrid.Columns.ColumnFilterInfo("[date_purchased] <= " & strdate))


        'MsgBox("Tutu")
    End Sub
    Private Sub btnLoadOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadOrders.Click
        LoadOrders()
        TabControl1.SelectedTabPage = TabResultLstOut
    End Sub
    Public Sub LoadOrders()
        Dim _SQLTxt As String
        '_DS.Tables("TmpOrderTable").Clear()
        '_DS.Tables("TmpProductsDVDTable").Clear()

        'txtInfo.Text = "Load Orders to Ship"
        'DoEvents()
        '_SQLTxt = "SELECT orders_products_id,  orders_id, products_id, products_dvd, orders_products_status, " & _
        '          " orders_products_type  FROM orders_products op  WHERE op.orders_products_status = 0 " 'Ready for Exped
        'DvdPostData.clsConnection.FillDataSet(_DS.Tables("TmpOrderTable"), _SQLTxt)
        'txtInfo.Text = "Loading Products_DVD Info"
        'DoEvents()
        '_SQLTxt = "SELECT products_id, products_dvdid, products_dvd_status, `inout`, box_id, pibox_id " & _
        '                  " FROM products_dvd " & _
        '                  " WHERE products_dvd_status = 1 and `inout` = 1 and box_id <> 0 ORDER BY box_id"
        'DvdPostData.clsConnection.FillDataSet(_DS.Tables("TmpProductsDVDTable"), _SQLTxt)
        '_DS.Tables("TmpProductsDVDTable").PrimaryKey = New DataColumn() {_DS.Tables("TmpProductsDVDTable").Columns("products_id"), _
        '                                                         _DS.Tables("TmpProductsDVDTable").Columns("products_dvdid")}
        '_ProductView = New DataView(_DS.Tables("TmpProductsDVDTable"), " ", "products_id, inout ", DataViewRowState.CurrentRows)
        Dim dt As DataTable
        ' objDS.Tables("orders_out_view1").Clear()
        _SQLTxt = DvdPostData.clsOdersStatusHistory.GetOrdersAssignPickGroup()
        dt = DvdPostData.clsConnection.FillDataSet(_SQLTxt)
        dt.TableName = "orders_out_view1"
        objDS = New DataSet
        objDS.Tables.Add(dt)
        GridListingOut.DataSource = dt
        _Lstview = CreateLstView(dt)
        SetQtyClient(_Lstview)

        'Set_Pick_Group()
        ' Grid1.DataSource = dt  'objDS.Tables(TableName).DefaultView

    End Sub
    Private Function Getsigne(ByVal pos As Integer) As String
        If pos = 1 Then
            Return "="
        Else
            Return "<>"
        End If
    End Function

    Private Function GetQtyClientInPickGroup(ByVal qtyClient As Integer, ByVal lstpickgroup() As String) As Integer

        Dim nb_pickgroup As Integer
        nb_pickgroup = lstpickgroup.Length

        Return CInt(qtyClient / nb_pickgroup) + 1
    End Function
    Private Sub SetQtyClient(ByVal lstview As DataView())
        For i As Integer = 1 To 2
            For j As Integer = 1 To 2
                SetQtyClient(i = 1, j = 1, lstview(GetIndexView(i, j)))
            Next
        Next

    End Sub
    Private Sub SetQtyClient(ByVal isBelgique As Boolean, ByVal IsNL As Boolean, ByVal view As DataView)

        Dim ctrl As Windows.Forms.TextBox
        Dim dt As DataTable
        ctrl = GetctrlQtyClient(isBelgique, IsNL)

        dt = view.ToTable(True, "customers_id")
        ctrl.Text = dt.Rows.Count
    End Sub
    Private Function GetctrlQtyClient(ByVal isBelgique As Boolean, ByVal IsNL As Boolean) As Windows.Forms.TextBox
        Dim isfr As Boolean = Not IsNL

        If isBelgique Then
            If isfr Then
                Return txtBelgiqueFRQtyClient
            Else
                Return txtBelgiqueNLQtyClient
            End If
        Else
            If isfr Then
                Return txtEtrangerFrQtyClient
            Else
                Return txtEtrangerNLQtyClient
            End If
        End If

    End Function

    Private Function GetLstPickGroup(ByVal isBelgique As Boolean, ByVal IsNL As Boolean) As String
        Dim isFR As Boolean = Not IsNL

        If isBelgique Then
            If isFR Then
                Return txtBelgiqueFR.Text
            Else
                Return txtBelgiqueNL.Text
            End If
        Else
            If isFR Then
                Return txtEtrangerFR.Text
            Else
                Return txtEtrangerNL.Text
            End If
        End If

    End Function
    Private Function GetIndexView(ByVal i As Integer, ByVal j As Integer) As Integer
        Return (i - 1) * 2 + j
    End Function

    Private Sub assignGroup(ByVal isBelgique As Boolean, ByVal IsNL As Boolean, ByVal view As DataView)
        Dim ctrl As Windows.Forms.TextBox
        Dim lstPickGroup() As String
        Dim strlstPickGroup As String
        Dim qtyClientPickGroup As Integer
        Dim oldCustomers_id As Integer = 0
        Dim qtycurrent As Integer = 0
        Dim indexCurrent As Integer = 0
        Dim pickgroupCurrent As Integer = 0


        Dim grp_country As String
        Dim grp_language As Integer
        Dim grp As String
        Dim grp_id As Integer

        Dim sql As String

        ctrl = GetctrlQtyClient(isBelgique, IsNL)
        strlstPickGroup = GetLstPickGroup(isBelgique, IsNL)

        lstPickGroup = strlstPickGroup.Split(",")
        qtyClientPickGroup = GetQtyClientInPickGroup(CInt(ctrl.Text), lstPickGroup)

        While indexCurrent < view.Count
            oldCustomers_id = view(indexCurrent)("customers_id")
            grp_id = lstPickGroup(pickgroupCurrent)
            While indexCurrent < view.Count AndAlso oldCustomers_id = view(indexCurrent)("customers_id")
                grp_country = view(indexCurrent)("delivery_country")
                grp_language = view(indexCurrent)("language_id")

                grp = grp_country & "-" & Format(grp_language, "00") & "-" & Format(grp_id, "00")
                view(indexCurrent)("pick_group") = grp

                sql = DvdPostData.clsOdersStatusHistory.getUpdateOrdersPickGroup(grp, grp_id, view(indexCurrent)("orders_id"))
                DvdPostData.clsConnection.ExecuteNonQuery(sql)

                indexCurrent += 1
            End While

            qtycurrent += 1

            If qtycurrent >= qtyClientPickGroup Then
                qtycurrent = 0
                pickgroupCurrent += 1
            End If
        End While


    End Sub
    Private Sub assignGroup(ByVal lstView() As DataView)
        For i As Integer = 1 To 2
            For j As Integer = 1 To 2
                assignGroup(i = 1, j = 1, lstView(GetIndexView(i, j)))
            Next
        Next

    End Sub
    Private Function CreateLstView(ByVal dt As DataTable) As DataView()
        Dim Lstview(4) As DataView

        Dim signeI, signeJ As String
        Dim cpt As Integer
        For i As Integer = 1 To 2
            signeI = Getsigne(i)
            For j As Integer = 1 To 2
                signeJ = Getsigne(j)
                Lstview(GetIndexView(i, j)) = New DataView(objDS.Tables(0), _
                "delivery_country " & signeI & " 'Belgium' and (language_id " & signeJ & "2)", _
                "customers_id", DataViewRowState.CurrentRows)
                ' txtInfo.EditValue = _View.Count
                ' AssignGroup(_View)
            Next
        Next

        Return Lstview
    End Function


    'Private Sub Set_Pick_Group2()

    '    Dim _View As DataView

    '    Dim signeI, signeJ As String

    '    For i As Integer = 1 To 2
    '        signeI = Getsigne(i)
    '        For j As Integer = 1 To 2
    '            signeJ = Getsigne(j)
    '            _View = New DataView(_objDS.Tables(TableName), _
    '            "delivery_country " & signeI & " 'Belgium' and (language_id " & signeJ & " '2')", _
    '            "customers_id", DataViewRowState.CurrentRows)
    '            ' txtInfo.EditValue = _View.Count
    '            AssignGroup(_View)
    '        Next
    '    Next

    'End Sub
    'Private Sub AssignGroup(ByVal vView As DataView)
    '    '1Box EU-FR : Box Nbr 1
    '    '1Box EU-NL : Box Nbr 2
    '    '2Box BE-NL : Box Nbr 3 and 4
    '    '5Boxes BE-FR : Box Nbr 5, 6, 7, 8 and 9
    '    Dim _row As DataRowView
    '    Dim _i As Integer = 0
    '    Dim _Grp As String = ""
    '    Dim _Grp_Ctry As String = ""
    '    Dim _Grp_Lang As Integer = 0
    '    Dim _Grp_ID As Integer = 1
    '    Dim _tot As Integer
    '    Dim _max As Integer = 200
    '    Dim sql As String
    '    If vView.Count = 0 Then Exit Sub
    '    _Grp_Ctry = vView(0)("delivery_country")
    '    _Grp_Lang = vView(0)("language_id")
    '    _tot = vView.Count
    '    If _Grp_Ctry <> "Belgium" Then 'EU Other than BE
    '        _max = _tot
    '        If _Grp_Lang <> 2 Then 'BE-FR
    '            _Grp_ID = 1
    '        Else 'BE-NL
    '            _Grp_ID = 2
    '        End If
    '    Else
    '        If _Grp_Lang <> 2 Then 'BE-FR
    '            _max = Fix((_tot / 5)) + 2
    '            _Grp_ID = 5
    '        Else 'BE-NL
    '            _max = Fix(_tot / 2) + 2
    '            _Grp_ID = 3
    '        End If
    '    End If
    '    If _max < 200 Then _max = 200
    '    For Each _row In vView
    '        _i += 1

    '        If _i > _max Then
    '            _Grp_ID += 1
    '            _i = 1
    '        End If
    '        _Grp = _Grp_Ctry & "-" & Format(_Grp_Lang, "00") & "-" & Format(_Grp_ID, "00")
    '        _row("pick_group") = _Grp

    '        sql = DvdPostData.clsOdersStatusHistory.getUpdateOrdersPickGroup(_Grp, _Grp_ID, _row("orders_id"))
    '        DvdPostData.clsConnection.ExecuteNonQuery(sql)

    '        'txtInfo.EditValue -= 1
    '        '  DoEvents()
    '    Next
    'End Sub
    'Private Sub btnClearDVDAssigned_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearDVDAssigned.Click
    '    Dim _SQLTxt As String
    '    _SQLTxt = "UPDATE products_dvd SET `inout` = 1 WHERE `inout` = 2 "
    '    DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
    '    _SQLTxt = "update orders_products op set  op.products_dvd = 0 where op.orders_products_status = 0 " 'Ready For Exped
    '    DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
    'End Sub
    'Private Sub btnAssignDVDToOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignDVDToOrders.Click
    '    Dim _products_id As Integer
    '    Dim _DVDID As Integer
    '    Dim _SQL As String

    '    Dim _Row As DataRow
    '    Dim _ProductTable As New DataTable("products_dvd")
    '    txtInfo.EditValue = _DS.Tables("TmpOrderTable").Rows.Count
    '    For Each _Row In _DS.Tables("TmpOrderTable").Rows
    '        txtInfo.EditValue -= 1
    '        DoEvents()
    '        _products_id = _Row("products_id")
    '        If _Row("products_dvd") = 0 And _products_id > 50 Then
    '            'Find DVDID to Ship
    '            '_ProductRows = _ProductView.FindRows(New Object() {_products_id, 1})
    '            _SQL = " SELECT products_id, products_dvdid, products_dvd_status, `inout`, box_id, pibox_id " & _
    '                   " FROM products_dvd " & _
    '                   " WHERE products_id = " & _products_id & " AND products_dvd_status = 1 and `inout` = 1 and box_id <> 0" & _
    '                   " ORDER BY box_id limit 1 "
    '            _ProductTable.Clear()
    '            DvdPostData.clsConnection.FillDataSet(_ProductTable, _SQL)
    '            'If _ProductRows.GetLength(0) > 0 Then
    '            If _ProductTable.Rows.Count = 1 Then
    '                _DVDID = _ProductTable.Rows(0)("products_dvdid")
    '                _ProductTable.Rows(0)("inout") = 2
    '                'Assign DVDID to Orders_PRoducts 
    '                '_SQL = "update orders_products op set op.orders_products_status = " & StatusEnum.OrderProductStatus.ORDERS_PRODUCTS_STATUS_EXPEDITED & " , op.products_dvd=" & _DVDID & _
    '                '     " where op.orders_id=" & _Row("orders_id")
    '                _SQL = "update orders_products op set  op.products_dvd=" & _DVDID & " where op.orders_id=" & _Row("orders_id")
    '                DvdPostData.clsConnection.ExecuteNonQuery(_SQL)
    '                _SQL = "update products_dvd pd set  `inout` = 2 WHERE pd.products_id = " & _products_id & " AND products_dvdid = " & _DVDID
    '                DvdPostData.clsConnection.ExecuteNonQuery(_SQL)
    '                '_SQL = "update products p set  products_quantity = products_quantity - 1 WHERE p.products_id = " & _products_id
    '                'DvdPostData.clsConnection.ExecuteNonQuery(_SQL)
    '                '`inout` = 1 if IN
    '                '`inout` = 0 if OUT
    '                '`inout` = 2 if ToBePicked
    '            End If
    '        End If
    '    Next
    'End Sub
    Private Sub btnSetPickingGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPickingGroup.Click
        '  Set_Pick_Group()
        LoadOrders()
        assignGroup(_Lstview)
        LoadOrders()
        TabControl1.SelectedTabPage = TabResult

    End Sub
    Private Sub btnCancelOrder_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick
        'Cancel Orders
        Dim _Orders_ID As Integer
        Dim _customers_id As Integer
        Dim _products_id As Integer
        Dim _dvd_id As Integer
        Dim _objProductsDVD As clsProduct_DVD
        Dim _DS As dsProducts
        Dim _i As Integer
        Dim _bool_line_selected As Boolean = False
        Dim isIllimitedAbo As Boolean
        For Each _i In GridView1.GetSelectedRows

            If GridViewListingOut.GetDataRow(_i)("products_id") Is DBNull.Value Then Continue For
            _Orders_ID = GridViewListingOut.GetDataRow(_i)("orders_id")
            _customers_id = GridViewListingOut.GetDataRow(_i)("customers_id")
            _products_id = GridViewListingOut.GetDataRow(_i)("products_id")
            _dvd_id = GridViewListingOut.GetDataRow(_i)("dvd_id")
            _DS = New dsProducts
            _objProductsDVD = New clsProduct_DVD(SessionInfo, _DS, _products_id, _dvd_id)
            isIllimitedAbo = DVDPostBuziness.ClsCustomers.isIllimitedaboByCustomers(_customers_id)
            _objProductsDVD.CancelOrder(isIllimitedAbo, _Orders_ID, _customers_id)

        Next
        Do
            If GridViewListingOut.GetSelectedRows.Length = 0 Then Exit Do

            GridViewListingOut.DeleteRow(GridViewListingOut.GetSelectedRows(0))

        Loop
        MsgBox("Process Complete")
    End Sub
    Private Sub btnDVDLost_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser2.ItemClick
        Dim _Orders_ID As Integer
        Dim _customers_id As Integer
        Dim _products_id As Integer
        Dim _dvd_id As Integer
        Dim objProductDVD As clsProduct_DVD
        Dim _DS As dsProducts
        Dim _i As Integer
        For Each _i In GridViewListingOut.GetSelectedRows
            _Orders_ID = GridViewListingOut.GetDataRow(_i)("orders_id")
            _customers_id = GridViewListingOut.GetDataRow(_i)("customers_id")
            _products_id = GridViewListingOut.GetDataRow(_i)("products_id")
            _dvd_id = GridViewListingOut.GetDataRow(_i)("dvd_id")
            _DS = New dsProducts
            objProductDVD = New clsProduct_DVD(SessionInfo, _DS, _products_id, _dvd_id)

            objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.BIZARREMENT_PERDU, _
                                                          "Listing OUT - bizarement perdu", _
                                                          DvdPostData.ClsProducts_dvd_state.state.OUT, objProductDVD.INOUT)

            ' objProductDVD.ChangeDVDStatus2(_products_id, _dvd_id, 15, , , "")

        Next
        MsgBox("Process Complete")
    End Sub
    Public Sub gridviewListingOut_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewListingOut.DoubleClick
        Dim _frm As New frmCancelOrder(SessionInfo)
        Dim _Orders_ID As Integer
        Dim _customers_id As Integer
        Dim _products_id As Integer
        Dim _dvd_id As Integer

        Dim _i As Integer = GridViewListingOut.FocusedRowHandle
        _Orders_ID = GridViewListingOut.GetDataRow(_i)("orders_id")
        _customers_id = GridViewListingOut.GetDataRow(_i)("customers_id")
        _products_id = GridViewListingOut.GetDataRow(_i)("products_id")
        _dvd_id = GridViewListingOut.GetDataRow(_i)("dvd_id")
        _frm.txtOrderID.EditValue = _Orders_ID
        _frm.SearchOrderInfo()
        _frm.ShowDialog(Me)


        LoadOrders()
    End Sub

    Private Sub btnexcel_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _ExportExcel.ItemClick
        If SFDExportExcel.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GridListingOut.ExportToXls(SFDExportExcel.FileName)
        End If
    End Sub

End Class
