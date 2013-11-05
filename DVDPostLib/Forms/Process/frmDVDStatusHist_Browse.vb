
Public Class frmDVDStatusHist_Browse

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
    '<System.Diagnostics.DebuggerStepThrough()> 
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDVDStatusHist_Browse))
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLimit = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lbl1 = New System.Windows.Forms.Label
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.TabChart.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        Me.TabResult.SuspendLayout()
        Me.TabParameters.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = CType(resources.GetObject("StatusBar1.Location"), System.Drawing.Point)
        Me.StatusBar1.Name = "StatusBar1"
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
        'Panel1
        '
        Me.Panel1.Location = CType(resources.GetObject("Panel1.Location"), System.Drawing.Point)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = CType(resources.GetObject("Panel1.Size"), System.Drawing.Size)
        '
        'TabAnalyse
        '
        Me.TabAnalyse.Name = "TabAnalyse"
        Me.TabAnalyse.Size = CType(resources.GetObject("TabAnalyse.Size"), System.Drawing.Size)
        '
        'TabResult
        '
        Me.TabResult.Name = "TabResult"
        Me.TabResult.Size = CType(resources.GetObject("TabResult.Size"), System.Drawing.Size)
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
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.Name = "TabControl1"
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
        Me.Grid1.Size = CType(resources.GetObject("Grid1.Size"), System.Drawing.Size)
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
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.ImageIndex = CType(resources.GetObject("Label6.ImageIndex"), Integer)
        Me.Label6.ImeMode = CType(resources.GetObject("Label6.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label6.Location = CType(resources.GetObject("Label6.Location"), System.Drawing.Point)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = CType(resources.GetObject("Label6.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.Label6, CType(resources.GetObject("Label6.ShowHelp"), Boolean))
        Me.Label6.Size = CType(resources.GetObject("Label6.Size"), System.Drawing.Size)
        Me.Label6.TabIndex = CType(resources.GetObject("Label6.TabIndex"), Integer)
        Me.Label6.Text = resources.GetString("Label6.Text")
        'Me.Label6.TextAlign = CType(resources.GetObject("Label6.TextAlign"), System.Drawing.ContentAlignment)
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
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtToDate)
        Me.GroupControl1.Controls.Add(Me.txtFromDate)
        Me.GroupControl1.Dock = CType(resources.GetObject("GroupControl1.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupControl1.Enabled = CType(resources.GetObject("GroupControl1.Enabled"), Boolean)
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
        Me.lbl1.Image = CType(resources.GetObject("lbl1.Image"), System.Drawing.Image)
        Me.lbl1.ImageIndex = CType(resources.GetObject("lbl1.ImageIndex"), Integer)
        Me.lbl1.ImeMode = CType(resources.GetObject("lbl1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lbl1.Location = CType(resources.GetObject("lbl1.Location"), System.Drawing.Point)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.RightToLeft = CType(resources.GetObject("lbl1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.lbl1, CType(resources.GetObject("lbl1.ShowHelp"), Boolean))
        Me.lbl1.Size = CType(resources.GetObject("lbl1.Size"), System.Drawing.Size)
        Me.lbl1.TabIndex = CType(resources.GetObject("lbl1.TabIndex"), Integer)
        Me.lbl1.Text = resources.GetString("lbl1.Text")
        Me.lbl1.Visible = CType(resources.GetObject("lbl1.Visible"), Boolean)
        '
        'txtFromDate
        '
        Me.txtFromDate.Anchor = CType(resources.GetObject("txtFromDate.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtFromDate.BackgroundImage = CType(resources.GetObject("txtFromDate.BackgroundImage"), System.Drawing.Image)
        Me.txtFromDate.Dock = CType(resources.GetObject("txtFromDate.Dock"), System.Windows.Forms.DockStyle)
        Me.txtFromDate.EditValue = CType(resources.GetObject("txtFromDate.EditValue"), Object)
        Me.txtFromDate.Enabled = CType(resources.GetObject("txtFromDate.Enabled"), Boolean)
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
        'frmDVDStatusHist_Browse
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmDVDStatusHist_Browse"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.TabChart.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabResult.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        objDS = New dsProducts
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "products_dvd_status_history_view1"
        MyBase.IDField = "products_dvd_status_history_view1"
        MyBase.NameField = "status_history_id"
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
        Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue)
        Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue)
        'Clear Table
        objDS.Tables(TableName).Clear()
        _SQLTxt = "select pshist.* , su.fullname as user_fullname , ps1.products_dvd_status_name as status_name, ps2.products_dvd_status_name as previous_status_name " & _
            " from products_dvd_status_history pshist " & _
            " left join securityuser su on su.UserID = pshist.User_ID " & _
            " left join products_dvd_status ps1 on ps1.products_dvd_status_id = pshist.status_id " & _
            " left join products_dvd_status ps2 on ps2.products_dvd_status_id = pshist.previous_status_id " & _
            " where status_date >= '" & _DateFromTxt & " 00:00:00' and status_date <= '" & _DateToTxt & " 23:59:59'"

        DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)

        Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
        TabControl1.SelectedTabPage = TabResult
    End Sub
End Class
