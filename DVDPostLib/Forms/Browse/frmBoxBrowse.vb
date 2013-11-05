Public Class frmBoxBrowse
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
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBox_ID As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBoxBrowse))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtBox_ID = New DevExpress.XtraEditors.TextEdit
        Me.Panel1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabChart.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        Me.TabResult.SuspendLayout()
        Me.TabParameters.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBox_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Name = "Panel1"
        Me.HelpProvider1.SetShowHelp(Me.Panel1, CType(resources.GetObject("Panel1.ShowHelp"), Boolean))
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
        'StatusBar1
        '
        Me.StatusBar1.Name = "StatusBar1"
        Me.HelpProvider1.SetShowHelp(Me.StatusBar1, CType(resources.GetObject("StatusBar1.ShowHelp"), Boolean))
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
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.LabelControl1)
        Me.TabParameters.Controls.Add(Me.txtBox_ID)
        Me.TabParameters.Name = "TabParameters"
        Me.TabParameters.Size = CType(resources.GetObject("TabParameters.Size"), System.Drawing.Size)
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
        'txtBox_ID
        '
        Me.txtBox_ID.Anchor = CType(resources.GetObject("txtBox_ID.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtBox_ID.BackgroundImage = CType(resources.GetObject("txtBox_ID.BackgroundImage"), System.Drawing.Image)
        Me.txtBox_ID.Dock = CType(resources.GetObject("txtBox_ID.Dock"), System.Windows.Forms.DockStyle)
        Me.txtBox_ID.EditValue = CType(resources.GetObject("txtBox_ID.EditValue"), Object)
        Me.txtBox_ID.Enabled = CType(resources.GetObject("txtBox_ID.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.txtBox_ID, resources.GetString("txtBox_ID.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtBox_ID, CType(resources.GetObject("txtBox_ID.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtBox_ID, resources.GetString("txtBox_ID.HelpString"))
        Me.txtBox_ID.ImeMode = CType(resources.GetObject("txtBox_ID.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtBox_ID.Location = CType(resources.GetObject("txtBox_ID.Location"), System.Drawing.Point)
        Me.txtBox_ID.Name = "txtBox_ID"
        '
        'txtBox_ID.Properties
        '
        Me.txtBox_ID.Properties.AccessibleDescription = resources.GetString("txtBox_ID.Properties.AccessibleDescription")
        Me.txtBox_ID.Properties.AccessibleName = resources.GetString("txtBox_ID.Properties.AccessibleName")
        Me.txtBox_ID.Properties.AutoHeight = CType(resources.GetObject("txtBox_ID.Properties.AutoHeight"), Boolean)
        Me.txtBox_ID.Properties.Mask.AutoComplete = CType(resources.GetObject("txtBox_ID.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtBox_ID.Properties.Mask.BeepOnError = CType(resources.GetObject("txtBox_ID.Properties.Mask.BeepOnError"), Boolean)
        Me.txtBox_ID.Properties.Mask.EditMask = resources.GetString("txtBox_ID.Properties.Mask.EditMask")
        Me.txtBox_ID.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtBox_ID.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtBox_ID.Properties.Mask.MaskType = CType(resources.GetObject("txtBox_ID.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtBox_ID.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtBox_ID.Properties.Mask.PlaceHolder"), Char)
        Me.txtBox_ID.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtBox_ID.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtBox_ID.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtBox_ID.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtBox_ID.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtBox_ID.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtBox_ID.Properties.NullText = resources.GetString("txtBox_ID.Properties.NullText")
        Me.txtBox_ID.Properties.ReadOnly = True
        Me.txtBox_ID.RightToLeft = CType(resources.GetObject("txtBox_ID.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.txtBox_ID, CType(resources.GetObject("txtBox_ID.ShowHelp"), Boolean))
        Me.txtBox_ID.Size = CType(resources.GetObject("txtBox_ID.Size"), System.Drawing.Size)
        Me.txtBox_ID.SuperTip = CType(resources.GetObject("txtBox_ID.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtBox_ID.TabIndex = CType(resources.GetObject("txtBox_ID.TabIndex"), Integer)
        Me.txtBox_ID.ToolTip = resources.GetString("txtBox_ID.ToolTip")
        Me.txtBox_ID.ToolTipIconType = CType(resources.GetObject("txtBox_ID.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtBox_ID.ToolTipTitle = resources.GetString("txtBox_ID.ToolTipTitle")
        Me.txtBox_ID.Visible = CType(resources.GetObject("txtBox_ID.Visible"), Boolean)
        '
        'frmBoxBrowse
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
        Me.Name = "frmBoxBrowse"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabChart.ResumeLayout(False)
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabResult.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBox_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objDS = New dsProducts
        objDS.Tables.Add("BoxView")
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "OrdersLocalView"
        MyBase.IDField = "orders_id"
        MyBase.NameField = "orders_id"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = False
        MyBase.StartUp()

        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , , False, False, True)
        CurrentDefaultSetID = cmbDefaultList.EditValue
        'btnOK
        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'If CurrentDefaultSetID <> 0 Then
        '    BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
        '    'LoadDataSet()
        '    TabControl1.SelectedTabPage = TabResult
        'Else
        TabAnalyse.Visible = False
        TabChart.Visible = False
        TabControl1.SelectedTabPage = TabParameters
        'End If
    End Sub

End Class
