
Public Class ClsCustomersData
    Public Const CODE_DISCOUNT As String = "D"
    Public Const CODE_ACTIVATION As String = "A"

#Region "enum"

    Public Enum PPVREADY
        NOCREDITCARD = 0
        PPVENABLED = 1
        PPVDISABLED = 2
    End Enum

    Public Enum Wishlist_Source
        CANCELORDER = 1
    End Enum
    Public Enum Role
        ADMINISTRATOR = 1
        LOGISTIC = 2
        CUSTOMER_SERVICE = 3
        SALER = 4
        PURCHASE = 5
        MANAGER = 7
        MARKETING = 8
    End Enum
    Public Enum discountCode
        WINTER_POWER = 750
        SUMMER_POWER = 662
    End Enum


    Public Enum abo
        VALID = 1
        UNVALID = 0
    End Enum
    Public Enum Country
        BELGIUM = 1
        NEDERLANDS = 38
        LUXEMBOURG
    End Enum

    Public Enum priority
        HIGH = 1
        MEDIUM = 2
        LOW = 3
    End Enum

    Public Enum Suspended
        OK = 0
        HOLIDAY = 1
        RECONDUCTION = 2
    End Enum


    Public Enum discount_code

        REDUCTION_PERCENT = 1
        AMOUNT = 2
        REDUCTION_VALUE = 3

    End Enum

    Public Enum Abo_status
        OK = 0
        RECONDUCTION = 4
    End Enum

    Public Enum Activation_code

        DAYS = 1
        MONTH = 2
        YEAR = 3

    End Enum

    Public Enum Payment_Method
        OGONE = 1
        DOMICILIATION = 2
        '  KDO = 4
        '  PHONE = 20
        '  SMS = 21
        VIREMENT = 3
        PAYPAL = 4
        '  BANK_TRANSFER = 0
    End Enum

    Public Enum TypePaymentCommunication
        OGONE = 3
        DOMICILIATION = 2
        PHONE = 5
        SMS = 6
        VIREMENT = 7
        PAYPAL = 4
    End Enum

    Public Enum TypeAction
        ACTION_CREATE = 1
        ACTION_DOWNGRADE_ID = 3
        ACTION_RECONDUCTION = 7
        ACTION_RECONDUCTIONFREE = 17
        ACTION_STOP = 4
        ACTION_UPGRADE = 2
        ACTION_FROM_DISCOUNT = 6
        ACTION_FROM_ACTIVATION = 8
        ACTION_CHANGCARD = 18
        ACTION_RECONDUCTION_ADULT_SVOD = 33
        ACTION_RECONDUCTION_STOP_ADULT_SVOD = 34
        ACTION_REQUEST_OF_ABO_DOWNGRADE = 25
    End Enum

    Public Enum DomiciliationStatus

        CREATE = 0
        RETRIEVELETTER = 2
        DOWNLOADED = 6
        SENDLETTER = 7
        SENT = 8
        OK = 3

    End Enum

    Public Enum StepRegistrationStatus
        CREATE_DOMICILIATION = 70
        RECEIVED_DOMICILIATION = 75
        OK = 100

    End Enum
    Public Enum AboStopReason
        AUTOSTOP = 29
        RECOVERY = 31
    End Enum

    Public Enum Language
        FR = 1
        NL = 2
        EN = 3
    End Enum

    Public Enum RedBlackListed
        BLACKLISTED = 0
        REDLISTED = 1
    End Enum

    Public Enum OrdersType
        ABOPROCESS
        MANUAL
    End Enum
    Public Enum WhereDVD
        [IN] = 1
        [OUT] = 0
    End Enum

#End Region
#Region "select"

    Public Shared Function GetSelectInfoAttributesCustomer(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "select * from customer_attributes where customer_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetCustEmailDiego() As String
        Dim sql As String

        sql = " select mmsh.cpt nb_mail,w.size, c.customers_id id,customers_gender gender,customers_firstname firstname,customers_lastname lastname,customers_email_address email" & _
"              ,customers_telephone telephone ,customers_abo abo,customers_abo_suspended suspended,customers_abo_type abo_type ,customers_next_abo_type next_abo_type" & _
"              ,customers_abo_payment_method payment_method,customers_abo_validityto next_reconduction,customers_abo_auto_stop_next_reconduction auto_stop, customers_info_date_account_created date_created" & _
"              ,customers_abo_dvd_norm norm,customers_abo_dvd_adult adult,customers_abo_dvd_home_norm home_norm,customers_abo_dvd_home_adult home_adult,customers_language language" & _
"               from customers c " & _
" join (select customers_id,count(*) cpt from mail_messages_sent_history where mail_messages_id = 452 group by customers_id) mmsh on mmsh.customers_id = c.customers_id " & _
" join (select customers_id,count(*) size from wishlist group by customers_id) w on w.customers_id = c.customers_id " & _
" where c.customers_abo = 1 and c.customers_abo_suspended = 1 and size < 10 and mmsh.cpt > 1 " & _
" order by mmsh.cpt desc "
        Return sql
    End Function
    Public Shared Function getSelectInfoWishlist(ByVal customers_id As Integer, ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As String
        Dim sql As String
        sql = " select 'CLASSIQUE' type_" & PlushTools.clsEnum.getNameStrEnum(type_dvd) & ",count(*)DVD " & _
               " from wishlist w join products p on w.product_id = p.products_id " & _
               " where customers_id = " & customers_id & " and products_series_id = 0 and products_next = 0 and p.products_availability in (-2,1) and wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(type_dvd) & "' " & _
        "union" & _
              " select 'SERIE' type_" & PlushTools.clsEnum.getNameStrEnum(type_dvd) & ",count(distinct imdb_id_serie) DVD " & _
              " from wishlist w join products p on w.product_id = p.products_id " & _
              " where customers_id = " & customers_id & " and p.imdb_id_serie > 0 and products_series_id > 0 and products_next = 0 and p.products_availability in (-2,1) and wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(type_dvd) & "' " & _
        " union " & _
              " select 'NEXT' type_" & PlushTools.clsEnum.getNameStrEnum(type_dvd) & ",count(*) DVD " & _
              " from wishlist w join products p on w.product_id = p.products_id " & _
              " where customers_id = " & customers_id & " and products_next = 1 and wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(type_dvd) & "' " & _
        " union " & _
              " select 'No OK' type_" & PlushTools.clsEnum.getNameStrEnum(type_dvd) & ",count(*) DVD " & _
               " from wishlist w join products p on w.product_id = p.products_id " & _
               " where customers_id = " & customers_id & " and products_next = 0 and p.products_availability in (-1,0) and  wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(type_dvd) & "' "

        Return sql

    End Function
    Public Shared Function getAboStopDebug() As String
        Dim sql As String
        sql = "select cProd.customers_next_abo_type, ps.name payment_status,p.cpt nb_payment_open,o.cpt dvd_sent,cProd.customers_id,cProd.customers_info_date_account_created ,cProd.customers_firstname,cProd.customers_lastname,cProd.customers_language,ab.entry_street_address,ab.entry_postcode,ab.entry_city,cProd.customers_email_address,cProd.customers_telephone,cProd.customers_abo_payment_method " & _
              " from dvdpost_test.customers cTest" & _
              " join dvdpost_be_prod.customers cProd on cTest.customers_id = cProd.customers_id" & _
              " join dvdpost_be_prod.address_book ab on cProd.customers_id = ab.customers_id and ab.address_book_id = cProd.customers_default_address_id" & _
              " join (select customers_id,count(*) cpt from dvdpost_test.payment where date_added < '2010-01-01' and payment_status in (13,14,15,16,17,10,11,12,19,20,21,22) group by customers_id having count(*) > 1) p" & _
              " on p.customers_id = cProd.customers_id" & _
              " left join (select customers_id,count(*) cpt from dvdpost_be_prod.orders o where o.date_purchased > '2011-01-01' and o.orders_status in (1,2)  group by customers_id having count(*) > 0) o" & _
              " on o.customers_id = cProd.customers_id" & _
              " join dvdpost_be_prod.payment pp on pp.customers_id = cProd.customers_id" & _
              " join dvdpost_be_prod.payment_status ps on ps.id = pp.payment_status" & _
              " where cTest.customers_abo_suspended = 2 and cProd.customers_abo_suspended = 0 and cProd.customers_info_date_account_created < '2010-01-01' and pp.date_added > '2011-01-01'" & _
              " order by p.cpt desc"

        Return sql

    End Function
    Public Shared Function GetAboType() As String
        Dim sql As String

        sql = " select products_id,name,description, price, packages_ids, package_count from products_abo "
        Return sql

    End Function

    Public Shared Function GetAboPackage_PackageCount(ByVal products_id) As String
        Dim sql As String

        sql = " select package_count from products_abo where products_id = " & products_id
        Return sql

    End Function

    Public Shared Function GetPriceAbo(ByVal products_id As Integer) As String
        Dim sql As String
        sql = "select products_price from products p where products_id = " & products_id
        Return sql
    End Function
    Public Shared Function GetLastReconductionCredityHistory() As String
        Dim sql As String
        sql = " select ch.* from credit_history ch join " & _
              " (select customers_id,max(id) id from credit_history where credit_action_id in (4,5) group by customers_id) max_credit " & _
              " on ch.customers_id = max_credit.customers_id and ch.id >= max_credit.id " & _
              " order by ch.customers_id,ch.id "
        Return sql
    End Function
    Public Shared Function getSelectAttributes(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = " select * from customer_attributes a where a.customer_id = " & customers_id
        Return sql
    End Function
    Public Shared Function getSelectSVOD(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = " select * from customers_svod sv where sv.customer_id = " & customers_id
        Return sql
    End Function

    Public Shared Function getSelectAboHistory(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = " select aa.name Action, a.* from abo a left join abo_action aa on a.action = aa.id where a.customerid = " & customers_id & _
              " order by a.Date desc"
        Return sql
    End Function

    Public Shared Function GetSelectRolesUser() As String
        Dim sql As String
        sql = "select * from securityuser_role where userid = " & clsSession.user_id
        Return sql
    End Function
    Public Shared Function getSelectWishlistSize() As String
        Dim sql As String
        '" join (" & GetSelectIsFreeTrial() & ") last_abo on last_abo.customers_id = c.customers_id " & _

        sql = "  select  w.cpt wl_size,c.customers_abo_suspended suspended,c.customers_info_date_account_created date_created, c.customers_id,c.customers_lastname,c.customers_firstname,c.customers_email_address,c.customers_telephone,c.customers_language from customers c " & _
               " left join (select customers_id,count(*) cpt from wishlist w group by customers_id) w on c.customers_id = w.customers_id " & _
               " where c.customers_abo = 1 " & _
               " order by w.cpt,c.customers_info_date_account_created desc "

        Return sql
    End Function
    Public Shared Function GetSelectWishlistWithfirstPerSerie(ByVal customers_id As Integer, ByVal product_type As String, ByVal imdb_id As Integer) As String
        Dim sql As String

        Dim restriction_imdb As String = ""

        If imdb_id > 0 Then
            restriction_imdb = "and p.imdb_id <> " & imdb_id
        End If
        sql = " select w.wishlist_type, pdv.products_id ,pdes.products_name products_title , pdv.products_dvdid,pdv.box_id ,pdv.pibox_id " & _
               " from wishlist w " & _
               " join ( " & _
               "      select product_id from wishlist w " & _
               "      join products p on w.product_id = p.products_id " & _
               "      where(customers_id = " & customers_id & " And p.imdb_id = 0) " & _
               "     union " & _
               " select products_id from ( " & _
               "            select p.products_id,p.imdb_id,p.products_series_id,min(p.products_series_number) products_series_number" & _
               "            from wishlist w " & _
               "            join products p on w.product_id = p.products_id " & _
               "            where(customers_id = " & customers_id & " And p.imdb_id > 0) " & _
                restriction_imdb & _
               "            group by p.imdb_id,p.products_series_id " & _
               "          ) xx " & _
               " group by xx.imdb_id " & _
               " ) xxx on w.product_id = xxx.product_id " & _
               " join products_dvd pdv on w.product_id = pdv.products_id " & _
               " join products_description pdes on  w.product_id = pdes.products_id" & _
               " where pdv.products_dvd_status = 1 and pdv.`inout` = 1" & _
               "       and w.wishlist_type = '" & product_type & "'" & _
               "       and pdv.pibox_id > 0 and w.customers_id = " & customers_id & _
               "       group by w.product_id " & _
               "       order by wishlist_type asc "

        Return sql
    End Function
    Public Shared Function getCustomersKeepLongtimeDVD() As String
        Dim sql As String
        sql = " select * from ( " & _
              "           select datediff(date(now()),date(date_purchased)) mod 31 exact_month,o.customers_id ,date_purchased,products_model," & _
              "                  op.products_id,op.products_dvd " & _
              "           from orders o " & _
              "           join orders_products op on o.orders_id = op.orders_id " & _
              "           where o.orders_status = " & PlushData.clsOdersStatusHistory.OrderStatusNew.EXPEDITED & " and date(date_purchased) < date(now()) " & _
              "         ) xx " & _
              " join customers c on xx.customers_id = c.customers_id " & _
              " where(exact_month = 0 And c.customers_abo = " & abo.VALID & ") "

        Return sql
    End Function
    Public Shared Function GetSelectWishlistAssigned(ByVal customers_id As Integer, ByVal lang_id As Integer) As String
        Dim sql As String

        sql = "select if(order_check.products_id is not null,1,0) order_check ,ws.name source_added,wa.*,p.*,pd.products_name as products_title_description " & _
        " from  wishlist_assigned wa join products p on wa.products_id = p.products_id " & _
        " LEFT JOIN products_description pd on pd.products_id = wa.products_id and pd.language_id = " & lang_id & _
        " left join (select op.products_id from orders o join orders_products op on o.orders_id = op.orders_id " & _
        "            where o.customers_id = " & customers_id & " and o.orders_status = " & clsOdersStatusHistory.OrderStatusNew.CHECK & ") order_check " & _
        " on order_check.products_id = p.products_id " & _
        " left join wishlist_sources ws on wa.wishlist_source_id = ws.id " & _
        " where wa.customers_id = " & customers_id & " order by wa.date_added desc "

        Return sql
    End Function
    Public Shared Function GetSelectWishlist(ByVal customers_id As Integer, ByVal lang_id As Integer) As String
        Dim sql As String

        sql = "select ws.name source_added, w.*,p.*,pd.products_name as products_title_description,pgroup.* from wishlist w join products p on w.product_id = p.products_id " & _
        " LEFT JOIN products_description pd on pd.products_id = w.product_id and pd.language_id = " & lang_id & _
        " left join (select products_id,count(*) qty_in_stock from products_dvd where products_dvd_status = 1 and `inout` = 1 group by products_id )" & _
        " pgroup on pgroup.products_id = p.products_id " & _
        " left join wishlist_sources ws on w.wishlist_source_id = ws.id " & _
        " where w.customers_id = " & customers_id & " order by w.date_added desc "

        Return sql
    End Function
    Public Shared Function GetSelectDetailsProducts(ByVal products_id As Integer, ByVal lang_id As Integer) As String
        Dim sql As String

        sql = " select pd.products_name,pd.products_description,pa.qty_credit,p.products_price,pa.qty_at_home " & _
              " from products p join products_abo pa on p.products_id = pa.products_id " & _
              " join products_description pd on p.products_id = pd.products_id " & _
              " where p.products_id = " & products_id & " and pd.language_id = " & lang_id

        Return sql
    End Function
    Public Shared Function GetSelectCustomersSearch(ByVal customers_id As String, _
                                                 ByVal email As String, _
                                                 ByVal NameCustomer As String, _
                                                 ByVal streetCustomer As String, _
                                                 ByVal PostCodeCustomer As String, _
                                                 ByVal NumDom As String, _
                                                 ByVal NumComm As String, ByVal PPAgreementID As String) As String
        Dim sql As String
        Dim sqlWhere As String
        sql = " SELECT distinct c.*,ab.* " & _
              " FROM customers c " & _
              " LEFT JOIN address_book ab " & _
              " ON c.customers_id = ab.customers_id and c.customers_default_address_id=ab.address_book_id "
        sqlWhere = " WHERE 1 = 1"

        If customers_id <> String.Empty Then
            sqlWhere += " and c.customers_id = " & customers_id
        End If

        If email <> String.Empty Then
            email = email.ToUpper()
            sqlWhere += " and c.email like '%" & email & "%'"
        End If

        If PPAgreementID <> String.Empty Then
            PPAgreementID = PPAgreementID.ToUpper()
            sqlWhere += " and c.paypal_agreement_id like '%" & PPAgreementID & "%'"
        End If

        If NameCustomer <> String.Empty Then
            NameCustomer = NameCustomer.ToUpper()
            sqlWhere += " AND (c.customers_firstname like '%" & NameCustomer & "%' " & _
                " OR c.customers_lastname like '%" & NameCustomer & "%')"
        End If

        If streetCustomer <> String.Empty Then
            sqlWhere += " and ab.entry_street_address like '%" & streetCustomer & "%'"
        End If

        If PostCodeCustomer <> String.Empty Then
            sqlWhere += " and ab.entry_postcode like '%" & PostCodeCustomer & "%'"
        End If

        If NumDom <> String.Empty Then
            sqlWhere += " and c.domiciliation_number like '%" & NumDom & "%'"
        End If

        If NumComm <> String.Empty Then

            sql += " join payment p on p.customers_id = c.customers_id "
            sql += " and p.communication like '%" & NumComm & "%'"


        End If

        Return sql + sqlWhere
    End Function
    Public Shared Function getSelectCustStopKeepdvdBacklog() As String
        Dim sql As String
        ' 18/05/2011 a la place de now
        sql = " select " & clsMassEmail.CapitalizeSql("customers_firstname", "customers_lastname") & " as customers_name, c.customers_gender, " & _
            " c.customers_email_address,c.customers_language,c.customers_id,c.customers_abo_payment_method,c.customers_abo,c.customers_abo_dvd_home_norm,c.customers_abo_dvd_home_adult, " & _
            " if(a.date_stop = null,date(now()),a.date_stop) abo_stop, date(o.date_purchased) date_orders_sent, pd.products_name products_title, " & _
            " ' ' payment_offline_communication, " & _
            " ' ' payment_offline_amount " & _
            " from customers c join address_book ab on ab.customers_id = c.customers_id and ab.address_book_id = c.customers_default_address_id " & _
            " left join (select customerid,max(date) date_stop from abo where action =  4 group by customerid) a on a.customerid = c.customers_id " & _
            " join orders o on o.customers_id = c.customers_id " & _
            " join orders_products op on o.orders_id = op.orders_id " & _
            " join products p on op.products_id = p.products_id " & _
            " join products_description pd on p.products_id = pd.products_id and pd.language_id = c.customers_language " & _
            " where c.customers_abo = 0 and o.date_purchased <= date_sub('2011-05-18',interval 6 month) and o.date_purchased >= date_sub('2011-05-18',interval 1 year)  and o.orders_status = " & PlushData.clsOdersStatusHistory.OrderStatusNew.EXPEDITED

        Return sql

    End Function

    Public Shared Function getSelectCustStopKeepdvd(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = " select " & clsMassEmail.CapitalizeSql("customers_firstname", "customers_lastname") & " as customers_name, c.customers_gender, " & _
            " c.customers_email_address,c.customers_language,c.customers_id,c.customers_abo_payment_method,c.customers_abo,c.customers_abo_dvd_home_norm,c.customers_abo_dvd_home_adult, " & _
            " date(now()) abo_stop, date(o.date_purchased) date_orders_sent, pd.products_name products_title, " & _
            " ' ' payment_offline_communication, " & _
            " ' ' payment_offline_amount " & _
            " from customers c join address_book ab on ab.customers_id = c.customers_id and ab.address_book_id = c.customers_default_address_id " & _
            " join orders o on o.customers_id = c.customers_id " & _
            " join orders_products op on o.orders_id = op.orders_id " & _
            " join products p on op.products_id = p.products_id " & _
            " join products_description pd on p.products_id = pd.products_id and pd.language_id = c.customers_language " & _
            " where c.customers_id = " & customers_id & " and o.orders_status = " & PlushData.clsOdersStatusHistory.OrderStatusNew.EXPEDITED

        Return sql

    End Function

    Public Shared Function GetSelectCustomerDetail(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = " select " & clsMassEmail.CapitalizeSql("customers_firstname", "customers_lastname") & " as customers_name, " & _
              "c.customers_gender,c.email,c.customers_language,c.customers_id,c.customers_abo_payment_method,c.customers_abo " & _
              " from customers c " & _
              " where c.customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetSelectActivationDomCustomers(ByVal typePayment As Integer, ByVal country_id As Integer) As String
        Dim sql As String

        Dim strmysqldate As String = PlushTools.ClsDate.formatDate()

        sql = "select b.financialid bic,"
        sql = sql & " c.customers_id,"
        sql = sql & " c.domiciliation_account_number,"
        sql = sql & " ab.entry_street_address,"
        sql = sql & " ab.entry_postcode,"
        sql = sql & " concat(c.customers_firstname,' ',c.customers_lastname) customers_name"
        sql = sql & " FROM customers c join address_book ab on ab.customers_id = c.customers_id and ab.address_book_id = c.customers_default_address_id"
        sql = sql & " join banks b on b.b_from "
        sql = sql & " WHERE customers_abo = 0 "
        sql = sql & " AND domiciliation_status = 2 "
        sql = sql & " AND customers_registration_step in (75,100) "
        sql = sql & " AND customers_abo_payment_method = " & typePayment
        sql = sql & " AND EntityID = " & country_id
        sql = sql & " and (cast(substring(c.domiciliation_account_number,1,3) as unsigned)) >= (cast(b.b_from as unsigned)) "
        sql = sql & " and (cast(substring(c.domiciliation_account_number,1,3) as unsigned)) <= (cast(b.b_to as unsigned)) "
        sql = sql & " and not b.financialid is null "
        sql = sql & " Order by bic "
        Return sql
    End Function
    Public Shared Function GetSelectInitialisationCustomer(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "select c.customers_abo_auto_stop_next_reconduction,"
        sql = sql & " c.customers_next_abo_type,"
        sql = sql & " c.customers_abo_type,"
        sql = sql & " c.customers_abo_payment_method,"
        sql = sql & " c.customers_id,"
        sql = sql & " p.products_model,"
        sql = sql & " c.customers_email_address,"
        sql = sql & "if(c.customers_abo_discount_recurring_to_date > now(), 1, 0) as recurring_discount, "
        sql = sql & " c.customers_abo_validityto,"
        sql = sql & " c.activation_discount_code_id,"
        sql = sql & " c.activation_discount_code_type,"
        sql = sql & " c.customers_next_discount_code,"
        sql = sql & " p.products_price,"
        sql = sql & " '-1' amount"
        sql = sql & " FROM customers c join products p on c.customers_next_abo_type = p.products_id "
        sql = sql & " WHERE customers_id = " & customers_id
        Return sql

    End Function
    Public Shared Function GetSelectInfoNextReconductionCustomers(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "select c.customers_abo_auto_stop_next_reconduction,"
        sql = sql & " c.customers_next_abo_type,"
        sql = sql & " c.customers_abo_type,"
        sql = sql & " c.customers_abo_payment_method,"
        sql = sql & " c.customers_id,"
        sql = sql & " c.email,"
        sql = sql & " concat(c.customers_firstname,' ',c.customers_lastname) customers_name,"
        sql = sql & " p.products_model,"
        sql = sql & "if(c.customers_abo_discount_recurring_to_date > now(), 1, 0) as recurring_discount, "
        sql = sql & " c.customers_abo_validityto,"
        sql = sql & " c.activation_discount_code_id,"
        sql = sql & " c.activation_discount_code_type,"
        sql = sql & " c.customers_next_discount_code,"
        sql = sql & " c.ogone_card_type,"
        sql = sql & " c.ogone_card_no,"
        sql = sql & " c.ogone_exp_date,"
        sql = sql & " p.products_price,"
        sql = sql & " '-1' amount"
        sql = sql & " FROM customers c join products p on c.customers_next_abo_type = p.products_id "
        sql = sql & " WHERE customers_abo = 1 "

        If customers_id > -1 Then
            sql = sql & " AND c.customers_id = " & customers_id
        End If
        Return sql
    End Function
    ''' <summary>
    '''  if the batch automatic doesn't work and not create invoices 
    ''' </summary>
    ''' <param name="d"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetRecreateBatchOgonewithoutpaymentCreate(ByVal d As String) As String

        Dim sql As String

        sql = " select a.customerid customers_id,ps.products_model,ps.products_price amount " & _
              " from abo a" & _
              " left join payment p on a.customerid = p.customers_id and p.payment_method = 1 and date(p.date_added) = '" & d & "'" & _
              " join products ps on a.product_id = ps.products_id " & _
              " where a.action = 7 and date(date) = '" & d & "' and a.payment_method = 'OGONE' and p.customers_id is null "


        Return sql
    End Function
    ''' <summary>
    ''' if the batch automatic doesn't work and the invoices are created 
    ''' </summary>
    ''' <param name="d"></param>
    ''' <param name="country_id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetSelectReplayReconductionOgoneCreateDate(ByVal d As String, ByVal country_id As Integer) As String

        Dim sql As String
        sql = " select c.customers_id," & _
              "       pp.products_model," & _
              "       p.amount" & _
              " from payment p " & _
              " join customers c on p.customers_id = c.customers_id" & _
              " join products pp on c.customers_next_abo_type = pp.products_id" & _
              " where c.EntityID = " & country_id & " and date(p.date_added) = '" & d & "'" & _
              " and p.payment_method = " & Payment_Method.OGONE & " and p.payment_status = 1 "

        Return sql
    End Function

    Public Shared Function GetSelectChangeCardCreditCustomers(ByVal country_id As Integer) As String

        Dim sql As String

        sql = "select c.customers_id," & _
              "       pp.products_model," & _
              "       p.amount" & _
              " from payment p " & _
              " join ( " & _
                        " Select ab.customerid" & _
                        " from abo ab " & _
                        " join (select customerid,max(abo_id) abo_id from abo group by customerid) a on ab.abo_id = a.abo_id" & _
                        " where(ab.action = " & TypeAction.ACTION_CHANGCARD & " and date(ab.Date) = date(date_add(now(),interval -1 day))) " & _
            " ) changecard_cust on changecard_cust.customerid = p.customers_id " & _
            " join customers c on p.customers_id = c.customers_id" & _
            " join products pp on c.customers_next_abo_type = pp.products_id" & _
            " where p.payment_status not in (" & PaymentOfflineData.GetListClose() & ") "
        '" and c.EntityID = " & country_id

        Return sql
    End Function
    Public Shared Function GetSelectReconductionCustomers(ByVal typePayment As Integer, ByVal country_id As Integer, ByVal customers_id As Integer) As String
        Dim sql As String

        Dim strmysqldate As String = PlushTools.ClsDate.formatDate()

        sql = "select c.customers_abo_auto_stop_next_reconduction,"
        sql = sql & " c.customers_next_abo_type,c.customers_abo,"
        sql = sql & " c.customers_abo_type,"
        sql = sql & " c.customers_abo_payment_method,"
        sql = sql & " c.customers_id,"
        sql = sql & " c.email,"
        sql = sql & " concat(c.customers_firstname,' ',c.customers_lastname) customers_name,"
        sql = sql & " p.products_model,"
        sql = sql & "if(date(c.customers_abo_discount_recurring_to_date) > now(), 1, 0) as recurring_discount, "
        sql = sql & " c.customers_abo_validityto,"
        sql = sql & " c.activation_discount_code_id,"
        sql = sql & " c.activation_discount_code_type,"
        sql = sql & " c.customers_next_discount_code,"
        sql = sql & " c.ogone_card_type,"
        sql = sql & " c.ogone_card_no,"
        sql = sql & " c.ogone_exp_date,"
        sql = sql & " c.customers_locked__for_reconduction,"
        sql = sql & " p.products_price,"
        sql = sql & " '-1' amount,"
        sql = sql & " pa.package_count package_count,"
        sql = sql & " panext.package_count package_count_next"
        sql = sql & " FROM customers c join products p on c.customers_next_abo_type = p.products_id "
        sql = sql & " join products_abo panext on c.customers_next_abo_type = panext.products_id "
        sql = sql & " join products_abo pa on c.customers_abo_type = pa.products_id "
        sql = sql & " WHERE date(customers_abo_validityto) <= '" & strmysqldate & "'"
        sql = sql & " AND customers_abo = 1 "
        sql = sql & " and customers_abo_suspended = 0 "

        '" AND customers_abo_payment_method = " & typePayment & - samsung cutomers without ogone data could be reconducted.
        '  But if the abo package is not samsung they shold have payment method defined


        If customers_id > -1 Then
            sql = sql & " AND c.customers_id = " & customers_id
        End If
        Return sql
    End Function

    Public Shared Function GetSelectReconductionPayPalCustomers(ByVal typePayment As Integer, ByVal country_id As Integer, ByVal customers_id As Integer) As String
        Dim sql As String

        Dim strmysqldate As String = PlushTools.ClsDate.formatDate()

        sql = "select c.customers_abo_auto_stop_next_reconduction,"
        sql = sql & " c.customers_next_abo_type,c.customers_abo,"
        sql = sql & " c.customers_abo_type,"
        sql = sql & " c.customers_abo_payment_method,"
        sql = sql & " c.customers_id,"
        sql = sql & " c.customers_abo_dvd_norm,"
        sql = sql & " c.customers_abo_dvd_adult,"
        sql = sql & " c.customers_email_address,"
        sql = sql & " concat(c.customers_firstname,' ',c.customers_lastname) customers_name,"
        sql = sql & " p.products_model,"
        sql = sql & "if(date(c.customers_abo_discount_recurring_to_date) > now(), 1, 0) as recurring_discount, "
        sql = sql & " c.customers_abo_validityto,"
        sql = sql & " c.activation_discount_code_id,"
        sql = sql & " c.activation_discount_code_type,"
        sql = sql & " c.customers_next_discount_code,"
        sql = sql & " c.ogone_card_type,"
        sql = sql & " c.ogone_card_no,"
        sql = sql & " c.ogone_exp_date,"
        sql = sql & " p.products_price,"
        sql = sql & " '-1' amount,"
        sql = sql & " ca.combined,  "
        sql = sql & "( SELECT if(pa.qty_dvd_max >= 0, 1, 0) FROM products_abo pa WHERE pa.products_id = c.customers_next_abo_type ) as npp_logic, " 'npp
        sql = sql & " c.paypal_agreement_id, c.paypal_transaction_id, " 'paypal
        sql = sql & " 0 payment_id,"
        sql = sql & " pa.package_count package_count,"
        sql = sql & " panext.package_count package_count_next"
        sql = sql & " FROM customers c join products p on c.customers_next_abo_type = p.products_id "
        sql = sql & " join customer_attributes ca on c.customers_id = ca.customer_id "
        sql = sql & " WHERE date(customers_abo_validityto) <= '" & strmysqldate & "'"
        sql = sql & " AND customers_abo = 1 "
        sql = sql & " AND customers_abo_payment_method = " & typePayment & " and customers_abo_suspended = 0 "


        If customers_id > -1 Then
            sql = sql & " AND c.customers_id = " & customers_id
        Else
            sql = sql & " AND EntityID = " & country_id
        End If
        Return sql
    End Function

    Public Shared Function GetUpdateADULTSVOD(ByVal customers_id As Integer, ByVal validity_period As String) As String
        Dim sql As String

        sql = "update customers_svod set validityto = date_add( now(), INTERVAL 1 " & validity_period & "), updated_at = now() " & _
" where customer_id = " & customers_id & "; update customers set svod_adult = (case when svod_adult = 1 then 2 when svod_adult = 3 then 4 end) where svod_adult in(1,3) and customers_id = " & customers_id & " ;"

        Return sql
    End Function

    Public Shared Function GetStopADULTSVOD(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = "update customers set svod_adult = 0 where svod_adult = 4 and customers_id = " & customers_id

        Return sql
    End Function

    Public Shared Function GetSelectReconductionADULTSVOD(ByVal typePayment As Integer, ByVal country_id As Integer, ByVal customers_id As Integer) As String
        Dim sql As String

        Dim strmysqldate As String = PlushTools.ClsDate.formatDate()

        sql = "select c.customers_id,"
        sql = sql & " c.customers_email_address,"
        sql = sql & " concat(c.customers_firstname,' ',c.customers_lastname) customers_name,"
        sql = sql & " c.customers_abo_payment_method,"
        sql = sql & " cs.amount as products_price, "
        sql = sql & " '' as amount, "
        sql = sql & " cs.product_abo_id, "
        sql = sql & " cs.product_abo_id customers_abo_type, "
        sql = sql & " cs.product_abo_id customers_next_abo_type, "
        sql = sql & " cs.validity_period, "
        sql = sql & " 'pack' as products_model,"
        sql = sql & " domiciliation_number,"
        sql = sql & " c.ogone_card_type,"
        sql = sql & " c.ogone_card_no,"
        sql = sql & " c.ogone_exp_date,"
        sql = sql & " c.paypal_agreement_id, c.paypal_transaction_id, "
        sql = sql & " 0 payment_id, "
        sql = sql & " c.svod_adult "
        sql = sql & " FROM customers c join customers_svod cs on c.customers_id = cs.customer_id "
        sql = sql & " WHERE date(cs.validityto) <= '" & strmysqldate & "'"
        sql = sql & " AND c.customers_abo = 1 "
        sql = sql & " AND c.customers_abo_payment_method = " & typePayment & " and c.customers_abo_suspended = 0 "
        sql = sql & " AND c.svod_adult in (1, 2, 3, 4) "


        If customers_id > -1 Then
            sql = sql & " AND c.customers_id = " & customers_id
        Else
            sql = sql & " AND EntityID = " & country_id
        End If
        Return sql
    End Function

    Public Shared Function GetSelectPAYPALReconductionADULTSVOD(ByVal typePayment As Integer, ByVal country_id As Integer, ByVal customers_id As Integer) As String
        Dim sql As String

        Dim strmysqldate As String = PlushTools.ClsDate.formatDate()

        sql = "select c.customers_id,"
        sql = sql & " c.customers_email_address,"
        sql = sql & " concat(c.customers_firstname,' ',c.customers_lastname) customers_name,"
        sql = sql & " c.customers_abo_payment_method,"
        sql = sql & " cs.amount, "
        sql = sql & " cs.product_abo_id, "
        sql = sql & " cs.product_abo_id customers_abo_type, "
        sql = sql & " cs.product_abo_id customers_next_abo_type, "
        sql = sql & " cs.validity_period, "
        sql = sql & " 'DVDPost subscription pack' as products_model,"
        sql = sql & " domiciliation_number,"
        sql = sql & " c.ogone_card_type,"
        sql = sql & " c.ogone_card_no,"
        sql = sql & " c.ogone_exp_date,"
        sql = sql & " c.paypal_agreement_id, c.paypal_transaction_id, "
        sql = sql & " 0 payment_id, "
        sql = sql & " c.svod_adult, "
        sql = sql & " c.paypal_agreement_id, c.paypal_transaction_id, " 'paypal
        sql = sql & " 0 payment_id"
        sql = sql & " FROM customers c join customers_svod cs on c.customers_id = cs.customer_id "
        sql = sql & " WHERE date(cs.validityto) <= '" & strmysqldate & "'"
        sql = sql & " AND c.customers_abo = 1 "
        sql = sql & " AND c.customers_abo_payment_method = " & typePayment & " and c.customers_abo_suspended = 0 "
        sql = sql & " AND c.svod_adult in (1, 2, 3, 4) "


        If customers_id > -1 Then
            sql = sql & " AND c.customers_id = " & customers_id
        Else
            sql = sql & " AND EntityID = " & country_id
        End If
        Return sql
    End Function

    Public Shared Function getLastCodeSubscription() As String
        Dim sql As String

        sql = " select a.customerid,if (a.action = " & TypeAction.ACTION_FROM_ACTIVATION & ",'A','D') type_code, if(a.action = " & TypeAction.ACTION_FROM_ACTIVATION & ", (select activation_code code from activation_code where activation_id = a.code_id), " & _
         " (select discount_code from discount_code where discount_code_id = a.code_id)) promo_code " & _
         " from abo a " & _
         " join (select customerid,max(abo_id) abo_id from abo where Action in(" & TypeAction.ACTION_FROM_ACTIVATION & "," & TypeAction.ACTION_FROM_DISCOUNT & ") group by customerid) lastabo " & _
         " on lastabo.customerid = a.customerid and lastabo.abo_id = a.abo_id "

        Return sql
    End Function

    Public Shared Function getLastCodeSubscription(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = " select if (abo.action = " & TypeAction.ACTION_FROM_ACTIVATION & ",'A','D') type_code, " & _
        "       if(abo.action = " & TypeAction.ACTION_FROM_ACTIVATION & ", (select activation_code code " & _
        "                           from activation_code where activation_id = abo.code_id)," & _
        "                          (select discount_code from discount_code " & _
        "                           where discount_code_id = abo.code_id)) code from " & _
        " (select code_id,action from abo where abo_id = " & _
        " (select max(abo_id) from abo where customerid = " & customers_id & _
        " and  Action in(" & TypeAction.ACTION_FROM_ACTIVATION & "," & TypeAction.ACTION_FROM_DISCOUNT & "))) abo "
        Return sql
    End Function

    Public Shared Function GetSelectDiscountCode(ByVal discount_code_id As Integer) As String
        Dim sql As String

        sql = "select dc.discount_code, dc.next_discount,dc.discount_type type ,dc.discount_value value,dc.discount_validityto date ,dc.discount_abo_validityto_value,dc.discount_abo_validityto_type ,discount_recurring_nbr_of_month,next_abo_type " & _
        " from discount_code dc where dc.discount_code_id = " & discount_code_id
        Return sql
    End Function

    Public Shared Function GetSelectActivationCode(ByVal Activation_code_id As Integer) As String
        Dim sql As String

        sql = "select a.activation_id code_id,a.activation_code code,a.activation_code, a.next_discount,a.validity_type type ,a.validity_value value,a.activation_code_validto_date date,next_abo_type  " & _
        " from activation_code a " & _
        " where a.activation_id = " & Activation_code_id
        Return sql
    End Function
    Public Shared Function GetSelectQtyDvd(ByVal type_abo As Integer) As String
        Dim sql As String
        sql = "select qty_at_home FROM products_abo where products_id = " & type_abo
        Return sql
    End Function
    Public Shared Function GetSelectCredit(ByVal type_abo As Integer) As String
        Dim sql As String
        sql = "select qty_credit FROM products_abo where products_id = " & type_abo
        Return sql
    End Function
    Public Shared Function GetSelectNPPCredit(ByVal type_abo As Integer) As String
        Dim sql As String
        sql = "select qty_credit, qty_dvd_max FROM products_abo where products_id = " & type_abo
        Return sql
    End Function
    Public Shared Function GetSelectNPPCreditByCustomer(ByVal customers_id As String) As String
        Dim sql As String
        If customers_id = "" Then
            customers_id = "0"
        End If
        sql = "select count(*) FROM customers c join products_abo pa on c.customers_abo_type = pa.products_id where pa.qty_dvd_max >= 0 and customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetSelectAboSummerWinterPOwer(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "select  if(a.action= " & TypeAction.ACTION_FROM_DISCOUNT & " ,(if(a.code_id in (" & discountCode.SUMMER_POWER & " , " & discountCode.WINTER_POWER & ") ,'Abonnement 12 mois', 0)),0) as discount_summer_winter  from abo a " & _
                                  "where   a.customerid = " & customers_id & " and a.action in (" & TypeAction.ACTION_FROM_DISCOUNT & " , " & TypeAction.ACTION_FROM_ACTIVATION & " ," & TypeAction.ACTION_CREATE & " ) order by a.abo_id desc limit 1"
        Return sql
    End Function
    Public Shared Function GetLastAboid(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = "select max(abo_id) from abo where customerid = " & customers_id
        Return sql

    End Function
    Public Shared Function GetSelectIsFreeTrial() As String
        Dim sql As String
        sql = " select x.customers_id,if(x.last_action = " & TypeAction.ACTION_RECONDUCTION & ",0,1) freeTrial " & _
              " from ( " & _
              " select c.customers_id,(select a.`action` from abo a where a.`action` in (" & TypeAction.ACTION_RECONDUCTION & "," & TypeAction.ACTION_RECONDUCTIONFREE & ") and a.customerid = c.customers_id order by a.abo_id desc limit 1) last_action " & _
              " from customers c " & _
              " ) x "

        Return sql
    End Function

    Public Shared Function GetIsFreeTrial(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = " select if(x.last_action = " & TypeAction.ACTION_RECONDUCTION & ",0,1) freeTrial " & _
                " from ( " & _
             " select c.customers_id,(select a.`action` from abo a where a.`action` in (" & TypeAction.ACTION_RECONDUCTION & "," & TypeAction.ACTION_RECONDUCTIONFREE & ") and a.customerid = c.customers_id order by a.abo_id desc limit 1) last_action " & _
             " from customers c " & _
             "   where( c.customers_id = " & customers_id & ")) x" 'and c.customers_abo = " & abo.VALID & " And c.customers_abo_suspended = " & Suspended.OK & ")) x "

        Return sql
    End Function
    Public Shared Function GetFreeTrial() As String
        Dim sql As String

        sql = "select freetrial,count(*) nb_cust from ( " & _
              " select customers_id, if(x.last_action = " & TypeAction.ACTION_RECONDUCTION & ",0,1) freeTrial " & _
              " from ( " & _
                 " select c.customers_id,(select a.`action` from abo a where a.`action` in (" & TypeAction.ACTION_RECONDUCTION & "," & TypeAction.ACTION_RECONDUCTIONFREE & ") and a.customerid = c.customers_id order by a.abo_id desc limit 1) last_action " & _
                 " from customers c " & _
                 "   where(c.customers_abo = " & abo.VALID & " And c.customers_abo_suspended = " & Suspended.OK & ") " & _
                 " ) x " & _
                 ") xx" & _
                 " group by freetrial "

        Return sql
    End Function

    Public Shared Function GetRedBlacklistedCustomers(ByVal blackRedListed As RedBlackListed) As String
        Dim sql As String
        Dim where As String = String.Empty
        sql = "SELECT distinct c.*,ab.* FROM customers c " & _
              " LEFT JOIN address_book ab " & _
              " ON c.customers_id = ab.customers_id and c.customers_default_address_id=ab.address_book_id "
        If blackRedListed = RedBlackListed.BLACKLISTED Then
            where = "where  black_listed = 1 "
        End If

        If blackRedListed = RedBlackListed.REDLISTED Then
            where = "where red_listed = 1 "
        End If

        where = where & "and customers_abo = 1 "

        Return sql + where

    End Function

    'Public Shared Function GetSelectVodAccess(ByVal customers_id) As String
    '    Dim sql As String
    '    sql = "select * from beta_tests where customer_id = " & customers_id
    '    Return sql
    'End Function

    Public Shared Function GetSelectSuspended() As String
        Dim sql As String

        sql = "select * from customers c left join (select p.customers_id,count(*) cpt from payment p " & _
              "                                             where p.payment_status in (" & PaymentOfflineData.GetListRecoverySuspended() & ")" & _
              "                                             group by p.customers_id" & _
              "                                            ) payment_offline on payment_offline.customers_id = c.customers_id" & _
              " join (select p.customers_id,count(*) cpt from payment p  where p.payment_status in (" & PaymentOfflineData.GetListRecovery() & ") group by p.customers_id) qty_paid on qty_paid.customers_id = c.customers_id " & _
              " where c.customers_abo_suspended = " & Suspended.OK & " and c.customers_abo = " & abo.VALID & " and (payment_offline.cpt > 0 or qty_paid.cpt >= 2) "

        Return sql
    End Function


    Public Shared Function GetSelectUnsuspended() As String
        Dim sql As String

        sql = "select * from customers c left join (select p.customers_id,count(*) from payment p " & _
              "                                             where p.payment_status in (" & PaymentOfflineData.GetListRecoverySuspended() & ")" & _
              "                                             group by p.customers_id" & _
              "                                            ) payment_offline on payment_offline.customers_id = c.customers_id" & _
              " left join (select p.customers_id,count(*) cpt from payment p  where p.payment_status  in (" & PaymentOfflineData.GetListRecovery() & ") group by p.customers_id) qty_paid on qty_paid.customers_id = c.customers_id " & _
              " where c.customers_abo_suspended = " & Suspended.RECONDUCTION & " and c.customers_abo = " & abo.VALID & " and (payment_offline.customers_id is null and (qty_paid.cpt is null or qty_paid.cpt < 2)) "

        Return sql
    End Function


    Public Shared Function GetSelectIsAboIllimited(ByVal customers_id As String) As String
        Dim sql As String
        sql = "select c.*  from customers c " & _
        " join products_abo pa on c.customers_abo_type = pa.products_id" & _
        " where c.customers_id = " & customers_id & _
        " and pa.qty_credit = 0"

        Return sql
    End Function

    Public Shared Function GetSelectTypeAbo(ByVal customers_id As String) As String
        Dim sql As String
        sql = "select customers_abo_type from customers where customers_id = " & customers_id
        Return sql
    End Function

    Public Shared Function GetSelectCountReconduction(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = " select count(*) cpt_reconduction " & _
              " from abo a where a.customerid = " & customers_id & _
              " and  a.`action` = " & TypeAction.ACTION_RECONDUCTION & _
              "        and a.date >= (select max(date) from abo aa where aa.customerid = a.customerid " & _
              "        and aa.action in (" & ClsCustomersData.TypeAction.ACTION_CREATE & "," & ClsCustomersData.TypeAction.ACTION_FROM_ACTIVATION & "," & ClsCustomersData.TypeAction.ACTION_FROM_DISCOUNT & _
              "      ) group by aa.customerid ) group by a.customerid "

        Return sql
    End Function

    Public Shared Function GetSelectIsMailCopy(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = "select mail_copy from customers where customers_id = " & customers_id
        Return sql
    End Function
#End Region
#Region "insert"
    Public Shared Function GetInsertHistoryAboStop(ByVal customers_id As Integer, ByVal reason_id As Integer, ByVal commentAboStop As String) As String
        Dim sql As String

        sql = "insert into customers_abo_stop ( customers_id ,date_stop ,reason_id ,COMMENT) "
        sql = sql & " values ('" & customers_id & "',now(), " & reason_id & " ,'" & commentAboStop & "')"
        Return sql

    End Function

    Public Shared Function GetInsertDiscountUse(ByVal customers_id As Integer, ByVal newdiscount_code As Integer) As String
        Dim sql As String

        sql = "insert into discount_use(discount_code_id , discount_use_date , customers_id) values (" & newdiscount_code & _
                                  ", now(), " & customers_id & ")"

        Return sql
    End Function

    Public Shared Function GetInsertHistoryAbo(ByVal customers_id As Integer, ByVal code_id As String, ByVal product_id As Integer, ByVal type_payment As String, ByVal actionCode As Integer) As String
        Dim sql As String
        If code_id = "" Then
            code_id = "null"
        End If
        sql = "insert into abo(Customerid ,code_id, Action , Date , product_id, payment_method) " & _
               " values(" & customers_id & "," & code_id & "," & actionCode & ", now(), '" & product_id & "', '" & type_payment & "' )"

        Return sql
    End Function

    'Public Shared Function GetInsertVodAccess(ByVal customers_id) As String
    '    Dim sql As String
    '    sql = "insert beta_tests values (null," & customers_id & ")"
    '    Return sql
    'End Function

#End Region
#Region "update"

    Public Shared Function GetUpdateNextProductType(ByVal customers_id As Integer, ByVal nextproduct_id As Integer) As String
        Dim sql As String

        sql = " update customers set customers_next_abo_type = " & nextproduct_id & "  where customers_id = " & customers_id
        Return sql
    End Function

    Public Shared Function GetUpdateProductType(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = " update customers set customers_abo_type = customers_next_abo_type  where customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetUpdateEncodeCreditCard(ByVal customers_id As Integer, ByVal encode_card As String) As String
        Dim sql As String

        sql = " update customers set ogone_card_no = '" & encode_card & "' where customers_id = " & customers_id
        Return sql
    End Function

    Public Shared Function GetUpdateActivation(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = "update customers set  customers_abo = 1,customers_abo_suspended = 0,customers_registration_step = 100, customers_abo_auto_stop_next_reconduction = 0 where customers_id = " & customers_id & " and customers_abo = 0"
        Return sql

    End Function

    Public Shared Function GetUpdateResetPointFather(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = " update mem_get_mem_used mgmu " & _
              " set expected_points = 0 " & _
              " where points = 0 and son_id = " & customers_id

        Return sql
    End Function

    Public Shared Function GetUpdateResetPointFreeTrial(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = " update customers c " & _
              " set mgm_points = 0 " & _
              " where customers_id = " & customers_id & _
              " and not exists (select * from abo where action = " & TypeAction.ACTION_RECONDUCTION & " and customerid = c.customers_id)"
        Return sql
    End Function
    Public Shared Function GetUpdateAboStop(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = "update customers set  customers_abo = 0,customers_registration_step = 90 where customers_id = " & customers_id & " and customers_abo = 1"
        Return sql

    End Function
    Public Shared Function GetUpdateSuspendedCustomersError(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "update customers set customers_abo_suspended = " & Suspended.RECONDUCTION & ",customers_abo_status = " & Abo_status.RECONDUCTION & "  where customers_id = " & customers_id & " and customers_abo = 1 "
        Return sql
    End Function
    Public Shared Function GetUpdateSuspendedCustomers(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "update customers set customers_abo_suspended = " & Suspended.RECONDUCTION & " where customers_id = " & customers_id & " and customers_abo = 1 "
        Return sql
    End Function

    Public Shared Function GetUpdateSuspendedForHolidayCustomers(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "update customers set customers_abo_suspended = " & Suspended.HOLIDAY & " where customers_id = " & customers_id & " and customers_abo = 1 "
        Return sql
    End Function

    Public Shared Function GetUpdateUnsuspendedForHolidayCustomer(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "update customers set customers_abo_suspended = " & Suspended.OK & " where customers_id = " & customers_id & " and customers_abo = 1 and customers_abo_suspended = " & Suspended.HOLIDAY
        Return sql
    End Function

    Public Shared Function GetUpdateUnsuspendedForPaymentCustomer(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "update customers set customers_abo_suspended = " & Suspended.OK & " where customers_id = " & customers_id & " and customers_abo = 1 and customers_abo_suspended = " & Suspended.RECONDUCTION

        Return sql
    End Function

    Public Shared Function GetUpdateDiscountCode(ByVal customers_id As Integer, ByVal newdiscount_code As Integer, ByVal discount_recurring_of_month As Integer, ByVal activation_discount_code_type As String, Optional ByVal discount_code As Integer = 0) As String
        Dim sql As String
        Dim RecurringDate As DateTime
        Dim strRecurringdate As String

        If discount_recurring_of_month > 0 Then
            RecurringDate = DateAdd(DateInterval.Month, discount_recurring_of_month + 1, Now())
            RecurringDate = DateAdd(DateInterval.Day, -1, RecurringDate)
            strRecurringdate = "'" & Year(RecurringDate) & "-" & Month(RecurringDate) & "-" & Day(RecurringDate) & "'"
        Else
            strRecurringdate = "null"
        End If
        sql = "update customers set activation_discount_code_id = " & newdiscount_code
        sql = sql & " , customers_abo_discount_recurring_to_date = " & strRecurringdate & ""
        sql = sql & " , activation_discount_code_type = '" & activation_discount_code_type & "'"
        sql = sql & " , customers_next_discount_code = " & discount_code
        sql = sql & " where customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetUpdateRecurringDiscountCode(ByVal customers_id As Integer, ByVal newdiscount_code As Integer, ByVal discount_recurring_of_month As Integer, ByVal activation_discount_code_type As String, Optional ByVal discount_code As Integer = 0) As String
        Dim sql As String
        Dim RecurringDate As DateTime
        Dim strRecurringdate As String

        If discount_recurring_of_month > 0 Then
            RecurringDate = DateAdd(DateInterval.Month, discount_recurring_of_month + 1, Now())
            RecurringDate = DateAdd(DateInterval.Day, -1, RecurringDate)
            strRecurringdate = "'" & Year(RecurringDate) & "-" & Month(RecurringDate) & "-" & Day(RecurringDate) & "'"
        Else
            strRecurringdate = "null"
        End If
        sql = "update customers set customers_abo_discount_recurring_to_date = " & strRecurringdate & " where customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetUpdateActivationCode(ByVal customers_id As Integer, ByVal activation_code_id As Integer) As String
        Dim sql As String
        sql = " UPDATE activation_code set activation_date = now(), customers_id = " & customers_id & " where activation_id = " & activation_code_id
        Return sql
    End Function
    Public Shared Function GetUpdateQtyDvd(ByVal customers_id As Integer, ByVal qtyNorm As Integer, ByVal qtyAdult As Integer) As String
        Dim sql As String
        sql = "UPDATE customers set customers_abo_dvd_norm = " & qtyNorm
        sql = sql & ",customers_abo_dvd_adult = " & qtyAdult
        sql = sql & ",wishlist_kind = 2 "
        sql = sql & ",customers_abo_multishipment = 1"
        sql = sql & " WHERE customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetUpdateQtyDvd(ByVal customers_id As Integer, ByVal qty As Integer) As String
        Dim sql As String
        sql = "UPDATE customers set customers_abo_dvd_norm = " & qty
        sql = sql & ",customers_abo_dvd_adult = 0"
        sql = sql & ",wishlist_kind = 2 "
        sql = sql & ",customers_abo_multishipment = 1"
        sql = sql & " WHERE customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetUpdateActivationNextDiscountCode(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "update customers set customers_next_discount_code = 0 where customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetUpdateNextDiscountCode(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "update customers set customers_next_discount_code = activation_discount_code_id where customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetUpdateCreditNoCombined(ByVal customers_id As Integer, ByVal credit As Integer) As String
        Dim sql As String
        sql = "update customers set customers_abo_dvd_credit = " & credit & " where customers_id = " & customers_id
        Return sql
    End Function

    Public Shared Function GetUpdateCredit(ByVal customers_id As Integer, ByVal credit As Integer) As String
        Dim sql As String
        sql = "update customers set customers_abo_dvd_credit = customers_abo_dvd_credit + " & credit & " where customers_id = " & customers_id
        Return sql
    End Function

    Public Shared Function GetUpdateNPPCredit(ByVal customers_id As Integer, ByVal credit As Integer, ByVal dvd_max As Integer) As String
        Dim sql As String
        sql = "update customers set customers_abo_dvd_credit = " & credit & ", customers_abo_dvd_remain = " & dvd_max & "  where customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetUpdateCreditsAlreadyRecieved(ByVal customer_id As Integer) As String

        Dim sql As String
        sql = " update customer_attributes set credits_already_recieved = 0 where customer_id = " & customer_id

        Return sql
    End Function
    Public Shared Function GetUpdateAboType(ByVal customers_id As Integer, ByVal abo_type As Integer, ByVal nb_dvd_norm As Integer) As String
        Dim sql As String
        sql = "UPDATE customers set customers_abo_dvd_norm = " & nb_dvd_norm
        sql = sql & ", customers_abo_dvd_adult = 0"
        sql = sql & ", customers_abo_type = " & abo_type
        sql = sql & " WHERE customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetUpdateNewClientRank(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = "update customers set customers_abo_rank = 10 where customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetUpdateValidAbo(ByVal customers_id As Integer, Optional ByVal domiciliation As Boolean = True) As String
        Dim sql As String
        Dim stepReg As Integer

        If domiciliation Then
            stepReg = StepRegistrationStatus.RECEIVED_DOMICILIATION
        Else

            stepReg = StepRegistrationStatus.OK
        End If
        sql = "update customers set customers_abo = 1,customers_registration_step = " & stepReg & " where customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetUpdateLockedReconduction(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = "update customers set customers_locked__for_reconduction = 0 where customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetUpdateValidityTo(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = "update customers set customers_abo_validityto = now() where customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetUpdateDateValidity(ByVal customers_id As Integer, Optional ByVal activationDuration As String = "") As String
        Dim sql As String
        Dim sqlactivation_duration As String

        If activationDuration = "" Then
            sqlactivation_duration = " 1 MONTH"
        Else
            sqlactivation_duration = activationDuration
        End If

        sql = "update customers set customers_abo_validityto = DATE_ADD(now(), INTERVAL " & sqlactivation_duration & ") where customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetUpdateNumberDomiciliation(ByVal customers_id As Integer, ByVal numDom As String) As String
        Dim sql As String

        sql = "update customers set domiciliation_number = '" & numDom & "',domiciliation_status = " & DomiciliationStatus.OK & " where customers_id = " & customers_id
        Return sql
    End Function

    Public Shared Function GetUpdatePPV_ready(ByVal customers_id As Integer, ByVal ppv_status_id As Integer) As String
        Dim sql As String

        sql = "update customers set ppv_status_id = " & ppv_status_id & " where customers_id = " & customers_id
        Return sql
    End Function

    Public Shared Function getUpdateNoActivation(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = "update customers set activation_discount_code_type = '' where customers_id = " & customers_id
        Return sql

    End Function
    Public Shared Function GetUpdatePassWord(ByVal customers_id As Integer, ByVal code As String) As String
        Dim sql As String
        sql = "update customers set encrypted_password = '" & code & "' where  customers_id = " & customers_id ' 80dc1837319ead62a8a8e53592bba048:b8 = dvdpost
        Return sql
    End Function
    Public Shared Function GetUpdateSuspended() As String
        Dim sql As String

        sql = "update customers c left join (select p.customers_id,count(*) cpt from payment p " & _
              "                                             where p.payment_status in (" & PaymentOfflineData.GetListRecoverySuspended() & ")" & _
              "                                             group by p.customers_id" & _
              "                                            ) payment_offline on payment_offline.customers_id = c.customers_id" & _
              " join (select p.customers_id,count(*) cpt from payment p  where p.payment_status not in (" & PaymentOfflineData.GetListClose() & ") group by p.customers_id) qty_paid on qty_paid.customers_id = c.customers_id " & _
              " set c.customers_abo_suspended = " & Suspended.RECONDUCTION & _
              " where c.customers_abo_suspended = " & Suspended.OK & " and c.customers_abo = " & abo.VALID & " and (payment_offline.cpt > 0 or qty_paid.cpt >= 2) "

        Return sql
    End Function


    Public Shared Function GetUpdateUnsuspended() As String
        Dim sql As String

        sql = "update customers c left join (select p.customers_id,count(*) from payment p " & _
              "                                             where p.payment_status in (" & PaymentOfflineData.GetListRecoverySuspended() & ")" & _
              "                                             group by p.customers_id" & _
              "                                            ) payment_offline on payment_offline.customers_id = c.customers_id" & _
              " left join (select p.customers_id,count(*) cpt from payment p  where p.payment_status not in (" & PaymentOfflineData.GetListClose() & ") group by p.customers_id) qty_paid on qty_paid.customers_id = c.customers_id " & _
              " set c.customers_abo_suspended = " & Suspended.OK & _
              " where c.customers_abo_suspended = " & Suspended.RECONDUCTION & " and c.customers_abo = " & abo.VALID & " and (payment_offline.customers_id is null and (qty_paid.cpt is null or qty_paid.cpt < 2)) "

        Return sql
    End Function
    Public Shared Function GetUpdateDvd_at_Home() As String
        Dim sql As String

        sql = " update customers c " & _
              " join ( select * from ( " & _
              "         select c.customers_id , customers_abo_dvd_home_norm ,  customers_abo_dvd_home_adult , " & _
              "         sum(if (products_type= '" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_NORM) & "', 1 , 0)) cpt_norm , sum(if (products_type= '" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_ADULT) & "', 1 , 0)) cpt_adult  " & _
              "         from customers c " & _
              "         left join orders o on o.customers_id = c.customers_id and " & _
              "                 o.orders_status in(" & clsOdersStatusHistory.OrderStatusNew.READY_FOR_EXPEDITION & "," & _
                               clsOdersStatusHistory.OrderStatusNew.EXPEDITED & ")" & _
              "         left join orders_products op on op.orders_id = o.orders_id " & _
              "         left join products p on p.products_id = op.products_id " & _
              "      group by c.customers_id ) xx " & _
              " where xx.customers_abo_dvd_home_norm <> cpt_norm or xx.customers_abo_dvd_home_adult <> cpt_adult)  tmp on tmp.customers_id = c.customers_id " & _
              " set c.customers_abo_dvd_home_norm = tmp.cpt_norm , c.customers_abo_dvd_home_adult = tmp.cpt_adult "

        Return sql

    End Function


#End Region


    'Public Shared Function getAmountCustomers() As String
    '    ' quel est sont utilite ?    
    '    ' _RecurringDate = DateAdd(DateInterval.Month, dr3("discount_recurring_nbr_of_month") + 1, Now())

    '    ' "insert into discount_use(discount_code_id , discount_use_date , customers_id)values('" & dr("customers_next_discount_code") & _
    '    '                          "', now(), '" & dr("customers_id") & "' )"


    '    ' sSQL4 = "UPDATE discount_code set discount_limit = discount_limit - 1 where discount_code_id = '" & dr("customers_next_discount_code") & "'"

    '    'sSQL2 = "insert into domiciliation_payment (domiciliation_payment_date, abo_id, customers_id, customers_name, customers_address, amount, strdomiciliation_debiter_name, strdomiciliation_number, reconduction)values(now(),'" & intmaxabo_id & "', '" & dr("customers_id") & "', '" & Replace(strcustomers_name, "'", "\'") & "', '" & Replace(strcustomers_addr_entry_street_address, "'", "\'") & "', '" & strtotal & "', '" & Replace(strdomiciliation_debiter_name, "'", "\'") & "' , '" & strdomiciliation_number & "' , 1 )"
    '    Return ""
    'End Function







    'Public Shared Function GetMatchingByAccountMovementOgone(ByVal customers_id As Integer) As String
    '    Dim sql As String

    '    sql = " select bam.* " & _
    '    " from bank_account_movements bam join ogone_payment op " & _
    '    " on bam.account_movements_id = op.account_movements_id " & _
    '    " where op.customers_id = " & customers_id
    '    Return sql

    'End Function






End Class
