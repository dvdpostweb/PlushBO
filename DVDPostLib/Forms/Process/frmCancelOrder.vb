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
    Public WithEvents btnDeleteOrder As DevExpress.XtraEditors.SimpleButton
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
    Public WithEvents btnSetDVDLost As DevExpress.XtraEditors.SimpleButton
    Public WithEvents cmbDVDID As DevExpress.XtraEditors.LookUpEdit
    Public WithEvents txtDVDId As DevExpress.XtraEditors.TextEdit
    Public WithEvents btnAbime As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnBroken As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnChangeProducts As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupModif As System.Windows.Forms.GroupBox
    Friend WithEvents GroupficheInfo As System.Windows.Forms.GroupBox
    Public WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Public WithEvents btnChgDVD As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtOrderID = New DevExpress.XtraEditors.TextEdit
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.btnDeleteOrder = New DevExpress.XtraEditors.SimpleButton
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
        Me.btnSetDVDLost = New DevExpress.XtraEditors.SimpleButton
        Me.btnChgDVD = New DevExpress.XtraEditors.SimpleButton
        Me.cmbDVDID = New DevExpress.XtraEditors.LookUpEdit
        Me.DsProducts1 = New DVDPostLib.dsProducts
        Me.txtDVDId = New DevExpress.XtraEditors.TextEdit
        Me.btnAbime = New DevExpress.XtraEditors.SimpleButton
        Me.btnBroken = New DevExpress.XtraEditors.SimpleButton
        Me.btnChangeProducts = New DevExpress.XtraEditors.SimpleButton
        Me.GroupModif = New System.Windows.Forms.GroupBox
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit
        Me.GroupficheInfo = New System.Windows.Forms.GroupBox
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
        CType(Me.cmbDVDID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProducts1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVDId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupModif.SuspendLayout()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupficheInfo.SuspendLayout()
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
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.Location = New System.Drawing.Point(44, 24)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(104, 23)
        Me.btnDeleteOrder.TabIndex = 7
        Me.btnDeleteOrder.Text = "Delete Order"
        Me.btnDeleteOrder.ToolTip = "Supprimer cette commande"
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
        'btnSetDVDLost
        '
        Me.btnSetDVDLost.Location = New System.Drawing.Point(44, 53)
        Me.btnSetDVDLost.Name = "btnSetDVDLost"
        Me.btnSetDVDLost.Size = New System.Drawing.Size(104, 23)
        Me.btnSetDVDLost.TabIndex = 28
        Me.btnSetDVDLost.Text = "DVD Perdu"
        Me.btnSetDVDLost.ToolTip = "Definir ce DVD comme Bizzarement Perdu"
        '
        'btnChgDVD
        '
        Me.btnChgDVD.Location = New System.Drawing.Point(44, 113)
        Me.btnChgDVD.Name = "btnChgDVD"
        Me.btnChgDVD.Size = New System.Drawing.Size(143, 23)
        Me.btnChgDVD.TabIndex = 29
        Me.btnChgDVD.Text = "Changer le products_dvdid"
        '
        'cmbDVDID
        '
        Me.cmbDVDID.Location = New System.Drawing.Point(193, 115)
        Me.cmbDVDID.Name = "cmbDVDID"
        Me.cmbDVDID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDVDID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_dvdid", "products_dvdid", 80, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("box_id", "box_id", 38, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("pibox_id", "pibox_id", 46, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbDVDID.Properties.DataSource = Me.DsProducts1.products_dvd_stock_1
        Me.cmbDVDID.Properties.DisplayMember = "products_dvdid"
        Me.cmbDVDID.Properties.NullText = ""
        Me.cmbDVDID.Properties.ValueMember = "products_dvdid"
        Me.cmbDVDID.Size = New System.Drawing.Size(175, 20)
        Me.cmbDVDID.TabIndex = 30
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
        'btnAbime
        '
        Me.btnAbime.Location = New System.Drawing.Point(154, 53)
        Me.btnAbime.Name = "btnAbime"
        Me.btnAbime.Size = New System.Drawing.Size(104, 23)
        Me.btnAbime.TabIndex = 32
        Me.btnAbime.Text = "DVD Abime"
        Me.btnAbime.ToolTip = "Definir ce DVD comme Abime"
        '
        'btnBroken
        '
        Me.btnBroken.Location = New System.Drawing.Point(264, 53)
        Me.btnBroken.Name = "btnBroken"
        Me.btnBroken.Size = New System.Drawing.Size(104, 23)
        Me.btnBroken.TabIndex = 33
        Me.btnBroken.Text = "DVD Broken"
        Me.btnBroken.ToolTip = "Definir ce DVD comme Broken"
        '
        'btnChangeProducts
        '
        Me.btnChangeProducts.Location = New System.Drawing.Point(44, 82)
        Me.btnChangeProducts.Name = "btnChangeProducts"
        Me.btnChangeProducts.Size = New System.Drawing.Size(143, 23)
        Me.btnChangeProducts.TabIndex = 34
        Me.btnChangeProducts.Text = "Changer le products"
        '
        'GroupModif
        '
        Me.GroupModif.Controls.Add(Me.LookUpEdit1)
        Me.GroupModif.Controls.Add(Me.btnDeleteOrder)
        Me.GroupModif.Controls.Add(Me.btnSetDVDLost)
        Me.GroupModif.Controls.Add(Me.btnChangeProducts)
        Me.GroupModif.Controls.Add(Me.btnChgDVD)
        Me.GroupModif.Controls.Add(Me.btnBroken)
        Me.GroupModif.Controls.Add(Me.cmbDVDID)
        Me.GroupModif.Controls.Add(Me.btnAbime)
        Me.GroupModif.Location = New System.Drawing.Point(561, 46)
        Me.GroupModif.Name = "GroupModif"
        Me.GroupModif.Size = New System.Drawing.Size(416, 162)
        Me.GroupModif.TabIndex = 36
        Me.GroupModif.TabStop = False
        Me.GroupModif.Text = "Modification"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(193, 82)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("wishlist_type", "wishlist_type", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_title", "products_title", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_id", "products_id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_dvdid", "products_dvdid", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("box_id", "box_id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("pibox_id", "pibox_id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.LookUpEdit1.Properties.DisplayMember = "products_title"
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Size = New System.Drawing.Size(175, 20)
        Me.LookUpEdit1.TabIndex = 39
        '
        'GroupficheInfo
        '
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
        'frmCancelOrder
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1040, 366)
        Me.Controls.Add(Me.GroupficheInfo)
        Me.Controls.Add(Me.GroupModif)
        Me.Name = "frmCancelOrder"
        Me.Text = "frmCancelOrder"
        Me.Controls.SetChildIndex(Me.GroupModif, 0)
        Me.Controls.SetChildIndex(Me.GroupficheInfo, 0)
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
        CType(Me.cmbDVDID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProducts1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVDId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupModif.ResumeLayout(False)
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupficheInfo.ResumeLayout(False)
        Me.GroupficheInfo.PerformLayout()
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
        _SQLTxt = "SELECT o.orders_id, o.customers_id, o.customers_name, o.date_purchased, op.products_id, op.products_dvd, op.products_name " & _
                  " FROM orders o left join orders_products op on op.orders_id = o.orders_id " & _
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
        chooseDVDWishlistDispo()

    End Sub
    Private Sub LoadAVailableDVDs(ByVal value As Integer)
        DsProducts1.Tables("products_dvd_stock_1").Clear()
        Dim _SQLtxt As String = "SELECT products_id, products_dvdid, `inout`, box_id, pibox_id, products_dvd_status from products_dvd " & _
            " where `inout` = 1 and products_dvd_status = 1 and box_id > 0 AND products_id = " & value & " order by box_id asc "
        DvdPostData.clsConnection.FillDataSet(DsProducts1.Tables("products_dvd_stock_1"), _SQLtxt)
    End Sub
    Private Sub btnDeleteOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteOrder.Click
        objProductDVD.CancelOrder(txtOrderID.EditValue, txtCustomerID.EditValue)
        MsgBox("Commande annullée", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub btnSetDVDLost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetDVDLost.Click

        objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.BIZARREMENT_PERDU, _
                                                   "Cancel Order SetDVDLost", _
                                                   DvdPostData.ClsProducts_dvd_state.state.STOCK)

        txtDVDStatus.EditValue = objProductDVD.products_dvd_status
        Me.txtInOut.EditValue = "1"
        MsgBox("Statut du DVD mis à 'Bizarement Perdu'", MsgBoxStyle.Exclamation)


    End Sub

    Private Sub btnAbime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbime.Click

        objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_DAMAGED, _
                                                  "Cancel Order Damaged", _
                                                  DvdPostData.ClsProducts_dvd_state.state.STOCK)

        txtDVDStatus.EditValue = objProductDVD.products_dvd_status
        Me.txtInOut.EditValue = "1"



    End Sub

    Private Sub btnBroken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBroken.Click

        objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_BROKEN, _
                                                "Cancel Order Broken", _
                                                DvdPostData.ClsProducts_dvd_state.state.STOCK)

        txtDVDStatus.EditValue = objProductDVD.products_dvd_status
        Me.txtInOut.EditValue = "1"



    End Sub
    Private Sub btnChgDVD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChgDVD.Click
        Dim _row As DataRowView = cmbDVDID.Properties.GetDataSourceRowByKeyValue(cmbDVDID.EditValue)
        Dim _PreviousDVDId As Integer = txtDVDId.EditValue
        If IsNothing(_row) Then
            MsgBox("Select a DVD first", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If Not IsNumeric(txtDVDId.EditValue) Then
            MsgBox("DVD ID must be a number, please re-enter", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Me.txtDVDStatus.EditValue = "1" Then
            MsgBox("you must choose a status for the dvd")
            Exit Sub
        End If

        txtBoxID.EditValue = _row("box_id")
        txtPiBoxID.EditValue = _row("pibox_id")
        txtDVDId.EditValue = _row("products_dvdid")
        Dim _SQLTxt As String = "UPDATE orders_products set products_dvd = " & txtDVDId.EditValue & " WHERE orders_id = " & txtOrderID.EditValue
        Dim _Nbr As Integer
        _Nbr = DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        If _Nbr <> 1 Then
            MsgBox("Something went wrong during the save.", MsgBoxStyle.Critical)
        End If
        _SQLTxt = "update products_dvd pd set  `inout` = 2,last_admindate = now(),last_adminby = '" & DvdPostData.clsSession.user_id & "'  WHERE pd.products_id = " & txtProductID.EditValue & " AND products_dvdid = " & txtDVDId.EditValue
        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        _SQLTxt = "update products_dvd pd set  `inout` = 1,last_admindate = now(),last_adminby = '" & DvdPostData.clsSession.user_id & "' WHERE pd.products_id = " & txtProductID.EditValue & " AND products_dvdid = " & _PreviousDVDId
        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        Me.txtDVDStatus.EditValue = "1"
        Me.txtInOut.EditValue = "1"
    End Sub
    Public Sub chooseDVDWishlistDispo()
        Dim sql As String
        ' sql = "select pdvd.products_dvdid ,wl.product_id,wl.wishlist_type,pdvd.pibox_id,pdvd.box_id,pd.products_name as products_title from wishlist wl , products_dvd pdvd, products_description pd where wl.product_id = pd.products_id and pdvd.products_id = pd.products_id and  pdvd.`inout` = 1  AND pdvd.box_id > 0 and pdvd.products_dvd_status = 1 and customers_id = '" & txtCustomerID.EditValue.ToString & "' group by pibox_id  order by  wl.wishlist_type,pd.products_name asc"
        sql = "select w.wishlist_type, pdv.products_id ,pdes.products_name products_title , pdv.products_dvdid,pdv.box_id ,pdv.pibox_id from wishlist w , products_dvd pdv,products_description pdes where w.product_id = pdv.products_id and w.product_id = pdes.products_id and pdv.products_dvd_status = 1 and pdv.`inout` = 1  and pdv.pibox_id > 0 and w.customers_id = '" & txtCustomerID.EditValue.ToString & "' group by w.product_id  order by wishlist_type asc "
        If IsNothing(_ds.Tables("wishlist_dvd_cust")) Then
            _ds.Tables.Add("wishlist_dvd_cust")
            DvdPostData.clsConnection.FillDataSet(_ds.Tables("wishlist_dvd_cust"), sql)
            Me.LookUpEdit1.Properties.DataSource = _ds.Tables("wishlist_dvd_cust")
        Else
            _ds.Tables("wishlist_dvd_cust").Clear()
            DvdPostData.clsConnection.FillDataSet(_ds.Tables("wishlist_dvd_cust"), sql)
            Me.LookUpEdit1.Properties.DataSource = _ds.Tables("wishlist_dvd_cust")
        End If

    End Sub

    Private Sub btnChangeProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeProducts.Click



        Dim _row As DataRowView = LookUpEdit1.Properties.GetDataSourceRowByKeyValue(LookUpEdit1.EditValue)
        If txtDVDStatus.EditValue = 1 Then
            MsgBox("Select a status for the dvd: " + txtProductTitle.EditValue.ToString, MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If IsNothing(_row) Then
            MsgBox("Select a product. ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        'remettre dans wihlist le products 
        Dim sqlWList As String = "insert into wishlist  (customers_id ,product_id,rank,date_added , wishlist_type) select customers_id,products_id,rank,date_added,wishlist_type from wishlist_assigned where customers_id = '" & txtCustomerID.EditValue & "' and products_id = '" & txtProductID.EditValue & "' "
        DvdPostData.clsConnection.ExecuteNonQuery(sqlWList)

        'delete from wishlist assigned
        Dim sqlDelfromWA As String = " delete from wishlist_assigned where products_id = '" & txtProductID.EditValue & "'and customers_id ='" & txtCustomerID.EditValue & "' "
        DvdPostData.clsConnection.ExecuteNonQuery(sqlDelfromWA)

        'element of drpdownlist "changer de products"
        txtProductID.EditValue = _row("products_id")
        txtProductTitle.EditValue = _row("products_title")
        txtDVDId.EditValue = _row("products_dvdid")
        txtBoxID.EditValue = _row("box_id")
        txtPiBoxID.EditValue = _row("pibox_id")

        'put the new dvd in wishlist_assigned
        Dim sqlInputDvdWl As String = "insert into wishlist_assigned  (wl_id,customers_id ,products_id,rank,date_added , wishlist_type,priority,source_added) select wl_id,customers_id,product_id,rank,date_added,wishlist_type,priority,source_added from wishlist where customers_id = '" & txtCustomerID.EditValue & "' and product_id = '" & txtProductID.EditValue & "' "
        DvdPostData.clsConnection.ExecuteNonQuery(sqlInputDvdWl)
        DvdPostData.clsConnection.ExecuteNonQuery("update wishlist_assigned set date_assigned = now() where customers_id = '" & txtCustomerID.EditValue & "' and products_id = '" & txtProductID.EditValue & "' ")

        'delete from wishlist the new dvd assigned
        Dim sqlDel As String = " delete from wishlist  where customers_id = '" & txtCustomerID.EditValue & "' and product_id = '" & txtProductID.EditValue & "' "
        DvdPostData.clsConnection.ExecuteNonQuery(sqlDel)

        'update productdvd INout with the new products_dvd
        Dim sqlOut As String = "update products_dvd  set  `inout` = 2, last_admindate = now(),last_adminby = '" & DvdPostData.clsSession.user_id & "' WHERE products_id = " & txtProductID.EditValue & " AND products_dvdid = " & txtDVDId.EditValue
        DvdPostData.clsConnection.ExecuteNonQuery(sqlOut)
        txtDVDStatus.EditValue = "1"
        txtInOut.EditValue = "2"

        'Update orders 
        Dim _SQLTxtOrder As String = "UPDATE orders_products set products_id = '" & txtProductID.EditValue & "' ,products_name='" & Me.txtProductTitle.EditValue.ToString & "' ,products_dvd = '" & txtDVDId.EditValue.ToString & " '  WHERE orders_id =' " & txtOrderID.EditValue & "' "
        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxtOrder)

        chooseDVDWishlistDispo()
        LoadAVailableDVDs(txtProductID.EditValue)

    End Sub



 
End Class

