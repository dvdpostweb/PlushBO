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
    Friend WithEvents GridIN As DevExpress.XtraGrid.GridControl
    Friend WithEvents cmbDVDStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents objDS As DVDPostLib.dsProducts
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBarCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtProducts_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDVD_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents StyleRed As DevExpress.XtraEditors.StyleController
    Friend WithEvents StyleGreen As DevExpress.XtraEditors.StyleController
    Friend WithEvents StyleBlue As DevExpress.XtraEditors.StyleController
    Friend WithEvents txtINFO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnFindBarCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnResetNbrs As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkIsBroken As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkIsDamaged As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkBadLabel As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnUnlock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBoxID As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GridViewIN As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colproducts_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_dvdid As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_dvd_status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colbox_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colpibox_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_model As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colbar_code As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colstock_type As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_io As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colinout As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents chkAllDVD As DevExpress.XtraEditors.CheckEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.objDS = New DVDPostLib.dsProducts
        Me.GridIN = New DevExpress.XtraGrid.GridControl
        Me.GridViewIN = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colproducts_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_dvdid = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_dvd_status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbDVDStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colbox_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colpibox_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_model = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colbar_code = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colstock_type = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_io = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colinout = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.txtBoxID = New DevExpress.XtraEditors.SpinEdit
        Me.btnUnlock = New DevExpress.XtraEditors.SimpleButton
        Me.chkAllDVD = New DevExpress.XtraEditors.CheckEdit
        Me.chkBadLabel = New DevExpress.XtraEditors.CheckEdit
        Me.chkIsDamaged = New DevExpress.XtraEditors.CheckEdit
        Me.chkIsBroken = New DevExpress.XtraEditors.CheckEdit
        Me.btnOK1 = New DevExpress.XtraEditors.SimpleButton
        Me.btnResetNbrs = New DevExpress.XtraEditors.SimpleButton
        Me.btnFindBarCode = New DevExpress.XtraEditors.SimpleButton
        Me.txtINFO = New DevExpress.XtraEditors.TextEdit
        Me.txtDVD_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
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
        CType(Me.GridIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDVDStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAllDVD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBadLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsDamaged.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsBroken.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtINFO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(365, 46)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 16)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Product ID"
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsProducts"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridIN
        '
        Me.GridIN.DataSource = Me.objDS.products_dvd_stock_1
        Me.GridIN.Dock = System.Windows.Forms.DockStyle.Left
        Me.GridIN.EmbeddedNavigator.Name = ""
        Me.GridIN.FormsUseDefaultLookAndFeel = False
        Me.GridIN.Location = New System.Drawing.Point(6, 153)
        Me.GridIN.MainView = Me.GridViewIN
        Me.GridIN.Name = "GridIN"
        Me.GridIN.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbDVDStatus})
        Me.GridIN.Size = New System.Drawing.Size(876, 237)
        Me.GridIN.TabIndex = 20
        Me.GridIN.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewIN})
        '
        'GridViewIN
        '
        Me.GridViewIN.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridViewIN.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colproducts_id, Me.colproducts_dvdid, Me.colproducts_dvd_status, Me.colbox_id, Me.colpibox_id, Me.colproducts_model, Me.colbar_code, Me.colstock_type, Me.colproducts_io, Me.colinout})
        Me.GridViewIN.CustomizationFormBounds = New System.Drawing.Rectangle(873, 335, 208, 191)
        Me.GridViewIN.GridControl = Me.GridIN
        Me.GridViewIN.Name = "GridViewIN"
        Me.GridViewIN.OptionsSelection.MultiSelect = True
        Me.GridViewIN.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colproducts_id)
        Me.GridBand1.Columns.Add(Me.colproducts_dvdid)
        Me.GridBand1.Columns.Add(Me.colproducts_dvd_status)
        Me.GridBand1.Columns.Add(Me.colbox_id)
        Me.GridBand1.Columns.Add(Me.colpibox_id)
        Me.GridBand1.Columns.Add(Me.colproducts_model)
        Me.GridBand1.Columns.Add(Me.colbar_code)
        Me.GridBand1.Columns.Add(Me.colstock_type)
        Me.GridBand1.Columns.Add(Me.colproducts_io)
        Me.GridBand1.Columns.Add(Me.colinout)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 866
        '
        'colproducts_id
        '
        Me.colproducts_id.Caption = "products_id"
        Me.colproducts_id.FieldName = "products_id"
        Me.colproducts_id.Name = "colproducts_id"
        Me.colproducts_id.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colproducts_id.Visible = True
        Me.colproducts_id.Width = 98
        '
        'colproducts_dvdid
        '
        Me.colproducts_dvdid.Caption = "products_dvdid"
        Me.colproducts_dvdid.FieldName = "products_dvdid"
        Me.colproducts_dvdid.Name = "colproducts_dvdid"
        Me.colproducts_dvdid.Visible = True
        Me.colproducts_dvdid.Width = 57
        '
        'colproducts_dvd_status
        '
        Me.colproducts_dvd_status.Caption = "products_dvd_status"
        Me.colproducts_dvd_status.ColumnEdit = Me.cmbDVDStatus
        Me.colproducts_dvd_status.FieldName = "products_dvd_status"
        Me.colproducts_dvd_status.Name = "colproducts_dvd_status"
        Me.colproducts_dvd_status.Visible = True
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
        Me.colbox_id.Visible = True
        '
        'colpibox_id
        '
        Me.colpibox_id.Caption = "pibox_id"
        Me.colpibox_id.FieldName = "pibox_id"
        Me.colpibox_id.Name = "colpibox_id"
        Me.colpibox_id.Visible = True
        Me.colpibox_id.Width = 82
        '
        'colproducts_model
        '
        Me.colproducts_model.Caption = "products_model"
        Me.colproducts_model.FieldName = "products_model"
        Me.colproducts_model.Name = "colproducts_model"
        Me.colproducts_model.Visible = True
        Me.colproducts_model.Width = 195
        '
        'colbar_code
        '
        Me.colbar_code.Caption = "bar_code"
        Me.colbar_code.FieldName = "bar_code"
        Me.colbar_code.Name = "colbar_code"
        Me.colbar_code.Visible = True
        '
        'colstock_type
        '
        Me.colstock_type.Caption = "stock_type"
        Me.colstock_type.FieldName = "stock_type"
        Me.colstock_type.Name = "colstock_type"
        Me.colstock_type.Visible = True
        '
        'colproducts_io
        '
        Me.colproducts_io.Caption = "products_io"
        Me.colproducts_io.FieldName = "products_io"
        Me.colproducts_io.Name = "colproducts_io"
        Me.colproducts_io.Visible = True
        '
        'colinout
        '
        Me.colinout.Caption = "inout"
        Me.colinout.FieldName = "inout"
        Me.colinout.Name = "colinout"
        Me.colinout.Visible = True
        '
        'PanelControl1
        '
        Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl1.Controls.Add(Me.txtBoxID)
        Me.PanelControl1.Controls.Add(Me.btnUnlock)
        Me.PanelControl1.Controls.Add(Me.chkAllDVD)
        Me.PanelControl1.Controls.Add(Me.chkBadLabel)
        Me.PanelControl1.Controls.Add(Me.chkIsDamaged)
        Me.PanelControl1.Controls.Add(Me.chkIsBroken)
        Me.PanelControl1.Controls.Add(Me.btnOK1)
        Me.PanelControl1.Controls.Add(Me.btnResetNbrs)
        Me.PanelControl1.Controls.Add(Me.btnFindBarCode)
        Me.PanelControl1.Controls.Add(Me.txtINFO)
        Me.PanelControl1.Controls.Add(Me.txtDVD_ID)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.btnSearch)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txtProducts_id)
        Me.PanelControl1.Controls.Add(Me.txtBarCode)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 35)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1040, 118)
        Me.PanelControl1.TabIndex = 30
        '
        'txtBoxID
        '
        Me.txtBoxID.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBoxID.Enabled = False
        Me.txtBoxID.Location = New System.Drawing.Point(76, 18)
        Me.txtBoxID.Name = "txtBoxID"
        Me.txtBoxID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtBoxID.Size = New System.Drawing.Size(120, 22)
        Me.txtBoxID.TabIndex = 43
        '
        'btnUnlock
        '
        Me.btnUnlock.Appearance.BackColor = System.Drawing.Color.White
        Me.btnUnlock.Appearance.BackColor2 = System.Drawing.Color.White
        Me.btnUnlock.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnlock.Appearance.Options.UseBackColor = True
        Me.btnUnlock.Appearance.Options.UseFont = True
        Me.btnUnlock.Location = New System.Drawing.Point(364, 7)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(90, 74)
        Me.btnUnlock.TabIndex = 42
        Me.btnUnlock.Text = "unlock"
        Me.btnUnlock.Visible = False
        '
        'chkAllDVD
        '
        Me.chkAllDVD.Location = New System.Drawing.Point(19, 46)
        Me.chkAllDVD.Name = "chkAllDVD"
        Me.chkAllDVD.Properties.Caption = "All DVD"
        Me.chkAllDVD.Size = New System.Drawing.Size(90, 21)
        Me.chkAllDVD.TabIndex = 41
        Me.chkAllDVD.ToolTip = "etat de la boite"
        Me.chkAllDVD.Visible = False
        '
        'chkBadLabel
        '
        Me.chkBadLabel.Location = New System.Drawing.Point(998, 65)
        Me.chkBadLabel.Name = "chkBadLabel"
        Me.chkBadLabel.Properties.Caption = "Bad Label (Boite 60.000)"
        Me.chkBadLabel.Size = New System.Drawing.Size(231, 21)
        Me.chkBadLabel.TabIndex = 40
        '
        'chkIsDamaged
        '
        Me.chkIsDamaged.Location = New System.Drawing.Point(998, 37)
        Me.chkIsDamaged.Name = "chkIsDamaged"
        Me.chkIsDamaged.Properties.Caption = "Is Damaged (Boite 70.000)"
        Me.chkIsDamaged.Size = New System.Drawing.Size(231, 21)
        Me.chkIsDamaged.TabIndex = 39
        Me.chkIsDamaged.Visible = False
        '
        'chkIsBroken
        '
        Me.chkIsBroken.Location = New System.Drawing.Point(998, 9)
        Me.chkIsBroken.Name = "chkIsBroken"
        Me.chkIsBroken.Properties.Caption = "Is Broken"
        Me.chkIsBroken.Size = New System.Drawing.Size(90, 21)
        Me.chkIsBroken.TabIndex = 38
        '
        'btnOK1
        '
        Me.btnOK1.Location = New System.Drawing.Point(854, 18)
        Me.btnOK1.Name = "btnOK1"
        Me.btnOK1.Size = New System.Drawing.Size(125, 27)
        Me.btnOK1.TabIndex = 36
        Me.btnOK1.Text = "OK"
        '
        'btnResetNbrs
        '
        Me.btnResetNbrs.Location = New System.Drawing.Point(250, 46)
        Me.btnResetNbrs.Name = "btnResetNbrs"
        Me.btnResetNbrs.Size = New System.Drawing.Size(86, 27)
        ToolTipTitleItem1.Text = "Reser Numbers"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "This will reser dvd position id in the box"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnResetNbrs.SuperTip = SuperToolTip1
        Me.btnResetNbrs.TabIndex = 35
        Me.btnResetNbrs.Text = "Reset Nbrs"
        '
        'btnFindBarCode
        '
        Me.btnFindBarCode.Location = New System.Drawing.Point(854, 46)
        Me.btnFindBarCode.Name = "btnFindBarCode"
        Me.btnFindBarCode.Size = New System.Drawing.Size(125, 27)
        Me.btnFindBarCode.TabIndex = 3
        Me.btnFindBarCode.Text = "Find Bar Code"
        '
        'txtINFO
        '
        Me.txtINFO.Location = New System.Drawing.Point(115, 83)
        Me.txtINFO.Name = "txtINFO"
        Me.txtINFO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtINFO.Properties.Appearance.ForeColor = System.Drawing.Color.Firebrick
        Me.txtINFO.Properties.Appearance.Options.UseFont = True
        Me.txtINFO.Properties.Appearance.Options.UseForeColor = True
        Me.txtINFO.Size = New System.Drawing.Size(711, 27)
        Me.txtINFO.TabIndex = 34
        '
        'txtDVD_ID
        '
        Me.txtDVD_ID.Enabled = False
        Me.txtDVD_ID.Location = New System.Drawing.Point(710, 46)
        Me.txtDVD_ID.Name = "txtDVD_ID"
        Me.txtDVD_ID.Properties.ReadOnly = True
        Me.txtDVD_ID.Size = New System.Drawing.Size(116, 22)
        Me.txtDVD_ID.TabIndex = 29
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(614, 46)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(40, 16)
        Me.LabelControl5.TabIndex = 28
        Me.LabelControl5.Text = "DVD ID"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(250, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(86, 27)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(19, 18)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(32, 16)
        Me.LabelControl4.TabIndex = 25
        Me.LabelControl4.Text = "BoxID"
        '
        'txtProducts_id
        '
        Me.txtProducts_id.Enabled = False
        Me.txtProducts_id.Location = New System.Drawing.Point(461, 46)
        Me.txtProducts_id.Name = "txtProducts_id"
        Me.txtProducts_id.Properties.ReadOnly = True
        Me.txtProducts_id.Size = New System.Drawing.Size(115, 22)
        Me.txtProducts_id.TabIndex = 24
        '
        'txtBarCode
        '
        Me.txtBarCode.Location = New System.Drawing.Point(461, 18)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(365, 22)
        Me.txtBarCode.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(365, 18)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl2.TabIndex = 23
        Me.LabelControl2.Text = "BareCode"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 153)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(6, 237)
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
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1040, 390)
        Me.Controls.Add(Me.GridIN)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmProcessIN"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        Me.Controls.SetChildIndex(Me.SplitterControl1, 0)
        Me.Controls.SetChildIndex(Me.GridIN, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDVDStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAllDVD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBadLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsDamaged.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsBroken.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtINFO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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

    Const _nametable As String = "products_dvd_stock_1"
    ' Private NbrDVDByBox As Int16 = 20
    Dim _CheckProcess As ClsCheckProcessLogistic

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()

    End Sub

    Private Sub initCheckProcess()
        _CheckProcess = New ClsCheckProcessLogistic()
        _CheckProcess.txtInfo = txtINFO
        _CheckProcess.sessionInfo = SessionInfo
        _CheckProcess.objDS = objDS
        _CheckProcess.btnSearch = btnSearch
        _CheckProcess.txtbarcode = txtBarCode
        _CheckProcess.btnUnlock = btnUnlock
        ' _CheckProcess.Ctrlbox_id = txtBoxID
        objDS.EnforceConstraints = False
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If btnUnlock.Visible = True Then Return
        If DvdPostData.clsSession.box_id = Integer.MaxValue Then
            MsgBox("Function disabled", MsgBoxStyle.Critical)
            Return
        End If
        _CheckProcess.RefreshData(objDS.Tables(_nametable), txtBoxID.EditValue)
        GridIN.DataSource = objDS.Tables(_nametable)
        clsDevExpress.AddHyperlinkDynamic(GridIN)
    End Sub
    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        GridIN.ContextMenuStrip = menuStrip
        If DvdPostData.clsSession.box_id < Integer.MaxValue Then
            txtBoxID.EditValue = DvdPostData.clsSession.box_id
        End If
        txtBarCode.Enabled = False

        txtProducts_id.ForeColor = Drawing.Color.Black
        txtDVD_ID.ForeColor = Drawing.Color.Black

        initCheckProcess()

    End Sub



    Private Function ValidLabel(ByRef objProductDVD As clsProduct_DVD, ByRef Order_Status As Integer) As Boolean
        If chkBadLabel.Checked Then
            ''objProductDVD.ChangeDVDStatus2(txtProducts_id.EditValue, txtDVD_ID.EditValue, 1, 60000, 1, "Process IN - Bad Label")
            'objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_BADLABEL, _
            '"Process IN - " & DVDPostTools.clsEnum.getNameStrEnum(objProductDVD.products_dvd_status), DvdPostData.ClsProducts_dvd_state.state.IN, objProductDVD.INOUT)

            txtINFO.Text = "Mettre ce DVD dans la boite " & DVDPostTools.clsEnum.getValueStrEnum(DvdPostData.clsProductDvd.BOXTYPE.BADLABEL)
            MsgBox(txtINFO.Text, MsgBoxStyle.Critical)
            Order_Status = DvdPostData.clsOdersStatusHistory.OrderStatusNew.TMP
            Return False
        End If

        Return True
    End Function

    'Private Function NotExistInStock(ByRef objProductDVD As clsProduct_DVD, ByRef Order_Status As Integer, ByRef Comment As String) As Boolean

    '    Dim warning As String = ""
    '    If objProductDVD.INOUT = DvdPostData.clsProductDvd.INOUT.IN Then
    '        If objProductDVD.products_dvd_status <> DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK Then
    '            warning = "PREVIOUS STATUS ( " & DVDPostTools.clsEnum.getNameStrEnum(objProductDVD.products_dvd_status) & " ) !!"
    '        End If
    '        txtINFO.Text = warning & " dvd in old box " & objProductDVD.BoxID
    '        MsgBox(txtINFO.Text, MsgBoxStyle.Critical)
    '        ' If Answ = MsgBoxResult.Yes Then
    '        '  objProductDVD.ChangeBox(vBoxID, vPiBoxID)
    '        ' objProductDVD.LogStatusDVD("Process IN - already in stock")
    '        ' Comment = "Process IN - already in stock"
    '        ' Order_Status = DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_ALREADYBOX
    '        ' Else
    '        Order_Status = -1
    '        Return False
    '    End If
    '    Return True
    'End Function

    'Private Sub ChkAlert(ByRef objProductDVD As clsProduct_DVD, ByRef Order_Status As Integer)
    '    ' objProductDVD.LoadFirstAlarm()

    '    Dim sql As String
    '    Dim isAlert As Boolean

    '    Dim dt As DataTable
    '    sql = DvdPostData.clsProductsAlert.getProductsAlert(objProductDVD.ProductsID, 0)
    '    dt = DvdPostData.clsConnection.FillDataSet(sql)
    '    isAlert = dt.Rows.Count > 0
    '    If dt.Rows.Count = 0 Then
    '        sql = DvdPostData.clsProductsAlert.getProductsAlert(objProductDVD.ProductsID, objProductDVD.DvdId)
    '        dt = DvdPostData.clsConnection.FillDataSet(sql)
    '        isAlert = dt.Rows.Count > 0
    '    End If

    '    If isAlert Then
    '        txtINFO.Text = dt.Rows(0)("alert_comment") & " - Ne PAS mettre ce DVD dans la boite"
    '        MsgBox(txtINFO.Text, MsgBoxStyle.Critical)
    '        txtINFO.Focus()
    '        sql = DvdPostData.clsProductsAlert.UpdateCheckStatus(dt.Rows(0)("alert_id"), DvdPostData.clsProductsAlert.checkStatus.CHECKED)
    '        DvdPostData.clsConnection.ExecuteNonQuery(sql)

    '        ' Order_Status = DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_CUSTSERV

    '    End If

    'End Sub

    Private Function NotExistOrder(ByRef objProductDVD As clsProduct_DVD, ByRef dr As DataRow, ByRef Order_Status As Integer, ByRef comment As String) As Boolean
        dr = objProductDVD.GetlastOrder(objProductDVD.ProductsID, objProductDVD.DvdId)

        Dim cpt_order_open As Integer
        Dim date_expedie As DateTime
        Dim nb_days As Integer
        If dr Is Nothing Then
            comment = "Error check the order of this dvd !!"
            txtINFO.Text = comment
            Order_Status = -1
            Return False
        Else
            ' si plusieurs clients ont ce dvd  chez eux
            cpt_order_open = objProductDVD.GetCptOrders(objProductDVD.ProductsID, objProductDVD.DvdId)

            If cpt_order_open > 1 Then
                comment = "Process IN - Plusieurs clients ont ce dvd en leur possession !!!! check all orders "
                txtINFO.Text = comment
                Order_Status = -1
                Return False
            End If

            Dim orders_status As Integer = dr("orders_status")
            date_expedie = dr("date_purchased")
            nb_days = (DateTime.Now - date_expedie).Days
            If nb_days < 2 Then
                If MsgBox("Continue ? Order returned too quick !!! " & nb_days & " days ", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                    Return False
                End If
            End If
            If orders_status = DvdPostData.clsOdersStatusHistory.OrderStatusNew.RETURNED Then
                txtINFO.Text = "DVD jamais commandé " & objProductDVD.ProductsID & "-" & objProductDVD.DvdId & ". il faut l'inventorier "
                comment = "Process IN - No Order Found"
                Return False
            ElseIf orders_status = DvdPostData.clsOdersStatusHistory.OrderStatusNew.READY_FOR_EXPEDITION Then
                txtINFO.Text = "Process out please !! " & objProductDVD.ProductsID & "-" & objProductDVD.DvdId
                comment = "Process IN - Pret a l'expedition"
                Return False
            ElseIf orders_status = DvdPostData.clsOdersStatusHistory.OrderStatusNew.CHECK Then
                txtINFO.Text = "Check DVD Please !! " & objProductDVD.ProductsID & "-" & objProductDVD.DvdId
                comment = "Process IN - check DVD"
            End If

            ' verifie si cette personne est arrete et si elle a une facture de dvd ouverte 
            If DVDPostBuziness.ClsCustomers.isCustomersStopDvdatHome(dr("customers_id")) Then
                ' cancel invoices
                DVDPostBuziness.clsPayment.CancelInvoiceLongtime(dr("customers_id"))
            End If
            Return True
        End If

    End Function

    Private Sub ChkDVDStatuslongTime(ByVal OrderRow As DataRow, ByRef orders_status As Integer)
        If OrderRow("products_dvd_status") = DvdPostData.clsProductDvd.DVDStatus.LONGTIME_CUSTOMER Then
            txtINFO.Text = "DVD LongTime@Customer "
            MsgBox(txtINFO.Text, MsgBoxStyle.Critical)

        End If

    End Sub

    'Private Sub ChkDVDStatusDamaged(ByRef objProductDVD As clsProduct_DVD, ByVal OrderRow As DataRow, ByRef orders_status As Integer)
    '    If OrderRow("products_dvd_status") = DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_DAMAGED Then
    '        txtINFO.Text = "DVD illisible. Mettre ce DVD dans la Boite " & DvdPostData.clsProductDvd.BOXTYPE.DAMAGED
    '        MsgBox(txtINFO.Text, MsgBoxStyle.Critical)
    '        orders_status = DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_DAMAGED
    '        '  objProductDVD.products_dvd_status = DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_DAMAGED

    '    End If

    'End Sub

    'Private Sub ChkDVDStatusBroken(ByRef objProductDVD As clsProduct_DVD, ByVal OrderRow As DataRow, ByRef orders_status As Integer)
    '    If OrderRow("products_dvd_status") = DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_BROKEN Or _
    '        chkIsBroken.Checked Then

    '        txtINFO.Text = "DVD cassé. Mettre ce DVD dans la Boite " & DvdPostData.clsProductDvd.BOXTYPE.BROKEN
    '        MsgBox(txtINFO.Text, MsgBoxStyle.Critical)

    '        orders_status = DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_BROKEN


    '        'objProductDVD.products_dvd_status = DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_BROKEN

    '    End If

    'End Sub

    Public Sub BarCode_OK()
        Dim NewRow As DataRow
        Dim DS As New dsProducts

        Dim objProductDVD As clsProduct_DVD

        Dim dt As DataTable

        dt = objDS.Tables(_nametable)
        If txtINFO.Text <> "" Then
            btnSearch.Focus()
            MsgBox("click unlock button ", MsgBoxStyle.Exclamation)
            _CheckProcess.DisableBarCode()
            Exit Sub
        End If
        objProductDVD = _CheckProcess.GetCodeBar(txtBarCode.Text)
        If objProductDVD Is Nothing Then Return

        txtProducts_id.EditValue = objProductDVD.ProductsID
        txtDVD_ID.EditValue = objProductDVD.DvdId

        Dim RowLastOrders As DataRow = Nothing
        Dim orders_status As Integer = -1
        Dim comment As String = ""
        Dim box_Id As Integer = txtBoxID.EditValue
        Dim PosBox_id As Integer = mvarPos_ID
        Dim ok As Boolean = False

        ' deja dans la liste en memoire representant la boite
        If Not _CheckProcess.ExistAlreadyBox(dt, objProductDVD) Then
            ' se trouve dans une autre boite physique dans le stock   
            If Not _CheckProcess.CheckdvdAlreadyInStock(objProductDVD.BoxID) Then
                ' la boite n'est pas pleine 
                If Not _CheckProcess.CheckFullBox(dt, txtBoxID.EditValue) Then
                    ValidLabel(objProductDVD, orders_status)
                    If NotExistOrder(objProductDVD, RowLastOrders, orders_status, comment) Then
                        If orders_status = -1 Then orders_status = RowLastOrders("orders_status")
                        _CheckProcess.ChkAlert(objProductDVD)
                        ' ChkDVDStatusDamaged(objProductDVD, RowLastOrders, orders_status)
                        ' ChkDVDStatusBroken(objProductDVD, RowLastOrders, orders_status)

                    End If
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
            ok = objProductDVD.processDVDIn(orders_status, box_Id, PosBox_id, orders_id, customers_id, comment, objProductDVD.INOUT)

            If ok Then

                NewRow = objDS.Tables(_nametable).NewRow
                NewRow("products_id") = objProductDVD.ProductsID
                NewRow("products_dvdid") = objProductDVD.DvdId
                NewRow("products_dvd_status") = 1
                NewRow("box_id") = txtBoxID.EditValue
                NewRow("pibox_id") = DVDPostBuziness.ClsproductsDvd.getFirstPosBox(objDS.Tables(_nametable), "pibox_id") + 1
                NewRow("bar_code") = txtBarCode.EditValue
                NewRow("inout") = 1
                objDS.Tables(_nametable).Rows.InsertAt(NewRow, 0)

                If txtINFO.Text <> "" Then
                    _CheckProcess.DisableBarCode()
                Else
                    EnableBarcode()
                End If

            End If
        Else
            _CheckProcess.DisableBarCode()
        End If

    End Sub
    Private Sub EnableBarcode()
        chkBadLabel.Checked = False
        chkIsBroken.Checked = False
        _CheckProcess.EnableBarCode()
    End Sub
    Private Sub btnFindBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindBarCode.Click
        If btnUnlock.Visible = True Then Return
        _CheckProcess.GenereBarCode()
    End Sub

    Private Sub btnResetNbrs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetNbrs.Click
        If btnUnlock.Visible = True Then Return
        DVDPostBuziness.ClsproductsDvd.resetposinbox(objDS.Tables(_nametable))

    End Sub

    Private Sub btnOK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK1.Click
        BarCode_OK()
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

