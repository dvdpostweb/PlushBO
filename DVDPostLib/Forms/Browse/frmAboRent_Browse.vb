
Public Class frmAboRent_Browse
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAboRent_Browse))
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLimit = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lbl1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabParameters.SuspendLayout()
        Me.TabResult.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = CType(resources.GetObject("Panel1.Size"), System.Drawing.Size)
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = CType(resources.GetObject("StatusBar1.Location"), System.Drawing.Point)
        Me.StatusBar1.Name = "StatusBar1"
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
        Me.TabControl1.Size = CType(resources.GetObject("TabControl1.Size"), System.Drawing.Size)
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.Label6)
        Me.TabParameters.Controls.Add(Me.txtLimit)
        Me.TabParameters.Controls.Add(Me.ProgressBar1)
        Me.TabParameters.Controls.Add(Me.GroupControl1)
        Me.TabParameters.Controls.Add(Me.lbl1)
        Me.TabParameters.Name = "TabParameters"
        Me.TabParameters.Size = CType(resources.GetObject("TabParameters.Size"), System.Drawing.Size)
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
        'frmAboRent_Browse
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
        Me.Name = "frmAboRent_Browse"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Panel1.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        Me.TabResult.ResumeLayout(False)
        Me.TabAnalyse.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
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
        MyBase.TableName = "AboRent"
        MyBase.IDField = "Customers_ID"
        MyBase.NameField = "Customers_ID"
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

        'Clear Table
        objDS.Tables("AboRent").Clear()
        _SQLTxt = "SELECT c.customers_id , c.customers_abo as 'abo' , c.customers_abo_type as 'abo_type' ,  " & _
                  " p.products_title as 'abo_type_desc' , 0 as Rentals FROM customers c " & _
                  " LEFT Join products p on p.products_id = c.customers_abo_type " & _Limit
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("AboRent"), _SQLTxt)

        ComputeRentingInfoHisto("orders_norm_2002")
        ComputeRentingInfoHisto("orders_norm_2003")
        ComputeRentingInfoHisto("orders_norm_2004")
        ComputeRentingInfoHisto("orders_norm_2005")
        ComputeRentingInfoCurrent()

        Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
        TabControl1.SelectedTabPage = TabResult
    End Sub
    Private Sub ComputeRentingInfoHisto(ByVal OrdersTable As String)
        Dim sSQL2 As String
        Dim _row, _row2 As DataRow

        lbl1.Text = OrdersTable
        lbl1.Refresh()
        ProgressBar1.Properties.Minimum = 0
        ProgressBar1.Properties.Maximum = objDS.Tables("AboRent").Rows.Count
        ProgressBar1.EditValue = 0

        sSQL2 = "SELECT customers_id, Rentals FROM " & OrdersTable & " " '" where customers_id = '" & vCustomer_ID & "' "
        objDS.Tables("CustOrder").Clear()
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("CustOrder"), sSQL2)
        For Each _row In objDS.Tables("AboRent").Rows
            'ProgressBar1.EditValue += 1
            'ProgressBar1.Refresh()
            _row2 = objDS.Tables("CustOrder").Rows.Find(New Object() {_row("Customers_ID")})
            If Not IsNothing(_row2) Then
                _row("Rentals") += _row2("Rentals")
            End If
        Next

        ProgressBar1.EditValue = 0
        lbl1.Text = ""

        'sSQL2 = "SELECT * FROM orders_adult_2002 where customers_id = '" & Request.QueryString("customers_id") & "' "
        'mycommand2.CommandText = sSQL2
        'dr2 = mycommand2.ExecuteReader
        'Do Until Not dr2.Read
        '    int_rentals_old = int_rentals_old + dr2("rentals")
        'Loop
        'dr2.Close()

        'sSQL2 = "SELECT * FROM orders_adult_2003 where customers_id = '" & Request.QueryString("customers_id") & "' "
        'mycommand2.CommandText = sSQL2
        'dr2 = mycommand2.ExecuteReader
        'Do Until Not dr2.Read
        '    int_rentals_old = int_rentals_old + dr2("rentals")
        'Loop
        'dr2.Close()

        'sSQL2 = "SELECT * FROM orders_adult_2004 where customers_id = '" & Request.QueryString("customers_id") & "' "
        'mycommand2.CommandText = sSQL2
        'dr2 = mycommand2.ExecuteReader
        'Do Until Not dr2.Read
        '    int_rentals_old = int_rentals_old + dr2("rentals")
        'Loop
        'dr2.Close()

        'sSQL2 = "SELECT * FROM orders_adult_2005 where customers_id = '" & Request.QueryString("customers_id") & "' "
        'mycommand2.CommandText = sSQL2
        'dr2 = mycommand2.ExecuteReader
        'Do Until Not dr2.Read
        '    int_rentals_old = int_rentals_old + dr2("rentals")
        'Loop
        'dr2.Close()


        'lbldvd_summup.Text = lbldvd_summup.Text & "<table>"
        'lbldvd_summup.Text = lbldvd_summup.Text & "<tr><td><i>DVD Returned(2002-->2005)</i>: </td><td><b>" & int_rentals_old & "</b></td></tr>"
        'sSQL2 = "SELECT orders_status, count( * ) AS cc FROM orders o LEFT JOIN orders_products op ON o.orders_id = op.orders_id WHERE o.customers_id = '" & intcustomers_id & "' AND op.products_id > 49 GROUP BY o.orders_status"
        'mycommand2.CommandText = sSQL2
        'dr2 = mycommand2.ExecuteReader
        'Do Until Not dr2.Read
        '    Select Case dr2("orders_status")
        '        Case 1
        '            lbldvd_summup.Text = lbldvd_summup.Text & "<tr><td><i>DVD RFE</i>: </td><td><b>" & dr2("cc") & "</b></td></tr>"
        '        Case 2
        '            lbldvd_summup.Text = lbldvd_summup.Text & "<tr><td><i>DVD @ home</i>: </td><td><b>" & dr2("cc") & "</b></td></tr>"
        '        Case 3
        '            lbldvd_summup.Text = lbldvd_summup.Text & "<tr><td><i>DVD Returned 2006</i>: </td><td><b>" & dr2("cc") & "</b></td></tr>"
        '        Case 6
        '            lbldvd_summup.Text = lbldvd_summup.Text & "<tr><td><i>DVD LOST</i>: </td><td><b>" & dr2("cc") & "</b></td></tr>"
        '        Case 9
        '            lbldvd_summup.Text = lbldvd_summup.Text & "<tr><td><i>DVD Cancel</i>: </td><td><b>" & dr2("cc") & "</b></td></tr>"
        '        Case 12
        '            lbldvd_summup.Text = lbldvd_summup.Text & "<tr><td><i>DVD DELAY</i>: </td><td><b>" & dr2("cc") & "</b></td></tr>"
        '        Case 13
        '            lbldvd_summup.Text = lbldvd_summup.Text & "<tr><td><i>DVD BROKEN</i>: </td><td><b>" & dr2("cc") & "</b></td></tr>"
        '        Case 15
        '            lbldvd_summup.Text = lbldvd_summup.Text & "<tr><td><i>DVD Transit KIALA</i>: </td><td><b>" & dr2("cc") & "</b></td></tr>"
        '        Case Else
        '            lbldvd_summup.Text = lbldvd_summup.Text & "<tr><td><i>" & dr2("orders_status") & "</i>: </td><td><b>" & dr2("cc") & "</b></td></tr>"
        '    End Select
        'Loop
        'dr2.Close()
        'lbldvd_summup.Text = lbldvd_summup.Text & "</table>"
    End Sub
    Private Sub ComputeRentingInfoCurrent()
        Dim sSQL2 As String
        Dim _row, _row2 As DataRow

        lbl1.Text = "Current Orders"
        lbl1.Refresh()
        ProgressBar1.Properties.Minimum = 0
        ProgressBar1.Properties.Maximum = objDS.Tables("AboRent").Rows.Count
        ProgressBar1.EditValue = 0

        sSQL2 = "SELECT customers_id, count(*) as 'Rentals' FROM orders  GROUP BY customers_id " '" where customers_id = '" & vCustomer_ID & "' "
        objDS.Tables("CustOrder").Clear()
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("CustOrder"), sSQL2)
        For Each _row In objDS.Tables("AboRent").Rows
            'ProgressBar1.EditValue += 1
            'ProgressBar1.Refresh()
            _row2 = objDS.Tables("CustOrder").Rows.Find(New Object() {_row("customers_ID")})
            If Not IsNothing(_row2) Then
                _row("Rentals") += _row2("Rentals")
            End If
        Next

        ProgressBar1.EditValue = 0
        lbl1.Text = ""

    End Sub
End Class
