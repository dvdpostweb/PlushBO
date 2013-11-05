Imports System.Web.Mail
Public Class frmEMail
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
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents lblMessage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbMessage As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEMail))
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.lblMessage = New DevExpress.XtraEditors.LabelControl
        Me.cmbMessage = New DevExpress.XtraEditors.LookUpEdit
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabParameters.SuspendLayout()
        Me.TabResult.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAnalyse.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabChart.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMessage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.Name = "TabControl1"
        Me.HelpProvider1.SetShowHelp(Me.TabControl1, CType(resources.GetObject("TabControl1.ShowHelp"), Boolean))
        Me.TabControl1.Size = CType(resources.GetObject("TabControl1.Size"), System.Drawing.Size)
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.lblMessage)
        Me.TabParameters.Controls.Add(Me.cmbMessage)
        Me.TabParameters.Name = "TabParameters"
        Me.HelpProvider1.SetShowHelp(Me.TabParameters, CType(resources.GetObject("TabParameters.ShowHelp"), Boolean))
        Me.TabParameters.Size = CType(resources.GetObject("TabParameters.Size"), System.Drawing.Size)
        '
        'TabResult
        '
        Me.TabResult.Name = "TabResult"
        Me.HelpProvider1.SetShowHelp(Me.TabResult, CType(resources.GetObject("TabResult.ShowHelp"), Boolean))
        Me.TabResult.Size = CType(resources.GetObject("TabResult.Size"), System.Drawing.Size)
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
        'TabAnalyse
        '
        Me.TabAnalyse.Name = "TabAnalyse"
        Me.HelpProvider1.SetShowHelp(Me.TabAnalyse, CType(resources.GetObject("TabAnalyse.ShowHelp"), Boolean))
        Me.TabAnalyse.Size = CType(resources.GetObject("TabAnalyse.Size"), System.Drawing.Size)
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = CType(resources.GetObject("StatusBar1.Location"), System.Drawing.Point)
        Me.StatusBar1.Name = "StatusBar1"
        Me.HelpProvider1.SetShowHelp(Me.StatusBar1, CType(resources.GetObject("StatusBar1.ShowHelp"), Boolean))
        Me.ToolTipController1.SetSuperTip(Me.StatusBar1, CType(resources.GetObject("StatusBar1.SuperTip"), DevExpress.Utils.SuperToolTip))
        '
        'UcPivotGrid1
        '
        Me.UcPivotGrid1.Name = "UcPivotGrid1"
        Me.HelpProvider1.SetShowHelp(Me.UcPivotGrid1, CType(resources.GetObject("UcPivotGrid1.ShowHelp"), Boolean))
        Me.UcPivotGrid1.Size = CType(resources.GetObject("UcPivotGrid1.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.UcPivotGrid1, CType(resources.GetObject("UcPivotGrid1.SuperTip"), DevExpress.Utils.SuperToolTip))
        '
        'UcChart1
        '
        Me.UcChart1.Name = "UcChart1"
        Me.UcChart1.Size = CType(resources.GetObject("UcChart1.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.UcChart1, CType(resources.GetObject("UcChart1.SuperTip"), DevExpress.Utils.SuperToolTip))
        '
        'Panel1
        '
        Me.Panel1.Location = CType(resources.GetObject("Panel1.Location"), System.Drawing.Point)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = CType(resources.GetObject("Panel1.Size"), System.Drawing.Size)
        Me.ToolTipController1.SetSuperTip(Me.Panel1, CType(resources.GetObject("Panel1.SuperTip"), DevExpress.Utils.SuperToolTip))
        '
        'TabChart
        '
        Me.TabChart.Name = "TabChart"
        Me.TabChart.Size = CType(resources.GetObject("TabChart.Size"), System.Drawing.Size)
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
        'lblMessage
        '
        Me.lblMessage.AccessibleDescription = resources.GetString("lblMessage.AccessibleDescription")
        Me.lblMessage.AccessibleName = resources.GetString("lblMessage.AccessibleName")
        Me.lblMessage.Anchor = CType(resources.GetObject("lblMessage.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblMessage.AutoSizeMode = CType(resources.GetObject("lblMessage.AutoSizeMode"), DevExpress.XtraEditors.LabelAutoSizeMode)
        Me.lblMessage.Dock = CType(resources.GetObject("lblMessage.Dock"), System.Windows.Forms.DockStyle)
        Me.lblMessage.Enabled = CType(resources.GetObject("lblMessage.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.lblMessage, resources.GetString("lblMessage.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblMessage, CType(resources.GetObject("lblMessage.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblMessage, resources.GetString("lblMessage.HelpString"))
        Me.lblMessage.ImeMode = CType(resources.GetObject("lblMessage.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblMessage.LineColor = CType(resources.GetObject("lblMessage.LineColor"), System.Drawing.Color)
        Me.lblMessage.Location = CType(resources.GetObject("lblMessage.Location"), System.Drawing.Point)
        Me.lblMessage.Name = "lblMessage"
        Me.HelpProvider1.SetShowHelp(Me.lblMessage, CType(resources.GetObject("lblMessage.ShowHelp"), Boolean))
        Me.lblMessage.Size = CType(resources.GetObject("lblMessage.Size"), System.Drawing.Size)
        Me.lblMessage.SuperTip = CType(resources.GetObject("lblMessage.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.lblMessage.TabIndex = CType(resources.GetObject("lblMessage.TabIndex"), Integer)
        Me.lblMessage.Text = resources.GetString("lblMessage.Text")
        Me.lblMessage.ToolTip = resources.GetString("lblMessage.ToolTip")
        Me.lblMessage.ToolTipIconType = CType(resources.GetObject("lblMessage.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.lblMessage.ToolTipTitle = resources.GetString("lblMessage.ToolTipTitle")
        Me.lblMessage.Visible = CType(resources.GetObject("lblMessage.Visible"), Boolean)
        '
        'cmbMessage
        '
        Me.cmbMessage.Anchor = CType(resources.GetObject("cmbMessage.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cmbMessage.BackgroundImage = CType(resources.GetObject("cmbMessage.BackgroundImage"), System.Drawing.Image)
        Me.cmbMessage.Dock = CType(resources.GetObject("cmbMessage.Dock"), System.Windows.Forms.DockStyle)
        Me.cmbMessage.EditValue = CType(resources.GetObject("cmbMessage.EditValue"), Object)
        Me.cmbMessage.Enabled = CType(resources.GetObject("cmbMessage.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.cmbMessage, resources.GetString("cmbMessage.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.cmbMessage, CType(resources.GetObject("cmbMessage.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.cmbMessage, resources.GetString("cmbMessage.HelpString"))
        Me.cmbMessage.ImeMode = CType(resources.GetObject("cmbMessage.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cmbMessage.Location = CType(resources.GetObject("cmbMessage.Location"), System.Drawing.Point)
        Me.cmbMessage.Name = "cmbMessage"
        '
        'cmbMessage.Properties
        '
        Me.cmbMessage.Properties.AccessibleDescription = resources.GetString("cmbMessage.Properties.AccessibleDescription")
        Me.cmbMessage.Properties.AccessibleName = resources.GetString("cmbMessage.Properties.AccessibleName")
        Me.cmbMessage.Properties.AutoHeight = CType(resources.GetObject("cmbMessage.Properties.AutoHeight"), Boolean)
        Me.cmbMessage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMessage.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mail_messages_id", "mail_messages_id", 104, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("messages_subject", "messages_subject", 94, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbMessage.Properties.DisplayMember = "messages_subject"
        Me.cmbMessage.Properties.Mask.AutoComplete = CType(resources.GetObject("cmbMessage.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.cmbMessage.Properties.Mask.BeepOnError = CType(resources.GetObject("cmbMessage.Properties.Mask.BeepOnError"), Boolean)
        Me.cmbMessage.Properties.Mask.EditMask = resources.GetString("cmbMessage.Properties.Mask.EditMask")
        Me.cmbMessage.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("cmbMessage.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.cmbMessage.Properties.Mask.MaskType = CType(resources.GetObject("cmbMessage.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.cmbMessage.Properties.Mask.PlaceHolder = CType(resources.GetObject("cmbMessage.Properties.Mask.PlaceHolder"), Char)
        Me.cmbMessage.Properties.Mask.SaveLiteral = CType(resources.GetObject("cmbMessage.Properties.Mask.SaveLiteral"), Boolean)
        Me.cmbMessage.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("cmbMessage.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.cmbMessage.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("cmbMessage.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.cmbMessage.Properties.NullText = resources.GetString("cmbMessage.Properties.NullText")
        Me.cmbMessage.Properties.ValueMember = "mail_messages_id"
        Me.cmbMessage.RightToLeft = CType(resources.GetObject("cmbMessage.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.cmbMessage, CType(resources.GetObject("cmbMessage.ShowHelp"), Boolean))
        Me.cmbMessage.Size = CType(resources.GetObject("cmbMessage.Size"), System.Drawing.Size)
        Me.cmbMessage.SuperTip = CType(resources.GetObject("cmbMessage.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.cmbMessage.TabIndex = CType(resources.GetObject("cmbMessage.TabIndex"), Integer)
        Me.cmbMessage.ToolTip = resources.GetString("cmbMessage.ToolTip")
        Me.cmbMessage.ToolTipIconType = CType(resources.GetObject("cmbMessage.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.cmbMessage.ToolTipTitle = resources.GetString("cmbMessage.ToolTipTitle")
        Me.cmbMessage.Visible = CType(resources.GetObject("cmbMessage.Visible"), Boolean)
        '
        'frmEMail
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
        Me.Name = "frmEMail"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.ToolTipController1.SetSuperTip(Me, CType(resources.GetObject("$this.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.Text = resources.GetString("$this.Text")
        Me.ToolTipController1.SetTitle(Me, resources.GetString("$this.Title"))
        Me.ToolTipController1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me, CType(resources.GetObject("$this.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        Me.TabResult.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAnalyse.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabChart.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMessage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "
    Dim mvarsmtpserver As String = "" '"192.168.0.203"
    Dim mvarsite As String = "" '"www.dvdpost.be"
    Dim intmessages_id As Integer = 0 '94

    Public Class clsABO
        Public ABO_ID As Integer
        Public ABO_Name As String
        Public DVD_Credit As Integer
        Public ABO_price As Double
        Public DVD_At_Home As Integer
        Public ABO_Description As String
        Private mvarSessionInfo As BizzLib.clsSessionInfo
        Dim Cls1 As BizzLib.clsDataSet

        Public Sub New(ByVal v_SessionInfo As BizzLib.clsSessionInfo, ByVal v_ABo_ID As Integer, ByVal v_lang As Integer)
            mvarSessionInfo = v_SessionInfo
            Cls1 = New BizzLib.clsDataSet(mvarSessionInfo)
            Dim _DS As New DataSet
            _DS.Tables.Add("products")
            _DS.Tables.Add("products_abo")
            _DS.Tables.Add("products_description")
            Dim _SQLTxt As String
            _SQLTxt = "SELECT products_id, products_price FROM products where products_id = " & v_ABo_ID
            Cls1.FillDataSet(_DS.Tables("products"), _SQLTxt)
            _SQLTxt = "SELECT * FROM Products_abo where products_id = " & v_ABo_ID
            Cls1.FillDataSet(_DS.Tables("products_abo"), _SQLTxt)
            _SQLTxt = "SELECT * FROM Products_description where products_id = " & v_ABo_ID & " AND language_id = " & v_lang
            Cls1.FillDataSet(_DS.Tables("products_description"), _SQLTxt)
            ABO_ID = v_ABo_ID
            If _DS.Tables("products_description").Rows.Count = 1 Then
                ABO_Name = _DS.Tables("products_description").Rows(0).Item("products_name")
                ABO_Description = _DS.Tables("products_description").Rows(0).Item("products_description")
                DVD_Credit = _DS.Tables("products_abo").Rows(0).Item("qty_credit")
                ABO_price = _DS.Tables("products").Rows(0).Item("products_price")
                DVD_At_Home = _DS.Tables("products_abo").Rows(0).Item("qty_at_home")
            Else
                ABO_Name = ""
                ABO_Description = ""
                DVD_Credit = 0
                ABO_price = 0
                DVD_At_Home = 0
            End If
        End Sub

    End Class

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objDS = New dsCustomers
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "customers_view1"
        MyBase.IDField = "customers_id"
        MyBase.NameField = "customers_lastname"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = False
        MyBase.StartUp()
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser1.Caption = "SEND E-Mails"

        SQLTxt1 = "SELECT C.customers_id , customers_gender, customers_firstname ,customers_lastname , customers_email_address , " & _
                  " customers_abo , customers_abo_type, customers_abo_dvd_credit, customers_abo_dvd_norm, customers_abo_dvd_adult, " & _
                  " customers_abo_dvd_home_norm, customers_abo_dvd_home_adult " & _
          " , customers_next_abo_type, " & _
          " if (customers_abo_validityto = '0000-00-00', Null, customers_abo_validityto) as customers_abo_validityto,  " & _
          " if (customers_dob = '0000-00-00', Null, customers_dob) as customers_dob , " & _
          " CI.* " & _
          " FROM customers C " & _
          " LEFT JOIN customers_info CI on CI.customers_info_id = C.customers_id  "

        BKGlobal.Cls1.FillDataSet(objDS.Tables("mail_messages1"), "SELECT * from mail_messages WHERE language_id = 1")
        cmbMessage.Properties.DataSource = objDS.Tables("mail_messages1")
        mvarsmtpserver = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM GeneralGlobalParameter WHERE SetUpCategory = 'Global' and Name = 'SMTPServer'")
        mvarsite = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM GeneralGlobalParameter WHERE SetUpCategory = 'Global' and Name = 'BESite'")
        BKGlobal.Cls1.FillDataSet(objDS.Tables("languages"), "SELECT * from languages ")

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
        'Create a new dataset to hold the records returned from the call to FillDataSet.
        'A temporary dataset is used because filling the existing dataset would
        'require the databindings to be rebound.
        'ToBeChecked *** Change DataSet to use
        Dim _SQLTxt As String = SQLTxt1
        If IsNothing(objDS.Tables(TableName)) Then
            objDS.Tables.Add(TableName)
        Else
            objDS.Tables(TableName).Clear()
        End If

        Try
            'Only Appropriate Entity
            OledbAdpat = New OleDb.OleDbDataAdapter(_SQLTxt, SessionInfo.OleDBConn)
            BKFilter.ApplyFilter(OledbAdpat, IsFiltered, CurrentFilterID, WhereClause & "", StatusBar1.Panels(1))
            'Attempt to fill the temporary dataset.
            Cls1.FillDataSet(objDS.Tables(TableName), OledbAdpat.SelectCommand.CommandText & " " & OrderByClause)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            'objDS.Clear()
            'Merge the records into the main dataset.
            'objDS.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try
        objDS.Tables(TableName).DefaultView.Sort = NameField
        Grid1.DataSource = objDS.Tables(TableName).DefaultView
        UcPivotGrid1.PivotGrid1.DataSource = objDS.Tables(TableName).DefaultView
        TabControl1.SelectedTabPage = TabResult
    End Sub

    'Public Overrides Sub LoadDataSet()
    '    Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
    '    Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
    '    Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
    '    TabControl1.SelectedTabPage = TabResult
    'End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub

    Private Sub btnUser1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick
        'Sending E-Mails
        Dim strFrom As String = "dvdpost@dvdpost.be"
        Dim strTo As String
        Dim strSubject As String = ""
        Dim strMessage As String = ""
        Dim _CustRow, _CustInfoRow As DataRow
        Dim _MailRow As DataRow
        Dim _i As Integer
        Dim intcustomers_language As Integer
        Dim sSQL2, sSQL3 As String
        Dim intmaxmailid As Integer
        Dim _actual_abo, _next_abo As clsABO
        sSQL3 = "SELECT max(mail_messages_sent_history_id) as cc  FROM mail_messages_sent_history  "
        intmaxmailid = BKGlobal.ExecuteFindFieldValueINT("cc", sSQL3)
        If IsDBNull(cmbMessage.EditValue) Then
            Exit Sub
        End If
        intmessages_id = cmbMessage.EditValue
        For _i = 0 To GridView1.RowCount - 1
            _CustRow = GridView1.GetDataRow(_i)
            intcustomers_language = _CustRow.Item("customers_language")
            _actual_abo = New clsABO(SessionInfo, _CustRow.Item("customers_abo_type"), intcustomers_language)
            _next_abo = New clsABO(SessionInfo, GetNextAbo(_CustRow.Item("customers_abo_type")), intcustomers_language)
            strTo = _CustRow.Item("customers_email_address")
            objDS.Tables("mail_messages").Clear()
            sSQL2 = "SELECT * FROM mail_messages WHERE mail_messages_id = '" & intmessages_id & "' and language_id = '" & intcustomers_language & "'"
            BKGlobal.Cls1.FillDataSet(objDS.Tables("mail_messages"), sSQL2)
            For Each _MailRow In objDS.Tables("mail_messages").Rows
                strSubject = _MailRow.Item("messages_subject")
                strMessage = _MailRow.Item("messages_html")
                'titre
                strMessage = Replace(strMessage, "$$$title$$$", _MailRow.Item("messages_title"))
                'customers_name
                strMessage = Replace(strMessage, "$$$customers_name$$$", _CustRow.Item("customers_firstname") & " " & _CustRow.Item("customers_lastname"))
                'site
                strMessage = Replace(strMessage, "$$$site$$$", "<a href='" & mvarsite & " '>" & mvarsite & "</a>")
                'today
                strMessage = Replace(strMessage, "$$$today$$$", Today())
                'mailid 
                strMessage = Replace(strMessage, "$$$mail_id$$$", intmaxmailid + 1)
                'customers_id
                strMessage = Replace(strMessage, "$$$customers_id$$$", _CustRow.Item("customers_id"))
                'customers_abo_validityto
                strMessage = Replace(strMessage, "$$$next_reconduction_date$$$", _CustRow.Item("customers_abo_validityto"))

                strMessage = Replace(strMessage, "$$$actual_abo_name$$$", _actual_abo.ABO_Name)
                strMessage = Replace(strMessage, "$$$actual_abo_price$$$", _actual_abo.ABO_price)
                strMessage = Replace(strMessage, "$$$next_abo_name$$$", _next_abo.ABO_Name)
                strMessage = Replace(strMessage, "$$$next_abo_price$$$", _next_abo.ABO_price)
                strMessage = Replace(strMessage, "$$$next_abo_dvd_credit$$$", _next_abo.DVD_Credit)
                strMessage = Replace(strMessage, "$$$next_abo_dvd_at_home$$$", _next_abo.DVD_At_Home)

                Dim mymail As New MailMessage
                mymail.From = strFrom
                mymail.To = strTo
                mymail.Subject = strSubject
                mymail.Body = strMessage
                mymail.BodyFormat = MailFormat.Html
                mymail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1")
                mymail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "Administrator")
                mymail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "DVD7(post")

                SmtpMail.SmtpServer = mvarsmtpserver
                Try
                    SmtpMail.Send(mymail)
                Catch ex As Exception
                    ex.Message.ToString()
                End Try
                sSQL3 = "insert into mail_messages_sent_history (mail_messages_sent_history_id, date, customers_id, " & _
                        " mail_messages_id , language_id ) values('" & intmaxmailid + 1 & _
                        "', now(), '" & _CustRow.Item("customers_id") & "', '" & intmessages_id & "', '" & _
                        intcustomers_language & "' ) "
                BKGlobal.Cls1.ExecuteNonQuery(sSQL3)
                'If E-Mail for Change ABO Type the Set customers_Next_abo_Type - Sorry for HardCoding
                If intmessages_id = 96 Then
                    sSQL3 = "UPDATE customers SET customers_next_abo_type = " & _next_abo.ABO_ID & _
                            " WHERE customers_id = " & _CustRow.Item("customers_id")
                    BKGlobal.Cls1.ExecuteNonQuery(sSQL3)
                End If

                intmaxmailid += 1
            Next
        Next
        MsgBox("Done", MsgBoxStyle.Information)
    End Sub
    Function GetNextAbo(ByVal currentAbo As Integer) As Integer
        Select Case currentAbo
            Case 2
                Return 18
            Case 5
                Return 18
            Case 6
                Return 20
            Case 7
                Return 22
            Case 8
                Return 24
            Case 9
                Return 25
            Case Else
                Return currentAbo
        End Select

    End Function
End Class
