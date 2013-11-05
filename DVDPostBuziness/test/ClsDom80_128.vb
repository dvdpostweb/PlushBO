Imports DvdPostData
''' <summary>
'''  create file to export domiciliation Isabel payment (dvdpost => isabel payment)
''' </summary>
''' <remarks></remarks>
Public Class ClsDom80_128

    Private _amountTot As Decimal
    Private _domIdTot As Long

    Const FORMATDATE As String = "ddMMyy"
    Const FORMATDATETIME As String = "yyMMddHHmm"
    Const BLANK As String = " "
    Const KEYFILE As String = "Path_Dom80"


    ' utiliser pour gerer la progress bar
    Public Event initMapping_Event(ByVal cpt As Integer)
    Public Event stepMapping_event(ByVal index As Integer)
    Public Event ReInitProgressbar_event()
    Const CREDITOR_NAME As String = "HOME ENTERTAINMENT SERVICES"

#Region "CONST_HEADER"

    'utility ???
    Const CODE_APPLICATION As String = "02"
    Const CODE_VERSION As String = "5"

    Const IDENTIFICATION_HEADER As String = "0"
    Const START_CHAR_HEADER As String = "0000"

    Const FINANCIALINSTITUTEID As String = "300"


    Const DVDPOST_VAT As String = "00478510502"
    Const END_CHAR_HEADER As Integer = 60

#End Region
#Region "CONST_ENREGISTREMENT"
    Const DOM80_DATA_NATURE_CODE_PAYMENT As String = "0"
    Const DOM80_DATA_NATURE_CODE_REFUND As String = "1"
    Const IDENTIFICATION_ENREGISTREMENT As String = "1"
    Const TYPE As String = "RECONDUCTION"

    Const LEN_NUMSEQUENCE As Integer = 4
    Const LEN_NUMDOM As Integer = 12
    Const LEN_AMOUNT As Integer = 12
    Const LEN_CUSTNAME As Integer = 26
    Const LEN_COMM_PART1 As Integer = 15
    Const LEN_TYPE As Integer = 15
    Const LEN_COMM As Integer = 12


    Const END_CHAR_ENREGISTREMENT As Integer = 30
#End Region
#Region "CONST_FOOTER"
    Const IDENTIFICATION_FOOTER As String = "9"

    Const LEN_CPT_PAYMENT As Integer = 4
    Const LEN_TOTAL_AMOUNT_PAYMENT As Integer = 12
    Const LEN_TOTAL_PAYMENTDOMID As Integer = 15

    Const LEN_CPT_REFUND As Integer = 4
    Const LEN_TOTAL_AMOUNT_REFUND As Integer = 12
    Const LEN_TOTAL_REFUNDDOMID As Integer = 15

    Const END_CHAR_FOOTER As Integer = 65

#End Region

    Public Shared Function CreatePathFile(ByVal tBatch As String, ByVal country As String) As String
        Dim nameFile As String
        Dim path_file As String

        path_file = Configuration.ConfigurationManager.AppSettings(KEYFILE)
        nameFile = country & "_" & tBatch.ToString() & "_" & DVDPostTools.ClsDate.formatDate() & ".txt"

        Return path_file & nameFile

    End Function
   
    Public Function GetDateTimeFormat(ByVal dt As DateTime) As String
        Return dt.ToString(FORMATDATETIME)
    End Function
    Public Shared Function GetDateFormat(ByVal dt As DateTime) As String
        Return dt.ToString(FORMATDATE)
    End Function

    Private Function FormatStringPad(ByVal o As Object, ByVal cpt_char As Integer) As String
        Dim str As String = o.ToString()
        Return str.PadLeft(cpt_char, "0"c)

    End Function

    Private Function Header() As String
        Dim strHeader As String
        Dim dtCurrent As DateTime = DateTime.Today.AddDays(2)

        Dim endStr As String = New String(BLANK, END_CHAR_HEADER)
        strHeader = IDENTIFICATION_HEADER + START_CHAR_HEADER + GetDateFormat(dtCurrent) + FINANCIALINSTITUTEID + CODE_APPLICATION + GetDateTimeFormat(dtCurrent)
        strHeader = strHeader + DVDPOST_VAT + DVDPOST_VAT + clsCompta.DVDPOST_BANK_ACCOUNT_ING + CODE_VERSION + BLANK + GetDateFormat(dtCurrent)
        strHeader = strHeader + endStr + vbLf

        Return strHeader
    End Function

    Private Function Footer(ByVal cpt_payment As Integer, _
                            ByVal totalAmount As Decimal, _
                            ByVal totalPaymentDomID As Long, _
                            ByVal numberofRefund As Integer, _
                            ByVal TotalRefundAmount As Decimal, _
    ByVal TotalNumberFund As Integer _
                            ) As String
        Dim strFooter As String
        Dim endStr As String = New String(BLANK, END_CHAR_FOOTER)

        strFooter = IDENTIFICATION_FOOTER + formatLeft(cpt_payment, LEN_CPT_PAYMENT) + formatLeft(totalAmount, LEN_TOTAL_AMOUNT_PAYMENT)
        strFooter = strFooter + formatright(totalPaymentDomID, LEN_TOTAL_PAYMENTDOMID, BLANK) + formatLeft(numberofRefund, LEN_CPT_REFUND)
        strFooter = strFooter + formatright(TotalRefundAmount, LEN_TOTAL_AMOUNT_REFUND, BLANK) + formatLeft(TotalNumberFund, LEN_TOTAL_REFUNDDOMID)
        strFooter = strFooter + endStr + vbLf
        Return strFooter
    End Function

    Private Function getDomiciliation(ByVal drReconduction As DataRow) As String
        Return drReconduction("domiciliation_number")
    End Function

    Private Function getAmount(ByVal drReconduction As DataRow) As String
        Return drReconduction("amount")
    End Function
    'Private Function getCustomerName(ByVal drReconduction As DataRow) As String
    '    Return drReconduction("customers_name")
    'End Function

    'Private Function getActionName(ByVal drReconduction As DataRow) As String
    '    Return drReconduction("action_name")
    'End Function
    Private Function formatright(ByVal o As Object, ByVal len As Integer, Optional ByVal char_replace As String = "0") As String
        If o.ToString.Length > len Then
            Return o.ToString.Substring(o.ToString.Length - len)
        Else
            Return o.ToString.PadRight(len, char_replace)
        End If

    End Function

    Private Function formatLeft(ByVal o As Object, ByVal len As Integer, Optional ByVal char_replace As String = "0") As String

        If o.ToString.Length > len Then
            Return o.ToString.Substring(0, len)
        Else
            Return o.ToString.PadLeft(len, char_replace)
        End If

    End Function

    Private Function LineData(ByVal drReconduction As DataRow, ByVal numsequence As Integer, ByVal strcommunication As String) As String
        Dim strLine As String
        Dim strdomiciliation_number As String
        Dim strcreditor_name As String
        'Dim straction_name As String
        Dim stramount As String

        Dim strcommunication_part1 As String
        Dim strType As String
        Dim strnumseq As String
        Dim cls As ClsCustomers = New ClsCustomers()
        Dim customers_id As String = cls.GetCustomersId(drReconduction)
        Dim endStr As String = New String(BLANK, END_CHAR_ENREGISTREMENT)
        Try
            strdomiciliation_number = getDomiciliation(drReconduction)
            _domIdTot += Long.Parse(strdomiciliation_number)
            'If strdomiciliation_number Is Nothing Then
            '    ' Dim cls As ClsCustomers = New ClsCustomers()
            '    MsgBox("customers " & cls.GetCustomersId(drReconduction) & " domiciliation_number is null")
            '    Return ""
            'End If
            'strcustomers_name = getCustomerName(drReconduction)
            'straction_name = getActionName(drReconduction)
            stramount = getAmount(drReconduction)

            _amountTot = _amountTot + Decimal.Parse(stramount)
            stramount = DVDPostTools.ClsPrice.castPriceDbToPriceBatch(stramount)

            strnumseq = formatLeft(numsequence, LEN_NUMSEQUENCE)
            strdomiciliation_number = formatLeft(strdomiciliation_number, LEN_NUMDOM)
            stramount = formatLeft(stramount, LEN_AMOUNT)
            strcreditor_name = formatLeft(CREDITOR_NAME, LEN_CUSTNAME, BLANK)
            strcommunication_part1 = formatLeft(strcommunication, LEN_COMM_PART1, BLANK)
            strType = formatLeft(TYPE, LEN_TYPE, BLANK)
            strcommunication = formatLeft(strcommunication, LEN_COMM, BLANK)

            strLine = IDENTIFICATION_ENREGISTREMENT + strnumseq + strdomiciliation_number + DOM80_DATA_NATURE_CODE_PAYMENT + stramount + strcreditor_name
            strLine = strLine + strType + strcommunication_part1 + strcommunication
            strLine = strLine + endStr + vbLf
            Return strLine
        Catch ex As Exception
            'Dim cls As ClsCustomers = New ClsCustomers()
            clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Reconduction, ex)
            Dim sql As String
            Sql = ClsCustomersData.GetUpdateSuspendedCustomersError(customers_id)
            DvdPostData.clsConnection.ExecuteNonQuery(Sql)

            'Throw New Exception(ex.Message & " customers id : " & cls.GetCustomersId(drReconduction))
            Return ""
        End Try

    End Function

    Public Function GenerateFile(ByVal dtReconduction As DataTable) As String
        Dim strMsg As String
        'Dim path As String
        Dim totalDomId As Integer = 0
        Dim numberOfRefund As Integer = 0
        Dim totalRefundAmount As Decimal = 0
        Dim totalFundId As Integer = 0

      
        Dim strcommunication As String
        Dim cpt As Integer = 0
        Dim sql As String
        Dim lastDomId As Integer
        'path = CreatePathFile()
        strMsg = Header()
        sql = DvdPostData.ClsBatchDomiciliation.getIdLastPaymentdomiciliation()
        lastDomId = DvdPostData.clsConnection.ExecuteScalar(sql)
        RaiseEvent initMapping_Event(dtReconduction.Rows.Count)

        For Each dr As DataRow In dtReconduction.Rows
            cpt = cpt + 1
            strcommunication = clsCompta.CreateCommunicationStruct(lastDomId + cpt, ClsCustomersData.TypePaymentCommunication.DOMICILIATION)
            If ClsBatchDomiciliation.InsertDomiciliationPayment(dr, strcommunication) Then
                strMsg = strMsg + LineData(dr, cpt, strcommunication)
                lastDomId = DvdPostData.clsConnection.ExecuteScalar(sql)
                RaiseEvent stepMapping_event(cpt)
            Else
                cpt -= 1
            End If

        Next


        strMsg = strMsg + Footer(cpt, _amountTot, _domIdTot, numberOfRefund, totalRefundAmount, totalFundId)
        Return strMsg

    End Function

    Public Sub New()
        _amountTot = 0
        _domIdTot = 0
    End Sub
End Class
