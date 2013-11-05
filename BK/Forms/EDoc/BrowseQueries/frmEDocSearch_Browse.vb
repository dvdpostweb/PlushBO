Public Class frmEDocSearch_Browse
    Inherits BizzLib.frmGeneral_Browse

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
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents cmbCategory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents lblPath As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents cmbType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents colOperator As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colKeyWord As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents LookUpOperator As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Grid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents objDS1 As BizzLib.dsEDoc
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEDocSearch_Browse))
        Me.Grid2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colOperator = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.LookUpOperator = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.objDS1 = New BizzLib.dsEDoc
        Me.colKeyWord = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.lblType = New System.Windows.Forms.Label
        Me.cmbType = New DevExpress.XtraEditors.LookUpEdit
        Me.lblName = New System.Windows.Forms.Label
        Me.lblPath = New System.Windows.Forms.Label
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.lblCategory = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.cmbCategory = New DevExpress.XtraEditors.LookUpEdit
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.TabParameters.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpOperator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        '
        'UcPivotGrid1
        '
        Me.UcPivotGrid1.Name = "UcPivotGrid1"
        Me.HelpProvider1.SetShowHelp(Me.UcPivotGrid1, CType(resources.GetObject("UcPivotGrid1.ShowHelp"), Boolean))
        Me.UcPivotGrid1.Size = CType(resources.GetObject("UcPivotGrid1.Size"), System.Drawing.Size)
        '
        'TabAnalyse
        '
        Me.TabAnalyse.Name = "TabAnalyse"
        Me.TabAnalyse.PageVisible = False
        Me.HelpProvider1.SetShowHelp(Me.TabAnalyse, CType(resources.GetObject("TabAnalyse.ShowHelp"), Boolean))
        Me.TabAnalyse.Size = CType(resources.GetObject("TabAnalyse.Size"), System.Drawing.Size)
        '
        'TabResult
        '
        Me.TabResult.Name = "TabResult"
        Me.HelpProvider1.SetShowHelp(Me.TabResult, CType(resources.GetObject("TabResult.ShowHelp"), Boolean))
        Me.TabResult.Size = CType(resources.GetObject("TabResult.Size"), System.Drawing.Size)
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = CType(resources.GetObject("StatusBar1.Location"), System.Drawing.Point)
        Me.StatusBar1.Name = "StatusBar1"
        Me.HelpProvider1.SetShowHelp(Me.StatusBar1, CType(resources.GetObject("StatusBar1.ShowHelp"), Boolean))
        Me.StatusBar1.Size = CType(resources.GetObject("StatusBar1.Size"), System.Drawing.Size)
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.GroupControl1)
        Me.TabParameters.Controls.Add(Me.Grid2)
        Me.TabParameters.Name = "TabParameters"
        Me.HelpProvider1.SetShowHelp(Me.TabParameters, CType(resources.GetObject("TabParameters.ShowHelp"), Boolean))
        Me.TabParameters.Size = CType(resources.GetObject("TabParameters.Size"), System.Drawing.Size)
        '
        'GridView1
        '
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowBands = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'Grid1
        '
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
        Me.Grid1.EmbeddedNavigator.Text = resources.GetString("Grid1.EmbeddedNavigator.Text")
        Me.Grid1.EmbeddedNavigator.TextLocation = CType(resources.GetObject("Grid1.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.Grid1.EmbeddedNavigator.TextStringFormat = resources.GetString("Grid1.EmbeddedNavigator.TextStringFormat")
        Me.Grid1.EmbeddedNavigator.ToolTip = resources.GetString("Grid1.EmbeddedNavigator.ToolTip")
        Me.Grid1.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("Grid1.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.Grid1.EmbeddedNavigator.ToolTipTitle = resources.GetString("Grid1.EmbeddedNavigator.ToolTipTitle")
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = CType(resources.GetObject("Grid1.Size"), System.Drawing.Size)
        '
        'Panel1
        '
        Me.Panel1.Location = CType(resources.GetObject("Panel1.Location"), System.Drawing.Point)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = CType(resources.GetObject("Panel1.Size"), System.Drawing.Size)
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = CType(resources.GetObject("TabControl1.Size"), System.Drawing.Size)
        '
        'View_Bar
        '
        Me.View_Bar.DockCol = 2
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
        'Misc_Bar
        '
        Me.Misc_Bar.DockCol = 0
        Me.Misc_Bar.Offset = 5
        '
        'Main_Bar
        '
        Me.Main_Bar.Visible = False
        '
        'QuickSearch_Bar
        '
        Me.QuickSearch_Bar.DockCol = 1
        Me.QuickSearch_Bar.Offset = 233
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
        'Grid2
        '
        Me.Grid2.AccessibleDescription = resources.GetString("Grid2.AccessibleDescription")
        Me.Grid2.AccessibleName = resources.GetString("Grid2.AccessibleName")
        Me.Grid2.Anchor = CType(resources.GetObject("Grid2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Grid2.BackgroundImage = CType(resources.GetObject("Grid2.BackgroundImage"), System.Drawing.Image)
        Me.Grid2.DataMember = resources.GetString("Grid2.DataMember")
        Me.Grid2.DataSource = Me.objDS1.EDocKeywordSearch
        Me.Grid2.Dock = CType(resources.GetObject("Grid2.Dock"), System.Windows.Forms.DockStyle)
        '
        'Grid2.EmbeddedNavigator
        '
        Me.Grid2.EmbeddedNavigator.AccessibleDescription = resources.GetString("Grid2.EmbeddedNavigator.AccessibleDescription")
        Me.Grid2.EmbeddedNavigator.AccessibleName = resources.GetString("Grid2.EmbeddedNavigator.AccessibleName")
        Me.Grid2.EmbeddedNavigator.Anchor = CType(resources.GetObject("Grid2.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Grid2.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("Grid2.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.Grid2.EmbeddedNavigator.Enabled = CType(resources.GetObject("Grid2.EmbeddedNavigator.Enabled"), Boolean)
        Me.Grid2.EmbeddedNavigator.ImeMode = CType(resources.GetObject("Grid2.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Grid2.EmbeddedNavigator.Name = ""
        Me.Grid2.EmbeddedNavigator.Text = resources.GetString("Grid2.EmbeddedNavigator.Text")
        Me.Grid2.EmbeddedNavigator.TextLocation = CType(resources.GetObject("Grid2.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.Grid2.EmbeddedNavigator.TextStringFormat = resources.GetString("Grid2.EmbeddedNavigator.TextStringFormat")
        Me.Grid2.EmbeddedNavigator.ToolTip = resources.GetString("Grid2.EmbeddedNavigator.ToolTip")
        Me.Grid2.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("Grid2.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.Grid2.EmbeddedNavigator.ToolTipTitle = resources.GetString("Grid2.EmbeddedNavigator.ToolTipTitle")
        Me.Grid2.Enabled = CType(resources.GetObject("Grid2.Enabled"), Boolean)
        Me.Grid2.Font = CType(resources.GetObject("Grid2.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.Grid2, resources.GetString("Grid2.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.Grid2, CType(resources.GetObject("Grid2.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.Grid2, resources.GetString("Grid2.HelpString"))
        Me.Grid2.ImeMode = CType(resources.GetObject("Grid2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Grid2.Location = CType(resources.GetObject("Grid2.Location"), System.Drawing.Point)
        Me.Grid2.MainView = Me.GridView2
        Me.Grid2.Name = "Grid2"
        Me.Grid2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookUpOperator})
        Me.Grid2.RightToLeft = CType(resources.GetObject("Grid2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.Grid2, CType(resources.GetObject("Grid2.ShowHelp"), Boolean))
        Me.Grid2.Size = CType(resources.GetObject("Grid2.Size"), System.Drawing.Size)
        Me.Grid2.TabIndex = CType(resources.GetObject("Grid2.TabIndex"), Integer)
        Me.Grid2.UseEmbeddedNavigator = True
        Me.Grid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        Me.Grid2.Visible = CType(resources.GetObject("Grid2.Visible"), Boolean)
        '
        'GridView2
        '
        Me.GridView2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridView2.ChildGridLevelName = resources.GetString("GridView2.ChildGridLevelName")
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colOperator, Me.colKeyWord})
        Me.GridView2.GridControl = Me.Grid2
        Me.GridView2.GroupFormat = resources.GetString("GridView2.GroupFormat")
        Me.GridView2.GroupPanelText = resources.GetString("GridView2.GroupPanelText")
        Me.GridView2.Name = "GridView2"
        Me.GridView2.NewItemRowText = resources.GetString("GridView2.NewItemRowText")
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView2.OptionsView.ShowBands = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.PreviewFieldName = resources.GetString("GridView2.PreviewFieldName")
        Me.GridView2.VertScrollTipFieldName = resources.GetString("GridView2.VertScrollTipFieldName")
        Me.GridView2.ViewCaption = resources.GetString("GridView2.ViewCaption")
        '
        'GridBand1
        '
        Me.GridBand1.AutoFillDown = CType(resources.GetObject("GridBand1.AutoFillDown"), Boolean)
        Me.GridBand1.Caption = resources.GetString("GridBand1.Caption")
        Me.GridBand1.Columns.Add(Me.colOperator)
        Me.GridBand1.Columns.Add(Me.colKeyWord)
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
        'colOperator
        '
        Me.colOperator.Caption = resources.GetString("colOperator.Caption")
        Me.colOperator.ColumnEdit = Me.LookUpOperator
        Me.colOperator.CustomizationCaption = resources.GetString("colOperator.CustomizationCaption")
        Me.colOperator.FieldName = resources.GetString("colOperator.FieldName")
        Me.colOperator.ImageAlignment = CType(resources.GetObject("colOperator.ImageAlignment"), System.Drawing.StringAlignment)
        Me.colOperator.ImageIndex = CType(resources.GetObject("colOperator.ImageIndex"), Integer)
        Me.colOperator.Name = "colOperator"
        Me.colOperator.ToolTip = resources.GetString("colOperator.ToolTip")
        Me.colOperator.Visible = CType(resources.GetObject("colOperator.Visible"), Boolean)
        Me.colOperator.Width = CType(resources.GetObject("colOperator.Width"), Integer)
        '
        'LookUpOperator
        '
        Me.LookUpOperator.AccessibleDescription = resources.GetString("LookUpOperator.AccessibleDescription")
        Me.LookUpOperator.AccessibleName = resources.GetString("LookUpOperator.AccessibleName")
        Me.LookUpOperator.AutoHeight = CType(resources.GetObject("LookUpOperator.AutoHeight"), Boolean)
        Me.LookUpOperator.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpOperator.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeDesc", "Operator", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpOperator.DataSource = Me.objDS1.EDocSearchOperatorVIEW1
        Me.LookUpOperator.DisplayMember = "CodeDesc"
        Me.LookUpOperator.Mask.AutoComplete = CType(resources.GetObject("LookUpOperator.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.LookUpOperator.Mask.BeepOnError = CType(resources.GetObject("LookUpOperator.Mask.BeepOnError"), Boolean)
        Me.LookUpOperator.Mask.EditMask = resources.GetString("LookUpOperator.Mask.EditMask")
        Me.LookUpOperator.Mask.IgnoreMaskBlank = CType(resources.GetObject("LookUpOperator.Mask.IgnoreMaskBlank"), Boolean)
        Me.LookUpOperator.Mask.MaskType = CType(resources.GetObject("LookUpOperator.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.LookUpOperator.Mask.PlaceHolder = CType(resources.GetObject("LookUpOperator.Mask.PlaceHolder"), Char)
        Me.LookUpOperator.Mask.SaveLiteral = CType(resources.GetObject("LookUpOperator.Mask.SaveLiteral"), Boolean)
        Me.LookUpOperator.Mask.ShowPlaceHolders = CType(resources.GetObject("LookUpOperator.Mask.ShowPlaceHolders"), Boolean)
        Me.LookUpOperator.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("LookUpOperator.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.LookUpOperator.Name = "LookUpOperator"
        Me.LookUpOperator.NullText = resources.GetString("LookUpOperator.NullText")
        Me.LookUpOperator.ValueMember = "CodeDesc"
        '
        'objDS1
        '
        Me.objDS1.DataSetName = "dsEDoc"
        Me.objDS1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'colKeyWord
        '
        Me.colKeyWord.Caption = resources.GetString("colKeyWord.Caption")
        Me.colKeyWord.CustomizationCaption = resources.GetString("colKeyWord.CustomizationCaption")
        Me.colKeyWord.FieldName = resources.GetString("colKeyWord.FieldName")
        Me.colKeyWord.ImageAlignment = CType(resources.GetObject("colKeyWord.ImageAlignment"), System.Drawing.StringAlignment)
        Me.colKeyWord.ImageIndex = CType(resources.GetObject("colKeyWord.ImageIndex"), Integer)
        Me.colKeyWord.Name = "colKeyWord"
        Me.colKeyWord.ToolTip = resources.GetString("colKeyWord.ToolTip")
        Me.colKeyWord.Visible = CType(resources.GetObject("colKeyWord.Visible"), Boolean)
        Me.colKeyWord.Width = CType(resources.GetObject("colKeyWord.Width"), Integer)
        '
        'lblType
        '
        Me.lblType.AccessibleDescription = resources.GetString("lblType.AccessibleDescription")
        Me.lblType.AccessibleName = resources.GetString("lblType.AccessibleName")
        Me.lblType.Anchor = CType(resources.GetObject("lblType.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblType.AutoSize = CType(resources.GetObject("lblType.AutoSize"), Boolean)
        Me.lblType.Dock = CType(resources.GetObject("lblType.Dock"), System.Windows.Forms.DockStyle)
        Me.lblType.Enabled = CType(resources.GetObject("lblType.Enabled"), Boolean)
        Me.lblType.Font = CType(resources.GetObject("lblType.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.lblType, resources.GetString("lblType.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblType, CType(resources.GetObject("lblType.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblType, resources.GetString("lblType.HelpString"))
        Me.lblType.Image = CType(resources.GetObject("lblType.Image"), System.Drawing.Image)
        Me.lblType.ImageAlign = CType(resources.GetObject("lblType.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblType.ImageIndex = CType(resources.GetObject("lblType.ImageIndex"), Integer)
        Me.lblType.ImeMode = CType(resources.GetObject("lblType.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblType.Location = CType(resources.GetObject("lblType.Location"), System.Drawing.Point)
        Me.lblType.Name = "lblType"
        Me.lblType.RightToLeft = CType(resources.GetObject("lblType.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.lblType, CType(resources.GetObject("lblType.ShowHelp"), Boolean))
        Me.lblType.Size = CType(resources.GetObject("lblType.Size"), System.Drawing.Size)
        Me.lblType.TabIndex = CType(resources.GetObject("lblType.TabIndex"), Integer)
        Me.lblType.Text = resources.GetString("lblType.Text")
        Me.lblType.TextAlign = CType(resources.GetObject("lblType.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblType.Visible = CType(resources.GetObject("lblType.Visible"), Boolean)
        '
        'cmbType
        '
        Me.cmbType.Anchor = CType(resources.GetObject("cmbType.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cmbType.BackgroundImage = CType(resources.GetObject("cmbType.BackgroundImage"), System.Drawing.Image)
        Me.cmbType.Dock = CType(resources.GetObject("cmbType.Dock"), System.Windows.Forms.DockStyle)
        Me.cmbType.EditValue = CType(resources.GetObject("cmbType.EditValue"), Object)
        Me.cmbType.Enabled = CType(resources.GetObject("cmbType.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.cmbType, resources.GetString("cmbType.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.cmbType, CType(resources.GetObject("cmbType.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.cmbType, resources.GetString("cmbType.HelpString"))
        Me.cmbType.ImeMode = CType(resources.GetObject("cmbType.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cmbType.Location = CType(resources.GetObject("cmbType.Location"), System.Drawing.Point)
        Me.cmbType.Name = "cmbType"
        '
        'cmbType.Properties
        '
        Me.cmbType.Properties.AccessibleDescription = resources.GetString("cmbType.Properties.AccessibleDescription")
        Me.cmbType.Properties.AccessibleName = resources.GetString("cmbType.Properties.AccessibleName")
        Me.cmbType.Properties.AutoHeight = CType(resources.GetObject("cmbType.Properties.AutoHeight"), Boolean)
        Me.cmbType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeValue", "CodeValue", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeDesc", "CodeDesc", 130, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbType.Properties.DataSource = Me.objDS1.EDocTypeView1
        Me.cmbType.Properties.DisplayMember = "CodeValue"
        Me.cmbType.Properties.Mask.AutoComplete = CType(resources.GetObject("cmbType.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.cmbType.Properties.Mask.BeepOnError = CType(resources.GetObject("cmbType.Properties.Mask.BeepOnError"), Boolean)
        Me.cmbType.Properties.Mask.EditMask = resources.GetString("cmbType.Properties.Mask.EditMask")
        Me.cmbType.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("cmbType.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.cmbType.Properties.Mask.MaskType = CType(resources.GetObject("cmbType.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.cmbType.Properties.Mask.PlaceHolder = CType(resources.GetObject("cmbType.Properties.Mask.PlaceHolder"), Char)
        Me.cmbType.Properties.Mask.SaveLiteral = CType(resources.GetObject("cmbType.Properties.Mask.SaveLiteral"), Boolean)
        Me.cmbType.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("cmbType.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.cmbType.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("cmbType.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.cmbType.Properties.NullText = resources.GetString("cmbType.Properties.NullText")
        Me.cmbType.Properties.PopupWidth = 200
        Me.cmbType.Properties.ValueMember = "CodeValue"
        Me.cmbType.RightToLeft = CType(resources.GetObject("cmbType.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.cmbType, CType(resources.GetObject("cmbType.ShowHelp"), Boolean))
        Me.cmbType.Size = CType(resources.GetObject("cmbType.Size"), System.Drawing.Size)
        Me.cmbType.TabIndex = CType(resources.GetObject("cmbType.TabIndex"), Integer)
        Me.cmbType.ToolTip = resources.GetString("cmbType.ToolTip")
        Me.cmbType.ToolTipIconType = CType(resources.GetObject("cmbType.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.cmbType.ToolTipTitle = resources.GetString("cmbType.ToolTipTitle")
        Me.cmbType.Visible = CType(resources.GetObject("cmbType.Visible"), Boolean)
        '
        'lblName
        '
        Me.lblName.AccessibleDescription = resources.GetString("lblName.AccessibleDescription")
        Me.lblName.AccessibleName = resources.GetString("lblName.AccessibleName")
        Me.lblName.Anchor = CType(resources.GetObject("lblName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = CType(resources.GetObject("lblName.AutoSize"), Boolean)
        Me.lblName.Dock = CType(resources.GetObject("lblName.Dock"), System.Windows.Forms.DockStyle)
        Me.lblName.Enabled = CType(resources.GetObject("lblName.Enabled"), Boolean)
        Me.lblName.Font = CType(resources.GetObject("lblName.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.lblName, resources.GetString("lblName.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblName, CType(resources.GetObject("lblName.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblName, resources.GetString("lblName.HelpString"))
        Me.lblName.Image = CType(resources.GetObject("lblName.Image"), System.Drawing.Image)
        Me.lblName.ImageAlign = CType(resources.GetObject("lblName.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblName.ImageIndex = CType(resources.GetObject("lblName.ImageIndex"), Integer)
        Me.lblName.ImeMode = CType(resources.GetObject("lblName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblName.Location = CType(resources.GetObject("lblName.Location"), System.Drawing.Point)
        Me.lblName.Name = "lblName"
        Me.lblName.RightToLeft = CType(resources.GetObject("lblName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.lblName, CType(resources.GetObject("lblName.ShowHelp"), Boolean))
        Me.lblName.Size = CType(resources.GetObject("lblName.Size"), System.Drawing.Size)
        Me.lblName.TabIndex = CType(resources.GetObject("lblName.TabIndex"), Integer)
        Me.lblName.Text = resources.GetString("lblName.Text")
        Me.lblName.TextAlign = CType(resources.GetObject("lblName.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblName.Visible = CType(resources.GetObject("lblName.Visible"), Boolean)
        '
        'lblPath
        '
        Me.lblPath.AccessibleDescription = resources.GetString("lblPath.AccessibleDescription")
        Me.lblPath.AccessibleName = resources.GetString("lblPath.AccessibleName")
        Me.lblPath.Anchor = CType(resources.GetObject("lblPath.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblPath.AutoSize = CType(resources.GetObject("lblPath.AutoSize"), Boolean)
        Me.lblPath.Dock = CType(resources.GetObject("lblPath.Dock"), System.Windows.Forms.DockStyle)
        Me.lblPath.Enabled = CType(resources.GetObject("lblPath.Enabled"), Boolean)
        Me.lblPath.Font = CType(resources.GetObject("lblPath.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.lblPath, resources.GetString("lblPath.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblPath, CType(resources.GetObject("lblPath.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblPath, resources.GetString("lblPath.HelpString"))
        Me.lblPath.Image = CType(resources.GetObject("lblPath.Image"), System.Drawing.Image)
        Me.lblPath.ImageAlign = CType(resources.GetObject("lblPath.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblPath.ImageIndex = CType(resources.GetObject("lblPath.ImageIndex"), Integer)
        Me.lblPath.ImeMode = CType(resources.GetObject("lblPath.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblPath.Location = CType(resources.GetObject("lblPath.Location"), System.Drawing.Point)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.RightToLeft = CType(resources.GetObject("lblPath.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.lblPath, CType(resources.GetObject("lblPath.ShowHelp"), Boolean))
        Me.lblPath.Size = CType(resources.GetObject("lblPath.Size"), System.Drawing.Size)
        Me.lblPath.TabIndex = CType(resources.GetObject("lblPath.TabIndex"), Integer)
        Me.lblPath.Text = resources.GetString("lblPath.Text")
        Me.lblPath.TextAlign = CType(resources.GetObject("lblPath.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblPath.Visible = CType(resources.GetObject("lblPath.Visible"), Boolean)
        '
        'txtPath
        '
        Me.txtPath.AccessibleDescription = resources.GetString("txtPath.AccessibleDescription")
        Me.txtPath.AccessibleName = resources.GetString("txtPath.AccessibleName")
        Me.txtPath.Anchor = CType(resources.GetObject("txtPath.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtPath.AutoSize = CType(resources.GetObject("txtPath.AutoSize"), Boolean)
        Me.txtPath.BackgroundImage = CType(resources.GetObject("txtPath.BackgroundImage"), System.Drawing.Image)
        Me.txtPath.Dock = CType(resources.GetObject("txtPath.Dock"), System.Windows.Forms.DockStyle)
        Me.txtPath.Enabled = CType(resources.GetObject("txtPath.Enabled"), Boolean)
        Me.txtPath.Font = CType(resources.GetObject("txtPath.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.txtPath, resources.GetString("txtPath.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtPath, CType(resources.GetObject("txtPath.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtPath, resources.GetString("txtPath.HelpString"))
        Me.txtPath.ImeMode = CType(resources.GetObject("txtPath.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtPath.Location = CType(resources.GetObject("txtPath.Location"), System.Drawing.Point)
        Me.txtPath.MaxLength = CType(resources.GetObject("txtPath.MaxLength"), Integer)
        Me.txtPath.Multiline = CType(resources.GetObject("txtPath.Multiline"), Boolean)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.PasswordChar = CType(resources.GetObject("txtPath.PasswordChar"), Char)
        Me.txtPath.RightToLeft = CType(resources.GetObject("txtPath.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtPath.ScrollBars = CType(resources.GetObject("txtPath.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.HelpProvider1.SetShowHelp(Me.txtPath, CType(resources.GetObject("txtPath.ShowHelp"), Boolean))
        Me.txtPath.Size = CType(resources.GetObject("txtPath.Size"), System.Drawing.Size)
        Me.txtPath.TabIndex = CType(resources.GetObject("txtPath.TabIndex"), Integer)
        Me.txtPath.Text = resources.GetString("txtPath.Text")
        Me.txtPath.TextAlign = CType(resources.GetObject("txtPath.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtPath.Visible = CType(resources.GetObject("txtPath.Visible"), Boolean)
        Me.txtPath.WordWrap = CType(resources.GetObject("txtPath.WordWrap"), Boolean)
        '
        'lblCategory
        '
        Me.lblCategory.AccessibleDescription = resources.GetString("lblCategory.AccessibleDescription")
        Me.lblCategory.AccessibleName = resources.GetString("lblCategory.AccessibleName")
        Me.lblCategory.Anchor = CType(resources.GetObject("lblCategory.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblCategory.AutoSize = CType(resources.GetObject("lblCategory.AutoSize"), Boolean)
        Me.lblCategory.Dock = CType(resources.GetObject("lblCategory.Dock"), System.Windows.Forms.DockStyle)
        Me.lblCategory.Enabled = CType(resources.GetObject("lblCategory.Enabled"), Boolean)
        Me.lblCategory.Font = CType(resources.GetObject("lblCategory.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.lblCategory, resources.GetString("lblCategory.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblCategory, CType(resources.GetObject("lblCategory.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblCategory, resources.GetString("lblCategory.HelpString"))
        Me.lblCategory.Image = CType(resources.GetObject("lblCategory.Image"), System.Drawing.Image)
        Me.lblCategory.ImageAlign = CType(resources.GetObject("lblCategory.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblCategory.ImageIndex = CType(resources.GetObject("lblCategory.ImageIndex"), Integer)
        Me.lblCategory.ImeMode = CType(resources.GetObject("lblCategory.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblCategory.Location = CType(resources.GetObject("lblCategory.Location"), System.Drawing.Point)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.RightToLeft = CType(resources.GetObject("lblCategory.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.lblCategory, CType(resources.GetObject("lblCategory.ShowHelp"), Boolean))
        Me.lblCategory.Size = CType(resources.GetObject("lblCategory.Size"), System.Drawing.Size)
        Me.lblCategory.TabIndex = CType(resources.GetObject("lblCategory.TabIndex"), Integer)
        Me.lblCategory.Text = resources.GetString("lblCategory.Text")
        Me.lblCategory.TextAlign = CType(resources.GetObject("lblCategory.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblCategory.Visible = CType(resources.GetObject("lblCategory.Visible"), Boolean)
        '
        'lblDescription
        '
        Me.lblDescription.AccessibleDescription = resources.GetString("lblDescription.AccessibleDescription")
        Me.lblDescription.AccessibleName = resources.GetString("lblDescription.AccessibleName")
        Me.lblDescription.Anchor = CType(resources.GetObject("lblDescription.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblDescription.AutoSize = CType(resources.GetObject("lblDescription.AutoSize"), Boolean)
        Me.lblDescription.Dock = CType(resources.GetObject("lblDescription.Dock"), System.Windows.Forms.DockStyle)
        Me.lblDescription.Enabled = CType(resources.GetObject("lblDescription.Enabled"), Boolean)
        Me.lblDescription.Font = CType(resources.GetObject("lblDescription.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.lblDescription, resources.GetString("lblDescription.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblDescription, CType(resources.GetObject("lblDescription.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblDescription, resources.GetString("lblDescription.HelpString"))
        Me.lblDescription.Image = CType(resources.GetObject("lblDescription.Image"), System.Drawing.Image)
        Me.lblDescription.ImageAlign = CType(resources.GetObject("lblDescription.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblDescription.ImageIndex = CType(resources.GetObject("lblDescription.ImageIndex"), Integer)
        Me.lblDescription.ImeMode = CType(resources.GetObject("lblDescription.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblDescription.Location = CType(resources.GetObject("lblDescription.Location"), System.Drawing.Point)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = CType(resources.GetObject("lblDescription.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.lblDescription, CType(resources.GetObject("lblDescription.ShowHelp"), Boolean))
        Me.lblDescription.Size = CType(resources.GetObject("lblDescription.Size"), System.Drawing.Size)
        Me.lblDescription.TabIndex = CType(resources.GetObject("lblDescription.TabIndex"), Integer)
        Me.lblDescription.Text = resources.GetString("lblDescription.Text")
        Me.lblDescription.TextAlign = CType(resources.GetObject("lblDescription.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblDescription.Visible = CType(resources.GetObject("lblDescription.Visible"), Boolean)
        '
        'cmbCategory
        '
        Me.cmbCategory.Anchor = CType(resources.GetObject("cmbCategory.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cmbCategory.BackgroundImage = CType(resources.GetObject("cmbCategory.BackgroundImage"), System.Drawing.Image)
        Me.cmbCategory.Dock = CType(resources.GetObject("cmbCategory.Dock"), System.Windows.Forms.DockStyle)
        Me.cmbCategory.EditValue = CType(resources.GetObject("cmbCategory.EditValue"), Object)
        Me.cmbCategory.Enabled = CType(resources.GetObject("cmbCategory.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.cmbCategory, resources.GetString("cmbCategory.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.cmbCategory, CType(resources.GetObject("cmbCategory.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.cmbCategory, resources.GetString("cmbCategory.HelpString"))
        Me.cmbCategory.ImeMode = CType(resources.GetObject("cmbCategory.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cmbCategory.Location = CType(resources.GetObject("cmbCategory.Location"), System.Drawing.Point)
        Me.cmbCategory.Name = "cmbCategory"
        '
        'cmbCategory.Properties
        '
        Me.cmbCategory.Properties.AccessibleDescription = resources.GetString("cmbCategory.Properties.AccessibleDescription")
        Me.cmbCategory.Properties.AccessibleName = resources.GetString("cmbCategory.Properties.AccessibleName")
        Me.cmbCategory.Properties.AutoHeight = CType(resources.GetObject("cmbCategory.Properties.AutoHeight"), Boolean)
        Me.cmbCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCategory.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeValue", "CodeValue", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeDesc", "CodeDesc", 130, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbCategory.Properties.DataSource = Me.objDS1.EDocCategoryView1
        Me.cmbCategory.Properties.DisplayMember = "CodeValue"
        Me.cmbCategory.Properties.Mask.AutoComplete = CType(resources.GetObject("cmbCategory.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.cmbCategory.Properties.Mask.BeepOnError = CType(resources.GetObject("cmbCategory.Properties.Mask.BeepOnError"), Boolean)
        Me.cmbCategory.Properties.Mask.EditMask = resources.GetString("cmbCategory.Properties.Mask.EditMask")
        Me.cmbCategory.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("cmbCategory.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.cmbCategory.Properties.Mask.MaskType = CType(resources.GetObject("cmbCategory.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.cmbCategory.Properties.Mask.PlaceHolder = CType(resources.GetObject("cmbCategory.Properties.Mask.PlaceHolder"), Char)
        Me.cmbCategory.Properties.Mask.SaveLiteral = CType(resources.GetObject("cmbCategory.Properties.Mask.SaveLiteral"), Boolean)
        Me.cmbCategory.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("cmbCategory.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.cmbCategory.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("cmbCategory.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.cmbCategory.Properties.NullText = resources.GetString("cmbCategory.Properties.NullText")
        Me.cmbCategory.Properties.PopupWidth = 200
        Me.cmbCategory.Properties.ValueMember = "CodeValue"
        Me.cmbCategory.RightToLeft = CType(resources.GetObject("cmbCategory.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.cmbCategory, CType(resources.GetObject("cmbCategory.ShowHelp"), Boolean))
        Me.cmbCategory.Size = CType(resources.GetObject("cmbCategory.Size"), System.Drawing.Size)
        Me.cmbCategory.TabIndex = CType(resources.GetObject("cmbCategory.TabIndex"), Integer)
        Me.cmbCategory.ToolTip = resources.GetString("cmbCategory.ToolTip")
        Me.cmbCategory.ToolTipIconType = CType(resources.GetObject("cmbCategory.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.cmbCategory.ToolTipTitle = resources.GetString("cmbCategory.ToolTipTitle")
        Me.cmbCategory.Visible = CType(resources.GetObject("cmbCategory.Visible"), Boolean)
        '
        'txtDescription
        '
        Me.txtDescription.AccessibleDescription = resources.GetString("txtDescription.AccessibleDescription")
        Me.txtDescription.AccessibleName = resources.GetString("txtDescription.AccessibleName")
        Me.txtDescription.Anchor = CType(resources.GetObject("txtDescription.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.AutoSize = CType(resources.GetObject("txtDescription.AutoSize"), Boolean)
        Me.txtDescription.BackgroundImage = CType(resources.GetObject("txtDescription.BackgroundImage"), System.Drawing.Image)
        Me.txtDescription.Dock = CType(resources.GetObject("txtDescription.Dock"), System.Windows.Forms.DockStyle)
        Me.txtDescription.Enabled = CType(resources.GetObject("txtDescription.Enabled"), Boolean)
        Me.txtDescription.Font = CType(resources.GetObject("txtDescription.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.txtDescription, resources.GetString("txtDescription.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtDescription, CType(resources.GetObject("txtDescription.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtDescription, resources.GetString("txtDescription.HelpString"))
        Me.txtDescription.ImeMode = CType(resources.GetObject("txtDescription.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtDescription.Location = CType(resources.GetObject("txtDescription.Location"), System.Drawing.Point)
        Me.txtDescription.MaxLength = CType(resources.GetObject("txtDescription.MaxLength"), Integer)
        Me.txtDescription.Multiline = CType(resources.GetObject("txtDescription.Multiline"), Boolean)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = CType(resources.GetObject("txtDescription.PasswordChar"), Char)
        Me.txtDescription.RightToLeft = CType(resources.GetObject("txtDescription.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtDescription.ScrollBars = CType(resources.GetObject("txtDescription.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.HelpProvider1.SetShowHelp(Me.txtDescription, CType(resources.GetObject("txtDescription.ShowHelp"), Boolean))
        Me.txtDescription.Size = CType(resources.GetObject("txtDescription.Size"), System.Drawing.Size)
        Me.txtDescription.TabIndex = CType(resources.GetObject("txtDescription.TabIndex"), Integer)
        Me.txtDescription.Text = resources.GetString("txtDescription.Text")
        Me.txtDescription.TextAlign = CType(resources.GetObject("txtDescription.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtDescription.Visible = CType(resources.GetObject("txtDescription.Visible"), Boolean)
        Me.txtDescription.WordWrap = CType(resources.GetObject("txtDescription.WordWrap"), Boolean)
        '
        'txtName
        '
        Me.txtName.AccessibleDescription = resources.GetString("txtName.AccessibleDescription")
        Me.txtName.AccessibleName = resources.GetString("txtName.AccessibleName")
        Me.txtName.Anchor = CType(resources.GetObject("txtName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtName.AutoSize = CType(resources.GetObject("txtName.AutoSize"), Boolean)
        Me.txtName.BackgroundImage = CType(resources.GetObject("txtName.BackgroundImage"), System.Drawing.Image)
        Me.txtName.Dock = CType(resources.GetObject("txtName.Dock"), System.Windows.Forms.DockStyle)
        Me.txtName.Enabled = CType(resources.GetObject("txtName.Enabled"), Boolean)
        Me.txtName.Font = CType(resources.GetObject("txtName.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.txtName, resources.GetString("txtName.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtName, CType(resources.GetObject("txtName.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtName, resources.GetString("txtName.HelpString"))
        Me.txtName.ImeMode = CType(resources.GetObject("txtName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtName.Location = CType(resources.GetObject("txtName.Location"), System.Drawing.Point)
        Me.txtName.MaxLength = CType(resources.GetObject("txtName.MaxLength"), Integer)
        Me.txtName.Multiline = CType(resources.GetObject("txtName.Multiline"), Boolean)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = CType(resources.GetObject("txtName.PasswordChar"), Char)
        Me.txtName.RightToLeft = CType(resources.GetObject("txtName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtName.ScrollBars = CType(resources.GetObject("txtName.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.HelpProvider1.SetShowHelp(Me.txtName, CType(resources.GetObject("txtName.ShowHelp"), Boolean))
        Me.txtName.Size = CType(resources.GetObject("txtName.Size"), System.Drawing.Size)
        Me.txtName.TabIndex = CType(resources.GetObject("txtName.TabIndex"), Integer)
        Me.txtName.Text = resources.GetString("txtName.Text")
        Me.txtName.TextAlign = CType(resources.GetObject("txtName.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtName.Visible = CType(resources.GetObject("txtName.Visible"), Boolean)
        Me.txtName.WordWrap = CType(resources.GetObject("txtName.WordWrap"), Boolean)
        '
        'btnClear
        '
        Me.btnClear.AccessibleDescription = resources.GetString("btnClear.AccessibleDescription")
        Me.btnClear.AccessibleName = resources.GetString("btnClear.AccessibleName")
        Me.btnClear.Anchor = CType(resources.GetObject("btnClear.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Appearance.Options.UseTextOptions = True
        Me.btnClear.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.Dock = CType(resources.GetObject("btnClear.Dock"), System.Windows.Forms.DockStyle)
        Me.btnClear.Enabled = CType(resources.GetObject("btnClear.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.btnClear, resources.GetString("btnClear.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.btnClear, CType(resources.GetObject("btnClear.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.btnClear, resources.GetString("btnClear.HelpString"))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageIndex = 13
        Me.btnClear.ImeMode = CType(resources.GetObject("btnClear.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnClear.Location = CType(resources.GetObject("btnClear.Location"), System.Drawing.Point)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.RightToLeft = CType(resources.GetObject("btnClear.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.btnClear, CType(resources.GetObject("btnClear.ShowHelp"), Boolean))
        Me.btnClear.Size = CType(resources.GetObject("btnClear.Size"), System.Drawing.Size)
        Me.btnClear.TabIndex = CType(resources.GetObject("btnClear.TabIndex"), Integer)
        Me.btnClear.Text = resources.GetString("btnClear.Text")
        Me.btnClear.ToolTip = resources.GetString("btnClear.ToolTip")
        Me.btnClear.ToolTipIconType = CType(resources.GetObject("btnClear.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.btnClear.ToolTipTitle = resources.GetString("btnClear.ToolTipTitle")
        Me.btnClear.Visible = CType(resources.GetObject("btnClear.Visible"), Boolean)
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleDescription = resources.GetString("btnSearch.AccessibleDescription")
        Me.btnSearch.AccessibleName = resources.GetString("btnSearch.AccessibleName")
        Me.btnSearch.Anchor = CType(resources.GetObject("btnSearch.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Appearance.Options.UseTextOptions = True
        Me.btnSearch.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.Dock = CType(resources.GetObject("btnSearch.Dock"), System.Windows.Forms.DockStyle)
        Me.btnSearch.Enabled = CType(resources.GetObject("btnSearch.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.btnSearch, resources.GetString("btnSearch.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.btnSearch, CType(resources.GetObject("btnSearch.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.btnSearch, resources.GetString("btnSearch.HelpString"))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageIndex = 13
        Me.btnSearch.ImeMode = CType(resources.GetObject("btnSearch.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnSearch.Location = CType(resources.GetObject("btnSearch.Location"), System.Drawing.Point)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.RightToLeft = CType(resources.GetObject("btnSearch.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.btnSearch, CType(resources.GetObject("btnSearch.ShowHelp"), Boolean))
        Me.btnSearch.Size = CType(resources.GetObject("btnSearch.Size"), System.Drawing.Size)
        Me.btnSearch.TabIndex = CType(resources.GetObject("btnSearch.TabIndex"), Integer)
        Me.btnSearch.Text = resources.GetString("btnSearch.Text")
        Me.btnSearch.ToolTip = resources.GetString("btnSearch.ToolTip")
        Me.btnSearch.ToolTipIconType = CType(resources.GetObject("btnSearch.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.btnSearch.ToolTipTitle = resources.GetString("btnSearch.ToolTipTitle")
        Me.btnSearch.Visible = CType(resources.GetObject("btnSearch.Visible"), Boolean)
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM AccountCode WHERE (GLAccountID = ?) AND (AcctCat = ? OR ? IS NULL AND" & _
        " AcctCat IS NULL) AND (AcctType = ? OR ? IS NULL AND AcctType IS NULL) AND (Comm" & _
        "ent = ? OR ? IS NULL AND Comment IS NULL) AND (CurrCode = ? OR ? IS NULL AND Cur" & _
        "rCode IS NULL) AND (DeductTax = ? OR ? IS NULL AND DeductTax IS NULL) AND (Deduc" & _
        "tVat = ? OR ? IS NULL AND DeductVat IS NULL) AND (Description = ? OR ? IS NULL A" & _
        "ND Description IS NULL) AND (EntityID = ?) AND (GLAccount = ?) AND (Tax = ? OR ?" & _
        " IS NULL AND Tax IS NULL)"
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_GLAccountID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GLAccountID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AcctCat", System.Data.OleDb.OleDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcctCat", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AcctCat1", System.Data.OleDb.OleDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcctCat", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AcctType", System.Data.OleDb.OleDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcctType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AcctType1", System.Data.OleDb.OleDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcctType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comment", System.Data.OleDb.OleDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comment", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comment1", System.Data.OleDb.OleDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comment", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CurrCode", System.Data.OleDb.OleDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CurrCode1", System.Data.OleDb.OleDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DeductTax", System.Data.OleDb.OleDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DeductTax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DeductTax1", System.Data.OleDb.OleDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DeductTax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DeductVat", System.Data.OleDb.OleDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DeductVat", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DeductVat1", System.Data.OleDb.OleDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DeductVat", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EntityID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EntityID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_GLAccount", System.Data.OleDb.OleDbType.VarChar, 9, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GLAccount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Tax", System.Data.OleDb.OleDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Tax1", System.Data.OleDb.OleDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tax", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO AccountCode(GLAccountID, GLAccount, EntityID, Description, Comment, A" & _
        "cctCat, AcctType, CurrCode, DeductTax, DeductVat, Tax) VALUES (?, ?, ?, ?, ?, ?," & _
        " ?, ?, ?, ?, ?); SELECT GLAccountID, GLAccount, EntityID, Description, Comment, " & _
        "AcctCat, AcctType, CurrCode, DeductTax, DeductVat, Tax FROM AccountCode WHERE (G" & _
        "LAccountID = ?)"
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("GLAccountID", System.Data.OleDb.OleDbType.Integer, 4, "GLAccountID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("GLAccount", System.Data.OleDb.OleDbType.VarChar, 9, "GLAccount"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("EntityID", System.Data.OleDb.OleDbType.Integer, 4, "EntityID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarChar, 50, "Description"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarChar, 8, "Comment"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AcctCat", System.Data.OleDb.OleDbType.VarChar, 8, "AcctCat"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AcctType", System.Data.OleDb.OleDbType.VarChar, 8, "AcctType"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CurrCode", System.Data.OleDb.OleDbType.VarChar, 3, "CurrCode"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DeductTax", System.Data.OleDb.OleDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DeductTax", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DeductVat", System.Data.OleDb.OleDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DeductVat", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Tax", System.Data.OleDb.OleDbType.VarChar, 3, "Tax"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Select_GLAccountID", System.Data.OleDb.OleDbType.Integer, 4, "GLAccountID"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT GLAccountID, GLAccount, EntityID, Description, Comment, AcctCat, AcctType," & _
        " CurrCode, DeductTax, DeductVat, Tax FROM AccountCode"
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE AccountCode SET GLAccountID = ?, GLAccount = ?, EntityID = ?, Description " & _
        "= ?, Comment = ?, AcctCat = ?, AcctType = ?, CurrCode = ?, DeductTax = ?, Deduct" & _
        "Vat = ?, Tax = ? WHERE (GLAccountID = ?) AND (AcctCat = ? OR ? IS NULL AND AcctC" & _
        "at IS NULL) AND (AcctType = ? OR ? IS NULL AND AcctType IS NULL) AND (Comment = " & _
        "? OR ? IS NULL AND Comment IS NULL) AND (CurrCode = ? OR ? IS NULL AND CurrCode " & _
        "IS NULL) AND (DeductTax = ? OR ? IS NULL AND DeductTax IS NULL) AND (DeductVat =" & _
        " ? OR ? IS NULL AND DeductVat IS NULL) AND (Description = ? OR ? IS NULL AND Des" & _
        "cription IS NULL) AND (EntityID = ?) AND (GLAccount = ?) AND (Tax = ? OR ? IS NU" & _
        "LL AND Tax IS NULL); SELECT GLAccountID, GLAccount, EntityID, Description, Comme" & _
        "nt, AcctCat, AcctType, CurrCode, DeductTax, DeductVat, Tax FROM AccountCode WHER" & _
        "E (GLAccountID = ?)"
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("GLAccountID", System.Data.OleDb.OleDbType.Integer, 4, "GLAccountID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("GLAccount", System.Data.OleDb.OleDbType.VarChar, 9, "GLAccount"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("EntityID", System.Data.OleDb.OleDbType.Integer, 4, "EntityID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarChar, 50, "Description"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarChar, 8, "Comment"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AcctCat", System.Data.OleDb.OleDbType.VarChar, 8, "AcctCat"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AcctType", System.Data.OleDb.OleDbType.VarChar, 8, "AcctType"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CurrCode", System.Data.OleDb.OleDbType.VarChar, 3, "CurrCode"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DeductTax", System.Data.OleDb.OleDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DeductTax", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DeductVat", System.Data.OleDb.OleDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DeductVat", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Tax", System.Data.OleDb.OleDbType.VarChar, 3, "Tax"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_GLAccountID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GLAccountID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AcctCat", System.Data.OleDb.OleDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcctCat", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AcctCat1", System.Data.OleDb.OleDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcctCat", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AcctType", System.Data.OleDb.OleDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcctType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AcctType1", System.Data.OleDb.OleDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcctType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comment", System.Data.OleDb.OleDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comment", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comment1", System.Data.OleDb.OleDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comment", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CurrCode", System.Data.OleDb.OleDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CurrCode1", System.Data.OleDb.OleDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DeductTax", System.Data.OleDb.OleDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DeductTax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DeductTax1", System.Data.OleDb.OleDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DeductTax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DeductVat", System.Data.OleDb.OleDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DeductVat", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DeductVat1", System.Data.OleDb.OleDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DeductVat", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EntityID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EntityID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_GLAccount", System.Data.OleDb.OleDbType.VarChar, 9, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GLAccount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Tax", System.Data.OleDb.OleDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Tax1", System.Data.OleDb.OleDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Select_GLAccountID", System.Data.OleDb.OleDbType.Integer, 4, "GLAccountID"))
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "EDocSearchView1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("EDocPath", "EDocPath"), New System.Data.Common.DataColumnMapping("Author", "Author"), New System.Data.Common.DataColumnMapping("Producer", "Producer"), New System.Data.Common.DataColumnMapping("CrDate", "CrDate"), New System.Data.Common.DataColumnMapping("UserID", "UserID"), New System.Data.Common.DataColumnMapping("Scanned", "Scanned"), New System.Data.Common.DataColumnMapping("KeyWord", "KeyWord"), New System.Data.Common.DataColumnMapping("KeyWordTypeID", "KeyWordTypeID"), New System.Data.Common.DataColumnMapping("EdocType", "EdocType"), New System.Data.Common.DataColumnMapping("EdocCategory", "EdocCategory"), New System.Data.Common.DataColumnMapping("UserFullName", "UserFullName"), New System.Data.Common.DataColumnMapping("EDocTypeID", "EDocTypeID"), New System.Data.Common.DataColumnMapping("EDocCategoryID", "EDocCategoryID"), New System.Data.Common.DataColumnMapping("EDocID", "EDocID")})})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT Name, Description, EDocPath, Author, Producer, CrDate, UserID, Scanned, Ke" & _
        "yWord, KeyWordTypeID, EdocType, EdocCategory, UserFullName, EDocTypeID, EDocCate" & _
        "goryID, EDocID FROM EDocSearchView1"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = resources.GetString("FolderBrowserDialog1.Description")
        Me.FolderBrowserDialog1.SelectedPath = resources.GetString("FolderBrowserDialog1.SelectedPath")
        '
        'GroupControl1
        '
        Me.GroupControl1.AccessibleDescription = resources.GetString("GroupControl1.AccessibleDescription")
        Me.GroupControl1.AccessibleName = resources.GetString("GroupControl1.AccessibleName")
        Me.GroupControl1.Anchor = CType(resources.GetObject("GroupControl1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AutoScroll = CType(resources.GetObject("GroupControl1.AutoScroll"), Boolean)
        Me.GroupControl1.AutoScrollMargin = CType(resources.GetObject("GroupControl1.AutoScrollMargin"), System.Drawing.Size)
        Me.GroupControl1.AutoScrollMinSize = CType(resources.GetObject("GroupControl1.AutoScrollMinSize"), System.Drawing.Size)
        Me.GroupControl1.BackgroundImage = CType(resources.GetObject("GroupControl1.BackgroundImage"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.btnBrowse)
        Me.GroupControl1.Controls.Add(Me.txtDescription)
        Me.GroupControl1.Controls.Add(Me.txtName)
        Me.GroupControl1.Controls.Add(Me.lblType)
        Me.GroupControl1.Controls.Add(Me.cmbType)
        Me.GroupControl1.Controls.Add(Me.lblName)
        Me.GroupControl1.Controls.Add(Me.lblPath)
        Me.GroupControl1.Controls.Add(Me.txtPath)
        Me.GroupControl1.Controls.Add(Me.lblCategory)
        Me.GroupControl1.Controls.Add(Me.lblDescription)
        Me.GroupControl1.Controls.Add(Me.cmbCategory)
        Me.GroupControl1.Controls.Add(Me.btnSearch)
        Me.GroupControl1.Controls.Add(Me.btnClear)
        Me.GroupControl1.Dock = CType(resources.GetObject("GroupControl1.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupControl1.Enabled = CType(resources.GetObject("GroupControl1.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.GroupControl1, resources.GetString("GroupControl1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.GroupControl1, CType(resources.GetObject("GroupControl1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.GroupControl1, resources.GetString("GroupControl1.HelpString"))
        Me.GroupControl1.ImeMode = CType(resources.GetObject("GroupControl1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupControl1.Location = CType(resources.GetObject("GroupControl1.Location"), System.Drawing.Point)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.RightToLeft = CType(resources.GetObject("GroupControl1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.GroupControl1, CType(resources.GetObject("GroupControl1.ShowHelp"), Boolean))
        Me.GroupControl1.Size = CType(resources.GetObject("GroupControl1.Size"), System.Drawing.Size)
        Me.GroupControl1.TabIndex = CType(resources.GetObject("GroupControl1.TabIndex"), Integer)
        Me.GroupControl1.Text = resources.GetString("GroupControl1.Text")
        Me.GroupControl1.Visible = CType(resources.GetObject("GroupControl1.Visible"), Boolean)
        '
        'btnBrowse
        '
        Me.btnBrowse.AccessibleDescription = resources.GetString("btnBrowse.AccessibleDescription")
        Me.btnBrowse.AccessibleName = resources.GetString("btnBrowse.AccessibleName")
        Me.btnBrowse.Anchor = CType(resources.GetObject("btnBrowse.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.BackgroundImage = CType(resources.GetObject("btnBrowse.BackgroundImage"), System.Drawing.Image)
        Me.btnBrowse.Dock = CType(resources.GetObject("btnBrowse.Dock"), System.Windows.Forms.DockStyle)
        Me.btnBrowse.Enabled = CType(resources.GetObject("btnBrowse.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.btnBrowse, resources.GetString("btnBrowse.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.btnBrowse, CType(resources.GetObject("btnBrowse.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.btnBrowse, resources.GetString("btnBrowse.HelpString"))
        Me.btnBrowse.ImeMode = CType(resources.GetObject("btnBrowse.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnBrowse.Location = CType(resources.GetObject("btnBrowse.Location"), System.Drawing.Point)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.RightToLeft = CType(resources.GetObject("btnBrowse.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.btnBrowse, CType(resources.GetObject("btnBrowse.ShowHelp"), Boolean))
        Me.btnBrowse.Size = CType(resources.GetObject("btnBrowse.Size"), System.Drawing.Size)
        Me.btnBrowse.TabIndex = CType(resources.GetObject("btnBrowse.TabIndex"), Integer)
        Me.btnBrowse.Text = resources.GetString("btnBrowse.Text")
        Me.btnBrowse.ToolTip = resources.GetString("btnBrowse.ToolTip")
        Me.btnBrowse.ToolTipIconType = CType(resources.GetObject("btnBrowse.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.btnBrowse.ToolTipTitle = resources.GetString("btnBrowse.ToolTipTitle")
        Me.btnBrowse.Visible = CType(resources.GetObject("btnBrowse.Visible"), Boolean)
        '
        'frmEDocSearch_Browse
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
        Me.Name = "frmEDocSearch_Browse"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.TabParameters.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpOperator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)

    End Sub

#End Region
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim PreviousSQL As String = ""

    Public Sub LoadBKComboSet()
        Try
            GetCombo(objDS1, "EDocTypeView1", "CodeValue", "SELECT * FROM EDocTypeView1")
            GetCombo(objDS1, "EDocCategoryView1", "CodeValue", "SELECT * FROM EDocCategoryView1")
            GetCombo(objDS1, "EDocSearchOperatorVIEW1", "CodeDesc", "SELECT * FROM EDocSearchOperatorVIEW1")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overrides Sub LoadDataSet()

        Dim _WhereTxt As String = ""
        Dim _WhereTxtKey As String = ""
        Dim _Row As DataRow
        Dim _PreviousSQL As String = ""

        GridView2.CloseEditor()
        GridView2.UpdateCurrentRow()
        objDS.Tables(TableName).Clear()
        PreviousSQL = ""

        If txtName.Text & "" <> "" Then
            If _WhereTxt & "" <> "" Then _WhereTxt += " AND "
            _WhereTxt += " Name Like '%" & txtName.Text & "%' "
        End If
        If txtDescription.Text & "" <> "" Then
            If _WhereTxt & "" <> "" Then _WhereTxt += " AND "
            _WhereTxt += " Description Like '%" & txtDescription.Text & "%' "
        End If
        If txtPath.Text & "" <> "" Then
            If _WhereTxt & "" <> "" Then _WhereTxt += " AND "
            _WhereTxt += " EDocPath = '" & txtPath.Text & "' "
        End If
        If cmbCategory.EditValue & "" <> "" Then
            If _WhereTxt & "" <> "" Then _WhereTxt += " AND "
            _WhereTxt += " EDocCategoryID = '" & cmbCategory.EditValue & "'"
        End If
        If cmbType.EditValue & "" <> "" Then
            If _WhereTxt & "" <> "" Then _WhereTxt += " AND "
            _WhereTxt += " EDocTypeID = '" & cmbType.EditValue & "'"
        End If
        For Each _Row In objDS.Tables("EDocKeywordSearch").Rows
            If _WhereTxtKey & "" <> "" Then _WhereTxtKey += " OR "
            _WhereTxtKey += " KeyWord " & _Row.Item("Operator") & " '" & _Row.Item("KeyWord") & "' "
        Next
        If _WhereTxtKey & "" <> "" Then
            If _WhereTxt & "" <> "" Then
                _WhereTxt += " AND ( " & _WhereTxtKey & ") "
            Else
                _WhereTxt += " ( " & _WhereTxtKey & ") "
            End If
        End If
        'OleDbDataAdapter1.SelectCommand.CommandText = SQLTxt1
        'Select Case RadioSummurize.EditValue
        '    Case 0 'Search in Current Result
        '        If PreviousSQL & "" <> "" Then
        '            _PreviousSQL = " WHERE " & _WhereTxt & " AND EDocID IN ( SELECT EDocID from EDocSearchView1 " & PreviousSQL.Replace("SELECT *", "SELECT EDocID")
        '        Else
        '            _PreviousSQL = " WHERE " & _WhereTxt & " ) "
        '        End If
        '        _WhereTxt = " SELECT * FROM EDocSearchView1 WHERE " & _WhereTxt & " AND EDocID IN ( SELECT * from EDocSearchView1 " & PreviousSQL.Replace("SELECT *", "SELECT EDocID")
        '        PreviousSQL = _PreviousSQL
        '    Case 1 'Replace ResultSet
        '        If _WhereTxt & "" = "" Then
        '            PreviousSQL = " "
        '            _WhereTxt = " SELECT * FROM EDocSearchView1 "
        '        Else
        '            PreviousSQL = " WHERE " & _WhereTxt & " )"
        '            _WhereTxt = " SELECT * FROM EDocSearchView1 WHERE " & _WhereTxt
        '        End If
        '    Case 2 'Append to ResultSet
        '        If PreviousSQL & "" <> "" Then
        '            _PreviousSQL = " WHERE " & _WhereTxt & " ) UNION ALL  " & " ( SELECT * from EDocSearchView1 " & PreviousSQL.Replace("SELECT EDocID", "SELECT *")
        '        Else
        '            _PreviousSQL = " WHERE " & _WhereTxt & " ) "
        '        End If
        '        _WhereTxt = " ( SELECT * FROM EDocSearchView1 WHERE " & _WhereTxt & " ) UNION ALL  " & " ( SELECT * from EDocSearchView1 " & PreviousSQL.Replace("SELECT EDocID", "SELECT *")
        '        PreviousSQL = _PreviousSQL
        'End Select
        If _WhereTxt & "" <> "" Then
            _WhereTxt = " WHERE " & _WhereTxt
        Else
            _WhereTxt = " "
        End If
        Dim _SQLTxtAll As String = SQLTxt1
        'PreviousSQL = _WhereTxt
        BKFilter.ApplyFilter(_SQLTxtAll, IsFiltered, CurrentFilterID, _WhereTxt, StatusBar1.Panels(1))
        Cls1.FillDataSet(objDS.Tables(TableName), _SQLTxtAll)
        'Cls1.FillDataSet(objDS.Tables(TableName), _WhereTxt)
        TabControl1.SelectedTabPage = TabResult
    End Sub

    Public Overridable Sub frm_LocalLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objDS = objDS1
        TabParameters.PageVisible = True
        TableName = "EDocSearchView1"
        IDField = "EDocID"
        NameField = "Name"
        MaintenanceMenuID = -1
        LoadBKComboSet()
        SQLTxt1 = "SELECT * FROM " & TableName & " "
        MyBase.StartUp()
        BKGlobal.SetToolBar(BarManager1, Me.Tag, False, False, False, False)

        CurrentDefaultSetID = cmbDefaultList.EditValue

        If CurrentDefaultSetID <> 0 Then
            BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
            LoadDataSet()
            TabControl1.SelectedTabPage = TabResult
        Else
            TabControl1.SelectedTabPage = TabParameters
        End If

        'Try
        '    HelpProvider1.HelpNamespace = ".\Help\" & SessionInfo.UserLang & "\BizzKeys.chm"
        '    SQLTxt1 = OleDbDataAdapter1.SelectCommand.CommandText
        '    CurrentFilterID = BKFilter.FindDefaultFilter(SessionInfo.UserID, Me.Tag)
        '    LoadBKComboSet()
        '    BKGlobal.LoadAssociatedMenu(Me.Tag, PopMenuAssociatedTasks, Me)
        '    CurrentBrowseViewID = BKBrowseView.LoadDefaultBrowseViewDefinition(SessionInfo.UserID, Me.Tag, TableName, GridView1, StatusBar1.Panels(0))
        '    BKGlobal.SetQueryBrowseToolBar(ToolBar1, Me.Tag, False, False, False, False, , , , , , True)
        'Catch eLoad As System.Exception
        '    'Add your error handling code here.
        '    'Display error message, if any.
        '    System.Windows.Forms.MessageBox.Show(eLoad.Message)
        'End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadDataSet()
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        objDS.Tables("EDocKeywordSearch").Clear()
    End Sub
    
    Private Sub btnView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ViewPDFFile()
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        ViewPDFFile()
    End Sub
    Private Sub ViewPDFFile()
        Dim p As New System.Diagnostics.ProcessStartInfo
        Dim _FileName As String
        Dim _Path As String
        If GridView1.FocusedRowHandle < 0 Then Exit Sub
        _FileName = GridView1.GetDataRow(GridView1.FocusedRowHandle).Item("Name")
        _Path = GridView1.GetDataRow(GridView1.FocusedRowHandle).Item("EDocPath")
        p.FileName = _Path & "\" & _FileName
        p.UseShellExecute = True
        System.Diagnostics.Process.Start(p)
    End Sub

    Private Sub btnBrowse_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        If Not System.IO.Directory.Exists(FolderBrowserDialog1.RootFolder) Then
            FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        End If
        Dim result As DialogResult = FolderBrowserDialog1.ShowDialog(Me)
        If result = DialogResult.OK Then
            txtPath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
End Class
