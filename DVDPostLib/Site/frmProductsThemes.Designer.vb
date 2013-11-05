<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductsThemes
    Inherits BizzLib.frmBKForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductsThemes))
        Me.gridListedProducts = New DevExpress.XtraGrid.GridControl
        Me.gridViewListedProducts = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcProducts_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcproducts_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcOrder = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcTheme = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repositoryCmbTheme = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.GridProductsDVD = New DevExpress.XtraGrid.GridControl
        Me.GridViewProductsDVD = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colproducts_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_model = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gpSearch = New DevExpress.XtraEditors.GroupControl
        Me.txtSearchProduct_id = New DevExpress.XtraEditors.TextEdit
        Me.lblProducts_id = New DevExpress.XtraEditors.LabelControl
        Me.txtSearchImdb_id = New DevExpress.XtraEditors.TextEdit
        Me.lblTitleProduct = New DevExpress.XtraEditors.LabelControl
        Me.lblImdb_id = New DevExpress.XtraEditors.LabelControl
        Me.txtTitleSearch = New DevExpress.XtraEditors.TextEdit
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.GPSearchProductTheme = New DevExpress.XtraEditors.GroupControl
        Me.btnLoad = New DevExpress.XtraEditors.SimpleButton
        Me.cmbThemeTop = New DevExpress.XtraEditors.LookUpEdit
        Me.lblThemeTop = New DevExpress.XtraEditors.LabelControl
        Me.cmbKind = New DevExpress.XtraEditors.LookUpEdit
        Me.lblKind = New DevExpress.XtraEditors.LabelControl
        Me.cmbLanguage = New DevExpress.XtraEditors.LookUpEdit
        Me.lblLanguage = New DevExpress.XtraEditors.LabelControl
        Me.pnlProductsList = New DevExpress.XtraEditors.PanelControl
        Me.gpProductsList = New DevExpress.XtraEditors.GroupControl
        Me.GPMoveProduct = New DevExpress.XtraEditors.GroupControl
        Me.BtnOrderDown = New DevExpress.XtraEditors.SimpleButton
        Me.Icones = New DevExpress.Utils.ImageCollection(Me.components)
        Me.BtnAddProduct = New DevExpress.XtraEditors.SimpleButton
        Me.BtnOrderUp = New DevExpress.XtraEditors.SimpleButton
        Me.BtnRemoveProduct = New DevExpress.XtraEditors.SimpleButton
        Me.cmbKindEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbStyle = New DevExpress.XtraEditors.LookUpEdit
        Me.lblStyle = New DevExpress.XtraEditors.LabelControl
        Me.cmbThemeEventEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.lblThemeEventEdit = New DevExpress.XtraEditors.LabelControl
        Me.lblKindEdit = New DevExpress.XtraEditors.LabelControl
        Me.txtUpdateDate = New DevExpress.XtraEditors.TextEdit
        Me.lblUpdateDate = New DevExpress.XtraEditors.LabelControl
        Me.txtCreateDate = New DevExpress.XtraEditors.TextEdit
        Me.lblDateCreate = New DevExpress.XtraEditors.LabelControl
        Me.chkStatus = New DevExpress.XtraEditors.CheckEdit
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl
        Me.txtHomePage = New DevExpress.XtraEditors.TextEdit
        Me.lblHomePage = New DevExpress.XtraEditors.LabelControl
        Me.TxtDescription = New DevExpress.XtraEditors.TextEdit
        Me.lblDescription = New DevExpress.XtraEditors.LabelControl
        Me.lblId = New DevExpress.XtraEditors.LabelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSaveTheme = New DevExpress.XtraEditors.SimpleButton
        Me.btnEditTheme = New DevExpress.XtraEditors.SimpleButton
        Me.btnNewTheme_edit = New DevExpress.XtraEditors.SimpleButton
        Me.TxtEventThemeId_edit = New DevExpress.XtraEditors.TextEdit
        Me.txtTitleEdit = New DevExpress.XtraEditors.TextEdit
        Me.lblTitleEdit = New DevExpress.XtraEditors.LabelControl
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridListedProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewListedProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryCmbTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GridProductsDVD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewProductsDVD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpSearch.SuspendLayout()
        CType(Me.txtSearchProduct_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearchImdb_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GPSearchProductTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPSearchProductTheme.SuspendLayout()
        CType(Me.cmbThemeTop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlProductsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProductsList.SuspendLayout()
        CType(Me.gpProductsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpProductsList.SuspendLayout()
        CType(Me.GPMoveProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPMoveProduct.SuspendLayout()
        CType(Me.Icones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbKindEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbThemeEventEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUpdateDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreateDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHomePage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEventThemeId_edit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridListedProducts
        '
        Me.gridListedProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridListedProducts.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.gridListedProducts.EmbeddedNavigator.Name = ""
        Me.gridListedProducts.FormsUseDefaultLookAndFeel = False
        Me.gridListedProducts.Location = New System.Drawing.Point(2, 22)
        Me.gridListedProducts.MainView = Me.gridViewListedProducts
        Me.gridListedProducts.Margin = New System.Windows.Forms.Padding(4)
        Me.gridListedProducts.Name = "gridListedProducts"
        Me.gridListedProducts.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryCmbTheme})
        Me.gridListedProducts.Size = New System.Drawing.Size(785, 294)
        Me.gridListedProducts.TabIndex = 4
        Me.gridListedProducts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewListedProducts})
        '
        'gridViewListedProducts
        '
        Me.gridViewListedProducts.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcProducts_name, Me.gcproducts_id, Me.gcOrder, Me.gcTheme})
        Me.gridViewListedProducts.GridControl = Me.gridListedProducts
        Me.gridViewListedProducts.Name = "gridViewListedProducts"
        Me.gridViewListedProducts.OptionsView.ShowFooter = True
        '
        'gcProducts_name
        '
        Me.gcProducts_name.Caption = "Title"
        Me.gcProducts_name.FieldName = "products_name"
        Me.gcProducts_name.Name = "gcProducts_name"
        Me.gcProducts_name.Visible = True
        Me.gcProducts_name.VisibleIndex = 0
        Me.gcProducts_name.Width = 136
        '
        'gcproducts_id
        '
        Me.gcproducts_id.Caption = "products_id"
        Me.gcproducts_id.FieldName = "product_id"
        Me.gcproducts_id.Name = "gcproducts_id"
        Me.gcproducts_id.Visible = True
        Me.gcproducts_id.VisibleIndex = 1
        Me.gcproducts_id.Width = 136
        '
        'gcOrder
        '
        Me.gcOrder.Caption = "order"
        Me.gcOrder.FieldName = "order"
        Me.gcOrder.Name = "gcOrder"
        Me.gcOrder.Visible = True
        Me.gcOrder.VisibleIndex = 2
        Me.gcOrder.Width = 83
        '
        'gcTheme
        '
        Me.gcTheme.Caption = "theme_event"
        Me.gcTheme.FieldName = "theme_event"
        Me.gcTheme.Name = "gcTheme"
        Me.gcTheme.Visible = True
        Me.gcTheme.VisibleIndex = 3
        Me.gcTheme.Width = 192
        '
        'repositoryCmbTheme
        '
        Me.repositoryCmbTheme.AutoHeight = False
        Me.repositoryCmbTheme.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryCmbTheme.DisplayMember = "name"
        Me.repositoryCmbTheme.Name = "repositoryCmbTheme"
        Me.repositoryCmbTheme.NullText = ""
        Me.repositoryCmbTheme.ValueMember = "id"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 35)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridProductsDVD)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.gpSearch)
        Me.SplitContainerControl1.Panel1.Text = "Products"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GPSearchProductTheme)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.pnlProductsList)
        Me.SplitContainerControl1.Panel2.Text = "Products_Theme"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1547, 526)
        Me.SplitContainerControl1.SplitterPosition = 535
        Me.SplitContainerControl1.TabIndex = 7
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GridProductsDVD
        '
        Me.GridProductsDVD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridProductsDVD.EmbeddedNavigator.Name = ""
        Me.GridProductsDVD.FormsUseDefaultLookAndFeel = False
        Me.GridProductsDVD.Location = New System.Drawing.Point(0, 136)
        Me.GridProductsDVD.MainView = Me.GridViewProductsDVD
        Me.GridProductsDVD.Name = "GridProductsDVD"
        Me.GridProductsDVD.Size = New System.Drawing.Size(531, 386)
        Me.GridProductsDVD.TabIndex = 18
        Me.GridProductsDVD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewProductsDVD})
        '
        'GridViewProductsDVD
        '
        Me.GridViewProductsDVD.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridViewProductsDVD.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colproducts_id, Me.colproducts_name, Me.colproducts_model})
        Me.GridViewProductsDVD.GridControl = Me.GridProductsDVD
        Me.GridViewProductsDVD.Name = "GridViewProductsDVD"
        Me.GridViewProductsDVD.OptionsBehavior.Editable = False
        Me.GridViewProductsDVD.OptionsView.ShowAutoFilterRow = True
        Me.GridViewProductsDVD.OptionsView.ShowBands = False
        Me.GridViewProductsDVD.OptionsView.ShowFooter = True
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colproducts_id)
        Me.GridBand1.Columns.Add(Me.colproducts_name)
        Me.GridBand1.Columns.Add(Me.colproducts_model)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 659
        '
        'colproducts_id
        '
        Me.colproducts_id.Caption = "products_id"
        Me.colproducts_id.FieldName = "products_id"
        Me.colproducts_id.Name = "colproducts_id"
        Me.colproducts_id.Visible = True
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
        'gpSearch
        '
        Me.gpSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.gpSearch.Controls.Add(Me.txtSearchProduct_id)
        Me.gpSearch.Controls.Add(Me.lblProducts_id)
        Me.gpSearch.Controls.Add(Me.txtSearchImdb_id)
        Me.gpSearch.Controls.Add(Me.lblTitleProduct)
        Me.gpSearch.Controls.Add(Me.lblImdb_id)
        Me.gpSearch.Controls.Add(Me.txtTitleSearch)
        Me.gpSearch.Controls.Add(Me.btnSearch)
        Me.gpSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpSearch.Location = New System.Drawing.Point(0, 0)
        Me.gpSearch.Name = "gpSearch"
        Me.gpSearch.Size = New System.Drawing.Size(531, 136)
        Me.gpSearch.TabIndex = 17
        Me.gpSearch.Text = "Search"
        '
        'txtSearchProduct_id
        '
        Me.txtSearchProduct_id.Location = New System.Drawing.Point(85, 25)
        Me.txtSearchProduct_id.Name = "txtSearchProduct_id"
        Me.txtSearchProduct_id.Size = New System.Drawing.Size(134, 22)
        Me.txtSearchProduct_id.TabIndex = 18
        '
        'lblProducts_id
        '
        Me.lblProducts_id.Location = New System.Drawing.Point(12, 28)
        Me.lblProducts_id.Name = "lblProducts_id"
        Me.lblProducts_id.Size = New System.Drawing.Size(59, 16)
        Me.lblProducts_id.TabIndex = 17
        Me.lblProducts_id.Text = "Product ID"
        '
        'txtSearchImdb_id
        '
        Me.txtSearchImdb_id.Location = New System.Drawing.Point(85, 94)
        Me.txtSearchImdb_id.Name = "txtSearchImdb_id"
        Me.txtSearchImdb_id.Size = New System.Drawing.Size(134, 22)
        Me.txtSearchImdb_id.TabIndex = 16
        '
        'lblTitleProduct
        '
        Me.lblTitleProduct.Location = New System.Drawing.Point(12, 64)
        Me.lblTitleProduct.Name = "lblTitleProduct"
        Me.lblTitleProduct.Size = New System.Drawing.Size(67, 16)
        Me.lblTitleProduct.TabIndex = 12
        Me.lblTitleProduct.Text = "Part of Title"
        '
        'lblImdb_id
        '
        Me.lblImdb_id.Location = New System.Drawing.Point(12, 97)
        Me.lblImdb_id.Name = "lblImdb_id"
        Me.lblImdb_id.Size = New System.Drawing.Size(45, 16)
        Me.lblImdb_id.TabIndex = 15
        Me.lblImdb_id.Text = "Imdb ID"
        '
        'txtTitleSearch
        '
        Me.txtTitleSearch.Location = New System.Drawing.Point(85, 61)
        Me.txtTitleSearch.Name = "txtTitleSearch"
        Me.txtTitleSearch.Size = New System.Drawing.Size(329, 22)
        Me.txtTitleSearch.TabIndex = 13
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(283, 89)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(131, 37)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Search"
        '
        'GPSearchProductTheme
        '
        Me.GPSearchProductTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GPSearchProductTheme.Controls.Add(Me.btnLoad)
        Me.GPSearchProductTheme.Controls.Add(Me.cmbThemeTop)
        Me.GPSearchProductTheme.Controls.Add(Me.lblThemeTop)
        Me.GPSearchProductTheme.Controls.Add(Me.cmbKind)
        Me.GPSearchProductTheme.Controls.Add(Me.lblKind)
        Me.GPSearchProductTheme.Controls.Add(Me.cmbLanguage)
        Me.GPSearchProductTheme.Controls.Add(Me.lblLanguage)
        Me.GPSearchProductTheme.Dock = System.Windows.Forms.DockStyle.Top
        Me.GPSearchProductTheme.Location = New System.Drawing.Point(0, 0)
        Me.GPSearchProductTheme.Name = "GPSearchProductTheme"
        Me.GPSearchProductTheme.Size = New System.Drawing.Size(1002, 194)
        Me.GPSearchProductTheme.TabIndex = 5
        Me.GPSearchProductTheme.Text = "Search"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(314, 80)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(117, 50)
        Me.btnLoad.TabIndex = 148
        Me.btnLoad.Text = "Load"
        '
        'cmbThemeTop
        '
        Me.cmbThemeTop.AllowDrop = True
        Me.cmbThemeTop.Location = New System.Drawing.Point(92, 132)
        Me.cmbThemeTop.Name = "cmbThemeTop"
        Me.cmbThemeTop.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbThemeTop.Properties.NullText = ""
        Me.cmbThemeTop.Size = New System.Drawing.Size(144, 22)
        Me.cmbThemeTop.TabIndex = 147
        '
        'lblThemeTop
        '
        Me.lblThemeTop.Location = New System.Drawing.Point(7, 135)
        Me.lblThemeTop.Name = "lblThemeTop"
        Me.lblThemeTop.Size = New System.Drawing.Size(66, 16)
        Me.lblThemeTop.TabIndex = 146
        Me.lblThemeTop.Text = "Theme Top"
        '
        'cmbKind
        '
        Me.cmbKind.AllowDrop = True
        Me.cmbKind.Location = New System.Drawing.Point(92, 87)
        Me.cmbKind.Name = "cmbKind"
        Me.cmbKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbKind.Properties.NullText = ""
        Me.cmbKind.Size = New System.Drawing.Size(144, 22)
        Me.cmbKind.TabIndex = 145
        '
        'lblKind
        '
        Me.lblKind.Location = New System.Drawing.Point(7, 90)
        Me.lblKind.Name = "lblKind"
        Me.lblKind.Size = New System.Drawing.Size(24, 16)
        Me.lblKind.TabIndex = 144
        Me.lblKind.Text = "Kind"
        '
        'cmbLanguage
        '
        Me.cmbLanguage.AllowDrop = True
        Me.cmbLanguage.Location = New System.Drawing.Point(92, 45)
        Me.cmbLanguage.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbLanguage.Name = "cmbLanguage"
        Me.cmbLanguage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguage.Properties.DisplayMember = "status_desc"
        Me.cmbLanguage.Properties.NullText = ""
        Me.cmbLanguage.Properties.ValueMember = "status_id"
        Me.cmbLanguage.Size = New System.Drawing.Size(144, 22)
        Me.cmbLanguage.TabIndex = 143
        '
        'lblLanguage
        '
        Me.lblLanguage.Location = New System.Drawing.Point(7, 47)
        Me.lblLanguage.Margin = New System.Windows.Forms.Padding(4)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(55, 16)
        Me.lblLanguage.TabIndex = 142
        Me.lblLanguage.Text = "Language"
        '
        'pnlProductsList
        '
        Me.pnlProductsList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.pnlProductsList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.pnlProductsList.Controls.Add(Me.gpProductsList)
        Me.pnlProductsList.Controls.Add(Me.GPMoveProduct)
        Me.pnlProductsList.Location = New System.Drawing.Point(0, 200)
        Me.pnlProductsList.Name = "pnlProductsList"
        Me.pnlProductsList.Size = New System.Drawing.Size(1002, 322)
        Me.pnlProductsList.TabIndex = 6
        '
        'gpProductsList
        '
        Me.gpProductsList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gpProductsList.Controls.Add(Me.gridListedProducts)
        Me.gpProductsList.Dock = System.Windows.Forms.DockStyle.Right
        Me.gpProductsList.Location = New System.Drawing.Point(211, 2)
        Me.gpProductsList.Name = "gpProductsList"
        Me.gpProductsList.Size = New System.Drawing.Size(789, 318)
        Me.gpProductsList.TabIndex = 6
        Me.gpProductsList.Text = "list of products"
        '
        'GPMoveProduct
        '
        Me.GPMoveProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GPMoveProduct.Controls.Add(Me.BtnOrderDown)
        Me.GPMoveProduct.Controls.Add(Me.BtnAddProduct)
        Me.GPMoveProduct.Controls.Add(Me.BtnOrderUp)
        Me.GPMoveProduct.Controls.Add(Me.BtnRemoveProduct)
        Me.GPMoveProduct.Dock = System.Windows.Forms.DockStyle.Left
        Me.GPMoveProduct.Location = New System.Drawing.Point(2, 2)
        Me.GPMoveProduct.Name = "GPMoveProduct"
        Me.GPMoveProduct.Size = New System.Drawing.Size(201, 318)
        Me.GPMoveProduct.TabIndex = 5
        Me.GPMoveProduct.Text = "Move"
        '
        'BtnOrderDown
        '
        Me.BtnOrderDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOrderDown.Appearance.Options.UseTextOptions = True
        Me.BtnOrderDown.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BtnOrderDown.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BtnOrderDown.ImageIndex = 0
        Me.BtnOrderDown.ImageList = Me.Icones
        Me.BtnOrderDown.Location = New System.Drawing.Point(150, 93)
        Me.BtnOrderDown.Name = "BtnOrderDown"
        Me.BtnOrderDown.Size = New System.Drawing.Size(46, 62)
        Me.BtnOrderDown.TabIndex = 3
        '
        'Icones
        '
        Me.Icones.ImageStream = CType(resources.GetObject("Icones.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'BtnAddProduct
        '
        Me.BtnAddProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddProduct.Appearance.Options.UseTextOptions = True
        Me.BtnAddProduct.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BtnAddProduct.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BtnAddProduct.ImageIndex = 2
        Me.BtnAddProduct.ImageList = Me.Icones
        Me.BtnAddProduct.Location = New System.Drawing.Point(115, 161)
        Me.BtnAddProduct.Name = "BtnAddProduct"
        Me.BtnAddProduct.Size = New System.Drawing.Size(81, 47)
        Me.BtnAddProduct.TabIndex = 2
        '
        'BtnOrderUp
        '
        Me.BtnOrderUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOrderUp.Appearance.Options.UseTextOptions = True
        Me.BtnOrderUp.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BtnOrderUp.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BtnOrderUp.ImageIndex = 3
        Me.BtnOrderUp.ImageList = Me.Icones
        Me.BtnOrderUp.Location = New System.Drawing.Point(150, 25)
        Me.BtnOrderUp.Name = "BtnOrderUp"
        Me.BtnOrderUp.Size = New System.Drawing.Size(46, 62)
        Me.BtnOrderUp.TabIndex = 1
        '
        'BtnRemoveProduct
        '
        Me.BtnRemoveProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnRemoveProduct.Appearance.Options.UseTextOptions = True
        Me.BtnRemoveProduct.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BtnRemoveProduct.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BtnRemoveProduct.ImageIndex = 1
        Me.BtnRemoveProduct.ImageList = Me.Icones
        Me.BtnRemoveProduct.Location = New System.Drawing.Point(5, 161)
        Me.BtnRemoveProduct.Name = "BtnRemoveProduct"
        Me.BtnRemoveProduct.Size = New System.Drawing.Size(81, 47)
        Me.BtnRemoveProduct.TabIndex = 0
        '
        'cmbKindEdit
        '
        Me.cmbKindEdit.AllowDrop = True
        Me.cmbKindEdit.Location = New System.Drawing.Point(548, 81)
        Me.cmbKindEdit.Name = "cmbKindEdit"
        Me.cmbKindEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbKindEdit.Properties.NullText = ""
        Me.cmbKindEdit.Size = New System.Drawing.Size(144, 22)
        Me.cmbKindEdit.TabIndex = 137
        '
        'cmbStyle
        '
        Me.cmbStyle.Enabled = False
        Me.cmbStyle.Location = New System.Drawing.Point(548, 216)
        Me.cmbStyle.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStyle.Name = "cmbStyle"
        Me.cmbStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStyle.Properties.DisplayMember = "status_desc"
        Me.cmbStyle.Properties.NullText = ""
        Me.cmbStyle.Properties.ValueMember = "status_id"
        Me.cmbStyle.Size = New System.Drawing.Size(144, 22)
        Me.cmbStyle.TabIndex = 143
        '
        'lblStyle
        '
        Me.lblStyle.Location = New System.Drawing.Point(463, 218)
        Me.lblStyle.Margin = New System.Windows.Forms.Padding(4)
        Me.lblStyle.Name = "lblStyle"
        Me.lblStyle.Size = New System.Drawing.Size(28, 16)
        Me.lblStyle.TabIndex = 142
        Me.lblStyle.Text = "Style"
        '
        'cmbThemeEventEdit
        '
        Me.cmbThemeEventEdit.AllowDrop = True
        Me.cmbThemeEventEdit.Location = New System.Drawing.Point(548, 125)
        Me.cmbThemeEventEdit.Name = "cmbThemeEventEdit"
        Me.cmbThemeEventEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbThemeEventEdit.Properties.NullText = ""
        Me.cmbThemeEventEdit.Size = New System.Drawing.Size(144, 22)
        Me.cmbThemeEventEdit.TabIndex = 139
        '
        'lblThemeEventEdit
        '
        Me.lblThemeEventEdit.Location = New System.Drawing.Point(463, 128)
        Me.lblThemeEventEdit.Name = "lblThemeEventEdit"
        Me.lblThemeEventEdit.Size = New System.Drawing.Size(75, 16)
        Me.lblThemeEventEdit.TabIndex = 138
        Me.lblThemeEventEdit.Text = "Theme Event"
        '
        'lblKindEdit
        '
        Me.lblKindEdit.Location = New System.Drawing.Point(463, 84)
        Me.lblKindEdit.Name = "lblKindEdit"
        Me.lblKindEdit.Size = New System.Drawing.Size(24, 16)
        Me.lblKindEdit.TabIndex = 136
        Me.lblKindEdit.Text = "Kind"
        '
        'txtUpdateDate
        '
        Me.txtUpdateDate.AllowDrop = True
        Me.txtUpdateDate.EditValue = ""
        Me.txtUpdateDate.Enabled = False
        Me.txtUpdateDate.Location = New System.Drawing.Point(193, 333)
        Me.txtUpdateDate.Name = "txtUpdateDate"
        Me.txtUpdateDate.Size = New System.Drawing.Size(157, 22)
        Me.txtUpdateDate.TabIndex = 135
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.Location = New System.Drawing.Point(49, 336)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(70, 16)
        Me.lblUpdateDate.TabIndex = 134
        Me.lblUpdateDate.Text = "Update Date"
        '
        'txtCreateDate
        '
        Me.txtCreateDate.AllowDrop = True
        Me.txtCreateDate.EditValue = ""
        Me.txtCreateDate.Enabled = False
        Me.txtCreateDate.Location = New System.Drawing.Point(193, 291)
        Me.txtCreateDate.Name = "txtCreateDate"
        Me.txtCreateDate.Size = New System.Drawing.Size(157, 22)
        Me.txtCreateDate.TabIndex = 133
        '
        'lblDateCreate
        '
        Me.lblDateCreate.Location = New System.Drawing.Point(49, 297)
        Me.lblDateCreate.Name = "lblDateCreate"
        Me.lblDateCreate.Size = New System.Drawing.Size(68, 16)
        Me.lblDateCreate.TabIndex = 132
        Me.lblDateCreate.Text = "Create Date"
        '
        'chkStatus
        '
        Me.chkStatus.Location = New System.Drawing.Point(546, 245)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Properties.Caption = ""
        Me.chkStatus.Size = New System.Drawing.Size(224, 21)
        Me.chkStatus.TabIndex = 131
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(463, 251)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(36, 16)
        Me.lblStatus.TabIndex = 130
        Me.lblStatus.Text = "Status"
        '
        'txtHomePage
        '
        Me.txtHomePage.AllowDrop = True
        Me.txtHomePage.EditValue = ""
        Me.txtHomePage.Enabled = False
        Me.txtHomePage.Location = New System.Drawing.Point(193, 211)
        Me.txtHomePage.Name = "txtHomePage"
        Me.txtHomePage.Size = New System.Drawing.Size(222, 22)
        Me.txtHomePage.TabIndex = 129
        '
        'lblHomePage
        '
        Me.lblHomePage.Location = New System.Drawing.Point(49, 215)
        Me.lblHomePage.Name = "lblHomePage"
        Me.lblHomePage.Size = New System.Drawing.Size(65, 16)
        Me.lblHomePage.TabIndex = 128
        Me.lblHomePage.Text = "Home Page"
        '
        'TxtDescription
        '
        Me.TxtDescription.AllowDrop = True
        Me.TxtDescription.EditValue = ""
        Me.TxtDescription.Enabled = False
        Me.TxtDescription.Location = New System.Drawing.Point(193, 169)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(222, 22)
        Me.TxtDescription.TabIndex = 127
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(49, 173)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 16)
        Me.lblDescription.TabIndex = 126
        Me.lblDescription.Text = "Description"
        '
        'lblId
        '
        Me.lblId.Location = New System.Drawing.Point(49, 87)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(11, 16)
        Me.lblId.TabIndex = 125
        Me.lblId.Text = "Id"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(364, 20)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 26)
        Me.btnCancel.TabIndex = 118
        Me.btnCancel.Text = "Cancel"
        '
        'btnSaveTheme
        '
        Me.btnSaveTheme.Location = New System.Drawing.Point(248, 20)
        Me.btnSaveTheme.Name = "btnSaveTheme"
        Me.btnSaveTheme.Size = New System.Drawing.Size(90, 26)
        Me.btnSaveTheme.TabIndex = 117
        Me.btnSaveTheme.Text = "Save"
        '
        'btnEditTheme
        '
        Me.btnEditTheme.Location = New System.Drawing.Point(125, 20)
        Me.btnEditTheme.Name = "btnEditTheme"
        Me.btnEditTheme.Size = New System.Drawing.Size(90, 26)
        Me.btnEditTheme.TabIndex = 123
        Me.btnEditTheme.Text = "Edit"
        '
        'btnNewTheme_edit
        '
        Me.btnNewTheme_edit.Location = New System.Drawing.Point(11, 20)
        Me.btnNewTheme_edit.Name = "btnNewTheme_edit"
        Me.btnNewTheme_edit.Size = New System.Drawing.Size(90, 26)
        Me.btnNewTheme_edit.TabIndex = 124
        Me.btnNewTheme_edit.Text = "new"
        '
        'TxtEventThemeId_edit
        '
        Me.TxtEventThemeId_edit.AllowDrop = True
        Me.TxtEventThemeId_edit.EditValue = ""
        Me.TxtEventThemeId_edit.Enabled = False
        Me.TxtEventThemeId_edit.Location = New System.Drawing.Point(193, 84)
        Me.TxtEventThemeId_edit.Name = "TxtEventThemeId_edit"
        Me.TxtEventThemeId_edit.Size = New System.Drawing.Size(78, 22)
        Me.TxtEventThemeId_edit.TabIndex = 115
        '
        'txtTitleEdit
        '
        Me.txtTitleEdit.AllowDrop = True
        Me.txtTitleEdit.EditValue = ""
        Me.txtTitleEdit.Enabled = False
        Me.txtTitleEdit.Location = New System.Drawing.Point(193, 129)
        Me.txtTitleEdit.Name = "txtTitleEdit"
        Me.txtTitleEdit.Size = New System.Drawing.Size(222, 22)
        Me.txtTitleEdit.TabIndex = 114
        '
        'lblTitleEdit
        '
        Me.lblTitleEdit.Location = New System.Drawing.Point(49, 133)
        Me.lblTitleEdit.Name = "lblTitleEdit"
        Me.lblTitleEdit.Size = New System.Drawing.Size(25, 16)
        Me.lblTitleEdit.TabIndex = 113
        Me.lblTitleEdit.Text = "Title"
        '
        'frmProductsThemes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1547, 561)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmProductsThemes"
        Me.Text = "frmProductsThemes"
        Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridListedProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewListedProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryCmbTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GridProductsDVD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewProductsDVD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpSearch.ResumeLayout(False)
        Me.gpSearch.PerformLayout()
        CType(Me.txtSearchProduct_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearchImdb_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GPSearchProductTheme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPSearchProductTheme.ResumeLayout(False)
        Me.GPSearchProductTheme.PerformLayout()
        CType(Me.cmbThemeTop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlProductsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProductsList.ResumeLayout(False)
        CType(Me.gpProductsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpProductsList.ResumeLayout(False)
        CType(Me.GPMoveProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPMoveProduct.ResumeLayout(False)
        CType(Me.Icones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbKindEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbThemeEventEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUpdateDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreateDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHomePage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEventThemeId_edit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridListedProducts As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewListedProducts As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcProducts_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcproducts_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTheme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repositoryCmbTheme As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents pnlProductsList As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GPSearchProductTheme As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GPMoveProduct As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnRemoveProduct As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnOrderUp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Icones As DevExpress.Utils.ImageCollection
    Friend WithEvents BtnAddProduct As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnOrderDown As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbLanguage As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblLanguage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbKindEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbStyle As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblStyle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbThemeEventEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblThemeEventEdit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblKindEdit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUpdateDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblUpdateDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCreateDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDateCreate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkStatus As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHomePage As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblHomePage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDescription As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveTheme As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditTheme As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNewTheme_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtEventThemeId_edit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTitleEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitleEdit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbThemeTop As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblThemeTop As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbKind As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblKind As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnLoad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSearchImdb_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblImdb_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTitleSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitleProduct As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gpSearch As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gpProductsList As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridProductsDVD As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewProductsDVD As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colproducts_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_model As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents txtSearchProduct_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblProducts_id As DevExpress.XtraEditors.LabelControl
End Class
