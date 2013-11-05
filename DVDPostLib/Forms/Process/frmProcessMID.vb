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
    Friend WithEvents GridStock As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewStock As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panelstock As System.Windows.Forms.Panel
    Friend WithEvents LabelStock As System.Windows.Forms.Label
    Friend WithEvents btnSearchInStock As System.Windows.Forms.Button
    Friend WithEvents LabelBoxID As System.Windows.Forms.Label
    Friend WithEvents txtBoxID As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnResetNbr As System.Windows.Forms.Button
    Friend WithEvents txtINFO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkAllDVD As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtPick_Group As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcessMID))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
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
        Me.GridStock = New DevExpress.XtraGrid.GridControl
        Me.GridViewStock = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panelstock = New System.Windows.Forms.Panel
        Me.chkAllDVD = New DevExpress.XtraEditors.CheckEdit
        Me.btnResetNbr = New System.Windows.Forms.Button
        Me.txtBoxID = New DevExpress.XtraEditors.SpinEdit
        Me.LabelBoxID = New System.Windows.Forms.Label
        Me.btnSearchInStock = New System.Windows.Forms.Button
        Me.LabelStock = New System.Windows.Forms.Label
        Me.txtINFO = New DevExpress.XtraEditors.TextEdit
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
        CType(Me.GridStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstock.SuspendLayout()
        CType(Me.chkAllDVD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtINFO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GridStock
        '
        resources.ApplyResources(Me.GridStock, "GridStock")
        Me.GridStock.EmbeddedNavigator.Name = ""
        Me.GridStock.FormsUseDefaultLookAndFeel = False
        GridLevelNode1.RelationName = "Level1"
        Me.GridStock.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridStock.MainView = Me.GridViewStock
        Me.GridStock.Name = "GridStock"
        Me.GridStock.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewStock})
        '
        'GridViewStock
        '
        Me.GridViewStock.GridControl = Me.GridStock
        Me.GridViewStock.Name = "GridViewStock"
        '
        'Panelstock
        '
        resources.ApplyResources(Me.Panelstock, "Panelstock")
        Me.Panelstock.Controls.Add(Me.chkAllDVD)
        Me.Panelstock.Controls.Add(Me.btnResetNbr)
        Me.Panelstock.Controls.Add(Me.txtBoxID)
        Me.Panelstock.Controls.Add(Me.LabelBoxID)
        Me.Panelstock.Controls.Add(Me.btnSearchInStock)
        Me.Panelstock.Controls.Add(Me.LabelStock)
        Me.Panelstock.Controls.Add(Me.GridStock)
        Me.Panelstock.Name = "Panelstock"
        '
        'chkAllDVD
        '
        resources.ApplyResources(Me.chkAllDVD, "chkAllDVD")
        Me.chkAllDVD.Name = "chkAllDVD"
        Me.chkAllDVD.Properties.Caption = resources.GetString("chkAllDVD.Properties.Caption")
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
        resources.ApplyResources(Me.txtBoxID, "txtBoxID")
        Me.txtBoxID.Name = "txtBoxID"
        Me.txtBoxID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtBoxID.Properties.DisplayFormat.FormatString = "N0"
        Me.txtBoxID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBoxID.Properties.EditFormat.FormatString = "N0"
        Me.txtBoxID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'LabelBoxID
        '
        resources.ApplyResources(Me.LabelBoxID, "LabelBoxID")
        Me.LabelBoxID.Name = "LabelBoxID"
        '
        'btnSearchInStock
        '
        resources.ApplyResources(Me.btnSearchInStock, "btnSearchInStock")
        Me.btnSearchInStock.Name = "btnSearchInStock"
        Me.btnSearchInStock.UseVisualStyleBackColor = True
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
        CType(Me.GridStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstock.ResumeLayout(False)
        Me.Panelstock.PerformLayout()
        CType(Me.chkAllDVD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtINFO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "
    Dim _DS As New DataSet
    Dim _dsStock As New DataSet
    Dim ViewByProduct As DataView
    Dim _row As DataRow
    Private NbrDVDByBox As Int16 = 20
    Dim _list_mid As System.Collections.Generic.Dictionary(Of String, Boolean)

    Dim _nametable As String = "products_dvd_stock_1"
    Dim _nametableStock As String = "stock"
    Dim _nametableOrder As String = "orders_out_view1"

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip
        GridStock.ContextMenuStrip = menuStrip


        _DS.Tables.Add("TmpOrderTable")
        _DS.Tables.Add("TmpProductsDVDTable")
        _dsStock.Tables.Add(_nametableStock)
        objDS = New dsProducts
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
        'MsgBox("Tutu")
    End Sub
    Private Sub btnLoadOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadOrders.Click
        LoadOrders()
    End Sub
    Private Sub LoadOrders()
        Dim _SQLTxt As String
        _DS.Tables("TmpOrderTable").Clear()
        _DS.Tables("TmpProductsDVDTable").Clear()

        _SQLTxt = " SELECT o.orders_id, o.customers_id, o.delivery_country, op.products_id, op.products_dvd as dvd_id, pd.box_id, " & _
                  " pd.pibox_id, c.customers_language as language_id, op.pick_group, op.pick_boxid " & _
                  " FROM orders o " & _
                  " LEFT JOIN orders_products op on op.orders_id = o.orders_id " & _
                  " LEFT JOIN products_dvd pd on pd.products_id = op.products_id and pd.products_dvdid= op.products_dvd " & _
                  " LEFT JOIN customers c on c.customers_id = o.customers_id" & _
                  " WHERE o.orders_status = 1 ORDER BY o.customers_id " 'Ready for Exped

        objDS.Tables(_nametableOrder).Clear()
        DvdPostData.clsConnection.FillDataSet(objDS.Tables(_nametableOrder), _SQLTxt)
        ViewByProduct = New DataView(objDS.Tables(_nametableOrder), "", "products_id, dvd_id ", DataViewRowState.CurrentRows)

        ' Grid1.DataSource = objDS.Tables(_nametableOrder) 'objDS.Tables(TableName).DefaultView
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

        For Each _i In GridView1.GetSelectedRows
            _Orders_ID = GridView1.GetDataRow(_i)("orders_id")
            _customers_id = GridView1.GetDataRow(_i)("customers_id")
            _products_id = GridView1.GetDataRow(_i)("products_id")
            _dvd_id = GridView1.GetDataRow(_i)("dvd_id")
            _DS = New dsProducts
            _objProductsDVD = New clsProduct_DVD(SessionInfo, _DS, _products_id, _dvd_id)
            _objProductsDVD.CancelOrder(_Orders_ID, _customers_id)

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
                                                  DvdPostData.ClsProducts_dvd_state.state.MID)

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
        Dim _productsId As Integer
        Dim _dvdId As Integer
        Dim _objProdDVD As clsProduct_DVD
        Dim _objds As New dsProducts
        txtBarCode.Text.Trim()
        If txtBarCode.Text.IndexOf("-") <> -1 Then
            _productsId = txtBarCode.Text.Substring(0, txtBarCode.Text.IndexOf("-"))
            _dvdId = txtBarCode.Text.Substring(txtBarCode.Text.IndexOf("-") + 1)
            _objProdDVD = New clsProduct_DVD(SessionInfo, _objds, _productsId, _dvdId)
            If _objProdDVD.BarCode.IsBarCodeValid Then
                txtBarCode.EditValue = _objProdDVD.BarCode.Barcode
                txtBarCode.Refresh()
            Else
            End If
        End If
    End Sub
    Private Function GetCodeBar(ByVal codebar As String) As clsProduct_DVD
        Dim objProductDVD As clsProduct_DVD

        objProductDVD = New clsProduct_DVD(SessionInfo, objDS, codebar)
        If Not objProductDVD.BarCode.IsBarCodeValid Then
            txtINFO.Text = "BAR CODE NON VALIDE  Retry Scan"
            MsgBox(txtINFO.Text, MsgBoxStyle.Critical)
            txtINFO.Focus()
            objProductDVD = Nothing
        End If
        Return objProductDVD
    End Function
    Private Sub EnableBarCode()
        txtBarCode.Text = ""
        txtBarCode.Enabled = True
        txtBarCode.Focus()
        txtBarCode.Refresh()
        'DoEvents()

    End Sub

    Private Function ExistAlreadyInBox(ByVal dt As DataTable, ByVal objProductDVD As clsProduct_DVD) As Boolean
        Dim DVD_Row As DataRow
        Dim sort As String = " products_id , products_dvdid" '= " + _objProductDVD.ProductID.ToString + " , " + " products_dvdid = " + _objProductDVD.DVDID.ToString
        Dim view As New DataView(dt, " ", sort, DataViewRowState.CurrentRows)
        Dim rowData As Integer

        rowData = view.Find(New Object() {objProductDVD.ProductsID, objProductDVD.DvdId})
        ' Deja Scanne 
        If rowData <> -1 Then
            txtINFO.Text = "DVD already in this box !!"
            MsgBox(txtINFO.Text, MsgBoxStyle.Critical)
            EnableBarCode()
            Return True
        End If
        Return False
    End Function

    Private Sub btnOK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK1.Click

        Dim dvdInout1 As Boolean = False
        Dim _OrderRow As DataRowView
        Dim _OrderRowIndex As Integer
        Dim _DS As New dsProducts

        Dim objProductDVD As clsProduct_DVD
        txtINFO.Text = ""

        If objDS.Tables(_nametableOrder) Is Nothing OrElse objDS.Tables(_nametableOrder).Rows.Count = 0 Then
            txtINFO.Text = "Load Order Before please !!"
            MsgBox(txtINFO.Text, MsgBoxStyle.Critical)

            Return
        End If
        If txtBoxID.EditValue Is Nothing OrElse Me.txtBoxID.EditValue = 0 Then
            txtINFO.Text = "Choose one box before "
            MsgBox(txtINFO.Text, MsgBoxStyle.Critical)

            Return
        End If

        objProductDVD = GetCodeBar(txtBarCode.Text)
        If objProductDVD Is Nothing Then Return

        txtProducts_id.EditValue = objProductDVD.ProductsID
        txtDVD_ID.EditValue = objProductDVD.DvdId

        ' return in stock 
        ' idem inventaire 
        ' idem process IN 
        If objProductDVD.INOUT = DvdPostData.clsProductDvd.INOUT.IN Then
            If objProductDVD.products_dvd_status <> DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK Then
                Dim warning As String
                warning = " STATUS ( " & DVDPostTools.clsEnum.getNameStrEnum(objProductDVD.products_dvd_status) & " ) !!"
                txtINFO.Text = warning & " ERROR !!"
                MsgBox(txtINFO.Text, MsgBoxStyle.Critical)

                Return
            Else


                If _dsStock.Tables(_nametableStock) Is Nothing Then
                    txtINFO.Text = "please load This box before !!"
                    MsgBox(txtINFO.Text, MsgBoxStyle.Critical)

                    Return
                End If
                If ExistAlreadyInBox(_dsStock.Tables(_nametableStock), objProductDVD) Then
                    Return
                End If
                Dim viewInOut As New DataView(_dsStock.Tables(_nametableStock))
                viewInOut.RowFilter = " inout = 1 "

                If viewInOut.Count >= NbrDVDByBox Then
                    txtINFO.Text = "Full Box ! Change Box please "
                    MsgBox(txtINFO.Text, MsgBoxStyle.Exclamation)
                    resetNbrDvd()
                    txtBoxID.EditValue = txtBoxID.EditValue + 1
                    Me.loadStock()
                    EnableBarCode()
                    Return
                End If


                _row = _dsStock.Tables(_nametableStock).NewRow
                _row("products_id") = objProductDVD.ProductsID
                _row("products_dvdid") = objProductDVD.DvdId
                _row("pibox_id") = DVDPostBuziness.ClsproductsDvd.getLastPosBox(_dsStock.Tables(_nametableStock), "pibox_id") + 1
                _row("box_id") = txtBoxID.EditValue
                _row("inout") = 1
                _dsStock.Tables(_nametableStock).Rows.Add(_row)


                objProductDVD.ChangeStateProductsDVD(objProductDVD.products_dvd_status, _
                                                       _row("box_id"), _
                                                       _row("pibox_id"), _
                                                       "PROCESS MID Replace in Stock", DvdPostData.ClsProducts_dvd_state.state.MID)

                ' Me.addStockActif(objProductDVD.ProductsID, objProductDVD.DvdId, Me.txtBoxID.EditValue)
                txtPick_BoxId.Text = _row("box_id")
                txtPick_Group.Text = "Stock"
            End If

        ElseIf objProductDVD.INOUT = DvdPostData.clsProductDvd.INOUT.OUT Then
            txtPick_BoxId.Text = 0
            txtPick_Group.Text = "Process In"
            MsgBox(txtPick_Group.Text, MsgBoxStyle.Exclamation)

        Else
            ' objProductDVD.INOUT = DvdPostData.clsProductDvd.INOUT.READYFOREXPEDITION 
            Dim key As String = objProductDVD.ProductsID & "-" & objProductDVD.DvdId
            _OrderRowIndex = ViewByProduct.Find(New Object() {objProductDVD.ProductsID, objProductDVD.DvdId})
            If _OrderRowIndex <> -1 Then
                If _list_mid.ContainsKey(key) Then
                    txtINFO.Text = "already Scan !!"
                    MsgBox(txtINFO.Text, MsgBoxStyle.Critical)
                    EnableBarCode()
                    Return
                End If
                _OrderRow = ViewByProduct(_OrderRowIndex)
                _list_mid.Add(key, True)

                If IsDBNull(_OrderRow("pick_boxid")) Then
                    txtPick_BoxId.Text = "X"
                    txtPick_Group.Text = "NO Group"
                    txtINFO.Text = "Click SET PICKING GROUP again"
                    MsgBox(txtINFO.Text)
                    Return
                Else
                    txtPick_BoxId.Text = _OrderRow("pick_boxid")
                    txtPick_Group.Text = _OrderRow("pick_group")
                End If

                ' DoEvents()
            Else
                txtINFO.Text = "Process MID - No Order Found"
                MsgBox(txtINFO.Text, MsgBoxStyle.Critical)

                Return
            End If
        End If

        EnableBarCode()
    End Sub

    Private Sub btnSearchInStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchInStock.Click
        Me.loadStock()
    End Sub

    Private Sub btnResetNbr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetNbr.Click
        resetNbrDvd()
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

    Private Sub updateDvdInStock(ByVal products_id As Integer, ByVal products_dvdid As Integer, ByVal pibox_id As Integer, ByVal box_id As Integer)
        Dim sql As String = " update products_dvd set products_dvd_status = 1, products_id = " & products_id & " , products_dvdid = " & products_dvdid & " , pibox_id = " & pibox_id & " ,box_id = " & box_id & "  " & _
                            " where products_dvdid = " & products_dvdid & "  and products_id = " & products_id & " "

        DvdPostData.clsConnection.ExecuteNonQuery(sql)

    End Sub

    Private Function dvdInout1Exist(ByVal products_id As Integer, ByVal products_dvdid As Integer) As Boolean

        Dim sqlExist As String = "select count(*) from products_dvd pd where  products_id = " & products_id & " and products_dvdid = " & products_dvdid & " and pd.inout = 1 "
        Return BKGlobal.ExecuteExists(sqlExist)
    End Function

    Private Sub loadStock()
        _dsStock.Tables(_nametableStock).Clear()
        Dim sql As String
        Dim param As String = ""
        If Not chkAllDVD.Checked Then
            param = " and pd.inout = 1 and  products_dvd_status = 1"
        End If

        sql = "select products_id , products_dvdid , pibox_id ,box_id,pd.inout from products_dvd pd " & _
          " where box_id = " & Me.txtBoxID.EditValue & param & " order by pibox_id asc"

        DvdPostData.clsConnection.FillDataSet(_dsStock.Tables(_nametableStock), sql)
        Me.GridStock.DataSource = _dsStock.Tables(_nametableStock)
    End Sub

    Private Sub resetNbrDvd()
        DVDPostBuziness.ClsproductsDvd.resetposinbox(_dsStock.Tables(_nametableStock))
        loadStock()
    End Sub

End Class
