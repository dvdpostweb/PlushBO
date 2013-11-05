Public Class frmSales_Browse
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
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSales_Browse))
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabParameters.SuspendLayout()
        Me.TabChart.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        Me.TabResult.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Name = "Panel1"
        Me.HelpProvider1.SetShowHelp(Me.Panel1, CType(resources.GetObject("Panel1.ShowHelp"), Boolean))
        '
        'StatusBar1
        '
        Me.StatusBar1.Name = "StatusBar1"
        Me.HelpProvider1.SetShowHelp(Me.StatusBar1, CType(resources.GetObject("StatusBar1.ShowHelp"), Boolean))
        '
        'GridView1
        '
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowBands = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.Name = "TabControl1"
        Me.HelpProvider1.SetShowHelp(Me.TabControl1, CType(resources.GetObject("TabControl1.ShowHelp"), Boolean))
        Me.TabControl1.Size = CType(resources.GetObject("TabControl1.Size"), System.Drawing.Size)
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
        Me.Grid1.EmbeddedNavigator.SuperTip = CType(resources.GetObject("Grid1.EmbeddedNavigator.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.Grid1.EmbeddedNavigator.Text = resources.GetString("Grid1.EmbeddedNavigator.Text")
        Me.Grid1.EmbeddedNavigator.TextLocation = CType(resources.GetObject("Grid1.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.Grid1.EmbeddedNavigator.TextStringFormat = resources.GetString("Grid1.EmbeddedNavigator.TextStringFormat")
        Me.Grid1.EmbeddedNavigator.ToolTip = resources.GetString("Grid1.EmbeddedNavigator.ToolTip")
        Me.Grid1.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("Grid1.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.Grid1.EmbeddedNavigator.ToolTipTitle = resources.GetString("Grid1.EmbeddedNavigator.ToolTipTitle")
        Me.Grid1.Name = "Grid1"
        Me.HelpProvider1.SetShowHelp(Me.Grid1, CType(resources.GetObject("Grid1.ShowHelp"), Boolean))
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.LabelControl2)
        Me.TabParameters.Controls.Add(Me.LabelControl1)
        Me.TabParameters.Controls.Add(Me.txtToDate)
        Me.TabParameters.Controls.Add(Me.txtFromDate)
        Me.TabParameters.Name = "TabParameters"
        '
        'TabChart
        '
        Me.TabChart.Name = "TabChart"
        Me.TabChart.Size = CType(resources.GetObject("TabChart.Size"), System.Drawing.Size)
        '
        'UcChart1
        '
        Me.UcChart1.Name = "UcChart1"
        Me.UcChart1.Size = CType(resources.GetObject("UcChart1.Size"), System.Drawing.Size)
        '
        'UcPivotGrid1
        '
        Me.UcPivotGrid1.Name = "UcPivotGrid1"
        Me.UcPivotGrid1.Size = CType(resources.GetObject("UcPivotGrid1.Size"), System.Drawing.Size)
        '
        'TabAnalyse
        '
        Me.TabAnalyse.Name = "TabAnalyse"
        Me.TabAnalyse.Size = CType(resources.GetObject("TabAnalyse.Size"), System.Drawing.Size)
        '
        'TabResult
        '
        Me.TabResult.Name = "TabResult"
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
        'QuickSearch_Bar
        '
        Me.QuickSearch_Bar.DockCol = 2
        '
        'Report_Bar
        '
        Me.Report_Bar.DockRow = 1
        Me.Report_Bar.Offset = 475
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
        'Filter_Bar
        '
        Me.Filter_Bar.DockCol = 1
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
        'DefaultSet_Bar
        '
        Me.DefaultSet_Bar.Offset = 3
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
        'Misc_Bar2
        '
        Me.Misc_Bar2.DockRow = 1
        Me.Misc_Bar2.Offset = 720
        '
        'Nav_Bar
        '
        Me.Nav_Bar.DockCol = 1
        Me.Nav_Bar.Offset = 195
        '
        'Main_Bar
        '
        Me.Main_Bar.DockCol = 0
        Me.Main_Bar.Offset = 41
        '
        'Misc_Bar
        '
        Me.Misc_Bar.DockCol = 3
        Me.Misc_Bar.Offset = 682
        '
        'View_Bar
        '
        Me.View_Bar.DockCol = 4
        '
        'txtFromDate
        '
        Me.txtFromDate.Anchor = CType(resources.GetObject("txtFromDate.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtFromDate.BackgroundImage = CType(resources.GetObject("txtFromDate.BackgroundImage"), System.Drawing.Image)
        Me.txtFromDate.Dock = CType(resources.GetObject("txtFromDate.Dock"), System.Windows.Forms.DockStyle)
        Me.txtFromDate.EditValue = CType(resources.GetObject("txtFromDate.EditValue"), Object)
        Me.txtFromDate.Enabled = CType(resources.GetObject("txtFromDate.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.txtFromDate, resources.GetString("txtFromDate.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtFromDate, CType(resources.GetObject("txtFromDate.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtFromDate, resources.GetString("txtFromDate.HelpString"))
        Me.txtFromDate.ImeMode = CType(resources.GetObject("txtFromDate.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtFromDate.Location = CType(resources.GetObject("txtFromDate.Location"), System.Drawing.Point)
        Me.txtFromDate.Name = "txtFromDate"
        '
        'txtFromDate.Properties
        '
        Me.txtFromDate.Properties.AccessibleDescription = resources.GetString("txtFromDate.Properties.AccessibleDescription")
        Me.txtFromDate.Properties.AccessibleName = resources.GetString("txtFromDate.Properties.AccessibleName")
        Me.txtFromDate.Properties.AutoHeight = CType(resources.GetObject("txtFromDate.Properties.AutoHeight"), Boolean)
        Me.txtFromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFromDate.Properties.Mask.AutoComplete = CType(resources.GetObject("txtFromDate.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtFromDate.Properties.Mask.BeepOnError = CType(resources.GetObject("txtFromDate.Properties.Mask.BeepOnError"), Boolean)
        Me.txtFromDate.Properties.Mask.EditMask = resources.GetString("txtFromDate.Properties.Mask.EditMask")
        Me.txtFromDate.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtFromDate.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtFromDate.Properties.Mask.MaskType = CType(resources.GetObject("txtFromDate.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtFromDate.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtFromDate.Properties.Mask.PlaceHolder"), Char)
        Me.txtFromDate.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtFromDate.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtFromDate.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtFromDate.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtFromDate.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtFromDate.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtFromDate.Properties.NullText = resources.GetString("txtFromDate.Properties.NullText")
        Me.txtFromDate.RightToLeft = CType(resources.GetObject("txtFromDate.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.txtFromDate, CType(resources.GetObject("txtFromDate.ShowHelp"), Boolean))
        Me.txtFromDate.Size = CType(resources.GetObject("txtFromDate.Size"), System.Drawing.Size)
        Me.txtFromDate.SuperTip = CType(resources.GetObject("txtFromDate.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtFromDate.TabIndex = CType(resources.GetObject("txtFromDate.TabIndex"), Integer)
        Me.txtFromDate.ToolTip = resources.GetString("txtFromDate.ToolTip")
        Me.txtFromDate.ToolTipIconType = CType(resources.GetObject("txtFromDate.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtFromDate.ToolTipTitle = resources.GetString("txtFromDate.ToolTipTitle")
        Me.txtFromDate.Visible = CType(resources.GetObject("txtFromDate.Visible"), Boolean)
        '
        'txtToDate
        '
        Me.txtToDate.Anchor = CType(resources.GetObject("txtToDate.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtToDate.BackgroundImage = CType(resources.GetObject("txtToDate.BackgroundImage"), System.Drawing.Image)
        Me.txtToDate.Dock = CType(resources.GetObject("txtToDate.Dock"), System.Windows.Forms.DockStyle)
        Me.txtToDate.EditValue = CType(resources.GetObject("txtToDate.EditValue"), Object)
        Me.txtToDate.Enabled = CType(resources.GetObject("txtToDate.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.txtToDate, resources.GetString("txtToDate.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtToDate, CType(resources.GetObject("txtToDate.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtToDate, resources.GetString("txtToDate.HelpString"))
        Me.txtToDate.ImeMode = CType(resources.GetObject("txtToDate.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtToDate.Location = CType(resources.GetObject("txtToDate.Location"), System.Drawing.Point)
        Me.txtToDate.Name = "txtToDate"
        '
        'txtToDate.Properties
        '
        Me.txtToDate.Properties.AccessibleDescription = resources.GetString("txtToDate.Properties.AccessibleDescription")
        Me.txtToDate.Properties.AccessibleName = resources.GetString("txtToDate.Properties.AccessibleName")
        Me.txtToDate.Properties.AutoHeight = CType(resources.GetObject("txtToDate.Properties.AutoHeight"), Boolean)
        Me.txtToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtToDate.Properties.Mask.AutoComplete = CType(resources.GetObject("txtToDate.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtToDate.Properties.Mask.BeepOnError = CType(resources.GetObject("txtToDate.Properties.Mask.BeepOnError"), Boolean)
        Me.txtToDate.Properties.Mask.EditMask = resources.GetString("txtToDate.Properties.Mask.EditMask")
        Me.txtToDate.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtToDate.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtToDate.Properties.Mask.MaskType = CType(resources.GetObject("txtToDate.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtToDate.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtToDate.Properties.Mask.PlaceHolder"), Char)
        Me.txtToDate.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtToDate.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtToDate.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtToDate.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtToDate.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtToDate.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtToDate.Properties.NullText = resources.GetString("txtToDate.Properties.NullText")
        Me.txtToDate.RightToLeft = CType(resources.GetObject("txtToDate.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.txtToDate, CType(resources.GetObject("txtToDate.ShowHelp"), Boolean))
        Me.txtToDate.Size = CType(resources.GetObject("txtToDate.Size"), System.Drawing.Size)
        Me.txtToDate.SuperTip = CType(resources.GetObject("txtToDate.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtToDate.TabIndex = CType(resources.GetObject("txtToDate.TabIndex"), Integer)
        Me.txtToDate.ToolTip = resources.GetString("txtToDate.ToolTip")
        Me.txtToDate.ToolTipIconType = CType(resources.GetObject("txtToDate.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtToDate.ToolTipTitle = resources.GetString("txtToDate.ToolTipTitle")
        Me.txtToDate.Visible = CType(resources.GetObject("txtToDate.Visible"), Boolean)
        '
        'LabelControl1
        '
        Me.LabelControl1.AccessibleDescription = resources.GetString("LabelControl1.AccessibleDescription")
        Me.LabelControl1.AccessibleName = resources.GetString("LabelControl1.AccessibleName")
        Me.LabelControl1.Anchor = CType(resources.GetObject("LabelControl1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.AutoSizeMode = CType(resources.GetObject("LabelControl1.AutoSizeMode"), DevExpress.XtraEditors.LabelAutoSizeMode)
        Me.LabelControl1.Dock = CType(resources.GetObject("LabelControl1.Dock"), System.Windows.Forms.DockStyle)
        Me.LabelControl1.Enabled = CType(resources.GetObject("LabelControl1.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.LabelControl1, resources.GetString("LabelControl1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.LabelControl1, CType(resources.GetObject("LabelControl1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.LabelControl1, resources.GetString("LabelControl1.HelpString"))
        Me.LabelControl1.ImeMode = CType(resources.GetObject("LabelControl1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.LabelControl1.LineColor = CType(resources.GetObject("LabelControl1.LineColor"), System.Drawing.Color)
        Me.LabelControl1.Location = CType(resources.GetObject("LabelControl1.Location"), System.Drawing.Point)
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, CType(resources.GetObject("LabelControl1.ShowHelp"), Boolean))
        Me.LabelControl1.Size = CType(resources.GetObject("LabelControl1.Size"), System.Drawing.Size)
        Me.LabelControl1.SuperTip = CType(resources.GetObject("LabelControl1.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.LabelControl1.TabIndex = CType(resources.GetObject("LabelControl1.TabIndex"), Integer)
        Me.LabelControl1.Text = resources.GetString("LabelControl1.Text")
        Me.LabelControl1.ToolTip = resources.GetString("LabelControl1.ToolTip")
        Me.LabelControl1.ToolTipIconType = CType(resources.GetObject("LabelControl1.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.LabelControl1.ToolTipTitle = resources.GetString("LabelControl1.ToolTipTitle")
        Me.LabelControl1.Visible = CType(resources.GetObject("LabelControl1.Visible"), Boolean)
        '
        'LabelControl2
        '
        Me.LabelControl2.AccessibleDescription = resources.GetString("LabelControl2.AccessibleDescription")
        Me.LabelControl2.AccessibleName = resources.GetString("LabelControl2.AccessibleName")
        Me.LabelControl2.Anchor = CType(resources.GetObject("LabelControl2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.AutoSizeMode = CType(resources.GetObject("LabelControl2.AutoSizeMode"), DevExpress.XtraEditors.LabelAutoSizeMode)
        Me.LabelControl2.Dock = CType(resources.GetObject("LabelControl2.Dock"), System.Windows.Forms.DockStyle)
        Me.LabelControl2.Enabled = CType(resources.GetObject("LabelControl2.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.LabelControl2, resources.GetString("LabelControl2.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.LabelControl2, CType(resources.GetObject("LabelControl2.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.LabelControl2, resources.GetString("LabelControl2.HelpString"))
        Me.LabelControl2.ImeMode = CType(resources.GetObject("LabelControl2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.LabelControl2.LineColor = CType(resources.GetObject("LabelControl2.LineColor"), System.Drawing.Color)
        Me.LabelControl2.Location = CType(resources.GetObject("LabelControl2.Location"), System.Drawing.Point)
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, CType(resources.GetObject("LabelControl2.ShowHelp"), Boolean))
        Me.LabelControl2.Size = CType(resources.GetObject("LabelControl2.Size"), System.Drawing.Size)
        Me.LabelControl2.SuperTip = CType(resources.GetObject("LabelControl2.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.LabelControl2.TabIndex = CType(resources.GetObject("LabelControl2.TabIndex"), Integer)
        Me.LabelControl2.Text = resources.GetString("LabelControl2.Text")
        Me.LabelControl2.ToolTip = resources.GetString("LabelControl2.ToolTip")
        Me.LabelControl2.ToolTipIconType = CType(resources.GetObject("LabelControl2.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.LabelControl2.ToolTipTitle = resources.GetString("LabelControl2.ToolTipTitle")
        Me.LabelControl2.Visible = CType(resources.GetObject("LabelControl2.Visible"), Boolean)
        '
        'frmSales_Browse
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
        Me.Name = "frmSales_Browse"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabParameters.ResumeLayout(False)
        Me.TabChart.ResumeLayout(False)
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabResult.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim menuStrip As New dvdpostbuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip


        objDS = New dsPur_Sls
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        txtFromDate.EditValue = Today.AddDays(-7)
        txtToDate.EditValue = Today
        MyBase.TableName = "shopping_orders_view1"
        MyBase.IDField = "shopping_orders_id"
        MyBase.NameField = "shopping_orders_id"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = False
        MyBase.StartUp()
        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , , False, False, True)
        CurrentDefaultSetID = cmbDefaultList.EditValue
        'btnOK
        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If CurrentDefaultSetID <> 0 Then
            BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
            'LoadDataSet()
            'TabControl1.SelectedTabPage = TabResult
        Else
            'TabControl1.SelectedTabPage = TabParameters
        End If
        TabControl1.SelectedTabPage = TabParameters
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub
    Public Overrides Sub LoadDataSet()
        Dim _SQLTxt As String

        'Clear Table
        Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue) & " 00:00:00"
        Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue) & " 23:59:59"

        objDS.Tables(TableName).Clear()
        _SQLTxt = " SELECT s.shopping_orders_id, s.customers_id, s.`date` as order_date, s.products_id, s.quantity, s.`status` as order_status, " & _
                  " sdvd.dvd_id, s.price, s.discount_code_id, c.* ,  " & _
                  " ab.entry_street_address as customers_street_address, ab.entry_postcode as customers_postcode, ab.entry_city as customers_city, " & _
                  " ab.entry_country_id as customers_country_id, ctry.countries_name as customers_country,  " & _
                  " p.products_model, p.products_type, p.products_media, p.products_status, pd.products_dvd_status, " & _
                  " pd.box_id, pd.pibox_id, pd.`inout`, s.products_type, s.products_state " & _
                  " FROM shopping_orders s " & _
                  " left join shopping_orders_dvd_id sdvd on sdvd.shopping_orders_id = s.shopping_orders_id and sdvd.products_id = s.products_id " & _
                  " left join customers c on c.customers_id = s.customers_id " & _
                  " left join address_book ab on ab.address_book_id = c.customers_default_address_id and ab.customers_id = c.customers_id " & _
                  " left join countries ctry on ctry.countries_id = ab.entry_country_id " & _
                  " left join products p on p.products_id = s.products_id " & _
                  " left join products_dvd pd on pd.products_id = s.products_id and pd.products_dvdid = sdvd.dvd_id " & _
                  " where s.status <> 1 and `date` >= '" & _DateFromTxt & "' and `date` <= '" & _DateToTxt & "'"

        ' c.customers_firstname, c.customers_lastname, c.EntityID, c.customers_gender, " & _
        ' " c.customers_email_address, c.customers_default_address_id
        DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)
        ''Set the quantity_assigned
        'Dim _row As DataRow
        'Dim _RowView As DataRowView
        Dim _View As DataView
        'Dim _TmpTable As New DataTable("TmpTable")
        '_SQLTxt = "select s.shopping_orders_id, s.quantity, count(*) as cnt from shopping_orders s " & _
        '          " left join shopping_orders_dvd_id sdvd on s.shopping_orders_id = sdvd.shopping_orders_id and " & _
        '          " s.products_id = sdvd.products_id where s.`status` = 1 group by s.shopping_orders_id"
        ' DvdPostData.clsConnection.FillDataSet(_TmpTable, _SQLTxt)
        '_View = New DataView(_TmpTable, "", "shopping_orders_id", DataViewRowState.CurrentRows)
        'For Each _row In objDS.Tables(TableName).Rows
        '    _i = _View.Find(New Object() {_row("shopping_orders_id")})
        '    If _i <> -1 Then
        '        _RowView = _View(_i)
        '        If Not IsNothing(_RowView) Then
        '            _row("quantity_assigned") = _RowView("cnt")
        '        Else
        '            _row("quantity_assigned") = 0
        '        End If
        '        '_row("quantity_assigned") = BKGlobal.ExecuteCount("select count(*) as cnt from shopping_orders_dvd_id where shopping_orders_id = " & _
        '        '           _row("shopping_orders_id") & " AND products_id = " & _row("products_id"))
        '    End If
        'Next
        Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        _View = New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
        TabControl1.SelectedTabPage = TabResult
    End Sub
    Public Overrides Sub gridview1_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles GridView1.DoubleClick
        Dim _frm As New frmModifyShoppingOrder(SessionInfo)
        Dim _Orders_ID As Integer
        Dim _customers_id As Integer
        Dim _products_id As Integer
        Dim _dvd_id As Integer
        Dim _i As Integer = GridView1.FocusedRowHandle
        _Orders_ID = GridView1.GetDataRow(_i)("shopping_orders_id")
        _customers_id = GridView1.GetDataRow(_i)("customers_id")
        _products_id = GridView1.GetDataRow(_i)("products_id")
        If GridView1.GetDataRow(_i)("quantity_assigned") <> GridView1.GetDataRow(_i)("quantity") Then
            MsgBox("You must assign DVD first.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If IsDBNull(GridView1.GetDataRow(_i)("dvd_id")) Then
            _dvd_id = -1
        Else
            _dvd_id = GridView1.GetDataRow(_i)("dvd_id")
        End If
        _frm.txtOrderID.EditValue = _Orders_ID
        _frm.txtDVDId.EditValue = _dvd_id
        _frm.txtCoverBoxID.EditValue = GridView1.GetDataRow(_i)("cover_box_id")
        _frm.SearchOrderInfo(False)
        _frm.ShowDialog(Me)
    End Sub
End Class
