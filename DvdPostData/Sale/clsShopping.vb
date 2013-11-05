Public Class clsShopping


    Public Shared Function GetShoppingOrders(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "SELECT * FROM shopping_orders so left join products_description pd on so.products_id = pd.products_id " & _
        " join shopping_orders_status sos on sos.shopping_orders_status_id = so.status " & _
        " left join shopping_discount sd on sd.shopping_discount_id = so.discount_code_id " & _
        " where pd.language_id = 1 and customers_id = " & customers_id & _
        " order by so.shopping_orders_id desc "
        Return sql
    End Function


End Class
