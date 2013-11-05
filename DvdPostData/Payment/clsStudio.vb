Public Class clsStudio

    Public Shared Function GetEnumMysqlStudioType() As String
        Dim sql As String

        sql = "SHOW COLUMNS FROM studio LIKE 'studio_type' "
        Return sql
    End Function
    Public Shared Function GetEnumMysqlBillingReportType() As String
        Dim sql As String

        sql = "SHOW COLUMNS FROM studio LIKE 'billing_report_type' "
        Return sql
    End Function

    Public Shared Function getSelectStudioByStudioID(ByVal studio_id As String) As String
        Dim sql As String

        sql = " select * from studio where studio_id = " & studio_id

        Return sql
    End Function

    Public Shared Function GetStudioBilling() As String
        Dim sql As String
        sql = "select studio_id,studio_name from studio where billing_reporting = 1 "
        Return sql
    End Function

    Public Shared Function getSelectStudioByStudioNameAndStudioType(ByVal studio_name As String, ByVal studio_type As String) As String
        Dim sql As String

        sql = " select * from studio where studio_name like '%" & studio_name & "%' and studio_type like '%" & studio_type & "%'"

        Return sql
    End Function

    Public Shared Function getSelectStudioAll() As String
        Dim sql As String

        sql = " select * from studio"

        Return sql
    End Function

    Public Shared Function getInsertStudio(ByVal studio_name As String, ByVal studio_type As String, ByVal cost_for_new As Int16, ByVal cost As Int16, _
                                            ByVal fee_new_vod As String, ByVal fee_back_catalogue As String, ByVal minimum_new_vod As String, _
                                            ByVal minimum_back_catalogue As String, ByVal minimum_global As String, ByVal billing_reporting As Boolean, _
                                            ByVal VODBE As Boolean, ByVal VODLUX As Boolean, ByVal VODNL As Boolean, _
                                            ByVal price_for_new As String, ByVal price As String, _
                                            ByVal svod_fee_new_vod As String, ByVal svod_fee_back_catalogue As String, ByVal svod_minimum_new_vod As String, _
                                            ByVal svod_minimum_back_catalogue As String, ByVal svod_minimum_global As String) As String
        Dim sql As String

        sql = " insert into studio ( studio_name, studio_type, cost_for_new, cost, vod_be, fee_new_vod, fee_back_catalogue,  minimum_new_vod, minimum_back_catalogue, minimum_global, billing_reporting, vod_lux, vod_nl, plush_price_new, plush_price_back_catalogue, svod_fee_new_vod, svod_fee_back_catalogue, svod_minimum_new_vod, svod_minimum_back_catalogue, svod_minimum_global ) " & _
        "values('" & studio_name & "', '" & studio_type & "', " & cost_for_new & ", " & cost & ", " & VODBE & ", " & fee_new_vod & ", " & fee_back_catalogue & ", " & minimum_new_vod & ", " & minimum_back_catalogue & ", " & minimum_global & ", " & billing_reporting & ", " & VODLUX & ", " & VODNL & _
        ", " & price_for_new & ", " & price & ", " & svod_fee_new_vod & ", " & svod_fee_back_catalogue & ", " & svod_minimum_new_vod & ", " & _
        svod_minimum_back_catalogue & ", " & svod_minimum_global & ")"

        Return sql
    End Function

    Public Shared Function getUpdateStudio(ByVal studio_id As Int16, ByVal studio_name As String, ByVal studio_type As String, ByVal cost_for_new As String, ByVal cost As String, _
                                            ByVal fee_new_vod As String, ByVal fee_back_catalogue As String, ByVal minimum_new_vod As String, _
                                            ByVal minimum_back_catalogue As String, ByVal minimum_global As String, ByVal billing_reporting As Boolean, _
                                            ByVal VODBE As Boolean, ByVal VODLUX As Boolean, ByVal VODNL As Boolean, _
                                            ByVal price_for_new As String, ByVal price As String, _
                                            ByVal svod_fee_new_vod As String, ByVal svod_fee_back_catalogue As String, ByVal svod_minimum_new_vod As String, _
                                            ByVal svod_minimum_back_catalogue As String, ByVal svod_minimum_global As String) As String
        Dim sql As String
        Dim strStudioName = studio_name.Replace("'", "''")
        cost_for_new = cost_for_new.Replace(",", ".")
        cost = cost.Replace(",", ".")
        fee_new_vod = fee_new_vod.Replace(",", ".")
        fee_back_catalogue = fee_back_catalogue.Replace(",", ".")
        minimum_new_vod = minimum_new_vod.Replace(",", ".")
        minimum_back_catalogue = minimum_back_catalogue.Replace(",", ".")
        minimum_global = minimum_global.Replace(",", ".")

        price_for_new = price_for_new.Replace(",", ".")
        price = price.Replace(",", ".")
        svod_fee_new_vod = svod_fee_new_vod.Replace(",", ".")
        svod_fee_back_catalogue = svod_fee_back_catalogue.Replace(",", ".")
        svod_minimum_new_vod = svod_minimum_new_vod.Replace(",", ".")
        svod_minimum_back_catalogue = svod_minimum_back_catalogue.Replace(",", ".")
        svod_minimum_global = svod_minimum_global.Replace(",", ".")

        sql = " update studio set studio_name = '" & strStudioName & _
                "', studio_type = '" & studio_type & _
                "', cost_for_new = " & cost_for_new & _
                ", cost = " & cost & _
                ", fee_new_vod = " & fee_new_vod & _
                ", fee_back_catalogue = " & fee_back_catalogue & _
                ", minimum_new_vod = " & minimum_new_vod & _
                ", minimum_back_catalogue = " & minimum_back_catalogue & _
                ", minimum_global = " & minimum_global & _
                ", billing_reporting = " & billing_reporting & _
                ", vod_be = " & VODBE & _
                ", vod_lux = " & VODLUX & _
                ", vod_nl = " & VODNL & _
                ", plush_price_new = " & price_for_new & _
                ", plush_price_back_catalogue = " & price & _
                ", svod_fee_new_vod = " & svod_fee_new_vod & _
                ", svod_fee_back_catalogue = " & svod_fee_back_catalogue & _
                ", svod_minimum_new_vod = " & svod_minimum_new_vod & _
                ", svod_minimum_back_catalogue = " & svod_minimum_back_catalogue & _
                ", svod_minimum_global = " & svod_minimum_global & _
                " where studio_id = " & studio_id

        Return sql
    End Function

    Public Shared Function GetCineartDetailedReportBackcatalogue(ByVal dateFrom As String, ByVal dateTo As String, ByVal studio_id As Integer)
        Dim sql As String
        sql = " select " & _
 " x.vodstudio," & _
 " x.productstudio, " & _
 " x.products_title, " & _
 " x.imdb_id, " & _
 " x.products_type, " & _
 " x.customer_id, " & _
 " x.customers_abo_type, " & _
 " x.customers_lastname, " & _
 " x.customers_firstname, " & _
 " x.customers_language, " & _
 " x.created_at, " & _
 " x.products_date_available, " & _
 " x.available_from, " & _
 " x.expire_at, " & _
 " x.available_backcatalogue_from, " & _
 " x.expire_backcatalogue_at, " & _
 " x.catalogue_type , " & _
 " x.products_price, " & _
 " x.qty_credit, " & _
 " x.qty_at_home, " & _
 " x.credits, " & _
 " x.price_of_movie_tvac, " & _
 " (x.price_of_movie_tvac / 1.21) price_of_movie_htva, " & _
 " case x.catalogue_type when 'N' then  if(((x.price_of_movie_tvac / 1.21) * x.fee_new_vod) < x.minimum_new_vod, x.minimum_new_vod, ((x.price_of_movie_tvac / 1.21) * x.fee_new_vod))  when 'B' then  if((x.price_of_movie_htva * x.fee_back_catalogue) < x.minimum_back_catalogue, x.minimum_back_catalogue, ((x.price_of_movie_tvac / 1.21) * x.fee_back_catalogue))  end amount  " & _
 "       from " & _
 " ( " & _
 " select " & _
 " s.studio_name vodstudio, " & _
 " ps.studio_name as productstudio, " & _
 " p.products_title, " & _
 " customer_id, " & _
 "  (select fn_customers_abopackage(customers_id, t.created_at) )as customers_abo_type, " & _
 " c.customers_lastname, " & _
 " c.customers_firstname, " & _
 " ( SELECT name FROM languages where languages_id = c.customers_language) as customers_language, " & _
 " t.imdb_id, " & _
 " p.products_type, " & _
 " t.created_at, " & _
 " p.products_date_available, " & _
 " sp.available_from, " & _
 " sp.expire_at, " & _
 " sp.available_backcatalogue_from, " & _
 " sp.expire_backcatalogue_at, " & _
 " if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
  " pabo.products_price, " & _
  " if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at)) qty_credit, " & _
   " pa.qty_at_home, " & _
   " if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits, " & _
    " if(t.is_ppv = 1, t.ppv_price,(pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) price_of_movie_tvac, " & _
     " (((pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) / 1.21) price_of_movie_htva, " & _
      " s.minimum_new_vod, " & _
       " s.fee_new_vod, " & _
       " s.minimum_back_catalogue, " & _
        " s.fee_back_catalogue " & _
       " from tokens t " & _
       " join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id " & _
       " join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
                    " ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id " & _
"                       from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' and month(available_backcatalogue_from) = month('" & PlushTools.ClsDate.formatDate(dateFrom) & "') and year(available_backcatalogue_from ) < year('" & PlushTools.ClsDate.formatDate(dateTo) & "') group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id " & _
  "      join customers c on t.customer_id = c.customers_id " & _
    "    join products pabo on pabo.products_id = fn_customers_abopackage(c.customers_id,t.created_at)  " & _
      "  join products_abo pa on pabo.products_id = pa.products_id " & _
       " left join studio s on s.studio_id = sp.studio_id " & _
       " left join studio ps on ps.studio_id = p.products_studio " & _
       " left join directors d on d.directors_id = p.products_directors_id " & _
        " where t.compensed = 0 and s.studio_id = " & studio_id & _
        " and t.created_at between date_add('" & PlushTools.ClsDate.formatDate(dateFrom) & "', interval -1 year) and '" & PlushTools.ClsDate.formatDate(dateFrom) & "' " & _
        " and t.kind in ('NORMAL','PPV') " & _
" group by s.studio_name, ps.studio_name, c.customers_id, t.created_at " & _
  "             order by s.studio_name, ps.studio_name,  p.products_title, t.created_at " & _
   " ) x " & _
 " where x.qty_credit <> 10000"

        '" and not ( p.products_type = 'DVD_ADULT'and c.svod_adult in(1,2,3) and exists(select * from customers_svod cs where c.customers_id = cs.customer_id and t.created_at between cs.created_at and cs.validityto)) " & _
        Return sql
    End Function

    Public Shared Function GetCineartSummaryReportBackcatalogue(ByVal dateFrom As String, ByVal dateTo As String, ByVal in_studio_id As Integer, Optional ByVal isDVDPOST As Boolean = True, Optional ByVal isKPN As Boolean = True)
        Dim sql As String

        sql = "  select x.vodstudio, x.productstudio, x.products_title, count(x.imdb_id) number_titles, sum(format(x.price_of_movie_tvac,2))  tvac_sum, " & _
   " sum(format(x.price_of_movie_tvac/1.21,2)) htvac_sum, " & _
   " sum(case x.catalogue_type when 'N' then " & _
" format(if(((x.price_of_movie_tvac/1.21) * x.fee_new_vod) < x.minimum_new_vod, x.minimum_new_vod, ((x.price_of_movie_tvac/1.21) * x.fee_new_vod)),2)" & _
" when 'B' then " & _
" format(if((x.price_of_movie_htva * x.fee_back_catalogue) < x.minimum_back_catalogue, x.minimum_back_catalogue, (x.price_of_movie_htva * x.fee_back_catalogue)),2) " & _
" end ) amount_sum , date(sysdate()) date_created, '" & PlushTools.ClsDate.formatDate(dateFrom) & "' period_start , '" & PlushTools.ClsDate.formatDate(dateTo) & "' period_end" & _
" from " & _
" ( "
        Dim sqlDVDPOST As String = "  select 'DVDPOST' source, " & _
"  s.studio_name vodstudio, " & _
"  ps.studio_name as productstudio, " & _
"  p.products_title, " & _
"  t.imdb_id, " & _
"  p.products_type, " & _
"  t.created_at, " & _
"  p.products_date_available, " & _
"  sp.available_from, " & _
"  sp.expire_at, " & _
"  sp.available_backcatalogue_from, " & _
"  sp.expire_backcatalogue_at, " & _
"  if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
"  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at)) qty_credit, " & _
"  if(t.is_ppv = 1, t.ppv_price,(pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) price_of_movie_tvac,  " & _
"  (((pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) / 1.21) price_of_movie_htva, " & _
" s.minimum_new_vod, " & _
" s.fee_new_vod, " & _
" s.minimum_back_catalogue, " & _
" s.fee_back_catalogue " & _
"  from tokens t  " & _
"  join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id " & _
 " join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
 " ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' and month(available_backcatalogue_from) = month('" & PlushTools.ClsDate.formatDate(dateFrom) & "') and year(available_backcatalogue_from ) < year('" & PlushTools.ClsDate.formatDate(dateFrom) & "') group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  " & _
 " join customers c on t.customer_id = c.customers_id  join products pabo on pabo.products_id = fn_customers_abopackage(c.customers_id,t.created_at)  " & _
 " join products_abo pa on pabo.products_id = pa.products_id " & _
 " left join studio s on s.studio_id = sp.studio_id " & _
 " left join studio ps on ps.studio_id = p.products_studio " & _
 " left join directors d on d.directors_id = p.products_directors_id " & _
" where t.compensed = 0 and t.created_at between date_add('" & PlushTools.ClsDate.formatDate(dateFrom) & "', interval -1 year) and '" & PlushTools.ClsDate.formatDate(dateFrom) & "' " & _
" and s.studio_id = " & in_studio_id & " and t.kind in ('NORMAL','PPV') " & _
" group by vodstudio, productstudio, c.customers_id, t.created_at "

        Dim sqlKPN As String = " select 'KPN' source, " & _
" s.studio_name vodstudio, " & _
" ps.studio_name as productstudio, " & _
" p.products_title, " & _
" t.imdb_id, " & _
" p.products_type, " & _
" concat(date(t.date_achat),time(t.date_achat)) created_at, " & _
" p.products_date_available, " & _
" sp.available_from, " & _
" sp.expire_at," & _
" sp.available_backcatalogue_from, " & _
" sp.expire_backcatalogue_at, " & _
" if(t.date_achat between available_from and expire_at,'N',if(t.date_achat between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
" 11 qty_credit, " & _
" format(t.amount_title,2) price_of_movie_tvac, " & _
" format(format(t.amount_title,2)/ 1.21,2) price_of_movie_htva, " & _
" s.minimum_new_vod, " & _
" s.fee_new_vod, " & _
" s.minimum_back_catalogue, " & _
" s.fee_back_catalogue " & _
" from an_kpn_reports t " & _
" join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id " & _
" join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, s.is_ppv, " & _
" ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' and month(available_backcatalogue_from) = month('" & PlushTools.ClsDate.formatDate(dateFrom) & "') and year(available_backcatalogue_from ) < year('" & PlushTools.ClsDate.formatDate(dateFrom) & "') group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  " & _
" left join studio s on s.studio_id = sp.studio_id " & _
" left join studio ps on ps.studio_id = p.products_studio " & _
" left join directors d on d.directors_id = p.products_directors_id " & _
" where sp.is_ppv = 0 and t.in_abcd = 1 and t.date_achat between date_add('" & PlushTools.ClsDate.formatDate(dateFrom) & "', interval -1 year) and '" & PlushTools.ClsDate.formatDate(dateFrom) & "' " & _
" and s.studio_id = " & in_studio_id & _
" group by vodstudio, productstudio, t.id "
        If isDVDPOST Then
            sql = sql & sqlDVDPOST
        End If

        If isDVDPOST And isKPN Then
            sql = sql & " union "
        End If

        If isKPN Then
            sql = sql & sqlKPN
        End If
        sql = sql & " order by vodstudio, productstudio, products_title" & _
" ) x  where x.qty_credit <> 10000 " & _
" group by 1,2,3 "

        '        sql = "  select x.vodstudio, x.productstudio, x.products_title, count(x.imdb_id) number_titles, sum(x.price_of_movie_tvac)  tvac_sum, " & _
        '" sum(x.price_of_movie_htva) htvac_sum, " & _
        '" sum(case x.catalogue_type when 'N' then if(((x.price_of_movie_tvac / 1.21) * x.fee_new_vod) < x.minimum_new_vod, x.minimum_new_vod, ((x.price_of_movie_tvac / 1.21) * x.fee_new_vod)) " & _
        '" when 'B' then " & _
        ' " if(((x.price_of_movie_tvac / 1.21) * x.fee_back_catalogue) < x.minimum_back_catalogue, x.minimum_back_catalogue, ((x.price_of_movie_tvac / 1.21) * x.fee_back_catalogue)) " & _
        ' " end ) amount_sum " & _
        '        " from " & _
        ' "( " & _
        '  " select " & _
        '  " s.studio_name vodstudio, " & _
        '"  ps.studio_name as productstudio, " & _
        '      " p.products_title, " & _
        '        " customer_id, " & _
        '      "   c.customers_abo_type, " & _
        '    "     c.customers_lastname, " & _
        '  "       c.customers_firstname, " & _
        '"   ( SELECT name FROM languages where languages_id = c.customers_language) as customers_language,  " & _
        '        " t.imdb_id, " & _
        '      "   p.products_type, " & _
        '    "     t.created_at, " & _
        '  "       p.products_date_available, " & _
        '"         sp.available_from, " & _
        '       "  sp.expire_at, " & _
        '     "    sp.available_backcatalogue_from, " & _
        '   "      sp.expire_backcatalogue_at, " & _
        ' "  if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type,  " & _
        ' "            pabo.products_price, " & _
        ' "  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at)) qty_credit,  " & _
        '   "              pa.qty_at_home, " & _
        '"   if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits,  " & _
        '"  if(t.is_ppv = 1, t.ppv_price,(pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) price_of_movie_tvac,  " & _
        '"  (((pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) / 1.21) price_of_movie_htva, " & _
        '                   "  s.minimum_new_vod, " & _
        '                   "  s.fee_new_vod, " & _
        '                   "  s.minimum_back_catalogue, " & _
        '                   "  s.fee_back_catalogue" & _
        ' "  from tokens t  " & _
        '"  join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id  " & _
        ' " join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
        ' " ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' and month(available_backcatalogue_from) = month('" & PlushTools.ClsDate.formatDate(dateFrom) & "') and year(available_backcatalogue_from ) < year('" & PlushTools.ClsDate.formatDate(dateFrom) & "')" & _
        '"  group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id " & _
        ' "  join customers c on t.customer_id = c.customers_id  join products pabo on pabo.products_id = fn_customers_abopackage(c.customers_id,t.created_at)  " & _
        '"   join products_abo pa on pabo.products_id = pa.products_id " & _
        ' "  left join studio s on s.studio_id = sp.studio_id  " & _
        ' "  left join studio ps on ps.studio_id = p.products_studio " & _
        ' "  left join directors d on d.directors_id = p.products_directors_id  " & _
        '"  where t.compensed = 0 and  s.studio_id = " & in_studio_id & _
        '     " and t.created_at between date_add('" & PlushTools.ClsDate.formatDate(dateFrom) & "', interval -1 year) and '" & PlushTools.ClsDate.formatDate(dateFrom) & "' " & _
        '             " and t.kind in ('NORMAL','PPV') " & _
        ' " order by s.studio_name, ps.studio_name,  p.products_title " & _
        ' " ) x  where x.qty_credit <> 10000  " & _
        '" group by 1,2,3"

        '" and not ( p.products_type = 'DVD_ADULT'and c.svod_adult in(1,2,3) and exists(select * from customers_svod cs where c.customers_id = cs.customer_id and t.created_at between cs.created_at and cs.validityto)) " & _

        Return sql
    End Function

    Public Shared Function GetCineartSummaryReportNew(ByVal dateFrom As String, ByVal dateTo As String, ByVal in_studio_id As Integer, Optional ByVal isDVDPOST As Boolean = True, Optional ByVal isKPN As Boolean = True)
        Dim sql As String

        sql = "  select x.vodstudio, x.productstudio, x.products_title, count(x.imdb_id) number_titles, sum(format(x.price_of_movie_tvac,2))  tvac_sum, " & _
       " sum(format(x.price_of_movie_tvac/1.21,2)) htvac_sum, " & _
       " sum(case x.catalogue_type when 'N' then " & _
" format(if(((x.price_of_movie_tvac/1.21) * x.fee_new_vod) < x.minimum_new_vod, x.minimum_new_vod, ((x.price_of_movie_tvac/1.21) * x.fee_new_vod)),2)" & _
" when 'B' then " & _
" format(if((x.price_of_movie_htva * x.fee_back_catalogue) < x.minimum_back_catalogue, x.minimum_back_catalogue, (x.price_of_movie_htva * x.fee_back_catalogue)),2) " & _
" end ) amount_sum from " & _
" ( "
        Dim sqlDVDPOST As String = "  select 'DVDPOST' source, " & _
"  s.studio_name vodstudio, " & _
"  ps.studio_name as productstudio, " & _
"  p.products_title, " & _
"  t.imdb_id, " & _
"  p.products_type, " & _
"  t.created_at, " & _
"  p.products_date_available, " & _
"  sp.available_from, " & _
"  sp.expire_at, " & _
"  sp.available_backcatalogue_from, " & _
"  sp.expire_backcatalogue_at, " & _
"  if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
"  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at)) qty_credit, " & _
"  if(t.is_ppv = 1, t.ppv_price,(pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) price_of_movie_tvac,  " & _
"  (((pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) / 1.21) price_of_movie_htva, " & _
" s.minimum_new_vod, " & _
" s.fee_new_vod, " & _
" s.minimum_back_catalogue, " & _
" s.fee_back_catalogue " & _
"  from tokens t  " & _
"  join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id " & _
 " join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
 " ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  and t.created_at between sp.available_from and sp.expire_at " & _
 " join customers c on t.customer_id = c.customers_id  join products pabo on pabo.products_id = fn_customers_abopackage(c.customers_id,t.created_at)  " & _
 " join products_abo pa on pabo.products_id = pa.products_id " & _
 " left join studio s on s.studio_id = sp.studio_id " & _
 " left join studio ps on ps.studio_id = p.products_studio " & _
 " left join directors d on d.directors_id = p.products_directors_id " & _
" where t.compensed = 0 and sp.expire_at between '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
" and s.studio_id = " & in_studio_id & " and t.kind in ('NORMAL','PPV') " & _
" group by vodstudio, productstudio, c.customers_id, t.created_at "

        Dim sqlKPN As String = " select 'KPN' source, " & _
" s.studio_name vodstudio, " & _
" ps.studio_name as productstudio, " & _
" p.products_title, " & _
" t.imdb_id, " & _
" p.products_type, " & _
" concat(date(t.date_achat),time(t.date_achat)) created_at, " & _
" p.products_date_available, " & _
" sp.available_from, " & _
" sp.expire_at," & _
" sp.available_backcatalogue_from, " & _
" sp.expire_backcatalogue_at, " & _
" if(t.date_achat between available_from and expire_at,'N',if(t.date_achat between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
" 11 qty_credit, " & _
" format(t.amount_title,2) price_of_movie_tvac, " & _
" format(format(t.amount_title,2)/ 1.21,2) price_of_movie_htva, " & _
" s.minimum_new_vod, " & _
" s.fee_new_vod, " & _
" s.minimum_back_catalogue, " & _
" s.fee_back_catalogue " & _
" from an_kpn_reports t " & _
" join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id " & _
" join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, s.is_ppv, " & _
" ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  and t.date_achat between sp.available_from and sp.expire_at  " & _
" left join studio s on s.studio_id = sp.studio_id " & _
" left join studio ps on ps.studio_id = p.products_studio " & _
" left join directors d on d.directors_id = p.products_directors_id " & _
" where sp.is_ppv = 0 and t.in_abcd = 1 and sp.expire_at between '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
" and s.studio_id = " & in_studio_id & _
" group by vodstudio, productstudio, t.id "
        If isDVDPOST Then
            sql = sql & sqlDVDPOST
        End If

        If isDVDPOST And isKPN Then
            sql = sql & " union "
        End If

        If isKPN Then
            sql = sql & sqlKPN
        End If
        sql = sql & " order by vodstudio, productstudio, products_title" & _
" ) x  where x.qty_credit <> 10000 " & _
" group by 1,2,3 "

        '        sql = "  select x.vodstudio, x.productstudio, x.products_title, count(x.imdb_id) number_titles, sum(x.price_of_movie_tvac)  tvac_sum, " & _
        '" sum(x.price_of_movie_htva) htvac_sum, " & _
        '" sum(case x.catalogue_type when 'N' then if(((x.price_of_movie_tvac / 1.21) * x.fee_new_vod) < x.minimum_new_vod, x.minimum_new_vod, ((x.price_of_movie_tvac / 1.21)* x.fee_new_vod)) " & _
        '" when 'B' then " & _
        ' " if(((x.price_of_movie_tvac / 1.21) * x.fee_back_catalogue) < x.minimum_back_catalogue, x.minimum_back_catalogue, ((x.price_of_movie_tvac / 1.21) * x.fee_back_catalogue)) " & _
        ' " end ) amount_sum " & _
        '        " from " & _
        ' "( " & _
        '  " select " & _
        '  " s.studio_name vodstudio, " & _
        '"  ps.studio_name as productstudio, " & _
        '      " p.products_title, " & _
        '        " customer_id, " & _
        '      "   c.customers_abo_type, " & _
        '    "     c.customers_lastname, " & _
        '  "       c.customers_firstname, " & _
        '"   ( SELECT name FROM languages where languages_id = c.customers_language) as customers_language,  " & _
        '        " t.imdb_id, " & _
        '      "   p.products_type, " & _
        '    "     t.created_at, " & _
        '  "       p.products_date_available, " & _
        '"         sp.available_from, " & _
        '       "  sp.expire_at, " & _
        '     "    sp.available_backcatalogue_from, " & _
        '   "      sp.expire_backcatalogue_at, " & _
        ' "  if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type,  " & _
        ' "            pabo.products_price, " & _
        ' "  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at)) qty_credit,  " & _
        '   "              pa.qty_at_home, " & _
        '"   if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits,  " & _
        '"  if(t.is_ppv = 1, t.ppv_price,(pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) price_of_movie_tvac,  " & _
        '"  (((pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) / 1.21) price_of_movie_htva, " & _
        '                   "  s.minimum_new_vod, " & _
        '                   "  s.fee_new_vod, " & _
        '                   "  s.minimum_back_catalogue, " & _
        '                   "  s.fee_back_catalogue" & _
        ' "  from tokens t  " & _
        '"  join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id  " & _
        ' " join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
        ' " ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' " & _
        '"  group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  and t.created_at between sp.available_from and sp.expire_at  " & _
        ' "  join customers c on t.customer_id = c.customers_id  join products pabo on pabo.products_id = fn_customers_abopackage(c.customers_id,t.created_at)  " & _
        '"   join products_abo pa on pabo.products_id = pa.products_id " & _
        ' "  left join studio s on s.studio_id = sp.studio_id  " & _
        ' "  left join studio ps on ps.studio_id = p.products_studio " & _
        ' "  left join directors d on d.directors_id = p.products_directors_id  " & _
        '"  where t.compensed = 0 and sp.expire_at between '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
        '"      and s.studio_id = " & in_studio_id & " and t.kind in ('NORMAL','PPV') " & " group by s.studio_name, ps.studio_name, c.customers_id, t.created_at " & _
        ' " order by s.studio_name, ps.studio_name,  p.products_title " & _
        ' " ) x  where x.qty_credit <> 10000  " & _
        '" group by 1,2,3"

        '" and not ( p.products_type = 'DVD_ADULT'and c.svod_adult in(1,2,3) and exists(select * from customers_svod cs where c.customers_id = cs.customer_id and t.created_at between cs.created_at and cs.validityto)) " & _

        Return sql
    End Function

    Public Shared Function GetCineartDetailedReportNew(ByVal dateFrom As String, ByVal dateTo As String, ByVal in_studio_id As Integer) As String
        Dim sql As String

        sql = " select " & _
 " x.vodstudio, " & _
 "        x.productstudio, " & _
   "      x.products_title, " & _
     "    x.customer_id, " & _
       "  x.customers_abo_type, " & _
        " x.customers_lastname, " & _
        " x.customers_firstname, " & _
        " x.customers_language, " & _
        " x.imdb_id, " & _
        " x.products_type, " & _
        " x.created_at, " & _
        " x.products_date_available, " & _
        " x.available_from, " & _
        " x.expire_at, " & _
        " x.available_backcatalogue_from, " & _
        " x.expire_backcatalogue_at, " & _
        " x.catalogue_type, " & _
        " x.products_price, " & _
        " x.qty_credit, " & _
        " x.qty_at_home, " & _
        " x.credits, " & _
        " x.price_of_movie_tvac, " & _
        " (x.price_of_movie_tvac / 1.21) price_of_movie_htva, " & _
 " case x.catalogue_type when 'N' then  if(((x.price_of_movie_tvac / 1.21) * x.fee_new_vod) < x.minimum_new_vod, x.minimum_new_vod, ((x.price_of_movie_tvac / 1.21) * x.fee_new_vod))  when 'B' then  if((x.price_of_movie_htva * x.fee_back_catalogue) < x.minimum_back_catalogue, x.minimum_back_catalogue, (x.price_of_movie_htva * x.fee_back_catalogue))  end amount  " & _
        " from  " & _
" (  " & _
 " select " & _
   "      s.studio_name as vodstudio, " & _
 " ps.studio_name as productstudio, " & _
   "      p.products_title, " & _
     "    customer_id, " & _
 " (select fn_customers_abopackage(customers_id, t.created_at) )as customers_abo_type, " & _
   "      c.customers_lastname, " & _
     "    c.customers_firstname, " & _
 " ( SELECT name FROM languages where languages_id = c.customers_language) as customers_language, " & _
   "      t.imdb_id, " & _
     "    p.products_type, " & _
       "  t.created_at, " & _
        " p.products_date_available, " & _
        " sp.available_from, " & _
        " sp.expire_at, " & _
        " sp.available_backcatalogue_from, " & _
   "     sp.expire_backcatalogue_at, " & _
 " if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
  " pabo.products_price, " & _
  " if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at)) qty_credit, " & _
    "         pa.qty_at_home, " & _
   " if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits, " & _
    " if(t.is_ppv = 1, t.ppv_price,(pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) price_of_movie_tvac, " & _
     " (((pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) / 1.21) price_of_movie_htva, " & _
       "  s.minimum_new_vod, " & _
        " s.fee_new_vod, " & _
        " s.minimum_back_catalogue, " & _
        " s.fee_back_catalogue " & _
"       from tokens t " & _
       " join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id " & _
       " join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
         "            ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id " & _
                      " from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' and expire_at between '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and '" & PlushTools.ClsDate.formatDate(dateTo) & "' group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  and t.created_at between sp.available_from and sp.expire_at  " & _
       " join customers c on t.customer_id = c.customers_id " & _
       " join products pabo on pabo.products_id = fn_customers_abopackage(c.customers_id,t.created_at)  " & _
       " join products_abo pa on pabo.products_id = pa.products_id " & _
       " left join studio s on s.studio_id = sp.studio_id " & _
       " left join studio ps on ps.studio_id = p.products_studio " & _
       " left join directors d on d.directors_id = p.products_directors_id " & _
        "         where t.compensed = 0 and s.studio_id = " & in_studio_id & _
        " and t.kind in ('NORMAL','PPV') " & _
" group by s.studio_name, ps.studio_name, c.customers_id, t.created_at " & _
  "             order by s.studio_name, ps.studio_name,  p.products_title, t.created_at  " & _
  " ) x " & _
 " where x.qty_credit <> 10000"

        '" and not ( p.products_type = 'DVD_ADULT'and c.svod_adult in(1,2,3) and exists(select * from customers_svod cs where c.customers_id = cs.customer_id and t.created_at between cs.created_at and cs.validityto)) " & _

        Return sql
    End Function

    Public Shared Function GetStudioDetailedReport(ByVal dateFrom As String, ByVal dateTo As String, ByVal studio_id As Integer) As String

        '" if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits, " & _
        Dim sql As String
        Dim allstudio As String = String.Empty

        If studio_id <> -1 Then
            allstudio = allstudio & " and s.studio_id = " & studio_id
        End If

        sql = " select  x.vodstudio, x.productstudio, x.products_title, x.customer_id, x.customers_abo_type, x.customers_lastname," & _
 " x.customers_firstname, x.customers_language, x.imdb_id, x.products_type, x.created_at, x.products_date_available, x.available_from, " & _
 " x.expire_at, x.available_backcatalogue_from, x.expire_backcatalogue_at, x.catalogue_type , x.products_price, x.qty_credit, " & _
 " x.qty_at_home, x.credits, x.price_of_movie_tvac price_of_movie_tvac, format((x.price_of_movie_tvac/1.21),2) price_of_movie_htva, " & _
" case x.catalogue_type when 'N' then " & _
" format(if(((x.price_of_movie_tvac/1.21) * x.fee_new_vod) < x.minimum_new_vod, x.minimum_new_vod, ((x.price_of_movie_tvac/1.21) * x.fee_new_vod)),2) " & _
" when 'B' then " & _
" format(if(((x.price_of_movie_tvac/1.21) * x.fee_back_catalogue) < x.minimum_back_catalogue, x.minimum_back_catalogue, ((x.price_of_movie_tvac/1.21) * x.fee_back_catalogue)),2) " & _
" end amount from " & _
" ( " & _
" select " & _
" s.studio_name vodstudio, " & _
" ps.studio_name as productstudio, " & _
" p.products_title, " & _
" customer_id,c.customers_abo_type, " & _
" c.customers_lastname, " & _
" c.customers_firstname, " & _
" ( SELECT name FROM languages where languages_id = c.customers_language) as customers_language, " & _
" t.imdb_id, " & _
" p.products_type, " & _
" t.created_at, " & _
" p.products_date_available, " & _
" sp.available_from, " & _
" sp.expire_at," & _
" sp.available_backcatalogue_from, " & _
" sp.expire_backcatalogue_at, " & _
" if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
" pabo.products_price, " & _
" if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at)) qty_credit, " & _
" pa.qty_at_home, " & _
" t.credits, " & _
" format(if(t.is_ppv = 1, t.ppv_price,(pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * t.credits),2) price_of_movie_tvac, " & _
" format((((pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * t.credits) / 1.21),2) price_of_movie_htva, " & _
" s.minimum_new_vod, " & _
" s.fee_new_vod, " & _
" s.minimum_back_catalogue, " & _
" s.fee_back_catalogue " & _
" from tokens t " & _
" join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id " & _
" join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
" ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  and ( ( t.created_at between sp.available_from and expire_at ) or (t.created_at between sp.available_backcatalogue_from and expire_backcatalogue_at))" & _
" join customers c on t.customer_id = c.customers_id  join products pabo on pabo.products_id = fn_customers_abopackage(c.customers_id,t.created_at)  " & _
" join products_abo pa on pabo.products_id = pa.products_id " & _
" left join studio s on s.studio_id = sp.studio_id " & _
" left join studio ps on ps.studio_id = p.products_studio " & _
" left join directors d on d.directors_id = p.products_directors_id " & _
" where t.compensed = 0 and date(t.created_at) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(t.created_at) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
" and t.kind in ('NORMAL','PPV') " & _
allstudio & _
" group by s.studio_name, ps.studio_name, c.customers_id, t.created_at " & _
" order by s.studio_name, ps.studio_name,  p.products_title " & _
" ) x  where x.qty_credit <> 10000 "

        Return sql

    End Function

    Public Shared Function GetStudioKPNDetailedReport(ByVal dateFrom As String, ByVal dateTo As String, ByVal studio_id As Integer) As String

        '" if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits, " & _
        Dim sql As String
        Dim allstudio As String = String.Empty

        If studio_id <> -1 Then
            allstudio = allstudio & " and s.studio_id = " & studio_id
        End If

        sql = " select  x.vodstudio, x.productstudio, x.products_title, " & _
 " x.imdb_id, x.products_type, x.created_at, x.products_date_available, x.available_from, " & _
 " x.expire_at, x.available_backcatalogue_from, x.expire_backcatalogue_at, x.catalogue_type , " & _
 " x.price_of_movie_tvac price_of_movie_tvac, format((x.price_of_movie_tvac/1.21),2) price_of_movie_htva, " & _
" case x.catalogue_type when 'N' then " & _
" format(if(((x.price_of_movie_tvac/1.21) * x.fee_new_vod) < x.minimum_new_vod, x.minimum_new_vod, ((x.price_of_movie_tvac/1.21) * x.fee_new_vod)),2) " & _
" when 'B' then " & _
" format(if(((x.price_of_movie_tvac/1.21) * x.fee_back_catalogue) < x.minimum_back_catalogue, x.minimum_back_catalogue, ((x.price_of_movie_tvac/1.21) * x.fee_back_catalogue)),2) " & _
" end amount from " & _
" ( " & _
" select " & _
" s.studio_name vodstudio, " & _
" ps.studio_name as productstudio, " & _
" p.products_title, " & _
" t.imdb_id, " & _
" p.products_type, " & _
" t.date_achat created_at, " & _
" p.products_date_available, " & _
" sp.available_from, " & _
" sp.expire_at," & _
" sp.available_backcatalogue_from, " & _
" sp.expire_backcatalogue_at, " & _
" if(t.date_achat between available_from and expire_at,'N',if(t.date_achat between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
" format(t.amount_title,2) price_of_movie_tvac, " & _
" format(format(t.amount_title,2)/ 1.21,2) price_of_movie_htva, " & _
" s.minimum_new_vod, " & _
" s.fee_new_vod, " & _
" s.minimum_back_catalogue, " & _
" s.fee_back_catalogue " & _
" from an_kpn_reports t " & _
" join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id " & _
" join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, s.is_ppv, " & _
" ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  and ( ( t.date_achat between sp.available_from and expire_at ) or (t.date_achat between sp.available_backcatalogue_from and expire_backcatalogue_at))" & _
" left join studio s on s.studio_id = sp.studio_id " & _
" left join studio ps on ps.studio_id = p.products_studio " & _
" left join directors d on d.directors_id = p.products_directors_id " & _
" where sp.is_ppv = 0 and t.in_abcd = 1 and date(t.date_achat) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(t.date_achat) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
allstudio & _
" group by s.studio_name, ps.studio_name, t.id " & _
" order by s.studio_name, ps.studio_name,  p.products_title " & _
" ) x  "

        Return sql

    End Function


    Public Shared Function GetStudioADULTSVODDetailedReport(ByVal dateFrom As String, ByVal dateTo As String, ByVal studio_id As Integer) As String

        '" if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits, " & _
        Dim sql As String
        Dim allstudio As String = String.Empty

        If studio_id <> -1 Then
            allstudio = allstudio & " and s.studio_id = " & studio_id
        End If

        sql = " select  x.vodstudio, x.productstudio, x.products_title, x.customer_id, x.customers_abo_type, x.customers_lastname," & _
 " x.customers_firstname, x.customers_language, x.imdb_id, x.products_type, x.created_at, x.products_date_available, x.available_from, " & _
 " x.expire_at, x.available_backcatalogue_from, x.expire_backcatalogue_at, x.catalogue_type from " & _
" ( " & _
" select " & _
" s.studio_name vodstudio, " & _
" ps.studio_name as productstudio, " & _
" p.products_title, " & _
" t.customer_id,c.customers_abo_type, " & _
" c.customers_lastname, " & _
" c.customers_firstname, " & _
" ( SELECT name FROM languages where languages_id = c.customers_language) as customers_language, " & _
" t.imdb_id, " & _
" p.products_type, " & _
" t.created_at, " & _
" p.products_date_available, " & _
" sp.available_from, " & _
" sp.expire_at," & _
" sp.available_backcatalogue_from, " & _
" sp.expire_backcatalogue_at, " & _
" if(t.created_at between available_from and expire_at,'N',if(t.created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type " & _
" from tokens t " & _
" join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id " & _
" join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
" ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  and ( ( t.created_at between sp.available_from and expire_at ) or (t.created_at between sp.available_backcatalogue_from and expire_backcatalogue_at))" & _
" join customers c on t.customer_id = c.customers_id  " & _
" join customers_svod sv on c.customers_id = sv.customer_id " & _
" left join studio s on s.studio_id = sp.studio_id " & _
" left join studio ps on ps.studio_id = p.products_studio " & _
" left join directors d on d.directors_id = p.products_directors_id " & _
" where t.compensed = 0 and date(t.created_at) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(t.created_at) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
" and t.kind in ('SVOD_ADULT') " & _
allstudio & _
" group by s.studio_name, ps.studio_name, c.customers_id, t.created_at " & _
" order by s.studio_name, ps.studio_name,  p.products_title " & _
" ) x"

        Return sql

    End Function

    Public Shared Function GetSummaryADULTSVODNewReconnduction(ByVal dateFrom As String, ByVal dateTo As String, ByVal studio_id As Integer) As String
        Dim sql As String

        Dim allstudio As String = String.Empty

        If studio_id <> -1 Then
            allstudio = allstudio & " and s.studio_id = " & studio_id
        End If

        sql = "call sp_adult_svod_new_reconduction('" & PlushTools.ClsDate.formatDate(dateFrom) & "', '" & PlushTools.ClsDate.formatDate(dateTo) & "')"

        Return sql
    End Function

    Public Shared Function GetSummaryADULTSVOD(ByVal dateFrom As String, ByVal dateTo As String, ByVal studio_id As Integer) As String
        Dim sql As String

        Dim allstudio As String = String.Empty

        If studio_id <> -1 Then
            allstudio = allstudio & " and s.studio_id = " & studio_id
        End If

        sql = "call sp_adult_svod_summary('" & PlushTools.ClsDate.formatDate(dateFrom) & "', '" & PlushTools.ClsDate.formatDate(dateTo) & "', " & studio_id & ")"

        Return sql
    End Function


    Public Shared Function GetStudioSummaryReport(ByVal dateFrom As String, ByVal dateTo As String, ByVal studio_id As Integer, Optional ByVal isDVDPOST As Boolean = True, Optional ByVal isKPN As Boolean = True) As String
        '
        '"  if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits, " & _
        Dim sql As String

        Dim allstudio As String = String.Empty

        If studio_id <> -1 Then
            allstudio = allstudio & " and s.studio_id = " & studio_id
        End If

        sql = "  select x.vodstudio, x.productstudio, x.products_title, count(x.imdb_id) number_titles, sum(format(x.price_of_movie_tvac,2))  tvac_sum, " & _
        " sum(format(x.price_of_movie_tvac/1.21,2)) htvac_sum, " & _
        " sum(case x.catalogue_type when 'N' then " & _
" format(if(((x.price_of_movie_tvac/1.21) * x.fee_new_vod) < x.minimum_new_vod, x.minimum_new_vod, ((x.price_of_movie_tvac/1.21) * x.fee_new_vod)),2)" & _
" when 'B' then " & _
" format(if((x.price_of_movie_htva * x.fee_back_catalogue) < x.minimum_back_catalogue, x.minimum_back_catalogue, (x.price_of_movie_htva * x.fee_back_catalogue)),2) " & _
" end ) amount_sum , date(sysdate()) date_created, '" & PlushTools.ClsDate.formatDate(dateFrom) & "' period_start , '" & PlushTools.ClsDate.formatDate(dateTo) & "' period_end" & _
" from " & _
" ( "
        Dim sqlDVDPOST As String = "  select 'DVDPOST' source, " & _
"  s.studio_name vodstudio, " & _
"  ps.studio_name as productstudio, " & _
"  p.products_title, " & _
"  t.imdb_id, " & _
"  p.products_type, " & _
"  t.created_at, " & _
"  p.products_date_available, " & _
"  sp.available_from, " & _
"  sp.expire_at, " & _
"  sp.available_backcatalogue_from, " & _
"  sp.expire_backcatalogue_at, " & _
"  if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
"  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at)) qty_credit, " & _
" if(t.is_ppv = 1, t.ppv_price,format((pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * t.credits,2)) price_of_movie_tvac, " & _
" format((((pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * t.credits) / 1.21),2) price_of_movie_htva, " & _
" s.minimum_new_vod, " & _
" s.fee_new_vod, " & _
" s.minimum_back_catalogue, " & _
" s.fee_back_catalogue " & _
"  from tokens t  " & _
"  join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id " & _
 " join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
 " ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  and ( ( t.created_at between sp.available_from and expire_at ) or (t.created_at between sp.available_backcatalogue_from and expire_backcatalogue_at))" & _
 " join customers c on t.customer_id = c.customers_id  join products pabo on pabo.products_id = fn_customers_abopackage(c.customers_id,t.created_at)  " & _
 " join products_abo pa on pabo.products_id = pa.products_id " & _
 " left join studio s on s.studio_id = sp.studio_id " & _
 " left join studio ps on ps.studio_id = p.products_studio " & _
 " left join directors d on d.directors_id = p.products_directors_id " & _
" where t.compensed = 0 and date(t.created_at) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(t.created_at) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
" and t.kind in ('NORMAL','PPV') " & _
allstudio & _
" group by vodstudio, productstudio, c.customers_id, t.created_at "

        Dim sqlKPN As String = " select 'KPN' source, " & _
" s.studio_name vodstudio, " & _
" ps.studio_name as productstudio, " & _
" p.products_title, " & _
" t.imdb_id, " & _
" p.products_type, " & _
" concat(date(t.date_achat),time(t.date_achat)) created_at, " & _
" p.products_date_available, " & _
" sp.available_from, " & _
" sp.expire_at," & _
" sp.available_backcatalogue_from, " & _
" sp.expire_backcatalogue_at, " & _
" if(t.date_achat between available_from and expire_at,'N',if(t.date_achat between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
" 11 qty_credit, " & _
" format(t.amount_title,2) price_of_movie_tvac, " & _
" format(format(t.amount_title,2)/ 1.21,2) price_of_movie_htva, " & _
" s.minimum_new_vod, " & _
" s.fee_new_vod, " & _
" s.minimum_back_catalogue, " & _
" s.fee_back_catalogue " & _
" from an_kpn_reports t " & _
" join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id " & _
" join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, s.is_ppv, " & _
" ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  and ( ( t.date_achat between sp.available_from and expire_at ) or (t.date_achat between sp.available_backcatalogue_from and expire_backcatalogue_at))" & _
" left join studio s on s.studio_id = sp.studio_id " & _
" left join studio ps on ps.studio_id = p.products_studio " & _
" left join directors d on d.directors_id = p.products_directors_id " & _
" where sp.is_ppv = 0 and t.in_abcd = 1 and date(t.date_achat) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(t.date_achat) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
allstudio & _
" group by vodstudio, productstudio, t.id "
        If isDVDPOST Then
            sql = sql & sqlDVDPOST
        End If

        If isDVDPOST And isKPN Then
            sql = sql & " union "
        End If

        If isKPN Then
            sql = sql & sqlKPN
        End If
        sql = sql & " order by vodstudio, productstudio, products_title" & _
" ) x  where x.qty_credit <> 10000 " & _
" group by 1,2,3 "

        Return sql

    End Function

    Public Shared Function GetSABAMDetailedReport(ByVal productsType As String, ByVal dateFrom As String, ByVal dateTo As String) As String
        '" if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits, " & _
        Dim sql As String

        sql = " select  x.vodstudio, x.productstudio, " & _
 " x.customer_id, x.customers_abo_type, " & _
 " (select d.directors_name from directors d where d.directors_id = x.products_directors_id) directors_name , x.imdb_id, x.products_title, x.products_type, x.created_at, x.products_date_available, x.available_from, " & _
 " x.expire_at, x.available_backcatalogue_from, x.expire_backcatalogue_at, x.catalogue_type , x.products_price, x.qty_credit, " & _
 " x.qty_at_home, format(x.price_of_movie_tvac,2) 'Price per film', if( x.products_type = 'DVD_ADULT', '1.00%', '1.38%') 'SABAM%', " & _
 "format((x.price_of_movie_tvac/1.21) * if( x.products_type = 'DVD_ADULT', 0.01, 0.01375),2) 'Sabam Fee' " & _
" from " & _
" ( " & _
" select " & _
" s.studio_name vodstudio, " & _
" ps.studio_name as productstudio, " & _
" p.products_title, " & _
" customer_id,c.customers_abo_type, " & _
"  p.products_directors_id, " & _
" t.imdb_id, " & _
" p.products_type, " & _
" t.created_at, " & _
" p.products_date_available, " & _
" sp.available_from, " & _
" sp.expire_at," & _
" sp.available_backcatalogue_from, " & _
" sp.expire_backcatalogue_at, " & _
" if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
" pabo.products_price, " & _
" if(fn_customers_credit(customers_id, t.created_at) = 0,11, fn_customers_credit(customers_id, t.created_at)) qty_credit, " & _
" pa.qty_at_home, " & _
" t.credits, " & _
" format(if(t.is_ppv = 1, t.ppv_price, (pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11, fn_customers_credit(customers_id, t.created_at))) * t.credits),2) price_of_movie_tvac, " & _
" format((((pabo.products_price /  if( fn_customers_credit(customers_id, t.created_at)=0,11, fn_customers_credit(customers_id, t.created_at))) * t.credits) / 1.21),2) price_of_movie_htva, " & _
" s.minimum_new_vod, " & _
" s.fee_new_vod, " & _
" s.minimum_back_catalogue, " & _
" s.fee_back_catalogue " & _
" from tokens t " & _
" join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products where products_type = '" & productsType & "' group by imdb_id) p on t.imdb_id = p.imdb_id " & _
" join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
" ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  and ( ( t.created_at between sp.available_from and expire_at ) or (t.created_at between sp.available_backcatalogue_from and expire_backcatalogue_at))" & _
" join customers c on t.customer_id = c.customers_id  join products pabo on pabo.products_id = fn_customers_abopackage(c.customers_id,t.created_at)  " & _
" join products_abo pa on pabo.products_id = pa.products_id " & _
" left join studio s on s.studio_id = sp.studio_id " & _
" left join studio ps on ps.studio_id = p.products_studio " & _
" left join directors d on d.directors_id = p.products_directors_id " & _
" where t.compensed = 0 and date(t.created_at) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(t.created_at) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
" and t.kind in ('NORMAL','PPV') " & _
" group by s.studio_name, ps.studio_name, c.customers_id, t.created_at " & _
" order by s.studio_name, ps.studio_name,  p.products_title " & _
" ) x where x.qty_credit <> 10000 "

        Return sql

    End Function

    Public Shared Function GetSABAMSummaryReport(ByVal productsType As String, ByVal dateFrom As String, ByVal dateTo As String) As String
        '"  if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits, " & _
        Dim sql As String

        sql = "select x.products_title, (select d.directors_name from directors d where d.directors_id = x.products_directors_id) directors_name , " & _
        " count(x.imdb_id) 'Nombre de products_title', " & _
        " format(sum((x.price_of_movie_tvac/1.21)),2) 'Somme de Price per film', " & _
        " format(sum((x.price_of_movie_tvac/1.21)) * if( x.products_type = 'DVD_ADULT', 0.01, 0.01375),2) 'Somme de Sabam Fee' " & _
" from " & _
" ( " & _
"  select " & _
"  p.products_title, " & _
"  customer_id,c.customers_abo_type, " & _
"  t.imdb_id, " & _
"  p.products_type, " & _
"  p.products_directors_id, " & _
"  t.created_at, " & _
"  p.products_date_available, " & _
"  sp.available_from, " & _
"  sp.expire_at, " & _
"  sp.available_backcatalogue_from, " & _
"  sp.expire_backcatalogue_at, " & _
"  if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
"  pabo.products_price, " & _
"  if(fn_customers_credit(customers_id, t.created_at)=0,11, fn_customers_credit(customers_id, t.created_at)) qty_credit, " & _
"  pa.qty_at_home, " & _
" t.credits, " & _
" format(if(t.is_ppv = 1, t.ppv_price,(pabo.products_price /  t.credits) * t.credits),2) price_of_movie_tvac, " & _
" format((((pabo.products_price /  if( fn_customers_credit(customers_id, t.created_at)=0,11, fn_customers_credit(customers_id, t.created_at))) * t.credits) / 1.21),2) price_of_movie_htva, " & _
" s.minimum_new_vod, " & _
" s.fee_new_vod, " & _
" s.minimum_back_catalogue, " & _
" s.fee_back_catalogue " & _
"  from tokens t  " & _
"  join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products where products_type = '" & productsType & "' group by imdb_id) p on t.imdb_id = p.imdb_id " & _
 " join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
 " ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  and ( ( t.created_at between sp.available_from and expire_at ) or (t.created_at between sp.available_backcatalogue_from and expire_backcatalogue_at))" & _
 " join customers c on t.customer_id = c.customers_id  join products pabo on pabo.products_id = fn_customers_abopackage(c.customers_id,t.created_at)  " & _
 " join products_abo pa on pabo.products_id = pa.products_id " & _
 " left join studio s on s.studio_id = sp.studio_id " & _
 " left join studio ps on ps.studio_id = p.products_studio " & _
 " left join directors d on d.directors_id = p.products_directors_id " & _
" where t.compensed = 0 and date(t.created_at) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(t.created_at) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
" and t.kind in ('NORMAL','PPV') " & _
" group by s.studio_name, ps.studio_name, c.customers_id, t.created_at " & _
" order by s.studio_name, ps.studio_name,  p.products_title " & _
" ) x  where x.qty_credit <> 10000  " & _
" group by 1,2 "

        Return sql

    End Function
End Class
