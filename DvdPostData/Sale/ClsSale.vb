Public Class ClsSale

    Public Shared Function GetShoppingProduct(ByVal shopping_orders_id As Integer, ByVal products_id As Integer) As String
        Dim sql As String

        sql = "select * from shopping_orders_dvd_id where shopping_orders_id = " & shopping_orders_id & _
                                           " and products_id = " & products_id
        Return sql
    End Function

    Public Shared Function getSalePrepareProduct(ByVal products_id As Integer) As String
        Dim sql As String

        sql = " select * from products_dvd pd where products_id = " & products_id & _
               " and pd.inout = " & clsProductDvd.INOUT.IN & " and products_dvd_status = " & clsProductDvd.DVDStatus.DVD_STATUS_OK & " and box_id > 0 " & _
               " and not exists(select * from shopping_orders_dvd_id sodi where sodi.products_id = pd.products_id and sodi.dvd_id = pd.products_dvdid ) order by box_id desc "
        Return sql
    End Function

    Public Shared Function getInsertShoppingProduct(ByVal shopping_orders_id As Integer, ByVal products_id As Integer, ByVal products_dvdid As Integer) As String
        Dim sql As String

        sql = "insert into shopping_orders_dvd_id values(" & shopping_orders_id & ", " & products_id & _
                                   ", " & products_dvdid & ")"
        Return sql
    End Function

    Public Shared Function GetAllShoppingOrders() As String
        Dim sql As String

        sql = " SELECT s.shopping_orders_id, s.customers_id, s.`date` as order_date, s.products_id, s.quantity, s.`status` as order_status, " & _
                 " sdvd.dvd_id, s.price, s.discount_code_id, c.customers_firstname, c.customers_lastname, c.EntityID, c.customers_gender, " & _
                 " c.email, c.customers_default_address_id,  " & _
                 " ab.entry_street_address as customers_street_address, ab.entry_postcode as customers_postcode, ab.entry_city as customers_city, " & _
                 " ab.entry_country_id as customers_country_id, ctry.countries_name as customers_country,  " & _
                 " p.products_model, p.products_type, p.products_media, p.products_status, pd.products_dvd_status, " & _
                 " pd.box_id, pd.pibox_id, pd.`inout` , s.products_type, s.products_state " & _
                 " FROM shopping_orders s " & _
                 " left join shopping_orders_dvd_id sdvd on sdvd.shopping_orders_id = s.shopping_orders_id and sdvd.products_id = s.products_id " & _
                 " left join customers c on c.customers_id = s.customers_id " & _
                 " left join address_book ab on ab.address_book_id = c.customers_default_address_id and ab.customers_id = c.customers_id " & _
                 " left join countries ctry on ctry.countries_id = ab.entry_country_id " & _
                 " left join products p on p.products_id = s.products_id " & _
                 " left join products_dvd pd on pd.products_id = s.products_id and pd.products_dvdid = sdvd.dvd_id " & _
                 " where s.status = 1 "
        Return sql
    End Function
End Class
