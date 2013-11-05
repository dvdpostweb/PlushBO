<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListingOUT
    Inherits BizzLib.frmBKForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControlListingOut = New DevExpress.XtraTab.XtraTabControl
        Me.TabParameters = New DevExpress.XtraTab.XtraTabPage
        Me.NbUserLogistic = New DevExpress.XtraEditors.SpinEdit
        Me.Chkstock = New DevExpress.XtraEditors.CheckEdit
        Me.Lblnb_cust = New System.Windows.Forms.Label
        Me.txtBelgiqueNLQtyClient = New System.Windows.Forms.TextBox
        Me.txtBelgiqueFRQtyClient = New System.Windows.Forms.TextBox
        Me.txtNetherlandsQtyClient = New System.Windows.Forms.TextBox
        Me.txtLuxembourgQtyClient = New System.Windows.Forms.TextBox
        Me.lblPickGroup = New System.Windows.Forms.Label
        Me.txtBelgiqueNL = New System.Windows.Forms.TextBox
        Me.txtBelgiqueFR = New System.Windows.Forms.TextBox
        Me.txtNetherlands = New System.Windows.Forms.TextBox
        Me.txtLuxembourg = New System.Windows.Forms.TextBox
        Me.LblBelgique = New System.Windows.Forms.Label
        Me.LblBelgiqueNL = New System.Windows.Forms.Label
        Me.lblNetherlands = New System.Windows.Forms.Label
        Me.LblLuxembourg = New System.Windows.Forms.Label
        Me.btnSetPickingGroup = New DevExpress.XtraEditors.SimpleButton
        Me.btnLoadOrders = New DevExpress.XtraEditors.SimpleButton
        Me.TabResult = New DevExpress.XtraTab.XtraTabPage
        Me.GridListingOut = New DevExpress.XtraGrid.GridControl
        Me.GridViewListingOut = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colBoxId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colpibox_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colProducts_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldvd_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldatepurchased = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colOrders_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCustomers_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldelivery_country = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colLanguage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colpickgroup = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colorders_type = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colpick_boxid = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colserie = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colQtyStock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControlListingOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlListingOut.SuspendLayout()
        Me.TabParameters.SuspendLayout()
        CType(Me.NbUserLogistic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chkstock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabResult.SuspendLayout()
        CType(Me.GridListingOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewListingOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlListingOut
        '
        Me.TabControlListingOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlListingOut.Location = New System.Drawing.Point(0, 35)
        Me.TabControlListingOut.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControlListingOut.Name = "TabControlListingOut"
        Me.TabControlListingOut.SelectedTabPage = Me.TabParameters
        Me.TabControlListingOut.Size = New System.Drawing.Size(1547, 292)
        Me.TabControlListingOut.TabIndex = 4
        Me.TabControlListingOut.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabParameters, Me.TabResult})
        Me.TabControlListingOut.Text = "ListingOut"
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.NbUserLogistic)
        Me.TabParameters.Controls.Add(Me.Chkstock)
        Me.TabParameters.Controls.Add(Me.Lblnb_cust)
        Me.TabParameters.Controls.Add(Me.txtBelgiqueNLQtyClient)
        Me.TabParameters.Controls.Add(Me.txtBelgiqueFRQtyClient)
        Me.TabParameters.Controls.Add(Me.txtNetherlandsQtyClient)
        Me.TabParameters.Controls.Add(Me.txtLuxembourgQtyClient)
        Me.TabParameters.Controls.Add(Me.lblPickGroup)
        Me.TabParameters.Controls.Add(Me.txtBelgiqueNL)
        Me.TabParameters.Controls.Add(Me.txtBelgiqueFR)
        Me.TabParameters.Controls.Add(Me.txtNetherlands)
        Me.TabParameters.Controls.Add(Me.txtLuxembourg)
        Me.TabParameters.Controls.Add(Me.LblBelgique)
        Me.TabParameters.Controls.Add(Me.LblBelgiqueNL)
        Me.TabParameters.Controls.Add(Me.lblNetherlands)
        Me.TabParameters.Controls.Add(Me.LblLuxembourg)
        Me.TabParameters.Controls.Add(Me.btnSetPickingGroup)
        Me.TabParameters.Controls.Add(Me.btnLoadOrders)
        Me.TabParameters.Margin = New System.Windows.Forms.Padding(4)
        Me.TabParameters.Name = "TabParameters"
        Me.TabParameters.Size = New System.Drawing.Size(1538, 258)
        Me.TabParameters.Text = "Parameters"
        '
        'NbUserLogistic
        '
        Me.NbUserLogistic.EditValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.NbUserLogistic.Location = New System.Drawing.Point(278, 163)
        Me.NbUserLogistic.Name = "NbUserLogistic"
        Me.NbUserLogistic.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.NbUserLogistic.Properties.MaxLength = 2
        Me.NbUserLogistic.Properties.MaxValue = New Decimal(New Integer() {15, 0, 0, 0})
        Me.NbUserLogistic.Size = New System.Drawing.Size(63, 22)
        Me.NbUserLogistic.TabIndex = 45
        '
        'Chkstock
        '
        Me.Chkstock.Location = New System.Drawing.Point(216, 31)
        Me.Chkstock.Margin = New System.Windows.Forms.Padding(4)
        Me.Chkstock.Name = "Chkstock"
        Me.Chkstock.Properties.Caption = "stock"
        Me.Chkstock.Size = New System.Drawing.Size(100, 21)
        Me.Chkstock.TabIndex = 43
        '
        'Lblnb_cust
        '
        Me.Lblnb_cust.AutoSize = True
        Me.Lblnb_cust.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lblnb_cust.Location = New System.Drawing.Point(757, 26)
        Me.Lblnb_cust.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblnb_cust.Name = "Lblnb_cust"
        Me.Lblnb_cust.Size = New System.Drawing.Size(93, 17)
        Me.Lblnb_cust.TabIndex = 42
        Me.Lblnb_cust.Text = "nb customers"
        '
        'txtBelgiqueNLQtyClient
        '
        Me.txtBelgiqueNLQtyClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtBelgiqueNLQtyClient.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBelgiqueNLQtyClient.Location = New System.Drawing.Point(748, 194)
        Me.txtBelgiqueNLQtyClient.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBelgiqueNLQtyClient.Name = "txtBelgiqueNLQtyClient"
        Me.txtBelgiqueNLQtyClient.ReadOnly = True
        Me.txtBelgiqueNLQtyClient.Size = New System.Drawing.Size(105, 26)
        Me.txtBelgiqueNLQtyClient.TabIndex = 41
        Me.txtBelgiqueNLQtyClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBelgiqueNLQtyClient.Visible = False
        '
        'txtBelgiqueFRQtyClient
        '
        Me.txtBelgiqueFRQtyClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtBelgiqueFRQtyClient.Location = New System.Drawing.Point(748, 156)
        Me.txtBelgiqueFRQtyClient.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBelgiqueFRQtyClient.Name = "txtBelgiqueFRQtyClient"
        Me.txtBelgiqueFRQtyClient.ReadOnly = True
        Me.txtBelgiqueFRQtyClient.Size = New System.Drawing.Size(105, 26)
        Me.txtBelgiqueFRQtyClient.TabIndex = 40
        Me.txtBelgiqueFRQtyClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNetherlandsQtyClient
        '
        Me.txtNetherlandsQtyClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtNetherlandsQtyClient.Location = New System.Drawing.Point(748, 96)
        Me.txtNetherlandsQtyClient.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNetherlandsQtyClient.Name = "txtNetherlandsQtyClient"
        Me.txtNetherlandsQtyClient.ReadOnly = True
        Me.txtNetherlandsQtyClient.Size = New System.Drawing.Size(105, 26)
        Me.txtNetherlandsQtyClient.TabIndex = 39
        Me.txtNetherlandsQtyClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLuxembourgQtyClient
        '
        Me.txtLuxembourgQtyClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtLuxembourgQtyClient.Location = New System.Drawing.Point(748, 62)
        Me.txtLuxembourgQtyClient.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLuxembourgQtyClient.Name = "txtLuxembourgQtyClient"
        Me.txtLuxembourgQtyClient.ReadOnly = True
        Me.txtLuxembourgQtyClient.Size = New System.Drawing.Size(105, 26)
        Me.txtLuxembourgQtyClient.TabIndex = 38
        Me.txtLuxembourgQtyClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPickGroup
        '
        Me.lblPickGroup.AutoSize = True
        Me.lblPickGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPickGroup.Location = New System.Drawing.Point(456, 26)
        Me.lblPickGroup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPickGroup.Name = "lblPickGroup"
        Me.lblPickGroup.Size = New System.Drawing.Size(78, 17)
        Me.lblPickGroup.TabIndex = 37
        Me.lblPickGroup.Text = "Pick Group"
        '
        'txtBelgiqueNL
        '
        Me.txtBelgiqueNL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtBelgiqueNL.Location = New System.Drawing.Point(459, 194)
        Me.txtBelgiqueNL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBelgiqueNL.Name = "txtBelgiqueNL"
        Me.txtBelgiqueNL.Size = New System.Drawing.Size(260, 26)
        Me.txtBelgiqueNL.TabIndex = 36
        Me.txtBelgiqueNL.Text = "3,4"
        Me.txtBelgiqueNL.Visible = False
        '
        'txtBelgiqueFR
        '
        Me.txtBelgiqueFR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtBelgiqueFR.Location = New System.Drawing.Point(459, 159)
        Me.txtBelgiqueFR.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBelgiqueFR.Name = "txtBelgiqueFR"
        Me.txtBelgiqueFR.ReadOnly = True
        Me.txtBelgiqueFR.Size = New System.Drawing.Size(260, 26)
        Me.txtBelgiqueFR.TabIndex = 35
        '
        'txtNetherlands
        '
        Me.txtNetherlands.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtNetherlands.Location = New System.Drawing.Point(459, 105)
        Me.txtNetherlands.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNetherlands.Name = "txtNetherlands"
        Me.txtNetherlands.ReadOnly = True
        Me.txtNetherlands.Size = New System.Drawing.Size(36, 26)
        Me.txtNetherlands.TabIndex = 34
        Me.txtNetherlands.Text = "2"
        '
        'txtLuxembourg
        '
        Me.txtLuxembourg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtLuxembourg.Location = New System.Drawing.Point(459, 62)
        Me.txtLuxembourg.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLuxembourg.Name = "txtLuxembourg"
        Me.txtLuxembourg.ReadOnly = True
        Me.txtLuxembourg.Size = New System.Drawing.Size(36, 26)
        Me.txtLuxembourg.TabIndex = 33
        Me.txtLuxembourg.Text = "1"
        '
        'LblBelgique
        '
        Me.LblBelgique.AutoSize = True
        Me.LblBelgique.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblBelgique.Location = New System.Drawing.Point(348, 162)
        Me.LblBelgique.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblBelgique.Name = "LblBelgique"
        Me.LblBelgique.Size = New System.Drawing.Size(58, 17)
        Me.LblBelgique.TabIndex = 32
        Me.LblBelgique.Text = "Belgium"
        '
        'LblBelgiqueNL
        '
        Me.LblBelgiqueNL.AutoSize = True
        Me.LblBelgiqueNL.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblBelgiqueNL.Location = New System.Drawing.Point(348, 194)
        Me.LblBelgiqueNL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblBelgiqueNL.Name = "LblBelgiqueNL"
        Me.LblBelgiqueNL.Size = New System.Drawing.Size(85, 17)
        Me.LblBelgiqueNL.TabIndex = 31
        Me.LblBelgiqueNL.Text = "Belgique NL"
        Me.LblBelgiqueNL.Visible = False
        '
        'lblNetherlands
        '
        Me.lblNetherlands.AutoSize = True
        Me.lblNetherlands.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNetherlands.Location = New System.Drawing.Point(349, 105)
        Me.lblNetherlands.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNetherlands.Name = "lblNetherlands"
        Me.lblNetherlands.Size = New System.Drawing.Size(85, 17)
        Me.lblNetherlands.TabIndex = 30
        Me.lblNetherlands.Text = "Netherlands"
        '
        'LblLuxembourg
        '
        Me.LblLuxembourg.AutoSize = True
        Me.LblLuxembourg.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblLuxembourg.Location = New System.Drawing.Point(349, 65)
        Me.LblLuxembourg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLuxembourg.Name = "LblLuxembourg"
        Me.LblLuxembourg.Size = New System.Drawing.Size(86, 17)
        Me.LblLuxembourg.TabIndex = 29
        Me.LblLuxembourg.Text = "Luxembourg"
        '
        'btnSetPickingGroup
        '
        Me.btnSetPickingGroup.Location = New System.Drawing.Point(12, 144)
        Me.btnSetPickingGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSetPickingGroup.Name = "btnSetPickingGroup"
        Me.btnSetPickingGroup.Size = New System.Drawing.Size(171, 28)
        Me.btnSetPickingGroup.TabIndex = 28
        Me.btnSetPickingGroup.Text = "Set Picking Group"
        Me.btnSetPickingGroup.ToolTip = "Set Picking Group"
        '
        'btnLoadOrders
        '
        Me.btnLoadOrders.Location = New System.Drawing.Point(12, 26)
        Me.btnLoadOrders.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLoadOrders.Name = "btnLoadOrders"
        Me.btnLoadOrders.Size = New System.Drawing.Size(171, 28)
        Me.btnLoadOrders.TabIndex = 24
        Me.btnLoadOrders.Text = "Load/Update Orders"
        Me.btnLoadOrders.ToolTip = "Assign DVD_ID to orders (due to OLD Abo Process)"
        '
        'TabResult
        '
        Me.TabResult.Controls.Add(Me.GridListingOut)
        Me.TabResult.Margin = New System.Windows.Forms.Padding(4)
        Me.TabResult.Name = "TabResult"
        Me.TabResult.Size = New System.Drawing.Size(1538, 258)
        Me.TabResult.Text = "Result"
        '
        'GridListingOut
        '
        Me.GridListingOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridListingOut.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GridListingOut.EmbeddedNavigator.Name = ""
        Me.GridListingOut.FormsUseDefaultLookAndFeel = False
        Me.GridListingOut.Location = New System.Drawing.Point(0, 0)
        Me.GridListingOut.MainView = Me.GridViewListingOut
        Me.GridListingOut.Margin = New System.Windows.Forms.Padding(4)
        Me.GridListingOut.Name = "GridListingOut"
        Me.GridListingOut.Size = New System.Drawing.Size(1538, 258)
        Me.GridListingOut.TabIndex = 1
        Me.GridListingOut.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewListingOut})
        '
        'GridViewListingOut
        '
        Me.GridViewListingOut.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridViewListingOut.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colOrders_id, Me.colCustomers_id, Me.coldelivery_country, Me.colProducts_id, Me.coldvd_id, Me.colBoxId, Me.colpibox_id, Me.colLanguage, Me.colpickgroup, Me.coldatepurchased, Me.colorders_type, Me.colpick_boxid, Me.coldate, Me.colserie, Me.colTitle, Me.colQtyStock})
        Me.GridViewListingOut.CustomizationFormBounds = New System.Drawing.Rectangle(1454, 748, 216, 178)
        Me.GridViewListingOut.GridControl = Me.GridListingOut
        Me.GridViewListingOut.Name = "GridViewListingOut"
        Me.GridViewListingOut.OptionsSelection.MultiSelect = True
        Me.GridViewListingOut.OptionsView.ShowBands = False
        Me.GridViewListingOut.OptionsView.ShowFooter = True
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colBoxId)
        Me.GridBand1.Columns.Add(Me.colpibox_id)
        Me.GridBand1.Columns.Add(Me.colProducts_id)
        Me.GridBand1.Columns.Add(Me.coldvd_id)
        Me.GridBand1.Columns.Add(Me.coldatepurchased)
        Me.GridBand1.Columns.Add(Me.colOrders_id)
        Me.GridBand1.Columns.Add(Me.colCustomers_id)
        Me.GridBand1.Columns.Add(Me.coldelivery_country)
        Me.GridBand1.Columns.Add(Me.colLanguage)
        Me.GridBand1.Columns.Add(Me.colpickgroup)
        Me.GridBand1.Columns.Add(Me.colorders_type)
        Me.GridBand1.Columns.Add(Me.colpick_boxid)
        Me.GridBand1.Columns.Add(Me.coldate)
        Me.GridBand1.Columns.Add(Me.colserie)
        Me.GridBand1.Columns.Add(Me.colTitle)
        Me.GridBand1.Columns.Add(Me.colQtyStock)
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 1231
        '
        'colBoxId
        '
        Me.colBoxId.Caption = "box_id"
        Me.colBoxId.FieldName = "box_id"
        Me.colBoxId.Name = "colBoxId"
        Me.colBoxId.OptionsColumn.AllowEdit = False
        Me.colBoxId.OptionsColumn.ReadOnly = True
        Me.colBoxId.Visible = True
        Me.colBoxId.Width = 109
        '
        'colpibox_id
        '
        Me.colpibox_id.Caption = "pos_box"
        Me.colpibox_id.FieldName = "pibox_id"
        Me.colpibox_id.Name = "colpibox_id"
        Me.colpibox_id.OptionsColumn.AllowEdit = False
        Me.colpibox_id.OptionsColumn.ReadOnly = True
        Me.colpibox_id.Visible = True
        Me.colpibox_id.Width = 78
        '
        'colProducts_id
        '
        Me.colProducts_id.Caption = "products_id"
        Me.colProducts_id.FieldName = "products_id"
        Me.colProducts_id.Name = "colProducts_id"
        Me.colProducts_id.OptionsColumn.ReadOnly = True
        Me.colProducts_id.Visible = True
        Me.colProducts_id.Width = 148
        '
        'coldvd_id
        '
        Me.coldvd_id.Caption = "dvd_id"
        Me.coldvd_id.FieldName = "dvd_id"
        Me.coldvd_id.Name = "coldvd_id"
        Me.coldvd_id.OptionsColumn.AllowEdit = False
        Me.coldvd_id.OptionsColumn.ReadOnly = True
        Me.coldvd_id.Visible = True
        Me.coldvd_id.Width = 65
        '
        'coldatepurchased
        '
        Me.coldatepurchased.Caption = "date time"
        Me.coldatepurchased.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.coldatepurchased.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.coldatepurchased.FieldName = "date_purchased"
        Me.coldatepurchased.GroupFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.coldatepurchased.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.coldatepurchased.Name = "coldatepurchased"
        Me.coldatepurchased.OptionsColumn.AllowEdit = False
        Me.coldatepurchased.OptionsColumn.ReadOnly = True
        Me.coldatepurchased.Visible = True
        Me.coldatepurchased.Width = 173
        '
        'colOrders_id
        '
        Me.colOrders_id.Caption = "orders_id"
        Me.colOrders_id.FieldName = "orders_id"
        Me.colOrders_id.Name = "colOrders_id"
        Me.colOrders_id.OptionsColumn.AllowEdit = False
        Me.colOrders_id.OptionsColumn.ReadOnly = True
        '
        'colCustomers_id
        '
        Me.colCustomers_id.Caption = "customers_id"
        Me.colCustomers_id.FieldName = "customers_id"
        Me.colCustomers_id.Name = "colCustomers_id"
        Me.colCustomers_id.OptionsColumn.ReadOnly = True
        Me.colCustomers_id.Visible = True
        Me.colCustomers_id.Width = 125
        '
        'coldelivery_country
        '
        Me.coldelivery_country.Caption = "delivery_country"
        Me.coldelivery_country.FieldName = "delivery_country"
        Me.coldelivery_country.Name = "coldelivery_country"
        Me.coldelivery_country.OptionsColumn.AllowEdit = False
        Me.coldelivery_country.OptionsColumn.ReadOnly = True
        '
        'colLanguage
        '
        Me.colLanguage.Caption = "language"
        Me.colLanguage.FieldName = "language_id"
        Me.colLanguage.Name = "colLanguage"
        Me.colLanguage.OptionsColumn.AllowEdit = False
        Me.colLanguage.OptionsColumn.ReadOnly = True
        '
        'colpickgroup
        '
        Me.colpickgroup.Caption = "pick_group"
        Me.colpickgroup.FieldName = "pick_group"
        Me.colpickgroup.Name = "colpickgroup"
        Me.colpickgroup.OptionsColumn.AllowEdit = False
        Me.colpickgroup.OptionsColumn.ReadOnly = True
        Me.colpickgroup.Visible = True
        Me.colpickgroup.Width = 170
        '
        'colorders_type
        '
        Me.colorders_type.Caption = "orders_type"
        Me.colorders_type.FieldName = "orders_type"
        Me.colorders_type.Name = "colorders_type"
        Me.colorders_type.OptionsColumn.AllowEdit = False
        Me.colorders_type.OptionsColumn.ReadOnly = True
        Me.colorders_type.Visible = True
        Me.colorders_type.Width = 148
        '
        'colpick_boxid
        '
        Me.colpick_boxid.Caption = "pick_box_id"
        Me.colpick_boxid.FieldName = "pick_boxid"
        Me.colpick_boxid.Name = "colpick_boxid"
        Me.colpick_boxid.Visible = True
        Me.colpick_boxid.Width = 113
        '
        'coldate
        '
        Me.coldate.Caption = "date"
        Me.coldate.FieldName = "date"
        Me.coldate.Name = "coldate"
        Me.coldate.Visible = True
        Me.coldate.Width = 102
        '
        'colserie
        '
        Me.colserie.Caption = "serie"
        Me.colserie.FieldName = "products_series_id"
        Me.colserie.Name = "colserie"
        '
        'colTitle
        '
        Me.colTitle.Caption = "title"
        Me.colTitle.FieldName = "products_title"
        Me.colTitle.Name = "colTitle"
        '
        'colQtyStock
        '
        Me.colQtyStock.Caption = "qty stock"
        Me.colQtyStock.FieldName = "qtyStock"
        Me.colQtyStock.Name = "colQtyStock"
        '
        'frmListingOUT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1547, 327)
        Me.Controls.Add(Me.TabControlListingOut)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmListingOUT"
        Me.Text = "frmListingOut"
        Me.Controls.SetChildIndex(Me.TabControlListingOut, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControlListingOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlListingOut.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        Me.TabParameters.PerformLayout()
        CType(Me.NbUserLogistic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chkstock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabResult.ResumeLayout(False)
        CType(Me.GridListingOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewListingOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlListingOut As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabParameters As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TabResult As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Lblnb_cust As System.Windows.Forms.Label
    Friend WithEvents txtBelgiqueNLQtyClient As System.Windows.Forms.TextBox
    Friend WithEvents txtBelgiqueFRQtyClient As System.Windows.Forms.TextBox
    Friend WithEvents txtNetherlandsQtyClient As System.Windows.Forms.TextBox
    Friend WithEvents txtLuxembourgQtyClient As System.Windows.Forms.TextBox
    Friend WithEvents lblPickGroup As System.Windows.Forms.Label
    Friend WithEvents txtBelgiqueNL As System.Windows.Forms.TextBox
    Friend WithEvents txtBelgiqueFR As System.Windows.Forms.TextBox
    Friend WithEvents txtNetherlands As System.Windows.Forms.TextBox
    Friend WithEvents txtLuxembourg As System.Windows.Forms.TextBox
    Friend WithEvents LblBelgique As System.Windows.Forms.Label
    Friend WithEvents LblBelgiqueNL As System.Windows.Forms.Label
    Friend WithEvents lblNetherlands As System.Windows.Forms.Label
    Friend WithEvents LblLuxembourg As System.Windows.Forms.Label
    Friend WithEvents btnSetPickingGroup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoadOrders As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridListingOut As DevExpress.XtraGrid.GridControl
    Friend WithEvents Chkstock As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridViewListingOut As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colOrders_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCustomers_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldelivery_country As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProducts_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldvd_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBoxId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colpibox_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLanguage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colpickgroup As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldatepurchased As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colorders_type As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colpick_boxid As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colserie As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTitle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQtyStock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents NbUserLogistic As DevExpress.XtraEditors.SpinEdit


End Class
