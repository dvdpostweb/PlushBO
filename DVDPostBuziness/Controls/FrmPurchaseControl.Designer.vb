<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchaseControl
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.GridViewOrdersDetailsPurchase = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColQtyDetails = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridPurchase = New DevExpress.XtraGrid.GridControl
        Me.GridViewOrdersPurchase = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColProduct_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColProduct_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCost = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Colsupplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColDateAdded = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColdateClosed = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCPurchase = New DevExpress.XtraEditors.GroupControl
        Me.btnAddDetails = New DevExpress.XtraEditors.SimpleButton
        Me.BtnDelete = New DevExpress.XtraEditors.SimpleButton
        Me.BtnClean = New DevExpress.XtraEditors.SimpleButton
        Me.lblSupplier = New DevExpress.XtraEditors.LabelControl
        Me.txtSupplier = New DevExpress.XtraEditors.TextEdit
        Me.lblCost = New DevExpress.XtraEditors.LabelControl
        Me.txtCost = New DevExpress.XtraEditors.TextEdit
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton
        Me.lblqty = New DevExpress.XtraEditors.LabelControl
        Me.txtQty = New DevExpress.XtraEditors.TextEdit
        Me.ColStatus_Order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl
        Me.cmbStatus_order = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.GridViewOrdersDetailsPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewOrdersPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCPurchase.SuspendLayout()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStatus_order.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridViewOrdersDetailsPurchase
        '
        Me.GridViewOrdersDetailsPurchase.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColQtyDetails, Me.coldate})
        Me.GridViewOrdersDetailsPurchase.GridControl = Me.GridPurchase
        Me.GridViewOrdersDetailsPurchase.Name = "GridViewOrdersDetailsPurchase"
        Me.GridViewOrdersDetailsPurchase.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridViewOrdersDetailsPurchase.OptionsCustomization.AllowGroup = False
        Me.GridViewOrdersDetailsPurchase.OptionsView.ShowGroupPanel = False
        '
        'ColQtyDetails
        '
        Me.ColQtyDetails.Caption = "qty"
        Me.ColQtyDetails.FieldName = "qty"
        Me.ColQtyDetails.Name = "ColQtyDetails"
        Me.ColQtyDetails.OptionsColumn.AllowEdit = False
        Me.ColQtyDetails.OptionsColumn.ReadOnly = True
        Me.ColQtyDetails.Visible = True
        Me.ColQtyDetails.VisibleIndex = 0
        '
        'coldate
        '
        Me.coldate.Caption = "date"
        Me.coldate.FieldName = "date_added"
        Me.coldate.Name = "coldate"
        Me.coldate.OptionsColumn.AllowEdit = False
        Me.coldate.OptionsColumn.ReadOnly = True
        Me.coldate.Visible = True
        Me.coldate.VisibleIndex = 1
        '
        'GridPurchase
        '
        Me.GridPurchase.EmbeddedNavigator.Name = ""
        Me.GridPurchase.FormsUseDefaultLookAndFeel = False
        GridLevelNode1.LevelTemplate = Me.GridViewOrdersDetailsPurchase
        GridLevelNode1.RelationName = "level 1"
        Me.GridPurchase.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridPurchase.Location = New System.Drawing.Point(8, 1)
        Me.GridPurchase.MainView = Me.GridViewOrdersPurchase
        Me.GridPurchase.Name = "GridPurchase"
        Me.GridPurchase.Size = New System.Drawing.Size(902, 297)
        Me.GridPurchase.TabIndex = 0
        Me.GridPurchase.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewOrdersPurchase, Me.GridViewOrdersDetailsPurchase})
        '
        'GridViewOrdersPurchase
        '
        Me.GridViewOrdersPurchase.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColProduct_id, Me.ColProduct_name, Me.ColQty, Me.ColCost, Me.Colsupplier, Me.ColDateAdded, Me.ColdateClosed, Me.ColStatus_Order})
        Me.GridViewOrdersPurchase.GridControl = Me.GridPurchase
        Me.GridViewOrdersPurchase.Name = "GridViewOrdersPurchase"
        Me.GridViewOrdersPurchase.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridViewOrdersPurchase.OptionsView.ShowFooter = True
        '
        'ColProduct_id
        '
        Me.ColProduct_id.Caption = "Product_id"
        Me.ColProduct_id.FieldName = "products_id"
        Me.ColProduct_id.Name = "ColProduct_id"
        Me.ColProduct_id.OptionsColumn.AllowEdit = False
        Me.ColProduct_id.OptionsColumn.ReadOnly = True
        Me.ColProduct_id.Visible = True
        Me.ColProduct_id.VisibleIndex = 1
        Me.ColProduct_id.Width = 187
        '
        'ColProduct_name
        '
        Me.ColProduct_name.Caption = "Product_name"
        Me.ColProduct_name.FieldName = "products_name"
        Me.ColProduct_name.Name = "ColProduct_name"
        Me.ColProduct_name.OptionsColumn.AllowEdit = False
        Me.ColProduct_name.OptionsColumn.ReadOnly = True
        Me.ColProduct_name.Visible = True
        Me.ColProduct_name.VisibleIndex = 2
        Me.ColProduct_name.Width = 187
        '
        'ColQty
        '
        Me.ColQty.Caption = "qty"
        Me.ColQty.FieldName = "qty"
        Me.ColQty.Name = "ColQty"
        Me.ColQty.OptionsColumn.AllowEdit = False
        Me.ColQty.OptionsColumn.ReadOnly = True
        Me.ColQty.Visible = True
        Me.ColQty.VisibleIndex = 3
        Me.ColQty.Width = 187
        '
        'ColCost
        '
        Me.ColCost.Caption = "cost"
        Me.ColCost.FieldName = "cost"
        Me.ColCost.Name = "ColCost"
        Me.ColCost.OptionsColumn.AllowEdit = False
        Me.ColCost.OptionsColumn.ReadOnly = True
        Me.ColCost.Visible = True
        Me.ColCost.VisibleIndex = 4
        Me.ColCost.Width = 187
        '
        'Colsupplier
        '
        Me.Colsupplier.Caption = "supplier"
        Me.Colsupplier.FieldName = "supplier"
        Me.Colsupplier.Name = "Colsupplier"
        Me.Colsupplier.OptionsColumn.AllowEdit = False
        Me.Colsupplier.OptionsColumn.ReadOnly = True
        Me.Colsupplier.Visible = True
        Me.Colsupplier.VisibleIndex = 5
        Me.Colsupplier.Width = 187
        '
        'ColDateAdded
        '
        Me.ColDateAdded.Caption = "Date Order"
        Me.ColDateAdded.FieldName = "date_added"
        Me.ColDateAdded.Name = "ColDateAdded"
        Me.ColDateAdded.OptionsColumn.AllowEdit = False
        Me.ColDateAdded.OptionsColumn.ReadOnly = True
        Me.ColDateAdded.Visible = True
        Me.ColDateAdded.VisibleIndex = 6
        Me.ColDateAdded.Width = 195
        '
        'ColdateClosed
        '
        Me.ColdateClosed.Caption = "date closed"
        Me.ColdateClosed.Name = "ColdateClosed"
        Me.ColdateClosed.OptionsColumn.AllowEdit = False
        Me.ColdateClosed.OptionsColumn.ReadOnly = True
        '
        'GCPurchase
        '
        Me.GCPurchase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCPurchase.Controls.Add(Me.cmbStatus_order)
        Me.GCPurchase.Controls.Add(Me.lblStatus)
        Me.GCPurchase.Controls.Add(Me.btnAddDetails)
        Me.GCPurchase.Controls.Add(Me.BtnDelete)
        Me.GCPurchase.Controls.Add(Me.BtnClean)
        Me.GCPurchase.Controls.Add(Me.lblSupplier)
        Me.GCPurchase.Controls.Add(Me.txtSupplier)
        Me.GCPurchase.Controls.Add(Me.lblCost)
        Me.GCPurchase.Controls.Add(Me.txtCost)
        Me.GCPurchase.Controls.Add(Me.BtnSave)
        Me.GCPurchase.Controls.Add(Me.lblqty)
        Me.GCPurchase.Controls.Add(Me.txtQty)
        Me.GCPurchase.Location = New System.Drawing.Point(12, 314)
        Me.GCPurchase.Name = "GCPurchase"
        Me.GCPurchase.Size = New System.Drawing.Size(704, 113)
        Me.GCPurchase.TabIndex = 1
        '
        'btnAddDetails
        '
        Me.btnAddDetails.Location = New System.Drawing.Point(169, 74)
        Me.btnAddDetails.Name = "btnAddDetails"
        Me.btnAddDetails.Size = New System.Drawing.Size(101, 23)
        Me.btnAddDetails.TabIndex = 10
        Me.btnAddDetails.Text = "add Detail"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(304, 74)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(101, 23)
        Me.BtnDelete.TabIndex = 9
        Me.BtnDelete.Text = "Delete"
        '
        'BtnClean
        '
        Me.BtnClean.Location = New System.Drawing.Point(565, 45)
        Me.BtnClean.Name = "BtnClean"
        Me.BtnClean.Size = New System.Drawing.Size(101, 23)
        Me.BtnClean.TabIndex = 8
        Me.BtnClean.Text = "Clean"
        '
        'lblSupplier
        '
        Me.lblSupplier.Location = New System.Drawing.Point(233, 23)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(37, 13)
        Me.lblSupplier.TabIndex = 7
        Me.lblSupplier.Text = "supplier"
        '
        'txtSupplier
        '
        Me.txtSupplier.Location = New System.Drawing.Point(180, 48)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(179, 20)
        Me.txtSupplier.TabIndex = 6
        '
        'lblCost
        '
        Me.lblCost.Location = New System.Drawing.Point(114, 23)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(20, 13)
        Me.lblCost.TabIndex = 5
        Me.lblCost.Text = "cost"
        '
        'txtCost
        '
        Me.txtCost.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCost.Location = New System.Drawing.Point(92, 48)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Properties.Mask.EditMask = "n"
        Me.txtCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCost.Size = New System.Drawing.Size(58, 20)
        Me.txtCost.TabIndex = 4
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(49, 74)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(101, 23)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "save"
        '
        'lblqty
        '
        Me.lblqty.Location = New System.Drawing.Point(27, 23)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(16, 13)
        Me.lblqty.TabIndex = 1
        Me.lblqty.Text = "qty"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(10, 48)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(58, 20)
        Me.txtQty.TabIndex = 0
        '
        'ColStatus_Order
        '
        Me.ColStatus_Order.Caption = "Status"
        Me.ColStatus_Order.FieldName = "status_order"
        Me.ColStatus_Order.Name = "ColStatus_Order"
        Me.ColStatus_Order.Visible = True
        Me.ColStatus_Order.VisibleIndex = 0
        Me.ColStatus_Order.Width = 118
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(406, 23)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(30, 13)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.Text = "status"
        '
        'cmbStatus_order
        '
        Me.cmbStatus_order.EditValue = "MUSTORDER"
        Me.cmbStatus_order.Location = New System.Drawing.Point(382, 48)
        Me.cmbStatus_order.Name = "cmbStatus_order"
        Me.cmbStatus_order.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStatus_order.Properties.Items.AddRange(New Object() {"MUSTORDER", "ORDERED", "CLOSED"})
        Me.cmbStatus_order.Size = New System.Drawing.Size(100, 20)
        Me.cmbStatus_order.TabIndex = 12
        '
        'FrmPurchaseControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 458)
        Me.Controls.Add(Me.GCPurchase)
        Me.Controls.Add(Me.GridPurchase)
        Me.Name = "FrmPurchaseControl"
        Me.Text = "FrmPurchaseControl"
        CType(Me.GridViewOrdersDetailsPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewOrdersPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCPurchase.ResumeLayout(False)
        Me.GCPurchase.PerformLayout()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStatus_order.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridPurchase As DevExpress.XtraGrid.GridControl
    Friend WithEvents GCPurchase As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblqty As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCost As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSupplier As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSupplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridViewOrdersDetailsPurchase As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColQtyDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridViewOrdersPurchase As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColProduct_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProduct_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colsupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateAdded As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColdateClosed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnClean As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddDetails As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColStatus_Order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbStatus_order As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
End Class
