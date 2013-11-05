Imports DvdPostData

Public Class clsDom70_128

    ''' <summary>
    '''  create file to export domiciliation Isabel Activation (dvdpost => isabel activation)
    ''' </summary>
    ''' <remarks></remarks>
    
    Private _sumNumAccount As Long

    Const FORMATDATE As String = "ddMMyy"
    Const FORMATDATETIME As String = "yyMMddHHmm"
    Const BLANK As String = " "
    Const KEYFILE As String = "Path_Dom70"

#Region "CONST_HEADER"

    'utility ???
    Private _financialInstitutId As String

    Const CODE_APPLICATION As String = "70"
    Const CODE_VERSION As String = "1"
    Const CODE_COMMUNICATION As String = "1"
    Const CODE_DUPLICATA As String = " "

    Const IDENTIFICATION_HEADER As String = "0"
    Const LEN_BLANK3 As Integer = 7
    Const LEN_BLANK5 As Integer = 3
    Const LEN_BLANK7 As Integer = 2

    Const LEN_FINANCIALINSTITUT As Integer = 3
    Const LEN_REFERENCE As Integer = 10
    Const LEN_IDENTIFICATION_CREANCIER As Integer = 11

    Const CREDITOR_NAME As String = "HOME ENTERTAINMENT SERVICES"
    Const DVDPOST_VAT As String = "00478510502"
    Const END_CHAR_HEADER As Integer = 80

#End Region
#Region "CONST_ENREGISTREMENT"

    Const IDENTIFICATION_ENREGISTREMENT As String = "1"
    Const DATA_CODE_NATURE_OPENED As String = "1"
    Const DATA_CODE_CREANCIER As String = "1"

    Const DATA_NUMDOM As String = "0"
    Const LEN_NUMSEQUENCE As Integer = 6
    Const LEN_DATA_REFERENCE As Integer = 19

    Const LEN_NUMDOM As Integer = 12
    Const LEN_BANKACCOUNT As Integer = 12
    Const LEN_DOMICILIATION As Integer = 12
    Const LEN_CUSTNAME As Integer = 26
    Const LEN_ADDRESS_CUST As Integer = 26
    Const LEN_CODEPOSTAL As Integer = 4

    Const END_CHAR_ENREGISTREMENT As Integer = 20

#End Region
#Region "CONST_FOOTER"
    Const IDENTIFICATION_FOOTER As String = "9"

    Const LEN_CPT_ACTIVATION As Integer = 6
    Const LEN_SUM_NUMACCOUNT As Integer = 15
    Const LEN_SUM_NUMDOM As Integer = 15
    Const CODE_MULTIPLE As String = "2"
    Const NUMDOM As String = BLANK
    Const END_CHAR_FOOTER As Integer = 90

#End Region


    Public Shared Function CreatePathFile(ByVal tBatch As String, ByVal country As String, ByVal bic As String) As String
        Dim nameFile As String
        Dim path_file As String

        path_file = Configuration.ConfigurationManager.AppSettings(KEYFILE)
        nameFile = country & "_" & tBatch.ToString() & "_" & bic & "_" & DVDPostTools.ClsDate.formatDate() & ".txt"

        Return path_file & nameFile

    End Function


    Public Function GetDateTimeFormat(ByVal dt As DateTime) As String
        Return dt.ToString(FORMATDATETIME)
    End Function
    Public Function GetDateFormat(ByVal dt As DateTime) As String

        Return dt.ToString(FORMATDATE)
    End Function

    Private Function FormatStringPad(ByVal o As Object, ByVal cpt_char As Integer) As String
        Dim str As String = o.ToString()
        Return str.PadLeft(cpt_char, "0"c)

    End Function

    Private Function Header(ByVal batchid As Integer) As String
        Dim strHeader As String
        Dim dtCurrent As DateTime = DateTime.Today

        Dim blank3 As String
        Dim blank5 As String
        Dim blank7 As String
        Dim strfinancialInstitut As String
        Dim strbatchid As String

        blank3 = New String(BLANK, LEN_BLANK3)
        blank5 = New String(BLANK, LEN_BLANK5)
        blank7 = New String(BLANK, LEN_BLANK7)

        strfinancialInstitut = formatLeft(_financialInstitutId, LEN_FINANCIALINSTITUT)
        strbatchid = formatLeft(batchid, LEN_REFERENCE)

        Dim endStr As String = New String(BLANK, END_CHAR_HEADER)
        strHeader = IDENTIFICATION_HEADER + GetDateFormat(dtCurrent) + blank3 + CODE_APPLICATION + blank5
        strHeader = strHeader + strfinancialInstitut + blank7 + strbatchid + DVDPOST_VAT + CODE_COMMUNICATION + CODE_VERSION + CODE_DUPLICATA
        strHeader = strHeader + endStr + vbLf

        Return strHeader
    End Function

    Private Function Footer(ByVal cpt_activation As Integer, _
                            ByVal SumNumAccount As Long _
                            ) As String
        Dim strFooter As String
        Dim endStr As String = New String(BLANK, END_CHAR_FOOTER)

        strFooter = IDENTIFICATION_FOOTER + formatLeft(cpt_activation, LEN_CPT_ACTIVATION) + formatright(SumNumAccount, LEN_SUM_NUMACCOUNT, BLANK)
        strFooter = strFooter + formatLeft(NUMDOM, LEN_SUM_NUMDOM) + CODE_MULTIPLE
        strFooter = strFooter + endStr + vbLf
        Return strFooter
    End Function

    Private Function getNumBankAccount(ByVal drReconduction As DataRow) As String
        Return drReconduction("domiciliation_account_number")
    End Function

    Private Function getCustomerreference(ByVal drReconduction As DataRow) As String
        Return drReconduction("customers_id").ToString() + "-" + getCustomerName(drReconduction)
    End Function

    Private Function getCustomerName(ByVal drReconduction As DataRow) As String
        Return drReconduction("customers_name")
    End Function

    Private Function getCustomerpostCode(ByVal drReconduction As DataRow) As String
        Return drReconduction("entry_postcode")
    End Function

    Private Function getCustomeraddress(ByVal drReconduction As DataRow) As String
        Return drReconduction("entry_street_address")
    End Function

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
    Private Function LineData(ByVal drReconduction As DataRow, ByVal numsequence As Integer) As String
        Dim strLine As String
        Dim strcustomers_name As String
        Dim strcustomers_address As String
        Dim strcustomers_codepostal As String
        Dim strReferenceCustomer As String
        Dim strNumBankAccount As String
        Dim strNumDom As String
        Dim strnumseq As String

        Dim endStr As String = New String(BLANK, END_CHAR_ENREGISTREMENT)
        Try

       
            strReferenceCustomer = getCustomerreference(drReconduction)
            strcustomers_name = getCustomerName(drReconduction)
            strNumBankAccount = getNumBankAccount(drReconduction)
            strcustomers_address = getCustomeraddress(drReconduction)
            strcustomers_codepostal = getCustomerpostCode(drReconduction)

            _sumNumAccount = _sumNumAccount + Long.Parse(strNumBankAccount)

            strnumseq = formatLeft(numsequence, LEN_NUMSEQUENCE)
            strReferenceCustomer = formatLeft(strReferenceCustomer, LEN_DATA_REFERENCE, BLANK)
            strcustomers_name = formatLeft(strcustomers_name, LEN_CUSTNAME, BLANK)
            strNumBankAccount = formatLeft(strNumBankAccount, LEN_BANKACCOUNT)
            strNumDom = formatLeft(DATA_NUMDOM, LEN_NUMDOM)
            strcustomers_address = formatLeft(strcustomers_address, LEN_ADDRESS_CUST)
            strcustomers_codepostal = formatLeft(strcustomers_codepostal, LEN_CODEPOSTAL)


            strLine = IDENTIFICATION_ENREGISTREMENT + strnumseq + strReferenceCustomer + strNumBankAccount + strNumDom + DATA_CODE_NATURE_OPENED
            strLine = strLine + DATA_CODE_CREANCIER + strcustomers_name + strcustomers_address + strcustomers_codepostal
            strLine = strLine + endStr + vbLf

            Return strLine

        Catch ex As Exception
            clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Reconduction, ex)
            Return ""
        End Try

    End Function

    Public Function GenerateFile(ByVal dtReconduction As DataTable) As String
        Dim strMsg As String
        Dim cpt As Integer = 0
        strMsg = Header(0)

        For Each dr As DataRow In dtReconduction.Rows

            cpt = cpt + 1
            strMsg = strMsg + LineData(dr, cpt)
        Next

        strMsg = strMsg + Footer(cpt, _sumNumAccount)

        Return strMsg

    End Function

    Public Sub New(ByVal bic As String)
        _sumNumAccount = 0
        _financialInstitutId = bic
    End Sub
End Class
