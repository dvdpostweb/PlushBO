<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateShoppingOrder
    Inherits BizzLib.frmBKForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtCustomerID = New DevExpress.XtraEditors.TextEdit
        Me.txtProductID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtQty = New DevExpress.XtraEditors.SpinEdit
        Me.btnShoppingOrder = New DevExpress.XtraEditors.SimpleButton
        Me.txtPrice = New DevExpress.XtraEditors.CalcEdit
        Me.txtCustomerName = New DevExpress.XtraEditors.TextEdit
        Me.txtProductModel = New DevExpress.XtraEditors.TextEdit
        Me.txtProductType = New DevExpress.XtraEditors.TextEdit
        Me.cmbState = New System.Windows.Forms.ComboBox
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductModel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(74, 90)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Customers ID"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(146, 87)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(133, 20)
        Me.txtCustomerID.TabIndex = 5
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(146, 113)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(133, 20)
        Me.txtProductID.TabIndex = 7
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(74, 116)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Product ID"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(74, 193)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Price"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(74, 167)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl4.TabIndex = 10
        Me.LabelControl4.Text = "Qty"
        '
        'txtQty
        '
        Me.txtQty.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtQty.Location = New System.Drawing.Point(146, 164)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtQty.Size = New System.Drawing.Size(133, 20)
        Me.txtQty.TabIndex = 11
        '
        'btnShoppingOrder
        '
        Me.btnShoppingOrder.Location = New System.Drawing.Point(146, 216)
        Me.btnShoppingOrder.Name = "btnShoppingOrder"
        Me.btnShoppingOrder.Size = New System.Drawing.Size(133, 23)
        Me.btnShoppingOrder.TabIndex = 12
        Me.btnShoppingOrder.Text = "Create Shopping Order"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(146, 190)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPrice.Size = New System.Drawing.Size(133, 20)
        Me.txtPrice.TabIndex = 13
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(285, 87)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(347, 20)
        Me.txtCustomerName.TabIndex = 14
        '
        'txtProductModel
        '
        Me.txtProductModel.Location = New System.Drawing.Point(285, 113)
        Me.txtProductModel.Name = "txtProductModel"
        Me.txtProductModel.Size = New System.Drawing.Size(347, 20)
        Me.txtProductModel.TabIndex = 15
        '
        'txtProductType
        '
        Me.txtProductType.Location = New System.Drawing.Point(647, 113)
        Me.txtProductType.Name = "txtProductType"
        Me.txtProductType.Size = New System.Drawing.Size(127, 20)
        Me.txtProductType.TabIndex = 16
        '
        'cmbState
        '
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Items.AddRange(New Object() {"EX_RENTAL", "NEW"})
        Me.cmbState.Location = New System.Drawing.Point(146, 137)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(133, 21)
        Me.cmbState.TabIndex = 17
        Me.cmbState.Text = "EX_RENTAL"
        '
        'frmCreateShoppingOrder
        '
        Me.ClientSize = New System.Drawing.Size(1160, 493)
        Me.Controls.Add(Me.cmbState)
        Me.Controls.Add(Me.txtProductType)
        Me.Controls.Add(Me.txtProductModel)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.btnShoppingOrder)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frmCreateShoppingOrder"
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.txtCustomerID, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.txtProductID, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.txtQty, 0)
        Me.Controls.SetChildIndex(Me.btnShoppingOrder, 0)
        Me.Controls.SetChildIndex(Me.txtPrice, 0)
        Me.Controls.SetChildIndex(Me.txtCustomerName, 0)
        Me.Controls.SetChildIndex(Me.txtProductModel, 0)
        Me.Controls.SetChildIndex(Me.txtProductType, 0)
        Me.Controls.SetChildIndex(Me.cmbState, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductModel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomerID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQty As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnShoppingOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPrice As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtCustomerName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProductModel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProductType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbState As System.Windows.Forms.ComboBox

End Class
