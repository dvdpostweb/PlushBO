Public Class ClsStatPayment
    Public Enum credit_action

        ABOPROCESS = 1
        PROCESSIN = 2
        DELETEORDER = 3
        FREERECONDUCTION = 4
        RECONDUCTION = 5
        FREEUPGRADE = 6
        INIT = 7
        MANUAL_CREDIT = 8
        PROMO_COMBINED = 9
        KDO = 10
        MANUAL_ASSIGN = 11
    End Enum

   
    Public Shared Function getSelectCustPaidWithOgone(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        ' one table 
        sql = "SELECT c.customers_id, entry_firstname, entry_lastname,p.payment_status,c.customers_abo_type," & _
        " entry_street_address, entry_postcode, entry_city, p.last_modified," & _
        " p.date_added, p.amount, qty_credit,p.payment_status,p.account_movements_id,c.customers_abo " & _
        " FROM payment p " & _
        " JOIN customers c ON p.customers_id = c.customers_id" & _
        " Left Join abo  on abo.abo_id = p.abo_id" & _
        " JOIN products_abo pa ON pa.products_id = if(abo.product_id>0," & _
        " abo.product_id,c.customers_abo_type)" & _
        " LEFT JOIN address_book a ON a.customers_id = c.customers_id AND address_book_id = c.customers_default_address_id" & _
        " WHERE p.last_modified > '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and p.last_modified < '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
        " AND p.payment_status" & _
        " IN ( " & PaymentOfflineData.GetListPaid() & " )" & _
        " and p.payment_method = " & ClsCustomersData.Payment_Method.OGONE

        Return sql
    End Function

    Public Shared Function getSelectCustPaidWithDomiciliation(ByVal dateFrom As String, ByVal dateTo As String) As String

        Dim sql As String

        sql = " SELECT c.customers_id,c.customers_abo_type," & _
        " entry_firstname,entry_lastname,entry_street_address,entry_postcode,entry_city," & _
        "last_modified, amount, qty_credit, p.account_movements_id,p.date_added,p.payment_status " & _
        " FROM payment p " & _
        " JOIN customers c ON c.customers_id = p.customers_id " & _
        " left join abo  on abo.abo_id = p.abo_id " & _
        " JOIN products_abo pa ON pa.products_id = if(abo.product_id>0," & _
        " abo.product_id,c.customers_abo_type)" & _
        " LEFT JOIN address_book a ON a.customers_id = c.customers_id AND " & _
        " address_book_id = c.customers_default_address_id " & _
         " WHERE last_modified > '" & PlushTools.ClsDate.formatDate(dateFrom) & "' " & _
         " AND last_modified < '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
         " AND p.payment_status " & _
         " IN ( " & PaymentOfflineData.GetListPaid() & " ) " & _
         " and p.payment_method = " & ClsCustomersData.Payment_Method.DOMICILIATION

        Return sql
    End Function

    Public Shared Function getSelectCustPaidWithBankTransfer(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String


        sql = "select c.customers_id,c.customers_abo_type,entry_firstname,entry_lastname,entry_street_address,entry_postcode,entry_city," & _
                " last_modified,amount, qty_credit,p.date_added,p.payment_status,p.account_movements_id " & _
                " from payment p" & _
                " join customers c on c.customers_id = p.customers_id" & _
                " left join products_abo pa on pa.products_id =(select product_id from abo" & _
                " where customerid=c.customers_id and date(date_added)=date(date) and" & _
                "  Action = " & ClsCustomersData.TypeAction.ACTION_RECONDUCTION & "  limit 1) " & _
                " left join address_book a on a.customers_id = c.customers_id and " & _
                " address_book_id = c.customers_default_address_id" & _
                " where last_modified > '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and last_modified < '" & PlushTools.ClsDate.formatDate(dateTo) & "' and " & _
                " p.payment_status in (" & PaymentOfflineData.GetListPaid() & ") and p.payment_method = " & ClsCustomersData.Payment_Method.VIREMENT

        Return sql

    End Function

    Public Shared Function getSelectCustUnPaidWithOgone(ByVal dateFrom As String, ByVal dateTo As String) As String

        Dim sql As String
        ' one table 
        sql = " SELECT c.customers_id,c.customers_abo_type, entry_firstname, entry_lastname,p.payment_status, " & _
        " entry_street_address, entry_postcode, entry_city, p.last_modified," & _
        " p.date_added,p.amount,qty_credit" & _
        " FROM payment p " & _
        " JOIN customers c ON p.customers_id = c.customers_id" & _
        " left join abo  on abo.abo_id = p.abo_id" & _
        " JOIN products_abo pa ON pa.products_id = if(abo.product_id>0,abo.product_id,c.customers_abo_type)" & _
        " LEFT JOIN address_book a ON a.customers_id = c.customers_id AND address_book_id =c.customers_default_address_id" & _
        " where date(p.date_added) <= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and ((date(p.last_modified) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "'" & _
        " and p.payment_status in (" & PaymentOfflineData.GetListClose() & "))" & _
        "                                                 or (not p.payment_status in  (" & PaymentOfflineData.GetListClose() & ")))" & _
        " and p.payment_method = " & ClsCustomersData.Payment_Method.OGONE

        Return sql
    End Function

    Public Shared Function getSelectCustCancelWithOgone(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String

        ' one table 

        sql = "    SELECT c.customers_id,c.customers_abo_type, entry_firstname, entry_lastname,p.payment_status," & _
        " entry_street_address, entry_postcode, entry_city, p.last_modified," & _
        " p.date_added,p.amount,qty_credit" & _
        " from payment p" & _
        " JOIN customers c ON p.customers_id = c.customers_id" & _
        " left join abo  on abo.abo_id = p.abo_id" & _
        " JOIN products_abo pa ON pa.products_id = if(abo.product_id>0," & _
        " abo.product_id,c.customers_abo_type)" & _
        " LEFT JOIN address_book a ON a.customers_id = c.customers_id AND" & _
        " address_book_id =c.customers_default_address_id" & _
        " where date(p.last_modified)  >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(p.last_modified)  < '" & PlushTools.ClsDate.formatDate(dateTo) & "' and p.payment_status = " & PaymentOfflineData.StepPayment.CANCEL & _
        " and p.payment_method = " & ClsCustomersData.Payment_Method.OGONE

        Return sql
    End Function

    Public Shared Function getSelectDroseliaSale(ByVal dateFrom As String, ByVal dateTo As String) As String


        Dim sql As String

        sql = " SELECT s.date date_purchased, dc.used_date,c.customers_id, c.customers_abo_type,entry_firstname, entry_lastname,entry_street_address, entry_postcode, entry_city,price,products_type,dc.catalog_id,dcs.name title" & _
        " FROM droselia_codes dc " & _
        " left join droselia_catalog_stream dcs on dc.catalog_id = dcs.catalog_id " & _
        " join shopping_orders s on dc.customers_id = s.customers_id and dc.buy_date = s.date" & _
        " join customers c on c.customers_id = s.customers_id " & _
        " LEFT JOIN address_book a ON a.customers_id = c.customers_id AND address_book_id =c.customers_default_address_id" & _
        " where date(dc.used_date) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and  date(dc.used_date) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
        " order by s.date "
        Return sql
    End Function

    Public Shared Function getSelectorders(ByVal dateFrom As String, ByVal dateTo As String) As String


        Dim sql As String

        sql = " SELECT c.customers_id,c.customers_abo_type, entry_firstname, entry_lastname,entry_street_address, entry_postcode, entry_city, date,price,products_type" & _
        " FROM shopping_orders s " & _
        " join customers c on c.customers_id = s.customers_id " & _
        " LEFT JOIN address_book a ON a.customers_id = c.customers_id AND address_book_id =c.customers_default_address_id" & _
        " where date >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and  date <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' order by date "

        Return sql
    End Function
    Public Shared Function getSelectUnUsedCredit() As String

        Dim sql As String

        sql = "select date(now()) today ,count(1) nb_creditUnused from customers where customers_abo = 1 "
        Return sql
    End Function
    Private Shared Function GetStatBaseCustomersCreditHistory(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = "    select c.customers_id,c.customers_abo_type,c.customers_abo_suspended, sum(chh_start.credit_paid) total_start, (sum(chh_start.credit_paid) - sum(chh_start.credit_free)) total_start_paid, sum(chh_start.credit_free) total_start_free," & _
       "sum(chh_end.credit_paid) + sum(quantity_free) + sum(quantity_paid) total_end, sum(chh_end.credit_paid) - sum(chh_end.credit_free) + sum(quantity_paid) total_end_paid,  sum(chh_end.credit_free) + sum(quantity_free) total_end_free, " & _
       "sum(chh_consum.quantity_paid_consum) total_credit_paid_consum,sum(chh_consum.quantity_paid_received) total_credit_paid_received, " & _
       "sum(chh_consum.quantity_free_consum) total_credit_free_consum,sum(chh_consum.quantity_free_received) total_credit_free_received,c.customers_abo_dvd_credit credit_current  " & _
"from customers c left join (select ch.customers_id,credit_paid,credit_free from credit_history ch" & _
"                        join (select customers_id, min(id) id from credit_history ch where date(date_added) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(date_added) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' and credit_action_id <>  " & credit_action.MANUAL_CREDIT & "  group by ch.customers_id) xx on xx.id = ch.id) chh_start " & _
" on c.customers_id = chh_start.customers_id " & _
" left join (select ch.customers_id,credit_paid,credit_free,quantity_free,quantity_paid from credit_history ch " & _
"                        join (select customers_id, max(id) id from credit_history ch where date(date_added) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(date_added) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' and credit_action_id <>  " & credit_action.MANUAL_CREDIT & "  group by ch.customers_id) xx on xx.id = ch.id) chh_end " & _
" on c.customers_id = chh_end.customers_id " & _
" left join (select ch.customers_id,(sum(if(quantity_paid < 0,quantity_paid,0))) quantity_paid_consum, (sum(if(quantity_paid > 0,quantity_paid,0))) quantity_paid_received, " & _
"     (sum(if(quantity_free < 0,quantity_free,0))) quantity_free_consum,(sum(if(quantity_free > 0,quantity_free,0 ))) quantity_free_received " & _
"      from credit_history ch where date(date_added) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(date_added) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' and credit_action_id <> " & credit_action.MANUAL_CREDIT & "  group by ch.customers_id) chh_consum " & _
" on c.customers_id = chh_consum.customers_id "

        Return sql
    End Function
    Public Shared Function GetStatCustomersStopCreditHistory(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String

        sql = "    select c.customers_id,c.customers_abo_type,c.customers_abo_suspended, sum(chh_start.credit_paid) total_start, (sum(chh_start.credit_paid) - sum(chh_start.credit_free)) total_start_paid, sum(chh_start.credit_free) total_start_free," & _
      "sum(chh_end.credit_paid) + sum(quantity_free) + sum(quantity_paid) total_end, sum(chh_end.credit_paid) - sum(chh_end.credit_free) + sum(quantity_paid) total_end_paid,  sum(chh_end.credit_free) + sum(quantity_free) total_end_free, " & _
      "sum(chh_consum.quantity_paid_consum) total_credit_paid_consum,sum(chh_consum.quantity_paid_received) total_credit_paid_received, " & _
      "sum(chh_consum.quantity_free_consum) total_credit_free_consum,sum(chh_consum.quantity_free_received) total_credit_free_received,c.customers_abo_dvd_credit credit_current  " & _
"from (select c.* from customers c join customers_abo_stop cas on c.customers_id = cas.customers_id where date(date_stop) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(date_stop) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "') c left join (select ch.customers_id,credit_paid,credit_free from credit_history ch" & _
"                        join (select customers_id, min(id) id from credit_history ch where date(date_added) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(date_added) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' and credit_action_id <>  " & credit_action.MANUAL_CREDIT & "  group by ch.customers_id) xx on xx.id = ch.id) chh_start " & _
" on c.customers_id = chh_start.customers_id " & _
" left join (select ch.customers_id,credit_paid,credit_free,quantity_free,quantity_paid from credit_history ch " & _
"                        join (select customers_id, max(id) id from credit_history ch where date(date_added) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(date_added) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' and credit_action_id <>  " & credit_action.MANUAL_CREDIT & "  group by ch.customers_id) xx on xx.id = ch.id) chh_end " & _
" on c.customers_id = chh_end.customers_id " & _
" left join (select ch.customers_id,(sum(if(quantity_paid < 0,quantity_paid,0))) quantity_paid_consum, (sum(if(quantity_paid > 0,quantity_paid,0))) quantity_paid_received, " & _
"     (sum(if(quantity_free < 0,quantity_free,0))) quantity_free_consum,(sum(if(quantity_free > 0,quantity_free,0 ))) quantity_free_received " & _
"      from credit_history ch where date(date_added) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(date_added) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' and credit_action_id <> " & credit_action.MANUAL_CREDIT & "  group by ch.customers_id) chh_consum " & _
" on c.customers_id = chh_consum.customers_id " & _
" group by c.customers_id "
        Return sql
    End Function

    Public Shared Function GetStatCustomersOgone(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        ' ogone_payment -> payment 
        sql = " select date(p.date_added),ps.name,count(*) " & _
              " from payment p " & _
              " join payment_status ps on p.payment_status = ps.id " & _
              " where date(p.date_added) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "'" & _
              " and date(p.date_added) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
              " and p.payment_method = " & ClsCustomersData.Payment_Method.OGONE & _
              " group by ps.name,date(p.date_added) order by date(p.date_added) "
        Return sql
    End Function
    Public Shared Function GetStatCustomersDomiciliation(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String

        ' domiciliation_payment -> payment

        sql = " select date(last_modified),ps.name,count(*) " & _
              " from payment p " & _
              " join payment_status ps on p.payment_status = ps.id " & _
              " where date(last_modified) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "'" & _
              " and date(last_modified) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
               " and payment_method = " & ClsCustomersData.Payment_Method.DOMICILIATION & _
              " group by ps.name,date(p.last_modified) order by date(last_modified) "
        Return sql
    End Function

    Public Shared Function GetStatCustomersBankTransfer(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        ' bank_transfer -> payment
        sql = " select date(last_modified),ps.name,count(*) " & _
              " from payment p " & _
              " join payment_status ps on p.payment_status = ps.id " & _
              " where date(p.last_modified) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "'" & _
              " and date(p.last_modified) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
              " and p.payment_method = " & ClsCustomersData.Payment_Method.VIREMENT & _
              " group by ps.name,date(last_modified) order by date(last_modified); "
        Return sql
    End Function

    Public Shared Function GetStatCustomersCreditHistory(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = GetStatBaseCustomersCreditHistory(dateFrom, dateTo) & " group by c.customers_id "

        Return sql
    End Function

    Public Shared Function GetViewVodHistorique(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String

        sql = " select s.studio_name vodstudio, ps.studio_name as productstudio, customer_id,c.customers_abo_type,c.customers_lastname,c.customers_firstname, ( SELECT name FROM languages where languages_id = c.customers_language) as customers_language, t.imdb_id,p.products_title, p.products_type, t.compensed, t.created_at,p.products_date_available,sp.available_from,sp.expire_at, sp.available_backcatalogue_from, sp.expire_backcatalogue_at,  pabo.products_price,pa.qty_credit,pa.qty_at_home,d.directors_name " & _
              " from tokens t join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id " & _
              " join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s group by s.imdb_id) sp on p.imdb_id = sp.imdb_id " & _
              " join customers c on t.customer_id = c.customers_id " & _
              " join products pabo on pabo.products_id = c.customers_abo_type " & _
              " join products_abo pa on pabo.products_id = pa.products_id " & _
              " left join studio s on s.studio_id = sp.studio_id " & _
              " left join studio ps on ps.studio_id = p.products_studio " & _
              " left join directors d on d.directors_id = p.products_directors_id " & _
              " where date(t.created_at) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(t.created_at) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
              " order by customer_id "

        Return sql
    End Function

    Public Shared Function GetViewCustomersLostMoreMonth(ByVal dateFrom As String, ByVal dateTo As String) As String

        Dim sql As String

        sql = " select ch.date_added date_lost,c.customers_id,c.customers_abo_type,c.customers_lastname,c.customers_firstname,c.customers_info_date_account_created abo_created,c.customers_abo " & _
              " from credit_history ch " & _
              " join customers c on ch.customers_id = c.customers_id " & _
              " where ch.credit_action_id = " & clsCreditHistory.ActionId.LONGTIME_DVD & _
              " and date(ch.date_added) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "'" & _
              " and date(ch.date_added) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'"

        Return sql
    End Function

    Public Shared Function GetViewStatVod(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String

        sql = " select * from stat_vod where date(created_at) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "'" & _
              " and date(created_at) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'"

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
End Class
