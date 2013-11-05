Public Class frmDVDStatus_Maintenance
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
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTitleSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbProductID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSaveGrid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colcover_box_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvd_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProducts_Status As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtQtyNow As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtQtyTot As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSalePrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents objDS As DVDPostLib.dsProducts
    Friend WithEvents cmbProducts_Status As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colproducts_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvdid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvd_status1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colinout As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvd_buy_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_lastrented As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnbr_rotation_in_feesharing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbox_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpibox_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collast_adminby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collast_admindate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpreattribute_orders_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcover_boxid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnResetQtyNow As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnChangeStatus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbNewDVDStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbActualDVDStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDVD_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProducts_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBarCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPosInBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBoxID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPosInBox As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblBoxID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitle2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtACtualPosID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtACtualBoxID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFindBarCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInOut As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFeeSharing As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFeeSharingEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ChkChgStatus As DevExpress.XtraEditors.CheckEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

        Me.ChkChgStatus = New DevExpress.XtraEditors.CheckEdit
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtTitleSearch = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.cmbProductID = New DevExpress.XtraEditors.LookUpEdit
        Me.objDS = New DVDPostLib.dsProducts
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtQtyNow = New DevExpress.XtraEditors.TextEdit
        Me.btnSaveGrid = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colproducts_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvdid = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvd_status1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbProducts_Status = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colinout = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldvd_buy_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldate_lastrented = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnbr_rotation_in_feesharing = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbox_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpibox_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collast_adminby = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collast_admindate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpreattribute_orders_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcover_boxid = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcover_box_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvd_status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtProducts_Status = New DevExpress.XtraEditors.TextEdit
        Me.txtQtyTot = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtSalePrice = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.btnResetQtyNow = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.txtFeeSharingEnd = New DevExpress.XtraEditors.DateEdit
        Me.txtFeeSharing = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.txtInOut = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.btnFindBarCode = New DevExpress.XtraEditors.SimpleButton
        Me.btnOK1 = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.cmbActualDVDStatus = New DevExpress.XtraEditors.LookUpEdit
        Me.txtDVD_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtACtualPosID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.txtACtualBoxID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.txtProducts_id = New DevExpress.XtraEditors.TextEdit
        Me.txtBarCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.txtTitle2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.cmbNewDVDStatus = New DevExpress.XtraEditors.LookUpEdit
        Me.txtPosInBox = New DevExpress.XtraEditors.TextEdit
        Me.lblPosInBox = New DevExpress.XtraEditors.LabelControl
        Me.txtBoxID = New DevExpress.XtraEditors.TextEdit
        Me.lblBoxID = New DevExpress.XtraEditors.LabelControl
        Me.btnChangeStatus = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        ChkChgStatus = New DevExpress.XtraEditors.CheckEdit
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtyNow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProducts_Status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducts_Status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtyTot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalePrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtFeeSharingEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFeeSharingEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFeeSharing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInOut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbActualDVDStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtACtualPosID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtACtualBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cmbNewDVDStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosInBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        CType(ChkChgStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(104, 88)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Properties.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(304, 20)
        Me.txtTitle.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 64)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Product ID"
        '
        'txtTitleSearch
        '
        Me.txtTitleSearch.Location = New System.Drawing.Point(104, 16)
        Me.txtTitleSearch.Name = "txtTitleSearch"
        Me.txtTitleSearch.Size = New System.Drawing.Size(304, 20)
        Me.txtTitleSearch.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(24, 16)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Title Like"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(416, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        '
        'cmbProductID
        '
        Me.cmbProductID.Location = New System.Drawing.Point(104, 64)
        Me.cmbProductID.Name = "cmbProductID"
        Me.cmbProductID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProductID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_id", "ID", 100), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_title", "Title", 200), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_model", "Modele", 200)})
        Me.cmbProductID.Properties.DataSource = Me.objDS.products
        Me.cmbProductID.Properties.DisplayMember = "products_id"
        Me.cmbProductID.Properties.NullText = ""
        Me.cmbProductID.Properties.PopupWidth = 500
        Me.cmbProductID.Properties.ValueMember = "products_id"
        Me.cmbProductID.Size = New System.Drawing.Size(100, 20)
        Me.cmbProductID.TabIndex = 2
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsProducts"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(24, 88)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Title"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(24, 144)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "Qty Now"
        '
        'txtQtyNow
        '
        Me.txtQtyNow.Location = New System.Drawing.Point(104, 144)
        Me.txtQtyNow.Name = "txtQtyNow"
        Me.txtQtyNow.Properties.ReadOnly = True
        Me.txtQtyNow.Size = New System.Drawing.Size(96, 20)
        Me.txtQtyNow.TabIndex = 4
        '
        'btnSaveGrid
        '
        Me.btnSaveGrid.Location = New System.Drawing.Point(416, 48)
        Me.btnSaveGrid.Name = "btnSaveGrid"
        Me.btnSaveGrid.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveGrid.TabIndex = 21
        Me.btnSaveGrid.Text = "Save Grid"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.objDS.products_dvd
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.FormsUseDefaultLookAndFeel = False
        Me.GridControl1.Location = New System.Drawing.Point(512, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbProducts_Status})
        Me.GridControl1.Size = New System.Drawing.Size(543, 297)
        Me.GridControl1.TabIndex = 20
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colproducts_id1, Me.colproducts_dvdid, Me.colproducts_dvd_status1, Me.colinout, Me.coldvd_buy_date, Me.coldate_lastrented, Me.colnbr_rotation_in_feesharing, Me.colbox_id, Me.colpibox_id, Me.collast_adminby, Me.collast_admindate, Me.colpreattribute_orders_id, Me.colcover_boxid})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colproducts_id1
        '
        Me.colproducts_id1.Caption = "products_id"
        Me.colproducts_id1.FieldName = "products_id"
        Me.colproducts_id1.Name = "colproducts_id1"
        Me.colproducts_id1.OptionsColumn.ReadOnly = True
        '
        'colproducts_dvdid
        '
        Me.colproducts_dvdid.Caption = "products_dvdid"
        Me.colproducts_dvdid.FieldName = "products_dvdid"
        Me.colproducts_dvdid.Name = "colproducts_dvdid"
        Me.colproducts_dvdid.OptionsColumn.ReadOnly = True
        Me.colproducts_dvdid.Visible = True
        Me.colproducts_dvdid.VisibleIndex = 0
        '
        'colproducts_dvd_status1
        '
        Me.colproducts_dvd_status1.Caption = "products_dvd_status"
        Me.colproducts_dvd_status1.ColumnEdit = Me.cmbProducts_Status
        Me.colproducts_dvd_status1.FieldName = "products_dvd_status"
        Me.colproducts_dvd_status1.Name = "colproducts_dvd_status1"
        Me.colproducts_dvd_status1.Visible = True
        Me.colproducts_dvd_status1.VisibleIndex = 1
        '
        'cmbProducts_Status
        '
        Me.cmbProducts_Status.AutoHeight = False
        Me.cmbProducts_Status.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProducts_Status.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_dvd_status_id", "products_dvd_status_id", 135, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_dvd_status_name", "products_dvd_status_name", 140, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbProducts_Status.DataSource = Me.objDS.products_dvd_status
        Me.cmbProducts_Status.DisplayMember = "products_dvd_status_name"
        Me.cmbProducts_Status.Name = "cmbProducts_Status"
        Me.cmbProducts_Status.NullText = ""
        Me.cmbProducts_Status.ValueMember = "products_dvd_status_id"
        '
        'colinout
        '
        Me.colinout.Caption = "inout"
        Me.colinout.FieldName = "inout"
        Me.colinout.Name = "colinout"
        Me.colinout.OptionsColumn.ReadOnly = True
        '
        'coldvd_buy_date
        '
        Me.coldvd_buy_date.Caption = "dvd_buy_date"
        Me.coldvd_buy_date.FieldName = "dvd_buy_date"
        Me.coldvd_buy_date.Name = "coldvd_buy_date"
        Me.coldvd_buy_date.OptionsColumn.ReadOnly = True
        '
        'coldate_lastrented
        '
        Me.coldate_lastrented.Caption = "date_lastrented"
        Me.coldate_lastrented.FieldName = "date_lastrented"
        Me.coldate_lastrented.Name = "coldate_lastrented"
        Me.coldate_lastrented.OptionsColumn.ReadOnly = True
        Me.coldate_lastrented.Visible = True
        Me.coldate_lastrented.VisibleIndex = 2
        '
        'colnbr_rotation_in_feesharing
        '
        Me.colnbr_rotation_in_feesharing.Caption = "nbr_rotation_in_feesharing"
        Me.colnbr_rotation_in_feesharing.FieldName = "nbr_rotation_in_feesharing"
        Me.colnbr_rotation_in_feesharing.Name = "colnbr_rotation_in_feesharing"
        Me.colnbr_rotation_in_feesharing.OptionsColumn.ReadOnly = True
        '
        'colbox_id
        '
        Me.colbox_id.Caption = "box_id"
        Me.colbox_id.FieldName = "box_id"
        Me.colbox_id.Name = "colbox_id"
        Me.colbox_id.OptionsColumn.ReadOnly = True
        '
        'colpibox_id
        '
        Me.colpibox_id.Caption = "pibox_id"
        Me.colpibox_id.FieldName = "pibox_id"
        Me.colpibox_id.Name = "colpibox_id"
        Me.colpibox_id.OptionsColumn.ReadOnly = True
        '
        'collast_adminby
        '
        Me.collast_adminby.Caption = "last_adminby"
        Me.collast_adminby.FieldName = "last_adminby"
        Me.collast_adminby.Name = "collast_adminby"
        Me.collast_adminby.OptionsColumn.ReadOnly = True
        '
        'collast_admindate
        '
        Me.collast_admindate.Caption = "last_admindate"
        Me.collast_admindate.FieldName = "last_admindate"
        Me.collast_admindate.Name = "collast_admindate"
        Me.collast_admindate.OptionsColumn.ReadOnly = True
        Me.collast_admindate.Visible = True
        Me.collast_admindate.VisibleIndex = 3
        '
        'colpreattribute_orders_id
        '
        Me.colpreattribute_orders_id.Caption = "preattribute_orders_id"
        Me.colpreattribute_orders_id.FieldName = "preattribute_orders_id"
        Me.colpreattribute_orders_id.Name = "colpreattribute_orders_id"
        Me.colpreattribute_orders_id.OptionsColumn.ReadOnly = True
        '
        'colcover_boxid
        '
        Me.colcover_boxid.Caption = "cover_boxid"
        Me.colcover_boxid.FieldName = "cover_boxid"
        Me.colcover_boxid.Name = "colcover_boxid"
        Me.colcover_boxid.OptionsColumn.ReadOnly = True
        '
        'colcover_box_id
        '
        Me.colcover_box_id.Caption = "cover_box_id"
        Me.colcover_box_id.FieldName = "cover_box_id"
        Me.colcover_box_id.Name = "colcover_box_id"
        Me.colcover_box_id.Visible = True
        Me.colcover_box_id.VisibleIndex = 2
        '
        'colproducts_id
        '
        Me.colproducts_id.Caption = "products_id"
        Me.colproducts_id.FieldName = "products_id"
        Me.colproducts_id.Name = "colproducts_id"
        Me.colproducts_id.OptionsColumn.ReadOnly = True
        '
        'colproducts_dvd_status
        '
        Me.colproducts_dvd_status.Caption = "products_dvd_status"
        Me.colproducts_dvd_status.ColumnEdit = Me.cmbProducts_Status
        Me.colproducts_dvd_status.FieldName = "products_dvd_status"
        Me.colproducts_dvd_status.Name = "colproducts_dvd_status"
        Me.colproducts_dvd_status.OptionsColumn.ReadOnly = True
        Me.colproducts_dvd_status.Visible = True
        Me.colproducts_dvd_status.VisibleIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(232, 64)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl5.TabIndex = 22
        Me.LabelControl5.Text = "Status"
        '
        'txtProducts_Status
        '
        Me.txtProducts_Status.Location = New System.Drawing.Point(312, 64)
        Me.txtProducts_Status.Name = "txtProducts_Status"
        Me.txtProducts_Status.Properties.ReadOnly = True
        Me.txtProducts_Status.Size = New System.Drawing.Size(96, 20)
        Me.txtProducts_Status.TabIndex = 23
        '
        'txtQtyTot
        '
        Me.txtQtyTot.Location = New System.Drawing.Point(104, 120)
        Me.txtQtyTot.Name = "txtQtyTot"
        Me.txtQtyTot.Properties.ReadOnly = True
        Me.txtQtyTot.Size = New System.Drawing.Size(96, 20)
        Me.txtQtyTot.TabIndex = 24
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(24, 120)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl6.TabIndex = 25
        Me.LabelControl6.Text = "Qty Tot"
        '
        'txtSalePrice
        '
        Me.txtSalePrice.Location = New System.Drawing.Point(104, 168)
        Me.txtSalePrice.Name = "txtSalePrice"
        Me.txtSalePrice.Properties.ReadOnly = True
        Me.txtSalePrice.Size = New System.Drawing.Size(96, 20)
        Me.txtSalePrice.TabIndex = 28
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(24, 168)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl7.TabIndex = 29
        Me.LabelControl7.Text = "Sale Price"
        '
        'btnResetQtyNow
        '
        Me.btnResetQtyNow.Location = New System.Drawing.Point(208, 144)
        Me.btnResetQtyNow.Name = "btnResetQtyNow"
        Me.btnResetQtyNow.Size = New System.Drawing.Size(75, 23)
        Me.btnResetQtyNow.TabIndex = 30
        Me.btnResetQtyNow.Text = "Reset ..."
        Me.btnResetQtyNow.ToolTip = "Set QtyNow to Nbr of DVD with Status = OK"
        '
        'PanelControl1
        '
        Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl1.Controls.Add(Me.btnRefresh)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtProducts_Status)
        Me.PanelControl1.Controls.Add(Me.btnResetQtyNow)
        Me.PanelControl1.Controls.Add(Me.txtQtyTot)
        Me.PanelControl1.Controls.Add(Me.txtSalePrice)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.txtQtyNow)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.btnSaveGrid)
        Me.PanelControl1.Controls.Add(Me.txtTitle)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.btnSearch)
        Me.PanelControl1.Controls.Add(Me.cmbProductID)
        Me.PanelControl1.Controls.Add(Me.txtTitleSearch)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(512, 297)
        Me.PanelControl1.TabIndex = 31
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(416, 80)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 31
        Me.btnRefresh.Text = "Refresh Info"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 30)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(1064, 328)
        Me.XtraTabControl1.TabIndex = 32
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2, Me.XtraTabPage1})
        Me.XtraTabControl1.Text = "Global Management"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1055, 297)
        Me.XtraTabPage2.Text = "Scanner Change Status"
        '
        'PanelControl2
        '
        Me.PanelControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl2.Controls.Add(Me.GroupControl2)
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1055, 270)
        Me.PanelControl2.TabIndex = 31
        '
        'GroupControl2
        '
        Me.GroupControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl2.Controls.Add(Me.LabelControl18)
        Me.GroupControl2.Controls.Add(Me.txtFeeSharingEnd)
        Me.GroupControl2.Controls.Add(Me.txtFeeSharing)
        Me.GroupControl2.Controls.Add(Me.LabelControl17)
        Me.GroupControl2.Controls.Add(Me.txtInOut)
        Me.GroupControl2.Controls.Add(Me.LabelControl16)
        Me.GroupControl2.Controls.Add(Me.btnFindBarCode)
        Me.GroupControl2.Controls.Add(Me.btnOK1)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.cmbActualDVDStatus)
        Me.GroupControl2.Controls.Add(Me.txtDVD_ID)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.txtACtualPosID)
        Me.GroupControl2.Controls.Add(Me.LabelControl14)
        Me.GroupControl2.Controls.Add(Me.txtACtualBoxID)
        Me.GroupControl2.Controls.Add(Me.LabelControl15)
        Me.GroupControl2.Controls.Add(Me.txtProducts_id)
        Me.GroupControl2.Controls.Add(Me.txtBarCode)
        Me.GroupControl2.Controls.Add(Me.LabelControl11)
        Me.GroupControl2.Controls.Add(Me.LabelControl12)
        Me.GroupControl2.Controls.Add(Me.txtTitle2)
        Me.GroupControl2.Controls.Add(Me.LabelControl13)
        Me.GroupControl2.Location = New System.Drawing.Point(16, 16)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(504, 216)
        Me.GroupControl2.TabIndex = 46
        Me.GroupControl2.Text = "Actual Status"
        '
        'LabelControl18
        '
        Me.LabelControl18.Enabled = False
        Me.LabelControl18.Location = New System.Drawing.Point(216, 128)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl18.TabIndex = 52
        Me.LabelControl18.Text = "FeeSharing End"
        '
        'txtFeeSharingEnd
        '
        Me.txtFeeSharingEnd.EditValue = Nothing
        Me.txtFeeSharingEnd.Enabled = False
        Me.txtFeeSharingEnd.Location = New System.Drawing.Point(296, 128)
        Me.txtFeeSharingEnd.Name = "txtFeeSharingEnd"
        Me.txtFeeSharingEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFeeSharingEnd.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtFeeSharingEnd.Size = New System.Drawing.Size(100, 20)
        Me.txtFeeSharingEnd.TabIndex = 51
        '
        'txtFeeSharing
        '
        Me.txtFeeSharing.Enabled = False
        Me.txtFeeSharing.Location = New System.Drawing.Point(88, 128)
        Me.txtFeeSharing.Name = "txtFeeSharing"
        Me.txtFeeSharing.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFeeSharing.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFeeSharing.Properties.ReadOnly = True
        Me.txtFeeSharing.Size = New System.Drawing.Size(96, 20)
        Me.txtFeeSharing.TabIndex = 50
        '
        'LabelControl17
        '
        Me.LabelControl17.Enabled = False
        Me.LabelControl17.Location = New System.Drawing.Point(8, 128)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl17.TabIndex = 49
        Me.LabelControl17.Text = "FeeSharing"
        '
        'txtInOut
        '
        Me.txtInOut.Enabled = False
        Me.txtInOut.Location = New System.Drawing.Point(88, 152)
        Me.txtInOut.Name = "txtInOut"
        Me.txtInOut.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInOut.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInOut.Properties.ReadOnly = True
        Me.txtInOut.Size = New System.Drawing.Size(96, 20)
        Me.txtInOut.TabIndex = 48
        '
        'LabelControl16
        '
        Me.LabelControl16.Enabled = False
        Me.LabelControl16.Location = New System.Drawing.Point(8, 152)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl16.TabIndex = 47
        Me.LabelControl16.Text = "In Out"
        '
        'btnFindBarCode
        '
        Me.btnFindBarCode.Location = New System.Drawing.Point(400, 32)
        Me.btnFindBarCode.Name = "btnFindBarCode"
        Me.btnFindBarCode.Size = New System.Drawing.Size(96, 23)
        Me.btnFindBarCode.TabIndex = 46
        Me.btnFindBarCode.Text = "&Find Bar Code"
        '
        'btnOK1
        '
        Me.btnOK1.Location = New System.Drawing.Point(296, 32)
        Me.btnOK1.Name = "btnOK1"
        Me.btnOK1.Size = New System.Drawing.Size(96, 23)
        Me.btnOK1.TabIndex = 45
        Me.btnOK1.Text = "&OK"
        '
        'LabelControl9
        '
        Me.LabelControl9.Enabled = False
        Me.LabelControl9.Location = New System.Drawing.Point(8, 192)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl9.TabIndex = 32
        Me.LabelControl9.Text = "Actual Status"
        '
        'cmbActualDVDStatus
        '
        Me.cmbActualDVDStatus.Enabled = False
        Me.cmbActualDVDStatus.Location = New System.Drawing.Point(88, 184)
        Me.cmbActualDVDStatus.Name = "cmbActualDVDStatus"
        Me.cmbActualDVDStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbActualDVDStatus.Properties.DataSource = Me.objDS.products_dvd_status
        Me.cmbActualDVDStatus.Properties.DisplayMember = "products_dvd_status_name"
        Me.cmbActualDVDStatus.Properties.NullText = ""
        Me.cmbActualDVDStatus.Properties.ValueMember = "products_dvd_status_id"
        Me.cmbActualDVDStatus.Size = New System.Drawing.Size(100, 20)
        Me.cmbActualDVDStatus.TabIndex = 31
        '
        'txtDVD_ID
        '
        Me.txtDVD_ID.Enabled = False
        Me.txtDVD_ID.Location = New System.Drawing.Point(296, 56)
        Me.txtDVD_ID.Name = "txtDVD_ID"
        Me.txtDVD_ID.Properties.ReadOnly = True
        Me.txtDVD_ID.Size = New System.Drawing.Size(96, 20)
        Me.txtDVD_ID.TabIndex = 29
        '
        'LabelControl10
        '
        Me.LabelControl10.Enabled = False
        Me.LabelControl10.Location = New System.Drawing.Point(216, 56)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl10.TabIndex = 28
        Me.LabelControl10.Text = "DVD ID"
        '
        'txtACtualPosID
        '
        Me.txtACtualPosID.Enabled = False
        Me.txtACtualPosID.Location = New System.Drawing.Point(296, 104)
        Me.txtACtualPosID.Name = "txtACtualPosID"
        Me.txtACtualPosID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtACtualPosID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtACtualPosID.Properties.ReadOnly = True
        Me.txtACtualPosID.Size = New System.Drawing.Size(96, 20)
        Me.txtACtualPosID.TabIndex = 44
        '
        'LabelControl14
        '
        Me.LabelControl14.Enabled = False
        Me.LabelControl14.Location = New System.Drawing.Point(216, 104)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl14.TabIndex = 43
        Me.LabelControl14.Text = "Pos In Box"
        '
        'txtACtualBoxID
        '
        Me.txtACtualBoxID.Enabled = False
        Me.txtACtualBoxID.Location = New System.Drawing.Point(88, 104)
        Me.txtACtualBoxID.Name = "txtACtualBoxID"
        Me.txtACtualBoxID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtACtualBoxID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtACtualBoxID.Properties.ReadOnly = True
        Me.txtACtualBoxID.Size = New System.Drawing.Size(96, 20)
        Me.txtACtualBoxID.TabIndex = 42
        '
        'LabelControl15
        '
        Me.LabelControl15.Enabled = False
        Me.LabelControl15.Location = New System.Drawing.Point(8, 104)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl15.TabIndex = 41
        Me.LabelControl15.Text = "Box ID"
        '
        'txtProducts_id
        '
        Me.txtProducts_id.Enabled = False
        Me.txtProducts_id.Location = New System.Drawing.Point(88, 56)
        Me.txtProducts_id.Name = "txtProducts_id"
        Me.txtProducts_id.Properties.ReadOnly = True
        Me.txtProducts_id.Size = New System.Drawing.Size(96, 20)
        Me.txtProducts_id.TabIndex = 24
        '
        'txtBarCode
        '
        Me.txtBarCode.Location = New System.Drawing.Point(88, 32)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(200, 20)
        Me.txtBarCode.TabIndex = 22
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(8, 32)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl11.TabIndex = 23
        Me.LabelControl11.Text = "BareCode"
        '
        'LabelControl12
        '
        Me.LabelControl12.Enabled = False
        Me.LabelControl12.Location = New System.Drawing.Point(8, 56)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl12.TabIndex = 5
        Me.LabelControl12.Text = "Product ID"
        '
        'txtTitle2
        '
        Me.txtTitle2.Enabled = False
        Me.txtTitle2.Location = New System.Drawing.Point(88, 80)
        Me.txtTitle2.Name = "txtTitle2"
        Me.txtTitle2.Properties.ReadOnly = True
        Me.txtTitle2.Size = New System.Drawing.Size(304, 20)
        Me.txtTitle2.TabIndex = 3
        '
        'LabelControl13
        '
        Me.LabelControl13.Enabled = False
        Me.LabelControl13.Location = New System.Drawing.Point(8, 80)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl13.TabIndex = 10
        Me.LabelControl13.Text = "Title"
        '
        'GroupControl1
        '
        Me.GroupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl1.Controls.Add(ChkChgStatus)
        Me.GroupControl1.Controls.Add(Me.cmbNewDVDStatus)
        Me.GroupControl1.Controls.Add(Me.txtPosInBox)
        Me.GroupControl1.Controls.Add(Me.lblPosInBox)
        Me.GroupControl1.Controls.Add(Me.txtBoxID)
        Me.GroupControl1.Controls.Add(Me.lblBoxID)
        Me.GroupControl1.Controls.Add(Me.btnChangeStatus)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Location = New System.Drawing.Point(528, 16)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(432, 216)
        Me.GroupControl1.TabIndex = 45
        Me.GroupControl1.Text = "New Status"
        '
        'cmbNewDVDStatus
        '
        Me.cmbNewDVDStatus.Location = New System.Drawing.Point(120, 32)
        Me.cmbNewDVDStatus.Name = "cmbNewDVDStatus"
        Me.cmbNewDVDStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNewDVDStatus.Properties.DataSource = Me.objDS.products_dvd_status
        Me.cmbNewDVDStatus.Properties.DisplayMember = "products_dvd_status_name"
        Me.cmbNewDVDStatus.Properties.NullText = ""
        Me.cmbNewDVDStatus.Properties.ValueMember = "products_dvd_status_id"
        Me.cmbNewDVDStatus.Size = New System.Drawing.Size(100, 20)
        Me.cmbNewDVDStatus.TabIndex = 33
        '
        'txtPosInBox
        '
        Me.txtPosInBox.EditValue = 1
        Me.txtPosInBox.Location = New System.Drawing.Point(312, 64)
        Me.txtPosInBox.Name = "txtPosInBox"
        Me.txtPosInBox.Properties.DisplayFormat.FormatString = "N0"
        Me.txtPosInBox.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPosInBox.Properties.EditFormat.FormatString = "N0"
        Me.txtPosInBox.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPosInBox.Size = New System.Drawing.Size(96, 20)
        Me.txtPosInBox.TabIndex = 40
        Me.txtPosInBox.Visible = False
        '
        'lblPosInBox
        '
        Me.lblPosInBox.Location = New System.Drawing.Point(232, 64)
        Me.lblPosInBox.Name = "lblPosInBox"
        Me.lblPosInBox.Size = New System.Drawing.Size(51, 13)
        Me.lblPosInBox.TabIndex = 39
        Me.lblPosInBox.Text = "Pos In Box"
        Me.lblPosInBox.Visible = False
        '
        'txtBoxID
        '
        Me.txtBoxID.Location = New System.Drawing.Point(120, 64)
        Me.txtBoxID.Name = "txtBoxID"
        Me.txtBoxID.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxID.TabIndex = 38
        Me.txtBoxID.Visible = False
        '
        'lblBoxID
        '
        Me.lblBoxID.Location = New System.Drawing.Point(8, 64)
        Me.lblBoxID.Name = "lblBoxID"
        Me.lblBoxID.Size = New System.Drawing.Size(32, 13)
        Me.lblBoxID.TabIndex = 37
        Me.lblBoxID.Text = "Box ID"
        Me.lblBoxID.Visible = False
        '
        'btnChangeStatus
        '
        Me.btnChangeStatus.Location = New System.Drawing.Point(312, 32)
        Me.btnChangeStatus.Name = "btnChangeStatus"
        Me.btnChangeStatus.Size = New System.Drawing.Size(96, 23)
        Me.btnChangeStatus.TabIndex = 36
        Me.btnChangeStatus.Text = "Change Status"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(8, 32)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl8.TabIndex = 34
        Me.LabelControl8.Text = "Change Status TO :"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1055, 297)
        Me.XtraTabPage1.Text = "Global Management"
        '
        'ChkChgStatus
        '
        ChkChgStatus.Location = New System.Drawing.Point(6, 105)
        ChkChgStatus.Name = "ChkChgStatus"
        ChkChgStatus.Properties.Caption = "Automatically Change Status"
        ChkChgStatus.Size = New System.Drawing.Size(178, 19)
        ChkChgStatus.TabIndex = 42
        '
        'frmDVDStatus_Maintenance
        '
        Me.AcceptButton = Me.btnOK1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1064, 358)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmDVDStatus_Maintenance"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtyNow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProducts_Status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducts_Status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtyTot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalePrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtFeeSharingEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFeeSharingEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFeeSharing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInOut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbActualDVDStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtACtualPosID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtACtualBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cmbNewDVDStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosInBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        CType(ChkChgStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim _objProductDVD As clsProduct_DVD


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim _SQLTxt As String = "SELECT * FROM products where products_title like '%" & txtTitleSearch.EditValue & "%' "
        objDS.Tables("products").Clear()
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products"), _SQLTxt)
        cmbProductID.Focus()
        cmbProductID.ShowPopup()
    End Sub
    Private Sub cmbProductID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductID.EditValueChanged
        RefreshDVDInfo()
    End Sub
    Private Sub RefreshDVDInfo()
        Dim _row As DataRow
        Dim _SQLTxt As String
        Dim _DS As New dsProducts
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("products"), "SELECT * FROM products WHERE products_id = " & cmbProductID.EditValue)
        _row = _DS.Tables("products").Rows(0)
        If Not IsNothing(_row) Then
            txtTitle.EditValue = _row("products_title")
            txtProducts_Status.EditValue = _row("products_status")

            txtQtyTot.EditValue = _row("products_dvd_quantity")
            txtQtyNow.EditValue = _row("products_quantity")
            txtSalePrice.EditValue = _row("products_sale_price")
            Me.Refresh()
        End If
        _SQLTxt = "SELECT products_id, products_dvdid, products_dvd_status, cover_box_id, `inout`, nbr_rotation_in_feesharing, box_id, pibox_id, last_adminby, " & _
                  " if (dvd_buy_date = '0000-00-00', Null, dvd_buy_date) as dvd_buy_date, " & _
                  " if (date_lastrented = '0000-00-00', Null, date_lastrented) as date_lastrented, " & _
                  " if (last_admindate = '0000-00-00', Null, last_admindate) as last_admindate " & _
                  " FROM products_dvd where products_id = " & cmbProductID.EditValue & _
                  " ORDER BY products_dvd_status, products_dvdid "  ' & " AND ( cover_box_id is null or cover_box_id = '' )"
        objDS.Tables("products_dvd").Clear()
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_dvd"), _SQLTxt)

        Dim _NewQtyNow As Integer
        _SQLTxt = "SELECT count(*) from products_dvd where products_id = " & cmbProductID.EditValue & " AND products_dvd_status = 1 "
        _NewQtyNow = BKGlobal.ExecuteCount(_SQLTxt)
        If _NewQtyNow <> _row("products_quantity") Then
            btnResetQtyNow.Visible = True
            btnResetQtyNow.ToolTip = "Qty Now should be : " & _NewQtyNow & vbCrLf & "Please click here."
        Else
            btnResetQtyNow.Visible = False
        End If

    End Sub

    Private Sub frmCoverEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        GridControl1.ContextMenuStrip = menuStrip

        Dim _SQLTxt As String
        DvdPostData.clsConnection.ExecuteNonQuery("UPDATE products_dvd set last_admindate = '1801-01-01' where last_admindate = '0000-00-00'")

        'Load DVD Status List
        _SQLTxt = "SELECT * FROM products_dvd_status"
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_dvd_status"), _SQLTxt)
    End Sub

    Private Sub btnSaveGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveGrid.Click
        SaveGrid()
    End Sub
    Private Sub SaveGrid()

        Dim _ModifiedView As DataView = New DataView(objDS.Tables("products_dvd"), "", "", DataViewRowState.ModifiedCurrent)
        Dim _OrigView As DataView = New DataView(objDS.Tables("products_dvd"), "", "", DataViewRowState.ModifiedOriginal)
        Dim _MRow As DataRowView
        For Each _MRow In _ModifiedView
            ChangeDVDStatus(_MRow("products_id"), _MRow("products_dvdid"), _MRow("products_dvd_status"))
        Next
        RefreshDVDInfo()
        MsgBox("Done", MsgBoxStyle.Information)
    End Sub

    Private Sub btnResetQtyNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetQtyNow.Click
        Dim _SQLTxt As String
        Dim _NewQtyNow As Integer
        Dim _row As DataRow
        _row = objDS.Tables("products").Rows.Find(New Object() {cmbProductID.EditValue})
        _SQLTxt = "SELECT count(*) from products_dvd where products_id = " & cmbProductID.EditValue & " AND products_dvd_status = 1 and `inout` = 1 "
        _NewQtyNow = BKGlobal.ExecuteCount(_SQLTxt)
        _SQLTxt = "UPDATE products set products_quantity = " & _NewQtyNow & " WHERE products_id = " & cmbProductID.EditValue
        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        _row("products_quantity") = _NewQtyNow
        RefreshDVDInfo()
    End Sub

    Private Sub RefreshDVDInfoTab2()
        Dim _SQLTxt As String = "SELECT PD.* , P.products_model as products_model, P.Feesharing, P.feesharing_end FROM products_dvd PD " & _
                                " Left join products P on P.products_id = PD.products_id " & _
                                " where PD.products_id = " & CInt(txtProducts_id.EditValue) & " and  PD.products_dvdid = " & CInt(txtDVD_ID.EditValue)
        objDS.Tables("products_dvd_stock_a").Clear()
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_dvd_stock_a"), _SQLTxt)
        If objDS.Tables("products_dvd_stock_a").Rows.Count = 0 Then
            MsgBox("This DVD : " & txtProducts_id.EditValue & "-" & txtDVD_ID.EditValue & " does not exist", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        txtTitle2.EditValue = objDS.Tables("products_dvd_stock_a").Rows(0)("products_model")
        cmbActualDVDStatus.EditValue = objDS.Tables("products_dvd_stock_a").Rows(0)("products_dvd_status")
        txtACtualBoxID.EditValue = objDS.Tables("products_dvd_stock_a").Rows(0)("box_id")
        txtACtualPosID.EditValue = objDS.Tables("products_dvd_stock_a").Rows(0)("pibox_id")
        txtInOut.EditValue = objDS.Tables("products_dvd_stock_a").Rows(0)("inout")
        txtFeeSharing.EditValue = objDS.Tables("products_dvd_stock_a").Rows(0)("Feesharing")
        txtFeeSharingEnd.EditValue = objDS.Tables("products_dvd_stock_a").Rows(0)("feesharing_end")
        'For i = 0 To GridView1.RowCount - 1
        '    'GridView1.GetRow()
        'Next
        'txtBarCode.Focus()
    End Sub

    Private Sub ChangeDVDStatus(ByVal v_products_id As Integer, ByVal v_dvd_id As Integer, ByVal v_newstatus As Integer)
        Dim _DS As New dsProducts
        _objProductDVD = New clsProduct_DVD(SessionInfo, _DS, v_products_id, v_dvd_id)

        If _objProductDVD.INOUT <> DvdPostData.clsProductDvd.INOUT.IN Then
            MsgBox("Warning You must Process IN  !!", MsgBoxStyle.Critical)
            Return
        End If
        If v_newstatus = DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK Then
            MsgBox("Inventory to pass Status OK  !!", MsgBoxStyle.Critical)
            Return
        End If
        _objProductDVD.ChangeStateProductsDVD(v_newstatus, _
                                             "DVD Status Maint. changeDVDSTATUS", _
                                             DvdPostData.ClsProducts_dvd_state.state.STOCK)


    End Sub
    Private Sub btnChangeStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeStatus.Click
        ChangeDVDStatus(CInt(txtProducts_id.EditValue), CInt(txtDVD_ID.EditValue), cmbNewDVDStatus.EditValue)
        txtBarCode.DoValidate()
        txtBarCode.Focus()
        RefreshDVDInfoTab2()
    End Sub

    'Private Sub rdChgStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdChgStatus.SelectedIndexChanged
    '    btnChangeStatus.Visible = IIf(rdChgStatus.EditValue = 0, True, False)
    'End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        RefreshDVDInfo()
    End Sub

    Private Sub btnOK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK1.Click

        If txtBarCode.EditValue & "" = "" Then Exit Sub
        Dim CLs As New clsProduct_BarCode(txtBarCode.Text)
        If CLs.IsBarCodeValid Then
            txtProducts_id.Text = CLs.ProductID
            txtDVD_ID.EditValue = CLs.DVDID
            RefreshDVDInfoTab2()
            If ChkChgStatus.Checked Then
                If cmbNewDVDStatus.EditValue = 0 Then
                    MsgBox("Choose status before scan", MsgBoxStyle.Critical)
                Else
                    ChangeDVDStatus(CInt(txtProducts_id.EditValue), CInt(txtDVD_ID.EditValue), cmbNewDVDStatus.EditValue)
                End If

            Else
                'Nothing to do, just display the DVD info
            End If
            txtBarCode.DoValidate()
            txtBarCode.EditValue = ""
            txtBarCode.Focus()
            txtBarCode.Refresh()
        End If
    End Sub
    Private Sub btnFindBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindBarCode.Click
        Dim _productsId As Integer
        Dim _dvdId As Integer
        Dim _objProdDVD As clsProduct_DVD
        txtBarCode.Text.Trim()
        If txtBarCode.Text.IndexOf("-") <> -1 Then
            _productsId = txtBarCode.Text.Substring(0, txtBarCode.Text.IndexOf("-"))
            _dvdId = txtBarCode.Text.Substring(txtBarCode.Text.IndexOf("-") + 1)
            _objProdDVD = New clsProduct_DVD(SessionInfo, objDS, _productsId, _dvdId)
            If _objProdDVD.BarCode.IsBarCodeValid Then
                txtBarCode.EditValue = _objProdDVD.BarCode.Barcode
                txtBarCode.Refresh()
            Else

            End If
        End If

        'Dim Product_ID As String
        'Dim DVD_ID As Integer
        If txtBarCode.EditValue & "" = "" Then Exit Sub
        Dim cls As New clsProduct_BarCode(txtBarCode.Text)
        If cls.IsBarCodeValid Then

            'Product_ID = txtBarCode.Text.Substring(3, 6)
            txtProducts_id.Text = cls.ProductID
            'DVD_ID = txtBarCode.Text.Substring(9, 3)
            txtDVD_ID.EditValue = cls.DVDID
            RefreshDVDInfoTab2()
        End If
    End Sub

End Class
