Public Class frmSuggestion_Browse
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
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkOpenOnly As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BtnViewPurchases As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRunAlgo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnBreakSeries As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnViewSales As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnViewPurchasesSalesProducts As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnviewOrderPurchase As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnViewOrdersClosed As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuggestion_Browse))
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.chkOpenOnly = New DevExpress.XtraEditors.CheckEdit
        Me.btnRunAlgo = New DevExpress.XtraEditors.SimpleButton
        Me.BtnViewPurchases = New DevExpress.XtraEditors.SimpleButton
        Me.BtnBreakSeries = New DevExpress.XtraEditors.SimpleButton
        Me.BtnViewSales = New DevExpress.XtraEditors.SimpleButton
        Me.BtnViewPurchasesSalesProducts = New DevExpress.XtraEditors.SimpleButton
        Me.btnviewOrderPurchase = New DevExpress.XtraEditors.SimpleButton
        Me.BtnViewOrdersClosed = New DevExpress.XtraEditors.SimpleButton
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
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOpenOnly.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TabParameters.Controls.Add(Me.BtnViewOrdersClosed)
        Me.TabParameters.Controls.Add(Me.btnviewOrderPurchase)
        Me.TabParameters.Controls.Add(Me.BtnViewPurchasesSalesProducts)
        Me.TabParameters.Controls.Add(Me.BtnViewSales)
        Me.TabParameters.Controls.Add(Me.BtnBreakSeries)
        Me.TabParameters.Controls.Add(Me.BtnViewPurchases)
        Me.TabParameters.Controls.Add(Me.btnRunAlgo)
        Me.TabParameters.Controls.Add(Me.chkOpenOnly)
        Me.TabParameters.Controls.Add(Me.LabelControl2)
        Me.TabParameters.Controls.Add(Me.LabelControl1)
        Me.TabParameters.Controls.Add(Me.txtToDate)
        Me.TabParameters.Controls.Add(Me.txtFromDate)
        resources.ApplyResources(Me.TabParameters, "TabParameters")
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
        'txtFromDate
        '
        Me.txtFromDate.EditValue = Nothing
        resources.ApplyResources(Me.txtFromDate, "txtFromDate")
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtFromDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtFromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtFromDate, CType(resources.GetObject("txtFromDate.ShowHelp"), Boolean))
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
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, CType(resources.GetObject("LabelControl1.ShowHelp"), Boolean))
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, CType(resources.GetObject("LabelControl2.ShowHelp"), Boolean))
        '
        'chkOpenOnly
        '
        resources.ApplyResources(Me.chkOpenOnly, "chkOpenOnly")
        Me.chkOpenOnly.Name = "chkOpenOnly"
        Me.chkOpenOnly.Properties.Caption = resources.GetString("chkOpenOnly.Properties.Caption")
        Me.chkOpenOnly.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        '
        'btnRunAlgo
        '
        resources.ApplyResources(Me.btnRunAlgo, "btnRunAlgo")
        Me.btnRunAlgo.Name = "btnRunAlgo"
        '
        'BtnViewPurchases
        '
        resources.ApplyResources(Me.BtnViewPurchases, "BtnViewPurchases")
        Me.BtnViewPurchases.Name = "BtnViewPurchases"
        Me.HelpProvider1.SetShowHelp(Me.BtnViewPurchases, CType(resources.GetObject("BtnViewPurchases.ShowHelp"), Boolean))
        '
        'BtnBreakSeries
        '
        resources.ApplyResources(Me.BtnBreakSeries, "BtnBreakSeries")
        Me.BtnBreakSeries.Name = "BtnBreakSeries"
        Me.HelpProvider1.SetShowHelp(Me.BtnBreakSeries, CType(resources.GetObject("BtnBreakSeries.ShowHelp"), Boolean))
        '
        'BtnViewSales
        '
        resources.ApplyResources(Me.BtnViewSales, "BtnViewSales")
        Me.BtnViewSales.Name = "BtnViewSales"
        Me.HelpProvider1.SetShowHelp(Me.BtnViewSales, CType(resources.GetObject("BtnViewSales.ShowHelp"), Boolean))
        '
        'BtnViewPurchasesSalesProducts
        '
        resources.ApplyResources(Me.BtnViewPurchasesSalesProducts, "BtnViewPurchasesSalesProducts")
        Me.BtnViewPurchasesSalesProducts.Name = "BtnViewPurchasesSalesProducts"
        Me.HelpProvider1.SetShowHelp(Me.BtnViewPurchasesSalesProducts, CType(resources.GetObject("BtnViewPurchasesSalesProducts.ShowHelp"), Boolean))
        '
        'btnviewOrderPurchase
        '
        resources.ApplyResources(Me.btnviewOrderPurchase, "btnviewOrderPurchase")
        Me.btnviewOrderPurchase.Name = "btnviewOrderPurchase"
        Me.HelpProvider1.SetShowHelp(Me.btnviewOrderPurchase, CType(resources.GetObject("btnviewOrderPurchase.ShowHelp"), Boolean))
        '
        'BtnViewOrdersClosed
        '
        resources.ApplyResources(Me.BtnViewOrdersClosed, "BtnViewOrdersClosed")
        Me.BtnViewOrdersClosed.Name = "BtnViewOrdersClosed"
        Me.HelpProvider1.SetShowHelp(Me.BtnViewOrdersClosed, CType(resources.GetObject("BtnViewOrdersClosed.ShowHelp"), Boolean))
        '
        'frmSuggestion_Browse
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmSuggestion_Browse"
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
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOpenOnly.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private _ctrlGridControl As PlushBuziness.ClsGridControl

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim menuStrip As New PlushBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        objDS = New dsPur_Sls
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        txtFromDate.EditValue = Today.AddDays(-7)
        txtToDate.EditValue = Today
        'MyBase.TableName = "suggestions"
        'MyBase.IDField = "suggestions_id"
        'MyBase.NameField = "suggestions_id"
        'MyBase.MaintenanceMenuID = -1
        'MyBase.WhereClause = ""
        'MyBase.AutoLoadData = True
        'MyBase.StartUp()
        ' btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        ' btnUser1.Caption = "Set as Viewed"
        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , , False, False, True)
        CurrentDefaultSetID = cmbDefaultList.EditValue
        'btnOK
        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If CurrentDefaultSetID <> 0 Then
            BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
            'LoadDataSet()
            'TabControl1.SelectedTabPage = TabResult
        Else
            'TabControl1.SelectedTabPage = TabParameters
        End If
        TabControl1.SelectedTabPage = TabParameters
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub
    Public Overrides Sub LoadDataSet()
        Dim _SQLTxt As String

        'Clear Table
        Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue) & " 00:00:00"
        Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue) & " 23:59:59"

        objDS.Tables(TableName).Clear()

        _SQLTxt = " SELECT * FROM suggestions s " & _
                  " LEFT JOIN customers c on c.customers_id = s.customers_id " & _
                  " where  s.`customer_date` >= '" & _DateFromTxt & "' and s.`customer_date` <= '" & _DateToTxt & "'"
        If chkOpenOnly.Checked Then
            _SQLTxt = _SQLTxt & " AND suggestion_status = 0 "
        Else

        End If
        PlushData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)
        Dim _View As DataView
        'Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        '_View = New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        'Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
        TabControl1.SelectedTabPage = TabResult
    End Sub
    Private Sub btnUser1_ItemClieck(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick
        Dim _id As Integer
        If GridView1.FocusedRowHandle < 0 Then Exit Sub
        _id = GridView1.GetDataRow(GridView1.FocusedRowHandle)("suggestions_id")
        PlushData.clsConnection.ExecuteNonQuery("update suggestions set suggestion_status = 1 where suggestions_id = " & _id & "")
        GridView1.GetDataRow(GridView1.FocusedRowHandle).Delete()
    End Sub

    Private Sub btnRunAlgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRunAlgo.Click
        Dim cls As New PlushBuziness.ClsPurchaseSale

        cls.CreatePrevisionAchat()
    End Sub
    Private Sub LoadGrid(ByVal dt As DataTable)
        Grid1.DataSource = Nothing
        Grid1.Views(0).PopulateColumns()
        Grid1.DataSource = dt
        readonlyColumn(Grid1.Views(0))
        TabControl1.SelectedTabPage = TabResult
    End Sub
    'Private Sub ButtonGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim products_id As Integer
    '    Dim PurchaseRow As DataRow

    '    PurchaseRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
    '    If PurchaseRow("products_id") IsNot DBNull.Value Then
    '        products_id = PurchaseRow("products_id")
    '    Else
    '        products_id = Nothing
    '    End If

    '    If System.Windows.Forms.MessageBox.Show("would you like order product " & products_id, "orders", Windows.Forms.MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
    '        Dim frm As FrmPurchaseControl = New FrmPurchaseControl()
    '        frm.products_id = products_id
    '        frm.ShowDialog()
    '    End If

    'End Sub

    Private Sub readonlyColumn(ByVal gridview As DevExpress.XtraGrid.Views.Grid.GridView)


        For Each col As DevExpress.XtraGrid.Columns.GridColumn In gridview.Columns
            col.OptionsColumn.AllowEdit = False
            col.OptionsColumn.ReadOnly = False
        Next


    End Sub
    'Private Sub addColumnButton()

    '    Dim btnAddPurchase As New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit


    '    If Grid1.RepositoryItems.Count = 0 Then

    '        btnAddPurchase.AutoHeight = False
    '        ' btnSendIt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
    '        btnAddPurchase.Name = "btnAddPurchase"
    '        btnAddPurchase.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
    '        'btnSendIt.Buttons. 
    '        Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {btnAddPurchase})
    '        AddHandler btnAddPurchase.Click, AddressOf ButtonGrid_Click
    '    Else
    '        btnAddPurchase = Grid1.RepositoryItems(0)
    '    End If

    '    Dim colAddPurchase As New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    '    colAddPurchase.Caption = "Orders"
    '    colAddPurchase.ColumnEdit = btnAddPurchase
    '    colAddPurchase.Name = "colAddPurchase"
    '    colAddPurchase.Visible = True
    '    colAddPurchase.OptionsColumn.ReadOnly = False
    '    colAddPurchase.OptionsColumn.AllowEdit = True
    '    GridView1.OptionsBehavior.Editable = True


    '    GridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {colAddPurchase})
    '    GridView1.Bands(0).Columns.Add(colAddPurchase)
    '    ' Grid1.Views(0).PopulateColumns()
    'End Sub

    Private Sub BtnBreakSeries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBreakSeries.Click
        Dim cls As New PlushBuziness.ClsPurchaseSale
        Dim dt As DataTable

        dt = cls.ViewBreakSeries()
        LoadGrid(dt)
    End Sub
    Private Sub Purchase_click(ByVal sender As Object, ByVal e As System.EventArgs)
        _ctrlGridControl.GridPurchase_click()
    End Sub
    Private Sub openFrmProducts(ByVal products_id As Integer)
        'Dim sing As DVDPostBuziness.clsSingleton = Nothing
        'sing = DVDPostBuziness.clsSingleton.Instance()
        'sing.Products_id = products_id
        Dim frm As New frmDVD_Maint(SessionInfo)
        frm.MdiParent = Me.ParentForm
        frm.Show()
        frm.searchID(products_id)
        frm.Text = "Products"
        'frm.XTabControlProduct.SelectedTabPage = frm.tabFeeSharing
        'frm.Text
    End Sub
    Private Sub Sale_click(ByVal sender As Object, ByVal e As System.EventArgs)


        Dim products_id As Integer
        Dim SaleRow As DataRow

        SaleRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If SaleRow("products_id") IsNot DBNull.Value Then
            products_id = SaleRow("products_id")
            openFrmProducts(products_id)
        Else
            products_id = Nothing
        End If

    End Sub

    Private Sub BtnViewPurchases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewPurchases.Click
        Dim cls As New PlushBuziness.ClsPurchaseSale
        Dim dt As DataTable

        dt = cls.ViewAlgoPurchase()
        GridView1.Columns.Clear()
        LoadGrid(dt)

        _ctrlGridControl = New PlushBuziness.ClsGridControl()
        AddHandler _ctrlGridControl.Purchase_click, AddressOf Purchase_click
        _ctrlGridControl.addColumnButtonOrderPurchase(Grid1, GridView1)
    End Sub


    Private Sub BtnViewSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewSales.Click
        Dim cls As New PlushBuziness.ClsPurchaseSale
        Dim dt As DataTable

        dt = cls.ViewAlgoSale()
        GridView1.Columns.Clear()
        LoadGrid(dt)

        _ctrlGridControl = New PlushBuziness.ClsGridControl()
        AddHandler _ctrlGridControl.Sale_click, AddressOf Sale_click
        _ctrlGridControl.addColumnButtonOrderSale(Grid1, GridView1)
    End Sub

    'Private Sub BtnViewPurchasesSalesProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewPurchasesSalesProducts.Click
    '    Dim cls As New DVDPostBuziness.ClsPurchaseSale
    '    Dim dt As DataTable

    '    dt = cls.ViewAlgoPurchasesSalesByProduct(119368)
    '    LoadGrid(dt)
    'End Sub

    Private Sub btnviewOrderPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewOrderPurchase.Click
        Dim cls As New PlushBuziness.ClsPurchaseSale
        Dim dt As DataTable

        dt = cls.ViewAlgoPurchasesOrderCurrent()
        LoadGrid(dt)
    End Sub

    Private Sub BtnViewOrdersClosed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewOrdersClosed.Click
        Dim cls As New PlushBuziness.ClsPurchaseSale
        Dim dt As DataTable

        dt = cls.ViewAlgoPurchasesOrderClosedCurrent()
        LoadGrid(dt)
    End Sub
End Class
