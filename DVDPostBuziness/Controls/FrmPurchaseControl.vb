Public Class FrmPurchaseControl
    Private _IsOrdersDetails As Boolean
    Private _idCurrent As Integer

    Private _title As String
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            _title = value
            GCPurchase.Text = _title
        End Set
    End Property

    Private _products_id As Integer
    Public Property products_id() As Integer
        Get
            Return _products_id
        End Get
        Set(ByVal value As Integer)
            _products_id = value
        End Set
    End Property


    Public Sub RecursExpand(ByVal masterView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal masterRowHandle As Integer)
        ' Prevent excessive visual updates.
        masterView.BeginUpdate()
        Try
            ' Get the number of master-detail relationships.
            Dim relationCount As Integer = masterView.GetRelationCount(masterRowHandle)
            ' Iterate through relationships.
            Dim index As Integer
            For index = relationCount - 1 To 0 Step -1
                ' Open the detail View for the current relationship.
                masterView.ExpandMasterRow(masterRowHandle, index)
                ' Get the detail View.
                Dim childView As DevExpress.XtraGrid.Views.Base.ColumnView = masterView.GetDetailView(masterRowHandle, index)
                If TypeOf childView Is DevExpress.XtraGrid.Views.Grid.GridView Then
                    ' Get the number of rows in the detail View.
                    Dim childRowCount As Integer = CType(childView, DevExpress.XtraGrid.Views.Grid.GridView).DataRowCount
                    ' Expand child rows recursively.
                    Dim handle As Integer
                    For handle = 0 To childRowCount - 1
                        RecursExpand(childView, handle)
                    Next
                End If
            Next
        Finally
            ' Enable visual updates.
            masterView.EndUpdate()
        End Try
    End Sub


    Private Sub loadData()
        Dim sql As String
        Dim dtMaster As DataTable
        Dim dtDetail As DataTable
        Dim ds As New DataSet

        sql = PlushData.ClsPurchaseSale.GetSelectOrdersPurchase(products_id)
        dtMaster = PlushData.clsConnection.FillDataSet(sql)

        sql = PlushData.ClsPurchaseSale.GetSelectOrdersDetailsPurchase(products_id)
        dtDetail = PlushData.clsConnection.FillDataSet(sql)

        ds.Tables.Add(dtMaster)
        ds.Tables.Add(dtDetail)

        ds.Relations.Add("Orders Detail", ds.Tables(0).Columns("OrdersPurchase_id"), ds.Tables(1).Columns("OrdersPurchase_id"), False)
        GridPurchase.LevelTree.Nodes(0).RelationName = "Orders Detail"
        GridPurchase.ShowOnlyPredefinedDetails = True
        GridPurchase.DataSource = dtMaster

        GridViewOrdersDetailsPurchase.ViewCaption = ""

        ' CType(GridPurchase.MainView, DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups()
        ' GridViewOrdersPurchase.ExpandAllGroups()
        ' GridViewOrdersDetailsPurchase.ExpandAllGroups()
        'GridPurchase.LevelTree.Nodes.Add("OrdersRelations", GridView1)

        'GridViewOrdersPurchase.ChildGridLevelName = "OrdersRelations"
        'Dim col As New DevExpress.XtraGrid.Columns.GridColumn

        'GridViewOrdersPurchase.OptionsView.ShowChildrenInGroupPanel = True
        'GridView1.SynchronizeClones = True

        'col.FieldName = "qty"
        'col.Caption = "qty"
        'GridView1.Columns.Add(col)
        ' GridViewOrdersPurchase.SetMasterRowExpanded(GridViewOrdersPurchase.FocusedRowHandle, True)
        GridPurchase.RefreshDataSource()



    End Sub
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Dim menuStrip As New PlushBuziness.contextMenu()
        GridPurchase.ContextMenuStrip = menuStrip
        '' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub displayDetail(ByVal dr As DataRow)

        clean(_IsOrdersDetails)
        If dr.Table.Columns.Contains("supplier") AndAlso dr("supplier") IsNot DBNull.Value Then
            txtSupplier.EditValue = dr("supplier")
        Else
            txtSupplier.EditValue = Nothing
        End If

        If dr.Table.Columns.Contains("cost") AndAlso dr("cost") IsNot DBNull.Value Then
            txtCost.EditValue = dr("cost")
        Else
            txtCost.EditValue = Nothing
        End If

        If dr.Table.Columns.Contains("status_order") AndAlso dr("status_order") IsNot DBNull.Value Then
            cmbStatus_order.EditValue = dr("status_order")
            If cmbStatus_order.EditValue = PlushTools.clsEnum.getNameStrEnum(PlushData.ClsPurchaseSale.StatusOrder.CLOSED) Then
                GCPurchase.Visible = False
            Else
                GCPurchase.Visible = True
            End If
        End If

        If dr("qty") IsNot DBNull.Value Then
            txtQty.EditValue = dr("qty")
        End If



        If dr.Table.Columns.Contains("OrdersDetailsPurchase_id") AndAlso dr("OrdersDetailsPurchase_id") IsNot DBNull.Value Then
            _idCurrent = dr("OrdersDetailsPurchase_id")
        Else
            _idCurrent = dr("OrdersPurchase_id")
        End If
    End Sub

    Private Sub FrmPurchaseControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadData()
    End Sub

    Private Sub GridViewOrdersPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewOrdersPurchase.Click
        Dim PurchaseRow As DataRow
        PurchaseRow = GridViewOrdersPurchase.GetDataRow(GridViewOrdersPurchase.FocusedRowHandle)
        If PurchaseRow IsNot Nothing Then
            _IsOrdersDetails = False
            displayDetail(PurchaseRow)
            ' RecursExpand(GridViewOrdersPurchase, GridViewOrdersPurchase.FocusedRowHandle)

            ' GridViewOrdersPurchase.SetMasterRowExpanded(GridViewOrdersPurchase.FocusedRowHandle, True)
        End If
    End Sub

    Private Sub GridViewOrdersDetailsPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewOrdersDetailsPurchase.Click
        'Dim PurchaseRow As DataRow

        'GridViewOrdersPurchase.GetDetailView(GridViewOrdersPurchase.FocusedRowHandle, 0)
        'PurchaseRow = GridViewOrdersDetailsPurchase.GetDataRow(GridViewOrdersDetailsPurchase.FocusedRowHandle)
        'If PurchaseRow IsNot Nothing Then
        '    displayDetail(PurchaseRow)
        '    _IsOrdersDetails = True
        'End If

        ' Obtain the focused row of the currently focused view
        Dim row As Integer = CType(GridPurchase.FocusedView, DevExpress.XtraGrid.Views.Base.ColumnView).FocusedRowHandle

        ' Obtain the focused view of a specific detail view
        ' gridView1 corresponds to GridControl.MainView
        'Dim detailView As DevExpress.XtraGrid.Views.Base.ColumnView = CType(GridViewOrdersPurchase.GetDetailView(0, 0), DevExpress.XtraGrid.Views.Base.ColumnView)
        'row = detailView.FocusedRowHandle

        Dim PurchaseRow As DataRow

        'GridViewOrdersPurchase.GetDetailView(GridViewOrdersPurchase.FocusedRowHandle, 0)
        ' PurchaseRow = GridViewOrdersDetailsPurchase.GetDataRow(detailView.FocusedRowHandle)
        PurchaseRow = GridViewOrdersPurchase.GetDetailView(GridViewOrdersPurchase.FocusedRowHandle, 0).GetRow(row).row
        If PurchaseRow IsNot Nothing Then
            _IsOrdersDetails = True
            displayDetail(PurchaseRow)

        End If


    End Sub

    Private Sub saveData(ByVal id As Integer, ByVal isOrdersDetails As Boolean)
        Dim qty As Integer
        Dim sql As String

        If isOrdersDetails Then
            Dim ordersPurchase_id As Integer

            If id = 0 Then
                ' news orderDetail 

                Dim PurchaseRow As DataRow
                PurchaseRow = GridViewOrdersPurchase.GetDataRow(GridViewOrdersPurchase.FocusedRowHandle)
                ordersPurchase_id = PurchaseRow("OrdersPurchase_id")

                qty = txtQty.EditValue
                sql = PlushData.ClsPurchaseSale.GetInsertOrdersDetailsPurchase(ordersPurchase_id, qty)
                PlushData.clsConnection.ExecuteNonQuery(sql)
            Else
                qty = txtQty.EditValue
                sql = PlushData.ClsPurchaseSale.GetUpdateOrdersDetailsPurchase(id, qty)
                PlushData.clsConnection.ExecuteNonQuery(sql)
            End If

        ElseIf txtQty.EditValue IsNot Nothing Then
            Dim cost As Decimal
            Dim supplier As String
            Dim status As String


            qty = txtQty.EditValue
            cost = txtCost.EditValue
            supplier = txtSupplier.EditValue

            If id = 0 Then
                ' news order
                sql = PlushData.ClsPurchaseSale.GetInsertOrdersPurchase(products_id, qty, cost, supplier)
                PlushData.clsConnection.ExecuteNonQuery(sql)
            Else
                status = cmbStatus_order.EditValue
                sql = PlushData.ClsPurchaseSale.GetUpdateOrdersPurchase(id, qty, cost, supplier, status)
                PlushData.clsConnection.ExecuteNonQuery(sql)
            End If
        End If
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        saveData(_idCurrent, _IsOrdersDetails)
        loadData()

    End Sub


    Private Sub clean(ByVal isOrdersDetails As Boolean)

        txtQty.Visible = True
        lblqty.Visible = True

        txtCost.Visible = Not isOrdersDetails
        lblCost.Visible = Not isOrdersDetails
        txtSupplier.Visible = Not isOrdersDetails
        lblSupplier.Visible = Not isOrdersDetails

        btnAddDetails.Visible = Not isOrdersDetails
        cmbStatus_order.Visible = Not isOrdersDetails
        lblStatus.Visible = Not isOrdersDetails

        txtQty.EditValue = String.Empty
        txtCost.EditValue = String.Empty
        txtSupplier.EditValue = String.Empty

        _idCurrent = 0
    End Sub
    Private Sub BtnClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClean.Click
        clean(_IsOrdersDetails)
    End Sub

    Private Sub delete(ByVal id As Integer, ByVal isOrdersDetails As Boolean)
        If id > 0 Then
            Dim sql As String
            If isOrdersDetails Then
                sql = PlushData.ClsPurchaseSale.GetDeleteOrdersDetailsPurchase(id)
                PlushData.clsConnection.ExecuteNonQuery(sql)
            Else
                sql = PlushData.ClsPurchaseSale.GetDeleteOrdersPurchase(id)
                PlushData.clsConnection.ExecuteNonQuery(sql)
            End If
        End If

    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        delete(_idCurrent, _IsOrdersDetails)
        loadData()
    End Sub

    'Private Sub GridViewOrdersDetailsPurchase_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewOrdersDetailsPurchase.FocusedRowChanged
    '    Dim rowHandle As Integer = e.FocusedRowHandle
    '    Dim gridChild As DevExpress.XtraGrid.Views.Grid.GridView = sender
    '    ' Dim rowDetail As DataRow = gridChild.GetFocusedDataRow()
    '    Dim rowDetail As DataRow = gridChild.GetDataRow(rowHandle)
    '    If rowDetail IsNot Nothing Then
    '        _IsOrdersDetails = True
    '        displayDetail(rowDetail)

    '    End If
    'End Sub

    Private Sub btnAddDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDetails.Click
        _IsOrdersDetails = True
        clean(_IsOrdersDetails)
    End Sub
End Class