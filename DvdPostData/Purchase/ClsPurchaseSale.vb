Public Class ClsPurchaseSale
    'Public Enum StatusOrder
    '    PURCHASE
    '    SALE
    'End Enum
    Public Const NB_MONTH_PREVISION As Integer = 2
    Public Enum StatusOrder
        MUSTORDER
        ORDERED
        CLOSED

    End Enum


#Region "SELECT"
    Public Shared Function GetSelectCurrentOrdersClosedPurchase() As String
        Dim sql As String

        sql = "select pd.products_id,pd.products_name,op.qty,op.cost,op.qty * op.cost total,op.supplier,op.date_added,op.status_order from OrdersPurchase op " & _
        " join products_description pd on op.products_id = pd.products_id and language_id = 1 " & _
        " where op.active = 1 and op.status_order = '" & PlushTools.clsEnum.getNameStrEnum(StatusOrder.CLOSED) & "'"
        Return sql
    End Function
    Public Shared Function GetSelectCurrentOrdersPurchase() As String
        Dim sql As String

        sql = "select pd.products_id, pd.products_name,op.qty,op.cost,op.qty * op.cost total ,op.supplier,op.date_added,op.status_order from OrdersPurchase op " & _
        " join products_description pd on op.products_id = pd.products_id and language_id = 1 " & _
        " where op.active = 1 and op.status_order <> '" & PlushTools.clsEnum.getNameStrEnum(StatusOrder.CLOSED) & "'"
        Return sql
    End Function

    Public Shared Function GetSelectOrdersDetailsPurchase(ByVal products_id As Integer) As String
        Dim sql As String

        sql = "select odp.* from OrdersDetailsPurchase odp " & _
        " join  OrdersPurchase op on odp.OrdersPurchase_id = op.OrdersPurchase_id " & _
        " where odp.active = 1 and op.products_id = " & products_id
        Return sql
    End Function

    Public Shared Function GetSelectOrdersPurchase(ByVal products_id) As String
        Dim sql As String
        sql = "select op.*,pd.products_name from OrdersPurchase op " & _
        " join products_description pd on op.products_id = pd.products_id and language_id = 1 " & _
        " where op.products_id = " & products_id & " and op.active = 1"
        Return sql
    End Function

    Public Shared Function GetSelectSeriesBreak() As String
        Dim sql As String
        sql = "SELECT p.* FROM v_seriesBreak v join products p on v.imdb_id = p.imdb_id and v.products_series_id = p.products_series_id "
        Return sql
    End Function

    Public Shared Function GetSelectViewSale() As String
        Return GetSelectViewPurchaseSale("<")
    End Function

    Private Shared Function GetDisplayColumn(ByVal Stralias As String, Optional ByVal alldisplay As Boolean = False) As String
        Dim sql As String

        sql = Stralias & ".date_added,"
        sql = sql + Stralias & ".nb_dvdachat,"
        sql = sql + Stralias & ".nb_dvdTheorique,"
        sql = sql + Stralias & ".nb_customershigh,"
        sql = sql + Stralias & ".nb_customersTotal,"
        sql = sql + Stralias & ".nb_dvdOK,"
        sql = sql + Stralias & ".nb_dvdBought,"
        sql = sql + Stralias & ".nb_dvdActuallyStock,"

        If alldisplay Then
            sql = sql + Stralias & ".dateStart,"
            sql = sql + Stralias & ".ordersMonthCurrent,"
            sql = sql + Stralias & ".`orders-1Month`,"
            sql = sql + Stralias & ".`orders-2Month`,"
            sql = sql + Stralias & ".`orders-3Month`,"
            sql = sql + Stralias & ".`orders-4Month`,"
            sql = sql + Stralias & ".`orders-5Month`,"
            sql = sql + Stralias & ".`orders-6Month`,"
            sql = sql + Stralias & ".`Rate-1Month`,"
            sql = sql + Stralias & ".`Rate-2Month`,"
            sql = sql + Stralias & ".`Rate-3Month`,"
            sql = sql + Stralias & ".`Rate-4Month`,"
            sql = sql + Stralias & ".`Rate-5Month`,"
            sql = sql + Stralias & ".`Rate-6Month`,"
            sql = sql + Stralias & ".RateMonthCurrent,"
        End If

        Return sql
    End Function
    Public Shared Function GetSelectViewPurchaseSaleByProducts(ByVal products_id As Integer) As String
        Dim sql As String


        sql = " SELECT p.products_title,Pa.products_id," & GetDisplayColumn("Pa", True) & " p.products_model,p.imdb_id,p.products_series_id,p.products_series_number,p.products_date_available,p.products_next,p.products_language_fr,products_undertitle_nl,products_media " & _
        " FROM PrevisionAchat Pa" & _
        " inner join products p on Pa.products_id = p.products_id" & _
        " where p.products_id = " & products_id & _
         " order by date_added desc; "

        Return sql
    End Function

    Public Shared Function GetSelectViewPurchaseSale(ByVal sign As String) As String
        Dim sql As String


        sql = "SELECT (select count(*) from products_dvd pd where products_dvd_status = 1 and pd.inout = 1 and p.products_id = pd.products_id) DvdOkIn, " & _
            "       if(spp.imdb_id is null,0,1) vod, " & _
            "       p.products_title, " & _
            "       Pa.products_id, " & _
            "       Pa.date_added, " & _
            "       Pa.nb_dvdachat, " & _
            "       Pa.nb_dvdTheorique, " & _
            "       Pa.nb_customershigh," & _
            "       Pa.nb_customersTotal, " & _
            "       Pa.nb_dvdOK, " & _
            "       Pa.nb_dvdBought, " & _
            "       Pa.nb_dvdActuallyStock, " & _
            "       p.products_model, " & _
            "       p.imdb_id, " & _
            "       p.products_series_id, " & _
            "       p.products_series_number, " & _
            "       p.products_date_available, " & _
            "       p.products_next, " & _
            "       p.products_language_fr, " & _
            "       products_undertitle_nl, " & _
            "       products_media, " & _
            "       p.products_availability, " & _
            "       s.studio_name, " & _
            "       OrderPurchase.total_qty " & _
            "       FROM PrevisionAchat Pa " & _
            "       join products p on Pa.products_id = p.products_id " & _
            "       join studio s on p.products_studio = s.studio_id " & _
            "       inner join (select max(date_added) date_added from PrevisionAchat) Plast on Plast.date_added = Pa.date_added left join(select imdb_id from streaming_products sp where available = 1 and expire_at > date(now()) group by imdb_id) spp " & _
            "       on spp.imdb_id = p.imdb_id " & _
            "       left join (SELECT products_id,sum(qty) total_qty FROM OrdersPurchase O where status_order <> 'CLOSED' group by products_id ) OrderPurchase on OrderPurchase.products_id = p.products_id " & _
            "       where Pa.nb_dvdachat " & sign & " 0  order by Pa.nb_dvdAchat desc;"

        Return sql
    End Function
    Public Shared Function GetSelectViewPurchase() As String
        Return GetSelectViewPurchaseSale(">")
    End Function
#End Region

#Region "INSERT"

    Public Shared Function getInsertCreatePrevisionAchat(ByVal typeDvd As String) As String
        Dim sql As String
        'SET GLOBAL log_bin_trust_function_creators = 1; permet de modifier une fonction
        sql = "  insert PrevisionAchat  " & _
    " select null,date(now()),now(),0,p.products_id," & _
    "       result.res nb_dvdTheorique," & _
    "       result.nb_cust nb_customershigh," & _
    "       w.total_customers nb_customersTotal," & _
    "       productOK.cpt_okStatus nb_dvdok," & _
    "       productAll.cpt_bought nb_dvdBought," & _
    "      func_GetNBDVDAchatVente(productOK.cpt_okStatus,result.res) nb_dvdAchat," & _
    "      pStock.cpt_OKstock nb_dvdActuallyStock," & _
    "      orders.dateStart," & _
    "      orders.monthCurrent OrdersMonthCurrent," & _
    "      orders. `-1 month` `Orders-1month`," & _
    "      orders. `-2 month` `Orders-2month`," & _
    "      orders. `-3 month` `Orders-3month`," & _
    "      orders. `-4 month` `Orders-4month`," & _
    "      orders. `-5 month` `Orders-5month`," & _
    "      orders. `-6 month` `Orders-6month`," & _
    "      if( productOK.cpt_okStatus > 0, truncate(orders. `-1 month` /productOK.cpt_okStatus,2),0) `Rate-1month` ," & _
    "      if( productOK.cpt_okStatus > 0, truncate(orders. `-2 month` /productOK.cpt_okStatus,2),0) `Rate-2month` ," & _
    "      if( productOK.cpt_okStatus > 0, truncate(orders. `-3 month` /productOK.cpt_okStatus,2),0) `Rate-3month` ," & _
    "      if( productOK.cpt_okStatus > 0, truncate(orders. `-4 month` /productOK.cpt_okStatus,2),0) `Rate-4month` ," & _
    "      if( productOK.cpt_okStatus > 0, truncate(orders. `-5 month` /productOK.cpt_okStatus,2),0) `Rate-5month` ," & _
    "      if( productOK.cpt_okStatus > 0, truncate(orders. `-6 month` /productOK.cpt_okStatus,2),0) `Rate-6month` ," & _
    "      if( productOK.cpt_okStatus > 0, truncate(orders. `monthCurrent` /productOK.cpt_okStatus,2),0) `RateMonthCurrent` " & _
    "  from (select * from products p where p.products_type = '" & typeDvd & "') p" & _
    "  left join (select products_id,count(*) cpt_OKstock from products_dvd where `inout` = 1 and products_dvd_status = 1 group by products_id) pStock on  pStock.products_id = p.products_id" & _
    "  left join (select products_id,count(*) cpt_okStatus from products_dvd where products_dvd_status = 1 group by products_id) productOK on productOK.products_id = p.products_id" & _
    "  left join (select products_id,count(*) cpt_bought from products_dvd where not products_dvd_status in (11,14) group by products_id) productAll on productAll.products_id = p.products_id " & _
    "  left join (select product_id,count(*) total_customers from wishlist w join customers c on w.customers_id = c.customers_id where c.customers_abo = 1 and customers_abo_dvd_norm > 0 group by product_id) w on w.product_id = p.products_id " & _
    "       Left Join " & _
    "    (select products_id,datestart," & _
    "    sum(if(date_purchased = concat(month(dateStart),'/',year(dateStart)), cpt,0)) monthCurrent," & _
    "    sum(if(date_purchased = concat(month(date_add(datestart,interval -1 MONTH)),'/' , year(date_add(datestart,interval -1 MONTH))), cpt,0)) `-1 month`," & _
    "    sum(if(date_purchased = concat(month(date_add(dateStart,interval -2 MONTH)),'/' ,year(date_add(dateStart,interval -2 MONTH))), cpt,0)) `-2 month`," & _
    "    sum(if(date_purchased = concat(month(date_add(dateStart,interval -3 MONTH)),'/' ,year(date_add(dateStart,interval -3 MONTH))), cpt,0)) `-3 month`," & _
    "    sum(if(date_purchased = concat(month(date_add(datestart,interval -4 MONTH)),'/' , year(date_add(datestart,interval -4 MONTH))), cpt,0)) `-4 month`," & _
    "    sum(if(date_purchased = concat(month(date_add(dateStart,interval -5 MONTH)),'/' ,year(date_add(dateStart,interval -5 MONTH))), cpt,0)) `-5 month`," & _
    "    sum(if(date_purchased = concat(month(date_add(dateStart,interval -6 MONTH)),'/' ,year(date_add(dateStart,interval -6 MONTH))), cpt,0)) `-6 month`" & _
    "    from  (select date(now()) dateStart ,op.products_id,concat(month(date_purchased), '/',year(date_purchased)) date_purchased ,count(*) cpt" & _
    "    from orders o join orders_products op on o.orders_id = op.orders_id" & _
    "    where date_purchased >= date_add(now(),interval -6 month) group by op.products_id,concat(month(date_purchased), '/',year(date_purchased))) xxx" & _
    "    group by products_id,dateStart) orders on orders.products_id = p.products_id" & _
    "        Left Join " & _
 " (" & _
 " select tponderation.product_id,cast(ceiling(sum(tponderation.ponderation)) as decimal(3,0)) res,count(*) nb_cust" & _
 " from ( " & _
 " select w.product_id,w.priority,w.customers_id,func_GetRateDVDWishlist(w.product_id,w.customers_id,maxp,2,func_RateRotationAbo(stat.qty_credit,stat.dvd_norm),stat.qty_credit,'" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_NORM) & "') ponderation " & _
 " from v_wishlist w " & _
 " Join /* stat */ " & _
 " ( " & _
 "    select wish.*,c.customers_abo_dvd_norm dvd_norm ,pa.qty_credit " & _
 "    from customers c " & _
 "    join products_abo pa on c.customers_next_abo_type = pa.products_id " & _
 "    Join /* wish */ " & _
 "    ( " & _
 "      select vw.customers_id,max_priority.maxp,count(1) cpt_dvd_wishlist " & _
 "      from v_wishlist vw " & _
 "         Join /*max_priority*/ " & _
 "          ( " & _
 "             select customers_id,if(ww.high >= ww.customers_abo_dvd_norm * 2,1,if(ww.high + ww.mediums >= ww.customers_abo_dvd_norm * 2 ,2,3)) maxp " & _
 "             from /*ww*/ " & _
 "            ( " & _
 "                   select c.customers_id,c.customers_abo_dvd_norm, " & _
 "                   (select count(w.priority)  from v_wishlist w where w.priority = 1 and w.customers_id = c.customers_id and w.wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_NORM) & "' ) high, " & _
 "                   (select count(w.priority)  from v_wishlist w where w.priority = 2 and w.customers_id = c.customers_id and w.wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_NORM) & "') mediums, " & _
 "                   (select count(w.priority)  from v_wishlist w where w.priority = 3 and w.customers_id = c.customers_id and w.wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_NORM) & "') low " & _
 "                    from customers c where c.customers_abo = 1 " & _
 "                    and c.customers_abo_suspended = 0 And c.customers_abo_dvd_norm > 0 " & _
 "           ) ww " & _
 "         ) max_priority on vw.customers_id = max_priority.customers_id and vw.priority <= max_priority.maxp " & _
 "      where(vw.wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_NORM) & "')  group by vw.customers_id,max_priority.maxp " & _
 "    ) wish on c.customers_id = wish.customers_id " & _
 "       where(c.customers_abo = 1 And c.customers_abo_suspended = 0 And customers_abo_dvd_norm > 0 And pa.qty_credit > 0) " & _
 " ) stat on w.customers_id = stat.customers_id and w.wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_NORM) & "' and w.priority <= stat.maxp " & _
 " ) tponderation " & _
 " group by tponderation.product_id " & _
 "    ) result on result.product_id = p.products_id and p.products_type = '" & typeDvd & "'" & _
 "     order by nb_dvdAchat desc"

        Return sql
    End Function
    Public Shared Function GetInsertCreateRateRotationAbo() As String
        Dim sql As String
        sql = "call proc_createRateRotationAbo"
        Return sql
    End Function

    Public Shared Function GetInsertOrdersDetailsPurchase(ByVal ordersPurchase_id As Integer, _
                                                            ByVal qty As Integer) As String
        Dim sql As String

        sql = "insert into OrdersDetailsPurchase values ( " & _
         " null," & _
         ordersPurchase_id & "," & _
         qty & "," & _
         "null," & _
         "now()," & _
         PlushData.clsSession.user_id & "," & _
         "DEFAULT(active)" & _
        ")"

        Return sql
    End Function
    Public Shared Function GetInsertOrdersPurchase(ByVal products_id As Integer, _
                                                       ByVal qty As Integer, _
                                                       ByVal cost As Decimal, _
                                                       ByVal supplier As String) As String
        Dim sql As String

        sql = "insert into OrdersPurchase values ( " & _
         " null," & _
         products_id & "," & _
         qty & "," & _
         PlushTools.ClsPrice.FormatPrice(cost) & "," & _
         "'" & supplier & "'," & _
         "null," & _
         "now()," & _
         PlushData.clsSession.user_id & "," & _
         "DEFAULT(active)," & _
         "DEFAULT(status_order)" & _
        ")"

        Return sql
    End Function
#End Region

#Region "UPDATE"

    Public Shared Function getUpdateStatusOrder(ByVal typeorder As String, ByVal ordersPurchase_id As Integer) As String
        Dim sql As String

        sql = "update OrdersPurchase set " & _
          " status_order = '" & typeorder & "' ,last_modified = now(),user_modified = " & PlushData.clsSession.user_id & _
         " where ordersPurchase_id = " & ordersPurchase_id

        Return sql
    End Function

    Public Shared Function getUpdateStatusOrder(ByVal typeorder As StatusOrder, ByVal ordersPurchase_id As Integer) As String
        Dim sql As String
        sql = getUpdateStatusOrder(PlushTools.clsEnum.getNameStrEnum(typeorder), ordersPurchase_id)
        Return sql
    End Function
    Public Shared Function GetUpdateOrdersDetailsPurchase(ByVal ordersDetailsPurchase_id As Integer, _
                                                            ByVal qty As Integer) As String

        Dim sql As String

        sql = "update OrdersDetailsPurchase set " & _
        " qty = " & qty & ",last_modified = now(),user_modified = " & PlushData.clsSession.user_id & _
        " where ordersDetailsPurchase_id = " & ordersDetailsPurchase_id

        Return sql

    End Function
    Public Shared Function GetUpdateOrdersPurchase(ByVal ordersPurchase_id As Integer, _
                                                       ByVal qty As Integer, _
                                                       ByVal cost As Decimal, _
                                                       ByVal supplier As String, _
                                                       ByVal status_order As String) As String

        Dim sql As String

        sql = "update OrdersPurchase set " & _
      " qty = " & qty & _
      ",cost = " & PlushTools.ClsPrice.FormatPrice(cost) & _
      ",supplier = '" & supplier & "'" & _
      ",status_order = '" & status_order & "'" & _
      ",last_modified = now(),user_modified = " & PlushData.clsSession.user_id & _
      " where ordersPurchase_id = " & ordersPurchase_id

        Return sql


    End Function
    Public Shared Function GetDeleteOrdersDetailsPurchase(ByVal ordersDetailsPurchase_id As Integer) As String
        Dim sql As String
        sql = "update OrdersDetailsPurchase set " & _
          " active = 0 ,last_modified = now(),user_modified = " & PlushData.clsSession.user_id & _
          " where ordersDetailsPurchase_id = " & ordersDetailsPurchase_id

        Return sql

    End Function
    Public Shared Function GetDeleteOrdersPurchase(ByVal ordersPurchase_id As Integer) As String
        Dim sql As String
        sql = "update OrdersPurchase set " & _
         " active = 0 ,last_modified = now(),user_modified = " & PlushData.clsSession.user_id & _
         " where ordersPurchase_id = " & ordersPurchase_id

        Return sql
    End Function

#End Region

#Region "DELETE"
    ''' <summary>
    ''' delete the data if the table contains data of today 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetDeletePrevisionPurchaseCurrentdate() As String
        Dim sql As String
        sql = "delete p from PrevisionAchat p where date(now()) = p.date_added"
        Return sql
    End Function
#End Region

    'select DISTINCT w.product_id,w.priority,w.customers_id,func_GetRateDVDWishlist(w.product_id,w.customers_id,maxp,2,func_RateRotationAbo(stat.qty_credit,stat.dvd_norm),stat.qty_credit,'" & PlushTools.clsEnum.getNameStrEnum(dvdpostdata.clsProductDvd.Type_DVD.DVD_NORM) & "') ponderation
    ' from wishlist w
    ' Join /* stat */
    '  (
    '     select wish.*,c.customers_abo_dvd_norm dvd_norm ,pa.qty_credit
    '     from customers c
    '     join products_abo pa on c.customers_next_abo_type = pa.products_id
    '     Join /* wish */
    '     (
    '       select w.customers_id,max_priority.maxp,count(1) cpt_dvd_wishlist
    '       from v_wishlist w
    '          Join /*max_priority*/
    '           (
    '              select customers_id,if(w.high >= w.customers_abo_dvd_norm * 2,1,if(w.high + w.mediums >= w.customers_abo_dvd_norm * 2 ,2,3)) maxp
    '              from /*w*/
    '             (

    '                    select c.customers_id,c.customers_abo_dvd_norm,
    '                    (select count(w.priority)  from v_wishlist w where w.priority = 1 and w.customers_id = c.customers_id and w.wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(dvdpostdata.clsProductDvd.Type_DVD.DVD_NORM) & "' ) high,
    '                    (select count(w.priority)  from v_wishlist w where w.priority = 2 and w.customers_id = c.customers_id and w.wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(dvdpostdata.clsProductDvd.Type_DVD.DVD_NORM) & "') mediums,
    '                    (select count(w.priority)  from v_wishlist w where w.priority = 3 and w.customers_id = c.customers_id and w.wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(dvdpostdata.clsProductDvd.Type_DVD.DVD_NORM) & "') low
    '                     from customers c where c.customers_abo = 1
    '                     and c.customers_abo_suspended = 0 And c.customers_abo_dvd_norm > 0
    '                     and customers_id in (78657,27055,49547,65901,46173,174065,109334,182042,1006060,1036057,91092,86068,185166,85134,114937,215521,121745,184111)


    '            ) w

    '          ) max_priority on w.customers_id = max_priority.customers_id and w.priority <= max_priority.maxp
    '        where(w.wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(dvdpostdata.clsProductDvd.Type_DVD.DVD_NORM) & "')  group by w.customers_id,max_priority.maxp
    '     ) wish on c.customers_id = wish.customers_id
    '    where c.customers_abo = 1 and c.customers_abo_suspended = 0 and customers_abo_dvd_norm > 0 and pa.qty_credit > 0
    ' ) stat

End Class
