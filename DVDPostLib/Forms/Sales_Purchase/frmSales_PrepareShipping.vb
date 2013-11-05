Public Class frmSales_PrepareShipping
    Inherits BizzLib.frmGeneral_Browse

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
    Friend WithEvents btnAssignDVDID As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales_PrepareShipping))
        Me.btnAssignDVDID = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabParameters.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        Me.TabChart.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.SelectedTabPage = Me.TabResult
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.btnAssignDVDID)
        '
        'TabAnalyse
        '
        resources.ApplyResources(Me.TabAnalyse, "TabAnalyse")
        '
        'UcPivotGrid1
        '
        resources.ApplyResources(Me.UcPivotGrid1, "UcPivotGrid1")
        '
        'UcChart1
        '
        resources.ApplyResources(Me.UcChart1, "UcChart1")
        '
        'TabChart
        '
        resources.ApplyResources(Me.TabChart, "TabChart")
        '
        'btnAssignDVDID
        '
        resources.ApplyResources(Me.btnAssignDVDID, "btnAssignDVDID")
        Me.btnAssignDVDID.Name = "btnAssignDVDID"
        Me.HelpProvider1.SetShowHelp(Me.btnAssignDVDID, CType(resources.GetObject("btnAssignDVDID.ShowHelp"), Boolean))
        '
        'frmSales_PrepareShipping
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmSales_PrepareShipping"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabChart.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim menuStrip As New dvdpostbuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip



        objDS = New dsPur_Sls
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "shopping_orders_view1"
        MyBase.IDField = "shopping_orders_id"
        MyBase.NameField = "shopping_orders_id"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = True
        MyBase.StartUp()

        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , , False, False, True)
        CurrentDefaultSetID = cmbDefaultList.EditValue
        btnUser1.Caption = "Set as Picked/DVD"
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser2.Caption = "Set as Picked/Customer"
        btnUser2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser3.Caption = "Un-Assign DVD"
        btnUser3.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser4.Caption = "Cancel this Order"
        btnUser4.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'btnOK
        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If CurrentDefaultSetID <> 0 Then
            BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
            TabControl1.SelectedTabPage = TabResult
      
        End If
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub
    Public Overrides Sub LoadDataSet()
        Dim _SQLTxt As String
        Dim _i As Integer
              'Clear Table
        objDS.Tables(TableName).Clear()
        _SQLTxt = DvdPostData.ClsSale.GetAllShoppingOrders()
        DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)
        'Set the quantity_assigned
        Dim _row As DataRow
        Dim _RowView As DataRowView
        Dim _View As DataView
        Dim _TmpTable As New DataTable("TmpTable")
        _SQLTxt = "select s.shopping_orders_id, s.quantity, count(*) as cnt from shopping_orders s " & _
                  " left join shopping_orders_dvd_id sdvd on s.shopping_orders_id = sdvd.shopping_orders_id and " & _
                  " s.products_id = sdvd.products_id where s.`status` = 1 group by s.shopping_orders_id"
        DvdPostData.clsConnection.FillDataSet(_TmpTable, _SQLTxt)
        _View = New DataView(_TmpTable, "", "shopping_orders_id", DataViewRowState.CurrentRows)
        For Each _row In objDS.Tables(TableName).Rows
            _i = _View.Find(New Object() {_row("shopping_orders_id")})
            If _i <> -1 Then
                _RowView = _View(_i)
                If Not IsNothing(_RowView) Then
                    _row("quantity_assigned") = _RowView("cnt")
                Else
                    _row("quantity_assigned") = 0
                End If
             
            End If
        Next
        Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        _View = New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = _View
        SearchCovers()
        TabControl1.SelectedTabPage = TabResult
    End Sub
    Private Sub AssignDVDToOrder(ByVal vOrderRow As DataRow)
        'Return the DVD_ID Assigned
        Dim _SQLTxt As String = ""
        Dim _DS As New dsProducts
        _DS.Tables.Add("tmpProdDVDtable")
        _DS.Tables.Add("tmpOrderDVDTable")
        Dim _NbrOfDVDAssign As Integer = 0
        Dim _i As Integer = 0
        Dim _Products_dvd_row As DataRow

        _SQLTxt = DvdPostData.ClsSale.GetShoppingProduct(vOrderRow("shopping_orders_id"), vOrderRow("products_id"))
        _DS.Tables("tmpOrderDVDTable").Clear()
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("tmpOrderDVDTable"), _SQLTxt)

        _NbrOfDVDAssign = _DS.Tables("tmpOrderDVDTable").Rows.Count
        If vOrderRow("quantity") >= 1 And _NbrOfDVDAssign < vOrderRow("quantity") And vOrderRow("products_state") <> "NEW" Then
            _DS.Tables("tmpProdDVDtable").Clear()
            _SQLTxt = DvdPostData.ClsSale.getSalePrepareProduct(vOrderRow("products_id"))
            DvdPostData.clsConnection.FillDataSet(_DS.Tables("tmpProdDVDtable"), _SQLTxt)
            For Each _Products_dvd_row In _DS.Tables("tmpProdDVDtable").Rows
                _SQLTxt = DvdPostData.ClsSale.getInsertShoppingProduct(vOrderRow("shopping_orders_id"), vOrderRow("products_id"), _Products_dvd_row("products_dvdid"))
                DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)

                'Change Status to "Ready To Sale"
                'objProductDVD = New clsProduct_DVD(SessionInfo, _DS, vOrderRow("products_id"), _Products_dvd_row("products_dvdid"))
                ' objProductDVD.products_dvd_status = DvdPostData.clsProductDvd.DVDStatus.PREP_FOR_SOLD
                'objProductDVD.ChangeBox(objProductDVD.GetBox(), objProductDVD.GetPosBox())
                'objProductDVD.ChangeStatus(objProductDVD.products_dvd_status)
                ' objProductDVD.LogStatusDVD("DVD Is Sold")


                _NbrOfDVDAssign += 1
                If _NbrOfDVDAssign >= vOrderRow("quantity") Then
                    Exit For
                End If
            Next
        End If
        If vOrderRow("quantity") >= 1 And _NbrOfDVDAssign < vOrderRow("quantity") And vOrderRow("products_state") = "NEW" Then
            For _i = _NbrOfDVDAssign + 1 To vOrderRow("quantity")
                _SQLTxt = DvdPostData.ClsSale.getInsertShoppingProduct(vOrderRow("shopping_orders_id"), vOrderRow("products_id"), 1)
                DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
            Next
        End If

    End Sub
    Private Sub btnAssignDVDID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignDVDID.Click
        Dim _row As DataRow
        For Each _row In objDS.Tables(TableName).Rows
            AssignDVDToOrder(_row)
        Next
        LoadDataSet()
    End Sub
    Public Overrides Sub gridview1_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles GridView1.DoubleClick
        Dim _frm As New frmModifyShoppingOrder(SessionInfo)
        Dim _Orders_ID As Integer
        Dim _customers_id As Integer
        Dim _products_id As Integer
        Dim _dvd_id As Integer
        Dim _i As Integer = GridView1.FocusedRowHandle
        _Orders_ID = GridView1.GetDataRow(_i)("shopping_orders_id")
        _customers_id = GridView1.GetDataRow(_i)("customers_id")
        _products_id = GridView1.GetDataRow(_i)("products_id")
        If GridView1.GetDataRow(_i)("quantity_assigned") <> GridView1.GetDataRow(_i)("quantity") Then
            MsgBox("You must assign DVD first.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If IsDBNull(GridView1.GetDataRow(_i)("dvd_id")) Then
            _dvd_id = -1
        Else
            _dvd_id = GridView1.GetDataRow(_i)("dvd_id")
        End If
        _frm.txtOrderID.EditValue = _Orders_ID
        _frm.txtDVDId.EditValue = _dvd_id
        _frm.txtCoverBoxID.EditValue = GridView1.GetDataRow(_i)("cover_box_id")
        _frm.SearchOrderInfo(False)
        _frm.ShowDialog(Me)
    End Sub
    Private Sub SearchCovers()
        Dim _row As DataRow
        Dim _DS As New DataSet
        Dim _cover_row As DataRowView
        Dim _SQLTxt As String = ""
        _DS.Tables.Add("tmptable")
        _DS.Tables("tmptable").Clear()
        _SQLTxt = "select * from products_cover order by products_id, cover_box_id "
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("tmptable"), _SQLTxt)
        Dim _View As New DataView(_DS.Tables("tmptable"), "", "products_id", DataViewRowState.CurrentRows)
        Dim _i As Integer
        For Each _row In objDS.Tables(TableName).Rows
            _row("cover_box_id") = ""
            _i = _View.Find(New Object() {_row("products_id")})
            If _i > -1 Then
                _cover_row = _View(_i)
           
                _row("cover_box_id") = _cover_row("cover_box_id")
            End If
        Next
    End Sub

    Private Sub ChangeShoppingOrders(ByVal dr As DataRow)
        Dim Orders_ID As Integer
        Dim customers_id As Integer
        Dim products_id As Integer
        Dim cover_box_id As Integer
        Dim products_media As String
        Dim orders_status As Integer
        Dim quantity As Integer
        Dim dvd_id As Integer

        Dim sql As String

        If IsNothing(dr) Or dr.RowState = DataRowState.Detached Then Return
        ' Load DATA
        Orders_ID = dr("shopping_orders_id")
        customers_id = dr("customers_id")
        products_id = dr("products_id")
        products_media = dr("Products_media")
        orders_status = dr("order_status")
        quantity = dr("quantity")

        If IsNothing(dr("dvd_id")) OrElse dr("dvd_id") Is DBNull.Value OrElse dr("dvd_id") Is String.Empty Then
            dvd_id = -1
        Else
            dvd_id = dr("dvd_id")
        End If

        If IsNothing(dr("cover_box_id")) OrElse dr("cover_box_id") Is DBNull.Value OrElse dr("cover_box_id") Is String.Empty Then
            cover_box_id = 0
        Else
            cover_box_id = dr("cover_box_id")
        End If
        '---------
        If products_media = "BUY" Then
            'Change Order Status
            sql = "update shopping_orders set `status` = 4 where shopping_orders_id = " & Orders_ID
            DvdPostData.clsConnection.ExecuteNonQuery(sql)
            Return

        End If

        If (dvd_id = -1) And quantity <> 0 Then

            MsgBox("Order : " & Orders_ID & " has NO DVD_ID", MsgBoxStyle.Critical)
            Return

        End If

        If orders_status <> 1 Then
            MsgBox("Already Picked, Expedited or Canceled", MsgBoxStyle.Exclamation)
            Return
        End If

        'Change Order Status
        sql = "update shopping_orders set `status` = 4 where shopping_orders_id = " & Orders_ID
        DvdPostData.clsConnection.ExecuteNonQuery(sql)

      

    End Sub

    Private Sub PickedDVD(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick

        Dim i As Integer = GridView1.FocusedRowHandle
        If i < 0 Then Exit Sub
        Dim OrdersRow As DataRow = GridView1.GetDataRow(i)
        ChangeShoppingOrders(OrdersRow)
        LoadDataSet()
        MsgBox("Done", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub pickedCust(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser2.ItemClick
        'Set as Picked for selected Cust

        Dim customers_id As Integer
        Dim i As Integer = GridView1.FocusedRowHandle
        If i < 0 Then Exit Sub

        Dim OrdersRow As DataRow = GridView1.GetDataRow(i)
        Dim _view As DataView
        customers_id = OrdersRow("customers_id")
        Dim _answ As MsgBoxResult = MsgBox("Do really want to set as Picked all DVD for customer : " & customers_id & "?", MsgBoxStyle.YesNo)
        If _answ = MsgBoxResult.Yes Then

            _view = New DataView(objDS.Tables(TableName), "customers_id = " & customers_id, "", DataViewRowState.CurrentRows)
            Dim ordersRowv As DataRowView
            For Each ordersRowv In _view
                ChangeShoppingOrders(ordersRowv.Row)
            Next
            LoadDataSet()
            MsgBox("Done", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub UnAssignDVD(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser3.ItemClick
        'Clear DVD Assigned
        Dim _i As Integer = GridView1.FocusedRowHandle
        If _i < 0 Then Exit Sub
        Dim _OrdersRow As DataRow = GridView1.GetDataRow(_i)
        Dim _products_id As Integer
        Dim _dvd_id As Integer
        Dim _Box_id As Integer
        Dim _PiBox_ID As Int16
        Dim _DS As New dsProducts

        _products_id = _OrdersRow("products_id")
        If IsDBNull(_OrdersRow("dvd_id")) Then
            _dvd_id = -1
            _Box_id = -1
            _PiBox_ID = -1
        Else
            _dvd_id = _OrdersRow("dvd_id")
            _Box_id = _OrdersRow("box_id")
            _PiBox_ID = _OrdersRow("pibox_id")
        End If
        If IsNothing(_OrdersRow) Then Exit Sub
        If _OrdersRow("order_status") <> 1 Then
            MsgBox("Already Expedited or Canceled", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim _SQLTxt As String
        _SQLTxt = "DELETE FROM shopping_orders_dvd_id WHERE shopping_orders_id = " & _OrdersRow("shopping_orders_id") & " AND products_id =  " & _OrdersRow("products_id") & _
                           " AND  dvd_id = " & _OrdersRow("dvd_id")
        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        'Set the Status of Item Back to OK
        ' objProductDVD = New clsProduct_DVD(SessionInfo, _DS, _products_id, _dvd_id)

        ' objProductDVD.products_dvd_status = DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK
        ' objProductDVD.ChangeBox(objProductDVD.GetBox(_Box_id), objProductDVD.GetPosBox(_PiBox_ID))
        ' objProductDVD.ChangeStatus(objProductDVD.products_dvd_status)
        '  objProductDVD.LogStatusDVD("DVD Is Sold")

        LoadDataSet()
    End Sub
    Private Sub CancelOrder(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser4.ItemClick
        'Set as Canceled
        Dim _Orders_ID As Integer
        Dim _customers_id As Integer
        Dim _products_id As Integer
        Dim _cover_box_id As Integer = 0
        Dim _DS As New dsProducts
        Dim _i As Integer = GridView1.FocusedRowHandle
        If _i < 0 Then Exit Sub
        Dim _OrdersRow As DataRow = GridView1.GetDataRow(_i)
        If IsNothing(_OrdersRow) Then Exit Sub
        _Orders_ID = _OrdersRow("shopping_orders_id")
        _customers_id = _OrdersRow("customers_id")
        _products_id = _OrdersRow("products_id")

        Dim _answ As MsgBoxResult = MsgBox("Cancel Order : " & _Orders_ID.ToString & " ?", MsgBoxStyle.YesNo)
        If _answ = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim _SQLTxt As String

        'Change ShoppingOrder Status
        _SQLTxt = "update shopping_orders set `status` = 9 where shopping_orders_id = " & _OrdersRow("shopping_orders_id")
        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        LoadDataSet()
        MsgBox("Done", MsgBoxStyle.Exclamation)
    End Sub
    End Class
