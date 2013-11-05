Public Class clsEmailWishList
    Public Shared Function getCustAndCountWhislist() As String
        Dim sql As String
        sql = "SELECT C.customers_id , customers_gender, customers_firstname ,customers_lastname , email , " & _
                  " customers_abo , customers_abo_type, customers_abo_dvd_credit, customers_abo_dvd_norm, customers_abo_dvd_adult, " & _
                  " customers_abo_dvd_home_norm, customers_abo_dvd_home_adult " & _
          " , customers_next_abo_type, " & _
          " if (customers_abo_validityto = '0000-00-00', Null, customers_abo_validityto) as customers_abo_validityto,  " & _
          " if (customers_dob = '0000-00-00', Null, customers_dob) as customers_dob , " & _
          " C.customers_info_date_of_last_logon, C.customers_info_number_of_logons, C.customers_info_date_account_created, C.customers_info_date_account_last_modified, C.global_product_notifications, C.customers_language, C.site, C.partners_id, C.belgiqueloisirs_id, " & _
          " count(wl.wl_id) as wl_count " & _
          " FROM customers C " & _
          " LEFT JOIN wishlist wl on wl.customers_id = C.customers_id and wl.wishlist_type = '" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_NORM) & "' " & _
          " WHERE C.customers_abo = 1   GROUP BY C.customers_id"

        Return sql
    End Function



    Public Shared Function getSmtpServer() As String
        Dim sql As String
        sql = "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global' and Name = 'SMTPServer'"
        Return sql
    End Function

    Public Shared Function getServerLogin() As String
        Dim sql As String
        sql = "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global' and Name = 'SMTPServerLogin'"
        Return sql

    End Function

    Public Shared Function getServerPassWord() As String
        Dim sql As String
        sql = "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global' and Name = 'SMTPServerPassWord'"
        Return sql
    End Function

    Public Shared Function getLanguages() As String
        Dim sql As String
        sql = "SELECT * from languages "
        Return sql
    End Function

    Public Shared Function getProducts() As String
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
        " group by pd.products_id "
        Return sql
    End Function

    Public Shared Function getProductsCategory()
        Dim sql As String
        sql = " SELECT * from products_to_categories "
        Return sql
    End Function

End Class
