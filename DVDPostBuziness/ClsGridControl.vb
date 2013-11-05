Imports DevExpress.XtraEditors
Public Class ClsGridControl
    Private _gridview As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView

    Public Event Purchase_click(ByVal sender As Object, ByVal e As EventArgs)
    Public Event Sale_click(ByVal sender As Object, ByVal e As EventArgs)

    Public Sub GridPurchase_click()
        Dim products_id As Integer
        Dim nb_dvdachat As Integer
        Dim PurchaseRow As DataRow

        PurchaseRow = _gridview.GetDataRow(_gridview.FocusedRowHandle)
        If PurchaseRow("products_id") IsNot DBNull.Value Then
            products_id = PurchaseRow("products_id")
        Else
            products_id = Nothing
        End If

        If PurchaseRow("nb_dvdachat") IsNot DBNull.Value Then
            nb_dvdachat = PurchaseRow("nb_dvdachat")
        Else
            nb_dvdachat = Nothing
        End If

        'If nb_dvdachat <= 0 Then
        '    System.Windows.Forms.MessageBox.Show("No Purchase for this product")
        '    Return
        'End If

        If System.Windows.Forms.MessageBox.Show("would you like order product " & products_id, "orders", Windows.Forms.MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim frm As FrmPurchaseControl = New FrmPurchaseControl()
            frm.products_id = products_id
            frm.ShowDialog()
        End If
    End Sub
    Private Sub GridPurchase_click(ByVal sender As Object, ByVal e As System.EventArgs)
        RaiseEvent Purchase_click(sender, e)
    End Sub

    Private Sub GridSale_click(ByVal sender As Object, ByVal e As System.EventArgs)
        RaiseEvent Sale_click(sender, e)
    End Sub

    Public Sub addColumnButtonOrderSale(ByVal grid As DevExpress.XtraGrid.GridControl, _
                                  ByVal gridview As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView _
                               )

        Dim btnAddSale As New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit

        _gridview = gridview
        grid.RepositoryItems.Clear()
        If grid.RepositoryItems.Count = 0 Then

            btnAddSale.AutoHeight = False
            ' btnSendIt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            btnAddSale.Name = "btnAddSale"
            btnAddSale.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
            'btnSendIt.Buttons. 
            grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {btnAddSale})
            AddHandler btnAddSale.Click, AddressOf GridSale_click
        Else
            btnAddSale = grid.RepositoryItems(0)
        End If

        Dim colAddSale As New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        colAddSale.Caption = "Sale"
        colAddSale.ColumnEdit = btnAddSale
        colAddSale.Name = "colAddSale"
        colAddSale.Visible = True
        colAddSale.OptionsColumn.ReadOnly = False
        colAddSale.OptionsColumn.AllowEdit = True
        gridview.OptionsBehavior.Editable = True


        gridview.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {colAddSale})
        gridview.Bands(0).Columns.Add(colAddSale)
        ' Grid1.Views(0).PopulateColumns()
    End Sub
    Public Sub addColumnButtonOrderPurchase(ByVal grid As DevExpress.XtraGrid.GridControl, _
                                   ByVal gridview As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView _
                                )

        Dim btnAddPurchase As New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit

        _gridview = gridview
        grid.RepositoryItems.Clear()
        If grid.RepositoryItems.Count = 0 Then

            btnAddPurchase.AutoHeight = False
            ' btnSendIt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            btnAddPurchase.Name = "btnAddPurchase"
            btnAddPurchase.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
            'btnSendIt.Buttons. 
            grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {btnAddPurchase})
            AddHandler btnAddPurchase.Click, AddressOf GridPurchase_click
        Else
            btnAddPurchase = grid.RepositoryItems(0)
        End If

        Dim colAddPurchase As New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        colAddPurchase.Caption = "Purchase"
        colAddPurchase.ColumnEdit = btnAddPurchase
        colAddPurchase.Name = "colAddPurchase"
        colAddPurchase.Visible = True
        colAddPurchase.OptionsColumn.ReadOnly = False
        colAddPurchase.OptionsColumn.AllowEdit = True
        gridview.OptionsBehavior.Editable = True


        gridview.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {colAddPurchase})
        gridview.Bands(0).Columns.Add(colAddPurchase)
        ' Grid1.Views(0).PopulateColumns()
    End Sub

End Class
