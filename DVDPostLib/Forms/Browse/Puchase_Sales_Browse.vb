Imports MySql.Data.MySqlClient

Public Class Form1
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents DS As dsPur_Sls
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblRank1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_rank1_1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_rank1_2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_rank2_1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_rank2_2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_rank3_1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_rank3_2 As System.Windows.Forms.TextBox
    Friend WithEvents UcPivotGrid1 As BizzLib.ucPivotGrid
    Friend WithEvents ProgressBar1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents TabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabParam As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabResult As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabAnal As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabGraph As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colProduct_ID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProducts_Title As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colw_q1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colw_q2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colw_q3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colst_q As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colp_price As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cols_price As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cols_q As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colp_q As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_date_available As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFeeSharing As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMini1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMini2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMini3 As System.Windows.Forms.TextBox
    Friend WithEvents colw_mini1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colw_mini2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colw_mini3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colst_mini As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents txtLimit As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents colfeesharing_end As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colw_q0 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProducts_Studio As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStudio_Name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents UcChart1 As BizzLib.ucChart
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.DS = New DVDPost.dsPur_Sls
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colProduct_ID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colProducts_Title = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_date_available = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colFeeSharing = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colw_q1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colw_mini1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colw_q2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colw_mini2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colw_q3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colw_mini3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colst_q = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colp_price = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cols_price = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colst_mini = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cols_q = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colp_q = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colfeesharing_end = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colw_q0 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colProducts_Studio = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colStudio_Name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.lbl1 = New System.Windows.Forms.Label
        Me.TabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tabParam = New DevExpress.XtraTab.XtraTabPage
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLimit = New System.Windows.Forms.TextBox
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.txtMini3 = New System.Windows.Forms.TextBox
        Me.txtMini2 = New System.Windows.Forms.TextBox
        Me.txtMini1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txt_rank3_2 = New System.Windows.Forms.TextBox
        Me.txt_rank3_1 = New System.Windows.Forms.TextBox
        Me.txt_rank2_2 = New System.Windows.Forms.TextBox
        Me.txt_rank2_1 = New System.Windows.Forms.TextBox
        Me.txt_rank1_2 = New System.Windows.Forms.TextBox
        Me.txt_rank1_1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblRank1 = New System.Windows.Forms.Label
        Me.tabResult = New DevExpress.XtraTab.XtraTabPage
        Me.tabAnal = New DevExpress.XtraTab.XtraTabPage
        Me.UcPivotGrid1 = New BizzLib.ucPivotGrid
        Me.tabGraph = New DevExpress.XtraTab.XtraTabPage
        Me.UcChart1 = New BizzLib.ucChart
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabParam.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.tabResult.SuspendLayout()
        Me.tabAnal.SuspendLayout()
        Me.tabGraph.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(288, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ok"
        '
        'Grid1
        '
        Me.Grid1.DataSource = Me.DS.PS_Ana
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'Grid1.EmbeddedNavigator
        '
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.AdvBandedGridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(1039, 495)
        Me.Grid1.TabIndex = 1
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGridView1})
        '
        'DS
        '
        Me.DS.DataSetName = "DS1"
        Me.DS.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colProduct_ID, Me.colProducts_Title, Me.colw_q1, Me.colw_q2, Me.colw_q3, Me.colst_q, Me.colp_price, Me.cols_price, Me.cols_q, Me.colp_q, Me.colproducts_date_available, Me.colFeeSharing, Me.colw_mini1, Me.colw_mini2, Me.colw_mini3, Me.colst_mini, Me.colfeesharing_end, Me.colw_q0, Me.colProducts_Studio, Me.colStudio_Name})
        Me.AdvBandedGridView1.GridControl = Me.Grid1
        Me.AdvBandedGridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsBehavior.Editable = False
        Me.AdvBandedGridView1.OptionsView.ShowBands = False
        Me.AdvBandedGridView1.OptionsView.ShowFooter = True
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colProduct_ID)
        Me.GridBand1.Columns.Add(Me.colProducts_Title)
        Me.GridBand1.Columns.Add(Me.colproducts_date_available)
        Me.GridBand1.Columns.Add(Me.colFeeSharing)
        Me.GridBand1.Columns.Add(Me.colw_q1)
        Me.GridBand1.Columns.Add(Me.colw_mini1)
        Me.GridBand1.Columns.Add(Me.colw_q2)
        Me.GridBand1.Columns.Add(Me.colw_mini2)
        Me.GridBand1.Columns.Add(Me.colw_q3)
        Me.GridBand1.Columns.Add(Me.colw_mini3)
        Me.GridBand1.Columns.Add(Me.colst_q)
        Me.GridBand1.Columns.Add(Me.colp_price)
        Me.GridBand1.Columns.Add(Me.cols_price)
        Me.GridBand1.Columns.Add(Me.colst_mini)
        Me.GridBand1.Columns.Add(Me.cols_q)
        Me.GridBand1.Columns.Add(Me.colp_q)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 1050
        '
        'colProduct_ID
        '
        Me.colProduct_ID.Caption = "Product_ID"
        Me.colProduct_ID.FieldName = "Product_ID"
        Me.colProduct_ID.Name = "colProduct_ID"
        Me.colProduct_ID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colProduct_ID.Visible = True
        '
        'colProducts_Title
        '
        Me.colProducts_Title.Caption = "Products_Title"
        Me.colProducts_Title.FieldName = "Products_Title"
        Me.colProducts_Title.Name = "colProducts_Title"
        Me.colProducts_Title.Visible = True
        '
        'colproducts_date_available
        '
        Me.colproducts_date_available.Caption = "products_date_available"
        Me.colproducts_date_available.FieldName = "products_date_available"
        Me.colproducts_date_available.Name = "colproducts_date_available"
        Me.colproducts_date_available.Visible = True
        '
        'colFeeSharing
        '
        Me.colFeeSharing.Caption = "FeeSharing"
        Me.colFeeSharing.FieldName = "FeeSharing"
        Me.colFeeSharing.Name = "colFeeSharing"
        Me.colFeeSharing.Visible = True
        '
        'colw_q1
        '
        Me.colw_q1.Caption = "Whish1"
        Me.colw_q1.FieldName = "w_q1"
        Me.colw_q1.Name = "colw_q1"
        Me.colw_q1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colw_q1.Visible = True
        '
        'colw_mini1
        '
        Me.colw_mini1.Caption = "w_mini1"
        Me.colw_mini1.FieldName = "w_mini1"
        Me.colw_mini1.Name = "colw_mini1"
        Me.colw_mini1.Visible = True
        '
        'colw_q2
        '
        Me.colw_q2.Caption = "Whish2"
        Me.colw_q2.FieldName = "w_q2"
        Me.colw_q2.Name = "colw_q2"
        Me.colw_q2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colw_q2.Visible = True
        '
        'colw_mini2
        '
        Me.colw_mini2.Caption = "w_mini2"
        Me.colw_mini2.FieldName = "w_mini2"
        Me.colw_mini2.Name = "colw_mini2"
        Me.colw_mini2.Visible = True
        '
        'colw_q3
        '
        Me.colw_q3.Caption = "Whish3"
        Me.colw_q3.FieldName = "w_q3"
        Me.colw_q3.Name = "colw_q3"
        Me.colw_q3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colw_q3.Visible = True
        '
        'colw_mini3
        '
        Me.colw_mini3.Caption = "w_mini3"
        Me.colw_mini3.FieldName = "w_mini3"
        Me.colw_mini3.Name = "colw_mini3"
        Me.colw_mini3.Visible = True
        '
        'colst_q
        '
        Me.colst_q.Caption = "Stock OK"
        Me.colst_q.FieldName = "st_q"
        Me.colst_q.Name = "colst_q"
        Me.colst_q.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colst_q.Visible = True
        '
        'colp_price
        '
        Me.colp_price.Caption = "p_price"
        Me.colp_price.FieldName = "p_price"
        Me.colp_price.Name = "colp_price"
        '
        'cols_price
        '
        Me.cols_price.Caption = "s_price"
        Me.cols_price.FieldName = "s_price"
        Me.cols_price.Name = "cols_price"
        '
        'colst_mini
        '
        Me.colst_mini.Caption = "st_mini"
        Me.colst_mini.FieldName = "st_mini"
        Me.colst_mini.Name = "colst_mini"
        Me.colst_mini.Visible = True
        '
        'cols_q
        '
        Me.cols_q.Caption = "A Vendre"
        Me.cols_q.FieldName = "s_q"
        Me.cols_q.Name = "cols_q"
        Me.cols_q.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.cols_q.Visible = True
        '
        'colp_q
        '
        Me.colp_q.Caption = "A Acheter"
        Me.colp_q.FieldName = "p_q"
        Me.colp_q.Name = "colp_q"
        Me.colp_q.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colp_q.Visible = True
        '
        'colfeesharing_end
        '
        Me.colfeesharing_end.Caption = "feesharing_end"
        Me.colfeesharing_end.FieldName = "feesharing_end"
        Me.colfeesharing_end.Name = "colfeesharing_end"
        Me.colfeesharing_end.Visible = True
        '
        'colw_q0
        '
        Me.colw_q0.Caption = "w_q0"
        Me.colw_q0.FieldName = "w_q0"
        Me.colw_q0.Name = "colw_q0"
        Me.colw_q0.Visible = True
        '
        'colProducts_Studio
        '
        Me.colProducts_Studio.Caption = "Products_Studio"
        Me.colProducts_Studio.FieldName = "Products_Studio"
        Me.colProducts_Studio.Name = "colProducts_Studio"
        Me.colProducts_Studio.Visible = True
        '
        'colStudio_Name
        '
        Me.colStudio_Name.Caption = "Studio_Name"
        Me.colStudio_Name.FieldName = "Studio_Name"
        Me.colStudio_Name.Name = "colStudio_Name"
        Me.colStudio_Name.Visible = True
        '
        'lbl1
        '
        Me.lbl1.Location = New System.Drawing.Point(288, 48)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(192, 23)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "#"
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabPage = Me.tabParam
        Me.TabControl1.Size = New System.Drawing.Size(944, 510)
        Me.TabControl1.TabIndex = 4
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabParam, Me.tabResult, Me.tabAnal, Me.tabGraph})
        Me.TabControl1.Text = "XtraTabControl1"
        '
        'tabParam
        '
        Me.tabParam.Controls.Add(Me.Label6)
        Me.tabParam.Controls.Add(Me.txtLimit)
        Me.tabParam.Controls.Add(Me.GroupControl3)
        Me.tabParam.Controls.Add(Me.ProgressBar1)
        Me.tabParam.Controls.Add(Me.GroupControl1)
        Me.tabParam.Controls.Add(Me.Button1)
        Me.tabParam.Controls.Add(Me.lbl1)
        Me.tabParam.Name = "tabParam"
        Me.tabParam.Size = New System.Drawing.Size(1039, 495)
        Me.tabParam.Text = "Parameters"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(408, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Limit"
        '
        'txtLimit
        '
        Me.txtLimit.Location = New System.Drawing.Point(520, 16)
        Me.txtLimit.Name = "txtLimit"
        Me.txtLimit.Size = New System.Drawing.Size(64, 20)
        Me.txtLimit.TabIndex = 8
        Me.txtLimit.Text = "1000000"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.txtMini3)
        Me.GroupControl3.Controls.Add(Me.txtMini2)
        Me.GroupControl3.Controls.Add(Me.txtMini1)
        Me.GroupControl3.Controls.Add(Me.Label5)
        Me.GroupControl3.Controls.Add(Me.Label4)
        Me.GroupControl3.Controls.Add(Me.Label3)
        Me.GroupControl3.Location = New System.Drawing.Point(16, 136)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(264, 136)
        Me.GroupControl3.TabIndex = 7
        Me.GroupControl3.Text = "Stock Mini"
        '
        'txtMini3
        '
        Me.txtMini3.Location = New System.Drawing.Point(136, 72)
        Me.txtMini3.Name = "txtMini3"
        Me.txtMini3.Size = New System.Drawing.Size(64, 20)
        Me.txtMini3.TabIndex = 9
        Me.txtMini3.Text = "6"
        '
        'txtMini2
        '
        Me.txtMini2.Location = New System.Drawing.Point(136, 48)
        Me.txtMini2.Name = "txtMini2"
        Me.txtMini2.Size = New System.Drawing.Size(64, 20)
        Me.txtMini2.TabIndex = 8
        Me.txtMini2.Text = "3"
        '
        'txtMini1
        '
        Me.txtMini1.Location = New System.Drawing.Point(136, 24)
        Me.txtMini1.Name = "txtMini1"
        Me.txtMini1.Size = New System.Drawing.Size(64, 20)
        Me.txtMini1.TabIndex = 7
        Me.txtMini1.Text = "1"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Monthes to serve Wish3"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Monthes to serve Wish2"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Monthes to serve Wish1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(288, 80)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(368, 18)
        Me.ProgressBar1.TabIndex = 6
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txt_rank3_2)
        Me.GroupControl1.Controls.Add(Me.txt_rank3_1)
        Me.GroupControl1.Controls.Add(Me.txt_rank2_2)
        Me.GroupControl1.Controls.Add(Me.txt_rank2_1)
        Me.GroupControl1.Controls.Add(Me.txt_rank1_2)
        Me.GroupControl1.Controls.Add(Me.txt_rank1_1)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.lblRank1)
        Me.GroupControl1.Location = New System.Drawing.Point(16, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(264, 112)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Rank Selection"
        '
        'txt_rank3_2
        '
        Me.txt_rank3_2.Location = New System.Drawing.Point(184, 80)
        Me.txt_rank3_2.Name = "txt_rank3_2"
        Me.txt_rank3_2.Size = New System.Drawing.Size(64, 20)
        Me.txt_rank3_2.TabIndex = 11
        Me.txt_rank3_2.Text = "1000"
        '
        'txt_rank3_1
        '
        Me.txt_rank3_1.Location = New System.Drawing.Point(112, 80)
        Me.txt_rank3_1.Name = "txt_rank3_1"
        Me.txt_rank3_1.Size = New System.Drawing.Size(64, 20)
        Me.txt_rank3_1.TabIndex = 10
        Me.txt_rank3_1.Text = "31"
        '
        'txt_rank2_2
        '
        Me.txt_rank2_2.Location = New System.Drawing.Point(184, 56)
        Me.txt_rank2_2.Name = "txt_rank2_2"
        Me.txt_rank2_2.Size = New System.Drawing.Size(64, 20)
        Me.txt_rank2_2.TabIndex = 9
        Me.txt_rank2_2.Text = "30"
        '
        'txt_rank2_1
        '
        Me.txt_rank2_1.Location = New System.Drawing.Point(112, 56)
        Me.txt_rank2_1.Name = "txt_rank2_1"
        Me.txt_rank2_1.Size = New System.Drawing.Size(64, 20)
        Me.txt_rank2_1.TabIndex = 8
        Me.txt_rank2_1.Text = "11"
        '
        'txt_rank1_2
        '
        Me.txt_rank1_2.Location = New System.Drawing.Point(184, 32)
        Me.txt_rank1_2.Name = "txt_rank1_2"
        Me.txt_rank1_2.Size = New System.Drawing.Size(64, 20)
        Me.txt_rank1_2.TabIndex = 7
        Me.txt_rank1_2.Text = "10"
        '
        'txt_rank1_1
        '
        Me.txt_rank1_1.Location = New System.Drawing.Point(112, 32)
        Me.txt_rank1_1.Name = "txt_rank1_1"
        Me.txt_rank1_1.Size = New System.Drawing.Size(64, 20)
        Me.txt_rank1_1.TabIndex = 6
        Me.txt_rank1_1.Text = "0"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Rank Low"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Rank Medium"
        '
        'lblRank1
        '
        Me.lblRank1.Location = New System.Drawing.Point(8, 32)
        Me.lblRank1.Name = "lblRank1"
        Me.lblRank1.TabIndex = 3
        Me.lblRank1.Text = "Rank Hi"
        '
        'tabResult
        '
        Me.tabResult.Controls.Add(Me.Grid1)
        Me.tabResult.Name = "tabResult"
        Me.tabResult.Size = New System.Drawing.Size(1039, 495)
        Me.tabResult.Text = "Result"
        '
        'tabAnal
        '
        Me.tabAnal.Controls.Add(Me.UcPivotGrid1)
        Me.tabAnal.Name = "tabAnal"
        Me.tabAnal.Size = New System.Drawing.Size(1039, 495)
        Me.tabAnal.Text = "Analyse"
        '
        'UcPivotGrid1
        '
        Me.UcPivotGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcPivotGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UcPivotGrid1.Name = "UcPivotGrid1"
        Me.UcPivotGrid1.SessionInfo = Nothing
        Me.UcPivotGrid1.Size = New System.Drawing.Size(1039, 495)
        Me.UcPivotGrid1.TabIndex = 0
        '
        'tabGraph
        '
        Me.tabGraph.Controls.Add(Me.UcChart1)
        Me.tabGraph.Name = "tabGraph"
        Me.tabGraph.Size = New System.Drawing.Size(935, 479)
        Me.tabGraph.Text = "Graphs"
        '
        'UcChart1
        '
        Me.UcChart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcChart1.Location = New System.Drawing.Point(0, 0)
        Me.UcChart1.Name = "UcChart1"
        Me.UcChart1.Size = New System.Drawing.Size(935, 479)
        Me.UcChart1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(944, 510)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Sales and Purchase"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabParam.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.tabResult.ResumeLayout(False)
        Me.tabAnal.ResumeLayout(False)
        Me.tabGraph.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim conn As New MySqlConnection("Server=localhost;Uid=root;Pwd=tutu;Database=dvdpost_be_prod;Port=3306")
    Dim Cmd As MySqlCommand
    Dim DAdapt As MySqlDataAdapter
    Dim CmdBld As MySqlCommandBuilder
    Dim _Data As New BizzLib.clsDataSet(SessionInfo)
    Dim _Limit As String = " limit 0, 100 "

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UcPivotGrid1.Initialize(SessionInfo)
        UcPivotGrid1.PivotGrid1.DataSource = DS.Tables("PS_Ana").DefaultView
        Grid1.DataMember = ""
        UcPivotGrid1.PivotGrid1.DataMember = ""
        UcPivotGrid1.SetFields()
        UcChart1.Initialize(SessionInfo)
        UcChart1.TableName = "PS_Ana"

        UcChart1.LoadFieldList()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim _SQLTxt As String

        'Clear Table
        DS.Tables("PS_Ana").Clear()

        'FeeSharing
        'Dim _SQLFee As String = " AND Feesharing in (-1, "
        'If chkFeeSharing.Checked Then
        '    _SQLFee += "1, "
        'End If
        'If chkNonFeeSharing.Checked Then
        '    _SQLFee += "0, "
        'End If
        '_SQLFee += "2) "

        'Updating Feesharing_end = 0000-00-00 00:00:00 to 1801-01-01 00:00:00
        _SQLTxt = "Update Products Set Feesharing_end = '1801-01-01 00:00:00' where Feesharing_End = '0000-00-00 00:00:00'"
        lbl1.Text = "updating : " & _Data.ExecuteNonQuery(_SQLTxt)

        'Products
        _SQLTxt = "SELECT P.Products_ID Product_ID, P.Products_Studio, S.Studio_Name, P.Feesharing, P.Feesharing_end, Products_Title, Products_Date_Available, " & _
                  " count(pdvd.products_dvdid) st_q FROM Products P " & _
                  " LEFT JOIN Products_DVD PDvd ON P.Products_ID = PDVD.Products_ID " & _
                  " LEFT JOIN Studio S ON P.Products_Studio = S.Studio_Id " & _
                  " WHERE P.Products_ID > 50 AND Products_dvd_status = 1 " & _
                  " GROUp BY P.Products_ID " & _Limit
        _Data.FillDataSet(DS.Tables("PS_Ana"), _SQLTxt)

        'WhisList Part0
        MergeWhishInfo(0, _Limit, 0, 9999)

        'WhisList Part1
        MergeWhishInfo(1, _Limit, txt_rank1_1.Text, txt_rank1_2.Text)

        'WidhList Part2

        MergeWhishInfo(2, _Limit, txt_rank2_1.Text, txt_rank2_2.Text)

        'WidhList Part3
        MergeWhishInfo(3, _Limit, txt_rank3_1.Text, txt_rank3_2.Text)

        ComputeStockMini()

        TabControl1.SelectedTabPage = tabResult

    End Sub

    'Public Sub MergeFeesharingEnd()
    '    Dim _SQLTxt As String
    '    Dim _tmpDS As New DVDLib.DS1
    '    Dim _row As DataRow
    '    Dim _i As Integer = 0
    '    Dim _Row2 As DataRow

    '    lbl1.Text = "FeeSharing End"
    '    lbl1.Refresh()
    '    ProgressBar1.Properties.Minimum = 0
    '    ProgressBar1.Properties.Maximum = DS.Tables("PS_Ana").Rows.Count
    '    ProgressBar1.EditValue = 0

    '    'WhisList
    '    _SQLTxt = "SELECT Products_ID as ID, Feesharing_end as Txt1 from Products as tmp1 "
    '    _Data.FillDataSet(_tmpDS.Tables("tmp1"), _SQLTxt)
    '    For Each _row In DS.Tables("PS_Ana").Rows
    '        ProgressBar1.EditValue += 1
    '        ProgressBar1.Refresh()
    '        _Row2 = _tmpDS.Tables("tmp1").Rows.Find(New Object() {_row.Item("Product_ID")})
    '        If Not IsNothing(_Row2) Then
    '            _row.BeginEdit()
    '            If _Row2.Item("txt1") <> "0000-00-00 00:00:00" Then
    '                _row.Item("Feesharing_end") = "1/1/1801"
    '            Else
    '                _row.Item("Feesharing_end") = _Row2.Item("txt1")
    '            End If

    '            _row.EndEdit()
    '        Else
    '            _row.Item("feesharing_end") = "1/1/1801"
    '        End If
    '    Next
    '    ProgressBar1.EditValue = 0

    'End Sub
    Public Sub MergeWhishInfo(ByVal vPart As Integer, ByVal vLimit As String, ByVal vMin As Integer, ByVal vMax As Integer)
        Dim _SQLTxt As String
        Dim _tmpDS As New dsPur_Sls
        Dim _row As DataRow
        Dim _i As Integer = 0
        Dim _Row2 As DataRow

        lbl1.Text = "Part" & vPart
        lbl1.Refresh()
        ProgressBar1.Properties.Minimum = 0
        ProgressBar1.Properties.Maximum = DS.Tables("PS_Ana").Rows.Count
        ProgressBar1.EditValue = 0

        'WhisList
        _SQLTxt = "SELECT Product_ID, count(product_id) w_q2 FROM WishList W " & _
                  " LEFT JOIN CUSTOMERS Cust ON W.Customers_ID = Cust.Customers_ID " & _
                  " WHERE Rank >= " & vMin & " and Rank <= " & vMax & " and Cust.Customers_Abo = 1 " & _
                  " group by Product_id " & vLimit
        _Data.FillDataSet(_tmpDS.Tables("PS_Ana"), _SQLTxt)
        For Each _row In DS.Tables("PS_Ana").Rows
            ProgressBar1.EditValue += 1
            ProgressBar1.Refresh()
            _Row2 = _tmpDS.Tables("PS_Ana").Rows.Find(New Object() {_row.Item("Product_ID")})
            If Not IsNothing(_Row2) Then
                _row.BeginEdit()
                _row.Item("W_Q" & vPart) = _Row2.Item("W_Q2")
                _row.EndEdit()
            Else
                _row.Item("W_Q" & vPart) = 0
            End If
        Next
        ProgressBar1.EditValue = 0
    End Sub

    Public Sub ComputeStockMini()
        Dim _row As DataRow
        lbl1.Text = "Processing Stock Mini"
        lbl1.Refresh()
        ProgressBar1.Properties.Minimum = 0
        ProgressBar1.Properties.Maximum = DS.Tables("PS_Ana").Rows.Count
        ProgressBar1.EditValue = 0
        For Each _row In DS.Tables("PS_Ana").Rows
            ProgressBar1.EditValue += 1
            ProgressBar1.Refresh()
            _row.BeginEdit()
            _row.Item("w_mini1") = _row.Item("w_q1") / 5 / txtMini1.Text
            _row.Item("w_mini2") = _row.Item("w_q2") / 5 / txtMini2.Text
            _row.Item("w_mini3") = _row.Item("w_q3") / 5 / txtMini3.Text
            _row.Item("st_mini") = 1
            _row.Item("st_mini") = Math.Max(_row.Item("st_mini"), _row.Item("w_mini1"))
            _row.Item("st_mini") = Math.Max(_row.Item("st_mini"), _row.Item("w_mini2"))
            _row.Item("st_mini") = Math.Max(_row.Item("st_mini"), _row.Item("w_mini3"))
            If _row.Item("st_mini") <= _row.Item("st_q") Then
                _row.Item("s_q") = _row.Item("st_q") - _row.Item("st_mini")
                _row.Item("p_q") = 0
            Else
                _row.Item("s_q") = 0
                _row.Item("p_q") = _row.Item("st_mini") - _row.Item("st_q")
            End If
            _row.EndEdit()
        Next
        ProgressBar1.EditValue = 0
        lbl1.Text = ""
    End Sub

    Private Sub txtLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimit.TextChanged
        _Limit = "limit 0, " & txtLimit.Text
    End Sub

End Class
