Public Class AboProcessData

    Public Shared Function IsAboprocessRun() As String
        Dim sql As String
        sql = "select date_end from aboprocess_stats_new where date(date_start) = date(now()) and date_end = date_start order by date_end desc limit 1"
        Return sql
    End Function
    Public Shared Function GetDateTimeRunAboprocess() As String
        Dim sql As String
        sql = "select max(date_end) date_end from aboprocess_stats_new where date(date_end) = date(now())"
        Return sql
    End Function
    ''' <summary>
    '''  search customers that entry to the process abo  
    '''  disturb dvd to customers 
    ''' </summary>
    ''' <remarks></remarks>
    Public Function GetCustomerwithAbo(ByVal Min_client_id As Integer, ByVal Max_Client_id As Integer) As String

        Dim SQLRange As String

        SQLRange = " AND customers.customers_id >= " & Min_client_id & _
                   " AND customers.customers_id <= " & Max_Client_id


        Return GetCustomerSql(SQLRange)

    End Function

    ''' <summary>
    '''  search customers that entry to the process abo  
    '''  disturb dvd to customers 
    ''' </summary>
    ''' <remarks></remarks>
    Public Function GetCustomerwithAbo() As String

        Return GetCustomerSql("")

    End Function

    Private Function GetCustomerSql(ByVal rangeSql As String)

        Dim SQLCustomers As String


        SQLCustomers = "SELECT distinct if(cd.customers_id is null,0,1) as isCompensation, c.customers_id, customers_abo, customers_abo_type, customers_abo_dvd_norm, customers_abo_dvd_adult, " & _
                      " customers_abo_dvd_home_norm, customers_abo_dvd_home_adult, customers_abo_dvd_credit, customers_abo_dvd_remain, customers_abo_rank, " & _
                      " customers_abo_multishipment, if(pa.qty_credit = 0, 0, 1) as use_credit, throttling, customers_abo_suspended, " & _
                      " 0 as InNeed, 0 as Served, 0 as NotServed, 0 as NotEnoughtCredit, 0 as NoDVDFound, 0 as TooManyAtHome, " & _
                      " 0 as NormToSend, 0 as AdultToSend, 0 as NormAssigned, 0 as AdultAssigned, 0 as NormCompensation, 0 AdultCompensation , " & _
                      " if(cr.customer_id is null or cr.time_average > 7 ,0,1) quick, if(cr.customer_id is null ,99,cr.time_average) time_average, c.sleep, " & _
                      " (SELECT if(pa.qty_dvd_max >= 0, 1, 0)) as npp_logic " & _
                      " from customers c " & _
                      " left join products_abo pa on pa.products_id = customers_abo_type " & _
                      " left join (select distinct customers_id from compensation cmp where compensation_date_setback IS NULL and cmp.products_id is not null) cd on c.customers_id = cd.customers_id " & _
                      " left join (select * from customers_rotations cr2 " & _
                      "            join(select max(create_at) max_date from customers_rotations) xx on cr2.create_at = xx.max_date) cr on cr.customer_id = c.customers_id " & _
                      " left join customer_attributes ca on ca.customer_id = c.customers_id " & _
                      " where customers_abo = 1 and ca.only_vod = 0 " & _
                      " and (customers_abo_auto_stop_next_reconduction = 0 or (customers_abo_auto_stop_next_reconduction = 1 and customers_abo_validityto > DATE_ADD(now(), INTERVAL 3 DAY))) " & _
                        rangeSql & _
                      " order by customers_abo_rank desc"

        Return SQLCustomers

    End Function


    Public Function GetSqlCompensation() As String
        Dim SQLCompensation As String

        SQLCompensation = "select c.customers_id , p.products_type , " & _
                         " count(*) as compensation_qty " & _
                         " FROM compensation c left join products p on ( c.products_id = p.products_id) " & _
                         " left join customers cust on (cust.customers_id = c.customers_id) " & _
                         " where compensation_date_setback IS NULL and cust.customers_abo = 1 " & _
                         " group by customers_id, p.products_type having products_type is not NULL"

        Return SQLCompensation
    End Function

    'Public Function GetSqlWishList(ByVal customer_id As Integer) As String

    '    Dim SQLWishList As String

    '    SQLWishList = "SELECT wl.wl_id, wl.customers_id,w.priority, wl.priority priority_purchase, wl.date_added, product_id,  wl.wishlist_type, p.products_series_id, p.products_series_number,p.imdb_id " & _
    '                                 " FROM " & _
    '                                   " ( select w.wl_id, w.wishlist_type, w.date_added,w.customers_id,w.product_id,if(w.priority <= wish_calc.maxp,1,2) priority from wishlist w join ( " & _
    '                                        " select customers_id,if(w.high >= w.customers_abo_dvd_norm * " & ClsPurchaseSale.NB_MONTH_PREVISION & ",1,if(w.high + w.mediums >= w.customers_abo_dvd_norm * " & ClsPurchaseSale.NB_MONTH_PREVISION & ",2,3)) maxp " & _
    '                                        " from " & _
    '                                                  " (select c.customers_id,c.customers_abo_dvd_norm, " & _
    '                                                  "(select count(w.priority)  from v_wishlist w where w.priority = 1 and w.customers_id = c.customers_id and w.wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(dvdpostdata.clsProductDvd.Type_DVD.DVD_NORM) & "' ) high," & _
    '                                                  "(select count(w.priority)  from v_wishlist w where w.priority = 2 and w.customers_id = c.customers_id and w.wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(dvdpostdata.clsProductDvd.Type_DVD.DVD_NORM) & "') mediums, " & _
    '                                                  "(select count(w.priority)  from v_wishlist w where w.priority = 3 and w.customers_id = c.customers_id and w.wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(dvdpostdata.clsProductDvd.Type_DVD.DVD_NORM) & "') low " & _
    '                                           " from customers c " & _
    '                                    " where(c.customers_abo = 1 And c.customers_abo_dvd_norm > 0 and c.customers_id = " & customer_id & ") " & _
    '                                         " ) w " & _
    '                            " ) wish_calc on w.customers_id = wish_calc.customers_id ) wl " & _
    '                        " LEFT JOIN products p on p.products_id = wl.product_id" & _
    '                        " JOIN wishlist w on w.wl_id = wl.wl_id " & _
    '                        " ORDER BY wl.wishlist_type, wl.priority "


    '    Return SQLWishList
    'End Function
    Public Function getSqlWishlist(ByVal customers_id As Integer, ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As String
        Dim sql As String

        sql = "select wl.wl_id, wl.customers_id, wl.priority, wl.date_added, product_id,  wl.wishlist_type, p.products_series_id, p.products_series_number,p.imdb_id_serie,pgroup.qty_in_stock,if(theme_event_id is null,0,1) theme " & _
              " from wishlist wl " & _
              " join products p on wl.product_id = p.products_id " & _
              "     left join (select  wl.wl_id,pd.products_id,count(pd.products_dvdid) as qty_in_stock " & _
              "                from wishlist wl " & _
              "                join products_dvd pd on (pd.products_id = wl.product_id) " & _
              "                where(pd.inout = 1 And pd.products_dvd_status = 1 And wl.customers_id = " & customers_id & ") " & _
              "                group by wl.product_id) as pgroup on pgroup.wl_id = wl.wl_id " & _
              " where wl.customers_id = " & customers_id & " and wl.wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(type_dvd) & "'" & _
              " and (pgroup.qty_in_stock > 0 or p.products_series_id > 0)"

        Return sql
    End Function
    Public Function getSqlWishlist(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = "select wl.wl_id, wl.customers_id, wl.priority, wl.date_added, product_id,  wl.wishlist_type, p.products_series_id, p.products_series_number,p.imdb_id_serie,pgroup.qty_in_stock,if(theme_event_id is null,0,1) theme " & _
              " from wishlist wl " & _
              " join products p on wl.product_id = p.products_id " & _
              "     left join (select  wl.wl_id,pd.products_id,count(pd.products_dvdid) as qty_in_stock " & _
              "                from wishlist wl " & _
              "                join products_dvd pd on (pd.products_id = wl.product_id) " & _
              "                where(pd.inout = 1 And pd.products_dvd_status = 1 And wl.customers_id = " & customers_id & ") " & _
              "                group by wl.product_id) as pgroup on pgroup.wl_id = wl.wl_id " & _
              " where wl.customers_id = " & customers_id

        Return sql
    End Function

    Public Function GetSqlListTheme_event() As String
        Dim sql As String
        sql = "select id,name from themes_events order by 1 desc "
        Return sql
    End Function

    Public Function getSqlProductsOfTheme(ByVal theme_event_id As Integer) As String
        Dim sql As String
        sql = " select product_id from listed_products lp " & _
              " join product_list pl on lp.product_list = pl.id " & _
              " where theme_event_id = " & theme_event_id
        Return sql
    End Function

    Public Function getUpdateWishlistThemeNull(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = " update  wishlist w " & _
              " set w.theme_event_id = null " & _
              " where customers_id = " & customers_id
        Return sql
    End Function
    Public Function getUpdateWishlistTheme(ByVal theme_event_id As Integer, ByVal customers_id As Integer) As String
        Dim sql As String
        sql = " update  wishlist w " & _
              "  left join (select distinct pl.theme_event_id,lp.product_id from listed_products lp " & _
              "             join product_lists pl on lp.product_list_id = pl.id and kind = 'THEME') pl on w.product_id = pl.product_id " & _
              " set w.theme_event_id = pl.theme_event_id " & _
              " where (pl.theme_event_id = " & theme_event_id & " or pl.theme_event_id is null) and customers_id = " & customers_id
        Return sql
    End Function

    'Public Function GetSqlWishList2(ByVal customer_id As Integer) As String

    '    Dim SQLWishList As String

    '    SQLWishList = "SELECT wl.wl_id, wl.customers_id, wl.priority, wl.date_added, product_id,  wl.wishlist_type, p.products_series_id, p.products_series_number,p.imdb_id,pgroup.qty_in_stock " & _
    '                                 " FROM wishlist wl " & _
    '                                 " LEFT JOIN customers c on c.customers_id = wl.customers_id " & _
    '                                 " LEFT JOIN products p on p.products_id = wl.product_id" & _
    '                                 " left join (select products_id,count(*) qty_in_stock from products_dvd where products_dvd_status = 1 and `inout` = 1 group by products_id )" & _
    '                                 " pgroup on pgroup.products_id = p.products_id " & _
    '                                 " WHERE c.customers_abo = 1 and wl.customers_id = " & customer_id & _
    '                                 " and p.products_next = 0 " & _
    '                                 " ORDER BY wl.wishlist_type, wl.priority,qty_in_stock desc "


    '    Return SQLWishList
    'End Function

    Public Function GetProductDVDAvailable()

        Dim SQLProducts_DVD As String

        SQLProducts_DVD = "SELECT pd.products_id, products_dvdid, products_dvd_status, `inout`, box_id, pibox_id,nbr_rotation, " & _
                         " products_series_id, products_series_number,imdb_id_serie " & _
                         " FROM products_dvd pd " & _
                         " LEFT JOIN products p on p.products_id = pd.products_id" & _
                         " WHERE pd.products_dvd_status = " & clsProductDvd.DVDStatus.DVD_STATUS_OK & " and pd.`inout` = " & clsProductDvd.INOUT.IN

        Return SQLProducts_DVD
    End Function

    ''' <summary>
    '''  list of DVD in stock
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetProductDVDAvailable(ByVal type_dvd As PlushData.clsProductDvd.Type_DVD)

        Dim SQLProducts_DVD As String

        SQLProducts_DVD = "SELECT pd.products_id, products_dvdid, products_dvd_status, `inout`, box_id, pibox_id,nbr_rotation, " & _
                         " products_series_id, products_series_number,imdb_id_serie " & _
                         " FROM products_dvd pd " & _
                         " LEFT JOIN products p on p.products_id = pd.products_id" & _
                         " WHERE pd.products_dvd_status = " & clsProductDvd.DVDStatus.DVD_STATUS_OK & " and pd.`inout` = " & clsProductDvd.INOUT.IN & _
                         " and p.products_type = '" & PlushTools.clsEnum.getNameStrEnum(type_dvd) & "'"

        Return SQLProducts_DVD
    End Function

    '''' <summary>
    ''''  selection in the wishlist the saison is minder with the series_number minder
    '''' </summary>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Function GetSerieIdNext(ByVal customer_id As Integer, ByVal imdb_id as integer)

    '    Dim SQLSeries_DVD As String

    '    SQLSeries_DVD = "SELECT wl.wl_id, wl.customers_id, wl.priority, wl.date_added, product_id,  wl.wishlist_type, p.products_series_id, p.products_series_number,p.imdb_id " & _
    '                    " FROM wishlist wl LEFT JOIN products p on p.products_id = wl.product_id " & _
    '                    " WHERE(customers_id = " & customer_id & " And imdb_id = " & imdb_id & ") " & _
    '                    " ORDER BY customers_id,wl.wishlist_type,imdb_id,p.products_series_id,p.products_series_number, wl.priority limit 1 "

    '    Return SQLSeries_DVD
    'End Function

    Public Function GetCustomersAboprocessStats(ByVal aboprocess_id As Integer) As String

        Dim sql As String
        sql = "select casr.label,cas.* from customers_aboprocess_stats cas inner join customers_aboprocess_stats_reason casr on cas.reason = casr.id " & _
        " where aboprocess_id = " & aboprocess_id
        Return sql
    End Function
    Public Shared Function GetAboprocessStatsByCust(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "SELECT if(ast.products_type = 0,'" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_NORM) & "','" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_ADULT) & "') products_type,cas.*, ast.*,casr.* FROM customers_aboprocess_stats_new cas " & _
              "left join customers_aboprocess_stats_reason casr on cas.reason = casr.id " & _
              "join aboprocess_stats_new ast on cas.aboProcess_id = ast.aboprocess_id where cas.customers_id = " & customers_id & " order by cas.id desc"
        Return sql
    End Function

    Public Shared Function GetAboprocessOldByCust(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "SELECT * FROM customers_aboprocess_stats cas " & _
              "left join customers_aboprocess_stats_reason casr on cas.reason = casr.id " & _
              "join aboprocess_stats ast on cas.aboProcess_id = ast.aboprocess_id where cas.customers_id = " & customers_id & " order by cas.id desc"
        Return sql
    End Function
End Class
