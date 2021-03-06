Public Class frmEnveloppe_SS_Labels
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmbDVDStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents StyleRed As DevExpress.XtraEditors.StyleController
    Friend WithEvents StyleGreen As DevExpress.XtraEditors.StyleController
    Friend WithEvents StyleBlue As DevExpress.XtraEditors.StyleController
    Friend WithEvents btnPrintLabels As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrintSelected As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents objDS As DVDPost.dsEnvelopeLabels
    Friend WithEvents txtDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colmultishipment_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgroup_abc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx_orders_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx_products_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx_dvd_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx_box_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx_box_dvd_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coly_orders_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx_group_login_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx_ean128 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coly_products_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coly_dvd_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coly_box_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coly_group_login_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coly_box_dvd_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldelivery_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coly_ean128 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldelivery_street_address As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldelivery_city As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldelivery_country As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldelivery_postcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsecured_mail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_added As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collang_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPrintAllEnvelopes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrintSelectedEnveloppes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtLoginID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.objDS = New DVDPost.dsEnvelopeLabels
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colmultishipment_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colgroup_abc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colx_orders_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colx_products_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colx_dvd_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colx_box_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colx_box_dvd_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coly_orders_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colx_group_login_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colx_ean128 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coly_products_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coly_dvd_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coly_box_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coly_group_login_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coly_box_dvd_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldelivery_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coly_ean128 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldelivery_street_address = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldelivery_city = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldelivery_country = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldelivery_postcode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsecured_mail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldate_added = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collang_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbDVDStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtLoginID = New DevExpress.XtraEditors.TextEdit
        Me.btnPrintSelectedEnveloppes = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrintAllEnvelopes = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtDate = New DevExpress.XtraEditors.DateEdit
        Me.btnPrintSelected = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrintLabels = New DevExpress.XtraEditors.SimpleButton
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl
        Me.StyleRed = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.StyleGreen = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.StyleBlue = New DevExpress.XtraEditors.StyleController(Me.components)
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDVDStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtLoginID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuickSearch_Bar
        '
        Me.QuickSearch_Bar.DockCol = 8
        '
        'Filter_Bar
        '
        Me.Filter_Bar.DockCol = 7
        '
        'DefaultSet_Bar
        '
        Me.DefaultSet_Bar.DockCol = 6
        '
        'Misc_Bar2
        '
        Me.Misc_Bar2.DockCol = 3
        '
        'Main_Bar
        '
        Me.Main_Bar.DockCol = 4
        '
        'Misc_Bar
        '
        Me.Misc_Bar.DockCol = 5
        '
        'View_Bar
        '
        Me.View_Bar.DockCol = 2
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.objDS.envelope_labels_multishipment_det
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(6, 104)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbDVDStatus})
        Me.GridControl1.Size = New System.Drawing.Size(1114, 302)
        Me.GridControl1.TabIndex = 20
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsEnvelopeLabels"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colmultishipment_id, Me.colgroup_abc, Me.colx_orders_id, Me.colx_products_id, Me.colx_dvd_id, Me.colx_box_id, Me.colx_box_dvd_id, Me.coly_orders_id, Me.colx_group_login_id, Me.colx_ean128, Me.coly_products_id, Me.coly_dvd_id, Me.coly_box_id, Me.coly_group_login_id, Me.coly_box_dvd_id, Me.coldelivery_name, Me.coly_ean128, Me.coldelivery_street_address, Me.coldelivery_city, Me.coldelivery_country, Me.coldelivery_postcode, Me.colsecured_mail, Me.coldate_added, Me.collang_name})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(873, 335, 208, 191)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colx_group_login_id, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colmultishipment_id
        '
        Me.colmultishipment_id.Caption = "multishipment_id"
        Me.colmultishipment_id.FieldName = "multishipment_id"
        Me.colmultishipment_id.Name = "colmultishipment_id"
        Me.colmultishipment_id.Visible = True
        Me.colmultishipment_id.VisibleIndex = 0
        '
        'colgroup_abc
        '
        Me.colgroup_abc.Caption = "group_abc"
        Me.colgroup_abc.FieldName = "group_abc"
        Me.colgroup_abc.Name = "colgroup_abc"
        Me.colgroup_abc.Visible = True
        Me.colgroup_abc.VisibleIndex = 1
        '
        'colx_orders_id
        '
        Me.colx_orders_id.Caption = "x_orders_id"
        Me.colx_orders_id.FieldName = "x_orders_id"
        Me.colx_orders_id.Name = "colx_orders_id"
        Me.colx_orders_id.Visible = True
        Me.colx_orders_id.VisibleIndex = 2
        '
        'colx_products_id
        '
        Me.colx_products_id.Caption = "x_products_id"
        Me.colx_products_id.FieldName = "x_products_id"
        Me.colx_products_id.Name = "colx_products_id"
        Me.colx_products_id.Visible = True
        Me.colx_products_id.VisibleIndex = 3
        '
        'colx_dvd_id
        '
        Me.colx_dvd_id.Caption = "x_dvd_id"
        Me.colx_dvd_id.FieldName = "x_dvd_id"
        Me.colx_dvd_id.Name = "colx_dvd_id"
        Me.colx_dvd_id.Visible = True
        Me.colx_dvd_id.VisibleIndex = 4
        '
        'colx_box_id
        '
        Me.colx_box_id.Caption = "x_box_id"
        Me.colx_box_id.FieldName = "x_box_id"
        Me.colx_box_id.Name = "colx_box_id"
        Me.colx_box_id.Visible = True
        Me.colx_box_id.VisibleIndex = 5
        '
        'colx_box_dvd_id
        '
        Me.colx_box_dvd_id.Caption = "x_box_dvd_id"
        Me.colx_box_dvd_id.FieldName = "x_box_dvd_id"
        Me.colx_box_dvd_id.Name = "colx_box_dvd_id"
        Me.colx_box_dvd_id.Visible = True
        Me.colx_box_dvd_id.VisibleIndex = 6
        '
        'coly_orders_id
        '
        Me.coly_orders_id.Caption = "y_orders_id"
        Me.coly_orders_id.FieldName = "y_orders_id"
        Me.coly_orders_id.Name = "coly_orders_id"
        '
        'colx_group_login_id
        '
        Me.colx_group_login_id.Caption = "x_group_login_id"
        Me.colx_group_login_id.FieldName = "x_group_login_id"
        Me.colx_group_login_id.Name = "colx_group_login_id"
        Me.colx_group_login_id.Visible = True
        Me.colx_group_login_id.VisibleIndex = 7
        '
        'colx_ean128
        '
        Me.colx_ean128.Caption = "x_ean128"
        Me.colx_ean128.FieldName = "x_ean128"
        Me.colx_ean128.Name = "colx_ean128"
        Me.colx_ean128.Visible = True
        Me.colx_ean128.VisibleIndex = 8
        '
        'coly_products_id
        '
        Me.coly_products_id.Caption = "y_products_id"
        Me.coly_products_id.FieldName = "y_products_id"
        Me.coly_products_id.Name = "coly_products_id"
        '
        'coly_dvd_id
        '
        Me.coly_dvd_id.Caption = "y_dvd_id"
        Me.coly_dvd_id.FieldName = "y_dvd_id"
        Me.coly_dvd_id.Name = "coly_dvd_id"
        '
        'coly_box_id
        '
        Me.coly_box_id.Caption = "y_box_id"
        Me.coly_box_id.FieldName = "y_box_id"
        Me.coly_box_id.Name = "coly_box_id"
        '
        'coly_group_login_id
        '
        Me.coly_group_login_id.Caption = "y_group_login_id"
        Me.coly_group_login_id.FieldName = "y_group_login_id"
        Me.coly_group_login_id.Name = "coly_group_login_id"
        '
        'coly_box_dvd_id
        '
        Me.coly_box_dvd_id.Caption = "y_box_dvd_id"
        Me.coly_box_dvd_id.FieldName = "y_box_dvd_id"
        Me.coly_box_dvd_id.Name = "coly_box_dvd_id"
        '
        'coldelivery_name
        '
        Me.coldelivery_name.Caption = "delivery_name"
        Me.coldelivery_name.FieldName = "delivery_name"
        Me.coldelivery_name.Name = "coldelivery_name"
        Me.coldelivery_name.Visible = True
        Me.coldelivery_name.VisibleIndex = 9
        '
        'coly_ean128
        '
        Me.coly_ean128.Caption = "y_ean128"
        Me.coly_ean128.FieldName = "y_ean128"
        Me.coly_ean128.Name = "coly_ean128"
        Me.coly_ean128.Visible = True
        Me.coly_ean128.VisibleIndex = 10
        '
        'coldelivery_street_address
        '
        Me.coldelivery_street_address.Caption = "delivery_street_address"
        Me.coldelivery_street_address.FieldName = "delivery_street_address"
        Me.coldelivery_street_address.Name = "coldelivery_street_address"
        Me.coldelivery_street_address.Visible = True
        Me.coldelivery_street_address.VisibleIndex = 11
        '
        'coldelivery_city
        '
        Me.coldelivery_city.Caption = "delivery_city"
        Me.coldelivery_city.FieldName = "delivery_city"
        Me.coldelivery_city.Name = "coldelivery_city"
        Me.coldelivery_city.Visible = True
        Me.coldelivery_city.VisibleIndex = 12
        '
        'coldelivery_country
        '
        Me.coldelivery_country.Caption = "delivery_country"
        Me.coldelivery_country.FieldName = "delivery_country"
        Me.coldelivery_country.Name = "coldelivery_country"
        Me.coldelivery_country.Visible = True
        Me.coldelivery_country.VisibleIndex = 13
        '
        'coldelivery_postcode
        '
        Me.coldelivery_postcode.Caption = "delivery_postcode"
        Me.coldelivery_postcode.FieldName = "delivery_postcode"
        Me.coldelivery_postcode.Name = "coldelivery_postcode"
        Me.coldelivery_postcode.Visible = True
        Me.coldelivery_postcode.VisibleIndex = 14
        '
        'colsecured_mail
        '
        Me.colsecured_mail.Caption = "secured_mail"
        Me.colsecured_mail.FieldName = "secured_mail"
        Me.colsecured_mail.Name = "colsecured_mail"
        Me.colsecured_mail.Visible = True
        Me.colsecured_mail.VisibleIndex = 15
        '
        'coldate_added
        '
        Me.coldate_added.Caption = "date_added"
        Me.coldate_added.FieldName = "date_added"
        Me.coldate_added.Name = "coldate_added"
        Me.coldate_added.Visible = True
        Me.coldate_added.VisibleIndex = 16
        '
        'collang_name
        '
        Me.collang_name.Caption = "lang_name"
        Me.collang_name.FieldName = "lang_name"
        Me.collang_name.Name = "collang_name"
        Me.collang_name.Visible = True
        Me.collang_name.VisibleIndex = 17
        '
        'cmbDVDStatus
        '
        Me.cmbDVDStatus.AutoHeight = False
        Me.cmbDVDStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDVDStatus.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_dvd_status_id", "products_dvd_status_id", 135, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_dvd_status_name", "products_dvd_status_name", 140, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbDVDStatus.DisplayMember = "products_dvd_status_name"
        Me.cmbDVDStatus.Name = "cmbDVDStatus"
        Me.cmbDVDStatus.NullText = ""
        Me.cmbDVDStatus.ValueMember = "products_dvd_status_id"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txtLoginID)
        Me.PanelControl1.Controls.Add(Me.btnPrintSelectedEnveloppes)
        Me.PanelControl1.Controls.Add(Me.btnPrintAllEnvelopes)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtDate)
        Me.PanelControl1.Controls.Add(Me.btnPrintSelected)
        Me.PanelControl1.Controls.Add(Me.btnPrintLabels)
        Me.PanelControl1.Controls.Add(Me.btnSearch)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 26)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1120, 78)
        Me.PanelControl1.TabIndex = 30
        Me.PanelControl1.Text = "PanelControl1"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 40)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.TabIndex = 39
        Me.LabelControl2.Text = "Login ID"
        '
        'txtLoginID
        '
        Me.txtLoginID.Location = New System.Drawing.Point(96, 40)
        Me.txtLoginID.Name = "txtLoginID"
        Me.txtLoginID.TabIndex = 38
        '
        'btnPrintSelectedEnveloppes
        '
        Me.btnPrintSelectedEnveloppes.Location = New System.Drawing.Point(432, 48)
        Me.btnPrintSelectedEnveloppes.Name = "btnPrintSelectedEnveloppes"
        Me.btnPrintSelectedEnveloppes.Size = New System.Drawing.Size(144, 23)
        Me.btnPrintSelectedEnveloppes.TabIndex = 37
        Me.btnPrintSelectedEnveloppes.Text = "Print Selected Enveloppes"
        Me.btnPrintSelectedEnveloppes.Visible = False
        '
        'btnPrintAllEnvelopes
        '
        Me.btnPrintAllEnvelopes.Location = New System.Drawing.Point(432, 16)
        Me.btnPrintAllEnvelopes.Name = "btnPrintAllEnvelopes"
        Me.btnPrintAllEnvelopes.Size = New System.Drawing.Size(144, 23)
        Me.btnPrintAllEnvelopes.TabIndex = 36
        Me.btnPrintAllEnvelopes.Text = "Print ALL Enveloppes"
        Me.btnPrintAllEnvelopes.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 16)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.TabIndex = 35
        Me.LabelControl1.Text = "Date"
        '
        'txtDate
        '
        Me.txtDate.EditValue = Nothing
        Me.txtDate.Location = New System.Drawing.Point(96, 16)
        Me.txtDate.Name = "txtDate"
        '
        'txtDate.Properties
        '
        Me.txtDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDate.TabIndex = 34
        '
        'btnPrintSelected
        '
        Me.btnPrintSelected.Location = New System.Drawing.Point(312, 48)
        Me.btnPrintSelected.Name = "btnPrintSelected"
        Me.btnPrintSelected.Size = New System.Drawing.Size(96, 23)
        Me.btnPrintSelected.TabIndex = 32
        Me.btnPrintSelected.Text = "Print Selected "
        '
        'btnPrintLabels
        '
        Me.btnPrintLabels.Location = New System.Drawing.Point(312, 16)
        Me.btnPrintLabels.Name = "btnPrintLabels"
        Me.btnPrintLabels.Size = New System.Drawing.Size(96, 23)
        Me.btnPrintLabels.TabIndex = 31
        Me.btnPrintLabels.Text = "Print ALL Labels"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(216, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.TabIndex = 27
        Me.btnSearch.Text = "Search"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 104)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(6, 302)
        Me.SplitterControl1.TabIndex = 31
        Me.SplitterControl1.TabStop = False
        '
        'StyleRed
        '
        Me.StyleRed.Appearance.BackColor = System.Drawing.Color.Red
        Me.StyleRed.Appearance.Options.UseBackColor = True
        '
        'StyleGreen
        '
        Me.StyleGreen.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(0, Byte))
        Me.StyleGreen.Appearance.Options.UseBackColor = True
        '
        'StyleBlue
        '
        Me.StyleBlue.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.StyleBlue.Appearance.Options.UseBackColor = True
        '
        'frmEnveloppe_SS_Labels
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1120, 406)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmEnveloppe_SS_Labels"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        Me.Controls.SetChildIndex(Me.SplitterControl1, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDVDStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtLoginID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Pos_ID As Integer = 1
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim _str As String
        Dim _LoginID As Integer
        If txtLoginID.EditValue & "" = "" Then
            _LoginID = -1
        Else
            If Not IsNumeric(txtLoginID.EditValue) Then
                MsgBox("Login ID must be a Number", MsgBoxStyle.Critical)
                Exit Sub
            Else
                _LoginID = txtLoginID.EditValue
            End If
        End If

        objDS.Tables("envelope_labels").Clear()
        _str = "date("

        Dim _SQLTXt As String
        If _LoginID = -1 Then
            _SQLTXt = " SELECT * FROM envelope_labels L LEFT join orders O on O.orders_id = L.orders_ID WHERE " & _
                                    " label_status = 1 and DATE_FORMAT(date_added, '%Y/%m/%d') = date_format('" & _
                                    txtDate.DateTime.Year & "/" & txtDate.DateTime.Month & "/" & txtDate.DateTime.Day & "', '%Y/%m/%d')"
        Else
            _SQLTXt = " SELECT * FROM envelope_labels L LEFT join orders O on O.orders_id = L.orders_ID WHERE " & _
                                    " group_id = " & _LoginID & " AND label_status = 1 and DATE_FORMAT(date_added, '%Y/%m/%d') = date_format('" & _
                                    txtDate.DateTime.Year & "/" & txtDate.DateTime.Month & "/" & txtDate.DateTime.Day & "', '%Y/%m/%d')"
        End If
        BKGlobal.Cls1.FillDataSet(objDS.Tables("envelope_labels"), _SQLTXt)

        Dim _row, _labelRow As DataRow
        'Dim _DS As New dsEnvelopeLabels
        Dim _i As Integer
        objDS.Tables("envelope_labels_multishipment_det").Clear()
        For Each _row In objDS.Tables("envelope_labels").Rows
            AddLabelRow(_row, objDS)
        Next

    End Sub

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDate.EditValue = Today
    End Sub

    Private Sub btnPrintLabels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintLabels.Click
        Dim _rpt As New rptSSEnvLabels
        _rpt.objDS = objDS
        _rpt.DataMember = ""
        _rpt.DataSource = objDS.Tables("envelope_labels_multishipment_det")
        _rpt.ShowPreview()
    End Sub
    Private Sub btnPrintSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintSelected.Click
        Dim _row, _row1 As DataRow
        Dim _DS As New dsEnvelopeLabels
        Dim _i As Integer
        _DS.Tables("envelope_labels_multishipment_det").Clear()
        For Each _i In GridView1.GetSelectedRows
            _row = GridView1.GetDataRow(_i)
            _row1 = _DS.Tables("envelope_labels_multishipment_det").NewRow
            _row1.ItemArray = _row.ItemArray
            _DS.Tables("envelope_labels_multishipment_det").Rows.Add(_row1)
        Next
        Dim _rpt As New rptSSEnvLabels
        _rpt.objDS = _DS
        _rpt.DataMember = ""
        _rpt.DataSource = _DS.Tables("envelope_labels_multishipment_det")
        _rpt.ShowPreview()

    End Sub
    Private Sub AddLabelRow(ByVal _row As DataRow, ByVal _DS As DataSet)
        Dim _labelRow As DataRow
        _labelRow = _DS.Tables("envelope_labels_multishipment_det").Rows.Find(New Object() {_row.Item("envelope_labels_id")})
        If IsNothing(_labelRow) Then
            _labelRow = _DS.Tables("envelope_labels_multishipment_det").NewRow
            _labelRow.Item("multishipment_id") = _row.Item("envelope_labels_id")
            _labelRow.Item("delivery_name") = _row.Item("delivery_name")
            _labelRow.Item("date_added") = _row.Item("date_added")
            _labelRow.Item("delivery_street_address") = _row.Item("delivery_street_address")
            _labelRow.Item("delivery_city") = _row.Item("delivery_city")
            _labelRow.Item("delivery_country") = _row.Item("delivery_country")
            _labelRow.Item("delivery_postcode") = _row.Item("delivery_postcode")
            _labelRow.Item("lang_name") = BKGlobal.ExecuteFindFieldValue("name", "SELECT L.name FROM customers_info CI left join languages L on CI.customers_language = L.languages_id WHERE CI.customers_info_id = " & _row.Item("customers_id"))
            If _row.Item("secured_mail") > 0 Then
                _labelRow.Item("secured_mail") = "Secured Mail"
            Else
                _labelRow.Item("secured_mail") = ""
            End If
            _labelRow.Item("group_abc") = "a" '_row.Item("group_abc")
            _DS.Tables("envelope_labels_multishipment_det").Rows.Add(_labelRow)
        End If
        _labelRow.BeginEdit()
        _labelRow.Item("X_orders_id") = _row.Item("orders_id")
        _labelRow.Item("X_products_id") = _row.Item("products_id")
        _labelRow.Item("X_dvd_id") = _row.Item("dvd_id")
        _labelRow.Item("X_box_id") = _row.Item("box_id")
        _labelRow.Item("X_box_dvd_id") = _row.Item("box_dvd_id")
        _labelRow.Item("X_group_login_id") = _row.Item("group_id")
        _labelRow.Item("X_ean128") = _row.Item("ean128")
        _labelRow.EndEdit()
    End Sub
    'Private Sub btnPrintAllEnvelopes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAllEnvelopes.Click
    '    Dim _rpt As New rptSSEnveloppes
    '    _rpt.objDS = objDS
    '    _rpt.DataMember = ""

    '    _rpt.ShowPreview()
    'End Sub

    'Private Sub btnPrintSelectedEnveloppes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintSelectedEnveloppes.Click
    '    Dim _row, _row1 As DataRow
    '    Dim _DS As New dsEnvelopeLabels
    '    Dim _i As Integer
    '    _DS.Tables("envelope_labels_multishipment_det").Clear()
    '    For Each _i In GridView1.GetSelectedRows
    '        _row = GridView1.GetDataRow(_i)
    '        _row1 = _DS.Tables("envelope_labels_multishipment_det").NewRow
    '        _row1.ItemArray = _row.ItemArray
    '        _DS.Tables("envelope_labels_multishipment_det").Rows.Add(_row1)
    '    Next
    '    Dim _rpt As New rptSSEnveloppes
    '    _rpt.objDS = _DS
    '    _rpt.DataMember = ""
    '    _rpt.DataSource = _DS.Tables("envelope_labels_multishipment_det")
    '    _rpt.ShowPreview()
    'End Sub

    Private Sub LabelControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl1.Click

    End Sub

    Private Sub btnPrintAllEnvelopes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAllEnvelopes.Click

    End Sub
End Class
