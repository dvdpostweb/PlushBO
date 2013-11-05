Imports System.Windows.Forms.Application
Public Class frmCancelOrder
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
    Friend WithEvents DsProducts1 As DVDPostLib.dsProducts
    Public WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtOrderID As DevExpress.XtraEditors.TextEdit
    Public WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Public WithEvents txtCustomerID As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtProductID As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Public WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtProductTitle As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtCustomerName As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Public WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtDatePurchased As DevExpress.XtraEditors.DateEdit
    Public WithEvents txtPiBoxID As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtBoxID As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtDVDStatus As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtInOut As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Public WithEvents btnDeleteOrder As DevExpress.XtraEditors.SimpleButton
    Public WithEvents cmbChangeDvdID As DevExpress.XtraEditors.LookUpEdit
    Public WithEvents txtDVDId As DevExpress.XtraEditors.TextEdit
    Public WithEvents btnChangeProduct As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupAction As System.Windows.Forms.GroupBox
    Friend WithEvents GroupficheInfo As System.Windows.Forms.GroupBox
    Public WithEvents LookUpChooseOtherProduct As DevExpress.XtraEditors.LookUpEdit
    Public WithEvents lblTypeProduct As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtProductsType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupStatusDVD As System.Windows.Forms.GroupBox
    Friend WithEvents RBDamaged As System.Windows.Forms.RadioButton
    Friend WithEvents RBBizzPerdu As System.Windows.Forms.RadioButton
    Friend WithEvents RBBroken As System.Windows.Forms.RadioButton
    Public WithEvents btnChgDVD As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtOrderID = New DevExpress.XtraEditors.TextEdit
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.txtCustomerID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtProductID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtProductTitle = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtCustomerName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtDatePurchased = New DevExpress.XtraEditors.DateEdit
        Me.txtPiBoxID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtBoxID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtDVDStatus = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtInOut = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.btnDeleteOrder = New DevExpress.XtraEditors.SimpleButton
        Me.btnChgDVD = New DevExpress.XtraEditors.SimpleButton
        Me.cmbChangeDvdID = New DevExpress.XtraEditors.LookUpEdit
        Me.DsProducts1 = New DVDPostLib.dsProducts
        Me.txtDVDId = New DevExpress.XtraEditors.TextEdit
        Me.btnChangeProduct = New DevExpress.XtraEditors.SimpleButton
        Me.GroupAction = New System.Windows.Forms.GroupBox
        Me.LookUpChooseOtherProduct = New DevExpress.XtraEditors.LookUpEdit
        Me.GroupficheInfo = New System.Windows.Forms.GroupBox
        Me.lblTypeProduct = New DevExpress.XtraEditors.LabelControl
        Me.txtProductsType = New DevExpress.XtraEditors.TextEdit
        Me.GroupStatusDVD = New System.Windows.Forms.GroupBox
        Me.RBBroken = New System.Windows.Forms.RadioButton
        Me.RBDamaged = New System.Windows.Forms.RadioButton
        Me.RBBizzPerdu = New System.Windows.Forms.RadioButton
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrderID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDatePurchased.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDatePurchased.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPiBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVDStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInOut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbChangeDvdID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProducts1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVDId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupAction.SuspendLayout()
        CType(Me.LookUpChooseOtherProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupficheInfo.SuspendLayout()
        CType(Me.txtProductsType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupStatusDVD.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(34, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Order ID"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(146, 32)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderID.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(258, 32)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.ToolTip = "Rechercher les info de cette commande"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Location = New System.Drawing.Point(146, 104)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerID.TabIndex = 9
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(34, 104)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Customer ID"
        '
        'txtProductID
        '
        Me.txtProductID.Enabled = False
        Me.txtProductID.Location = New System.Drawing.Point(146, 160)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(100, 20)
        Me.txtProductID.TabIndex = 11
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(34, 160)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Product ID"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(258, 160)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "DVD ID"
        '
        'txtProductTitle
        '
        Me.txtProductTitle.Enabled = False
        Me.txtProductTitle.Location = New System.Drawing.Point(146, 184)
        Me.txtProductTitle.Name = "txtProductTitle"
        Me.txtProductTitle.Size = New System.Drawing.Size(296, 20)
        Me.txtProductTitle.TabIndex = 15
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(34, 184)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl5.TabIndex = 14
        Me.LabelControl5.Text = "Title"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerName.Location = New System.Drawing.Point(146, 128)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(296, 20)
        Me.txtCustomerName.TabIndex = 17
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(34, 128)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "Customer Name"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(34, 72)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl7.TabIndex = 18
        Me.LabelControl7.Text = "Purchase Date"
        '
        'txtDatePurchased
        '
        Me.txtDatePurchased.EditValue = Nothing
        Me.txtDatePurchased.Enabled = False
        Me.txtDatePurchased.Location = New System.Drawing.Point(146, 72)
        Me.txtDatePurchased.Name = "txtDatePurchased"
        Me.txtDatePurchased.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDatePurchased.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDatePurchased.Size = New System.Drawing.Size(100, 20)
        Me.txtDatePurchased.TabIndex = 19
        '
        'txtPiBoxID
        '
        Me.txtPiBoxID.Enabled = False
        Me.txtPiBoxID.Location = New System.Drawing.Point(338, 208)
        Me.txtPiBoxID.Name = "txtPiBoxID"
        Me.txtPiBoxID.Size = New System.Drawing.Size(104, 20)
        Me.txtPiBoxID.TabIndex = 23
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(258, 208)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl8.TabIndex = 22
        Me.LabelControl8.Text = "P-I-Box ID"
        '
        'txtBoxID
        '
        Me.txtBoxID.Enabled = False
        Me.txtBoxID.Location = New System.Drawing.Point(146, 208)
        Me.txtBoxID.Name = "txtBoxID"
        Me.txtBoxID.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxID.TabIndex = 21
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(34, 208)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl9.TabIndex = 20
        Me.LabelControl9.Text = "Box ID"
        '
        'txtDVDStatus
        '
        Me.txtDVDStatus.Enabled = False
        Me.txtDVDStatus.Location = New System.Drawing.Point(146, 232)
        Me.txtDVDStatus.Name = "txtDVDStatus"
        Me.txtDVDStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtDVDStatus.TabIndex = 25
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(34, 232)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl10.TabIndex = 24
        Me.LabelControl10.Text = "DVD Status"
        '
        'txtInOut
        '
        Me.txtInOut.Enabled = False
        Me.txtInOut.Location = New System.Drawing.Point(338, 232)
        Me.txtInOut.Name = "txtInOut"
        Me.txtInOut.Size = New System.Drawing.Size(104, 20)
        Me.txtInOut.TabIndex = 27
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(258, 232)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl11.TabIndex = 26
        Me.LabelControl11.Text = "InOut"
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.Location = New System.Drawing.Point(6, 168)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(169, 51)
        Me.btnDeleteOrder.TabIndex = 28
        Me.btnDeleteOrder.Text = "Delete Order"
        '
        'btnChgDVD
        '
        Me.btnChgDVD.Location = New System.Drawing.Point(6, 23)
        Me.btnChgDVD.Name = "btnChgDVD"
        Me.btnChgDVD.Size = New System.Drawing.Size(163, 51)
        Me.btnChgDVD.TabIndex = 29
        Me.btnChgDVD.Text = "Change dvdID"
        '
        'cmbChangeDvdID
        '
        Me.cmbChangeDvdID.Location = New System.Drawing.Point(181, 34)
        Me.cmbChangeDvdID.Name = "cmbChangeDvdID"
        Me.cmbChangeDvdID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbChangeDvdID.Properties.Appearance.Options.UseFont = True
        Me.cmbChangeDvdID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbChangeDvdID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_dvdid", "products_dvdid", 80, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("box_id", "box_id", 38, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("pibox_id", "pibox_id", 46, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbChangeDvdID.Properties.DataSource = Me.DsProducts1.products_dvd_stock_1
        Me.cmbChangeDvdID.Properties.DisplayMember = "products_dvdid"
        Me.cmbChangeDvdID.Properties.NullText = ""
        Me.cmbChangeDvdID.Properties.ValueMember = "products_dvdid"
        Me.cmbChangeDvdID.Size = New System.Drawing.Size(342, 22)
        Me.cmbChangeDvdID.TabIndex = 30
        '
        'DsProducts1
        '
        Me.DsProducts1.DataSetName = "dsProducts"
        Me.DsProducts1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsProducts1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDVDId
        '
        Me.txtDVDId.Enabled = False
        Me.txtDVDId.Location = New System.Drawing.Point(338, 160)
        Me.txtDVDId.Name = "txtDVDId"
        Me.txtDVDId.Size = New System.Drawing.Size(104, 20)
        Me.txtDVDId.TabIndex = 31
        '
        'btnChangeProduct
        '
        Me.btnChangeProduct.Location = New System.Drawing.Point(6, 97)
        Me.btnChangeProduct.Name = "btnChangeProduct"
        Me.btnChangeProduct.Size = New System.Drawing.Size(169, 48)
        Me.btnChangeProduct.TabIndex = 34
        Me.btnChangeProduct.Text = "Change Product "
        '
        'GroupAction
        '
        Me.GroupAction.Controls.Add(Me.cmbChangeDvdID)
        Me.GroupAction.Controls.Add(Me.LookUpChooseOtherProduct)
        Me.GroupAction.Controls.Add(Me.btnChgDVD)
        Me.GroupAction.Controls.Add(Me.btnDeleteOrder)
        Me.GroupAction.Controls.Add(Me.btnChangeProduct)
        Me.GroupAction.Location = New System.Drawing.Point(543, 100)
        Me.GroupAction.Name = "GroupAction"
        Me.GroupAction.Size = New System.Drawing.Size(535, 241)
        Me.GroupAction.TabIndex = 36
        Me.GroupAction.TabStop = False
        Me.GroupAction.Text = "Action"
        '
        'LookUpChooseOtherProduct
        '
        Me.LookUpChooseOtherProduct.Location = New System.Drawing.Point(181, 106)
        Me.LookUpChooseOtherProduct.Name = "LookUpChooseOtherProduct"
        Me.LookUpChooseOtherProduct.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpChooseOtherProduct.Properties.Appearance.Options.UseFont = True
        Me.LookUpChooseOtherProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpChooseOtherProduct.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("wishlist_type", "wishlist_type", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_title", "products_title", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_id", "products_id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_dvdid", "products_dvdid", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("box_id", "box_id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("pibox_id", "pibox_id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.LookUpChooseOtherProduct.Properties.DisplayMember = "products_title"
        Me.LookUpChooseOtherProduct.Properties.NullText = ""
        Me.LookUpChooseOtherProduct.Size = New System.Drawing.Size(342, 22)
        Me.LookUpChooseOtherProduct.TabIndex = 39
        '
        'GroupficheInfo
        '
        Me.GroupficheInfo.Controls.Add(Me.lblTypeProduct)
        Me.GroupficheInfo.Controls.Add(Me.txtProductsType)
        Me.GroupficheInfo.Controls.Add(Me.LabelControl1)
        Me.GroupficheInfo.Controls.Add(Me.txtOrderID)
        Me.GroupficheInfo.Controls.Add(Me.txtDVDId)
        Me.GroupficheInfo.Controls.Add(Me.btnSearch)
        Me.GroupficheInfo.Controls.Add(Me.txtInOut)
        Me.GroupficheInfo.Controls.Add(Me.LabelControl2)
        Me.GroupficheInfo.Controls.Add(Me.LabelControl11)
        Me.GroupficheInfo.Controls.Add(Me.txtCustomerID)
        Me.GroupficheInfo.Controls.Add(Me.txtDVDStatus)
        Me.GroupficheInfo.Controls.Add(Me.LabelControl3)
        Me.GroupficheInfo.Controls.Add(Me.LabelControl10)
        Me.GroupficheInfo.Controls.Add(Me.txtProductID)
        Me.GroupficheInfo.Controls.Add(Me.txtPiBoxID)
        Me.GroupficheInfo.Controls.Add(Me.LabelControl4)
        Me.GroupficheInfo.Controls.Add(Me.LabelControl8)
        Me.GroupficheInfo.Controls.Add(Me.LabelControl5)
        Me.GroupficheInfo.Controls.Add(Me.txtBoxID)
        Me.GroupficheInfo.Controls.Add(Me.txtProductTitle)
        Me.GroupficheInfo.Controls.Add(Me.LabelControl9)
        Me.GroupficheInfo.Controls.Add(Me.LabelControl6)
        Me.GroupficheInfo.Controls.Add(Me.txtDatePurchased)
        Me.GroupficheInfo.Controls.Add(Me.txtCustomerName)
        Me.GroupficheInfo.Controls.Add(Me.LabelControl7)
        Me.GroupficheInfo.Location = New System.Drawing.Point(23, 46)
        Me.GroupficheInfo.Name = "GroupficheInfo"
        Me.GroupficheInfo.Size = New System.Drawing.Size(493, 295)
        Me.GroupficheInfo.TabIndex = 37
        Me.GroupficheInfo.TabStop = False
        Me.GroupficheInfo.Text = "Fiche Info"
        '
        'lblTypeProduct
        '
        Me.lblTypeProduct.Location = New System.Drawing.Point(255, 72)
        Me.lblTypeProduct.Name = "lblTypeProduct"
        Me.lblTypeProduct.Size = New System.Drawing.Size(24, 13)
        Me.lblTypeProduct.TabIndex = 32
        Me.lblTypeProduct.Text = "Type"
        '
        'txtProductsType
        '
        Me.txtProductsType.Enabled = False
        Me.txtProductsType.Location = New System.Drawing.Point(302, 72)
        Me.txtProductsType.Name = "txtProductsType"
        Me.txtProductsType.Size = New System.Drawing.Size(100, 20)
        Me.txtProductsType.TabIndex = 33
        '
        'GroupStatusDVD
        '
        Me.GroupStatusDVD.Controls.Add(Me.RBBroken)
        Me.GroupStatusDVD.Controls.Add(Me.RBDamaged)
        Me.GroupStatusDVD.Controls.Add(Me.RBBizzPerdu)
        Me.GroupStatusDVD.Location = New System.Drawing.Point(549, 46)
        Me.GroupStatusDVD.Name = "GroupStatusDVD"
        Me.GroupStatusDVD.Size = New System.Drawing.Size(529, 52)
        Me.GroupStatusDVD.TabIndex = 40
        Me.GroupStatusDVD.TabStop = False
        Me.GroupStatusDVD.Text = "Status DVD Error"
        '
        'RBBroken
        '
        Me.RBBroken.AutoSize = True
        Me.RBBroken.Location = New System.Drawing.Point(391, 19)
        Me.RBBroken.Name = "RBBroken"
        Me.RBBroken.Size = New System.Drawing.Size(59, 17)
        Me.RBBroken.TabIndex = 2
        Me.RBBroken.TabStop = True
        Me.RBBroken.Text = "Broken"
        Me.RBBroken.UseVisualStyleBackColor = True
        '
        'RBDamaged
        '
        Me.RBDamaged.AutoSize = True
        Me.RBDamaged.Location = New System.Drawing.Point(212, 19)
        Me.RBDamaged.Name = "RBDamaged"
        Me.RBDamaged.Size = New System.Drawing.Size(71, 17)
        Me.RBDamaged.TabIndex = 1
        Me.RBDamaged.TabStop = True
        Me.RBDamaged.Text = "Damaged"
        Me.RBDamaged.UseVisualStyleBackColor = True
        '
        'RBBizzPerdu
        '
        Me.RBBizzPerdu.AutoSize = True
        Me.RBBizzPerdu.Location = New System.Drawing.Point(29, 19)
        Me.RBBizzPerdu.Name = "RBBizzPerdu"
        Me.RBBizzPerdu.Size = New System.Drawing.Size(75, 17)
        Me.RBBizzPerdu.TabIndex = 0
        Me.RBBizzPerdu.TabStop = True
        Me.RBBizzPerdu.Text = "Bizz Perdu"
        Me.RBBizzPerdu.UseVisualStyleBackColor = True
        '
        'frmCancelOrder
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1108, 472)
        Me.Controls.Add(Me.GroupStatusDVD)
        Me.Controls.Add(Me.GroupficheInfo)
        Me.Controls.Add(Me.GroupAction)
        Me.Name = "frmCancelOrder"
        Me.Text = "frmCancelOrder"
        Me.Controls.SetChildIndex(Me.GroupAction, 0)
        Me.Controls.SetChildIndex(Me.GroupficheInfo, 0)
        Me.Controls.SetChildIndex(Me.GroupStatusDVD, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrderID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDatePurchased.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDatePurchased.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPiBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVDStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInOut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbChangeDvdID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProducts1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVDId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupAction.ResumeLayout(False)
        CType(Me.LookUpChooseOtherProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupficheInfo.ResumeLayout(False)
        Me.GroupficheInfo.PerformLayout()
        CType(Me.txtProductsType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupStatusDVD.ResumeLayout(False)
        Me.GroupStatusDVD.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub

    Dim OrderTable As New DataTable("OrderTable")
    Dim OrderRow, row, rowValue As DataRow
    Dim objProductDVD As clsProduct_DVD
    Dim varCmdDvdId As String
    Dim _ds As New DataSet()

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchOrderInfo()
    End Sub
    Public Sub SearchOrderInfo()
        If txtOrderID.EditValue & "" = "" Then Exit Sub
        If Not IsNumeric(txtOrderID.EditValue) Then Exit Sub
        Dim _SQLTxt As String
        _SQLTxt = "SELECT o.orders_id, o.customers_id, o.customers_name, o.date_purchased, op.products_id, op.products_dvd, op.products_name,op.orders_products_type,p.imdb_id " & _
                  " FROM orders o join orders_products op on op.orders_id = o.orders_id " & _
                  " join products p on p.products_id = op.products_id " & _
                  " WHERE o.orders_id = " & txtOrderID.EditValue
        OrderTable.Clear()
        DvdPostData.clsConnection.FillDataSet(OrderTable, _SQLTxt)
        If OrderTable.Rows.Count = 1 Then
            OrderRow = OrderTable.Rows(0)
        Else
            OrderRow = Nothing
            objProductDVD = Nothing
        End If


        If Not IsNothing(OrderRow) Then
            objProductDVD = New clsProduct_DVD(SessionInfo, DsProducts1, OrderRow("products_id"), OrderRow("products_dvd"))
            txtDatePurchased.EditValue = OrderRow("date_purchased")
            txtCustomerID.EditValue = OrderRow("customers_id")
            txtCustomerName.EditValue = OrderRow("customers_name")
            txtProductID.EditValue = OrderRow("products_id")
            txtDVDId.EditValue = OrderRow("products_dvd")
            txtProductTitle.EditValue = OrderRow("products_name")
            txtProductsType.EditValue = OrderRow("orders_products_type")
            objProductDVD.Load_One_Products_DVD_Info()
            If Not IsNothing(objProductDVD.Products_dvd_row) Then
                txtBoxID.EditValue = objProductDVD.Products_dvd_row("box_id")
                txtPiBoxID.EditValue = objProductDVD.Products_dvd_row("pibox_id")
                txtDVDStatus.EditValue = objProductDVD.Products_dvd_row("products_dvd_status")
                txtInOut.EditValue = objProductDVD.Products_dvd_row("inout")
            Else
                txtBoxID.EditValue = ""
                txtPiBoxID.EditValue = ""
                txtDVDStatus.EditValue = ""
                txtInOut.EditValue = ""
            End If
            LoadAVailableDVDs(txtProductID.EditValue)
        Else
            txtDatePurchased.EditValue = ""
            txtCustomerID.EditValue = ""
            txtCustomerName.EditValue = "COMMANDE NON TROUVEE"
            txtProductID.EditValue = ""
            txtDVDId.EditValue = ""
            txtProductTitle.EditValue = ""
            txtBoxID.EditValue = ""
            txtPiBoxID.EditValue = ""
            txtDVDStatus.EditValue = ""
            txtInOut.EditValue = ""
        End If
        chooseDVDWishlistDispo(OrderRow("orders_products_type"), OrderRow("imdb_id"))

    End Sub
    Private Sub LoadAVailableDVDs(ByVal value As Integer)
        DsProducts1.Tables("products_dvd_stock_1").Clear()
        Dim _SQLtxt As String = "SELECT products_id, products_dvdid, `inout`, box_id, pibox_id, products_dvd_status from products_dvd " & _
            " where `inout` = 1 and products_dvd_status = 1 and box_id > 0 AND products_id = " & value & " order by box_id asc "
        DvdPostData.clsConnection.FillDataSet(DsProducts1.Tables("products_dvd_stock_1"), _SQLtxt)
    End Sub
   

    Private Function IsCheckedStatus() As Boolean
        Return RBBizzPerdu.Checked Or RBBroken.Checked Or RBDamaged.Checked
    End Function
    Private Sub changeStatus()
        If RBBizzPerdu.Checked Then
            ChangeDVDBizPerdu()
        ElseIf RBBroken.Checked Then
            ChangeDVDBroken()
        ElseIf RBDamaged.Checked Then
            ChangeDVDDamaged()
        End If
    End Sub
    Private Sub ChangeDVDBizPerdu()

        objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.BIZARREMENT_PERDU, _
                                             "Cancel Order SetDVDLost", _
                                             DvdPostData.ClsProducts_dvd_state.state.DVD_STATUS_MAINTENANCE, objProductDVD.INOUT)
        txtDVDStatus.EditValue = objProductDVD.products_dvd_status
        Me.txtInOut.EditValue = "1"
        MsgBox("Statut Bizarement Perdu")

    End Sub
    Private Sub ChangeDVDDamaged()
        objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_DAMAGED, _
                                                   "Cancel Order Damaged", _
                                                   DvdPostData.ClsProducts_dvd_state.state.DVD_STATUS_MAINTENANCE, objProductDVD.INOUT)

        txtDVDStatus.EditValue = objProductDVD.products_dvd_status
        Me.txtInOut.EditValue = "1"
        MsgBox("Statut Damaged")
    End Sub
    Private Sub ChangeDVDBroken()
        objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_BROKEN, _
                                                   "Cancel Order Broken", _
                                                   DvdPostData.ClsProducts_dvd_state.state.DVD_STATUS_MAINTENANCE, objProductDVD.INOUT)

        txtDVDStatus.EditValue = objProductDVD.products_dvd_status
        Me.txtInOut.EditValue = "1"
        MsgBox("Statut Broken")
    End Sub

    Private Function checkStatus() As Boolean
        If Not IsCheckedStatus() Then
            MsgBox("choose Status DVD before action", MsgBoxStyle.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function
    Private Function changeDVDID() As Boolean

        Dim _row As DataRowView = cmbChangeDvdID.Properties.GetDataSourceRowByKeyValue(cmbChangeDvdID.EditValue)
        Dim _PreviousDVDId As Integer = txtDVDId.EditValue

        If _row Is Nothing Then
            MsgBox("choose a new dvd number before action")
            Return False
        End If
        If Not IsNumeric(txtDVDId.EditValue) Then
            MsgBox("DVD ID must be a number, please re-enter", MsgBoxStyle.Critical)
            Return False
        End If
        DvdPostData.clsConnection.CreateTransaction(False)
        Try
            txtBoxID.EditValue = _row("box_id")
            txtPiBoxID.EditValue = _row("pibox_id")
            txtDVDId.EditValue = _row("products_dvdid")
            Dim _SQLTxt As String = "UPDATE orders_products set pick_group = null,  products_dvd = " & txtDVDId.EditValue & " WHERE orders_id = " & txtOrderID.EditValue
            Dim _Nbr As Integer
            _Nbr = DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
            If _Nbr <> 1 Then
                MsgBox("Something went wrong during the save.", MsgBoxStyle.Critical)
            End If
            ' recupere le status,inout de l'id previous
            _SQLTxt = "update products_dvd pd set  `inout` = 2,last_admindate = now(),last_adminby = '" & DvdPostData.clsSession.user_id & "'  WHERE pd.products_id = " & txtProductID.EditValue & " AND products_dvdid = " & txtDVDId.EditValue
            DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
            _SQLTxt = "update products_dvd pd set  `inout` = 1,last_admindate = now(),last_adminby = '" & DvdPostData.clsSession.user_id & "' WHERE pd.products_id = " & txtProductID.EditValue & " AND products_dvdid = " & _PreviousDVDId
            DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
            'Me.txtDVDStatus.EditValue = "1"
            Me.txtInOut.EditValue = "1"
            DvdPostData.clsConnection.CommitTransaction(True)
            Return True
        Catch ex As Exception
            DvdPostData.clsConnection.CommitTransaction(False)
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Cancel, ex)

            Return False
        End Try

    End Function

    Public Sub chooseDVDWishlistDispo(ByVal products_type As String, ByVal imdb_id As Integer)
        Dim sql As String
        ' sql = "select pdvd.products_dvdid ,wl.product_id,wl.wishlist_type,pdvd.pibox_id,pdvd.box_id,pd.products_name as products_title from wishlist wl , products_dvd pdvd, products_description pd where wl.product_id = pd.products_id and pdvd.products_id = pd.products_id and  pdvd.`inout` = 1  AND pdvd.box_id > 0 and pdvd.products_dvd_status = 1 and customers_id = '" & txtCustomerID.EditValue.ToString & "' group by pibox_id  order by  wl.wishlist_type,pd.products_name asc"
        'sql = " select w.wishlist_type, pdv.products_id ,pdes.products_name products_title , pdv.products_dvdid,pdv.box_id ,pdv.pibox_id " & _
        '      " from wishlist w " & _
        '      " join products_dvd pdv on w.product_id = pdv.products_id " & _
        '      " join products_description pdes on  w.product_id = pdes.products_id " & _
        '      " where pdv.products_dvd_status = 1 and pdv.`inout` = 1  " & _
        '      " and w.wishlist_type = '" & products_type & "'" & _
        '      " and pdv.pibox_id > 0 and w.customers_id = '" & txtCustomerID.EditValue.ToString & "' group by w.product_id  order by wishlist_type asc "

        sql = DvdPostData.ClsCustomersData.GetSelectWishlistWithfirstPerSerie(txtCustomerID.EditValue, products_type, imdb_id)
        If IsNothing(_ds.Tables("wishlist_dvd_cust")) Then
            _ds.Tables.Add("wishlist_dvd_cust")
            DvdPostData.clsConnection.FillDataSet(_ds.Tables("wishlist_dvd_cust"), sql)
            Me.LookUpChooseOtherProduct.Properties.DataSource = _ds.Tables("wishlist_dvd_cust")
        Else
            _ds.Tables("wishlist_dvd_cust").Clear()
            DvdPostData.clsConnection.FillDataSet(_ds.Tables("wishlist_dvd_cust"), sql)
            Me.LookUpChooseOtherProduct.Properties.DataSource = _ds.Tables("wishlist_dvd_cust")
        End If

    End Sub
    Private Function changeProducts() As Boolean
        Dim _row As DataRowView = LookUpChooseOtherProduct.Properties.GetDataSourceRowByKeyValue(LookUpChooseOtherProduct.EditValue)
        'If txtDVDStatus.EditValue = 1 Then
        '    MsgBox("Select a status for the dvd: " + txtProductTitle.EditValue.ToString, MsgBoxStyle.Exclamation)
        '    Return False
        'End If

        If IsNothing(_row) Then
            MsgBox("Select a product. ", MsgBoxStyle.Exclamation)
            Return False
        End If
        DvdPostData.clsConnection.CreateTransaction(False)
        Try
            'remettre dans wihlist le products 
            Dim sqlWList As String = "insert into wishlist  (customers_id ,product_id,rank,date_added , wishlist_type,wishlist_source_id) select customers_id,products_id,rank,date_added,wishlist_type," & DvdPostData.ClsCustomersData.Wishlist_Source.CANCELORDER & " from wishlist_assigned where customers_id = '" & txtCustomerID.EditValue & "' and products_id = '" & txtProductID.EditValue & "' "
            DvdPostData.clsConnection.ExecuteNonQuery(sqlWList)

            'delete from wishlist assigned
            Dim sqlDelfromWA As String = " delete from wishlist_assigned where products_id = '" & txtProductID.EditValue & "'and customers_id ='" & txtCustomerID.EditValue & "' "
            DvdPostData.clsConnection.ExecuteNonQuery(sqlDelfromWA)

            'element of drpdownlist "changer de products"
            txtProductID.EditValue = _row("products_id")
            txtProductTitle.EditValue = _row("products_title").ToString().Replace("'", "''")
            txtDVDId.EditValue = _row("products_dvdid")
            txtBoxID.EditValue = _row("box_id")
            txtPiBoxID.EditValue = _row("pibox_id")

            'put the new dvd in wishlist_assigned
            Dim sqlInputDvdWl As String = "insert into wishlist_assigned  (wl_id,customers_id ,products_id,rank,date_added ,date_assigned, wishlist_type,priority,wishlist_source_id) select wl_id,customers_id,product_id,rank,date_added,now(),wishlist_type,priority,wishlist_source_id " & _
                                           " from wishlist where customers_id = '" & txtCustomerID.EditValue & "' and product_id = '" & txtProductID.EditValue & "' "
            DvdPostData.clsConnection.ExecuteNonQuery(sqlInputDvdWl)
            '  DvdPostData.clsConnection.ExecuteNonQuery("update wishlist_assigned set date_assigned = now() where customers_id = '" & txtCustomerID.EditValue & "' and products_id = '" & txtProductID.EditValue & "' ")

            'delete from wishlist the new dvd assigned
            Dim sqlDel As String = " delete from wishlist  where customers_id = '" & txtCustomerID.EditValue & "' and product_id = '" & txtProductID.EditValue & "' "
            DvdPostData.clsConnection.ExecuteNonQuery(sqlDel)

            'update productdvd INout with the new products_dvd
            Dim sqlOut As String = "update products_dvd  set  `inout` = 2, last_admindate = now(),last_adminby = '" & DvdPostData.clsSession.user_id & "' WHERE products_id = " & txtProductID.EditValue & " AND products_dvdid = " & txtDVDId.EditValue
            DvdPostData.clsConnection.ExecuteNonQuery(sqlOut)
            txtDVDStatus.EditValue = "1"
            txtInOut.EditValue = "2"

            'Update orders 
            Dim _SQLTxtOrder As String = "UPDATE orders_products op join orders o on op.orders_id = o.orders_id " & _
                                        " set o.Orders_type = '" & DVDPostTools.clsEnum.getNameStrEnum(DvdPostData.ClsCustomersData.OrdersType.MANUAL) & "'" & _
                                        ", o.last_modified = now()" & _
                                        ",  op.products_id = " & txtProductID.EditValue & _
                                        " ,op.products_name='" & Me.txtProductTitle.EditValue & "'" & _
                                        ",op.products_dvd = " & txtDVDId.EditValue & _
                                        ",op.pick_group = null " & _
                                        "  WHERE o.orders_id = " & txtOrderID.EditValue
            DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxtOrder)
            '  chooseDVDWishlistDispo()
            ' LoadAVailableDVDs(txtProductID.EditValue)
            DvdPostData.clsConnection.CommitTransaction(True)
            Return True
        Catch ex As Exception
            DvdPostData.clsConnection.CommitTransaction(False)
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Cancel, ex)

            Return False
        End Try

    End Function

    Private Sub btnChangeProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeProduct.Click
        If checkStatus() Then
            If changeProducts() Then
                changeStatus()
                MsgBox("Changed Product")
            Else
                MsgBox("Error change product please call administrator", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
    Private Sub btnChgDVDID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChgDVD.Click
        If checkStatus() Then
            If changeDVDID() Then
                changeStatus()
                MsgBox("Changed DVDID")
            End If
        End If
    End Sub
    Private Sub btnDeleteOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteOrder.Click
        If checkStatus() Then
            Dim isIllimitedAbo As Boolean

            isIllimitedAbo = DVDPostBuziness.ClsCustomers.isIllimitedaboByCustomers(txtCustomerID.EditValue)
            If objProductDVD.CancelOrder(isIllimitedAbo, txtOrderID.EditValue, txtCustomerID.EditValue) Then
                changeStatus()
                MsgBox("Deleted Order ")
            End If
        End If
    End Sub
End Class

