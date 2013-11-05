Public Class frmPrintDVDLabels
    Inherits BizzLib.frmBKForm

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
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbProductID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitleSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtyNoCover As DevExpress.XtraEditors.TextEdit
    Friend WithEvents objDS As DVDPost.dsProducts
    Friend WithEvents btnPrintLabels As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFromDVDID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTODVDID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProductsID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabOne As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabMulti As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDVD_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProducts_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBarCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPrintSelected As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colproducts_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvdid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvd_status1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbDVDStatus2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colbox_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpibox_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbar_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrintLabelsMulti As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.cmbProductID = New DevExpress.XtraEditors.LookUpEdit
        Me.objDS = New DVDPost.dsProducts
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtTitleSearch = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtTotalQty = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtQtyNoCover = New DevExpress.XtraEditors.TextEdit
        Me.btnPrintLabels = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtFromDVDID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtTODVDID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtProductsID = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tabOne = New DevExpress.XtraTab.XtraTabPage
        Me.tabMulti = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colproducts_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvdid1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvd_status1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbDVDStatus2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colbox_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpibox_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbar_code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrintSelected = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrintLabelsMulti = New DevExpress.XtraEditors.SimpleButton
        Me.txtDVD_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtProducts_id = New DevExpress.XtraEditors.TextEdit
        Me.txtBarCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtyNoCover.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDVDID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTODVDID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductsID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabOne.SuspendLayout()
        Me.tabMulti.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDVDStatus2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Misc_Bar
        '
        Me.Misc_Bar.DockCol = 5
        '
        'Main_Bar
        '
        Me.Main_Bar.DockCol = 4
        '
        'Misc_Bar2
        '
        Me.Misc_Bar2.DockCol = 3
        '
        'View_Bar
        '
        Me.View_Bar.DockCol = 2
        '
        'QuickSearch_Bar
        '
        Me.QuickSearch_Bar.DockCol = 8
        '
        'DefaultSet_Bar
        '
        Me.DefaultSet_Bar.DockCol = 6
        '
        'Filter_Bar
        '
        Me.Filter_Bar.DockCol = 7
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(416, 24)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        '
        'cmbProductID
        '
        Me.cmbProductID.Location = New System.Drawing.Point(104, 96)
        Me.cmbProductID.Name = "cmbProductID"
        '
        'cmbProductID.Properties
        '
        Me.cmbProductID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProductID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_id", "products_id", 75, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_name", "products_name", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_model", "products_model", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbProductID.Properties.DataSource = Me.objDS.products_description1
        Me.cmbProductID.Properties.DisplayMember = "products_id"
        Me.cmbProductID.Properties.NullText = ""
        Me.cmbProductID.Properties.PopupWidth = 500
        Me.cmbProductID.Properties.ValueMember = "products_id"
        Me.cmbProductID.Size = New System.Drawing.Size(304, 20)
        Me.cmbProductID.TabIndex = 2
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsProducts"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 96)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "Product ID"
        '
        'txtTitleSearch
        '
        Me.txtTitleSearch.Location = New System.Drawing.Point(104, 24)
        Me.txtTitleSearch.Name = "txtTitleSearch"
        Me.txtTitleSearch.Size = New System.Drawing.Size(304, 20)
        Me.txtTitleSearch.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(24, 24)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "Title Like"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(104, 120)
        Me.txtTitle.Name = "txtTitle"
        '
        'txtTitle.Properties
        '
        Me.txtTitle.Properties.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(304, 20)
        Me.txtTitle.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(24, 120)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.TabIndex = 22
        Me.LabelControl3.Text = "Title"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(24, 144)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.TabIndex = 23
        Me.LabelControl4.Text = "Total Qty"
        '
        'txtTotalQty
        '
        Me.txtTotalQty.Location = New System.Drawing.Point(104, 144)
        Me.txtTotalQty.Name = "txtTotalQty"
        '
        'txtTotalQty.Properties
        '
        Me.txtTotalQty.Properties.ReadOnly = True
        Me.txtTotalQty.Size = New System.Drawing.Size(96, 20)
        Me.txtTotalQty.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(208, 144)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(104, 14)
        Me.LabelControl5.TabIndex = 24
        Me.LabelControl5.Text = "Qty with No Cover"
        '
        'txtQtyNoCover
        '
        Me.txtQtyNoCover.Location = New System.Drawing.Point(312, 144)
        Me.txtQtyNoCover.Name = "txtQtyNoCover"
        '
        'txtQtyNoCover.Properties
        '
        Me.txtQtyNoCover.Properties.ReadOnly = True
        Me.txtQtyNoCover.Size = New System.Drawing.Size(96, 20)
        Me.txtQtyNoCover.TabIndex = 6
        '
        'btnPrintLabels
        '
        Me.btnPrintLabels.Location = New System.Drawing.Point(416, 168)
        Me.btnPrintLabels.Name = "btnPrintLabels"
        Me.btnPrintLabels.Size = New System.Drawing.Size(80, 23)
        Me.btnPrintLabels.TabIndex = 9
        Me.btnPrintLabels.Text = "Print Labels"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(24, 168)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.TabIndex = 34
        Me.LabelControl6.Text = "From DVD ID"
        '
        'txtFromDVDID
        '
        Me.txtFromDVDID.Location = New System.Drawing.Point(104, 168)
        Me.txtFromDVDID.Name = "txtFromDVDID"
        '
        'txtFromDVDID.Properties
        '
        Me.txtFromDVDID.Properties.DisplayFormat.FormatString = "N0"
        Me.txtFromDVDID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFromDVDID.Properties.EditFormat.FormatString = "N0"
        Me.txtFromDVDID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFromDVDID.Size = New System.Drawing.Size(96, 20)
        Me.txtFromDVDID.TabIndex = 7
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(232, 168)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.TabIndex = 36
        Me.LabelControl7.Text = "To DVD ID"
        '
        'txtTODVDID
        '
        Me.txtTODVDID.Location = New System.Drawing.Point(312, 168)
        Me.txtTODVDID.Name = "txtTODVDID"
        '
        'txtTODVDID.Properties
        '
        Me.txtTODVDID.Properties.DisplayFormat.FormatString = "N0"
        Me.txtTODVDID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTODVDID.Properties.EditFormat.FormatString = "N0"
        Me.txtTODVDID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTODVDID.Size = New System.Drawing.Size(96, 20)
        Me.txtTODVDID.TabIndex = 8
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(24, 48)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.TabIndex = 38
        Me.LabelControl8.Text = "Product ID"
        '
        'txtProductsID
        '
        Me.txtProductsID.Location = New System.Drawing.Point(104, 48)
        Me.txtProductsID.Name = "txtProductsID"
        '
        'txtProductsID.Properties
        '
        Me.txtProductsID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtProductsID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtProductsID.Size = New System.Drawing.Size(96, 20)
        Me.txtProductsID.TabIndex = 3
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 26)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabOne
        Me.XtraTabControl1.Size = New System.Drawing.Size(1040, 348)
        Me.XtraTabControl1.TabIndex = 39
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabOne, Me.tabMulti})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'tabOne
        '
        Me.tabOne.Controls.Add(Me.LabelControl2)
        Me.tabOne.Controls.Add(Me.txtTitle)
        Me.tabOne.Controls.Add(Me.LabelControl5)
        Me.tabOne.Controls.Add(Me.LabelControl3)
        Me.tabOne.Controls.Add(Me.LabelControl4)
        Me.tabOne.Controls.Add(Me.txtTotalQty)
        Me.tabOne.Controls.Add(Me.cmbProductID)
        Me.tabOne.Controls.Add(Me.txtQtyNoCover)
        Me.tabOne.Controls.Add(Me.btnPrintLabels)
        Me.tabOne.Controls.Add(Me.txtProductsID)
        Me.tabOne.Controls.Add(Me.LabelControl6)
        Me.tabOne.Controls.Add(Me.txtFromDVDID)
        Me.tabOne.Controls.Add(Me.LabelControl7)
        Me.tabOne.Controls.Add(Me.txtTODVDID)
        Me.tabOne.Controls.Add(Me.LabelControl8)
        Me.tabOne.Controls.Add(Me.btnSearch)
        Me.tabOne.Controls.Add(Me.LabelControl1)
        Me.tabOne.Controls.Add(Me.txtTitleSearch)
        Me.tabOne.Name = "tabOne"
        Me.tabOne.Size = New System.Drawing.Size(1031, 317)
        Me.tabOne.Text = "Search ONE Product"
        '
        'tabMulti
        '
        Me.tabMulti.Controls.Add(Me.GridControl2)
        Me.tabMulti.Controls.Add(Me.PanelControl1)
        Me.tabMulti.Name = "tabMulti"
        Me.tabMulti.Size = New System.Drawing.Size(1031, 317)
        Me.tabMulti.Text = "Scan Multiple"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.objDS.products_dvd_stock_2
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'GridControl2.EmbeddedNavigator
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(0, 80)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbDVDStatus2})
        Me.GridControl2.Size = New System.Drawing.Size(1031, 237)
        Me.GridControl2.TabIndex = 33
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colproducts_id1, Me.colproducts_dvdid1, Me.colproducts_dvd_status1, Me.colbox_id1, Me.colpibox_id1, Me.colbar_code})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(867, 345, 208, 191)
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'colproducts_id1
        '
        Me.colproducts_id1.Caption = "products_id"
        Me.colproducts_id1.FieldName = "products_id"
        Me.colproducts_id1.Name = "colproducts_id1"
        Me.colproducts_id1.Visible = True
        Me.colproducts_id1.VisibleIndex = 0
        '
        'colproducts_dvdid1
        '
        Me.colproducts_dvdid1.Caption = "products_dvdid"
        Me.colproducts_dvdid1.FieldName = "products_dvdid"
        Me.colproducts_dvdid1.Name = "colproducts_dvdid1"
        Me.colproducts_dvdid1.Visible = True
        Me.colproducts_dvdid1.VisibleIndex = 1
        '
        'colproducts_dvd_status1
        '
        Me.colproducts_dvd_status1.Caption = "products_dvd_status"
        Me.colproducts_dvd_status1.ColumnEdit = Me.cmbDVDStatus2
        Me.colproducts_dvd_status1.FieldName = "products_dvd_status"
        Me.colproducts_dvd_status1.Name = "colproducts_dvd_status1"
        Me.colproducts_dvd_status1.Visible = True
        Me.colproducts_dvd_status1.VisibleIndex = 2
        '
        'cmbDVDStatus2
        '
        Me.cmbDVDStatus2.AutoHeight = False
        Me.cmbDVDStatus2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDVDStatus2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_dvd_status_id", "products_dvd_status_id", 135, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_dvd_status_name", "products_dvd_status_name", 140, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbDVDStatus2.DataSource = Me.objDS.products_dvd_status
        Me.cmbDVDStatus2.DisplayMember = "products_dvd_status_name"
        Me.cmbDVDStatus2.Name = "cmbDVDStatus2"
        Me.cmbDVDStatus2.NullText = ""
        Me.cmbDVDStatus2.ValueMember = "products_dvd_status_id"
        '
        'colbox_id1
        '
        Me.colbox_id1.Caption = "box_id"
        Me.colbox_id1.FieldName = "box_id"
        Me.colbox_id1.Name = "colbox_id1"
        '
        'colpibox_id1
        '
        Me.colpibox_id1.Caption = "pibox_id"
        Me.colpibox_id1.FieldName = "pibox_id"
        Me.colpibox_id1.Name = "colpibox_id1"
        '
        'colbar_code
        '
        Me.colbar_code.Caption = "bar_code"
        Me.colbar_code.FieldName = "bar_code"
        Me.colbar_code.Name = "colbar_code"
        Me.colbar_code.Visible = True
        Me.colbar_code.VisibleIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnAdd)
        Me.PanelControl1.Controls.Add(Me.btnClear)
        Me.PanelControl1.Controls.Add(Me.btnPrintSelected)
        Me.PanelControl1.Controls.Add(Me.btnPrintLabelsMulti)
        Me.PanelControl1.Controls.Add(Me.txtDVD_ID)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.txtProducts_id)
        Me.PanelControl1.Controls.Add(Me.txtBarCode)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.LabelControl11)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1031, 80)
        Me.PanelControl1.TabIndex = 0
        Me.PanelControl1.Text = "PanelControl1"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(408, 40)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 39
        Me.btnAdd.Text = "Add"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(408, 16)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.TabIndex = 38
        Me.btnClear.Text = "Clear"
        '
        'btnPrintSelected
        '
        Me.btnPrintSelected.Location = New System.Drawing.Point(496, 40)
        Me.btnPrintSelected.Name = "btnPrintSelected"
        Me.btnPrintSelected.Size = New System.Drawing.Size(96, 23)
        Me.btnPrintSelected.TabIndex = 37
        Me.btnPrintSelected.Text = "Print Selected "
        '
        'btnPrintLabelsMulti
        '
        Me.btnPrintLabelsMulti.Location = New System.Drawing.Point(496, 16)
        Me.btnPrintLabelsMulti.Name = "btnPrintLabelsMulti"
        Me.btnPrintLabelsMulti.Size = New System.Drawing.Size(96, 23)
        Me.btnPrintLabelsMulti.TabIndex = 36
        Me.btnPrintLabelsMulti.Text = "Print ALL Labels"
        '
        'txtDVD_ID
        '
        Me.txtDVD_ID.Location = New System.Drawing.Point(304, 40)
        Me.txtDVD_ID.Name = "txtDVD_ID"
        Me.txtDVD_ID.Size = New System.Drawing.Size(96, 20)
        Me.txtDVD_ID.TabIndex = 35
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(224, 40)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.TabIndex = 34
        Me.LabelControl9.Text = "DVD ID"
        '
        'txtProducts_id
        '
        Me.txtProducts_id.Location = New System.Drawing.Point(96, 40)
        Me.txtProducts_id.Name = "txtProducts_id"
        Me.txtProducts_id.Size = New System.Drawing.Size(96, 20)
        Me.txtProducts_id.TabIndex = 33
        '
        'txtBarCode
        '
        Me.txtBarCode.Location = New System.Drawing.Point(96, 16)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(304, 20)
        Me.txtBarCode.TabIndex = 31
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(16, 16)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.TabIndex = 32
        Me.LabelControl10.Text = "BareCode"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(16, 40)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.TabIndex = 30
        Me.LabelControl11.Text = "Product ID"
        '
        'frmPrintDVDLabels
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1040, 374)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmPrintDVDLabels"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtyNoCover.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDVDID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTODVDID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductsID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabOne.ResumeLayout(False)
        Me.tabMulti.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDVDStatus2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim _SQLTxt As String
        If txtTitleSearch.EditValue & "" = "" Then
            _SQLTxt = "SELECT PD.products_id, PD.language_id, PD.products_name , P.products_model as products_model FROM products_description PD " & _
                                    " Left join products P on P.products_id = PD.products_id " & _
                                    " where PD.products_id = " & txtProductsID.EditValue & "  "
        Else
            _SQLTxt = "SELECT PD.products_id, PD.language_id, PD.products_name , P.products_model as products_model FROM products_description PD " & _
                                    " Left join products P on P.products_id = PD.products_id " & _
                                    " where products_name like '%" & txtTitleSearch.EditValue & "%'  "
        End If
        objDS.Tables("products_description1").Clear()
        BKGlobal.Cls1.FillDataSet(objDS.Tables("products_description1"), _SQLTxt)
        cmbProductID.Focus()
        cmbProductID.ShowPopup()
    End Sub

    Private Sub cmbProductID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductID.EditValueChanged
        RefreshDVDInfo()
    End Sub
    Private Sub RefreshDVDInfo()
        Dim _PRow As DataRow
        Dim _SQLTxt As String
        '_row = objDS.Tables("products_description1").Rows.Find(New Object() {cmbProductID.EditValue})
        txtProductsID.EditValue = cmbProductID.EditValue
        _SQLTxt = "SELECT products_id, products_title, products_model, products_quantity, quantity_to_sale, " & _
                  " products_sale_price, if (products_sale_date = '0000-00-00', Null, products_sale_date) as products_sale_date " & _
                  " FROM products where products_id = " & cmbProductID.EditValue
        objDS.Tables("products_combo").Clear()
        BKGlobal.Cls1.FillDataSet(objDS.Tables("products_combo"), _SQLTxt)
        If objDS.Tables("products_combo").Rows.Count = 1 Then
            _PRow = objDS.Tables("products_combo").Rows(0)
        Else
            _PRow = Nothing
        End If
        If Not IsNothing(_PRow) Then
            txtTitle.EditValue = _PRow.Item("products_title")
            'txtSaleDate.EditValue = _PRow.Item("products_sale_date")
            _SQLTxt = "SELECT count(*) from products_dvd where products_id = " & cmbProductID.EditValue
            txtTotalQty.EditValue = BKGlobal.ExecuteCount(_SQLTxt)
            _SQLTxt = "SELECT count(*) from products_dvd where products_id = " & cmbProductID.EditValue & " AND ( cover_box_id = '' or cover_box_id is null)"
            txtQtyNoCover.EditValue = BKGlobal.ExecuteCount(_SQLTxt)
        End If
        '_SQLTxt = "SELECT products_id, products_dvdid, products_dvd_status, cover_box_id, inout, nbr_rotation_in_feesharing, box_id, pibox_id, last_adminby, " & _
        '          " if (dvd_buy_date = '0000-00-00', Null, dvd_buy_date) as dvd_buy_date, " & _
        '          " if (date_lastrented = '0000-00-00', Null, date_lastrented) as date_lastrented, " & _
        '          " if (last_admindate = '0000-00-00', Null, last_admindate) as last_admindate " & _
        '          " FROM products_dvd where products_id = " & cmbProductID.EditValue & _
        '          " ORDER BY products_dvd_status, products_dvdid "  ' & " AND ( cover_box_id is null or cover_box_id = '' )"

        'objDS.Tables("products_dvd").Clear()
        'BKGlobal.Cls1.FillDataSet(objDS.Tables("products_dvd"), _SQLTxt)
    End Sub
    Private Sub btnPrintLabels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintLabels.Click
        Dim _labelRow As DataRow
        Dim _DS As New dsProducts
        Dim _objProducts As New clsProducts(SessionInfo)
        Dim _i As Integer
        If Not IsNumeric(txtFromDVDID.EditValue) Or Not IsNumeric(txtTODVDID.EditValue) Then
            MsgBox("Please select a FROM-TO DVD Id", MsgBoxStyle.Critical)
            Exit Sub
        End If
        For _i = txtFromDVDID.EditValue To txtTODVDID.EditValue
            '_row.Item("bar_code") = barcode(_row.Item("products_id"), _row.Item("products_dvdid"))
            _labelRow = _DS.Tables("products_labels").NewRow
            _labelRow.Item("products_id") = txtProductsID.EditValue
            _labelRow.Item("dvd_id") = _i
            _labelRow.Item("IDStr") = txtProductsID.EditValue & "-" & _i
            _labelRow.Item("bar_code") = _objProducts.barcode(txtProductsID.EditValue, _i)
            _labelRow.Item("Lang") = _objProducts.GetProductLangLabel(txtProductsID.EditValue)
            _DS.Tables("products_labels").Rows.Add(_labelRow)
        Next
        Dim _rpt As New rptDVDLabel
        _rpt.objDS = _DS
        _rpt.DataMember = ""
        _rpt.DataSource = _DS.Tables("products_labels")
        _rpt.ShowPreview()
    End Sub
    Private Sub frmPrintDVDLabels_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _SQLTxt As String
        BKGlobal.Cls1.ExecuteNonQuery("UPDATE products_dvd set last_admindate = '1801-01-01' where last_admindate = '0000-00-00'")
    End Sub


#Region "Multi-Scanning"
    Public Sub BarCode_OK()
        Dim Product_ID As String
        Dim DVD_ID As Integer
        Dim _OLDRow As DataRow
        Dim _NewRow As DataRow
        Dim _DS As New dsProducts
        Dim _view As DataView

        If txtBarCode.Text.Length = 13 Then
            Product_ID = txtBarCode.Text.Substring(3, 6)
            txtProducts_id.Text = Product_ID
            If Not IsNumeric(txtBarCode.Text.Substring(9, 3)) Then
                MsgBox("Use  SHIFT-Lock before scanning", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            DVD_ID = txtBarCode.Text.Substring(9, 3)
            txtDVD_ID.EditValue = DVD_ID
            _view = New DataView(objDS.Tables("products_dvd_stock_2"), "products_id = " & CInt(Product_ID) & " aND products_dvdid = " & _
                  CInt(DVD_ID), "", DataViewRowState.CurrentRows)
            If _view.Count > 0 Then Exit Sub
            Dim _SQLTxt As String = "SELECT PD.products_id, PD.products_dvdid, PD.products_dvd_status, PD.box_id, PD.pibox_id, P.products_model as products_model FROM products_dvd PD " & _
                        " Left join products P on P.products_id = PD.products_id " & _
                        " where PD.products_id = " & CInt(Product_ID) & " AND PD.products_dvdid = " & CInt(DVD_ID)
            BKGlobal.Cls1.FillDataSet(_DS.Tables("products_dvd_stock_2"), _SQLTxt)
            _OLDRow = _DS.Tables("products_dvd_stock_2").Rows(0)
            _NewRow = objDS.Tables("products_dvd_stock_2").NewRow
            '_NewRow.ItemArray = _OLDRow.ItemArray
            _NewRow.Item("products_id") = _OLDRow.Item("products_id")
            _NewRow.Item("products_dvdid") = _OLDRow.Item("products_dvdid")
            _NewRow.Item("bar_code") = txtBarCode.EditValue
            _NewRow.Item("products_dvd_status") = 0
            _NewRow.Item("box_id") = 0
            _NewRow.Item("pibox_id") = 0
            objDS.Tables("products_dvd_stock_2").Rows.Add(_NewRow)
            'txtBarCode.DoValidate()
            txtBarCode.Text = ""
            'txtBarCode.Focus()
            txtBarCode.Refresh()
        End If
    End Sub
    Private Sub txtBarCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBarCode.TextChanged
        BarCode_OK()
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        objDS.Tables("products_dvd_stock_2").Clear()
    End Sub
    Private Sub btnPrintLabelsMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintLabelsMulti.Click
        Dim _row, _labelRow As DataRow
        Dim _DS As New dsProducts
        Dim _objProducts As New clsProducts(SessionInfo)
        For Each _row In objDS.Tables("products_dvd_stock_2").Rows
            '_row.Item("bar_code") = barcode(_row.Item("products_id"), _row.Item("products_dvdid"))
            _labelRow = _DS.Tables("products_labels").NewRow
            _labelRow.Item("products_id") = _row.Item("products_id")
            _labelRow.Item("dvd_id") = _row.Item("products_dvdid")
            _labelRow.Item("IDStr") = _row.Item("products_id") & "-" & _row.Item("products_dvdid")
            _labelRow.Item("bar_code") = _objProducts.barcode(_row.Item("products_id"), _row.Item("products_dvdid"))
            _labelRow.Item("Lang") = _objProducts.GetProductLangLabel(_row.Item("products_id"))
            _DS.Tables("products_labels").Rows.Add(_labelRow)
        Next
        Dim _rpt As New rptDVDLabel
        _rpt.objDS = _DS
        _rpt.DataMember = ""
        _rpt.DataSource = _DS.Tables("products_labels")
        _rpt.ShowPreview()
    End Sub

    Private Sub btnPrintSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintSelected.Click
        Dim _row, _labelRow As DataRow
        Dim _DS As New dsProducts
        Dim _objProducts As New clsProducts(SessionInfo)
        Dim _i As Integer
        For Each _i In GridView2.GetSelectedRows
            _row = GridView2.GetDataRow(_i)
            '_row.Item("bar_code") = barcode(_row.Item("products_id"), _row.Item("products_dvdid"))
            _labelRow = _DS.Tables("products_labels").NewRow
            _labelRow.Item("products_id") = _row.Item("products_id")
            _labelRow.Item("dvd_id") = _row.Item("products_dvdid")
            _labelRow.Item("IDStr") = _row.Item("products_id") & "-" & _row.Item("products_dvdid")
            _labelRow.Item("bar_code") = _objProducts.barcode(_row.Item("products_id"), _row.Item("products_dvdid"))
            _labelRow.Item("Lang") = _objProducts.GetProductLangLabel(_row.Item("products_id"))
            _DS.Tables("products_labels").Rows.Add(_labelRow)
        Next
        Dim _rpt As New rptDVDLabel
        _rpt.objDS = _DS
        _rpt.DataMember = ""
        _rpt.DataSource = _DS.Tables("products_labels")
        _rpt.ShowPreview()

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Product_ID As String
        Dim DVD_ID As Integer
        Dim _OLDRow As DataRow
        Dim _NewRow As DataRow
        Dim _DS As New dsProducts
        Dim _view As DataView

        Product_ID = txtProducts_id.EditValue
        DVD_ID = txtDVD_ID.EditValue

        _view = New DataView(objDS.Tables("products_dvd_stock_2"), "products_id = " & CInt(Product_ID) & " aND products_dvdid = " & _
              CInt(DVD_ID), "", DataViewRowState.CurrentRows)
        If _view.Count > 0 Then Exit Sub
        Dim _SQLTxt As String = "SELECT PD.products_id, PD.products_dvdid, PD.products_dvd_status, PD.box_id, PD.pibox_id, P.products_model as products_model FROM products_dvd PD " & _
                    " Left join products P on P.products_id = PD.products_id " & _
                    " where PD.products_id = " & CInt(Product_ID) & " AND PD.products_dvdid = " & CInt(DVD_ID)
        BKGlobal.Cls1.FillDataSet(_DS.Tables("products_dvd_stock_2"), _SQLTxt)
        If _DS.Tables("products_dvd_stock_2").Rows.Count = 0 Then
            MsgBox("Cannot find this products")
            Exit Sub
        End If
        _OLDRow = _DS.Tables("products_dvd_stock_2").Rows(0)
        _NewRow = objDS.Tables("products_dvd_stock_2").NewRow
        '_NewRow.ItemArray = _OLDRow.ItemArray
        _NewRow.Item("products_id") = _OLDRow.Item("products_id")
        _NewRow.Item("products_dvdid") = _OLDRow.Item("products_dvdid")
        _NewRow.Item("bar_code") = txtBarCode.EditValue
        _NewRow.Item("products_dvd_status") = 0
        _NewRow.Item("box_id") = 0
        _NewRow.Item("pibox_id") = 0
        objDS.Tables("products_dvd_stock_2").Rows.Add(_NewRow)

    End Sub
#End Region

 
End Class
