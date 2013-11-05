Imports System.Windows.Forms.Application
Public Class frmStockInventory
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmbDVDStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents objDS As DVDPostLib.dsProducts
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBoxID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBarCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtProducts_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDVD_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colproducts_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvdid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvd_status1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbox_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpibox_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvdid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvd_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbox_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpibox_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbDVDStatus2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents StyleRed As DevExpress.XtraEditors.StyleController
    Friend WithEvents StyleGreen As DevExpress.XtraEditors.StyleController
    Friend WithEvents StyleBlue As DevExpress.XtraEditors.StyleController
    Friend WithEvents colbar_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPrintLabels As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrintSelected As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkADD As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnFindBarCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrint1 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.objDS = New DVDPostLib.dsProducts
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colproducts_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvdid = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvd_status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbDVDStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colbox_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpibox_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_model = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnOK1 = New DevExpress.XtraEditors.SimpleButton
        Me.btnFindBarCode = New DevExpress.XtraEditors.SimpleButton
        Me.chkADD = New DevExpress.XtraEditors.CheckEdit
        Me.btnPrintSelected = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrintLabels = New DevExpress.XtraEditors.SimpleButton
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton
        Me.txtDVD_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.txtBoxID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtProducts_id = New DevExpress.XtraEditors.TextEdit
        Me.txtBarCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colproducts_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvdid1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvd_status1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbDVDStatus2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colbox_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpibox_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbar_code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.StyleRed = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.StyleGreen = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.StyleBlue = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.btnPrint1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDVDStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.chkADD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDVDStatus2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'View_Bar
        '
        Me.View_Bar.DockCol = 2
        '
        'Main_Bar
        '
        Me.Main_Bar.DockCol = 4
        '
        'Misc_Bar2
        '
        Me.Misc_Bar2.DockCol = 3
        '
        'QuickSearch_Bar
        '
        Me.QuickSearch_Bar.DockCol = 8
        '
        'Misc_Bar
        '
        Me.Misc_Bar.DockCol = 5
        '
        'DefaultSet_Bar
        '
        Me.DefaultSet_Bar.DockCol = 6
        '
        'Filter_Bar
        '
        Me.Filter_Bar.DockCol = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(304, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Product ID"
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsProducts"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.objDS.products_dvd_stock_1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Left
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(6, 104)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbDVDStatus})
        Me.GridControl1.Size = New System.Drawing.Size(512, 286)
        Me.GridControl1.TabIndex = 20
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colproducts_id, Me.colproducts_dvdid, Me.colproducts_dvd_status, Me.colbox_id, Me.colpibox_id, Me.colproducts_model})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(873, 335, 208, 191)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colproducts_id
        '
        Me.colproducts_id.Caption = "products_id"
        Me.colproducts_id.FieldName = "products_id"
        Me.colproducts_id.Name = "colproducts_id"
        Me.colproducts_id.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colproducts_id.Visible = True
        Me.colproducts_id.VisibleIndex = 0
        Me.colproducts_id.Width = 98
        '
        'colproducts_dvdid
        '
        Me.colproducts_dvdid.Caption = "products_dvdid"
        Me.colproducts_dvdid.FieldName = "products_dvdid"
        Me.colproducts_dvdid.Name = "colproducts_dvdid"
        Me.colproducts_dvdid.Visible = True
        Me.colproducts_dvdid.VisibleIndex = 1
        Me.colproducts_dvdid.Width = 57
        '
        'colproducts_dvd_status
        '
        Me.colproducts_dvd_status.Caption = "products_dvd_status"
        Me.colproducts_dvd_status.ColumnEdit = Me.cmbDVDStatus
        Me.colproducts_dvd_status.FieldName = "products_dvd_status"
        Me.colproducts_dvd_status.Name = "colproducts_dvd_status"
        Me.colproducts_dvd_status.Visible = True
        Me.colproducts_dvd_status.VisibleIndex = 2
        Me.colproducts_dvd_status.Width = 59
        '
        'cmbDVDStatus
        '
        Me.cmbDVDStatus.AutoHeight = False
        Me.cmbDVDStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDVDStatus.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_dvd_status_id", "products_dvd_status_id", 135, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_dvd_status_name", "products_dvd_status_name", 140, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbDVDStatus.DataSource = Me.objDS.products_dvd_status
        Me.cmbDVDStatus.DisplayMember = "products_dvd_status_name"
        Me.cmbDVDStatus.Name = "cmbDVDStatus"
        Me.cmbDVDStatus.NullText = ""
        Me.cmbDVDStatus.ValueMember = "products_dvd_status_id"
        '
        'colbox_id
        '
        Me.colbox_id.Caption = "box_id"
        Me.colbox_id.FieldName = "box_id"
        Me.colbox_id.Name = "colbox_id"
        '
        'colpibox_id
        '
        Me.colpibox_id.Caption = "pibox_id"
        Me.colpibox_id.FieldName = "pibox_id"
        Me.colpibox_id.Name = "colpibox_id"
        Me.colpibox_id.Visible = True
        Me.colpibox_id.VisibleIndex = 3
        Me.colpibox_id.Width = 82
        '
        'colproducts_model
        '
        Me.colproducts_model.Caption = "products_model"
        Me.colproducts_model.FieldName = "products_model"
        Me.colproducts_model.Name = "colproducts_model"
        Me.colproducts_model.Visible = True
        Me.colproducts_model.VisibleIndex = 4
        Me.colproducts_model.Width = 195
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnPrint1)
        Me.PanelControl1.Controls.Add(Me.btnOK1)
        Me.PanelControl1.Controls.Add(Me.btnFindBarCode)
        Me.PanelControl1.Controls.Add(Me.chkADD)
        Me.PanelControl1.Controls.Add(Me.btnPrintSelected)
        Me.PanelControl1.Controls.Add(Me.btnPrintLabels)
        Me.PanelControl1.Controls.Add(Me.btnUpdate)
        Me.PanelControl1.Controls.Add(Me.txtDVD_ID)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.btnSearch)
        Me.PanelControl1.Controls.Add(Me.txtBoxID)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txtProducts_id)
        Me.PanelControl1.Controls.Add(Me.txtBarCode)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 26)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1040, 78)
        Me.PanelControl1.TabIndex = 30
        Me.PanelControl1.Text = "PanelControl1"
        '
        'btnOK1
        '
        Me.btnOK1.Location = New System.Drawing.Point(704, 16)
        Me.btnOK1.Name = "btnOK1"
        Me.btnOK1.Size = New System.Drawing.Size(88, 23)
        Me.btnOK1.TabIndex = 37
        Me.btnOK1.Text = "OK"
        '
        'btnFindBarCode
        '
        Me.btnFindBarCode.Location = New System.Drawing.Point(704, 40)
        Me.btnFindBarCode.Name = "btnFindBarCode"
        Me.btnFindBarCode.Size = New System.Drawing.Size(88, 23)
        Me.btnFindBarCode.TabIndex = 3
        Me.btnFindBarCode.Text = "Find Bar Code"
        '
        'chkADD
        '
        Me.chkADD.Location = New System.Drawing.Point(96, 48)
        Me.chkADD.Name = "chkADD"
        '
        'chkADD.Properties
        '
        Me.chkADD.Properties.Caption = "ADD DVD in this BOX"
        Me.chkADD.Size = New System.Drawing.Size(192, 19)
        Me.chkADD.TabIndex = 33
        '
        'btnPrintSelected
        '
        Me.btnPrintSelected.Location = New System.Drawing.Point(872, 40)
        Me.btnPrintSelected.Name = "btnPrintSelected"
        Me.btnPrintSelected.Size = New System.Drawing.Size(88, 23)
        Me.btnPrintSelected.TabIndex = 32
        Me.btnPrintSelected.Text = "Print Selected "
        '
        'btnPrintLabels
        '
        Me.btnPrintLabels.Location = New System.Drawing.Point(872, 16)
        Me.btnPrintLabels.Name = "btnPrintLabels"
        Me.btnPrintLabels.Size = New System.Drawing.Size(88, 23)
        Me.btnPrintLabels.TabIndex = 31
        Me.btnPrintLabels.Text = "Print ALL Labels"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(792, 16)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 23)
        Me.btnUpdate.TabIndex = 30
        Me.btnUpdate.Text = "Save"
        '
        'txtDVD_ID
        '
        Me.txtDVD_ID.Enabled = False
        Me.txtDVD_ID.Location = New System.Drawing.Point(592, 40)
        Me.txtDVD_ID.Name = "txtDVD_ID"
        '
        'txtDVD_ID.Properties
        '
        Me.txtDVD_ID.Properties.ReadOnly = True
        Me.txtDVD_ID.Size = New System.Drawing.Size(96, 20)
        Me.txtDVD_ID.TabIndex = 29
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(512, 40)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.TabIndex = 28
        Me.LabelControl5.Text = "DVD ID"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(208, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        '
        'txtBoxID
        '
        Me.txtBoxID.Location = New System.Drawing.Point(96, 16)
        Me.txtBoxID.Name = "txtBoxID"
        Me.txtBoxID.Size = New System.Drawing.Size(96, 20)
        Me.txtBoxID.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(16, 16)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.TabIndex = 25
        Me.LabelControl4.Text = "BoxID"
        '
        'txtProducts_id
        '
        Me.txtProducts_id.Enabled = False
        Me.txtProducts_id.Location = New System.Drawing.Point(384, 40)
        Me.txtProducts_id.Name = "txtProducts_id"
        '
        'txtProducts_id.Properties
        '
        Me.txtProducts_id.Properties.ReadOnly = True
        Me.txtProducts_id.Size = New System.Drawing.Size(96, 20)
        Me.txtProducts_id.TabIndex = 24
        '
        'txtBarCode
        '
        Me.txtBarCode.Location = New System.Drawing.Point(384, 16)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(304, 20)
        Me.txtBarCode.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(304, 16)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.TabIndex = 23
        Me.LabelControl2.Text = "BareCode"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 104)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(6, 286)
        Me.SplitterControl1.TabIndex = 31
        Me.SplitterControl1.TabStop = False
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.objDS.products_dvd_stock_2
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'GridControl2.EmbeddedNavigator
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(6, 104)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbDVDStatus2})
        Me.GridControl2.Size = New System.Drawing.Size(1034, 286)
        Me.GridControl2.TabIndex = 32
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colproducts_id1, Me.colproducts_dvdid1, Me.colproducts_dvd_status1, Me.colbox_id1, Me.colpibox_id1, Me.colbar_code})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowFooter = True
        '
        'colproducts_id1
        '
        Me.colproducts_id1.Caption = "products_id"
        Me.colproducts_id1.FieldName = "products_id"
        Me.colproducts_id1.Name = "colproducts_id1"
        Me.colproducts_id1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
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
        Me.colbox_id1.Visible = True
        Me.colbox_id1.VisibleIndex = 3
        '
        'colpibox_id1
        '
        Me.colpibox_id1.Caption = "pibox_id"
        Me.colpibox_id1.FieldName = "pibox_id"
        Me.colpibox_id1.Name = "colpibox_id1"
        Me.colpibox_id1.Visible = True
        Me.colpibox_id1.VisibleIndex = 4
        '
        'colbar_code
        '
        Me.colbar_code.Caption = "bar_code"
        Me.colbar_code.FieldName = "bar_code"
        Me.colbar_code.Name = "colbar_code"
        Me.colbar_code.Visible = True
        Me.colbar_code.VisibleIndex = 5
        '
        'StyleRed
        '
        Me.StyleRed.Appearance.BackColor = System.Drawing.Color.Red
        Me.StyleRed.Appearance.Options.UseBackColor = True
        '
        'StyleGreen
        '
        Me.StyleGreen.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(0, Byte))
        Me.StyleGreen.Appearance.Options.UseBackColor = True
        '
        'StyleBlue
        '
        Me.StyleBlue.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.StyleBlue.Appearance.Options.UseBackColor = True
        '
        'btnPrint1
        '
        Me.btnPrint1.Location = New System.Drawing.Point(792, 40)
        Me.btnPrint1.Name = "btnPrint1"
        Me.btnPrint1.Size = New System.Drawing.Size(80, 23)
        Me.btnPrint1.TabIndex = 38
        Me.btnPrint1.Text = "Print List"
        '
        'frmStockInventory
        '
        Me.AcceptButton = Me.btnOK1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1040, 390)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmStockInventory"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        Me.Controls.SetChildIndex(Me.SplitterControl1, 0)
        Me.Controls.SetChildIndex(Me.GridControl2, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDVDStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.chkADD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDVDStatus2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Pos_ID As Integer = 1
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        RefreshLists()
    End Sub
    Private Sub RefreshLists()
        Dim _SQLTxt As String = " SELECT PD.products_id, PD.products_dvdid, PD.products_dvd_status, PD.box_id, PD.pibox_id, " & _
                                " P.products_model as products_model FROM products_dvd PD " & _
                                " Left join products P on P.products_id = PD.products_id " & _
                                " where  PD.box_id = '" & txtBoxID.EditValue & "' Order by pibox_id "
        '" where PD.`inout` = 1 and PD.products_dvd_status = 1 and PD.box_id = '" & _
        objDS.Tables("products_dvd_stock_1").Clear()
        objDS.Tables("products_dvd_stock_2").Clear()
        Pos_ID = 1
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_dvd_stock_1"), _SQLTxt)
        _SQLTxt = "SELECT PD.products_id, PD.products_dvdid, PD.products_dvd_status, PD.box_id, PD.pibox_id, P.products_model as products_model FROM products_dvd PD " & _
                                        " Left join products P on P.products_id = PD.products_id " & _
                                        " where PD.box_id = -9999999 "
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_dvd_stock_2"), _SQLTxt)
        'For i = 0 To GridView1.RowCount - 1
        '    'GridView1.GetRow()
        'Next
        txtBarCode.Enabled = True
        txtBarCode.Focus()

    End Sub

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        GridControl1.ContextMenuStrip = menuStrip
        GridControl2.ContextMenuStrip = menuStrip

        'Load DVD Status List
        MsgBox("This Program Is Obsolete. User Stock Inventory Actif/Passif.", MsgBoxStyle.Exclamation)
        Me.Close()
        Dim _SQLTxt As String = "SELECT * FROM products_dvd_status"
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_dvd_status"), _SQLTxt)
    End Sub
    Public Sub BarCode_OK()
        'Dim Product_ID As String
        'Dim DVD_ID As Integer
        Dim _OLDRow As DataRow
        Dim _NewRow As DataRow
        Dim _DS As New dsProducts
        Dim _objProductDVD As clsProduct_DVD

        If txtBarCode.Enabled = False Then Exit Sub
        txtBarCode.Enabled = False
        _objProductDVD = New clsProduct_DVD(SessionInfo, objDS, txtBarCode.Text)
        If Not _objProductDVD.BarCode.IsBarCodeValid Then
            Beep()
            MsgBox("BAR CODE IS NOT VALIDE", MsgBoxStyle.Critical)
            Exit Sub
        End If
        txtProducts_id.EditValue = _objProductDVD.ProductsID
        txtDVD_ID.EditValue = _objProductDVD.DvdId
        _objProductDVD.LoadExpeditedOrders()
        If _objProductDVD.OrdersDataTable.Rows.Count > 0 Then
            MsgBox("OPEN Orders exist. Please use Process IN", MsgBoxStyle.Critical)
            Exit Sub
        Else
        End If
        'Product_ID = txtBarCode.Text.Substring(3, 6)
        'txtProducts_id.Text = Product_ID
        'DVD_ID = txtBarCode.Text.Substring(9, 3)
        'txtDVD_ID.EditValue = DVD_ID
        '_view = New DataView(objDS.Tables("products_dvd_stock_2"), "products_id = " & _objProductDVD.ProductsId & _
        '        " AND products_dvdid = " & _objProductDVD.DvdId, "", DataViewRowState.CurrentRows)
        'If _view.Count > 0 Then Exit Sub
        Dim _Row As DataRow = objDS.Tables("products_dvd_stock_2").Rows.Find(New Object() {_objProductDVD.ProductsID, _objProductDVD.DvdId})
        If Not IsNothing(_Row) Then
            EnableBarCode()
            Exit Sub
        End If
        Dim _SQLTxt As String = "SELECT PD.products_id, PD.products_dvdid, PD.products_dvd_status, PD.box_id, PD.pibox_id, " & _
                    " P.products_model as products_model FROM products_dvd PD " & _
                    " Left join products P on P.products_id = PD.products_id " & _
                    " where PD.products_id = " & _objProductDVD.ProductsID & " AND PD.products_dvdid = " & _objProductDVD.DvdId

        DvdPostData.clsConnection.FillDataSet(_DS.Tables("products_dvd_stock_2"), _SQLTxt)
        If _DS.Tables("products_dvd_stock_2").Rows.Count = 0 Then
            MsgBox("Invalid DVD, Gve it to Fred or Manu", MsgBoxStyle.Critical)
            EnableBarCode()
            Exit Sub
        End If
        _OLDRow = _DS.Tables("products_dvd_stock_2").Rows(0)
        _NewRow = objDS.Tables("products_dvd_stock_2").NewRow
        '_NewRow.ItemArray = _OLDRow.ItemArray
        _NewRow("products_id") = _OLDRow("products_id")
        _NewRow("products_dvdid") = _OLDRow("products_dvdid")
        _NewRow("products_dvd_status") = _OLDRow("products_dvd_status")
        _NewRow("box_id") = txtBoxID.EditValue
        _NewRow("pibox_id") = Pos_ID
        _NewRow("bar_code") = txtBarCode.EditValue
        Pos_ID += 1
        objDS.Tables("products_dvd_stock_2").Rows.Add(_NewRow)
        EnableBarCode()
        'txtBarCode.Enabled = True
        'txtBarCode.EditValue = ""
        'txtBarCode.Refresh()
        'txtBarCode.Focus()
        'DoEvents()

    End Sub
    Private Sub EnableBarCode()
        txtBarCode.Text = ""
        txtBarCode.Enabled = True
        txtBarCode.Focus()
        DoEvents()

    End Sub
    Private Sub txtBarCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBarCode.TextChanged
        'BarCode_OK()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        SaveTheBox()
    End Sub
    Private Sub SaveTheBox()
        Dim _row As DataRow
        Dim _SQLTxt As String
        Dim _StartPosition As Integer
        Dim objProductDVD As clsProduct_DVD
        Dim _DS As New dsProducts
        Dim _i As Integer
        'IF Not adding then replacing
        If Not chkADD.Checked Then
            'TO Replace, SET status = 15 = Bizzarement Perdu to all DVD in this Box
            'For Each _row In objDS.Tables("products_dvd_stock_1").Rows
            '    _objProduct = New clsProduct_DVD(SessionInfo, _DS, _row("products_id"), _row("products_dvdid"))
            '    _objProduct.SetProductsStatusBox(15, 0, 0)
            '    _objProduct.ChangeProductsQuantity(-1)
            'Next
            _SQLTxt = "update products_dvd SET products_dvd_status = 15 , last_adminby = " & _
                      DvdPostData.clsSession.user_id & " , last_admindate = '" & Now & "', box_id = 0  , pibox_id = 0 " & _
                      " WHERE box_id = " & txtBoxID.EditValue
            DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
            _i = DvdPostData.clsConnection.ExecuteNonQuery("")
            DoEvents()
            _StartPosition = 0
        Else
            'ADDING - then find the position of the last DVD in the BOX
            _StartPosition = objDS.Tables("products_dvd_stock_1").Rows.Count
        End If
        _i = 0
        For Each _row In objDS.Tables("products_dvd_stock_2").Rows
            _i += 1
            txtProducts_id.Text = "Saving Nbr : " & _i.ToString
            DoEvents()
            'ADD DVD to this BOX - Set Status = 0 = OK and set the BoxID and the Position_in_Box_ID
            objProductDVD = New clsProduct_DVD(SessionInfo, _DS, _row("products_id"), _row("products_dvdid"))
            objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK, _
                                                 _row("box_id"), _StartPosition + _row("pibox_id"), _
                                                  "StockInventory saveBOX", _
                                                  DvdPostData.ClsProducts_dvd_state.state.STOCK)
        Next
        txtProducts_id.Text = ""
        DoEvents()
        RefreshLists()
    End Sub
    Private Sub btnPrintLabels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintLabels.Click
        Dim _row, _labelRow As DataRow
        Dim _DS As New dsProducts
        Dim _objProducts As clsProduct_DVD
        For Each _row In objDS.Tables("products_dvd_stock_1").Rows
            _objProducts = New clsProduct_DVD(SessionInfo, _DS, _row("products_id"), _row("products_dvdid"))
            '_row("bar_code") = barcode(_row("products_id"), _row("products_dvdid"))
            _labelRow = _DS.Tables("products_labels").NewRow
            _labelRow("products_id") = _row("products_id")
            _labelRow("dvd_id") = _row("products_dvdid")
            _labelRow("IDStr") = _row("products_id") & "-" & _row("products_dvdid")
            _labelRow("bar_code") = _objProducts.BarCode.Barcode '_objProducts.barcode(_row("products_id"), _row("products_dvdid"))
            _labelRow("Lang") = _objProducts.GetProductLangLabel()
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
        Dim _objProducts As clsProduct_DVD
        Dim _i As Integer
        For Each _i In GridView1.GetSelectedRows
            _row = GridView1.GetDataRow(_i)
            _objProducts = New clsProduct_DVD(SessionInfo, _DS, _row("products_id"), _i)
            '_row("bar_code") = barcode(_row("products_id"), _row("products_dvdid"))
            _labelRow = _DS.Tables("products_labels").NewRow
            _labelRow("products_id") = _row("products_id")
            _labelRow("dvd_id") = _row("products_dvdid")
            _labelRow("IDStr") = _row("products_id") & "-" & _row("products_dvdid")
            _labelRow("bar_code") = _objProducts.BarCode.Barcode '_objProducts.barcode(_row("products_id"), _row("products_dvdid"))
            _labelRow("Lang") = _objProducts.GetProductLangLabel()
            _DS.Tables("products_labels").Rows.Add(_labelRow)
        Next
        Dim _rpt As New rptDVDLabel
        _rpt.objDS = _DS
        _rpt.DataMember = ""
        _rpt.DataSource = _DS.Tables("products_labels")
        _rpt.ShowPreview()

    End Sub

    Private Sub txtBoxID_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtBoxID.EditValueChanging
        Dim _answ As MsgBoxResult
        If objDS.Tables("products_dvd_stock_1").Rows.Count > 0 And objDS.Tables("products_dvd_stock_2").Rows.Count > 0 Then
            _answ = MsgBox("Do you want to save before changing the BOX ID ?", MsgBoxStyle.YesNoCancel, "Confirme")
            If _answ = MsgBoxResult.Cancel Then
                e.Cancel = True
                Exit Sub
            End If
            If _answ = MsgBoxResult.No Then
                objDS.Tables("products_dvd_stock_1").Clear()
            End If
            If _answ = MsgBoxResult.Yes Then
                SaveTheBox()
            End If
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
    End Sub

    Private Sub btnOK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK1.Click
        BarCode_OK()
    End Sub

    Private Sub btnPrint1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint1.Click
        Dim PrtSys1 As New DevExpress.XtraPrinting.PrintingSystem
        Dim Link1 As New DevExpress.XtraPrinting.PrintableComponentLink
        PrtSys1.Links.Add(Link1)
        Link1.Component = GridControl1
        Link1.CreateDocument(PrtSys1)
        'PrtSys1.PageSettings.Landscape = LandScape
        PrtSys1.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        PrtSys1.PreviewFormEx.Show()
    End Sub
End Class
