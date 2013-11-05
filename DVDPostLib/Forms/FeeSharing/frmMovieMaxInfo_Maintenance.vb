Imports BizzLib.clsGlobal.ObjectState

Public Class frmMovieMaxInfo_Maintenance
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblProductID As System.Windows.Forms.Label
    Friend WithEvents lblTitleName As System.Windows.Forms.Label
    Friend WithEvents lblTitleNbr As System.Windows.Forms.Label
    Friend WithEvents lblStudio As System.Windows.Forms.Label
    Friend WithEvents objDS As DVDPostLib.dsFeeSharing
    Friend WithEvents lblOurTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbStudio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMovieMaxInfo_Maintenance))
        Me.lblProductID = New System.Windows.Forms.Label
        Me.lblTitleName = New System.Windows.Forms.Label
        Me.lblTitleNbr = New System.Windows.Forms.Label
        Me.objDS = New DVDPostLib.dsFeeSharing
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbStudio = New DevExpress.XtraEditors.LookUpEdit
        Me.txtID = New DevExpress.XtraEditors.TextEdit
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit
        Me.txtProductID = New DevExpress.XtraEditors.TextEdit
        Me.lblStudio = New System.Windows.Forms.Label
        Me.lblOurTitle = New DevExpress.XtraEditors.LabelControl
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.cmbStudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PopMenuNew
        '
        '
        'PopMenuEdit
        '
        '
        'PopMenuDelete
        '
        '
        'PopMenuSave
        '
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = CType(resources.GetObject("StatusBar1.Location"), System.Drawing.Point)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = CType(resources.GetObject("StatusBar1.Size"), System.Drawing.Size)
        '
        'PopMenuUndo
        '
        '
        'PrintSystem1
        '
        Me.PrintSystem1.ExportOptions.Xls.UseNativeFormat = True
        '
        'Misc_Bar
        '
        Me.Misc_Bar.DockCol = 5
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
        'Misc_Bar2
        '
        Me.Misc_Bar2.DockCol = 4
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
        'lblProductID
        '
        Me.lblProductID.AccessibleDescription = resources.GetString("lblProductID.AccessibleDescription")
        Me.lblProductID.AccessibleName = resources.GetString("lblProductID.AccessibleName")
        Me.lblProductID.Anchor = CType(resources.GetObject("lblProductID.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblProductID.AutoSize = CType(resources.GetObject("lblProductID.AutoSize"), Boolean)
        Me.lblProductID.Dock = CType(resources.GetObject("lblProductID.Dock"), System.Windows.Forms.DockStyle)
        Me.lblProductID.Enabled = CType(resources.GetObject("lblProductID.Enabled"), Boolean)
        Me.lblProductID.Font = CType(resources.GetObject("lblProductID.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.lblProductID, resources.GetString("lblProductID.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblProductID, CType(resources.GetObject("lblProductID.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblProductID, resources.GetString("lblProductID.HelpString"))
        Me.lblProductID.Image = CType(resources.GetObject("lblProductID.Image"), System.Drawing.Image)
        Me.lblProductID.ImageAlign = CType(resources.GetObject("lblProductID.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblProductID.ImageIndex = CType(resources.GetObject("lblProductID.ImageIndex"), Integer)
        Me.lblProductID.ImeMode = CType(resources.GetObject("lblProductID.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblProductID.Location = CType(resources.GetObject("lblProductID.Location"), System.Drawing.Point)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.RightToLeft = CType(resources.GetObject("lblProductID.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.lblProductID, CType(resources.GetObject("lblProductID.ShowHelp"), Boolean))
        Me.lblProductID.Size = CType(resources.GetObject("lblProductID.Size"), System.Drawing.Size)
        Me.lblProductID.TabIndex = CType(resources.GetObject("lblProductID.TabIndex"), Integer)
        Me.lblProductID.Text = resources.GetString("lblProductID.Text")
        Me.lblProductID.TextAlign = CType(resources.GetObject("lblProductID.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTip1.SetToolTip(Me.lblProductID, resources.GetString("lblProductID.ToolTip"))
        Me.lblProductID.Visible = CType(resources.GetObject("lblProductID.Visible"), Boolean)
        '
        'lblTitleName
        '
        Me.lblTitleName.AccessibleDescription = resources.GetString("lblTitleName.AccessibleDescription")
        Me.lblTitleName.AccessibleName = resources.GetString("lblTitleName.AccessibleName")
        Me.lblTitleName.Anchor = CType(resources.GetObject("lblTitleName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblTitleName.AutoSize = CType(resources.GetObject("lblTitleName.AutoSize"), Boolean)
        Me.lblTitleName.Dock = CType(resources.GetObject("lblTitleName.Dock"), System.Windows.Forms.DockStyle)
        Me.lblTitleName.Enabled = CType(resources.GetObject("lblTitleName.Enabled"), Boolean)
        Me.lblTitleName.Font = CType(resources.GetObject("lblTitleName.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.lblTitleName, resources.GetString("lblTitleName.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblTitleName, CType(resources.GetObject("lblTitleName.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblTitleName, resources.GetString("lblTitleName.HelpString"))
        Me.lblTitleName.Image = CType(resources.GetObject("lblTitleName.Image"), System.Drawing.Image)
        Me.lblTitleName.ImageAlign = CType(resources.GetObject("lblTitleName.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblTitleName.ImageIndex = CType(resources.GetObject("lblTitleName.ImageIndex"), Integer)
        Me.lblTitleName.ImeMode = CType(resources.GetObject("lblTitleName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblTitleName.Location = CType(resources.GetObject("lblTitleName.Location"), System.Drawing.Point)
        Me.lblTitleName.Name = "lblTitleName"
        Me.lblTitleName.RightToLeft = CType(resources.GetObject("lblTitleName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.lblTitleName, CType(resources.GetObject("lblTitleName.ShowHelp"), Boolean))
        Me.lblTitleName.Size = CType(resources.GetObject("lblTitleName.Size"), System.Drawing.Size)
        Me.lblTitleName.TabIndex = CType(resources.GetObject("lblTitleName.TabIndex"), Integer)
        Me.lblTitleName.Text = resources.GetString("lblTitleName.Text")
        Me.lblTitleName.TextAlign = CType(resources.GetObject("lblTitleName.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTip1.SetToolTip(Me.lblTitleName, resources.GetString("lblTitleName.ToolTip"))
        Me.lblTitleName.Visible = CType(resources.GetObject("lblTitleName.Visible"), Boolean)
        '
        'lblTitleNbr
        '
        Me.lblTitleNbr.AccessibleDescription = resources.GetString("lblTitleNbr.AccessibleDescription")
        Me.lblTitleNbr.AccessibleName = resources.GetString("lblTitleNbr.AccessibleName")
        Me.lblTitleNbr.Anchor = CType(resources.GetObject("lblTitleNbr.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblTitleNbr.AutoSize = CType(resources.GetObject("lblTitleNbr.AutoSize"), Boolean)
        Me.lblTitleNbr.Dock = CType(resources.GetObject("lblTitleNbr.Dock"), System.Windows.Forms.DockStyle)
        Me.lblTitleNbr.Enabled = CType(resources.GetObject("lblTitleNbr.Enabled"), Boolean)
        Me.lblTitleNbr.Font = CType(resources.GetObject("lblTitleNbr.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.lblTitleNbr, resources.GetString("lblTitleNbr.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblTitleNbr, CType(resources.GetObject("lblTitleNbr.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblTitleNbr, resources.GetString("lblTitleNbr.HelpString"))
        Me.lblTitleNbr.Image = CType(resources.GetObject("lblTitleNbr.Image"), System.Drawing.Image)
        Me.lblTitleNbr.ImageAlign = CType(resources.GetObject("lblTitleNbr.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblTitleNbr.ImageIndex = CType(resources.GetObject("lblTitleNbr.ImageIndex"), Integer)
        Me.lblTitleNbr.ImeMode = CType(resources.GetObject("lblTitleNbr.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblTitleNbr.Location = CType(resources.GetObject("lblTitleNbr.Location"), System.Drawing.Point)
        Me.lblTitleNbr.Name = "lblTitleNbr"
        Me.lblTitleNbr.RightToLeft = CType(resources.GetObject("lblTitleNbr.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.lblTitleNbr, CType(resources.GetObject("lblTitleNbr.ShowHelp"), Boolean))
        Me.lblTitleNbr.Size = CType(resources.GetObject("lblTitleNbr.Size"), System.Drawing.Size)
        Me.lblTitleNbr.TabIndex = CType(resources.GetObject("lblTitleNbr.TabIndex"), Integer)
        Me.lblTitleNbr.Text = resources.GetString("lblTitleNbr.Text")
        Me.lblTitleNbr.TextAlign = CType(resources.GetObject("lblTitleNbr.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTip1.SetToolTip(Me.lblTitleNbr, resources.GetString("lblTitleNbr.ToolTip"))
        Me.lblTitleNbr.Visible = CType(resources.GetObject("lblTitleNbr.Visible"), Boolean)
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsFeeSharing"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
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
        Me.Panel1.Controls.Add(Me.cmbStudio)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.txtTitle)
        Me.Panel1.Controls.Add(Me.txtProductID)
        Me.Panel1.Controls.Add(Me.lblStudio)
        Me.Panel1.Controls.Add(Me.lblOurTitle)
        Me.Panel1.Controls.Add(Me.lblProductID)
        Me.Panel1.Controls.Add(Me.lblTitleName)
        Me.Panel1.Controls.Add(Me.lblTitleNbr)
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
        'cmbStudio
        '
        Me.cmbStudio.Anchor = CType(resources.GetObject("cmbStudio.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cmbStudio.BackgroundImage = CType(resources.GetObject("cmbStudio.BackgroundImage"), System.Drawing.Image)
        Me.cmbStudio.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "feesharing_moviemax_input.maatschappij"))
        Me.cmbStudio.Dock = CType(resources.GetObject("cmbStudio.Dock"), System.Windows.Forms.DockStyle)
        Me.cmbStudio.EditValue = CType(resources.GetObject("cmbStudio.EditValue"), Object)
        Me.cmbStudio.Enabled = CType(resources.GetObject("cmbStudio.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.cmbStudio, resources.GetString("cmbStudio.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.cmbStudio, CType(resources.GetObject("cmbStudio.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.cmbStudio, resources.GetString("cmbStudio.HelpString"))
        Me.cmbStudio.ImeMode = CType(resources.GetObject("cmbStudio.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cmbStudio.Location = CType(resources.GetObject("cmbStudio.Location"), System.Drawing.Point)
        Me.cmbStudio.Name = "cmbStudio"
        '
        'cmbStudio.Properties
        '
        Me.cmbStudio.Properties.AccessibleDescription = resources.GetString("cmbStudio.Properties.AccessibleDescription")
        Me.cmbStudio.Properties.AccessibleName = resources.GetString("cmbStudio.Properties.AccessibleName")
        Me.cmbStudio.Properties.AutoHeight = CType(resources.GetObject("cmbStudio.Properties.AutoHeight"), Boolean)
        Me.cmbStudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStudio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 27, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("leverancier", "leverancier", 59, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("percentage", "percentage", 61, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbStudio.Properties.DataSource = Me.objDS.feesharing_moviemax_leverancier
        Me.cmbStudio.Properties.DisplayMember = "leverancier"
        Me.cmbStudio.Properties.Mask.AutoComplete = CType(resources.GetObject("cmbStudio.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.cmbStudio.Properties.Mask.BeepOnError = CType(resources.GetObject("cmbStudio.Properties.Mask.BeepOnError"), Boolean)
        Me.cmbStudio.Properties.Mask.EditMask = resources.GetString("cmbStudio.Properties.Mask.EditMask")
        Me.cmbStudio.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("cmbStudio.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.cmbStudio.Properties.Mask.MaskType = CType(resources.GetObject("cmbStudio.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.cmbStudio.Properties.Mask.PlaceHolder = CType(resources.GetObject("cmbStudio.Properties.Mask.PlaceHolder"), Char)
        Me.cmbStudio.Properties.Mask.SaveLiteral = CType(resources.GetObject("cmbStudio.Properties.Mask.SaveLiteral"), Boolean)
        Me.cmbStudio.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("cmbStudio.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.cmbStudio.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("cmbStudio.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.cmbStudio.Properties.NullText = resources.GetString("cmbStudio.Properties.NullText")
        Me.cmbStudio.Properties.ValueMember = "id"
        Me.cmbStudio.RightToLeft = CType(resources.GetObject("cmbStudio.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.cmbStudio, CType(resources.GetObject("cmbStudio.ShowHelp"), Boolean))
        Me.cmbStudio.Size = CType(resources.GetObject("cmbStudio.Size"), System.Drawing.Size)
        Me.cmbStudio.SuperTip = CType(resources.GetObject("cmbStudio.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.cmbStudio.TabIndex = CType(resources.GetObject("cmbStudio.TabIndex"), Integer)
        Me.ToolTip1.SetToolTip(Me.cmbStudio, resources.GetString("cmbStudio.ToolTip"))
        Me.cmbStudio.ToolTip = resources.GetString("cmbStudio.ToolTip1")
        Me.cmbStudio.ToolTipIconType = CType(resources.GetObject("cmbStudio.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.cmbStudio.ToolTipTitle = resources.GetString("cmbStudio.ToolTipTitle")
        Me.cmbStudio.Visible = CType(resources.GetObject("cmbStudio.Visible"), Boolean)
        '
        'txtID
        '
        Me.txtID.Anchor = CType(resources.GetObject("txtID.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtID.BackgroundImage = CType(resources.GetObject("txtID.BackgroundImage"), System.Drawing.Image)
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "feesharing_moviemax_input.titelnr"))
        Me.txtID.Dock = CType(resources.GetObject("txtID.Dock"), System.Windows.Forms.DockStyle)
        Me.txtID.EditValue = CType(resources.GetObject("txtID.EditValue"), Object)
        Me.txtID.Enabled = CType(resources.GetObject("txtID.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.txtID, resources.GetString("txtID.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtID, CType(resources.GetObject("txtID.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtID, resources.GetString("txtID.HelpString"))
        Me.txtID.ImeMode = CType(resources.GetObject("txtID.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtID.Location = CType(resources.GetObject("txtID.Location"), System.Drawing.Point)
        Me.txtID.Name = "txtID"
        '
        'txtID.Properties
        '
        Me.txtID.Properties.AccessibleDescription = resources.GetString("txtID.Properties.AccessibleDescription")
        Me.txtID.Properties.AccessibleName = resources.GetString("txtID.Properties.AccessibleName")
        Me.txtID.Properties.AutoHeight = CType(resources.GetObject("txtID.Properties.AutoHeight"), Boolean)
        Me.txtID.Properties.Mask.AutoComplete = CType(resources.GetObject("txtID.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtID.Properties.Mask.BeepOnError = CType(resources.GetObject("txtID.Properties.Mask.BeepOnError"), Boolean)
        Me.txtID.Properties.Mask.EditMask = resources.GetString("txtID.Properties.Mask.EditMask")
        Me.txtID.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtID.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtID.Properties.Mask.MaskType = CType(resources.GetObject("txtID.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtID.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtID.Properties.Mask.PlaceHolder"), Char)
        Me.txtID.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtID.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtID.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtID.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtID.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtID.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtID.Properties.NullText = resources.GetString("txtID.Properties.NullText")
        Me.txtID.RightToLeft = CType(resources.GetObject("txtID.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.txtID, CType(resources.GetObject("txtID.ShowHelp"), Boolean))
        Me.txtID.Size = CType(resources.GetObject("txtID.Size"), System.Drawing.Size)
        Me.txtID.SuperTip = CType(resources.GetObject("txtID.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtID.TabIndex = CType(resources.GetObject("txtID.TabIndex"), Integer)
        Me.txtID.ToolTip = resources.GetString("txtID.ToolTip")
        Me.ToolTip1.SetToolTip(Me.txtID, resources.GetString("txtID.ToolTip1"))
        Me.txtID.ToolTipIconType = CType(resources.GetObject("txtID.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtID.ToolTipTitle = resources.GetString("txtID.ToolTipTitle")
        Me.txtID.Visible = CType(resources.GetObject("txtID.Visible"), Boolean)
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = CType(resources.GetObject("txtTitle.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtTitle.BackgroundImage = CType(resources.GetObject("txtTitle.BackgroundImage"), System.Drawing.Image)
        Me.txtTitle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "feesharing_moviemax_input.title_name"))
        Me.txtTitle.Dock = CType(resources.GetObject("txtTitle.Dock"), System.Windows.Forms.DockStyle)
        Me.txtTitle.EditValue = CType(resources.GetObject("txtTitle.EditValue"), Object)
        Me.txtTitle.Enabled = CType(resources.GetObject("txtTitle.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.txtTitle, resources.GetString("txtTitle.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtTitle, CType(resources.GetObject("txtTitle.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtTitle, resources.GetString("txtTitle.HelpString"))
        Me.txtTitle.ImeMode = CType(resources.GetObject("txtTitle.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtTitle.Location = CType(resources.GetObject("txtTitle.Location"), System.Drawing.Point)
        Me.txtTitle.Name = "txtTitle"
        '
        'txtTitle.Properties
        '
        Me.txtTitle.Properties.AccessibleDescription = resources.GetString("txtTitle.Properties.AccessibleDescription")
        Me.txtTitle.Properties.AccessibleName = resources.GetString("txtTitle.Properties.AccessibleName")
        Me.txtTitle.Properties.AutoHeight = CType(resources.GetObject("txtTitle.Properties.AutoHeight"), Boolean)
        Me.txtTitle.Properties.Mask.AutoComplete = CType(resources.GetObject("txtTitle.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtTitle.Properties.Mask.BeepOnError = CType(resources.GetObject("txtTitle.Properties.Mask.BeepOnError"), Boolean)
        Me.txtTitle.Properties.Mask.EditMask = resources.GetString("txtTitle.Properties.Mask.EditMask")
        Me.txtTitle.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtTitle.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtTitle.Properties.Mask.MaskType = CType(resources.GetObject("txtTitle.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtTitle.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtTitle.Properties.Mask.PlaceHolder"), Char)
        Me.txtTitle.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtTitle.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtTitle.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtTitle.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtTitle.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtTitle.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtTitle.Properties.NullText = resources.GetString("txtTitle.Properties.NullText")
        Me.txtTitle.RightToLeft = CType(resources.GetObject("txtTitle.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.txtTitle, CType(resources.GetObject("txtTitle.ShowHelp"), Boolean))
        Me.txtTitle.Size = CType(resources.GetObject("txtTitle.Size"), System.Drawing.Size)
        Me.txtTitle.SuperTip = CType(resources.GetObject("txtTitle.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtTitle.TabIndex = CType(resources.GetObject("txtTitle.TabIndex"), Integer)
        Me.txtTitle.ToolTip = resources.GetString("txtTitle.ToolTip")
        Me.ToolTip1.SetToolTip(Me.txtTitle, resources.GetString("txtTitle.ToolTip1"))
        Me.txtTitle.ToolTipIconType = CType(resources.GetObject("txtTitle.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtTitle.ToolTipTitle = resources.GetString("txtTitle.ToolTipTitle")
        Me.txtTitle.Visible = CType(resources.GetObject("txtTitle.Visible"), Boolean)
        '
        'txtProductID
        '
        Me.txtProductID.Anchor = CType(resources.GetObject("txtProductID.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtProductID.BackgroundImage = CType(resources.GetObject("txtProductID.BackgroundImage"), System.Drawing.Image)
        Me.txtProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "feesharing_moviemax_input.products_id"))
        Me.txtProductID.Dock = CType(resources.GetObject("txtProductID.Dock"), System.Windows.Forms.DockStyle)
        Me.txtProductID.EditValue = CType(resources.GetObject("txtProductID.EditValue"), Object)
        Me.txtProductID.Enabled = CType(resources.GetObject("txtProductID.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.txtProductID, resources.GetString("txtProductID.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.txtProductID, CType(resources.GetObject("txtProductID.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.txtProductID, resources.GetString("txtProductID.HelpString"))
        Me.txtProductID.ImeMode = CType(resources.GetObject("txtProductID.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtProductID.Location = CType(resources.GetObject("txtProductID.Location"), System.Drawing.Point)
        Me.txtProductID.Name = "txtProductID"
        '
        'txtProductID.Properties
        '
        Me.txtProductID.Properties.AccessibleDescription = resources.GetString("txtProductID.Properties.AccessibleDescription")
        Me.txtProductID.Properties.AccessibleName = resources.GetString("txtProductID.Properties.AccessibleName")
        Me.txtProductID.Properties.AutoHeight = CType(resources.GetObject("txtProductID.Properties.AutoHeight"), Boolean)
        Me.txtProductID.Properties.Mask.AutoComplete = CType(resources.GetObject("txtProductID.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtProductID.Properties.Mask.BeepOnError = CType(resources.GetObject("txtProductID.Properties.Mask.BeepOnError"), Boolean)
        Me.txtProductID.Properties.Mask.EditMask = resources.GetString("txtProductID.Properties.Mask.EditMask")
        Me.txtProductID.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtProductID.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtProductID.Properties.Mask.MaskType = CType(resources.GetObject("txtProductID.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtProductID.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtProductID.Properties.Mask.PlaceHolder"), Char)
        Me.txtProductID.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtProductID.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtProductID.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtProductID.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtProductID.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtProductID.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtProductID.Properties.NullText = resources.GetString("txtProductID.Properties.NullText")
        Me.txtProductID.RightToLeft = CType(resources.GetObject("txtProductID.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.txtProductID, CType(resources.GetObject("txtProductID.ShowHelp"), Boolean))
        Me.txtProductID.Size = CType(resources.GetObject("txtProductID.Size"), System.Drawing.Size)
        Me.txtProductID.SuperTip = CType(resources.GetObject("txtProductID.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.txtProductID.TabIndex = CType(resources.GetObject("txtProductID.TabIndex"), Integer)
        Me.txtProductID.ToolTip = resources.GetString("txtProductID.ToolTip")
        Me.ToolTip1.SetToolTip(Me.txtProductID, resources.GetString("txtProductID.ToolTip1"))
        Me.txtProductID.ToolTipIconType = CType(resources.GetObject("txtProductID.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.txtProductID.ToolTipTitle = resources.GetString("txtProductID.ToolTipTitle")
        Me.txtProductID.Visible = CType(resources.GetObject("txtProductID.Visible"), Boolean)
        '
        'lblStudio
        '
        Me.lblStudio.AccessibleDescription = resources.GetString("lblStudio.AccessibleDescription")
        Me.lblStudio.AccessibleName = resources.GetString("lblStudio.AccessibleName")
        Me.lblStudio.Anchor = CType(resources.GetObject("lblStudio.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblStudio.AutoSize = CType(resources.GetObject("lblStudio.AutoSize"), Boolean)
        Me.lblStudio.Dock = CType(resources.GetObject("lblStudio.Dock"), System.Windows.Forms.DockStyle)
        Me.lblStudio.Enabled = CType(resources.GetObject("lblStudio.Enabled"), Boolean)
        Me.lblStudio.Font = CType(resources.GetObject("lblStudio.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.lblStudio, resources.GetString("lblStudio.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblStudio, CType(resources.GetObject("lblStudio.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblStudio, resources.GetString("lblStudio.HelpString"))
        Me.lblStudio.Image = CType(resources.GetObject("lblStudio.Image"), System.Drawing.Image)
        Me.lblStudio.ImageAlign = CType(resources.GetObject("lblStudio.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblStudio.ImageIndex = CType(resources.GetObject("lblStudio.ImageIndex"), Integer)
        Me.lblStudio.ImeMode = CType(resources.GetObject("lblStudio.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblStudio.Location = CType(resources.GetObject("lblStudio.Location"), System.Drawing.Point)
        Me.lblStudio.Name = "lblStudio"
        Me.lblStudio.RightToLeft = CType(resources.GetObject("lblStudio.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.lblStudio, CType(resources.GetObject("lblStudio.ShowHelp"), Boolean))
        Me.lblStudio.Size = CType(resources.GetObject("lblStudio.Size"), System.Drawing.Size)
        Me.lblStudio.TabIndex = CType(resources.GetObject("lblStudio.TabIndex"), Integer)
        Me.lblStudio.Text = resources.GetString("lblStudio.Text")
        Me.lblStudio.TextAlign = CType(resources.GetObject("lblStudio.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTip1.SetToolTip(Me.lblStudio, resources.GetString("lblStudio.ToolTip"))
        Me.lblStudio.Visible = CType(resources.GetObject("lblStudio.Visible"), Boolean)
        '
        'lblOurTitle
        '
        Me.lblOurTitle.AccessibleDescription = resources.GetString("lblOurTitle.AccessibleDescription")
        Me.lblOurTitle.AccessibleName = resources.GetString("lblOurTitle.AccessibleName")
        Me.lblOurTitle.Anchor = CType(resources.GetObject("lblOurTitle.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblOurTitle.AutoSizeMode = CType(resources.GetObject("lblOurTitle.AutoSizeMode"), DevExpress.XtraEditors.LabelAutoSizeMode)
        Me.lblOurTitle.Dock = CType(resources.GetObject("lblOurTitle.Dock"), System.Windows.Forms.DockStyle)
        Me.lblOurTitle.Enabled = CType(resources.GetObject("lblOurTitle.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.lblOurTitle, resources.GetString("lblOurTitle.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblOurTitle, CType(resources.GetObject("lblOurTitle.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblOurTitle, resources.GetString("lblOurTitle.HelpString"))
        Me.lblOurTitle.ImeMode = CType(resources.GetObject("lblOurTitle.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblOurTitle.LineColor = CType(resources.GetObject("lblOurTitle.LineColor"), System.Drawing.Color)
        Me.lblOurTitle.Location = CType(resources.GetObject("lblOurTitle.Location"), System.Drawing.Point)
        Me.lblOurTitle.Name = "lblOurTitle"
        Me.HelpProvider1.SetShowHelp(Me.lblOurTitle, CType(resources.GetObject("lblOurTitle.ShowHelp"), Boolean))
        Me.lblOurTitle.Size = CType(resources.GetObject("lblOurTitle.Size"), System.Drawing.Size)
        Me.lblOurTitle.SuperTip = CType(resources.GetObject("lblOurTitle.SuperTip"), DevExpress.Utils.SuperToolTip)
        Me.lblOurTitle.TabIndex = CType(resources.GetObject("lblOurTitle.TabIndex"), Integer)
        Me.lblOurTitle.Text = resources.GetString("lblOurTitle.Text")
        Me.ToolTip1.SetToolTip(Me.lblOurTitle, resources.GetString("lblOurTitle.ToolTip"))
        Me.lblOurTitle.ToolTip = resources.GetString("lblOurTitle.ToolTip1")
        Me.lblOurTitle.ToolTipIconType = CType(resources.GetObject("lblOurTitle.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.lblOurTitle.ToolTipTitle = resources.GetString("lblOurTitle.ToolTipTitle")
        Me.lblOurTitle.Visible = CType(resources.GetObject("lblOurTitle.Visible"), Boolean)
        '
        'frmMovieMaxInfo_Maintenance
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
        Me.Name = "frmMovieMaxInfo_Maintenance"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.cmbStudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim KeyDataSet As String = "dsFeeSharing" 'The Dataset used 
    Dim MainData As clsMoviewmax_info

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'SetUp of Variables
            If KeyFieldName & "" = "" Then KeyFieldName = "title_name"
            If IDField & "" = "" Then IDField = "products_id"
            If TableName = "" Then TableName = "feesharing_moviemax_input"
            'objDS = New dsFeeSharing
            MainDataSet = objDS
            MyBase.RaiseEventForReportDesigner = True
            HelpProvider1.HelpNamespace = ".\Help\" & SessionInfo.UserLang & "\BizzKeys.chm"
            'MyBase.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
            'MyBase.HelpProvider1.SetHelpKeyword(Me, "Holding")
            'Attempt to load the dataset.
            Me.LoadBKComboSet()
            Me.LoadDataSet()
            'RefreshBindings()
            BKGlobal.LoadAssociatedMenu(Me.Tag, PopMenuAssociatedTasks, Me)
            If OpenType = "NEW" Then
                NewRecord(sender, e)
            End If
            If OpenType = "EDIT" Then
                'Retreiving the GLAccount Code for the Associated ID
                '_Row = objDs.Tables(TableName).Rows.Find(New Object() {KeyID})
                If KeyValue <> "" Then 'Not IsNothing(_Row) Then
                    Me.objDS.Tables(TableName).DefaultView.Sort = IDField
                    Dim _Name As String = Me.objDS.Tables(TableName).DefaultView(Me.objDS.Tables(TableName).DefaultView.Find(New Object() {KeyValue})).Item(KeyFieldName)
                    'Now Finding the record by the name, because this is the one used in the ORDER BY in the LoadDataset
                    Me.objDS.Tables(TableName).DefaultView.Sort = KeyFieldName
                    Me.BindingContext(objDS, TableName).Position = Me.objDS.Tables(TableName).DefaultView.Find(New Object() {_Name})
                    PositionChanged(sender, e)
                    EditRecord(sender, e)
                Else
                    OpenType = "BROWSE"
                    Exit Sub
                End If
            End If
        Catch eLoad As System.Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Feesharing, eLoad)
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
    Private Sub RefreshBindings()
        txtProductID.DataBindings.Clear()
        Me.txtProductID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS.Tables(TableName), "products_id"))
        txtID.DataBindings.Clear()
        txtID.DataBindings.Add("Text", objDS.Tables(TableName), "titelnr")
        txtTitle.DataBindings.Clear()
        txtTitle.DataBindings.Add("Text", objDS.Tables(TableName), "title_name")
        cmbStudio.DataBindings.Clear()
        cmbStudio.DataBindings.Add("EditValue", objDS.Tables(TableName), "maatschappij")


        'txtProductID.DataBindings("Text").BindingManagerBase.ResumeBinding()

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
            Me.BindingContext(objDS, TableName).EndCurrentEdit()
            Me.BindingContext(objDS, TableName).AddNew()
            txtID.EditValue = ""
            txtProductID.EditValue = ""
            txtTitle.EditValue = ""
            cmbStudio.EditValue = DBNull.Value
        Catch eEndEdit As System.Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Feesharing, eEndEdit)
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        PositionChanged(Sender, e)
    End Sub
    Private Sub EditRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuEdit.Click, MyBase.EventEditRecord
        If Me.BindingContext(objDS, TableName).Position < 0 Then
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
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            'Msg = 1 = Confirm Delete
            If MsgBox(BKGlobal.GetMsg(1, SessionInfo.UserLang), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    BKGlobal.DeleteTranslations("GLAccountCode.GLAccountID", CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item(IDField) & "")
                    BKGlobal.DeleteComments(SessionInfo.EntityID, txtProductID.Text)
                    'Deleting the Holding 
                    MainData.Delete(CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item(IDField))
                    EnablingAll(False)
                    LoadDataSet()
                    PositionChanged(Sender, e)
                Catch ex As Exception
                    DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Feesharing, ex)
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
        Me.BindingContext(objDS, TableName).CancelCurrentEdit()
        PositionChanged(Sender, e)
        OpenType = "BROWSE"
    End Sub
    Private Sub SaveChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuSave.Click, MyBase.EventSaveChanges

        Try
            'Validate Fields and assign any Necessary ID
            MainData.ValidateRecordFields(CType(Me.BindingContext(objDS, TableName).Current, DataRowView))
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
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Feesharing, eUpdate)
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        Finally
        End Try
        PositionChanged(Sender, e)
    End Sub

    Public Sub UpdateDataSet() Handles MyBase.EventUpdateDataset
        'Stop any current edits.
        Me.BindingContext(objDS, TableName).EndCurrentEdit()
        'Me.BindingContext(objDs, "GeneralAddress").EndCurrentEdit()

        MainData.Save()
    End Sub
    Public Sub LoadDataSet() Handles MyBase.EventLoadDataset
        If IsNothing(objDS.Tables(TableName)) Then
            Exit Sub
        End If
        If IsFiltered Then
            MainData = New clsMoviewmax_info(SessionInfo, objDS, KeyDataSet, TableName, FilterTxt, "ORDER BY " & KeyFieldName)
        Else
            MainData = New clsMoviewmax_info(SessionInfo, objDS, KeyDataSet, TableName, "", "ORDER BY " & KeyFieldName)
        End If
        Me.objDS.Tables(TableName).DefaultView.Sort = KeyFieldName
        'BKGlobal.Cls1.FillDataSet(objDS.Tables(TableName), "SELECT * FROM feesharing_moviemax_input ")
    End Sub
    Private Sub PositionChanged(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.EventPositionChanged
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            StatusBar1.Panels(0).Text = (((Me.BindingContext(objDS, TableName).Position + 1).ToString + " of  ") _
                        + Me.BindingContext(objDS, TableName).Count.ToString)
            ToolTip1.SetToolTip(StatusBar1, TableName & "-->" & IDField & "=" & CType(Me.BindingContext(objDS, TableName).Current, DataRowView).Item(IDField) & "")
            txtQuickSearch.EditValue = txtTitle.Text
        End If
    End Sub
    Private Sub EnablingEditFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingEditFields
        'ToBeChecked ***
        txtID.Enabled = Enabling
        txtTitle.Enabled = Enabling
        txtProductID.Enabled = Enabling
        cmbStudio.Enabled = Enabling
    End Sub
    Private Sub EnablingKeyFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingkeyFields
        'ToBeChecked ***
    End Sub
    Private Sub StartPrintForm() Handles MyBase.EventPrintForm
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            'Find HoldingView1Row
            Dim _SQLTxt As String = "SELECT feesharing_moviemax_input.products_id, feesharing_moviemax_input.title_name, feesharing_moviemax_input.titelnr, " & _
                      " feesharing_moviemax_input.maatschappij, feesharing_moviemax_leverancier.id, feesharing_moviemax_leverancier.leverancier, " & _
                      "feesharing_moviemax_leverancier.percentage" & _
                      " FROM         feesharing_moviemax_input LEFT OUTER JOIN " & _
                      " feesharing_moviemax_leverancier ON feesharing_moviemax_input.maatschappij = feesharing_moviemax_leverancier.id " & _
                      " WHERE Products_id = " & txtProductID.Text
            '"SELECT * FROM generalholdingView1 WHERE HoldingID = " & CType(Me.BindingContext(objDs, TableName).Current, DataRowView).Item("HoldingID")
            Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)
            objDS.Tables("MovieMax_Info_View1").Clear()
            _Cls1.FillDataSet(objDS.Tables("MovieMax_Info_View1"), _SQLTxt)
            If objDS.Tables("MovieMax_Info_View1").Rows.Count = 1 Then
                BKReport.PrintForm(CurrentReportID, New DataRow() { _
                    objDS.Tables("MovieMax_Info_View1").Rows(0)})
            End If
        End If
        'PrintForm(CurrentReportID, New DataRow() {CType(Me.BindingContext(MainDataSet, TableName).Current, DataRowView).Row})
    End Sub
    Private Sub StartDesignReport() Handles MyBase.EventDesignReport
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            'Find EntityView1Row
            Dim _SQLTxt As String = "SELECT feesharing_moviemax_input.products_id, feesharing_moviemax_input.title_name, feesharing_moviemax_input.titelnr, " & _
                      " feesharing_moviemax_input.maatschappij, feesharing_moviemax_leverancier.id, feesharing_moviemax_leverancier.leverancier, " & _
                      "feesharing_moviemax_leverancier.percentage" & _
                      " FROM         feesharing_moviemax_input LEFT OUTER JOIN " & _
                      " feesharing_moviemax_leverancier ON feesharing_moviemax_input.maatschappij = feesharing_moviemax_leverancier.id " & _
                      " WHERE Products_id = " & txtProductID.Text
            Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)
            objDS.Tables("MovieMax_Info_View1").Clear()
            _Cls1.FillDataSet(objDS.Tables("MovieMax_Info_View1"), _SQLTxt)
            If objDS.Tables("MovieMax_Info_View1").Rows.Count = 1 Then
                BKReport.DesignReport(CurrentReportID, New DataRow() { _
                    objDS.Tables("MovieMax_Info_View1").Rows(0)})
            End If
        End If
    End Sub
    Public Sub LoadBKComboSet()
        Try
            BKCombo.GetCombo(objDS, "feesharing_moviemax_leverancier", "leverancier", "SELECT * FROM feesharing_moviemax_leverancier")
            'BKCombo.GetCombo(objDS, "products", "products_title", "SELECT products_id, products_title, products_model FROM products WHERE products_id > 50")
        Catch ex As Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Feesharing, ex)
            Throw ex
        End Try
    End Sub
    Private Sub txtProductID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProductID.EditValueChanged
        'Searching for OUR Product Info
        Dim _DS As New dsFeeSharing
        Dim _SQLTxt As String = "SELECT * FROM products where products_id = " & txtProductID.Text
        _DS.Tables("Products").Clear()
        BKGlobal.Cls1.FillDataSet(_DS.Tables("Products"), _SQLTxt)
        If _DS.Tables("Products").Rows.Count = 1 Then
            lblOurTitle.Text = _DS.Tables("Products").Rows(0).Item("products_title")
        End If
    End Sub

End Class
