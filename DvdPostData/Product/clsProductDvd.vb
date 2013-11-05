Public Class clsProductDvd
#Region "Enum"

    Public Enum WHEREDVD
        STOCK = 1
        CUST_SERV = 2
        VOD_SERV = 3
        OUT = 4
    End Enum
    Public Enum BOXTYPE
        BROKEN = 80000
        DAMAGED = 70000
        BADLABEL = 60000
        BIZARREMENT_PERDU = 90000
        PREPFORSOLD = 22220
        SOLD = 23220
        CUSTSERV = 23300
        PURCHASE = 23400
        OUT = -100
        INVENTAIRE = 10000
        LOST_AFTER_INVENTORY = 10001
        VOD = 24220
        NOLOCATIVE = 25000
    End Enum
    Public Enum ProductStatus
        ok = 1
        NOStock = 0
        DisabledProvider = -1
        DisabledToPurchase = -2
    End Enum
    Public Enum DVDStatus
        DVD_STATUS_OK = 1
        DVD_STATUS_DAMAGED = 2
        DVD_STATUS_LOST = 3
        DVD_STATUS_BROKEN = 4
        DVD_STATUS_DELAYED = 5
        LOST_AND_CHARGED = 6
        MOVED_TO_FRANCE = 7
        MOVED_TO_NL = 8
        CANCEL = 9
        DVD_SOLD = 11
        DVD_GIVEN_IN_KDO = 12
        INTERCHANGE = 13
        PREP_FOR_SOLD = 14
        BIZARREMENT_PERDU = 15
        GIVEN_BACK_TO_STUDIO = 16
        LONGTIME_CUSTOMER = 17
        NON_LOCATIF = 18
        CUSTOMERS_SERVICE = 19
        IRREPARABLE = 20
        ENTRETIEN = 21
        INVENTAIRE = 22
        VOD = 23
        DVD_STATUS_BADLABEL = 24
        PURCHASE = 25
        LOST_AFTER_INVENTORY = 26
        PAID_BY_SUBSCRIPTION = 27

    End Enum
    Public Enum INOUT
        [OUT] = 0
        [IN] = 1
        [READYFOREXPEDITION] = 2
    End Enum
    Public Enum Type_DVD
        DVD_NORM
        DVD_ADULT
    End Enum
#End Region

#Region "Select"
    Private Shared Function GetSelectProductDisabled() As String
        Dim sql As String

        sql = " select c.customers_id,p.products_id,p.products_title,c.customers_firstname,c.customers_lastname,c.email,c.customers_language" & _
                " from products p " & _
                " join wishlist w on p.products_id = w.product_id " & _
                " join customers c on w.customers_id = c.customers_id " & _
                " where products_availability = " & ProductStatus.DisabledToPurchase & _
                " and c.customers_abo = " & ClsCustomersData.abo.VALID & " and products_type = '" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_NORM) & "' " & _
                " and not exists (select * from products_dvd pd " & _
                "                 where pd.products_dvd_status in (" & DVDStatus.DVD_STATUS_OK & _
                "                 ," & DVDStatus.ENTRETIEN & _
                "                 ," & DVDStatus.VOD & _
                "                 ," & DVDStatus.PURCHASE & _
                "                 ," & DVDStatus.DVD_STATUS_BADLABEL & ")" & _
                "                 and pd.products_id = p.products_id) "
        Return sql

    End Function
    Public Shared Function GetSelectProductStatusInventaire(ByVal box_id As Integer) As String

        Dim sql As String
        sql = "select * from products_dvd where box_id = " & box_id & " and products_dvd_status = " & DVDStatus.INVENTAIRE
        Return sql
    End Function
    Public Shared Function GetSelectProductDvdInBox(ByVal box_id As Integer) As String
        Dim sql As String

        sql = " SELECT PD.products_id, PD.products_dvdid, PDS.products_dvd_status_name, PD.box_id, PD.pibox_id, " & _
                               " P.products_model as products_model, PD.`inout` FROM products_dvd PD " & _
                               " Left join products P on P.products_id = PD.products_id " & _
                               " left join products_dvd_status PDS on PDS.products_dvd_status_id=PD.products_dvd_status" & _
                               " where PD.box_id = " & box_id & " Order by pibox_id "

        Return sql
    End Function
    Public Shared Function GetSelectProductDvdInBoxClean(ByVal box_id As Integer) As String
        Dim sql As String

        sql = " SELECT PD.products_id, PD.products_dvdid, PDS.products_dvd_status_name, PD.box_id, PD.pibox_id, " & _
                               " P.products_model as products_model, PD.`inout` FROM products_dvd PD " & _
                               " Left join products P on P.products_id = PD.products_id " & _
                               " left join products_dvd_status PDS on PDS.products_dvd_status_id=PD.products_dvd_status" & _
                               " where PD.box_id = " & box_id & " Order by pibox_id "

        Return sql
    End Function
    Public Shared Function GetSelectWhereStatusProducts(ByVal productId As Integer, Optional ByVal productDVDId As Integer = 0) As String

        Dim sql As String
        Dim sqlDvdId As String = ""
        If productDVDId > 0 Then
            sqlDvdId = " AND PD.products_dvdid = " & productDVDId
        End If
        sql = "SELECT PD.`inout`,PD.box_id,PD.pibox_id,pds.products_dvd_status_name " & _
               " FROM products_dvd PD " & _
               " join products_dvd_status pds on PD.products_dvd_status = pds.products_dvd_status_id" & _
               " where PD.products_id = " & productId & sqlDvdId & " and box_id <> " & PlushData.clsProductDvd.BOXTYPE.LOST_AFTER_INVENTORY & _
               " order by box_id "

        Return sql
    End Function
    Public Shared Function GetSelectProductDvd(ByVal productId As Integer, ByVal productDVDId As Integer) As String

        Dim sql As String

        sql = "SELECT PD.products_id, PD.products_dvdid, PD.products_dvd_status, PD.box_id, PD.pibox_id, " & _
                        " P.products_model as products_model, PD.stock_type as stock_type, PD.`inout` FROM products_dvd PD " & _
                        " Left join products P on P.products_id = PD.products_id " & _
                        " where PD.products_id = " & productId & " AND PD.products_dvdid = " & productDVDId



        Return sql
    End Function
    Public Shared Function GetSelectWishlistCustomerProduct(ByVal products_id As Integer) As String
        Dim sql As String

        'sql = "select c.customers_id,c.customers_language,c.customers_lastname,c.customers_firstname, c.customers_abo, w.priority" & _
        '",(select count(*) from wishlist ww join products p on ww.product_id = p.products_id where ww.customers_id = w.customers_id and p.products_next = 0 and p.products_series_id = 0) nb_dvdNorm " & _
        '",(select count(*) from wishlist ww join products p on ww.product_id = p.products_id where ww.customers_id = w.customers_id and p.products_next = 0 and p.products_series_id > 0) nb_dvdSeries " & _
        '",(select count(*) from wishlist ww join products p on ww.product_id = p.products_id where ww.customers_id = w.customers_id and p.products_next = 1) nb_dvdNext " & _
        '",(select count(*) from vod_wishlists where customer_id = w.customers_id) nb_vodwishlist " & _
        '",(select count(*) from wishlist ww  join customers c on ww.customers_id = c.customers_id " & _
        '"    where c.customers_abo in (" & ClsCustomersData.abo.VALID & ", " & ClsCustomersData.abo.UNVALID & ") and c.customers_abo_suspended <> " & ClsCustomersData.Suspended.RECONDUCTION & _
        '"    and ww.product_id = " & products_id & " and ww.priority = 1) cutomers_high" & _
        '",(select count(*) from products_dvd pd where pd.products_dvd_status = 1 and pd.products_id = " & products_id & ") dvd_ok" & _
        '" from customers c " & _
        '" join wishlist w on w.customers_id = c.customers_id " & _
        '" where c.customers_abo in (" & ClsCustomersData.abo.VALID & ", " & ClsCustomersData.abo.UNVALID & ") And c.customers_abo_suspended <> " & ClsCustomersData.Suspended.RECONDUCTION & " And product_id = " & products_id

        sql = "select c.customers_id,c.customers_language,c.customers_lastname,c.customers_firstname, " & _
        " CASE WHEN c.customers_abo = 1 and c.customers_abo_suspended in(0, 1) THEN 'Active' " & _
" WHEN c.customers_abo = 1 AND c.customers_abo_suspended = 2 THEN 'Not Active' " & _
" WHEN c.customers_abo = 0 THEN 'Not Active' " & _
" END customer_activity " & _
", w.priority" & _
",(select count(*) from wishlist ww join products p on ww.product_id = p.products_id where ww.customers_id = w.customers_id and p.products_next = 0 and p.products_series_id = 0) nb_dvdNorm " & _
",(select count(*) from wishlist ww join products p on ww.product_id = p.products_id where ww.customers_id = w.customers_id and p.products_next = 0 and p.products_series_id > 0) nb_dvdSeries " & _
",(select count(*) from wishlist ww join products p on ww.product_id = p.products_id where ww.customers_id = w.customers_id and p.products_next = 1) nb_dvdNext " & _
",(select count(*) from vod_wishlists where customer_id = w.customers_id) nb_vodwishlist " & _
",(select count(*) from wishlist ww  join customers c on ww.customers_id = c.customers_id " & _
"    where  customers_abo = 1 and customers_abo_suspended <> 2 and ww.product_id = " & products_id & " and ww.priority = 1) cutomers_active_high" & _
",(select count(*) from wishlist ww  join customers c on ww.customers_id = c.customers_id " & _
"    where  ( customers_abo = 0 or customers_abo_suspended = 2 ) and ww.product_id = " & products_id & " and ww.priority = 1) cutomers_notactive_high" & _
",(select count(*) from products_dvd pd where pd.products_dvd_status = 1 and pd.products_id = " & products_id & ") dvd_ok" & _
" from customers c " & _
" join wishlist w on w.customers_id = c.customers_id " & _
" where product_id = " & products_id

        Return sql

    End Function
    Public Shared Function GetSelectVod(ByVal products_id As Integer) As String
        Dim sql As String
        sql = " select group_concat(pl.short_alpha, ',') languages, group_concat(pu.short_alpha) " & _
        " from products p join streaming_products sp on p.imdb_id = sp.imdb_id " & _
        " left join products_languages pl on sp1.language_id = pl.languages_id and pl.languagenav_id = 1 " & _
        " left join products_undertitles pu on sp.subtitle_id = pu.undertitles_id and pu.language_id = 1 " & _
        " where p.products_id = " & products_id

        Return sql

    End Function

    Public Shared Function GetSelectCountDVDByBox(ByVal box_id As Integer, ByVal inout As Integer) As String
        Dim sql As String
        sql = " select count(*) from products_dvd pd where pd.box_id = " & box_id & "  and pd.inout = " & inout
        Return sql
    End Function
    Public Shared Function GetSelectListActors(ByVal products_id As Integer) As String

        Dim sql As String
        sql = " select pa.products_id, pa.actors_id, a.actors_name,d.directors_id,d.directors_name " & _
              " from products_to_actors pa  " & _
              " join products p on pa.products_id = p.products_id " & _
              " left join actors a on a.actors_id = pa.actors_id " & _
              " left join directors d on d.directors_id = p.products_directors_id " & _
              " WHERE pa.products_id = " & products_id
        Return sql
    End Function
    Public Shared Function GetSelectPicturesDVD(ByVal products_id As Integer) As String
        Dim sql As String

        sql = " select p.products_id , count(pd.products_id) as cnt_dvd , " & _
       " pdesc_fr.products_image_big as image_fr, pdesc_fr.products_name as name_fr, " & _
       " pdesc_nl.products_image_big as image_nl, pdesc_nl.products_name as name_nl, " & _
       " pdesc_en.products_image_big as image_en, pdesc_en.products_name as name_en, '' as categories " & _
       " from products p " & _
       " left join products_dvd pd on pd.products_id = p.products_id " & _
       " left join products_description pdesc_fr on pdesc_fr.products_id = p.products_id and pdesc_fr.language_id = 1 " & _
       " left join products_description pdesc_nl on pdesc_nl.products_id = p.products_id and pdesc_nl.language_id = 2 " & _
       " left join products_description pdesc_en on pdesc_en.products_id = p.products_id and pdesc_en.language_id = 3 " & _
       " WHERE p.products_id = " & products_id & _
       " and (p.rating_users / p.rating_count) >= 3 " & _
       " group by pd.products_id "
        Return sql

    End Function
    Public Shared Function GetSelectPicturesDVD() As String
        Dim sql As String

        sql = " select p.products_id , count(pd.products_id) as cnt_dvd , " & _
       " pdesc_fr.products_image_big as image_fr, pdesc_fr.products_name as name_fr, " & _
       " pdesc_nl.products_image_big as image_nl, pdesc_nl.products_name as name_nl, " & _
       " pdesc_en.products_image_big as image_en, pdesc_en.products_name as name_en, '' as categories " & _
       " from products p " & _
       " left join products_dvd pd on pd.products_id = p.products_id " & _
       " left join products_description pdesc_fr on pdesc_fr.products_id = p.products_id and pdesc_fr.language_id = 1 " & _
       " left join products_description pdesc_nl on pdesc_nl.products_id = p.products_id and pdesc_nl.language_id = 2 " & _
       " left join products_description pdesc_en on pdesc_en.products_id = p.products_id and pdesc_en.language_id = 3 " & _
       " WHERE pd.products_dvd_status = 1 and pd.`inout` = 1 and p.products_status = 1 and p.products_type = '" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_NORM) & "' " & _
       " and (p.rating_users / p.rating_count) >= 3 " & _
       " group by pd.products_id order by rand() limit 7 "
        Return sql

    End Function
    Public Shared Function GetSelectProductsDvdToManualAssign(ByVal products_id As Integer) As String
        Dim sql As String
        sql = "select products_dvdid from products_dvd where products_id = " & products_id & _
              " and products_dvd_status = " & DVDStatus.DVD_STATUS_OK & "  and `inout` = " & INOUT.IN & " order by box_id asc limit 1"
        Return sql


    End Function

#Region "Search"

    Private Shared Function SearchThemeCondition(ByVal theme_id As Integer) As String
        Dim sql As String

        If theme_id = 0 Then
            sql = ""
        Else
            sql = " and ptt.themes_id = " & theme_id
        End If

        Return sql

    End Function
    Private Shared Function SearchThemeTable(ByVal theme_id As Integer) As String
        Dim sql As String

        If theme_id = 0 Then
            sql = ""
        Else
            sql = " join products_to_themes ptt on p.products_id = ptt.products_id "
        End If


        Return sql

    End Function

    Private Shared Function SearchCategorieCondition(ByVal categorie_id As Integer) As String
        Dim sql As String

        If categorie_id = 0 Then
            sql = ""
        Else
            sql = " and ptc.categories_id = " & categorie_id
        End If

        Return sql

    End Function
    Private Shared Function SearchCategorieTable(ByVal categorie_id As Integer) As String
        Dim sql As String

        If categorie_id = 0 Then
            sql = ""
        Else
            sql = " join products_to_categories ptc on p.products_id = ptc.products_id "
        End If


        Return sql

    End Function

    Private Shared Function SearchActorCondition(ByVal actor_id As Integer) As String
        Dim sql As String

        If actor_id = 0 Then
            sql = ""
        Else
            sql = " and pta.actors_id = " & actor_id
        End If

        Return sql

    End Function
    Private Shared Function SearchDirectorCondition(ByVal director_id As Integer) As String
        Dim sql As String

        If director_id = 0 Then
            sql = ""
        Else
            sql = " and p.products_directors_id = " & director_id
        End If

        Return sql

    End Function

    Private Shared Function SearchActorTable(ByVal actor_id As Integer) As String
        Dim sql As String

        If actor_id = 0 Then
            sql = ""
        Else
            sql = " join products_to_actors pta on p.products_id = pta.products_id "
        End If


        Return sql

    End Function

    Private Shared Function SearchDirectorTable(ByVal actor_id As Integer) As String
        Dim sql As String

        If actor_id = 0 Then
            sql = ""
        Else
            sql = " join directors dir on p.products_directos_id = dir.directors_id "
        End If


        Return sql

    End Function



    Private Shared Function SearchLangCondition(ByVal lang_id As Integer) As String
        Dim sql As String

        If lang_id = 0 Then
            sql = ""
        Else
            sql = " and ptl.products_languages_id = " & lang_id
        End If

        Return sql

    End Function
    Private Shared Function SearchLangTable(ByVal lang_id As Integer) As String
        Dim sql As String

        If lang_id = 0 Then
            sql = ""
        Else
            sql = " join products_to_languages ptl on p.products_id = ptl.products_id "
        End If


        Return sql

    End Function

    Private Shared Function SearchSubtitleCondition(ByVal Subtitle_id As Integer) As String
        Dim sql As String

        If Subtitle_id = 0 Then
            sql = ""
        Else
            sql = " and ptu.products_undertitles_id = " & Subtitle_id
        End If

        Return sql

    End Function
    Private Shared Function SearchSubtitleTable(ByVal subtitle_id As Integer) As String
        Dim sql As String

        If subtitle_id = 0 Then
            sql = ""
        Else
            sql = " join products_to_undertitles ptu on p.products_id = ptu.products_id "
        End If


        Return sql

    End Function

    Private Shared Function SearchSerieCondition(ByVal serie_id As Integer) As String
        Dim sql As String

        If serie_id = 0 Then
            sql = ""
        Else
            sql = " and p.products_series_id = " & serie_id
        End If

        Return sql

    End Function
    Private Shared Function SearchStudioCondition(ByVal studio_id As Integer) As String
        Dim sql As String

        If studio_id = 0 Then
            sql = ""
        Else
            sql = " and p.products_studio = " & studio_id
        End If

        Return sql

    End Function
    Private Shared Function SearchStatusCondition(ByVal status_id As Integer) As String
        Dim sql As String

        If status_id = -4 Then
            sql = ""
        Else
            sql = " and p.products_status = " & status_id
        End If

        Return sql

    End Function
    Private Shared Function SearchAvailabilityCondition(ByVal availability_id As Integer) As String
        Dim sql As String

        If availability_id = -4 Then
            sql = ""
        Else
            sql = " and p.products_availability = " & availability_id
        End If

        Return sql

    End Function
    Private Shared Function SearchProductNextCondition(ByVal product_next As Object) As String
        Dim sql As String

        If product_next = 2 Then
            sql = ""
        Else
            sql = " and p.products_next = " & (product_next = 1).ToString()
        End If

        Return sql

    End Function
    Private Shared Function SearchRatingCondition(ByVal rating As String) As String
        Dim sql As String

        If rating = String.Empty Then
            sql = ""
        Else
            sql = " and p.products_rating = " & rating
        End If

        Return sql

    End Function
    Private Shared Function SearchProductsTypeCondition(ByVal product_type As String) As String
        Dim sql As String

        If product_type = String.Empty Then
            sql = ""
        Else
            sql = " and p.products_type = '" & product_type & "'"
        End If

        Return sql

    End Function
    Private Shared Function SearchProductsMediaCondition(ByVal product_media As String) As String
        Dim sql As String

        If product_media = String.Empty Then
            sql = ""
        Else
            sql = " and p.products_media = '" & product_media & "'"
        End If

        Return sql

    End Function

    Private Shared Function SearchDateCreatedCondition(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String

        If dateFrom = String.Empty Then
            sql = ""
        Else
            sql = " and  date(p.products_date_added) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "'"
        End If


        If dateTo = String.Empty Then
            sql += ""
        Else
            sql += " and  date(p.products_date_added) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'"
        End If

        Return sql

    End Function

    Public Shared Function getSelectSearchViewProduct(ByVal categorie_id As Integer, _
                                             ByVal theme_id As Integer, _
                                             ByVal status As Integer, _
                                             ByVal availability As Integer, _
                                             ByVal serie_id As Integer, _
                                             ByVal studio_id As Integer, _
                                             ByVal language_id As Integer, _
                                             ByVal subtitle_id As Integer, _
                                             ByVal actor_id As Integer, _
                                             ByVal director_id As Integer, _
                                             ByVal rating As String, _
                                             ByVal product_type As String, _
                                             ByVal product_media As String, _
                                             ByVal product_next As Object, _
                                             ByVal dateFrom As String, _
                                             ByVal dateTo As String, _
                                             ByVal cust_active As String) As String

        Dim sql As String
        '& ClsCustomersData.abo.VALID & 
        '", (select count(*) from wishlist ww  join customers c on ww.customers_id = c.customers_id " & _
        '      "    where c.customers_abo = " & ClsCustomersData.abo.UNVALID & "  or c.customers_abo_suspended = " & ClsCustomersData.Suspended.RECONDUCTION & _
        '      "    and ww.product_id = p.products_id  and ww.priority = 1) cutomers_notactive_high " & _

        sql = "select p.*,pde.products_name,pdvd.cpt_dvd,w.cpt_cust " & _
      ",(select count(*) from wishlist ww  join customers c on ww.customers_id = c.customers_id " & _
      "    where " & cust_active & _
      "    and ww.product_id = p.products_id  and ww.priority = 1) cutomers_high " & _
      ", ( select count(*) from wishlist ww  join customers c on ww.customers_id = c.customers_id " & _
      " where c.customers_abo = 1 and c.customers_abo_suspended in(0,1) and ww.product_id = p.products_id) customers_active " & _
      ", ( select count(*) from wishlist ww  join customers c on ww.customers_id = c.customers_id " & _
      " where ((c.customers_abo = 1 and c.customers_abo_suspended = 2 ) or c.customers_abo = 0  )and ww.product_id = p.products_id) customers_not_active " & _
      ", ( select if(count(*)>0,1,0) from dvdpost_be_prod.streaming_products sp where p.imdb_id = sp.imdb_id and sp.source = 'ALPHANETWORKS' and sp.status = 'online_test_ok' and ((sp.expire_at > sysdate() and sp.available_from < sysdate()) or ( sp.available_backcatalogue_from < sysdate() and sp.expire_backcatalogue_at > sysdate() ) ) ) vod_exists " & _
      " from products p " & _
              " join products_description pde on p.products_id = pde.products_id and pde.language_id = 1 " & _
              " left join (select products_id,count(*) cpt_dvd from products_dvd pd where pd.products_dvd_status = 1 group by products_id) pdvd on p.products_id = pdvd.products_id " & _
              " left join (select w.product_id,count(*) cpt_cust from wishlist w " & _
              " join customers c on w.customers_id = c.customers_id where c.customers_abo = 1 and c.customers_abo_suspended = 0 group by w.product_id) w on p.products_id = w.product_id " & _
               SearchCategorieTable(categorie_id) & _
               SearchThemeTable(theme_id) & _
               SearchActorTable(actor_id) & _
               SearchDirectorTable(actor_id) & _
               SearchLangTable(language_id) & _
               SearchSubtitleTable(subtitle_id) & _
               " where p.products_type in ('" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_NORM) & "','" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_ADULT) & "')" & _
               SearchCategorieCondition(categorie_id) & _
               SearchThemeCondition(theme_id) & _
               SearchActorCondition(actor_id) & _
               SearchDirectorCondition(director_id) & _
               SearchLangCondition(language_id) & _
               SearchSubtitleCondition(subtitle_id) & _
               SearchSerieCondition(serie_id) & _
               SearchStudioCondition(studio_id) & _
               SearchStatusCondition(status) & _
               SearchAvailabilityCondition(availability) & _
               SearchProductNextCondition(product_next) & _
               SearchRatingCondition(rating) & _
               SearchProductsMediaCondition(product_media) & _
               SearchProductsTypeCondition(product_type) & _
               SearchDateCreatedCondition(dateFrom, dateTo)


        Return sql

    End Function
#End Region
#Region "Entity"

    Public Shared Function GetSelectCategorie(ByVal products_type As String, Optional ByVal language_id As Integer = 1) As String
        Dim sql As String
        sql = " select cd.categories_id id,cd.categories_name name " & _
              " from categories c join categories_description cd on c.categories_id = cd.categories_id " & _
              " where c.categories_type = '" & products_type & "' and language_id = " & language_id
        Return sql
    End Function

    Public Shared Function GetSelectTheme(ByVal products_type As String, Optional ByVal language_id As Integer = 1) As String
        Dim sql As String
        sql = " select td.themes_id id,td.themes_name name " & _
              " from themes t join themes_description td on t.themes_id = td.themes_id " & _
              " where t.themes_type = '" & products_type & "' and td.language_id = " & language_id
        Return sql
    End Function

    Public Shared Function GetSelectStatus() As String
        Dim sql As String
        sql = " SELECT codevalue id, codedesc name from generalglobalcode where CodeType = 'Products_Status'"
        Return sql
    End Function

    Public Shared Function GetSelectType() As String
        Dim sql As String
        sql = " SELECT CodeValue id, CodeDesc name from generalglobalcode where CodeType = 'Products_type'"
        Return sql
    End Function

    Public Shared Function GetSelectMedia() As String
        Dim sql As String
        sql = " SELECT CodeValue id, CodeDesc name from generalglobalcode where CodeType = 'Products_media'"
        Return sql
    End Function


    Public Shared Function GetSelectAvailability() As String
        Dim sql As String
        sql = " SELECT CodeValue id, CodeDesc name from generalglobalcode where CodeType = 'Products_Availability'"
        Return sql
    End Function

    Public Shared Function GetSelectRating() As String
        Dim sql As String
        sql = " SELECT CodeValue id, CodeDesc name from generalglobalcode where CodeType = 'Products_Rating'"
        Return sql
    End Function

    Public Shared Function GetSelectActor(ByVal products_type As String) As String
        Dim sql As String
        sql = " SELECT actors_id id,actors_name name FROM actors " & _
              " where actors_type = '" & products_type & "' order by actors_name "
        Return sql
    End Function

    Public Shared Function GetSelectStudio() As String
        Dim sql As String
        sql = " SELECT studio_id id,studio_name name FROM studio order by studio_name "
        Return sql
    End Function

    Public Shared Function GetSelectDirector() As String
        Dim sql As String
        sql = " SELECT directors_id id,directors_name name FROM directors order by directors_name "
        Return sql
    End Function

    Public Shared Function GetSelectSerie() As String
        Dim sql As String
        sql = " SELECT series_id id,series_name name FROM series order by series_name "
        Return sql
    End Function

#End Region


#End Region

#Region "Update"
    ''' <summary>
    '''  compte le nombre de dvd encore physiquement en etat pour ce titre 
    ''' si il n'y en a plus alors passer le status du product a -1 pour les products qui etaient a -2 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetUpdateStepProductDisabled() As String
        Dim sql As String
        sql = " update (" & _
                " select p.products_id, " & _
                " (select count(*) from products_dvd pd where " & _
                "                   pd.products_dvd_status in (" & DVDStatus.DVD_STATUS_OK & _
                "                                               ," & DVDStatus.VOD & _
                "                                               ," & DVDStatus.ENTRETIEN & _
                "                                               ," & DVDStatus.CUSTOMERS_SERVICE & _
                "                                               ," & DVDStatus.DVD_STATUS_BADLABEL & _
                " ) and pd.products_id = p.products_id) cpt_ok from products p " & _
                "        where(products_status = " & ProductStatus.DisabledToPurchase & ") " & _
                " ) pd " & _
                " join products p on pd.products_id = p.products_id " & _
                " set p.products_status = " & ProductStatus.DisabledProvider & " , p.date_disabled = now() " & _
                "     where(pd.cpt_ok = 0)"

        Return sql
    End Function
    Public Shared Function GetUpdateStatusProducts() As String
        Dim sql As String

        sql = " update products p join ( " & _
              "   select * from ( " & _
              "     select p.products_id,(select count(*) from products_dvd pd where pd.products_id = p.products_id and pd.products_dvd_status = 1) cpt " & _
              "     from products p " & _
              "   where products_availability in (-1,0)) xx " & _
              " where xx.cpt > 0 ) xxx on p.products_id = xxx.products_id " & _
              " set p.products_availability = 1 "
        Return sql
    End Function
    Public Shared Function GetUpdateDVDpos(ByVal productId As Integer, ByVal productDVDId As Integer, ByVal posbox_id As Integer) As String
        Dim sql As String

        sql = "UPDATE products_dvd set pibox_id = " & posbox_id & " where products_id = " & productId & _
                      " AND products_dvdid = " & productDVDId
        Return sql

    End Function

    Public Shared Function GetUpdateRenumberPiboxProductdvd(ByVal box_id As Integer, ByVal pibox_id As Integer)
        Dim sql As String
        sql = "update products_dvd pdvd set pibox_id = pibox_id -1 1 where box_id = '" & box_id & _
                        "' and pibox_id > '" & pibox_id & "'and pdvd.inout = 1 and products_dvd_status = 1 order by pibox_id asc "
        Return sql
    End Function
    Public Shared Function GetUpdateBoxPiboxStatus(ByVal productsId As Integer, ByVal productDVDId As Integer, ByVal status As Integer, ByVal inout As Integer, _
                                                   ByVal box_id As Integer, ByVal pibox_id As Integer, ByVal userId As Integer) As String
        Dim sql As String
        sql = "update products_dvd pd set pd.box_id = " & box_id & "  , pd.pibox_id = '" & pibox_id & "', pd.inout=  " & inout & " , " & _
              " pd.products_dvd_status = " & status & " ,pd.last_admindate = now(),pd.last_adminby = " & userId & _
              " where pd.products_id = " & productsId & " and pd.products_dvdid=" & productDVDId & " "
        Return sql
    End Function
    Public Shared Function GetUpdateQuantityDVDInStock() As String
        Dim sql As String
        sql = "update products p set p.products_quantity = (select count(*) from products_dvd pd where pd.products_id = p.products_id and pd.inout = " & INOUT.IN & " and pd.products_dvd_status = " & DVDStatus.DVD_STATUS_OK & ") "
        Return sql
    End Function

#End Region

#Region "Insert"

    Public Shared Function getInsertAvailabilityProducts() As String
        Dim sql As String

        sql = " truncate table products_availability;" & _
              " insert products_availability  " & _
              "       select xx.products_id,if(wl_cust > 0,(products_quantity/wl_cust),products_quantity) ratio,now(),now() from " & _
              "       ( " & _
              "           select p.products_id,p.products_quantity,(select count(*) from wishlist w " & _
              "                                                                     join customers c on c.customers_id = w.customers_id " & _
              "                                                                     where c.customers_abo = 1 and w.product_id = p.products_id and w.priority = 1) wl_cust " & _
              "           from products p " & _
              "       ) xx "


        Return sql
    End Function

#End Region




End Class
