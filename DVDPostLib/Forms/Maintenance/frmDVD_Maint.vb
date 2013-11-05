Imports BizzLib.clsGlobal.ObjectState
Public Class frmDVD_Maint
    Inherits BizzLib.frmGeneral_Maintenance

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
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabMain As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabFR As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabNL As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabEN As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabLanguages As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabTheme As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblProductID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtModel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblModel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtyNow As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblQtyNow As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateAdded As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateAdded As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDateAvailable As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtYear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblYear As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRunTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblRunTime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCountry As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbCountry As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbStudio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblStudio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPublic As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPublic As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbPictureFormat As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPictureFormat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbRating As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblRating As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDirector As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblDirector As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpSeries As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblSeries As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbSerie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtSerieNbr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSerieNbr As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkSerieAboProcess As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grpImage As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents grpActors As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnActorsMaint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSearch As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcustomers_id_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitleSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents objDS As DVDPostLib.dsProducts
    Friend WithEvents colproducts_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents collanguage_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_model As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbLanguages As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tabDVDs As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnRemoveDVD As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.objDS = New DVDPostLib.dsProducts
        Me.GridViewSearch = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colproducts_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.collanguage_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbLanguages = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colproducts_name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_model = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.txtTitleSearch = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtcustomers_id_search = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.tabMain = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.btnRemoveDVD = New DevExpress.XtraEditors.SimpleButton
        Me.grpActors = New DevExpress.XtraEditors.GroupControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnActorsMaint = New DevExpress.XtraEditors.SimpleButton
        Me.grpImage = New DevExpress.XtraEditors.GroupControl
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.grpSeries = New DevExpress.XtraEditors.GroupControl
        Me.chkSerieAboProcess = New DevExpress.XtraEditors.CheckEdit
        Me.txtSerieNbr = New DevExpress.XtraEditors.TextEdit
        Me.lblSerieNbr = New DevExpress.XtraEditors.LabelControl
        Me.cmbSerie = New DevExpress.XtraEditors.LookUpEdit
        Me.lblSeries = New DevExpress.XtraEditors.LabelControl
        Me.grpMain = New DevExpress.XtraEditors.GroupControl
        Me.cmbStatus = New DevExpress.XtraEditors.LookUpEdit
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl
        Me.cmbDirector = New DevExpress.XtraEditors.LookUpEdit
        Me.lblDirector = New DevExpress.XtraEditors.LabelControl
        Me.cmbRating = New DevExpress.XtraEditors.LookUpEdit
        Me.lblRating = New DevExpress.XtraEditors.LabelControl
        Me.cmbPictureFormat = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPictureFormat = New DevExpress.XtraEditors.LabelControl
        Me.txtPublic = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPublic = New DevExpress.XtraEditors.LabelControl
        Me.cmbStudio = New DevExpress.XtraEditors.LookUpEdit
        Me.lblStudio = New DevExpress.XtraEditors.LabelControl
        Me.cmbCountry = New DevExpress.XtraEditors.LookUpEdit
        Me.lblCountry = New DevExpress.XtraEditors.LabelControl
        Me.txtRunTime = New DevExpress.XtraEditors.TextEdit
        Me.lblRunTime = New DevExpress.XtraEditors.LabelControl
        Me.txtYear = New DevExpress.XtraEditors.TextEdit
        Me.lblYear = New DevExpress.XtraEditors.LabelControl
        Me.txtDateAvailable = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtDateAdded = New DevExpress.XtraEditors.DateEdit
        Me.lblDateAdded = New DevExpress.XtraEditors.LabelControl
        Me.txtQtyNow = New DevExpress.XtraEditors.TextEdit
        Me.lblQtyNow = New DevExpress.XtraEditors.LabelControl
        Me.txtQty = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl
        Me.txtModel = New DevExpress.XtraEditors.TextEdit
        Me.lblModel = New DevExpress.XtraEditors.LabelControl
        Me.txtProductID = New DevExpress.XtraEditors.TextEdit
        Me.lblProductID = New DevExpress.XtraEditors.LabelControl
        Me.tabFR = New DevExpress.XtraTab.XtraTabPage
        Me.tabNL = New DevExpress.XtraTab.XtraTabPage
        Me.tabEN = New DevExpress.XtraTab.XtraTabPage
        Me.tabTheme = New DevExpress.XtraTab.XtraTabPage
        Me.tabLanguages = New DevExpress.XtraTab.XtraTabPage
        Me.tabDVDs = New DevExpress.XtraTab.XtraTabPage
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabSearch.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcustomers_id_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.grpActors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpActors.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grpImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpImage.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSeries.SuspendLayout()
        CType(Me.chkSerieAboProcess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieNbr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDirector.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPictureFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPublic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRunTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateAvailable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateAdded.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtyNow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintSystem1
        '
        Me.PrintSystem1.ExportOptions.XlsNativeFormat = True
        '
        'PopMenuUndo
        '
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 424)
        Me.StatusBar1.Name = "StatusBar1"
        '
        'PopMenuSave
        '
        '
        'PopMenuEdit
        '
        '
        'Misc_Bar2
        '
        Me.Misc_Bar2.DockCol = 4
        '
        'Misc_Bar
        '
        Me.Misc_Bar.DockCol = 5
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 57)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabSearch
        Me.XtraTabControl1.Size = New System.Drawing.Size(1056, 389)
        Me.XtraTabControl1.TabIndex = 35
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabSearch, Me.tabMain, Me.tabFR, Me.tabNL, Me.tabEN, Me.tabTheme, Me.tabLanguages, Me.tabDVDs})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'tabSearch
        '
        Me.tabSearch.Controls.Add(Me.GridControl2)
        Me.tabSearch.Controls.Add(Me.PanelControl2)
        Me.tabSearch.Name = "tabSearch"
        Me.tabSearch.Size = New System.Drawing.Size(1047, 358)
        Me.tabSearch.Text = "Search"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.objDS.products_description1
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'GridControl2.EmbeddedNavigator
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(0, 80)
        Me.GridControl2.MainView = Me.GridViewSearch
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbLanguages})
        Me.GridControl2.Size = New System.Drawing.Size(1047, 278)
        Me.GridControl2.TabIndex = 3
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSearch})
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsProducts"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GridViewSearch
        '
        Me.GridViewSearch.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridViewSearch.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colproducts_id, Me.collanguage_id, Me.colproducts_name, Me.colproducts_model})
        Me.GridViewSearch.GridControl = Me.GridControl2
        Me.GridViewSearch.Name = "GridViewSearch"
        Me.GridViewSearch.OptionsBehavior.Editable = False
        Me.GridViewSearch.OptionsView.ShowAutoFilterRow = True
        Me.GridViewSearch.OptionsView.ShowBands = False
        Me.GridViewSearch.OptionsView.ShowFooter = True
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colproducts_id)
        Me.GridBand1.Columns.Add(Me.collanguage_id)
        Me.GridBand1.Columns.Add(Me.colproducts_name)
        Me.GridBand1.Columns.Add(Me.colproducts_model)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 806
        '
        'colproducts_id
        '
        Me.colproducts_id.Caption = "products_id"
        Me.colproducts_id.FieldName = "products_id"
        Me.colproducts_id.Name = "colproducts_id"
        Me.colproducts_id.Visible = True
        '
        'collanguage_id
        '
        Me.collanguage_id.Caption = "language_id"
        Me.collanguage_id.ColumnEdit = Me.cmbLanguages
        Me.collanguage_id.FieldName = "language_id"
        Me.collanguage_id.Name = "collanguage_id"
        Me.collanguage_id.Visible = True
        Me.collanguage_id.Width = 147
        '
        'cmbLanguages
        '
        Me.cmbLanguages.AutoHeight = False
        Me.cmbLanguages.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguages.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "languages_id", 82, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 32, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbLanguages.DataSource = Me.objDS.languages
        Me.cmbLanguages.DisplayMember = "name"
        Me.cmbLanguages.Name = "cmbLanguages"
        Me.cmbLanguages.ValueMember = "languages_id"
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
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnSearch)
        Me.PanelControl2.Controls.Add(Me.txtTitleSearch)
        Me.PanelControl2.Controls.Add(Me.LabelControl7)
        Me.PanelControl2.Controls.Add(Me.txtcustomers_id_search)
        Me.PanelControl2.Controls.Add(Me.LabelControl8)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1047, 80)
        Me.PanelControl2.TabIndex = 2
        Me.PanelControl2.Text = "PanelControl2"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(448, 40)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "&Search"
        '
        'txtTitleSearch
        '
        Me.txtTitleSearch.Location = New System.Drawing.Point(160, 40)
        Me.txtTitleSearch.Name = "txtTitleSearch"
        Me.txtTitleSearch.Size = New System.Drawing.Size(272, 20)
        Me.txtTitleSearch.TabIndex = 3
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(24, 48)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(136, 14)
        Me.LabelControl7.TabIndex = 2
        Me.LabelControl7.Text = "Part of Title"
        '
        'txtcustomers_id_search
        '
        Me.txtcustomers_id_search.Location = New System.Drawing.Point(160, 16)
        Me.txtcustomers_id_search.Name = "txtcustomers_id_search"
        Me.txtcustomers_id_search.Size = New System.Drawing.Size(272, 20)
        Me.txtcustomers_id_search.TabIndex = 1
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(24, 22)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(136, 14)
        Me.LabelControl8.TabIndex = 0
        Me.LabelControl8.Text = "Products ID"
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.PanelControl3)
        Me.tabMain.Controls.Add(Me.grpActors)
        Me.tabMain.Controls.Add(Me.grpImage)
        Me.tabMain.Controls.Add(Me.grpSeries)
        Me.tabMain.Controls.Add(Me.grpMain)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Size = New System.Drawing.Size(1047, 358)
        Me.tabMain.Text = "General Info"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnRemoveDVD)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1047, 56)
        Me.PanelControl3.TabIndex = 4
        Me.PanelControl3.Text = "PanelControl3"
        '
        'btnRemoveDVD
        '
        Me.btnRemoveDVD.Location = New System.Drawing.Point(16, 16)
        Me.btnRemoveDVD.Name = "btnRemoveDVD"
        Me.btnRemoveDVD.TabIndex = 0
        Me.btnRemoveDVD.Text = "Remove DVD"
        '
        'grpActors
        '
        Me.grpActors.Controls.Add(Me.GridControl1)
        Me.grpActors.Controls.Add(Me.PanelControl1)
        Me.grpActors.Location = New System.Drawing.Point(728, 72)
        Me.grpActors.Name = "grpActors"
        Me.grpActors.Size = New System.Drawing.Size(200, 304)
        Me.grpActors.TabIndex = 3
        Me.grpActors.Text = "Actors"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(196, 242)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnActorsMaint)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(2, 262)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(196, 40)
        Me.PanelControl1.TabIndex = 1
        Me.PanelControl1.Text = "PanelControl1"
        '
        'btnActorsMaint
        '
        Me.btnActorsMaint.Location = New System.Drawing.Point(48, 8)
        Me.btnActorsMaint.Name = "btnActorsMaint"
        Me.btnActorsMaint.Size = New System.Drawing.Size(96, 23)
        Me.btnActorsMaint.TabIndex = 0
        Me.btnActorsMaint.Text = "Manage Actors"
        '
        'grpImage
        '
        Me.grpImage.Controls.Add(Me.PictureEdit1)
        Me.grpImage.Controls.Add(Me.TextEdit1)
        Me.grpImage.Location = New System.Drawing.Point(456, 176)
        Me.grpImage.Name = "grpImage"
        Me.grpImage.Size = New System.Drawing.Size(264, 200)
        Me.grpImage.TabIndex = 2
        Me.grpImage.Text = "Small Image"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(88, 56)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 136)
        Me.PictureEdit1.TabIndex = 5
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(8, 24)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(248, 20)
        Me.TextEdit1.TabIndex = 4
        '
        'grpSeries
        '
        Me.grpSeries.Controls.Add(Me.chkSerieAboProcess)
        Me.grpSeries.Controls.Add(Me.txtSerieNbr)
        Me.grpSeries.Controls.Add(Me.lblSerieNbr)
        Me.grpSeries.Controls.Add(Me.cmbSerie)
        Me.grpSeries.Controls.Add(Me.lblSeries)
        Me.grpSeries.Location = New System.Drawing.Point(456, 72)
        Me.grpSeries.Name = "grpSeries"
        Me.grpSeries.Size = New System.Drawing.Size(264, 96)
        Me.grpSeries.TabIndex = 1
        Me.grpSeries.Text = "Series Info"
        '
        'chkSerieAboProcess
        '
        Me.chkSerieAboProcess.Location = New System.Drawing.Point(8, 72)
        Me.chkSerieAboProcess.Name = "chkSerieAboProcess"
        '
        'chkSerieAboProcess.Properties
        '
        Me.chkSerieAboProcess.Properties.Caption = "Serie for ABO Process"
        Me.chkSerieAboProcess.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkSerieAboProcess.Size = New System.Drawing.Size(184, 19)
        Me.chkSerieAboProcess.TabIndex = 31
        '
        'txtSerieNbr
        '
        Me.txtSerieNbr.Location = New System.Drawing.Point(96, 48)
        Me.txtSerieNbr.Name = "txtSerieNbr"
        Me.txtSerieNbr.TabIndex = 30
        '
        'lblSerieNbr
        '
        Me.lblSerieNbr.Location = New System.Drawing.Point(8, 48)
        Me.lblSerieNbr.Name = "lblSerieNbr"
        Me.lblSerieNbr.Size = New System.Drawing.Size(88, 20)
        Me.lblSerieNbr.TabIndex = 29
        Me.lblSerieNbr.Text = "Serie Nbr"
        '
        'cmbSerie
        '
        Me.cmbSerie.Location = New System.Drawing.Point(96, 24)
        Me.cmbSerie.Name = "cmbSerie"
        '
        'cmbSerie.Properties
        '
        Me.cmbSerie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSerie.Properties.NullText = ""
        Me.cmbSerie.Size = New System.Drawing.Size(160, 20)
        Me.cmbSerie.TabIndex = 28
        '
        'lblSeries
        '
        Me.lblSeries.Location = New System.Drawing.Point(8, 24)
        Me.lblSeries.Name = "lblSeries"
        Me.lblSeries.Size = New System.Drawing.Size(88, 20)
        Me.lblSeries.TabIndex = 12
        Me.lblSeries.Text = "Serie"
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.cmbStatus)
        Me.grpMain.Controls.Add(Me.lblStatus)
        Me.grpMain.Controls.Add(Me.cmbDirector)
        Me.grpMain.Controls.Add(Me.lblDirector)
        Me.grpMain.Controls.Add(Me.cmbRating)
        Me.grpMain.Controls.Add(Me.lblRating)
        Me.grpMain.Controls.Add(Me.cmbPictureFormat)
        Me.grpMain.Controls.Add(Me.lblPictureFormat)
        Me.grpMain.Controls.Add(Me.txtPublic)
        Me.grpMain.Controls.Add(Me.lblPublic)
        Me.grpMain.Controls.Add(Me.cmbStudio)
        Me.grpMain.Controls.Add(Me.lblStudio)
        Me.grpMain.Controls.Add(Me.cmbCountry)
        Me.grpMain.Controls.Add(Me.lblCountry)
        Me.grpMain.Controls.Add(Me.txtRunTime)
        Me.grpMain.Controls.Add(Me.lblRunTime)
        Me.grpMain.Controls.Add(Me.txtYear)
        Me.grpMain.Controls.Add(Me.lblYear)
        Me.grpMain.Controls.Add(Me.txtDateAvailable)
        Me.grpMain.Controls.Add(Me.LabelControl2)
        Me.grpMain.Controls.Add(Me.txtDateAdded)
        Me.grpMain.Controls.Add(Me.lblDateAdded)
        Me.grpMain.Controls.Add(Me.txtQtyNow)
        Me.grpMain.Controls.Add(Me.lblQtyNow)
        Me.grpMain.Controls.Add(Me.txtQty)
        Me.grpMain.Controls.Add(Me.LabelControl1)
        Me.grpMain.Controls.Add(Me.txtTitle)
        Me.grpMain.Controls.Add(Me.lblTitle)
        Me.grpMain.Controls.Add(Me.txtModel)
        Me.grpMain.Controls.Add(Me.lblModel)
        Me.grpMain.Controls.Add(Me.txtProductID)
        Me.grpMain.Controls.Add(Me.lblProductID)
        Me.grpMain.Location = New System.Drawing.Point(8, 72)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(440, 304)
        Me.grpMain.TabIndex = 0
        Me.grpMain.Text = "General Info"
        '
        'cmbStatus
        '
        Me.cmbStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_status"))
        Me.cmbStatus.Enabled = False
        Me.cmbStatus.Location = New System.Drawing.Point(328, 24)
        Me.cmbStatus.Name = "cmbStatus"
        '
        'cmbStatus.Properties
        '
        Me.cmbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStatus.Properties.NullText = ""
        Me.cmbStatus.Size = New System.Drawing.Size(104, 20)
        Me.cmbStatus.TabIndex = 31
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(240, 24)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(88, 20)
        Me.lblStatus.TabIndex = 30
        Me.lblStatus.Text = "Status"
        '
        'cmbDirector
        '
        Me.cmbDirector.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_directors_id"))
        Me.cmbDirector.Enabled = False
        Me.cmbDirector.Location = New System.Drawing.Point(328, 216)
        Me.cmbDirector.Name = "cmbDirector"
        '
        'cmbDirector.Properties
        '
        Me.cmbDirector.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDirector.Properties.DataSource = Me.objDS.directors
        Me.cmbDirector.Properties.DisplayMember = "directors_name"
        Me.cmbDirector.Properties.NullText = ""
        Me.cmbDirector.Properties.ValueMember = "directors_id"
        Me.cmbDirector.Size = New System.Drawing.Size(104, 20)
        Me.cmbDirector.TabIndex = 29
        '
        'lblDirector
        '
        Me.lblDirector.Location = New System.Drawing.Point(240, 216)
        Me.lblDirector.Name = "lblDirector"
        Me.lblDirector.Size = New System.Drawing.Size(88, 20)
        Me.lblDirector.TabIndex = 28
        Me.lblDirector.Text = "Director"
        '
        'cmbRating
        '
        Me.cmbRating.Enabled = False
        Me.cmbRating.Location = New System.Drawing.Point(104, 216)
        Me.cmbRating.Name = "cmbRating"
        '
        'cmbRating.Properties
        '
        Me.cmbRating.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRating.Properties.NullText = ""
        Me.cmbRating.TabIndex = 27
        '
        'lblRating
        '
        Me.lblRating.Location = New System.Drawing.Point(16, 216)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(88, 20)
        Me.lblRating.TabIndex = 26
        Me.lblRating.Text = "Rating"
        '
        'cmbPictureFormat
        '
        Me.cmbPictureFormat.Enabled = False
        Me.cmbPictureFormat.Location = New System.Drawing.Point(328, 192)
        Me.cmbPictureFormat.Name = "cmbPictureFormat"
        '
        'cmbPictureFormat.Properties
        '
        Me.cmbPictureFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPictureFormat.Properties.NullText = ""
        Me.cmbPictureFormat.Size = New System.Drawing.Size(104, 20)
        Me.cmbPictureFormat.TabIndex = 25
        '
        'lblPictureFormat
        '
        Me.lblPictureFormat.Location = New System.Drawing.Point(240, 192)
        Me.lblPictureFormat.Name = "lblPictureFormat"
        Me.lblPictureFormat.Size = New System.Drawing.Size(88, 20)
        Me.lblPictureFormat.TabIndex = 24
        Me.lblPictureFormat.Text = "Picture Format"
        '
        'txtPublic
        '
        Me.txtPublic.Enabled = False
        Me.txtPublic.Location = New System.Drawing.Point(104, 192)
        Me.txtPublic.Name = "txtPublic"
        '
        'txtPublic.Properties
        '
        Me.txtPublic.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPublic.Properties.NullText = ""
        Me.txtPublic.TabIndex = 23
        '
        'lblPublic
        '
        Me.lblPublic.Location = New System.Drawing.Point(16, 192)
        Me.lblPublic.Name = "lblPublic"
        Me.lblPublic.Size = New System.Drawing.Size(88, 20)
        Me.lblPublic.TabIndex = 22
        Me.lblPublic.Text = "Public"
        '
        'cmbStudio
        '
        Me.cmbStudio.Enabled = False
        Me.cmbStudio.Location = New System.Drawing.Point(328, 168)
        Me.cmbStudio.Name = "cmbStudio"
        '
        'cmbStudio.Properties
        '
        Me.cmbStudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStudio.Properties.NullText = ""
        Me.cmbStudio.Size = New System.Drawing.Size(104, 20)
        Me.cmbStudio.TabIndex = 21
        '
        'lblStudio
        '
        Me.lblStudio.Location = New System.Drawing.Point(240, 168)
        Me.lblStudio.Name = "lblStudio"
        Me.lblStudio.Size = New System.Drawing.Size(88, 20)
        Me.lblStudio.TabIndex = 20
        Me.lblStudio.Text = "Studio"
        '
        'cmbCountry
        '
        Me.cmbCountry.Enabled = False
        Me.cmbCountry.Location = New System.Drawing.Point(104, 168)
        Me.cmbCountry.Name = "cmbCountry"
        '
        'cmbCountry.Properties
        '
        Me.cmbCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCountry.Properties.NullText = ""
        Me.cmbCountry.TabIndex = 19
        '
        'lblCountry
        '
        Me.lblCountry.Location = New System.Drawing.Point(16, 168)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(88, 20)
        Me.lblCountry.TabIndex = 18
        Me.lblCountry.Text = "Country"
        '
        'txtRunTime
        '
        Me.txtRunTime.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_runtime"))
        Me.txtRunTime.Enabled = False
        Me.txtRunTime.Location = New System.Drawing.Point(328, 144)
        Me.txtRunTime.Name = "txtRunTime"
        Me.txtRunTime.Size = New System.Drawing.Size(104, 20)
        Me.txtRunTime.TabIndex = 17
        '
        'lblRunTime
        '
        Me.lblRunTime.Location = New System.Drawing.Point(240, 144)
        Me.lblRunTime.Name = "lblRunTime"
        Me.lblRunTime.Size = New System.Drawing.Size(88, 20)
        Me.lblRunTime.TabIndex = 16
        Me.lblRunTime.Text = "Run Time"
        '
        'txtYear
        '
        Me.txtYear.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_year"))
        Me.txtYear.Enabled = False
        Me.txtYear.Location = New System.Drawing.Point(104, 144)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.TabIndex = 15
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(16, 144)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(88, 20)
        Me.lblYear.TabIndex = 14
        Me.lblYear.Text = "Year"
        '
        'txtDateAvailable
        '
        Me.txtDateAvailable.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_date_available"))
        Me.txtDateAvailable.EditValue = Nothing
        Me.txtDateAvailable.Enabled = False
        Me.txtDateAvailable.Location = New System.Drawing.Point(328, 120)
        Me.txtDateAvailable.Name = "txtDateAvailable"
        '
        'txtDateAvailable.Properties
        '
        Me.txtDateAvailable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateAvailable.Size = New System.Drawing.Size(104, 20)
        Me.txtDateAvailable.TabIndex = 13
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(240, 120)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(88, 20)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "Date Available"
        '
        'txtDateAdded
        '
        Me.txtDateAdded.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_date_added"))
        Me.txtDateAdded.EditValue = Nothing
        Me.txtDateAdded.Enabled = False
        Me.txtDateAdded.Location = New System.Drawing.Point(104, 120)
        Me.txtDateAdded.Name = "txtDateAdded"
        '
        'txtDateAdded.Properties
        '
        Me.txtDateAdded.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateAdded.TabIndex = 11
        '
        'lblDateAdded
        '
        Me.lblDateAdded.Location = New System.Drawing.Point(16, 120)
        Me.lblDateAdded.Name = "lblDateAdded"
        Me.lblDateAdded.Size = New System.Drawing.Size(88, 20)
        Me.lblDateAdded.TabIndex = 10
        Me.lblDateAdded.Text = "Date Added"
        '
        'txtQtyNow
        '
        Me.txtQtyNow.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_quantity"))
        Me.txtQtyNow.Enabled = False
        Me.txtQtyNow.Location = New System.Drawing.Point(328, 96)
        Me.txtQtyNow.Name = "txtQtyNow"
        Me.txtQtyNow.Size = New System.Drawing.Size(104, 20)
        Me.txtQtyNow.TabIndex = 9
        '
        'lblQtyNow
        '
        Me.lblQtyNow.Location = New System.Drawing.Point(240, 96)
        Me.lblQtyNow.Name = "lblQtyNow"
        Me.lblQtyNow.Size = New System.Drawing.Size(88, 20)
        Me.lblQtyNow.TabIndex = 8
        Me.lblQtyNow.Text = "Qty Now"
        '
        'txtQty
        '
        Me.txtQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_dvd_quantity"))
        Me.txtQty.Enabled = False
        Me.txtQty.Location = New System.Drawing.Point(104, 96)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 96)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(88, 20)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Qty"
        '
        'txtTitle
        '
        Me.txtTitle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_title"))
        Me.txtTitle.Enabled = False
        Me.txtTitle.Location = New System.Drawing.Point(104, 72)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(328, 20)
        Me.txtTitle.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(16, 72)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(88, 20)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Title"
        '
        'txtModel
        '
        Me.txtModel.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_model"))
        Me.txtModel.Enabled = False
        Me.txtModel.Location = New System.Drawing.Point(104, 48)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(328, 20)
        Me.txtModel.TabIndex = 3
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(16, 48)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(88, 20)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Model"
        '
        'txtProductID
        '
        Me.txtProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_id"))
        Me.txtProductID.Enabled = False
        Me.txtProductID.Location = New System.Drawing.Point(104, 24)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.TabIndex = 1
        '
        'lblProductID
        '
        Me.lblProductID.Location = New System.Drawing.Point(16, 24)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(88, 20)
        Me.lblProductID.TabIndex = 0
        Me.lblProductID.Text = "Product ID"
        '
        'tabFR
        '
        Me.tabFR.Name = "tabFR"
        Me.tabFR.Size = New System.Drawing.Size(1047, 358)
        Me.tabFR.Text = "FR"
        '
        'tabNL
        '
        Me.tabNL.Name = "tabNL"
        Me.tabNL.Size = New System.Drawing.Size(1047, 358)
        Me.tabNL.Text = "NL"
        '
        'tabEN
        '
        Me.tabEN.Name = "tabEN"
        Me.tabEN.Size = New System.Drawing.Size(1047, 358)
        Me.tabEN.Text = "EN"
        '
        'tabTheme
        '
        Me.tabTheme.Name = "tabTheme"
        Me.tabTheme.Size = New System.Drawing.Size(1047, 358)
        Me.tabTheme.Text = "Themes and Categories"
        '
        'tabLanguages
        '
        Me.tabLanguages.Name = "tabLanguages"
        Me.tabLanguages.Size = New System.Drawing.Size(1047, 358)
        Me.tabLanguages.Text = "Languages"
        '
        'tabDVDs
        '
        Me.tabDVDs.Name = "tabDVDs"
        Me.tabDVDs.Size = New System.Drawing.Size(1047, 358)
        Me.tabDVDs.Text = "DVDs"
        '
        'frmDVD_Maint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1056, 446)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmDVD_Maint"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabSearch.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcustomers_id_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.grpActors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpActors.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grpImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpImage.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSeries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSeries.ResumeLayout(False)
        CType(Me.chkSerieAboProcess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieNbr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDirector.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPictureFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPublic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRunTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateAvailable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateAdded.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtyNow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sSQL As String

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim _objProductDVD As clsProduct_DVD
    Dim KeyDataSet As String = "BizzLib.dsGeneral" 'The Dataset used 
    Dim CurrentProductID As Integer
    Dim CurrentDVDID As Integer
    Dim MainData As clsProduct_DVD

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _Row As DataRow
        Try
            'SetUp of Variables
            KeyFieldName = "products_id"
            IDField = "products_id"
            TableName = "products"
            MainDataSet = objDS
            MyBase.RaiseEventForReportDesigner = True
            HelpProvider1.HelpNamespace = ".\Help\" & SessionInfo.UserLang & "\BizzKeys.chm"
            'Attempt to load the dataset.
            Me.LoadBKComboSet()
            BKGlobal.LoadAssociatedMenu(Me.Tag, PopMenuAssociatedTasks, Me)
            btnNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            DefaultSet_Bar.Visible = False
            Filter_Bar.Visible = False
            Misc_Bar2.Visible = False
            'If OpenType = "NEW" Then
            '    'NewRecord(sender, e)
            'End If
            'If OpenType = "EDIT" Then
            '    If KeyValue <> "" Then 'Not IsNothing(_Row) Then
            '        Dim _View As New DataView(Me.objDS.Tables(TableName), "", IDField, DataViewRowState.CurrentRows)
            '        Dim _Name As String = _View(_View.Find(New Object() {KeyValue})).Item(KeyFieldName)
            '        'Now Finding the record by the name, because this is the one used in the ORDER BY in the LoadDataset
            '        Me.objDS.Tables(TableName).DefaultView.Sort = KeyFieldName
            '        Me.BindingContext(objDS, TableName).Position = Me.objDS.Tables(TableName).DefaultView.Find(New Object() {_Name})
            '        'EditRecord(sender, e)
            '    Else
            '        OpenType = "BROWSE"
            '        Exit Sub
            '    End If
            'End If
            XtraTabControl1.SelectedTabPage = tabSearch


        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
    End Sub
    Private Sub EditRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuEdit.Click, MyBase.EventEditRecord
        If Me.BindingContext(objDS, TableName).Position < 0 Then
            Exit Sub
        End If
        SetState(EditState)
        PopMenuNew.Enabled = False
        PopMenuEdit.Enabled = False
        PopMenuSave.Enabled = True
        PopMenuDelete.Enabled = False
        PopMenuUndo.Enabled = True
        EnablingForEdit()
        OpenType = "EDIT"
    End Sub
    Private Sub UndoChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuUndo.Click, MyBase.EventUndoChanges
        SetState(BrowseState)
        PopMenuNew.Enabled = True
        PopMenuEdit.Enabled = True
        PopMenuSave.Enabled = False
        PopMenuDelete.Enabled = True
        PopMenuUndo.Enabled = False
        EnablingAll(False)
        Me.BindingContext(objDS, TableName).CancelCurrentEdit()
        'PositionChanged(Sender, e)
        LoadProductsInfo()
        OpenType = "BROWSE"
    End Sub
    Private Sub SaveChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuSave.Click, MyBase.EventSaveChanges
        Dim _ID As Integer
        Try
            'Validate Fields and assign any Necessary ID
            MainData.ValidateRecordFields(CType(Me.BindingContext(objDS, TableName).Current, DataRowView))
            'Attempt to update the datasource.
            Me.UpdateDataSet()
            SetState(BrowseState)
            PopMenuNew.Enabled = True
            PopMenuEdit.Enabled = True
            PopMenuSave.Enabled = False
            PopMenuDelete.Enabled = True
            PopMenuUndo.Enabled = False
            EnablingAll(False)
            OpenType = "BROWSE"
        Catch eUpdate As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        Finally
        End Try
        'PositionChanged(Sender, e)
    End Sub
    Public Sub UpdateDataSet() Handles MyBase.EventUpdateDataset
        'Stop any current edits.
        Me.BindingContext(objDS, TableName).EndCurrentEdit()
        Me.BindingContext(objDS, "address_book_default").EndCurrentEdit()
        MainData.Save()
        'MainData.AddrData.Rows(0).Item("EntityID") = CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item(IDField)
        'MainData.AddrData.Rows(0).Item("Name") = CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item("Name")
        'MainData.AddrData.Rows(0).Item("Description") = CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item("Description")
        'MainData.SaveOnlyAddr()
    End Sub
    Public Sub LoadBKComboSet()
        Try
            BKGlobal.Cls1.FillDataSet(objDS.Tables("languages"), "SELECT * FROM languages")
            BKGlobal.Cls1.FillDataSet(objDS.Tables("directors"), "SELECT * FROM directors")
            BKGlobal.Cls1.FillDataSet(objDS.Tables("series"), "SELECT * FROM series")
            'BKGlobal.Cls1.FillDataSet(objDS.Tables("products_status"), "SELECT * FROM products_status")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub LoadProductsInfo()
        objDS.Tables("products").Clear()
        MainData = New clsProduct_DVD(SessionInfo, objDS, CurrentProductID, 0)
    End Sub
    Private Sub EnablingEditFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingEditFields
        txtModel.EditValue = Enabling
        txtTitle.Enabled = Enabling
        txtQty.Enabled = Enabling
        txtQtyNow.Enabled = Enabling
        txtDateAdded.Enabled = Enabling
        txtDateAvailable.Enabled = Enabling
    End Sub
    Private Sub EnablingKeyFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingkeyFields
        'ToBeChecked ***
    End Sub
    Private Sub StartPrintForm() Handles MyBase.EventPrintForm
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            'Find EntityView1Row
            Dim _SQLTxt As String = "SELECT * FROM GeneralEntityView1 WHERE EntityID = " & CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item("EntityID")
            Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)
            objDS.Tables("GeneralEntityView1").Clear()
            _Cls1.FillDataSet(objDS.Tables("GeneralEntityView1"), _SQLTxt)
            If objDS.Tables("GeneralEntityView1").Rows.Count = 1 Then
                BKReport.PrintForm(CurrentReportID, New DataRow() { _
                    objDS.Tables("GeneralEntityView1").Rows(0), _
                    CType(Me.BindingContext(objDS, "GeneralAddress").Current, DataRowView).Row})
            End If
        End If
    End Sub
    Private Sub StartDesignReport() Handles MyBase.EventDesignReport
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            'Find EntityView1Row
            Dim _SQLTxt As String = "SELECT * FROM GeneralEntityView1 WHERE EntityID = " & CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item("EntityID")
            Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)
            objDS.Tables("GeneralEntityView1").Clear()
            _Cls1.FillDataSet(objDS.Tables("GeneralEntityView1"), _SQLTxt)
            If objDS.Tables("GeneralEntityView1").Rows.Count = 1 Then
                BKReport.DesignReport(CurrentReportID, New DataRow() { _
                    objDS.Tables("GeneralEntityView1").Rows(0), _
                    CType(Me.BindingContext(objDS, "GeneralAddress").Current, DataRowView).Row})
            End If
        End If
    End Sub

#Region "Naviagtion / Search"
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim _SQLTxt As String
        _SQLTxt = "SELECT PD.products_id, PD.language_id, PD.products_name , P.products_model as products_model FROM products_description PD " & _
                                " Left join products P on P.products_id = PD.products_id " & _
                                " where products_name like '%" & txtTitleSearch.EditValue & "%'  "
        objDS.Tables("products_description1").Clear()
        BKGlobal.Cls1.FillDataSet(objDS.Tables("products_description1"), _SQLTxt)
    End Sub
    Private Sub GridViewSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridViewSearch.DoubleClick
        CurrentProductID = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle).Item("products_id")
        LoadProductsInfo()
        XtraTabControl1.SelectedTabPage = tabMain
    End Sub
    Public Overrides Sub btnQuickSearch_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuickSearch.ItemClick
        If IsNumeric(txtQuickSearch.EditValue) Then
            CurrentProductID = txtQuickSearch.EditValue
            LoadProductsInfo()
            XtraTabControl1.SelectedTabPage = tabMain
        End If
    End Sub
    Public Overloads Sub btnPrevious_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrevious.ItemClick
        CurrentProductID -= 1
        LoadProductsInfo()
    End Sub
    Public Overloads Sub btnNext_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNext.ItemClick
        CurrentProductID += 1
        LoadProductsInfo()
    End Sub
    Public Overloads Sub btnFirst_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFirst.ItemClick
        CurrentProductID = 0
        LoadProductsInfo()
    End Sub
    Public Overloads Sub btnLast_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLast.ItemClick
        CurrentProductID = BKGlobal.ExecuteFindFieldValueINT("products_id", "select products_id from products order by products_id desc limit 1")
        LoadProductsInfo()
    End Sub
#End Region
    Private Sub btnRemoveDVD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveDVD.Click
        MainData.RemoveDVDFromCatalogue()
    End Sub

End Class
