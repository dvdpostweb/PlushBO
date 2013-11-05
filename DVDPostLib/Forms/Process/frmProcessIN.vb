Imports System.Windows.Forms.Application
Public Class frmProcessIN
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
    Friend WithEvents colproducts_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvdid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvd_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbox_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpibox_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleRed As DevExpress.XtraEditors.StyleController
    Friend WithEvents StyleGreen As DevExpress.XtraEditors.StyleController
    Friend WithEvents StyleBlue As DevExpress.XtraEditors.StyleController
    Friend WithEvents colproducts_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtINFO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnFindBarCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnResetNbrs As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFindBox As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkIsBroken As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkIsDamaged As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colbar_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstock_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_io As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colinout As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkBadLabel As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAllDVD As DevExpress.XtraEditors.CheckEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
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
        Me.colbar_code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colstock_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_io = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colinout = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.chkAllDVD = New DevExpress.XtraEditors.CheckEdit
        Me.chkBadLabel = New DevExpress.XtraEditors.CheckEdit
        Me.chkIsDamaged = New DevExpress.XtraEditors.CheckEdit
        Me.chkIsBroken = New DevExpress.XtraEditors.CheckEdit
        Me.btnFindBox = New DevExpress.XtraEditors.SimpleButton
        Me.btnOK1 = New DevExpress.XtraEditors.SimpleButton
        Me.btnResetNbrs = New DevExpress.XtraEditors.SimpleButton
        Me.btnFindBarCode = New DevExpress.XtraEditors.SimpleButton
        Me.txtINFO = New DevExpress.XtraEditors.TextEdit
        Me.txtDVD_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.txtBoxID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtProducts_id = New DevExpress.XtraEditors.TextEdit
        Me.txtBarCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl
        Me.StyleRed = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.StyleGreen = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.StyleBlue = New DevExpress.XtraEditors.StyleController(Me.components)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.chkAllDVD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBadLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsDamaged.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsBroken.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtINFO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(304, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Product ID"
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsProducts"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.objDS.products_dvd_stock_1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.FormsUseDefaultLookAndFeel = False
        Me.GridControl1.Location = New System.Drawing.Point(6, 132)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbDVDStatus})
        Me.GridControl1.Size = New System.Drawing.Size(730, 258)
        Me.GridControl1.TabIndex = 20
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colproducts_id, Me.colproducts_dvdid, Me.colproducts_dvd_status, Me.colbox_id, Me.colpibox_id, Me.colproducts_model, Me.colbar_code, Me.colstock_type, Me.colproducts_io, Me.colinout})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(873, 335, 208, 191)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
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
        Me.colproducts_model.Width = 195
        '
        'colbar_code
        '
        Me.colbar_code.Caption = "bar_code"
        Me.colbar_code.FieldName = "bar_code"
        Me.colbar_code.Name = "colbar_code"
        '
        'colstock_type
        '
        Me.colstock_type.Caption = "stock_type"
        Me.colstock_type.FieldName = "stock_type"
        Me.colstock_type.Name = "colstock_type"
        '
        'colproducts_io
        '
        Me.colproducts_io.Caption = "products_io"
        Me.colproducts_io.FieldName = "products_io"
        Me.colproducts_io.Name = "colproducts_io"
        '
        'colinout
        '
        Me.colinout.Caption = "inout"
        Me.colinout.FieldName = "inout"
        Me.colinout.Name = "colinout"
        Me.colinout.Visible = True
        Me.colinout.VisibleIndex = 4
        '
        'PanelControl1
        '
        Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl1.Controls.Add(Me.chkAllDVD)
        Me.PanelControl1.Controls.Add(Me.chkBadLabel)
        Me.PanelControl1.Controls.Add(Me.chkIsDamaged)
        Me.PanelControl1.Controls.Add(Me.chkIsBroken)
        Me.PanelControl1.Controls.Add(Me.btnFindBox)
        Me.PanelControl1.Controls.Add(Me.btnOK1)
        Me.PanelControl1.Controls.Add(Me.btnResetNbrs)
        Me.PanelControl1.Controls.Add(Me.btnFindBarCode)
        Me.PanelControl1.Controls.Add(Me.txtINFO)
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
        Me.PanelControl1.Location = New System.Drawing.Point(0, 30)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1040, 102)
        Me.PanelControl1.TabIndex = 30
        '
        'chkAllDVD
        '
        Me.chkAllDVD.Location = New System.Drawing.Point(16, 40)
        Me.chkAllDVD.Name = "chkAllDVD"
        Me.chkAllDVD.Properties.Caption = "All DVD"
        Me.chkAllDVD.Size = New System.Drawing.Size(75, 19)
        Me.chkAllDVD.TabIndex = 41
        Me.chkAllDVD.ToolTip = "etat de la boite"
        '
        'chkBadLabel
        '
        Me.chkBadLabel.Location = New System.Drawing.Point(832, 56)
        Me.chkBadLabel.Name = "chkBadLabel"
        Me.chkBadLabel.Properties.Caption = "Bad Label (Boite 60.000)"
        Me.chkBadLabel.Size = New System.Drawing.Size(192, 19)
        Me.chkBadLabel.TabIndex = 40
        '
        'chkIsDamaged
        '
        Me.chkIsDamaged.Location = New System.Drawing.Point(832, 32)
        Me.chkIsDamaged.Name = "chkIsDamaged"
        Me.chkIsDamaged.Properties.Caption = "Is Damaged (Boite 70.000)"
        Me.chkIsDamaged.Size = New System.Drawing.Size(192, 19)
        Me.chkIsDamaged.TabIndex = 39
        Me.chkIsDamaged.Visible = False
        '
        'chkIsBroken
        '
        Me.chkIsBroken.Location = New System.Drawing.Point(832, 8)
        Me.chkIsBroken.Name = "chkIsBroken"
        Me.chkIsBroken.Properties.Caption = "Is Broken"
        Me.chkIsBroken.Size = New System.Drawing.Size(75, 19)
        Me.chkIsBroken.TabIndex = 38
        '
        'btnFindBox
        '
        Me.btnFindBox.Location = New System.Drawing.Point(96, 40)
        Me.btnFindBox.Name = "btnFindBox"
        Me.btnFindBox.Size = New System.Drawing.Size(72, 23)
        ToolTipTitleItem1.Text = "Reser Numbers"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "This will reser dvd position id in the box"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnFindBox.SuperTip = SuperToolTip1
        Me.btnFindBox.TabIndex = 37
        Me.btnFindBox.Text = "Find a Box"
        '
        'btnOK1
        '
        Me.btnOK1.Location = New System.Drawing.Point(712, 16)
        Me.btnOK1.Name = "btnOK1"
        Me.btnOK1.Size = New System.Drawing.Size(104, 23)
        Me.btnOK1.TabIndex = 36
        Me.btnOK1.Text = "OK"
        '
        'btnResetNbrs
        '
        Me.btnResetNbrs.Location = New System.Drawing.Point(208, 40)
        Me.btnResetNbrs.Name = "btnResetNbrs"
        Me.btnResetNbrs.Size = New System.Drawing.Size(72, 23)
        ToolTipTitleItem2.Text = "Reser Numbers"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "This will reser dvd position id in the box"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btnResetNbrs.SuperTip = SuperToolTip2
        Me.btnResetNbrs.TabIndex = 35
        Me.btnResetNbrs.Text = "Reset Nbrs"
        '
        'btnFindBarCode
        '
        Me.btnFindBarCode.Location = New System.Drawing.Point(712, 40)
        Me.btnFindBarCode.Name = "btnFindBarCode"
        Me.btnFindBarCode.Size = New System.Drawing.Size(104, 23)
        Me.btnFindBarCode.TabIndex = 3
        Me.btnFindBarCode.Text = "Find Bar Code"
        '
        'txtINFO
        '
        Me.txtINFO.Location = New System.Drawing.Point(96, 72)
        Me.txtINFO.Name = "txtINFO"
        Me.txtINFO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtINFO.Properties.Appearance.ForeColor = System.Drawing.Color.Firebrick
        Me.txtINFO.Properties.Appearance.Options.UseFont = True
        Me.txtINFO.Properties.Appearance.Options.UseForeColor = True
        Me.txtINFO.Size = New System.Drawing.Size(592, 23)
        Me.txtINFO.TabIndex = 34
        '
        'txtDVD_ID
        '
        Me.txtDVD_ID.Enabled = False
        Me.txtDVD_ID.Location = New System.Drawing.Point(592, 40)
        Me.txtDVD_ID.Name = "txtDVD_ID"
        Me.txtDVD_ID.Properties.ReadOnly = True
        Me.txtDVD_ID.Size = New System.Drawing.Size(96, 20)
        Me.txtDVD_ID.TabIndex = 29
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(512, 40)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl5.TabIndex = 28
        Me.LabelControl5.Text = "DVD ID"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(208, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(72, 23)
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
        Me.LabelControl4.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl4.TabIndex = 25
        Me.LabelControl4.Text = "BoxID"
        '
        'txtProducts_id
        '
        Me.txtProducts_id.Enabled = False
        Me.txtProducts_id.Location = New System.Drawing.Point(384, 40)
        Me.txtProducts_id.Name = "txtProducts_id"
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
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 23
        Me.LabelControl2.Text = "BareCode"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 132)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(6, 258)
        Me.SplitterControl1.TabIndex = 31
        Me.SplitterControl1.TabStop = False
        '
        'StyleRed
        '
        Me.StyleRed.Appearance.BackColor = System.Drawing.Color.Red
        Me.StyleRed.Appearance.Options.UseBackColor = True
        '
        'StyleGreen
        '
        Me.StyleGreen.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StyleGreen.Appearance.Options.UseBackColor = True
        '
        'StyleBlue
        '
        Me.StyleBlue.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StyleBlue.Appearance.Options.UseBackColor = True
        '
        'frmProcessIN
        '
        Me.AcceptButton = Me.btnOK1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1040, 390)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmProcessIN"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        Me.Controls.SetChildIndex(Me.SplitterControl1, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.PanelControl1.PerformLayout()
        CType(Me.chkAllDVD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBadLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsDamaged.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsBroken.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtINFO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim mvarPos_ID As Integer = 1
    Dim mvarStartPosition As Integer
    Dim IsBroken As Boolean = False
    Dim IsDamaged As Boolean = False
    Const MAXPARTINBOX As Integer = 5
    Const _nametable As String = "products_dvd_stock_1"
    Private NbrDVDByBox As Int16 = 20

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim _SQLTxt As String
        If Not chkAllDVD.Checked Then
            _SQLTxt = DvdPostData.clsProcessIN.getDVDInStockAndReady(txtBoxID.EditValue)
        Else
            _SQLTxt = DvdPostData.clsProcessIN.getDVDInStock(txtBoxID.EditValue)
        End If

        objDS.Tables(_nametable).Clear()
        '  objDS.Tables("products_dvd_stock_2").Clear()
        DvdPostData.clsConnection.FillDataSet(objDS.Tables(_nametable), _SQLTxt)
        '_SQLTxt = DvdPostData.clsProcessIN.getDVDBoxOnly(-9999999)
        'DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_dvd_stock_2"), _SQLTxt)
        'For i = 0 To GridView1.RowCount - 1
        '    'GridView1.GetRow()
        'Next
        mvarStartPosition = objDS.Tables(_nametable).Rows.Count
        GridControl1.DataSource = objDS.Tables(_nametable)
        mvarPos_ID = mvarStartPosition + 1
        txtBarCode.Enabled = True
        txtBarCode.Focus()
    End Sub
    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        GridControl1.ContextMenuStrip = menuStrip

        '  DvdPostData.clsConnection.ExecuteNonQuery("UPDATE products_dvd set last_admindate = Null where last_admindate = '0000-00-00 00:00:00'")
        'Load DVD Status List
        ' Dim _SQLTxt As String = "SELECT * FROM products_dvd_status"
        ' DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_dvd_status"), _SQLTxt)
    End Sub

    Private Sub txtBoxID_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtBoxID.EditValueChanging
        'objDS.Tables(_nametable).Clear()
        txtBarCode.Enabled = False
    End Sub
    Private Sub EnableBarCode()
        txtBarCode.Text = ""
        txtBarCode.Enabled = True
        txtBarCode.Focus()
        txtBarCode.Refresh()
        'DoEvents()

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
    Private Function NotExistBox(ByVal dt As DataTable, ByVal objProductDVD As clsProduct_DVD, ByRef Order_Status As Integer) As Boolean
        Dim DVD_Row As DataRow
        DVD_Row = dt.Rows.Find(New Object() {objProductDVD.ProductsID, objProductDVD.DvdId})
        ' Deja Scanne 
        If DVD_Row IsNot Nothing Then
            txtINFO.Text = "DVD already in this box !!"
            MsgBox(txtINFO.Text, MsgBoxStyle.Critical)
            Order_Status = -1
            Return False
        End If
        Return True
    End Function
    Private Function ValidLabel(ByRef objProductDVD As clsProduct_DVD) As Boolean
        If chkBadLabel.Checked Then
            'objProductDVD.ChangeDVDStatus2(txtProducts_id.EditValue, txtDVD_ID.EditValue, 1, 60000, 1, "Process IN - Bad Label")
            objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_BADLABEL, _
            "Process IN - " & DVDPostTools.clsEnum.getNameStrEnum(objProductDVD.products_dvd_status), DvdPostData.ClsProducts_dvd_state.state.IN)

            txtINFO.Text = "Mettre ce DVD dans la boite " & DVDPostTools.clsEnum.getNameStrEnum(objProductDVD.products_dvd_status)
            MsgBox(txtINFO.Text, MsgBoxStyle.Critical)

            Return False
        End If
        Return True
    End Function

    Private Function NotExistInStock(ByRef objProductDVD As clsProduct_DVD, ByRef Order_Status As Integer, ByRef Comment As String) As Boolean
        Dim Answ As MsgBoxResult
        Dim warning As String = ""
        If objProductDVD.INOUT = DvdPostData.clsProductDvd.INOUT.IN Then
            If objProductDVD.products_dvd_status <> DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK Then
                warning = "PREVIOUS STATUS ( " & DVDPostTools.clsEnum.getNameStrEnum(objProductDVD.products_dvd_status) & " ) !!"
            End If
            txtINFO.Text = warning & " DVD deja en stock. Voulez vous ranger ce DVD dans cette boite?"
            Answ = MsgBox(txtINFO.Text, MsgBoxStyle.YesNo)
            If Answ = MsgBoxResult.Yes Then
                '  objProductDVD.ChangeBox(vBoxID, vPiBoxID)
                ' objProductDVD.LogStatusDVD("Process IN - already in stock")
                Comment = "Process IN - already in stock"
                Order_Status = DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_ALREADYBOX
            Else
                Order_Status = -1
            End If
            Return False
        End If
        Return True
    End Function

    Private Sub ChkAlert(ByRef objProductDVD As clsProduct_DVD, ByRef Order_Status As Integer)
        ' objProductDVD.LoadFirstAlarm()

        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.clsProductsAlert.getProductsAlert(objProductDVD.ProductsID, objProductDVD.DvdId)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        If dt.Rows.Count > 0 Then
            txtINFO.Text = dt.Rows(0)("alert_comment") & " - Ne PAS mettre ce DVD dans la boite"
            'Beep()
            MsgBox(txtINFO.Text, MsgBoxStyle.Critical)
            txtINFO.Focus()
            Order_Status = DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_CUSTSERV
        End If

    End Sub

    Private Function NotExistOrder(ByRef objProductDVD As clsProduct_DVD, ByRef dr As DataRow, ByRef Order_Status As Integer, ByRef comment As String) As Boolean
        dr = objProductDVD.GetlastOrder(objProductDVD.ProductsID, objProductDVD.DvdId)
        Dim Answ As MsgBoxResult

        If dr Is Nothing Then
            MsgBox("Error check the order of this dvd !!", MsgBoxStyle.Critical)
            Order_Status = -1
            Return False
        Else
            Dim orders_status As Integer = dr("orders_status")
            If orders_status = DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_RETURNED Then
                txtINFO.Text = "DVD jamais commandé " & objProductDVD.ProductsID & "-" & objProductDVD.DvdId & ". Voulez vous ranger ce DVD dans la boite?"
                Answ = MsgBox(txtINFO.Text, MsgBoxStyle.YesNo)
                If Answ = MsgBoxResult.Yes Then
                    comment = "Process IN - No Order Found"
                    Order_Status = DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_NOORDER
                Else
                    Order_Status = -1
                End If
                Return False
            Else
                Return True
            End If

        End If

    End Function

    Private Sub ChkDVDStatuslongTime(ByVal OrderRow As DataRow, ByRef orders_status As Integer)
        If OrderRow("products_dvd_status") = DvdPostData.clsProductDvd.DVDStatus.LONGTIME_CUSTOMER Then
            txtINFO.Text = "DVD LongTime@Customer "
            MsgBox(txtINFO.Text, MsgBoxStyle.Critical)

        End If

    End Sub

    Private Sub ChkDVDStatusDamaged(ByVal OrderRow As DataRow, ByRef orders_status As Integer)
        If OrderRow("products_dvd_status") = DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_DAMAGED Then
            txtINFO.Text = "DVD illisible. Mettre ce DVD dans la Boite " & DvdPostData.clsProductDvd.BOXTYPE.DAMAGED
            MsgBox(txtINFO.Text, MsgBoxStyle.Critical)
            orders_status = DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_DAMAGED
        End If

    End Sub

    Private Sub ChkDVDStatusBroken(ByVal OrderRow As DataRow, ByRef orders_status As Integer)
        If OrderRow("products_dvd_status") = DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_BROKEN Or _
            chkIsBroken.Checked Then

            txtINFO.Text = "DVD cassé. Mettre ce DVD dans la Boite " & DvdPostData.clsProductDvd.BOXTYPE.BROKEN
            MsgBox(txtINFO.Text, MsgBoxStyle.Critical)
            orders_status = DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_broken

        End If

    End Sub
    Private Sub clearInfo()
        chkIsBroken.Checked = False
        chkBadLabel.Checked = False
        txtINFO.Text = ""
        EnableBarCode()
    End Sub
    Public Sub BarCode_OK()
        Dim NewRow As DataRow
        Dim DS As New dsProducts

        Dim objProductDVD As clsProduct_DVD
        If txtBoxID.EditValue Is Nothing Then
            MsgBox("Choose one box before ", MsgBoxStyle.Critical)
            Return
        End If
        objProductDVD = GetCodeBar(txtBarCode.Text)
        If objProductDVD Is Nothing Then Return

        If objDS.Tables(_nametable) Is Nothing OrElse objDS.Tables(_nametable).Rows.Count >= NbrDVDByBox And txtBoxID.EditValue > 0 Then
            MsgBox("Full Box ! Change Box please ", MsgBoxStyle.Exclamation)
            btnResetNbrs_Click(Nothing, Nothing)
            txtBoxID.EditValue = txtBoxID.EditValue + 1
            btnSearch_Click(Nothing, Nothing)
            clearInfo()
            Return
        End If

        If Not ValidLabel(objProductDVD) Then
            Return
        End If

        txtProducts_id.EditValue = objProductDVD.ProductsID
        txtDVD_ID.EditValue = objProductDVD.DvdId
        Dim RowLastOrders As DataRow = Nothing
        Dim orders_status As Integer = -1
        Dim comment As String = ""
        Dim box_Id As Integer = txtBoxID.EditValue
        Dim PosBox_id As Integer = mvarPos_ID
        Dim ok As Boolean = False

        If NotExistBox(objDS.Tables(_nametable), objProductDVD, orders_status) Then
            If NotExistInStock(objProductDVD, orders_status, comment) Then
                If NotExistOrder(objProductDVD, RowLastOrders, orders_status, comment) Then
                    orders_status = RowLastOrders("orders_status")
                    ChkAlert(objProductDVD, orders_status)
                    ChkDVDStatusDamaged(RowLastOrders, orders_status)
                    ChkDVDStatusBroken(RowLastOrders, orders_status)

                End If
            End If
        End If
        If orders_status <> -1 Then

            Dim orders_id As Integer = 0
            Dim customers_id As Integer = 0

            If RowLastOrders IsNot Nothing Then
                orders_id = RowLastOrders("orders_id")
                customers_id = RowLastOrders("customers_id")
            End If
            ok = objProductDVD.processDVDIn(orders_status, box_Id, PosBox_id, orders_id, customers_id, comment)

            If ok Then

                NewRow = objDS.Tables(_nametable).NewRow
                NewRow("products_id") = objProductDVD.ProductsID
                NewRow("products_dvdid") = objProductDVD.DvdId
                NewRow("products_dvd_status") = 1
                NewRow("box_id") = txtBoxID.EditValue
                NewRow("pibox_id") = DVDPostBuziness.ClsproductsDvd.getLastPosBox(objDS.Tables(_nametable), "pibox_id") + 1
                NewRow("bar_code") = txtBarCode.EditValue
                NewRow("inout") = 1
                objDS.Tables(_nametable).Rows.Add(NewRow)

                clearInfo()
            Else
                EnableBarCode()
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
                chkBadLabel.Checked = True
            End If
        End If
    End Sub

    Private Sub btnResetNbrs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetNbrs.Click

        DVDPostBuziness.ClsproductsDvd.resetposinbox(objDS.Tables(_nametable))
      
    End Sub

    Private Sub btnOK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK1.Click
        BarCode_OK()
    End Sub

    Private Sub btnFindBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindBox.Click
        Dim _frm As New frmBoxList
        '  Dim _SQLTXt As String = "SELECT box_id mod 5, count(*) as DVD_Count from products_dvd where `inout` = 1 and products_dvd_status = 1 group by box_id mod 5"

        Dim sql As String
        sql = "select ((xx.box * " & MAXPARTINBOX & ") + 1) min ,((xx.box+1)*" & MAXPARTINBOX & ") max,dvd_count from ( " & _
              " SELECT ((box_id -1) div " & MAXPARTINBOX & ") box, count(*) as DVD_Count from products_dvd where `inout` = 1 and products_dvd_status = 1 and box_id > 0 and box_id < 50000 group by ((box_id - 1) div " & MAXPARTINBOX & ")) xx " & _
              " order by dvd_count "
        Dim _DS As New DataSet
        _DS.Tables.Add("BoxList")
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("BoxList"), sql)
        ' Dim _View As New DataView(_DS.Tables("BoxList"), "", "DVD_Count", DataViewRowState.CurrentRows)
        _frm.GridControl1.DataSource = _DS.Tables("BoxList")
        _frm.ShowDialog(Me)
    End Sub

    Private Sub chkIsBroken_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIsBroken.CheckedChanged
        Checked()
    End Sub

    Private Sub chkIsDamaged_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIsDamaged.CheckedChanged
        Checked()
    End Sub

    Private Sub chkBadLabel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBadLabel.CheckedChanged
        Checked()
    End Sub

    Private Sub Checked()
        If Me.chkBadLabel.Checked = True Then
            Me.chkIsBroken.Checked = False
            Me.chkIsDamaged.Checked = False

        End If

        If Me.chkIsDamaged.Checked = True Then
            Me.chkIsBroken.Checked = False
            Me.chkBadLabel.Checked = False


        End If

        If Me.chkIsBroken.Checked = True Then
            Me.chkBadLabel.Checked = False
            Me.chkIsDamaged.Checked = False

        End If


    End Sub


End Class

