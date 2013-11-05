Public Class frmSlsPur_Browse
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
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtMini3 As System.Windows.Forms.TextBox
    Friend WithEvents txtMini2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMini1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_rank3_2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_rank3_1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_rank2_2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_rank2_1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_rank1_2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_rank1_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblRank1 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtStockMini As System.Windows.Forms.TextBox
    Friend WithEvents lblStockMini As System.Windows.Forms.Label
    Friend WithEvents chkLanguages As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSubTitles As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblDVDStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDVDStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtStockTampon As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents chkUSeStockIN As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents chkStock_with_Cover As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFromID As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSlsPur_Browse))
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLimit = New System.Windows.Forms.TextBox
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.chkStock_with_Cover = New DevExpress.XtraEditors.CheckEdit
        Me.chkUSeStockIN = New DevExpress.XtraEditors.CheckEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtStockTampon = New System.Windows.Forms.TextBox
        Me.txtMini3 = New System.Windows.Forms.TextBox
        Me.txtMini2 = New System.Windows.Forms.TextBox
        Me.txtMini1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblStockMini = New System.Windows.Forms.Label
        Me.txtStockMini = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txt_rank3_2 = New System.Windows.Forms.TextBox
        Me.txt_rank3_1 = New System.Windows.Forms.TextBox
        Me.txt_rank2_2 = New System.Windows.Forms.TextBox
        Me.txt_rank2_1 = New System.Windows.Forms.TextBox
        Me.txt_rank1_2 = New System.Windows.Forms.TextBox
        Me.txt_rank1_1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblRank1 = New System.Windows.Forms.Label
        Me.lbl1 = New System.Windows.Forms.Label
        Me.chkSubTitles = New DevExpress.XtraEditors.CheckEdit
        Me.chkLanguages = New DevExpress.XtraEditors.CheckEdit
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.lblDVDStatus = New DevExpress.XtraEditors.LabelControl
        Me.txtDVDStatus = New DevExpress.XtraEditors.TextEdit
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtToID = New DevExpress.XtraEditors.TextEdit
        Me.txtFromID = New DevExpress.XtraEditors.TextEdit
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabParameters.SuspendLayout()
        Me.TabResult.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabChart.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.chkStock_with_Cover.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUSeStockIN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.chkSubTitles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLanguages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtDVDStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.txtToID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowBands = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.GroupControl4)
        Me.TabParameters.Controls.Add(Me.MemoEdit1)
        Me.TabParameters.Controls.Add(Me.GroupControl2)
        Me.TabParameters.Controls.Add(Me.Label6)
        Me.TabParameters.Controls.Add(Me.txtLimit)
        Me.TabParameters.Controls.Add(Me.GroupControl3)
        Me.TabParameters.Controls.Add(Me.ProgressBar1)
        Me.TabParameters.Controls.Add(Me.GroupControl1)
        Me.TabParameters.Controls.Add(Me.lbl1)
        Me.TabParameters.Name = "TabParameters"
        Me.TabParameters.Size = CType(resources.GetObject("TabParameters.Size"), System.Drawing.Size)
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = CType(resources.GetObject("StatusBar1.Location"), System.Drawing.Point)
        Me.StatusBar1.Name = "StatusBar1"
        Me.ToolTipController1.SetSuperTip(Me.StatusBar1, CType(resources.GetObject("StatusBar1.SuperTip"), DevExpress.Utils.SuperToolTip))
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
        Me.ToolTipController1.SetSuperTip(Me.UcPivotGrid1, CType(resources.GetObject("UcPivotGrid1.SuperTip"), DevExpress.Utils.SuperToolTip))
        '
        'Panel1
        '
        Me.Panel1.Location = CType(resources.GetObject("Panel1.Location"), System.Drawing.Point)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = CType(resources.GetObject("Panel1.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.Panel1, CType(resources.GetObject("Panel1.SuperTip"), DevExpress.Utils.SuperToolTip))
        '
        'UcChart1
        '
        Me.UcChart1.Name = "UcChart1"
        Me.UcChart1.Size = CType(resources.GetObject("UcChart1.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.UcChart1, CType(resources.GetObject("UcChart1.SuperTip"), DevExpress.Utils.SuperToolTip))
        '
        'TabChart
        '
        Me.TabChart.Name = "TabChart"
        Me.TabChart.Size = CType(resources.GetObject("TabChart.Size"), System.Drawing.Size)
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
        Me.Grid1.Size = CType(resources.GetObject("Grid1.Size"), System.Drawing.Size)
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = CType(resources.GetObject("TabControl1.Size"), System.Drawing.Size)
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
        Me.ToolTipController1.SetSuperTip(Me.Label6, CType(resources.GetObject("Label6.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.Label6.TabIndex = CType(resources.GetObject("Label6.TabIndex"), Integer)
        Me.Label6.Text = resources.GetString("Label6.Text")
        Me.Label6.TextAlign = CType(resources.GetObject("Label6.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTipController1.SetTitle(Me.Label6, resources.GetString("Label6.Title"))
        Me.ToolTipController1.SetToolTip(Me.Label6, resources.GetString("Label6.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.Label6, CType(resources.GetObject("Label6.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
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
        Me.ToolTipController1.SetSuperTip(Me.txtLimit, CType(resources.GetObject("txtLimit.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.txtLimit.TabIndex = CType(resources.GetObject("txtLimit.TabIndex"), Integer)
        Me.txtLimit.Text = resources.GetString("txtLimit.Text")
        Me.txtLimit.TextAlign = CType(resources.GetObject("txtLimit.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTipController1.SetTitle(Me.txtLimit, resources.GetString("txtLimit.Title"))
        Me.ToolTipController1.SetToolTip(Me.txtLimit, resources.GetString("txtLimit.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.txtLimit, CType(resources.GetObject("txtLimit.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.txtLimit.Visible = CType(resources.GetObject("txtLimit.Visible"), Boolean)
        Me.txtLimit.WordWrap = CType(resources.GetObject("txtLimit.WordWrap"), Boolean)
        '
        'GroupControl3
        '
        Me.GroupControl3.AccessibleDescription = resources.GetString("GroupControl3.AccessibleDescription")
        Me.GroupControl3.AccessibleName = resources.GetString("GroupControl3.AccessibleName")
        Me.GroupControl3.Anchor = CType(resources.GetObject("GroupControl3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.AutoScrollMargin = CType(resources.GetObject("GroupControl3.AutoScrollMargin"), System.Drawing.Size)
        Me.GroupControl3.AutoScrollMinSize = CType(resources.GetObject("GroupControl3.AutoScrollMinSize"), System.Drawing.Size)
        Me.GroupControl3.Appearance.Image = CType(resources.GetObject("GroupControl3.BackgroundImage"), System.Drawing.Image)
        Me.GroupControl3.Controls.Add(Me.chkStock_with_Cover)
        Me.GroupControl3.Controls.Add(Me.chkUSeStockIN)
        Me.GroupControl3.Controls.Add(Me.Label7)
        Me.GroupControl3.Controls.Add(Me.txtStockTampon)
        Me.GroupControl3.Controls.Add(Me.txtMini3)
        Me.GroupControl3.Controls.Add(Me.txtMini2)
        Me.GroupControl3.Controls.Add(Me.txtMini1)
        Me.GroupControl3.Controls.Add(Me.Label5)
        Me.GroupControl3.Controls.Add(Me.Label4)
        Me.GroupControl3.Controls.Add(Me.Label3)
        Me.GroupControl3.Controls.Add(Me.lblStockMini)
        Me.GroupControl3.Controls.Add(Me.txtStockMini)
        Me.GroupControl3.Dock = CType(resources.GetObject("GroupControl3.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupControl3.Enabled = CType(resources.GetObject("GroupControl3.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.GroupControl3, resources.GetString("GroupControl3.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.GroupControl3, CType(resources.GetObject("GroupControl3.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.GroupControl3, resources.GetString("GroupControl3.HelpString"))
        Me.GroupControl3.ImeMode = CType(resources.GetObject("GroupControl3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupControl3.Location = CType(resources.GetObject("GroupControl3.Location"), System.Drawing.Point)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.RightToLeft = CType(resources.GetObject("GroupControl3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.GroupControl3, CType(resources.GetObject("GroupControl3.ShowHelp"), Boolean))
        Me.GroupControl3.Size = CType(resources.GetObject("GroupControl3.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.GroupControl3, CType(resources.GetObject("GroupControl3.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.GroupControl3.TabIndex = CType(resources.GetObject("GroupControl3.TabIndex"), Integer)
        Me.GroupControl3.Text = resources.GetString("GroupControl3.Text")
        Me.ToolTipController1.SetTitle(Me.GroupControl3, resources.GetString("GroupControl3.Title"))
        Me.ToolTipController1.SetToolTip(Me.GroupControl3, resources.GetString("GroupControl3.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.GroupControl3, CType(resources.GetObject("GroupControl3.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.GroupControl3.Visible = CType(resources.GetObject("GroupControl3.Visible"), Boolean)
        '
        'chkStock_with_Cover
        '
        Me.chkStock_with_Cover.Anchor = CType(resources.GetObject("chkStock_with_Cover.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkStock_with_Cover.BackgroundImage = CType(resources.GetObject("chkStock_with_Cover.BackgroundImage"), System.Drawing.Image)
        Me.chkStock_with_Cover.Dock = CType(resources.GetObject("chkStock_with_Cover.Dock"), System.Windows.Forms.DockStyle)
        Me.chkStock_with_Cover.EditValue = CType(resources.GetObject("chkStock_with_Cover.EditValue"), Object)
        Me.chkStock_with_Cover.Enabled = CType(resources.GetObject("chkStock_with_Cover.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.chkStock_with_Cover, resources.GetString("chkStock_with_Cover.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.chkStock_with_Cover, CType(resources.GetObject("chkStock_with_Cover.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.chkStock_with_Cover, resources.GetString("chkStock_with_Cover.HelpString"))
        Me.chkStock_with_Cover.ImeMode = CType(resources.GetObject("chkStock_with_Cover.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkStock_with_Cover.Location = CType(resources.GetObject("chkStock_with_Cover.Location"), System.Drawing.Point)
        Me.chkStock_with_Cover.Name = "chkStock_with_Cover"
        '
        'chkStock_with_Cover.Properties
        '
        Me.chkStock_with_Cover.Properties.AccessibleDescription = resources.GetString("chkStock_with_Cover.Properties.AccessibleDescription")
        Me.chkStock_with_Cover.Properties.AccessibleName = resources.GetString("chkStock_with_Cover.Properties.AccessibleName")
        Me.chkStock_with_Cover.Properties.AutoHeight = CType(resources.GetObject("chkStock_with_Cover.Properties.AutoHeight"), Boolean)
        Me.chkStock_with_Cover.Properties.Caption = resources.GetString("chkStock_with_Cover.Properties.Caption")
        Me.chkStock_with_Cover.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkStock_with_Cover.Properties.NullText = resources.GetString("chkStock_with_Cover.Properties.NullText")
        Me.chkStock_with_Cover.RightToLeft = CType(resources.GetObject("chkStock_with_Cover.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.chkStock_with_Cover, CType(resources.GetObject("chkStock_with_Cover.ShowHelp"), Boolean))
        Me.chkStock_with_Cover.Size = CType(resources.GetObject("chkStock_with_Cover.Size"), System.Drawing.Size)
        Me.chkStock_with_Cover.SuperTip = CType(resources.GetObject("chkStock_with_Cover.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.chkStock_with_Cover.TabIndex = CType(resources.GetObject("chkStock_with_Cover.TabIndex"), Integer)
        Me.chkStock_with_Cover.ToolTip = resources.GetString("chkStock_with_Cover.ToolTip")
        Me.chkStock_with_Cover.ToolTipIconType = CType(resources.GetObject("chkStock_with_Cover.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.chkStock_with_Cover.ToolTipTitle = resources.GetString("chkStock_with_Cover.ToolTipTitle")
        Me.chkStock_with_Cover.Visible = CType(resources.GetObject("chkStock_with_Cover.Visible"), Boolean)
        '
        'chkUSeStockIN
        '
        Me.chkUSeStockIN.Anchor = CType(resources.GetObject("chkUSeStockIN.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkUSeStockIN.BackgroundImage = CType(resources.GetObject("chkUSeStockIN.BackgroundImage"), System.Drawing.Image)
        Me.chkUSeStockIN.Dock = CType(resources.GetObject("chkUSeStockIN.Dock"), System.Windows.Forms.DockStyle)
        Me.chkUSeStockIN.EditValue = CType(resources.GetObject("chkUSeStockIN.EditValue"), Object)
        Me.chkUSeStockIN.Enabled = CType(resources.GetObject("chkUSeStockIN.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.chkUSeStockIN, resources.GetString("chkUSeStockIN.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.chkUSeStockIN, CType(resources.GetObject("chkUSeStockIN.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.chkUSeStockIN, resources.GetString("chkUSeStockIN.HelpString"))
        Me.chkUSeStockIN.ImeMode = CType(resources.GetObject("chkUSeStockIN.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkUSeStockIN.Location = CType(resources.GetObject("chkUSeStockIN.Location"), System.Drawing.Point)
        Me.chkUSeStockIN.Name = "chkUSeStockIN"
        '
        'chkUSeStockIN.Properties
        '
        Me.chkUSeStockIN.Properties.AccessibleDescription = resources.GetString("chkUSeStockIN.Properties.AccessibleDescription")
        Me.chkUSeStockIN.Properties.AccessibleName = resources.GetString("chkUSeStockIN.Properties.AccessibleName")
        Me.chkUSeStockIN.Properties.AutoHeight = CType(resources.GetObject("chkUSeStockIN.Properties.AutoHeight"), Boolean)
        Me.chkUSeStockIN.Properties.Caption = resources.GetString("chkUSeStockIN.Properties.Caption")
        Me.chkUSeStockIN.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkUSeStockIN.Properties.NullText = resources.GetString("chkUSeStockIN.Properties.NullText")
        Me.chkUSeStockIN.RightToLeft = CType(resources.GetObject("chkUSeStockIN.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.chkUSeStockIN, CType(resources.GetObject("chkUSeStockIN.ShowHelp"), Boolean))
        Me.chkUSeStockIN.Size = CType(resources.GetObject("chkUSeStockIN.Size"), System.Drawing.Size)
        Me.chkUSeStockIN.SuperTip = CType(resources.GetObject("chkUSeStockIN.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.chkUSeStockIN.TabIndex = CType(resources.GetObject("chkUSeStockIN.TabIndex"), Integer)
        Me.chkUSeStockIN.ToolTip = resources.GetString("chkUSeStockIN.ToolTip")
        Me.chkUSeStockIN.ToolTipIconType = CType(resources.GetObject("chkUSeStockIN.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.chkUSeStockIN.ToolTipTitle = resources.GetString("chkUSeStockIN.ToolTipTitle")
        Me.chkUSeStockIN.Visible = CType(resources.GetObject("chkUSeStockIN.Visible"), Boolean)
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = resources.GetString("Label7.AccessibleDescription")
        Me.Label7.AccessibleName = resources.GetString("Label7.AccessibleName")
        Me.Label7.Anchor = CType(resources.GetObject("Label7.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = CType(resources.GetObject("Label7.AutoSize"), Boolean)
        Me.Label7.Dock = CType(resources.GetObject("Label7.Dock"), System.Windows.Forms.DockStyle)
        Me.Label7.Enabled = CType(resources.GetObject("Label7.Enabled"), Boolean)
        Me.Label7.Font = CType(resources.GetObject("Label7.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.Label7, resources.GetString("Label7.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.Label7, CType(resources.GetObject("Label7.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.Label7, resources.GetString("Label7.HelpString"))
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.ImageAlign = CType(resources.GetObject("Label7.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label7.ImageIndex = CType(resources.GetObject("Label7.ImageIndex"), Integer)
        Me.Label7.ImeMode = CType(resources.GetObject("Label7.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label7.Location = CType(resources.GetObject("Label7.Location"), System.Drawing.Point)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = CType(resources.GetObject("Label7.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.Label7, CType(resources.GetObject("Label7.ShowHelp"), Boolean))
        Me.Label7.Size = CType(resources.GetObject("Label7.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.Label7, CType(resources.GetObject("Label7.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.Label7.TabIndex = CType(resources.GetObject("Label7.TabIndex"), Integer)
        Me.Label7.Text = resources.GetString("Label7.Text")
        Me.Label7.TextAlign = CType(resources.GetObject("Label7.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTipController1.SetTitle(Me.Label7, resources.GetString("Label7.Title"))
        Me.ToolTipController1.SetToolTip(Me.Label7, resources.GetString("Label7.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.Label7, CType(resources.GetObject("Label7.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.Label7.Visible = CType(resources.GetObject("Label7.Visible"), Boolean)
        '
        'txtStockTampon
        '
        Me.txtStockTampon.AccessibleDescription = resources.GetString("txtStockTampon.AccessibleDescription")
        Me.txtStockTampon.AccessibleName = resources.GetString("txtStockTampon.AccessibleName")
        Me.txtStockTampon.Anchor = CType(resources.GetObject("txtStockTampon.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtStockTampon.AutoSize = CType(resources.GetObject("txtStockTampon.AutoSize"), Boolean)
        Me.txtStockTampon.BackgroundImage = CType(resources.GetObject("txtStockTampon.BackgroundImage"), System.Drawing.Image)
        Me.txtStockTampon.Dock = CType(resources.GetObject("txtStockTampon.Dock"), System.Windows.Forms.DockStyle)
        Me.txtStockTampon.Enabled = CType(resources.GetObject("txtStockTampon.Enabled"), Boolean)
        Me.txtStockTampon.Font = CType(resources.GetObject("txtStockTampon.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.txtStockTampon, resources.GetString("txtStockTampon.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtStockTampon, CType(resources.GetObject("txtStockTampon.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtStockTampon, resources.GetString("txtStockTampon.HelpString"))
        Me.txtStockTampon.ImeMode = CType(resources.GetObject("txtStockTampon.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtStockTampon.Location = CType(resources.GetObject("txtStockTampon.Location"), System.Drawing.Point)
        Me.txtStockTampon.MaxLength = CType(resources.GetObject("txtStockTampon.MaxLength"), Integer)
        Me.txtStockTampon.Multiline = CType(resources.GetObject("txtStockTampon.Multiline"), Boolean)
        Me.txtStockTampon.Name = "txtStockTampon"
        Me.txtStockTampon.PasswordChar = CType(resources.GetObject("txtStockTampon.PasswordChar"), Char)
        Me.txtStockTampon.RightToLeft = CType(resources.GetObject("txtStockTampon.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtStockTampon.ScrollBars = CType(resources.GetObject("txtStockTampon.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.HelpProvider1.SetShowHelp(Me.txtStockTampon, CType(resources.GetObject("txtStockTampon.ShowHelp"), Boolean))
        Me.txtStockTampon.Size = CType(resources.GetObject("txtStockTampon.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.txtStockTampon, CType(resources.GetObject("txtStockTampon.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.txtStockTampon.TabIndex = CType(resources.GetObject("txtStockTampon.TabIndex"), Integer)
        Me.txtStockTampon.Text = resources.GetString("txtStockTampon.Text")
        Me.txtStockTampon.TextAlign = CType(resources.GetObject("txtStockTampon.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTipController1.SetTitle(Me.txtStockTampon, resources.GetString("txtStockTampon.Title"))
        Me.ToolTipController1.SetToolTip(Me.txtStockTampon, resources.GetString("txtStockTampon.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.txtStockTampon, CType(resources.GetObject("txtStockTampon.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.txtStockTampon.Visible = CType(resources.GetObject("txtStockTampon.Visible"), Boolean)
        Me.txtStockTampon.WordWrap = CType(resources.GetObject("txtStockTampon.WordWrap"), Boolean)
        '
        'txtMini3
        '
        Me.txtMini3.AccessibleDescription = resources.GetString("txtMini3.AccessibleDescription")
        Me.txtMini3.AccessibleName = resources.GetString("txtMini3.AccessibleName")
        Me.txtMini3.Anchor = CType(resources.GetObject("txtMini3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtMini3.AutoSize = CType(resources.GetObject("txtMini3.AutoSize"), Boolean)
        Me.txtMini3.BackgroundImage = CType(resources.GetObject("txtMini3.BackgroundImage"), System.Drawing.Image)
        Me.txtMini3.Dock = CType(resources.GetObject("txtMini3.Dock"), System.Windows.Forms.DockStyle)
        Me.txtMini3.Enabled = CType(resources.GetObject("txtMini3.Enabled"), Boolean)
        Me.txtMini3.Font = CType(resources.GetObject("txtMini3.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.txtMini3, resources.GetString("txtMini3.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtMini3, CType(resources.GetObject("txtMini3.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtMini3, resources.GetString("txtMini3.HelpString"))
        Me.txtMini3.ImeMode = CType(resources.GetObject("txtMini3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtMini3.Location = CType(resources.GetObject("txtMini3.Location"), System.Drawing.Point)
        Me.txtMini3.MaxLength = CType(resources.GetObject("txtMini3.MaxLength"), Integer)
        Me.txtMini3.Multiline = CType(resources.GetObject("txtMini3.Multiline"), Boolean)
        Me.txtMini3.Name = "txtMini3"
        Me.txtMini3.PasswordChar = CType(resources.GetObject("txtMini3.PasswordChar"), Char)
        Me.txtMini3.RightToLeft = CType(resources.GetObject("txtMini3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtMini3.ScrollBars = CType(resources.GetObject("txtMini3.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.HelpProvider1.SetShowHelp(Me.txtMini3, CType(resources.GetObject("txtMini3.ShowHelp"), Boolean))
        Me.txtMini3.Size = CType(resources.GetObject("txtMini3.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.txtMini3, CType(resources.GetObject("txtMini3.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.txtMini3.TabIndex = CType(resources.GetObject("txtMini3.TabIndex"), Integer)
        Me.txtMini3.Text = resources.GetString("txtMini3.Text")
        Me.txtMini3.TextAlign = CType(resources.GetObject("txtMini3.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTipController1.SetTitle(Me.txtMini3, resources.GetString("txtMini3.Title"))
        Me.ToolTipController1.SetToolTip(Me.txtMini3, resources.GetString("txtMini3.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.txtMini3, CType(resources.GetObject("txtMini3.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.txtMini3.Visible = CType(resources.GetObject("txtMini3.Visible"), Boolean)
        Me.txtMini3.WordWrap = CType(resources.GetObject("txtMini3.WordWrap"), Boolean)
        '
        'txtMini2
        '
        Me.txtMini2.AccessibleDescription = resources.GetString("txtMini2.AccessibleDescription")
        Me.txtMini2.AccessibleName = resources.GetString("txtMini2.AccessibleName")
        Me.txtMini2.Anchor = CType(resources.GetObject("txtMini2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtMini2.AutoSize = CType(resources.GetObject("txtMini2.AutoSize"), Boolean)
        Me.txtMini2.BackgroundImage = CType(resources.GetObject("txtMini2.BackgroundImage"), System.Drawing.Image)
        Me.txtMini2.Dock = CType(resources.GetObject("txtMini2.Dock"), System.Windows.Forms.DockStyle)
        Me.txtMini2.Enabled = CType(resources.GetObject("txtMini2.Enabled"), Boolean)
        Me.txtMini2.Font = CType(resources.GetObject("txtMini2.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.txtMini2, resources.GetString("txtMini2.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtMini2, CType(resources.GetObject("txtMini2.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtMini2, resources.GetString("txtMini2.HelpString"))
        Me.txtMini2.ImeMode = CType(resources.GetObject("txtMini2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtMini2.Location = CType(resources.GetObject("txtMini2.Location"), System.Drawing.Point)
        Me.txtMini2.MaxLength = CType(resources.GetObject("txtMini2.MaxLength"), Integer)
        Me.txtMini2.Multiline = CType(resources.GetObject("txtMini2.Multiline"), Boolean)
        Me.txtMini2.Name = "txtMini2"
        Me.txtMini2.PasswordChar = CType(resources.GetObject("txtMini2.PasswordChar"), Char)
        Me.txtMini2.RightToLeft = CType(resources.GetObject("txtMini2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtMini2.ScrollBars = CType(resources.GetObject("txtMini2.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.HelpProvider1.SetShowHelp(Me.txtMini2, CType(resources.GetObject("txtMini2.ShowHelp"), Boolean))
        Me.txtMini2.Size = CType(resources.GetObject("txtMini2.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.txtMini2, CType(resources.GetObject("txtMini2.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.txtMini2.TabIndex = CType(resources.GetObject("txtMini2.TabIndex"), Integer)
        Me.txtMini2.Text = resources.GetString("txtMini2.Text")
        Me.txtMini2.TextAlign = CType(resources.GetObject("txtMini2.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTipController1.SetTitle(Me.txtMini2, resources.GetString("txtMini2.Title"))
        Me.ToolTipController1.SetToolTip(Me.txtMini2, resources.GetString("txtMini2.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.txtMini2, CType(resources.GetObject("txtMini2.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.txtMini2.Visible = CType(resources.GetObject("txtMini2.Visible"), Boolean)
        Me.txtMini2.WordWrap = CType(resources.GetObject("txtMini2.WordWrap"), Boolean)
        '
        'txtMini1
        '
        Me.txtMini1.AccessibleDescription = resources.GetString("txtMini1.AccessibleDescription")
        Me.txtMini1.AccessibleName = resources.GetString("txtMini1.AccessibleName")
        Me.txtMini1.Anchor = CType(resources.GetObject("txtMini1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtMini1.AutoSize = CType(resources.GetObject("txtMini1.AutoSize"), Boolean)
        Me.txtMini1.BackgroundImage = CType(resources.GetObject("txtMini1.BackgroundImage"), System.Drawing.Image)
        Me.txtMini1.Dock = CType(resources.GetObject("txtMini1.Dock"), System.Windows.Forms.DockStyle)
        Me.txtMini1.Enabled = CType(resources.GetObject("txtMini1.Enabled"), Boolean)
        Me.txtMini1.Font = CType(resources.GetObject("txtMini1.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.txtMini1, resources.GetString("txtMini1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtMini1, CType(resources.GetObject("txtMini1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtMini1, resources.GetString("txtMini1.HelpString"))
        Me.txtMini1.ImeMode = CType(resources.GetObject("txtMini1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtMini1.Location = CType(resources.GetObject("txtMini1.Location"), System.Drawing.Point)
        Me.txtMini1.MaxLength = CType(resources.GetObject("txtMini1.MaxLength"), Integer)
        Me.txtMini1.Multiline = CType(resources.GetObject("txtMini1.Multiline"), Boolean)
        Me.txtMini1.Name = "txtMini1"
        Me.txtMini1.PasswordChar = CType(resources.GetObject("txtMini1.PasswordChar"), Char)
        Me.txtMini1.RightToLeft = CType(resources.GetObject("txtMini1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtMini1.ScrollBars = CType(resources.GetObject("txtMini1.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.HelpProvider1.SetShowHelp(Me.txtMini1, CType(resources.GetObject("txtMini1.ShowHelp"), Boolean))
        Me.txtMini1.Size = CType(resources.GetObject("txtMini1.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.txtMini1, CType(resources.GetObject("txtMini1.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.txtMini1.TabIndex = CType(resources.GetObject("txtMini1.TabIndex"), Integer)
        Me.txtMini1.Text = resources.GetString("txtMini1.Text")
        Me.txtMini1.TextAlign = CType(resources.GetObject("txtMini1.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTipController1.SetTitle(Me.txtMini1, resources.GetString("txtMini1.Title"))
        Me.ToolTipController1.SetToolTip(Me.txtMini1, resources.GetString("txtMini1.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.txtMini1, CType(resources.GetObject("txtMini1.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.txtMini1.Visible = CType(resources.GetObject("txtMini1.Visible"), Boolean)
        Me.txtMini1.WordWrap = CType(resources.GetObject("txtMini1.WordWrap"), Boolean)
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = resources.GetString("Label5.AccessibleDescription")
        Me.Label5.AccessibleName = resources.GetString("Label5.AccessibleName")
        Me.Label5.Anchor = CType(resources.GetObject("Label5.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = CType(resources.GetObject("Label5.AutoSize"), Boolean)
        Me.Label5.Dock = CType(resources.GetObject("Label5.Dock"), System.Windows.Forms.DockStyle)
        Me.Label5.Enabled = CType(resources.GetObject("Label5.Enabled"), Boolean)
        Me.Label5.Font = CType(resources.GetObject("Label5.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.Label5, resources.GetString("Label5.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.Label5, CType(resources.GetObject("Label5.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.Label5, resources.GetString("Label5.HelpString"))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.ImageAlign = CType(resources.GetObject("Label5.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label5.ImageIndex = CType(resources.GetObject("Label5.ImageIndex"), Integer)
        Me.Label5.ImeMode = CType(resources.GetObject("Label5.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label5.Location = CType(resources.GetObject("Label5.Location"), System.Drawing.Point)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = CType(resources.GetObject("Label5.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.Label5, CType(resources.GetObject("Label5.ShowHelp"), Boolean))
        Me.Label5.Size = CType(resources.GetObject("Label5.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.Label5, CType(resources.GetObject("Label5.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.Label5.TabIndex = CType(resources.GetObject("Label5.TabIndex"), Integer)
        Me.Label5.Text = resources.GetString("Label5.Text")
        Me.Label5.TextAlign = CType(resources.GetObject("Label5.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTipController1.SetTitle(Me.Label5, resources.GetString("Label5.Title"))
        Me.ToolTipController1.SetToolTip(Me.Label5, resources.GetString("Label5.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.Label5, CType(resources.GetObject("Label5.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.Label5.Visible = CType(resources.GetObject("Label5.Visible"), Boolean)
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = resources.GetString("Label4.AccessibleDescription")
        Me.Label4.AccessibleName = resources.GetString("Label4.AccessibleName")
        Me.Label4.Anchor = CType(resources.GetObject("Label4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = CType(resources.GetObject("Label4.AutoSize"), Boolean)
        Me.Label4.Dock = CType(resources.GetObject("Label4.Dock"), System.Windows.Forms.DockStyle)
        Me.Label4.Enabled = CType(resources.GetObject("Label4.Enabled"), Boolean)
        Me.Label4.Font = CType(resources.GetObject("Label4.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.Label4, resources.GetString("Label4.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.Label4, CType(resources.GetObject("Label4.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.Label4, resources.GetString("Label4.HelpString"))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = CType(resources.GetObject("Label4.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label4.ImageIndex = CType(resources.GetObject("Label4.ImageIndex"), Integer)
        Me.Label4.ImeMode = CType(resources.GetObject("Label4.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label4.Location = CType(resources.GetObject("Label4.Location"), System.Drawing.Point)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = CType(resources.GetObject("Label4.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.Label4, CType(resources.GetObject("Label4.ShowHelp"), Boolean))
        Me.Label4.Size = CType(resources.GetObject("Label4.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.Label4, CType(resources.GetObject("Label4.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.Label4.TabIndex = CType(resources.GetObject("Label4.TabIndex"), Integer)
        Me.Label4.Text = resources.GetString("Label4.Text")
        Me.Label4.TextAlign = CType(resources.GetObject("Label4.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTipController1.SetTitle(Me.Label4, resources.GetString("Label4.Title"))
        Me.ToolTipController1.SetToolTip(Me.Label4, resources.GetString("Label4.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.Label4, CType(resources.GetObject("Label4.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.Label4.Visible = CType(resources.GetObject("Label4.Visible"), Boolean)
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = resources.GetString("Label3.AccessibleDescription")
        Me.Label3.AccessibleName = resources.GetString("Label3.AccessibleName")
        Me.Label3.Anchor = CType(resources.GetObject("Label3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = CType(resources.GetObject("Label3.AutoSize"), Boolean)
        Me.Label3.Dock = CType(resources.GetObject("Label3.Dock"), System.Windows.Forms.DockStyle)
        Me.Label3.Enabled = CType(resources.GetObject("Label3.Enabled"), Boolean)
        Me.Label3.Font = CType(resources.GetObject("Label3.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.Label3, resources.GetString("Label3.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.Label3, CType(resources.GetObject("Label3.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.Label3, resources.GetString("Label3.HelpString"))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = CType(resources.GetObject("Label3.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label3.ImageIndex = CType(resources.GetObject("Label3.ImageIndex"), Integer)
        Me.Label3.ImeMode = CType(resources.GetObject("Label3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label3.Location = CType(resources.GetObject("Label3.Location"), System.Drawing.Point)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = CType(resources.GetObject("Label3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.Label3, CType(resources.GetObject("Label3.ShowHelp"), Boolean))
        Me.Label3.Size = CType(resources.GetObject("Label3.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.Label3, CType(resources.GetObject("Label3.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.Label3.TabIndex = CType(resources.GetObject("Label3.TabIndex"), Integer)
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = CType(resources.GetObject("Label3.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTipController1.SetTitle(Me.Label3, resources.GetString("Label3.Title"))
        Me.ToolTipController1.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.Label3, CType(resources.GetObject("Label3.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.Label3.Visible = CType(resources.GetObject("Label3.Visible"), Boolean)
        '
        'lblStockMini
        '
        Me.lblStockMini.AccessibleDescription = resources.GetString("lblStockMini.AccessibleDescription")
        Me.lblStockMini.AccessibleName = resources.GetString("lblStockMini.AccessibleName")
        Me.lblStockMini.Anchor = CType(resources.GetObject("lblStockMini.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblStockMini.AutoSize = CType(resources.GetObject("lblStockMini.AutoSize"), Boolean)
        Me.lblStockMini.Dock = CType(resources.GetObject("lblStockMini.Dock"), System.Windows.Forms.DockStyle)
        Me.lblStockMini.Enabled = CType(resources.GetObject("lblStockMini.Enabled"), Boolean)
        Me.lblStockMini.Font = CType(resources.GetObject("lblStockMini.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.lblStockMini, resources.GetString("lblStockMini.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblStockMini, CType(resources.GetObject("lblStockMini.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblStockMini, resources.GetString("lblStockMini.HelpString"))
        Me.lblStockMini.Image = CType(resources.GetObject("lblStockMini.Image"), System.Drawing.Image)
        Me.lblStockMini.ImageAlign = CType(resources.GetObject("lblStockMini.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblStockMini.ImageIndex = CType(resources.GetObject("lblStockMini.ImageIndex"), Integer)
        Me.lblStockMini.ImeMode = CType(resources.GetObject("lblStockMini.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblStockMini.Location = CType(resources.GetObject("lblStockMini.Location"), System.Drawing.Point)
        Me.lblStockMini.Name = "lblStockMini"
        Me.lblStockMini.RightToLeft = CType(resources.GetObject("lblStockMini.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.lblStockMini, CType(resources.GetObject("lblStockMini.ShowHelp"), Boolean))
        Me.lblStockMini.Size = CType(resources.GetObject("lblStockMini.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.lblStockMini, CType(resources.GetObject("lblStockMini.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.lblStockMini.TabIndex = CType(resources.GetObject("lblStockMini.TabIndex"), Integer)
        Me.lblStockMini.Text = resources.GetString("lblStockMini.Text")
        Me.lblStockMini.TextAlign = CType(resources.GetObject("lblStockMini.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTipController1.SetTitle(Me.lblStockMini, resources.GetString("lblStockMini.Title"))
        Me.ToolTipController1.SetToolTip(Me.lblStockMini, resources.GetString("lblStockMini.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.lblStockMini, CType(resources.GetObject("lblStockMini.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.lblStockMini.Visible = CType(resources.GetObject("lblStockMini.Visible"), Boolean)
        '
        'txtStockMini
        '
        Me.txtStockMini.AccessibleDescription = resources.GetString("txtStockMini.AccessibleDescription")
        Me.txtStockMini.AccessibleName = resources.GetString("txtStockMini.AccessibleName")
        Me.txtStockMini.Anchor = CType(resources.GetObject("txtStockMini.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtStockMini.AutoSize = CType(resources.GetObject("txtStockMini.AutoSize"), Boolean)
        Me.txtStockMini.BackgroundImage = CType(resources.GetObject("txtStockMini.BackgroundImage"), System.Drawing.Image)
        Me.txtStockMini.Dock = CType(resources.GetObject("txtStockMini.Dock"), System.Windows.Forms.DockStyle)
        Me.txtStockMini.Enabled = CType(resources.GetObject("txtStockMini.Enabled"), Boolean)
        Me.txtStockMini.Font = CType(resources.GetObject("txtStockMini.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.txtStockMini, resources.GetString("txtStockMini.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtStockMini, CType(resources.GetObject("txtStockMini.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtStockMini, resources.GetString("txtStockMini.HelpString"))
        Me.txtStockMini.ImeMode = CType(resources.GetObject("txtStockMini.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtStockMini.Location = CType(resources.GetObject("txtStockMini.Location"), System.Drawing.Point)
        Me.txtStockMini.MaxLength = CType(resources.GetObject("txtStockMini.MaxLength"), Integer)
        Me.txtStockMini.Multiline = CType(resources.GetObject("txtStockMini.Multiline"), Boolean)
        Me.txtStockMini.Name = "txtStockMini"
        Me.txtStockMini.PasswordChar = CType(resources.GetObject("txtStockMini.PasswordChar"), Char)
        Me.txtStockMini.RightToLeft = CType(resources.GetObject("txtStockMini.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtStockMini.ScrollBars = CType(resources.GetObject("txtStockMini.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.HelpProvider1.SetShowHelp(Me.txtStockMini, CType(resources.GetObject("txtStockMini.ShowHelp"), Boolean))
        Me.txtStockMini.Size = CType(resources.GetObject("txtStockMini.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.txtStockMini, CType(resources.GetObject("txtStockMini.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.txtStockMini.TabIndex = CType(resources.GetObject("txtStockMini.TabIndex"), Integer)
        Me.txtStockMini.Text = resources.GetString("txtStockMini.Text")
        Me.txtStockMini.TextAlign = CType(resources.GetObject("txtStockMini.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTipController1.SetTitle(Me.txtStockMini, resources.GetString("txtStockMini.Title"))
        Me.ToolTipController1.SetToolTip(Me.txtStockMini, resources.GetString("txtStockMini.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.txtStockMini, CType(resources.GetObject("txtStockMini.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.txtStockMini.Visible = CType(resources.GetObject("txtStockMini.Visible"), Boolean)
        Me.txtStockMini.WordWrap = CType(resources.GetObject("txtStockMini.WordWrap"), Boolean)
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
        Me.GroupControl1.Controls.Add(Me.txt_rank3_2)
        Me.GroupControl1.Controls.Add(Me.txt_rank3_1)
        Me.GroupControl1.Controls.Add(Me.txt_rank2_2)
        Me.GroupControl1.Controls.Add(Me.txt_rank2_1)
        Me.GroupControl1.Controls.Add(Me.txt_rank1_2)
        Me.GroupControl1.Controls.Add(Me.txt_rank1_1)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.lblRank1)
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
        Me.ToolTipController1.SetSuperTip(Me.GroupControl1, CType(resources.GetObject("GroupControl1.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.GroupControl1.TabIndex = CType(resources.GetObject("GroupControl1.TabIndex"), Integer)
        Me.GroupControl1.Text = resources.GetString("GroupControl1.Text")
        Me.ToolTipController1.SetTitle(Me.GroupControl1, resources.GetString("GroupControl1.Title"))
        Me.ToolTipController1.SetToolTip(Me.GroupControl1, resources.GetString("GroupControl1.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.GroupControl1, CType(resources.GetObject("GroupControl1.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.GroupControl1.Visible = CType(resources.GetObject("GroupControl1.Visible"), Boolean)
        '
        'txt_rank3_2
        '
        Me.txt_rank3_2.AccessibleDescription = resources.GetString("txt_rank3_2.AccessibleDescription")
        Me.txt_rank3_2.AccessibleName = resources.GetString("txt_rank3_2.AccessibleName")
        Me.txt_rank3_2.Anchor = CType(resources.GetObject("txt_rank3_2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_rank3_2.AutoSize = CType(resources.GetObject("txt_rank3_2.AutoSize"), Boolean)
        Me.txt_rank3_2.BackgroundImage = CType(resources.GetObject("txt_rank3_2.BackgroundImage"), System.Drawing.Image)
        Me.txt_rank3_2.Dock = CType(resources.GetObject("txt_rank3_2.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_rank3_2.Enabled = CType(resources.GetObject("txt_rank3_2.Enabled"), Boolean)
        Me.txt_rank3_2.Font = CType(resources.GetObject("txt_rank3_2.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.txt_rank3_2, resources.GetString("txt_rank3_2.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txt_rank3_2, CType(resources.GetObject("txt_rank3_2.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txt_rank3_2, resources.GetString("txt_rank3_2.HelpString"))
        Me.txt_rank3_2.ImeMode = CType(resources.GetObject("txt_rank3_2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_rank3_2.Location = CType(resources.GetObject("txt_rank3_2.Location"), System.Drawing.Point)
        Me.txt_rank3_2.MaxLength = CType(resources.GetObject("txt_rank3_2.MaxLength"), Integer)
        Me.txt_rank3_2.Multiline = CType(resources.GetObject("txt_rank3_2.Multiline"), Boolean)
        Me.txt_rank3_2.Name = "txt_rank3_2"
        Me.txt_rank3_2.PasswordChar = CType(resources.GetObject("txt_rank3_2.PasswordChar"), Char)
        Me.txt_rank3_2.RightToLeft = CType(resources.GetObject("txt_rank3_2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_rank3_2.ScrollBars = CType(resources.GetObject("txt_rank3_2.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.HelpProvider1.SetShowHelp(Me.txt_rank3_2, CType(resources.GetObject("txt_rank3_2.ShowHelp"), Boolean))
        Me.txt_rank3_2.Size = CType(resources.GetObject("txt_rank3_2.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.txt_rank3_2, CType(resources.GetObject("txt_rank3_2.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.txt_rank3_2.TabIndex = CType(resources.GetObject("txt_rank3_2.TabIndex"), Integer)
        Me.txt_rank3_2.Text = resources.GetString("txt_rank3_2.Text")
        Me.txt_rank3_2.TextAlign = CType(resources.GetObject("txt_rank3_2.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTipController1.SetTitle(Me.txt_rank3_2, resources.GetString("txt_rank3_2.Title"))
        Me.ToolTipController1.SetToolTip(Me.txt_rank3_2, resources.GetString("txt_rank3_2.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.txt_rank3_2, CType(resources.GetObject("txt_rank3_2.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.txt_rank3_2.Visible = CType(resources.GetObject("txt_rank3_2.Visible"), Boolean)
        Me.txt_rank3_2.WordWrap = CType(resources.GetObject("txt_rank3_2.WordWrap"), Boolean)
        '
        'txt_rank3_1
        '
        Me.txt_rank3_1.AccessibleDescription = resources.GetString("txt_rank3_1.AccessibleDescription")
        Me.txt_rank3_1.AccessibleName = resources.GetString("txt_rank3_1.AccessibleName")
        Me.txt_rank3_1.Anchor = CType(resources.GetObject("txt_rank3_1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_rank3_1.AutoSize = CType(resources.GetObject("txt_rank3_1.AutoSize"), Boolean)
        Me.txt_rank3_1.BackgroundImage = CType(resources.GetObject("txt_rank3_1.BackgroundImage"), System.Drawing.Image)
        Me.txt_rank3_1.Dock = CType(resources.GetObject("txt_rank3_1.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_rank3_1.Enabled = CType(resources.GetObject("txt_rank3_1.Enabled"), Boolean)
        Me.txt_rank3_1.Font = CType(resources.GetObject("txt_rank3_1.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.txt_rank3_1, resources.GetString("txt_rank3_1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txt_rank3_1, CType(resources.GetObject("txt_rank3_1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txt_rank3_1, resources.GetString("txt_rank3_1.HelpString"))
        Me.txt_rank3_1.ImeMode = CType(resources.GetObject("txt_rank3_1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_rank3_1.Location = CType(resources.GetObject("txt_rank3_1.Location"), System.Drawing.Point)
        Me.txt_rank3_1.MaxLength = CType(resources.GetObject("txt_rank3_1.MaxLength"), Integer)
        Me.txt_rank3_1.Multiline = CType(resources.GetObject("txt_rank3_1.Multiline"), Boolean)
        Me.txt_rank3_1.Name = "txt_rank3_1"
        Me.txt_rank3_1.PasswordChar = CType(resources.GetObject("txt_rank3_1.PasswordChar"), Char)
        Me.txt_rank3_1.RightToLeft = CType(resources.GetObject("txt_rank3_1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_rank3_1.ScrollBars = CType(resources.GetObject("txt_rank3_1.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.HelpProvider1.SetShowHelp(Me.txt_rank3_1, CType(resources.GetObject("txt_rank3_1.ShowHelp"), Boolean))
        Me.txt_rank3_1.Size = CType(resources.GetObject("txt_rank3_1.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.txt_rank3_1, CType(resources.GetObject("txt_rank3_1.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.txt_rank3_1.TabIndex = CType(resources.GetObject("txt_rank3_1.TabIndex"), Integer)
        Me.txt_rank3_1.Text = resources.GetString("txt_rank3_1.Text")
        Me.txt_rank3_1.TextAlign = CType(resources.GetObject("txt_rank3_1.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTipController1.SetTitle(Me.txt_rank3_1, resources.GetString("txt_rank3_1.Title"))
        Me.ToolTipController1.SetToolTip(Me.txt_rank3_1, resources.GetString("txt_rank3_1.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.txt_rank3_1, CType(resources.GetObject("txt_rank3_1.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.txt_rank3_1.Visible = CType(resources.GetObject("txt_rank3_1.Visible"), Boolean)
        Me.txt_rank3_1.WordWrap = CType(resources.GetObject("txt_rank3_1.WordWrap"), Boolean)
        '
        'txt_rank2_2
        '
        Me.txt_rank2_2.AccessibleDescription = resources.GetString("txt_rank2_2.AccessibleDescription")
        Me.txt_rank2_2.AccessibleName = resources.GetString("txt_rank2_2.AccessibleName")
        Me.txt_rank2_2.Anchor = CType(resources.GetObject("txt_rank2_2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_rank2_2.AutoSize = CType(resources.GetObject("txt_rank2_2.AutoSize"), Boolean)
        Me.txt_rank2_2.BackgroundImage = CType(resources.GetObject("txt_rank2_2.BackgroundImage"), System.Drawing.Image)
        Me.txt_rank2_2.Dock = CType(resources.GetObject("txt_rank2_2.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_rank2_2.Enabled = CType(resources.GetObject("txt_rank2_2.Enabled"), Boolean)
        Me.txt_rank2_2.Font = CType(resources.GetObject("txt_rank2_2.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.txt_rank2_2, resources.GetString("txt_rank2_2.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txt_rank2_2, CType(resources.GetObject("txt_rank2_2.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txt_rank2_2, resources.GetString("txt_rank2_2.HelpString"))
        Me.txt_rank2_2.ImeMode = CType(resources.GetObject("txt_rank2_2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_rank2_2.Location = CType(resources.GetObject("txt_rank2_2.Location"), System.Drawing.Point)
        Me.txt_rank2_2.MaxLength = CType(resources.GetObject("txt_rank2_2.MaxLength"), Integer)
        Me.txt_rank2_2.Multiline = CType(resources.GetObject("txt_rank2_2.Multiline"), Boolean)
        Me.txt_rank2_2.Name = "txt_rank2_2"
        Me.txt_rank2_2.PasswordChar = CType(resources.GetObject("txt_rank2_2.PasswordChar"), Char)
        Me.txt_rank2_2.RightToLeft = CType(resources.GetObject("txt_rank2_2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_rank2_2.ScrollBars = CType(resources.GetObject("txt_rank2_2.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.HelpProvider1.SetShowHelp(Me.txt_rank2_2, CType(resources.GetObject("txt_rank2_2.ShowHelp"), Boolean))
        Me.txt_rank2_2.Size = CType(resources.GetObject("txt_rank2_2.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.txt_rank2_2, CType(resources.GetObject("txt_rank2_2.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.txt_rank2_2.TabIndex = CType(resources.GetObject("txt_rank2_2.TabIndex"), Integer)
        Me.txt_rank2_2.Text = resources.GetString("txt_rank2_2.Text")
        Me.txt_rank2_2.TextAlign = CType(resources.GetObject("txt_rank2_2.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTipController1.SetTitle(Me.txt_rank2_2, resources.GetString("txt_rank2_2.Title"))
        Me.ToolTipController1.SetToolTip(Me.txt_rank2_2, resources.GetString("txt_rank2_2.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.txt_rank2_2, CType(resources.GetObject("txt_rank2_2.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.txt_rank2_2.Visible = CType(resources.GetObject("txt_rank2_2.Visible"), Boolean)
        Me.txt_rank2_2.WordWrap = CType(resources.GetObject("txt_rank2_2.WordWrap"), Boolean)
        '
        'txt_rank2_1
        '
        Me.txt_rank2_1.AccessibleDescription = resources.GetString("txt_rank2_1.AccessibleDescription")
        Me.txt_rank2_1.AccessibleName = resources.GetString("txt_rank2_1.AccessibleName")
        Me.txt_rank2_1.Anchor = CType(resources.GetObject("txt_rank2_1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_rank2_1.AutoSize = CType(resources.GetObject("txt_rank2_1.AutoSize"), Boolean)
        Me.txt_rank2_1.BackgroundImage = CType(resources.GetObject("txt_rank2_1.BackgroundImage"), System.Drawing.Image)
        Me.txt_rank2_1.Dock = CType(resources.GetObject("txt_rank2_1.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_rank2_1.Enabled = CType(resources.GetObject("txt_rank2_1.Enabled"), Boolean)
        Me.txt_rank2_1.Font = CType(resources.GetObject("txt_rank2_1.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.txt_rank2_1, resources.GetString("txt_rank2_1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txt_rank2_1, CType(resources.GetObject("txt_rank2_1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txt_rank2_1, resources.GetString("txt_rank2_1.HelpString"))
        Me.txt_rank2_1.ImeMode = CType(resources.GetObject("txt_rank2_1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_rank2_1.Location = CType(resources.GetObject("txt_rank2_1.Location"), System.Drawing.Point)
        Me.txt_rank2_1.MaxLength = CType(resources.GetObject("txt_rank2_1.MaxLength"), Integer)
        Me.txt_rank2_1.Multiline = CType(resources.GetObject("txt_rank2_1.Multiline"), Boolean)
        Me.txt_rank2_1.Name = "txt_rank2_1"
        Me.txt_rank2_1.PasswordChar = CType(resources.GetObject("txt_rank2_1.PasswordChar"), Char)
        Me.txt_rank2_1.RightToLeft = CType(resources.GetObject("txt_rank2_1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_rank2_1.ScrollBars = CType(resources.GetObject("txt_rank2_1.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.HelpProvider1.SetShowHelp(Me.txt_rank2_1, CType(resources.GetObject("txt_rank2_1.ShowHelp"), Boolean))
        Me.txt_rank2_1.Size = CType(resources.GetObject("txt_rank2_1.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.txt_rank2_1, CType(resources.GetObject("txt_rank2_1.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.txt_rank2_1.TabIndex = CType(resources.GetObject("txt_rank2_1.TabIndex"), Integer)
        Me.txt_rank2_1.Text = resources.GetString("txt_rank2_1.Text")
        Me.txt_rank2_1.TextAlign = CType(resources.GetObject("txt_rank2_1.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTipController1.SetTitle(Me.txt_rank2_1, resources.GetString("txt_rank2_1.Title"))
        Me.ToolTipController1.SetToolTip(Me.txt_rank2_1, resources.GetString("txt_rank2_1.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.txt_rank2_1, CType(resources.GetObject("txt_rank2_1.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.txt_rank2_1.Visible = CType(resources.GetObject("txt_rank2_1.Visible"), Boolean)
        Me.txt_rank2_1.WordWrap = CType(resources.GetObject("txt_rank2_1.WordWrap"), Boolean)
        '
        'txt_rank1_2
        '
        Me.txt_rank1_2.AccessibleDescription = resources.GetString("txt_rank1_2.AccessibleDescription")
        Me.txt_rank1_2.AccessibleName = resources.GetString("txt_rank1_2.AccessibleName")
        Me.txt_rank1_2.Anchor = CType(resources.GetObject("txt_rank1_2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_rank1_2.AutoSize = CType(resources.GetObject("txt_rank1_2.AutoSize"), Boolean)
        Me.txt_rank1_2.BackgroundImage = CType(resources.GetObject("txt_rank1_2.BackgroundImage"), System.Drawing.Image)
        Me.txt_rank1_2.Dock = CType(resources.GetObject("txt_rank1_2.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_rank1_2.Enabled = CType(resources.GetObject("txt_rank1_2.Enabled"), Boolean)
        Me.txt_rank1_2.Font = CType(resources.GetObject("txt_rank1_2.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.txt_rank1_2, resources.GetString("txt_rank1_2.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txt_rank1_2, CType(resources.GetObject("txt_rank1_2.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txt_rank1_2, resources.GetString("txt_rank1_2.HelpString"))
        Me.txt_rank1_2.ImeMode = CType(resources.GetObject("txt_rank1_2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_rank1_2.Location = CType(resources.GetObject("txt_rank1_2.Location"), System.Drawing.Point)
        Me.txt_rank1_2.MaxLength = CType(resources.GetObject("txt_rank1_2.MaxLength"), Integer)
        Me.txt_rank1_2.Multiline = CType(resources.GetObject("txt_rank1_2.Multiline"), Boolean)
        Me.txt_rank1_2.Name = "txt_rank1_2"
        Me.txt_rank1_2.PasswordChar = CType(resources.GetObject("txt_rank1_2.PasswordChar"), Char)
        Me.txt_rank1_2.RightToLeft = CType(resources.GetObject("txt_rank1_2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_rank1_2.ScrollBars = CType(resources.GetObject("txt_rank1_2.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.HelpProvider1.SetShowHelp(Me.txt_rank1_2, CType(resources.GetObject("txt_rank1_2.ShowHelp"), Boolean))
        Me.txt_rank1_2.Size = CType(resources.GetObject("txt_rank1_2.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.txt_rank1_2, CType(resources.GetObject("txt_rank1_2.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.txt_rank1_2.TabIndex = CType(resources.GetObject("txt_rank1_2.TabIndex"), Integer)
        Me.txt_rank1_2.Text = resources.GetString("txt_rank1_2.Text")
        Me.txt_rank1_2.TextAlign = CType(resources.GetObject("txt_rank1_2.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTipController1.SetTitle(Me.txt_rank1_2, resources.GetString("txt_rank1_2.Title"))
        Me.ToolTipController1.SetToolTip(Me.txt_rank1_2, resources.GetString("txt_rank1_2.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.txt_rank1_2, CType(resources.GetObject("txt_rank1_2.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.txt_rank1_2.Visible = CType(resources.GetObject("txt_rank1_2.Visible"), Boolean)
        Me.txt_rank1_2.WordWrap = CType(resources.GetObject("txt_rank1_2.WordWrap"), Boolean)
        '
        'txt_rank1_1
        '
        Me.txt_rank1_1.AccessibleDescription = resources.GetString("txt_rank1_1.AccessibleDescription")
        Me.txt_rank1_1.AccessibleName = resources.GetString("txt_rank1_1.AccessibleName")
        Me.txt_rank1_1.Anchor = CType(resources.GetObject("txt_rank1_1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_rank1_1.AutoSize = CType(resources.GetObject("txt_rank1_1.AutoSize"), Boolean)
        Me.txt_rank1_1.BackgroundImage = CType(resources.GetObject("txt_rank1_1.BackgroundImage"), System.Drawing.Image)
        Me.txt_rank1_1.Dock = CType(resources.GetObject("txt_rank1_1.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_rank1_1.Enabled = CType(resources.GetObject("txt_rank1_1.Enabled"), Boolean)
        Me.txt_rank1_1.Font = CType(resources.GetObject("txt_rank1_1.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.txt_rank1_1, resources.GetString("txt_rank1_1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txt_rank1_1, CType(resources.GetObject("txt_rank1_1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txt_rank1_1, resources.GetString("txt_rank1_1.HelpString"))
        Me.txt_rank1_1.ImeMode = CType(resources.GetObject("txt_rank1_1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_rank1_1.Location = CType(resources.GetObject("txt_rank1_1.Location"), System.Drawing.Point)
        Me.txt_rank1_1.MaxLength = CType(resources.GetObject("txt_rank1_1.MaxLength"), Integer)
        Me.txt_rank1_1.Multiline = CType(resources.GetObject("txt_rank1_1.Multiline"), Boolean)
        Me.txt_rank1_1.Name = "txt_rank1_1"
        Me.txt_rank1_1.PasswordChar = CType(resources.GetObject("txt_rank1_1.PasswordChar"), Char)
        Me.txt_rank1_1.RightToLeft = CType(resources.GetObject("txt_rank1_1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_rank1_1.ScrollBars = CType(resources.GetObject("txt_rank1_1.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.HelpProvider1.SetShowHelp(Me.txt_rank1_1, CType(resources.GetObject("txt_rank1_1.ShowHelp"), Boolean))
        Me.txt_rank1_1.Size = CType(resources.GetObject("txt_rank1_1.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.txt_rank1_1, CType(resources.GetObject("txt_rank1_1.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.txt_rank1_1.TabIndex = CType(resources.GetObject("txt_rank1_1.TabIndex"), Integer)
        Me.txt_rank1_1.Text = resources.GetString("txt_rank1_1.Text")
        Me.txt_rank1_1.TextAlign = CType(resources.GetObject("txt_rank1_1.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTipController1.SetTitle(Me.txt_rank1_1, resources.GetString("txt_rank1_1.Title"))
        Me.ToolTipController1.SetToolTip(Me.txt_rank1_1, resources.GetString("txt_rank1_1.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.txt_rank1_1, CType(resources.GetObject("txt_rank1_1.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.txt_rank1_1.Visible = CType(resources.GetObject("txt_rank1_1.Visible"), Boolean)
        Me.txt_rank1_1.WordWrap = CType(resources.GetObject("txt_rank1_1.WordWrap"), Boolean)
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = resources.GetString("Label2.AccessibleDescription")
        Me.Label2.AccessibleName = resources.GetString("Label2.AccessibleName")
        Me.Label2.Anchor = CType(resources.GetObject("Label2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = CType(resources.GetObject("Label2.AutoSize"), Boolean)
        Me.Label2.Dock = CType(resources.GetObject("Label2.Dock"), System.Windows.Forms.DockStyle)
        Me.Label2.Enabled = CType(resources.GetObject("Label2.Enabled"), Boolean)
        Me.Label2.Font = CType(resources.GetObject("Label2.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.Label2, resources.GetString("Label2.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.Label2, CType(resources.GetObject("Label2.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.Label2, resources.GetString("Label2.HelpString"))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = CType(resources.GetObject("Label2.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label2.ImageIndex = CType(resources.GetObject("Label2.ImageIndex"), Integer)
        Me.Label2.ImeMode = CType(resources.GetObject("Label2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label2.Location = CType(resources.GetObject("Label2.Location"), System.Drawing.Point)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = CType(resources.GetObject("Label2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.Label2, CType(resources.GetObject("Label2.ShowHelp"), Boolean))
        Me.Label2.Size = CType(resources.GetObject("Label2.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.Label2, CType(resources.GetObject("Label2.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.Label2.TabIndex = CType(resources.GetObject("Label2.TabIndex"), Integer)
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = CType(resources.GetObject("Label2.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTipController1.SetTitle(Me.Label2, resources.GetString("Label2.Title"))
        Me.ToolTipController1.SetToolTip(Me.Label2, resources.GetString("Label2.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.Label2, CType(resources.GetObject("Label2.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.Label2.Visible = CType(resources.GetObject("Label2.Visible"), Boolean)
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
        Me.ToolTipController1.SetSuperTip(Me.Label1, CType(resources.GetObject("Label1.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.Label1.TabIndex = CType(resources.GetObject("Label1.TabIndex"), Integer)
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = CType(resources.GetObject("Label1.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTipController1.SetTitle(Me.Label1, resources.GetString("Label1.Title"))
        Me.ToolTipController1.SetToolTip(Me.Label1, resources.GetString("Label1.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.Label1, CType(resources.GetObject("Label1.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.Label1.Visible = CType(resources.GetObject("Label1.Visible"), Boolean)
        '
        'lblRank1
        '
        Me.lblRank1.AccessibleDescription = resources.GetString("lblRank1.AccessibleDescription")
        Me.lblRank1.AccessibleName = resources.GetString("lblRank1.AccessibleName")
        Me.lblRank1.Anchor = CType(resources.GetObject("lblRank1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblRank1.AutoSize = CType(resources.GetObject("lblRank1.AutoSize"), Boolean)
        Me.lblRank1.Dock = CType(resources.GetObject("lblRank1.Dock"), System.Windows.Forms.DockStyle)
        Me.lblRank1.Enabled = CType(resources.GetObject("lblRank1.Enabled"), Boolean)
        Me.lblRank1.Font = CType(resources.GetObject("lblRank1.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.lblRank1, resources.GetString("lblRank1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblRank1, CType(resources.GetObject("lblRank1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblRank1, resources.GetString("lblRank1.HelpString"))
        Me.lblRank1.Image = CType(resources.GetObject("lblRank1.Image"), System.Drawing.Image)
        Me.lblRank1.ImageAlign = CType(resources.GetObject("lblRank1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblRank1.ImageIndex = CType(resources.GetObject("lblRank1.ImageIndex"), Integer)
        Me.lblRank1.ImeMode = CType(resources.GetObject("lblRank1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblRank1.Location = CType(resources.GetObject("lblRank1.Location"), System.Drawing.Point)
        Me.lblRank1.Name = "lblRank1"
        Me.lblRank1.RightToLeft = CType(resources.GetObject("lblRank1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.lblRank1, CType(resources.GetObject("lblRank1.ShowHelp"), Boolean))
        Me.lblRank1.Size = CType(resources.GetObject("lblRank1.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.lblRank1, CType(resources.GetObject("lblRank1.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.lblRank1.TabIndex = CType(resources.GetObject("lblRank1.TabIndex"), Integer)
        Me.lblRank1.Text = resources.GetString("lblRank1.Text")
        Me.lblRank1.TextAlign = CType(resources.GetObject("lblRank1.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTipController1.SetTitle(Me.lblRank1, resources.GetString("lblRank1.Title"))
        Me.ToolTipController1.SetToolTip(Me.lblRank1, resources.GetString("lblRank1.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.lblRank1, CType(resources.GetObject("lblRank1.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.lblRank1.Visible = CType(resources.GetObject("lblRank1.Visible"), Boolean)
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
        Me.ToolTipController1.SetSuperTip(Me.lbl1, CType(resources.GetObject("lbl1.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.lbl1.TabIndex = CType(resources.GetObject("lbl1.TabIndex"), Integer)
        Me.lbl1.Text = resources.GetString("lbl1.Text")
        Me.lbl1.TextAlign = CType(resources.GetObject("lbl1.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTipController1.SetTitle(Me.lbl1, resources.GetString("lbl1.Title"))
        Me.ToolTipController1.SetToolTip(Me.lbl1, resources.GetString("lbl1.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.lbl1, CType(resources.GetObject("lbl1.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
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
        Me.GroupControl2.Controls.Add(Me.lblDVDStatus)
        Me.GroupControl2.Controls.Add(Me.txtDVDStatus)
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
        Me.ToolTipController1.SetSuperTip(Me.GroupControl2, CType(resources.GetObject("GroupControl2.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.GroupControl2.TabIndex = CType(resources.GetObject("GroupControl2.TabIndex"), Integer)
        Me.GroupControl2.Text = resources.GetString("GroupControl2.Text")
        Me.ToolTipController1.SetTitle(Me.GroupControl2, resources.GetString("GroupControl2.Title"))
        Me.ToolTipController1.SetToolTip(Me.GroupControl2, resources.GetString("GroupControl2.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.GroupControl2, CType(resources.GetObject("GroupControl2.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.GroupControl2.Visible = CType(resources.GetObject("GroupControl2.Visible"), Boolean)
        '
        'lblDVDStatus
        '
        Me.lblDVDStatus.AccessibleDescription = resources.GetString("lblDVDStatus.AccessibleDescription")
        Me.lblDVDStatus.AccessibleName = resources.GetString("lblDVDStatus.AccessibleName")
        Me.lblDVDStatus.Anchor = CType(resources.GetObject("lblDVDStatus.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblDVDStatus.AutoSizeMode = CType(resources.GetObject("lblDVDStatus.AutoSizeMode"), DevExpress.XtraEditors.LabelAutoSizeMode)
        Me.lblDVDStatus.Dock = CType(resources.GetObject("lblDVDStatus.Dock"), System.Windows.Forms.DockStyle)
        Me.lblDVDStatus.Enabled = CType(resources.GetObject("lblDVDStatus.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.lblDVDStatus, resources.GetString("lblDVDStatus.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblDVDStatus, CType(resources.GetObject("lblDVDStatus.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblDVDStatus, resources.GetString("lblDVDStatus.HelpString"))
        Me.lblDVDStatus.ImeMode = CType(resources.GetObject("lblDVDStatus.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblDVDStatus.LineColor = CType(resources.GetObject("lblDVDStatus.LineColor"), System.Drawing.Color)
        Me.lblDVDStatus.Location = CType(resources.GetObject("lblDVDStatus.Location"), System.Drawing.Point)
        Me.lblDVDStatus.Name = "lblDVDStatus"
        Me.HelpProvider1.SetShowHelp(Me.lblDVDStatus, CType(resources.GetObject("lblDVDStatus.ShowHelp"), Boolean))
        Me.lblDVDStatus.Size = CType(resources.GetObject("lblDVDStatus.Size"), System.Drawing.Size)
        Me.lblDVDStatus.SuperTip = CType(resources.GetObject("lblDVDStatus.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.lblDVDStatus.TabIndex = CType(resources.GetObject("lblDVDStatus.TabIndex"), Integer)
        Me.lblDVDStatus.Text = resources.GetString("lblDVDStatus.Text")
        Me.lblDVDStatus.ToolTip = resources.GetString("lblDVDStatus.ToolTip")
        Me.lblDVDStatus.ToolTipIconType = CType(resources.GetObject("lblDVDStatus.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.lblDVDStatus.ToolTipTitle = resources.GetString("lblDVDStatus.ToolTipTitle")
        Me.lblDVDStatus.Visible = CType(resources.GetObject("lblDVDStatus.Visible"), Boolean)
        '
        'txtDVDStatus
        '
        Me.txtDVDStatus.Anchor = CType(resources.GetObject("txtDVDStatus.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtDVDStatus.BackgroundImage = CType(resources.GetObject("txtDVDStatus.BackgroundImage"), System.Drawing.Image)
        Me.txtDVDStatus.Dock = CType(resources.GetObject("txtDVDStatus.Dock"), System.Windows.Forms.DockStyle)
        Me.txtDVDStatus.EditValue = resources.GetString("txtDVDStatus.EditValue")
        Me.txtDVDStatus.Enabled = CType(resources.GetObject("txtDVDStatus.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.txtDVDStatus, resources.GetString("txtDVDStatus.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtDVDStatus, CType(resources.GetObject("txtDVDStatus.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtDVDStatus, resources.GetString("txtDVDStatus.HelpString"))
        Me.txtDVDStatus.ImeMode = CType(resources.GetObject("txtDVDStatus.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtDVDStatus.Location = CType(resources.GetObject("txtDVDStatus.Location"), System.Drawing.Point)
        Me.txtDVDStatus.Name = "txtDVDStatus"
        '
        'txtDVDStatus.Properties
        '
        Me.txtDVDStatus.Properties.AccessibleDescription = resources.GetString("txtDVDStatus.Properties.AccessibleDescription")
        Me.txtDVDStatus.Properties.AccessibleName = resources.GetString("txtDVDStatus.Properties.AccessibleName")
        Me.txtDVDStatus.Properties.AutoHeight = CType(resources.GetObject("txtDVDStatus.Properties.AutoHeight"), Boolean)
        Me.txtDVDStatus.Properties.Mask.AutoComplete = CType(resources.GetObject("txtDVDStatus.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDVDStatus.Properties.Mask.BeepOnError = CType(resources.GetObject("txtDVDStatus.Properties.Mask.BeepOnError"), Boolean)
        Me.txtDVDStatus.Properties.Mask.EditMask = resources.GetString("txtDVDStatus.Properties.Mask.EditMask")
        Me.txtDVDStatus.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDVDStatus.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDVDStatus.Properties.Mask.MaskType = CType(resources.GetObject("txtDVDStatus.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDVDStatus.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtDVDStatus.Properties.Mask.PlaceHolder"), Char)
        Me.txtDVDStatus.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtDVDStatus.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtDVDStatus.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDVDStatus.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDVDStatus.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDVDStatus.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDVDStatus.Properties.NullText = resources.GetString("txtDVDStatus.Properties.NullText")
        Me.txtDVDStatus.RightToLeft = CType(resources.GetObject("txtDVDStatus.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.txtDVDStatus, CType(resources.GetObject("txtDVDStatus.ShowHelp"), Boolean))
        Me.txtDVDStatus.Size = CType(resources.GetObject("txtDVDStatus.Size"), System.Drawing.Size)
        Me.txtDVDStatus.SuperTip = CType(resources.GetObject("txtDVDStatus.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtDVDStatus.TabIndex = CType(resources.GetObject("txtDVDStatus.TabIndex"), Integer)
        Me.txtDVDStatus.ToolTip = resources.GetString("txtDVDStatus.ToolTip")
        Me.txtDVDStatus.ToolTipIconType = CType(resources.GetObject("txtDVDStatus.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtDVDStatus.ToolTipTitle = resources.GetString("txtDVDStatus.ToolTipTitle")
        Me.txtDVDStatus.Visible = CType(resources.GetObject("txtDVDStatus.Visible"), Boolean)
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Anchor = CType(resources.GetObject("MemoEdit1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.MemoEdit1.BackgroundImage = CType(resources.GetObject("MemoEdit1.BackgroundImage"), System.Drawing.Image)
        Me.MemoEdit1.Dock = CType(resources.GetObject("MemoEdit1.Dock"), System.Windows.Forms.DockStyle)
        Me.MemoEdit1.EditValue = resources.GetString("MemoEdit1.EditValue")
        Me.MemoEdit1.Enabled = CType(resources.GetObject("MemoEdit1.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.MemoEdit1, resources.GetString("MemoEdit1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.MemoEdit1, CType(resources.GetObject("MemoEdit1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.MemoEdit1, resources.GetString("MemoEdit1.HelpString"))
        Me.MemoEdit1.ImeMode = CType(resources.GetObject("MemoEdit1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.MemoEdit1.Location = CType(resources.GetObject("MemoEdit1.Location"), System.Drawing.Point)
        Me.MemoEdit1.Name = "MemoEdit1"
        '
        'MemoEdit1.Properties
        '
        Me.MemoEdit1.Properties.AccessibleDescription = resources.GetString("MemoEdit1.Properties.AccessibleDescription")
        Me.MemoEdit1.Properties.AccessibleName = resources.GetString("MemoEdit1.Properties.AccessibleName")
        Me.MemoEdit1.Properties.NullText = resources.GetString("MemoEdit1.Properties.NullText")
        Me.MemoEdit1.RightToLeft = CType(resources.GetObject("MemoEdit1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.MemoEdit1, CType(resources.GetObject("MemoEdit1.ShowHelp"), Boolean))
        Me.MemoEdit1.Size = CType(resources.GetObject("MemoEdit1.Size"), System.Drawing.Size)
        Me.MemoEdit1.SuperTip = CType(resources.GetObject("MemoEdit1.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.MemoEdit1.TabIndex = CType(resources.GetObject("MemoEdit1.TabIndex"), Integer)
        Me.MemoEdit1.ToolTip = resources.GetString("MemoEdit1.ToolTip")
        Me.MemoEdit1.ToolTipIconType = CType(resources.GetObject("MemoEdit1.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.MemoEdit1.ToolTipTitle = resources.GetString("MemoEdit1.ToolTipTitle")
        Me.MemoEdit1.Visible = CType(resources.GetObject("MemoEdit1.Visible"), Boolean)
        '
        'GroupControl4
        '
        Me.GroupControl4.AccessibleDescription = resources.GetString("GroupControl4.AccessibleDescription")
        Me.GroupControl4.AccessibleName = resources.GetString("GroupControl4.AccessibleName")
        Me.GroupControl4.Anchor = CType(resources.GetObject("GroupControl4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupControl4.AutoScrollMargin = CType(resources.GetObject("GroupControl4.AutoScrollMargin"), System.Drawing.Size)
        Me.GroupControl4.AutoScrollMinSize = CType(resources.GetObject("GroupControl4.AutoScrollMinSize"), System.Drawing.Size)
        Me.GroupControl4.Appearance.Image = CType(resources.GetObject("GroupControl4.BackgroundImage"), System.Drawing.Image)
        Me.GroupControl4.Controls.Add(Me.LabelControl2)
        Me.GroupControl4.Controls.Add(Me.LabelControl1)
        Me.GroupControl4.Controls.Add(Me.txtToID)
        Me.GroupControl4.Controls.Add(Me.txtFromID)
        Me.GroupControl4.Dock = CType(resources.GetObject("GroupControl4.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupControl4.Enabled = CType(resources.GetObject("GroupControl4.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.GroupControl4, resources.GetString("GroupControl4.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.GroupControl4, CType(resources.GetObject("GroupControl4.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.GroupControl4, resources.GetString("GroupControl4.HelpString"))
        Me.GroupControl4.ImeMode = CType(resources.GetObject("GroupControl4.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupControl4.Location = CType(resources.GetObject("GroupControl4.Location"), System.Drawing.Point)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.RightToLeft = CType(resources.GetObject("GroupControl4.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.GroupControl4, CType(resources.GetObject("GroupControl4.ShowHelp"), Boolean))
        Me.GroupControl4.Size = CType(resources.GetObject("GroupControl4.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.GroupControl4, CType(resources.GetObject("GroupControl4.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.GroupControl4.TabIndex = CType(resources.GetObject("GroupControl4.TabIndex"), Integer)
        Me.GroupControl4.Text = resources.GetString("GroupControl4.Text")
        Me.ToolTipController1.SetTitle(Me.GroupControl4, resources.GetString("GroupControl4.Title"))
        Me.ToolTipController1.SetToolTip(Me.GroupControl4, resources.GetString("GroupControl4.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.GroupControl4, CType(resources.GetObject("GroupControl4.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.GroupControl4.Visible = CType(resources.GetObject("GroupControl4.Visible"), Boolean)
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
        Me.txtFromID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
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
        'frmSlsPur_Browse
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
        Me.Name = "frmSlsPur_Browse"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.ToolTipController1.SetSuperTip(Me, CType(resources.GetObject("$this.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.Text = resources.GetString("$this.Text")
        Me.ToolTipController1.SetTitle(Me, resources.GetString("$this.Title"))
        Me.ToolTipController1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me, CType(resources.GetObject("$this.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabParameters.ResumeLayout(False)
        Me.TabResult.ResumeLayout(False)
        Me.TabAnalyse.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabChart.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.chkStock_with_Cover.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUSeStockIN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.chkSubTitles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLanguages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.txtDVDStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.txtToID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New dvdpostbuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        objDS = New dsPur_Sls
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "PS_Ana"
        MyBase.IDField = "products_id"
        MyBase.NameField = "products_model"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = False
        MyBase.StartUp()
        GridView1.OptionsBehavior.Editable = True
        UcChart1.SetDataSource(objDS, "PS_Ana")
        UcChart1.SetXYAxis("studio_name", "stock_qty")

        MemoEdit1.Text = "Monthes to serve WL1 is always based on Total Stock QTY" & vbCrLf & vbCrLf & _
                         "Stock Mini, Qty to Sale, Qty to Purchase are  based on Total Stock Qty or Stock Qty IN"

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
        objDS.Tables("PS_Ana").Clear()

        'FeeSharing
        'Dim _SQLFee As String = " AND Feesharing in (-1, "
        'If chkFeeSharing.Checked Then
        '    _SQLFee += "1, "
        'End If
        'If chkNonFeeSharing.Checked Then
        '    _SQLFee += "0, "
        'End If
        '_SQLFee += "2) "

        'Updating Feesharing_end = 0000-00-00 00:00:00 to 1801-01-01 00:00:00
        _SQLTxt = "Update products set feesharing_end = NULL where feesharing_end = '0000-00-00 00:00:00'"
        lbl1.Text = "updating : " & DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        Dim _SQLStockIn As String = ""
        If chkUSeStockIN.Checked Then
            _SQLStockIn = " AND PDVD.`inout` = 1 "
        Else
            _SQLStockIn = ""
        End If
        'Products
        _SQLTxt = "SELECT P.products_ID product_id, P.products_type products_type, P.products_model , P.imdb_id, P.products_studio, S.studio_name, P.feesharing, " & _
                  " if (P.feesharing_end = '0000-00-00', Null, P.feesharing_end) as feesharing_end , products_title, " & _
                  " if (products_date_available = '0000-00-00', Null, products_date_available) as products_date_available, P.products_status, P.cinebel_id, " & _
                  " P.products_ordered, P.products_public, P.products_runtime, P.products_year, " & _
                  " count(PDVD.`inout`) stock_in_qty , PDVD.products_dvd_status, PDVDS.products_dvd_status_name, P.products_series_number, " & _
                  " P.products_sale_price, P.products_sale_date, P.quantity_to_sale , P.in_the_bags, P.in_the_bags_next, P.in_cinema_now, P.products_next, " & _
                  " P.products_media " & _
                  " FROM products as P " & _
                  " LEFT JOIN products_dvd PDVD ON P.products_id = PDVD.products_id " & _
                  " LEFT JOIN studio S ON P.products_studio = S.studio_Id " & _
                  " LEFT JOIN products_dvd_status PDVDS on PDVDS.products_dvd_status_id = PDVD.products_dvd_status " & _
                  " WHERE P.products_type <> 'ABO' and P.products_id >= " & txtFromID.EditValue & " AND P.products_id <= " & txtToID.EditValue & _
                  " GROUP BY P.products_id " & _Limit
        '" AND ( ( Products_dvd_status = " & CInt(txtDVDStatus.EditValue) & " ) OR ( " & txtDVDStatus.EditValue & " = -1 ) )" 

        '_SQLStockIn & _

        '_SQLTxt = _
        '" SELECT p.products_id product_id" & _
        '" , p.products_model , p.imdb_id, " & _
        '" p.products_title, p.products_date_added, p.products_last_modified, p.products_date_available, " & _
        '" p.products_ordered, p.products_public, p.products_runtime, p.products_year, S.studio_id, " & _
        '" S.studio_name, p.feesharing, p.feesharing_end, p.cinebel_id, p.feesharing_upfront_fee, " & _
        '" p.feesharing_upfront_fee_recoverable, p.feesharing_turn_price, p.feesharing_turn_price_after3month, " & _
        '" p.feesharing_buy_option_price, p.feesharing_expected_nbr_turns, p.products_dvd_quantity AS original_qty, " & _
        '" COUNT(PDvd.products_dvdid) AS stock_qty " & _
        '" FROM Products P " & _
        '" LEFT JOIN Products_DVD PDvd ON p.products_id = PDVD.products_id " & _
        '" LEFT JOIN Studio S ON p.Products_Studio = S.studio_id " & _
        '" WHERE P.products_id > 50 AND Products_dvd_status = 1 " & _
        '" GROUp BY p.products_id " & _Limit
        objDS.Tables("PS_Ana").Columns("stock_cover_qty").DefaultValue = 0
        objDS.Tables("PS_Ana").Columns("stock_qty").DefaultValue = 0
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("PS_Ana"), _SQLTxt)
        MergeProductInfo()

        'WhisList Part0
        MergeWhishInfo(0, _Limit, 0, 99999)

        'WhisList Part1
        MergeWhishInfo(1, _Limit, txt_rank1_1.Text, txt_rank1_2.Text)

        'WidhList Part2

        MergeWhishInfo(2, _Limit, txt_rank2_1.Text, txt_rank2_2.Text)

        'WidhList Part3
        MergeWhishInfo(3, _Limit, txt_rank3_1.Text, txt_rank3_2.Text)

        ComputeStockMini()


        Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
        Dim _col As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        For Each _col In GridView1.Columns
            If _col.Name <> "products_sale_price" And _col.Name <> "products_sale_date" And _col.Name <> "quantity_to_sale" Then
                _col.OptionsColumn.ReadOnly = True
            End If
        Next
        TabControl1.SelectedTabPage = TabResult
    End Sub
    Public Sub MergeProductInfo()
        Dim _row, _ItemRow As DataRow
        Dim _row2 As DataRowView
        Dim _viewLang As New DataView
        Dim _viewSubTitle As New DataView()
        Dim _rowsSub() As DataRowView
        Dim _rowsLang() As DataRowView
        Dim _SqlTxt As String
        Dim _tmpDS As New dsPur_Sls

        'Reset Stock QTY to Status
        _SqlTxt = "select products_id as ID , count(products_id) as Int_1 from products_dvd where ( " & _
                  " ( products_dvd_status = " & CInt(txtDVDStatus.EditValue) & " ) OR ( " & txtDVDStatus.EditValue & " = -1 ) ) " & _
                  " and products_id >= " & txtFromID.EditValue & " AND products_id <= " & txtToID.EditValue & _
                  " group by products_id"
        _tmpDS.Tables("Tmp1").Clear()
        DvdPostData.clsConnection.FillDataSet(_tmpDS.Tables("Tmp1"), _SqlTxt)
        For Each _row In _tmpDS.Tables("Tmp1").Rows
            _ItemRow = objDS.Tables("PS_Ana").Rows.Find(New Object() {_row("ID")})
            If Not IsNothing(_ItemRow) Then
                _ItemRow("stock_qty") = _row("Int_1")
            End If
        Next


        'Load Cover Info
        If chkStock_with_Cover.Checked = True Then
            '_SqlTxt = "select products_id as ID , count(cover_box_id) as Int_1 from products_dvd where cover_box_id <> '' AND ( " & _
            '          " ( Products_dvd_status = " & CInt(txtDVDStatus.EditValue) & " ) OR ( " & txtDVDStatus.EditValue & " = -1 ) ) " & _
            '          " and products_id >= " & txtFromID.EditValue & " AND products_id <= " & txtToID.EditValue & _
            '          " group by products_id"
            _SqlTxt = " select products_id as ID, sum(qty) as Int_1 from products_cover where " & _
                      " products_id >= " & txtFromID.EditValue & " AND products_id <= " & txtToID.EditValue & _
                      " group by products_id "
            _tmpDS.Tables("Tmp1").Clear()
            DvdPostData.clsConnection.FillDataSet(_tmpDS.Tables("Tmp1"), _SqlTxt)
            For Each _row In _tmpDS.Tables("Tmp1").Rows
                _ItemRow = objDS.Tables("PS_Ana").Rows.Find(New Object() {_row("ID")})
                If Not IsNothing(_ItemRow) Then
                    _ItemRow("stock_cover_qty") = _row("Int_1")
                End If
            Next
        End If

        'Load StockIN
        If chkUSeStockIN.Checked = True Then
            'Set QTY In = 0 First
            For Each _row In objDS.Tables("PS_Ana").Rows
                _row("stock_in_qty") = 0
            Next
            _SqlTxt = "select products_id as ID , count(`inout`) as Int_1 from products_dvd where `inout` = 1 AND ( " & _
                      " ( Products_dvd_status = " & CInt(txtDVDStatus.EditValue) & " ) OR ( " & txtDVDStatus.EditValue & " = -1 ) ) " & _
                      " and products_id >= " & txtFromID.EditValue & " AND products_id <= " & txtToID.EditValue & _
                      " group by products_id"
            _tmpDS.Tables("Tmp1").Clear()
            DvdPostData.clsConnection.FillDataSet(_tmpDS.Tables("Tmp1"), _SqlTxt)
            For Each _row In _tmpDS.Tables("Tmp1").Rows
                _ItemRow = objDS.Tables("PS_Ana").Rows.Find(New Object() {_row("ID")})
                If Not IsNothing(_ItemRow) Then
                    _ItemRow("stock_in_qty") = _row("Int_1")
                End If
            Next
        End If

        If chkLanguages.Checked = False And chkSubTitles.Checked = False Then Exit Sub
        lbl1.Text = "Merging DVD Info"
        lbl1.Refresh()
        ProgressBar1.Properties.Minimum = 0
        ProgressBar1.Properties.Maximum = objDS.Tables("PS_Ana").Rows.Count
        ProgressBar1.EditValue = 0
        'SubTitles and Languages
        If chkSubTitles.Checked Then
            _SqlTxt = "SELECT p.products_id, undertitles_id, language_id, undertitles_description as description " & _
                      " FROM products_to_undertitles p left join products_undertitles u " & _
                      " on p.products_undertitles_id = u.undertitles_id WHERe u.language_id = 3" & _
                      " and p.products_id >= " & txtFromID.EditValue & " AND p.products_id <= " & txtToID.EditValue
            DvdPostData.clsConnection.FillDataSet(_tmpDS.Tables("products_undertitles_View1"), _SqlTxt)
            _viewSubTitle = New DataView(_tmpDS.Tables("products_undertitles_View1"), "", "products_id", DataViewRowState.CurrentRows)
        End If
        If chkLanguages.Checked Then
            _SqlTxt = "SELECT p.products_id, languages_id, languagenav_id, languages_description as description " & _
                    " FROM products_to_languages p " & _
                    " left join products_languages l on p.products_languages_id = l.languages_id " & _
                    " WHERe l.languagenav_id = 3 " & _
                    " and p.products_id >= " & txtFromID.EditValue & " AND p.products_id <= " & txtToID.EditValue
            DvdPostData.clsConnection.FillDataSet(_tmpDS.Tables("products_languages_View1"), _SqlTxt)
            _viewLang = New DataView(_tmpDS.Tables("products_languages_View1"), "", "products_id", DataViewRowState.CurrentRows)
        End If
        For Each _row In objDS.Tables("PS_Ana").Rows
            ProgressBar1.EditValue += 1
            ProgressBar1.Refresh()
            '_row2 = _tmpDS.Tables("products_undertitles_View1").Rows.Find(New Object() {_row("Product_ID")})
            'Adding SubTitles Info
            If chkSubTitles.Checked Then
                '_view = New DataView(_tmpDS.Tables("products_undertitles_View1"), "Products_Id = " & _row("Product_ID"), "", DataViewRowState.CurrentRows)
                _rowsSub = _viewSubTitle.FindRows(_row("product_id"))
                For Each _row2 In _rowsSub
                    _row.BeginEdit()
                    _row("SubTitles") += _row2("Description") + " , "
                    _row.EndEdit()
                Next
            End If
            'Adding Languages Info
            If chkLanguages.Checked Then
                '_view = New DataView(_tmpDS.Tables("products_languages_View1"), "Products_Id = " & _row("Product_ID"), "", DataViewRowState.CurrentRows)
                _rowsLang = _viewLang.FindRows(_row("product_id"))
                For Each _row2 In _rowsLang
                    _row.BeginEdit()
                    _row("Languages") += _row2("Description") + " , "
                    _row.EndEdit()
                Next
            End If
        Next
        ProgressBar1.EditValue = 0
    End Sub
    Public Sub MergeWhishInfo(ByVal vPart As Integer, ByVal vLimit As String, ByVal vMin As Integer, ByVal vMax As Integer)
        Dim _SQLTxt As String

        Dim _tmpDS As New dsPur_Sls
        Dim _row As DataRow
        Dim _i As Integer = 0
        Dim _Row2 As DataRow

        lbl1.Text = "Part" & vPart
        lbl1.Refresh()
        ProgressBar1.Properties.Minimum = 0
        ProgressBar1.Properties.Maximum = objDS.Tables("PS_Ana").Rows.Count
        ProgressBar1.EditValue = 0

        'WhisList
        _SQLTxt = "SELECT product_id as product_id, count(product_id) w_q2 FROM wishlist W " & _
                  " LEFT JOIN customers Cust ON W.customers_id = Cust.customers_id " & _
                  " WHERE rank >= " & vMin & " and rank <= " & vMax & " and Cust.customers_abo = 1 " & _
                  " and product_id >= " & txtFromID.EditValue & " AND product_id <= " & txtToID.EditValue & _
                  " group by product_id " & vLimit
        DvdPostData.clsConnection.FillDataSet(_tmpDS.Tables("PS_Ana"), _SQLTxt)
        For Each _row In objDS.Tables("PS_Ana").Rows
            ProgressBar1.EditValue += 1
            ProgressBar1.Refresh()
            _Row2 = _tmpDS.Tables("PS_Ana").Rows.Find(New Object() {_row("product_id")})
            If Not IsNothing(_Row2) Then
                _row.BeginEdit()
                _row("W_Q" & vPart) = _Row2("W_Q2")
                _row.EndEdit()
            Else
                _row("W_Q" & vPart) = 0
            End If
        Next
        ProgressBar1.EditValue = 0
    End Sub
    Public Sub ComputeStockMini()
        Dim _row As DataRow
        Dim _StartStockQty As Integer
        lbl1.Text = "Processing Stock Mini"
        lbl1.Refresh()
        ProgressBar1.Properties.Minimum = 0
        ProgressBar1.Properties.Maximum = objDS.Tables("PS_Ana").Rows.Count
        ProgressBar1.EditValue = 0

        For Each _row In objDS.Tables("PS_Ana").Rows
            ProgressBar1.EditValue += 1
            ProgressBar1.Refresh()
            _row.BeginEdit()
            If chkUSeStockIN.Checked Then
                'If chkStock_with_Cover.Checked Then
                '    _StartStockQty = Math.Min(_row("stock_in_qty"), _row("stock_cover_qty"))
                'Else
                '    _StartStockQty = _row("stock_in_qty")
                'End If
                _StartStockQty = _row("stock_in_qty")
            Else
                'If chkStock_with_Cover.Checked Then
                '    _StartStockQty = _row("stock_cover_qty")
                'Else
                _StartStockQty = _row("stock_qty")
                'End If
            End If
            If _row("stock_qty") = 0 Then
                _row("monthes_w1") = 999
            Else
                _row("monthes_w1") = Math.Ceiling(_row("w_q1") / 5 / _row("stock_qty"))
            End If
            _row("w_mini1") = Math.Ceiling(_row("w_q1") / 5 / txtMini1.Text)
            _row("w_mini2") = Math.Ceiling((_row("w_q1") + _row("w_q2")) / 5 / txtMini2.Text)
            _row("w_mini3") = Math.Ceiling((_row("w_q1") + _row("w_q2") + _row("w_q3")) / 5 / txtMini3.Text)
            _row("stock_mini") = 0
            _row("stock_mini") = Math.Max(_row("stock_mini"), _row("w_mini1"))
            _row("stock_mini") = Math.Max(_row("stock_mini"), _row("w_mini2"))
            _row("stock_mini") = Math.Max(_row("stock_mini"), _row("w_mini3"))
            _row("stock_mini") += txtStockTampon.Text
            If _row("stock_mini") < CInt(txtStockMini.Text) Then
                _row("stock_mini") = CInt(txtStockMini.Text)
            End If
            If _row("stock_mini") <= _StartStockQty Then
                _row("to_sale_qty") = _StartStockQty - _row("stock_mini")
                _row("to_purchase_qty") = 0
            Else
                _row("to_sale_qty") = 0
                _row("to_purchase_qty") = _row("stock_mini") - _StartStockQty
            End If
            _row("qty_flow") = _row("stock_mini") - _StartStockQty
            Dim _stock_cover_qty As Integer
            If IsDBNull(_row("stock_cover_qty")) Then
                _stock_cover_qty = 0
            Else
                _stock_cover_qty = _row("stock_cover_qty")
            End If
            If chkStock_with_Cover.Checked Then
                _row("to_sale_qty") = Math.Min(_row("to_sale_qty"), _stock_cover_qty)
            End If
            _row.EndEdit()
        Next
        ProgressBar1.EditValue = 0
        lbl1.Text = ""
    End Sub
    Private Sub txtLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimit.TextChanged
        _Limit = "limit 0, " & txtLimit.Text
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub
    Public Overrides Sub Grid1_Validated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) 'Handles GridView1.ValidateRow
        MsgBox("Saving : " & GridView1.GetDataRow(e.RowHandle)("product_id"))
        GridView1.GetDataRow(e.RowHandle)("products_sale_date") = Now()
        Dim _SQLTxt As String = "UPDATE products set quantity_to_sale = " & GridView1.GetDataRow(e.RowHandle)("quantity_to_sale") & _
                                ", products_sale_date = Now(),  products_sale_price = " & Replace(GridView1.GetDataRow(e.RowHandle)("products_sale_price"), ",", ".") & _
                                " WHERE products_id = " & GridView1.GetDataRow(e.RowHandle)("product_id")
        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
    End Sub

    Private Sub TabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click

    End Sub
End Class
