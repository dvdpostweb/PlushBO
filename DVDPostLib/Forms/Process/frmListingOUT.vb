Imports System.Windows.Forms.Application
Public Class frmListingOUT
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
    Friend WithEvents txtInfo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnLoadOrders As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMaxDVDPerGroup As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtProcedure As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnClearDVDAssigned As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAssignDVDToOrders As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSetPickingGroup As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmListingOUT))
        Me.txtInfo = New DevExpress.XtraEditors.TextEdit
        Me.btnLoadOrders = New DevExpress.XtraEditors.SimpleButton
        Me.txtMaxDVDPerGroup = New DevExpress.XtraEditors.SpinEdit
        Me.txtProcedure = New DevExpress.XtraEditors.LabelControl
        Me.btnClearDVDAssigned = New DevExpress.XtraEditors.SimpleButton
        Me.btnAssignDVDToOrders = New DevExpress.XtraEditors.SimpleButton
        Me.btnSetPickingGroup = New DevExpress.XtraEditors.SimpleButton
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabParameters.SuspendLayout()
        Me.TabResult.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        Me.TabChart.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInfo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaxDVDPerGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
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
        Me.TabParameters.Controls.Add(Me.btnSetPickingGroup)
        Me.TabParameters.Controls.Add(Me.btnAssignDVDToOrders)
        Me.TabParameters.Controls.Add(Me.btnClearDVDAssigned)
        Me.TabParameters.Controls.Add(Me.txtMaxDVDPerGroup)
        Me.TabParameters.Controls.Add(Me.txtProcedure)
        Me.TabParameters.Controls.Add(Me.txtInfo)
        Me.TabParameters.Controls.Add(Me.btnLoadOrders)
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
        'TabChart
        '
        Me.TabChart.Name = "TabChart"
        Me.TabChart.Size = CType(resources.GetObject("TabChart.Size"), System.Drawing.Size)
        '
        'Panel1
        '
        Me.Panel1.Location = CType(resources.GetObject("Panel1.Location"), System.Drawing.Point)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = CType(resources.GetObject("Panel1.Size"), System.Drawing.Size)
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
        'btnUser1
        '
        '
        'btnUser2
        '
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
        'txtInfo
        '
        Me.txtInfo.Anchor = CType(resources.GetObject("txtInfo.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtInfo.BackgroundImage = CType(resources.GetObject("txtInfo.BackgroundImage"), System.Drawing.Image)
        Me.txtInfo.Dock = CType(resources.GetObject("txtInfo.Dock"), System.Windows.Forms.DockStyle)
        Me.txtInfo.EditValue = CType(resources.GetObject("txtInfo.EditValue"), Object)
        Me.txtInfo.Enabled = CType(resources.GetObject("txtInfo.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.txtInfo, resources.GetString("txtInfo.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtInfo, CType(resources.GetObject("txtInfo.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtInfo, resources.GetString("txtInfo.HelpString"))
        Me.txtInfo.ImeMode = CType(resources.GetObject("txtInfo.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtInfo.Location = CType(resources.GetObject("txtInfo.Location"), System.Drawing.Point)
        Me.txtInfo.Name = "txtInfo"
        '
        'txtInfo.Properties
        '
        Me.txtInfo.Properties.AccessibleDescription = resources.GetString("txtInfo.Properties.AccessibleDescription")
        Me.txtInfo.Properties.AccessibleName = resources.GetString("txtInfo.Properties.AccessibleName")
        Me.txtInfo.Properties.AutoHeight = CType(resources.GetObject("txtInfo.Properties.AutoHeight"), Boolean)
        Me.txtInfo.Properties.Mask.AutoComplete = CType(resources.GetObject("txtInfo.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtInfo.Properties.Mask.BeepOnError = CType(resources.GetObject("txtInfo.Properties.Mask.BeepOnError"), Boolean)
        Me.txtInfo.Properties.Mask.EditMask = resources.GetString("txtInfo.Properties.Mask.EditMask")
        Me.txtInfo.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtInfo.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtInfo.Properties.Mask.MaskType = CType(resources.GetObject("txtInfo.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtInfo.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtInfo.Properties.Mask.PlaceHolder"), Char)
        Me.txtInfo.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtInfo.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtInfo.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtInfo.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtInfo.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtInfo.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtInfo.Properties.NullText = resources.GetString("txtInfo.Properties.NullText")
        Me.txtInfo.RightToLeft = CType(resources.GetObject("txtInfo.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.txtInfo, CType(resources.GetObject("txtInfo.ShowHelp"), Boolean))
        Me.txtInfo.Size = CType(resources.GetObject("txtInfo.Size"), System.Drawing.Size)
        Me.txtInfo.SuperTip = CType(resources.GetObject("txtInfo.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtInfo.TabIndex = CType(resources.GetObject("txtInfo.TabIndex"), Integer)
        Me.txtInfo.ToolTip = resources.GetString("txtInfo.ToolTip")
        Me.txtInfo.ToolTipIconType = CType(resources.GetObject("txtInfo.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtInfo.ToolTipTitle = resources.GetString("txtInfo.ToolTipTitle")
        Me.txtInfo.Visible = CType(resources.GetObject("txtInfo.Visible"), Boolean)
        '
        'btnLoadOrders
        '
        Me.btnLoadOrders.AccessibleDescription = resources.GetString("btnLoadOrders.AccessibleDescription")
        Me.btnLoadOrders.AccessibleName = resources.GetString("btnLoadOrders.AccessibleName")
        Me.btnLoadOrders.Anchor = CType(resources.GetObject("btnLoadOrders.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnLoadOrders.BackgroundImage = CType(resources.GetObject("btnLoadOrders.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadOrders.Dock = CType(resources.GetObject("btnLoadOrders.Dock"), System.Windows.Forms.DockStyle)
        Me.btnLoadOrders.Enabled = CType(resources.GetObject("btnLoadOrders.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.btnLoadOrders, resources.GetString("btnLoadOrders.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.btnLoadOrders, CType(resources.GetObject("btnLoadOrders.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.btnLoadOrders, resources.GetString("btnLoadOrders.HelpString"))
        Me.btnLoadOrders.ImeMode = CType(resources.GetObject("btnLoadOrders.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnLoadOrders.Location = CType(resources.GetObject("btnLoadOrders.Location"), System.Drawing.Point)
        Me.btnLoadOrders.Name = "btnLoadOrders"
        Me.btnLoadOrders.RightToLeft = CType(resources.GetObject("btnLoadOrders.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.btnLoadOrders, CType(resources.GetObject("btnLoadOrders.ShowHelp"), Boolean))
        Me.btnLoadOrders.Size = CType(resources.GetObject("btnLoadOrders.Size"), System.Drawing.Size)
        Me.btnLoadOrders.SuperTip = CType(resources.GetObject("btnLoadOrders.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.btnLoadOrders.TabIndex = CType(resources.GetObject("btnLoadOrders.TabIndex"), Integer)
        Me.btnLoadOrders.Text = resources.GetString("btnLoadOrders.Text")
        Me.btnLoadOrders.ToolTip = resources.GetString("btnLoadOrders.ToolTip")
        Me.btnLoadOrders.ToolTipIconType = CType(resources.GetObject("btnLoadOrders.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.btnLoadOrders.ToolTipTitle = resources.GetString("btnLoadOrders.ToolTipTitle")
        Me.btnLoadOrders.Visible = CType(resources.GetObject("btnLoadOrders.Visible"), Boolean)
        '
        'txtMaxDVDPerGroup
        '
        Me.txtMaxDVDPerGroup.Anchor = CType(resources.GetObject("txtMaxDVDPerGroup.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtMaxDVDPerGroup.BackgroundImage = CType(resources.GetObject("txtMaxDVDPerGroup.BackgroundImage"), System.Drawing.Image)
        Me.txtMaxDVDPerGroup.Dock = CType(resources.GetObject("txtMaxDVDPerGroup.Dock"), System.Windows.Forms.DockStyle)
        Me.txtMaxDVDPerGroup.EditValue = CType(resources.GetObject("txtMaxDVDPerGroup.EditValue"), Object)
        Me.txtMaxDVDPerGroup.Enabled = CType(resources.GetObject("txtMaxDVDPerGroup.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.txtMaxDVDPerGroup, resources.GetString("txtMaxDVDPerGroup.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtMaxDVDPerGroup, CType(resources.GetObject("txtMaxDVDPerGroup.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtMaxDVDPerGroup, resources.GetString("txtMaxDVDPerGroup.HelpString"))
        Me.txtMaxDVDPerGroup.ImeMode = CType(resources.GetObject("txtMaxDVDPerGroup.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtMaxDVDPerGroup.Location = CType(resources.GetObject("txtMaxDVDPerGroup.Location"), System.Drawing.Point)
        Me.txtMaxDVDPerGroup.Name = "txtMaxDVDPerGroup"
        '
        'txtMaxDVDPerGroup.Properties
        '
        Me.txtMaxDVDPerGroup.Properties.AccessibleDescription = resources.GetString("txtMaxDVDPerGroup.Properties.AccessibleDescription")
        Me.txtMaxDVDPerGroup.Properties.AccessibleName = resources.GetString("txtMaxDVDPerGroup.Properties.AccessibleName")
        Me.txtMaxDVDPerGroup.Properties.AutoHeight = CType(resources.GetObject("txtMaxDVDPerGroup.Properties.AutoHeight"), Boolean)
        Me.txtMaxDVDPerGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtMaxDVDPerGroup.Properties.Mask.AutoComplete = CType(resources.GetObject("txtMaxDVDPerGroup.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtMaxDVDPerGroup.Properties.Mask.BeepOnError = CType(resources.GetObject("txtMaxDVDPerGroup.Properties.Mask.BeepOnError"), Boolean)
        Me.txtMaxDVDPerGroup.Properties.Mask.EditMask = resources.GetString("txtMaxDVDPerGroup.Properties.Mask.EditMask")
        Me.txtMaxDVDPerGroup.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtMaxDVDPerGroup.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtMaxDVDPerGroup.Properties.Mask.MaskType = CType(resources.GetObject("txtMaxDVDPerGroup.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtMaxDVDPerGroup.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtMaxDVDPerGroup.Properties.Mask.PlaceHolder"), Char)
        Me.txtMaxDVDPerGroup.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtMaxDVDPerGroup.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtMaxDVDPerGroup.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtMaxDVDPerGroup.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtMaxDVDPerGroup.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtMaxDVDPerGroup.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtMaxDVDPerGroup.Properties.NullText = resources.GetString("txtMaxDVDPerGroup.Properties.NullText")
        Me.txtMaxDVDPerGroup.RightToLeft = CType(resources.GetObject("txtMaxDVDPerGroup.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.txtMaxDVDPerGroup, CType(resources.GetObject("txtMaxDVDPerGroup.ShowHelp"), Boolean))
        Me.txtMaxDVDPerGroup.Size = CType(resources.GetObject("txtMaxDVDPerGroup.Size"), System.Drawing.Size)
        Me.txtMaxDVDPerGroup.SuperTip = CType(resources.GetObject("txtMaxDVDPerGroup.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtMaxDVDPerGroup.TabIndex = CType(resources.GetObject("txtMaxDVDPerGroup.TabIndex"), Integer)
        Me.txtMaxDVDPerGroup.ToolTip = resources.GetString("txtMaxDVDPerGroup.ToolTip")
        Me.txtMaxDVDPerGroup.ToolTipIconType = CType(resources.GetObject("txtMaxDVDPerGroup.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtMaxDVDPerGroup.ToolTipTitle = resources.GetString("txtMaxDVDPerGroup.ToolTipTitle")
        Me.txtMaxDVDPerGroup.Visible = CType(resources.GetObject("txtMaxDVDPerGroup.Visible"), Boolean)
        '
        'txtProcedure
        '
        Me.txtProcedure.AccessibleDescription = resources.GetString("txtProcedure.AccessibleDescription")
        Me.txtProcedure.AccessibleName = resources.GetString("txtProcedure.AccessibleName")
        Me.txtProcedure.Anchor = CType(resources.GetObject("txtProcedure.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtProcedure.AutoSizeMode = CType(resources.GetObject("txtProcedure.AutoSizeMode"), DevExpress.XtraEditors.LabelAutoSizeMode)
        Me.txtProcedure.Dock = CType(resources.GetObject("txtProcedure.Dock"), System.Windows.Forms.DockStyle)
        Me.txtProcedure.Enabled = CType(resources.GetObject("txtProcedure.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.txtProcedure, resources.GetString("txtProcedure.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtProcedure, CType(resources.GetObject("txtProcedure.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtProcedure, resources.GetString("txtProcedure.HelpString"))
        Me.txtProcedure.ImeMode = CType(resources.GetObject("txtProcedure.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtProcedure.LineColor = CType(resources.GetObject("txtProcedure.LineColor"), System.Drawing.Color)
        Me.txtProcedure.Location = CType(resources.GetObject("txtProcedure.Location"), System.Drawing.Point)
        Me.txtProcedure.Name = "txtProcedure"
        Me.HelpProvider1.SetShowHelp(Me.txtProcedure, CType(resources.GetObject("txtProcedure.ShowHelp"), Boolean))
        Me.txtProcedure.Size = CType(resources.GetObject("txtProcedure.Size"), System.Drawing.Size)
        Me.txtProcedure.SuperTip = CType(resources.GetObject("txtProcedure.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtProcedure.TabIndex = CType(resources.GetObject("txtProcedure.TabIndex"), Integer)
        Me.txtProcedure.Text = resources.GetString("txtProcedure.Text")
        Me.txtProcedure.ToolTip = resources.GetString("txtProcedure.ToolTip")
        Me.txtProcedure.ToolTipIconType = CType(resources.GetObject("txtProcedure.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtProcedure.ToolTipTitle = resources.GetString("txtProcedure.ToolTipTitle")
        Me.txtProcedure.Visible = CType(resources.GetObject("txtProcedure.Visible"), Boolean)
        '
        'btnClearDVDAssigned
        '
        Me.btnClearDVDAssigned.AccessibleDescription = resources.GetString("btnClearDVDAssigned.AccessibleDescription")
        Me.btnClearDVDAssigned.AccessibleName = resources.GetString("btnClearDVDAssigned.AccessibleName")
        Me.btnClearDVDAssigned.Anchor = CType(resources.GetObject("btnClearDVDAssigned.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnClearDVDAssigned.BackgroundImage = CType(resources.GetObject("btnClearDVDAssigned.BackgroundImage"), System.Drawing.Image)
        Me.btnClearDVDAssigned.Dock = CType(resources.GetObject("btnClearDVDAssigned.Dock"), System.Windows.Forms.DockStyle)
        Me.btnClearDVDAssigned.Enabled = CType(resources.GetObject("btnClearDVDAssigned.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.btnClearDVDAssigned, resources.GetString("btnClearDVDAssigned.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.btnClearDVDAssigned, CType(resources.GetObject("btnClearDVDAssigned.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.btnClearDVDAssigned, resources.GetString("btnClearDVDAssigned.HelpString"))
        Me.btnClearDVDAssigned.ImeMode = CType(resources.GetObject("btnClearDVDAssigned.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnClearDVDAssigned.Location = CType(resources.GetObject("btnClearDVDAssigned.Location"), System.Drawing.Point)
        Me.btnClearDVDAssigned.Name = "btnClearDVDAssigned"
        Me.btnClearDVDAssigned.RightToLeft = CType(resources.GetObject("btnClearDVDAssigned.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.btnClearDVDAssigned, CType(resources.GetObject("btnClearDVDAssigned.ShowHelp"), Boolean))
        Me.btnClearDVDAssigned.Size = CType(resources.GetObject("btnClearDVDAssigned.Size"), System.Drawing.Size)
        Me.btnClearDVDAssigned.SuperTip = CType(resources.GetObject("btnClearDVDAssigned.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.btnClearDVDAssigned.TabIndex = CType(resources.GetObject("btnClearDVDAssigned.TabIndex"), Integer)
        Me.btnClearDVDAssigned.Text = resources.GetString("btnClearDVDAssigned.Text")
        Me.btnClearDVDAssigned.ToolTip = resources.GetString("btnClearDVDAssigned.ToolTip")
        Me.btnClearDVDAssigned.ToolTipIconType = CType(resources.GetObject("btnClearDVDAssigned.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.btnClearDVDAssigned.ToolTipTitle = resources.GetString("btnClearDVDAssigned.ToolTipTitle")
        Me.btnClearDVDAssigned.Visible = CType(resources.GetObject("btnClearDVDAssigned.Visible"), Boolean)
        '
        'btnAssignDVDToOrders
        '
        Me.btnAssignDVDToOrders.AccessibleDescription = resources.GetString("btnAssignDVDToOrders.AccessibleDescription")
        Me.btnAssignDVDToOrders.AccessibleName = resources.GetString("btnAssignDVDToOrders.AccessibleName")
        Me.btnAssignDVDToOrders.Anchor = CType(resources.GetObject("btnAssignDVDToOrders.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnAssignDVDToOrders.BackgroundImage = CType(resources.GetObject("btnAssignDVDToOrders.BackgroundImage"), System.Drawing.Image)
        Me.btnAssignDVDToOrders.Dock = CType(resources.GetObject("btnAssignDVDToOrders.Dock"), System.Windows.Forms.DockStyle)
        Me.btnAssignDVDToOrders.Enabled = CType(resources.GetObject("btnAssignDVDToOrders.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.btnAssignDVDToOrders, resources.GetString("btnAssignDVDToOrders.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.btnAssignDVDToOrders, CType(resources.GetObject("btnAssignDVDToOrders.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.btnAssignDVDToOrders, resources.GetString("btnAssignDVDToOrders.HelpString"))
        Me.btnAssignDVDToOrders.ImeMode = CType(resources.GetObject("btnAssignDVDToOrders.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnAssignDVDToOrders.Location = CType(resources.GetObject("btnAssignDVDToOrders.Location"), System.Drawing.Point)
        Me.btnAssignDVDToOrders.Name = "btnAssignDVDToOrders"
        Me.btnAssignDVDToOrders.RightToLeft = CType(resources.GetObject("btnAssignDVDToOrders.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.btnAssignDVDToOrders, CType(resources.GetObject("btnAssignDVDToOrders.ShowHelp"), Boolean))
        Me.btnAssignDVDToOrders.Size = CType(resources.GetObject("btnAssignDVDToOrders.Size"), System.Drawing.Size)
        Me.btnAssignDVDToOrders.SuperTip = CType(resources.GetObject("btnAssignDVDToOrders.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.btnAssignDVDToOrders.TabIndex = CType(resources.GetObject("btnAssignDVDToOrders.TabIndex"), Integer)
        Me.btnAssignDVDToOrders.Text = resources.GetString("btnAssignDVDToOrders.Text")
        Me.btnAssignDVDToOrders.ToolTip = resources.GetString("btnAssignDVDToOrders.ToolTip")
        Me.btnAssignDVDToOrders.ToolTipIconType = CType(resources.GetObject("btnAssignDVDToOrders.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.btnAssignDVDToOrders.ToolTipTitle = resources.GetString("btnAssignDVDToOrders.ToolTipTitle")
        Me.btnAssignDVDToOrders.Visible = CType(resources.GetObject("btnAssignDVDToOrders.Visible"), Boolean)
        '
        'btnSetPickingGroup
        '
        Me.btnSetPickingGroup.AccessibleDescription = resources.GetString("btnSetPickingGroup.AccessibleDescription")
        Me.btnSetPickingGroup.AccessibleName = resources.GetString("btnSetPickingGroup.AccessibleName")
        Me.btnSetPickingGroup.Anchor = CType(resources.GetObject("btnSetPickingGroup.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnSetPickingGroup.BackgroundImage = CType(resources.GetObject("btnSetPickingGroup.BackgroundImage"), System.Drawing.Image)
        Me.btnSetPickingGroup.Dock = CType(resources.GetObject("btnSetPickingGroup.Dock"), System.Windows.Forms.DockStyle)
        Me.btnSetPickingGroup.Enabled = CType(resources.GetObject("btnSetPickingGroup.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.btnSetPickingGroup, resources.GetString("btnSetPickingGroup.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.btnSetPickingGroup, CType(resources.GetObject("btnSetPickingGroup.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.btnSetPickingGroup, resources.GetString("btnSetPickingGroup.HelpString"))
        Me.btnSetPickingGroup.ImeMode = CType(resources.GetObject("btnSetPickingGroup.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnSetPickingGroup.Location = CType(resources.GetObject("btnSetPickingGroup.Location"), System.Drawing.Point)
        Me.btnSetPickingGroup.Name = "btnSetPickingGroup"
        Me.btnSetPickingGroup.RightToLeft = CType(resources.GetObject("btnSetPickingGroup.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.btnSetPickingGroup, CType(resources.GetObject("btnSetPickingGroup.ShowHelp"), Boolean))
        Me.btnSetPickingGroup.Size = CType(resources.GetObject("btnSetPickingGroup.Size"), System.Drawing.Size)
        Me.btnSetPickingGroup.SuperTip = CType(resources.GetObject("btnSetPickingGroup.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.btnSetPickingGroup.TabIndex = CType(resources.GetObject("btnSetPickingGroup.TabIndex"), Integer)
        Me.btnSetPickingGroup.Text = resources.GetString("btnSetPickingGroup.Text")
        Me.btnSetPickingGroup.ToolTip = resources.GetString("btnSetPickingGroup.ToolTip")
        Me.btnSetPickingGroup.ToolTipIconType = CType(resources.GetObject("btnSetPickingGroup.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.btnSetPickingGroup.ToolTipTitle = resources.GetString("btnSetPickingGroup.ToolTipTitle")
        Me.btnSetPickingGroup.Visible = CType(resources.GetObject("btnSetPickingGroup.Visible"), Boolean)
        '
        'frmListingOUT
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
        Me.Name = "frmListingOUT"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        Me.TabResult.ResumeLayout(False)
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabChart.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInfo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaxDVDPerGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "
    Dim _DS As New DataSet
    Dim _ProductView As DataView
    Dim OrderViewToPick As DataView
    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim menuStrip As New dvdpostbuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        _DS.Tables.Add("TmpOrderTable")
        _DS.Tables.Add("TmpProductsDVDTable")

        objDS = New dsEnvelopeLabels
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "orders_out_view1"
        MyBase.IDField = "orders_id"
        MyBase.NameField = "orders_id"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = False
        MyBase.StartUp()

        BKGlobal.SetToolBar(BarManager1, Me.Tag, False, False, False, False, True, False, , False, False, False, False)
        Main_Bar.Visible = False
        Misc_Bar.Visible = True
        CurrentDefaultSetID = cmbDefaultList.EditValue
        'btnOK
        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Never  'DevExpress.XtraBars.BarItemVisibility.Always
        'If CurrentDefaultSetID <> 0 Then
        '    BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
        '    'LoadDataSet()
        '    TabControl1.SelectedTabPage = TabResult
        'Else
        '    TabControl1.SelectedTabPage = TabParameters
        'End If
        TabAnalyse.Visible = False
        TabChart.Visible = False
        TabControl1.SelectedTabPage = TabParameters
        txtProcedure.Text = "1. The system will load all ORDERS to ship." & vbCrLf & _
                            "2. It will create group of DVDs to pick " & vbCrLf & _
                            "      By country " & vbCrLf & _
                            "      By Language " & vbCrLf & _
                            "      With Maximum : " & txtMaxDVDPerGroup.Value.ToString & vbCrLf & _
                            "3. When Result appear : " & vbCrLf & _
                            "   Print 'Picking List' and follow the instruction"
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser1.Caption = "Cancel Order"
        btnUser1.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        btnUser2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser2.Caption = "DVD are Lost"
        btnUser2.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        GridView1.OptionsSelection.MultiSelect = True
        'MsgBox("Tutu")
    End Sub
    Private Sub btnLoadOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadOrders.Click
        LoadOrders()
    End Sub
    Public Sub LoadOrders()
        Dim _SQLTxt As String
        _DS.Tables("TmpOrderTable").Clear()
        _DS.Tables("TmpProductsDVDTable").Clear()

        txtInfo.Text = "Load Orders to Ship"
        DoEvents()
        _SQLTxt = "SELECT orders_products_id,  orders_id, products_id, products_dvd, orders_products_status, " & _
                  " orders_products_type  FROM orders_products op  WHERE op.orders_products_status = 0 " 'Ready for Exped
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("TmpOrderTable"), _SQLTxt)
        txtInfo.Text = "Loading Products_DVD Info"
        DoEvents()
        _SQLTxt = "SELECT products_id, products_dvdid, products_dvd_status, `inout`, box_id, pibox_id " & _
                          " FROM products_dvd " & _
                          " WHERE products_dvd_status = 1 and `inout` = 1 and box_id <> 0 ORDER BY box_id"
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("TmpProductsDVDTable"), _SQLTxt)
        _DS.Tables("TmpProductsDVDTable").PrimaryKey = New DataColumn() {_DS.Tables("TmpProductsDVDTable").Columns("products_id"), _
                                                                 _DS.Tables("TmpProductsDVDTable").Columns("products_dvdid")}
        _ProductView = New DataView(_DS.Tables("TmpProductsDVDTable"), " ", "products_id, inout ", DataViewRowState.CurrentRows)

        _SQLTxt = " SELECT o.orders_id, o.customers_id, o.delivery_country, op.products_id, op.products_dvd as dvd_id, pd.box_id, " & _
                  " pd.pibox_id, c.customers_language as language_id, op.pick_group, op.pick_boxid, o.date_purchased " & _
                  " FROM orders o " & _
                  " LEFT JOIN orders_products op on op.orders_id = o.orders_id " & _
                  " LEFT JOIN products_dvd pd on pd.products_id = op.products_id and pd.products_dvdid= op.products_dvd " & _
                  " LEFT JOIN customers c on c.customers_id = o.customers_id" & _
                  " WHERE o.orders_status = 1 ORDER BY o.customers_id " 'Ready for Exped
        objDS.Tables("orders_out_view1").Clear()
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("orders_out_view1"), _SQLTxt)
        'Set_Pick_Group()
        Grid1.DataSource = objDS.Tables("orders_out_view1") 'objDS.Tables(TableName).DefaultView
        TabControl1.SelectedTabPage = TabResult
    End Sub
    Private Function Getsigne(ByVal pos As Integer) As String
        If pos = 1 Then
            Return "="
        Else
            Return "<>"
        End If
    End Function


    Private Sub Set_Pick_Group()

        Dim _View As DataView

        Dim signeI, signeJ As String

        For i As Integer = 1 To 2
            signeI = Getsigne(i)
            For j As Integer = 1 To 2
                signeJ = Getsigne(j)
                _View = New DataView(objDS.Tables(TableName), _
                "delivery_country " & signeI & " 'Belgium' and (language_id " & signeJ & " '2')", _
                "customers_id", DataViewRowState.CurrentRows)
                txtInfo.EditValue = _View.Count
                AssignGroup(_View)
            Next
        Next


        ''Setting Tot and Max by Group
        '_View = New DataView(objDS.Tables(TableName), "delivery_country = 'Belgium' and (language_id <> '2')", _
        ' "customers_id", DataViewRowState.CurrentRows)
        'txtInfo.EditValue = _View.Count
        'AssignGroup(_View)

        ''_tot_be_fr = _View1.Count
        '_View = New DataView(objDS.Tables(TableName), "delivery_country = 'Belgium' and (language_id = '2')", _
        '         "customers_id", DataViewRowState.CurrentRows)
        'txtInfo.EditValue = _View.Count
        'AssignGroup(_View)
        ''_tot_be_nl = _View1.Count
        '_View = New DataView(objDS.Tables(TableName), "delivery_country <> 'Belgium' and (language_id <> '2')", _
        '         "customers_id", DataViewRowState.CurrentRows)
        'txtInfo.EditValue = _View.Count
        'AssignGroup(_View)
        ''_tot_eu_fr = _View1.Count
        '_View = New DataView(objDS.Tables(TableName), "delivery_country <> 'Belgium' and (language_id = '2')", _
        '         "customers_id", DataViewRowState.CurrentRows)
        'txtInfo.EditValue = _View.Count
        'AssignGroup(_View)

    End Sub
    Private Sub AssignGroup(ByVal vView As DataView)
        '1Box EU-FR : Box Nbr 1
        '1Box EU-NL : Box Nbr 2
        '2Box BE-NL : Box Nbr 3 and 4
        '5Boxes BE-FR : Box Nbr 5, 6, 7, 8 and 9
        Dim _row As DataRowView
        Dim _i As Integer = 0
        Dim _Grp As String = ""
        Dim _Grp_Ctry As String = ""
        Dim _Grp_Lang As Integer = 0
        Dim _Grp_ID As Integer = 1
        Dim _tot As Integer
        Dim _max As Integer = 200
        If vView.Count = 0 Then Exit Sub
        _Grp_Ctry = vView(0)("delivery_country")
        _Grp_Lang = vView(0)("language_id")
        _tot = vView.Count
        If _Grp_Ctry <> "Belgium" Then 'EU Other than BE
            _max = _tot
            If _Grp_Lang <> 2 Then 'BE-FR
                _Grp_ID = 1
            Else 'BE-NL
                _Grp_ID = 2
            End If
        Else
            If _Grp_Lang <> 2 Then 'BE-FR
                _max = Fix((_tot / 5)) + 2
                _Grp_ID = 5
            Else 'BE-NL
                _max = Fix(_tot / 2) + 2
                _Grp_ID = 3
            End If
        End If
        If _max < 200 Then _max = 200
        For Each _row In vView
            _i += 1
            'If _row("products_id") = 7159 Or _
            '    _row("products_id") = 114133 Or _
            '    _row("products_id") = 110036 Or _
            '    _row("products_id") = 119887 Then


            If _i > _max Then
                _Grp_ID += 1
                _i = 1
            End If
            _Grp = _Grp_Ctry & "-" & Format(_Grp_Lang, "00") & "-" & Format(_Grp_ID, "00")
            _row("pick_group") = _Grp

            DvdPostData.clsConnection.ExecuteNonQuery("update orders_products set pick_group = '" & _Grp & "' , pick_boxid = " & _Grp_ID & _
                  " WHERE orders_id = " & _row("orders_id"))
            ' End If
            txtInfo.EditValue -= 1
            DoEvents()
        Next
    End Sub
    Private Sub btnClearDVDAssigned_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearDVDAssigned.Click
        Dim _SQLTxt As String
        _SQLTxt = "UPDATE products_dvd SET `inout` = 1 WHERE `inout` = 2 "
        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        _SQLTxt = "update orders_products op set  op.products_dvd = 0 where op.orders_products_status = 0 " 'Ready For Exped
        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
    End Sub
    Private Sub btnAssignDVDToOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignDVDToOrders.Click
        Dim _products_id As Integer
        Dim _DVDID As Integer
        Dim _SQL As String

        Dim _Row As DataRow
        Dim _ProductTable As New DataTable("products_dvd")
        txtInfo.EditValue = _DS.Tables("TmpOrderTable").Rows.Count
        For Each _Row In _DS.Tables("TmpOrderTable").Rows
            txtInfo.EditValue -= 1
            DoEvents()
            _products_id = _Row("products_id")
            If _Row("products_dvd") = 0 And _products_id > 50 Then
                'Find DVDID to Ship
                '_ProductRows = _ProductView.FindRows(New Object() {_products_id, 1})
                _SQL = " SELECT products_id, products_dvdid, products_dvd_status, `inout`, box_id, pibox_id " & _
                       " FROM products_dvd " & _
                       " WHERE products_id = " & _products_id & " AND products_dvd_status = 1 and `inout` = 1 and box_id <> 0" & _
                       " ORDER BY box_id limit 1 "
                _ProductTable.Clear()
                DvdPostData.clsConnection.FillDataSet(_ProductTable, _SQL)
                'If _ProductRows.GetLength(0) > 0 Then
                If _ProductTable.Rows.Count = 1 Then
                    _DVDID = _ProductTable.Rows(0)("products_dvdid")
                    _ProductTable.Rows(0)("inout") = 2
                    'Assign DVDID to Orders_PRoducts 
                    '_SQL = "update orders_products op set op.orders_products_status = " & StatusEnum.OrderProductStatus.ORDERS_PRODUCTS_STATUS_EXPEDITED & " , op.products_dvd=" & _DVDID & _
                    '     " where op.orders_id=" & _Row("orders_id")
                    _SQL = "update orders_products op set  op.products_dvd=" & _DVDID & " where op.orders_id=" & _Row("orders_id")
                    DvdPostData.clsConnection.ExecuteNonQuery(_SQL)
                    _SQL = "update products_dvd pd set  `inout` = 2 WHERE pd.products_id = " & _products_id & " AND products_dvdid = " & _DVDID
                    DvdPostData.clsConnection.ExecuteNonQuery(_SQL)
                    '_SQL = "update products p set  products_quantity = products_quantity - 1 WHERE p.products_id = " & _products_id
                    'DvdPostData.clsConnection.ExecuteNonQuery(_SQL)
                    '`inout` = 1 if IN
                    '`inout` = 0 if OUT
                    '`inout` = 2 if ToBePicked
                End If
            End If
        Next
    End Sub
    Private Sub btnSetPickingGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPickingGroup.Click
        Set_Pick_Group()
    End Sub
    Private Sub btnUser1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick
        'Cancel Orders
        Dim _Orders_ID As Integer
        Dim _customers_id As Integer
        Dim _products_id As Integer
        Dim _dvd_id As Integer
        Dim _objProductsDVD As clsProduct_DVD
        Dim _DS As dsProducts
        Dim _i As Integer
        Dim _bool_line_selected As Boolean = False

        For Each _i In GridView1.GetSelectedRows
            _Orders_ID = GridView1.GetDataRow(_i)("orders_id")
            _customers_id = GridView1.GetDataRow(_i)("customers_id")
            _products_id = GridView1.GetDataRow(_i)("products_id")
            _dvd_id = GridView1.GetDataRow(_i)("dvd_id")
            _DS = New dsProducts
            _objProductsDVD = New clsProduct_DVD(SessionInfo, _DS, _products_id, _dvd_id)
            _objProductsDVD.CancelOrder(_Orders_ID, _customers_id)

        Next
        Do
            If GridView1.GetSelectedRows.Length = 0 Then Exit Do

            GridView1.DeleteRow(GridView1.GetSelectedRows(0))

        Loop
        MsgBox("Process Complete")
    End Sub
    Private Sub btnUser2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser2.ItemClick
        Dim _Orders_ID As Integer
        Dim _customers_id As Integer
        Dim _products_id As Integer
        Dim _dvd_id As Integer
        Dim objProductDVD As clsProduct_DVD
        Dim _DS As dsProducts
        Dim _i As Integer
        For Each _i In GridView1.GetSelectedRows
            _Orders_ID = GridView1.GetDataRow(_i)("orders_id")
            _customers_id = GridView1.GetDataRow(_i)("customers_id")
            _products_id = GridView1.GetDataRow(_i)("products_id")
            _dvd_id = GridView1.GetDataRow(_i)("dvd_id")
            _DS = New dsProducts
            objProductDVD = New clsProduct_DVD(SessionInfo, _DS, _products_id, _dvd_id)

            objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.BIZARREMENT_PERDU, _
                                                          "Listing OUT - bizarement perdu", _
                                                          DvdPostData.ClsProducts_dvd_state.state.OUT)

            ' objProductDVD.ChangeDVDStatus2(_products_id, _dvd_id, 15, , , "")

        Next
        MsgBox("Process Complete")
    End Sub
    Public Overrides Sub gridview1_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles GridView1.DoubleClick
        Dim _frm As New frmCancelOrder(SessionInfo)
        Dim _Orders_ID As Integer
        Dim _customers_id As Integer
        Dim _products_id As Integer
        Dim _dvd_id As Integer

        Dim _i As Integer = GridView1.FocusedRowHandle
        _Orders_ID = GridView1.GetDataRow(_i)("orders_id")
        _customers_id = GridView1.GetDataRow(_i)("customers_id")
        _products_id = GridView1.GetDataRow(_i)("products_id")
        _dvd_id = GridView1.GetDataRow(_i)("dvd_id")
        _frm.txtOrderID.EditValue = _Orders_ID
        _frm.SearchOrderInfo()
        _frm.ShowDialog(Me)


        LoadOrders()
    End Sub
End Class
