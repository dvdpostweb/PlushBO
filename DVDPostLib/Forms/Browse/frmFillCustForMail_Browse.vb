Public Class frmFillCustForMail_Browse
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
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFillCustForMail_Browse))
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLimit = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.lbl1 = New System.Windows.Forms.Label
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabParameters.SuspendLayout()
        Me.TabResult.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Name = "Panel1"
        Me.HelpProvider1.SetShowHelp(Me.Panel1, CType(resources.GetObject("Panel1.ShowHelp"), Boolean))
        Me.Panel1.Size = CType(resources.GetObject("Panel1.Size"), System.Drawing.Size)
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
        'StatusBar1
        '
        Me.StatusBar1.Location = CType(resources.GetObject("StatusBar1.Location"), System.Drawing.Point)
        Me.StatusBar1.Name = "StatusBar1"
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
        Me.TabParameters.Controls.Add(Me.SimpleButton1)
        Me.TabParameters.Controls.Add(Me.Label6)
        Me.TabParameters.Controls.Add(Me.txtLimit)
        Me.TabParameters.Controls.Add(Me.ProgressBar1)
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
        'SimpleButton1
        '
        Me.SimpleButton1.AccessibleDescription = resources.GetString("SimpleButton1.AccessibleDescription")
        Me.SimpleButton1.AccessibleName = resources.GetString("SimpleButton1.AccessibleName")
        Me.SimpleButton1.Anchor = CType(resources.GetObject("SimpleButton1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.BackgroundImage = CType(resources.GetObject("SimpleButton1.BackgroundImage"), System.Drawing.Image)
        Me.SimpleButton1.Dock = CType(resources.GetObject("SimpleButton1.Dock"), System.Windows.Forms.DockStyle)
        Me.SimpleButton1.Enabled = CType(resources.GetObject("SimpleButton1.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.SimpleButton1, resources.GetString("SimpleButton1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.SimpleButton1, CType(resources.GetObject("SimpleButton1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.SimpleButton1, resources.GetString("SimpleButton1.HelpString"))
        Me.SimpleButton1.ImeMode = CType(resources.GetObject("SimpleButton1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.SimpleButton1.Location = CType(resources.GetObject("SimpleButton1.Location"), System.Drawing.Point)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.RightToLeft = CType(resources.GetObject("SimpleButton1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.SimpleButton1, CType(resources.GetObject("SimpleButton1.ShowHelp"), Boolean))
        Me.SimpleButton1.Size = CType(resources.GetObject("SimpleButton1.Size"), System.Drawing.Size)
        Me.SimpleButton1.SuperTip = CType(resources.GetObject("SimpleButton1.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.SimpleButton1.TabIndex = CType(resources.GetObject("SimpleButton1.TabIndex"), Integer)
        Me.SimpleButton1.Text = resources.GetString("SimpleButton1.Text")
        Me.SimpleButton1.ToolTip = resources.GetString("SimpleButton1.ToolTip")
        Me.SimpleButton1.ToolTipIconType = CType(resources.GetObject("SimpleButton1.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.SimpleButton1.ToolTipTitle = resources.GetString("SimpleButton1.ToolTipTitle")
        Me.SimpleButton1.Visible = CType(resources.GetObject("SimpleButton1.Visible"), Boolean)
        '
        'frmFillCustForMail_Browse
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
        Me.Name = "frmFillCustForMail_Browse"
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
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        objDS = New dsPur_Sls
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "VIEW_FillCustForMail"
        MyBase.IDField = "Products_ID"
        MyBase.NameField = "Products_Model"
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

    Public Overrides Sub LoadDataSet()
        Dim _SQLTxt As String

        'Clear Table
        objDS.Tables(TableName).Clear()

        _SQLTxt = _
            "        SELECT     customers_id, customers_gender, customers_firstname, customers_lastname, if(customers_dob = '0000-00-00', NULL, customers_dob) as customers_dob, customers_email_address, " & _
            "                      customers_default_address_id, customers_telephone, customers_telephone_evening, customers_fax, customers_password, customers_newsletter, " & _
            "                      customers_newsletterpartner, customers_privilege, customers_privilege_balance, customers_garantie, sponsoring_code, sponsored_code, " & _
            "                      customers_abo, customers_abo_suspended, customers_abo_type, flagminiat1995, customers_abo_method, customers_abo_dvd_norm, " & _
            "                      customers_abo_dvd_adult, customers_abo_dvd_home_norm, customers_abo_dvd_home_adult, if(customers_abo_validityto= '0000-00-00', NULL, customers_abo_validityto) as customers_abo_validityto , throttling, " & _
            "                      customers_abo_rank, customers_abo_start_rentthismonth, customers_abo_dvd_credit, customers_abo_multishipment, " & _
            "                      if (customers_abo_discount_recurring_to_date = '0000-00-00', NULL, customers_abo_discount_recurring_to_date) as customers_abo_discount_recurring_to_date, abotested, customers_abo_status, customers_abo_payment_method, domiciliation_status, " & _
            "                      domiciliation_debiter_name, domiciliation_number, domiciliation_account_number, adult_pwd, ogone_card_type, ogone_card_no, ogone_exp_date, " & _
            "                      ogone_owner, ogone_cc_expiration_status, offline_payment_status, comment, vip, black_listed, red_listed, sm_eligible, customers_enquiry_id, " & _
            "        if (date_first_delivery = '0000-00-00', NULL, date_first_delivery) as date_first_delivery, if (mail_wl_adult_not_sufficient = '0000-00-00', NULL, mail_wl_adult_not_sufficient) as mail_wl_adult_not_sufficient, if ( mail_wl_norm_not_sufficient = '0000-00-00', NULL, mail_wl_norm_not_sufficient) as mail_wl_norm_not_sufficient, mgm_points, wishlist_kind , " & _
            "         if (c.customers_info_date_of_last_logon = '0000-00-00', NULL, c.customers_info_date_of_last_logon) as customers_info_date_of_last_logon, " & _
            "         c.customers_info_number_of_logons, if ( c.customers_info_date_account_created = '0000-00-00' , Null, c.customers_info_date_account_created) as customers_info_date_account_created , " & _
            "         if ( c.customers_info_date_account_last_modified = '0000-00-00', Null, c.customers_info_date_account_last_modified) as customers_info_date_account_last_modified , c.global_product_notifications, " & _
            "         c.customers_language, c.partners_id, c.belgiqueloisirs_id " & _
            " FROM         customers c " & _
            " WHERE 1 "


        BKFilter.ApplyFilter(_SQLTxt, IsFiltered, CurrentFilterID, " ", StatusBar1.Panels(1))
        DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt & _Limit)

        MergeAboInfo()

        'Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        'Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = objDS.Tables(TableName).DefaultView '_View 
        TabControl1.SelectedTabPage = TabResult
    End Sub

    Public Sub MergeAboInfo()
        Dim _row As DataRow
        Dim _row2 As DataRowView
        Dim _SqlTxt As String
        Dim _tmpDS As New dsPur_Sls
        lbl1.Text = "Merging DVD Info"
        lbl1.Refresh()
        ProgressBar1.Properties.Minimum = 0
        ProgressBar1.Properties.Maximum = objDS.Tables(TableName).Rows.Count
        ProgressBar1.EditValue = 0

        For Each _row In objDS.Tables(TableName).Rows
            ProgressBar1.EditValue += 1
            ProgressBar1.Refresh()
            _SqlTxt = "SELECT * from abo LEFT JOIN abo_action ac on ac.id = abo.action where abo.customerid = " & _row("customers_id") & " "
            _tmpDS.Tables("abo").Clear()
            DvdPostData.clsConnection.FillDataSet(_tmpDS.Tables("abo"), _SqlTxt)
            For Each _row2 In _tmpDS.Tables("abo").DefaultView
                _row.BeginEdit()
                _row("abo_action_id_list") = _row("abo_action_id_list") & _row2("id") & " , "
                _row("abo_action_name_list") = _row("abo_action_name_list") & _row2("name") & " , "
                _row.EndEdit()
            Next
            _row("abo_action_count") = _tmpDS.Tables("abo").Rows.Count
            If _tmpDS.Tables("abo").Rows.Count >= 1 Then
                _row("abo_last_action_id") = _tmpDS.Tables("abo").Rows(_tmpDS.Tables("abo").Rows.Count - 1)("id")
                _row("abo_last_action_name") = _tmpDS.Tables("abo").Rows(_tmpDS.Tables("abo").Rows.Count - 1)("name")
            End If
        Next
        ProgressBar1.EditValue = 0
    End Sub
    'Public Sub MergeAboInfo()
    '    Dim _row As DataRow
    '    Dim _view As DataView
    '    Dim _row2 As DataRowView
    '    Dim _SqlTxt As String
    '    Dim _tmpDS As New dsPur_Sls
    '    lbl1.Text = "Merging DVD Info"
    '    lbl1.Refresh()
    '    ProgressBar1.Properties.Minimum = 0
    '    ProgressBar1.Properties.Maximum = objDS.Tables(TableName).Rows.Count
    '    ProgressBar1.EditValue = 0

    '    _SqlTxt = "SELECT * from abo LEFT JOIN abo_action ac on ac.id = abo.action "
    '    _tmpDS.Tables("abo").Clear()
    '     DvdPostData.clsConnection.FillDataSet(_tmpDS.Tables("abo"), _SqlTxt)

    '    For Each _row In objDS.Tables(TableName).Rows
    '        ProgressBar1.EditValue += 1
    '        ProgressBar1.Refresh()
    '        _view = New DataView(_tmpDS.Tables("abo"), "customerid = " & _row("customers_id"), " abo_id", DataViewRowState.CurrentRows)
    '        For Each _row2 In _view
    '            _row.BeginEdit()
    '            _row("abo_action_id_list") = _row("abo_action_id_list") & _row2("id") & " , "
    '            _row("abo_action_name_list") = _row("abo_action_name_list") & _row2("name") & " , "
    '            _row.EndEdit()
    '        Next
    '        _row("abo_action_count") = _view.Count
    '        If _view.Count >= 1 Then
    '            _row("abo_last_action_id") = _view(_view.Count - 1)("id")
    '            _row("abo_last_action_name") = _view(_view.Count - 1)("name")
    '        End If
    '    Next
    '    ProgressBar1.EditValue = 0
    'End Sub

    Private Sub txtLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimit.TextChanged
        _Limit = "limit 0, " & txtLimit.Text
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        MsgBox("Not Yet.", MsgBoxStyle.Exclamation)
    End Sub
End Class
