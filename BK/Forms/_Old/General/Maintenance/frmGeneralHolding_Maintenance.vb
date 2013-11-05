Imports BizzLib.clsGlobal.ObjectState

Public Class frmgeneralholding_Maintenance
    Inherits BizzLib.frmGeneral_Maintenance

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
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents objDs As BizzLib.dsGeneral
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblCurrCode As System.Windows.Forms.Label
    Friend WithEvents cmbCurrCode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmgeneralholding_Maintenance))
        Me.lblName = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblCurrCode = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.objDs = New BizzLib.dsGeneral
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbCurrCode = New DevExpress.XtraEditors.LookUpEdit
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.cmbCurrCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = CType(resources.GetObject("StatusBar1.Location"), System.Drawing.Point)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = CType(resources.GetObject("StatusBar1.Size"), System.Drawing.Size)
        '
        'PopMenuSave
        '
        '
        'PopMenuDelete
        '
        '
        'PopMenuEdit
        '
        '
        'PopMenuNew
        '
        '
        'PopMenuUndo
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
        'lblName
        '
        Me.lblName.AccessibleDescription = resources.GetString("lblName.AccessibleDescription")
        Me.lblName.AccessibleName = resources.GetString("lblName.AccessibleName")
        Me.lblName.Anchor = CType(resources.GetObject("lblName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = CType(resources.GetObject("lblName.AutoSize"), Boolean)
        Me.lblName.Dock = CType(resources.GetObject("lblName.Dock"), System.Windows.Forms.DockStyle)
        Me.lblName.Enabled = CType(resources.GetObject("lblName.Enabled"), Boolean)
        Me.lblName.Font = CType(resources.GetObject("lblName.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.lblName, resources.GetString("lblName.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblName, CType(resources.GetObject("lblName.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblName, resources.GetString("lblName.HelpString"))
        Me.lblName.Image = CType(resources.GetObject("lblName.Image"), System.Drawing.Image)
        Me.lblName.ImageAlign = CType(resources.GetObject("lblName.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblName.ImageIndex = CType(resources.GetObject("lblName.ImageIndex"), Integer)
        Me.lblName.ImeMode = CType(resources.GetObject("lblName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblName.Location = CType(resources.GetObject("lblName.Location"), System.Drawing.Point)
        Me.lblName.Name = "lblName"
        Me.lblName.RightToLeft = CType(resources.GetObject("lblName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.lblName, CType(resources.GetObject("lblName.ShowHelp"), Boolean))
        Me.lblName.Size = CType(resources.GetObject("lblName.Size"), System.Drawing.Size)
        Me.lblName.TabIndex = CType(resources.GetObject("lblName.TabIndex"), Integer)
        Me.lblName.Text = resources.GetString("lblName.Text")
        Me.lblName.TextAlign = CType(resources.GetObject("lblName.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTip1.SetToolTip(Me.lblName, resources.GetString("lblName.ToolTip"))
        Me.lblName.Visible = CType(resources.GetObject("lblName.Visible"), Boolean)
        '
        'lblDescription
        '
        Me.lblDescription.AccessibleDescription = resources.GetString("lblDescription.AccessibleDescription")
        Me.lblDescription.AccessibleName = resources.GetString("lblDescription.AccessibleName")
        Me.lblDescription.Anchor = CType(resources.GetObject("lblDescription.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblDescription.AutoSize = CType(resources.GetObject("lblDescription.AutoSize"), Boolean)
        Me.lblDescription.Dock = CType(resources.GetObject("lblDescription.Dock"), System.Windows.Forms.DockStyle)
        Me.lblDescription.Enabled = CType(resources.GetObject("lblDescription.Enabled"), Boolean)
        Me.lblDescription.Font = CType(resources.GetObject("lblDescription.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.lblDescription, resources.GetString("lblDescription.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblDescription, CType(resources.GetObject("lblDescription.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblDescription, resources.GetString("lblDescription.HelpString"))
        Me.lblDescription.Image = CType(resources.GetObject("lblDescription.Image"), System.Drawing.Image)
        Me.lblDescription.ImageAlign = CType(resources.GetObject("lblDescription.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblDescription.ImageIndex = CType(resources.GetObject("lblDescription.ImageIndex"), Integer)
        Me.lblDescription.ImeMode = CType(resources.GetObject("lblDescription.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblDescription.Location = CType(resources.GetObject("lblDescription.Location"), System.Drawing.Point)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = CType(resources.GetObject("lblDescription.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.lblDescription, CType(resources.GetObject("lblDescription.ShowHelp"), Boolean))
        Me.lblDescription.Size = CType(resources.GetObject("lblDescription.Size"), System.Drawing.Size)
        Me.lblDescription.TabIndex = CType(resources.GetObject("lblDescription.TabIndex"), Integer)
        Me.lblDescription.Text = resources.GetString("lblDescription.Text")
        Me.lblDescription.TextAlign = CType(resources.GetObject("lblDescription.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTip1.SetToolTip(Me.lblDescription, resources.GetString("lblDescription.ToolTip"))
        Me.lblDescription.Visible = CType(resources.GetObject("lblDescription.Visible"), Boolean)
        '
        'lblCurrCode
        '
        Me.lblCurrCode.AccessibleDescription = resources.GetString("lblCurrCode.AccessibleDescription")
        Me.lblCurrCode.AccessibleName = resources.GetString("lblCurrCode.AccessibleName")
        Me.lblCurrCode.Anchor = CType(resources.GetObject("lblCurrCode.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblCurrCode.AutoSize = CType(resources.GetObject("lblCurrCode.AutoSize"), Boolean)
        Me.lblCurrCode.Dock = CType(resources.GetObject("lblCurrCode.Dock"), System.Windows.Forms.DockStyle)
        Me.lblCurrCode.Enabled = CType(resources.GetObject("lblCurrCode.Enabled"), Boolean)
        Me.lblCurrCode.Font = CType(resources.GetObject("lblCurrCode.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.lblCurrCode, resources.GetString("lblCurrCode.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblCurrCode, CType(resources.GetObject("lblCurrCode.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblCurrCode, resources.GetString("lblCurrCode.HelpString"))
        Me.lblCurrCode.Image = CType(resources.GetObject("lblCurrCode.Image"), System.Drawing.Image)
        Me.lblCurrCode.ImageAlign = CType(resources.GetObject("lblCurrCode.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblCurrCode.ImageIndex = CType(resources.GetObject("lblCurrCode.ImageIndex"), Integer)
        Me.lblCurrCode.ImeMode = CType(resources.GetObject("lblCurrCode.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblCurrCode.Location = CType(resources.GetObject("lblCurrCode.Location"), System.Drawing.Point)
        Me.lblCurrCode.Name = "lblCurrCode"
        Me.lblCurrCode.RightToLeft = CType(resources.GetObject("lblCurrCode.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.lblCurrCode, CType(resources.GetObject("lblCurrCode.ShowHelp"), Boolean))
        Me.lblCurrCode.Size = CType(resources.GetObject("lblCurrCode.Size"), System.Drawing.Size)
        Me.lblCurrCode.TabIndex = CType(resources.GetObject("lblCurrCode.TabIndex"), Integer)
        Me.lblCurrCode.Text = resources.GetString("lblCurrCode.Text")
        Me.lblCurrCode.TextAlign = CType(resources.GetObject("lblCurrCode.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTip1.SetToolTip(Me.lblCurrCode, resources.GetString("lblCurrCode.ToolTip"))
        Me.lblCurrCode.Visible = CType(resources.GetObject("lblCurrCode.Visible"), Boolean)
        '
        'txtName
        '
        Me.txtName.AccessibleDescription = resources.GetString("txtName.AccessibleDescription")
        Me.txtName.AccessibleName = resources.GetString("txtName.AccessibleName")
        Me.txtName.Anchor = CType(resources.GetObject("txtName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtName.AutoSize = CType(resources.GetObject("txtName.AutoSize"), Boolean)
        Me.txtName.BackgroundImage = CType(resources.GetObject("txtName.BackgroundImage"), System.Drawing.Image)
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDs, "generalholding.Name"))
        Me.txtName.Dock = CType(resources.GetObject("txtName.Dock"), System.Windows.Forms.DockStyle)
        Me.txtName.Enabled = CType(resources.GetObject("txtName.Enabled"), Boolean)
        Me.txtName.Font = CType(resources.GetObject("txtName.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.txtName, resources.GetString("txtName.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtName, CType(resources.GetObject("txtName.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtName, resources.GetString("txtName.HelpString"))
        Me.txtName.ImeMode = CType(resources.GetObject("txtName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtName.Location = CType(resources.GetObject("txtName.Location"), System.Drawing.Point)
        Me.txtName.MaxLength = CType(resources.GetObject("txtName.MaxLength"), Integer)
        Me.txtName.Multiline = CType(resources.GetObject("txtName.Multiline"), Boolean)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = CType(resources.GetObject("txtName.PasswordChar"), Char)
        Me.txtName.RightToLeft = CType(resources.GetObject("txtName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtName.ScrollBars = CType(resources.GetObject("txtName.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.HelpProvider1.SetShowHelp(Me.txtName, CType(resources.GetObject("txtName.ShowHelp"), Boolean))
        Me.txtName.Size = CType(resources.GetObject("txtName.Size"), System.Drawing.Size)
        Me.txtName.TabIndex = CType(resources.GetObject("txtName.TabIndex"), Integer)
        Me.txtName.Text = resources.GetString("txtName.Text")
        Me.txtName.TextAlign = CType(resources.GetObject("txtName.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip1.SetToolTip(Me.txtName, resources.GetString("txtName.ToolTip"))
        Me.txtName.Visible = CType(resources.GetObject("txtName.Visible"), Boolean)
        Me.txtName.WordWrap = CType(resources.GetObject("txtName.WordWrap"), Boolean)
        '
        'objDs
        '
        Me.objDs.DataSetName = "dsGeneral"
        Me.objDs.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'txtDescription
        '
        Me.txtDescription.AccessibleDescription = resources.GetString("txtDescription.AccessibleDescription")
        Me.txtDescription.AccessibleName = resources.GetString("txtDescription.AccessibleName")
        Me.txtDescription.Anchor = CType(resources.GetObject("txtDescription.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.AutoSize = CType(resources.GetObject("txtDescription.AutoSize"), Boolean)
        Me.txtDescription.BackgroundImage = CType(resources.GetObject("txtDescription.BackgroundImage"), System.Drawing.Image)
        Me.txtDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDs, "generalholding.Description"))
        Me.txtDescription.Dock = CType(resources.GetObject("txtDescription.Dock"), System.Windows.Forms.DockStyle)
        Me.txtDescription.Enabled = CType(resources.GetObject("txtDescription.Enabled"), Boolean)
        Me.txtDescription.Font = CType(resources.GetObject("txtDescription.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.txtDescription, resources.GetString("txtDescription.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtDescription, CType(resources.GetObject("txtDescription.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtDescription, resources.GetString("txtDescription.HelpString"))
        Me.txtDescription.ImeMode = CType(resources.GetObject("txtDescription.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtDescription.Location = CType(resources.GetObject("txtDescription.Location"), System.Drawing.Point)
        Me.txtDescription.MaxLength = CType(resources.GetObject("txtDescription.MaxLength"), Integer)
        Me.txtDescription.Multiline = CType(resources.GetObject("txtDescription.Multiline"), Boolean)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = CType(resources.GetObject("txtDescription.PasswordChar"), Char)
        Me.txtDescription.RightToLeft = CType(resources.GetObject("txtDescription.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtDescription.ScrollBars = CType(resources.GetObject("txtDescription.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.HelpProvider1.SetShowHelp(Me.txtDescription, CType(resources.GetObject("txtDescription.ShowHelp"), Boolean))
        Me.txtDescription.Size = CType(resources.GetObject("txtDescription.Size"), System.Drawing.Size)
        Me.txtDescription.TabIndex = CType(resources.GetObject("txtDescription.TabIndex"), Integer)
        Me.txtDescription.Text = resources.GetString("txtDescription.Text")
        Me.txtDescription.TextAlign = CType(resources.GetObject("txtDescription.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip1.SetToolTip(Me.txtDescription, resources.GetString("txtDescription.ToolTip"))
        Me.txtDescription.Visible = CType(resources.GetObject("txtDescription.Visible"), Boolean)
        Me.txtDescription.WordWrap = CType(resources.GetObject("txtDescription.WordWrap"), Boolean)
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = resources.GetString("Panel1.AccessibleDescription")
        Me.Panel1.AccessibleName = resources.GetString("Panel1.AccessibleName")
        Me.Panel1.Anchor = CType(resources.GetObject("Panel1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = CType(resources.GetObject("Panel1.AutoScroll"), Boolean)
        Me.Panel1.AutoScrollMargin = CType(resources.GetObject("Panel1.AutoScrollMargin"), System.Drawing.Size)
        Me.Panel1.AutoScrollMinSize = CType(resources.GetObject("Panel1.AutoScrollMinSize"), System.Drawing.Size)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.cmbCurrCode)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.txtDescription)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.lblDescription)
        Me.Panel1.Controls.Add(Me.lblCurrCode)
        Me.Panel1.Dock = CType(resources.GetObject("Panel1.Dock"), System.Windows.Forms.DockStyle)
        Me.Panel1.Enabled = CType(resources.GetObject("Panel1.Enabled"), Boolean)
        Me.Panel1.Font = CType(resources.GetObject("Panel1.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.Panel1, resources.GetString("Panel1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.Panel1, CType(resources.GetObject("Panel1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.Panel1, resources.GetString("Panel1.HelpString"))
        Me.Panel1.ImeMode = CType(resources.GetObject("Panel1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Panel1.Location = CType(resources.GetObject("Panel1.Location"), System.Drawing.Point)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = CType(resources.GetObject("Panel1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.Panel1, CType(resources.GetObject("Panel1.ShowHelp"), Boolean))
        Me.Panel1.Size = CType(resources.GetObject("Panel1.Size"), System.Drawing.Size)
        Me.Panel1.TabIndex = CType(resources.GetObject("Panel1.TabIndex"), Integer)
        Me.Panel1.Text = resources.GetString("Panel1.Text")
        Me.ToolTip1.SetToolTip(Me.Panel1, resources.GetString("Panel1.ToolTip"))
        Me.Panel1.Visible = CType(resources.GetObject("Panel1.Visible"), Boolean)
        '
        'cmbCurrCode
        '
        Me.cmbCurrCode.Anchor = CType(resources.GetObject("cmbCurrCode.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cmbCurrCode.BackgroundImage = CType(resources.GetObject("cmbCurrCode.BackgroundImage"), System.Drawing.Image)
        Me.cmbCurrCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDs, "generalholding.CurrCode"))
        Me.cmbCurrCode.Dock = CType(resources.GetObject("cmbCurrCode.Dock"), System.Windows.Forms.DockStyle)
        Me.cmbCurrCode.EditValue = CType(resources.GetObject("cmbCurrCode.EditValue"), Object)
        Me.cmbCurrCode.Enabled = CType(resources.GetObject("cmbCurrCode.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.cmbCurrCode, resources.GetString("cmbCurrCode.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.cmbCurrCode, CType(resources.GetObject("cmbCurrCode.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.cmbCurrCode, resources.GetString("cmbCurrCode.HelpString"))
        Me.cmbCurrCode.ImeMode = CType(resources.GetObject("cmbCurrCode.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cmbCurrCode.Location = CType(resources.GetObject("cmbCurrCode.Location"), System.Drawing.Point)
        Me.cmbCurrCode.Name = "cmbCurrCode"
        '
        'cmbCurrCode.Properties
        '
        Me.cmbCurrCode.Properties.AccessibleDescription = resources.GetString("cmbCurrCode.Properties.AccessibleDescription")
        Me.cmbCurrCode.Properties.AccessibleName = resources.GetString("cmbCurrCode.Properties.AccessibleName")
        Me.cmbCurrCode.Properties.AutoHeight = CType(resources.GetObject("cmbCurrCode.Properties.AutoHeight"), Boolean)
        Me.cmbCurrCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCurrCode.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrCode", "CurrCode", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbCurrCode.Properties.DataSource = Me.objDs.systemcurrency
        Me.cmbCurrCode.Properties.DisplayMember = "CurrCode"
        Me.cmbCurrCode.Properties.Mask.AutoComplete = CType(resources.GetObject("cmbCurrCode.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.cmbCurrCode.Properties.Mask.BeepOnError = CType(resources.GetObject("cmbCurrCode.Properties.Mask.BeepOnError"), Boolean)
        Me.cmbCurrCode.Properties.Mask.EditMask = resources.GetString("cmbCurrCode.Properties.Mask.EditMask")
        Me.cmbCurrCode.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("cmbCurrCode.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.cmbCurrCode.Properties.Mask.MaskType = CType(resources.GetObject("cmbCurrCode.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.cmbCurrCode.Properties.Mask.PlaceHolder = CType(resources.GetObject("cmbCurrCode.Properties.Mask.PlaceHolder"), Char)
        Me.cmbCurrCode.Properties.Mask.SaveLiteral = CType(resources.GetObject("cmbCurrCode.Properties.Mask.SaveLiteral"), Boolean)
        Me.cmbCurrCode.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("cmbCurrCode.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.cmbCurrCode.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("cmbCurrCode.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.cmbCurrCode.Properties.NullText = resources.GetString("cmbCurrCode.Properties.NullText")
        Me.cmbCurrCode.Properties.ValueMember = "CurrCode"
        Me.cmbCurrCode.RightToLeft = CType(resources.GetObject("cmbCurrCode.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.cmbCurrCode, CType(resources.GetObject("cmbCurrCode.ShowHelp"), Boolean))
        Me.cmbCurrCode.Size = CType(resources.GetObject("cmbCurrCode.Size"), System.Drawing.Size)
        Me.cmbCurrCode.TabIndex = CType(resources.GetObject("cmbCurrCode.TabIndex"), Integer)
        Me.cmbCurrCode.ToolTip = resources.GetString("cmbCurrCode.ToolTip")
        Me.ToolTip1.SetToolTip(Me.cmbCurrCode, resources.GetString("cmbCurrCode.ToolTip1"))
        Me.cmbCurrCode.ToolTipIconType = CType(resources.GetObject("cmbCurrCode.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.cmbCurrCode.ToolTipTitle = resources.GetString("cmbCurrCode.ToolTipTitle")
        Me.cmbCurrCode.Visible = CType(resources.GetObject("cmbCurrCode.Visible"), Boolean)
        '
        'frmgeneralholding_Maintenance
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.Add(Me.Panel1)
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
        Me.Name = "frmgeneralholding_Maintenance"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.cmbCurrCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim KeyDataSet As String = "BizzLib.dsGeneral" 'The Dataset used 
    Dim MainData As clsData_Holding

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'SetUp of Variables
            If KeyFieldName & "" = "" Then KeyFieldName = "Name"
            If IDField & "" = "" Then IDField = "HoldingID"
            If TableName = "" Then TableName = "generalholding"
            MainDataSet = objDs
            MyBase.RaiseEventForReportDesigner = True
            HelpProvider1.HelpNamespace = ".\Help\" & SessionInfo.UserLang & "\BizzKeys.chm"
            'MyBase.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
            'MyBase.HelpProvider1.SetHelpKeyword(Me, "Holding")
            'Attempt to load the dataset.
            Me.LoadBKComboSet()
            Me.LoadDataSet()
            BKGlobal.LoadAssociatedMenu(Me.Tag, PopMenuAssociatedTasks, Me)
            If OpenType = "NEW" Then
                NewRecord(sender, e)
            End If
            If OpenType = "EDIT" Then
                'Retreiving the GLAccount Code for the Associated ID
                '_Row = objDs.Tables(TableName).Rows.Find(New Object() {KeyID})
                If KeyValue <> "" Then 'Not IsNothing(_Row) Then
                    Me.objDs.Tables(TableName).DefaultView.Sort = IDField
                    Dim _Name As String = Me.objDs.Tables(TableName).DefaultView(Me.objDs.Tables(TableName).DefaultView.Find(New Object() {KeyValue}))(KeyFieldName)
                    'Now Finding the record by the name, because this is the one used in the ORDER BY in the LoadDataset
                    Me.objDs.Tables(TableName).DefaultView.Sort = KeyFieldName
                    Me.BindingContext(objDs, TableName).Position = Me.objDs.Tables(TableName).DefaultView.Find(New Object() {_Name})
                    PositionChanged(sender, e)
                    EditRecord(sender, e)
                Else
                    OpenType = "BROWSE"
                    Exit Sub
                End If
            End If
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        PositionChanged(sender, e)
    End Sub
    Private Sub frm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim _Answ As MsgBoxResult
        If OpenType = "EDIT" Or OpenType = "NEW" Then
            _Answ = MsgBox(BKGlobal.GetMsg(4, SessionInfo.UserLang), MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question)
            If _Answ = MsgBoxResult.Yes Then
                SaveChanges(sender, e)
            End If
            If _Answ = MsgBoxResult.No Then
                UndoChanges(sender, e)
            End If
            If _Answ = MsgBoxResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub NewRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuNew.Click, MyBase.EventNewRecord
        SetState(NewState)
        PopMenuNew.Enabled = False
        PopMenuEdit.Enabled = False
        PopMenuSave.Enabled = True
        PopMenuDelete.Enabled = False
        PopMenuUndo.Enabled = True
        EnablingAll(True)
        OpenType = "NEW"
        Try
            'Clear out the current edits
            Me.BindingContext(objDs, TableName).EndCurrentEdit()
            Me.BindingContext(objDs, TableName).AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        PositionChanged(Sender, e)
    End Sub
    Private Sub EditRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuEdit.Click, MyBase.EventEditRecord
        If Me.BindingContext(objDs, TableName).Position < 0 Then
            Exit Sub
        End If
        SetState(EditState)
        PopMenuNew.Enabled = False
        PopMenuEdit.Enabled = False
        PopMenuSave.Enabled = True
        PopMenuDelete.Enabled = False
        PopMenuUndo.Enabled = True
        EnablingForEdit()
        OpenType = "EDIT"
    End Sub
    Private Sub DeleteRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuDelete.Click, MyBase.EventDeleteRecord
        If Me.BindingContext(objDs, TableName).Position >= 0 Then
            'Msg = 1 = Confirm Delete
            If MsgBox(BKGlobal.GetMsg(1, SessionInfo.UserLang), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    BKGlobal.DeleteTranslations("GLAccountCode.GLAccountID", CType(Me.BindingContext(objDs, TableName).Current, DataRowView)(IDField) & "")
                    BKGlobal.DeleteComments(SessionInfo.EntityID, txtName.Text)
                    'Deleting the Holding 
                    MainData.Delete(CType(Me.BindingContext(objDs, TableName).Current, DataRowView)(IDField))
                    EnablingAll(False)
                    LoadDataSet()
                    PositionChanged(Sender, e)
                Catch ex As Exception
                    If ex.Source <> "##" Then
                        '7: Cannot Delete - Linked Tables exists
                        MsgBox(BKGlobal.GetMsg(7, SessionInfo.UserLang), MsgBoxStyle.Critical)
                    Else
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    End If
                    Exit Sub
                Finally
                    PositionChanged(Sender, e)
                End Try
            End If
        End If
    End Sub
    Private Sub UndoChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuUndo.Click, MyBase.EventUndoChanges
        SetState(BrowseState)
        PopMenuNew.Enabled = True
        PopMenuEdit.Enabled = True
        PopMenuSave.Enabled = False
        PopMenuDelete.Enabled = True
        PopMenuUndo.Enabled = False
        EnablingAll(False)
        Me.BindingContext(objDs, TableName).CancelCurrentEdit()
        PositionChanged(Sender, e)
        OpenType = "BROWSE"
    End Sub
    Private Sub SaveChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuSave.Click, MyBase.EventSaveChanges
        Try
            'Validate Fields and assign any Necessary ID
            MainData.ValidateRecordFields(CType(Me.BindingContext(objDs, TableName).Current, DataRowView))
            'Attempt to update the datasource.
            Me.UpdateDataSet()
            SetState(BrowseState)
            PopMenuNew.Enabled = True
            PopMenuEdit.Enabled = True
            PopMenuSave.Enabled = False
            PopMenuDelete.Enabled = True
            PopMenuUndo.Enabled = False
            EnablingAll(False)
            OpenType = "BROWSE"
        Catch eUpdate As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        Finally
        End Try
        PositionChanged(Sender, e)
    End Sub

    Public Sub UpdateDataSet() Handles MyBase.EventUpdateDataset
        'Stop any current edits.
        Me.BindingContext(objDs, TableName).EndCurrentEdit()
        'Me.BindingContext(objDs, "GeneralAddress").EndCurrentEdit()

        MainData.Save()
    End Sub
    Public Sub LoadDataSet() Handles MyBase.EventLoadDataset
        If IsFiltered Then
            MainData = New clsData_Holding(SessionInfo, objDs, KeyDataSet, TableName, " WHERE HoldingID <> 0 AND " & FilterTxt, "ORDER BY " & KeyFieldName)
        Else
            MainData = New clsData_Holding(SessionInfo, objDs, KeyDataSet, TableName, " WHERE HoldingID <> 0 ", "ORDER BY " & KeyFieldName)
        End If
        Me.objDs.Tables(TableName).DefaultView.Sort = "Name"
    End Sub
    Private Sub PositionChanged(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.EventPositionChanged
        If Me.BindingContext(objDs, TableName).Position >= 0 Then
            StatusBar1.Panels(0).Text = (((Me.BindingContext(objDs, TableName).Position + 1).ToString + " of  ") _
                        + Me.BindingContext(objDs, TableName).Count.ToString)
            ToolTip1.SetToolTip(StatusBar1, TableName & "-->" & IDField & "=" & CType(Me.BindingContext(objDs, TableName).Current, DataRowView)(IDField) & "")
            txtQuickSearch.EditValue = txtName.Text
        End If
    End Sub
    Private Sub EnablingEditFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingEditFields
        'ToBeChecked ***
        txtName.Enabled = Enabling
        txtDescription.Enabled = Enabling
        cmbCurrCode.Properties.Enabled = Enabling
    End Sub
    Private Sub EnablingKeyFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingkeyFields
        'ToBeChecked ***
    End Sub
    Private Sub StartPrintForm() Handles MyBase.EventPrintForm
        If Me.BindingContext(objDs, TableName).Position >= 0 Then
            'Find HoldingView1Row
            Dim _SQLTxt As String = "SELECT * FROM generalholdingView1 WHERE HoldingID = " & CType(Me.BindingContext(objDs, TableName).Current, DataRowView)("HoldingID")
            ' Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)
            objDs.Tables("generalholdingView1").Clear()
            DvdPostData.clsConnection.FillDataSet(objDs.Tables("generalholdingView1"), _SQLTxt)
            If objDs.Tables("generalholdingView1").Rows.Count = 1 Then
                BKReport.PrintForm(CurrentReportID, New DataRow() { _
                    objDs.Tables("generalholdingView1").Rows(0)})
            End If
        End If
        'PrintForm(CurrentReportID, New DataRow() {CType(Me.BindingContext(MainDataSet, TableName).Current, DataRowView).Row})
    End Sub
    Private Sub StartDesignReport() Handles MyBase.EventDesignReport
        If Me.BindingContext(objDs, TableName).Position >= 0 Then
            'Find EntityView1Row
            Dim _SQLTxt As String = "SELECT * FROM generalholdingView1 WHERE HoldingID = " & CType(Me.BindingContext(objDs, TableName).Current, DataRowView)("HoldingID")
            ' Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)
            objDs.Tables("generalholdingView1").Clear()
            DvdPostData.clsConnection.FillDataSet(objDs.Tables("generalholdingView1"), _SQLTxt)
            If objDs.Tables("generalholdingView1").Rows.Count = 1 Then
                BKReport.DesignReport(CurrentReportID, New DataRow() { _
                    objDs.Tables("generalholdingView1").Rows(0)})
            End If
        End If
    End Sub

    Public Sub LoadBKComboSet()
        Try
            BKCombo.GetCombo_Currency(objDs, "systemcurrency", "CurrCode")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
