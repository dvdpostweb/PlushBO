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
    Friend WithEvents objDS As DVDPostLib.dsProducts
    Friend WithEvents StyleRed As DevExpress.XtraEditors.StyleController
    Friend WithEvents StyleGreen As DevExpress.XtraEditors.StyleController
    Friend WithEvents StyleBlue As DevExpress.XtraEditors.StyleController
    Friend WithEvents btnFindBarCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDVD_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProducts_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents CEBadSticker As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnOK1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TEQSQL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridInventary As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnResetNbrs1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBoxID As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents BTPartDeleteReadyToRent As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSearchActif As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkAllDVD As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtINFO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblcptLost As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblCpRefound As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblLost As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblRefound As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnUnlock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBarCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridViewInventary As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents coInOut As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_dvdid As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_dvd_status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colbox_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colpibox_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colbar_code As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_model As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUser As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastModified As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents btnBoxOrderInventory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFindBox As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBoxEmpty As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkResetCounter As DevExpress.XtraEditors.CheckEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.objDS = New DVDPostLib.dsProducts
        Me.StyleRed = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.StyleGreen = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.StyleBlue = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.btnFindBarCode = New DevExpress.XtraEditors.SimpleButton
        Me.txtDVD_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtProducts_id = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.txtBarCode = New DevExpress.XtraEditors.TextEdit
        Me.btnUnlock = New DevExpress.XtraEditors.SimpleButton
        Me.chkResetCounter = New DevExpress.XtraEditors.CheckEdit
        Me.TEQSQL = New DevExpress.XtraEditors.TextEdit
        Me.btnOK1 = New DevExpress.XtraEditors.SimpleButton
        Me.CEBadSticker = New DevExpress.XtraEditors.CheckEdit
        Me.GridInventary = New DevExpress.XtraGrid.GridControl
        Me.GridViewInventary = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.coInOut = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_dvdid = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_dvd_status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colbox_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colpibox_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colbar_code = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_model = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colUser = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colLastModified = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
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
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.btnBoxEmpty = New DevExpress.XtraEditors.SimpleButton
        Me.btnBoxOrderInventory = New DevExpress.XtraEditors.SimpleButton
        Me.btnFindBox = New DevExpress.XtraEditors.SimpleButton
        Me.txtINFO = New DevExpress.XtraEditors.TextEdit
        Me.chkAllDVD = New DevExpress.XtraEditors.CheckEdit
        Me.btnResetNbrs1 = New DevExpress.XtraEditors.SimpleButton
        Me.txtBoxID = New DevExpress.XtraEditors.SpinEdit
        Me.BTPartDeleteReadyToRent = New DevExpress.XtraEditors.SimpleButton
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton
        Me.btnSearchActif = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LblcptLost = New DevExpress.XtraEditors.LabelControl
        Me.LblCpRefound = New DevExpress.XtraEditors.LabelControl
        Me.LblLost = New DevExpress.XtraEditors.LabelControl
        Me.LblRefound = New DevExpress.XtraEditors.LabelControl
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkResetCounter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEQSQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEBadSticker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridInventary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewInventary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtINFO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAllDVD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsProducts"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'btnFindBarCode
        '
        Me.btnFindBarCode.Location = New System.Drawing.Point(845, 18)
        Me.btnFindBarCode.Name = "btnFindBarCode"
        Me.btnFindBarCode.Size = New System.Drawing.Size(105, 27)
        Me.btnFindBarCode.TabIndex = 3
        Me.btnFindBarCode.Text = "Find Bar Code"
        '
        'txtDVD_ID
        '
        Me.txtDVD_ID.Enabled = False
        Me.txtDVD_ID.Location = New System.Drawing.Point(710, 46)
        Me.txtDVD_ID.Name = "txtDVD_ID"
        Me.txtDVD_ID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDVD_ID.Properties.Appearance.Options.UseFont = True
        Me.txtDVD_ID.Properties.ReadOnly = True
        Me.txtDVD_ID.Size = New System.Drawing.Size(116, 26)
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
        'txtProducts_id
        '
        Me.txtProducts_id.Enabled = False
        Me.txtProducts_id.Location = New System.Drawing.Point(461, 46)
        Me.txtProducts_id.Name = "txtProducts_id"
        Me.txtProducts_id.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducts_id.Properties.Appearance.Options.UseFont = True
        Me.txtProducts_id.Properties.ReadOnly = True
        Me.txtProducts_id.Size = New System.Drawing.Size(115, 26)
        Me.txtProducts_id.TabIndex = 24
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(365, 18)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl2.TabIndex = 23
        Me.LabelControl2.Text = "BareCode"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(365, 46)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 16)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Product ID"
        '
        'PanelControl1
        '
        Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl1.Controls.Add(Me.txtBarCode)
        Me.PanelControl1.Controls.Add(Me.btnUnlock)
        Me.PanelControl1.Controls.Add(Me.chkResetCounter)
        Me.PanelControl1.Controls.Add(Me.TEQSQL)
        Me.PanelControl1.Controls.Add(Me.btnOK1)
        Me.PanelControl1.Controls.Add(Me.CEBadSticker)
        Me.PanelControl1.Controls.Add(Me.btnFindBarCode)
        Me.PanelControl1.Controls.Add(Me.txtDVD_ID)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtProducts_id)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 35)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1168, 95)
        Me.PanelControl1.TabIndex = 30
        '
        'txtBarCode
        '
        Me.txtBarCode.Location = New System.Drawing.Point(461, 16)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(365, 22)
        Me.txtBarCode.TabIndex = 37
        '
        'btnUnlock
        '
        Me.btnUnlock.Appearance.BackColor = System.Drawing.Color.White
        Me.btnUnlock.Appearance.BackColor2 = System.Drawing.Color.White
        Me.btnUnlock.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnlock.Appearance.Options.UseBackColor = True
        Me.btnUnlock.Appearance.Options.UseFont = True
        Me.btnUnlock.Location = New System.Drawing.Point(364, 15)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(90, 74)
        Me.btnUnlock.TabIndex = 36
        Me.btnUnlock.Text = "unlock"
        Me.btnUnlock.Visible = False
        '
        'chkResetCounter
        '
        Me.chkResetCounter.Location = New System.Drawing.Point(958, 55)
        Me.chkResetCounter.Name = "chkResetCounter"
        Me.chkResetCounter.Properties.Caption = "Reset Rotation Counter"
        Me.chkResetCounter.Size = New System.Drawing.Size(171, 21)
        Me.chkResetCounter.TabIndex = 35
        '
        'TEQSQL
        '
        Me.TEQSQL.Location = New System.Drawing.Point(10, 28)
        Me.TEQSQL.Name = "TEQSQL"
        Me.TEQSQL.Size = New System.Drawing.Size(316, 22)
        Me.TEQSQL.TabIndex = 34
        Me.TEQSQL.Visible = False
        '
        'btnOK1
        '
        Me.btnOK1.Location = New System.Drawing.Point(960, 18)
        Me.btnOK1.Name = "btnOK1"
        Me.btnOK1.Size = New System.Drawing.Size(106, 27)
        Me.btnOK1.TabIndex = 33
        Me.btnOK1.Text = "ok"
        '
        'CEBadSticker
        '
        Me.CEBadSticker.Location = New System.Drawing.Point(845, 55)
        Me.CEBadSticker.Name = "CEBadSticker"
        Me.CEBadSticker.Properties.Caption = "BadLabel"
        Me.CEBadSticker.Size = New System.Drawing.Size(90, 21)
        Me.CEBadSticker.TabIndex = 30
        '
        'GridInventary
        '
        Me.GridInventary.DataSource = Me.objDS.products_dvd_stock_1
        Me.GridInventary.EmbeddedNavigator.Name = ""
        Me.GridInventary.FormsUseDefaultLookAndFeel = False
        Me.GridInventary.Location = New System.Drawing.Point(0, 234)
        Me.GridInventary.MainView = Me.GridViewInventary
        Me.GridInventary.Name = "GridInventary"
        Me.GridInventary.Size = New System.Drawing.Size(907, 589)
        Me.GridInventary.TabIndex = 1
        Me.GridInventary.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewInventary, Me.GridView1})
        '
        'GridViewInventary
        '
        Me.GridViewInventary.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridViewInventary.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.coInOut, Me.colproducts_id, Me.colproducts_dvdid, Me.colproducts_dvd_status, Me.colbox_id, Me.colpibox_id, Me.colbar_code, Me.colproducts_model, Me.colUser, Me.colLastModified})
        Me.GridViewInventary.CustomizationFormBounds = New System.Drawing.Rectangle(382, 307, 208, 276)
        Me.GridViewInventary.GridControl = Me.GridInventary
        Me.GridViewInventary.Name = "GridViewInventary"
        Me.GridViewInventary.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridViewInventary.OptionsSelection.MultiSelect = True
        Me.GridViewInventary.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.GridViewInventary.OptionsView.ShowFooter = True
        Me.GridViewInventary.OptionsView.ShowGroupPanel = False
        Me.GridViewInventary.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.coInOut, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.coInOut)
        Me.GridBand1.Columns.Add(Me.colproducts_id)
        Me.GridBand1.Columns.Add(Me.colproducts_dvdid)
        Me.GridBand1.Columns.Add(Me.colproducts_dvd_status)
        Me.GridBand1.Columns.Add(Me.colbox_id)
        Me.GridBand1.Columns.Add(Me.colpibox_id)
        Me.GridBand1.Columns.Add(Me.colbar_code)
        Me.GridBand1.Columns.Add(Me.colproducts_model)
        Me.GridBand1.Columns.Add(Me.colUser)
        Me.GridBand1.Columns.Add(Me.colLastModified)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 856
        '
        'coInOut
        '
        Me.coInOut.Caption = "InOut"
        Me.coInOut.FieldName = "inout"
        Me.coInOut.Name = "coInOut"
        Me.coInOut.Visible = True
        Me.coInOut.Width = 64
        '
        'colproducts_id
        '
        Me.colproducts_id.Caption = "products_id"
        Me.colproducts_id.FieldName = "products_id"
        Me.colproducts_id.Name = "colproducts_id"
        Me.colproducts_id.Visible = True
        Me.colproducts_id.Width = 83
        '
        'colproducts_dvdid
        '
        Me.colproducts_dvdid.Caption = "products_dvdid"
        Me.colproducts_dvdid.FieldName = "products_dvdid"
        Me.colproducts_dvdid.Name = "colproducts_dvdid"
        Me.colproducts_dvdid.Visible = True
        Me.colproducts_dvdid.Width = 118
        '
        'colproducts_dvd_status
        '
        Me.colproducts_dvd_status.Caption = "products_dvd_status"
        Me.colproducts_dvd_status.FieldName = "products_dvd_status_name"
        Me.colproducts_dvd_status.Name = "colproducts_dvd_status"
        Me.colproducts_dvd_status.Visible = True
        Me.colproducts_dvd_status.Width = 109
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
        Me.colpibox_id.Width = 107
        '
        'colbar_code
        '
        Me.colbar_code.Caption = "bar_code"
        Me.colbar_code.FieldName = "bar_code"
        Me.colbar_code.Name = "colbar_code"
        Me.colbar_code.Visible = True
        '
        'colproducts_model
        '
        Me.colproducts_model.Caption = "products_model"
        Me.colproducts_model.FieldName = "products_model"
        Me.colproducts_model.Name = "colproducts_model"
        Me.colproducts_model.Visible = True
        '
        'colUser
        '
        Me.colUser.Caption = "user"
        Me.colUser.FieldName = "fullname"
        Me.colUser.Name = "colUser"
        Me.colUser.Visible = True
        '
        'colLastModified
        '
        Me.colLastModified.Caption = "last_modified"
        Me.colLastModified.FieldName = "last_modified"
        Me.colLastModified.Name = "colLastModified"
        Me.colLastModified.Visible = True
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colproducts_id1, Me.colproducts_dvdid1, Me.colproducts_dvd_status1, Me.colbox_id1, Me.colpibox_id1, Me.colbar_code1, Me.colproducts_model1, Me.colstock_type, Me.colproducts_io, Me.colinout})
        Me.GridView1.GridControl = Me.GridInventary
        Me.GridView1.Name = "GridView1"
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
        Me.colproducts_dvd_status1.FieldName = "products_dvd_status_name"
        Me.colproducts_dvd_status1.Name = "colproducts_dvd_status1"
        Me.colproducts_dvd_status1.Visible = True
        Me.colproducts_dvd_status1.VisibleIndex = 2
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
        'colbar_code1
        '
        Me.colbar_code1.Caption = "bar_code"
        Me.colbar_code1.FieldName = "bar_code"
        Me.colbar_code1.Name = "colbar_code1"
        Me.colbar_code1.Visible = True
        Me.colbar_code1.VisibleIndex = 5
        '
        'colproducts_model1
        '
        Me.colproducts_model1.Caption = "products_model"
        Me.colproducts_model1.FieldName = "products_model"
        Me.colproducts_model1.Name = "colproducts_model1"
        Me.colproducts_model1.Visible = True
        Me.colproducts_model1.VisibleIndex = 6
        '
        'colstock_type
        '
        Me.colstock_type.Caption = "stock_type"
        Me.colstock_type.FieldName = "stock_type"
        Me.colstock_type.Name = "colstock_type"
        Me.colstock_type.Visible = True
        Me.colstock_type.VisibleIndex = 7
        '
        'colproducts_io
        '
        Me.colproducts_io.Caption = "products_io"
        Me.colproducts_io.FieldName = "products_io"
        Me.colproducts_io.Name = "colproducts_io"
        Me.colproducts_io.Visible = True
        Me.colproducts_io.VisibleIndex = 8
        '
        'colinout
        '
        Me.colinout.Caption = "inout"
        Me.colinout.FieldName = "inout"
        Me.colinout.Name = "colinout"
        Me.colinout.Visible = True
        Me.colinout.VisibleIndex = 9
        '
        'PanelControl2
        '
        Me.PanelControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl2.Controls.Add(Me.btnBoxEmpty)
        Me.PanelControl2.Controls.Add(Me.btnBoxOrderInventory)
        Me.PanelControl2.Controls.Add(Me.btnFindBox)
        Me.PanelControl2.Controls.Add(Me.txtINFO)
        Me.PanelControl2.Controls.Add(Me.chkAllDVD)
        Me.PanelControl2.Controls.Add(Me.btnResetNbrs1)
        Me.PanelControl2.Controls.Add(Me.txtBoxID)
        Me.PanelControl2.Controls.Add(Me.BTPartDeleteReadyToRent)
        Me.PanelControl2.Controls.Add(Me.btnClear)
        Me.PanelControl2.Controls.Add(Me.btnSearchActif)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Location = New System.Drawing.Point(6, 136)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(764, 103)
        Me.PanelControl2.TabIndex = 0
        '
        'btnBoxEmpty
        '
        Me.btnBoxEmpty.Location = New System.Drawing.Point(576, 28)
        Me.btnBoxEmpty.Name = "btnBoxEmpty"
        Me.btnBoxEmpty.Size = New System.Drawing.Size(183, 27)
        ToolTipTitleItem1.Text = "box empty"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "box empty order by number of dvd"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnBoxEmpty.SuperTip = SuperToolTip1
        Me.btnBoxEmpty.TabIndex = 46
        Me.btnBoxEmpty.Text = "box empty"
        Me.btnBoxEmpty.Visible = False
        '
        'btnBoxOrderInventory
        '
        Me.btnBoxOrderInventory.Location = New System.Drawing.Point(576, 0)
        Me.btnBoxOrderInventory.Name = "btnBoxOrderInventory"
        Me.btnBoxOrderInventory.Size = New System.Drawing.Size(183, 27)
        ToolTipTitleItem2.Text = "order inventory"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "order by inventory last date"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btnBoxOrderInventory.SuperTip = SuperToolTip2
        Me.btnBoxOrderInventory.TabIndex = 45
        Me.btnBoxOrderInventory.Text = "box order by inventory"
        '
        'btnFindBox
        '
        Me.btnFindBox.Location = New System.Drawing.Point(482, 28)
        Me.btnFindBox.Name = "btnFindBox"
        Me.btnFindBox.Size = New System.Drawing.Size(87, 27)
        ToolTipTitleItem3.Text = "find box"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "find box the least filled"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.btnFindBox.SuperTip = SuperToolTip3
        Me.btnFindBox.TabIndex = 44
        Me.btnFindBox.Text = "Find a Box"
        '
        'txtINFO
        '
        Me.txtINFO.Location = New System.Drawing.Point(305, 61)
        Me.txtINFO.Name = "txtINFO"
        Me.txtINFO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtINFO.Properties.Appearance.ForeColor = System.Drawing.Color.Firebrick
        Me.txtINFO.Properties.Appearance.Options.UseFont = True
        Me.txtINFO.Properties.Appearance.Options.UseForeColor = True
        Me.txtINFO.Size = New System.Drawing.Size(403, 27)
        Me.txtINFO.TabIndex = 43
        '
        'chkAllDVD
        '
        Me.chkAllDVD.Location = New System.Drawing.Point(480, 10)
        Me.chkAllDVD.Name = "chkAllDVD"
        Me.chkAllDVD.Properties.Caption = "All DVD"
        Me.chkAllDVD.Size = New System.Drawing.Size(90, 21)
        Me.chkAllDVD.TabIndex = 42
        Me.chkAllDVD.ToolTip = "etat de la boite"
        Me.chkAllDVD.Visible = False
        '
        'btnResetNbrs1
        '
        Me.btnResetNbrs1.Location = New System.Drawing.Point(58, 65)
        Me.btnResetNbrs1.Name = "btnResetNbrs1"
        Me.btnResetNbrs1.Size = New System.Drawing.Size(86, 26)
        ToolTipTitleItem4.Text = "Reser Numbers"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "This will reser dvd position id in the box"
        SuperToolTip4.Items.Add(ToolTipTitleItem4)
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.btnResetNbrs1.SuperTip = SuperToolTip4
        Me.btnResetNbrs1.TabIndex = 36
        Me.btnResetNbrs1.Text = "Reset Nbrs"
        Me.btnResetNbrs1.Visible = False
        '
        'txtBoxID
        '
        Me.txtBoxID.CausesValidation = False
        Me.txtBoxID.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBoxID.Location = New System.Drawing.Point(58, 9)
        Me.txtBoxID.Name = "txtBoxID"
        Me.txtBoxID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxID.Properties.Appearance.Options.UseFont = True
        Me.txtBoxID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtBoxID.Properties.DisplayFormat.FormatString = "N0"
        Me.txtBoxID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBoxID.Properties.EditFormat.FormatString = "N0"
        Me.txtBoxID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBoxID.Properties.IsFloatValue = False
        Me.txtBoxID.Properties.Mask.EditMask = "n0"
        Me.txtBoxID.Size = New System.Drawing.Size(140, 35)
        Me.txtBoxID.TabIndex = 33
        '
        'BTPartDeleteReadyToRent
        '
        Me.BTPartDeleteReadyToRent.Location = New System.Drawing.Point(154, 65)
        Me.BTPartDeleteReadyToRent.Name = "BTPartDeleteReadyToRent"
        Me.BTPartDeleteReadyToRent.Size = New System.Drawing.Size(144, 26)
        Me.BTPartDeleteReadyToRent.TabIndex = 32
        Me.BTPartDeleteReadyToRent.Text = "Delete selected DVD"
        Me.BTPartDeleteReadyToRent.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(379, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(67, 48)
        Me.btnClear.TabIndex = 29
        Me.btnClear.Text = "Clear"
        '
        'btnSearchActif
        '
        Me.btnSearchActif.Location = New System.Drawing.Point(222, 6)
        Me.btnSearchActif.Name = "btnSearchActif"
        Me.btnSearchActif.Size = New System.Drawing.Size(98, 48)
        Me.btnSearchActif.TabIndex = 27
        Me.btnSearchActif.Text = "Search"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(10, 14)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(32, 16)
        Me.LabelControl3.TabIndex = 28
        Me.LabelControl3.Text = "BoxID"
        '
        'LblcptLost
        '
        Me.LblcptLost.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcptLost.Appearance.Options.UseFont = True
        Me.LblcptLost.Location = New System.Drawing.Point(1022, 150)
        Me.LblcptLost.Name = "LblcptLost"
        Me.LblcptLost.Size = New System.Drawing.Size(15, 29)
        Me.LblcptLost.TabIndex = 63
        Me.LblcptLost.Text = "0"
        Me.LblcptLost.Visible = False
        '
        'LblCpRefound
        '
        Me.LblCpRefound.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCpRefound.Appearance.Options.UseFont = True
        Me.LblCpRefound.Location = New System.Drawing.Point(858, 150)
        Me.LblCpRefound.Name = "LblCpRefound"
        Me.LblCpRefound.Size = New System.Drawing.Size(15, 29)
        Me.LblCpRefound.TabIndex = 62
        Me.LblCpRefound.Text = "0"
        '
        'LblLost
        '
        Me.LblLost.Location = New System.Drawing.Point(961, 159)
        Me.LblLost.Name = "LblLost"
        Me.LblLost.Size = New System.Drawing.Size(33, 16)
        Me.LblLost.TabIndex = 61
        Me.LblLost.Text = "perdu"
        Me.LblLost.Visible = False
        '
        'LblRefound
        '
        Me.LblRefound.Location = New System.Drawing.Point(776, 157)
        Me.LblRefound.Name = "LblRefound"
        Me.LblRefound.Size = New System.Drawing.Size(51, 16)
        Me.LblRefound.TabIndex = 60
        Me.LblRefound.Text = "Retrouve"
        '
        'frmStockInventory
        '
        Me.AcceptButton = Me.btnOK1
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1168, 715)
        Me.Controls.Add(Me.LblcptLost)
        Me.Controls.Add(Me.LblCpRefound)
        Me.Controls.Add(Me.LblLost)
        Me.Controls.Add(Me.LblRefound)
        Me.Controls.Add(Me.GridInventary)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmStockInventory"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        Me.Controls.SetChildIndex(Me.PanelControl2, 0)
        Me.Controls.SetChildIndex(Me.GridInventary, 0)
        Me.Controls.SetChildIndex(Me.LblRefound, 0)
        Me.Controls.SetChildIndex(Me.LblLost, 0)
        Me.Controls.SetChildIndex(Me.LblCpRefound, 0)
        Me.Controls.SetChildIndex(Me.LblcptLost, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkResetCounter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEQSQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEBadSticker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridInventary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewInventary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtINFO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAllDVD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Const _tableName As String = "products_dvd_stock_1"
    Dim _cptRefound As Integer = 0
    Dim _CheckProcess As ClsCheckProcessLogistic

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        GridInventary.ContextMenuStrip = menuStrip

        txtProducts_id.ForeColor = Drawing.Color.Black
        txtDVD_ID.ForeColor = Drawing.Color.Black
        clsDevExpress.AddHyperlinkDynamic(GridInventary)
        initCheckProcess()

    End Sub

    Private Sub initCheckProcess()
        _CheckProcess = New ClsCheckProcessLogistic()
        _CheckProcess.txtInfo = txtINFO
        _CheckProcess.sessionInfo = SessionInfo
        _CheckProcess.objDS = objDS
        _CheckProcess.btnSearch = btnSearchActif
        _CheckProcess.txtbarcode = txtBarCode
        _CheckProcess.btnUnlock = btnUnlock
        _CheckProcess.Ctrlbox_id = txtBoxID
        objDS.EnforceConstraints = False
    End Sub

    Public Sub BarCode_OK()


        Dim _NewRow As DataRow
        Dim _DS As New dsProducts
        Dim objProductDVD As clsProduct_DVD
        Dim box_id As Integer
        Dim pibox_id As Integer
        Dim dt As DataTable

        dt = objDS.Tables(_tableName)
        If txtINFO.Text <> "" Then
            btnSearchActif.Focus()
            MsgBox("click unlock button ", MsgBoxStyle.Exclamation)
            _CheckProcess.DisableBarCode()
            Exit Sub
        End If
        objProductDVD = _CheckProcess.GetCodeBar(txtBarCode.Text)
        If objProductDVD Is Nothing Then Return

        txtProducts_id.EditValue = objProductDVD.ProductsID
        txtDVD_ID.EditValue = objProductDVD.DvdId

        ' deja dans la liste en memoire representant la boite
        If Not _CheckProcess.ExistAlreadyBox(dt, objProductDVD) Then
            ' se trouve dans une autre boite physique dans le stock   
            If Not _CheckProcess.CheckdvdAlreadyInStock(objProductDVD.BoxID) Then
                ' la boite n'est pas pleine 
                If Not _CheckProcess.CheckFullBox(dt, txtBoxID.EditValue) Then
                    Dim currentdvd_status As DvdPostData.clsProductDvd.DVDStatus
                    currentdvd_status = objProductDVD.products_dvd_status
                    ' le status du dvd est valide 
                    If _CheckProcess.CheckStatus(currentdvd_status, objProductDVD, chkResetCounter.Checked, _cptRefound) Then
                        currentdvd_status = DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK
                        _CheckProcess.ChkAlert(objProductDVD)
                        ' pas d'order associe a ce dvd 
                        If _CheckProcess.CheckOrder(objProductDVD) Then


                            box_id = Integer.Parse(txtBoxID.EditValue)
                            pibox_id = DVDPostBuziness.ClsproductsDvd.getFirstPosBox(dt, "pibox_id") + 1

                            _NewRow = objDS.Tables(_tableName).NewRow
                            '  _NewRow.ItemArray = objProductDVD.Products_dvd_row.ItemArray
                            _NewRow("products_id") = objProductDVD.ProductsID
                            _NewRow("products_dvdid") = objProductDVD.DvdId
                            _NewRow("products_dvd_status") = currentdvd_status
                            _NewRow("inout") = objProductDVD.INOUT
                            _NewRow("bar_code") = txtBarCode.Text
                            _NewRow("box_id") = txtBoxID.EditValue
                            _NewRow("pibox_id") = DVDPostBuziness.ClsproductsDvd.getFirstPosBox(objDS.Tables(_tableName), "pibox_id") + 1

                            objDS.Tables(_tableName).Rows.InsertAt(_NewRow, 0)

                            'objProductDVD.ChangeStateProductsDVD(currentdvd_status, _
                            '                                     _NewRow("box_id"), _
                            '                                     _NewRow("pibox_id"), _
                            '                                     "Inventaire OK", DvdPostData.ClsProducts_dvd_state.state.STOCK, DvdPostData.clsProductDvd.INOUT.IN)

                            objProductDVD.ChangeStateProductsDVD(currentdvd_status, _
                                                               box_id, _
                                                               pibox_id, _
                                                               "Inventaire OK", DvdPostData.ClsProducts_dvd_state.state.STOCK, DvdPostData.clsProductDvd.INOUT.IN)

                            '_CheckProcess.RefreshData(dt, box_id)
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

    Private Sub displaycpt()
        LblCpRefound.Text = _cptRefound
        '  LblcptLost.Text = _cptLost
    End Sub


    Private Function ValidAllBoxId() As Int16
        If txtBoxID.EditValue = 0 Then
            System.Windows.Forms.MessageBox.Show("BoxId must be set")
            txtBoxID.Focus()
            Return 1
        End If

        Return 0
    End Function
    Private Sub btnFindBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindBarCode.Click
        _CheckProcess.GenereBarCode()
    End Sub
    ' !!! ne pas effacet
    'Public Function RemovedDvdStatusInventaire(ByVal box_id As Integer) As Integer
    '    Dim sql As String
    '    Dim dt As DataTable
    '    Dim _objProdDVD As clsProduct_DVD
    '    sql = DvdPostData.clsProductDvd.GetSelectProductStatusInventaire(box_id)
    '    dt = DvdPostData.clsConnection.FillDataSet(sql)
    '    Dim cpt As Integer = 0

    '    For Each dr As DataRow In dt.Rows
    '        _objProdDVD = New clsProduct_DVD(SessionInfo, objDS, dr("products_id"), dr("products_dvd"))
    '        _objProdDVD.ChangeStateProductsDVD(_objProdDVD.products_dvd_status, _
    '                                         "INVENTAIRE ERROR", DvdPostData.ClsProducts_dvd_state.state.STOCK, dr("inout"))

    '        cpt += 1
    '    Next

    '    Return cpt
    'End Function


    Private Sub btnSearchActif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchActif.Click
        If btnUnlock.Visible = True Then Return
        _CheckProcess.RefreshData(objDS.Tables(_tableName), Integer.Parse(txtBoxID.EditValue), True)

    End Sub
    Private Sub CEBadSticker_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEBadSticker.CheckedChanged
        If btnUnlock.Visible = True Then Return
        txtBarCode.Focus()
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If btnUnlock.Visible = True Then Return
        If _CheckProcess.CheckValidBox(txtBoxID) Then
            If _CheckProcess.cleanBox(objDS.Tables(_tableName), txtBoxID.EditValue) Then
                _CheckProcess.EnableBarCode()
            End If

        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK1.Click
        '      If btnUnlock.Visible = True Then Return
        If ValidAllBoxId() = 0 Then
            BarCode_OK()
            displaycpt()
        Else
            DoEvents()
        End If

    End Sub

    Private Sub btnResetNbrs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetNbrs1.Click
        If btnUnlock.Visible = True Then Return
        DVDPostBuziness.ClsproductsDvd.resetposinbox(objDS.Tables(_tableName))
        _CheckProcess.RefreshData(objDS.Tables(_tableName), Integer.Parse(txtBoxID.EditValue), True)
    End Sub

    Private Sub txtBoxID_EditValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtBoxID.EditValueChanged

        If btnUnlock.Visible = True Then Return

        _CheckProcess.RefreshData(objDS.Tables(_tableName), Integer.Parse(txtBoxID.EditValue), True)
        txtBoxID.Focus()
    End Sub


    Private Sub btnFindBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindBox.Click
        _CheckProcess.GetMoreEmptyBox(Me)
    End Sub

    Private Sub btnBoxOrderInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoxOrderInventory.Click
        _CheckProcess.GetLastInventory(Me)
    End Sub

    Private Sub btnBoxEmpty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoxEmpty.Click
        _CheckProcess.GetBoxEmpty(Me)
    End Sub
End Class
