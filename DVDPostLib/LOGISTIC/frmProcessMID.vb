Imports System.Windows.Forms.Application
Public Class frmProcessMID
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
    Friend WithEvents btnLoadOrders As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFindBarCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDVD_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProducts_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBarCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPick_BoxId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panelstock As System.Windows.Forms.Panel
    Friend WithEvents LabelStock As System.Windows.Forms.Label
    Friend WithEvents LabelBoxID As System.Windows.Forms.Label
    Friend WithEvents txtBoxID As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnResetNbr As System.Windows.Forms.Button
    Friend WithEvents txtINFO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblCptOut As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblStock As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblOut As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblcptStock As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnUnlock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSearchInStock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridStock As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewStock As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coInOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvdid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvd_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbox_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpibox_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbar_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastModified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colproducts_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvdid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvd_status1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbox_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpibox_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbar_code1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_model1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstock_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_io As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colinout As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridPickin As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewPickin As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtBox_idMin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LblMinBox_id As System.Windows.Forms.Label
    Friend WithEvents btnLoadPickin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LblMaxBox_id As System.Windows.Forms.Label
    Friend WithEvents txtBox_idMax As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ChkPickin As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtPick_Group As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcessMID))
        Me.btnLoadOrders = New DevExpress.XtraEditors.SimpleButton
        Me.btnOK1 = New DevExpress.XtraEditors.SimpleButton
        Me.btnFindBarCode = New DevExpress.XtraEditors.SimpleButton
        Me.txtDVD_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtProducts_id = New DevExpress.XtraEditors.TextEdit
        Me.txtBarCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtPick_BoxId = New DevExpress.XtraEditors.LabelControl
        Me.txtPick_Group = New DevExpress.XtraEditors.LabelControl
        Me.Panelstock = New System.Windows.Forms.Panel
        Me.gridStock = New DevExpress.XtraGrid.GridControl
        Me.gridViewStock = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.coInOut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvdid = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvd_status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbox_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpibox_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbar_code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_model = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUser = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLastModified = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colproducts_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvdid1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvd_status1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbox_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpibox_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbar_code1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_model1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colstock_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_io = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colinout = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnSearchInStock = New DevExpress.XtraEditors.SimpleButton
        Me.btnResetNbr = New System.Windows.Forms.Button
        Me.txtBoxID = New DevExpress.XtraEditors.SpinEdit
        Me.LabelBoxID = New System.Windows.Forms.Label
        Me.LabelStock = New System.Windows.Forms.Label
        Me.txtINFO = New DevExpress.XtraEditors.TextEdit
        Me.LblOut = New DevExpress.XtraEditors.LabelControl
        Me.LblStock = New DevExpress.XtraEditors.LabelControl
        Me.LblCptOut = New DevExpress.XtraEditors.LabelControl
        Me.LblcptStock = New DevExpress.XtraEditors.LabelControl
        Me.btnUnlock = New DevExpress.XtraEditors.SimpleButton
        Me.GridPickin = New DevExpress.XtraGrid.GridControl
        Me.GridViewPickin = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtBox_idMin = New DevExpress.XtraEditors.SpinEdit
        Me.LblMinBox_id = New System.Windows.Forms.Label
        Me.LblMaxBox_id = New System.Windows.Forms.Label
        Me.txtBox_idMax = New DevExpress.XtraEditors.SpinEdit
        Me.btnLoadPickin = New DevExpress.XtraEditors.SimpleButton
        Me.ChkPickin = New DevExpress.XtraEditors.CheckEdit
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
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstock.SuspendLayout()
        CType(Me.gridStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtINFO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPickin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPickin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBox_idMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBox_idMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkPickin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.ChkPickin)
        Me.TabParameters.Controls.Add(Me.btnLoadPickin)
        Me.TabParameters.Controls.Add(Me.LblMaxBox_id)
        Me.TabParameters.Controls.Add(Me.txtBox_idMax)
        Me.TabParameters.Controls.Add(Me.LblMinBox_id)
        Me.TabParameters.Controls.Add(Me.txtBox_idMin)
        Me.TabParameters.Controls.Add(Me.GridPickin)
        Me.TabParameters.Controls.Add(Me.btnUnlock)
        Me.TabParameters.Controls.Add(Me.LblcptStock)
        Me.TabParameters.Controls.Add(Me.LblCptOut)
        Me.TabParameters.Controls.Add(Me.LblStock)
        Me.TabParameters.Controls.Add(Me.LblOut)
        Me.TabParameters.Controls.Add(Me.txtINFO)
        Me.TabParameters.Controls.Add(Me.Panelstock)
        Me.TabParameters.Controls.Add(Me.txtPick_Group)
        Me.TabParameters.Controls.Add(Me.txtPick_BoxId)
        Me.TabParameters.Controls.Add(Me.btnOK1)
        Me.TabParameters.Controls.Add(Me.btnFindBarCode)
        Me.TabParameters.Controls.Add(Me.txtDVD_ID)
        Me.TabParameters.Controls.Add(Me.LabelControl5)
        Me.TabParameters.Controls.Add(Me.txtProducts_id)
        Me.TabParameters.Controls.Add(Me.txtBarCode)
        Me.TabParameters.Controls.Add(Me.LabelControl2)
        Me.TabParameters.Controls.Add(Me.LabelControl1)
        Me.TabParameters.Controls.Add(Me.btnLoadOrders)
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
        'btnLoadOrders
        '
        resources.ApplyResources(Me.btnLoadOrders, "btnLoadOrders")
        Me.btnLoadOrders.Name = "btnLoadOrders"
        Me.HelpProvider1.SetShowHelp(Me.btnLoadOrders, CType(resources.GetObject("btnLoadOrders.ShowHelp"), Boolean))
        '
        'btnOK1
        '
        resources.ApplyResources(Me.btnOK1, "btnOK1")
        Me.btnOK1.Name = "btnOK1"
        Me.HelpProvider1.SetShowHelp(Me.btnOK1, CType(resources.GetObject("btnOK1.ShowHelp"), Boolean))
        '
        'btnFindBarCode
        '
        resources.ApplyResources(Me.btnFindBarCode, "btnFindBarCode")
        Me.btnFindBarCode.Name = "btnFindBarCode"
        Me.HelpProvider1.SetShowHelp(Me.btnFindBarCode, CType(resources.GetObject("btnFindBarCode.ShowHelp"), Boolean))
        '
        'txtDVD_ID
        '
        resources.ApplyResources(Me.txtDVD_ID, "txtDVD_ID")
        Me.txtDVD_ID.Name = "txtDVD_ID"
        Me.txtDVD_ID.Properties.ReadOnly = True
        Me.HelpProvider1.SetShowHelp(Me.txtDVD_ID, CType(resources.GetObject("txtDVD_ID.ShowHelp"), Boolean))
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Name = "LabelControl5"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl5, CType(resources.GetObject("LabelControl5.ShowHelp"), Boolean))
        '
        'txtProducts_id
        '
        resources.ApplyResources(Me.txtProducts_id, "txtProducts_id")
        Me.txtProducts_id.Name = "txtProducts_id"
        Me.txtProducts_id.Properties.ReadOnly = True
        Me.HelpProvider1.SetShowHelp(Me.txtProducts_id, CType(resources.GetObject("txtProducts_id.ShowHelp"), Boolean))
        '
        'txtBarCode
        '
        resources.ApplyResources(Me.txtBarCode, "txtBarCode")
        Me.txtBarCode.Name = "txtBarCode"
        Me.HelpProvider1.SetShowHelp(Me.txtBarCode, CType(resources.GetObject("txtBarCode.ShowHelp"), Boolean))
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, CType(resources.GetObject("LabelControl2.ShowHelp"), Boolean))
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, CType(resources.GetObject("LabelControl1.ShowHelp"), Boolean))
        '
        'txtPick_BoxId
        '
        Me.txtPick_BoxId.Appearance.Font = New System.Drawing.Font("Tahoma", 150.0!)
        Me.txtPick_BoxId.Appearance.Options.UseFont = True
        resources.ApplyResources(Me.txtPick_BoxId, "txtPick_BoxId")
        Me.txtPick_BoxId.Name = "txtPick_BoxId"
        Me.HelpProvider1.SetShowHelp(Me.txtPick_BoxId, CType(resources.GetObject("txtPick_BoxId.ShowHelp"), Boolean))
        '
        'txtPick_Group
        '
        Me.txtPick_Group.Appearance.Font = New System.Drawing.Font("Tahoma", 52.0!)
        Me.txtPick_Group.Appearance.Options.UseFont = True
        Me.txtPick_Group.Appearance.Options.UseTextOptions = True
        Me.txtPick_Group.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.txtPick_Group, "txtPick_Group")
        Me.txtPick_Group.Name = "txtPick_Group"
        Me.HelpProvider1.SetShowHelp(Me.txtPick_Group, CType(resources.GetObject("txtPick_Group.ShowHelp"), Boolean))
        '
        'Panelstock
        '
        resources.ApplyResources(Me.Panelstock, "Panelstock")
        Me.Panelstock.Controls.Add(Me.gridStock)
        Me.Panelstock.Controls.Add(Me.btnSearchInStock)
        Me.Panelstock.Controls.Add(Me.btnResetNbr)
        Me.Panelstock.Controls.Add(Me.txtBoxID)
        Me.Panelstock.Controls.Add(Me.LabelBoxID)
        Me.Panelstock.Controls.Add(Me.LabelStock)
        Me.Panelstock.Name = "Panelstock"
        '
        'gridStock
        '
        Me.gridStock.EmbeddedNavigator.Name = ""
        Me.gridStock.FormsUseDefaultLookAndFeel = False
        resources.ApplyResources(Me.gridStock, "gridStock")
        Me.gridStock.MainView = Me.gridViewStock
        Me.gridStock.Name = "gridStock"
        Me.gridStock.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewStock, Me.GridView2})
        '
        'gridViewStock
        '
        Me.gridViewStock.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coInOut, Me.colproducts_id, Me.colproducts_dvdid, Me.colproducts_dvd_status, Me.colbox_id, Me.colpibox_id, Me.colbar_code, Me.colproducts_model, Me.colUser, Me.colLastModified})
        Me.gridViewStock.CustomizationFormBounds = New System.Drawing.Rectangle(382, 307, 208, 276)
        Me.gridViewStock.GridControl = Me.gridStock
        Me.gridViewStock.Name = "gridViewStock"
        Me.gridViewStock.OptionsBehavior.Editable = False
        Me.gridViewStock.OptionsFilter.UseNewCustomFilterDialog = True
        Me.gridViewStock.OptionsSelection.MultiSelect = True
        Me.gridViewStock.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.gridViewStock.OptionsView.ShowFooter = True
        Me.gridViewStock.OptionsView.ShowGroupPanel = False
        Me.gridViewStock.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.coInOut, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'coInOut
        '
        resources.ApplyResources(Me.coInOut, "coInOut")
        Me.coInOut.FieldName = "inout"
        Me.coInOut.Name = "coInOut"
        '
        'colproducts_id
        '
        resources.ApplyResources(Me.colproducts_id, "colproducts_id")
        Me.colproducts_id.FieldName = "products_id"
        Me.colproducts_id.Name = "colproducts_id"
        '
        'colproducts_dvdid
        '
        resources.ApplyResources(Me.colproducts_dvdid, "colproducts_dvdid")
        Me.colproducts_dvdid.FieldName = "products_dvdid"
        Me.colproducts_dvdid.Name = "colproducts_dvdid"
        '
        'colproducts_dvd_status
        '
        resources.ApplyResources(Me.colproducts_dvd_status, "colproducts_dvd_status")
        Me.colproducts_dvd_status.FieldName = "products_dvd_status_name"
        Me.colproducts_dvd_status.Name = "colproducts_dvd_status"
        '
        'colbox_id
        '
        resources.ApplyResources(Me.colbox_id, "colbox_id")
        Me.colbox_id.FieldName = "box_id"
        Me.colbox_id.Name = "colbox_id"
        '
        'colpibox_id
        '
        resources.ApplyResources(Me.colpibox_id, "colpibox_id")
        Me.colpibox_id.FieldName = "pibox_id"
        Me.colpibox_id.Name = "colpibox_id"
        '
        'colbar_code
        '
        resources.ApplyResources(Me.colbar_code, "colbar_code")
        Me.colbar_code.FieldName = "bar_code"
        Me.colbar_code.Name = "colbar_code"
        '
        'colproducts_model
        '
        resources.ApplyResources(Me.colproducts_model, "colproducts_model")
        Me.colproducts_model.FieldName = "products_model"
        Me.colproducts_model.Name = "colproducts_model"
        '
        'colUser
        '
        resources.ApplyResources(Me.colUser, "colUser")
        Me.colUser.FieldName = "fullname"
        Me.colUser.Name = "colUser"
        '
        'colLastModified
        '
        resources.ApplyResources(Me.colLastModified, "colLastModified")
        Me.colLastModified.FieldName = "last_modified"
        Me.colLastModified.Name = "colLastModified"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colproducts_id1, Me.colproducts_dvdid1, Me.colproducts_dvd_status1, Me.colbox_id1, Me.colpibox_id1, Me.colbar_code1, Me.colproducts_model1, Me.colstock_type, Me.colproducts_io, Me.colinout})
        Me.GridView2.GridControl = Me.gridStock
        Me.GridView2.Name = "GridView2"
        '
        'colproducts_id1
        '
        resources.ApplyResources(Me.colproducts_id1, "colproducts_id1")
        Me.colproducts_id1.FieldName = "products_id"
        Me.colproducts_id1.Name = "colproducts_id1"
        '
        'colproducts_dvdid1
        '
        resources.ApplyResources(Me.colproducts_dvdid1, "colproducts_dvdid1")
        Me.colproducts_dvdid1.FieldName = "products_dvdid"
        Me.colproducts_dvdid1.Name = "colproducts_dvdid1"
        '
        'colproducts_dvd_status1
        '
        resources.ApplyResources(Me.colproducts_dvd_status1, "colproducts_dvd_status1")
        Me.colproducts_dvd_status1.FieldName = "products_dvd_status_name"
        Me.colproducts_dvd_status1.Name = "colproducts_dvd_status1"
        '
        'colbox_id1
        '
        resources.ApplyResources(Me.colbox_id1, "colbox_id1")
        Me.colbox_id1.FieldName = "box_id"
        Me.colbox_id1.Name = "colbox_id1"
        '
        'colpibox_id1
        '
        resources.ApplyResources(Me.colpibox_id1, "colpibox_id1")
        Me.colpibox_id1.FieldName = "pibox_id"
        Me.colpibox_id1.Name = "colpibox_id1"
        '
        'colbar_code1
        '
        resources.ApplyResources(Me.colbar_code1, "colbar_code1")
        Me.colbar_code1.FieldName = "bar_code"
        Me.colbar_code1.Name = "colbar_code1"
        '
        'colproducts_model1
        '
        resources.ApplyResources(Me.colproducts_model1, "colproducts_model1")
        Me.colproducts_model1.FieldName = "products_model"
        Me.colproducts_model1.Name = "colproducts_model1"
        '
        'colstock_type
        '
        resources.ApplyResources(Me.colstock_type, "colstock_type")
        Me.colstock_type.FieldName = "stock_type"
        Me.colstock_type.Name = "colstock_type"
        '
        'colproducts_io
        '
        resources.ApplyResources(Me.colproducts_io, "colproducts_io")
        Me.colproducts_io.FieldName = "products_io"
        Me.colproducts_io.Name = "colproducts_io"
        '
        'colinout
        '
        resources.ApplyResources(Me.colinout, "colinout")
        Me.colinout.FieldName = "inout"
        Me.colinout.Name = "colinout"
        '
        'btnSearchInStock
        '
        resources.ApplyResources(Me.btnSearchInStock, "btnSearchInStock")
        Me.btnSearchInStock.Name = "btnSearchInStock"
        Me.HelpProvider1.SetShowHelp(Me.btnSearchInStock, CType(resources.GetObject("btnSearchInStock.ShowHelp"), Boolean))
        '
        'btnResetNbr
        '
        resources.ApplyResources(Me.btnResetNbr, "btnResetNbr")
        Me.btnResetNbr.Name = "btnResetNbr"
        Me.HelpProvider1.SetShowHelp(Me.btnResetNbr, CType(resources.GetObject("btnResetNbr.ShowHelp"), Boolean))
        Me.btnResetNbr.UseVisualStyleBackColor = True
        '
        'txtBoxID
        '
        Me.txtBoxID.CausesValidation = False
        resources.ApplyResources(Me.txtBoxID, "txtBoxID")
        Me.txtBoxID.Name = "txtBoxID"
        Me.txtBoxID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtBoxID.Properties.DisplayFormat.FormatString = "N0"
        Me.txtBoxID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBoxID.Properties.EditFormat.FormatString = "N0"
        Me.txtBoxID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBoxID.Properties.IsFloatValue = False
        Me.txtBoxID.Properties.Mask.EditMask = resources.GetString("txtBoxID.Properties.Mask.EditMask")
        '
        'LabelBoxID
        '
        resources.ApplyResources(Me.LabelBoxID, "LabelBoxID")
        Me.LabelBoxID.Name = "LabelBoxID"
        '
        'LabelStock
        '
        resources.ApplyResources(Me.LabelStock, "LabelStock")
        Me.LabelStock.Name = "LabelStock"
        '
        'txtINFO
        '
        resources.ApplyResources(Me.txtINFO, "txtINFO")
        Me.txtINFO.Name = "txtINFO"
        Me.txtINFO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtINFO.Properties.Appearance.ForeColor = System.Drawing.Color.Firebrick
        Me.txtINFO.Properties.Appearance.Options.UseFont = True
        Me.txtINFO.Properties.Appearance.Options.UseForeColor = True
        '
        'LblOut
        '
        resources.ApplyResources(Me.LblOut, "LblOut")
        Me.LblOut.Name = "LblOut"
        '
        'LblStock
        '
        resources.ApplyResources(Me.LblStock, "LblStock")
        Me.LblStock.Name = "LblStock"
        Me.HelpProvider1.SetShowHelp(Me.LblStock, CType(resources.GetObject("LblStock.ShowHelp"), Boolean))
        '
        'LblCptOut
        '
        Me.LblCptOut.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCptOut.Appearance.Options.UseFont = True
        resources.ApplyResources(Me.LblCptOut, "LblCptOut")
        Me.LblCptOut.Name = "LblCptOut"
        Me.HelpProvider1.SetShowHelp(Me.LblCptOut, CType(resources.GetObject("LblCptOut.ShowHelp"), Boolean))
        '
        'LblcptStock
        '
        Me.LblcptStock.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcptStock.Appearance.Options.UseFont = True
        resources.ApplyResources(Me.LblcptStock, "LblcptStock")
        Me.LblcptStock.Name = "LblcptStock"
        Me.HelpProvider1.SetShowHelp(Me.LblcptStock, CType(resources.GetObject("LblcptStock.ShowHelp"), Boolean))
        '
        'btnUnlock
        '
        Me.btnUnlock.Appearance.BackColor = System.Drawing.Color.White
        Me.btnUnlock.Appearance.BackColor2 = System.Drawing.Color.White
        Me.btnUnlock.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnlock.Appearance.Options.UseBackColor = True
        Me.btnUnlock.Appearance.Options.UseFont = True
        resources.ApplyResources(Me.btnUnlock, "btnUnlock")
        Me.btnUnlock.Name = "btnUnlock"
        '
        'GridPickin
        '
        Me.GridPickin.EmbeddedNavigator.Name = ""
        Me.GridPickin.FormsUseDefaultLookAndFeel = False
        resources.ApplyResources(Me.GridPickin, "GridPickin")
        Me.GridPickin.MainView = Me.GridViewPickin
        Me.GridPickin.Name = "GridPickin"
        Me.HelpProvider1.SetShowHelp(Me.GridPickin, CType(resources.GetObject("GridPickin.ShowHelp"), Boolean))
        Me.GridPickin.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPickin, Me.GridView4})
        '
        'GridViewPickin
        '
        Me.GridViewPickin.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.GridViewPickin.CustomizationFormBounds = New System.Drawing.Rectangle(382, 307, 208, 276)
        Me.GridViewPickin.GridControl = Me.GridPickin
        Me.GridViewPickin.Name = "GridViewPickin"
        Me.GridViewPickin.OptionsBehavior.Editable = False
        Me.GridViewPickin.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridViewPickin.OptionsSelection.MultiSelect = True
        Me.GridViewPickin.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.GridViewPickin.OptionsView.ShowFooter = True
        Me.GridViewPickin.OptionsView.ShowGroupPanel = False
        Me.GridViewPickin.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "inout"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.FieldName = "products_id"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        resources.ApplyResources(Me.GridColumn3, "GridColumn3")
        Me.GridColumn3.FieldName = "dvd_id"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        resources.ApplyResources(Me.GridColumn4, "GridColumn4")
        Me.GridColumn4.FieldName = "products_dvd_status_name"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        resources.ApplyResources(Me.GridColumn5, "GridColumn5")
        Me.GridColumn5.FieldName = "box_id"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        resources.ApplyResources(Me.GridColumn6, "GridColumn6")
        Me.GridColumn6.FieldName = "pibox_id"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        resources.ApplyResources(Me.GridColumn7, "GridColumn7")
        Me.GridColumn7.FieldName = "bar_code"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        resources.ApplyResources(Me.GridColumn8, "GridColumn8")
        Me.GridColumn8.FieldName = "products_model"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn9
        '
        resources.ApplyResources(Me.GridColumn9, "GridColumn9")
        Me.GridColumn9.FieldName = "fullname"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        resources.ApplyResources(Me.GridColumn10, "GridColumn10")
        Me.GridColumn10.FieldName = "last_modified"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20})
        Me.GridView4.GridControl = Me.GridPickin
        Me.GridView4.Name = "GridView4"
        '
        'GridColumn11
        '
        resources.ApplyResources(Me.GridColumn11, "GridColumn11")
        Me.GridColumn11.FieldName = "products_id"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        resources.ApplyResources(Me.GridColumn12, "GridColumn12")
        Me.GridColumn12.FieldName = "products_dvdid"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        resources.ApplyResources(Me.GridColumn13, "GridColumn13")
        Me.GridColumn13.FieldName = "products_dvd_status_name"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn14
        '
        resources.ApplyResources(Me.GridColumn14, "GridColumn14")
        Me.GridColumn14.FieldName = "box_id"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn15
        '
        resources.ApplyResources(Me.GridColumn15, "GridColumn15")
        Me.GridColumn15.FieldName = "pibox_id"
        Me.GridColumn15.Name = "GridColumn15"
        '
        'GridColumn16
        '
        resources.ApplyResources(Me.GridColumn16, "GridColumn16")
        Me.GridColumn16.FieldName = "bar_code"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn17
        '
        resources.ApplyResources(Me.GridColumn17, "GridColumn17")
        Me.GridColumn17.FieldName = "products_model"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn18
        '
        resources.ApplyResources(Me.GridColumn18, "GridColumn18")
        Me.GridColumn18.FieldName = "stock_type"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn19
        '
        resources.ApplyResources(Me.GridColumn19, "GridColumn19")
        Me.GridColumn19.FieldName = "products_io"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'GridColumn20
        '
        resources.ApplyResources(Me.GridColumn20, "GridColumn20")
        Me.GridColumn20.FieldName = "inout"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'txtBox_idMin
        '
        Me.txtBox_idMin.CausesValidation = False
        resources.ApplyResources(Me.txtBox_idMin, "txtBox_idMin")
        Me.txtBox_idMin.Name = "txtBox_idMin"
        Me.txtBox_idMin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtBox_idMin.Properties.DisplayFormat.FormatString = "N0"
        Me.txtBox_idMin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBox_idMin.Properties.EditFormat.FormatString = "N0"
        Me.txtBox_idMin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBox_idMin.Properties.IsFloatValue = False
        Me.txtBox_idMin.Properties.Mask.EditMask = resources.GetString("txtBox_idMin.Properties.Mask.EditMask")
        Me.HelpProvider1.SetShowHelp(Me.txtBox_idMin, CType(resources.GetObject("txtBox_idMin.ShowHelp"), Boolean))
        '
        'LblMinBox_id
        '
        resources.ApplyResources(Me.LblMinBox_id, "LblMinBox_id")
        Me.LblMinBox_id.Name = "LblMinBox_id"
        Me.HelpProvider1.SetShowHelp(Me.LblMinBox_id, CType(resources.GetObject("LblMinBox_id.ShowHelp"), Boolean))
        '
        'LblMaxBox_id
        '
        resources.ApplyResources(Me.LblMaxBox_id, "LblMaxBox_id")
        Me.LblMaxBox_id.Name = "LblMaxBox_id"
        Me.HelpProvider1.SetShowHelp(Me.LblMaxBox_id, CType(resources.GetObject("LblMaxBox_id.ShowHelp"), Boolean))
        '
        'txtBox_idMax
        '
        Me.txtBox_idMax.CausesValidation = False
        resources.ApplyResources(Me.txtBox_idMax, "txtBox_idMax")
        Me.txtBox_idMax.Name = "txtBox_idMax"
        Me.txtBox_idMax.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtBox_idMax.Properties.DisplayFormat.FormatString = "N0"
        Me.txtBox_idMax.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBox_idMax.Properties.EditFormat.FormatString = "N0"
        Me.txtBox_idMax.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBox_idMax.Properties.IsFloatValue = False
        Me.txtBox_idMax.Properties.Mask.EditMask = resources.GetString("txtBox_idMax.Properties.Mask.EditMask")
        Me.HelpProvider1.SetShowHelp(Me.txtBox_idMax, CType(resources.GetObject("txtBox_idMax.ShowHelp"), Boolean))
        '
        'btnLoadPickin
        '
        resources.ApplyResources(Me.btnLoadPickin, "btnLoadPickin")
        Me.btnLoadPickin.Name = "btnLoadPickin"
        Me.HelpProvider1.SetShowHelp(Me.btnLoadPickin, CType(resources.GetObject("btnLoadPickin.ShowHelp"), Boolean))
        '
        'ChkPickin
        '
        resources.ApplyResources(Me.ChkPickin, "ChkPickin")
        Me.ChkPickin.Name = "ChkPickin"
        Me.ChkPickin.Properties.Caption = resources.GetString("ChkPickin.Properties.Caption")
        '
        'frmProcessMID
        '
        Me.AcceptButton = Me.btnOK1
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmProcessMID"
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
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstock.ResumeLayout(False)
        Me.Panelstock.PerformLayout()
        CType(Me.gridStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtINFO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPickin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPickin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBox_idMin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBox_idMax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkPickin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "
    Dim _DS As New DataSet
    '  Dim _dsStock As New DataSet
    Dim ViewByProduct As DataView
    Dim _row As DataRow
    Private NbrDVDByBox As Int16 = 20
    Dim _list_mid As System.Collections.Generic.Dictionary(Of String, Boolean)

    Dim _nametable As String = "products_dvd_stock_1"
    Dim _nametableStock As String = "products_dvd_stock_1"
    Dim _nametableOrder As String = "orders_out_view1"
    Dim _cptStock As Integer = 0
    Dim _cptOut As Integer = 0
    Dim _CheckProcess As ClsCheckProcessLogistic

    Private Sub initCheckProcess()
        _CheckProcess = New ClsCheckProcessLogistic()
        _CheckProcess.txtInfo = txtINFO
        _CheckProcess.sessionInfo = SessionInfo
        _CheckProcess.objDS = objDS
        _CheckProcess.btnSearch = btnSearchInStock
        _CheckProcess.txtbarcode = txtBarCode
        _CheckProcess.btnUnlock = btnUnlock
        _CheckProcess.Ctrlbox_id = txtBoxID
        objDS.EnforceConstraints = False
    End Sub


    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip
        gridStock.ContextMenuStrip = menuStrip


        '_DS.Tables.Add("TmpOrderTable")
        ' _DS.Tables.Add("TmpProductsDVDTable")
        '_dsStock.Tables.Add(_nametableStock)
        objDS = New dsProducts
        'objDS.Tables.Add(_nametableStock)
        'objDS = New DataSet()
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = _nametableOrder
        MyBase.IDField = "orders_id"
        MyBase.NameField = "orders_id"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = False
        MyBase.StartUp()
        LoadOrders()
        BKGlobal.SetToolBar(BarManager1, Me.Tag, False, False, False, False, True, False, , False, False, False, False)
        Main_Bar.Visible = False
        Misc_Bar.Visible = True
        CurrentDefaultSetID = cmbDefaultList.EditValue
        'btnOK
        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Never  'DevExpress.XtraBars.BarItemVisibility.Always
        'If CurrentDefaultSetID <> 0 Then
        '    BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
        '    'LoadDataSet()
        '    TabControl1.SelectedTabPage = TabResult
        'Else
        '    TabControl1.SelectedTabPage = TabParameters
        'End If
        TabAnalyse.Visible = False
        TabChart.Visible = False
        TabControl1.SelectedTabPage = TabParameters
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser1.Caption = "Cancel Order"
        btnUser1.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        btnUser2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser2.Caption = "DVD are Lost"
        btnUser2.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        GridView1.OptionsSelection.MultiSelect = True
        Me.Panelstock.Visible = True
        Me.Panelstock.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        _list_mid = New System.Collections.Generic.Dictionary(Of String, Boolean)
        initCheckProcess()
        gridStock.DataSource = objDS.Tables(_nametableStock)
        clsDevExpress.AddHyperlinkDynamic(gridStock)
        'MsgBox("Tutu")
    End Sub
    Private Sub btnLoadOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadOrders.Click
        LoadOrders()
    End Sub
    Private Sub LoadOrders()
        Dim sql As String
        '  _DS.Tables("TmpOrderTable").Clear()
        '  _DS.Tables("TmpProductsDVDTable").Clear()

        '_SQLTxt = " SELECT o.orders_id, o.customers_id, o.delivery_country, op.products_id, op.products_dvd as dvd_id, pd.box_id, " & _
        '          " pd.pibox_id, c.customers_language as language_id, op.pick_group, op.pick_boxid " & _
        '           " FROM orders o " & _
        '          " LEFT JOIN orders_products op on op.orders_id = o.orders_id " & _
        '          " LEFT JOIN products_dvd pd on pd.products_id = op.products_id and pd.products_dvdid= op.products_dvd " & _
        '          " LEFT JOIN customers c on c.customers_id = o.customers_id" & _
        '          " WHERE o.orders_status = 1 ORDER BY o.customers_id " 'Ready for Exped


        sql = DvdPostData.clsOdersStatusHistory.GetOrdersAssignPickGroup()

        objDS.Tables(_nametableOrder).Clear()
        DvdPostData.clsConnection.FillDataSet(objDS.Tables(_nametableOrder), sql)
        ViewByProduct = New DataView(objDS.Tables(_nametableOrder), "", "products_id, dvd_id ", DataViewRowState.CurrentRows)

        'Grid1.DataSource = objDS.Tables(_nametableOrder) 'objDS.Tables(TableName).DefaultView
        ' TabControl1.SelectedTabPage = TabResult
    End Sub
    Private Sub btnUser1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick
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
            _Orders_ID = GridView1.GetDataRow(_i)("orders_id")
            _customers_id = GridView1.GetDataRow(_i)("customers_id")
            _products_id = GridView1.GetDataRow(_i)("products_id")
            _dvd_id = GridView1.GetDataRow(_i)("dvd_id")
            _DS = New dsProducts
            _objProductsDVD = New clsProduct_DVD(SessionInfo, _DS, _products_id, _dvd_id)
            isIllimitedAbo = DVDPostBuziness.ClsCustomers.isIllimitedaboByCustomers(_customers_id)
            _objProductsDVD.CancelOrder(isIllimitedAbo, _Orders_ID, _customers_id)

        Next
        Do
            If GridView1.GetSelectedRows.Length = 0 Then Exit Do
            GridView1.DeleteRow(GridView1.GetSelectedRows(0))

        Loop
        MsgBox("Process Complete")
    End Sub
    Private Sub btnUser2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser2.ItemClick
        Dim _Orders_ID As Integer
        Dim _customers_id As Integer
        Dim _products_id As Integer
        Dim _dvd_id As Integer
        Dim objProductDVD As clsProduct_DVD
        Dim _DS As dsProducts
        Dim _i As Integer
        For Each _i In GridView1.GetSelectedRows
            _Orders_ID = GridView1.GetDataRow(_i)("orders_id")
            _customers_id = GridView1.GetDataRow(_i)("customers_id")
            _products_id = GridView1.GetDataRow(_i)("products_id")
            _dvd_id = GridView1.GetDataRow(_i)("dvd_id")
            _DS = New dsProducts
            objProductDVD = New clsProduct_DVD(SessionInfo, _DS, _products_id, _dvd_id)
            objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.BIZARREMENT_PERDU, _
                                                  "Process MID - bizarement perdu", _
                                                  DvdPostData.ClsProducts_dvd_state.state.MID, objProductDVD.INOUT)

        Next
        MsgBox("Process Complete")
    End Sub
    Public Overrides Sub gridview1_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles GridView1.DoubleClick
        Dim _frm As New frmCancelOrder(SessionInfo)
        Dim _Orders_ID As Integer
        Dim _customers_id As Integer
        Dim _products_id As Integer
        Dim _dvd_id As Integer
        Dim _i As Integer = GridView1.FocusedRowHandle
        _Orders_ID = GridView1.GetDataRow(_i)("orders_id")
        _customers_id = GridView1.GetDataRow(_i)("customers_id")
        _products_id = GridView1.GetDataRow(_i)("products_id")
        _dvd_id = GridView1.GetDataRow(_i)("dvd_id")
        _frm.txtOrderID.EditValue = _Orders_ID
        _frm.SearchOrderInfo()
        _frm.ShowDialog(Me)
    End Sub
    Private Sub btnFindBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindBarCode.Click
        _CheckProcess.GenereBarCode()
    End Sub
    'Private Function GetCodeBar(ByVal codebar As String) As clsProduct_DVD
    '    Dim objProductDVD As clsProduct_DVD

    '    objProductDVD = New clsProduct_DVD(SessionInfo, objDS, codebar)
    '    If Not objProductDVD.BarCode.IsBarCodeValid Then
    '        txtINFO.Text = "BAR CODE NON VALIDE  Retry Scan"
    '        MsgBox(txtINFO.Text, MsgBoxStyle.Critical)
    '        txtINFO.Focus()
    '        objProductDVD = Nothing
    '    End If
    '    Return objProductDVD
    'End Function
    ''Private Sub EnableBarCode()
    '    txtBarCode.Text = ""
    '    txtBarCode.Enabled = True
    '    txtBarCode.Focus()
    '    txtBarCode.Refresh()
    '    'DoEvents()

    'End Sub

    ''Private Function ExistAlreadyInBox(ByVal dt As DataTable, ByVal objProductDVD As clsProduct_DVD) As Boolean
    ''    Dim DVD_Row As DataRow
    ''    Dim sort As String = " products_id , products_dvdid" '= " + _objProductDVD.ProductID.ToString + " , " + " products_dvdid = " + _objProductDVD.DVDID.ToString
    ''    Dim view As New DataView(dt, " ", sort, DataViewRowState.CurrentRows)
    ''    Dim rowData As Integer

    ''    rowData = view.Find(New Object() {objProductDVD.ProductsID, objProductDVD.DvdId})
    ''    ' Deja Scanne 
    ''    If rowData <> -1 Then
    ''        txtINFO.Text = "DVD already in this box !!"
    ''        MsgBox(txtINFO.Text, MsgBoxStyle.Critical)
    ''        EnableBarCode()
    ''        Return True
    ''    End If
    ''    Return False
    ''End Function
    Private Sub ProcessIn_ok(ByVal objProductDVD As clsProduct_DVD)
        Dim dtStock As DataTable
        dtStock = objDS.Tables(_nametableStock)

        If objProductDVD.INOUT = DvdPostData.clsProductDvd.INOUT.READYFOREXPEDITION Then
            ' dvd en partance 
            Dim drv As DataRowView
            drv = searchDataRowview(objProductDVD)

            If drv Is Nothing Then
                ' not find dvd Error
                txtINFO.Text = "this dvd is not in the listing Out !!!"


            ElseIf IsDBNull(drv("pick_boxid")) Then
                ' not picking group 
                txtPick_BoxId.Text = "X"
                txtPick_Group.Text = "NO Group"

                txtINFO.Text = "No Pickin Group , click set pickin_group in listing out "


            Else
                txtPick_BoxId.Text = drv("pick_boxid")
                txtPick_Group.Text = drv("pick_group")
                objProductDVD.ChangeStateProductsDVD(objProductDVD.products_dvd_status, _
                                            drv("box_id"), _
                                            drv("pibox_id"), _
                                            "PROCESS MID -> OUT", DvdPostData.ClsProducts_dvd_state.state.MID, objProductDVD.INOUT, drv("pick_boxid"), DvdPostData.clsProductDvd.INOUT.READYFOREXPEDITION)
                _cptOut += 1

            End If
        ElseIf objProductDVD.INOUT = DvdPostData.clsProductDvd.INOUT.OUT Then
            ' dvd deja expedie
            txtINFO.Text = "dvd already expedied !!! check the order for this dvd "

        Else
            'GestionInventaire()
            ' dvd retour stock 
            If dtStock Is Nothing Then
                txtINFO.Text = "please choose one box in the stock !!!!"
            Else
                txtPick_BoxId.Text = txtBoxID.EditValue
                txtPick_Group.Text = "Stock"

                ManageInventory(objProductDVD, dtStock)
            End If
        End If

    End Sub

    Private Sub Pickin_ok(ByVal objProductDVD As clsProduct_DVD)
        If DeleteDvdPickin(objProductDVD) Then
            Dim drv As DataRowView
            drv = searchDataRowview(objProductDVD)

            txtPick_BoxId.Text = drv("pick_boxid")
            txtPick_Group.Text = drv("pick_group")

            objProductDVD.ChangeStateProductsDVD(objProductDVD.products_dvd_status, _
                                        drv("box_id"), _
                                        drv("pibox_id"), _
                                        "PROCESS MID -> OUT", DvdPostData.ClsProducts_dvd_state.state.MID, objProductDVD.INOUT, drv("pick_boxid"), DvdPostData.clsProductDvd.INOUT.READYFOREXPEDITION)
            _cptOut += 1
        Else
            txtINFO.Text = "Error DVD pickin Not found "
        End If

    End Sub
    Private Sub process_Ok()
        ' Dim _NewRow As DataRow
        Dim _DS As New dsProducts
        Dim objProductDVD As clsProduct_DVD
        '  Dim box_id As Integer
        '  Dim pibox_id As Integer
        Dim dtOrdersList As DataTable

        dtOrdersList = objDS.Tables(_nametableOrder)
        If txtINFO.Text <> "" Then
            btnSearchInStock.Focus()
            MsgBox("click unlock button ", MsgBoxStyle.Exclamation)
            _CheckProcess.DisableBarCode()
            Exit Sub
        End If
        If dtOrdersList Is Nothing OrElse dtOrdersList.Rows.Count = 0 Then
            txtINFO.Text = "Load Order Before please !!"
        Else

            objProductDVD = _CheckProcess.GetCodeBar(txtBarCode.Text)
            If objProductDVD Is Nothing Then Return

            txtProducts_id.EditValue = objProductDVD.ProductsID
            txtDVD_ID.EditValue = objProductDVD.DvdId

            If ChkPickin.Checked Then
                Pickin_ok(objProductDVD)
            Else
                ProcessIn_ok(objProductDVD)
            End If

        End If ' load order

        If txtINFO.Text <> "" Then
            _CheckProcess.DisableBarCode()
        Else
            _CheckProcess.EnableBarCode()
        End If

        displaycpt()

    End Sub
    Private Function DeleteDvdPickin(ByVal objProductDVD As clsProduct_DVD) As Boolean
        Dim dv As DataView
        Dim lst_dr As DataRow()
        dv = GridViewPickin.DataSource

        lst_dr = dv.Table.Select("products_id = " & objProductDVD.ProductsID & " and dvd_id = " & objProductDVD.DvdId)
        If lst_dr.Length > 0 Then
            dv.Table.Rows.Remove(lst_dr(0))
            Return True
        Else
            Return False
        End If

    End Function
    Private Function searchDataRowview(ByVal objProductDVD As clsProduct_DVD) As DataRowView
        Dim orderRowIndex As Integer
        Dim drv As DataRowView
        Dim key As String = objProductDVD.ProductsID & "-" & objProductDVD.DvdId
        orderRowIndex = ViewByProduct.Find(New Object() {objProductDVD.ProductsID, objProductDVD.DvdId})
        If orderRowIndex > -1 Then
            drv = ViewByProduct(orderRowIndex)
            Return drv
        Else
            Return Nothing
        End If
    End Function

    Public Sub ManageInventory(ByVal objProductDVD As clsProduct_DVD, ByRef dtStock As DataTable)


        Dim _NewRow As DataRow
        Dim _DS As New dsProducts
        Dim box_id As Integer
        Dim pibox_id As Integer


        Dim cptrefound As Integer
        txtProducts_id.EditValue = objProductDVD.ProductsID
        txtDVD_ID.EditValue = objProductDVD.DvdId

        ' deja dans la liste en memoire representant la boite
        If Not _CheckProcess.ExistAlreadyBox(dtStock, objProductDVD) Then
            ' se trouve dans une autre boite physique dans le stock   
            If Not _CheckProcess.CheckdvdAlreadyInStock(objProductDVD.BoxID) Then
                ' la boite n'est pas pleine 
                If Not _CheckProcess.CheckFullBox(dtStock, txtBoxID.EditValue) Then
                    Dim currentdvd_status As DvdPostData.clsProductDvd.DVDStatus
                    currentdvd_status = objProductDVD.products_dvd_status
                    ' le status du dvd est valide 
                    If _CheckProcess.CheckStatus(currentdvd_status, objProductDVD, False, cptrefound) Then
                        'currentdvd_status = DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK
                        ' pas d'order associe a ce dvd 
                        If _CheckProcess.CheckOrder(objProductDVD) Then

                            box_id = Integer.Parse(txtBoxID.EditValue)
                            pibox_id = DVDPostBuziness.ClsproductsDvd.getFirstPosBox(dtStock, "pibox_id") + 1

                            _NewRow = dtStock.NewRow
                            '  _NewRow.ItemArray = objProductDVD.Products_dvd_row.ItemArray
                            _NewRow("products_id") = objProductDVD.ProductsID
                            _NewRow("products_dvdid") = objProductDVD.DvdId
                            _NewRow("products_dvd_status") = DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK
                            _NewRow("inout") = objProductDVD.INOUT
                            _NewRow("bar_code") = txtBarCode.Text
                            _NewRow("box_id") = txtBoxID.EditValue
                            _NewRow("pibox_id") = DVDPostBuziness.ClsproductsDvd.getFirstPosBox(dtStock, "pibox_id") + 1

                            dtStock.Rows.InsertAt(_NewRow, 0)

                            'objProductDVD.ChangeStateProductsDVD(currentdvd_status, _
                            '                                     _NewRow("box_id"), _
                            '                                     _NewRow("pibox_id"), _
                            '                                     "PROCESS MID Replace in Stock", DvdPostData.ClsProducts_dvd_state.state.MID, objProductDVD.INOUT)

                            objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK, _
                                                               box_id, _
                                                               pibox_id, _
                                                               "PROCESS MID Replace in Stock", DvdPostData.ClsProducts_dvd_state.state.MID, DvdPostData.clsProductDvd.INOUT.IN)

                            '_CheckProcess.RefreshData(dt, box_id)
                            _cptStock = +1
                            If txtINFO.Text <> "" Then
                                _CheckProcess.DisableBarCode()
                            Else
                                _CheckProcess.EnableBarCode()
                            End If

                        End If

                    End If

                End If
            End If
        End If



    End Sub

    Private Sub btnOK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK1.Click
        process_Ok()
    End Sub

    'Private Sub btnOK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK1.Click

    '    Dim dvdInout1 As Boolean = False
    '    Dim _OrderRow As DataRowView
    '    Dim _OrderRowIndex As Integer
    '    Dim _DS As New dsProducts

    '    Dim objProductDVD As clsProduct_DVD
    '    txtINFO.Text = ""

    '    If objDS.Tables(_nametableOrder) Is Nothing OrElse objDS.Tables(_nametableOrder).Rows.Count = 0 Then
    '        txtINFO.Text = "Load Order Before please !!"
    '        MsgBox(txtINFO.Text, MsgBoxStyle.Critical)

    '        Return
    '    End If
    '    If txtBoxID.EditValue Is Nothing OrElse Me.txtBoxID.EditValue = 0 Then
    '        txtINFO.Text = "Choose one box before "
    '        MsgBox(txtINFO.Text, MsgBoxStyle.Critical)

    '        Return
    '    End If

    '    objProductDVD = GetCodeBar(txtBarCode.Text)
    '    If objProductDVD Is Nothing Then Return

    '    txtProducts_id.EditValue = objProductDVD.ProductsID
    '    txtDVD_ID.EditValue = objProductDVD.DvdId

    '    ' return in stock 
    '    ' idem inventaire 
    '    ' idem process IN 
    '    If objProductDVD.INOUT = DvdPostData.clsProductDvd.INOUT.IN Then
    '        If objProductDVD.products_dvd_status <> DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK Then
    '            Dim warning As String
    '            warning = " STATUS ( " & DVDPostTools.clsEnum.getNameStrEnum(objProductDVD.products_dvd_status) & " ) !!"
    '            txtINFO.Text = warning & " ERROR !!"
    '            MsgBox(txtINFO.Text, MsgBoxStyle.Critical)
    '            Return
    '        Else


    '            If _dsStock.Tables(_nametableStock) Is Nothing Then
    '                txtINFO.Text = "please load This box before !!"
    '                MsgBox(txtINFO.Text, MsgBoxStyle.Critical)

    '                Return
    '            End If
    '            If ExistAlreadyInBox(_dsStock.Tables(_nametableStock), objProductDVD) Then
    '                Return
    '            End If
    '            Dim viewInOut As New DataView(_dsStock.Tables(_nametableStock))
    '            'viewInOut.RowFilter = " inout = 1 "

    '            If txtBoxID.EditValue > 0 Then
    '                If viewInOut.Count >= NbrDVDByBox Then
    '                    txtINFO.Text = "Full Box ! Change Box please "
    '                    MsgBox(txtINFO.Text, MsgBoxStyle.Exclamation)
    '                    resetNbrDvd()
    '                    'txtBoxID.EditValue = txtBoxID.EditValue + 1
    '                    Me.loadStock()
    '                    Return
    '                End If
    '            End If

    '            _row = _dsStock.Tables(_nametableStock).NewRow
    '            _row("products_id") = objProductDVD.ProductsID
    '            _row("products_dvdid") = objProductDVD.DvdId
    '            _row("pibox_id") = DVDPostBuziness.ClsproductsDvd.getFirstPosBox(_dsStock.Tables(_nametableStock), "pibox_id") + 1
    '            _row("box_id") = txtBoxID.EditValue
    '            _row("inout") = 1
    '            _dsStock.Tables(_nametableStock).Rows.InsertAt(_row, 0)


    '            objProductDVD.ChangeStateProductsDVD(objProductDVD.products_dvd_status, _
    '                                                   _row("box_id"), _
    '                                                   _row("pibox_id"), _
    '                                                   "PROCESS MID Replace in Stock", DvdPostData.ClsProducts_dvd_state.state.MID, objProductDVD.INOUT)

    '            ' Me.addStockActif(objProductDVD.ProductsID, objProductDVD.DvdId, Me.txtBoxID.EditValue)
    '            txtPick_BoxId.Text = _row("box_id")
    '            txtPick_Group.Text = "Stock"

    '            _cptStock += 1
    '        End If

    '    ElseIf objProductDVD.INOUT = DvdPostData.clsProductDvd.INOUT.OUT Then
    '        txtPick_BoxId.Text = 0
    '        txtPick_Group.Text = "Process In"
    '        MsgBox(txtPick_Group.Text, MsgBoxStyle.Exclamation)

    '    Else
    '        ' objProductDVD.INOUT = DvdPostData.clsProductDvd.INOUT.READYFOREXPEDITION 
    '        Dim key As String = objProductDVD.ProductsID & "-" & objProductDVD.DvdId
    '        _OrderRowIndex = ViewByProduct.Find(New Object() {objProductDVD.ProductsID, objProductDVD.DvdId})
    '        If _OrderRowIndex <> -1 Then
    '            If _list_mid.ContainsKey(key) Then
    '                txtINFO.Text = "already Scan !!"
    '                MsgBox(txtINFO.Text, MsgBoxStyle.Critical)
    '                EnableBarCode()
    '                Return
    '            End If
    '            _OrderRow = ViewByProduct(_OrderRowIndex)
    '            _list_mid.Add(key, True)

    '            If IsDBNull(_OrderRow("pick_boxid")) Then
    '                txtPick_BoxId.Text = "X"
    '                txtPick_Group.Text = "NO Group"
    '                txtINFO.Text = "Click SET PICKING GROUP again"
    '                MsgBox(txtINFO.Text)
    '                Return
    '            Else
    '                txtPick_BoxId.Text = _OrderRow("pick_boxid")
    '                txtPick_Group.Text = _OrderRow("pick_group")
    '                objProductDVD.ChangeStateProductsDVD(objProductDVD.products_dvd_status, _
    '                                                 _OrderRow("box_id"), _
    '                                                 _OrderRow("pibox_id"), _
    '                                                 "PROCESS MID -> OUT", DvdPostData.ClsProducts_dvd_state.state.MID, objProductDVD.INOUT, _OrderRow("pick_boxid"), DvdPostData.clsProductDvd.INOUT.READYFOREXPEDITION)
    '                _cptOut += 1
    '            End If

    '            ' DoEvents()
    '        Else
    '            txtINFO.Text = "Process MID - No Order Found"
    '            MsgBox(txtINFO.Text, MsgBoxStyle.Critical)

    '            Return
    '        End If
    '    End If
    '    displaycpt()
    '    EnableBarCode()
    'End Sub

    Private Sub displaycpt()
        LblCptOut.Text = _cptOut
        LblcptStock.Text = _cptStock
    End Sub
    Private Sub btnSearchInStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchInStock.Click
        If btnUnlock.Visible = True Then Return
        _CheckProcess.RefreshData(objDS.Tables(_nametableStock), txtBoxID.EditValue)
    End Sub

    Private Sub btnResetNbr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetNbr.Click
        If btnUnlock.Visible = True Then Return
        _CheckProcess.resetNumberBox(objDS.Tables(_nametableStock), txtBoxID.EditValue)
    End Sub

    'Public Sub addStockActif(ByVal products_id As Integer, ByVal products_dvdid As Integer, ByVal box_id As Integer)
    '    Dim count As Integer
    '    count = _dsStock.Tables(_nametableStock).Rows.Count

    '    Dim pibox_id As Integer = count

    '    pibox_id = pibox_id + 1

    '    If pibox_id > 20 Then
    '        MsgBox("you must change the box ")
    '        Me.txtBoxID.Text = Me.txtBoxID.EditValue + 1
    '        Me.loadStock()
    '        Exit Sub
    '    End If

    '    _row = _dsStock.Tables("stock").NewRow

    '    _row("products_id") = products_id
    '    _row("products_dvdid") = products_dvdid
    '    _row("pibox_id") = pibox_id
    '    _row("box_id") = box_id

    '    _dsStock.Tables("stock").Rows.Add(_row)

    '    updateDvdInStock(products_id, products_dvdid, pibox_id, box_id)

    'End Sub

    'Private Sub updateDvdInStock(ByVal products_id As Integer, ByVal products_dvdid As Integer, ByVal pibox_id As Integer, ByVal box_id As Integer)
    '    Dim sql As String = " update products_dvd set products_dvd_status = 1, products_id = " & products_id & " , products_dvdid = " & products_dvdid & " , pibox_id = " & pibox_id & " ,box_id = " & box_id & "  " & _
    '                        " where products_dvdid = " & products_dvdid & "  and products_id = " & products_id & " "

    '    DvdPostData.clsConnection.ExecuteNonQuery(sql)

    'End Sub

    'Private Function dvdInout1Exist(ByVal products_id As Integer, ByVal products_dvdid As Integer) As Boolean

    '    Dim sqlExist As String = "select count(*) from products_dvd pd where  products_id = " & products_id & " and products_dvdid = " & products_dvdid & " and pd.inout = 1 "
    '    Return BKGlobal.ExecuteExists(sqlExist)
    'End Function


    Private Sub txtBoxID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBoxID.EditValueChanged
        If btnUnlock.Visible = True Then Return
        _CheckProcess.RefreshData(objDS.Tables(_nametableStock), txtBoxID.EditValue)
        txtBoxID.Focus()
    End Sub

    Private Sub btnLoadPickin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadPickin.Click
        Dim dt As DataTable
        Dim sql As String

        sql = DvdPostData.clsOdersStatusHistory.GetOrdersAssignPickGroup(txtBox_idMin.EditValue, txtBox_idMax.EditValue)
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        GridPickin.DataSource = dt
    End Sub

    Private Sub ChkPickin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPickin.CheckedChanged

        txtBox_idMax.Visible = ChkPickin.Checked
        txtBox_idMin.Visible = ChkPickin.Checked
        GridPickin.Visible = ChkPickin.Checked
        btnLoadPickin.Visible = ChkPickin.Checked
        LblMaxBox_id.Visible = ChkPickin.Checked
        LblMinBox_id.Visible = ChkPickin.Checked

    End Sub
End Class
