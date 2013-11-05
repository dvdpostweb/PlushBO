Public Class frmSales_Picked
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales_Picked))
        Me.Panel1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
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
        'frmSales_Picked
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmSales_Picked"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
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

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New dvdpostbuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        objDS = New dsPur_Sls
        'TabParameters.PageVisible = True
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
        btnUser1.Caption = "Set as Un-Picked"
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser2.Caption = "Ship DVD"
        btnUser2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser3.Caption = "Ship ALL This Customer"
        btnUser3.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser4.Caption = "Cancel Order"
        btnUser4.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'btnOK
        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'If CurrentDefaultSetID <> 0 Then
        '    BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
        '    'LoadDataSet()
        '    TabControl1.SelectedTabPage = TabResult
        'Else
        '    'TabControl1.SelectedTabPage = TabParameters
        'End If
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub
    Public Overrides Sub LoadDataSet()
        Dim _SQLTxt As String
        Dim _i As Integer
        'Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue)
        'Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue)
        'Clear Table
        objDS.Tables(TableName).Clear()
        _SQLTxt = " SELECT s.shopping_orders_id, s.customers_id, s.`date` as order_date, s.products_id, s.quantity, s.`status` as order_status, " & _
                  " sdvd.dvd_id, s.price, s.discount_code_id, c.customers_firstname, c.customers_lastname, c.EntityID, c.customers_gender, " & _
                  " c.customers_email_address, c.customers_default_address_id,  " & _
                  " ab.entry_street_address as customers_street_address, ab.entry_postcode as customers_postcode, ab.entry_city as customers_city, " & _
                  " ab.entry_country_id as customers_country_id, ctry.countries_name as customers_country,  " & _
                  " p.products_model, p.products_type, p.products_media, p.products_status, pd.products_dvd_status, " & _
                  " pd.box_id, pd.pibox_id, pd.`inout`, s.products_type, s.products_state " & _
                  " FROM shopping_orders s " & _
                  " left join shopping_orders_dvd_id sdvd on sdvd.shopping_orders_id = s.shopping_orders_id and sdvd.products_id = s.products_id " & _
                  " left join customers c on c.customers_id = s.customers_id " & _
                  " left join address_book ab on ab.address_book_id = c.customers_default_address_id and ab.customers_id = c.customers_id " & _
                  " left join countries ctry on ctry.countries_id = ab.entry_country_id " & _
                  " left join products p on p.products_id = s.products_id " & _
                  " left join products_dvd pd on pd.products_id = s.products_id and pd.products_dvdid = sdvd.dvd_id " & _
                  " where s.status = 4 "
        DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)
        'Set the quantity_assigned
        Dim _row As DataRow
        Dim _RowView As DataRowView
        Dim _View As DataView
        Dim _TmpTable As New DataTable("TmpTable")
        _SQLTxt = "select s.shopping_orders_id, s.quantity, count(*) as cnt from shopping_orders s " & _
                  " left join shopping_orders_dvd_id sdvd on s.shopping_orders_id = sdvd.shopping_orders_id and " & _
                  " s.products_id = sdvd.products_id where s.`status` = 4 group by s.shopping_orders_id"
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
                '_row("quantity_assigned") = BKGlobal.ExecuteCount("select count(*) as cnt from shopping_orders_dvd_id where shopping_orders_id = " & _
                '           _row("shopping_orders_id") & " AND products_id = " & _row("products_id"))
            End If
        Next
        Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        _View = New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
        SearchCovers()
        TabControl1.SelectedTabPage = TabResult
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
        'Dim _rowView As DataRowView
        Dim _DS As New DataSet
        Dim _cover_row As DataRowView
        Dim _SQLTxt As String = ""
        _DS.Tables.Add("tmptable")
        _DS.Tables("tmptable").Clear()
        '_SQLTxt = "select * from products_cover where products_id = " & _row("products_id") & " order by cover_box_id "
        _SQLTxt = "select * from products_cover order by products_id, cover_box_id "
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("tmptable"), _SQLTxt)
        Dim _View As New DataView(_DS.Tables("tmptable"), "", "products_id", DataViewRowState.CurrentRows)
        Dim _i As Integer
        For Each _row In objDS.Tables(TableName).Rows
            _row("cover_box_id") = ""
            _i = _View.Find(New Object() {_row("products_id")})
            If _i > -1 Then
                _cover_row = _View(_i)
                'If _DS.Tables("tmptable").Rows.Count > 0 Then
                '_cover_row = _DS.Tables("tmptable").Rows(0)
                _row("cover_box_id") = _cover_row("cover_box_id")
            End If
        Next
    End Sub

    Private Sub ChangeShoppingOrdersPrepForSold(ByVal dr As DataRow)
        Dim Orders_ID As Integer
        Dim customers_id As Integer
        Dim products_id As Integer
        Dim cover_box_id As Integer
        Dim products_media As String
        Dim orders_status As Integer
        Dim quantity As Integer
        Dim dvd_id As Integer
        Dim objProductDVD As clsProduct_DVD
        Dim DS As New dsProducts
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
            sql = "update shopping_orders set `status` = 2 where shopping_orders_id = " & Orders_ID
            DvdPostData.clsConnection.ExecuteNonQuery(sql)
            Return

        End If

        If (dvd_id = -1) And quantity <> 0 Then

            MsgBox("Order : " & Orders_ID & " has NO DVD_ID", MsgBoxStyle.Critical)
            Return

        End If

        If orders_status <> 4 Then
            MsgBox("Already To-Prepared, Expedited or Canceled", MsgBoxStyle.Exclamation)
            Return
        End If

        objProductDVD = New clsProduct_DVD(SessionInfo, DS, products_id, dvd_id)
        If IsNothing(objProductDVD) Then Exit Sub

        objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.DVD_SOLD, _
                                                        "DVD Is Sold", _
                                                        DvdPostData.ClsProducts_dvd_state.state.SALE, objProductDVD.INOUT)

        'Insert as Sold History
        sql = "insert into  products_dvd_sold  (products_id ,products_dvdid,date_added) values ('" & _
              objProductDVD.ProductsID & "', '" & objProductDVD.DvdId & "', now())"
        DvdPostData.clsConnection.ExecuteNonQuery(sql)
        'Change Order Status
        sql = "update shopping_orders set `status` = 2 where shopping_orders_id = " & Orders_ID
        DvdPostData.clsConnection.ExecuteNonQuery(sql)
        'Decrease Cover Qty
        If IsNumeric(cover_box_id) Then
            sql = "update products_cover set qty = qty - 1 where products_id = " & objProductDVD.ProductsID & " and cover_box_id = " & cover_box_id
            DvdPostData.clsConnection.ExecuteNonQuery(sql)
        End If

     

    End Sub

    Private Sub setUnPicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick
        'Set as Un-Picked
        Dim _Orders_ID As Integer
        Dim _customers_id As Integer
        Dim _products_id As Integer
        Dim _dvd_id As Integer
        Dim _cover_box_id As Integer
        Dim _DS As New dsProducts
        Dim _i As Integer = GridView1.FocusedRowHandle
        If _i < 0 Then Exit Sub
        Dim OrdersRow As DataRow = GridView1.GetDataRow(_i)

        _Orders_ID = OrdersRow("shopping_orders_id")
        _customers_id = OrdersRow("customers_id")
        _products_id = OrdersRow("products_id")
        If OrdersRow("cover_box_id") & "" = "" Then
            _cover_box_id = 0
        Else
            _cover_box_id = OrdersRow("cover_box_id")
        End If

        If IsDBNull(OrdersRow("dvd_id")) Then
            _dvd_id = -1
        Else
            _dvd_id = OrdersRow("dvd_id")
        End If
        If IsNothing(OrdersRow) Then Exit Sub
        If OrdersRow("order_status") <> 4 Then
            MsgBox("Already To-Prepared, Expedited or Canceled", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim _SQLTxt As String
        'Change Order Status
        _SQLTxt = "update shopping_orders set `status` = 1 where shopping_orders_id = " & OrdersRow("shopping_orders_id")
        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
      
    End Sub
    Private Sub shippedDVD(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser2.ItemClick
        'Set as Shipped

        Dim i As Integer = GridView1.FocusedRowHandle
        If i < 0 Then Exit Sub
        Dim OrdersRow As DataRow = GridView1.GetDataRow(i)
        ChangeShoppingOrdersPrepForSold(OrdersRow)
        LoadDataSet()
        MsgBox("Done", MsgBoxStyle.Exclamation)

    End Sub
    Private Sub shippedAll(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser3.ItemClick
        'Set as Shipped all This Cust

        Dim customers_id As Integer
        Dim i As Integer = GridView1.FocusedRowHandle
        If i < 0 Then Exit Sub
        Dim OrdersRow As DataRow = GridView1.GetDataRow(i)
        customers_id = OrdersRow("customers_id")
        Dim _answ As MsgBoxResult = MsgBox("Do really want to ship all DVD to customer : " & customers_id & "?", MsgBoxStyle.YesNo)
        If _answ = MsgBoxResult.Yes Then
            Dim _view As New DataView(objDS.Tables(TableName), "customers_id = " & customers_id, "", DataViewRowState.CurrentRows)
            Dim orderRowV As DataRowView
            For Each orderRowV In _view
                ChangeShoppingOrdersPrepForSold(orderRowV.Row)
            Next
            LoadDataSet()
            MsgBox("Done", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub Cancel_order(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser4.ItemClick
        'Set as Canceled
        Dim _Orders_ID As Integer
        Dim _customers_id As Integer
        Dim _products_id As Integer
        'Dim _dvd_id As Integer
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

        'Change Order Status
        _SQLTxt = "update shopping_orders set `status` = 9 where shopping_orders_id = " & _OrdersRow("shopping_orders_id")
        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        LoadDataSet()
        MsgBox("Done", MsgBoxStyle.Exclamation)
    End Sub

End Class
