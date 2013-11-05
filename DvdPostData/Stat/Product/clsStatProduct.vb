Public Class clsStatProduct

    Public Shared Function GetSelectCptCustMovieXByAbo(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " select pabo.products_title,count(distinct c.customers_id) cpt_cust " & _
               " from products p " & _
               " join orders_products op on p.products_id = op.products_id " & _
               " join orders o on o.orders_id = op.orders_id " & _
               " join customers c on c.customers_id = o.customers_id " & _
               " join products pabo on  c.customers_abo_type = pabo.products_id " & _
               " where date(o.date_purchased) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(o.date_purchased) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
               " and p.products_type = '" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_ADULT) & "' and c.customers_abo = 1 " & _
               " group by c.customers_abo_type "
        Return sql
    End Function

    Public Shared Function GetSelectCptDVDWishlistMovieXByAbo(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " select pabo.products_title,count(*) cpt_dvd " & _
               " from products p " & _
               " join wishlist w on p.products_id = w.product_id " & _
               " join customers c on c.customers_id = w.customers_id " & _
               " join products pabo on  c.customers_abo_type = pabo.products_id " & _
               " where date(w.date_added) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(w.date_added) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
               " and p.products_type = '" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_ADULT) & "' and c.customers_abo = 1 " & _
               " group by c.customers_abo_type "
        Return sql
    End Function

End Class
