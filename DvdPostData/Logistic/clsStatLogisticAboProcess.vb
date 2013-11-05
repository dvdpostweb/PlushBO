Public Class clsStatLogisticAboProcess

   
    Public Shared Function getSelectAboProcessServed(ByVal dateFrom As String, ByVal dateTo As String, ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As String

        Dim sql As String

        sql = " select date_start,((served/total) * 100) pourcent_served,((partial_served/total) * 100) pourcent_partial_served,total,served,partial_served " & _
              " from ( " & _
              "     select xx.date_start date_start,sum(if(reason in (" & PlushData.Customer_stat.TypeReason.SERVED & "," & PlushData.Customer_stat.TypeReason.PARTIAL_SERVED & "," & PlushData.Customer_stat.TypeReason.NOTFOUNDDVD & "," & PlushData.Customer_stat.TypeReason.MSGERROR & "),cpt,0)) total, " & _
              "     sum(if(reason = " & PlushData.Customer_stat.TypeReason.SERVED & ",cpt,0)) served," & _
              "     sum(if(reason = " & PlushData.Customer_stat.TypeReason.PARTIAL_SERVED & ",cpt,0)) partial_served " & _
              "     from ( " & _
              "         select cas.reason,date(date_start) date_start,count(*) cpt " & _
              "         from aboprocess_stats_new abs " & _
              "         join customers_aboprocess_stats_new cas on abs.aboprocess_id = cas.aboprocess_id " & _
              "     where cas.sleep = 0 and abs.products_type = " & type_dvd & _
              "           and  date(abs.date_start) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & _
              "              ' and date(abs.date_start) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
              "     group by cas.reason,date(abs.date_start) " & _
              "     ) xx group by date_start " & _
              " ) xxx group by date_start "

        Return sql
    End Function

    Public Shared Function getSelectRateRotationAverage(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = "select abo_type,sum(averageRotation) / count(*) average_time from RateRotationAbo " & _
              " where date(date_added) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(date_added) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
              " group by abo_type "
        Return sql
    End Function

    Public Shared Function getSelectSizeWishlistNoServed(ByVal dateFrom As String, ByVal dateTo As String, ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As String
        Dim sql As String

        sql = " select date_start,sum(if (nbwishlist > 0 and nbwishlist <= 5,1,0)) wl_5," & _
              "  sum(if (nbwishlist > 5 and nbwishlist <= 10,1,0)) wl_10, " & _
         " sum(if (nbwishlist > 10 and nbwishlist <= 15,1,0)) wl_15," & _
         " sum(if (nbwishlist > 15 and nbwishlist <= 20,1,0)) wl_20," & _
         " sum(if(nbwishlist > 20,1,0)) wl_Plus20," & _
         " count(*) total " & _
         " from " & _
         "( " & _
         "      select cas.*,date(abs.date_start) date_start " & _
         "      from aboprocess_stats_new abs " & _
         "      join customers_aboprocess_stats_new cas on abs.aboprocess_id = cas.aboprocess_id " & _
         "      where cas.sleep = 0 and abs.products_type = " & type_dvd & _
         "         and date(abs.date_start) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' " & _
         "          and date(abs.date_start) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' and cas.reason = 5 and nbwishlist > 0 " & _
         " ) x group by date_start"
        Return sql
    End Function

    Public Shared Function getSelectedHighMediumLowDVDSent(ByVal dateFrom As String, ByVal dateTo As String, ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As String
        Dim sql As String

        sql = " select sum(dvd_highsent) high,sum(dvd_mediumsent) mediums , sum(dvd_lowsent) low, sum(dvd_sent) total" & _
              " from aboprocess_stats_new abs " & _
              " where abs.products_type = " & type_dvd & _
              "     and  date(abs.date_start) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & _
              "      ' and date(abs.date_start) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'"
        Return sql
    End Function

    Public Shared Function getSelectServedWlRank(ByVal dateFrom As String, ByVal dateTo As String, ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As String

        Dim sql As String

        sql = " select xx.date_start,xx.wl,xx.rank,count(*) cpt_customers from (" & _
              "   select if(nbwishlist = 0,0, " & _
              "            if (nbwishlist > 0 and nbwishlist <= 5,5, " & _
              "                if (nbwishlist > 5 and nbwishlist <= 10,10, " & _
              "                    if (nbwishlist > 10 and nbwishlist <= 15,15," & _
              "                        if (nbwishlist > 15 and nbwishlist <= 20,20, " & _
              "                             if(nbwishlist > 20,25,-1)))))) wl, " & _
              " (select max(customer_abo_rank) from aboprocess_stats_new aa join customers_aboprocess_stats_new aac on aa.aboprocess_id = aac.aboprocess_id " & _
              "  where abs.products_type = " & type_dvd & " and date(aa.date_start) = date(abs.date_start - 1) " & _
              "       and aac.customers_id = cas.customers_id ) rank " & _
              "   ,reason,customers_id,dvd_abo,date(abs.date_start) date_start " & _
              "      from aboprocess_stats_new abs " & _
              " join customers_aboprocess_stats_new cas on abs.aboprocess_id = cas.aboprocess_id " & _
              " where cas.sleep = 0 and abs.products_type = " & type_dvd & _
              "      and date(abs.date_start) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & _
              "     ' and date(abs.date_start) <= '" & PlushTools.ClsDate.formatDate(dateTo) & _
              "     ' and cas.dvd_to_send  > 0 and cas.reason in (0,8) " & _
              " ) xx " & _
              " group by xx.wl,xx.rank,xx.date_start " & _
              " order by date_start,rank desc"
        Return sql

    End Function

    Public Shared Function getSelectNoServedWlRank(ByVal dateFrom As String, ByVal dateTo As String, ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As String

        Dim sql As String

        sql = " select xx.date_start,xx.wl,xx.customer_abo_rank,count(*) cpt_customers from (" & _
              "   select if(nbwishlist = 0,0, " & _
              "            if (nbwishlist > 0 and nbwishlist <= 5,5, " & _
              "                if (nbwishlist > 5 and nbwishlist <= 10,10, " & _
              "                    if (nbwishlist > 10 and nbwishlist <= 15,15," & _
              "                        if (nbwishlist > 15 and nbwishlist <= 20,20, " & _
              "                             if(nbwishlist > 20,25,-1)))))) wl,customer_abo_rank,reason,customers_id,dvd_abo,date(abs.date_start) date_start " & _
              "      from aboprocess_stats_new abs " & _
              " join customers_aboprocess_stats_new cas on abs.aboprocess_id = cas.aboprocess_id " & _
              " where cas.sleep = 0 and abs.products_type = " & type_dvd & _
              "       and  date(abs.date_start) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & _
              "     ' and date(abs.date_start) <= '" & PlushTools.ClsDate.formatDate(dateTo) & _
              "     ' and (cas.dvd_to_send) = 0 and cas.reason = 5 " & _
              " ) xx " & _
              " group by xx.wl,xx.customer_abo_rank,xx.date_start " & _
              " order by date_start,wl,customer_abo_rank desc"
        Return sql

    End Function

    Public Shared Function getselectCustomersNoServedRecurring(ByVal dateFrom As String, ByVal dateTo As String, ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As String
        Dim sql As String

        sql = " select ( " & _
                "   select count(distinct customers_id) " & _
                "   from aboprocess_stats_new abs " & _
                "   join customers_aboprocess_stats_new cas on abs.aboprocess_id = cas.aboprocess_id " & _
                "   where cas.sleep = 0 and abs.products_type = " & type_dvd & _
                "      and  date(abs.date_start) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & _
                "    ' and date(abs.date_start) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
                "   and cas.reason in(" & PlushData.Customer_stat.TypeReason.NOTFOUNDDVD & "," & PlushData.Customer_stat.TypeReason.SERVED & "," & PlushData.Customer_stat.TypeReason.PARTIAL_SERVED & ")) cust_must_served, " & _
                " ( " & _
                "   select count(distinct customers_id) " & _
                "   from aboprocess_stats_new abs " & _
                "   join customers_aboprocess_stats_new cas on abs.aboprocess_id = cas.aboprocess_id " & _
                "   where cas.sleep = 0 and abs.products_type = " & type_dvd & _
                "     and date(abs.date_start) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & _
                "    ' and date(abs.date_start) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
                "   and cas.reason in(" & PlushData.Customer_stat.TypeReason.NOTFOUNDDVD & ")) cust_not_served "

        Return sql

    End Function

    'Public Shared Function getSelectCustomerNothingServed(ByVal dateFrom As String, ByVal dateTo As String) As String
    '    Dim sql As String

    '    sql = "        select noServed.* from " & _
    '            " ( " & _
    '            "   select distinct customers_id" & _
    '            "   from aboprocess_stats_new abs" & _
    '            "   join customers_aboprocess_stats_new cas on abs.aboprocess_id = cas.aboprocess_id" & _
    '            "   where date(abs.date_start) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(abs.date_start) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
    '            "   and cas.reason in(5)" & _
    '            " ) noServed" & _
    '            " left join " & _
    '            " ( " & _
    '            "   select distinct customers_id" & _
    '            "   from aboprocess_stats_new abs " & _
    '            "   join customers_aboprocess_stats_new cas on abs.aboprocess_id = cas.aboprocess_id" & _
    '            "   where date(abs.date_start) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(abs.date_start) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
    '            "   and cas.reason in(0,8)" & _
    '            " ) oneServed" & _
    '            " on noServed.customers_id = oneServed.customers_id" & _
    '            "        where(oneServed.customers_id Is null)" & _
    '            " order by noServed.customers_id desc "
    '    Return sql
    'End Function
    Public Shared Function getSelectTimeElapsedPerDVD(ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As String
        Dim sql As String

        sql = "SELECT time_elapsed,count(*) cpt_dvd,(select count(*) from products_dvd pd where  pd.products_dvd_status = 1 and pd.inout = 1) total_dvd from " & _
              "( " & _
              "     select if(duration <= 30,'1 month'," & _
              "                 if (duration <= 60,'2 months'," & _
              "                     if (duration <= 90,'3 months', " & _
              "                         if (duration <= 120,'4 months', " & _
              "                             if (duration <= 150,'5 months', " & _
              "                                 if (duration <= 180,'6 months', " & _
              "                                     if (duration > 180,'more 6 months','error'))))))) time_elapsed,products_id,products_dvd " & _
              " from (" & _
              " select op.products_id,op.products_dvd,(date(now()) - max(date(date_purchased))) duration,max(date(date_purchased))" & _
              " from orders o " & _
              " join orders_products op on o.orders_id = op.orders_id " & _
              " join products_dvd pd on pd.products_id = op.products_id and pd.products_dvdid = op.products_dvd " & _
              "        where(pd.products_dvd_status = 1 And pd.inout = 1 and op.orders_products_type = '" & PlushTools.clsEnum.getNameStrEnum(type_dvd) & "')" & _
              " group by op.products_id,op.products_dvd " & _
              " ) xx " & _
              " ) xxx group by time_elapsed"

        Return sql

    End Function

    Public Shared Function getSelectTimeElapsedPerProductAvailable(ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As String
        Dim sql As String

        sql = " SELECT time_elapsed,count(*) cpt_dvd,(select count(distinct pd.products_id) from products_dvd pd where  pd.products_dvd_status = 1 and pd.inout = 1) total_dvd from" & _
                " (" & _
                " select if(duration <= 30,'1 month'," & _
                "          if (duration <= 60,'2 months'," & _
                "            if (duration <= 90,'3 months'," & _
                "              if (duration <= 120,'4 months'," & _
                "                if (duration <= 150,'5 months'," & _
                "                  if (duration <= 180,'6 months'," & _
                "                    if (duration > 180,'more 6 months','error'))))))) time_elapsed,products_id" & _
                " from (" & _
                " select op.products_id,(date(now()) - max(date(date_purchased))) duration,max(date(date_purchased))" & _
                " from orders o" & _
                " join orders_products op on o.orders_id = op.orders_id" & _
                " join products_dvd pd on pd.products_id = op.products_id and pd.products_dvdid = op.products_dvd" & _
                "        where(pd.products_dvd_status = 1 And pd.inout = 1 and op.orders_products_type = '" & PlushTools.clsEnum.getNameStrEnum(type_dvd) & "')" & _
                " group by op.products_id" & _
                " ) xx" & _
                " ) xxx group by time_elapsed"
        Return sql
    End Function

    Public Shared Function getSelectCountWishlistByPriorityByProduct(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        Return "CALL spWishListReport()"
        'sql = " select * from wish_list_report order by cnt_summary desc  "
    End Function
    Public Shared Function getSelectCustomerNothingServed(ByVal dateFrom As String, ByVal dateTo As String, ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As String
        Dim sql As String

        sql = "   select w.customers_id,c.customers_abo_dvd_norm dvd_norm," & _
              "   c.customers_abo_dvd_home_norm home_dvd_norm,c.customers_abo_dvd_adult dvd_adult ," & _
              "   c.customers_abo_dvd_home_adult home_dvd_adult, sum(1) cpt " & _
              "  from" & _
              " customers c " & _
              " join  wishlist w on c.customers_id = w.customers_id and wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(type_dvd) & "'" & _
              "  join    (select noServed.* from " & _
                " ( " & _
                "   select distinct customers_id" & _
                "   from aboprocess_stats_new abs" & _
                "   join customers_aboprocess_stats_new cas on abs.aboprocess_id = cas.aboprocess_id" & _
                "   where cas.sleep = 0 and abs.products_type = " & type_dvd & _
                "        and  date(abs.date_start) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & _
                "      ' and date(abs.date_start) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
                "   and cas.reason in(5)" & _
                " ) noServed" & _
                " left join " & _
                " ( " & _
                "   select distinct customers_id" & _
                "   from aboprocess_stats_new abs " & _
                "   join customers_aboprocess_stats_new cas on abs.aboprocess_id = cas.aboprocess_id" & _
                "   where cas.sleep = 0 and abs.products_type = " & type_dvd & _
                "         and date(abs.date_start) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & _
                "       ' and date(abs.date_start) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
                "   and cas.reason in(0,8)" & _
                " ) oneServed" & _
                "  on noServed.customers_id = oneServed.customers_id" & _
                "  where(oneServed.customers_id Is null)" & _
                "           ) cust_aboprocess on w.customers_id = cust_aboprocess.customers_id" & _
                " group by w.customers_id " & _
                 " order by cpt desc "


        Return sql
    End Function
    Public Shared Function getSelectProductsNoDvdFound(ByVal dateFrom As String, ByVal dateTo As String, ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As String
        Dim sql As String
        sql = " select products_id,products_title,products_model,products_availability,count(*) cpt_cust,(select count(*) from products_dvd pd where pd.products_id = p.products_id and pd.products_dvd_status in (1,21,23,24,25)) cpt_dvd from" & _
                "( " & _
                "   select w.customers_id,w.product_id from" & _
                "   wishlist w" & _
                "  join    (     select distinct customers_id" & _
                "               from aboprocess_stats_new abs" & _
                "               join customers_aboprocess_stats_new cas on abs.aboprocess_id = cas.aboprocess_id" & _
                "               where cas.sleep = 0 and abs.products_type = " & type_dvd & _
                "                     and date(abs.date_start) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & _
                "                   ' and date(abs.date_start) <= '" & PlushTools.ClsDate.formatDate(dateTo) & _
                "                   ' and cas.reason = 5 " & _
                "           ) cust_aboprocess on w.customers_id = cust_aboprocess.customers_id" & _
                " ) xx" & _
                " join products p on xx.product_id = p.products_id" & _
                " where p.products_next = 0 and p.products_type = '" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_NORM) & "' " & _
                " group by products_id" & _
                " order by cpt_cust desc"
        Return sql
    End Function
End Class