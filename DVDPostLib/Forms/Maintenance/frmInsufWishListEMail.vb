Imports System.Web.Mail
Imports System.Windows.Forms.Application

Public Class frmInsufWishListEMail
    Inherits BizzLib.frmBKForm

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
    Friend WithEvents txtTotalCustomers As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTotalCustomers As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnLoadInfo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnStart As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCustomersToProcess As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotCustToSend As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInfo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSuspend As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInsufWishListEMail))
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.txtTotalCustomers = New DevExpress.XtraEditors.TextEdit
        Me.lblTotalCustomers = New DevExpress.XtraEditors.LabelControl
        Me.btnLoadInfo = New DevExpress.XtraEditors.SimpleButton
        Me.btnStart = New DevExpress.XtraEditors.SimpleButton
        Me.txtCustomersToProcess = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtTotCustToSend = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtInfo = New DevExpress.XtraEditors.TextEdit
        Me.btnSuspend = New DevExpress.XtraEditors.SimpleButton
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCustomers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomersToProcess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotCustToSend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInfo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.QuickSearch_Bar.DockCol = 8
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
        'Main_Bar
        '
        Me.Main_Bar.DockCol = 4
        '
        'Filter_Bar
        '
        Me.Filter_Bar.DockCol = 7
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
        Me.DefaultSet_Bar.DockCol = 6
        '
        'View_Bar
        '
        Me.View_Bar.DockCol = 2
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
        Me.Misc_Bar2.DockCol = 3
        '
        'Misc_Bar
        '
        Me.Misc_Bar.DockCol = 5
        '
        'txtTotalCustomers
        '
        Me.txtTotalCustomers.Anchor = CType(resources.GetObject("txtTotalCustomers.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtTotalCustomers.BackgroundImage = CType(resources.GetObject("txtTotalCustomers.BackgroundImage"), System.Drawing.Image)
        Me.txtTotalCustomers.Dock = CType(resources.GetObject("txtTotalCustomers.Dock"), System.Windows.Forms.DockStyle)
        Me.txtTotalCustomers.EditValue = CType(resources.GetObject("txtTotalCustomers.EditValue"), Object)
        Me.txtTotalCustomers.Enabled = CType(resources.GetObject("txtTotalCustomers.Enabled"), Boolean)
        Me.txtTotalCustomers.ImeMode = CType(resources.GetObject("txtTotalCustomers.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtTotalCustomers.Location = CType(resources.GetObject("txtTotalCustomers.Location"), System.Drawing.Point)
        Me.txtTotalCustomers.Name = "txtTotalCustomers"
        '
        'txtTotalCustomers.Properties
        '
        Me.txtTotalCustomers.Properties.AccessibleDescription = resources.GetString("txtTotalCustomers.Properties.AccessibleDescription")
        Me.txtTotalCustomers.Properties.AccessibleName = resources.GetString("txtTotalCustomers.Properties.AccessibleName")
        Me.txtTotalCustomers.Properties.AutoHeight = CType(resources.GetObject("txtTotalCustomers.Properties.AutoHeight"), Boolean)
        Me.txtTotalCustomers.Properties.Mask.AutoComplete = CType(resources.GetObject("txtTotalCustomers.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtTotalCustomers.Properties.Mask.BeepOnError = CType(resources.GetObject("txtTotalCustomers.Properties.Mask.BeepOnError"), Boolean)
        Me.txtTotalCustomers.Properties.Mask.EditMask = resources.GetString("txtTotalCustomers.Properties.Mask.EditMask")
        Me.txtTotalCustomers.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtTotalCustomers.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtTotalCustomers.Properties.Mask.MaskType = CType(resources.GetObject("txtTotalCustomers.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtTotalCustomers.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtTotalCustomers.Properties.Mask.PlaceHolder"), Char)
        Me.txtTotalCustomers.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtTotalCustomers.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtTotalCustomers.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtTotalCustomers.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtTotalCustomers.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtTotalCustomers.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtTotalCustomers.Properties.NullText = resources.GetString("txtTotalCustomers.Properties.NullText")
        Me.txtTotalCustomers.Properties.ReadOnly = True
        Me.txtTotalCustomers.RightToLeft = CType(resources.GetObject("txtTotalCustomers.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtTotalCustomers.Size = CType(resources.GetObject("txtTotalCustomers.Size"), System.Drawing.Size)
        Me.txtTotalCustomers.SuperTip = CType(resources.GetObject("txtTotalCustomers.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtTotalCustomers.TabIndex = CType(resources.GetObject("txtTotalCustomers.TabIndex"), Integer)
        Me.txtTotalCustomers.ToolTip = resources.GetString("txtTotalCustomers.ToolTip")
        Me.txtTotalCustomers.ToolTipIconType = CType(resources.GetObject("txtTotalCustomers.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtTotalCustomers.ToolTipTitle = resources.GetString("txtTotalCustomers.ToolTipTitle")
        Me.txtTotalCustomers.Visible = CType(resources.GetObject("txtTotalCustomers.Visible"), Boolean)
        '
        'lblTotalCustomers
        '
        Me.lblTotalCustomers.AccessibleDescription = resources.GetString("lblTotalCustomers.AccessibleDescription")
        Me.lblTotalCustomers.AccessibleName = resources.GetString("lblTotalCustomers.AccessibleName")
        Me.lblTotalCustomers.Anchor = CType(resources.GetObject("lblTotalCustomers.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblTotalCustomers.AutoSizeMode = CType(resources.GetObject("lblTotalCustomers.AutoSizeMode"), DevExpress.XtraEditors.LabelAutoSizeMode)
        Me.lblTotalCustomers.Dock = CType(resources.GetObject("lblTotalCustomers.Dock"), System.Windows.Forms.DockStyle)
        Me.lblTotalCustomers.Enabled = CType(resources.GetObject("lblTotalCustomers.Enabled"), Boolean)
        Me.lblTotalCustomers.ImeMode = CType(resources.GetObject("lblTotalCustomers.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblTotalCustomers.LineColor = CType(resources.GetObject("lblTotalCustomers.LineColor"), System.Drawing.Color)
        Me.lblTotalCustomers.Location = CType(resources.GetObject("lblTotalCustomers.Location"), System.Drawing.Point)
        Me.lblTotalCustomers.Name = "lblTotalCustomers"
        Me.lblTotalCustomers.Size = CType(resources.GetObject("lblTotalCustomers.Size"), System.Drawing.Size)
        Me.lblTotalCustomers.SuperTip = CType(resources.GetObject("lblTotalCustomers.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.lblTotalCustomers.TabIndex = CType(resources.GetObject("lblTotalCustomers.TabIndex"), Integer)
        Me.lblTotalCustomers.Text = resources.GetString("lblTotalCustomers.Text")
        Me.lblTotalCustomers.ToolTip = resources.GetString("lblTotalCustomers.ToolTip")
        Me.lblTotalCustomers.ToolTipIconType = CType(resources.GetObject("lblTotalCustomers.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.lblTotalCustomers.ToolTipTitle = resources.GetString("lblTotalCustomers.ToolTipTitle")
        Me.lblTotalCustomers.Visible = CType(resources.GetObject("lblTotalCustomers.Visible"), Boolean)
        '
        'btnLoadInfo
        '
        Me.btnLoadInfo.AccessibleDescription = resources.GetString("btnLoadInfo.AccessibleDescription")
        Me.btnLoadInfo.AccessibleName = resources.GetString("btnLoadInfo.AccessibleName")
        Me.btnLoadInfo.Anchor = CType(resources.GetObject("btnLoadInfo.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnLoadInfo.BackgroundImage = CType(resources.GetObject("btnLoadInfo.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadInfo.Dock = CType(resources.GetObject("btnLoadInfo.Dock"), System.Windows.Forms.DockStyle)
        Me.btnLoadInfo.Enabled = CType(resources.GetObject("btnLoadInfo.Enabled"), Boolean)
        Me.btnLoadInfo.ImeMode = CType(resources.GetObject("btnLoadInfo.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnLoadInfo.Location = CType(resources.GetObject("btnLoadInfo.Location"), System.Drawing.Point)
        Me.btnLoadInfo.Name = "btnLoadInfo"
        Me.btnLoadInfo.RightToLeft = CType(resources.GetObject("btnLoadInfo.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnLoadInfo.Size = CType(resources.GetObject("btnLoadInfo.Size"), System.Drawing.Size)
        Me.btnLoadInfo.SuperTip = CType(resources.GetObject("btnLoadInfo.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.btnLoadInfo.TabIndex = CType(resources.GetObject("btnLoadInfo.TabIndex"), Integer)
        Me.btnLoadInfo.Text = resources.GetString("btnLoadInfo.Text")
        Me.btnLoadInfo.ToolTip = resources.GetString("btnLoadInfo.ToolTip")
        Me.btnLoadInfo.ToolTipIconType = CType(resources.GetObject("btnLoadInfo.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.btnLoadInfo.ToolTipTitle = resources.GetString("btnLoadInfo.ToolTipTitle")
        Me.btnLoadInfo.Visible = CType(resources.GetObject("btnLoadInfo.Visible"), Boolean)
        '
        'btnStart
        '
        Me.btnStart.AccessibleDescription = resources.GetString("btnStart.AccessibleDescription")
        Me.btnStart.AccessibleName = resources.GetString("btnStart.AccessibleName")
        Me.btnStart.Anchor = CType(resources.GetObject("btnStart.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnStart.BackgroundImage = CType(resources.GetObject("btnStart.BackgroundImage"), System.Drawing.Image)
        Me.btnStart.Dock = CType(resources.GetObject("btnStart.Dock"), System.Windows.Forms.DockStyle)
        Me.btnStart.Enabled = CType(resources.GetObject("btnStart.Enabled"), Boolean)
        Me.btnStart.ImeMode = CType(resources.GetObject("btnStart.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnStart.Location = CType(resources.GetObject("btnStart.Location"), System.Drawing.Point)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.RightToLeft = CType(resources.GetObject("btnStart.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnStart.Size = CType(resources.GetObject("btnStart.Size"), System.Drawing.Size)
        Me.btnStart.SuperTip = CType(resources.GetObject("btnStart.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.btnStart.TabIndex = CType(resources.GetObject("btnStart.TabIndex"), Integer)
        Me.btnStart.Text = resources.GetString("btnStart.Text")
        Me.btnStart.ToolTip = resources.GetString("btnStart.ToolTip")
        Me.btnStart.ToolTipIconType = CType(resources.GetObject("btnStart.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.btnStart.ToolTipTitle = resources.GetString("btnStart.ToolTipTitle")
        Me.btnStart.Visible = CType(resources.GetObject("btnStart.Visible"), Boolean)
        '
        'txtCustomersToProcess
        '
        Me.txtCustomersToProcess.Anchor = CType(resources.GetObject("txtCustomersToProcess.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtCustomersToProcess.BackgroundImage = CType(resources.GetObject("txtCustomersToProcess.BackgroundImage"), System.Drawing.Image)
        Me.txtCustomersToProcess.Dock = CType(resources.GetObject("txtCustomersToProcess.Dock"), System.Windows.Forms.DockStyle)
        Me.txtCustomersToProcess.EditValue = CType(resources.GetObject("txtCustomersToProcess.EditValue"), Object)
        Me.txtCustomersToProcess.Enabled = CType(resources.GetObject("txtCustomersToProcess.Enabled"), Boolean)
        Me.txtCustomersToProcess.ImeMode = CType(resources.GetObject("txtCustomersToProcess.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtCustomersToProcess.Location = CType(resources.GetObject("txtCustomersToProcess.Location"), System.Drawing.Point)
        Me.txtCustomersToProcess.Name = "txtCustomersToProcess"
        '
        'txtCustomersToProcess.Properties
        '
        Me.txtCustomersToProcess.Properties.AccessibleDescription = resources.GetString("txtCustomersToProcess.Properties.AccessibleDescription")
        Me.txtCustomersToProcess.Properties.AccessibleName = resources.GetString("txtCustomersToProcess.Properties.AccessibleName")
        Me.txtCustomersToProcess.Properties.AutoHeight = CType(resources.GetObject("txtCustomersToProcess.Properties.AutoHeight"), Boolean)
        Me.txtCustomersToProcess.Properties.Mask.AutoComplete = CType(resources.GetObject("txtCustomersToProcess.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtCustomersToProcess.Properties.Mask.BeepOnError = CType(resources.GetObject("txtCustomersToProcess.Properties.Mask.BeepOnError"), Boolean)
        Me.txtCustomersToProcess.Properties.Mask.EditMask = resources.GetString("txtCustomersToProcess.Properties.Mask.EditMask")
        Me.txtCustomersToProcess.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtCustomersToProcess.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtCustomersToProcess.Properties.Mask.MaskType = CType(resources.GetObject("txtCustomersToProcess.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtCustomersToProcess.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtCustomersToProcess.Properties.Mask.PlaceHolder"), Char)
        Me.txtCustomersToProcess.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtCustomersToProcess.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtCustomersToProcess.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtCustomersToProcess.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtCustomersToProcess.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtCustomersToProcess.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtCustomersToProcess.Properties.NullText = resources.GetString("txtCustomersToProcess.Properties.NullText")
        Me.txtCustomersToProcess.Properties.ReadOnly = True
        Me.txtCustomersToProcess.RightToLeft = CType(resources.GetObject("txtCustomersToProcess.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtCustomersToProcess.Size = CType(resources.GetObject("txtCustomersToProcess.Size"), System.Drawing.Size)
        Me.txtCustomersToProcess.SuperTip = CType(resources.GetObject("txtCustomersToProcess.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtCustomersToProcess.TabIndex = CType(resources.GetObject("txtCustomersToProcess.TabIndex"), Integer)
        Me.txtCustomersToProcess.ToolTip = resources.GetString("txtCustomersToProcess.ToolTip")
        Me.txtCustomersToProcess.ToolTipIconType = CType(resources.GetObject("txtCustomersToProcess.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtCustomersToProcess.ToolTipTitle = resources.GetString("txtCustomersToProcess.ToolTipTitle")
        Me.txtCustomersToProcess.Visible = CType(resources.GetObject("txtCustomersToProcess.Visible"), Boolean)
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
        Me.LabelControl1.Size = CType(resources.GetObject("LabelControl1.Size"), System.Drawing.Size)
        Me.LabelControl1.SuperTip = CType(resources.GetObject("LabelControl1.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.LabelControl1.TabIndex = CType(resources.GetObject("LabelControl1.TabIndex"), Integer)
        Me.LabelControl1.Text = resources.GetString("LabelControl1.Text")
        Me.LabelControl1.ToolTip = resources.GetString("LabelControl1.ToolTip")
        Me.LabelControl1.ToolTipIconType = CType(resources.GetObject("LabelControl1.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.LabelControl1.ToolTipTitle = resources.GetString("LabelControl1.ToolTipTitle")
        Me.LabelControl1.Visible = CType(resources.GetObject("LabelControl1.Visible"), Boolean)
        '
        'txtTotCustToSend
        '
        Me.txtTotCustToSend.Anchor = CType(resources.GetObject("txtTotCustToSend.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtTotCustToSend.BackgroundImage = CType(resources.GetObject("txtTotCustToSend.BackgroundImage"), System.Drawing.Image)
        Me.txtTotCustToSend.Dock = CType(resources.GetObject("txtTotCustToSend.Dock"), System.Windows.Forms.DockStyle)
        Me.txtTotCustToSend.EditValue = CType(resources.GetObject("txtTotCustToSend.EditValue"), Object)
        Me.txtTotCustToSend.Enabled = CType(resources.GetObject("txtTotCustToSend.Enabled"), Boolean)
        Me.txtTotCustToSend.ImeMode = CType(resources.GetObject("txtTotCustToSend.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtTotCustToSend.Location = CType(resources.GetObject("txtTotCustToSend.Location"), System.Drawing.Point)
        Me.txtTotCustToSend.Name = "txtTotCustToSend"
        '
        'txtTotCustToSend.Properties
        '
        Me.txtTotCustToSend.Properties.AccessibleDescription = resources.GetString("txtTotCustToSend.Properties.AccessibleDescription")
        Me.txtTotCustToSend.Properties.AccessibleName = resources.GetString("txtTotCustToSend.Properties.AccessibleName")
        Me.txtTotCustToSend.Properties.AutoHeight = CType(resources.GetObject("txtTotCustToSend.Properties.AutoHeight"), Boolean)
        Me.txtTotCustToSend.Properties.Mask.AutoComplete = CType(resources.GetObject("txtTotCustToSend.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtTotCustToSend.Properties.Mask.BeepOnError = CType(resources.GetObject("txtTotCustToSend.Properties.Mask.BeepOnError"), Boolean)
        Me.txtTotCustToSend.Properties.Mask.EditMask = resources.GetString("txtTotCustToSend.Properties.Mask.EditMask")
        Me.txtTotCustToSend.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtTotCustToSend.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtTotCustToSend.Properties.Mask.MaskType = CType(resources.GetObject("txtTotCustToSend.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtTotCustToSend.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtTotCustToSend.Properties.Mask.PlaceHolder"), Char)
        Me.txtTotCustToSend.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtTotCustToSend.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtTotCustToSend.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtTotCustToSend.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtTotCustToSend.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtTotCustToSend.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtTotCustToSend.Properties.NullText = resources.GetString("txtTotCustToSend.Properties.NullText")
        Me.txtTotCustToSend.Properties.ReadOnly = True
        Me.txtTotCustToSend.RightToLeft = CType(resources.GetObject("txtTotCustToSend.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtTotCustToSend.Size = CType(resources.GetObject("txtTotCustToSend.Size"), System.Drawing.Size)
        Me.txtTotCustToSend.SuperTip = CType(resources.GetObject("txtTotCustToSend.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtTotCustToSend.TabIndex = CType(resources.GetObject("txtTotCustToSend.TabIndex"), Integer)
        Me.txtTotCustToSend.ToolTip = resources.GetString("txtTotCustToSend.ToolTip")
        Me.txtTotCustToSend.ToolTipIconType = CType(resources.GetObject("txtTotCustToSend.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtTotCustToSend.ToolTipTitle = resources.GetString("txtTotCustToSend.ToolTipTitle")
        Me.txtTotCustToSend.Visible = CType(resources.GetObject("txtTotCustToSend.Visible"), Boolean)
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
        Me.LabelControl2.Size = CType(resources.GetObject("LabelControl2.Size"), System.Drawing.Size)
        Me.LabelControl2.SuperTip = CType(resources.GetObject("LabelControl2.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.LabelControl2.TabIndex = CType(resources.GetObject("LabelControl2.TabIndex"), Integer)
        Me.LabelControl2.Text = resources.GetString("LabelControl2.Text")
        Me.LabelControl2.ToolTip = resources.GetString("LabelControl2.ToolTip")
        Me.LabelControl2.ToolTipIconType = CType(resources.GetObject("LabelControl2.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.LabelControl2.ToolTipTitle = resources.GetString("LabelControl2.ToolTipTitle")
        Me.LabelControl2.Visible = CType(resources.GetObject("LabelControl2.Visible"), Boolean)
        '
        'txtInfo
        '
        Me.txtInfo.Anchor = CType(resources.GetObject("txtInfo.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtInfo.BackgroundImage = CType(resources.GetObject("txtInfo.BackgroundImage"), System.Drawing.Image)
        Me.txtInfo.Dock = CType(resources.GetObject("txtInfo.Dock"), System.Windows.Forms.DockStyle)
        Me.txtInfo.EditValue = CType(resources.GetObject("txtInfo.EditValue"), Object)
        Me.txtInfo.Enabled = CType(resources.GetObject("txtInfo.Enabled"), Boolean)
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
        Me.txtInfo.Size = CType(resources.GetObject("txtInfo.Size"), System.Drawing.Size)
        Me.txtInfo.SuperTip = CType(resources.GetObject("txtInfo.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtInfo.TabIndex = CType(resources.GetObject("txtInfo.TabIndex"), Integer)
        Me.txtInfo.ToolTip = resources.GetString("txtInfo.ToolTip")
        Me.txtInfo.ToolTipIconType = CType(resources.GetObject("txtInfo.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtInfo.ToolTipTitle = resources.GetString("txtInfo.ToolTipTitle")
        Me.txtInfo.Visible = CType(resources.GetObject("txtInfo.Visible"), Boolean)
        '
        'btnSuspend
        '
        Me.btnSuspend.AccessibleDescription = resources.GetString("btnSuspend.AccessibleDescription")
        Me.btnSuspend.AccessibleName = resources.GetString("btnSuspend.AccessibleName")
        Me.btnSuspend.Anchor = CType(resources.GetObject("btnSuspend.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnSuspend.BackgroundImage = CType(resources.GetObject("btnSuspend.BackgroundImage"), System.Drawing.Image)
        Me.btnSuspend.Dock = CType(resources.GetObject("btnSuspend.Dock"), System.Windows.Forms.DockStyle)
        Me.btnSuspend.Enabled = CType(resources.GetObject("btnSuspend.Enabled"), Boolean)
        Me.btnSuspend.ImeMode = CType(resources.GetObject("btnSuspend.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnSuspend.Location = CType(resources.GetObject("btnSuspend.Location"), System.Drawing.Point)
        Me.btnSuspend.Name = "btnSuspend"
        Me.btnSuspend.RightToLeft = CType(resources.GetObject("btnSuspend.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnSuspend.Size = CType(resources.GetObject("btnSuspend.Size"), System.Drawing.Size)
        Me.btnSuspend.SuperTip = CType(resources.GetObject("btnSuspend.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.btnSuspend.TabIndex = CType(resources.GetObject("btnSuspend.TabIndex"), Integer)
        Me.btnSuspend.Text = resources.GetString("btnSuspend.Text")
        Me.btnSuspend.ToolTip = resources.GetString("btnSuspend.ToolTip")
        Me.btnSuspend.ToolTipIconType = CType(resources.GetObject("btnSuspend.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.btnSuspend.ToolTipTitle = resources.GetString("btnSuspend.ToolTipTitle")
        Me.btnSuspend.Visible = CType(resources.GetObject("btnSuspend.Visible"), Boolean)
        '
        'frmInsufWishListEMail
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.Add(Me.btnSuspend)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.txtTotCustToSend)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtCustomersToProcess)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnLoadInfo)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtTotalCustomers)
        Me.Controls.Add(Me.lblTotalCustomers)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmInsufWishListEMail"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.ToolTipController1.SetSuperTip(Me, CType(resources.GetObject("$this.SuperTip"), DevExpress.Utils.SuperToolTip))
        Me.Text = resources.GetString("$this.Text")
        Me.ToolTipController1.SetTitle(Me, resources.GetString("$this.Title"))
        Me.ToolTipController1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me, CType(resources.GetObject("$this.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
        Me.Controls.SetChildIndex(Me.lblTotalCustomers, 0)
        Me.Controls.SetChildIndex(Me.txtTotalCustomers, 0)
        Me.Controls.SetChildIndex(Me.btnStart, 0)
        Me.Controls.SetChildIndex(Me.btnLoadInfo, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.txtCustomersToProcess, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.txtTotCustToSend, 0)
        Me.Controls.SetChildIndex(Me.txtInfo, 0)
        Me.Controls.SetChildIndex(Me.btnSuspend, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCustomers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomersToProcess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotCustToSend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInfo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "
    Dim mvarsmtpserver As String = "" '"192.168.0.203"
    Dim mvarsite As String = "" '"www.dvdpost.be"
    Dim intmessages_id As Integer = 103 'WishList Insuffisante
    Dim SQLTxtCustomers, SQLTxtProducts, SQLTxtProductsToCategories As String
    Dim objDS As New dsCustomers
    Dim TableName As String = "customersViewProducts1"
    Dim ViewCustToSend As DataView
    Dim ViewProducts As DataView
    Dim ViewProductsByCategory As DataView
    Dim ViewMessage As DataView
    Dim lowerbound As Integer
    Dim upperbound As Integer
    Dim bolSuspend As Boolean = False

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objDS.Tables.Add("CustCategories")
        objDS.Tables.Add("products_to_categories")
        SQLTxtCustomers = "SELECT C.customers_id , customers_gender, customers_firstname ,customers_lastname , customers_email_address , " & _
                  " customers_abo , customers_abo_type, customers_abo_dvd_credit, customers_abo_dvd_norm, customers_abo_dvd_adult, " & _
                  " customers_abo_dvd_home_norm, customers_abo_dvd_home_adult " & _
          " , customers_next_abo_type, " & _
          " if (customers_abo_validityto = '0000-00-00', Null, customers_abo_validityto) as customers_abo_validityto,  " & _
          " if (customers_dob = '0000-00-00', Null, customers_dob) as customers_dob , " & _
          " CI.*, count(wl.wl_id) as wl_count " & _
          " FROM customers C " & _
          " LEFT JOIN customers_info CI on CI.customers_info_id = C.customers_id  " & _
          " LEFT JOIN wishlist wl on wl.customers_id = C.customers_id and wl.wishlist_type = 'DVD_NORM' " & _
          " WHERE C.customers_abo = 1   GROUP BY C.customers_id"
        'Select All Cust ---- Remove Customers_ID criteria and C.customers_id = 115503

        mvarsmtpserver = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM GeneralGlobalParameter WHERE SetUpCategory = 'Global' and Name = 'SMTPServer'")
        mvarsite = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM GeneralGlobalParameter WHERE SetUpCategory = 'Global' and Name = 'BESite'")
        BKGlobal.Cls1.FillDataSet(objDS.Tables("languages"), "SELECT * from languages ")

        SQLTxtProducts = " select p.products_id , count(pd.products_id) as cnt_dvd , " & _
        " pdesc_fr.products_image_big as image_fr, pdesc_fr.products_name as name_fr, " & _
        " pdesc_nl.products_image_big as image_nl, pdesc_nl.products_name as name_nl, " & _
        " pdesc_en.products_image_big as image_en, pdesc_en.products_name as name_en, '' as categories " & _
        " from products p " & _
        " left join products_dvd pd on pd.products_id = p.products_id " & _
        " left join products_description pdesc_fr on pdesc_fr.products_id = p.products_id and pdesc_fr.language_id = 1 " & _
        " left join products_description pdesc_nl on pdesc_nl.products_id = p.products_id and pdesc_nl.language_id = 2 " & _
        " left join products_description pdesc_en on pdesc_en.products_id = p.products_id and pdesc_en.language_id = 3 " & _
        " WHERE pd.products_dvd_status = 1 and pd.inout = 1 and p.products_status = 1 and p.products_type = 'DVD_NORM' " & _
        " group by pd.products_id "

        SQLTxtProductsToCategories = " SELECT * from Products_To_Categories "
    End Sub
    Private Sub btnLoadInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadInfo.Click
        btnLoadInfo.Enabled = False
        btnStart.Enabled = False
        txtInfo.Visible = True
        txtInfo.Text = "Loading Customers List"
        txtInfo.Refresh()
        'Load Customer List
        LoadCustomerList()
        'Load DVD in stock
        txtInfo.Text = "Loading Products List"
        txtInfo.Refresh()
        objDS.Tables("prod_instock_image_view1").Clear()
        BKGlobal.Cls1.FillDataSet(objDS.Tables("prod_instock_image_view1"), SQLTxtProducts)
        'Load Categories of products
        objDS.Tables("products_to_categories").Clear()
        BKGlobal.Cls1.FillDataSet(objDS.Tables("products_to_categories"), SQLTxtProductsToCategories)
        Dim _row As DataRow
        Dim _rowview As DataRowView
        Dim _View As DataView
        Dim _i As Integer = 1
        For Each _row In objDS.Tables("prod_instock_image_view1").Rows
            txtInfo.Text = "Findind Products Categories " & _i & " on " & objDS.Tables("prod_instock_image_view1").Rows.Count
            _View = New DataView(objDS.Tables("products_to_categories"), "products_id = " & _row.Item("products_id"), "", DataViewRowState.CurrentRows)
            For Each _rowview In _View
                _row.Item("categories") = _row.Item("categories") & _rowview.Item("categories_id") & "-"
            Next
            _i += 1
            DoEvents()
        Next
        ViewProducts = New DataView(objDS.Tables("prod_instock_image_view1"), "cnt_dvd >= 5", "", DataViewRowState.CurrentRows)
        lowerbound = 0
        upperbound = ViewProducts.Count - 1
        txtInfo.Text = "Ready to Start"
        'btnLoadInfo.Enabled = True
        btnStart.Enabled = True
    End Sub
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        btnStart.Enabled = False
        btnSuspend.Enabled = True
        btnLoadInfo.Enabled = False
        SendMails()
        btnSuspend.Enabled = False
        btnLoadInfo.Enabled = True
    End Sub

    Public Sub LoadCustomerList()
        If IsNothing(objDS.Tables(TableName)) Then
            objDS.Tables.Add(TableName)
        Else
            objDS.Tables(TableName).Clear()
        End If

        Try
            Cls1.FillDataSet(objDS.Tables(TableName), SQLTxtCustomers)
        Catch eFillDataSet As System.Exception
            Throw eFillDataSet
        End Try
        ViewCustToSend = New DataView(objDS.Tables(TableName), "wl_count < 20 ", "customers_id", DataViewRowState.CurrentRows)
        'ViewCustToSend = New DataView(objDS.Tables(TableName), "customers_id = 115503 ", "customers_id", DataViewRowState.CurrentRows)
        txtTotalCustomers.EditValue = objDS.Tables(TableName).Rows.Count
        txtTotCustToSend.EditValue = ViewCustToSend.Count
    End Sub
    Private Sub SendMails()
        'Sending E-Mails
        Dim strFrom As String = "dvdpost@dvdpost.be"
        Dim strTo As String
        Dim strSubject As String = ""
        Dim strMessage As String = ""
        Dim _custrow As DataRowView
        Dim _CustInfoRow As DataRow
        Dim _MailRow As DataRowView
        Dim _i, _j As Integer
        Dim intcustomers_language As Integer
        Dim sSQL2, sSQL3, sSQL4 As String
        Dim intmaxmailid As Integer
        Dim _actual_abo, _next_abo As clsCustomersInfo.clsCustomerABOInfo
        sSQL3 = "SELECT max(mail_messages_sent_history_id) as cc  FROM mail_messages_sent_history  "
        intmaxmailid = BKGlobal.ExecuteFindFieldValueINT("cc", sSQL3)
        intmessages_id = 103
        objDS.Tables("mail_messages").Clear()
        sSQL2 = "SELECT * FROM mail_messages WHERE mail_messages_id = '" & intmessages_id & "'"
        BKGlobal.Cls1.FillDataSet(objDS.Tables("mail_messages"), sSQL2)
        txtCustomersToProcess.EditValue = txtTotCustToSend.EditValue
        For Each _custrow In ViewCustToSend '_i = 0 To GridView1.RowCount - 1
            intcustomers_language = _custrow.Item("customers_language")
            _actual_abo = New clsCustomersInfo.clsCustomerABOInfo(SessionInfo, _custrow.Item("customers_abo_type"), intcustomers_language)
            _next_abo = New clsCustomersInfo.clsCustomerABOInfo(SessionInfo, GetNextAbo(_custrow.Item("customers_abo_type")), intcustomers_language)
            strTo = _custrow.Item("customers_email_address")
            ViewMessage = New DataView(objDS.Tables("mail_messages"), "language_id = '" & intcustomers_language & "'", "", DataViewRowState.CurrentRows)
            If ViewMessage.Count = 1 Then
                _MailRow = ViewMessage(0)
                'For Each _MailRow In objDS.Tables("mail_messages").Rows
                strSubject = _MailRow.Item("messages_subject")
                strMessage = _MailRow.Item("messages_html")
                'titre
                strMessage = Replace(strMessage, "$$$title$$$", _MailRow.Item("messages_title"))
                'customers_name
                strMessage = Replace(strMessage, "$$$customers_name$$$", _custrow.Item("customers_firstname") & " " & _custrow.Item("customers_lastname"))
                'site
                strMessage = Replace(strMessage, "$$$site$$$", "<a href='" & mvarsite & " '>" & mvarsite & "</a>")
                'today
                strMessage = Replace(strMessage, "$$$today$$$", Today())
                'mailid 
                strMessage = Replace(strMessage, "$$$mail_id$$$", intmaxmailid + 1)
                'customers_id
                strMessage = Replace(strMessage, "$$$customers_id$$$", _custrow.Item("customers_id"))
                'customers_abo_validityto
                strMessage = Replace(strMessage, "$$$next_reconduction_date$$$", _custrow.Item("customers_abo_validityto"))
                strMessage = Replace(strMessage, "$$$_customers_wishlist_count$$$", _custrow.Item("wl_count"))
                strMessage = Replace(strMessage, "$$$_customers_wishlist_count2$$$", 20 - _custrow.Item("wl_count"))

                strMessage = Replace(strMessage, "$$$actual_abo_name$$$", _actual_abo.ABO_Name)
                strMessage = Replace(strMessage, "$$$actual_abo_price$$$", _actual_abo.ABO_price)
                strMessage = Replace(strMessage, "$$$next_abo_name$$$", _next_abo.ABO_Name)
                strMessage = Replace(strMessage, "$$$next_abo_price$$$", _next_abo.ABO_price)
                strMessage = Replace(strMessage, "$$$next_abo_dvd_credit$$$", _next_abo.DVD_Credit)
                strMessage = Replace(strMessage, "$$$next_abo_dvd_at_home$$$", _next_abo.DVD_At_Home)
                Randomize()
                lowerbound = 0
                upperbound = ViewProducts.Count - 1

                For _i = 1 To 7
                    _j = CInt(Int((upperbound - lowerbound + 1) * Rnd() + lowerbound))
                    strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_id$$$", ViewProducts(_j).Item("products_id"))
                    Select Case intcustomers_language
                        Case 1 'FR
                            strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_image$$$", ViewProducts(_j).Item("image_fr"))
                            strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_name$$$", ViewProducts(_j).Item("name_fr"))
                        Case 2 'NL
                            strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_image$$$", ViewProducts(_j).Item("image_nl"))
                            strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_name$$$", ViewProducts(_j).Item("name_nl"))
                        Case 3 'EN
                            strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_image$$$", ViewProducts(_j).Item("image_en"))
                            strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_name$$$", ViewProducts(_j).Item("name_en"))
                    End Select
                Next
                'Finding 3 most view Categories by the customer
                objDS.Tables("CustCategories").Clear()
                sSQL4 = "Select count(ptc.categories_id) as cpt,ptc.categories_id from products_to_categories ptc " & _
                        " LEFT JOIN wishlist w ON ptc.products_id=w.product_id where w.customers_id= " & _custrow.Item("customers_id") & _
                        " group by ptc.categories_id  order by cpt DESC LIMIT 1"
                BKGlobal.Cls1.FillDataSet(objDS.Tables("CustCategories"), sSQL4)
                If objDS.Tables("CustCategories").Rows.Count = 1 Then
                    ViewProductsByCategory = New DataView(objDS.Tables("prod_instock_image_view1"), "categories like '%" & objDS.Tables("CustCategories").Rows(0).Item("categories_id") & "-%' and cnt_dvd >= 5", "", DataViewRowState.CurrentRows)
                Else
                    ViewProductsByCategory = New DataView(objDS.Tables("prod_instock_image_view1"), "cnt_dvd >= 5", "", DataViewRowState.CurrentRows)
                End If
                If ViewProductsByCategory.Count = 0 Then
                    ViewProductsByCategory = ViewProducts
                End If
                lowerbound = 0
                upperbound = ViewProductsByCategory.Count - 1

                For _i = 100 To 119
                    _j = CInt(Int((upperbound - lowerbound + 1) * Rnd() + lowerbound))
                    strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_id$$$", ViewProductsByCategory(_j).Item("products_id"))
                    Select Case intcustomers_language
                        Case 1 'FR
                            strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_image$$$", ViewProductsByCategory(_j).Item("image_fr"))
                            strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_name$$$", ViewProductsByCategory(_j).Item("name_fr"))
                        Case 2 'NL
                            strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_image$$$", ViewProductsByCategory(_j).Item("image_nl"))
                            strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_name$$$", ViewProductsByCategory(_j).Item("name_nl"))
                        Case 3 'EN
                            strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_image$$$", ViewProductsByCategory(_j).Item("image_en"))
                            strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_name$$$", ViewProductsByCategory(_j).Item("name_en"))
                    End Select
                Next
                strMessage = Replace(strMessage, "$$$count_dvds$$$", 20)
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
                         "', now(), '" & _custrow.Item("customers_id") & "', '" & intmessages_id & "', '" & _
                         intcustomers_language & "' ) "
                BKGlobal.Cls1.ExecuteNonQuery(sSQL3)
                intmaxmailid += 1
                'Next
            End If
            txtCustomersToProcess.EditValue -= 1
            txtCustomersToProcess.Refresh()
            DoEvents()
            Me.Refresh()
            If bolSuspend = True Then
                Dim _answ As MsgBoxResult
                _answ = MsgBox("Resume ?", MsgBoxStyle.YesNo, "")
                If _answ = MsgBoxResult.No Then Exit For
            End If
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

    Private Sub btnSuspend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuspend.Click
        bolSuspend = Not bolSuspend
    End Sub
End Class
