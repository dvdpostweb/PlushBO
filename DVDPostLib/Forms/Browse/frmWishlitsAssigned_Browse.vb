
Public Class frmWishlitsAssigned_Browse

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
    Friend WithEvents ProgressBar1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FromProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ToProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ToCustomerID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FromCustomerID As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmWishlitsAssigned_Browse))
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLimit = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.lbl1 = New System.Windows.Forms.Label
        Me.FromProductID = New DevExpress.XtraEditors.TextEdit
        Me.ToProductID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.ToCustomerID = New DevExpress.XtraEditors.TextEdit
        Me.FromCustomerID = New DevExpress.XtraEditors.TextEdit
        Me.TabChart.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        Me.TabResult.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabParameters.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToCustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromCustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabChart
        '
        Me.TabChart.Name = "TabChart"
        Me.HelpProvider1.SetShowHelp(Me.TabChart, CType(resources.GetObject("TabChart.ShowHelp"), Boolean))
        Me.TabChart.Size = CType(resources.GetObject("TabChart.Size"), System.Drawing.Size)
        '
        'UcChart1
        '
        Me.UcChart1.Name = "UcChart1"
        Me.HelpProvider1.SetShowHelp(Me.UcChart1, CType(resources.GetObject("UcChart1.ShowHelp"), Boolean))
        Me.UcChart1.Size = CType(resources.GetObject("UcChart1.Size"), System.Drawing.Size)
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
        Me.HelpProvider1.SetShowHelp(Me.TabAnalyse, CType(resources.GetObject("TabAnalyse.ShowHelp"), Boolean))
        Me.TabAnalyse.Size = CType(resources.GetObject("TabAnalyse.Size"), System.Drawing.Size)
        '
        'TabResult
        '
        Me.TabResult.Name = "TabResult"
        Me.HelpProvider1.SetShowHelp(Me.TabResult, CType(resources.GetObject("TabResult.ShowHelp"), Boolean))
        Me.TabResult.Size = CType(resources.GetObject("TabResult.Size"), System.Drawing.Size)
        '
        'Panel1
        '
        Me.Panel1.Name = "Panel1"
        Me.HelpProvider1.SetShowHelp(Me.Panel1, CType(resources.GetObject("Panel1.ShowHelp"), Boolean))
        Me.Panel1.Size = CType(resources.GetObject("Panel1.Size"), System.Drawing.Size)
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.Label6)
        Me.TabParameters.Controls.Add(Me.txtLimit)
        Me.TabParameters.Controls.Add(Me.ProgressBar1)
        Me.TabParameters.Controls.Add(Me.GroupControl1)
        Me.TabParameters.Controls.Add(Me.lbl1)
        Me.TabParameters.Name = "TabParameters"
        Me.HelpProvider1.SetShowHelp(Me.TabParameters, CType(resources.GetObject("TabParameters.ShowHelp"), Boolean))
        Me.TabParameters.Size = CType(resources.GetObject("TabParameters.Size"), System.Drawing.Size)
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.Name = "TabControl1"
        Me.HelpProvider1.SetShowHelp(Me.TabControl1, CType(resources.GetObject("TabControl1.ShowHelp"), Boolean))
        Me.TabControl1.Size = CType(resources.GetObject("TabControl1.Size"), System.Drawing.Size)
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
        Me.Grid1.EmbeddedNavigator.SuperTip = CType(resources.GetObject("Grid1.EmbeddedNavigator.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.Grid1.EmbeddedNavigator.Text = resources.GetString("Grid1.EmbeddedNavigator.Text")
        Me.Grid1.EmbeddedNavigator.TextLocation = CType(resources.GetObject("Grid1.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.Grid1.EmbeddedNavigator.TextStringFormat = resources.GetString("Grid1.EmbeddedNavigator.TextStringFormat")
        Me.Grid1.EmbeddedNavigator.ToolTip = resources.GetString("Grid1.EmbeddedNavigator.ToolTip")
        Me.Grid1.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("Grid1.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.Grid1.EmbeddedNavigator.ToolTipTitle = resources.GetString("Grid1.EmbeddedNavigator.ToolTipTitle")
        Me.Grid1.Name = "Grid1"
        Me.HelpProvider1.SetShowHelp(Me.Grid1, CType(resources.GetObject("Grid1.ShowHelp"), Boolean))
        Me.Grid1.Size = CType(resources.GetObject("Grid1.Size"), System.Drawing.Size)
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = CType(resources.GetObject("StatusBar1.Location"), System.Drawing.Point)
        Me.StatusBar1.Name = "StatusBar1"
        Me.HelpProvider1.SetShowHelp(Me.StatusBar1, CType(resources.GetObject("StatusBar1.ShowHelp"), Boolean))
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
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(resources.GetObject("ProgressBar1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.BackgroundImage = CType(resources.GetObject("ProgressBar1.BackgroundImage"), System.Drawing.Image)
        Me.ProgressBar1.Dock = CType(resources.GetObject("ProgressBar1.Dock"), System.Windows.Forms.DockStyle)
        Me.ProgressBar1.EditValue = CType(resources.GetObject("ProgressBar1.EditValue"), Object)
        Me.ProgressBar1.Enabled = CType(resources.GetObject("ProgressBar1.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.ProgressBar1, resources.GetString("ProgressBar1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.ProgressBar1, CType(resources.GetObject("ProgressBar1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.ProgressBar1, resources.GetString("ProgressBar1.HelpString"))
        Me.ProgressBar1.ImeMode = CType(resources.GetObject("ProgressBar1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.ProgressBar1.Location = CType(resources.GetObject("ProgressBar1.Location"), System.Drawing.Point)
        Me.ProgressBar1.Name = "ProgressBar1"
        '
        'ProgressBar1.Properties
        '
        Me.ProgressBar1.Properties.AccessibleDescription = resources.GetString("ProgressBar1.Properties.AccessibleDescription")
        Me.ProgressBar1.Properties.AccessibleName = resources.GetString("ProgressBar1.Properties.AccessibleName")
        Me.ProgressBar1.Properties.AutoHeight = CType(resources.GetObject("ProgressBar1.Properties.AutoHeight"), Boolean)
        Me.ProgressBar1.Properties.NullText = resources.GetString("ProgressBar1.Properties.NullText")
        Me.ProgressBar1.RightToLeft = CType(resources.GetObject("ProgressBar1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.ProgressBar1, CType(resources.GetObject("ProgressBar1.ShowHelp"), Boolean))
        Me.ProgressBar1.Size = CType(resources.GetObject("ProgressBar1.Size"), System.Drawing.Size)
        Me.ProgressBar1.SuperTip = CType(resources.GetObject("ProgressBar1.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.ProgressBar1.TabIndex = CType(resources.GetObject("ProgressBar1.TabIndex"), Integer)
        Me.ProgressBar1.ToolTip = resources.GetString("ProgressBar1.ToolTip")
        Me.ProgressBar1.ToolTipIconType = CType(resources.GetObject("ProgressBar1.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.ProgressBar1.ToolTipTitle = resources.GetString("ProgressBar1.ToolTipTitle")
        Me.ProgressBar1.Visible = CType(resources.GetObject("ProgressBar1.Visible"), Boolean)
        '
        'GroupControl1
        '
        Me.GroupControl1.AccessibleDescription = resources.GetString("GroupControl1.AccessibleDescription")
        Me.GroupControl1.AccessibleName = resources.GetString("GroupControl1.AccessibleName")
        Me.GroupControl1.Anchor = CType(resources.GetObject("GroupControl1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AutoScrollMargin = CType(resources.GetObject("GroupControl1.AutoScrollMargin"), System.Drawing.Size)
        Me.GroupControl1.AutoScrollMinSize = CType(resources.GetObject("GroupControl1.AutoScrollMinSize"), System.Drawing.Size)
        Me.GroupControl1.Appearance.Image = CType(resources.GetObject("GroupControl1.BackgroundImage"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.ToCustomerID)
        Me.GroupControl1.Controls.Add(Me.FromCustomerID)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.ToProductID)
        Me.GroupControl1.Controls.Add(Me.FromProductID)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtToDate)
        Me.GroupControl1.Controls.Add(Me.txtFromDate)
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
        'lbl1
        '
        Me.lbl1.AccessibleDescription = resources.GetString("lbl1.AccessibleDescription")
        Me.lbl1.AccessibleName = resources.GetString("lbl1.AccessibleName")
        Me.lbl1.Anchor = CType(resources.GetObject("lbl1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lbl1.AutoSize = CType(resources.GetObject("lbl1.AutoSize"), Boolean)
        Me.lbl1.Dock = CType(resources.GetObject("lbl1.Dock"), System.Windows.Forms.DockStyle)
        Me.lbl1.Enabled = CType(resources.GetObject("lbl1.Enabled"), Boolean)
        Me.lbl1.Font = CType(resources.GetObject("lbl1.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.lbl1, resources.GetString("lbl1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lbl1, CType(resources.GetObject("lbl1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lbl1, resources.GetString("lbl1.HelpString"))
        Me.lbl1.Image = CType(resources.GetObject("lbl1.Image"), System.Drawing.Image)
        Me.lbl1.ImageAlign = CType(resources.GetObject("lbl1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lbl1.ImageIndex = CType(resources.GetObject("lbl1.ImageIndex"), Integer)
        Me.lbl1.ImeMode = CType(resources.GetObject("lbl1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lbl1.Location = CType(resources.GetObject("lbl1.Location"), System.Drawing.Point)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.RightToLeft = CType(resources.GetObject("lbl1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.lbl1, CType(resources.GetObject("lbl1.ShowHelp"), Boolean))
        Me.lbl1.Size = CType(resources.GetObject("lbl1.Size"), System.Drawing.Size)
        Me.lbl1.TabIndex = CType(resources.GetObject("lbl1.TabIndex"), Integer)
        Me.lbl1.Text = resources.GetString("lbl1.Text")
        Me.lbl1.TextAlign = CType(resources.GetObject("lbl1.TextAlign"), System.Drawing.ContentAlignment)
        Me.lbl1.Visible = CType(resources.GetObject("lbl1.Visible"), Boolean)
        '
        'FromProductID
        '
        Me.FromProductID.Anchor = CType(resources.GetObject("FromProductID.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.FromProductID.BackgroundImage = CType(resources.GetObject("FromProductID.BackgroundImage"), System.Drawing.Image)
        Me.FromProductID.Dock = CType(resources.GetObject("FromProductID.Dock"), System.Windows.Forms.DockStyle)
        Me.FromProductID.EditValue = CType(resources.GetObject("FromProductID.EditValue"), Object)
        Me.FromProductID.Enabled = CType(resources.GetObject("FromProductID.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.FromProductID, resources.GetString("FromProductID.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.FromProductID, CType(resources.GetObject("FromProductID.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.FromProductID, resources.GetString("FromProductID.HelpString"))
        Me.FromProductID.ImeMode = CType(resources.GetObject("FromProductID.ImeMode"), System.Windows.Forms.ImeMode)
        Me.FromProductID.Location = CType(resources.GetObject("FromProductID.Location"), System.Drawing.Point)
        Me.FromProductID.Name = "FromProductID"
        '
        'FromProductID.Properties
        '
        Me.FromProductID.Properties.AccessibleDescription = resources.GetString("FromProductID.Properties.AccessibleDescription")
        Me.FromProductID.Properties.AccessibleName = resources.GetString("FromProductID.Properties.AccessibleName")
        Me.FromProductID.Properties.AutoHeight = CType(resources.GetObject("FromProductID.Properties.AutoHeight"), Boolean)
        Me.FromProductID.Properties.DisplayFormat.FormatString = "N0"
        Me.FromProductID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FromProductID.Properties.EditFormat.FormatString = "N0"
        Me.FromProductID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FromProductID.Properties.Mask.AutoComplete = CType(resources.GetObject("FromProductID.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.FromProductID.Properties.Mask.BeepOnError = CType(resources.GetObject("FromProductID.Properties.Mask.BeepOnError"), Boolean)
        Me.FromProductID.Properties.Mask.EditMask = resources.GetString("FromProductID.Properties.Mask.EditMask")
        Me.FromProductID.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("FromProductID.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.FromProductID.Properties.Mask.MaskType = CType(resources.GetObject("FromProductID.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.FromProductID.Properties.Mask.PlaceHolder = CType(resources.GetObject("FromProductID.Properties.Mask.PlaceHolder"), Char)
        Me.FromProductID.Properties.Mask.SaveLiteral = CType(resources.GetObject("FromProductID.Properties.Mask.SaveLiteral"), Boolean)
        Me.FromProductID.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("FromProductID.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.FromProductID.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("FromProductID.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.FromProductID.Properties.NullText = resources.GetString("FromProductID.Properties.NullText")
        Me.FromProductID.RightToLeft = CType(resources.GetObject("FromProductID.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.FromProductID, CType(resources.GetObject("FromProductID.ShowHelp"), Boolean))
        Me.FromProductID.Size = CType(resources.GetObject("FromProductID.Size"), System.Drawing.Size)
        Me.FromProductID.SuperTip = CType(resources.GetObject("FromProductID.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.FromProductID.TabIndex = CType(resources.GetObject("FromProductID.TabIndex"), Integer)
        Me.FromProductID.ToolTip = resources.GetString("FromProductID.ToolTip")
        Me.FromProductID.ToolTipIconType = CType(resources.GetObject("FromProductID.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.FromProductID.ToolTipTitle = resources.GetString("FromProductID.ToolTipTitle")
        Me.FromProductID.Visible = CType(resources.GetObject("FromProductID.Visible"), Boolean)
        '
        'ToProductID
        '
        Me.ToProductID.Anchor = CType(resources.GetObject("ToProductID.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.ToProductID.BackgroundImage = CType(resources.GetObject("ToProductID.BackgroundImage"), System.Drawing.Image)
        Me.ToProductID.Dock = CType(resources.GetObject("ToProductID.Dock"), System.Windows.Forms.DockStyle)
        Me.ToProductID.EditValue = CType(resources.GetObject("ToProductID.EditValue"), Object)
        Me.ToProductID.Enabled = CType(resources.GetObject("ToProductID.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.ToProductID, resources.GetString("ToProductID.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.ToProductID, CType(resources.GetObject("ToProductID.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.ToProductID, resources.GetString("ToProductID.HelpString"))
        Me.ToProductID.ImeMode = CType(resources.GetObject("ToProductID.ImeMode"), System.Windows.Forms.ImeMode)
        Me.ToProductID.Location = CType(resources.GetObject("ToProductID.Location"), System.Drawing.Point)
        Me.ToProductID.Name = "ToProductID"
        '
        'ToProductID.Properties
        '
        Me.ToProductID.Properties.AccessibleDescription = resources.GetString("ToProductID.Properties.AccessibleDescription")
        Me.ToProductID.Properties.AccessibleName = resources.GetString("ToProductID.Properties.AccessibleName")
        Me.ToProductID.Properties.AutoHeight = CType(resources.GetObject("ToProductID.Properties.AutoHeight"), Boolean)
        Me.ToProductID.Properties.Mask.AutoComplete = CType(resources.GetObject("ToProductID.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.ToProductID.Properties.Mask.BeepOnError = CType(resources.GetObject("ToProductID.Properties.Mask.BeepOnError"), Boolean)
        Me.ToProductID.Properties.Mask.EditMask = resources.GetString("ToProductID.Properties.Mask.EditMask")
        Me.ToProductID.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("ToProductID.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.ToProductID.Properties.Mask.MaskType = CType(resources.GetObject("ToProductID.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.ToProductID.Properties.Mask.PlaceHolder = CType(resources.GetObject("ToProductID.Properties.Mask.PlaceHolder"), Char)
        Me.ToProductID.Properties.Mask.SaveLiteral = CType(resources.GetObject("ToProductID.Properties.Mask.SaveLiteral"), Boolean)
        Me.ToProductID.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("ToProductID.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.ToProductID.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("ToProductID.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.ToProductID.Properties.NullText = resources.GetString("ToProductID.Properties.NullText")
        Me.ToProductID.RightToLeft = CType(resources.GetObject("ToProductID.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.ToProductID, CType(resources.GetObject("ToProductID.ShowHelp"), Boolean))
        Me.ToProductID.Size = CType(resources.GetObject("ToProductID.Size"), System.Drawing.Size)
        Me.ToProductID.SuperTip = CType(resources.GetObject("ToProductID.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.ToProductID.TabIndex = CType(resources.GetObject("ToProductID.TabIndex"), Integer)
        Me.ToProductID.ToolTip = resources.GetString("ToProductID.ToolTip")
        Me.ToProductID.ToolTipIconType = CType(resources.GetObject("ToProductID.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.ToProductID.ToolTipTitle = resources.GetString("ToProductID.ToolTipTitle")
        Me.ToProductID.Visible = CType(resources.GetObject("ToProductID.Visible"), Boolean)
        '
        'LabelControl3
        '
        Me.LabelControl3.AccessibleDescription = resources.GetString("LabelControl3.AccessibleDescription")
        Me.LabelControl3.AccessibleName = resources.GetString("LabelControl3.AccessibleName")
        Me.LabelControl3.Anchor = CType(resources.GetObject("LabelControl3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.AutoSizeMode = CType(resources.GetObject("LabelControl3.AutoSizeMode"), DevExpress.XtraEditors.LabelAutoSizeMode)
        Me.LabelControl3.Dock = CType(resources.GetObject("LabelControl3.Dock"), System.Windows.Forms.DockStyle)
        Me.LabelControl3.Enabled = CType(resources.GetObject("LabelControl3.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.LabelControl3, resources.GetString("LabelControl3.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.LabelControl3, CType(resources.GetObject("LabelControl3.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.LabelControl3, resources.GetString("LabelControl3.HelpString"))
        Me.LabelControl3.ImeMode = CType(resources.GetObject("LabelControl3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.LabelControl3.LineColor = CType(resources.GetObject("LabelControl3.LineColor"), System.Drawing.Color)
        Me.LabelControl3.Location = CType(resources.GetObject("LabelControl3.Location"), System.Drawing.Point)
        Me.LabelControl3.Name = "LabelControl3"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl3, CType(resources.GetObject("LabelControl3.ShowHelp"), Boolean))
        Me.LabelControl3.Size = CType(resources.GetObject("LabelControl3.Size"), System.Drawing.Size)
        Me.LabelControl3.SuperTip = CType(resources.GetObject("LabelControl3.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.LabelControl3.TabIndex = CType(resources.GetObject("LabelControl3.TabIndex"), Integer)
        Me.LabelControl3.Text = resources.GetString("LabelControl3.Text")
        Me.LabelControl3.ToolTip = resources.GetString("LabelControl3.ToolTip")
        Me.LabelControl3.ToolTipIconType = CType(resources.GetObject("LabelControl3.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.LabelControl3.ToolTipTitle = resources.GetString("LabelControl3.ToolTipTitle")
        Me.LabelControl3.Visible = CType(resources.GetObject("LabelControl3.Visible"), Boolean)
        '
        'LabelControl4
        '
        Me.LabelControl4.AccessibleDescription = resources.GetString("LabelControl4.AccessibleDescription")
        Me.LabelControl4.AccessibleName = resources.GetString("LabelControl4.AccessibleName")
        Me.LabelControl4.Anchor = CType(resources.GetObject("LabelControl4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.AutoSizeMode = CType(resources.GetObject("LabelControl4.AutoSizeMode"), DevExpress.XtraEditors.LabelAutoSizeMode)
        Me.LabelControl4.Dock = CType(resources.GetObject("LabelControl4.Dock"), System.Windows.Forms.DockStyle)
        Me.LabelControl4.Enabled = CType(resources.GetObject("LabelControl4.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.LabelControl4, resources.GetString("LabelControl4.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.LabelControl4, CType(resources.GetObject("LabelControl4.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.LabelControl4, resources.GetString("LabelControl4.HelpString"))
        Me.LabelControl4.ImeMode = CType(resources.GetObject("LabelControl4.ImeMode"), System.Windows.Forms.ImeMode)
        Me.LabelControl4.LineColor = CType(resources.GetObject("LabelControl4.LineColor"), System.Drawing.Color)
        Me.LabelControl4.Location = CType(resources.GetObject("LabelControl4.Location"), System.Drawing.Point)
        Me.LabelControl4.Name = "LabelControl4"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl4, CType(resources.GetObject("LabelControl4.ShowHelp"), Boolean))
        Me.LabelControl4.Size = CType(resources.GetObject("LabelControl4.Size"), System.Drawing.Size)
        Me.LabelControl4.SuperTip = CType(resources.GetObject("LabelControl4.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.LabelControl4.TabIndex = CType(resources.GetObject("LabelControl4.TabIndex"), Integer)
        Me.LabelControl4.Text = resources.GetString("LabelControl4.Text")
        Me.LabelControl4.ToolTip = resources.GetString("LabelControl4.ToolTip")
        Me.LabelControl4.ToolTipIconType = CType(resources.GetObject("LabelControl4.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.LabelControl4.ToolTipTitle = resources.GetString("LabelControl4.ToolTipTitle")
        Me.LabelControl4.Visible = CType(resources.GetObject("LabelControl4.Visible"), Boolean)
        '
        'LabelControl5
        '
        Me.LabelControl5.AccessibleDescription = resources.GetString("LabelControl5.AccessibleDescription")
        Me.LabelControl5.AccessibleName = resources.GetString("LabelControl5.AccessibleName")
        Me.LabelControl5.Anchor = CType(resources.GetObject("LabelControl5.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.AutoSizeMode = CType(resources.GetObject("LabelControl5.AutoSizeMode"), DevExpress.XtraEditors.LabelAutoSizeMode)
        Me.LabelControl5.Dock = CType(resources.GetObject("LabelControl5.Dock"), System.Windows.Forms.DockStyle)
        Me.LabelControl5.Enabled = CType(resources.GetObject("LabelControl5.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.LabelControl5, resources.GetString("LabelControl5.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.LabelControl5, CType(resources.GetObject("LabelControl5.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.LabelControl5, resources.GetString("LabelControl5.HelpString"))
        Me.LabelControl5.ImeMode = CType(resources.GetObject("LabelControl5.ImeMode"), System.Windows.Forms.ImeMode)
        Me.LabelControl5.LineColor = CType(resources.GetObject("LabelControl5.LineColor"), System.Drawing.Color)
        Me.LabelControl5.Location = CType(resources.GetObject("LabelControl5.Location"), System.Drawing.Point)
        Me.LabelControl5.Name = "LabelControl5"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl5, CType(resources.GetObject("LabelControl5.ShowHelp"), Boolean))
        Me.LabelControl5.Size = CType(resources.GetObject("LabelControl5.Size"), System.Drawing.Size)
        Me.LabelControl5.SuperTip = CType(resources.GetObject("LabelControl5.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.LabelControl5.TabIndex = CType(resources.GetObject("LabelControl5.TabIndex"), Integer)
        Me.LabelControl5.Text = resources.GetString("LabelControl5.Text")
        Me.LabelControl5.ToolTip = resources.GetString("LabelControl5.ToolTip")
        Me.LabelControl5.ToolTipIconType = CType(resources.GetObject("LabelControl5.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.LabelControl5.ToolTipTitle = resources.GetString("LabelControl5.ToolTipTitle")
        Me.LabelControl5.Visible = CType(resources.GetObject("LabelControl5.Visible"), Boolean)
        '
        'LabelControl6
        '
        Me.LabelControl6.AccessibleDescription = resources.GetString("LabelControl6.AccessibleDescription")
        Me.LabelControl6.AccessibleName = resources.GetString("LabelControl6.AccessibleName")
        Me.LabelControl6.Anchor = CType(resources.GetObject("LabelControl6.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.AutoSizeMode = CType(resources.GetObject("LabelControl6.AutoSizeMode"), DevExpress.XtraEditors.LabelAutoSizeMode)
        Me.LabelControl6.Dock = CType(resources.GetObject("LabelControl6.Dock"), System.Windows.Forms.DockStyle)
        Me.LabelControl6.Enabled = CType(resources.GetObject("LabelControl6.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.LabelControl6, resources.GetString("LabelControl6.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.LabelControl6, CType(resources.GetObject("LabelControl6.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.LabelControl6, resources.GetString("LabelControl6.HelpString"))
        Me.LabelControl6.ImeMode = CType(resources.GetObject("LabelControl6.ImeMode"), System.Windows.Forms.ImeMode)
        Me.LabelControl6.LineColor = CType(resources.GetObject("LabelControl6.LineColor"), System.Drawing.Color)
        Me.LabelControl6.Location = CType(resources.GetObject("LabelControl6.Location"), System.Drawing.Point)
        Me.LabelControl6.Name = "LabelControl6"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl6, CType(resources.GetObject("LabelControl6.ShowHelp"), Boolean))
        Me.LabelControl6.Size = CType(resources.GetObject("LabelControl6.Size"), System.Drawing.Size)
        Me.LabelControl6.SuperTip = CType(resources.GetObject("LabelControl6.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.LabelControl6.TabIndex = CType(resources.GetObject("LabelControl6.TabIndex"), Integer)
        Me.LabelControl6.Text = resources.GetString("LabelControl6.Text")
        Me.LabelControl6.ToolTip = resources.GetString("LabelControl6.ToolTip")
        Me.LabelControl6.ToolTipIconType = CType(resources.GetObject("LabelControl6.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.LabelControl6.ToolTipTitle = resources.GetString("LabelControl6.ToolTipTitle")
        Me.LabelControl6.Visible = CType(resources.GetObject("LabelControl6.Visible"), Boolean)
        '
        'ToCustomerID
        '
        Me.ToCustomerID.Anchor = CType(resources.GetObject("ToCustomerID.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.ToCustomerID.BackgroundImage = CType(resources.GetObject("ToCustomerID.BackgroundImage"), System.Drawing.Image)
        Me.ToCustomerID.Dock = CType(resources.GetObject("ToCustomerID.Dock"), System.Windows.Forms.DockStyle)
        Me.ToCustomerID.EditValue = CType(resources.GetObject("ToCustomerID.EditValue"), Object)
        Me.ToCustomerID.Enabled = CType(resources.GetObject("ToCustomerID.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.ToCustomerID, resources.GetString("ToCustomerID.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.ToCustomerID, CType(resources.GetObject("ToCustomerID.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.ToCustomerID, resources.GetString("ToCustomerID.HelpString"))
        Me.ToCustomerID.ImeMode = CType(resources.GetObject("ToCustomerID.ImeMode"), System.Windows.Forms.ImeMode)
        Me.ToCustomerID.Location = CType(resources.GetObject("ToCustomerID.Location"), System.Drawing.Point)
        Me.ToCustomerID.Name = "ToCustomerID"
        '
        'ToCustomerID.Properties
        '
        Me.ToCustomerID.Properties.AccessibleDescription = resources.GetString("ToCustomerID.Properties.AccessibleDescription")
        Me.ToCustomerID.Properties.AccessibleName = resources.GetString("ToCustomerID.Properties.AccessibleName")
        Me.ToCustomerID.Properties.AutoHeight = CType(resources.GetObject("ToCustomerID.Properties.AutoHeight"), Boolean)
        Me.ToCustomerID.Properties.Mask.AutoComplete = CType(resources.GetObject("ToCustomerID.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.ToCustomerID.Properties.Mask.BeepOnError = CType(resources.GetObject("ToCustomerID.Properties.Mask.BeepOnError"), Boolean)
        Me.ToCustomerID.Properties.Mask.EditMask = resources.GetString("ToCustomerID.Properties.Mask.EditMask")
        Me.ToCustomerID.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("ToCustomerID.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.ToCustomerID.Properties.Mask.MaskType = CType(resources.GetObject("ToCustomerID.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.ToCustomerID.Properties.Mask.PlaceHolder = CType(resources.GetObject("ToCustomerID.Properties.Mask.PlaceHolder"), Char)
        Me.ToCustomerID.Properties.Mask.SaveLiteral = CType(resources.GetObject("ToCustomerID.Properties.Mask.SaveLiteral"), Boolean)
        Me.ToCustomerID.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("ToCustomerID.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.ToCustomerID.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("ToCustomerID.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.ToCustomerID.Properties.NullText = resources.GetString("ToCustomerID.Properties.NullText")
        Me.ToCustomerID.RightToLeft = CType(resources.GetObject("ToCustomerID.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.ToCustomerID, CType(resources.GetObject("ToCustomerID.ShowHelp"), Boolean))
        Me.ToCustomerID.Size = CType(resources.GetObject("ToCustomerID.Size"), System.Drawing.Size)
        Me.ToCustomerID.SuperTip = CType(resources.GetObject("ToCustomerID.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.ToCustomerID.TabIndex = CType(resources.GetObject("ToCustomerID.TabIndex"), Integer)
        Me.ToCustomerID.ToolTip = resources.GetString("ToCustomerID.ToolTip")
        Me.ToCustomerID.ToolTipIconType = CType(resources.GetObject("ToCustomerID.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.ToCustomerID.ToolTipTitle = resources.GetString("ToCustomerID.ToolTipTitle")
        Me.ToCustomerID.Visible = CType(resources.GetObject("ToCustomerID.Visible"), Boolean)
        '
        'FromCustomerID
        '
        Me.FromCustomerID.Anchor = CType(resources.GetObject("FromCustomerID.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.FromCustomerID.BackgroundImage = CType(resources.GetObject("FromCustomerID.BackgroundImage"), System.Drawing.Image)
        Me.FromCustomerID.Dock = CType(resources.GetObject("FromCustomerID.Dock"), System.Windows.Forms.DockStyle)
        Me.FromCustomerID.EditValue = CType(resources.GetObject("FromCustomerID.EditValue"), Object)
        Me.FromCustomerID.Enabled = CType(resources.GetObject("FromCustomerID.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.FromCustomerID, resources.GetString("FromCustomerID.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.FromCustomerID, CType(resources.GetObject("FromCustomerID.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.FromCustomerID, resources.GetString("FromCustomerID.HelpString"))
        Me.FromCustomerID.ImeMode = CType(resources.GetObject("FromCustomerID.ImeMode"), System.Windows.Forms.ImeMode)
        Me.FromCustomerID.Location = CType(resources.GetObject("FromCustomerID.Location"), System.Drawing.Point)
        Me.FromCustomerID.Name = "FromCustomerID"
        '
        'FromCustomerID.Properties
        '
        Me.FromCustomerID.Properties.AccessibleDescription = resources.GetString("FromCustomerID.Properties.AccessibleDescription")
        Me.FromCustomerID.Properties.AccessibleName = resources.GetString("FromCustomerID.Properties.AccessibleName")
        Me.FromCustomerID.Properties.AutoHeight = CType(resources.GetObject("FromCustomerID.Properties.AutoHeight"), Boolean)
        Me.FromCustomerID.Properties.DisplayFormat.FormatString = "N0"
        Me.FromCustomerID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FromCustomerID.Properties.EditFormat.FormatString = "N0"
        Me.FromCustomerID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FromCustomerID.Properties.Mask.AutoComplete = CType(resources.GetObject("FromCustomerID.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.FromCustomerID.Properties.Mask.BeepOnError = CType(resources.GetObject("FromCustomerID.Properties.Mask.BeepOnError"), Boolean)
        Me.FromCustomerID.Properties.Mask.EditMask = resources.GetString("FromCustomerID.Properties.Mask.EditMask")
        Me.FromCustomerID.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("FromCustomerID.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.FromCustomerID.Properties.Mask.MaskType = CType(resources.GetObject("FromCustomerID.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.FromCustomerID.Properties.Mask.PlaceHolder = CType(resources.GetObject("FromCustomerID.Properties.Mask.PlaceHolder"), Char)
        Me.FromCustomerID.Properties.Mask.SaveLiteral = CType(resources.GetObject("FromCustomerID.Properties.Mask.SaveLiteral"), Boolean)
        Me.FromCustomerID.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("FromCustomerID.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.FromCustomerID.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("FromCustomerID.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.FromCustomerID.Properties.NullText = resources.GetString("FromCustomerID.Properties.NullText")
        Me.FromCustomerID.RightToLeft = CType(resources.GetObject("FromCustomerID.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.FromCustomerID, CType(resources.GetObject("FromCustomerID.ShowHelp"), Boolean))
        Me.FromCustomerID.Size = CType(resources.GetObject("FromCustomerID.Size"), System.Drawing.Size)
        Me.FromCustomerID.SuperTip = CType(resources.GetObject("FromCustomerID.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.FromCustomerID.TabIndex = CType(resources.GetObject("FromCustomerID.TabIndex"), Integer)
        Me.FromCustomerID.ToolTip = resources.GetString("FromCustomerID.ToolTip")
        Me.FromCustomerID.ToolTipIconType = CType(resources.GetObject("FromCustomerID.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.FromCustomerID.ToolTipTitle = resources.GetString("FromCustomerID.ToolTipTitle")
        Me.FromCustomerID.Visible = CType(resources.GetObject("FromCustomerID.Visible"), Boolean)
        '
        'frmWishlitsAssigned_Browse
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
        Me.Name = "frmWishlitsAssigned_Browse"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.TabChart.ResumeLayout(False)
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabResult.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToCustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromCustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        objDS = New dsAboRent
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "wishlist_assigned_view1"
        MyBase.IDField = "wl_assigned_id"
        MyBase.NameField = "wl_id"
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
            TabControl1.SelectedTabPage = TabParameters
        End If
    End Sub
    Private Sub txtLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimit.TextChanged
        _Limit = "limit 0, " & txtLimit.Text
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub

    Public Overrides Sub LoadDataSet()
        Dim _SQLTxt As String
        Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue) & " 00:00:00"
        Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue) & " 23:59:59"
        'Clear Table
        objDS.Tables(TableName).Clear()
        Dim _FromProductID, _ToProductsID As Integer
        Dim _FromCustID, _ToCustID As Integer

        If IsNothing(txtFromDate.EditValue) Or IsNothing(txtToDate.EditValue) Then
            MsgBox("Select a valide Date Range", MsgBoxStyle.Critical)
            Exit Sub
        End If
        'If FromProductID.EditValue & "" = "" Then _FromProductID = 0
        If Not IsNumeric(FromProductID.EditValue) Then _FromProductID = 0
        'If ToProductID.EditValue & "" = "" Then _ToProductsID = 999999999
        If Not IsNumeric(ToProductID.EditValue) Then _ToProductsID = 99999999
        If Not IsNumeric(FromCustomerID.EditValue) Then _FromCustID = 0
        If Not IsNumeric(ToCustomerID.EditValue) Then _ToCustID = 99999999
        _SQLTxt = _
            "SELECT wl.wl_assigned_id, wl.wl_id, wl.customers_id, wl.products_id, wl.rank, " & _
            " if ( date_assigned = '0000-00-00 00:00:00', null, date_assigned) as date_assigned, " & _
            " if ( date_added ='00000-00-00 00:00:00', null, date_added) as date_added, c.customers_lastname, c.customers_firstname, p.products_type, p.products_title  " & _
            " FROM wishlist_assigned wl " & _
            " left join customers c on c.customers_id = wl.customers_id" & _
            " left join products p on p.products_id = wl.products_id" & _
            " where wl.date_assigned >= '" & _DateFromTxt & "' and wl.date_assigned <= '" & _DateToTxt & _
            "' AND wl.customers_id >= " & _FromCustID & " AND wl.customers_id <= " & _ToCustID & _
            " AND wl.products_id >= " & _FromProductID & " AND wl.products_id <= " & _ToProductsID



        DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)

        Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
        TabControl1.SelectedTabPage = TabResult
    End Sub
End Class
