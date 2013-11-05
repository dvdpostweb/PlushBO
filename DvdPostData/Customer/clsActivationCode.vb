Public Class clsActivationCode


    Public Shared productsTypeAbo As String = "ABO"
    Public Shared productsTypeDvd As String = "DVD"
    Public Const NEWDISCOUNT As String = "NEW DISCOUNT"
    Public Const FOOTER As String = "FREETRIAL"


    Public Const COMBINEDACTIONYES As String = "YES"
    Public Const COMBINEDACTIONNO As String = "NO"


    Public Shared Function GetActivationGroup() As String
        Dim sql As String
        sql = "SELECT * FROM activation_group"
        Return sql
    End Function



    Public Shared Function GetProducts(ByVal productsType As String) As String
        Dim sql As String
        sql = "SELECT products_id, products_model , products_title FROM products where products_type = '" & productsType & "' order by products_id desc"
        Return sql
    End Function


    Public Shared Function GetActivationValidityType() As String
        Dim sql As String
        sql = "SELECT * FROM  activation_validity_type"
        Return sql
    End Function

    


    Public Shared Function insertActivationCode(ByVal _ActivationCode As String, ByVal activation_type As Integer, _
                                                ByVal activation_value As Decimal, ByVal group As Integer, ByVal _ActivationGroupID As Integer, _
                                                ByVal _ValidToStr As String, ByVal cmbProductsID As Integer, ByVal ValidType As Integer, _
                                                ByVal ValidValue As Integer, ByVal chkWaranty As Integer, ByVal txtComment As String, _
                                                ByVal _NextDiscountCodeID As Integer, ByVal chkAuto_Stop_at_Next_Reconduction As Integer, ByVal NextAboType As Integer, _
                                                ByVal txtBanner As String, ByVal txtDescFR As String, ByVal txtDescNL As String, ByVal txtDescEN As String, _
                                                ByVal chkFree_Upgrade_Allowed As Integer, ByVal txtFooter As String, ByVal txtCampaign As String, _
                                                ByVal combinetActi As String, _
                                                ByVal paypal As Integer, _
                                                ByVal creditcard As Integer, _
                                                ByVal debitcard As Integer, _
                                                ByVal discount_action As String) As String

        txtComment = replaceSingleCote(txtComment)
        txtDescFR = replaceSingleCote(txtDescFR)
        txtDescNL = replaceSingleCote(txtDescNL)
        txtDescEN = replaceSingleCote(txtDescEN)
        txtFooter = replaceSingleCote(txtFooter)
        txtCampaign = replaceSingleCote(txtCampaign)

        If _ValidToStr <> "" Then
            _ValidToStr = " '" & PlushTools.ClsDate.formatDate(_ValidToStr) & "' "
        Else
            _ValidToStr = " DEFAULT(activation_code_validto_date) "
        End If


        Dim sql As String
        sql = "INSERT INTO activation_code (activation_code, campaign_id, activation_type, activation_value, activation_group,activation_group_id , " & _
                                            "activation_code_creation_date, activation_code_validto_date , activation_products_id , " & _
                                            "validity_type ,validity_value ,activation_waranty ,comment, " & _
                                            "next_discount , abo_auto_stop_next_reconduction , banner , activation_text_fr , " & _
                                            "activation_text_nl ,activation_text_en , free_upgrade_allowed ,footer ,campaign ,combined_action, next_abo_type, " & _
                                            "paypal, creditcard, debitcard, discount_action) values " & _
                                            "  ('" & _ActivationCode & "'" & _
                      " ,0 " & _
                      " , " & activation_type & _
                      " , " & PlushTools.ClsPrice.FormatPrice(activation_value) & _
                      " , " & group & _
                      " , " & _ActivationGroupID & _
                      " , now() " & _
                      " , " & _ValidToStr & _
                      " , " & cmbProductsID & _
                      " , " & ValidType & ", " & ValidValue & _
                      " , " & chkWaranty & _
                      " , '" & txtComment & "'" & _
                      " , " & _NextDiscountCodeID & _
                      " , " & chkAuto_Stop_at_Next_Reconduction & _
                      " , '" & txtBanner & "' " & _
                      " , '" & txtDescFR & "' " & _
                      " , '" & txtDescNL & "' " & _
                      " , '" & txtDescEN & "' " & _
                      " , " & chkFree_Upgrade_Allowed & _
                      " , '" & txtFooter & "' " & _
                      " , '" & txtCampaign & "' " & _
                      " , '" & combinetActi & "' " & _
                      " , " & NextAboType & _
                      " , " & paypal & _
                      " , " & creditcard & _
                      " , " & debitcard & _
                      " , '" & discount_action & "' )"


        Return sql
    End Function


    Public Shared Function updateActivationBYCust(ByVal customers_id As Integer, ByVal Activation_id As Integer, ByVal validityTo As String) As String
        Dim sql As String


        If validityTo <> "" Then
            validityTo = " '" & PlushTools.ClsDate.formatDate(validityTo) & "' "
        Else
            validityTo = " NULL "
        End If

        sql = "update activation_code set  activation_code_validto_date = " & validityTo & " where customers_id = " & customers_id & " and activation_id = " & Activation_id
        Return sql
    End Function


    Public Shared Function updateActivation(ByVal group As Integer, ByVal activation_type As Integer, _
                                                ByVal activation_value As Decimal, ByVal _activationGroupID As Integer, _
                                                ByVal ValidToStr As String, ByVal productsID As Integer, ByVal ValidType As Integer, _
                                                ByVal ValidValue As Integer, ByVal chkWaranty As Integer, ByVal Comment As String, _
                                                ByVal nextDiscountCodeId As Integer, ByVal chkAuto_Stop_at_Next_Reconduction As Integer, _
                                                ByVal banner As String, ByVal txtDescFR As String, ByVal txtDescNL As String, ByVal txtDescEN As String, _
                                                ByVal chkFree_Upgrade_Allowed As Integer, ByVal txtFooter As String, ByVal txtCampaign As String, _
                                                ByVal combinetActi As String, ByVal activation_code_cretion_date As String, ByVal activation_code_condition As String, ByVal next_abotype As Integer, _
                                                ByVal paypal As Integer, _
                                                ByVal creditcard As Integer, _
                                                ByVal debitcard As Integer, _
                                                ByVal discount_action As String) As String
        Comment = replaceSingleCote(Comment)
        txtDescFR = replaceSingleCote(txtDescFR)
        txtDescNL = replaceSingleCote(txtDescNL)
        txtDescEN = replaceSingleCote(txtDescEN)
        txtFooter = replaceSingleCote(txtFooter)
        txtCampaign = replaceSingleCote(txtCampaign)

        If ValidToStr <> "" Then
            ValidToStr = " '" & PlushTools.ClsDate.formatDate(ValidToStr) & "' "
        Else
            ValidToStr = " NULL "
        End If

        Dim sql As String
        sql = "update activation_code set  activation_type = " & activation_type & _
              " , activation_value = " & PlushTools.ClsPrice.FormatPrice(activation_value) & _
              " ,activation_group = " & group & _
              " ,activation_code_validto_date = " & ValidToStr & _
              " ,activation_products_id = " & productsID & _
              " , validity_type = " & ValidType & _
              " , validity_value = " & ValidValue & _
              " , activation_waranty = " & chkWaranty & _
              " , comment = '" & Comment & "' " & _
              " , next_discount = " & nextDiscountCodeId & _
              " , abo_auto_stop_next_reconduction = " & Math.Abs(chkAuto_Stop_at_Next_Reconduction) & _
              " , banner = '" & banner & "' " & _
              " , activation_text_fr = '" & txtDescFR & "' " & _
              " , activation_text_nl = '" & txtDescNL & "' " & _
              " , activation_text_en = '" & txtDescEN & "' " & _
              " , free_upgrade_allowed = " & chkFree_Upgrade_Allowed & _
              " , footer = '" & txtFooter & "' " & _
              " , combined_action = '" & combinetActi & "' " & _
              ", next_abo_type = " & next_abotype & _
              " , paypal = " & paypal & _
              " , creditcard = " & creditcard & _
              " , debitcard = " & debitcard & _
              " , discount_action = '" & discount_action & "' " & _
              "  where DATE(activation_code_creation_date) = '" & PlushTools.ClsDate.formatDate(activation_code_cretion_date) & "' " & _
              "  and  customers_id = 0 and activation_code like '" & activation_code_condition & "%' " & _
              "  and  campaign = '" & txtCampaign & "' "

        Return sql
    End Function

    'Public Shared Function GetValueInsert(ByVal _ActivationCode As String, ByVal group As Integer, ByVal _ActivationGroupID As Integer, _
    '                                            ByVal _CreationDateStr As String, _
    '                                            ByVal _ValidToStr As String, ByVal cmbProductsID As Integer, ByVal ValidType As Integer, _
    '                                            ByVal ValidValue As Integer, ByVal chkWaranty As Integer, ByVal txtComment As String, _
    '                                            ByVal DVDCredit As Integer, ByVal _NextDiscountCodeID As Integer, ByVal chkAuto_Stop_at_Next_Reconduction As Integer, _
    '                                            ByVal txtBanner As String, ByVal txtDescFR As String, ByVal txtDescNL As String, ByVal txtDescEN As String, _
    '                                            ByVal chkFree_Upgrade_Allowed As Integer, ByVal txtFooter As String, ByVal txtCampaign As String, _
    '                                            ByVal combinetActi As String) As String
    '    Dim value As String
    '    value = "  ('" & _ActivationCode & "'" & _
    '                  " ,0 " & _
    '                  " , " & group & _
    '                  " , " & _ActivationGroupID & _
    '                  " , '" & _CreationDateStr & "'" & _
    '                  " , '" & _ValidToStr & "'" & _
    '                  " , " & cmbProductsID & _
    '                  " , " & ValidType & ", " & ValidValue & _
    '                  " , " & chkWaranty & _
    '                  " , '" & txtComment & "'" & _
    '                  " , " & DVDCredit & _
    '                  " , " & _NextDiscountCodeID & _
    '                  " , " & chkAuto_Stop_at_Next_Reconduction & _
    '                  " , '" & txtBanner & "' " & _
    '                  " , '" & txtDescFR & "' " & _
    '                  " , '" & txtDescNL & "' " & _
    '                  " , '" & txtDescEN & "' " & _
    '                  " , " & chkFree_Upgrade_Allowed & _
    '                  " , '" & txtFooter & "' " & _
    '                  " , '" & txtCampaign & "' " & _
    '                  " , '" & combinetActi & "') "
    '    Return value

    'End Function


    Public Shared Function getActivationGroupId(ByVal cmbGroup As Integer) As String
        Dim sql As String
        sql = "SELECT activation_group_id FROM activation_code a where activation_group = " & cmbGroup & " order by activation_group_id desc limit 1; "
        Return sql
    End Function

    Public Shared Function GetActivationCode() As String
        Dim sql As String
        sql = "select activation_code from activation_code"
        Return sql
    End Function

    'Public Shared Function GetActivationWithPrefixe(ByVal prefixe As String) As String
    '    Dim sql As String
    '    Dim where As String
    '    Dim unpercent As String = "%"
    '    where = " where activation_code like '" & prefixe & "%' "
    '    sql = GetActivtionCodeAllFields() & where
    '    Return sql
    'End Function


    Public Shared Function GetDiscountExpiration() As String
        Dim where As String = " where  discount_validityto <= DATE_ADD(now(), INTERVAL 31 DAY) and discount_validityto >= DATE_ADD(now(), INTERVAL -31 DAY) order by discount_validityto DESC"
        Dim sql As String = GetDiscountCode() + where

        Return sql
    End Function

    Public Shared Function GetActivationExpiration() As String
        Dim condition As String = " and  activation_code_validto_date <= DATE_ADD(now(), INTERVAL 31 DAY) and activation_code_validto_date >= DATE_ADD(now(), INTERVAL -31 DAY)group by campaign order by activation_code_validto_date desc"
        Dim sql As String = GetActivtionCodeAllFields() + condition
        Return sql
    End Function

    Public Shared Function GetActivtionCodeAllFields() As String
        Dim sql = "select (select count(*) from vod_wishlists w where w.customer_id = ac.customers_id) size_w, activation_id, activation_type, activation_value, activation_code, activation_group, campaign_id, activation_group_id, activation_pack, activation_code_creation_date, activation_code_validto_date, activation_products_id," & _
                  " validity_month, validity_type, validity_value, activation_waranty, customers_id,   activation_date  , comment, next_discount, credit0_auto_reconduct, " & _
                  "abo_auto_stop_next_reconduction, banner, activation_text_fr, activation_text_nl, activation_text_en, free_upgrade_allowed, footer, campaign, combined_action,next_abo_type, paypal, creditcard, debitcard, discount_action " & _
                  " from activation_code ac  where 1 "
        Return sql
        'if (activation_date is null , '0000-00-00 00:00:00',activation_date) as
    End Function


    'Public Shared Function GetActivationById(ByVal activation_id As Integer) As String
    '    Dim where As String = " where activation_id = " & activation_id & " "
    '    Return GetActivtionCodeAllFields() + where
    'End Function

    'Public Shared Function GetActivationByCampaign(ByVal campaign As String) As String
    '    Dim where As String = " where campaign like '%" & campaign & "%'"
    '    Return GetActivtionCodeAllFields() + where
    'End Function

    Public Shared Function GetActivationSearch(Optional ByVal customers_id As Integer = 0, Optional ByVal activation_id As String = "", Optional ByVal activation_code As String = "", Optional ByVal activationUse As Boolean = False, Optional ByVal campaign As String = "", Optional ByVal dateFrom As String = "", Optional ByVal dateTo As String = "", Optional ByVal groupId As String = "") As String
        Dim sql As String
        'Dim orderBy As String = " order by activation_code_creation_date desc "
        sql = GetActivtionCodeAllFields()

        If customers_id <> 0 Then
            sql = sql + " and customers_id = " & customers_id
        End If

        If activation_id <> String.Empty Then
            sql = sql + " and activation_id = " & activation_id  'GetActivationById(activation_id)
        End If

        If activation_code <> String.Empty Then
            sql = sql + " and activation_code like '" & activation_code & "%' " 'GetActivationWithPrefixe(activation_code)
        End If

        If campaign <> String.Empty Then
            sql = sql + " and campaign like '" & campaign & "%'" 'GetActivationByCampaign(campaign)
        End If

        If activationUse = True Then
            sql = sql + " and customers_id <> 0 "
            If dateTo <> String.Empty And dateFrom <> String.Empty Then
                sql = sql + " and activation_date >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and  activation_date <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' "
            End If
        End If


        If activationUse = False And dateTo <> String.Empty And dateFrom <> String.Empty Then
            sql = sql + " and activation_code_creation_date >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and   activation_code_creation_date <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'"
        End If

        If groupId <> "" Then
            sql = sql + " and activation_group = " & groupId
        End If


        sql = sql + " order by activation_id desc "
        Return sql
    End Function



    Public Shared Function GetDiscountCode() As String
        Dim sql As String
        sql = "SELECT * FROM  discount_code d " & " left join activation_group ag on d.group_id = ag.activation_group_id "
        Return sql
    End Function

    Public Shared Function GetDiscountCodeDesc() As String
        Dim order As String
        order = " order by discount_code_id desc "
        Return GetDiscountCode() + order
    End Function

    Public Shared Function GetDiscountAboValidityType() As String
        Dim sql As String = "SELECT * FROM  discount_abo_validityto_type"
        Return sql
    End Function

    Public Shared Function GetDiscountType() As String
        Dim sql As String = "SELECT * FROM  discount_type"
        Return sql
    End Function


    Public Shared Function GetDiscountSearch(ByVal discount_id As String, Optional ByVal discount_code As String = "", Optional ByVal groupPartnerId As String = "", Optional ByVal dateFrom As String = "", Optional ByVal dateTo As String = "") As String
        Dim sql As String
        Dim where As String
        sql = GetDiscountCode()
        where = " where 1 "

        sql = sql + where

        If discount_id <> String.Empty Then
            sql = sql + " and discount_code_id = " & discount_id
        End If

        If discount_code <> String.Empty Then
            sql = sql + " and discount_code  like '" & discount_code & "%' "
        End If

        If groupPartnerId <> String.Empty Then
            If groupPartnerId <> "0" Then
                sql = sql + " and group_id = " & groupPartnerId
            End If
        End If

        If dateFrom <> String.Empty And dateTo <> String.Empty Then
            sql = sql + " and discount_validityTo >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and  discount_validityTo <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'"
        End If


        Return sql
    End Function


    'Public Shared Function InsertNewDiscountCode() As String
    '    Dim sql As String
    '    sql = "insert into discount_code (discount_code) values ('" & NEWDISCOUNT & "')"
    '    Return sql
    'End Function

    Public Shared Function GetLastInsert() As String
        Dim sql As String
        sql = "SELECT  discount_code_id from discount_code order by discount_code_id desc limit 1 "
        Return sql
    End Function


    Public Shared Function GetExistNewDiscount(ByVal discount_code As String) As String
        Dim sql As String
        sql = "select count(*) from discount_code where discount_code = '" & discount_code & "'"
        Return sql
    End Function

    Public Shared Function updateDiscountCode(ByVal discount_code As String, _
                                              ByVal discount_type As Integer, _
                                              ByVal discount_value As Decimal, _
                                              ByVal discount_limit As Integer, _
                                              ByVal discount_commitment As Integer, _
                                              ByVal discount_status As Integer, _
                                              ByVal discount_text_fr As String, _
                                              ByVal discount_text_nl As String, _
                                              ByVal discount_text_en As String, _
                                              ByVal discount_abo_validityto_type As Integer, _
                                              ByVal discount_abo_validityto_value As Integer, _
                                              ByVal comment As String, _
                                              ByVal discount_nbr_month_before_reuse As Integer, _
                                              ByVal discount_recurring_nbr_of_month As Integer, _
                                              ByVal bypass_discountuse As Integer, _
                                              ByVal discount_validityto As String, _
                                              ByVal payable As Integer, _
                                              ByVal next_discount As Integer, _
                                              ByVal credit0_auto_reconduct As Integer, _
                                              ByVal landing_page As Integer, _
                                              ByVal landing_page_php As String, _
                                              ByVal listing_products_allowed As String, _
                                              ByVal abo_auto_stop_next_reconduction As Integer, _
                                              ByVal goto_step As Integer, _
                                              ByVal banner As String, _
                                              ByVal Footer As String, _
                                              ByVal free_upgrade_allowed As Integer, _
                                              ByVal group_id As Integer, _
                                              ByVal next_abo_type As Integer, _
                                              ByVal paypal As Integer, _
                                              ByVal creditcard As Integer, _
                                              ByVal debitcard As Integer, _
                                              ByVal discount_action As String _
                                              ) As String
        Dim sql As String


        If discount_validityto = "" Then
            discount_validityto = "DEFAULT(discount_validityto)"
        Else
            discount_validityto = " '" & PlushTools.ClsDate.formatDate(discount_validityto) & "' "
        End If


        discount_text_fr = replaceSingleCote(discount_text_fr)
        discount_text_nl = replaceSingleCote(discount_text_nl)
        discount_text_en = replaceSingleCote(discount_text_en)
        comment = replaceSingleCote(comment)


        sql = " update discount_code set discount_code = '" & discount_code & "' " & _
                                      " , discount_type = " & discount_type & _
                                      " , discount_value = " & PlushTools.ClsPrice.FormatPrice(discount_value) & _
                                      " , discount_limit = " & discount_limit & _
                                      " , discount_commitment = " & discount_commitment & _
                                      " , discount_status = " & discount_status & _
                                      " , discount_text_fr = '" & discount_text_fr & "' " & _
                                      " , discount_text_nl = '" & discount_text_nl & "' " & _
                                      " , discount_text_en = '" & discount_text_en & "' " & _
                                      " , discount_abo_validityto_type = " & discount_abo_validityto_type & _
                                      " , discount_abo_validityto_value = " & discount_abo_validityto_value & _
                                      " , comment = '" & comment & "' " & _
                                      " , discount_nbr_month_before_reuse = " & discount_nbr_month_before_reuse & _
                                      " , discount_recurring_nbr_of_month = " & discount_recurring_nbr_of_month & _
                                      " , bypass_discountuse = " & bypass_discountuse & _
                                      " , discount_validityto = " & discount_validityto & "  " & _
                                      " , payable = " & payable & _
                                      " , next_discount = " & next_discount & _
                                      " , credit0_auto_reconduct = " & credit0_auto_reconduct & _
                                      " , landing_page = " & landing_page & _
                                      " , landing_page_php = '" & landing_page_php & "'" & _
                                      " , listing_products_allowed = " & listing_products_allowed & _
                                      " , abo_auto_stop_next_reconduction = " & Math.Abs(abo_auto_stop_next_reconduction) & _
                                      " , goto_step = " & goto_step & _
                                      " , banner = '" & banner & "'" & _
                                      " , Footer = '" & Footer & "'" & _
                                      " , free_upgrade_allowed = " & free_upgrade_allowed & _
                                      " , next_abo_type = " & next_abo_type & _
                                      " , paypal = " & paypal & _
                                      " , creditcard = " & creditcard & _
                                      " , debitcard = " & debitcard & _
                                      " , discount_action = '" & discount_action & "' " & _
                                      " where discount_code = '" & discount_code & "'"
        Return sql
    End Function


    Public Shared Function insertDiscount(ByVal discount_code As String, _
                                              ByVal discount_type As Integer, _
                                              ByVal discount_value As Decimal, _
                                              ByVal discount_limit As Integer, _
                                              ByVal discount_commitment As Integer, _
                                              ByVal discount_status As Integer, _
                                              ByVal discount_text_fr As String, _
                                              ByVal discount_text_nl As String, _
                                              ByVal discount_text_en As String, _
                                              ByVal discount_abo_validityto_type As Integer, _
                                              ByVal discount_abo_validityto_value As Integer, _
                                              ByVal comment As String, _
                                              ByVal discount_nbr_month_before_reuse As Integer, _
                                              ByVal discount_recurring_nbr_of_month As Integer, _
                                              ByVal bypass_discountuse As Integer, _
                                              ByVal discount_validityto As String, _
                                              ByVal payable As Integer, _
                                              ByVal next_discount As Integer, _
                                              ByVal credit0_auto_reconduct As Integer, _
                                              ByVal landing_page As Integer, _
                                              ByVal landing_page_php As String, _
                                              ByVal listing_products_allowed As String, _
                                              ByVal abo_auto_stop_next_reconduction As Integer, _
                                              ByVal goto_step As Integer, _
                                              ByVal banner As String, _
                                              ByVal Footer As String, _
                                              ByVal free_upgrade_allowed As Integer, _
                                              ByVal group_id As Integer, _
                                              ByVal nextAboType As Integer, _
                                              ByVal paypal As Integer, _
                                              ByVal creditcard As Integer, _
                                              ByVal debitcard As Integer, _
                                              ByVal discount_action As String) As String
        Dim sql As String

        If discount_validityto = "" Then
            discount_validityto = "DEFAULT(discount_validityto)"
        Else
            discount_validityto = " '" & PlushTools.ClsDate.formatDate(discount_validityto) & "' "
        End If


        discount_text_fr = replaceSingleCote(discount_text_fr)
        discount_text_nl = replaceSingleCote(discount_text_nl)
        discount_text_en = replaceSingleCote(discount_text_en)
        comment = replaceSingleCote(comment)


        sql = "insert into discount_code(discount_code, discount_type, discount_value, discount_limit," & _
                                        " discount_commitment, discount_status, discount_text_fr, discount_text_nl, discount_text_en, discount_abo_validityto_type," & _
                                        " discount_abo_validityto_value, comment, discount_nbr_month_before_reuse, discount_recurring_nbr_of_month, bypass_discountuse," & _
                                        " discount_validityto, payable, next_discount, credit0_auto_reconduct, landing_page, landing_page_php, " & _
                                        " listing_products_allowed, abo_auto_stop_next_reconduction, goto_step, banner, Footer, free_upgrade_allowed, group_id , shopping_discount , droselia,next_abo_type, paypal, creditcard, debitcard, discount_action )" & _
                                        " values  ( '" & discount_code & "' " & _
                                                   " , " & discount_type & _
                                                   " , " & PlushTools.ClsPrice.FormatPrice(discount_value) & _
                                      " , " & discount_limit & _
                                      " , " & discount_commitment & _
                                      " , " & discount_status & _
                                      " , ' " & discount_text_fr & "' " & _
                                      " , '" & discount_text_nl & "' " & _
                                      " , '" & discount_text_en & "' " & _
                                      " , " & discount_abo_validityto_type & _
                                      " , " & discount_abo_validityto_value & _
                                      " , '" & comment & "' " & _
                                      " , " & discount_nbr_month_before_reuse & _
                                      " , " & discount_recurring_nbr_of_month & _
                                      " , " & bypass_discountuse & _
                                      " , " & discount_validityto & _
                                      " , " & payable & _
                                      " , " & next_discount & _
                                      " , " & credit0_auto_reconduct & _
                                      " , " & landing_page & _
                                      " , '" & landing_page_php & "'" & _
                                      " , " & IIf(listing_products_allowed Is Nothing, "DEFAULT(listing_products_allowed) ", listing_products_allowed) & _
                                      " , " & Math.Abs(abo_auto_stop_next_reconduction) & _
                                      " , " & goto_step & _
                                      " , '" & banner & "'" & _
                                      " , '" & Footer & "'" & _
                                      " , " & free_upgrade_allowed & _
                                      "  , " & group_id & _
                                      " , DEFAULT(shopping_discount) , 0 " & _
                                       "  , " & nextAboType & " , " & paypal & ", " & creditcard & ", " & debitcard & ", '" & discount_action & "' ) "


        Return sql
    End Function



    Public Shared Function GetshoppingDIscount(Optional ByVal shopping_discount_id As Integer = 0) As String
        Dim sql As String
        Dim order

        sql = "select * from shopping_discount "
        order = " order by shopping_discount_id desc"

        If shopping_discount_id <> 0 Then
            sql = sql & " where shopping_discount_id = " & shopping_discount_id
        End If

        Return sql & order
    End Function


    Public Shared Function updateShoppingDiscount(ByVal discount_code As String, ByVal discount_type As Integer, ByVal discount_value As Integer, ByVal discount_status As Integer, ByVal discount_text_fr As String, ByVal discount_text_nl As String, ByVal discount_text_en As String, ByVal validity_to As String)
        Dim sql As String
        If validity_to = "" Then
            validity_to = "DEFAULT(validity_to)"
        Else
            validity_to = " '" & PlushTools.ClsDate.formatDate(validity_to) & "' "
        End If

        discount_text_fr = replaceSingleCote(discount_text_fr)
        discount_text_nl = replaceSingleCote(discount_text_nl)
        discount_text_en = replaceSingleCote(discount_text_en)


        sql = "update shopping_discount set discount_code = '" & discount_code & "' " & _
         " , discount_type = " & discount_type & "  ,discount_value = " & discount_value & _
         " , discount_status =  " & discount_status & _
         " , discount_text_fr = '" & discount_text_fr & "', discount_text_nl = '" & discount_text_nl & "' , discount_text_en = '" & discount_text_en & "' , validity_to = " & validity_to & " where discount_code = '" & discount_code & "'"
        Return sql
    End Function

    Public Shared Function GetExistShoppingDiscount(ByVal discount_code As String) As String
        Dim sql As String
        sql = "select count(*) from shopping_discount where discount_code = '" & discount_code & "' "
        Return sql
    End Function


    Public Shared Function insertShoppingDiscount(ByVal discount_code As String, ByVal discount_type As Integer, ByVal discount_value As Integer, ByVal discount_status As Integer, ByVal discount_text_fr As String, ByVal discount_text_nl As String, ByVal discount_text_en As String, ByVal validity_to As String)
        Dim sql As String

        If validity_to = "" Then
            validity_to = "DEFAULT(validity_to)"
        Else
            validity_to = " '" & PlushTools.ClsDate.formatDate(validity_to) & "' "
        End If

        discount_text_fr = replaceSingleCote(discount_text_fr)
        discount_text_nl = replaceSingleCote(discount_text_nl)
        discount_text_en = replaceSingleCote(discount_text_en)

        sql = "insert into shopping_discount" & _
        " (discount_code, discount_type, discount_value, discount_status, discount_text_fr, discount_text_nl, discount_text_en, validity_to) " & _
        " values ('" & discount_code & "' , " & discount_type & " , " & discount_value & ", " & discount_status & "  , '" & discount_text_fr & "' , '" & discount_text_nl & "' , '" & discount_text_en & "' , " & validity_to & " )"
        Return sql
    End Function

    Private Shared Function replaceSingleCote(ByVal str As String) As String
        str = Replace(str, "'", "\'")
        Return str
    End Function

    Public Shared Function GetEnumMysqlDiscountAction() As String
        Dim sql As String

        sql = "SHOW COLUMNS FROM discount_code LIKE 'discount_action' "
        Return sql
    End Function


End Class
