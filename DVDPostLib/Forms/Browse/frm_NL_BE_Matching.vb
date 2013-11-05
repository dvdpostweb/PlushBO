Public Class frm_NL_BE_Matching
    Inherits BizzLib.frmGeneral_BrowseMaint

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
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents objDS As DVDPostLib.dsProducts
    Friend WithEvents colproducts_id_nl As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_type As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_model As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_image As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_id_be As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents collanguages As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colsubtitles As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbProductsBE As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tmpDS As DVDPostLib.dsPur_Sls
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_NL_BE_Matching))
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.objDS = New DVDPostLib.dsProducts
        Me.GridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colproducts_id_nl = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_type = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_model = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_image = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.collanguages = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colsubtitles = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_id_be = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbProductsBE = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tmpDS = New DVDPostLib.dsPur_Sls
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductsBE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tmpDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Grid1)
        Me.Panel1.Name = "Panel1"
        '
        'StatusBar1
        '
        Me.StatusBar1.Name = "StatusBar1"
        '
        'BaseGrid1
        '
        '
        'BaseGrid1.EmbeddedNavigator
        '
        Me.BaseGrid1.EmbeddedNavigator.AccessibleDescription = resources.GetString("BaseGrid1.EmbeddedNavigator.AccessibleDescription")
        Me.BaseGrid1.EmbeddedNavigator.AccessibleName = resources.GetString("BaseGrid1.EmbeddedNavigator.AccessibleName")
        Me.BaseGrid1.EmbeddedNavigator.Anchor = CType(resources.GetObject("BaseGrid1.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.BaseGrid1.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("BaseGrid1.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.BaseGrid1.EmbeddedNavigator.Enabled = CType(resources.GetObject("BaseGrid1.EmbeddedNavigator.Enabled"), Boolean)
        Me.BaseGrid1.EmbeddedNavigator.ImeMode = CType(resources.GetObject("BaseGrid1.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.BaseGrid1.EmbeddedNavigator.Name = ""
        Me.BaseGrid1.EmbeddedNavigator.SuperTip = CType(resources.GetObject("BaseGrid1.EmbeddedNavigator.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.BaseGrid1.EmbeddedNavigator.Text = resources.GetString("BaseGrid1.EmbeddedNavigator.Text")
        Me.BaseGrid1.EmbeddedNavigator.TextLocation = CType(resources.GetObject("BaseGrid1.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.BaseGrid1.EmbeddedNavigator.TextStringFormat = resources.GetString("BaseGrid1.EmbeddedNavigator.TextStringFormat")
        Me.BaseGrid1.EmbeddedNavigator.ToolTip = resources.GetString("BaseGrid1.EmbeddedNavigator.ToolTip")
        Me.BaseGrid1.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("BaseGrid1.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.BaseGrid1.EmbeddedNavigator.ToolTipTitle = resources.GetString("BaseGrid1.EmbeddedNavigator.ToolTipTitle")
        Me.BaseGrid1.MainView = Me.GridView2
        Me.BaseGrid1.Name = "BaseGrid1"
        Me.BaseGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'cmbFilterListRepos
        '
        Me.cmbFilterListRepos.Mask.AutoComplete = CType(resources.GetObject("cmbFilterListRepos.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.cmbFilterListRepos.Mask.BeepOnError = CType(resources.GetObject("cmbFilterListRepos.Mask.BeepOnError"), Boolean)
        Me.cmbFilterListRepos.Mask.EditMask = resources.GetString("cmbFilterListRepos.Mask.EditMask")
        Me.cmbFilterListRepos.Mask.IgnoreMaskBlank = CType(resources.GetObject("cmbFilterListRepos.Mask.IgnoreMaskBlank"), Boolean)
        Me.cmbFilterListRepos.Mask.MaskType = CType(resources.GetObject("cmbFilterListRepos.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.cmbFilterListRepos.Mask.PlaceHolder = CType(resources.GetObject("cmbFilterListRepos.Mask.PlaceHolder"), Char)
        Me.cmbFilterListRepos.Mask.SaveLiteral = CType(resources.GetObject("cmbFilterListRepos.Mask.SaveLiteral"), Boolean)
        Me.cmbFilterListRepos.Mask.ShowPlaceHolders = CType(resources.GetObject("cmbFilterListRepos.Mask.ShowPlaceHolders"), Boolean)
        Me.cmbFilterListRepos.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("cmbFilterListRepos.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'cmbDefaultListRepos
        '
        Me.cmbDefaultListRepos.Mask.AutoComplete = CType(resources.GetObject("cmbDefaultListRepos.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.cmbDefaultListRepos.Mask.BeepOnError = CType(resources.GetObject("cmbDefaultListRepos.Mask.BeepOnError"), Boolean)
        Me.cmbDefaultListRepos.Mask.EditMask = resources.GetString("cmbDefaultListRepos.Mask.EditMask")
        Me.cmbDefaultListRepos.Mask.IgnoreMaskBlank = CType(resources.GetObject("cmbDefaultListRepos.Mask.IgnoreMaskBlank"), Boolean)
        Me.cmbDefaultListRepos.Mask.MaskType = CType(resources.GetObject("cmbDefaultListRepos.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.cmbDefaultListRepos.Mask.PlaceHolder = CType(resources.GetObject("cmbDefaultListRepos.Mask.PlaceHolder"), Char)
        Me.cmbDefaultListRepos.Mask.SaveLiteral = CType(resources.GetObject("cmbDefaultListRepos.Mask.SaveLiteral"), Boolean)
        Me.cmbDefaultListRepos.Mask.ShowPlaceHolders = CType(resources.GetObject("cmbDefaultListRepos.Mask.ShowPlaceHolders"), Boolean)
        Me.cmbDefaultListRepos.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("cmbDefaultListRepos.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'cmbReportListRepos
        '
        Me.cmbReportListRepos.Mask.AutoComplete = CType(resources.GetObject("cmbReportListRepos.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.cmbReportListRepos.Mask.BeepOnError = CType(resources.GetObject("cmbReportListRepos.Mask.BeepOnError"), Boolean)
        Me.cmbReportListRepos.Mask.EditMask = resources.GetString("cmbReportListRepos.Mask.EditMask")
        Me.cmbReportListRepos.Mask.IgnoreMaskBlank = CType(resources.GetObject("cmbReportListRepos.Mask.IgnoreMaskBlank"), Boolean)
        Me.cmbReportListRepos.Mask.MaskType = CType(resources.GetObject("cmbReportListRepos.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.cmbReportListRepos.Mask.PlaceHolder = CType(resources.GetObject("cmbReportListRepos.Mask.PlaceHolder"), Char)
        Me.cmbReportListRepos.Mask.SaveLiteral = CType(resources.GetObject("cmbReportListRepos.Mask.SaveLiteral"), Boolean)
        Me.cmbReportListRepos.Mask.ShowPlaceHolders = CType(resources.GetObject("cmbReportListRepos.Mask.ShowPlaceHolders"), Boolean)
        Me.cmbReportListRepos.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("cmbReportListRepos.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'txtQuickSearchRepos
        '
        Me.txtQuickSearchRepos.Mask.AutoComplete = CType(resources.GetObject("txtQuickSearchRepos.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtQuickSearchRepos.Mask.BeepOnError = CType(resources.GetObject("txtQuickSearchRepos.Mask.BeepOnError"), Boolean)
        Me.txtQuickSearchRepos.Mask.EditMask = resources.GetString("txtQuickSearchRepos.Mask.EditMask")
        Me.txtQuickSearchRepos.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtQuickSearchRepos.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtQuickSearchRepos.Mask.MaskType = CType(resources.GetObject("txtQuickSearchRepos.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtQuickSearchRepos.Mask.PlaceHolder = CType(resources.GetObject("txtQuickSearchRepos.Mask.PlaceHolder"), Char)
        Me.txtQuickSearchRepos.Mask.SaveLiteral = CType(resources.GetObject("txtQuickSearchRepos.Mask.SaveLiteral"), Boolean)
        Me.txtQuickSearchRepos.Mask.ShowPlaceHolders = CType(resources.GetObject("txtQuickSearchRepos.Mask.ShowPlaceHolders"), Boolean)
        Me.txtQuickSearchRepos.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtQuickSearchRepos.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'Misc_Bar2
        '
        Me.Misc_Bar2.DockCol = 4
        '
        'Nav_Bar
        '
        Me.Nav_Bar.DockCol = 5
        '
        'cmbViewListRepos
        '
        Me.cmbViewListRepos.Mask.AutoComplete = CType(resources.GetObject("cmbViewListRepos.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.cmbViewListRepos.Mask.BeepOnError = CType(resources.GetObject("cmbViewListRepos.Mask.BeepOnError"), Boolean)
        Me.cmbViewListRepos.Mask.EditMask = resources.GetString("cmbViewListRepos.Mask.EditMask")
        Me.cmbViewListRepos.Mask.IgnoreMaskBlank = CType(resources.GetObject("cmbViewListRepos.Mask.IgnoreMaskBlank"), Boolean)
        Me.cmbViewListRepos.Mask.MaskType = CType(resources.GetObject("cmbViewListRepos.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.cmbViewListRepos.Mask.PlaceHolder = CType(resources.GetObject("cmbViewListRepos.Mask.PlaceHolder"), Char)
        Me.cmbViewListRepos.Mask.SaveLiteral = CType(resources.GetObject("cmbViewListRepos.Mask.SaveLiteral"), Boolean)
        Me.cmbViewListRepos.Mask.ShowPlaceHolders = CType(resources.GetObject("cmbViewListRepos.Mask.ShowPlaceHolders"), Boolean)
        Me.cmbViewListRepos.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("cmbViewListRepos.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'Grid1
        '
        Me.Grid1.AccessibleDescription = resources.GetString("Grid1.AccessibleDescription")
        Me.Grid1.AccessibleName = resources.GetString("Grid1.AccessibleName")
        Me.Grid1.Anchor = CType(resources.GetObject("Grid1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Grid1.BackgroundImage = CType(resources.GetObject("Grid1.BackgroundImage"), System.Drawing.Image)
        Me.Grid1.DataMember = resources.GetString("Grid1.DataMember")
        Me.Grid1.DataSource = Me.objDS.tmp_products_nl
        Me.Grid1.Dock = CType(resources.GetObject("Grid1.Dock"), System.Windows.Forms.DockStyle)
        '
        'Grid1.EmbeddedNavigator
        '
        Me.Grid1.EmbeddedNavigator.AccessibleDescription = resources.GetString("Grid1.EmbeddedNavigator.AccessibleDescription")
        Me.Grid1.EmbeddedNavigator.AccessibleName = resources.GetString("Grid1.EmbeddedNavigator.AccessibleName")
        Me.Grid1.EmbeddedNavigator.Anchor = CType(resources.GetObject("Grid1.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Grid1.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("Grid1.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.Grid1.EmbeddedNavigator.Enabled = CType(resources.GetObject("Grid1.EmbeddedNavigator.Enabled"), Boolean)
        Me.Grid1.EmbeddedNavigator.ImeMode = CType(resources.GetObject("Grid1.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.EmbeddedNavigator.SuperTip = CType(resources.GetObject("Grid1.EmbeddedNavigator.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.Grid1.EmbeddedNavigator.Text = resources.GetString("Grid1.EmbeddedNavigator.Text")
        Me.Grid1.EmbeddedNavigator.TextLocation = CType(resources.GetObject("Grid1.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.Grid1.EmbeddedNavigator.TextStringFormat = resources.GetString("Grid1.EmbeddedNavigator.TextStringFormat")
        Me.Grid1.EmbeddedNavigator.ToolTip = resources.GetString("Grid1.EmbeddedNavigator.ToolTip")
        Me.Grid1.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("Grid1.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.Grid1.EmbeddedNavigator.ToolTipTitle = resources.GetString("Grid1.EmbeddedNavigator.ToolTipTitle")
        Me.Grid1.Enabled = CType(resources.GetObject("Grid1.Enabled"), Boolean)
        Me.Grid1.Font = CType(resources.GetObject("Grid1.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.Grid1, resources.GetString("Grid1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.Grid1, CType(resources.GetObject("Grid1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.Grid1, resources.GetString("Grid1.HelpString"))
        Me.Grid1.ImeMode = CType(resources.GetObject("Grid1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Grid1.Location = CType(resources.GetObject("Grid1.Location"), System.Drawing.Point)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbProductsBE})
        Me.Grid1.RightToLeft = CType(resources.GetObject("Grid1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.Grid1, CType(resources.GetObject("Grid1.ShowHelp"), Boolean))
        Me.Grid1.Size = CType(resources.GetObject("Grid1.Size"), System.Drawing.Size)
        Me.Grid1.TabIndex = CType(resources.GetObject("Grid1.TabIndex"), Integer)
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.Grid1.Visible = CType(resources.GetObject("Grid1.Visible"), Boolean)
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsProducts"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GridView1
        '
        Me.GridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridView1.ChildGridLevelName = resources.GetString("GridView1.ChildGridLevelName")
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colproducts_id_nl, Me.colproducts_type, Me.colproducts_model, Me.colproducts_image, Me.colproducts_status, Me.colproducts_id_be, Me.collanguages, Me.colsubtitles})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(672, 333, 217, 222)
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.GroupFormat = resources.GetString("GridView1.GroupFormat")
        Me.GridView1.GroupPanelText = resources.GetString("GridView1.GroupPanelText")
        Me.GridView1.Name = "GridView1"
        Me.GridView1.NewItemRowText = resources.GetString("GridView1.NewItemRowText")
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowBands = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PreviewFieldName = resources.GetString("GridView1.PreviewFieldName")
        Me.GridView1.VertScrollTipFieldName = resources.GetString("GridView1.VertScrollTipFieldName")
        Me.GridView1.ViewCaption = resources.GetString("GridView1.ViewCaption")
        '
        'GridBand1
        '
        Me.GridBand1.AutoFillDown = CType(resources.GetObject("GridBand1.AutoFillDown"), Boolean)
        Me.GridBand1.Caption = resources.GetString("GridBand1.Caption")
        Me.GridBand1.Columns.Add(Me.colproducts_id_nl)
        Me.GridBand1.Columns.Add(Me.colproducts_type)
        Me.GridBand1.Columns.Add(Me.colproducts_model)
        Me.GridBand1.Columns.Add(Me.colproducts_image)
        Me.GridBand1.Columns.Add(Me.colproducts_status)
        Me.GridBand1.Columns.Add(Me.collanguages)
        Me.GridBand1.Columns.Add(Me.colsubtitles)
        Me.GridBand1.Columns.Add(Me.colproducts_id_be)
        Me.GridBand1.CustomizationCaption = resources.GetString("GridBand1.CustomizationCaption")
        Me.GridBand1.Fixed = CType(resources.GetObject("GridBand1.Fixed"), DevExpress.XtraGrid.Columns.FixedStyle)
        Me.GridBand1.ImageAlignment = CType(resources.GetObject("GridBand1.ImageAlignment"), System.Drawing.StringAlignment)
        Me.GridBand1.ImageIndex = CType(resources.GetObject("GridBand1.ImageIndex"), Integer)
        Me.GridBand1.MinWidth = CType(resources.GetObject("GridBand1.MinWidth"), Integer)
        Me.GridBand1.Name = resources.GetString("GridBand1.Name")
        Me.GridBand1.RowCount = CType(resources.GetObject("GridBand1.RowCount"), Integer)
        Me.GridBand1.ToolTip = resources.GetString("GridBand1.ToolTip")
        Me.GridBand1.Visible = CType(resources.GetObject("GridBand1.Visible"), Boolean)
        Me.GridBand1.Width = CType(resources.GetObject("GridBand1.Width"), Integer)
        '
        'colproducts_id_nl
        '
        Me.colproducts_id_nl.Caption = resources.GetString("colproducts_id_nl.Caption")
        Me.colproducts_id_nl.CustomizationCaption = resources.GetString("colproducts_id_nl.CustomizationCaption")
        Me.colproducts_id_nl.FieldName = "products_id_nl"
        Me.colproducts_id_nl.ImageAlignment = CType(resources.GetObject("colproducts_id_nl.ImageAlignment"), System.Drawing.StringAlignment)
        Me.colproducts_id_nl.ImageIndex = CType(resources.GetObject("colproducts_id_nl.ImageIndex"), Integer)
        Me.colproducts_id_nl.Name = "colproducts_id_nl"
        Me.colproducts_id_nl.OptionsColumn.ReadOnly = True
        Me.colproducts_id_nl.ToolTip = resources.GetString("colproducts_id_nl.ToolTip")
        Me.colproducts_id_nl.Visible = CType(resources.GetObject("colproducts_id_nl.Visible"), Boolean)
        Me.colproducts_id_nl.Width = CType(resources.GetObject("colproducts_id_nl.Width"), Integer)
        '
        'colproducts_type
        '
        Me.colproducts_type.Caption = resources.GetString("colproducts_type.Caption")
        Me.colproducts_type.CustomizationCaption = resources.GetString("colproducts_type.CustomizationCaption")
        Me.colproducts_type.FieldName = "products_type"
        Me.colproducts_type.ImageAlignment = CType(resources.GetObject("colproducts_type.ImageAlignment"), System.Drawing.StringAlignment)
        Me.colproducts_type.ImageIndex = CType(resources.GetObject("colproducts_type.ImageIndex"), Integer)
        Me.colproducts_type.Name = "colproducts_type"
        Me.colproducts_type.OptionsColumn.ReadOnly = True
        Me.colproducts_type.ToolTip = resources.GetString("colproducts_type.ToolTip")
        Me.colproducts_type.Visible = CType(resources.GetObject("colproducts_type.Visible"), Boolean)
        Me.colproducts_type.Width = CType(resources.GetObject("colproducts_type.Width"), Integer)
        '
        'colproducts_model
        '
        Me.colproducts_model.Caption = resources.GetString("colproducts_model.Caption")
        Me.colproducts_model.CustomizationCaption = resources.GetString("colproducts_model.CustomizationCaption")
        Me.colproducts_model.FieldName = "products_model"
        Me.colproducts_model.ImageAlignment = CType(resources.GetObject("colproducts_model.ImageAlignment"), System.Drawing.StringAlignment)
        Me.colproducts_model.ImageIndex = CType(resources.GetObject("colproducts_model.ImageIndex"), Integer)
        Me.colproducts_model.Name = "colproducts_model"
        Me.colproducts_model.OptionsColumn.ReadOnly = True
        Me.colproducts_model.ToolTip = resources.GetString("colproducts_model.ToolTip")
        Me.colproducts_model.Visible = CType(resources.GetObject("colproducts_model.Visible"), Boolean)
        Me.colproducts_model.Width = CType(resources.GetObject("colproducts_model.Width"), Integer)
        '
        'colproducts_image
        '
        Me.colproducts_image.Caption = resources.GetString("colproducts_image.Caption")
        Me.colproducts_image.CustomizationCaption = resources.GetString("colproducts_image.CustomizationCaption")
        Me.colproducts_image.FieldName = "products_image"
        Me.colproducts_image.ImageAlignment = CType(resources.GetObject("colproducts_image.ImageAlignment"), System.Drawing.StringAlignment)
        Me.colproducts_image.ImageIndex = CType(resources.GetObject("colproducts_image.ImageIndex"), Integer)
        Me.colproducts_image.Name = "colproducts_image"
        Me.colproducts_image.OptionsColumn.ReadOnly = True
        Me.colproducts_image.ToolTip = resources.GetString("colproducts_image.ToolTip")
        Me.colproducts_image.Visible = CType(resources.GetObject("colproducts_image.Visible"), Boolean)
        Me.colproducts_image.Width = CType(resources.GetObject("colproducts_image.Width"), Integer)
        '
        'colproducts_status
        '
        Me.colproducts_status.Caption = resources.GetString("colproducts_status.Caption")
        Me.colproducts_status.CustomizationCaption = resources.GetString("colproducts_status.CustomizationCaption")
        Me.colproducts_status.FieldName = "products_status"
        Me.colproducts_status.ImageAlignment = CType(resources.GetObject("colproducts_status.ImageAlignment"), System.Drawing.StringAlignment)
        Me.colproducts_status.ImageIndex = CType(resources.GetObject("colproducts_status.ImageIndex"), Integer)
        Me.colproducts_status.Name = "colproducts_status"
        Me.colproducts_status.OptionsColumn.ReadOnly = True
        Me.colproducts_status.ToolTip = resources.GetString("colproducts_status.ToolTip")
        Me.colproducts_status.Visible = CType(resources.GetObject("colproducts_status.Visible"), Boolean)
        Me.colproducts_status.Width = CType(resources.GetObject("colproducts_status.Width"), Integer)
        '
        'collanguages
        '
        Me.collanguages.Caption = resources.GetString("collanguages.Caption")
        Me.collanguages.CustomizationCaption = resources.GetString("collanguages.CustomizationCaption")
        Me.collanguages.FieldName = "languages"
        Me.collanguages.ImageAlignment = CType(resources.GetObject("collanguages.ImageAlignment"), System.Drawing.StringAlignment)
        Me.collanguages.ImageIndex = CType(resources.GetObject("collanguages.ImageIndex"), Integer)
        Me.collanguages.Name = "collanguages"
        Me.collanguages.OptionsColumn.ReadOnly = True
        Me.collanguages.ToolTip = resources.GetString("collanguages.ToolTip")
        Me.collanguages.Visible = CType(resources.GetObject("collanguages.Visible"), Boolean)
        Me.collanguages.Width = CType(resources.GetObject("collanguages.Width"), Integer)
        '
        'colsubtitles
        '
        Me.colsubtitles.Caption = resources.GetString("colsubtitles.Caption")
        Me.colsubtitles.CustomizationCaption = resources.GetString("colsubtitles.CustomizationCaption")
        Me.colsubtitles.FieldName = "subtitles"
        Me.colsubtitles.ImageAlignment = CType(resources.GetObject("colsubtitles.ImageAlignment"), System.Drawing.StringAlignment)
        Me.colsubtitles.ImageIndex = CType(resources.GetObject("colsubtitles.ImageIndex"), Integer)
        Me.colsubtitles.Name = "colsubtitles"
        Me.colsubtitles.OptionsColumn.ReadOnly = True
        Me.colsubtitles.ToolTip = resources.GetString("colsubtitles.ToolTip")
        Me.colsubtitles.Visible = CType(resources.GetObject("colsubtitles.Visible"), Boolean)
        Me.colsubtitles.Width = CType(resources.GetObject("colsubtitles.Width"), Integer)
        '
        'colproducts_id_be
        '
        Me.colproducts_id_be.Caption = resources.GetString("colproducts_id_be.Caption")
        Me.colproducts_id_be.ColumnEdit = Me.cmbProductsBE
        Me.colproducts_id_be.CustomizationCaption = resources.GetString("colproducts_id_be.CustomizationCaption")
        Me.colproducts_id_be.FieldName = "products_id_be"
        Me.colproducts_id_be.ImageAlignment = CType(resources.GetObject("colproducts_id_be.ImageAlignment"), System.Drawing.StringAlignment)
        Me.colproducts_id_be.ImageIndex = CType(resources.GetObject("colproducts_id_be.ImageIndex"), Integer)
        Me.colproducts_id_be.Name = "colproducts_id_be"
        Me.colproducts_id_be.ToolTip = resources.GetString("colproducts_id_be.ToolTip")
        Me.colproducts_id_be.Visible = CType(resources.GetObject("colproducts_id_be.Visible"), Boolean)
        Me.colproducts_id_be.Width = CType(resources.GetObject("colproducts_id_be.Width"), Integer)
        '
        'cmbProductsBE
        '
        Me.cmbProductsBE.AccessibleDescription = resources.GetString("cmbProductsBE.AccessibleDescription")
        Me.cmbProductsBE.AccessibleName = resources.GetString("cmbProductsBE.AccessibleName")
        Me.cmbProductsBE.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        Me.cmbProductsBE.AutoHeight = CType(resources.GetObject("cmbProductsBE.AutoHeight"), Boolean)
        Me.cmbProductsBE.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.cmbProductsBE.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("product_id", "product_id", 70, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_model", "products_model", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_title", "products_title", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages", "languages", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubTitles", "SubTitles", 49, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_year", "products_year", 76, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_type", "products_type", 76, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbProductsBE.DataSource = Me.tmpDS.PS_Ana
        Me.cmbProductsBE.DisplayMember = "product_id"
        Me.cmbProductsBE.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch
        Me.cmbProductsBE.Mask.AutoComplete = CType(resources.GetObject("cmbProductsBE.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.cmbProductsBE.Mask.BeepOnError = CType(resources.GetObject("cmbProductsBE.Mask.BeepOnError"), Boolean)
        Me.cmbProductsBE.Mask.EditMask = resources.GetString("cmbProductsBE.Mask.EditMask")
        Me.cmbProductsBE.Mask.IgnoreMaskBlank = CType(resources.GetObject("cmbProductsBE.Mask.IgnoreMaskBlank"), Boolean)
        Me.cmbProductsBE.Mask.MaskType = CType(resources.GetObject("cmbProductsBE.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.cmbProductsBE.Mask.PlaceHolder = CType(resources.GetObject("cmbProductsBE.Mask.PlaceHolder"), Char)
        Me.cmbProductsBE.Mask.SaveLiteral = CType(resources.GetObject("cmbProductsBE.Mask.SaveLiteral"), Boolean)
        Me.cmbProductsBE.Mask.ShowPlaceHolders = CType(resources.GetObject("cmbProductsBE.Mask.ShowPlaceHolders"), Boolean)
        Me.cmbProductsBE.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("cmbProductsBE.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.cmbProductsBE.Name = "cmbProductsBE"
        Me.cmbProductsBE.NullText = resources.GetString("cmbProductsBE.NullText")
        Me.cmbProductsBE.PopupWidth = 300
        Me.cmbProductsBE.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbProductsBE.ValueMember = "product_id"
        '
        'tmpDS
        '
        Me.tmpDS.DataSetName = "dsPur_Sls"
        Me.tmpDS.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GridView2
        '
        Me.GridView2.ChildGridLevelName = resources.GetString("GridView2.ChildGridLevelName")
        Me.GridView2.GridControl = Me.BaseGrid1
        Me.GridView2.GroupFormat = resources.GetString("GridView2.GroupFormat")
        Me.GridView2.GroupPanelText = resources.GetString("GridView2.GroupPanelText")
        Me.GridView2.Name = "GridView2"
        Me.GridView2.NewItemRowText = resources.GetString("GridView2.NewItemRowText")
        Me.GridView2.PreviewFieldName = resources.GetString("GridView2.PreviewFieldName")
        Me.GridView2.VertScrollTipFieldName = resources.GetString("GridView2.VertScrollTipFieldName")
        Me.GridView2.ViewCaption = resources.GetString("GridView2.ViewCaption")
        '
        'frm_NL_BE_Matching
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me, resources.GetString("$this.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me, CType(resources.GetObject("$this.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me, resources.GetString("$this.HelpString"))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frm_NL_BE_Matching"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductsBE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tmpDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip


        TableName = "tmp_products_nl"
        IDField = "products_id_nl"
        NameField = "products_id_nl"
        SQLTxt1 = "SELECT * FROM " & TableName & " "
        ForCurrentEntityOnly = False
        If Not DesignMode Then
            MainDataSet = objDS
            'LoadBKComboSet()
            MyBase.frm_Load(sender, e)
            LoadDVDInfo()
            KeyDataSet = "dsStock" 'The Dataset used 
            BKGlobal.SetToolBar(BarManager1, Me.Tag, False, False, False, , False, False)
            Grid1.DataSource = objDS.Tables(TableName).DefaultView
            BaseGrid1 = Grid1
            BaseGridView1 = GridView1()
        End If
    End Sub
    Private Sub LoadDVDInfo()
        Dim _SQLTXt As String
        Dim _row As DataRow
        Dim _viewLang, _viewSubTitle As DataView
        Dim _row2 As DataRowView
        Dim _rowsSub() As DataRowView
        Dim _rowsLang() As DataRowView
        Me.StatusBar1.Text = "Please Wait - Loading DVD Info"
        tmpDS.Tables("PS_Ana").Clear()
        _SQLTXt = "SELECT P.Products_ID product_id, P.products_type products_type, P.products_model , P.imdb_id, P.products_studio, S.studio_name, P.feesharing, " & _
          " if (P.feesharing_end = '0000-00-00', Null, P.feesharing_end) as feesharing_end , products_title, " & _
          " if (products_date_available = '0000-00-00', Null, products_date_available) as products_date_available, P.products_status, P.cinebel_id, " & _
          " P.products_ordered, P.products_public, P.products_runtime, P.products_year, " & _
          " count(PDVD.`inout`) stock_in_qty , PDVD.products_dvd_status, PDVDS.products_dvd_status_name, P.products_series_number, " & _
          " P.products_sale_price, P.products_sale_date, P.quantity_to_sale, P.in_the_bags, P.in_the_bags_next, P.in_cinema_now " & _
          " FROM Products as P " & _
          " LEFT JOIN Products_DVD PDVD ON P.Products_ID = PDVD.Products_ID " & _
          " LEFT JOIN Studio S ON P.Products_Studio = S.Studio_Id " & _
          " LEFT JOIN products_dvd_status PDVDS on PDVDS.products_dvd_status_id = PDVD.products_dvd_status " & _
          " WHERE P.products_type <> 'ABO' " & _
          " GROUP BY P.Products_ID ORDER BY P.products_model  "
        tmpDS.Tables("PS_Ana").Columns("stock_cover_qty").DefaultValue = 0
        tmpDS.Tables("PS_Ana").Columns("stock_qty").DefaultValue = 0
        DvdPostData.clsConnection.FillDataSet(tmpDS.Tables("PS_Ana"), _SQLTXt)
        tmpDS.Tables("products_undertitles_View1").Clear()
        _SQLTXt = "SELECT p.products_id, undertitles_id, language_id, undertitles_description as description " & _
                  " FROM products_to_undertitles p left join products_undertitles u " & _
                  " on p.products_undertitles_id = u.undertitles_id WHERe u.language_id = 3"
        DvdPostData.clsConnection.FillDataSet(tmpDS.Tables("products_undertitles_View1"), _SQLTXt)
        _viewSubTitle = New DataView(tmpDS.Tables("products_undertitles_View1"), "", "Products_ID", DataViewRowState.CurrentRows)
        tmpDS.Tables("products_languages_View1").Clear()
        _SQLTXt = "SELECT p.products_id, languages_id, languagenav_id, languages_description as description " & _
                " FROM products_to_languages p " & _
                " left join products_languages l on p.products_languages_id = l.languages_id " & _
                " WHERe l.languagenav_id = 3 "
        DvdPostData.clsConnection.FillDataSet(tmpDS.Tables("products_languages_View1"), _SQLTXt)
        _viewLang = New DataView(tmpDS.Tables("products_languages_View1"), "", "Products_ID", DataViewRowState.CurrentRows)
        Me.StatusBar1.Text = "Please Wait - Loading Languages and SubTitles"
        For Each _row In tmpDS.Tables("PS_Ana").Rows
            '_row2 = _tmpDS.Tables("products_undertitles_View1").Rows.Find(New Object() {_row("Product_ID")})
            'Adding SubTitles Info
            '_view = New DataView(tmpDS.Tables("products_undertitles_View1"), "Products_Id = " & _row("Product_ID"), "", DataViewRowState.CurrentRows)
            _rowsSub = _viewSubTitle.FindRows(_row("Product_ID"))
            For Each _row2 In _rowsSub
                _row.BeginEdit()
                _row("SubTitles") += _row2("Description") + " , "
                _row.EndEdit()
            Next
            'Adding Languages Info
            '_view = New DataView(tmpDS.Tables("products_languages_View1"), "Products_Id = " & _row("Product_ID"), "", DataViewRowState.CurrentRows)
            _rowsLang = _viewLang.FindRows(_row("Product_ID"))
            For Each _row2 In _rowsLang
                _row.BeginEdit()
                _row("Languages") += _row2("Description") + " , "
                _row.EndEdit()
            Next
        Next
        Me.StatusBar1.Text = ""
    End Sub
    Private Sub cmbProductsBE_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbProductsBE.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Delete Then
            Dim _row As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Not IsNothing(_row) Then
                GridView1.SetFocusedValue(DBNull.Value)
            End If
        End If
    End Sub
End Class
