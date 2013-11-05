Imports PlushData
Imports System.Collections.Generic
Imports PayPal_Merchant_SDK

Public Class ClsCustomers

    '' utiliser pour gerer la progress bar
    Public Event initMapping_Event(ByVal cpt As Integer)
    Public Event stepMapping_event(ByVal index As Integer)
    Public Event ReInitProgressbar_event()

    Public Enum AdultSVODStatus
        INITIALISED = 1
        ACTIVE = 2
        STOP_ADULT_SVOD_ON_NEXT_RECONDUCTION = 3
        STOP_ADULT_SVOD = 4
    End Enum

    Public Shared Sub encryptPwd()

        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsUsers.GetselectUser()
        dt = PlushData.clsConnection.FillDataSet(sql)


        For Each dr As DataRow In dt.Rows
            sql = PlushData.clsUsers.GetUpdatePwdUser(dr("userid"), MD5Encrypt(dr("password")))
            PlushData.clsConnection.ExecuteNonQuery(sql)
        Next

    End Sub
    Public Shared Function MD5Encrypt(ByVal str As String) As String


        Dim md5 As Security.Cryptography.MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim strOutput As String
        Dim i As Integer
        Try
            md5 = New System.Security.Cryptography.MD5CryptoServiceProvider
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        bytValue = System.Text.Encoding.UTF8.GetBytes(str)


        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            strOutput &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

        Return strOutput



    End Function
    Public Shared Sub CreateInvoiceDvd(ByVal customers_id As Integer)
        Dim montant As String
        montant = "15"
        clsPayment.CreateInvoice(customers_id, ClsCustomersData.Payment_Method.VIREMENT, PlushData.ClsPayment.Payment_type.LOST_CHARGE, ClsCustomersData.TypePaymentCommunication.VIREMENT, montant)
    End Sub
    Public Shared Function CreateInvoiceLongtime(ByVal customers_id As Integer) As Boolean

        'Dim montant As String

        'Dim communication As String

        'Dim dt As DataTable
        'Dim sql As String
        'montant = "15"
        'sql = PlushData.ClsCustomersData.getSelectCustStopKeepdvd(customers_id)
        'dt = PlushData.clsConnection.FillDataSet(sql)

        'For Each dr As DataRow In dt.Rows
        '    communication = clsPayment.CreateInvoice(customers_id, ClsCustomersData.Payment_Method.VIREMENT, PlushData.ClsPayment.Payment_type.LONGTIME, ClsCustomersData.TypePaymentCommunication.VIREMENT, montant)
        '    dr("payment_offline_communication") = communication
        '    dr("payment_offline_amount") = montant
        '    PlushBuziness.clsMail.SendMail(dr, clsMail.Mail.MAIL_DVDABOSTOP)

        'Next

    End Function

    Private Shared Function GetCptDvdatHome(ByVal customers_id As Integer) As Integer
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.ClsCustomersData.GetSelectCustomerDetail(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sql)

        If dt.Rows.Count = 1 Then
            Dim dr As DataRow = dt.Rows(0)
            Return dr("customers_abo_dvd_home_norm") + dr("customers_abo_dvd_home_adult")
        End If
        Return 0
    End Function
    Public Shared Function isCustomersStopDvdatHome(ByVal customers_id As Integer) As Boolean
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.ClsCustomersData.GetSelectCustomerDetail(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sql)

        If dt.Rows.Count = 1 Then
            Dim dr As DataRow = dt.Rows(0)

            Return dr("customers_abo") = 0 And (dr("customers_abo_dvd_home_norm") + dr("customers_abo_dvd_home_adult")) > 0
        End If

        Return False
    End Function

    Public Sub CreateCustomersRotation()
        Dim sql As String

        sql = PlushData.clsOdersStatusHistory.GetInsertCustomersRotation()
        PlushData.clsConnection.ExecuteNonQuery(sql)
    End Sub

    Private Function CalcAmountAbo(ByVal discount_type As Integer, ByVal product_price As Decimal, ByVal discount_value As Decimal) As String
        Dim result As Decimal
        Dim strtotal As String = product_price
        Select Case discount_type
            Case ClsCustomersData.discount_code.REDUCTION_PERCENT
                result = product_price
                result = (result - (result * discount_value / 100))
                result = Math.Round(result, 2)
                strtotal = result
            Case ClsCustomersData.discount_code.AMOUNT
                strtotal = discount_value
            Case ClsCustomersData.discount_code.REDUCTION_VALUE
                result = product_price
                result = (result - discount_value)
                result = Math.Round(result, 2)
                strtotal = result
        End Select

        Return strtotal
    End Function

    Private Function GetDurationActivation(ByVal activation_type As Integer, ByVal activation_value As Integer) As String
        Dim result As String = activation_value.ToString()
        If activation_value = 0 Then
            result = " 1 MONTH"
        Else
            Select Case activation_type
                Case ClsCustomersData.Activation_code.DAYS
                    result = result + " DAY"
                Case ClsCustomersData.Activation_code.MONTH
                    result = result + " MONTH"
                Case ClsCustomersData.Activation_code.YEAR
                    result = result + " YEAR"

            End Select
        End If
        Return result
    End Function

    Private Function GetStrPayment_method(ByVal payment_methode_id As Integer) As String
        'Select Case payment_methode_id
        '    Case Payment_Method.DOMICILIATION
        '        Return Payment_Method.DOMICILIATION
        '    Case Payment_Method.KDO
        '        Return Payment_Method.KDO
        '    Case Payment_Method.OGONE
        '        Return Payment_Method.OGONE
        '    Case Payment_Method.VIREMENT

        '        [Enum].GetName(Payment_Method, payment_methode_id)

        Dim payment_Methode_value As ClsCustomersData.Payment_Method
        If [Enum].IsDefined(GetType(ClsCustomersData.Payment_Method), payment_methode_id) Then
            payment_Methode_value = [Enum].ToObject(GetType(ClsCustomersData.Payment_Method), payment_methode_id)
            Return payment_Methode_value.ToString().ToUpper()
        Else
            Return ""

        End If


    End Function

    Public Function getCustomersDomiciliationNumber(ByVal drCustomer As DataRow) As String

        If drCustomer("domiciliation_number") Is DBNull.Value Then
            Return ""
        Else
            Return drCustomer("domiciliation_number")
        End If
    End Function

    Public Function getCustomersDvdNorm(ByVal drCustomer As DataRow) As String

        Return drCustomer("customers_abo_dvd_norm")
    End Function

    Public Function getCustomersDvdAdult(ByVal drCustomer As DataRow) As String

        Return drCustomer("customers_abo_dvd_adult")
    End Function

    Private Function getCustomersNextDiscount(ByVal drCustomer As DataRow) As String
        If drCustomer("customers_next_discount_code") IsNot DBNull.Value Then
            Return drCustomer("customers_next_discount_code")
        End If
        Return 0
    End Function

    Public Function GetCustomersAmount(ByVal drCustomer As DataRow) As String
        Return drCustomer("amount")
    End Function
    Public Function GetCustomersPayment_method(ByVal drCustomer As DataRow) As Integer
        Return drCustomer("customers_abo_payment_method")
    End Function

    Public Shared Function isIllimitedaboByCustomers(ByVal customers_id As Integer) As Boolean
        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.ClsCustomersData.GetSelectIsAboIllimited(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt.Rows.Count > 0

    End Function
    'Public Shared Function isIllimitedabo(ByVal abo_type As Integer) As Boolean
    '    Dim lstillimited() As Integer = {5, 6, 7, 8, 9, 13, 14, 15, 16, 41, 42}
    '    Dim i As Integer = 0
    '    While i < lstillimited.Length
    '        If lstillimited(i) = abo_type Then Return True
    '        i += 1
    '    End While
    '    Return False
    'End Function

    Public Function GetCustomersPayment_method(ByVal customers_id As Integer) As Integer
        Dim drCustomer As DataRow
        Dim dt As DataTable
        Dim sql As String

        sql = PlushData.ClsCustomersData.GetSelectCustomerDetail(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sql)

        If dt.Rows.Count > 0 Then
            drCustomer = dt.Rows(0)
            Return drCustomer("customers_abo_payment_method")
        Else
            Return 0
        End If

    End Function

    Public Function GetCustomersId(ByVal drCustomer As DataRow) As Integer
        Return drCustomer("customers_id")
    End Function
    Public Function GetCustomersPackageCount(ByVal drCustomer As DataRow) As Integer
        Return drCustomer("package_count")
    End Function
    Public Function GetCustomersPackageCountNext(ByVal drCustomer As DataRow) As Integer
        Return drCustomer("package_count_next")
    End Function

    Public Function GetCustomersSVODADULTStatus(ByVal drCustomer As DataRow) As Integer
        Return drCustomer("svod_adult")
    End Function

    Public Function GetCustomersValidityPeriod(ByVal drCustomer As DataRow) As String
        Return drCustomer("validity_period")
    End Function

    Public Function GetPaymentId(ByVal drCustomer As DataRow) As Integer
        Return drCustomer("payment_id")
    End Function

    Public Function GetCustomersEmail(ByVal drCustomer As DataRow) As String
        Return drCustomer("email")
    End Function

    Public Function GetCustomersLastAbo(ByVal drCustomer As DataRow) As Integer
        Return drCustomer("customers_abo_type")
    End Function

    Private Function getCustomersTypeAbo(ByVal drCustomer As DataRow) As Integer
        Return drCustomer("customers_next_abo_type")
    End Function

    Private Function GetCustomersAbo(ByVal drCustomer As DataRow) As Integer
        Dim product_id As Integer
        Dim customers_id As Integer
        Dim sql As String
        product_id = getCustomersTypeAbo(drCustomer)
        customers_id = GetCustomersId(drCustomer)

        sql = PlushData.ClsBatchOgone.GetLastAboIdCustomers(customers_id, product_id)
        Return PlushData.clsConnection.ExecuteScalar(sql)

    End Function

    Private Function GetCustomersLastAboAction(ByVal drCustomer As DataRow) As ClsCustomersData.TypeAction
        Dim customers_id As Integer
        Dim sql As String
        customers_id = GetCustomersId(drCustomer)

        sql = PlushData.ClsBatchOgone.GetCustomersLastAboAction(customers_id)
        Return PlushTools.clsEnum.getValueEnum(PlushData.clsConnection.ExecuteScalar(sql))

    End Function

    Private Function GetCustomersPaymentMethod(ByVal drCustomer As DataRow) As Integer
        Return drCustomer("customers_abo_payment_method")
    End Function

    Private Sub CreateAboStopHistory(ByVal drCustomer As DataRow, ByVal reason As ClsCustomersData.AboStopReason, ByVal comment As String)
        Dim customers_id As Integer
        Dim sql As String

        customers_id = GetCustomersId(drCustomer)
        sql = ClsCustomersData.GetInsertHistoryAboStop(customers_id, reason, comment)
        PlushData.clsConnection.ExecuteNonQuery(sql)

    End Sub

    Private Sub CreateaboHistory(ByVal drCustomer As DataRow, ByVal ta As ClsCustomersData.TypeAction, Optional ByVal code_id As String = "null")
        Dim product_id As Integer
        Dim customers_id As Integer
        Dim sql As String

        Dim payment_methode_id As Integer
        product_id = getCustomersTypeAbo(drCustomer)

        customers_id = GetCustomersId(drCustomer)

        payment_methode_id = GetCustomersPaymentMethod(drCustomer)
        Dim payment_methode_value As String = GetStrPayment_method(payment_methode_id)

        sql = PlushData.ClsCustomersData.GetInsertHistoryAbo(customers_id, code_id, product_id, payment_methode_value, ta)
        PlushData.clsConnection.ExecuteNonQuery(sql)


    End Sub
    'Public Sub aboStopDebug()
    '    Dim sql As String
    '    Dim dt As DataTable

    '    sql = DvdPostData.ClsCustomersData.getAboStopDebug()

    '    dt = DvdPostData.clsConnection.FillDataSet(sql)


    '    For Each dr As DataRow In dt.Rows
    '        AboStopRecovery(dr)
    '    Next


    'End Sub

    Public Sub AboStopManual(ByVal drCustomer As DataRow, ByVal reason_id As Integer, ByVal comment As String)
        AboStop(drCustomer, reason_id, comment)
    End Sub
    Public Sub AboStopRecovery(ByVal drCustomer As DataRow)
        AboStop(drCustomer, ClsCustomersData.AboStopReason.RECOVERY, "LETTER2")
    End Sub

    Public Sub AboAutoStop(ByVal drCustomer As DataRow)
        AboStop(drCustomer, ClsCustomersData.AboStopReason.AUTOSTOP, "RECONDUCTION")
    End Sub

    Private Sub AboStop(ByVal drCustomer As DataRow, ByVal reason As Integer, ByVal comment As String)
        Dim sql As String
        Dim customers_id As Integer
        Dim cpt_update As Integer
        customers_id = GetCustomersId(drCustomer)

        sql = PlushData.ClsCustomersData.GetUpdateAboStop(customers_id)
        cpt_update = PlushData.clsConnection.ExecuteNonQuery(sql)
        ' si la personne est deja arrete
        If cpt_update = 0 Then Return

        'sql = PlushData.ClsCustomersData.GetUpdateResetPointFather(customers_id)
        'PlushData.clsConnection.ExecuteNonQuery(sql)

        'sql = PlushData.ClsCustomersData.GetUpdateResetPointFreeTrial(customers_id)
        'PlushData.clsConnection.ExecuteNonQuery(sql)


        'CreateAboStopHistory(drCustomer, reason, comment)
        CreateaboHistory(drCustomer, ClsCustomersData.TypeAction.ACTION_STOP)

        'clsMail.SendMail(customers_id, clsMail.Mail.MAIL_STOP)

        'ClsCustomers.CreateInvoiceLongtime(customers_id)
    End Sub
    Private Function IsAutoStop(ByVal dr As DataRow) As Boolean
        Return dr("customers_abo_auto_stop_next_reconduction") = 1
    End Function
    Private Function IsLocedForReconduction(ByVal dr As DataRow) As Boolean
        Return dr("customers_locked__for_reconduction") = 1
    End Function
    Private Function IsADULTSVODStop(ByVal dr As DataRow) As Boolean
        Return dr("svod_adult") = AdultSVODStatus.STOP_ADULT_SVOD
    End Function

    Private Function IsRecurringDiscount(ByVal dr As DataRow) As Boolean
        Return dr("recurring_discount") = 1
    End Function
    Private Function IsRecurringDiscountCode(ByVal dr As DataRow) As Boolean
        Return dr("discount_recurring_nbr_of_month") > 0
    End Function
    Private Function GetActivationDiscountCode(ByVal drCustomer As DataRow) As Integer
        If drCustomer("activation_discount_code_id") IsNot DBNull.Value Then
            Return drCustomer("activation_discount_code_id")
        End If
        Return 0
    End Function
    Private Function IsDiscount(ByVal drCustomer As DataRow) As Boolean
        Return drCustomer("activation_discount_code_type") = ClsCustomersData.CODE_DISCOUNT
    End Function

    Private Function IsActivation(ByVal drCustomer As DataRow) As Boolean
        Return drCustomer("activation_discount_code_type") = ClsCustomersData.CODE_ACTIVATION
    End Function
    Private Function GetPriceProduct(ByVal drCustomer As DataRow) As Decimal
        Return drCustomer("products_price")
    End Function
    Private Function GetDiscountActivationDVDRemain(ByVal drDiscountActivation As DataRow) As Integer
        If drDiscountActivation("abo_dvd_remain") Is DBNull.Value Then
            Return -1
        Else
            Return drDiscountActivation("abo_dvd_remain")
        End If

    End Function
    Private Function GetDiscountActivationCredit(ByVal drDiscountActivation As DataRow) As Integer
        If drDiscountActivation("abo_dvd_credit") Is DBNull.Value Then
            Return 0
        Else
            Return drDiscountActivation("abo_dvd_credit")
        End If

    End Function

    Private Function GetDiscountCodeTypeDate(ByVal drdiscount As DataRow) As Integer
        Return drdiscount("discount_abo_validityto_type")
    End Function

    Private Function GetDiscountCodeValueDate(ByVal drdiscount As DataRow) As Integer
        Return drdiscount("discount_abo_validityto_value")
    End Function

    Private Function GetActivationCodeType(ByVal drActivation As DataRow) As Integer
        Return drActivation("type")
    End Function

    Private Function GetActivationCodeValue(ByVal drAcvtivation As DataRow) As Integer
        Return drAcvtivation("value")
    End Function

    Private Function GetDiscountCodeType(ByVal drDiscount As DataRow) As Integer
        Return drDiscount("type")
    End Function
    Private Function GetDroseliaValue(ByVal drDiscountActivation As DataRow) As Integer
        If drDiscountActivation("droselia") Is DBNull.Value Then
            Return 0
        Else
            Return drDiscountActivation("droselia")
        End If


    End Function

    Private Function GetDiscountCodeValue(ByVal drDiscount As DataRow) As Decimal
        Return drDiscount("value")
    End Function

    Private Function GetNextDiscountCode(ByVal drCustomer As DataRow, ByVal drDiscount As DataRow) As Integer
        Dim id As Integer

        id = getCustomersNextDiscount(drCustomer)
        If id > 0 Then
            Return id
        Else
            If drDiscount Is Nothing Then
                Return 0
            Else
                Return drDiscount("next_discount")
            End If

        End If

    End Function

    Private Function Getdiscount_recurring_nbr_of_month(ByVal drDiscount As DataRow) As Integer
        Return drDiscount("discount_recurring_nbr_of_month")
    End Function



    Private Function ManageReduction(ByRef drCustomer As DataRow, _
                                     ByRef strDurationActivation As String, _
                                     Optional ByVal Classique As Boolean = True) As String
        Dim productPrice As Decimal
        Dim drDiscount As DataRow
        Dim sql As String
        strDurationActivation = ""

        'productPrice = GetPriceProduct(drCustomer) - not used any more

        If IsDiscount(drCustomer) Then
            productPrice = ManagePriceDiscount(drCustomer, strDurationActivation, Classique)
        ElseIf IsActivation(drCustomer) Then
            productPrice = ManagePriceActivation(drCustomer, strDurationActivation, Classique)
        Else ' forced next discount code 
            drDiscount = ManagePriceNextDiscount(drCustomer, Nothing, strDurationActivation)
            If drDiscount Is Nothing Then
                'forcedcredit = 0
                'cptdroselia = 0
                productPrice = GetPriceProduct(drCustomer)
            Else
                'forcedcredit = GetDiscountActivationCredit(drDiscount)
                'cptdroselia = GetDroseliaValue(drDiscount)
                productPrice = CalcAmountAbo(GetDiscountCodeType(drDiscount), GetPriceProduct(drCustomer), GetDiscountCodeValue(drDiscount))
            End If

        End If

        Return PlushTools.ClsPrice.FormatPrice(productPrice)
    End Function
    Private Function GetRowDiscount(ByVal discount_id As Integer) As DataRow
        Dim sql As String
        Dim dtDiscount As DataTable

        sql = PlushData.ClsCustomersData.GetSelectDiscountCode(discount_id)
        dtDiscount = PlushData.clsConnection.FillDataSet(sql)
        If dtDiscount.Rows.Count <> 1 Then
            'clsMsgError.MsgBox("ERROR DISCOUNT CODE " & discount_id)
            Return Nothing
        End If
        Return dtDiscount.Rows(0)
    End Function

    Private Function GetRowActivation(ByVal activation_id As Integer) As DataRow
        Dim sql As String
        Dim dtActivation As DataTable

        sql = PlushData.ClsCustomersData.GetSelectActivationCode(activation_id)
        dtActivation = PlushData.clsConnection.FillDataSet(sql)
        If dtActivation.Rows.Count <> 1 Then
            Return Nothing
        End If
        Return dtActivation.Rows(0)
    End Function

#Region "Initialisation"

    Private Function GetQtyDvd(ByVal abo_id As Integer) As Integer
        Dim sql As String
        Dim qtydvd As Integer
        sql = PlushData.ClsCustomersData.GetSelectQtyDvd(abo_id)
        qtydvd = PlushData.clsConnection.ExecuteScalar(sql)

        Return qtydvd

    End Function
    'Private Function ManageDroselia(ByVal drCustomer As DataRow) As Integer
    '    Dim droselia As Integer

    '    If IsDiscount(drCustomer) Then
    '        droselia = ManageDroseliaDiscount(drCustomer)
    '    ElseIf IsActivation(drCustomer) Then
    '        droselia = ManageDroseliaActivation(drCustomer)
    '    Else
    '        Return 0
    '    End If

    'End Function

    Private Sub activeAboCustomer(ByVal customers_id As Integer, ByVal domiciliation As Boolean)
        Dim sql As String

        sql = PlushData.ClsCustomersData.GetUpdateValidAbo(customers_id, domiciliation)
        PlushData.clsConnection.ExecuteNonQuery(sql)

        sql = PlushData.ClsCustomersData.GetUpdateValidityTo(customers_id)
        PlushData.clsConnection.ExecuteNonQuery(sql)

        sql = PlushData.ClsCustomersData.GetUpdateNewClientRank(customers_id)
        PlushData.clsConnection.ExecuteNonQuery(sql)

    End Sub
    'Private Function GetCptDroselia(ByVal drReduction As DataRow) As Integer

    '    If Not drReduction Is Nothing Then
    '        Return GetDroseliaValue(drReduction)
    '    Else
    '        Return 0
    '    End If

    'End Function

    '''' <summary>
    '''' search droselia in discount
    '''' </summary>
    '''' <param name="drCustomer"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Private Function ManageDroseliaDiscount(ByVal drCustomer As DataRow) As Integer
    '    Dim activation_id As Integer
    '    Dim drDiscount As DataRow
    '    Dim customers_id As Integer

    '    customers_id = GetCustomersId(drCustomer)
    '    activation_id = drCustomer("activation_discount_code_id")
    '    drDiscount = GetRowDiscount(activation_id)

    '    Return GetCptDroselia(drDiscount)

    'End Function
    '''' <summary>
    '''' cpt droselia in activation 
    '''' </summary>
    '''' <param name="drCustomer"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Private Function ManageDroseliaActivation(ByVal drCustomer As DataRow) As Integer
    '    Dim activation_id As Integer
    '    Dim drActivation As DataRow
    '    Dim customers_id As Integer

    '    customers_id = GetCustomersId(drCustomer)
    '    activation_id = drCustomer("activation_discount_code_id")
    '    drActivation = GetRowActivation(activation_id)

    '    Return GetCptDroselia(drActivation)

    'End Function
    ''' <summary>
    ''' getcptdroselia 
    ''' update validityto = now()
    ''' update customers_dvd_home 
    ''' </summary>
    ''' <param name="customers_id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Initialisation(ByVal customers_id As Integer, ByVal domiciliation As Boolean) As Boolean
        Dim sql As String
        Dim dtCustomersReconduction As DataTable
        Dim cptDroselia As Integer = 0
        Dim aboType As Integer
        Dim email As String

        Try
            sql = PlushData.ClsCustomersData.GetSelectInitialisationCustomer(customers_id)
            dtCustomersReconduction = PlushData.clsConnection.FillDataSet(sql)
            If dtCustomersReconduction.Rows.Count = 0 Then
                Return False
            End If

            Dim drCustomers As DataRow = dtCustomersReconduction.Rows(0)

            PlushData.clsConnection.CreateTransaction(False)

            'cptDroselia = ManageDroselia(drCustomers)

            createActivationAboHistory(drCustomers)

            aboType = GetCustomersLastAbo(drCustomers)
            email = GetCustomersEmail(drCustomers)

            ' ---------------------------------------------
            ' the order calles is very important after UpdateParrainageSummer after UpdateParrainage
            ' UpdateParrainageSummer(customers_id)
            ' UpdateParrainage(customers_id, email, aboType)
            ' ---------------------------------------------
            activeAboCustomer(customers_id, domiciliation)
            UpdateQtyDvd(drCustomers)

            PlushData.clsConnection.CommitTransaction(True)
            Return True

        Catch ex As Exception
            PlushData.clsConnection.CommitTransaction(False)
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex)
            Return False
        End Try


    End Function

#End Region
#Region "Reconduction"
    Private Sub UpdateDateReconduction(ByVal drCustomer As DataRow, ByVal sqlDurationActivation As String)

        Dim sql As String

        sql = PlushData.ClsCustomersData.GetUpdateDateValidity(GetCustomersId(drCustomer), sqlDurationActivation)
        PlushData.clsConnection.ExecuteNonQuery(sql)
    End Sub

    'copy next discount code and duration of next discount, if exists, to discount_code in column customers.activation_discount_code_id
    Private Function ManagePriceNextDiscount(ByVal drcustomer As DataRow, _
                                             ByVal drReduction As DataRow, _
                                             ByRef strDurationActivation As String) As DataRow
        ' Get Next Discount Code  
        Dim discount_id As Integer
        Dim drNextDiscount As DataRow
        Dim customers_id As Integer
        customers_id = GetCustomersId(drcustomer)

        discount_id = GetNextDiscountCode(drcustomer, drReduction)
        drNextDiscount = GetRowDiscount(discount_id)
        Dim sql As String

        If drNextDiscount Is Nothing Then
            'sql = DvdPostData.ClsCustomersData.GetUpdateDiscountCode(customers_id, 0, 0, "")
            'DvdPostData.clsConnection.ExecuteNonQuery(sql)
            Return Nothing
        Else
            strDurationActivation = GetDurationActivation(GetDiscountCodeTypeDate(drNextDiscount), GetDiscountCodeValueDate(drNextDiscount))
            sql = PlushData.ClsCustomersData.GetUpdateDiscountCode(customers_id, discount_id, Getdiscount_recurring_nbr_of_month(drNextDiscount), ClsCustomersData.CODE_DISCOUNT)
            PlushData.clsConnection.ExecuteNonQuery(sql)

            sql = PlushData.ClsCustomersData.GetInsertDiscountUse(customers_id, discount_id)
            PlushData.clsConnection.ExecuteNonQuery(sql)

            Return drNextDiscount
        End If


    End Function
    Private Sub UpdateNextProduct(ByVal drCode As DataRow, ByVal customers_id As Integer, ByRef drCustomer As DataRow)
        ' le customers_next_abo_type est prioritaire sur le next_abo_type 

        Dim nextproduct_id As Integer
        If ((drCustomer("customers_next_abo_type") Is Nothing OrElse drCustomer("customers_next_abo_type") = 0)) _
             AndAlso drCode IsNot Nothing AndAlso drCode("next_abo_type") IsNot DBNull.Value Then
            nextproduct_id = drCode("next_abo_type")
            drCustomer("customers_next_abo_type") = nextproduct_id
            Dim sql As String
            Dim price As Decimal
            sql = PlushData.ClsCustomersData.GetPriceAbo(nextproduct_id)
            price = PlushData.clsConnection.ExecuteScalar(sql)
            drCustomer("products_price") = price

            sql = PlushData.ClsCustomersData.GetUpdateNextProductType(customers_id, nextproduct_id)
            PlushData.clsConnection.ExecuteNonQuery(sql)
        End If

    End Sub

    Private Function ManagePriceDiscount(ByRef drCustomer As DataRow, _
                                        ByRef strDurationActivation As String, _
                                        Optional ByVal Classique As Boolean = True) As String
        Dim discount_id As Integer
        Dim drDiscount As DataRow = Nothing
        Dim customers_id As Integer
        Dim sql As String
        customers_id = GetCustomersId(drCustomer)

        If drCustomer("activation_discount_code_id") IsNot DBNull.Value Then
            discount_id = drCustomer("activation_discount_code_id")
            drDiscount = GetRowDiscount(discount_id)
        End If

        'calculate price, from next discount code, set next product type in customers table. price is in drCustomer("products_price")
        UpdateNextProduct(drDiscount, customers_id, drCustomer)

        'always is classic,just sometime is not
        If Classique Then

            'currently this is not used
            If Not IsRecurringDiscount(drCustomer) Then

                'returns next discount code
                drDiscount = ManagePriceNextDiscount(drCustomer, drDiscount, strDurationActivation)
            End If
        Else
            ' parrainage classique 
            'ClsWebServices.CallUrlSponsor(customers_id, 0)
            If IsRecurringDiscountCode(drDiscount) Then
                ActivateRecurringDiscountCode(drCustomer, drDiscount, discount_id, strDurationActivation)
            End If
        End If

        If drDiscount Is Nothing Then ' discount doesn't exists
            Return GetPriceProduct(drCustomer)
        Else ' if discount exists then calculate price with discount
            'forcedcredit = GetDiscountActivationCredit(drDiscount)

            'just info thatcustomer use discount
            sql = PlushData.ClsCustomersData.GetInsertDiscountUse(customers_id, discount_id)
            PlushData.clsConnection.ExecuteNonQuery(sql)

            strDurationActivation = GetDurationActivation(GetDiscountCodeTypeDate(drDiscount), GetDiscountCodeValueDate(drDiscount))

            Return CalcAmountAbo(GetDiscountCodeType(drDiscount), GetPriceProduct(drCustomer), GetDiscountCodeValue(drDiscount))


        End If


    End Function
    Private Function ManagePriceActivation(ByRef drCustomer As DataRow, _
                                      ByRef StrDurationActivation As String, _
                                      Optional ByVal Classique As Boolean = True) As String
        Dim activation_id As Integer
        Dim drActivation As DataRow
        Dim drNextDiscount As DataRow


        Dim customers_id As Integer

        customers_id = GetCustomersId(drCustomer)
        activation_id = drCustomer("activation_discount_code_id")
        drActivation = GetRowActivation(activation_id)

        UpdateNextProduct(drActivation, customers_id, drCustomer)

        If Classique Then
            drNextDiscount = ManagePriceNextDiscount(drCustomer, drActivation, StrDurationActivation)
            If drNextDiscount Is Nothing Then
                'forcedcredit = 0
                'forceddvdremain = -1
                'droselia = 0
                Return GetPriceProduct(drCustomer)
            Else
                'forcedcredit = GetDiscountActivationCredit(drNextDiscount)
                'forceddvdremain = GetDiscountActivationDVDRemain(drNextDiscount)
                'droselia = GetDroseliaValue(drNextDiscount)
                Return CalcAmountAbo(GetDiscountCodeType(drNextDiscount), GetPriceProduct(drCustomer), GetDiscountCodeValue(drNextDiscount))

            End If
        Else

            If drActivation Is Nothing Then
                'forcedcredit = 0
                'forceddvdremain = 0
                'droselia = 0
                Return "0"
            Else

                'ClsWebServices.CallUrlSponsor(customers_id, activation_id)
                'forcedcredit = GetDiscountActivationCredit(drActivation)
                'forceddvdremain = GetDiscountActivationDVDRemain(drActivation)
                StrDurationActivation = GetDurationActivation(GetActivationCodeType(drActivation), GetActivationCodeValue(drActivation))
                'droselia = GetDroseliaValue(drActivation)
                Return "0"
            End If


        End If

    End Function

    Private Function GetPackageCount(ByVal abo_id As Integer) As Integer
        Dim sql As String
        Dim credit As Integer
        sql = PlushData.ClsCustomersData.GetSelectCredit(abo_id)
        credit = PlushData.clsConnection.ExecuteScalar(sql)

        Return credit

    End Function

    Private Function GetNPPCredit(ByVal abo_id As Integer) As DataTable
        Dim sql As String
        Dim dtCredit As DataTable
        sql = PlushData.ClsCustomersData.GetSelectNPPCredit(abo_id)
        dtCredit = PlushData.clsConnection.FillDataSet(sql)

        Return dtCredit

    End Function

    'Private Sub ManageUpdateCredit(ByVal drCustomer As DataRow, ByVal price As String, Optional ByVal Forcedcredit As Integer = 0, Optional ByVal Forceddvdremain As Integer = 0)

    '    Dim dt As DataTable
    '    dt = GetInfoAttributesCustomer(GetCustomersId(drCustomer))

    '    If dt.Rows(0)("credits_already_recieved") = 0 Then
    '        UpdateCredit(drCustomer, price, Forcedcredit, Forceddvdremain)
    '    Else
    '        Dim sql As String
    '        sql = PlushData.ClsCustomersData.GetUpdateCreditsAlreadyRecieved(GetCustomersId(drCustomer))
    '        PlushData.clsConnection.ExecuteNonQuery(sql)
    '    End If

    'End Sub

    'Private Sub UpdateCredit(ByVal drCustomer As DataRow, ByVal price As String, Optional ByVal Forcedcredit As Integer = 0, Optional ByVal Forceddvdremain As Integer = 0)
    '    Try
    '        If drCustomer("npp_logic") = 0 Then
    '            Dim sql As String
    '            Dim credit As Integer
    '            Dim creditAction As PlushData.clsCreditHistory.ActionId

    '            If Forcedcredit = 0 Then
    '                credit = GetCredit(getCustomersTypeAbo(drCustomer))
    '            Else
    '                credit = Forcedcredit
    '            End If

    '            If price = 0 Then
    '                creditAction = clsCreditHistory.ActionId.FREERECONDUCTION
    '            Else
    '                creditAction = clsCreditHistory.ActionId.RECONDUCTION
    '            End If

    '            InsertCreditHistory(GetCustomersId(drCustomer), creditAction, credit, drCustomer("combined") = 1)
    '            If drCustomer("combined") = 1 Then
    '                sql = PlushData.ClsCustomersData.GetUpdateCredit(GetCustomersId(drCustomer), credit)

    '            Else
    '                sql = PlushData.ClsCustomersData.GetUpdateCreditNoCombined(GetCustomersId(drCustomer), credit)

    '            End If
    '            PlushData.clsConnection.ExecuteNonQuery(sql)
    '        Else
    '            Dim sql As String
    '            Dim dtCredit As DataTable
    '            Dim creditAction As PlushData.clsCreditHistory.ActionId

    '            If Forcedcredit = 0 Then
    '                dtCredit = GetNPPCredit(getCustomersTypeAbo(drCustomer))
    '            Else
    '                'credit = Forcedcredit
    '                dtCredit = New DataTable()
    '                dtCredit.Columns.Add("qty_credit", Type.GetType("System.Int32"))
    '                dtCredit.Columns.Add("qty_dvd_max", Type.GetType("System.Int32"))
    '                Dim dr As DataRow = dtCredit.NewRow()
    '                dr("qty_credit") = Forcedcredit
    '                If (Forceddvdremain = -1) Then
    '                    Dim dtRemain As DataTable = GetNPPCredit(getCustomersTypeAbo(drCustomer))
    '                    dr("qty_dvd_max") = dtRemain.Rows(0)("qty_dvd_max")
    '                Else
    '                    dr("qty_dvd_max") = Forceddvdremain
    '                End If
    '                dtCredit.Rows.Add(dr)
    '            End If

    '            If price = 0 Then
    '                creditAction = clsCreditHistory.ActionId.FREERECONDUCTION
    '            Else
    '                creditAction = clsCreditHistory.ActionId.RECONDUCTION
    '            End If

    '            InsertCreditHistory(GetCustomersId(drCustomer), creditAction, dtCredit.Rows(0)("qty_credit"), False)

    '            sql = PlushData.ClsCustomersData.GetUpdateNPPCredit(GetCustomersId(drCustomer), dtCredit.Rows(0)("qty_credit"), dtCredit.Rows(0)("qty_dvd_max"))
    '            PlushData.clsConnection.ExecuteNonQuery(sql)
    '        End If
    '    Catch ex As Exception
    '        Dim i As Int16 = 0
    '    End Try


    'End Sub

    Private Sub InsertCreditHistory(ByVal customersId As Integer, ByVal creditAction As PlushData.clsCreditHistory.ActionId, ByVal qtyCredit As Integer, Optional ByVal combined As Boolean = True)
        Dim sql As String = ""
        Try
            sql = PlushData.clsCreditHistory.GetInsertCreditHistory(qtyCredit, customersId, creditAction, combined)
            PlushData.clsConnection.ExecuteNonQuery(sql)
        Catch ex As Exception
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex.Message & " sql error |" & sql & "|", customersId)
        End Try
    End Sub
    Private Sub InsertNPPCreditHistory(ByVal customersId As Integer, ByVal creditAction As PlushData.clsCreditHistory.ActionId, ByVal qtyCredit As Integer, ByVal qtyDvdMax As Integer, Optional ByVal combined As Boolean = True)
        Dim sql As String = ""
        Try
            sql = PlushData.clsCreditHistory.GetInsertNPPCreditHistory(qtyCredit, qtyDvdMax, customersId, creditAction, combined)
            PlushData.clsConnection.ExecuteNonQuery(sql)
        Catch ex As Exception
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex.Message & " sql error |" & sql & "|", customersId)
        End Try
    End Sub
    Public Function GetInfoAttributesCustomer(ByVal customers_id As Integer) As DataTable

        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.ClsCustomersData.GetSelectInfoAttributesCustomer(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt

    End Function
    Public Function GetInfoNextReconduction(ByVal customers_id As Integer, _
                                             ByRef nextPrice As String) As Boolean

        Dim sql As String
        Dim cptDroselia As Integer = 0
        Dim sqlDurationActivation As String = ""
        'Dim Forcedcredit As Integer
        'Dim Forceddvdremain As Integer

        Dim dtCustomersReconduction As DataTable

        PlushData.clsConnection.CreateTransaction(True)

        sql = PlushData.ClsCustomersData.GetSelectInfoNextReconductionCustomers(customers_id)
        dtCustomersReconduction = PlushData.clsConnection.FillDataSet(sql)

        For Each drCustomers As DataRow In dtCustomersReconduction.Rows
            If IsAutoStop(drCustomers) Then
                PlushData.clsConnection.CancelBulkQuery()
                Return False
            Else
                nextPrice = ManageReduction(drCustomers, sqlDurationActivation)
                'If Forcedcredit = 0 Then
                '    If (PlushBuziness.ClsInventory.isNPP(customers_id)) Then
                '        Dim dt As DataTable = GetNPPCredit(getCustomersTypeAbo(drCustomers))
                '        creditNext = dt.Rows(0)(0)
                '        dvdremainNext = dt.Rows(0)(1)
                '    Else
                '        creditNext = GetCredit(getCustomersTypeAbo(drCustomers))
                '        dvdremainNext = 0
                '    End If
                'Else
                '    creditNext = Forcedcredit
                '    If (PlushBuziness.ClsInventory.isNPP(customers_id)) Then
                '        Dim dtRemain As DataTable = GetNPPCredit(getCustomersTypeAbo(drCustomers))
                '        dvdremainNext = dtRemain.Rows(0)("qty_dvd_max")
                '    Else
                '        dvdremainNext = Forceddvdremain
                '    End If

                'End If

            End If
        Next

        PlushData.clsConnection.CancelBulkQuery()
        Return True
    End Function

    Public Sub StopSVODADULT(ByVal customers_id As Integer)
        Dim sql As String
        sql = PlushData.ClsCustomersData.GetStopADULTSVOD(customers_id)
        PlushData.clsConnection.ExecuteNonQuery(sql)
    End Sub

    Private Function ReconductionADULTSVOD(ByVal pay_method As ClsCustomersData.Payment_Method, ByVal idcountry As Integer, _
                                 Optional ByVal customers_id As Integer = -1) As DataTable
        Dim dtCustomersReconduction As DataTable
        Dim sql As String
        Dim dtResult As DataTable
        Dim currentcustomers_id As Integer
        Dim customers_validity_period As String
        Dim price As String
        Dim sqlUpdate As String
        If pay_method = ClsCustomersData.Payment_Method.PAYPAL Then
            sql = PlushData.ClsCustomersData.GetSelectPAYPALReconductionADULTSVOD(pay_method, idcountry, customers_id)
        Else
            sql = PlushData.ClsCustomersData.GetSelectReconductionADULTSVOD(pay_method, idcountry, customers_id)
        End If

        dtCustomersReconduction = PlushData.clsConnection.FillDataSet(sql)
        RaiseEvent initMapping_Event(dtCustomersReconduction.Rows.Count)
        dtResult = createTableResult(dtCustomersReconduction)
        If clsMsgError.MsgBox("Are you sur to process " & dtCustomersReconduction.Rows.Count & " ReconductionsADULTSVOD " & PlushTools.clsEnum.getNameStrEnum(pay_method) & " ? ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Try
                PlushData.clsConnection.CreateTransaction(False)
                For Each drCustomers As DataRow In dtCustomersReconduction.Rows
                    currentcustomers_id = GetCustomersId(drCustomers)
                    price = PlushTools.ClsPrice.FormatPrice(GetPriceProduct(drCustomers))
                    drCustomers("amount") = price
                    customers_validity_period = GetCustomersValidityPeriod(drCustomers)
                    If IsADULTSVODStop(drCustomers) Then
                        Dim sqlStop As String
                        CreateaboHistory(drCustomers, ClsCustomersData.TypeAction.ACTION_RECONDUCTION_STOP_ADULT_SVOD)
                        sqlStop = PlushData.ClsCustomersData.GetStopADULTSVOD(currentcustomers_id)
                        PlushData.clsConnection.ExecuteNonQuery(sqlStop)
                    Else
                        sqlUpdate = PlushData.ClsCustomersData.GetUpdateADULTSVOD(currentcustomers_id, customers_validity_period)
                        PlushData.clsConnection.ExecuteNonQuery(sqlUpdate)

                        If Decimal.Parse(price) > 0 Then 'add row in memory structure in order to generate invoce
                            dtResult.Rows.Add(drCustomers.ItemArray())
                        End If
                        createReconductionAboHistoryADULTSVOD(drCustomers, price)
                    End If
                Next
                PlushData.clsConnection.CommitTransaction(True)
                clsMsgError.MsgBox("ReconductionADULTSVOD " & PlushTools.clsEnum.getNameStrEnum(pay_method) & vbNewLine & " Customers Paid : " & dtResult.Rows.Count)
            Catch ex As Exception
                PlushData.clsConnection.CommitTransaction(False)
                dtResult.Clear()
                clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex, currentcustomers_id)
                Throw ex
            End Try
        End If

        Return dtResult
    End Function



    ''' <summary>
    ''' reconduction de type classique 
    ''' sinon reconduction Immediat 
    ''' </summary>
    ''' <param name="pay_method"></param>
    ''' <param name="idcountry"></param>
    ''' <param name="customers_id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Reconduction(ByVal pay_method As ClsCustomersData.Payment_Method, _
                                 ByVal idcountry As ClsCustomersData.Country, _
                                 Optional ByVal customers_id As Integer = -1, _
                                 Optional ByVal classique As Boolean = True, Optional ByVal forced As Boolean = False) As DataTable
        Dim dtCustomersReconduction As DataTable
        Dim sql As String
        Dim price As String
        Dim cpt As Integer
        Dim currentcustomers_id As Integer
        Dim cptDroselia As Integer = 0
        Dim dtResult As DataTable
        Dim cptFreeTrialist As Integer
        Dim email As String

        If pay_method = ClsCustomersData.Payment_Method.PAYPAL Then
            sql = PlushData.ClsCustomersData.GetSelectReconductionPayPalCustomers(pay_method, idcountry, customers_id)
        Else
            sql = PlushData.ClsCustomersData.GetSelectReconductionCustomers(pay_method, idcountry, customers_id)

        End If

        dtCustomersReconduction = PlushData.clsConnection.FillDataSet(sql)
        RaiseEvent initMapping_Event(dtCustomersReconduction.Rows.Count)
        dtResult = createTableResult(dtCustomersReconduction)
        Dim forcedcredit As Integer = 0
        Dim forceddvdremain As Integer = -1
        Dim sqlDurationActivation As String

        If clsMsgError.MsgBox("Are you sur to process " & dtCustomersReconduction.Rows.Count & " Reconductions " & PlushTools.clsEnum.getNameStrEnum(pay_method) & " ? ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Try
                PlushData.clsConnection.CreateTransaction(False)
                For Each drCustomers As DataRow In dtCustomersReconduction.Rows


                    currentcustomers_id = GetCustomersId(drCustomers)
                    email = GetCustomersEmail(drCustomers)
                    ' customers_id = -1 : uniquement dans le cas ou on fait la reconduction en masse  
                    If IsAutoStop(drCustomers) And classique And Not IsRecurringDiscount(drCustomers) Then
                        AboAutoStop(drCustomers)
                    Else

                        'calculate the price
                        price = ManageReduction(drCustomers, sqlDurationActivation, classique)

                        drCustomers("amount") = price
                        If Decimal.Parse(price) > 0 Then 'add row in memory structure in order to gerate invoce
                            dtResult.Rows.Add(drCustomers.ItemArray())
                            'clsMemberGetMember.AddPointFather(currentcustomers_id)

                        End If
                        If classique Or (Decimal.Parse(price) = 0) Or forced Then
                            'ManageUpdateCredit(drCustomers, price, forcedcredit, forceddvdremain)
                            UpdateDateReconduction(drCustomers, sqlDurationActivation)
                            createReconductionAboHistory(drCustomers, price)
                            'If classique Then
                            updateProductType(drCustomers)
                            '    UpdateQtyDvdNormAdult(drCustomers)
                            'End If

                            updatelockedReconduction(drCustomers)
                        Else
                            dtResult.Clear()
                            PlushData.clsConnection.CommitTransaction(False)
                            Return dtResult
                        End If

                        'If Not classique Then
                        '    ' lien webservice 
                        'End If
                    End If
                    cpt += 1
                    ' create line file
                    ' cpt_droselia n'est pas gere dans la reconduction 

                    RaiseEvent stepMapping_event(cpt)
                    'DvdPostData.clsConnection.CommitTransaction(True)

                Next
                'cptFreeTrialist = dtCustomersReconduction.Rows.Count - dtResult.Rows.Count
                PlushData.clsConnection.CommitTransaction(True)
                clsMsgError.MsgBox("Reconduction " & PlushTools.clsEnum.getNameStrEnum(pay_method) & vbNewLine & "Free Trialist : " & cptFreeTrialist & vbNewLine & " Customers Paid : " & dtResult.Rows.Count)

            Catch ex As Exception
                PlushData.clsConnection.CommitTransaction(False)

                'sql = ClsCustomersData.GetSuspendedCustomersError(customers_id)
                'DvdPostData.clsConnection.ExecuteNonQuery(sql)
                'Dim lstDr As DataRow()
                'lstDr = dtResult.Select("customers_id = " & customers_id)
                'If lstDr.Length > 0 Then
                '    dtResult.Rows.Remove(lstDr(0))
                'End If
                dtResult.Clear()
                clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex, currentcustomers_id)
                Throw ex
            End Try
        End If

        Return dtResult
    End Function
#End Region



    'Private Sub UpdateActivationNextDiscountCode(ByVal drCustomer As DataRow)

    '    Dim sql As String

    '    sql = DvdPostData.ClsCustomersData.GetUpdateActivationNextDiscountCode(GetCustomersId(drCustomer))
    '    DvdPostData.clsConnection.ExecuteNonQuery(sql)

    'End Sub
    'Private Sub UpdateNextDiscountCode(ByVal drCustomer As DataRow)

    '    Dim sql As String

    '    sql = DvdPostData.ClsCustomersData.GetUpdateNextDiscountCode(GetCustomersId(drCustomer))
    '    DvdPostData.clsConnection.ExecuteNonQuery(sql)

    'End Sub

    Private Sub CalculateQtyDVDNormAdult(ByVal total As Integer, ByRef qtynorm As Integer, ByRef qtyAdult As Integer)
        ' no changed
        If total <> qtynorm + qtyAdult Then
            ' upgrade 
            If total > qtynorm + qtyAdult Then
                qtynorm = total - qtyAdult
                ' downgrade
            Else
                If total > qtynorm Then
                    qtyAdult = total - qtynorm
                End If

                If total > qtyAdult Then
                    qtynorm = total - qtyAdult
                End If

                If total <= qtynorm And total <= qtyAdult Then
                    If qtynorm >= qtyAdult Then
                        qtynorm = total
                        qtyAdult = 0
                    Else
                        qtyAdult = total
                        qtynorm = 0
                    End If

                End If

            End If
        End If
    End Sub
    Private Sub UpdateQtyDvdNormAdult(ByVal drCustomer As DataRow)

        Dim sql As String
        Dim total As Integer
        Dim qtynorm As Integer
        Dim qtyAdult As Integer

        qtynorm = getCustomersDvdNorm(drCustomer)
        qtyAdult = getCustomersDvdAdult(drCustomer)
        total = GetQtyDvd(getCustomersTypeAbo(drCustomer))
        CalculateQtyDVDNormAdult(total, qtynorm, qtyAdult)


        sql = PlushData.ClsCustomersData.GetUpdateQtyDvd(GetCustomersId(drCustomer), qtynorm, qtyAdult)
        PlushData.clsConnection.ExecuteNonQuery(sql)


    End Sub


    Private Sub UpdateQtyDvd(ByVal drCustomer As DataRow)

        Dim sql As String
        Dim qty As Integer
        qty = GetQtyDvd(GetCustomersLastAbo(drCustomer))

        sql = PlushData.ClsCustomersData.GetUpdateQtyDvd(GetCustomersId(drCustomer), qty)
        PlushData.clsConnection.ExecuteNonQuery(sql)


    End Sub

    Private Sub InitProgressBar(ByVal cpt As Integer)
        RaiseEvent initMapping_Event(cpt)
    End Sub

    Private Sub StepProgressBar(ByVal index As Integer)
        RaiseEvent stepMapping_event(index)
    End Sub
    Public Function RejetFileOgone() As Boolean
        Dim sql As String
        Dim dt As DataTable
        dt = New DataTable

        Dim batch As String
        Dim x As DateTime
        Dim day As Integer = (PlushBuziness.clsOffLinePayments.DAYS_CREATE_RECOVERY - 1) * -1
        x = DateTime.Now.AddDays(day)

        sql = PlushData.ClsBatchOgone.GetListCustomersRejectOgone(x)
        ' sql = DvdPostData.ClsBatchOgone.GetListCustomersHaveonePaymentLetter2()
        dt = PlushData.clsConnection.FillDataSet(sql)

        Dim clsBatchOgone As PlushBuziness.ClsBatchOgone = New PlushBuziness.ClsBatchOgone()

        AddHandler clsBatchOgone.initMapping_Event, AddressOf InitProgressBar
        AddHandler clsBatchOgone.stepMapping_event, AddressOf StepProgressBar

        batch = clsBatchOgone.CreateBatchFile(dt, PlushData.ClsCustomersData.Country.BELGIUM)

        If Not batch Is String.Empty Then
            Dim path As String
            path = clsBatchOgone.CreatePathFile(clsBatchOgone.TypeBatch.REJET_OGONE, PlushData.ClsCustomersData.Country.BELGIUM)
            PlushTools.clsFile.WriteFileNoExist(path, batch)
            PlushData.clsConnection.ExecuteNonQuery(PlushData.ClsBatchOgone.OgonePaymentBatch(batch))
            PlushBuziness.ClsBatchOgone.UpdateBatchId(dt)

            Return True
        End If
        Return False
    End Function
    Private Function createTableResult(ByVal dt As DataTable) As DataTable
        Dim dtResult As New DataTable

        'now add field1 to the arrayList
        For Each col As DataColumn In dt.Columns
            dtResult.Columns.Add(col.ColumnName)
        Next
        Return dtResult
    End Function
    Private Function Activation(ByVal pay_method As ClsCustomersData.Payment_Method, ByVal idcountry As ClsCustomersData.Country) As DataTable
        Dim dtResult As DataTable
        Dim sql As String
        sql = PlushData.ClsCustomersData.GetSelectActivationDomCustomers(pay_method, idcountry)
        dtResult = PlushData.clsConnection.FillDataSet(sql)

        Return dtResult
    End Function
    Public Function GenerateDroseliaCode(ByVal nbrCode As Integer, ByVal customers_id As Integer) As String
        Dim i As Integer
        Dim Droseliacode As String
        Dim rnd As Integer, randomNum As New Random
        Dim sql As String
        Dim str As String
        For i = 1 To nbrCode
            rnd = randomNum.Next(10000, 99999)
            Droseliacode = "CST" + rnd.ToString
            sql = PlushData.ClsDroselia.CreateCodeDroselia(Droseliacode, customers_id)
            PlushData.clsConnection.ExecuteNonQuery(sql)
            str &= Droseliacode & " , "
        Next

        Return str
    End Function
    'Public Sub UpdateParrainageSummer(ByVal customers_id As Integer)
    '    Dim sqlInfo As String
    '    Dim dtGodsonSponsorInfo As DataTable
    '    sqlInfo = DvdPostData.clsMemberGetMember.getGodsonAndSponsorInfo(customers_id)
    '    dtGodsonSponsorInfo = DvdPostData.clsConnection.FillDataSet(sqlInfo)

    '    If dtGodsonSponsorInfo.Rows.Count = 1 Then
    '        ' mail send to father
    '        DVDPostBuziness.clsMail.SendMail(dtGodsonSponsorInfo.Rows(0), clsMail.Mail.MAIL_SON_PAID, dtGodsonSponsorInfo.Rows(0)("sponsor_email_address"), DvdPostData.clsMemberGetMember.MAIL_FROM_SPONSOR, DvdPostData.clsMemberGetMember.MAIL_FROM_SPONSOR_NAME)
    '    End If
    'End Sub
    'Public Sub UpdateParrainage(ByVal customers_id As Integer, ByVal email As String, ByVal abo_type As Integer)
    '    Dim dtFather As DataTable
    '    Dim fatherId As Object
    '    Dim fatherAbo As Boolean
    '    Dim fatherAboType As Integer


    '    fatherId = DvdPostData.clsConnection.ExecuteScalar(DvdPostData.clsMemberGetMember.getFatherId(email))

    '    If Not IsNothing(fatherId) Then
    '        dtFather = DvdPostData.clsConnection.FillDataSet(DvdPostData.clsMemberGetMember.getCustomers(CType(fatherId, Integer)))

    '        ' DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.clsMemberGetMember.updateCustomersMgm(customers_id))
    '        ' DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.clsMemberGetMember.insertCustomersPointHist(customers_id, DvdPostData.clsMemberGetMember.PointsHistoryAction.ADD, DvdPostData.clsMemberGetMember.PointsHistorySubAction.POINT_GIVEN_TO_SON, DvdPostData.clsMemberGetMember.MGMPOINT))

    '        fatherAbo = dtFather.Rows(0)("customers_abo")
    '        fatherAboType = dtFather.Rows(0)("customers_abo_type")
    '        If fatherAbo Then
    '            DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.clsMemberGetMember.insertMgmUsed(fatherId, fatherAboType, customers_id, abo_type))
    '            UpdateParrainageSummer(customers_id)
    '        End If
    '    End If


    '  End Sub


    Public Function ActivationDom70Domiciliation() As Boolean
        Dim flux_dom70 As String
        Dim dtResult_dom70 As DataTable
        Dim bic_old As Integer
        Dim clsActivationDom As clsDom70_128

        Try
            dtResult_dom70 = Activation(ClsCustomersData.Payment_Method.DOMICILIATION, ClsCustomersData.Country.BELGIUM)
            If clsMsgError.MsgBox("Are you sur to process " & dtResult_dom70.Rows.Count & " activations ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                If dtResult_dom70.Rows.Count > 0 Then

                    RaiseEvent ReInitProgressbar_event()

                    ' rupture de sequence sur le bic 
                    Dim index As Integer = 0
                    Dim dr As DataRow
                    Dim dt As DataTable
                    Dim lst_Clientbank As List(Of DataTable) = New List(Of DataTable)

                    While index < dtResult_dom70.Rows.Count - 1
                        dr = dtResult_dom70.Rows(index)
                        bic_old = dr("Bic")
                        dt = New DataTable()
                        dt = createTableResult(dtResult_dom70)

                        While index < dtResult_dom70.Rows.Count - 1 And bic_old = dr("Bic")
                            dt.Rows.Add(dr.ItemArray())
                            index += 1
                            dr = dtResult_dom70.Rows(index)
                        End While
                        lst_Clientbank.Add(dt)
                    End While


                    For Each dtCurrent As DataTable In lst_Clientbank

                        Dim bic As String
                        bic = dtCurrent.Rows(0)("Bic")
                        clsActivationDom = New clsDom70_128(bic)
                        flux_dom70 = clsActivationDom.GenerateFile(dtCurrent)
                        PlushTools.clsFile.WriteFile(clsDom70_128.CreatePathFile(PlushTools.clsEnum.getNameStrEnum(PlushData.ClsBatchDomiciliation.TypeBatch.ACTIVATION_DOM70), _
                                                                                   PlushTools.clsEnum.getNameStrEnum(ClsCustomersData.Country.BELGIUM), bic), flux_dom70)

                    Next

                    PlushData.clsConnection.CommitTransaction(True)
                    Return True
                Else
                    PlushData.clsConnection.CommitTransaction(False)
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            PlushData.clsConnection.CommitTransaction(False)
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Dom70, ex)
            clsMsgError.MsgBox(ex.Message)
            Return False
        End Try

    End Function
    Private Sub InsertAllADULTSVODBankTransfert(ByVal dtResult As DataTable, ByVal typePaymentCommunication As Integer)
        Dim customers_id As Integer
        Dim price As String
        Dim sql As String
        Dim id As Object
        Dim payment_method As Integer
        Dim communication As String

        Try
            sql = PlushData.ClsPayment.getIdLastPayment()
            id = PlushData.clsConnection.ExecuteScalar(sql)
            If id Is DBNull.Value Then
                id = 0
            End If

            For Each drcustomers As DataRow In dtResult.Rows

                customers_id = GetCustomersId(drcustomers)
                price = GetCustomersAmount(drcustomers)
                price = PlushTools.ClsPrice.FormatPrice(price)
                If price <= 0 Then
                    Throw New Exception("Error price " & price & "€ Customers_id : " & customers_id)
                End If
                payment_method = GetCustomersPayment_method(drcustomers)
                sql = PlushData.clsBatchBankTransfert.insertBankTransfert(0, customers_id, price)
                PlushData.clsConnection.ExecuteNonQuery(sql)
                id += 1
                ' une communication identique par client id = customers_id 
                communication = clsCompta.CreateCommunicationStruct(id, typePaymentCommunication)
                If communication = "0" Then
                    Throw New Exception("Error Communication Customers_id : " & customers_id)
                End If
                sql = PlushData.clsBatchBankTransfert.UpdateCommunicationBankTransfert(id, communication)
                PlushData.clsConnection.ExecuteNonQuery(sql)

                'DvdPostData.clsConnection.CommitTransaction(True)


            Next

            ' link abo and payment 
            sql = PlushData.clsBatchBankTransfert.GetUpdateLinkADULTSVODAbo()
            PlushData.clsConnection.ExecuteNonQuery(sql)

        Catch ex As Exception

            ' DvdPostData.clsConnection.CommitTransaction(False)

            'sql = ClsCustomersData.GetSuspendedCustomersError(customers_id)
            ' DvdPostData.clsConnection.ExecuteNonQuery(sql)
            'Dim lstDr As DataRow()
            'lstDr = dtResult.Select("customers_id = " & customers_id)
            'If lstDr.Length > 0 Then
            '    dtResult.Rows.Remove(lstDr(0))
            'End If
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex)
            Throw ex
        End Try
    End Sub

    Private Sub InsertAllBankTransfert(ByVal dtResult As DataTable, ByVal typePaymentCommunication As Integer)
        Dim customers_id As Integer
        Dim price As String
        Dim sql As String
        Dim id As Object
        Dim payment_method As Integer
        Dim communication As String

        Try
            sql = PlushData.ClsPayment.getIdLastPayment()
            id = PlushData.clsConnection.ExecuteScalar(sql)
            If id Is DBNull.Value Then
                id = 0
            End If

            For Each drcustomers As DataRow In dtResult.Rows

                customers_id = GetCustomersId(drcustomers)
                price = GetCustomersAmount(drcustomers)
                price = PlushTools.ClsPrice.FormatPrice(price)
                If price <= 0 Then
                    Throw New Exception("Error price " & price & "€ Customers_id : " & customers_id)
                End If
                payment_method = GetCustomersPayment_method(drcustomers)
                sql = PlushData.clsBatchBankTransfert.insertBankTransfert(0, customers_id, price)
                PlushData.clsConnection.ExecuteNonQuery(sql)
                id += 1
                ' une communication identique par client id = customers_id 
                communication = clsCompta.CreateCommunicationStruct(id, typePaymentCommunication)
                If communication = "0" Then
                    Throw New Exception("Error Communication Customers_id : " & customers_id)
                End If
                sql = PlushData.clsBatchBankTransfert.UpdateCommunicationBankTransfert(id, communication)
                PlushData.clsConnection.ExecuteNonQuery(sql)

                'DvdPostData.clsConnection.CommitTransaction(True)


            Next

            ' link abo and payment 
            sql = PlushData.clsBatchBankTransfert.GetUpdateLinkAbo()
            PlushData.clsConnection.ExecuteNonQuery(sql)

        Catch ex As Exception

            ' DvdPostData.clsConnection.CommitTransaction(False)

            'sql = ClsCustomersData.GetSuspendedCustomersError(customers_id)
            ' DvdPostData.clsConnection.ExecuteNonQuery(sql)
            'Dim lstDr As DataRow()
            'lstDr = dtResult.Select("customers_id = " & customers_id)
            'If lstDr.Length > 0 Then
            '    dtResult.Rows.Remove(lstDr(0))
            'End If
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex)
            Throw ex
        End Try
    End Sub

    Private Sub InsertAllPayPalBankTransfert(ByVal dtResult As DataTable, ByVal typePaymentCommunication As Integer)
        Dim customers_id As Integer
        Dim price As String
        Dim sql As String
        Dim id As Object
        Dim payment_method As Integer
        Dim communication As String

        Try
            sql = PlushData.ClsPayment.getIdLastPayment()
            id = PlushData.clsConnection.ExecuteScalar(sql)
            If id Is DBNull.Value Then
                id = 0
            End If

            For Each drcustomers As DataRow In dtResult.Rows

                customers_id = GetCustomersId(drcustomers)
                price = GetCustomersAmount(drcustomers)
                price = PlushTools.ClsPrice.FormatPrice(price)
                If price <= 0 Then
                    Throw New Exception("Error price " & price & "€ Customers_id : " & customers_id)
                End If
                payment_method = GetCustomersPayment_method(drcustomers)
                sql = PlushData.clsBatchBankTransfert.insertPayPalBankTransfert(0, customers_id, price)
                PlushData.clsConnection.ExecuteNonQuery(sql)
                id += 1
                drcustomers("payment_id") = id
                ' une communication identique par client id = customers_id 
                communication = clsCompta.CreateCommunicationStruct(id, typePaymentCommunication)
                If communication = "0" Then
                    Throw New Exception("Error Communication Customers_id : " & customers_id)
                End If
                sql = PlushData.clsBatchBankTransfert.UpdateCommunicationBankTransfert(id, communication)
                PlushData.clsConnection.ExecuteNonQuery(sql)

                'DvdPostData.clsConnection.CommitTransaction(True)


            Next

            ' link abo and payment 
            sql = PlushData.clsBatchBankTransfert.GetUpdateLinkAbo()
            PlushData.clsConnection.ExecuteNonQuery(sql)

        Catch ex As Exception

            ' DvdPostData.clsConnection.CommitTransaction(False)

            'sql = ClsCustomersData.GetSuspendedCustomersError(customers_id)
            ' DvdPostData.clsConnection.ExecuteNonQuery(sql)
            'Dim lstDr As DataRow()
            'lstDr = dtResult.Select("customers_id = " & customers_id)
            'If lstDr.Length > 0 Then
            '    dtResult.Rows.Remove(lstDr(0))
            'End If
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex)
            Throw ex
        End Try
    End Sub


    Public Function ReconductionDomiciliation(ByVal idcountry As ClsCustomersData.Country, Optional ByVal customers_id As Integer = -1, Optional ByVal classique As Boolean = True) As Boolean
        Dim flux_dom80 As String
        Dim dtResult_dom80 As DataTable
        Dim cpt_result As Integer
        PlushData.clsConnection.CreateTransaction(True)
        Try
            Dim clsBatchdomiciliation As ClsBatchDomiciliation = New ClsBatchDomiciliation()
            dtResult_dom80 = Reconduction(ClsCustomersData.Payment_Method.DOMICILIATION, idcountry, customers_id, classique)

            If dtResult_dom80.Rows.Count > 0 Then
                RaiseEvent ReInitProgressbar_event()
                flux_dom80 = clsBatchdomiciliation.CreateBatchFile(dtResult_dom80)
                PlushTools.clsFile.WriteFileNoExist(clsBatchdomiciliation.CreatePathFile(PlushTools.clsEnum.getNameStrEnum(PlushData.ClsBatchDomiciliation.TypeBatch.RECONDUCTION_DOM80), _
                                                                              PlushTools.clsEnum.getNameStrEnum(ClsCustomersData.Country.BELGIUM)), flux_dom80)
                'DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.ClsBatchOgone.OgonePaymentBatch(flux))

                'insertCustomersOgonePayment(dtResult)
            End If

            Return PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Reconduction, cpt_result)

        Catch ex As Exception
            ' insert msg into db  
            PlushData.clsConnection.CancelBulkQuery()
            clsMsgError.MsgBox(ex.Message)
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex)
            Return False
        End Try
    End Function

    Public Function ReconductionDomiciliationADULTSVOD(ByVal idcountry As ClsCustomersData.Country, Optional ByVal customers_id As Integer = -1, Optional ByVal classique As Boolean = True) As Boolean
        Dim flux_dom80 As String
        Dim dtResult_dom80 As DataTable
        Dim cpt_result As Integer
        PlushData.clsConnection.CreateTransaction(True)
        Try
            Dim clsBatchdomiciliation As ClsBatchDomiciliation = New ClsBatchDomiciliation()
            dtResult_dom80 = ReconductionADULTSVOD(ClsCustomersData.Payment_Method.DOMICILIATION, idcountry)

            If dtResult_dom80.Rows.Count > 0 Then
                RaiseEvent ReInitProgressbar_event()
                flux_dom80 = clsBatchdomiciliation.CreateBatchFile(dtResult_dom80)
                PlushTools.clsFile.WriteFileNoExist(clsBatchdomiciliation.CreatePathFileADULTSVOD(PlushTools.clsEnum.getNameStrEnum(PlushData.ClsBatchDomiciliation.TypeBatch.RECONDUCTION_DOM80), _
                                                                              PlushTools.clsEnum.getNameStrEnum(ClsCustomersData.Country.BELGIUM)), flux_dom80)
                'DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.ClsBatchOgone.OgonePaymentBatch(flux))

                'insertCustomersOgonePayment(dtResult)
            End If

            Return PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Reconduction, cpt_result)

        Catch ex As Exception
            ' insert msg into db  
            PlushData.clsConnection.CancelBulkQuery()
            clsMsgError.MsgBox(ex.Message)
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex)
            Return False
        End Try
    End Function

    'Public Function ReconductionSms(ByVal idcountry As ClsCustomersData.Country, Optional ByVal customers_id As Integer = -1, Optional ByVal classique As Boolean = True) As Boolean
    '    Dim dtResult As DataTable
    '    Dim cpt_result As Integer
    '    DvdPostData.clsConnection.CreateTransaction(True)
    '    Try
    '        dtResult = Reconduction(ClsCustomersData.Payment_Method.VIREMENT, idcountry, customers_id, classique, True)
    '        InsertAllBankTransfert(dtResult, ClsCustomersData.TypePaymentCommunication.SMS)
    '        Return DvdPostData.clsConnection.ExecuteBulkQuery(DvdPostData.clsMsgError.processType.Reconduction, cpt_result)

    '    Catch ex As Exception
    '        ' insert msg into db  
    '        clsMsgError.MsgBox(ex.Message)
    '        clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Reconduction, ex)
    '        Return False
    '    End Try


    'End Function
    'Public Function ReconductionPhone(Optional ByVal idcountry As ClsCustomersData.Country = ClsCustomersData.Country.BELGIQUE, Optional ByVal customers_id As Integer = -1, Optional ByVal classique As Boolean = True) As Boolean
    '    Dim dtResult As DataTable
    '    Dim cpt_result As Integer
    '    DvdPostData.clsConnection.CreateTransaction(True)
    '    Try
    '        dtResult = Reconduction(ClsCustomersData.Payment_Method.VIREMENT, idcountry, customers_id, classique, True)
    '        InsertAllBankTransfert(dtResult, ClsCustomersData.TypePaymentCommunication.PHONE)
    '        Return DvdPostData.clsConnection.ExecuteBulkQuery(DvdPostData.clsMsgError.processType.Reconduction, cpt_result)

    '    Catch ex As Exception
    '        ' insert msg into db  
    '        clsMsgError.MsgBox(ex.Message)
    '        clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Reconduction, ex)
    '        Return False
    '    End Try


    'End Function
    Public Function ReconductionVirement(ByVal idcountry As ClsCustomersData.Country, Optional ByVal customers_id As Integer = -1, Optional ByVal classique As Boolean = True) As Boolean
        Dim dtResult As DataTable
        Dim cpt_result As Integer
        PlushData.clsConnection.CreateTransaction(True)
        Try
            dtResult = Reconduction(ClsCustomersData.Payment_Method.VIREMENT, idcountry, customers_id, classique, True)
            InsertAllBankTransfert(dtResult, ClsCustomersData.TypePaymentCommunication.VIREMENT)
            Return PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Reconduction, cpt_result)

        Catch ex As Exception
            ' insert msg into db  
            PlushData.clsConnection.CancelBulkQuery()
            clsMsgError.MsgBox(ex.Message)
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex)
            Return False
        End Try


    End Function
    Public Function ReconductionVirementADULTSVOD(ByVal idcountry As ClsCustomersData.Country, Optional ByVal customers_id As Integer = -1, Optional ByVal classique As Boolean = True) As Boolean
        Dim dtResult As DataTable
        Dim cpt_result As Integer
        PlushData.clsConnection.CreateTransaction(True)
        Try
            dtResult = ReconductionADULTSVOD(ClsCustomersData.Payment_Method.VIREMENT, idcountry)

            InsertAllADULTSVODBankTransfert(dtResult, ClsCustomersData.TypePaymentCommunication.VIREMENT)
            Return PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Reconduction, cpt_result)

        Catch ex As Exception
            ' insert msg into db  
            PlushData.clsConnection.CancelBulkQuery()
            clsMsgError.MsgBox(ex.Message)
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex)
            Return False
        End Try


    End Function

    Public Function ReconductionPayPal(ByVal idcountry As ClsCustomersData.Country, Optional ByVal customers_id As Integer = -1, Optional ByVal classique As Boolean = True) As Boolean
        Dim dtResult As DataTable
        Dim cpt_result As Integer
        Dim sql As String
        Dim str As String = ""
        PlushData.clsConnection.CreateTransaction(True)
        Try
            dtResult = Reconduction(ClsCustomersData.Payment_Method.PAYPAL, idcountry, customers_id, classique, True)
            InsertAllPayPalBankTransfert(dtResult, ClsCustomersData.TypePaymentCommunication.PAYPAL)

            Dim result = PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Reconduction, cpt_result)

            Dim paypal As PayPal.DoReferenceTransaction = New PayPal.DoReferenceTransaction()
            str = 1

            If dtResult.Rows.Count > 0 Then
                For Each drCustomers As DataRow In dtResult.Rows
                    Dim paypalResult As PayPal.PayPalResponse

                    customers_id = GetCustomersId(drCustomers)
                    str = 2
                    paypalResult = paypal.PayPalSendPayments(drCustomers)
                    str = 3
                    Dim message As String

                    If paypalResult.Response.Ack.HasValue Then
                        str = 4
                        If (paypalResult.Response.Ack.Value = Global.PayPal.PayPalAPIInterfaceService.Model.AckCodeType.SUCCESS) Or (paypalResult.Response.Ack.Value = Global.PayPal.PayPalAPIInterfaceService.Model.AckCodeType.SUCCESSWITHWARNING) Then
                            sql = PlushData.clsBatchBankTransfert.UpdateStatusBankTransfert(GetPaymentId(drCustomers), PaymentOfflineData.StepPayment.PAID)
                            str = 5
                            PlushData.clsConnection.ExecuteNonQuery(sql)
                            message = paypalResult.Response.Ack.Value.ToString()
                            str = 6
                        Else
                            str = 7
                            message = paypalResult.Response.Ack.Value.ToString()
                            str = 8
                            If paypalResult.Response.Errors.Count > 0 Then
                                str = 9
                                Try
                                    message = message & ":" & paypalResult.Response.DoReferenceTransactionResponseDetails.PaymentInfo.PaymentError.LongMessage
                                    str = 10
                                Catch ex As Exception
                                    message = message & ":" & ex.Message
                                End Try
                            End If
                            str = 11
                            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Batch, "PayPal payment does not succedded. Please check logs, the returned status is : " & paypalResult.Response.Ack.Value.ToString(), GetCustomersId(drCustomers))
                            str = 12
                        End If
                    Else
                        str = 13
                        message = "paypalResult.Response.Ack is not returned"
                    End If


                    sql = PlushData.clsBatchBankTransfert.InsertPayPalPaymentsHistory(GetPaymentId(drCustomers), paypalResult.XMLRequest, paypalResult.XMLResponse, message, GetCustomersId(drCustomers))
                    str = 14
                    PlushData.clsConnection.ExecuteNonQuery(sql)
                    str = 15

                Next

            End If
            Return True
        Catch ex As Exception
            ' insert msg into db  
            PlushData.clsConnection.CancelBulkQuery()
            clsMsgError.MsgBox(ex.Message)
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex, customers_id & " : position: " & str)
            Return True
        End Try


    End Function
    Public Function ReconductionPayPalADULTSVOD(ByVal idcountry As ClsCustomersData.Country, Optional ByVal customers_id As Integer = -1, Optional ByVal classique As Boolean = True) As Boolean
        Dim dtResult As DataTable
        Dim cpt_result As Integer
        Dim sql As String
        Dim str As String = ""
        PlushData.clsConnection.CreateTransaction(True)
        Try
            dtResult = ReconductionADULTSVOD(ClsCustomersData.Payment_Method.PAYPAL, idcountry, customers_id)
            InsertAllPayPalBankTransfert(dtResult, ClsCustomersData.TypePaymentCommunication.PAYPAL)

            Dim result = PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Reconduction, cpt_result)

            Dim paypal As PayPal.DoReferenceTransaction = New PayPal.DoReferenceTransaction()
            str = 1

            If dtResult.Rows.Count > 0 Then
                For Each drCustomers As DataRow In dtResult.Rows
                    Dim paypalResult As PayPal.PayPalResponse

                    customers_id = GetCustomersId(drCustomers)
                    str = 2
                    paypalResult = paypal.PayPalSendPayments(drCustomers)
                    str = 3
                    Dim message As String

                    If paypalResult.Response.Ack.HasValue Then
                        str = 4
                        If (paypalResult.Response.Ack.Value = Global.PayPal.PayPalAPIInterfaceService.Model.AckCodeType.SUCCESS) Or (paypalResult.Response.Ack.Value = Global.PayPal.PayPalAPIInterfaceService.Model.AckCodeType.SUCCESSWITHWARNING) Then
                            sql = PlushData.clsBatchBankTransfert.UpdateStatusBankTransfert(GetPaymentId(drCustomers), PaymentOfflineData.StepPayment.PAID)
                            str = 5
                            PlushData.clsConnection.ExecuteNonQuery(sql)
                            message = paypalResult.Response.Ack.Value.ToString()
                            str = 6
                        Else
                            str = 7
                            message = paypalResult.Response.Ack.Value.ToString()
                            str = 8
                            If paypalResult.Response.Errors.Count > 0 Then
                                str = 9
                                Try
                                    message = message & ":" & paypalResult.Response.DoReferenceTransactionResponseDetails.PaymentInfo.PaymentError.LongMessage
                                    str = 10
                                Catch ex As Exception
                                    message = message & ":" & ex.Message
                                End Try
                            End If
                            str = 11
                            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Batch, "PayPal payment does not succedded. Please check logs, the returned status is : " & paypalResult.Response.Ack.Value.ToString(), GetCustomersId(drCustomers))
                            str = 12
                        End If
                    Else
                        str = 13
                        message = "paypalResult.Response.Ack is not returned"
                    End If


                    sql = PlushData.clsBatchBankTransfert.InsertPayPalPaymentsHistory(GetPaymentId(drCustomers), paypalResult.XMLRequest, paypalResult.XMLResponse, message, GetCustomersId(drCustomers))
                    str = 14
                    PlushData.clsConnection.ExecuteNonQuery(sql)
                    str = 15

                Next

            End If
            Return True
        Catch ex As Exception
            ' insert msg into db  
            PlushData.clsConnection.CancelBulkQuery()
            clsMsgError.MsgBox(ex.Message)
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex, customers_id & " : position: " & str)
            Return True
        End Try


    End Function

    Public Function ReplayReconductionNoInvoice_customers(ByVal d As String, ByVal idcountry As ClsCustomersData.Country) As Boolean
        Dim sql As String
        Dim dtResult As DataTable
        Dim flux As String
        Dim ok As Boolean

        sql = PlushData.ClsCustomersData.GetRecreateBatchOgonewithoutpaymentCreate(d)
        dtResult = PlushData.clsConnection.FillDataSet(sql)
        If dtResult.Rows.Count > 0 Then
            Dim clsBatchOgone As ClsBatchOgone = New ClsBatchOgone()
            flux = clsBatchOgone.CreateBatchFile(dtResult, idcountry)
            ok = PlushTools.clsFile.WriteFileNoExist(clsBatchOgone.CreatePathFile(clsBatchOgone.TypeBatch.CHANGE_CREDITCARD, idcountry), flux)

            For Each dr As DataRow In dtResult.Rows
                clsPayment.CreateInvoice(dr("customers_id"), ClsCustomersData.Payment_Method.OGONE, PlushData.ClsPayment.Payment_type.RECONDUCTION, ClsCustomersData.TypePaymentCommunication.OGONE, PlushTools.ClsPrice.FormatPrice(dr("amount")))
            Next

        End If
    End Function
    Public Function ReplayReconduction_customers(ByVal d As String, ByVal idcountry As ClsCustomersData.Country) As Boolean
        Dim sql As String
        Dim dtResult As DataTable
        Dim flux As String
        Dim ok As Boolean

        sql = PlushData.ClsCustomersData.GetSelectReplayReconductionOgoneCreateDate(d, idcountry)
        dtResult = PlushData.clsConnection.FillDataSet(sql)
        If dtResult.Rows.Count > 0 Then
            Dim clsBatchOgone As ClsBatchOgone = New ClsBatchOgone()
            flux = clsBatchOgone.CreateBatchFile(dtResult, idcountry)
            ok = PlushTools.clsFile.WriteFileNoExist(clsBatchOgone.CreatePathFile(clsBatchOgone.TypeBatch.CHANGE_CREDITCARD, idcountry), flux)
        End If
    End Function

    Public Function ChangeCard_customers(ByVal idcountry As ClsCustomersData.Country) As Boolean
        Dim sql As String
        Dim dtResult As DataTable
        Dim flux As String
        Dim ok As Boolean

        sql = PlushData.ClsCustomersData.GetSelectChangeCardCreditCustomers(idcountry)
        dtResult = PlushData.clsConnection.FillDataSet(sql)
        If dtResult.Rows.Count > 0 Then
            Dim clsBatchOgone As ClsBatchOgone = New ClsBatchOgone()
            flux = clsBatchOgone.CreateBatchFile(dtResult, idcountry)
            ok = PlushTools.clsFile.WriteFileNoExist(clsBatchOgone.CreatePathFile(clsBatchOgone.TypeBatch.CHANGE_CREDITCARD, idcountry), flux)
        End If
    End Function
    Public Function ReconductionOgone(ByVal idcountry As ClsCustomersData.Country) As Boolean
        Dim flux As String
        Dim dtResult As DataTable
        Dim ok As Boolean
        Dim cpt_result As Integer
        Dim clsBatchOgone As ClsBatchOgone = New ClsBatchOgone()

        PlushData.clsConnection.CreateTransaction(True)
        Try
            dtResult = Reconduction(ClsCustomersData.Payment_Method.OGONE, idcountry)

            If dtResult.Rows.Count > 0 Then
                RaiseEvent ReInitProgressbar_event()
                insertCustomersOgonePayment(dtResult)

                flux = clsBatchOgone.CreateBatchFile(dtResult, idcountry)
                ok = PlushTools.clsFile.WriteFileNoExist(clsBatchOgone.CreatePathFile(clsBatchOgone.TypeBatch.RECONDUCTION_OGONE, idcountry), flux)
                If Not ok Then
                    PlushData.clsConnection.CancelBulkQuery()
                    Return False
                End If

                PlushData.clsConnection.ExecuteNonQuery(PlushData.ClsBatchOgone.OgonePaymentBatch(flux))
                Return PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Reconduction, cpt_result)
            End If
            Return True
        Catch ex As Exception
            PlushData.clsConnection.CancelBulkQuery()
            clsMsgError.MsgBox(ex.Message)
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex)
            ' ecrire error dans la table msg error 
            Return False
        End Try

    End Function

    Public Function ReconductionOgoneADULTSVOD(ByVal idcountry As ClsCustomersData.Country) As Boolean
        Dim flux As String
        Dim dtResult As DataTable
        Dim ok As Boolean
        Dim cpt_result As Integer
        Dim clsBatchOgone As ClsBatchOgone = New ClsBatchOgone()

        PlushData.clsConnection.CreateTransaction(True)
        Try
            dtResult = ReconductionADULTSVOD(ClsCustomersData.Payment_Method.OGONE, idcountry)

            If dtResult.Rows.Count > 0 Then
                RaiseEvent ReInitProgressbar_event()
                insertCustomersOgonePayment(dtResult)

                flux = clsBatchOgone.CreateBatchFile(dtResult, idcountry)
                ok = PlushTools.clsFile.WriteFileNoExist(clsBatchOgone.CreatePathFileADULTSVOD(clsBatchOgone.TypeBatch.RECONDUCTION_OGONE, idcountry), flux)
                If Not ok Then
                    PlushData.clsConnection.CancelBulkQuery()
                    Return False
                End If

                PlushData.clsConnection.ExecuteNonQuery(PlushData.ClsBatchOgone.OgonePaymentBatch(flux))
                Return PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Reconduction, cpt_result)
            End If
            Return True
        Catch ex As Exception
            PlushData.clsConnection.CancelBulkQuery()
            clsMsgError.MsgBox(ex.Message)
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex)
            ' ecrire error dans la table msg error 
            Return False
        End Try

    End Function

    Public Function ReconductionForced(ByVal customers_id As Integer) As Boolean
        Dim payment_method As Integer

        payment_method = GetCustomersPayment_method(customers_id)
        'Return ReconductionOgone(ClsCustomersData.Country.BELGIUM)


        Select Case payment_method
            Case PlushData.ClsCustomersData.Payment_Method.VIREMENT
                Return ReconductionVirement(ClsCustomersData.Country.BELGIUM, customers_id)
                'Case DvdPostData.ClsCustomersData.Payment_Method.VIREMENT
                '    Return ReconductionPhone(ClsCustomersData.Country.BELGIQUE, customers_id)
                'Case DvdPostData.ClsCustomersData.Payment_Method.VIREMENT
                '    Return ReconductionSms(ClsCustomersData.Country.BELGIQUE, customers_id)
            Case Else

                Return False
        End Select

    End Function
    Private Sub createActivationAboHistory(ByVal drCustomer As DataRow)
        Dim customers_id As Integer
        Dim activationCode As Integer
        Dim sql As String
        customers_id = GetCustomersId(drCustomer)
        activationCode = GetActivationDiscountCode(drCustomer)

        If IsDiscount(drCustomer) Then
            CreateaboHistory(drCustomer, ClsCustomersData.TypeAction.ACTION_FROM_DISCOUNT, activationCode.ToString())
        ElseIf IsActivation(drCustomer) Then
            CreateaboHistory(drCustomer, ClsCustomersData.TypeAction.ACTION_FROM_ACTIVATION, activationCode.ToString())
            ' links code to customers 
            sql = PlushData.ClsCustomersData.GetUpdateActivationCode(customers_id, activationCode)
            PlushData.clsConnection.ExecuteNonQuery(sql)
        Else
            CreateaboHistory(drCustomer, ClsCustomersData.TypeAction.ACTION_CREATE)
        End If

    End Sub
    Public Shared Function isFT(ByVal customers_id As Integer) As Boolean
        Dim sql As String
        Dim result As Integer
        sql = PlushData.ClsCustomersData.GetIsFreeTrial(customers_id)
        result = PlushData.clsConnection.ExecuteScalar(sql)

        Return result = 1

    End Function

    Private Sub updatelockedReconduction(ByVal drCustomer As DataRow)
        Dim sql As String
        Dim customer_id As Integer = GetCustomersId(drCustomer)
        sql = PlushData.ClsCustomersData.GetUpdateLockedReconduction(customer_id)
        PlushData.clsConnection.ExecuteNonQuery(sql)
    End Sub

    Private Sub updateProductType(ByVal drCustomer As DataRow)
        Dim sql As String
        Dim customer_id As Integer = GetCustomersId(drCustomer)
        sql = PlushData.ClsCustomersData.GetUpdateProductType(customer_id)
        PlushData.clsConnection.ExecuteNonQuery(sql)
    End Sub
    Private Sub createReconductionAboHistory(ByVal drCustomer As DataRow, ByVal price As String)
        Dim package_count As Integer
        Dim package_count_next As Integer
        Dim isLastAboActtionUpgrade As Boolean = False
        Dim isLastAboActtionRequestForDowngrade As Boolean = False

        If IsLocedForReconduction(drCustomer) Then
            isLastAboActtionUpgrade = (((GetCustomersLastAboAction(drCustomer)) = ClsCustomersData.TypeAction.ACTION_UPGRADE))
            isLastAboActtionRequestForDowngrade = (((GetCustomersLastAboAction(drCustomer)) = ClsCustomersData.TypeAction.ACTION_REQUEST_OF_ABO_DOWNGRADE))
        End If

        If price = "0.00" Then
            CreateaboHistory(drCustomer, ClsCustomersData.TypeAction.ACTION_RECONDUCTIONFREE)
        Else
            package_count = GetCustomersPackageCount(drCustomer)
            package_count_next = GetCustomersPackageCountNext(drCustomer)

            If package_count >= package_count_next And IsLocedForReconduction(drCustomer) And isLastAboActtionRequestForDowngrade Then
                CreateaboHistory(drCustomer, ClsCustomersData.TypeAction.ACTION_DOWNGRADE_ID)
            End If

            CreateaboHistory(drCustomer, ClsCustomersData.TypeAction.ACTION_RECONDUCTION)

        End If


    End Sub
    Private Sub createReconductionAboHistoryADULTSVOD(ByVal drCustomer As DataRow, ByVal price As String)
        CreateaboHistory(drCustomer, ClsCustomersData.TypeAction.ACTION_RECONDUCTION_ADULT_SVOD)
    End Sub
    Private Shared Function getLastId() As Integer
        Dim sql As String
        Dim result As Integer

        sql = PlushData.ClsBatchOgone.getLastIdInsert()
        result = PlushData.clsConnection.ExecuteScalar(sql)
        Return result
    End Function
    Private Sub insertCustomersOgonePayment(ByVal dtCustomers As DataTable)
        Dim lastOgoneBatch_id As Integer = ClsBatchOgone.getIdBatchOgone()
        For Each drcustomer As DataRow In dtCustomers.Rows
            insertOgonePayment(drcustomer, lastOgoneBatch_id)
        Next
    End Sub
    Private Sub insertOgonePayment(ByVal drcustomers As DataRow, ByVal ogone_batch_id As Integer)
        Dim abo_id As Integer
        Dim customers_id As Integer
        Dim OgonePaymentLastID As Integer
        Dim price As String = ""
        Try
            price = GetCustomersAmount(drcustomers)
            price = PlushTools.ClsPrice.FormatPrice(price)
            abo_id = GetCustomersAbo(drcustomers)
            customers_id = GetCustomersId(drcustomers)

            PlushData.clsConnection.ExecuteNonQuery(PlushData.ClsBatchOgone.CreateOgonePayment(abo_id, customers_id, price, ogone_batch_id), True)

            'OgonePaymentLastID = DvdPostData.clsConnection.ExecuteScalar(DvdPostData.ClsBatchOgone.getLastIdInsert())
            'DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.ClsBatchOgone.OgonePaymentHistory(PaymentOfflineData.StepPayment.WAITING_PAYMENT, OgonePaymentLastID), True)
        Catch ex As Exception
            clsMsgError.MsgBox("erreur insertion ogone customers_id " & customers_id & " price " & price)
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Reconduction, ex, customers_id)
        End Try
    End Sub
    Public Sub updateNumDom(ByVal customers_id As Integer, ByVal numdom As String)
        Dim sql As String
        sql = PlushData.ClsCustomersData.GetUpdateNumberDomiciliation(customers_id, numdom)
        PlushData.clsConnection.ExecuteNonQuery(sql)
    End Sub

    Public Sub UpdateDvd_at_Home()
        Dim sql As String
        sql = PlushData.ClsCustomersData.GetUpdateDvd_at_Home()
        PlushData.clsConnection.ExecuteNonQuery(sql)
    End Sub

    Private Sub ActivateRecurringDiscountCode(ByVal drcustomer As DataRow, _
                                             ByVal drDiscountCode As DataRow, _
                                             ByVal discount_code_Id As Integer, _
                                             ByRef strDurationActivation As String)
        Dim Sql As String
        strDurationActivation = GetDurationActivation(GetDiscountCodeTypeDate(drDiscountCode), GetDiscountCodeValueDate(drDiscountCode))
        Sql = PlushData.ClsCustomersData.GetUpdateRecurringDiscountCode(GetCustomersId(drcustomer), discount_code_Id, Getdiscount_recurring_nbr_of_month(drDiscountCode), ClsCustomersData.CODE_DISCOUNT)
        PlushData.clsConnection.ExecuteNonQuery(Sql)

        Sql = PlushData.ClsCustomersData.GetInsertDiscountUse(GetCustomersId(drcustomer), discount_code_Id)
        PlushData.clsConnection.ExecuteNonQuery(Sql)
    End Sub

    Private Shared Function GetLastPaymentOgone(ByVal customers_id As Integer) As DataRow
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.ClsBatchOgone.GetLastPaymentOpenStatus_ogone(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sql)
        If dt.Rows.Count = 1 Then
            Return dt.Rows(0)
        Else
            Return Nothing
        End If


    End Function

    Public Shared Function SuspendPaymentCustomer(ByVal Customers_id As Integer, Optional ByVal batch_id As Integer = -1) As String
        Dim dr As DataRow
        Dim sql As String
        Dim lastId As Integer

        Try
            dr = GetLastPaymentOgone(Customers_id)
            If Not dr Is Nothing Then

                lastId = dr("id")

                If batch_id = -1 Then
                    batch_id = dr("batch_id")
                End If
                Dim communication_structure As String
                communication_structure = clsCompta.CreateCommunicationStruct(lastId, ClsCustomersData.TypePaymentCommunication.OGONE)

                sql = PlushData.PaymentOfflineData.UpdateStatusPaymentOffline(lastId, PaymentOfflineData.StepPayment.CREATE_RECOVERY, communication_structure, batch_id)
                PlushData.clsConnection.ExecuteNonQuery(sql)

                PlushData.clsConnection.ExecuteNonQuery(PlushData.ClsCustomersData.GetUpdateSuspendedCustomers(Customers_id))
                PlushData.clsConnection.ExecuteNonQuery(PlushData.ClsCustomersData.GetInsertHistoryAbo(Customers_id, Nothing, lastId, ClsCustomersData.Payment_Method.OGONE, 20))
                PlushData.clsConnection.ExecuteNonQuery(PlushData.clsAboSuspended.GetInsertAboSuspendedHistory(Customers_id, PlushData.clsAboSuspended.Payment, DateTime.Now.ToShortDateString()))
                clsMail.SendMail(Customers_id, clsMail.Mail.MAIL_PLUSH_PAYMENT_NOT_RECEIVED_CREATE_RECOVERY)

                Return ""
            End If
            Return "the payment ogone doesn't exist (customer_id : " & Customers_id & " / batch_id : " & batch_id & ")"

        Catch ex As Exception
            Return "the payment ogone doesn't exist (customer_id : " & Customers_id & " / batch_id : " & batch_id & ")"

        End Try
    End Function

    Public Shared Function UnsuspendPaymentCustomer(ByVal Customers_id As Integer, ByVal abo_products_id As Integer) As String
        Try


            If PlushData.clsConnection.ExecuteScalar(PlushData.ClsPayment.GetCountOfCustomersUnpaidPayments(Customers_id)) > 0 Then
                Return "Customer has unpaid payments"
            End If

            PlushData.clsConnection.ExecuteNonQuery(PlushData.ClsCustomersData.GetUpdateUnsuspendedForPaymentCustomer(Customers_id))
            PlushData.clsConnection.ExecuteNonQuery(PlushData.ClsCustomersData.GetInsertHistoryAbo(Customers_id, Nothing, abo_products_id, "OGONE", 23))
            PlushData.clsConnection.ExecuteNonQuery(PlushData.clsAboSuspended.GetUpdateAboSuspendedHistory(Customers_id))

            Return ""

        Catch ex As Exception
            Return ex.Message

        End Try
    End Function

    Public Shared Function SuspendForHolidayCustomer(ByVal Customers_id As Integer, ByVal abo_products_id As Integer, ByVal date_end As String) As String
       
        Try

            PlushData.clsConnection.ExecuteNonQuery(PlushData.ClsCustomersData.GetUpdateSuspendedForHolidayCustomers(Customers_id))
            PlushData.clsConnection.ExecuteNonQuery(PlushData.ClsCustomersData.GetInsertHistoryAbo(Customers_id, Nothing, abo_products_id, "OGONE", 19))
            PlushData.clsConnection.ExecuteNonQuery(PlushData.clsAboSuspended.GetInsertAboSuspendedHistory(Customers_id, PlushData.clsAboSuspended.Holidays, date_end))
            Return ""

        Catch ex As Exception
            Return "Customer is not suspended for holiday "

        End Try
    End Function

    Public Shared Function UnsuspendForHolidayCustomer(ByVal Customers_id As Integer, ByVal abo_products_id As Integer, ByVal date_end As String) As String
        Try

            PlushData.clsConnection.ExecuteNonQuery(PlushData.ClsCustomersData.GetUpdateUnsuspendedForHolidayCustomer(Customers_id))
            PlushData.clsConnection.ExecuteNonQuery(PlushData.ClsCustomersData.GetInsertHistoryAbo(Customers_id, Nothing, abo_products_id, "OGONE", 21))
            PlushData.clsConnection.ExecuteNonQuery(PlushData.clsAboSuspended.GetInsertAboSuspendedHistory(Customers_id, PlushData.clsAboSuspended.Holidays, date_end))
            Return ""

        Catch ex As Exception
            Return "Customer is not unsuspended for holiday "

        End Try
    End Function

End Class
