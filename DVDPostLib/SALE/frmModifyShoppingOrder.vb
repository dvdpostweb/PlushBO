Imports System.Windows.Forms.Application
Public Class frmModifyShoppingOrder
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
    Public WithEvents btnChgDVD As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnSetAsSold As DevExpress.XtraEditors.SimpleButton
    Public WithEvents txtCoverBoxID As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
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
        Me.btnSetAsSold = New DevExpress.XtraEditors.SimpleButton
        Me.txtCoverBoxID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
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
        CType(Me.txtCoverBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(38, 65)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Order ID"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(173, 65)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(120, 22)
        Me.txtOrderID.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(298, 65)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 26)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.ToolTip = "Rechercher les info de cette commande"
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.Location = New System.Drawing.Point(403, 92)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(125, 27)
        Me.btnDeleteOrder.TabIndex = 7
        Me.btnDeleteOrder.Text = "Delete Order"
        Me.btnDeleteOrder.ToolTip = "Supprimer cette commande"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Location = New System.Drawing.Point(173, 148)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(120, 22)
        Me.txtCustomerID.TabIndex = 9
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(38, 148)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Customer ID"
        '
        'txtProductID
        '
        Me.txtProductID.Enabled = False
        Me.txtProductID.Location = New System.Drawing.Point(173, 212)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(120, 22)
        Me.txtProductID.TabIndex = 11
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(38, 212)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(59, 16)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Product ID"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(307, 212)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(40, 16)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "DVD ID"
        '
        'txtProductTitle
        '
        Me.txtProductTitle.Enabled = False
        Me.txtProductTitle.Location = New System.Drawing.Point(173, 240)
        Me.txtProductTitle.Name = "txtProductTitle"
        Me.txtProductTitle.Size = New System.Drawing.Size(355, 22)
        Me.txtProductTitle.TabIndex = 15
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(38, 240)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(25, 16)
        Me.LabelControl5.TabIndex = 14
        Me.LabelControl5.Text = "Title"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerName.Location = New System.Drawing.Point(173, 175)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(355, 22)
        Me.txtCustomerName.TabIndex = 17
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(38, 175)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(92, 16)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "Customer Name"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(38, 111)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(82, 16)
        Me.LabelControl7.TabIndex = 18
        Me.LabelControl7.Text = "Purchase Date"
        '
        'txtDatePurchased
        '
        Me.txtDatePurchased.EditValue = Nothing
        Me.txtDatePurchased.Enabled = False
        Me.txtDatePurchased.Location = New System.Drawing.Point(173, 111)
        Me.txtDatePurchased.Name = "txtDatePurchased"
        Me.txtDatePurchased.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDatePurchased.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDatePurchased.Size = New System.Drawing.Size(120, 22)
        Me.txtDatePurchased.TabIndex = 19
        '
        'txtPiBoxID
        '
        Me.txtPiBoxID.Enabled = False
        Me.txtPiBoxID.Location = New System.Drawing.Point(403, 268)
        Me.txtPiBoxID.Name = "txtPiBoxID"
        Me.txtPiBoxID.Size = New System.Drawing.Size(125, 22)
        Me.txtPiBoxID.TabIndex = 23
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(307, 268)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl8.TabIndex = 22
        Me.LabelControl8.Text = "P-I-Box ID"
        '
        'txtBoxID
        '
        Me.txtBoxID.Enabled = False
        Me.txtBoxID.Location = New System.Drawing.Point(173, 268)
        Me.txtBoxID.Name = "txtBoxID"
        Me.txtBoxID.Size = New System.Drawing.Size(120, 22)
        Me.txtBoxID.TabIndex = 21
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(38, 268)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(36, 16)
        Me.LabelControl9.TabIndex = 20
        Me.LabelControl9.Text = "Box ID"
        '
        'txtDVDStatus
        '
        Me.txtDVDStatus.Enabled = False
        Me.txtDVDStatus.Location = New System.Drawing.Point(173, 295)
        Me.txtDVDStatus.Name = "txtDVDStatus"
        Me.txtDVDStatus.Size = New System.Drawing.Size(120, 22)
        Me.txtDVDStatus.TabIndex = 25
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(38, 295)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(64, 16)
        Me.LabelControl10.TabIndex = 24
        Me.LabelControl10.Text = "DVD Status"
        '
        'txtInOut
        '
        Me.txtInOut.Enabled = False
        Me.txtInOut.Location = New System.Drawing.Point(403, 295)
        Me.txtInOut.Name = "txtInOut"
        Me.txtInOut.Size = New System.Drawing.Size(125, 22)
        Me.txtInOut.TabIndex = 27
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(307, 295)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(31, 16)
        Me.LabelControl11.TabIndex = 26
        Me.LabelControl11.Text = "InOut"
        '
        'btnSetDVDLost
        '
        Me.btnSetDVDLost.Location = New System.Drawing.Point(403, 65)
        Me.btnSetDVDLost.Name = "btnSetDVDLost"
        Me.btnSetDVDLost.Size = New System.Drawing.Size(125, 26)
        Me.btnSetDVDLost.TabIndex = 28
        Me.btnSetDVDLost.Text = "DVD Perdu"
        Me.btnSetDVDLost.ToolTip = "Definir ce DVD comme Bizzarement Perdu"
        '
        'btnChgDVD
        '
        Me.btnChgDVD.Location = New System.Drawing.Point(403, 120)
        Me.btnChgDVD.Name = "btnChgDVD"
        Me.btnChgDVD.Size = New System.Drawing.Size(125, 27)
        Me.btnChgDVD.TabIndex = 29
        Me.btnChgDVD.Text = "Changer le DVD"
        Me.btnChgDVD.ToolTip = "Supprimer cette commande"
        '
        'cmbDVDID
        '
        Me.cmbDVDID.Location = New System.Drawing.Point(538, 212)
        Me.cmbDVDID.Name = "cmbDVDID"
        Me.cmbDVDID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDVDID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_dvdid", "products_dvdid", 80, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("box_id", "box_id", 38, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("pibox_id", "pibox_id", 46, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbDVDID.Properties.DataSource = Me.DsProducts1.products_dvd_stock_1
        Me.cmbDVDID.Properties.DisplayMember = "products_dvdid"
        Me.cmbDVDID.Properties.NullText = ""
        Me.cmbDVDID.Properties.ValueMember = "products_dvdid"
        Me.cmbDVDID.Size = New System.Drawing.Size(124, 22)
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
        Me.txtDVDId.Location = New System.Drawing.Point(403, 212)
        Me.txtDVDId.Name = "txtDVDId"
        Me.txtDVDId.Size = New System.Drawing.Size(125, 22)
        Me.txtDVDId.TabIndex = 31
        '
        'btnSetAsSold
        '
        Me.btnSetAsSold.Location = New System.Drawing.Point(403, 148)
        Me.btnSetAsSold.Name = "btnSetAsSold"
        Me.btnSetAsSold.Size = New System.Drawing.Size(125, 26)
        Me.btnSetAsSold.TabIndex = 32
        Me.btnSetAsSold.Text = "Set DVD as SOLD"
        Me.btnSetAsSold.ToolTip = "Supprimer cette commande"
        '
        'txtCoverBoxID
        '
        Me.txtCoverBoxID.Enabled = False
        Me.txtCoverBoxID.Location = New System.Drawing.Point(173, 323)
        Me.txtCoverBoxID.Name = "txtCoverBoxID"
        Me.txtCoverBoxID.Size = New System.Drawing.Size(120, 22)
        Me.txtCoverBoxID.TabIndex = 34
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(38, 323)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl12.TabIndex = 33
        Me.LabelControl12.Text = "Cover Box"
        '
        'frmModifyShoppingOrder
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(608, 366)
        Me.Controls.Add(Me.txtCoverBoxID)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.btnSetAsSold)
        Me.Controls.Add(Me.txtDVDId)
        Me.Controls.Add(Me.cmbDVDID)
        Me.Controls.Add(Me.btnChgDVD)
        Me.Controls.Add(Me.btnSetDVDLost)
        Me.Controls.Add(Me.txtInOut)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtDVDStatus)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtPiBoxID)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtBoxID)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtDatePurchased)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtProductTitle)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnDeleteOrder)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frmModifyShoppingOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmModifyShoppingOrder"
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.txtOrderID, 0)
        Me.Controls.SetChildIndex(Me.btnSearch, 0)
        Me.Controls.SetChildIndex(Me.btnDeleteOrder, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.txtCustomerID, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.txtProductID, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.LabelControl5, 0)
        Me.Controls.SetChildIndex(Me.txtProductTitle, 0)
        Me.Controls.SetChildIndex(Me.LabelControl6, 0)
        Me.Controls.SetChildIndex(Me.txtCustomerName, 0)
        Me.Controls.SetChildIndex(Me.LabelControl7, 0)
        Me.Controls.SetChildIndex(Me.txtDatePurchased, 0)
        Me.Controls.SetChildIndex(Me.LabelControl9, 0)
        Me.Controls.SetChildIndex(Me.txtBoxID, 0)
        Me.Controls.SetChildIndex(Me.LabelControl8, 0)
        Me.Controls.SetChildIndex(Me.txtPiBoxID, 0)
        Me.Controls.SetChildIndex(Me.LabelControl10, 0)
        Me.Controls.SetChildIndex(Me.txtDVDStatus, 0)
        Me.Controls.SetChildIndex(Me.LabelControl11, 0)
        Me.Controls.SetChildIndex(Me.txtInOut, 0)
        Me.Controls.SetChildIndex(Me.btnSetDVDLost, 0)
        Me.Controls.SetChildIndex(Me.btnChgDVD, 0)
        Me.Controls.SetChildIndex(Me.cmbDVDID, 0)
        Me.Controls.SetChildIndex(Me.txtDVDId, 0)
        Me.Controls.SetChildIndex(Me.btnSetAsSold, 0)
        Me.Controls.SetChildIndex(Me.LabelControl12, 0)
        Me.Controls.SetChildIndex(Me.txtCoverBoxID, 0)
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
        CType(Me.txtCoverBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub

    Dim OrderTable As New DataTable("ShoppingOrderTable")
    Dim OrderRow As DataRow
    Dim _objProductDVD As clsProduct_DVD

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchOrderInfo()
    End Sub
    Public Sub SearchOrderInfo(Optional ByVal vSearchCover As Boolean = True)
        If txtOrderID.EditValue & "" = "" Then Exit Sub
        If Not IsNumeric(txtOrderID.EditValue) Then Exit Sub
        Dim _SQLTxt As String
        _SQLTxt = " SELECT s.shopping_orders_id, s.customers_id, s.`date` as order_date, s.products_id, s.quantity, s.`status` as order_status, " & _
                  " sdvd.dvd_id, s.price, s.discount_code_id, c.customers_firstname, c.customers_lastname, c.EntityID, c.customers_gender, " & _
                  " c.customers_email_address, c.customers_default_address_id,  " & _
                  " ab.entry_street_address as customers_street_address, ab.entry_postcode as customers_postcode, ab.entry_city as customers_city, " & _
                  " ab.entry_country_id as customers_country_id, ctry.countries_name as customers_country,  " & _
                  " p.products_model, p.products_type, p.products_media, p.products_status, pd.products_dvd_status, " & _
                  " pd.box_id, pd.pibox_id, pd.`inout` " & _
                  " FROM shopping_orders s " & _
                  " left join shopping_orders_dvd_id sdvd on sdvd.shopping_orders_id = s.shopping_orders_id and sdvd.products_id = s.products_id " & _
                  " left join customers c on c.customers_id = s.customers_id " & _
                  " left join address_book ab on ab.address_book_id = c.customers_default_address_id and ab.customers_id = c.customers_id " & _
                  " left join countries ctry on ctry.countries_id = ab.entry_country_id " & _
                  " left join products p on p.products_id = s.products_id " & _
                  " left join products_dvd pd on pd.products_id = s.products_id and pd.products_dvdid = sdvd.dvd_id " & _
                  " where s.status = 1 and s.shopping_orders_id = " & txtOrderID.EditValue
        If txtDVDId.EditValue <> -1 Then
            _SQLTxt = _SQLTxt & " AND sdvd.dvd_id = " & txtDVDId.EditValue
        End If
        OrderTable.Clear()
        DvdPostData.clsConnection.FillDataSet(OrderTable, _SQLTxt)
        If OrderTable.Rows.Count = 1 Then
            OrderRow = OrderTable.Rows(0)
        Else
            OrderRow = Nothing
            _objProductDVD = Nothing
        End If
        If Not IsNothing(OrderRow) Then
            _objProductDVD = New clsProduct_DVD(SessionInfo, DsProducts1, OrderRow("products_id"), CInt("0" & OrderRow("dvd_id")))
            txtDatePurchased.EditValue = OrderRow("order_date")
            txtCustomerID.EditValue = OrderRow("customers_id")
            txtCustomerName.EditValue = OrderRow("customers_lastname") & " " & OrderRow("customers_firstname")
            txtProductID.EditValue = OrderRow("products_id")
            txtDVDId.EditValue = OrderRow("dvd_id")
            txtProductTitle.EditValue = OrderRow("products_model")
            _objProductDVD.Load_One_Products_DVD_Info()
            If Not IsNothing(OrderRow) Then
                txtBoxID.EditValue = OrderRow("box_id")
                txtPiBoxID.EditValue = OrderRow("pibox_id")
                txtDVDStatus.EditValue = OrderRow("products_dvd_status")
                txtInOut.EditValue = OrderRow("inout")
            Else
                txtBoxID.EditValue = ""
                txtPiBoxID.EditValue = ""
                txtDVDStatus.EditValue = ""
                txtInOut.EditValue = ""
            End If
            LoadAVailableDVDs()
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
        If vSearchCover = True Then
            SearchCovers()
        End If
    End Sub
    Private Sub LoadAVailableDVDs()
        DsProducts1.Tables("products_dvd_stock_1").Clear()
        Dim _SQLtxt As String = "SELECT products_id, products_dvdid, `inout`, box_id, pibox_id, products_dvd_status from products_dvd " & _
            " where `inout` = 1 and products_dvd_status = 1 and box_id > 0 AND products_id = " & OrderRow("products_id") & " order by box_id asc "
        DvdPostData.clsConnection.FillDataSet(DsProducts1.Tables("products_dvd_stock_1"), _SQLtxt)
    End Sub
    Private Sub btnDeleteOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteOrder.Click
        Dim _SQLTxt As String = "UPDATE shopping_orders set `status` = 9 WHERE shopping_orders_id = " & txtOrderID.EditValue
        Dim _Nbr As Integer
        _Nbr = DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        If _Nbr <> 1 Then
            MsgBox("Something went wrong during the save.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        MsgBox("Commande annullée", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub btnSetDVDLost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetDVDLost.Click
        'objProductsDVD.SetProductsStatusBox(15, 0, 0)
        If Not IsNothing(OrderRow) Then
            If IsNumeric(OrderRow("products_id")) And OrderRow("dvd_id") <> 0 Then

                _objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.BIZARREMENT_PERDU, _
                                                  "Modify Shopping Order", _
                                                  DvdPostData.ClsProducts_dvd_state.state.SALE, _objProductDVD.INOUT)

                MsgBox("Statut du DVD mis a 'Bizarement Perdu'", MsgBoxStyle.Exclamation)
                LoadAVailableDVDs()
            End If
        End If
    End Sub
    Private Sub btnChgDVD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChgDVD.Click
        Dim _row As DataRowView = cmbDVDID.Properties.GetDataSourceRowByKeyValue(cmbDVDID.EditValue)
        Dim _PreviousDVDId As Integer = txtDVDId.EditValue
        Dim _previousBox_id As Integer = txtBoxID.EditValue
        Dim _previous_PiBox_id As Integer = txtPiBoxID.EditValue
        Dim _objProd As clsProduct_DVD
        Dim _DS As New dsProducts
        If IsNothing(_row) Then
            MsgBox("Select a DVD first", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If Not IsNumeric(txtDVDId.EditValue) Then
            MsgBox("DVD ID must be a number, please re-enter", MsgBoxStyle.Critical)
            Exit Sub
        End If
        txtBoxID.EditValue = _row("box_id")
        txtPiBoxID.EditValue = _row("pibox_id")
        txtDVDId.EditValue = _row("products_dvdid")
        'Set The Previous DVD back to OK


        Dim _SQLTxt As String = "UPDATE shopping_orders_dvd_id set dvd_id = " & txtDVDId.EditValue & _
                     " WHERE shopping_orders_id = " & txtOrderID.EditValue & " AND products_id = " & OrderRow("products_id") & _
                     " AND dvd_id = " & _PreviousDVDId
        Dim _Nbr As Integer
        _Nbr = DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        If _Nbr <> 1 Then
            MsgBox("Something went wrong during the save.", MsgBoxStyle.Critical)
        End If
        'Set The Current DVD to Prep For Sold
        _objProd = New clsProduct_DVD(SessionInfo, _DS, txtProductID.EditValue, txtDVDId.EditValue)
        ' _objProd.ChangeDVDStatus(1, txtBoxID.EditValue, txtPiBoxID.EditValue, "Un-Picking for Sale")

        _objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK, _
                                                    _previousBox_id, _previous_PiBox_id, _
                                                         "Un-Picking for Sale", _
                                                         DvdPostData.ClsProducts_dvd_state.state.SALE)

    End Sub
    Private Sub btnSetAsSold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetAsSold.Click
        If IsNothing(_objProductDVD) Then Exit Sub
        If IsNothing(OrderRow) Then Exit Sub
        If OrderRow("order_status") <> 1 Then
            MsgBox("Already Expedited or Canceled", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        'Set Status as Sold
        _objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.DVD_SOLD, _
                                                txtBoxID.EditValue, txtPiBoxID.EditValue, _
                                                      "DVD Is Sold", _
                                                      DvdPostData.ClsProducts_dvd_state.state.SALE)


        'Insert as Sold History
        Dim _SQLTxt As String = "insert into  products_dvd_sold  (products_id ,products_dvdid,date_added) values ('" & _
              _objProductDVD.ProductsID & "', '" & _objProductDVD.DvdId & "', now())"
        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        'Change Order Status
        _SQLTxt = "update shopping_orders set `status` = 2 where shopping_orders_id = " & OrderRow("shopping_orders_id")
        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        'Decrease Cover Qty
        If IsNumeric(txtCoverBoxID.EditValue) Then
            _SQLTxt = "update products_cover set qty = qty - 1 where products_id = " & _objProductDVD.ProductsID & " and cover_box_id = " & txtCoverBoxID.EditValue
            DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        End If
        SearchOrderInfo()
        MsgBox("Done", MsgBoxStyle.Exclamation)
    End Sub
    Public Sub SearchCovers()
        Dim _cover_row As DataRow
        Dim _SQLTxt As String = ""
        Dim _DS As New DataSet
        _DS.Tables.Add("tmptable")
        _DS.Tables("tmptable").Clear()
        _SQLTxt = "select * from products_cover where products_id = " & _objProductDVD.ProductsID & " order by cover_box_id "
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("tmptable"), _SQLTxt)
        txtCoverBoxID.EditValue = ""
        If _DS.Tables("tmptable").Rows.Count > 0 Then
            _cover_row = _DS.Tables("tmptable").Rows(0)
            txtCoverBoxID = _cover_row("cover_box_id")
        End If
    End Sub
End Class

