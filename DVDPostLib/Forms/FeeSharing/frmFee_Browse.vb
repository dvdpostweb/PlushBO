Public Class frmFee_Browse
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
    Friend WithEvents chkLanguages As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSubTitles As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmOrders_Browse))
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLimit = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.lbl1 = New System.Windows.Forms.Label
        Me.chkSubTitles = New DevExpress.XtraEditors.CheckEdit
        Me.chkLanguages = New DevExpress.XtraEditors.CheckEdit
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtDateTo = New DevExpress.XtraEditors.DateEdit
        Me.txtDateFrom = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.TabAnalyse.SuspendLayout()
        Me.TabResult.SuspendLayout()
        Me.TabParameters.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSubTitles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLanguages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.GroupControl1)
        Me.TabParameters.Controls.Add(Me.GroupControl2)
        Me.TabParameters.Controls.Add(Me.Label6)
        Me.TabParameters.Controls.Add(Me.txtLimit)
        Me.TabParameters.Controls.Add(Me.ProgressBar1)
        Me.TabParameters.Controls.Add(Me.lbl1)
        Me.TabParameters.Name = "TabParameters"
        Me.HelpProvider1.SetShowHelp(Me.TabParameters, CType(resources.GetObject("TabParameters.ShowHelp"), Boolean))
        Me.TabParameters.Size = CType(resources.GetObject("TabParameters.Size"), System.Drawing.Size)
        '
        'UcChart1
        '
        Me.UcChart1.Name = "UcChart1"
        Me.HelpProvider1.SetShowHelp(Me.UcChart1, CType(resources.GetObject("UcChart1.ShowHelp"), Boolean))
        Me.UcChart1.Size = CType(resources.GetObject("UcChart1.Size"), System.Drawing.Size)
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
        '
        'Panel1
        '
        Me.Panel1.Location = CType(resources.GetObject("Panel1.Location"), System.Drawing.Point)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = CType(resources.GetObject("Panel1.Size"), System.Drawing.Size)
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
        'GroupControl2
        '
        Me.GroupControl2.AccessibleDescription = resources.GetString("GroupControl2.AccessibleDescription")
        Me.GroupControl2.AccessibleName = resources.GetString("GroupControl2.AccessibleName")
        Me.GroupControl2.Anchor = CType(resources.GetObject("GroupControl2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AutoScrollMargin = CType(resources.GetObject("GroupControl2.AutoScrollMargin"), System.Drawing.Size)
        Me.GroupControl2.AutoScrollMinSize = CType(resources.GetObject("GroupControl2.AutoScrollMinSize"), System.Drawing.Size)
        Me.GroupControl1.Appearance.Image = CType(resources.GetObject("GroupControl2.BackgroundImage"), System.Drawing.Image)
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
        Me.GroupControl1.Controls.Add(Me.txtDateTo)
        Me.GroupControl1.Controls.Add(Me.txtDateFrom)
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
        'txtDateTo
        '
        Me.txtDateTo.Anchor = CType(resources.GetObject("txtDateTo.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtDateTo.BackgroundImage = CType(resources.GetObject("txtDateTo.BackgroundImage"), System.Drawing.Image)
        Me.txtDateTo.Dock = CType(resources.GetObject("txtDateTo.Dock"), System.Windows.Forms.DockStyle)
        Me.txtDateTo.EditValue = CType(resources.GetObject("txtDateTo.EditValue"), Object)
        Me.txtDateTo.Enabled = CType(resources.GetObject("txtDateTo.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.txtDateTo, resources.GetString("txtDateTo.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtDateTo, CType(resources.GetObject("txtDateTo.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtDateTo, resources.GetString("txtDateTo.HelpString"))
        Me.txtDateTo.ImeMode = CType(resources.GetObject("txtDateTo.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtDateTo.Location = CType(resources.GetObject("txtDateTo.Location"), System.Drawing.Point)
        Me.txtDateTo.Name = "txtDateTo"
        '
        'txtDateTo.Properties
        '
        Me.txtDateTo.Properties.AccessibleDescription = resources.GetString("txtDateTo.Properties.AccessibleDescription")
        Me.txtDateTo.Properties.AccessibleName = resources.GetString("txtDateTo.Properties.AccessibleName")
        Me.txtDateTo.Properties.AutoHeight = CType(resources.GetObject("txtDateTo.Properties.AutoHeight"), Boolean)
        Me.txtDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateTo.Properties.Mask.AutoComplete = CType(resources.GetObject("txtDateTo.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDateTo.Properties.Mask.BeepOnError = CType(resources.GetObject("txtDateTo.Properties.Mask.BeepOnError"), Boolean)
        Me.txtDateTo.Properties.Mask.EditMask = resources.GetString("txtDateTo.Properties.Mask.EditMask")
        Me.txtDateTo.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDateTo.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDateTo.Properties.Mask.MaskType = CType(resources.GetObject("txtDateTo.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDateTo.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtDateTo.Properties.Mask.PlaceHolder"), Char)
        Me.txtDateTo.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtDateTo.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtDateTo.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDateTo.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDateTo.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDateTo.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDateTo.Properties.NullText = resources.GetString("txtDateTo.Properties.NullText")
        Me.txtDateTo.RightToLeft = CType(resources.GetObject("txtDateTo.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.txtDateTo, CType(resources.GetObject("txtDateTo.ShowHelp"), Boolean))
        Me.txtDateTo.Size = CType(resources.GetObject("txtDateTo.Size"), System.Drawing.Size)
        Me.txtDateTo.SuperTip = CType(resources.GetObject("txtDateTo.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtDateTo.TabIndex = CType(resources.GetObject("txtDateTo.TabIndex"), Integer)
        Me.txtDateTo.ToolTip = resources.GetString("txtDateTo.ToolTip")
        Me.txtDateTo.ToolTipIconType = CType(resources.GetObject("txtDateTo.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtDateTo.ToolTipTitle = resources.GetString("txtDateTo.ToolTipTitle")
        Me.txtDateTo.Visible = CType(resources.GetObject("txtDateTo.Visible"), Boolean)
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Anchor = CType(resources.GetObject("txtDateFrom.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtDateFrom.BackgroundImage = CType(resources.GetObject("txtDateFrom.BackgroundImage"), System.Drawing.Image)
        Me.txtDateFrom.Dock = CType(resources.GetObject("txtDateFrom.Dock"), System.Windows.Forms.DockStyle)
        Me.txtDateFrom.EditValue = CType(resources.GetObject("txtDateFrom.EditValue"), Object)
        Me.txtDateFrom.Enabled = CType(resources.GetObject("txtDateFrom.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.txtDateFrom, resources.GetString("txtDateFrom.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtDateFrom, CType(resources.GetObject("txtDateFrom.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtDateFrom, resources.GetString("txtDateFrom.HelpString"))
        Me.txtDateFrom.ImeMode = CType(resources.GetObject("txtDateFrom.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtDateFrom.Location = CType(resources.GetObject("txtDateFrom.Location"), System.Drawing.Point)
        Me.txtDateFrom.Name = "txtDateFrom"
        '
        'txtDateFrom.Properties
        '
        Me.txtDateFrom.Properties.AccessibleDescription = resources.GetString("txtDateFrom.Properties.AccessibleDescription")
        Me.txtDateFrom.Properties.AccessibleName = resources.GetString("txtDateFrom.Properties.AccessibleName")
        Me.txtDateFrom.Properties.AutoHeight = CType(resources.GetObject("txtDateFrom.Properties.AutoHeight"), Boolean)
        Me.txtDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateFrom.Properties.Mask.AutoComplete = CType(resources.GetObject("txtDateFrom.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDateFrom.Properties.Mask.BeepOnError = CType(resources.GetObject("txtDateFrom.Properties.Mask.BeepOnError"), Boolean)
        Me.txtDateFrom.Properties.Mask.EditMask = resources.GetString("txtDateFrom.Properties.Mask.EditMask")
        Me.txtDateFrom.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDateFrom.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDateFrom.Properties.Mask.MaskType = CType(resources.GetObject("txtDateFrom.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDateFrom.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtDateFrom.Properties.Mask.PlaceHolder"), Char)
        Me.txtDateFrom.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtDateFrom.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtDateFrom.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDateFrom.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDateFrom.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDateFrom.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDateFrom.Properties.NullText = resources.GetString("txtDateFrom.Properties.NullText")
        Me.txtDateFrom.RightToLeft = CType(resources.GetObject("txtDateFrom.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.txtDateFrom, CType(resources.GetObject("txtDateFrom.ShowHelp"), Boolean))
        Me.txtDateFrom.Size = CType(resources.GetObject("txtDateFrom.Size"), System.Drawing.Size)
        Me.txtDateFrom.SuperTip = CType(resources.GetObject("txtDateFrom.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtDateFrom.TabIndex = CType(resources.GetObject("txtDateFrom.TabIndex"), Integer)
        Me.txtDateFrom.ToolTip = resources.GetString("txtDateFrom.ToolTip")
        Me.txtDateFrom.ToolTipIconType = CType(resources.GetObject("txtDateFrom.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtDateFrom.ToolTipTitle = resources.GetString("txtDateFrom.ToolTipTitle")
        Me.txtDateFrom.Visible = CType(resources.GetObject("txtDateFrom.Visible"), Boolean)
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
        'frmOrders_Browse
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
        Me.Name = "frmOrders_Browse"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabResult.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSubTitles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLanguages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        txtDateFrom.EditValue = Today
        txtDateFrom.EditValue = CDate(txtDateFrom.EditValue).AddDays(-7)
        objDS = New dsFeeSharing
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "Fee_View1"
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

        'Updating Feesharing_end = 0000-00-00 00:00:00 to 1801-01-01 00:00:00
        _SQLTxt = "Update Products Set Feesharing_end = NULL where Feesharing_End = '0000-00-00 00:00:00'"
        lbl1.Text = "updating : " & DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        _SQLTxt = "Update Products Set Products_Sale_Date = NULL where Products_Sale_Date = '0000-00-00 00:00:00'"
        lbl1.Text = "updating : " & DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)

        'Products
        _SQLTxt = " SELECT   o.orders_id, if (o.date_purchased = '0000-00-00' , Null, o.date_purchased) as date_purchased,   " & _
                  " p.products_id, p.feesharing, if (p.feesharing_end = '0000-00-00', Null, p.feesharing_end) as feesharing_end , " & _
                  " o.customers_id, p.products_model, p.products_title, p.feesharing_upfront_fee , p.feesharing_upfront_fee_recoverable, " & _
                  " p.feesharing_turn_price, p.feesharing_turn_price_after3month, p.feesharing_buy_option_price, studio.studio_name " & _
            " FROM         orders o " & _
            " LEFT OUTER JOIN orders_products op ON o.orders_id = op.orders_id " & _
            " left OUTER JOIN  products p ON op.products_id = p.products_id " & _
            " LEFT OUTER JOIN  studio ON p.products_studio = studio.studio_id " & _
            " WHERE o.orders_status <> 9  " & _
            " AND o.date_purchased >= '" & txtDateFrom.DateTime.Year & "-" & txtDateFrom.DateTime.Month & "-" & txtDateFrom.DateTime.Day & "' " & _
            " AND o.date_purchased <= '" & txtDateTo.DateTime.Year & "-" & txtDateTo.DateTime.Month & "-" & txtDateTo.DateTime.Day & "' " & _
            " AND p.products_id > 50 "

        'SELECT *
        'FROM Orders_Products OP
        'LEFT JOIN PRODUCTS P ON P.Products_ID = OP.Products_ID
        'LEFT JOIN Orders O on O.Orders_ID = OP.Orders_ID
        'WHERE OP.Products_ID > 50
        'Limit 0, 500


        BKFilter.ApplyFilter(_SQLTxt, IsFiltered, CurrentFilterID, " ", StatusBar1.Panels(1))
        BKGlobal.Cls1.FillDataSet(objDS.Tables(TableName), _SQLTxt)
        MergeProductInfo()

        'Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        'Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = objDS.Tables(TableName).DefaultView '_View 
        TabControl1.SelectedTabPage = TabResult
    End Sub
    Public Sub MergeProductInfo()
        Dim _row As DataRow
        Dim _view As DataView
        Dim _row2 As DataRowView
        Dim _SqlTxt As String
        Dim _tmpDS As New dsPur_Sls
        If chkLanguages.Checked = False And chkSubTitles.Checked = False Then Exit Sub
        lbl1.Text = "Merging DVD Info"
        lbl1.Refresh()
        ProgressBar1.Properties.Minimum = 0
        ProgressBar1.Properties.Maximum = objDS.Tables(TableName).Rows.Count
        ProgressBar1.EditValue = 0
        If chkSubTitles.Checked Then
            _SqlTxt = "SELECT p.products_id, undertitles_id, language_id, undertitles_description as description " & _
                      " FROM products_to_undertitles p left join products_undertitles u " & _
                      "on p.products_undertitles_id = u.undertitles_id WHERe u.language_id = 3"
            BKGlobal.Cls1.FillDataSet(_tmpDS.Tables("products_undertitles_View1"), _SqlTxt)
        End If
        If chkLanguages.Checked Then
            _SqlTxt = "SELECT p.products_id, languages_id, languagenav_id, languages_description as description " & _
                    " FROM products_to_languages p " & _
                    "left join products_languages l on p.products_languages_id = l.languages_id " & _
                    "WHERe l.languagenav_id = 3"
            BKGlobal.Cls1.FillDataSet(_tmpDS.Tables("products_languages_View1"), _SqlTxt)
        End If
        For Each _row In objDS.Tables(TableName).Rows
            ProgressBar1.EditValue += 1
            ProgressBar1.Refresh()
            '_row2 = _tmpDS.Tables("products_undertitles_View1").Rows.Find(New Object() {_row.Item("Product_ID")})
            'Adding SubTitles Info
            If chkSubTitles.Checked Then
                _view = New DataView(_tmpDS.Tables("products_undertitles_View1"), "Products_Id = " & _row.Item("Products_ID"), "", DataViewRowState.CurrentRows)
                For Each _row2 In _view
                    _row.BeginEdit()
                    _row.Item("SubTitles") += _row2.Item("Description") + " , "
                    _row.EndEdit()
                Next
            End If
            'Adding Languages Info
            If chkLanguages.Checked Then
                _view = New DataView(_tmpDS.Tables("products_languages_View1"), "Products_Id = " & _row.Item("Products_ID"), "", DataViewRowState.CurrentRows)
                For Each _row2 In _view
                    _row.BeginEdit()
                    _row.Item("Languages") += _row2.Item("Description") + " , "
                    _row.EndEdit()
                Next
            End If
        Next
        ProgressBar1.EditValue = 0
    End Sub

    Private Sub txtLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimit.TextChanged
        _Limit = "limit 0, " & txtLimit.Text
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub
End Class
