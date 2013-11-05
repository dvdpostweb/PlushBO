Public Class ClsStatCustomer

    Public Shared Function GetSelectListSubscription(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " select c.customers_id" & _
              ",customers_gender gender,customers_firstname firstname,customers_lastname lastname,email " & _
              ",customers_telephone telephone ,customers_abo abo,customers_abo_suspended suspended,customers_abo_type abo_type ,customers_next_abo_type next_abo_type " & _
              ",customers_abo_payment_method payment_method,customers_abo_validityto next_reconduction,customers_abo_auto_stop_next_reconduction auto_stop, created_at date_created " & _
              ",customers_language language " & _
              ",ab.entry_street_address street ,ab.entry_postcode postcode,ab.entry_city city,c.customers_newsletter,customers_registration_step step " & _
              " from customers c " & _
              " left join address_book ab on ab.customers_id = c.customers_id and ab.address_book_id = c.customers_default_address_id " & _
              " where date(c.created_at) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(c.created_at) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'"

        Return sql
    End Function


    Public Shared Function GetSelectCustomersStop(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String

        sql = " select date(a.date) date_abostop, c.customers_id id,c.customers_lastname name,c.customers_firstname firstname,c.customers_abo_dvd_credit,c.customers_next_abo_type next_abo,c.customers_abo_type type_abo,c.customers_abo_dvd_norm + c.customers_abo_dvd_adult dvd_abo " & _
               " from abo a " & _
               " join customers c on c.customers_id = a.customerid " & _
               " where date(a.date) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(a.date) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
               " and a.action = " & ClsCustomersData.TypeAction.ACTION_STOP & _
               " order by a.date desc,c.customers_id "
        Return sql

    End Function

    Public Shared Function GetDvdReceivedPerMonth(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String

        sql = " select c.customers_id id,c.customers_lastname name,c.customers_firstname firstname,c.customers_abo_dvd_credit,c.customers_next_abo_type next_abo,c.customers_abo_type type_abo,c.customers_abo_dvd_norm + c.customers_abo_dvd_adult dvd_abo,year(o.date_purchased) y, month(o.date_purchased) m,count(*) nb_dvd_month " & _
               " from customers c " & _
               " join orders o on o.customers_id = c.customers_id " & _
               " where date(date_purchased) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(date_purchased) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
               " group by c.customers_id, year(o.date_purchased),month(o.date_purchased) " & _
               " order by c.customers_abo_dvd_credit desc ,c.customers_id "
        Return sql

    End Function
    Public Shared Function GetSelectProspectCustomers() As String
        Dim sql As String
        sql = "select * from prospects"
        Return sql
    End Function
    Public Shared Function GetListCustomers() As String
        Dim sql As String

        sql = "select c.customers_id id" & _
              ",(select count(*) size_w from wishlist w where w.customers_id = c.customers_id ) size_w" & _
              ",(select count(*) from abo a where a.`action` = " & ClsCustomersData.TypeAction.ACTION_RECONDUCTION & " and a.customerid = c.customers_id) cpt_reconduction " & _
              ",(select count(*) from orders o join orders_products op on o.orders_id = op.orders_id where o.orders_status in (1,2,3) and o.customers_id = c.customers_id) cpt_dvd_sent " & _
              ",(select count(*) from payment p where (payment_status in (19,20,21,22) or last_status_id in (19,20,21,22)) and p.customers_id = c.customers_id ) cpt_payment_recovery " & _
              ",customers_gender gender,customers_firstname firstname,customers_lastname lastname,email email " & _
              ",c.customers_abo_dvd_credit credit,customers_telephone telephone ,customers_abo abo,customers_abo_suspended suspended,customers_abo_type abo_type ,customers_next_abo_type next_abo_type " & _
              ",customers_abo_payment_method payment_method,customers_abo_validityto next_reconduction,customers_abo_auto_stop_next_reconduction auto_stop, customers_info_date_account_created date_created " & _
              ",customers_abo_dvd_norm norm,customers_abo_dvd_adult adult,customers_abo_dvd_home_norm home_norm,customers_abo_dvd_home_adult home_adult,customers_language language " & _
              ",ab.entry_street_address street ,ab.entry_postcode postcode,ab.entry_city city,c.customers_newsletter,customers_registration_step step " & _
              " from customers c " & _
              " left join address_book ab on ab.customers_id = c.customers_id and ab.address_book_id = c.customers_default_address_id "

        Return sql
    End Function
    Public Shared Function getSelectCustServMessagesAnswered(ByVal dateFrom As String, ByVal dateTo As String) As String

        Dim sql As String
        sql = " select datediff(admindate,customer_date) days_elapsed,su.fullname, cv.customers_id,cv.custserv_cat_id,cv.message,cv.customer_date,cv.adminmessage" & _
              " from custserv cv " & _
              " join securityuser su on cv.adminby = su.UserID " & _
              " where customer_date >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and customer_date <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
              " and not adminby in (0,99) and admindate is not null "
        Return sql
    End Function
    Public Shared Function GetCustomersWithNotFinalySubscription(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " select c.customers_id,c.customers_firstname prenom ,c.customers_lastname nom ,date(c.customers_info_date_account_created) date_inscription,c.customers_language ,c.email,customers_telephone,c.activation_discount_code_type,if(c.activation_discount_code_type = 'D',dc.discount_code,ac.activation_code) promo, " & _
                " if(c.activation_discount_code_type = 'D',dc.discount_text_fr,ac.activation_text_fr) description " & _
                " from customers c " & _
                " left join discount_code dc on c.activation_discount_code_id = dc.discount_code_id " & _
                " left join activation_code ac on c.activation_discount_code_id = ac.activation_id " & _
                " where customers_registration_step in (31,33) and date(customers_info_date_account_created) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "'" & _
                " and date(customers_info_date_account_created) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
                " order by date(customers_info_date_account_created) desc "

        Return sql

    End Function
    Public Shared Function GetCustomersWelcomeCall(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " select c.customers_id,c.customers_firstname,c.customers_lastname,c.email,c.customers_telephone,c.customers_info_date_account_created,c.customers_language,c.customers_abo_validityto " & _
              ",(select count(*) from wishlist ww join products p on ww.product_id = p.products_id where ww.customers_id = c.customers_id and p.products_next = 0 and p.products_series_id = 0) nb_dvdNorm " & _
              ",(select count(*) from wishlist ww join products p on ww.product_id = p.products_id where ww.customers_id = c.customers_id and p.products_next = 0 and p.products_series_id > 0) nb_dvdSeries " & _
              ",(select count(*) from wishlist ww join products p on ww.product_id = p.products_id where ww.customers_id = c.customers_id and p.products_next = 1) nb_dvdNext " & _
              " from (select ab.* from abo ab join (select customerid,max(abo_id) abo_id " & _
              " from abo group by customerid ) a on ab.abo_id = a.abo_id) a " & _
              " join customers c on c.customers_id = a.customerid " & _
              " where a.action = " & ClsCustomersData.TypeAction.ACTION_RECONDUCTIONFREE & " and date(customers_info_date_account_created) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "'" & _
              " and date(customers_info_date_account_created) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
              " order by customers_info_date_account_created,customers_language "

        Return sql
    End Function

    Public Shared Function GetSelectEarlierReconduction(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String

        sql = "SELECT month(credit_spent_date), c.customers_id, c.customers_firstname, c.customers_lastname, " & _
                " c.email, customers_telephone, " & _
                " (select products_title from products p where p.products_id = c.customers_next_abo_type) abopackage, " & _
                " c.customers_abo_validityto, " & _
                " nb_days number_of_days_credit_spent_earlier, credit_spent_date, p.customers_abo_validityto earlier_validityto FROM potential_upgrades p join customers c on p.customers_id = c.customers_id where " & _
                " p.credit_spent_date>= '" & PlushTools.ClsDate.formatDate(dateFrom) & "'" & _
                " and date(p.credit_spent_date) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
                " group by 1,2 order by 1, nb_days "

        Return sql

    End Function

    Public Shared Function GetListDVDCustomersNoServed10Days(ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As String
        Dim sql As String

        sql = " select ((xxx.cpt_customers div 10) - qty_dvdOk) qty_purchased ,xxx.* " & _
              " from ( " & _
              " select xx.cpt cpt_customers,(select count(*) from products_dvd pd where products_dvd_status = 1 and pd.products_id = xx.product_id group by pd.products_id) qty_dvdOK , " & _
              " pp.products_id, pp.products_title, pp.imdb_id, pp.products_series_id, pp.products_media, pp.products_date_available, s.studio_name,if(spp.imdb_id is null,0,1) vod  " & _
              " from ( " & _
              " select distinct w.customers_id,count(distinct wish.customers_id) cpt,w.product_id " & _
              " from wishlist w " & _
              " join (select cas.* from customers_aboprocess_stats_new cas " & _
              "               join aboprocess_stats_new ast on ast.aboprocess_id = cas.aboprocess_id " & _
              "               where ast.products_type = " & type_dvd & " and  (date_sub(now(),interval 10 day)) <= date(date_start) and reason = 5 and nbwishlist >= 20 and (dvd_abo - dvd_home) > 0 )  aboprocess on w.customers_id = aboprocess.customers_id " & _
              " join wishlist wish on w.product_id = wish.product_id " & _
              "        where(wish.priority = 1) " & _
              " group by wish.product_id " & _
              " ) xx " & _
              " join products pp on xx.product_id = pp.products_id " & _
              " join studio s on pp.products_studio = s.studio_id " & _
              " left join(select imdb_id from streaming_products sp where available = 1 and expire_at > date(now()) group by imdb_id) spp on spp.imdb_id = pp.imdb_id " & _
              " where pp.products_type = '" & PlushTools.clsEnum.getNameStrEnum(type_dvd) & "' and pp.products_next = 0 " & _
              " ) xxx " & _
              " order by qty_purchased desc "
        Return sql
    End Function

    Public Shared Function GetListAboStopFt(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String

        sql = "select c.customers_id,c.customers_firstname,c.customers_lastname,c.email, " & _
        " c.customers_telephone,c.customers_info_date_account_created,c.customers_language,c.customers_abo_validityto,code.code_type,code.code,last_stop.last_date stop_date " & _
        " from customers c " & _
        " join (select a.customerid,count(*) cpt from abo a where a.`action` = 7 " & _
        "        and a.date >= (select max(date) from abo aa where aa.customerid = a.customerid " & _
        "        and aa.action in (" & ClsCustomersData.TypeAction.ACTION_CREATE & "," & ClsCustomersData.TypeAction.ACTION_FROM_ACTIVATION & "," & ClsCustomersData.TypeAction.ACTION_FROM_DISCOUNT & _
        "      ) group by aa.customerid ) group by a.customerid having count(*) = 1) last_action on last_action.customerid = c.customers_id" & _
        " left join (select a.customerid,if(a.action = " & ClsCustomersData.TypeAction.ACTION_FROM_DISCOUNT & ",'D','A') code_type," & _
        "            if(a.action = " & ClsCustomersData.TypeAction.ACTION_FROM_DISCOUNT & "," & _
        "           (select max(discount_code) from discount_code where discount_code_id = a.code_id)," & _
        "           (select max(activation_code) from activation_code where activation_id = a.code_id)) code from abo a" & _
        "            join  " & _
        "           (select customerid,max(abo_id) abo_id from abo " & _
        "           where action in (" & ClsCustomersData.TypeAction.ACTION_FROM_ACTIVATION & "," & ClsCustomersData.TypeAction.ACTION_FROM_DISCOUNT & ") " & _
        "           group by customerid) lastcode on a.abo_id = lastcode.abo_id ) code on  code.customerid = c.customers_id " & _
        " join (select customerid, max(date) last_date from abo where action = " & ClsCustomersData.TypeAction.ACTION_STOP & " group by customerid) last_stop on last_stop.customerid = c.customers_id  " & _
        " where c.customers_abo = 0 " & _
        " and date(last_stop.last_date) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "'" & _
              " and date(last_stop.last_date) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'"



        'select cpt,c.customers_id,c.customers_firstname,c.customers_lastname,c.customers_email_address,  c.customers_telephone,c.customers_info_date_account_created,c.customers_language,c.customers_abo_validityto,code.code_type,code.code,last_stop.last_date stop_date  from customers c
        'join (select a.customerid,count(*) cpt from abo a where a.`action` = 7 and a.date >= (select max(date) from abo aa where aa.customerid = a.customerid and aa.action in (1,6,8) group by aa.customerid ) group by a.customerid having count(*) = 1) last_action on last_action.customerid = c.customers_id
        'left join (select a.customerid,if(a.action = 6,'D','A') code_type,  if(a.action = 6, (select max(discount_code) from discount_code where discount_code_id = a.code_id),           (select max(activation_code) from activation_code where activation_id = a.code_id)) code from abo a            join             (select customerid,max(abo_id) abo_id from abo            where action in (8,6)            group by customerid) lastcode on a.abo_id = lastcode.abo_id ) code on  code.customerid = c.customers_id  join (select customerid, max(date) last_date from abo where action = 4 group by customerid) last_stop on last_stop.customerid = c.customers_id
        'where c.customers_abo = 0 and date(last_stop.last_date) >= '2010-08-01' and date(last_stop.last_date) <= '2010-12-06'




        Return sql
    End Function
    '    Public Shared Function getStatCreditHistory(ByVal dateFrom As String, ByVal dateTo As String) As String
    '        Dim sql As String


    '        sql = " select customers_id ,customers_abo_dvd_credit, credit_date_from , credit_date_to ," & _
    '  "sum(if(credit_action_id = 1,sum_paid,0)) aboprocess_paid, " & _
    '  "sum(if(credit_action_id = 1,sum_free,0)) aboprocess_free, " & _
    '  "sum(if(credit_action_id = 3,sum_paid,0)) delete_oders_paid, " & _
    '  "sum(if(credit_action_id = 3,sum_free,0)) delete_oders_free, " & _
    '  "sum(if(credit_action_id = 4,sum_free,0)) free_reconduction_free," & _
    '  " sum(if(credit_action_id = 5,sum_paid,0)) reconduction_paid, " & _
    '  "sum(if(credit_action_id = 6,sum_free,0)) free_upgrade, " & _
    '  "sum(if(credit_action_id = 7,sum_paid,0)) init_paid, " & _
    '  " sum(if(credit_action_id = 7,sum_free,0)) init_free," & _
    '  "sum(if(credit_action_id = 8,sum_paid,0)) manual_credit_paid, " & _
    '  "sum(if(credit_action_id = 8,sum_free,0)) manual_credit_free," & _
    '  "sum(if(credit_action_id = 9,sum_paid,0)) promo_combined_paid," & _
    '  "sum(if(credit_action_id = 9,sum_free,0)) promo_combined_free," & _
    '  "sum(if(credit_action_id = 10,sum_paid,0)) kdo_paid," & _
    '  "sum(if(credit_action_id = 10,sum_free,0)) kdo_free," & _
    '  " sum(if(credit_action_id = 11,sum_paid,0)) manual_assign_paid," & _
    ' " sum(if(credit_action_id = 11,sum_free,0)) manual_assign_free " & _
    '        " from " & _
    '"(select c.customers_id , c.customers_abo_dvd_credit , ch3.sum_free , ch3.sum_paid , ch3.credit_date_from , ch3.credit_action_id ,ch3.credit_date_to from customers c" & _
    '        " left join " & _
    '"(select ch.customers_id, ch2.credit_date_from , sum(quantity_free)as sum_free , sum(quantity_paid)as sum_paid , ch.credit_action_id , ch4.credit_date_to  from credit_history ch " & _
    '" join (select customers_id, credit as credit_date_from from credit_history chTmp2 join (select min(id) as id from credit_history where date_added >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date_added <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'  group by customers_id) tmp2 on tmp2.id= chTmp2.id) ch2 on ch2.customers_id=ch.customers_id " & _
    '" join  (select customers_id, (credit+quantity_free+quantity_paid) as credit_date_to from credit_history chTmp3 join (select max(id) as id from credit_history where date_added >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date_added <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'  group by customers_id) tmp3 on tmp3.id= chTmp3.id)ch4 on ch4.customers_id=ch.customers_id " & _
    '" where date_added >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date_added <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' group by ch.customers_id , ch.credit_action_id) ch3 on ch3.customers_id = c.customers_id  where c.customers_abo = 1 ) x group by x.customers_id "

    '        Return sql
    '    End Function
    '' Calcul credit from orders 
    '' ---------------------------
    '        select count(o.orders_id)as nrb_credit ,o.customers_id,
    'customers_name,customers_street_address,customers_city,customers_country
    'from orders o
    'where o.date_purchased>'2010-04-01' and o.date_purchased
    '<'2010-05-01'and customers_id not in
    '(select  o.customers_id from orders o where date_purchased

    '> '2010-04-01' and date_purchased<'2010-05-01' and customers_id in
    '>      
    '(select distinct a1.customerid from abo a1
    'left join abo a2 on a1.customerid=a2.customerid and a2.action=7 and
    'a2.date<'2010-05-01' and a2.date>'2010-01-01'
    'where a1.date<'2010-05-01' and a1.date>'2010-01-01' and a1.action in
    '(1,8,6) and a2.abo_id is null))
    'group by o.customers_id 
    '' -----------------------------

    '' calcul Credit from credit_history
    '' -----------------------------------
    '    select sum(chh_start.credit) total_start, (sum(chh_start.credit) - sum(chh_start.credit_free)) total_start_paid, sum(chh_start.credit_free) total_start_free,
    '       sum(chh_end.credit) + sum(quantity_free) + sum(quantity_paid) total_end, sum(chh_end.credit) - sum(chh_end.credit_free) + sum(quantity_paid) total_end_paid,  sum(chh_end.credit_free) + sum(quantity_free) total_end_free,
    '       sum(chh_consum.quantity_paid_consum) total_credit_paid_consum,sum(chh_consum.quantity_paid_received) total_credit_paid_received,
    '       sum(chh_consum.quantity_free_consum) total_credit_free_consum,sum(chh_consum.quantity_free_received) total_credit_free_received

    'from customers c join (select ch.customers_id,credit,credit_free from credit_history ch
    '                        join (select customers_id, min(id) id from credit_history ch where date(date_added) >= '2010-06-01' and date(date_added) <= '2010-06-31' and credit_action_id <> 8  group by ch.customers_id) xx on xx.id = ch.id) chh_start

    'on c.customers_id = chh_start.customers_id

    'join (select ch.customers_id,credit,credit_free,quantity_free,quantity_paid from credit_history ch
    '                        join (select customers_id, max(id) id from credit_history ch where date(date_added) >= '2010-06-01' and date(date_added) <= '2010-06-31' and credit_action_id <> 8  group by ch.customers_id) xx on xx.id = ch.id) chh_end
    'on c.customers_id = chh_end.customers_id

    'join (select ch.customers_id,(sum(if(quantity_paid < 0,quantity_paid,0))) quantity_paid_consum, (sum(if(quantity_paid > 0,quantity_paid,0))) quantity_paid_received,
    '      (sum(if(quantity_free < 0,quantity_free,0))) quantity_free_consum,(sum(if(quantity_free > 0,quantity_free,0 ))) quantity_free_received
    '      from credit_history ch where date(date_added) >= '2010-06-01' and date(date_added) <= '2010-06-31' and credit_action_id <> 8  group by ch.customers_id) chh_consum
    'on c.customers_id = chh_consum.customers_id;


    'select sum(chh_start.credit) total_start, (sum(chh_start.credit) - sum(chh_start.credit_free)) total_start_paid, sum(chh_start.credit_free) total_start_free,
    '       sum(chh_end.credit) + sum(quantity_free) + sum(quantity_paid) total_end, sum(chh_end.credit) - sum(chh_end.credit_free) + sum(quantity_paid) total_end_paid,  sum(chh_end.credit_free) + sum(quantity_free) total_end_free,
    '       sum(chh_consum.quantity_paid_consum) total_credit_paid_consum,sum(chh_consum.quantity_paid_received) total_credit_paid_received,
    '       sum(chh_consum.quantity_free_consum) total_credit_free_consum,sum(chh_consum.quantity_free_received) total_credit_free_received

    'from customers c join (select ch.customers_id,credit,credit_free from credit_history ch
    '                        join (select customers_id, min(id) id from credit_history ch where date(date_added) >= '2010-06-01' and date(date_added) <= '2010-06-31' and credit_action_id <> 8  group by ch.customers_id) xx on xx.id = ch.id) chh_start

    'on c.customers_id = chh_start.customers_id

    ' ---------------------------------------------------------------------------------------------

    ' Delete Doublon Payment_offline_request
    '    DELETE doublons.*
    'FROM payment_offline_request AS doublons
    'INNER JOIN (
    '   SELECT reason_pk_name,reason_pk_value, MIN(payment_offline_request_id) AS plus_petit_id
    '   FROM payment_offline_request
    '   GROUP BY reason_pk_name,reason_pk_value
    '   HAVING COUNT(*) > 1
    ') AS a_garder
    'ON a_garder.reason_pk_name = doublons.reason_pk_name and a_garder.reason_pk_value = doublons.reason_pk_value
    'AND a_garder.plus_petit_id <> doublons.payment_offline_request_id


    'check qtyathome
    '****************
    '   select * from (

    'select c.customers_id , customers_abo_dvd_home_norm ,  customers_abo_dvd_home_adult , sum(if (products_type= '" & PlushTools.clsEnum.getNameStrEnum(dvdpostdata.clsProductDvd.Type_DVD.DVD_NORM) & "', 1 , 0)) cpt_norm , sum(if (products_type= '" & PlushTools.clsEnum.getNameStrEnum(dvdpostdata.clsProductDvd.Type_DVD.DVD_ADULT) & "', 1 , 0)) cpt_adult  from customers c
    'left join orders o on o.customers_id = c.customers_id and o.orders_status in(1,2)
    'left join orders_products op on op.orders_id = o.orders_id
    'left join products p on p.products_id = op.products_id
    'where c.customers_abo = 1
    'group by c.customers_id ) xx

    'where xx.customers_abo_dvd_home_norm <> cpt_norm or xx.customers_abo_dvd_home_adult <> cpt_adult




    'update qtyathome
    '***************** 'update customers c join ( select * from (

    'select c.customers_id , customers_abo_dvd_home_norm ,  customers_abo_dvd_home_adult , sum(if (products_type= '" & PlushTools.clsEnum.getNameStrEnum(dvdpostdata.clsProductDvd.Type_DVD.DVD_NORM) & "', 1 , 0)) cpt_norm , sum(if (products_type= '" & PlushTools.clsEnum.getNameStrEnum(dvdpostdata.clsProductDvd.Type_DVD.DVD_ADULT) & "', 1 , 0)) cpt_adult  from customers c
    'left join orders o on o.customers_id = c.customers_id and o.orders_status in(1,2)
    'left join orders_products op on op.orders_id = o.orders_id
    'left join products p on p.products_id = op.products_id
    'group by c.customers_id ) xx

    'where xx.customers_abo_dvd_home_norm <> cpt_norm or xx.customers_abo_dvd_home_adult <> cpt_adult)  tmp on tmp.customers_id = c.customers_id

    'set c.customers_abo_dvd_home_norm = tmp.cpt_norm , c.customers_abo_dvd_home_adult = tmp.cpt_adult;




    '    select o.orders_id,o.customers_id,op.products_id , op.products_dvd,o.orders_status
    'from orders o
    'join orders_products op on op.orders_id = o.orders_id
    'join (select tmp.products_id,tmp.products_dvd,max(orders_id)orders_id from orders_products tmp group by tmp.products_id,tmp.products_dvd) xx on xx.products_id = op.products_id and xx.products_dvd = op.products_dvd
    'where o.orders_id <> xx.orders_id and o.orders_status not in (3,9,99);


    '    update
    'orders o
    'join orders_products op on op.orders_id = o.orders_id
    'join (select tmp.products_id,tmp.products_dvd,max(orders_id)orders_id from orders_products tmp group by tmp.products_id,tmp.products_dvd) xx on xx.products_id = op.products_id and xx.products_dvd = op.products_dvd
    'set o.orders_status = 3,o.last_modified = now()
    'where o.orders_id <> xx.orders_id and o.orders_status not in (3,9,99);



    '    select o.orders_id , o.orders_status ,last_orders_history.new_value ,last_orders_history.date_added   from orders o
    '     join
    '       (  select orders_id , new_value , old_value , date_added
    '          from orders_status_history x1
    '          join  (select max(orders_status_history_id) id
    '                from  orders_status_history
    '                group by orders_id) y1 on x1.orders_status_history_id = y1.id
    '       )  last_orders_history on last_orders_history.orders_id = o.orders_id
    '    where last_orders_history.new_value <> o.orders_status ;


    'check Process IN
    '----------------

    '    select orders.products_id,orders.products_dvd,count(*) from
    '(select * from products_dvd_state_history where date(date_added) = date(now()) = type_process = 1 ) xx

    'left join

    '(SELECT * FROM securityuser_log s where date(logdate) = date(now()) and log_type like '%Process IN%') log on xx.products_id = log.products_id and xx.products_dvd_id = log.dvd_id

    'left join (
    'select o.customers_id, op.* from orders o
    'join orders_products op on op.orders_id = o.orders_id
    'where orders_status = 3 and date(last_modified) = date(now())) orders on orders.products_id = xx.products_id and orders.products_dvd = xx.products_dvd_id
    'group by orders.products_id,orders.products_dvd having count(*) > 1
    ';

    ' recensement 
    '----------------
    '    select if(last_action = 17,'FT','PAID') type, postcode,city,customers_gender,age,count(*)
    'from (
    'select 2010 - (year(customers_dob) div 10) * 10 age,upper(ab.entry_city) city,entry_postcode postcode,c.customers_gender,c.customers_email_address,l.name langue,c.customers_telephone,(select a.`action` from abo a where a.`action` in (7,17 ) and a.customerid = c.customers_id order by a.abo_id desc limit 1) last_action
    'from customers c
    'join address_book ab on c.customers_default_address_id = ab.address_book_id and c.customers_id = ab.customers_id
    'join languages l on l.languages_id = c.customers_language
    'where customers_abo = 1 and customers_abo_suspended = 0 ) xx
    'group by last_action,postcode,customers_gender,age;

    ' wishlist customersNoserved
    ' ---------------------------
    '   select xx.cpt cpt_customers,pp.products_id,pp.products_title,pp.imdb_id,pp.products_series_id, (select count(*) from products_dvd pd where products_dvd_status = 1 and pd.products_id = xx.product_id group by pd.products_id) qty_dvdOK from (
    'select distinct w.customers_id,count(distinct wish.customers_id) cpt,w.product_id
    'from wishlist w
    'join (select cas.* from customers_aboprocess_stats cas
    '               join aboprocess_stats ast on ast.aboprocess_id = cas.aboprocess_id
    '               where  (date_sub(now(),interval 10 day)) <= date(date_start) and reason = 5 and nbwishlistnorm >= 20 and (dvd_norm_abo - dvd_norm_home) > 0 )  aboprocess on w.customers_id = aboprocess.customers_id
    'join wishlist wish on w.product_id = wish.product_id
    'where wish.priority = 1
    'group by wish.product_id
    ' ) xx
    'join products pp on xx.product_id = pp.products_id
    'where pp.products_type = '" & PlushTools.clsEnum.getNameStrEnum(dvdpostdata.clsProductDvd.Type_DVD.DVD_NORM) & "' and pp.products_next = 0

    ' size wishlist 
    'select action,size,count(*) from (

    'select if(size_wishlist > 0 and size_wishlist < 6,5,
    '          if (size_wishlist > 5 and size_wishlist < 11,10,
    '              if(size_wishlist > 10 and size_wishlist < 16,15,
    '                 if (size_wishlist > 15 and size_wishlist < 21,20,
    '                     if (size_wishlist > 20,100,0)
    '                  )
    '              )
    '         )
    '       ) size,customers_id,action
    'from (
    'select c.customers_id,lastabo.action,(select count(*) from wishlist w join products p on w.product_id = p.products_id where p.products_next = 0 and w.wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(dvdpostdata.clsProductDvd.Type_DVD.DVD_NORM) & "' and w.customers_id = c.customers_id group by w.customers_id) size_wishlist from customers c
    ' join (select customerid,max(abo_id) abo_id,action from abo where Action in(7,17) and date(date) >= '2010-12-13' and date(date) <= '2010-12-20' group by customerid) lastabo
    '         on lastabo.customerid = c.customers_id

    'where c.customers_abo = 1 and c.customers_abo_suspended = 0
    ') xx

    ') xxx group by action,size
End Class
