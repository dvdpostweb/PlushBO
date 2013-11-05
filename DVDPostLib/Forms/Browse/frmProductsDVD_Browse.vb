Public Class frmProductsDVD_Browse
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLimit As System.Windows.Forms.TextBox
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkSubTitles As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkLanguages As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkCategories As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkActors As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFromID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtToID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents spinProcessing As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProductsDVD_Browse))
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLimit = New System.Windows.Forms.TextBox
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.chkActors = New DevExpress.XtraEditors.CheckEdit
        Me.chkCategories = New DevExpress.XtraEditors.CheckEdit
        Me.chkSubTitles = New DevExpress.XtraEditors.CheckEdit
        Me.chkLanguages = New DevExpress.XtraEditors.CheckEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtToID = New DevExpress.XtraEditors.TextEdit
        Me.txtFromID = New DevExpress.XtraEditors.TextEdit
        Me.spinProcessing = New DevExpress.XtraEditors.SpinEdit
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabParameters.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabResult.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabChart.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.chkActors.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCategories.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSubTitles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLanguages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtToID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinProcessing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowBands = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = CType(resources.GetObject("StatusBar1.Location"), System.Drawing.Point)
        Me.StatusBar1.Name = "StatusBar1"
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.Label1)
        Me.TabParameters.Controls.Add(Me.spinProcessing)
        Me.TabParameters.Controls.Add(Me.GroupControl1)
        Me.TabParameters.Controls.Add(Me.GroupControl2)
        Me.TabParameters.Controls.Add(Me.Label6)
        Me.TabParameters.Controls.Add(Me.txtLimit)
        Me.TabParameters.Name = "TabParameters"
        Me.TabParameters.Size = CType(resources.GetObject("TabParameters.Size"), System.Drawing.Size)
        '
        'Panel1
        '
        Me.Panel1.Location = CType(resources.GetObject("Panel1.Location"), System.Drawing.Point)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = CType(resources.GetObject("Panel1.Size"), System.Drawing.Size)
        '
        'TabResult
        '
        Me.TabResult.Name = "TabResult"
        Me.TabResult.Size = CType(resources.GetObject("TabResult.Size"), System.Drawing.Size)
        '
        'TabAnalyse
        '
        Me.TabAnalyse.Name = "TabAnalyse"
        Me.TabAnalyse.Size = CType(resources.GetObject("TabAnalyse.Size"), System.Drawing.Size)
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
        Me.Grid1.Size = CType(resources.GetObject("Grid1.Size"), System.Drawing.Size)
        '
        'UcPivotGrid1
        '
        Me.UcPivotGrid1.Name = "UcPivotGrid1"
        Me.UcPivotGrid1.Size = CType(resources.GetObject("UcPivotGrid1.Size"), System.Drawing.Size)
        '
        'UcChart1
        '
        Me.UcChart1.Name = "UcChart1"
        Me.UcChart1.Size = CType(resources.GetObject("UcChart1.Size"), System.Drawing.Size)
        '
        'TabChart
        '
        Me.TabChart.Name = "TabChart"
        Me.TabChart.Size = CType(resources.GetObject("TabChart.Size"), System.Drawing.Size)
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = CType(resources.GetObject("TabControl1.Size"), System.Drawing.Size)
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
        'QuickSearch_Bar
        '
        Me.QuickSearch_Bar.DockCol = 2
        '
        'View_Bar
        '
        Me.View_Bar.DockCol = 3
        '
        'Misc_Bar
        '
        Me.Misc_Bar.DockCol = 1
        Me.Misc_Bar.Offset = 168
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
        'Report_Bar
        '
        Me.Report_Bar.DockCol = 6
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
        'Main_Bar
        '
        Me.Main_Bar.DockCol = 0
        Me.Main_Bar.Offset = 20
        '
        'Filter_Bar
        '
        Me.Filter_Bar.DockCol = 0
        Me.Filter_Bar.Offset = 1
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
        Me.DefaultSet_Bar.DockCol = 1
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
        Me.Misc_Bar2.DockCol = 4
        '
        'Nav_Bar
        '
        Me.Nav_Bar.DockCol = 5
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = resources.GetString("Label6.AccessibleDescription")
        Me.Label6.AccessibleName = resources.GetString("Label6.AccessibleName")
        Me.Label6.Anchor = CType(resources.GetObject("Label6.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = CType(resources.GetObject("Label6.AutoSize"), Boolean)
        Me.Label6.Dock = CType(resources.GetObject("Label6.Dock"), System.Windows.Forms.DockStyle)
        Me.Label6.Enabled = CType(resources.GetObject("Label6.Enabled"), Boolean)
        Me.Label6.Font = CType(resources.GetObject("Label6.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.Label6, resources.GetString("Label6.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.Label6, CType(resources.GetObject("Label6.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.Label6, resources.GetString("Label6.HelpString"))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.ImageAlign = CType(resources.GetObject("Label6.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label6.ImageIndex = CType(resources.GetObject("Label6.ImageIndex"), Integer)
        Me.Label6.ImeMode = CType(resources.GetObject("Label6.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label6.Location = CType(resources.GetObject("Label6.Location"), System.Drawing.Point)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = CType(resources.GetObject("Label6.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.Label6, CType(resources.GetObject("Label6.ShowHelp"), Boolean))
        Me.Label6.Size = CType(resources.GetObject("Label6.Size"), System.Drawing.Size)
        Me.Label6.TabIndex = CType(resources.GetObject("Label6.TabIndex"), Integer)
        Me.Label6.Text = resources.GetString("Label6.Text")
        Me.Label6.TextAlign = CType(resources.GetObject("Label6.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label6.Visible = CType(resources.GetObject("Label6.Visible"), Boolean)
        '
        'txtLimit
        '
        Me.txtLimit.AccessibleDescription = resources.GetString("txtLimit.AccessibleDescription")
        Me.txtLimit.AccessibleName = resources.GetString("txtLimit.AccessibleName")
        Me.txtLimit.Anchor = CType(resources.GetObject("txtLimit.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtLimit.AutoSize = CType(resources.GetObject("txtLimit.AutoSize"), Boolean)
        Me.txtLimit.BackgroundImage = CType(resources.GetObject("txtLimit.BackgroundImage"), System.Drawing.Image)
        Me.txtLimit.Dock = CType(resources.GetObject("txtLimit.Dock"), System.Windows.Forms.DockStyle)
        Me.txtLimit.Enabled = CType(resources.GetObject("txtLimit.Enabled"), Boolean)
        Me.txtLimit.Font = CType(resources.GetObject("txtLimit.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.txtLimit, resources.GetString("txtLimit.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtLimit, CType(resources.GetObject("txtLimit.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtLimit, resources.GetString("txtLimit.HelpString"))
        Me.txtLimit.ImeMode = CType(resources.GetObject("txtLimit.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtLimit.Location = CType(resources.GetObject("txtLimit.Location"), System.Drawing.Point)
        Me.txtLimit.MaxLength = CType(resources.GetObject("txtLimit.MaxLength"), Integer)
        Me.txtLimit.Multiline = CType(resources.GetObject("txtLimit.Multiline"), Boolean)
        Me.txtLimit.Name = "txtLimit"
        Me.txtLimit.PasswordChar = CType(resources.GetObject("txtLimit.PasswordChar"), Char)
        Me.txtLimit.RightToLeft = CType(resources.GetObject("txtLimit.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtLimit.ScrollBars = CType(resources.GetObject("txtLimit.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.HelpProvider1.SetShowHelp(Me.txtLimit, CType(resources.GetObject("txtLimit.ShowHelp"), Boolean))
        Me.txtLimit.Size = CType(resources.GetObject("txtLimit.Size"), System.Drawing.Size)
        Me.txtLimit.TabIndex = CType(resources.GetObject("txtLimit.TabIndex"), Integer)
        Me.txtLimit.Text = resources.GetString("txtLimit.Text")
        Me.txtLimit.TextAlign = CType(resources.GetObject("txtLimit.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtLimit.Visible = CType(resources.GetObject("txtLimit.Visible"), Boolean)
        Me.txtLimit.WordWrap = CType(resources.GetObject("txtLimit.WordWrap"), Boolean)
        '
        'GroupControl2
        '
        Me.GroupControl2.AccessibleDescription = resources.GetString("GroupControl2.AccessibleDescription")
        Me.GroupControl2.AccessibleName = resources.GetString("GroupControl2.AccessibleName")
        Me.GroupControl2.Anchor = CType(resources.GetObject("GroupControl2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AutoScrollMargin = CType(resources.GetObject("GroupControl2.AutoScrollMargin"), System.Drawing.Size)
        Me.GroupControl2.AutoScrollMinSize = CType(resources.GetObject("GroupControl2.AutoScrollMinSize"), System.Drawing.Size)
        Me.GroupControl1.Appearance.Image = CType(resources.GetObject("GroupControl2.BackgroundImage"), System.Drawing.Image)
        Me.GroupControl2.Controls.Add(Me.chkActors)
        Me.GroupControl2.Controls.Add(Me.chkCategories)
        Me.GroupControl2.Controls.Add(Me.chkSubTitles)
        Me.GroupControl2.Controls.Add(Me.chkLanguages)
        Me.GroupControl2.Dock = CType(resources.GetObject("GroupControl2.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupControl2.Enabled = CType(resources.GetObject("GroupControl2.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.GroupControl2, resources.GetString("GroupControl2.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.GroupControl2, CType(resources.GetObject("GroupControl2.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.GroupControl2, resources.GetString("GroupControl2.HelpString"))
        Me.GroupControl2.ImeMode = CType(resources.GetObject("GroupControl2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupControl2.Location = CType(resources.GetObject("GroupControl2.Location"), System.Drawing.Point)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.RightToLeft = CType(resources.GetObject("GroupControl2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.GroupControl2, CType(resources.GetObject("GroupControl2.ShowHelp"), Boolean))
        Me.GroupControl2.Size = CType(resources.GetObject("GroupControl2.Size"), System.Drawing.Size)
        Me.GroupControl2.TabIndex = CType(resources.GetObject("GroupControl2.TabIndex"), Integer)
        Me.GroupControl2.Text = resources.GetString("GroupControl2.Text")
        Me.GroupControl2.Visible = CType(resources.GetObject("GroupControl2.Visible"), Boolean)
        '
        'chkActors
        '
        Me.chkActors.Anchor = CType(resources.GetObject("chkActors.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkActors.BackgroundImage = CType(resources.GetObject("chkActors.BackgroundImage"), System.Drawing.Image)
        Me.chkActors.Dock = CType(resources.GetObject("chkActors.Dock"), System.Windows.Forms.DockStyle)
        Me.chkActors.EditValue = CType(resources.GetObject("chkActors.EditValue"), Object)
        Me.chkActors.Enabled = CType(resources.GetObject("chkActors.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.chkActors, resources.GetString("chkActors.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.chkActors, CType(resources.GetObject("chkActors.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.chkActors, resources.GetString("chkActors.HelpString"))
        Me.chkActors.ImeMode = CType(resources.GetObject("chkActors.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkActors.Location = CType(resources.GetObject("chkActors.Location"), System.Drawing.Point)
        Me.chkActors.Name = "chkActors"
        '
        'chkActors.Properties
        '
        Me.chkActors.Properties.AccessibleDescription = resources.GetString("chkActors.Properties.AccessibleDescription")
        Me.chkActors.Properties.AccessibleName = resources.GetString("chkActors.Properties.AccessibleName")
        Me.chkActors.Properties.AutoHeight = CType(resources.GetObject("chkActors.Properties.AutoHeight"), Boolean)
        Me.chkActors.Properties.Caption = resources.GetString("chkActors.Properties.Caption")
        Me.chkActors.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkActors.Properties.NullText = resources.GetString("chkActors.Properties.NullText")
        Me.chkActors.RightToLeft = CType(resources.GetObject("chkActors.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.chkActors, CType(resources.GetObject("chkActors.ShowHelp"), Boolean))
        Me.chkActors.Size = CType(resources.GetObject("chkActors.Size"), System.Drawing.Size)
        Me.chkActors.SuperTip = CType(resources.GetObject("chkActors.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.chkActors.TabIndex = CType(resources.GetObject("chkActors.TabIndex"), Integer)
        Me.chkActors.ToolTip = resources.GetString("chkActors.ToolTip")
        Me.chkActors.ToolTipIconType = CType(resources.GetObject("chkActors.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.chkActors.ToolTipTitle = resources.GetString("chkActors.ToolTipTitle")
        Me.chkActors.Visible = CType(resources.GetObject("chkActors.Visible"), Boolean)
        '
        'chkCategories
        '
        Me.chkCategories.Anchor = CType(resources.GetObject("chkCategories.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkCategories.BackgroundImage = CType(resources.GetObject("chkCategories.BackgroundImage"), System.Drawing.Image)
        Me.chkCategories.Dock = CType(resources.GetObject("chkCategories.Dock"), System.Windows.Forms.DockStyle)
        Me.chkCategories.EditValue = CType(resources.GetObject("chkCategories.EditValue"), Object)
        Me.chkCategories.Enabled = CType(resources.GetObject("chkCategories.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.chkCategories, resources.GetString("chkCategories.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.chkCategories, CType(resources.GetObject("chkCategories.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.chkCategories, resources.GetString("chkCategories.HelpString"))
        Me.chkCategories.ImeMode = CType(resources.GetObject("chkCategories.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkCategories.Location = CType(resources.GetObject("chkCategories.Location"), System.Drawing.Point)
        Me.chkCategories.Name = "chkCategories"
        '
        'chkCategories.Properties
        '
        Me.chkCategories.Properties.AccessibleDescription = resources.GetString("chkCategories.Properties.AccessibleDescription")
        Me.chkCategories.Properties.AccessibleName = resources.GetString("chkCategories.Properties.AccessibleName")
        Me.chkCategories.Properties.AutoHeight = CType(resources.GetObject("chkCategories.Properties.AutoHeight"), Boolean)
        Me.chkCategories.Properties.Caption = resources.GetString("chkCategories.Properties.Caption")
        Me.chkCategories.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkCategories.Properties.NullText = resources.GetString("chkCategories.Properties.NullText")
        Me.chkCategories.RightToLeft = CType(resources.GetObject("chkCategories.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.chkCategories, CType(resources.GetObject("chkCategories.ShowHelp"), Boolean))
        Me.chkCategories.Size = CType(resources.GetObject("chkCategories.Size"), System.Drawing.Size)
        Me.chkCategories.SuperTip = CType(resources.GetObject("chkCategories.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.chkCategories.TabIndex = CType(resources.GetObject("chkCategories.TabIndex"), Integer)
        Me.chkCategories.ToolTip = resources.GetString("chkCategories.ToolTip")
        Me.chkCategories.ToolTipIconType = CType(resources.GetObject("chkCategories.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.chkCategories.ToolTipTitle = resources.GetString("chkCategories.ToolTipTitle")
        Me.chkCategories.Visible = CType(resources.GetObject("chkCategories.Visible"), Boolean)
        '
        'chkSubTitles
        '
        Me.chkSubTitles.Anchor = CType(resources.GetObject("chkSubTitles.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkSubTitles.BackgroundImage = CType(resources.GetObject("chkSubTitles.BackgroundImage"), System.Drawing.Image)
        Me.chkSubTitles.Dock = CType(resources.GetObject("chkSubTitles.Dock"), System.Windows.Forms.DockStyle)
        Me.chkSubTitles.EditValue = CType(resources.GetObject("chkSubTitles.EditValue"), Object)
        Me.chkSubTitles.Enabled = CType(resources.GetObject("chkSubTitles.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.chkSubTitles, resources.GetString("chkSubTitles.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.chkSubTitles, CType(resources.GetObject("chkSubTitles.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.chkSubTitles, resources.GetString("chkSubTitles.HelpString"))
        Me.chkSubTitles.ImeMode = CType(resources.GetObject("chkSubTitles.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkSubTitles.Location = CType(resources.GetObject("chkSubTitles.Location"), System.Drawing.Point)
        Me.chkSubTitles.Name = "chkSubTitles"
        '
        'chkSubTitles.Properties
        '
        Me.chkSubTitles.Properties.AccessibleDescription = resources.GetString("chkSubTitles.Properties.AccessibleDescription")
        Me.chkSubTitles.Properties.AccessibleName = resources.GetString("chkSubTitles.Properties.AccessibleName")
        Me.chkSubTitles.Properties.AutoHeight = CType(resources.GetObject("chkSubTitles.Properties.AutoHeight"), Boolean)
        Me.chkSubTitles.Properties.Caption = resources.GetString("chkSubTitles.Properties.Caption")
        Me.chkSubTitles.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkSubTitles.Properties.NullText = resources.GetString("chkSubTitles.Properties.NullText")
        Me.chkSubTitles.RightToLeft = CType(resources.GetObject("chkSubTitles.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.chkSubTitles, CType(resources.GetObject("chkSubTitles.ShowHelp"), Boolean))
        Me.chkSubTitles.Size = CType(resources.GetObject("chkSubTitles.Size"), System.Drawing.Size)
        Me.chkSubTitles.SuperTip = CType(resources.GetObject("chkSubTitles.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.chkSubTitles.TabIndex = CType(resources.GetObject("chkSubTitles.TabIndex"), Integer)
        Me.chkSubTitles.ToolTip = resources.GetString("chkSubTitles.ToolTip")
        Me.chkSubTitles.ToolTipIconType = CType(resources.GetObject("chkSubTitles.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.chkSubTitles.ToolTipTitle = resources.GetString("chkSubTitles.ToolTipTitle")
        Me.chkSubTitles.Visible = CType(resources.GetObject("chkSubTitles.Visible"), Boolean)
        '
        'chkLanguages
        '
        Me.chkLanguages.Anchor = CType(resources.GetObject("chkLanguages.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkLanguages.BackgroundImage = CType(resources.GetObject("chkLanguages.BackgroundImage"), System.Drawing.Image)
        Me.chkLanguages.Dock = CType(resources.GetObject("chkLanguages.Dock"), System.Windows.Forms.DockStyle)
        Me.chkLanguages.EditValue = CType(resources.GetObject("chkLanguages.EditValue"), Object)
        Me.chkLanguages.Enabled = CType(resources.GetObject("chkLanguages.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.chkLanguages, resources.GetString("chkLanguages.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.chkLanguages, CType(resources.GetObject("chkLanguages.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.chkLanguages, resources.GetString("chkLanguages.HelpString"))
        Me.chkLanguages.ImeMode = CType(resources.GetObject("chkLanguages.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkLanguages.Location = CType(resources.GetObject("chkLanguages.Location"), System.Drawing.Point)
        Me.chkLanguages.Name = "chkLanguages"
        '
        'chkLanguages.Properties
        '
        Me.chkLanguages.Properties.AccessibleDescription = resources.GetString("chkLanguages.Properties.AccessibleDescription")
        Me.chkLanguages.Properties.AccessibleName = resources.GetString("chkLanguages.Properties.AccessibleName")
        Me.chkLanguages.Properties.AutoHeight = CType(resources.GetObject("chkLanguages.Properties.AutoHeight"), Boolean)
        Me.chkLanguages.Properties.Caption = resources.GetString("chkLanguages.Properties.Caption")
        Me.chkLanguages.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkLanguages.Properties.NullText = resources.GetString("chkLanguages.Properties.NullText")
        Me.chkLanguages.RightToLeft = CType(resources.GetObject("chkLanguages.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.chkLanguages, CType(resources.GetObject("chkLanguages.ShowHelp"), Boolean))
        Me.chkLanguages.Size = CType(resources.GetObject("chkLanguages.Size"), System.Drawing.Size)
        Me.chkLanguages.SuperTip = CType(resources.GetObject("chkLanguages.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.chkLanguages.TabIndex = CType(resources.GetObject("chkLanguages.TabIndex"), Integer)
        Me.chkLanguages.ToolTip = resources.GetString("chkLanguages.ToolTip")
        Me.chkLanguages.ToolTipIconType = CType(resources.GetObject("chkLanguages.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.chkLanguages.ToolTipTitle = resources.GetString("chkLanguages.ToolTipTitle")
        Me.chkLanguages.Visible = CType(resources.GetObject("chkLanguages.Visible"), Boolean)
        '
        'GroupControl1
        '
        Me.GroupControl1.AccessibleDescription = resources.GetString("GroupControl1.AccessibleDescription")
        Me.GroupControl1.AccessibleName = resources.GetString("GroupControl1.AccessibleName")
        Me.GroupControl1.Anchor = CType(resources.GetObject("GroupControl1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AutoScrollMargin = CType(resources.GetObject("GroupControl1.AutoScrollMargin"), System.Drawing.Size)
        Me.GroupControl1.AutoScrollMinSize = CType(resources.GetObject("GroupControl1.AutoScrollMinSize"), System.Drawing.Size)
        Me.GroupControl1.Appearance.Image = CType(resources.GetObject("GroupControl1.BackgroundImage"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtToID)
        Me.GroupControl1.Controls.Add(Me.txtFromID)
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
        'txtToID
        '
        Me.txtToID.Anchor = CType(resources.GetObject("txtToID.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtToID.BackgroundImage = CType(resources.GetObject("txtToID.BackgroundImage"), System.Drawing.Image)
        Me.txtToID.Dock = CType(resources.GetObject("txtToID.Dock"), System.Windows.Forms.DockStyle)
        Me.txtToID.EditValue = resources.GetString("txtToID.EditValue")
        Me.txtToID.Enabled = CType(resources.GetObject("txtToID.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.txtToID, resources.GetString("txtToID.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtToID, CType(resources.GetObject("txtToID.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtToID, resources.GetString("txtToID.HelpString"))
        Me.txtToID.ImeMode = CType(resources.GetObject("txtToID.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtToID.Location = CType(resources.GetObject("txtToID.Location"), System.Drawing.Point)
        Me.txtToID.Name = "txtToID"
        '
        'txtToID.Properties
        '
        Me.txtToID.Properties.AccessibleDescription = resources.GetString("txtToID.Properties.AccessibleDescription")
        Me.txtToID.Properties.AccessibleName = resources.GetString("txtToID.Properties.AccessibleName")
        Me.txtToID.Properties.AutoHeight = CType(resources.GetObject("txtToID.Properties.AutoHeight"), Boolean)
        Me.txtToID.Properties.Mask.AutoComplete = CType(resources.GetObject("txtToID.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtToID.Properties.Mask.BeepOnError = CType(resources.GetObject("txtToID.Properties.Mask.BeepOnError"), Boolean)
        Me.txtToID.Properties.Mask.EditMask = resources.GetString("txtToID.Properties.Mask.EditMask")
        Me.txtToID.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtToID.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtToID.Properties.Mask.MaskType = CType(resources.GetObject("txtToID.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtToID.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtToID.Properties.Mask.PlaceHolder"), Char)
        Me.txtToID.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtToID.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtToID.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtToID.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtToID.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtToID.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtToID.Properties.NullText = resources.GetString("txtToID.Properties.NullText")
        Me.txtToID.RightToLeft = CType(resources.GetObject("txtToID.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.txtToID, CType(resources.GetObject("txtToID.ShowHelp"), Boolean))
        Me.txtToID.Size = CType(resources.GetObject("txtToID.Size"), System.Drawing.Size)
        Me.txtToID.SuperTip = CType(resources.GetObject("txtToID.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtToID.TabIndex = CType(resources.GetObject("txtToID.TabIndex"), Integer)
        Me.txtToID.ToolTip = resources.GetString("txtToID.ToolTip")
        Me.txtToID.ToolTipIconType = CType(resources.GetObject("txtToID.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtToID.ToolTipTitle = resources.GetString("txtToID.ToolTipTitle")
        Me.txtToID.Visible = CType(resources.GetObject("txtToID.Visible"), Boolean)
        '
        'txtFromID
        '
        Me.txtFromID.Anchor = CType(resources.GetObject("txtFromID.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtFromID.BackgroundImage = CType(resources.GetObject("txtFromID.BackgroundImage"), System.Drawing.Image)
        Me.txtFromID.Dock = CType(resources.GetObject("txtFromID.Dock"), System.Windows.Forms.DockStyle)
        Me.txtFromID.EditValue = resources.GetString("txtFromID.EditValue")
        Me.txtFromID.Enabled = CType(resources.GetObject("txtFromID.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.txtFromID, resources.GetString("txtFromID.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtFromID, CType(resources.GetObject("txtFromID.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtFromID, resources.GetString("txtFromID.HelpString"))
        Me.txtFromID.ImeMode = CType(resources.GetObject("txtFromID.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtFromID.Location = CType(resources.GetObject("txtFromID.Location"), System.Drawing.Point)
        Me.txtFromID.Name = "txtFromID"
        '
        'txtFromID.Properties
        '
        Me.txtFromID.Properties.AccessibleDescription = resources.GetString("txtFromID.Properties.AccessibleDescription")
        Me.txtFromID.Properties.AccessibleName = resources.GetString("txtFromID.Properties.AccessibleName")
        Me.txtFromID.Properties.AutoHeight = CType(resources.GetObject("txtFromID.Properties.AutoHeight"), Boolean)
        Me.txtFromID.Properties.DisplayFormat.FormatString = "N0"
        Me.txtFromID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFromID.Properties.EditFormat.FormatString = "N0"
        Me.txtFromID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFromID.Properties.Mask.AutoComplete = CType(resources.GetObject("txtFromID.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtFromID.Properties.Mask.BeepOnError = CType(resources.GetObject("txtFromID.Properties.Mask.BeepOnError"), Boolean)
        Me.txtFromID.Properties.Mask.EditMask = resources.GetString("txtFromID.Properties.Mask.EditMask")
        Me.txtFromID.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtFromID.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtFromID.Properties.Mask.MaskType = CType(resources.GetObject("txtFromID.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtFromID.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtFromID.Properties.Mask.PlaceHolder"), Char)
        Me.txtFromID.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtFromID.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtFromID.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtFromID.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtFromID.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtFromID.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtFromID.Properties.NullText = resources.GetString("txtFromID.Properties.NullText")
        Me.txtFromID.RightToLeft = CType(resources.GetObject("txtFromID.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.txtFromID, CType(resources.GetObject("txtFromID.ShowHelp"), Boolean))
        Me.txtFromID.Size = CType(resources.GetObject("txtFromID.Size"), System.Drawing.Size)
        Me.txtFromID.SuperTip = CType(resources.GetObject("txtFromID.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtFromID.TabIndex = CType(resources.GetObject("txtFromID.TabIndex"), Integer)
        Me.txtFromID.ToolTip = resources.GetString("txtFromID.ToolTip")
        Me.txtFromID.ToolTipIconType = CType(resources.GetObject("txtFromID.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtFromID.ToolTipTitle = resources.GetString("txtFromID.ToolTipTitle")
        Me.txtFromID.Visible = CType(resources.GetObject("txtFromID.Visible"), Boolean)
        '
        'spinProcessing
        '
        Me.spinProcessing.Anchor = CType(resources.GetObject("spinProcessing.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.spinProcessing.BackgroundImage = CType(resources.GetObject("spinProcessing.BackgroundImage"), System.Drawing.Image)
        Me.spinProcessing.Dock = CType(resources.GetObject("spinProcessing.Dock"), System.Windows.Forms.DockStyle)
        Me.spinProcessing.EditValue = CType(resources.GetObject("spinProcessing.EditValue"), Object)
        Me.spinProcessing.Enabled = CType(resources.GetObject("spinProcessing.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.spinProcessing, resources.GetString("spinProcessing.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.spinProcessing, CType(resources.GetObject("spinProcessing.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.spinProcessing, resources.GetString("spinProcessing.HelpString"))
        Me.spinProcessing.ImeMode = CType(resources.GetObject("spinProcessing.ImeMode"), System.Windows.Forms.ImeMode)
        Me.spinProcessing.Location = CType(resources.GetObject("spinProcessing.Location"), System.Drawing.Point)
        Me.spinProcessing.Name = "spinProcessing"
        '
        'spinProcessing.Properties
        '
        Me.spinProcessing.Properties.AccessibleDescription = resources.GetString("spinProcessing.Properties.AccessibleDescription")
        Me.spinProcessing.Properties.AccessibleName = resources.GetString("spinProcessing.Properties.AccessibleName")
        Me.spinProcessing.Properties.AutoHeight = CType(resources.GetObject("spinProcessing.Properties.AutoHeight"), Boolean)
        Me.spinProcessing.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.spinProcessing.Properties.Mask.AutoComplete = CType(resources.GetObject("spinProcessing.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.spinProcessing.Properties.Mask.BeepOnError = CType(resources.GetObject("spinProcessing.Properties.Mask.BeepOnError"), Boolean)
        Me.spinProcessing.Properties.Mask.EditMask = resources.GetString("spinProcessing.Properties.Mask.EditMask")
        Me.spinProcessing.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("spinProcessing.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.spinProcessing.Properties.Mask.MaskType = CType(resources.GetObject("spinProcessing.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.spinProcessing.Properties.Mask.PlaceHolder = CType(resources.GetObject("spinProcessing.Properties.Mask.PlaceHolder"), Char)
        Me.spinProcessing.Properties.Mask.SaveLiteral = CType(resources.GetObject("spinProcessing.Properties.Mask.SaveLiteral"), Boolean)
        Me.spinProcessing.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("spinProcessing.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.spinProcessing.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("spinProcessing.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.spinProcessing.Properties.NullText = resources.GetString("spinProcessing.Properties.NullText")
        Me.spinProcessing.RightToLeft = CType(resources.GetObject("spinProcessing.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.spinProcessing, CType(resources.GetObject("spinProcessing.ShowHelp"), Boolean))
        Me.spinProcessing.Size = CType(resources.GetObject("spinProcessing.Size"), System.Drawing.Size)
        Me.spinProcessing.SuperTip = CType(resources.GetObject("spinProcessing.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.spinProcessing.TabIndex = CType(resources.GetObject("spinProcessing.TabIndex"), Integer)
        Me.spinProcessing.ToolTip = resources.GetString("spinProcessing.ToolTip")
        Me.spinProcessing.ToolTipIconType = CType(resources.GetObject("spinProcessing.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.spinProcessing.ToolTipTitle = resources.GetString("spinProcessing.ToolTipTitle")
        Me.spinProcessing.Visible = CType(resources.GetObject("spinProcessing.Visible"), Boolean)
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = resources.GetString("Label1.AccessibleDescription")
        Me.Label1.AccessibleName = resources.GetString("Label1.AccessibleName")
        Me.Label1.Anchor = CType(resources.GetObject("Label1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = CType(resources.GetObject("Label1.AutoSize"), Boolean)
        Me.Label1.Dock = CType(resources.GetObject("Label1.Dock"), System.Windows.Forms.DockStyle)
        Me.Label1.Enabled = CType(resources.GetObject("Label1.Enabled"), Boolean)
        Me.Label1.Font = CType(resources.GetObject("Label1.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.Label1, resources.GetString("Label1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.Label1, CType(resources.GetObject("Label1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.Label1, resources.GetString("Label1.HelpString"))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = CType(resources.GetObject("Label1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label1.ImageIndex = CType(resources.GetObject("Label1.ImageIndex"), Integer)
        Me.Label1.ImeMode = CType(resources.GetObject("Label1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label1.Location = CType(resources.GetObject("Label1.Location"), System.Drawing.Point)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = CType(resources.GetObject("Label1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.Label1, CType(resources.GetObject("Label1.ShowHelp"), Boolean))
        Me.Label1.Size = CType(resources.GetObject("Label1.Size"), System.Drawing.Size)
        Me.Label1.TabIndex = CType(resources.GetObject("Label1.TabIndex"), Integer)
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = CType(resources.GetObject("Label1.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label1.Visible = CType(resources.GetObject("Label1.Visible"), Boolean)
        '
        'frmProductsDVD_Browse
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
        Me.Name = "frmProductsDVD_Browse"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabParameters.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabResult.ResumeLayout(False)
        Me.TabAnalyse.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabChart.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.chkActors.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCategories.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSubTitles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLanguages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtToID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinProcessing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 1000000 "

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        objDS = New dsProducts
        'objDS.Tables.Add("products_DVD_view1")
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "products_DVD_view1"
        MyBase.IDField = "products_id"
        MyBase.NameField = "products_model"
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
            TabControl1.SelectedTabPage = TabResult
        Else
            'TabControl1.SelectedTabPage = TabParameters
            TabControl1.SelectedTabPage = TabResult
        End If
        TabControl1.SelectedTabPage = TabParameters
        LoadListValues()
    End Sub

    Public Overrides Sub LoadDataSet()
        Dim _SQLTxt As String
        Dim _tmpDS As New dsProducts
        'Clear Table
        objDS.Tables(TableName).Clear()

        'Updating Feesharing_end = 0000-00-00 00:00:00 to 1801-01-01 00:00:00
        '_SQLTxt = "Update Products Set Feesharing_end = NULL where Feesharing_End = '0000-00-00 00:00:00'"
        'DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        '_SQLTxt = "Update Products Set Products_Sale_Date = NULL where Products_Sale_Date = '0000-00-00 00:00:00'"
        'DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        '_SQLTxt = "Update products_dvd Set last_admindate = NULL where last_admindate = '0000-00-00 00:00:00'"
        'DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        '_SQLTxt = "Update products_dvd Set dvd_buy_date = NULL where dvd_buy_date = '0000-00-00 00:00:00'"
        'DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)

        'Products
        '_SQLTxt = "SELECT PD.products_id, PD.products_dvdid, PD.box_id, PD.pibox_id, PD.cover_box_id, PD.products_dvd_status, P.* from products_dvd PD  " & _
        '          " LEFT JOIN products P on PD.products_id = P.products_id " & _
        '          " WHERE products_type <> 'ABO' " & _
        '          _Limit
        Dim _FromID, _ToID As Integer
        If IsNumeric(txtFromID.EditValue) Then
            _FromID = txtFromID.EditValue
        Else
            _FromID = 0
        End If
        If IsNumeric(txtToID.EditValue) Then
            _ToID = txtToID.EditValue
        Else
            _ToID = 9999999
        End If
        _SQLTxt = " SELECT * from products p " & _
                  " LEFT JOIN products_dvd pd on pd.products_id = p.products_id " & _
                  " LEFT JOIN products_dvd_status pds on pds.products_dvd_status_id = pd.products_dvd_status " & _
                  " LEFT JOIN products_description pdesc on pdesc.products_id = p.products_id and pdesc.language_id = 1 " & _
                  " WHERE p.products_type <> 'ABO' and p.products_id >= " & _FromID & " AND p.products_id <= " & _ToID
        BKFilter.ApplyFilter(_SQLTxt, IsFiltered, CurrentFilterID, " ", StatusBar1.Panels(1))
        _SQLTxt = _SQLTxt & _Limit
        objDS.EnforceConstraints = False
        DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)
        ''SubTitles and Languages
        'If chkSubTitles.Checked Then
        '    _SQLTxt = "SELECT p.products_id, undertitles_id, language_id, undertitles_description as description " & _
        '              " FROM products_to_undertitles p left join products_undertitles u " & _
        '              "on p.products_undertitles_id = u.undertitles_id WHERe u.language_id = 3"
        '     DvdPostData.clsConnection.FillDataSet(_tmpDS.Tables("products_undertitles_View1"), _SQLTxt)
        'End If
        'If chkLanguages.Checked Then
        '    _SQLTxt = "SELECT p.products_id, languages_id, languagenav_id, languages_description as description " & _
        '                " FROM products_to_languages p " & _
        '                "left join products_languages l on p.products_languages_id = l.languages_id " & _
        '                "WHERe l.languagenav_id = 3"
        '     DvdPostData.clsConnection.FillDataSet(_tmpDS.Tables("products_languages_View1"), _SQLTxt)
        'End If
        'spinProcessing.EditValue = 0
        'spinProcessing.Visible = True
        'For Each _row In objDS.Tables(TableName).Rows
        '    spinProcessing.EditValue += 1
        '    spinProcessing.Refresh()
        '    '_row2 = _tmpDS.Tables("products_undertitles_View1").Rows.Find(New Object() {_row("Product_ID")})
        '    'Adding SubTitles Info
        '    If chkSubTitles.Checked Then
        '        _View = New DataView(_tmpDS.Tables("products_undertitles_View1"), "Products_Id = " & _row("products_id"), "", DataViewRowState.CurrentRows)
        '        For Each _Vrow In _View
        '            _row.BeginEdit()
        '            _row("SubTitles") += _Vrow("Description") + " , "
        '            _row.EndEdit()
        '        Next
        '    End If
        '    'Adding Languages Info
        '    If chkLanguages.Checked Then
        '        _View = New DataView(_tmpDS.Tables("products_languages_View1"), "Products_Id = " & _row("products_id"), "", DataViewRowState.CurrentRows)
        '        For Each _Vrow In _View
        '            _row.BeginEdit()
        '            _row("Languages") += _Vrow("Description") + " , "
        '            _row.EndEdit()
        '        Next
        '    End If
        '    If chkCategories.Checked Then
        '        _SQLTxt = "SELECT * FROM products_to_categories WHERE products_id = " & _row("products_id")
        '        BKCombo.GetCombo(_tmpDS, "products_to_categories", "categories_id", _SQLTxt)
        '        _i = 0
        '        For Each _row2 In _tmpDS.Tables("products_to_categories").Rows
        '            _i += 1
        '            _row3 = objDS.Tables("categories_description").Rows.Find(New Object() {_row2("categories_id"), 3})
        '            If Not IsNothing(_row3) Then
        '                _row("categories") = _row("categories") & _row3("categories_name") & ", "
        '                If _i <= 3 Then
        '                    _row("Category" & _i) = _row3("categories_name")
        '                End If
        '            End If
        '        Next
        '    End If
        '    If chkActors.Checked Then
        '        _SQLTxt = "SELECT * FROM products_to_actors WHERE products_id = " & _row("products_id")
        '        BKCombo.GetCombo(_tmpDS, "products_to_actors", "actors_id", _SQLTxt)
        '        _i = 0
        '        For Each _row2 In _tmpDS.Tables("products_to_actors").Rows
        '            _i += 1
        '            _row3 = objDS.Tables("actors").Rows.Find(New Object() {_row2("actors_id")})
        '            If Not IsNothing(_row3) Then
        '                _row("actors") = _row("actors") & _row3("actors_name") & ", "
        '                If _i <= 3 Then
        '                    _row("Actor" & _i) = _row3("actors_name")
        '                End If
        '            End If
        '        Next
        '    End If

        'Next
        'spinProcessing.Visible = False
        Grid1.DataSource = objDS.Tables(TableName).DefaultView '_View 
        TabControl1.SelectedTabPage = TabResult
        UcPivotGrid1.Initialize(SessionInfo)
        UcPivotGrid1.PivotGrid1.DataSource = objDS.Tables(TableName).DefaultView
        UcPivotGrid1.PivotGrid1.DataMember = ""
        UcPivotGrid1.SetFields()
    End Sub

    Private Sub txtLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimit.TextChanged
        _Limit = "limit 0, " & txtLimit.Text
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub

    Private Sub LoadListValues()
        BKCombo.GetCombo(objDS, "actors", "actors_name", "SELECT * FROM actors")
        BKCombo.GetCombo(objDS, "categories_description", "categories_name", "SELECT * FROM categories_description where language_id = 3")
        BKCombo.GetCombo(objDS, "directors", "directors_name", "SELECT * FROM directors")
    End Sub
End Class
