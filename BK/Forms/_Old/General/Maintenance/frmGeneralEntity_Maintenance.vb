Imports BizzLib.clsGlobal.ObjectState

Public Class frmgeneralentity_Maintenance
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents objDS As BizzLib.dsGeneral
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblcountry As System.Windows.Forms.Label
    Friend WithEvents lblZip_City As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtEMail As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents txtWebSite As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents lblWebSite As System.Windows.Forms.Label
    Friend WithEvents lblEMail As System.Windows.Forms.Label
    Friend WithEvents cmbcountry As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbHolding As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblHolding As System.Windows.Forms.Label
    Friend WithEvents txtFormIcon As System.Windows.Forms.TextBox
    Friend WithEvents lblFormIcon As System.Windows.Forms.Label
    Friend WithEvents cmbCurrCode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblCurrCode As System.Windows.Forms.Label
    Friend WithEvents cmbConsoEntityID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblConsoEntityID As System.Windows.Forms.Label
    Friend WithEvents PanelEntity As System.Windows.Forms.Panel
    Friend WithEvents lblSTCostType As System.Windows.Forms.Label
    Friend WithEvents ListView As System.Windows.Forms.TabPage
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colEntityID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCurrCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFormIcon As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colHoldingID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAddrID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colConsoEntityID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCostTypeForGL As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ReposCurrCode As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ReposHolding As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ReposConsoEntity As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtTaxNbr3 As System.Windows.Forms.TextBox
    Friend WithEvents lblTaxNbr3 As System.Windows.Forms.Label
    Friend WithEvents txtTaxNbr2 As System.Windows.Forms.TextBox
    Friend WithEvents lblTaxNbr2 As System.Windows.Forms.Label
    Friend WithEvents txtTaxNbr1 As System.Windows.Forms.TextBox
    Friend WithEvents lblTaxNbr1 As System.Windows.Forms.Label
    Friend WithEvents ReposCostType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lblRegion As System.Windows.Forms.Label
    Friend WithEvents txtRegion As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmgeneralentity_Maintenance))
        Me.objDS = New BizzLib.dsGeneral
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PanelEntity = New System.Windows.Forms.Panel
        Me.lblSTCostType = New System.Windows.Forms.Label
        Me.cmbConsoEntityID = New DevExpress.XtraEditors.LookUpEdit
        Me.lblConsoEntityID = New System.Windows.Forms.Label
        Me.cmbHolding = New DevExpress.XtraEditors.LookUpEdit
        Me.lblHolding = New System.Windows.Forms.Label
        Me.txtFormIcon = New System.Windows.Forms.TextBox
        Me.lblFormIcon = New System.Windows.Forms.Label
        Me.cmbCurrCode = New DevExpress.XtraEditors.LookUpEdit
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblCurrCode = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtRegion = New System.Windows.Forms.TextBox
        Me.lblRegion = New System.Windows.Forms.Label
        Me.txtTaxNbr3 = New System.Windows.Forms.TextBox
        Me.lblTaxNbr3 = New System.Windows.Forms.Label
        Me.txtTaxNbr2 = New System.Windows.Forms.TextBox
        Me.lblTaxNbr2 = New System.Windows.Forms.Label
        Me.txtTaxNbr1 = New System.Windows.Forms.TextBox
        Me.lblTaxNbr1 = New System.Windows.Forms.Label
        Me.cmbcountry = New DevExpress.XtraEditors.LookUpEdit
        Me.txtEMail = New DevExpress.XtraEditors.HyperLinkEdit
        Me.txtWebSite = New DevExpress.XtraEditors.HyperLinkEdit
        Me.lblWebSite = New System.Windows.Forms.Label
        Me.lblEMail = New System.Windows.Forms.Label
        Me.lblFax = New System.Windows.Forms.Label
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.lblPhone = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.txtZip = New System.Windows.Forms.TextBox
        Me.lblZip_City = New System.Windows.Forms.Label
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblcountry = New System.Windows.Forms.Label
        Me.ListView = New System.Windows.Forms.TabPage
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.ListView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colEntityID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDescription = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCurrCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.ReposCurrCode = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFormIcon = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colHoldingID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.ReposHolding = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colAddrID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colConsoEntityID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.ReposConsoEntity = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCostTypeForGL = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.ReposCostType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PanelEntity.SuspendLayout()
        CType(Me.cmbConsoEntityID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbHolding.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCurrCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.cmbcountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWebSite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListView.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReposCurrCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReposHolding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReposConsoEntity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReposCostType, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PopMenuUndo
        '
        '
        'StatusBar1
        '
        resources.ApplyResources(Me.StatusBar1, "StatusBar1")
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsGeneral"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.ListView)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.HelpProvider1.SetShowHelp(Me.TabControl1, CType(resources.GetObject("TabControl1.ShowHelp"), Boolean))
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PanelEntity)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.HelpProvider1.SetShowHelp(Me.TabPage1, CType(resources.GetObject("TabPage1.ShowHelp"), Boolean))
        '
        'PanelEntity
        '
        Me.PanelEntity.BackColor = System.Drawing.SystemColors.Window
        Me.PanelEntity.Controls.Add(Me.lblSTCostType)
        Me.PanelEntity.Controls.Add(Me.cmbConsoEntityID)
        Me.PanelEntity.Controls.Add(Me.lblConsoEntityID)
        Me.PanelEntity.Controls.Add(Me.cmbHolding)
        Me.PanelEntity.Controls.Add(Me.lblHolding)
        Me.PanelEntity.Controls.Add(Me.txtFormIcon)
        Me.PanelEntity.Controls.Add(Me.lblFormIcon)
        Me.PanelEntity.Controls.Add(Me.cmbCurrCode)
        Me.PanelEntity.Controls.Add(Me.txtName)
        Me.PanelEntity.Controls.Add(Me.txtDescription)
        Me.PanelEntity.Controls.Add(Me.lblName)
        Me.PanelEntity.Controls.Add(Me.lblDescription)
        Me.PanelEntity.Controls.Add(Me.lblCurrCode)
        resources.ApplyResources(Me.PanelEntity, "PanelEntity")
        Me.PanelEntity.Name = "PanelEntity"
        Me.HelpProvider1.SetShowHelp(Me.PanelEntity, CType(resources.GetObject("PanelEntity.ShowHelp"), Boolean))
        '
        'lblSTCostType
        '
        Me.lblSTCostType.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.lblSTCostType, "lblSTCostType")
        Me.lblSTCostType.Name = "lblSTCostType"
        Me.HelpProvider1.SetShowHelp(Me.lblSTCostType, CType(resources.GetObject("lblSTCostType.ShowHelp"), Boolean))
        '
        'cmbConsoEntityID
        '
        Me.cmbConsoEntityID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "generalentity.ConsoEntityID", True))
        resources.ApplyResources(Me.cmbConsoEntityID, "cmbConsoEntityID")
        Me.cmbConsoEntityID.Name = "cmbConsoEntityID"
        Me.cmbConsoEntityID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbConsoEntityID.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbConsoEntityID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 38, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbConsoEntityID.Properties.DataSource = Me.objDS.generalentity
        Me.cmbConsoEntityID.Properties.DisplayMember = "Name"
        Me.cmbConsoEntityID.Properties.NullText = resources.GetString("cmbConsoEntityID.Properties.NullText")
        Me.cmbConsoEntityID.Properties.ValueMember = "EntityID"
        Me.HelpProvider1.SetShowHelp(Me.cmbConsoEntityID, CType(resources.GetObject("cmbConsoEntityID.ShowHelp"), Boolean))
        '
        'lblConsoEntityID
        '
        Me.lblConsoEntityID.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.lblConsoEntityID, "lblConsoEntityID")
        Me.lblConsoEntityID.Name = "lblConsoEntityID"
        Me.HelpProvider1.SetShowHelp(Me.lblConsoEntityID, CType(resources.GetObject("lblConsoEntityID.ShowHelp"), Boolean))
        '
        'cmbHolding
        '
        Me.cmbHolding.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "generalentity.HoldingID", True))
        resources.ApplyResources(Me.cmbHolding, "cmbHolding")
        Me.cmbHolding.Name = "cmbHolding"
        Me.cmbHolding.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbHolding.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbHolding.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 38, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbHolding.Properties.DataSource = Me.objDS.generalholding
        Me.cmbHolding.Properties.DisplayMember = "Name"
        Me.cmbHolding.Properties.NullText = resources.GetString("cmbHolding.Properties.NullText")
        Me.cmbHolding.Properties.ValueMember = "HoldingID"
        Me.HelpProvider1.SetShowHelp(Me.cmbHolding, CType(resources.GetObject("cmbHolding.ShowHelp"), Boolean))
        '
        'lblHolding
        '
        Me.lblHolding.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.lblHolding, "lblHolding")
        Me.lblHolding.Name = "lblHolding"
        Me.HelpProvider1.SetShowHelp(Me.lblHolding, CType(resources.GetObject("lblHolding.ShowHelp"), Boolean))
        '
        'txtFormIcon
        '
        Me.txtFormIcon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "generalentity.FormIcon", True))
        resources.ApplyResources(Me.txtFormIcon, "txtFormIcon")
        Me.txtFormIcon.Name = "txtFormIcon"
        Me.HelpProvider1.SetShowHelp(Me.txtFormIcon, CType(resources.GetObject("txtFormIcon.ShowHelp"), Boolean))
        '
        'lblFormIcon
        '
        Me.lblFormIcon.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.lblFormIcon, "lblFormIcon")
        Me.lblFormIcon.Name = "lblFormIcon"
        Me.HelpProvider1.SetShowHelp(Me.lblFormIcon, CType(resources.GetObject("lblFormIcon.ShowHelp"), Boolean))
        '
        'cmbCurrCode
        '
        Me.cmbCurrCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "generalentity.CurrCode", True))
        resources.ApplyResources(Me.cmbCurrCode, "cmbCurrCode")
        Me.cmbCurrCode.Name = "cmbCurrCode"
        Me.cmbCurrCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbCurrCode.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbCurrCode.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrCode", "CurrCode", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbCurrCode.Properties.DataSource = Me.objDS.systemcurrency
        Me.cmbCurrCode.Properties.DisplayMember = "CurrCode"
        Me.cmbCurrCode.Properties.NullText = resources.GetString("cmbCurrCode.Properties.NullText")
        Me.cmbCurrCode.Properties.ValueMember = "CurrCode"
        Me.HelpProvider1.SetShowHelp(Me.cmbCurrCode, CType(resources.GetObject("cmbCurrCode.ShowHelp"), Boolean))
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "generalentity.Name", True))
        resources.ApplyResources(Me.txtName, "txtName")
        Me.txtName.Name = "txtName"
        Me.HelpProvider1.SetShowHelp(Me.txtName, CType(resources.GetObject("txtName.ShowHelp"), Boolean))
        '
        'txtDescription
        '
        Me.txtDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "generalentity.Description", True))
        resources.ApplyResources(Me.txtDescription, "txtDescription")
        Me.txtDescription.Name = "txtDescription"
        Me.HelpProvider1.SetShowHelp(Me.txtDescription, CType(resources.GetObject("txtDescription.ShowHelp"), Boolean))
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.lblName, "lblName")
        Me.lblName.Name = "lblName"
        Me.HelpProvider1.SetShowHelp(Me.lblName, CType(resources.GetObject("lblName.ShowHelp"), Boolean))
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.lblDescription, "lblDescription")
        Me.lblDescription.Name = "lblDescription"
        Me.HelpProvider1.SetShowHelp(Me.lblDescription, CType(resources.GetObject("lblDescription.ShowHelp"), Boolean))
        '
        'lblCurrCode
        '
        Me.lblCurrCode.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.lblCurrCode, "lblCurrCode")
        Me.lblCurrCode.Name = "lblCurrCode"
        Me.HelpProvider1.SetShowHelp(Me.lblCurrCode, CType(resources.GetObject("lblCurrCode.ShowHelp"), Boolean))
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel3)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.HelpProvider1.SetShowHelp(Me.TabPage2, CType(resources.GetObject("TabPage2.ShowHelp"), Boolean))
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Window
        Me.Panel3.Controls.Add(Me.txtRegion)
        Me.Panel3.Controls.Add(Me.lblRegion)
        Me.Panel3.Controls.Add(Me.txtTaxNbr3)
        Me.Panel3.Controls.Add(Me.lblTaxNbr3)
        Me.Panel3.Controls.Add(Me.txtTaxNbr2)
        Me.Panel3.Controls.Add(Me.lblTaxNbr2)
        Me.Panel3.Controls.Add(Me.txtTaxNbr1)
        Me.Panel3.Controls.Add(Me.lblTaxNbr1)
        Me.Panel3.Controls.Add(Me.cmbcountry)
        Me.Panel3.Controls.Add(Me.txtEMail)
        Me.Panel3.Controls.Add(Me.txtWebSite)
        Me.Panel3.Controls.Add(Me.lblWebSite)
        Me.Panel3.Controls.Add(Me.lblEMail)
        Me.Panel3.Controls.Add(Me.lblFax)
        Me.Panel3.Controls.Add(Me.txtFax)
        Me.Panel3.Controls.Add(Me.lblPhone)
        Me.Panel3.Controls.Add(Me.txtPhone)
        Me.Panel3.Controls.Add(Me.txtZip)
        Me.Panel3.Controls.Add(Me.lblZip_City)
        Me.Panel3.Controls.Add(Me.txtCity)
        Me.Panel3.Controls.Add(Me.txtAddress1)
        Me.Panel3.Controls.Add(Me.txtAddress2)
        Me.Panel3.Controls.Add(Me.lblAddress)
        Me.Panel3.Controls.Add(Me.lblcountry)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        Me.HelpProvider1.SetShowHelp(Me.Panel3, CType(resources.GetObject("Panel3.ShowHelp"), Boolean))
        '
        'txtRegion
        '
        Me.txtRegion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "GeneralAddress.Region", True))
        resources.ApplyResources(Me.txtRegion, "txtRegion")
        Me.txtRegion.Name = "txtRegion"
        Me.HelpProvider1.SetShowHelp(Me.txtRegion, CType(resources.GetObject("txtRegion.ShowHelp"), Boolean))
        '
        'lblRegion
        '
        resources.ApplyResources(Me.lblRegion, "lblRegion")
        Me.lblRegion.Name = "lblRegion"
        Me.HelpProvider1.SetShowHelp(Me.lblRegion, CType(resources.GetObject("lblRegion.ShowHelp"), Boolean))
        '
        'txtTaxNbr3
        '
        Me.txtTaxNbr3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "GeneralAddress.TaxNbr3", True))
        resources.ApplyResources(Me.txtTaxNbr3, "txtTaxNbr3")
        Me.txtTaxNbr3.Name = "txtTaxNbr3"
        Me.HelpProvider1.SetShowHelp(Me.txtTaxNbr3, CType(resources.GetObject("txtTaxNbr3.ShowHelp"), Boolean))
        Me.ToolTip1.SetToolTip(Me.txtTaxNbr3, resources.GetString("txtTaxNbr3.ToolTip"))
        '
        'lblTaxNbr3
        '
        Me.lblTaxNbr3.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.lblTaxNbr3, "lblTaxNbr3")
        Me.lblTaxNbr3.Name = "lblTaxNbr3"
        Me.HelpProvider1.SetShowHelp(Me.lblTaxNbr3, CType(resources.GetObject("lblTaxNbr3.ShowHelp"), Boolean))
        '
        'txtTaxNbr2
        '
        Me.txtTaxNbr2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "GeneralAddress.TaxNbr2", True))
        resources.ApplyResources(Me.txtTaxNbr2, "txtTaxNbr2")
        Me.txtTaxNbr2.Name = "txtTaxNbr2"
        Me.HelpProvider1.SetShowHelp(Me.txtTaxNbr2, CType(resources.GetObject("txtTaxNbr2.ShowHelp"), Boolean))
        Me.ToolTip1.SetToolTip(Me.txtTaxNbr2, resources.GetString("txtTaxNbr2.ToolTip"))
        '
        'lblTaxNbr2
        '
        Me.lblTaxNbr2.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.lblTaxNbr2, "lblTaxNbr2")
        Me.lblTaxNbr2.Name = "lblTaxNbr2"
        Me.HelpProvider1.SetShowHelp(Me.lblTaxNbr2, CType(resources.GetObject("lblTaxNbr2.ShowHelp"), Boolean))
        '
        'txtTaxNbr1
        '
        Me.txtTaxNbr1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "GeneralAddress.TaxNbr1", True))
        resources.ApplyResources(Me.txtTaxNbr1, "txtTaxNbr1")
        Me.txtTaxNbr1.Name = "txtTaxNbr1"
        Me.HelpProvider1.SetShowHelp(Me.txtTaxNbr1, CType(resources.GetObject("txtTaxNbr1.ShowHelp"), Boolean))
        Me.ToolTip1.SetToolTip(Me.txtTaxNbr1, resources.GetString("txtTaxNbr1.ToolTip"))
        '
        'lblTaxNbr1
        '
        Me.lblTaxNbr1.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.lblTaxNbr1, "lblTaxNbr1")
        Me.lblTaxNbr1.Name = "lblTaxNbr1"
        Me.HelpProvider1.SetShowHelp(Me.lblTaxNbr1, CType(resources.GetObject("lblTaxNbr1.ShowHelp"), Boolean))
        '
        'cmbcountry
        '
        Me.cmbcountry.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "GeneralAddress.countryCode", True))
        resources.ApplyResources(Me.cmbcountry, "cmbcountry")
        Me.cmbcountry.Name = "cmbcountry"
        Me.cmbcountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbcountry.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbcountry.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 39, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 49, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbcountry.Properties.DataSource = Me.objDS.CRMcountry
        Me.cmbcountry.Properties.DisplayMember = "Name"
        Me.cmbcountry.Properties.NullText = resources.GetString("cmbcountry.Properties.NullText")
        Me.cmbcountry.Properties.ValidateOnEnterKey = True
        Me.cmbcountry.Properties.ValueMember = "Code"
        Me.HelpProvider1.SetShowHelp(Me.cmbcountry, CType(resources.GetObject("cmbcountry.ShowHelp"), Boolean))
        '
        'txtEMail
        '
        Me.txtEMail.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "GeneralAddress.EMail1", True))
        resources.ApplyResources(Me.txtEMail, "txtEMail")
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Properties.ReadOnly = True
        Me.txtEMail.Properties.SingleClick = False
        Me.txtEMail.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.HelpProvider1.SetShowHelp(Me.txtEMail, CType(resources.GetObject("txtEMail.ShowHelp"), Boolean))
        '
        'txtWebSite
        '
        Me.txtWebSite.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "GeneralAddress.WebSite", True))
        resources.ApplyResources(Me.txtWebSite, "txtWebSite")
        Me.txtWebSite.Name = "txtWebSite"
        Me.txtWebSite.Properties.ReadOnly = True
        Me.txtWebSite.Properties.SingleClick = False
        Me.txtWebSite.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.HelpProvider1.SetShowHelp(Me.txtWebSite, CType(resources.GetObject("txtWebSite.ShowHelp"), Boolean))
        '
        'lblWebSite
        '
        resources.ApplyResources(Me.lblWebSite, "lblWebSite")
        Me.lblWebSite.Name = "lblWebSite"
        Me.HelpProvider1.SetShowHelp(Me.lblWebSite, CType(resources.GetObject("lblWebSite.ShowHelp"), Boolean))
        '
        'lblEMail
        '
        resources.ApplyResources(Me.lblEMail, "lblEMail")
        Me.lblEMail.Name = "lblEMail"
        Me.HelpProvider1.SetShowHelp(Me.lblEMail, CType(resources.GetObject("lblEMail.ShowHelp"), Boolean))
        '
        'lblFax
        '
        resources.ApplyResources(Me.lblFax, "lblFax")
        Me.lblFax.Name = "lblFax"
        Me.HelpProvider1.SetShowHelp(Me.lblFax, CType(resources.GetObject("lblFax.ShowHelp"), Boolean))
        '
        'txtFax
        '
        Me.txtFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "GeneralAddress.Fax1", True))
        resources.ApplyResources(Me.txtFax, "txtFax")
        Me.txtFax.Name = "txtFax"
        Me.HelpProvider1.SetShowHelp(Me.txtFax, CType(resources.GetObject("txtFax.ShowHelp"), Boolean))
        '
        'lblPhone
        '
        resources.ApplyResources(Me.lblPhone, "lblPhone")
        Me.lblPhone.Name = "lblPhone"
        Me.HelpProvider1.SetShowHelp(Me.lblPhone, CType(resources.GetObject("lblPhone.ShowHelp"), Boolean))
        '
        'txtPhone
        '
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "GeneralAddress.Phone1", True))
        resources.ApplyResources(Me.txtPhone, "txtPhone")
        Me.txtPhone.Name = "txtPhone"
        Me.HelpProvider1.SetShowHelp(Me.txtPhone, CType(resources.GetObject("txtPhone.ShowHelp"), Boolean))
        '
        'txtZip
        '
        Me.txtZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "GeneralAddress.ZIP", True))
        resources.ApplyResources(Me.txtZip, "txtZip")
        Me.txtZip.Name = "txtZip"
        Me.HelpProvider1.SetShowHelp(Me.txtZip, CType(resources.GetObject("txtZip.ShowHelp"), Boolean))
        '
        'lblZip_City
        '
        resources.ApplyResources(Me.lblZip_City, "lblZip_City")
        Me.lblZip_City.Name = "lblZip_City"
        Me.HelpProvider1.SetShowHelp(Me.lblZip_City, CType(resources.GetObject("lblZip_City.ShowHelp"), Boolean))
        '
        'txtCity
        '
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "GeneralAddress.City", True))
        resources.ApplyResources(Me.txtCity, "txtCity")
        Me.txtCity.Name = "txtCity"
        Me.HelpProvider1.SetShowHelp(Me.txtCity, CType(resources.GetObject("txtCity.ShowHelp"), Boolean))
        '
        'txtAddress1
        '
        Me.txtAddress1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "GeneralAddress.Address1", True))
        resources.ApplyResources(Me.txtAddress1, "txtAddress1")
        Me.txtAddress1.Name = "txtAddress1"
        Me.HelpProvider1.SetShowHelp(Me.txtAddress1, CType(resources.GetObject("txtAddress1.ShowHelp"), Boolean))
        '
        'txtAddress2
        '
        Me.txtAddress2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "GeneralAddress.Address2", True))
        resources.ApplyResources(Me.txtAddress2, "txtAddress2")
        Me.txtAddress2.Name = "txtAddress2"
        Me.HelpProvider1.SetShowHelp(Me.txtAddress2, CType(resources.GetObject("txtAddress2.ShowHelp"), Boolean))
        '
        'lblAddress
        '
        resources.ApplyResources(Me.lblAddress, "lblAddress")
        Me.lblAddress.Name = "lblAddress"
        Me.HelpProvider1.SetShowHelp(Me.lblAddress, CType(resources.GetObject("lblAddress.ShowHelp"), Boolean))
        '
        'lblcountry
        '
        resources.ApplyResources(Me.lblcountry, "lblcountry")
        Me.lblcountry.Name = "lblcountry"
        Me.HelpProvider1.SetShowHelp(Me.lblcountry, CType(resources.GetObject("lblcountry.ShowHelp"), Boolean))
        '
        'ListView
        '
        Me.ListView.Controls.Add(Me.Grid1)
        resources.ApplyResources(Me.ListView, "ListView")
        Me.ListView.Name = "ListView"
        Me.HelpProvider1.SetShowHelp(Me.ListView, CType(resources.GetObject("ListView.ShowHelp"), Boolean))
        '
        'Grid1
        '
        Me.Grid1.DataSource = Me.objDS.generalentity
        resources.ApplyResources(Me.Grid1, "Grid1")
        Me.Grid1.EmbeddedNavigator.Buttons.Append.Enabled = False
        Me.Grid1.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.Grid1.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.FormsUseDefaultLookAndFeel = False
        Me.Grid1.MainView = Me.ListView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ReposCurrCode, Me.ReposHolding, Me.ReposConsoEntity, Me.ReposCostType})
        Me.HelpProvider1.SetShowHelp(Me.Grid1, CType(resources.GetObject("Grid1.ShowHelp"), Boolean))
        Me.Grid1.UseEmbeddedNavigator = True
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListView1})
        '
        'ListView1
        '
        Me.ListView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.ListView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colEntityID, Me.colName, Me.colDescription, Me.colCurrCode, Me.colFormIcon, Me.colHoldingID, Me.colAddrID, Me.colConsoEntityID, Me.colCostTypeForGL})
        Me.ListView1.GridControl = Me.Grid1
        resources.ApplyResources(Me.ListView1, "ListView1")
        Me.ListView1.Name = "ListView1"
        Me.ListView1.OptionsBehavior.Editable = False
        Me.ListView1.OptionsSelection.MultiSelect = True
        Me.ListView1.OptionsView.ShowBands = False
        Me.ListView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridBand1
        '
        resources.ApplyResources(Me.GridBand1, "GridBand1")
        Me.GridBand1.Columns.Add(Me.colEntityID)
        Me.GridBand1.Columns.Add(Me.colName)
        Me.GridBand1.Columns.Add(Me.colDescription)
        Me.GridBand1.Columns.Add(Me.colCurrCode)
        Me.GridBand1.Columns.Add(Me.colFormIcon)
        Me.GridBand1.Columns.Add(Me.colHoldingID)
        Me.GridBand1.Columns.Add(Me.colAddrID)
        Me.GridBand1.Columns.Add(Me.colConsoEntityID)
        Me.GridBand1.Columns.Add(Me.colCostTypeForGL)
        '
        'colEntityID
        '
        resources.ApplyResources(Me.colEntityID, "colEntityID")
        Me.colEntityID.FieldName = "EntityID"
        Me.colEntityID.Name = "colEntityID"
        '
        'colName
        '
        resources.ApplyResources(Me.colName, "colName")
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        '
        'colDescription
        '
        resources.ApplyResources(Me.colDescription, "colDescription")
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        '
        'colCurrCode
        '
        resources.ApplyResources(Me.colCurrCode, "colCurrCode")
        Me.colCurrCode.ColumnEdit = Me.ReposCurrCode
        Me.colCurrCode.FieldName = "CurrCode"
        Me.colCurrCode.Name = "colCurrCode"
        '
        'ReposCurrCode
        '
        resources.ApplyResources(Me.ReposCurrCode, "ReposCurrCode")
        Me.ReposCurrCode.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("ReposCurrCode.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.ReposCurrCode.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrCode", "CurrCode", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ReposCurrCode.DataSource = Me.objDS.systemcurrency
        Me.ReposCurrCode.DisplayMember = "CurrCode"
        Me.ReposCurrCode.Name = "ReposCurrCode"
        Me.ReposCurrCode.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.ReposCurrCode.ValueMember = "CurrCode"
        '
        'colFormIcon
        '
        resources.ApplyResources(Me.colFormIcon, "colFormIcon")
        Me.colFormIcon.FieldName = "FormIcon"
        Me.colFormIcon.Name = "colFormIcon"
        '
        'colHoldingID
        '
        resources.ApplyResources(Me.colHoldingID, "colHoldingID")
        Me.colHoldingID.ColumnEdit = Me.ReposHolding
        Me.colHoldingID.FieldName = "HoldingID"
        Me.colHoldingID.Name = "colHoldingID"
        '
        'ReposHolding
        '
        resources.ApplyResources(Me.ReposHolding, "ReposHolding")
        Me.ReposHolding.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("ReposHolding.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.ReposHolding.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ReposHolding.DataSource = Me.objDS.generalholding
        Me.ReposHolding.DisplayMember = "Name"
        Me.ReposHolding.Name = "ReposHolding"
        Me.ReposHolding.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.ReposHolding.ValueMember = "HoldingID"
        '
        'colAddrID
        '
        resources.ApplyResources(Me.colAddrID, "colAddrID")
        Me.colAddrID.FieldName = "AddrID"
        Me.colAddrID.Name = "colAddrID"
        '
        'colConsoEntityID
        '
        resources.ApplyResources(Me.colConsoEntityID, "colConsoEntityID")
        Me.colConsoEntityID.ColumnEdit = Me.ReposConsoEntity
        Me.colConsoEntityID.FieldName = "ConsoEntityID"
        Me.colConsoEntityID.Name = "colConsoEntityID"
        '
        'ReposConsoEntity
        '
        resources.ApplyResources(Me.ReposConsoEntity, "ReposConsoEntity")
        Me.ReposConsoEntity.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("ReposConsoEntity.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.ReposConsoEntity.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ReposConsoEntity.DataSource = Me.objDS.generalentity
        Me.ReposConsoEntity.DisplayMember = "Name"
        Me.ReposConsoEntity.Name = "ReposConsoEntity"
        Me.ReposConsoEntity.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.ReposConsoEntity.ValueMember = "EntityID"
        '
        'colCostTypeForGL
        '
        resources.ApplyResources(Me.colCostTypeForGL, "colCostTypeForGL")
        Me.colCostTypeForGL.ColumnEdit = Me.ReposCostType
        Me.colCostTypeForGL.FieldName = "CostTypeForGL"
        Me.colCostTypeForGL.Name = "colCostTypeForGL"
        '
        'ReposCostType
        '
        resources.ApplyResources(Me.ReposCostType, "ReposCostType")
        Me.ReposCostType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("ReposCostType.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.ReposCostType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeDesc", "CodeDesc", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ReposCostType.DataSource = Me.objDS.STCostTypeView1
        Me.ReposCostType.DisplayMember = "CodeDesc"
        Me.ReposCostType.Name = "ReposCostType"
        Me.ReposCostType.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.ReposCostType.ValueMember = "CodeValue"
        '
        'frmgeneralentity_Maintenance
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.TabControl1)
        Me.HelpProvider1.SetHelpKeyword(Me, resources.GetString("$this.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me, CType(resources.GetObject("$this.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.Name = "frmgeneralentity_Maintenance"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.PanelEntity.ResumeLayout(False)
        Me.PanelEntity.PerformLayout()
        CType(Me.cmbConsoEntityID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbHolding.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCurrCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.cmbcountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWebSite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListView.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReposCurrCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReposHolding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReposConsoEntity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReposCostType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim KeyDataSet As String = "BizzLib.dsGeneral" 'The Dataset used 
    Dim CurrentAddrID As Integer
    Dim MainData As BizzLib.clsData_Entity

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'SetUp of Variables
            KeyFieldName = "Name"
            IDField = "EntityID"
            TableName = "generalentity"
            MainDataSet = objDS
            MyBase.RaiseEventForReportDesigner = True
            HelpProvider1.HelpNamespace = ".\Help\" & SessionInfo.UserLang & "\BizzKeys.chm"
            'Attempt to load the dataset.
            Me.LoadBKComboSet()
            Me.LoadDataSet()
            BKGlobal.LoadAssociatedMenu(Me.Tag, PopMenuAssociatedTasks, Me)
            If OpenType = "NEW" Then
                NewRecord(sender, e)
            End If
            If OpenType = "EDIT" Then
                If KeyValue <> "" Then 'Not IsNothing(_Row) Then
                    Dim _View As New DataView(Me.objDS.Tables(TableName), "", IDField, DataViewRowState.CurrentRows)
                    Dim _Name As String = _View(_View.Find(New Object() {KeyValue}))(KeyFieldName)
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
            Me.BindingContext(objDS, TableName).EndCurrentEdit()
            Me.BindingContext(objDS, TableName).AddNew()
        Catch eEndEdit As System.Exception
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
                    BKGlobal.DeleteTranslations("GLAccountCode.GLAccountID", CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField) & "")
                    BKGlobal.DeleteComments(SessionInfo.EntityID, txtName.Text)
                    MainData.Delete(CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField))
                    EnablingAll(False)
                    PositionChanged(Sender, e)
                Catch ex As Exception
                    If ex.Source <> "##" Then
                        '7: Cannot Delete - Linked Tables exists
                        MsgBox(BKGlobal.GetMsg(7, SessionInfo.UserLang), MsgBoxStyle.Critical)
                    Else
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    End If
                    Exit Sub
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
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        Finally
        End Try
        PositionChanged(Sender, e)
    End Sub

    Public Sub UpdateDataSet() Handles MyBase.EventUpdateDataset
        'Stop any current edits.
        Me.BindingContext(objDS, TableName).EndCurrentEdit()
        Me.BindingContext(objDS, "GeneralAddress").EndCurrentEdit()
        MainData.SaveOnlyEntity()
        'MainData.AddrData.Rows(0)("EntityID") = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField)
        'MainData.AddrData.Rows(0)("Name") = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)("Name")
        'MainData.AddrData.Rows(0)("Description") = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)("Description")
        'MainData.SaveOnlyAddr()
    End Sub
    Public Sub LoadDataSet() Handles MyBase.EventLoadDataset
        If IsFiltered Then
            MainData = New BizzLib.clsData_Entity(SessionInfo, objDS, KeyDataSet, TableName, " WHERE EntityID <> 0 AND " & FilterTxt, "ORDER BY " & KeyFieldName)
        Else
            MainData = New BizzLib.clsData_Entity(SessionInfo, objDS, KeyDataSet, TableName, " WHERE EntityID <> 0 ", "ORDER BY " & KeyFieldName)
        End If
        Me.objDS.Tables(TableName).DefaultView.Sort = "Name"
    End Sub
    Private Sub PositionChanged(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.EventPositionChanged
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            If CType(Me.BindingContext(objDS, TableName).Current, DataRowView)("AddrID") & "" <> "" Then
                CurrentAddrID = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)("AddrID")
            Else
                CurrentAddrID = BKGlobal.GetNextID("AddrID")
                CType(Me.BindingContext(objDS, TableName).Current, DataRowView)("AddrID") = CurrentAddrID
            End If
            'Load Address Info and Create Record if Necessary
            'MainData.LoadAddress(objDS, KeyDataSet, CurrentAddrID)
            StatusBar1.Panels(0).Text = (((Me.BindingContext(objDS, TableName).Position + 1).ToString + " of  ") _
                        + Me.BindingContext(objDS, TableName).Count.ToString)
            ToolTip1.SetToolTip(StatusBar1, TableName & "-->" & IDField & "=" & CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField) & "")
            txtQuickSearch.EditValue = txtName.Text
        End If
    End Sub
    Private Sub EnablingEditFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingEditFields
        'ToBeChecked ***
        txtName.Enabled = Enabling
        txtDescription.Enabled = Enabling
        cmbCurrCode.Properties.Enabled = Enabling
        cmbHolding.Properties.Enabled = Enabling
        cmbConsoEntityID.Properties.Enabled = Enabling
        txtFormIcon.Enabled = Enabling
        'Codes Section
        txtTaxNbr1.Enabled = Enabling
        txtTaxNbr2.Enabled = Enabling
        txtTaxNbr3.Enabled = Enabling
        'Address Section
        txtAddress1.Enabled = Enabling
        txtAddress2.Enabled = Enabling
        txtZip.Enabled = Enabling
        txtCity.Enabled = Enabling
        txtRegion.Enabled = Enabling
        cmbcountry.Properties.Enabled = Enabling
        txtEMail.Properties.ReadOnly = Not Enabling
        txtWebSite.Properties.ReadOnly = Not Enabling
        txtFax.Enabled = Enabling
        txtPhone.Enabled = Enabling
        'ListView
        ListView1.OptionsBehavior.Editable = Enabling
        'Grid1.EmbeddedNavigator.Enabled = Enabling
    End Sub
    Private Sub EnablingKeyFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingkeyFields
        'ToBeChecked ***
    End Sub
    Private Sub StartPrintForm() Handles MyBase.EventPrintForm
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            'Find EntityView1Row
            Dim _SQLTxt As String = "SELECT * FROM generalentityView1 WHERE EntityID = " & CType(Me.BindingContext(objDS, TableName).Current, DataRowView)("EntityID")
            '  Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)
            objDS.Tables("generalentityView1").Clear()
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("generalentityView1"), _SQLTxt)
            If objDS.Tables("generalentityView1").Rows.Count = 1 Then
                BKReport.PrintForm(CurrentReportID, New DataRow() { _
                    objDS.Tables("generalentityView1").Rows(0), _
                    CType(Me.BindingContext(objDS, "GeneralAddress").Current, DataRowView).Row})
            End If
        End If
    End Sub
    Private Sub StartDesignReport() Handles MyBase.EventDesignReport
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            'Find EntityView1Row
            Dim _SQLTxt As String = "SELECT * FROM generalentityView1 WHERE EntityID = " & CType(Me.BindingContext(objDS, TableName).Current, DataRowView)("EntityID")
            '  Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)
            objDS.Tables("generalentityView1").Clear()
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("generalentityView1"), _SQLTxt)
            If objDS.Tables("generalentityView1").Rows.Count = 1 Then
                BKReport.DesignReport(CurrentReportID, New DataRow() { _
                    objDS.Tables("generalentityView1").Rows(0), _
                    CType(Me.BindingContext(objDS, "GeneralAddress").Current, DataRowView).Row})
            End If
        End If
    End Sub

    Public Sub LoadBKComboSet()
        Try
            BKCombo.GetCombo_Currency(objDS, "systemcurrency", "CurrCode")
            BKCombo.GetCombo_HoldingAll(objDS, "generalholding", "Name")
            BKCombo.GetCombo_CRMcountry(objDS)
            BKCombo.GetCombo_AllowedEntities(objDS)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub txtEMail_OpenLink(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles txtEMail.OpenLink
        Const mailPrefix As String = "mailto:"
        Dim PreviousTxt As String = e.EditValue
        If Not e.EditValue.ToString().ToLower().StartsWith(mailPrefix) Then
            e.EditValue = mailPrefix + e.EditValue.ToString()
        End If
    End Sub

    Private Sub ListView1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles ListView1.ValidateRow
        If IsDBNull(ListView1.GetDataRow(e.RowHandle)("EntityID")) Then
            ListView1.GetDataRow(e.RowHandle)("EntityID") = BKGlobal.GetNextID("EntityId")
        End If
        If IsDBNull(ListView1.GetDataRow(e.RowHandle)("AddrID")) Then
            CurrentAddrID = BKGlobal.GetNextID("AddrID")
            ListView1.GetDataRow(e.RowHandle)("AddrID") = CurrentAddrID
            MainData.LoadAddress(objDS, KeyDataSet, CurrentAddrID)
        End If
    End Sub
    Private Sub ListView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles ListView1.FocusedRowChanged
        If IsNothing(ListView1.GetDataRow(e.FocusedRowHandle)) Then Exit Sub
        txtQuickSearch.EditValue = ListView1.GetDataRow(e.FocusedRowHandle)("Name") & ""
        Dim e1 As New System.EventArgs
        ListView1.Columns("Name").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        MyBase.QuickSearch(sender, e1)
    End Sub
End Class
