Public Class clsProductsRating

    Public Shared Function GetProductsRatingByCust(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "SELECT pr.*, pd.* FROM products_rating pr join products_description pd on pd.products_id = pr.products_id " & _
              "join customers c on c.customers_id = pr.customers_id and c.customers_language = pd.language_id " & _
              "where pr.customers_id = " & customers_id & _
              " order by pr.products_rating_id desc "
        Return sql
    End Function


End Class
