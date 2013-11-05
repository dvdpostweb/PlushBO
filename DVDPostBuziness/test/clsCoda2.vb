Imports System.Collections.Generic

Public Class clsCoda2


    Private Interface ICoda
        Function isValid(ByVal line As String) As Boolean
        Sub fillData(ByVal line As String)

    End Interface

    Private Class dataStruct
        Public key As String
        Public typeLine As Type
        Public pos As Integer

        Public Sub New(ByVal dkey As String, ByVal dtypeline As Type, ByVal dpos As Integer)
            key = dkey
            typeLine = dtypeline
            pos = dpos
        End Sub
    End Class

    Private Class StructDb
        Public lst As List(Of dataStruct)
        Public lstHeader As List(Of dataStruct)
        Private Sub LoadData()

            Dim data As dataStruct
            lst = New List(Of dataStruct)

            data = New dataStruct("Debit", GetType(MouvementPart1), MouvementPart1.posField.SIGNEMOUVEMENT)
            lst.Add(data)

            data = New dataStruct("Amount", GetType(MouvementPart1), MouvementPart1.posField.MONTANT)
            lst.Add(data)

            data = New dataStruct("ValueDate", GetType(MouvementPart1), MouvementPart1.posField.DATEVALEUR)
            lst.Add(data)

            data = New dataStruct("OperationCode", GetType(MouvementPart1), MouvementPart1.posField.CODEOPERATION)
            lst.Add(data)

            data = New dataStruct("CommunicationTypeID", GetType(MouvementPart1), MouvementPart1.posField.TYPECOMMUNICATION)
            lst.Add(data)

            data = New dataStruct("Communication", GetType(MouvementPart1), MouvementPart1.posField.ZONECOMMUNICATION)
            lst.Add(data)

            data = New dataStruct("AccountingDate", GetType(MouvementPart1), MouvementPart1.posField.DATECOMPTA)
            lst.Add(data)

            data = New dataStruct("BankingExtractSequenceNumber", GetType(MouvementPart1), MouvementPart1.posField.NUMSEQEXTRAIT)
            lst.Add(data)

            data = New dataStruct("GlobalisationCode", GetType(MouvementPart1), MouvementPart1.posField.CODEGLOBAL)
            lst.Add(data)

            data = New dataStruct("ClientReference", GetType(MouvementPart2), MouvementPart2.posField.REFCLIENT)
            lst.Add(data)

            data = New dataStruct("CounterPartDetails", GetType(MouvementPart3), MouvementPart3.posField.NOMCONTREPARTIE)
            lst.Add(data)

        End Sub

        Private Sub LoadHeader()
            Dim data As dataStruct
            lstHeader = New List(Of dataStruct)

            data = New dataStruct("dvdpost_bank_account", GetType(AncienSolde), AncienSolde.posField.ACCOUNT)
            lstHeader.Add(data)
            'data = New dataStruct("TypeCoda", GetType(Header), Header.posField.CODEVERSION)
            'lstHeader.Add(data)


        End Sub
        Public Sub New()

            ' Structure DB Bank account movements  

            ' account_movements_id,
            ' coda_filename
            ' date_coda_created
            ' ReferenceNumberGivenByBank
            ' BankReferenceNumberExtension
            ' Debit *
            ' Amount *
            ' ValueDate *
            ' OperationCode * 
            ' CommunicationTypeID *
            ' Communication *
            ' AccountingDate *
            ' BankingExtractSequenceNumber *
            ' GlobalisationCode * 
            ' Communication2
            ' ClientReference
            ' InitialCurrency
            ' IntitialAmount
            ' BankAccountCounterpart
            ' InternalCodeCounterpart
            ' BankAccountCounterpartExtension
            ' CounterpartDetails
            ' CounterpartName
            ' CounterpartAddress
            ' CounterpartCity
            ' dvdpost_bank_account
            ' communication_type
            ' structuredComm12
            ' date_added
            ' ismatching
            ' last_modified
            ' user_modified



            'data = New dataStruct("x", mv1.GetType(), MouvementPart1.posField.ID)
            'lst.Add(data)

            'data = New dataStruct("x", mv1.GetType(), MouvementPart1.posField.CODEARTICLE)
            'lst.Add(data)

            'data = New dataStruct("x", mv1.GetType(), MouvementPart1.posField.NUMSEQ)
            'lst.Add(data)

            'data = New dataStruct("x", mv1.GetType(), MouvementPart1.posField.NUMDETAIL)
            'lst.Add(data)

            'data = New dataStruct("x", mv1.GetType(), MouvementPart1.posField.NUMREFBANK)
            'lst.Add(data)

            LoadHeader()
            LoadData()

        End Sub
    End Class
    Private Class Coda
        Implements ICoda

        Friend _struct As Integer()
        Friend _listData As List(Of String)
        Friend _lineBrut As String

        Friend Sub fillData(ByVal line As String) Implements ICoda.fillData
            Dim index As Integer
            Dim len As Integer
            Dim pos As Integer
            Dim val As String
            _listData = New List(Of String)
            _lineBrut = line
            For index = 0 To _struct.Length - 1

                pos = _struct(index)
                If index < _struct.Length - 1 Then
                    len = _struct(index + 1) - pos
                    val = line.Substring(pos - 1, len)

                Else
                    val = line.Substring(pos - 1)

                End If
                _listData.Add(val)
            Next

        End Sub

        Friend Function GetVal(ByVal index As Integer) As String
            If index <= _listData.Count Then
                Return _listData(index)
            Else
                Return String.Empty
            End If
        End Function

        Public Overridable Function isValid(ByVal line As String) As Boolean Implements ICoda.isValid
            Return False
        End Function


    End Class
    Private Class Header
        Inherits Coda

        Public Const TYPECODA As String = "1"
        Private Const IDENTIFICATION As String = "0"
        Enum posField
            ID = 0
            ZEROS
            DATECREATE
            IDBANK
            CODEAPPLICATION
            DUPLICATA
            BLANK
            REFERENCEFILE
            NOMDESTINATAIRE
            BICBANK
            IDTITULAIRE
            BLANK2
            CODEAPPLICATIONDISTINCT
            TRANSATIONREF
            RELATEDREF
            BLANK3
            CODEVERSION
        End Enum

        Public Overrides Function isValid(ByVal line As String) As Boolean
            Return line.StartsWith(IDENTIFICATION)
        End Function


        Public Sub New()
            _struct = New Integer() {1, 2, 6, 12, 15, 17, 18, 25, 35, 61, 72, 83, 84, 89, 105, 121, 128}
        End Sub


    End Class
    Private Class AncienSolde
        Inherits Coda

        Private Const IDENTIFICATION As String = "1"
        Enum posField
            ID = 0
            ACCOUNTTYPE
            NUMSEQ
            ACCOUNT
            SIGNESOLDE
            ANCIENSOLDE
            DATEANCIENSOLDE
            NOMTITULAIRE
            LIBELLECOMPTE
            NUMSEQEXTRAIT
        End Enum
        Public Overrides Function isValid(ByVal line As String) As Boolean
            Return line.StartsWith(IDENTIFICATION)
        End Function

        Public Sub New()
            _struct = New Integer() {1, 2, 3, 6, 43, 44, 59, 65, 91, 126}
        End Sub

    End Class
    Private Class MouvementPart1
        Inherits Coda
        Private IDENTIFICATION As String = "2"
        Private CODE_ARTICLE As String = "1"
        Enum posField
            ID = 0
            CODEARTICLE
            NUMSEQ
            NUMDETAIL
            NUMREFBANK
            SIGNEMOUVEMENT
            MONTANT ' amount 
            DATEVALEUR ' date value 
            CODEOPERATION
            TYPECOMMUNICATION
            ZONECOMMUNICATION ' communication
            DATECOMPTA
            NUMSEQEXTRAIT
            CODEGLOBAL
            CODESUITE
            BLANK
            CODEENREGNEXT

        End Enum

        Public Overrides Function isValid(ByVal line As String) As Boolean
            Return line.StartsWith(IDENTIFICATION & CODE_ARTICLE)
        End Function

        Public Sub New()
            _struct = New Integer() {1, 2, 3, 7, 11, 32, 33, 48, 54, 62, 63, 116, 122, 125, 126, 127, 128}
        End Sub

    End Class
    Private Class MouvementPart2
        Inherits Coda

        Private IDENTIFICATION As String = "2"
        Private CODE_ARTICLE As String = "2"

        Enum posField
            ID = 0
            CODEARTICLE
            NUMSEQ
            NUMDETAIL
            COMMUNICATION
            REFCLIENT
            BIC
            BLANK
            CATEGORYPURPOSE
            PURPOSE
            CODESUITE
            BLANK2
            CODEENREGNEXT

        End Enum

        Public Overrides Function isValid(ByVal line As String) As Boolean
            Return line.StartsWith(IDENTIFICATION & CODE_ARTICLE)
        End Function

        Public Sub New()
            _struct = New Integer() {1, 2, 3, 7, 11, 64, 99, 110, 118, 122, 126, 127, 128}
        End Sub

    End Class
    Private Class MouvementPart3
        Inherits Coda

        Private IDENTIFICATION As String = "2"
        Private CODE_ARTICLE As String = "3"

        Enum posField
            ID = 0
            CODEARTICLE
            NUMSEQ
            NUMDETAIL
            NUMCOMPTECONTREPARTIE
            NOMCONTREPARTIE
            ' COMMUNICATION
            CODESUITE

        End Enum

        Public Overrides Function isValid(ByVal line As String) As Boolean
            Return line.StartsWith(IDENTIFICATION & CODE_ARTICLE)
        End Function

        Public Sub New()
            '_struct = New Integer() {1, 2, 3, 7, 11, 48, 83, 126, 127, 128}
            _struct = New Integer() {1, 2, 3, 7, 11, 48, 126, 127, 128}
        End Sub
    End Class
    Private Class InfoPart1
        Inherits Coda

        Private IDENTIFICATION As String = "3"
        Private CODE_ARTICLE As String = "1"

        Enum posField
            ID = 0
            CODEARTICLE
            NUMSEQ
            NUMDETAIL
            NUMREF
            CODEOPERATION
            TYPECOMMUNICATION
            COMMUNICATION
            BLANK
            CODESUITE
            BLANK2
            CODEENREG


        End Enum
        Public Overrides Function isValid(ByVal line As String) As Boolean
            Return line.StartsWith(IDENTIFICATION & CODE_ARTICLE)
        End Function

        Public Sub New()
            _struct = New Integer() {1, 2, 3, 7, 11, 32, 40, 41, 114, 126, 127, 128}
        End Sub
    End Class
    Private Class InfoPart2
        Inherits Coda

        Private IDENTIFICATION As String = "3"
        Private CODE_ARTICLE As String = "2"


        Enum posField
            ID = 0
            CODEARTICLE
            NUMSEQ
            NUMDETAIL
            COMMUNICATION
            BLANK
            CODESUITE
            BLANK2
            CODEENREG
        End Enum

        Public Overrides Function isValid(ByVal line As String) As Boolean
            Return line.StartsWith(IDENTIFICATION & CODE_ARTICLE)
        End Function

        Public Sub New()
            _struct = New Integer() {1, 2, 3, 7, 11, 116, 126, 127, 128}
        End Sub

    End Class
    Private Class InfoPart3
        Inherits Coda

        Private IDENTIFICATION As String = "3"
        Private CODE_ARTICLE As String = "3"

        Enum posField
            ID = 0
            CODEARTICLE
            NUMSEQ
            NUMDETAIL
            COMMUNICATION
            BLANK
            CODESUITE
            BLANK2
            CODEENREG
        End Enum

        Public Overrides Function isValid(ByVal line As String) As Boolean
            Return line.StartsWith(IDENTIFICATION & CODE_ARTICLE)
        End Function

        Public Sub New()
            _struct = New Integer() {1, 2, 3, 7, 11, 101, 126, 127, 128}
        End Sub


    End Class
    Private Class NouveauSolde
        Inherits Coda

        Private IDENTIFICATION As String = "8"

        Enum posField
            ID = 0
            NUMSEQ
            NUMACCOUNT
            SIGNSOLDE
            SOLDE
            DATENOUVEAUSOLDE
            BLANK
            CODEENREG
        End Enum

        Public Overrides Function isValid(ByVal line As String) As Boolean
            Return line.StartsWith(IDENTIFICATION)
        End Function

        Public Sub New()
            _struct = New Integer() {1, 2, 5, 42, 43, 58, 64, 128}
        End Sub

    End Class
    Private Class MessageLibre
        Inherits Coda

        Const StartLineDom As String = "ref:"
        Const DATEPIVOT As String = "DATE PIVOT"
        Private Const IDENTIFICATION As String = "4"

        Enum posField
            ID = 0
            BLANK
            NUMSEQ
            NUMDETAIL
            BLANK2
            MSGLIBRE
            BLANK3
            CODEENREG
        End Enum

        Public Function getLine() As String
            Return GetVal(posField.MSGLIBRE)
        End Function
        Public Function IsStartOfDom() As Boolean
            return GetVal(posField.MSGLIBRE).Contains(StartLineDom) 
        End Function

        Public Function GetDatePivot() As String
            Dim lst As String()
            Dim strdate As String
            Dim d As DateTime
            If GetVal(posField.MSGLIBRE).Contains(datePivot) Then
                lst = GetVal(posField.MSGLIBRE).Split(New String() {datePivot}, StringSplitOptions.RemoveEmptyEntries)
                If lst.Length > 1 Then
                    strdate = lst(1).Trim().Substring(0, 10)
                    d = strdate
                    Return DVDPostTools.ClsDate.formatDate(d)
                End If

            End If
            Return (Nothing)
        End Function

        Public Overrides Function isValid(ByVal line As String) As Boolean
            Return line.StartsWith(IDENTIFICATION)
        End Function

        Public Sub New()
            _struct = New Integer() {1, 2, 3, 7, 11, 33, 113, 128}
        End Sub
    End Class
    Private Class Footer
        Inherits Coda

        Private Const IDENTIFICATION As String = "9"
        Enum posField
            ID = 0
            BLANK
            NBENREG
            CADEBIT
            CACREDIT
            BLANK2
            CODEFILEMULTIPLE
        End Enum

        Public Overrides Function isValid(ByVal line As String) As Boolean
            Return line.StartsWith(IDENTIFICATION)
        End Function


        Public Sub New()
            _struct = New Integer() {1, 2, 17, 23, 38, 53, 128}
        End Sub


    End Class
    Private Class Dom80Communication
        Inherits Coda

        Private Const IDENTIFICATION As String = "107"
        Enum posField
            TYPE = 0
            NUMDOM
            DATEPIVOT
            COMMUNICATION
            STATUS
        End Enum
        Public Overrides Function isValid(ByVal line As String) As Boolean
            Return line.StartsWith(IDENTIFICATION)
        End Function

        Public Sub New()
            _struct = New Integer() {1, 4, 16, 22, 52}
        End Sub


    End Class
    Private Class CommunicationStructure
        Inherits Coda

        Private Const IDENTIFICATION As String = "101"
        Enum posField
            TYPE = 0
            COMMUNICATION
        End Enum
        Public Overrides Function isValid(ByVal line As String) As Boolean
            Return line.StartsWith(IDENTIFICATION)
        End Function

        Public Sub New()
            _struct = New Integer() {1, 4}
        End Sub


    End Class
    Private Class CommunicationStructureReconstitue
        Inherits Coda

        Private Const IDENTIFICATION As String = "102"
        Enum posField
            TYPE = 0
            COMMUNICATION
        End Enum
        Public Overrides Function isValid(ByVal line As String) As Boolean
            Return line.StartsWith(IDENTIFICATION)
        End Function

        Public Sub New()
            _struct = New Integer() {1, 4}
        End Sub


    End Class
    Private Function isexistCoda(ByVal coda_name As String) As Boolean
        Dim sql As String
        Dim cpt As Integer
        sql = DvdPostData.ClsBatchDomiciliation.IsexistCoda(coda_name)
        cpt = DvdPostData.clsConnection.ExecuteScalar(sql)
        Return cpt > 0
    End Function

    Private Function GetInfoDB(ByVal lstDataCoda As List(Of Coda), _
                               ByVal filePath As String, _
                               ByRef strInsertKeyHeader As String, _
                               ByRef strinsertdataHeader As String _
                            ) As String
        Dim lst As String()
        Dim cls As StructDb = New StructDb()

        lst = filePath.Split("\")
        Dim name_coda As String = lst(lst.Length - 1)

        ' if name_coda exist deja return nothing 
        If isexistCoda(name_coda) Then Return Nothing

        Dim str As String = ""
        Dim data As String


        strInsertKeyHeader = "insert into bank_account_movements (coda_filename,date_coda_created,last_modified,user_modified,"
        strinsertdataHeader = "values('" & name_coda & "',now(),now()," & DvdPostData.clsSession.user_id & ","

        ' search info commun a tous 
        For Each item As dataStruct In cls.lstHeader
            data = searchData(item, lstDataCoda, 0, lstDataCoda.Count)

            '' si version coda incorrect
            'If item.key = "TypeCoda" Then
            '    If data <> Header.TYPECODA Then
            '        name_coda = Nothing
            '    End If
            'Else
            If data = String.Empty Then
                data = "null"
            Else
                data = "'" & data.Replace("'", "''") & "'"
            End If
            strInsertKeyHeader += item.key + ","
            strinsertdataHeader += data + ","
            ' End If
        Next
      
        Return name_coda


    End Function
    Private Function InsertDBVirement(ByVal lstDataCoda As List(Of Coda), _
                                      ByVal strInsertKeyHeader As String, _
                                      ByVal strinsertdataHeader As String, _
                                      ByVal index_EndVirement As Integer) As String

        Dim index_start As Integer = 0
        Dim index_stop As Integer = 0
        Dim strInsertKey As String
        Dim strinsertData As String
        Dim entireData As String = ""
        Dim data As String
        Dim cls As StructDb = New StructDb()
        Dim sql As String

        ' coda_name ,compteDvdPost,
        Dim lsttype_Stop As Type() = {GetType(MouvementPart1), GetType(MessageLibre)} ' permet de fixer le range d'index entre 2 objets de type mouvementparts1

        index_start = GetIndexNexTypeCoda(lstDataCoda, index_start, lsttype_Stop, entireData)

        While index_stop < index_EndVirement
            ' create insert 
            ' create values 
            strInsertKey = strInsertKeyHeader
            strinsertData = strinsertdataHeader

            index_stop = GetIndexNexTypeCoda(lstDataCoda, index_start, lsttype_Stop, entireData)

            For Each item As dataStruct In cls.lst

                Data = searchData(item, lstDataCoda, index_start, index_stop)
                If Data = String.Empty Then
                    Data = "null"
                Else
                    Data = "'" & Data.Replace("'", "''") & "'"
                End If
                strInsertKey += item.key + ","
                strinsertData += Data + ","
            Next
            strInsertKey += "EntireData"
            strinsertData += "'" & entireData.Replace("'", "''") & "'"
            ' strInsertKey = strInsertKey.Remove(strInsertKey.Length - 1, 1)
            ' strinsertData = strinsertData.Remove(strinsertData.Length - 1, 1)
            strInsertKey = strInsertKey + ")"
            strinsertData = strinsertData + ")"

            index_start = index_stop

            sql += strInsertKey + strinsertData + ";" + vbNewLine

        End While

        Return sql
    End Function
    Private Function CreateQuery(ByVal strInsertKeyHeader As String, _
                                 ByVal strinsertdataHeader As String, _
                                 ByVal date_pivot As String, _
                                 ByVal entireData As String) As String

        Dim strInsertKey As String
        Dim strinsertData As String

        strInsertKey = strInsertKeyHeader
        strinsertData = strinsertdataHeader
        strInsertKey += "EntireData,accountingdate"
        strinsertData += "'" & entireData.Replace("'", "''") & "','" & date_pivot & "'"
        strInsertKey = strInsertKey + ")"
        strinsertData = strinsertData + ")"
        Return strInsertKey + strinsertData + ";" + vbNewLine

    End Function
    Private Function InsertDBDomiciliation(ByVal lstDataCoda As List(Of Coda), _
                                      ByVal strInsertKeyHeader As String, _
                                      ByVal strinsertdataHeader As String, _
                                      ByVal index_EndVirement As Integer) As String
        'ByRef lst_DatePivot As String) As String

        Dim entireData As String = ""
        Dim index_start As Integer = 0

        Dim date_pivot As String = ""
        Dim obj_msgLibre As MessageLibre
        Dim containsDom As Boolean = False

        Dim sql As String = ""

        ' managed dom unpaid 
        entireData = ""
        'lst_DatePivot = ""
        index_start = index_EndVirement

        While index_start < lstDataCoda.Count

            If Not TypeOf (lstDataCoda(index_start)) Is MessageLibre Then
                Return sql
            End If
            obj_msgLibre = lstDataCoda(index_start)
            If obj_msgLibre.IsStartOfDom Then
                If containsDom Then
                    sql += CreateQuery(strInsertKeyHeader, strinsertdataHeader, date_pivot, entireData)
                End If
                entireData = ""
                containsDom = True
            End If

            Dim tmp As String
            tmp = obj_msgLibre.GetDatePivot()
            If tmp IsNot Nothing Then

                If date_pivot <> tmp And tmp <> "" Then
                    date_pivot = tmp
                    ' lst_DatePivot += "'" & date_pivot & "',"
                End If
            End If

            entireData += obj_msgLibre.getLine() & vbNewLine

            index_start += 1
        End While
        sql += CreateQuery(strInsertKeyHeader, strinsertdataHeader, date_pivot, entireData)

        'If lst_DatePivot.Length > 0 Then
        '    lst_DatePivot = lst_DatePivot.Remove(lst_DatePivot.Length - 1)
        'End If
        Return sql
    End Function
    ''' <summary>
    '''  save struct in db (bank_account_movements) 
    ''' create range between two objects of type movementpart1 
    ''' </summary>
    ''' <param name="lstDataCoda"></param>
    ''' <param name="filePath"></param>
    ''' <remarks></remarks>
    Private Function createItemDb(ByVal lstDataCoda As List(Of Coda), _
                                  ByVal filePath As String, _
                                  ByVal index_EndVirement As Integer) As String
        ' ByRef lst_DatePivot As String) As String

        Dim strInsertKeyHeader As String
        Dim strinsertdataHeader As String

        ' save bank account movement 
        Dim name_coda As String
        Dim sql As String = ""
        name_coda = GetInfoDB(lstDataCoda, filePath, strInsertKeyHeader, strinsertdataHeader)
        If name_coda IsNot Nothing Then
            sql += InsertDBVirement(lstDataCoda, strInsertKeyHeader, strinsertdataHeader, index_EndVirement)
            sql += InsertDBDomiciliation(lstDataCoda, strInsertKeyHeader, strinsertdataHeader, index_EndVirement)

            If sql <> "" Then
                DvdPostData.clsConnection.ExecuteNonQuery(sql)
            End If

        End If

        Return name_coda

    End Function
    ''' <summary>
    ''' get all object type of coda
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetLstTypeCoda() As List(Of Coda)
        Dim lstCodaType As List(Of Coda) = New List(Of Coda)

        lstCodaType.Add(New Header())
        lstCodaType.Add(New AncienSolde())
        lstCodaType.Add(New MouvementPart1())
        lstCodaType.Add(New MouvementPart2())
        lstCodaType.Add(New MouvementPart3())
        lstCodaType.Add(New InfoPart1)
        lstCodaType.Add(New InfoPart2)
        lstCodaType.Add(New InfoPart3)
        lstCodaType.Add(New NouveauSolde())
        lstCodaType.Add(New MessageLibre())
        lstCodaType.Add(New Footer())

        Return lstCodaType
    End Function

    ''' <summary>
    '''  load file in struct coda 
    ''' </summary>
    ''' <param name="lstCodaType"></param>
    ''' <param name="filePath"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LoadStruct(ByVal lstCodaType As List(Of Coda), ByVal filePath As String, ByRef index_EndVirement As Integer) As List(Of Coda)
        Dim lstDataCoda As List(Of Coda) = New List(Of Coda)
        Dim struct As List(Of String)

        struct = DVDPostTools.clsFile.openFile(filePath)
        Dim currentTypeStruct As Coda
        Dim currentTypeData As Coda
        Dim index As Integer
        Dim cpt_line As Integer
        Dim ok As Boolean

        cpt_line = 0
        index_EndVirement = 0
        For Each line As String In struct

            ok = False
            index = 0
            ' search the type coda % line current  
            While Not ok And index < lstCodaType.Count
                ok = lstCodaType(index).isValid(line)
                index += 1
            End While

            If ok Then

                currentTypeStruct = lstCodaType(index - 1)

                currentTypeData = getTypeCoda(currentTypeStruct)

                If TypeOf (currentTypeData) Is MessageLibre Then
                    If index_EndVirement = 0 Then
                        index_EndVirement = cpt_line
                    End If
                End If

                If Not currentTypeData Is Nothing Then
                    currentTypeData.fillData(line)
                    lstDataCoda.Add(currentTypeData)
                End If

            Else
                'MsgBox("error in file " & filePath & " " & line)
                lstDataCoda.Clear()
                Return lstDataCoda
            End If
            cpt_line += 1
        Next
        If index_EndVirement = 0 Then
            index_EndVirement = lstDataCoda.Count
        End If
        Return lstDataCoda
    End Function

    Private Sub updateDOMStructure(ByVal coda_filename As String)
        Dim lstDataCoda As List(Of Dom80Communication) = New List(Of Dom80Communication)
        Dim sql As String
        Dim dt As DataTable

        Dim strInsertmodel As String
        Dim strinsertdata As String
        Dim str As String = ""

        sql = DvdPostData.ClsBatchDomiciliation.GetBankAccountMovementWithCommunicationStructure(coda_filename)
        dt = DvdPostData.clsConnection.FillDataSet(sql)


        Dim ok As Boolean
        Dim comStruct As String

        Dim dom80 As Dom80Communication = New Dom80Communication()
        Dim communicationstruct As CommunicationStructure = New CommunicationStructure()
        Dim communicationstructRecon As CommunicationStructureReconstitue = New CommunicationStructureReconstitue()

        Dim Current As Coda
        Dim isstruct As Boolean

        strInsertmodel = "update bank_account_movements set "
        For Each dr As DataRow In dt.Rows
            ok = False
            comStruct = dr("communication")
            strinsertdata = strInsertmodel

            isstruct = False

            If dom80.isValid(comStruct) Then
                Current = New Dom80Communication()
                Current.fillData(comStruct)
                strinsertdata = strinsertdata + " communication_type = '" + Current.GetVal(Dom80Communication.posField.TYPE) + "',"
                strinsertdata = strinsertdata + " structuredcomm12 = '" + Current.GetVal(Dom80Communication.posField.COMMUNICATION) + "',"
                strinsertdata = strinsertdata + " communication2 = '" + Current.GetVal(Dom80Communication.posField.NUMDOM) + "',"

                isstruct = True

            ElseIf communicationstruct.isValid(comStruct) Then
                Current = New CommunicationStructure()
                Current.fillData(comStruct)
                strinsertdata = strinsertdata + " communication_type = '" + Current.GetVal(CommunicationStructure.posField.TYPE) + "',"
                strinsertdata = strinsertdata + " structuredcomm12 = '" + Current.GetVal(CommunicationStructureReconstitue.posField.COMMUNICATION) + "',"
                isstruct = True

            ElseIf communicationstructRecon.isValid(comStruct) Then
                Current = New CommunicationStructureReconstitue()
                Current.fillData(comStruct)
                strinsertdata = strinsertdata + " communication_type = '" + Current.GetVal(CommunicationStructure.posField.TYPE) + "',"
                strinsertdata = strinsertdata + " structuredcomm12 = '" + Current.GetVal(CommunicationStructureReconstitue.posField.COMMUNICATION) + "',"
                isstruct = True
            End If

            If isstruct Then
                strinsertdata = strinsertdata + " last_modified = now(),"
                strinsertdata = strinsertdata + " user_modified = " & DvdPostData.clsSession.user_id
                strinsertdata = strinsertdata + " where account_movements_id = " & dr("account_movements_id")

                strinsertdata = strinsertdata + ";"
                str = str + strinsertdata + vbNewLine
            End If


        Next
        If str <> "" Then
            DvdPostData.clsConnection.ExecuteNonQuery(str)
        End If

    End Sub

    Private Sub updateamount(ByVal coda_filename As String)
        Dim sql As String

        sql = DvdPostData.ClsBatchDomiciliation.GetBankAccountMovementAmount(coda_filename)
        DvdPostData.clsConnection.ExecuteNonQuery(sql)
    End Sub

    Private Sub updateDomUnpaid(ByVal coda_filename As String) ', ByVal lst_datePivot As String)

        Dim sql As String
        Dim unpaid_inexistant As Integer
        Dim unpaid_insolvent As Integer
        Dim paid As Integer
        ' If lst_datePivot Is Nothing OrElse lst_datePivot.Length = 0 Then Return
        DvdPostData.clsConnection.CreateTransaction(False)
        Try

            sql = DvdPostData.ClsBatchDomiciliation.getFlagUnpaidDomInexist(coda_filename)
            unpaid_inexistant = DvdPostData.clsConnection.ExecuteNonQuery(sql)

            sql = DvdPostData.ClsBatchDomiciliation.getFlagUnpaidInsolvent(coda_filename)
            unpaid_insolvent = DvdPostData.clsConnection.ExecuteNonQuery(sql)

            sql = DvdPostData.ClsBatchDomiciliation.getInsertPaymentOfflineRequest(coda_filename, clsCompta.DVDPOST_BANK_ACCOUNT_ING)
            DvdPostData.clsConnection.ExecuteNonQuery(sql)

            sql = DvdPostData.ClsBatchDomiciliation.getFlagPaidDom()
            paid = DvdPostData.clsConnection.ExecuteNonQuery(sql)

            sql = DvdPostData.ClsBatchDomiciliation.getChangeStatusUnpaidDomInexist()
            DvdPostData.clsConnection.ExecuteNonQuery(sql)

            sql = DvdPostData.ClsBatchDomiciliation.getChangeStatusUnpaidInsolvent()
            DvdPostData.clsConnection.ExecuteNonQuery(sql)

            If unpaid_inexistant + unpaid_insolvent > 0 Then
                MsgBox("Domiciliation : " & coda_filename & vbNewLine & _
                " Paid : " & paid & vbNewLine & _
                " Unpaid inexistant : " & unpaid_inexistant & vbNewLine & _
                " Unpaid insolvent : " & unpaid_insolvent)
            End If

            DvdPostData.clsConnection.CommitTransaction(True)
        Catch ex As Exception
            DvdPostData.clsConnection.CommitTransaction(False)
            clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Import_Payment, ex)
        End Try


    End Sub

    Public Function AnalyseFile(ByVal filePath As String) As Boolean

        Dim lstDataCoda As List(Of Coda)
        Dim lstCodaType As List(Of Coda)
        Dim name_coda As String
        Dim index_EndVirement As Integer
        'Dim lst_datepivot As String

        lstCodaType = GetLstTypeCoda()
        lstDataCoda = LoadStruct(lstCodaType, filePath, index_EndVirement)
        name_coda = createItemDb(lstDataCoda, filePath, index_EndVirement)
        If Not name_coda Is Nothing Then
            updateDOMStructure(name_coda)
            updateamount(name_coda)
            updateDomUnpaid(name_coda)
            clsOffLinePayments.matchingOffline()
            Return True
        End If

        Return False


    End Function

    Private Function isTypeCoda(ByVal t As Type, ByVal cls As Coda) As Boolean

        If t Is cls.GetType() Then
            Return True
        End If

        Return False


    End Function

    Private Function isTypeCoda(ByVal lst_t As Type(), ByVal cls As Coda) As Boolean


        For Each t As Type In lst_t
            If t Is cls.GetType() Then
                Return True
            End If
        Next


        Return False


    End Function
    Private Function getTypeCoda(ByVal t As Coda) As Coda

        If TypeOf (t) Is Header Then
            Return New Header
        End If

        If TypeOf (t) Is AncienSolde Then
            Return New AncienSolde
        End If

        If TypeOf (t) Is MouvementPart1 Then
            Return New MouvementPart1
        End If

        If TypeOf (t) Is MouvementPart2 Then
            Return New MouvementPart2
        End If

        If TypeOf (t) Is MouvementPart3 Then
            Return New MouvementPart3
        End If

        If TypeOf (t) Is InfoPart1 Then
            Return New InfoPart1
        End If

        If TypeOf (t) Is InfoPart2 Then
            Return New InfoPart2
        End If

        If TypeOf (t) Is InfoPart3 Then
            Return New InfoPart3
        End If

        If TypeOf (t) Is NouveauSolde Then
            Return New NouveauSolde
        End If

        If TypeOf (t) Is MessageLibre Then
            Return New MessageLibre
        End If

        Return Nothing


    End Function


    Private Function GetIndexNexTypeCoda(ByVal lst As List(Of Coda), ByVal index_start As Integer, ByVal lst_tEnd As Type(), ByRef Line As String) As Integer
        Line = ""
        If index_start >= lst.Count Then
            Return lst.Count
        Else
            Line += lst(index_start)._lineBrut & vbNewLine
            index_start += 1
            While index_start < lst.Count

                If isTypeCoda(lst_tEnd, lst(index_start)) Then
                    Return index_start
                Else
                    Line += lst(index_start)._lineBrut + vbNewLine
                    index_start += 1
                End If
            End While

            Return lst.Count
        End If
    End Function
    Private Function searchData(ByVal current As dataStruct, ByVal lst As List(Of Coda), ByVal index_start As Integer, ByVal index_stop As Integer) As String

        Dim index As Integer
        index = index_start
        If (lst.Count < index_start) Then
            Return String.Empty
        Else
            While index < index_stop
                If isTypeCoda(current.typeLine, lst(index)) Then
                    Return lst(index).GetVal(current.pos)
                Else
                    index += 1
                End If
            End While
            Return String.Empty
        End If

    End Function


End Class
