Imports System.Windows.Forms.Application
Public Class frmProcessOUT
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
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmbDVDStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBarCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProducts_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDVD_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents StyleRed As DevExpress.XtraEditors.StyleController
    Friend WithEvents StyleGreen As DevExpress.XtraEditors.StyleController
    Friend WithEvents StyleBlue As DevExpress.XtraEditors.StyleController
    Friend WithEvents txtINFO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents objDS As DVDPostLib.dsEnvelopeLabels
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
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrintSelectedEnveloppes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrintAllEnvelopes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFindBarCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictXY As System.Windows.Forms.PictureBox
    Friend WithEvents btnResetBarCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrintSelectedEnveloppesFLAT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrintAllEnvelopesFLAT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkForcedStatus As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnUnlock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtGroupId As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LblGroupId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnProcessXml As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.objDS = New DVDPostLib.dsEnvelopeLabels
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
        Me.btnProcessXml = New DevExpress.XtraEditors.SimpleButton
        Me.LblGroupId = New DevExpress.XtraEditors.LabelControl
        Me.txtGroupId = New DevExpress.XtraEditors.SpinEdit
        Me.btnUnlock = New DevExpress.XtraEditors.SimpleButton
        Me.chkForcedStatus = New DevExpress.XtraEditors.CheckEdit
        Me.btnPrintSelectedEnveloppesFLAT = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrintAllEnvelopesFLAT = New DevExpress.XtraEditors.SimpleButton
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton
        Me.btnImport = New DevExpress.XtraEditors.SimpleButton
        Me.btnResetBarCode = New DevExpress.XtraEditors.SimpleButton
        Me.PictXY = New System.Windows.Forms.PictureBox
        Me.btnOK1 = New DevExpress.XtraEditors.SimpleButton
        Me.btnFindBarCode = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrintSelectedEnveloppes = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrintAllEnvelopes = New DevExpress.XtraEditors.SimpleButton
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton
        Me.txtINFO = New DevExpress.XtraEditors.TextEdit
        Me.txtDVD_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtProducts_id = New DevExpress.XtraEditors.TextEdit
        Me.txtBarCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl
        Me.StyleRed = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.StyleGreen = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.StyleBlue = New DevExpress.XtraEditors.StyleController(Me.components)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDVDStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtGroupId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkForcedStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictXY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtINFO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Product ID"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.objDS.envelope_labels_multishipment_det
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.FormsUseDefaultLookAndFeel = False
        Me.GridControl1.Location = New System.Drawing.Point(6, 132)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbDVDStatus})
        Me.GridControl1.Size = New System.Drawing.Size(1106, 258)
        Me.GridControl1.TabIndex = 20
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsEnvelopeLabels"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colmultishipment_id, Me.colgroup_abc, Me.colx_orders_id, Me.colx_products_id, Me.colx_dvd_id, Me.colx_box_id, Me.colx_box_dvd_id, Me.coly_orders_id, Me.colx_group_login_id, Me.colx_ean128, Me.coly_products_id, Me.coly_dvd_id, Me.coly_box_id, Me.coly_group_login_id, Me.coly_box_dvd_id, Me.coldelivery_name, Me.coly_ean128, Me.coldelivery_street_address, Me.coldelivery_city, Me.coldelivery_country, Me.coldelivery_postcode, Me.colsecured_mail, Me.coldate_added, Me.collang_name})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(873, 335, 208, 191)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colmultishipment_id
        '
        Me.colmultishipment_id.Caption = "multishipment_id"
        Me.colmultishipment_id.FieldName = "multishipment_id"
        Me.colmultishipment_id.Name = "colmultishipment_id"
        Me.colmultishipment_id.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        '
        'colgroup_abc
        '
        Me.colgroup_abc.Caption = "group_abc"
        Me.colgroup_abc.FieldName = "group_abc"
        Me.colgroup_abc.Name = "colgroup_abc"
        '
        'colx_orders_id
        '
        Me.colx_orders_id.Caption = "x_orders_id"
        Me.colx_orders_id.FieldName = "x_orders_id"
        Me.colx_orders_id.Name = "colx_orders_id"
        Me.colx_orders_id.Visible = True
        Me.colx_orders_id.VisibleIndex = 0
        Me.colx_orders_id.Width = 78
        '
        'colx_products_id
        '
        Me.colx_products_id.Caption = "x_products_id"
        Me.colx_products_id.FieldName = "x_products_id"
        Me.colx_products_id.Name = "colx_products_id"
        Me.colx_products_id.Visible = True
        Me.colx_products_id.VisibleIndex = 1
        Me.colx_products_id.Width = 78
        '
        'colx_dvd_id
        '
        Me.colx_dvd_id.Caption = "x_dvd_id"
        Me.colx_dvd_id.FieldName = "x_dvd_id"
        Me.colx_dvd_id.Name = "colx_dvd_id"
        Me.colx_dvd_id.Visible = True
        Me.colx_dvd_id.VisibleIndex = 2
        Me.colx_dvd_id.Width = 78
        '
        'colx_box_id
        '
        Me.colx_box_id.Caption = "x_box_id"
        Me.colx_box_id.FieldName = "x_box_id"
        Me.colx_box_id.Name = "colx_box_id"
        Me.colx_box_id.Width = 78
        '
        'colx_box_dvd_id
        '
        Me.colx_box_dvd_id.Caption = "x_box_dvd_id"
        Me.colx_box_dvd_id.FieldName = "x_box_dvd_id"
        Me.colx_box_dvd_id.Name = "colx_box_dvd_id"
        Me.colx_box_dvd_id.Width = 93
        '
        'coly_orders_id
        '
        Me.coly_orders_id.Caption = "y_orders_id"
        Me.coly_orders_id.FieldName = "y_orders_id"
        Me.coly_orders_id.Name = "coly_orders_id"
        Me.coly_orders_id.Visible = True
        Me.coly_orders_id.VisibleIndex = 3
        Me.coly_orders_id.Width = 77
        '
        'colx_group_login_id
        '
        Me.colx_group_login_id.Caption = "x_group_login_id"
        Me.colx_group_login_id.FieldName = "x_group_login_id"
        Me.colx_group_login_id.Name = "colx_group_login_id"
        Me.colx_group_login_id.Width = 77
        '
        'colx_ean128
        '
        Me.colx_ean128.Caption = "x_ean128"
        Me.colx_ean128.FieldName = "x_ean128"
        Me.colx_ean128.Name = "colx_ean128"
        Me.colx_ean128.Width = 77
        '
        'coly_products_id
        '
        Me.coly_products_id.Caption = "y_products_id"
        Me.coly_products_id.FieldName = "y_products_id"
        Me.coly_products_id.Name = "coly_products_id"
        Me.coly_products_id.Visible = True
        Me.coly_products_id.VisibleIndex = 4
        Me.coly_products_id.Width = 77
        '
        'coly_dvd_id
        '
        Me.coly_dvd_id.Caption = "y_dvd_id"
        Me.coly_dvd_id.FieldName = "y_dvd_id"
        Me.coly_dvd_id.Name = "coly_dvd_id"
        Me.coly_dvd_id.Visible = True
        Me.coly_dvd_id.VisibleIndex = 5
        Me.coly_dvd_id.Width = 77
        '
        'coly_box_id
        '
        Me.coly_box_id.Caption = "y_box_id"
        Me.coly_box_id.FieldName = "y_box_id"
        Me.coly_box_id.Name = "coly_box_id"
        Me.coly_box_id.Width = 77
        '
        'coly_group_login_id
        '
        Me.coly_group_login_id.Caption = "y_group_login_id"
        Me.coly_group_login_id.FieldName = "y_group_login_id"
        Me.coly_group_login_id.Name = "coly_group_login_id"
        Me.coly_group_login_id.Width = 77
        '
        'coly_box_dvd_id
        '
        Me.coly_box_dvd_id.Caption = "y_box_dvd_id"
        Me.coly_box_dvd_id.FieldName = "y_box_dvd_id"
        Me.coly_box_dvd_id.Name = "coly_box_dvd_id"
        Me.coly_box_dvd_id.Width = 77
        '
        'coldelivery_name
        '
        Me.coldelivery_name.Caption = "delivery_name"
        Me.coldelivery_name.FieldName = "delivery_name"
        Me.coldelivery_name.Name = "coldelivery_name"
        Me.coldelivery_name.Visible = True
        Me.coldelivery_name.VisibleIndex = 6
        Me.coldelivery_name.Width = 77
        '
        'coly_ean128
        '
        Me.coly_ean128.Caption = "y_ean128"
        Me.coly_ean128.FieldName = "y_ean128"
        Me.coly_ean128.Name = "coly_ean128"
        Me.coly_ean128.Width = 77
        '
        'coldelivery_street_address
        '
        Me.coldelivery_street_address.Caption = "delivery_street_address"
        Me.coldelivery_street_address.FieldName = "delivery_street_address"
        Me.coldelivery_street_address.Name = "coldelivery_street_address"
        Me.coldelivery_street_address.Visible = True
        Me.coldelivery_street_address.VisibleIndex = 7
        Me.coldelivery_street_address.Width = 77
        '
        'coldelivery_city
        '
        Me.coldelivery_city.Caption = "delivery_city"
        Me.coldelivery_city.FieldName = "delivery_city"
        Me.coldelivery_city.Name = "coldelivery_city"
        Me.coldelivery_city.Visible = True
        Me.coldelivery_city.VisibleIndex = 8
        Me.coldelivery_city.Width = 77
        '
        'coldelivery_country
        '
        Me.coldelivery_country.Caption = "delivery_country"
        Me.coldelivery_country.FieldName = "delivery_country"
        Me.coldelivery_country.Name = "coldelivery_country"
        Me.coldelivery_country.Visible = True
        Me.coldelivery_country.VisibleIndex = 9
        Me.coldelivery_country.Width = 77
        '
        'coldelivery_postcode
        '
        Me.coldelivery_postcode.Caption = "delivery_postcode"
        Me.coldelivery_postcode.FieldName = "delivery_postcode"
        Me.coldelivery_postcode.Name = "coldelivery_postcode"
        Me.coldelivery_postcode.Visible = True
        Me.coldelivery_postcode.VisibleIndex = 10
        Me.coldelivery_postcode.Width = 77
        '
        'colsecured_mail
        '
        Me.colsecured_mail.Caption = "secured_mail"
        Me.colsecured_mail.FieldName = "secured_mail"
        Me.colsecured_mail.Name = "colsecured_mail"
        Me.colsecured_mail.Width = 77
        '
        'coldate_added
        '
        Me.coldate_added.Caption = "date_added"
        Me.coldate_added.FieldName = "date_added"
        Me.coldate_added.Name = "coldate_added"
        Me.coldate_added.Width = 77
        '
        'collang_name
        '
        Me.collang_name.Caption = "lang_name"
        Me.collang_name.FieldName = "lang_name"
        Me.collang_name.Name = "collang_name"
        Me.collang_name.Visible = True
        Me.collang_name.VisibleIndex = 11
        Me.collang_name.Width = 91
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
        Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl1.Controls.Add(Me.btnProcessXml)
        Me.PanelControl1.Controls.Add(Me.LblGroupId)
        Me.PanelControl1.Controls.Add(Me.txtGroupId)
        Me.PanelControl1.Controls.Add(Me.btnUnlock)
        Me.PanelControl1.Controls.Add(Me.chkForcedStatus)
        Me.PanelControl1.Controls.Add(Me.btnPrintSelectedEnveloppesFLAT)
        Me.PanelControl1.Controls.Add(Me.btnPrintAllEnvelopesFLAT)
        Me.PanelControl1.Controls.Add(Me.btnExport)
        Me.PanelControl1.Controls.Add(Me.btnImport)
        Me.PanelControl1.Controls.Add(Me.btnResetBarCode)
        Me.PanelControl1.Controls.Add(Me.PictXY)
        Me.PanelControl1.Controls.Add(Me.btnOK1)
        Me.PanelControl1.Controls.Add(Me.btnFindBarCode)
        Me.PanelControl1.Controls.Add(Me.btnPrintSelectedEnveloppes)
        Me.PanelControl1.Controls.Add(Me.btnPrintAllEnvelopes)
        Me.PanelControl1.Controls.Add(Me.btnClear)
        Me.PanelControl1.Controls.Add(Me.txtINFO)
        Me.PanelControl1.Controls.Add(Me.txtDVD_ID)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtProducts_id)
        Me.PanelControl1.Controls.Add(Me.txtBarCode)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 30)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1112, 102)
        Me.PanelControl1.TabIndex = 30
        '
        'btnProcessXml
        '
        Me.btnProcessXml.Location = New System.Drawing.Point(862, 36)
        Me.btnProcessXml.Name = "btnProcessXml"
        Me.btnProcessXml.Size = New System.Drawing.Size(80, 24)
        Me.btnProcessXml.TabIndex = 63
        Me.btnProcessXml.Text = "Process XML"
        Me.btnProcessXml.Visible = False
        '
        'LblGroupId
        '
        Me.LblGroupId.Location = New System.Drawing.Point(883, 69)
        Me.LblGroupId.Name = "LblGroupId"
        Me.LblGroupId.Size = New System.Drawing.Size(43, 13)
        Me.LblGroupId.TabIndex = 62
        Me.LblGroupId.Text = "Group ID"
        '
        'txtGroupId
        '
        Me.txtGroupId.CausesValidation = False
        Me.txtGroupId.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtGroupId.Location = New System.Drawing.Point(777, 61)
        Me.txtGroupId.Name = "txtGroupId"
        Me.txtGroupId.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupId.Properties.Appearance.Options.UseFont = True
        Me.txtGroupId.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtGroupId.Properties.DisplayFormat.FormatString = "N0"
        Me.txtGroupId.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtGroupId.Properties.EditFormat.FormatString = "N0"
        Me.txtGroupId.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtGroupId.Properties.IsFloatValue = False
        Me.txtGroupId.Properties.Mask.EditMask = "N00"
        Me.txtGroupId.Properties.MaxValue = New Decimal(New Integer() {15, 0, 0, 0})
        Me.txtGroupId.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtGroupId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtGroupId.Size = New System.Drawing.Size(100, 26)
        Me.txtGroupId.TabIndex = 61
        '
        'btnUnlock
        '
        Me.btnUnlock.Appearance.BackColor = System.Drawing.Color.White
        Me.btnUnlock.Appearance.BackColor2 = System.Drawing.Color.White
        Me.btnUnlock.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnlock.Appearance.Options.UseBackColor = True
        Me.btnUnlock.Appearance.Options.UseFont = True
        Me.btnUnlock.Location = New System.Drawing.Point(8, 8)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(75, 64)
        Me.btnUnlock.TabIndex = 50
        Me.btnUnlock.Text = "unlock"
        Me.btnUnlock.Visible = False
        '
        'chkForcedStatus
        '
        Me.chkForcedStatus.Location = New System.Drawing.Point(895, 12)
        Me.chkForcedStatus.Name = "chkForcedStatus"
        Me.chkForcedStatus.Properties.Caption = "Forced Status"
        Me.chkForcedStatus.Size = New System.Drawing.Size(103, 19)
        Me.chkForcedStatus.TabIndex = 49
        '
        'btnPrintSelectedEnveloppesFLAT
        '
        Me.btnPrintSelectedEnveloppesFLAT.Location = New System.Drawing.Point(664, 32)
        Me.btnPrintSelectedEnveloppesFLAT.Name = "btnPrintSelectedEnveloppesFLAT"
        Me.btnPrintSelectedEnveloppesFLAT.Size = New System.Drawing.Size(144, 23)
        Me.btnPrintSelectedEnveloppesFLAT.TabIndex = 48
        Me.btnPrintSelectedEnveloppesFLAT.Text = "Print Selected "
        Me.btnPrintSelectedEnveloppesFLAT.Visible = False
        '
        'btnPrintAllEnvelopesFLAT
        '
        Me.btnPrintAllEnvelopesFLAT.Location = New System.Drawing.Point(664, 8)
        Me.btnPrintAllEnvelopesFLAT.Name = "btnPrintAllEnvelopesFLAT"
        Me.btnPrintAllEnvelopesFLAT.Size = New System.Drawing.Size(144, 23)
        Me.btnPrintAllEnvelopesFLAT.TabIndex = 47
        Me.btnPrintAllEnvelopesFLAT.Text = "Print "
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(814, 8)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(52, 23)
        Me.btnExport.TabIndex = 46
        Me.btnExport.Text = "Save"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(814, 32)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(52, 23)
        Me.btnImport.TabIndex = 45
        Me.btnImport.Text = "Load"
        '
        'btnResetBarCode
        '
        Me.btnResetBarCode.Location = New System.Drawing.Point(484, 8)
        Me.btnResetBarCode.Name = "btnResetBarCode"
        Me.btnResetBarCode.Size = New System.Drawing.Size(62, 23)
        Me.btnResetBarCode.TabIndex = 44
        Me.btnResetBarCode.Text = "Reset Bar"
        Me.btnResetBarCode.Visible = False
        '
        'PictXY
        '
        Me.PictXY.BackColor = System.Drawing.Color.Transparent
        Me.PictXY.Location = New System.Drawing.Point(16, 56)
        Me.PictXY.Name = "PictXY"
        Me.PictXY.Size = New System.Drawing.Size(64, 40)
        Me.PictXY.TabIndex = 43
        Me.PictXY.TabStop = False
        '
        'btnOK1
        '
        Me.btnOK1.Location = New System.Drawing.Point(398, 8)
        Me.btnOK1.Name = "btnOK1"
        Me.btnOK1.Size = New System.Drawing.Size(80, 23)
        Me.btnOK1.TabIndex = 42
        Me.btnOK1.Text = "OK"
        '
        'btnFindBarCode
        '
        Me.btnFindBarCode.Location = New System.Drawing.Point(398, 32)
        Me.btnFindBarCode.Name = "btnFindBarCode"
        Me.btnFindBarCode.Size = New System.Drawing.Size(80, 23)
        Me.btnFindBarCode.TabIndex = 1
        Me.btnFindBarCode.Text = "Find Bar Code"
        '
        'btnPrintSelectedEnveloppes
        '
        Me.btnPrintSelectedEnveloppes.Location = New System.Drawing.Point(552, 32)
        Me.btnPrintSelectedEnveloppes.Name = "btnPrintSelectedEnveloppes"
        Me.btnPrintSelectedEnveloppes.Size = New System.Drawing.Size(106, 23)
        Me.btnPrintSelectedEnveloppes.TabIndex = 41
        Me.btnPrintSelectedEnveloppes.Text = "Print Selected Env."
        Me.btnPrintSelectedEnveloppes.Visible = False
        '
        'btnPrintAllEnvelopes
        '
        Me.btnPrintAllEnvelopes.Location = New System.Drawing.Point(552, 8)
        Me.btnPrintAllEnvelopes.Name = "btnPrintAllEnvelopes"
        Me.btnPrintAllEnvelopes.Size = New System.Drawing.Size(106, 23)
        Me.btnPrintAllEnvelopes.TabIndex = 40
        Me.btnPrintAllEnvelopes.Text = "Print ALL Env."
        Me.btnPrintAllEnvelopes.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(484, 32)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(62, 23)
        Me.btnClear.TabIndex = 35
        Me.btnClear.Text = "Clear"
        Me.btnClear.Visible = False
        '
        'txtINFO
        '
        Me.txtINFO.EditValue = ""
        Me.txtINFO.Location = New System.Drawing.Point(88, 64)
        Me.txtINFO.Name = "txtINFO"
        Me.txtINFO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtINFO.Properties.Appearance.ForeColor = System.Drawing.Color.Firebrick
        Me.txtINFO.Properties.Appearance.Options.UseFont = True
        Me.txtINFO.Properties.Appearance.Options.UseForeColor = True
        Me.txtINFO.Size = New System.Drawing.Size(672, 23)
        Me.txtINFO.TabIndex = 34
        '
        'txtDVD_ID
        '
        Me.txtDVD_ID.Enabled = False
        Me.txtDVD_ID.Location = New System.Drawing.Point(296, 32)
        Me.txtDVD_ID.Name = "txtDVD_ID"
        Me.txtDVD_ID.Properties.ReadOnly = True
        Me.txtDVD_ID.Size = New System.Drawing.Size(96, 20)
        Me.txtDVD_ID.TabIndex = 29
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(216, 32)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl5.TabIndex = 28
        Me.LabelControl5.Text = "DVD ID"
        '
        'txtProducts_id
        '
        Me.txtProducts_id.Enabled = False
        Me.txtProducts_id.Location = New System.Drawing.Point(88, 32)
        Me.txtProducts_id.Name = "txtProducts_id"
        Me.txtProducts_id.Properties.ReadOnly = True
        Me.txtProducts_id.Size = New System.Drawing.Size(96, 20)
        Me.txtProducts_id.TabIndex = 24
        '
        'txtBarCode
        '
        Me.txtBarCode.Location = New System.Drawing.Point(88, 8)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(304, 20)
        Me.txtBarCode.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(8, 8)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 23
        Me.LabelControl2.Text = "BareCode"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 132)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(6, 258)
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
        Me.StyleGreen.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StyleGreen.Appearance.Options.UseBackColor = True
        '
        'StyleBlue
        '
        Me.StyleBlue.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StyleBlue.Appearance.Options.UseBackColor = True
        '
        'frmProcessOUT
        '
        Me.AcceptButton = Me.btnOK1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1112, 390)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmProcessOUT"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        Me.Controls.SetChildIndex(Me.SplitterControl1, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDVDStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtGroupId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkForcedStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictXY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtINFO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub

    Dim CustView As DataView
    Dim Y_Pos As Int16 = 0
    Dim X_Pos As Int16 = 0
    Dim _CheckProcess As ClsCheckProcessLogistic

    Private Sub initCheckProcess()
        _CheckProcess = New ClsCheckProcessLogistic()
        _CheckProcess.txtInfo = txtINFO
        _CheckProcess.sessionInfo = SessionInfo
        _CheckProcess.objDS = New dsProducts
        _CheckProcess.btnSearch = Nothing
        _CheckProcess.txtbarcode = txtBarCode
        _CheckProcess.btnUnlock = btnUnlock
        _CheckProcess.Ctrlbox_id = Nothing
        objDS.EnforceConstraints = False
    End Sub

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        GridControl1.ContextMenuStrip = menuStrip

        CustView = New DataView(objDS.Tables("envelope_labels_multishipment_det"), " ", "customers_id", DataViewRowState.CurrentRows)
        txtBarCode.Focus()
        initCheckProcess()
        ' CreateOrderManually()
    End Sub
    ' Error lors du remasterisation du process out oublie de changer le status de l'order et l'historique
    ' c'ette procedure sert a remettre cela en ordre
    'Private Sub CreateOrderManually()

    '    Dim sql As String
    '    Dim dt As DataTable

    '    Dim dsP As New dsProducts
    '    sql = "select o.orders_id,op.products_id,op.products_dvd " & _
    '          " from orders o " & _
    '          " join orders_products op on o.orders_id = op.orders_id " & _
    '          " join (select products_id,products_dvd_id from products_dvd_state_history pdsh where date(date_added) = date(now()) and type_process = 3) hist " & _
    '          " on hist.products_id = op.products_id and hist.products_dvd_id = op.products_dvd " & _
    '          " where date(o.date_purchased) = '2011-02-24' and o.orders_status = 1"
    '    dt = DvdPostData.clsConnection.FillDataSet(sql)

    '    Dim clsp As clsProduct_DVD

    '    For Each dr As DataRow In dt.Rows
    '        clsp = New clsProduct_DVD(SessionInfo, dsP, dr("products_id"), dr("products_dvd"))
    '        clsp.setOrderAsExpedited(DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_EXPEDITED, dr("orders_id"), DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_EXPEDITED)
    '    Next




    'End Sub
    Public Sub BarCode_OK()

        Dim _OrderRow As DataRow
        Dim objProductDVD As clsProduct_DVD
        Dim box_id As Integer

        If txtINFO.Text <> "" Then
            MsgBox("click unlock button ", MsgBoxStyle.Exclamation)
            _CheckProcess.DisableBarCode()
            Exit Sub
        End If
        If txtGroupId.EditValue = 0 Then
            txtINFO.Text = "choose a group ID before scan dvd  !!"
            _CheckProcess.DisableBarCode()
        End If
        objProductDVD = _CheckProcess.GetCodeBar(txtBarCode.Text)
        If objProductDVD Is Nothing Then Return

        txtProducts_id.EditValue = objProductDVD.ProductsID
        txtDVD_ID.EditValue = objProductDVD.DvdId

        Dim order_status As Integer = -1
        _CheckProcess.ChkAlert(objProductDVD)

        If txtINFO.Text = "" Then
            _OrderRow = objProductDVD.GetlastOrder(objProductDVD.ProductsID, objProductDVD.DvdId)

            If IsNothing(_OrderRow) Then ' pas d'order pour ce dvd 
                txtINFO.Text = "Impossible de trouver une commande pour ce DVD. A remettre en stock."
            Else
                If _OrderRow("orders_status") = DvdPostData.clsOdersStatusHistory.OrderStatusNew.READY_FOR_EXPEDITION Or _
                    (DvdPostData.clsOdersStatusHistory.OrderStatusNew.EXPEDITED And chkForcedStatus.Checked) Then
                    If _OrderRow("pick_boxid") Is DBNull.Value Then
                        txtINFO.Text = "No mid , no pickin "
                    Else

                        If (_OrderRow("pick_boxid")) <> txtGroupId.EditValue Then
                            txtINFO.Text = "the dvd must in group box " & _OrderRow("pick_boxid")
                        Else

                            AddLabelRow(_OrderRow, objDS)
                            objProductDVD.setOrderAsExpedited(_OrderRow("orders_id"), _OrderRow("orders_status"))

                            'Dim box_id As Integer
                            box_id = DvdPostData.clsProductDvd.BOXTYPE.OUT - _OrderRow("pick_boxid")
                            objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK, _
                                                                  box_id, 1, "OUT - OK", _
                                                                  DvdPostData.ClsProducts_dvd_state.state.OUT, _
                                                                  DvdPostData.clsProductDvd.INOUT.OUT, _
                                                                  _OrderRow("pick_boxid"), _
                                                                  DvdPostData.clsProductDvd.INOUT.OUT)
                        End If
                    End If

                Else
                    txtINFO.Text = "Impossible d'expedier ce dvd : Date de la commande : " & _OrderRow("date_purchased")

                End If
            End If ' no exist order
        End If

        If txtINFO.Text <> "" Then
            _CheckProcess.DisableBarCode()
        Else
            _CheckProcess.EnableBarCode()
        End If


    End Sub
    Private Sub AddLabelRow(ByVal _row As DataRow, ByVal _DS As DataSet)
        Dim _labelRow As DataRow
        Dim _LabelRowsV() As DataRowView
        Dim _LabelRowV As DataRowView = Nothing
        
        Dim _NewLabelRow As Boolean = False

        Dim _XY As String = "X"
        
        _LabelRowsV = CustView.FindRows(New Object() {_row("customers_id")})
        _labelRow = Nothing

        If _LabelRowsV.GetLength(0) = 0 Then
            _XY = "X"
            _NewLabelRow = True
        Else
            _XY = "X"
            _NewLabelRow = True
            For Each _LabelRowV In _LabelRowsV
                If _LabelRowV("x_orders_id") & "" = "" Then
                    _XY = "X"
                    _NewLabelRow = False
                    _labelRow = _LabelRowV.Row
                    Exit For
                Else
                    If (_LabelRowV("x_products_id") & "" = _row("products_id") And _LabelRowV("x_dvd_id") & "" = _row("dvd_id")) Then
                        Exit Sub
                    End If
                    If _LabelRowV("y_orders_id") & "" = "" And _row("customers_abo_multishipment") = 1 Then
                        _XY = "Y"
                        _NewLabelRow = False
                        _labelRow = _LabelRowV.Row
                        Exit For
                    Else
                        _XY = "X"
                        _NewLabelRow = True
                    End If
                End If
            Next
        End If
        If _NewLabelRow Then
            _labelRow = objDS.Tables("envelope_labels_multishipment_det").NewRow
            _labelRow("multishipment_id") = objDS.Tables("envelope_labels_multishipment_det").Rows.Count + 1

            _labelRow("customers_id") = _row("customers_id")
            _labelRow("delivery_name") = _row("delivery_name")
            _labelRow("date_added") = _row("date_purchased")
            _labelRow("delivery_street_address") = _row("delivery_street_address")
            _labelRow("delivery_city") = _row("delivery_city")
            If _row("delivery_country") = "Belgium" Then
                _labelRow("delivery_country") = ""
            Else
                _labelRow("delivery_country") = _row("delivery_country")
            End If
            _labelRow("delivery_postcode") = _row("delivery_postcode")
            _labelRow("lang_name") = _row("lang_name")
            _labelRow("group_abc") = "a"

            objDS.Tables("envelope_labels_multishipment_det").Rows.Add(_labelRow)
        Else
            _XY = "Y"
        End If
        If Not IsNothing(_labelRow) Then
            _labelRow.BeginEdit()
            _labelRow(_XY & "_orders_id") = _row("orders_id")
            _labelRow(_XY & "_products_id") = _row("products_id")
            _labelRow(_XY & "_dvd_id") = _row("dvd_id")
            _labelRow(_XY & "_box_id") = 0
            If _XY = "X" Then
                PictXY.BackColor = System.Drawing.Color.Lime
                X_Pos += 1
                _labelRow(_XY & "_box_dvd_id") = X_Pos
            Else
                PictXY.BackColor = System.Drawing.Color.Red
                Y_Pos += 1
                _labelRow(_XY & "_box_dvd_id") = Y_Pos
            
            End If
            
            _row("multishipment_sm") = _XY
            _row.EndEdit()
            _labelRow.EndEdit()
        End If
    End Sub

    Private Sub btnPrintAllEnvelopesFLAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAllEnvelopesFLAT.Click
        Dim _row, _row1 As DataRow
        Dim _DS As New dsEnvelopeLabels
        Dim _i As Integer
        _DS.Tables("envelope_labels_multishipment_det").Clear()
        For _i = 0 To GridView1.DataRowCount - 1
            _row = GridView1.GetDataRow(_i)
            _row1 = _DS.Tables("envelope_labels_multishipment_det").NewRow
            _row1.ItemArray = _row.ItemArray
            _DS.Tables("envelope_labels_multishipment_det").Rows.Add(_row1)
        Next
        Dim _rpt As New rptNewEnveloppe 'rptMSEnveloppesFlat
        _rpt.objDS = _DS
        _rpt.DataMember = ""
        _rpt.DataSource = _DS.Tables("envelope_labels_multishipment_det")
        _rpt.ShowPreview()

    End Sub
    'Private Sub btnPrintSelectedEnveloppesFLAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintSelectedEnveloppesFLAT.Click
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
    '    Dim _rpt As New rptMSEnveloppesFlat
    '    _rpt.objDS = _DS
    '    _rpt.DataMember = ""
    '    _rpt.DataSource = _DS.Tables("envelope_labels_multishipment_det")
    '    _rpt.ShowPreview()
    'End Sub

    Private Sub btnOK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK1.Click
        BarCode_OK()
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Dim _frm As New BizzLib.frmDialogSelectXMLFile
        Dim _FileName As String
        _frm.mvarBoolSave = True
        _frm.ShowDialog(Me)
        If _frm.DialogResult = Windows.Forms.DialogResult.Cancel Then Exit Sub
        _FileName = _frm.txtFileName.Text
        'Dim _MyTable As DataTable
        '_MyTable = objDS.Tables("envelope_labels_multishipment_det").Copy
        'Dim _Ds As New DataSet
        '_Ds.Tables.Add(_MyTable)
        _objDS.WriteXml(_FileName)
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Dim _frm As New BizzLib.frmDialogSelectXMLFile
        Dim _FileName As String
        _frm.mvarBoolSave = False
        _frm.ShowDialog(Me)
        If _frm.DialogResult = Windows.Forms.DialogResult.Cancel Then Exit Sub
        _FileName = _frm.txtFileName.Text
        _objDS.ReadXml(_FileName)
        X_Pos = objDS.Tables("envelope_labels_multishipment_det").Rows.Count
        Dim _View As New DataView(objDS.Tables("envelope_labels_multishipment_det"), "y_box_dvd_id not is null", "", DataViewRowState.CurrentRows)
        Y_Pos = _View.Count
    End Sub

    Private Sub btnFindBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindBarCode.Click
        _CheckProcess.GenereBarCode()
    End Sub
    Private Function ProcessOutAutomatic(ByVal barcode As String) As Boolean
        If barcode = String.Empty Then Return True

        txtBarCode.Text = barcode
        btnFindBarCode_Click(Nothing, Nothing)
        btnOK1_Click(Nothing, Nothing)
        If txtINFO.Text.Length > 0 Then
            Return False
        End If

        Return True
    End Function
    ''' <summary>
    '''  au cas ou probleme de commit transaction
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnProcessXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessXml.Click
        Dim dr As DataRow
        Dim _frm As New BizzLib.frmDialogSelectXMLFile
        Dim _FileName As String
        Dim strX As String = String.Empty
        Dim strY As String = String.Empty
        Dim dt As DataTable = New DataTable()
        Dim ds As DataSet = New DataSet()
        _frm.mvarBoolSave = False
        _frm.ShowDialog(Me)
        If _frm.DialogResult = Windows.Forms.DialogResult.Cancel Then Exit Sub
        _FileName = _frm.txtFileName.Text
        ds.ReadXml(_FileName)

        '_objDS.ReadXml(_FileName)

        For index As Integer = 0 To ds.Tables(0).Rows.Count - 1

            'dr = GridView1.GetDataRow(index)
            dr = ds.Tables(0).Rows(index)
            If dr.Table.Columns.Contains("x_products_id") Then
                strX = dr("x_products_id") & "-" & dr("x_dvd_id")
                strY = dr("y_products_id") & "-" & dr("y_dvd_id")
            Else
                strX = dr("products_id") & "-" & dr("dvd_id")
                strY = String.Empty
            End If

            If Not ProcessOutAutomatic(strX) Then Exit For
            If Not ProcessOutAutomatic(strY) Then Exit For
           

        Next




    End Sub
End Class
