<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatusOrder
    Inherits System.Windows.Forms.Form

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
        Me.cmbStatusOrder = New DevExpress.XtraEditors.LookUpEdit
        Me.lblOrderid = New DevExpress.XtraEditors.LabelControl
        Me.lblValueOrder_id = New DevExpress.XtraEditors.LabelControl
        Me.btnChangeOrderStatus = New DevExpress.XtraEditors.SimpleButton
        Me.txtProducts_id = New DevExpress.XtraEditors.TextEdit
        Me.lblProducts_id = New DevExpress.XtraEditors.LabelControl
        Me.lblDvdId = New DevExpress.XtraEditors.LabelControl
        Me.txtDVDid = New DevExpress.XtraEditors.TextEdit
        Me.btncreateInvoice = New DevExpress.XtraEditors.SimpleButton
        CType(Me.cmbStatusOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVDid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbStatusOrder
        '
        Me.cmbStatusOrder.Location = New System.Drawing.Point(12, 50)
        Me.cmbStatusOrder.Name = "cmbStatusOrder"
        Me.cmbStatusOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStatusOrder.Properties.NullText = ""
        Me.cmbStatusOrder.Size = New System.Drawing.Size(203, 22)
        Me.cmbStatusOrder.TabIndex = 0
        '
        'lblOrderid
        '
        Me.lblOrderid.Location = New System.Drawing.Point(12, 12)
        Me.lblOrderid.Name = "lblOrderid"
        Me.lblOrderid.Size = New System.Drawing.Size(63, 16)
        Me.lblOrderid.TabIndex = 1
        Me.lblOrderid.Text = "orders_id :"
        '
        'lblValueOrder_id
        '
        Me.lblValueOrder_id.Location = New System.Drawing.Point(82, 13)
        Me.lblValueOrder_id.Name = "lblValueOrder_id"
        Me.lblValueOrder_id.Size = New System.Drawing.Size(7, 16)
        Me.lblValueOrder_id.TabIndex = 2
        Me.lblValueOrder_id.Text = "0"
        '
        'btnChangeOrderStatus
        '
        Me.btnChangeOrderStatus.Location = New System.Drawing.Point(11, 195)
        Me.btnChangeOrderStatus.Name = "btnChangeOrderStatus"
        Me.btnChangeOrderStatus.Size = New System.Drawing.Size(98, 29)
        Me.btnChangeOrderStatus.TabIndex = 3
        Me.btnChangeOrderStatus.Text = "changer status"
        '
        'txtProducts_id
        '
        Me.txtProducts_id.Location = New System.Drawing.Point(93, 90)
        Me.txtProducts_id.Name = "txtProducts_id"
        Me.txtProducts_id.Size = New System.Drawing.Size(122, 22)
        Me.txtProducts_id.TabIndex = 4
        '
        'lblProducts_id
        '
        Me.lblProducts_id.Location = New System.Drawing.Point(11, 93)
        Me.lblProducts_id.Name = "lblProducts_id"
        Me.lblProducts_id.Size = New System.Drawing.Size(66, 16)
        Me.lblProducts_id.TabIndex = 5
        Me.lblProducts_id.Text = "products_id"
        '
        'lblDvdId
        '
        Me.lblDvdId.Location = New System.Drawing.Point(11, 121)
        Me.lblDvdId.Name = "lblDvdId"
        Me.lblDvdId.Size = New System.Drawing.Size(37, 16)
        Me.lblDvdId.TabIndex = 7
        Me.lblDvdId.Text = "dvd_id"
        '
        'txtDVDid
        '
        Me.txtDVDid.Location = New System.Drawing.Point(93, 118)
        Me.txtDVDid.Name = "txtDVDid"
        Me.txtDVDid.Size = New System.Drawing.Size(122, 22)
        Me.txtDVDid.TabIndex = 6
        '
        'btncreateInvoice
        '
        Me.btncreateInvoice.Location = New System.Drawing.Point(12, 160)
        Me.btncreateInvoice.Name = "btncreateInvoice"
        Me.btncreateInvoice.Size = New System.Drawing.Size(98, 29)
        Me.btncreateInvoice.TabIndex = 8
        Me.btncreateInvoice.Text = "creer facture"
        '
        'frmStatusOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 271)
        Me.Controls.Add(Me.btncreateInvoice)
        Me.Controls.Add(Me.lblDvdId)
        Me.Controls.Add(Me.txtDVDid)
        Me.Controls.Add(Me.lblProducts_id)
        Me.Controls.Add(Me.txtProducts_id)
        Me.Controls.Add(Me.btnChangeOrderStatus)
        Me.Controls.Add(Me.lblValueOrder_id)
        Me.Controls.Add(Me.lblOrderid)
        Me.Controls.Add(Me.cmbStatusOrder)
        Me.Name = "frmStatusOrder"
        Me.Text = "status order change"
        CType(Me.cmbStatusOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVDid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbStatusOrder As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblOrderid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValueOrder_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnChangeOrderStatus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtProducts_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblProducts_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDvdId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDVDid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btncreateInvoice As DevExpress.XtraEditors.SimpleButton
End Class
