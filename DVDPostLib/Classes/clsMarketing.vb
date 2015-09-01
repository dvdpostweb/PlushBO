Public Class clsMarketing
#Region "discount_code"
    Public Class clsDiscountCode
        'Inherits BizzLib.clsOneTableData

        'Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, ByVal WhereClause As String, ByVal OrderByTxt As String, ByVal discountId As Integer)
        '    MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "discount_code_id", "SELECT * FROM discount_code where discount_code_id = " & discountId, WhereClause, OrderByTxt)
        '    'SetDefault()
        'End Sub
        'Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo)
        '    MyBase.New(SessionInfo)
        '    'SetDefault()
        'End Sub
        ''Public Sub SetDefault()
        ''    DataSet1.Tables(TableName).Columns("discount_type").DefaultValue = 0
        ''    DataSet1.Tables(TableName).Columns("discount_value").DefaultValue = 0
        ''    DataSet1.Tables(TableName).Columns("discount_limit").DefaultValue = 0
        ''    DataSet1.Tables(TableName).Columns("discount_commitment").DefaultValue = 0
        ''    DataSet1.Tables(TableName).Columns("discount_status").DefaultValue = 1
        ''    DataSet1.Tables(TableName).Columns("discount_abo_validityto_type").DefaultValue = 0
        ''    DataSet1.Tables(TableName).Columns("discount_abo_validityto_value").DefaultValue = 0
        ''    DataSet1.Tables(TableName).Columns("discount_nbr_month_before_reuse").DefaultValue = 3
        ''    DataSet1.Tables(TableName).Columns("discount_recurring_nbr_of_month").DefaultValue = 0
        ''    DataSet1.Tables(TableName).Columns("payable").DefaultValue = 0
        ''    DataSet1.Tables(TableName).Columns("abo_dvd_credit").DefaultValue = 0
        ''    DataSet1.Tables(TableName).Columns("next_discount").DefaultValue = 0
        ''    DataSet1.Tables(TableName).Columns("credit0_auto_reconduct").DefaultValue = 0
        ''    DataSet1.Tables(TableName).Columns("landing_page").DefaultValue = 0
        ''    DataSet1.Tables(TableName).Columns("abo_auto_stop_next_reconduction").DefaultValue = 0
        ''    DataSet1.Tables(TableName).Columns("goto_step").DefaultValue = 31
        ''    DataSet1.Tables(TableName).Columns("Footer").DefaultValue = "FREETRIAL"
        ''    DataSet1.Tables(TableName).Columns("free_upgrade_allowed").DefaultValue = 0
        ''    DataSet1.Tables(TableName).Columns("group_id").DefaultValue = 0
        ''    DataSet1.Tables(TableName).Columns("bypass_discountuse").DefaultValue = 0
        ''End Sub
        'Public Overrides Function ValidateRecordBeforeDelete(ByVal Row1 As System.Data.DataRowView) As Integer
        '    Dim _MsgID As Integer = -1
        '    Return _MsgID
        'End Function
        'Public Overrides Function ValidateRecordFields(ByRef Row1 As System.Data.DataRowView) As Integer
        '    Dim _MsgID As Integer = -1
        '    'Check ID
        '    If Row1(IDField) & "" = "" Then
        '        Row1(IDField) = BKGlobal.GetNextID(IDField)
        '    End If
        '    'Check Name
        '    If Row1("discount_code") & "" = "" Then
        '        'Name Cannot Be Blank
        '        _MsgID = 5
        '    End If
        '    Return _MsgID
        'End Function

        'Public Overrides Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean
        '    Return DvdPostData.clsConnection.ExecuteScalar("Select Count(*) FROM discount_code WHERE " & IDFieldName & " = " & ID)
        'End Function
        'Public Overloads Overrides Function DeleteByID(ByVal ID As Integer) As Integer
        '    Return DvdPostData.clsConnection.ExecuteNonQuery("DELETE discount_code WHERE discount_code_id = " & ID)
        'End Function




        Public Shared Function GetDiscountCode(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("discount_code")) Then
                Return dr("discount_code")
            Else
                Return ""
            End If
        End Function


        Public Shared Function GetDiscountType(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("discount_type")) Then
                Return dr("discount_type")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetDiscountValue(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("discount_value")) Then
                Return dr("discount_value").ToString
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetDiscountLimit(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("discount_limit")) Then
                Return dr("discount_limit")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetDiscountCommitment(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("discount_commitment")) Then
                Return dr("discount_commitment")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetCommentDiscount(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("comment")) Then
                Return dr("comment")
            Else
                Return ""
            End If
        End Function


        Public Shared Function GetDiscountTxtFr(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("discount_text_fr")) Then
                Return dr("discount_text_fr")
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetDiscountTxtNl(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("discount_text_nl")) Then
                Return dr("discount_text_nl")
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetDiscountTxtEn(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("discount_text_en")) Then
                Return dr("discount_text_en")
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetBanner(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("banner")) Then
                Return dr("banner")
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetFooter(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("Footer")) Then
                Return dr("Footer")
            Else
                Return PlushData.clsActivationCode.FOOTER
            End If
        End Function

        Public Shared Function GetLandingPage(ByVal dr As DataRow) As Integer

            If Not IsDBNull(dr("landing_page")) Then
                Return dr("landing_page")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetLandingPagePhp(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("landing_page_php")) Then
                Return dr("landing_page_php")
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetGroupId(ByVal dr As DataRow) As Integer

            If Not IsDBNull(dr("group_id")) Then
                Return dr("group_id")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetDiscountValitdityType(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("discount_abo_validityto_type")) Then
                Return dr("discount_abo_validityto_type")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetDiscountValidityValue(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("discount_abo_validityto_value")) Then
                Return dr("discount_abo_validityto_value")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetNbrMonthBeforeReuse(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("discount_nbr_month_before_reuse")) Then
                Return dr("discount_nbr_month_before_reuse")
            Else
                Return 0
            End If
        End Function


        Public Shared Function GetRecurringNbrOfMonth(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("discount_recurring_nbr_of_month")) Then
                Return dr("discount_recurring_nbr_of_month")
            Else
                Return 0
            End If
        End Function


        Public Shared Function GetValidityTo(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("discount_validityto")) Then
                Return dr("discount_validityto")
            Else
                Return ""
            End If
        End Function
        Public Shared Function GetDvdCredit(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("abo_dvd_credit")) Then
                Return dr("abo_dvd_credit")
            Else
                Return 0
            End If
        End Function
        Public Shared Function GetDvdRemaining(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("abo_dvd_remain")) Then
                Return dr("abo_dvd_remain")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetNextDiscount(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("next_discount")) Then
                Return dr("next_discount")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetNextAboType(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("next_abo_type")) AndAlso Not dr("next_abo_type") Is String.Empty Then
                Return dr("next_abo_type")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetDiscountAction(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("discount_action")) AndAlso Not dr("discount_action") Is String.Empty Then
                Return dr("discount_action")
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetTVODFree(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("tvod_free")) AndAlso Not dr("tvod_free") Is String.Empty Then
                Return dr("tvod_free")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetAboType(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("listing_products_allowed")) AndAlso Not dr("listing_products_allowed") Is String.Empty Then
                Return dr("listing_products_allowed")
            Else
                Return 0
            End If
        End Function


        Public Shared Function GetGotoSep(ByVal dr As DataRow) As Integer

            If Not IsDBNull(dr("goto_step")) Then
                Return dr("goto_step")
            Else
                Return 0
            End If

        End Function


        Public Shared Function GetAutoStop(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("abo_auto_stop_next_reconduction")) Then
                Return dr("abo_auto_stop_next_reconduction")
            Else
                Return 0
            End If
        End Function


        Public Shared Function GetPayable(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("payable")) Then
                Return dr("payable")
            Else
                Return 0
            End If
        End Function


        Public Shared Function GetCredit0AutoReconduction(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("credit0_auto_reconduct")) Then
                Return dr("credit0_auto_reconduct")
            Else
                Return 0
            End If

        End Function


        Public Shared Function GetBypassDiscountUse(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("bypass_discountuse")) Then
                Return dr("bypass_discountuse")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetFreeUpGradeAllowed(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("free_upgrade_allowed")) Then
                Return dr("free_upgrade_allowed")
            Else
                Return (0)
            End If
        End Function



        Public Shared Function GetDiscountStatus(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("discount_status")) Then
                Return dr("discount_status")
            Else
                Return 0
            End If
        End Function


        Public Shared Function GetPayPal(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("paypal")) Then
                Return dr("paypal")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetCrediCard(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("creditcard")) Then
                Return dr("creditcard")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetDebitCard(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("debitcard")) Then
                Return dr("debitcard")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetAllCust(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("all_cust")) Then
                Return dr("all_cust")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetShoppingDiscountValidityTo(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("validity_to")) Then
                Return dr("validity_to")
            Else
                Return ""
            End If
        End Function
    End Class
#End Region

#Region "Activation_code"
    Public Class clsActivationCode

        Public Shared Function GetActivationId(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("activation_id")) Then
                Return dr("activation_id")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetActivationCode(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("activation_code")) Then
                Return dr("activation_code")
            Else
                Return ""
            End If
        End Function
        Public Shared Function GetActivationType(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("activation_type")) Then
                Return dr("activation_type")
            Else
                Return 0
            End If
        End Function
        Public Shared Function GetActivationValue(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("activation_value")) Then
                Return dr("activation_value").ToString
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetActivationGroup(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("activation_group")) Then
                Return dr("activation_group")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetCampaignId(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("campaign_id")) Then
                Return dr("campaign_id")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetActivationGroupId(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("activation_group_id")) Then
                Return dr("activation_group_id")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetActivationPack(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("activation_pack")) Then
                Return dr("activation_pack")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetActivationCodeCreationDate(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("activation_code_creation_date")) Then
                Return dr("activation_code_creation_date")
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetActivationCodeValidtoDate(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("activation_code_validto_date")) Then
                Return dr("activation_code_validto_date")
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetActivationProductsId(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("activation_products_id")) Then
                Return dr("activation_products_id")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetValidityMonth(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("validity_month")) Then
                Return dr("validity_month")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetValidityType(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("validity_type")) Then
                Return dr("validity_type")
            Else
                Return 0
            End If
        End Function
        Public Shared Function GetValidityValue(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("validity_value")) Then
                Return dr("validity_value")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetActivationWaranty(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("activation_waranty")) Then
                Return dr("activation_waranty")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetCustomersId(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("customers_id")) Then
                Return dr("customers_id")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetActivationVate(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("activation_date")) Then
                Return dr("activation_date")
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetComment(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("comment")) Then
                Return dr("comment")
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetAboDvdCredit(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("abo_dvd_credit")) Then
                Return dr("abo_dvd_credit")
            Else
                Return 0
            End If
        End Function
        Public Shared Function GetAboDvdRemain(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("abo_dvd_remain")) Then
                Return dr("abo_dvd_remain")
            Else
                Return 0
            End If
        End Function


        Public Shared Function GetNextDiscount(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("next_discount")) Then
                Return dr("next_discount")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetActivationCredit0AutoReconduct(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("credit0_auto_reconduct")) Then
                Return dr("credit0_auto_reconduct")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetAboAutoStopNextReconduction(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("abo_auto_stop_next_reconduction")) Then
                Return dr("abo_auto_stop_next_reconduction")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetBanner(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("banner")) Then
                Return dr("banner")
            Else
                Return ""
            End If
        End Function

        Public Shared Function getActivationTextFr(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("activation_text_fr")) Then
                Return dr("activation_text_fr")
            Else
                Return ""
            End If
        End Function

        Public Shared Function getActivationTextNl(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("activation_text_nl")) Then
                Return dr("activation_text_nl")
            Else
                Return ""
            End If
        End Function

        Public Shared Function getActivationTextEn(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("activation_text_en")) Then
                Return dr("activation_text_en")
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetFreeUpgradeAllowed(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("free_upgrade_allowed")) Then
                Return dr("free_upgrade_allowed")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetFooter(ByVal dr As DataRow) As String
            If IsDBNull(dr("footer")) Then
                Return dr("footer")
            Else
                Return PlushData.clsActivationCode.FOOTER
            End If
        End Function


        Public Shared Function GetCampaign(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("campaign")) Then
                Return dr("campaign")
            Else
                Return ""
            End If
        End Function


        Public Shared Function GetCombinedAction(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("combined_action")) Then
                Return (dr("combined_action"))
            Else
                Return PlushData.clsActivationCode.COMBINEDACTIONNO
            End If
        End Function
    End Class
#End Region

#Region "Streaming_code"
    Public Class clsStreamingCode

        Public Shared Function GetStreamingId(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("id")) Then
                Return dr("id")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetStreamingCode(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("name")) Then
                Return dr("name")
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetActivationGroupId(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("activation_group_id")) Then
                Return dr("activation_group_id")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetStreamingCodeCreationAt(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("created_at")) Then
                Return dr("created_at")
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetStreamingCodeExpirationAt(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("expiration_at")) Then
                Return dr("expiration_at")
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetStrimingCodeWhiteLabel(ByVal dr As DataRow) As Integer
            If Not IsDBNull(dr("white_label")) Then
                Return dr("white_label")
            Else
                Return 0
            End If
        End Function

        Public Shared Function GetStrimingCodeUsedAt(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("used_at")) Then
                Return dr("used_at")
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetStreamingCodeMailID(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("mail_id")) Then
                Return dr("mail_id")
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetStrimingCodeEmail(ByVal dr As DataRow) As String
            If Not IsDBNull(dr("email")) Then
                Return dr("email")
            Else
                Return ""
            End If
        End Function


    End Class
#End Region
End Class

